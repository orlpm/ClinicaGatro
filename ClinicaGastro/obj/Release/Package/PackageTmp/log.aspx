<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="log.aspx.vb" Inherits="ClinicaGastro.log" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1
        {
        }
        .auto-style2
        {
            width: 141px;
            height: 23px;
        }
        .auto-style3
        {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MenuContextual" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    
     

      <div id="login" runat="server">  
        
    <h1>Log in</h1>
    <hr />
    <table style="width: 100%;" id="tabla3">
        <tr>
            <td class="auto-style1">Usuario</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="345px" CssClass="txtbox" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Contraseña</td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBox2" runat="server" Width="345px" CssClass="txtbox" TextMode="Password" DefaultButton="Button1" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" colspan="2">
                <asp:Button ID="Button1" runat="server" Text="Ingresar" Width="115px" />
            </td>
        </tr>
    </table>
        </div>
        
   
</asp:Content>


<asp:Content ID="Content4" ContentPlaceHolderID="ContenidoEncuestas" runat="server">
</asp:Content>
