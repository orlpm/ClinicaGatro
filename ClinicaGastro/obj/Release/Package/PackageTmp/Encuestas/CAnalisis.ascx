<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="CAnalisis.ascx.vb" Inherits="ClinicaGastro.CAnalisis" %>


<table style="width: 100%;">
    <tr>
        <td colspan="8">
            Topográfico</td>
    </tr>
    <tr>
        <td>
            Región</td>
        <td colspan="2">
            Inicia</td>
        <td>
            Irradiación</td>
        <td>
            Migración</td>
        <td colspan="2">
            Expansión</td>
        <td>
            Proyección</td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="TxtRegion" runat="server"></asp:TextBox>
        </td>
        <td colspan="2">
            <asp:TextBox ID="TxtIni" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="TxtIrradiacion" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="TxtMigracion" runat="server"></asp:TextBox>
        </td>
        <td colspan="2">
            <asp:TextBox ID="TxtExpansion" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="TxtProyeccion" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="4">
            Cualitativos</td>
        <td colspan="4">
            Cuantitativos</td>
    </tr>
    <tr>
        <td>
            Semejanza</td>
        <td colspan="3">
            Localización</td>
        <td>
            Intensidad Inicial</td>
        <td colspan="2">
            Máxima Intensidad</td>
        <td>
            Intensidad de Último Evento</td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="TxtSemejanza" runat="server"></asp:TextBox>
        </td>
        <td colspan="3">
            <asp:DropDownList ID="DdlLocalizacion" runat="server">
                <asp:ListItem>--Seleccionar--</asp:ListItem>
                <asp:ListItem>Localizado</asp:ListItem>
                <asp:ListItem>Difuso</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            <asp:TextBox ID="TxtIntIni" runat="server"></asp:TextBox>
        </td>
        <td colspan="2">
            <asp:TextBox ID="TxtMaxInt" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="TxtIntUlt" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="8">
            Cronológicos</td>
    </tr>
    <tr>
        <td>
            Inicio</td>
        <td colspan="2">
            Patrón</td>
        <td>
            Duración</td>
        <td>
            Frecuencia / día</td>
        <td colspan="2">
            Frecuencia sem/mens</td>
        <td>
            Último Evento</td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="TxtIniCro" runat="server"></asp:TextBox>
        </td>
        <td colspan="2">
            <asp:DropDownList ID="DdlPatron" runat="server">
                <asp:ListItem>--Seleccionar--</asp:ListItem>
                <asp:ListItem>Intermitente</asp:ListItem>
                <asp:ListItem>Continuo</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            <asp:TextBox ID="TxtDuracion" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="TxtFrecDia" runat="server"></asp:TextBox>
        </td>
        <td colspan="2">
            <asp:TextBox ID="TxtFrecMens" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="TxtUltEventoFr" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Patrón de día</td>
        <td colspan="2">
            Patrón de Ayuno</td>
        <td>
            Patron Evacuaciones</td>
        <td>
            &nbsp;</td>
        <td colspan="2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:DropDownList ID="DdlPatronDia" runat="server">
                <asp:ListItem>--Seleccionar--</asp:ListItem>
                <asp:ListItem>Predominio mañana</asp:ListItem>
                <asp:ListItem>Predominio tarde</asp:ListItem>
                <asp:ListItem>Predominio noche</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td colspan="2">
            <asp:DropDownList ID="DdlPatronAyuno" runat="server">
                <asp:ListItem>--Seleccionar--</asp:ListItem>
                <asp:ListItem>Antes de Comer</asp:ListItem>
                <asp:ListItem>Durante la comida</asp:ListItem>
                <asp:ListItem>Después de Comer</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            <asp:DropDownList ID="DdlPatronEvac" runat="server">
                <asp:ListItem>--Seleccionar--</asp:ListItem>
                <asp:ListItem>Ántes de Evacuar</asp:ListItem>
                <asp:ListItem>Durante la evacuación</asp:ListItem>
                <asp:ListItem>Después de Evacuar</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            &nbsp;</td>
        <td colspan="2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td colspan="8">
            Eventos Fisiológicos Asociados</td>
    </tr>
    <tr>
        <td colspan="3">
            Patrón Evacuaciones</td>
        <td colspan="2">
            Patrón Gases</td>
        <td colspan="3">
            Patrón Vómito</td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:TextBox ID="TxtPatronEvac" runat="server"></asp:TextBox>
        </td>
        <td colspan="2">
            <asp:TextBox ID="TxtPatronGases" runat="server"></asp:TextBox>
        </td>
        <td colspan="3">
            <asp:TextBox ID="TxtPatronVomito" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="8">
            Modificadores</td>
    </tr>
    <tr>
        <td colspan="3">
            ¿Qué aumenta su intensidad?</td>
        <td colspan="2">
            ¿Qué disminuye su intensidad?</td>
        <td colspan="3">
            Alimentos que lo provocan o aumentan</td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:TextBox ID="TxtAumentaInt" runat="server" Height="69px" TextMode="MultiLine" Width="240px"></asp:TextBox>
        </td>
        <td colspan="2">
            <asp:TextBox ID="TxtDismInt" runat="server" Height="69px" style="margin-top: 0px" TextMode="MultiLine" Width="240px"></asp:TextBox>
        </td>
        <td colspan="3">
            <asp:TextBox ID="TxtAlimProvocan" runat="server" Height="69px" TextMode="MultiLine" Width="240px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="3">
            Alimentos que lo disminuyen</td>
        <td colspan="2">
            Las evacuaciones lo aumentan o lo disminuyen</td>
        <td colspan="3">
            Canalización de gases lo aumentan o disminuyen</td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:TextBox ID="TxtAlimDism" runat="server" Height="69px" TextMode="MultiLine" Width="240px"></asp:TextBox>
        </td>
        <td colspan="2">
            <asp:DropDownList ID="DdlEvac" runat="server">
                <asp:ListItem>--Seleccionar--</asp:ListItem>
                <asp:ListItem>Aumentan</asp:ListItem>
                <asp:ListItem>Disminuyen</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td colspan="3">
            <asp:DropDownList ID="DdlGases" runat="server">
                <asp:ListItem>--Seleccionar--</asp:ListItem>
                <asp:ListItem>Aumentan</asp:ListItem>
                <asp:ListItem>Disminuyen</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td colspan="3">
            Eructos lo aumentan o disminuyen</td>
        <td colspan="2">
            Medicamentos que lo calman</td>
        <td colspan="3">
            Medicamentos que NO lo controlan</td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:DropDownList ID="DdlEructos" runat="server">
                <asp:ListItem>--Seleccionar--</asp:ListItem>
                <asp:ListItem>Aumentan</asp:ListItem>
                <asp:ListItem>Disminuyen</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td colspan="2">
            <asp:TextBox ID="TxtMedicamCalman" runat="server" Height="69px" TextMode="MultiLine" Width="240px"></asp:TextBox>
        </td>
        <td colspan="3">
            <asp:TextBox ID="TxtMednoCalm" runat="server" Height="69px" TextMode="MultiLine" Width="240px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="8">
            Se acompaña ocasionalmente de los siguientes síntomas</td>
    </tr>
    <tr style="margin-left: 40px">
        <td colspan="2">
            <asp:TextBox ID="TxtSintOA" runat="server"></asp:TextBox>
        </td>
        <td colspan="2">
            <asp:TextBox ID="TxtSintOB" runat="server"></asp:TextBox>
        </td>
        <td colspan="2">
            <asp:TextBox ID="TxtSintOC" runat="server"></asp:TextBox>
        </td>
        <td colspan="2">
            <asp:TextBox ID="TxtSintOD" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr style="margin-left: 40px">
        <td colspan="8">
            Se acompaña SIEMPRE de los siguientes síntomas</td>
    </tr>
    <tr style="margin-left: 40px">
        <td colspan="2">
            <asp:TextBox ID="TxtSintSA" runat="server"></asp:TextBox>
        </td>
        <td colspan="2">
            <asp:TextBox ID="TxtSintSB" runat="server"></asp:TextBox>
        </td>
        <td colspan="2">
            <asp:TextBox ID="TxtSintSC" runat="server"></asp:TextBox>
        </td>
        <td colspan="2">
            <asp:TextBox ID="TxtSintSD" runat="server"></asp:TextBox>
        </td>
    </tr>
    </table>
