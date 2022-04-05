using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (ListBox1.Items.Capacity == 0) //Page.IsPostBack == false
        {
            ListBox1.Items.Add("Teknik Programlar");
            ListBox1.Items.Add("İktisadi Programlar");
            ListBox1.Items.Add("Sağlık Birimleri Programlar");
            CheckBox1.Text = "algoritma";
            CheckBox2.Text = "iktisada giriş";
            CheckBox3.Text = "istatistik";
            CheckBox4.Text = "veri tabanı";
            CheckBox5.Text = "C# programlama";
            CheckBox6.Text = "vb.net programlama";
            CheckBox7.Text = "matematik";
        }
        ListBox1.AutoPostBack = true;
    }

    void yazdir()
    {
        TextBox1.Text = "";
        if (CheckBox1.Checked == true)
            TextBox1.Text += CheckBox1.Text + " ";
        if (CheckBox2.Checked == true)
            TextBox1.Text += CheckBox2.Text + " ";
        if (CheckBox3.Checked == true)
            TextBox1.Text += CheckBox3.Text + " ";
        if (CheckBox4.Checked == true)
            TextBox1.Text += CheckBox4.Text + " ";
        if (CheckBox5.Checked == true)
            TextBox1.Text += CheckBox5.Text + " ";
        if (CheckBox6.Checked == true)
            TextBox1.Text += CheckBox6.Text + " ";
        if (CheckBox7.Checked == true)
            TextBox1.Text += CheckBox7.Text + " ";
    }
    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ListBox1.SelectedIndex == 0)
        {
            CheckBox1.Checked = true;
            CheckBox4.Checked = true;
            CheckBox5.Checked = true;
            CheckBox2.Checked = false;
            CheckBox3.Checked = false;
            CheckBox6.Checked = true;
            CheckBox7.Checked = false;
            yazdir();
        }
        else if (ListBox1.SelectedIndex == 1)
        {
            CheckBox1.Checked = false;
            CheckBox4.Checked = false;
            CheckBox5.Checked = false;
            CheckBox2.Checked = true;
            CheckBox3.Checked = true;
            CheckBox6.Checked = false;
            CheckBox7.Checked = true;
            yazdir();
        }
        else
        {
            CheckBox1.Checked = false;
            CheckBox4.Checked = false;
            CheckBox5.Checked = false;
            CheckBox2.Checked = false;
            CheckBox3.Checked = false;
            CheckBox6.Checked = false;
            CheckBox7.Checked = true;
            yazdir();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
    }
}