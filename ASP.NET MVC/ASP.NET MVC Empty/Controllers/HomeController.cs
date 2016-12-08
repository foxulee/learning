using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NET_MVC_Empty.Models;

namespace ASP.NET_MVC_Empty.Controllers
{
    public class HomeController : Controller
    {
        //在mvc中，访问页面时，实际访问的是某个类的某个actionresult方法（action）
        //在webform中，访问页面时，实际访问的是某个类
        // GET: Home
        public ActionResult Index()
        {
            //默认不指定显示页面时，会采用与行文同名的页面进行显示
            //return View();
            //还可以自定义显示页面
            return View("Show");
        }

        public ActionResult HtmlTest()
        {
            //controller向view传数据,用ViewData 键值对
            ViewData["test1"] = "我是ViewData";
            //另一种写法
            ViewBag.test2 = "我是ViewBag";

            //Dropdown list数据传值
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem() { Selected = false, Text = "Mary", Value = "1" });
            list.Add(new SelectListItem() { Selected = false, Text = "Charlie", Value = "2" });
            list.Add(new SelectListItem() { Selected = true, Text = "Per", Value = "3" });
            list.Add(new SelectListItem() { Selected = false, Text = "Jasie", Value = "4" });
            ViewBag.dropDownList = list;

            //在页面指定了强类型view，传递对象
            ViewData.Model= new Person() {Age = 10, QQ = "21242314"};


            return View();
        }
    }
}