
Partial Class soru4_s3
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        HyperLink1.Text = "Anasayfa"
        HyperLink1.NavigateUrl = "/soru4_s1.aspx"
        Label1.Text = "Bilgisayar Programcılığı"
        HiddenField1.Value = "Doğukan TEKİN"
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = HiddenField1.Value
    End Sub
End Class
