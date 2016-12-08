using System.Web;
using System.Web.Mvc;
using FilterDemo.Filters;

namespace FilterDemo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //系统默认的异常过滤器，如果使用自定义异常处理，要将如下代码删除
            //filters.Add(new HandleErrorAttribute());
            

            //在全局中注册过滤器，则对所有controller的所有action，都会执行这个filter
            //filters.Add(new MyAuthorizatioin());  //对authorization过滤器一般不这么全局设置

            filters.Add(new MyException());  //应用全局异常过滤器
        }
    }
}
