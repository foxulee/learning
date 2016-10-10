using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML文档的增删查改
{
    class Program
    {
        static void Main(string[] args)
        {
            //无论进行什么xml的操作，都要先创建一个xml对象
            XmlDocument doc = new XmlDocument();
            #region 对xml进行追加
            //首先判断xml文档是否存在 如果存在则追加 否则创建一个
            //if (File.Exists("student.xml"))
            //{
            //    //先加载文档到内存中，才能访问
            //    doc.Load("student.xml");
            //    //追加
            //    //获得根节点 给根节点添加子节点
            //    XmlElement person = doc.DocumentElement;

            //    XmlElement student = doc.CreateElement("student");
            //    student.SetAttribute("studentID", "10");
            //    person.AppendChild(student);

            //    XmlElement name = doc.CreateElement("Name");
            //    name.InnerText = "刘德华";
            //    student.AppendChild(name);

            //    XmlElement age = doc.CreateElement("Age");
            //    age.InnerText = "18";
            //    student.AppendChild(age);

            //    XmlElement gender = doc.CreateElement("Gender");
            //    gender.InnerText = "男";
            //    student.AppendChild(gender);



            //}
            //else
            //{
            //    //不存在 则创建
            //    //创建第一行
            //    XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            //    doc.AppendChild(dec);

            //    XmlElement person = doc.CreateElement("Person");
            //    doc.AppendChild(person);
            //} 

            //doc.Save("student.xml");     //最后必须保存修改
            #endregion

            #region 读取查看xml的内容
            doc.Load("Orders.xml");
            //先获得根节点
            XmlElement orders = doc.DocumentElement;
            //获得根节点下面的所有子节点
            XmlNodeList xnl = orders.ChildNodes;

            //查看子节点的内容 <...>内容<.../>  但无法显示子节点内的属性
            foreach (XmlNode item in xnl)
            {
                Console.WriteLine(item.InnerText);
            }

            //查看子节点内的属性 <...属性/>
            XmlElement items = orders["Items"];
            XmlNodeList xnl2 = items.ChildNodes;
            foreach (XmlNode item in xnl2)
            {
                Console.WriteLine(item.Attributes["Name"].Value);
                Console.WriteLine(item.Attributes["Count"].Value);

                //    //重新赋值
                //    if (item.Attributes["Name"].Value == "手套")
                //    {
                //        item.Attributes["Count"].Value = "100new";
                //    }
            }

            //doc.Save("Orders.xml"); 
            #endregion

            #region 用Xpath的方式读取查看xml的内容
            //doc.Load("orders.xml");
            ////获得根节点
            //XmlElement orders = doc.DocumentElement;

            //XmlNode xn = orders.SelectSingleNode("/Order/Items/OrderItem[@Name='雨衣']");
            //xn.Attributes["Count"].Value = "new1000";

            //doc.Save("orders.xml"); 
            #endregion

            #region 删除xml文档中的特定内容
            //    doc.Load("orders.xml");
            ////找到根节点
            //XmlElement order = doc.DocumentElement;
            ////doc.RemoveAll(); 不行 跟节点不允许删除！！！
            ////order.RemoveAll(); 移除根节点下所有的子节点

            //XmlNode xn = order.SelectSingleNode("/Order/Items/OrderItem[@Name='手套']");

            ////获得Items节点
            //XmlNode items = order["Items"];//order.SelectSingleNode("/Order/Items");

            ////items.RemoveChild(xn);移除当前子节点

            ////xn.Attributes.RemoveNamedItem("Count"); 移除某一个子节点的某一属性

            //doc.Save("orders.xml"); 
            #endregion


            Console.WriteLine("保存成功！");
            Console.ReadKey();
        }
    }
}
