<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="NuevoPaciente.aspx.vb" Inherits="ClinicaGastro.NuevoPaciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2
        {
            font-weight: bolder;
            width: 165px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MenuContextual" runat="server">
    <h2>Nuevo Paciente</h2>
    <hr />
    <table style="width:100%;" id="tablaenc2">
        <tr>
            <td class="auto-style2"  >Nombre(s)</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"  Width="269px" CssClass="txtbox" ></asp:TextBox>
                <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Apellido Paterno</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"  Width="269px" CssClass="txtbox" ></asp:TextBox>
                <asp:Label ID="Label2" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Apellido Materno</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"  Width="269px" CssClass="txtbox" ></asp:TextBox>
                <asp:Label ID="Label3" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Fecha de Nacimiento<br />
                (dd/mm/aaaa)</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"  Width="269px" TextMode="Date" CssClass="txtbox"  ></asp:TextBox>
                <asp:Label ID="Label4" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Genero</td>
            <td>
                <asp:Label ID="Label5" runat="server" Visible="False"></asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="cmbox" CausesValidation="true">
                    <asp:ListItem Value="--Select--"></asp:ListItem>
                    <asp:ListItem Value="Hombre"></asp:ListItem>
                    <asp:ListItem Value="Mujer"></asp:ListItem>
                </asp:DropDownList><asp:RequiredFieldValidator id="lista1" ControlToValidate="DropDownList1"  display="Static" InitialValue="--Seleccionar--" ErrorMessage="Seleccione Genero" ValidationGroup="Valida" runat="server" SetFocusOnError="true"  ></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Correo Electrónico</td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server"  Width="269px" TextMode="Email" CssClass="txtbox"  >@</asp:TextBox>
                <asp:Label ID="Label6" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="Button1" runat="server" Text="Crear" Width="150px" ValidationGroup="Valida" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Pacientes/ListaPacientes.aspx">Regresar</asp:HyperLink>
            </td>
        </tr>
    </table>
    

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contenidoPrincipal" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContenidoEncuestas" runat="server">
</asp:Content>
