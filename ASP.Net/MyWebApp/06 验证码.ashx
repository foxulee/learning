<%@ WebHandler Language="C#" Class="_06_验证码" %>

using System;
using System.Web;

public class _06_验证码 : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/html";
        ValidateCode vCode = new ValidateCode();
        string code = vCode.CreateValidateCode(6);
        vCode.CreateValidateGraphic(code, context);
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}