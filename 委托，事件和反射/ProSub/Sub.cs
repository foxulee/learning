using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProSub
{
    public class Sub : ProOperation.Operation
    {
        public Sub(int num1, int num2) : base(num1, num2)
        {

        }

        public override string Type
        {
            get
            {
                return "-";
            }
        }

        public override int GetResult()
        {
            return this.NumOne-this.NumTwo;
        }
    }
}
