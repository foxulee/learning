using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @namespace
{
    class Program
    {
        static void Main(string[] args)
        {

            //�   namespace（命名空间），用于解决类重名问题，可以看做“类的文件夹”。
            //� 在代码中使用其他类的时候需要using类所在的namespace。System.Collections.ArrayList，快速引入的方法，右键→解析（Ctrl+.）。
            //� 为什么使用Convert、Console等类不需要自己写using？
            //� 如果代码和被使用的类在一个namespace则不需要using。
            //� 可以修改默认的namespace，因此不要认为在相同文件夹下就不用using，不在相同文件夹下就需要using。
            //� 类内部定义的类的引用：namespace+外部类名+内部类名

        }
    }
}
