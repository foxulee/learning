using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 练习__LoginLock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //连接数据库
            string connStr = ConfigurationManager.ConnectionStrings["SqlConnString"].ConnectionString;
            
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand sCmd = conn.CreateCommand())
                {
                    conn.Open();

                    //注意次写法有sql注入漏洞，如果有参数的sql脚本需要用parameters来增加参数。
                    //sCmd.CommandText = string.Format("select UserID,UserName,CreateDate,UserPwd,LastErrorDateTime,ErrorTimes from UserInfo where UserName='{0}' and UserPwd='{1}'",txtUser.Text,txtPwd.Text);

                    //此方法解决sql注入漏洞
                    sCmd.CommandText = "select UserID,UserName,CreateDate,UserPwd,LastErrorDateTime,ErrorTimes from UserInfo where UserName=@UserName and UserPwd=@UserPwd";
                    sCmd.Parameters.AddWithValue("@UserName", txtUser.Text);
                    sCmd.Parameters.AddWithValue("@UserPwd", txtPwd.Text);



                    //判断是否有查询出数据

                    UserInfo user = null;
                    
                    using (SqlDataReader reader = sCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user= new UserInfo();
                            user.Id = int.Parse(reader["UserID"].ToString());
                            user.UserName = reader["UserName"].ToString();
                            user.UserPwd = reader["UserPwd"].ToString();
                            user.LastErrorDateTime = DateTime.Parse(reader["LastErrorDateTime"].ToString());
                            user.ErrorTimes=int.Parse(reader["ErrorTimes"].ToString());

                        }

                    }  //！！！注意：括号执行结束之前，数据库连接一直没有关闭，reader一直占用Connection对象，所以不能在内部用Command对性

                    //如果没有数据
                    if (user==null)
                    {
                        sCmd.CommandText =
                            string.Format(
                                "update UserInfo set ErrorTimes=ErrorTimes+1, LastErrorDateTime=getdate() where UserName='{0}'",txtUser.Text.Trim());   //增加错误次数 修改error时间
                        int rowsAffected = sCmd.ExecuteNonQuery();
                        //如果用户名存在，密码错误
                        if (rowsAffected>=1)
                        {
                            sCmd.CommandText = string.Format("select ErrorTimes from UserInfo where UserName='{0}'",
                                txtUser.Text);
                            object o = sCmd.ExecuteScalar();
                            int leftTimes = 3-Convert.ToInt32(o);
                            if (leftTimes>=0)
                            {
                                MessageBox.Show("密码错误，还可以输入" + leftTimes + "次.");
                            }
                            else
                            {
                                MessageBox.Show("登录错误超过三次，请15分钟再尝试。");
                            }
                            
                        }
                        //如果用户名不存在
                        else
                        {
                            MessageBox.Show("此用户名不存在！");
                        }
                        return;
                    }// end if isHasData

                    //如果有数据，检验错误时间和错误次数
                    
                    if (user.ErrorTimes<3 || DateTime.Now.Subtract(user.LastErrorDateTime).Minutes>15 )
                    {
                        MessageBox.Show("登录成功！");
                        sCmd.CommandText = string.Format("update UserInfo set ErrorTimes=0 where UserId='{0}'", user.Id);
                        sCmd.ExecuteNonQuery();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("登录错误超过三次，请15分钟再尝试。");
                        return;
                    }
                    
                   

                }
            }

        }
    }
}
