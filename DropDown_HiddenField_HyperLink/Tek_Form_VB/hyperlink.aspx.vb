
Partial Class hyperlink
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        HyperLink1.Text = "Dene Bakalım"
        HyperLink1.NavigateUrl = "/hyperlink2.aspx"
    End Sub
End Class
