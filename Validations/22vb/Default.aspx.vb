
Partial Class _Default
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        RequiredFieldValidator1.ControlToValidate = "TextBox1"
        RequiredFieldValidator1.Text = "Kullanıcı Alanı Boş"
        RequiredFieldValidator1.InitialValue = ""
    End Sub
End Class
