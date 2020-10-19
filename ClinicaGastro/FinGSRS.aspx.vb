Public Class FinGSRS
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim nombre, appat, apmat, fecha As String
        nombre = Request.Params("nombre")
        appat = Request.Params("appat")
        apmat = Request.Params("apmat")
        fecha = Request.Params("fecnac")
        Label1.Text = UCase(nombre.Substring(0, 3) & appat.Substring(0, 3) & apmat.Substring(0, 3))
        Label2.Text = fecha
    End Sub

End Class