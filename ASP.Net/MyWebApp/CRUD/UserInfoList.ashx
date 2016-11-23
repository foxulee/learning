<%@ WebHandler Language="C#" Class="UserInfoList" %>

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Web;

public class UserInfoList : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/html";
        string connString = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        using (SqlConnection conn = new SqlConnection(connString))
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter("select * from UserInfo where DelFlag=1", conn))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td><a href='MoreInfo.html'>More...</a></td><td><a  href='DeleteUserInfo.ashx?UserId={0}'>Delete</a></td><td><a href='EditUserInfo.ashx?UserId={0}&UserName={1}&UserPwd={2}&UserAge={3}'>Edit</a></td></tr>", dataTable.Rows[i]["UserId"], dataTable.Rows[i]["UserName"],dataTable.Rows[i]["UserPwd"],dataTable.Rows[i]["UserAge"]!=System.DBNull.Value?dataTable.Rows[i]["UserAge"]:"unknown",dataTable.Rows[i]["CreateDate"].ToString());  //get传值，点击超链接传值（不通过form）:href='DeleteUserInfo.ashx?UserId={0}  如果要传多个值，值之间用"&"连接
                }
                string filePath = context.Request.MapPath("UserInfoList.html");
                string fileContent = File.ReadAllText(filePath).Replace("$tbody", sb.ToString());
                context.Response.Write(fileContent);
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