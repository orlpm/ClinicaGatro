<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Encuestas/Encuestas.master" CodeBehind="encuesta1.aspx.vb" Inherits="ClinicaGastro.encuesta1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
   
    <h1>Encuesta de Ingreso a la Clínica</h1>
    <h2>Con el objetivo de brindarle un servicio de calidad es necesario contar con datos generales bajo la confidencialidad y confianza de nuestros pacientes, ya que somos una institución seria y comprometida con nuestro servicio.</h2>
     <hr />
    <br />
    <br />
    <div id="tabla1">
    <table style="width:100%;" id="tablaenc1">
        
        <tr>
            
            <td style="width: 159px">Nombre</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="359px" CssClass="txtbox" ></asp:TextBox><asp:RequiredFieldValidator 
                            ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="TextBox1"
                            ErrorMessage="Campo Requerido" 
                            ValidationGroup="Validate">
        </asp:RequiredFieldValidator>
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 159px">Edad</td>
            <td>
               
                <asp:TextBox ID="TextBox2" runat="server" Width="357px" CssClass="txtbox"></asp:TextBox><asp:RequiredFieldValidator 
                            ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="TextBox2"
                            ErrorMessage="Campo Requerido" 
                            ValidationGroup="Validate">
        </asp:RequiredFieldValidator>

            </td>
        </tr>
        <tr>
            <td style="width: 159px">Email</td>
            <td style="font-weight: 700">
                <asp:TextBox ID="TextBox3" runat="server" Width="359px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 159px">Dirección</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" Width="359px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 159px">Delegación</td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server" Width="359px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 159px">CP</td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server" Width="359px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 159px">Teléfono</td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server" Width="359px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 159px">Familiar Responsable</td>
            <td>
                <asp:TextBox ID="TextBox8" runat="server" Width="359px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 159px">Ocupación</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" Height="19px" Width="364px" CssClass="cmbox">
                    <asp:ListItem>Empleado de Tiempo Completo</asp:ListItem>
                    <asp:ListItem>Empleado de Medio Tiempo</asp:ListItem>
                    <asp:ListItem>Independiente</asp:ListItem>
                    <asp:ListItem>Ama de Casa</asp:ListItem>
                    <asp:ListItem>Jubilado</asp:ListItem>
                    <asp:ListItem>Estudiante</asp:ListItem>
                    <asp:ListItem>Desempleado</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 159px">¿Cómo se enteró de la Clínica?</td>
            <td>
                <asp:DropDownList ID="DropDownList2"  runat="server" Height="19px" Width="364px" CssClass="cmbox" onchange="getvalue();">
                    
                    <asp:ListItem>Volantes / Anuncios</asp:ListItem>
                    <asp:ListItem>Feria / Campaña de Salud</asp:ListItem>
                    <asp:ListItem>Mi institución tiene convenio</asp:ListItem>
                    <asp:ListItem>Facebook</asp:ListItem>
                    <asp:ListItem>Búsqueda en Google</asp:ListItem>
                    <asp:ListItem>Anuncio en Google</asp:ListItem>
                    <asp:ListItem>Recomendación</asp:ListItem>
                    <asp:ListItem>Otro</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 159px" id="lblotro" runat="server" >Otro</td>
            <td>
                <asp:TextBox ID="TextBox9" runat="server" Width="359px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 159px" id="lblinstitucion" runat="server" >¿Cuál es su institución?</td>
            <td>
                <asp:TextBox ID="TextBox10" runat="server" Width="359px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            
                <td style="width: 159px" id="lblrecomienda" runat="server" >¿Quién lo recomienda?</td>
            <td>
                <asp:TextBox ID="TextBox11" runat="server" Width="359px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 20px">
                ¿Cuándo se enteró de la Clínica?</td>
            <td style="height: 20px">
                <asp:DropDownList ID="DropDownList3" runat="server" Height="19px" Width="364px" CssClass="cmbox">
                    <asp:ListItem>Hace unos días</asp:ListItem>
                    <asp:ListItem>Esta Semana</asp:ListItem>
                    <asp:ListItem>La semana pasada</asp:ListItem>
                    <asp:ListItem>Hace más de dos semanas</asp:ListItem>
                    <asp:ListItem>Hace más de un mes</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="Button1" runat="server" Text="Terminar" Width="118px" ValidationGroup="Validate"/>
            </td>
        </tr>
    </table>
   </div>
    
    <script src="Scripts/jquery-3.2.0.js"></script>
<script>
    
    document.getElementById('<%=lblotro.ClientID()%>').style.display = 'none';
    document.getElementById('<%=TextBox9.ClientID()%>').style.display = 'none';
    document.getElementById('<%=lblinstitucion.ClientID()%>').style.display = 'none';
    document.getElementById('<%=TextBox10.ClientID()%>').style.display = 'none';
    document.getElementById('<%=lblrecomienda.ClientID()%>').style.display = 'none';
    document.getElementById('<%=TextBox11.ClientID()%>').style.display = 'none';
    function getvalue() {
        var texto = document.getElementById('<%=DropDownList2.ClientID()%>').value;
        

        if (texto == 'Otro') {
            document.getElementById('<%=lblotro.ClientID()%>').style.display = 'block';
            document.getElementById('<%=TextBox9.ClientID()%>').style.display = 'block';
            document.getElementById('<%=lblinstitucion.ClientID()%>').style.display = 'none';
            document.getElementById('<%=TextBox10.ClientID()%>').style.display = 'none';
            document.getElementById('<%=lblrecomienda.ClientID()%>').style.display = 'none';
            document.getElementById('<%=TextBox11.ClientID()%>').style.display = 'none';
        }
        else if (texto == 'Mi institución tiene convenio') {
            
            document.getElementById('<%=lblinstitucion.ClientID()%>').style.display = 'block';
            document.getElementById('<%=TextBox10.ClientID()%>').style.display = 'block';
            document.getElementById('<%=lblotro.ClientID()%>').style.display = 'none';
            document.getElementById('<%=TextBox9.ClientID()%>').style.display = 'none';
            document.getElementById('<%=lblrecomienda.ClientID()%>').style.display = 'none';
            document.getElementById('<%=TextBox11.ClientID()%>').style.display = 'none';
        }
        else if (texto == 'Recomendación') {
            document.getElementById('<%=lblrecomienda.ClientID()%>').style.display = 'block';
            document.getElementById('<%=TextBox11.ClientID()%>').style.display = 'block';
            document.getElementById('<%=lblinstitucion.ClientID()%>').style.display = 'none';
            document.getElementById('<%=TextBox10.ClientID()%>').style.display = 'none';
            document.getElementById('<%=lblotro.ClientID()%>').style.display = 'none';
            document.getElementById('<%=TextBox9.ClientID()%>').style.display = 'none';
            
        }
        else {
            document.getElementById('<%=lblinstitucion.ClientID()%>').style.display = 'none';
            document.getElementById('<%=TextBox10.ClientID()%>').style.display = 'none';
            document.getElementById('<%=lblotro.ClientID()%>').style.display = 'none';
            document.getElementById('<%=TextBox9.ClientID()%>').style.display = 'none';
            document.getElementById('<%=lblrecomienda.ClientID()%>').style.display = 'none';
            document.getElementById('<%=TextBox11.ClientID()%>').style.display = 'none';
        }
    }


    
    </script> 
    <script>
        $(document).ready(function(){
            $("#<%=TextBox2.ClientID()%>").keypress(function (event) {
                if (event.charCode >= 48 && event.charCode <= 57) {
                    return true;
                }
                else
                {
                    return false;
                }
            });
        });

    </script>
</asp:Content>
