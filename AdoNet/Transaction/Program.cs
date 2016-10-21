using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction
{
    class Program
    {
        static void Main(string[] args)
        {
            string connStr = "server =.; uid = sa; pwd = hjlsqh; database = Practise";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    //创建事务对象
                    SqlTransaction trans = conn.BeginTransaction();
                    
                    try
                    {
                        cmd.CommandText = "update UserInfo set UserName='GoldFish' where UserId=3; " +
                                                      "update UserInfo set UserAge = 'unkown'where UserId = 3";
                        cmd.Transaction = trans;   //把事务指向cmd对象。
                        cmd.ExecuteNonQuery();
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("执行失败！");
                        trans.Rollback();
                    }
                    
                  

                }
            }
            Console.WriteLine("Done!");
            Console.ReadKey();
        }
    }
}

