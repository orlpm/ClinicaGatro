<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Encuestas/Encuestas.master" CodeBehind="gastro.aspx.vb" Inherits="ClinicaGastro.gastro" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp"%>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional" ><ContentTemplate>
    <h1>Nota de Evolución</h1>
    <h2>Gastroenterología</h2>
<br />
    <h3>Datos generales</h3>
    <hr />
    <div id="datgen" runat="server">
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
            <td style="width: 263px">Sexo</td>
            <td>
                <asp:DropDownList ID="DropDownList200" runat="server" AutoPostBack="True">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>Hombre</asp:ListItem>
                    <asp:ListItem>Mujer</asp:ListItem>
                </asp:DropDownList>
                            <asp:Label ID="Label436" runat="server" Visible="False"></asp:Label>
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
    </div>
        <div id="ocultar" runat="server">
     <h2>Antecedentes Heredofamiliares</h2>
                <hr />
    <table style="width: 100%;" id="tablaenc29">
        <tr>
            <td class="textgral" style="width: 153px">Enfermedad</td>
            <td class="textgral">Familiar</td>
        </tr>
        <tr>
            <td class="textgral" style="width: 153px">Diarrea Reciente</td>
            <td>
                            <asp:DropDownList ID="DropDownList17" runat="server">
                                <asp:ListItem>Ninguno</asp:ListItem>
                                <asp:ListItem>Abuelos</asp:ListItem>
                                <asp:ListItem>Padres</asp:ListItem>
                                <asp:ListItem>Hermanos</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Label188" runat="server" Visible="False"></asp:Label>
                        </td>
        </tr>
        <tr>
            <td class="textgral" style="width: 153px">Hernias</td>
            <td>
                            <asp:DropDownList ID="DropDownList21" runat="server">
                                <asp:ListItem>Ninguno</asp:ListItem>
                                <asp:ListItem>Abuelos</asp:ListItem>
                                <asp:ListItem>Padres</asp:ListItem>
                                <asp:ListItem>Hermanos</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Label189" runat="server" Visible="False"></asp:Label>
                        </td>
        </tr>
        <tr>
            <td class="textgral" style="width: 153px">Cáncer</td>
            <td style="margin-left: 80px">
                            <asp:DropDownList ID="DropDownList25" runat="server">
                                <asp:ListItem>Ninguno</asp:ListItem>
                                <asp:ListItem>Abuelos</asp:ListItem>
                                <asp:ListItem>Padres</asp:ListItem>
                                <asp:ListItem>Hermanos</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Label190" runat="server" Visible="False"></asp:Label>
                        </td>
        </tr>
        <tr>
            <td class="textgral" style="width: 153px">Estreñimiento</td>
            <td style="margin-left: 80px">
                            <asp:DropDownList ID="DropDownList29" runat="server">
                                <asp:ListItem>Ninguno</asp:ListItem>
                                <asp:ListItem>Abuelos</asp:ListItem>
                                <asp:ListItem>Padres</asp:ListItem>
                                <asp:ListItem>Hermanos</asp:ListItem>
                             </asp:DropDownList>
                            <asp:Label ID="Label191" runat="server" Visible="False"></asp:Label>
                        </td>
        </tr>
        <tr>
            <td class="textgral" style="width: 153px">Cancer en tubo digestivo</td>
            <td style="margin-left: 80px">
                            <asp:DropDownList ID="DropDownList33" runat="server">
                                <asp:ListItem>Ninguno</asp:ListItem>
                                <asp:ListItem>Abuelos</asp:ListItem>
                                <asp:ListItem>Padres</asp:ListItem>
                                <asp:ListItem>Hermanos</asp:ListItem>
                                
                            </asp:DropDownList>
                            <asp:Label ID="Label192" runat="server" Visible="False"></asp:Label>
                        </td>
        </tr>
        <tr>
            <td class="textgral" style="width: 153px">Colecistitis Litiástica</td>
            <td style="margin-left: 80px">
                            <asp:DropDownList ID="DropDownList37" runat="server">
                                <asp:ListItem>Ninguno</asp:ListItem>
                                <asp:ListItem>Abuelos</asp:ListItem>
                                <asp:ListItem>Padres</asp:ListItem>
                                <asp:ListItem>Hermanos</asp:ListItem>
                                
                            </asp:DropDownList>
                            <asp:Label ID="Label193" runat="server" Visible="False"></asp:Label>
                        </td>
        </tr>
        <tr>
            <td class="textgral" style="width: 153px">Hipertensión</td>
            <td style="margin-left: 80px">
                            <asp:DropDownList ID="DropDownList41" runat="server">
                                <asp:ListItem>Ninguno</asp:ListItem>
                                <asp:ListItem>Abuelos</asp:ListItem>
                                <asp:ListItem>Padres</asp:ListItem>
                                <asp:ListItem>Hermanos</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Label194" runat="server" Visible="False"></asp:Label>
                        </td>
        </tr>
        <tr>
            <td class="textgral" style="width: 153px">Cardiopatía Isquémica</td>
            <td style="margin-left: 80px">
                            <asp:DropDownList ID="DropDownList45" runat="server">
                                <asp:ListItem>Ninguno</asp:ListItem>
                                <asp:ListItem>Abuelos</asp:ListItem>
                                <asp:ListItem>Padres</asp:ListItem>
                                <asp:ListItem>Hermanos</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Label195" runat="server" Visible="False"></asp:Label>
                        </td>
        </tr>
        <tr>
            <td class="textgral" style="width: 153px">Enfermedades Autoinmunes</td>
            <td style="margin-left: 80px">
                            <asp:DropDownList ID="DropDownList49" runat="server">
                                <asp:ListItem>Ninguno</asp:ListItem>
                                <asp:ListItem>Abuelos</asp:ListItem>
                                <asp:ListItem>Padres</asp:ListItem>
                                <asp:ListItem>Hermanos</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Label196" runat="server" Visible="False"></asp:Label>
                        </td>
        </tr>
        <tr>
            <td class="textgral" style="width: 153px">Diabetes Mellitus</td>
            <td style="margin-left: 80px">
                            <asp:DropDownList ID="DropDownList53" runat="server">
                                <asp:ListItem>Ninguno</asp:ListItem>
                                <asp:ListItem>Abuelos</asp:ListItem>
                                <asp:ListItem>Padres</asp:ListItem>
                                <asp:ListItem>Hermanos</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Label197" runat="server" Visible="False"></asp:Label>
                        </td>
        </tr>
        <tr>
            <td class="textgral" style="width: 153px">Endocrinopatías</td>
            <td style="margin-left: 80px">
                            <asp:DropDownList ID="DropDownList57" runat="server">
                                <asp:ListItem>Ninguno</asp:ListItem>
                                <asp:ListItem>Abuelos</asp:ListItem>
                                <asp:ListItem>Padres</asp:ListItem>
                                <asp:ListItem>Hermanos</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Label198" runat="server" Visible="False"></asp:Label>
                        </td>
        </tr>
        <tr>
            <td class="textgral" style="width: 153px">Otro
                            <asp:Label ID="Label199" runat="server" Visible="False"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox85" runat="server"  Width="243px"></asp:TextBox>
                        </td>
            <td style="margin-left: 80px">
                            <asp:DropDownList ID="DropDownList168" runat="server">
                                <asp:ListItem>Ninguno</asp:ListItem>
                                <asp:ListItem>Abuelos</asp:ListItem>
                                <asp:ListItem>Padres</asp:ListItem>
                                <asp:ListItem>Hermanos</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Label200" runat="server" Visible="False"></asp:Label>
                        </td>
        </tr>
    </table>
                <br />
                <h2>Antecedentes Personales No Patológicos</h2>
                <hr />
                <table style="width: 100%;" id="tablaenc31">
                    <tr>
                        <td class="textgral" >Ocupación</td>
                        <td class="textgral" >Escolaridad</td>
                        <td class="textgral" >Actividad Física</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="TextBox91" runat="server" Width="339px"></asp:TextBox>
                            <asp:Label ID="Label201" runat="server" Visible="False"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList61" runat="server">
                                <asp:ListItem>Nula</asp:ListItem>
                                <asp:ListItem>Primaria</asp:ListItem>
                                <asp:ListItem>Secundaria</asp:ListItem>
                                <asp:ListItem>Preparatoria</asp:ListItem>
                                <asp:ListItem>Licenciatura/Carrera Tec.</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Label202" runat="server" Visible="False"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList64" runat="server">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Label203" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
                </table>
                <br />
                <h2>Antecedentes Personales Patológicos</h2>
                <hr />
                <table style="width: 100%;" id="tablaenc32">
                    <tr>
                        <td style="width: 142px" class="textgral" >Alérgicos</td>
                        <td>
                            <asp:DropDownList ID="DropDownList65" runat="server">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Label204" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 142px" class="textgral" >Descripción</td>
                        <td>
                            <asp:TextBox ID="TextBox94" runat="server" Height="67px" Width="667px" TextMode="MultiLine" ></asp:TextBox>
                            <asp:Label ID="Label205" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    </table>
                <br />
                <h2>Quirúrgicos</h2>
                <hr />
                
                <table style="width: 100%; height: 192px;" id="tablaenc33">
                    <tr>
                        <td style="width: 160px" class="textgral" >Cirugías Realizadas</td>
                        <td>
                            <asp:TextBox ID="TextBox97" runat="server" Width="667px" Height="72px" TextMode="MultiLine"></asp:TextBox>
                            <asp:Label ID="Label206" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 160px" class="textgral" >Tuviste Complicaciones durante la(s) cirugía(s)</td>
                        <td>
                            <asp:TextBox ID="TextBox115" runat="server" Width="667px" Height="72px"  TextMode="MultiLine"></asp:TextBox>
                            <asp:Label ID="Label207" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 160px" class="textgral" >Recibiste Transfuciones de Sangre</td>
                        <td>
                            <asp:DropDownList ID="DropDownList66" runat="server">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Label208" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 160px" class="textgral" >Descripción</td>
                        <td>
                            <asp:TextBox ID="TextBox116" runat="server" Height="72px" Width="667px" TextMode="MultiLine" ></asp:TextBox>
                            <asp:Label ID="Label209" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 160px" class="textgral" >Tipo de Sangre</td>
                        <td>
                            <asp:DropDownList ID="DropDownList67" runat="server">
                                <asp:ListItem>Desconocido</asp:ListItem>
                                <asp:ListItem>O+</asp:ListItem>
                                <asp:ListItem>O-</asp:ListItem>
                                <asp:ListItem>A+</asp:ListItem>
                                <asp:ListItem>A-</asp:ListItem>
                                <asp:ListItem>B+</asp:ListItem>
                                <asp:ListItem>B-</asp:ListItem>
                                <asp:ListItem>AB+</asp:ListItem>
                                <asp:ListItem>AB-</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Label210" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 160px" class="textgral" >Fracturas</td>
                        <td>
                            <asp:DropDownList ID="DropDownList68" runat="server">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Label211" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 160px" class="textgral" >Descripción</td>
                        <td>
                            <asp:TextBox ID="TextBox117" runat="server" Height="72px" Width="630px" TextMode="MultiLine" ></asp:TextBox>
                            <asp:Label ID="Label212" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 160px" class="textgral" >Hospitalizaciones Previas</td>
                        <td>
                            <asp:DropDownList ID="DropDownList69" runat="server">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Label213" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="textgral" style="width: 160px">Descripción</td>
                        <td>
                            <asp:TextBox ID="TextBox118" runat="server" Height="72px" Width="630px" TextMode="MultiLine" ></asp:TextBox>
                            <asp:Label ID="Label214" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
                </table>
                <br />
                <h2>Enfermedades Crónico - Degenerativas</h2>
                <h4>Enfermedades, tiempo de evolución y tratamiento actual</h4>
                <hr />
    <table style="width: 100%;"  id="tablaenc34">
        <tr>
            <td class="textgral" style="width: 208px">Enfermedad</td>
            <td class="textgral" style="width: 43px">&nbsp;</td>
            <td class="textgral" style="width: 135px">Desde cuando te lo diagnosticaron</td>
            <td class="textgral">Tratamiento Actual</td>
        </tr>
        <tr>
            <td class="textgral" style="width: 208px">Hipertensión Arterial
                            <asp:Label ID="Label215" runat="server" Visible="False"></asp:Label>
                        </td>
            <td style="width: 43px">
                            <asp:DropDownList ID="DropDownList169" runat="server" AutoPostBack="True">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
            <td style="width: 135px">
                <asp:TextBox ID="TextBox148" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label216" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox149" runat="server" Visible="False" width="250"></asp:TextBox>
                            <asp:Label ID="Label217" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="textgral" style="width: 208px">Insuficiencia Cardiaca
                            <asp:Label ID="Label218" runat="server" Visible="False"></asp:Label>
                        </td>
            <td style="width: 43px">
                            <asp:DropDownList ID="DropDownList170" runat="server" AutoPostBack="True">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
            <td style="width: 135px">
                <asp:TextBox ID="TextBox150" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label219" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox151" runat="server" Visible="False" width="250"></asp:TextBox>
                            <asp:Label ID="Label220" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="textgral" style="width: 208px">Cardiopatía Isquémica
                            <asp:Label ID="Label221" runat="server" Visible="False"></asp:Label>
                        </td>
            <td style="width: 43px">
                            <asp:DropDownList ID="DropDownList171" runat="server" AutoPostBack="True">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
            <td style="width: 135px">
                <asp:TextBox ID="TextBox152" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label222" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox153" runat="server" Visible="False" width="250"></asp:TextBox>
                            <asp:Label ID="Label223" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="textgral" style="width: 208px">EVC (Transitorio / Isquémico)
                            <asp:Label ID="Label224" runat="server" Visible="False"></asp:Label>
                        </td>
            <td style="width: 43px">
                            <asp:DropDownList ID="DropDownList172" runat="server" AutoPostBack="True">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
            <td style="width: 135px">
                <asp:TextBox ID="TextBox154" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label225" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox155" runat="server" Visible="False" width="250"></asp:TextBox>
                            <asp:Label ID="Label226" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="textgral" style="width: 208px">Insuficiencia Venosa Periférica / Profunda
                            <asp:Label ID="Label227" runat="server" Visible="False"></asp:Label>
                        </td>
            <td style="width: 43px">
                            <asp:DropDownList ID="DropDownList173" runat="server" AutoPostBack="True">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
            <td style="width: 135px">
                <asp:TextBox ID="TextBox156" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label228" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox157" runat="server" Visible="False" width="250"></asp:TextBox>
                            <asp:Label ID="Label229" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="textgral" style="width: 208px">Diabetes Mellitus
                            <asp:Label ID="Label230" runat="server" Visible="False"></asp:Label>
                        </td>
            <td style="width: 43px">
                            <asp:DropDownList ID="DropDownList174" runat="server" AutoPostBack="True">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
            <td style="width: 135px">
                <asp:TextBox ID="TextBox158" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label231" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox159" runat="server" Visible="False" width="250"></asp:TextBox>
                            <asp:Label ID="Label232" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="textgral" style="width: 208px">Dislipidemmia
                            <asp:Label ID="Label233" runat="server" Visible="False"></asp:Label>
                        </td>
            <td style="width: 43px">
                            <asp:DropDownList ID="DropDownList175" runat="server" AutoPostBack="True">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
            <td style="width: 135px">
                <asp:TextBox ID="TextBox160" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label234" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox161" runat="server" Visible="False" width="250"></asp:TextBox>
                            <asp:Label ID="Label235" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="textgral" style="width: 208px">Obesidad
                            <asp:Label ID="Label236" runat="server" Visible="False"></asp:Label>
                        </td>
            <td style="width: 43px">
                            <asp:DropDownList ID="DropDownList176" runat="server" AutoPostBack="True">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
            <td style="width: 135px">
                <asp:TextBox ID="TextBox162" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label237" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox163" runat="server" Visible="False" width="250"></asp:TextBox>
                            <asp:Label ID="Label238" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="textgral" style="width: 208px">Enfermedad&nbsp;Tiroidea
                            <asp:Label ID="Label239" runat="server" Visible="False"></asp:Label>
                        </td>
            <td style="width: 43px">
                            <asp:DropDownList ID="DropDownList177" runat="server" AutoPostBack="True">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
            <td style="width: 135px">
                <asp:TextBox ID="TextBox164" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label240" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox165" runat="server" Visible="False" width="250"></asp:TextBox>
                            <asp:Label ID="Label241" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="textgral" style="width: 208px">Cáncer
                            <asp:Label ID="Label242" runat="server" Visible="False"></asp:Label>
                        </td>
            <td style="width: 43px">
                            <asp:DropDownList ID="DropDownList178" runat="server" AutoPostBack="True">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
            <td style="width: 135px">
                <asp:TextBox ID="TextBox166" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label243" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox167" runat="server" Visible="False" width="250"></asp:TextBox>
                            <asp:Label ID="Label244" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="textgral" style="width: 208px">Tuberculosis
                            <asp:Label ID="Label245" runat="server" Visible="False"></asp:Label>
                        </td>
            <td style="width: 43px">
                            <asp:DropDownList ID="DropDownList179" runat="server" AutoPostBack="True">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
            <td style="width: 135px">
                <asp:TextBox ID="TextBox168" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label246" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox169" runat="server" Visible="False" width="250"></asp:TextBox>
                            <asp:Label ID="Label247" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="textgral" style="width: 208px">Asma
                            <asp:Label ID="Label248" runat="server" Visible="False"></asp:Label>
                        </td>
            <td style="width: 43px">
                            <asp:DropDownList ID="DropDownList180" runat="server" AutoPostBack="True">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
            <td style="width: 135px">
                <asp:TextBox ID="TextBox170" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label249" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox171" runat="server" Visible="False" width="250"></asp:TextBox>
                            <asp:Label ID="Label250" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="textgral" style="width: 208px">EPOC
                            <asp:Label ID="Label251" runat="server" Visible="False"></asp:Label>
                        </td>
            <td style="width: 43px">
                            <asp:DropDownList ID="DropDownList181" runat="server" AutoPostBack="True">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
            <td style="width: 135px">
                <asp:TextBox ID="TextBox172" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label252" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox173" runat="server" Visible="False" width="250"></asp:TextBox>
                            <asp:Label ID="Label253" runat="server" Visible="False"></asp:Label>
                </td>
        </tr>
        <tr>
            <td class="textgral" style="width: 208px">Bronquitis Crónica
                            <asp:Label ID="Label254" runat="server" Visible="False"></asp:Label>
                        </td>
            <td style="width: 43px">
                            <asp:DropDownList ID="DropDownList182" runat="server" AutoPostBack="True">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
            <td style="width: 135px">
                <asp:TextBox ID="TextBox174" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label255" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox175" runat="server" Visible="False" width="250"></asp:TextBox>
                            <asp:Label ID="Label256" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="textgral" style="width: 208px">Otros
                            <asp:TextBox ID="TextBox176" runat="server" Height="16px" Width="260px" AutoPostBack="True"></asp:TextBox>
                            <asp:Label ID="Label257" runat="server" Visible="False"></asp:Label>
                        </td>
            <td style="width: 43px">
                            &nbsp;</td>
            <td style="width: 135px">
                <asp:TextBox ID="TextBox177" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label258" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox178" runat="server" Visible="False" width="250"></asp:TextBox>
                            <asp:Label ID="Label259" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
    </table>
                <br />
                <h2>Toxicomanias</h2>
                <hr />
                <br />
    <table style="width:100%;" id="tablaenc45">
        <tr>
            <td class="textgral" style="width: 80px">Producto</td>
            <td>&nbsp;</td>
            <td class="textgral">Tiempo de Consumo</td>
            <td class="textgral">Cantidad de Consumo Promedio</td>
        </tr>
        <tr>
            <td class="textgral" style="width: 80px">Alcoholismo
                            <asp:Label ID="Label260" runat="server" Visible="False"></asp:Label>
                        </td>
            <td>
                            <asp:DropDownList ID="DropDownList84" runat="server" AutoPostBack="True">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
            <td>
                <asp:TextBox ID="TextBox179" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label261" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox180" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label262" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="textgral" style="width: 80px">Tabaquismo<asp:Label ID="Label263" runat="server" Visible="False"></asp:Label>
                        </td>
            <td>
                            <asp:DropDownList ID="DropDownList85" runat="server" AutoPostBack="True">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
            <td>
                <asp:TextBox ID="TextBox181" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label264" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox182" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label265" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="textgral" style="width: 80px">Drogas y/o Sust.
                <br />
                Psicoactivas<asp:Label ID="Label266" runat="server" Visible="False"></asp:Label>
                        </td>
            <td>
                            <asp:DropDownList ID="DropDownList86" runat="server" style="height: 22px" AutoPostBack="True">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
            <td>
                <asp:TextBox ID="TextBox183" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label267" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox184" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label268" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" class="textgral">Otros
                <asp:TextBox ID="TextBox185" runat="server" Width="212px" AutoPostBack="True"></asp:TextBox>
                            <asp:Label ID="Label269" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox186" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label270" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox187" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label271" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
    </table>
    <div id="ocultar2" runat="server">
     <br />
                <h2>Antecedentes Gineco-Obstétricos</h2>
                <hr />
                <table style="width: 100%;" id="tablaenc36">
                    <tr>
                        <td class="textgral" style="width: 491px" >Fecha de última regla (MM/dd/YYYY)</td>
                        <td class="textgral" style="width: 411px" >Ritmo</td>
                        <td colspan="2" class="textgral" >Menopausia</td>
                    </tr>
                    <tr>
                        <td style="width: 491px">
                            <asp:TextBox ID="TextBox123" runat="server" TextMode="Date" ></asp:TextBox>
                            <asp:Label ID="Label187" runat="server" ></asp:Label>
                        </td>
                        <td style="width: 411px">
                            <asp:TextBox ID="TextBox124" runat="server" Width="208px"></asp:TextBox>
                            <asp:Label ID="Label272" runat="server" Visible="False"></asp:Label>
                        </td>
                        <td colspan="2">
                            <asp:DropDownList ID="DropDownList87" runat="server" AutoPostBack="True">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Label273" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="textgral" style="width: 491px" >Gesta</td>
                        <td class="textgral" style="width: 411px" >Para</td>
                        <td class="textgral" >Cesárea</td>
                        <td class="textgral">Aborto</td>
                    </tr>
                    <tr>
                        <td style="width: 491px">
                            <asp:DropDownList ID="DropDownList88" runat="server">
                                <asp:ListItem>0</asp:ListItem>
                                <asp:ListItem>1</asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                                <asp:ListItem>3</asp:ListItem>
                                <asp:ListItem>4</asp:ListItem>
                                <asp:ListItem>5</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Label274" runat="server" Visible="False"></asp:Label>
                        </td>
                        <td style="width: 411px">
                            <asp:DropDownList ID="DropDownList89" runat="server">
                                <asp:ListItem>0</asp:ListItem>
                                <asp:ListItem>1</asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                                <asp:ListItem>3</asp:ListItem>
                                <asp:ListItem>4</asp:ListItem>
                                <asp:ListItem>5</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Label275" runat="server" Visible="False"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList90" runat="server">
                                <asp:ListItem>0</asp:ListItem>
                                <asp:ListItem>1</asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                                <asp:ListItem>3</asp:ListItem>
                                <asp:ListItem>4</asp:ListItem>
                                <asp:ListItem>5</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Label276" runat="server" Visible="False"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList91" runat="server">
                                <asp:ListItem>0</asp:ListItem>
                                <asp:ListItem>1</asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                                <asp:ListItem>3</asp:ListItem>
                                <asp:ListItem>4</asp:ListItem>
                                <asp:ListItem>5</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Label277" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="textgral" style="width: 491px">Método de planificación familiar
                            <asp:DropDownList ID="DropDownList92" runat="server">
                                <asp:ListItem>Ninguno</asp:ListItem>
                                <asp:ListItem>DIU</asp:ListItem>
                                <asp:ListItem>Pildoras Anticonceptivas</asp:ListItem>
                                <asp:ListItem>Parche</asp:ListItem>
                                <asp:ListItem>Implante Subdermico</asp:ListItem>
                                <asp:ListItem>Inyecciones Hormonales</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Label278" runat="server" Visible="False"></asp:Label>
                        </td>
                        <td class="textgral" style="width: 411px" >Otro
                            <asp:TextBox ID="TextBox125" runat="server" Width="298px"></asp:TextBox>
                            <asp:Label ID="Label279" runat="server" Visible="False"></asp:Label>
                        </td>
                        <td class="textgral"></td>
                        <td></td>
                    </tr>
                </table>
                <br />
        </div>           
                <h2>Interrogatorio por aparatos y sistemas</h2>
                <h4>Síntomas generales</h4>
                <hr />
                <br />
    <table style="width:100%;" id="tablaenc37">
        <tr>
            <td class="textgral" style="width: 137px">Síntoma</td>
            <td style="width: 61px">&nbsp;</td>
            <td class="textgral" style="width: 177px">Tiempo de Evolución</td>
            <td class="textgral">Cuantificación</td>
        </tr>
        <tr>
            <td class="textgral" style="width: 137px">Fiebre </td>
            <td style="width: 61px">
                            <asp:Label ID="Label280" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList93" runat="server">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
            <td style="width: 177px">
                <asp:TextBox ID="TextBox188" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label281" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox189" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label282" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="textgral" style="width: 137px">Astenia </td>
            <td style="width: 61px">
                            <asp:Label ID="Label283" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList94" runat="server">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
            <td style="width: 177px">
                <asp:TextBox ID="TextBox191" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label284" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox192" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label285" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="textgral" style="width: 137px">Adinamia </td>
            <td style="width: 61px">
                            <asp:Label ID="Label286" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList95" runat="server">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
            <td style="width: 177px">
                <asp:TextBox ID="TextBox194" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label287" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox195" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label288" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="textgral" style="width: 137px">Anorexia </td>
            <td style="width: 61px">
                            <asp:Label ID="Label289" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList96" runat="server">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
            <td style="width: 177px">
                <asp:TextBox ID="TextBox197" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label290" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox198" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label291" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="textgral" style="width: 137px">Pérdida de peso<br />
                (+ de 10 Kg en menos de 3 meses) </td>
            <td style="width: 61px">
                            <asp:Label ID="Label292" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList97" runat="server">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
            <td style="width: 177px">
                <asp:TextBox ID="TextBox200" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label293" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox201" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label294" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
    </table>
                <h4>Respiratorio</h4>
                <table style="width:100%;" id="tablaenc30">
                    <tr>
                        <td style="width: 117px" class="textgral">Síntoma</td>
                        <td style="width: 49px">&nbsp;</td>
                        <td class="textgral">Mejoró o Empeoró</td>
                    </tr>
                    <tr>
                        <td style="width: 117px" class="textgral">Obstrucción Nasal</td>
                        <td style="width: 49px">
                            <asp:Label ID="Label295" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList98" runat="server" AutoPostBack="True">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList183" runat="server" Visible="False">
                                <asp:ListItem>Mejoró</asp:ListItem>
                                <asp:ListItem>Empeoró</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Label296" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 117px" class="textgral">Ronquera Matutina</td>
                        <td style="width: 49px">
                            <asp:Label ID="Label297" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList99" runat="server" AutoPostBack="True">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList184" runat="server" Visible="False">
                                <asp:ListItem>Mejoró</asp:ListItem>
                                <asp:ListItem>Empeoró</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Label298" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 117px" class="textgral">Sinusitis Matutina</td>
                        <td style="width: 49px">
                            <asp:Label ID="Label299" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList100" runat="server" AutoPostBack="True">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList185" runat="server" Visible="False">
                                <asp:ListItem>Mejoró</asp:ListItem>
                                <asp:ListItem>Empeoró</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Label300" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 117px" class="textgral">Disfonía</td>
                        <td style="width: 49px">
                            <asp:Label ID="Label301" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList101" runat="server" AutoPostBack="True">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList186" runat="server" Visible="False">
                                <asp:ListItem>Mejoró</asp:ListItem>
                                <asp:ListItem>Empeoró</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Label302" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 117px" class="textgral">Disnea</td>
                        <td style="width: 49px">
                            <asp:Label ID="Label303" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList102" runat="server" AutoPostBack="True">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList187" runat="server" Visible="False">
                                <asp:ListItem>Mejoró</asp:ListItem>
                                <asp:ListItem>Empeoró</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Label304" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 117px" class="textgral">Sibilancias Audibles</td>
                        <td style="width: 49px">
                            <asp:Label ID="Label305" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList103" runat="server" AutoPostBack="True">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList188" runat="server" Visible="False">
                                <asp:ListItem>Mejoró</asp:ListItem>
                                <asp:ListItem>Empeoró</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Label306" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 117px" class="textgral">Tos</td>
                        <td style="width: 49px">
                            <asp:Label ID="Label307" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList104" runat="server" AutoPostBack="True">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList189" runat="server" Visible="False">
                                <asp:ListItem>Mejoró</asp:ListItem>
                                <asp:ListItem>Empeoró</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Label308" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 117px" class="textgral">Cianosis</td>
                        <td style="width: 49px">
                            <asp:Label ID="Label309" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList105" runat="server" AutoPostBack="True">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList190" runat="server" Visible="False">
                                <asp:ListItem>Mejoró</asp:ListItem>
                                <asp:ListItem>Empeoró</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Label310" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 117px" class="textgral">Asma (exacerbaciones)</td>
                        <td style="width: 49px">
                            <asp:Label ID="Label311" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList106" runat="server" AutoPostBack="True">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList191" runat="server" Visible="False">
                                <asp:ListItem>Mejoró</asp:ListItem>
                                <asp:ListItem>Empeoró</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Label312" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
    </table>
                <h4>Cardiovascular</h4>
                <table style="width:100%;" id="tablaenc38">
                    <tr>
                        <td class="textgral" style="width: 152px">Síntoma</td>
                        <td style="width: 56px">&nbsp;</td>
                        <td class="textgral" style="width: 141px">Mejoró o Empeoró</td>
                        <td class="textgral">Sensaciones</td>
                    </tr>
                    <tr>
                        <td class="textgral" style="width: 152px">Lipotimia</td>
                        <td style="width: 56px">
                            <asp:Label ID="Label313" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList107" runat="server" AutoPostBack="True">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td style="width: 141px">
                            <asp:Label ID="Label314" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList192" runat="server" Visible="False">
                                <asp:ListItem>Mejoró</asp:ListItem>
                                <asp:ListItem>Empeoró</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                <asp:TextBox ID="TextBox203" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label315" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="textgral" style="width: 152px">Síncope</td>
                        <td style="width: 56px">
                            <asp:Label ID="Label316" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList108" runat="server" AutoPostBack="True">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td style="width: 141px">
                            <asp:Label ID="Label317" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList193" runat="server" Visible="False">
                                <asp:ListItem>Mejoró</asp:ListItem>
                                <asp:ListItem>Empeoró</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                <asp:TextBox ID="TextBox204" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label318" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="textgral" style="width: 152px">Fatiga</td>
                        <td style="width: 56px">
                            <asp:Label ID="Label319" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList109" runat="server" AutoPostBack="True">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td style="width: 141px">
                            <asp:Label ID="Label320" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList194" runat="server" Visible="False">
                                <asp:ListItem>Mejoró</asp:ListItem>
                                <asp:ListItem>Empeoró</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                <asp:TextBox ID="TextBox205" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label321" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="textgral" style="width: 152px">Palpitaciones</td>
                        <td style="width: 56px">
                            <asp:Label ID="Label322" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList110" runat="server" AutoPostBack="True">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td style="width: 141px">
                            <asp:Label ID="Label323" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList195" runat="server" Visible="False">
                                <asp:ListItem>Mejoró</asp:ListItem>
                                <asp:ListItem>Empeoró</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                <asp:TextBox ID="TextBox206" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label324" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="textgral" style="width: 152px">Dolor Precordial</td>
                        <td style="width: 56px">
                            <asp:Label ID="Label325" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList111" runat="server" AutoPostBack="True">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td style="width: 141px">
                            <asp:Label ID="Label326" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList196" runat="server" Visible="False">
                                <asp:ListItem>Mejoró</asp:ListItem>
                                <asp:ListItem>Empeoró</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                <asp:TextBox ID="TextBox207" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label327" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="textgral" style="width: 152px">Edema</td>
                        <td style="width: 56px">
                            <asp:Label ID="Label328" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList112" runat="server" AutoPostBack="True">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td style="width: 141px">
                            <asp:Label ID="Label329" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList197" runat="server" Visible="False">
                                <asp:ListItem>Mejoró</asp:ListItem>
                                <asp:ListItem>Empeoró</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                <asp:TextBox ID="TextBox208" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label330" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="textgral" style="width: 152px">Disnea paroxístrica nocturna</td>
                        <td style="width: 56px">
                            <asp:Label ID="Label331" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList113" runat="server" AutoPostBack="True">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td style="width: 141px">
                            <asp:Label ID="Label332" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList198" runat="server" Visible="False">
                                <asp:ListItem>Mejoró</asp:ListItem>
                                <asp:ListItem>Empeoró</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                <asp:TextBox ID="TextBox209" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label333" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="textgral" style="width: 152px">Ascitis</td>
                        <td style="width: 56px">
                            <asp:Label ID="Label334" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList114" runat="server" AutoPostBack="True">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td style="width: 141px">
                            <asp:Label ID="Label335" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList199" runat="server" Visible="False">
                                <asp:ListItem>Mejoró</asp:ListItem>
                                <asp:ListItem>Empeoró</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                <asp:TextBox ID="TextBox210" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label336" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
    </table>
                <br />
                <br />
                <h2>Otros</h2>
                <hr />
                <table style="width: 100%;" id="tablaenc42">
                    <tr>
                        <td class="textgral">Disuria</td>
                        <td class="textgral">Polaquiuria</td>
                        <td class="textgral" style="width: 370px">Tenesmo Vesical</td>
                        <td class="textgral">Hematuria</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label337" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList138" runat="server">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="Label338" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList139" runat="server">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td style="width: 370px">
                            <asp:Label ID="Label339" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList140" runat="server">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="Label340" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList141" runat="server">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="textgral">Dolor Suprapubica</td>
                        <td class="textgral">Dolor Lumbar</td>
                        <td class="textgral" style="width: 370px">Ninguno</td>
                        <td class="textgral">Otros</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label341" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList142" runat="server">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="Label342" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList143" runat="server">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td style="width: 370px">
                            <asp:Label ID="Label343" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList144" runat="server">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="Label344" runat="server" Visible="False"></asp:Label>
                            <asp:TextBox ID="TextBox131" runat="server" Height="16px" Width="228px"></asp:TextBox>
                        </td>
                    </tr>
                </table>
                <br />
                <h2>Hemolinfático</h2>
                <hr />
                <table style="width: 100%;" id="tablaenc43">
                    <tr>
                        <td class="textgral">Tendencia a hemorragia</td>
                        <td class="textgral">Adenopatías</td>
                        <td class="textgral">Infecciones recurrentes</td>
                        <td class="textgral">Anemia</td>
                        <td class="textgral">Negado</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label345" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList145" runat="server">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="Label346" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList146" runat="server">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="Label347" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList147" runat="server">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="Label348" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList148" runat="server">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="Label349" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList149" runat="server">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="textgral" colspan="5">Otros
                            </td>
                    </tr>
                    <tr>
                        <td colspan="5">
                            <asp:Label ID="Label350" runat="server" Visible="False"></asp:Label>
                            <asp:TextBox ID="TextBox132" runat="server" Width="667px"></asp:TextBox>
                        </td>
                    </tr>
                </table>
                <br />
                <h2>Sistema Nervioso</h2>
                <hr />
                <table style="width: 100%;" id="tablaenc44">
                    <tr>
                        <td class="textgral">Parálisis</td>
                        <td class="textgral">Parestesias</td>
                        <td class="textgral">Temblores</td>
                        <td class="textgral">Alteraciones de la marcha</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label351" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList150" runat="server">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="Label352" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList151" runat="server">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="Label353" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList152" runat="server">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="Label354" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList153" runat="server">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="textgral">Cefalea/Migraña</td>
                        <td class="textgral">Negado</td>
                        <td class="textgral">Otros</td>
                        <td class="textgral"></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label355" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList154" runat="server">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="Label356" runat="server" Visible="False"></asp:Label>
                            <asp:DropDownList ID="DropDownList155" runat="server">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Si</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td colspan="2">
                            <asp:Label ID="Label357" runat="server" Visible="False"></asp:Label>
                            <asp:TextBox ID="TextBox133" runat="server" Width="266px"></asp:TextBox>
                        </td>
                    </tr>
                </table>
                <br />
    </div>
    <h3>Subjetivo</h3>
    <hr />
    <table style="width: 100%;" id="tablaenc1">
        <tr>
            <td>Padecimiento Actual</td>
            <td>
                            <asp:Label ID="Label358" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"  TextMode="MultiLine" Height="66px" Width="336px" CssClass="txtbox"  ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>¿Cuál es el motivo de consulta o la principal molestia?</td>
            <td>
                            <asp:Label ID="Label359" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox12" runat="server"  TextMode="MultiLine" Height="66px" Width="336px" CssClass="txtbox"  ></asp:TextBox>
            </td>
        </tr>
        </table>
    <br />
        <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional" >
            <ContentTemplate>
    <h3>Dolor              
        <asp:ImageButton ID="ImageButton1" runat="server" Height="28px" ImageUrl="~/Images/mas2.jpg" Width="31px" Visible="False"/>
        <asp:ImageButton ID="ImageButton2" runat="server"  Height="28px" ImageUrl="~/Images/menos.jpg" Width="31px" Visible="False"  />
    </h3>
        
    <div id="Pacdolor" runat="server">
        
       


        


    </div>
        </ContentTemplate>
        </asp:UpdatePanel>
   <%--<h4>Topográfico</h4>
    <hr />
    <table style="width: 100%;" id="tablaenc3">
        <tr>
            <td>Region</td>
            <td>Inicia</td>
            <td>Irradiación</td>
            <td>Migración</td>
            <td>Expansión</td>
            <td>Proyección</td>
        </tr>
        <tr>
            <td>
                            <asp:Label ID="Label360" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
            </td>
            <td>
                            <asp:Label ID="Label361" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
            </td>
            <td>
                            <asp:Label ID="Label362" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
            </td>
            <td>
                            <asp:Label ID="Label363" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
            </td>
            <td>
                            <asp:Label ID="Label364" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
            </td>
            <td>
                            <asp:Label ID="Label365" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox18" runat="server"></asp:TextBox>
            </td>
        </tr>
        </table>
    <br />
    <h4>Cualitativos</h4>
    <hr />
    <table style="width: 100%;" id="tablaenc4">
        <tr>
            <td style="width: 219px">Semejanza</td>
            <td>Localización<br />
                (Localizado, Difuso)</td>
        </tr>
        <tr>
            <td style="width: 219px">
                            <asp:Label ID="Label366" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox19" runat="server"></asp:TextBox>
            </td>
            <td>
                            <asp:Label ID="Label367" runat="server" Visible="False"></asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>Localizado</asp:ListItem>
                    <asp:ListItem>Difuso</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        </table>
    <br />
    <h4>
        Cuantitativos
    </h4>
    <hr />
    <table style="width: 100%;" id="tablaenc5">
        <tr>
            <td>Intensidad Inicial</td>
            <td>Máxima Intensidad</td>
            <td>Intensidad de último evento</td>
        </tr>
        <tr>
            <td>
                            <asp:Label ID="Label368" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox>
            </td>
            <td>
                            <asp:Label ID="Label369" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox21" runat="server"></asp:TextBox>
            </td>
            <td>
                            <asp:Label ID="Label370" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox22" runat="server"></asp:TextBox>
            </td>
        </tr>
        </table>
    <br />
    <h4>Cronológicos</h4>
    <hr />
    <table style="width: 100%;" id="tablaenc6">
        <tr>
            <td>Inicio</td>
            <td>Patrón</td>
            <td>Duración</td>
            <td>Frecuencia / día</td>
            <td>Frecuencia sem / mens</td>
        </tr>
        <tr>
            <td>
                            <asp:Label ID="Label371" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox23" runat="server"></asp:TextBox>
            </td>
            <td>
                            <asp:Label ID="Label372" runat="server" Visible="False"></asp:Label>
                <asp:DropDownList ID="DropDownList2" runat="server">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>Intermitente</asp:ListItem>
                    <asp:ListItem>Continuo</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                            <asp:Label ID="Label373" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox24" runat="server"></asp:TextBox>
            </td>
            <td>
                            <asp:Label ID="Label374" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox25" runat="server"></asp:TextBox>
            </td>
            <td>
                            <asp:Label ID="Label375" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox26" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Último evento</td>
            <td>Patrón de día</td>
            <td>Patrón de ayuno</td>
            <td>Patrón evacuaciones</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                            <asp:Label ID="Label376" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox27" runat="server"></asp:TextBox>
            </td>
            <td>
                            <asp:Label ID="Label377" runat="server" Visible="False"></asp:Label>
                <asp:DropDownList ID="DropDownList3" runat="server">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>Predominio mañana</asp:ListItem>
                    <asp:ListItem>Predominio tarde</asp:ListItem>
                    <asp:ListItem>Predominio noche</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                            <asp:Label ID="Label378" runat="server" Visible="False"></asp:Label>
                <asp:DropDownList ID="DropDownList4" runat="server">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>Antes de comer</asp:ListItem>
                    <asp:ListItem>Durante la comida</asp:ListItem>
                    <asp:ListItem>Después de comer</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                            <asp:Label ID="Label379" runat="server" Visible="False"></asp:Label>
                <asp:DropDownList ID="DropDownList5" runat="server">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>Antes de evacuar</asp:ListItem>
                    <asp:ListItem>Durante la evacuación</asp:ListItem>
                    <asp:ListItem>Después de evacuar</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
            </table>
    <br />
    <h4>Eventos fisiológicos asociados</h4>
    <hr />
    <table style="width: 100%;" id="tablaenc8">
        <tr>
            <td>Patrón evacuaciones</td>
            <td>Patrón Gases</td>
            <td>Patrón Vómito</td>
        </tr>
        <tr>
            <td>
                            <asp:Label ID="Label380" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox28" runat="server"></asp:TextBox>
            </td>
            <td>
                            <asp:Label ID="Label381" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox29" runat="server"></asp:TextBox>
            </td>
            <td>
                            <asp:Label ID="Label382" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox30" runat="server"></asp:TextBox>
            </td>
        </tr>
        </table>
    <br />
    <h4>Modificadores</h4>
    <hr />
    <table style="width: 100%;" id="tablaenc9">
        <tr>
            <td>¿Qué aumenta su intesidad?</td>
            <td>
                            <asp:Label ID="Label383" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox33" runat="server"  TextMode="MultiLine" Height="66px" Width="336px" CssClass="txtbox"  ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>¿Qué disminuye su intensidad?</td>
            <td>
                            <asp:Label ID="Label384" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox34" runat="server"  TextMode="MultiLine" Height="66px" Width="336px" CssClass="txtbox"  ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Alimentos que lo disminuyen</td>
            <td>
                            <asp:Label ID="Label385" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox35" runat="server"  TextMode="MultiLine" Height="66px" Width="336px" CssClass="txtbox"  ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Evacuaciones</td>
            <td>
                            <asp:Label ID="Label386" runat="server" Visible="False"></asp:Label>
                <asp:DropDownList ID="DropDownList7" runat="server">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>Aumentan</asp:ListItem>
                    <asp:ListItem>Disminuyen</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Canalización de gases</td>
            <td>
                            <asp:Label ID="Label387" runat="server" Visible="False"></asp:Label>
                <asp:DropDownList ID="DropDownList8" runat="server">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>Aumentan</asp:ListItem>
                    <asp:ListItem>Disminuyen</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Eructos</td>
            <td>
                            <asp:Label ID="Label388" runat="server" Visible="False"></asp:Label>
                <asp:DropDownList ID="DropDownList9" runat="server">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>Aumentan</asp:ListItem>
                    <asp:ListItem>Disminuyen</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Medicamentos que lo calman</td>
            <td>
                            <asp:Label ID="Label389" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox32" runat="server"  TextMode="MultiLine" Height="66px" Width="336px" CssClass="txtbox"  ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Medicamentos que no lo controlan</td>
            <td>
                            <asp:Label ID="Label390" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox31" runat="server"  TextMode="MultiLine" Height="66px" Width="336px" CssClass="txtbox"  ></asp:TextBox>
            </td>
        </tr>
    </table>
    <br />
    <h4>Síntomas que acompañan ocasionalmente</h4>
    <hr />
    <table style="width: 100%;" id="tablaenc10">
        <tr>
            <td>Síntoma 1</td>
            <td>
                            <asp:Label ID="Label391" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox36" runat="server"  TextMode="MultiLine" Height="66px" Width="336px" CssClass="txtbox"  ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Síntoma 2</td>
            <td>
                            <asp:Label ID="Label392" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox37" runat="server"  TextMode="MultiLine" Height="66px" Width="336px" CssClass="txtbox"  ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Síntoma 3</td>
            <td>
                            <asp:Label ID="Label393" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox38" runat="server"  TextMode="MultiLine" Height="66px" Width="336px" CssClass="txtbox"  ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Síntoma 4</td>
            <td>
                            <asp:Label ID="Label394" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox39" runat="server"  TextMode="MultiLine" Height="66px" Width="336px" CssClass="txtbox"  ></asp:TextBox>
            </td>
        </tr>
    </table>
    <br />
    <h4>Síntomas que acompañan siempre</h4>
    <hr />
    <table style="width: 100%;" id="tablaenc11">
        <tr>
            <td>Síntoma 1</td>
            <td>
                            <asp:Label ID="Label395" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox40" runat="server"  TextMode="MultiLine" Height="66px" Width="336px" CssClass="txtbox"  ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Síntoma 2</td>
            <td>
                            <asp:Label ID="Label396" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox41" runat="server"  TextMode="MultiLine" Height="66px" Width="336px" CssClass="txtbox"  ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Síntoma 3</td>
            <td>
                            <asp:Label ID="Label397" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox42" runat="server"  TextMode="MultiLine" Height="66px" Width="336px" CssClass="txtbox"  ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Síntoma 4</td>
            <td>
                            <asp:Label ID="Label398" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox43" runat="server"  TextMode="MultiLine" Height="66px" Width="336px" CssClass="txtbox"  ></asp:TextBox>
            </td>
        </tr>
    </table>
    <br />--%>
    <hr />
    
    <h3>Síntomas no dolor</h3>
    <br />
    <hr />
    <table style="width: 100%;" id="tablaenc12">
        <tr>
            <td>Síntoma / Signo</td>
            <td>
                            <asp:Label ID="Label399" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox44" runat="server"  TextMode="MultiLine" Height="66px" Width="336px" CssClass="txtbox"  ></asp:TextBox>
            </td>
        </tr>
        </table>
    <br />
    <h4>Cronológicos</h4>
    <hr />
    <table style="width: 100%;" id="tablaenc13">
       <tr>
            <td>Inicio</td>
            <td>Patrón</td>
            <td>Duración</td>
            <td>Frecuencia / día</td>
            <td>Frecuencia sem / mens</td>
        </tr>
        <tr>
            <td>
                            <asp:Label ID="Label400" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td>
                            <asp:Label ID="Label401" runat="server" Visible="False"></asp:Label>
                <asp:DropDownList ID="DropDownList6" runat="server">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>Intermitente</asp:ListItem>
                    <asp:ListItem>Continuo</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                            <asp:Label ID="Label402" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td>
                            <asp:Label ID="Label403" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
            <td>
                            <asp:Label ID="Label404" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Último evento</td>
            <td>Patrón de día</td>
            <td>Patrón de ayuno</td>
            <td>Patrón evacuaciones</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                            <asp:Label ID="Label405" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
            <td>
                            <asp:Label ID="Label406" runat="server" Visible="False"></asp:Label>
                <asp:DropDownList ID="DropDownList10" runat="server">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>Predominio mañana</asp:ListItem>
                    <asp:ListItem>Predominio tarde</asp:ListItem>
                    <asp:ListItem>Predominio noche</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                            <asp:Label ID="Label407" runat="server" Visible="False"></asp:Label>
                <asp:DropDownList ID="DropDownList11" runat="server">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>Antes de comer</asp:ListItem>
                    <asp:ListItem>Durante la comida</asp:ListItem>
                    <asp:ListItem>Después de comer</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                            <asp:Label ID="Label408" runat="server" Visible="False"></asp:Label>
                <asp:DropDownList ID="DropDownList12" runat="server">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>Antes de evacuar</asp:ListItem>
                    <asp:ListItem>Durante la evacuación</asp:ListItem>
                    <asp:ListItem>Después de evacuar</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
<br />
    <h4>Eventos fisiológicos asociados</h4>    
    <hr />
    <table style="width: 100%;" id="tablaenc14">
        <tr>
            <td>Patrón gases</td>
            <td>
                            <asp:Label ID="Label409" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox46" runat="server"  TextMode="MultiLine" Height="66px" Width="335px" CssClass="txtbox"  ></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td>Patrón Vómito</td>
            <td>
                            <asp:Label ID="Label410" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox45" runat="server"  TextMode="MultiLine" Height="66px" Width="336px" CssClass="txtbox"  ></asp:TextBox>
            </td>
        </tr>
        </table>
    <h4>Modificadores</h4>
    <hr />
    <table style="width: 100%;" id="tablaenc15">
        <tr>
            <td>¿Qué aumenta su intensidad?</td>
            <td>
                            <asp:Label ID="Label411" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox47" runat="server"  TextMode="MultiLine" Height="66px" Width="336px" CssClass="txtbox"  ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>¿Qué disminuye su intensidad?</td>
            <td>
                            <asp:Label ID="Label412" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox48" runat="server"  TextMode="MultiLine" Height="66px" Width="336px" CssClass="txtbox"  ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Alimentos que lo provocan o lo aumentan</td>
            <td>
                            <asp:Label ID="Label413" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox49" runat="server"  TextMode="MultiLine" Height="66px" Width="336px" CssClass="txtbox"  ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Alimentos que lo disminuyen</td>
            <td>
                            <asp:Label ID="Label414" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox50" runat="server"  TextMode="MultiLine" Height="66px" Width="336px" CssClass="txtbox"  ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Evacuaciones</td>
            <td>
                            <asp:Label ID="Label415" runat="server" Visible="False"></asp:Label>
                <asp:DropDownList ID="DropDownList13" runat="server">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>Aumentan</asp:ListItem>
                    <asp:ListItem>Disminuyen</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Canalizacion de gases</td>
            <td>
                            <asp:Label ID="Label416" runat="server" Visible="False"></asp:Label>
                <asp:DropDownList ID="DropDownList14" runat="server">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>Aumentan</asp:ListItem>
                    <asp:ListItem>Disminuyen</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Eructos</td>
            <td>
                            <asp:Label ID="Label417" runat="server" Visible="False"></asp:Label>
                <asp:DropDownList ID="DropDownList15" runat="server">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>Aumentan</asp:ListItem>
                    <asp:ListItem>Disminuyen</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Medicamentos que lo calman</td>
            <td>
                            <asp:Label ID="Label418" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox51" runat="server"  TextMode="MultiLine" Height="66px" Width="336px" CssClass="txtbox"  ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Medicamentos que no lo controlan</td>
            <td>
                            <asp:Label ID="Label419" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox52" runat="server"  TextMode="MultiLine" Height="66px" Width="336px" CssClass="txtbox"  ></asp:TextBox>
            </td>
        </tr>
    </table>
    <br />
    <h3>Signos vitales</h3>
    <hr />
    <table style="width: 100%;" id="tablaenc16">
        <tr>
            <td>Peso</td>
            <td>Talla</td>
            <td>Temperatura</td>
            <td>T.A.&nbsp;</td>
            <td>T.C.</td>
            <td>F.R.</td>
        </tr>
        <tr>
            <td>
                            <asp:Label ID="Label420" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox53" runat="server"></asp:TextBox>
            </td>
            <td>
                            <asp:Label ID="Label421" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox54" runat="server"></asp:TextBox>
            </td>
            <td>
                            <asp:Label ID="Label422" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox55" runat="server"></asp:TextBox>
            </td>
            <td>
                            <asp:Label ID="Label423" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox56" runat="server"></asp:TextBox>
            </td>
            <td>
                            <asp:Label ID="Label424" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox57" runat="server"></asp:TextBox>
            </td>
            <td>
                            <asp:Label ID="Label425" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox58" runat="server"></asp:TextBox>
            </td>
        </tr>
        </table>
    <br />
    <h3>Exploración Física</h3>
    <hr />
    <table style="width: 100%;" id="tablaenc17">
        <tr>
            <td>Cabeza</td>
            <td>
                            <asp:Label ID="Label426" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox59" runat="server"  TextMode="MultiLine" Height="66px" Width="336px" CssClass="txtbox"  ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Torax</td>
            <td>
                            <asp:Label ID="Label427" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox60" runat="server"  TextMode="MultiLine" Height="66px" Width="336px" CssClass="txtbox"  ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Abdomen</td>
            <td>
                            <asp:Label ID="Label428" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox61" runat="server"  TextMode="MultiLine" Height="66px" Width="336px" CssClass="txtbox"  ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Extremidades</td>
            <td>
                            <asp:Label ID="Label429" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox62" runat="server"  TextMode="MultiLine" Height="66px" Width="336px" CssClass="txtbox"  ></asp:TextBox>
            </td>
        </tr>
    </table>
    <br />
    <h3>Estudios</h3>
    <hr />
    <table style="width: 100%;" id="tablaenc18">
        <tr>
            <td>
                            <asp:Label ID="Label430" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox63" runat="server"  TextMode="MultiLine" Height="123px" Width="612px" CssClass="txtbox"  ></asp:TextBox>
            </td>
        </tr>
        </table>
    <br />
    <h3>Análisis</h3>
    <hr />
    
        <br />
        <table style="width:100%;" id="tablaenc35">
            <tr>
                <td>
        <asp:GridView ID="GridView1" runat="server" Visible="False">
        </asp:GridView>
    
                </td>
            </tr>
        </table>
    <div id="divPassenger" runat="server" style="width: 811px; margin-left: 120px;" >
        <%--<table style="width: 100%;">
            <tr>
                <td>Región</td>
                <td style="width: 155px">Síntoma / Signo</td>
                <td style="width: 194px">Síndrome Clínico</td>
                <td style="width: 178px">Subtipo</td>
            </tr>
        </table>  --%>  
    </div>
        
        <table style="width: 100%;" id="tablaenc19" border="1" runat="server">
            <tr>
            <td style="width: 115px">
                Región</td>
            <td style="width: 123px">
                Síntoma/Signo</td>
            <td style="width: 143px">
                Síndromes Clínicos</td>
            <td style="width: 125px">
                Subtipo</td>
        </tr>
            <tr>
            <td style="width: 115px">
                
                <asp:DropDownList ID="DropDownList16" runat="server" OnSelectedIndexChanged="DropDownList16_SelectedIndexChanged" AutoPostBack="True" style="height: 22px" >
                <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
            </td>
            
                <td style="width: 123px">
                    
                       
                
                     
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True">
                        </asp:CheckBoxList>
                        <asp:Label ID="Label10" runat="server" Text="Otro" Visible="False"></asp:Label>
                        <asp:TextBox ID="TextBox101" runat="server" Visible="False"></asp:TextBox>
                </td>
                    
            <td style="width: 143px">
                <asp:DropDownList ID="DropDownList18" runat="server" AutoPostBack="True">
                    <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="TextBox102" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td style="width: 215px">
                <asp:DropDownList ID="DropDownList19" runat="server" AutoPostBack="True">
                    <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="TextBox66" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
            <tr>
            <td style="width: 115px">
                <asp:DropDownList ID="DropDownList20" runat="server" AutoPostBack="True">
                <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="width: 123px">
                <asp:CheckBoxList ID="CheckBoxList2" runat="server">
                </asp:CheckBoxList>
                <asp:Label ID="Label11" runat="server" Text="Otro" Visible="False"></asp:Label>
                        <asp:TextBox ID="TextBox103" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td style="width: 143px">
                <asp:DropDownList ID="DropDownList22" runat="server" AutoPostBack="True">
                    <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="TextBox68" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td style="width: 215px">
                <asp:DropDownList ID="DropDownList23" runat="server" AutoPostBack="True">
                    <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="TextBox69" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
            <tr>
            <td style="width: 115px">
                <asp:DropDownList ID="DropDownList24" runat="server" AutoPostBack="True">
                <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="width: 123px">
                <asp:CheckBoxList ID="CheckBoxList3" runat="server">
                </asp:CheckBoxList>
                <asp:Label ID="Label12" runat="server" Text="Otro" Visible="False"></asp:Label>
                        <asp:TextBox ID="TextBox104" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td style="width: 143px">
                <asp:DropDownList ID="DropDownList26" runat="server" AutoPostBack="True">
                    <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="TextBox71" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td style="width: 215px">
                <asp:DropDownList ID="DropDownList27" runat="server" AutoPostBack="True">
                    <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="TextBox72" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
            <tr>
            <td style="width: 115px">
                <asp:DropDownList ID="DropDownList28" runat="server" AutoPostBack="True">
                <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="width: 123px">
                <asp:CheckBoxList ID="CheckBoxList4" runat="server">
                </asp:CheckBoxList>
                <asp:Label ID="Label13" runat="server" Text="Otro" Visible="False"></asp:Label>
                        <asp:TextBox ID="TextBox105" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td style="width: 143px">
                <asp:DropDownList ID="DropDownList30" runat="server" AutoPostBack="True">
                    <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="TextBox74" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td style="width: 215px">
                <asp:DropDownList ID="DropDownList31" runat="server" AutoPostBack="True">
                    <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="TextBox75" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
            <tr>
            <td style="width: 115px">
                <asp:DropDownList ID="DropDownList32" runat="server" AutoPostBack="True">
                <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="width: 123px">
                <asp:CheckBoxList ID="CheckBoxList5" runat="server">
                </asp:CheckBoxList>
                <asp:Label ID="Label14" runat="server" Text="Otro" Visible="False"></asp:Label>
                        <asp:TextBox ID="TextBox106" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td style="width: 143px">
                <asp:DropDownList ID="DropDownList34" runat="server" AutoPostBack="True">
                    <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="TextBox77" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td style="width: 215px">
                <asp:DropDownList ID="DropDownList35" runat="server" AutoPostBack="True">
                    <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="TextBox78" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
            <tr>
            <td style="width: 115px">
                <asp:DropDownList ID="DropDownList36" runat="server" AutoPostBack="True">
                <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="width: 123px">
                <asp:CheckBoxList ID="CheckBoxList6" runat="server">
                </asp:CheckBoxList>
                <asp:Label ID="Label15" runat="server" Text="Otro" Visible="False"></asp:Label>
                        <asp:TextBox ID="TextBox107" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td style="width: 143px">
                <asp:DropDownList ID="DropDownList38" runat="server" AutoPostBack="True">
                    <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="TextBox80" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td style="width: 215px">
                <asp:DropDownList ID="DropDownList39" runat="server" AutoPostBack="True">
                    <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="TextBox81" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
            <tr>
            <td style="width: 115px">
                <asp:DropDownList ID="DropDownList40" runat="server" AutoPostBack="True">
                <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="width: 123px">
                <asp:CheckBoxList ID="CheckBoxList7" runat="server">
                </asp:CheckBoxList>
                <asp:Label ID="Label16" runat="server" Text="Otro" Visible="False"></asp:Label>
                        <asp:TextBox ID="TextBox108" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td style="width: 143px">
                <asp:DropDownList ID="DropDownList42" runat="server" AutoPostBack="True">
                    <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="TextBox83" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td style="width: 215px">
                <asp:DropDownList ID="DropDownList43" runat="server" AutoPostBack="True">
                    <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="TextBox84" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
            <tr>
            <td style="width: 115px">
                <asp:DropDownList ID="DropDownList44" runat="server" AutoPostBack="True">
                <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="width: 123px">
                <asp:CheckBoxList ID="CheckBoxList8" runat="server">
                </asp:CheckBoxList>
                <asp:Label ID="Label17" runat="server" Text="Otro" Visible="False"></asp:Label>
                        <asp:TextBox ID="TextBox109" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td style="width: 143px">
                <asp:DropDownList ID="DropDownList46" runat="server" AutoPostBack="True">
                    <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="TextBox86" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td style="width: 215px">
                <asp:DropDownList ID="DropDownList47" runat="server" AutoPostBack="True">
                    <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="TextBox87" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
            <tr>
            <td style="width: 115px">
                <asp:DropDownList ID="DropDownList48" runat="server" AutoPostBack="True">
                <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="width: 123px">
                <asp:CheckBoxList ID="CheckBoxList9" runat="server">
                </asp:CheckBoxList>
                <asp:Label ID="Label18" runat="server" Text="Otro" Visible="False"></asp:Label>
                        <asp:TextBox ID="TextBox110" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td style="width: 143px">
                <asp:DropDownList ID="DropDownList50" runat="server" AutoPostBack="True">
                    <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="TextBox89" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td style="width: 215px">
                <asp:DropDownList ID="DropDownList51" runat="server" AutoPostBack="True">
                    <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="TextBox90" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
            <tr>
            <td style="width: 115px">
                <asp:DropDownList ID="DropDownList52" runat="server" AutoPostBack="True">
                <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="width: 123px">
                <asp:CheckBoxList ID="CheckBoxList10" runat="server">
                </asp:CheckBoxList>
                <asp:Label ID="Label19" runat="server" Text="Otro" Visible="False"></asp:Label>
                        <asp:TextBox ID="TextBox111" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td style="width: 143px">
                <asp:DropDownList ID="DropDownList54" runat="server" AutoPostBack="True">
                    <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="TextBox92" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td style="width: 215px">
                <asp:DropDownList ID="DropDownList55" runat="server" AutoPostBack="True">
                    <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="TextBox93" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
            <tr>
            <td style="width: 115px">
                <asp:DropDownList ID="DropDownList56" runat="server" AutoPostBack="True">
                <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="width: 123px">
                <asp:CheckBoxList ID="CheckBoxList11" runat="server">
                </asp:CheckBoxList>
                <asp:Label ID="Label20" runat="server" Text="Otro" Visible="False"></asp:Label>
                        <asp:TextBox ID="TextBox112" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td style="width: 143px">
                <asp:DropDownList ID="DropDownList58" runat="server" AutoPostBack="True">
                    <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="TextBox95" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td style="width: 215px">
                <asp:DropDownList ID="DropDownList59" runat="server" AutoPostBack="True">
                    <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="TextBox96" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
            <tr>
            <td style="width: 115px">
                <asp:DropDownList ID="DropDownList60" runat="server" AutoPostBack="True">
                <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="width: 123px">
                <asp:CheckBoxList ID="CheckBoxList12" runat="server">
                </asp:CheckBoxList>
                <asp:Label ID="Label21" runat="server" Text="Otro" Visible="False"></asp:Label>
                        <asp:TextBox ID="TextBox113" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td style="width: 143px">
                <asp:DropDownList ID="DropDownList62" runat="server" AutoPostBack="True">
                    <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="TextBox98" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td style="width: 215px">
                <asp:DropDownList ID="DropDownList63" runat="server" AutoPostBack="True">
                    <asp:ListItem Text = "--Seleccionar--" Value = ""></asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="TextBox99" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
            </table>
    <br />
    <h3>Análisis</h3>
    <hr />
    <table style="width:100%;" id="tablaenc20"><tr><td>
                            <asp:Label ID="Label431" runat="server" Visible="False"></asp:Label>
        <asp:TextBox ID="TextBox100" runat="server" textmode="Multiline" Height="100px" Width="738px"></asp:TextBox>
        </td></tr></table>
    <br />
        <div id="OcultarDiag" runat="server" >
            <h3>Diagnósticos Anteriores</h3>
            <hr />
            <table style="width: 100%;">
                <tr>
                    <td>
                        <asp:GridView ID="GridView2" runat="server">
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    <h3>Diagnóstico</h3>
    <hr />
    <table style="width: 100%;" id="tablaenc21">
        <tr>
            <td style="width: 741px">
                            <asp:Label ID="Label432" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox7" runat="server" Height="123px" TextMode="MultiLine" Width="722px"></asp:TextBox>
            </td>
        </tr>
        </table>

    <%--<div id="divPassenger2" runat="server" style="width: 811px; margin-left: 120px; height: 33px;" >
        
            Impresión Diagnóstica      <asp:Button ID="Button1" runat="server" Text="Nuevo" Width="81px" /><br />
        
            </div>
    <br />--%>
    <h3>GSRS</h3>
    <table style="width:100%;" id="tablaenc22"><tr><td>Sx. Diarréico&nbsp;
                    <asp:TextBox ID="TextBox64" runat="server"></asp:TextBox>
                    <asp:Label ID="Label181" runat="server"></asp:Label>
                    </td>
<td>
    &nbsp;</td>
</tr>
<tr><td>Sx. Indigestión&nbsp;
    <asp:TextBox ID="TextBox65" runat="server"></asp:TextBox>
    <asp:Label ID="Label182" runat="server"></asp:Label>
    </td>
<td>
    &nbsp;</td>
</tr>
<tr><td>Sx. Constipación&nbsp;
    <asp:TextBox ID="TextBox67" runat="server"></asp:TextBox>
    <asp:Label ID="Label183" runat="server"></asp:Label>
    </td>
<td>
    &nbsp;</td>
</tr>
<tr><td>Sx. Dolor Abdominal&nbsp;
    <asp:TextBox ID="TextBox70" runat="server"></asp:TextBox>
    <asp:Label ID="Label184" runat="server"></asp:Label>
    </td>
<td>
    &nbsp;</td>
</tr>
<tr><td>Sx. Reflujo&nbsp;
    <asp:TextBox ID="TextBox73" runat="server"></asp:TextBox>
    <asp:Label ID="Label185" runat="server"></asp:Label>
    </td>
<td>
    &nbsp;</td>
</tr>
<tr><td>Puntaje Global GSRS&nbsp;
    <asp:TextBox ID="TextBox76" runat="server"></asp:TextBox>
    <asp:Label ID="Label186" runat="server"></asp:Label>
    </td>
<td>
    &nbsp;</td>
</tr>
</table>
    <br />
    <h3>Plan</h3>
    <hr />
    <h4>Indicaciones Generales</h4>
    <table style="width: 100%;" id="tablaenc23">
        <tr>
            <td>
                            <asp:Label ID="Label433" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox114" runat="server" Height="123px" TextMode="MultiLine" Width="722px" ></asp:TextBox>
            </td>
        </tr>
        </table>
    <br />
    <h4>Estudios</h4>
    <table style="width: 100%;" id="tablaenc24">
        <tr>
            <td>
                            <asp:Label ID="Label434" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox79" runat="server" Height="123px" TextMode="MultiLine" Width="722px" ></asp:TextBox>
            </td>
        </tr>
        </table>
    <br />
    <h4>Tratamiento</h4>
    <table style="width: 100%;" id="tablaenc25">
        <tr>
            <td>
                            <asp:Label ID="Label435" runat="server" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox82" runat="server" Height="123px" TextMode="MultiLine" Width="722px" ></asp:TextBox>
            </td>
        </tr>
        </table>
    <br />

    <script src="Scripts/jquery-3.2.0.js"></script>
<script>
    
    </script>
                    
    <asp:Button ID="Button1" runat="server" Text="Guardar" Width="200px" OnClick="Button1_Click"/>
    <asp:Button ID="Button2" runat="server" Text="Modificar" Width="200px" Visible="false" OnClick="Button3_Click"/>
    <asp:Button ID="Button3" runat="server" Text="Guardar" Width="200px" Visible="False" />
        </ContentTemplate> </asp:UpdatePanel>
    </asp:Content>
