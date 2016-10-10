using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 练习__利用委托在窗体间传值
{
    public partial class Form2 : Form
    {
        Deltrans _del;
        public Form2(Deltrans del)
        {
            //this._del = new Deltrans(del);
            this._del = del;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this._del(textBox1.Text);
        }
    }
}
