using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class dropdown : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (DropDownList1.Items.Capacity == 0)
        {
            DropDownList1.Items.Add("Doğukan");
            DropDownList1.Items.Add("Umut");
            DropDownList1.Items.Add("Emirhan");
            DropDownList1.AutoPostBack = true;
        }
        if (DropDownList1.SelectedIndex == 0)
            TextBox1.Text = "TEKİN";
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedIndex == 0)
            TextBox1.Text = "TEKİN";
        else if (DropDownList1.SelectedIndex == 1)
            TextBox1.Text = "TOKSOY";
        else
            TextBox1.Text = "KOÇ";
    }
}