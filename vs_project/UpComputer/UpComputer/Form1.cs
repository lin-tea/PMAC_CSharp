using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using PCOMMSERVERLib;   // PMAC 调用库
namespace UpComputer
{
    public partial class Form1 : Form
    {
        public static PmacDeviceClass PMAC;    // PMAC卡
        public bool selectPmacSuccess = false; // 选择状态
        public bool openPmacSuccess = false;   // 打开状态
        public int pmacNumber;                 // PMAC卡number
        public string filename;
        public double xPrePos,yPrePos,prePos;         //x、y前时间段的位置 用于计算速度
        private int xMotorNum,yMotorNum;              //
        public Form1()                          //GUI初始化函数
        {
            InitializeComponent();              // 生成界面、各种控件
            this.timerCurrentDateTime.Start();  //定时器，1s，更新显示时间
            this.timerCurrentPosAndSpeedInfo.Start(); // 位置
            PMAC = new PmacDeviceClass();       //生成PMAC控制卡对象
            // 设置初始的X、Y电机号
            xMotorNum = 1;
            yMotorNum = 2;
        }
// *******************PMac 基本控制、接口********************//
// **********************************************************//
// *********************************************************//
        private void StepUp(int motorNum,out string response)   //电机正向点动
        {   /*
             motorNum: 电机号 
                PLC: 代码 #1j+
             */
            string question = "#" + motorNum.ToString() + "j+";
            PMAC.GetResponse(pmacNumber, question, out response);
        }
        private void StepDown(int motorNum, out string response) //电机反向点动
        {
            string question = "#" + motorNum.ToString() + "j-";
            PMAC.GetResponse(pmacNumber, question, out response);
        }
        private void motorStop(int motorNum,out string response) //电机停止
        {   
            string question = "#" + motorNum.ToString() + "j/";
            PMAC.GetResponse(pmacNumber, question, out response);
        }
        private void MoveToPos(int motorNum,double pos) //电机移动到pos位置
        {   // pos 脉冲数
            string question = "#" + motorNum.ToString() + "j=" + pos.ToString();
            PMAC.GetResponse(pmacNumber, question, out string res);
        }
        private void MoveStep(int motorNum, string step, out string response)  //在当前位置移动step脉冲
        {
            string question = "#" + motorNum.ToString() + "j^" + step;
            PMAC.GetResponse(pmacNumber, question, out response);
        }
        private void SetSpeed(string motorNum,string speed) //电机速度
        {
            // speed: 单位cts/ms
            double s = Convert.ToDouble(speed);
            if (s > 15) s = 15;
            else if (s<0) return;
            speed = s.ToString();
            string commond = "I"+motorNum+"22="+speed;
            PMAC.GetResponse(pmacNumber, commond, out string res);
        }
        private void readVar(string var,out int pmacStatus,out string pmacResponse )  //读取PMac卡代号为var变量当前的值、状态
        {
            PMAC.GetResponseEx(pmacNumber,var,bAddLF:true,out pmacResponse,out pmacStatus);
        }
        private bool downloadFiletoPMac(string filepath) //下载程序文件到PMAC
        { 
            // 如果文件路径有
            if (filepath == null) return false;
            //下载文件到PMAC中
            PMAC.Download(pmacNumber, filepath, bMacro: false, bMap: false, 
                bLog: true, bDnld: true, out bool flag);
            //返回下载的结果成功或者失败
            return flag; 
        }

// **********************各种事件触发***********************//
// ********************* ************ **********************//
// *********************************************************//
        //######## PMAC连接、断开 #########
        private void selectDevice_Click(object sender, EventArgs e)  //选择、连接PMAC
        {

            PMAC.SelectDevice(0, out pmacNumber, out selectPmacSuccess);
            if (selectPmacSuccess)    //检验Pmac是否能选择
            {
                PMAC.Open(pmacNumber, out openPmacSuccess);
                if (openPmacSuccess)   //PMac是否成功打开
                {
                    this.selectStatus.ResetText();
                    this.selectStatus.AppendText("通信中!");
                    this.selectStatus.Show();
                    MessageBox.Show($"Successful to Open PMac {pmacNumber} card!");
                }
                else
                {
                    MessageBox.Show("File to Open PMAC card!");
                }
            }
        }
        private void deSelectDevice_Click(object sender, EventArgs e) //关闭连接，断开PMAC卡
        {
            if (this.openPmacSuccess == true)
            {
                PMAC.GetResponse(pmacNumber, "k", out string res); //kill all运行
                PMAC.Close(0);  //关闭连接
                openPmacSuccess = false;
                PMAC.Abort(0);
                selectPmacSuccess = false;
                this.selectStatus.ResetText();
                this.selectStatus.AppendText("已断开!");
            }
        }
        //######### 菜单栏信息 #############
        private void 开发信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("nStart Date:2022/4,Shantou GuangDon\n" +
                "Email:xxx@xxx","上位机程序 开发信息");
        }
        private void 软件版本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.4","上位机程序 版本");
        }
        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("这是用于与PMAC运动控制卡进行连接的上位机软件。\n" +
                "(只使用电机1、电机2控制X、Y轴运动)\n如果不能进行连接，可能是权限问题，要用管理员权限运行该软件。");
        }
        //######### 电机点动控制 ##########
        private void dotUp_MouseDown(object sender, MouseEventArgs e)  //按下，电机2正转
        {
           yMotorNum = Convert.ToInt32(this.yMotor.Text);
            string response = null;
            if (this.stepOne.Checked)
            {
                string step = this.dotStep.Text;
                MoveStep(yMotorNum, step,out response);
            }
            else 
            {
                StepUp(yMotorNum, out response); 
            }
            if (response != "")
            {
                MessageBox.Show(response);
            }
        }
        private void dotUp_MouseUp(object sender, MouseEventArgs e)   //松开，电机2停止
        {
            string response=null;
            if(!this.stepOne.Checked) motorStop(yMotorNum, out response);
        }
        private void dotDown_MouseDown(object sender, MouseEventArgs e)  //按下，电机2反转
        {
            yMotorNum = Convert.ToInt32(this.yMotor.Text);
            string response = null;
            if (this.stepOne.Checked)
            {
                string step = "-" + this.dotStep.Text;
                MoveStep(yMotorNum, step, out response);
            }
            else
            {
                StepDown(yMotorNum, out response);
            }
            if (response != "")
            {
                MessageBox.Show(response);
            }
        }
        private void dotDown_MouseUp(object sender, MouseEventArgs e)    //松开，电机2停止
        {
            if(!this.stepOne.Checked) motorStop(yMotorNum, out string response);
        }
        private void dotLeft_MouseDown(object sender, MouseEventArgs e)  //按下，电机1正转
        {
            xMotorNum = Convert.ToInt32(this.xMotor.Text);
            string response = null;
            if (this.stepOne.Checked)
            {
                string step = this.dotStep.Text;
                MoveStep(xMotorNum, step, out response);
            }
            else
            {
                StepUp(xMotorNum, out response);
            }
            if (response != "")
            {
                MessageBox.Show(response);
            }
        }
        private void dotLeft_MouseUp(object sender, MouseEventArgs e)    //松开，电机1停止
        {
            string response;
            if(!this.stepOne.Checked) motorStop(xMotorNum, out response);
        }
        private void dotRight_MouseDown(object sender, MouseEventArgs e) //按下，电机1反转
        {
            xMotorNum = Convert.ToInt32(this.xMotor.Text);
            string response = null;
            if (this.stepOne.Checked)
            {
                string step = "-"+this.dotStep.Text;
                MoveStep(xMotorNum, step, out response);
            }
            else
            {
                StepDown(xMotorNum, out response);
            }
            if (response != "")
            {
                MessageBox.Show(response);
            }
        }
        private void dotRight_MouseUp(object sender, MouseEventArgs e)   //松开，电机1停止
        {
            string response;
            if(!this.stepOne.Checked) motorStop(xMotorNum, out response);
        }
        private void jogHere_Click(object sender, EventArgs e)  //jog到pos
        {
            if (openPmacSuccess)
            {
                int motor = Convert.ToInt32(this.motorCombo.Text);
                MoveToPos(motor, Convert.ToDouble(this.jogHerePos.Text));
            }
        }
        /// <summary>
        /// 读取文件按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        // ########## 读取文件 ###########
        private void openPLCFile_Click(object sender, EventArgs e)  //打开程序文件
        {
            this.openPLCFileDialog.Filter = "ACLII文件(*.txt,*.pmc)|*.txt;*.pmc";
            DialogResult dr = this.openPLCFileDialog.ShowDialog();
            this.filename = this.openPLCFileDialog.FileName;
            if (dr == DialogResult.OK)
            {
                this.filePLCPath.Text = filename;
            }
        }
        // ########## 下载文件 ###########
        /// <summary>
        /// 下载文件到PMAC按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plcFileUpload_Click(object sender, EventArgs e) 
        {
            bool flag = false;
            if (this.filename != "")
            {
                flag = downloadFiletoPMac(this.filename);
            }
            if (flag == false)
            {
                MessageBox.Show("Fail to download " + filename);
            }
            else
            {
                MessageBox.Show("Download Success!");
            }
        }
        /// <summary>
        /// form2读取文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void readFile_Click(object sender, EventArgs e) 
        {
            Form2 frm = new Form2();
            frm.readfile(filename);
            frm.ShowDialog();
        }
        /// <summary>
        /// 电机置零
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void homeZMotor_Click(object sender, EventArgs e)  //home
        {
            if(openPmacSuccess) PMAC.GetResponse(pmacNumber,"#"+ motorCombo.Text+"HOMEZ",out string res);
        }
        /// <summary>
        /// 发送命令
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendCommand_Click(object sender, EventArgs e) 
        {
            // if  open PMAC successful
            if (openPmacSuccess) { 
                if(this.commandText.Text != "")
                {
                    string response = null;
                    PMAC.GetResponseEx(pmacNumber, this.commandText.Text,true,out response,out int pstatus);
                    if (response != "")
                    {
                        MessageBox.Show(response);
                    }
                    else
                    {
                        MessageBox.Show("发送成功！");
                    }
                }
            }
        }
        /// <summary>
        /// 设置电机速度按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setSpeedBTN_Click(object sender, EventArgs e)
        {
            if (openPmacSuccess)
            {
                if (this.speed.Text != "")
                {
                    SetSpeed(this.xMotorNum.ToString(), this.speed.Text);
                    SetSpeed(this.yMotorNum.ToString(), this.speed.Text);
                }
                if (Convert.ToDouble(this.speed.Text) > 15)
                {
                    MessageBox.Show("速度大于15时，自动设置为15cts/ms");
                }
            }
        }
        /// <summary>
        /// Kill All
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stopMove_Click(object sender, EventArgs e)  //Kill all
        {
            if (openPmacSuccess)
            { 
                PMAC.GetResponse(pmacNumber, "k", out string res); 
                motorStop(xMotorNum,out res);
                motorStop(yMotorNum,out res);
                motorStop(Convert.ToInt32(motorCombo.Text), out res);
            }
        }
        // ######### 各种定时任务 #########
        /// <summary>
        /// 更新日期时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCurrentDateTime_Tick(object sender, EventArgs e) //1秒更新一次日期、时间
        {
            this.dateCurrent.Text = DateTime.Now.ToString("d");
            this.timeCurrent.Text = DateTime.Now.ToString("t");
            this.timerCurrentDateTime.Interval = 1000;
            this.timerCurrentDateTime.Start();
        }
        /// <summary>
        /// 更新位置、速度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCurrentPosAndSpeedInfo_Tick(object sender, EventArgs e) //定时器，读取位置、速度
        {
  
            this.chooseMotorLabel.Text = "电机" + motorCombo.Text + "位置";
            if (openPmacSuccess) //如果与PMAC卡通讯连接成功
            {
                string motor1P,motor2P,motorP;   // 保存各电机位置

                string question = "#"+xMotorNum.ToString()+"P";  //X轴电机位置命令
                PMAC.GetResponse(pmacNumber,question,out motor1P);
                question = "#" + yMotorNum.ToString() + "P";     //Y轴电机位置命令
                PMAC.GetResponse(pmacNumber, question, out motor2P);
                question = "#" + motorCombo.Text + "P";          //所选电机位置命令
                PMAC.GetResponse(pmacNumber, question, out motorP);
                // 位置显示
                this.xPosition.Text = motor1P;
                this.yPosition.Text = motor2P;
                this.chooseMotorPos.Text = motorP;
                // 速度计算、显示
                this.xCurrentSpeed.Text = Convert.ToString((Convert.ToDouble(motor1P) - xPrePos)/500);
                this.yCurrentSpeed.Text = Convert.ToString((Convert.ToDouble(motor2P) - yPrePos)/500);
                this.chooseMotorV.Text = Convert.ToString((Convert.ToDouble(motorP) - prePos) / 500);
                // 保存当前位置
                xPrePos = Convert.ToDouble(motor1P);
                yPrePos = Convert.ToDouble(motor2P);
                prePos = Convert.ToDouble(motorP);
            }
            // 开启定时器
            this.timerCurrentPosAndSpeedInfo.Interval = 500;
            this.timerCurrentPosAndSpeedInfo.Start();
        }
    }
}
