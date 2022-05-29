namespace UpComputer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dotUp = new System.Windows.Forms.Button();
            this.dotDown = new System.Windows.Forms.Button();
            this.selectDevice = new System.Windows.Forms.Button();
            this.dotLeft = new System.Windows.Forms.Button();
            this.dotRight = new System.Windows.Forms.Button();
            this.xPosition = new System.Windows.Forms.TextBox();
            this.yPosition = new System.Windows.Forms.TextBox();
            this.xPosLabel = new System.Windows.Forms.Label();
            this.yPosLabel = new System.Windows.Forms.Label();
            this.selectStatus = new System.Windows.Forms.TextBox();
            this.statuLabel = new System.Windows.Forms.Label();
            this.currentPos = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chooseMotorV = new System.Windows.Forms.TextBox();
            this.speedChooseMotorLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chooseMotorPos = new System.Windows.Forms.TextBox();
            this.chooseMotorLabel = new System.Windows.Forms.Label();
            this.xUnitLabel = new System.Windows.Forms.Label();
            this.yUnitLabel = new System.Windows.Forms.Label();
            this.yUnitSpeedLabel = new System.Windows.Forms.Label();
            this.xUnitSpeedLabel = new System.Windows.Forms.Label();
            this.yCurrentSpeed = new System.Windows.Forms.TextBox();
            this.xCurrentSpeed = new System.Windows.Forms.TextBox();
            this.ySpeedLabel = new System.Windows.Forms.Label();
            this.xSpeedLabel = new System.Windows.Forms.Label();
            this.dotMotion = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.setSpeedBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.TextBox();
            this.speedLabel = new System.Windows.Forms.Label();
            this.homeZMotor = new System.Windows.Forms.Button();
            this.yMotor = new System.Windows.Forms.ComboBox();
            this.xMotor = new System.Windows.Forms.ComboBox();
            this.yMotorLabel = new System.Windows.Forms.Label();
            this.xMotorLabel = new System.Windows.Forms.Label();
            this.motorCombo = new System.Windows.Forms.ComboBox();
            this.ctLabel = new System.Windows.Forms.Label();
            this.motorLabel = new System.Windows.Forms.Label();
            this.jogHere = new System.Windows.Forms.Button();
            this.jogHerePos = new System.Windows.Forms.TextBox();
            this.stepOne = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stopMove = new System.Windows.Forms.Button();
            this.dotStepLabel = new System.Windows.Forms.Label();
            this.dotStep = new System.Windows.Forms.TextBox();
            this.communicationGroup = new System.Windows.Forms.GroupBox();
            this.deSelectDevice = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.plcFileGroup = new System.Windows.Forms.GroupBox();
            this.commandText = new System.Windows.Forms.TextBox();
            this.sendCommandLabel = new System.Windows.Forms.Label();
            this.readFile = new System.Windows.Forms.Button();
            this.plcFileUpload = new System.Windows.Forms.Button();
            this.filePLCPath = new System.Windows.Forms.TextBox();
            this.openPLCFile = new System.Windows.Forms.Button();
            this.programFileLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于我们ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.软件版本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开发信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateCurrent = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeCurrent = new System.Windows.Forms.TextBox();
            this.openPLCFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.timerCurrentDateTime = new System.Windows.Forms.Timer(this.components);
            this.timerCurrentPosAndSpeedInfo = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.send_command = new System.Windows.Forms.Button();
            this.currentPos.SuspendLayout();
            this.dotMotion.SuspendLayout();
            this.communicationGroup.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.plcFileGroup.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dotUp
            // 
            this.dotUp.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dotUp.Location = new System.Drawing.Point(106, 143);
            this.dotUp.Margin = new System.Windows.Forms.Padding(2);
            this.dotUp.Name = "dotUp";
            this.dotUp.Size = new System.Drawing.Size(42, 23);
            this.dotUp.TabIndex = 1;
            this.dotUp.Text = "Y+";
            this.dotUp.UseVisualStyleBackColor = true;
            this.dotUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dotUp_MouseDown);
            this.dotUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dotUp_MouseUp);
            // 
            // dotDown
            // 
            this.dotDown.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dotDown.Location = new System.Drawing.Point(106, 170);
            this.dotDown.Margin = new System.Windows.Forms.Padding(2);
            this.dotDown.Name = "dotDown";
            this.dotDown.Size = new System.Drawing.Size(42, 22);
            this.dotDown.TabIndex = 2;
            this.dotDown.Text = "Y-";
            this.dotDown.UseVisualStyleBackColor = true;
            this.dotDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dotDown_MouseDown);
            this.dotDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dotDown_MouseUp);
            // 
            // selectDevice
            // 
            this.selectDevice.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectDevice.Location = new System.Drawing.Point(162, 26);
            this.selectDevice.Margin = new System.Windows.Forms.Padding(2);
            this.selectDevice.Name = "selectDevice";
            this.selectDevice.Size = new System.Drawing.Size(71, 34);
            this.selectDevice.TabIndex = 0;
            this.selectDevice.Text = "通讯";
            this.selectDevice.UseVisualStyleBackColor = true;
            this.selectDevice.Click += new System.EventHandler(this.selectDevice_Click);
            // 
            // dotLeft
            // 
            this.dotLeft.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dotLeft.Location = new System.Drawing.Point(151, 157);
            this.dotLeft.Margin = new System.Windows.Forms.Padding(2);
            this.dotLeft.Name = "dotLeft";
            this.dotLeft.Size = new System.Drawing.Size(44, 24);
            this.dotLeft.TabIndex = 3;
            this.dotLeft.Text = "X+";
            this.dotLeft.UseVisualStyleBackColor = true;
            this.dotLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dotLeft_MouseDown);
            this.dotLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dotLeft_MouseUp);
            // 
            // dotRight
            // 
            this.dotRight.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dotRight.Location = new System.Drawing.Point(63, 157);
            this.dotRight.Margin = new System.Windows.Forms.Padding(2);
            this.dotRight.Name = "dotRight";
            this.dotRight.Size = new System.Drawing.Size(42, 24);
            this.dotRight.TabIndex = 4;
            this.dotRight.Text = "X-";
            this.dotRight.UseVisualStyleBackColor = true;
            this.dotRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dotRight_MouseDown);
            this.dotRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dotRight_MouseUp);
            // 
            // xPosition
            // 
            this.xPosition.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xPosition.Location = new System.Drawing.Point(62, 31);
            this.xPosition.Margin = new System.Windows.Forms.Padding(2);
            this.xPosition.Name = "xPosition";
            this.xPosition.ReadOnly = true;
            this.xPosition.Size = new System.Drawing.Size(87, 26);
            this.xPosition.TabIndex = 6;
            this.xPosition.Text = "0.0";
            this.xPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yPosition
            // 
            this.yPosition.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yPosition.Location = new System.Drawing.Point(62, 63);
            this.yPosition.Margin = new System.Windows.Forms.Padding(2);
            this.yPosition.Name = "yPosition";
            this.yPosition.ReadOnly = true;
            this.yPosition.Size = new System.Drawing.Size(88, 26);
            this.yPosition.TabIndex = 7;
            this.yPosition.Text = "0.0";
            this.yPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xPosLabel
            // 
            this.xPosLabel.AutoSize = true;
            this.xPosLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xPosLabel.Location = new System.Drawing.Point(10, 33);
            this.xPosLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.xPosLabel.Name = "xPosLabel";
            this.xPosLabel.Size = new System.Drawing.Size(55, 16);
            this.xPosLabel.TabIndex = 8;
            this.xPosLabel.Text = "X坐标:";
            // 
            // yPosLabel
            // 
            this.yPosLabel.AutoSize = true;
            this.yPosLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yPosLabel.Location = new System.Drawing.Point(10, 65);
            this.yPosLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yPosLabel.Name = "yPosLabel";
            this.yPosLabel.Size = new System.Drawing.Size(55, 16);
            this.yPosLabel.TabIndex = 9;
            this.yPosLabel.Text = "Y坐标:";
            // 
            // selectStatus
            // 
            this.selectStatus.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectStatus.Location = new System.Drawing.Point(74, 29);
            this.selectStatus.Margin = new System.Windows.Forms.Padding(2);
            this.selectStatus.Name = "selectStatus";
            this.selectStatus.ReadOnly = true;
            this.selectStatus.Size = new System.Drawing.Size(57, 21);
            this.selectStatus.TabIndex = 11;
            this.selectStatus.Text = "未连接";
            this.selectStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statuLabel
            // 
            this.statuLabel.AutoSize = true;
            this.statuLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statuLabel.Location = new System.Drawing.Point(11, 30);
            this.statuLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statuLabel.Name = "statuLabel";
            this.statuLabel.Size = new System.Drawing.Size(59, 12);
            this.statuLabel.TabIndex = 12;
            this.statuLabel.Text = "通讯状态:";
            // 
            // currentPos
            // 
            this.currentPos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentPos.AutoSize = true;
            this.currentPos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.currentPos.Controls.Add(this.label4);
            this.currentPos.Controls.Add(this.chooseMotorV);
            this.currentPos.Controls.Add(this.speedChooseMotorLabel);
            this.currentPos.Controls.Add(this.label3);
            this.currentPos.Controls.Add(this.chooseMotorPos);
            this.currentPos.Controls.Add(this.chooseMotorLabel);
            this.currentPos.Controls.Add(this.xUnitLabel);
            this.currentPos.Controls.Add(this.yUnitLabel);
            this.currentPos.Controls.Add(this.yUnitSpeedLabel);
            this.currentPos.Controls.Add(this.xUnitSpeedLabel);
            this.currentPos.Controls.Add(this.yCurrentSpeed);
            this.currentPos.Controls.Add(this.xCurrentSpeed);
            this.currentPos.Controls.Add(this.ySpeedLabel);
            this.currentPos.Controls.Add(this.xSpeedLabel);
            this.currentPos.Controls.Add(this.xPosition);
            this.currentPos.Controls.Add(this.xPosLabel);
            this.currentPos.Controls.Add(this.yPosition);
            this.currentPos.Controls.Add(this.yPosLabel);
            this.currentPos.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.currentPos.Location = new System.Drawing.Point(263, 2);
            this.currentPos.Margin = new System.Windows.Forms.Padding(2);
            this.currentPos.Name = "currentPos";
            this.currentPos.Padding = new System.Windows.Forms.Padding(2);
            this.currentPos.Size = new System.Drawing.Size(462, 149);
            this.currentPos.TabIndex = 15;
            this.currentPos.TabStop = false;
            this.currentPos.Text = "当前位置信息";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(334, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 31;
            this.label4.Text = "ct/ms";
            // 
            // chooseMotorV
            // 
            this.chooseMotorV.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chooseMotorV.Location = new System.Drawing.Point(246, 98);
            this.chooseMotorV.Margin = new System.Windows.Forms.Padding(2);
            this.chooseMotorV.Name = "chooseMotorV";
            this.chooseMotorV.ReadOnly = true;
            this.chooseMotorV.Size = new System.Drawing.Size(87, 26);
            this.chooseMotorV.TabIndex = 30;
            this.chooseMotorV.Text = "0.0";
            this.chooseMotorV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // speedChooseMotorLabel
            // 
            this.speedChooseMotorLabel.AutoSize = true;
            this.speedChooseMotorLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.speedChooseMotorLabel.Location = new System.Drawing.Point(200, 99);
            this.speedChooseMotorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speedChooseMotorLabel.Name = "speedChooseMotorLabel";
            this.speedChooseMotorLabel.Size = new System.Drawing.Size(47, 16);
            this.speedChooseMotorLabel.TabIndex = 29;
            this.speedChooseMotorLabel.Text = "速度:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(180, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 28;
            this.label3.Text = "ct";
            // 
            // chooseMotorPos
            // 
            this.chooseMotorPos.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chooseMotorPos.Location = new System.Drawing.Point(94, 98);
            this.chooseMotorPos.Margin = new System.Windows.Forms.Padding(2);
            this.chooseMotorPos.Name = "chooseMotorPos";
            this.chooseMotorPos.ReadOnly = true;
            this.chooseMotorPos.Size = new System.Drawing.Size(88, 26);
            this.chooseMotorPos.TabIndex = 27;
            this.chooseMotorPos.Text = "0.0";
            this.chooseMotorPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chooseMotorLabel
            // 
            this.chooseMotorLabel.AutoSize = true;
            this.chooseMotorLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chooseMotorLabel.Location = new System.Drawing.Point(8, 99);
            this.chooseMotorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chooseMotorLabel.Name = "chooseMotorLabel";
            this.chooseMotorLabel.Size = new System.Drawing.Size(87, 16);
            this.chooseMotorLabel.TabIndex = 26;
            this.chooseMotorLabel.Text = "电机1坐标:";
            // 
            // xUnitLabel
            // 
            this.xUnitLabel.AutoSize = true;
            this.xUnitLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xUnitLabel.Location = new System.Drawing.Point(157, 38);
            this.xUnitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.xUnitLabel.Name = "xUnitLabel";
            this.xUnitLabel.Size = new System.Drawing.Size(17, 12);
            this.xUnitLabel.TabIndex = 25;
            this.xUnitLabel.Text = "ct";
            // 
            // yUnitLabel
            // 
            this.yUnitLabel.AutoSize = true;
            this.yUnitLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yUnitLabel.Location = new System.Drawing.Point(157, 69);
            this.yUnitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yUnitLabel.Name = "yUnitLabel";
            this.yUnitLabel.Size = new System.Drawing.Size(17, 12);
            this.yUnitLabel.TabIndex = 24;
            this.yUnitLabel.Text = "ct";
            // 
            // yUnitSpeedLabel
            // 
            this.yUnitSpeedLabel.AutoSize = true;
            this.yUnitSpeedLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yUnitSpeedLabel.Location = new System.Drawing.Point(334, 69);
            this.yUnitSpeedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yUnitSpeedLabel.Name = "yUnitSpeedLabel";
            this.yUnitSpeedLabel.Size = new System.Drawing.Size(35, 12);
            this.yUnitSpeedLabel.TabIndex = 23;
            this.yUnitSpeedLabel.Text = "ct/ms";
            // 
            // xUnitSpeedLabel
            // 
            this.xUnitSpeedLabel.AutoSize = true;
            this.xUnitSpeedLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xUnitSpeedLabel.Location = new System.Drawing.Point(334, 35);
            this.xUnitSpeedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.xUnitSpeedLabel.Name = "xUnitSpeedLabel";
            this.xUnitSpeedLabel.Size = new System.Drawing.Size(35, 12);
            this.xUnitSpeedLabel.TabIndex = 22;
            this.xUnitSpeedLabel.Text = "ct/ms";
            // 
            // yCurrentSpeed
            // 
            this.yCurrentSpeed.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yCurrentSpeed.Location = new System.Drawing.Point(246, 63);
            this.yCurrentSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.yCurrentSpeed.Name = "yCurrentSpeed";
            this.yCurrentSpeed.ReadOnly = true;
            this.yCurrentSpeed.Size = new System.Drawing.Size(87, 26);
            this.yCurrentSpeed.TabIndex = 14;
            this.yCurrentSpeed.Text = "0.0";
            this.yCurrentSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xCurrentSpeed
            // 
            this.xCurrentSpeed.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xCurrentSpeed.Location = new System.Drawing.Point(246, 29);
            this.xCurrentSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.xCurrentSpeed.Name = "xCurrentSpeed";
            this.xCurrentSpeed.ReadOnly = true;
            this.xCurrentSpeed.Size = new System.Drawing.Size(87, 26);
            this.xCurrentSpeed.TabIndex = 13;
            this.xCurrentSpeed.Text = "0.0";
            this.xCurrentSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ySpeedLabel
            // 
            this.ySpeedLabel.AutoSize = true;
            this.ySpeedLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ySpeedLabel.Location = new System.Drawing.Point(194, 65);
            this.ySpeedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ySpeedLabel.Name = "ySpeedLabel";
            this.ySpeedLabel.Size = new System.Drawing.Size(55, 16);
            this.ySpeedLabel.TabIndex = 12;
            this.ySpeedLabel.Text = "Y速度:";
            // 
            // xSpeedLabel
            // 
            this.xSpeedLabel.AutoSize = true;
            this.xSpeedLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xSpeedLabel.Location = new System.Drawing.Point(194, 30);
            this.xSpeedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.xSpeedLabel.Name = "xSpeedLabel";
            this.xSpeedLabel.Size = new System.Drawing.Size(55, 16);
            this.xSpeedLabel.TabIndex = 11;
            this.xSpeedLabel.Text = "X速度:";
            // 
            // dotMotion
            // 
            this.dotMotion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dotMotion.AutoSize = true;
            this.dotMotion.Controls.Add(this.tableLayoutPanel2);
            this.dotMotion.Controls.Add(this.setSpeedBTN);
            this.dotMotion.Controls.Add(this.label2);
            this.dotMotion.Controls.Add(this.speed);
            this.dotMotion.Controls.Add(this.speedLabel);
            this.dotMotion.Controls.Add(this.homeZMotor);
            this.dotMotion.Controls.Add(this.yMotor);
            this.dotMotion.Controls.Add(this.xMotor);
            this.dotMotion.Controls.Add(this.yMotorLabel);
            this.dotMotion.Controls.Add(this.xMotorLabel);
            this.dotMotion.Controls.Add(this.motorCombo);
            this.dotMotion.Controls.Add(this.ctLabel);
            this.dotMotion.Controls.Add(this.motorLabel);
            this.dotMotion.Controls.Add(this.jogHere);
            this.dotMotion.Controls.Add(this.jogHerePos);
            this.dotMotion.Controls.Add(this.stepOne);
            this.dotMotion.Controls.Add(this.label1);
            this.dotMotion.Controls.Add(this.stopMove);
            this.dotMotion.Controls.Add(this.dotStepLabel);
            this.dotMotion.Controls.Add(this.dotStep);
            this.dotMotion.Controls.Add(this.dotUp);
            this.dotMotion.Controls.Add(this.dotDown);
            this.dotMotion.Controls.Add(this.dotLeft);
            this.dotMotion.Controls.Add(this.dotRight);
            this.dotMotion.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dotMotion.Location = new System.Drawing.Point(263, 155);
            this.dotMotion.Margin = new System.Windows.Forms.Padding(2);
            this.dotMotion.Name = "dotMotion";
            this.dotMotion.Padding = new System.Windows.Forms.Padding(2);
            this.dotMotion.Size = new System.Drawing.Size(462, 209);
            this.dotMotion.TabIndex = 16;
            this.dotMotion.TabStop = false;
            this.dotMotion.Text = "点动、回零控制";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(375, 170);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(4, 4);
            this.tableLayoutPanel2.TabIndex = 31;
            // 
            // setSpeedBTN
            // 
            this.setSpeedBTN.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.setSpeedBTN.Location = new System.Drawing.Point(172, 46);
            this.setSpeedBTN.Margin = new System.Windows.Forms.Padding(2);
            this.setSpeedBTN.Name = "setSpeedBTN";
            this.setSpeedBTN.Size = new System.Drawing.Size(62, 24);
            this.setSpeedBTN.TabIndex = 30;
            this.setSpeedBTN.Text = "设置速度";
            this.setSpeedBTN.UseVisualStyleBackColor = true;
            this.setSpeedBTN.Click += new System.EventHandler(this.setSpeedBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(124, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 29;
            this.label2.Text = "cts/ms";
            // 
            // speed
            // 
            this.speed.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.speed.Location = new System.Drawing.Point(70, 48);
            this.speed.Margin = new System.Windows.Forms.Padding(2);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(52, 21);
            this.speed.TabIndex = 28;
            this.speed.Text = "10";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.speedLabel.Location = new System.Drawing.Point(9, 51);
            this.speedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(53, 12);
            this.speedLabel.TabIndex = 27;
            this.speedLabel.Text = "点动速度";
            // 
            // homeZMotor
            // 
            this.homeZMotor.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.homeZMotor.Location = new System.Drawing.Point(384, 40);
            this.homeZMotor.Margin = new System.Windows.Forms.Padding(2);
            this.homeZMotor.Name = "homeZMotor";
            this.homeZMotor.Size = new System.Drawing.Size(58, 25);
            this.homeZMotor.TabIndex = 26;
            this.homeZMotor.Text = "HOME";
            this.homeZMotor.UseVisualStyleBackColor = true;
            this.homeZMotor.Click += new System.EventHandler(this.homeZMotor_Click);
            // 
            // yMotor
            // 
            this.yMotor.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yMotor.FormattingEnabled = true;
            this.yMotor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.yMotor.Location = new System.Drawing.Point(188, 100);
            this.yMotor.Margin = new System.Windows.Forms.Padding(2);
            this.yMotor.Name = "yMotor";
            this.yMotor.Size = new System.Drawing.Size(52, 20);
            this.yMotor.TabIndex = 25;
            this.yMotor.Text = "2";
            // 
            // xMotor
            // 
            this.xMotor.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xMotor.FormattingEnabled = true;
            this.xMotor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.xMotor.Location = new System.Drawing.Point(72, 100);
            this.xMotor.Margin = new System.Windows.Forms.Padding(2);
            this.xMotor.Name = "xMotor";
            this.xMotor.Size = new System.Drawing.Size(52, 20);
            this.xMotor.TabIndex = 24;
            this.xMotor.Text = "1";
            // 
            // yMotorLabel
            // 
            this.yMotorLabel.AutoSize = true;
            this.yMotorLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yMotorLabel.Location = new System.Drawing.Point(137, 103);
            this.yMotorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yMotorLabel.Name = "yMotorLabel";
            this.yMotorLabel.Size = new System.Drawing.Size(47, 12);
            this.yMotorLabel.TabIndex = 23;
            this.yMotorLabel.Text = "Y轴电机";
            // 
            // xMotorLabel
            // 
            this.xMotorLabel.AutoSize = true;
            this.xMotorLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xMotorLabel.Location = new System.Drawing.Point(14, 103);
            this.xMotorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.xMotorLabel.Name = "xMotorLabel";
            this.xMotorLabel.Size = new System.Drawing.Size(47, 12);
            this.xMotorLabel.TabIndex = 22;
            this.xMotorLabel.Text = "X轴电机";
            // 
            // motorCombo
            // 
            this.motorCombo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.motorCombo.FormattingEnabled = true;
            this.motorCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.motorCombo.Location = new System.Drawing.Point(307, 18);
            this.motorCombo.Margin = new System.Windows.Forms.Padding(2);
            this.motorCombo.Name = "motorCombo";
            this.motorCombo.Size = new System.Drawing.Size(52, 20);
            this.motorCombo.TabIndex = 21;
            this.motorCombo.Text = "1";
            // 
            // ctLabel
            // 
            this.ctLabel.AutoSize = true;
            this.ctLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ctLabel.Location = new System.Drawing.Point(364, 48);
            this.ctLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ctLabel.Name = "ctLabel";
            this.ctLabel.Size = new System.Drawing.Size(17, 12);
            this.ctLabel.TabIndex = 20;
            this.ctLabel.Text = "ct";
            // 
            // motorLabel
            // 
            this.motorLabel.AutoSize = true;
            this.motorLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.motorLabel.Location = new System.Drawing.Point(274, 22);
            this.motorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.motorLabel.Name = "motorLabel";
            this.motorLabel.Size = new System.Drawing.Size(29, 12);
            this.motorLabel.TabIndex = 19;
            this.motorLabel.Text = "电机";
            // 
            // jogHere
            // 
            this.jogHere.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jogHere.Location = new System.Drawing.Point(270, 44);
            this.jogHere.Margin = new System.Windows.Forms.Padding(2);
            this.jogHere.Name = "jogHere";
            this.jogHere.Size = new System.Drawing.Size(34, 19);
            this.jogHere.TabIndex = 17;
            this.jogHere.Text = "到这";
            this.jogHere.UseVisualStyleBackColor = true;
            this.jogHere.Click += new System.EventHandler(this.jogHere_Click);
            // 
            // jogHerePos
            // 
            this.jogHerePos.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jogHerePos.Location = new System.Drawing.Point(307, 42);
            this.jogHerePos.Margin = new System.Windows.Forms.Padding(2);
            this.jogHerePos.Name = "jogHerePos";
            this.jogHerePos.Size = new System.Drawing.Size(53, 21);
            this.jogHerePos.TabIndex = 16;
            this.jogHerePos.Text = "0";
            // 
            // stepOne
            // 
            this.stepOne.AutoSize = true;
            this.stepOne.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stepOne.Location = new System.Drawing.Point(13, 76);
            this.stepOne.Margin = new System.Windows.Forms.Padding(2);
            this.stepOne.Name = "stepOne";
            this.stepOne.Size = new System.Drawing.Size(72, 16);
            this.stepOne.TabIndex = 15;
            this.stepOne.Text = "点动一步";
            this.stepOne.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(125, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "cts";
            // 
            // stopMove
            // 
            this.stopMove.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stopMove.Location = new System.Drawing.Point(278, 103);
            this.stopMove.Margin = new System.Windows.Forms.Padding(2);
            this.stopMove.Name = "stopMove";
            this.stopMove.Size = new System.Drawing.Size(119, 50);
            this.stopMove.TabIndex = 10;
            this.stopMove.Text = "Kill All";
            this.stopMove.UseVisualStyleBackColor = true;
            this.stopMove.Click += new System.EventHandler(this.stopMove_Click);
            // 
            // dotStepLabel
            // 
            this.dotStepLabel.AutoSize = true;
            this.dotStepLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dotStepLabel.Location = new System.Drawing.Point(9, 26);
            this.dotStepLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dotStepLabel.Name = "dotStepLabel";
            this.dotStepLabel.Size = new System.Drawing.Size(59, 12);
            this.dotStepLabel.TabIndex = 7;
            this.dotStepLabel.Text = "点动步长:";
            // 
            // dotStep
            // 
            this.dotStep.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dotStep.Location = new System.Drawing.Point(70, 23);
            this.dotStep.Margin = new System.Windows.Forms.Padding(2);
            this.dotStep.Name = "dotStep";
            this.dotStep.Size = new System.Drawing.Size(52, 21);
            this.dotStep.TabIndex = 6;
            this.dotStep.Text = "1000";
            this.dotStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // communicationGroup
            // 
            this.communicationGroup.Controls.Add(this.deSelectDevice);
            this.communicationGroup.Controls.Add(this.selectStatus);
            this.communicationGroup.Controls.Add(this.statuLabel);
            this.communicationGroup.Controls.Add(this.selectDevice);
            this.communicationGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.communicationGroup.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.communicationGroup.Location = new System.Drawing.Point(2, 2);
            this.communicationGroup.Margin = new System.Windows.Forms.Padding(2);
            this.communicationGroup.Name = "communicationGroup";
            this.communicationGroup.Padding = new System.Windows.Forms.Padding(2);
            this.communicationGroup.Size = new System.Drawing.Size(257, 149);
            this.communicationGroup.TabIndex = 18;
            this.communicationGroup.TabStop = false;
            this.communicationGroup.Text = "通讯";
            // 
            // deSelectDevice
            // 
            this.deSelectDevice.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deSelectDevice.Location = new System.Drawing.Point(162, 74);
            this.deSelectDevice.Margin = new System.Windows.Forms.Padding(2);
            this.deSelectDevice.Name = "deSelectDevice";
            this.deSelectDevice.Size = new System.Drawing.Size(71, 32);
            this.deSelectDevice.TabIndex = 16;
            this.deSelectDevice.Text = "断开";
            this.deSelectDevice.UseVisualStyleBackColor = true;
            this.deSelectDevice.Click += new System.EventHandler(this.deSelectDevice_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.currentPos, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dotMotion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.communicationGroup, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.plcFileGroup, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.83835F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.16165F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(727, 366);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // plcFileGroup
            // 
            this.plcFileGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plcFileGroup.Controls.Add(this.send_command);
            this.plcFileGroup.Controls.Add(this.commandText);
            this.plcFileGroup.Controls.Add(this.sendCommandLabel);
            this.plcFileGroup.Controls.Add(this.readFile);
            this.plcFileGroup.Controls.Add(this.plcFileUpload);
            this.plcFileGroup.Controls.Add(this.filePLCPath);
            this.plcFileGroup.Controls.Add(this.openPLCFile);
            this.plcFileGroup.Controls.Add(this.programFileLabel);
            this.plcFileGroup.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plcFileGroup.Location = new System.Drawing.Point(2, 155);
            this.plcFileGroup.Margin = new System.Windows.Forms.Padding(2);
            this.plcFileGroup.Name = "plcFileGroup";
            this.plcFileGroup.Padding = new System.Windows.Forms.Padding(2);
            this.plcFileGroup.Size = new System.Drawing.Size(257, 209);
            this.plcFileGroup.TabIndex = 19;
            this.plcFileGroup.TabStop = false;
            this.plcFileGroup.Text = "程序控制";
            // 
            // commandText
            // 
            this.commandText.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.commandText.Location = new System.Drawing.Point(68, 26);
            this.commandText.Margin = new System.Windows.Forms.Padding(2);
            this.commandText.Name = "commandText";
            this.commandText.Size = new System.Drawing.Size(123, 21);
            this.commandText.TabIndex = 22;
            // 
            // sendCommandLabel
            // 
            this.sendCommandLabel.AutoSize = true;
            this.sendCommandLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendCommandLabel.Location = new System.Drawing.Point(6, 27);
            this.sendCommandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sendCommandLabel.Name = "sendCommandLabel";
            this.sendCommandLabel.Size = new System.Drawing.Size(59, 12);
            this.sendCommandLabel.TabIndex = 21;
            this.sendCommandLabel.Text = "发送命令:";
            // 
            // readFile
            // 
            this.readFile.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.readFile.Location = new System.Drawing.Point(47, 91);
            this.readFile.Margin = new System.Windows.Forms.Padding(2);
            this.readFile.Name = "readFile";
            this.readFile.Size = new System.Drawing.Size(74, 29);
            this.readFile.TabIndex = 6;
            this.readFile.Text = "打开文件";
            this.readFile.UseVisualStyleBackColor = true;
            this.readFile.Click += new System.EventHandler(this.readFile_Click);
            // 
            // plcFileUpload
            // 
            this.plcFileUpload.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plcFileUpload.Location = new System.Drawing.Point(137, 91);
            this.plcFileUpload.Margin = new System.Windows.Forms.Padding(2);
            this.plcFileUpload.Name = "plcFileUpload";
            this.plcFileUpload.Size = new System.Drawing.Size(84, 29);
            this.plcFileUpload.TabIndex = 3;
            this.plcFileUpload.Text = "文件上传";
            this.plcFileUpload.UseVisualStyleBackColor = true;
            this.plcFileUpload.Click += new System.EventHandler(this.plcFileUpload_Click);
            // 
            // filePLCPath
            // 
            this.filePLCPath.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.filePLCPath.Location = new System.Drawing.Point(68, 51);
            this.filePLCPath.Margin = new System.Windows.Forms.Padding(2);
            this.filePLCPath.Name = "filePLCPath";
            this.filePLCPath.Size = new System.Drawing.Size(123, 21);
            this.filePLCPath.TabIndex = 2;
            // 
            // openPLCFile
            // 
            this.openPLCFile.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.openPLCFile.Location = new System.Drawing.Point(193, 48);
            this.openPLCFile.Margin = new System.Windows.Forms.Padding(2);
            this.openPLCFile.Name = "openPLCFile";
            this.openPLCFile.Size = new System.Drawing.Size(62, 27);
            this.openPLCFile.TabIndex = 1;
            this.openPLCFile.Text = "选择文件";
            this.openPLCFile.UseVisualStyleBackColor = true;
            this.openPLCFile.Click += new System.EventHandler(this.openPLCFile_Click);
            // 
            // programFileLabel
            // 
            this.programFileLabel.AutoSize = true;
            this.programFileLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.programFileLabel.Location = new System.Drawing.Point(6, 55);
            this.programFileLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.programFileLabel.Name = "programFileLabel";
            this.programFileLabel.Size = new System.Drawing.Size(59, 12);
            this.programFileLabel.TabIndex = 0;
            this.programFileLabel.Text = "程序文件:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助ToolStripMenuItem,
            this.关于我们ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(727, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // 关于我们ToolStripMenuItem
            // 
            this.关于我们ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.软件版本ToolStripMenuItem,
            this.开发信息ToolStripMenuItem});
            this.关于我们ToolStripMenuItem.Name = "关于我们ToolStripMenuItem";
            this.关于我们ToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.关于我们ToolStripMenuItem.Text = "关于我们";
            // 
            // 软件版本ToolStripMenuItem
            // 
            this.软件版本ToolStripMenuItem.Name = "软件版本ToolStripMenuItem";
            this.软件版本ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.软件版本ToolStripMenuItem.Text = "软件版本";
            this.软件版本ToolStripMenuItem.Click += new System.EventHandler(this.软件版本ToolStripMenuItem_Click);
            // 
            // 开发信息ToolStripMenuItem
            // 
            this.开发信息ToolStripMenuItem.Name = "开发信息ToolStripMenuItem";
            this.开发信息ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.开发信息ToolStripMenuItem.Text = "开发信息";
            this.开发信息ToolStripMenuItem.Click += new System.EventHandler(this.开发信息ToolStripMenuItem_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel.Location = new System.Drawing.Point(397, 5);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(35, 12);
            this.dateLabel.TabIndex = 21;
            this.dateLabel.Text = "日期:";
            // 
            // dateCurrent
            // 
            this.dateCurrent.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateCurrent.Location = new System.Drawing.Point(434, 1);
            this.dateCurrent.Margin = new System.Windows.Forms.Padding(2);
            this.dateCurrent.Name = "dateCurrent";
            this.dateCurrent.ReadOnly = true;
            this.dateCurrent.Size = new System.Drawing.Size(73, 21);
            this.dateCurrent.TabIndex = 22;
            this.dateCurrent.Text = "2022/1/1";
            this.dateCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeLabel.Location = new System.Drawing.Point(508, 5);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(35, 12);
            this.timeLabel.TabIndex = 23;
            this.timeLabel.Text = "时间:";
            // 
            // timeCurrent
            // 
            this.timeCurrent.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeCurrent.Location = new System.Drawing.Point(541, 1);
            this.timeCurrent.Margin = new System.Windows.Forms.Padding(2);
            this.timeCurrent.Name = "timeCurrent";
            this.timeCurrent.ReadOnly = true;
            this.timeCurrent.Size = new System.Drawing.Size(42, 21);
            this.timeCurrent.TabIndex = 24;
            this.timeCurrent.Text = "00:00";
            this.timeCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerCurrentDateTime
            // 
            this.timerCurrentDateTime.Tick += new System.EventHandler(this.timerCurrentDateTime_Tick);
            // 
            // timerCurrentPosAndSpeedInfo
            // 
            this.timerCurrentPosAndSpeedInfo.Interval = 1000;
            this.timerCurrentPosAndSpeedInfo.Tick += new System.EventHandler(this.timerCurrentPosAndSpeedInfo_Tick);
            // 
            // send_command
            // 
            this.send_command.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.send_command.Location = new System.Drawing.Point(195, 22);
            this.send_command.Margin = new System.Windows.Forms.Padding(2);
            this.send_command.Name = "send_command";
            this.send_command.Size = new System.Drawing.Size(62, 27);
            this.send_command.TabIndex = 23;
            this.send_command.Text = "发送";
            this.send_command.UseVisualStyleBackColor = true;
            this.send_command.Click += new System.EventHandler(this.sendCommand_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(727, 390);
            this.Controls.Add(this.timeCurrent);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateCurrent);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "上位机控制程序";
            this.currentPos.ResumeLayout(false);
            this.currentPos.PerformLayout();
            this.dotMotion.ResumeLayout(false);
            this.dotMotion.PerformLayout();
            this.communicationGroup.ResumeLayout(false);
            this.communicationGroup.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.plcFileGroup.ResumeLayout(false);
            this.plcFileGroup.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button dotUp;
        private System.Windows.Forms.Button dotDown;
        private System.Windows.Forms.Button selectDevice;
        private System.Windows.Forms.Button dotLeft;
        private System.Windows.Forms.Button dotRight;
        private System.Windows.Forms.TextBox xPosition;
        private System.Windows.Forms.TextBox yPosition;
        private System.Windows.Forms.Label xPosLabel;
        private System.Windows.Forms.Label yPosLabel;
        private System.Windows.Forms.TextBox selectStatus;
        private System.Windows.Forms.Label statuLabel;
        private System.Windows.Forms.GroupBox currentPos;
        private System.Windows.Forms.GroupBox dotMotion;
        private System.Windows.Forms.GroupBox communicationGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于我们ToolStripMenuItem;
        private System.Windows.Forms.Label ySpeedLabel;
        private System.Windows.Forms.Label xSpeedLabel;
        private System.Windows.Forms.TextBox yCurrentSpeed;
        private System.Windows.Forms.TextBox xCurrentSpeed;
        private System.Windows.Forms.Label dotStepLabel;
        private System.Windows.Forms.TextBox dotStep;
        private System.Windows.Forms.Button stopMove;
        private System.Windows.Forms.ToolStripMenuItem 软件版本ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开发信息ToolStripMenuItem;
        private System.Windows.Forms.GroupBox plcFileGroup;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox dateCurrent;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TextBox timeCurrent;
        private System.Windows.Forms.Label programFileLabel;
        private System.Windows.Forms.Button deSelectDevice;
        private System.Windows.Forms.TextBox filePLCPath;
        private System.Windows.Forms.Button openPLCFile;
        private System.Windows.Forms.OpenFileDialog openPLCFileDialog;
        private System.Windows.Forms.Timer timerCurrentDateTime;
        private System.Windows.Forms.Button plcFileUpload;
        private System.Windows.Forms.Label yUnitSpeedLabel;
        private System.Windows.Forms.Label xUnitSpeedLabel;
        private System.Windows.Forms.Timer timerCurrentPosAndSpeedInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox stepOne;
        private System.Windows.Forms.Label xUnitLabel;
        private System.Windows.Forms.Label yUnitLabel;
        private System.Windows.Forms.Button readFile;
        private System.Windows.Forms.TextBox jogHerePos;
        private System.Windows.Forms.Button jogHere;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label motorLabel;
        private System.Windows.Forms.Label ctLabel;
        private System.Windows.Forms.ComboBox motorCombo;
        private System.Windows.Forms.ComboBox yMotor;
        private System.Windows.Forms.ComboBox xMotor;
        private System.Windows.Forms.Label yMotorLabel;
        private System.Windows.Forms.Label xMotorLabel;
        private System.Windows.Forms.Label chooseMotorLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox chooseMotorPos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox chooseMotorV;
        private System.Windows.Forms.Label speedChooseMotorLabel;
        private System.Windows.Forms.Button homeZMotor;
        private System.Windows.Forms.TextBox commandText;
        private System.Windows.Forms.Label sendCommandLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox speed;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Button setSpeedBTN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button send_command;
    }
}

