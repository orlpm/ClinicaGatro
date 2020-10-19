Imports System.Data.SqlClient
Public Class modificahistora

    Inherits System.Web.UI.Page
    Public genero As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim da, da1, da2, da3, da4, da5, da6, da7, da8, da9, da10, da11, da12, da13, da14, da15, da16, da17, da18, da19, da20, da21, da22, da23, da24, da25, da26, da27, da28, da29, da30, da31, da32, da33, da34, da35, da36, da37, da38, da39, da40, da41, da42, da43, da44, da45, da46, da47, da48, da49, da50, da51, da52, da53, da54, da55, da56, da57, da58, da59, da60, da61, da62, da63, da64, da65, da66, da67, da68, da69, da70, da71, da72, da73, da74, da75, da76, da77, da78, da79, da80, da81, da82, da83, da84, da85, da86, da87, da88, da89, da90, da91, da92, da93, da94, da95, da96, da97, da98, da99, da100, da101, da102, da103, da104, da105, da106, da107, da108, da109, da110, da111, da112, da113, da114, da115, da116, da117, da118, da119, da120, da121, da122, da123, da124, da125, da126, da127, da128, da129, da130, da131, da132, da133, da134, da135, da136, da137, da138, da139, da140, da141, da142, da143, da144, da145, da146, da147, da148, da149, da150, da151, da152, da153, da154, da155, da156, da157, da158, da159, da160, da161, da162, da163, da164, da165, da166, da167, da168, da169, da170, da171 As New SqlDataAdapter
        Dim dr, dr1, dr2, dr3, dr4, dr5, dr6, dr7, dr8, dr9, dr10, dr11, dr12, dr13, dr14, dr15, dr16, dr17, dr18, dr19, dr20, dr21, dr22, dr23, dr24, dr25, dr26, dr27, dr28, dr29, dr30, dr31, dr32, dr33, dr34, dr35, dr36, dr37, dr38, dr39, dr40, dr41, dr42, dr43, dr44, dr45, dr46, dr47, dr48, dr49, dr50, dr51, dr52, dr53, dr54, dr55, dr56, dr57, dr58, dr59, dr60, dr61, dr62, dr63, dr64, dr65, dr66, dr67, dr68, dr69, dr70, dr71, dr72, dr73, dr74, dr75, dr76, dr77, dr78, dr79, dr80, dr81, dr82, dr83, dr84, dr85, dr86, dr87, dr88, dr89, dr90, dr91, dr92, dr93, dr94, dr95, dr96, dr97, dr98, dr99, dr100, dr101, dr102, dr103, dr104, dr105, dr106, dr107, dr108, dr109, dr110, dr111, dr112, dr113, dr114, dr115, dr116, dr117, dr118, dr119, dr120, dr121, dr122, dr123, dr124, dr125, dr126, dr127, dr128, dr129, dr130, dr131, dr132, dr133, dr134, dr135, dr136, dr137, dr138, dr139, dr140, dr141, dr142, dr143, dr144, dr145, dr146, dr147, dr148, dr149, dr150, dr151, dr152, dr153, dr154, dr155, dr156, dr157, dr158, dr159, dr160, dr161, dr162, dr163, dr164, dr165, dr166, dr167, dr168, dr169, dr170, dr171 As SqlDataReader

        If Not IsPostBack Then
            Label1.Text = Session("exped")


            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da = New SqlDataAdapter("select nombres from paciente where pacienteid=@pac", con)
                da.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr = da.SelectCommand.ExecuteReader
                dr.Read()
                TextBox1.Text = dr(0)
                con.Close()
            Catch ex As Exception
                con.Close()
                MsgBox(ex.Message)
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da1 = New SqlDataAdapter("select appaterno from paciente where pacienteid=@pac", con)
                da1.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr1 = da1.SelectCommand.ExecuteReader
                dr1.Read()
                TextBox2.Text = dr1(0)
                con.Close()
            Catch ex As Exception
                con.Close()
                MsgBox(ex.Message)
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da2 = New SqlDataAdapter("select apmaterno from paciente where pacienteid=@pac", con)
                da2.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr2 = da2.SelectCommand.ExecuteReader
                dr2.Read()
                TextBox3.Text = dr2(0)
                con.Close()
            Catch ex As Exception

            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da3 = New SqlDataAdapter("select genero from paciente where pacienteid=@pac", con)
                da3.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr3 = da3.SelectCommand.ExecuteReader
                dr3.Read()
                genero = dr3(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            Finally
                If genero = 1 Then
                    Label9.Text = "Femenino"
                Else
                    Label9.Text = "Masculino"
                End If
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da4 = New SqlDataAdapter("select familiar from paciente where pacienteid=@pac", con)
                da4.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr4 = da4.SelectCommand.ExecuteReader
                dr4.Read()
                TextBox9.Text = dr4(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da5 = New SqlDataAdapter("select (cast(datediff(dd,nacimiento,GETDATE()) / 365.25 as int)) from paciente where pacienteid=@pac", con)
                da5.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr5 = da5.SelectCommand.ExecuteReader
                dr5.Read()
                Label10.Text = dr5(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da6 = New SqlDataAdapter("select telefono from paciente where pacienteid=@pac", con)
                da6.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr6 = da6.SelectCommand.ExecuteReader
                dr6.Read()
                TextBox5.Text = dr6(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da7 = New SqlDataAdapter("select telefono2 from paciente where pacienteid=@pac", con)
                da7.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr7 = da7.SelectCommand.ExecuteReader
                dr7.Read()
                TextBox4.Text = dr7(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da8 = New SqlDataAdapter("select direccion from paciente where pacienteid=@pac", con)
                da8.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr8 = da8.SelectCommand.ExecuteReader
                dr8.Read()
                TextBox6.Text = dr8(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da9 = New SqlDataAdapter("select delegacion from paciente where pacienteid=@pac", con)
                da9.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr9 = da9.SelectCommand.ExecuteReader
                dr9.Read()
                TextBox7.Text = dr9(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da10 = New SqlDataAdapter("select pais from paciente where pacienteid=@pac", con)
                da10.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr10 = da10.SelectCommand.ExecuteReader
                dr10.Read()
                TextBox8.Text = dr10(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da11 = New SqlDataAdapter("select padecimientoactual from paciente where pacienteid=@pac", con)
                da11.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr11 = da11.SelectCommand.ExecuteReader
                dr11.Read()
                TextBox10.Text = dr11(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try


            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da12 = New SqlDataAdapter("select diarrea from paciente where pacienteid=@pac", con)
                da12.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr12 = da12.SelectCommand.ExecuteReader
                dr12.Read()
                DropDownList1.Text = dr12(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da13 = New SqlDataAdapter("select hernias from paciente where pacienteid=@pac", con)
                da13.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr13 = da13.SelectCommand.ExecuteReader
                dr13.Read()
                DropDownList2.Text = dr13(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da14 = New SqlDataAdapter("select cancer from paciente where pacienteid=@pac", con)
                da14.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr14 = da14.SelectCommand.ExecuteReader
                dr14.Read()
                DropDownList3.Text = dr14(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da15 = New SqlDataAdapter("select estrenimiento from paciente where pacienteid=@pac", con)
                da15.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr15 = da15.SelectCommand.ExecuteReader
                dr15.Read()
                DropDownList4.Text = dr15(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da16 = New SqlDataAdapter("select cancerdigestivo from paciente where pacienteid=@pac", con)
                da16.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr16 = da16.SelectCommand.ExecuteReader
                dr16.Read()
                DropDownList8.Text = dr16(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da17 = New SqlDataAdapter("select colecistitis from paciente where pacienteid=@pac", con)
                da17.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr17 = da17.SelectCommand.ExecuteReader
                dr17.Read()
                DropDownList7.Text = dr17(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da18 = New SqlDataAdapter("select hipertension from paciente where pacienteid=@pac", con)
                da18.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr18 = da18.SelectCommand.ExecuteReader
                dr18.Read()
                DropDownList6.Text = dr18(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da19 = New SqlDataAdapter("select cardiopatia from paciente where pacienteid=@pac", con)
                da19.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr19 = da19.SelectCommand.ExecuteReader
                dr19.Read()
                DropDownList5.Text = dr19(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da20 = New SqlDataAdapter("select Autoinmunes from paciente where pacienteid=@pac", con)
                da20.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr20 = da20.SelectCommand.ExecuteReader
                dr20.Read()
                DropDownList9.Text = dr20(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da21 = New SqlDataAdapter("select Diabetes from paciente where pacienteid=@pac", con)
                da21.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr21 = da21.SelectCommand.ExecuteReader
                dr21.Read()
                DropDownList10.Text = dr21(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da22 = New SqlDataAdapter("select endocrinopatias from paciente where pacienteid=@pac", con)
                da22.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr22 = da22.SelectCommand.ExecuteReader
                dr22.Read()
                DropDownList11.Text = dr22(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da23 = New SqlDataAdapter("select otro from paciente where pacienteid=@pac", con)
                da23.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr23 = da22.SelectCommand.ExecuteReader
                dr23.Read()
                TextBox11.Text = dr23(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try


            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da24 = New SqlDataAdapter("select otraenfermedad from paciente where pacienteid=@pac", con)
                da24.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr24 = da24.SelectCommand.ExecuteReader
                dr24.Read()
                TextBox12.Text = dr24(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da25 = New SqlDataAdapter("select ocupacion from paciente where pacienteid=@pac", con)
                da25.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr25 = da25.SelectCommand.ExecuteReader
                dr25.Read()
                TextBox13.Text = dr25(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da26 = New SqlDataAdapter("select escolaridad from paciente where pacienteid=@pac", con)
                da26.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr26 = da26.SelectCommand.ExecuteReader
                dr26.Read()
                DropDownList12.Text = dr26(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da27 = New SqlDataAdapter("select actividadfisica from paciente where pacienteid=@pac", con)
                da27.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr27 = da27.SelectCommand.ExecuteReader
                dr27.Read()
                DropDownList13.Text = dr27(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da28 = New SqlDataAdapter("select alergicos from paciente where pacienteid=@pac", con)
                da28.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr28 = da28.SelectCommand.ExecuteReader
                dr28.Read()
                DropDownList14.Text = dr28(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da29 = New SqlDataAdapter("select alergicosdesc from paciente where pacienteid=@pac", con)
                da29.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr29 = da29.SelectCommand.ExecuteReader
                dr29.Read()
                TextBox14.Text = dr29(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try


            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da30 = New SqlDataAdapter("select cirugiasrealizadas from paciente where pacienteid=@pac", con)
                da30.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr30 = da30.SelectCommand.ExecuteReader
                dr30.Read()
                TextBox15.Text = dr30(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da31 = New SqlDataAdapter("select tranfusionales from paciente where pacienteid=@pac", con)
                da31.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr31 = da31.SelectCommand.ExecuteReader
                dr31.Read()
                DropDownList15.Text = dr31(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da32 = New SqlDataAdapter("select tranfusionalesdesc from paciente where pacienteid=@pac", con)
                da32.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr32 = da32.SelectCommand.ExecuteReader
                dr32.Read()
                TextBox17.Text = dr32(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da33 = New SqlDataAdapter("select hemotipo from paciente where pacienteid=@pac", con)
                da33.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr33 = da33.SelectCommand.ExecuteReader
                dr33.Read()
                DropDownList16.Text = dr33(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da34 = New SqlDataAdapter("select traumaticos from paciente where pacienteid=@pac", con)
                da34.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr34 = da34.SelectCommand.ExecuteReader
                dr34.Read()
                DropDownList17.Text = dr34(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da35 = New SqlDataAdapter("select traumaticosdesc from paciente where pacienteid=@pac", con)
                da35.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr35 = da35.SelectCommand.ExecuteReader
                dr35.Read()
                TextBox18.Text = dr35(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da36 = New SqlDataAdapter("select hospitalizaciones from paciente where pacienteid=@pac", con)
                da36.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr36 = da36.SelectCommand.ExecuteReader
                dr36.Read()
                DropDownList18.Text = dr36(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da37 = New SqlDataAdapter("select hospitalizacionesdesc from paciente where pacienteid=@pac", con)
                da37.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr37 = da37.SelectCommand.ExecuteReader
                dr37.Read()
                TextBox19.Text = dr37(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da38 = New SqlDataAdapter("select hipertensioncdeg from paciente where pacienteid=@pac", con)
                da38.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr38 = da38.SelectCommand.ExecuteReader
                dr38.Read()
                DropDownList19.Text = dr38(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da39 = New SqlDataAdapter("select insuficienciacardiaca from paciente where pacienteid=@pac", con)
                da39.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr39 = da39.SelectCommand.ExecuteReader
                dr39.Read()
                DropDownList20.Text = dr39(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da40 = New SqlDataAdapter("select cardiopatiacdeg from paciente where pacienteid=@pac", con)
                da40.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr40 = da40.SelectCommand.ExecuteReader
                dr40.Read()
                DropDownList21.Text = dr40(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da41 = New SqlDataAdapter("select evc from paciente where pacienteid=@pac", con)
                da41.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr41 = da41.SelectCommand.ExecuteReader
                dr41.Read()
                DropDownList22.Text = dr41(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da42 = New SqlDataAdapter("select insuficienciavenosa from paciente where pacienteid=@pac", con)
                da42.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr42 = da42.SelectCommand.ExecuteReader
                dr42.Read()
                DropDownList23.Text = dr42(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da43 = New SqlDataAdapter("select diabetesmelitus from paciente where pacienteid=@pac", con)
                da43.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr43 = da43.SelectCommand.ExecuteReader
                dr43.Read()
                DropDownList24.Text = dr43(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da44 = New SqlDataAdapter("select DISLIPIDEMMIA from paciente where pacienteid=@pac", con)
                da44.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr44 = da44.SelectCommand.ExecuteReader
                dr44.Read()
                DropDownList25.Text = dr44(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da45 = New SqlDataAdapter("select obesidad from paciente where pacienteid=@pac", con)
                da45.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr45 = da45.SelectCommand.ExecuteReader
                dr45.Read()
                DropDownList26.Text = dr45(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da46 = New SqlDataAdapter("select tiroidea from paciente where pacienteid=@pac", con)
                da46.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr46 = da46.SelectCommand.ExecuteReader
                dr46.Read()
                DropDownList30.Text = dr46(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da47 = New SqlDataAdapter("select cancerenfcdeg from paciente where pacienteid=@pac", con)
                da47.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr47 = da47.SelectCommand.ExecuteReader
                dr47.Read()
                DropDownList29.Text = dr47(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da48 = New SqlDataAdapter("select tuberculosis from paciente where pacienteid=@pac", con)
                da48.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr48 = da48.SelectCommand.ExecuteReader
                dr48.Read()
                DropDownList28.Text = dr48(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da49 = New SqlDataAdapter("select asma from paciente where pacienteid=@pac", con)
                da49.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr49 = da49.SelectCommand.ExecuteReader
                dr49.Read()
                DropDownList27.Text = dr49(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da50 = New SqlDataAdapter("select epoc from paciente where pacienteid=@pac", con)
                da50.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr50 = da50.SelectCommand.ExecuteReader
                dr50.Read()
                DropDownList31.Text = dr50(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da51 = New SqlDataAdapter("select bronquitis from paciente where pacienteid=@pac", con)
                da51.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr51 = da51.SelectCommand.ExecuteReader
                dr51.Read()
                DropDownList32.Text = dr51(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da52 = New SqlDataAdapter("select otrosenfcdeg from paciente where pacienteid=@pac", con)
                da52.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr52 = da52.SelectCommand.ExecuteReader
                dr52.Read()
                TextBox20.Text = dr52(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da53 = New SqlDataAdapter("select tratamientoactualdesc from paciente where pacienteid=@pac", con)
                da53.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr53 = da53.SelectCommand.ExecuteReader
                dr53.Read()
                TextBox21.Text = dr53(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da54 = New SqlDataAdapter("select alcoholismo from paciente where pacienteid=@pac", con)
                da54.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr54 = da54.SelectCommand.ExecuteReader
                dr54.Read()
                DropDownList33.Text = dr54(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da55 = New SqlDataAdapter("select tabaquismo from paciente where pacienteid=@pac", con)
                da55.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr55 = da55.SelectCommand.ExecuteReader
                dr55.Read()
                DropDownList34.Text = dr55(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da56 = New SqlDataAdapter("select drogas from paciente where pacienteid=@pac", con)
                da56.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr56 = da56.SelectCommand.ExecuteReader
                dr56.Read()
                DropDownList35.Text = dr56(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da57 = New SqlDataAdapter("select otrostoxicomas from paciente where pacienteid=@pac", con)
                da57.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr57 = da57.SelectCommand.ExecuteReader
                dr57.Read()
                TextBox22.Text = dr57(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da58 = New SqlDataAdapter("select Consumotoxicomas from paciente where pacienteid=@pac", con)
                da58.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr58 = da58.SelectCommand.ExecuteReader
                dr58.Read()
                TextBox23.Text = dr58(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da59 = New SqlDataAdapter("select cast(regla as date()) from paciente where pacienteid=@pac", con)
                da59.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr59 = da59.SelectCommand.ExecuteReader
                dr59.Read()
                If genero = 1 Then
                    TextBox24.Text = dr59(0)
                Else
                    TextBox24.Enabled = False
                End If
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da60 = New SqlDataAdapter("select ritmo from paciente where pacienteid=@pac", con)
                da60.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr60 = da60.SelectCommand.ExecuteReader
                dr60.Read()
                If genero = 1 Then
                    TextBox25.Text = dr60(0)
                Else
                    TextBox25.Enabled = False
                End If
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try
            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da61 = New SqlDataAdapter("select menopausia from paciente where pacienteid=@pac", con)
                da61.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr61 = da61.SelectCommand.ExecuteReader
                dr61.Read()
                If genero = 1 Then
                    DropDownList36.Text = dr61(0)
                Else
                    DropDownList36.Enabled = False
                End If
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da62 = New SqlDataAdapter("select gesta from paciente where pacienteid=@pac", con)
                da62.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr62 = da62.SelectCommand.ExecuteReader
                dr62.Read()
                If genero = 1 Then
                    DropDownList37.Text = dr62(0)
                Else
                    DropDownList37.Enabled = False
                End If
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da63 = New SqlDataAdapter("select para from paciente where pacienteid=@pac", con)
                da63.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr63 = da63.SelectCommand.ExecuteReader
                dr63.Read()
                If genero = 1 Then
                    DropDownList38.Text = dr63(0)
                Else
                    DropDownList38.Enabled = False
                End If
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try


            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da64 = New SqlDataAdapter("select cesarea from paciente where pacienteid=@pac", con)
                da64.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr64 = da64.SelectCommand.ExecuteReader
                dr64.Read()
                If genero = 1 Then
                    DropDownList39.Text = dr64(0)
                Else
                    DropDownList39.Enabled = False
                End If
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da65 = New SqlDataAdapter("select aborto from paciente where pacienteid=@pac", con)
                da65.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr65 = da65.SelectCommand.ExecuteReader
                dr65.Read()
                If genero = 1 Then
                    DropDownList40.Text = dr65(0)
                Else
                    DropDownList40.Enabled = False
                End If
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da66 = New SqlDataAdapter("select metodoanticonceptivo from paciente where pacienteid=@pac", con)
                da66.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr66 = da66.SelectCommand.ExecuteReader
                dr66.Read()
                DropDownList41.Text = dr66(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da67 = New SqlDataAdapter("select otrometodoanticonceptivo from paciente where pacienteid=@pac", con)
                da67.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr67 = da67.SelectCommand.ExecuteReader
                dr67.Read()
                TextBox26.Text = dr67(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da68 = New SqlDataAdapter("select fiebre from paciente where pacienteid=@pac", con)
                da68.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr68 = da68.SelectCommand.ExecuteReader
                dr68.Read()
                DropDownList42.Text = dr68(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da69 = New SqlDataAdapter("select astenia from paciente where pacienteid=@pac", con)
                da69.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr69 = da69.SelectCommand.ExecuteReader
                dr69.Read()
                DropDownList43.Text = dr69(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da70 = New SqlDataAdapter("select adinamia from paciente where pacienteid=@pac", con)
                da70.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr70 = da70.SelectCommand.ExecuteReader
                dr70.Read()
                DropDownList44.Text = dr70(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da71 = New SqlDataAdapter("select anorexia from paciente where pacienteid=@pac", con)
                da71.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr71 = da71.SelectCommand.ExecuteReader
                dr71.Read()
                DropDownList45.Text = dr71(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da72 = New SqlDataAdapter("select perdidapeso from paciente where pacienteid=@pac", con)
                da72.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr72 = da72.SelectCommand.ExecuteReader
                dr72.Read()
                DropDownList46.Text = dr72(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da73 = New SqlDataAdapter("select tiempoevoluciongral from paciente where pacienteid=@pac", con)
                da73.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr73 = da73.SelectCommand.ExecuteReader
                dr73.Read()
                TextBox27.Text = dr73(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da74 = New SqlDataAdapter("select obstruccionnasal from paciente where pacienteid=@pac", con)
                da74.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr74 = da74.SelectCommand.ExecuteReader
                dr74.Read()
                DropDownList47.Text = dr74(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da75 = New SqlDataAdapter("select ronquera from paciente where pacienteid=@pac", con)
                da75.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr75 = da75.SelectCommand.ExecuteReader
                dr75.Read()
                DropDownList48.Text = dr75(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da76 = New SqlDataAdapter("select sinusitis from paciente where pacienteid=@pac", con)
                da76.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr76 = da76.SelectCommand.ExecuteReader
                dr76.Read()
                DropDownList49.Text = dr76(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da77 = New SqlDataAdapter("select disfonia from paciente where pacienteid=@pac", con)
                da77.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr77 = da77.SelectCommand.ExecuteReader
                dr77.Read()
                DropDownList50.Text = dr77(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da78 = New SqlDataAdapter("select disnea from paciente where pacienteid=@pac", con)
                da78.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr78 = da78.SelectCommand.ExecuteReader
                dr78.Read()
                DropDownList51.Text = dr78(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da79 = New SqlDataAdapter("select sibilancias from paciente where pacienteid=@pac", con)
                da79.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr79 = da79.SelectCommand.ExecuteReader
                dr79.Read()
                DropDownList52.Text = dr79(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da80 = New SqlDataAdapter("select tos from paciente where pacienteid=@pac", con)
                da80.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr80 = da80.SelectCommand.ExecuteReader
                dr80.Read()
                DropDownList53.Text = dr80(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da81 = New SqlDataAdapter("select cianosis from paciente where pacienteid=@pac", con)
                da81.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr81 = da81.SelectCommand.ExecuteReader
                dr81.Read()
                DropDownList54.Text = dr81(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da82 = New SqlDataAdapter("select asmaresp from paciente where pacienteid=@pac", con)
                da82.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr82 = da82.SelectCommand.ExecuteReader
                dr82.Read()
                DropDownList55.Text = dr82(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da83 = New SqlDataAdapter("select tipoevolucionresp from paciente where pacienteid=@pac", con)
                da83.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr83 = da83.SelectCommand.ExecuteReader
                dr83.Read()
                TextBox28.Text = dr83(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da84 = New SqlDataAdapter("select lipotimia from paciente where pacienteid=@pac", con)
                da84.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr84 = da84.SelectCommand.ExecuteReader
                dr84.Read()
                DropDownList56.Text = dr84(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try



            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da85 = New SqlDataAdapter("select sincope from paciente where pacienteid=@pac", con)
                da85.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr85 = da85.SelectCommand.ExecuteReader
                dr85.Read()
                DropDownList57.Text = dr85(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da86 = New SqlDataAdapter("select fatiga from paciente where pacienteid=@pac", con)
                da86.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr86 = da86.SelectCommand.ExecuteReader
                dr86.Read()
                DropDownList58.Text = dr86(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da87 = New SqlDataAdapter("select palpitaciones from paciente where pacienteid=@pac", con)
                da87.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr87 = da87.SelectCommand.ExecuteReader
                dr87.Read()
                DropDownList59.Text = dr87(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da88 = New SqlDataAdapter("select dolorprecordial from paciente where pacienteid=@pac", con)
                da88.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr88 = da88.SelectCommand.ExecuteReader
                dr88.Read()
                DropDownList60.Text = dr88(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da89 = New SqlDataAdapter("select edema from paciente where pacienteid=@pac", con)
                da89.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr89 = da89.SelectCommand.ExecuteReader
                dr89.Read()
                DropDownList61.Text = dr89(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da90 = New SqlDataAdapter("select disneaparoxistrica from paciente where pacienteid=@pac", con)
                da90.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr90 = da90.SelectCommand.ExecuteReader
                dr90.Read()
                DropDownList62.Text = dr90(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da91 = New SqlDataAdapter("select ascitis from paciente where pacienteid=@pac", con)
                da91.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr91 = da91.SelectCommand.ExecuteReader
                dr91.Read()
                DropDownList63.Text = dr91(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da92 = New SqlDataAdapter("select tipoevolucioncardio from paciente where pacienteid=@pac", con)
                da92.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr92 = da92.SelectCommand.ExecuteReader
                dr92.Read()
                TextBox29.Text = dr92(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da93 = New SqlDataAdapter("select digestivo1 from paciente where pacienteid=@pac", con)
                da93.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr93 = da93.SelectCommand.ExecuteReader
                dr93.Read()
                If dr93(0) = "0" Then
                    DropDownList64.Text = "0 días"
                ElseIf dr93(0) = "1" Then
                    DropDownList64.Text = "1 día"
                ElseIf dr93(0) = "2" Then
                    DropDownList64.Text = "2 - 3 días"
                ElseIf dr93(0) = "3" Then
                    DropDownList64.Text = "4 - 7 días"
                End If

                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da94 = New SqlDataAdapter("select digestivo4 from paciente where pacienteid=@pac", con)
                da94.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr94 = da94.SelectCommand.ExecuteReader
                dr94.Read()
                If dr94(0) = "0" Then
                    DropDownList65.Text = "0 días"
                ElseIf dr94(0) = "1" Then
                    DropDownList65.Text = "1 día"
                ElseIf dr94(0) = "2" Then
                    DropDownList65.Text = "2 - 3 días"
                ElseIf dr94(0) = "3" Then
                    DropDownList65.Text = "4 - 7 días"
                End If
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try
            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da95 = New SqlDataAdapter("select digestivo2 from paciente where pacienteid=@pac", con)
                da95.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr95 = da95.SelectCommand.ExecuteReader
                dr95.Read()
                If dr95(0) = "0" Then
                    DropDownList66.Text = "0 días"
                ElseIf dr95(0) = "1" Then
                    DropDownList66.Text = "1 día"
                ElseIf dr95(0) = "2" Then
                    DropDownList66.Text = "2 - 3 días"
                ElseIf dr95(0) = "3" Then
                    DropDownList66.Text = "4 - 7 días"
                End If
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da96 = New SqlDataAdapter("select digestivo5 from paciente where pacienteid=@pac", con)
                da96.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr96 = da96.SelectCommand.ExecuteReader
                dr96.Read()
                If dr96(0) = "0" Then
                    DropDownList67.Text = "0 días"
                ElseIf dr96(0) = "1" Then
                    DropDownList67.Text = "1 día"
                ElseIf dr96(0) = "2" Then
                    DropDownList67.Text = "2 - 3 días"
                ElseIf dr96(0) = "3" Then
                    DropDownList67.Text = "4 - 7 días"
                End If
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da97 = New SqlDataAdapter("select digestivo3 from paciente where pacienteid=@pac", con)
                da97.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr97 = da97.SelectCommand.ExecuteReader
                dr97.Read()
                If dr97(0) = "0" Then
                    DropDownList68.Text = "0 días"
                ElseIf dr97(0) = "1" Then
                    DropDownList68.Text = "1 día"
                ElseIf dr97(0) = "2" Then
                    DropDownList68.Text = "2 - 3 días"
                ElseIf dr97(0) = "3" Then
                    DropDownList68.Text = "4 - 7 días"
                End If
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da98 = New SqlDataAdapter("select digestivo6 from paciente where pacienteid=@pac", con)
                da98.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr98 = da98.SelectCommand.ExecuteReader
                dr98.Read()
                If dr98(0) = "0" Then
                    DropDownList116.Text = "0 días"
                ElseIf dr98(0) = "1" Then
                    DropDownList116.Text = "1 día"
                ElseIf dr98(0) = "2" Then
                    DropDownList116.Text = "2 - 3 días"
                ElseIf dr98(0) = "3" Then
                    DropDownList116.Text = "4 - 7 días"
                End If
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try


            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da99 = New SqlDataAdapter("select digestivo1+digestivo2+digestivo3+digestivo4+digestivo5+digestivo6 from paciente where pacienteid=@pac", con)
                da99.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr99 = da99.SelectCommand.ExecuteReader
                dr99.Read()
                Label107.Text = dr99(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da100 = New SqlDataAdapter("select ((digestivo1+digestivo2+digestivo3+digestivo4+digestivo5+digestivo6)/18)*100 from paciente where pacienteid=@pac", con)
                da100.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr100 = da100.SelectCommand.ExecuteReader
                dr100.Read()
                Label108.Text = dr100(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da101 = New SqlDataAdapter("select intestinoirritable1 from paciente where pacienteid=@pac", con)
                da101.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr101 = da101.SelectCommand.ExecuteReader
                dr101.Read()
                DropDownList69.Text = dr101(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da102 = New SqlDataAdapter("select intestinoirritable2 from paciente where pacienteid=@pac", con)
                da102.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr102 = da102.SelectCommand.ExecuteReader
                dr102.Read()
                DropDownList72.Text = dr102(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da103 = New SqlDataAdapter("select intestinoirritable3 from paciente where pacienteid=@pac", con)
                da103.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr103 = da103.SelectCommand.ExecuteReader
                dr103.Read()
                DropDownList70.Text = dr103(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da104 = New SqlDataAdapter("select disfagia from paciente where pacienteid=@pac", con)
                da104.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr104 = da104.SelectCommand.ExecuteReader
                dr104.Read()
                DropDownList73.Text = dr104(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da105 = New SqlDataAdapter("select intestinoirritable4 from paciente where pacienteid=@pac", con)
                da105.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr105 = da105.SelectCommand.ExecuteReader
                dr105.Read()
                DropDownList71.Text = dr105(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da106 = New SqlDataAdapter("select iniciosintomasintesirri from paciente where pacienteid=@pac", con)
                da106.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr106 = da106.SelectCommand.ExecuteReader
                dr106.Read()
                TextBox30.Text = dr106(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da107 = New SqlDataAdapter("select regurgitacion from paciente where pacienteid=@pac", con)
                da107.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr107 = da107.SelectCommand.ExecuteReader
                dr107.Read()
                DropDownList74.Text = dr107(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try


            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da108 = New SqlDataAdapter("select pirosis from paciente where pacienteid=@pac", con)
                da108.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr108 = da108.SelectCommand.ExecuteReader
                dr108.Read()
                DropDownList75.Text = dr108(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da109 = New SqlDataAdapter("select dolorepigastrico from paciente where pacienteid=@pac", con)
                da109.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr109 = da109.SelectCommand.ExecuteReader
                dr109.Read()
                DropDownList76.Text = dr109(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da110 = New SqlDataAdapter("select vomito from paciente where pacienteid=@pac", con)
                da110.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr110 = da110.SelectCommand.ExecuteReader
                dr110.Read()
                DropDownList77.Text = dr110(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da111 = New SqlDataAdapter("select dolorabdominal from paciente where pacienteid=@pac", con)
                da111.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr111 = da111.SelectCommand.ExecuteReader
                dr111.Read()
                DropDownList81.Text = dr111(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da112 = New SqlDataAdapter("select globus from paciente where pacienteid=@pac", con)
                da112.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr112 = da112.SelectCommand.ExecuteReader
                dr112.Read()
                DropDownList80.Text = dr112(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da113 = New SqlDataAdapter("select nausea from paciente where pacienteid=@pac", con)
                da113.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr113 = da113.SelectCommand.ExecuteReader
                dr113.Read()
                DropDownList79.Text = dr113(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da114 = New SqlDataAdapter("select hematemesis from paciente where pacienteid=@pac", con)
                da114.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr114 = da114.SelectCommand.ExecuteReader
                dr114.Read()
                DropDownList78.Text = dr114(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da115 = New SqlDataAdapter("select colitis from paciente where pacienteid=@pac", con)
                da115.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr115 = da115.SelectCommand.ExecuteReader
                dr115.Read()
                DropDownList82.Text = dr115(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da116 = New SqlDataAdapter("select meteorismo from paciente where pacienteid=@pac", con)
                da116.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr116 = da116.SelectCommand.ExecuteReader
                dr116.Read()
                DropDownList83.Text = dr116(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da117 = New SqlDataAdapter("select anorexiatransesof from paciente where pacienteid=@pac", con)
                da117.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr117 = da117.SelectCommand.ExecuteReader
                dr117.Read()
                DropDownList84.Text = dr117(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da118 = New SqlDataAdapter("select ictericia from paciente where pacienteid=@pac", con)
                da118.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr118 = da118.SelectCommand.ExecuteReader
                dr118.Read()
                DropDownList85.Text = dr118(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da119 = New SqlDataAdapter("select iniciosintomastransesof from paciente where pacienteid=@pac", con)
                da119.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr119 = da119.SelectCommand.ExecuteReader
                dr119.Read()
                TextBox31.Text = dr119(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da120 = New SqlDataAdapter("select disuria from paciente where pacienteid=@pac", con)
                da120.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr120 = da120.SelectCommand.ExecuteReader
                dr120.Read()
                DropDownList86.Text = dr120(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da121 = New SqlDataAdapter("select polaquiuria from paciente where pacienteid=@pac", con)
                da121.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr121 = da121.SelectCommand.ExecuteReader
                dr121.Read()
                DropDownList87.Text = dr121(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da122 = New SqlDataAdapter("select tenesmovesical from paciente where pacienteid=@pac", con)
                da122.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr122 = da122.SelectCommand.ExecuteReader
                dr122.Read()
                DropDownList88.Text = dr122(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da123 = New SqlDataAdapter("select hematuria from paciente where pacienteid=@pac", con)
                da123.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr123 = da123.SelectCommand.ExecuteReader
                dr123.Read()
                DropDownList89.Text = dr123(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da124 = New SqlDataAdapter("select dolorsuprapubica from paciente where pacienteid=@pac", con)
                da124.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr124 = da124.SelectCommand.ExecuteReader
                dr124.Read()
                DropDownList90.Text = dr124(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da125 = New SqlDataAdapter("select dolorlumbar from paciente where pacienteid=@pac", con)
                da125.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr125 = da125.SelectCommand.ExecuteReader
                dr125.Read()
                DropDownList91.Text = dr125(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da126 = New SqlDataAdapter("select ningunotrans from paciente where pacienteid=@pac", con)
                da126.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr126 = da126.SelectCommand.ExecuteReader
                dr126.Read()
                DropDownList92.Text = dr126(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da127 = New SqlDataAdapter("select otrostrans from paciente where pacienteid=@pac", con)
                da127.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr127 = da127.SelectCommand.ExecuteReader
                dr127.Read()
                TextBox32.Text = dr127(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da128 = New SqlDataAdapter("select tendenciahemorragia from paciente where pacienteid=@pac", con)
                da128.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr128 = da128.SelectCommand.ExecuteReader
                dr128.Read()
                DropDownList93.Text = dr128(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da129 = New SqlDataAdapter("select adenopatias from paciente where pacienteid=@pac", con)
                da129.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr129 = da129.SelectCommand.ExecuteReader
                dr129.Read()
                DropDownList94.Text = dr129(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da130 = New SqlDataAdapter("select infeccionesrecurrentes from paciente where pacienteid=@pac", con)
                da130.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr130 = da130.SelectCommand.ExecuteReader
                dr130.Read()
                DropDownList95.Text = dr130(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da131 = New SqlDataAdapter("select anemiahemo from paciente where pacienteid=@pac", con)
                da131.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr131 = da131.SelectCommand.ExecuteReader
                dr131.Read()
                DropDownList96.Text = dr131(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da132 = New SqlDataAdapter("select negadohemo from paciente where pacienteid=@pac", con)
                da132.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr132 = da132.SelectCommand.ExecuteReader
                dr132.Read()
                DropDownList97.Text = dr132(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da133 = New SqlDataAdapter("select otroshemo from paciente where pacienteid=@pac", con)
                da133.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr133 = da133.SelectCommand.ExecuteReader
                dr133.Read()
                TextBox33.Text = dr133(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da134 = New SqlDataAdapter("select paralisis from paciente where pacienteid=@pac", con)
                da134.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr134 = da134.SelectCommand.ExecuteReader
                dr134.Read()
                DropDownList98.Text = dr134(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da135 = New SqlDataAdapter("select parestesias from paciente where pacienteid=@pac", con)
                da135.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr135 = da135.SelectCommand.ExecuteReader
                dr135.Read()
                DropDownList99.Text = dr135(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da136 = New SqlDataAdapter("select temblores from paciente where pacienteid=@pac", con)
                da136.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr136 = da136.SelectCommand.ExecuteReader
                dr136.Read()
                DropDownList100.Text = dr136(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da137 = New SqlDataAdapter("select alteracionesmarcha from paciente where pacienteid=@pac", con)
                da137.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr137 = da137.SelectCommand.ExecuteReader
                dr137.Read()
                DropDownList101.Text = dr137(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da138 = New SqlDataAdapter("select cefalea from paciente where pacienteid=@pac", con)
                da138.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr138 = da138.SelectCommand.ExecuteReader
                dr138.Read()
                DropDownList102.Text = dr138(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da139 = New SqlDataAdapter("select negadonervioso from paciente where pacienteid=@pac", con)
                da139.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr139 = da139.SelectCommand.ExecuteReader
                dr139.Read()
                DropDownList103.Text = dr139(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da140 = New SqlDataAdapter("select otrosnervioso from paciente where pacienteid=@pac", con)
                da140.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr140 = da140.SelectCommand.ExecuteReader
                dr140.Read()
                TextBox34.Text = dr140(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da141 = New SqlDataAdapter("select ansiedad from paciente where pacienteid=@pac", con)
                da141.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr141 = da141.SelectCommand.ExecuteReader
                dr141.Read()
                DropDownList104.Text = dr141(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da142 = New SqlDataAdapter("select angustia from paciente where pacienteid=@pac", con)
                da142.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr142 = da142.SelectCommand.ExecuteReader
                dr142.Read()
                DropDownList105.Text = dr142(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da143 = New SqlDataAdapter("select nerviosismo from paciente where pacienteid=@pac", con)
                da143.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr143 = da143.SelectCommand.ExecuteReader
                dr143.Read()
                DropDownList106.Text = dr143(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da144 = New SqlDataAdapter("select irritabilidad from paciente where pacienteid=@pac", con)
                da144.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr144 = da144.SelectCommand.ExecuteReader
                dr144.Read()
                DropDownList107.Text = dr144(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da145 = New SqlDataAdapter("select llanto from paciente where pacienteid=@pac", con)
                da145.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr145 = da145.SelectCommand.ExecuteReader
                dr145.Read()
                DropDownList108.Text = dr145(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da146 = New SqlDataAdapter("select insomnio from paciente where pacienteid=@pac", con)
                da146.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr146 = da146.SelectCommand.ExecuteReader
                dr146.Read()
                DropDownList109.Text = dr146(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da147 = New SqlDataAdapter("select talla from paciente where pacienteid=@pac", con)
                da147.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr147 = da147.SelectCommand.ExecuteReader
                dr147.Read()
                TextBox35.Text = dr147(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da148 = New SqlDataAdapter("select peso from paciente where pacienteid=@pac", con)
                da148.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr148 = da148.SelectCommand.ExecuteReader
                dr148.Read()
                TextBox36.Text = dr148(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da149 = New SqlDataAdapter("select peso/power(talla,2) from paciente where pacienteid=@pac", con)
                da149.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr149 = da149.SelectCommand.ExecuteReader
                dr149.Read()
                Label157.Text = dr149(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da150 = New SqlDataAdapter("select temperatura from paciente where pacienteid=@pac", con)
                da150.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr150 = da150.SelectCommand.ExecuteReader
                dr150.Read()
                TextBox37.Text = dr150(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da151 = New SqlDataAdapter("select frecuenciacardiaca from paciente where pacienteid=@pac", con)
                da151.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr151 = da151.SelectCommand.ExecuteReader
                dr151.Read()
                TextBox38.Text = dr151(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da152 = New SqlDataAdapter("select frecuenciaresp from paciente where pacienteid=@pac", con)
                da152.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr152 = da152.SelectCommand.ExecuteReader
                dr152.Read()
                TextBox39.Text = dr152(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da153 = New SqlDataAdapter("select tensionarterial from paciente where pacienteid=@pac", con)
                da153.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr153 = da153.SelectCommand.ExecuteReader
                dr153.Read()
                TextBox40.Text = dr153(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da154 = New SqlDataAdapter("select habitusexterior from paciente where pacienteid=@pac", con)
                da154.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr154 = da154.SelectCommand.ExecuteReader
                dr154.Read()
                TextBox41.Text = dr154(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da155 = New SqlDataAdapter("select cabezacuello from paciente where pacienteid=@pac", con)
                da155.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr155 = da155.SelectCommand.ExecuteReader
                dr155.Read()
                TextBox42.Text = dr155(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da156 = New SqlDataAdapter("select torax from paciente where pacienteid=@pac", con)
                da156.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr156 = da156.SelectCommand.ExecuteReader
                dr156.Read()
                TextBox43.Text = dr156(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da157 = New SqlDataAdapter("select abdomen from paciente where pacienteid=@pac", con)
                da157.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr157 = da157.SelectCommand.ExecuteReader
                dr157.Read()
                TextBox44.Text = dr157(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da158 = New SqlDataAdapter("select extremidades from paciente where pacienteid=@pac", con)
                da158.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr158 = da158.SelectCommand.ExecuteReader
                dr158.Read()
                TextBox45.Text = dr158(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da159 = New SqlDataAdapter("select neurologico from paciente where pacienteid=@pac", con)
                da159.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr159 = da159.SelectCommand.ExecuteReader
                dr159.Read()
                TextBox46.Text = dr159(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da160 = New SqlDataAdapter("select diagnostico from paciente where pacienteid=@pac", con)
                da160.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr160 = da160.SelectCommand.ExecuteReader
                dr160.Read()
                TextBox47.Text = dr160(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da161 = New SqlDataAdapter("select impresiones from paciente where pacienteid=@pac", con)
                da161.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr161 = da161.SelectCommand.ExecuteReader
                dr161.Read()
                TextBox48.Text = dr161(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da162 = New SqlDataAdapter("select enviogastro from paciente where pacienteid=@pac", con)
                da162.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr162 = da152.SelectCommand.ExecuteReader
                dr162.Read()
                DropDownList110.Text = dr162(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da163 = New SqlDataAdapter("select envionutricion from paciente where pacienteid=@pac", con)
                da163.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr163 = da163.SelectCommand.ExecuteReader
                dr163.Read()
                DropDownList111.Text = dr163(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da164 = New SqlDataAdapter("select estudioscomplementarios from paciente where pacienteid=@pac", con)
                da164.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr164 = da164.SelectCommand.ExecuteReader
                dr164.Read()
                DropDownList112.Text = dr164(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da165 = New SqlDataAdapter("select enviopsico from paciente where pacienteid=@pac", con)
                da165.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr165 = da165.SelectCommand.ExecuteReader
                dr165.Read()
                DropDownList113.Text = dr165(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da166 = New SqlDataAdapter("select medicinageneral from paciente where pacienteid=@pac", con)
                da166.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr166 = da166.SelectCommand.ExecuteReader
                dr166.Read()
                DropDownList114.Text = dr166(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da167 = New SqlDataAdapter("select enviocirugia from paciente where pacienteid=@pac", con)
                da167.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr167 = da167.SelectCommand.ExecuteReader
                dr167.Read()
                DropDownList115.Text = dr167(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da168 = New SqlDataAdapter("select fechacreacion from paciente where pacienteid=@pac", con)
                da168.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr168 = da168.SelectCommand.ExecuteReader
                dr168.Read()
                Label176.Text = dr168(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da169 = New SqlDataAdapter("select medicoencargado from paciente where pacienteid=@pac", con)
                da169.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr169 = da169.SelectCommand.ExecuteReader
                dr169.Read()
                Label177.Text = dr169(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da170 = New SqlDataAdapter("select medicocedula from paciente where pacienteid=@pac", con)
                da170.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr170 = da170.SelectCommand.ExecuteReader
                dr170.Read()
                Label178.Text = dr170(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da171 = New SqlDataAdapter("select complicaciones from paciente where pacienteid=@pac", con)
                da171.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("exped")
                dr171 = da171.SelectCommand.ExecuteReader
                dr171.Read()
                TextBox16.Text = dr171(0)
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try

        End If

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim da As New SqlDataAdapter

        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da = New SqlDataAdapter("actualizapaciente", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Label1.Text
            da.SelectCommand.Parameters.Add("@FECHA", SqlDbType.DateTime).Value = Date.Now
            da.SelectCommand.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = TextBox1.Text
            da.SelectCommand.Parameters.Add("@paterno", SqlDbType.NVarChar).Value = TextBox2.Text
            da.SelectCommand.Parameters.Add("@apmaterno", SqlDbType.NVarChar).Value = TextBox3.Text
            da.SelectCommand.Parameters.Add("@familiar", SqlDbType.NVarChar).Value = TextBox9.Text
            da.SelectCommand.Parameters.Add("@tel1", SqlDbType.NVarChar).Value = TextBox5.Text
            da.SelectCommand.Parameters.Add("@tel2", SqlDbType.NVarChar).Value = TextBox4.Text
            da.SelectCommand.Parameters.Add("@dir", SqlDbType.NVarChar).Value = TextBox6.Text
            da.SelectCommand.Parameters.Add("@delegacion", SqlDbType.NVarChar).Value = TextBox7.Text
            da.SelectCommand.Parameters.Add("@pais", SqlDbType.NVarChar).Value = TextBox8.Text
            da.SelectCommand.Parameters.Add("@edo", SqlDbType.NVarChar).Value = TextBox49.Text
            da.SelectCommand.Parameters.Add("@diarrea", SqlDbType.NVarChar).Value = DropDownList1.Text
            da.SelectCommand.Parameters.Add("@hernias", SqlDbType.NVarChar).Value = DropDownList2.Text
            da.SelectCommand.Parameters.Add("@cancer", SqlDbType.NVarChar).Value = DropDownList3.Text
            da.SelectCommand.Parameters.Add("@estrenimiento", SqlDbType.NVarChar).Value = DropDownList4.Text
            da.SelectCommand.Parameters.Add("@cancerd", SqlDbType.NVarChar).Value = DropDownList8.Text
            da.SelectCommand.Parameters.Add("@colecistitis", SqlDbType.NVarChar).Value = DropDownList7.Text
            da.SelectCommand.Parameters.Add("@hipertension", SqlDbType.NVarChar).Value = DropDownList6.Text
            da.SelectCommand.Parameters.Add("@cardiopatia", SqlDbType.NVarChar).Value = DropDownList5.Text
            da.SelectCommand.Parameters.Add("@autoinmunes", SqlDbType.NVarChar).Value = DropDownList9.Text
            da.SelectCommand.Parameters.Add("@diabetes1", SqlDbType.NVarChar).Value = DropDownList10.Text
            da.SelectCommand.Parameters.Add("@endocrinopatias", SqlDbType.NVarChar).Value = DropDownList11.Text
            da.SelectCommand.Parameters.Add("@otro", SqlDbType.NVarChar).Value = TextBox11.Text
            da.SelectCommand.Parameters.Add("@otraenf", SqlDbType.NVarChar).Value = TextBox12.Text
            da.SelectCommand.Parameters.Add("@ocupacion", SqlDbType.NVarChar).Value = TextBox13.Text
            da.SelectCommand.Parameters.Add("@escolaridad", SqlDbType.NVarChar).Value = DropDownList12.Text
            da.SelectCommand.Parameters.Add("@actfis", SqlDbType.NVarChar).Value = DropDownList13.Text
            da.SelectCommand.Parameters.Add("@alergicos", SqlDbType.NVarChar).Value = DropDownList14.Text
            da.SelectCommand.Parameters.Add("@alergdesc", SqlDbType.NVarChar).Value = TextBox14.Text
            da.SelectCommand.Parameters.Add("@cirugrealiz", SqlDbType.NVarChar).Value = TextBox15.Text
            da.SelectCommand.Parameters.Add("@complicaciones", SqlDbType.NVarChar).Value = TextBox16.Text
            da.SelectCommand.Parameters.Add("@transf", SqlDbType.NVarChar).Value = DropDownList15.Text
            da.SelectCommand.Parameters.Add("@transfesc", SqlDbType.NVarChar).Value = TextBox17.Text
            da.SelectCommand.Parameters.Add("@hemtip", SqlDbType.NVarChar).Value = DropDownList16.Text
            da.SelectCommand.Parameters.Add("@traum", SqlDbType.NVarChar).Value = DropDownList17.Text
            da.SelectCommand.Parameters.Add("@traumdesc", SqlDbType.NVarChar).Value = TextBox18.Text
            da.SelectCommand.Parameters.Add("@hosp", SqlDbType.NVarChar).Value = DropDownList18.Text
            da.SelectCommand.Parameters.Add("@hospdesc", SqlDbType.NVarChar).Value = TextBox19.Text
            da.SelectCommand.Parameters.Add("@hipertensioncdeg", SqlDbType.NVarChar).Value = DropDownList19.Text
            da.SelectCommand.Parameters.Add("@cardcdeg", SqlDbType.NVarChar).Value = DropDownList21.Text
            da.SelectCommand.Parameters.Add("@evc", SqlDbType.NVarChar).Value = DropDownList22.Text
            da.SelectCommand.Parameters.Add("@insufven", SqlDbType.NVarChar).Value = DropDownList23.Text
            da.SelectCommand.Parameters.Add("@diabetes", SqlDbType.NVarChar).Value = DropDownList24.Text
            da.SelectCommand.Parameters.Add("@dislip", SqlDbType.NVarChar).Value = DropDownList25.Text
            da.SelectCommand.Parameters.Add("@obesidad", SqlDbType.NVarChar).Value = DropDownList26.Text
            da.SelectCommand.Parameters.Add("@tiroidea", SqlDbType.NVarChar).Value = DropDownList30.Text
            da.SelectCommand.Parameters.Add("@cancerenfcdeg", SqlDbType.NVarChar).Value = DropDownList29.Text
            da.SelectCommand.Parameters.Add("@tuberculosis", SqlDbType.NVarChar).Value = DropDownList28.Text
            da.SelectCommand.Parameters.Add("@asma", SqlDbType.NVarChar).Value = DropDownList27.Text
            da.SelectCommand.Parameters.Add("@epoc", SqlDbType.NVarChar).Value = DropDownList31.Text
            da.SelectCommand.Parameters.Add("@bronquitis", SqlDbType.NVarChar).Value = DropDownList32.Text
            da.SelectCommand.Parameters.Add("@otrosenfcdeg", SqlDbType.NVarChar).Value = TextBox20.Text
            da.SelectCommand.Parameters.Add("@tratact", SqlDbType.NVarChar).Value = TextBox21.Text
            da.SelectCommand.Parameters.Add("@alcoholismo", SqlDbType.NVarChar).Value = DropDownList33.Text
            da.SelectCommand.Parameters.Add("@tabaquismo", SqlDbType.NVarChar).Value = DropDownList34.Text
            da.SelectCommand.Parameters.Add("@drogas", SqlDbType.NVarChar).Value = DropDownList35.Text
            da.SelectCommand.Parameters.Add("@otrostoxicomas", SqlDbType.NVarChar).Value = TextBox22.Text
            da.SelectCommand.Parameters.Add("@constoxic", SqlDbType.NVarChar).Value = TextBox23.Text
            If genero = 1 Then
                da.SelectCommand.Parameters.Add("@regla", SqlDbType.Date).Value = CDate(TextBox24.Text)
                da.SelectCommand.Parameters.Add("@ritmo", SqlDbType.NVarChar).Value = TextBox25.Text
                da.SelectCommand.Parameters.Add("@menopausia", SqlDbType.NVarChar).Value = DropDownList36.Text
                da.SelectCommand.Parameters.Add("@gesta", SqlDbType.Int).Value = DropDownList37.Text
                da.SelectCommand.Parameters.Add("@para", SqlDbType.Int).Value = DropDownList38.Text
                da.SelectCommand.Parameters.Add("@cesarea", SqlDbType.Int).Value = DropDownList39.Text
                da.SelectCommand.Parameters.Add("@aborto", SqlDbType.Int).Value = DropDownList40.Text
                da.SelectCommand.Parameters.Add("@metodoanticonceptivo", SqlDbType.NVarChar).Value = DropDownList41.Text
                da.SelectCommand.Parameters.Add("@otrometodoantic", SqlDbType.NVarChar).Value = TextBox26.Text
            Else
                da.SelectCommand.Parameters.Add("@regla", SqlDbType.Date).Value = DBNull.Value
                da.SelectCommand.Parameters.Add("@ritmo", SqlDbType.NVarChar).Value = DBNull.Value
                da.SelectCommand.Parameters.Add("@menopausia", SqlDbType.NVarChar).Value = DBNull.Value
                da.SelectCommand.Parameters.Add("@gesta", SqlDbType.Int).Value = "0"
                da.SelectCommand.Parameters.Add("@para", SqlDbType.Int).Value = "0"
                da.SelectCommand.Parameters.Add("@cesarea", SqlDbType.Int).Value = "0"
                da.SelectCommand.Parameters.Add("@aborto", SqlDbType.Int).Value = "0"
                da.SelectCommand.Parameters.Add("@metodoanticonceptivo", SqlDbType.NVarChar).Value = DBNull.Value
                da.SelectCommand.Parameters.Add("@otrometodoantic", SqlDbType.NVarChar).Value = DBNull.Value
            End If

            da.SelectCommand.Parameters.Add("@fiebre", SqlDbType.NVarChar).Value = DropDownList42.Text
            da.SelectCommand.Parameters.Add("@astenia", SqlDbType.NVarChar).Value = DropDownList43.Text
            da.SelectCommand.Parameters.Add("@adinamia", SqlDbType.NVarChar).Value = DropDownList44.Text
            da.SelectCommand.Parameters.Add("@anorexia", SqlDbType.NVarChar).Value = DropDownList45.Text
            da.SelectCommand.Parameters.Add("@perdidapeso", SqlDbType.NVarChar).Value = DropDownList46.Text
            da.SelectCommand.Parameters.Add("@tiempoevoluciongral", SqlDbType.NVarChar).Value = TextBox27.Text
            da.SelectCommand.Parameters.Add("@obstnasal", SqlDbType.NVarChar).Value = DropDownList47.Text
            da.SelectCommand.Parameters.Add("@ronquera", SqlDbType.NVarChar).Value = DropDownList48.Text
            da.SelectCommand.Parameters.Add("@sinusitis", SqlDbType.NVarChar).Value = DropDownList49.Text
            da.SelectCommand.Parameters.Add("@disfonia", SqlDbType.NVarChar).Value = DropDownList50.Text
            da.SelectCommand.Parameters.Add("@disnea", SqlDbType.NVarChar).Value = DropDownList51.Text
            da.SelectCommand.Parameters.Add("@sibilancias", SqlDbType.NVarChar).Value = DropDownList52.Text
            da.SelectCommand.Parameters.Add("@tos", SqlDbType.NVarChar).Value = DropDownList53.Text
            da.SelectCommand.Parameters.Add("@cianosis", SqlDbType.NVarChar).Value = DropDownList54.Text
            da.SelectCommand.Parameters.Add("@asmaresp", SqlDbType.NVarChar).Value = DropDownList55.Text
            da.SelectCommand.Parameters.Add("@tipoevolucionresp", SqlDbType.NVarChar).Value = TextBox28.Text
            da.SelectCommand.Parameters.Add("@lipotimia", SqlDbType.NVarChar).Value = DropDownList56.Text
            da.SelectCommand.Parameters.Add("@sincope", SqlDbType.NVarChar).Value = DropDownList57.Text
            da.SelectCommand.Parameters.Add("@fatiga", SqlDbType.NVarChar).Value = DropDownList58.Text
            da.SelectCommand.Parameters.Add("@palpitaciones", SqlDbType.NVarChar).Value = DropDownList59.Text
            da.SelectCommand.Parameters.Add("@dolorprecordial", SqlDbType.NVarChar).Value = DropDownList60.Text
            da.SelectCommand.Parameters.Add("@edema", SqlDbType.NVarChar).Value = DropDownList61.Text
            da.SelectCommand.Parameters.Add("@disparox", SqlDbType.NVarChar).Value = DropDownList62.Text
            da.SelectCommand.Parameters.Add("@ascitis", SqlDbType.NVarChar).Value = DropDownList63.Text
            da.SelectCommand.Parameters.Add("@tipoevcard", SqlDbType.NVarChar).Value = TextBox29.Text
            If DropDownList64.SelectedValue = "0 días" Then
                da.SelectCommand.Parameters.Add("@dig1", SqlDbType.Int).Value = "0"
            ElseIf DropDownList64.SelectedValue = "1 día" Then
                da.SelectCommand.Parameters.Add("@dig1", SqlDbType.Int).Value = "1"
            ElseIf DropDownList64.SelectedValue = "2 - 3 días" Then
                da.SelectCommand.Parameters.Add("@dig1", SqlDbType.Int).Value = "2"
            ElseIf DropDownList64.SelectedValue = "4 - 7 días" Then
                da.SelectCommand.Parameters.Add("@dig1", SqlDbType.Int).Value = "3"
            End If
            If DropDownList66.SelectedValue = "0 días" Then
                da.SelectCommand.Parameters.Add("@dig2", SqlDbType.Int).Value = "0"
            ElseIf DropDownList66.SelectedValue = "1 día" Then
                da.SelectCommand.Parameters.Add("@dig2", SqlDbType.Int).Value = "1"
            ElseIf DropDownList66.SelectedValue = "2 - 3 días" Then
                da.SelectCommand.Parameters.Add("@dig2", SqlDbType.Int).Value = "2"
            ElseIf DropDownList66.SelectedValue = "4 - 7 días" Then
                da.SelectCommand.Parameters.Add("@dig2", SqlDbType.Int).Value = "3"
            End If
            If DropDownList68.SelectedValue = "0 días" Then
                da.SelectCommand.Parameters.Add("@dig3", SqlDbType.Int).Value = "0"
            ElseIf DropDownList68.SelectedValue = "1 día" Then
                da.SelectCommand.Parameters.Add("@dig3", SqlDbType.Int).Value = "1"
            ElseIf DropDownList68.SelectedValue = "2 - 3 días" Then
                da.SelectCommand.Parameters.Add("@dig3", SqlDbType.Int).Value = "2"
            ElseIf DropDownList68.SelectedValue = "4 - 7 días" Then
                da.SelectCommand.Parameters.Add("@dig3", SqlDbType.Int).Value = "3"
            End If
            If DropDownList65.SelectedValue = "0 días" Then
                da.SelectCommand.Parameters.Add("@dig4", SqlDbType.Int).Value = "0"
            ElseIf DropDownList65.SelectedValue = "1 día" Then
                da.SelectCommand.Parameters.Add("@dig4", SqlDbType.Int).Value = "1"
            ElseIf DropDownList65.SelectedValue = "2 - 3 días" Then
                da.SelectCommand.Parameters.Add("@dig4", SqlDbType.Int).Value = "2"
            ElseIf DropDownList65.SelectedValue = "4 - 7 días" Then
                da.SelectCommand.Parameters.Add("@dig4", SqlDbType.Int).Value = "3"
            End If
            If DropDownList67.SelectedValue = "0 días" Then
                da.SelectCommand.Parameters.Add("@dig5", SqlDbType.Int).Value = "0"
            ElseIf DropDownList67.SelectedValue = "1 día" Then
                da.SelectCommand.Parameters.Add("@dig5", SqlDbType.Int).Value = "1"
            ElseIf DropDownList67.SelectedValue = "2 - 3 días" Then
                da.SelectCommand.Parameters.Add("@dig5", SqlDbType.Int).Value = "2"
            ElseIf DropDownList67.SelectedValue = "4 - 7 días" Then
                da.SelectCommand.Parameters.Add("@dig5", SqlDbType.Int).Value = "3"
            End If
            If DropDownList116.SelectedValue = "0 días" Then
                da.SelectCommand.Parameters.Add("@dig6", SqlDbType.Int).Value = "0"
            ElseIf DropDownList116.SelectedValue = "1 día" Then
                da.SelectCommand.Parameters.Add("@dig6", SqlDbType.Int).Value = "1"
            ElseIf DropDownList116.SelectedValue = "2 - 3 días" Then
                da.SelectCommand.Parameters.Add("@dig6", SqlDbType.Int).Value = "2"
            ElseIf DropDownList116.SelectedValue = "4 - 7 días" Then
                da.SelectCommand.Parameters.Add("@dig6", SqlDbType.Int).Value = "3"
            End If

            da.SelectCommand.Parameters.Add("@intirr1", SqlDbType.NVarChar).Value = DropDownList69.Text
            da.SelectCommand.Parameters.Add("@intirr2", SqlDbType.NVarChar).Value = DropDownList70.Text
            da.SelectCommand.Parameters.Add("@intirr3", SqlDbType.NVarChar).Value = DropDownList71.Text
            da.SelectCommand.Parameters.Add("@intirr4", SqlDbType.NVarChar).Value = DropDownList72.Text
            da.SelectCommand.Parameters.Add("@disfagia", SqlDbType.NVarChar).Value = DropDownList73.Text
            da.SelectCommand.Parameters.Add("@inisintsinirri", SqlDbType.NVarChar).Value = TextBox30.Text
            da.SelectCommand.Parameters.Add("@regurg", SqlDbType.NVarChar).Value = DropDownList74.Text
            da.SelectCommand.Parameters.Add("@pirosis", SqlDbType.NVarChar).Value = DropDownList75.Text
            da.SelectCommand.Parameters.Add("@dolorepig", SqlDbType.NVarChar).Value = DropDownList76.Text
            da.SelectCommand.Parameters.Add("@vomito", SqlDbType.NVarChar).Value = DropDownList77.Text
            da.SelectCommand.Parameters.Add("@hematemesis", SqlDbType.NVarChar).Value = DropDownList78.Text
            da.SelectCommand.Parameters.Add("@nausea", SqlDbType.NVarChar).Value = DropDownList79.Text
            da.SelectCommand.Parameters.Add("@globus", SqlDbType.NVarChar).Value = DropDownList80.Text
            da.SelectCommand.Parameters.Add("@dolorabd", SqlDbType.NVarChar).Value = DropDownList81.Text
            da.SelectCommand.Parameters.Add("@colitis", SqlDbType.NVarChar).Value = DropDownList82.Text
            da.SelectCommand.Parameters.Add("@meteorismo", SqlDbType.NVarChar).Value = DropDownList83.Text
            da.SelectCommand.Parameters.Add("@anorexiatransesof", SqlDbType.NVarChar).Value = DropDownList84.Text
            da.SelectCommand.Parameters.Add("@ictericia", SqlDbType.NVarChar).Value = DropDownList85.Text
            da.SelectCommand.Parameters.Add("@initransesof", SqlDbType.NVarChar).Value = TextBox31.Text
            da.SelectCommand.Parameters.Add("@disuria", SqlDbType.NVarChar).Value = DropDownList86.Text
            da.SelectCommand.Parameters.Add("@poliaquiuria", SqlDbType.NVarChar).Value = DropDownList87.Text
            da.SelectCommand.Parameters.Add("@tenesmovesical", SqlDbType.NVarChar).Value = DropDownList88.Text
            da.SelectCommand.Parameters.Add("@hematuria", SqlDbType.NVarChar).Value = DropDownList89.Text
            da.SelectCommand.Parameters.Add("@dolsuprapub", SqlDbType.NVarChar).Value = DropDownList90.Text
            da.SelectCommand.Parameters.Add("@dolorlumbar", SqlDbType.NVarChar).Value = DropDownList91.Text
            da.SelectCommand.Parameters.Add("@ningtrans", SqlDbType.NVarChar).Value = DropDownList92.Text
            da.SelectCommand.Parameters.Add("@otrostrans", SqlDbType.NVarChar).Value = TextBox32.Text
            da.SelectCommand.Parameters.Add("@tendhemorr", SqlDbType.NVarChar).Value = DropDownList93.Text
            da.SelectCommand.Parameters.Add("@adenopatias", SqlDbType.NVarChar).Value = DropDownList94.Text
            da.SelectCommand.Parameters.Add("@infrec", SqlDbType.NVarChar).Value = DropDownList95.Text
            da.SelectCommand.Parameters.Add("@anemiahemo", SqlDbType.NVarChar).Value = DropDownList96.Text
            da.SelectCommand.Parameters.Add("@neghemo", SqlDbType.NVarChar).Value = DropDownList97.Text
            da.SelectCommand.Parameters.Add("@otroshemo", SqlDbType.NVarChar).Value = TextBox33.Text
            da.SelectCommand.Parameters.Add("@paralisis", SqlDbType.NVarChar).Value = DropDownList98.Text
            da.SelectCommand.Parameters.Add("@parestesias", SqlDbType.NVarChar).Value = DropDownList99.Text
            da.SelectCommand.Parameters.Add("@temblores", SqlDbType.NVarChar).Value = DropDownList100.Text
            da.SelectCommand.Parameters.Add("@alteracionesmarcha", SqlDbType.NVarChar).Value = DropDownList101.Text
            da.SelectCommand.Parameters.Add("@cefalea", SqlDbType.NVarChar).Value = DropDownList102.Text
            da.SelectCommand.Parameters.Add("@negnerv", SqlDbType.NVarChar).Value = DropDownList103.Text
            da.SelectCommand.Parameters.Add("@otrosnerv", SqlDbType.NVarChar).Value = TextBox34.Text
            da.SelectCommand.Parameters.Add("@ansiedad", SqlDbType.NVarChar).Value = DropDownList104.Text
            da.SelectCommand.Parameters.Add("@angustia", SqlDbType.NVarChar).Value = DropDownList105.Text
            da.SelectCommand.Parameters.Add("@nerviosismo", SqlDbType.NVarChar).Value = DropDownList106.Text
            da.SelectCommand.Parameters.Add("@irritabilidad", SqlDbType.NVarChar).Value = DropDownList107.Text
            da.SelectCommand.Parameters.Add("@llano", SqlDbType.NVarChar).Value = DropDownList108.Text
            da.SelectCommand.Parameters.Add("@insomnio", SqlDbType.NVarChar).Value = DropDownList109.Text
            If TextBox35.Text = "" Then
                da.SelectCommand.Parameters.Add("@talla", SqlDbType.Float).Value = "0"
            Else
                da.SelectCommand.Parameters.Add("@talla", SqlDbType.Float).Value = TextBox35.Text
            End If
            If TextBox36.Text = "" Then
                da.SelectCommand.Parameters.Add("@peso", SqlDbType.Float).Value = "0"
            Else
                da.SelectCommand.Parameters.Add("@peso", SqlDbType.Float).Value = TextBox36.Text
            End If
            If TextBox37.Text = "" Then
                da.SelectCommand.Parameters.Add("@temp", SqlDbType.Float).Value = "0"
            Else
                da.SelectCommand.Parameters.Add("@temp", SqlDbType.Float).Value = TextBox37.Text
            End If

            da.SelectCommand.Parameters.Add("@fc", SqlDbType.NVarChar).Value = TextBox38.Text
            da.SelectCommand.Parameters.Add("@fr", SqlDbType.NVarChar).Value = TextBox39.Text
            da.SelectCommand.Parameters.Add("@ta", SqlDbType.NVarChar).Value = TextBox40.Text
            da.SelectCommand.Parameters.Add("@habext", SqlDbType.NVarChar).Value = TextBox41.Text
            da.SelectCommand.Parameters.Add("@cabezacuello", SqlDbType.NVarChar).Value = TextBox42.Text
            da.SelectCommand.Parameters.Add("@torax", SqlDbType.NVarChar).Value = TextBox43.Text
            da.SelectCommand.Parameters.Add("@abdomen", SqlDbType.NVarChar).Value = TextBox44.Text
            da.SelectCommand.Parameters.Add("@extremidades", SqlDbType.NVarChar).Value = TextBox45.Text
            da.SelectCommand.Parameters.Add("@neurologico", SqlDbType.NVarChar).Value = TextBox46.Text
            da.SelectCommand.Parameters.Add("@diag", SqlDbType.NVarChar).Value = TextBox47.Text
            da.SelectCommand.Parameters.Add("@impp", SqlDbType.NVarChar).Value = TextBox48.Text
            da.SelectCommand.Parameters.Add("@envgast", SqlDbType.NVarChar).Value = DropDownList110.Text
            da.SelectCommand.Parameters.Add("@envnut", SqlDbType.NVarChar).Value = DropDownList111.Text
            da.SelectCommand.Parameters.Add("@estudioscompl", SqlDbType.NVarChar).Value = DropDownList112.Text
            da.SelectCommand.Parameters.Add("@enviopsico", SqlDbType.NVarChar).Value = DropDownList113.Text
            da.SelectCommand.Parameters.Add("@medicinageneral", SqlDbType.NVarChar).Value = DropDownList114.Text
            da.SelectCommand.Parameters.Add("@envcir", SqlDbType.NVarChar).Value = DropDownList115.Text
            da.SelectCommand.Parameters.Add("@padact", SqlDbType.NVarChar).Value = TextBox10.Text
            da.SelectCommand.Parameters.Add("@inscard", SqlDbType.NVarChar).Value = DropDownList20.Text
            da.SelectCommand.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        Finally
            Response.Redirect("\Pacientes\ExpCompleto.aspx" & "?Expediente=" & Label1.Text)
        End Try


    End Sub
End Class