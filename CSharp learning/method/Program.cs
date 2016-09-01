using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method
{
    class Program
    {
        static void Main(string[] args)
        {

            ////快捷键

            //Console.WriteLine()的快捷键：cw+tab

            //之后连按两下tab，所有程序块自动出来。例如：
            //for (int i = 0; i < length; i++)
            //{

            //}
            //也可以自己定义代码段的快捷键Tools---Code Snippets manager


            //选中字段，Ctrl+K+C注释，Ctrl+K+U取消注释

            //shift+alt+F10 (ctrl+.) 显示下划线要提示的内容

            

            #region method
            /*
             函数就是将一堆代码进行重用的一种机制。函数就是一段代码，这段代码可能有输入的值（参数），
             可能会返回值。一个函数就像一个专门做这件事的人，我们调用它来做一些事情，
             它可能需要我们提供一些数据给它，它执行完成后可能会有一些执行结果给我们。
             要求的数据就叫参数，返回的执行结果就是返回值。
             */
            /*
            string s = Console.ReadLine()就是一个有返回结果的函数；Console.WriteLine("hello")
            就是一个有执行参数的函数，只有告诉WriteLine被打印的数据它才知道如何打印；
            int i = Convert.ToInt32("22")则是一个既有参数又有返回值的函数。
            */
            /*有了函数写代码就像拼积木，C#中的各种各样的技术其实就是通过for、
            if等这些基础的语法将不同的函数按照一定的逻辑组织起来。
            */

            //语法：
            //    [访问修饰符][static] 返回值类型 方法名([参数])
            //{
            //    方法体;
            //}
            //命名规则：方法名开头大写，参数名开头小写，参数名、变量名要有意义。
            //方法的调用,对于静态（static）方法,如果在同一个类中,直接写名字调用就行了.
            //return可以立即退出方法.在没有返回值的方法中可以不写reture（编译器自动加上了），也可以与if语句搭配强制跳出方法达到特殊用途。有返回值的方法必须写return。
            //注意：1）方法一般要定义在类中。2)如果方法没有返回值，则返回值类型写void
            //调用：如果是静态方法调用（static），则使用 类名.方法名();   但在本类中调用本方法，可以只写方法名（）;


            //例子：
            ShowUI();             //完整的写法是：Program.ShowUI();
            Console.ReadKey();


            //练习：重复让用户输入一个数,判断该数是否是质数,输入q结束? 质数的判断用方法来实现
            //int number;
            //string str;
            //do
            //{
            //    Console.WriteLine("Please enter a number (>=1): (Press 'q' to exit.)");
            //    str = Console.ReadLine();
            //    try
            //    {
            //        number = Convert.ToInt32(str);
            //        if (number > 0)
            //        {
            //            if (IsPrimerNumber(number))
            //            {
            //                Console.WriteLine("{0} is a prime.", number);
            //            }
            //            else
            //            {
            //                Console.WriteLine("{0} is a not prime.", number);
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Please enter a number >=1");
            //        }

            //    }
            //    catch
            //    {
            //        if (str != "q")
            //        {
            //            Console.WriteLine("Error! Please re-enter a number.");
            //        }

            //    }
            //    Console.WriteLine("_______________________________________________________\n");
            //}
            //while (str != "q");
            //Console.ReadKey();




            #endregion

            #region 变量及作用域
            //在方法中定义的变量称为局部变量,其作用域从定义开始,到其所在的大括号结束为止.
            //在一个方法中想要访问另一个方法中的变量,怎么办?
            //两种解决方法:参数和返回值
            //举例:写一个方法,判断一个年份是否是润年.
            //方法中的return语句
            //导致函数立即返回。在返回值为void的函数中return，在返回值非void的函数中return 值
            //一个变量一旦在方法外，类的里面，就叫做类的字段，这个变量就可以被本类的所有方法访问，但要注意，静态方法只能访问静态字段。
            //常量const不能被声明为static，但可以被static或非static方法直接访问。
            //� 全局变量。static类变量。
            //� 不用new就能用的方法：static方法，static方法其实就是普通函数
            //� 在static方法中可以调用其他static成员，但是不能调用非static成员。在非static方法中可以调用static成员。
            //� 静态类，不能被new的类就是静态类。静态类一般用来实现一些函数库。***Helper，SqlHelper，PageHelper。


            #endregion

            #region 返回值
            //只要在方法中有return返回值，前面就应该用一个变量来接收方法的返回值。
            //一个方法只能有一个返回值。
            //一旦一个方法有返回值，那么方法类型void就要变成相应数据类型(int/string...)


            //练习1：读取输入的整数，定义成方法，多次调用(如果用户输入的是数字,则返回,否则提示用户重新输入)
            //Console.WriteLine("请输入你的年龄");
            //int age = ReadInt();
            //Console.WriteLine("你的年龄是：" + age);
            //Console.ReadKey();



            //练习2：查找两个整数中的最大值：int Max(int i1,int i2)
            //Console.WriteLine("Please enter the first one:");
            //int num1 = ReadInt();
            //Console.WriteLine("Please enter the second two:");
            //int num2 = ReadInt();
            //Console.WriteLine("The max number is "+MaxBetweenTwo(num1,num2));
            //Console.ReadKey();



            //计算输入数组的和：int Sum(int[] values)
            //int[] array = {2, 4, 5, 6, 6, 7, 77, 7, 7, 9, 966, 3, 345};
            //Console.WriteLine("The sum is " + SumInArray(array));
            //Console.ReadKey();







            #endregion

            #region 方法重载
            //一般在同一个类中，方法名相同，并且方法的参数的个数不同或者对应位置上的类型不同，才能构成方法的重载。注意：方法重载与返回值无关。


            #endregion

            #region 方法的out和ref参数
            //函数参数默认是值传递的，也就是“复制一份”.out则是内部为外部变量赋值，out一般用在函数需要有多个返回值的场所。例：int.TryParse。
            //方法只能返回一个值,当需要返回多个值时怎么办? 例如:写一个方法,计算一个int类型数组中每个元素的总和 和 最大值与最小值 ?
            //out使用：
            //在方法的参数类型钱加out，那么传参数的时候，也必须在用的变量名前加out表明这个参数不是传入的，而是用来传出值的。
            //如果参数是以out形式传入的，那么在传入前可以不赋初值。
            //在方法中对于由out修饰的参数，必须赋值，并且必须在使用前赋值。


            //练习1：写一个MyTryParse方法，要求用户传入一个字符串，如果这个字符串能转换成int类型，则方法返回true，
            //并且转换后的int类型数据通过方法的参数传出。如果字符串不能转换成int类型，则方法返回false，那么out传出的参数将没有意义，在方法中随意赋值就行了。
            //Console.WriteLine("Enter numbers: ");
            //string str = Console.ReadLine();
            //int num;
            //if (MyTryParse(str, out num) == true)
            //{
            //    Console.WriteLine("Your number is {0}", num);
            //}
            //else
            //{
            //    Console.WriteLine("Cann't be converted to int.");

            //}
            //Console.ReadKey();


            //练习2：写一个方法,计算一个int类型数组中每个元素的总和 和 最大值与最小值?
            //int[] array = { 1, 2, 1, 4, 5, 5, 6, 7, 8, 9, 23, 4, 6, 7, 89, 45 };
            //int max, min;
            //Console.WriteLine("Sum={0}, Max={1}, Min={2}", SumWithMaxMin(array, out max, out min),max, min);
            //Console.ReadKey();




            //out用于传出值，在方法中必须对out修饰的参数进行赋值。ref可以理解成是双向的，在方法中可以不赋值，相当于指针的作用，ref实际上传递的内存地址。






            #endregion

            #region 错误和异常
            //�   try catch。Exception ex 异常也是对象。
            //�   Exception 类主要属性：Message、StackTrace
            //� 发生异常后程序默认就退出了，try代码块中的后续代码不会被执行。catch以后的代码则会继续执行。
            //� 不要吃掉异常，一般情况下不需要处理异常。
            //� 扔出自己的异常，扔：throw，抓住：catch

            //try
            //{
            //    string desc = GetAgeDesc(300);                              
            //    Console.WriteLine(desc);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("数据错误： "+ex.Message);                 //ex.Message显示异常内容。
                
            //}
            //Console.ReadKey();


            #endregion

            #region 可变参数
            //� 参数数组：int sum(params int[] values) int sum(string name,params int[] values) 可变参数数组必须是最后一个。
            SayNames("Jialei Hu","Charlie","小野");
            Console.ReadKey();


            #endregion

            #region 方法的递归
            //在方法内部自己调用自己
            TellStory();
            Console.ReadKey();

            #endregion
        }

        public static int i=0;                               //定义一个静态参数，用于函数的递归
        public static void TellStory()
        {
            i++;
            Console.WriteLine("从前有座山");
            Console.WriteLine("山里有个庙");
            Console.WriteLine("庙里有个小和尚和小和尚");
            Console.WriteLine( "有一天，小和尚哭了，老和尚给小和尚讲了一个故事");
            if (i>5)                                         //函数的递归要设置一个条件条件，否则死循环
            {                                                //函数的递归return是一层一层往外跳，本例要跳五次，因为进行了五次函数递归调用
                return;
            }
            TellStory();
        }

        /// <summary>
        /// 用于显示主界面的方法
        /// </summary>
        public static void ShowUI()                                                    //方法定义在main方法之外 class program之内
        {
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*                 欢迎使用本软件                    *");
            Console.WriteLine("*****************************************************");
        }

        /// <summary>
        /// Only enter int
        /// </summary>
        /// <returns></returns>
        public static int ReadInt()
        {
            do
            {
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    return number;
                }
                catch
                {
                    Console.WriteLine("Error!");
                    Console.WriteLine("Please enter again.");
                   
                }
                
            }
            while (true);
            
        }
        public static int MaxBetweenTwo (int num1, int num2)
        {
            return (num1 > num2) ? num1 : num2;
        }
        public static int SumInArray(int[] array)
        {
            int sum = 0;
            for (int i=0;i<array.Length;i++)
            {
                sum += array[i];
            }
            return sum;
        }

        public static bool MyTryParse(string str, out int result)
        {
            try
            {
                
                result=Convert.ToInt32(str);
                return true;
            }
            catch
            {
               
                result = 0;
                return false;
            }
        }

        public static int SumWithMaxMin(int[] array, out int maxInArray, out int minInArray)
        {
            int sumForArray = 0;
            maxInArray = minInArray=array[0];
            for (int i=0; i<array.Length; i++)
            {
                sumForArray += array[i];
                if (maxInArray < array[i])
                {
                    maxInArray = array[i];
                }
                if (minInArray > array[i])
                {
                    minInArray = array[i];
                }
            }
            return sumForArray;
        }

        public static bool IsPrimerNumber(int number)
        {
            bool prime = true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    prime = false;
                    break;
                }
               
            }
            return prime;

        }

        public static string GetAgeDesc(int age)
        {
            if (age>=0 && age<=3)
            {
                return "婴幼儿";
            }
            else if (age>3 && age<=18)
            {
                return "青少年";
            }
            else if (age>19 && age<150)
            {
                return "成年人";
            }
            else if (age<0)
            {
                throw new Exception("您来自反物质世界吧！");              //new一个message的内容，抛出，被调用程序catch住。
            }
            else
            {
                throw new Exception("您见过老佛爷吧！");
            }
        }


        public static void SayNames(string name, params string[] nicknames)                 //可变参数可以和固定参数一起用，但必须在后面。
        {
            Console.WriteLine("我的名字是",name);
            foreach (string nickname in nicknames)
            {
                Console.WriteLine("我的昵称： {0}", nickname);
            }
        }



    }
}
