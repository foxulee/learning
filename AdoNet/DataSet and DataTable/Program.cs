using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSet_and_DataTable
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            //创建一个内存的数据集 using System.Data
            DataSet ds = new DataSet("ds");

            //-----------第一张表-----------
            //创建一张内存表
            DataTable dt1 = new DataTable("dt1");

            //把表放到dataset里面去
            ds.Tables.Add(dt1);

            //给表定义列
            DataColumn dcName = new DataColumn("dcName",typeof(string));
            DataColumn dcAge = new DataColumn("dcAge",typeof(int));
            DataColumn dcId = new DataColumn("dcId",typeof(int));

            //把列放到表里面去 两种方式：
            dt1.Columns.Add(dcId);
            dt1.Columns.AddRange(new DataColumn[] {dcName,dcAge});

            //给表添加数据（行） ，添加的参数顺序必须和column的一致
            dt1.Rows.Add(1, "Charlie", 32);
            dt1.Rows.Add(2, "Jason", 2);
            dt1.Rows.Add(3, "GoldFish", 32);


            //----------第二张表----------
            DataTable dt2 = new DataTable("dt2");

            ds.Tables.Add(dt2);

            DataColumn dcName2 = new DataColumn("dcName2", typeof(string));
            DataColumn dcAge2 = new DataColumn("dcAge2", typeof(int));
            DataColumn dcId2 = new DataColumn("dcId2", typeof(int));
            
            dt2.Columns.AddRange(new DataColumn[] {dcId2, dcName2, dcAge2 });

            //给表添加数据（行）
            dt2.Rows.Add(4, "Jay", 32);
            dt2.Rows.Add(5, "Sam", 2);
            dt2.Rows.Add(6, "null", 32);


            //遍历DataSet
            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    Console.WriteLine(row[0]+"  "+row[1]+"  "+ row[2]);
                }
            }

            Console.ReadKey();
        }
    }
}
