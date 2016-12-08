using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Empty.Controllers
{
    public class AJAXDemoController : Controller
    {
        // GET: AJAXDemo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CalcAdd(int num1,int num2)
        {
            return Content((num1+num2).ToString());
        }

        public ActionResult CalcAdd1(int num1, int num2)
        {
           object obj = new    //匿名对象
            {
                Sum=num1+num2    //定义匿名对象的属性
            };
            return Json(obj,JsonRequestBehavior.AllowGet);
        }

    }
}