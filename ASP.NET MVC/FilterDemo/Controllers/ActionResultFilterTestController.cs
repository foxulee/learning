using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilterDemo.Filters;

namespace FilterDemo.Controllers
{
    public class ActionResultFilterTestController : Controller
    {
        // GET: ActionTest
        [MyAction]
        [MyResult]
        public ActionResult Index()
        {
            Response.Write("Action正在执行中...</br>");
            return View();
        }
    }
}