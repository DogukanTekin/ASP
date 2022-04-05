
Partial Class RegularExpressionValidator
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        RegularExpressionValidator1.ControlToValidate = "TextBox1"
        RegularExpressionValidator1.Text = "Sayı değeri yanlış girildi"
        RegularExpressionValidator1.ValidationExpression = "\d{3}" ' -> Sadece 3 haneli sayı değeri girilmesine izin verir
        RegularExpressionValidator2.ControlToValidate = "TextBox2"
        RegularExpressionValidator2.Text = "Sayı değeri yanlış girildi"
        RegularExpressionValidator2.ValidationExpression = "^\d{3}-\d{2}-\d{4}$"
        RegularExpressionValidator3.ControlToValidate = "TextBox3"
        RegularExpressionValidator3.Text = "Sayı değeri yanlış girildi"
        RegularExpressionValidator3.ValidationExpression = "^\d+$" ' -> + değeri koyduksak sınırsız sayı girebiliriz
        RegularExpressionValidator4.ControlToValidate = "TextBox4"
        RegularExpressionValidator4.Text = "Sayı değeri yanlış girildi"
        RegularExpressionValidator4.ValidationExpression = "^\d+(\.\d\d)?$" '-> \d\d ifadesi yan yana 2 rakam girilmesi içindir
        ' -> \. ifadesi araya . koydurmak içindir
        RegularExpressionValidator5.ControlToValidate = "TextBox5"
        RegularExpressionValidator5.Text = "Sayı değeri yanlış girildi"
        RegularExpressionValidator5.ValidationExpression = "^\d{3}(\.\d\d)?$"
    End Sub
End Class
