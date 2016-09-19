using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alarm_clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("你中病毒啦");
            //每隔一秒钟将当前系统的时间赋值给lable
            lblTime.Text = DateTime.Now.ToString();

            if (DateTime.Now.Hour==10 && DateTime.Now.Minute==50 && DateTime.Now.Second==40)   //调用系统时间的方法
            {
                //创建一个能够播放音乐的对象
                SoundPlayer sp = new SoundPlayer();    //需要using System.Media
                sp.SoundLocation = @"K:\音乐\游戏音乐\《幻灵游侠》\爱河.WAV";  // 只能播放wav文件
                sp.Play();
            }
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //当程序加载的时候 将当前系统的时间 赋值给label
            lblTime.Text = DateTime.Now.ToString();
        }
    }
}
