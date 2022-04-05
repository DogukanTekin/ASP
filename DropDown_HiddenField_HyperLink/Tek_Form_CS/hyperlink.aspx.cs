using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class hyperlink : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HyperLink1.Text = "Dene Bakalım";
        HyperLink1.NavigateUrl = "/hyperlink2.aspx";
    }
}