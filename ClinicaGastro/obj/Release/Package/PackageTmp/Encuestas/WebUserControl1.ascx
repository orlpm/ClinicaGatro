<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="WebUserControl1.ascx.vb" Inherits="ClinicaGastro.WebUserControl1" %>
<table style="width: 100%;" id="tablaenc2">
    <tr>
        <td>
            <asp:TextBox ID="txtsintoma" runat="server" Width="248px"></asp:TextBox>
            <asp:DropDownList ID="ddlsintoma" runat="server">
                <asp:ListItem>--Seleccionar--</asp:ListItem>
                <asp:ListItem>Siempre</asp:ListItem>
                <asp:ListItem>Ocasionalmente</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>&nbsp;</td>
    </tr>
    </table>
