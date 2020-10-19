﻿Imports System.Data.SqlClient
Public Class ModifPsico
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label2.Text = DateTime.Now
        Dim da, da1, da2, da3, da4, da5, da6, da7, da8, da9, da10, da11, da12, da13, da14, da15, da16, da17, da18, da19, da20, da21, da22, da23, da24, da25, da26, da27, da28, da29, da30, da31, da32, da33, da34, da35, da36, da37, da38, da39, da40, da41, da42, da43, da44 As New SqlDataAdapter
        Dim dr, dr1, dr2, dr3, dr4, dr5, dr6, dr7, dr8, dr9, dr10, dr11, dr12, dr13, dr14, dr15, dr16, dr17, dr18, dr19, dr20, dr21, dr22, dr23, dr24, dr25, dr26, dr27, dr28, dr29, dr30, dr31, dr32, dr33, dr34, dr35, dr36, dr37, dr38, dr39, dr40, dr41, dr42, dr43, dr44 As SqlDataReader
        If Request.Params("id2") IsNot Nothing Then
            Session("numnota") = Request.Params("id2")
            Session("paciente") = Request.Params("pac")
        End If
        If Not IsPostBack Then
            If Session("nivel") = 0 Or Session("nivel") = 3 Then
                ocultar.Visible = False
            Else

                ocultar.Visible = True

                If (Session("paciente") IsNot Nothing) Then
                    Label7.Text = Session("paciente")
                    Label8.Text = Session("nomus")
                    Label9.Text = ConfigurationManager.AppSettings("cedula")

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da = New SqlDataAdapter("select nombres from paciente where pacienteid=@id", con)
                        da.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("paciente")
                        dr = da.SelectCommand.ExecuteReader
                        dr.Read()
                        TextBox8.Visible = False
                        Label3.Visible = True
                        Label3.Text = dr(0)
                        con.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    Finally

                    End Try
                End If
                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()

                    End If
                    con.Open()
                    da1 = New SqlDataAdapter("select appaterno from paciente where pacienteid=@id", con)
                    da1.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("paciente")
                    dr1 = da1.SelectCommand.ExecuteReader
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
                    da2 = New SqlDataAdapter("select apmaterno from paciente where pacienteid=@id", con)
                    da2.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("paciente")
                    dr2 = da2.SelectCommand.ExecuteReader
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
                    da3 = New SqlDataAdapter("select (cast(datediff(dd,nacimiento,GETDATE()) / 365.25 as int)) from paciente where pacienteid=@pac", con)
                    da3.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("paciente")
                    dr3 = da3.SelectCommand.ExecuteReader
                    dr3.Read()
                    TextBox11.Visible = False
                    Label6.Visible = True
                    Label6.Text = dr3(0)
                    con.Close()
                Catch ex As Exception

                    con.Close()
                End Try
            End If
            If Request.Params("id2") IsNot Nothing Then


                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    da4 = New SqlDataAdapter("select motivoconsultaanterior from psico where pacienteid=@paciente and folionota=@folio", con)
                    da4.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                    da4.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                    dr4 = da4.SelectCommand.ExecuteReader
                    dr4.Read()
                    If dr4.HasRows Then
                        DropDownList1.Visible = False
                        Label10.Text = dr4(0)
                        Label10.Visible = False
                        If Label10.Text = "" Then
                            DropDownList1.Text = "No"
                        Else
                            DropDownList1.Text = "Si"
                            TextBox1.Visible = True
                            TextBox1.Text = dr4(0)
                        End If
                    End If
                    con.Close()
                Catch ex As Exception

                End Try
            End If

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da5 = New SqlDataAdapter("select otrotipoterap from psico where pacienteid=@paciente and folionota=@folio", con)
                da5.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da5.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr5 = da5.SelectCommand.ExecuteReader
                dr5.Read()
                If dr5.HasRows Then
                    TextBox2.Visible = True
                    Label12.Visible = False
                    TextBox2.Text = dr5(0)
                End If
                con.Close()
            Catch ex As Exception

            End Try
            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da6 = New SqlDataAdapter("select relacfisemocion from psico where pacienteid=@paciente and folionota=@folio", con)
                da6.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da6.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr6 = da6.SelectCommand.ExecuteReader
                dr6.Read()
                If dr6.HasRows Then
                    DropDownList2.Visible = True
                    DropDownList2.Text = dr6(0)
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
                da7 = New SqlDataAdapter("select apegadoindic from psico where pacienteid=@paciente and folionota=@folio", con)
                da7.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da7.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr7 = da7.SelectCommand.ExecuteReader
                dr7.Read()
                If dr7.HasRows Then
                    DropDownList3.Visible = True
                    DropDownList3.Text = dr7(0)
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
                da8 = New SqlDataAdapter("select vidaafectadasintomas from psico where pacienteid=@paciente and folionota=@folio", con)
                da8.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da8.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr8 = da8.SelectCommand.ExecuteReader
                dr8.Read()
                If dr8.HasRows Then
                    DropDownList4.Visible = True
                    DropDownList4.Text = dr8(0)
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
                da10 = New SqlDataAdapter("select comoafecta from psico where pacienteid=@paciente and folionota=@folio", con)
                da10.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da10.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr10 = da10.SelectCommand.ExecuteReader
                dr10.Read()
                If dr10.HasRows Then
                    TextBox3.Visible = True
                    TextBox3.Text = dr10(0)
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
                da11 = New SqlDataAdapter("select pensamientos from psico where pacienteid=@paciente and folionota=@folio", con)
                da11.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da11.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr11 = da11.SelectCommand.ExecuteReader
                dr11.Read()
                If dr11.HasRows Then
                    CheckBox1.Enabled = True
                    CheckBox1.Checked = dr11(0)
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
                da12 = New SqlDataAdapter("select emociones from psico where pacienteid=@paciente and folionota=@folio", con)
                da12.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da12.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr12 = da12.SelectCommand.ExecuteReader
                dr12.Read()
                If dr12.HasRows Then
                    CheckBox2.Enabled = True
                    CheckBox2.Checked = dr12(0)
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
                da13 = New SqlDataAdapter("select conductas from psico where pacienteid=@paciente and folionota=@folio", con)
                da13.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da13.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr13 = da13.SelectCommand.ExecuteReader
                dr13.Read()
                If dr13.HasRows Then
                    CheckBox3.Enabled = True
                    CheckBox3.Checked = dr13(0)
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
                da14 = New SqlDataAdapter("select noreconoce from psico where pacienteid=@paciente and folionota=@folio", con)
                da14.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da14.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr14 = da14.SelectCommand.ExecuteReader
                dr14.Read()
                If dr14.HasRows Then
                    CheckBox4.Enabled = True
                    CheckBox4.Checked = dr14(0)
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
                da15 = New SqlDataAdapter("select alino from psico where pacienteid=@paciente and folionota=@folio", con)
                da15.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da15.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr15 = da15.SelectCommand.ExecuteReader
                dr15.Read()
                If dr15.HasRows Then
                    DropDownList6.Visible = True
                    DropDownList6.Text = dr15(0)
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
                da16 = New SqlDataAdapter("select espacio from psico where pacienteid=@paciente and folionota=@folio", con)
                da16.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da16.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr16 = da16.SelectCommand.ExecuteReader
                dr16.Read()
                If dr16.HasRows Then
                    CheckBox5.Enabled = True
                    CheckBox5.Checked = dr16(0)
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
                da17 = New SqlDataAdapter("select tiempo from psico where pacienteid=@paciente and folionota=@folio", con)
                da17.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da17.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr17 = da17.SelectCommand.ExecuteReader
                dr17.Read()
                If dr17.HasRows Then
                    CheckBox6.Enabled = True
                    CheckBox6.Checked = dr17(0)
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
                da18 = New SqlDataAdapter("select lugar from psico where pacienteid=@paciente and folionota=@folio", con)
                da18.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da18.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr18 = da18.SelectCommand.ExecuteReader
                dr18.Read()
                If dr18.HasRows Then
                    CheckBox7.Enabled = True
                    CheckBox7.Checked = dr18(0)
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
                da19 = New SqlDataAdapter("select persona from psico where pacienteid=@paciente and folionota=@folio", con)
                da19.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da19.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr19 = da19.SelectCommand.ExecuteReader
                dr19.Read()
                If dr19.HasRows Then
                    CheckBox8.Enabled = True
                    CheckBox8.Checked = dr19(0)
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
                da20 = New SqlDataAdapter("select atencion from psico where pacienteid=@paciente and folionota=@folio", con)
                da20.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da20.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr20 = da20.SelectCommand.ExecuteReader
                dr20.Read()
                If dr20.HasRows Then
                    DropDownList7.Visible = True
                    DropDownList7.Text = dr20(0)
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
                da20 = New SqlDataAdapter("select atencion from psico where pacienteid=@paciente and folionota=@folio", con)
                da20.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da20.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr20 = da20.SelectCommand.ExecuteReader
                dr20.Read()
                If dr20.HasRows Then
                    DropDownList7.Visible = True
                    DropDownList7.Text = dr20(0)
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
                da21 = New SqlDataAdapter("select calidadsueno from psico where pacienteid=@paciente and folionota=@folio", con)
                da21.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da21.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr21 = da21.SelectCommand.ExecuteReader
                dr21.Read()
                If dr21.HasRows Then
                    DropDownList8.Visible = True
                    DropDownList8.Text = dr21(0)
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
                da22 = New SqlDataAdapter("select higienesueno from psico where pacienteid=@paciente and folionota=@folio", con)
                da22.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da22.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr22 = da22.SelectCommand.ExecuteReader
                dr22.Read()
                If dr22.HasRows Then
                    DropDownList9.Visible = True
                    DropDownList9.Text = dr22(0)
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
                da23 = New SqlDataAdapter("select pensamiento from psico where pacienteid=@paciente and folionota=@folio", con)
                da23.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da23.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr23 = da23.SelectCommand.ExecuteReader
                dr23.Read()
                If dr23.HasRows Then
                    DropDownList10.Visible = True
                    DropDownList10.Text = dr23(0)
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
                da25 = New SqlDataAdapter("select locus from psico where pacienteid=@paciente and folionota=@folio", con)
                da25.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da25.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr25 = da25.SelectCommand.ExecuteReader
                dr25.Read()
                If dr25.HasRows Then
                    DropDownList12.Visible = True
                    DropDownList12.Text = dr25(0)
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
                da26 = New SqlDataAdapter("select apegotratam from psico where pacienteid=@paciente and folionota=@folio", con)
                da26.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da26.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr26 = da26.SelectCommand.ExecuteReader
                dr26.Read()
                If dr26.HasRows Then
                    DropDownList13.Visible = True
                    DropDownList13.Text = dr26(0)
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
                da27 = New SqlDataAdapter("select redapoyo from psico where pacienteid=@paciente and folionota=@folio", con)
                da27.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da27.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr27 = da27.SelectCommand.ExecuteReader
                dr27.Read()
                If dr27.HasRows Then
                    DropDownList14.Visible = True
                    DropDownList14.Text = dr27(0)
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
                da28 = New SqlDataAdapter("select impdiagnostica from psico where pacienteid=@paciente and folionota=@folio", con)
                da28.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da28.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr28 = da28.SelectCommand.ExecuteReader
                dr28.Read()
                If dr28.HasRows Then
                    TextBox4.Visible = True
                    TextBox4.Text = dr28(0)
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
                da29 = New SqlDataAdapter("select reqcontrol from psico where pacienteid=@paciente and folionota=@folio", con)
                da29.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da29.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr29 = da29.SelectCommand.ExecuteReader
                dr29.Read()
                If dr29.HasRows Then
                    DropDownList15.Visible = True
                    DropDownList15.Text = dr29(0)
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
                da30 = New SqlDataAdapter("select objterapeutico from psico where pacienteid=@paciente and folionota=@folio", con)
                da30.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da30.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr30 = da30.SelectCommand.ExecuteReader
                dr30.Read()
                If dr30.HasRows Then
                    TextBox5.Visible = True
                    TextBox5.Text = dr30(0)
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
                da31 = New SqlDataAdapter("select planterap from psico where pacienteid=@paciente and folionota=@folio", con)
                da31.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da31.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr31 = da31.SelectCommand.ExecuteReader
                dr31.Read()
                If dr31.HasRows Then
                    TextBox6.Visible = True
                    TextBox6.Text = dr31(0)
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
                da32 = New SqlDataAdapter("select seguimpsic from psico where pacienteid=@paciente and folionota=@folio", con)
                da32.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da32.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr32 = da32.SelectCommand.ExecuteReader
                dr32.Read()
                If dr32.HasRows Then
                    DropDownList16.Visible = True
                    DropDownList16.Text = dr32(0)
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
                da33 = New SqlDataAdapter("select observaciones from psico where pacienteid=@paciente and folionota=@folio", con)
                da33.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da33.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr33 = da33.SelectCommand.ExecuteReader
                dr33.Read()
                If dr33.HasRows Then
                    TextBox7.Visible = True
                    TextBox7.Text = dr33(0)
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
                da9 = New SqlDataAdapter("select laboral from psico where pacienteid=@paciente and folionota=@folio", con)
                da9.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da9.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr9 = da9.SelectCommand.ExecuteReader
                dr9.Read()
                If dr9.HasRows Then
                    CheckBox9.Enabled = True
                    CheckBox9.Checked = dr9(0)
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
                da24 = New SqlDataAdapter("select recreativa from psico where pacienteid=@paciente and folionota=@folio", con)
                da24.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da24.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr24 = da24.SelectCommand.ExecuteReader
                dr24.Read()
                If dr24.HasRows Then
                    CheckBox10.Enabled = True
                    CheckBox10.Checked = dr24(0)
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
                da34 = New SqlDataAdapter("select sexual from psico where pacienteid=@paciente and folionota=@folio", con)
                da34.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da34.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr34 = da34.SelectCommand.ExecuteReader
                dr34.Read()
                If dr34.HasRows Then
                    CheckBox11.Enabled = True
                    CheckBox11.Checked = dr34(0)
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
                da35 = New SqlDataAdapter("select familiar from psico where pacienteid=@paciente and folionota=@folio", con)
                da35.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da35.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr35 = da35.SelectCommand.ExecuteReader
                dr35.Read()
                If dr35.HasRows Then
                    CheckBox12.Enabled = True
                    CheckBox12.Checked = dr35(0)
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
                da36 = New SqlDataAdapter("select emocional from psico where pacienteid=@paciente and folionota=@folio", con)
                da36.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da36.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr36 = da36.SelectCommand.ExecuteReader
                dr36.Read()
                If dr36.HasRows Then
                    CheckBox13.Enabled = True
                    CheckBox13.Checked = dr36(0)
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
                da37 = New SqlDataAdapter("select pasivo from psico where pacienteid=@paciente and folionota=@folio", con)
                da37.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da37.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr37 = da37.SelectCommand.ExecuteReader
                dr37.Read()
                If dr37.HasRows Then
                    CheckBox14.Enabled = True
                    CheckBox14.Checked = dr37(0)
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
                da38 = New SqlDataAdapter("select activo from psico where pacienteid=@paciente and folionota=@folio", con)
                da38.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da38.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr38 = da38.SelectCommand.ExecuteReader
                dr38.Read()
                If dr38.HasRows Then
                    CheckBox15.Enabled = True
                    CheckBox15.Checked = dr38(0)
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
                da39 = New SqlDataAdapter("select evitativo from psico where pacienteid=@paciente and folionota=@folio", con)
                da39.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da39.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr39 = da39.SelectCommand.ExecuteReader
                dr39.Read()
                If dr39.HasRows Then
                    CheckBox16.Enabled = True
                    CheckBox16.Checked = dr39(0)
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
                da40 = New SqlDataAdapter("select centradoproblema from psico where pacienteid=@paciente and folionota=@folio", con)
                da40.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da40.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr40 = da40.SelectCommand.ExecuteReader
                dr40.Read()
                If dr40.HasRows Then
                    CheckBox17.Enabled = True
                    CheckBox17.Checked = dr40(0)
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
                da41 = New SqlDataAdapter("select centradoemociones from psico where pacienteid=@paciente and folionota=@folio", con)
                da41.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da41.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr41 = da41.SelectCommand.ExecuteReader
                dr41.Read()
                If dr41.HasRows Then
                    CheckBox18.Enabled = True
                    CheckBox18.Checked = dr41(0)
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
                da42 = New SqlDataAdapter("select irracional from psico where pacienteid=@paciente and folionota=@folio", con)
                da42.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da42.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr42 = da42.SelectCommand.ExecuteReader
                dr42.Read()
                If dr42.HasRows Then
                    CheckBox19.Enabled = True
                    CheckBox19.Checked = dr42(0)
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
                da43 = New SqlDataAdapter("select racional from psico where pacienteid=@paciente and folionota=@folio", con)
                da43.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da43.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr43 = da43.SelectCommand.ExecuteReader
                dr43.Read()
                If dr43.HasRows Then
                    CheckBox20.Enabled = True
                    CheckBox20.Checked = dr43(0)
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
                da44 = New SqlDataAdapter("select catastrofico from psico where pacienteid=@paciente and folionota=@folio", con)
                da44.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Session("paciente")
                da44.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                dr44 = da44.SelectCommand.ExecuteReader
                dr44.Read()
                If dr44.HasRows Then
                    CheckBox21.Enabled = True
                    CheckBox21.Checked = dr44(0)
                End If
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try
        End If
        If Label10.Visible = True Then
            Button1.Visible = False
            
        End If
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        If DropDownList1.Text = "Si" Then
            TextBox1.Visible = True
            Label1.Visible = True
        Else
            TextBox1.Visible = False
            Label1.Visible = False
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim da, da4 As New SqlDataAdapter
        'Dim dr4 As SqlDataReader
        
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da = New SqlDataAdapter("update psico set fechamodif = @fechamodif, motivoconsultaanterior = @motivoconsultaanterior, otrotipoterap = @otrotipoterap, relacfisemocion = @relacfisemocion, apegadoindic = @apegadoindic, vidaafectadasintomas = @vidaafectadasintomas, comoafecta = @comoafecta, pensamientos = @pensamientos, emociones = @emociones, conductas = @conductas, noreconoce = @noreconoce, alino = @alino, espacio = @espacio, tiempo = @tiempo, lugar = @lugar, persona = @persona, atencion = @atencion, calidadsueno = @calidadsueno, higienesueno = @higienesueno, pensamiento = @pensamiento, locus = @locus, apegotratam = @apegotratam, redapoyo = @redapoyo, impdiagnostica = @impdiagnostica, reqcontrol = @reqcontrol, objterapeutico = @objterapeutico, planterap = @planterap, seguimpsic = @seguimpsic, observaciones = @observaciones, medico = @medico, laboral = @laboral, recreativa = @recreativa, sexual = @sexual, familiar = @familiar, emocional = @emocional, pasivo = @pasivo, activo = @activo, evitativo = @evitativo, centradoproblema = @centradop, centradoemociones = @centradoe, irracional = @irracional, racional = @racional, catastrofico = @catastrofico where folionota=@folio and pacienteid=@pacienteid", con)
            da.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
            da.SelectCommand.Parameters.Add("@pacienteid", SqlDbType.Int).Value = Session("paciente")
            If DropDownList1.Text = "Si" Then
                da.SelectCommand.Parameters.Add("@motivoconsultaanterior", SqlDbType.VarChar).Value = TextBox1.Text
            Else
                da.SelectCommand.Parameters.Add("@motivoconsultaanterior", SqlDbType.VarChar).Value = ""
            End If
            da.SelectCommand.Parameters.Add("@fechamodif", SqlDbType.DateTime).Value = Label2.Text

            da.SelectCommand.Parameters.Add("@otrotipoterap", SqlDbType.VarChar).Value = TextBox2.Text
            If DropDownList2.Text = "--Seleccionar--" Then
                da.SelectCommand.Parameters.Add("@relacfisemocion", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@relacfisemocion", SqlDbType.VarChar).Value = DropDownList2.Text
            End If
            If DropDownList3.Text = "--Seleccionar--" Then
                da.SelectCommand.Parameters.Add("@apegadoindic", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@apegadoindic", SqlDbType.VarChar).Value = DropDownList3.Text
            End If
            If DropDownList4.Text = "--Seleccionar--" Then
                da.SelectCommand.Parameters.Add("@vidaafectadasintomas", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@vidaafectadasintomas", SqlDbType.VarChar).Value = DropDownList4.Text
            End If

            'da.SelectCommand.Parameters.Add("@areasafectadas", SqlDbType.VarChar).Value = DropDownList5.Text
            da.SelectCommand.Parameters.Add("@comoafecta", SqlDbType.VarChar).Value = TextBox3.Text
            If CheckBox1.Checked = True Then
                da.SelectCommand.Parameters.Add("@pensamientos", SqlDbType.Bit).Value = True
            Else
                da.SelectCommand.Parameters.Add("@pensamientos", SqlDbType.Bit).Value = False
            End If
            If CheckBox2.Checked = True Then
                da.SelectCommand.Parameters.Add("@emociones", SqlDbType.Bit).Value = True
            Else
                da.SelectCommand.Parameters.Add("@emociones", SqlDbType.Bit).Value = False
            End If
            If CheckBox3.Checked = True Then
                da.SelectCommand.Parameters.Add("@conductas", SqlDbType.Bit).Value = True
            Else
                da.SelectCommand.Parameters.Add("@conductas", SqlDbType.Bit).Value = False
            End If
            If CheckBox4.Checked = True Then
                da.SelectCommand.Parameters.Add("@noreconoce", SqlDbType.Bit).Value = True
            Else
                da.SelectCommand.Parameters.Add("@noreconoce", SqlDbType.Bit).Value = False
            End If
            If DropDownList6.Text = "--Seleccionar--" Then
                da.SelectCommand.Parameters.Add("@alino", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@alino", SqlDbType.VarChar).Value = DropDownList6.Text
            End If

            If CheckBox5.Checked = True Then
                da.SelectCommand.Parameters.Add("@espacio", SqlDbType.Bit).Value = True
            Else
                da.SelectCommand.Parameters.Add("@espacio", SqlDbType.Bit).Value = False
            End If
            If CheckBox6.Checked = True Then
                da.SelectCommand.Parameters.Add("@tiempo", SqlDbType.Bit).Value = True
            Else
                da.SelectCommand.Parameters.Add("@tiempo", SqlDbType.Bit).Value = False
            End If
            If CheckBox7.Checked = True Then
                da.SelectCommand.Parameters.Add("@lugar", SqlDbType.Bit).Value = True
            Else
                da.SelectCommand.Parameters.Add("@lugar", SqlDbType.Bit).Value = False
            End If
            If CheckBox8.Checked = True Then
                da.SelectCommand.Parameters.Add("@persona", SqlDbType.Bit).Value = True
            Else
                da.SelectCommand.Parameters.Add("@persona", SqlDbType.Bit).Value = False
            End If
            If DropDownList7.Text = "--Seleccionar--" Then
                da.SelectCommand.Parameters.Add("@atencion", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@atencion", SqlDbType.VarChar).Value = DropDownList7.Text
            End If

            If DropDownList9.Text = "--Seleccionar--" Then
                da.SelectCommand.Parameters.Add("@calidadsueno", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@calidadsueno", SqlDbType.VarChar).Value = DropDownList8.Text
            End If

            If DropDownList9.Text = "--Seleccionar--" Then
                da.SelectCommand.Parameters.Add("@higienesueno", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@higienesueno", SqlDbType.VarChar).Value = DropDownList9.Text
            End If

            If DropDownList10.Text = "--Seleccionar--" Then
                da.SelectCommand.Parameters.Add("@pensamiento", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@pensamiento", SqlDbType.VarChar).Value = DropDownList10.Text
            End If

            If DropDownList12.Text = "--Seleccionar--" Then
                da.SelectCommand.Parameters.Add("@locus", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@locus", SqlDbType.VarChar).Value = DropDownList12.Text
            End If

            If DropDownList13.Text = "--Seleccionar--" Then
                da.SelectCommand.Parameters.Add("@apegotratam", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@apegotratam", SqlDbType.VarChar).Value = DropDownList13.Text
            End If

            If DropDownList14.Text = "--Seleccionar--" Then
                da.SelectCommand.Parameters.Add("@redapoyo", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@redapoyo", SqlDbType.VarChar).Value = DropDownList14.Text
            End If

            da.SelectCommand.Parameters.Add("@impdiagnostica", SqlDbType.VarChar).Value = TextBox4.Text
            If DropDownList15.Text = "--Seleccionar--" Then
                da.SelectCommand.Parameters.Add("@reqcontrol", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@reqcontrol", SqlDbType.VarChar).Value = DropDownList15.Text
            End If

            da.SelectCommand.Parameters.Add("@objterapeutico", SqlDbType.VarChar).Value = TextBox5.Text
            da.SelectCommand.Parameters.Add("@planterap", SqlDbType.VarChar).Value = TextBox6.Text
            If DropDownList16.Text = "--Seleccionar--" Then
                da.SelectCommand.Parameters.Add("@seguimpsic", SqlDbType.VarChar).Value = ""
            Else
                da.SelectCommand.Parameters.Add("@seguimpsic", SqlDbType.VarChar).Value = DropDownList16.Text
            End If

            da.SelectCommand.Parameters.Add("@observaciones", SqlDbType.VarChar).Value = TextBox7.Text
            da.SelectCommand.Parameters.Add("@medico", SqlDbType.VarChar).Value = Label8.Text
            If CheckBox9.Checked = True Then
                da.SelectCommand.Parameters.Add("@laboral", SqlDbType.Bit).Value = True
            Else
                da.SelectCommand.Parameters.Add("@laboral", SqlDbType.Bit).Value = False
            End If
            If CheckBox10.Checked = True Then
                da.SelectCommand.Parameters.Add("@recreativa", SqlDbType.Bit).Value = True
            Else
                da.SelectCommand.Parameters.Add("@recreativa", SqlDbType.Bit).Value = False
            End If
            If CheckBox11.Checked = True Then
                da.SelectCommand.Parameters.Add("@sexual", SqlDbType.Bit).Value = True
            Else
                da.SelectCommand.Parameters.Add("@sexual", SqlDbType.Bit).Value = False
            End If
            If CheckBox12.Checked = True Then
                da.SelectCommand.Parameters.Add("@familiar", SqlDbType.Bit).Value = True
            Else
                da.SelectCommand.Parameters.Add("@familiar", SqlDbType.Bit).Value = False
            End If
            If CheckBox13.Checked = True Then
                da.SelectCommand.Parameters.Add("@emocional", SqlDbType.Bit).Value = True
            Else
                da.SelectCommand.Parameters.Add("@emocional", SqlDbType.Bit).Value = False
            End If
            If CheckBox14.Checked = True Then
                da.SelectCommand.Parameters.Add("@pasivo", SqlDbType.Bit).Value = True
            Else
                da.SelectCommand.Parameters.Add("@pasivo", SqlDbType.Bit).Value = False
            End If
            If CheckBox15.Checked = True Then
                da.SelectCommand.Parameters.Add("@activo", SqlDbType.Bit).Value = True
            Else
                da.SelectCommand.Parameters.Add("@activo", SqlDbType.Bit).Value = False
            End If
            If CheckBox16.Checked = True Then
                da.SelectCommand.Parameters.Add("@evitativo", SqlDbType.Bit).Value = True
            Else
                da.SelectCommand.Parameters.Add("@evitativo", SqlDbType.Bit).Value = False
            End If
            If CheckBox17.Checked = True Then
                da.SelectCommand.Parameters.Add("@centradop", SqlDbType.Bit).Value = True
            Else
                da.SelectCommand.Parameters.Add("@centradop", SqlDbType.Bit).Value = False
            End If
            If CheckBox18.Checked = True Then
                da.SelectCommand.Parameters.Add("@centradoe", SqlDbType.Bit).Value = True
            Else
                da.SelectCommand.Parameters.Add("@centradoe", SqlDbType.Bit).Value = False
            End If
            If CheckBox19.Checked = True Then
                da.SelectCommand.Parameters.Add("@irracional", SqlDbType.Bit).Value = True
            Else
                da.SelectCommand.Parameters.Add("@irracional", SqlDbType.Bit).Value = False
            End If
            If CheckBox20.Checked = True Then
                da.SelectCommand.Parameters.Add("@racional", SqlDbType.Bit).Value = True
            Else
                da.SelectCommand.Parameters.Add("@racional", SqlDbType.Bit).Value = False
            End If
            If CheckBox21.Checked = True Then
                da.SelectCommand.Parameters.Add("@catastrofico", SqlDbType.Bit).Value = True
            Else
                da.SelectCommand.Parameters.Add("@catastrofico", SqlDbType.Bit).Value = False
            End If

            da.SelectCommand.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Response.Redirect("~/FinNota.aspx", False)
        End Try
    End Sub
End Class