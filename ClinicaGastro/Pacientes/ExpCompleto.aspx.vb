Imports System.Data.SqlClient
Imports System.IO
Imports System.Data
Imports iTextSharp.text.pdf
Imports iTextSharp
Imports System.Drawing
Imports System.Windows.Forms.Layout
Imports System.Diagnostics
Imports iTextSharp.text
Imports iTextSharp.text.html.simpleparser
Imports PdfSharp
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf
Public Class ExpCompleto
    Inherits System.Web.UI.Page

    Private Sub ExpCompleto_Init(sender As Object, e As EventArgs) Handles Me.Init
        TabContainer1.ActiveTab = TabPanel1
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TabContainer1.ActiveTab = TabPanel1
        Dim nombre As String = Convert.ToString(Request.Params("Expediente"))
        If (Request.Params("Expediente") IsNot Nothing) Then
            Label1.Text = Request.Params("Expediente")
            Session("exped") = Label1.Text
            ConfigurationManager.AppSettings("expediente") = Request.Params("Expediente")
        End If
        Dim da, da1, da2, da3, da4, da5, da6, da7, da8, da9, da10, da11, da12, da13, da14, da15, da16, da17, da18, da19, da20, da21, da22, da23, da24, da25, da26, da27, da28, da29, da30, da31, da32, da33, da34, da35, da36, da37, da38, da39, da40, da41, da42, da43, da44, da45, da46, da47, da48, da49, da50, da51, da52, da53, da54, da55, da56, da57, da58, da59, da60, da61, da62, da63, da64, da65, da66, da67, da68, da69, da70, da71, da72, da73, da74, da75, da76, da77, da78, da79, da80, da81, da82, da83, da84, da85, da86, da87, da88, da89, da90, da91, da92, da93, da94, da95, da96, da97, da98, da99, da100, da101, da102, da103, da104, da105, da106, da107, da108, da109, da110, da111, da112, da113, da114, da115, da116, da117, da118, da119, da120, da121, da122, da123, da124, da125, da126, da127, da128, da129, da130, da131, da132, da133, da134, da135, da136, da137, da138, da139, da140, da141, da142, da143, da144, da145, da146, da147, da148, da149, da150, da151, da152, da153, da154, da155, da156, da157, da158, da159, da160, da161, da162, da163, da164, da165, da166, da167, da168, da169, da170, da171, da172, da173, da174, da175, da176, da177, da178, da179 As New SqlDataAdapter
        Dim dr, dr1, dr2, dr3, dr4, dr5, dr6, dr7, dr8, dr9, dr10, dr11, dr12, dr13, dr14, dr15, dr16, dr17, dr18, dr19, dr20, dr21, dr22, dr23, dr24, dr25, dr26, dr27, dr28, dr29, dr30, dr31, dr32, dr33, dr34, dr35, dr36, dr37, dr38, dr39, dr40, dr41, dr42, dr43, dr44, dr45, dr46, dr47, dr48, dr49, dr50, dr51, dr52, dr53, dr54, dr55, dr56, dr57, dr58, dr59, dr60, dr61, dr62, dr63, dr64, dr65, dr66, dr67, dr68, dr69, dr70, dr71, dr72, dr73, dr74, dr75, dr76, dr77, dr78, dr79, dr80, dr81, dr82, dr83, dr84, dr85, dr86, dr87, dr88, dr89, dr90, dr91, dr92, dr93, dr94, dr95, dr96, dr97, dr98, dr99, dr100, dr101, dr102, dr103, dr104, dr105, dr106, dr107, dr108, dr109, dr110, dr111, dr112, dr113, dr114, dr115, dr116, dr117, dr118, dr119, dr120, dr121, dr122, dr123, dr124, dr125, dr126, dr127, dr128, dr129, dr130, dr131, dr132, dr133, dr134, dr135, dr136, dr137, dr138, dr139, dr140, dr141, dr142, dr143, dr144, dr145, dr146, dr147, dr148, dr149, dr150, dr151, dr152, dr153, dr154, dr155, dr156, dr157, dr158, dr159, dr160, dr161, dr162, dr163, dr164, dr165, dr166, dr167, dr168, dr169, dr170, dr171, dr172, dr173, dr174, dr175, dr176, dr177 As SqlDataReader
        Dim ds178, ds179 As New DataSet
        Dim genero As Integer

        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da = New SqlDataAdapter("notaspacientes", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("exped")
            da.Fill(ds178)

            Me.GridView1.DataSource = ds178.Tables(0)
            Me.GridView1.DataBind()
            If Me.GridView1.Rows.Count > 0 Then
                Me.GridView1.Visible = True
                Me.Label187.Visible = False

            Else
                Me.GridView1.Visible = False
                Me.Label187.Visible = True

            End If
            con.Close()
        Catch ex As Exception

        End Try


        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da179 = New SqlDataAdapter("diagnosticospacientes", con)
            da179.SelectCommand.CommandType = CommandType.StoredProcedure
            da179.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("exped")
            da179.Fill(ds179)
            Me.GridView2.DataSource = ds179.Tables(0)
            Me.GridView2.DataBind()
            If Me.GridView2.Rows.Count > 0 Then
                Me.GridView2.Visible = True
            Else
                Me.GridView1.Visible = False
            End If
            con.Close()
        Catch ex As Exception

        End Try
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da = New SqlDataAdapter("select nombres,appaterno,apmaterno,genero,familiar, (cast(datediff(dd,nacimiento,GETDATE())/365.25 as int)), telefono, telefono2, direccion, delegacion, pais, padecimientoactual, diarrea, hernias, cancer, estrenimiento, cancerdigestivo, colecistitis, hipertension, cardiopatia, Autoinmunes, Diabetes, endocrinopatias, otro, otraenfermedad, ocupacion, escolaridad, actividadfisica, alergicos, alergicosdesc, cirugiasrealizadas, tranfusionales, tranfusionalesdesc, hemotipo, traumaticos, traumaticosdesc, hospitalizaciones, hospitalizacionesdesc, hipertensioncdeg, insuficienciacardiaca, cardiopatiacdeg, evc, insuficienciavenosa, diabetesmelitus, DISLIPIDEMMIA, obesidad, tiroidea, cancerenfcdeg, tuberculosis, asma, epoc, bronquitis, otrosenfcdeg, tratamientoactualdesc, alcoholismo, tabaquismo, drogas, otrostoxicomas, Consumotoxicomas, cast(regla as date), ritmo, menopausia, gesta, para, cesarea, aborto, metodoanticonceptivo, otrometodoanticonceptivo, fiebre, astenia, adinamia, anorexia, perdidapeso, tiempoevoluciongral, obstruccionnasal, ronquera, sinusitis, disfonia, disnea, sibilancias, tos, cianosis, asmaresp, tipoevolucionresp, lipotimia, sincope, fatiga, palpitaciones, dolorprecordial, edema, disneaparoxistrica, ascitis, tipoevolucioncardio, digestivo1, digestivo4, digestivo2, digestivo5, digestivo3, digestivo6, digestivo1+digestivo2+digestivo3+digestivo4+digestivo5+digestivo6, ((digestivo1+digestivo2+digestivo3+digestivo4+digestivo5+digestivo6)/18)*100, intestinoirritable1, intestinoirritable2, intestinoirritable3, disfagia, intestinoirritable4, iniciosintomasintesirri, regurgitacion, pirosis, dolorepigastrico, vomito, dolorabdominal, globus, nausea, hematemesis, colitis, meteorismo, anorexiatransesof, ictericia, iniciosintomastransesof, disuria, polaquiuria, tenesmovesical, hematuria, dolorsuprapubica, dolorlumbar, ningunotrans, otrostrans, tendenciahemorragia, adenopatias, infeccionesrecurrentes, anemiahemo, negadohemo, otroshemo, paralisis, parestesias, temblores, alteracionesmarcha, cefalea, negadonervioso, otrosnervioso, ansiedad, angustia, nerviosismo, irritabilidad, llanto, insomnio, talla, peso, case when talla >0 then peso/power(talla,2) else 0 end, temperatura, frecuenciacardiaca, frecuenciaresp, tensionarterial, habitusexterior, cabezacuello, torax, abdomen, extremidades, neurologico, analisis, diagnostico, enviogastro, envionutricion, estudioscomplementarios, enviopsico, medicinageneral, enviocirugia, fechacreacion, medicoencargado, medicocedula, complicaciones from paciente where pacienteid=@pac", con)
            da.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
            dr = da.SelectCommand.ExecuteReader
            dr.Read()
            Label2.Text = dr(0)
            Label14.Text = dr(1)
            Label13.Text = dr(2)
            genero = dr(3)
            Label17.Text = dr(4)
            Label10.Text = dr(5)
            Label7.Text = dr(6)
            Label8.Text = dr(7)
            Label15.Text = dr(8)
            Label19.Text = dr(9)
            Label20.Text = dr(10)
            Label18.Text = dr(11)
            Label21.Text = dr(12)
            Label22.Text = dr(13)
            Label23.Text = dr(14)
            Label24.Text = dr(15)
            Label25.Text = dr(16)
            Label26.Text = dr(17)
            Label27.Text = dr(18)
            Label28.Text = dr(19)
            Label29.Text = dr(20)
            Label30.Text = dr(21)
            Label31.Text = dr(22)
            Label32.Text = dr(23)
            Label33.Text = dr(24)
            Label34.Text = dr(25)
            Label35.Text = dr(26)
            Label36.Text = dr(27)
            Label37.Text = dr(28)
            Label38.Text = dr(29)
            Label39.Text = dr(30)
            Label40.Text = dr(31)
            Label41.Text = dr(32)
            Label42.Text = dr(33)
            Label43.Text = dr(34)
            Label44.Text = dr(35)
            Label45.Text = dr(36)
            Label179.Text = dr(37)
            Label46.Text = dr(38)
            Label47.Text = dr(39)
            Label48.Text = dr(40)
            Label49.Text = dr(41)
            Label50.Text = dr(42)
            Label51.Text = dr(43)
            Label52.Text = dr(44)
            Label53.Text = dr(45)
            Label54.Text = dr(46)
            Label55.Text = dr(47)
            Label56.Text = dr(48)
            Label57.Text = dr(49)
            Label58.Text = dr(50)
            Label59.Text = dr(51)
            Label60.Text = dr(52)
            Label61.Text = dr(53)
            Label62.Text = dr(54)
            Label63.Text = dr(55)
            Label64.Text = dr(56)
            Label65.Text = dr(57)
            Label66.Text = dr(58)
            Label67.Text = dr(59)
            Label68.Text = dr(60)
            Label69.Text = dr(61)
            Label70.Text = dr(62)
            Label71.Text = dr(63)
            Label72.Text = dr(64)
            Label73.Text = dr(65)
            Label74.Text = dr(66)
            Label75.Text = dr(67)
            Label76.Text = dr(68)
            Label77.Text = dr(69)
            Label78.Text = dr(70)
            Label79.Text = dr(71)
            Label80.Text = dr(72)
            Label81.Text = dr(73)
            Label82.Text = dr(74)
            Label83.Text = dr(75)
            Label84.Text = dr(76)
            Label85.Text = dr(77)
            Label86.Text = dr(78)
            Label87.Text = dr(79)
            Label88.Text = dr(80)
            Label89.Text = dr(81)
            Label90.Text = dr(82)
            Label91.Text = dr(83)
            Label92.Text = dr(84)
            Label93.Text = dr(85)
            Label94.Text = dr(86)
            Label95.Text = dr(87)
            Label96.Text = dr(88)
            Label97.Text = dr(89)
            Label98.Text = dr(90)
            Label99.Text = dr(91)
            Label100.Text = dr(92)
            Label101.Text = dr(93)
            Label102.Text = dr(94)
            Label103.Text = dr(95)
            Label104.Text = dr(96)
            Label105.Text = dr(97)
            Label106.Text = dr(98)
            Label107.Text = dr(99)
            Label108.Text = dr(100)
            Label109.Text = dr(101)
            Label110.Text = dr(102)
            Label111.Text = dr(103)
            Label112.Text = dr(104)
            Label113.Text = dr(105)
            Label114.Text = dr(106)
            Label115.Text = dr(107)
            Label116.Text = dr(108)
            Label117.Text = dr(109)
            Label118.Text = dr(110)
            Label119.Text = dr(111)
            Label120.Text = dr(112)
            Label121.Text = dr(113)
            Label122.Text = dr(114)
            Label123.Text = dr(115)
            Label124.Text = dr(116)
            Label125.Text = dr(117)
            Label126.Text = dr(118)
            Label127.Text = dr(119)
            Label128.Text = dr(120)
            Label129.Text = dr(121)
            Label130.Text = dr(122)
            Label131.Text = dr(123)
            Label132.Text = dr(124)
            Label133.Text = dr(125)
            Label134.Text = dr(126)
            Label135.Text = dr(127)
            Label136.Text = dr(128)
            Label137.Text = dr(129)
            Label138.Text = dr(130)
            Label139.Text = dr(131)
            Label140.Text = dr(132)
            Label141.Text = dr(133)
            Label142.Text = dr(134)
            Label143.Text = dr(135)
            Label144.Text = dr(136)
            Label145.Text = dr(137)
            Label146.Text = dr(138)
            Label147.Text = dr(139)
            Label148.Text = dr(140)
            Label149.Text = dr(141)
            Label150.Text = dr(142)
            Label151.Text = dr(143)
            Label152.Text = dr(144)
            Label153.Text = dr(145)
            Label154.Text = dr(146)
            Label155.Text = dr(147)
            Label156.Text = dr(148)
            Label157.Text = dr(149)
            Label158.Text = dr(150)
            Label159.Text = dr(151)
            Label160.Text = dr(152)
            Label161.Text = dr(153)
            Label162.Text = dr(154)
            Label163.Text = dr(155)
            Label164.Text = dr(156)
            Label165.Text = dr(157)
            Label166.Text = dr(158)
            Label167.Text = dr(159)
            Label168.Text = dr(160)
            Label169.Text = dr(161)
            Label170.Text = dr(162)
            Label171.Text = dr(163)
            Label172.Text = dr(164)
            Label173.Text = dr(165)
            Label174.Text = dr(166)
            Label175.Text = dr(167)
            Label176.Text = dr(168)
            Label177.Text = dr(169)
            Label178.Text = dr(170)
            Label180.Text = dr(171)
            con.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
            con.Close()
        Finally
            If genero = 1 Then
                Label9.Text = "Femenino"
            Else
                Label9.Text = "Masculino"
            End If
        End Try


        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da5 = New SqlDataAdapter("select (cast(datediff(dd,nacimiento,GETDATE()) / 365.25 as int)) from paciente where pacienteid=@pac", con)
        '    da5.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr5 = da5.SelectCommand.ExecuteReader
        '    dr5.Read()
        '    Label10.Text = dr5(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da6 = New SqlDataAdapter("select telefono from paciente where pacienteid=@pac", con)
        '    da6.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr6 = da6.SelectCommand.ExecuteReader
        '    dr6.Read()
        '    Label7.Text = dr6(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da7 = New SqlDataAdapter("select telefono2 from paciente where pacienteid=@pac", con)
        '    da7.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr7 = da7.SelectCommand.ExecuteReader
        '    dr7.Read()
        '    Label8.Text = dr7(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da8 = New SqlDataAdapter("select direccion from paciente where pacienteid=@pac", con)
        '    da8.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr8 = da8.SelectCommand.ExecuteReader
        '    dr8.Read()
        '    Label15.Text = dr8(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da9 = New SqlDataAdapter("select delegacion from paciente where pacienteid=@pac", con)
        '    da9.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr9 = da9.SelectCommand.ExecuteReader
        '    dr9.Read()
        '    Label19.Text = dr9(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da10 = New SqlDataAdapter("select pais from paciente where pacienteid=@pac", con)
        '    da10.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr10 = da10.SelectCommand.ExecuteReader
        '    dr10.Read()
        '    Label20.Text = dr10(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da11 = New SqlDataAdapter("select padecimientoactual from paciente where pacienteid=@pac", con)
        '    da11.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr11 = da11.SelectCommand.ExecuteReader
        '    dr11.Read()
        '    Label18.Text = dr11(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try


        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da12 = New SqlDataAdapter("select diarrea from paciente where pacienteid=@pac", con)
        '    da12.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr12 = da12.SelectCommand.ExecuteReader
        '    dr12.Read()
        '    Label21.Text = dr12(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da13 = New SqlDataAdapter("select hernias from paciente where pacienteid=@pac", con)
        '    da13.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr13 = da13.SelectCommand.ExecuteReader
        '    dr13.Read()
        '    Label22.Text = dr13(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da14 = New SqlDataAdapter("select cancer from paciente where pacienteid=@pac", con)
        '    da14.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr14 = da14.SelectCommand.ExecuteReader
        '    dr14.Read()
        '    Label23.Text = dr14(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da15 = New SqlDataAdapter("select estrenimiento from paciente where pacienteid=@pac", con)
        '    da15.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr15 = da15.SelectCommand.ExecuteReader
        '    dr15.Read()
        '    Label24.Text = dr15(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da16 = New SqlDataAdapter("select cancerdigestivo from paciente where pacienteid=@pac", con)
        '    da16.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr16 = da16.SelectCommand.ExecuteReader
        '    dr16.Read()
        '    Label25.Text = dr16(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da17 = New SqlDataAdapter("select colecistitis from paciente where pacienteid=@pac", con)
        '    da17.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr17 = da17.SelectCommand.ExecuteReader
        '    dr17.Read()
        '    Label26.Text = dr17(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da18 = New SqlDataAdapter("select hipertension from paciente where pacienteid=@pac", con)
        '    da18.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr18 = da18.SelectCommand.ExecuteReader
        '    dr18.Read()
        '    Label27.Text = dr18(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da19 = New SqlDataAdapter("select cardiopatia from paciente where pacienteid=@pac", con)
        '    da19.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr19 = da19.SelectCommand.ExecuteReader
        '    dr19.Read()
        '    Label28.Text = dr19(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da20 = New SqlDataAdapter("select Autoinmunes from paciente where pacienteid=@pac", con)
        '    da20.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr20 = da20.SelectCommand.ExecuteReader
        '    dr20.Read()
        '    Label29.Text = dr20(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da21 = New SqlDataAdapter("select Diabetes from paciente where pacienteid=@pac", con)
        '    da21.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr21 = da21.SelectCommand.ExecuteReader
        '    dr21.Read()
        '    Label30.Text = dr21(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da22 = New SqlDataAdapter("select endocrinopatias from paciente where pacienteid=@pac", con)
        '    da22.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr22 = da22.SelectCommand.ExecuteReader
        '    dr22.Read()
        '    Label31.Text = dr22(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da23 = New SqlDataAdapter("select otro from paciente where pacienteid=@pac", con)
        '    da23.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr23 = da22.SelectCommand.ExecuteReader
        '    dr23.Read()
        '    Label32.Text = dr23(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try


        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da24 = New SqlDataAdapter("select otraenfermedad from paciente where pacienteid=@pac", con)
        '    da24.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr24 = da24.SelectCommand.ExecuteReader
        '    dr24.Read()
        '    Label33.Text = dr24(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da25 = New SqlDataAdapter("select ocupacion from paciente where pacienteid=@pac", con)
        '    da25.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr25 = da25.SelectCommand.ExecuteReader
        '    dr25.Read()
        '    Label34.Text = dr25(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da26 = New SqlDataAdapter("select escolaridad from paciente where pacienteid=@pac", con)
        '    da26.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr26 = da26.SelectCommand.ExecuteReader
        '    dr26.Read()
        '    Label35.Text = dr26(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da27 = New SqlDataAdapter("select actividadfisica from paciente where pacienteid=@pac", con)
        '    da27.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr27 = da27.SelectCommand.ExecuteReader
        '    dr27.Read()
        '    Label36.Text = dr27(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da28 = New SqlDataAdapter("select alergicos from paciente where pacienteid=@pac", con)
        '    da28.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr28 = da28.SelectCommand.ExecuteReader
        '    dr28.Read()
        '    Label37.Text = dr28(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da29 = New SqlDataAdapter("select alergicosdesc from paciente where pacienteid=@pac", con)
        '    da29.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr29 = da29.SelectCommand.ExecuteReader
        '    dr29.Read()
        '    Label38.Text = dr29(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try


        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da30 = New SqlDataAdapter("select cirugiasrealizadas from paciente where pacienteid=@pac", con)
        '    da30.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr30 = da30.SelectCommand.ExecuteReader
        '    dr30.Read()
        '    Label39.Text = dr30(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da31 = New SqlDataAdapter("select tranfusionales from paciente where pacienteid=@pac", con)
        '    da31.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr31 = da31.SelectCommand.ExecuteReader
        '    dr31.Read()
        '    Label40.Text = dr31(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da32 = New SqlDataAdapter("select tranfusionalesdesc from paciente where pacienteid=@pac", con)
        '    da32.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr32 = da32.SelectCommand.ExecuteReader
        '    dr32.Read()
        '    Label41.Text = dr32(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da33 = New SqlDataAdapter("select hemotipo from paciente where pacienteid=@pac", con)
        '    da33.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr33 = da33.SelectCommand.ExecuteReader
        '    dr33.Read()
        '    Label42.Text = dr33(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da34 = New SqlDataAdapter("select traumaticos from paciente where pacienteid=@pac", con)
        '    da34.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr34 = da34.SelectCommand.ExecuteReader
        '    dr34.Read()
        '    Label43.Text = dr34(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da35 = New SqlDataAdapter("select traumaticosdesc from paciente where pacienteid=@pac", con)
        '    da35.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr35 = da35.SelectCommand.ExecuteReader
        '    dr35.Read()
        '    Label44.Text = dr35(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da36 = New SqlDataAdapter("select hospitalizaciones from paciente where pacienteid=@pac", con)
        '    da36.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr36 = da36.SelectCommand.ExecuteReader
        '    dr36.Read()
        '    Label45.Text = dr36(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da37 = New SqlDataAdapter("select hospitalizacionesdesc from paciente where pacienteid=@pac", con)
        '    da37.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr37 = da37.SelectCommand.ExecuteReader
        '    dr37.Read()
        '    Label179.Text = dr37(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da38 = New SqlDataAdapter("select hipertensioncdeg from paciente where pacienteid=@pac", con)
        '    da38.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr38 = da38.SelectCommand.ExecuteReader
        '    dr38.Read()
        '    Label46.Text = dr38(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da39 = New SqlDataAdapter("select insuficienciacardiaca from paciente where pacienteid=@pac", con)
        '    da39.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr39 = da39.SelectCommand.ExecuteReader
        '    dr39.Read()
        '    Label47.Text = dr39(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da40 = New SqlDataAdapter("select cardiopatiacdeg from paciente where pacienteid=@pac", con)
        '    da40.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr40 = da40.SelectCommand.ExecuteReader
        '    dr40.Read()
        '    Label48.Text = dr40(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da41 = New SqlDataAdapter("select evc from paciente where pacienteid=@pac", con)
        '    da41.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr41 = da41.SelectCommand.ExecuteReader
        '    dr41.Read()
        '    Label49.Text = dr41(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da42 = New SqlDataAdapter("select insuficienciavenosa from paciente where pacienteid=@pac", con)
        '    da42.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr42 = da42.SelectCommand.ExecuteReader
        '    dr42.Read()
        '    Label50.Text = dr42(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da43 = New SqlDataAdapter("select diabetesmelitus from paciente where pacienteid=@pac", con)
        '    da43.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr43 = da43.SelectCommand.ExecuteReader
        '    dr43.Read()
        '    Label51.Text = dr43(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da44 = New SqlDataAdapter("select DISLIPIDEMMIA from paciente where pacienteid=@pac", con)
        '    da44.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr44 = da44.SelectCommand.ExecuteReader
        '    dr44.Read()
        '    Label52.Text = dr44(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da45 = New SqlDataAdapter("select obesidad from paciente where pacienteid=@pac", con)
        '    da45.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr45 = da45.SelectCommand.ExecuteReader
        '    dr45.Read()
        '    Label53.Text = dr45(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da46 = New SqlDataAdapter("select tiroidea from paciente where pacienteid=@pac", con)
        '    da46.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr46 = da46.SelectCommand.ExecuteReader
        '    dr46.Read()
        '    Label54.Text = dr46(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da47 = New SqlDataAdapter("select cancerenfcdeg from paciente where pacienteid=@pac", con)
        '    da47.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr47 = da47.SelectCommand.ExecuteReader
        '    dr47.Read()
        '    Label55.Text = dr47(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da48 = New SqlDataAdapter("select tuberculosis from paciente where pacienteid=@pac", con)
        '    da48.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr48 = da48.SelectCommand.ExecuteReader
        '    dr48.Read()
        '    Label56.Text = dr48(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da49 = New SqlDataAdapter("select asma from paciente where pacienteid=@pac", con)
        '    da49.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr49 = da49.SelectCommand.ExecuteReader
        '    dr49.Read()
        '    Label57.Text = dr49(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da50 = New SqlDataAdapter("select epoc from paciente where pacienteid=@pac", con)
        '    da50.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr50 = da50.SelectCommand.ExecuteReader
        '    dr50.Read()
        '    Label58.Text = dr50(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da51 = New SqlDataAdapter("select bronquitis from paciente where pacienteid=@pac", con)
        '    da51.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr51 = da51.SelectCommand.ExecuteReader
        '    dr51.Read()
        '    Label59.Text = dr51(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da52 = New SqlDataAdapter("select otrosenfcdeg from paciente where pacienteid=@pac", con)
        '    da52.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr52 = da52.SelectCommand.ExecuteReader
        '    dr52.Read()
        '    Label60.Text = dr52(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da53 = New SqlDataAdapter("select tratamientoactualdesc from paciente where pacienteid=@pac", con)
        '    da53.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr53 = da53.SelectCommand.ExecuteReader
        '    dr53.Read()
        '    Label61.Text = dr53(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da54 = New SqlDataAdapter("select alcoholismo from paciente where pacienteid=@pac", con)
        '    da54.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr54 = da54.SelectCommand.ExecuteReader
        '    dr54.Read()
        '    Label62.Text = dr54(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da55 = New SqlDataAdapter("select tabaquismo from paciente where pacienteid=@pac", con)
        '    da55.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr55 = da55.SelectCommand.ExecuteReader
        '    dr55.Read()
        '    Label63.Text = dr55(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da56 = New SqlDataAdapter("select drogas from paciente where pacienteid=@pac", con)
        '    da56.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr56 = da56.SelectCommand.ExecuteReader
        '    dr56.Read()
        '    Label64.Text = dr56(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da57 = New SqlDataAdapter("select otrostoxicomas from paciente where pacienteid=@pac", con)
        '    da57.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr57 = da57.SelectCommand.ExecuteReader
        '    dr57.Read()
        '    Label65.Text = dr57(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da58 = New SqlDataAdapter("select Consumotoxicomas from paciente where pacienteid=@pac", con)
        '    da58.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr58 = da58.SelectCommand.ExecuteReader
        '    dr58.Read()
        '    Label66.Text = dr58(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da59 = New SqlDataAdapter("select cast(regla as date()) from paciente where pacienteid=@pac", con)
        '    da59.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr59 = da59.SelectCommand.ExecuteReader
        '    dr59.Read()
        '    Label67.Text = dr59(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da60 = New SqlDataAdapter("select ritmo from paciente where pacienteid=@pac", con)
        '    da60.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr60 = da60.SelectCommand.ExecuteReader
        '    dr60.Read()
        '    Label68.Text = dr60(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try
        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da61 = New SqlDataAdapter("select menopausia from paciente where pacienteid=@pac", con)
        '    da61.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr61 = da61.SelectCommand.ExecuteReader
        '    dr61.Read()
        '    Label69.Text = dr61(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da62 = New SqlDataAdapter("select gesta from paciente where pacienteid=@pac", con)
        '    da62.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr62 = da62.SelectCommand.ExecuteReader
        '    dr62.Read()
        '    Label70.Text = dr62(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da63 = New SqlDataAdapter("select para from paciente where pacienteid=@pac", con)
        '    da63.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr63 = da63.SelectCommand.ExecuteReader
        '    dr63.Read()
        '    Label71.Text = dr63(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try


        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da64 = New SqlDataAdapter("select cesarea from paciente where pacienteid=@pac", con)
        '    da64.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr64 = da64.SelectCommand.ExecuteReader
        '    dr64.Read()
        '    Label72.Text = dr64(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da65 = New SqlDataAdapter("select aborto from paciente where pacienteid=@pac", con)
        '    da65.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr65 = da65.SelectCommand.ExecuteReader
        '    dr65.Read()
        '    Label73.Text = dr65(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da66 = New SqlDataAdapter("select metodoanticonceptivo from paciente where pacienteid=@pac", con)
        '    da66.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr66 = da66.SelectCommand.ExecuteReader
        '    dr66.Read()
        '    Label74.Text = dr66(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da67 = New SqlDataAdapter("select otrometodoanticonceptivo from paciente where pacienteid=@pac", con)
        '    da67.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr67 = da67.SelectCommand.ExecuteReader
        '    dr67.Read()
        '    Label75.Text = dr67(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da68 = New SqlDataAdapter("select fiebre from paciente where pacienteid=@pac", con)
        '    da68.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr68 = da68.SelectCommand.ExecuteReader
        '    dr68.Read()
        '    Label76.Text = dr68(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da69 = New SqlDataAdapter("select astenia from paciente where pacienteid=@pac", con)
        '    da69.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr69 = da69.SelectCommand.ExecuteReader
        '    dr69.Read()
        '    Label77.Text = dr69(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da70 = New SqlDataAdapter("select adinamia from paciente where pacienteid=@pac", con)
        '    da70.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr70 = da70.SelectCommand.ExecuteReader
        '    dr70.Read()
        '    Label78.Text = dr70(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da71 = New SqlDataAdapter("select anorexia from paciente where pacienteid=@pac", con)
        '    da71.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr71 = da71.SelectCommand.ExecuteReader
        '    dr71.Read()
        '    Label79.Text = dr71(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da72 = New SqlDataAdapter("select perdidapeso from paciente where pacienteid=@pac", con)
        '    da72.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr72 = da72.SelectCommand.ExecuteReader
        '    dr72.Read()
        '    Label80.Text = dr72(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da73 = New SqlDataAdapter("select tiempoevoluciongral from paciente where pacienteid=@pac", con)
        '    da73.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr73 = da73.SelectCommand.ExecuteReader
        '    dr73.Read()
        '    Label81.Text = dr73(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da74 = New SqlDataAdapter("select obstruccionnasal from paciente where pacienteid=@pac", con)
        '    da74.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr74 = da74.SelectCommand.ExecuteReader
        '    dr74.Read()
        '    Label82.Text = dr74(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da75 = New SqlDataAdapter("select ronquera from paciente where pacienteid=@pac", con)
        '    da75.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr75 = da75.SelectCommand.ExecuteReader
        '    dr75.Read()
        '    Label83.Text = dr75(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da76 = New SqlDataAdapter("select sinusitis from paciente where pacienteid=@pac", con)
        '    da76.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr76 = da76.SelectCommand.ExecuteReader
        '    dr76.Read()
        '    Label84.Text = dr76(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da77 = New SqlDataAdapter("select disfonia from paciente where pacienteid=@pac", con)
        '    da77.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr77 = da77.SelectCommand.ExecuteReader
        '    dr77.Read()
        '    Label85.Text = dr77(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da78 = New SqlDataAdapter("select disnea from paciente where pacienteid=@pac", con)
        '    da78.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr78 = da78.SelectCommand.ExecuteReader
        '    dr78.Read()
        '    Label86.Text = dr78(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da79 = New SqlDataAdapter("select sibilancias from paciente where pacienteid=@pac", con)
        '    da79.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr79 = da79.SelectCommand.ExecuteReader
        '    dr79.Read()
        '    Label87.Text = dr79(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da80 = New SqlDataAdapter("select tos from paciente where pacienteid=@pac", con)
        '    da80.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr80 = da80.SelectCommand.ExecuteReader
        '    dr80.Read()
        '    Label88.Text = dr80(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da81 = New SqlDataAdapter("select cianosis from paciente where pacienteid=@pac", con)
        '    da81.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr81 = da81.SelectCommand.ExecuteReader
        '    dr81.Read()
        '    Label89.Text = dr81(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da82 = New SqlDataAdapter("select asmaresp from paciente where pacienteid=@pac", con)
        '    da82.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr82 = da82.SelectCommand.ExecuteReader
        '    dr82.Read()
        '    Label90.Text = dr82(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da83 = New SqlDataAdapter("select tipoevolucionresp from paciente where pacienteid=@pac", con)
        '    da83.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr83 = da83.SelectCommand.ExecuteReader
        '    dr83.Read()
        '    Label91.Text = dr83(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da84 = New SqlDataAdapter("select lipotimia from paciente where pacienteid=@pac", con)
        '    da84.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr84 = da84.SelectCommand.ExecuteReader
        '    dr84.Read()
        '    Label92.Text = dr84(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try



        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da85 = New SqlDataAdapter("select sincope from paciente where pacienteid=@pac", con)
        '    da85.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr85 = da85.SelectCommand.ExecuteReader
        '    dr85.Read()
        '    Label93.Text = dr85(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da86 = New SqlDataAdapter("select fatiga from paciente where pacienteid=@pac", con)
        '    da86.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr86 = da86.SelectCommand.ExecuteReader
        '    dr86.Read()
        '    Label94.Text = dr86(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da87 = New SqlDataAdapter("select palpitaciones from paciente where pacienteid=@pac", con)
        '    da87.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr87 = da87.SelectCommand.ExecuteReader
        '    dr87.Read()
        '    Label95.Text = dr87(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da88 = New SqlDataAdapter("select dolorprecordial from paciente where pacienteid=@pac", con)
        '    da88.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr88 = da88.SelectCommand.ExecuteReader
        '    dr88.Read()
        '    Label96.Text = dr88(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da89 = New SqlDataAdapter("select edema from paciente where pacienteid=@pac", con)
        '    da89.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr89 = da89.SelectCommand.ExecuteReader
        '    dr89.Read()
        '    Label97.Text = dr89(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da90 = New SqlDataAdapter("select disneaparoxistrica from paciente where pacienteid=@pac", con)
        '    da90.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr90 = da90.SelectCommand.ExecuteReader
        '    dr90.Read()
        '    Label98.Text = dr90(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da91 = New SqlDataAdapter("select ascitis from paciente where pacienteid=@pac", con)
        '    da91.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr91 = da91.SelectCommand.ExecuteReader
        '    dr91.Read()
        '    Label99.Text = dr91(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da92 = New SqlDataAdapter("select tipoevolucioncardio from paciente where pacienteid=@pac", con)
        '    da92.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr92 = da92.SelectCommand.ExecuteReader
        '    dr92.Read()
        '    Label100.Text = dr92(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da93 = New SqlDataAdapter("select digestivo1 from paciente where pacienteid=@pac", con)
        '    da93.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr93 = da93.SelectCommand.ExecuteReader
        '    dr93.Read()
        '    Label101.Text = dr93(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da94 = New SqlDataAdapter("select digestivo4 from paciente where pacienteid=@pac", con)
        '    da94.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr94 = da94.SelectCommand.ExecuteReader
        '    dr94.Read()
        '    Label102.Text = dr94(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try
        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da95 = New SqlDataAdapter("select digestivo2 from paciente where pacienteid=@pac", con)
        '    da95.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr95 = da95.SelectCommand.ExecuteReader
        '    dr95.Read()
        '    Label103.Text = dr95(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da96 = New SqlDataAdapter("select digestivo5 from paciente where pacienteid=@pac", con)
        '    da96.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr96 = da96.SelectCommand.ExecuteReader
        '    dr96.Read()
        '    Label104.Text = dr96(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da97 = New SqlDataAdapter("select digestivo3 from paciente where pacienteid=@pac", con)
        '    da97.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr97 = da97.SelectCommand.ExecuteReader
        '    dr97.Read()
        '    Label105.Text = dr97(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da98 = New SqlDataAdapter("select digestivo6 from paciente where pacienteid=@pac", con)
        '    da98.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr98 = da98.SelectCommand.ExecuteReader
        '    dr98.Read()
        '    Label106.Text = dr98(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try


        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da99 = New SqlDataAdapter("select digestivo1+digestivo2+digestivo3+digestivo4+digestivo5+digestivo6 from paciente where pacienteid=@pac", con)
        '    da99.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr99 = da99.SelectCommand.ExecuteReader
        '    dr99.Read()
        '    Label107.Text = dr99(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da100 = New SqlDataAdapter("select ((digestivo1+digestivo2+digestivo3+digestivo4+digestivo5+digestivo6)/18)*100 from paciente where pacienteid=@pac", con)
        '    da100.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr100 = da100.SelectCommand.ExecuteReader
        '    dr100.Read()
        '    Label108.Text = dr100(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da101 = New SqlDataAdapter("select intestinoirritable1 from paciente where pacienteid=@pac", con)
        '    da101.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr101 = da101.SelectCommand.ExecuteReader
        '    dr101.Read()
        '    Label109.Text = dr101(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da102 = New SqlDataAdapter("select intestinoirritable2 from paciente where pacienteid=@pac", con)
        '    da102.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr102 = da102.SelectCommand.ExecuteReader
        '    dr102.Read()
        '    Label110.Text = dr102(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da103 = New SqlDataAdapter("select intestinoirritable3 from paciente where pacienteid=@pac", con)
        '    da103.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr103 = da103.SelectCommand.ExecuteReader
        '    dr103.Read()
        '    Label111.Text = dr103(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da104 = New SqlDataAdapter("select disfagia from paciente where pacienteid=@pac", con)
        '    da104.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr104 = da104.SelectCommand.ExecuteReader
        '    dr104.Read()
        '    Label112.Text = dr104(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da105 = New SqlDataAdapter("select intestinoirritable4 from paciente where pacienteid=@pac", con)
        '    da105.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr105 = da105.SelectCommand.ExecuteReader
        '    dr105.Read()
        '    Label113.Text = dr105(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da106 = New SqlDataAdapter("select iniciosintomasintesirri from paciente where pacienteid=@pac", con)
        '    da106.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr106 = da106.SelectCommand.ExecuteReader
        '    dr106.Read()
        '    Label114.Text = dr106(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da107 = New SqlDataAdapter("select regurgitacion from paciente where pacienteid=@pac", con)
        '    da107.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr107 = da107.SelectCommand.ExecuteReader
        '    dr107.Read()
        '    Label115.Text = dr107(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try


        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da108 = New SqlDataAdapter("select pirosis from paciente where pacienteid=@pac", con)
        '    da108.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr108 = da108.SelectCommand.ExecuteReader
        '    dr108.Read()
        '    Label116.Text = dr108(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da109 = New SqlDataAdapter("select dolorepigastrico from paciente where pacienteid=@pac", con)
        '    da109.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr109 = da109.SelectCommand.ExecuteReader
        '    dr109.Read()
        '    Label117.Text = dr109(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da110 = New SqlDataAdapter("select vomito from paciente where pacienteid=@pac", con)
        '    da110.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr110 = da110.SelectCommand.ExecuteReader
        '    dr110.Read()
        '    Label118.Text = dr110(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da111 = New SqlDataAdapter("select dolorabdominal from paciente where pacienteid=@pac", con)
        '    da111.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr111 = da111.SelectCommand.ExecuteReader
        '    dr111.Read()
        '    Label119.Text = dr111(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da112 = New SqlDataAdapter("select globus from paciente where pacienteid=@pac", con)
        '    da112.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr112 = da112.SelectCommand.ExecuteReader
        '    dr112.Read()
        '    Label120.Text = dr112(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da113 = New SqlDataAdapter("select nausea from paciente where pacienteid=@pac", con)
        '    da113.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr113 = da113.SelectCommand.ExecuteReader
        '    dr113.Read()
        '    Label121.Text = dr113(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da114 = New SqlDataAdapter("select hematemesis from paciente where pacienteid=@pac", con)
        '    da114.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr114 = da114.SelectCommand.ExecuteReader
        '    dr114.Read()
        '    Label122.Text = dr114(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da115 = New SqlDataAdapter("select colitis from paciente where pacienteid=@pac", con)
        '    da115.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr115 = da115.SelectCommand.ExecuteReader
        '    dr115.Read()
        '    Label123.Text = dr115(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da116 = New SqlDataAdapter("select meteorismo from paciente where pacienteid=@pac", con)
        '    da116.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr116 = da116.SelectCommand.ExecuteReader
        '    dr116.Read()
        '    Label124.Text = dr116(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da117 = New SqlDataAdapter("select anorexiatransesof from paciente where pacienteid=@pac", con)
        '    da117.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr117 = da117.SelectCommand.ExecuteReader
        '    dr117.Read()
        '    Label125.Text = dr117(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da118 = New SqlDataAdapter("select ictericia from paciente where pacienteid=@pac", con)
        '    da118.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr118 = da118.SelectCommand.ExecuteReader
        '    dr118.Read()
        '    Label126.Text = dr118(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da119 = New SqlDataAdapter("select iniciosintomastransesof from paciente where pacienteid=@pac", con)
        '    da119.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr119 = da119.SelectCommand.ExecuteReader
        '    dr119.Read()
        '    Label127.Text = dr119(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da120 = New SqlDataAdapter("select disuria from paciente where pacienteid=@pac", con)
        '    da120.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr120 = da120.SelectCommand.ExecuteReader
        '    dr120.Read()
        '    Label128.Text = dr120(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da121 = New SqlDataAdapter("select poliaquiuria from paciente where pacienteid=@pac", con)
        '    da121.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr121 = da121.SelectCommand.ExecuteReader
        '    dr121.Read()
        '    Label129.Text = dr121(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da122 = New SqlDataAdapter("select tenesmovesical from paciente where pacienteid=@pac", con)
        '    da122.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr122 = da122.SelectCommand.ExecuteReader
        '    dr122.Read()
        '    Label130.Text = dr122(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da123 = New SqlDataAdapter("select hematuria from paciente where pacienteid=@pac", con)
        '    da123.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr123 = da123.SelectCommand.ExecuteReader
        '    dr123.Read()
        '    Label131.Text = dr123(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da124 = New SqlDataAdapter("select dolorsuprapubica from paciente where pacienteid=@pac", con)
        '    da124.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr124 = da124.SelectCommand.ExecuteReader
        '    dr124.Read()
        '    Label132.Text = dr124(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da125 = New SqlDataAdapter("select dolorlumbar from paciente where pacienteid=@pac", con)
        '    da125.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr125 = da125.SelectCommand.ExecuteReader
        '    dr125.Read()
        '    Label133.Text = dr125(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da126 = New SqlDataAdapter("select ningunotrans from paciente where pacienteid=@pac", con)
        '    da126.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr126 = da126.SelectCommand.ExecuteReader
        '    dr126.Read()
        '    Label134.Text = dr126(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da127 = New SqlDataAdapter("select otrostrans from paciente where pacienteid=@pac", con)
        '    da127.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr127 = da127.SelectCommand.ExecuteReader
        '    dr127.Read()
        '    Label135.Text = dr127(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da128 = New SqlDataAdapter("select tendenciahemorragia from paciente where pacienteid=@pac", con)
        '    da128.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr128 = da128.SelectCommand.ExecuteReader
        '    dr128.Read()
        '    Label136.Text = dr128(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da129 = New SqlDataAdapter("select adenopatias from paciente where pacienteid=@pac", con)
        '    da129.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr129 = da129.SelectCommand.ExecuteReader
        '    dr129.Read()
        '    Label137.Text = dr129(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da130 = New SqlDataAdapter("select infeccionesrecurrentes from paciente where pacienteid=@pac", con)
        '    da130.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr130 = da130.SelectCommand.ExecuteReader
        '    dr130.Read()
        '    Label138.Text = dr130(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da131 = New SqlDataAdapter("select anemiahemo from paciente where pacienteid=@pac", con)
        '    da131.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr131 = da131.SelectCommand.ExecuteReader
        '    dr131.Read()
        '    Label139.Text = dr131(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da132 = New SqlDataAdapter("select negadohemo from paciente where pacienteid=@pac", con)
        '    da132.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr132 = da132.SelectCommand.ExecuteReader
        '    dr132.Read()
        '    Label140.Text = dr132(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da133 = New SqlDataAdapter("select otroshemo from paciente where pacienteid=@pac", con)
        '    da133.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr133 = da133.SelectCommand.ExecuteReader
        '    dr133.Read()
        '    Label141.Text = dr133(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da134 = New SqlDataAdapter("select paralisis from paciente where pacienteid=@pac", con)
        '    da134.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr134 = da134.SelectCommand.ExecuteReader
        '    dr134.Read()
        '    Label142.Text = dr134(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da135 = New SqlDataAdapter("select parestesias from paciente where pacienteid=@pac", con)
        '    da135.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr135 = da135.SelectCommand.ExecuteReader
        '    dr135.Read()
        '    Label143.Text = dr135(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da136 = New SqlDataAdapter("select temblores from paciente where pacienteid=@pac", con)
        '    da136.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr136 = da136.SelectCommand.ExecuteReader
        '    dr136.Read()
        '    Label144.Text = dr136(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da137 = New SqlDataAdapter("select alteracionesmarcha from paciente where pacienteid=@pac", con)
        '    da137.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr137 = da137.SelectCommand.ExecuteReader
        '    dr137.Read()
        '    Label145.Text = dr137(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da138 = New SqlDataAdapter("select cefalea from paciente where pacienteid=@pac", con)
        '    da138.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr138 = da138.SelectCommand.ExecuteReader
        '    dr138.Read()
        '    Label146.Text = dr138(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da139 = New SqlDataAdapter("select negadonervioso from paciente where pacienteid=@pac", con)
        '    da139.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr139 = da139.SelectCommand.ExecuteReader
        '    dr139.Read()
        '    Label147.Text = dr139(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da140 = New SqlDataAdapter("select otrosnervioso from paciente where pacienteid=@pac", con)
        '    da140.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr140 = da140.SelectCommand.ExecuteReader
        '    dr140.Read()
        '    Label148.Text = dr140(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da141 = New SqlDataAdapter("select ansiedad from paciente where pacienteid=@pac", con)
        '    da141.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr141 = da141.SelectCommand.ExecuteReader
        '    dr141.Read()
        '    Label149.Text = dr141(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da142 = New SqlDataAdapter("select angustia from paciente where pacienteid=@pac", con)
        '    da142.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr142 = da142.SelectCommand.ExecuteReader
        '    dr142.Read()
        '    Label150.Text = dr142(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da143 = New SqlDataAdapter("select nerviosismo from paciente where pacienteid=@pac", con)
        '    da143.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr143 = da143.SelectCommand.ExecuteReader
        '    dr143.Read()
        '    Label151.Text = dr143(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da144 = New SqlDataAdapter("select irritabilidad from paciente where pacienteid=@pac", con)
        '    da144.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr144 = da144.SelectCommand.ExecuteReader
        '    dr144.Read()
        '    Label152.Text = dr144(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da145 = New SqlDataAdapter("select llanto from paciente where pacienteid=@pac", con)
        '    da145.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr145 = da145.SelectCommand.ExecuteReader
        '    dr145.Read()
        '    Label153.Text = dr145(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da146 = New SqlDataAdapter("select insomnio from paciente where pacienteid=@pac", con)
        '    da146.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr146 = da146.SelectCommand.ExecuteReader
        '    dr146.Read()
        '    Label154.Text = dr146(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da147 = New SqlDataAdapter("select talla from paciente where pacienteid=@pac", con)
        '    da147.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr147 = da147.SelectCommand.ExecuteReader
        '    dr147.Read()
        '    Label155.Text = dr147(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da148 = New SqlDataAdapter("select peso from paciente where pacienteid=@pac", con)
        '    da148.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr148 = da148.SelectCommand.ExecuteReader
        '    dr148.Read()
        '    Label156.Text = dr148(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da149 = New SqlDataAdapter("select peso/power(talla,2) from paciente where pacienteid=@pac", con)
        '    da149.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr149 = da149.SelectCommand.ExecuteReader
        '    dr149.Read()
        '    Label157.Text = dr149(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da150 = New SqlDataAdapter("select temperatura from paciente where pacienteid=@pac", con)
        '    da150.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr150 = da150.SelectCommand.ExecuteReader
        '    dr150.Read()
        '    Label158.Text = dr150(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da151 = New SqlDataAdapter("select frecuenciacardiaca from paciente where pacienteid=@pac", con)
        '    da151.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr151 = da151.SelectCommand.ExecuteReader
        '    dr151.Read()
        '    Label159.Text = dr151(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da152 = New SqlDataAdapter("select frecuenciaresp from paciente where pacienteid=@pac", con)
        '    da152.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr152 = da152.SelectCommand.ExecuteReader
        '    dr152.Read()
        '    Label160.Text = dr152(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da153 = New SqlDataAdapter("select tensionarterial from paciente where pacienteid=@pac", con)
        '    da153.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr153 = da153.SelectCommand.ExecuteReader
        '    dr153.Read()
        '    Label161.Text = dr153(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da154 = New SqlDataAdapter("select habitusexterior from paciente where pacienteid=@pac", con)
        '    da154.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr154 = da154.SelectCommand.ExecuteReader
        '    dr154.Read()
        '    Label162.Text = dr154(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da155 = New SqlDataAdapter("select cabezacuello from paciente where pacienteid=@pac", con)
        '    da155.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr155 = da155.SelectCommand.ExecuteReader
        '    dr155.Read()
        '    Label163.Text = dr155(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da156 = New SqlDataAdapter("select torax from paciente where pacienteid=@pac", con)
        '    da156.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr156 = da156.SelectCommand.ExecuteReader
        '    dr156.Read()
        '    Label164.Text = dr156(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da157 = New SqlDataAdapter("select abdomen from paciente where pacienteid=@pac", con)
        '    da157.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr157 = da157.SelectCommand.ExecuteReader
        '    dr157.Read()
        '    Label165.Text = dr157(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da158 = New SqlDataAdapter("select extremidades from paciente where pacienteid=@pac", con)
        '    da158.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr158 = da158.SelectCommand.ExecuteReader
        '    dr158.Read()
        '    Label166.Text = dr158(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da159 = New SqlDataAdapter("select neurologico from paciente where pacienteid=@pac", con)
        '    da159.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr159 = da159.SelectCommand.ExecuteReader
        '    dr159.Read()
        '    Label167.Text = dr159(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da160 = New SqlDataAdapter("select analisis from paciente where pacienteid=@pac", con)
        '    da160.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr160 = da160.SelectCommand.ExecuteReader
        '    dr160.Read()
        '    Label168.Text = dr160(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da161 = New SqlDataAdapter("select diagnostico from paciente where pacienteid=@pac", con)
        '    da161.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr161 = da161.SelectCommand.ExecuteReader
        '    dr161.Read()
        '    Label169.Text = dr161(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da162 = New SqlDataAdapter("select enviogastro from paciente where pacienteid=@pac", con)
        '    da162.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr162 = da162.SelectCommand.ExecuteReader
        '    dr162.Read()
        '    Label170.Text = dr162(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da163 = New SqlDataAdapter("select envionutricion from paciente where pacienteid=@pac", con)
        '    da163.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr163 = da163.SelectCommand.ExecuteReader
        '    dr163.Read()
        '    Label171.Text = dr163(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da164 = New SqlDataAdapter("select estudioscomplementarios from paciente where pacienteid=@pac", con)
        '    da164.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr164 = da164.SelectCommand.ExecuteReader
        '    dr164.Read()
        '    Label172.Text = dr164(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da165 = New SqlDataAdapter("select enviopsico from paciente where pacienteid=@pac", con)
        '    da165.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr165 = da165.SelectCommand.ExecuteReader
        '    dr165.Read()
        '    Label173.Text = dr165(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da166 = New SqlDataAdapter("select medicinageneral from paciente where pacienteid=@pac", con)
        '    da166.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr166 = da166.SelectCommand.ExecuteReader
        '    dr166.Read()
        '    Label174.Text = dr166(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da167 = New SqlDataAdapter("select enviocirugia from paciente where pacienteid=@pac", con)
        '    da167.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr167 = da167.SelectCommand.ExecuteReader
        '    dr167.Read()
        '    Label175.Text = dr167(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da168 = New SqlDataAdapter("select fechacreacion from paciente where pacienteid=@pac", con)
        '    da168.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr168 = da168.SelectCommand.ExecuteReader
        '    dr168.Read()
        '    Label176.Text = dr168(0)
        '    con.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da169 = New SqlDataAdapter("select medicoencargado from paciente where pacienteid=@pac", con)
        '    da169.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr169 = da169.SelectCommand.ExecuteReader
        '    dr169.Read()
        '    Label177.Text = dr169(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da170 = New SqlDataAdapter("select medicocedula from paciente where pacienteid=@pac", con)
        '    da170.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr170 = da170.SelectCommand.ExecuteReader
        '    dr170.Read()
        '    Label178.Text = dr170(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da171 = New SqlDataAdapter("select complicaciones from paciente where pacienteid=@pac", con)
        '    da171.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
        '    dr171 = da171.SelectCommand.ExecuteReader
        '    dr171.Read()
        '    Label180.Text = dr171(0)
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        'End Try

        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da172 = New SqlDataAdapter("select SxDiarreicoManual from GSRS where pacienteid=@pac", con)
            da172.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
            dr172 = da172.SelectCommand.ExecuteReader
            dr172.Read()
            If dr172.HasRows Then
                Label181.Text = dr172(0)
                Label181.Visible = True
                TextBox6.Visible = False
            Else
                Label181.Visible = False
                TextBox5.Visible = True
            End If

            con.Close()
        Catch ex As Exception

        End Try
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da173 = New SqlDataAdapter("select SxIndigestionManual from GSRS where pacienteid=@pac", con)
            da173.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
            dr173 = da173.SelectCommand.ExecuteReader
            dr173.Read()
            If dr173.HasRows Then
                Label182.Text = dr173(0)
                Label182.Visible = True
                TextBox5.Visible = False
            Else
                Label182.Visible = False
                TextBox5.Visible = True
            End If

            con.Close()
        Catch ex As Exception

        End Try
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da174 = New SqlDataAdapter("select SxConstipacionManual from GSRS where pacienteid=@pac", con)
            da174.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
            dr174 = da174.SelectCommand.ExecuteReader
            dr174.Read()
            If dr174.HasRows Then
                Label183.Text = dr174(0)
                Label183.Visible = True
                TextBox4.Visible = False
            Else
                Label183.Visible = False
                TextBox4.Visible = True
            End If

            con.Close()
        Catch ex As Exception

        End Try

        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da175 = New SqlDataAdapter("select SxDolorAbdominalManual from GSRS where pacienteid=@pac", con)
            da175.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
            dr175 = da175.SelectCommand.ExecuteReader
            dr175.Read()
            If dr175.HasRows Then
                Label184.Text = dr175(0)
                Label184.Visible = True
                TextBox3.Visible = False
            Else
                Label184.Visible = False
                TextBox3.Visible = True
            End If

            con.Close()
        Catch ex As Exception

        End Try

        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da176 = New SqlDataAdapter("select SxReflujoManual from GSRS where pacienteid=@pac", con)
            da176.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
            dr176 = da176.SelectCommand.ExecuteReader
            dr176.Read()
            If dr176.HasRows Then
                Label185.Text = dr176(0)
                Label185.Visible = True
                TextBox2.Visible = False
            Else
                Label185.Visible = False
                TextBox2.Visible = True
            End If

            con.Close()
        Catch ex As Exception

        End Try

        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da177 = New SqlDataAdapter("select PuntajeGlobalManual from GSRS where pacienteid=@pac", con)
            da177.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
            dr177 = da177.SelectCommand.ExecuteReader
            dr177.Read()
            If dr177.HasRows Then
                Label186.Visible = True
                TextBox1.Visible = False
                Label186.Text = dr177(0)
            Else
                Label186.Visible = False
                TextBox1.Visible = True
            End If

            con.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Label1_Load(sender As Object, e As EventArgs) Handles Label1.Load


    End Sub


    Protected Sub Menu2_MenuItemClick(sender As Object, e As MenuEventArgs) Handles Menu2.MenuItemClick
        Dim pacienteid As Integer
        pacienteid = Session("Expediente")
        Dim da, da1, da2, da3, da4 As New SqlDataAdapter

        'If Menu2.SelectedItem.Text = "Exportar PDF" Then
        '    Response.ContentType = "application/pdf"
        '    Response.AddHeader("content-disposition", "attachment;filename=Panel.pdf")
        '    Response.Cache.SetCacheability(HttpCacheability.NoCache)
        '    Dim sw As New StringWriter()
        '    Dim hw As New HtmlTextWriter(sw)
        '    exportar.RenderControl(hw)
        '    Dim sr As New StringReader(sw.ToString())
        '    Dim pdfDoc As New Document(PageSize.A4, 10.0F, 10.0F, 100.0F, 0.0F)
        '    Dim htmlparser As New HTMLWorker(pdfDoc)
        '    PdfWriter.GetInstance(pdfDoc, Response.OutputStream)
        '    pdfDoc.Open()
        '    htmlparser.Parse(sr)
        '    pdfDoc.Close()
        '    Response.Write(pdfDoc)
        '    Response.End()
        'Else
        If Menu2.SelectedItem.Text = "Eliminar" Then
            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da = New SqlDataAdapter("delete from nota where pacienteid=@pacienteid", con)
                da.SelectCommand.Parameters.Add("@pacienteid", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                da.SelectCommand.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    da1 = New SqlDataAdapter("delete from gsrs where pacienteid=@pacienteid", con)
                    da1.SelectCommand.Parameters.Add("@pacienteid", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                    da1.SelectCommand.ExecuteNonQuery()
                    con.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da2 = New SqlDataAdapter("delete from paciente where pacienteid=@pacienteid", con)
                        da2.SelectCommand.Parameters.Add("@pacienteid", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                        da2.SelectCommand.ExecuteNonQuery()
                        con.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    Finally
                        Response.Redirect("~/Pacientes/ListaPacientes.aspx")
                    End Try

                End Try
            End Try
        ElseIf Menu2.SelectedItem.Text = "Exportar PDF" Then
            Request.ContentType = "application/pdf"
            Response.AddHeader("content-disposition", "attachment;filename=exp.pdf")
            Response.Cache.SetCacheability(HttpCacheability.NoCache)
            Dim sw As New StringWriter
            sw = New StringWriter
            Dim hw As New HtmlTextWriter(sw)
            exportar.RenderControl(hw)
            Dim sr As New StringReader(sw.ToString)
            Dim pdfdoc As New Document
            'pdfdoc = New Document(PageSize.A4, 10.0F, 10.0F, 100.0F, 10.0F)
            Dim htmlparse As New HTMLWorker(pdfdoc)
            PdfWriter.GetInstance(pdfdoc, Response.OutputStream)
            pdfdoc.Open()
            htmlparse.Parse(sr)
            pdfdoc.Close()
            Response.Write(pdfdoc)
            Response.End()

        End If


    End Sub
    Protected Function checkLink(myid As Object) As String


        Dim myLinkString As String = String.Empty


        Dim intmyid As String = DirectCast(myid, String)


        If intmyid = "Psicogastroenterología" Then




            myLinkString = "~/Encuestas/Psico.aspx"
        ElseIf intmyid = "Nutricional" Then


            myLinkString = "~/Encuestas/Nnutricional.aspx"

        ElseIf intmyid = "Gastroquirúrgica" Then
            myLinkString = "~/Encuestas/gastro.aspx"
        End If


        Return myLinkString


    End Function

    Public Overrides Sub VerifyRenderingInServerForm(ByVal control As Control)
        Return
    End Sub

    Protected Function checkLink2(myid As Object) As String


        Dim myLinkString As String = String.Empty


        Dim intmyid As String = DirectCast(myid, String)



        myLinkString = "~/Encuestas/Eliminar.aspx"

        Return myLinkString


    End Function
    Protected Function checkLink3(myid As Object) As String


        Dim myLinkString As String = String.Empty


        Dim intmyid As String = DirectCast(myid, String)


        If intmyid = "Psicogastroenterología" Then




            myLinkString = "~/Encuestas/ModifPsico.aspx"
        ElseIf intmyid = "Nutricional" Then


            myLinkString = "~/Encuestas/ModificaNutricion.aspx"

        ElseIf intmyid = "Gastroquirúrgica" Then
            myLinkString = "~/Encuestas/modifgastro.aspx"
        End If


        Return myLinkString


    End Function
    Protected Sub OnRowDataBound(ByVal sender As Object, ByVal e As GridViewRowEventArgs)
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        If (e.Row.RowType = DataControlRowType.DataRow) Then
            'Find the DropDownList in the Row
            Dim estado As DropDownList = CType(e.Row.FindControl("Selecestado"), DropDownList)
            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da = New SqlDataAdapter("SELECT tipo_diagnosticos FROM tipodiagnosticos", con)
                da.Fill(ds)
                estado.DataTextField = "tipo_diagnosticos"
                estado.DataValueField = "tipo_diagnosticos"
                estado.DataSource = ds.Tables(0)
                estado.DataBind()
            Catch ex As Exception

            End Try

        End If


    End Sub
    Protected Function actualizaLink(myid As Object, myid2 As Object, myid3 As Object) As String
        Dim da As New SqlDataAdapter

        Dim myLinkString As String = String.Empty


        Dim intmyid As String = DirectCast(myid, String)
        Dim intmyid2 As Integer = DirectCast(myid2, Integer)
        Dim intmyid3 As String = DirectCast(myid3, String)
        If intmyid = "Psicogastroenterología" Then

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da = New SqlDataAdapter("update psico set estadodiagnostico=@estadodiag where folionota=@folionota", con)
                da.SelectCommand.Parameters.Add("@folionota", SqlDbType.VarChar).Value = intmyid2
                da.SelectCommand.Parameters.Add("@estadodiag", SqlDbType.VarChar).Value = intmyid3
                da.SelectCommand.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
            Finally
                myLinkString = "~/Pacientes/ListaPacientes.aspx"
            End Try



        ElseIf intmyid = "Nutricional" Then


            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da = New SqlDataAdapter("update nutricional set estadodiagnostico=@estadodiag where folionota=@folionota", con)
                da.SelectCommand.Parameters.Add("@folionota", SqlDbType.VarChar).Value = intmyid2
                da.SelectCommand.Parameters.Add("@estadodiag", SqlDbType.VarChar).Value = intmyid3
                da.SelectCommand.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
            Finally
                myLinkString = "~/Pacientes/ListaPacientes.aspx"
            End Try

        ElseIf intmyid = "GastroQuirúrgica" Then
            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da = New SqlDataAdapter("update gastro set estadodiagnostico=@estadodiag where folionota=@folionota", con)
                da.SelectCommand.Parameters.Add("@folionota", SqlDbType.VarChar).Value = intmyid2
                da.SelectCommand.Parameters.Add("@estadodiag", SqlDbType.VarChar).Value = intmyid3
                da.SelectCommand.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
            Finally
                myLinkString = "~/Pacientes/ListaPacientes.aspx"
            End Try
        End If

        Return myLinkString



    End Function

    Protected Function estadodiagnostico(myid As Object) As String


        Dim myLinkString As String = String.Empty







        myLinkString = "~/Encuestas/ModificaDiagnostico.aspx"


        Return myLinkString


    End Function
    Protected Sub btnExportasPDF_Click(sender As Object, e As EventArgs) Handles btnExportasPDF.Click
        'Response.ContentType = "application/pdf"
        'Response.AddHeader("content-disposition", "attachment;filename=TestPage.pdf")
        'Response.Cache.SetCacheability(HttpCacheability.NoCache)
        'Dim sw As New StringWriter()
        'Dim hw As New HtmlTextWriter(sw)
        'Me.Page.RenderControl(hw)
        'Dim sr As New StringReader(sw.ToString())
        'Dim pdfDoc As New Document(PageSize.A4, 10.0F, 10.0F, 100.0F, 0.0F)
        'Dim htmlparser As New HTMLWorker(pdfDoc)
        'PdfWriter.GetInstance(pdfDoc, Response.OutputStream)
        'pdfDoc.Open()
        'htmlparser.Parse(sr)
        'pdfDoc.Close()
        'Response.Write(pdfDoc)
        'Response.[End]()
    End Sub
End Class