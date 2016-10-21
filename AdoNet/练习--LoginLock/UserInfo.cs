using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习__LoginLock
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserPwd { get; set; }
        public DateTime LastErrorDateTime { get; set; }
        public int ErrorTimes { get; set; }
    }
}
