<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Pacientes/ControlPacientes.master" CodeBehind="modificahistora.aspx.vb" Inherits="ClinicaGastro.modificahistora" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContenidoPAcientes" runat="server">
    
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
   
     <asp:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="2" Width="1158px" Height="6150px" CssClass="Tab" >
        <asp:TabPanel ID="TabPanel1" runat="server" HeaderText="Historial Clínico">
            
            <ContentTemplate>
                <br />
                <asp:Menu ID="Menu2" runat="server" Orientation="Horizontal"><Items>
<asp:MenuItem  Text="Editar Historial" Value="Editar Historial"></asp:MenuItem>
<asp:MenuItem Text="|" Enabled="False" Selectable="False" Value="|"></asp:MenuItem>
<asp:MenuItem Text="Exportar PDF" Value="Exportar PDF"></asp:MenuItem>
<asp:MenuItem Text="|" Enabled="False" Selectable="False" Value="|"></asp:MenuItem>
<asp:MenuItem Text="Eliminar" Value="Eliminar"></asp:MenuItem>
<asp:MenuItem Text="|" Enabled="False" Selectable="False" Value="|"></asp:MenuItem>
<asp:MenuItem Text="Regresar" Value="Regresar" NavigateUrl="/Pacientes/ListaPacientes.aspx"></asp:MenuItem>
</Items>
</asp:Menu>


                <h2>Datos personales - Expediente <asp:Label ID="Label1" runat="server"></asp:Label>

                </h2>
                <br />
                <hr />
                <table style="width: 90%;" id="tablaenc1">
                    <tr>
                        <td style="width: 248px" class="textgral" >Nombre: 
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                        </td>
                        <td style="width: 108px"></td>
                        <td style="width: 329px" class="textgral" >Apellido Paterno: 
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

                        </td>
                        <td style="width: 313px" class="textgral" >Apellido Materno: 
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td style="width: 248px" class="textgral" >Genero: <asp:Label ID="Label9" runat="server" CssClass="txtlbl" ></asp:Label>

                        </td>
                        <td style="width: 108px" class="textgral" >Edad: <asp:Label ID="Label10" runat="server" CssClass="txtlbl" ></asp:Label>

                        </td>
                        <td style="width: 329px" class="textgral" >Teléfono Principal:<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>

                        </td>
                        <td style="width: 313px" class="textgral" >Teléfono Secundario:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td style="width: 248px" class="textgral" rowspan="2" >Dirección, calle y número: 
                            <asp:TextBox ID="TextBox6" runat="server" TextMode="MultiLine" Height="50px" Width="193px" AutoPostBack="True" ></asp:TextBox>

                        </td>
                        <td style="width: 108px" rowspan="2"></td>
                        <td style="width: 329px" class="textgral" >Delegación/Municipio:
                            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>

                            &nbsp;<br /> 
                        </td>
                        <td style="width: 313px" class="textgral" >Estado<br />
                            <asp:TextBox ID="TextBox49" runat="server"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td class="textgral" style="width: 329px">País:&nbsp;<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>

                        </td>
                        <td class="textgral" style="width: 313px">Familiar responsable (parentesco):
                            <asp:TextBox ID="TextBox9" runat="server" Width="332px"></asp:TextBox>

                        </td>
                    </tr>
                </table>

                <h2>Padecimiento Actual</h2>
               
                <hr />
                 <br />
                <table style="width: 90%;" id="tablaenc2">
                    <tr>
                        <td>
                            <asp:TextBox ID="TextBox10" runat="server" TextMode="MultiLine" Height="58px" Width="667px" AutoPostBack="True"></asp:TextBox>

                        </td>
                    </tr>
                </table>
                <h2>Antecedentes Heredofamiliares</h2>
                <hr />
                <table style="width: 90%;" id="tablaenc3">
                    <tr>
                        <td class="textgral" style="width: 494px" >Diarrea Reciente</td>
                        <td class="textgral" >Hernias</td>
                        <td class="textgral" >Cáncer</td>
                        <td class="textgral" >Estreñimiento</td>
                    </tr>
                    <tr>
                        <td style="width: 494px">
                            <asp:DropDownList ID="DropDownList1" runat="server"><asp:ListItem>Ninguno</asp:ListItem>
<asp:ListItem>Abuelos</asp:ListItem>
<asp:ListItem>Padres</asp:ListItem>
<asp:ListItem>Hermanos</asp:ListItem>
<asp:ListItem>Hijos</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList2" runat="server"><asp:ListItem>Ninguno</asp:ListItem>
<asp:ListItem>Abuelos</asp:ListItem>
<asp:ListItem>Padres</asp:ListItem>
<asp:ListItem>Hermanos</asp:ListItem>
<asp:ListItem>Hijos</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList3" runat="server"><asp:ListItem>Ninguno</asp:ListItem>
<asp:ListItem>Abuelos</asp:ListItem>
<asp:ListItem>Padres</asp:ListItem>
<asp:ListItem>Hermanos</asp:ListItem>
<asp:ListItem>Hijos</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList4" runat="server"><asp:ListItem>Ninguno</asp:ListItem>
<asp:ListItem>Abuelos</asp:ListItem>
<asp:ListItem>Padres</asp:ListItem>
<asp:ListItem>Hermanos</asp:ListItem>
<asp:ListItem>Hijos</asp:ListItem>
</asp:DropDownList>

                        </td>
                    </tr>
                    <tr>
                        <td class="textgral" style="width: 494px" >Cáncer en tubo digestivo</td>
                        <td class="textgral" >Colecistitis Litiástica</td>
                        <td class="textgral" >Hipertensión</td>
                        <td class="textgral" >Cardiopatía Isquémica</td>
                    </tr>
                    <tr>
                        <td style="width: 494px">
                            <asp:DropDownList ID="DropDownList8" runat="server"><asp:ListItem>Ninguno</asp:ListItem>
<asp:ListItem>Abuelos</asp:ListItem>
<asp:ListItem>Padres</asp:ListItem>
<asp:ListItem>Hermanos</asp:ListItem>
<asp:ListItem>Hijos</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList7" runat="server"><asp:ListItem>Ninguno</asp:ListItem>
<asp:ListItem>Abuelos</asp:ListItem>
<asp:ListItem>Padres</asp:ListItem>
<asp:ListItem>Hermanos</asp:ListItem>
<asp:ListItem>Hijos</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList6" runat="server"><asp:ListItem>Ninguno</asp:ListItem>
<asp:ListItem>Abuelos</asp:ListItem>
<asp:ListItem>Padres</asp:ListItem>
<asp:ListItem>Hermanos</asp:ListItem>
<asp:ListItem>Hijos</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList5" runat="server"><asp:ListItem>Ninguno</asp:ListItem>
<asp:ListItem>Abuelos</asp:ListItem>
<asp:ListItem>Padres</asp:ListItem>
<asp:ListItem>Hermanos</asp:ListItem>
<asp:ListItem>Hijos</asp:ListItem>
</asp:DropDownList>

                        </td>
                    </tr>
                    <tr>
                        <td class="textgral" style="width: 494px" >Enfermedades Autoinmunes</td>
                        <td class="textgral" >Diabetes Mellitus</td>
                        <td class="textgral" >Endocrinopatías</td>
                        <td class="textgral" >Otro</td>
                    </tr>
                    <tr>
                        <td style="width: 494px">
                            <asp:DropDownList ID="DropDownList9" runat="server"><asp:ListItem>Ninguno</asp:ListItem>
<asp:ListItem>Abuelos</asp:ListItem>
<asp:ListItem>Padres</asp:ListItem>
<asp:ListItem>Hermanos</asp:ListItem>
<asp:ListItem>Hijos</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList10" runat="server"><asp:ListItem>Ninguno</asp:ListItem>
<asp:ListItem>Abuelos</asp:ListItem>
<asp:ListItem>Padres</asp:ListItem>
<asp:ListItem>Hermanos</asp:ListItem>
<asp:ListItem>Hijos</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList11" runat="server"><asp:ListItem>Ninguno</asp:ListItem>
<asp:ListItem>Abuelos</asp:ListItem>
<asp:ListItem>Padres</asp:ListItem>
<asp:ListItem>Hermanos</asp:ListItem>
<asp:ListItem>Hijos</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td class="textgral" colspan="4" >Otra enfermedad<br /> (Padecimiento y familiar afectado)
                            <asp:TextBox ID="TextBox12" runat="server" Height="16px" Width="667px"></asp:TextBox>

                        </td>
                    </tr>
                </table>
                <br />
                <h2>Antecedentes Personales No Patológicos</h2>
                <hr />
                <table style="width: 90%;" id="tablaenc4">
                    <tr>
                        <td class="textgral" >Ocupación</td>
                        <td class="textgral" >Escolaridad</td>
                        <td class="textgral" >Actividad Física</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="TextBox13" runat="server" Width="339px"></asp:TextBox>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList12" runat="server"><asp:ListItem>Nula</asp:ListItem>
<asp:ListItem>Primaria</asp:ListItem>
<asp:ListItem>Secundaria</asp:ListItem>
<asp:ListItem>Preparatoria</asp:ListItem>
<asp:ListItem>Licenciatura/Carrera Tec.</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList13" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                    </tr>
                </table>
                <br />
                <h2>Antecedentes Personales Patológicos</h2>
                <hr />
                <table style="width: 90%;" id="tablaenc5">
                    <tr>
                        <td style="width: 142px" class="textgral" >Alérgicos</td>
                        <td>
                            <asp:DropDownList ID="DropDownList14" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                    </tr>
                    <tr>
                        <td style="width: 142px" class="textgral" >Descripción</td>
                        <td>
                            <asp:TextBox ID="TextBox14" runat="server" Height="67px" Width="667px" TextMode="MultiLine" ></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td style="width: 142px" class="textgral" >Cirugías Realizadas</td>
                        <td>
                            <asp:TextBox ID="TextBox15" runat="server" Width="667px"></asp:TextBox>

                        </td>
                    </tr>
                </table>
                <br />
                <h2>Quirúrgicos</h2>
                <hr />
                
                <table style="width: 90%; height: 192px;" id="tablaenc6">
                    <tr>
                        <td style="width: 160px" class="textgral" >Complicaciones</td>
                        <td>
                            <asp:TextBox ID="TextBox16" runat="server" Height="16px" Width="667px"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td style="width: 160px" class="textgral" >Transfusionales</td>
                        <td>
                            <asp:DropDownList ID="DropDownList15" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                    </tr>
                    <tr>
                        <td style="width: 160px" class="textgral" >Descripción</td>
                        <td>
                            <asp:TextBox ID="TextBox17" runat="server" Height="72px" Width="667px" TextMode="MultiLine" ></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td style="width: 160px" class="textgral" >Hemotipo</td>
                        <td>
                            <asp:DropDownList ID="DropDownList16" runat="server"><asp:ListItem>Desconocido</asp:ListItem>
<asp:ListItem>O+</asp:ListItem>
<asp:ListItem>O-</asp:ListItem>
<asp:ListItem>A+</asp:ListItem>
<asp:ListItem>A-</asp:ListItem>
<asp:ListItem>B+</asp:ListItem>
<asp:ListItem>B-</asp:ListItem>
<asp:ListItem>AB+</asp:ListItem>
<asp:ListItem>AB-</asp:ListItem>
</asp:DropDownList>

                        </td>
                    </tr>
                    <tr>
                        <td style="width: 160px" class="textgral" >Traumáticos</td>
                        <td>
                            <asp:DropDownList ID="DropDownList17" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                    </tr>
                    <tr>
                        <td style="width: 160px" class="textgral" >Descripción</td>
                        <td>
                            <asp:TextBox ID="TextBox18" runat="server" Height="72px" Width="630px" TextMode="MultiLine" ></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td style="width: 160px" class="textgral" >Hospitalizaciones Previas</td>
                        <td>
                            <asp:DropDownList ID="DropDownList18" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                    </tr>
                    <tr>
                        <td class="textgral" style="width: 160px">Descripción</td>
                        <td>
                            <asp:TextBox ID="TextBox19" runat="server" Height="72px" Width="630px" TextMode="MultiLine" ></asp:TextBox>

                        </td>
                    </tr>
                </table>
                <br />
                <h2>Enfermedades Crónico - Degenerativas</h2>
                <h4>Enfermedades, tiempo de evolución y tratamiento actual</h4>
                <hr />
                <table style="width: 90%;" id="tablaenc7">
                    <tr>
                        <td class="textgral" >Hipertensión Arterial</td>
                        <td class="textgral" >Insuficiencia Cardiaca</td>
                        <td class="textgral" >Cardiopatía Isquémica</td>
                        <td class="textgral" >EVC (Transitorio/Isquémico)</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="DropDownList19" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList20" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList21" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList22" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                    </tr>
                    <tr>
                        <td class="textgral" >Insuficiencia Venosa<br /> Periférica/Profunda</td>
                        <td class="textgral" >Diabetes Mellitus</td>
                        <td class="textgral" >Dislipidemmia</td>
                        <td class="textgral" >Obesidad</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="DropDownList23" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList24" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList25" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList26" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                    </tr>
                    <tr>
                        <td class="textgral" >Enfermedad Tiroidea</td>
                        <td class="textgral" >Cáncer</td>
                        <td class="textgral" >Tuberculosis</td>
                        <td class="textgral" >Asma</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="DropDownList30" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList29" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList28" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList27" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                    </tr>
                    <tr>
                        <td class="textgral" >EPOC</td>
                        <td class="textgral" >Bronquitis Crónica</td>
                        <td class="textgral" >Otros</td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="DropDownList31" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList32" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:TextBox ID="TextBox20" runat="server" Height="16px" Width="260px"></asp:TextBox>

                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td class="textgral" >Años de diagnóstico y tratamiento<br /> actual POR ENFERMEDAD</td>
                        <td>
                            <asp:TextBox ID="TextBox21" runat="server" Height="72px" Width="630px" TextMode="MultiLine" ></asp:TextBox>

                        </td>
                        <td></td>
                    </tr>
                </table>
                <br />
                <h2>Toxicomanias</h2>
                <hr />
                <table style="width: 90%;" id="tablaenc8">
                    <tr>
                        <td class="textgral" style="width: 242px" >Alcoholismo</td>
                        <td class="textgral" >Tabaquismo</td>
                        <td class="textgral" >Drogas y/o sust. Psicoactivas</td>
                    </tr>
                    <tr>
                        <td style="width: 242px">
                            <asp:DropDownList ID="DropDownList33" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList34" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList35" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                    </tr>
                    <tr>
                        <td class="textgral" style="width: 242px" >Otros</td>
                        <td colspan="2">
                            <asp:TextBox ID="TextBox22" runat="server" Height="18px" Width="667px"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td class="textgral" style="width: 242px" >Tiempo de Evolución /<br /> Consumo Promedio</td>
                        <td colspan="2">
                            <asp:TextBox ID="TextBox23" runat="server" Width="667px" TextMode="MultiLine" ></asp:TextBox>

                        </td>
                    </tr>
                </table>
                <br />
                <h2>Antecedentes Gineco-Obstétricos</h2>
                <hr />
                <table style="width: 90%;" id="tablaenc9">
                    <tr>
                        <td class="textgral" style="width: 491px" >Fecha de última regla (MM/dd/YYYY)</td>
                        <td class="textgral" style="width: 411px" >Ritmo</td>
                        <td colspan="2" class="textgral" >Menopausia</td>
                    </tr>
                    <tr>
                        <td style="width: 491px">
                            <asp:TextBox ID="TextBox24" runat="server" TextMode="Date" ></asp:TextBox>

                        </td>
                        <td style="width: 411px">
                            <asp:TextBox ID="TextBox25" runat="server" Width="208px"></asp:TextBox>

                        </td>
                        <td colspan="2">
                            <asp:DropDownList ID="DropDownList36" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

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
                            <asp:DropDownList ID="DropDownList37" runat="server"><asp:ListItem>0</asp:ListItem>
<asp:ListItem>1</asp:ListItem>
<asp:ListItem>2</asp:ListItem>
<asp:ListItem>3</asp:ListItem>
<asp:ListItem>4</asp:ListItem>
<asp:ListItem>5</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td style="width: 411px">
                            <asp:DropDownList ID="DropDownList38" runat="server"><asp:ListItem>0</asp:ListItem>
<asp:ListItem>1</asp:ListItem>
<asp:ListItem>2</asp:ListItem>
<asp:ListItem>3</asp:ListItem>
<asp:ListItem>4</asp:ListItem>
<asp:ListItem>5</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList39" runat="server"><asp:ListItem>0</asp:ListItem>
<asp:ListItem>1</asp:ListItem>
<asp:ListItem>2</asp:ListItem>
<asp:ListItem>3</asp:ListItem>
<asp:ListItem>4</asp:ListItem>
<asp:ListItem>5</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList40" runat="server"><asp:ListItem>0</asp:ListItem>
<asp:ListItem>1</asp:ListItem>
<asp:ListItem>2</asp:ListItem>
<asp:ListItem>3</asp:ListItem>
<asp:ListItem>4</asp:ListItem>
<asp:ListItem>5</asp:ListItem>
</asp:DropDownList>

                        </td>
                    </tr>
                    <tr>
                        <td class="textgral" style="width: 491px">Método de planificación familiar
                            <asp:DropDownList ID="DropDownList41" runat="server"><asp:ListItem>Ninguno</asp:ListItem>
<asp:ListItem>DIU</asp:ListItem>
<asp:ListItem>Pildoras Anticonceptivas</asp:ListItem>
<asp:ListItem>Parche</asp:ListItem>
<asp:ListItem>Implante Subdermico</asp:ListItem>
<asp:ListItem>Inyecciones Hormonales</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td class="textgral" style="width: 411px" >Otro
                            <asp:TextBox ID="TextBox26" runat="server" Width="298px"></asp:TextBox>

                        </td>
                        <td class="textgral"></td>
                        <td></td>
                    </tr>
                </table>
                <br />
                <h2>Interrogatorio por aparatos y sistemas</h2>
                <h4>Síntomas generales</h4>
                <hr />
                <table style="width: 90%;" id="tablaenc10">
                    <tr>
                        <td class="textgral">Fiebre</td>
                        <td class="textgral">Astenia</td>
                        <td class="textgral">Adinamia</td>
                        <td class="textgral">Anorexia</td>
                        <td class="textgral">Pérdida de peso (+ de 10 Kg en menos de 3 meses)</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="DropDownList42" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList43" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList44" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList45" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList46" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                    </tr>
                    <tr>
                        <td class="textgral">Tiempo de evolución,<br /> cuantificación,<br /> predominio</td>
                        <td colspan="4">
                            <asp:TextBox ID="TextBox27" runat="server" TextMode="MultiLine" Width="667px" Height="51px" ></asp:TextBox>

                        </td>
                    </tr>
                    </table>
                <h4>Respiratorio</h4>
                <table style="width: 90%;" id="tablaenc30">
                    <tr>
                        <td class="textgral">Obstrucción Nasal</td>
                        <td class="textgral">Ronquera Matutina</td>
                        <td class="textgral">Sinusitis Matutina</td>
                        <td class="textgral">Disfonía</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="DropDownList47" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList48" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList49" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList50" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                    </tr>
                    <tr>
                        <td class="textgral">Disnea</td>
                        <td class="textgral">Sibilancias Audibles</td>
                        <td class="textgral">Tos</td>
                        <td class="textgral">Cianosis</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="DropDownList51" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList52" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList53" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList54" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                    </tr>
                    <tr>
                        <td class="textgral">Asma (exacerbaciones)</td>
                        <td class="textgral">Tipo de evolución, predominio</td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="DropDownList55" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:TextBox ID="TextBox28" runat="server" Width="291px"></asp:TextBox>

                        </td>
                        <td></td>
                        <td></td>
                    </tr>
                </table>
                <h4>Cardiovascular</h4>
                <table style="width: 90%;" id="tablaenc11">
                    <tr>
                        <td class="textgral">Lipotimia</td>
                        <td class="textgral" style="width: 507px">Síncope</td>
                        <td class="textgral">Fatiga</td>
                        <td class="textgral">Palpitaciones</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="DropDownList56" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td style="width: 507px">
                            <asp:DropDownList ID="DropDownList57" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList58" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList59" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                    </tr>
                    <tr>
                        <td class="textgral">Dolor precordial</td>
                        <td class="textgral" style="width: 507px">Edema</td>
                        <td class="textgral">Disnea paroxístrica nocturna</td>
                        <td class="textgral">Ascitis</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="DropDownList60" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td style="width: 507px">
                            <asp:DropDownList ID="DropDownList61" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList62" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList63" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td class="textgral" style="width: 507px">Tipo de evolución,<br /> predominio,semiología&nbsp;
                            <asp:TextBox ID="TextBox29" runat="server" Height="30px" Width="241px" TextMode="MultiLine" ></asp:TextBox>

                        </td>
                        <td></td>
                        <td></td>
                    </tr>
                </table>
                <br />
                <h4>Digestivo</h4>
                <hr />
                <table style="width: 90%;" id="tablaenc12">
                    <tr>
                        <td class="textgral">1. ¿Con qué frecuencia presenta sensación de ardor retroesternal (pirosis)?</td>
                        <td class="textgral">4. ¿Con qué frecuencia ha presentado nausea?</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="DropDownList64" runat="server"><asp:ListItem>0 días</asp:ListItem>
<asp:ListItem>1 día</asp:ListItem>
<asp:ListItem>2 - 3 días</asp:ListItem>
<asp:ListItem>4 - 7 días</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList65" runat="server"><asp:ListItem>0 días</asp:ListItem>
<asp:ListItem>1 día</asp:ListItem>
<asp:ListItem>2 - 3 días</asp:ListItem>
<asp:ListItem>4 - 7 días</asp:ListItem>
</asp:DropDownList>

                        </td>
                    </tr>
                    <tr>
                        <td class="textgral">2. ¿Con qué frecuencia se regresa la comida o líquidos a la garganta o boca (regurgitación)?</td>
                        <td class="textgral">5. ¿Con qué frecuencia la pirosis o regurgitación le dificultan dormir por las noches?</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="DropDownList66" runat="server"><asp:ListItem>0 días</asp:ListItem>
<asp:ListItem>1 día</asp:ListItem>
<asp:ListItem>2 - 3 días</asp:ListItem>
<asp:ListItem>4 - 7 días</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList67" runat="server"><asp:ListItem>0 días</asp:ListItem>
<asp:ListItem>1 día</asp:ListItem>
<asp:ListItem>2 - 3 días</asp:ListItem>
<asp:ListItem>4 - 7 días</asp:ListItem>
</asp:DropDownList>

                        </td>
                    </tr>
                    <tr>
                        <td class="textgral">3. ¿Con qué frecuencia tiene dolor en la boca del estómago? (Epigastrio)</td>
                        <td class="textgral">6. ¿Con qué frecuencia toma algún medicamento adicional para la pirosis/regurgitación distinto al que su médico le recetó?</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="DropDownList68" runat="server"><asp:ListItem>0 días</asp:ListItem>
<asp:ListItem>1 día</asp:ListItem>
<asp:ListItem>2 - 3 días</asp:ListItem>
<asp:ListItem>4 - 7 días</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList116" runat="server"><asp:ListItem>0 días</asp:ListItem>
<asp:ListItem>1 día</asp:ListItem>
<asp:ListItem>2 - 3 días</asp:ListItem>
<asp:ListItem>4 - 7 días</asp:ListItem>
</asp:DropDownList>

                            </td>
                    </tr>
                    <tr>
                        <td class="textgral">Puntaje
                            <asp:Label ID="Label107" runat="server" CssClass="txtlbl"></asp:Label>

                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td class="textgral">Probabilidad ERGE %
                            <asp:Label ID="Label108" runat="server" CssClass="txtlbl"></asp:Label>

                        </td>
                        <td></td>
                    </tr>
                </table>
                <br />
                <h2>SX de intestino irritable</h2>
                <hr />
                <table style="width: 90%;" id="tablaenc13">
                    <tr>
                        <td class="textgral">Dolor o discomfort abdominal(sensación abdominal no descrita como dolor) por lo menos 3 dias/mes en los últimos 3 meses</td>
                        <td class="textgral">Síntomas asociadosa cambio en frecuencia de evacuaciones</td>
                        <td class="textgral">Sintomas asociados a cambio en forma/apariencia/consistencia de las heces</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="DropDownList69" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList70" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList71" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                    </tr>
                    <tr>
                        <td class="textgral">Mejoría con defecación</td>
                        <td class="textgral">Disfagia</td>
                        <td class="textgral">Inicio de Síntomas</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="DropDownList72" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList73" runat="server"><asp:ListItem>Negada</asp:ListItem>
<asp:ListItem>Sólidos</asp:ListItem>
<asp:ListItem>Líquidos</asp:ListItem>
<asp:ListItem>Progresiva</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:TextBox ID="TextBox30" runat="server" Width="303px"></asp:TextBox>

                        </td>
                    </tr>
                </table>
                <br />
                <h2>Transtornos de Motilidad Esofágica</h2>
                <hr />
                <table style="width: 90%;" id="tablaenc14">
                    <tr>
                        <td class="textgral">Regurgitación de alimentos solidos/no Digeridos</td>
                        <td class="textgral">Pirosis</td>
                        <td class="textgral">Dolor Epigástrico</td>
                        <td class="textgral">Vómito</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="DropDownList74" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList75" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList76" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList77" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                    </tr>
                    <tr>
                        <td class="textgral">Hematemesis</td>
                        <td class="textgral">Náusea</td>
                        <td class="textgral">Globus</td>
                        <td class="textgral">Dolor Abdominal</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="DropDownList78" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList79" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList80" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList81" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                    </tr>
                    <tr>
                        <td class="textgral">Colitis</td>
                        <td class="textgral">Meteorismo</td>
                        <td class="textgral">Anorexia TransEsof</td>
                        <td class="textgral">Ictericia</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="DropDownList82" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList83" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList84" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList85" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                    </tr>
                    <tr>
                        <td class="textgral" colspan="4">Inicio de Síntomas
                            <asp:TextBox ID="TextBox31" runat="server" Height="16px" Width="667px"></asp:TextBox>

                        </td>
                    </tr>
                </table>
                <br />
                <h2>Otros</h2>
                <hr />
                <table style="width: 90%;" id="tablaenc15">
                    <tr>
                        <td class="textgral">Disuria</td>
                        <td class="textgral">Polaquiuria</td>
                        <td class="textgral" style="width: 370px">Tenesmo Vesical</td>
                        <td class="textgral">Hematuria</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="DropDownList86" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList87" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td style="width: 370px">
                            <asp:DropDownList ID="DropDownList88" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList89" runat="server"><asp:ListItem>No</asp:ListItem>
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
                            <asp:DropDownList ID="DropDownList90" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList91" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td style="width: 370px">
                            <asp:DropDownList ID="DropDownList92" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:TextBox ID="TextBox32" runat="server" Height="16px" Width="228px"></asp:TextBox>

                        </td>
                    </tr>
                </table>
                <br />
                <h2>Hemolinfático</h2>
                <hr />
                <table style="width: 90%;" id="tablaenc16">
                    <tr>
                        <td class="textgral">Tendencia a hemorragia</td>
                        <td class="textgral">Adenopatías</td>
                        <td class="textgral">Infecciones recurrentes</td>
                        <td class="textgral">Anemia</td>
                        <td class="textgral">Negado</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="DropDownList93" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList94" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList95" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList96" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList97" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                    </tr>
                    <tr>
                        <td class="textgral" colspan="5">Otros
                            <asp:TextBox ID="TextBox33" runat="server" Width="667px"></asp:TextBox>

                        </td>
                    </tr>
                </table>
                <br />
                <h2>Sistema Nervioso</h2>
                <hr />
                <table style="width: 90%;" id="tablaenc17">
                    <tr>
                        <td class="textgral">Parálisis</td>
                        <td class="textgral">Parestesias</td>
                        <td class="textgral">Temblores</td>
                        <td class="textgral">Alteraciones de la marcha</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="DropDownList98" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList99" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList100" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList101" runat="server"><asp:ListItem>No</asp:ListItem>
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
                            <asp:DropDownList ID="DropDownList102" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList103" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td colspan="2">
                            <asp:TextBox ID="TextBox34" runat="server" Width="266px"></asp:TextBox>

                        </td>
                    </tr>
                </table>
                <br />
                <h2>Transtornos Psico-Afectivos</h2>
                <hr />
                <table style="width: 90%;" id="tablaenc18">
                    <tr>
                        <td class="textgral">Ansiedad</td>
                        <td class="textgral">Angustia</td>
                        <td class="textgral">Nerviosismo</td>
                        <td class="textgral">Irritabilidad</td>
                        <td class="textgral">Llanto friable</td>
                        <td class="textgral">Insomnio</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="DropDownList104" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList105" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList106" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList107" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList108" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList109" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                    </tr>
                </table>
                <br />
                <h2>Exploración Física</h2>
                <h4>Somatometría</h4>
                <hr />
                <table style="width: 90%;" id="tablaenc19">
                    <tr>
                        <td class="textgral">Talla(m)</td>
                        <td class="textgral">Peso (kg)</td>
                        <td class="textgral">IMC</td>
                        <td class="textgral">Temperatura</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="TextBox35" runat="server" Width="200px"></asp:TextBox>

                        </td>
                        <td>
                            <asp:TextBox ID="TextBox36" runat="server" Width="200px"></asp:TextBox>

                        </td>
                        <td>
                            <asp:Label ID="Label157" runat="server" CssClass="txtlbl"></asp:Label>

                        </td>
                        <td>
                            <asp:TextBox ID="TextBox37" runat="server" Width="200px"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td class="textgral">Frecuencia Cardiaca</td>
                        <td class="textgral">Frecuencia Respiratoria</td>
                        <td class="textgral">Tensión Arterial</td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="TextBox38" runat="server" Width="200px"></asp:TextBox>

                        </td>
                        <td>
                            <asp:TextBox ID="TextBox39" runat="server" Width="200px"></asp:TextBox>

                        </td>
                        <td>
                            <asp:TextBox ID="TextBox40" runat="server" Width="200px"></asp:TextBox>

                        </td>
                        <td></td>
                    </tr>
                </table>
                <h4>Habitus Exterior</h4>
                <table style="width: 90%;" id="tablaenc20">
                    <tr>
                        <td style="width: 329px" class="textgral">Estado de&nbsp; consciencia, Fascies, Actitud, Tegumentos, Edad Cronológica, Orientación, Movimientos Anormales, Estado anímico</td>
                        <td>
                            <asp:TextBox ID="TextBox41" runat="server" Height="51px" TextMode="MultiLine" Width="667px"></asp:TextBox>

                        </td>
                       
                    </tr>
                   
                </table>

                <h4>Cabeza y Cuello</h4>
                <table style="width: 90%;" id="tablaenc21">
                    <tr>
                        <td style="width: 330px" class="textgral">Pares Craneales, Estado de mucosas, Faringe, Dentadura, Adenomegalias, Nodulaciones tiroideas</td>
                        <td>
                            <asp:TextBox ID="TextBox42" runat="server" Height="51px" TextMode="MultiLine" Width="667px"></asp:TextBox>

                        </td>
                    </tr>
                </table>
                <h4>Torax</h4>
                <table style="width: 90%;" id="tablaenc22">
                    <tr>
                        <td style="width: 330px" class="textgral">Forma, Movimientos, Entrada y salida de aire, Ruidos cardiacos (soplos, intensidad, tono, frecuencia), fenómenos agregados</td>
                        <td>
                            <asp:TextBox ID="TextBox43" runat="server" Height="51px" TextMode="MultiLine" Width="667px"></asp:TextBox>

                        </td>
                    </tr>
                </table>
                <h4>Abdomen</h4>
                <table style="width: 90%;" id="tablaenc23">
                    <tr>
                        <td style="width: 332px" class="textgral">Forma, Volumen, Red Venosa, Pigmentación, Ascitis, Reflejos Cutáneos,Resistencia, Dolor a la palpacion, Murphy, Puntos Uretrales, Puntos Pancreáticos,Signos</td>
                        <td>
                            <asp:TextBox ID="TextBox44" runat="server" Height="51px" TextMode="MultiLine" Width="667px"></asp:TextBox>

                        </td>
                    </tr>
                </table>
                <h4>Extremidades</h4>
                <table style="width: 90%;" id="tablaenc24" >
                    <tr>
                        <td style="width: 335px" class="textgral">Simetría, Morfología, Edema, Arcos de movilidad, Reflejos, Fuerza Muscular, Insuficiencia Venosa</td>
                        <td>
                            <asp:TextBox ID="TextBox45" runat="server" Height="51px" TextMode="MultiLine" Width="667px"></asp:TextBox>

                        </td>
                    </tr>
                </table>
                <h4>Neurológico</h4>
                <table style="width: 90%;" id="tablaenc25">
                    <tr>
                        <td style="width: 336px" class="textgral">Razonamiento, Atención, Trastornos del habla, Funciones mentales superiores,Funciones motoras involuntarias, Paresias, Parálisis, Marcha</td>
                        <td>
                            <asp:TextBox ID="TextBox46" runat="server" Height="51px" TextMode="MultiLine" Width="667px"></asp:TextBox>

                        </td>
                    </tr>
                </table>
                <br />
                <h2>Análisis (Diagnósticos Sindromáticos)</h2>
                <hr />
                <table style="width: 190%;" id="tablaenc26">
                    <tr>
                        <td>
                            <asp:TextBox ID="TextBox47" runat="server" Height="51px" TextMode="MultiLine" Width="667px"></asp:TextBox>

                        </td>
                    </tr>
                </table>
                <br />
                <h2>Impresión Diagnóstica</h2>
                <hr />
                <table style="width: 90%;" id="tablaenc27">
                    <tr>
                        <td>
                            <asp:TextBox ID="TextBox48" runat="server" Height="51px" TextMode="MultiLine" Width="667px"></asp:TextBox>

                        </td>
                    </tr>
                </table>
                <br />
                <h2>Plan</h2>
                <hr />
                <table style="width: 90%;" id="tablaenc28">
                    <tr>
                        <td class="textgral">Envío a Médico Gastro Clínico</td>
                        <td class="textgral">Envío a Nutrición</td>
                        <td class="textgral">Estudios Complementarios</td>
                        <td class="textgral">Envió a Psicología</td>
                        <td class="textgral">Medicina General</td>
                        <td class="textgral">Envío a Cirugía</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="DropDownList110" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList111" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList112" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList113" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList114" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList115" runat="server"><asp:ListItem>No</asp:ListItem>
<asp:ListItem>Si</asp:ListItem>
</asp:DropDownList>

                        </td>
                    </tr>
                </table>
                <br />
                <h2>Médico</h2>
                <hr />
                <table style="width: 90%;" id="tablaenc29">
                    <tr>
                        <td class="textgral">Fecha de Modificación</td>
                        <td class="textgral">Capturó</td>
                        <td class="textgral">Cédula Profesional</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label176" runat="server" CssClass="txtlbl"></asp:Label>

                        </td>
                        <td>
                            <asp:Label ID="Label177" runat="server" CssClass="txtlbl"></asp:Label>

                        </td>
                        <td>
                            <asp:Label ID="Label178" runat="server" CssClass="txtlbl"></asp:Label>

                            
                        </td>
                    </tr>
                </table>
                <br />
                <asp:Button ID="Button1" runat="server" Text="Editar" />

            
</ContentTemplate>
            
        
</asp:TabPanel>
        <asp:TabPanel ID="TabPanel2" runat="server" HeaderText="Notas">

        </asp:TabPanel>
        <asp:TabPanel ID="TabPanel3" runat="server" HeaderText="GSRS">

        </asp:TabPanel>
    </asp:TabContainer>
</asp:Content>
