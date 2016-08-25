using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow_control
{
    class Program
    {
        static void Main(string[] args)
        {
            //选中要排版的段落，自动排版快捷键Ctrl+K+F
            #region if statement 
            //规范，if和else后都分别加上｛｝，以防止配对出错，并增加程序可读性。
            /* 简单语法
            if (条件)
                ｛语句1；语句2; ....｝ //用一对大括号来组成语句块
            else
                ｛语句1; 语句2; ...｝ //else与离它最近的if是一对，else语句里面还可以if...else套嵌
            */

            /*  if...else if statement语法
            if (条件)
                ｛语句1；语句2; ....｝  //只有当上一个条件不成立时，才会进入下一个if语句并进行if语句后面的条件判断。
            else if
                ｛语句1; 语句2; ...｝ 
            else if
                {语句；}
            .
            .
            .
            else
                {语句；}
             */

            //int var1 = 3;
            //if (var1 > 1)
            //    Console.WriteLine("True"); //if默认只带这一句话，规范：if后不管几句话都要加｛｝。
            //Console.WriteLine("The program is Done."); //此句和if没关系
            //Console.ReadKey();



            //练习1：提示用户输入密码，如果密码是‘888888’则提示正确，否则要求再输入一次，如果密码是‘888888’则提示正确，否则提示错误，程序结束。
            //Console.WriteLine("Please enter the password:");
            //string password = Console.ReadLine();
            //if (password == "888888")
            //{
            //    Console.WriteLine("The password is correct!");
            //}
            //else
            //{
            //    Console.WriteLine("The password is wrong, please enter the password again:");
            //    password= Console.ReadLine();
            //    if (password == "888888")
            //    {
            //        Console.WriteLine("The password is correct!");
            //    }
            //    else { Console.WriteLine("Game over!"); }                
            //}
            //Console.ReadKey();


            //练习2：练习2：提示用户输入用户名，然后再提示输入密码，如果用户名是“admin”并且密码是“888888”，则提示正确，
            //否则，如果用户名不是admin还提示用户用户名不存在,如果用户名是admin则提示密码错误。
            //Console.WriteLine("Please enter your name:");
            //string name = Console.ReadLine();
            //Console.WriteLine("Please enter the password:");
            //string password = Console.ReadLine();
            //if (name == "admin" && password == "888888")
            //{
            //    Console.WriteLine("Correct!");
            //}
            //else
            //{
            //    if (name != "admin")
            //    {
            //        Console.WriteLine("The user doesn't exist.");
            //    }
            //    else if (name == "admin" && password != "888888")
            //    {
            //        Console.WriteLine("The password is wrong.");
            //    }    
            //}
            //Console.ReadKey();


            //练习3：提示用户输入年龄，如果大于等于18，则告知用户可以查看，如果小于10岁，则告知不允许查看，
            //如果大于等于10岁并且小于18，则提示用户是否继续查看（yes、no），如果输入的是yes则提示用户请查看，否则提示"退出,你放弃查看"。
            //Console.WriteLine("Please enter your age:");
            //int age = Convert.ToInt32(Console.ReadLine());
            //if (age >= 18)
            //{
            //    Console.WriteLine("你将查看.");
            //}
            //else if (age < 10)
            //{
            //    Console.WriteLine("不允许查看.");
            //}
            //else
            //{
            //    Console.WriteLine("是否继续查看（\"yes\" or \"no\"）: ");
            //    string yesOrNo = Console.ReadLine();
            //    if (yesOrNo == "yes")
            //    {
            //        Console.WriteLine("你将查看。");
            //    }
            //    else if (yesOrNo == "no")
            //    {
            //        Console.WriteLine("退出，你放弃查看。");
            //    }

            //}
            //Console.ReadKey();



            #endregion

            #region switch...case statement
            /*
            switch-case语法:   //用表达式和变量的值去搜索一下匹配的case，而不是逐句判断执行，所以case和default先后顺序无关紧要。
            switch (表达式 / 变量)
            {
                case 值1:
                    语句块1;    
                    break;      //每一个case和default后都必须有break。
                case 值2:
                    语句块2;
                    break;
                default:       //如果所有case都不匹配，则执行default后的语句。
                    语句块3;
                    break;
            }
            */

            //李四的年终工作评定,如果定为A级,则工资涨500元,如果定为B级,则工资涨200元,如果定为C级,工资不变,如果定为D级工资降200元,如果定为E级工资降500元.
            //设李四的原工资为5000,请用户输入李四的评级,然后显示李四来年的工资.
            //Console.WriteLine("请输入你对李四的评定等级（A-E）");
            //string input = Console.ReadLine();
            //decimal salary = 5000;
            //bool flag = false;  //小技巧加上flag，如果输入的不是A-E，则让switch语句块后的语句不执行（在default中改变flag值）。

            //switch (input)
            //{
            //    case "A":
            //        salary += 500;
            //        break;
            //    case "B":
            //        salary += 200;
            //        break;
            //    case "C":
            //        break;
            //    case "D":
            //        salary -= 200;
            //        break;
            //    case "E":
            //        salary -= 500;
            //        break;
            //    default:
            //        Console.WriteLine("你的输出有问题,请输入A-E");
            //        flag = true;   //小技巧
            //        break;

            //}
            //if (flag==false)      //小技巧
            //{
            //    Console.WriteLine("李四来年的工资是" + salary);
            //}

            //Console.ReadLine();



            #endregion


            #region if-else if与switch的比较

            //相同点: 都可以实现多分支结构
            //不同点: switch:一般 只能用于等值比较; if-else if:可以处理范围

            //习题1：请用户输年份,输入月份,输出该月的天数。
            //Console.WriteLine("Please enter a year:");
            //int year = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter a month:");
            //int month = Convert.ToInt32(Console.ReadLine());
            //switch (month)      //注意month要与case后的变量型相同或比较。
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:                     //多个case后有相同的语句，可以合起来一起写！
            //        Console.WriteLine("31天");
            //        break;
            //    case 2:
            //        if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))  //判断是否为闰年。
            //        {
            //            Console.WriteLine("29天");

            //        }
            //        else
            //        {
            //            Console.WriteLine("28天");

            //        }
            //        break;
            //    default:
            //        Console.WriteLine("30天");
            //        break;
            //}
            //Console.ReadLine();



            //习题2：对学员的结业考试成绩评测(改成用Switch来做)
            //成绩 >= 90 ：A
            // 90 > 成绩 >= 80 ：B
            //80 > 成绩 >= 70 ：C
            //70 > 成绩 >= 60 ：D
            // 成绩 < 60   ：E
            //Console.WriteLine("Please enter your score:");
            //int score = Convert.ToInt32(Console.ReadLine());
            //switch (score/10)      //score/10这是关键点！
            //{
            //    case 10:
            //    case 9:
            //        Console.WriteLine("A");
            //        break;
            //    case 8:
            //        Console.WriteLine("B");
            //        break;
            //    case 7:
            //        Console.WriteLine("C");
            //        break;
            //    case 6:
            //        Console.WriteLine("D");
            //        break;
            //    case 5:
            //    case 4:
            //    case 3:
            //    case 2:
            //    case 1:
            //    case 0:
            //        Console.WriteLine("E");
            //        break;
            //    default:
            //        Console.WriteLine("The score you entered is not correct.");
            //        break;
            //}
            //Console.ReadKey();


            #endregion


            #region while statement
            /* while语法
            while (循环条件)                   //注意整个结构没有“；”
            {
                循环体;
            }
            */

            //n次循环，如果i从0开始，则循环条件为i<n.
            //n次循环，如果i从1开始，则循环条件为i<=n.
            /*
            int i = 0;
            while (i < 5)
            {
                // i = 0 1 2 3 4
                Console.WriteLine("Repeat sentenses!");
                i++;
                //i=5，退出循环。
            }
            Console.ReadKey();
            */


            //练习1：输入班级人数,然后依次输入学员成绩，计算班级学员的平均成绩和总成绩
            //Console.WriteLine("Please enter number of students in the class:");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int i = 1;
            //int sum = 0;
            //double avg = 0;
            //while (i <= num)
            //{
            //    Console.WriteLine("Please enter the score of {0} student",i);
            //    int score = Convert.ToInt32(Console.ReadLine());
            //    sum += score;
            //    avg = (avg*(i-1)+score)/i;
            //    i++;
            //}
            //Console.WriteLine("The sum score is "+sum);
            //Console.WriteLine("The average score is "+avg);
            //Console.ReadKey();


            //练习2： 老师问学生,这道题你会做了吗?如果学生答"会了(y)",则可以放学.如果学生不会做(n),则老师再讲一遍,再问学生是否会做了......
            //直到学生会为止,才可以放学.
            //直到学生会或老师给他讲了5遍还不会,都要放学

            //Console.WriteLine("老师教你第1遍");
            //int i = 1;
            //while (i <= 5)
            //{
            //    i++;
            //    Console.WriteLine("你会做了吗？(y//n)");
            //    string answer = Console.ReadLine();

            //    if (answer == "y")
            //    {
            //        Console.WriteLine("放学了！");
            //        break;
            //    }
            //    else if (answer == "n")
            //    {
            //        if (i <= 5)
            //        {
            //            Console.WriteLine("老师教你第{0}遍", i);
            //        }
            //        else
            //        {
            //            break;
            //        }

            //    }

            //}


            //if (i == 6)
            //{
            //    Console.WriteLine("我已经教了5遍了，你还不会，放学，不教了！");
            //}
            //Console.ReadKey();


            //更优化的写法：
            //while (answer=="n" && i<5)




            //练习3：2006年培养学员80000人，每年增长25%，请问按此增长速度，到哪一年培训学员人数将达到20万人？
            //double numOfPeople = 80000;
            //int year = 0;
            //while (numOfPeople <= 200000)
            //{
            //    numOfPeople += numOfPeople * 0.25;
            //    year++;
            //}
            //Console.WriteLine(2006 + year);
            //Console.ReadKey();


            #endregion


            #region do-while statement
            //先执行，再判断
            //while or do-while？ 循环的先后顺序。假如循环条件一开始就不成立，对于while循环，一次都不会执行。对于do-while循环体会执行一次。所以，do-while的循环体一般至少会被执行一次。
            /* 语法：
            do
            { 循环体；｝
            while (条件) ;                    //*******注意整个结构最后有“；”,这点和和while语句不同！
            */

            //练习1：练习1：计算1到100之间整数的和；
            //int sum = 0;
            //int i = 1;
            //do
            //{
            //    sum += i;
            //    i++;
            //}
            //while (i <= 100) ;
            //Console.WriteLine(sum);
            //Console.ReadLine();



            //练习2：要求用户输入用户名和密码，只要不是admin、888888就一直提示用户名或密码错误,请重新输入。

            //string userName, password;
            //do
            //{
            //    Console.WriteLine("Please enter User Name:");
            //    userName = Console.ReadLine();
            //    Console.WriteLine("{Please enter password:");
            //    password = Console.ReadLine();

            //}
            //while (userName != "admin" && password != "888888");
            //Console.WriteLine("You passed!");
            //Console.ReadKey();



            //练习3：不断要求用户输入学生姓名,输入q结束
            //string name;
            //do
            //{
            //    Console.WriteLine("Please enter your name:");
            //    name = Console.ReadLine();
            //}
            //while (name != "q");
            //Console.ReadKey();


            //练习4：不断要求用户输入一个数字，然后打印这个数字的二倍，当用户输入q的时候程序退出。

            //string input;
            //do
            //{
            //    Console.WriteLine("Please enter a number:");
            //    input = Console.ReadLine();
            //    if (input != "q")
            //    { Console.WriteLine("The double amount is " + 2 * Convert.ToInt32(input)); }
            //}
            //while (input != "q");
            //Console.ReadKey();

            //用try...catch解法2                                              ///*****记住try catch while循环用法！！！
            //int input;
            //bool flag = true;
            //do
            //{
            //    try
            //    {
            //        console.writeline("please enter a number:");
            //        input = convert.toint32(console.readline());
            //        console.writeline("the double amount is " + 2 * convert.toint32(input));
            //        flag = true;
            //    }
            //    catch
            //    {
            //        flag = false;
            //    }
            //}
            //while (flag);
            //console.readkey();




            //练习5：不断要求用户输入一个数字（假定用户输入的都是正整数），当用户输入end的时候显示刚才输入的数字中的最大值
            //int number, max;
            //string input;
            //number = 0;
            //max = 0;
            //do
            //{
            //    Console.WriteLine("Please enter a number:");
            //    input = Console.ReadLine();
            //    if (input!="end")
            //    {
            //        number = Convert.ToInt32(input);
            //    };

            //    if (number >= max && input != "end")
            //    {
            //        max = number;
            //    }
            //}
            //while (input != "end");
            //Console.WriteLine("The max number your just entered is " + max);
            //Console.ReadKey();




            //练习6：张三先唱一遍要表演的歌曲,老师觉得张三唱歌不过关,就让张三再唱一遍,老师满意则张三可以下课,不然则需要再唱一遍,再问老师是否满意...
            //string answer;
            //do
            //{
            //    Console.WriteLine("张三唱歌");
            //    Console.WriteLine("老师，可以了吗？（y/n）");
            //    answer = Console.ReadLine();
            //    while (answer != "y" && answer != "n")                     //**********加入只能输入y和n的控制循环
            //    {                                                          //
            //        Console.WriteLine("只能输入y和n，请重新输入：");         //
            //        answer = Console.ReadLine();                           //
            //    }                                                          //

            //}
            //while (answer == "n");
            //Console.WriteLine("你可以下课了！");
            //Console.ReadKey();



            #endregion


            #region for statement
            //for (表达式1; 表达式2(bool 循环条件); 表达式3)
            //{ 循环体; };
            /*
             比如
             for (int i=1;i<10;i++)                             //****注意：如果i写在for（）里，那么的i的作用范围只能在循环体中使用，如果希望i在循环体外也能作用，则用以下变体。
             {
                 循环体;
             }

             */

            /* for循环变体
            int i=0;
            for (; i < 10; i++)
            {
                Console.WriteLine("Print {0} times", i);
            }
            Console.WriteLine("i={0}", i);                      //i在for以外定义的话，最后的值为10.
            Console.ReadKey();
            */



            //习题1：求1-100间的所有偶数和?
            //int sum = 0;
            //for (int i = 2; i <= 100; i += 2)
            //{
            //    sum +=i;
            //}
            //Console.WriteLine("Sum is {0}", sum);
            //Console.ReadLine();



            //习题2：找出100-999间的水仙花数?水仙花数是指一个 n 位数 ( n≥3 )，它的每个位上的数字的 n 次幂之和等于它本身。（例如：1^3 + 5^3+ 3^3 = 153）
            //int daffodilNum;
            //int hundDigit, tenthDigit, unitDigit;
            //for (int i = 100; i <= 999; i++)
            //{
            //    hundDigit = i / 100;
            //    tenthDigit = (i - hundDigit * 100) / 10;
            //    unitDigit= (i - hundDigit * 100) % 10;
            //    if (i == hundDigit * hundDigit * hundDigit + tenthDigit * tenthDigit * tenthDigit + unitDigit * unitDigit * unitDigit)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadKey();


            //习题3：输出九九乘法表(循环的嵌套)
            //三角形排列
            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = i; j >= 1; j--)
            //    {
            //        Console.Write("{0}*{1}={2:00}   ", (i - j + 1), i, i * (i - j + 1));              //*******占位符{2:00}中的：00表示占两位，如果只有一位，则用0补齐，如果超过两位则不受限制!!!

            //    }
            //    Console.Write("\n");       //换行
            //}
            //Console.ReadKey();


            ////矩形排列
            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= 9; j++)
            //    {
            //        Console.Write("{0}*{1}={2:00} ", i, j, i * j);                                    //*******占位符{2:00}中的：00表示占两位，如果只有一位，则用0补齐，如果超过两位则不受限制!!!
            //    }
            //    Console.Write("\n");
            //}
            //Console.ReadKey();



            //习题4：用户输入一个值，输出加法表,乘法表。
            //Console.WriteLine("Please enter a number:");
            //int num= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("The addition table is:");
            //for (int i = 0; i <= num; i++)
            //{

            //        Console.WriteLine("{0} + {1} = {2}", i, num-i, num);

            //}
            //Console.ReadKey();

            //Console.WriteLine("The multiplication table is: ");
            //for (int i = 1; i <= num; i++)
            //{
            //    if(num%i==0)
            //    {
            //        Console.WriteLine("{0} * {1} = {2}", i, num / i, num);
            //    }

            //}
            //Console.ReadKey();

            #endregion


            #region continue和break
            //break经常和if语句配合使用。

            //习题1：循环录入5个人的年龄并计算平均年龄,如果录入的数据出现负数或大于100的数,立即停止输入并报错.
            //int sum = 0;
            //int age, avg=0;
            //bool flag = true;
            //Console.WriteLine("Please enter the age of 5 people: ");
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("The age of number {0}", i);
            //    age=Convert.ToInt32(Console.ReadLine());
            //    if (age < 100 && age > 0)
            //    {
            //        sum += age;
            //        avg = sum / i;

            //    }
            //    else
            //    {
            //        Console.WriteLine("The age is out of range!");
            //        flag= false;
            //        break;

            //    }
            //}

            //if (flag)
            //{
            //    Console.WriteLine("The average age is {0}", avg);
            //}
            //Console.ReadKey();





            //习题2：在while中用break实现要求用户一直输入用户名和密码，只要不是admin、888888就一直提示要求重新输入,如果正确则提登录成功.
            //string userName, password;
            //do
            //{
            //    Console.WriteLine("Please enter username: ");
            //    userName = Console.ReadLine();
            //    Console.WriteLine("Please enter password: ");
            //    password = Console.ReadLine();
            //    if (userName == "admin" && password == "888888")
            //    {
            //        Console.WriteLine("Log in successifully!");
            //        break;

            //    }
            //}
            //while (true) ;
            //Console.ReadKey();




            //习题3：1~100之间的整数相加，得到累加值大于20的当前数
            //int sum = 0;
            //int i = 1;
            //for (; i <= 100; i++)
            //{
            //    sum += i;
            //    if (sum > 20)
            //    {
            //        Console.WriteLine("当前数为" + i);
            //        break;
            //    }
            //}
            //Console.ReadKey();



            //习题4：用for/while continue实现计算1到100(含)之间的除了能被7整除之外所有整数的和。
            //int sum = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();


            //int sum = 0;
            //int i = 1;
            //while (i <= 100)
            //{
            //    if (i % 7 == 0)
            //    {
            //        i++;
            //        continue;
            //    }
            //    else
            //    {
            //        sum += i++;

            //    }

            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();

            #endregion


            #region try...catch
            //利用try...catch和while循环实现“限制用户只能输入数字,并且数字的值必须在0到100之间！”
            //int age = 0;                                                     //注意循环中用到的变量尽量在循环外面定义！
            //bool isNumber = false;
            //bool isBetweenZeroAndHundred=false;
            //while (isNumber==false || isBetweenZeroAndHundred==false)                                          //跳出while循环除了用break，还是如本题一样用一个bool类型的flag变量！
            //{
            //    try
            //    {
            //        Console.WriteLine("************************************************************************");
            //        Console.WriteLine("Please enter your age: ");
            //        age = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("The age you entered is: " + age);
            //        isNumber = true;                                         //!!!!!!!!!!!!!!!!!!!!!
            //        if (age >= 0 && age <= 100)
            //        {
            //            Console.WriteLine("The age is between 0 and 100!");
            //            isBetweenZeroAndHundred = true;
            //        }
            //        else
            //        {
            //            Console.WriteLine("The age is out of range! The age must be between 0 and 100. \nPlease enter again! Press any key to continue...");
            //            Console.ReadKey();
            //            isBetweenZeroAndHundred = false;
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("The age should be a number!\nPlease enter again! Press any key to continue...");
            //        Console.ReadKey();
            //        isNumber = false;                                        //!!!!!!!!!!!!!!!!!!!!!
            //    }
            //}
            //Console.ReadKey();



            #endregion


            #region The Ternary Operator 三元表达式
            //可以简洁地取代if...else
            //语法：(expression1)?expression2 : expression3
            //例：
            //Console.WriteLine("Please enter a number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //string resultString= ( num > 10 )?  "Greater than 10." : "Less or equal to 10!";
            //Console.WriteLine(resultString);
            //Console.ReadKey();




            #endregion


            #region goto
            //goto太灵活，不建议使用，不利于程序阅读！
            //如果有时候要从套嵌循环的最里层break跳出循环，goto容易实现。但是建议用bool=false/true结合if的方式来取代goto。
            //任何时候都不要使用goto。


            #endregion
        }
    }
}
