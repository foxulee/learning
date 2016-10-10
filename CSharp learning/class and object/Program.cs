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
            //�每一个class都应该单独地存在一个class文件中！！！


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
              � 属性 惯用法：属性开头字母大写，字段开头字母小写  （属性的本质就是set get两个方法，所以首字母大写）
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

            /*构造函数   （访问修饰符必须是public！）
             � 构造函数用来创建对象，并且可以在构造函数中对对象进行初始化。
             � 构造函数是用来创建对象的特殊函数，函数名必须和类名一样，没有返回值，连void也不能写。
             � 构造函数可以有参数，new对象的时候传递函数参数即可。new的作用： 如果new的三步任一步出错，则无法初始化对象。
                1)、在内存的堆中开辟空间
                2)、在开辟的堆空间中创建对象
                3)、调用对象的构造函数，初始化对象。
             � 构造函数可以重载，也就是有多个参数不同的构造函数。
             � 如果不指定构造函数，则类有一个默认的无参构造函数。如果指定了构造函数，则不再有默认的无参构造函数，不管新写的构造函数有没有参数。
             */

            //Person5 p1 = new Person5();
            //Person5 p2 = new Person5("Charlie");
            //Person5 p3 = new Person5("Jason", 2);

            //� 字段的保护可以在属性的get，set方法中，也可以在构造方法中。


            //��� 对象的引用
            //http://www.cnblogs.com/kirinboy/archive/2012/06/15/value-and-reference-in-csharp-2.html
            //�值类型：int, double, char, bool, decimal, struct, enum
            //�引用类型：string, array, class
            //�内存分为三部分：堆，栈，静态存储区域。
            //�值类型的值存在栈上；引用类型的值是存在堆中的。


            //��� 静态和非静态
            /*
            静态成员需要被static修饰，非静态成员不需要加static。
            问题1：在一个非静态类中，是否允许出现静态成员？
                答：非静态类中是可以出现静态成员的。
            问题2：在非静态函数中，能不能够访问到静态成员？
                答：在非静态函数中，既可以访问到非静态成员，也可以访问到静态成员。
            问题3：在静态函数中，能不能够访问到非静态成员？
                答：静态方法只能够访问到静态成员。
            问题4：在静态类中能否出现非静态成员？
                答：不可以，在静态类中，只允许出现静态成员。
            < �在调用上，静态和非静态的区别-- >
                1、在调用实例成员的时候，需要使用对象去调用      例如P1.方法()
                2、在调用静态成员的时候，必须使用类名.静态成员名; 例如Console.ReadLine()
                3、静态类是不允许创建对象的
                
            � 什么时候使用静态类，什么时候使用非静态类？
              如果你写的类属于工具类，可以考虑写成静态类。静态类无法实现封装，继承，多态。
              静态的好处：资源共享。非静态不占内存，静态类占内存，存在静态存储区域！
              静态类应该越少越好。原因1，减少静态内所占的内存；原因2，所有程序结束才能释放共享的资源。
            */



            /*
            ��� 、在一个项目中引用另一个项目的类
            1、添加要引用的类所在的项目。
            2、引用命名空间

            ��� 访问修饰符
            public :公开的，公共的
            private：私有的，只能在类的内部访问，出了这个类之后，就访问不到了。类中的成员没有访问修饰符，默认为private。
            能够修饰类的访问修饰符只有两个：
            1)、public
            2)、internal：表示只能在当前程序集的内部进行访问，出了这个程序集就访问不到啦。如果类没有修饰符，默认为internal。
            对于咱们而言，现阶段就将程序集理解为当前项目。
            */



            //��� 继承
            /*
                我们在写类的过程当中，会发现，在多个类当中会存在一些相同的属性和方法。
                为了解决这种代码冗余，于是乎，我们使用继承来解决这个问题。

                我们把一些类当中所共同具有的属性和方法单独的拿出来封装成一个父类。
                然后让其他类去继承这个父类。



                如果一个类继承了另一个类，我们管这个类称之为子类，管被继承的那个类称之为父类。
                或者 管这类称之为派生类，管被继承的那个类称之为基类。

                语法：
                     :要继承的类

                2、一个子类继承了一个父类，那么这个子类继承了父类的什么成员？
                字段、属性、方法、构造函数

                子类继承了父类的属性和方法。
                子类并没有继承父类的私有字段。
                子类并没有继承父类的构造函数，而是会默认的调用父类那个无参数的构造函数，
                当你在父类中写了一个有参数的构造函数之后，那个默认的无参数的构造函数就被干掉了，
                此时子类就调不到那个无参数的构造函数了。
                解决办法：
                1)、在父类中重新写一个无参数的构造函数。但一般不这么做。
                2)、让子类去显示的调用父类有参数的构造函数。使用关键字   子类构造方法后面+:base(要传给父类的参数)


                3、继承的两个特性
                1、单根性，一个子类只能有一个父类。一个儿子只能有一个爹。
                2、传递性，爷爷有的，爹肯定有，爹有的，最终儿子也会有。

                4、object类是一切类型的基类
                */


            //� new的用法
            //1)、创建对象
            //2)、如果子类和父类成员重名，在成员名前加new，隐藏从父类那里继承过来的成员。


            //� this的用法
            //1)、代表当前类的对象
            //2)、显示的调用自己的构造函数. 当有构造函数重构时，部分参数的函数名后加上 :this(要传入的参数，不齐的用0或者null补足)



            //� 里氏转换
            //1)、子类对象可以赋值给父类（如果有一个地方需要父类作为参数，我们可以给一个子类代替。）。  例如：Person p = new student();
            //2)、如果这个父类中装的是子类对象，那么可以将这个父类强转为子类对象。  例如：Person p = new student(); Student s = (student) p;
            //两个关键字
            //� is：类型转换，如果转换成功，返回一个true，否则返回一个false。
            //� as：类型转换，如果转换成功，则返回对应的对象，如果转换失败，返回一个null
            //if (p is Teacher)
            //{
            //    Teacher s = (Teacher)p;                  //无法转换，因为p装的是student
            //}
            //例如，Join方法的参数为object类型：
            string str=string.Join("|", new int[] { 1, 2, 3 },"string", 'c', 2,true);

            //Person p = new student();
            //Teacher t = p as Teacher;                  //无法转换，t的值是null



            //其他修饰关键字sealed和partial
            //sealed将类密封起来，不让它派生出其他类，在需要把类设计为密封类的时候，将类标记为Sealed即可。
            //Partial：不完整类型声明。类、结构和接口修饰符，用于把类定义拆分为几个部分，便于代码管理。





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




            //练习1：
            Ticket ticket1 = new Ticket(-150);
            ticket1.DisplayTicketInformation();




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

    class Person5                            //构造函数
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
   

