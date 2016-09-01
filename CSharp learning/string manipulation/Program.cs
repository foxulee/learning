using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //� C#中单个字符用单引号包含就是char类型，（'a'），单引号中放且只能放一个字符。
            //� 单个字符也可以表示为字符串，还可以有长度为0的字符串
            //� 使用s.Length属性来获得字符串中的字符个数 （类似于数组的用法。）
            //� string可以看做是char的只读数组,不可更改。char c = s[1];。例子：遍历输出string中的每个元素。
            //� C#中字符串有一个重要的特性：不可变性，字符串一旦声明就不再可以改变。所以只能通过索引来读取指定位置的char，不能对指定位置的char进行修改。
            //� 如果要对char进行修改，那么就必须创建一个新的字符串，用s.ToCharArray()方法得到字符串的char数组，对数组进行修改后，调用new string(char[])这个构造函数（暂时不用细研究）来创建char数组的字符串。一旦字符串被创建，那么char数组的修改也不会造成字符串的变化。例子：将字符串中的A替换为a。

            string str = "hello";
            Console.WriteLine(str.Length);
            Console.WriteLine(str[0]);
            Console.ReadKey();

            ////�遍历字符串
            //foreach (char s in str)
            //{
            //    Console.WriteLine(s);
            //}
            //Console.ReadKey();



            ////�更改字符串的内容
            //char[] chars= str.ToCharArray();
            //chars[0] = 'a';
            //string strNew = new string(chars);                       //new string()函数把char数组组合成新的字符串。
            //Console.WriteLine(strNew);


            //�ToLower()：得到字符串的小写形式。  注意字符串是不可变的，所以这些函数都不会直接改变字符串的内容，而是把修改后的字符串的值通过函数返回值的形式返回。s.ToLower()与s = s.ToLower()


            //�ToUpper()：得到字符串的大写形式



            //�Trim()去掉字符串两端的空白。


            ////�s1.Equals(s2, StringComparison.OrdinalIgnoreCase)，两个字符串进行比区分大小写的比较。
            //bool isEqual1 = "abc" == "ABC";
            //bool isEqual2 = "abc".Equals("ABC", StringComparison.OrdinalIgnoreCase);
            //Console.WriteLine("isEquals is "+isEqual1);
            //Console.WriteLine("isEqual2 is "+isEqual2);


            ////�string[] Split(params char[] separator)：将字符串按照指定的分割符分割为字符串数组；
            //string str1 = "aaa,ddd,fcd,dds.gdg//dfd||dfd";
            //foreach (string s in str1.Split(',','.','/','|'))
            //{
            //    Console.WriteLine(s);
            //}



            //�string[] Split(new char[] {'separator'}, StringSplitOptions options)将字符串按照指定的char分割符分割为字符串数组（ options 取RemoveEmptyEntries的时候移除结果中的空白字符串）


            //�string[] Split(new string[] {'separator'}, StringSplitOptions options)将字符串按照指定的string分割符分割为字符串数组。


            //练习：从日期字符串（"2008-08-08"）中分析出年、月、日；2008年08月08日。
            //string date = "2008-08-08";
            //string[] itemsInDate = date.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("{0}年{1}月{2}日",itemsInDate[0],itemsInDate[1],itemsInDate[2]);



            ////�字符串替换：<string>.Replace(string oldValue, string newValue), 将字符串中的出现oldValue的地方替换为newValue。例子：名字替换。
            //string str2 = "李时珍是一个好同志，向李时珍同志学习";
            //string strNew = str2.Replace("李时珍","李素丽");
            //Console.WriteLine(strNew);



            //�插入字符 insert()的用法: < string >.insert(参数1, 参数2) 参数1为插入子字符串的其实位置,参数2为要插入的子字符串



            ////�取子字符串：<string>.Substring(int startIndex)，取从位置startIndex开始一直到最后的子字符串；string Substring(int startIndex, int length)，取从位置startIndex开始长度为length的子字符串，如果子字符串的长度不足length则报错。
            //string link = "http://www.baidu.com";
            //string domain = link.Substring(7);
            //Console.WriteLine(domain);
            //Console.WriteLine(link.Substring(7,5));
            //Console.WriteLine(link.Substring(7,10));



            ////�bool Contains(string value)判断字符串中是否含有子串value
            //string str2 = "我的社会真和谐啊！";
            //if (str2.Contains("社会"))
            //{
            //    Console.WriteLine("含有敏感词汇，请文明用语！");
            //}



            ////�bool StartsWith(string value)判断字符串是否以子串value开始；bool EndsWith (string value)判断字符串是否以子串value结束；
            //string str3 = "http://www.cctv.com";
            //if (str3.StartsWith("http://"))
            //{
            //    Console.WriteLine("是网址。");
            //}



            ////�int IndexOf(string value)：取子串value第一次出现的位置。如果没有则返回-1.
            //string str4 = "你好，我是王某某";
            //int i = str4.IndexOf("我是");
            //int j = str4.IndexOf("他是");
            //Console.WriteLine(i);
            //Console.WriteLine(j);



            //练习1：接收用户输入的字符串，将其中的字符以与输入相反的顺序输出。"abc"→"cba"
            //string str5 = "abc";
            //char[] chars=str5.ToArray();
            //Array.Reverse(chars);                                      // 原地将数组反向，Array.Reverse(name of array)
            //string str5New = new string(chars);
            //Console.WriteLine(str5New);


            //课上练习2：接收用户输入的一句英文，将其中的单词以反序输出。"hello c sharp"→"sharp c hello"
            //Console.WriteLine("Your content:");
            //string inputStr = Console.ReadLine();
            //string reversedStr=string.Join(" ", inputStr.Trim().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Reverse());  //string.join(" seperator ", 数组名)是将指定数组中的元素用seperator连接在一起生成字符串。
            //Console.WriteLine(reversedStr);


            //练习3：从Email中提取出用户名和域名：abc@163.com。IndexOf 找到 @的位置。SubString。
            //string email = "abc@163.com";
            //int numOfAt = email.IndexOf("@");
            //string userName = email.Substring(0, numOfAt);
            //string domainName = email.Substring(numOfAt+1, email.Length - numOfAt-1);
            //Console.WriteLine("User name is {0}, and domain name is {1}",userName,domainName);


            //练习4：文本文件中存储了多个文章标题、作者，标题和作者之间用若干空格（数量不定）隔开，每行一个，标题有的长有的短，输出到控制台的时候最多标题长度20，如果超过20，则截取长度17的子串并且最后添加“...”，加一个竖线后输出作者的名字。

            //string[] fileContent=Console.ReadLine().Split(new string[] { "\n"}, StringSplitOptions.RemoveEmptyEntries);
            //foreach (string lines in fileContent)
            //{
            //    string[] lineContent = lines.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            //    foreach (string item in lineContent)
            //    {
            //        if (lineContent.Length<20)
            //        {
            //            Console.WriteLine(lineContent[0]+"|"+lineContent[1]);
            //        }
            //        else
            //        {
            //            Console.WriteLine(lineContent[0].Substring(0,17)+"...|"+lineContent[1]);
            //        }
                    
            //    }
                    
            //}







            Console.ReadKey();
        }
    }
}
