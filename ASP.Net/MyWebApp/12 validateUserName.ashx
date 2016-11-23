<%@ WebHandler Language="C#" Class="_12_validateUserName" %>

using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web;

public class _12_validateUserName : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/plain";
        string name = context.Request["name"];
        string connString = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        using (SqlConnection conn = new SqlConnection(connString))
        {
            using (SqlCommand command = new SqlCommand("select count(*) from UserInfo where UserName=@name", conn))
            {
                conn.Open();
                SqlParameter parameter = new SqlParameter("@name", name);
                command.Parameters.Add(parameter);
                int num = (int) command.ExecuteScalar();
                if (num >0)
                {
                    context.Response.Write("此用户名已存在");
                }
                else
                {
                    context.Response.Write("此用户名可用");
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