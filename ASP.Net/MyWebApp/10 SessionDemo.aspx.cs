using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _10_SessionDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Session是服务端一种状态保持机制，可以将各种类型数据存储到Session,最终这些数据是存储到服务端器的内存中。
        if (IsPostBack)
        {
            Session["UserName"] = Request.Form["txtName"];
            Response.Redirect("10 SessionDemoTestUser.aspx");
        }
        //在网站中的某个页面给Session赋值以后，在网站的其它任意的页面中，都可以拿到SSession中存储的值。

        //Session的应用场景.就是用来存储登录用户的信息。用户在登录时，输入完成用户名密码以后，单击提交按钮，判断完用户名密码以后，将正确的用户的信息存储到Session中。Session["userInfo"],然后再其它页面中判断该Session的值，如果有值表示登录了，如果没有值表示没有登录。
    }
}