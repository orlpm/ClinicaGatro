<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Encuestas/Encuestas.master" CodeBehind="ModificaDiagnostico.aspx.vb" Inherits="ClinicaGastro.ModificaDiagnostico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
<asp:UpdatePanel runat="server"><contenttemplate> 
<h1>Modificar Diagnóstico</h1>
    <hr />
    <table style="width:100%;" id="tablaenc1"><tr><td style="width: 158px" class="textgral">Fecha de Modificación</td><td>
        <asp:Label ID="Label1" runat="server" ></asp:Label>
        </td></tr><tr><td style="width: 158px" class="textgral">Nombre Completo</td><td>
        <asp:Label ID="Label2" runat="server" ></asp:Label>
            </td></tr><tr><td style="width: 158px" class="textgral">Diagnóstico</td><td>
        <asp:Label ID="Label3" runat="server" ></asp:Label>
            </td></tr><tr><td style="width: 158px" class="textgral">Estado Diagnóstico</td><td>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>--Seleccionar--</asp:ListItem>
                <asp:ListItem>TRATAMIENTO</asp:ListItem>
                <asp:ListItem>EMPEORÓ</asp:ListItem>
                <asp:ListItem>MEJORÓ</asp:ListItem>
                <asp:ListItem>ALTA</asp:ListItem>
            </asp:DropDownList>
            </td></tr><tr><td style="width: 158px" class="textgral">Expediente</td><td>
        <asp:Label ID="Label5" runat="server" ></asp:Label>
            </td></tr><tr><td style="width: 158px" class="textgral">Área</td><td>
        <asp:Label ID="Label6" runat="server" ></asp:Label>
            </td></tr></table>
    <br />
    <asp:Button runat="server" Text="Guardar" id="Button1"></asp:Button>
    <br />
    </contenttemplate> 
            </asp:UpdatePanel>
</asp:Content>
