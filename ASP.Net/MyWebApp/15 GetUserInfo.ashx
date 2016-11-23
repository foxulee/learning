<%@ WebHandler Language="C#" Class="_15_GetUserInfo" %>

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Script.Serialization;

public class _15_GetUserInfo : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/plain";
        string connString = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        using (SqlConnection conn = new SqlConnection(connString))
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter("select * from UserInfo where DelFlag=1", conn))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                List<UserInfo> list = new List<UserInfo>();
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    UserInfo userInfo = new UserInfo();
                    userInfo.Id = Convert.ToInt32(dataTable.Rows[i]["UserId"]);
                    userInfo.UserName = dataTable.Rows[i]["UserName"].ToString();
                    userInfo.Age = dataTable.Rows[i]["UserAge"] != System.DBNull.Value ? dataTable.Rows[i]["UserAge"].ToString() : "unknown";
                    userInfo.Date = dataTable.Rows[i]["CreateDate"].ToString();
                    list.Add(userInfo);
                }

                JavaScriptSerializer jss = new JavaScriptSerializer();
                context.Response.Write(jss.Serialize(list));
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