Public Class Recalimentos
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Function AsignarID(i As Integer) As Integer
        ddlTiempCom.ID = "ddlTiempCom" & i
        tbLugar.ID = "tbLugar" & i
        tbHr.ID = "tbHr" & i
        tbAlim.ID = "tbAlim" & i
        tbVCal.ID = "tbVCal" & i

        Return i
    End Function


End Class