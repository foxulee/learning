using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stored_Procedure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int pageIndex=1;
        private int pageSize;
        private int totalPage;
        private void Form1_Load(object sender, EventArgs e)
        {
            pageIndex = 1;    //设置默认显示第一页
            pageSize = 3;
            LoadList();
        }

        private void LoadList()
        {
            string sql = "GetPageList"; //stored procedure name
            SqlParameter pCount = new SqlParameter("@rowsCount", SqlDbType.Int);  //要获得传出值必须把参数定义卸载using外，即连接close之后
            SqlParameter pIndex = new SqlParameter("@pageIndex", pageIndex);
            SqlParameter pSize = new SqlParameter("@pageSize", pageSize);
            using (SqlConnection conn = new SqlConnection("server =.; uid = sa; pwd = hjlsqh; database = Practise"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    //指定命令类型为存储过程，（默认为text）
                    cmd.CommandType=CommandType.StoredProcedure;
                    //设置参数
                    
                    pCount.Direction = ParameterDirection.Output;   //将参数设置为输出
                    cmd.Parameters.Add(pIndex);
                    cmd.Parameters.Add(pSize);
                    cmd.Parameters.Add(pCount);

                    cmd.CommandText = sql;

                    SqlDataReader reader = cmd.ExecuteReader();
                    List<UserInfo> list = new List<UserInfo>();
                    while (reader.Read())
                    {
                        list.Add(new UserInfo()
                        {
                            UserName = reader["UserName"].ToString(),
                            UserId = Int32.Parse(reader["UserId"].ToString())
                        });
                    }
                    dgvUserInfo.DataSource = list;
                }
                
            }
            txtTotalCount.Text = pCount.SqlValue.ToString();
            totalPage = Int32.Parse(pCount.SqlValue.ToString());
        }

        private void nextPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int pageCount = (int)Math.Ceiling(totalPage * 1.0 / pageSize);
            if (pageIndex < pageCount)
            {
                pageIndex += 1;
                previousPageToolStripMenuItem.Enabled = true;
            }
            else
            {
                nextPageToolStripMenuItem.Enabled = false;
            }
            
            LoadList();
        }

        private void previousPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (pageIndex>1)
            {
                pageIndex -= 1;
                nextPageToolStripMenuItem.Enabled = true;
            }
            else
            {
                previousPageToolStripMenuItem.Enabled = false;
            }
            LoadList();
        }
    }
}
