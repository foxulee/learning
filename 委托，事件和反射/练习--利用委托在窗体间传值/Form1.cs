using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 练习__利用委托在窗体间传值
{
    public delegate void Deltrans(string str);
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(ShowMesssage);
            frm2.Show();
        }

        private void ShowMesssage(string str)
        {
            label1.Text = str;
        }
    }
}
