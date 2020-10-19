Public Class CAnalisis
    Inherits System.Web.UI.UserControl
    Function AsignarID(i As Integer) As Integer
        TxtRegion.ID = "TxtRegion" & i
        TxtAlimDism.ID = "TxtAlimDism" & i
        TxtAlimProvocan.ID = "TxtAlimProvocan" & i
        TxtAumentaInt.ID = "TxtAumentaInt" & i
        TxtDismInt.ID = "TxtDismInt" & i
        TxtDuracion.ID = "TxtDuracion" & i
        TxtExpansion.ID = "TxtExpansion" & i
        TxtFrecDia.ID = "TxtFrecDia" & i
        TxtFrecMens.ID = "TxtFrecMens" & i
        TxtIni.ID = "TxtIni" & i
        TxtIniCro.ID = "TxtIniCro" & i
        TxtIntIni.ID = "TxtIntIni" & i
        TxtIntUlt.ID = "TxtIntUlt" & i
        TxtIrradiacion.ID = "TxtIrradiacion" & i
        TxtMaxInt.ID = "TxtMaxInt" & i
        TxtMedicamCalman.ID = "TxtMedicamCalman" & i
        TxtMednoCalm.ID = "TxtMednoCalm" & i
        TxtMigracion.ID = "TxtMigracion" & i
        TxtPatronEvac.ID = "TxtPatronEvac" & i
        TxtPatronGases.ID = "TxtPatronGases" & i
        TxtPatronVomito.ID = "TxtPatronVomito" & i
        TxtProyeccion.ID = "TxtProyeccion" & i
        TxtSemejanza.ID = "TxtSemejanza" & i
        TxtSintOA.ID = "TxtSintOA" & i
        TxtSintOB.ID = "TxtSintOB" & i
        TxtSintOC.ID = "TxtSintOC" & i
        TxtSintOD.ID = "TxtSintOD" & i
        TxtSintSA.ID = "TxtSintSA" & i
        TxtSintSB.ID = "TxtSintSB" & i
        TxtSintSC.ID = "TxtSintSC" & i
        TxtSintSD.ID = "TxtSintSD" & i
        TxtUltEventoFr.ID = "TxtUltEventoFr" & i
        DdlEructos.ID = "DdlEructos" & i
        DdlEvac.ID = "DdlEvac" & i
        DdlGases.ID = "DdlGases" & i
        DdlLocalizacion.ID = "DdlLocalizacion" & i
        DdlPatron.ID = "DdlPatron" & i
        DdlPatronAyuno.ID = "DdlPatronAyuno" & i
        DdlPatronDia.ID = "DdlPatronDia" & i
        DdlPatronEvac.ID = "DdlPatronEvac" & i
        Return i
    End Function


End Class