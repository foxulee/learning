using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Models;

namespace WebAPI_Demo.Controllers
{
    //WCF、WebAPI、WCF REST、Web Service之间的区别:http://www.faceye.net/search/92311.html
    //WebService的两种方式SOAP和REST比较: http://stevenjohn.iteye.com/blog/1442776
    //两种web服务
    //SOAP风格：基于方法，产品是WebService
    //REST风格：基于资源，产品是WebAPI
    //可以返回json、xml类型的数据
    //对于数据的增、删、改、查，提供相对的资源操作，按照请求的类型进行相应处理，主要包括Get(查)、Post(增)、Put(改)、Delete(删)，这些都是http协议支持的请求方式
    //请求方式：根据路由规则请求


    /// <summary>
    /// 如何建WebAPI controller: Add.../Controller.../Web API 2 Controller with read/write actions
    /// 只能有这五个方法
    /// </summary>
    public class UserInfoController : ApiController
    {
        // GET: api/UserInfo
        //使用Method=Get的方式请求url=api/userinfo,则这个方法会被调用执行
        //查询所有users的信息
        public IEnumerable<UserInfo> Get()
        {
            List<UserInfo> list = new List<UserInfo>();
            list.Add(new UserInfo()
            {
                Id = 1,
                Name = "Charlie"
            });
            list.Add(new UserInfo()
            {
                Id = 2,
                Name = "Jason"
            });
            list.Add(new UserInfo()
            {
                Id = 3,
                Name = "Fish"
            });
            list.Add(new UserInfo()
            {
                Id = 4,
                Name = "Binbin"
            });

            return list;
        }

        // GET: api/UserInfo/5
        //查询单个user的信息
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/UserInfo
        //Method=Post,增加操作
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/UserInfo/5
        //Method=Put,修改操作
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/UserInfo/5
        //Method=Delete,删除操作
        public void Delete(int id)
        {
        }
    }
}
