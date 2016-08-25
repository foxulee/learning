using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const_Enumeration_Structure_and_Array
{
    public enum Gender                               //public不是必须，但如果被struct用到，则必须有public
    {
        Male=1,                                      //=1可以不写，那么Male默认的编号为0     
        Female                                       //Female的编号自动为Male的编号加1.
    }

    public struct Person                             //public不是必须，但是最好都加上
    {
        public string name;
        public Gender sex;
        public int age;
             

    }


    public enum MyColor
    {
        red,
        gree,
        blue
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region const
            //语法
            /*const double PI = 3.14; */      // 和variable的定义一样，在前面加上const。只能初始化的时候赋值，后面的code无法更改PI的值。
            #endregion


            #region enumeration
            //作用：1.限制用户不能随意赋值，只能在定义枚举时例举的值中选择。2.不需要死机每一个值是什么，只需要选择相应的值。
            //enum的定义，一般和类定义一个级别（如上：class program的上面），这样，在同一个命名空间下的所有的类就都可以使用这个枚举了（当然定义在类/方法中也可以，作用域不同）。
            //注意，定义枚举时，值不能是int类型。枚举类型的变量都可以强制转换成一个int类型。枚举的值在定义时是有一个默认编号的，编号从0开始。
            //Gender sex;
            //sex = Gender.Male;
            //Console.WriteLine(sex);
            //Console.ReadKey();

            //Console.Write((int)sex);
            //Console.ReadKey();

            //把字符串转换为枚举
            //(Gender)(Enum.Parse(typeof(Gender), "待转化的字符串"));
            //Gender sex;
            //Console.WriteLine("Please enter your gender: ");
            //string s = Console.ReadLine();
            //try                                                            //让用户输入枚举类型中的值是，用try catch保护起来，否则用户有可能输入枚举范围外的值会报错。
            //{
            //    sex=(Gender)(Enum.Parse(typeof(Gender), s));
            //    Console.WriteLine("The gender your entered is: " + sex);
            //}
            //catch
            //{
            //    Console.WriteLine("Error!");
            //}
            //Console.ReadKey();
            #endregion


            #region structure
            //为什么要用结构：为了存储一个人的信息，要声明一组变量，当要存储n个人的信息时，就要声明n组变量，麻烦；而且存储一个人的信息的这几个变量间没有关系，容易混乱出错。
            //Person onePerson;
            //onePerson.name = "Jane";
            //onePerson.sex = Gender.Female;
            //onePerson.age = 20;

            //Person secPerson;
            //secPerson.name = "Jack";
            //onePerson.sex = Gender.Male;
            //onePerson.age = 26;


            //练习1 定义一个枚举叫MyColor,有三个成员,分别为red,green,blue，声明一个 MyColor类型的变量, 并对其成员赋值.使MyColor可以表示成一个红色.
            //MyColor myColor = MyColor.red;
            //Console.WriteLine(myColor);
            //Console.ReadKey();




            #endregion


            #region array （很重要）
            //一次语文测试后,老师让班长统计每一个学生的成绩并计算全班(全班共10人)的平均成绩,然后把所有成绩显示出来.
            //如何声明变量?
            //好的解决方法,使用数组.数组的好处是可以一次声明多个同类型的变量。这些变量在内存中是连续存储的。
            //数组声明语法：
            //数据类型[] 数组名=new 类型[数组长度]；
            //例如：
            //简单的：
            //int[] nums = { 5, 3, 8 };


            ////另一种：
            //int[] score = new int[10];                   //声明了score数组，里面包含10个int类型的变量。里面所有元素被初始化成0.
            //score[0] = 3;                               //给数组第一个元素赋值。编号从0开始，到9为止。

            ////通过 数组名.Length 可以得到数组长度（元素个数）。
            //int sum = 0;
            //for (int i = 0; i < score.Length; i++)
            //{
            //    Console.WriteLine("请输入第{0}个人的成绩： ", i + 1);
            //    score[i] = Convert.ToInt32(Console.ReadLine());
            //}

            ////用for循环遍历数组,计算总和。
            //for (int i = 0; i < score.Length; i++)
            //{
            //    sum += score[i];
            //}
            //Console.WriteLine("学生总成绩是{0},平均成绩是{1}", sum, sum / score.Length);
            //Console.ReadKey();

            //Console.Clear();                                   //***********把屏幕清空！！！

            ////输出数组中的每一个元素的值
            //for (int i = 0; i < score.Length; i++)
            //{
            //    Console.WriteLine("第{0}个学生的成绩是{1}", i + 1, score[i]);
            //}
            //Console.ReadKey();



            ////方法总结：数组正遍历循环：
            //for (int i = 0; i < score.Length; i++) { }
            ////数组倒遍历循环：
            //for (int i = score.Length-1; i >= 0; i--) { }
            




            //练习1：将一个字符串数组输出为|分割的形式，比如“梅西|卡卡|郑大世”
            //string[] names = {"梅西","卡卡","郑大世" };
            //string linkedNames="";
            //for (int i = 0; i < names.Length; i++)
            //{
            //    linkedNames = (i != names.Length - 1) ? (linkedNames + names[i] + "|") : (linkedNames + names[i]);                 //此处用三元表达式比较简单。
            //}
            //Console.WriteLine(linkedNames);
            //Console.ReadKey();


            //将一个整数数组的每一个元素进行如下的处理：如果元素是正数则将这个位置的元素的值加1，如果元素是负数则将这个位置的元素的值减1,如果元素是0,则不变。
            //int[] numbers = { 3, 4, 5, 6, 7, -1, -2, -3, 0 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > 0)
            //    {
            //        numbers[i]++;
            //    }
            //    else if (numbers[i] < 0)
            //    {
            //        numbers[i]--;
            //    }
            //}
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //Console.ReadKey();



            //练习3：将一个字符串数组的元素的顺序进行反转。{“3”,“a”,“8”,“haha”} {“haha”,“8”,“a”,“3”}。第i个和第length-i-1个进行交换。
            //string[] myString = { "3", "a", "8", "haha" };
            //int length = myString.Length;
            //string[] reversedString = new string[length];
            //for (int i = 0; i < length; i++)
            //{
            //    reversedString[i] = myString[length - i-1];
            //}
            //for (int i = 0; i < reversedString.Length; i++)
            //{
            //    Console.WriteLine(reversedString[i]);
            //}
            //Console.ReadKey();






            #endregion


        }
    }
}
