using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习1__利用class打开不同文件
{
    class MP4File : BaseFile
    {
        public MP4File(string filePath, string fileName) : base(filePath, fileName)
        { }
    }
}
