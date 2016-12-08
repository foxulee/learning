using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Entity_Framework.Models;

namespace Entity_Framework.Controllers
{
    public class UserInfoCRUDController : Controller
    {
        // GET: UserInfoCRUD

        DbContext ctx = new MyContext();
        public ActionResult Index()
        {
            
            ViewData.Model = ctx.Set<UserInfo>().Where(u=>u.DelFlag==0).OrderBy(u=>u.UserId);
            
            return View();
        }

        public ActionResult AddUser()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult AddUser(UserInfo userInfo)
        {
           ctx.Set<UserInfo>().Add(userInfo);
            int result = ctx.SaveChanges();  //如果内存中的塑聚发生了变化，并且希望将这个变化映射到数据库，需要执行这个方法。
            if (result>0)
            {
                return Redirect(Url.Action("Index","UserInfoCRUD"));
            }
            else
            {
                return Redirect(Url.Action("AddUser", "UserInfoCRUD"));
            }
            
        }

        public ActionResult EditUserInfo(int id)
        {
            ViewData.Model=ctx.Set<UserInfo>().Where(u=>u.UserId==id).FirstOrDefault();    //注意和First()的区别，First（）如果没拿到数据则抛异常，前者不会
            return View();
        }
        [HttpPost]
        public ActionResult EditUserInfo(UserInfo userInfo)
        {
            ctx.Set<UserInfo>().AddOrUpdate(userInfo);
            //ctx.Entry(userInfo).State=EntityState.Modified;
            int result = ctx.SaveChanges();
            if (result > 0)
            {
                return Redirect(Url.Action("Index", "UserInfoCRUD"));
            }
            else
            {
                return Redirect(Url.Action("EditUserInfo", "UserInfoCRUD", new RouteValueDictionary(new {id=userInfo.UserId})));
            }
        }

        public ActionResult DeleteUserInfo(int id)
        {
            //ctx.Set<UserInfo>().Remove(ctx.Set<UserInfo>().Where(u=>u.UserId==id).FirstOrDefault());
            UserInfo userinfo = ctx.Set<UserInfo>().Find(id);
            //int length1 = ctx.Set<UserInfo>().Count();
            ctx.Set<UserInfo>().Remove(userinfo);

            //ctx.Set<UserInfo>().SqlQuery("update UserInfo set DelFlag=0 where UserId=@id", new SqlParameter("@id", id));
            //ctx.Database.ExecuteSqlCommand("update UserInfo set DelFlag=0 where UserId=@id", new SqlParameter("@id", id));
            int result = ctx.SaveChanges();
            //int length2 = ctx.Set<UserInfo>().Count();
            return Redirect(Url.Action("Index","UserInfoCRUD"));
        }
    }

    
}