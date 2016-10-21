using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlDataAdapter_____WinformDataGridView
{
    public partial class Mainfrm : Form
    {
        public Mainfrm()
        {
            InitializeComponent();
           
        }

        private void Mainfrm_Load(object sender, EventArgs e)
        {
           
            //把UserInfo表中的数据加载到窗体的DataGridView中
            string connStr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;


            using (SqlConnection conn = new SqlConnection(connStr))
            {
                //Sql select command string
                string strSql =
                    "select UserId, UserName, UserAge, DelFlag, CreateDate, UserPwd, LastErrorDateTime, ErrorTimes from UserInfo";
                //创建SqlDataAdapter类
                using (SqlDataAdapter adapter = new SqlDataAdapter(strSql, conn))
                {
                    //adapter内部封装了reader创建连接，执行cmd.CommandText(SqlScript)
                    DataTable dt = new DataTable();
                    //把数据库中的数据填充到内存表dt中
                    //fill之前不需要打开数据库连接，adapter会自动打开连接，并执行sql
                    //Fill()内部：先判断SqlConnection是否初始化，如果没有open连接，那么.Open()；再初始化一个select sql Sqlcommand对象；通过cmd对象执行然后返回一个SqlDataReader对象。；最后序曲数据库中的数据填充到DataTable中。
                    adapter.Fill(dt);

                    //!!只在做测试的时候这么写。要把弱类型的数据转换成强类型的数据。定义List<T>
                    this.dgvAllUserInfo.DataSource = dt;

                    //先创建对象List<UserInfo>，然后再绑定给DataGridView
                    List<UserInfo> userList = new List<UserInfo>();

                    foreach (DataRow row in dt.Rows)
                    {
                        //把每一行数据封装成UserInfo对象
                        UserInfo user = new UserInfo();
                        user.UserName = row["UserName"].ToString();
                        user.UserAge =
                            int.Parse(row["UserAge"] == DBNull.Value ? string.Empty : row["UserAge"].ToString());
                        user.UserId = int.Parse(row["UserId"].ToString());
                        user.DelFlag = short.Parse(row["DelFlag"].ToString());
                        user.CreateDate =
                            DateTime.Parse(row["CreateDate"] == DBNull.Value
                                ? SqlDateTime.MinValue.ToString()
                                : row["CreateDate"].ToString());                        //判断，如果为空值，就给一个默认值
                            if (row["LastErrorDateTime"] != DBNull.Value)               //判断，如果为空值，就不赋值
                        {
                            user.LastErrorDateTime = DateTime.Parse(row["LastErrorDateTime"].ToString());
                        }
                        user.ErrorTimes = int.Parse(row["ErrorTimes"].ToString());
                        userList.Add(user);

                    }
                    this.dgvSelectedUserInfo.DataSource = userList;
                }
                

                
            }
            
        }
    }
}
