using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_Empty.Models
{
    public class User
    {
        //.NET 框架中System.ComponentModel.DataAnnotations命名空间包括了众多可用的内置验证特性，用于修饰属性，常用的四个如下：
        //[Required]
        //[StringLength]
        //[Range]
        //[RegularExpression]  正则表达式
        //属性ErrorMessage：指定错误提示信息

        [Required(ErrorMessage = "Cannot be empty!")]
        public int Id { get; set; }
        [StringLength(10,ErrorMessage = "Length should be less than 10 chars.")]
        public string Name { get; set; }
        [Range(0,150,ErrorMessage = "Age must be between 0 and 150 ")]
        public int Age { get; set; }
        public string Password { get; set; }
    }
}