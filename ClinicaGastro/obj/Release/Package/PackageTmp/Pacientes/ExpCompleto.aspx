<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Pacientes/ControlPacientes.master" CodeBehind="ExpCompleto.aspx.vb" Inherits="ClinicaGastro.ExpCompleto" runat="server" EnableEventValidation="false"%>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContenidoPAcientes" runat="server">
    
    
   <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
   <div id="exportar" runat="server" >
     <asp:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="1" Width="1158px" Height="5351px" CssClass="Tab" >
        <asp:TabPanel ID="TabPanel1" runat="server" HeaderText="Historial Clínico">
            
            <ContentTemplate >
                

                <br />
                

                <asp:Menu ID="Menu2" runat="server" Orientation="Horizontal"><Items>
                    
<asp:MenuItem  Text="Editar Historial" Value="Editar Historial" NavigateUrl="~/Pacientes/modificahistora.aspx" ></asp:MenuItem>
                    
<asp:MenuItem Text="|" Enabled="False" Selectable="False" Value="|"></asp:MenuItem>
                    
<asp:MenuItem Text="Exportar PDF" Value="Exportar PDF" ></asp:MenuItem>
                    
<asp:MenuItem Text="|" Enabled="False" Selectable="False" Value="|"></asp:MenuItem>
                    
<asp:MenuItem Text="Eliminar" Value="Eliminar" ></asp:MenuItem>
                    
<asp:MenuItem Text="|" Enabled="False" Selectable="False" Value="|"></asp:MenuItem>
                    
<asp:MenuItem Text="Regresar" Value="Regresar" NavigateUrl="~/Pacientes/ListaPacientes.aspx"></asp:MenuItem>
                    
</Items>
                    
</asp:Menu>


                





                <h2>Datos personales - Expediente <asp:Label ID="Label1" runat="server"></asp:Label>

                    



                </h2>
                

                <br />
                

                <hr />
                

                <table style="width: 90%;" id="tablaenc1" runat="server" ><tr runat="server"><td style="width: 248px" class="textgral" runat="server" >Nombre: <asp:Label ID="Label2" runat="server" CssClass="txtlbl" ></asp:Label>

                        



                        </td>
                    
<td style="width: 108px" runat="server"></td>
                    
<td style="width: 329px" class="textgral" runat="server" >Apellido Paterno: <asp:Label ID="Label14" runat="server" CssClass="txtlbl" ></asp:Label>

                        



                        </td>
                    
<td style="width: 313px" class="textgral" runat="server" >Apellido Materno: <asp:Label ID="Label13" runat="server" CssClass="txtlbl" ></asp:Label>

                        



                        </td>
                    
</tr>
                    
<tr runat="server"><td style="width: 248px" class="textgral" runat="server" >Genero: <asp:Label ID="Label9" runat="server" CssClass="txtlbl" ></asp:Label>

                        



                        </td>
    
<td style="width: 108px" class="textgral" runat="server" >Edad: <asp:Label ID="Label10" runat="server" CssClass="txtlbl" ></asp:Label>

                        



                        </td>
    
<td style="width: 329px" class="textgral" runat="server" >Teléfono Principal:<asp:Label ID="Label7" runat="server" CssClass="txtlbl" ></asp:Label>

                        



                        </td>
    
<td style="width: 313px" class="textgral" runat="server" >Teléfono Secundario:<asp:Label ID="Label8" runat="server" CssClass="txtlbl" ></asp:Label>

                        



                        </td>
    
</tr>
                    
<tr runat="server"><td style="width: 248px" class="textgral" runat="server" >Dirección, calle y número: <asp:Label ID="Label15" runat="server" CssClass="txtlbl" ></asp:Label>

                        



                        </td>
    
<td style="width: 108px" runat="server"></td>
    
<td style="width: 329px" class="textgral" runat="server" >Delegación/Municipio:

                            <asp:Label ID="Label19" runat="server" CssClass="txtlbl" ></asp:Label>

                            



                            &nbsp--;País:<asp:Label ID="Label20" runat="server" CssClass="txtlbl" ></asp:Label>

                        



                        </td>
    
<td style="width: 313px" class="textgral" runat="server" >Familiar responsable (parentesco):

                            <asp:Label ID="Label17" runat="server" CssClass="txtlbl" ></asp:Label>

                        



                        </td>
    
</tr>
                    
</table>


                





                <h2>Padecimiento Actual</h2>
               
                
 

               
                <hr />
                 

                 <br />
                

                <table style="width: 90%;" id="tablaenc2">
                    

                    <tr>
                        

                        <td>
                            

                            <asp:Label ID="Label18" runat="server"></asp:Label>

                            



                        </td>
                        

                    </tr>
                    

                </table>
                

                <h2>Antecedentes Heredofamiliares</h2>
                

                <hr />
                

                <table style="width: 90%;" id="tablaenc3">
                    

                    <tr>
                        

                        <td class="textgral" >Diarrea Reciente</td>
                        

                        <td class="textgral" >Hernias</td>
                        

                        <td class="textgral" >Cáncer</td>
                        

                        <td class="textgral" >Estreñimiento</td>
                        

                    </tr>
                    

                    <tr>
                        

                        <td>
                            

                            <asp:Label ID="Label21" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label22" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label23" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label24" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                    </tr>
                    

                    <tr>
                        

                        <td class="textgral" >Cáncer en tubo digestivo</td>
                        

                        <td class="textgral" >Colecistitis Litiástica</td>
                        

                        <td class="textgral" >Hipertensión</td>
                        

                        <td class="textgral" >Cardiopatía Isquémica</td>
                        

                    </tr>
                    

                    <tr>
                        

                        <td>
                            

                            <asp:Label ID="Label25" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label26" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label27" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label28" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                    </tr>
                    

                    <tr>
                        

                        <td class="textgral" >Enfermedades Autoinmunes</td>
                        

                        <td class="textgral" >Diabetes Mellitus</td>
                        

                        <td class="textgral" >Endocrinopatías</td>
                        

                        <td class="textgral" >Otro</td>
                        

                    </tr>
                    

                    <tr>
                        

                        <td>
                            

                            <asp:Label ID="Label29" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label30" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label31" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label32" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                    </tr>
                    

                    <tr>
                        

                        <td class="textgral" >Otra enfermedad<br /> (Padecimiento y familiar afectado)</td>
                        

                        <td colspan="3">
                            

                            <asp:Label ID="Label33" runat="server" CssClass="txtlbl"></asp:Label>

                            



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
                            

                            <asp:Label ID="Label34" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label35" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label36" runat="server" CssClass="txtlbl"></asp:Label>

                            



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
                            

                            <asp:Label ID="Label37" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                    </tr>
                    

                    <tr>
                        

                        <td style="width: 142px" class="textgral" >Descripción</td>
                        

                        <td>
                            

                            <asp:Label ID="Label38" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                    </tr>
                    

                    <tr>
                        

                        <td style="width: 142px" class="textgral" >Cirugías Realizadas</td>
                        

                        <td>
                            

                            <asp:Label ID="Label39" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                    </tr>
                    

                </table>
                

                <br />
                

                <h2>Quirúrgicos</h2>
                

                <hr />
                                

                                <table style="width: 90%;" id="tablaenc6">
                                    

                    <tr>
                        

                        <td style="width: 160px" class="textgral" >Complicaciones</td>
                        

                        <td>
                            

                            <asp:Label ID="Label180" runat="server"></asp:Label>

                            



                        </td>
                        

                    </tr>
                                    

                    <tr>
                        

                        <td style="width: 160px" class="textgral" >Transfusionales</td>
                        

                        <td>
                            

                            <asp:Label ID="Label40" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                    </tr>
                                    

                    <tr>
                        

                        <td style="width: 160px" class="textgral" >Descripción</td>
                        

                        <td>
                            

                            <asp:Label ID="Label41" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                    </tr>
                                    

                    <tr>
                        

                        <td style="width: 160px" class="textgral" >Hemotipo</td>
                        

                        <td>
                            

                            <asp:Label ID="Label42" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                    </tr>
                                    

                    <tr>
                        

                        <td style="width: 160px" class="textgral" >Traumáticos</td>
                        

                        <td>
                            

                            <asp:Label ID="Label43" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                    </tr>
                                    

                    <tr>
                        

                        <td style="width: 160px" class="textgral" >Descripción</td>
                        

                        <td>
                            

                            <asp:Label ID="Label44" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                    </tr>
                                    

                    <tr>
                        

                        <td style="width: 160px" class="textgral" >Hospitalizaciones Previas</td>
                        

                        <td>
                            

                            <asp:Label ID="Label45" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                    </tr>
                                    

                                    <tr>
                                        

                                        <td class="textgral" style="width: 160px">Descripción</td>
                                        

                                        <td>
                                            

                                            <asp:Label ID="Label179" runat="server"></asp:Label>

                                            



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
                            

                            <asp:Label ID="Label46" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label47" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label48" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label49" runat="server" CssClass="txtlbl"></asp:Label>

                            



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
                            

                            <asp:Label ID="Label50" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label51" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label52" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label53" runat="server" CssClass="txtlbl"></asp:Label>

                            



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
                            

                            <asp:Label ID="Label54" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label55" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label56" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label57" runat="server" CssClass="txtlbl"></asp:Label>

                            



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
                            

                            <asp:Label ID="Label58" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label59" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label60" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td></td>
                        

                    </tr>
                    

                    <tr>
                        

                        <td></td>
                        

                        <td class="textgral" >Años de diagnóstico y tratamiento<br /> actual POR ENFERMEDAD</td>
                        

                        <td>
                            

                            <asp:Label ID="Label61" runat="server" CssClass="txtlbl"></asp:Label>

                            



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
                            

                            <asp:Label ID="Label62" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label63" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label64" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                    </tr>
                    

                    <tr>
                        

                        <td class="textgral" style="width: 242px" >Otros</td>
                        

                        <td>
                            

                            <asp:Label ID="Label65" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td></td>
                        

                    </tr>
                    

                    <tr>
                        

                        <td class="textgral" style="width: 242px" >Tiempo de Evolución /<br /> Consumo Promedio</td>
                        

                        <td>
                            

                            <asp:Label ID="Label66" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td></td>
                        

                    </tr>
                    

                </table>
                

                <br />
                

                <h2>Antecedentes Gineco-Obstétricos</h2>
                

                <hr />
                

                <table style="width: 90%;" id="tablaenc9">
                    

                    <tr>
                        

                        <td class="textgral" >Fecha de última regla (MM/dd/YYYY)</td>
                        

                        <td class="textgral" >Ritmo</td>
                        

                        <td colspan="2" class="textgral" >Menopausia</td>
                        

                    </tr>
                    

                    <tr>
                        

                        <td>
                            

                            <asp:Label ID="Label67" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label68" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td colspan="2">
                            

                            <asp:Label ID="Label69" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                    </tr>
                    

                    <tr>
                        

                        <td class="textgral" >Gesta</td>
                        

                        <td class="textgral" >Para</td>
                        

                        <td class="textgral" >Cesárea</td>
                        

                        <td class="textgral">Aborto</td>
                        

                    </tr>
                    

                    <tr>
                        

                        <td>
                            

                            <asp:Label ID="Label70" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label71" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label72" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label73" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                    </tr>
                    

                    <tr>
                        

                        <td class="textgral">Método de planificación familiar

                            <asp:Label ID="Label74" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td></td>
                        

                        <td class="textgral">Otro

                            <asp:Label ID="Label75" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

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
                            

                            <asp:Label ID="Label76" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label77" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label78" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label79" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label80" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                    </tr>
                    

                    <tr>
                        

                        <td class="textgral">Tiempo de evolución,<br /> cuantificación,<br /> predominio</td>
                        

                        <td colspan="4">
                            

                            <asp:Label ID="Label81" runat="server" CssClass="txtlbl"></asp:Label>

                            



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
                            

                            <asp:Label ID="Label82" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label83" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label84" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label85" runat="server" CssClass="txtlbl"></asp:Label>

                            



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
                            

                            <asp:Label ID="Label86" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label87" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label88" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label89" runat="server" CssClass="txtlbl"></asp:Label>

                            



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
                            

                            <asp:Label ID="Label90" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label91" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td></td>
                        

                        <td></td>
                        

                    </tr>
                    

                </table>
                

                <h4>Cardiovascular</h4>
                

                <table style="width: 90%;" id="tablaenc11">
                    

                    <tr>
                        

                        <td class="textgral">Lipotimia</td>
                        

                        <td class="textgral">Síncope</td>
                        

                        <td class="textgral">Fatiga</td>
                        

                        <td class="textgral">Palpitaciones</td>
                        

                    </tr>
                    

                    <tr>
                        

                        <td>
                            

                            <asp:Label ID="Label92" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label93" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label94" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label95" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                    </tr>
                    

                    <tr>
                        

                        <td class="textgral">Dolor precordial</td>
                        

                        <td class="textgral">Edema</td>
                        

                        <td class="textgral">Disnea paroxístrica nocturna</td>
                        

                        <td class="textgral">Ascitis</td>
                        

                    </tr>
                    

                    <tr>
                        

                        <td>
                            

                            <asp:Label ID="Label96" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label97" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label98" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label99" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                    </tr>
                    

                    <tr>
                        

                        <td></td>
                        

                        <td class="textgral">Tipo de evolución,<br /> predominio,semiología

                            <asp:Label ID="Label100" runat="server" CssClass="txtlbl"></asp:Label>

                            



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
                            

                            <asp:Label ID="Label101" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label102" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                    </tr>
                    

                    <tr>
                        

                        <td class="textgral">2. ¿Con qué frecuencia se regresa la comida o líquidos a la garganta o boca (regurgitación)?</td>
                        

                        <td class="textgral">5. ¿Con qué frecuencia la pirosis o regurgitación le dificultan dormir por las noches?</td>
                        

                    </tr>
                    

                    <tr>
                        

                        <td>
                            

                            <asp:Label ID="Label103" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label104" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                    </tr>
                    

                    <tr>
                        

                        <td class="textgral">3. ¿Con qué frecuencia tiene dolor en la boca del estómago? (Epigastrio)</td>
                        

                        <td class="textgral">6. ¿Con qué frecuencia toma algún medicamento adicional para la pirosis/regurgitación distinto al que su médico le recetó?</td>
                        

                    </tr>
                    

                    <tr>
                        

                        <td>
                            

                            <asp:Label ID="Label105" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label106" runat="server" CssClass="txtlbl"></asp:Label>

                            



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
                            

                            <asp:Label ID="Label109" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label111" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label113" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                    </tr>
                    

                    <tr>
                        

                        <td class="textgral">Mejoría con defecación</td>
                        

                        <td class="textgral">Disfagia</td>
                        

                        <td class="textgral">Inicio de Síntomas</td>
                        

                    </tr>
                    

                    <tr>
                        

                        <td>
                            

                            <asp:Label ID="Label110" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label112" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label114" runat="server" CssClass="txtlbl"></asp:Label>

                            



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
                            

                            <asp:Label ID="Label115" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label116" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label117" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label118" runat="server" CssClass="txtlbl"></asp:Label>

                            



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
                            

                            <asp:Label ID="Label122" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label121" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label120" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label119" runat="server" CssClass="txtlbl"></asp:Label>

                            



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
                            

                            <asp:Label ID="Label123" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label124" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label125" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label126" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                    </tr>
                    

                    <tr>
                        

                        <td class="textgral">Inicio de Síntomas

                            <asp:Label ID="Label127" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td colspan="3"></td>
                        

                    </tr>
                    

                </table>
                

                <br />
                

                <h2>Otros</h2>
                

                <hr />
                

                <table style="width: 90%;" id="tablaenc15">
                    

                    <tr>
                        

                        <td class="textgral">Disuria</td>
                        

                        <td class="textgral">Polaquiuria</td>
                        

                        <td class="textgral">Tenesmo Vesical</td>
                        

                        <td class="textgral">Hematuria</td>
                        

                    </tr>
                    

                    <tr>
                        

                        <td>
                            

                            <asp:Label ID="Label128" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label129" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label130" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label131" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                    </tr>
                    

                    <tr>
                        

                        <td class="textgral">Dolor Suprapubica</td>
                        

                        <td class="textgral">Dolor Lumbar</td>
                        

                        <td class="textgral">Ninguno</td>
                        

                        <td class="textgral">Otros</td>
                        

                    </tr>
                    

                    <tr>
                        

                        <td>
                            

                            <asp:Label ID="Label132" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label133" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label134" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label135" runat="server" CssClass="txtlbl"></asp:Label>

                            



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
                            

                            <asp:Label ID="Label136" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label137" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label138" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label139" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label140" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                    </tr>
                    

                    <tr>
                        

                        <td class="textgral">Otros

                            <asp:Label ID="Label141" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td colspan="4"></td>
                        

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
                            

                            <asp:Label ID="Label142" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label143" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label144" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label145" runat="server" CssClass="txtlbl"></asp:Label>

                            



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
                            

                            <asp:Label ID="Label146" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label147" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label148" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td></td>
                        

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
                            

                            <asp:Label ID="Label149" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label150" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label151" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label152" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label153" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label154" runat="server" CssClass="txtlbl"></asp:Label>

                            



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
                            

                            <asp:Label ID="Label155" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label156" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label157" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label158" runat="server" CssClass="txtlbl"></asp:Label>

                            



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
                            

                            <asp:Label ID="Label159" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label160" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label161" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td></td>
                        

                    </tr>
                    

                </table>
                

                <h4>Habitus Exterior</h4>
                

                <table style="width: 90%;" id="tablaenc20">
                    

                    <tr>
                        

                        <td style="width: 329px" class="textgral">Estado de consciencia, Fascies, Actitud, Tegumentos, Edad Cronológica, Orientación, Movimientos Anormales, Estado anímico</td>
                        

                        <td>
                            

                            <asp:Label ID="Label162" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                       
                        
 

                       
                    </tr>
                   
                    
 

                   
                </table>

                



                <h4>Cabeza y Cuello</h4>
                

                <table style="width: 90%;" id="tablaenc21">
                    

                    <tr>
                        

                        <td style="width: 330px" class="textgral">Pares Craneales, Estado de mucosas, Faringe, Dentadura, Adenomegalias, Nodulaciones tiroideas</td>
                        

                        <td>
                            

                            <asp:Label ID="Label163" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                    </tr>
                    

                </table>
                

                <h4>Torax</h4>
                

                <table style="width: 90%;" id="tablaenc22">
                    

                    <tr>
                        

                        <td style="width: 330px" class="textgral">Forma, Movimientos, Entrada y salida de aire, Ruidos cardiacos (soplos, intensidad, tono, frecuencia), fenómenos agregados</td>
                        

                        <td>
                            

                            <asp:Label ID="Label164" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                    </tr>
                    

                </table>
                

                <h4>Abdomen</h4>
                

                <table style="width: 90%;" id="tablaenc23">
                    

                    <tr>
                        

                        <td style="width: 332px" class="textgral">Forma, Volumen, Red Venosa, Pigmentación, Ascitis, Reflejos Cutáneos,Resistencia, Dolor a la palpacion, Murphy, Puntos Uretrales, Puntos Pancreáticos,Signos</td>
                        

                        <td>
                            

                            <asp:Label ID="Label165" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                    </tr>
                    

                </table>
                

                <h4>Extremidades</h4>
                

                <table style="width: 90%;" id="tablaenc24" >
                    

                    <tr>
                        

                        <td style="width: 335px" class="textgral">Simetría, Morfología, Edema, Arcos de movilidad, Reflejos, Fuerza Muscular, Insuficiencia Venosa</td>
                        

                        <td>
                            

                            <asp:Label ID="Label166" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                    </tr>
                    

                </table>
                

                <h4>Neurológico</h4>
                

                <table style="width: 90%;" id="tablaenc25">
                    

                    <tr>
                        

                        <td style="width: 336px" class="textgral">Razonamiento, Atención, Trastornos del habla, Funciones mentales superiores,Funciones motoras involuntarias, Paresias, Parálisis, Marcha</td>
                        

                        <td>
                            

                            <asp:Label ID="Label167" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                    </tr>
                    

                </table>
                

                <br />
                

                <h2>Análisis (Diagnósticos Sindromáticos)</h2>
                

                <hr />
                

                <table style="width: 90%;" id="tablaenc26">
                    

                    <tr>
                        

                        <td>
                            

                            <asp:Label ID="Label168" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                    </tr>
                    

                </table>
                

                <br />
                

                <h2>Impresión Diagnóstica</h2>
                

                <hr />
                

                <table style="width: 90%;" id="tablaenc27">
                    

                    <tr>
                        

                        <td>
                            

                            <asp:Label ID="Label169" runat="server" CssClass="txtlbl"></asp:Label>

                            



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
                            

                            <asp:Label ID="Label170" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label171" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label172" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label173" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label174" runat="server" CssClass="txtlbl"></asp:Label>

                            



                        </td>
                        

                        <td>
                            

                            <asp:Label ID="Label175" runat="server" CssClass="txtlbl"></asp:Label>

                            



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
                    

                    <tr>
                        

                        <td>
                            

                            <asp:Button ID="btnExportasPDF" runat="server" Text="Exportar A PDF" OnClick="btnExportasPDF_Click"/>

                            



                        </td>
                        

                        <td>
                            

                            </td>
                        

                        <td>
                            

                            </td>
                        

                    </tr>
                    

                </table>
            
                
 
            
</ContentTemplate>
            
        

















            
</asp:TabPanel>
         
        <asp:TabPanel ID="TabPanel2" runat="server" HeaderText="Notas" >

            <ContentTemplate>
                
<asp:Menu ID="Menu3" runat="server" Orientation="Horizontal" >
    

    <Items>
        

        <asp:MenuItem Text="Nutrición" Value="Nutrición" NavigateUrl="~/Encuestas/Nnutricional.aspx"></asp:MenuItem>
        

        <asp:MenuItem Text="|" Enabled="False" Selectable="False" Value="|"></asp:MenuItem>
        

        <asp:MenuItem Text="Psicogastro" Value="Psicogastro" NavigateUrl="~/Encuestas/Psico.aspx"></asp:MenuItem>
        

        <asp:MenuItem Text="|" Enabled="False" Selectable="False" Value="|"></asp:MenuItem>
        

        <asp:MenuItem Text="Gastroquirúrgica" Value="Gastroquirúrgica" NavigateUrl="~/Encuestas/gastro.aspx"></asp:MenuItem>
        

    </Items>
    
</asp:Menu>
                
<br />
                
<asp:Label ID="Label187" runat="server" Text="Aún no existen notas relacionadas con el paciente"></asp:Label>
                
<br />
                
<br />
                
<asp:GridView ID="GridView1" runat="server" allowpaging="True" AutoGenerateColumns="False"  PageSize="15" CssClass="dgv" GridLines="Horizontal">
    

    <Columns>
        

        <asp:BoundField DataField="NoNota" HeaderText="No. Nota" ReadOnly="True" SortExpression="No.Nota" />
        

        <asp:BoundField DataField="Área" HeaderText="Área" ReadOnly="True" SortExpression="Área" />
        

        <asp:BoundField DataField="Médico" HeaderText="Médico" ReadOnly="True" SortExpression="Médico" />
        

        <asp:TemplateField>
            

            <ItemTemplate>
                

                <asp:HyperLink runat="server" ID="HyperLink1" NavigateUrl='<%# checkLink(Eval("Área")) + "?id=" & Eval("Nonota").ToString%>' Text="Consultar"></asp:HyperLink>
                

            </ItemTemplate>
            

        </asp:TemplateField>
        

        <asp:TemplateField >
            

            <ItemTemplate>
                

                <asp:HyperLink runat="server" ID="HyperLink3" NavigateUrl='<%# checkLink3(Eval("Área")) & "?id2=" & Eval("Nonota").ToString & "&pac=" & Label1.Text%>' Text="Modificar" ></asp:HyperLink>
                

            </ItemTemplate>
            

        </asp:TemplateField>
        

        <asp:TemplateField>
            

            <ItemTemplate>
                

                <asp:HyperLink runat="server" ID="HyperLink2" NavigateUrl='<%# checkLink2(Eval("Área")) & "?id2=" & Eval("Nonota").ToString & "&area=" & Eval("Área")%>' Text="Eliminar" ></asp:HyperLink>
                

            </ItemTemplate>
            

        </asp:TemplateField>
        

    </Columns>
    

    <HeaderStyle CssClass="headergdw"></HeaderStyle>
    

    <RowStyle CssClass="rows"></RowStyle>
    
</asp:GridView>
                
</ContentTemplate>

        

















            
</asp:TabPanel>
        <asp:TabPanel ID="TabPanel3" runat="server" HeaderText="GSRS" >
            
          <ContentTemplate>
              

              <br />
                

                <table style="width:100%;"><tr><td>Sx. Diarréico

                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    

                    </td>
                    
<td>
    

    <asp:Label ID="Label181" runat="server"></asp:Label>

                    



                    </td>
                    
</tr>
                    
<tr><td>Sx. Indigestión

    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    

    </td>
    
<td>
    

    <asp:Label ID="Label182" runat="server"></asp:Label>

                    



                    </td>
    
</tr>
                    
<tr><td>Sx. Constipación

    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    

    </td>
    
<td>
    

    <asp:Label ID="Label183" runat="server"></asp:Label>

                    



                    </td>
    
</tr>
                    
<tr><td>Sx. Dolor Abdominal

    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    

    </td>
    
<td>
    

    <asp:Label ID="Label184" runat="server"></asp:Label>

                    



                    </td>
    
</tr>
                    
<tr><td>Sx. Reflujo

    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    

    </td>
    
<td>
    

    <asp:Label ID="Label185" runat="server"></asp:Label>

                    



                    </td>
    
</tr>
                    
<tr><td>Puntaje Global GSRS

    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    

    </td>
    
<td>
    

    <asp:Label ID="Label186" runat="server"></asp:Label>

                    



                    </td>
    
</tr>
                    
</table>


                
              


 


                
</ContentTemplate>
        

            
</asp:TabPanel>
         <asp:TabPanel ID="TabPanel4" runat="server" HeaderText="Diagnósticos">
<ContentTemplate>
    
<asp:GridView ID="GridView2" runat="server" allowpaging="True" AutoGenerateColumns="False"  PageSize="15" CssClass="dgv" GridLines="Horizontal" onrowdatabound="OnRowDataBound">
    

    <columns>
        

        <asp:BoundField DataField="NoNota" HeaderText="No. Nota" ReadOnly="True" SortExpression="No.Nota" />
        

        <asp:BoundField DataField="Área" HeaderText="Área" ReadOnly="True" SortExpression="Área" />
        

        <asp:BoundField DataField="Médico" HeaderText="Médico" ReadOnly="True" SortExpression="Médico" />
        

        <asp:BoundField DataField="EstDiagnóstico" HeaderText="Estado Diagnóstico" ReadOnly="True" SortExpression="EstDiagnóstico" />
        

        <asp:TemplateField>
            

            <ItemTemplate>
                

                <asp:HyperLink runat="server" ID="HyperLink3" NavigateUrl='<%# estadodiagnostico(Eval("Área")) & "?id2=" & Eval("Nonota").ToString & "&area=" & Eval("Área")%>' Text="Modificar"></asp:HyperLink>
                

            </ItemTemplate>
            

        </asp:TemplateField>
        

    </columns>
    

    <HeaderStyle CssClass="headergdw"></HeaderStyle>
    

    <RowStyle CssClass="rows"></RowStyle>
    
</asp:GridView>
    
</ContentTemplate>
             
         </asp:TabPanel>
    </asp:TabContainer>
       </div>
</asp:Content>
