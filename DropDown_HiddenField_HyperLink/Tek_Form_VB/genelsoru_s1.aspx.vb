
Partial Class genelsoru_s1
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        HyperLink1.Text = "HiddenField"
        HyperLink2.Text = "DropDownList"
        HyperLink1.NavigateUrl = "/genelsoru_hidden.aspx"
        HyperLink2.NavigateUrl = "/genelsoru_dropdown.aspx"
    End Sub
End Class
