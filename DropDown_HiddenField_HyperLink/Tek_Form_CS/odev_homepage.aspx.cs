using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class odev_homepage : System.Web.UI.Page
    
{
    //textBox'ları Clearlar
    void txtClear()
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
        TextBox8.Text = "";
    }
    //Adların bulunduğu dropdownlist'e seçilebilecek adları yazdırır
    void adlar()
    {
        DropDownList1.Items.Add("Doğukan");
        DropDownList1.Items.Add("Umut");
        DropDownList1.Items.Add("Emirhan");
        DropDownList1.AutoPostBack = true;
    }

    //Soyadların bulunduğu dropdownlist'e seçilebilecek soyadları yazdırır
    void soyadlar()
    {
        DropDownList2.Items.Add("TEKİN");
        DropDownList2.Items.Add("TOKSOY");
        DropDownList2.Items.Add("KOÇ");
        DropDownList2.AutoPostBack = true;
    }

    //İllerin bulunduğu dropdownlist'e seçilebilecek illeri yazdırır
    void iller()
    {
        DropDownList3.Items.Clear();
        DropDownList3.Items.Add("İl");
        DropDownList3.Items.Add("İzmir");
        DropDownList3.Items.Add("Ordu");
    }

    //İlçelerin bulunduğu dropdownlist'e seçilmiş olan ile ait ilçeleri yazdırır
     void ilceler()
    {
        DropDownList4.Items.Clear();
        DropDownList4.Items.Add("İlçe");
        if (DropDownList3.SelectedIndex == 1)
        {
            //İzmir ilçelerini ekler
            DropDownList4.Items.Add("Konak");
            DropDownList4.Items.Add("Buca");
        }
        else if (DropDownList3.SelectedIndex == 2)
        {
            //Ordu ilçelerini ekler
            DropDownList4.Items.Add("Ünye");
            DropDownList4.Items.Add("Fatsa");
        }
    }

    //Mahallelerin bulunduğu dropdownlist'e seçilmiş olan ilçeye ait mahalleleri yazdırır
    void mahalleler()
    {
        DropDownList5.Items.Clear();
        DropDownList5.Items.Add("Mahalle");
        if (DropDownList4.SelectedItem.Text == "Konak")
        {
            //Konak mahallelerini ekler
            DropDownList5.Items.Add("KonakMahalle1");
            DropDownList5.Items.Add("KonakMahalle2");
        }
        else if (DropDownList4.SelectedItem.Text == "Buca")
        {
            //Buca mahallelerini ekler
            DropDownList5.Items.Add("BucaMahalle1");
            DropDownList5.Items.Add("BucaMahalle2");
        }
        else if (DropDownList4.SelectedItem.Text == "Ünye")
        {
            //Ünye mahallelerini ekler
            DropDownList5.Items.Add("ÜnyeMahalle1");
            DropDownList5.Items.Add("ÜnyeMahalle2");
        }
        else if (DropDownList4.SelectedItem.Text == "Fatsa")
        {
            //Fatsa mahallelerini ekler
            DropDownList5.Items.Add("FatsaMahalle1");
            DropDownList5.Items.Add("FatsaMahalle2");
        }
    }

    //Caddelerin bulunduğu dropdownlist'e seçilmiş olan mahalleye ait caddeleri yazdırır
    void caddeler()
    {
        DropDownList6.Items.Clear();
        DropDownList6.Items.Add("Cadde");
        if (DropDownList5.SelectedItem.Text == "KonakMahalle1")
        {
            //Konak - Mahalle 1 ' in caddelerini ekler
            DropDownList6.Items.Add("KonakM1C1");
            DropDownList6.Items.Add("KonakM1C2");

        }
        else if (DropDownList5.SelectedItem.Text == "KonakMahalle2")
        {
            //Konak - Mahalle 2 ' in caddelerini ekler
            DropDownList6.Items.Add("KonakM2C1");
            DropDownList6.Items.Add("KonakM2C2");
        }
        else if (DropDownList5.SelectedItem.Text == "BucaMahalle1")
        {
            //Buca - Mahalle 1 ' in caddelerini ekler
            DropDownList6.Items.Add("BucaM1C1");
            DropDownList6.Items.Add("BucaM1C2");
        }
        else if (DropDownList5.SelectedItem.Text == "BucaMahalle2")
        {
            //Buca - Mahalle 2 ' in caddelerini ekler
            DropDownList6.Items.Add("BucaM2C1");
            DropDownList6.Items.Add("BucaM2C2");
        }
        else if (DropDownList5.SelectedItem.Text == "ÜnyeMahalle1")
        {
            //Ünye - Mahalle 1 ' in caddelerini ekler
            DropDownList6.Items.Add("ÜnyeM1C1");
            DropDownList6.Items.Add("ÜnyeM1C2");
        }
        else if (DropDownList5.SelectedItem.Text == "ÜnyeMahalle2")
        {
            //Ünye - Mahalle 2 ' in caddelerini ekler
            DropDownList6.Items.Add("ÜnyeM2C1");
            DropDownList6.Items.Add("ÜnyeM2C2");
        }
        else if (DropDownList5.SelectedItem.Text == "FatsaMahalle1")
        {
            //Fatsa - Mahalle 1 ' in caddelerini ekler
            DropDownList6.Items.Add("FatsaM1C1");
            DropDownList6.Items.Add("FatsaM1C2");
        }
        else if (DropDownList5.SelectedItem.Text == "FatsaMahalle2")
        {
            //Fatsa - Mahalle 2 ' in caddelerini ekler
            DropDownList6.Items.Add("FatsaM2C1");
            DropDownList6.Items.Add("FatsaM2C2");
        }
    }

    //Apartmanların bulunduğu dropdownlist'e seçilmiş olan caddeye ait apartman adlarını yazdırır
    void apartmanlar()
    {
        DropDownList7.Items.Clear();
        DropDownList7.Items.Add("Apartman");
        //Konak apartmanlarını ekler
        if (DropDownList6.SelectedItem.Text == "KonakM1C1")
        {
            DropDownList7.Items.Add("KonakM1C1A1");
            DropDownList7.Items.Add("KonakM1C1A2");
        }
        else if (DropDownList6.SelectedItem.Text == "KonakM1C2")
        {
            DropDownList7.Items.Add("KonakM1C2A1");
            DropDownList7.Items.Add("KonakM1C2A2");
        }
        else if (DropDownList6.SelectedItem.Text == "KonakM2C1")
        {
            DropDownList7.Items.Add("KonakM2C1A1");
            DropDownList7.Items.Add("KonakM2C1A2");
        }
        else if (DropDownList6.SelectedItem.Text == "KonakM2C2")
        {
            DropDownList7.Items.Add("KonakM2C2A1");
            DropDownList7.Items.Add("KonakM2C2A2");
        }
        //Buca apartmanlarını ekler
        else if (DropDownList6.SelectedItem.Text == "BucaM1C1")
        {
            DropDownList7.Items.Add("BucaM1C1A1");
            DropDownList7.Items.Add("BucaM1C1A2");
        }
        else if (DropDownList6.SelectedItem.Text == "BucaM1C2")
        {
            DropDownList7.Items.Add("BucaM1C2A1");
            DropDownList7.Items.Add("BucaM1C2A2");
        }
        else if (DropDownList6.SelectedItem.Text == "BucaM2C1")
        {
            DropDownList7.Items.Add("BucaM2C1A1");
            DropDownList7.Items.Add("BucaM2C1A2");
        }
        else if (DropDownList6.SelectedItem.Text == "BucaM2C2")
        {
            DropDownList7.Items.Add("BucaM2C2A1");
            DropDownList7.Items.Add("BucaM2C2A2");
        }
        //Ünye apartmanlarını ekler
        else if (DropDownList6.SelectedItem.Text == "ÜnyeM1C1")
        {
            DropDownList7.Items.Add("ÜnyeM1C1A1");
            DropDownList7.Items.Add("ÜnyeM1C1A2");
        }
        else if (DropDownList6.SelectedItem.Text == "ÜnyeM1C2")
        {
            DropDownList7.Items.Add("ÜnyeM1C2A1");
            DropDownList7.Items.Add("ÜnyeM1C2A2");
        }
        else if (DropDownList6.SelectedItem.Text == "ÜnyeM2C1")
        {
            DropDownList7.Items.Add("ÜnyeM2C1A1");
            DropDownList7.Items.Add("ÜnyeM2C1A2");
        }
        else if (DropDownList6.SelectedItem.Text == "ÜnyeM2C2")
        {
            DropDownList7.Items.Add("ÜnyeM2C2A1");
            DropDownList7.Items.Add("ÜnyeM2C2A2");
        }
        //Fatsa apartmanlarını ekler
        else if (DropDownList6.SelectedItem.Text == "FatsaM1C1")
        {
            DropDownList7.Items.Add("FatsaM1C1A1");
            DropDownList7.Items.Add("FatsaM1C1A2");
        }
        else if (DropDownList6.SelectedItem.Text == "FatsaM1C2")
        {
            DropDownList7.Items.Add("FatsaM1C2A1");
            DropDownList7.Items.Add("FatsaM1C2A2");
        }
        else if (DropDownList6.SelectedItem.Text == "FatsaM2C1")
        {
            DropDownList7.Items.Add("FatsaM2C1A1");
            DropDownList7.Items.Add("FatsaM2C1A2");
        }
        else if (DropDownList6.SelectedItem.Text == "FatsaM2C2")
        {
            DropDownList7.Items.Add("FatsaM2C2A1");
            DropDownList7.Items.Add("FatsaM2C2A2");
        }
    }

    //Kapı numaralarının bulunduğu dropdownlist'e seçilmiş olan apartmana ait kapı numaralarını yazdırır
    void kapino()
    {
        //Konak Kapı Numaraları
        DropDownList8.Items.Clear();
        DropDownList8.Items.Add("Kapı No");
        if (DropDownList7.SelectedItem.Text == "KonakM1C1A1")
        {
            DropDownList8.Items.Add("KonakM1C1A1K1");
            DropDownList8.Items.Add("KonakM1C1A1K2");
        }
        else if (DropDownList7.SelectedItem.Text == "KonakM1C1A2")
        {
            DropDownList8.Items.Add("KonakM1C1A2K1");
            DropDownList8.Items.Add("KonakM1C1A2K2");
        }
        else if (DropDownList7.SelectedItem.Text == "KonakM1C2A1")
        {
            DropDownList8.Items.Add("KonakM1C2A1K1");
            DropDownList8.Items.Add("KonakM1C2A1K2");
        }
        else if (DropDownList7.SelectedItem.Text == "KonakM1C2A2")
        {
            DropDownList8.Items.Add("KonakM1C2A2K1");
            DropDownList8.Items.Add("KonakM1C2A2K2");
        }
        else if (DropDownList7.SelectedItem.Text == "KonakM2C1A1")
        {
            DropDownList8.Items.Add("KonakM2C1A1K1");
            DropDownList8.Items.Add("KonakM2C1A1K2");
        }
        else if (DropDownList7.SelectedItem.Text == "KonakM2C1A2")
        {
            DropDownList8.Items.Add("KonakM2C1A2K1");
            DropDownList8.Items.Add("KonakM2C1A2K2");
        }
        else if (DropDownList7.SelectedItem.Text == "KonakM2C2A1")
        {
            DropDownList8.Items.Add("KonakM2C2A1K1");
            DropDownList8.Items.Add("KonakM2C2A2K2");
        }
        else if (DropDownList7.SelectedItem.Text == "KonakM2C2A2")
        {
            DropDownList8.Items.Add("KonakM2C2A2K1");
            DropDownList8.Items.Add("KonakM2C2A2K2");
        }
        //Buca Kapı Numaraları
        else if (DropDownList7.SelectedItem.Text == "BucaM1C1A1")
        {
            DropDownList8.Items.Add("BucaM1C1A1K1");
            DropDownList8.Items.Add("BucaM1C1A1K2");
        }
        else if (DropDownList7.SelectedItem.Text == "BucaM1C1A2")
        {
            DropDownList8.Items.Add("BucaM1C1A2K1");
            DropDownList8.Items.Add("BucaM1C1A2K2");
        }
        else if (DropDownList7.SelectedItem.Text == "BucaM1C2A1")
        {
            DropDownList8.Items.Add("BucaM1C2A1K1");
            DropDownList8.Items.Add("BucaM1C2A1K2");
        }
        else if (DropDownList7.SelectedItem.Text == "BucaM1C2A2")
        {
            DropDownList8.Items.Add("BucaM1C2A2K1");
            DropDownList8.Items.Add("BucaM1C2A2K2");
        }
        else if (DropDownList7.SelectedItem.Text == "BucaM2C1A1")
        {
            DropDownList8.Items.Add("BucaM2C1A1K1");
            DropDownList8.Items.Add("BucaM2C1A1K2");
        }
        else if (DropDownList7.SelectedItem.Text == "BucaM2C1A2")
        {
            DropDownList8.Items.Add("BucaM2C1A2K1");
            DropDownList8.Items.Add("BucaM2C1A2K2");
        }
        else if (DropDownList7.SelectedItem.Text == "BucaM2C2A1")
        {
            DropDownList8.Items.Add("BucaM2C2A1K1");
            DropDownList8.Items.Add("BucaM2C2A1K2");
        }
        else if (DropDownList7.SelectedItem.Text == "BucaM2C2A2")
        {
            DropDownList8.Items.Add("BucaM2C2A2K1");
            DropDownList8.Items.Add("BucaM2C2A2K2");
        }
        //Ünye Kapı Numaraları
        else if (DropDownList7.SelectedItem.Text == "ÜnyeM1C1A1")
        {
            DropDownList8.Items.Add("ÜnyeM1C1A1K1");
            DropDownList8.Items.Add("ÜnyeM1C1A1K2");
        }
        else if (DropDownList7.SelectedItem.Text == "ÜnyeM1C1A2")
        {
            DropDownList8.Items.Add("ÜnyeM1C1A2K1");
            DropDownList8.Items.Add("ÜnyeM1C1A2K2");
        }
        else if (DropDownList7.SelectedItem.Text == "ÜnyeM1C2A1")
        {
            DropDownList8.Items.Add("ÜnyeM1C2A1K1");
            DropDownList8.Items.Add("ÜnyeM1C2A1K2");
        }
        else if (DropDownList7.SelectedItem.Text == "ÜnyeM1C2A2")
        {
            DropDownList8.Items.Add("ÜnyeM1C2A2K1");
            DropDownList8.Items.Add("ÜnyeM1C2A2K2");
        }
        else if (DropDownList7.SelectedItem.Text == "ÜnyeM2C1A1")
        {
            DropDownList8.Items.Add("ÜnyeM2C1A1K1");
            DropDownList8.Items.Add("ÜnyeM2C1A1K2");
        }
        else if (DropDownList7.SelectedItem.Text == "ÜnyeM2C1A2")
        {
            DropDownList8.Items.Add("ÜnyeM2C1A2K1");
            DropDownList8.Items.Add("ÜnyeM2C1A2K2");
        }
        else if (DropDownList7.SelectedItem.Text == "ÜnyeM2C2A1")
        {
            DropDownList8.Items.Add("ÜnyeM2C2A1K1");
            DropDownList8.Items.Add("ÜnyeM2C2A1K2");
        }
        else if (DropDownList7.SelectedItem.Text == "ÜnyeM2C2A2")
        {
            DropDownList8.Items.Add("ÜnyeM2C2A2K1");
            DropDownList8.Items.Add("ÜnyeM2C2A2K2");
        }
        //Fatsa Kapı Numaraları
        else if (DropDownList7.SelectedItem.Text == "FatsaM1C1A1")
        {
            DropDownList8.Items.Add("FatsaM1C1A1K1");
            DropDownList8.Items.Add("FatsaM1C1A1K2");
        }
        else if (DropDownList7.SelectedItem.Text == "FatsaM1C1A2")
        {
            DropDownList8.Items.Add("FatsaM1C1A2K1");
            DropDownList8.Items.Add("FatsaM1C1A2K2");
        }
        else if (DropDownList7.SelectedItem.Text == "FatsaM1C2A1")
        {
            DropDownList8.Items.Add("FatsaM1C2A1K1");
            DropDownList8.Items.Add("FatsaM1C2A1K2");
        }
        else if (DropDownList7.SelectedItem.Text == "FatsaM1C2A2")
        {
            DropDownList8.Items.Add("FatsaM1C2A2K1");
            DropDownList8.Items.Add("FatsaM1C2A2K2");
        }
        else if (DropDownList7.SelectedItem.Text == "FatsaM2C1A1")
        {
            DropDownList8.Items.Add("FatsaM2C1A1K1");
            DropDownList8.Items.Add("FatsaM2C1A1K2");
        }
        else if (DropDownList7.SelectedItem.Text == "FatsaM2C1A2")
        {
            DropDownList8.Items.Add("FatsaM2C1A2K1");
            DropDownList8.Items.Add("FatsaM2C1A2K2");
        }
        else if (DropDownList7.SelectedItem.Text == "FatsaM2C2A1")
        {
            DropDownList8.Items.Add("FatsaM2C2A1K1");
            DropDownList8.Items.Add("FatsaM2C2A1K2");
        }
        else if (DropDownList7.SelectedItem.Text == "FatsaM2C2A2")
        {
            DropDownList8.Items.Add("FatsaM2C2A2K1");
            DropDownList8.Items.Add("FatsaM2C2A2K2");
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (DropDownList1.Items.Capacity == 0)
        {            
            adlar();
            soyadlar();
            iller();
            ilceler();
            mahalleler();
            caddeler();
            apartmanlar();
            kapino();            
        }
        DropDownList3.AutoPostBack = true;
        DropDownList4.AutoPostBack = true;
        DropDownList5.AutoPostBack = true;
        DropDownList6.AutoPostBack = true;
        DropDownList7.AutoPostBack = true;
        DropDownList8.AutoPostBack = true;
    }

    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        //İl değiştiğinde ile bağlı olarak diğer alt verilerin değişmesini sağlar
        ilceler();
        mahalleler();
        caddeler();
        apartmanlar();
        kapino();
    }

    protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
    {
        //İlçe değiştiğinde ilçeye bağlı olarak diğer alt verilerin değişmesini sağlar
        mahalleler();
        caddeler();
        apartmanlar();
        kapino();
    }

    protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Mahalle değiştiğinde mahalleye bağlı olarak diğer alt verilerin değişmesini sağlar
        caddeler();
        apartmanlar();
        kapino();
    }

    protected void DropDownList6_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Cadde değiştiğinde caddeye bağlı olarak diğer alt verilerin değişmesini sağlar
        apartmanlar();
        kapino();
    }

    protected void DropDownList7_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Apartman değiştiğinde apartmana bağlı olarak diğer alt verilerin değişmesini sağlar
        kapino();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //Sırayla il-ilçe-mahalle-cadde-apartman-kapino verilerinin boş olup olmama durumunu kontrol eder
        //Eğer boş veri varsa kullanıcıya o veriyi doldurması için uyarı mesajı verir
        //Boş veri yoksa ilgili textboxlara dropdowndan alacağı verileri yazdırır
        if (DropDownList3.SelectedIndex == 0)
        {
            Response.Write("<script>alert('İl Seçiniz')</script>");
            txtClear();
        }
        else
        {
            if (DropDownList4.SelectedIndex == 0)
            {
                Response.Write("<script>alert('İlçe Seçiniz')</script>");
                txtClear();
            }
            else
            {
                if (DropDownList5.SelectedIndex == 0)
                {
                    Response.Write("<script>alert('Mahalle Seçiniz')</script>");
                    txtClear();
                }
                else
                {
                    if (DropDownList6.SelectedIndex == 0)
                    {
                        Response.Write("<script>alert('Cadde Seçiniz')</script>");
                        txtClear();
                    }
                    else
                    {
                        if (DropDownList7.SelectedIndex == 0)
                        {
                            Response.Write("<script>alert('Apartman Seçiniz')</script>");
                            txtClear();
                        }
                        else
                        {
                            if (DropDownList8.SelectedIndex == 0)
                            {
                                Response.Write("<script>alert('Kapı Numarası Seçiniz')</script>");
                                txtClear();
                            }
                            else
                            {
                                TextBox1.Text = DropDownList1.SelectedItem.Text;
                                TextBox2.Text = DropDownList2.SelectedItem.Text;
                                TextBox3.Text = DropDownList3.SelectedItem.Text;
                                TextBox4.Text = DropDownList4.SelectedItem.Text;
                                TextBox5.Text = DropDownList5.SelectedItem.Text;
                                TextBox6.Text = DropDownList6.SelectedItem.Text;
                                TextBox7.Text = DropDownList7.SelectedItem.Text;
                                TextBox8.Text = DropDownList8.SelectedItem.Text;
                            }
                        }
                    }
                }
            }
        }
    }
}