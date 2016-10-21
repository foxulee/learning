using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataAdapter_____WinformDataGridView
{
    //data model 每一table都建一个类
    public class UserInfo
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int UserAge { get;  set; }
        public short DelFlag { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastErrorDateTime { get; set; }
        public int ErrorTimes { get; set; } 
        
    }
}
