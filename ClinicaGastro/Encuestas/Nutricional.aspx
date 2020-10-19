<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Encuestas/Encuestas.master" CodeBehind="Nutricional.aspx.vb" Inherits="ClinicaGastro.Nutricional" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
<script></script>
<h1>Nota de Evolucion</h1>
    <div id="nutricionalcompleto">
    <h2>Nutricional</h2>
    <br />
    <h2>Datos generales</h2>
    <hr />
    <br />
    <table style="width:100%;" id="tablaenc1">
        <tr>
            <td style="width: 35px" >Fecha de modificación</td>
            <td style="width: 387px">
                <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 35px">Nombre</td>
            <td style="width: 387px">
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" Width="353px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 35px">Apellido Paterno</td>
            <td style="width: 387px">
                <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" Width="353px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 35px">Apellido Materno</td>
            <td style="width: 387px">
                <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server" Width="353px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 35px">Edad</td>
            <td style="width: 387px">
                <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server" Width="353px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        
        <tr>
            <td style="width: 35px">Expediente</td>
            <td style="width: 387px">
                <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        
        <tr>
            <td style="width: 35px">Capturo</td>
            <td style="width: 387px">
                <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        
        <tr>
            <td style="width: 35px">Cédula Profesional</td>
            <td style="width: 387px">
                <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        
    </table>


    <div id="ocul" runat="server">
    <br />
    <h2>Signos Vitales</h2>
    <hr />
    <br />
    <table style="width: 100%;" id="tablaenc2">
        <tr>
            <td>TA</td>
            <td>FC</td>
            <td>FR</td>
            <td>TEMP</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="TextBox5" runat="server" Width="203px" CssClass="txtbox"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server" Width="203px" CssClass="txtbox"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server" Width="203px" CssClass="txtbox"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="TextBox8" runat="server" Width="203px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        </table>
    <br />
    <h2>Somatometría</h2>
    <hr />
    <br />
    <table style="width: 100%;" id="tablaenc3">
        <tr>
            <td>Talla(m)</td>
            <td>Peso(kg)</td>
            <td>Masa Muscular</td>
            <td>% Grasa</td>
            <td>% Agua</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="TextBox9" runat="server" CssClass="txtbox"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="TextBox10" runat="server" CssClass="txtbox"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="TextBox11" runat="server" CssClass="txtbox"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="TextBox12" runat="server" CssClass="txtbox"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="TextBox13" runat="server" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        </table>
        </div>
    <br />
    <h2 id="antnut">Antecedentes Nutricionales de Importancia</h2>
    <hr />
    <div id="tablaenc4">
    <table style="width:100%;">
        
        <tr>
            <td style="width: 191px">Peso mas bajo en la vida (kg)</td>
            <td style="width: 199px">Peso más alto en la vida (kg)</td>
            <td>Peso Promedio en la Vida (kg)</td>
        </tr>
        <tr>
            <td style="width: 191px">
                <asp:TextBox ID="TextBox14" runat="server" CssClass="txtbox"></asp:TextBox>
            </td>
            <td style="width: 199px">
                <asp:TextBox ID="TextBox15" runat="server" CssClass="txtbox"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="TextBox16" runat="server" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height: 94px">Alimentos Favoritos</td>
            <td style="height: 94px">
                <asp:TextBox ID="TextBox17" runat="server" Height="84px" Width="355px" TextMode="MultiLine" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">Alimentos que no gustan</td>
            <td>
                <asp:TextBox ID="TextBox18" runat="server" Height="84px" Width="355px" TextMode="MultiLine" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
    </table>
        </div>
    <br />
    <h2>Alimentos que consume diariamente</h2>
    <hr />
    <br />
    <h3>Comida 1</h3>
    <table style="width: 100%;" id="tablaenc5">
        <tr>
            <td style="width: 155px">Comida</td>
            <td>
                <asp:TextBox ID="TextBox19" runat="server" Width="411px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 155px">Hora</td>
            <td>
                <asp:TextBox ID="TextBox20" runat="server" Width="411px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 155px">Alimento y Cantidad</td>
            <td>
                <asp:TextBox ID="TextBox21" runat="server" Width="411px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 155px">Lugar de Consumo</td>
            <td>
                <asp:TextBox ID="TextBox22" runat="server" Width="411px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 155px">Sentimiento</td>
            <td>
                <asp:TextBox ID="TextBox23" runat="server" Width="411px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
    </table>
    <br />
    <h3>Comida 2</h3>
    <table style="width: 100%;" id="tablaenc6">
        <tr>
            <td style="width: 155px">Comida</td>
            <td>
                <asp:TextBox ID="TextBox24" runat="server" Width="411px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 155px">Hora</td>
            <td>
                <asp:TextBox ID="TextBox25" runat="server" Width="411px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 155px">Alimento y Cantidad</td>
            <td>
                <asp:TextBox ID="TextBox26" runat="server" Width="411px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 155px">Lugar de Consumo</td>
            <td>
                <asp:TextBox ID="TextBox27" runat="server" Width="411px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 155px">Sentimiento</td>
            <td>
                <asp:TextBox ID="TextBox28" runat="server" Width="411px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
    </table>
    <h3>Comida 3</h3>
    <table style="width: 100%;" id="tablaenc7">
        <tr>
            <td style="width: 155px">Comida</td>
            <td>
                <asp:TextBox ID="TextBox29" runat="server" Width="411px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 155px">Hora</td>
            <td>
                <asp:TextBox ID="TextBox30" runat="server" Width="411px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 155px">Alimento y Cantidad</td>
            <td>
                <asp:TextBox ID="TextBox31" runat="server" Width="411px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 155px">Lugar de Consumo</td>
            <td>
                <asp:TextBox ID="TextBox32" runat="server" Width="411px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 155px">Sentimiento</td>
            <td>
                <asp:TextBox ID="TextBox33" runat="server" Width="411px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
    </table>
    <h3>Comida 4</h3>
    <table style="width: 100%;" id="tablaenc8">
        <tr>
            <td style="width: 155px">Comida</td>
            <td>
                <asp:TextBox ID="TextBox34" runat="server" Width="411px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 155px">Hora</td>
            <td>
                <asp:TextBox ID="TextBox35" runat="server" Width="411px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 155px">Alimento y Cantidad</td>
            <td>
                <asp:TextBox ID="TextBox36" runat="server" Width="411px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 155px">Lugar de Consumo</td>
            <td>
                <asp:TextBox ID="TextBox37" runat="server" Width="411px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 155px">Sentimiento</td>
            <td>
                <asp:TextBox ID="TextBox38" runat="server" Width="411px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
    </table>
    <h3>Comida 5</h3>
    <table style="width: 100%;" id="tablaenc9">
        <tr>
            <td style="width: 155px">Comida</td>
            <td>
                <asp:TextBox ID="TextBox39" runat="server" Width="411px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 155px">Hora</td>
            <td>
                <asp:TextBox ID="TextBox40" runat="server" Width="411px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 155px">Alimento y Cantidad</td>
            <td>
                <asp:TextBox ID="TextBox41" runat="server" Width="411px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 155px">Lugar de Consumo</td>
            <td>
                <asp:TextBox ID="TextBox42" runat="server" Width="411px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 155px">Sentimiento</td>
            <td>
                <asp:TextBox ID="TextBox43" runat="server" Width="411px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
    </table>
    <br />
    <h2>Tratamiento Nutricional Previo</h2>
    <hr />
    <table style="width: 100%;" id="tablaenc10">
        <tr>
            <td>Existe</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="cmbox">
                    <asp:ListItem>Si</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>Motivo</td>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="cmbox">
                    <asp:ListItem>Ninguno</asp:ListItem>
                    <asp:ListItem>Control de peso</asp:ListItem>
                    <asp:ListItem>Enfermedad</asp:ListItem>
                    <asp:ListItem>Rendimiento Físico</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        </table>
    <br />
    <h2>Actividad Física</h2>
    <hr />
    <table style="width: 100%;" id="tablaenc11">
        <tr>
            <td style="height: 92px; width: 208px;">Tratamiento,estudio y doméstica</td>
            <td colspan="3" style="height: 92px">
                <asp:TextBox ID="TextBox44" runat="server" Height="81px" TextMode="MultiLine" Width="470px" CssClass="txtbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 208px">Trabajo predominante</td>
            <td colspan="3">
                <asp:DropDownList ID="DropDownList3" runat="server" CssClass="cmbox">
                    <asp:ListItem>Pie</asp:ListItem>
                    <asp:ListItem>Sentado</asp:ListItem>
                    <asp:ListItem>Caminando</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 208px">Dormir</td>
            <td style="width: 87px">&nbsp;</td>
            <td>Tipo</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 208px">
                <asp:TextBox ID="TextBox45" runat="server" Width="195px" CssClass="txtbox"></asp:TextBox>
            </td>
            <td style="width: 87px">&nbsp;</td>
            <td>
                <asp:TextBox ID="TextBox49" runat="server" Width="195px" CssClass="txtbox"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 208px">Transporte</td>
            <td style="width: 87px">&nbsp;</td>
            <td>Horario y Frecuencia</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 208px">
                <asp:TextBox ID="TextBox47" runat="server" Width="195px" CssClass="txtbox"></asp:TextBox>
            </td>
            <td style="width: 87px">&nbsp;</td>
            <td>
                <asp:TextBox ID="TextBox48" runat="server" Width="195px" CssClass="txtbox"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 208px">Ejercicio</td>
            <td style="width: 87px">&nbsp;</td>
            <td>Años de Práctica</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 208px">
                <asp:TextBox ID="TextBox50" runat="server" Width="195px" CssClass="txtbox"></asp:TextBox>
            </td>
            <td style="width: 87px">&nbsp;</td>
            <td>
                <asp:TextBox ID="TextBox51" runat="server" Width="195px" CssClass="txtbox"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />
    <h2>Antecedentes Personales Patológicos de Importancia</h2>
    <hr />
    <asp:TextBox ID="TextBox46" runat="server" Height="89px" TextMode="MultiLine" Width="722px" CssClass="txtbox1"></asp:TextBox>
    <br />
    <div id="ocul1" runat="server">
    <h2>Exploración Física</h2>
    <hr />
    <asp:TextBox ID="TextBox52" runat="server" Height="89px" TextMode="MultiLine" Width="722px" CssClass="txtbox1"></asp:TextBox>
    <br />
    <h2>Resultados de Laboratorio</h2>
    <hr />
    <asp:TextBox ID="TextBox53" runat="server" Height="89px" TextMode="MultiLine" Width="722px" CssClass="txtbox1"></asp:TextBox>
    <br />
    <h2>Análisis</h2>
    <hr />
    <asp:TextBox ID="TextBox54" runat="server" Height="89px" TextMode="MultiLine" Width="722px" CssClass="txtbox1"></asp:TextBox>
    <br />
    <h2>Diagnóstico</h2>
    <hr />
    <asp:TextBox ID="TextBox55" runat="server" Height="89px" TextMode="MultiLine" Width="722px" CssClass="txtbox1"></asp:TextBox>
    <br />
    <h2>Plan</h2>
    <hr />
    <asp:TextBox ID="TextBox56" runat="server" Height="89px" TextMode="MultiLine" Width="722px" CssClass="txtbox1"></asp:TextBox>
    <br />
    <h2>Tratamiento</h2>
    <hr />
    <asp:TextBox ID="TextBox57" runat="server" Height="89px" TextMode="MultiLine" Width="722px" CssClass="txtbox1"></asp:TextBox>
    <br />
    <br />
    </div>
    <div id="botoncent" runat="server">
        <asp:Button ID="Button1" runat="server" Text="Guardar" CssClass="btn"/>
    </div>
    
    
    <br />
    <br />
        </div>
</asp:Content>
