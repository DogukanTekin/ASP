
Partial Class hp
    Inherits System.Web.UI.Page

    Public Sub emptycontrol(rq As RequiredFieldValidator, tb As String, msg As String)
        rq.ControlToValidate = tb
        rq.Text = msg + " alanı boş bırakılamaz"
        rq.InitialValue = ""
    End Sub

    Public Sub revcontrol(rv As RegularExpressionValidator, tb As String, msg As String, val As String)
        rv.ControlToValidate = tb
        rv.Text = msg
        rv.ValidationExpression = val
    End Sub

    Public Sub comcontrol(cv As CompareValidator, tb As String, tb1 As String, msg As String)
        cv.ControlToValidate = tb
        cv.ControlToCompare = tb1
        cv.Text = "Girmiş olduğunuz " + msg + " aynı olmalıdır"
    End Sub

    Public Sub integercontrol(rv As RangeValidator, tb As String, min As Integer, max As Integer)
        rv.ControlToValidate = tb
        rv.Text = min.ToString() + " ile " + max.ToString() + " aralığında yaş giriniz"
        rv.Type = ValidationDataType.Integer
        rv.MinimumValue = min
        rv.MaximumValue = max
    End Sub

    Public Sub datecontrol(rv As RangeValidator, tb As String, min As String, max As String)
        rv.ControlToValidate = tb
        rv.Text = min + " ile " + max + " aralığında bir tarih giriniz"
        rv.Type = ValidationDataType.Date
        rv.MinimumValue = min
        rv.MaximumValue = max
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        emptycontrol(RequiredFieldValidator1, "TextBox1", "Ad")
        emptycontrol(RequiredFieldValidator2, "TextBox2", "Soyad")
        emptycontrol(RequiredFieldValidator3, "TextBox3", "TC")
        emptycontrol(RequiredFieldValidator4, "TextBox4", "Okul no")
        emptycontrol(RequiredFieldValidator5, "TextBox5", "Adres")
        emptycontrol(RequiredFieldValidator6, "TextBox6", "Tel no")
        emptycontrol(RequiredFieldValidator7, "TextBox7", "Tel no yinele")
        emptycontrol(RequiredFieldValidator8, "TextBox8", "Doğum yeri")
        emptycontrol(RequiredFieldValidator9, "TextBox9", "Yaş")
        emptycontrol(RequiredFieldValidator10, "TextBox10", "Doğum tarihi")
        emptycontrol(RequiredFieldValidator11, "TextBox11", "Cinsiyet")
        emptycontrol(RequiredFieldValidator12, "TextBox12", "E-Mail")
        emptycontrol(RequiredFieldValidator13, "TextBox13", "E-Mail yinele")
        revcontrol(RegularExpressionValidator1, "TextBox1", "25 karakterden fazla veya özel karakterler girilemez", "\w{1,25}")
        revcontrol(RegularExpressionValidator2, "TextBox2", "25 karakterden fazla veya özel karakterler girilemez", "\w{1,25}")
        revcontrol(RegularExpressionValidator3, "TextBox3", "11 haneli tc kimlik numaranızı giriniz", "\d{11}")
        revcontrol(RegularExpressionValidator4, "TextBox4", "10 haneli okul numaranızı giriniz", "\d{10}")
        revcontrol(RegularExpressionValidator5, "TextBox6", "000.000.00.00 formatında telefon numarası giriniz", "^\d{3}\.\d{3}\.\d{2}\.\d{2}$")
        revcontrol(RegularExpressionValidator6, "TextBox7", "000.000.00.00 formatında telefon numarası giriniz", "^\d{3}\.\d{3}\.\d{2}\.\d{2}$")
        comcontrol(CompareValidator1, "TextBox6", "TextBox7", "telefon numaraları")
        revcontrol(RegularExpressionValidator7, "TextBox8", "Sadece harf kullanın", "^\D{1,50}")
        integercontrol(RangeValidator1, "TextBox9", 18, 35)
        datecontrol(RangeValidator2, "TextBox10", "31.12.1987", "31.12.2001")
        revcontrol(RegularExpressionValidator8, "TextBox11", "5 haneli değer giriniz. (Kadın/Erkek)", "\D{5}")
        revcontrol(RegularExpressionValidator9, "TextBox12", "ad.soyad@ogr.deu.edu.tr formatında mail adresinizi giriniz", "\D{1,25}\.\D{1,25}@ogr.deu.edu.tr")
        revcontrol(RegularExpressionValidator10, "TextBox13", "ad.soyad@ogr.deu.edu.tr formatında mail adresinizi giriniz", "\D{1,25}\.\D{1,25}@ogr.deu.edu.tr")
        comcontrol(CompareValidator2, "TextBox12", "TextBox13", "mail adresleri")
    End Sub
End Class
