using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class soru4_page1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HiddenField1.Value = "Doğukan";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox1.Text = HiddenField1.Value;
    }
}