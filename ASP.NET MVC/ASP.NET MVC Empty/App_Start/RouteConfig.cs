using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASP.NET_MVC_Empty
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //自定义路由规则的要求：小范围写在前，大范围写在后
            //示例：
            //新闻显示页
            routes.MapRoute(
                name: "NewsShow",
                url: "News/{year}-{month}-{day}-{id}",
                defaults: new { Controller = "NewsHome", Action = "Show" },
                constraints: new { year = @"^\d{4}$", month = @"^\d{1,2}$", day = @"^\d{1,2}$" }
                );


            //参数url:
            //设置url的路由规则，可变的值使用{ } 括起来
            //关键字controller、action名称不可变
            //可以使用?key = value的格式传递参数
            //通过路由规则，可以省略? 与key部分，直接传递值，在action的参数中自动装配
            // 优化：如果传递的参数比较多，为action定义多个参数非常乱，则将所有的参数封装到一个类中，将该类定义为action的参数类型
            //注意：对于一个网站,为了SEO友好,一个网址的URL层次不要超过三层
            //示例：localhost/{频道}/{具体网页}，其中域名第一层, 频道第二层, 那么最后的网页就只剩下最后一层了.如果使用默认实例中的“{controller}/{action}/{id}”的形式会影响网站的SEO，可以使用”/”之外的其它字符进行分隔，如”-”，但这时会进行严格匹配，即必须要有 - 才可以匹配到，默认值会失效


            //参数defaults:
            //设置路由规则中参数的默认值
            //类型为object，可以传递一个匿名对象，属性取决于规则中定义的参数
            //参数UrlParameter.Optional表示可选的只读参数
            //如果在实际的url中没有指定路由规则中某些参数，则会使用默认值作为参数的值使用


            //参数constraints
            //设置路由规则的约束
            //类型为object，可以传递一个匿名对象，属性取决于规则中定义的参数
            //参数是正则表达式字符串，如controller="^[a - z] +$"



            //路由规则调试
            //当我们写了多个路由规则之后，如何确定路由规则是否都正确呢？这些路由规则之间是否有重复呢？这就需要使用RouteDebug进行分析
            //操作步骤
            //在当前项目中添加程序集RouteDebug的引用
            //在Global文件的Application_Start方法中，在完成路由规则注册的后面，进行调试注册



            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",   //路由规则的名字，不能重复, name作为键存储
                url: "{controller}/{action}/{id}",  //路由规则，传递参数
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            
        }
    }
}
