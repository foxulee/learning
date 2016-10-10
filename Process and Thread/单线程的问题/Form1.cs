using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 单线程的问题
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Thread th1;            //注意：需要在事件之外，因为多个事件都要访问
        private void button1_Click(object sender, EventArgs e)
        {
            //test();   //主线程去执行此费时的方法，主窗口会假死，需另外开一个线程
            //Thread th = new Thread(test);
            ////设置成后台线程
            //th.IsBackground = true;
            //th.Start();       //告诉CPU我们的程序已经就绪，什么时候调用由CPU决定，无法通过代码来让CPU立刻或何时执行程序。如果CPU此时闲置，会立刻执行，如果CPU此时被占用，则等空闲的时候再执行。所以这就是为什么有时候即使开了多线程，程序也卡的原因。

            //跨线程访问。
            th1 = new Thread(testCrossThreads);
            th1.IsBackground = true;
            th1.Start();
            //但跨线程容易产生一个问题，就是当后台线程还未运行结束主窗体就已经关闭，那么主窗体中所有的窗体都会关闭，这样后台线程还有可能访问某窗体，所以有可能程序会报错。解决办法是，在Form1创建一个事件Form1_FormClosing

        }

        void test()
        {
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine(i);
            }
            MessageBox.Show("运行结束");
        }

        void testCrossThreads()
        {
            for (int i = 0; i < 10000; i++)
            {
                textBox1.Text=i.ToString();
            }
            MessageBox.Show("运行结束");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //.NET FrameWork默认不让跨线程访问
            //可以通过取消对跨线程访问的检查是实现此目的
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //当关闭主窗体的时候，同时关闭后台线程
            if (th1!=null)      //判断已开的线程是否已关闭,没有的话，手动关闭
            {
                //关闭线程,释放资源。注意！！！：线程一旦没关闭，就不能再被打开了
                th1.Abort();
            }

        }
    }
}
