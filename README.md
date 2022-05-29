# PMAC CSharp 在C#中控制PMAC  

**摘要**：设计上位机，控制下位机(PMAC)。在C#中，与PMAC卡建立通讯，控制PMAC卡，控制电机、显示电机的位置、转速，进行PLC文件的下载。
(因个人能力，存在不足，见谅)。

---
**目录**：
- [PMAC介绍](#pmac)  
- [环境](#环境)
- [通讯](#通讯)  
- [Jog实现](#jog实现)
- [位置、速度读取](#位置速度读取)  
- [PLC文件下载](#plc文件下载)

---

## PMAC
- PMAC(Programmable Multi-Axis Controller)：可编程多轴控制器，Delta Tau公司生产的运动控制器，是开放式数控系统控制器。[PMAC](https://baike.baidu.com/item/PMAC%E5%8F%AF%E7%BC%96%E7%A8%8B%E5%A4%9A%E8%BD%B4%E6%8E%A7%E5%88%B6%E5%99%A8%E7%AE%80%E4%BB%8B/15641480)  

## 环境：
- [安装PeWinPro 2](https://github.com/lin-tea/PMAC_LabView/tree/main/Sources)  
- C# (vs2022,.NET4)
- 通讯时，注意要管理员权限(windows)。 
- 用Ethenet进行连接时，注意IP的设置[参考](https://blog.csdn.net/qq_42807924/article/details/95048605)。
- [编程手册参考](https://github.com/lin-tea/PMAC_LabView/blob/main/Sources/PcommServer%20Library%20of%20PMAC%20Functions%20.pdf)  

## 程序建立调用
- 程序的建立:
	- 打开
	<div align=center>
		<img src="./images/setupproject.png" height="55%" width="45%">  <img src="./images/setupproject1.png" height="40%" width="40%"></div>
	
- 引用Pcomserver.dll
	- 在项目的`解决方案资源管理器`中的`引用`,右击，选择`添加引用`，在`COM`中找到Pcomserver,添加确定。
	<div align=center>
		<img src="./images/setupproject2.png" height="45%" width="45%"></div>
	
- 在C#中的调用:
	```c#
	using PCOMMSERVERLib;   // PMAC 调用库	
	```  
	如果没报错，OK。
	(注意：调用的dll属性，互嵌入操作需要改成false)  
	<div align=center>
		<img src="./images/embed.png" height="30%" width="30%"></div>  
		
## 主要函数使用:
- 函数  

  |函数|功能|手册页数|
  |---|---|---|
  |*SelectDevice()*|选择PMAC卡|p38|
  |*Open()*|连接PMAC卡|p39|
  |*GetResponseEx()*|发送命令到PMAC卡|p41|	

- PMAC下位机命令:
  |命令|功能|
  |---|---|
  |#nj+|正向连续点动|
  |#nj-|反向连续点动|
  |#nj/|停止、闭环|
  |#nj={*C*}|到C位置,单位脉冲|
  |#nj^{*C*}|运动C个脉冲|
  |#nP|获取位置，单位脉冲|
  |#nHOMEZ|置当前位置为0点|  
  
其中(n表示电机号，C表示常数)
		
## 通讯
- 参考手册，使用函数:`SelectDevice()` + `open()`  
先选择PMAC卡，得到PMAC卡号后，再进行OPEN。  
	- `SelectDevice(0, out pmacNumber, out selectPmacSuccess)`:  
		选择PMAC卡号、连接方式。其中，第一个参数0表示显示连接窗口，选择后PMAC的卡号将输出到pmacNumber变量中，其是主窗口类的一个属性，其他方法可在选择、连接成功后使用该PMAC号与PMAC卡进行通讯；*selectPmacSuccess*为选择状态，选择成功将变为`True`。  
	
	- `Open(pmacNumber, out openPmacSuccess)`:  
		根据卡号与PMAC进行通讯，若成功，openpmacSuccess变为True，其也是主		窗口类的一个属性，连接成功后才能进行如点动等控制。  
		
```c#
//######## PMAC连接、断开 #########
// 这里为按键click触发执行函数
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
```

-  GUI如下:  

<div align=center>
		<img src="./images/connectFront.png" height="20%" width="20%"></div>  
	

## Jog实现

## 位置速度读取

## PLC文件下载

---
## Reference
[1]  
