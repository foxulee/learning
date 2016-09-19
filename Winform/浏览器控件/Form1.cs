using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 浏览器控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txbURL.Text = txbURL.Text;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txbURL.Text.ToString());
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.txbURL.Width = this.ClientSize.Width - this.btnEnter.Width - 30;
        }
    }
}
