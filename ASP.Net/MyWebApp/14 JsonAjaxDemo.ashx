<%@ WebHandler Language="C#" Class="_14_JsonAjaxDemo" %>

using System;
using System.Web;

public class _14_JsonAjaxDemo : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
            context.Response.Write("{\"Name\":\"testName\"}");
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}