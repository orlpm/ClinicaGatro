<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="ClinicaGastro.WebForm1" EnableEventValidation = "false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="completo" runat="server">
        <div id="exporta" runat="server">
    <div id="tabla2" >
        <h3>Datos generales</h3>
    <hr />

    <table style="width: 100%;" id="tablaenc1">
        <tr>
            <td style="width: 263px">Fecha de modificación</td>
            <td>
                <asp:Label ID="Label1" runat="server" ></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 263px">Nombre</td>
            <td>
                <asp:Label ID="Label2" runat="server"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox1" runat="server" Width="265"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 263px">Apellido Paterno</td>
            <td>
                <asp:Label ID="Label3" runat="server"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox2" runat="server" Width="265"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 263px">Apellido Materno</td>
            <td>
                <asp:Label ID="Label4" runat="server"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox3" runat="server" Width="265"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 263px">Edad</td>
            <td>
                <asp:Label ID="Label5" runat="server"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox4" runat="server" Width="265" TextMode="Date"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 263px">Expediente</td>
            <td>
                <asp:Label ID="Label6" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 263px">Capturó</td>
            <td>
                <asp:Label ID="Label7" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 263px">Cédula Profesional</td>
            <td>
                <asp:Label ID="Label8" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
        <br />
    <br />
    <h3>Antecedentes Nutricionales de Importancia</h3>
    <br />
        <hr />
    <%--<table style="width: 100%;" id="tablaenc2">
        <tr>
            <td colspan="2">¿Hás acudido anteriormente a consulta de nutrición?</td>
            <td colspan="3"><asp:Label ID="Label12" runat="server" Text="Motivo"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:DropDownList ID="DropDownList1" runat="server" onchange="getvalue();">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                    <asp:ListItem>Si</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td colspan="3">
                <asp:TextBox ID="TextBox5" runat="server" Width="346px" TextMode="MultiLine" Height="64px" style="margin-left: 0px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 871px">
                <asp:Label ID="Label13" runat="server" Text="¿Lograste el objetivo de tu consulta de nutrición?"></asp:Label>
            </td>
            <td style="width: 258px">
                <asp:Label ID="Label14" runat="server" Text="¿Cuál era el (los) objetivo(s)?"></asp:Label>
            </td>
            <td colspan="3">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 871px">
                <asp:DropDownList ID="DropDownList2" runat="server" onchange="getvalue2();">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                    <asp:ListItem>Si</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="width: 258px">
                <asp:TextBox ID="TextBox6" runat="server" Width="346px" TextMode="MultiLine" Height="64px" style="margin-left: 0px"></asp:TextBox>
            </td>
            <td colspan="3">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 871px">Peso más bajo en la vida</td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server" Width="164px"></asp:TextBox>
            </td>
            <td colspan="3">
                &nbsp;</td>
        </tr>
        <tr>
            <td>Peso más alto en la vida</td>
            <td>
                <asp:TextBox ID="TextBox8" runat="server" Width="164px"></asp:TextBox>
            </td>
            <td colspan="3">
                &nbsp;</td>
        </tr>
        <tr>
            <td>Peso promedio en la vida</td>
            <td>
                <asp:TextBox ID="TextBox9" runat="server" Width="164px"></asp:TextBox>
            </td>
            <td colspan="3">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 871px">¿Eres alérgico a algún alimento?</td>
            <td style="width: 258px">
                <asp:Label ID="Label9" runat="server" Text="¿Cuál?"></asp:Label>
            </td>
            <td style="width: 125px">
                ¿Eres intolerante a algún alimento?</td>
            <td style="width: 302px">
                <asp:Label ID="Label10" runat="server" Text="Menciona a que alimento eres intolerante y que te sucede cuando los consumes"></asp:Label>
            </td>
            <td style="width: 171px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 871px">
                <asp:DropDownList ID="DropDownList3" runat="server">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                    <asp:ListItem>Si</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="width: 258px">
                <asp:TextBox ID="TextBox10" runat="server" Height="64px" style="margin-left: 0px" TextMode="MultiLine" Width="346px"></asp:TextBox>
            </td>
            <td style="width: 125px">
                
                <asp:DropDownList ID="DropDownList4" runat="server">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                    <asp:ListItem>Si</asp:ListItem>
                </asp:DropDownList>
                
            </td>
            <td style="width: 302px">
                <asp:TextBox ID="TextBox11" runat="server" Width="346px" TextMode="MultiLine" Height="64px" style="margin-left: 0px"></asp:TextBox>
            </td>
            <td style="width: 171px">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">Alimentos que no me gustan</td>
            <td style="width: 125px">
                &nbsp;</td>
            <td style="width: 302px">
                Alimentos que me gustan</td>
            <td style="width: 171px">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:TextBox ID="TextBox12" runat="server" Width="346px" TextMode="MultiLine" Height="64px" style="margin-left: 0px"></asp:TextBox>
            </td>
            <td style="width: 125px">
                &nbsp;</td>
            <td style="width: 302px">
                <asp:TextBox ID="TextBox13" runat="server" Width="346px" TextMode="MultiLine" Height="64px" style="margin-left: 0px"></asp:TextBox>
            </td>
            <td style="width: 171px">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">¿Existe algun impedimento para realizar tus comidas habituales?</td>
            <td style="width: 125px">
                <asp:Label ID="Label11" runat="server" Text="¿Qué impedimento?"></asp:Label>
            </td>
            <td style="width: 302px">
                &nbsp;</td>
            <td style="width: 171px">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:DropDownList ID="DropDownList5" runat="server">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                    <asp:ListItem>Si</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="width: 125px">
                <asp:TextBox ID="TextBox14" runat="server" Width="346px" TextMode="MultiLine" Height="64px" style="margin-left: 0px"></asp:TextBox>
            </td>
            <td style="width: 302px">
                &nbsp;</td>
            <td style="width: 171px">
                &nbsp;</td>
        </tr>
    </table>--%>
        <table style="width: 122%; height: 141px;" id="tablaenc2">
            <tr>
                <td style="width: 122px; height: 9px;">¿Hás acudido anteriormente a consulta de nutrición?</td>
                <td style="width: 17px; height: 9px;"></td>
                <td style="width: 179px; height: 9px">
                    <asp:Label ID="Label9" runat="server" Text="Motivo"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 122px">
                    <asp:Label ID="Label20" runat="server" Visible="False"></asp:Label>
                    <asp:DropDownList ID="DropDownList1" runat="server" onchange="getvalue();">
                        <asp:ListItem>--Seleccionar--</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                        <asp:ListItem>Si</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td style="width: 17px">&nbsp;</td>
                <td style="width: 179px">
                    <asp:Label ID="Label21" runat="server" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox5" runat="server" TextMode="MultiLine" Height="74px" Width="300px" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 122px">
                    &nbsp;</td>
                <td style="width: 17px">&nbsp;</td>
                <td style="width: 179px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 122px">
                    <asp:Label ID="Label10" runat="server" Text="¿Lograste el objetivo de tu consulta de nutrición?"></asp:Label>
                </td>
                <td style="width: 17px">&nbsp;</td>
                <td style="width: 179px">
                    <asp:Label ID="Label11" runat="server" Text="¿Cuál era el (los) objetivo(s)?"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 122px">
                    <asp:Label ID="Label22" runat="server" Visible="False"></asp:Label>
                    <asp:DropDownList ID="DropDownList2" runat="server" onchange="getvalue2();">
                        <asp:ListItem>--Seleccionar--</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                        <asp:ListItem>Si</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td style="width: 17px">&nbsp;</td>
                <td style="width: 179px">
                    <asp:Label ID="Label23" runat="server" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox6" runat="server" TextMode="MultiLine" Height="74px" Width="300px" ></asp:TextBox>
                </td>
            </tr>
            </table>
        <table style="width: 100%;" id="tablaenc3">
            <tr>
                <td style="width: 162px">Peso más bajo en la vida</td>
                <td>
                    <asp:Label ID="Label24" runat="server" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox7" runat="server" Width="74px" TextMode="Number"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 162px">Peso más alto en la vida</td>
                <td>
                    <asp:Label ID="Label25" runat="server" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox8" runat="server" Width="74px" TextMode="Number" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 162px">Peso promedio en la vida</td>
                <td>
                    <asp:Label ID="Label26" runat="server" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox9" runat="server" Width="74px" TextMode="Number" ></asp:TextBox>
                </td>
            </tr>
        </table>
        <table style="width:100%;" id="tablaenc4">
            <tr>
                <td style="width: 261px">¿Eres alérgico a algún alimento?</td>
                <td>
                    <asp:Label ID="Label12" runat="server" Text="¿Cuál?"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 261px">
                    <asp:Label ID="Label27" runat="server" Visible="False"></asp:Label>
                    <asp:DropDownList ID="DropDownList3" runat="server" onchange="getvalue3();">
                        <asp:ListItem>--Seleccionar--</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                        <asp:ListItem>Si</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Label ID="Label28" runat="server" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox10" runat="server" TextMode="MultiLine" Height="74px" Width="300px" ></asp:TextBox>
                </td>
            </tr>
            </table>
        <table style="width:100%;" id="tablaenc5">
            <tr>
                <td style="width: 133px">¿Eres intolerante a algún alimento?</td>
                <td style="width: 369px">
                    <asp:Label ID="Label13" runat="server" Text="Menciona a que alimento eres intolerante y que te sucede cuando los consumes"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 133px">
                    <asp:Label ID="Label29" runat="server" Visible="False"></asp:Label>
                    <asp:DropDownList ID="DropDownList4" runat="server" onchange="getvalue4();">
                        <asp:ListItem>--Seleccionar--</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                        <asp:ListItem>Si</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td style="width: 369px">
                    <asp:Label ID="Label30" runat="server" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox11" runat="server" TextMode="MultiLine" Height="74px" Width="300px" ></asp:TextBox>
                </td>
            </tr>
            </table>
        <table style="width:104%; height: 182px;" id="tablaenc6">
            <tr>
                <td style="width: 143px">Alimentos que no me gustan</td>
                <td style="width: 404px">
                    <asp:Label ID="Label31" runat="server" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox12" runat="server" TextMode="MultiLine" Height="74px" Width="300px" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 143px">Alimentos que me gustan</td>
                <td style="width: 404px">
                    <asp:Label ID="Label32" runat="server" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox13" runat="server" TextMode="MultiLine" Height="74px" Width="300px" ></asp:TextBox>
                </td>
            </tr>
            </table>
        <table style="width:129%;" id="tablaenc7">
            <tr>
                <td style="width: 145px">¿Existe algún impedimento para realizar tus comidas habituales?</td>
                <td>
                    <asp:Label ID="Label14" runat="server" Text="¿Qué impedimento?"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 145px">
                    <asp:Label ID="Label33" runat="server" Visible="False"></asp:Label>
                    <asp:DropDownList ID="DropDownList5" runat="server" onchange="getvalue5();">
                        <asp:ListItem>--Seleccionar--</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                        <asp:ListItem>Si</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Label ID="Label34" runat="server" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox14" runat="server" TextMode="MultiLine" Height="74px" Width="300px" ></asp:TextBox>
                </td>
            </tr>
            </table>
        <table style="width: 100%;" id="tablaenc8">
            <tr>
                <td style="width: 183px">¿Existe algún alimento que al consumirlo acentúe algún síntoma de tu padecimiento actual?</td>
                <td>
                    <asp:Label ID="Label15" runat="server" Text="¿Qué síntoma?"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label16" runat="server" Text="¿Qué alimento(s)?"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label17" runat="server" Text="¿Existe algún alimento con el que alivie el síntoma anterior?"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 183px">
                    <asp:Label ID="Label35" runat="server" Visible="False"></asp:Label>
                    <asp:DropDownList ID="DropDownList6" runat="server" onchange="getvalue6();">
                        <asp:ListItem>--Seleccionar--</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                        <asp:ListItem>Si</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Label ID="Label36" runat="server" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox15" runat="server" TextMode="MultiLine" Height="74px" Width="300px" ></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label37" runat="server" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox16" runat="server" TextMode="MultiLine" Height="74px" Width="300px" ></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label38" runat="server"></asp:Label>
                    <asp:TextBox ID="TextBox17" runat="server" TextMode="MultiLine" Height="74px" Width="300px" ></asp:TextBox>
                </td>
            </tr>
            </table>
        <table style="width:87%;" id="tablaenc9">
            <tr>
                <td>¿Realizas actividad física o ejercicio?</td>
                <td>
                    <asp:Label ID="Label18" runat="server" Text="¿Que realizas?"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label19" runat="server" Text="Duración y días a la semana"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label39" runat="server" Visible="False"></asp:Label>
                    <asp:DropDownList ID="DropDownList7" runat="server" onchange="getvalue7();">
                        <asp:ListItem>--Seleccionar--</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                        <asp:ListItem>Si</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Label ID="Label40" runat="server" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox18" runat="server" TextMode="MultiLine" Height="76px" Width="231px" ></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label41" runat="server" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox19" runat="server"></asp:TextBox>
                </td>
            </tr>
            </table>
    <br />
    <h3>Recordatorio de 24 horas</h3>
    <hr />
       
        <div id="divPassenger" runat="server" style="width: 811px; margin-left: 120px;" >
        
            <table style="width:100%;">
                <tr>
                    <td style="width: 127px">Tiempo de Comida</td>
                    <td style="width: 127px">Lugar</td>
                    <td style="width: 147px">Horario</td>
                    <td style="width: 141px">Alimento y Cantidad</td>
                    <td>Valor calórico</td>
                </tr>
                <tr>
                    <td style="width: 127px">
                        <asp:DropDownList ID="DropDownList17" runat="server">
                            <asp:ListItem Selected="True">--Seleccionar--</asp:ListItem>
                            <asp:ListItem>Desayuno</asp:ListItem>
                            <asp:ListItem>Comida</asp:ListItem>
                            <asp:ListItem>Cena</asp:ListItem>
                            <asp:ListItem>Colación</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td style="width: 127px">
                        <asp:TextBox ID="TextBox38" runat="server"></asp:TextBox>
                    </td>
                    <td style="width: 147px">
                        <asp:TextBox ID="TextBox39" runat="server"></asp:TextBox>
                    </td>
                    <td style="width: 141px">
                        <asp:TextBox ID="TextBox40" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox41" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 127px">
                        <asp:DropDownList ID="DropDownList18" runat="server">
                            <asp:ListItem Selected="True">--Seleccionar--</asp:ListItem>
                            <asp:ListItem>Desayuno</asp:ListItem>
                            <asp:ListItem>Comida</asp:ListItem>
                            <asp:ListItem>Cena</asp:ListItem>
                            <asp:ListItem>Colación</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td style="width: 127px">
                        <asp:TextBox ID="TextBox42" runat="server"></asp:TextBox>
                    </td>
                    <td style="width: 147px">
                        <asp:TextBox ID="TextBox43" runat="server"></asp:TextBox>
                    </td>
                    <td style="width: 141px">
                        <asp:TextBox ID="TextBox44" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox45" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 127px">
                        <asp:DropDownList ID="DropDownList19" runat="server">
                            <asp:ListItem Selected="True">--Seleccionar--</asp:ListItem>
                            <asp:ListItem>Desayuno</asp:ListItem>
                            <asp:ListItem>Comida</asp:ListItem>
                            <asp:ListItem>Cena</asp:ListItem>
                            <asp:ListItem>Colación</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td style="width: 127px">
                        <asp:TextBox ID="TextBox46" runat="server"></asp:TextBox>
                    </td>
                    <td style="width: 147px">
                        <asp:TextBox ID="TextBox47" runat="server"></asp:TextBox>
                    </td>
                    <td style="width: 141px">
                        <asp:TextBox ID="TextBox48" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox49" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 127px">
                        <asp:DropDownList ID="DropDownList20" runat="server">
                            <asp:ListItem Selected="True">--Seleccionar--</asp:ListItem>
                            <asp:ListItem>Desayuno</asp:ListItem>
                            <asp:ListItem>Comida</asp:ListItem>
                            <asp:ListItem>Cena</asp:ListItem>
                            <asp:ListItem>Colación</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td style="width: 127px">
                        <asp:TextBox ID="TextBox50" runat="server"></asp:TextBox>
                    </td>
                    <td style="width: 147px">
                        <asp:TextBox ID="TextBox51" runat="server"></asp:TextBox>
                    </td>
                    <td style="width: 141px">
                        <asp:TextBox ID="TextBox52" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox53" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 127px">
                        <asp:DropDownList ID="DropDownList21" runat="server">
                            <asp:ListItem Selected="True">--Seleccionar--</asp:ListItem>
                            <asp:ListItem>Desayuno</asp:ListItem>
                            <asp:ListItem>Comida</asp:ListItem>
                            <asp:ListItem>Cena</asp:ListItem>
                            <asp:ListItem>Colación</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td style="width: 127px">
                        <asp:TextBox ID="TextBox54" runat="server"></asp:TextBox>
                    </td>
                    <td style="width: 147px">
                        <asp:TextBox ID="TextBox55" runat="server"></asp:TextBox>
                    </td>
                    <td style="width: 141px">
                        <asp:TextBox ID="TextBox56" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox57" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 127px">
                        <asp:DropDownList ID="DropDownList22" runat="server">
                            <asp:ListItem Selected="True">--Seleccionar--</asp:ListItem>
                            <asp:ListItem>Desayuno</asp:ListItem>
                            <asp:ListItem>Comida</asp:ListItem>
                            <asp:ListItem>Cena</asp:ListItem>
                            <asp:ListItem>Colación</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td style="width: 127px">
                        <asp:TextBox ID="TextBox58" runat="server"></asp:TextBox>
                    </td>
                    <td style="width: 147px">
                        <asp:TextBox ID="TextBox59" runat="server"></asp:TextBox>
                    </td>
                    <td style="width: 141px">
                        <asp:TextBox ID="TextBox60" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox61" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 127px">
                        <asp:DropDownList ID="DropDownList23" runat="server">
                            <asp:ListItem Selected="True">--Seleccionar--</asp:ListItem>
                            <asp:ListItem>Desayuno</asp:ListItem>
                            <asp:ListItem>Comida</asp:ListItem>
                            <asp:ListItem>Cena</asp:ListItem>
                            <asp:ListItem>Colación</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td style="width: 127px">
                        <asp:TextBox ID="TextBox62" runat="server"></asp:TextBox>
                    </td>
                    <td style="width: 147px">
                        <asp:TextBox ID="TextBox63" runat="server"></asp:TextBox>
                    </td>
                    <td style="width: 141px">
                        <asp:TextBox ID="TextBox64" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox65" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 127px">
                        <asp:DropDownList ID="DropDownList24" runat="server">
                            <asp:ListItem Selected="True">--Seleccionar--</asp:ListItem>
                            <asp:ListItem>Desayuno</asp:ListItem>
                            <asp:ListItem>Comida</asp:ListItem>
                            <asp:ListItem>Cena</asp:ListItem>
                            <asp:ListItem>Colación</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td style="width: 127px">
                        <asp:TextBox ID="TextBox66" runat="server"></asp:TextBox>
                    </td>
                    <td style="width: 147px">
                        <asp:TextBox ID="TextBox67" runat="server"></asp:TextBox>
                    </td>
                    <td style="width: 141px">
                        <asp:TextBox ID="TextBox68" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox69" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 127px">
                        <asp:DropDownList ID="DropDownList25" runat="server">
                            <asp:ListItem Selected="True">--Seleccionar--</asp:ListItem>
                            <asp:ListItem>Desayuno</asp:ListItem>
                            <asp:ListItem>Comida</asp:ListItem>
                            <asp:ListItem>Cena</asp:ListItem>
                            <asp:ListItem>Colación</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td style="width: 127px">
                        <asp:TextBox ID="TextBox70" runat="server"></asp:TextBox>
                    </td>
                    <td style="width: 147px">
                        <asp:TextBox ID="TextBox71" runat="server"></asp:TextBox>
                    </td>
                    <td style="width: 141px">
                        <asp:TextBox ID="TextBox72" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox73" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 127px">
                        <asp:DropDownList ID="DropDownList26" runat="server">
                            <asp:ListItem Selected="True">--Seleccionar--</asp:ListItem>
                            <asp:ListItem>Desayuno</asp:ListItem>
                            <asp:ListItem>Comida</asp:ListItem>
                            <asp:ListItem>Cena</asp:ListItem>
                            <asp:ListItem>Colación</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td style="width: 127px">
                        <asp:TextBox ID="TextBox74" runat="server"></asp:TextBox>
                    </td>
                    <td style="width: 147px; margin-left: 80px;">
                        <asp:TextBox ID="TextBox75" runat="server"></asp:TextBox>
                    </td>
                    <td style="width: 141px">
                        <asp:TextBox ID="TextBox76" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox77" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="5">
                        &nbsp;</td>
                </tr>
            </table>
        
            <br />
                        
        
            </div>
        <asp:GridView ID="GridView1" runat="server" Visible="False">
                        </asp:GridView>
        <table style="width: 221%;" id="tablaenc10">
            <tr>
                <td style="width: 429px">&nbsp;</td>
                <td style="width: 213px">Valor total Calórico Aproximado</td>
                <td>
                    <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox>
                </td>
            </tr>
            </table>
        <br />
        <div id="ocultar" runat="server">
        <h3>Antropometría</h3>
        <hr />
        <table style="width: 125%;" id="tablaenc11">
            <tr>
                <td style="width: 78px">Talla</td>
                <td style="width: 99px">Peso</td>
                <td style="width: 98px">IMC</td>
                <td style="width: 115px">Circ. de Cintura</td>
            </tr>
            <tr>
                <td style="width: 78px">
                    <asp:Label ID="Label42" runat="server" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox21" runat="server"></asp:TextBox>
                </td>
                <td style="width: 99px">
                    <asp:Label ID="Label43" runat="server" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox22" runat="server"></asp:TextBox>
                </td>
                <td style="width: 98px">
                    <asp:Label ID="Label44" runat="server" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox23" runat="server"></asp:TextBox>
                </td>
                <td style="width: 115px">
                    <asp:Label ID="Label45" runat="server" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox24" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 78px">Circ. de Cadera</td>
                <td style="width: 99px">% grasa</td>
                <td style="width: 98px">% musculo</td>
                <td style="width: 115px">% agua</td>
            </tr>
            <tr>
                <td style="width: 78px">
                    <asp:Label ID="Label46" runat="server" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox25" runat="server"></asp:TextBox>
                </td>
                <td style="width: 99px">
                    <asp:Label ID="Label47" runat="server" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox26" runat="server"></asp:TextBox>
                </td>
                <td style="width: 98px">
                    <asp:Label ID="Label48" runat="server" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox27" runat="server"></asp:TextBox>
                </td>
                <td style="width: 115px">
                    <asp:Label ID="Label49" runat="server" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox28" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <h3>Análisis de la dieta / Padecimiento</h3>
        <hr />
        <table style="width: 100%;" id="tablaenc12">
            <tr>
                <td style="width: 105px">Completa</td>
                <td colspan="2">Motivo</td>
                <td style="width: 96px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 105px">
                    <asp:Label ID="Label50" runat="server" Visible="False"></asp:Label>
                    <asp:DropDownList ID="DropDownList8" runat="server" onchange="getvalue7();">
                        <asp:ListItem>--Seleccionar--</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                        <asp:ListItem>Si</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td colspan="2">
                    <asp:Label ID="Label51" runat="server" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox29" runat="server" TextMode="MultiLine" Height="65px" Width="227px" ></asp:TextBox>
                </td>
                <td style="width: 96px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 105px">&nbsp;Equilibrada</td>
                <td colspan="2">Motivo</td>
                <td style="width: 96px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 105px">
                    <asp:Label ID="Label52" runat="server" Visible="False"></asp:Label>
                    <asp:DropDownList ID="DropDownList9" runat="server" onchange="getvalue7();">
                        <asp:ListItem>--Seleccionar--</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                        <asp:ListItem>Si</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td style="width: 123px">
                    <asp:Label ID="Label53" runat="server" Visible="False"></asp:Label>
                    <asp:DropDownList ID="DropDownList10" runat="server" onchange="getvalue7();">
                        <asp:ListItem>--Seleccionar--</asp:ListItem>
                        <asp:ListItem>Carbohidratos</asp:ListItem>
                        <asp:ListItem>Proteina</asp:ListItem>
                        <asp:ListItem>Grasa</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Label ID="Label54" runat="server" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox30" runat="server" TextMode="MultiLine" Height="65px" Width="227px" ></asp:TextBox>
                </td>
                <td style="width: 96px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 105px">Variada</td>
                <td colspan="2">Motivo</td>
                <td style="width: 96px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 105px">
                    <asp:Label ID="Label55" runat="server" Visible="False"></asp:Label>
                    <asp:DropDownList ID="DropDownList11" runat="server" onchange="getvalue7();">
                        <asp:ListItem>--Seleccionar--</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                        <asp:ListItem>Si</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td colspan="2">
                    <asp:Label ID="Label56" runat="server" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox31" runat="server" TextMode="MultiLine" Height="65px" Width="227px" ></asp:TextBox>
                </td>
                <td style="width: 96px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 105px">Adecuada</td>
                <td colspan="2">Motivo</td>
                <td style="width: 96px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 105px">
                    <asp:Label ID="Label57" runat="server" Visible="False"></asp:Label>
                    <asp:DropDownList ID="DropDownList12" runat="server" onchange="getvalue7();">
                        <asp:ListItem>--Seleccionar--</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                        <asp:ListItem>Si</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Label ID="Label58" runat="server" Visible="False"></asp:Label>
                    <asp:DropDownList ID="DropDownList13" runat="server" onchange="getvalue7();">
                        <asp:ListItem>--Seleccionar--</asp:ListItem>
                        <asp:ListItem>Grasas</asp:ListItem>
                        <asp:ListItem>Azucares</asp:ListItem>
                        <asp:ListItem>Irritantes</asp:ListItem>
                        <asp:ListItem>Condimentos</asp:ListItem>
                        <asp:ListItem>Alcohol</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Label ID="Label59" runat="server" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox32" runat="server" TextMode="MultiLine" Height="65px" Width="227px" ></asp:TextBox>
                </td>
                <td style="width: 96px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 105px">Suficiente</td>
                <td>Motivo</td>
                <td>&nbsp;</td>
                <td style="width: 96px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 105px">
                    <asp:Label ID="Label60" runat="server" Visible="False"></asp:Label>
                    <asp:DropDownList ID="DropDownList14" runat="server" onchange="getvalue7();">
                        <asp:ListItem>--Seleccionar--</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                        <asp:ListItem>Si</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Label ID="Label61" runat="server" Visible="False"></asp:Label>
                    <asp:DropDownList ID="DropDownList15" runat="server" onchange="getvalue7();">
                        <asp:ListItem>--Seleccionar--</asp:ListItem>
                        <asp:ListItem>Deficiente</asp:ListItem>
                        <asp:ListItem>Exceso</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Label ID="Label62" runat="server" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox33" runat="server" TextMode="MultiLine" Height="65px" Width="227px" ></asp:TextBox>
                </td>
                <td style="width: 96px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 105px">Inocua</td>
                <td colspan="2">Motivo</td>
                <td style="width: 96px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 105px">
                    <asp:Label ID="Label63" runat="server" Visible="False"></asp:Label>
                    <asp:DropDownList ID="DropDownList16" runat="server" onchange="getvalue7();">
                        <asp:ListItem>--Seleccionar--</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                        <asp:ListItem>Si</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td colspan="2">
                    <asp:Label ID="Label64" runat="server" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox34" runat="server" TextMode="MultiLine" Height="65px" Width="227px" ></asp:TextBox>
                </td>
                <td style="width: 96px">&nbsp;</td>
            </tr>
        </table>
        <br />
        <h3>Diagnóstico Nutricional</h3>
        <hr />
        <table style="width: 100%;" id="tablaenc13">
            <tr>
                <td>
                    <asp:Label ID="Label65" runat="server" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox35" runat="server" TextMode="MultiLine" Height="65px" Width="659px" ></asp:TextBox>
                </td>
            </tr>
            </table>
        <br />
        <h3>Objetivo Tratamiento </h3>
        <hr />
         <table style="width: 100%;" id="tablaenc14">
            <tr>
                <td>
                    <asp:Label ID="Label66" runat="server" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox36" runat="server" TextMode="MultiLine" Height="65px" Width="659px" ></asp:TextBox>
                </td>
            </tr>
            </table>
        <br />
        <h3>Tratamiento Nutricional</h3>
        <hr />
         <table style="width: 100%;" id="tablaenc15">
            <tr>
                <td>
                    <asp:Label ID="Label67" runat="server" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox37" runat="server" TextMode="MultiLine" Height="65px" Width="659px" ></asp:TextBox>
                </td>
            </tr>
            </table>
        <br />
            </div>
        </div>
             <asp:Button ID="exportar" runat="server" Text="Exportar a PDF" Height="32px" Width="114px" />
            </div>
        
       
        
    
    </div>
    </form>
</body>
</html>
