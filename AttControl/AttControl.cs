

using System;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;
/// <summary>
/// 
/// </summary>
namespace AttControl
{
    
    public partial class AttControl : Form
    {
        public AttControl()
        {
            InitializeComponent();
        }
        SerialPort Sp1 = new SerialPort();        //这个是定义的全局变量
        SerialPort Sp2 = new SerialPort();
        Thread Att1Start, Att2Start,CycleStart;
        public delegate void DelegateFun(string msg);
        SerialPortSetting Att1 = new SerialPortSetting();
        SerialPortSetting Att2 = new SerialPortSetting();
        bool IsCycle;
       


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AttControl_Load(object sender, EventArgs e)
        {
            RefreshPort();
            //Att1.Formthis = this;
            //Att1.Log = Log;
            //Att2.Formthis = this;
            //Att2.Log = Log;
            Att1.Showatt += new SerialPortSetting.ShowAtt(Showatt1);
            Att1.Endset += new SerialPortSetting.ShowAtt(Setbt1);
            Att1.ShowInfo += new SerialPortSetting.ShowAtt(ShowInfo);
            Att2.Showatt += new SerialPortSetting.ShowAtt(Showatt2);
            Att2.ShowInfo += new SerialPortSetting.ShowAtt(ShowInfo);
            Att2.Endset += new SerialPortSetting.ShowAtt(Setbt2);
        }
        /// <summary>
        /// refresh port
        /// </summary>
        private void RefreshPort()
        {
            string[] str = SerialPort.GetPortNames();//检查是否含有串口 
            Port1.Items.Clear();
            Port2.Items.Clear();
            if (str == null)
            {
                ShowInfo("本机没有串口！");
                return;
            }

            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())   //添加串口
            {

                Port1.Items.Add(s);
                Port2.Items.Add(s);//获取有多少个COM口，添加到控件里
            }
            ShowInfo("刷新串口成功！");
        }
        private void ATT1BT_Click(object sender, EventArgs e)
        {

            if (ATT1BT.Text.ToString().Equals("End"))
            {
                try
                {
                    Att1Start.Abort();
                }
                catch (ThreadAbortException)
                {
                    ShowInfo("中止测试！");
                }
                catch (Exception ex)
                {
                    ShowInfo(ex.Message.ToString());
                }

                Setbt1("Start");
            }
            else
            {
                Att1Start = new Thread(new ThreadStart(Att1.Run));
                Att1.Start = StartAtt1.Text.ToString();
                Att1.End = EndAtt1.Text.ToString();
                Att1.Rate = AttGap1.Text.ToString().TrimEnd("dB".ToCharArray());
                Att1.Gap = TimeGap1.Text.ToString().TrimEnd("ms".ToCharArray());
                Att1.Port = Port1.Text.ToString();
                Att1.Portrate = Rate1.Text.ToString();
                Setbt1("End");
                Att1Start.Start();
            }
        }


        private void ATT2BT_Click(object sender, EventArgs e)
        {
            if (ATT2BT.Text.ToString().Equals("End"))
            {
                try
                {
                    Att2Start.Abort();
                }
                catch (ThreadAbortException)
                {
                    ShowInfo("中止测试！");
                }
                catch (Exception ex)
                {
                    ShowInfo(ex.Message.ToString());
                }

                Setbt2("Start");
            }
            else
            {
                Att2Start = new Thread(new ThreadStart(Att2.Run));
                Att2.Start = StartAtt2.Text.ToString();
                Att2.End = EndAtt2.Text.ToString();
                Att2.Rate = AttGap2.Text.ToString().TrimEnd("dB".ToCharArray());
                Att2.Gap = TimeGap2.Text.ToString().TrimEnd("ms".ToCharArray());
                Att2.Port = Port2.Text.ToString();
                Att2.Portrate = Rate2.Text.ToString();
                //Att2.BT = ATT2BT;
                Att2Start.Start();
                Setbt2("End");

            }

        }

        private void RefreshBT_Click(object sender, EventArgs e) => RefreshPort();

        public void Setcycle(string cycle)
        {
            Invoke(new EventHandler(delegate
            {
                Cycles.Text = cycle;
                Cycles.Update();
            }));
        }

        public void Showatt1(string att)
        {
            Invoke(new EventHandler(delegate
            {
                CurrentAtt1.Text = att;
                CurrentAtt1.Update();
            }));
            
        }
        public void Showatt2(string att)
        {
            Invoke(new EventHandler(delegate
            {
                CurrentAtt2.Text = att;
                CurrentAtt2.Update();
            }));
            
        }
        public void Setbt1(string att)
        {
            Invoke(new EventHandler(delegate
            {
                ATT1BT.Text = att;
                ATT1BT.Update();
            }));

        }
        public void Setbt2(string att)
        {
            Invoke(new EventHandler(delegate
            {
                ATT2BT.Text = att;
                ATT2BT.Update();
            }));

        }
        public void EnableBT(bool en)
        {
            Invoke(new EventHandler(delegate
            {
                ATT1BT.Enabled = en;
                ATT1BT.Update();
                ATT2BT.Enabled = en;
                ATT2BT.Update();
            }));

        }

        private void CycleBt_Click(object sender, EventArgs e)
        {
            
            if (CycleBt.Text.ToString().Equals("End"))
            {
                try
                {
                    EnableBT(true);
                    CycleStart.Abort();
                }
                catch (ThreadAbortException)
                {
                    ShowInfo("中止测试！");
                }
                catch (Exception ex)
                {
                    ShowInfo(ex.Message.ToString());
                }
                CycleBt.Text = "循环测试";
            }
            else
            {
                EnableBT(false);
                IsCycle = true;
                CycleStart = new Thread(new ThreadStart(CycleRun));
                Att1.Rate = AttGap1.Text.ToString().TrimEnd("dB".ToCharArray());
                Att1.Gap = TimeGap1.Text.ToString().TrimEnd("ms".ToCharArray());
                Att1.Port = Port1.Text.ToString();
                Att1.Portrate = Rate1.Text.ToString();
                Att2.Rate = AttGap2.Text.ToString().TrimEnd("dB".ToCharArray());
                Att2.Gap = TimeGap2.Text.ToString().TrimEnd("ms".ToCharArray());
                Att2.Port = Port2.Text.ToString();
                Att2.Portrate = Rate2.Text.ToString();
                //Att2.BT = ATT2BT;
                CycleStart.Start();
                CycleBt.Text = "End";

            }
        }
        private void CycleRun()
        {
            int cycle = 0;
            

            while (IsCycle)
            {
                cycle++;
                Setcycle(cycle.ToString());
                Att1.Start ="0";
                Att1.End ="0";
                Att1.Run();
                Att2.Start = "0";
                Att2.End = "60";
                Att2.Run();
                Thread.Sleep(10000);
                cycle++;
                Setcycle(cycle.ToString());
                Att2.Start = "0";
                Att2.End = "0";
                Att2.Run();
                Att1.Start = "0";
                Att1.End = "60";
                Att1.Run();
                Thread.Sleep(10000);
            }

        }




        /// <summary>
        /// print log
        /// </summary>
        /// <param name="Info"></param>
        public void ShowInfo(string Info)
        {
            string time = DateTime.Now.ToString("HH:mm:ss");
            string info = "" + time + "\t" + Info;
            Invoke(new EventHandler(delegate
            {
                Log.AppendText(info);
                Log.AppendText(Environment.NewLine);
                Log.ScrollToCaret();
            }));
            

        }
    }
    /// <summary>
    /// 串口设置类
    /// <para> start</para>
    /// </summary>
 
    class SerialPortSetting
    {
        private string start;
        private string end;
        private string rate;
        private string gap;
        private string port;
        private string portrate;
        private SerialPort Sp = new SerialPort();
        public delegate void ShowAtt(string att);
        public event ShowAtt Showatt;
        public event ShowAtt ShowInfo;
        public event ShowAtt Endset;

        public string Start { get => start; set => start = value; }
        public string End { get => end; set => end = value; }
        public string Rate { get => rate; set => rate = value; }
        public string Gap { get => gap; set => gap = value; }
        public string Port { get => port; set => port = value; }
        public string Portrate { get => portrate; set => portrate = value; }
        /// <summary>
        /// 
        /// </summary>
        public void Run()
        {
            float AttRate;
            float CurrentAtt;
            try
            {
                OpenPort();
                MaxMin(Start, End, out float min, out float max, out int symble);
                AttRate = symble * float.Parse(Rate);
                CurrentAtt = float.Parse(Start);
                while (true)
                {
                    Showatt(CurrentAtt.ToString());
                    ShowInfo("设置端口" + Port + "衰减：" + CurrentAtt.ToString());
                    SendData(Sp, CurrentAtt);
                    Thread.Sleep(Convert.ToInt32(Gap));
                    CurrentAtt += AttRate;
                    if (min > CurrentAtt || CurrentAtt > max)
                    {
                         break;
                    }    
                }
                ClosePort();
            }
            catch(ThreadAbortException)
            {
                ClosePort();
                ShowInfo("中止测试！");
            }
            catch (Exception ex)
            {
                ShowInfo(ex.ToString());
                ShowInfo("打开串口失败" + Port);
                ClosePort();
                return;
            }
            Endset("Start");
            Sp.Close();
        }
        public void OpenPort()
        {
            Sp.PortName = Port;
            Sp.BaudRate = Convert.ToInt32(Portrate);
            Sp.Parity = Parity.None;
            Sp.DataBits = Convert.ToInt32(8);
            Sp.StopBits = (StopBits)Convert.ToInt32(1);

            try
            {
                Sp.Open();
                ShowInfo("打开串口成功" + Port);
            }
            catch (Exception ex)
            {
                ShowInfo(ex.ToString());
                ShowInfo("打开串口失败" + Port);
                Sp.Close();
                return;
            }
        }
        public void ClosePort()
        {
            Sp.Close();
        }
        private static void MaxMin(string N1, string N2, out float min, out float max, out int symble)
        {
            if (float.Parse(N1) > float.Parse(N2))
            {
                symble = -1;
                max = float.Parse(N1);
                min = float.Parse(N2);
            }
            else
            {
                symble = 1;
                max = float.Parse(N2);
                min = float.Parse(N1);
            };

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Sp"></param>
        /// <param name="senddata"></param>
        private void SendData(SerialPort Sp, double att)
        {
            string data;

            try
            {
                if (att == 0)
                {
                    data = "wv00000\n";
                }
                else if (att < 10)
                {
                    data = "wv00" + (att * 100).ToString() + "\n";
                }
                else
                {
                    data = "wv0" + (att * 100).ToString() + "\n";
                }
                byte[] senddata = Encoding.ASCII.GetBytes(data);
                Sp.Write(senddata, 0, senddata.Length);//发送数据
                ShowInfo("成功...");
            }
            catch (ThreadAbortException)
            {
                ShowInfo("中止测试！");
            }
            catch (Exception ex)
            {
                ShowInfo(ex.ToString());
                ShowInfo("失败...");
                return;
            }
        }
        
    }
}
