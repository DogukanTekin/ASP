
Partial Class question_datetime
    Inherits System.Web.UI.Page

    Public Sub dateval(rv As RangeValidator, tb As TextBox, date1 As String, date2 As String)
        rv.ControlToValidate = tb.ClientID
        rv.Type = ValidationDataType.Date
        rv.Text = date1 + " ile " + date2 + " aralığında bir tarih giriniz"
        rv.MinimumValue = date1
        rv.MaximumValue = date2
    End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        dateval(RangeValidator1, TextBox1, "01.01.2000", "01.01.2020")
        dateval(RangeValidator2, TextBox2, "01.01.1990", "01.01.2000")
    End Sub
End Class
