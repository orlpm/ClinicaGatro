<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Encuestas/Encuestas.master" CodeBehind="Eliminar.aspx.vb" Inherits="ClinicaGastro.Eliminar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
<h1>Borrar Nota</h1>
    <hr />
    <h2>¿Seguro de eliminar esta nota?</h2>
    <table style="width:100%;" id="tablaenc1"><tr><td style="width: 180px" class="textgral">Fecha de Modificación</td><td>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </td></tr><tr><td style="width: 180px" class="textgral">Nombre Completo</td><td>
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            </td></tr><tr><td style="width: 180px" class="textgral">Expediente</td><td>
        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
            </td></tr><tr><td style="width: 180px" class="textgral">Área</td><td>
        <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
            </td></tr></table>
    <br />
    <asp:Button runat="server" Text="Eliminar" id="button1"></asp:Button>
    <br />
</asp:Content>
