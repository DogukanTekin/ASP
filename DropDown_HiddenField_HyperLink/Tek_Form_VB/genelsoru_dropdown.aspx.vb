
Partial Class genelsoru_dropdown
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        HyperLink1.Text = "Anasayfa"
        HyperLink1.NavigateUrl = "/genelsoru_s1.aspx"
        If DropDownList1.Items.Capacity = 0 Then
            DropDownList1.Items.Add("İzmir")
            DropDownList1.Items.Add("Ordu")
            DropDownList1.Items.Add("Samsun")
            DropDownList1.AutoPostBack = True
        End If
        Label1.Text = "Buca"
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        If DropDownList1.SelectedIndex = 0 Then
            Label1.Text = "Buca"
        ElseIf DropDownList1.SelectedIndex = 1 Then
            Label1.Text = "Ünye"
        Else
            Label1.Text = "Atakum"
        End If
    End Sub
End Class
