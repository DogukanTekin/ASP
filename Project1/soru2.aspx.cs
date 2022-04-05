using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class soru2 : System.Web.UI.Page
{
    double ortalama;
    int v1, v2, final;
    string hNotu;
    void ortalamaHesapla()
    {
        if (CheckBox5.Checked == true && TextBox5.Text.Length != 0)
            v1 = Convert.ToInt32(TextBox5.Text);
        else
            v1 = 0;
        if (CheckBox6.Checked == true && TextBox6.Text.Length != 0)
            v2 = Convert.ToInt32(TextBox6.Text);
        else
            v2 = 0;
        if (CheckBox7.Checked == true && TextBox7.Text.Length != 0)
            final = Convert.ToInt32(TextBox7.Text);
        else
        {
            if (CheckBox8.Checked == true && TextBox8.Text.Length != 0)
                final = Convert.ToInt32(TextBox8.Text);
            else
                final = 0;
        }
        ortalama = (v1 * 2 / 10) + (v2 * 2 / 10) + (final * 6 / 10);
    }
    void harfNotu()
    {
        if (ortalama < 50)
            hNotu = "FF";
        else if (ortalama < 65)
            hNotu = "CC";
        else if (ortalama < 80)
            hNotu = "BB";
        else
            hNotu = "AA";
    }

    void iller()
    {
        DropDownList2.Items.Clear();
        DropDownList2.Items.Add("İl");
        DropDownList2.Items.Add("İzmir");
        DropDownList2.Items.Add("Ordu");
    }

    //İlçelerin bulunduğu dropdownlist'e seçilmiş olan ile ait ilçeleri yazdırır
    void ilceler()
    {
        DropDownList3.Items.Clear();
        DropDownList3.Items.Add("İlçe");
        if (DropDownList2.SelectedIndex == 1)
        {
            //İzmir ilçelerini ekler
            DropDownList3.Items.Add("Konak");
            DropDownList3.Items.Add("Buca");
        }
        else if (DropDownList2.SelectedIndex == 2)
        {
            //Ordu ilçelerini ekler
            DropDownList3.Items.Add("Ünye");
            DropDownList3.Items.Add("Fatsa");
        }
    }

    //Mahallelerin bulunduğu dropdownlist'e seçilmiş olan ilçeye ait mahalleleri yazdırır
    void mahalleler()
    {
        DropDownList4.Items.Clear();
        DropDownList4.Items.Add("Mahalle");
        if (DropDownList3.SelectedItem.Text == "Konak")
        {
            //Konak mahallelerini ekler
            DropDownList4.Items.Add("KonakMahalle1");
            DropDownList4.Items.Add("KonakMahalle2");
        }
        else if (DropDownList3.SelectedItem.Text == "Buca")
        {
            //Buca mahallelerini ekler
            DropDownList4.Items.Add("BucaMahalle1");
            DropDownList4.Items.Add("BucaMahalle2");
        }
        else if (DropDownList3.SelectedItem.Text == "Ünye")
        {
            //Ünye mahallelerini ekler
            DropDownList4.Items.Add("ÜnyeMahalle1");
            DropDownList4.Items.Add("ÜnyeMahalle2");
        }
        else if (DropDownList3.SelectedItem.Text == "Fatsa")
        {
            //Fatsa mahallelerini ekler
            DropDownList4.Items.Add("FatsaMahalle1");
            DropDownList4.Items.Add("FatsaMahalle2");
        }
    }

    //------------------------------------------------------------------------
    void kapino()
    {
        //Konak Kapı Numaraları
        DropDownList7.Items.Clear();
        DropDownList7.Items.Add("Kapı No");
        if (DropDownList6.SelectedItem.Text == "KonakM1C1A1")
        {
            DropDownList7.Items.Add("KonakM1C1A1K1");
            DropDownList7.Items.Add("KonakM1C1A1K2");
        }
        else if (DropDownList6.SelectedItem.Text == "KonakM1C1A2")
        {
            DropDownList7.Items.Add("KonakM1C1A2K1");
            DropDownList7.Items.Add("KonakM1C1A2K2");
        }
        else if (DropDownList6.SelectedItem.Text == "KonakM1C2A1")
        {
            DropDownList7.Items.Add("KonakM1C2A1K1");
            DropDownList7.Items.Add("KonakM1C2A1K2");
        }
        else if (DropDownList6.SelectedItem.Text == "KonakM1C2A2")
        {
            DropDownList7.Items.Add("KonakM1C2A2K1");
            DropDownList7.Items.Add("KonakM1C2A2K2");
        }
        else if (DropDownList6.SelectedItem.Text == "KonakM2C1A1")
        {
            DropDownList7.Items.Add("KonakM2C1A1K1");
            DropDownList7.Items.Add("KonakM2C1A1K2");
        }
        else if (DropDownList6.SelectedItem.Text == "KonakM2C1A2")
        {
            DropDownList7.Items.Add("KonakM2C1A2K1");
            DropDownList7.Items.Add("KonakM2C1A2K2");
        }
        else if (DropDownList6.SelectedItem.Text == "KonakM2C2A1")
        {
            DropDownList7.Items.Add("KonakM2C2A1K1");
            DropDownList7.Items.Add("KonakM2C2A2K2");
        }
        else if (DropDownList6.SelectedItem.Text == "KonakM2C2A2")
        {
            DropDownList7.Items.Add("KonakM2C2A2K1");
            DropDownList7.Items.Add("KonakM2C2A2K2");
        }
        //Buca Kapı Numaraları
        else if (DropDownList6.SelectedItem.Text == "BucaM1C1A1")
        {
            DropDownList7.Items.Add("BucaM1C1A1K1");
            DropDownList7.Items.Add("BucaM1C1A1K2");
        }
        else if (DropDownList6.SelectedItem.Text == "BucaM1C1A2")
        {
            DropDownList7.Items.Add("BucaM1C1A2K1");
            DropDownList7.Items.Add("BucaM1C1A2K2");
        }
        else if (DropDownList6.SelectedItem.Text == "BucaM1C2A1")
        {
            DropDownList7.Items.Add("BucaM1C2A1K1");
            DropDownList7.Items.Add("BucaM1C2A1K2");
        }
        else if (DropDownList6.SelectedItem.Text == "BucaM1C2A2")
        {
            DropDownList7.Items.Add("BucaM1C2A2K1");
            DropDownList7.Items.Add("BucaM1C2A2K2");
        }
        else if (DropDownList6.SelectedItem.Text == "BucaM2C1A1")
        {
            DropDownList7.Items.Add("BucaM2C1A1K1");
            DropDownList7.Items.Add("BucaM2C1A1K2");
        }
        else if (DropDownList6.SelectedItem.Text == "BucaM2C1A2")
        {
            DropDownList7.Items.Add("BucaM2C1A2K1");
            DropDownList7.Items.Add("BucaM2C1A2K2");
        }
        else if (DropDownList6.SelectedItem.Text == "BucaM2C2A1")
        {
            DropDownList7.Items.Add("BucaM2C2A1K1");
            DropDownList7.Items.Add("BucaM2C2A1K2");
        }
        else if (DropDownList6.SelectedItem.Text == "BucaM2C2A2")
        {
            DropDownList7.Items.Add("BucaM2C2A2K1");
            DropDownList7.Items.Add("BucaM2C2A2K2");
        }
        //Ünye Kapı Numaraları
        else if (DropDownList6.SelectedItem.Text == "ÜnyeM1C1A1")
        {
            DropDownList7.Items.Add("ÜnyeM1C1A1K1");
            DropDownList7.Items.Add("ÜnyeM1C1A1K2");
        }
        else if (DropDownList6.SelectedItem.Text == "ÜnyeM1C1A2")
        {
            DropDownList7.Items.Add("ÜnyeM1C1A2K1");
            DropDownList7.Items.Add("ÜnyeM1C1A2K2");
        }
        else if (DropDownList6.SelectedItem.Text == "ÜnyeM1C2A1")
        {
            DropDownList7.Items.Add("ÜnyeM1C2A1K1");
            DropDownList7.Items.Add("ÜnyeM1C2A1K2");
        }
        else if (DropDownList6.SelectedItem.Text == "ÜnyeM1C2A2")
        {
            DropDownList7.Items.Add("ÜnyeM1C2A2K1");
            DropDownList7.Items.Add("ÜnyeM1C2A2K2");
        }
        else if (DropDownList6.SelectedItem.Text == "ÜnyeM2C1A1")
        {
            DropDownList7.Items.Add("ÜnyeM2C1A1K1");
            DropDownList7.Items.Add("ÜnyeM2C1A1K2");
        }
        else if (DropDownList6.SelectedItem.Text == "ÜnyeM2C1A2")
        {
            DropDownList7.Items.Add("ÜnyeM2C1A2K1");
            DropDownList7.Items.Add("ÜnyeM2C1A2K2");
        }
        else if (DropDownList6.SelectedItem.Text == "ÜnyeM2C2A1")
        {
            DropDownList7.Items.Add("ÜnyeM2C2A1K1");
            DropDownList7.Items.Add("ÜnyeM2C2A1K2");
        }
        else if (DropDownList6.SelectedItem.Text == "ÜnyeM2C2A2")
        {
            DropDownList7.Items.Add("ÜnyeM2C2A2K1");
            DropDownList7.Items.Add("ÜnyeM2C2A2K2");
        }
        //Fatsa Kapı Numaraları
        else if (DropDownList6.SelectedItem.Text == "FatsaM1C1A1")
        {

            DropDownList7.Items.Add("FatsaM1C1A1K1");
            DropDownList7.Items.Add("FatsaM1C1A1K2");
        }
        else if (DropDownList6.SelectedItem.Text == "FatsaM1C1A2")
        {
            DropDownList7.Items.Add("FatsaM1C1A2K1");
            DropDownList7.Items.Add("FatsaM1C1A2K2");
        }
        else if (DropDownList6.SelectedItem.Text == "FatsaM1C2A1")
        {
            DropDownList7.Items.Add("FatsaM1C2A1K1");
            DropDownList7.Items.Add("FatsaM1C2A1K2");
        }
        else if (DropDownList6.SelectedItem.Text == "FatsaM1C2A2")
        {
            DropDownList7.Items.Add("FatsaM1C2A2K1");
            DropDownList7.Items.Add("FatsaM1C2A2K2");
        }
        else if (DropDownList6.SelectedItem.Text == "FatsaM2C1A1")
        {
            DropDownList7.Items.Add("FatsaM2C1A1K1");
            DropDownList7.Items.Add("FatsaM2C1A1K2");
        }
        else if (DropDownList6.SelectedItem.Text == "FatsaM2C1A2")
        {
            DropDownList7.Items.Add("FatsaM2C1A2K1");
            DropDownList7.Items.Add("FatsaM2C1A2K2");
        }
        else if (DropDownList6.SelectedItem.Text == "FatsaM2C2A1")
        {
            DropDownList7.Items.Add("FatsaM2C2A1K1");
            DropDownList7.Items.Add("FatsaM2C2A1K2");
        }
        else if (DropDownList6.SelectedItem.Text == "FatsaM2C2A2")
        {
            DropDownList7.Items.Add("FatsaM2C2A2K1");
            DropDownList7.Items.Add("FatsaM2C2A2K2");
        }
    }
    //------------------------------------------------------------------------
    void daireno()
    {
        DropDownList6.Items.Clear();
        DropDownList6.Items.Add("Daire No");
        //Konak apartmanlarını ekler
        if (DropDownList5.SelectedItem.Text == "KonakM1C1")
        {
            DropDownList6.Items.Add("KonakM1C1A1");
            DropDownList6.Items.Add("KonakM1C1A2");
        }
        else if (DropDownList5.SelectedItem.Text == "KonakM1C2")
        {
            DropDownList6.Items.Add("KonakM1C2A1");
            DropDownList6.Items.Add("KonakM1C2A2");
        }
        else if (DropDownList5.SelectedItem.Text == "KonakM2C1")
        {
            DropDownList6.Items.Add("KonakM2C1A1");
            DropDownList6.Items.Add("KonakM2C1A2");
        }
        else if (DropDownList5.SelectedItem.Text == "KonakM2C2")
        {
            DropDownList6.Items.Add("KonakM2C2A1");
            DropDownList6.Items.Add("KonakM2C2A2");
        }
        //Buca apartmanlarını ekler
        else if (DropDownList5.SelectedItem.Text == "BucaM1C1")
        {
            DropDownList6.Items.Add("BucaM1C1A1");
            DropDownList6.Items.Add("BucaM1C1A2");
        }
        else if (DropDownList5.SelectedItem.Text == "BucaM1C2")
        {
            DropDownList6.Items.Add("BucaM1C2A1");
            DropDownList6.Items.Add("BucaM1C2A2");
        }
        else if (DropDownList5.SelectedItem.Text == "BucaM2C1")
        {
            DropDownList6.Items.Add("BucaM2C1A1");
            DropDownList6.Items.Add("BucaM2C1A2");
        }
        else if (DropDownList5.SelectedItem.Text == "BucaM2C2")
        {
            DropDownList6.Items.Add("BucaM2C2A1");
            DropDownList6.Items.Add("BucaM2C2A2");
        }
        //Ünye apartmanlarını ekler
        else if (DropDownList5.SelectedItem.Text == "ÜnyeM1C1")
        {
            DropDownList6.Items.Add("ÜnyeM1C1A1");
            DropDownList6.Items.Add("ÜnyeM1C1A2");
        }
        else if (DropDownList5.SelectedItem.Text == "ÜnyeM1C2")
        {
            DropDownList6.Items.Add("ÜnyeM1C2A1");
            DropDownList6.Items.Add("ÜnyeM1C2A2");
        }
        else if (DropDownList5.SelectedItem.Text == "ÜnyeM2C1")
        {
            DropDownList6.Items.Add("ÜnyeM2C1A1");
            DropDownList6.Items.Add("ÜnyeM2C1A2");
        }
        else if (DropDownList5.SelectedItem.Text == "ÜnyeM2C2")
        {
            DropDownList6.Items.Add("ÜnyeM2C2A1");
            DropDownList6.Items.Add("ÜnyeM2C2A2");
        }
        //Fatsa apartmanlarını ekler
        else if (DropDownList5.SelectedItem.Text == "FatsaM1C1")
        {
            DropDownList6.Items.Add("FatsaM1C1A1");
            DropDownList6.Items.Add("FatsaM1C1A2");
        }
        else if (DropDownList5.SelectedItem.Text == "FatsaM1C2")
        {
            DropDownList6.Items.Add("FatsaM1C2A1");
            DropDownList6.Items.Add("FatsaM1C2A2");
        }
        else if (DropDownList5.SelectedItem.Text == "FatsaM2C1")
        {
            DropDownList6.Items.Add("FatsaM2C1A1");
            DropDownList6.Items.Add("FatsaM2C1A2");
        }
        else if (DropDownList5.SelectedItem.Text == "FatsaM2C2")
        {
            DropDownList6.Items.Add("FatsaM2C2A1");
            DropDownList6.Items.Add("FatsaM2C2A2");
        }
    }

    public void cadde()
    {
        DropDownList5.Items.Clear();
        DropDownList5.Items.Add("Cadde");
        if (DropDownList4.SelectedItem.Text == "KonakMahalle1")
        {
            //Konak - Mahalle 1 ' in caddelerini ekler
            DropDownList5.Items.Add("KonakM1C1");
            DropDownList5.Items.Add("KonakM1C2");

        }
        else if (DropDownList4.SelectedItem.Text == "KonakMahalle2")
        {
            //Konak - Mahalle 2 ' in caddelerini ekler
            DropDownList5.Items.Add("KonakM2C1");
            DropDownList5.Items.Add("KonakM2C2");
        }
        else if (DropDownList4.SelectedItem.Text == "BucaMahalle1")
        {
            //Buca - Mahalle 1 ' in caddelerini ekler
            DropDownList5.Items.Add("BucaM1C1");
            DropDownList5.Items.Add("BucaM1C2");
        }
        else if (DropDownList4.SelectedItem.Text == "BucaMahalle2")
        {
            //Buca - Mahalle 2 ' in caddelerini ekler
            DropDownList5.Items.Add("BucaM2C1");
            DropDownList5.Items.Add("BucaM2C2");
        }
        else if (DropDownList4.SelectedItem.Text == "ÜnyeMahalle1")
        {
            //Ünye - Mahalle 1 ' in caddelerini ekler
            DropDownList5.Items.Add("ÜnyeM1C1");
            DropDownList5.Items.Add("ÜnyeM1C2");
        }
        else if (DropDownList4.SelectedItem.Text == "ÜnyeMahalle2")
        {
            //Ünye - Mahalle 2 ' in caddelerini ekler
            DropDownList5.Items.Add("ÜnyeM2C1");
            DropDownList5.Items.Add("ÜnyeM2C2");
        }
        else if (DropDownList4.SelectedItem.Text == "FatsaMahalle1")
        {
            //Fatsa - Mahalle 1 ' in caddelerini ekler
            DropDownList5.Items.Add("FatsaM1C1");
            DropDownList5.Items.Add("FatsaM1C2");
        }
        else if (DropDownList4.SelectedItem.Text == "FatsaMahalle2")
        {
            //Fatsa - Mahalle 2 ' in caddelerini ekler
            DropDownList5.Items.Add("FatsaM2C1");
            DropDownList5.Items.Add("FatsaM2C2");
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (DropDownList1.Items.Capacity == 0)
        {
            DropDownList1.Items.Add("Öğrenci Numarası Seçiniz");
            for (int i = 1; i <= 9; i++)
            {
                DropDownList1.Items.Add("202070700" + i.ToString());
            }
            DropDownList1.Items.Add("2020707010");
        }


        //if (DropDownList2.Items.Capacity == 0)
        //{
        //    iller();            
        //}

        CheckCapacityIsZero(DropDownList2, iller);

        //if (DropDownList3.Items.Capacity == 0)
        //{
        //    ilceler();
        //}

        CheckCapacityIsZero(DropDownList3, ilceler);

        //if (DropDownList4.Items.Capacity == 0)
        //{
        //    mahalleler();
        //}

        CheckCapacityIsZero(DropDownList4, mahalleler);


        //if (DropDownList5.Items.Capacity == 0)
        //{
        //    cadde();
        //}

        CheckCapacityIsZero(DropDownList5, cadde);


        //if (DropDownList6.Items.Capacity == 0) // Kapı No
        //{
        //    daireno();
        //}

        CheckCapacityIsZero(DropDownList6, daireno);

        //if (DropDownList7.Items.Capacity == 0) // Daire No
        //{
        //    kapino();
        //}

        CheckCapacityIsZero(DropDownList7, kapino);


        DropDownList1.AutoPostBack = true;
        DropDownList2.AutoPostBack = true;
        DropDownList3.AutoPostBack = true;
        DropDownList4.AutoPostBack = true;
        DropDownList5.AutoPostBack = true;
        DropDownList6.AutoPostBack = true;
        DropDownList7.AutoPostBack = true;


        CheckBox1.Text = "Erkek";
        CheckBox2.Text = "Kadın";
        CheckBox3.Text = "Türk";
        CheckBox4.Text = "Yabancı";
        CheckBox5.Text = "Vize 1";
        CheckBox6.Text = "Vize 2";
        CheckBox7.Text = "Final";
        CheckBox8.Text = "Bütünleme";


        CheckBox1.AutoPostBack = true;
        CheckBox2.AutoPostBack = true;
        CheckBox3.AutoPostBack = true;
        CheckBox4.AutoPostBack = true;
        CheckBox5.AutoPostBack= true;
        CheckBox6.AutoPostBack = true;
        CheckBox7.AutoPostBack= true;
        CheckBox8.AutoPostBack= true;
        ListBox1.AutoPostBack = true;


        if (Page.IsPostBack == false)
        {
            TextBox5.Visible = false;
            TextBox6.Visible = false;
            TextBox7.Visible = false;
            TextBox8.Visible = false;
            CheckBox8.Visible = false;
        }
        if (ListBox1.Items.Capacity == 0)
        {
            ListBox1.Items.Add("C#");
            ListBox1.Items.Add("VisualBasic");
            ListBox1.Items.Add("Algoritma");
        }
        Button1.Text = "AKTAR";
    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        ilceler();
        mahalleler();
        cadde();
        daireno();
        kapino();
    }

    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        mahalleler();
        cadde();
        daireno();
        kapino();
    }

    protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
    {
        cadde();
        daireno();
        kapino();
    }

    protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
    {
        daireno();
        kapino();
    }

    protected void DropDownList6_SelectedIndexChanged(object sender, EventArgs e)
    {
        kapino();
    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        //if (CheckBox1.Checked == true)
        //    CheckBox2.Checked = false;
        //else
        //    CheckBox2.Checked = true;

        CheckedChanged(CheckBox1, CheckBox2);
    }

    protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
    {
        //if (CheckBox2.Checked == true)
        //    CheckBox1.Checked = false;
        //else
        //    CheckBox1.Checked = true;

        CheckedChanged(CheckBox2, CheckBox1);
    }

    protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
    {
        //if (CheckBox3.Checked == true)
        //    CheckBox4.Checked = false;
        //else
        //    CheckBox4.Checked = true;

        CheckedChanged(CheckBox3, CheckBox4);
    }

    protected void CheckBox4_CheckedChanged(object sender, EventArgs e)
    {
        //if (CheckBox4.Checked == true)
        //    CheckBox3.Checked = false;
        //else
        //    CheckBox3.Checked = true;

        CheckedChanged(CheckBox4, CheckBox3);
    }

    protected void CheckBox5_CheckedChanged(object sender, EventArgs e)
    {
        //if (CheckBox5.Checked == true)
        //    TextBox5.Visible = true;
        //else
        //    TextBox5.Visible = false;

        CheckedChanged(CheckBox5, TextBox5);
    }

    protected void CheckBox6_CheckedChanged(object sender, EventArgs e)
    {
        //if (CheckBox6.Checked == true)
        //    TextBox6.Visible = true;
        //else
        //    TextBox6.Visible = false;

        CheckedChanged(CheckBox6, TextBox6);
    }


    protected void CheckBox7_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox7.Checked == true)
        {
            TextBox7.Visible = true;
            CheckBox8.Visible = false;
            TextBox8.Visible = false;
        }            
        else
        {
            TextBox7.Visible = false;
            CheckBox8.Visible = true;           
        }            
    }

    protected void CheckBox8_CheckedChanged(object sender, EventArgs e)
    {
    //    if (CheckBox8.Checked == true)
    //        TextBox8.Visible = true;
    //    else
    //        TextBox8.Visible = false;

        CheckedChanged(CheckBox8,TextBox8);
    }

    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {
        ortalamaHesapla();
        harfNotu();
    }

    protected void TextBox6_TextChanged(object sender, EventArgs e)
    {
        ortalamaHesapla();
        harfNotu();
    }

    protected void TextBox7_TextChanged(object sender, EventArgs e)
    {
        ortalamaHesapla();
        harfNotu();
    }

    protected void TextBox8_TextChanged(object sender, EventArgs e)
    {
        ortalamaHesapla();
        harfNotu();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ListBox2.Items.Clear();
        ListBox2.Items.Add("TC No : " + TextBox2.Text);
        ListBox2.Items.Add("Ad: " + TextBox3.Text);
        ListBox2.Items.Add("Soyad: " + TextBox4.Text);

        WriteResponseByCondition(DropDownList1,"Öğrenci Numarası", "Öğrenci No");
        WriteResponseByCondition(DropDownList2,"İl");
        WriteResponseByCondition(DropDownList3,"İlçe");
        WriteResponseByCondition(DropDownList4, "Mahalle");
        WriteResponseByCondition(DropDownList5,"Cadde");
        WriteResponseByCondition(DropDownList6, "Daire");
        WriteResponseByCondition(DropDownList7,"Kapı No");

       
        AddListBoxByCheckBoxCondition(CheckBox1, CheckBox2, "Cinsiyet");
        AddListBoxByCheckBoxCondition(CheckBox3, CheckBox4, "Uyruk");

        ListBox2.Items.Add("Ders Adı : " + ListBox1.SelectedItem.Text);
        ListBox2.Items.Add("Ortalama : " + ortalama.ToString());
        ListBox2.Items.Add("Harf Notu : " + hNotu);
    }

   
    private void CheckCapacityIsZero(DropDownList dropDownList,Action method)
    {
        if (dropDownList.Items.Capacity == 0)
        {
            method.Invoke();
        }
    }
    private void WriteResponseByCondition(DropDownList dropDownList, string fieldName)
    {
        if (dropDownList.SelectedIndex == 0)
        {
            Response.Write($"<script>alert('${fieldName} seçin')</script>");
        }
        else
        {
            ListBox2.Items.Add($"{fieldName} : " + dropDownList.SelectedItem.Text);
        }
        
    }

    private void WriteResponseByCondition(DropDownList dropDownList,string fieldName,string listBoxFieldName)
    {
        if (dropDownList.SelectedIndex == 0)
        {
            Response.Write($"<script>alert('${fieldName} seçin')</script>");
        }
        else
        {
            ListBox2.Items.Add($"{listBoxFieldName} : " + dropDownList.SelectedItem.Text);
        }
        
    }

    private void AddListBoxByCheckBoxCondition(CheckBox checkBox1,CheckBox checkBox2,string fieldName)
    {
        if (checkBox1.Checked)
        {
            ListBox2.Items.Add($"{fieldName}:{checkBox1.Text}");
        }

        else
        {
            ListBox2.Items.Add($"{fieldName}:{checkBox2.Text}");
        }

        
    }

    private void CheckedChanged(CheckBox checkBox1,TextBox textBox1)
    {
        //if (checkBox1.Checked == true)
        //    textBox1.Visible = true;
        //else
        //    textBox1.Visible = false;
        SetToChecked(textBox1, checkBox1.Checked, true, false);
    }

    private void CheckedChanged(CheckBox checkBox1, CheckBox checkBox2)
    {
        //if (checkBox1.Checked == true)
        //    checkBox2.Visible = false;
        //else
        //    checkBox2.Visible = true;
        SetToChecked(checkBox2, checkBox1.Checked, false, true);
    }

    private void SetToChecked(WebControl wb,bool expression,bool firstSetValue,bool secondSetValue)
    {
        if (expression)
        {
            wb.Visible = firstSetValue;
        }

        else
        {
            wb.Visible = secondSetValue;
        }

       
    }


}