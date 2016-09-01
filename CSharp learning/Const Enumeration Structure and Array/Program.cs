using System;
using System.Collections;                            //要使用动态数组ArrayList, 需要using System.Collections
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
            //语法 常量名要大写。
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


            #region Array, ArrayList, List （很重要）
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




            ////��������数组的查找
            ////� Array.IndexOf(Array, obj); 查找arr数组中第一个出现obj元素的索引
            ////� Array.LastIndexOf(arr, obj); 查arr找数组中最后一个出现obj元素的索引

            //int[] arr = new int[] { 3, 2, 1, 5, 2, 4 };
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            //int z = Array.IndexOf(arr, 2);
            //int j = Array.LastIndexOf(arr, 2);

            //Console.Write("第一次出现2的索引位：" + z);
            //Console.WriteLine("最后一次出现2的索引位：" + j);
            ////c#提供的Array.IndexOf和Array.LastIndexOf方法还提供了两种方法：
            ////� Array.IndexOf(Array, obj, beginIndex); 开始查询的索引位。
            ////� Array.IndexOf(Array, obj, beginIndex, count); 起始查询的索引位，索引往大的方向累加查询数。
            ////� Array.LastIndexOf(Array, obj, beginIndex); 开始查询的索引位。
            ////� Array.LastIndexOf(Array, obj, beginIndex, count); 起始查询的索引位，索引往小的方向累加查询数。



            //��������数组的排序
            //� Array.Sort(arr); 用于对一维Array对象中的元素由小到大默认进行排序
            //� Array.Reverse(arr); 反转一维arr
            //� Array.Sort(arr, beginIndex, count); 用于对一维Array对象部分中的元素进行排序,从beginIndex索引开始，操作count个元素
            //� Array.Reverse(arr, beginIndex, count); 反转一维arr或部分arr中元素的顺序，从beginIndex索引开始，操作count个元素


            //�数组在C#中最早出现的。在内存中是连续存储的，所以它的索引速度非常快，而且赋值与修改元素也很简单。但是数组存在一些不足的地方。在数组的两个数据间插入数据是很麻烦的，而且在声明数组的时候必须指定数组的长度，数组的长度过长，会造成内存浪费，过段会造成数据溢出的错误。如果在声明数组时我们不清楚数组的长度，就会变得很麻烦。针对数组的这些缺点，C#中最先提供了ArrayList对象来克服这些缺点。

            //��������ArrayList
            //ArrayList是命名空间System.Collections下的一部分，在使用该类时必须进行引用，同时继承了IList接口，提供了数据存储和检索。ArrayList对象的大小是按照其中存储的数据来动态扩充与收缩的。所以，在声明ArrayList对象时并不需要指定它的长度。

            ArrayList arrayList = new ArrayList();                                       //要使用动态数组ArrayList, 需要using System.Collections
            //�Add方法用于添加一个元素到当前列表的末尾  
            arrayList.Add("cde");
            arrayList.Add(5678);
            arrayList.Add('a');
            //�AddRange方法用于添加一批元素到当前列表的末尾
            String[] strlist = { "test1", "test5", "test9", "test13", "test18", "test24" };
            arrayList.AddRange(strlist);          //传入参数必须是数组名，不能直接把数组放进去。
            //�修改数据  
            arrayList[1] = 34;
            //�Remove方法用于删除一个元素，通过元素本身的引用来删除
            arrayList.Remove("test1");
            //�RemoveAt方法用于删除一个元素，通过索引值来删除  
            arrayList.RemoveAt(0);
            //�Insert用于添加一个元素到指定位置，列表后面的元素依次往后移动  
            arrayList.Insert(0, "qwe");
            //�InsertRange用于从指定位置开始添加一批元素，列表后面的元素依次往后移动
            arrayList.InsertRange(1,strlist);
            //�缩减容量 - ArrayList.TrimToSize（）；将集合的容量减少到实际元素个数的大小.在执行删除操作后，要养成良好的缩减容量的习惯，节省内存空间，提高性能。
            //�Clear方法用于清除现有所有的元素
            //�查找元素-除了按数组的索引查找外，还可以用ArrayList.Contains（value）；按照元素值查找集合，如果包含便返回True，不包含时返回False。
            //if (arrayList.Contains('a'))
            //{
            //    Console.WriteLine("Contains 'a'");
            //}
            //else
            //{
            //    Console.WriteLine("Non!");
            //}


            //���遍历 ArrayList 对象的方法
            //方法1：
            foreach (object o in arrayList)                      //此处要用object类型i，因为ArrayList是object.
            {
                Console.Write(o.ToString() + " ");
            }
            Console.ReadKey();

            //方法2：
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.Write(arrayList[i].ToString() + " ");
            }
            Console.ReadKey();

            //ArrayList好像是解决了数组中所有的缺点，为什么又会有List？我们从上面的例子看，在List中，我们不仅插入了字符串cde，而且插入了数字5678。这样在ArrayList中插入不同类型的数据是允许的。因为ArrayList会把所有插入其中的数据当作为object类型来处理，在我们使用ArrayList处理数据时，很可能会报类型不匹配的错误，也就是ArrayList不是类型安全的。在存储或检索值类型时通常发生装箱和取消装箱操作，带来很大的性能耗损。装箱与拆箱的概念：简单的说:装箱：就是将值类型的数据打包到引用类型的实例中比如将string类型的值abc赋给object对象obj。拆箱：就是从引用数据中提取值类型比如将object对象obj的值赋给string类型的变量i。装箱与拆箱的过程是很损耗性能的。
            //更详细的了解：http://www.cnblogs.com/toconnection/archive/2011/04/11/2012645.html


            //��������List
            //因为ArrayList存在不安全类型与装箱拆箱的缺点，所以出现了泛型的概念。List类是ArrayList类的泛型等效类，它的大部分用法都与ArrayList相似，因为List类也继承了IList接口。最关键的区别在于，在声明List集合时，我们同时需要为其声明List集合内数据的对象类型。
            List<string> list = new List<string>();
            //�新增数据  
            list.Add("adc");               //如果我们往List集合中插入int数组123，IDE就会报错，且不能通过编译。这样就避免了前面讲的类型安全问题与装箱拆箱的性能问题了。
            //�修改数据  
            list[0] = "def";
            //�移除数据  
            list.RemoveAt(0);



            //���总结：数组的容量是固定的，您只能一次获取或设置一个元素的值，而ArrayList或List<T> 的容量可根据需要自动扩充、修改、删除或插入数据。数组可以具有多个维度，而 ArrayList或 List<T> 始终只具有一个维度。但是，您可以轻松创建数组列表或列表的列表。特定类型（Object 除外）的数组 的性能优于 ArrayList的性能。 这是因为 ArrayList的元素属于 Object 类型；所以在存储或检索值类型时通常发生装箱和取消装箱操作。不过，在不需要重新分配时（即最初的容量十分接近列表的最大容量），List<T> 的性能与同类型的数组十分相近。在决定使用 List< T > 还是使用ArrayList 类（两者具有类似的功能）时，记住List<T> 类在大多数情况下执行得更好并且是类型安全的。如果对List<T> 类的类型T 使用引用类型，则两个类的行为是完全相同的。但是，如果对类型T使用值类型，则需要考虑实现和装箱问题。



            //��������Array,List和ArrayList间的转换:可以用遍历的方法装换，不过这种方法无疑有些笨拙。下面是一些简单点的方法：
            //数组Array转换成ArrayList和List
            int[] arrayToConvert = { 1, 2, 3, 5 };
            List<int> newList = new List<int>(arrayToConvert);
            ArrayList newArrayList = new ArrayList(arrayToConvert);
            //ArrayList和List转换成数组Array
            int[] newArray1 =newList.ToArray();               //List转换成Array,方法一

            int[] newArray2 = new int[newList.Count];         //List转换成Array,方法二
            newList.CopyTo(newArray2);                        
            Console.WriteLine("Type of newArray2 is "+newArray2.GetType());

            int[] newArray3 =(int[])newArrayList.ToArray(typeof(Int32));           //ArrayList转换为Array，方法一。此处的int32还可以为string等其他类型

            int[] newArray4 = new int[newArrayList.Count];                         //ArrayList转换为Array，方法二
            newArrayList.CopyTo(newArray4);                        
            Console.WriteLine("Type of newArray4 is "+newArray4.GetType());       //.GetType().得到值类型




            //��������数组Array和集合List的交集，差集，合并，去重，判断
            //在开发过程中.数组和集合的处理一般会用for or foreach 来处理一些操作.这里介绍一些常用的集合跟数组的操作函数.
            //�两个集合的合并

            List<int> listA = new List<int> { 1, 2, 3, 5, 7, 9 };

            List<int> listB = new List<int> { 13, 4, 17, 29, 2 };


            listA.AddRange(listB);                                        //把集合A.B合并
            List<int> listC = listA.Union(listB).ToList<int>();           //.Union()剔除重复项 
            List<int> listD = listA.Concat(listB).ToList<int>();          //.Concat()保留重复项
            int q=listA.BinarySearch(1);                                  //判断集合中是否包含某个值.如果包含则返回0



            //�两个数组的合并
            int[] arrayA = new int[] { 1, 2 };
            int[] arrayB = new int[] { 2, 3 };
           
            List<int> r = new List<int>();
            r.AddRange(arrayA);
            r.AddRange(arrayB);
            int[] arrayC = r.ToArray();                                 // 合并数组
            int[] arrayD = arrayA.Union(arrayB).ToArray();              //Union()剔除重复项 
            int[] arrayE = arrayA.Concat(arrayB).ToArray();             //Concat()保留重复项
            int n = Array.BinarySearch(arrayA, 3);                      //判断数组中是否包含某个值.如果包含则返回0

            //�集合的取交集
            List<int> list1 = new List<int> { 1, 2, 3, 5, 9 };
            List<int> list2 = new List<int> { 4,3,9};
            bool isIntersected = list1.Intersect(list2).Count() > 0;    //.Intersect( )

            //集合的取差集 (list1有，list2沒有)
            bool isExcepted = list1.Except(list2).Count() > 0;          //.Except( )

            //数组的交集和差集
            int[] array1 = { 1, 2, 3, 5, 9 };
            int[] array2= { 4, 3, 9 };
            int[] arrayIntersected = array1.Intersect(array2).ToArray();   //注意两个数组Interesect，Except，Union，Concat完了后是一个集合List，用ToArray()再转化为数组Array。
            int[] arrayExcepted = array1.Except(array2).ToArray();





            Console.ReadKey();
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



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
