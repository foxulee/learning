using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace 基本概念
{
    class Program
    {
        static void Main(string[] args)
        {
            //C#委托及事件处理机制浅析: http://blog.sina.com.cn/s/blog_5f30147a010111y1.html

            //C# 委托、事件与Lambda表达式: http://sighingnow.github.io/编程语言/c_sharp_delegate_event_lambda.html

            //
            var list = new List<int>() { 1,2,45,5,6,7,8,9,9,0,3,4,25,23,5,235,231};
            var listRes = list.Where(name=>name >= 2);
            foreach (var item in listRes)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

            
        }
    }
}
