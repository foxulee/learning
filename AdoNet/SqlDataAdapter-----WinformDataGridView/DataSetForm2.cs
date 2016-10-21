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

namespace SqlDataAdapter_____WinformDataGridView
{
    public partial class DataSetForm2 : Form
    {
        public DataSetForm2()
        {
            InitializeComponent();
        }

        private void DataSetForm2_Load(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            //要查询两张或者多张表
            string cmdStr = @"select UserId, UserName, UserAge, DelFlag, CreateDate, UserPwd, LastErrorDateTime, ErrorTimes from UserInfo;
                             select AreaId, AreaName, AreaPid from AreaFull";

            //此种写法省略了创建SqlConnection和SqlCommand对象，更简洁
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmdStr,connStr) )
            {
                DataSet ds = new DataSet();        //DataSet用得不多，一般用DataTable
                adapter.Fill(ds);
                dgvUserInfo.DataSource = ds.Tables[0];
                dgvAreaInfo.DataSource = ds.Tables[1];
            }
        }
    }
}
