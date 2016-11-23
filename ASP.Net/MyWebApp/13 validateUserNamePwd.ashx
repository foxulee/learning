<%@ WebHandler Language="C#" Class="_13_validateUserNamePwd" %>

using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web;

public class _13_validateUserNamePwd : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        string name = context.Request["name"];
        string pwd = context.Request["pwd"];
        string connString = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        using (SqlConnection conn = new SqlConnection(connString))
        {
            using (SqlCommand command = new SqlCommand("select count(*) from UserInfo where UserName=@name and UserPwd=@pwd", conn))
            {
                conn.Open();
                SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@name", name), new SqlParameter("@pwd", pwd), };
                command.Parameters.AddRange(parameters);
                int num = (int) command.ExecuteScalar();
                if (num >0)
                {
                    context.Response.Write("yes");
                }
                else
                {
                    context.Response.Write("no");
                }

            }
        }
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}