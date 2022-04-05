using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class soru5_homepage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HyperLink1.Text = "Sayfa 1";
        HyperLink2.Text = "Sayfa 2";
        HyperLink1.NavigateUrl = "/soru5_page1.aspx";
        HyperLink2.NavigateUrl = "/soru5_page2.aspx";
    }
}