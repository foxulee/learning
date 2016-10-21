using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionString_in_App.Config
{
    class Program
    {
        static void Main(string[] args)
        {
            //连接字符串必须放在配置文件中！！！
            //首先在项目中中添加System.Configuration程序集引用控制台和WinForm才需要，ASP.NET不需要，已经默认添加了）

            //方法1，在<AppSettings>节点中提供connectionString，在获取<AppSettings>节点中的数据
            string str1 = ConfigurationManager.AppSettings["SqlConn"];
            Console.WriteLine(str1);

            //方法2：获取connectionStrings节点中的数据
            string str2 = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            Console.WriteLine(str2);

            

            Console.ReadKey();

        }
    }
}
