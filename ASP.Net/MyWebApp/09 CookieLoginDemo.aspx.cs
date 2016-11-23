using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _09_CookieLoginDemo : System.Web.UI.Page
{
    public string UserName { get; set; }
    public string UserPwd { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)   //post提交 
        {
            Response.Cookies["UserName"].Value = Request.Form["txtName"];
            Response.Cookies["UserName"].Expires = DateTime.Now.AddDays(3);
            Response.Cookies["Pwd"].Value = Request.Form["txtPwd"];
            Response.Cookies["Pwd"].Expires = DateTime.Now.AddDays(3);
        }
        else  //get提交
        {
            if (Request.Cookies["UserName"]!=null)  //later login
            {
                UserName = Request.Cookies["UserName"].Value;
                UserPwd = Request.Cookies["Pwd"].Value;
            }
        }
    }
}