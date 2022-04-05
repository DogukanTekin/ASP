
Partial Class ogrenci
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            RadioButtonList1.Items.Add("Bilgisayar Programcılığı")
            RadioButtonList1.Items.Add("Turizm")
            RadioButtonList1.Items.Add("İstatistik")
            RadioButtonList3.Items.Add("1")
            RadioButtonList3.Items.Add("2")
            RadioButtonList3.Items.Add("3")
            RadioButtonList3.Items.Add("4")
            RadioButtonList2.Items.Add("Örgün Öğretim")
            RadioButtonList2.Items.Add("İkinci Öğretim")
            RadioButtonList2.Items.Add("Uzaktan Öğretim")
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox5.Text = ""
        TextBox5.Text = TextBox1.Text + vbCrLf + TextBox2.Text + vbCrLf + TextBox3.Text + vbCrLf + TextBox4.Text + vbCrLf + RadioButtonList1.SelectedItem.Text + vbCrLf + RadioButtonList3.SelectedItem.Text + vbCrLf + RadioButtonList2.SelectedItem.Text
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub
End Class
