Public Class cPasajeros
    Inherits System.Web.UI.UserControl
    Partial Public Class cPasajeros
        Inherits System.Web.UI.UserControl
        Protected Sub Page_Load(sender As Object, e As EventArgs)

        End Sub

        'Public Sub AsignarID(num As Integer)
        '    tbNombrePas.ID = "tbNombrePas" + num
        '    tbApellidosPas.ID = "tbApellidosPas" + num
        '    tbNumeroDocPas.ID = "tbNumeroDocPas" + num
        '    tbTelefonoPas.ID = "tbTelefonoPas" + num
        '    ddlDocumentoPas.ID = "ddlDocumentoPas" + num
        '    ddlTipoPas.ID = "ddlTipoPas" + num

        'End Sub
    End Class

    Function AsignarID(i As Integer) As Integer
            tbNombrePas.ID = "tbNombrePas" & i
            tbApellidosPas.ID = "tbApellidosPas" & i
            tbNumeroDocPas.ID = "tbNumeroDocPas" & i
            tbTelefonoPas.ID = "tbTelefonoPas" & i
            ddlDocumentoPas.ID = "ddlDocumentoPas" & i
            ddlTipoPas.ID = "ddlTipoPas" & i
        Return i
    End Function
End Class