Imports System.Data.SqlClient
Imports System
Imports System.Configuration
Imports System.Data
Imports System.Linq
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.HtmlControls
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Xml.Linq

' include iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.html.simpleparser
Imports iTextSharp.text.pdf
Imports System.Text
Imports System.IO
Public Class WebForm1
    Inherits System.Web.UI.Page
    Private datapdf As New DataTable()
    Public Overrides Sub VerifyRenderingInServerForm(ByVal control As System.Web.UI.Control)
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = DateTime.Now
        Dim da, da1, da2, da3, da4, da5, da6, da7, da8, da9, da10, da11, da12, da13, da14, da15, da16, da17, da18, da19, da20, da21, da22, da23, da24, da25, da26, da27, da28, da29, da30, da31, da32, da33, da34, da35, da36, da37, da38, da39, da40, da41, da42, da43, da44, da45, da46, da47 As New SqlDataAdapter
        Dim dr, dr1, dr2, dr3, dr4, dr5, dr6, dr7, dr8, dr9, dr11, dr12, dr13, dr14, dr15, dr16, dr17, dr18, dr19, dr20, dr22, dr23, dr24, dr25, dr26, dr27, dr28, dr29, dr30, dr31, dr32, dr33, dr34, dr35, dr36, dr37, dr38, dr39, dr40, dr41, dr42, dr43, dr44, dr45, dr46, dr47 As SqlDataReader
        Dim ds As New DataSet
        If Request.Params("id") IsNot Nothing Then
            Session("numnota") = Request.Params("id")
        End If
        If Not IsPostBack Then
            If Session("nivel") = 0 Or Session("nivel") = 3 Then
                ocultar.Visible = False
            Else
                ocultar.Visible = True

                Dim nombre As String = ConfigurationManager.AppSettings("expediente")

                If (ConfigurationManager.AppSettings("expediente") IsNot Nothing) Then
                    Label6.Text = ConfigurationManager.AppSettings("expediente")
                    Label7.Text = Session("nomus")
                    Label8.Text = ConfigurationManager.AppSettings("cedula")
                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da = New SqlDataAdapter("select nombres from paciente where pacienteid=@id", con)
                        da.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                        dr = da.SelectCommand.ExecuteReader
                        dr.Read()
                        TextBox1.Visible = False
                        Label2.Visible = True
                        Label2.Text = dr(0)
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
                    da1.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                    dr1 = da1.SelectCommand.ExecuteReader
                    dr1.Read()
                    TextBox2.Visible = False
                    Label3.Visible = True
                    Label3.Text = dr1(0)
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
                    da2.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                    dr2 = da2.SelectCommand.ExecuteReader
                    dr2.Read()
                    TextBox3.Visible = False
                    Label4.Visible = True
                    Label4.Text = dr2(0)
                    con.Close()
                Catch ex As Exception

                End Try

                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    da3 = New SqlDataAdapter("select (cast(datediff(dd,nacimiento,GETDATE()) / 365.25 as int)) from paciente where pacienteid=@pac", con)
                    da3.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                    dr3 = da3.SelectCommand.ExecuteReader
                    dr3.Read()
                    TextBox4.Visible = False
                    Label5.Visible = True
                    Label5.Text = dr3(0)
                    con.Close()
                Catch ex As Exception
                    con.Close()
                End Try
                If Request.Params("id") IsNot Nothing Then
                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da4 = New SqlDataAdapter("select distinct fechamodif from nutricional where pacienteid=@paciente and folionota=@id", con)
                        da4.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                        da4.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                        dr4 = da4.SelectCommand.ExecuteReader
                        dr4.Read()
                        If dr4.HasRows Then
                            Label1.Text = dr4(0)
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da5 = New SqlDataAdapter("select distinct consultaanterior from nutricional where pacienteid=@paciente and folionota=@id", con)
                        da5.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                        da5.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                        dr5 = da5.SelectCommand.ExecuteReader
                        dr5.Read()
                        If dr5.HasRows Then
                            Label20.Text = dr5(0)
                            If Label20.Text = "No" Then
                                Label9.Visible = False
                                Label21.Visible = False
                                TextBox5.Visible = False
                                DropDownList1.Visible = False
                                Label10.Visible = False
                                Label11.Visible = False
                                DropDownList2.Visible = False
                                TextBox6.Visible = False
                                Label22.Visible = False
                                Label23.Visible = False
                            Else
                                Label20.Text = "Si"
                                Label9.Visible = True
                                Label21.Text = dr5(0)
                                TextBox5.Visible = False
                                DropDownList1.Visible = False
                                Label10.Visible = True
                                Label11.Visible = True
                                DropDownList2.Visible = False
                                TextBox6.Visible = False
                                Label22.Visible = True
                                Label23.Visible = True
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
                        da6 = New SqlDataAdapter("select distinct objetivosconsant from nutricional where pacienteid=@paciente and folionota=@id", con)
                        da6.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                        da6.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                        dr6 = da6.SelectCommand.ExecuteReader
                        dr6.Read()
                        If dr6.HasRows Then
                            Label22.Text = dr6(0)
                            If Label22.Text = "No" Then
                                Label9.Visible = False
                                Label23.Visible = False
                                TextBox6.Visible = False

                            Else
                                Label22.Text = "Si"
                                Label9.Visible = True
                                Label23.Text = dr6(0)
                                TextBox6.Visible = False
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
                        da7 = New SqlDataAdapter("select distinct pesobajo from nutricional where pacienteid=@paciente and folionota=@id", con)
                        da7.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                        da7.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                        dr7 = da7.SelectCommand.ExecuteReader
                        dr7.Read()
                        If dr7.HasRows Then
                            Label24.Text = dr7(0)
                            Label24.Visible = True
                            TextBox7.Visible = False
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da8 = New SqlDataAdapter("select distinct pesoalto from nutricional where pacienteid=@paciente and folionota=@id", con)
                        da8.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                        da8.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                        dr8 = da8.SelectCommand.ExecuteReader
                        dr8.Read()
                        If dr8.HasRows Then
                            Label25.Text = dr8(0)
                            Label25.Visible = True
                            TextBox8.Visible = False
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da9 = New SqlDataAdapter("select distinct pesopromedio from nutricional where pacienteid=@paciente and folionota=@id", con)
                        da9.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                        da9.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                        dr9 = da9.SelectCommand.ExecuteReader
                        dr9.Read()
                        If dr9.HasRows Then
                            Label26.Text = dr9(0)
                            Label26.Visible = True
                            TextBox9.Visible = False
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try



                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da11 = New SqlDataAdapter("select distinct alergicoalimento from nutricional where pacienteid=@paciente and folionota=@id", con)
                        da11.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                        da11.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                        dr11 = da11.SelectCommand.ExecuteReader
                        dr11.Read()
                        If dr11.HasRows Then
                            Label27.Text = dr11(0)
                            If Label27.Text = "No" Then
                                Label27.Visible = True
                                Label28.Visible = False
                                DropDownList3.Visible = False
                                TextBox10.Visible = False
                            Else
                                Label27.Text = "Si"
                                Label28.Text = dr11(0)
                                Label28.Visible = True
                                DropDownList3.Visible = False
                                TextBox10.Visible = False
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
                        da12 = New SqlDataAdapter("select distinct intolerantealimento from nutricional where pacienteid=@paciente and folionota=@id", con)
                        da12.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                        da12.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                        dr12 = da12.SelectCommand.ExecuteReader
                        dr12.Read()
                        If dr12.HasRows Then
                            Label29.Text = dr12(0)
                            If Label29.Text = "No" Then
                                Label29.Visible = True
                                TextBox11.Visible = False
                                Label30.Visible = False
                                DropDownList4.Visible = False
                                TextBox11.Visible = False
                            Else
                                Label29.Text = "Si"
                                Label30.Text = dr12(0)
                                Label30.Visible = True
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
                        da13 = New SqlDataAdapter("select distinct alimnogustan from nutricional where pacienteid=@paciente and folionota=@id", con)
                        da13.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                        da13.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                        dr13 = da13.SelectCommand.ExecuteReader
                        dr13.Read()
                        If dr13.HasRows Then
                            Label31.Text = dr13(0)

                            TextBox12.Visible = False
                            Label31.Visible = True


                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da14 = New SqlDataAdapter("select distinct alimgustan from nutricional where pacienteid=@paciente and folionota=@id", con)
                        da14.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                        da14.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                        dr14 = da14.SelectCommand.ExecuteReader
                        dr14.Read()
                        If dr14.HasRows Then
                            Label32.Text = dr14(0)
                            TextBox13.Visible = False
                            Label31.Visible = True
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da15 = New SqlDataAdapter("select distinct impedimentocomidas from nutricional where pacienteid=@paciente and folionota=@id", con)
                        da15.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                        da15.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                        dr15 = da15.SelectCommand.ExecuteReader
                        dr15.Read()
                        If dr15.HasRows Then
                            Label33.Text = dr15(0)
                            If Label33.Text = "No" Then
                                DropDownList5.Visible = False
                                TextBox14.Visible = False
                                Label33.Visible = True
                                Label34.Visible = False
                            Else
                                DropDownList5.Visible = False
                                TextBox14.Visible = False
                                Label33.Visible = True
                                Label34.Visible = True
                                Label34.Text = dr15(0)
                                Label33.Text = "Si"
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
                        da16 = New SqlDataAdapter("select distinct sintomaalimentos from nutricional where pacienteid=@paciente and folionota=@id", con)
                        da16.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                        da16.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                        dr16 = da16.SelectCommand.ExecuteReader
                        dr16.Read()
                        If dr16.HasRows Then
                            DropDownList6.Visible = False
                            TextBox15.Visible = False
                            TextBox16.Visible = False
                            TextBox17.Visible = False
                            Label35.Text = dr16(0)
                            If Label35.Text = "" Then
                                Label35.Text = "No"
                                Label35.Visible = True
                                Label36.Visible = False
                            Else
                                Label35.Text = "Si"
                                Label35.Visible = True
                                Label36.Text = dr16(0)
                                Label36.Visible = True
                                Label37.Visible = True
                                Label38.Visible = True
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    con1.Open()
                                    da17 = New SqlDataAdapter("select distinct alimentoscausantes from nutricional where pacienteid=@paciente and folionota=@id", con1)
                                    da17.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                                    da17.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                                    dr17 = da17.SelectCommand.ExecuteReader
                                    dr17.Read()
                                    Label37.Text = dr17(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    con1.Open()
                                    da18 = New SqlDataAdapter("select distinct alimentosalivian from nutricional where pacienteid=@paciente and folionota=@id", con1)
                                    da18.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                                    da18.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                                    dr18 = da18.SelectCommand.ExecuteReader
                                    dr18.Read()
                                    Label38.Text = dr18(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
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
                        da19 = New SqlDataAdapter("select distinct actividadfisica from nutricional where pacienteid=@paciente and folionota=@id", con)
                        da19.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                        da19.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                        dr19 = da19.SelectCommand.ExecuteReader
                        dr19.Read()
                        If dr19.HasRows Then
                            DropDownList7.Visible = False
                            TextBox18.Visible = False
                            TextBox19.Visible = False
                            Label39.Text = dr19(0)
                            If Label39.Text = "No" Then
                                Label39.Visible = True
                                Label40.Visible = False
                                Label41.Visible = False
                            Else
                                Label39.Text = "Si"
                                Label40.Text = dr19(0)
                                Label39.Visible = True
                                Label40.Visible = True
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    con1.Open()
                                    da20 = New SqlDataAdapter("select distinct tiempoacfisica from nutricional where pacienteid=@paciente and folionota=@id", con1)
                                    da20.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                                    da20.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                                    dr20 = da20.SelectCommand.ExecuteReader
                                    dr20.Read()
                                    Label41.Visible = True
                                    Label41.Text = dr20(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
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
                        da21 = New SqlDataAdapter("select distinct tiempocomida as 'Tiempo de Comida',lugarcomida as 'Lugar', horariocomida as 'Horario', alimentoycant as 'Alimento y Cantidad',valorcalorico as 'Valor Calórico' from nutricional where pacienteid=@paciente and folionota=@id", con)
                        da21.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                        da21.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                        da21.Fill(ds)
                        divPassenger.Visible = False
                        GridView1.DataSource = ds.Tables(0)
                        GridView1.DataBind()
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da22 = New SqlDataAdapter("select distinct talla from nutricional where pacienteid=@paciente and folionota=@id", con)
                        da22.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                        da22.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                        dr22 = da22.SelectCommand.ExecuteReader
                        dr22.Read()
                        If dr22.HasRows Then
                            Label42.Text = dr22(0)
                            Label42.Visible = True
                            TextBox21.Visible = False
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da23 = New SqlDataAdapter("select distinct peso from nutricional where pacienteid=@paciente and folionota=@id", con)
                        da23.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                        da23.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                        dr23 = da23.SelectCommand.ExecuteReader
                        dr23.Read()
                        If dr23.HasRows Then
                            Label43.Text = dr23(0)
                            Label43.Visible = True
                            TextBox22.Visible = False
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da24 = New SqlDataAdapter("select distinct imc from nutricional where pacienteid=@paciente and folionota=@id", con)
                        da24.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                        da24.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                        dr24 = da24.SelectCommand.ExecuteReader
                        dr24.Read()
                        If dr24.HasRows Then
                            Label44.Text = dr24(0)
                            Label44.Visible = True
                            TextBox23.Visible = False
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da25 = New SqlDataAdapter("select distinct circintura from nutricional where pacienteid=@paciente and folionota=@id", con)
                        da25.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                        da25.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                        dr25 = da25.SelectCommand.ExecuteReader
                        dr25.Read()
                        If dr25.HasRows Then
                            Label45.Text = dr25(0)
                            Label45.Visible = True
                            TextBox24.Visible = False
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da26 = New SqlDataAdapter("select distinct circcadera from nutricional where pacienteid=@paciente and folionota=@id", con)
                        da26.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                        da26.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                        dr26 = da26.SelectCommand.ExecuteReader
                        dr26.Read()
                        If dr26.HasRows Then
                            Label46.Text = dr26(0)
                            Label46.Visible = True
                            TextBox25.Visible = False
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da27 = New SqlDataAdapter("select distinct porcgrasa from nutricional where pacienteid=@paciente and folionota=@id", con)
                        da27.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                        da27.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                        dr27 = da27.SelectCommand.ExecuteReader
                        dr27.Read()
                        If dr27.HasRows Then
                            Label47.Text = dr27(0)
                            Label47.Visible = True
                            TextBox26.Visible = False
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da28 = New SqlDataAdapter("select distinct porcmusculo from nutricional where pacienteid=@paciente and folionota=@id", con)
                        da28.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                        da28.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                        dr28 = da28.SelectCommand.ExecuteReader
                        dr28.Read()
                        If dr28.HasRows Then
                            Label48.Text = dr28(0)
                            Label48.Visible = True
                            TextBox27.Visible = False
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da29 = New SqlDataAdapter("select distinct porcagua from nutricional where pacienteid=@paciente and folionota=@id", con)
                        da29.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                        da29.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                        dr29 = da29.SelectCommand.ExecuteReader
                        dr29.Read()
                        If dr29.HasRows Then
                            Label49.Text = dr29(0)
                            Label49.Visible = True
                            TextBox28.Visible = False
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da30 = New SqlDataAdapter("select distinct dietacompleta from nutricional where pacienteid=@paciente and folionota=@id", con)
                        da30.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                        da30.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                        dr30 = da30.SelectCommand.ExecuteReader
                        dr30.Read()
                        If dr30.HasRows Then

                            Label50.Text = dr30(0)
                            Label50.Visible = True
                            DropDownList8.Visible = False
                            TextBox29.Visible = False
                            If Label50.Text = "No" Then
                                Label51.Visible = True
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    con1.Open()
                                    da31 = New SqlDataAdapter("select distinct motivocompleta from nutricional where pacienteid=@paciente and folionota=@id", con1)
                                    da31.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                                    da31.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                                    dr31 = da31.SelectCommand.ExecuteReader
                                    dr31.Read()
                                    Label51.Text = dr31(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                            Else
                                Label51.Visible = False

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
                        da32 = New SqlDataAdapter("select distinct dietaequilibrada from nutricional where pacienteid=@paciente and folionota=@id", con)
                        da32.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                        da32.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                        dr32 = da32.SelectCommand.ExecuteReader
                        dr32.Read()
                        If dr32.HasRows Then

                            Label52.Text = dr32(0)
                            Label52.Visible = True
                            DropDownList9.Visible = False
                            DropDownList10.Visible = False
                            TextBox30.Visible = False
                            If Label52.Text = "No" Then
                                Label53.Visible = True
                                Label54.Visible = True
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    con1.Open()
                                    da33 = New SqlDataAdapter("select distinct motivo1dietaeq from nutricional where pacienteid=@paciente and folionota=@id", con1)
                                    da33.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                                    da33.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                                    dr33 = da33.SelectCommand.ExecuteReader
                                    dr33.Read()
                                    Label53.Text = dr33(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    con1.Open()
                                    da34 = New SqlDataAdapter("select distinct motivo2dietaeq from nutricional where pacienteid=@paciente and folionota=@id", con1)
                                    da34.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                                    da34.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                                    dr34 = da34.SelectCommand.ExecuteReader
                                    dr34.Read()
                                    Label54.Text = dr34(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                            Else
                                Label53.Visible = False
                                Label54.Visible = False
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
                        da35 = New SqlDataAdapter("select distinct dietavariada from nutricional where pacienteid=@paciente and folionota=@id", con)
                        da35.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                        da35.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                        dr35 = da35.SelectCommand.ExecuteReader
                        dr35.Read()
                        If dr35.HasRows Then

                            Label55.Text = dr35(0)
                            Label55.Visible = True
                            DropDownList11.Visible = False
                            TextBox31.Visible = False
                            If Label55.Text = "No" Then
                                Label56.Visible = True
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    con1.Open()
                                    da36 = New SqlDataAdapter("select distinct motivodietavar from nutricional where pacienteid=@paciente and folionota=@id", con1)
                                    da36.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                                    da36.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                                    dr36 = da36.SelectCommand.ExecuteReader
                                    dr36.Read()
                                    Label56.Text = dr36(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                            Else
                                Label56.Visible = False

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
                        da37 = New SqlDataAdapter("select distinct dietaadecuada from nutricional where pacienteid=@paciente and folionota=@id", con)
                        da37.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                        da37.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                        dr37 = da37.SelectCommand.ExecuteReader
                        dr37.Read()
                        If dr37.HasRows Then

                            Label57.Text = dr37(0)
                            Label57.Visible = True
                            DropDownList12.Visible = False
                            DropDownList13.Visible = False
                            TextBox32.Visible = False
                            If Label57.Text = "No" Then
                                Label58.Visible = True
                                Label59.Visible = True
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    con1.Open()
                                    da38 = New SqlDataAdapter("select distinct motivo1dietaadec from nutricional where pacienteid=@paciente and folionota=@id", con1)
                                    da38.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                                    da38.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                                    dr38 = da38.SelectCommand.ExecuteReader
                                    dr38.Read()
                                    Label58.Text = dr38(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    con1.Open()
                                    da39 = New SqlDataAdapter("select distinct motivo2dietaadec from nutricional where pacienteid=@paciente and folionota=@id", con1)
                                    da39.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                                    da39.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                                    dr39 = da39.SelectCommand.ExecuteReader
                                    dr39.Read()
                                    Label59.Text = dr39(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                            Else
                                Label58.Visible = False
                                Label59.Visible = False
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
                        da40 = New SqlDataAdapter("select distinct dietasufic from nutricional where pacienteid=@paciente and folionota=@id", con)
                        da40.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                        da40.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                        dr40 = da40.SelectCommand.ExecuteReader
                        dr40.Read()
                        If dr40.HasRows Then

                            Label60.Text = dr40(0)
                            Label60.Visible = True
                            DropDownList14.Visible = False
                            DropDownList15.Visible = False
                            TextBox33.Visible = False
                            If Label60.Text = "No" Then
                                Label61.Visible = True
                                Label62.Visible = True
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    con1.Open()
                                    da41 = New SqlDataAdapter("select distinct motivo1dietasufic from nutricional where pacienteid=@paciente and folionota=@id", con1)
                                    da41.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                                    da41.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                                    dr41 = da41.SelectCommand.ExecuteReader
                                    dr41.Read()
                                    Label61.Text = dr41(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    con1.Open()
                                    da42 = New SqlDataAdapter("select distinct motivo2dietasufic from nutricional where pacienteid=@paciente and folionota=@id", con1)
                                    da42.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                                    da42.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                                    dr42 = da42.SelectCommand.ExecuteReader
                                    dr42.Read()
                                    Label62.Text = dr42(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                            Else
                                Label61.Visible = False
                                Label62.Visible = False
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
                        da43 = New SqlDataAdapter("select distinct dietainocua from nutricional where pacienteid=@paciente and folionota=@id", con)
                        da43.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                        da43.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                        dr43 = da43.SelectCommand.ExecuteReader
                        dr43.Read()
                        If dr43.HasRows Then

                            Label63.Text = dr43(0)
                            Label63.Visible = True
                            DropDownList16.Visible = False
                            TextBox34.Visible = False
                            If Label63.Text = "No" Then
                                Label64.Visible = True
                                Try
                                    If con1.State = ConnectionState.Open Then
                                        con1.Close()
                                    End If
                                    con1.Open()
                                    da44 = New SqlDataAdapter("select distinct motivodietainocua from nutricional where pacienteid=@paciente and folionota=@id", con1)
                                    da44.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                                    da44.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                                    dr44 = da44.SelectCommand.ExecuteReader
                                    dr44.Read()
                                    Label64.Text = dr44(0)
                                    con1.Close()
                                Catch ex As Exception

                                End Try
                            Else
                                Label64.Visible = False

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
                        da45 = New SqlDataAdapter("select distinct diagnutric from nutricional where pacienteid=@paciente and folionota=@id", con)
                        da45.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                        da45.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                        dr45 = da45.SelectCommand.ExecuteReader
                        dr45.Read()
                        If dr45.HasRows Then
                            Label65.Text = dr45(0)
                            Label65.Visible = True
                            TextBox35.Visible = False
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da46 = New SqlDataAdapter("select distinct objtratamiento from nutricional where pacienteid=@paciente and folionota=@id", con)
                        da46.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                        da46.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                        dr46 = da46.SelectCommand.ExecuteReader
                        dr46.Read()
                        If dr46.HasRows Then
                            Label66.Text = dr46(0)
                            Label66.Visible = True
                            TextBox36.Visible = False
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da47 = New SqlDataAdapter("select distinct objtratamiento from nutricional where pacienteid=@paciente and folionota=@id", con)
                        da47.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                        da47.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                        dr47 = da47.SelectCommand.ExecuteReader
                        dr47.Read()
                        If dr47.HasRows Then
                            Label67.Text = dr47(0)
                            Label67.Visible = True
                            TextBox37.Visible = False
                        End If
                        con.Close()
                    Catch ex As Exception

                    End Try
                End If


            End If

            'ReDim arregloTextBoxs1(0 To 100 - 1)
            'ReDim arregloTextBoxs2(0 To 100 - 1)
            'ReDim arregloTextBoxs3(0 To 100 - 1)
            'ReDim arregloTextBoxs4(0 To 100 - 1)
            'ReDim arregloCombos(0 To 100 - 1)


            ' contadorControles = 0
            'If Button1.OnClientClick = True Then
            '    Try
            '        Dim numeroRegistro As Integer = contadorControles
            '        Dim nuevoTxt1, nuevoTxt2, nuevoTxt3, nuevoTxt4 As New TextBox()
            '        nuevoTxt1.ID = "txtlugar" & numeroRegistro.ToString()
            '        nuevoTxt1.Width = 100
            '        nuevoTxt1.AutoPostBack = True
            '        nuevoTxt2.ID = "txthorario" & numeroRegistro.ToString()
            '        nuevoTxt2.Width = 150
            '        nuevoTxt2.AutoPostBack = True
            '        nuevoTxt3.ID = "txtalimycant" & numeroRegistro.ToString()
            '        nuevoTxt3.Width = 150
            '        nuevoTxt3.AutoPostBack = True
            '        nuevoTxt4.ID = "txtvalcalor" & numeroRegistro.ToString()
            '        nuevoTxt4.Width = 100
            '        nuevoTxt4.AutoPostBack = True
            '        arregloTextBoxs1(numeroRegistro) = nuevoTxt1
            '        arregloTextBoxs2(numeroRegistro) = nuevoTxt2
            '        arregloTextBoxs3(numeroRegistro) = nuevoTxt3
            '        arregloTextBoxs4(numeroRegistro) = nuevoTxt4
            '        Dim nuevoCmb As New DropDownList()
            '        nuevoCmb.ID = "cmb" & numeroRegistro.ToString()
            '        nuevoCmb.Items.Add("---Seleccione el Plazo---")
            '        nuevoCmb.Items.Add("Desayuno")
            '        nuevoCmb.Items.Add("Comida")
            '        nuevoCmb.Items.Add("Cena")
            '        nuevoCmb.Items.Add("Colación")
            '        nuevoCmb.SelectedIndex = 0
            '        nuevoCmb.AutoPostBack = True
            '        arregloCombos(numeroRegistro) = nuevoCmb
            '        AgregarControles(nuevoCmb, nuevoTxt1, nuevoTxt2, nuevoTxt3, nuevoTxt4)
            '        MsgBox(nuevoTxt1.ID)
            '        contadorControles += 1

            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '    End Try
            'End If

        End If




        'Try
        '    For i As Integer = 0 To contadorControles - 1
        '        AgregarControles(arregloCombos(i), arregloTextBoxs1(i), arregloTextBoxs2(i), arregloTextBoxs3(i), arregloTextBoxs4(i))
        '    Next
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

    End Sub

    Protected Sub exportar_Click(sender As Object, e As EventArgs) Handles exportar.Click
        Dim sw As New StringWriter()
        Dim hw As New HtmlTextWriter(sw)
        Response.ContentType = "application/pdf"
        Response.AddHeader("content-disposition", "attachment;filename=" & Session("numnota") & ".pdf")
        Response.Cache.SetCacheability(HttpCacheability.NoCache)

        exporta.RenderControl(hw)
        Dim sr As New StringReader(sw.ToString())
        Dim pdfDoc As New Document(PageSize.A4, 10.0F, 10.0F, 100.0F, 0.0F)
        Dim htmlparser As New HTMLWorker(pdfDoc)
        PdfWriter.GetInstance(pdfDoc, Response.OutputStream)
        pdfDoc.Open()
        htmlparser.Parse(sr)
        pdfDoc.Close()



        Response.Write(pdfDoc)

        Response.Close()
    End Sub
End Class