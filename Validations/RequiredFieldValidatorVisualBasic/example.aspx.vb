
Partial Class example
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        RequiredFieldValidator1.ControlToValidate = TextBox1.ClientID
        RequiredFieldValidator1.Text = "Ad alanı boş bırakıldı"
        RequiredFieldValidator1.InitialValue = ""
    End Sub
End Class
