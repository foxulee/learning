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
using ProFactory;
using ProOperation;

namespace ProCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //首先读取配置文档Config
            string[] lines = File.ReadAllLines("Config.txt");

            int x = 139;
            int y = 154;
            foreach (string line in lines)
            {
                //有几条数据，就创建几个按钮
                Button btn = new Button();
                btn.Location = new Point(x,y);
                btn.Size = new Size(75, 23);
                btn.Text = line;
                x += 74;

                btn.Click += Btn_Click;  //创建点击事件
                this.Controls.Add(btn); //添加到窗体上
            }
            label1.Text = "";
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int num1 = Convert.ToInt32(textBox1.Text.Trim());
            int num2 = Convert.ToInt32(textBox2.Text.Trim());
            //获得简单工厂提供的父类对象
            Operation oper = Factory.Getoper(btn.Text,num1,num2);

            if (oper !=null)
            {
                label1.Text = oper.GetResult().ToString(); 
            }
            else
            {
                MessageBox.Show("缺少运算符！");
            }
            
        }
    }
}
