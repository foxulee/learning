using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习__省市选择
{
    public class AreaInfo
    {
        public int AreaPId { get; set; }
        public string AreaName { get; set; }

        public int AreaID { get; set; }

        public override string ToString()
        {
            return AreaName;
        }
    }
}
