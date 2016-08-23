using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {/// <summary>
    /// 注释函数
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region How to make comments!
            // This is one way to comment. Only one line!
            /* This is another way to comment
             * With multiple lines.*/
            #endregion

            #region Declaring variables and types of variables.
            //***Note that there is no upper limit on the amount of characters making up a string , because it can use varying amounts of memory.
            /*  variable naming rules:
             *  1.  The ﬁrst character of a variable name must be either a letter, an underscore character ( _ ), or the at symbol ( @ ) 
             *  2.  Subsequent characters may be letters, underscore characters, or numbers. */

            /*For simple variables, stick to camelCase; Use PascalCase for certain more advanced naming. */

            //char myChar = 'a';
            //string myString = "\"myInteger\" is";
            //int myInt1 = 17, myInt2 = 1000;
            //float myFloat = 1.7f;
            //double myDouble = 1.7;
            //decimal myDecimal = 1.7m;

            //string myPath = @"C:\Temp\MyDir\MyFile.doc";
            //string uncommonQuot= @"C:\Temp\MyDir""\MyFile.doc"; //注意用了@后要用到”的时候，用两个“”，因为/的作用失效。
            //Console.WriteLine(uncommonQuot);


            //Console.WriteLine(myString);
            //Console.WriteLine("This is a character: {0} and this is a number: {1}", myChar, myInt1);
            //Console.ReadKey();
            #endregion

            #region Concatenation of two strings with "+".The += operator can also be used with strings, just like +.
            //string var1 = "1+2",var2 = "=3", var3;
            //var3 = var1 + var2;
            //Console.WriteLine(var3);
            //Console.ReadKey();
            #endregion

            #region Manipulating Variableswith MathematicalOperators.
            //double firstNumber, secondNumber;
            //string userName;
            //Console.WriteLine("Enter your name:");
            //userName = Console.ReadLine();
            //Console.WriteLine("Welcome {0}!", userName);
            //Console.WriteLine("Now give me a number:");
            //firstNumber = Convert.ToDouble(Console.ReadLine());   //Remember Convert.ToDouble()的用法!!!
            //Console.WriteLine("Now give me another number:");
            //secondNumber = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("The sum of {0} and {1} is {2}.", firstNumber,
            //secondNumber, firstNumber + secondNumber);
            //Console.WriteLine("The result of subtracting {0} from {1} is {2}.",
            //secondNumber, firstNumber, firstNumber - secondNumber);
            //Console.WriteLine("The product of {0} and {1} is {2}.", firstNumber, secondNumber, firstNumber * secondNumber);
            //Console.WriteLine("The result of dividing {0} by {1} is {2}.",
            //firstNumber, secondNumber, firstNumber / secondNumber);
            //Console.WriteLine("The remainder after dividing {0} by {1} is {2}.",
            //firstNumber, secondNumber, firstNumber % secondNumber);
            //Console.ReadKey();
            #endregion

            #region Variable conversion
            int num1 = 10, num2 = 3;
            int mod = num1 / 3;
            double quo = 1.0*num1 / num2;  //隐式转换
            double quo1 = (double)num1 / num2;  //显式转换
            //对于表达式，如果一个操作数为double型，则整个表达式提升为double型！
            Console.WriteLine("mod = {0}, quo = {1}, quo1 = {2}", mod, quo, quo1);
            Console.ReadLine();


            //一件商品打8.8折后出现小鼠，商家为了结算方便，只收用户整数部分的钱，应该如何做？
            int salePrice,itemPrice = 9;
            salePrice = (int)(itemPrice * 0.88);

            //Q:让用户输入语文和数学成绩，计算总成绩并显示出来。利用Conver.Toint32(Double)，Console.Readline读取的都是string。反过来一切类型都可以转换成string，Convert.ToString().
            //Console.WriteLine("Please input your Chinese Score");
            //double chineseScore = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Please input your Math Score");
            //double mathScore = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Your total score is {0}",chineseScore+mathScore);
            //Console.ReadKey();

            //如上题，如果用户输入的内容不能被转换为int或者double（比如输入一个字母），程序会报错。可以用try...catch...来解决，要求用户重新输入。
            /*
            try
            {
                codes to be tested
            }
            catch
            {
                codes here will be excuted only if error occurs in try block.
                Console.WriteLine("你刚刚输入的数据有问题，请重新运行");
           
            }
            */

            #endregion

            #region 练习，计算几天（如46天）是几周零几天。
            //Console.WriteLine("Please input a day");
            //int days = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("{0} days is {1} weeks and {2} days", days, days/7, days%7);
            //Console.ReadLine();
            #endregion

            #region 练习：107653秒是几天几小时几分钟几秒？然后修改后，让用户输入一个数值。
            //Console.WriteLine("Please input a number of seconds:");
            //int secondTotal = Convert.ToInt32(Console.ReadLine());
            //int day = secondTotal / 60 / 60 / 24;
            //int hour = (secondTotal - day * 60 * 60 * 24) / 60 / 60;
            //int minute = (secondTotal - day * 60 * 60 * 24 - hour * 60 * 60) / 60;
            //int second = secondTotal - day * 60 * 60 * 24 - hour * 60 * 60 - minute * 60;
            //Console.WriteLine("{0} seconds is {1} days, {2} hours, {3} minutes, and {4} seconds", secondTotal, day,hour,minute,second);
            //Console.ReadKey();

            #endregion

            #region 当使用&&和||时，容易忽略的地方。
            int a = 10;
            int b = 5;
            bool result1 = ++a > 50 && ++b > 1;  //注意当用&&时，如果第一个逻辑表达式为false，则第二个逻辑表达式被忽略不参与运算。
            Console.WriteLine("a={0}, b={1}",a, b);
            Console.ReadKey();

            int c = 10;
            int d = 5;
            bool result2 = ++c > 5 || ++b > 1;
            Console.WriteLine("c={0}, d={1}", c,d); //注意当用||时，如果第一个逻辑表达式为true，则第二个逻辑表达式被忽略不参与运算。
            Console.ReadKey();

            #endregion






        }
    }
}
