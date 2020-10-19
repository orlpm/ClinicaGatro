<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Administrativo/Afiliaciones.master" CodeBehind="Nuevaafil.aspx.vb" Inherits="ClinicaGastro.Nuevaafil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContenidoAfiliacion" runat="server">
    <h1>Nueva Afiliación</h1>
    <hr />
    <table style="width: 100%;" id="tablaenc2">
        <tr>
            <td style="width: 135px">Nombre Afiliado</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="484px" CssClass="txtbox" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 135px">Dirección Afiliado</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Width="484px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 135px">Fecha Afiliación</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" Width="212px" TextMode="Date" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 135px">Empresa</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" Width="484px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 135px">Afiliado 1</td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server" Width="484px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 135px">Afiliado 2</td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server" Width="484px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="Button1" runat="server" Text="Agregar" Width="227px"  />
            </td>
        </tr>
    </table>
</asp:Content>
