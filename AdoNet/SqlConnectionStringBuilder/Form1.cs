using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlConnectionStringBuilder
{
    public partial class mainFrm : Form
    {
        public mainFrm()
        {
            InitializeComponent();
            //创建SqlConnectionStringBuilder类
            System.Data.SqlClient.SqlConnectionStringBuilder scsb = new System.Data.SqlClient.SqlConnectionStringBuilder();
            //初始化属性（非必须）
            scsb.DataSource = ".";
            scsb.UserID = "sa";
            scsb.Password = "hjlsqh";
            scsb.InitialCatalog = "Demo";
            scsb.MinPoolSize = 4;

            //让PropertyGrid指向SqlConnectionStringBuilder object
            this.propGrid4String.SelectedObject = scsb;   //propertyGrid

        }

        private void btnGetStr_Click(object sender, EventArgs e)
        {
            txtStr.Text = this.propGrid4String.SelectedObject.ToString();
            Clipboard.Clear();       //清空剪贴板
            Clipboard.SetText(txtStr.Text);   //赋值剪贴板
            MessageBox.Show(txtStr.Text);
        }
    }
}
