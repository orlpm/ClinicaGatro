Public Class Nutricional
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label7.Text = DateAndTime.Now
        If ConfigurationManager.AppSettings("nivelus") = 0 Or ConfigurationManager.AppSettings("nivelus") = 3 Then
            ocul.Visible = False
            ocul1.Visible = False
            Label1.Visible = False
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Label6.Visible = False
            TextBox1.Visible = True
            TextBox2.Visible = True
            TextBox4.Visible = True
            TextBox3.Visible = True
        Else
            ocul.Visible = True
            ocul1.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            Label6.Visible = True
            TextBox1.Visible = False
            TextBox2.Visible = False
            TextBox4.Visible = False
            TextBox3.Visible = False
        End If
    End Sub

End Class