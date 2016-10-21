using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql脚本参数化_防止sql注入漏洞_
{
    class Program
    {
        static void Main(string[] args)
        {
            //http://www.cnblogs.com/hkncd/archive/2012/03/31/2426274.html

            //注意次写法有sql注入漏洞，如果有参数的sql脚本需要用parameters来增加参数。错误写法！！！
            //sCmd.CommandText = string.Format("select UserID,UserName,CreateDate,UserPwd,LastErrorDateTime,ErrorTimes from UserInfo where UserName='{0}' and UserPwd='{1}'",txtUser.Text,txtPwd.Text);

            //正确写法所有sql脚本必须参数化！！！
            //sCmd.CommandText = "select UserID,UserName,CreateDate,UserPwd,LastErrorDateTime,ErrorTimes from UserInfo where UserName=@UserName and UserPwd=@UserPwd";
            //sCmd.Parameters.AddWithValue("@UserName", txtUser.Text);
            //sCmd.Parameters.AddWithValue("@UserPwd", txtPwd.Text);
        }
    }
}
