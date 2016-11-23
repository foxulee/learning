<%@ WebHandler Language="C#" Class="AddUserInfo" %>

using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Web;

public class AddUserInfo : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/html";
        string userName = context.Request.Form["txtName"];
        string userPwd = context.Request.Form["txtPwd"];
        string userAge = context.Request.Form["txtAge"];
        string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        using (SqlConnection conn = new SqlConnection(connStr))
        {
            using (SqlCommand command = new SqlCommand("insert into UserInfo (UserName, UserAge,UserPwd) values (@userName,@userAge,@userPwd)", conn))
            {
                conn.Open();
                SqlParameter[] sqlParameters = new SqlParameter[] { new SqlParameter("@userName", userName), new SqlParameter("@userAge", userAge), new SqlParameter("@userPwd", userPwd) };
                command.Parameters.AddRange(sqlParameters);
                if (command.ExecuteNonQuery()>0)
                {
                        //如果添加成功跳转到列表页面
                    context.Response.Redirect("UserInfoList.ashx");
                }
                else
                {
                    context.Response.Redirect("Error.html");
                }
            }
        }


    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}