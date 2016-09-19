using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 练习__石头_见到_布
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        string[] ChuQuan = new string[] {"石头","剪刀","布" };
        Random rd = new Random();
        int rdnum;

        private string JudgeResult(string playerText, string computerText)
        {
            int playerIndex = Array.IndexOf(ChuQuan,playerText);
            int computerIndex = Array.IndexOf(ChuQuan,computerText);
            int delta = playerIndex - computerIndex;
            if (delta==0)
            {
                return "平手";
            }
            else if (delta==-1 || delta==2)
            {
                return "玩家赢";
            }
            else
            {
                return "电脑赢";
            }




            //if (playerIndex==computerIndex)
            //{
            //    return "平手";
            //}
            //else if (playerIndex==0)
            //{
            //    if (computerIndex==1)
            //    {
            //        return "玩家赢";
            //    }
            //    else
            //    {
            //        return "电脑赢";
            //    }
            //}
            //else if (playerIndex == 1)
            //{
            //    if (computerIndex == 2)
            //    {
            //        return "玩家赢";
            //    }
            //    else
            //    {
            //        return "电脑赢";
            //    }
            //}
            //else
            //{
            //    if (computerIndex == 0)
            //    {
            //        return "玩家赢";
            //    }
            //    else
            //    {
            //        return "电脑赢";
            //    }
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblStart.Visible = true;
        }

        private void btnStone_Click(object sender, EventArgs e)
        {
            lblStart.Visible = false;
            lblPlayer.Text = "石头";
            rdnum = rd.Next(0, 3);
            lblComputer.Text = ChuQuan[rdnum];
            lblResult.Text = JudgeResult(lblPlayer.Text, lblComputer.Text);
        }

        private void btnScissor_Click(object sender, EventArgs e)
        {
            lblStart.Visible = false;
            lblPlayer.Text = "剪刀";
            rdnum = rd.Next(0, 3);
            lblComputer.Text = ChuQuan[rdnum];
            lblResult.Text = JudgeResult(lblPlayer.Text, lblComputer.Text);

        }

        private void btnCloth_Click(object sender, EventArgs e)
        {
            lblStart.Visible = false;
            lblPlayer.Text = "布";
            rdnum = rd.Next(0, 3);
            lblComputer.Text = ChuQuan[rdnum];
            lblResult.Text = JudgeResult(lblPlayer.Text, lblComputer.Text);

        }
    }
}
