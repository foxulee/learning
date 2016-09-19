using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_you_love_me
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我也爱你哟！");
            this.Close();                          //关闭窗体,只要主窗体一关，整个应用程序结束。this代表当前窗体的对象。
            
        }

        private void btnNotLove_MouseEnter(object sender, EventArgs e)
        {
            Random rd = new Random();           //产生随机坐标
            //给按钮重新赋值一个随机坐标。
            btnNotLove.Location = new Point(rd.Next(0,this.ClientSize.Width-btnNotLove.Width+1),rd.Next(0,this.ClientSize.Height-btnNotLove.Height+1));          //ClientSize.Width/Height获取实时窗口的长宽。
        }
    }
}
