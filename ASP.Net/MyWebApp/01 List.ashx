<%@ WebHandler Language="C#" Class="List" %>

using System;
using System.IO;
using System.Web;

public class List : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/html";
        //从数据库中查询出用户的信息。替换模版List.html文件中的占位符（$UserName）
        //找到模版文件
        string filepath = context.Request.MapPath("List.html"); //获取文件的物理路径.在操作文件或文件夹时一定要获取物理路径。physical path
        //读取文件的内容
        string fileContent = File.ReadAllText(filepath);
        fileContent = fileContent.Replace("$UserName", "Charlie");
        fileContent = fileContent.Replace("$UserPwd", "123456");
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