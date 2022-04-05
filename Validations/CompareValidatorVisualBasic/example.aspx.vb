
Partial Class example
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        CompareValidator1.ControlToCompare = TextBox1.ClientID
        CompareValidator1.ControlToValidate = TextBox2.ClientID
        CompareValidator1.Text = "Girilen değerler eşit değil"
    End Sub
End Class
