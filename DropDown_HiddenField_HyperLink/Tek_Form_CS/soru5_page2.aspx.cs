using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class soru5_page2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (DropDownList1.Items.Capacity == 0)
        {
            DropDownList1.Items.Add("Ordu");
            DropDownList1.Items.Add("İzmir");
            DropDownList1.Items.Add("Samsun");
            DropDownList1.AutoPostBack = true;
        }
        if (DropDownList1.SelectedIndex == 0)
            TextBox1.Text = "Ünye";
        HyperLink1.Text = "HomePage";
        HyperLink1.NavigateUrl = "/soru5_homepage.aspx";
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedIndex == 0)
            TextBox1.Text = "Ünye";
        else if (DropDownList1.SelectedIndex == 1)
            TextBox1.Text = "Alsancak";
        else
            TextBox1.Text = "Atakum";
    }
}