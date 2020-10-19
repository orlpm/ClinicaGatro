<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Medicos/Medicos.master" CodeBehind="AltaMedicos.aspx.vb" Inherits="ClinicaGastro.AltaMedicos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    
    <h1>Alta de Médicos</h1>
    <hr />
    <br />
    <div id="tablanumed">
    <table style="width: 100%;" id="tabla3">
        <tr>
            <td style="width: 176px">Nombre(s)</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="452px" CssClass="txtbox" ></asp:TextBox><asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator1" ControlToValidate="TextBox1" ErrorMessage="Dato requerido" ForeColor="Red" ValidationGroup="Valida" ></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 176px">Apellido Paterno</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Width="452px" CssClass="txtbox" ></asp:TextBox><asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator2" ControlToValidate="TextBox2" ErrorMessage="Dato requerido" ForeColor="Red" ValidationGroup="Valida" ></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 176px">Apellido Materno</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" Width="452px" CssClass="txtbox" ></asp:TextBox><asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator3" ControlToValidate="TextBox3" ErrorMessage="Dato requerido" ForeColor="Red" ValidationGroup="Valida" ></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 176px">Cédula</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" Width="452px" CssClass="txtbox" ></asp:TextBox><asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator4" ControlToValidate="TextBox4" ErrorMessage="Dato requerido" ForeColor="Red" ValidationGroup="Valida" ></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 176px">Especialidad</td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server" Width="452px" CssClass="txtbox" ></asp:TextBox><asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator5" ControlToValidate="TextBox5" ErrorMessage="Dato requerido" ForeColor="Red" ValidationGroup="Valida"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 176px">Teléfono</td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server" Width="452px" CssClass="txtbox" ></asp:TextBox><asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator6" ControlToValidate="TextBox6" ErrorMessage="Dato requerido" ForeColor="Red" ValidationGroup="Valida"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 176px">Nivel</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="213px" CssClass="cmbox" >
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>Administrador</asp:ListItem>
                    <asp:ListItem>Medico</asp:ListItem>
                    <asp:ListItem>Administrativo</asp:ListItem>
                </asp:DropDownList><asp:RequiredFieldValidator id="lista1" ControlToValidate="DropDownList1"  display="Static" InitialValue="--Seleccionar--" ErrorMessage="Seleccione Nivel" ValidationGroup="Valida" runat="server" SetFocusOnError="true"  ></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 176px">E-mail</td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server" Width="452px" CssClass="txtbox" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 176px">Contraseña</td>
            <td>
                <asp:TextBox ID="TextBox8" runat="server" Width="452px" TextMode="Password" CssClass="txtbox" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" id="valida" ControlToValidate="TextBox8" ErrorMessage="La contraseña no puede estar en blanco" ForeColor="Red" ValidationGroup="Valida"></asp:RequiredFieldValidator>
            </td> 
        </tr>
        <tr>
            <td>Confirmar Contraseña</td>
            <td>
                <asp:TextBox ID="TextBox9" runat="server" Width="452px" TextMode="Password"  CssClass="txtbox" ></asp:TextBox>
                <asp:CompareValidator id="comparar" runat="server"
                    Forecolor="Red" 
                     ControlToValidate="TextBox8"
                     ControlToCompare="TextBox9"
                    type="String" 
                     ErrorMessage="Las contraseñas no coinciden"
                    ValidationGroup="Valida"
                    ></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="Button1" runat="server" Text="Alta" Width="140px" ValidationGroup="Valida"/>
            </td>
        </tr>
    </table>
    </div>
    <script src="Scripts/jquery-3.2.0.js">

    </script>
    

</asp:Content>
