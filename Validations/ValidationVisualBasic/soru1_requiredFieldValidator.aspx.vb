
Partial Class soru1_requiredFieldValidator
    Inherits System.Web.UI.Page

    Public Sub tb_isempty(rq As RequiredFieldValidator, tb As TextBox, msg As String)
        rq.ControlToValidate = tb.ClientID
        rq.Text = msg + " alanı boş bırakıldı"
        rq.InitialValue = ""
    End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        tb_isempty(RequiredFieldValidator1, TextBox1, "Ad")
        tb_isempty(RequiredFieldValidator2, TextBox2, "Soyad")
        tb_isempty(RequiredFieldValidator3, TextBox3, "Telefon numarası")
    End Sub
End Class
