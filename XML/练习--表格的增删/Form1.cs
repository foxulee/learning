using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace 练习__表格的增删
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void LoadData()
        {
            //存储对象的集合
            List<User> listUser = new List<User>();

            //开始读取数据 赋值给集合中的对象

            XmlDocument doc = new XmlDocument();
            doc.Load("haodongxi.xml");

            //获得根节点
            XmlElement users = doc.DocumentElement;

            //获得根节点下面的所有子节点
            XmlNodeList xnl = users.ChildNodes;

            foreach (XmlNode item in xnl)
            {
                //将从XML文档中读取到的数据赋值给集合中对象的属性
                listUser.Add(new User { ID = Convert.ToInt32(item.Attributes["id"].Value), Name = item["name"].InnerText, Age = item["age"].InnerText, Gender = Convert.ToChar(item["gender"].InnerText), Password = item["password"].InnerText });
            }

            //将数据赋值给DataGridView
            dataGridView1.DataSource = listUser;
        }


        //注册
        private void btnNew_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("haodongxi.xml");

            //获得根节点
            XmlElement users = doc.DocumentElement;

            //创建子节点
            XmlElement user = doc.CreateElement("user");
            user.SetAttribute("id", txtNewID.Text.Trim());
            users.AppendChild(user);

            XmlElement name = doc.CreateElement("name");
            name.InnerText = txtNewName.Text.Trim();
            user.AppendChild(name);

            XmlElement age = doc.CreateElement("age");
            age.InnerText = txtNewAge.Text.Trim();
            user.AppendChild(age);

            XmlElement password = doc.CreateElement("password");
            password.InnerText = txtNewPass.Text;
            user.AppendChild(password);

            XmlElement gender = doc.CreateElement("gender");
            if (rbtNewMale.Checked)
            {
                gender.InnerText = "男";
            }
            else if (rbtNewFemale.Checked)
            {
                gender.InnerText = "女";
            }
            else
            {
                gender.InnerText = "";
            }
            user.AppendChild(gender);

            doc.Save("haodongxi.xml");

            LoadData();

            MessageBox.Show("注册成功！");

            
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //删除指定的行数据
            //获得当前选中行的ID
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            //根据id进行删除
            XmlDocument doc = new XmlDocument();
            doc.Load("haodongxi.xml");

            XmlElement users = doc.DocumentElement;
            //获得要删除的节点
            XmlNode xn = users.SelectSingleNode("/Users/user[@id='" + id + "']");

            users.RemoveChild(xn);

            doc.Save("haodongxi.xml");

            LoadData();

            MessageBox.Show("删除成功！");

        }


        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUpdateName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtUpdateAge.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtUpdatePass.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            lblUpdateID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            string gender = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            if (gender=="男")
            {
                rbtUpdateMale.Checked = true;
            }
            else if (gender == "女")
            {
                rbtUpdateFemale.Checked = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = lblUpdateID.Text;

            XmlDocument doc = new XmlDocument();
            doc.Load("haodongxi.xml");


            XmlElement users = doc.DocumentElement;
            XmlNode xn = users.SelectSingleNode("/Users/user[@id='" + id + "']");

            xn["name"].InnerText = txtUpdateName.Text.Trim();
            xn["age"].InnerText = txtUpdateAge.Text.Trim();
            xn["password"].InnerText = txtUpdatePass.Text;
            xn["gender"].InnerText = rbtUpdateMale.Checked ? "男" : "女";

            doc.Save("haodongxi.xml");

            LoadData();

            MessageBox.Show("修改成功！");


        }
    }
}
