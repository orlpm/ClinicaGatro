<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="EncuestaIngreso.aspx.vb" Inherits="ClinicaGastro.EncuestaIngreso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MenuContextual" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

            <asp:GridView ID="GridView1" runat="server" allowpaging="True" AutoGenerateColumns="False"  PageSize="15" CssClass="dgv" GridLines="Horizontal">
                <pagersettings mode="Numeric" 
          position="Bottom"           
          pagebuttoncount="20"/>
                <Columns>
              
                <asp:HyperlinkField datatextfield="No. Encuesta" datatextformatstring="{0:D}" DataNavigateUrlFields="No. Encuesta" DataNavigateUrlFormatString="~\Encuestas\ConsultaEncuesta.aspx?Encuesta={0}" HeaderText="No. Encuesta"/>
            
                    <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                </Columns>
                <HeaderStyle CssClass="headergdw"></HeaderStyle>
    <RowStyle CssClass="rows"></RowStyle>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:gastrodbtest1ConnectionString %>" SelectCommand="select distinct encuestaingresoID as 'No. Encuesta', Nombre from encuestaingreso"></asp:SqlDataSource>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContenidoEncuestas" runat="server">
</asp:Content>
