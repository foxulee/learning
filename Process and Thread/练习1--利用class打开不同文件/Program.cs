using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习1__利用class打开不同文件
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要打开的文件所在的路径");
            string filePath = Console.ReadLine();
            Console.WriteLine("请输入要打开的文件的名字");
            string fileName = Console.ReadLine();

            //通过简单工厂设计模式返回父类
            BaseFile bf = GetFile(filePath,fileName);
            if (bf!=null)
            {
                bf.OpenFile();
            }
            Console.ReadKey();

        }

        static BaseFile GetFile(string filePath, string fileName)
        {
            BaseFile baseFile = null;
            string strExtension = Path.GetExtension(fileName);
            switch (strExtension)
            {
                case ".txt":
                    baseFile=new TxtFile(filePath,fileName);
                    break;
                case ".MP4":
                    baseFile = new MP4File(filePath, fileName);
                    break;
                case ".Avi":
                    baseFile = new AviFile(filePath, fileName);
                    break;
                case ".docx":
                    baseFile = new WordFile(filePath,fileName);
                    break;
              
            }
            return baseFile;

        }
    }
}
