
Partial Class _Default
    Inherits System.Web.UI.Page

    Public Sub kontrol(rq As RequiredFieldValidator, control As String, msg As String)
        rq.ControlToValidate = control
        rq.Text = msg
        rq.InitialValue = ""
    End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        kontrol(RequiredFieldValidator1, "TextBox1", "Kullanıcı Alanı Boş")
        kontrol(RequiredFieldValidator2, "TextBox2", "Kullanıcı Alanı Boş")
        kontrol(RequiredFieldValidator3, "TextBox3", "Kullanıcı Alanı Boş")
        kontrol(RequiredFieldValidator4, "TextBox4", "Kullanıcı Alanı Boş")
    End Sub
End Class
