
Partial Class question1
    Inherits System.Web.UI.Page

    Public Sub intcontrol(rv As RangeValidator, tb As TextBox, val1 As Integer, val2 As Integer)
        rv.ControlToValidate = tb.ClientID
        rv.Text = val1.ToString() + " ile " + val2.ToString() + " aralığında sayısal değer giriniz"
        rv.Type = ValidationDataType.Integer
        rv.MinimumValue = val1
        rv.MaximumValue = val2
    End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        intcontrol(RangeValidator1, TextBox1, 1, 100)
        intcontrol(RangeValidator2, TextBox2, 100, 200)
    End Sub
End Class
