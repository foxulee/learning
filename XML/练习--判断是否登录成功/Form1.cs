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

namespace 练习__判断是否登录成功
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnLog_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            stu.ID = txtID.Text;
            stu.Name = txtName.Text;
            stu.Age = int.Parse(txtAge.Text);

            if (radioMale.Checked)
            {
                stu.Gender = radioMale.Text;
            }
            else if (radioFemal.Checked)
            {
                stu.Gender = radioFemal.Text;
            }
            else
            {
                stu.Gender = "";
            }

            XmlDocument doc = new XmlDocument();
            doc.Load("Person.xml");
            XmlElement person = doc.DocumentElement;

            //XmlNodeList xnl = person.SelectNodes("/Person");
            XmlNodeList xnl1 = person.ChildNodes;
            bool flag = false;
            foreach (XmlNode items in xnl1)
            {
                XmlNodeList xnl2 = items.ChildNodes;

                foreach (XmlNode item in xnl2)
                {
                    if (item["Name"].InnerText == stu.Name && item["Age"].InnerText == stu.Age.ToString() && item["Gender"].InnerText == stu.Gender && item.Attributes["studentID"].Value == stu.ID)
                    {
                        flag = true;
                        break;
                    }
                    else
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    break;
                }

                
            }

            if (flag)
            {
                MessageBox.Show("Login successful!");
            }
            else
            {
                MessageBox.Show("Failed!");
            }
        
        }
    }
}
