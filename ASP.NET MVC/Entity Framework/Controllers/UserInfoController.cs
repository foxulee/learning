using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entity_Framework.Models;

namespace Entity_Framework.Controllers
{
    public class UserInfoController : Controller
    {
        // GET: UserInfo
        public ActionResult Index()
        {
            //MyContext myContext = new MyContext();
            //获得所有的列
            //方法1：查询语法
            //var list = from userinfo in myContext.UserInfo
            //           select userinfo;

            //DbContext dbContext = new MyContext();  //创建父类对象指向子类
            //dbContext.Set<UserInfo>();


            ////方法2：方法语法
            //var list = myContext.UserInfo.Select(u => u);  //所有的列

            IQueryable<UserInfo> list;
            //创建上下文对象
            DbContext dbContext = new MyContext();

            //基本查询
            //1：查询语法
            //list = from userinfo in dbContext.Set<UserInfo>()
            //    select userinfo;
            //2：方法语法
            //list = dbContext.Set<UserInfo>();

            //单条件、多条件：&& || Contains
            //1：查询语法
            //list = from userinfo in dbContext.Set<UserInfo>()
            //       where userinfo.UserAge > 10 && userinfo.DelFlag==1 && userinfo.UserName.Length<5
            //       select userinfo;
            //2：方法语法
            list = dbContext.Set<UserInfo>().Where(u => u.DelFlag == 1 && u.UserId < 10 && u.UserName.Contains("J"));

            //查询部分列
            //1：查询语法
            //var list1 = from userinfo in dbContext.Set<UserInfo>()
            //    /*select userinfo.UserId;*/
            //    //查询单列
            //    select new //查询多列，匿名对象
            //    {
            //        UserId = userinfo.UserId,
            //        UserName = userinfo.UserName
            //    };
            //2：方法语法
            //var list1 = dbContext.Set<UserInfo>().Select(u => new
            //{
            //    UserId=u.UserId,
            //    UserName=u.UserName
            //});

            //分页查询：Skip、Take（仅lambda，一定要先排序后使用此方法，lambda方法特有）
            //var list1 = from userinfo in dbContext.Set<UserInfo>()
            //    select userinfo;
            //list = list1.OrderBy(u => u.UserId).Skip(2).Take(3);   //按UserId排序后，跳过前2条，取3条数据



            ViewData.Model = list;    /*返回值(list类型)：IQueryable<T> 类型. View页面强类型为IQueryable<T>*/

            return View();
        }
    }
}