using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_and_polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //���多态的概念: 多态简单讲就是一个类针对同一个方法可以表现出多种不同的形态。举例：动物类有个叫的方法，通过多态当调用动物类叫的方法时，根据动物类对象实际存放子对象的不同，则表现出不同的叫声，有可能是人叫、也有可能是狗叫、也有可能是猫叫等等。
            //���多态的实现
            //（1）虚方法  Virtual Method
            //步骤：
            //①将父类的方法标记为虚方法，即给父类的方法加上virtual修饰
            //②在子类中重写父类的方法，即给子类对应的方法加上override修饰
            //注意：
            //①在虚方法中父类可以创建实例
            //②父类的方法有实现并且可以被调用
            //③子类可以重写父类的方法也可以不重写，重写的实现多态，不重写的不能实现多态

            Employee emp = new Employee();
            Manager mg = new Manager();
            Programmer pm = new Programmer();
            Employee[] emps = { emp, mg, pm };
            for (int i = 0; i < emps.Length; i++)
            {
                emps[i].DaKa();
            }
            Console.ReadKey();



            //（2）抽象类  Abstract Class
            //步骤：
            //①将父类标记为抽象类、将父类的方法标记为抽象方法(连大括号也不能有)，即给父类和父类的方法加上abstract修饰
            //②在子类中重写父类的方法，即给子类对应的方法加上override修饰
            //注意：
            //①在创建父类实例时不能使用new父类名()，而应该是new子类名()
            //②抽象成员必须标记为abstract,并且不能有任何实现
            //③子类继承抽象类后，必须把父类中的所有抽象成员都重写，除非子类也是一个抽象类，则可以不重写
            //抽象成员的访问修饰符不能是private
            //抽象类是有构造函数的。虽然不能被实例化。给子类用。
            //④如果父类的抽象方法中有参数(/无参数)，那么继承这个抽象父类的子类在重写父类的方法的时候必须传入对应的参数（/无参数）
            //⑤如果抽象父类的抽象方法中有返回值，那么子类在重写这个抽象方法的时候也必须要传入返回值。

            Shape shape = new Square(5, 6); //new Circle(5);  
            double area = shape.GetArea();
            double perimeter = shape.GetPerimeter();
            Console.WriteLine("这个形状的面积是{0},周长是{1}", area, perimeter);
            Console.ReadKey();


            //如果父类中的方法有默认的实现，并且父类需要被实例化，这时可以考虑将父类定义成一个普通类，用虚方法来实现多态。
            //如果父类中的方法没有默认实现，父类也不需要被实例化，则可以将该类定义为抽象类。



            //（3）接口，接口表示一种规范，同时也表示一种能力，继承了这个接口，也就有了这个能力。
            //接口语法格式：
            //[public] interface I..able    //命名一般以I开头，以able结尾， I..able表示具备什么能力
            // {
            //       成员;
            // }
            //注意：
            //①接口中的成员不允许添加访问修饰符默认就是Public，普通类中的成员不加访问修饰符的话默认是Private。
            //②接口中的方法不允许有方法体
            //③接口中的成员可以是方法、属性、索引器，但不能为字段和构造函数
            //④接口不能被实例化，也就是说，接口不能new(不能创建对象)
            //⑤实现接口的子类必须实现该接口的全部成员
            //⑥接口与接口之间可以继承，并且可以多继承
            //⑦一个类可以同时继承一个类并实现多个接口，如果一个子类同时继承了父类A，并实现了接口IA,那么语法上A必须写在IA的前面。classMyClass:A,IA{}，因为类是单继承的。

            IFlyable birdFly = new Bird();
            birdFly.Fly();           //鸟在飞  
            IFlyable personFly = new Person();
            personFly.Fly();         //人在飞   
            Console.ReadKey();


            //显示实现接口的目的：解决方法的重名问题
            //什么时候显示的去实现接口：
            //当继承的借口中的方法和参数一摸一样的时候，要是用显示的实现接口
            //interface name.method name()

            //当一个抽象类实现接口的时候，需要子类去实现接口。

            //深入理解接口的优势和好处：http://blog.jobbole.com/85751/




        }


        // 虚方法 Virtual Method
        public class Employee  //基类(父类)  
        {
            public virtual void DaKa()
            {
                Console.WriteLine("9点打卡");
            }
        }

        public class Manager : Employee
        {
            public override void DaKa()
            {
                Console.WriteLine("经理11点打卡");
            }
        }

        public class Programmer : Employee
        {
            public override void DaKa()
            {
                Console.WriteLine("程序猿不打卡");
            }
        }


        //抽象类 Abstract Class
        public abstract class Shape
        {
            public abstract double GetArea();
            public abstract double GetPerimeter();
        }
        public class Circle : Shape
        {

            private double _r;
            public double R
            {
                get { return _r; }
                set { _r = value; }
            }

            public Circle(double r)
            {
                this.R = r;
            }
            public override double GetArea()
            {
                return Math.PI * this.R * this.R;
            }

            public override double GetPerimeter()
            {
                return 2 * Math.PI * this.R;
            }
        }
        public class Square : Shape
        {
            private double _height;

            public double Height
            {
                get { return _height; }
                set { _height = value; }
            }

            private double _width;

            public double Width
            {
                get { return _width; }
                set { _width = value; }
            }

            public Square(double height, double width)
            {
                this.Height = height;
                this.Width = width;
            }

            public override double GetArea()
            {
                return this.Height * this.Width;
            }

            public override double GetPerimeter()
            {
                return (this.Height + this.Width) * 2;
            }
        }


        //接口 Interface
        public interface IFlyable
        {
            void Fly();
        }

        public class Bird : IFlyable
        {
            public void Fly()
            {
                Console.WriteLine("我是小鸟，我可以自由飞翔！");
            }
        }

        public class Person : IFlyable
        {
            public void Fly()
            {
                Console.WriteLine("我是超人，我要保护地球！");
            }
        }
    }
}
