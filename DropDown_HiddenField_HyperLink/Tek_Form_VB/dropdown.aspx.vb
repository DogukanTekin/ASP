
Partial Class dropdown
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If DropDownList1.Items.Capacity = 0 Then
            DropDownList1.Items.Add("Doğukan")
            DropDownList1.Items.Add("Umut")
            DropDownList1.Items.Add("Emirhan")
            DropDownList1.AutoPostBack = True
        End If
        TextBox1.Text = "TEKİN"
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        If DropDownList1.SelectedIndex = 0 Then
            TextBox1.Text = "TEKİN"
        ElseIf DropDownList1.SelectedIndex = 1 Then
            TextBox1.Text = "TOKSOY"
        Else
            TextBox1.Text = "KOÇ"
        End If
    End Sub
End Class
