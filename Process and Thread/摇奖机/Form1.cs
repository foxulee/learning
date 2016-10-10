using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 摇奖机
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";
            label4.Text = "0";
            label5.Text = "0";
            //禁止跨线程校验
            CheckForIllegalCrossThreadCalls = false;
        }

        Thread th;
        bool flag = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text=="开始")
            {
                flag = true;
                button1.Text = "停止";
            }
            else
            {
                flag = false;
                button1.Text = "开始";
            }

            th = new Thread(GameStart);
            th.IsBackground = true;
            th.Start();
        }

        private void GameStart()
        {
            Random r = new Random();
            while (flag==true)
            {
                label1.Text = r.Next(0, 10).ToString();
                label2.Text = r.Next(0, 10).ToString();
                label3.Text = r.Next(0, 10).ToString();
                label4.Text = r.Next(0, 10).ToString();
                label5.Text = r.Next(0, 10).ToString();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //关闭主窗口时关闭线程
            if (th!=null)
            {
                th.Abort();
            }
            MessageBox.Show("感谢使用！");
        }

       
    }
}
