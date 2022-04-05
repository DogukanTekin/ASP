
Partial Class BüyükDileKontrol
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        RegularExpressionValidator1.ControlToValidate = "TextBox1"
        RegularExpressionValidator1.Text = "Hatalı giriş yapıldı"
        RegularExpressionValidator1.ValidationExpression = "^\D{3}"

        RegularExpressionValidator2.ControlToValidate = "TextBox2"
        RegularExpressionValidator2.Text = "Hatalı giriş yapıldı"
        RegularExpressionValidator2.ValidationExpression = "^\D{3}.\D{2}$"

        RegularExpressionValidator3.ControlToValidate = "TextBox3"
        RegularExpressionValidator3.Text = "Hatalı giriş yapıldı"
        RegularExpressionValidator3.ValidationExpression = "^\d{4}-\D{3}-\d{2}$"

        RegularExpressionValidator4.ControlToValidate = "TextBox4"
        RegularExpressionValidator4.Text = "Hatalı giriş yapıldı"
        RegularExpressionValidator4.ValidationExpression = "^\w+@\w{7}\.\w+"

        RegularExpressionValidator5.ControlToValidate = "TextBox5"
        RegularExpressionValidator5.Text = "Hatalı giriş yapıldı"
        RegularExpressionValidator5.ValidationExpression = "^[a-zA-Z'-'\s]{1,40}$"
    End Sub
End Class
