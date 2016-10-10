using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Socket socket;
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;

            //在客户端创建一个负责跟服务端通信使用的Socket
            socket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);

            //获得要连接服务器的地址
            IPAddress ip = IPAddress.Parse(txtServer.Text);

            //获得要连接服务器的端口号
            IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text));

            ShowMsg("正在连接...");

            socket.Connect(point);


            if (socket.Connected==true)
            {
                ShowMsg("连接成功");
            }

            //客户端接收服务端发来的数据
            Thread th = new Thread(Receive);
            th.IsBackground = true;
            th.Start();



        }

        private void ShowMsg(string str)
        {
            txtLog.AppendText(str+"\r\n");
        }

        /// <summary>
        /// 接受文字消息
        /// </summary>
        void Receive()
        {
            while (true)
            {
                try
                {
                    //客户端接受服务器短发来的数据
                    byte[] buffer = new byte[1024 * 1024 * 2];
                    int r = socket.Receive(buffer);
                    //解码，判断接收的是文字，文件还是震动
                    byte b = buffer[0];

                    //文字
                    if (b==0)
                    {
                        string str = Encoding.UTF8.GetString(buffer, 1, r-1);
                        txtLog.AppendText(socket.RemoteEndPoint.ToString() + ": " + str + "\r\n");
                    }
                    //文件
                    else if(b==1)
                    {
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.InitialDirectory = @"C:\Users\Foxulee\Desktop";
                        sfd.Title = "请选择保存路径";
                        sfd.Filter=
                        sfd.ShowDialog(this);            //在Win7环境下，最好加上this，Win8没这个问题，这是个bug

                        using (FileStream fsWrtie= new FileStream(sfd.FileName,FileMode.OpenOrCreate,FileAccess.Write))
                        {
                            fsWrtie.Write(buffer, 1, r - 1);
                        }
                        MessageBox.Show("保存成功！");
                    }
                    //震动
                    else
                    {
                        ScrnShake();
                    }
                    
                }
                catch
                {

                }
            }
            

        }

        void ScrnShake()
        {
            int width = this.Width;
            int height = this.Height;
            for (int i = 0; i < 200; i++)
            {
                this.Size = new Size(width+5,height+5);
                this.Size = new Size(width,height);
            }
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            string str=txtMsg.Text.ToString();
            byte[] buffer = Encoding.UTF8.GetBytes(str);
            socket.Send(buffer);
            ShowMsg("我: "+str);
            txtMsg.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
