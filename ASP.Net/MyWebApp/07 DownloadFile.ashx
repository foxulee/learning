<%@ WebHandler Language="C#" Class="_07_DownloadFile" %>

using System;
using System.Web;

public class _07_DownloadFile : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/html";
        string encodeFileName = HttpUtility.UrlEncode("DownloadFile/test.txt"); //国际通用防止产生乱码。生成ASCII
        context.Response.AddHeader("Content-Disposition", String.Format("attachment;filename=\"{0}\"", encodeFileName)); //在响应头中加上Content-Diposition, attchment表示以附件形式下载。
        context.Response.WriteFile("DownloadFile/test.txt"); //输出文件内容
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}