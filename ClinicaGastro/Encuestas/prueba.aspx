<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Encuestas/Encuestas.master" CodeBehind="prueba.aspx.vb" Inherits="ClinicaGastro.prueba" EnableEventValidation="false"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    
    <div id="exporta" runat="server" >
        
    <asp:Image ID="Image1" runat="server" ImageUrl="http://www.developerji.com/App_Themes/Principal/Images/logo.png" />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        
                
            
        
        <br />
        
        <br />
    </div>
    <asp:Button ID="btnExportasPDF" runat="server" Text="Exportar Página a PDF"
            OnclientClick="btnExportasPDF_Click"/>
                <br />
</asp:Content>
