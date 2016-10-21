using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 练习__省市选择
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //加载省的数据
            string sqlStr = ConfigurationManager.ConnectionStrings["SqlConnString"].ConnectionString;  //ConnectionStrings的数据要放在App.config中
            string cmdStr = "select AreaId, AreaName, AreaPId from AreaFull where AreaPid = 0";  
            using (SqlConnection conn = new SqlConnection(sqlStr))
            {
                using (SqlCommand sCmd = new SqlCommand(cmdStr, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = sCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //把表格数据转换成object
                            AreaInfo areaInfo = new AreaInfo();  //自定义一个AreaInfo类来存储数据
                            areaInfo.AreaID = int.Parse(reader["AreaId"].ToString());
                            areaInfo.AreaName = reader["AreaName"].ToString();
                            areaInfo.AreaPId = int.Parse(reader["AreaPId"].ToString());
                            //把省的信息放到ComboBox中，ComboBox显示的信息是Item对象中ToString（）。
                            cbxProvince.Items.Add(areaInfo);
                        }
                    }// end using sdr
                }// end using scmd
            }//end using conn

            this.cbxProvince.SelectedIndex = 0;  //默认显示第一条数据
        }

        private void cbxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            //首先清空ComboBox之前存储的数据
            this.cbxCity.Items.Clear();

            string selectProvince= this.cbxProvince.SelectedItem.ToString();
            string cmdStr = string.Format("select AreaId, AreaName, AreaPId from AreaFull where AreaPid in (select AreaId from AreaFull where AreaName='{0}')", selectProvince);
            

            //加载省的数据
            string sqlStr = ConfigurationManager.ConnectionStrings["SqlConnString"].ConnectionString;  //ConnectionStrings的数据要放在App.config中
            
            using (SqlConnection conn = new SqlConnection(sqlStr))
            {
                using (SqlCommand sCmd = new SqlCommand(cmdStr, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = sCmd.ExecuteReader())
                    {
                       while (reader.Read())
                        {
                            //把表格数据转换成object
                            AreaInfo areaInfo = new AreaInfo();  //自定义一个AreaInfo类来存储数据
                            areaInfo.AreaID = int.Parse(reader["AreaId"].ToString());
                            areaInfo.AreaName = reader["AreaName"].ToString();
                            areaInfo.AreaPId = int.Parse(reader["AreaPId"].ToString());
                            //把省的信息放到ComboBox中，ComboBox显示的信息是Item对象中ToString（）。
                            cbxCity.Items.Add(areaInfo);
                        }
                    }// end using sdr
                }// end using scmd
            }//end using conn

            this.cbxCity.SelectedIndex = 0;  //默认显示第一条数据
        }
    }
}
