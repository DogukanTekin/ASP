
Partial Class soru2_s1
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        HyperLink1.Text = "Sayfa 1"
        HyperLink2.Text = "Sayfa 2"
        HyperLink3.Text = "Sayfa 3"
        HyperLink4.Text = "Sayfa 4"
        HyperLink1.NavigateUrl = "/soru2_s2.aspx"
        HyperLink2.NavigateUrl = "/soru2_s3.aspx"
        HyperLink3.NavigateUrl = "/soru2_s4.aspx"
        HyperLink4.NavigateUrl = "/soru2_s5.aspx"
    End Sub
End Class
