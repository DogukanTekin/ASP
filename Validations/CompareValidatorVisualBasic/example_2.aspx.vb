
Partial Class example_2
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        'CV1 / Equal
        CompareValidator1.ControlToValidate = TextBox1.ClientID
        CompareValidator1.Text = "Girilen değer 500'e eşit değil"
        CompareValidator1.Operator = ValidationCompareOperator.Equal
        CompareValidator1.ValueToCompare = 500
        'CV2 / GreaterThen / Girilen değer 500'den küçükse validation çalışır
        CompareValidator2.ControlToValidate = TextBox2.ClientID
        CompareValidator2.Text = "Girilen değer 500'den büyük değil"
        CompareValidator2.Operator = ValidationCompareOperator.GreaterThan
        CompareValidator2.ValueToCompare = 500
        'CV3 / LessThen / Girilen değer 500'den büyükse validation çalışır
        CompareValidator3.ControlToValidate = TextBox3.ClientID
        CompareValidator3.Text = "Girilen değer 500'den küçük değil"
        CompareValidator3.Operator = ValidationCompareOperator.LessThan
        CompareValidator3.ValueToCompare = 500
    End Sub
End Class
