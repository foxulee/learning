using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习1__利用class打开不同文件
{
    class BaseFile
    {
        private string _filePath;      // 自动创建属性ctrl+R+E

        public string FilePath
        {
            get
            {
                return _filePath;
            }

            set
            {
                _filePath = value;
            }
        }

        public string FileName { get; set; }     //自动属性快捷键：prop+两下tab
        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="fileName"></param>
        public BaseFile(string filePath, string fileName)
        {
            this.FileName = fileName;
            this.FilePath = filePath;
        }

        //设计一个方法，用来打开指定的文件
        public void OpenFile()
        {
            ProcessStartInfo psi = new ProcessStartInfo(this.FilePath+"\\"+this.FileName);
            Process pro = new Process();
            pro.StartInfo = psi;
            pro.Start();
        }
          
    }
}
