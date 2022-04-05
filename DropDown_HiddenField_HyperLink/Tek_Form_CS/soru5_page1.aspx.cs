using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class soru5_page1ü : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HyperLink1.Text = "HomePage";
        HyperLink1.NavigateUrl = "/soru5_homepage.aspx";
        TextBox1.Text = "Doğukan";
        HiddenField1.Value = "Doğukan TEKİN";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox1.Text = HiddenField1.Value;
    }
}