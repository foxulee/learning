using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visable和Enable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.BackColor = Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            button3.BackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button1.Enabled = true;
        }
    }
}
