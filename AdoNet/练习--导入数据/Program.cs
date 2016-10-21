using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace 练习__导入数据
{
    class Program
    {
        static void Main(string[] args)
        {
            //获取文件路径
            string filePath = @"M:\net24期\2015-04-25 数据库03\资料\资料\Data.txt";
            //读取文件每一行
            IEnumerable<string> lines = File.ReadLines(filePath);

            //获取App.Config中的connnectionstr
            string connStr = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;


            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand sCmd = conn.CreateCommand())
                {
                    conn.Open();  //只能open一次！！！
                    foreach (string line in lines)
                    {
                        string[] lineStr = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        if (lineStr[0] != "stuId")
                        {

                            //Console.WriteLine(lineStr[1]+"  "+ lineStr[2]+"   "+ lineStr[3]+"   "+ lineStr[1]);
                            string sql =
                                string.Format(
                                    @"insert into StudentInfo(stuName,stuSex,stuBirthdate,stuPhone) values ('{0}','{1}','{2}','{3}')",
                                    lineStr[1], lineStr[2], lineStr[3], lineStr[4]);
                            sCmd.CommandText = sql;
                            Console.WriteLine(sql);
                            sCmd.ExecuteNonQuery();

                        }
                    }
                }
            }

            Console.ReadKey();
        }

        
    }
}
