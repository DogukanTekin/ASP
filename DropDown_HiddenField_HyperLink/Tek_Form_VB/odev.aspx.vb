
Partial Class odev
    Inherits System.Web.UI.Page

    Public Sub ilce()
        DropDownList4.Items.Clear()
        DropDownList4.Items.Add("İlçe")
        If DropDownList3.SelectedIndex = 1 Then
            DropDownList4.Items.Add("Buca")
            DropDownList4.Items.Add("Konak")
            DropDownList4.Items.Add("Bornova")
        ElseIf DropDownList3.SelectedIndex = 2 Then
            DropDownList4.Items.Add("Ünye")
            DropDownList4.Items.Add("Fatsa")
            DropDownList4.Items.Add("Altınordu")
        ElseIf DropDownList3.SelectedIndex = 3 Then
            DropDownList4.Items.Add("Atakum")
            DropDownList4.Items.Add("Canik")
            DropDownList4.Items.Add("İlkadım")
        End If
    End Sub
    Public Sub mahalle()
        DropDownList5.Items.Clear()
        DropDownList5.Items.Add("Mahalle")
        If DropDownList4.SelectedIndex = 1 Then
            DropDownList5.Items.Add("Adatepe")
            DropDownList5.Items.Add("29 Ekim Mahallesi")
            DropDownList5.Items.Add("Atatürk")
        ElseIf DropDownList4.SelectedIndex = 2 Then
            DropDownList5.Items.Add("Cumhuriyet")
            DropDownList5.Items.Add("Gölevi")
            DropDownList5.Items.Add("İnönü")
        ElseIf DropDownList4.SelectedIndex = 3 Then
            DropDownList5.Items.Add("Çınarlık")
            DropDownList5.Items.Add("Kuruçeşme")
            DropDownList5.Items.Add("Merkez")
        End If
    End Sub
    Public Sub sokak()
        DropDownList6.Items.Clear()
        DropDownList6.Items.Add("Sokak")
        If DropDownList5.SelectedIndex = 1 Then
            DropDownList6.Items.Add("2119")
            DropDownList6.Items.Add("2128")
            DropDownList6.Items.Add("2141")
        ElseIf DropDownList5.SelectedIndex = 2 Then
            DropDownList6.Items.Add("1441")
            DropDownList6.Items.Add("1444")
            DropDownList6.Items.Add("1447")
        ElseIf DropDownList5.SelectedIndex = 3 Then
            DropDownList6.Items.Add("556")
            DropDownList6.Items.Add("554")
            DropDownList6.Items.Add("560")
        End If
    End Sub
    Public Sub apartman()
        DropDownList7.Items.Clear()
        DropDownList7.Items.Add("Apartman")
        If DropDownList6.SelectedIndex = 1 Then
            DropDownList7.Items.Add("Gül Apt. / 7")
            DropDownList7.Items.Add("Tepe Apt. / 9")
            DropDownList7.Items.Add("Merkez Apt. / 6")
        ElseIf DropDownList6.SelectedIndex = 2 Then
            DropDownList7.Items.Add("A Apt. / 11")
            DropDownList7.Items.Add("B Apt. / 22")
            DropDownList7.Items.Add("C Apt. / 16")
        ElseIf DropDownList6.SelectedIndex = 3 Then
            DropDownList7.Items.Add("1. Apt / 1")
            DropDownList7.Items.Add("2. Apt / 2")
            DropDownList7.Items.Add("3. Apt / 3")
        End If
    End Sub

    Public Sub daire()
        DropDownList8.Items.Clear()
        DropDownList8.Items.Add("Daire")
        If DropDownList7.SelectedIndex = 1 Then
            DropDownList8.Items.Add("1")
            DropDownList8.Items.Add("2")
            DropDownList8.Items.Add("3")
        ElseIf DropDownList7.SelectedIndex = 2 Then
            DropDownList8.Items.Add("11")
            DropDownList8.Items.Add("22")
            DropDownList8.Items.Add("33")
        ElseIf DropDownList7.SelectedIndex = 3 Then
            DropDownList8.Items.Add("7")
            DropDownList8.Items.Add("8")
            DropDownList8.Items.Add("9")
        End If
    End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            DropDownList1.Items.Add("Ad")
            DropDownList1.Items.Add("Doğukan")
            DropDownList1.Items.Add("Umut")
            DropDownList1.Items.Add("Emirhan")
            DropDownList2.Items.Add("Soyad")
            DropDownList2.Items.Add("TEKİN")
            DropDownList2.Items.Add("TOKSOY")
            DropDownList2.Items.Add("KOÇ")
            DropDownList3.Items.Add("İl")
            DropDownList3.Items.Add("İzmir")
            DropDownList3.Items.Add("Ordu")
            DropDownList3.Items.Add("Samsun")
            DropDownList4.Items.Add("İlçe")
            DropDownList5.Items.Add("Mahalle")
            DropDownList6.Items.Add("Sokak")
            DropDownList7.Items.Add("Apartman")
            DropDownList8.Items.Add("Daire")
        End If
        DropDownList3.AutoPostBack = True
        DropDownList4.AutoPostBack = True
        DropDownList5.AutoPostBack = True
        DropDownList6.AutoPostBack = True
        DropDownList7.AutoPostBack = True
    End Sub

    Protected Sub DropDownList3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList3.SelectedIndexChanged
        ilce()
        mahalle()
        sokak()
        apartman()
        daire()
    End Sub

    Protected Sub DropDownList4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList4.SelectedIndexChanged
        mahalle()
        sokak()
        apartman()
        daire()
    End Sub

    Protected Sub DropDownList5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList5.SelectedIndexChanged
        sokak()
        apartman()
        daire()
    End Sub

    Protected Sub DropDownList6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList6.SelectedIndexChanged
        apartman()
        daire()
    End Sub

    Protected Sub DropDownList7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList7.SelectedIndexChanged
        daire()
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DropDownList1.SelectedIndex = 0 Then
            Response.Write("<script>alert('Ad Seçiniz')</script>")
        Else
            If DropDownList2.SelectedIndex = 0 Then
                Response.Write("<script>alert('Soyad Seçiniz')</script>")
            Else
                If DropDownList3.SelectedIndex = 0 Then
                    Response.Write("<script>alert('İl Seçiniz')</script>")
                Else
                    If DropDownList4.SelectedIndex = 0 Then
                        Response.Write("<script>alert('İlçe Seçiniz')</script>")
                    Else
                        If DropDownList5.SelectedIndex = 0 Then
                            Response.Write("<script>alert('Mahalle Seçiniz')</script>")
                        Else
                            If DropDownList6.SelectedIndex = 0 Then
                                Response.Write("<script>alert('Sokak Seçiniz')</script>")
                            Else
                                If DropDownList7.SelectedIndex = 0 Then
                                    Response.Write("<script>alert('Apartman Seçiniz')</script>")
                                Else
                                    If DropDownList8.SelectedIndex = 0 Then
                                        Response.Write("<script>alert('Daire Seçiniz')</script>")
                                    Else
                                        TextBox1.Text = DropDownList1.SelectedItem.Value
                                        TextBox2.Text = DropDownList2.SelectedItem.Value
                                        TextBox3.Text = DropDownList3.SelectedItem.Value
                                        TextBox4.Text = DropDownList4.SelectedItem.Value
                                        TextBox5.Text = DropDownList5.SelectedItem.Value
                                        TextBox6.Text = DropDownList6.SelectedItem.Value
                                        TextBox7.Text = DropDownList7.SelectedItem.Value
                                        TextBox8.Text = DropDownList8.SelectedItem.Value
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
End Class
