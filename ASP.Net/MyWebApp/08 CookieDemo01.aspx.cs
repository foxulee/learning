using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _08_CookieDemo01 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Cookie是一段文本，当用户通过浏览器访问我们网站时，我们的网站可以创建一个Cookie文本通过响应报文返回给浏览器。浏览器可以存储服务器返回的Cookie文本数据，存储的方式有两种：一种是存储在浏览器内存中，如果浏览器关闭，那么Cookie数据数据丢失了。另外一种可以指定过期时间，那么就可以将Cookie文本数据以文件的形式存在浏览器端磁盘上，只要没有过期，当用户下次再通过浏览器访问时，属性咱们网站的Cookie的数据会自动放在请求报文中发送过来。（与网站有关）

        //创建cookie，存在浏览器内存中
        Response.Cookies["cp1"].Value = DateTime.Now.ToString();

        //创建cookie丙炔指定过期事件，这些cookie数据会存到磁盘上
        Response.Cookies["cp2"].Value = "stored in disk";
        Response.Cookies["cp2"].Expires = DateTime.Now.AddDays(3); //3天后过期

        //删除cookie
        Response.Cookies["cp2"].Expires = DateTime.Now.AddDays(-1);//设置一个已经过了时的时间

        //关于Cookie的其它的属性；
        Response.Cookies["cp3"].Value = "cccccc";

        //Cookie的域：浏览器往后台发送数据时候，要把cookie放到请求报文里面去，发送到后台。
        //请求是子域的网页，那么主域的cookie会不会发送到后台呢？答案：是的。一块发送。如果请求时主域页面，子域的cookie是不会发送到后台的。如果子域想让请求主域页面的时候也一块发送到后台，设置当前Cookie的域为主域可以了。
        // Response.Cookies["cp3"].Domain = "baidu.com";//域（域名），跨域的问题。bai.com是主域，tieba.baidu.com是子域。在tieba子域下创建的cookie要想被主域baidu.com获取，需要指定domain
        Response.Cookies["cp3"].Path = "/CRUD";  //设置只允许CRUD文件夹下的文件获得cookie
        Response.Cookies["cp3"].Expires = DateTime.Now.AddDays(3);


        //什么时候用cookie？
        //1:保存上次登录时间等信息
        //2:保存用户名、密码，在一定时间不用重新登录
        //3：网上商城中的购物车


        //Cookie注意的问题
        //1:Cookie文件大小4KB
        //2：一个网站默认的最多创建20个Cookie.
        //3:某些浏览器会对访问的所有网站的Cookie限制为300.
        //4：创建Cookie另外一种方式:
        HttpCookie cookie1 = new HttpCookie("cp4", "saaaa");
        cookie1.Expires = DateTime.Now.AddDays(5);
        Response.Cookies.Add(cookie1);

        //5:多值Cookie  为了解决20个cookie的上限问题
        Response.Cookies["userInfo"]["userName"] = "patrick";
        Response.Cookies["userInfo"]["lastVisit"] = DateTime.Now.ToString();
        Response.Cookies["userInfo"].Expires = DateTime.Now.AddDays(1);


        //6:Cookie不安全。
        //Cookie尽量存储安全要求不高的数据。
        //一定要将需要存储的敏感的数据一定要加密以后存储到Cookie中。
    }
}