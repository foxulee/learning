using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI窗体设计                 //MDI其实就可以理解成是老子和儿子的问题，儿子总是听老子的话，子窗体不能超出父窗体，无论怎么移动都只能在父窗体里面！
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 显示窗口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.MdiParent = this;                        //此处用this，因为在Form1类里面
            frm2.Show();
            Form3 frm3 = new Form3();
            frm3.MdiParent = this;
            frm3.Show();
            Form4 frm4 = new Form4();
            frm4.MdiParent = this;
            frm4.Show();


        }

        private void 纵向排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void 横向排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
    }
}
