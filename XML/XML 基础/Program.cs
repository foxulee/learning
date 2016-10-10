using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML_基础
{
    class Program
    {
        static void Main(string[] args)
        {
            //XML：eXtensible Markup Language
            //什么是标记语言？什么是标记？
            //标记（markup）：文档中任何不想被打印输出的部分（不是真正的文档的内容，联想读书时做的“读书笔记”，在旁边写的注解等。）注解是注解，实际内容是实际内容。
            //标记的作用：传递了关于文档本身以外的额外信息。比如：标记文档的某部分该如何显示，某部分是什么意思等。重在数据，标记只是为了说明数据的含义而已。
            //常见的标记语言：SGML、HTML、XML
            //HTML与XML的区别与联系？
            //Xml作用与应用场合：xml数据存储，html数据展示。
            //语法、是否有预定义标签、各自的作用与意义
            //相关术语：标签、节点、根节点、元素、子元素、后代元素、属性、嵌套、命名空间、字符数据（CDATA）

            //DOM方法创建XML文档
            //1、穿件一个XML对象
            XmlDocument doc = new XmlDocument();      // using System.Xml;
            //2、创建第一行描述信息
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0","utf-8",null);
            //3、将创建的第一行数据添加到文档中
            doc.AppendChild(dec);
            //4、给文档添加根节点
            XmlElement books = doc.CreateElement("Books");
            //5、将根节点添加给文档对象
            doc.AppendChild(books);

            //6、给根节点添加子节点
            XmlElement book1 = doc.CreateElement("Book");
            //将子节点book1添加到根节点下
            books.AppendChild(book1);

            //7、给book1添加子节点
            XmlElement bookName1 = doc.CreateElement("BookName");
            //8、设置标签中显示的文本
            bookName1.InnerText = "水浒传";
            book1.AppendChild(bookName1);

            XmlElement author1 = doc.CreateElement("Author");
            author1.InnerText = "匿名";
            book1.AppendChild(author1);

            XmlElement price1 = doc.CreateElement("Price");
            price1.InnerXml = "100RMB";
            book1.AppendChild(price1);

            XmlElement dec1 = doc.CreateElement("Dec");
            dec1.InnerXml = "好看！";
            book1.AppendChild(dec1);
            


            doc.Save(@"Books(DOM生成).xml");     //以相对路径保存，在bin/Dedug文件夹下
            Console.WriteLine("生成成功");
            Console.ReadKey();


        }
    }
}
