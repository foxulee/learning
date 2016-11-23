<%@ WebHandler Language="C#" Class="_02_Post_demo" %>

using System;
using System.IO;
using System.Web;

public class _02_Post_demo : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/html";
        string filePath = context.Request.MapPath("02 Post demo.html");
        string fileContent = File.ReadAllText(filePath);
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