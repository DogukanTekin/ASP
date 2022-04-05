
Partial Class soru
    Inherits System.Web.UI.Page

    Public Sub bosmu(rq As RequiredFieldValidator, tb As String, msg As String)
        rq.ControlToValidate = tb
        rq.Text = msg + " boş geçilemez"
        rq.InitialValue = ""
    End Sub

    'Public Sub uzunluk(rv As RangeValidator, tb As String, min As Integer, max As Integer, msg As String)
    '    rv.ControlToValidate = tb
    '    rv.Type = ValidationDataType.Integer
    '    rv.MinimumValue = min
    '    rv.MaximumValue = max
    '    rv.Text = msg
    'End Sub

    Public Sub uzunluk(rv As RegularExpressionValidator, tb As String, msg As String)
        rv.ControlToValidate = tb
        rv.Text = msg
    End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        bosmu(RequiredFieldValidator1, "TextBox1", "Ad")
        bosmu(RequiredFieldValidator2, "TextBox2", "Soyad")
        bosmu(RequiredFieldValidator3, "TextBox3", "TC")
        bosmu(RequiredFieldValidator4, "TextBox4", "Okul no")
        bosmu(RequiredFieldValidator5, "TextBox5", "Adres")
        bosmu(RequiredFieldValidator6, "TextBox6", "Tel no")
        bosmu(RequiredFieldValidator7, "TextBox7", "Tel no yinele")
        bosmu(RequiredFieldValidator8, "TextBox8", "Doğum yeri")
        bosmu(RequiredFieldValidator9, "TextBox9", "Yaş")
        bosmu(RequiredFieldValidator10, "TextBox10", "Doğum tarihi")
        bosmu(RequiredFieldValidator11, "TextBox11", "Cinsiyet")
        bosmu(RequiredFieldValidator12, "TextBox12", "E-Mail")
        bosmu(RequiredFieldValidator13, "TextBox13", "E-Mail yinele")
        uzunluk(RegularExpressionValidator1, "TextBox1", "25 karakterden uzun ad girmeyiniz")
        RegularExpressionValidator1.ValidationExpression = "^\d{3}\.\d{7}$"
    End Sub
End Class
