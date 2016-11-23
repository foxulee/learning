<%@ WebHandler Language="C#" Class="_03_practiceSelfAdd" %>

using System;
using System.IO;
using System.ServiceModel.Configuration;
using System.Web;

public class _03_practiceSelfAdd : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/html";
        string filePath = context.Request.MapPath("03 practiceSelfAdd.html");
        string fileContent = File.ReadAllText(filePath);

        if (context.Request.Form["txtNum"] == null)
        {
            fileContent = fileContent.Replace("$Num", "");
            context.Response.Write(fileContent);
            return;
        }

        try
        {
            int num = Convert.ToInt32(context.Request.Form["txtNum"]) + 1;
            fileContent = fileContent.Replace("$Num", num.ToString());
            context.Response.Write(fileContent);
        }
        catch
        {

            fileContent = fileContent.Replace("$Num", "");
            context.Response.Write(fileContent);

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