Public Class WebUserControl1
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Public Sub asignarID(num As Integer)
        txtsintoma.ID = "txtsintoma" & num
        ddlsintoma.ID = "ddlsintoma" & num
    End Sub
   
End Class