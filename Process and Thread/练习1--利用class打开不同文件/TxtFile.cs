using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习1__利用class打开不同文件
{
    class TxtFile : BaseFile
    {
        //重写父类的构造函数，因为父类默认的无参构造函数被有参的重写了，所以子类需要重写
        public TxtFile(string filePath, string fileName) : base(filePath, fileName)
        {     }
        
    }
}
