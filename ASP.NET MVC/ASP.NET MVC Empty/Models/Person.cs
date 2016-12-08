using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_Empty.Models
{
    public class Person
    {
        public int Age { get; set; }
        public string QQ { get; set; }


        public void Run()
        {
        }


    }

    //扩展方法 :详细 http://hovertree.com/h/bjaf/bkb8kjqj.htm
    //定义扩展方法必须遵守两个Static和一个this：
    //1.必须把扩展方法定义在静态类中，每个扩展方法也必须声明为静态的
    //2.所有扩展方法必须要使用this关键字对第一个参数进行修饰
    public static class PersonExtension
    {
        public static void Say(this Person person, string age)   //表示Say方法被扩展到Person类的对象上去
        {
          
        }
    }
}