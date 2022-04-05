
Partial Class example_datetime
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        RangeValidator1.ControlToValidate = TextBox1.ClientID
        RangeValidator1.Text = "01.01.2000 ile 01.01.2010 aralığında tarih giriniz"
        RangeValidator1.Type = ValidationDataType.Date
        RangeValidator1.MinimumValue = "01.01.2000"
        RangeValidator1.MaximumValue = "01.01.2010"
    End Sub
End Class
