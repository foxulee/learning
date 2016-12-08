using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterDemo.Filters
{
    /// <summary>
    ///结果过滤器: 在结果被执行前、后执行的过滤器
    //可以重写方法OnResultExecuting（结果执行前）
    //可以重写方法OnActionExecuted（结果执行后）
    /// </summary>
    public class MyResult : ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write(" 结果执行前");
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write("结果执行后");
        }
    }
}