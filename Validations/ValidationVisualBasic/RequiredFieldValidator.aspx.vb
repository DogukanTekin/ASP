
Partial Class RequiredFieldValidator
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        RequiredFieldValidator1.ControlToValidate = TextBox1.ClientID
        RequiredFieldValidator1.Text = "Ad alanı boş bırakıldı"
        RequiredFieldValidator1.InitialValue = ""
        RequiredFieldValidator2.ControlToValidate = TextBox2.ClientID
        RequiredFieldValidator2.Text = "Soyad alanı boş bırakıldı"
        RequiredFieldValidator2.InitialValue = ""
    End Sub
End Class
