<%@ WebHandler Language="C#" Class="EditUserInfo" %>

using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Web;

public class EditUserInfo : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/html";
        string userId = context.Request.QueryString["UserId"];
        string userName = context.Request.QueryString["UserName"];
        string userPwd = context.Request.QueryString["UserPwd"];
        string userAge = context.Request.QueryString["UserAge"];
        string filePath = context.Request.MapPath("EditUserInfo.html");
        string fileContent = File.ReadAllText(filePath);
        fileContent = fileContent.Replace("@UserName", userName).Replace("@UserAge", userAge).Replace("@UserPwd", userPwd).Replace("@UserId",userId);
        context.Response.Write(fileContent);

        
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}