using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 使用GDI_绘制验证码
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string str = "";
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                str += r.Next(0,10);              //产生0-9的随机数
            }
            

            
            //创建图片类型 bmp是操作系统默认的图片格式
            Bitmap bmp = new Bitmap(130, 25);
            //创建GDI对象
            Graphics g = Graphics.FromImage(bmp);

            string[] fonts = {"黑体","楷体","微软雅黑","宋体","隶书","Arial" };
            Color[] colors = { Color.Aqua ,Color.Black,Color.Chocolate,Color.Bisque,Color.Yellow,Color.Green,Color.Yellow};
            //把数字按顺序随机数画到图片上
            int x = 0;
            int y = 0;
            for (int i = 0; i < 5; i++)
            {
                Point p = new Point(x, y);              //产生随机坐标 

                g.DrawString(str[i].ToString(), new Font(fonts[r.Next(0, 6)], r.Next(15,20), FontStyle.Regular), new SolidBrush(colors[r.Next(0,7)]), p);                 //字体，颜色也随机

                x = x + r.Next(20, 30);
                y = y + r.Next(0, 1);
            }


            //给验证码加上干扰背景
            //加随机直线
            for (int i = 0; i < 20; i++)
            {
                g.DrawLine(new Pen(Brushes.Gray), new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height)), new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height)));
            }

            //加噪点(像素颗粒)
            for (int i = 0; i < 200; i++)
            {
                bmp.SetPixel(r.Next(0, bmp.Width), r.Next(0, bmp.Height), Color.Gray);
            }

            


            //把画好的图片放到picturebox上
            pictureBox1.Image = bmp;
        }
    }
}
