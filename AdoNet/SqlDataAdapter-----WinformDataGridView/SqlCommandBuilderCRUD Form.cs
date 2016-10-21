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
    public partial class SqlCommandBuilderCRUD_Form : Form
    {
        public SqlCommandBuilderCRUD_Form()
        {
            InitializeComponent();
        }

        private void SqlCommandBuilderCRUD_Form_Load(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
         
            string cmdStr = @"select UserId, UserName, UserAge, DelFlag, CreateDate, UserPwd, LastErrorDateTime, ErrorTimes from UserInfo";

            using (SqlDataAdapter adapter = new SqlDataAdapter(cmdStr, connStr))
            {
                DataTable dt = new DataTable();       
                adapter.Fill(dt);
                dgvUserInfoCRUD.DataSource = dt;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //把DataGridView的修改保存到数据库中
            string connStr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;

            //修改的sql脚本一定要和上面查询的sql脚本一致
            string cmdStr = @"select UserId, UserName, UserAge, DelFlag, CreateDate, UserPwd, LastErrorDateTime, ErrorTimes from UserInfo";

            using (SqlDataAdapter adapter= new SqlDataAdapter(cmdStr,connStr) )
            {
                DataTable dt = this.dgvUserInfoCRUD.DataSource as DataTable;
                //SqlCommandBuilder帮Adapter生成相关的CRUD SqlCommand
                using (SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter) )
                {
                    adapter.Update(dt);
                }
                
            }
            MessageBox.Show("保存成功！");

        }
    }
}
