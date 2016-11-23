<%@ WebHandler Language="C#" Class="DeleteUserInfo" %>

using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web;

public class DeleteUserInfo : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/html";
        int userId;
        if (int.TryParse(context.Request.QueryString["UserId"], out userId))
        {
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand command = new SqlCommand("update UserInfo set DelFlag=0 where UserId=@UserId", conn))
                {
                    conn.Open();

                    command.Parameters.Add(new SqlParameter("@UserId", userId));
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
            context.Response.Write("此用户不存在！");
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