
Partial Class soru3_s1
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        HyperLink1.Text = "DEU"
        HyperLink2.Text = "İMYO"
        HyperLink3.Text = "Amazon"
        HyperLink1.NavigateUrl = "https://www.deu.edu.tr/"
        HyperLink2.NavigateUrl = "https://imyo.deu.edu.tr/tr/"
        HyperLink3.NavigateUrl = "https://www.amazon.com.tr/"
    End Sub
End Class
