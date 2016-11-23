using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index_of_Webform : System.Web.UI.Page
{
    public string Strhtml { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        Strhtml = "aaa";
    }
}