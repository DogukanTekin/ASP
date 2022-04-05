
Partial Class question
    Inherits System.Web.UI.Page

    Public Sub isempty(rq As RequiredFieldValidator, tb As TextBox, msg As String)
        rq.ControlToValidate = tb.ClientID
        rq.Text = msg + " alanı boş bırakıldı"
        rq.InitialValue = ""
    End Sub

    Public Sub rangeval(rv As RangeValidator, type As ValidationDataType, tb As TextBox, val1 As String, val2 As String)
        rv.ControlToValidate = tb.ClientID
        rv.Type = type
        If (type = ValidationDataType.Integer) Then
            rv.MinimumValue = Convert.ToInt16(val1)
            rv.MaximumValue = Convert.ToInt16(val2)
            rv.Text = val1 + " ile " + val2 + " aralığında sayısal değer giriniz"
        ElseIf (type = ValidationDataType.Date) Then
            rv.MinimumValue = val1
            rv.MaximumValue = val2
            rv.Text = val1 + " ile " + val2 + " aralığında bir tarih giriniz"
        End If
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        isempty(RequiredFieldValidator1, TextBox1, "Ad")
        isempty(RequiredFieldValidator2, TextBox2, "Soyad")
        isempty(RequiredFieldValidator3, TextBox3, "Yaş")
        isempty(RequiredFieldValidator4, TextBox4, "Doğum tarihi")
        rangeval(RangeValidator1, ValidationDataType.Integer, TextBox3, "18", "35")
        rangeval(RangeValidator2, ValidationDataType.Date, TextBox4, "24.03.2004", "24.03.2039")
    End Sub
End Class
