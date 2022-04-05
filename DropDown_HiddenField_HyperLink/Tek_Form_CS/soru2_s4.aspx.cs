using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class soru2_s4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HyperLink1.Text = "Anasayfa";
        HyperLink2.Text = "Sayfa 1";
        HyperLink3.Text = "Sayfa 2";
        HyperLink4.Text = "Sayfa 3";
        HyperLink1.NavigateUrl = "/soru2_hp.aspx";
        HyperLink2.NavigateUrl = "/soru2_s1.aspx";
        HyperLink3.NavigateUrl = "/soru2_s2.aspx";
        HyperLink4.NavigateUrl = "/soru2_S3.aspx";
    }
}