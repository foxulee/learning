using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI_的基本用法
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Graphics类是sealed，GDI对象无法通过new方法来创建。只能用this.CreateGraphics()；方法来创建
            Graphics g = this.CreateGraphics();
            //画直线
            //条件：纸 笔 两个点 颜色 人
            Point p1 = new Point(50,50);
            Point p2 = new Point(250,250);
            Pen pen = new Pen(Brushes.Green);
            g.DrawLine(pen,p1,p2);

        }

        int i = 0;       //显示窗体重绘的次数
        private void Form1_Paint(object sender, PaintEventArgs e)               //操作系统能自动重绘拖动的窗口，但无法重绘GUI绘的直线，所有要给Form1主窗体创建一个Paint时间，每次都重绘直线。
        {
            if (i>=2)
            {
                //Graphics类是sealed，GDI对象无法通过new方法来创建。只能用this.CreateGraphics()；方法来创建
                Graphics g = this.CreateGraphics();
                //画直线
                //条件：纸 笔 两个点 颜色 人
                Point p1 = new Point(50, 50);
                Point p2 = new Point(250, 250);
                Pen pen = new Pen(Brushes.Green);
                g.DrawLine(pen, p1, p2);
            }
            
            label1.Text = "直线重绘"+i.ToString()+"次";
            i++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Graphics g = this.CreateGraphics();
            Rectangle rect = new Rectangle(3,3,200,300);
            g.DrawRectangle(new Pen(Brushes.Black,2.5f),rect);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Rectangle rect = new Rectangle(3, 3, 200, 300);
            g.FillRectangle(Brushes.Blue,rect);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawString("我是最帅的", new Font("宋体",20,FontStyle.Italic),Brushes.Bisque,new Point (250,250));
        }
    }
}
