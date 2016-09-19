using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] strs = Directory.GetFiles(@"M:\DCIM\Acadia National Park","*.jpg");                         //参数"*.jpg"，只显示jpg文件
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(strs[0]);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        
        int i = 0;
        private void btnNext_Click(object sender, EventArgs e)
        {
            i++;
            if (i==strs.Length)                              //重复显示图片
            {
                i = 0;
            }
            pictureBox1.Image = Image.FromFile(strs[i]);

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
                      
            i--;
            if (i < 0)
            {
                i = strs.Length - 1;
            }

            pictureBox1.Image = Image.FromFile(strs[i]);
        }
    }
}
