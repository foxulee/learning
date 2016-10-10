using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_System
{
    class Program
    {
        static void Main(string[] args)
        {
            //基本操作：判存、复制、移动、删除
            //需要using System.IO调用File类;
            //基本方法：
            //File.Exist(@"D:\360Downloads\HotFix\test.txt");                        //判断文件是否存在
            //File.Copy(“source”, “targetFileName”, true);                          //文件拷贝,true表示当文件存在时“覆盖”，如果不加true,则文件存在报异常。
            //File.Move(“source”, “target”);                                        //移动（剪切）
            //File.Delete(“path”);                                                  //删除。如果文件不存在？不存在，不报错
            //File.Create(“path”);                                                  //创建文件


            //文本文件编码，文本文件有不同的存储方式，将字符串以什么样的形式保存为二进制，这个就是编码，UTF - 8、ASCII、Unicode等，如果出现乱码一般就是编码的问题，文本文件相关的函数一般都有一个Encoding类型的参数，取得编码的方式：Encoding.Default、Encoding.UTF8、Encoding.GetEncoding("GBK")
            //输出Encoding.GetEncodings()，所有编码。
            //什么是文本文件。拖到记事本中还能看得懂的就是文本文件，doc不是。
            //常用静态方法
            //void AppendAllText(string path, string contents)，
            //将文本contents附加到文件path中
            //bool Exists(string path)判断文件path是否存在
            //string[] ReadAllLines(string path) 读取文本文件到字符串数组中
            //string ReadAllText(string path) 读取文本文件到字符串中
            //void WriteAllText(string path, string contents)
            //将文本contents保存到文件path中，会覆盖旧内容。
            //WriteAllLines(string path, string[] contents)，
            //将字符串数组逐行保存到文件path中，会覆盖旧内容。

            #region 读取文件
            ///���三种读file数据的方法。
            //string[] str1 = File.ReadAllLines(@"D:\360Downloads\HotFix\test.txt", Encoding.Default);    //以行的形式读取，存到字符串数组中。Encoding.Default操作系统默认的编码格式
            //string str2 = File.ReadAllText(@"D:\360Downloads\HotFix\test.txt", Encoding.Default);   //读取所有内容，存到字符串中。注意二者返回值的区别。这两种方法只能读文本文件.txt.
            //                                                                                        //�如果要对某行数据进行操作，用ReadAllLines.如果显示file内容，用ReadAllText.

            ////ReadAllBytes除了txt，还可以读取所有类型文件。
            //byte[] buffer = File.ReadAllBytes(@"D:\360Downloads\HotFix\test.txt");   //将文件读取成字节存在字节数组中
            //string str = Encoding.Default.GetString(buffer);                 //把字节数组解码成我们认识的字符串，如果中文有乱码，Default换成UTF-8,再不行换成.GetEncoding("GBK")
            #endregion

            #region 写入文件
            //���覆盖写入，同样三种方法
            //File.WriteAllLines(@"D:\360Downloads\HotFix\test.txt",new string[] { "张三","李四","王五"});   //如果没有次文件，自动创建一个；如果有同名文件，内容将被覆盖。
            //File.WriteAllText(@"D:\360Downloads\HotFix\test.txt", "张三" );    //同上，也会覆盖原内容。
            //string str3 = "今天天气好晴朗，处处好风光";
            //byte[] buffer2= Encoding.Default.GetBytes(str3);                   //将字符串转换成字节数组。
            //File.WriteAllBytes(@"D:\360Downloads\HotFix\test.txt", buffer2);    //覆盖原内容。

            //���追加写入
            //File.AppendAllText(@"D:\360Downloads\HotFix\test.txt","追加成功",Encoding.GetEncoding("gb2312"));


            //非txt文件的复制粘贴(实际上就是先读，再写的过程)
            //byte[] buffer3=File.ReadAllBytes(@"D:\360Downloads\HotFix\test.wmv");
            //File.WriteAllBytes(@"C: \Users\Foxulee\Desktop\new.wmv", buffer3);       //粘贴后并重命名
            //                                                                         //File类此种方法虽简单，可以操作任何类型文件，但是只能操作小文件，耗时。操作大文件需要用文件流file stream.
            //File类是一次全部读完，filestream是一点一点的读。


            #endregion

            #region Directory操作
            //基本操作：创建、移动和删除的功能
            //需要命名空间using System.IO
            //Directory常用方法
            //CreateDirectory()
            //Move(“source”, “target”)
            //Delete(“path”,true)
            //Exist(“path”)
            //GetFiles(“path”[, string searchPattern][,searchOption])   //获得指定目录下所有或指定文件的路径，searchOption是否搜索子目录，返回字符串数组string[]
            //GetDirectories(“path”[, string searchPattern][,searchOption])   //获得指定目录下所有或指定文件夹的路径。

            //for (int i = 0; i < 10; i++)
            //{
            //    Directory.CreateDirectory(@"C:\a\"+i);
            //}

            //Directory.Delete(@"C:\a\",true);
            //Directory.GetFiles(@"C:\a\", "*.mp3");
            #endregion

            #region Path类操作
            //需要命名空间using System.IO
            //Path.GetFileName("Path")                  //获得指定文件的全名称
            //Path.GetFileNameWithoutExtension("Path")  //获得指定文件的全名称，不包含扩展名
            //Path.GetExtension("Path")                 //获得指定文件的扩展名
            //Path.GetDirectoryName("Path")             //获得指定文件所在的文件夹的路径
            //Path.GetFullPath("Path")                  //获得指定文件的绝对路径


            #endregion

            #region File Stream
            //FileStream用来操作大文件。File类用来操作小文件，一次都写进内存，文件大会耗尽内存。
            //FileStream：用来操作字节的，任何文件。
            //StreamWriter StreamReader：用来操作字符的，文本文件.txt

            //读取文件
            //第一步：创建一个FileStream的对象
            //FileStream fsRead = new FileStream("Path", FileMode.OpenOrCreate, FileAccess.Read);     //第一个参数表述操作文件的路径；第二个文件表示对文件做一个怎么样的操作；第三个参数表示对文件中的数据进行怎样的操作。
            //byte[] buffer = new byte[1024 * 1024 * 2];                     //创建2M的缓冲空间
            //int r = fsRead.Read(buffer, 0, buffer.Length);                 //第二个参数表示从...位置开始读取，第三个参数表示，一次读取多大，用buffer.Length表示能接收的最大值。返回的这个int类型表示这次读取实际读取到的字节数
            //string str = Encoding.Default.GetString(buffer,0,r);            //将字符数组转换成字符串。第二个参数表示从...位置开始读取，第三个参数表示要解码的长度，因为实际存储的空间会小于创建的空间，没有此参数，无用空间也会耗时地读取。
            //fsRead.close();               //关闭文件。
            //fsRead.Dispose();               // Garbage Collection无法自动释放资源。这两行code要手动写上，否则无法操作成功。



            //写文件
            //FileStream fsWrite = new FileStream(@"C:\Users\Foxulee\Desktop\1.txt",FileMode.OpenOrCreate,FileAccess.ReadWrite);
            //string s = "新加入内容";
            //byte[] buffer = Encoding.Default.GetBytes(s);                  //将字符串转换成字节数组
            //fsWrite.Write(buffer, 0, buffer.Length);
            //fsWrite.Close();
            //fsWrite.Dispose();


            //由于我们在使用FileStream的过程当中，经常会忘记写Close() Dispose(),所以微软提供给我们更为简单的方法帮助我们关闭流和释放流所占用的资源。就是将创建FileStream对象的过程写在using(){ }当中
            //using (FileStream fsWrite = new FileStream(@"C:\Users\Foxulee\Desktop\1.txt", FileMode.Append, FileAccess.Write)
            //{
            //    string s = "不替换";
            //    byte[] buffer = Encoding.Default.GetBytes(s);
            //    fsWrite.Write(buffer, 0, buffer.Length);
            //}


            //读写大文件
            //string resourse = @"C:\Users\Foxulee\Desktop\test.avi";
            //string target = @"D:\new.avi";
            //CopyFile(resourse, target);


            //StreamWriter和StreamReader
            //使用StreamReader来读取数据
            using (StreamReader sr=new StreamReader(@"C:\Users\Foxulee\Desktop\test.avi",Encoding.Default))
            {
                while (!sr.EndOfStream)                             //.EndOfStream 到文件末尾，返回bool类型true
                {
                    string str = sr.ReadLine();
                    Console.WriteLine(str);
                }
                
            }

            //使用StreamWriter写入数据
            using (StreamWriter sw = new StreamWriter(@"C:\new. txt", true))                    //加上true参数，表示append，没有的话，覆盖原内容。
            {
                sw.Write("不overwrite！");

            }

        #endregion



        }

        public static void CopyFile(string resourse, string target)
        {
            using (FileStream fsRead=new FileStream(resourse,FileMode.OpenOrCreate,FileAccess.Read))
            {
                using (FileStream fsWrite=new FileStream(target, FileMode.OpenOrCreate,FileAccess.Write))
                {
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    while (true)
                    {
                        int r = fsRead.Read(buffer, 0, buffer.Length);                     //本次读取实际读取到的有效字节数。如果没有读入内容，Read（）返回0给r
                        fsWrite.Write(buffer, 0, r);                                       //写入的时候，应该写入实际读取到的有效字节数。
                        if (r==0)
                        {
                            break;
                        }
                    }
                    
                }
            }
        }
    }

}
