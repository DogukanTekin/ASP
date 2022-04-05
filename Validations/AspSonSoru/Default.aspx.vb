
Partial Class _Default
    Inherits System.Web.UI.Page

    Public Sub isempty(rq As RequiredFieldValidator, tb As TextBox, msg As String)
        rq.ControlToValidate = tb.ClientID
        rq.Text = msg + " alanı boş geçildi"
        rq.InitialValue = ""
    End Sub

    Public Sub yas(rv As RangeValidator, tb As String, cins As ValidationDataType, min As String, max As String)
        rv.ControlToValidate = tb
        rv.Text = "Yaşınız 18 ile 35 aralığında olmalıdır"
        rv.Type = cins
        If (cins = ValidationDataType.Integer) Then
            rv.MinimumValue = Convert.ToInt16(min)
            rv.MaximumValue = Convert.ToInt16(max)
        ElseIf (cins = ValidationDataType.Date) Then
            rv.MinimumValue = min
            rv.MaximumValue = max
        End If
    End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Boş geçilemez
        isempty(RequiredFieldValidator1, TextBox1, "Ad")
        isempty(RequiredFieldValidator2, TextBox2, "Soyad")
        isempty(RequiredFieldValidator3, TextBox3, "Yaş")
        isempty(RequiredFieldValidator4, TextBox4, "Doğum tarihi")
        'Yaş kontrol
        'RangeValidator1.ControlToValidate = "TextBox3"
        'RangeValidator1.Text = "18 ile 35 arasında değer girmelisiniz"
        'RangeValidator1.Type = ValidationDataType.Integer
        'RangeValidator1.MinimumValue = 18
        'RangeValidator1.MaximumValue = 35
        yas(RangeValidator1, "TextBox3", ValidationDataType.Integer, "18", "35")
        yas(RangeValidator2, "TextBox4", ValidationDataType.Date, "24.03.1987", "24.03.2004")
        'Doğum Tarihi kontrol
        'RangeValidator2.ControlToValidate = "TextBox4"
        'RangeValidator2.Text = "Yaşınız 18 ile 35 arasında olmalıdır"
        'RangeValidator2.Type = ValidationDataType.Date
        'RangeValidator2.MinimumValue = "24.03.1987"
        'RangeValidator2.MaximumValue = "24.03.2004"
    End Sub
End Class
