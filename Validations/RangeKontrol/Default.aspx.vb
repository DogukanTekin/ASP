
Partial Class _Default
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        CompareValidator1.ControlToValidate = "TextBox5"
        CompareValidator1.ControlToCompare = "TextBox4"
        CompareValidator1.Text = "Girilen değerler aynı değil"
    End Sub
End Class
