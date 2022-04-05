using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class soru1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            RadioButtonList1.Items.Add("Lise");
            RadioButtonList1.Items.Add("Ön Lisans");
            RadioButtonList1.Items.Add("Lisans");
            RadioButtonList2.Items.Add("Erkek");
            RadioButtonList2.Items.Add("Kadın");
            RadioButtonList3.Items.Add("Yapıldı");
            RadioButtonList3.Items.Add("Tecilli");
        }
    }
}