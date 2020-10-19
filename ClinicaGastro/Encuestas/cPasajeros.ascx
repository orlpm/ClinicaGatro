<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="cPasajeros.ascx.vb" Inherits="ClinicaGastro.cPasajeros" %>
<div style="width: 100%; float: left; clear: both" class="art-BlockContent-body">
        <div style="width: 100%; float: left; clear: both; padding-top: 0.5em; padding-bottom: 1em">
            <div style="width: 100%; float: left; clear: both; padding-bottom: 1em">
                <div style="width: 50%; float: left;">
                    <div style="width: 30%; float: left;">
                        Nombre* :
                    </div>
                    <div style="width: 70%; float: left;">
                        <div style="width: 20%; float: left;">
                            <asp:DropDownList ID="ddlTipoPas" Width="40px" runat="server">
                                <asp:ListItem Text="Sr." Value="1"></asp:ListItem>
                                <asp:ListItem Text="Sra." Value="2"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div style="width: 80%; float: left;">
                            <div style="width: 100%; float: left;">
                                <asp:TextBox ID="tbNombrePas" Width="80%" class="cNombre" name="errorNom" runat="server"></asp:TextBox> 
                            </div>
                            <div id="errorNom" style="width: 100%; float: left; color: red" class="cDivNombre">
                                <span>Campo obligatorio.</span>
                            </div>
                        </div>
                    </div>
                </div>
                <div style="width: 50%; float: left;">
                    <div style="width: 30%; float: left;">
                        Apellidos *:
                    </div>
                    <div style="width: 70%; float: left;">
                        <div style="width: 100%; float: left;">
                            <asp:TextBox ID="tbApellidosPas" Width="80%" class="cApellido" name="errorApe" runat="server"></asp:TextBox> 
                        </div>
                        <div id="errorApe" style="width: 100%; float: left; color: red" class="cDivApellido">
                            <span>Campo obligatorio.</span>
                        </div>
                    </div>
                </div>
            </div>
            <div style="width: 100%; float: left; clear: both; padding-bottom: 1em">
                <div style="width: 50%; float: left;">
                    <div style="width: 30%; float: left;">
                        Tipo documento*:
                    </div>
                    <div style="width: 70%; float: left;">
                        <asp:DropDownList ID="ddlDocumentoPas" Width="80%" runat="server">
                            <asp:ListItem Text="DNI/NIF" Value="0" ></asp:ListItem>
                            <asp:ListItem Text="Pasaporte Espa&#241;ol" Value="2"></asp:ListItem>
                            <asp:ListItem Text="Pasaporte" Value="3"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <div style="width: 50%; float: left;">
                    <div style="width: 30%; float: left;">
                        N&uacute;mero* :
                    </div>
                    <div style="width: 70%; float: left;">
                        <div style="width: 100%; float: left;">
                            <asp:TextBox ID="tbNumeroDocPas" Width="80%" class="cNumero" name="errorNumero" runat="server"></asp:TextBox> 
                        </div>
                        <div id="errorNumero" style="width: 100%; float: left; color: red" class="cDivNumero">
                            <span>Campo obligatorio.</span>
                        </div>
                    </div>
                </div>
            </div>
            <div style="width: 100%; float: left; clear: both; padding-bottom: 1em">
                <div style="width: 50%; float: left;">
                    <div style="width: 30%; float: left;">
                        Tel&eacute;fono:
                    </div>
                    <div style="width: 70%; float: left;">
                        <div style="width: 100%; float: left;">
                            <asp:TextBox ID="tbTelefonoPas" Width="80%" runat="server"></asp:TextBox> 
                        </div>
                    </div>
                </div>
                <div style="width: 50%; float: left;">
                    <div style="width: 30%; float: left;">
                        Email*:
                    </div>
                    <div style="width: 70%; float: left;">
                        <div style="width: 100%; float: left;">
                            <asp:TextBox ID="tbEmailPas" Width="80%" class="cEmail" name="errorEmail" runat="server"></asp:TextBox>
                            <br />
                        </div>
                        <div id="errorEmail" style="width: 100%; float: left; color: red" class="cDivEmail">
                            <span>Campo obligatorio.</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
