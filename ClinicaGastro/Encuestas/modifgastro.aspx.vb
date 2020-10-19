Imports System.Data.SqlClient
Public Class modifgastro
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label2.Text = Date.Now
        Dim da, da1, da2, da3, da4, da5, da6, da7, da8, da9, da10, da11, da12, da13, da14, da15, da16, da17, da18, da19, da20, da21, da22, da23, da24, da25, da26, da27, da28, da29, da30, da31, da32, da33, da34, da35, da36, da37, da38, da39, da40, da41, da42, da43, da44, da45, da46, da47, da48, da49, da50, da51, da52, da53, da54, da55, da56, da57, da58, da59, da60, da61, da62, da63, da64, da65, da66, da67, da68, da69, da70, da71, da72, da73, da74, da75, da76, da77, da78, da79, da80, da81, da82, da83, da84, da85, da86, da87, da88, da89, da90, da91, da92, da93, da94, da95, da96, da97, da98, da99, da100, da101, da102, da103, da104, da105, da106, da107, da108, da109, da110, da111, da112, da113, da114, da115, da116, da117, da118, da119, da120, da121, da122, da123, da124, da125, da126, da127, da128, da129, da130, da131, da132, da133, da134, da135, da136, da137, da138, da139, da140, da141, da142, da143, da144, da145, da146, da147, da148, da149, da150, da151, da152, da153, da154, da155, da156, da157, da158, da159, da160, da161, da162, da163, da164, da165, da166, da167, da168, da169, da170, da171, da172, da173, da174, da175, da176, da177, da178, da179, da180, da181, da182, da183, da184, da185, da186, da187, da188, da189, da190, da191, da192, da193, da194, da195, da196, da197, da198, da199, da200, da201, da202, da203, da204, da205, da206, da207, da208, da209, da210, da211, da212, da213, da214, da215, da216, da217, da218, da219, da220, da221, da222, da223, da224 As New SqlDataAdapter
        Dim ds, ds1, ds2, ds3 As New DataSet
        Dim dr, dr1, dr2, dr3, dr4, dr5, dr6, dr7, dr8, dr9, dr10, dr11, dr12, dr13, dr14, dr15, dr16, dr17, dr18, dr19, dr20, dr21, dr22, dr23, dr24, dr25, dr26, dr27, dr28, dr29, dr30, dr31, dr32, dr33, dr34, dr35, dr36, dr37, dr38, dr39, dr40, dr41, dr42, dr43, dr44, dr45, dr46, dr47, dr48, dr49, dr50, dr51, dr52, dr53, dr54, dr58, dr59, dr60, dr61, dr62, dr63, dr64, dr65, dr66, dr67, dr68, dr69, dr70, dr71, dr72, dr73, dr74, dr75, dr76, dr77, dr78, dr79, dr80, dr81, dr82, dr83, dr84, dr85, dr86, dr87, dr88, dr89, dr90, dr91, dr92, dr93, dr94, dr95, dr96, dr97, dr98, dr99, dr100, dr101, dr102, dr103, dr104, dr105, dr106, dr107, dr108, dr109, dr110, dr111, dr112, dr113, dr114, dr115, dr116, dr117, dr118, dr119, dr120, dr121, dr122, dr123, dr124, dr125, dr126, dr127, dr128, dr129, dr130, dr131, dr132, dr133, dr134, dr135, dr136, dr137, dr138, dr139, dr140, dr141, dr143, dr144, dr145, dr146, dr147, dr148, dr149, dr150, dr151, dr152, dr153, dr154, dr155, dr156, dr157, dr158, dr159, dr160, dr161, dr162, dr163, dr164, dr165, dr166, dr167, dr168, dr169, dr170, dr171, dr172, dr173, dr174, dr175, dr176, dr177, dr178, dr179, dr180, dr181, dr182, dr183, dr184, dr185, dr186, dr187, dr188, dr189, dr190, dr191, dr192, dr193, dr194, dr195, dr196, dr197, dr198, dr199, dr200, dr201, dr202, dr203, dr204, dr205, dr206, dr207, dr208, dr209, dr210, dr211, dr212, dr213, dr214, dr215, dr216, dr217, dr218, dr219, dr222, dr220, dr221 As SqlDataReader
        Dim nacimiento As Date
        If Request.Params("id2") IsNot Nothing Then
            Session("numnota2") = Request.Params("id2")
            Session("paciente") = Request.Params("pac")

            If Not IsPostBack Then
                ocultar.Visible = False
                Label7.Text = Session("paciente")
                Label8.Text = Session("nomus")
                'ocultar.Visible = True
                Label9.Text = ConfigurationManager.AppSettings("cedula")


                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    da3 = New SqlDataAdapter("select nombres from paciente where pacienteid=@id", con)
                    da3.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("paciente")
                    dr = da3.SelectCommand.ExecuteReader
                    dr.Read()
                    TextBox8.Visible = False
                    Label3.Visible = True
                    Label3.Text = dr(0)
                    con.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally

                End Try

                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()

                    End If
                    con.Open()
                    da4 = New SqlDataAdapter("select appaterno from paciente where pacienteid=@id", con)
                    da4.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("paciente")
                    dr1 = da4.SelectCommand.ExecuteReader
                    dr1.Read()
                    TextBox9.Visible = False
                    Label4.Visible = True
                    Label4.Text = dr1(0)
                    con.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    da5 = New SqlDataAdapter("select apmaterno from paciente where pacienteid=@id", con)
                    da5.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("paciente")
                    dr2 = da5.SelectCommand.ExecuteReader
                    dr2.Read()
                    TextBox10.Visible = False
                    Label5.Visible = True
                    Label5.Text = dr2(0)
                    con.Close()
                Catch ex As Exception

                End Try

                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    da223 = New SqlDataAdapter("select nacimiento from paciente where pacienteid=@id", con)
                    da223.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("paciente")
                    dr222 = da223.SelectCommand.ExecuteReader
                    dr222.Read()
                    If dr222.HasRows Then
                        nacimiento = dr222(0)
                    End If
                    con.Close()
                Catch ex As Exception

                End Try

                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    da6 = New SqlDataAdapter("select (cast(datediff(dd,nacimiento,GETDATE()) / 365.25 as int)) from paciente where pacienteid=@pac", con)
                    da6.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                    dr3 = da6.SelectCommand.ExecuteReader
                    dr3.Read()
                    TextBox11.Visible = False
                    Label6.Visible = True
                    Label6.Text = dr3(0)
                    con.Close()
                Catch ex As Exception
                    con.Close()
                End Try

                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    da221 = New SqlDataAdapter("select distinct genero from paciente where pacienteid=@pac", con)
                    da221.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                    dr219 = da221.SelectCommand.ExecuteReader
                    dr219.Read()
                    If dr219.HasRows Then

                        Label436.Text = dr219(0)
                        If Label436.Text = "1" Then
                            DropDownList200.Text = "Mujer"
                        Else
                            DropDownList200.Text = "Hombre"
                        End If

                        Label436.Visible = False
                    End If
                    con.Close()
                Catch ex As Exception

                End Try
                

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da222 = New SqlDataAdapter("select distinct proyeccion from gastro where pacienteid=@pac and folionota=@folio", con)
                        da222.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da222.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr220 = da222.SelectCommand.ExecuteReader
                        dr220.Read()
                        If dr220.HasRows Then
                            TextBox18.Text = dr220(0)
                            TextBox18.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da7 = New SqlDataAdapter("select distinct diarrea from gastro where pacienteid=@pac and folionota=@folio", con)
                        da7.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da7.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr4 = da7.SelectCommand.ExecuteReader
                        dr4.Read()
                        If dr4.HasRows Then
                            DropDownList17.Visible = False
                            DropDownList17.Text = dr4(0)
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da8 = New SqlDataAdapter("select distinct hernias from gastro where pacienteid=@pac and folionota=@folio", con)
                        da8.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da8.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr5 = da8.SelectCommand.ExecuteReader
                        dr5.Read()
                        If dr5.HasRows Then
                            DropDownList21.Visible = True
                            DropDownList21.Text = dr5(0)
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try
                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da9 = New SqlDataAdapter("select distinct cancer from gastro where pacienteid=@pac and folionota=@folio", con)
                        da9.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da9.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr6 = da9.SelectCommand.ExecuteReader
                        dr6.Read()
                        If dr6.HasRows Then
                            DropDownList25.Visible = True
                            DropDownList25.Text = dr6(0)
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da10 = New SqlDataAdapter("select distinct estrenimiento from gastro where pacienteid=@pac and folionota=@folio", con)
                        da10.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da10.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr7 = da10.SelectCommand.ExecuteReader
                        dr7.Read()
                        If dr7.HasRows Then
                            DropDownList29.Visible = True
                            DropDownList29.Text = dr7(0)
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da11 = New SqlDataAdapter("select distinct cancerdigestivo from gastro where pacienteid=@pac and folionota=@folio", con)
                        da11.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da11.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr8 = da11.SelectCommand.ExecuteReader
                        dr8.Read()
                        If dr8.HasRows Then
                            DropDownList33.Visible = True
                            DropDownList33.Text = dr8(0)
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try
                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da12 = New SqlDataAdapter("select distinct colecistitis from gastro where pacienteid=@pac and folionota=@folio", con)
                        da12.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da12.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr9 = da12.SelectCommand.ExecuteReader
                        dr9.Read()
                        If dr9.HasRows Then
                            DropDownList37.Visible = True
                            DropDownList37.Text = dr9(0)
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da13 = New SqlDataAdapter("select distinct hipertension from gastro where pacienteid=@pac and folionota=@folio", con)
                        da13.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da13.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr10 = da13.SelectCommand.ExecuteReader
                        dr10.Read()
                        If dr10.HasRows Then
                            DropDownList41.Visible = True
                            DropDownList41.Text = dr10(0)
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try
                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da14 = New SqlDataAdapter("select distinct cardiopatia from gastro where pacienteid=@pac and folionota=@folio", con)
                        da14.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da14.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr11 = da14.SelectCommand.ExecuteReader
                        dr11.Read()
                        If dr11.HasRows Then
                            DropDownList45.Visible = True
                            DropDownList45.Text = dr11(0)
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da15 = New SqlDataAdapter("select distinct autoinmunes from gastro where pacienteid=@pac and folionota=@folio", con)
                        da15.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da15.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr12 = da15.SelectCommand.ExecuteReader
                        dr12.Read()
                        If dr12.HasRows Then
                            DropDownList49.Visible = True
                            DropDownList49.Text = dr12(0)
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da16 = New SqlDataAdapter("select distinct diabetes from gastro where pacienteid=@pac and folionota=@folio", con)
                        da16.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da16.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr13 = da16.SelectCommand.ExecuteReader
                        dr13.Read()
                        If dr13.HasRows Then
                            DropDownList53.Visible = True
                            DropDownList53.Text = dr13(0)
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da17 = New SqlDataAdapter("select distinct endocrinopatias from gastro where pacienteid=@pac and folionota=@folio", con)
                        da17.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da17.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr14 = da17.SelectCommand.ExecuteReader
                        dr14.Read()
                        If dr14.HasRows Then
                            DropDownList57.Visible = True
                            DropDownList57.Text = dr14(0)
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try
                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da18 = New SqlDataAdapter("select distinct otrosenf from gastro where pacienteid=@pac and folionota=@folio", con)
                        da18.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da18.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr15 = da18.SelectCommand.ExecuteReader
                        dr15.Read()
                        If dr15.HasRows Then
                            TextBox85.Visible = True
                            TextBox85.Text = dr15(0)
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da224 = New SqlDataAdapter("select distinct otrosfam from gastro where pacienteid=@pac and folionota=@folio", con)
                        da224.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da224.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr221 = da224.SelectCommand.ExecuteReader
                        dr221.Read()
                        If dr221.HasRows Then
                            DropDownList168.Visible = True
                            DropDownList168.Text = dr221(0)
                        End If
                    Catch ex As Exception

                    End Try
                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da19 = New SqlDataAdapter("select distinct otrosfam from gastro where pacienteid=@pac and folionota=@folio", con)
                        da19.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da19.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr16 = da19.SelectCommand.ExecuteReader
                        dr16.Read()
                        If dr16.HasRows Then
                            DropDownList61.Visible = True
                            DropDownList61.Text = dr16(0)
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da20 = New SqlDataAdapter("select distinct ocupacion from gastro where pacienteid=@pac and folionota=@folio", con)
                        da20.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da20.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr17 = da20.SelectCommand.ExecuteReader
                        dr17.Read()
                        If dr17.HasRows Then
                            TextBox91.Visible = True
                            TextBox91.Text = dr17(0)
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try
                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da21 = New SqlDataAdapter("select distinct escolaridad from gastro where pacienteid=@pac and folionota=@folio", con)
                        da21.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da21.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr18 = da21.SelectCommand.ExecuteReader
                        dr18.Read()
                        If dr18.HasRows Then
                            DropDownList61.Visible = True
                            DropDownList61.Text = dr18(0)
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try
                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da22 = New SqlDataAdapter("select distinct actfis from gastro where pacienteid=@pac and folionota=@folio", con)
                        da22.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da22.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr19 = da22.SelectCommand.ExecuteReader
                        dr19.Read()
                        If dr19.HasRows Then
                            DropDownList64.Visible = True
                            DropDownList64.Text = dr19(0)
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da23 = New SqlDataAdapter("select distinct alergicos from gastro where pacienteid=@pac and folionota=@folio", con)
                        da23.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da23.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr20 = da23.SelectCommand.ExecuteReader
                        dr20.Read()
                        If dr20.HasRows Then
                            TextBox94.Visible = True
                            DropDownList65.Visible = True
                            TextBox94.Text = dr20(0)
                            If TextBox94.Text <> "No" Then
                                DropDownList65.Text = "Si"
                            Else
                                DropDownList65.Text = "No"
                                TextBox94.Text = ""
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da24 = New SqlDataAdapter("select distinct cirugias from gastro where pacienteid=@pac and folionota=@folio", con)
                        da24.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da24.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr21 = da24.SelectCommand.ExecuteReader
                        dr21.Read()
                        If dr21.HasRows Then
                            TextBox97.Visible = True
                            TextBox97.Text = dr21(0)
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try
                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da25 = New SqlDataAdapter("select distinct complicacionescirugias from gastro where pacienteid=@pac and folionota=@folio", con)
                        da25.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da25.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr22 = da25.SelectCommand.ExecuteReader
                        dr22.Read()
                        If dr22.HasRows Then
                            TextBox115.Visible = True
                            TextBox115.Text = dr22(0)
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da26 = New SqlDataAdapter("select distinct transfusiones from gastro where pacienteid=@pac and folionota=@folio", con)
                        da26.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da26.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr23 = da26.SelectCommand.ExecuteReader
                        dr23.Read()
                        If dr23.HasRows Then
                            DropDownList66.Visible = True
                            TextBox116.Visible = True
                            TextBox116.Text = dr23(0)
                            If TextBox116.Text <> "No" Then
                                DropDownList66.Text = "Si"
                            Else
                                DropDownList66.Text = "No"
                                TextBox116.Text = ""
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da27 = New SqlDataAdapter("select distinct tiposangre from gastro where pacienteid=@pac and folionota=@folio", con)
                        da27.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da27.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr24 = da27.SelectCommand.ExecuteReader
                        dr24.Read()
                        If dr24.HasRows Then
                            DropDownList67.Visible = True
                            DropDownList67.Text = dr24(0)
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da28 = New SqlDataAdapter("select distinct fracturas from gastro where pacienteid=@pac and folionota=@folio", con)
                        da28.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da28.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr25 = da28.SelectCommand.ExecuteReader
                        dr25.Read()
                        If dr25.HasRows Then
                            DropDownList68.Visible = False
                            TextBox117.Visible = False
                            TextBox117.Text = dr25(0)
                            If TextBox117.Text <> "No" Then
                                DropDownList68.Text = "Si"
                            Else
                                DropDownList68.Text = "No"
                                TextBox117.Text = ""
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da29 = New SqlDataAdapter("select distinct hospprevias from gastro where pacienteid=@pac and folionota=@folio", con)
                        da29.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da29.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr26 = da29.SelectCommand.ExecuteReader
                        dr26.Read()
                        TextBox118.Visible = False
                        If dr26.HasRows Then
                            DropDownList69.Visible = True
                            TextBox117.Visible = True
                            TextBox117.Text = dr26(0)
                            If TextBox117.Text <> "No" Then
                                DropDownList69.Text = "Si"
                            Else
                                DropDownList69.Text = "No"
                                TextBox117.Text = ""
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try
                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da30 = New SqlDataAdapter("select distinct tiempohipertension from gastro where pacienteid=@pac and folionota=@folio", con)
                        da30.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da30.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr27 = da30.SelectCommand.ExecuteReader
                        dr27.Read()
                        If dr27.HasRows Then
                            DropDownList169.Visible = True
                            TextBox148.Visible = True
                            TextBox149.Visible = True
                            TextBox148.Text = dr27(0)
                            If TextBox148.Text <> "" Then
                                DropDownList169.Text = "Si"
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    da31 = New SqlDataAdapter("select distinct tratamientohipertension from gastro where pacienteid=@pac and folionota=@folio", con1)
                                    da31.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                                    da31.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                                    dr28 = da31.SelectCommand.ExecuteReader
                                    dr28.Read()
                                    TextBox149.Text = dr28(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                            Else
                                DropDownList169.Text = "No"
                                TextBox148.Text = ""
                                TextBox149.Text = ""
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da32 = New SqlDataAdapter("select distinct tiempoinsuficiencia from gastro where pacienteid=@pac and folionota=@folio", con)
                        da32.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da32.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr29 = da32.SelectCommand.ExecuteReader
                        dr29.Read()
                        If dr29.HasRows Then
                            DropDownList170.Visible = True
                            TextBox150.Visible = True
                            TextBox151.Visible = True
                            TextBox150.Text = dr29(0)
                            If TextBox150.Text <> "" Then
                                DropDownList170.Text = "Si"
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    da33 = New SqlDataAdapter("select distinct tratamientoinsuficiencia from gastro where pacienteid=@pac and folionota=@folio", con1)
                                    da33.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                                    da33.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                                    dr30 = da33.SelectCommand.ExecuteReader
                                    dr30.Read()
                                    TextBox151.Text = dr30(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                            Else
                                DropDownList170.Text = "No"
                                TextBox150.Text = ""
                                TextBox151.Text = ""
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try
                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da34 = New SqlDataAdapter("select distinct tiempocardisq from gastro where pacienteid=@pac and folionota=@folio", con)
                        da34.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da34.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr31 = da34.SelectCommand.ExecuteReader
                        dr31.Read()
                        If dr31.HasRows Then
                            DropDownList171.Visible = True
                            TextBox152.Visible = True
                            TextBox153.Visible = True
                            TextBox152.Text = dr31(0)
                            If TextBox152.Text <> "" Then
                                DropDownList171.Text = "Si"
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    da35 = New SqlDataAdapter("select distinct tratamientocardisq from gastro where pacienteid=@pac and folionota=@folio", con1)
                                    da35.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                                    da35.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                                    dr32 = da35.SelectCommand.ExecuteReader
                                    dr32.Read()
                                    TextBox153.Text = dr32(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                            Else
                                DropDownList171.Text = "No"
                                TextBox152.Text = ""
                                TextBox153.Text = ""
                            End If

                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da36 = New SqlDataAdapter("select distinct tiempoevc from gastro where pacienteid=@pac and folionota=@folio", con)
                        da36.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da36.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr33 = da36.SelectCommand.ExecuteReader
                        dr33.Read()
                        If dr33.HasRows Then
                            DropDownList172.Visible = True
                            TextBox154.Visible = True
                            TextBox155.Visible = True
                            TextBox154.Text = dr33(0)
                            If TextBox154.Text <> "" Then
                                DropDownList172.Text = "Si"
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    da37 = New SqlDataAdapter("select distinct tratamientoevc from gastro where pacienteid=@pac and folionota=@folio", con1)
                                    da37.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                                    da37.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                                    dr34 = da37.SelectCommand.ExecuteReader
                                    dr34.Read()
                                    TextBox155.Text = dr34(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                            Else
                                DropDownList172.Text = "No"
                                TextBox154.Text = ""
                                TextBox155.Text = ""
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da38 = New SqlDataAdapter("select distinct tiempoinsufvenosa from gastro where pacienteid=@pac and folionota=@folio", con)
                        da38.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da38.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr35 = da38.SelectCommand.ExecuteReader
                        dr35.Read()
                        If dr35.HasRows Then
                            DropDownList173.Visible = True
                            TextBox156.Visible = True
                            TextBox157.Visible = True
                            TextBox156.Text = dr35(0)
                            If TextBox156.Text <> "" Then
                                DropDownList173.Text = "Si"
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    da39 = New SqlDataAdapter("select distinct tratamientoinsufvenosa from gastro where pacienteid=@pac and folionota=@folio", con1)
                                    da39.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                                    da39.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                                    dr36 = da39.SelectCommand.ExecuteReader
                                    dr36.Read()
                                    TextBox157.Text = dr36(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                            Else
                                DropDownList173.Text = "No"
                                TextBox156.Text = ""
                                TextBox157.Text = ""
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try


                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da40 = New SqlDataAdapter("select distinct tiempodiabetes from gastro where pacienteid=@pac and folionota=@folio", con)
                        da40.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da40.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr37 = da40.SelectCommand.ExecuteReader
                        dr37.Read()
                        If dr37.HasRows Then
                            DropDownList174.Visible = True
                            TextBox158.Visible = True
                            TextBox159.Visible = True
                            TextBox158.Text = dr37(0)
                            If TextBox158.Text <> "" Then
                                DropDownList174.Text = "Si"
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    da41 = New SqlDataAdapter("select distinct tratamientodiabetes from gastro where pacienteid=@pac and folionota=@folio", con1)
                                    da41.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                                    da41.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                                    dr38 = da41.SelectCommand.ExecuteReader
                                    dr38.Read()
                                    TextBox159.Text = dr38(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                            Else
                                DropDownList174.Text = "No"
                                TextBox158.Text = ""
                                TextBox159.Text = ""
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da42 = New SqlDataAdapter("select distinct tiempodislipidemmia from gastro where pacienteid=@pac and folionota=@folio", con)
                        da42.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da42.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr39 = da42.SelectCommand.ExecuteReader
                        dr39.Read()
                        If dr39.HasRows Then
                            DropDownList175.Visible = True
                            TextBox160.Visible = True
                            TextBox161.Visible = True
                            TextBox160.Text = dr39(0)
                            If TextBox160.Text <> "" Then
                                DropDownList175.Text = "Si"
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    da43 = New SqlDataAdapter("select distinct tratamientodislipidemmia from gastro where pacienteid=@pac and folionota=@folio", con1)
                                    da43.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                                    da43.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                                    dr40 = da43.SelectCommand.ExecuteReader
                                    dr40.Read()
                                    TextBox161.Text = dr40(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                            Else
                                DropDownList175.Text = "No"
                                TextBox160.Text = ""
                                TextBox161.Text = ""
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da44 = New SqlDataAdapter("select distinct tiempoobesidad from gastro where pacienteid=@pac and folionota=@folio", con)
                        da44.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da44.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr41 = da44.SelectCommand.ExecuteReader
                        dr41.Read()
                        If dr41.HasRows Then
                            DropDownList176.Visible = True
                            TextBox162.Visible = True
                            TextBox163.Visible = True
                            TextBox162.Text = dr41(0)
                            If TextBox162.Text <> "" Then
                                DropDownList176.Text = "Si"
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    da45 = New SqlDataAdapter("select distinct tratamientoobesidad from gastro where pacienteid=@pac and folionota=@folio", con1)
                                    da45.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                                    da45.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                                    dr42 = da45.SelectCommand.ExecuteReader
                                    dr42.Read()
                                    TextBox163.Text = dr42(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                            Else
                                DropDownList176.Text = "No"
                                TextBox162.Text = ""
                                TextBox163.Text = ""
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da46 = New SqlDataAdapter("select distinct tiempoenftiroidea from gastro where pacienteid=@pac and folionota=@folio", con)
                        da46.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da46.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr43 = da46.SelectCommand.ExecuteReader
                        dr43.Read()
                        If dr43.HasRows Then
                            DropDownList177.Visible = True
                            TextBox164.Visible = True
                            TextBox165.Visible = True
                            TextBox164.Text = dr43(0)
                            If TextBox164.Text <> "" Then
                                DropDownList177.Text = "Si"
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    da47 = New SqlDataAdapter("select distinct tratamientoenftiroidea from gastro where pacienteid=@pac and folionota=@folio", con1)
                                    da47.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                                    da47.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                                    dr44 = da47.SelectCommand.ExecuteReader
                                    dr44.Read()
                                    TextBox165.Text = dr44(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                            Else
                                DropDownList177.Text = "No"
                                TextBox164.Text = ""
                                TextBox165.Text = ""
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da48 = New SqlDataAdapter("select distinct tiempocancer from gastro where pacienteid=@pac and folionota=@folio", con)
                        da48.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da48.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr45 = da48.SelectCommand.ExecuteReader
                        dr45.Read()
                        If dr45.HasRows Then
                            DropDownList178.Visible = True
                            TextBox166.Visible = True
                            TextBox167.Visible = True
                            TextBox166.Text = dr45(0)
                            If TextBox166.Text <> "" Then
                                DropDownList178.Text = "Si"
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    da49 = New SqlDataAdapter("select distinct tratamientocancer from gastro where pacienteid=@pac and folionota=@folio", con1)
                                    da49.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                                    da49.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                                    dr46 = da49.SelectCommand.ExecuteReader
                                    dr46.Read()
                                    TextBox167.Text = dr46(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                        Else
                            DropDownList178.Text = "No"
                            TextBox166.Text = ""
                            TextBox167.Text = ""
                        End If
                    End If
                    con.Close()
                Catch ex As Exception

                End Try

                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    da50 = New SqlDataAdapter("select distinct tiempotuberculosis from gastro where pacienteid=@pac and folionota=@folio", con)
                    da50.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                    da50.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                    dr47 = da50.SelectCommand.ExecuteReader
                    dr47.Read()
                    If dr47.HasRows Then

                        DropDownList179.Visible = True
                        TextBox168.Visible = True
                        TextBox169.Visible = True
                        TextBox168.Text = dr47(0)
                        If TextBox168.Text <> "" Then
                            DropDownList179.Text = "Si"
                            Try
                                If con1.State = ConnectionState.Open Then
                                    con1.Close()
                                End If
                                da51 = New SqlDataAdapter("select distinct tratamientotuberculosis from gastro where pacienteid=@pac and folionota=@folio", con1)
                                da51.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                                da51.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                                dr48 = da51.SelectCommand.ExecuteReader
                                dr48.Read()
                                TextBox169.Text = dr48(0)
                                con1.Close()
                            Catch ex As Exception

                            End Try
                        Else
                            DropDownList179.Text = "No"
                            TextBox168.Text = ""
                            TextBox169.Text = ""
                        End If
                    End If
                    con.Close()
                Catch ex As Exception

                End Try

                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    da52 = New SqlDataAdapter("select distinct tiempoasma from gastro where pacienteid=@pac and folionota=@folio", con)
                    da52.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                    da52.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                    dr49 = da52.SelectCommand.ExecuteReader
                    dr49.Read()
                    If dr49.HasRows Then
                        DropDownList180.Visible = True
                        TextBox170.Visible = True
                        TextBox171.Visible = True
                        TextBox170.Text = dr49(0)
                        If TextBox170.Text <> "" Then
                            DropDownList180.Text = "Si"
                            Try
                                If con1.State = ConnectionState.Open Then
                                    con1.Close()
                                End If
                                da53 = New SqlDataAdapter("select distinct tratamientoasma from gastro where pacienteid=@pac and folionota=@folio", con1)
                                da53.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                                da53.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                                dr50 = da53.SelectCommand.ExecuteReader
                                dr50.Read()
                                TextBox171.Text = dr50(0)
                                con1.Close()
                            Catch ex As Exception

                            End Try
                        Else
                            DropDownList180.Text = "No"
                            TextBox170.Text = ""
                            TextBox171.Text = ""
                        End If
                    End If
                    con.Close()
                Catch ex As Exception

                End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da54 = New SqlDataAdapter("select distinct tiempoepoc from gastro where pacienteid=@pac and folionota=@folio", con)
                        da54.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da54.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr51 = da54.SelectCommand.ExecuteReader
                        dr51.Read()
                        If dr51.HasRows Then
                            DropDownList181.Visible = True
                            TextBox172.Visible = True
                            TextBox173.Visible = True
                            TextBox172.Text = dr51(0)
                            If TextBox172.Text <> "" Then
                                DropDownList181.Text = "Si"
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    da55 = New SqlDataAdapter("select distinct tratamientoepoc from gastro where pacienteid=@pac and folionota=@folio", con1)
                                    da55.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                                    da55.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                                    dr52 = da55.SelectCommand.ExecuteReader
                                    dr52.Read()
                                    TextBox173.Text = dr52(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                            Else
                                DropDownList181.Text = "No"
                                TextBox172.Text = ""
                                TextBox173.Text = ""
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da56 = New SqlDataAdapter("select distinct tiempobronquitis from gastro where pacienteid=@pac and folionota=@folio", con)
                        da56.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da56.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr53 = da56.SelectCommand.ExecuteReader
                        dr53.Read()
                        If dr53.HasRows Then
                            DropDownList182.Visible = True
                            TextBox174.Visible = True
                            TextBox175.Visible = True
                            TextBox174.Text = dr53(0)
                            If TextBox174.Text <> "" Then
                                DropDownList182.Text = "Si"
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    da57 = New SqlDataAdapter("select distinct tratamientobronquitis from gastro where pacienteid=@pac and folionota=@folio", con1)
                                    da57.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                                    da57.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                                    dr54 = da57.SelectCommand.ExecuteReader
                                    dr54.Read()
                                    TextBox175.Text = dr54(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                            Else
                                DropDownList182.Text = "No"
                                TextBox174.Text = ""
                                TextBox175.Text = ""
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da60 = New SqlDataAdapter("select distinct otraenf from gastro where pacienteid=@pac and folionota=@folio", con)
                        da60.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da60.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr58 = da60.SelectCommand.ExecuteReader
                        dr58.Read()
                        TextBox176.Visible = True
                        TextBox177.Visible = True
                        TextBox178.Visible = True
                        If dr58.HasRows Then
                            TextBox176.Text = dr58(0)

                            Try
                                If con1.State = ConnectionState.Open Then
                                    con1.Close()
                                End If
                                con1.Open()
                                da61 = New SqlDataAdapter("select distinct tiempootraenf from gastro where pacienteid=@pac and folionota=@folio", con1)
                                da61.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                                da61.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                                dr59 = da61.SelectCommand.ExecuteReader
                                dr59.Read()
                                If dr59.HasRows Then
                                    TextBox177.Text = dr59(0)
                                    Try
                                        If con2.State = ConnectionState.Open Then
                                            con2.Close()
                                        End If
                                        con2.Open()
                                        da62 = New SqlDataAdapter("select distinct tratamientootraenf from gastro where pacienteid=@pac and folionota=@folio", con2)
                                        da62.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                                        da62.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                                        dr60 = da62.SelectCommand.ExecuteReader
                                        dr60.Read()
                                        If dr60.HasRows Then
                                            TextBox178.Text = dr60(0)
                                        End If
                                        con2.Close()
                                    Catch ex As Exception

                                    End Try
                                End If
                                con1.Close()
                            Catch ex As Exception

                            End Try
                        Else
                            TextBox176.Text = ""
                            TextBox177.Text = ""
                            TextBox178.Text = ""
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da63 = New SqlDataAdapter("select distinct tiempoalcoholismo from gastro where pacienteid=@pac and folionota=@folio", con)
                        da63.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da63.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr61 = da63.SelectCommand.ExecuteReader
                        dr61.Read()
                        If dr61.HasRows Then
                            DropDownList84.Visible = True
                            TextBox179.Visible = True
                            TextBox180.Visible = True
                            TextBox179.Text = dr61(0)
                            If TextBox179.Text <> "" Then
                                DropDownList84.Text = "Si"
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    da64 = New SqlDataAdapter("select distinct cantalcoholismo from gastro where pacienteid=@pac and folionota=@folio", con1)
                                    da64.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                                    da64.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                                    dr62 = da64.SelectCommand.ExecuteReader
                                    dr62.Read()
                                    TextBox180.Text = dr62(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                            Else
                                DropDownList84.Text = "No"
                                TextBox179.Text = ""
                                TextBox180.Text = ""
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try
                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da65 = New SqlDataAdapter("select distinct tiempotabaquismo from gastro where pacienteid=@pac and folionota=@folio", con)
                        da65.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da65.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr63 = da65.SelectCommand.ExecuteReader
                        dr63.Read()
                        If dr63.HasRows Then

                            DropDownList85.Visible = True
                            TextBox181.Visible = True
                            TextBox182.Visible = True
                            TextBox181.Text = dr63(0)
                            If TextBox181.Text <> "" Then
                                DropDownList85.Text = "Si"
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    da66 = New SqlDataAdapter("select distinct canttabaquismo from gastro where pacienteid=@pac and folionota=@folio", con1)
                                    da66.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                                    da66.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                                    dr64 = da66.SelectCommand.ExecuteReader
                                    dr64.Read()
                                    TextBox182.Text = dr64(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                            Else
                                DropDownList85.Text = "No"
                                TextBox181.Text = ""
                                TextBox182.Text = ""
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try
                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da67 = New SqlDataAdapter("select distinct tiempodrogas from gastro where pacienteid=@pac and folionota=@folio", con)
                        da67.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da67.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr65 = da67.SelectCommand.ExecuteReader
                        dr65.Read()
                        If dr65.HasRows Then
                            DropDownList86.Visible = True
                            TextBox183.Visible = True
                            TextBox184.Visible = True
                            TextBox183.Text = dr65(0)
                            If TextBox183.Text <> "" Then
                                DropDownList86.Text = "Si"
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    da68 = New SqlDataAdapter("select distinct cantdrogas from gastro where pacienteid=@pac and folionota=@folio", con1)
                                    da68.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                                    da68.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                                    dr66 = da68.SelectCommand.ExecuteReader
                                    dr66.Read()
                                    TextBox184.Text = dr66(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                            Else
                                DropDownList86.Text = "No"
                                TextBox183.Text = ""
                                TextBox184.Text = ""
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da69 = New SqlDataAdapter("select distinct otrotox from gastro where pacienteid=@pac and folionota=@folio", con)
                        da69.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da69.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr67 = da69.SelectCommand.ExecuteReader
                        dr67.Read()
                        TextBox185.Visible = True
                        TextBox186.Visible = True
                        TextBox187.Visible = True
                        If dr67.HasRows Then
                            TextBox185.Text = dr67(0)

                            Try
                                If con1.State = ConnectionState.Open Then
                                    con1.Close()
                                End If
                                con1.Open()
                                da70 = New SqlDataAdapter("select distinct tiempootrotox from gastro where pacienteid=@pac and folionota=@folio", con1)
                                da70.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                                da70.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                                dr68 = da70.SelectCommand.ExecuteReader
                                dr68.Read()
                                If dr68.HasRows Then
                                    TextBox186.Text = dr68(0)
                                    Try
                                        If con2.State = ConnectionState.Open Then
                                            con2.Close()
                                        End If
                                        con2.Open()
                                        da71 = New SqlDataAdapter("select distinct cantotrotox from gastro where pacienteid=@pac and folionota=@folio", con2)
                                        da71.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                                        da71.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                                        dr69 = da71.SelectCommand.ExecuteReader
                                        dr69.Read()
                                        If dr69.HasRows Then
                                            TextBox187.Text = dr69(0)
                                        End If
                                        con2.Close()
                                    Catch ex As Exception

                                    End Try
                                End If
                                con1.Close()
                            Catch ex As Exception

                            End Try
                        Else

                            TextBox185.Text = ""
                            TextBox186.Text = ""
                            TextBox187.Text = ""
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da72 = New SqlDataAdapter("select distinct ultregla from gastro where pacienteid=@pac and folionota=@folio", con)
                        da72.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da72.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr70 = da72.SelectCommand.ExecuteReader
                        dr70.Read()
                        If dr70.HasRows Then
                            TextBox123.Visible = True
                            TextBox123.Text = dr70(0)
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da73 = New SqlDataAdapter("select distinct ritmo from gastro where pacienteid=@pac and folionota=@folio", con)
                        da73.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da73.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr71 = da73.SelectCommand.ExecuteReader
                        dr71.Read()
                        If dr71.HasRows Then
                            TextBox124.Visible = True
                            TextBox124.Text = dr71(0)
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da74 = New SqlDataAdapter("select distinct menopausia from gastro where pacienteid=@pac and folionota=@folio", con)
                        da74.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da74.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr72 = da74.SelectCommand.ExecuteReader
                        dr72.Read()
                        If dr72.HasRows Then
                            DropDownList87.Visible = True
                            DropDownList87.Text = dr72(0)
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da75 = New SqlDataAdapter("select distinct gesta from gastro where pacienteid=@pac and folionota=@folio", con)
                        da75.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da75.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr73 = da75.SelectCommand.ExecuteReader
                        dr73.Read()
                        If dr73.HasRows Then
                            DropDownList88.Visible = True
                            DropDownList88.Text = dr73(0)
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try
                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da76 = New SqlDataAdapter("select distinct para from gastro where pacienteid=@pac and folionota=@folio", con)
                        da76.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da76.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr74 = da76.SelectCommand.ExecuteReader
                        dr74.Read()
                        If dr74.HasRows Then
                            DropDownList89.Visible = True
                            DropDownList89.Text = dr74(0)
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try
                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da77 = New SqlDataAdapter("select distinct cesarea from gastro where pacienteid=@pac and folionota=@folio", con)
                        da77.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da77.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr75 = da77.SelectCommand.ExecuteReader
                        dr75.Read()
                        If dr75.HasRows Then
                            DropDownList90.Visible = True
                            DropDownList90.Text = dr75(0)
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try


                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da78 = New SqlDataAdapter("select distinct aborto from gastro where pacienteid=@pac and folionota=@folio", con)
                        da78.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da78.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr76 = da78.SelectCommand.ExecuteReader
                        dr76.Read()
                        If dr76.HasRows Then
                            DropDownList91.Visible = True
                            DropDownList91.Text = dr76(0)
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da79 = New SqlDataAdapter("select distinct metplanfam from gastro where pacienteid=@pac and folionota=@folio", con)
                        da79.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da79.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr77 = da79.SelectCommand.ExecuteReader
                        dr77.Read()
                        If dr77.HasRows Then
                            DropDownList92.Visible = True
                            DropDownList92.Text = dr77(0)
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da79 = New SqlDataAdapter("select distinct otroplanfam from gastro where pacienteid=@pac and folionota=@folio", con)
                        da79.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da79.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr78 = da79.SelectCommand.ExecuteReader
                        dr78.Read()
                        If dr78.HasRows Then
                            TextBox125.Visible = True
                            TextBox125.Text = dr78(0)
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try



                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da80 = New SqlDataAdapter("select distinct tiempofiebre from gastro where pacienteid=@pac and folionota=@folio", con)
                        da80.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da80.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr79 = da80.SelectCommand.ExecuteReader
                        dr79.Read()
                        If dr79.HasRows Then
                            DropDownList93.Visible = True
                            TextBox188.Visible = True
                            TextBox189.Visible = True
                            TextBox188.Text = dr79(0)
                            If TextBox188.Text <> "" Then
                                DropDownList93.Text = "Si"
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    con1.Open()
                                    da81 = New SqlDataAdapter("select distinct cuantificacionfiebre from gastro where pacienteid=@pac and folionota=@folio", con1)
                                    da81.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                                    da81.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                                    dr80 = da81.SelectCommand.ExecuteReader
                                    dr80.Read()
                                    TextBox189.Text = dr80(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                            Else
                                DropDownList93.Text = "No"
                                TextBox188.Text = ""
                                TextBox189.Text = ""
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da82 = New SqlDataAdapter("select distinct tiempoastenia from gastro where pacienteid=@pac and folionota=@folio", con)
                        da82.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da82.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr81 = da82.SelectCommand.ExecuteReader
                        dr81.Read()
                        If dr81.HasRows Then
                            DropDownList94.Visible = True
                            TextBox191.Visible = True
                            TextBox192.Visible = True
                            TextBox191.Text = dr81(0)
                            If TextBox191.Text <> "" Then
                                DropDownList94.Text = "Si"
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    con1.Open()
                                    da83 = New SqlDataAdapter("select distinct cuantificacionastenia from gastro where pacienteid=@pac and folionota=@folio", con1)
                                    da83.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                                    da83.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                                    dr82 = da83.SelectCommand.ExecuteReader
                                    dr82.Read()
                                    TextBox192.Text = dr82(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                            Else
                                DropDownList94.Text = "No"
                                TextBox191.Text = ""
                                TextBox192.Text = ""
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da84 = New SqlDataAdapter("select distinct tiempoadinamia from gastro where pacienteid=@pac and folionota=@folio", con)
                        da84.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da84.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr83 = da84.SelectCommand.ExecuteReader
                        dr83.Read()
                        If dr83.HasRows Then
                            DropDownList95.Visible = True
                            TextBox194.Visible = True
                            TextBox195.Visible = True
                            TextBox194.Text = dr83(0)
                            If TextBox194.Text <> "" Then
                                DropDownList95.Text = "Si"
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    con1.Open()
                                    da85 = New SqlDataAdapter("select distinct cuantificacionadinamia from gastro where pacienteid=@pac and folionota=@folio", con1)
                                    da85.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                                    da85.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                                    dr84 = da85.SelectCommand.ExecuteReader
                                    dr84.Read()
                                    TextBox195.Text = dr84(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                            Else
                                DropDownList95.Text = "No"
                                TextBox194.Text = ""
                                TextBox195.Text = ""
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da86 = New SqlDataAdapter("select distinct tiempoanorexia from gastro where pacienteid=@pac and folionota=@folio", con)
                        da86.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da86.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr85 = da86.SelectCommand.ExecuteReader
                        dr85.Read()
                        If dr85.HasRows Then

                            DropDownList96.Visible = True
                            TextBox197.Visible = True
                            TextBox198.Visible = True
                            TextBox197.Text = dr85(0)
                            If TextBox197.Text <> "" Then
                                DropDownList96.Text = "Si"
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    con1.Open()
                                    da87 = New SqlDataAdapter("select distinct cuantificacionanorexia from gastro where pacienteid=@pac and folionota=@folio", con1)
                                    da87.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                                    da87.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                                    dr86 = da87.SelectCommand.ExecuteReader
                                    dr86.Read()
                                    TextBox198.Text = dr86(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                            Else
                                DropDownList96.Text = "No"
                                TextBox197.Text = ""
                                TextBox198.Text = ""
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da88 = New SqlDataAdapter("select distinct tiempoperdidapeso from gastro where pacienteid=@pac and folionota=@folio", con)
                        da88.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da88.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr87 = da88.SelectCommand.ExecuteReader
                        dr87.Read()
                        If dr87.HasRows Then
                            DropDownList97.Visible = True
                            TextBox200.Visible = True
                            TextBox201.Visible = True
                            TextBox200.Text = dr87(0)
                            If TextBox200.Text <> "" Then
                                DropDownList97.Text = "Si"
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    con1.Open()
                                    da89 = New SqlDataAdapter("select distinct cuantificacionperdidapeso from gastro where pacienteid=@pac and folionota=@folio", con1)
                                    da89.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                                    da89.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                                    dr88 = da89.SelectCommand.ExecuteReader
                                    dr88.Read()
                                    TextBox201.Text = dr88(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                            Else
                                DropDownList97.Text = "No"
                                TextBox200.Text = ""
                                TextBox201.Text = ""
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da90 = New SqlDataAdapter("select distinct obstruccionnasal from gastro where pacienteid=@pac and folionota=@folio", con)
                        da90.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da90.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr89 = da90.SelectCommand.ExecuteReader
                        dr89.Read()
                        DropDownList98.Visible = True
                        DropDownList183.Visible = True
                        If dr89.HasRows Then
                            DropDownList183.Text = dr89(0)
                            If DropDownList183.Text <> "" Then
                                DropDownList98.Text = "Si"
                            Else
                                DropDownList98.Text = "No"
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da91 = New SqlDataAdapter("select distinct ronqueramatutina from gastro where pacienteid=@pac and folionota=@folio", con)
                        da91.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da91.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr90 = da91.SelectCommand.ExecuteReader
                        dr90.Read()
                        DropDownList99.Visible = True
                        DropDownList184.Visible = True
                        If dr90.HasRows Then

                            DropDownList184.Text = dr90(0)
                            If DropDownList184.Text <> "" Then
                                DropDownList99.Text = "Si"
                            Else
                                DropDownList99.Text = "No"
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da92 = New SqlDataAdapter("select distinct sinusitis from gastro where pacienteid=@pac and folionota=@folio", con)
                        da92.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da92.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr91 = da92.SelectCommand.ExecuteReader
                        dr91.Read()
                        DropDownList100.Visible = True
                        DropDownList185.Visible = True

                        If dr91.HasRows Then

                            DropDownList185.Text = dr91(0)
                            If DropDownList185.Text <> "" Then
                                DropDownList100.Text = "Si"

                            Else
                                DropDownList100.Text = "No"
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da93 = New SqlDataAdapter("select distinct disfonia from gastro where pacienteid=@pac and folionota=@folio", con)
                        da93.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da93.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr92 = da93.SelectCommand.ExecuteReader
                        dr92.Read()
                        DropDownList101.Visible = True
                        DropDownList186.Visible = True
                        If dr92.HasRows Then

                            DropDownList186.Text = dr92(0)
                            If DropDownList186.Text <> "" Then
                                DropDownList101.Text = "Si"

                            Else
                                DropDownList101.Text = "No"
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da94 = New SqlDataAdapter("select distinct disnea from gastro where pacienteid=@pac and folionota=@folio", con)
                        da94.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da94.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr93 = da94.SelectCommand.ExecuteReader
                        dr93.Read()
                        DropDownList102.Visible = True
                        DropDownList187.Visible = True
                        If dr93.HasRows Then

                            DropDownList187.Text = dr93(0)
                            If DropDownList187.Text <> "" Then
                                DropDownList102.Text = "Si"
                            Else
                                DropDownList102.Text = "No"
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da95 = New SqlDataAdapter("select distinct sibilancias from gastro where pacienteid=@pac and folionota=@folio", con)
                        da95.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da95.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr94 = da95.SelectCommand.ExecuteReader
                        dr94.Read()
                        DropDownList103.Visible = True
                        DropDownList188.Visible = True
                        If dr94.HasRows Then

                            DropDownList188.Text = dr94(0)
                            If DropDownList188.Text <> "" Then
                                DropDownList103.Text = "Si"
                            Else
                                DropDownList103.Text = "No"
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da96 = New SqlDataAdapter("select distinct tos from gastro where pacienteid=@pac and folionota=@folio", con)
                        da96.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da96.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr95 = da96.SelectCommand.ExecuteReader
                        dr95.Read()
                        DropDownList104.Visible = True
                        DropDownList189.Visible = True
                        If dr95.HasRows Then
                            DropDownList189.Text = dr95(0)
                            If DropDownList189.Text <> "" Then
                                DropDownList104.Text = "Si"
                            Else
                                DropDownList104.Text = "No"
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da97 = New SqlDataAdapter("select distinct cianosis from gastro where pacienteid=@pac and folionota=@folio", con)
                        da97.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da97.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr96 = da97.SelectCommand.ExecuteReader
                        dr96.Read()
                        DropDownList105.Visible = True
                        DropDownList190.Visible = True
                        If dr96.HasRows Then
                            DropDownList190.Text = dr96(0)
                            If DropDownList190.Text <> "" Then
                                DropDownList105.Text = "Si"
                            Else
                                DropDownList105.Text = "No"
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try


                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da98 = New SqlDataAdapter("select distinct asma from gastro where pacienteid=@pac and folionota=@folio", con)
                        da98.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da98.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr97 = da98.SelectCommand.ExecuteReader
                        dr97.Read()
                        DropDownList106.Visible = True
                        DropDownList191.Visible = True
                        If dr97.HasRows Then

                            DropDownList191.Text = dr97(0)
                            If DropDownList191.Text <> "" Then
                                DropDownList106.Text = "Si"
                            Else
                                DropDownList106.Text = "No"
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da99 = New SqlDataAdapter("select distinct mejorolipotimia from gastro where pacienteid=@pac and folionota=@folio", con)
                        da99.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da99.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr98 = da99.SelectCommand.ExecuteReader
                        dr98.Read()
                        If dr98.HasRows Then
                            DropDownList107.Visible = True
                            DropDownList192.Visible = True
                            TextBox203.Visible = True
                            DropDownList192.Text = dr98(0)
                            If DropDownList192.Text <> "" Then
                                DropDownList107.Text = "Si"
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    con1.Open()
                                    da100 = New SqlDataAdapter("select distinct sensacioneslipotimia from gastro where pacienteid=@pac and folionota=@folio", con1)
                                    da100.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                                    da100.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                                    dr99 = da100.SelectCommand.ExecuteReader
                                    dr99.Read()
                                    TextBox203.Text = dr99(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                            Else
                                DropDownList107.Text = "No"
                                DropDownList192.Text = "Mejoró"
                                TextBox203.Text = ""
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da101 = New SqlDataAdapter("select distinct mejorosincope from gastro where pacienteid=@pac and folionota=@folio", con)
                        da101.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da101.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr100 = da101.SelectCommand.ExecuteReader
                        dr100.Read()
                        If dr100.HasRows Then
                            DropDownList108.Visible = True
                            DropDownList193.Visible = True
                            TextBox204.Visible = True
                            DropDownList193.Text = dr100(0)
                            If DropDownList193.Text <> "" Then

                                DropDownList108.Text = "Si"
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    con1.Open()
                                    da102 = New SqlDataAdapter("select distinct sensacionessincope from gastro where pacienteid=@pac and folionota=@folio", con1)
                                    da102.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                                    da102.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                                    dr101 = da102.SelectCommand.ExecuteReader
                                    dr101.Read()
                                    TextBox204.Text = dr101(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                            Else
                                DropDownList108.Text = "No"
                                DropDownList193.Text = "Mejoró"
                                TextBox204.Text = ""
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try
                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da103 = New SqlDataAdapter("select distinct mejorofatiga from gastro where pacienteid=@pac and folionota=@folio", con)
                        da103.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da103.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr102 = da103.SelectCommand.ExecuteReader
                        dr102.Read()
                        DropDownList109.Visible = True
                        DropDownList194.Visible = True
                        TextBox205.Visible = True
                        If dr102.HasRows Then
                            DropDownList194.Text = dr102(0)
                            If DropDownList194.Text <> "" Then
                                DropDownList109.Text = "Si"
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    con1.Open()
                                    da104 = New SqlDataAdapter("select distinct sensacionesfatiga from gastro where pacienteid=@pac and folionota=@folio", con1)
                                    da104.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                                    da104.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                                    dr103 = da104.SelectCommand.ExecuteReader
                                    dr103.Read()
                                    TextBox205.Text = dr103(0)
                                    con1.Close()
                                Catch ex As Exception
                                    MsgBox(ex.Message)
                                End Try
                            Else
                                DropDownList109.Visible = True
                                DropDownList194.Visible = True
                                TextBox205.Visible = True
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da105 = New SqlDataAdapter("select distinct mejoropalpitaciones from gastro where pacienteid=@pac and folionota=@folio", con)
                        da105.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da105.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr104 = da105.SelectCommand.ExecuteReader
                        dr104.Read()
                        If dr104.HasRows Then
                            DropDownList110.Visible = True
                            DropDownList195.Visible = True
                            TextBox206.Visible = True
                            DropDownList195.Text = dr104(0)
                            If DropDownList195.Text <> "" Then
                                DropDownList110.Text = "Si"
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    con1.Open()
                                    da106 = New SqlDataAdapter("select distinct sensacionespalpitaciones from gastro where pacienteid=@pac and folionota=@folio", con1)
                                    da106.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                                    da106.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                                    dr105 = da106.SelectCommand.ExecuteReader
                                    dr105.Read()
                                    TextBox206.Text = dr105(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                            Else
                                DropDownList110.Text = "No"
                                DropDownList195.Text = "Mejoró"
                                TextBox206.Text = ""
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da107 = New SqlDataAdapter("select distinct mejorodolprecordial from gastro where pacienteid=@pac and folionota=@folio", con)
                        da107.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da107.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr106 = da107.SelectCommand.ExecuteReader
                        dr106.Read()

                        DropDownList111.Visible = True
                        DropDownList196.Visible = True
                        TextBox207.Visible = True
                        If dr106.HasRows Then

                            DropDownList196.Text = dr106(0)
                            If DropDownList196.Text <> "" Then
                                DropDownList111.Text = "Si"
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    con1.Open()
                                    da108 = New SqlDataAdapter("select distinct sensacionesdolprecordial from gastro where pacienteid=@pac and folionota=@folio", con1)
                                    da108.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                                    da108.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                                    dr107 = da108.SelectCommand.ExecuteReader
                                    dr107.Read()
                                    TextBox207.Text = dr107(0)
                                    con1.Close()
                                Catch ex As Exception
                                    MsgBox(ex.Message)
                                End Try
                            Else
                                DropDownList111.Text = "No"
                                DropDownList196.Text = "Mejoró"
                                TextBox207.Text = ""
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da109 = New SqlDataAdapter("select distinct mejoroedema from gastro where pacienteid=@pac and folionota=@folio", con)
                        da109.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da109.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr108 = da109.SelectCommand.ExecuteReader
                        dr108.Read()
                        If dr108.HasRows Then
                            DropDownList112.Visible = True
                            DropDownList197.Visible = True
                            TextBox207.Visible = True
                            DropDownList197.Text = dr108(0)
                            If DropDownList197.Text <> "" Then
                                DropDownList112.Text = "Si"
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    con1.Open()
                                    da110 = New SqlDataAdapter("select distinct sensacionesedema from gastro where pacienteid=@pac and folionota=@folio", con1)
                                    da110.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                                    da110.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                                    dr109 = da110.SelectCommand.ExecuteReader
                                    dr109.Read()
                                    TextBox207.Text = dr109(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                            Else
                                DropDownList112.Text = "No"
                                DropDownList197.Text = "Mejoró"
                                TextBox207.Text = ""
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da111 = New SqlDataAdapter("select distinct mejorodisnea from gastro where pacienteid=@pac and folionota=@folio", con)
                        da111.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da111.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr110 = da111.SelectCommand.ExecuteReader
                        dr110.Read()
                        If dr110.HasRows Then
                            DropDownList113.Visible = True
                            DropDownList198.Visible = True
                            TextBox208.Visible = True
                            DropDownList198.Text = dr110(0)
                            If DropDownList198.Text <> "" Then

                                DropDownList113.Text = "Si"
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    con1.Open()
                                    da112 = New SqlDataAdapter("select distinct sensacionesdisnea from gastro where pacienteid=@pac and folionota=@folio", con1)
                                    da112.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                                    da112.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                                    dr111 = da112.SelectCommand.ExecuteReader
                                    dr111.Read()
                                    TextBox208.Text = dr111(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                            Else
                                DropDownList113.Text = "No"
                                DropDownList198.Text = "Mejoró"
                                TextBox208.Text = ""
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da113 = New SqlDataAdapter("select distinct mejoroascitis from gastro where pacienteid=@pac and folionota=@folio", con)
                        da113.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da113.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr112 = da113.SelectCommand.ExecuteReader
                        dr112.Read()
                        If dr112.HasRows Then
                            DropDownList114.Visible = True
                            DropDownList199.Visible = True
                            TextBox209.Visible = True
                            DropDownList199.Text = dr112(0)
                            If DropDownList199.Text <> "" Then
                                DropDownList114.Text = "Si"
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    con1.Open()
                                    da114 = New SqlDataAdapter("select distinct sensacionesascitis from gastro where pacienteid=@pac and folionota=@folio", con1)
                                    da114.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                                    da114.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                                    dr113 = da114.SelectCommand.ExecuteReader
                                    dr113.Read()
                                    TextBox209.Text = dr113(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                            Else
                                DropDownList114.Text = "No"
                                DropDownList199.Text = "Mejoró"
                                TextBox209.Text = ""
                            End If
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da115 = New SqlDataAdapter("select distinct disuria from gastro where pacienteid=@pac and folionota=@folio", con)
                        da115.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da115.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr114 = da115.SelectCommand.ExecuteReader
                        dr114.Read()
                        If dr114.HasRows Then
                            DropDownList138.Text = dr114(0)
                            DropDownList138.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da116 = New SqlDataAdapter("select distinct poliaquiuria from gastro where pacienteid=@pac and folionota=@folio", con)
                        da116.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da116.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr115 = da116.SelectCommand.ExecuteReader
                        dr115.Read()
                        If dr115.HasRows Then
                            DropDownList139.Text = dr115(0)
                            DropDownList139.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da117 = New SqlDataAdapter("select distinct tenesmo from gastro where pacienteid=@pac and folionota=@folio", con)
                        da117.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da117.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr116 = da117.SelectCommand.ExecuteReader
                        dr116.Read()
                        If dr116.HasRows Then
                            DropDownList140.Text = dr116(0)
                            DropDownList140.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da118 = New SqlDataAdapter("select distinct hematuria from gastro where pacienteid=@pac and folionota=@folio", con)
                        da118.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da118.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr117 = da118.SelectCommand.ExecuteReader
                        dr117.Read()
                        If dr117.HasRows Then
                            DropDownList141.Text = dr117(0)
                            DropDownList141.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da119 = New SqlDataAdapter("select distinct suprapubica from gastro where pacienteid=@pac and folionota=@folio", con)
                        da119.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da119.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr118 = da119.SelectCommand.ExecuteReader
                        dr118.Read()
                        If dr118.HasRows Then
                            DropDownList142.Text = dr118(0)
                            DropDownList142.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try
                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da120 = New SqlDataAdapter("select distinct lumbar from gastro where pacienteid=@pac and folionota=@folio", con)
                        da120.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da120.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr119 = da120.SelectCommand.ExecuteReader
                        dr119.Read()
                        If dr119.HasRows Then
                            DropDownList143.Text = dr119(0)
                            DropDownList143.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da121 = New SqlDataAdapter("select distinct ninguno from gastro where pacienteid=@pac and folionota=@folio", con)
                        da121.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da121.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr120 = da121.SelectCommand.ExecuteReader
                        dr120.Read()
                        If dr120.HasRows Then
                            DropDownList144.Text = dr120(0)
                            DropDownList144.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da122 = New SqlDataAdapter("select distinct otrosdolores from gastro where pacienteid=@pac and folionota=@folio", con)
                        da122.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da122.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr121 = da122.SelectCommand.ExecuteReader
                        dr121.Read()
                        If dr121.HasRows Then
                            TextBox131.Text = dr121(0)
                            TextBox131.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da123 = New SqlDataAdapter("select distinct tendenciahemorragia from gastro where pacienteid=@pac and folionota=@folio", con)
                        da123.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da123.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr122 = da123.SelectCommand.ExecuteReader
                        dr122.Read()
                        If dr122.HasRows Then
                            DropDownList145.Text = dr122(0)
                            DropDownList145.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da124 = New SqlDataAdapter("select distinct adenopatias from gastro where pacienteid=@pac and folionota=@folio", con)
                        da124.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da124.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr123 = da124.SelectCommand.ExecuteReader
                        dr123.Read()
                        If dr123.HasRows Then
                            DropDownList146.Text = dr123(0)
                            DropDownList146.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da125 = New SqlDataAdapter("select distinct infecrecurrentes from gastro where pacienteid=@pac and folionota=@folio", con)
                        da125.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da125.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr124 = da125.SelectCommand.ExecuteReader
                        dr124.Read()
                        DropDownList147.Visible = True
                        If dr124.HasRows Then
                            DropDownList147.Text = dr124(0)
                        End If
                        con.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da126 = New SqlDataAdapter("select distinct anemia from gastro where pacienteid=@pac and folionota=@folio", con)
                        da126.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da126.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr125 = da126.SelectCommand.ExecuteReader
                        dr125.Read()
                        If dr125.HasRows Then
                            DropDownList148.Text = dr125(0)
                            DropDownList148.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da127 = New SqlDataAdapter("select distinct hemolinfaticonegado from gastro where pacienteid=@pac and folionota=@folio", con)
                        da127.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da127.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr126 = da127.SelectCommand.ExecuteReader
                        dr126.Read()
                        If dr126.HasRows Then
                            DropDownList149.Text = dr126(0)
                            DropDownList149.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da128 = New SqlDataAdapter("select distinct otroshemolinf from gastro where pacienteid=@pac and folionota=@folio", con)
                        da128.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da128.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr127 = da128.SelectCommand.ExecuteReader
                        dr127.Read()
                        If dr127.HasRows Then
                            TextBox132.Text = dr127(0)
                            TextBox132.Visible = True

                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da129 = New SqlDataAdapter("select distinct paralisis from gastro where pacienteid=@pac and folionota=@folio", con)
                        da129.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da129.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr128 = da129.SelectCommand.ExecuteReader
                        dr128.Read()
                        If dr128.HasRows Then
                            DropDownList150.Text = dr128(0)
                            DropDownList150.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da130 = New SqlDataAdapter("select distinct parestesisas from gastro where pacienteid=@pac and folionota=@folio", con)
                        da130.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da130.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr129 = da130.SelectCommand.ExecuteReader
                        dr129.Read()
                        If dr129.HasRows Then
                            DropDownList151.Text = dr129(0)
                            DropDownList151.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da131 = New SqlDataAdapter("select distinct temblores from gastro where pacienteid=@pac and folionota=@folio", con)
                        da131.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da131.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr130 = da131.SelectCommand.ExecuteReader
                        dr130.Read()
                        If dr130.HasRows Then
                            DropDownList152.Text = dr130(0)
                            DropDownList152.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da132 = New SqlDataAdapter("select distinct alteracionesmarcha from gastro where pacienteid=@pac and folionota=@folio", con)
                        da132.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da132.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr131 = da132.SelectCommand.ExecuteReader
                        dr131.Read()
                        If dr131.HasRows Then
                            DropDownList153.Text = dr131(0)
                            DropDownList153.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da133 = New SqlDataAdapter("select distinct cefalea from gastro where pacienteid=@pac and folionota=@folio", con)
                        da133.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da133.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr132 = da133.SelectCommand.ExecuteReader
                        dr132.Read()
                        If dr132.HasRows Then
                            DropDownList154.Text = dr132(0)
                            DropDownList154.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da134 = New SqlDataAdapter("select distinct sisnerviosonegado from gastro where pacienteid=@pac and folionota=@folio", con)
                        da134.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da134.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr133 = da134.SelectCommand.ExecuteReader
                        dr133.Read()
                        If dr133.HasRows Then
                            DropDownList155.Text = dr133(0)
                            DropDownList155.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da135 = New SqlDataAdapter("select distinct otrossisnerv from gastro where pacienteid=@pac and folionota=@folio", con)
                        da135.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da135.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr134 = da135.SelectCommand.ExecuteReader
                        dr134.Read()
                        If dr134.HasRows Then
                            TextBox133.Text = dr134(0)
                            TextBox133.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da136 = New SqlDataAdapter("select distinct padactual from gastro where pacienteid=@pac and folionota=@folio", con)
                        da136.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da136.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr135 = da136.SelectCommand.ExecuteReader
                        dr135.Read()
                        If dr135.HasRows Then
                            TextBox1.Text = dr135(0)
                            TextBox1.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try
                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da137 = New SqlDataAdapter("select distinct motivoconsulta from gastro where pacienteid=@pac and folionota=@folio", con)
                        da137.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da137.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr136 = da137.SelectCommand.ExecuteReader
                        dr136.Read()
                        If dr136.HasRows Then
                            TextBox12.Text = dr136(0)
                            TextBox12.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try
                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da138 = New SqlDataAdapter("select distinct region from gastro where pacienteid=@pac and folionota=@folio", con)
                        da138.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da138.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr137 = da138.SelectCommand.ExecuteReader
                        dr137.Read()
                        If dr137.HasRows Then
                            TextBox13.Text = dr137(0)
                            TextBox13.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da139 = New SqlDataAdapter("select distinct inicia from gastro where pacienteid=@pac and folionota=@folio", con)
                        da139.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da139.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr138 = da139.SelectCommand.ExecuteReader
                        dr138.Read()
                        If dr138.HasRows Then
                            TextBox14.Text = dr138(0)
                            TextBox14.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da140 = New SqlDataAdapter("select distinct irradiacion from gastro where pacienteid=@pac and folionota=@folio", con)
                        da140.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da140.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr139 = da140.SelectCommand.ExecuteReader
                        dr139.Read()
                        If dr139.HasRows Then
                            TextBox15.Text = dr139(0)
                            TextBox15.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da141 = New SqlDataAdapter("select distinct migracion from gastro where pacienteid=@pac and folionota=@folio", con)
                        da141.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da141.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr140 = da141.SelectCommand.ExecuteReader
                        dr140.Read()
                        If dr140.HasRows Then
                            TextBox16.Text = dr140(0)
                            TextBox16.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da142 = New SqlDataAdapter("select distinct expansion from gastro where pacienteid=@pac and folionota=@folio", con)
                        da142.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da142.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr141 = da142.SelectCommand.ExecuteReader
                        dr141.Read()
                        If dr141.HasRows Then
                            TextBox17.Text = dr141(0)
                            TextBox17.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da144 = New SqlDataAdapter("select distinct semejanzacualitativos from gastro where pacienteid=@pac and folionota=@folio", con)
                        da144.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da144.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr143 = da144.SelectCommand.ExecuteReader
                        dr143.Read()
                        If dr143.HasRows Then
                            TextBox19.Text = dr143(0)
                            TextBox19.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da145 = New SqlDataAdapter("select distinct localizacioncualitativos from gastro where pacienteid=@pac and folionota=@folio", con)
                        da145.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da145.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr144 = da145.SelectCommand.ExecuteReader
                        dr144.Read()
                        If dr144.HasRows Then
                            DropDownList1.Text = dr144(0)
                            DropDownList1.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da146 = New SqlDataAdapter("select distinct intensidadcuantitativos from gastro where pacienteid=@pac and folionota=@folio", con)
                        da146.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da146.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr145 = da146.SelectCommand.ExecuteReader
                        dr145.Read()
                        If dr145.HasRows Then
                            TextBox20.Text = dr145(0)
                            TextBox20.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da147 = New SqlDataAdapter("select distinct maximaintensidadcuantitativos from gastro where pacienteid=@pac and folionota=@folio", con)
                        da147.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da147.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr146 = da147.SelectCommand.ExecuteReader
                        dr146.Read()
                        If dr146.HasRows Then
                            TextBox21.Text = dr146(0)
                            TextBox21.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da148 = New SqlDataAdapter("select distinct intensidadultimoevento from gastro where pacienteid=@pac and folionota=@folio", con)
                        da148.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da148.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr147 = da148.SelectCommand.ExecuteReader
                        dr147.Read()
                        If dr147.HasRows Then
                            TextBox22.Text = dr147(0)
                            TextBox22.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da149 = New SqlDataAdapter("select distinct iniciocronologicos from gastro where pacienteid=@pac and folionota=@folio", con)
                        da149.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da149.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr148 = da149.SelectCommand.ExecuteReader
                        dr148.Read()
                        If dr148.HasRows Then
                            TextBox23.Text = dr148(0)
                            TextBox23.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da150 = New SqlDataAdapter("select distinct patroncronologicos from gastro where pacienteid=@pac and folionota=@folio", con)
                        da150.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da150.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr149 = da150.SelectCommand.ExecuteReader
                        dr149.Read()
                        If dr149.HasRows Then
                            DropDownList2.Text = dr149(0)
                            DropDownList2.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da151 = New SqlDataAdapter("select distinct duracion from gastro where pacienteid=@pac and folionota=@folio", con)
                        da151.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da151.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr150 = da151.SelectCommand.ExecuteReader
                        dr150.Read()
                        If dr150.HasRows Then
                            TextBox24.Text = dr150(0)
                            TextBox24.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da152 = New SqlDataAdapter("select distinct frecuenciadia from gastro where pacienteid=@pac and folionota=@folio", con)
                        da152.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da152.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr151 = da152.SelectCommand.ExecuteReader
                        dr151.Read()
                        If dr151.HasRows Then
                            TextBox25.Text = dr151(0)
                            TextBox25.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da153 = New SqlDataAdapter("select distinct frecuenciamensual from gastro where pacienteid=@pac and folionota=@folio", con)
                        da153.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da153.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr152 = da153.SelectCommand.ExecuteReader
                        dr152.Read()
                        If dr152.HasRows Then
                            TextBox26.Text = dr152(0)
                            TextBox26.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da154 = New SqlDataAdapter("select distinct ultimoevento from gastro where pacienteid=@pac and folionota=@folio", con)
                        da154.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da154.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr153 = da154.SelectCommand.ExecuteReader
                        dr153.Read()
                        If dr153.HasRows Then
                            TextBox27.Text = dr153(0)
                            TextBox27.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da155 = New SqlDataAdapter("select distinct patrondia from gastro where pacienteid=@pac and folionota=@folio", con)
                        da155.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da155.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr154 = da155.SelectCommand.ExecuteReader
                        dr154.Read()
                        If dr154.HasRows Then
                            DropDownList3.Text = dr154(0)
                            DropDownList3.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da156 = New SqlDataAdapter("select distinct patronayuno from gastro where pacienteid=@pac and folionota=@folio", con)
                        da156.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da156.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr155 = da156.SelectCommand.ExecuteReader
                        dr155.Read()
                        If dr155.HasRows Then
                            DropDownList4.Text = dr155(0)
                            DropDownList4.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da157 = New SqlDataAdapter("select distinct patronevacuaciones from gastro where pacienteid=@pac and folionota=@folio", con)
                        da157.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da157.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr156 = da157.SelectCommand.ExecuteReader
                        dr156.Read()
                        If dr156.HasRows Then
                            DropDownList5.Text = dr156(0)
                            DropDownList5.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da158 = New SqlDataAdapter("select distinct patronevacuaciones2 from gastro where pacienteid=@pac and folionota=@folio", con)
                        da158.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da158.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr157 = da158.SelectCommand.ExecuteReader
                        dr157.Read()
                        If dr157.HasRows Then
                            TextBox28.Text = dr157(0)
                            TextBox28.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da159 = New SqlDataAdapter("select distinct patrongases from gastro where pacienteid=@pac and folionota=@folio", con)
                        da159.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da159.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr158 = da159.SelectCommand.ExecuteReader
                        dr158.Read()
                        If dr158.HasRows Then
                            TextBox29.Text = dr158(0)
                            TextBox29.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da160 = New SqlDataAdapter("select distinct patronvomito from gastro where pacienteid=@pac and folionota=@folio", con)
                        da160.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da160.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr159 = da160.SelectCommand.ExecuteReader
                        dr159.Read()
                        If dr159.HasRows Then
                            TextBox30.Text = dr159(0)
                            TextBox30.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da161 = New SqlDataAdapter("select distinct aumentaintesidad from gastro where pacienteid=@pac and folionota=@folio", con)
                        da161.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da161.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr160 = da161.SelectCommand.ExecuteReader
                        dr160.Read()
                        If dr160.HasRows Then
                            TextBox33.Text = dr160(0)
                            TextBox33.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da162 = New SqlDataAdapter("select distinct disminuyeintensidad from gastro where pacienteid=@pac and folionota=@folio", con)
                        da162.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da162.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr161 = da162.SelectCommand.ExecuteReader
                        dr161.Read()
                        If dr161.HasRows Then
                            TextBox34.Text = dr161(0)
                            TextBox34.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da163 = New SqlDataAdapter("select distinct alimdisminuyen from gastro where pacienteid=@pac and folionota=@folio", con)
                        da163.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da163.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr162 = da163.SelectCommand.ExecuteReader
                        dr162.Read()
                        If dr162.HasRows Then
                            TextBox35.Text = dr162(0)
                            TextBox35.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da164 = New SqlDataAdapter("select distinct evacuaciones from gastro where pacienteid=@pac and folionota=@folio", con)
                        da164.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da164.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr163 = da164.SelectCommand.ExecuteReader
                        dr163.Read()
                        If dr163.HasRows Then
                            DropDownList7.Text = dr163(0)
                            DropDownList7.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da165 = New SqlDataAdapter("select distinct canalizacionesgases from gastro where pacienteid=@pac and folionota=@folio", con)
                        da165.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da165.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr164 = da165.SelectCommand.ExecuteReader
                        dr164.Read()
                        If dr164.HasRows Then
                            DropDownList8.Text = dr164(0)
                            DropDownList8.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da166 = New SqlDataAdapter("select distinct eructos from gastro where pacienteid=@pac and folionota=@folio", con)
                        da166.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da166.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr165 = da166.SelectCommand.ExecuteReader
                        dr165.Read()
                        If dr165.HasRows Then
                            DropDownList9.Text = dr165(0)
                            DropDownList9.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da167 = New SqlDataAdapter("select distinct medicamcalman from gastro where pacienteid=@pac and folionota=@folio", con)
                        da167.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da167.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr166 = da167.SelectCommand.ExecuteReader
                        dr166.Read()
                        If dr166.HasRows Then
                            TextBox32.Text = dr166(0)
                            TextBox32.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da168 = New SqlDataAdapter("select distinct medicamnocontrolan from gastro where pacienteid=@pac and folionota=@folio", con)
                        da168.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da168.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr167 = da168.SelectCommand.ExecuteReader
                        dr167.Read()
                        If dr167.HasRows Then
                            TextBox31.Text = dr167(0)
                            TextBox31.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da169 = New SqlDataAdapter("select distinct sintomaocasional1 from gastro where pacienteid=@pac and folionota=@folio", con)
                        da169.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da169.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr168 = da169.SelectCommand.ExecuteReader
                        dr168.Read()
                        If dr168.HasRows Then
                            TextBox36.Text = dr168(0)
                            TextBox36.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da170 = New SqlDataAdapter("select distinct sintomaocasional2 from gastro where pacienteid=@pac and folionota=@folio", con)
                        da170.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da170.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr169 = da170.SelectCommand.ExecuteReader
                        dr169.Read()
                        If dr169.HasRows Then
                            TextBox37.Text = dr169(0)
                            TextBox37.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da171 = New SqlDataAdapter("select distinct sintomaocasional3 from gastro where pacienteid=@pac and folionota=@folio", con)
                        da171.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da171.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr170 = da171.SelectCommand.ExecuteReader
                        dr170.Read()
                        If dr170.HasRows Then
                            TextBox38.Text = dr170(0)
                            TextBox38.Visible = True

                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da172 = New SqlDataAdapter("select distinct sintomaocasional4 from gastro where pacienteid=@pac and folionota=@folio", con)
                        da172.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da172.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr171 = da172.SelectCommand.ExecuteReader
                        dr171.Read()
                        If dr171.HasRows Then
                            TextBox39.Text = dr171(0)
                            TextBox39.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da173 = New SqlDataAdapter("select distinct sintomasiempre1 from gastro where pacienteid=@pac and folionota=@folio", con)
                        da173.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da173.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr172 = da173.SelectCommand.ExecuteReader
                        dr172.Read()
                        If dr172.HasRows Then
                            TextBox40.Text = dr172(0)
                            TextBox40.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da174 = New SqlDataAdapter("select distinct sintomasiempre2 from gastro where pacienteid=@pac and folionota=@folio", con)
                        da174.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da174.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr173 = da174.SelectCommand.ExecuteReader
                        dr173.Read()
                        If dr173.HasRows Then
                            TextBox41.Text = dr173(0)
                            TextBox41.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da175 = New SqlDataAdapter("select distinct sintomasiempre3 from gastro where pacienteid=@pac and folionota=@folio", con)
                        da175.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da175.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr174 = da175.SelectCommand.ExecuteReader
                        dr174.Read()
                        If dr174.HasRows Then
                            TextBox42.Text = dr174(0)
                            TextBox42.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da176 = New SqlDataAdapter("select distinct sintomasiempre4 from gastro where pacienteid=@pac and folionota=@folio", con)
                        da176.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da176.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr175 = da176.SelectCommand.ExecuteReader
                        dr175.Read()
                        If dr175.HasRows Then
                            TextBox43.Text = dr175(0)
                            TextBox43.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da177 = New SqlDataAdapter("select distinct sintomanodolor from gastro where pacienteid=@pac and folionota=@folio", con)
                        da177.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da177.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr176 = da177.SelectCommand.ExecuteReader
                        dr176.Read()
                        If dr176.HasRows Then
                            TextBox44.Text = dr176(0)
                            TextBox44.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da178 = New SqlDataAdapter("select distinct inicionodolor from gastro where pacienteid=@pac and folionota=@folio", con)
                        da178.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da178.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr177 = da178.SelectCommand.ExecuteReader
                        dr177.Read()
                        If dr177.HasRows Then
                            TextBox2.Text = dr177(0)
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
                        da179 = New SqlDataAdapter("select distinct patronnodolor from gastro where pacienteid=@pac and folionota=@folio", con)
                        da179.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da179.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr178 = da179.SelectCommand.ExecuteReader
                        dr178.Read()
                        If dr178.HasRows Then
                            DropDownList6.Text = dr178(0)
                            DropDownList6.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da180 = New SqlDataAdapter("select distinct duracionnodolor from gastro where pacienteid=@pac and folionota=@folio", con)
                        da180.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da180.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr179 = da180.SelectCommand.ExecuteReader
                        dr179.Read()
                        If dr179.HasRows Then
                            TextBox3.Text = dr179(0)
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
                        da181 = New SqlDataAdapter("select distinct frecuenciadianodolor from gastro where pacienteid=@pac and folionota=@folio", con)
                        da181.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da181.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr180 = da181.SelectCommand.ExecuteReader
                        dr180.Read()
                        If dr180.HasRows Then
                            TextBox4.Text = dr180(0)
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
                        da182 = New SqlDataAdapter("select distinct frecuenciamesnodolor from gastro where pacienteid=@pac and folionota=@folio", con)
                        da182.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da182.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr181 = da182.SelectCommand.ExecuteReader
                        dr181.Read()
                        If dr181.HasRows Then
                            TextBox5.Text = dr181(0)
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
                        da183 = New SqlDataAdapter("select distinct ulteventonodolor from gastro where pacienteid=@pac and folionota=@folio", con)
                        da183.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da183.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr182 = da183.SelectCommand.ExecuteReader
                        dr182.Read()
                        If dr182.HasRows Then
                            TextBox6.Text = dr182(0)
                            TextBox6.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da184 = New SqlDataAdapter("select distinct patrondianodolor from gastro where pacienteid=@pac and folionota=@folio", con)
                        da184.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da184.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr183 = da184.SelectCommand.ExecuteReader
                        dr183.Read()
                        If dr183.HasRows Then
                            DropDownList10.Text = dr183(0)
                            DropDownList10.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da185 = New SqlDataAdapter("select distinct patronayunonodolor from gastro where pacienteid=@pac and folionota=@folio", con)
                        da185.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da185.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr184 = da185.SelectCommand.ExecuteReader
                        dr184.Read()
                        If dr184.HasRows Then
                            DropDownList11.Text = dr184(0)
                            DropDownList11.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da186 = New SqlDataAdapter("select distinct patronevacnodolor from gastro where pacienteid=@pac and folionota=@folio", con)
                        da186.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da186.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr185 = da186.SelectCommand.ExecuteReader
                        dr185.Read()
                        If dr185.HasRows Then
                            DropDownList12.Text = dr185(0)
                            DropDownList12.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da187 = New SqlDataAdapter("select distinct patrongasesnodolor from gastro where pacienteid=@pac and folionota=@folio", con)
                        da187.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da187.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr186 = da187.SelectCommand.ExecuteReader
                        dr186.Read()
                        If dr186.HasRows Then
                            TextBox46.Text = dr186(0)
                            TextBox46.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da188 = New SqlDataAdapter("select distinct patronvomitonodolor from gastro where pacienteid=@pac and folionota=@folio", con)
                        da188.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da188.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr187 = da188.SelectCommand.ExecuteReader
                        dr187.Read()
                        If dr187.HasRows Then
                            TextBox45.Text = dr187(0)
                            TextBox45.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da189 = New SqlDataAdapter("select distinct aumentaintensnodolor from gastro where pacienteid=@pac and folionota=@folio", con)
                        da189.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da189.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr188 = da189.SelectCommand.ExecuteReader
                        dr188.Read()
                        If dr188.HasRows Then
                            TextBox47.Text = dr188(0)
                            TextBox47.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da190 = New SqlDataAdapter("select distinct disminuyeintensnodolor from gastro where pacienteid=@pac and folionota=@folio", con)
                        da190.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da190.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr189 = da190.SelectCommand.ExecuteReader
                        dr189.Read()
                        If dr189.HasRows Then
                            TextBox48.Text = dr189(0)
                            TextBox48.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da191 = New SqlDataAdapter("select distinct alimprovocannodolor from gastro where pacienteid=@pac and folionota=@folio", con)
                        da191.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da191.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr190 = da191.SelectCommand.ExecuteReader
                        dr190.Read()
                        If dr190.HasRows Then
                            TextBox49.Text = dr190(0)
                            TextBox49.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da192 = New SqlDataAdapter("select distinct alimdisminuyennodolor from gastro where pacienteid=@pac and folionota=@folio", con)
                        da192.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da192.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr191 = da192.SelectCommand.ExecuteReader
                        dr191.Read()
                        If dr191.HasRows Then
                            TextBox50.Text = dr191(0)
                            TextBox50.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da193 = New SqlDataAdapter("select distinct evacnodolor from gastro where pacienteid=@pac and folionota=@folio", con)
                        da193.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da193.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr192 = da193.SelectCommand.ExecuteReader
                        dr192.Read()
                        If dr192.HasRows Then
                            DropDownList13.Text = dr192(0)
                            DropDownList13.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da194 = New SqlDataAdapter("select distinct canalizgasesnodolor from gastro where pacienteid=@pac and folionota=@folio", con)
                        da194.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da194.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr193 = da194.SelectCommand.ExecuteReader
                        dr193.Read()
                        If dr193.HasRows Then
                            DropDownList14.Text = dr193(0)
                            DropDownList14.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da195 = New SqlDataAdapter("select distinct eructosnodolor from gastro where pacienteid=@pac and folionota=@folio", con)
                        da195.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da195.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr194 = da195.SelectCommand.ExecuteReader
                        dr194.Read()
                        If dr194.HasRows Then
                            DropDownList15.Text = dr194(0)
                            DropDownList15.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da196 = New SqlDataAdapter("select distinct medicamcalmannodolor from gastro where pacienteid=@pac and folionota=@folio", con)
                        da196.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da196.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr195 = da196.SelectCommand.ExecuteReader
                        dr195.Read()
                        If dr195.HasRows Then
                            TextBox51.Text = dr195(0)
                            TextBox51.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da197 = New SqlDataAdapter("select distinct mednocontrolannodolor from gastro where pacienteid=@pac and folionota=@folio", con)
                        da197.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da197.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr196 = da197.SelectCommand.ExecuteReader
                        dr196.Read()
                        If dr196.HasRows Then
                            TextBox52.Text = dr196(0)
                            TextBox52.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da198 = New SqlDataAdapter("select distinct peso from gastro where pacienteid=@pac and folionota=@folio", con)
                        da198.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da198.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr197 = da198.SelectCommand.ExecuteReader
                        dr197.Read()
                        If dr197.HasRows Then
                            TextBox53.Text = dr197(0)
                            TextBox53.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da199 = New SqlDataAdapter("select distinct talla from gastro where pacienteid=@pac and folionota=@folio", con)
                        da199.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da199.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr198 = da199.SelectCommand.ExecuteReader
                        dr198.Read()
                        If dr198.HasRows Then
                            TextBox54.Text = dr198(0)
                            TextBox54.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da200 = New SqlDataAdapter("select distinct temp from gastro where pacienteid=@pac and folionota=@folio", con)
                        da200.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da200.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr199 = da200.SelectCommand.ExecuteReader
                        dr199.Read()
                        If dr199.HasRows Then
                            TextBox55.Text = dr199(0)
                            TextBox55.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da201 = New SqlDataAdapter("select distinct ta from gastro where pacienteid=@pac and folionota=@folio", con)
                        da201.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da201.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr200 = da201.SelectCommand.ExecuteReader
                        dr200.Read()
                        If dr200.HasRows Then
                            TextBox56.Text = dr200(0)
                            TextBox56.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da202 = New SqlDataAdapter("select distinct fc from gastro where pacienteid=@pac and folionota=@folio", con)
                        da202.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da202.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr201 = da202.SelectCommand.ExecuteReader
                        dr201.Read()
                        If dr201.HasRows Then
                            TextBox57.Text = dr201(0)
                            TextBox57.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da203 = New SqlDataAdapter("select distinct fr from gastro where pacienteid=@pac and folionota=@folio", con)
                        da203.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da203.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr202 = da203.SelectCommand.ExecuteReader
                        dr202.Read()
                        If dr202.HasRows Then
                            TextBox58.Text = dr202(0)
                            TextBox58.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da204 = New SqlDataAdapter("select distinct cabeza from gastro where pacienteid=@pac and folionota=@folio", con)
                        da204.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da204.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr203 = da204.SelectCommand.ExecuteReader
                        dr203.Read()
                        If dr203.HasRows Then
                            TextBox59.Text = dr203(0)
                            TextBox59.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da205 = New SqlDataAdapter("select distinct torax from gastro where pacienteid=@pac and folionota=@folio", con)
                        da205.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da205.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr204 = da205.SelectCommand.ExecuteReader
                        dr204.Read()
                        If dr204.HasRows Then
                            TextBox60.Text = dr204(0)
                            TextBox60.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da206 = New SqlDataAdapter("select distinct abdomen from gastro where pacienteid=@pac and folionota=@folio", con)
                        da206.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da206.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr205 = da206.SelectCommand.ExecuteReader
                        dr205.Read()
                        If dr205.HasRows Then
                            TextBox61.Text = dr205(0)
                            TextBox61.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da207 = New SqlDataAdapter("select distinct extremidades from gastro where pacienteid=@pac and folionota=@folio", con)
                        da207.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da207.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr206 = da207.SelectCommand.ExecuteReader
                        dr206.Read()
                        If dr206.HasRows Then
                            TextBox62.Text = dr206(0)
                            TextBox62.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da208 = New SqlDataAdapter("select distinct estudios from gastro where pacienteid=@pac and folionota=@folio", con)
                        da208.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da208.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr207 = da208.SelectCommand.ExecuteReader
                        dr207.Read()
                        If dr207.HasRows Then
                            TextBox63.Text = dr207(0)
                            TextBox63.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da209 = New SqlDataAdapter("select distinct regionanalisis as 'Región',sintomaanalisis as 'Síntoma/Signo',sindromeclin as 'Síndromes Clínicos',subtipoanalisis as 'Subtipo' from gastro where pacienteid=@pac and folionota=@folio", con)
                        da209.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da209.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        da209.Fill(ds3)
                        GridView1.DataSource = ds3.Tables(0)
                        GridView1.DataBind()
                        If GridView1.Rows.Count > 0 Then
                            GridView1.Visible = True
                    End If

                        con.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da210 = New SqlDataAdapter("select distinct analisis from gastro where pacienteid=@pac and folionota=@folio", con)
                        da210.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da210.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr208 = da210.SelectCommand.ExecuteReader
                        dr208.Read()
                        If dr208.HasRows Then
                            TextBox100.Text = dr208(0)
                            TextBox100.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da211 = New SqlDataAdapter("select distinct diagnostico from gastro where pacienteid=@pac and folionota=@folio", con)
                        da211.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da211.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr209 = da211.SelectCommand.ExecuteReader
                        dr209.Read()
                        If dr209.HasRows Then
                            TextBox7.Text = dr209(0)
                            TextBox7.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da212 = New SqlDataAdapter("select distinct indicgrales from gastro where pacienteid=@pac and folionota=@folio", con)
                        da212.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da212.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr210 = da212.SelectCommand.ExecuteReader
                        dr210.Read()
                        If dr210.HasRows Then
                            TextBox114.Text = dr210(0)
                            TextBox114.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da213 = New SqlDataAdapter("select distinct estudiosgrales from gastro where pacienteid=@pac and folionota=@folio", con)
                        da213.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da213.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr211 = da213.SelectCommand.ExecuteReader
                        dr211.Read()
                        If dr211.HasRows Then
                            TextBox79.Text = dr211(0)
                            TextBox79.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da214 = New SqlDataAdapter("select distinct tratamiento from gastro where pacienteid=@pac and folionota=@folio", con)
                        da214.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        da214.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                        dr212 = da214.SelectCommand.ExecuteReader
                        dr212.Read()
                        If dr212.HasRows Then
                            TextBox82.Text = dr212(0)
                            TextBox82.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da215 = New SqlDataAdapter("select SxDiarreicoManual from GSRS where pacienteid=@pac", con)
                        da215.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        dr213 = da215.SelectCommand.ExecuteReader
                        dr213.Read()
                        If dr213.HasRows Then
                            Label181.Text = dr213(0)
                            Label181.Visible = True
                        TextBox64.Visible = False
                        End If

                        con.Close()
                    Catch ex As Exception

                    End Try
                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da216 = New SqlDataAdapter("select SxIndigestionManual from GSRS where pacienteid=@pac", con)
                        da216.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        dr214 = da216.SelectCommand.ExecuteReader
                        dr214.Read()
                        If dr214.HasRows Then
                            Label182.Text = dr214(0)
                            Label182.Visible = True
                            TextBox65.Visible = False
                        Else
                            Label182.Visible = False
                            TextBox65.Visible = True
                        End If

                        con.Close()
                    Catch ex As Exception

                    End Try
                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da217 = New SqlDataAdapter("select SxConstipacionManual from GSRS where pacienteid=@pac", con)
                        da217.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        dr215 = da217.SelectCommand.ExecuteReader
                        dr215.Read()
                        If dr215.HasRows Then
                            Label183.Text = dr215(0)
                            Label183.Visible = True
                            TextBox67.Visible = False
                        Else
                            Label183.Visible = False
                            TextBox67.Visible = True
                        End If

                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da218 = New SqlDataAdapter("select SxDolorAbdominalManual from GSRS where pacienteid=@pac", con)
                        da218.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        dr216 = da218.SelectCommand.ExecuteReader
                        dr216.Read()
                        If dr216.HasRows Then
                            Label184.Text = dr216(0)
                            Label184.Visible = True
                            TextBox70.Visible = False
                        Else
                            Label184.Visible = False
                            TextBox70.Visible = True
                        End If

                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da219 = New SqlDataAdapter("select SxReflujoManual from GSRS where pacienteid=@pac", con)
                        da219.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        dr217 = da219.SelectCommand.ExecuteReader
                        dr217.Read()
                        If dr217.HasRows Then
                            Label185.Text = dr217(0)
                            Label185.Visible = True
                            TextBox73.Visible = False
                        Else
                            Label185.Visible = False
                            TextBox73.Visible = True
                        End If

                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da220 = New SqlDataAdapter("select PuntajeGlobalManual from GSRS where pacienteid=@pac", con)
                        da220.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                        dr218 = da220.SelectCommand.ExecuteReader
                        dr218.Read()
                        If dr218.HasRows Then
                            Label186.Visible = True
                            TextBox76.Visible = False
                            Label186.Text = dr218(0)
                        Else
                            Label186.Visible = False
                            TextBox76.Visible = True
                        End If

                        con.Close()
                    Catch ex As Exception

                    End Try

                'Try
                '    If con.State = ConnectionState.Open Then
                '        con.Close()
                '    End If
                '    con.Open()
                '    da221 = New SqlDataAdapter("select distinct genero from paciente where pacienteid=@pac", con)
                '    da221.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                '    da221.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota2")
                '    dr219 = da221.SelectCommand.ExecuteReader
                '    dr219.Read()
                '    If dr219.HasRows Then

                '        DropDownList200.Text = dr219(0)
                '        DropDownList200.Visible = False
                '        DropDownList200.Visible = True
                '    End If
                '    con.Close()
                'Catch ex As Exception

                'End Try







                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    da = New SqlDataAdapter("select distinct region from tablasintoma", con)
                    da.Fill(ds)
                    DropDownList16.DataValueField = "region"
                    DropDownList16.DataSource = ds.Tables(0)
                    DropDownList16.DataBind()
                    DropDownList20.DataValueField = "region"
                    DropDownList20.DataSource = ds.Tables(0)
                    DropDownList20.DataBind()
                    DropDownList24.DataValueField = "region"
                    DropDownList24.DataSource = ds.Tables(0)
                    DropDownList24.DataBind()
                    DropDownList28.DataValueField = "region"
                    DropDownList28.DataSource = ds.Tables(0)
                    DropDownList28.DataBind()
                    DropDownList32.DataValueField = "region"
                    DropDownList32.DataSource = ds.Tables(0)
                    DropDownList32.DataBind()
                    DropDownList36.DataValueField = "region"
                    DropDownList36.DataSource = ds.Tables(0)
                    DropDownList36.DataBind()
                    DropDownList40.DataValueField = "region"
                    DropDownList40.DataSource = ds.Tables(0)
                    DropDownList40.DataBind()
                    DropDownList44.DataValueField = "region"
                    DropDownList44.DataSource = ds.Tables(0)
                    DropDownList44.DataBind()
                    DropDownList48.DataValueField = "region"
                    DropDownList48.DataSource = ds.Tables(0)
                    DropDownList48.DataBind()
                    DropDownList52.DataValueField = "region"
                    DropDownList52.DataSource = ds.Tables(0)
                    DropDownList52.DataBind()
                    DropDownList56.DataValueField = "region"
                    DropDownList56.DataSource = ds.Tables(0)
                    DropDownList56.DataBind()
                    DropDownList60.DataValueField = "region"
                    DropDownList60.DataSource = ds.Tables(0)
                    DropDownList60.DataBind()


                    con.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try


                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    da1 = New SqlDataAdapter("select distinct sindromeclin from tablasintoma", con)
                    da1.Fill(ds1)
                    DropDownList18.DataValueField = "sindromeclin"
                    DropDownList18.DataSource = ds1.Tables(0)
                    DropDownList18.DataBind()
                    DropDownList22.DataValueField = "sindromeclin"
                    DropDownList22.DataSource = ds1.Tables(0)
                    DropDownList22.DataBind()
                    DropDownList26.DataValueField = "sindromeclin"
                    DropDownList26.DataSource = ds1.Tables(0)
                    DropDownList26.DataBind()
                    DropDownList30.DataValueField = "sindromeclin"
                    DropDownList30.DataSource = ds1.Tables(0)
                    DropDownList30.DataBind()
                    DropDownList34.DataValueField = "sindromeclin"
                    DropDownList34.DataSource = ds1.Tables(0)
                    DropDownList34.DataBind()
                    DropDownList38.DataValueField = "sindromeclin"
                    DropDownList38.DataSource = ds1.Tables(0)
                    DropDownList38.DataBind()
                    DropDownList42.DataValueField = "sindromeclin"
                    DropDownList42.DataSource = ds1.Tables(0)
                    DropDownList42.DataBind()
                    DropDownList46.DataValueField = "sindromeclin"
                    DropDownList46.DataSource = ds1.Tables(0)
                    DropDownList46.DataBind()
                    DropDownList50.DataValueField = "sindromeclin"
                    DropDownList50.DataSource = ds1.Tables(0)
                    DropDownList50.DataBind()
                    DropDownList54.DataValueField = "sindromeclin"
                    DropDownList54.DataSource = ds1.Tables(0)
                    DropDownList54.DataBind()
                    DropDownList58.DataValueField = "sindromeclin"
                    DropDownList58.DataSource = ds1.Tables(0)
                    DropDownList58.DataBind()
                    DropDownList62.DataValueField = "sindromeclin"
                    DropDownList62.DataSource = ds1.Tables(0)
                    DropDownList62.DataBind()
                    con.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    da2 = New SqlDataAdapter("select distinct subtipo from tablasintoma", con)
                    da2.Fill(ds2)
                    DropDownList19.DataValueField = "subtipo"
                    DropDownList19.DataSource = ds2.Tables(0)
                    DropDownList19.DataBind()
                    DropDownList23.DataValueField = "subtipo"
                    DropDownList23.DataSource = ds2.Tables(0)
                    DropDownList23.DataBind()
                    DropDownList27.DataValueField = "subtipo"
                    DropDownList27.DataSource = ds2.Tables(0)
                    DropDownList27.DataBind()
                    DropDownList31.DataValueField = "subtipo"
                    DropDownList31.DataSource = ds2.Tables(0)
                    DropDownList31.DataBind()
                    DropDownList35.DataValueField = "subtipo"
                    DropDownList35.DataSource = ds2.Tables(0)
                    DropDownList35.DataBind()
                    DropDownList39.DataValueField = "subtipo"
                    DropDownList39.DataSource = ds2.Tables(0)
                    DropDownList39.DataBind()
                    DropDownList43.DataValueField = "subtipo"
                    DropDownList43.DataSource = ds2.Tables(0)
                    DropDownList43.DataBind()
                    DropDownList47.DataValueField = "subtipo"
                    DropDownList47.DataSource = ds2.Tables(0)
                    DropDownList47.DataBind()
                    DropDownList51.DataValueField = "subtipo"
                    DropDownList51.DataSource = ds2.Tables(0)
                    DropDownList51.DataBind()
                    DropDownList55.DataValueField = "subtipo"
                    DropDownList55.DataSource = ds2.Tables(0)
                    DropDownList55.DataBind()
                    DropDownList59.DataValueField = "subtipo"
                    DropDownList59.DataSource = ds2.Tables(0)
                    DropDownList59.DataBind()
                    DropDownList63.DataValueField = "subtipo"
                    DropDownList63.DataSource = ds2.Tables(0)
                    DropDownList63.DataBind()
                    con.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                ' ReDim arregloTextBoxs1(0 To 100 - 1)
            End If
        End If

    End Sub

    Protected Sub DropDownList16_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList16.SelectedIndexChanged
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da = New SqlDataAdapter("select distinct sintoma_signo from tablasintoma where region=@region", con)
            da.SelectCommand.Parameters.Add("@region", SqlDbType.VarChar).Value = DropDownList16.SelectedItem.Value
            da.Fill(ds)
            CheckBoxList1.DataValueField = "sintoma_signo"
            CheckBoxList1.DataSource = ds.Tables(0)
            CheckBoxList1.DataBind()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Label10.Visible = True
        TextBox101.Visible = True
    End Sub

    Protected Sub DropDownList20_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList20.SelectedIndexChanged
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da = New SqlDataAdapter("select distinct sintoma_signo from tablasintoma where region=@region", con)
            da.SelectCommand.Parameters.Add("@region", SqlDbType.VarChar).Value = DropDownList20.SelectedItem.Value
            da.Fill(ds)
            CheckBoxList2.DataValueField = "sintoma_signo"
            CheckBoxList2.DataSource = ds.Tables(0)
            CheckBoxList2.DataBind()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Label11.Visible = True
        TextBox103.Visible = True
    End Sub

    Protected Sub DropDownList24_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList24.SelectedIndexChanged
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da = New SqlDataAdapter("select distinct sintoma_signo from tablasintoma where region=@region", con)
            da.SelectCommand.Parameters.Add("@region", SqlDbType.VarChar).Value = DropDownList24.SelectedItem.Value
            da.Fill(ds)
            CheckBoxList3.DataValueField = "sintoma_signo"
            CheckBoxList3.DataSource = ds.Tables(0)
            CheckBoxList3.DataBind()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Label12.Visible = True
        TextBox104.Visible = True
    End Sub

    Protected Sub DropDownList28_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList28.SelectedIndexChanged
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da = New SqlDataAdapter("select distinct sintoma_signo from tablasintoma where region=@region", con)
            da.SelectCommand.Parameters.Add("@region", SqlDbType.VarChar).Value = DropDownList28.SelectedItem.Value
            da.Fill(ds)
            CheckBoxList4.DataValueField = "sintoma_signo"
            CheckBoxList4.DataSource = ds.Tables(0)
            CheckBoxList4.DataBind()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Label13.Visible = True
        TextBox105.Visible = True
    End Sub

    Protected Sub DropDownList32_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList32.SelectedIndexChanged
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da = New SqlDataAdapter("select distinct sintoma_signo from tablasintoma where region=@region", con)
            da.SelectCommand.Parameters.Add("@region", SqlDbType.VarChar).Value = DropDownList32.SelectedItem.Value
            da.Fill(ds)
            CheckBoxList5.DataValueField = "sintoma_signo"
            CheckBoxList5.DataSource = ds.Tables(0)
            CheckBoxList5.DataBind()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Label14.Visible = True
        TextBox106.Visible = True
    End Sub

    Protected Sub DropDownList36_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList36.SelectedIndexChanged
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da = New SqlDataAdapter("select distinct sintoma_signo from tablasintoma where region=@region", con)
            da.SelectCommand.Parameters.Add("@region", SqlDbType.VarChar).Value = DropDownList36.SelectedItem.Value
            da.Fill(ds)
            CheckBoxList6.DataValueField = "sintoma_signo"
            CheckBoxList6.DataSource = ds.Tables(0)
            CheckBoxList6.DataBind()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Label15.Visible = True
        TextBox107.Visible = True
    End Sub

    Protected Sub DropDownList40_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList40.SelectedIndexChanged
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da = New SqlDataAdapter("select distinct sintoma_signo from tablasintoma where region=@region", con)
            da.SelectCommand.Parameters.Add("@region", SqlDbType.VarChar).Value = DropDownList40.SelectedItem.Value
            da.Fill(ds)
            CheckBoxList7.DataValueField = "sintoma_signo"
            CheckBoxList7.DataSource = ds.Tables(0)
            CheckBoxList7.DataBind()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Label16.Visible = True
        TextBox108.Visible = True
    End Sub

    Protected Sub DropDownList44_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList44.SelectedIndexChanged
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da = New SqlDataAdapter("select distinct sintoma_signo from tablasintoma where region=@region", con)
            da.SelectCommand.Parameters.Add("@region", SqlDbType.VarChar).Value = DropDownList44.SelectedItem.Value
            da.Fill(ds)
            CheckBoxList8.DataValueField = "sintoma_signo"
            CheckBoxList8.DataSource = ds.Tables(0)
            CheckBoxList8.DataBind()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Label17.Visible = True
        TextBox109.Visible = True
    End Sub

    Protected Sub DropDownList48_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList48.SelectedIndexChanged
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da = New SqlDataAdapter("select distinct sintoma_signo from tablasintoma where region=@region", con)
            da.SelectCommand.Parameters.Add("@region", SqlDbType.VarChar).Value = DropDownList48.SelectedItem.Value
            da.Fill(ds)
            CheckBoxList9.DataValueField = "sintoma_signo"
            CheckBoxList9.DataSource = ds.Tables(0)
            CheckBoxList9.DataBind()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Label18.Visible = True
        TextBox110.Visible = True
    End Sub

    Protected Sub DropDownList52_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList52.SelectedIndexChanged
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da = New SqlDataAdapter("select distinct sintoma_signo from tablasintoma where region=@region", con)
            da.SelectCommand.Parameters.Add("@region", SqlDbType.VarChar).Value = DropDownList52.SelectedItem.Value
            da.Fill(ds)
            CheckBoxList10.DataValueField = "sintoma_signo"
            CheckBoxList10.DataSource = ds.Tables(0)
            CheckBoxList10.DataBind()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Label19.Visible = True
        TextBox111.Visible = True
    End Sub

    Protected Sub DropDownList56_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList56.SelectedIndexChanged
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da = New SqlDataAdapter("select distinct sintoma_signo from tablasintoma where region=@region", con)
            da.SelectCommand.Parameters.Add("@region", SqlDbType.VarChar).Value = DropDownList56.SelectedItem.Value
            da.Fill(ds)
            CheckBoxList11.DataValueField = "sintoma_signo"
            CheckBoxList11.DataSource = ds.Tables(0)
            CheckBoxList11.DataBind()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Label20.Visible = True
        TextBox112.Visible = True
    End Sub

    Protected Sub DropDownList60_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList60.SelectedIndexChanged
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da = New SqlDataAdapter("select distinct sintoma_signo from tablasintoma where region=@region", con)
            da.SelectCommand.Parameters.Add("@region", SqlDbType.VarChar).Value = DropDownList60.SelectedItem.Value
            da.Fill(ds)
            CheckBoxList12.DataValueField = "sintoma_signo"
            CheckBoxList12.DataSource = ds.Tables(0)
            CheckBoxList12.DataBind()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Label21.Visible = True
        TextBox113.Visible = True
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim da As New SqlDataAdapter
        Dim sintanalisis1 As String = ""
        Dim sintanalisis2 As String = ""
        Dim sintanalisis3 As String = ""
        Dim sintanalisis4 As String = ""
        Dim sintanalisis5 As String = ""
        Dim sintanalisis6 As String = ""
        Dim sintanalisis7 As String = ""
        Dim sintanalisis8 As String = ""
        Dim sintanalisis9 As String = ""
        Dim sintanalisis10 As String = ""
        Dim sintanalisis11 As String = ""
        Dim sintanalisis12 As String = ""
        Try
            If DropDownList16.Text <> "--Seleccionar--" Then


                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    da = New SqlDataAdapter("modificagastro", con)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.SelectCommand.Parameters.Add("@folionota", SqlDbType.Int).Value = Session("numnota2")
                    da.SelectCommand.Parameters.Add("@pacienteid", SqlDbType.Int).Value = Session("Paciente")
                    da.SelectCommand.Parameters.Add("@fechamodif", SqlDbType.DateTime).Value = Label2.Text
                    da.SelectCommand.Parameters.Add("@genero", SqlDbType.VarChar).Value = DropDownList200.Text
                    da.SelectCommand.Parameters.Add("@diarrea", SqlDbType.VarChar).Value = DropDownList17.Text
                    da.SelectCommand.Parameters.Add("@hernias", SqlDbType.VarChar).Value = DropDownList21.Text
                    da.SelectCommand.Parameters.Add("@cancer", SqlDbType.VarChar).Value = DropDownList25.Text
                    da.SelectCommand.Parameters.Add("@estrenimiento", SqlDbType.VarChar).Value = DropDownList29.Text
                    da.SelectCommand.Parameters.Add("@cancerdigestivo", SqlDbType.VarChar).Value = DropDownList33.Text
                    da.SelectCommand.Parameters.Add("@colecistitis", SqlDbType.VarChar).Value = DropDownList37.Text
                    da.SelectCommand.Parameters.Add("@hipertension", SqlDbType.VarChar).Value = DropDownList41.Text
                    da.SelectCommand.Parameters.Add("@cardiopatia", SqlDbType.VarChar).Value = DropDownList45.Text
                    da.SelectCommand.Parameters.Add("@autoinmunes", SqlDbType.VarChar).Value = DropDownList49.Text
                    da.SelectCommand.Parameters.Add("@diabetes", SqlDbType.VarChar).Value = DropDownList53.Text
                    da.SelectCommand.Parameters.Add("@endocrinopatias", SqlDbType.VarChar).Value = DropDownList57.Text
                    da.SelectCommand.Parameters.Add("@otrosenf", SqlDbType.VarChar).Value = TextBox85.Text
                    da.SelectCommand.Parameters.Add("@otrosfam", SqlDbType.VarChar).Value = DropDownList168.Text
                    da.SelectCommand.Parameters.Add("@ocupacion", SqlDbType.VarChar).Value = TextBox91.Text
                    da.SelectCommand.Parameters.Add("@escolaridad", SqlDbType.VarChar).Value = DropDownList61.Text
                    da.SelectCommand.Parameters.Add("@actfis", SqlDbType.VarChar).Value = DropDownList64.Text
                    If DropDownList65.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@alergicos", SqlDbType.VarChar).Value = DropDownList65.Text
                    Else
                        da.SelectCommand.Parameters.Add("@alergicos", SqlDbType.VarChar).Value = TextBox94.Text
                    End If

                    da.SelectCommand.Parameters.Add("@cirugias", SqlDbType.VarChar).Value = TextBox97.Text
                    da.SelectCommand.Parameters.Add("@complicacionescirugias", SqlDbType.VarChar).Value = TextBox115.Text
                    If DropDownList66.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@transfusiones", SqlDbType.VarChar).Value = DropDownList66.Text
                    Else
                        da.SelectCommand.Parameters.Add("@transfusiones", SqlDbType.VarChar).Value = TextBox116.Text
                    End If
                    da.SelectCommand.Parameters.Add("@tiposangre", SqlDbType.VarChar).Value = DropDownList67.Text
                    If DropDownList68.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@fracturas", SqlDbType.VarChar).Value = DropDownList68.Text
                    Else
                        da.SelectCommand.Parameters.Add("@fracturas", SqlDbType.VarChar).Value = TextBox117.Text
                    End If
                    If DropDownList69.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@hospprevias", SqlDbType.VarChar).Value = DropDownList69.Text
                    Else
                        da.SelectCommand.Parameters.Add("@hospprevias", SqlDbType.VarChar).Value = TextBox118.Text
                    End If
                    If DropDownList169.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempohipertension", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientohipertension", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempohipertension", SqlDbType.VarChar).Value = TextBox148.Text
                        da.SelectCommand.Parameters.Add("@tratamientohipertension", SqlDbType.VarChar).Value = TextBox149.Text
                    End If
                    If DropDownList170.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoinsuficiencia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoinsuficiencia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoinsuficiencia", SqlDbType.VarChar).Value = TextBox150.Text
                        da.SelectCommand.Parameters.Add("@tratamientoinsuficiencia", SqlDbType.VarChar).Value = TextBox151.Text
                    End If
                    If DropDownList171.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempocardisq", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientocardisq", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempocardisq", SqlDbType.VarChar).Value = TextBox152.Text
                        da.SelectCommand.Parameters.Add("@tratamientocardisq", SqlDbType.VarChar).Value = TextBox153.Text
                    End If
                    If DropDownList172.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoevc", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoevc", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoevc", SqlDbType.VarChar).Value = TextBox154.Text
                        da.SelectCommand.Parameters.Add("@tratamientoevc", SqlDbType.VarChar).Value = TextBox155.Text
                    End If
                    If DropDownList173.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoinsufvenosa", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoinsufvenosa", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoinsufvenosa", SqlDbType.VarChar).Value = TextBox156.Text
                        da.SelectCommand.Parameters.Add("@tratamientoinsufvenosa", SqlDbType.VarChar).Value = TextBox157.Text
                    End If
                    If DropDownList174.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodiabetes", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientodiabetes", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodiabetes", SqlDbType.VarChar).Value = TextBox158.Text
                        da.SelectCommand.Parameters.Add("@tratamientodiabetes", SqlDbType.VarChar).Value = TextBox159.Text
                    End If
                    If DropDownList175.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodislipidemmia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientodislipidemmia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodislipidemmia", SqlDbType.VarChar).Value = TextBox160.Text
                        da.SelectCommand.Parameters.Add("@tratamientodislipidemmia", SqlDbType.VarChar).Value = TextBox161.Text
                    End If
                    If DropDownList176.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoobesidad", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoobesidad", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoobesidad", SqlDbType.VarChar).Value = TextBox162.Text
                        da.SelectCommand.Parameters.Add("@tratamientoobesidad", SqlDbType.VarChar).Value = TextBox163.Text
                    End If
                    If DropDownList177.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoenftiroidea", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoenftiroidea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoenftiroidea", SqlDbType.VarChar).Value = TextBox164.Text
                        da.SelectCommand.Parameters.Add("@tratamientoenftiroidea", SqlDbType.VarChar).Value = TextBox165.Text
                    End If
                    If DropDownList178.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempocancer", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientocancer", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempocancer", SqlDbType.VarChar).Value = TextBox166.Text
                        da.SelectCommand.Parameters.Add("@tratamientocancer", SqlDbType.VarChar).Value = TextBox167.Text
                    End If
                    If DropDownList179.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempotuberculosis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientotuberculosis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempotuberculosis", SqlDbType.VarChar).Value = TextBox168.Text
                        da.SelectCommand.Parameters.Add("@tratamientotuberculosis", SqlDbType.VarChar).Value = TextBox169.Text
                    End If
                    If DropDownList180.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoasma", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoasma", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoasma", SqlDbType.VarChar).Value = TextBox170.Text
                        da.SelectCommand.Parameters.Add("@tratamientoasma", SqlDbType.VarChar).Value = TextBox171.Text
                    End If
                    If DropDownList181.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoepoc", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoepoc", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoepoc", SqlDbType.VarChar).Value = TextBox172.Text
                        da.SelectCommand.Parameters.Add("@tratamientoepoc", SqlDbType.VarChar).Value = TextBox173.Text
                    End If
                    If DropDownList182.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempobronquitis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientobronquitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempobronquitis", SqlDbType.VarChar).Value = TextBox174.Text
                        da.SelectCommand.Parameters.Add("@tratamientobronquitis", SqlDbType.VarChar).Value = TextBox175.Text
                    End If
                    If TextBox176.Text = "" Then
                        da.SelectCommand.Parameters.Add("@otraenf", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tiempootraenf", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientootraenf", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@otraenf", SqlDbType.VarChar).Value = TextBox176.Text
                        da.SelectCommand.Parameters.Add("@tiempootraenf", SqlDbType.VarChar).Value = TextBox177.Text
                        da.SelectCommand.Parameters.Add("@tratamientootraenf", SqlDbType.VarChar).Value = TextBox178.Text
                    End If
                    If DropDownList84.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoalcoholismo", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantalcoholismo", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoalcoholismo", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@cantalcoholismo", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If DropDownList85.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempotabaquismo", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@canttabaquismo", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempotabaquismo", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@canttabaquismo", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If DropDownList86.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodrogas", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantdrogas", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodrogas", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@cantdrogas", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If TextBox185.Text = "" Then
                        da.SelectCommand.Parameters.Add("@otrotox", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tiempootrotox", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantotrotox", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@otrotox", SqlDbType.VarChar).Value = TextBox185.Text
                        da.SelectCommand.Parameters.Add("@tiempootrotox", SqlDbType.VarChar).Value = TextBox186.Text
                        da.SelectCommand.Parameters.Add("@cantotrotox", SqlDbType.VarChar).Value = TextBox187.Text
                    End If
                        da.SelectCommand.Parameters.Add("@ultregla", SqlDbType.Date).Value = DBNull.Value
                    

                    da.SelectCommand.Parameters.Add("@ritmo", SqlDbType.VarChar).Value = TextBox124.Text
                    da.SelectCommand.Parameters.Add("@menopausia", SqlDbType.VarChar).Value = DropDownList87.Text
                    da.SelectCommand.Parameters.Add("@gesta", SqlDbType.Int).Value = DropDownList88.Text
                    da.SelectCommand.Parameters.Add("@para", SqlDbType.Int).Value = DropDownList89.Text
                    da.SelectCommand.Parameters.Add("@cesarea", SqlDbType.Int).Value = DropDownList90.Text
                    da.SelectCommand.Parameters.Add("@aborto", SqlDbType.Int).Value = DropDownList91.Text
                    da.SelectCommand.Parameters.Add("@metplanfam", SqlDbType.VarChar).Value = DropDownList92.Text
                    da.SelectCommand.Parameters.Add("@otroplanfam", SqlDbType.VarChar).Value = TextBox125.Text
                    If DropDownList93.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempofiebre", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionfiebre", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempofiebre", SqlDbType.VarChar).Value = TextBox188.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionfiebre", SqlDbType.VarChar).Value = TextBox189.Text
                    End If
                    If DropDownList94.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoastenia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionastenia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoastenia", SqlDbType.VarChar).Value = TextBox191.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionastenia", SqlDbType.VarChar).Value = TextBox192.Text
                    End If
                    If DropDownList95.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoadinamia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionadinamia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoadinamia", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionadinamia", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList96.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoanorexia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionanorexia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoanorexia", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionanorexia", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList97.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoperdidapeso", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionperdidapeso", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoperdidapeso", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionperdidapeso", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList98.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@obstruccionnasal", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@obstruccionnasal", SqlDbType.VarChar).Value = DropDownList183.Text
                    End If
                    If DropDownList99.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@ronqueramatutina", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@ronqueramatutina", SqlDbType.VarChar).Value = DropDownList184.Text
                    End If
                    If DropDownList100.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@sinusitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@sinusitis", SqlDbType.VarChar).Value = DropDownList185.Text
                    End If
                    If DropDownList101.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@disfonia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@disfonia", SqlDbType.VarChar).Value = DropDownList186.Text
                    End If
                    If DropDownList102.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@disnea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@disnea", SqlDbType.VarChar).Value = DropDownList187.Text
                    End If
                    If DropDownList103.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@sibilancias", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@sibilancias", SqlDbType.VarChar).Value = DropDownList188.Text
                    End If
                    If DropDownList104.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tos", SqlDbType.VarChar).Value = DropDownList189.Text
                    End If
                    If DropDownList105.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@cianosis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@cianosis", SqlDbType.VarChar).Value = DropDownList190.Text
                    End If
                    If DropDownList106.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@asma", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@asma", SqlDbType.VarChar).Value = DropDownList191.Text
                    End If
                    If DropDownList107.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorolipotimia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacioneslipotimia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorolipotimia", SqlDbType.VarChar).Value = DropDownList192.Text
                        da.SelectCommand.Parameters.Add("@sensacioneslipotimia", SqlDbType.VarChar).Value = TextBox203.Text
                    End If
                    If DropDownList108.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorosincope", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionessincope", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorosincope", SqlDbType.VarChar).Value = DropDownList193.Text
                        da.SelectCommand.Parameters.Add("@sensacionessincope", SqlDbType.VarChar).Value = TextBox204.Text
                    End If
                    If DropDownList109.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorofatiga", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesfatiga", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorofatiga", SqlDbType.VarChar).Value = DropDownList194.Text
                        da.SelectCommand.Parameters.Add("@sensacionesfatiga", SqlDbType.VarChar).Value = TextBox205.Text
                    End If
                    If DropDownList110.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoropalpitaciones", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionespalpitaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoropalpitaciones", SqlDbType.VarChar).Value = DropDownList195.Text
                        da.SelectCommand.Parameters.Add("@sensacionespalpitaciones", SqlDbType.VarChar).Value = TextBox206.Text
                    End If
                    If DropDownList111.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorodolprecordial", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesdolprecordial", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorodolprecordial", SqlDbType.VarChar).Value = DropDownList196.Text
                        da.SelectCommand.Parameters.Add("@sensacionesdolprecordial", SqlDbType.VarChar).Value = TextBox207.Text
                    End If
                    If DropDownList112.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoroedema", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesedema", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoroedema", SqlDbType.VarChar).Value = DropDownList197.Text
                        da.SelectCommand.Parameters.Add("@sensacionesedema", SqlDbType.VarChar).Value = TextBox208.Text
                    End If
                    If DropDownList113.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorodisnea", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesdisnea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorodisnea", SqlDbType.VarChar).Value = DropDownList198.Text
                        da.SelectCommand.Parameters.Add("@sensacionesdisnea", SqlDbType.VarChar).Value = TextBox209.Text
                    End If
                    If DropDownList114.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoroascitis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesascitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoroascitis", SqlDbType.VarChar).Value = DropDownList199.Text
                        da.SelectCommand.Parameters.Add("@sensacionesascitis", SqlDbType.VarChar).Value = TextBox210.Text
                    End If
                    da.SelectCommand.Parameters.Add("@disuria", SqlDbType.VarChar).Value = DropDownList138.Text
                    da.SelectCommand.Parameters.Add("@poliaquiuria", SqlDbType.VarChar).Value = DropDownList139.Text
                    da.SelectCommand.Parameters.Add("@tenesmo", SqlDbType.VarChar).Value = DropDownList140.Text
                    da.SelectCommand.Parameters.Add("@hematuria", SqlDbType.VarChar).Value = DropDownList141.Text
                    da.SelectCommand.Parameters.Add("@suprapubica", SqlDbType.VarChar).Value = DropDownList142.Text
                    da.SelectCommand.Parameters.Add("@lumbar", SqlDbType.VarChar).Value = DropDownList143.Text
                    da.SelectCommand.Parameters.Add("@ninguno", SqlDbType.VarChar).Value = DropDownList144.Text
                    da.SelectCommand.Parameters.Add("@otrosdolores", SqlDbType.VarChar).Value = TextBox131.Text
                    da.SelectCommand.Parameters.Add("@tendenciahemorragia", SqlDbType.VarChar).Value = DropDownList145.Text
                    da.SelectCommand.Parameters.Add("@adenopatias", SqlDbType.VarChar).Value = DropDownList146.Text
                    da.SelectCommand.Parameters.Add("@infecrecurrentes", SqlDbType.VarChar).Value = DropDownList147.Text
                    da.SelectCommand.Parameters.Add("@anemia", SqlDbType.VarChar).Value = DropDownList148.Text
                    da.SelectCommand.Parameters.Add("@hemolinfaticonegado", SqlDbType.VarChar).Value = DropDownList149.Text
                    da.SelectCommand.Parameters.Add("@otroshemolinf", SqlDbType.VarChar).Value = TextBox132.Text
                    da.SelectCommand.Parameters.Add("@paralisis", SqlDbType.VarChar).Value = DropDownList150.Text
                    da.SelectCommand.Parameters.Add("@parestesisas", SqlDbType.VarChar).Value = DropDownList151.Text
                    da.SelectCommand.Parameters.Add("@temblores", SqlDbType.VarChar).Value = DropDownList152.Text
                    da.SelectCommand.Parameters.Add("@alteracionesmarcha", SqlDbType.VarChar).Value = DropDownList153.Text
                    da.SelectCommand.Parameters.Add("@cefalea", SqlDbType.VarChar).Value = DropDownList154.Text
                    da.SelectCommand.Parameters.Add("@sisnerviosonegado", SqlDbType.VarChar).Value = DropDownList155.Text
                    da.SelectCommand.Parameters.Add("@otrossisnerv", SqlDbType.VarChar).Value = TextBox133.Text
                    da.SelectCommand.Parameters.Add("@padactual", SqlDbType.VarChar).Value = TextBox1.Text
                    da.SelectCommand.Parameters.Add("@motivoconsulta", SqlDbType.VarChar).Value = TextBox12.Text
                    da.SelectCommand.Parameters.Add("@region", SqlDbType.VarChar).Value = TextBox13.Text
                    da.SelectCommand.Parameters.Add("@inicia", SqlDbType.VarChar).Value = TextBox14.Text
                    da.SelectCommand.Parameters.Add("@irradiacion", SqlDbType.VarChar).Value = TextBox15.Text
                    da.SelectCommand.Parameters.Add("@migracion", SqlDbType.VarChar).Value = TextBox16.Text
                    da.SelectCommand.Parameters.Add("@expansion", SqlDbType.VarChar).Value = TextBox17.Text
                    da.SelectCommand.Parameters.Add("@proyeccion", SqlDbType.VarChar).Value = TextBox18.Text
                    da.SelectCommand.Parameters.Add("@semejanzacualitativos", SqlDbType.VarChar).Value = TextBox19.Text
                    If DropDownList1.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@localizacioncualitativos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@localizacioncualitativos", SqlDbType.VarChar).Value = DropDownList1.Text
                    End If
                    da.SelectCommand.Parameters.Add("@intensidadcuantitativos", SqlDbType.VarChar).Value = TextBox20.Text
                    da.SelectCommand.Parameters.Add("@maximaintensidadcuantitativos", SqlDbType.VarChar).Value = TextBox21.Text
                    da.SelectCommand.Parameters.Add("@intensidadultimoevento", SqlDbType.VarChar).Value = TextBox22.Text
                    da.SelectCommand.Parameters.Add("@iniciocronologicos", SqlDbType.VarChar).Value = TextBox23.Text
                    If DropDownList2.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patroncronologicos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patroncronologicos", SqlDbType.VarChar).Value = DropDownList2.Text
                    End If
                    da.SelectCommand.Parameters.Add("@duracion", SqlDbType.VarChar).Value = TextBox24.Text
                    da.SelectCommand.Parameters.Add("@frecuenciadia", SqlDbType.VarChar).Value = TextBox25.Text
                    da.SelectCommand.Parameters.Add("@frecuenciamensual", SqlDbType.VarChar).Value = TextBox26.Text
                    da.SelectCommand.Parameters.Add("@ultimoevento", SqlDbType.VarChar).Value = TextBox27.Text
                    If DropDownList3.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patrondia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patrondia", SqlDbType.VarChar).Value = DropDownList3.Text
                    End If
                    If DropDownList4.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronayuno", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronayuno", SqlDbType.VarChar).Value = DropDownList4.Text
                    End If
                    If DropDownList5.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronevacuaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronevacuaciones", SqlDbType.VarChar).Value = DropDownList5.Text
                    End If

                    da.SelectCommand.Parameters.Add("@patronevacuaciones2", SqlDbType.VarChar).Value = TextBox28.Text
                    da.SelectCommand.Parameters.Add("@patrongases", SqlDbType.VarChar).Value = TextBox29.Text
                    da.SelectCommand.Parameters.Add("@patronvomito", SqlDbType.VarChar).Value = TextBox30.Text
                    da.SelectCommand.Parameters.Add("@aumentaintesidad", SqlDbType.VarChar).Value = TextBox33.Text
                    da.SelectCommand.Parameters.Add("@disminuyeintensidad", SqlDbType.VarChar).Value = TextBox33.Text
                    da.SelectCommand.Parameters.Add("@alimdisminuyen", SqlDbType.VarChar).Value = TextBox35.Text
                    If DropDownList7.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@evacuaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@evacuaciones", SqlDbType.VarChar).Value = DropDownList7.Text
                    End If

                    If DropDownList8.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@canalizacionesgases", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@canalizacionesgases", SqlDbType.VarChar).Value = DropDownList8.Text
                    End If
                    If DropDownList9.Text = "-Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@eructos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@eructos", SqlDbType.VarChar).Value = DropDownList9.Text
                    End If
                    da.SelectCommand.Parameters.Add("@medicamcalman", SqlDbType.VarChar).Value = TextBox32.Text
                    da.SelectCommand.Parameters.Add("@medicamnocontrolan", SqlDbType.VarChar).Value = TextBox31.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional1", SqlDbType.VarChar).Value = TextBox36.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional2", SqlDbType.VarChar).Value = TextBox37.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional3", SqlDbType.VarChar).Value = TextBox38.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional4", SqlDbType.VarChar).Value = TextBox39.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre1", SqlDbType.VarChar).Value = TextBox40.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre2", SqlDbType.VarChar).Value = TextBox41.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre3", SqlDbType.VarChar).Value = TextBox42.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre4", SqlDbType.VarChar).Value = TextBox43.Text
                    da.SelectCommand.Parameters.Add("@sintomanodolor", SqlDbType.VarChar).Value = TextBox44.Text
                    da.SelectCommand.Parameters.Add("@inicionodolor", SqlDbType.VarChar).Value = TextBox2.Text
                    If DropDownList6.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronnodolor", SqlDbType.VarChar).Value = DropDownList6.Text
                    End If

                    da.SelectCommand.Parameters.Add("@duracionnodolor", SqlDbType.VarChar).Value = TextBox3.Text
                    da.SelectCommand.Parameters.Add("@frecuenciadianodolor", SqlDbType.VarChar).Value = TextBox4.Text
                    da.SelectCommand.Parameters.Add("@frecuenciamesnodolor", SqlDbType.VarChar).Value = TextBox5.Text
                    da.SelectCommand.Parameters.Add("@ulteventonodolor", SqlDbType.VarChar).Value = TextBox6.Text
                    If DropDownList10.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patrondianodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patrondianodolor", SqlDbType.VarChar).Value = DropDownList10.Text
                    End If
                    If DropDownList11.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronayunonodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronayunonodolor", SqlDbType.VarChar).Value = DropDownList11.Text
                    End If
                    If DropDownList12.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronevacnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronevacnodolor", SqlDbType.VarChar).Value = DropDownList12.Text
                    End If
                    da.SelectCommand.Parameters.Add("@patrongasesnodolor", SqlDbType.VarChar).Value = TextBox46.Text
                    da.SelectCommand.Parameters.Add("@patronvomitonodolor", SqlDbType.VarChar).Value = TextBox45.Text
                    da.SelectCommand.Parameters.Add("@aumentaintensnodolor", SqlDbType.VarChar).Value = TextBox47.Text
                    da.SelectCommand.Parameters.Add("@disminuyeintensnodolor", SqlDbType.VarChar).Value = TextBox48.Text
                    da.SelectCommand.Parameters.Add("@alimprovocannodolor", SqlDbType.VarChar).Value = TextBox49.Text
                    da.SelectCommand.Parameters.Add("@alimdisminuyennodolor", SqlDbType.VarChar).Value = TextBox50.Text
                    If DropDownList13.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@evacnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@evacnodolor", SqlDbType.VarChar).Value = DropDownList13.Text
                    End If
                    If DropDownList14.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@canalizgasesnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@canalizgasesnodolor", SqlDbType.VarChar).Value = DropDownList14.Text
                    End If
                    If DropDownList15.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@eructosnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@eructosnodolor", SqlDbType.VarChar).Value = DropDownList15.Text
                    End If

                    da.SelectCommand.Parameters.Add("@medicamcalmannodolor", SqlDbType.VarChar).Value = TextBox51.Text
                    da.SelectCommand.Parameters.Add("@mednocontrolannodolor", SqlDbType.VarChar).Value = TextBox52.Text
                    da.SelectCommand.Parameters.Add("@peso", SqlDbType.VarChar).Value = TextBox53.Text
                    da.SelectCommand.Parameters.Add("@talla", SqlDbType.VarChar).Value = TextBox54.Text
                    da.SelectCommand.Parameters.Add("@temp", SqlDbType.VarChar).Value = TextBox55.Text
                    da.SelectCommand.Parameters.Add("@ta", SqlDbType.VarChar).Value = TextBox56.Text
                    da.SelectCommand.Parameters.Add("@tc", SqlDbType.VarChar).Value = TextBox57.Text
                    da.SelectCommand.Parameters.Add("@fr", SqlDbType.VarChar).Value = TextBox58.Text
                    da.SelectCommand.Parameters.Add("@cabeza", SqlDbType.VarChar).Value = TextBox59.Text
                    da.SelectCommand.Parameters.Add("@torax", SqlDbType.VarChar).Value = TextBox60.Text
                    da.SelectCommand.Parameters.Add("@abdomen", SqlDbType.VarChar).Value = TextBox61.Text
                    da.SelectCommand.Parameters.Add("@extremidades", SqlDbType.VarChar).Value = TextBox62.Text
                    da.SelectCommand.Parameters.Add("@estudios", SqlDbType.VarChar).Value = TextBox63.Text
                    da.SelectCommand.Parameters.Add("@regionanalisis", SqlDbType.VarChar).Value = DropDownList16.Text
                    For Each li As ListItem In CheckBoxList1.Items
                        If li.Selected Then
                            If sintanalisis1.Length = 0 Then
                                sintanalisis1 = li.Value
                            Else
                                sintanalisis1 += ", " + li.Value
                            End If
                        End If
                    Next
                    If TextBox101.Text <> "" Then
                        sintanalisis1 += ", " + TextBox101.Text
                    End If
                    da.SelectCommand.Parameters.Add("@sintomaanalisis", SqlDbType.VarChar).Value = sintanalisis1
                    If TextBox102.Visible = True Then
                        da.SelectCommand.Parameters.Add("@sindromeclin", SqlDbType.VarChar).Value = TextBox102.Text
                    Else
                        da.SelectCommand.Parameters.Add("@sindromeclin", SqlDbType.VarChar).Value = DropDownList18.Text
                    End If
                    If TextBox66.Visible = True Then
                        da.SelectCommand.Parameters.Add("@subtipoanalisis", SqlDbType.VarChar).Value = TextBox66.Text
                    Else
                        da.SelectCommand.Parameters.Add("@subtipoanalisis", SqlDbType.VarChar).Value = DropDownList19.Text
                    End If
                    da.SelectCommand.Parameters.Add("@analisis", SqlDbType.VarChar).Value = TextBox100.Text
                    da.SelectCommand.Parameters.Add("@diagnostico", SqlDbType.VarChar).Value = TextBox7.Text
                    da.SelectCommand.Parameters.Add("@indicgrales", SqlDbType.VarChar).Value = TextBox114.Text
                    da.SelectCommand.Parameters.Add("@estudiosgrales", SqlDbType.VarChar).Value = TextBox79.Text
                    da.SelectCommand.Parameters.Add("@tratamiento", SqlDbType.VarChar).Value = TextBox82.Text
                    da.SelectCommand.Parameters.Add("@medico", SqlDbType.VarChar).Value = Label8.Text

                    da.SelectCommand.ExecuteNonQuery()
                    con.Close()


                Catch ex As Exception

                End Try
            End If

            If DropDownList20.Text <> "--Seleccionar--" Then


                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    da = New SqlDataAdapter("modificagastro", con)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.SelectCommand.Parameters.Add("@folionota", SqlDbType.Int).Value = Session("numnota2")
                    da.SelectCommand.Parameters.Add("@pacienteid", SqlDbType.Int).Value = Session("Paciente")
                    da.SelectCommand.Parameters.Add("@fechamodif", SqlDbType.DateTime).Value = Label2.Text
                    da.SelectCommand.Parameters.Add("@genero", SqlDbType.VarChar).Value = DropDownList200.Text
                    da.SelectCommand.Parameters.Add("@diarrea", SqlDbType.VarChar).Value = DropDownList17.Text
                    da.SelectCommand.Parameters.Add("@hernias", SqlDbType.VarChar).Value = DropDownList21.Text
                    da.SelectCommand.Parameters.Add("@cancer", SqlDbType.VarChar).Value = DropDownList25.Text
                    da.SelectCommand.Parameters.Add("@estrenimiento", SqlDbType.VarChar).Value = DropDownList29.Text
                    da.SelectCommand.Parameters.Add("@cancerdigestivo", SqlDbType.VarChar).Value = DropDownList33.Text
                    da.SelectCommand.Parameters.Add("@colecistitis", SqlDbType.VarChar).Value = DropDownList37.Text
                    da.SelectCommand.Parameters.Add("@hipertension", SqlDbType.VarChar).Value = DropDownList41.Text
                    da.SelectCommand.Parameters.Add("@cardiopatia", SqlDbType.VarChar).Value = DropDownList45.Text
                    da.SelectCommand.Parameters.Add("@autoinmunes", SqlDbType.VarChar).Value = DropDownList49.Text
                    da.SelectCommand.Parameters.Add("@diabetes", SqlDbType.VarChar).Value = DropDownList53.Text
                    da.SelectCommand.Parameters.Add("@endocrinopatias", SqlDbType.VarChar).Value = DropDownList57.Text
                    da.SelectCommand.Parameters.Add("@otrosenf", SqlDbType.VarChar).Value = TextBox85.Text
                    da.SelectCommand.Parameters.Add("@otrosfam", SqlDbType.VarChar).Value = DropDownList168.Text
                    da.SelectCommand.Parameters.Add("@ocupacion", SqlDbType.VarChar).Value = TextBox91.Text
                    da.SelectCommand.Parameters.Add("@escolaridad", SqlDbType.VarChar).Value = DropDownList61.Text
                    da.SelectCommand.Parameters.Add("@actfis", SqlDbType.VarChar).Value = DropDownList64.Text
                    If DropDownList65.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@alergicos", SqlDbType.VarChar).Value = DropDownList65.Text
                    Else
                        da.SelectCommand.Parameters.Add("@alergicos", SqlDbType.VarChar).Value = TextBox94.Text
                    End If

                    da.SelectCommand.Parameters.Add("@cirugias", SqlDbType.VarChar).Value = TextBox97.Text
                    da.SelectCommand.Parameters.Add("@complicacionescirugias", SqlDbType.VarChar).Value = TextBox115.Text
                    If DropDownList66.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@transfusiones", SqlDbType.VarChar).Value = DropDownList66.Text
                    Else
                        da.SelectCommand.Parameters.Add("@transfusiones", SqlDbType.VarChar).Value = TextBox116.Text
                    End If
                    da.SelectCommand.Parameters.Add("@tiposangre", SqlDbType.VarChar).Value = DropDownList67.Text
                    If DropDownList68.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@fracturas", SqlDbType.VarChar).Value = DropDownList68.Text
                    Else
                        da.SelectCommand.Parameters.Add("@fracturas", SqlDbType.VarChar).Value = TextBox117.Text
                    End If
                    If DropDownList69.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@hospprevias", SqlDbType.VarChar).Value = DropDownList69.Text
                    Else
                        da.SelectCommand.Parameters.Add("@hospprevias", SqlDbType.VarChar).Value = TextBox118.Text
                    End If
                    If DropDownList169.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempohipertension", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientohipertension", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempohipertension", SqlDbType.VarChar).Value = TextBox148.Text
                        da.SelectCommand.Parameters.Add("@tratamientohipertension", SqlDbType.VarChar).Value = TextBox149.Text
                    End If
                    If DropDownList170.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoinsuficiencia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoinsuficiencia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoinsuficiencia", SqlDbType.VarChar).Value = TextBox150.Text
                        da.SelectCommand.Parameters.Add("@tratamientoinsuficiencia", SqlDbType.VarChar).Value = TextBox151.Text
                    End If
                    If DropDownList171.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempocardisq", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientocardisq", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempocardisq", SqlDbType.VarChar).Value = TextBox152.Text
                        da.SelectCommand.Parameters.Add("@tratamientocardisq", SqlDbType.VarChar).Value = TextBox153.Text
                    End If
                    If DropDownList172.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoevc", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoevc", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoevc", SqlDbType.VarChar).Value = TextBox154.Text
                        da.SelectCommand.Parameters.Add("@tratamientoevc", SqlDbType.VarChar).Value = TextBox155.Text
                    End If
                    If DropDownList173.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoinsufvenosa", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoinsufvenosa", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoinsufvenosa", SqlDbType.VarChar).Value = TextBox156.Text
                        da.SelectCommand.Parameters.Add("@tratamientoinsufvenosa", SqlDbType.VarChar).Value = TextBox157.Text
                    End If
                    If DropDownList174.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodiabetes", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientodiabetes", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodiabetes", SqlDbType.VarChar).Value = TextBox158.Text
                        da.SelectCommand.Parameters.Add("@tratamientodiabetes", SqlDbType.VarChar).Value = TextBox159.Text
                    End If
                    If DropDownList175.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodislipidemmia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientodislipidemmia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodislipidemmia", SqlDbType.VarChar).Value = TextBox160.Text
                        da.SelectCommand.Parameters.Add("@tratamientodislipidemmia", SqlDbType.VarChar).Value = TextBox161.Text
                    End If
                    If DropDownList176.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoobesidad", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoobesidad", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoobesidad", SqlDbType.VarChar).Value = TextBox162.Text
                        da.SelectCommand.Parameters.Add("@tratamientoobesidad", SqlDbType.VarChar).Value = TextBox163.Text
                    End If
                    If DropDownList177.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoenftiroidea", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoenftiroidea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoenftiroidea", SqlDbType.VarChar).Value = TextBox164.Text
                        da.SelectCommand.Parameters.Add("@tratamientoenftiroidea", SqlDbType.VarChar).Value = TextBox165.Text
                    End If
                    If DropDownList178.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempocancer", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientocancer", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempocancer", SqlDbType.VarChar).Value = TextBox166.Text
                        da.SelectCommand.Parameters.Add("@tratamientocancer", SqlDbType.VarChar).Value = TextBox167.Text
                    End If
                    If DropDownList179.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempotuberculosis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientotuberculosis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempotuberculosis", SqlDbType.VarChar).Value = TextBox168.Text
                        da.SelectCommand.Parameters.Add("@tratamientotuberculosis", SqlDbType.VarChar).Value = TextBox169.Text
                    End If
                    If DropDownList180.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoasma", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoasma", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoasma", SqlDbType.VarChar).Value = TextBox170.Text
                        da.SelectCommand.Parameters.Add("@tratamientoasma", SqlDbType.VarChar).Value = TextBox171.Text
                    End If
                    If DropDownList181.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoepoc", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoepoc", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoepoc", SqlDbType.VarChar).Value = TextBox172.Text
                        da.SelectCommand.Parameters.Add("@tratamientoepoc", SqlDbType.VarChar).Value = TextBox173.Text
                    End If
                    If DropDownList182.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempobronquitis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientobronquitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempobronquitis", SqlDbType.VarChar).Value = TextBox174.Text
                        da.SelectCommand.Parameters.Add("@tratamientobronquitis", SqlDbType.VarChar).Value = TextBox175.Text
                    End If
                    If TextBox176.Text = "" Then
                        da.SelectCommand.Parameters.Add("@otraenf", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tiempootraenf", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientootraenf", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@otraenf", SqlDbType.VarChar).Value = TextBox176.Text
                        da.SelectCommand.Parameters.Add("@tiempootraenf", SqlDbType.VarChar).Value = TextBox177.Text
                        da.SelectCommand.Parameters.Add("@tratamientootraenf", SqlDbType.VarChar).Value = TextBox178.Text
                    End If
                    If DropDownList84.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoalcoholismo", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantalcoholismo", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoalcoholismo", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@cantalcoholismo", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If DropDownList85.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempotabaquismo", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@canttabaquismo", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempotabaquismo", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@canttabaquismo", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If DropDownList86.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodrogas", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantdrogas", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodrogas", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@cantdrogas", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If TextBox185.Text = "" Then
                        da.SelectCommand.Parameters.Add("@otrotox", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tiempootrotox", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantotrotox", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@otrotox", SqlDbType.VarChar).Value = TextBox185.Text
                        da.SelectCommand.Parameters.Add("@tiempootrotox", SqlDbType.VarChar).Value = TextBox186.Text
                        da.SelectCommand.Parameters.Add("@cantotrotox", SqlDbType.VarChar).Value = TextBox187.Text
                    End If

                    da.SelectCommand.Parameters.Add("@ultregla", SqlDbType.Date).Value = DBNull.Value
                   
            da.SelectCommand.Parameters.Add("@ritmo", SqlDbType.VarChar).Value = TextBox124.Text
            da.SelectCommand.Parameters.Add("@menopausia", SqlDbType.VarChar).Value = DropDownList87.Text
            da.SelectCommand.Parameters.Add("@gesta", SqlDbType.Int).Value = DropDownList88.Text
            da.SelectCommand.Parameters.Add("@para", SqlDbType.Int).Value = DropDownList89.Text
            da.SelectCommand.Parameters.Add("@cesarea", SqlDbType.Int).Value = DropDownList90.Text
            da.SelectCommand.Parameters.Add("@aborto", SqlDbType.Int).Value = DropDownList91.Text
            da.SelectCommand.Parameters.Add("@metplanfam", SqlDbType.VarChar).Value = DropDownList92.Text
            da.SelectCommand.Parameters.Add("@otroplanfam", SqlDbType.VarChar).Value = TextBox125.Text
            If DropDownList93.Text = "No" Then
                da.SelectCommand.Parameters.Add("@tiempofiebre", SqlDbType.VarChar).Value = ""
                da.SelectCommand.Parameters.Add("@cuantificacionfiebre", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@tiempofiebre", SqlDbType.VarChar).Value = TextBox188.Text
                da.SelectCommand.Parameters.Add("@cuantificacionfiebre", SqlDbType.VarChar).Value = TextBox189.Text
            End If
            If DropDownList94.Text = "No" Then
                da.SelectCommand.Parameters.Add("@tiempoastenia", SqlDbType.VarChar).Value = ""
                da.SelectCommand.Parameters.Add("@cuantificacionastenia", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@tiempoastenia", SqlDbType.VarChar).Value = TextBox191.Text
                da.SelectCommand.Parameters.Add("@cuantificacionastenia", SqlDbType.VarChar).Value = TextBox192.Text
            End If
            If DropDownList95.Text = "No" Then
                da.SelectCommand.Parameters.Add("@tiempoadinamia", SqlDbType.VarChar).Value = ""
                da.SelectCommand.Parameters.Add("@cuantificacionadinamia", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@tiempoadinamia", SqlDbType.VarChar).Value = TextBox194.Text
                da.SelectCommand.Parameters.Add("@cuantificacionadinamia", SqlDbType.VarChar).Value = TextBox195.Text
            End If
            If DropDownList96.Text = "No" Then
                da.SelectCommand.Parameters.Add("@tiempoanorexia", SqlDbType.VarChar).Value = ""
                da.SelectCommand.Parameters.Add("@cuantificacionanorexia", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@tiempoanorexia", SqlDbType.VarChar).Value = TextBox194.Text
                da.SelectCommand.Parameters.Add("@cuantificacionanorexia", SqlDbType.VarChar).Value = TextBox195.Text
            End If
            If DropDownList97.Text = "No" Then
                da.SelectCommand.Parameters.Add("@tiempoperdidapeso", SqlDbType.VarChar).Value = ""
                da.SelectCommand.Parameters.Add("@cuantificacionperdidapeso", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@tiempoperdidapeso", SqlDbType.VarChar).Value = TextBox194.Text
                da.SelectCommand.Parameters.Add("@cuantificacionperdidapeso", SqlDbType.VarChar).Value = TextBox195.Text
            End If
            If DropDownList98.Text = "No" Then
                da.SelectCommand.Parameters.Add("@obstruccionnasal", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@obstruccionnasal", SqlDbType.VarChar).Value = DropDownList183.Text
            End If
            If DropDownList99.Text = "No" Then
                da.SelectCommand.Parameters.Add("@ronqueramatutina", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@ronqueramatutina", SqlDbType.VarChar).Value = DropDownList184.Text
            End If
            If DropDownList100.Text = "No" Then
                da.SelectCommand.Parameters.Add("@sinusitis", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@sinusitis", SqlDbType.VarChar).Value = DropDownList185.Text
            End If
            If DropDownList101.Text = "No" Then
                da.SelectCommand.Parameters.Add("@disfonia", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@disfonia", SqlDbType.VarChar).Value = DropDownList186.Text
            End If
            If DropDownList102.Text = "No" Then
                da.SelectCommand.Parameters.Add("@disnea", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@disnea", SqlDbType.VarChar).Value = DropDownList187.Text
            End If
            If DropDownList103.Text = "No" Then
                da.SelectCommand.Parameters.Add("@sibilancias", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@sibilancias", SqlDbType.VarChar).Value = DropDownList188.Text
            End If
            If DropDownList104.Text = "No" Then
                da.SelectCommand.Parameters.Add("@tos", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@tos", SqlDbType.VarChar).Value = DropDownList189.Text
            End If
            If DropDownList105.Text = "No" Then
                da.SelectCommand.Parameters.Add("@cianosis", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@cianosis", SqlDbType.VarChar).Value = DropDownList190.Text
            End If
            If DropDownList106.Text = "No" Then
                da.SelectCommand.Parameters.Add("@asma", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@asma", SqlDbType.VarChar).Value = DropDownList191.Text
            End If
            If DropDownList107.Text = "No" Then
                da.SelectCommand.Parameters.Add("@mejorolipotimia", SqlDbType.VarChar).Value = ""
                da.SelectCommand.Parameters.Add("@sensacioneslipotimia", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@mejorolipotimia", SqlDbType.VarChar).Value = DropDownList192.Text
                da.SelectCommand.Parameters.Add("@sensacioneslipotimia", SqlDbType.VarChar).Value = TextBox203.Text
            End If
            If DropDownList108.Text = "No" Then
                da.SelectCommand.Parameters.Add("@mejorosincope", SqlDbType.VarChar).Value = ""
                da.SelectCommand.Parameters.Add("@sensacionessincope", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@mejorosincope", SqlDbType.VarChar).Value = DropDownList193.Text
                da.SelectCommand.Parameters.Add("@sensacionessincope", SqlDbType.VarChar).Value = TextBox204.Text
            End If
            If DropDownList109.Text = "No" Then
                da.SelectCommand.Parameters.Add("@mejorofatiga", SqlDbType.VarChar).Value = ""
                da.SelectCommand.Parameters.Add("@sensacionesfatiga", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@mejorofatiga", SqlDbType.VarChar).Value = DropDownList194.Text
                da.SelectCommand.Parameters.Add("@sensacionesfatiga", SqlDbType.VarChar).Value = TextBox205.Text
            End If
            If DropDownList110.Text = "No" Then
                da.SelectCommand.Parameters.Add("@mejoropalpitaciones", SqlDbType.VarChar).Value = ""
                da.SelectCommand.Parameters.Add("@sensacionespalpitaciones", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@mejoropalpitaciones", SqlDbType.VarChar).Value = DropDownList195.Text
                da.SelectCommand.Parameters.Add("@sensacionespalpitaciones", SqlDbType.VarChar).Value = TextBox206.Text
            End If
            If DropDownList111.Text = "No" Then
                da.SelectCommand.Parameters.Add("@mejorodolprecordial", SqlDbType.VarChar).Value = ""
                da.SelectCommand.Parameters.Add("@sensacionesdolprecordial", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@mejorodolprecordial", SqlDbType.VarChar).Value = DropDownList196.Text
                da.SelectCommand.Parameters.Add("@sensacionesdolprecordial", SqlDbType.VarChar).Value = TextBox207.Text
            End If
            If DropDownList112.Text = "No" Then
                da.SelectCommand.Parameters.Add("@mejoroedema", SqlDbType.VarChar).Value = ""
                da.SelectCommand.Parameters.Add("@sensacionesedema", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@mejoroedema", SqlDbType.VarChar).Value = DropDownList197.Text
                da.SelectCommand.Parameters.Add("@sensacionesedema", SqlDbType.VarChar).Value = TextBox208.Text
            End If
            If DropDownList113.Text = "No" Then
                da.SelectCommand.Parameters.Add("@mejorodisnea", SqlDbType.VarChar).Value = ""
                da.SelectCommand.Parameters.Add("@sensacionesdisnea", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@mejorodisnea", SqlDbType.VarChar).Value = DropDownList198.Text
                da.SelectCommand.Parameters.Add("@sensacionesdisnea", SqlDbType.VarChar).Value = TextBox209.Text
            End If
            If DropDownList114.Text = "No" Then
                da.SelectCommand.Parameters.Add("@mejoroascitis", SqlDbType.VarChar).Value = ""
                da.SelectCommand.Parameters.Add("@sensacionesascitis", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@mejoroascitis", SqlDbType.VarChar).Value = DropDownList199.Text
                da.SelectCommand.Parameters.Add("@sensacionesascitis", SqlDbType.VarChar).Value = TextBox210.Text
            End If
            da.SelectCommand.Parameters.Add("@disuria", SqlDbType.VarChar).Value = DropDownList138.Text
            da.SelectCommand.Parameters.Add("@poliaquiuria", SqlDbType.VarChar).Value = DropDownList139.Text
            da.SelectCommand.Parameters.Add("@tenesmo", SqlDbType.VarChar).Value = DropDownList140.Text
            da.SelectCommand.Parameters.Add("@hematuria", SqlDbType.VarChar).Value = DropDownList141.Text
            da.SelectCommand.Parameters.Add("@suprapubica", SqlDbType.VarChar).Value = DropDownList142.Text
            da.SelectCommand.Parameters.Add("@lumbar", SqlDbType.VarChar).Value = DropDownList143.Text
            da.SelectCommand.Parameters.Add("@ninguno", SqlDbType.VarChar).Value = DropDownList144.Text
            da.SelectCommand.Parameters.Add("@otrosdolores", SqlDbType.VarChar).Value = TextBox131.Text
            da.SelectCommand.Parameters.Add("@tendenciahemorragia", SqlDbType.VarChar).Value = DropDownList145.Text
            da.SelectCommand.Parameters.Add("@adenopatias", SqlDbType.VarChar).Value = DropDownList146.Text
            da.SelectCommand.Parameters.Add("@infecrecurrentes", SqlDbType.VarChar).Value = DropDownList147.Text
            da.SelectCommand.Parameters.Add("@anemia", SqlDbType.VarChar).Value = DropDownList148.Text
            da.SelectCommand.Parameters.Add("@hemolinfaticonegado", SqlDbType.VarChar).Value = DropDownList149.Text
            da.SelectCommand.Parameters.Add("@otroshemolinf", SqlDbType.VarChar).Value = TextBox132.Text
            da.SelectCommand.Parameters.Add("@paralisis", SqlDbType.VarChar).Value = DropDownList150.Text
            da.SelectCommand.Parameters.Add("@parestesisas", SqlDbType.VarChar).Value = DropDownList151.Text
            da.SelectCommand.Parameters.Add("@temblores", SqlDbType.VarChar).Value = DropDownList152.Text
            da.SelectCommand.Parameters.Add("@alteracionesmarcha", SqlDbType.VarChar).Value = DropDownList153.Text
            da.SelectCommand.Parameters.Add("@cefalea", SqlDbType.VarChar).Value = DropDownList154.Text
            da.SelectCommand.Parameters.Add("@sisnerviosonegado", SqlDbType.VarChar).Value = DropDownList155.Text
            da.SelectCommand.Parameters.Add("@otrossisnerv", SqlDbType.VarChar).Value = TextBox133.Text
            da.SelectCommand.Parameters.Add("@padactual", SqlDbType.VarChar).Value = TextBox1.Text
            da.SelectCommand.Parameters.Add("@motivoconsulta", SqlDbType.VarChar).Value = TextBox12.Text
            da.SelectCommand.Parameters.Add("@region", SqlDbType.VarChar).Value = TextBox13.Text
            da.SelectCommand.Parameters.Add("@inicia", SqlDbType.VarChar).Value = TextBox14.Text
            da.SelectCommand.Parameters.Add("@irradiacion", SqlDbType.VarChar).Value = TextBox15.Text
            da.SelectCommand.Parameters.Add("@migracion", SqlDbType.VarChar).Value = TextBox16.Text
            da.SelectCommand.Parameters.Add("@expansion", SqlDbType.VarChar).Value = TextBox17.Text
            da.SelectCommand.Parameters.Add("@proyeccion", SqlDbType.VarChar).Value = TextBox18.Text
            da.SelectCommand.Parameters.Add("@semejanzacualitativos", SqlDbType.VarChar).Value = TextBox19.Text
            If DropDownList1.Text = "--Seleccionar--" Then
                da.SelectCommand.Parameters.Add("@localizacioncualitativos", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@localizacioncualitativos", SqlDbType.VarChar).Value = DropDownList1.Text
            End If
            da.SelectCommand.Parameters.Add("@intensidadcuantitativos", SqlDbType.VarChar).Value = TextBox20.Text
            da.SelectCommand.Parameters.Add("@maximaintensidadcuantitativos", SqlDbType.VarChar).Value = TextBox21.Text
            da.SelectCommand.Parameters.Add("@intensidadultimoevento", SqlDbType.VarChar).Value = TextBox22.Text
            da.SelectCommand.Parameters.Add("@iniciocronologicos", SqlDbType.VarChar).Value = TextBox23.Text
            If DropDownList2.Text = "--Seleccionar--" Then
                da.SelectCommand.Parameters.Add("@patroncronologicos", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@patroncronologicos", SqlDbType.VarChar).Value = DropDownList2.Text
            End If

            da.SelectCommand.Parameters.Add("@duracion", SqlDbType.VarChar).Value = TextBox24.Text
            da.SelectCommand.Parameters.Add("@frecuenciadia", SqlDbType.VarChar).Value = TextBox25.Text
            da.SelectCommand.Parameters.Add("@frecuenciamensual", SqlDbType.VarChar).Value = TextBox26.Text
            da.SelectCommand.Parameters.Add("@ultimoevento", SqlDbType.VarChar).Value = TextBox27.Text
            If DropDownList3.Text = "--Seleccionar--" Then
                da.SelectCommand.Parameters.Add("@patrondia", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@patrondia", SqlDbType.VarChar).Value = DropDownList3.Text
            End If
            If DropDownList4.Text = "--Seleccionar--" Then
                da.SelectCommand.Parameters.Add("@patronayuno", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@patronayuno", SqlDbType.VarChar).Value = DropDownList4.Text
            End If
            If DropDownList5.Text = "--Seleccionar--" Then
                da.SelectCommand.Parameters.Add("@patronevacuaciones", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@patronevacuaciones", SqlDbType.VarChar).Value = DropDownList5.Text
            End If

            da.SelectCommand.Parameters.Add("@patronevacuaciones2", SqlDbType.VarChar).Value = TextBox28.Text
            da.SelectCommand.Parameters.Add("@patrongases", SqlDbType.VarChar).Value = TextBox29.Text
            da.SelectCommand.Parameters.Add("@patronvomito", SqlDbType.VarChar).Value = TextBox30.Text
            da.SelectCommand.Parameters.Add("@aumentaintesidad", SqlDbType.VarChar).Value = TextBox33.Text
            da.SelectCommand.Parameters.Add("@disminuyeintensidad", SqlDbType.VarChar).Value = TextBox33.Text
            da.SelectCommand.Parameters.Add("@alimdisminuyen", SqlDbType.VarChar).Value = TextBox35.Text
            If DropDownList7.Text = "--Seleccionar--" Then
                da.SelectCommand.Parameters.Add("@evacuaciones", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@evacuaciones", SqlDbType.VarChar).Value = DropDownList7.Text
            End If
            If DropDownList8.Text = "--Seleccionar--" Then
                da.SelectCommand.Parameters.Add("@canalizacionesgases", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@canalizacionesgases", SqlDbType.VarChar).Value = DropDownList8.Text
            End If
            If DropDownList9.Text = "-Seleccionar--" Then
                da.SelectCommand.Parameters.Add("@eructos", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@eructos", SqlDbType.VarChar).Value = DropDownList9.Text
            End If

            da.SelectCommand.Parameters.Add("@medicamcalman", SqlDbType.VarChar).Value = TextBox32.Text
            da.SelectCommand.Parameters.Add("@medicamnocontrolan", SqlDbType.VarChar).Value = TextBox31.Text
            da.SelectCommand.Parameters.Add("@sintomaocasional1", SqlDbType.VarChar).Value = TextBox36.Text
            da.SelectCommand.Parameters.Add("@sintomaocasional2", SqlDbType.VarChar).Value = TextBox37.Text
            da.SelectCommand.Parameters.Add("@sintomaocasional3", SqlDbType.VarChar).Value = TextBox38.Text
            da.SelectCommand.Parameters.Add("@sintomaocasional4", SqlDbType.VarChar).Value = TextBox39.Text
            da.SelectCommand.Parameters.Add("@sintomasiempre1", SqlDbType.VarChar).Value = TextBox40.Text
            da.SelectCommand.Parameters.Add("@sintomasiempre2", SqlDbType.VarChar).Value = TextBox41.Text
            da.SelectCommand.Parameters.Add("@sintomasiempre3", SqlDbType.VarChar).Value = TextBox42.Text
            da.SelectCommand.Parameters.Add("@sintomasiempre4", SqlDbType.VarChar).Value = TextBox43.Text
            da.SelectCommand.Parameters.Add("@sintomanodolor", SqlDbType.VarChar).Value = TextBox44.Text
            da.SelectCommand.Parameters.Add("@inicionodolor", SqlDbType.VarChar).Value = TextBox2.Text
            If DropDownList6.Text = "--Seleccionar--" Then
                da.SelectCommand.Parameters.Add("@patronnodolor", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@patronnodolor", SqlDbType.VarChar).Value = DropDownList6.Text
            End If
            da.SelectCommand.Parameters.Add("@duracionnodolor", SqlDbType.VarChar).Value = TextBox3.Text
            da.SelectCommand.Parameters.Add("@frecuenciadianodolor", SqlDbType.VarChar).Value = TextBox4.Text
            da.SelectCommand.Parameters.Add("@frecuenciamesnodolor", SqlDbType.VarChar).Value = TextBox5.Text
            da.SelectCommand.Parameters.Add("@ulteventonodolor", SqlDbType.VarChar).Value = TextBox6.Text
            If DropDownList10.Text = "--Seleccionar--" Then
                da.SelectCommand.Parameters.Add("@patrondianodolor", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@patrondianodolor", SqlDbType.VarChar).Value = DropDownList10.Text
            End If
            If DropDownList11.Text = "--Seleccionar--" Then
                da.SelectCommand.Parameters.Add("@patronayunonodolor", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@patronayunonodolor", SqlDbType.VarChar).Value = DropDownList11.Text
            End If
            If DropDownList12.Text = "--Seleccionar--" Then
                da.SelectCommand.Parameters.Add("@patronevacnodolor", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@patronevacnodolor", SqlDbType.VarChar).Value = DropDownList12.Text
            End If
            da.SelectCommand.Parameters.Add("@patrongasesnodolor", SqlDbType.VarChar).Value = TextBox46.Text
            da.SelectCommand.Parameters.Add("@patronvomitonodolor", SqlDbType.VarChar).Value = TextBox45.Text
            da.SelectCommand.Parameters.Add("@aumentaintensnodolor", SqlDbType.VarChar).Value = TextBox47.Text
            da.SelectCommand.Parameters.Add("@disminuyeintensnodolor", SqlDbType.VarChar).Value = TextBox48.Text
            da.SelectCommand.Parameters.Add("@alimprovocannodolor", SqlDbType.VarChar).Value = TextBox49.Text
            da.SelectCommand.Parameters.Add("@alimdisminuyennodolor", SqlDbType.VarChar).Value = TextBox50.Text
            If DropDownList13.Text = "--Seleccionar--" Then
                da.SelectCommand.Parameters.Add("@evacnodolor", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@evacnodolor", SqlDbType.VarChar).Value = DropDownList13.Text
            End If
            If DropDownList14.Text = "--Seleccionar--" Then
                da.SelectCommand.Parameters.Add("@canalizgasesnodolor", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@canalizgasesnodolor", SqlDbType.VarChar).Value = DropDownList14.Text
            End If
            If DropDownList15.Text = "--Seleccionar--" Then
                da.SelectCommand.Parameters.Add("@eructosnodolor", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@eructosnodolor", SqlDbType.VarChar).Value = DropDownList15.Text
            End If
            da.SelectCommand.Parameters.Add("@medicamcalmannodolor", SqlDbType.VarChar).Value = TextBox51.Text
            da.SelectCommand.Parameters.Add("@mednocontrolannodolor", SqlDbType.VarChar).Value = TextBox52.Text
            da.SelectCommand.Parameters.Add("@peso", SqlDbType.VarChar).Value = TextBox53.Text
            da.SelectCommand.Parameters.Add("@talla", SqlDbType.VarChar).Value = TextBox54.Text
            da.SelectCommand.Parameters.Add("@temp", SqlDbType.VarChar).Value = TextBox55.Text
            da.SelectCommand.Parameters.Add("@ta", SqlDbType.VarChar).Value = TextBox56.Text
            da.SelectCommand.Parameters.Add("@tc", SqlDbType.VarChar).Value = TextBox57.Text
            da.SelectCommand.Parameters.Add("@fr", SqlDbType.VarChar).Value = TextBox58.Text
            da.SelectCommand.Parameters.Add("@cabeza", SqlDbType.VarChar).Value = TextBox59.Text
            da.SelectCommand.Parameters.Add("@torax", SqlDbType.VarChar).Value = TextBox60.Text
            da.SelectCommand.Parameters.Add("@abdomen", SqlDbType.VarChar).Value = TextBox61.Text
            da.SelectCommand.Parameters.Add("@extremidades", SqlDbType.VarChar).Value = TextBox62.Text
            da.SelectCommand.Parameters.Add("@estudios", SqlDbType.VarChar).Value = TextBox63.Text
            da.SelectCommand.Parameters.Add("@regionanalisis", SqlDbType.VarChar).Value = DropDownList20.Text
            For Each li As ListItem In CheckBoxList2.Items
                If li.Selected Then
                    If sintanalisis2.Length = 0 Then
                        sintanalisis2 = li.Value
                    Else
                        sintanalisis2 += ", " + li.Value
                    End If
                End If
            Next
            If TextBox103.Text <> "" Then
                sintanalisis2 += ", " + TextBox103.Text
            End If
            da.SelectCommand.Parameters.Add("@sintomaanalisis", SqlDbType.VarChar).Value = sintanalisis2
            If TextBox68.Visible = True Then
                da.SelectCommand.Parameters.Add("@sindromeclin", SqlDbType.VarChar).Value = TextBox68.Text
            Else
                da.SelectCommand.Parameters.Add("@sindromeclin", SqlDbType.VarChar).Value = DropDownList22.Text
            End If
            If TextBox69.Visible = True Then
                da.SelectCommand.Parameters.Add("@subtipoanalisis", SqlDbType.VarChar).Value = TextBox69.Text
            Else
                da.SelectCommand.Parameters.Add("@subtipoanalisis", SqlDbType.VarChar).Value = DropDownList23.Text
            End If
            da.SelectCommand.Parameters.Add("@analisis", SqlDbType.VarChar).Value = TextBox100.Text
            da.SelectCommand.Parameters.Add("@diagnostico", SqlDbType.VarChar).Value = TextBox7.Text
            da.SelectCommand.Parameters.Add("@indicgrales", SqlDbType.VarChar).Value = TextBox114.Text
            da.SelectCommand.Parameters.Add("@estudiosgrales", SqlDbType.VarChar).Value = TextBox79.Text
            da.SelectCommand.Parameters.Add("@tratamiento", SqlDbType.VarChar).Value = TextBox82.Text
            da.SelectCommand.Parameters.Add("@medico", SqlDbType.VarChar).Value = Label8.Text

            da.SelectCommand.ExecuteNonQuery()
            con.Close()


        Catch ex As Exception

        End Try
            End If

            If DropDownList24.Text <> "--Seleccionar--" Then


                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    da = New SqlDataAdapter("modificagastro", con)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.SelectCommand.Parameters.Add("@folionota", SqlDbType.Int).Value = Session("numnota2")
                    da.SelectCommand.Parameters.Add("@pacienteid", SqlDbType.Int).Value = Session("Paciente")
                    da.SelectCommand.Parameters.Add("@fechamodif", SqlDbType.DateTime).Value = Label2.Text
                    da.SelectCommand.Parameters.Add("@genero", SqlDbType.VarChar).Value = DropDownList200.Text
                    da.SelectCommand.Parameters.Add("@diarrea", SqlDbType.VarChar).Value = DropDownList17.Text
                    da.SelectCommand.Parameters.Add("@hernias", SqlDbType.VarChar).Value = DropDownList21.Text
                    da.SelectCommand.Parameters.Add("@cancer", SqlDbType.VarChar).Value = DropDownList25.Text
                    da.SelectCommand.Parameters.Add("@estrenimiento", SqlDbType.VarChar).Value = DropDownList29.Text
                    da.SelectCommand.Parameters.Add("@cancerdigestivo", SqlDbType.VarChar).Value = DropDownList33.Text
                    da.SelectCommand.Parameters.Add("@colecistitis", SqlDbType.VarChar).Value = DropDownList37.Text
                    da.SelectCommand.Parameters.Add("@hipertension", SqlDbType.VarChar).Value = DropDownList41.Text
                    da.SelectCommand.Parameters.Add("@cardiopatia", SqlDbType.VarChar).Value = DropDownList45.Text
                    da.SelectCommand.Parameters.Add("@autoinmunes", SqlDbType.VarChar).Value = DropDownList49.Text
                    da.SelectCommand.Parameters.Add("@diabetes", SqlDbType.VarChar).Value = DropDownList53.Text
                    da.SelectCommand.Parameters.Add("@endocrinopatias", SqlDbType.VarChar).Value = DropDownList57.Text
                    da.SelectCommand.Parameters.Add("@otrosenf", SqlDbType.VarChar).Value = TextBox85.Text
                    da.SelectCommand.Parameters.Add("@otrosfam", SqlDbType.VarChar).Value = DropDownList168.Text
                    da.SelectCommand.Parameters.Add("@ocupacion", SqlDbType.VarChar).Value = TextBox91.Text
                    da.SelectCommand.Parameters.Add("@escolaridad", SqlDbType.VarChar).Value = DropDownList61.Text
                    da.SelectCommand.Parameters.Add("@actfis", SqlDbType.VarChar).Value = DropDownList64.Text
                    If DropDownList65.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@alergicos", SqlDbType.VarChar).Value = DropDownList65.Text
                    Else
                        da.SelectCommand.Parameters.Add("@alergicos", SqlDbType.VarChar).Value = TextBox94.Text
                    End If

                    da.SelectCommand.Parameters.Add("@cirugias", SqlDbType.VarChar).Value = TextBox97.Text
                    da.SelectCommand.Parameters.Add("@complicacionescirugias", SqlDbType.VarChar).Value = TextBox115.Text
                    If DropDownList66.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@transfusiones", SqlDbType.VarChar).Value = DropDownList66.Text
                    Else
                        da.SelectCommand.Parameters.Add("@transfusiones", SqlDbType.VarChar).Value = TextBox116.Text
                    End If
                    da.SelectCommand.Parameters.Add("@tiposangre", SqlDbType.VarChar).Value = DropDownList67.Text
                    If DropDownList68.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@fracturas", SqlDbType.VarChar).Value = DropDownList68.Text
                    Else
                        da.SelectCommand.Parameters.Add("@fracturas", SqlDbType.VarChar).Value = TextBox117.Text
                    End If
                    If DropDownList69.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@hospprevias", SqlDbType.VarChar).Value = DropDownList69.Text
                    Else
                        da.SelectCommand.Parameters.Add("@hospprevias", SqlDbType.VarChar).Value = TextBox118.Text
                    End If
                    If DropDownList169.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempohipertension", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientohipertension", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempohipertension", SqlDbType.VarChar).Value = TextBox148.Text
                        da.SelectCommand.Parameters.Add("@tratamientohipertension", SqlDbType.VarChar).Value = TextBox149.Text
                    End If
                    If DropDownList170.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoinsuficiencia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoinsuficiencia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoinsuficiencia", SqlDbType.VarChar).Value = TextBox150.Text
                        da.SelectCommand.Parameters.Add("@tratamientoinsuficiencia", SqlDbType.VarChar).Value = TextBox151.Text
                    End If
                    If DropDownList171.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempocardisq", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientocardisq", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempocardisq", SqlDbType.VarChar).Value = TextBox152.Text
                        da.SelectCommand.Parameters.Add("@tratamientocardisq", SqlDbType.VarChar).Value = TextBox153.Text
                    End If
                    If DropDownList172.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoevc", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoevc", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoevc", SqlDbType.VarChar).Value = TextBox154.Text
                        da.SelectCommand.Parameters.Add("@tratamientoevc", SqlDbType.VarChar).Value = TextBox155.Text
                    End If
                    If DropDownList173.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoinsufvenosa", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoinsufvenosa", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoinsufvenosa", SqlDbType.VarChar).Value = TextBox156.Text
                        da.SelectCommand.Parameters.Add("@tratamientoinsufvenosa", SqlDbType.VarChar).Value = TextBox157.Text
                    End If
                    If DropDownList174.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodiabetes", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientodiabetes", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodiabetes", SqlDbType.VarChar).Value = TextBox158.Text
                        da.SelectCommand.Parameters.Add("@tratamientodiabetes", SqlDbType.VarChar).Value = TextBox159.Text
                    End If
                    If DropDownList175.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodislipidemmia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientodislipidemmia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodislipidemmia", SqlDbType.VarChar).Value = TextBox160.Text
                        da.SelectCommand.Parameters.Add("@tratamientodislipidemmia", SqlDbType.VarChar).Value = TextBox161.Text
                    End If
                    If DropDownList176.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoobesidad", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoobesidad", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoobesidad", SqlDbType.VarChar).Value = TextBox162.Text
                        da.SelectCommand.Parameters.Add("@tratamientoobesidad", SqlDbType.VarChar).Value = TextBox163.Text
                    End If
                    If DropDownList177.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoenftiroidea", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoenftiroidea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoenftiroidea", SqlDbType.VarChar).Value = TextBox164.Text
                        da.SelectCommand.Parameters.Add("@tratamientoenftiroidea", SqlDbType.VarChar).Value = TextBox165.Text
                    End If
                    If DropDownList178.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempocancer", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientocancer", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempocancer", SqlDbType.VarChar).Value = TextBox166.Text
                        da.SelectCommand.Parameters.Add("@tratamientocancer", SqlDbType.VarChar).Value = TextBox167.Text
                    End If
                    If DropDownList179.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempotuberculosis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientotuberculosis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempotuberculosis", SqlDbType.VarChar).Value = TextBox168.Text
                        da.SelectCommand.Parameters.Add("@tratamientotuberculosis", SqlDbType.VarChar).Value = TextBox169.Text
                    End If
                    If DropDownList180.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoasma", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoasma", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoasma", SqlDbType.VarChar).Value = TextBox170.Text
                        da.SelectCommand.Parameters.Add("@tratamientoasma", SqlDbType.VarChar).Value = TextBox171.Text
                    End If
                    If DropDownList181.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoepoc", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoepoc", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoepoc", SqlDbType.VarChar).Value = TextBox172.Text
                        da.SelectCommand.Parameters.Add("@tratamientoepoc", SqlDbType.VarChar).Value = TextBox173.Text
                    End If
                    If DropDownList182.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempobronquitis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientobronquitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempobronquitis", SqlDbType.VarChar).Value = TextBox174.Text
                        da.SelectCommand.Parameters.Add("@tratamientobronquitis", SqlDbType.VarChar).Value = TextBox175.Text
                    End If
                    If TextBox176.Text = "" Then
                        da.SelectCommand.Parameters.Add("@otraenf", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tiempootraenf", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientootraenf", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@otraenf", SqlDbType.VarChar).Value = TextBox176.Text
                        da.SelectCommand.Parameters.Add("@tiempootraenf", SqlDbType.VarChar).Value = TextBox177.Text
                        da.SelectCommand.Parameters.Add("@tratamientootraenf", SqlDbType.VarChar).Value = TextBox178.Text
                    End If
                    If DropDownList84.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoalcoholismo", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantalcoholismo", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoalcoholismo", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@cantalcoholismo", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If DropDownList85.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempotabaquismo", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@canttabaquismo", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempotabaquismo", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@canttabaquismo", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If DropDownList86.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodrogas", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantdrogas", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodrogas", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@cantdrogas", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If TextBox185.Text = "" Then
                        da.SelectCommand.Parameters.Add("@otrotox", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tiempootrotox", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantotrotox", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@otrotox", SqlDbType.VarChar).Value = TextBox185.Text
                        da.SelectCommand.Parameters.Add("@tiempootrotox", SqlDbType.VarChar).Value = TextBox186.Text
                        da.SelectCommand.Parameters.Add("@cantotrotox", SqlDbType.VarChar).Value = TextBox187.Text
                    End If
                        da.SelectCommand.Parameters.Add("@ultregla", SqlDbType.Date).Value = DBNull.Value
                    
                    da.SelectCommand.Parameters.Add("@ritmo", SqlDbType.VarChar).Value = TextBox124.Text
                    da.SelectCommand.Parameters.Add("@menopausia", SqlDbType.VarChar).Value = DropDownList87.Text
                    da.SelectCommand.Parameters.Add("@gesta", SqlDbType.Int).Value = DropDownList88.Text
                    da.SelectCommand.Parameters.Add("@para", SqlDbType.Int).Value = DropDownList89.Text
                    da.SelectCommand.Parameters.Add("@cesarea", SqlDbType.Int).Value = DropDownList90.Text
                    da.SelectCommand.Parameters.Add("@aborto", SqlDbType.Int).Value = DropDownList91.Text
                    da.SelectCommand.Parameters.Add("@metplanfam", SqlDbType.VarChar).Value = DropDownList92.Text
                    da.SelectCommand.Parameters.Add("@otroplanfam", SqlDbType.VarChar).Value = TextBox125.Text
                    If DropDownList93.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempofiebre", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionfiebre", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempofiebre", SqlDbType.VarChar).Value = TextBox188.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionfiebre", SqlDbType.VarChar).Value = TextBox189.Text
                    End If
                    If DropDownList94.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoastenia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionastenia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoastenia", SqlDbType.VarChar).Value = TextBox191.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionastenia", SqlDbType.VarChar).Value = TextBox192.Text
                    End If
                    If DropDownList95.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoadinamia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionadinamia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoadinamia", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionadinamia", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList96.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoanorexia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionanorexia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoanorexia", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionanorexia", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList97.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoperdidapeso", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionperdidapeso", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoperdidapeso", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionperdidapeso", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList98.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@obstruccionnasal", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@obstruccionnasal", SqlDbType.VarChar).Value = DropDownList183.Text
                    End If
                    If DropDownList99.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@ronqueramatutina", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@ronqueramatutina", SqlDbType.VarChar).Value = DropDownList184.Text
                    End If
                    If DropDownList100.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@sinusitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@sinusitis", SqlDbType.VarChar).Value = DropDownList185.Text
                    End If
                    If DropDownList101.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@disfonia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@disfonia", SqlDbType.VarChar).Value = DropDownList186.Text
                    End If
                    If DropDownList102.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@disnea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@disnea", SqlDbType.VarChar).Value = DropDownList187.Text
                    End If
                    If DropDownList103.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@sibilancias", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@sibilancias", SqlDbType.VarChar).Value = DropDownList188.Text
                    End If
                    If DropDownList104.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tos", SqlDbType.VarChar).Value = DropDownList189.Text
                    End If
                    If DropDownList105.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@cianosis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@cianosis", SqlDbType.VarChar).Value = DropDownList190.Text
                    End If
                    If DropDownList106.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@asma", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@asma", SqlDbType.VarChar).Value = DropDownList191.Text
                    End If
                    If DropDownList107.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorolipotimia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacioneslipotimia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorolipotimia", SqlDbType.VarChar).Value = DropDownList192.Text
                        da.SelectCommand.Parameters.Add("@sensacioneslipotimia", SqlDbType.VarChar).Value = TextBox203.Text
                    End If
                    If DropDownList108.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorosincope", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionessincope", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorosincope", SqlDbType.VarChar).Value = DropDownList193.Text
                        da.SelectCommand.Parameters.Add("@sensacionessincope", SqlDbType.VarChar).Value = TextBox204.Text
                    End If
                    If DropDownList109.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorofatiga", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesfatiga", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorofatiga", SqlDbType.VarChar).Value = DropDownList194.Text
                        da.SelectCommand.Parameters.Add("@sensacionesfatiga", SqlDbType.VarChar).Value = TextBox205.Text
                    End If
                    If DropDownList110.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoropalpitaciones", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionespalpitaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoropalpitaciones", SqlDbType.VarChar).Value = DropDownList195.Text
                        da.SelectCommand.Parameters.Add("@sensacionespalpitaciones", SqlDbType.VarChar).Value = TextBox206.Text
                    End If
                    If DropDownList111.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorodolprecordial", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesdolprecordial", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorodolprecordial", SqlDbType.VarChar).Value = DropDownList196.Text
                        da.SelectCommand.Parameters.Add("@sensacionesdolprecordial", SqlDbType.VarChar).Value = TextBox207.Text
                    End If
                    If DropDownList112.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoroedema", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesedema", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoroedema", SqlDbType.VarChar).Value = DropDownList197.Text
                        da.SelectCommand.Parameters.Add("@sensacionesedema", SqlDbType.VarChar).Value = TextBox208.Text
                    End If
                    If DropDownList113.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorodisnea", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesdisnea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorodisnea", SqlDbType.VarChar).Value = DropDownList198.Text
                        da.SelectCommand.Parameters.Add("@sensacionesdisnea", SqlDbType.VarChar).Value = TextBox209.Text
                    End If
                    If DropDownList114.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoroascitis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesascitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoroascitis", SqlDbType.VarChar).Value = DropDownList199.Text
                        da.SelectCommand.Parameters.Add("@sensacionesascitis", SqlDbType.VarChar).Value = TextBox210.Text
                    End If
                    da.SelectCommand.Parameters.Add("@disuria", SqlDbType.VarChar).Value = DropDownList138.Text
                    da.SelectCommand.Parameters.Add("@poliaquiuria", SqlDbType.VarChar).Value = DropDownList139.Text
                    da.SelectCommand.Parameters.Add("@tenesmo", SqlDbType.VarChar).Value = DropDownList140.Text
                    da.SelectCommand.Parameters.Add("@hematuria", SqlDbType.VarChar).Value = DropDownList141.Text
                    da.SelectCommand.Parameters.Add("@suprapubica", SqlDbType.VarChar).Value = DropDownList142.Text
                    da.SelectCommand.Parameters.Add("@lumbar", SqlDbType.VarChar).Value = DropDownList143.Text
                    da.SelectCommand.Parameters.Add("@ninguno", SqlDbType.VarChar).Value = DropDownList144.Text
                    da.SelectCommand.Parameters.Add("@otrosdolores", SqlDbType.VarChar).Value = TextBox131.Text
                    da.SelectCommand.Parameters.Add("@tendenciahemorragia", SqlDbType.VarChar).Value = DropDownList145.Text
                    da.SelectCommand.Parameters.Add("@adenopatias", SqlDbType.VarChar).Value = DropDownList146.Text
                    da.SelectCommand.Parameters.Add("@infecrecurrentes", SqlDbType.VarChar).Value = DropDownList147.Text
                    da.SelectCommand.Parameters.Add("@anemia", SqlDbType.VarChar).Value = DropDownList148.Text
                    da.SelectCommand.Parameters.Add("@hemolinfaticonegado", SqlDbType.VarChar).Value = DropDownList149.Text
                    da.SelectCommand.Parameters.Add("@otroshemolinf", SqlDbType.VarChar).Value = TextBox132.Text
                    da.SelectCommand.Parameters.Add("@paralisis", SqlDbType.VarChar).Value = DropDownList150.Text
                    da.SelectCommand.Parameters.Add("@parestesisas", SqlDbType.VarChar).Value = DropDownList151.Text
                    da.SelectCommand.Parameters.Add("@temblores", SqlDbType.VarChar).Value = DropDownList152.Text
                    da.SelectCommand.Parameters.Add("@alteracionesmarcha", SqlDbType.VarChar).Value = DropDownList153.Text
                    da.SelectCommand.Parameters.Add("@cefalea", SqlDbType.VarChar).Value = DropDownList154.Text
                    da.SelectCommand.Parameters.Add("@sisnerviosonegado", SqlDbType.VarChar).Value = DropDownList155.Text
                    da.SelectCommand.Parameters.Add("@otrossisnerv", SqlDbType.VarChar).Value = TextBox133.Text
                    da.SelectCommand.Parameters.Add("@padactual", SqlDbType.VarChar).Value = TextBox1.Text
                    da.SelectCommand.Parameters.Add("@motivoconsulta", SqlDbType.VarChar).Value = TextBox12.Text
                    da.SelectCommand.Parameters.Add("@region", SqlDbType.VarChar).Value = TextBox13.Text
                    da.SelectCommand.Parameters.Add("@inicia", SqlDbType.VarChar).Value = TextBox14.Text
                    da.SelectCommand.Parameters.Add("@irradiacion", SqlDbType.VarChar).Value = TextBox15.Text
                    da.SelectCommand.Parameters.Add("@migracion", SqlDbType.VarChar).Value = TextBox16.Text
                    da.SelectCommand.Parameters.Add("@expansion", SqlDbType.VarChar).Value = TextBox17.Text
                    da.SelectCommand.Parameters.Add("@proyeccion", SqlDbType.VarChar).Value = TextBox18.Text
                    da.SelectCommand.Parameters.Add("@semejanzacualitativos", SqlDbType.VarChar).Value = TextBox19.Text
                    If DropDownList1.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@localizacioncualitativos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@localizacioncualitativos", SqlDbType.VarChar).Value = DropDownList1.Text
                    End If
                    da.SelectCommand.Parameters.Add("@intensidadcuantitativos", SqlDbType.VarChar).Value = TextBox20.Text
                    da.SelectCommand.Parameters.Add("@maximaintensidadcuantitativos", SqlDbType.VarChar).Value = TextBox21.Text
                    da.SelectCommand.Parameters.Add("@intensidadultimoevento", SqlDbType.VarChar).Value = TextBox22.Text
                    da.SelectCommand.Parameters.Add("@iniciocronologicos", SqlDbType.VarChar).Value = TextBox23.Text
                    If DropDownList2.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patroncronologicos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patroncronologicos", SqlDbType.VarChar).Value = DropDownList2.Text
                    End If
                    da.SelectCommand.Parameters.Add("@duracion", SqlDbType.VarChar).Value = TextBox24.Text
                    da.SelectCommand.Parameters.Add("@frecuenciadia", SqlDbType.VarChar).Value = TextBox25.Text
                    da.SelectCommand.Parameters.Add("@frecuenciamensual", SqlDbType.VarChar).Value = TextBox26.Text
                    da.SelectCommand.Parameters.Add("@ultimoevento", SqlDbType.VarChar).Value = TextBox27.Text
                    If DropDownList3.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patrondia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patrondia", SqlDbType.VarChar).Value = DropDownList3.Text
                    End If
                    If DropDownList4.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronayuno", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronayuno", SqlDbType.VarChar).Value = DropDownList4.Text
                    End If
                    If DropDownList5.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronevacuaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronevacuaciones", SqlDbType.VarChar).Value = DropDownList5.Text
                    End If
                    da.SelectCommand.Parameters.Add("@patronevacuaciones2", SqlDbType.VarChar).Value = TextBox28.Text
                    da.SelectCommand.Parameters.Add("@patrongases", SqlDbType.VarChar).Value = TextBox29.Text
                    da.SelectCommand.Parameters.Add("@patronvomito", SqlDbType.VarChar).Value = TextBox30.Text
                    da.SelectCommand.Parameters.Add("@aumentaintesidad", SqlDbType.VarChar).Value = TextBox33.Text
                    da.SelectCommand.Parameters.Add("@disminuyeintensidad", SqlDbType.VarChar).Value = TextBox33.Text
                    da.SelectCommand.Parameters.Add("@alimdisminuyen", SqlDbType.VarChar).Value = TextBox35.Text
                    If DropDownList7.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@evacuaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@evacuaciones", SqlDbType.VarChar).Value = DropDownList7.Text
                    End If
                    If DropDownList8.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@canalizacionesgases", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@canalizacionesgases", SqlDbType.VarChar).Value = DropDownList8.Text
                    End If
                    If DropDownList9.Text = "-Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@eructos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@eructos", SqlDbType.VarChar).Value = DropDownList9.Text
                    End If
                    da.SelectCommand.Parameters.Add("@medicamcalman", SqlDbType.VarChar).Value = TextBox32.Text
                    da.SelectCommand.Parameters.Add("@medicamnocontrolan", SqlDbType.VarChar).Value = TextBox31.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional1", SqlDbType.VarChar).Value = TextBox36.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional2", SqlDbType.VarChar).Value = TextBox37.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional3", SqlDbType.VarChar).Value = TextBox38.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional4", SqlDbType.VarChar).Value = TextBox39.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre1", SqlDbType.VarChar).Value = TextBox40.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre2", SqlDbType.VarChar).Value = TextBox41.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre3", SqlDbType.VarChar).Value = TextBox42.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre4", SqlDbType.VarChar).Value = TextBox43.Text
                    da.SelectCommand.Parameters.Add("@sintomanodolor", SqlDbType.VarChar).Value = TextBox44.Text
                    da.SelectCommand.Parameters.Add("@inicionodolor", SqlDbType.VarChar).Value = TextBox2.Text
                    If DropDownList6.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronnodolor", SqlDbType.VarChar).Value = DropDownList6.Text
                    End If
                    da.SelectCommand.Parameters.Add("@duracionnodolor", SqlDbType.VarChar).Value = TextBox3.Text
                    da.SelectCommand.Parameters.Add("@frecuenciadianodolor", SqlDbType.VarChar).Value = TextBox4.Text
                    da.SelectCommand.Parameters.Add("@frecuenciamesnodolor", SqlDbType.VarChar).Value = TextBox5.Text
                    da.SelectCommand.Parameters.Add("@ulteventonodolor", SqlDbType.VarChar).Value = TextBox6.Text
                    If DropDownList10.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patrondianodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patrondianodolor", SqlDbType.VarChar).Value = DropDownList10.Text
                    End If
                    If DropDownList11.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronayunonodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronayunonodolor", SqlDbType.VarChar).Value = DropDownList11.Text
                    End If
                    If DropDownList12.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronevacnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronevacnodolor", SqlDbType.VarChar).Value = DropDownList12.Text
                    End If
                    da.SelectCommand.Parameters.Add("@patrongasesnodolor", SqlDbType.VarChar).Value = TextBox46.Text
                    da.SelectCommand.Parameters.Add("@patronvomitonodolor", SqlDbType.VarChar).Value = TextBox45.Text
                    da.SelectCommand.Parameters.Add("@aumentaintensnodolor", SqlDbType.VarChar).Value = TextBox47.Text
                    da.SelectCommand.Parameters.Add("@disminuyeintensnodolor", SqlDbType.VarChar).Value = TextBox48.Text
                    da.SelectCommand.Parameters.Add("@alimprovocannodolor", SqlDbType.VarChar).Value = TextBox49.Text
                    da.SelectCommand.Parameters.Add("@alimdisminuyennodolor", SqlDbType.VarChar).Value = TextBox50.Text
                    If DropDownList13.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@evacnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@evacnodolor", SqlDbType.VarChar).Value = DropDownList13.Text
                    End If
                    If DropDownList14.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@canalizgasesnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@canalizgasesnodolor", SqlDbType.VarChar).Value = DropDownList14.Text
                    End If
                    If DropDownList15.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@eructosnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@eructosnodolor", SqlDbType.VarChar).Value = DropDownList15.Text
                    End If
                    da.SelectCommand.Parameters.Add("@medicamcalmannodolor", SqlDbType.VarChar).Value = TextBox51.Text
                    da.SelectCommand.Parameters.Add("@mednocontrolannodolor", SqlDbType.VarChar).Value = TextBox52.Text
                    da.SelectCommand.Parameters.Add("@peso", SqlDbType.VarChar).Value = TextBox53.Text
                    da.SelectCommand.Parameters.Add("@talla", SqlDbType.VarChar).Value = TextBox54.Text
                    da.SelectCommand.Parameters.Add("@temp", SqlDbType.VarChar).Value = TextBox55.Text
                    da.SelectCommand.Parameters.Add("@ta", SqlDbType.VarChar).Value = TextBox56.Text
                    da.SelectCommand.Parameters.Add("@tc", SqlDbType.VarChar).Value = TextBox57.Text
                    da.SelectCommand.Parameters.Add("@fr", SqlDbType.VarChar).Value = TextBox58.Text
                    da.SelectCommand.Parameters.Add("@cabeza", SqlDbType.VarChar).Value = TextBox59.Text
                    da.SelectCommand.Parameters.Add("@torax", SqlDbType.VarChar).Value = TextBox60.Text
                    da.SelectCommand.Parameters.Add("@abdomen", SqlDbType.VarChar).Value = TextBox61.Text
                    da.SelectCommand.Parameters.Add("@extremidades", SqlDbType.VarChar).Value = TextBox62.Text
                    da.SelectCommand.Parameters.Add("@estudios", SqlDbType.VarChar).Value = TextBox63.Text
                    da.SelectCommand.Parameters.Add("@regionanalisis", SqlDbType.VarChar).Value = DropDownList24.Text
                    For Each li As ListItem In CheckBoxList3.Items
                        If li.Selected Then
                            If sintanalisis3.Length = 0 Then
                                sintanalisis3 = li.Value
                            Else
                                sintanalisis3 += ", " + li.Value
                            End If
                        End If
                    Next
                    If TextBox104.Text <> "" Then
                        sintanalisis3 += ", " + TextBox104.Text
                    End If
                    da.SelectCommand.Parameters.Add("@sintomaanalisis", SqlDbType.VarChar).Value = sintanalisis3
                    If TextBox71.Visible = True Then
                        da.SelectCommand.Parameters.Add("@sindromeclin", SqlDbType.VarChar).Value = TextBox71.Text
                    Else
                        da.SelectCommand.Parameters.Add("@sindromeclin", SqlDbType.VarChar).Value = DropDownList26.Text
                    End If
                    If TextBox72.Visible = True Then
                        da.SelectCommand.Parameters.Add("@subtipoanalisis", SqlDbType.VarChar).Value = TextBox72.Text
                    Else
                        da.SelectCommand.Parameters.Add("@subtipoanalisis", SqlDbType.VarChar).Value = DropDownList27.Text
                    End If
                    da.SelectCommand.Parameters.Add("@analisis", SqlDbType.VarChar).Value = TextBox100.Text
                    da.SelectCommand.Parameters.Add("@diagnostico", SqlDbType.VarChar).Value = TextBox7.Text
                    da.SelectCommand.Parameters.Add("@indicgrales", SqlDbType.VarChar).Value = TextBox114.Text
                    da.SelectCommand.Parameters.Add("@estudiosgrales", SqlDbType.VarChar).Value = TextBox79.Text
                    da.SelectCommand.Parameters.Add("@tratamiento", SqlDbType.VarChar).Value = TextBox82.Text
                    da.SelectCommand.Parameters.Add("@medico", SqlDbType.VarChar).Value = Label8.Text

                    da.SelectCommand.ExecuteNonQuery()
                    con.Close()


                Catch ex As Exception

                End Try
            End If

            If DropDownList28.Text <> "--Seleccionar--" Then


                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    da = New SqlDataAdapter("modificagastro", con)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.SelectCommand.Parameters.Add("@folionota", SqlDbType.Int).Value = Session("numnota2")
                    da.SelectCommand.Parameters.Add("@pacienteid", SqlDbType.Int).Value = Session("Paciente")
                    da.SelectCommand.Parameters.Add("@fechamodif", SqlDbType.DateTime).Value = Label2.Text
                    da.SelectCommand.Parameters.Add("@genero", SqlDbType.VarChar).Value = DropDownList200.Text
                    da.SelectCommand.Parameters.Add("@diarrea", SqlDbType.VarChar).Value = DropDownList17.Text
                    da.SelectCommand.Parameters.Add("@hernias", SqlDbType.VarChar).Value = DropDownList21.Text
                    da.SelectCommand.Parameters.Add("@cancer", SqlDbType.VarChar).Value = DropDownList25.Text
                    da.SelectCommand.Parameters.Add("@estrenimiento", SqlDbType.VarChar).Value = DropDownList29.Text
                    da.SelectCommand.Parameters.Add("@cancerdigestivo", SqlDbType.VarChar).Value = DropDownList33.Text
                    da.SelectCommand.Parameters.Add("@colecistitis", SqlDbType.VarChar).Value = DropDownList37.Text
                    da.SelectCommand.Parameters.Add("@hipertension", SqlDbType.VarChar).Value = DropDownList41.Text
                    da.SelectCommand.Parameters.Add("@cardiopatia", SqlDbType.VarChar).Value = DropDownList45.Text
                    da.SelectCommand.Parameters.Add("@autoinmunes", SqlDbType.VarChar).Value = DropDownList49.Text
                    da.SelectCommand.Parameters.Add("@diabetes", SqlDbType.VarChar).Value = DropDownList53.Text
                    da.SelectCommand.Parameters.Add("@endocrinopatias", SqlDbType.VarChar).Value = DropDownList57.Text
                    da.SelectCommand.Parameters.Add("@otrosenf", SqlDbType.VarChar).Value = TextBox85.Text
                    da.SelectCommand.Parameters.Add("@otrosfam", SqlDbType.VarChar).Value = DropDownList168.Text
                    da.SelectCommand.Parameters.Add("@ocupacion", SqlDbType.VarChar).Value = TextBox91.Text
                    da.SelectCommand.Parameters.Add("@escolaridad", SqlDbType.VarChar).Value = DropDownList61.Text
                    da.SelectCommand.Parameters.Add("@actfis", SqlDbType.VarChar).Value = DropDownList64.Text
                    If DropDownList65.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@alergicos", SqlDbType.VarChar).Value = DropDownList65.Text
                    Else
                        da.SelectCommand.Parameters.Add("@alergicos", SqlDbType.VarChar).Value = TextBox94.Text
                    End If

                    da.SelectCommand.Parameters.Add("@cirugias", SqlDbType.VarChar).Value = TextBox97.Text
                    da.SelectCommand.Parameters.Add("@complicacionescirugias", SqlDbType.VarChar).Value = TextBox115.Text
                    If DropDownList66.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@transfusiones", SqlDbType.VarChar).Value = DropDownList66.Text
                    Else
                        da.SelectCommand.Parameters.Add("@transfusiones", SqlDbType.VarChar).Value = TextBox116.Text
                    End If
                    da.SelectCommand.Parameters.Add("@tiposangre", SqlDbType.VarChar).Value = DropDownList67.Text
                    If DropDownList68.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@fracturas", SqlDbType.VarChar).Value = DropDownList68.Text
                    Else
                        da.SelectCommand.Parameters.Add("@fracturas", SqlDbType.VarChar).Value = TextBox117.Text
                    End If
                    If DropDownList69.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@hospprevias", SqlDbType.VarChar).Value = DropDownList69.Text
                    Else
                        da.SelectCommand.Parameters.Add("@hospprevias", SqlDbType.VarChar).Value = TextBox118.Text
                    End If
                    If DropDownList169.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempohipertension", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientohipertension", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempohipertension", SqlDbType.VarChar).Value = TextBox148.Text
                        da.SelectCommand.Parameters.Add("@tratamientohipertension", SqlDbType.VarChar).Value = TextBox149.Text
                    End If
                    If DropDownList170.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoinsuficiencia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoinsuficiencia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoinsuficiencia", SqlDbType.VarChar).Value = TextBox150.Text
                        da.SelectCommand.Parameters.Add("@tratamientoinsuficiencia", SqlDbType.VarChar).Value = TextBox151.Text
                    End If
                    If DropDownList171.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempocardisq", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientocardisq", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempocardisq", SqlDbType.VarChar).Value = TextBox152.Text
                        da.SelectCommand.Parameters.Add("@tratamientocardisq", SqlDbType.VarChar).Value = TextBox153.Text
                    End If
                    If DropDownList172.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoevc", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoevc", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoevc", SqlDbType.VarChar).Value = TextBox154.Text
                        da.SelectCommand.Parameters.Add("@tratamientoevc", SqlDbType.VarChar).Value = TextBox155.Text
                    End If
                    If DropDownList173.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoinsufvenosa", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoinsufvenosa", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoinsufvenosa", SqlDbType.VarChar).Value = TextBox156.Text
                        da.SelectCommand.Parameters.Add("@tratamientoinsufvenosa", SqlDbType.VarChar).Value = TextBox157.Text
                    End If
                    If DropDownList174.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodiabetes", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientodiabetes", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodiabetes", SqlDbType.VarChar).Value = TextBox158.Text
                        da.SelectCommand.Parameters.Add("@tratamientodiabetes", SqlDbType.VarChar).Value = TextBox159.Text
                    End If
                    If DropDownList175.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodislipidemmia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientodislipidemmia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodislipidemmia", SqlDbType.VarChar).Value = TextBox160.Text
                        da.SelectCommand.Parameters.Add("@tratamientodislipidemmia", SqlDbType.VarChar).Value = TextBox161.Text
                    End If
                    If DropDownList176.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoobesidad", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoobesidad", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoobesidad", SqlDbType.VarChar).Value = TextBox162.Text
                        da.SelectCommand.Parameters.Add("@tratamientoobesidad", SqlDbType.VarChar).Value = TextBox163.Text
                    End If
                    If DropDownList177.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoenftiroidea", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoenftiroidea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoenftiroidea", SqlDbType.VarChar).Value = TextBox164.Text
                        da.SelectCommand.Parameters.Add("@tratamientoenftiroidea", SqlDbType.VarChar).Value = TextBox165.Text
                    End If
                    If DropDownList178.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempocancer", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientocancer", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempocancer", SqlDbType.VarChar).Value = TextBox166.Text
                        da.SelectCommand.Parameters.Add("@tratamientocancer", SqlDbType.VarChar).Value = TextBox167.Text
                    End If
                    If DropDownList179.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempotuberculosis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientotuberculosis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempotuberculosis", SqlDbType.VarChar).Value = TextBox168.Text
                        da.SelectCommand.Parameters.Add("@tratamientotuberculosis", SqlDbType.VarChar).Value = TextBox169.Text
                    End If
                    If DropDownList180.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoasma", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoasma", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoasma", SqlDbType.VarChar).Value = TextBox170.Text
                        da.SelectCommand.Parameters.Add("@tratamientoasma", SqlDbType.VarChar).Value = TextBox171.Text
                    End If
                    If DropDownList181.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoepoc", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoepoc", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoepoc", SqlDbType.VarChar).Value = TextBox172.Text
                        da.SelectCommand.Parameters.Add("@tratamientoepoc", SqlDbType.VarChar).Value = TextBox173.Text
                    End If
                    If DropDownList182.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempobronquitis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientobronquitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempobronquitis", SqlDbType.VarChar).Value = TextBox174.Text
                        da.SelectCommand.Parameters.Add("@tratamientobronquitis", SqlDbType.VarChar).Value = TextBox175.Text
                    End If
                    If TextBox176.Text = "" Then
                        da.SelectCommand.Parameters.Add("@otraenf", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tiempootraenf", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientootraenf", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@otraenf", SqlDbType.VarChar).Value = TextBox176.Text
                        da.SelectCommand.Parameters.Add("@tiempootraenf", SqlDbType.VarChar).Value = TextBox177.Text
                        da.SelectCommand.Parameters.Add("@tratamientootraenf", SqlDbType.VarChar).Value = TextBox178.Text
                    End If
                    If DropDownList84.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoalcoholismo", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantalcoholismo", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoalcoholismo", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@cantalcoholismo", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If DropDownList85.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempotabaquismo", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@canttabaquismo", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempotabaquismo", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@canttabaquismo", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If DropDownList86.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodrogas", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantdrogas", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodrogas", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@cantdrogas", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If TextBox185.Text = "" Then
                        da.SelectCommand.Parameters.Add("@otrotox", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tiempootrotox", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantotrotox", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@otrotox", SqlDbType.VarChar).Value = TextBox185.Text
                        da.SelectCommand.Parameters.Add("@tiempootrotox", SqlDbType.VarChar).Value = TextBox186.Text
                        da.SelectCommand.Parameters.Add("@cantotrotox", SqlDbType.VarChar).Value = TextBox187.Text
                    End If
                        da.SelectCommand.Parameters.Add("@ultregla", SqlDbType.Date).Value = DBNull.Value
                   
                    da.SelectCommand.Parameters.Add("@ritmo", SqlDbType.VarChar).Value = TextBox124.Text
                    da.SelectCommand.Parameters.Add("@menopausia", SqlDbType.VarChar).Value = DropDownList87.Text
                    da.SelectCommand.Parameters.Add("@gesta", SqlDbType.Int).Value = DropDownList88.Text
                    da.SelectCommand.Parameters.Add("@para", SqlDbType.Int).Value = DropDownList89.Text
                    da.SelectCommand.Parameters.Add("@cesarea", SqlDbType.Int).Value = DropDownList90.Text
                    da.SelectCommand.Parameters.Add("@aborto", SqlDbType.Int).Value = DropDownList91.Text
                    da.SelectCommand.Parameters.Add("@metplanfam", SqlDbType.VarChar).Value = DropDownList92.Text
                    da.SelectCommand.Parameters.Add("@otroplanfam", SqlDbType.VarChar).Value = TextBox125.Text
                    If DropDownList93.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempofiebre", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionfiebre", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempofiebre", SqlDbType.VarChar).Value = TextBox188.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionfiebre", SqlDbType.VarChar).Value = TextBox189.Text
                    End If
                    If DropDownList94.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoastenia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionastenia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoastenia", SqlDbType.VarChar).Value = TextBox191.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionastenia", SqlDbType.VarChar).Value = TextBox192.Text
                    End If
                    If DropDownList95.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoadinamia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionadinamia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoadinamia", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionadinamia", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList96.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoanorexia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionanorexia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoanorexia", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionanorexia", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList97.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoperdidapeso", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionperdidapeso", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoperdidapeso", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionperdidapeso", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList98.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@obstruccionnasal", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@obstruccionnasal", SqlDbType.VarChar).Value = DropDownList183.Text
                    End If
                    If DropDownList99.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@ronqueramatutina", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@ronqueramatutina", SqlDbType.VarChar).Value = DropDownList184.Text
                    End If
                    If DropDownList100.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@sinusitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@sinusitis", SqlDbType.VarChar).Value = DropDownList185.Text
                    End If
                    If DropDownList101.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@disfonia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@disfonia", SqlDbType.VarChar).Value = DropDownList186.Text
                    End If
                    If DropDownList102.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@disnea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@disnea", SqlDbType.VarChar).Value = DropDownList187.Text
                    End If
                    If DropDownList103.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@sibilancias", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@sibilancias", SqlDbType.VarChar).Value = DropDownList188.Text
                    End If
                    If DropDownList104.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tos", SqlDbType.VarChar).Value = DropDownList189.Text
                    End If
                    If DropDownList105.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@cianosis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@cianosis", SqlDbType.VarChar).Value = DropDownList190.Text
                    End If
                    If DropDownList106.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@asma", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@asma", SqlDbType.VarChar).Value = DropDownList191.Text
                    End If
                    If DropDownList107.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorolipotimia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacioneslipotimia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorolipotimia", SqlDbType.VarChar).Value = DropDownList192.Text
                        da.SelectCommand.Parameters.Add("@sensacioneslipotimia", SqlDbType.VarChar).Value = TextBox203.Text
                    End If
                    If DropDownList108.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorosincope", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionessincope", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorosincope", SqlDbType.VarChar).Value = DropDownList193.Text
                        da.SelectCommand.Parameters.Add("@sensacionessincope", SqlDbType.VarChar).Value = TextBox204.Text
                    End If
                    If DropDownList109.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorofatiga", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesfatiga", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorofatiga", SqlDbType.VarChar).Value = DropDownList194.Text
                        da.SelectCommand.Parameters.Add("@sensacionesfatiga", SqlDbType.VarChar).Value = TextBox205.Text
                    End If
                    If DropDownList110.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoropalpitaciones", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionespalpitaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoropalpitaciones", SqlDbType.VarChar).Value = DropDownList195.Text
                        da.SelectCommand.Parameters.Add("@sensacionespalpitaciones", SqlDbType.VarChar).Value = TextBox206.Text
                    End If
                    If DropDownList111.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorodolprecordial", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesdolprecordial", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorodolprecordial", SqlDbType.VarChar).Value = DropDownList196.Text
                        da.SelectCommand.Parameters.Add("@sensacionesdolprecordial", SqlDbType.VarChar).Value = TextBox207.Text
                    End If
                    If DropDownList112.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoroedema", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesedema", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoroedema", SqlDbType.VarChar).Value = DropDownList197.Text
                        da.SelectCommand.Parameters.Add("@sensacionesedema", SqlDbType.VarChar).Value = TextBox208.Text
                    End If
                    If DropDownList113.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorodisnea", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesdisnea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorodisnea", SqlDbType.VarChar).Value = DropDownList198.Text
                        da.SelectCommand.Parameters.Add("@sensacionesdisnea", SqlDbType.VarChar).Value = TextBox209.Text
                    End If
                    If DropDownList114.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoroascitis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesascitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoroascitis", SqlDbType.VarChar).Value = DropDownList199.Text
                        da.SelectCommand.Parameters.Add("@sensacionesascitis", SqlDbType.VarChar).Value = TextBox210.Text
                    End If
                    da.SelectCommand.Parameters.Add("@disuria", SqlDbType.VarChar).Value = DropDownList138.Text
                    da.SelectCommand.Parameters.Add("@poliaquiuria", SqlDbType.VarChar).Value = DropDownList139.Text
                    da.SelectCommand.Parameters.Add("@tenesmo", SqlDbType.VarChar).Value = DropDownList140.Text
                    da.SelectCommand.Parameters.Add("@hematuria", SqlDbType.VarChar).Value = DropDownList141.Text
                    da.SelectCommand.Parameters.Add("@suprapubica", SqlDbType.VarChar).Value = DropDownList142.Text
                    da.SelectCommand.Parameters.Add("@lumbar", SqlDbType.VarChar).Value = DropDownList143.Text
                    da.SelectCommand.Parameters.Add("@ninguno", SqlDbType.VarChar).Value = DropDownList144.Text
                    da.SelectCommand.Parameters.Add("@otrosdolores", SqlDbType.VarChar).Value = TextBox131.Text
                    da.SelectCommand.Parameters.Add("@tendenciahemorragia", SqlDbType.VarChar).Value = DropDownList145.Text
                    da.SelectCommand.Parameters.Add("@adenopatias", SqlDbType.VarChar).Value = DropDownList146.Text
                    da.SelectCommand.Parameters.Add("@infecrecurrentes", SqlDbType.VarChar).Value = DropDownList147.Text
                    da.SelectCommand.Parameters.Add("@anemia", SqlDbType.VarChar).Value = DropDownList148.Text
                    da.SelectCommand.Parameters.Add("@hemolinfaticonegado", SqlDbType.VarChar).Value = DropDownList149.Text
                    da.SelectCommand.Parameters.Add("@otroshemolinf", SqlDbType.VarChar).Value = TextBox132.Text
                    da.SelectCommand.Parameters.Add("@paralisis", SqlDbType.VarChar).Value = DropDownList150.Text
                    da.SelectCommand.Parameters.Add("@parestesisas", SqlDbType.VarChar).Value = DropDownList151.Text
                    da.SelectCommand.Parameters.Add("@temblores", SqlDbType.VarChar).Value = DropDownList152.Text
                    da.SelectCommand.Parameters.Add("@alteracionesmarcha", SqlDbType.VarChar).Value = DropDownList153.Text
                    da.SelectCommand.Parameters.Add("@cefalea", SqlDbType.VarChar).Value = DropDownList154.Text
                    da.SelectCommand.Parameters.Add("@sisnerviosonegado", SqlDbType.VarChar).Value = DropDownList155.Text
                    da.SelectCommand.Parameters.Add("@otrossisnerv", SqlDbType.VarChar).Value = TextBox133.Text
                    da.SelectCommand.Parameters.Add("@padactual", SqlDbType.VarChar).Value = TextBox1.Text
                    da.SelectCommand.Parameters.Add("@motivoconsulta", SqlDbType.VarChar).Value = TextBox12.Text
                    da.SelectCommand.Parameters.Add("@region", SqlDbType.VarChar).Value = TextBox13.Text
                    da.SelectCommand.Parameters.Add("@inicia", SqlDbType.VarChar).Value = TextBox14.Text
                    da.SelectCommand.Parameters.Add("@irradiacion", SqlDbType.VarChar).Value = TextBox15.Text
                    da.SelectCommand.Parameters.Add("@migracion", SqlDbType.VarChar).Value = TextBox16.Text
                    da.SelectCommand.Parameters.Add("@expansion", SqlDbType.VarChar).Value = TextBox17.Text
                    da.SelectCommand.Parameters.Add("@proyeccion", SqlDbType.VarChar).Value = TextBox18.Text
                    da.SelectCommand.Parameters.Add("@semejanzacualitativos", SqlDbType.VarChar).Value = TextBox19.Text
                    If DropDownList1.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@localizacioncualitativos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@localizacioncualitativos", SqlDbType.VarChar).Value = DropDownList1.Text
                    End If
                    da.SelectCommand.Parameters.Add("@intensidadcuantitativos", SqlDbType.VarChar).Value = TextBox20.Text
                    da.SelectCommand.Parameters.Add("@maximaintensidadcuantitativos", SqlDbType.VarChar).Value = TextBox21.Text
                    da.SelectCommand.Parameters.Add("@intensidadultimoevento", SqlDbType.VarChar).Value = TextBox22.Text
                    da.SelectCommand.Parameters.Add("@iniciocronologicos", SqlDbType.VarChar).Value = TextBox23.Text
                    If DropDownList2.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patroncronologicos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patroncronologicos", SqlDbType.VarChar).Value = DropDownList2.Text
                    End If
                    da.SelectCommand.Parameters.Add("@duracion", SqlDbType.VarChar).Value = TextBox24.Text
                    da.SelectCommand.Parameters.Add("@frecuenciadia", SqlDbType.VarChar).Value = TextBox25.Text
                    da.SelectCommand.Parameters.Add("@frecuenciamensual", SqlDbType.VarChar).Value = TextBox26.Text
                    da.SelectCommand.Parameters.Add("@ultimoevento", SqlDbType.VarChar).Value = TextBox27.Text
                    If DropDownList3.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patrondia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patrondia", SqlDbType.VarChar).Value = DropDownList3.Text
                    End If
                    If DropDownList4.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronayuno", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronayuno", SqlDbType.VarChar).Value = DropDownList4.Text
                    End If
                    If DropDownList5.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronevacuaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronevacuaciones", SqlDbType.VarChar).Value = DropDownList5.Text
                    End If
                    da.SelectCommand.Parameters.Add("@patronevacuaciones2", SqlDbType.VarChar).Value = TextBox28.Text
                    da.SelectCommand.Parameters.Add("@patrongases", SqlDbType.VarChar).Value = TextBox29.Text
                    da.SelectCommand.Parameters.Add("@patronvomito", SqlDbType.VarChar).Value = TextBox30.Text
                    da.SelectCommand.Parameters.Add("@aumentaintesidad", SqlDbType.VarChar).Value = TextBox33.Text
                    da.SelectCommand.Parameters.Add("@disminuyeintensidad", SqlDbType.VarChar).Value = TextBox33.Text
                    da.SelectCommand.Parameters.Add("@alimdisminuyen", SqlDbType.VarChar).Value = TextBox35.Text
                    If DropDownList7.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@evacuaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@evacuaciones", SqlDbType.VarChar).Value = DropDownList7.Text
                    End If
                    If DropDownList8.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@canalizacionesgases", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@canalizacionesgases", SqlDbType.VarChar).Value = DropDownList8.Text
                    End If
                    If DropDownList9.Text = "-Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@eructos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@eructos", SqlDbType.VarChar).Value = DropDownList9.Text
                    End If
                    da.SelectCommand.Parameters.Add("@medicamcalman", SqlDbType.VarChar).Value = TextBox32.Text
                    da.SelectCommand.Parameters.Add("@medicamnocontrolan", SqlDbType.VarChar).Value = TextBox31.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional1", SqlDbType.VarChar).Value = TextBox36.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional2", SqlDbType.VarChar).Value = TextBox37.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional3", SqlDbType.VarChar).Value = TextBox38.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional4", SqlDbType.VarChar).Value = TextBox39.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre1", SqlDbType.VarChar).Value = TextBox40.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre2", SqlDbType.VarChar).Value = TextBox41.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre3", SqlDbType.VarChar).Value = TextBox42.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre4", SqlDbType.VarChar).Value = TextBox43.Text
                    da.SelectCommand.Parameters.Add("@sintomanodolor", SqlDbType.VarChar).Value = TextBox44.Text
                    da.SelectCommand.Parameters.Add("@inicionodolor", SqlDbType.VarChar).Value = TextBox2.Text
                    If DropDownList6.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronnodolor", SqlDbType.VarChar).Value = DropDownList6.Text
                    End If
                    da.SelectCommand.Parameters.Add("@duracionnodolor", SqlDbType.VarChar).Value = TextBox3.Text
                    da.SelectCommand.Parameters.Add("@frecuenciadianodolor", SqlDbType.VarChar).Value = TextBox4.Text
                    da.SelectCommand.Parameters.Add("@frecuenciamesnodolor", SqlDbType.VarChar).Value = TextBox5.Text
                    da.SelectCommand.Parameters.Add("@ulteventonodolor", SqlDbType.VarChar).Value = TextBox6.Text
                    If DropDownList10.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patrondianodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patrondianodolor", SqlDbType.VarChar).Value = DropDownList10.Text
                    End If
                    If DropDownList11.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronayunonodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronayunonodolor", SqlDbType.VarChar).Value = DropDownList11.Text
                    End If
                    If DropDownList12.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronevacnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronevacnodolor", SqlDbType.VarChar).Value = DropDownList12.Text
                    End If
                    da.SelectCommand.Parameters.Add("@patrongasesnodolor", SqlDbType.VarChar).Value = TextBox46.Text
                    da.SelectCommand.Parameters.Add("@patronvomitonodolor", SqlDbType.VarChar).Value = TextBox45.Text
                    da.SelectCommand.Parameters.Add("@aumentaintensnodolor", SqlDbType.VarChar).Value = TextBox47.Text
                    da.SelectCommand.Parameters.Add("@disminuyeintensnodolor", SqlDbType.VarChar).Value = TextBox48.Text
                    da.SelectCommand.Parameters.Add("@alimprovocannodolor", SqlDbType.VarChar).Value = TextBox49.Text
                    da.SelectCommand.Parameters.Add("@alimdisminuyennodolor", SqlDbType.VarChar).Value = TextBox50.Text
                    If DropDownList13.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@evacnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@evacnodolor", SqlDbType.VarChar).Value = DropDownList13.Text
                    End If
                    If DropDownList14.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@canalizgasesnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@canalizgasesnodolor", SqlDbType.VarChar).Value = DropDownList14.Text
                    End If
                    If DropDownList15.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@eructosnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@eructosnodolor", SqlDbType.VarChar).Value = DropDownList15.Text
                    End If
                    da.SelectCommand.Parameters.Add("@medicamcalmannodolor", SqlDbType.VarChar).Value = TextBox51.Text
                    da.SelectCommand.Parameters.Add("@mednocontrolannodolor", SqlDbType.VarChar).Value = TextBox52.Text
                    da.SelectCommand.Parameters.Add("@peso", SqlDbType.VarChar).Value = TextBox53.Text
                    da.SelectCommand.Parameters.Add("@talla", SqlDbType.VarChar).Value = TextBox54.Text
                    da.SelectCommand.Parameters.Add("@temp", SqlDbType.VarChar).Value = TextBox55.Text
                    da.SelectCommand.Parameters.Add("@ta", SqlDbType.VarChar).Value = TextBox56.Text
                    da.SelectCommand.Parameters.Add("@tc", SqlDbType.VarChar).Value = TextBox57.Text
                    da.SelectCommand.Parameters.Add("@fr", SqlDbType.VarChar).Value = TextBox58.Text
                    da.SelectCommand.Parameters.Add("@cabeza", SqlDbType.VarChar).Value = TextBox59.Text
                    da.SelectCommand.Parameters.Add("@torax", SqlDbType.VarChar).Value = TextBox60.Text
                    da.SelectCommand.Parameters.Add("@abdomen", SqlDbType.VarChar).Value = TextBox61.Text
                    da.SelectCommand.Parameters.Add("@extremidades", SqlDbType.VarChar).Value = TextBox62.Text
                    da.SelectCommand.Parameters.Add("@estudios", SqlDbType.VarChar).Value = TextBox63.Text
                    da.SelectCommand.Parameters.Add("@regionanalisis", SqlDbType.VarChar).Value = DropDownList28.Text
                    For Each li As ListItem In CheckBoxList4.Items
                        If li.Selected Then
                            If sintanalisis4.Length = 0 Then
                                sintanalisis4 = li.Value
                            Else
                                sintanalisis4 += ", " + li.Value
                            End If
                        End If
                    Next
                    If TextBox105.Text <> "" Then
                        sintanalisis4 += ", " + TextBox105.Text
                    End If
                    da.SelectCommand.Parameters.Add("@sintomaanalisis", SqlDbType.VarChar).Value = sintanalisis4
                    If TextBox74.Visible = True Then
                        da.SelectCommand.Parameters.Add("@sindromeclin", SqlDbType.VarChar).Value = TextBox74.Text
                    Else
                        da.SelectCommand.Parameters.Add("@sindromeclin", SqlDbType.VarChar).Value = DropDownList30.Text
                    End If
                    If TextBox75.Visible = True Then
                        da.SelectCommand.Parameters.Add("@subtipoanalisis", SqlDbType.VarChar).Value = TextBox75.Text
                    Else
                        da.SelectCommand.Parameters.Add("@subtipoanalisis", SqlDbType.VarChar).Value = DropDownList31.Text
                    End If
                    da.SelectCommand.Parameters.Add("@analisis", SqlDbType.VarChar).Value = TextBox100.Text
                    da.SelectCommand.Parameters.Add("@diagnostico", SqlDbType.VarChar).Value = TextBox7.Text
                    da.SelectCommand.Parameters.Add("@indicgrales", SqlDbType.VarChar).Value = TextBox114.Text
                    da.SelectCommand.Parameters.Add("@estudiosgrales", SqlDbType.VarChar).Value = TextBox79.Text
                    da.SelectCommand.Parameters.Add("@tratamiento", SqlDbType.VarChar).Value = TextBox82.Text
                    da.SelectCommand.Parameters.Add("@medico", SqlDbType.VarChar).Value = Label8.Text

                    da.SelectCommand.ExecuteNonQuery()
                    con.Close()


                Catch ex As Exception

                End Try
            End If

            If DropDownList32.Text <> "--Seleccionar--" Then


                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    da = New SqlDataAdapter("modificagastro", con)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.SelectCommand.Parameters.Add("@folionota", SqlDbType.Int).Value = Session("numnota2")
                    da.SelectCommand.Parameters.Add("@pacienteid", SqlDbType.Int).Value = Session("Paciente")
                    da.SelectCommand.Parameters.Add("@fechamodif", SqlDbType.DateTime).Value = Label2.Text
                    da.SelectCommand.Parameters.Add("@genero", SqlDbType.VarChar).Value = DropDownList200.Text
                    da.SelectCommand.Parameters.Add("@diarrea", SqlDbType.VarChar).Value = DropDownList17.Text
                    da.SelectCommand.Parameters.Add("@hernias", SqlDbType.VarChar).Value = DropDownList21.Text
                    da.SelectCommand.Parameters.Add("@cancer", SqlDbType.VarChar).Value = DropDownList25.Text
                    da.SelectCommand.Parameters.Add("@estrenimiento", SqlDbType.VarChar).Value = DropDownList29.Text
                    da.SelectCommand.Parameters.Add("@cancerdigestivo", SqlDbType.VarChar).Value = DropDownList33.Text
                    da.SelectCommand.Parameters.Add("@colecistitis", SqlDbType.VarChar).Value = DropDownList37.Text
                    da.SelectCommand.Parameters.Add("@hipertension", SqlDbType.VarChar).Value = DropDownList41.Text
                    da.SelectCommand.Parameters.Add("@cardiopatia", SqlDbType.VarChar).Value = DropDownList45.Text
                    da.SelectCommand.Parameters.Add("@autoinmunes", SqlDbType.VarChar).Value = DropDownList49.Text
                    da.SelectCommand.Parameters.Add("@diabetes", SqlDbType.VarChar).Value = DropDownList53.Text
                    da.SelectCommand.Parameters.Add("@endocrinopatias", SqlDbType.VarChar).Value = DropDownList57.Text
                    da.SelectCommand.Parameters.Add("@otrosenf", SqlDbType.VarChar).Value = TextBox85.Text
                    da.SelectCommand.Parameters.Add("@otrosfam", SqlDbType.VarChar).Value = DropDownList168.Text
                    da.SelectCommand.Parameters.Add("@ocupacion", SqlDbType.VarChar).Value = TextBox91.Text
                    da.SelectCommand.Parameters.Add("@escolaridad", SqlDbType.VarChar).Value = DropDownList61.Text
                    da.SelectCommand.Parameters.Add("@actfis", SqlDbType.VarChar).Value = DropDownList64.Text
                    If DropDownList65.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@alergicos", SqlDbType.VarChar).Value = DropDownList65.Text
                    Else
                        da.SelectCommand.Parameters.Add("@alergicos", SqlDbType.VarChar).Value = TextBox94.Text
                    End If

                    da.SelectCommand.Parameters.Add("@cirugias", SqlDbType.VarChar).Value = TextBox97.Text
                    da.SelectCommand.Parameters.Add("@complicacionescirugias", SqlDbType.VarChar).Value = TextBox115.Text
                    If DropDownList66.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@transfusiones", SqlDbType.VarChar).Value = DropDownList66.Text
                    Else
                        da.SelectCommand.Parameters.Add("@transfusiones", SqlDbType.VarChar).Value = TextBox116.Text
                    End If
                    da.SelectCommand.Parameters.Add("@tiposangre", SqlDbType.VarChar).Value = DropDownList67.Text
                    If DropDownList68.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@fracturas", SqlDbType.VarChar).Value = DropDownList68.Text
                    Else
                        da.SelectCommand.Parameters.Add("@fracturas", SqlDbType.VarChar).Value = TextBox117.Text
                    End If
                    If DropDownList69.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@hospprevias", SqlDbType.VarChar).Value = DropDownList69.Text
                    Else
                        da.SelectCommand.Parameters.Add("@hospprevias", SqlDbType.VarChar).Value = TextBox118.Text
                    End If
                    If DropDownList169.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempohipertension", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientohipertension", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempohipertension", SqlDbType.VarChar).Value = TextBox148.Text
                        da.SelectCommand.Parameters.Add("@tratamientohipertension", SqlDbType.VarChar).Value = TextBox149.Text
                    End If
                    If DropDownList170.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoinsuficiencia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoinsuficiencia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoinsuficiencia", SqlDbType.VarChar).Value = TextBox150.Text
                        da.SelectCommand.Parameters.Add("@tratamientoinsuficiencia", SqlDbType.VarChar).Value = TextBox151.Text
                    End If
                    If DropDownList171.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempocardisq", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientocardisq", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempocardisq", SqlDbType.VarChar).Value = TextBox152.Text
                        da.SelectCommand.Parameters.Add("@tratamientocardisq", SqlDbType.VarChar).Value = TextBox153.Text
                    End If
                    If DropDownList172.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoevc", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoevc", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoevc", SqlDbType.VarChar).Value = TextBox154.Text
                        da.SelectCommand.Parameters.Add("@tratamientoevc", SqlDbType.VarChar).Value = TextBox155.Text
                    End If
                    If DropDownList173.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoinsufvenosa", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoinsufvenosa", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoinsufvenosa", SqlDbType.VarChar).Value = TextBox156.Text
                        da.SelectCommand.Parameters.Add("@tratamientoinsufvenosa", SqlDbType.VarChar).Value = TextBox157.Text
                    End If
                    If DropDownList174.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodiabetes", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientodiabetes", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodiabetes", SqlDbType.VarChar).Value = TextBox158.Text
                        da.SelectCommand.Parameters.Add("@tratamientodiabetes", SqlDbType.VarChar).Value = TextBox159.Text
                    End If
                    If DropDownList175.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodislipidemmia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientodislipidemmia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodislipidemmia", SqlDbType.VarChar).Value = TextBox160.Text
                        da.SelectCommand.Parameters.Add("@tratamientodislipidemmia", SqlDbType.VarChar).Value = TextBox161.Text
                    End If
                    If DropDownList176.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoobesidad", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoobesidad", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoobesidad", SqlDbType.VarChar).Value = TextBox162.Text
                        da.SelectCommand.Parameters.Add("@tratamientoobesidad", SqlDbType.VarChar).Value = TextBox163.Text
                    End If
                    If DropDownList177.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoenftiroidea", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoenftiroidea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoenftiroidea", SqlDbType.VarChar).Value = TextBox164.Text
                        da.SelectCommand.Parameters.Add("@tratamientoenftiroidea", SqlDbType.VarChar).Value = TextBox165.Text
                    End If
                    If DropDownList178.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempocancer", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientocancer", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempocancer", SqlDbType.VarChar).Value = TextBox166.Text
                        da.SelectCommand.Parameters.Add("@tratamientocancer", SqlDbType.VarChar).Value = TextBox167.Text
                    End If
                    If DropDownList179.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempotuberculosis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientotuberculosis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempotuberculosis", SqlDbType.VarChar).Value = TextBox168.Text
                        da.SelectCommand.Parameters.Add("@tratamientotuberculosis", SqlDbType.VarChar).Value = TextBox169.Text
                    End If
                    If DropDownList180.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoasma", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoasma", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoasma", SqlDbType.VarChar).Value = TextBox170.Text
                        da.SelectCommand.Parameters.Add("@tratamientoasma", SqlDbType.VarChar).Value = TextBox171.Text
                    End If
                    If DropDownList181.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoepoc", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoepoc", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoepoc", SqlDbType.VarChar).Value = TextBox172.Text
                        da.SelectCommand.Parameters.Add("@tratamientoepoc", SqlDbType.VarChar).Value = TextBox173.Text
                    End If
                    If DropDownList182.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempobronquitis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientobronquitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempobronquitis", SqlDbType.VarChar).Value = TextBox174.Text
                        da.SelectCommand.Parameters.Add("@tratamientobronquitis", SqlDbType.VarChar).Value = TextBox175.Text
                    End If
                    If TextBox176.Text = "" Then
                        da.SelectCommand.Parameters.Add("@otraenf", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tiempootraenf", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientootraenf", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@otraenf", SqlDbType.VarChar).Value = TextBox176.Text
                        da.SelectCommand.Parameters.Add("@tiempootraenf", SqlDbType.VarChar).Value = TextBox177.Text
                        da.SelectCommand.Parameters.Add("@tratamientootraenf", SqlDbType.VarChar).Value = TextBox178.Text
                    End If
                    If DropDownList84.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoalcoholismo", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantalcoholismo", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoalcoholismo", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@cantalcoholismo", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If DropDownList85.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempotabaquismo", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@canttabaquismo", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempotabaquismo", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@canttabaquismo", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If DropDownList86.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodrogas", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantdrogas", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodrogas", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@cantdrogas", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If TextBox185.Text = "" Then
                        da.SelectCommand.Parameters.Add("@otrotox", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tiempootrotox", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantotrotox", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@otrotox", SqlDbType.VarChar).Value = TextBox185.Text
                        da.SelectCommand.Parameters.Add("@tiempootrotox", SqlDbType.VarChar).Value = TextBox186.Text
                        da.SelectCommand.Parameters.Add("@cantotrotox", SqlDbType.VarChar).Value = TextBox187.Text
                    End If
                        da.SelectCommand.Parameters.Add("@ultregla", SqlDbType.Date).Value = DBNull.Value
                    
                    da.SelectCommand.Parameters.Add("@ritmo", SqlDbType.VarChar).Value = TextBox124.Text
                    da.SelectCommand.Parameters.Add("@menopausia", SqlDbType.VarChar).Value = DropDownList87.Text
                    da.SelectCommand.Parameters.Add("@gesta", SqlDbType.Int).Value = DropDownList88.Text
                    da.SelectCommand.Parameters.Add("@para", SqlDbType.Int).Value = DropDownList89.Text
                    da.SelectCommand.Parameters.Add("@cesarea", SqlDbType.Int).Value = DropDownList90.Text
                    da.SelectCommand.Parameters.Add("@aborto", SqlDbType.Int).Value = DropDownList91.Text
                    da.SelectCommand.Parameters.Add("@metplanfam", SqlDbType.VarChar).Value = DropDownList92.Text
                    da.SelectCommand.Parameters.Add("@otroplanfam", SqlDbType.VarChar).Value = TextBox125.Text
                    If DropDownList93.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempofiebre", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionfiebre", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempofiebre", SqlDbType.VarChar).Value = TextBox188.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionfiebre", SqlDbType.VarChar).Value = TextBox189.Text
                    End If
                    If DropDownList94.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoastenia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionastenia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoastenia", SqlDbType.VarChar).Value = TextBox191.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionastenia", SqlDbType.VarChar).Value = TextBox192.Text
                    End If
                    If DropDownList95.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoadinamia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionadinamia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoadinamia", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionadinamia", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList96.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoanorexia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionanorexia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoanorexia", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionanorexia", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList97.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoperdidapeso", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionperdidapeso", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoperdidapeso", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionperdidapeso", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList98.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@obstruccionnasal", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@obstruccionnasal", SqlDbType.VarChar).Value = DropDownList183.Text
                    End If
                    If DropDownList99.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@ronqueramatutina", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@ronqueramatutina", SqlDbType.VarChar).Value = DropDownList184.Text
                    End If
                    If DropDownList100.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@sinusitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@sinusitis", SqlDbType.VarChar).Value = DropDownList185.Text
                    End If
                    If DropDownList101.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@disfonia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@disfonia", SqlDbType.VarChar).Value = DropDownList186.Text
                    End If
                    If DropDownList102.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@disnea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@disnea", SqlDbType.VarChar).Value = DropDownList187.Text
                    End If
                    If DropDownList103.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@sibilancias", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@sibilancias", SqlDbType.VarChar).Value = DropDownList188.Text
                    End If
                    If DropDownList104.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tos", SqlDbType.VarChar).Value = DropDownList189.Text
                    End If
                    If DropDownList105.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@cianosis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@cianosis", SqlDbType.VarChar).Value = DropDownList190.Text
                    End If
                    If DropDownList106.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@asma", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@asma", SqlDbType.VarChar).Value = DropDownList191.Text
                    End If
                    If DropDownList107.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorolipotimia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacioneslipotimia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorolipotimia", SqlDbType.VarChar).Value = DropDownList192.Text
                        da.SelectCommand.Parameters.Add("@sensacioneslipotimia", SqlDbType.VarChar).Value = TextBox203.Text
                    End If
                    If DropDownList108.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorosincope", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionessincope", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorosincope", SqlDbType.VarChar).Value = DropDownList193.Text
                        da.SelectCommand.Parameters.Add("@sensacionessincope", SqlDbType.VarChar).Value = TextBox204.Text
                    End If
                    If DropDownList109.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorofatiga", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesfatiga", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorofatiga", SqlDbType.VarChar).Value = DropDownList194.Text
                        da.SelectCommand.Parameters.Add("@sensacionesfatiga", SqlDbType.VarChar).Value = TextBox205.Text
                    End If
                    If DropDownList110.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoropalpitaciones", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionespalpitaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoropalpitaciones", SqlDbType.VarChar).Value = DropDownList195.Text
                        da.SelectCommand.Parameters.Add("@sensacionespalpitaciones", SqlDbType.VarChar).Value = TextBox206.Text
                    End If
                    If DropDownList111.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorodolprecordial", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesdolprecordial", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorodolprecordial", SqlDbType.VarChar).Value = DropDownList196.Text
                        da.SelectCommand.Parameters.Add("@sensacionesdolprecordial", SqlDbType.VarChar).Value = TextBox207.Text
                    End If
                    If DropDownList112.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoroedema", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesedema", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoroedema", SqlDbType.VarChar).Value = DropDownList197.Text
                        da.SelectCommand.Parameters.Add("@sensacionesedema", SqlDbType.VarChar).Value = TextBox208.Text
                    End If
                    If DropDownList113.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorodisnea", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesdisnea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorodisnea", SqlDbType.VarChar).Value = DropDownList198.Text
                        da.SelectCommand.Parameters.Add("@sensacionesdisnea", SqlDbType.VarChar).Value = TextBox209.Text
                    End If
                    If DropDownList114.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoroascitis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesascitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoroascitis", SqlDbType.VarChar).Value = DropDownList199.Text
                        da.SelectCommand.Parameters.Add("@sensacionesascitis", SqlDbType.VarChar).Value = TextBox210.Text
                    End If
                    da.SelectCommand.Parameters.Add("@disuria", SqlDbType.VarChar).Value = DropDownList138.Text
                    da.SelectCommand.Parameters.Add("@poliaquiuria", SqlDbType.VarChar).Value = DropDownList139.Text
                    da.SelectCommand.Parameters.Add("@tenesmo", SqlDbType.VarChar).Value = DropDownList140.Text
                    da.SelectCommand.Parameters.Add("@hematuria", SqlDbType.VarChar).Value = DropDownList141.Text
                    da.SelectCommand.Parameters.Add("@suprapubica", SqlDbType.VarChar).Value = DropDownList142.Text
                    da.SelectCommand.Parameters.Add("@lumbar", SqlDbType.VarChar).Value = DropDownList143.Text
                    da.SelectCommand.Parameters.Add("@ninguno", SqlDbType.VarChar).Value = DropDownList144.Text
                    da.SelectCommand.Parameters.Add("@otrosdolores", SqlDbType.VarChar).Value = TextBox131.Text
                    da.SelectCommand.Parameters.Add("@tendenciahemorragia", SqlDbType.VarChar).Value = DropDownList145.Text
                    da.SelectCommand.Parameters.Add("@adenopatias", SqlDbType.VarChar).Value = DropDownList146.Text
                    da.SelectCommand.Parameters.Add("@infecrecurrentes", SqlDbType.VarChar).Value = DropDownList147.Text
                    da.SelectCommand.Parameters.Add("@anemia", SqlDbType.VarChar).Value = DropDownList148.Text
                    da.SelectCommand.Parameters.Add("@hemolinfaticonegado", SqlDbType.VarChar).Value = DropDownList149.Text
                    da.SelectCommand.Parameters.Add("@otroshemolinf", SqlDbType.VarChar).Value = TextBox132.Text
                    da.SelectCommand.Parameters.Add("@paralisis", SqlDbType.VarChar).Value = DropDownList150.Text
                    da.SelectCommand.Parameters.Add("@parestesisas", SqlDbType.VarChar).Value = DropDownList151.Text
                    da.SelectCommand.Parameters.Add("@temblores", SqlDbType.VarChar).Value = DropDownList152.Text
                    da.SelectCommand.Parameters.Add("@alteracionesmarcha", SqlDbType.VarChar).Value = DropDownList153.Text
                    da.SelectCommand.Parameters.Add("@cefalea", SqlDbType.VarChar).Value = DropDownList154.Text
                    da.SelectCommand.Parameters.Add("@sisnerviosonegado", SqlDbType.VarChar).Value = DropDownList155.Text
                    da.SelectCommand.Parameters.Add("@otrossisnerv", SqlDbType.VarChar).Value = TextBox133.Text
                    da.SelectCommand.Parameters.Add("@padactual", SqlDbType.VarChar).Value = TextBox1.Text
                    da.SelectCommand.Parameters.Add("@motivoconsulta", SqlDbType.VarChar).Value = TextBox12.Text
                    da.SelectCommand.Parameters.Add("@region", SqlDbType.VarChar).Value = TextBox13.Text
                    da.SelectCommand.Parameters.Add("@inicia", SqlDbType.VarChar).Value = TextBox14.Text
                    da.SelectCommand.Parameters.Add("@irradiacion", SqlDbType.VarChar).Value = TextBox15.Text
                    da.SelectCommand.Parameters.Add("@migracion", SqlDbType.VarChar).Value = TextBox16.Text
                    da.SelectCommand.Parameters.Add("@expansion", SqlDbType.VarChar).Value = TextBox17.Text
                    da.SelectCommand.Parameters.Add("@proyeccion", SqlDbType.VarChar).Value = TextBox18.Text
                    da.SelectCommand.Parameters.Add("@semejanzacualitativos", SqlDbType.VarChar).Value = TextBox19.Text
                    If DropDownList1.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@localizacioncualitativos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@localizacioncualitativos", SqlDbType.VarChar).Value = DropDownList1.Text
                    End If
                    da.SelectCommand.Parameters.Add("@intensidadcuantitativos", SqlDbType.VarChar).Value = TextBox20.Text
                    da.SelectCommand.Parameters.Add("@maximaintensidadcuantitativos", SqlDbType.VarChar).Value = TextBox21.Text
                    da.SelectCommand.Parameters.Add("@intensidadultimoevento", SqlDbType.VarChar).Value = TextBox22.Text
                    da.SelectCommand.Parameters.Add("@iniciocronologicos", SqlDbType.VarChar).Value = TextBox23.Text
                    If DropDownList2.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patroncronologicos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patroncronologicos", SqlDbType.VarChar).Value = DropDownList2.Text
                    End If
                    da.SelectCommand.Parameters.Add("@duracion", SqlDbType.VarChar).Value = TextBox24.Text
                    da.SelectCommand.Parameters.Add("@frecuenciadia", SqlDbType.VarChar).Value = TextBox25.Text
                    da.SelectCommand.Parameters.Add("@frecuenciamensual", SqlDbType.VarChar).Value = TextBox26.Text
                    da.SelectCommand.Parameters.Add("@ultimoevento", SqlDbType.VarChar).Value = TextBox27.Text
                    If DropDownList3.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patrondia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patrondia", SqlDbType.VarChar).Value = DropDownList3.Text
                    End If
                    If DropDownList4.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronayuno", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronayuno", SqlDbType.VarChar).Value = DropDownList4.Text
                    End If
                    If DropDownList5.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronevacuaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronevacuaciones", SqlDbType.VarChar).Value = DropDownList5.Text
                    End If
                    da.SelectCommand.Parameters.Add("@patronevacuaciones2", SqlDbType.VarChar).Value = TextBox28.Text
                    da.SelectCommand.Parameters.Add("@patrongases", SqlDbType.VarChar).Value = TextBox29.Text
                    da.SelectCommand.Parameters.Add("@patronvomito", SqlDbType.VarChar).Value = TextBox30.Text
                    da.SelectCommand.Parameters.Add("@aumentaintesidad", SqlDbType.VarChar).Value = TextBox33.Text
                    da.SelectCommand.Parameters.Add("@disminuyeintensidad", SqlDbType.VarChar).Value = TextBox33.Text
                    da.SelectCommand.Parameters.Add("@alimdisminuyen", SqlDbType.VarChar).Value = TextBox35.Text
                    If DropDownList7.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@evacuaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@evacuaciones", SqlDbType.VarChar).Value = DropDownList7.Text
                    End If
                    If DropDownList8.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@canalizacionesgases", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@canalizacionesgases", SqlDbType.VarChar).Value = DropDownList8.Text
                    End If
                    If DropDownList9.Text = "-Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@eructos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@eructos", SqlDbType.VarChar).Value = DropDownList9.Text
                    End If
                    da.SelectCommand.Parameters.Add("@medicamcalman", SqlDbType.VarChar).Value = TextBox32.Text
                    da.SelectCommand.Parameters.Add("@medicamnocontrolan", SqlDbType.VarChar).Value = TextBox31.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional1", SqlDbType.VarChar).Value = TextBox36.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional2", SqlDbType.VarChar).Value = TextBox37.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional3", SqlDbType.VarChar).Value = TextBox38.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional4", SqlDbType.VarChar).Value = TextBox39.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre1", SqlDbType.VarChar).Value = TextBox40.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre2", SqlDbType.VarChar).Value = TextBox41.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre3", SqlDbType.VarChar).Value = TextBox42.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre4", SqlDbType.VarChar).Value = TextBox43.Text
                    da.SelectCommand.Parameters.Add("@sintomanodolor", SqlDbType.VarChar).Value = TextBox44.Text
                    da.SelectCommand.Parameters.Add("@inicionodolor", SqlDbType.VarChar).Value = TextBox2.Text
                    If DropDownList6.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronnodolor", SqlDbType.VarChar).Value = DropDownList6.Text
                    End If
                    da.SelectCommand.Parameters.Add("@duracionnodolor", SqlDbType.VarChar).Value = TextBox3.Text
                    da.SelectCommand.Parameters.Add("@frecuenciadianodolor", SqlDbType.VarChar).Value = TextBox4.Text
                    da.SelectCommand.Parameters.Add("@frecuenciamesnodolor", SqlDbType.VarChar).Value = TextBox5.Text
                    da.SelectCommand.Parameters.Add("@ulteventonodolor", SqlDbType.VarChar).Value = TextBox6.Text
                    If DropDownList10.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patrondianodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patrondianodolor", SqlDbType.VarChar).Value = DropDownList10.Text
                    End If
                    If DropDownList11.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronayunonodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronayunonodolor", SqlDbType.VarChar).Value = DropDownList11.Text
                    End If
                    If DropDownList12.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronevacnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronevacnodolor", SqlDbType.VarChar).Value = DropDownList12.Text
                    End If
                    da.SelectCommand.Parameters.Add("@patrongasesnodolor", SqlDbType.VarChar).Value = TextBox46.Text
                    da.SelectCommand.Parameters.Add("@patronvomitonodolor", SqlDbType.VarChar).Value = TextBox45.Text
                    da.SelectCommand.Parameters.Add("@aumentaintensnodolor", SqlDbType.VarChar).Value = TextBox47.Text
                    da.SelectCommand.Parameters.Add("@disminuyeintensnodolor", SqlDbType.VarChar).Value = TextBox48.Text
                    da.SelectCommand.Parameters.Add("@alimprovocannodolor", SqlDbType.VarChar).Value = TextBox49.Text
                    da.SelectCommand.Parameters.Add("@alimdisminuyennodolor", SqlDbType.VarChar).Value = TextBox50.Text
                    If DropDownList13.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@evacnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@evacnodolor", SqlDbType.VarChar).Value = DropDownList13.Text
                    End If
                    If DropDownList14.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@canalizgasesnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@canalizgasesnodolor", SqlDbType.VarChar).Value = DropDownList14.Text
                    End If
                    If DropDownList15.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@eructosnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@eructosnodolor", SqlDbType.VarChar).Value = DropDownList15.Text
                    End If
                    da.SelectCommand.Parameters.Add("@medicamcalmannodolor", SqlDbType.VarChar).Value = TextBox51.Text
                    da.SelectCommand.Parameters.Add("@mednocontrolannodolor", SqlDbType.VarChar).Value = TextBox52.Text
                    da.SelectCommand.Parameters.Add("@peso", SqlDbType.VarChar).Value = TextBox53.Text
                    da.SelectCommand.Parameters.Add("@talla", SqlDbType.VarChar).Value = TextBox54.Text
                    da.SelectCommand.Parameters.Add("@temp", SqlDbType.VarChar).Value = TextBox55.Text
                    da.SelectCommand.Parameters.Add("@ta", SqlDbType.VarChar).Value = TextBox56.Text
                    da.SelectCommand.Parameters.Add("@tc", SqlDbType.VarChar).Value = TextBox57.Text
                    da.SelectCommand.Parameters.Add("@fr", SqlDbType.VarChar).Value = TextBox58.Text
                    da.SelectCommand.Parameters.Add("@cabeza", SqlDbType.VarChar).Value = TextBox59.Text
                    da.SelectCommand.Parameters.Add("@torax", SqlDbType.VarChar).Value = TextBox60.Text
                    da.SelectCommand.Parameters.Add("@abdomen", SqlDbType.VarChar).Value = TextBox61.Text
                    da.SelectCommand.Parameters.Add("@extremidades", SqlDbType.VarChar).Value = TextBox62.Text
                    da.SelectCommand.Parameters.Add("@estudios", SqlDbType.VarChar).Value = TextBox63.Text
                    da.SelectCommand.Parameters.Add("@regionanalisis", SqlDbType.VarChar).Value = DropDownList32.Text
                    For Each li As ListItem In CheckBoxList5.Items
                        If li.Selected Then
                            If sintanalisis5.Length = 0 Then
                                sintanalisis5 = li.Value
                            Else
                                sintanalisis5 += ", " + li.Value
                            End If
                        End If
                    Next
                    If TextBox106.Text <> "" Then
                        sintanalisis5 += ", " + TextBox106.Text
                    End If
                    da.SelectCommand.Parameters.Add("@sintomaanalisis", SqlDbType.VarChar).Value = sintanalisis5
                    If TextBox77.Visible = True Then
                        da.SelectCommand.Parameters.Add("@sindromeclin", SqlDbType.VarChar).Value = TextBox77.Text
                    Else
                        da.SelectCommand.Parameters.Add("@sindromeclin", SqlDbType.VarChar).Value = DropDownList34.Text
                    End If
                    If TextBox78.Visible = True Then
                        da.SelectCommand.Parameters.Add("@subtipoanalisis", SqlDbType.VarChar).Value = TextBox78.Text
                    Else
                        da.SelectCommand.Parameters.Add("@subtipoanalisis", SqlDbType.VarChar).Value = DropDownList35.Text
                    End If
                    da.SelectCommand.Parameters.Add("@analisis", SqlDbType.VarChar).Value = TextBox100.Text
                    da.SelectCommand.Parameters.Add("@diagnostico", SqlDbType.VarChar).Value = TextBox7.Text
                    da.SelectCommand.Parameters.Add("@indicgrales", SqlDbType.VarChar).Value = TextBox114.Text
                    da.SelectCommand.Parameters.Add("@estudiosgrales", SqlDbType.VarChar).Value = TextBox79.Text
                    da.SelectCommand.Parameters.Add("@tratamiento", SqlDbType.VarChar).Value = TextBox82.Text
                    da.SelectCommand.Parameters.Add("@medico", SqlDbType.VarChar).Value = Label8.Text

                    da.SelectCommand.ExecuteNonQuery()
                    con.Close()


                Catch ex As Exception

                End Try
            End If

            If DropDownList36.Text <> "--Seleccionar--" Then


                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    da = New SqlDataAdapter("modificagastro", con)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.SelectCommand.Parameters.Add("@folionota", SqlDbType.Int).Value = Session("numnota2")
                    da.SelectCommand.Parameters.Add("@pacienteid", SqlDbType.Int).Value = Session("Paciente")
                    da.SelectCommand.Parameters.Add("@fechamodif", SqlDbType.DateTime).Value = Label2.Text
                    da.SelectCommand.Parameters.Add("@genero", SqlDbType.VarChar).Value = DropDownList200.Text
                    da.SelectCommand.Parameters.Add("@diarrea", SqlDbType.VarChar).Value = DropDownList17.Text
                    da.SelectCommand.Parameters.Add("@hernias", SqlDbType.VarChar).Value = DropDownList21.Text
                    da.SelectCommand.Parameters.Add("@cancer", SqlDbType.VarChar).Value = DropDownList25.Text
                    da.SelectCommand.Parameters.Add("@estrenimiento", SqlDbType.VarChar).Value = DropDownList29.Text
                    da.SelectCommand.Parameters.Add("@cancerdigestivo", SqlDbType.VarChar).Value = DropDownList33.Text
                    da.SelectCommand.Parameters.Add("@colecistitis", SqlDbType.VarChar).Value = DropDownList37.Text
                    da.SelectCommand.Parameters.Add("@hipertension", SqlDbType.VarChar).Value = DropDownList41.Text
                    da.SelectCommand.Parameters.Add("@cardiopatia", SqlDbType.VarChar).Value = DropDownList45.Text
                    da.SelectCommand.Parameters.Add("@autoinmunes", SqlDbType.VarChar).Value = DropDownList49.Text
                    da.SelectCommand.Parameters.Add("@diabetes", SqlDbType.VarChar).Value = DropDownList53.Text
                    da.SelectCommand.Parameters.Add("@endocrinopatias", SqlDbType.VarChar).Value = DropDownList57.Text
                    da.SelectCommand.Parameters.Add("@otrosenf", SqlDbType.VarChar).Value = TextBox85.Text
                    da.SelectCommand.Parameters.Add("@otrosfam", SqlDbType.VarChar).Value = DropDownList168.Text
                    da.SelectCommand.Parameters.Add("@ocupacion", SqlDbType.VarChar).Value = TextBox91.Text
                    da.SelectCommand.Parameters.Add("@escolaridad", SqlDbType.VarChar).Value = DropDownList61.Text
                    da.SelectCommand.Parameters.Add("@actfis", SqlDbType.VarChar).Value = DropDownList64.Text
                    If DropDownList65.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@alergicos", SqlDbType.VarChar).Value = DropDownList65.Text
                    Else
                        da.SelectCommand.Parameters.Add("@alergicos", SqlDbType.VarChar).Value = TextBox94.Text
                    End If

                    da.SelectCommand.Parameters.Add("@cirugias", SqlDbType.VarChar).Value = TextBox97.Text
                    da.SelectCommand.Parameters.Add("@complicacionescirugias", SqlDbType.VarChar).Value = TextBox115.Text
                    If DropDownList66.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@transfusiones", SqlDbType.VarChar).Value = DropDownList66.Text
                    Else
                        da.SelectCommand.Parameters.Add("@transfusiones", SqlDbType.VarChar).Value = TextBox116.Text
                    End If
                    da.SelectCommand.Parameters.Add("@tiposangre", SqlDbType.VarChar).Value = DropDownList67.Text
                    If DropDownList68.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@fracturas", SqlDbType.VarChar).Value = DropDownList68.Text
                    Else
                        da.SelectCommand.Parameters.Add("@fracturas", SqlDbType.VarChar).Value = TextBox117.Text
                    End If
                    If DropDownList69.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@hospprevias", SqlDbType.VarChar).Value = DropDownList69.Text
                    Else
                        da.SelectCommand.Parameters.Add("@hospprevias", SqlDbType.VarChar).Value = TextBox118.Text
                    End If
                    If DropDownList169.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempohipertension", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientohipertension", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempohipertension", SqlDbType.VarChar).Value = TextBox148.Text
                        da.SelectCommand.Parameters.Add("@tratamientohipertension", SqlDbType.VarChar).Value = TextBox149.Text
                    End If
                    If DropDownList170.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoinsuficiencia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoinsuficiencia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoinsuficiencia", SqlDbType.VarChar).Value = TextBox150.Text
                        da.SelectCommand.Parameters.Add("@tratamientoinsuficiencia", SqlDbType.VarChar).Value = TextBox151.Text
                    End If
                    If DropDownList171.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempocardisq", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientocardisq", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempocardisq", SqlDbType.VarChar).Value = TextBox152.Text
                        da.SelectCommand.Parameters.Add("@tratamientocardisq", SqlDbType.VarChar).Value = TextBox153.Text
                    End If
                    If DropDownList172.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoevc", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoevc", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoevc", SqlDbType.VarChar).Value = TextBox154.Text
                        da.SelectCommand.Parameters.Add("@tratamientoevc", SqlDbType.VarChar).Value = TextBox155.Text
                    End If
                    If DropDownList173.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoinsufvenosa", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoinsufvenosa", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoinsufvenosa", SqlDbType.VarChar).Value = TextBox156.Text
                        da.SelectCommand.Parameters.Add("@tratamientoinsufvenosa", SqlDbType.VarChar).Value = TextBox157.Text
                    End If
                    If DropDownList174.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodiabetes", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientodiabetes", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodiabetes", SqlDbType.VarChar).Value = TextBox158.Text
                        da.SelectCommand.Parameters.Add("@tratamientodiabetes", SqlDbType.VarChar).Value = TextBox159.Text
                    End If
                    If DropDownList175.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodislipidemmia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientodislipidemmia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodislipidemmia", SqlDbType.VarChar).Value = TextBox160.Text
                        da.SelectCommand.Parameters.Add("@tratamientodislipidemmia", SqlDbType.VarChar).Value = TextBox161.Text
                    End If
                    If DropDownList176.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoobesidad", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoobesidad", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoobesidad", SqlDbType.VarChar).Value = TextBox162.Text
                        da.SelectCommand.Parameters.Add("@tratamientoobesidad", SqlDbType.VarChar).Value = TextBox163.Text
                    End If
                    If DropDownList177.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoenftiroidea", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoenftiroidea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoenftiroidea", SqlDbType.VarChar).Value = TextBox164.Text
                        da.SelectCommand.Parameters.Add("@tratamientoenftiroidea", SqlDbType.VarChar).Value = TextBox165.Text
                    End If
                    If DropDownList178.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempocancer", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientocancer", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempocancer", SqlDbType.VarChar).Value = TextBox166.Text
                        da.SelectCommand.Parameters.Add("@tratamientocancer", SqlDbType.VarChar).Value = TextBox167.Text
                    End If
                    If DropDownList179.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempotuberculosis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientotuberculosis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempotuberculosis", SqlDbType.VarChar).Value = TextBox168.Text
                        da.SelectCommand.Parameters.Add("@tratamientotuberculosis", SqlDbType.VarChar).Value = TextBox169.Text
                    End If
                    If DropDownList180.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoasma", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoasma", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoasma", SqlDbType.VarChar).Value = TextBox170.Text
                        da.SelectCommand.Parameters.Add("@tratamientoasma", SqlDbType.VarChar).Value = TextBox171.Text
                    End If
                    If DropDownList181.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoepoc", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoepoc", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoepoc", SqlDbType.VarChar).Value = TextBox172.Text
                        da.SelectCommand.Parameters.Add("@tratamientoepoc", SqlDbType.VarChar).Value = TextBox173.Text
                    End If
                    If DropDownList182.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempobronquitis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientobronquitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempobronquitis", SqlDbType.VarChar).Value = TextBox174.Text
                        da.SelectCommand.Parameters.Add("@tratamientobronquitis", SqlDbType.VarChar).Value = TextBox175.Text
                    End If
                    If TextBox176.Text = "" Then
                        da.SelectCommand.Parameters.Add("@otraenf", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tiempootraenf", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientootraenf", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@otraenf", SqlDbType.VarChar).Value = TextBox176.Text
                        da.SelectCommand.Parameters.Add("@tiempootraenf", SqlDbType.VarChar).Value = TextBox177.Text
                        da.SelectCommand.Parameters.Add("@tratamientootraenf", SqlDbType.VarChar).Value = TextBox178.Text
                    End If
                    If DropDownList84.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoalcoholismo", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantalcoholismo", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoalcoholismo", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@cantalcoholismo", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If DropDownList85.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempotabaquismo", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@canttabaquismo", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempotabaquismo", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@canttabaquismo", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If DropDownList86.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodrogas", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantdrogas", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodrogas", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@cantdrogas", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If TextBox185.Text = "" Then
                        da.SelectCommand.Parameters.Add("@otrotox", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tiempootrotox", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantotrotox", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@otrotox", SqlDbType.VarChar).Value = TextBox185.Text
                        da.SelectCommand.Parameters.Add("@tiempootrotox", SqlDbType.VarChar).Value = TextBox186.Text
                        da.SelectCommand.Parameters.Add("@cantotrotox", SqlDbType.VarChar).Value = TextBox187.Text
                    End If
                        da.SelectCommand.Parameters.Add("@ultregla", SqlDbType.Date).Value = DBNull.Value
                    
                    da.SelectCommand.Parameters.Add("@ritmo", SqlDbType.VarChar).Value = TextBox124.Text
                    da.SelectCommand.Parameters.Add("@menopausia", SqlDbType.VarChar).Value = DropDownList87.Text
                    da.SelectCommand.Parameters.Add("@gesta", SqlDbType.Int).Value = DropDownList88.Text
                    da.SelectCommand.Parameters.Add("@para", SqlDbType.Int).Value = DropDownList89.Text
                    da.SelectCommand.Parameters.Add("@cesarea", SqlDbType.Int).Value = DropDownList90.Text
                    da.SelectCommand.Parameters.Add("@aborto", SqlDbType.Int).Value = DropDownList91.Text
                    da.SelectCommand.Parameters.Add("@metplanfam", SqlDbType.VarChar).Value = DropDownList92.Text
                    da.SelectCommand.Parameters.Add("@otroplanfam", SqlDbType.VarChar).Value = TextBox125.Text
                    If DropDownList93.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempofiebre", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionfiebre", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempofiebre", SqlDbType.VarChar).Value = TextBox188.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionfiebre", SqlDbType.VarChar).Value = TextBox189.Text
                    End If
                    If DropDownList94.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoastenia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionastenia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoastenia", SqlDbType.VarChar).Value = TextBox191.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionastenia", SqlDbType.VarChar).Value = TextBox192.Text
                    End If
                    If DropDownList95.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoadinamia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionadinamia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoadinamia", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionadinamia", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList96.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoanorexia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionanorexia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoanorexia", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionanorexia", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList97.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoperdidapeso", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionperdidapeso", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoperdidapeso", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionperdidapeso", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList98.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@obstruccionnasal", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@obstruccionnasal", SqlDbType.VarChar).Value = DropDownList183.Text
                    End If
                    If DropDownList99.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@ronqueramatutina", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@ronqueramatutina", SqlDbType.VarChar).Value = DropDownList184.Text
                    End If
                    If DropDownList100.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@sinusitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@sinusitis", SqlDbType.VarChar).Value = DropDownList185.Text
                    End If
                    If DropDownList101.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@disfonia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@disfonia", SqlDbType.VarChar).Value = DropDownList186.Text
                    End If
                    If DropDownList102.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@disnea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@disnea", SqlDbType.VarChar).Value = DropDownList187.Text
                    End If
                    If DropDownList103.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@sibilancias", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@sibilancias", SqlDbType.VarChar).Value = DropDownList188.Text
                    End If
                    If DropDownList104.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tos", SqlDbType.VarChar).Value = DropDownList189.Text
                    End If
                    If DropDownList105.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@cianosis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@cianosis", SqlDbType.VarChar).Value = DropDownList190.Text
                    End If
                    If DropDownList106.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@asma", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@asma", SqlDbType.VarChar).Value = DropDownList191.Text
                    End If
                    If DropDownList107.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorolipotimia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacioneslipotimia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorolipotimia", SqlDbType.VarChar).Value = DropDownList192.Text
                        da.SelectCommand.Parameters.Add("@sensacioneslipotimia", SqlDbType.VarChar).Value = TextBox203.Text
                    End If
                    If DropDownList108.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorosincope", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionessincope", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorosincope", SqlDbType.VarChar).Value = DropDownList193.Text
                        da.SelectCommand.Parameters.Add("@sensacionessincope", SqlDbType.VarChar).Value = TextBox204.Text
                    End If
                    If DropDownList109.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorofatiga", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesfatiga", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorofatiga", SqlDbType.VarChar).Value = DropDownList194.Text
                        da.SelectCommand.Parameters.Add("@sensacionesfatiga", SqlDbType.VarChar).Value = TextBox205.Text
                    End If
                    If DropDownList110.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoropalpitaciones", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionespalpitaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoropalpitaciones", SqlDbType.VarChar).Value = DropDownList195.Text
                        da.SelectCommand.Parameters.Add("@sensacionespalpitaciones", SqlDbType.VarChar).Value = TextBox206.Text
                    End If
                    If DropDownList111.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorodolprecordial", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesdolprecordial", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorodolprecordial", SqlDbType.VarChar).Value = DropDownList196.Text
                        da.SelectCommand.Parameters.Add("@sensacionesdolprecordial", SqlDbType.VarChar).Value = TextBox207.Text
                    End If
                    If DropDownList112.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoroedema", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesedema", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoroedema", SqlDbType.VarChar).Value = DropDownList197.Text
                        da.SelectCommand.Parameters.Add("@sensacionesedema", SqlDbType.VarChar).Value = TextBox208.Text
                    End If
                    If DropDownList113.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorodisnea", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesdisnea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorodisnea", SqlDbType.VarChar).Value = DropDownList198.Text
                        da.SelectCommand.Parameters.Add("@sensacionesdisnea", SqlDbType.VarChar).Value = TextBox209.Text
                    End If
                    If DropDownList114.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoroascitis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesascitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoroascitis", SqlDbType.VarChar).Value = DropDownList199.Text
                        da.SelectCommand.Parameters.Add("@sensacionesascitis", SqlDbType.VarChar).Value = TextBox210.Text
                    End If
                    da.SelectCommand.Parameters.Add("@disuria", SqlDbType.VarChar).Value = DropDownList138.Text
                    da.SelectCommand.Parameters.Add("@poliaquiuria", SqlDbType.VarChar).Value = DropDownList139.Text
                    da.SelectCommand.Parameters.Add("@tenesmo", SqlDbType.VarChar).Value = DropDownList140.Text
                    da.SelectCommand.Parameters.Add("@hematuria", SqlDbType.VarChar).Value = DropDownList141.Text
                    da.SelectCommand.Parameters.Add("@suprapubica", SqlDbType.VarChar).Value = DropDownList142.Text
                    da.SelectCommand.Parameters.Add("@lumbar", SqlDbType.VarChar).Value = DropDownList143.Text
                    da.SelectCommand.Parameters.Add("@ninguno", SqlDbType.VarChar).Value = DropDownList144.Text
                    da.SelectCommand.Parameters.Add("@otrosdolores", SqlDbType.VarChar).Value = TextBox131.Text
                    da.SelectCommand.Parameters.Add("@tendenciahemorragia", SqlDbType.VarChar).Value = DropDownList145.Text
                    da.SelectCommand.Parameters.Add("@adenopatias", SqlDbType.VarChar).Value = DropDownList146.Text
                    da.SelectCommand.Parameters.Add("@infecrecurrentes", SqlDbType.VarChar).Value = DropDownList147.Text
                    da.SelectCommand.Parameters.Add("@anemia", SqlDbType.VarChar).Value = DropDownList148.Text
                    da.SelectCommand.Parameters.Add("@hemolinfaticonegado", SqlDbType.VarChar).Value = DropDownList149.Text
                    da.SelectCommand.Parameters.Add("@otroshemolinf", SqlDbType.VarChar).Value = TextBox132.Text
                    da.SelectCommand.Parameters.Add("@paralisis", SqlDbType.VarChar).Value = DropDownList150.Text
                    da.SelectCommand.Parameters.Add("@parestesisas", SqlDbType.VarChar).Value = DropDownList151.Text
                    da.SelectCommand.Parameters.Add("@temblores", SqlDbType.VarChar).Value = DropDownList152.Text
                    da.SelectCommand.Parameters.Add("@alteracionesmarcha", SqlDbType.VarChar).Value = DropDownList153.Text
                    da.SelectCommand.Parameters.Add("@cefalea", SqlDbType.VarChar).Value = DropDownList154.Text
                    da.SelectCommand.Parameters.Add("@sisnerviosonegado", SqlDbType.VarChar).Value = DropDownList155.Text
                    da.SelectCommand.Parameters.Add("@otrossisnerv", SqlDbType.VarChar).Value = TextBox133.Text
                    da.SelectCommand.Parameters.Add("@padactual", SqlDbType.VarChar).Value = TextBox1.Text
                    da.SelectCommand.Parameters.Add("@motivoconsulta", SqlDbType.VarChar).Value = TextBox12.Text
                    da.SelectCommand.Parameters.Add("@region", SqlDbType.VarChar).Value = TextBox13.Text
                    da.SelectCommand.Parameters.Add("@inicia", SqlDbType.VarChar).Value = TextBox14.Text
                    da.SelectCommand.Parameters.Add("@irradiacion", SqlDbType.VarChar).Value = TextBox15.Text
                    da.SelectCommand.Parameters.Add("@migracion", SqlDbType.VarChar).Value = TextBox16.Text
                    da.SelectCommand.Parameters.Add("@expansion", SqlDbType.VarChar).Value = TextBox17.Text
                    da.SelectCommand.Parameters.Add("@proyeccion", SqlDbType.VarChar).Value = TextBox18.Text
                    da.SelectCommand.Parameters.Add("@semejanzacualitativos", SqlDbType.VarChar).Value = TextBox19.Text
                    If DropDownList1.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@localizacioncualitativos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@localizacioncualitativos", SqlDbType.VarChar).Value = DropDownList1.Text
                    End If
                    da.SelectCommand.Parameters.Add("@intensidadcuantitativos", SqlDbType.VarChar).Value = TextBox20.Text
                    da.SelectCommand.Parameters.Add("@maximaintensidadcuantitativos", SqlDbType.VarChar).Value = TextBox21.Text
                    da.SelectCommand.Parameters.Add("@intensidadultimoevento", SqlDbType.VarChar).Value = TextBox22.Text
                    da.SelectCommand.Parameters.Add("@iniciocronologicos", SqlDbType.VarChar).Value = TextBox23.Text
                    If DropDownList2.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patroncronologicos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patroncronologicos", SqlDbType.VarChar).Value = DropDownList2.Text
                    End If
                    da.SelectCommand.Parameters.Add("@duracion", SqlDbType.VarChar).Value = TextBox24.Text
                    da.SelectCommand.Parameters.Add("@frecuenciadia", SqlDbType.VarChar).Value = TextBox25.Text
                    da.SelectCommand.Parameters.Add("@frecuenciamensual", SqlDbType.VarChar).Value = TextBox26.Text
                    da.SelectCommand.Parameters.Add("@ultimoevento", SqlDbType.VarChar).Value = TextBox27.Text
                    If DropDownList3.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patrondia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patrondia", SqlDbType.VarChar).Value = DropDownList3.Text
                    End If
                    If DropDownList4.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronayuno", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronayuno", SqlDbType.VarChar).Value = DropDownList4.Text
                    End If
                    If DropDownList5.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronevacuaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronevacuaciones", SqlDbType.VarChar).Value = DropDownList5.Text
                    End If
                    da.SelectCommand.Parameters.Add("@patronevacuaciones2", SqlDbType.VarChar).Value = TextBox28.Text
                    da.SelectCommand.Parameters.Add("@patrongases", SqlDbType.VarChar).Value = TextBox29.Text
                    da.SelectCommand.Parameters.Add("@patronvomito", SqlDbType.VarChar).Value = TextBox30.Text
                    da.SelectCommand.Parameters.Add("@aumentaintesidad", SqlDbType.VarChar).Value = TextBox33.Text
                    da.SelectCommand.Parameters.Add("@disminuyeintensidad", SqlDbType.VarChar).Value = TextBox33.Text
                    da.SelectCommand.Parameters.Add("@alimdisminuyen", SqlDbType.VarChar).Value = TextBox35.Text
                    If DropDownList7.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@evacuaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@evacuaciones", SqlDbType.VarChar).Value = DropDownList7.Text
                    End If
                    If DropDownList8.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@canalizacionesgases", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@canalizacionesgases", SqlDbType.VarChar).Value = DropDownList8.Text
                    End If
                    If DropDownList9.Text = "-Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@eructos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@eructos", SqlDbType.VarChar).Value = DropDownList9.Text
                    End If
                    da.SelectCommand.Parameters.Add("@medicamcalman", SqlDbType.VarChar).Value = TextBox32.Text
                    da.SelectCommand.Parameters.Add("@medicamnocontrolan", SqlDbType.VarChar).Value = TextBox31.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional1", SqlDbType.VarChar).Value = TextBox36.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional2", SqlDbType.VarChar).Value = TextBox37.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional3", SqlDbType.VarChar).Value = TextBox38.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional4", SqlDbType.VarChar).Value = TextBox39.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre1", SqlDbType.VarChar).Value = TextBox40.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre2", SqlDbType.VarChar).Value = TextBox41.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre3", SqlDbType.VarChar).Value = TextBox42.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre4", SqlDbType.VarChar).Value = TextBox43.Text
                    da.SelectCommand.Parameters.Add("@sintomanodolor", SqlDbType.VarChar).Value = TextBox44.Text
                    da.SelectCommand.Parameters.Add("@inicionodolor", SqlDbType.VarChar).Value = TextBox2.Text
                    If DropDownList6.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronnodolor", SqlDbType.VarChar).Value = DropDownList6.Text
                    End If
                    da.SelectCommand.Parameters.Add("@duracionnodolor", SqlDbType.VarChar).Value = TextBox3.Text
                    da.SelectCommand.Parameters.Add("@frecuenciadianodolor", SqlDbType.VarChar).Value = TextBox4.Text
                    da.SelectCommand.Parameters.Add("@frecuenciamesnodolor", SqlDbType.VarChar).Value = TextBox5.Text
                    da.SelectCommand.Parameters.Add("@ulteventonodolor", SqlDbType.VarChar).Value = TextBox6.Text
                    If DropDownList10.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patrondianodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patrondianodolor", SqlDbType.VarChar).Value = DropDownList10.Text
                    End If
                    If DropDownList11.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronayunonodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronayunonodolor", SqlDbType.VarChar).Value = DropDownList11.Text
                    End If
                    If DropDownList12.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronevacnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronevacnodolor", SqlDbType.VarChar).Value = DropDownList12.Text
                    End If
                    da.SelectCommand.Parameters.Add("@patrongasesnodolor", SqlDbType.VarChar).Value = TextBox46.Text
                    da.SelectCommand.Parameters.Add("@patronvomitonodolor", SqlDbType.VarChar).Value = TextBox45.Text
                    da.SelectCommand.Parameters.Add("@aumentaintensnodolor", SqlDbType.VarChar).Value = TextBox47.Text
                    da.SelectCommand.Parameters.Add("@disminuyeintensnodolor", SqlDbType.VarChar).Value = TextBox48.Text
                    da.SelectCommand.Parameters.Add("@alimprovocannodolor", SqlDbType.VarChar).Value = TextBox49.Text
                    da.SelectCommand.Parameters.Add("@alimdisminuyennodolor", SqlDbType.VarChar).Value = TextBox50.Text
                    If DropDownList13.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@evacnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@evacnodolor", SqlDbType.VarChar).Value = DropDownList13.Text
                    End If
                    If DropDownList14.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@canalizgasesnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@canalizgasesnodolor", SqlDbType.VarChar).Value = DropDownList14.Text
                    End If
                    If DropDownList15.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@eructosnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@eructosnodolor", SqlDbType.VarChar).Value = DropDownList15.Text
                    End If
                    da.SelectCommand.Parameters.Add("@medicamcalmannodolor", SqlDbType.VarChar).Value = TextBox51.Text
                    da.SelectCommand.Parameters.Add("@mednocontrolannodolor", SqlDbType.VarChar).Value = TextBox52.Text
                    da.SelectCommand.Parameters.Add("@peso", SqlDbType.VarChar).Value = TextBox53.Text
                    da.SelectCommand.Parameters.Add("@talla", SqlDbType.VarChar).Value = TextBox54.Text
                    da.SelectCommand.Parameters.Add("@temp", SqlDbType.VarChar).Value = TextBox55.Text
                    da.SelectCommand.Parameters.Add("@ta", SqlDbType.VarChar).Value = TextBox56.Text
                    da.SelectCommand.Parameters.Add("@tc", SqlDbType.VarChar).Value = TextBox57.Text
                    da.SelectCommand.Parameters.Add("@fr", SqlDbType.VarChar).Value = TextBox58.Text
                    da.SelectCommand.Parameters.Add("@cabeza", SqlDbType.VarChar).Value = TextBox59.Text
                    da.SelectCommand.Parameters.Add("@torax", SqlDbType.VarChar).Value = TextBox60.Text
                    da.SelectCommand.Parameters.Add("@abdomen", SqlDbType.VarChar).Value = TextBox61.Text
                    da.SelectCommand.Parameters.Add("@extremidades", SqlDbType.VarChar).Value = TextBox62.Text
                    da.SelectCommand.Parameters.Add("@estudios", SqlDbType.VarChar).Value = TextBox63.Text
                    da.SelectCommand.Parameters.Add("@regionanalisis", SqlDbType.VarChar).Value = DropDownList36.Text
                    For Each li As ListItem In CheckBoxList6.Items
                        If li.Selected Then
                            If sintanalisis6.Length = 0 Then
                                sintanalisis6 = li.Value
                            Else
                                sintanalisis6 += ", " + li.Value
                            End If
                        End If
                    Next
                    If TextBox107.Text <> "" Then
                        sintanalisis6 += ", " + TextBox107.Text
                    End If
                    da.SelectCommand.Parameters.Add("@sintomaanalisis", SqlDbType.VarChar).Value = sintanalisis6
                    If TextBox80.Visible = True Then
                        da.SelectCommand.Parameters.Add("@sindromeclin", SqlDbType.VarChar).Value = TextBox80.Text
                    Else
                        da.SelectCommand.Parameters.Add("@sindromeclin", SqlDbType.VarChar).Value = DropDownList38.Text
                    End If
                    If TextBox81.Visible = True Then
                        da.SelectCommand.Parameters.Add("@subtipoanalisis", SqlDbType.VarChar).Value = TextBox81.Text
                    Else
                        da.SelectCommand.Parameters.Add("@subtipoanalisis", SqlDbType.VarChar).Value = DropDownList39.Text
                    End If
                    da.SelectCommand.Parameters.Add("@analisis", SqlDbType.VarChar).Value = TextBox100.Text
                    da.SelectCommand.Parameters.Add("@diagnostico", SqlDbType.VarChar).Value = TextBox7.Text
                    da.SelectCommand.Parameters.Add("@indicgrales", SqlDbType.VarChar).Value = TextBox114.Text
                    da.SelectCommand.Parameters.Add("@estudiosgrales", SqlDbType.VarChar).Value = TextBox79.Text
                    da.SelectCommand.Parameters.Add("@tratamiento", SqlDbType.VarChar).Value = TextBox82.Text
                    da.SelectCommand.Parameters.Add("@medico", SqlDbType.VarChar).Value = Label8.Text

                    da.SelectCommand.ExecuteNonQuery()
                    con.Close()


                Catch ex As Exception

                End Try
            End If
            If DropDownList40.Text <> "--Seleccionar--" Then


                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    da = New SqlDataAdapter("modificagastro", con)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.SelectCommand.Parameters.Add("@folionota", SqlDbType.Int).Value = Session("numnota2")
                    da.SelectCommand.Parameters.Add("@pacienteid", SqlDbType.Int).Value = Session("Paciente")
                    da.SelectCommand.Parameters.Add("@fechamodif", SqlDbType.DateTime).Value = Label2.Text
                    da.SelectCommand.Parameters.Add("@genero", SqlDbType.VarChar).Value = DropDownList200.Text
                    da.SelectCommand.Parameters.Add("@diarrea", SqlDbType.VarChar).Value = DropDownList17.Text
                    da.SelectCommand.Parameters.Add("@hernias", SqlDbType.VarChar).Value = DropDownList21.Text
                    da.SelectCommand.Parameters.Add("@cancer", SqlDbType.VarChar).Value = DropDownList25.Text
                    da.SelectCommand.Parameters.Add("@estrenimiento", SqlDbType.VarChar).Value = DropDownList29.Text
                    da.SelectCommand.Parameters.Add("@cancerdigestivo", SqlDbType.VarChar).Value = DropDownList33.Text
                    da.SelectCommand.Parameters.Add("@colecistitis", SqlDbType.VarChar).Value = DropDownList37.Text
                    da.SelectCommand.Parameters.Add("@hipertension", SqlDbType.VarChar).Value = DropDownList41.Text
                    da.SelectCommand.Parameters.Add("@cardiopatia", SqlDbType.VarChar).Value = DropDownList45.Text
                    da.SelectCommand.Parameters.Add("@autoinmunes", SqlDbType.VarChar).Value = DropDownList49.Text
                    da.SelectCommand.Parameters.Add("@diabetes", SqlDbType.VarChar).Value = DropDownList53.Text
                    da.SelectCommand.Parameters.Add("@endocrinopatias", SqlDbType.VarChar).Value = DropDownList57.Text
                    da.SelectCommand.Parameters.Add("@otrosenf", SqlDbType.VarChar).Value = TextBox85.Text
                    da.SelectCommand.Parameters.Add("@otrosfam", SqlDbType.VarChar).Value = DropDownList168.Text
                    da.SelectCommand.Parameters.Add("@ocupacion", SqlDbType.VarChar).Value = TextBox91.Text
                    da.SelectCommand.Parameters.Add("@escolaridad", SqlDbType.VarChar).Value = DropDownList61.Text
                    da.SelectCommand.Parameters.Add("@actfis", SqlDbType.VarChar).Value = DropDownList64.Text
                    If DropDownList65.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@alergicos", SqlDbType.VarChar).Value = DropDownList65.Text
                    Else
                        da.SelectCommand.Parameters.Add("@alergicos", SqlDbType.VarChar).Value = TextBox94.Text
                    End If

                    da.SelectCommand.Parameters.Add("@cirugias", SqlDbType.VarChar).Value = TextBox97.Text
                    da.SelectCommand.Parameters.Add("@complicacionescirugias", SqlDbType.VarChar).Value = TextBox115.Text
                    If DropDownList66.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@transfusiones", SqlDbType.VarChar).Value = DropDownList66.Text
                    Else
                        da.SelectCommand.Parameters.Add("@transfusiones", SqlDbType.VarChar).Value = TextBox116.Text
                    End If
                    da.SelectCommand.Parameters.Add("@tiposangre", SqlDbType.VarChar).Value = DropDownList67.Text
                    If DropDownList68.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@fracturas", SqlDbType.VarChar).Value = DropDownList68.Text
                    Else
                        da.SelectCommand.Parameters.Add("@fracturas", SqlDbType.VarChar).Value = TextBox117.Text
                    End If
                    If DropDownList69.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@hospprevias", SqlDbType.VarChar).Value = DropDownList69.Text
                    Else
                        da.SelectCommand.Parameters.Add("@hospprevias", SqlDbType.VarChar).Value = TextBox118.Text
                    End If
                    If DropDownList169.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempohipertension", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientohipertension", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempohipertension", SqlDbType.VarChar).Value = TextBox148.Text
                        da.SelectCommand.Parameters.Add("@tratamientohipertension", SqlDbType.VarChar).Value = TextBox149.Text
                    End If
                    If DropDownList170.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoinsuficiencia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoinsuficiencia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoinsuficiencia", SqlDbType.VarChar).Value = TextBox150.Text
                        da.SelectCommand.Parameters.Add("@tratamientoinsuficiencia", SqlDbType.VarChar).Value = TextBox151.Text
                    End If
                    If DropDownList171.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempocardisq", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientocardisq", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempocardisq", SqlDbType.VarChar).Value = TextBox152.Text
                        da.SelectCommand.Parameters.Add("@tratamientocardisq", SqlDbType.VarChar).Value = TextBox153.Text
                    End If
                    If DropDownList172.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoevc", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoevc", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoevc", SqlDbType.VarChar).Value = TextBox154.Text
                        da.SelectCommand.Parameters.Add("@tratamientoevc", SqlDbType.VarChar).Value = TextBox155.Text
                    End If
                    If DropDownList173.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoinsufvenosa", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoinsufvenosa", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoinsufvenosa", SqlDbType.VarChar).Value = TextBox156.Text
                        da.SelectCommand.Parameters.Add("@tratamientoinsufvenosa", SqlDbType.VarChar).Value = TextBox157.Text
                    End If
                    If DropDownList174.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodiabetes", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientodiabetes", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodiabetes", SqlDbType.VarChar).Value = TextBox158.Text
                        da.SelectCommand.Parameters.Add("@tratamientodiabetes", SqlDbType.VarChar).Value = TextBox159.Text
                    End If
                    If DropDownList175.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodislipidemmia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientodislipidemmia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodislipidemmia", SqlDbType.VarChar).Value = TextBox160.Text
                        da.SelectCommand.Parameters.Add("@tratamientodislipidemmia", SqlDbType.VarChar).Value = TextBox161.Text
                    End If
                    If DropDownList176.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoobesidad", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoobesidad", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoobesidad", SqlDbType.VarChar).Value = TextBox162.Text
                        da.SelectCommand.Parameters.Add("@tratamientoobesidad", SqlDbType.VarChar).Value = TextBox163.Text
                    End If
                    If DropDownList177.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoenftiroidea", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoenftiroidea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoenftiroidea", SqlDbType.VarChar).Value = TextBox164.Text
                        da.SelectCommand.Parameters.Add("@tratamientoenftiroidea", SqlDbType.VarChar).Value = TextBox165.Text
                    End If
                    If DropDownList178.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempocancer", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientocancer", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempocancer", SqlDbType.VarChar).Value = TextBox166.Text
                        da.SelectCommand.Parameters.Add("@tratamientocancer", SqlDbType.VarChar).Value = TextBox167.Text
                    End If
                    If DropDownList179.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempotuberculosis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientotuberculosis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempotuberculosis", SqlDbType.VarChar).Value = TextBox168.Text
                        da.SelectCommand.Parameters.Add("@tratamientotuberculosis", SqlDbType.VarChar).Value = TextBox169.Text
                    End If
                    If DropDownList180.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoasma", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoasma", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoasma", SqlDbType.VarChar).Value = TextBox170.Text
                        da.SelectCommand.Parameters.Add("@tratamientoasma", SqlDbType.VarChar).Value = TextBox171.Text
                    End If
                    If DropDownList181.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoepoc", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoepoc", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoepoc", SqlDbType.VarChar).Value = TextBox172.Text
                        da.SelectCommand.Parameters.Add("@tratamientoepoc", SqlDbType.VarChar).Value = TextBox173.Text
                    End If
                    If DropDownList182.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempobronquitis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientobronquitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempobronquitis", SqlDbType.VarChar).Value = TextBox174.Text
                        da.SelectCommand.Parameters.Add("@tratamientobronquitis", SqlDbType.VarChar).Value = TextBox175.Text
                    End If
                    If TextBox176.Text = "" Then
                        da.SelectCommand.Parameters.Add("@otraenf", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tiempootraenf", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientootraenf", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@otraenf", SqlDbType.VarChar).Value = TextBox176.Text
                        da.SelectCommand.Parameters.Add("@tiempootraenf", SqlDbType.VarChar).Value = TextBox177.Text
                        da.SelectCommand.Parameters.Add("@tratamientootraenf", SqlDbType.VarChar).Value = TextBox178.Text
                    End If
                    If DropDownList84.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoalcoholismo", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantalcoholismo", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoalcoholismo", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@cantalcoholismo", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If DropDownList85.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempotabaquismo", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@canttabaquismo", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempotabaquismo", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@canttabaquismo", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If DropDownList86.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodrogas", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantdrogas", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodrogas", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@cantdrogas", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If TextBox185.Text = "" Then
                        da.SelectCommand.Parameters.Add("@otrotox", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tiempootrotox", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantotrotox", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@otrotox", SqlDbType.VarChar).Value = TextBox185.Text
                        da.SelectCommand.Parameters.Add("@tiempootrotox", SqlDbType.VarChar).Value = TextBox186.Text
                        da.SelectCommand.Parameters.Add("@cantotrotox", SqlDbType.VarChar).Value = TextBox187.Text
                    End If
                        da.SelectCommand.Parameters.Add("@ultregla", SqlDbType.Date).Value = DBNull.Value
                    
                    da.SelectCommand.Parameters.Add("@ritmo", SqlDbType.VarChar).Value = TextBox124.Text
                    da.SelectCommand.Parameters.Add("@menopausia", SqlDbType.VarChar).Value = DropDownList87.Text
                    da.SelectCommand.Parameters.Add("@gesta", SqlDbType.Int).Value = DropDownList88.Text
                    da.SelectCommand.Parameters.Add("@para", SqlDbType.Int).Value = DropDownList89.Text
                    da.SelectCommand.Parameters.Add("@cesarea", SqlDbType.Int).Value = DropDownList90.Text
                    da.SelectCommand.Parameters.Add("@aborto", SqlDbType.Int).Value = DropDownList91.Text
                    da.SelectCommand.Parameters.Add("@metplanfam", SqlDbType.VarChar).Value = DropDownList92.Text
                    da.SelectCommand.Parameters.Add("@otroplanfam", SqlDbType.VarChar).Value = TextBox125.Text
                    If DropDownList93.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempofiebre", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionfiebre", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempofiebre", SqlDbType.VarChar).Value = TextBox188.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionfiebre", SqlDbType.VarChar).Value = TextBox189.Text
                    End If
                    If DropDownList94.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoastenia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionastenia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoastenia", SqlDbType.VarChar).Value = TextBox191.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionastenia", SqlDbType.VarChar).Value = TextBox192.Text
                    End If
                    If DropDownList95.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoadinamia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionadinamia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoadinamia", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionadinamia", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList96.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoanorexia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionanorexia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoanorexia", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionanorexia", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList97.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoperdidapeso", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionperdidapeso", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoperdidapeso", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionperdidapeso", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList98.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@obstruccionnasal", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@obstruccionnasal", SqlDbType.VarChar).Value = DropDownList183.Text
                    End If
                    If DropDownList99.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@ronqueramatutina", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@ronqueramatutina", SqlDbType.VarChar).Value = DropDownList184.Text
                    End If
                    If DropDownList100.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@sinusitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@sinusitis", SqlDbType.VarChar).Value = DropDownList185.Text
                    End If
                    If DropDownList101.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@disfonia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@disfonia", SqlDbType.VarChar).Value = DropDownList186.Text
                    End If
                    If DropDownList102.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@disnea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@disnea", SqlDbType.VarChar).Value = DropDownList187.Text
                    End If
                    If DropDownList103.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@sibilancias", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@sibilancias", SqlDbType.VarChar).Value = DropDownList188.Text
                    End If
                    If DropDownList104.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tos", SqlDbType.VarChar).Value = DropDownList189.Text
                    End If
                    If DropDownList105.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@cianosis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@cianosis", SqlDbType.VarChar).Value = DropDownList190.Text
                    End If
                    If DropDownList106.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@asma", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@asma", SqlDbType.VarChar).Value = DropDownList191.Text
                    End If
                    If DropDownList107.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorolipotimia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacioneslipotimia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorolipotimia", SqlDbType.VarChar).Value = DropDownList192.Text
                        da.SelectCommand.Parameters.Add("@sensacioneslipotimia", SqlDbType.VarChar).Value = TextBox203.Text
                    End If
                    If DropDownList108.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorosincope", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionessincope", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorosincope", SqlDbType.VarChar).Value = DropDownList193.Text
                        da.SelectCommand.Parameters.Add("@sensacionessincope", SqlDbType.VarChar).Value = TextBox204.Text
                    End If
                    If DropDownList109.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorofatiga", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesfatiga", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorofatiga", SqlDbType.VarChar).Value = DropDownList194.Text
                        da.SelectCommand.Parameters.Add("@sensacionesfatiga", SqlDbType.VarChar).Value = TextBox205.Text
                    End If
                    If DropDownList110.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoropalpitaciones", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionespalpitaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoropalpitaciones", SqlDbType.VarChar).Value = DropDownList195.Text
                        da.SelectCommand.Parameters.Add("@sensacionespalpitaciones", SqlDbType.VarChar).Value = TextBox206.Text
                    End If
                    If DropDownList111.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorodolprecordial", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesdolprecordial", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorodolprecordial", SqlDbType.VarChar).Value = DropDownList196.Text
                        da.SelectCommand.Parameters.Add("@sensacionesdolprecordial", SqlDbType.VarChar).Value = TextBox207.Text
                    End If
                    If DropDownList112.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoroedema", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesedema", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoroedema", SqlDbType.VarChar).Value = DropDownList197.Text
                        da.SelectCommand.Parameters.Add("@sensacionesedema", SqlDbType.VarChar).Value = TextBox208.Text
                    End If
                    If DropDownList113.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorodisnea", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesdisnea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorodisnea", SqlDbType.VarChar).Value = DropDownList198.Text
                        da.SelectCommand.Parameters.Add("@sensacionesdisnea", SqlDbType.VarChar).Value = TextBox209.Text
                    End If
                    If DropDownList114.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoroascitis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesascitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoroascitis", SqlDbType.VarChar).Value = DropDownList199.Text
                        da.SelectCommand.Parameters.Add("@sensacionesascitis", SqlDbType.VarChar).Value = TextBox210.Text
                    End If
                    da.SelectCommand.Parameters.Add("@disuria", SqlDbType.VarChar).Value = DropDownList138.Text
                    da.SelectCommand.Parameters.Add("@poliaquiuria", SqlDbType.VarChar).Value = DropDownList139.Text
                    da.SelectCommand.Parameters.Add("@tenesmo", SqlDbType.VarChar).Value = DropDownList140.Text
                    da.SelectCommand.Parameters.Add("@hematuria", SqlDbType.VarChar).Value = DropDownList141.Text
                    da.SelectCommand.Parameters.Add("@suprapubica", SqlDbType.VarChar).Value = DropDownList142.Text
                    da.SelectCommand.Parameters.Add("@lumbar", SqlDbType.VarChar).Value = DropDownList143.Text
                    da.SelectCommand.Parameters.Add("@ninguno", SqlDbType.VarChar).Value = DropDownList144.Text
                    da.SelectCommand.Parameters.Add("@otrosdolores", SqlDbType.VarChar).Value = TextBox131.Text
                    da.SelectCommand.Parameters.Add("@tendenciahemorragia", SqlDbType.VarChar).Value = DropDownList145.Text
                    da.SelectCommand.Parameters.Add("@adenopatias", SqlDbType.VarChar).Value = DropDownList146.Text
                    da.SelectCommand.Parameters.Add("@infecrecurrentes", SqlDbType.VarChar).Value = DropDownList147.Text
                    da.SelectCommand.Parameters.Add("@anemia", SqlDbType.VarChar).Value = DropDownList148.Text
                    da.SelectCommand.Parameters.Add("@hemolinfaticonegado", SqlDbType.VarChar).Value = DropDownList149.Text
                    da.SelectCommand.Parameters.Add("@otroshemolinf", SqlDbType.VarChar).Value = TextBox132.Text
                    da.SelectCommand.Parameters.Add("@paralisis", SqlDbType.VarChar).Value = DropDownList150.Text
                    da.SelectCommand.Parameters.Add("@parestesisas", SqlDbType.VarChar).Value = DropDownList151.Text
                    da.SelectCommand.Parameters.Add("@temblores", SqlDbType.VarChar).Value = DropDownList152.Text
                    da.SelectCommand.Parameters.Add("@alteracionesmarcha", SqlDbType.VarChar).Value = DropDownList153.Text
                    da.SelectCommand.Parameters.Add("@cefalea", SqlDbType.VarChar).Value = DropDownList154.Text
                    da.SelectCommand.Parameters.Add("@sisnerviosonegado", SqlDbType.VarChar).Value = DropDownList155.Text
                    da.SelectCommand.Parameters.Add("@otrossisnerv", SqlDbType.VarChar).Value = TextBox133.Text
                    da.SelectCommand.Parameters.Add("@padactual", SqlDbType.VarChar).Value = TextBox1.Text
                    da.SelectCommand.Parameters.Add("@motivoconsulta", SqlDbType.VarChar).Value = TextBox12.Text
                    da.SelectCommand.Parameters.Add("@region", SqlDbType.VarChar).Value = TextBox13.Text
                    da.SelectCommand.Parameters.Add("@inicia", SqlDbType.VarChar).Value = TextBox14.Text
                    da.SelectCommand.Parameters.Add("@irradiacion", SqlDbType.VarChar).Value = TextBox15.Text
                    da.SelectCommand.Parameters.Add("@migracion", SqlDbType.VarChar).Value = TextBox16.Text
                    da.SelectCommand.Parameters.Add("@expansion", SqlDbType.VarChar).Value = TextBox17.Text
                    da.SelectCommand.Parameters.Add("@proyeccion", SqlDbType.VarChar).Value = TextBox18.Text
                    da.SelectCommand.Parameters.Add("@semejanzacualitativos", SqlDbType.VarChar).Value = TextBox19.Text
                    If DropDownList1.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@localizacioncualitativos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@localizacioncualitativos", SqlDbType.VarChar).Value = DropDownList1.Text
                    End If
                    da.SelectCommand.Parameters.Add("@intensidadcuantitativos", SqlDbType.VarChar).Value = TextBox20.Text
                    da.SelectCommand.Parameters.Add("@maximaintensidadcuantitativos", SqlDbType.VarChar).Value = TextBox21.Text
                    da.SelectCommand.Parameters.Add("@intensidadultimoevento", SqlDbType.VarChar).Value = TextBox22.Text
                    da.SelectCommand.Parameters.Add("@iniciocronologicos", SqlDbType.VarChar).Value = TextBox23.Text
                    If DropDownList2.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patroncronologicos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patroncronologicos", SqlDbType.VarChar).Value = DropDownList2.Text
                    End If
                    da.SelectCommand.Parameters.Add("@duracion", SqlDbType.VarChar).Value = TextBox24.Text
                    da.SelectCommand.Parameters.Add("@frecuenciadia", SqlDbType.VarChar).Value = TextBox25.Text
                    da.SelectCommand.Parameters.Add("@frecuenciamensual", SqlDbType.VarChar).Value = TextBox26.Text
                    da.SelectCommand.Parameters.Add("@ultimoevento", SqlDbType.VarChar).Value = TextBox27.Text
                    If DropDownList3.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patrondia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patrondia", SqlDbType.VarChar).Value = DropDownList3.Text
                    End If
                    If DropDownList4.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronayuno", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronayuno", SqlDbType.VarChar).Value = DropDownList4.Text
                    End If
                    If DropDownList5.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronevacuaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronevacuaciones", SqlDbType.VarChar).Value = DropDownList5.Text
                    End If
                    da.SelectCommand.Parameters.Add("@patronevacuaciones2", SqlDbType.VarChar).Value = TextBox28.Text
                    da.SelectCommand.Parameters.Add("@patrongases", SqlDbType.VarChar).Value = TextBox29.Text
                    da.SelectCommand.Parameters.Add("@patronvomito", SqlDbType.VarChar).Value = TextBox30.Text
                    da.SelectCommand.Parameters.Add("@aumentaintesidad", SqlDbType.VarChar).Value = TextBox33.Text
                    da.SelectCommand.Parameters.Add("@disminuyeintensidad", SqlDbType.VarChar).Value = TextBox33.Text
                    da.SelectCommand.Parameters.Add("@alimdisminuyen", SqlDbType.VarChar).Value = TextBox35.Text
                    If DropDownList7.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@evacuaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@evacuaciones", SqlDbType.VarChar).Value = DropDownList7.Text
                    End If
                    If DropDownList8.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@canalizacionesgases", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@canalizacionesgases", SqlDbType.VarChar).Value = DropDownList8.Text
                    End If
                    If DropDownList9.Text = "-Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@eructos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@eructos", SqlDbType.VarChar).Value = DropDownList9.Text
                    End If
                    da.SelectCommand.Parameters.Add("@medicamcalman", SqlDbType.VarChar).Value = TextBox32.Text
                    da.SelectCommand.Parameters.Add("@medicamnocontrolan", SqlDbType.VarChar).Value = TextBox31.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional1", SqlDbType.VarChar).Value = TextBox36.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional2", SqlDbType.VarChar).Value = TextBox37.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional3", SqlDbType.VarChar).Value = TextBox38.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional4", SqlDbType.VarChar).Value = TextBox39.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre1", SqlDbType.VarChar).Value = TextBox40.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre2", SqlDbType.VarChar).Value = TextBox41.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre3", SqlDbType.VarChar).Value = TextBox42.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre4", SqlDbType.VarChar).Value = TextBox43.Text
                    da.SelectCommand.Parameters.Add("@sintomanodolor", SqlDbType.VarChar).Value = TextBox44.Text
                    da.SelectCommand.Parameters.Add("@inicionodolor", SqlDbType.VarChar).Value = TextBox2.Text
                    If DropDownList6.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronnodolor", SqlDbType.VarChar).Value = DropDownList6.Text
                    End If
                    da.SelectCommand.Parameters.Add("@duracionnodolor", SqlDbType.VarChar).Value = TextBox3.Text
                    da.SelectCommand.Parameters.Add("@frecuenciadianodolor", SqlDbType.VarChar).Value = TextBox4.Text
                    da.SelectCommand.Parameters.Add("@frecuenciamesnodolor", SqlDbType.VarChar).Value = TextBox5.Text
                    da.SelectCommand.Parameters.Add("@ulteventonodolor", SqlDbType.VarChar).Value = TextBox6.Text
                    If DropDownList10.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patrondianodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patrondianodolor", SqlDbType.VarChar).Value = DropDownList10.Text
                    End If
                    If DropDownList11.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronayunonodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronayunonodolor", SqlDbType.VarChar).Value = DropDownList11.Text
                    End If
                    If DropDownList12.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronevacnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronevacnodolor", SqlDbType.VarChar).Value = DropDownList12.Text
                    End If
                    da.SelectCommand.Parameters.Add("@patrongasesnodolor", SqlDbType.VarChar).Value = TextBox46.Text
                    da.SelectCommand.Parameters.Add("@patronvomitonodolor", SqlDbType.VarChar).Value = TextBox45.Text
                    da.SelectCommand.Parameters.Add("@aumentaintensnodolor", SqlDbType.VarChar).Value = TextBox47.Text
                    da.SelectCommand.Parameters.Add("@disminuyeintensnodolor", SqlDbType.VarChar).Value = TextBox48.Text
                    da.SelectCommand.Parameters.Add("@alimprovocannodolor", SqlDbType.VarChar).Value = TextBox49.Text
                    da.SelectCommand.Parameters.Add("@alimdisminuyennodolor", SqlDbType.VarChar).Value = TextBox50.Text
                    If DropDownList13.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@evacnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@evacnodolor", SqlDbType.VarChar).Value = DropDownList13.Text
                    End If
                    If DropDownList14.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@canalizgasesnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@canalizgasesnodolor", SqlDbType.VarChar).Value = DropDownList14.Text
                    End If
                    If DropDownList15.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@eructosnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@eructosnodolor", SqlDbType.VarChar).Value = DropDownList15.Text
                    End If
                    da.SelectCommand.Parameters.Add("@medicamcalmannodolor", SqlDbType.VarChar).Value = TextBox51.Text
                    da.SelectCommand.Parameters.Add("@mednocontrolannodolor", SqlDbType.VarChar).Value = TextBox52.Text
                    da.SelectCommand.Parameters.Add("@peso", SqlDbType.VarChar).Value = TextBox53.Text
                    da.SelectCommand.Parameters.Add("@talla", SqlDbType.VarChar).Value = TextBox54.Text
                    da.SelectCommand.Parameters.Add("@temp", SqlDbType.VarChar).Value = TextBox55.Text
                    da.SelectCommand.Parameters.Add("@ta", SqlDbType.VarChar).Value = TextBox56.Text
                    da.SelectCommand.Parameters.Add("@tc", SqlDbType.VarChar).Value = TextBox57.Text
                    da.SelectCommand.Parameters.Add("@fr", SqlDbType.VarChar).Value = TextBox58.Text
                    da.SelectCommand.Parameters.Add("@cabeza", SqlDbType.VarChar).Value = TextBox59.Text
                    da.SelectCommand.Parameters.Add("@torax", SqlDbType.VarChar).Value = TextBox60.Text
                    da.SelectCommand.Parameters.Add("@abdomen", SqlDbType.VarChar).Value = TextBox61.Text
                    da.SelectCommand.Parameters.Add("@extremidades", SqlDbType.VarChar).Value = TextBox62.Text
                    da.SelectCommand.Parameters.Add("@estudios", SqlDbType.VarChar).Value = TextBox63.Text
                    da.SelectCommand.Parameters.Add("@regionanalisis", SqlDbType.VarChar).Value = DropDownList40.Text
                    For Each li As ListItem In CheckBoxList7.Items
                        If li.Selected Then
                            If sintanalisis7.Length = 0 Then
                                sintanalisis7 = li.Value
                            Else
                                sintanalisis7 += ", " + li.Value
                            End If
                        End If
                    Next
                    If TextBox108.Text <> "" Then
                        sintanalisis7 += ", " + TextBox108.Text
                    End If
                    da.SelectCommand.Parameters.Add("@sintomaanalisis", SqlDbType.VarChar).Value = sintanalisis7
                    If TextBox83.Visible = True Then
                        da.SelectCommand.Parameters.Add("@sindromeclin", SqlDbType.VarChar).Value = TextBox83.Text
                    Else
                        da.SelectCommand.Parameters.Add("@sindromeclin", SqlDbType.VarChar).Value = DropDownList46.Text
                    End If
                    If TextBox84.Visible = True Then
                        da.SelectCommand.Parameters.Add("@subtipoanalisis", SqlDbType.VarChar).Value = TextBox84.Text
                    Else
                        da.SelectCommand.Parameters.Add("@subtipoanalisis", SqlDbType.VarChar).Value = DropDownList43.Text
                    End If
                    da.SelectCommand.Parameters.Add("@analisis", SqlDbType.VarChar).Value = TextBox100.Text
                    da.SelectCommand.Parameters.Add("@diagnostico", SqlDbType.VarChar).Value = TextBox7.Text
                    da.SelectCommand.Parameters.Add("@indicgrales", SqlDbType.VarChar).Value = TextBox114.Text
                    da.SelectCommand.Parameters.Add("@estudiosgrales", SqlDbType.VarChar).Value = TextBox79.Text
                    da.SelectCommand.Parameters.Add("@tratamiento", SqlDbType.VarChar).Value = TextBox82.Text
                    da.SelectCommand.Parameters.Add("@medico", SqlDbType.VarChar).Value = Label8.Text

                    da.SelectCommand.ExecuteNonQuery()
                    con.Close()


                Catch ex As Exception

                End Try
            End If

            If DropDownList44.Text <> "--Seleccionar--" Then


                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    da = New SqlDataAdapter("modificagastro", con)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.SelectCommand.Parameters.Add("@folionota", SqlDbType.Int).Value = Session("numnota2")
                    da.SelectCommand.Parameters.Add("@pacienteid", SqlDbType.Int).Value = Session("Paciente")
                    da.SelectCommand.Parameters.Add("@fechamodif", SqlDbType.DateTime).Value = Label2.Text
                    da.SelectCommand.Parameters.Add("@genero", SqlDbType.VarChar).Value = DropDownList200.Text
                    da.SelectCommand.Parameters.Add("@diarrea", SqlDbType.VarChar).Value = DropDownList17.Text
                    da.SelectCommand.Parameters.Add("@hernias", SqlDbType.VarChar).Value = DropDownList21.Text
                    da.SelectCommand.Parameters.Add("@cancer", SqlDbType.VarChar).Value = DropDownList25.Text
                    da.SelectCommand.Parameters.Add("@estrenimiento", SqlDbType.VarChar).Value = DropDownList29.Text
                    da.SelectCommand.Parameters.Add("@cancerdigestivo", SqlDbType.VarChar).Value = DropDownList33.Text
                    da.SelectCommand.Parameters.Add("@colecistitis", SqlDbType.VarChar).Value = DropDownList37.Text
                    da.SelectCommand.Parameters.Add("@hipertension", SqlDbType.VarChar).Value = DropDownList41.Text
                    da.SelectCommand.Parameters.Add("@cardiopatia", SqlDbType.VarChar).Value = DropDownList45.Text
                    da.SelectCommand.Parameters.Add("@autoinmunes", SqlDbType.VarChar).Value = DropDownList49.Text
                    da.SelectCommand.Parameters.Add("@diabetes", SqlDbType.VarChar).Value = DropDownList53.Text
                    da.SelectCommand.Parameters.Add("@endocrinopatias", SqlDbType.VarChar).Value = DropDownList57.Text
                    da.SelectCommand.Parameters.Add("@otrosenf", SqlDbType.VarChar).Value = TextBox85.Text
                    da.SelectCommand.Parameters.Add("@otrosfam", SqlDbType.VarChar).Value = DropDownList168.Text
                    da.SelectCommand.Parameters.Add("@ocupacion", SqlDbType.VarChar).Value = TextBox91.Text
                    da.SelectCommand.Parameters.Add("@escolaridad", SqlDbType.VarChar).Value = DropDownList61.Text
                    da.SelectCommand.Parameters.Add("@actfis", SqlDbType.VarChar).Value = DropDownList64.Text
                    If DropDownList65.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@alergicos", SqlDbType.VarChar).Value = DropDownList65.Text
                    Else
                        da.SelectCommand.Parameters.Add("@alergicos", SqlDbType.VarChar).Value = TextBox94.Text
                    End If

                    da.SelectCommand.Parameters.Add("@cirugias", SqlDbType.VarChar).Value = TextBox97.Text
                    da.SelectCommand.Parameters.Add("@complicacionescirugias", SqlDbType.VarChar).Value = TextBox115.Text
                    If DropDownList66.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@transfusiones", SqlDbType.VarChar).Value = DropDownList66.Text
                    Else
                        da.SelectCommand.Parameters.Add("@transfusiones", SqlDbType.VarChar).Value = TextBox116.Text
                    End If
                    da.SelectCommand.Parameters.Add("@tiposangre", SqlDbType.VarChar).Value = DropDownList67.Text
                    If DropDownList68.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@fracturas", SqlDbType.VarChar).Value = DropDownList68.Text
                    Else
                        da.SelectCommand.Parameters.Add("@fracturas", SqlDbType.VarChar).Value = TextBox117.Text
                    End If
                    If DropDownList69.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@hospprevias", SqlDbType.VarChar).Value = DropDownList69.Text
                    Else
                        da.SelectCommand.Parameters.Add("@hospprevias", SqlDbType.VarChar).Value = TextBox118.Text
                    End If
                    If DropDownList169.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempohipertension", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientohipertension", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempohipertension", SqlDbType.VarChar).Value = TextBox148.Text
                        da.SelectCommand.Parameters.Add("@tratamientohipertension", SqlDbType.VarChar).Value = TextBox149.Text
                    End If
                    If DropDownList170.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoinsuficiencia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoinsuficiencia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoinsuficiencia", SqlDbType.VarChar).Value = TextBox150.Text
                        da.SelectCommand.Parameters.Add("@tratamientoinsuficiencia", SqlDbType.VarChar).Value = TextBox151.Text
                    End If
                    If DropDownList171.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempocardisq", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientocardisq", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempocardisq", SqlDbType.VarChar).Value = TextBox152.Text
                        da.SelectCommand.Parameters.Add("@tratamientocardisq", SqlDbType.VarChar).Value = TextBox153.Text
                    End If
                    If DropDownList172.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoevc", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoevc", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoevc", SqlDbType.VarChar).Value = TextBox154.Text
                        da.SelectCommand.Parameters.Add("@tratamientoevc", SqlDbType.VarChar).Value = TextBox155.Text
                    End If
                    If DropDownList173.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoinsufvenosa", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoinsufvenosa", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoinsufvenosa", SqlDbType.VarChar).Value = TextBox156.Text
                        da.SelectCommand.Parameters.Add("@tratamientoinsufvenosa", SqlDbType.VarChar).Value = TextBox157.Text
                    End If
                    If DropDownList174.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodiabetes", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientodiabetes", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodiabetes", SqlDbType.VarChar).Value = TextBox158.Text
                        da.SelectCommand.Parameters.Add("@tratamientodiabetes", SqlDbType.VarChar).Value = TextBox159.Text
                    End If
                    If DropDownList175.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodislipidemmia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientodislipidemmia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodislipidemmia", SqlDbType.VarChar).Value = TextBox160.Text
                        da.SelectCommand.Parameters.Add("@tratamientodislipidemmia", SqlDbType.VarChar).Value = TextBox161.Text
                    End If
                    If DropDownList176.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoobesidad", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoobesidad", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoobesidad", SqlDbType.VarChar).Value = TextBox162.Text
                        da.SelectCommand.Parameters.Add("@tratamientoobesidad", SqlDbType.VarChar).Value = TextBox163.Text
                    End If
                    If DropDownList177.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoenftiroidea", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoenftiroidea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoenftiroidea", SqlDbType.VarChar).Value = TextBox164.Text
                        da.SelectCommand.Parameters.Add("@tratamientoenftiroidea", SqlDbType.VarChar).Value = TextBox165.Text
                    End If
                    If DropDownList178.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempocancer", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientocancer", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempocancer", SqlDbType.VarChar).Value = TextBox166.Text
                        da.SelectCommand.Parameters.Add("@tratamientocancer", SqlDbType.VarChar).Value = TextBox167.Text
                    End If
                    If DropDownList179.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempotuberculosis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientotuberculosis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempotuberculosis", SqlDbType.VarChar).Value = TextBox168.Text
                        da.SelectCommand.Parameters.Add("@tratamientotuberculosis", SqlDbType.VarChar).Value = TextBox169.Text
                    End If
                    If DropDownList180.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoasma", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoasma", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoasma", SqlDbType.VarChar).Value = TextBox170.Text
                        da.SelectCommand.Parameters.Add("@tratamientoasma", SqlDbType.VarChar).Value = TextBox171.Text
                    End If
                    If DropDownList181.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoepoc", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoepoc", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoepoc", SqlDbType.VarChar).Value = TextBox172.Text
                        da.SelectCommand.Parameters.Add("@tratamientoepoc", SqlDbType.VarChar).Value = TextBox173.Text
                    End If
                    If DropDownList182.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempobronquitis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientobronquitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempobronquitis", SqlDbType.VarChar).Value = TextBox174.Text
                        da.SelectCommand.Parameters.Add("@tratamientobronquitis", SqlDbType.VarChar).Value = TextBox175.Text
                    End If
                    If TextBox176.Text = "" Then
                        da.SelectCommand.Parameters.Add("@otraenf", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tiempootraenf", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientootraenf", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@otraenf", SqlDbType.VarChar).Value = TextBox176.Text
                        da.SelectCommand.Parameters.Add("@tiempootraenf", SqlDbType.VarChar).Value = TextBox177.Text
                        da.SelectCommand.Parameters.Add("@tratamientootraenf", SqlDbType.VarChar).Value = TextBox178.Text
                    End If
                    If DropDownList84.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoalcoholismo", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantalcoholismo", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoalcoholismo", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@cantalcoholismo", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If DropDownList85.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempotabaquismo", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@canttabaquismo", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempotabaquismo", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@canttabaquismo", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If DropDownList86.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodrogas", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantdrogas", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodrogas", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@cantdrogas", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If TextBox185.Text = "" Then
                        da.SelectCommand.Parameters.Add("@otrotox", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tiempootrotox", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantotrotox", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@otrotox", SqlDbType.VarChar).Value = TextBox185.Text
                        da.SelectCommand.Parameters.Add("@tiempootrotox", SqlDbType.VarChar).Value = TextBox186.Text
                        da.SelectCommand.Parameters.Add("@cantotrotox", SqlDbType.VarChar).Value = TextBox187.Text
                    End If
                        da.SelectCommand.Parameters.Add("@ultregla", SqlDbType.Date).Value = DBNull.Value
                   
                    da.SelectCommand.Parameters.Add("@ritmo", SqlDbType.VarChar).Value = TextBox124.Text
                    da.SelectCommand.Parameters.Add("@menopausia", SqlDbType.VarChar).Value = DropDownList87.Text
                    da.SelectCommand.Parameters.Add("@gesta", SqlDbType.Int).Value = DropDownList88.Text
                    da.SelectCommand.Parameters.Add("@para", SqlDbType.Int).Value = DropDownList89.Text
                    da.SelectCommand.Parameters.Add("@cesarea", SqlDbType.Int).Value = DropDownList90.Text
                    da.SelectCommand.Parameters.Add("@aborto", SqlDbType.Int).Value = DropDownList91.Text
                    da.SelectCommand.Parameters.Add("@metplanfam", SqlDbType.VarChar).Value = DropDownList92.Text
                    da.SelectCommand.Parameters.Add("@otroplanfam", SqlDbType.VarChar).Value = TextBox125.Text
                    If DropDownList93.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempofiebre", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionfiebre", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempofiebre", SqlDbType.VarChar).Value = TextBox188.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionfiebre", SqlDbType.VarChar).Value = TextBox189.Text
                    End If
                    If DropDownList94.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoastenia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionastenia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoastenia", SqlDbType.VarChar).Value = TextBox191.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionastenia", SqlDbType.VarChar).Value = TextBox192.Text
                    End If
                    If DropDownList95.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoadinamia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionadinamia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoadinamia", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionadinamia", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList96.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoanorexia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionanorexia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoanorexia", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionanorexia", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList97.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoperdidapeso", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionperdidapeso", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoperdidapeso", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionperdidapeso", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList98.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@obstruccionnasal", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@obstruccionnasal", SqlDbType.VarChar).Value = DropDownList183.Text
                    End If
                    If DropDownList99.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@ronqueramatutina", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@ronqueramatutina", SqlDbType.VarChar).Value = DropDownList184.Text
                    End If
                    If DropDownList100.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@sinusitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@sinusitis", SqlDbType.VarChar).Value = DropDownList185.Text
                    End If
                    If DropDownList101.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@disfonia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@disfonia", SqlDbType.VarChar).Value = DropDownList186.Text
                    End If
                    If DropDownList102.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@disnea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@disnea", SqlDbType.VarChar).Value = DropDownList187.Text
                    End If
                    If DropDownList103.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@sibilancias", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@sibilancias", SqlDbType.VarChar).Value = DropDownList188.Text
                    End If
                    If DropDownList104.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tos", SqlDbType.VarChar).Value = DropDownList189.Text
                    End If
                    If DropDownList105.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@cianosis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@cianosis", SqlDbType.VarChar).Value = DropDownList190.Text
                    End If
                    If DropDownList106.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@asma", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@asma", SqlDbType.VarChar).Value = DropDownList191.Text
                    End If
                    If DropDownList107.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorolipotimia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacioneslipotimia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorolipotimia", SqlDbType.VarChar).Value = DropDownList192.Text
                        da.SelectCommand.Parameters.Add("@sensacioneslipotimia", SqlDbType.VarChar).Value = TextBox203.Text
                    End If
                    If DropDownList108.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorosincope", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionessincope", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorosincope", SqlDbType.VarChar).Value = DropDownList193.Text
                        da.SelectCommand.Parameters.Add("@sensacionessincope", SqlDbType.VarChar).Value = TextBox204.Text
                    End If
                    If DropDownList109.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorofatiga", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesfatiga", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorofatiga", SqlDbType.VarChar).Value = DropDownList194.Text
                        da.SelectCommand.Parameters.Add("@sensacionesfatiga", SqlDbType.VarChar).Value = TextBox205.Text
                    End If
                    If DropDownList110.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoropalpitaciones", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionespalpitaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoropalpitaciones", SqlDbType.VarChar).Value = DropDownList195.Text
                        da.SelectCommand.Parameters.Add("@sensacionespalpitaciones", SqlDbType.VarChar).Value = TextBox206.Text
                    End If
                    If DropDownList111.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorodolprecordial", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesdolprecordial", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorodolprecordial", SqlDbType.VarChar).Value = DropDownList196.Text
                        da.SelectCommand.Parameters.Add("@sensacionesdolprecordial", SqlDbType.VarChar).Value = TextBox207.Text
                    End If
                    If DropDownList112.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoroedema", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesedema", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoroedema", SqlDbType.VarChar).Value = DropDownList197.Text
                        da.SelectCommand.Parameters.Add("@sensacionesedema", SqlDbType.VarChar).Value = TextBox208.Text
                    End If
                    If DropDownList113.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorodisnea", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesdisnea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorodisnea", SqlDbType.VarChar).Value = DropDownList198.Text
                        da.SelectCommand.Parameters.Add("@sensacionesdisnea", SqlDbType.VarChar).Value = TextBox209.Text
                    End If
                    If DropDownList114.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoroascitis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesascitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoroascitis", SqlDbType.VarChar).Value = DropDownList199.Text
                        da.SelectCommand.Parameters.Add("@sensacionesascitis", SqlDbType.VarChar).Value = TextBox210.Text
                    End If
                    da.SelectCommand.Parameters.Add("@disuria", SqlDbType.VarChar).Value = DropDownList138.Text
                    da.SelectCommand.Parameters.Add("@poliaquiuria", SqlDbType.VarChar).Value = DropDownList139.Text
                    da.SelectCommand.Parameters.Add("@tenesmo", SqlDbType.VarChar).Value = DropDownList140.Text
                    da.SelectCommand.Parameters.Add("@hematuria", SqlDbType.VarChar).Value = DropDownList141.Text
                    da.SelectCommand.Parameters.Add("@suprapubica", SqlDbType.VarChar).Value = DropDownList142.Text
                    da.SelectCommand.Parameters.Add("@lumbar", SqlDbType.VarChar).Value = DropDownList143.Text
                    da.SelectCommand.Parameters.Add("@ninguno", SqlDbType.VarChar).Value = DropDownList144.Text
                    da.SelectCommand.Parameters.Add("@otrosdolores", SqlDbType.VarChar).Value = TextBox131.Text
                    da.SelectCommand.Parameters.Add("@tendenciahemorragia", SqlDbType.VarChar).Value = DropDownList145.Text
                    da.SelectCommand.Parameters.Add("@adenopatias", SqlDbType.VarChar).Value = DropDownList146.Text
                    da.SelectCommand.Parameters.Add("@infecrecurrentes", SqlDbType.VarChar).Value = DropDownList147.Text
                    da.SelectCommand.Parameters.Add("@anemia", SqlDbType.VarChar).Value = DropDownList148.Text
                    da.SelectCommand.Parameters.Add("@hemolinfaticonegado", SqlDbType.VarChar).Value = DropDownList149.Text
                    da.SelectCommand.Parameters.Add("@otroshemolinf", SqlDbType.VarChar).Value = TextBox132.Text
                    da.SelectCommand.Parameters.Add("@paralisis", SqlDbType.VarChar).Value = DropDownList150.Text
                    da.SelectCommand.Parameters.Add("@parestesisas", SqlDbType.VarChar).Value = DropDownList151.Text
                    da.SelectCommand.Parameters.Add("@temblores", SqlDbType.VarChar).Value = DropDownList152.Text
                    da.SelectCommand.Parameters.Add("@alteracionesmarcha", SqlDbType.VarChar).Value = DropDownList153.Text
                    da.SelectCommand.Parameters.Add("@cefalea", SqlDbType.VarChar).Value = DropDownList154.Text
                    da.SelectCommand.Parameters.Add("@sisnerviosonegado", SqlDbType.VarChar).Value = DropDownList155.Text
                    da.SelectCommand.Parameters.Add("@otrossisnerv", SqlDbType.VarChar).Value = TextBox133.Text
                    da.SelectCommand.Parameters.Add("@padactual", SqlDbType.VarChar).Value = TextBox1.Text
                    da.SelectCommand.Parameters.Add("@motivoconsulta", SqlDbType.VarChar).Value = TextBox12.Text
                    da.SelectCommand.Parameters.Add("@region", SqlDbType.VarChar).Value = TextBox13.Text
                    da.SelectCommand.Parameters.Add("@inicia", SqlDbType.VarChar).Value = TextBox14.Text
                    da.SelectCommand.Parameters.Add("@irradiacion", SqlDbType.VarChar).Value = TextBox15.Text
                    da.SelectCommand.Parameters.Add("@migracion", SqlDbType.VarChar).Value = TextBox16.Text
                    da.SelectCommand.Parameters.Add("@expansion", SqlDbType.VarChar).Value = TextBox17.Text
                    da.SelectCommand.Parameters.Add("@proyeccion", SqlDbType.VarChar).Value = TextBox18.Text
                    da.SelectCommand.Parameters.Add("@semejanzacualitativos", SqlDbType.VarChar).Value = TextBox19.Text
                    If DropDownList1.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@localizacioncualitativos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@localizacioncualitativos", SqlDbType.VarChar).Value = DropDownList1.Text
                    End If
                    da.SelectCommand.Parameters.Add("@intensidadcuantitativos", SqlDbType.VarChar).Value = TextBox20.Text
                    da.SelectCommand.Parameters.Add("@maximaintensidadcuantitativos", SqlDbType.VarChar).Value = TextBox21.Text
                    da.SelectCommand.Parameters.Add("@intensidadultimoevento", SqlDbType.VarChar).Value = TextBox22.Text
                    da.SelectCommand.Parameters.Add("@iniciocronologicos", SqlDbType.VarChar).Value = TextBox23.Text
                    If DropDownList2.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patroncronologicos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patroncronologicos", SqlDbType.VarChar).Value = DropDownList2.Text
                    End If
                    da.SelectCommand.Parameters.Add("@duracion", SqlDbType.VarChar).Value = TextBox24.Text
                    da.SelectCommand.Parameters.Add("@frecuenciadia", SqlDbType.VarChar).Value = TextBox25.Text
                    da.SelectCommand.Parameters.Add("@frecuenciamensual", SqlDbType.VarChar).Value = TextBox26.Text
                    da.SelectCommand.Parameters.Add("@ultimoevento", SqlDbType.VarChar).Value = TextBox27.Text
                    If DropDownList3.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patrondia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patrondia", SqlDbType.VarChar).Value = DropDownList3.Text
                    End If
                    If DropDownList4.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronayuno", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronayuno", SqlDbType.VarChar).Value = DropDownList4.Text
                    End If
                    If DropDownList5.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronevacuaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronevacuaciones", SqlDbType.VarChar).Value = DropDownList5.Text
                    End If
                    da.SelectCommand.Parameters.Add("@patronevacuaciones2", SqlDbType.VarChar).Value = TextBox28.Text
                    da.SelectCommand.Parameters.Add("@patrongases", SqlDbType.VarChar).Value = TextBox29.Text
                    da.SelectCommand.Parameters.Add("@patronvomito", SqlDbType.VarChar).Value = TextBox30.Text
                    da.SelectCommand.Parameters.Add("@aumentaintesidad", SqlDbType.VarChar).Value = TextBox33.Text
                    da.SelectCommand.Parameters.Add("@disminuyeintensidad", SqlDbType.VarChar).Value = TextBox33.Text
                    da.SelectCommand.Parameters.Add("@alimdisminuyen", SqlDbType.VarChar).Value = TextBox35.Text
                    If DropDownList7.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@evacuaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@evacuaciones", SqlDbType.VarChar).Value = DropDownList7.Text
                    End If
                    If DropDownList8.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@canalizacionesgases", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@canalizacionesgases", SqlDbType.VarChar).Value = DropDownList8.Text
                    End If
                    If DropDownList9.Text = "-Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@eructos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@eructos", SqlDbType.VarChar).Value = DropDownList9.Text
                    End If
                    da.SelectCommand.Parameters.Add("@medicamcalman", SqlDbType.VarChar).Value = TextBox32.Text
                    da.SelectCommand.Parameters.Add("@medicamnocontrolan", SqlDbType.VarChar).Value = TextBox31.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional1", SqlDbType.VarChar).Value = TextBox36.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional2", SqlDbType.VarChar).Value = TextBox37.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional3", SqlDbType.VarChar).Value = TextBox38.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional4", SqlDbType.VarChar).Value = TextBox39.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre1", SqlDbType.VarChar).Value = TextBox40.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre2", SqlDbType.VarChar).Value = TextBox41.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre3", SqlDbType.VarChar).Value = TextBox42.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre4", SqlDbType.VarChar).Value = TextBox43.Text
                    da.SelectCommand.Parameters.Add("@sintomanodolor", SqlDbType.VarChar).Value = TextBox44.Text
                    da.SelectCommand.Parameters.Add("@inicionodolor", SqlDbType.VarChar).Value = TextBox2.Text
                    If DropDownList6.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronnodolor", SqlDbType.VarChar).Value = DropDownList6.Text
                    End If
                    da.SelectCommand.Parameters.Add("@duracionnodolor", SqlDbType.VarChar).Value = TextBox3.Text
                    da.SelectCommand.Parameters.Add("@frecuenciadianodolor", SqlDbType.VarChar).Value = TextBox4.Text
                    da.SelectCommand.Parameters.Add("@frecuenciamesnodolor", SqlDbType.VarChar).Value = TextBox5.Text
                    da.SelectCommand.Parameters.Add("@ulteventonodolor", SqlDbType.VarChar).Value = TextBox6.Text
                    If DropDownList10.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patrondianodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patrondianodolor", SqlDbType.VarChar).Value = DropDownList10.Text
                    End If
                    If DropDownList11.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronayunonodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronayunonodolor", SqlDbType.VarChar).Value = DropDownList11.Text
                    End If
                    If DropDownList12.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronevacnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronevacnodolor", SqlDbType.VarChar).Value = DropDownList12.Text
                    End If
                    da.SelectCommand.Parameters.Add("@patrongasesnodolor", SqlDbType.VarChar).Value = TextBox46.Text
                    da.SelectCommand.Parameters.Add("@patronvomitonodolor", SqlDbType.VarChar).Value = TextBox45.Text
                    da.SelectCommand.Parameters.Add("@aumentaintensnodolor", SqlDbType.VarChar).Value = TextBox47.Text
                    da.SelectCommand.Parameters.Add("@disminuyeintensnodolor", SqlDbType.VarChar).Value = TextBox48.Text
                    da.SelectCommand.Parameters.Add("@alimprovocannodolor", SqlDbType.VarChar).Value = TextBox49.Text
                    da.SelectCommand.Parameters.Add("@alimdisminuyennodolor", SqlDbType.VarChar).Value = TextBox50.Text
                    If DropDownList13.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@evacnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@evacnodolor", SqlDbType.VarChar).Value = DropDownList13.Text
                    End If
                    If DropDownList14.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@canalizgasesnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@canalizgasesnodolor", SqlDbType.VarChar).Value = DropDownList14.Text
                    End If
                    If DropDownList15.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@eructosnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@eructosnodolor", SqlDbType.VarChar).Value = DropDownList15.Text
                    End If
                    da.SelectCommand.Parameters.Add("@medicamcalmannodolor", SqlDbType.VarChar).Value = TextBox51.Text
                    da.SelectCommand.Parameters.Add("@mednocontrolannodolor", SqlDbType.VarChar).Value = TextBox52.Text
                    da.SelectCommand.Parameters.Add("@peso", SqlDbType.VarChar).Value = TextBox53.Text
                    da.SelectCommand.Parameters.Add("@talla", SqlDbType.VarChar).Value = TextBox54.Text
                    da.SelectCommand.Parameters.Add("@temp", SqlDbType.VarChar).Value = TextBox55.Text
                    da.SelectCommand.Parameters.Add("@ta", SqlDbType.VarChar).Value = TextBox56.Text
                    da.SelectCommand.Parameters.Add("@tc", SqlDbType.VarChar).Value = TextBox57.Text
                    da.SelectCommand.Parameters.Add("@fr", SqlDbType.VarChar).Value = TextBox58.Text
                    da.SelectCommand.Parameters.Add("@cabeza", SqlDbType.VarChar).Value = TextBox59.Text
                    da.SelectCommand.Parameters.Add("@torax", SqlDbType.VarChar).Value = TextBox60.Text
                    da.SelectCommand.Parameters.Add("@abdomen", SqlDbType.VarChar).Value = TextBox61.Text
                    da.SelectCommand.Parameters.Add("@extremidades", SqlDbType.VarChar).Value = TextBox62.Text
                    da.SelectCommand.Parameters.Add("@estudios", SqlDbType.VarChar).Value = TextBox63.Text
                    da.SelectCommand.Parameters.Add("@regionanalisis", SqlDbType.VarChar).Value = DropDownList44.Text
                    For Each li As ListItem In CheckBoxList8.Items
                        If li.Selected Then
                            If sintanalisis8.Length = 0 Then
                                sintanalisis8 = li.Value
                            Else
                                sintanalisis8 += ", " + li.Value
                            End If
                        End If
                    Next
                    If TextBox109.Text <> "" Then
                        sintanalisis8 += ", " + TextBox109.Text
                    End If
                    da.SelectCommand.Parameters.Add("@sintomaanalisis", SqlDbType.VarChar).Value = sintanalisis8
                    If TextBox86.Visible = True Then
                        da.SelectCommand.Parameters.Add("@sindromeclin", SqlDbType.VarChar).Value = TextBox86.Text
                    Else
                        da.SelectCommand.Parameters.Add("@sindromeclin", SqlDbType.VarChar).Value = DropDownList46.Text
                    End If
                    If TextBox87.Visible = True Then
                        da.SelectCommand.Parameters.Add("@subtipoanalisis", SqlDbType.VarChar).Value = TextBox87.Text
                    Else
                        da.SelectCommand.Parameters.Add("@subtipoanalisis", SqlDbType.VarChar).Value = DropDownList47.Text
                    End If
                    da.SelectCommand.Parameters.Add("@analisis", SqlDbType.VarChar).Value = TextBox100.Text
                    da.SelectCommand.Parameters.Add("@diagnostico", SqlDbType.VarChar).Value = TextBox7.Text
                    da.SelectCommand.Parameters.Add("@indicgrales", SqlDbType.VarChar).Value = TextBox114.Text
                    da.SelectCommand.Parameters.Add("@estudiosgrales", SqlDbType.VarChar).Value = TextBox79.Text
                    da.SelectCommand.Parameters.Add("@tratamiento", SqlDbType.VarChar).Value = TextBox82.Text
                    da.SelectCommand.Parameters.Add("@medico", SqlDbType.VarChar).Value = Label8.Text

                    da.SelectCommand.ExecuteNonQuery()
                    con.Close()


                Catch ex As Exception

                End Try
            End If
            If DropDownList48.Text <> "--Seleccionar--" Then


                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    da = New SqlDataAdapter("modificagastro", con)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.SelectCommand.Parameters.Add("@folionota", SqlDbType.Int).Value = Session("numnota2")
                    da.SelectCommand.Parameters.Add("@pacienteid", SqlDbType.Int).Value = Session("Paciente")
                    da.SelectCommand.Parameters.Add("@fechamodif", SqlDbType.DateTime).Value = Label2.Text
                    da.SelectCommand.Parameters.Add("@genero", SqlDbType.VarChar).Value = DropDownList200.Text
                    da.SelectCommand.Parameters.Add("@diarrea", SqlDbType.VarChar).Value = DropDownList17.Text
                    da.SelectCommand.Parameters.Add("@hernias", SqlDbType.VarChar).Value = DropDownList21.Text
                    da.SelectCommand.Parameters.Add("@cancer", SqlDbType.VarChar).Value = DropDownList25.Text
                    da.SelectCommand.Parameters.Add("@estrenimiento", SqlDbType.VarChar).Value = DropDownList29.Text
                    da.SelectCommand.Parameters.Add("@cancerdigestivo", SqlDbType.VarChar).Value = DropDownList33.Text
                    da.SelectCommand.Parameters.Add("@colecistitis", SqlDbType.VarChar).Value = DropDownList37.Text
                    da.SelectCommand.Parameters.Add("@hipertension", SqlDbType.VarChar).Value = DropDownList41.Text
                    da.SelectCommand.Parameters.Add("@cardiopatia", SqlDbType.VarChar).Value = DropDownList45.Text
                    da.SelectCommand.Parameters.Add("@autoinmunes", SqlDbType.VarChar).Value = DropDownList49.Text
                    da.SelectCommand.Parameters.Add("@diabetes", SqlDbType.VarChar).Value = DropDownList53.Text
                    da.SelectCommand.Parameters.Add("@endocrinopatias", SqlDbType.VarChar).Value = DropDownList57.Text
                    da.SelectCommand.Parameters.Add("@otrosenf", SqlDbType.VarChar).Value = TextBox85.Text
                    da.SelectCommand.Parameters.Add("@otrosfam", SqlDbType.VarChar).Value = DropDownList168.Text
                    da.SelectCommand.Parameters.Add("@ocupacion", SqlDbType.VarChar).Value = TextBox91.Text
                    da.SelectCommand.Parameters.Add("@escolaridad", SqlDbType.VarChar).Value = DropDownList61.Text
                    da.SelectCommand.Parameters.Add("@actfis", SqlDbType.VarChar).Value = DropDownList64.Text
                    If DropDownList65.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@alergicos", SqlDbType.VarChar).Value = DropDownList65.Text
                    Else
                        da.SelectCommand.Parameters.Add("@alergicos", SqlDbType.VarChar).Value = TextBox94.Text
                    End If

                    da.SelectCommand.Parameters.Add("@cirugias", SqlDbType.VarChar).Value = TextBox97.Text
                    da.SelectCommand.Parameters.Add("@complicacionescirugias", SqlDbType.VarChar).Value = TextBox115.Text
                    If DropDownList66.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@transfusiones", SqlDbType.VarChar).Value = DropDownList66.Text
                    Else
                        da.SelectCommand.Parameters.Add("@transfusiones", SqlDbType.VarChar).Value = TextBox116.Text
                    End If
                    da.SelectCommand.Parameters.Add("@tiposangre", SqlDbType.VarChar).Value = DropDownList67.Text
                    If DropDownList68.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@fracturas", SqlDbType.VarChar).Value = DropDownList68.Text
                    Else
                        da.SelectCommand.Parameters.Add("@fracturas", SqlDbType.VarChar).Value = TextBox117.Text
                    End If
                    If DropDownList69.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@hospprevias", SqlDbType.VarChar).Value = DropDownList69.Text
                    Else
                        da.SelectCommand.Parameters.Add("@hospprevias", SqlDbType.VarChar).Value = TextBox118.Text
                    End If
                    If DropDownList169.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempohipertension", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientohipertension", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempohipertension", SqlDbType.VarChar).Value = TextBox148.Text
                        da.SelectCommand.Parameters.Add("@tratamientohipertension", SqlDbType.VarChar).Value = TextBox149.Text
                    End If
                    If DropDownList170.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoinsuficiencia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoinsuficiencia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoinsuficiencia", SqlDbType.VarChar).Value = TextBox150.Text
                        da.SelectCommand.Parameters.Add("@tratamientoinsuficiencia", SqlDbType.VarChar).Value = TextBox151.Text
                    End If
                    If DropDownList171.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempocardisq", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientocardisq", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempocardisq", SqlDbType.VarChar).Value = TextBox152.Text
                        da.SelectCommand.Parameters.Add("@tratamientocardisq", SqlDbType.VarChar).Value = TextBox153.Text
                    End If
                    If DropDownList172.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoevc", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoevc", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoevc", SqlDbType.VarChar).Value = TextBox154.Text
                        da.SelectCommand.Parameters.Add("@tratamientoevc", SqlDbType.VarChar).Value = TextBox155.Text
                    End If
                    If DropDownList173.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoinsufvenosa", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoinsufvenosa", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoinsufvenosa", SqlDbType.VarChar).Value = TextBox156.Text
                        da.SelectCommand.Parameters.Add("@tratamientoinsufvenosa", SqlDbType.VarChar).Value = TextBox157.Text
                    End If
                    If DropDownList174.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodiabetes", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientodiabetes", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodiabetes", SqlDbType.VarChar).Value = TextBox158.Text
                        da.SelectCommand.Parameters.Add("@tratamientodiabetes", SqlDbType.VarChar).Value = TextBox159.Text
                    End If
                    If DropDownList175.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodislipidemmia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientodislipidemmia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodislipidemmia", SqlDbType.VarChar).Value = TextBox160.Text
                        da.SelectCommand.Parameters.Add("@tratamientodislipidemmia", SqlDbType.VarChar).Value = TextBox161.Text
                    End If
                    If DropDownList176.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoobesidad", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoobesidad", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoobesidad", SqlDbType.VarChar).Value = TextBox162.Text
                        da.SelectCommand.Parameters.Add("@tratamientoobesidad", SqlDbType.VarChar).Value = TextBox163.Text
                    End If
                    If DropDownList177.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoenftiroidea", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoenftiroidea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoenftiroidea", SqlDbType.VarChar).Value = TextBox164.Text
                        da.SelectCommand.Parameters.Add("@tratamientoenftiroidea", SqlDbType.VarChar).Value = TextBox165.Text
                    End If
                    If DropDownList178.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempocancer", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientocancer", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempocancer", SqlDbType.VarChar).Value = TextBox166.Text
                        da.SelectCommand.Parameters.Add("@tratamientocancer", SqlDbType.VarChar).Value = TextBox167.Text
                    End If
                    If DropDownList179.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempotuberculosis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientotuberculosis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempotuberculosis", SqlDbType.VarChar).Value = TextBox168.Text
                        da.SelectCommand.Parameters.Add("@tratamientotuberculosis", SqlDbType.VarChar).Value = TextBox169.Text
                    End If
                    If DropDownList180.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoasma", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoasma", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoasma", SqlDbType.VarChar).Value = TextBox170.Text
                        da.SelectCommand.Parameters.Add("@tratamientoasma", SqlDbType.VarChar).Value = TextBox171.Text
                    End If
                    If DropDownList181.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoepoc", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoepoc", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoepoc", SqlDbType.VarChar).Value = TextBox172.Text
                        da.SelectCommand.Parameters.Add("@tratamientoepoc", SqlDbType.VarChar).Value = TextBox173.Text
                    End If
                    If DropDownList182.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempobronquitis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientobronquitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempobronquitis", SqlDbType.VarChar).Value = TextBox174.Text
                        da.SelectCommand.Parameters.Add("@tratamientobronquitis", SqlDbType.VarChar).Value = TextBox175.Text
                    End If
                    If TextBox176.Text = "" Then
                        da.SelectCommand.Parameters.Add("@otraenf", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tiempootraenf", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientootraenf", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@otraenf", SqlDbType.VarChar).Value = TextBox176.Text
                        da.SelectCommand.Parameters.Add("@tiempootraenf", SqlDbType.VarChar).Value = TextBox177.Text
                        da.SelectCommand.Parameters.Add("@tratamientootraenf", SqlDbType.VarChar).Value = TextBox178.Text
                    End If
                    If DropDownList84.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoalcoholismo", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantalcoholismo", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoalcoholismo", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@cantalcoholismo", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If DropDownList85.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempotabaquismo", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@canttabaquismo", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempotabaquismo", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@canttabaquismo", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If DropDownList86.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodrogas", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantdrogas", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodrogas", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@cantdrogas", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If TextBox185.Text = "" Then
                        da.SelectCommand.Parameters.Add("@otrotox", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tiempootrotox", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantotrotox", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@otrotox", SqlDbType.VarChar).Value = TextBox185.Text
                        da.SelectCommand.Parameters.Add("@tiempootrotox", SqlDbType.VarChar).Value = TextBox186.Text
                        da.SelectCommand.Parameters.Add("@cantotrotox", SqlDbType.VarChar).Value = TextBox187.Text
                    End If
                        da.SelectCommand.Parameters.Add("@ultregla", SqlDbType.Date).Value = DBNull.Value
                    
                    da.SelectCommand.Parameters.Add("@ritmo", SqlDbType.VarChar).Value = TextBox124.Text
                    da.SelectCommand.Parameters.Add("@menopausia", SqlDbType.VarChar).Value = DropDownList87.Text
                    da.SelectCommand.Parameters.Add("@gesta", SqlDbType.Int).Value = DropDownList88.Text
                    da.SelectCommand.Parameters.Add("@para", SqlDbType.Int).Value = DropDownList89.Text
                    da.SelectCommand.Parameters.Add("@cesarea", SqlDbType.Int).Value = DropDownList90.Text
                    da.SelectCommand.Parameters.Add("@aborto", SqlDbType.Int).Value = DropDownList91.Text
                    da.SelectCommand.Parameters.Add("@metplanfam", SqlDbType.VarChar).Value = DropDownList92.Text
                    da.SelectCommand.Parameters.Add("@otroplanfam", SqlDbType.VarChar).Value = TextBox125.Text
                    If DropDownList93.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempofiebre", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionfiebre", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempofiebre", SqlDbType.VarChar).Value = TextBox188.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionfiebre", SqlDbType.VarChar).Value = TextBox189.Text
                    End If
                    If DropDownList94.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoastenia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionastenia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoastenia", SqlDbType.VarChar).Value = TextBox191.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionastenia", SqlDbType.VarChar).Value = TextBox192.Text
                    End If
                    If DropDownList95.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoadinamia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionadinamia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoadinamia", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionadinamia", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList96.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoanorexia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionanorexia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoanorexia", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionanorexia", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList97.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoperdidapeso", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionperdidapeso", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoperdidapeso", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionperdidapeso", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList98.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@obstruccionnasal", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@obstruccionnasal", SqlDbType.VarChar).Value = DropDownList183.Text
                    End If
                    If DropDownList99.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@ronqueramatutina", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@ronqueramatutina", SqlDbType.VarChar).Value = DropDownList184.Text
                    End If
                    If DropDownList100.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@sinusitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@sinusitis", SqlDbType.VarChar).Value = DropDownList185.Text
                    End If
                    If DropDownList101.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@disfonia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@disfonia", SqlDbType.VarChar).Value = DropDownList186.Text
                    End If
                    If DropDownList102.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@disnea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@disnea", SqlDbType.VarChar).Value = DropDownList187.Text
                    End If
                    If DropDownList103.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@sibilancias", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@sibilancias", SqlDbType.VarChar).Value = DropDownList188.Text
                    End If
                    If DropDownList104.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tos", SqlDbType.VarChar).Value = DropDownList189.Text
                    End If
                    If DropDownList105.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@cianosis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@cianosis", SqlDbType.VarChar).Value = DropDownList190.Text
                    End If
                    If DropDownList106.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@asma", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@asma", SqlDbType.VarChar).Value = DropDownList191.Text
                    End If
                    If DropDownList107.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorolipotimia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacioneslipotimia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorolipotimia", SqlDbType.VarChar).Value = DropDownList192.Text
                        da.SelectCommand.Parameters.Add("@sensacioneslipotimia", SqlDbType.VarChar).Value = TextBox203.Text
                    End If
                    If DropDownList108.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorosincope", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionessincope", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorosincope", SqlDbType.VarChar).Value = DropDownList193.Text
                        da.SelectCommand.Parameters.Add("@sensacionessincope", SqlDbType.VarChar).Value = TextBox204.Text
                    End If
                    If DropDownList109.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorofatiga", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesfatiga", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorofatiga", SqlDbType.VarChar).Value = DropDownList194.Text
                        da.SelectCommand.Parameters.Add("@sensacionesfatiga", SqlDbType.VarChar).Value = TextBox205.Text
                    End If
                    If DropDownList110.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoropalpitaciones", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionespalpitaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoropalpitaciones", SqlDbType.VarChar).Value = DropDownList195.Text
                        da.SelectCommand.Parameters.Add("@sensacionespalpitaciones", SqlDbType.VarChar).Value = TextBox206.Text
                    End If
                    If DropDownList111.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorodolprecordial", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesdolprecordial", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorodolprecordial", SqlDbType.VarChar).Value = DropDownList196.Text
                        da.SelectCommand.Parameters.Add("@sensacionesdolprecordial", SqlDbType.VarChar).Value = TextBox207.Text
                    End If
                    If DropDownList112.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoroedema", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesedema", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoroedema", SqlDbType.VarChar).Value = DropDownList197.Text
                        da.SelectCommand.Parameters.Add("@sensacionesedema", SqlDbType.VarChar).Value = TextBox208.Text
                    End If
                    If DropDownList113.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorodisnea", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesdisnea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorodisnea", SqlDbType.VarChar).Value = DropDownList198.Text
                        da.SelectCommand.Parameters.Add("@sensacionesdisnea", SqlDbType.VarChar).Value = TextBox209.Text
                    End If
                    If DropDownList114.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoroascitis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesascitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoroascitis", SqlDbType.VarChar).Value = DropDownList199.Text
                        da.SelectCommand.Parameters.Add("@sensacionesascitis", SqlDbType.VarChar).Value = TextBox210.Text
                    End If
                    da.SelectCommand.Parameters.Add("@disuria", SqlDbType.VarChar).Value = DropDownList138.Text
                    da.SelectCommand.Parameters.Add("@poliaquiuria", SqlDbType.VarChar).Value = DropDownList139.Text
                    da.SelectCommand.Parameters.Add("@tenesmo", SqlDbType.VarChar).Value = DropDownList140.Text
                    da.SelectCommand.Parameters.Add("@hematuria", SqlDbType.VarChar).Value = DropDownList141.Text
                    da.SelectCommand.Parameters.Add("@suprapubica", SqlDbType.VarChar).Value = DropDownList142.Text
                    da.SelectCommand.Parameters.Add("@lumbar", SqlDbType.VarChar).Value = DropDownList143.Text
                    da.SelectCommand.Parameters.Add("@ninguno", SqlDbType.VarChar).Value = DropDownList144.Text
                    da.SelectCommand.Parameters.Add("@otrosdolores", SqlDbType.VarChar).Value = TextBox131.Text
                    da.SelectCommand.Parameters.Add("@tendenciahemorragia", SqlDbType.VarChar).Value = DropDownList145.Text
                    da.SelectCommand.Parameters.Add("@adenopatias", SqlDbType.VarChar).Value = DropDownList146.Text
                    da.SelectCommand.Parameters.Add("@infecrecurrentes", SqlDbType.VarChar).Value = DropDownList147.Text
                    da.SelectCommand.Parameters.Add("@anemia", SqlDbType.VarChar).Value = DropDownList148.Text
                    da.SelectCommand.Parameters.Add("@hemolinfaticonegado", SqlDbType.VarChar).Value = DropDownList149.Text
                    da.SelectCommand.Parameters.Add("@otroshemolinf", SqlDbType.VarChar).Value = TextBox132.Text
                    da.SelectCommand.Parameters.Add("@paralisis", SqlDbType.VarChar).Value = DropDownList150.Text
                    da.SelectCommand.Parameters.Add("@parestesisas", SqlDbType.VarChar).Value = DropDownList151.Text
                    da.SelectCommand.Parameters.Add("@temblores", SqlDbType.VarChar).Value = DropDownList152.Text
                    da.SelectCommand.Parameters.Add("@alteracionesmarcha", SqlDbType.VarChar).Value = DropDownList153.Text
                    da.SelectCommand.Parameters.Add("@cefalea", SqlDbType.VarChar).Value = DropDownList154.Text
                    da.SelectCommand.Parameters.Add("@sisnerviosonegado", SqlDbType.VarChar).Value = DropDownList155.Text
                    da.SelectCommand.Parameters.Add("@otrossisnerv", SqlDbType.VarChar).Value = TextBox133.Text
                    da.SelectCommand.Parameters.Add("@padactual", SqlDbType.VarChar).Value = TextBox1.Text
                    da.SelectCommand.Parameters.Add("@motivoconsulta", SqlDbType.VarChar).Value = TextBox12.Text
                    da.SelectCommand.Parameters.Add("@region", SqlDbType.VarChar).Value = TextBox13.Text
                    da.SelectCommand.Parameters.Add("@inicia", SqlDbType.VarChar).Value = TextBox14.Text
                    da.SelectCommand.Parameters.Add("@irradiacion", SqlDbType.VarChar).Value = TextBox15.Text
                    da.SelectCommand.Parameters.Add("@migracion", SqlDbType.VarChar).Value = TextBox16.Text
                    da.SelectCommand.Parameters.Add("@expansion", SqlDbType.VarChar).Value = TextBox17.Text
                    da.SelectCommand.Parameters.Add("@proyeccion", SqlDbType.VarChar).Value = TextBox18.Text
                    da.SelectCommand.Parameters.Add("@semejanzacualitativos", SqlDbType.VarChar).Value = TextBox19.Text
                    If DropDownList1.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@localizacioncualitativos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@localizacioncualitativos", SqlDbType.VarChar).Value = DropDownList1.Text
                    End If
                    da.SelectCommand.Parameters.Add("@intensidadcuantitativos", SqlDbType.VarChar).Value = TextBox20.Text
                    da.SelectCommand.Parameters.Add("@maximaintensidadcuantitativos", SqlDbType.VarChar).Value = TextBox21.Text
                    da.SelectCommand.Parameters.Add("@intensidadultimoevento", SqlDbType.VarChar).Value = TextBox22.Text
                    da.SelectCommand.Parameters.Add("@iniciocronologicos", SqlDbType.VarChar).Value = TextBox23.Text
                    If DropDownList2.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patroncronologicos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patroncronologicos", SqlDbType.VarChar).Value = DropDownList2.Text
                    End If
                    da.SelectCommand.Parameters.Add("@duracion", SqlDbType.VarChar).Value = TextBox24.Text
                    da.SelectCommand.Parameters.Add("@frecuenciadia", SqlDbType.VarChar).Value = TextBox25.Text
                    da.SelectCommand.Parameters.Add("@frecuenciamensual", SqlDbType.VarChar).Value = TextBox26.Text
                    da.SelectCommand.Parameters.Add("@ultimoevento", SqlDbType.VarChar).Value = TextBox27.Text
                    If DropDownList3.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patrondia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patrondia", SqlDbType.VarChar).Value = DropDownList3.Text
                    End If
                    If DropDownList4.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronayuno", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronayuno", SqlDbType.VarChar).Value = DropDownList4.Text
                    End If
                    If DropDownList5.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronevacuaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronevacuaciones", SqlDbType.VarChar).Value = DropDownList5.Text
                    End If
                    da.SelectCommand.Parameters.Add("@patronevacuaciones2", SqlDbType.VarChar).Value = TextBox28.Text
                    da.SelectCommand.Parameters.Add("@patrongases", SqlDbType.VarChar).Value = TextBox29.Text
                    da.SelectCommand.Parameters.Add("@patronvomito", SqlDbType.VarChar).Value = TextBox30.Text
                    da.SelectCommand.Parameters.Add("@aumentaintesidad", SqlDbType.VarChar).Value = TextBox33.Text
                    da.SelectCommand.Parameters.Add("@disminuyeintensidad", SqlDbType.VarChar).Value = TextBox33.Text
                    da.SelectCommand.Parameters.Add("@alimdisminuyen", SqlDbType.VarChar).Value = TextBox35.Text
                    If DropDownList7.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@evacuaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@evacuaciones", SqlDbType.VarChar).Value = DropDownList7.Text
                    End If
                    If DropDownList8.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@canalizacionesgases", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@canalizacionesgases", SqlDbType.VarChar).Value = DropDownList8.Text
                    End If
                    If DropDownList9.Text = "-Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@eructos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@eructos", SqlDbType.VarChar).Value = DropDownList9.Text
                    End If
                    da.SelectCommand.Parameters.Add("@medicamcalman", SqlDbType.VarChar).Value = TextBox32.Text
                    da.SelectCommand.Parameters.Add("@medicamnocontrolan", SqlDbType.VarChar).Value = TextBox31.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional1", SqlDbType.VarChar).Value = TextBox36.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional2", SqlDbType.VarChar).Value = TextBox37.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional3", SqlDbType.VarChar).Value = TextBox38.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional4", SqlDbType.VarChar).Value = TextBox39.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre1", SqlDbType.VarChar).Value = TextBox40.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre2", SqlDbType.VarChar).Value = TextBox41.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre3", SqlDbType.VarChar).Value = TextBox42.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre4", SqlDbType.VarChar).Value = TextBox43.Text
                    da.SelectCommand.Parameters.Add("@sintomanodolor", SqlDbType.VarChar).Value = TextBox44.Text
                    da.SelectCommand.Parameters.Add("@inicionodolor", SqlDbType.VarChar).Value = TextBox2.Text
                    If DropDownList6.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronnodolor", SqlDbType.VarChar).Value = DropDownList6.Text
                    End If
                    da.SelectCommand.Parameters.Add("@duracionnodolor", SqlDbType.VarChar).Value = TextBox3.Text
                    da.SelectCommand.Parameters.Add("@frecuenciadianodolor", SqlDbType.VarChar).Value = TextBox4.Text
                    da.SelectCommand.Parameters.Add("@frecuenciamesnodolor", SqlDbType.VarChar).Value = TextBox5.Text
                    da.SelectCommand.Parameters.Add("@ulteventonodolor", SqlDbType.VarChar).Value = TextBox6.Text
                    If DropDownList10.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patrondianodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patrondianodolor", SqlDbType.VarChar).Value = DropDownList10.Text
                    End If
                    If DropDownList11.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronayunonodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronayunonodolor", SqlDbType.VarChar).Value = DropDownList11.Text
                    End If
                    If DropDownList12.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronevacnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronevacnodolor", SqlDbType.VarChar).Value = DropDownList12.Text
                    End If
                    da.SelectCommand.Parameters.Add("@patrongasesnodolor", SqlDbType.VarChar).Value = TextBox46.Text
                    da.SelectCommand.Parameters.Add("@patronvomitonodolor", SqlDbType.VarChar).Value = TextBox45.Text
                    da.SelectCommand.Parameters.Add("@aumentaintensnodolor", SqlDbType.VarChar).Value = TextBox47.Text
                    da.SelectCommand.Parameters.Add("@disminuyeintensnodolor", SqlDbType.VarChar).Value = TextBox48.Text
                    da.SelectCommand.Parameters.Add("@alimprovocannodolor", SqlDbType.VarChar).Value = TextBox49.Text
                    da.SelectCommand.Parameters.Add("@alimdisminuyennodolor", SqlDbType.VarChar).Value = TextBox50.Text
                    If DropDownList13.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@evacnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@evacnodolor", SqlDbType.VarChar).Value = DropDownList13.Text
                    End If
                    If DropDownList14.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@canalizgasesnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@canalizgasesnodolor", SqlDbType.VarChar).Value = DropDownList14.Text
                    End If
                    If DropDownList15.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@eructosnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@eructosnodolor", SqlDbType.VarChar).Value = DropDownList15.Text
                    End If
                    da.SelectCommand.Parameters.Add("@medicamcalmannodolor", SqlDbType.VarChar).Value = TextBox51.Text
                    da.SelectCommand.Parameters.Add("@mednocontrolannodolor", SqlDbType.VarChar).Value = TextBox52.Text
                    da.SelectCommand.Parameters.Add("@peso", SqlDbType.VarChar).Value = TextBox53.Text
                    da.SelectCommand.Parameters.Add("@talla", SqlDbType.VarChar).Value = TextBox54.Text
                    da.SelectCommand.Parameters.Add("@temp", SqlDbType.VarChar).Value = TextBox55.Text
                    da.SelectCommand.Parameters.Add("@ta", SqlDbType.VarChar).Value = TextBox56.Text
                    da.SelectCommand.Parameters.Add("@tc", SqlDbType.VarChar).Value = TextBox57.Text
                    da.SelectCommand.Parameters.Add("@fr", SqlDbType.VarChar).Value = TextBox58.Text
                    da.SelectCommand.Parameters.Add("@cabeza", SqlDbType.VarChar).Value = TextBox59.Text
                    da.SelectCommand.Parameters.Add("@torax", SqlDbType.VarChar).Value = TextBox60.Text
                    da.SelectCommand.Parameters.Add("@abdomen", SqlDbType.VarChar).Value = TextBox61.Text
                    da.SelectCommand.Parameters.Add("@extremidades", SqlDbType.VarChar).Value = TextBox62.Text
                    da.SelectCommand.Parameters.Add("@estudios", SqlDbType.VarChar).Value = TextBox63.Text
                    da.SelectCommand.Parameters.Add("@regionanalisis", SqlDbType.VarChar).Value = DropDownList48.Text
                    For Each li As ListItem In CheckBoxList9.Items
                        If li.Selected Then
                            If sintanalisis9.Length = 0 Then
                                sintanalisis9 = li.Value
                            Else
                                sintanalisis9 += ", " + li.Value
                            End If
                        End If
                    Next
                    If TextBox110.Text <> "" Then
                        sintanalisis9 += ", " + TextBox110.Text
                    End If
                    da.SelectCommand.Parameters.Add("@sintomaanalisis", SqlDbType.VarChar).Value = sintanalisis9
                    If TextBox89.Visible = True Then
                        da.SelectCommand.Parameters.Add("@sindromeclin", SqlDbType.VarChar).Value = TextBox89.Text
                    Else
                        da.SelectCommand.Parameters.Add("@sindromeclin", SqlDbType.VarChar).Value = DropDownList50.Text
                    End If
                    If TextBox90.Visible = True Then
                        da.SelectCommand.Parameters.Add("@subtipoanalisis", SqlDbType.VarChar).Value = TextBox90.Text
                    Else
                        da.SelectCommand.Parameters.Add("@subtipoanalisis", SqlDbType.VarChar).Value = DropDownList51.Text
                    End If
                    da.SelectCommand.Parameters.Add("@analisis", SqlDbType.VarChar).Value = TextBox100.Text
                    da.SelectCommand.Parameters.Add("@diagnostico", SqlDbType.VarChar).Value = TextBox7.Text
                    da.SelectCommand.Parameters.Add("@indicgrales", SqlDbType.VarChar).Value = TextBox114.Text
                    da.SelectCommand.Parameters.Add("@estudiosgrales", SqlDbType.VarChar).Value = TextBox79.Text
                    da.SelectCommand.Parameters.Add("@tratamiento", SqlDbType.VarChar).Value = TextBox82.Text
                    da.SelectCommand.Parameters.Add("@medico", SqlDbType.VarChar).Value = Label8.Text

                    da.SelectCommand.ExecuteNonQuery()
                    con.Close()


                Catch ex As Exception

                End Try
            End If

            If DropDownList52.Text <> "--Seleccionar--" Then


                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    da = New SqlDataAdapter("modificagastro", con)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.SelectCommand.Parameters.Add("@folionota", SqlDbType.Int).Value = Session("numnota2")
                    da.SelectCommand.Parameters.Add("@pacienteid", SqlDbType.Int).Value = Session("Paciente")
                    da.SelectCommand.Parameters.Add("@fechamodif", SqlDbType.DateTime).Value = Label2.Text
                    da.SelectCommand.Parameters.Add("@genero", SqlDbType.VarChar).Value = DropDownList200.Text
                    da.SelectCommand.Parameters.Add("@diarrea", SqlDbType.VarChar).Value = DropDownList17.Text
                    da.SelectCommand.Parameters.Add("@hernias", SqlDbType.VarChar).Value = DropDownList21.Text
                    da.SelectCommand.Parameters.Add("@cancer", SqlDbType.VarChar).Value = DropDownList25.Text
                    da.SelectCommand.Parameters.Add("@estrenimiento", SqlDbType.VarChar).Value = DropDownList29.Text
                    da.SelectCommand.Parameters.Add("@cancerdigestivo", SqlDbType.VarChar).Value = DropDownList33.Text
                    da.SelectCommand.Parameters.Add("@colecistitis", SqlDbType.VarChar).Value = DropDownList37.Text
                    da.SelectCommand.Parameters.Add("@hipertension", SqlDbType.VarChar).Value = DropDownList41.Text
                    da.SelectCommand.Parameters.Add("@cardiopatia", SqlDbType.VarChar).Value = DropDownList45.Text
                    da.SelectCommand.Parameters.Add("@autoinmunes", SqlDbType.VarChar).Value = DropDownList49.Text
                    da.SelectCommand.Parameters.Add("@diabetes", SqlDbType.VarChar).Value = DropDownList53.Text
                    da.SelectCommand.Parameters.Add("@endocrinopatias", SqlDbType.VarChar).Value = DropDownList57.Text
                    da.SelectCommand.Parameters.Add("@otrosenf", SqlDbType.VarChar).Value = TextBox85.Text
                    da.SelectCommand.Parameters.Add("@otrosfam", SqlDbType.VarChar).Value = DropDownList168.Text
                    da.SelectCommand.Parameters.Add("@ocupacion", SqlDbType.VarChar).Value = TextBox91.Text
                    da.SelectCommand.Parameters.Add("@escolaridad", SqlDbType.VarChar).Value = DropDownList61.Text
                    da.SelectCommand.Parameters.Add("@actfis", SqlDbType.VarChar).Value = DropDownList64.Text
                    If DropDownList65.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@alergicos", SqlDbType.VarChar).Value = DropDownList65.Text
                    Else
                        da.SelectCommand.Parameters.Add("@alergicos", SqlDbType.VarChar).Value = TextBox94.Text
                    End If

                    da.SelectCommand.Parameters.Add("@cirugias", SqlDbType.VarChar).Value = TextBox97.Text
                    da.SelectCommand.Parameters.Add("@complicacionescirugias", SqlDbType.VarChar).Value = TextBox115.Text
                    If DropDownList66.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@transfusiones", SqlDbType.VarChar).Value = DropDownList66.Text
                    Else
                        da.SelectCommand.Parameters.Add("@transfusiones", SqlDbType.VarChar).Value = TextBox116.Text
                    End If
                    da.SelectCommand.Parameters.Add("@tiposangre", SqlDbType.VarChar).Value = DropDownList67.Text
                    If DropDownList68.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@fracturas", SqlDbType.VarChar).Value = DropDownList68.Text
                    Else
                        da.SelectCommand.Parameters.Add("@fracturas", SqlDbType.VarChar).Value = TextBox117.Text
                    End If
                    If DropDownList69.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@hospprevias", SqlDbType.VarChar).Value = DropDownList69.Text
                    Else
                        da.SelectCommand.Parameters.Add("@hospprevias", SqlDbType.VarChar).Value = TextBox118.Text
                    End If
                    If DropDownList169.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempohipertension", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientohipertension", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempohipertension", SqlDbType.VarChar).Value = TextBox148.Text
                        da.SelectCommand.Parameters.Add("@tratamientohipertension", SqlDbType.VarChar).Value = TextBox149.Text
                    End If
                    If DropDownList170.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoinsuficiencia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoinsuficiencia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoinsuficiencia", SqlDbType.VarChar).Value = TextBox150.Text
                        da.SelectCommand.Parameters.Add("@tratamientoinsuficiencia", SqlDbType.VarChar).Value = TextBox151.Text
                    End If
                    If DropDownList171.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempocardisq", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientocardisq", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempocardisq", SqlDbType.VarChar).Value = TextBox152.Text
                        da.SelectCommand.Parameters.Add("@tratamientocardisq", SqlDbType.VarChar).Value = TextBox153.Text
                    End If
                    If DropDownList172.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoevc", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoevc", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoevc", SqlDbType.VarChar).Value = TextBox154.Text
                        da.SelectCommand.Parameters.Add("@tratamientoevc", SqlDbType.VarChar).Value = TextBox155.Text
                    End If
                    If DropDownList173.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoinsufvenosa", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoinsufvenosa", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoinsufvenosa", SqlDbType.VarChar).Value = TextBox156.Text
                        da.SelectCommand.Parameters.Add("@tratamientoinsufvenosa", SqlDbType.VarChar).Value = TextBox157.Text
                    End If
                    If DropDownList174.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodiabetes", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientodiabetes", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodiabetes", SqlDbType.VarChar).Value = TextBox158.Text
                        da.SelectCommand.Parameters.Add("@tratamientodiabetes", SqlDbType.VarChar).Value = TextBox159.Text
                    End If
                    If DropDownList175.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodislipidemmia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientodislipidemmia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodislipidemmia", SqlDbType.VarChar).Value = TextBox160.Text
                        da.SelectCommand.Parameters.Add("@tratamientodislipidemmia", SqlDbType.VarChar).Value = TextBox161.Text
                    End If
                    If DropDownList176.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoobesidad", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoobesidad", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoobesidad", SqlDbType.VarChar).Value = TextBox162.Text
                        da.SelectCommand.Parameters.Add("@tratamientoobesidad", SqlDbType.VarChar).Value = TextBox163.Text
                    End If
                    If DropDownList177.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoenftiroidea", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoenftiroidea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoenftiroidea", SqlDbType.VarChar).Value = TextBox164.Text
                        da.SelectCommand.Parameters.Add("@tratamientoenftiroidea", SqlDbType.VarChar).Value = TextBox165.Text
                    End If
                    If DropDownList178.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempocancer", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientocancer", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempocancer", SqlDbType.VarChar).Value = TextBox166.Text
                        da.SelectCommand.Parameters.Add("@tratamientocancer", SqlDbType.VarChar).Value = TextBox167.Text
                    End If
                    If DropDownList179.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempotuberculosis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientotuberculosis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempotuberculosis", SqlDbType.VarChar).Value = TextBox168.Text
                        da.SelectCommand.Parameters.Add("@tratamientotuberculosis", SqlDbType.VarChar).Value = TextBox169.Text
                    End If
                    If DropDownList180.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoasma", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoasma", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoasma", SqlDbType.VarChar).Value = TextBox170.Text
                        da.SelectCommand.Parameters.Add("@tratamientoasma", SqlDbType.VarChar).Value = TextBox171.Text
                    End If
                    If DropDownList181.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoepoc", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoepoc", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoepoc", SqlDbType.VarChar).Value = TextBox172.Text
                        da.SelectCommand.Parameters.Add("@tratamientoepoc", SqlDbType.VarChar).Value = TextBox173.Text
                    End If
                    If DropDownList182.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempobronquitis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientobronquitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempobronquitis", SqlDbType.VarChar).Value = TextBox174.Text
                        da.SelectCommand.Parameters.Add("@tratamientobronquitis", SqlDbType.VarChar).Value = TextBox175.Text
                    End If
                    If TextBox176.Text = "" Then
                        da.SelectCommand.Parameters.Add("@otraenf", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tiempootraenf", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientootraenf", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@otraenf", SqlDbType.VarChar).Value = TextBox176.Text
                        da.SelectCommand.Parameters.Add("@tiempootraenf", SqlDbType.VarChar).Value = TextBox177.Text
                        da.SelectCommand.Parameters.Add("@tratamientootraenf", SqlDbType.VarChar).Value = TextBox178.Text
                    End If
                    If DropDownList84.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoalcoholismo", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantalcoholismo", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoalcoholismo", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@cantalcoholismo", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If DropDownList85.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempotabaquismo", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@canttabaquismo", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempotabaquismo", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@canttabaquismo", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If DropDownList86.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodrogas", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantdrogas", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodrogas", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@cantdrogas", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If TextBox185.Text = "" Then
                        da.SelectCommand.Parameters.Add("@otrotox", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tiempootrotox", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantotrotox", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@otrotox", SqlDbType.VarChar).Value = TextBox185.Text
                        da.SelectCommand.Parameters.Add("@tiempootrotox", SqlDbType.VarChar).Value = TextBox186.Text
                        da.SelectCommand.Parameters.Add("@cantotrotox", SqlDbType.VarChar).Value = TextBox187.Text
                    End If
                        da.SelectCommand.Parameters.Add("@ultregla", SqlDbType.Date).Value = DBNull.Value
                    
                    da.SelectCommand.Parameters.Add("@ritmo", SqlDbType.VarChar).Value = TextBox124.Text
                    da.SelectCommand.Parameters.Add("@menopausia", SqlDbType.VarChar).Value = DropDownList87.Text
                    da.SelectCommand.Parameters.Add("@gesta", SqlDbType.Int).Value = DropDownList88.Text
                    da.SelectCommand.Parameters.Add("@para", SqlDbType.Int).Value = DropDownList89.Text
                    da.SelectCommand.Parameters.Add("@cesarea", SqlDbType.Int).Value = DropDownList90.Text
                    da.SelectCommand.Parameters.Add("@aborto", SqlDbType.Int).Value = DropDownList91.Text
                    da.SelectCommand.Parameters.Add("@metplanfam", SqlDbType.VarChar).Value = DropDownList92.Text
                    da.SelectCommand.Parameters.Add("@otroplanfam", SqlDbType.VarChar).Value = TextBox125.Text
                    If DropDownList93.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempofiebre", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionfiebre", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempofiebre", SqlDbType.VarChar).Value = TextBox188.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionfiebre", SqlDbType.VarChar).Value = TextBox189.Text
                    End If
                    If DropDownList94.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoastenia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionastenia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoastenia", SqlDbType.VarChar).Value = TextBox191.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionastenia", SqlDbType.VarChar).Value = TextBox192.Text
                    End If
                    If DropDownList95.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoadinamia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionadinamia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoadinamia", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionadinamia", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList96.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoanorexia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionanorexia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoanorexia", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionanorexia", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList97.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoperdidapeso", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionperdidapeso", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoperdidapeso", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionperdidapeso", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList98.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@obstruccionnasal", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@obstruccionnasal", SqlDbType.VarChar).Value = DropDownList183.Text
                    End If
                    If DropDownList99.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@ronqueramatutina", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@ronqueramatutina", SqlDbType.VarChar).Value = DropDownList184.Text
                    End If
                    If DropDownList100.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@sinusitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@sinusitis", SqlDbType.VarChar).Value = DropDownList185.Text
                    End If
                    If DropDownList101.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@disfonia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@disfonia", SqlDbType.VarChar).Value = DropDownList186.Text
                    End If
                    If DropDownList102.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@disnea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@disnea", SqlDbType.VarChar).Value = DropDownList187.Text
                    End If
                    If DropDownList103.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@sibilancias", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@sibilancias", SqlDbType.VarChar).Value = DropDownList188.Text
                    End If
                    If DropDownList104.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tos", SqlDbType.VarChar).Value = DropDownList189.Text
                    End If
                    If DropDownList105.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@cianosis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@cianosis", SqlDbType.VarChar).Value = DropDownList190.Text
                    End If
                    If DropDownList106.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@asma", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@asma", SqlDbType.VarChar).Value = DropDownList191.Text
                    End If
                    If DropDownList107.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorolipotimia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacioneslipotimia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorolipotimia", SqlDbType.VarChar).Value = DropDownList192.Text
                        da.SelectCommand.Parameters.Add("@sensacioneslipotimia", SqlDbType.VarChar).Value = TextBox203.Text
                    End If
                    If DropDownList108.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorosincope", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionessincope", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorosincope", SqlDbType.VarChar).Value = DropDownList193.Text
                        da.SelectCommand.Parameters.Add("@sensacionessincope", SqlDbType.VarChar).Value = TextBox204.Text
                    End If
                    If DropDownList109.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorofatiga", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesfatiga", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorofatiga", SqlDbType.VarChar).Value = DropDownList194.Text
                        da.SelectCommand.Parameters.Add("@sensacionesfatiga", SqlDbType.VarChar).Value = TextBox205.Text
                    End If
                    If DropDownList110.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoropalpitaciones", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionespalpitaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoropalpitaciones", SqlDbType.VarChar).Value = DropDownList195.Text
                        da.SelectCommand.Parameters.Add("@sensacionespalpitaciones", SqlDbType.VarChar).Value = TextBox206.Text
                    End If
                    If DropDownList111.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorodolprecordial", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesdolprecordial", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorodolprecordial", SqlDbType.VarChar).Value = DropDownList196.Text
                        da.SelectCommand.Parameters.Add("@sensacionesdolprecordial", SqlDbType.VarChar).Value = TextBox207.Text
                    End If
                    If DropDownList112.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoroedema", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesedema", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoroedema", SqlDbType.VarChar).Value = DropDownList197.Text
                        da.SelectCommand.Parameters.Add("@sensacionesedema", SqlDbType.VarChar).Value = TextBox208.Text
                    End If
                    If DropDownList113.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorodisnea", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesdisnea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorodisnea", SqlDbType.VarChar).Value = DropDownList198.Text
                        da.SelectCommand.Parameters.Add("@sensacionesdisnea", SqlDbType.VarChar).Value = TextBox209.Text
                    End If
                    If DropDownList114.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoroascitis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesascitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoroascitis", SqlDbType.VarChar).Value = DropDownList199.Text
                        da.SelectCommand.Parameters.Add("@sensacionesascitis", SqlDbType.VarChar).Value = TextBox210.Text
                    End If
                    da.SelectCommand.Parameters.Add("@disuria", SqlDbType.VarChar).Value = DropDownList138.Text
                    da.SelectCommand.Parameters.Add("@poliaquiuria", SqlDbType.VarChar).Value = DropDownList139.Text
                    da.SelectCommand.Parameters.Add("@tenesmo", SqlDbType.VarChar).Value = DropDownList140.Text
                    da.SelectCommand.Parameters.Add("@hematuria", SqlDbType.VarChar).Value = DropDownList141.Text
                    da.SelectCommand.Parameters.Add("@suprapubica", SqlDbType.VarChar).Value = DropDownList142.Text
                    da.SelectCommand.Parameters.Add("@lumbar", SqlDbType.VarChar).Value = DropDownList143.Text
                    da.SelectCommand.Parameters.Add("@ninguno", SqlDbType.VarChar).Value = DropDownList144.Text
                    da.SelectCommand.Parameters.Add("@otrosdolores", SqlDbType.VarChar).Value = TextBox131.Text
                    da.SelectCommand.Parameters.Add("@tendenciahemorragia", SqlDbType.VarChar).Value = DropDownList145.Text
                    da.SelectCommand.Parameters.Add("@adenopatias", SqlDbType.VarChar).Value = DropDownList146.Text
                    da.SelectCommand.Parameters.Add("@infecrecurrentes", SqlDbType.VarChar).Value = DropDownList147.Text
                    da.SelectCommand.Parameters.Add("@anemia", SqlDbType.VarChar).Value = DropDownList148.Text
                    da.SelectCommand.Parameters.Add("@hemolinfaticonegado", SqlDbType.VarChar).Value = DropDownList149.Text
                    da.SelectCommand.Parameters.Add("@otroshemolinf", SqlDbType.VarChar).Value = TextBox132.Text
                    da.SelectCommand.Parameters.Add("@paralisis", SqlDbType.VarChar).Value = DropDownList150.Text
                    da.SelectCommand.Parameters.Add("@parestesisas", SqlDbType.VarChar).Value = DropDownList151.Text
                    da.SelectCommand.Parameters.Add("@temblores", SqlDbType.VarChar).Value = DropDownList152.Text
                    da.SelectCommand.Parameters.Add("@alteracionesmarcha", SqlDbType.VarChar).Value = DropDownList153.Text
                    da.SelectCommand.Parameters.Add("@cefalea", SqlDbType.VarChar).Value = DropDownList154.Text
                    da.SelectCommand.Parameters.Add("@sisnerviosonegado", SqlDbType.VarChar).Value = DropDownList155.Text
                    da.SelectCommand.Parameters.Add("@otrossisnerv", SqlDbType.VarChar).Value = TextBox133.Text
                    da.SelectCommand.Parameters.Add("@padactual", SqlDbType.VarChar).Value = TextBox1.Text
                    da.SelectCommand.Parameters.Add("@motivoconsulta", SqlDbType.VarChar).Value = TextBox12.Text
                    da.SelectCommand.Parameters.Add("@region", SqlDbType.VarChar).Value = TextBox13.Text
                    da.SelectCommand.Parameters.Add("@inicia", SqlDbType.VarChar).Value = TextBox14.Text
                    da.SelectCommand.Parameters.Add("@irradiacion", SqlDbType.VarChar).Value = TextBox15.Text
                    da.SelectCommand.Parameters.Add("@migracion", SqlDbType.VarChar).Value = TextBox16.Text
                    da.SelectCommand.Parameters.Add("@expansion", SqlDbType.VarChar).Value = TextBox17.Text
                    da.SelectCommand.Parameters.Add("@proyeccion", SqlDbType.VarChar).Value = TextBox18.Text
                    da.SelectCommand.Parameters.Add("@semejanzacualitativos", SqlDbType.VarChar).Value = TextBox19.Text
                    If DropDownList1.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@localizacioncualitativos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@localizacioncualitativos", SqlDbType.VarChar).Value = DropDownList1.Text
                    End If
                    da.SelectCommand.Parameters.Add("@intensidadcuantitativos", SqlDbType.VarChar).Value = TextBox20.Text
                    da.SelectCommand.Parameters.Add("@maximaintensidadcuantitativos", SqlDbType.VarChar).Value = TextBox21.Text
                    da.SelectCommand.Parameters.Add("@intensidadultimoevento", SqlDbType.VarChar).Value = TextBox22.Text
                    da.SelectCommand.Parameters.Add("@iniciocronologicos", SqlDbType.VarChar).Value = TextBox23.Text
                    If DropDownList2.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patroncronologicos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patroncronologicos", SqlDbType.VarChar).Value = DropDownList2.Text
                    End If
                    da.SelectCommand.Parameters.Add("@duracion", SqlDbType.VarChar).Value = TextBox24.Text
                    da.SelectCommand.Parameters.Add("@frecuenciadia", SqlDbType.VarChar).Value = TextBox25.Text
                    da.SelectCommand.Parameters.Add("@frecuenciamensual", SqlDbType.VarChar).Value = TextBox26.Text
                    da.SelectCommand.Parameters.Add("@ultimoevento", SqlDbType.VarChar).Value = TextBox27.Text
                    If DropDownList3.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patrondia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patrondia", SqlDbType.VarChar).Value = DropDownList3.Text
                    End If
                    If DropDownList4.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronayuno", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronayuno", SqlDbType.VarChar).Value = DropDownList4.Text
                    End If
                    If DropDownList5.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronevacuaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronevacuaciones", SqlDbType.VarChar).Value = DropDownList5.Text
                    End If
                    da.SelectCommand.Parameters.Add("@patronevacuaciones2", SqlDbType.VarChar).Value = TextBox28.Text
                    da.SelectCommand.Parameters.Add("@patrongases", SqlDbType.VarChar).Value = TextBox29.Text
                    da.SelectCommand.Parameters.Add("@patronvomito", SqlDbType.VarChar).Value = TextBox30.Text
                    da.SelectCommand.Parameters.Add("@aumentaintesidad", SqlDbType.VarChar).Value = TextBox33.Text
                    da.SelectCommand.Parameters.Add("@disminuyeintensidad", SqlDbType.VarChar).Value = TextBox33.Text
                    da.SelectCommand.Parameters.Add("@alimdisminuyen", SqlDbType.VarChar).Value = TextBox35.Text
                    If DropDownList7.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@evacuaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@evacuaciones", SqlDbType.VarChar).Value = DropDownList7.Text
                    End If
                    If DropDownList8.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@canalizacionesgases", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@canalizacionesgases", SqlDbType.VarChar).Value = DropDownList8.Text
                    End If
                    If DropDownList9.Text = "-Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@eructos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@eructos", SqlDbType.VarChar).Value = DropDownList9.Text
                    End If
                    da.SelectCommand.Parameters.Add("@medicamcalman", SqlDbType.VarChar).Value = TextBox32.Text
                    da.SelectCommand.Parameters.Add("@medicamnocontrolan", SqlDbType.VarChar).Value = TextBox31.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional1", SqlDbType.VarChar).Value = TextBox36.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional2", SqlDbType.VarChar).Value = TextBox37.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional3", SqlDbType.VarChar).Value = TextBox38.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional4", SqlDbType.VarChar).Value = TextBox39.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre1", SqlDbType.VarChar).Value = TextBox40.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre2", SqlDbType.VarChar).Value = TextBox41.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre3", SqlDbType.VarChar).Value = TextBox42.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre4", SqlDbType.VarChar).Value = TextBox43.Text
                    da.SelectCommand.Parameters.Add("@sintomanodolor", SqlDbType.VarChar).Value = TextBox44.Text
                    da.SelectCommand.Parameters.Add("@inicionodolor", SqlDbType.VarChar).Value = TextBox2.Text
                    If DropDownList6.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronnodolor", SqlDbType.VarChar).Value = DropDownList6.Text
                    End If
                    da.SelectCommand.Parameters.Add("@duracionnodolor", SqlDbType.VarChar).Value = TextBox3.Text
                    da.SelectCommand.Parameters.Add("@frecuenciadianodolor", SqlDbType.VarChar).Value = TextBox4.Text
                    da.SelectCommand.Parameters.Add("@frecuenciamesnodolor", SqlDbType.VarChar).Value = TextBox5.Text
                    da.SelectCommand.Parameters.Add("@ulteventonodolor", SqlDbType.VarChar).Value = TextBox6.Text
                    If DropDownList10.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patrondianodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patrondianodolor", SqlDbType.VarChar).Value = DropDownList10.Text
                    End If
                    If DropDownList11.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronayunonodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronayunonodolor", SqlDbType.VarChar).Value = DropDownList11.Text
                    End If
                    If DropDownList12.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronevacnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronevacnodolor", SqlDbType.VarChar).Value = DropDownList12.Text
                    End If
                    da.SelectCommand.Parameters.Add("@patrongasesnodolor", SqlDbType.VarChar).Value = TextBox46.Text
                    da.SelectCommand.Parameters.Add("@patronvomitonodolor", SqlDbType.VarChar).Value = TextBox45.Text
                    da.SelectCommand.Parameters.Add("@aumentaintensnodolor", SqlDbType.VarChar).Value = TextBox47.Text
                    da.SelectCommand.Parameters.Add("@disminuyeintensnodolor", SqlDbType.VarChar).Value = TextBox48.Text
                    da.SelectCommand.Parameters.Add("@alimprovocannodolor", SqlDbType.VarChar).Value = TextBox49.Text
                    da.SelectCommand.Parameters.Add("@alimdisminuyennodolor", SqlDbType.VarChar).Value = TextBox50.Text
                    If DropDownList13.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@evacnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@evacnodolor", SqlDbType.VarChar).Value = DropDownList13.Text
                    End If
                    If DropDownList14.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@canalizgasesnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@canalizgasesnodolor", SqlDbType.VarChar).Value = DropDownList14.Text
                    End If
                    If DropDownList15.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@eructosnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@eructosnodolor", SqlDbType.VarChar).Value = DropDownList15.Text
                    End If
                    da.SelectCommand.Parameters.Add("@medicamcalmannodolor", SqlDbType.VarChar).Value = TextBox51.Text
                    da.SelectCommand.Parameters.Add("@mednocontrolannodolor", SqlDbType.VarChar).Value = TextBox52.Text
                    da.SelectCommand.Parameters.Add("@peso", SqlDbType.VarChar).Value = TextBox53.Text
                    da.SelectCommand.Parameters.Add("@talla", SqlDbType.VarChar).Value = TextBox54.Text
                    da.SelectCommand.Parameters.Add("@temp", SqlDbType.VarChar).Value = TextBox55.Text
                    da.SelectCommand.Parameters.Add("@ta", SqlDbType.VarChar).Value = TextBox56.Text
                    da.SelectCommand.Parameters.Add("@tc", SqlDbType.VarChar).Value = TextBox57.Text
                    da.SelectCommand.Parameters.Add("@fr", SqlDbType.VarChar).Value = TextBox58.Text
                    da.SelectCommand.Parameters.Add("@cabeza", SqlDbType.VarChar).Value = TextBox59.Text
                    da.SelectCommand.Parameters.Add("@torax", SqlDbType.VarChar).Value = TextBox60.Text
                    da.SelectCommand.Parameters.Add("@abdomen", SqlDbType.VarChar).Value = TextBox61.Text
                    da.SelectCommand.Parameters.Add("@extremidades", SqlDbType.VarChar).Value = TextBox62.Text
                    da.SelectCommand.Parameters.Add("@estudios", SqlDbType.VarChar).Value = TextBox63.Text
                    da.SelectCommand.Parameters.Add("@regionanalisis", SqlDbType.VarChar).Value = DropDownList52.Text
                    For Each li As ListItem In CheckBoxList10.Items
                        If li.Selected Then
                            If sintanalisis10.Length = 0 Then
                                sintanalisis10 = li.Value
                            Else
                                sintanalisis10 += ", " + li.Value
                            End If
                        End If
                    Next
                    If TextBox111.Text <> "" Then
                        sintanalisis10 += ", " + TextBox111.Text
                    End If
                    da.SelectCommand.Parameters.Add("@sintomaanalisis", SqlDbType.VarChar).Value = sintanalisis10
                    If TextBox92.Visible = True Then
                        da.SelectCommand.Parameters.Add("@sindromeclin", SqlDbType.VarChar).Value = TextBox92.Text
                    Else
                        da.SelectCommand.Parameters.Add("@sindromeclin", SqlDbType.VarChar).Value = DropDownList54.Text
                    End If
                    If TextBox93.Visible = True Then
                        da.SelectCommand.Parameters.Add("@subtipoanalisis", SqlDbType.VarChar).Value = TextBox93.Text
                    Else
                        da.SelectCommand.Parameters.Add("@subtipoanalisis", SqlDbType.VarChar).Value = DropDownList55.Text
                    End If
                    da.SelectCommand.Parameters.Add("@analisis", SqlDbType.VarChar).Value = TextBox100.Text
                    da.SelectCommand.Parameters.Add("@diagnostico", SqlDbType.VarChar).Value = TextBox7.Text
                    da.SelectCommand.Parameters.Add("@indicgrales", SqlDbType.VarChar).Value = TextBox114.Text
                    da.SelectCommand.Parameters.Add("@estudiosgrales", SqlDbType.VarChar).Value = TextBox79.Text
                    da.SelectCommand.Parameters.Add("@tratamiento", SqlDbType.VarChar).Value = TextBox82.Text
                    da.SelectCommand.Parameters.Add("@medico", SqlDbType.VarChar).Value = Label8.Text

                    da.SelectCommand.ExecuteNonQuery()
                    con.Close()


                Catch ex As Exception

                End Try
            End If
            If DropDownList56.Text <> "--Seleccionar--" Then


                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    da = New SqlDataAdapter("modificagastro", con)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.SelectCommand.Parameters.Add("@folionota", SqlDbType.Int).Value = Session("numnota2")
                    da.SelectCommand.Parameters.Add("@pacienteid", SqlDbType.Int).Value = Session("Paciente")
                    da.SelectCommand.Parameters.Add("@fechamodif", SqlDbType.DateTime).Value = Label2.Text
                    da.SelectCommand.Parameters.Add("@genero", SqlDbType.VarChar).Value = DropDownList200.Text
                    da.SelectCommand.Parameters.Add("@diarrea", SqlDbType.VarChar).Value = DropDownList17.Text
                    da.SelectCommand.Parameters.Add("@hernias", SqlDbType.VarChar).Value = DropDownList21.Text
                    da.SelectCommand.Parameters.Add("@cancer", SqlDbType.VarChar).Value = DropDownList25.Text
                    da.SelectCommand.Parameters.Add("@estrenimiento", SqlDbType.VarChar).Value = DropDownList29.Text
                    da.SelectCommand.Parameters.Add("@cancerdigestivo", SqlDbType.VarChar).Value = DropDownList33.Text
                    da.SelectCommand.Parameters.Add("@colecistitis", SqlDbType.VarChar).Value = DropDownList37.Text
                    da.SelectCommand.Parameters.Add("@hipertension", SqlDbType.VarChar).Value = DropDownList41.Text
                    da.SelectCommand.Parameters.Add("@cardiopatia", SqlDbType.VarChar).Value = DropDownList45.Text
                    da.SelectCommand.Parameters.Add("@autoinmunes", SqlDbType.VarChar).Value = DropDownList49.Text
                    da.SelectCommand.Parameters.Add("@diabetes", SqlDbType.VarChar).Value = DropDownList53.Text
                    da.SelectCommand.Parameters.Add("@endocrinopatias", SqlDbType.VarChar).Value = DropDownList57.Text
                    da.SelectCommand.Parameters.Add("@otrosenf", SqlDbType.VarChar).Value = TextBox85.Text
                    da.SelectCommand.Parameters.Add("@otrosfam", SqlDbType.VarChar).Value = DropDownList168.Text
                    da.SelectCommand.Parameters.Add("@ocupacion", SqlDbType.VarChar).Value = TextBox91.Text
                    da.SelectCommand.Parameters.Add("@escolaridad", SqlDbType.VarChar).Value = DropDownList61.Text
                    da.SelectCommand.Parameters.Add("@actfis", SqlDbType.VarChar).Value = DropDownList64.Text
                    If DropDownList65.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@alergicos", SqlDbType.VarChar).Value = DropDownList65.Text
                    Else
                        da.SelectCommand.Parameters.Add("@alergicos", SqlDbType.VarChar).Value = TextBox94.Text
                    End If

                    da.SelectCommand.Parameters.Add("@cirugias", SqlDbType.VarChar).Value = TextBox97.Text
                    da.SelectCommand.Parameters.Add("@complicacionescirugias", SqlDbType.VarChar).Value = TextBox115.Text
                    If DropDownList66.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@transfusiones", SqlDbType.VarChar).Value = DropDownList66.Text
                    Else
                        da.SelectCommand.Parameters.Add("@transfusiones", SqlDbType.VarChar).Value = TextBox116.Text
                    End If
                    da.SelectCommand.Parameters.Add("@tiposangre", SqlDbType.VarChar).Value = DropDownList67.Text
                    If DropDownList68.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@fracturas", SqlDbType.VarChar).Value = DropDownList68.Text
                    Else
                        da.SelectCommand.Parameters.Add("@fracturas", SqlDbType.VarChar).Value = TextBox117.Text
                    End If
                    If DropDownList69.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@hospprevias", SqlDbType.VarChar).Value = DropDownList69.Text
                    Else
                        da.SelectCommand.Parameters.Add("@hospprevias", SqlDbType.VarChar).Value = TextBox118.Text
                    End If
                    If DropDownList169.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempohipertension", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientohipertension", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempohipertension", SqlDbType.VarChar).Value = TextBox148.Text
                        da.SelectCommand.Parameters.Add("@tratamientohipertension", SqlDbType.VarChar).Value = TextBox149.Text
                    End If
                    If DropDownList170.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoinsuficiencia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoinsuficiencia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoinsuficiencia", SqlDbType.VarChar).Value = TextBox150.Text
                        da.SelectCommand.Parameters.Add("@tratamientoinsuficiencia", SqlDbType.VarChar).Value = TextBox151.Text
                    End If
                    If DropDownList171.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempocardisq", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientocardisq", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempocardisq", SqlDbType.VarChar).Value = TextBox152.Text
                        da.SelectCommand.Parameters.Add("@tratamientocardisq", SqlDbType.VarChar).Value = TextBox153.Text
                    End If
                    If DropDownList172.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoevc", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoevc", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoevc", SqlDbType.VarChar).Value = TextBox154.Text
                        da.SelectCommand.Parameters.Add("@tratamientoevc", SqlDbType.VarChar).Value = TextBox155.Text
                    End If
                    If DropDownList173.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoinsufvenosa", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoinsufvenosa", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoinsufvenosa", SqlDbType.VarChar).Value = TextBox156.Text
                        da.SelectCommand.Parameters.Add("@tratamientoinsufvenosa", SqlDbType.VarChar).Value = TextBox157.Text
                    End If
                    If DropDownList174.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodiabetes", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientodiabetes", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodiabetes", SqlDbType.VarChar).Value = TextBox158.Text
                        da.SelectCommand.Parameters.Add("@tratamientodiabetes", SqlDbType.VarChar).Value = TextBox159.Text
                    End If
                    If DropDownList175.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodislipidemmia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientodislipidemmia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodislipidemmia", SqlDbType.VarChar).Value = TextBox160.Text
                        da.SelectCommand.Parameters.Add("@tratamientodislipidemmia", SqlDbType.VarChar).Value = TextBox161.Text
                    End If
                    If DropDownList176.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoobesidad", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoobesidad", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoobesidad", SqlDbType.VarChar).Value = TextBox162.Text
                        da.SelectCommand.Parameters.Add("@tratamientoobesidad", SqlDbType.VarChar).Value = TextBox163.Text
                    End If
                    If DropDownList177.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoenftiroidea", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoenftiroidea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoenftiroidea", SqlDbType.VarChar).Value = TextBox164.Text
                        da.SelectCommand.Parameters.Add("@tratamientoenftiroidea", SqlDbType.VarChar).Value = TextBox165.Text
                    End If
                    If DropDownList178.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempocancer", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientocancer", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempocancer", SqlDbType.VarChar).Value = TextBox166.Text
                        da.SelectCommand.Parameters.Add("@tratamientocancer", SqlDbType.VarChar).Value = TextBox167.Text
                    End If
                    If DropDownList179.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempotuberculosis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientotuberculosis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempotuberculosis", SqlDbType.VarChar).Value = TextBox168.Text
                        da.SelectCommand.Parameters.Add("@tratamientotuberculosis", SqlDbType.VarChar).Value = TextBox169.Text
                    End If
                    If DropDownList180.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoasma", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoasma", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoasma", SqlDbType.VarChar).Value = TextBox170.Text
                        da.SelectCommand.Parameters.Add("@tratamientoasma", SqlDbType.VarChar).Value = TextBox171.Text
                    End If
                    If DropDownList181.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoepoc", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoepoc", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoepoc", SqlDbType.VarChar).Value = TextBox172.Text
                        da.SelectCommand.Parameters.Add("@tratamientoepoc", SqlDbType.VarChar).Value = TextBox173.Text
                    End If
                    If DropDownList182.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempobronquitis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientobronquitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempobronquitis", SqlDbType.VarChar).Value = TextBox174.Text
                        da.SelectCommand.Parameters.Add("@tratamientobronquitis", SqlDbType.VarChar).Value = TextBox175.Text
                    End If
                    If TextBox176.Text = "" Then
                        da.SelectCommand.Parameters.Add("@otraenf", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tiempootraenf", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientootraenf", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@otraenf", SqlDbType.VarChar).Value = TextBox176.Text
                        da.SelectCommand.Parameters.Add("@tiempootraenf", SqlDbType.VarChar).Value = TextBox177.Text
                        da.SelectCommand.Parameters.Add("@tratamientootraenf", SqlDbType.VarChar).Value = TextBox178.Text
                    End If
                    If DropDownList84.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoalcoholismo", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantalcoholismo", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoalcoholismo", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@cantalcoholismo", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If DropDownList85.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempotabaquismo", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@canttabaquismo", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempotabaquismo", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@canttabaquismo", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If DropDownList86.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodrogas", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantdrogas", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodrogas", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@cantdrogas", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If TextBox185.Text = "" Then
                        da.SelectCommand.Parameters.Add("@otrotox", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tiempootrotox", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantotrotox", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@otrotox", SqlDbType.VarChar).Value = TextBox185.Text
                        da.SelectCommand.Parameters.Add("@tiempootrotox", SqlDbType.VarChar).Value = TextBox186.Text
                        da.SelectCommand.Parameters.Add("@cantotrotox", SqlDbType.VarChar).Value = TextBox187.Text
                    End If
                        da.SelectCommand.Parameters.Add("@ultregla", SqlDbType.Date).Value = DBNull.Value
                    
                    da.SelectCommand.Parameters.Add("@ritmo", SqlDbType.VarChar).Value = TextBox124.Text
                    da.SelectCommand.Parameters.Add("@menopausia", SqlDbType.VarChar).Value = DropDownList87.Text
                    da.SelectCommand.Parameters.Add("@gesta", SqlDbType.Int).Value = DropDownList88.Text
                    da.SelectCommand.Parameters.Add("@para", SqlDbType.Int).Value = DropDownList89.Text
                    da.SelectCommand.Parameters.Add("@cesarea", SqlDbType.Int).Value = DropDownList90.Text
                    da.SelectCommand.Parameters.Add("@aborto", SqlDbType.Int).Value = DropDownList91.Text
                    da.SelectCommand.Parameters.Add("@metplanfam", SqlDbType.VarChar).Value = DropDownList92.Text
                    da.SelectCommand.Parameters.Add("@otroplanfam", SqlDbType.VarChar).Value = TextBox125.Text
                    If DropDownList93.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempofiebre", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionfiebre", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempofiebre", SqlDbType.VarChar).Value = TextBox188.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionfiebre", SqlDbType.VarChar).Value = TextBox189.Text
                    End If
                    If DropDownList94.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoastenia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionastenia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoastenia", SqlDbType.VarChar).Value = TextBox191.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionastenia", SqlDbType.VarChar).Value = TextBox192.Text
                    End If
                    If DropDownList95.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoadinamia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionadinamia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoadinamia", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionadinamia", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList96.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoanorexia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionanorexia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoanorexia", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionanorexia", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList97.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoperdidapeso", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionperdidapeso", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoperdidapeso", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionperdidapeso", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList98.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@obstruccionnasal", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@obstruccionnasal", SqlDbType.VarChar).Value = DropDownList183.Text
                    End If
                    If DropDownList99.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@ronqueramatutina", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@ronqueramatutina", SqlDbType.VarChar).Value = DropDownList184.Text
                    End If
                    If DropDownList100.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@sinusitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@sinusitis", SqlDbType.VarChar).Value = DropDownList185.Text
                    End If
                    If DropDownList101.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@disfonia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@disfonia", SqlDbType.VarChar).Value = DropDownList186.Text
                    End If
                    If DropDownList102.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@disnea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@disnea", SqlDbType.VarChar).Value = DropDownList187.Text
                    End If
                    If DropDownList103.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@sibilancias", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@sibilancias", SqlDbType.VarChar).Value = DropDownList188.Text
                    End If
                    If DropDownList104.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tos", SqlDbType.VarChar).Value = DropDownList189.Text
                    End If
                    If DropDownList105.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@cianosis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@cianosis", SqlDbType.VarChar).Value = DropDownList190.Text
                    End If
                    If DropDownList106.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@asma", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@asma", SqlDbType.VarChar).Value = DropDownList191.Text
                    End If
                    If DropDownList107.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorolipotimia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacioneslipotimia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorolipotimia", SqlDbType.VarChar).Value = DropDownList192.Text
                        da.SelectCommand.Parameters.Add("@sensacioneslipotimia", SqlDbType.VarChar).Value = TextBox203.Text
                    End If
                    If DropDownList108.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorosincope", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionessincope", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorosincope", SqlDbType.VarChar).Value = DropDownList193.Text
                        da.SelectCommand.Parameters.Add("@sensacionessincope", SqlDbType.VarChar).Value = TextBox204.Text
                    End If
                    If DropDownList109.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorofatiga", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesfatiga", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorofatiga", SqlDbType.VarChar).Value = DropDownList194.Text
                        da.SelectCommand.Parameters.Add("@sensacionesfatiga", SqlDbType.VarChar).Value = TextBox205.Text
                    End If
                    If DropDownList110.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoropalpitaciones", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionespalpitaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoropalpitaciones", SqlDbType.VarChar).Value = DropDownList195.Text
                        da.SelectCommand.Parameters.Add("@sensacionespalpitaciones", SqlDbType.VarChar).Value = TextBox206.Text
                    End If
                    If DropDownList111.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorodolprecordial", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesdolprecordial", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorodolprecordial", SqlDbType.VarChar).Value = DropDownList196.Text
                        da.SelectCommand.Parameters.Add("@sensacionesdolprecordial", SqlDbType.VarChar).Value = TextBox207.Text
                    End If
                    If DropDownList112.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoroedema", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesedema", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoroedema", SqlDbType.VarChar).Value = DropDownList197.Text
                        da.SelectCommand.Parameters.Add("@sensacionesedema", SqlDbType.VarChar).Value = TextBox208.Text
                    End If
                    If DropDownList113.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorodisnea", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesdisnea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorodisnea", SqlDbType.VarChar).Value = DropDownList198.Text
                        da.SelectCommand.Parameters.Add("@sensacionesdisnea", SqlDbType.VarChar).Value = TextBox209.Text
                    End If
                    If DropDownList114.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoroascitis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesascitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoroascitis", SqlDbType.VarChar).Value = DropDownList199.Text
                        da.SelectCommand.Parameters.Add("@sensacionesascitis", SqlDbType.VarChar).Value = TextBox210.Text
                    End If
                    da.SelectCommand.Parameters.Add("@disuria", SqlDbType.VarChar).Value = DropDownList138.Text
                    da.SelectCommand.Parameters.Add("@poliaquiuria", SqlDbType.VarChar).Value = DropDownList139.Text
                    da.SelectCommand.Parameters.Add("@tenesmo", SqlDbType.VarChar).Value = DropDownList140.Text
                    da.SelectCommand.Parameters.Add("@hematuria", SqlDbType.VarChar).Value = DropDownList141.Text
                    da.SelectCommand.Parameters.Add("@suprapubica", SqlDbType.VarChar).Value = DropDownList142.Text
                    da.SelectCommand.Parameters.Add("@lumbar", SqlDbType.VarChar).Value = DropDownList143.Text
                    da.SelectCommand.Parameters.Add("@ninguno", SqlDbType.VarChar).Value = DropDownList144.Text
                    da.SelectCommand.Parameters.Add("@otrosdolores", SqlDbType.VarChar).Value = TextBox131.Text
                    da.SelectCommand.Parameters.Add("@tendenciahemorragia", SqlDbType.VarChar).Value = DropDownList145.Text
                    da.SelectCommand.Parameters.Add("@adenopatias", SqlDbType.VarChar).Value = DropDownList146.Text
                    da.SelectCommand.Parameters.Add("@infecrecurrentes", SqlDbType.VarChar).Value = DropDownList147.Text
                    da.SelectCommand.Parameters.Add("@anemia", SqlDbType.VarChar).Value = DropDownList148.Text
                    da.SelectCommand.Parameters.Add("@hemolinfaticonegado", SqlDbType.VarChar).Value = DropDownList149.Text
                    da.SelectCommand.Parameters.Add("@otroshemolinf", SqlDbType.VarChar).Value = TextBox132.Text
                    da.SelectCommand.Parameters.Add("@paralisis", SqlDbType.VarChar).Value = DropDownList150.Text
                    da.SelectCommand.Parameters.Add("@parestesisas", SqlDbType.VarChar).Value = DropDownList151.Text
                    da.SelectCommand.Parameters.Add("@temblores", SqlDbType.VarChar).Value = DropDownList152.Text
                    da.SelectCommand.Parameters.Add("@alteracionesmarcha", SqlDbType.VarChar).Value = DropDownList153.Text
                    da.SelectCommand.Parameters.Add("@cefalea", SqlDbType.VarChar).Value = DropDownList154.Text
                    da.SelectCommand.Parameters.Add("@sisnerviosonegado", SqlDbType.VarChar).Value = DropDownList155.Text
                    da.SelectCommand.Parameters.Add("@otrossisnerv", SqlDbType.VarChar).Value = TextBox133.Text
                    da.SelectCommand.Parameters.Add("@padactual", SqlDbType.VarChar).Value = TextBox1.Text
                    da.SelectCommand.Parameters.Add("@motivoconsulta", SqlDbType.VarChar).Value = TextBox12.Text
                    da.SelectCommand.Parameters.Add("@region", SqlDbType.VarChar).Value = TextBox13.Text
                    da.SelectCommand.Parameters.Add("@inicia", SqlDbType.VarChar).Value = TextBox14.Text
                    da.SelectCommand.Parameters.Add("@irradiacion", SqlDbType.VarChar).Value = TextBox15.Text
                    da.SelectCommand.Parameters.Add("@migracion", SqlDbType.VarChar).Value = TextBox16.Text
                    da.SelectCommand.Parameters.Add("@expansion", SqlDbType.VarChar).Value = TextBox17.Text
                    da.SelectCommand.Parameters.Add("@proyeccion", SqlDbType.VarChar).Value = TextBox18.Text
                    da.SelectCommand.Parameters.Add("@semejanzacualitativos", SqlDbType.VarChar).Value = TextBox19.Text
                    If DropDownList1.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@localizacioncualitativos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@localizacioncualitativos", SqlDbType.VarChar).Value = DropDownList1.Text
                    End If
                    da.SelectCommand.Parameters.Add("@intensidadcuantitativos", SqlDbType.VarChar).Value = TextBox20.Text
                    da.SelectCommand.Parameters.Add("@maximaintensidadcuantitativos", SqlDbType.VarChar).Value = TextBox21.Text
                    da.SelectCommand.Parameters.Add("@intensidadultimoevento", SqlDbType.VarChar).Value = TextBox22.Text
                    da.SelectCommand.Parameters.Add("@iniciocronologicos", SqlDbType.VarChar).Value = TextBox23.Text
                    If DropDownList2.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patroncronologicos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patroncronologicos", SqlDbType.VarChar).Value = DropDownList2.Text
                    End If
                    da.SelectCommand.Parameters.Add("@duracion", SqlDbType.VarChar).Value = TextBox24.Text
                    da.SelectCommand.Parameters.Add("@frecuenciadia", SqlDbType.VarChar).Value = TextBox25.Text
                    da.SelectCommand.Parameters.Add("@frecuenciamensual", SqlDbType.VarChar).Value = TextBox26.Text
                    da.SelectCommand.Parameters.Add("@ultimoevento", SqlDbType.VarChar).Value = TextBox27.Text
                    If DropDownList3.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patrondia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patrondia", SqlDbType.VarChar).Value = DropDownList3.Text
                    End If
                    If DropDownList4.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronayuno", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronayuno", SqlDbType.VarChar).Value = DropDownList4.Text
                    End If
                    If DropDownList5.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronevacuaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronevacuaciones", SqlDbType.VarChar).Value = DropDownList5.Text
                    End If
                    da.SelectCommand.Parameters.Add("@patronevacuaciones2", SqlDbType.VarChar).Value = TextBox28.Text
                    da.SelectCommand.Parameters.Add("@patrongases", SqlDbType.VarChar).Value = TextBox29.Text
                    da.SelectCommand.Parameters.Add("@patronvomito", SqlDbType.VarChar).Value = TextBox30.Text
                    da.SelectCommand.Parameters.Add("@aumentaintesidad", SqlDbType.VarChar).Value = TextBox33.Text
                    da.SelectCommand.Parameters.Add("@disminuyeintensidad", SqlDbType.VarChar).Value = TextBox33.Text
                    da.SelectCommand.Parameters.Add("@alimdisminuyen", SqlDbType.VarChar).Value = TextBox35.Text
                    If DropDownList7.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@evacuaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@evacuaciones", SqlDbType.VarChar).Value = DropDownList7.Text
                    End If
                    If DropDownList8.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@canalizacionesgases", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@canalizacionesgases", SqlDbType.VarChar).Value = DropDownList8.Text
                    End If
                    If DropDownList9.Text = "-Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@eructos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@eructos", SqlDbType.VarChar).Value = DropDownList9.Text
                    End If
                    da.SelectCommand.Parameters.Add("@medicamcalman", SqlDbType.VarChar).Value = TextBox32.Text
                    da.SelectCommand.Parameters.Add("@medicamnocontrolan", SqlDbType.VarChar).Value = TextBox31.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional1", SqlDbType.VarChar).Value = TextBox36.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional2", SqlDbType.VarChar).Value = TextBox37.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional3", SqlDbType.VarChar).Value = TextBox38.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional4", SqlDbType.VarChar).Value = TextBox39.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre1", SqlDbType.VarChar).Value = TextBox40.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre2", SqlDbType.VarChar).Value = TextBox41.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre3", SqlDbType.VarChar).Value = TextBox42.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre4", SqlDbType.VarChar).Value = TextBox43.Text
                    da.SelectCommand.Parameters.Add("@sintomanodolor", SqlDbType.VarChar).Value = TextBox44.Text
                    da.SelectCommand.Parameters.Add("@inicionodolor", SqlDbType.VarChar).Value = TextBox2.Text
                    If DropDownList6.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronnodolor", SqlDbType.VarChar).Value = DropDownList6.Text
                    End If
                    da.SelectCommand.Parameters.Add("@duracionnodolor", SqlDbType.VarChar).Value = TextBox3.Text
                    da.SelectCommand.Parameters.Add("@frecuenciadianodolor", SqlDbType.VarChar).Value = TextBox4.Text
                    da.SelectCommand.Parameters.Add("@frecuenciamesnodolor", SqlDbType.VarChar).Value = TextBox5.Text
                    da.SelectCommand.Parameters.Add("@ulteventonodolor", SqlDbType.VarChar).Value = TextBox6.Text
                    If DropDownList10.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patrondianodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patrondianodolor", SqlDbType.VarChar).Value = DropDownList10.Text
                    End If
                    If DropDownList11.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronayunonodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronayunonodolor", SqlDbType.VarChar).Value = DropDownList11.Text
                    End If
                    If DropDownList12.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronevacnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronevacnodolor", SqlDbType.VarChar).Value = DropDownList12.Text
                    End If
                    da.SelectCommand.Parameters.Add("@patrongasesnodolor", SqlDbType.VarChar).Value = TextBox46.Text
                    da.SelectCommand.Parameters.Add("@patronvomitonodolor", SqlDbType.VarChar).Value = TextBox45.Text
                    da.SelectCommand.Parameters.Add("@aumentaintensnodolor", SqlDbType.VarChar).Value = TextBox47.Text
                    da.SelectCommand.Parameters.Add("@disminuyeintensnodolor", SqlDbType.VarChar).Value = TextBox48.Text
                    da.SelectCommand.Parameters.Add("@alimprovocannodolor", SqlDbType.VarChar).Value = TextBox49.Text
                    da.SelectCommand.Parameters.Add("@alimdisminuyennodolor", SqlDbType.VarChar).Value = TextBox50.Text
                    If DropDownList13.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@evacnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@evacnodolor", SqlDbType.VarChar).Value = DropDownList13.Text
                    End If
                    If DropDownList14.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@canalizgasesnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@canalizgasesnodolor", SqlDbType.VarChar).Value = DropDownList14.Text
                    End If
                    If DropDownList15.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@eructosnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@eructosnodolor", SqlDbType.VarChar).Value = DropDownList15.Text
                    End If
                    da.SelectCommand.Parameters.Add("@medicamcalmannodolor", SqlDbType.VarChar).Value = TextBox51.Text
                    da.SelectCommand.Parameters.Add("@mednocontrolannodolor", SqlDbType.VarChar).Value = TextBox52.Text
                    da.SelectCommand.Parameters.Add("@peso", SqlDbType.VarChar).Value = TextBox53.Text
                    da.SelectCommand.Parameters.Add("@talla", SqlDbType.VarChar).Value = TextBox54.Text
                    da.SelectCommand.Parameters.Add("@temp", SqlDbType.VarChar).Value = TextBox55.Text
                    da.SelectCommand.Parameters.Add("@ta", SqlDbType.VarChar).Value = TextBox56.Text
                    da.SelectCommand.Parameters.Add("@tc", SqlDbType.VarChar).Value = TextBox57.Text
                    da.SelectCommand.Parameters.Add("@fr", SqlDbType.VarChar).Value = TextBox58.Text
                    da.SelectCommand.Parameters.Add("@cabeza", SqlDbType.VarChar).Value = TextBox59.Text
                    da.SelectCommand.Parameters.Add("@torax", SqlDbType.VarChar).Value = TextBox60.Text
                    da.SelectCommand.Parameters.Add("@abdomen", SqlDbType.VarChar).Value = TextBox61.Text
                    da.SelectCommand.Parameters.Add("@extremidades", SqlDbType.VarChar).Value = TextBox62.Text
                    da.SelectCommand.Parameters.Add("@estudios", SqlDbType.VarChar).Value = TextBox63.Text
                    da.SelectCommand.Parameters.Add("@regionanalisis", SqlDbType.VarChar).Value = DropDownList56.Text
                    For Each li As ListItem In CheckBoxList11.Items
                        If li.Selected Then
                            If sintanalisis11.Length = 0 Then
                                sintanalisis11 = li.Value
                            Else
                                sintanalisis11 += ", " + li.Value
                            End If
                        End If
                    Next
                    If TextBox112.Text <> "" Then
                        sintanalisis11 += ", " + TextBox112.Text
                    End If
                    da.SelectCommand.Parameters.Add("@sintomaanalisis", SqlDbType.VarChar).Value = sintanalisis11
                    If TextBox95.Visible = True Then
                        da.SelectCommand.Parameters.Add("@sindromeclin", SqlDbType.VarChar).Value = TextBox95.Text
                    Else
                        da.SelectCommand.Parameters.Add("@sindromeclin", SqlDbType.VarChar).Value = DropDownList58.Text
                    End If
                    If TextBox96.Visible = True Then
                        da.SelectCommand.Parameters.Add("@subtipoanalisis", SqlDbType.VarChar).Value = TextBox96.Text
                    Else
                        da.SelectCommand.Parameters.Add("@subtipoanalisis", SqlDbType.VarChar).Value = DropDownList59.Text
                    End If
                    da.SelectCommand.Parameters.Add("@analisis", SqlDbType.VarChar).Value = TextBox100.Text
                    da.SelectCommand.Parameters.Add("@diagnostico", SqlDbType.VarChar).Value = TextBox7.Text
                    da.SelectCommand.Parameters.Add("@indicgrales", SqlDbType.VarChar).Value = TextBox114.Text
                    da.SelectCommand.Parameters.Add("@estudiosgrales", SqlDbType.VarChar).Value = TextBox79.Text
                    da.SelectCommand.Parameters.Add("@tratamiento", SqlDbType.VarChar).Value = TextBox82.Text
                    da.SelectCommand.Parameters.Add("@medico", SqlDbType.VarChar).Value = Label8.Text

                    da.SelectCommand.ExecuteNonQuery()
                    con.Close()


                Catch ex As Exception

                End Try
            End If

            If DropDownList60.Text <> "--Seleccionar--" Then


                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    da = New SqlDataAdapter("modificagastro", con)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.SelectCommand.Parameters.Add("@folionota", SqlDbType.Int).Value = Session("numnota2")
                    da.SelectCommand.Parameters.Add("@pacienteid", SqlDbType.Int).Value = Session("Paciente")
                    da.SelectCommand.Parameters.Add("@fechamodif", SqlDbType.DateTime).Value = Label2.Text
                    da.SelectCommand.Parameters.Add("@genero", SqlDbType.VarChar).Value = DropDownList200.Text
                    da.SelectCommand.Parameters.Add("@diarrea", SqlDbType.VarChar).Value = DropDownList17.Text
                    da.SelectCommand.Parameters.Add("@hernias", SqlDbType.VarChar).Value = DropDownList21.Text
                    da.SelectCommand.Parameters.Add("@cancer", SqlDbType.VarChar).Value = DropDownList25.Text
                    da.SelectCommand.Parameters.Add("@estrenimiento", SqlDbType.VarChar).Value = DropDownList29.Text
                    da.SelectCommand.Parameters.Add("@cancerdigestivo", SqlDbType.VarChar).Value = DropDownList33.Text
                    da.SelectCommand.Parameters.Add("@colecistitis", SqlDbType.VarChar).Value = DropDownList37.Text
                    da.SelectCommand.Parameters.Add("@hipertension", SqlDbType.VarChar).Value = DropDownList41.Text
                    da.SelectCommand.Parameters.Add("@cardiopatia", SqlDbType.VarChar).Value = DropDownList45.Text
                    da.SelectCommand.Parameters.Add("@autoinmunes", SqlDbType.VarChar).Value = DropDownList49.Text
                    da.SelectCommand.Parameters.Add("@diabetes", SqlDbType.VarChar).Value = DropDownList53.Text
                    da.SelectCommand.Parameters.Add("@endocrinopatias", SqlDbType.VarChar).Value = DropDownList57.Text
                    da.SelectCommand.Parameters.Add("@otrosenf", SqlDbType.VarChar).Value = TextBox85.Text
                    da.SelectCommand.Parameters.Add("@otrosfam", SqlDbType.VarChar).Value = DropDownList168.Text
                    da.SelectCommand.Parameters.Add("@ocupacion", SqlDbType.VarChar).Value = TextBox91.Text
                    da.SelectCommand.Parameters.Add("@escolaridad", SqlDbType.VarChar).Value = DropDownList61.Text
                    da.SelectCommand.Parameters.Add("@actfis", SqlDbType.VarChar).Value = DropDownList64.Text
                    If DropDownList65.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@alergicos", SqlDbType.VarChar).Value = DropDownList65.Text
                    Else
                        da.SelectCommand.Parameters.Add("@alergicos", SqlDbType.VarChar).Value = TextBox94.Text
                    End If

                    da.SelectCommand.Parameters.Add("@cirugias", SqlDbType.VarChar).Value = TextBox97.Text
                    da.SelectCommand.Parameters.Add("@complicacionescirugias", SqlDbType.VarChar).Value = TextBox115.Text
                    If DropDownList66.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@transfusiones", SqlDbType.VarChar).Value = DropDownList66.Text
                    Else
                        da.SelectCommand.Parameters.Add("@transfusiones", SqlDbType.VarChar).Value = TextBox116.Text
                    End If
                    da.SelectCommand.Parameters.Add("@tiposangre", SqlDbType.VarChar).Value = DropDownList67.Text
                    If DropDownList68.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@fracturas", SqlDbType.VarChar).Value = DropDownList68.Text
                    Else
                        da.SelectCommand.Parameters.Add("@fracturas", SqlDbType.VarChar).Value = TextBox117.Text
                    End If
                    If DropDownList69.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@hospprevias", SqlDbType.VarChar).Value = DropDownList69.Text
                    Else
                        da.SelectCommand.Parameters.Add("@hospprevias", SqlDbType.VarChar).Value = TextBox118.Text
                    End If
                    If DropDownList169.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempohipertension", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientohipertension", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempohipertension", SqlDbType.VarChar).Value = TextBox148.Text
                        da.SelectCommand.Parameters.Add("@tratamientohipertension", SqlDbType.VarChar).Value = TextBox149.Text
                    End If
                    If DropDownList170.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoinsuficiencia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoinsuficiencia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoinsuficiencia", SqlDbType.VarChar).Value = TextBox150.Text
                        da.SelectCommand.Parameters.Add("@tratamientoinsuficiencia", SqlDbType.VarChar).Value = TextBox151.Text
                    End If
                    If DropDownList171.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempocardisq", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientocardisq", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempocardisq", SqlDbType.VarChar).Value = TextBox152.Text
                        da.SelectCommand.Parameters.Add("@tratamientocardisq", SqlDbType.VarChar).Value = TextBox153.Text
                    End If
                    If DropDownList172.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoevc", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoevc", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoevc", SqlDbType.VarChar).Value = TextBox154.Text
                        da.SelectCommand.Parameters.Add("@tratamientoevc", SqlDbType.VarChar).Value = TextBox155.Text
                    End If
                    If DropDownList173.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoinsufvenosa", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoinsufvenosa", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoinsufvenosa", SqlDbType.VarChar).Value = TextBox156.Text
                        da.SelectCommand.Parameters.Add("@tratamientoinsufvenosa", SqlDbType.VarChar).Value = TextBox157.Text
                    End If
                    If DropDownList174.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodiabetes", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientodiabetes", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodiabetes", SqlDbType.VarChar).Value = TextBox158.Text
                        da.SelectCommand.Parameters.Add("@tratamientodiabetes", SqlDbType.VarChar).Value = TextBox159.Text
                    End If
                    If DropDownList175.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodislipidemmia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientodislipidemmia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodislipidemmia", SqlDbType.VarChar).Value = TextBox160.Text
                        da.SelectCommand.Parameters.Add("@tratamientodislipidemmia", SqlDbType.VarChar).Value = TextBox161.Text
                    End If
                    If DropDownList176.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoobesidad", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoobesidad", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoobesidad", SqlDbType.VarChar).Value = TextBox162.Text
                        da.SelectCommand.Parameters.Add("@tratamientoobesidad", SqlDbType.VarChar).Value = TextBox163.Text
                    End If
                    If DropDownList177.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoenftiroidea", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoenftiroidea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoenftiroidea", SqlDbType.VarChar).Value = TextBox164.Text
                        da.SelectCommand.Parameters.Add("@tratamientoenftiroidea", SqlDbType.VarChar).Value = TextBox165.Text
                    End If
                    If DropDownList178.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempocancer", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientocancer", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempocancer", SqlDbType.VarChar).Value = TextBox166.Text
                        da.SelectCommand.Parameters.Add("@tratamientocancer", SqlDbType.VarChar).Value = TextBox167.Text
                    End If
                    If DropDownList179.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempotuberculosis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientotuberculosis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempotuberculosis", SqlDbType.VarChar).Value = TextBox168.Text
                        da.SelectCommand.Parameters.Add("@tratamientotuberculosis", SqlDbType.VarChar).Value = TextBox169.Text
                    End If
                    If DropDownList180.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoasma", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoasma", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoasma", SqlDbType.VarChar).Value = TextBox170.Text
                        da.SelectCommand.Parameters.Add("@tratamientoasma", SqlDbType.VarChar).Value = TextBox171.Text
                    End If
                    If DropDownList181.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoepoc", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoepoc", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoepoc", SqlDbType.VarChar).Value = TextBox172.Text
                        da.SelectCommand.Parameters.Add("@tratamientoepoc", SqlDbType.VarChar).Value = TextBox173.Text
                    End If
                    If DropDownList182.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempobronquitis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientobronquitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempobronquitis", SqlDbType.VarChar).Value = TextBox174.Text
                        da.SelectCommand.Parameters.Add("@tratamientobronquitis", SqlDbType.VarChar).Value = TextBox175.Text
                    End If
                    If TextBox176.Text = "" Then
                        da.SelectCommand.Parameters.Add("@otraenf", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tiempootraenf", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientootraenf", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@otraenf", SqlDbType.VarChar).Value = TextBox176.Text
                        da.SelectCommand.Parameters.Add("@tiempootraenf", SqlDbType.VarChar).Value = TextBox177.Text
                        da.SelectCommand.Parameters.Add("@tratamientootraenf", SqlDbType.VarChar).Value = TextBox178.Text
                    End If
                    If DropDownList84.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoalcoholismo", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantalcoholismo", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoalcoholismo", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@cantalcoholismo", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If DropDownList85.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempotabaquismo", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@canttabaquismo", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempotabaquismo", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@canttabaquismo", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If DropDownList86.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodrogas", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantdrogas", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodrogas", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@cantdrogas", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If TextBox185.Text = "" Then
                        da.SelectCommand.Parameters.Add("@otrotox", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tiempootrotox", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantotrotox", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@otrotox", SqlDbType.VarChar).Value = TextBox185.Text
                        da.SelectCommand.Parameters.Add("@tiempootrotox", SqlDbType.VarChar).Value = TextBox186.Text
                        da.SelectCommand.Parameters.Add("@cantotrotox", SqlDbType.VarChar).Value = TextBox187.Text
                    End If
                        da.SelectCommand.Parameters.Add("@ultregla", SqlDbType.Date).Value = DBNull.Value
                   
                    da.SelectCommand.Parameters.Add("@ritmo", SqlDbType.VarChar).Value = TextBox124.Text
                    da.SelectCommand.Parameters.Add("@menopausia", SqlDbType.VarChar).Value = DropDownList87.Text
                    da.SelectCommand.Parameters.Add("@gesta", SqlDbType.Int).Value = DropDownList88.Text
                    da.SelectCommand.Parameters.Add("@para", SqlDbType.Int).Value = DropDownList89.Text
                    da.SelectCommand.Parameters.Add("@cesarea", SqlDbType.Int).Value = DropDownList90.Text
                    da.SelectCommand.Parameters.Add("@aborto", SqlDbType.Int).Value = DropDownList91.Text
                    da.SelectCommand.Parameters.Add("@metplanfam", SqlDbType.VarChar).Value = DropDownList92.Text
                    da.SelectCommand.Parameters.Add("@otroplanfam", SqlDbType.VarChar).Value = TextBox125.Text
                    If DropDownList93.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempofiebre", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionfiebre", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempofiebre", SqlDbType.VarChar).Value = TextBox188.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionfiebre", SqlDbType.VarChar).Value = TextBox189.Text
                    End If
                    If DropDownList94.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoastenia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionastenia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoastenia", SqlDbType.VarChar).Value = TextBox191.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionastenia", SqlDbType.VarChar).Value = TextBox192.Text
                    End If
                    If DropDownList95.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoadinamia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionadinamia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoadinamia", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionadinamia", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList96.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoanorexia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionanorexia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoanorexia", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionanorexia", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList97.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoperdidapeso", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionperdidapeso", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoperdidapeso", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionperdidapeso", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList98.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@obstruccionnasal", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@obstruccionnasal", SqlDbType.VarChar).Value = DropDownList183.Text
                    End If
                    If DropDownList99.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@ronqueramatutina", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@ronqueramatutina", SqlDbType.VarChar).Value = DropDownList184.Text
                    End If
                    If DropDownList100.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@sinusitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@sinusitis", SqlDbType.VarChar).Value = DropDownList185.Text
                    End If
                    If DropDownList101.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@disfonia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@disfonia", SqlDbType.VarChar).Value = DropDownList186.Text
                    End If
                    If DropDownList102.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@disnea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@disnea", SqlDbType.VarChar).Value = DropDownList187.Text
                    End If
                    If DropDownList103.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@sibilancias", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@sibilancias", SqlDbType.VarChar).Value = DropDownList188.Text
                    End If
                    If DropDownList104.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tos", SqlDbType.VarChar).Value = DropDownList189.Text
                    End If
                    If DropDownList105.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@cianosis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@cianosis", SqlDbType.VarChar).Value = DropDownList190.Text
                    End If
                    If DropDownList106.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@asma", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@asma", SqlDbType.VarChar).Value = DropDownList191.Text
                    End If
                    If DropDownList107.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorolipotimia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacioneslipotimia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorolipotimia", SqlDbType.VarChar).Value = DropDownList192.Text
                        da.SelectCommand.Parameters.Add("@sensacioneslipotimia", SqlDbType.VarChar).Value = TextBox203.Text
                    End If
                    If DropDownList108.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorosincope", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionessincope", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorosincope", SqlDbType.VarChar).Value = DropDownList193.Text
                        da.SelectCommand.Parameters.Add("@sensacionessincope", SqlDbType.VarChar).Value = TextBox204.Text
                    End If
                    If DropDownList109.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorofatiga", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesfatiga", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorofatiga", SqlDbType.VarChar).Value = DropDownList194.Text
                        da.SelectCommand.Parameters.Add("@sensacionesfatiga", SqlDbType.VarChar).Value = TextBox205.Text
                    End If
                    If DropDownList110.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoropalpitaciones", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionespalpitaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoropalpitaciones", SqlDbType.VarChar).Value = DropDownList195.Text
                        da.SelectCommand.Parameters.Add("@sensacionespalpitaciones", SqlDbType.VarChar).Value = TextBox206.Text
                    End If
                    If DropDownList111.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorodolprecordial", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesdolprecordial", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorodolprecordial", SqlDbType.VarChar).Value = DropDownList196.Text
                        da.SelectCommand.Parameters.Add("@sensacionesdolprecordial", SqlDbType.VarChar).Value = TextBox207.Text
                    End If
                    If DropDownList112.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoroedema", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesedema", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoroedema", SqlDbType.VarChar).Value = DropDownList197.Text
                        da.SelectCommand.Parameters.Add("@sensacionesedema", SqlDbType.VarChar).Value = TextBox208.Text
                    End If
                    If DropDownList113.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorodisnea", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesdisnea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorodisnea", SqlDbType.VarChar).Value = DropDownList198.Text
                        da.SelectCommand.Parameters.Add("@sensacionesdisnea", SqlDbType.VarChar).Value = TextBox209.Text
                    End If
                    If DropDownList114.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoroascitis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesascitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoroascitis", SqlDbType.VarChar).Value = DropDownList199.Text
                        da.SelectCommand.Parameters.Add("@sensacionesascitis", SqlDbType.VarChar).Value = TextBox210.Text
                    End If
                    da.SelectCommand.Parameters.Add("@disuria", SqlDbType.VarChar).Value = DropDownList138.Text
                    da.SelectCommand.Parameters.Add("@poliaquiuria", SqlDbType.VarChar).Value = DropDownList139.Text
                    da.SelectCommand.Parameters.Add("@tenesmo", SqlDbType.VarChar).Value = DropDownList140.Text
                    da.SelectCommand.Parameters.Add("@hematuria", SqlDbType.VarChar).Value = DropDownList141.Text
                    da.SelectCommand.Parameters.Add("@suprapubica", SqlDbType.VarChar).Value = DropDownList142.Text
                    da.SelectCommand.Parameters.Add("@lumbar", SqlDbType.VarChar).Value = DropDownList143.Text
                    da.SelectCommand.Parameters.Add("@ninguno", SqlDbType.VarChar).Value = DropDownList144.Text
                    da.SelectCommand.Parameters.Add("@otrosdolores", SqlDbType.VarChar).Value = TextBox131.Text
                    da.SelectCommand.Parameters.Add("@tendenciahemorragia", SqlDbType.VarChar).Value = DropDownList145.Text
                    da.SelectCommand.Parameters.Add("@adenopatias", SqlDbType.VarChar).Value = DropDownList146.Text
                    da.SelectCommand.Parameters.Add("@infecrecurrentes", SqlDbType.VarChar).Value = DropDownList147.Text
                    da.SelectCommand.Parameters.Add("@anemia", SqlDbType.VarChar).Value = DropDownList148.Text
                    da.SelectCommand.Parameters.Add("@hemolinfaticonegado", SqlDbType.VarChar).Value = DropDownList149.Text
                    da.SelectCommand.Parameters.Add("@otroshemolinf", SqlDbType.VarChar).Value = TextBox132.Text
                    da.SelectCommand.Parameters.Add("@paralisis", SqlDbType.VarChar).Value = DropDownList150.Text
                    da.SelectCommand.Parameters.Add("@parestesisas", SqlDbType.VarChar).Value = DropDownList151.Text
                    da.SelectCommand.Parameters.Add("@temblores", SqlDbType.VarChar).Value = DropDownList152.Text
                    da.SelectCommand.Parameters.Add("@alteracionesmarcha", SqlDbType.VarChar).Value = DropDownList153.Text
                    da.SelectCommand.Parameters.Add("@cefalea", SqlDbType.VarChar).Value = DropDownList154.Text
                    da.SelectCommand.Parameters.Add("@sisnerviosonegado", SqlDbType.VarChar).Value = DropDownList155.Text
                    da.SelectCommand.Parameters.Add("@otrossisnerv", SqlDbType.VarChar).Value = TextBox133.Text
                    da.SelectCommand.Parameters.Add("@padactual", SqlDbType.VarChar).Value = TextBox1.Text
                    da.SelectCommand.Parameters.Add("@motivoconsulta", SqlDbType.VarChar).Value = TextBox12.Text
                    da.SelectCommand.Parameters.Add("@region", SqlDbType.VarChar).Value = TextBox13.Text
                    da.SelectCommand.Parameters.Add("@inicia", SqlDbType.VarChar).Value = TextBox14.Text
                    da.SelectCommand.Parameters.Add("@irradiacion", SqlDbType.VarChar).Value = TextBox15.Text
                    da.SelectCommand.Parameters.Add("@migracion", SqlDbType.VarChar).Value = TextBox16.Text
                    da.SelectCommand.Parameters.Add("@expansion", SqlDbType.VarChar).Value = TextBox17.Text
                    da.SelectCommand.Parameters.Add("@proyeccion", SqlDbType.VarChar).Value = TextBox18.Text
                    da.SelectCommand.Parameters.Add("@semejanzacualitativos", SqlDbType.VarChar).Value = TextBox19.Text
                    If DropDownList1.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@localizacioncualitativos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@localizacioncualitativos", SqlDbType.VarChar).Value = DropDownList1.Text
                    End If
                    da.SelectCommand.Parameters.Add("@intensidadcuantitativos", SqlDbType.VarChar).Value = TextBox20.Text
                    da.SelectCommand.Parameters.Add("@maximaintensidadcuantitativos", SqlDbType.VarChar).Value = TextBox21.Text
                    da.SelectCommand.Parameters.Add("@intensidadultimoevento", SqlDbType.VarChar).Value = TextBox22.Text
                    da.SelectCommand.Parameters.Add("@iniciocronologicos", SqlDbType.VarChar).Value = TextBox23.Text
                    If DropDownList2.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patroncronologicos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patroncronologicos", SqlDbType.VarChar).Value = DropDownList2.Text
                    End If
                    da.SelectCommand.Parameters.Add("@duracion", SqlDbType.VarChar).Value = TextBox24.Text
                    da.SelectCommand.Parameters.Add("@frecuenciadia", SqlDbType.VarChar).Value = TextBox25.Text
                    da.SelectCommand.Parameters.Add("@frecuenciamensual", SqlDbType.VarChar).Value = TextBox26.Text
                    da.SelectCommand.Parameters.Add("@ultimoevento", SqlDbType.VarChar).Value = TextBox27.Text
                    If DropDownList3.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patrondia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patrondia", SqlDbType.VarChar).Value = DropDownList3.Text
                    End If
                    If DropDownList4.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronayuno", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronayuno", SqlDbType.VarChar).Value = DropDownList4.Text
                    End If
                    If DropDownList5.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronevacuaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronevacuaciones", SqlDbType.VarChar).Value = DropDownList5.Text
                    End If
                    da.SelectCommand.Parameters.Add("@patronevacuaciones2", SqlDbType.VarChar).Value = TextBox28.Text
                    da.SelectCommand.Parameters.Add("@patrongases", SqlDbType.VarChar).Value = TextBox29.Text
                    da.SelectCommand.Parameters.Add("@patronvomito", SqlDbType.VarChar).Value = TextBox30.Text
                    da.SelectCommand.Parameters.Add("@aumentaintesidad", SqlDbType.VarChar).Value = TextBox33.Text
                    da.SelectCommand.Parameters.Add("@disminuyeintensidad", SqlDbType.VarChar).Value = TextBox33.Text
                    da.SelectCommand.Parameters.Add("@alimdisminuyen", SqlDbType.VarChar).Value = TextBox35.Text
                    If DropDownList7.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@evacuaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@evacuaciones", SqlDbType.VarChar).Value = DropDownList7.Text
                    End If
                    If DropDownList8.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@canalizacionesgases", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@canalizacionesgases", SqlDbType.VarChar).Value = DropDownList8.Text
                    End If
                    If DropDownList9.Text = "-Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@eructos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@eructos", SqlDbType.VarChar).Value = DropDownList9.Text
                    End If
                    da.SelectCommand.Parameters.Add("@medicamcalman", SqlDbType.VarChar).Value = TextBox32.Text
                    da.SelectCommand.Parameters.Add("@medicamnocontrolan", SqlDbType.VarChar).Value = TextBox31.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional1", SqlDbType.VarChar).Value = TextBox36.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional2", SqlDbType.VarChar).Value = TextBox37.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional3", SqlDbType.VarChar).Value = TextBox38.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional4", SqlDbType.VarChar).Value = TextBox39.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre1", SqlDbType.VarChar).Value = TextBox40.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre2", SqlDbType.VarChar).Value = TextBox41.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre3", SqlDbType.VarChar).Value = TextBox42.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre4", SqlDbType.VarChar).Value = TextBox43.Text
                    da.SelectCommand.Parameters.Add("@sintomanodolor", SqlDbType.VarChar).Value = TextBox44.Text
                    da.SelectCommand.Parameters.Add("@inicionodolor", SqlDbType.VarChar).Value = TextBox2.Text
                    If DropDownList6.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronnodolor", SqlDbType.VarChar).Value = DropDownList6.Text
                    End If
                    da.SelectCommand.Parameters.Add("@duracionnodolor", SqlDbType.VarChar).Value = TextBox3.Text
                    da.SelectCommand.Parameters.Add("@frecuenciadianodolor", SqlDbType.VarChar).Value = TextBox4.Text
                    da.SelectCommand.Parameters.Add("@frecuenciamesnodolor", SqlDbType.VarChar).Value = TextBox5.Text
                    da.SelectCommand.Parameters.Add("@ulteventonodolor", SqlDbType.VarChar).Value = TextBox6.Text
                    If DropDownList10.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patrondianodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patrondianodolor", SqlDbType.VarChar).Value = DropDownList10.Text
                    End If
                    If DropDownList11.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronayunonodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronayunonodolor", SqlDbType.VarChar).Value = DropDownList11.Text
                    End If
                    If DropDownList12.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronevacnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronevacnodolor", SqlDbType.VarChar).Value = DropDownList12.Text
                    End If
                    da.SelectCommand.Parameters.Add("@patrongasesnodolor", SqlDbType.VarChar).Value = TextBox46.Text
                    da.SelectCommand.Parameters.Add("@patronvomitonodolor", SqlDbType.VarChar).Value = TextBox45.Text
                    da.SelectCommand.Parameters.Add("@aumentaintensnodolor", SqlDbType.VarChar).Value = TextBox47.Text
                    da.SelectCommand.Parameters.Add("@disminuyeintensnodolor", SqlDbType.VarChar).Value = TextBox48.Text
                    da.SelectCommand.Parameters.Add("@alimprovocannodolor", SqlDbType.VarChar).Value = TextBox49.Text
                    da.SelectCommand.Parameters.Add("@alimdisminuyennodolor", SqlDbType.VarChar).Value = TextBox50.Text
                    If DropDownList13.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@evacnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@evacnodolor", SqlDbType.VarChar).Value = DropDownList13.Text
                    End If
                    If DropDownList14.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@canalizgasesnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@canalizgasesnodolor", SqlDbType.VarChar).Value = DropDownList14.Text
                    End If
                    If DropDownList15.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@eructosnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@eructosnodolor", SqlDbType.VarChar).Value = DropDownList15.Text
                    End If
                    da.SelectCommand.Parameters.Add("@medicamcalmannodolor", SqlDbType.VarChar).Value = TextBox51.Text
                    da.SelectCommand.Parameters.Add("@mednocontrolannodolor", SqlDbType.VarChar).Value = TextBox52.Text
                    da.SelectCommand.Parameters.Add("@peso", SqlDbType.VarChar).Value = TextBox53.Text
                    da.SelectCommand.Parameters.Add("@talla", SqlDbType.VarChar).Value = TextBox54.Text
                    da.SelectCommand.Parameters.Add("@temp", SqlDbType.VarChar).Value = TextBox55.Text
                    da.SelectCommand.Parameters.Add("@ta", SqlDbType.VarChar).Value = TextBox56.Text
                    da.SelectCommand.Parameters.Add("@tc", SqlDbType.VarChar).Value = TextBox57.Text
                    da.SelectCommand.Parameters.Add("@fr", SqlDbType.VarChar).Value = TextBox58.Text
                    da.SelectCommand.Parameters.Add("@cabeza", SqlDbType.VarChar).Value = TextBox59.Text
                    da.SelectCommand.Parameters.Add("@torax", SqlDbType.VarChar).Value = TextBox60.Text
                    da.SelectCommand.Parameters.Add("@abdomen", SqlDbType.VarChar).Value = TextBox61.Text
                    da.SelectCommand.Parameters.Add("@extremidades", SqlDbType.VarChar).Value = TextBox62.Text
                    da.SelectCommand.Parameters.Add("@estudios", SqlDbType.VarChar).Value = TextBox63.Text
                    da.SelectCommand.Parameters.Add("@regionanalisis", SqlDbType.VarChar).Value = DropDownList60.Text
                    For Each li As ListItem In CheckBoxList12.Items
                        If li.Selected Then
                            If sintanalisis12.Length = 0 Then
                                sintanalisis12 = li.Value
                            Else
                                sintanalisis12 += ", " + li.Value
                            End If
                        End If
                    Next
                    If TextBox113.Text <> "" Then
                        sintanalisis12 += ", " + TextBox113.Text
                    End If
                    da.SelectCommand.Parameters.Add("@sintomaanalisis", SqlDbType.VarChar).Value = sintanalisis12
                    If TextBox98.Visible = True Then
                        da.SelectCommand.Parameters.Add("@sindromeclin", SqlDbType.VarChar).Value = TextBox98.Text
                    Else
                        da.SelectCommand.Parameters.Add("@sindromeclin", SqlDbType.VarChar).Value = DropDownList62.Text
                    End If
                    If TextBox99.Visible = True Then
                        da.SelectCommand.Parameters.Add("@subtipoanalisis", SqlDbType.VarChar).Value = TextBox99.Text
                    Else
                        da.SelectCommand.Parameters.Add("@subtipoanalisis", SqlDbType.VarChar).Value = DropDownList63.Text
                    End If
                    da.SelectCommand.Parameters.Add("@analisis", SqlDbType.VarChar).Value = TextBox100.Text
                    da.SelectCommand.Parameters.Add("@diagnostico", SqlDbType.VarChar).Value = TextBox7.Text
                    da.SelectCommand.Parameters.Add("@indicgrales", SqlDbType.VarChar).Value = TextBox114.Text
                    da.SelectCommand.Parameters.Add("@estudiosgrales", SqlDbType.VarChar).Value = TextBox79.Text
                    da.SelectCommand.Parameters.Add("@tratamiento", SqlDbType.VarChar).Value = TextBox82.Text
                    da.SelectCommand.Parameters.Add("@medico", SqlDbType.VarChar).Value = Label8.Text


                    da.SelectCommand.ExecuteNonQuery()
                    con.Close()


                Catch ex As Exception

                End Try
            End If

            If DropDownList16.Text = "--Seleccionar--" And DropDownList20.Text = "--Seleccionar--" And DropDownList24.Text = "--Seleccionar--" And DropDownList28.Text = "--Seleccionar--" And DropDownList32.Text = "--Seleccionar--" And DropDownList36.Text = "--Seleccionar--" And DropDownList40.Text = "--Seleccionar--" And DropDownList44.Text = "--Seleccionar--" And DropDownList48.Text = "--Seleccionar--" And DropDownList52.Text = "--Seleccionar--" And DropDownList56.Text = "--Seleccionar--" And DropDownList60.Text = "--Seleccionar--" Then
                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    da = New SqlDataAdapter("modificagastro", con)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.SelectCommand.Parameters.Add("@folionota", SqlDbType.Int).Value = Session("numnota2")
                    da.SelectCommand.Parameters.Add("@pacienteid", SqlDbType.Int).Value = Session("Paciente")
                    da.SelectCommand.Parameters.Add("@fechamodif", SqlDbType.DateTime).Value = Label2.Text
                    da.SelectCommand.Parameters.Add("@genero", SqlDbType.VarChar).Value = DropDownList200.Text
                    da.SelectCommand.Parameters.Add("@diarrea", SqlDbType.VarChar).Value = DropDownList17.Text
                    da.SelectCommand.Parameters.Add("@hernias", SqlDbType.VarChar).Value = DropDownList21.Text
                    da.SelectCommand.Parameters.Add("@cancer", SqlDbType.VarChar).Value = DropDownList25.Text
                    da.SelectCommand.Parameters.Add("@estrenimiento", SqlDbType.VarChar).Value = DropDownList29.Text
                    da.SelectCommand.Parameters.Add("@cancerdigestivo", SqlDbType.VarChar).Value = DropDownList33.Text
                    da.SelectCommand.Parameters.Add("@colecistitis", SqlDbType.VarChar).Value = DropDownList37.Text
                    da.SelectCommand.Parameters.Add("@hipertension", SqlDbType.VarChar).Value = DropDownList41.Text
                    da.SelectCommand.Parameters.Add("@cardiopatia", SqlDbType.VarChar).Value = DropDownList45.Text
                    da.SelectCommand.Parameters.Add("@autoinmunes", SqlDbType.VarChar).Value = DropDownList49.Text
                    da.SelectCommand.Parameters.Add("@diabetes", SqlDbType.VarChar).Value = DropDownList53.Text
                    da.SelectCommand.Parameters.Add("@endocrinopatias", SqlDbType.VarChar).Value = DropDownList57.Text
                    da.SelectCommand.Parameters.Add("@otrosenf", SqlDbType.VarChar).Value = TextBox85.Text
                    da.SelectCommand.Parameters.Add("@otrosfam", SqlDbType.VarChar).Value = DropDownList168.Text
                    da.SelectCommand.Parameters.Add("@ocupacion", SqlDbType.VarChar).Value = TextBox91.Text
                    da.SelectCommand.Parameters.Add("@escolaridad", SqlDbType.VarChar).Value = DropDownList61.Text
                    da.SelectCommand.Parameters.Add("@actfis", SqlDbType.VarChar).Value = DropDownList64.Text
                    If DropDownList65.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@alergicos", SqlDbType.VarChar).Value = DropDownList65.Text
                    Else
                        da.SelectCommand.Parameters.Add("@alergicos", SqlDbType.VarChar).Value = TextBox94.Text
                    End If

                    da.SelectCommand.Parameters.Add("@cirugias", SqlDbType.VarChar).Value = TextBox97.Text
                    da.SelectCommand.Parameters.Add("@complicacionescirugias", SqlDbType.VarChar).Value = TextBox115.Text
                    If DropDownList66.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@transfusiones", SqlDbType.VarChar).Value = DropDownList66.Text
                    Else
                        da.SelectCommand.Parameters.Add("@transfusiones", SqlDbType.VarChar).Value = TextBox116.Text
                    End If
                    da.SelectCommand.Parameters.Add("@tiposangre", SqlDbType.VarChar).Value = DropDownList67.Text
                    If DropDownList68.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@fracturas", SqlDbType.VarChar).Value = DropDownList68.Text
                    Else
                        da.SelectCommand.Parameters.Add("@fracturas", SqlDbType.VarChar).Value = TextBox117.Text
                    End If
                    If DropDownList69.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@hospprevias", SqlDbType.VarChar).Value = DropDownList69.Text
                    Else
                        da.SelectCommand.Parameters.Add("@hospprevias", SqlDbType.VarChar).Value = TextBox118.Text
                    End If
                    If DropDownList169.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempohipertension", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientohipertension", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempohipertension", SqlDbType.VarChar).Value = TextBox148.Text
                        da.SelectCommand.Parameters.Add("@tratamientohipertension", SqlDbType.VarChar).Value = TextBox149.Text
                    End If
                    If DropDownList170.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoinsuficiencia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoinsuficiencia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoinsuficiencia", SqlDbType.VarChar).Value = TextBox150.Text
                        da.SelectCommand.Parameters.Add("@tratamientoinsuficiencia", SqlDbType.VarChar).Value = TextBox151.Text
                    End If
                    If DropDownList171.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempocardisq", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientocardisq", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempocardisq", SqlDbType.VarChar).Value = TextBox152.Text
                        da.SelectCommand.Parameters.Add("@tratamientocardisq", SqlDbType.VarChar).Value = TextBox153.Text
                    End If
                    If DropDownList172.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoevc", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoevc", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoevc", SqlDbType.VarChar).Value = TextBox154.Text
                        da.SelectCommand.Parameters.Add("@tratamientoevc", SqlDbType.VarChar).Value = TextBox155.Text
                    End If
                    If DropDownList173.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoinsufvenosa", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoinsufvenosa", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoinsufvenosa", SqlDbType.VarChar).Value = TextBox156.Text
                        da.SelectCommand.Parameters.Add("@tratamientoinsufvenosa", SqlDbType.VarChar).Value = TextBox157.Text
                    End If
                    If DropDownList174.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodiabetes", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientodiabetes", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodiabetes", SqlDbType.VarChar).Value = TextBox158.Text
                        da.SelectCommand.Parameters.Add("@tratamientodiabetes", SqlDbType.VarChar).Value = TextBox159.Text
                    End If
                    If DropDownList175.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodislipidemmia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientodislipidemmia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodislipidemmia", SqlDbType.VarChar).Value = TextBox160.Text
                        da.SelectCommand.Parameters.Add("@tratamientodislipidemmia", SqlDbType.VarChar).Value = TextBox161.Text
                    End If
                    If DropDownList176.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoobesidad", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoobesidad", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoobesidad", SqlDbType.VarChar).Value = TextBox162.Text
                        da.SelectCommand.Parameters.Add("@tratamientoobesidad", SqlDbType.VarChar).Value = TextBox163.Text
                    End If
                    If DropDownList177.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoenftiroidea", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoenftiroidea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoenftiroidea", SqlDbType.VarChar).Value = TextBox164.Text
                        da.SelectCommand.Parameters.Add("@tratamientoenftiroidea", SqlDbType.VarChar).Value = TextBox165.Text
                    End If
                    If DropDownList178.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempocancer", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientocancer", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempocancer", SqlDbType.VarChar).Value = TextBox166.Text
                        da.SelectCommand.Parameters.Add("@tratamientocancer", SqlDbType.VarChar).Value = TextBox167.Text
                    End If
                    If DropDownList179.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempotuberculosis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientotuberculosis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempotuberculosis", SqlDbType.VarChar).Value = TextBox168.Text
                        da.SelectCommand.Parameters.Add("@tratamientotuberculosis", SqlDbType.VarChar).Value = TextBox169.Text
                    End If
                    If DropDownList180.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoasma", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoasma", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoasma", SqlDbType.VarChar).Value = TextBox170.Text
                        da.SelectCommand.Parameters.Add("@tratamientoasma", SqlDbType.VarChar).Value = TextBox171.Text
                    End If
                    If DropDownList181.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoepoc", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientoepoc", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoepoc", SqlDbType.VarChar).Value = TextBox172.Text
                        da.SelectCommand.Parameters.Add("@tratamientoepoc", SqlDbType.VarChar).Value = TextBox173.Text
                    End If
                    If DropDownList182.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempobronquitis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientobronquitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempobronquitis", SqlDbType.VarChar).Value = TextBox174.Text
                        da.SelectCommand.Parameters.Add("@tratamientobronquitis", SqlDbType.VarChar).Value = TextBox175.Text
                    End If
                    If TextBox176.Text = "" Then
                        da.SelectCommand.Parameters.Add("@otraenf", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tiempootraenf", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tratamientootraenf", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@otraenf", SqlDbType.VarChar).Value = TextBox176.Text
                        da.SelectCommand.Parameters.Add("@tiempootraenf", SqlDbType.VarChar).Value = TextBox177.Text
                        da.SelectCommand.Parameters.Add("@tratamientootraenf", SqlDbType.VarChar).Value = TextBox178.Text
                    End If
                    If DropDownList84.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoalcoholismo", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantalcoholismo", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoalcoholismo", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@cantalcoholismo", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If DropDownList85.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempotabaquismo", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@canttabaquismo", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempotabaquismo", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@canttabaquismo", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If DropDownList86.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempodrogas", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantdrogas", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempodrogas", SqlDbType.VarChar).Value = TextBox179.Text
                        da.SelectCommand.Parameters.Add("@cantdrogas", SqlDbType.VarChar).Value = TextBox180.Text
                    End If
                    If TextBox185.Text = "" Then
                        da.SelectCommand.Parameters.Add("@otrotox", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@tiempootrotox", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cantotrotox", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@otrotox", SqlDbType.VarChar).Value = TextBox185.Text
                        da.SelectCommand.Parameters.Add("@tiempootrotox", SqlDbType.VarChar).Value = TextBox186.Text
                        da.SelectCommand.Parameters.Add("@cantotrotox", SqlDbType.VarChar).Value = TextBox187.Text
                    End If
                        da.SelectCommand.Parameters.Add("@ultregla", SqlDbType.Date).Value = DBNull.Value
                   
                    da.SelectCommand.Parameters.Add("@ritmo", SqlDbType.VarChar).Value = TextBox124.Text
                    da.SelectCommand.Parameters.Add("@menopausia", SqlDbType.VarChar).Value = DropDownList87.Text
                    da.SelectCommand.Parameters.Add("@gesta", SqlDbType.Int).Value = DropDownList88.Text
                    da.SelectCommand.Parameters.Add("@para", SqlDbType.Int).Value = DropDownList89.Text
                    da.SelectCommand.Parameters.Add("@cesarea", SqlDbType.Int).Value = DropDownList90.Text
                    da.SelectCommand.Parameters.Add("@aborto", SqlDbType.Int).Value = DropDownList91.Text
                    da.SelectCommand.Parameters.Add("@metplanfam", SqlDbType.VarChar).Value = DropDownList92.Text
                    da.SelectCommand.Parameters.Add("@otroplanfam", SqlDbType.VarChar).Value = TextBox125.Text
                    If DropDownList93.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempofiebre", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionfiebre", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempofiebre", SqlDbType.VarChar).Value = TextBox188.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionfiebre", SqlDbType.VarChar).Value = TextBox189.Text
                    End If
                    If DropDownList94.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoastenia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionastenia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoastenia", SqlDbType.VarChar).Value = TextBox191.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionastenia", SqlDbType.VarChar).Value = TextBox192.Text
                    End If
                    If DropDownList95.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoadinamia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionadinamia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoadinamia", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionadinamia", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList96.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoanorexia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionanorexia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoanorexia", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionanorexia", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList97.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tiempoperdidapeso", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@cuantificacionperdidapeso", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tiempoperdidapeso", SqlDbType.VarChar).Value = TextBox194.Text
                        da.SelectCommand.Parameters.Add("@cuantificacionperdidapeso", SqlDbType.VarChar).Value = TextBox195.Text
                    End If
                    If DropDownList98.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@obstruccionnasal", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@obstruccionnasal", SqlDbType.VarChar).Value = DropDownList183.Text
                    End If
                    If DropDownList99.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@ronqueramatutina", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@ronqueramatutina", SqlDbType.VarChar).Value = DropDownList184.Text
                    End If
                    If DropDownList100.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@sinusitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@sinusitis", SqlDbType.VarChar).Value = DropDownList185.Text
                    End If
                    If DropDownList101.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@disfonia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@disfonia", SqlDbType.VarChar).Value = DropDownList186.Text
                    End If
                    If DropDownList102.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@disnea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@disnea", SqlDbType.VarChar).Value = DropDownList187.Text
                    End If
                    If DropDownList103.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@sibilancias", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@sibilancias", SqlDbType.VarChar).Value = DropDownList188.Text
                    End If
                    If DropDownList104.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@tos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@tos", SqlDbType.VarChar).Value = DropDownList189.Text
                    End If
                    If DropDownList105.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@cianosis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@cianosis", SqlDbType.VarChar).Value = DropDownList190.Text
                    End If
                    If DropDownList106.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@asma", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@asma", SqlDbType.VarChar).Value = DropDownList191.Text
                    End If
                    If DropDownList107.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorolipotimia", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacioneslipotimia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorolipotimia", SqlDbType.VarChar).Value = DropDownList192.Text
                        da.SelectCommand.Parameters.Add("@sensacioneslipotimia", SqlDbType.VarChar).Value = TextBox203.Text
                    End If
                    If DropDownList108.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorosincope", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionessincope", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorosincope", SqlDbType.VarChar).Value = DropDownList193.Text
                        da.SelectCommand.Parameters.Add("@sensacionessincope", SqlDbType.VarChar).Value = TextBox204.Text
                    End If
                    If DropDownList109.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorofatiga", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesfatiga", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorofatiga", SqlDbType.VarChar).Value = DropDownList194.Text
                        da.SelectCommand.Parameters.Add("@sensacionesfatiga", SqlDbType.VarChar).Value = TextBox205.Text
                    End If
                    If DropDownList110.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoropalpitaciones", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionespalpitaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoropalpitaciones", SqlDbType.VarChar).Value = DropDownList195.Text
                        da.SelectCommand.Parameters.Add("@sensacionespalpitaciones", SqlDbType.VarChar).Value = TextBox206.Text
                    End If
                    If DropDownList111.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorodolprecordial", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesdolprecordial", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorodolprecordial", SqlDbType.VarChar).Value = DropDownList196.Text
                        da.SelectCommand.Parameters.Add("@sensacionesdolprecordial", SqlDbType.VarChar).Value = TextBox207.Text
                    End If
                    If DropDownList112.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoroedema", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesedema", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoroedema", SqlDbType.VarChar).Value = DropDownList197.Text
                        da.SelectCommand.Parameters.Add("@sensacionesedema", SqlDbType.VarChar).Value = TextBox208.Text
                    End If
                    If DropDownList113.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejorodisnea", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesdisnea", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejorodisnea", SqlDbType.VarChar).Value = DropDownList198.Text
                        da.SelectCommand.Parameters.Add("@sensacionesdisnea", SqlDbType.VarChar).Value = TextBox209.Text
                    End If
                    If DropDownList114.Text = "No" Then
                        da.SelectCommand.Parameters.Add("@mejoroascitis", SqlDbType.VarChar).Value = ""
                        da.SelectCommand.Parameters.Add("@sensacionesascitis", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@mejoroascitis", SqlDbType.VarChar).Value = DropDownList199.Text
                        da.SelectCommand.Parameters.Add("@sensacionesascitis", SqlDbType.VarChar).Value = TextBox210.Text
                    End If
                    da.SelectCommand.Parameters.Add("@disuria", SqlDbType.VarChar).Value = DropDownList138.Text
                    da.SelectCommand.Parameters.Add("@poliaquiuria", SqlDbType.VarChar).Value = DropDownList139.Text
                    da.SelectCommand.Parameters.Add("@tenesmo", SqlDbType.VarChar).Value = DropDownList140.Text
                    da.SelectCommand.Parameters.Add("@hematuria", SqlDbType.VarChar).Value = DropDownList141.Text
                    da.SelectCommand.Parameters.Add("@suprapubica", SqlDbType.VarChar).Value = DropDownList142.Text
                    da.SelectCommand.Parameters.Add("@lumbar", SqlDbType.VarChar).Value = DropDownList143.Text
                    da.SelectCommand.Parameters.Add("@ninguno", SqlDbType.VarChar).Value = DropDownList144.Text
                    da.SelectCommand.Parameters.Add("@otrosdolores", SqlDbType.VarChar).Value = TextBox131.Text
                    da.SelectCommand.Parameters.Add("@tendenciahemorragia", SqlDbType.VarChar).Value = DropDownList145.Text
                    da.SelectCommand.Parameters.Add("@adenopatias", SqlDbType.VarChar).Value = DropDownList146.Text
                    da.SelectCommand.Parameters.Add("@infecrecurrentes", SqlDbType.VarChar).Value = DropDownList147.Text
                    da.SelectCommand.Parameters.Add("@anemia", SqlDbType.VarChar).Value = DropDownList148.Text
                    da.SelectCommand.Parameters.Add("@hemolinfaticonegado", SqlDbType.VarChar).Value = DropDownList149.Text
                    da.SelectCommand.Parameters.Add("@otroshemolinf", SqlDbType.VarChar).Value = TextBox132.Text
                    da.SelectCommand.Parameters.Add("@paralisis", SqlDbType.VarChar).Value = DropDownList150.Text
                    da.SelectCommand.Parameters.Add("@parestesisas", SqlDbType.VarChar).Value = DropDownList151.Text
                    da.SelectCommand.Parameters.Add("@temblores", SqlDbType.VarChar).Value = DropDownList152.Text
                    da.SelectCommand.Parameters.Add("@alteracionesmarcha", SqlDbType.VarChar).Value = DropDownList153.Text
                    da.SelectCommand.Parameters.Add("@cefalea", SqlDbType.VarChar).Value = DropDownList154.Text
                    da.SelectCommand.Parameters.Add("@sisnerviosonegado", SqlDbType.VarChar).Value = DropDownList155.Text
                    da.SelectCommand.Parameters.Add("@otrossisnerv", SqlDbType.VarChar).Value = TextBox133.Text
                    da.SelectCommand.Parameters.Add("@padactual", SqlDbType.VarChar).Value = TextBox1.Text
                    da.SelectCommand.Parameters.Add("@motivoconsulta", SqlDbType.VarChar).Value = TextBox12.Text
                    da.SelectCommand.Parameters.Add("@region", SqlDbType.VarChar).Value = TextBox13.Text
                    da.SelectCommand.Parameters.Add("@inicia", SqlDbType.VarChar).Value = TextBox14.Text
                    da.SelectCommand.Parameters.Add("@irradiacion", SqlDbType.VarChar).Value = TextBox15.Text
                    da.SelectCommand.Parameters.Add("@migracion", SqlDbType.VarChar).Value = TextBox16.Text
                    da.SelectCommand.Parameters.Add("@expansion", SqlDbType.VarChar).Value = TextBox17.Text
                    da.SelectCommand.Parameters.Add("@proyeccion", SqlDbType.VarChar).Value = TextBox18.Text
                    da.SelectCommand.Parameters.Add("@semejanzacualitativos", SqlDbType.VarChar).Value = TextBox19.Text
                    If DropDownList1.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@localizacioncualitativos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@localizacioncualitativos", SqlDbType.VarChar).Value = DropDownList1.Text
                    End If
                    da.SelectCommand.Parameters.Add("@intensidadcuantitativos", SqlDbType.VarChar).Value = TextBox20.Text
                    da.SelectCommand.Parameters.Add("@maximaintensidadcuantitativos", SqlDbType.VarChar).Value = TextBox21.Text
                    da.SelectCommand.Parameters.Add("@intensidadultimoevento", SqlDbType.VarChar).Value = TextBox22.Text
                    da.SelectCommand.Parameters.Add("@iniciocronologicos", SqlDbType.VarChar).Value = TextBox23.Text
                    If DropDownList2.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patroncronologicos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patroncronologicos", SqlDbType.VarChar).Value = DropDownList2.Text
                    End If
                    da.SelectCommand.Parameters.Add("@duracion", SqlDbType.VarChar).Value = TextBox24.Text
                    da.SelectCommand.Parameters.Add("@frecuenciadia", SqlDbType.VarChar).Value = TextBox25.Text
                    da.SelectCommand.Parameters.Add("@frecuenciamensual", SqlDbType.VarChar).Value = TextBox26.Text
                    da.SelectCommand.Parameters.Add("@ultimoevento", SqlDbType.VarChar).Value = TextBox27.Text
                    If DropDownList3.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patrondia", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patrondia", SqlDbType.VarChar).Value = DropDownList3.Text
                    End If
                    If DropDownList4.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronayuno", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronayuno", SqlDbType.VarChar).Value = DropDownList4.Text
                    End If

                    If DropDownList5.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronevacuaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronevacuaciones", SqlDbType.VarChar).Value = DropDownList5.Text
                    End If
                    da.SelectCommand.Parameters.Add("@patronevacuaciones2", SqlDbType.VarChar).Value = TextBox28.Text
                    da.SelectCommand.Parameters.Add("@patrongases", SqlDbType.VarChar).Value = TextBox29.Text
                    da.SelectCommand.Parameters.Add("@patronvomito", SqlDbType.VarChar).Value = TextBox30.Text
                    da.SelectCommand.Parameters.Add("@aumentaintesidad", SqlDbType.VarChar).Value = TextBox33.Text
                    da.SelectCommand.Parameters.Add("@disminuyeintensidad", SqlDbType.VarChar).Value = TextBox33.Text
                    da.SelectCommand.Parameters.Add("@alimdisminuyen", SqlDbType.VarChar).Value = TextBox35.Text
                    If DropDownList7.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@evacuaciones", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@evacuaciones", SqlDbType.VarChar).Value = DropDownList7.Text
                    End If
                    If DropDownList8.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@canalizacionesgases", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@canalizacionesgases", SqlDbType.VarChar).Value = DropDownList8.Text
                    End If
                    If DropDownList9.Text = "-Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@eructos", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@eructos", SqlDbType.VarChar).Value = DropDownList9.Text
                    End If
                    da.SelectCommand.Parameters.Add("@medicamcalman", SqlDbType.VarChar).Value = TextBox32.Text
                    da.SelectCommand.Parameters.Add("@medicamnocontrolan", SqlDbType.VarChar).Value = TextBox31.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional1", SqlDbType.VarChar).Value = TextBox36.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional2", SqlDbType.VarChar).Value = TextBox37.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional3", SqlDbType.VarChar).Value = TextBox38.Text
                    da.SelectCommand.Parameters.Add("@sintomaocasional4", SqlDbType.VarChar).Value = TextBox39.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre1", SqlDbType.VarChar).Value = TextBox40.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre2", SqlDbType.VarChar).Value = TextBox41.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre3", SqlDbType.VarChar).Value = TextBox42.Text
                    da.SelectCommand.Parameters.Add("@sintomasiempre4", SqlDbType.VarChar).Value = TextBox43.Text
                    da.SelectCommand.Parameters.Add("@sintomanodolor", SqlDbType.VarChar).Value = TextBox44.Text
                    da.SelectCommand.Parameters.Add("@inicionodolor", SqlDbType.VarChar).Value = TextBox2.Text
                    If DropDownList6.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronnodolor", SqlDbType.VarChar).Value = DropDownList6.Text
                    End If
                    da.SelectCommand.Parameters.Add("@duracionnodolor", SqlDbType.VarChar).Value = TextBox3.Text
                    da.SelectCommand.Parameters.Add("@frecuenciadianodolor", SqlDbType.VarChar).Value = TextBox4.Text
                    da.SelectCommand.Parameters.Add("@frecuenciamesnodolor", SqlDbType.VarChar).Value = TextBox5.Text
                    da.SelectCommand.Parameters.Add("@ulteventonodolor", SqlDbType.VarChar).Value = TextBox6.Text
                    If DropDownList10.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patrondianodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patrondianodolor", SqlDbType.VarChar).Value = DropDownList10.Text
                    End If
                    If DropDownList11.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronayunonodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronayunonodolor", SqlDbType.VarChar).Value = DropDownList11.Text
                    End If
                    If DropDownList12.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@patronevacnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@patronevacnodolor", SqlDbType.VarChar).Value = DropDownList12.Text
                    End If
                    da.SelectCommand.Parameters.Add("@patrongasesnodolor", SqlDbType.VarChar).Value = TextBox46.Text
                    da.SelectCommand.Parameters.Add("@patronvomitonodolor", SqlDbType.VarChar).Value = TextBox45.Text
                    da.SelectCommand.Parameters.Add("@aumentaintensnodolor", SqlDbType.VarChar).Value = TextBox47.Text
                    da.SelectCommand.Parameters.Add("@disminuyeintensnodolor", SqlDbType.VarChar).Value = TextBox48.Text
                    da.SelectCommand.Parameters.Add("@alimprovocannodolor", SqlDbType.VarChar).Value = TextBox49.Text
                    da.SelectCommand.Parameters.Add("@alimdisminuyennodolor", SqlDbType.VarChar).Value = TextBox50.Text
                    If DropDownList13.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@evacnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@evacnodolor", SqlDbType.VarChar).Value = DropDownList13.Text
                    End If
                    If DropDownList14.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@canalizgasesnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@canalizgasesnodolor", SqlDbType.VarChar).Value = DropDownList14.Text
                    End If
                    If DropDownList15.Text = "--Seleccionar--" Then
                        da.SelectCommand.Parameters.Add("@eructosnodolor", SqlDbType.VarChar).Value = ""
                    Else
                        da.SelectCommand.Parameters.Add("@eructosnodolor", SqlDbType.VarChar).Value = DropDownList15.Text
                    End If
                    da.SelectCommand.Parameters.Add("@medicamcalmannodolor", SqlDbType.VarChar).Value = TextBox51.Text
                    da.SelectCommand.Parameters.Add("@mednocontrolannodolor", SqlDbType.VarChar).Value = TextBox52.Text
                    da.SelectCommand.Parameters.Add("@peso", SqlDbType.VarChar).Value = TextBox53.Text
                    da.SelectCommand.Parameters.Add("@talla", SqlDbType.VarChar).Value = TextBox54.Text
                    da.SelectCommand.Parameters.Add("@temp", SqlDbType.VarChar).Value = TextBox55.Text
                    da.SelectCommand.Parameters.Add("@ta", SqlDbType.VarChar).Value = TextBox56.Text
                    da.SelectCommand.Parameters.Add("@tc", SqlDbType.VarChar).Value = TextBox57.Text
                    da.SelectCommand.Parameters.Add("@fr", SqlDbType.VarChar).Value = TextBox58.Text
                    da.SelectCommand.Parameters.Add("@cabeza", SqlDbType.VarChar).Value = TextBox59.Text
                    da.SelectCommand.Parameters.Add("@torax", SqlDbType.VarChar).Value = TextBox60.Text
                    da.SelectCommand.Parameters.Add("@abdomen", SqlDbType.VarChar).Value = TextBox61.Text
                    da.SelectCommand.Parameters.Add("@extremidades", SqlDbType.VarChar).Value = TextBox62.Text
                    da.SelectCommand.Parameters.Add("@estudios", SqlDbType.VarChar).Value = TextBox63.Text
                    da.SelectCommand.Parameters.Add("@regionanalisis", SqlDbType.VarChar).Value = DBNull.Value
                    da.SelectCommand.Parameters.Add("@sintomaanalisis", SqlDbType.VarChar).Value = DBNull.Value
                    da.SelectCommand.Parameters.Add("@sindromeclin", SqlDbType.VarChar).Value = DBNull.Value
                    da.SelectCommand.Parameters.Add("@subtipoanalisis", SqlDbType.VarChar).Value = DBNull.Value
                    da.SelectCommand.Parameters.Add("@analisis", SqlDbType.VarChar).Value = TextBox100.Text
                    da.SelectCommand.Parameters.Add("@diagnostico", SqlDbType.VarChar).Value = TextBox7.Text
                    da.SelectCommand.Parameters.Add("@indicgrales", SqlDbType.VarChar).Value = TextBox114.Text
                    da.SelectCommand.Parameters.Add("@estudiosgrales", SqlDbType.VarChar).Value = TextBox79.Text
                    da.SelectCommand.Parameters.Add("@tratamiento", SqlDbType.VarChar).Value = TextBox82.Text
                    da.SelectCommand.Parameters.Add("@medico", SqlDbType.VarChar).Value = Label8.Text


                    da.SelectCommand.ExecuteNonQuery()
                    con.Close()


                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Catch ex As Exception
        Finally
            Response.Redirect("~/FinNota.aspx", False)
        End Try

        
    End Sub

    Protected Sub DropDownList200_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList200.SelectedIndexChanged
        If DropDownList200.SelectedValue = "Hombre" Then
            ocultar2.Visible = False
        Else
            ocultar2.Visible = True
        End If
    End Sub
End Class