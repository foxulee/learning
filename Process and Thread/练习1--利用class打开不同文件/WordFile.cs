using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习1__利用class打开不同文件
{
    class WordFile : BaseFile
    {
        public WordFile(string filePath, string fileName):base(filePath,fileName)
        { }
    }
}
