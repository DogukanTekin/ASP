
Partial Class RegularExpressionValidationOrnek
    Inherits System.Web.UI.Page

    'Public Sub kontrol(rev As RegularExpressionValidator, tb As String, msg As String, val As String)
    '    rev.ControlToValidate = tb
    '    rev.Text = msg
    '    rev.ValidationExpression = val
    'End Sub

    'Public Sub emptycontrol(rq As RequiredFieldValidator, tb As String, msg As String)
    '    rq.ControlToValidate = tb
    '    rq.Text = msg
    '    rq.InitialValue = ""
    'End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        RequiredFieldValidator1.ControlToValidate = "TextBox1"
        RequiredFieldValidator1.Text = "Boş girilemez"
        RequiredFieldValidator1.InitialValue = ""
        RegularExpressionValidator1.ControlToValidate = "TextBox1"
        RegularExpressionValidator1.Text = "Hatalı numara girişi yapıldı"
        RegularExpressionValidator1.ValidationExpression = "^\d{3}\.\d{7}$"
    End Sub
End Class
