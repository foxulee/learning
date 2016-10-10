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

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Thread th;
        private void btnStart_Click(object sender, EventArgs e)
        {
            //创建一个开始监听的socket   SocketType.Stream,ProtocolType.Tcp表示TCP协议
            Socket socketWatch = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);

            //创建IP地址（两种写法）
            //IPAddress ip = IPAddress.Parse(txtServer.Text); //IP地址写死了，不灵活
            IPAddress ip = IPAddress.Any;     //查看本机ip地址 cmd-->>ipconfig

            //创建端口号
            IPEndPoint point = new IPEndPoint(ip,Convert.ToInt32(txtPort.Text));

            //让负责监听的Socket绑定IP地址和端口号
            socketWatch.Bind(point);
            btnStart.Enabled = false;

            ShowMsg("监听成功");

            //设置监听队列
            socketWatch.Listen(10);  //10表示在当前时间点内能够连入客户端的最大数量，例如登录游戏时排队，显示当前有168人在等待...

            //开启新的线程来创建通信Socket  新线程执行带参数的方法，参数只能是object类型，并且参数放在Start()方法中。
            th = new Thread(Listen);
            th.IsBackground = true;
            th.Start(socketWatch);

            
        }

        void ShowMsg(string str)
        {
            txtLog.AppendText(str+"\r\n");
        }


        //存储ip地址和对应的和客户端通信的socket
        Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket>();
        

        Socket socketSend;        //把负责通信的socket写到方法外面，方便其他方法调用
        /// <summary>
        /// 监听客户端的连接 并创建与之通信的Socket
        /// </summary>
        /// <param name="o"></param>
        void Listen(object o)                  //创建新thread执行带参数的方法，参数必须是object类型！！！
        {
            try
            {
                Socket socketWatch = o as Socket;       //里氏转换
                while (true)
                {
                    //通过Accept方法创建负责和客户端通信的Socket.需要新建一个thread！否则卡死。

                    socketSend = socketWatch.Accept();        //注意：这里存的是最后一个连进来的客户端

                    //将远程客户端的IP地址和端口号存储到combobox中
                    cboUsers.Items.Add(socketSend.RemoteEndPoint.ToString());

                    //同时存储到Dictionary中
                    dicSocket.Add(socketSend.RemoteEndPoint.ToString(),socketSend);

                    ShowMsg(socketSend.RemoteEndPoint.ToString() + "连接成功！");

                    //开启一个新线程来接受客户端发来的消息。
                    Thread th = new Thread(ReceiveMsg);
                    th.IsBackground = true;
                    th.Start(socketSend);

                    

                }
            }
            catch 
            {

              
            }
        }


        
        /// <summary>
        /// 不停地接受客户端发过来的消息
        /// </summary>
        /// <param name="o"></param>
        void ReceiveMsg(object o)
        {
           Socket socket = o as Socket;

            while (true)
            {
                try                             //凡是网络编程的代码都try catch起来，因为各种各样的问题例如网络传输不顺畅等会抛异常
                {
                    //服务端开始接受客户端发来的数据
                    byte[] buffer = new byte[1024 * 1024 * 2];
                    //服务端实际接收到的有效字节数
                    int r = socket.Receive(buffer);
                    if (r == 0)              //如果客户端下线则跳出循环。
                    {
                        break;
                    }
                    //将接收到的字节数组转换成字符串；
                    string str = Encoding.UTF8.GetString(buffer, 0, r);
                    ShowMsg(socket.RemoteEndPoint.ToString() + ": " + str);

                }
                catch 
                {

                    
                }
                
                
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (th!=null)         //主窗口结束时关闭线程。
            {
                th.Abort();
            }
        }

        private void Form1_Load(object sender, EventArgs e)    
        {
            Control.CheckForIllegalCrossThreadCalls = false;   // 取消跨线程限制！
        }

        /// <summary>
        /// 服务端给客户端发送文字消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(txtMsg.Text);
            List<byte> list = new List<byte>();
            list.Add(0);        //假协议，在文字消息前面人为的加上0作为标记，以区分文件和震动。
            list.AddRange(buffer);
            byte[] bufferCoded = list.ToArray();

            //选择在下拉框中选择的客户端，发送给该客户端
            dicSocket[cboUsers.SelectedItem.ToString()].Send(bufferCoded);

            ShowMsg("我: "+txtMsg.Text);
            txtMsg.Text = "";
        }

        /// <summary>
        /// 选择要发送的文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\Foxulee\Desktop";
            ofd.Title = "请选择要发送的文件";
            ofd.ShowDialog();
            txtPath.Text = ofd.FileName;
        }

        /// <summary>
        /// 向客户端发送文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendFile_Click(object sender, EventArgs e)
        {
            
            using (FileStream fsRead = new FileStream(txtPath.Text,FileMode.OpenOrCreate,FileAccess.Read))
            {
                byte[] buffer = new byte[fsRead.Length];
                //获得用户选择的ip地址
                List<byte> list = new List<byte>();
                list.Add(1);             //将要传送的文件前加上1作为标记
                list.AddRange(buffer);
                byte[] bufferCoded = list.ToArray();

                string ip = cboUsers.SelectedItem.ToString();
                dicSocket[ip].Send(bufferCoded);
            }
        }

        /// <summary>
        /// 发送震动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZD_Click(object sender, EventArgs e)
        {
            if (cboUsers.SelectedItem==null)
            {
                MessageBox.Show("请在下拉框中选择对方的的IP地址。");
            }
            else
            {
                byte[] buffer = new byte[1];
                buffer[0] = 2;              //将震动标记为2

                string ip = cboUsers.SelectedItem.ToString();
                dicSocket[ip].Send(buffer);
            }
            
        }
    }
}
