<%@ WebHandler Language="C#" Class="ProcessEdit" %>

using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web;

public class ProcessEdit : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/plain";
        int userId;
        string userName = context.Request.Form["txtName"];
        string userPwd = context.Request.Form["txtPwd"];
        string userAge = context.Request.Form["txtAge"];

        if (int.TryParse(context.Request.Form["txtId"], out userId))
        {
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (
                    SqlCommand command =
                        new SqlCommand(
                            "update UserInfo set UserName=@UserName,UserAge=@UserAge, UserPwd=@UserPwd where UserId=@UserId",
                            conn))
                {
                    conn.Open();
                    SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@UserName", userName), new SqlParameter("@UserAge", userAge), new SqlParameter("@UserPwd", userPwd), new SqlParameter("@UserId", userId) };
                    command.Parameters.AddRange(parameters);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        context.Response.Redirect("UserInfoList.ashx");
                    }
                    else
                    {
                        context.Response.Redirect("Error.html");
                    }
                    
                }
            }
        }
        else
        {
            context.Response.Write("参数错误.");
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