using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entity_Framework.Models;

namespace Entity_Framework.Controllers
{
    public class SalesInfoController : Controller
    {
        // GET: SalesInfo
        public ActionResult Index()
        {
            DbContext ctx = new AdventureWorks2014Entities();

            var setST = ctx.Set<SalesTerritory>();
            var setSTH = ctx.Set<SalesTerritoryHistory>();


            //多表连接
            //多from查询
            //1. LINQ写法1
            //var list = from st in setST
            //           from sth in setSTH
            //           where st.TerritoryID == sth.TerritoryID
            //           orderby st.Group descending 
            //           select new SalesInfoViewModel()       //要使用页面强类型，需要在Models下面自定义一个用于视图的class：SalesInfoViewModel，用于接受返回值
            //           {
            //               TerritoryId = st.TerritoryID,
            //               BussinessEntityId = sth.BusinessEntityID,
            //               Name = st.Name,
            //               Group = st.Group
            //           };

            //2. LINQ写法2
            //var list = from st in setST
            //    join sth in setSTH on st.TerritoryID equals sth.TerritoryID
            //    orderby st.Group descending
            //    select new SalesInfoViewModel()
            //    {
            //        TerritoryId = st.TerritoryID,
            //        BussinessEntityId = sth.BusinessEntityID,
            //        Name = st.Name,
            //        Group = st.Group
            //    };

            var list = setST.Join(setSTH, s => s.TerritoryID, t => t.TerritoryID, (s, t) => new SalesInfoViewModel()
            {
                TerritoryId = s.TerritoryID,
                BussinessEntityId = t.BusinessEntityID,
                Name = s.Name,
                Group = s.Group
            }).OrderByDescending(s=>s.Group)
            //.ToList()   //如果此处用了ToList（）方法，则把返回值类型IQueryable<T>转变成了List<T>，那么才View的页面强类型应为List<T>
            ;




            ViewData.Model = list;

            return View();
        }
    }
}