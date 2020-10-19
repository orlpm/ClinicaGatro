<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Encuestas/Encuestas.master" CodeBehind="ConsultaEncuesta.aspx.vb" Inherits="ClinicaGastro.ConsultaEncuesta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
        <h1>Encuesta de Ingreso a la Clínica</h1>
         <hr />
    <br />
    <br />
    <div id="tabla1">
    <table style="width:100%;" id="tablaenc1">
        
        <tr>
            
            <td style="width: 159px">Nombre</td>
            <td>
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 159px">Edad</td>
            <td>
               
                <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                </td>
        </tr>
        <tr>
            <td style="width: 159px">Email</td>
            <td >
                <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                </td>
        </tr>
        <tr>
            <td style="width: 159px">Dirección</td>
            <td>
                <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
                </td>
        </tr>
        <tr>
            <td style="width: 159px">Delegación</td>
            <td>
                <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
                </td>
        </tr>
        <tr>
            <td style="width: 159px">CP</td>
            <td>
                <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
                </td>
        </tr>
        <tr>
            <td style="width: 159px">Teléfono</td>
            <td>
                <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
                </td>
        </tr>
        <tr>
            <td style="width: 159px">Familiar Responsable</td>
            <td>
                <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
                </td>
        </tr>
        <tr>
            <td style="width: 159px">Ocupación</td>
            <td>
                <asp:Label ID="Label9" runat="server" Text=""></asp:Label>
                </td>
        </tr>
        <tr>
            <td style="width: 159px">¿Cómo se enteró de la Clínica?</td>
            <td>
                <asp:Label ID="Label10" runat="server" Text=""></asp:Label>
                </td>
        </tr>
        <tr>
            <td style="width: 159px" id="lblotro" runat="server" >Otro</td>
            <td>
                <asp:Label ID="Label11" runat="server" Text=""></asp:Label>
                </td>
        </tr>
        <tr>
            <td style="width: 159px" id="lblinstitucion" runat="server" >¿Cuál es su institución?</td>
            <td>
                <asp:Label ID="Label12" runat="server" Text=""></asp:Label>
                </td>
        </tr>
        <tr>
            
                <td style="width: 159px" id="lblrecomienda" runat="server" >¿Quién lo recomienda?</td>
            <td>
                <asp:Label ID="Label13" runat="server" Text=""></asp:Label>
                </td>
        </tr>
        <tr>
            <td style="height: 20px">
                ¿Cuándo se enteró de la Clínica?</td>
            <td style="height: 20px">
                <asp:Label ID="Label14" runat="server" Text=""></asp:Label>
                </td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;</td>
        </tr>
    </table>
   </div>

</asp:Content>
