<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Pacientes/ControlPacientes.master" CodeBehind="ListaPacientes.aspx.vb" Inherits="ClinicaGastro.ListaPacientes" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContenidoPAcientes" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    
    <div>
        <table style="width: 100%;" id="tablaenc1">
            <tr>
                <td>
                    
                </td>
            </tr>
            </table>
        <asp:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" Width="1158px" Height="5351px" CssClass="Tab" >
            <asp:TabPanel runat="server" HeaderText="Pacientes" ID="TabPanel1">
                <ContentTemplate>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/NuevoPaciente.aspx">Nuevo Paciente</asp:HyperLink>
                    <label>|</label>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="txtbox" DefaultButton="Button1" ></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="Buscar" />
                 <asp:GridView ID="GridView1" runat="server" allowpaging="True" AutoGenerateColumns="False"  PageSize="15" HeaderStyle-CssClass="headergdw" CssClass="dgv" RowStyle-CssClass="rows" GridLines="Horizontal">
        
        <pagersettings mode="Numeric" 
          position="Bottom"           
          pagebuttoncount="20"/>
        <Columns>
            <asp:HyperlinkField datatextfield="Expediente" datatextformatstring="{0:D}" DataNavigateUrlFields="Expediente" DataNavigateUrlFormatString="\Pacientes\ExpCompleto.aspx?Expediente={0}" HeaderText="Expediente"/>
            
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" ReadOnly="True" SortExpression="Nombre" />
            <asp:BoundField DataField="Edad" HeaderText="Edad" ReadOnly="True" SortExpression="Edad" />
        </Columns>

    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:gastrodbtest1ConnectionString %>" SelectCommand="select pacienteid as 'Expediente', nombres+' '+appaterno+' '+apmaterno as 'Nombre', (cast(datediff(dd,nacimiento,GETDATE()) / 365.25 as int)) as 'Edad' from paciente order by pacienteID desc"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:gastrodbtest1ConnectionString %>" SelectCommand="select pacienteid as 'Expediente', nombres+' '+appaterno+' '+apmaterno as 'Nombre', (cast(datediff(dd,nacimiento,GETDATE()) / 365.25 as int)) as 'Edad' from paciente where nombres like '%'+@busca+'%' or appaterno like '%'+@busca+'%' or apmaterno like '%'+@busca+'%' order by pacienteID desc">
            <SelectParameters>
                <asp:ControlParameter ControlID="TextBox1" Name="busca" PropertyName="Text" />
            </SelectParameters>
        </asp:SqlDataSource>
        </ContentTemplate>
            </asp:TabPanel>
            <asp:TabPanel ID="TabPanel2" runat="server" HeaderText="Prepacientes">
            <ContentTemplate>
                <asp:GridView ID="GridView2" runat="server"  allowpaging="True" AutoGenerateColumns="False"  PageSize="15" CssClass="dgv" GridLines="Horizontal">
                    <Columns>
                          <asp:BoundField DataField="Noprepaciente" HeaderText="No. Prepaciente" ReadOnly="True" SortExpression="No.Prepaciente" />
        <asp:BoundField DataField="Nombre" HeaderText="Nombre" ReadOnly="True" SortExpression="Nombre" />
                        <asp:BoundField DataField="FechaIngreso" HeaderText="Fecha Ingreso" ReadOnly="True" SortExpression="FechaIngreso" />
      <asp:TemplateField>
            <ItemTemplate>
                <asp:HyperLink runat="server" ID="HyperLink1" NavigateUrl='<%# checkLink(Eval("Noprepaciente")) & "?prep=" & Eval("Noprepaciente")%>' Text="Enviar a Pacientes"></asp:HyperLink>
            </ItemTemplate>
        </asp:TemplateField>
                    </Columns>
                    <HeaderStyle CssClass="headergdw" />
                    <pagersettings           
          pagebuttoncount="20"/>

                    <RowStyle CssClass="rows" />

                </asp:GridView>
            </ContentTemplate>
            </asp:TabPanel>
           
        </asp:TabContainer>
        
    
        
</div>
           
</asp:Content>
        