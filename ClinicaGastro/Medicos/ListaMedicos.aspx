<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Medicos/Medicos.master" CodeBehind="ListaMedicos.aspx.vb" Inherits="ClinicaGastro.ListaMedicos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
   <br />
    <div id="tablaenc1" runat="server">
    <asp:Menu Orientation="Horizontal" ID="menu2" runat="server" CssClass="lastchild">
                 <Items>
            <asp:MenuItem Text="Nuevo Médico" Value="Nuevo Médico" NavigateUrl="~/Medicos/AltaMedicos.aspx"></asp:MenuItem>
        </Items>
            </asp:Menu>
        </div> 
    <br />
    <div id="dgv" runat="server">
    <asp:GridView ID="GridView1" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" HeaderStyle-CssClass="headergdw" CssClass="dgv" RowStyle-CssClass="rows" runat="server" GridLines="none">
              
        <Columns>
            <asp:CheckBoxField DataField="Activo" HeaderText="Activo"/>
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" ReadOnly="True" SortExpression="Nombre"/>
            <asp:BoundField DataField="Cédula" HeaderText="Cédula" SortExpression="Cédula"/>
            <asp:BoundField DataField="Especialidad" HeaderText="Especialidad" SortExpression="Especialidad"/>
            <asp:BoundField DataField="Contacto" HeaderText="Contacto" SortExpression="Contacto"/>
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email"/>
            
        </Columns>
        
    </asp:GridView>
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:gastrodbtest1ConnectionString %>" SelectCommand="SELECT nombre + ' ' + appaterno + ' ' + apmaterno AS 'Nombre', cedula AS 'Cédula', ocupacion AS 'Especialidad', telefono AS 'Contacto', email AS 'Email', activo as 'Activo' FROM usuarios where activo='1' and nivel<>'4'"></asp:SqlDataSource>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Guardar Cambios" Width="142px" />
    <br />
    <br />
</asp:Content>
