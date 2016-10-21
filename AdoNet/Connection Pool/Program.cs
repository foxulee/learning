using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            string connStrPool = "server=.;uid=sa;pwd=hjlsqh;database=Demo;pooling=true;min pool size=8";       //pool默认就是true
            string connStr = "server=.;uid=sa;pwd=hjlsqh;database=Demo;pooling=false";

            int i = 1;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (i<1000)
            {
                using (SqlConnection conn = new SqlConnection(connStrPool))
                {
                    conn.Open();
                }
                i++;
            }
            sw.Stop();
            Console.WriteLine("The running time of connection with Pool is {0} seconds.", sw.Elapsed.Seconds);
            
            sw.Reset();
            sw.Restart();
            i = 0;
            while (i < 1000)
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                }
                i++;
            }
            sw.Stop();
            Console.WriteLine("The running time of connection without Pool is {0} seconds.", sw.Elapsed.Seconds);

            Console.ReadKey(true);
        }
    }
}
