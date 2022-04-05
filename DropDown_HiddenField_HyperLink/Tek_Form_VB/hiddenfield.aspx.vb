
Partial Class hiddenfield
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextBox1.Text = "Doğukan"
        HiddenField1.Value = "Doğukan TEKİN"
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = HiddenField1.Value
    End Sub
End Class
