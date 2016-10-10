using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //快捷键显示overload: ctrl+shift+space
            
            
            //为什么要用多线程
            //让计算机"同时"做多件事情，节约时间。
            //多线程可以让一个程序“同时”处理多个事情。
            //后台运行程序，提高程序的运行效率，也不会使主界面出现无响应的情况。
            //获得当前线程和当前进程


            //产生一个线程的4步骤：
            //编写产生线程所要执行的方法
            //引用System.Threading命名空间
            //实例化Thread类，并传入一个指向线程所要运行方法的委托。（这时候这个线程已经产生，但是还没有运行）
            //调用Thread实例的Start方法，标记该线程可以被CPU执行了，但具体执行时间由CPU决定。


            //前台线程：只有所有的前台线程都关闭才能完成程序关闭。
            //后台线程：只要所有的前台线程结束，后台线程自动结束。



            Process[] pros = Process.GetProcesses();
            //foreach (var pro in pros)
            //{
            //    Console.WriteLine(pro.ToString());
            //}

            foreach (var item in pros)
            {
                Console.WriteLine(item.ProcessName);       //当前运行程序的程序名
            }

            //用进程来启动应用程序，调用Process的静态方法
            //Process.Start("photoshop");
            //Process.Start("iexplore","http://www.google.com");

            //用进程来打开文件
            //第一步：封装要打开的文件，但是并不去打开这个文件
            ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\Foxulee\Desktop\ChIP-seq library info.docx");
            //创建进程对线
            Process pro = new Process();
            //高速进程要打开的文件信息
            pro.StartInfo = psi;
            //调用实例方法打开
            pro.Start();

            Thread.Sleep(3000);    //主线程暂停3000毫秒再继续执行后面的程序


            Console.ReadKey() ;
        }
    }
}
