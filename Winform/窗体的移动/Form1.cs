using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗体的移动
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Form2 frm2 = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (this.Contains(button1))
            {
                frm2.Controls.Add(this.button1);                     //在窗体中添加控件
                this.button1.Text = "我现在窗体2中";
                frm2.Show();         
            }

            else
            {
                this.Controls.Add(button1);                           //在窗体中添加控件
                this.button1.Text = "我现在窗体1中";
                this.Show();
            }
        }
    }
}
