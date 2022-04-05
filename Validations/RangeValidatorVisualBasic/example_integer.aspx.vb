
Partial Class example
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        RangeValidator1.ControlToValidate = TextBox1.ClientID
        RangeValidator1.Text = "1 ile 50 arasında değer giriniz"
        RangeValidator1.Type = ValidationDataType.Integer
        RangeValidator1.MinimumValue = 1
        RangeValidator1.MaximumValue = 50
    End Sub
End Class
