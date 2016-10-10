using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace 正则表达式_Regular_expression
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            C#中为正则表达式的使用提供了非常强大的功能，这就是Regex类。这个包包含于System.Text.RegularExpressions命名空间下面，而这个命名空间所在DLL基本上在所有的项目模板中都不需要单独去添加引用，可以直接使用。

            1、定义一个Regex类的实例


            Regex regex = new Regex(@"\d");
            这里的初始化参数就是一个正则表达式，“\d”表示配置数字。

            2、判断是否匹配

            判断一个字符串，是否匹配一个正则表达式，在Regex对象中，可以使用Regex.IsMatch(string)方法。

            regex.IsMatch("abc"); //返回值为false，字符串中未包含数字
            regex.IsMatch("abc3abc"); //返回值为true，因为字符串中包含了数字

            3、获取匹配次数

            使用Regex.Matches(string)方法得到一个Matches集合，再使用这个集合的Count属性。

            regex.Matches("abc123abc").Count;
            返回值为3，因为匹配了三次数字。

            4、获取匹配的内容

            使用Regex.Match(string)方法进行匹配。

            regex.Match("abc123abc").Value;
            返回值为1，表示第一个匹配到的值。

            5、捕获

            正则表达式中可以使用括号对部分值进行捕获，要想获取捕获的值，可以使用Regex.Match(string).Groups[int].Value来获取。

            Regex regex = new Regex(@"\w(\d*)\w"); //匹配两个字母间的数字串
            regex.Match("abc123abc").Groups[0].Value; //返回值为“123”。

            6、正则表达式规则详解
            http://www.cnblogs.com/morvenhuang/archive/2008/03/23/1118423.html#!comments
            */



            //string x = "1024";
            //string y = "+1024";
            //string z = "1,024";
            //string b = "-1024";
            //string c = "10000";

            //Regex rx = new Regex(@"^\+?[1-9],?\d{3}$");
            //Console.WriteLine("x match count: {0}", rx.Matches(x).Count);
            //Console.WriteLine("y match count: {0}", rx.Matches(y).Count);
            //Console.WriteLine("z match count: {0}", rx.Matches(z).Count);
            //Console.WriteLine("b match count: {0}", rx.Matches(b).Count);
            //Console.WriteLine("c match count: {0}", rx.Matches(c).Count);

            //MatchCollection mc = Regex.Matches("今天是2016年9月27号",@"\d{1,4}");
            //foreach (var item in mc)
            //{
            //    if (mc!=null)
            //    {
            //        Console.WriteLine(item.ToString());
            //    }
            //}

            //Match mc1= Regex.Match("今天是2016年9月27号", @"\d{1,4}");
            //if (mc1.Success)
            //{
            //    Console.WriteLine(mc1.Value);
            //}

            //一种写法：
            //Regex r = new Regex(@"\d{1}");
            //string str1=r.Replace("今天是2016年9月27号","*");

            //另一种写法：
            //string str2 = Regex.Replace("今天是2016年9月27号", @"\d{1}", "*");
            //Console.WriteLine("str1: {0}", str1);
            //Console.WriteLine("str2: {0}", str2);


            //提取分组
            //string regex = @"(\w+)@(\w+)(\.\w+){1,2}";
            //Match mc2 = Regex.Match("abc123@qq.com",regex);
            //if (mc2.Success)
            //{
            //    Console.WriteLine(mc2.Groups[0]);      //序号为0的是所匹配的全长字符串
            //    Console.WriteLine(mc2.Groups[1]);      //分组的从序号1开始！！！
            //    Console.WriteLine(mc2.Groups[2]);
            //    Console.WriteLine(mc2.Groups[3]);
            //}
            //Console.ReadKey();



            //练习1：提取网页中的所有email
            //WebClient web = new WebClient();
            ////string html = web.DownloadString(@"C:\Users\Foxulee\Desktop\大家留下email交友吧_email_天涯部落.html");           //注意：用DownloadString的方法只能显示英文，中文有乱码，如要正确显示中文，应该用DownloadData,如下：
            //byte[] buffer = web.DownloadData(@"C:\Users\Foxulee\Desktop\大家留下email交友吧_email_天涯部落.html");
            //string html = Encoding.UTF8.GetString(buffer);

            //MatchCollection mc = Regex.Matches(html, @"[0-9a-zA-Z_\-\.]+@\w+\.[0-9a-zA-Z]+(\.[0-9a-zA-Z]+){0,3}");
            //foreach (Match item in mc)
            //{
            //    if (item.Success)
            //    {
            //        Console.WriteLine(item.Value);
            //    }
            //}
            //Console.Write("\n");
            //Console.WriteLine("Total email number is {0}.", mc.Count);
            //Console.ReadKey();



            //练习：下载页面所有图片
            //WebClient wb = new WebClient();
            //string website = wb.DownloadString(@"http://www.freshwatertropicalfishonline.com/l_series_plecostomus.php");
            
            //MatchCollection mc = Regex.Matches(website, @"<img.+?src.+?(?<link>images.+?\.jpg).+?>");
            //int i = 0;
            //foreach (Match item in mc)
            //{
            //    if (item.Success)
            //    {
            //        i++;
            //        string downloadAddress = @"http://www.freshwatertropicalfishonline.com/" + item.Groups["link"].Value;
            //        string fileName = @"C:\Users\Foxulee\Desktop\download pics\"+i+@".jpg";
            //        wb.DownloadFile(downloadAddress,fileName);
            //        Console.WriteLine("Picture {0} downloaded sucessfully!", i);
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("{0} pictures have been downloaded sucessfully!", i);
            //Console.ReadKey();



        }
    }
}
