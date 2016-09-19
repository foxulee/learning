using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace 使用ListBox实现双击播放音乐
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] paths=Directory.GetFiles(@"K:\音乐\游戏音乐\","*.WAV",SearchOption.AllDirectories);          //将此文件夹(包括子文件夹,SearchOption.AllDirectories)下全部wav文件("*.WAV")的路径提取出来
            foreach (string path in paths)
            {
                listBox1.Items.Add(path);
            }
            
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();               //using System.Media
            sp.SoundLocation = listBox1.Items[listBox1.SelectedIndex].ToString();
            sp.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
