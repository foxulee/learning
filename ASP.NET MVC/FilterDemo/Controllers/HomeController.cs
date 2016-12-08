using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
using FilterDemo.Filters;

namespace FilterDemo.Controllers
{
    //[MyAuthorizatioin] //放在此处，对当前controller下的所有action添加filter
    //如果想对所有的controller应用filter，可以在App_Start/FilterConfig.cs中设置
    public class HomeController : Controller
    {
        // GET: Home

        //过滤器的第一种实现方式(推荐此种方式)：自定义类继承自相应的类或接口，重写方法，作为特性使用

        [MyAuthorizatioin]   //仅对当前的Action添加filter，在当前action执行前，会执行身份验证fitler
        public ActionResult Index()
        {
            //test Error filter: throw  new Exception();
            return View();
        }


        //过滤器的第二种实现方式，重写controller的方法，这样会应用于所有的action
        protected override void OnAuthentication(AuthenticationContext filterContext)
        {
            filterContext.HttpContext.Response.Write("Filter defined in controller! ");
        }
    }
}