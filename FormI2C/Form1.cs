using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using USBLib;

namespace FormI2C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private USBMethod usb;
        private bool flag;
        byte[] data = new byte[64];
        private bool connect = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if (!connect) return;
            if (flag) return;
            //开始按钮
            flag = true;
            timer1.Start();
            Task.Run(() =>
            {
                this.Read();
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //暂停按钮
            flag = false;
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //重置按钮
            flag = false;
            timer1.Stop();
            strSDA = "";
            strSCL = "";
            main = "";
            text3 = "";
            display1.ClearBitmap();
            display2.ClearBitmap();
            textSDA.Clear();
            textSCL.Clear();
            textBox1.Clear();
        }
        
        int cursor = 0;
        int pointer = 0;
        List<byte[]> buffer0 = new List<byte[]>();
        List<byte[]> buffer1 = new List<byte[]>();
        private void Read()
        {
            while (flag)
            {
                if (usb.ReadData())
                {
                    data = usb.RecvBuffer;
                    //深度拷贝
                    byte[] b = new byte[data.Length];
                    Array.Copy(data, 0, b, 0, data.Length);

                    switch (cursor)
                    {
                        case 0:
                            buffer0.Add(b);
                            break;
                        case 1:
                            buffer1.Add(b);
                            break;
                    }
                }
            }
        }

        private int _SDA;//数据
        private int _SCL;//时钟
        public int SDA
        {
            get { return _SDA; }
            set
            {
                if (value != _SDA)
                {
                    _SDA = value;
                    SDA_Changed();
                }
            }
        }

        public int SCL
        {
            get { return _SCL; }
            set
            {
                if (value != _SCL)
                {
                    _SCL = value;
                    //SCL_Changed();
                }
            }
        }
        private string strSCL = "";
        private string strSDA = "";
        string main = "";
        string text3 = "";
        string DataType = "Addr";
        private void getBufferData()
        {
            switch (pointer)
            {
                case 0:
                    cursor = 1;
                    display1.DrawBitmap(buffer0, 0x10);
                    display2.DrawBitmap(buffer0, 0x11);
                    foreach (byte[] b in buffer0)
                    {
                        if (b[0x11] > 127)
                        {
                            //strSCL += "1";
                            SCL = 1;
                        }
                        else
                        {
                            //strSCL += "0";
                            SCL = 0;
                        }
                        strSCL = SCL + strSCL;

                        if (b[0x10] > 127)
                        {
                            //strSDA += "1";
                            SDA = 1;
                        }
                        else
                        {
                            //strSDA += "0";
                            SDA = 0;
                        }
                        strSDA = SDA + strSDA;
                        this.WriteI2c();
                    }
                    textSCL.Text = strSCL;
                    textSDA.Text = strSDA;

                    buffer0.Clear();
                    pointer = 1;
                    break;
                case 1:
                    cursor = 0;
                    display1.DrawBitmap(buffer1, 0x10);
                    display2.DrawBitmap(buffer1, 0x11);
                    foreach (byte[] b in buffer1)
                    {
                        if (b[0x11] > 127)
                        {
                            //strSCL += "1";
                            SCL = 1;
                        }
                        else
                        {
                            //strSCL += "0";
                            SCL = 0;
                        }
                        strSCL = SCL + strSCL;

                        if (b[0x10] > 127)
                        {
                            //strSDA += "1";
                            SDA = 1;
                        }
                        else
                        {
                            //strSDA += "0";
                            SDA = 0;
                        }
                        strSDA = SDA + strSDA;
                        this.WriteI2c();
                    }
                    textSCL.Text = strSCL;
                    textSDA.Text = strSDA;

                    buffer1.Clear();
                    pointer = 0;
                    break;
            }
        }

        private void WriteI2c()
        {
            if (startFlag)
            {
                switch (DataType)
                {
                    case "Addr":
                        if (i < 7)
                        {
                            main += SDA.ToString();
                            //main += i.ToString();
                            i++;
                        }
                        else if (i == 7)
                        {
                            if (SDA == 1)
                            {
                                main += " Read ";
                            }
                            else
                            {
                                main += " Write";
                            }
                            i++;
                        }
                        else if (i == 8)
                        {
                            textBox1.AppendText(DataType + ":" + main + " ACK ");
                            main = "";
                            i = 0;
                            DataType = "Data";
                        }
                        else
                        {
                            i = 0;
                        }
                        break;
                    case "Data":
                        if (i < 8)
                        {
                            main += SDA.ToString();
                            i++;
                        }
                        else if (i == 8)
                        {
                            textBox1.AppendText(DataType + ":" + main + " ACK ");
                            main = "";
                            i = 0;
                        }
                        else
                        {
                            i = 0;
                        }
                        break;
                }
            }
        }

        private bool startFlag = false;
        private int i = 0;
        private void SDA_Changed()
        {
            if (SCL == 1)
            {
                //从高位到低位
                if (SDA == 0)
                {
                    //开始信号
                    text3 += "S ";
                    textBox1.AppendText(text3);
                    text3 = "";
                    main = "";
                    startFlag = true;
                }
                else
                {
                    //结束信号
                    startFlag = false;
                    DataType = "Addr";
                    i = 0;
                    text3 += main;
                    text3 += " P\r\n";
                    textBox1.AppendText(text3);
                    text3 = "";
                }

                this.textBox1.Focus();//获取焦点
                this.textBox1.Select(this.textBox1.Text.Length, 0);
                this.textBox1.ScrollToCaret();//滚动到光标处
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getBufferData();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            usb = new USBMethod(0x0079, 0x0006);
            usb.OnEnabledChange += new USBMethod.enabledChange(UsbEnabled_Change);
            //array_data = new ObservableCollection<byte[]>();
            //buffer_data = new ObservableCollection<byte[]>();
        }
        //ObservableCollection<byte[]> array_data;
        //ObservableCollection<byte[]> buffer_data;

        private void UsbEnabled_Change(object sender, EventArgs e)
        {
            if (usb.enabled)
            {
                this.toolStripStatusLabel1.Text = "设备连接";
                connect = true;
            }
        }
    }
}
