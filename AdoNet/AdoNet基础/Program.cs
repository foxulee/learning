using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdoNet基础
{
    class Program
    {
        static void Main(string[] args)
        {

            #region SqlConnection Object
            ////设置连接字符串，登录信息
            //string connStr = "server=.;uid=sa;pwd=hjlsqh;database=Demo";
            ////初始化对象
            //SqlConnection conn = new SqlConnection(connStr);
            ////打开数据库
            //conn.Open(); //如果连接成功，那么不会抛异常

            //Console.WriteLine("Database opened!");

            //Thread.Sleep(3000);

            ////关闭数据库
            //conn.Close();

            ////释放资源
            //conn.Dispose();

            //Console.WriteLine("Database closed!"); 
            #endregion

            #region SqlCommand Object
            //先创建连接对象
            //string strConn = "server=(local);database=Demo;uid=sa;pwd=hjlsqh";

            #region try写法 (需要写close() dispose())
            //SqlConnection conn = new SqlConnection(strConn);
            //try
            //{
            //    //创建一个Sql对象
            //    SqlCommand cmd = new SqlCommand();
            //    //给命令对象指定连接对象
            //    cmd.Connection = conn;

            //    conn.Open();   //异型要在执行命令之前打开

            //    //写sql script
            //    cmd.CommandText = @"create table Demo 
            //                    (
            //                     tblID int primary key not null,
            //                     tblName nvarchar(32)not null,
            //                     tblAge int null,
            //                     tblGender nvarchar(16) not null
            //                    )";

            //    cmd.ExecuteNonQuery();  //执行一个非查询的sql语句，返回受影响的行数。
            //}
            //finally               //和catch有区别，无论try里面有没有异常，都执行finally中的代码
            //{
            //    conn.Close(); //*********最后一定要关闭连接
            //}
            #endregion

            #region ****using写法 (trycatch的简洁写法，不需要写close() dispose())

            //using (SqlConnection conn = new SqlConnection(strConn))
            //{
            //    //创建一个Sql对象
            //    using (SqlCommand cmd = new SqlCommand())
            //    {
            //        //给命令对象指定连接对象
            //        cmd.Connection = conn;

            //        conn.Open();   //异型要在执行命令之前打开

            //        //写sql script
            //        cmd.CommandText = @"create table Demo 
            //                    (
            //                     tblID int primary key not null,
            //                     tblName nvarchar(32)not null,
            //                     tblAge int null,
            //                     tblGender nvarchar(16) not null
            //                    )";

            //        cmd.ExecuteNonQuery();  //执行一个非查询的sql语句，返回受影响的行数。
            //    }

            //}



            #endregion


            #endregion

            #region ExecuteScalar
            //作用：执行查询
            //返回值：返回查询所返回的结果集中第一行的第一列。 忽略其他列或行。System.Object 结果集中第一行的第一列；如果结果集为空，则为空引用（在 Visual Basic 中为Nothing）
            //适用情况：使用 ExecuteScalar 方法从数据库中检索单个值（例如一个聚合值）。与使用 ExecuteReader 方法，然后使用 SqlDataReader 返回的数据执行生成单个值所需的操作相比，此操作需要的代码较少。
            //string strConn = "server=(local);database=Test;uid=sa;pwd=hjlsqh";
            //string cmdText= "select count(*) from StudentInfo";
            //using (SqlConnection conn= new SqlConnection(strConn))
            //{
            //    using (SqlCommand sCmd = new SqlCommand(cmdText,conn))
            //    {
            //        conn.Open();
            //        object o = sCmd.ExecuteScalar();          //返回查询所返回的结果集中第一行的第一列，因为不能确定返回值的类型，所以返回值是object类型。
            //        Console.WriteLine(o.ToString());

            //        sCmd.CommandText = "select stuName from StudentInfo where stuID=5";
            //        Console.WriteLine("stuName of stuID=5 is {0}",sCmd.ExecuteScalar().ToString());

            //        sCmd.CommandText = "select * from StudentInfo where stuPhone=12345678909";
            //        Console.WriteLine(sCmd.ExecuteScalar().ToString());    //返回的是stuId的值（第一行第一列）
            //    }
            //}


            #endregion

            #region ExecuteNonQuery

            //作用：对连接执行 Transact-SQL 语句并返回受影响的行数。
            //返回值：
            //       类型：System.Int32 受影响的行数。对于 UPDATE、INSERT 和 DELETE 语句，返回值为该命令所影响的行数。 如果正在执行插入或更新操作的表上存在触发器，则返回值包括受插入或更新操作影响的行数以及受一个或多个触发器影响的行数。 对于其他所有类型的语句，返回值为 - 1。 如果发生回滚，则返回值也是 - 1。
            //适用情况：
            //        1.使用 ExecuteNonQuery 来执行目录操作（例如查询数据库的结构或创建诸如表等的数据库对象），或通过执行 UPDATE、INSERT 或 DELETE 语句；ExecuteNonQuery 不返回任何行，但映射到参数的任何输出参数或返回值都会用数据进行填充。
            //        2.ExecuteNonQuery也会返回后运行查询影响的记录数。但是，ExecuteNonQuery不返回任何行或列中的存储过程。如果您只需要知道更改行数，则使用插入、 更新或删除语句时最有用的ExecuteNonQuery方法。在存储过程中使用 SELECT 语句，您收到 - 1，因为查询不会影响任何行。

            //string strConn = "server=(local);database=Test;uid=sa;pwd=hjlsqh";
            //using (SqlConnection conn = new SqlConnection(strConn))
            //{
            //    using (SqlCommand sCmd= conn.CreateCommand())
            //    {
            //        conn.Open();
            //        sCmd.CommandText = "update StudentInfo set stuName='newname' where stuID=5";
            //        Console.WriteLine("{0} row is affected!",sCmd.ExecuteNonQuery());    //return 1

            //        sCmd.CommandText = "select stuName from StudentInfo where stuID=5";
            //        Console.WriteLine("{0} row is affected!", sCmd.ExecuteNonQuery());   //return -1
            //    }
            //}

            #endregion

            #region ExecuteReader
            //作用：将 CommandText 发送到 Connection 并生成一个 SqlDataReader。
            //解释１：将SQL语句发送到指定连接 生成一个SqlDataReader对象
            //解释２：当ExecuteReader()执行后返回一个SqlDataReader对象
            //  两种解释实际上都在说明些方法就是给SqlDataReader对象一个可以访问查询到的结果的渠道。
            //返回值：
            //       类型：System.Data.SqlClient.SqlDataReader SqlDataReader 对象。
            //SqlDataReader的Read方法可以使SqlDataReader前进到下一条记录，同样返回bool值，当下一条无记录返回false，则表示记录读取完毕；当下一条有数据时为true，将读取到的数据（当前的一条记录）暂存在SqlDataReader中。
            //备注： 当 CommandType 属性设置为 StoredProcedure 时，CommandText 属性应设置为存储过程的名称。 当调用 ExecuteReader 时，该命令将执行此存储过程。
            //string strConn = "server=(local);database=Test;uid=sa;pwd=hjlsqh";
            //using (SqlConnection conn = new SqlConnection(strConn))
            //{
            //    using (SqlCommand sCmd = conn.CreateCommand())
            //    {
            //        conn.Open();
            //        sCmd.CommandText = "select * from StudentInfo where stuSex='m'";
            //        using (SqlDataReader reader = sCmd.ExecuteReader())
            //        {
            //            if (reader.HasRows)             //判断是否包含一行或者多行
            //            {
            //                while (reader.Read())      //.Read()执行一次，指针跳到下一行
            //                {
            //                    //Console.WriteLine(reader[0].ToString() + "==>" + reader[1].ToString());   //1.可以同数字取值
            //                    //Console.WriteLine(reader["stuName"].ToString()); //2. 也可以用“列名”取值
            //                    for (int i = 0; i < reader.FieldCount; i++)    //打印每一行的数据
            //                    {
            //                        Console.Write(reader[i] + "   ");
            //                    }
            //                    Console.WriteLine();
            //                }
            //            }
            //        }
            //    }
            //}


            #endregion

            #region DataSet，DataReader，DataTable和DataAdapter的区别
            //http://blog.sina.com.cn/s/blog_7e540ba10102vc26.html

            #endregion



            Console.ReadKey();

        }
    }
}
