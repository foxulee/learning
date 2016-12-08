using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using Models;

namespace HttpClientDemo.Controllers
{
    public class HttpClientController : Controller
    {
        // GET: HttpClient
        public ActionResult Index()
        {
            //客户端对象的创建与初始化
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //执行Get操作
            HttpResponseMessage response = client.GetAsync("http://localhost:55047/api/userinfo").Result;
            List<UserInfo> list = response.Content.ReadAsAsync<List<UserInfo>>().Result;

            ViewData.Model = list;



            return View();
        }
    }
}