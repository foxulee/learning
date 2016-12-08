using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Empty.Controllers
{
    public class NewsHomeController : Controller
    {
        // GET: NewsHome
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Show(string year,string month, string day, string id)
        {
            ViewBag.year = year;
            ViewBag.month = month;
            ViewBag.day = day;
            ViewBag.id = id;
            return View();
        }
    }
}