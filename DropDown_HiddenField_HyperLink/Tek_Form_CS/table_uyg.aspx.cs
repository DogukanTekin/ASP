using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class table_uyg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "Doğukan";
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox2.Text = "TEKİN";
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        TextBox3.Text = "Dokuz Eylül Üniversitesi";
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        TextBox4.Text = "Bilgisayar Programcılığı";
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        TextBox5.Text = "Örgün Öğretim";
    }
}