using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NET_MVC_Empty.Models;

namespace ASP.NET_MVC_Empty.Controllers
{
    public class ControllerDemoController : Controller
    {
        // GET: ControllerDemo
//=========================================返回结果==================================================
        //常见的四种Action返回结果
            
            /// <summary>
        ///1 使用View()可以指定一个页面，也可以指定传递的模型对象，如果没有指定参数则表示返回与Action同名的页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        ///2 使用Content(string content)返回一个原始字符串
        /// </summary>
        /// <returns></returns>
        public ActionResult Content()
        {
            return Content("我是content");   //相当于Response.Write()
        }


        /// <summary>
        ///3 使用Redirect(string url)将结果转到其它的Action
        /// </summary>
        /// <returns></returns>
        public ActionResult Redirect()
        {
            return Redirect(Url.Action("Index","Home"));   //相当于Response.Redirect()
        }


        /// <summary>
        ///4 使用Json(object data)将data序列化为json数据并返回，默认是只处理post请求，推荐加上JsonRequestBehavior.AllowGet可以处理Get请求，一般结合客户端的ajax请求进行返回
        /// </summary>
        /// <returns></returns>
        public ActionResult Json()
        {
            Person p = new Person() {Age = 12,QQ = "1341341"};
            return Json(p, JsonRequestBehavior.AllowGet);
        }



        //==============================================接收传递参数==========================================
        //方式一：使用Request根据key接收value
        //如果要实现行为的重载，必须满足两个条件：1 参数不同  2 请求类型不同（[HttpGet]）
        [HttpGet]
        public ActionResult DataExchange()
        {
            string id = Request["id"];
            ViewBag.Id1 = id;
            return View();
        }

        //方式二(最常用简便)：自动装备，在方法的参数位置，定义类型及参数名称，mvc会自动匹配相同名称的属性值，即匹配input的name与对象的属性相同名称的值
        //自动装配的要求：参数的名称或对象类型的属性必须与参数的键相同
        [HttpPost]
        public ActionResult DataExchange(int id)
        {
            ViewBag.Id2 = id;
            return View();
        }

        //还可以完成自定义类型参数的自动装配 例如自定义的Person对象；相当于webform平台的：
                //Person person = new Person();
                //person.Age = requeset["Age"];
                //person.QQ. request["QQ"];     //MVC平台简化了代码，系统通过反射reflection自动完成装配
        //自动装配的要求：参数的名称或对象类型的属性必须与参数的键相同

        public ActionResult GetPerson(Person person)
        {
            ViewData.Model = person;
            return View();
        }

    }
}