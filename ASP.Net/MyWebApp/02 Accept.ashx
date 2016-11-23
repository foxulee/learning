<%@ WebHandler Language="C#" Class="_02_Accept" %>

using System;
using System.Web;

public class _02_Accept : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        //接收表单提交过来的数据
        string userName = context.Request.Form["txtName"]; //如果是以post方式提交，那么在服务端接收表单数据是需要用到context.Request.Form，并且Form的名字就是表单name属性的值。
        //string userName = context.Request.QueryString["txtName"]; //如果是以post方式提交，则用context.Request.QueryString方式接收
        string userPwd = context.Request.Form["txtPwd"];
        context.Response.Write("你输入的用户名是："+userName+"，密码是："+userPwd);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}