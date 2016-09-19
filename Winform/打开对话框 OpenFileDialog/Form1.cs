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

namespace 打开对话框_OpenFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();   //创建打开对话框对象
            ofd.Title = "Please choose the file";        //设置标题栏显示的内容
            ofd.Multiselect = true;      //设置对话框可以多选文件
            ofd.InitialDirectory = @"C:\Users\Foxulee\Desktop";   //初始显示的路径
            ofd.Filter = "媒体文件|*.WAV|图片文件|*.jpg|文本文件|*.txt|所有文件|*.*";                    //设置打开对话框文件的类型
            ofd.ShowDialog();                //显示对话框。

            string[] paths = ofd.FileNames;    //获得所有选中文件的全路径

            foreach (string path in paths)
            {
                listBox1.Items.Add(Path.GetFileName(path));      //Path.getFileName根据路径获得对应的文件的文件名，需要using System.IO
            }

        }
    }
}
