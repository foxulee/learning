using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 练习__动态创建事件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Location = new Point(154, 62);
            btn.Size = new Size(175,23);
            btn.Text = "我是被动态创建的";

            btn.Click += Btn_Click1;
            btn.Click += Btn_Click;
            
            this.Controls.Add(btn);
        }

        private void Btn_Click1(object sender, EventArgs e)
        {
            Label lbl = new Label();
            lbl.Location = new Point(154,90);
            lbl.AutoSize = true;
            lbl.Text = "我也是被动态创建的文本";
            this.Controls.Add(lbl);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我是被事件出发的窗口");
        }
    }
}
