<%@ WebHandler Language="C#" Class="_11_AjaxDemo" %>

using System;
using System.Web;

public class _11_AjaxDemo : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        context.Response.Write(DateTime.Now.ToString());
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}