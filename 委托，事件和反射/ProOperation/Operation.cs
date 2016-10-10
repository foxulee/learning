using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProOperation
{
    public abstract class Operation
    {
        public int NumOne { get; set; }
        public int NumTwo { get; set; }
        public Operation(int num1, int num2)
        {
            this.NumOne = num1;
            this.NumTwo = num2;

        }

        //记录子类的计算类型
        public abstract string Type
        { get; }

        //获得计算结果
        public abstract int GetResult();
          
           
    }
}
