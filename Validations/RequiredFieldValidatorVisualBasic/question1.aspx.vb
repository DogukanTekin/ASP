
Partial Class question1
    Inherits System.Web.UI.Page

    Public Sub emptyval(rq As RequiredFieldValidator, tb As TextBox, msg As String)
        rq.ControlToValidate = tb.ClientID
        rq.Text = msg + " alanı boş bırakıldı"
        rq.InitialValue = ""
    End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        emptyval(RequiredFieldValidator1, TextBox1, "Ad")
        emptyval(RequiredFieldValidator2, TextBox2, "Soyad")
        emptyval(RequiredFieldValidator3, TextBox3, "Telefon numarası")
    End Sub
End Class
