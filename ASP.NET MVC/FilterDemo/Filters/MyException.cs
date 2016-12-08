using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterDemo.Filters
{
    /// <summary>
    /// 异常处理过滤器: 当发生异常时，用于进行自定义异步处理，如记录日志、跳转页面
    ///使用自定义异常处理，需要在web.config中为system.web添加<customErrors mode="On" /> 节点
    ///重写OnException方法，不要禁用base.***
    ///如果想进行跳转，需要设置上下文对象的Result属性为new RedirectResult(string url);
    /// </summary>
    public class MyException: HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            //如下代码不可以被删除，否则捕获不到异常；
            base.OnException(filterContext);

            //记录日志

            //页面跳转
            filterContext.Result= new RedirectResult("/Error/400.html");
        }
    }
}