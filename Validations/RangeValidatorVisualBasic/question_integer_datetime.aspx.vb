
Partial Class question_integer_datetime
    Inherits System.Web.UI.Page


    'Boş olup olmadığını kontrol ediyor
    Public Sub isempty(rq As RequiredFieldValidator, tb As TextBox, msg As String)
        rq.ControlToValidate = tb.ClientID
        rq.Text = msg + " alanı boş bırakıldı"
        rq.InitialValue = ""
    End Sub

    'Girilen değerin sayıysa istenilen sayı aralığında, tarihse istenilen tarih aralığında olup olmadığını kontrol ediyor
    Public Sub rangeval(rv As RangeValidator, type As ValidationDataType, tb As TextBox, val1 As String, val2 As String)
        rv.ControlToValidate = tb.ClientID
        If (type = ValidationDataType.Integer) Then
            rv.Text = val1 + " ile " + val2 + " aralığında sayı giriniz"
            rv.Type = type
            rv.MinimumValue = Convert.ToInt16(val1)
            rv.MaximumValue = Convert.ToInt16(val2)
        ElseIf (type = ValidationDataType.Date) Then
            rv.Text = val1 + " ile " + val2 + " aralığında bir tarih giriniz"
            rv.Type = type
            rv.MinimumValue = val1
            rv.MaximumValue = val2
        End If
    End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        isempty(RequiredFieldValidator1, TextBox2, "Ad")
        rangeval(RangeValidator2, ValidationDataType.Date, TextBox3, "01.01.2000", "01.01.2010")
        rangeval(RangeValidator3, ValidationDataType.Integer, TextBox4, "1", "100")
    End Sub
End Class
