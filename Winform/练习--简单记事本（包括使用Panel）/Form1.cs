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

namespace 练习__简单记事本_包括使用Panel_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.WordWrap = false;
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void 打开记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panel1.Visible = true;
            
        }

        List<string> list = new List<string>();

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择要打开的文件";
            ofd.InitialDirectory = @"C:\Users\Foxulee\Desktop";
            ofd.Filter = "文本文件|*.txt|所有文件|*.*";
            ofd.ShowDialog();

            string path = ofd.FileName;

            //将选中文件的名字存储到ListBox中
            listBox1.Items.Add(Path.GetFileName(path));
            //并存储路径
            list.Add(path);

            if (path=="")
            {
                return;
            }
            using (FileStream fsRead= new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer = new byte[1024*1024*3];
                //本次读取实际读取到的字节数
                int r = fsRead.Read(buffer, 0, buffer.Length);
                textBox1.Text = Encoding.Default.GetString(buffer, 0, r);
            }

            listBox1.Show();
            
           
            ofd.OpenFile();
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "请选择保存路径";
            sfd.InitialDirectory = @"C:\Users\Foxulee\Desktop";
            sfd.Filter = "文本文件|*.txt|全部文件|*.*";
            sfd.ShowDialog();

            string path = sfd.FileName;

            if (path == "")
            {
                return;
            }

            using (FileStream fsWrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] buffer = Encoding.Default.GetBytes(textBox1.Text);
                fsWrite.Write(buffer,0,buffer.Length);

            }
            MessageBox.Show("保存成功");
        }

        private void 自动换行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (自动换行ToolStripMenuItem.Text=="自动换行")
            {
                textBox1.WordWrap = true;
                自动换行ToolStripMenuItem.Text = "取消自动换行";
            }
            else
            {
                textBox1.WordWrap = false;
                自动换行ToolStripMenuItem.Text = "自动换行";
            }
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            textBox1.Font = fd.Font;
            
        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            textBox1.ForeColor = cd.Color;
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //获得选择的文件的路径
            string path = list[listBox1.SelectedIndex]; 

            using (FileStream fsRead = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 3];
                int r = fsRead.Read(buffer, 0, buffer.Length);
                textBox1.Text = Encoding.Default.GetString(buffer, 0, r);
            }
        }
    }
}
