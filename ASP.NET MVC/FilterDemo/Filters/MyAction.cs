using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterDemo.Filters
{
    /// <summary>
    ///行为过滤器: 在行为被执行前、后执行的过滤器
    //可以重写方法OnActionExecuting（行为执行前）
    //可以重写方法OnActionExecuted（行为执行后）
    /// </summary>
    public class MyAction: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //可以删除
            //base.OnResultExecuting(filterContext);

            filterContext.HttpContext.Response.Write("ing<br>");
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //base.OnResultExecuted(filterContext);

            filterContext.HttpContext.Response.Write("ed<br>");
        }
    }
}