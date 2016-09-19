using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox练习__日期选择器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1949; i < 2017; i++)
            {
                cboYear.Items.Add(i);
            }
            
        }

        
        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMonth.Items.Clear();
            cboMonth.Items.AddRange(new string[]{ "1","2","3","4","5","6","7","8","9","10","11","12"});
        }

        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            string month = cboMonth.Items[cboMonth.SelectedIndex].ToString();
            cboDay.Items.Clear();                                             //年每变一次都要先清空内容
            if (new string[] {"1","3","5","7","8","10","12" }.Contains(month))    //大月
            {
                for (int i = 1; i <= 31; i++)
                {
                    cboDay.Items.Add(i);
                }
            }
            else if(new string[] { "4", "6", "9", "11" }.Contains(month))     //小月
            {
                for (int i = 1; i <= 30; i++)
                {
                    cboDay.Items.Add(i);
                }
            }
            else                                                             //闰年二月份
            {
                if (int.Parse(cboYear.Items[cboYear.SelectedIndex].ToString()) % 400==0 ||( (int.Parse(cboYear.Items[cboYear.SelectedIndex].ToString()) % 4==0 && int.Parse(cboYear.Items[cboYear.SelectedIndex].ToString())%100!=0)))
                {
                    for (int i = 1; i <= 29; i++)
                    {
                        cboDay.Items.Add(i);
                    }
                }
                else
                {
                    for (int i = 1; i <= 28; i++)
                    {
                        cboDay.Items.Add(i);
                    }
                    
                }
            }
        }
    }
}
