<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Encuestas/Encuestas.master" CodeBehind="ModifPsico.aspx.vb" Inherits="ClinicaGastro.ModifPsico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
<asp:UpdatePanel ID="UpdatePanel1" runat="server"><contenttemplate> 
<h1>Nota de Evolución</h1>
    <h2>Psicogastroenterología</h2>
<br />
    <h3>Datos generales</h3>
    <hr />
    <table style="width: 100%;" id="tablaenc7">
        <tr>
            <td style="width: 263px">Fecha de modificación</td>
            <td>
                <asp:Label ID="Label2" runat="server" ></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 263px">Nombre</td>
            <td>
                <asp:Label ID="Label3" runat="server"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox8" runat="server" Width="265" CssClass="txtbox" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 263px">Apellido Paterno</td>
            <td>
                <asp:Label ID="Label4" runat="server"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox9" runat="server" Width="265" CssClass="txtbox" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 263px">Apellido Materno</td>
            <td>
                <asp:Label ID="Label5" runat="server"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox10" runat="server" Width="265" CssClass="txtbox" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 263px">Edad</td>
            <td>
                <asp:Label ID="Label6" runat="server"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox11" runat="server" Width="265" TextMode="Date" CssClass="txtbox" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 263px">Expediente</td>
            <td>
                <asp:Label ID="Label7" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 263px">Capturó</td>
            <td>
                <asp:Label ID="Label8" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 263px">Cédula Profesional</td>
            <td>
                <asp:Label ID="Label9" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
        <br />
    <h3>Antecedentes psicológicos</h3>
    <hr />
    <table style="width: 100%;" id="tablaenc1">
        <tr>
            <td style="width: 239px">¿Has recibido atención psicológica?&nbsp;</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                    <asp:ListItem>Si</asp:ListItem>
                </asp:DropDownList>
                <asp:Label ID="Label10" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 239px">
                <asp:Label ID="Label1" runat="server" Text="Motivo por el que recibiste atención psicológica"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"  TextMode="MultiLine" Height="66px" Width="336px" CssClass="txtbox"  ></asp:TextBox>
                <asp:Label ID="Label11" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 239px">¿Has recibido otro tipo de terapia o atencion emocional?</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"  TextMode="MultiLine" Height="66px" Width="336px" CssClass="txtbox" ></asp:TextBox>
                <asp:Label ID="Label12" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
    </table>
    <br />
    <h3>Relación síntomas Emoción / Psicológicos</h3>
    <hr />
    <table style="width: 100%;" id="tablaenc2">
        <tr>
            <td style="width: 345px">¿Consideras que hay relación entre tus síntomas físicos y emocionales?</td>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                    <asp:ListItem>Si</asp:ListItem>
                </asp:DropDownList>
                <asp:Label ID="Label13" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 345px">¿Que tan apegado eres a las indicaciones médicas o dieta?</td>
            <td>
                <asp:DropDownList ID="DropDownList3" runat="server">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>Muy apegado</asp:ListItem>
                    <asp:ListItem>Apegado</asp:ListItem>
                    <asp:ListItem>Nada apegado</asp:ListItem>
                </asp:DropDownList>
                <asp:Label ID="Label14" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 345px">¿En algún momento su vida se ha visto afectada por tus síntomas?</td>
            <td>
                <asp:DropDownList ID="DropDownList4" runat="server">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                    <asp:ListItem>Si</asp:ListItem>
                </asp:DropDownList>
                <asp:Label ID="Label15" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 345px; height: 24px;">¿Qué áreas se ven mas afectadas por tus síntomas?</td>
            <td style="height: 24px">
                <asp:CheckBox ID="CheckBox9" runat="server" Text="Laboral" />
                &nbsp;<asp:CheckBox ID="CheckBox10" runat="server" Text="Recreativa" />
                &nbsp;<asp:CheckBox ID="CheckBox11" runat="server" Text="Sexual" />
                &nbsp;<asp:CheckBox ID="CheckBox12" runat="server" Text="Familiar" />
                &nbsp;<asp:CheckBox ID="CheckBox13" runat="server" Text="Emocional" />
            </td>
        </tr>
        <tr>
            <td style="width: 345px">¿Cómo se afecta?</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"  TextMode="MultiLine" Height="66px" Width="336px" CssClass="txtbox" ></asp:TextBox>
                <asp:Label ID="Label17" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
    </table>
    <br />
    <div id="ocultar" runat="server">
    <h3>Ejes de la psicología</h3>
    <hr />
    <table style="width: 100%;" id="tablaenc3">
        <tr>
            <td colspan="3">¿Que áreas psicológicas consideras que se afectan más cuando presenta los síntomas que describe?</td>
        </tr>
        <tr>
            <td style="width: 111px">
                <asp:CheckBox ID="CheckBox1" runat="server" Text="Pensamientos"/>
            </td>
            <td style="width: 101px">
                <asp:CheckBox ID="CheckBox2" runat="server" Text="Emociones"/>
            </td>
            <td style="width: 208px">
                <asp:CheckBox ID="CheckBox3" runat="server" Text="Conductas" />
            </td>
        </tr>
        <tr>
            <td style="width: 111px">&nbsp;</td>
            <td style="width: 101px">
                <asp:CheckBox ID="CheckBox4" runat="server" Text="No identifica área afectada" />
            </td>
            <td style="width: 208px">&nbsp;</td>
        </tr>
    </table>
    <br />
    <h3>
        Observaciones clínicas
    </h3>
    <hr />
    <table style="width: 100%;" id="tablaenc4">
        <tr>
            <td colspan="2">Condiciones de Aliño
                <asp:Label ID="Label26" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList6" runat="server" style="margin-left: 0px">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>Adecuadas</asp:ListItem>
                    <asp:ListItem>Regulares</asp:ListItem>
                    <asp:ListItem>Inadecuadas</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Orientación</td>
            <td colspan="2">
                <asp:CheckBox ID="CheckBox5" runat="server" text="Espacio"/>

                &nbsp;<asp:CheckBox ID="CheckBox6" runat="server" text="Tiempo" />
                <asp:CheckBox ID="CheckBox7" runat="server" text="Lugar" />
                &nbsp;<asp:CheckBox ID="CheckBox8" runat="server" text="Persona" />

            </td>
        </tr>
        <tr>
            <td colspan="2">Atención
                <asp:Label ID="Label35" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList7" runat="server" style="margin-left: 0px">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>Adecuada</asp:ListItem>
                    <asp:ListItem>Dispersa</asp:ListItem>
                    <asp:ListItem>Inadecuada</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2">Calidad de Sueño
                <asp:Label ID="Label36" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList8" runat="server" style="margin-left: 0px">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>Buena</asp:ListItem>
                    <asp:ListItem>Regular</asp:ListItem>
                    <asp:ListItem>Mala</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2">Higiene de Sueño
                <asp:Label ID="Label37" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList9" runat="server" style="margin-left: 0px">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>Adecuada</asp:ListItem>
                    <asp:ListItem>Inadecuada</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2">Tipo de Pensamiento
                <asp:Label ID="Label38" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList10" runat="server" style="margin-left: 0px">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>Concreto</asp:ListItem>
                    <asp:ListItem>Abstracto</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2">Estilo de Afrontamiento
                <asp:Label ID="Label39" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:CheckBox ID="CheckBox14" runat="server" Text="Pasivo" />
                &nbsp;<asp:CheckBox ID="CheckBox15" runat="server" Text="Activo" />
                &nbsp;<asp:CheckBox ID="CheckBox16" runat="server" Text="Evitativo" />
                &nbsp;<asp:CheckBox ID="CheckBox17" runat="server" Text="Centrado en el problema" />
                &nbsp;<asp:CheckBox ID="CheckBox18" runat="server" Text="Centrado en las emociones" />
            </td>
        </tr>
        <tr>
            <td colspan="2">Contenido del Pensamiento</td>
            <td>
                <asp:CheckBox ID="CheckBox19" runat="server" Text="Irracional" />
                &nbsp;<asp:CheckBox ID="CheckBox20" runat="server" Text="Racional" />
                &nbsp;<asp:CheckBox ID="CheckBox21" runat="server" Text="Catastrófico" />
            </td>
        </tr>
        <tr>
            <td colspan="2">Locus de control
                <asp:Label ID="Label40" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList12" runat="server" style="margin-left: 0px">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>Interno</asp:ListItem>
                    <asp:ListItem>Externo</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2">Apego a tratamientos
                <asp:Label ID="Label41" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList13" runat="server" style="margin-left: 0px">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>Bueno</asp:ListItem>
                    <asp:ListItem>Regular</asp:ListItem>
                    <asp:ListItem>Malo</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2">Red de apoyo real y percibida
                <asp:Label ID="Label42" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList14" runat="server" style="margin-left: 0px">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>Adecuada</asp:ListItem>
                    <asp:ListItem>Inadecuada</asp:ListItem>
                    <asp:ListItem>Con elementos por movilizar</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2">Impresión diagnóstica
                <asp:Label ID="Label43" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"  TextMode="MultiLine" Height="93px" Width="461px" CssClass="txtbox" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">Requiere control
                <asp:Label ID="Label44" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList15" runat="server">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                    <asp:ListItem>Si</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
    </table>
    <br />
    <h3>Conclusiones</h3>
    <hr />
    
    <table style="width: 100%;" id="tablaenc5">
        <tr>
            <td>Objetivo terapéutico</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="TextBox5" runat="server"  TextMode="MultiLine" Height="93px" Width="740px" CssClass="txtbox" ></asp:TextBox>
                <asp:Label ID="Label45" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Plan</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="TextBox6" runat="server"  TextMode="MultiLine" Height="93px" Width="740px" CssClass="txtbox" ></asp:TextBox>
                <asp:Label ID="Label46" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Seguimiento psicológico&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList16" runat="server">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                    <asp:ListItem>Si</asp:ListItem>
                </asp:DropDownList>
                <asp:Label ID="Label47" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Observaciones y notas</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="TextBox7" runat="server"  TextMode="MultiLine" Height="93px" Width="740px" CssClass="txtbox" ></asp:TextBox>
                <asp:Label ID="Label48" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
    </table>
    <br />
        </div>

    <asp:Button ID="Button1" runat="server" Text="Guardar" Width="160px" />
    </contenttemplate> 
            </asp:UpdatePanel>
</asp:Content>
