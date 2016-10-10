using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProOperation;
using ProAdd;
using System.Reflection;
using System.IO;

namespace ProFactory
{
    public class Factory
    {
        //简单工厂模式 返回父类， 但其实父类中装的是子类对象
        public static Operation Getoper(string type, int num1, int num2)
        {
            Operation oper = null;
            //动态获得程序集dll
            //获得Plug文件夹的路径
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Plug");
            //获得path路径下所有文件的全路径
            string[] files = Directory.GetFiles(path, "*.dll");
            //遍历files，加载所有的程序集文件
            foreach (string file in files)
            {
                Assembly ass = Assembly.LoadFile(file);
                //获得程序集文件中所有公开的数据类型
                Type[] types = ass.GetExportedTypes();
                foreach (Type item in types)
                {
                    //判断当前数据类型是否我需要的类型, 是operation的子类，并且不是抽象对象
                    if (item.IsSubclassOf(typeof(Operation)) && !item.IsAbstract)
                    {
                        //创建子类对象 赋值给oper
                        oper = (Operation)Activator.CreateInstance(item, num1, num2);
                    }
                }

                if (type==oper.Type)
                {
                    break;
                }
                else
                {
                    oper = null;
                }
            }
            
            return oper;
        }
    }
}
