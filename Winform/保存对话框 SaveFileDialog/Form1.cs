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

namespace 保存对话框_SaveFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"C:\Users\Foxulee\Desktop";
            sfd.Title = "请选择要保存的路径";
            sfd.Filter = "文本文件|*.txt|全部文件|*.*";
            sfd.ShowDialog();

            string path = sfd.FileName;             //获得保存的文件的路径
            if (path=="")                           //如果没有if这个语句，那么点击“cancel”则会报错。因为path为null.
            {
                return;
            }
            string text = textBox1.Text.Trim();
            using (FileStream fsWrite= new FileStream(path,FileMode.OpenOrCreate,FileAccess.Write))
            {
                byte[] buffer = Encoding.Default.GetBytes(text);
                fsWrite.Write(buffer,0,buffer.Length);
            }
            MessageBox.Show("Saved Successfully!");
                       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();             //创建颜色对话框
            cd.ShowDialog();
            textBox1.ForeColor = cd.Color;                 //改变textbox字体颜色
            textBox1.BackColor = Color.Black;             //改变textbox背景颜色
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();               //创建字体对话框
            fd.ShowDialog();
            textBox1.Font = fd.Font;
        }
    }
}
