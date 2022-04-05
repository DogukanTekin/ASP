using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class soru3_homepage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HyperLink1.Text = "DEU";
        HyperLink1.NavigateUrl = "https://www.deu.edu.tr/";
        HyperLink3.Text = "Amazon";
        HyperLink2.Text = "İMYO";
        HyperLink2.NavigateUrl = "https://imyo.deu.edu.tr/tr/";
        HyperLink3.NavigateUrl = "https://www.amazon.com.tr/";
    }
}