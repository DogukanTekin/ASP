
Partial Class soru1
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            RadioButtonList2.Items.Add("Yapıldı")
            RadioButtonList2.Items.Add("Tecilli")
            RadioButtonList1.Items.Add("Erkek")
            RadioButtonList1.Items.Add("Kadın")
            RadioButtonList3.Items.Add("Lise")
            RadioButtonList3.Items.Add("Ön Lisans")
            RadioButtonList3.Items.Add("Lisans")
        End If
    End Sub
End Class
