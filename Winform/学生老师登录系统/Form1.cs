using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学生老师登录系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbtnStu.Checked == false && rdbtnTeacher.Checked == false)
            {
                MessageBox.Show("Please choose 'Student' or 'Teacher'.");
            }
            else if (rdbtnStu.Checked == true)
            {
                if (txtAcc.Text.Trim() == "student" && txtPwd.Text == "student")
                {
                    MessageBox.Show("Student login is succeful!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed! Please check your account name or password, and retry!");
                    txtAcc.Text = null;
                    txtPwd.Text = null;
                    txtAcc.Focus();           //设置光标的位置
                }

            }
            else if (rdbtnTeacher.Checked == true)
            {
                if (txtAcc.Text.Trim() == "teacher" && txtPwd.Text == "teacher")
                {
                    MessageBox.Show("Teacher login is succeful!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed! Please check your account name or password, and retry!");
                    txtAcc.Text = null;
                    txtPwd.Text = null;
                    txtAcc.Focus();           //设置光标的位置
                }
            }

            
          
            
            
        }

       

        private void Form1_Activated(object sender, EventArgs e)
        {
            txtAcc.Focus();
            rdbtnStu.Checked = false;
        }
    }
}
