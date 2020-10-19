<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Encuestas/Encuestas.master" CodeBehind="GSRS.aspx.vb" Inherits="ClinicaGastro.GSRS" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp"%>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <h1>GSRS</h1>
    <h2>Datos Personales</h2>
    <hr />
    <br />
    <table style="width:105%;" id="tabla2">
        <tr>
            <td style="width: 111px">Nombre</td>
            <td style="width: 261px">
                <asp:TextBox ID="TextBox1" runat="server" Width="249px" CssClass="txtbox" ></asp:TextBox>
            </td>
            <td style="width: 155px">Apellido Paterno</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" Width="247px" CssClass="txtbox" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 111px">Apellido Materno</td>
            <td style="width: 261px">
                <asp:TextBox ID="TextBox2" runat="server" Width="247px" CssClass="txtbox" ></asp:TextBox>
            </td>
            <td style="width: 155px">Fecha de Nacimiento<br />
                dd/mm/aaaa</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" CssClass="txtbox" Width="247px" TextMode="Date" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 111px">Genero</td>
            <td style="width: 261px">
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="cmbox"  CausesValidation="true">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>Hombre</asp:ListItem>
                    <asp:ListItem>Mujer</asp:ListItem>
                </asp:DropDownList><asp:RequiredFieldValidator id="lista1" ControlToValidate="DropDownList1"  display="Static" InitialValue="--Seleccionar--" ErrorMessage="Seleccione Genero" ValidationGroup="Valida" runat="server" SetFocusOnError="true"  ></asp:RequiredFieldValidator>
            </td>
            <td style="width: 155px">Correo Electrónico</td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server" CssClass="txtbox" Width="247px" TextMode="Email" >@</asp:TextBox>
            </td>
        </tr>
    </table>
    
    <h2>Cuestionario</h2>
<hr />
    <table style="width:100%;" id="tabla3">
        <tr>
            <td ><span style="color: rgb(51, 51, 51); font-family: Helvetica Neue, Helvetica, Arial sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: bold; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">1. ¿Ha sentido molestia por reflujo ácido en la última semana?</span></td>
            <td><span style="color: rgb(51, 51, 51); font-family: Helvetica Neue, Helvetica, Arial sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: bold; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">2. ¿Ha sentido molestia por pirosis en la última semana?</span></td>
        </tr>
        <tr>
            <td><span style="color: rgb(51, 51, 51); font-family: Helvetica, Arial, sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 100; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Reflujo ácido significa regurgitación o flujo de líquido amargo o agrio hacia la boca.</span></td>
           <td><span style="color: rgb(51, 51, 51); font-family: Helvetica, Arial, sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 100; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Pirosis significa sensación de quemazón o molestia detrás del esternón, en el pecho. Agruras</span></td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="cmbox">
                    <asp:ListItem>Sin molestias</asp:ListItem>
                    <asp:ListItem>Ligero Malestar</asp:ListItem>
                    <asp:ListItem>Malestar Leve</asp:ListItem>
                    <asp:ListItem>Malestar Moderado</asp:ListItem>
                    <asp:ListItem>Malestar Moderado a Severo</asp:ListItem>
                    <asp:ListItem>Malestar Severo</asp:ListItem>
                    <asp:ListItem>Malestar muy Severo</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList8" runat="server" CssClass="cmbox">
                    <asp:ListItem>Sin molestias</asp:ListItem>
                    <asp:ListItem>Ligero Malestar</asp:ListItem>
                    <asp:ListItem>Malestar Leve</asp:ListItem>
                    <asp:ListItem>Malestar Moderado</asp:ListItem>
                    <asp:ListItem>Malestar Moderado a Severo</asp:ListItem>
                    <asp:ListItem>Malestar Severo</asp:ListItem>
                    <asp:ListItem>Malestar muy Severo</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td><span style="color: rgb(51, 51, 51); font-family: Helvetica Neue, Helvetica, Arial sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: bold; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">3. ¿Ha sentido molestia o dolor estomacal durante la última semana?</span></td>
            <td><span style="color: rgb(51, 51, 51); font-family: Helvetica Neue, Helvetica, Arial sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: bold; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">4. ¿Ha sentido náuseas en la última semana?</span></td>
        </tr>
        <tr>
            <td><span style="color: rgb(51, 51, 51); font-family: Helvetica Neue, Helvetica, Arial sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 100; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Dolor estomacal o molestia se refiere a cualquier dolor o molestia en el estómago o abdomen.</span></td>
            <td><span style="color: rgb(51, 51, 51); font-family: Helvetica Neue, Helvetica, Arial sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 100; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Náusea se refiere a la sensación de vomitar.</span></td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="DropDownList9" runat="server" CssClass="cmbox">
                    <asp:ListItem>Sin molestias</asp:ListItem>
                    <asp:ListItem>Ligero Malestar</asp:ListItem>
                    <asp:ListItem>Malestar Leve</asp:ListItem>
                    <asp:ListItem>Malestar Moderado</asp:ListItem>
                    <asp:ListItem>Malestar Moderado a Severo</asp:ListItem>
                    <asp:ListItem>Malestar Severo</asp:ListItem>
                    <asp:ListItem>Malestar muy Severo</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList10" runat="server" CssClass="cmbox">
                    <asp:ListItem>Sin molestias</asp:ListItem>
                    <asp:ListItem>Ligero Malestar</asp:ListItem>
                    <asp:ListItem>Malestar Leve</asp:ListItem>
                    <asp:ListItem>Malestar Moderado</asp:ListItem>
                    <asp:ListItem>Malestar Moderado a Severo</asp:ListItem>
                    <asp:ListItem>Malestar Severo</asp:ListItem>
                    <asp:ListItem>Malestar muy Severo</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td><span style="color: rgb(51, 51, 51); font-family: Helvetica Neue, Helvetica, Arial sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: bold; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">5. ¿Ha sentido molestia por dolor estomacal o abdominal por hambre en la última semana?</span></td>
            <td><span style="color: rgb(51, 51, 51); font-family: Helvetica Neue, Helvetica, Arial sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: bold; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">6. ¿Ha sentido malestar por constipación en la última semana?</span></td>
        </tr>
        <tr>
            <td><span style="color: rgb(51, 51, 51); font-family: Helvetica Neue, Helvetica, Arial sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 100; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Esta sensación de vacío estomacal se asocia con la necesidad de comer entre comidas</span></td>
            <td><span style="color: rgb(51, 51, 51); font-family: Helvetica Neue, Helvetica, Arial sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 100; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Constipación se refiere a la dificultad o incapacidad para evacuar los intestinos</span></td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="DropDownList11" runat="server" CssClass="cmbox">
                    <asp:ListItem>Sin molestias</asp:ListItem>
                    <asp:ListItem>Ligero Malestar</asp:ListItem>
                    <asp:ListItem>Malestar Leve</asp:ListItem>
                    <asp:ListItem>Malestar Moderado</asp:ListItem>
                    <asp:ListItem>Malestar Moderado a Severo</asp:ListItem>
                    <asp:ListItem>Malestar Severo</asp:ListItem>
                    <asp:ListItem>Malestar muy Severo</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList12" runat="server" CssClass="cmbox">
                    <asp:ListItem>Sin molestias</asp:ListItem>
                    <asp:ListItem>Ligero Malestar</asp:ListItem>
                    <asp:ListItem>Malestar Leve</asp:ListItem>
                    <asp:ListItem>Malestar Moderado</asp:ListItem>
                    <asp:ListItem>Malestar Moderado a Severo</asp:ListItem>
                    <asp:ListItem>Malestar Severo</asp:ListItem>
                    <asp:ListItem>Malestar muy Severo</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td><span style="color: rgb(51, 51, 51); font-family:Helvetica Neue, Helvetica, Arial sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: bold; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">7. ¿Ha sentido malestar por heces endurecidas en la última semana?</span></td>
            <td><span style="color: rgb(51, 51, 51); font-family: Helvetica Neue, Helvetica, Arial sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: bold; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">8. Cuando acude al sanitario la última semana ¿Ha sentido que no evacúa por completo los intestinos?</span></td>
        </tr>
        <tr>
            <td><span style="color: rgb(51, 51, 51); font-family: Helvetica Neue, Helvetica, Arial sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 100; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Si sus heces han sido tanto duras como flojas, esta pregunta se refiere solamente a qué tanta molestia ha sentido por las heces duras</span></td>
            <td><span style="color: rgb(51, 51, 51); font-family: Helvetica Neue, Helvetica, Arial sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 100; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Aquella sensación de que a pesar de haber evacuado, aún quedan heces que deben ser expulsadas.</span></td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="DropDownList13" runat="server" CssClass="cmbox">
                    <asp:ListItem>Sin molestias</asp:ListItem>
                    <asp:ListItem>Ligero Malestar</asp:ListItem>
                    <asp:ListItem>Malestar Leve</asp:ListItem>
                    <asp:ListItem>Malestar Moderado</asp:ListItem>
                    <asp:ListItem>Malestar Moderado a Severo</asp:ListItem>
                    <asp:ListItem>Malestar Severo</asp:ListItem>
                    <asp:ListItem>Malestar muy Severo</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList14" runat="server" CssClass="cmbox">
                    <asp:ListItem>Sin molestias</asp:ListItem>
                    <asp:ListItem>Ligero Malestar</asp:ListItem>
                    <asp:ListItem>Malestar Leve</asp:ListItem>
                    <asp:ListItem>Malestar Moderado</asp:ListItem>
                    <asp:ListItem>Malestar Moderado a Severo</asp:ListItem>
                    <asp:ListItem>Malestar Severo</asp:ListItem>
                    <asp:ListItem>Malestar muy Severo</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td><span style="color: rgb(51, 51, 51); font-family: Helvetica Neue, Helvetica, Arial sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: bold; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">9. ¿Ha sentido borborigmos en el estómago o abdomen en la última semana?</span></td>
            <td><span style="color: rgb(51, 51, 51); font-family: Helvetica Neue, Helvetica, Arial sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: bold; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">10. ¿Ha sentido inflamación estomacal en la última semana?</span></td>
        </tr>
        <tr>
            <td><span style="color: rgb(51, 51, 51); font-family: Helvetica Neue, Helvetica, Arial sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 100; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Borborigmos significa vibraciones o ruido estomacal.</span></td>
            <td><span style="color: rgb(51, 51, 51); font-family: Helvetica Neue, Helvetica, Arial sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 100; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Sentir inflamación estomacal significa sentir el estómago o abdomen hinchado o inflamado.</span></td>
        </tr>
        <tr>
            <td style="margin-left: 80px">
                <asp:DropDownList ID="DropDownList15" runat="server" CssClass="cmbox">
                    <asp:ListItem>Sin molestias</asp:ListItem>
                    <asp:ListItem>Ligero Malestar</asp:ListItem>
                    <asp:ListItem>Malestar Leve</asp:ListItem>
                    <asp:ListItem>Malestar Moderado</asp:ListItem>
                    <asp:ListItem>Malestar Moderado a Severo</asp:ListItem>
                    <asp:ListItem>Malestar Severo</asp:ListItem>
                    <asp:ListItem>Malestar muy Severo</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList16" runat="server" CssClass="cmbox">
                    <asp:ListItem>Sin molestias</asp:ListItem>
                    <asp:ListItem>Ligero Malestar</asp:ListItem>
                    <asp:ListItem>Malestar Leve</asp:ListItem>
                    <asp:ListItem>Malestar Moderado</asp:ListItem>
                    <asp:ListItem>Malestar Moderado a Severo</asp:ListItem>
                    <asp:ListItem>Malestar Severo</asp:ListItem>
                    <asp:ListItem>Malestar muy Severo</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td><span style="color: rgb(51, 51, 51); font-family: Helvetica Neue, Helvetica, Arial sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: bold; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">11. ¿Ha tenido malestar por eructos en la última semana?</span></td>
            <td><span style="color: rgb(51, 51, 51); font-family: Helvetica Neue, Helvetica, Arial sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: bold; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">12. ¿Ha tenido malestar por gases o flatulencias en la última semana?</span></td>
        </tr>
        <tr>
            <td><span style="color: rgb(51, 51, 51); font-family: Helvetica Neue, Helvetica, Arial sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 100; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Eructos se refiere a sacar aire o gas por la boca.</span></td>
            <td><span style="color: rgb(51, 51, 51); font-family: Helvetica Neue, Helvetica, Arial sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 100; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Gases o flatulencias significa liberar gas intestinal por el recto/ano</span></td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="DropDownList17" runat="server" CssClass="cmbox">
                    <asp:ListItem>Sin molestias</asp:ListItem>
                    <asp:ListItem>Ligero Malestar</asp:ListItem>
                    <asp:ListItem>Malestar Leve</asp:ListItem>
                    <asp:ListItem>Malestar Moderado</asp:ListItem>
                    <asp:ListItem>Malestar Moderado a Severo</asp:ListItem>
                    <asp:ListItem>Malestar Severo</asp:ListItem>
                    <asp:ListItem>Malestar muy Severo</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList18" runat="server" CssClass="cmbox">
                    <asp:ListItem>Sin molestias</asp:ListItem>
                    <asp:ListItem>Ligero Malestar</asp:ListItem>
                    <asp:ListItem>Malestar Leve</asp:ListItem>
                    <asp:ListItem>Malestar Moderado</asp:ListItem>
                    <asp:ListItem>Malestar Moderado a Severo</asp:ListItem>
                    <asp:ListItem>Malestar Severo</asp:ListItem>
                    <asp:ListItem>Malestar muy Severo</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td><span style="color: rgb(51, 51, 51); font-family: Helvetica Neue, Helvetica, Arial sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: bold; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">13. ¿Ha tenido malestar por Diarrea en la última semana?</span></td>
            <td><span style="color: rgb(51, 51, 51); font-family: Helvetica Neue, Helvetica, Arial sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: bold; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">14. ¿Ha tenido malestar por Heces flojas en la última semana?</span></td>
        </tr>
        <tr>
            <td><span style="color: rgb(51, 51, 51); font-family: Helvetica Neue, Helvetica, Arial sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 100; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Diarrea se refiere a heces flojas o líquidas frecuentes.</span></td>
            <td><span style="color: rgb(51, 51, 51); font-family: Helvetica Neue, Helvetica, Arial sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 100; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Si sus heces han sido tanto duras como flojas, esta pregunta se refiere solamente a qué tanta molestia ha sentido por las heces flojas</span></td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="DropDownList19" runat="server" CssClass="cmbox">
                    <asp:ListItem>Sin molestias</asp:ListItem>
                    <asp:ListItem>Ligero Malestar</asp:ListItem>
                    <asp:ListItem>Malestar Leve</asp:ListItem>
                    <asp:ListItem>Malestar Moderado</asp:ListItem>
                    <asp:ListItem>Malestar Moderado a Severo</asp:ListItem>
                    <asp:ListItem>Malestar Severo</asp:ListItem>
                    <asp:ListItem>Malestar muy Severo</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList20" runat="server" CssClass="cmbox">
                    <asp:ListItem>Sin molestias</asp:ListItem>
                    <asp:ListItem>Ligero Malestar</asp:ListItem>
                    <asp:ListItem>Malestar Leve</asp:ListItem>
                    <asp:ListItem>Malestar Moderado</asp:ListItem>
                    <asp:ListItem>Malestar Moderado a Severo</asp:ListItem>
                    <asp:ListItem>Malestar Severo</asp:ListItem>
                    <asp:ListItem>Malestar muy Severo</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td><span style="color: rgb(51, 51, 51); font-family: Helvetica Neue, Helvetica, Arial sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: bold; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">15. ¿Ha tenido necesidad urgente de evacuar en la última semana?</span></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td><span style="color: rgb(51, 51, 51); font-family: Helvetica Neue, Helvetica, Arial sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 100; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Se refiere a la sensación urgente de evacuar los intestinos que le hace correr al sanitario</span></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="DropDownList21" runat="server" CssClass="cmbox" Width="250px">
                    <asp:ListItem>Sin molestias</asp:ListItem>
                    <asp:ListItem>Ligero Malestar</asp:ListItem>
                    <asp:ListItem>Malestar Leve</asp:ListItem>
                    <asp:ListItem>Malestar Moderado</asp:ListItem>
                    <asp:ListItem>Malestar Moderado a Severo</asp:ListItem>
                    <asp:ListItem>Malestar Severo</asp:ListItem>
                    <asp:ListItem>Malestar muy Severo</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Enviar" Width="140px" ValidationGroup="Valida"  />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />

</asp:Content>
