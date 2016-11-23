<%@ WebHandler Language="C#" Class="_15_GetUserDetail" %>

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Script.Serialization;

public class _15_GetUserDetail : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/plain";
        string id = context.Request["id"];
        string connString = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        using (SqlConnection conn = new SqlConnection(connString))
        {
            using (SqlCommand command = new SqlCommand("select * from UserInfo where UserId=@id", conn))
            {
                conn.Open();
                List<UserInfo> list = new List<UserInfo> { };
                command.Parameters.Add(new SqlParameter("@id", id));
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    UserInfo userInfo =new UserInfo();
                    userInfo.Id = Convert.ToInt32(reader["UserId"]);
                    userInfo.UserName = reader["UserName"].ToString();
                    userInfo.Age = reader["UserAge"] != System.DBNull.Value ? reader["UserAge"].ToString() : "unknown";
                    userInfo.Date = reader["CreateDate"].ToString();

                    list.Add(userInfo);
                    JavaScriptSerializer jss = new JavaScriptSerializer();
                    context.Response.Write(jss.Serialize(list));
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