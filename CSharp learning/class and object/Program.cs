using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_and_object
{
    class Program
    {
        static void Main(string[] args)
        {
            /*� 面向对象不是取代面向过程的。
              � 类、对象。“人”是类，“张三”是“人”这个类的对象。类是抽象的，对
                象是具体的。按钮就是类，某个按钮就是对象。对象可以叫做类的实
                例（Instance）。类就像int，对象就像10。字段Field（和某个对象相
                关的变量），字段就是类的状态。人这个类有姓名、年龄、身高等字
                段。类不占内存，对象才占内存。
              � 方法Method，方法就是类能够执行的动作，比如问好、吃饭等。
              � 类的继承，类之间可以有继承关系，比如“电脑”类可以从“电器”类继
                承，这样的好处是“电脑”类只需要定义自己特有的字段、方法就可
                以，也就是只要定义内存大小、CPU型号这些字段或者弹出光驱等方
                法就可以。父类(Parent)、基类(Base，基业，祖宗十八代传下来的)。
                电脑类是电器类的子类(ChildClass)。重用。
              � 面向对象的三个特性：封装、继承、多态。
              � 没有面向对象的世界中的难题。*/


            //Person1 p1 = new Person1();
            //p1.Name = "Charlie";
            //p1.Height = 180;
            //p1.Age = 23;
            //p1.SayHello();
            //Console.ReadKey();


            /*� 字段、方法、属性（后面讲）都可以叫做类的成员 Member，它们都需要定义
                访问级别。访问级别的用处在于控制成员在哪些地方可以被访问，这样达到
                面向对象中“封装”的目的。
              � 几个访问级别：public（任何地方都可以访问）；private（默认级别。只能由
                本类中的成员访问）。还有internal、protected两个级别，以后会讲。
              �  永远不要把字段public*/



            /*
              � 属性 惯用法：属性开头字母大写，字段开头字母小写
              � 只用set或者只用get就可以定义只读或者只写属性（只写的不常见）
              � 可以为set、get设置访问级别
              � 例子，限制非法值的设置
              � （.Net3.x）简化set、get：public int Age { get; set; }。适合于set、get中没有特殊逻辑代码的情况。允许外部访问的值一定要声明为属性。
              � 字段和属性的区别是什么？属性看似字段、不是字段，可以进行非法值控制，可以设置只读。
              �set、get块内部其实就是get_***、set_*** 方法。
              */

            //Person2 p2 = new Person2();
            //p2.Age = 30;                  //把30赋值给value,
            //Console.WriteLine("Age is {0}.",p2.Age);
            //p2.Age = -1;                  //无法赋值成功，因为if语句限制赋值>0
            //Console.WriteLine("Age is {0}.", p2.Age);
            //Console.ReadKey();


            //Person4 p4 = new Person4();
            ////p4.Age = 30;               //不可以赋值，因为没有set，是只读属性。
            //p4.IncAge();
            //p4.IncAge();
            //Console.WriteLine(p4.Age);
            //Console.ReadKey();

            /*构造函数
             � 构造函数用来创建对象，并且可以在构造函数中对对象进行初始化。
             � 构造函数是用来创建对象的特殊函数，函数名和类名一样，没有返回值，连void都不用。
             � 构造函数可以有参数，new对象的时候传递函数参数即可
             � 构造函数可以重载，也就是有多个参数不同的构造函数。
             � 如果不指定构造函数，则类有一个默认的无参构造函数。如果指定了构造函数，则不再有默认的无参构造函数，如果需要无参构造函数，则需要自己来写。
             */

            //Person5 p1 = new Person5();
            //Person5 p2 = new Person5("Charlie");
            //Person5 p3 = new Person5("Jason", 2);


            //对象的引用
            //http://www.cnblogs.com/kirinboy/archive/2012/06/15/value-and-reference-in-csharp-2.html


            //继承。定义类的时候不指定父类，则父类是Object类。Object类是任何类的直接或者间接父类。
            //Chinese c1 = new Chinese();
            //c1.Name = "Bruce Lee";
            //c1.Age = 32;
            //c1.户口 = "香港";
            //c1.SayHello();
            //c1.功夫();
            //Console.ReadKey();

            //Korean k1 = new Korean();
            //k1.Name = "金三顺";
            //k1.做泡菜();
            //Console.ReadKey();

            ////对象的隐式转换和显式转换：
            //Person1 p1 = c1;
            //p1.SayHello();

            //Person1 p2 = k1;

            ////Korean k2 = new Person1();              //报错
            ////Chinese c2 = p1;                        //同样报错，我要一个中国人，给了我一个Person类型的变量，我一看p1是Person类型，我就报错，给的要不是中国人咋办？谁负责？
            //Chinese c2 = (Chinese)p1;                 //我看到p1是Person类型，但是程序员说了，“大胆的去指吧”，p1       一定是一个中国人。
            //Chinese c3 = (Chinese)p2;                 //一旦程序员的保证不靠谱，照样报错。






            Console.ReadKey();
        }
    }

    class Person1
    {
        public int Height;
        public int Age;
        public string Name;
        public void SayHello()
        {
            Console.WriteLine("大家好！我的名字叫{0}，今年{1}岁，我的身高{2}",this.Name,this.Age,this.Height);   //this.: 我自己的*** （可以省略）
        }

    }
    class Person2
    {
        private int age;           //字段，age小写，private
        public int Age             //属性，Age大写，public  不存储数据，都存储到age中。
        {
            set                     //赋值
            {
                if (value < 0)      //可以用if语句控制赋值范围
                {
                    return;
                }
                this.age = value;   //value代表用户赋值过来的值
            }
            get                     //取值
            {
                return this.age;
            }
        }


    }

    class Person3
    {
        public int Age { set; get; }                 //定义一个属性可以简写，编译器自动帮我们生成代码块和私有字段存储数据。
    }

    class Person4
    {
        private int age;            //初始化时的值为0.
        public int Age
        {
            get                     //没有set语句块的话，属性为只读，不可赋值。
            { return this.age; }
        }

        public void IncAge()
        {
            this.age++;
        }
             
    }

    class Person5
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person5()                          //构造函数要与本类同名
        {
            Name = "未命名";
            Age =0;
        }

        public Person5(string name)               //构造函数可以重构
        {
            Name = name;
            Age = 0;
        }

        public Person5(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class Chinese : Person1                  //类的继承
    {
        public string 户口 { get; set; }
        public void 功夫()
        {
            Console.WriteLine("我打！！！！");
        }
             
    }
    class Korean : Person1
    {
        public void 做泡菜()
            {
            Console.WriteLine("做包菜！！！来吃！");
            }
    }
}
   

