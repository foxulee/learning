<%@ WebHandler Language="C#" Class="First" %>

using System;
using System.Web;

public class First : IHttpHandler {
    
        /// <summary>
        /// 程序员写的代码都放在这个方法里面
        /// </summary>
        /// <param name="context"></param>
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        context.Response.Write("Hello World");
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}