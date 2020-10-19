<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="FinGSRS.aspx.vb" Inherits="ClinicaGastro.FinGSRS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MenuContextual" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contenidoPrincipal" runat="server">
<h1>Gracias por contestar el GSRS</h1>
    <h2>Lee por favor las instrucciones</h2>
    <hr />
    <h3>Tu usuario en el expediente clínico ha sido registrado este servirá para proximas visitas</h3>
    <h3>Usuario: <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></h3>
    
    <h3>Tu password: <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></h3>
    <hr />
    <br />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContenidoEncuestas" runat="server">
</asp:Content>
