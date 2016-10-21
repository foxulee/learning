using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlDataAdapter_____WinformDataGridView
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Mainfrm());
            //Application.Run(new DataSetForm2());
            Application.Run(new SqlCommandBuilderCRUD_Form());
        }
    }
}
