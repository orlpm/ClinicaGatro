Imports System.Data.SqlClient
Public Class ModificaNutricion
    Inherits System.Web.UI.Page
    Protected Overrides Sub OnInit(e As EventArgs)
        CargarControles()

    End Sub

    Protected Sub CargarControles()
        Dim i As Integer = 1
        For i = 1 To Session("contador") Step 1

            Dim cpas As Recalimentos = CType(LoadControl("Recalimentos.ascx"), Recalimentos)
            cpas.ID = "cPas" & i
            cpas.AsignarID(i)
            divPassenger.Controls.Add(cpas)
        Next
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = Date.Now
        Dim da, da1, da2, da3, da4, da5, da6, da7, da8, da9, da10, da11, da12, da13, da14, da15, da16, da17, da18, da19, da20, da21, da22, da23, da24, da25, da26, da27, da28, da29, da30, da31, da32, da33, da34, da35, da36, da37, da38, da39, da40, da41, da42, da43, da44, da45, da46, da47, da48, da49, da50, da51, da52, da53 As New SqlDataAdapter
        Dim dr, dr1, dr2, dr3, dr4, dr5, dr6, dr7, dr8, dr9, dr11, dr12, dr13, dr14, dr15, dr16, dr17, dr18, dr19, dr20, dr22, dr23, dr24, dr25, dr26, dr27, dr28, dr29, dr30, dr31, dr32, dr33, dr34, dr35, dr36, dr37, dr38, dr39, dr40, dr41, dr42, dr43, dr44, dr45, dr46, dr47, dr48, dr49, dr50, dr51, dr52, dr53 As SqlDataReader
        Dim ds As New DataSet
        Dim paciente As New Integer
        
        If Not IsPostBack Then
            Session("contador") = 1
            If Request.Params("id2") IsNot Nothing Then
                Session("numnota") = Request.Params("id2")
                paciente = Request.Params("pac")
            End If
            If Session("nivel") = 0 Or Session("nivel") = 3 Then
                ocultar.Visible = False
            Else
                If Not IsPostBack Then


                    ocultar.Visible = True

                    Dim nombre As String = ConfigurationManager.AppSettings("expediente")

                    If (Request.Params("pac") IsNot Nothing) Then
                        Label6.Text = Request.Params("pac")
                        Label7.Text = Session("nomus")
                        Label8.Text = ConfigurationManager.AppSettings("cedula")
                        Try
                            If con.State = ConnectionState.Open Then
                                con.Close()
                            End If
                            con.Open()
                            da = New SqlDataAdapter("select nombres from paciente where pacienteid=@id", con)
                            da.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Request.Params("pac")
                            dr = da.SelectCommand.ExecuteReader
                            dr.Read()
                            TextBox1.Visible = False
                            Label2.Visible = True
                            Label2.Text = dr(0)
                            con.Close()
                        Catch ex As Exception

                        Finally

                        End Try
                    End If
                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()

                        End If
                        con.Open()
                        da1 = New SqlDataAdapter("select appaterno from paciente where pacienteid=@id", con)
                        da1.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Request.Params("pac")
                        dr1 = da1.SelectCommand.ExecuteReader
                        dr1.Read()
                        TextBox2.Visible = False
                        Label3.Visible = True
                        Label3.Text = dr1(0)
                        con.Close()
                    Catch ex As Exception
                    End Try

                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da2 = New SqlDataAdapter("select apmaterno from paciente where pacienteid=@id", con)
                        da2.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Request.Params("pac")
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
                        da3.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Request.Params("pac")
                        dr3 = da3.SelectCommand.ExecuteReader
                        dr3.Read()
                        TextBox4.Visible = False
                        Label5.Visible = True
                        Label5.Text = dr3(0)
                        con.Close()
                    Catch ex As Exception
                        con.Close()
                    End Try
                    If Request.Params("id2") IsNot Nothing Then
                        

                        Try
                            If con.State = ConnectionState.Open Then
                                con.Close()
                            End If
                            con.Open()
                            da5 = New SqlDataAdapter("select distinct consultaanterior from nutricional where pacienteid=@paciente and folionota=@id", con)
                            da5.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                            da5.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            dr5 = da5.SelectCommand.ExecuteReader
                            dr5.Read()
                            If dr5.HasRows Then
                                DropDownList1.Text = dr5(0)
                                If DropDownList1.Text = "No" Then
                                    Label9.Visible = False

                                    TextBox5.Visible = False
                                    DropDownList1.Visible = True
                                    Label10.Visible = False
                                    Label11.Visible = False
                                    DropDownList2.Visible = False
                                    TextBox6.Visible = False

                                Else
                                    DropDownList1.Text = "Si"
                                    Label9.Visible = False
                                    TextBox5.Text = dr5(0)
                                    TextBox5.Visible = True
                                    DropDownList1.Visible = True
                                    Label10.Visible = False
                                    Label11.Visible = False
                                    DropDownList2.Visible = True
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
                            da6 = New SqlDataAdapter("select distinct objetivosconsant from nutricional where pacienteid=@paciente and folionota=@id", con)
                            da6.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                            da6.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            dr6 = da6.SelectCommand.ExecuteReader
                            dr6.Read()
                            If dr6.HasRows Then
                                DropDownList2.Text = dr6(0)
                                If DropDownList2.Text = "No" Then
                                    Label9.Visible = False
                                    TextBox6.Visible = False
                                    DropDownList2.Visible = False
                                Else
                                    DropDownList2.Text = "Si"
                                    Label9.Visible = False
                                    TextBox6.Text = dr6(0)
                                    TextBox6.Visible = True
                                    DropDownList2.Visible = True
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
                            da7.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                            da7.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            dr7 = da7.SelectCommand.ExecuteReader
                            dr7.Read()
                            TextBox7.Visible = False
                            If dr7.HasRows Then
                                TextBox7.Visible = True
                                TextBox7.Text = dr7(0)
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
                            da8.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                            da8.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            dr8 = da8.SelectCommand.ExecuteReader
                            dr8.Read()
                            If dr8.HasRows Then
                                TextBox8.Text = dr8(0)
                                TextBox8.Visible = True
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
                            da9.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                            da9.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            dr9 = da9.SelectCommand.ExecuteReader
                            dr9.Read()
                            If dr9.HasRows Then
                                TextBox9.Text = dr9(0)
                                TextBox9.Visible = True
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
                            da11.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                            da11.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            dr11 = da11.SelectCommand.ExecuteReader
                            dr11.Read()
                            If dr11.HasRows Then
                                DropDownList3.Text = dr11(0)
                                If DropDownList3.Text = "No" Then
                                    DropDownList3.Visible = True
                                    TextBox10.Visible = False
                                Else
                                    DropDownList3.Text = "Si"
                                    TextBox10.Text = dr11(0)
                                    DropDownList3.Visible = True
                                    TextBox10.Visible = True
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
                            da12.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                            da12.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            dr12 = da12.SelectCommand.ExecuteReader
                            dr12.Read()
                            If dr12.HasRows Then
                                If DropDownList4.Text = "No" Then
                                    TextBox11.Visible = False
                                    DropDownList4.Visible = True
                                    TextBox11.Visible = False
                                    Label13.Visible = False
                                Else
                                    DropDownList4.Text = "Si"
                                    TextBox11.Text = dr12(0)
                                    TextBox11.Visible = True
                                    Label13.Visible = True
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
                            da13.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                            da13.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            dr13 = da13.SelectCommand.ExecuteReader
                            dr13.Read()
                            If dr13.HasRows Then
                                TextBox12.Text = dr13(0)

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
                            da14 = New SqlDataAdapter("select distinct alimgustan from nutricional where pacienteid=@paciente and folionota=@id", con)
                            da14.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                            da14.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            dr14 = da14.SelectCommand.ExecuteReader
                            dr14.Read()
                            If dr14.HasRows Then
                                TextBox13.Text = dr14(0)
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
                            da15 = New SqlDataAdapter("select distinct impedimentocomidas from nutricional where pacienteid=@paciente and folionota=@id", con)
                            da15.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                            da15.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            dr15 = da15.SelectCommand.ExecuteReader
                            dr15.Read()
                            If dr15.HasRows Then
                                DropDownList5.Text = dr15(0)
                                If DropDownList5.Text = "No" Then
                                    DropDownList5.Visible = True
                                    TextBox14.Visible = False
                                    Label14.Visible = False
                                Else
                                    DropDownList5.Visible = True
                                    TextBox14.Visible = True
                                    TextBox14.Text = dr15(0)
                                    DropDownList5.Text = "Si"
                                    Label14.Visible = True
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
                            da16.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                            da16.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            dr16 = da16.SelectCommand.ExecuteReader
                            dr16.Read()
                            If dr16.HasRows Then
                                
                                DropDownList6.Text = dr16(0)
                                If DropDownList6.Text = "" Then
                                    DropDownList6.Text = "No"
                                    DropDownList6.Visible = True
                                    TextBox15.Visible = True
                                    TextBox16.Visible = True
                                    TextBox17.Visible = True
                                    Label15.Visible = True
                                    Label16.Visible = True
                                    Label17.Visible = True
                                Else
                                    TextBox15.Text = dr16(0)
                                    TextBox15.Visible = False
                                    TextBox16.Visible = False
                                    TextBox17.Visible = False
                                    Label15.Visible = False
                                    Label16.Visible = False
                                    Label17.Visible = False
                                    Try
                                        If con1.State = ConnectionState.Open Then
                                            con1.Close()
                                        End If
                                        con1.Open()
                                        da17 = New SqlDataAdapter("select distinct alimentoscausantes from nutricional where pacienteid=@paciente and folionota=@id", con1)
                                        da17.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                                        da17.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                                        dr17 = da17.SelectCommand.ExecuteReader
                                        dr17.Read()
                                        TextBox16.Text = dr17(0)
                                        con1.Close()
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        If con1.State = ConnectionState.Open Then
                                            con1.Close()
                                        End If
                                        con1.Open()
                                        da18 = New SqlDataAdapter("select distinct alimentosalivian from nutricional where pacienteid=@paciente and folionota=@id", con1)
                                        da18.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                                        da18.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                                        dr18 = da18.SelectCommand.ExecuteReader
                                        dr18.Read()
                                        TextBox17.Text = dr18(0)
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
                            da19.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                            da19.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            dr19 = da19.SelectCommand.ExecuteReader
                            dr19.Read()
                            If dr19.HasRows Then
                                
                                DropDownList7.Text = dr19(0)
                                If DropDownList7.Text = "No" Then
                                    DropDownList7.Visible = True
                                    TextBox18.Visible = False
                                    TextBox19.Visible = False
                                Else
                                    DropDownList7.Text = "Si"
                                    TextBox18.Text = dr19(0)
                                    Try
                                        If con1.State = ConnectionState.Open Then
                                            con1.Close()
                                        End If
                                        con1.Open()
                                        da20 = New SqlDataAdapter("select distinct tiempoacfisica from nutricional where pacienteid=@paciente and folionota=@id", con1)
                                        da20.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                                        da20.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                                        dr20 = da20.SelectCommand.ExecuteReader
                                        dr20.Read()
                                        TextBox19.Text = dr20(0)
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
                            da21.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                            da21.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            da21.Fill(ds)
                            'tablaenc20.Visible = True
                            If ds.Tables.Count > 0 Then
                                GridView1.Visible = True
                                GridView1.DataSource = ds.Tables(0)
                                GridView1.DataBind()
                                con.Close()
                            Else
                                GridView1.Visible = True

                            End If


                        Catch ex As Exception

                        End Try

                        Try
                            If con.State = ConnectionState.Open Then
                                con.Close()
                            End If
                            con.Open()
                            da22 = New SqlDataAdapter("select distinct talla from nutricional where pacienteid=@paciente and folionota=@id", con)
                            da22.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                            da22.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            dr22 = da22.SelectCommand.ExecuteReader
                            dr22.Read()
                            If dr22.HasRows Then
                                TextBox21.Text = dr22(0)
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
                            da23 = New SqlDataAdapter("select distinct peso from nutricional where pacienteid=@paciente and folionota=@id", con)
                            da23.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                            da23.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            dr23 = da23.SelectCommand.ExecuteReader
                            dr23.Read()
                            If dr23.HasRows Then
                                TextBox22.Text = dr23(0)
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
                            da24 = New SqlDataAdapter("select distinct imc from nutricional where pacienteid=@paciente and folionota=@id", con)
                            da24.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                            da24.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            dr24 = da24.SelectCommand.ExecuteReader
                            dr24.Read()
                            If dr24.HasRows Then
                                TextBox23.Text = dr24(0)
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
                            da25 = New SqlDataAdapter("select distinct circintura from nutricional where pacienteid=@paciente and folionota=@id", con)
                            da25.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                            da25.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            dr25 = da25.SelectCommand.ExecuteReader
                            dr25.Read()
                            If dr25.HasRows Then
                                TextBox24.Text = dr25(0)
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
                            da26 = New SqlDataAdapter("select distinct circcadera from nutricional where pacienteid=@paciente and folionota=@id", con)
                            da26.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                            da26.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            dr26 = da26.SelectCommand.ExecuteReader
                            dr26.Read()
                            If dr26.HasRows Then
                                TextBox25.Text = dr26(0)
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
                            da27 = New SqlDataAdapter("select distinct porcgrasa from nutricional where pacienteid=@paciente and folionota=@id", con)
                            da27.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                            da27.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            dr27 = da27.SelectCommand.ExecuteReader
                            dr27.Read()
                            If dr27.HasRows Then
                                TextBox26.Text = dr27(0)
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
                            da28 = New SqlDataAdapter("select distinct porcmusculo from nutricional where pacienteid=@paciente and folionota=@id", con)
                            da28.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                            da28.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            dr28 = da28.SelectCommand.ExecuteReader
                            dr28.Read()
                            If dr28.HasRows Then
                                TextBox27.Text = dr28(0)
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
                            da29 = New SqlDataAdapter("select distinct porcagua from nutricional where pacienteid=@paciente and folionota=@id", con)
                            da29.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                            da29.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            dr29 = da29.SelectCommand.ExecuteReader
                            dr29.Read()
                            If dr29.HasRows Then
                                TextBox28.Text = dr29(0)
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
                            da30 = New SqlDataAdapter("select distinct dietacompleta from nutricional where pacienteid=@paciente and folionota=@id", con)
                            da30.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                            da30.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            dr30 = da30.SelectCommand.ExecuteReader
                            dr30.Read()
                            If dr30.HasRows Then

                                DropDownList8.Text = dr30(0)
                               
                                If DropDownList8.Text = "No" Then
                                    DropDownList8.Visible = True
                                    TextBox29.Visible = True
                                    Try
                                        If con1.State = ConnectionState.Open Then
                                            con1.Close()
                                        End If
                                        con1.Open()
                                        da31 = New SqlDataAdapter("select distinct motivocompleta from nutricional where pacienteid=@paciente and folionota=@id", con1)
                                        da31.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                                        da31.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                                        dr31 = da31.SelectCommand.ExecuteReader
                                        dr31.Read()
                                        TextBox29.Text = dr31(0)
                                        con1.Close()
                                    Catch ex As Exception

                                    End Try
                                Else
                                    TextBox29.Visible = False

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
                            da32.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                            da32.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            dr32 = da32.SelectCommand.ExecuteReader
                            dr32.Read()
                            If dr32.HasRows Then

                                DropDownList9.Text = dr32(0)
                                
                                If DropDownList9.Text = "No" Then
                                    DropDownList9.Visible = True
                                    TextBox30.Visible = True
                                    Try
                                        If con1.State = ConnectionState.Open Then
                                            con1.Close()
                                        End If
                                        con1.Open()
                                        da33 = New SqlDataAdapter("select distinct motivo1dietaeq from nutricional where pacienteid=@paciente and folionota=@id", con1)
                                        da33.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                                        da33.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                                        dr33 = da33.SelectCommand.ExecuteReader
                                        dr33.Read()
                                        con1.Close()
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        If con1.State = ConnectionState.Open Then
                                            con1.Close()
                                        End If
                                        con1.Open()
                                        da34 = New SqlDataAdapter("select distinct motivo2dietaeq from nutricional where pacienteid=@paciente and folionota=@id", con1)
                                        da34.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                                        da34.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                                        dr34 = da34.SelectCommand.ExecuteReader
                                        dr34.Read()
                                        TextBox30.Text = dr34(0)
                                        con1.Close()
                                    Catch ex As Exception

                                    End Try
                                Else
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
                            da35.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                            da35.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            dr35 = da35.SelectCommand.ExecuteReader
                            dr35.Read()
                            If dr35.HasRows Then

                                DropDownList11.Text = dr35(0)
                                
                                If DropDownList11.Text = "No" Then
                                    DropDownList11.Visible = True
                                    TextBox31.Visible = True
                                    Try
                                        If con1.State = ConnectionState.Open Then
                                            con1.Close()
                                        End If
                                        con1.Open()
                                        da36 = New SqlDataAdapter("select distinct motivodietavar from nutricional where pacienteid=@paciente and folionota=@id", con1)
                                        da36.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                                        da36.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                                        dr36 = da36.SelectCommand.ExecuteReader
                                        dr36.Read()
                                        TextBox31.Text = dr36(0)
                                        con1.Close()
                                    Catch ex As Exception

                                    End Try
                                Else
                                    TextBox31.Visible = False

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
                            da37.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                            da37.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            dr37 = da37.SelectCommand.ExecuteReader
                            dr37.Read()
                            If dr37.HasRows Then

                                
                                TextBox32.Visible = True
                                If DropDownList12.Text = "No" Then
                                    DropDownList12.Text = dr37(0)
                                    DropDownList12.Visible = True
                                    CheckBox4.Visible = True
                                    CheckBox5.Visible = True
                                    CheckBox6.Visible = True
                                    CheckBox7.Visible = True
                                    CheckBox8.Visible = True
                                    Try
                                        If con1.State = ConnectionState.Open Then
                                            con1.Close()
                                        End If
                                        con1.Open()
                                        da38 = New SqlDataAdapter("select distinct motivo1dietaadec from nutricional where pacienteid=@paciente and folionota=@id", con1)
                                        da38.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                                        da38.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                                        dr38 = da38.SelectCommand.ExecuteReader
                                        dr38.Read()

                                        con1.Close()
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        If con1.State = ConnectionState.Open Then
                                            con1.Close()
                                        End If
                                        con1.Open()
                                        da39 = New SqlDataAdapter("select distinct motivo2dietaadec from nutricional where pacienteid=@paciente and folionota=@id", con1)
                                        da39.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                                        da39.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                                        dr39 = da39.SelectCommand.ExecuteReader
                                        dr39.Read()
                                        TextBox32.Text = dr39(0)
                                        con1.Close()
                                    Catch ex As Exception

                                    End Try
                                Else
                                    CheckBox4.Visible = False
                                    CheckBox5.Visible = False
                                    CheckBox6.Visible = False
                                    CheckBox7.Visible = False
                                    CheckBox8.Visible = False
                                    TextBox32.Visible = False
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
                            da40.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                            da40.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            dr40 = da40.SelectCommand.ExecuteReader
                            dr40.Read()
                            If dr40.HasRows Then

                                DropDownList14.Text = dr40(0)
                                
                                If DropDownList14.Text = "No" Then
                                    DropDownList14.Visible = True
                                    DropDownList15.Visible = True
                                    TextBox33.Visible = True
                                    Try
                                        If con1.State = ConnectionState.Open Then
                                            con1.Close()
                                        End If
                                        con1.Open()
                                        da41 = New SqlDataAdapter("select distinct motivo1dietasufic from nutricional where pacienteid=@paciente and folionota=@id", con1)
                                        da41.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                                        da41.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                                        dr41 = da41.SelectCommand.ExecuteReader
                                        dr41.Read()
                                        DropDownList15.Text = dr41(0)
                                        con1.Close()
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        If con1.State = ConnectionState.Open Then
                                            con1.Close()
                                        End If
                                        con1.Open()
                                        da42 = New SqlDataAdapter("select distinct motivo2dietasufic from nutricional where pacienteid=@paciente and folionota=@id", con1)
                                        da42.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                                        da42.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                                        dr42 = da42.SelectCommand.ExecuteReader
                                        dr42.Read()
                                        TextBox33.Text = dr42(0)
                                        con1.Close()
                                    Catch ex As Exception

                                    End Try
                                Else
                                    DropDownList15.Visible = False
                                    TextBox33.Visible = False
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
                            da43.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                            da43.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            dr43 = da43.SelectCommand.ExecuteReader
                            dr43.Read()
                            If dr43.HasRows Then

                                DropDownList16.Text = dr43(0)
                                
                                If DropDownList16.Text = "No" Then
                                    DropDownList16.Visible = True
                                    TextBox34.Visible = True
                                    Try
                                        If con1.State = ConnectionState.Open Then
                                            con1.Close()
                                        End If
                                        con1.Open()
                                        da44 = New SqlDataAdapter("select distinct motivodietainocua from nutricional where pacienteid=@paciente and folionota=@id", con1)
                                        da44.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                                        da44.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                                        dr44 = da44.SelectCommand.ExecuteReader
                                        dr44.Read()
                                        TextBox34.Text = dr44(0)
                                        con1.Close()
                                    Catch ex As Exception

                                    End Try
                                Else

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
                            da45.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                            da45.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            dr45 = da45.SelectCommand.ExecuteReader
                            dr45.Read()
                            If dr45.HasRows Then
                                TextBox35.Text = dr45(0)
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
                            da46 = New SqlDataAdapter("select distinct objtratamiento from nutricional where pacienteid=@paciente and folionota=@id", con)
                            da46.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                            da46.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            dr46 = da46.SelectCommand.ExecuteReader
                            dr46.Read()
                            If dr46.HasRows Then
                                TextBox36.Text = dr46(0)
                                Label66.Visible = False
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
                            da47 = New SqlDataAdapter("select distinct tratamnutricional from nutricional where pacienteid=@paciente and folionota=@id", con)
                            da47.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = Request.Params("pac")
                            da47.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            dr47 = da47.SelectCommand.ExecuteReader
                            dr47.Read()
                            If dr47.HasRows Then
                                TextBox37.Text = dr47(0)
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
                            da48 = New SqlDataAdapter("select distinct proteina from nutricional where pacienteid=@paciente and folionota=@id", con)
                            da48.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                            da48.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            dr48 = da48.SelectCommand.ExecuteReader
                            dr48.Read()
                            CheckBox1.Checked = dr48(0)
                            con.Close()
                        Catch ex As Exception

                        End Try

                        Try
                            If con.State = ConnectionState.Open Then
                                con.Close()
                            End If
                            con.Open()
                            da49 = New SqlDataAdapter("select distinct grasa from nutricional where pacienteid=@paciente and folionota=@id", con)
                            da49.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                            da49.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            dr49 = da49.SelectCommand.ExecuteReader
                            dr49.Read()
                            CheckBox3.Checked = dr49(0)
                            con.Close()
                        Catch ex As Exception

                        End Try
                        Try
                            If con.State = ConnectionState.Open Then
                                con.Close()
                            End If
                            con.Open()
                            da50 = New SqlDataAdapter("select distinct grasas from nutricional where pacienteid=@paciente and folionota=@id", con)
                            da50.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                            da50.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            dr50 = da50.SelectCommand.ExecuteReader
                            dr50.Read()
                            CheckBox4.Checked = dr50(0)
                            con.Close()
                        Catch ex As Exception

                        End Try

                        Try
                            If con.State = ConnectionState.Open Then
                                con.Close()
                            End If
                            con.Open()
                            da51 = New SqlDataAdapter("select distinct irritantes from nutricional where pacienteid=@paciente and folionota=@id", con)
                            da51.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                            da51.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            dr51 = da51.SelectCommand.ExecuteReader
                            dr51.Read()
                            CheckBox6.Checked = dr51(0)
                            con.Close()
                        Catch ex As Exception

                        End Try

                        Try
                            If con.State = ConnectionState.Open Then
                                con.Close()
                            End If
                            con.Open()
                            da52 = New SqlDataAdapter("select distinct condimentos from nutricional where pacienteid=@paciente and folionota=@id", con)
                            da52.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                            da52.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            dr52 = da52.SelectCommand.ExecuteReader
                            dr52.Read()

                            CheckBox7.Checked = dr52(0)
                            con.Close()
                        Catch ex As Exception

                        End Try

                        Try
                            If con.State = ConnectionState.Open Then
                                con.Close()
                            End If
                            con.Open()
                            da53 = New SqlDataAdapter("select distinct alcohol from nutricional where pacienteid=@paciente and folionota=@id", con)
                            da53.SelectCommand.Parameters.Add("@paciente", SqlDbType.Int).Value = ConfigurationManager.AppSettings("expediente")
                            da53.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("numnota")
                            dr53 = da53.SelectCommand.ExecuteReader
                            dr53.Read()
                            CheckBox8.Checked = dr53(0)
                            con.Close()
                        Catch ex As Exception

                        End Try
                    End If

                End If
            End If
        End If
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        If DropDownList1.Text = "No" Then
            Label9.Visible = False
            TextBox5.Visible = False
            Label10.Visible = False
            DropDownList2.Visible = False
            Label11.Visible = False
            TextBox6.Visible = False
        Else
            Label9.Visible = True
            TextBox5.Visible = True
            Label10.Visible = True
            DropDownList2.Visible = True
            Label11.Visible = True
            TextBox6.Visible = True
        End If
    End Sub

    
    Protected Sub DropDownList3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList3.SelectedIndexChanged
        If DropDownList3.Text = "No" Then
            Label12.Visible = False
            TextBox10.Visible = False
        Else
            Label12.Visible = True
            TextBox10.Visible = True
        End If
    End Sub

    Protected Sub DropDownList4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList4.SelectedIndexChanged
        

        If DropDownList4.Text = "No" Then
            Label13.Visible = False
            TextBox11.Visible = False
        Else
            Label13.Visible = True
            TextBox11.Visible = True
        End If
    End Sub

    Protected Sub DropDownList5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList5.SelectedIndexChanged
        
        If DropDownList5.Text = "No" Then
            Label14.Visible = False
            TextBox14.Visible = False
        Else
            Label14.Visible = True
            TextBox14.Visible = True
        End If
    End Sub

    Protected Sub DropDownList6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList6.SelectedIndexChanged
        If DropDownList6.Text = "No" Then
            Label15.Visible = False
            TextBox15.Visible = False
            Label16.Visible = False
            TextBox16.Visible = False
            Label17.Visible = False
            TextBox17.Visible = False
        Else
            Label15.Visible = True
            TextBox15.Visible = True
            Label16.Visible = True
            TextBox16.Visible = True
            Label17.Visible = True
            TextBox17.Visible = True
        End If
    End Sub

    Protected Sub DropDownList7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList7.SelectedIndexChanged
        If DropDownList7.Text = "No" Then
            Label18.Visible = False
            TextBox18.Visible = False
            Label19.Visible = False
            TextBox19.Visible = False
            
        Else
            Label18.Visible = True
            TextBox18.Visible = True
            Label19.Visible = True
            TextBox19.Visible = True
            
        End If
    End Sub

    Protected Sub DropDownList9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList9.SelectedIndexChanged
        If DropDownList9.Text = "No" Then
            CheckBox1.Visible = True
            CheckBox2.Visible = True
            CheckBox3.Visible = True
            TextBox30.Visible = True
            Label69.Visible = True
        Else
            CheckBox1.Visible = False
            CheckBox2.Visible = False
            CheckBox3.Visible = False
            TextBox30.Visible = False
            Label69.Visible = False
        End If
    End Sub

    Protected Sub DropDownList11_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList11.SelectedIndexChanged
        If DropDownList11.Text = "No" Then

            TextBox31.Visible = True
            Label70.Visible = True
        Else
            TextBox31.Visible = False
            Label70.Visible = False
        End If
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim da As New SqlDataAdapter
        If Session("nivel") = 0 Or Session("nivel") = 3 Then

        Else
            Try


                '    If DropDownList17.Text <> "--Seleccionar--" Then
                '        Try

                '            'Dim tb As TextBox = divPassenger.FindControl("txtlugar" & numeroRegistro)
                '            'MsgBox(tb.Text)
                '            'Dim tb2 As TextBox = divPassenger.FindControl("txthorario" & numeroRegistro)
                '            'Dim tb3 As TextBox = divPassenger.FindControl("txtalimycant" & numeroRegistro)
                '            'Dim tb4 As TextBox = divPassenger.FindControl("txtvalcalor" & numeroRegistro)
                '            'Dim cmb As DropDownList = divPassenger.FindControl("cmb" & numeroRegistro)
                '            If con.State = ConnectionState.Open Then
                '                con.Close()
                '            End If
                '            con.Open()
                '            da = New SqlDataAdapter("insert into nutricional values(@folio,@exped, @fechamodif,@consultaanterior,@objetivocons,@pesobajo,@pesoalto,@pesopromedio,@alergicoalimento,@intolerantealimento,@alimnogustan,@alimgustan,@impedimentocomidas,@sintomaalimentos,@alimentoscausantes,@alimentosalivian,@actividadfisica,@tiempoacfisica,@tiempocomida,@lugarcomida,@horariocomida,@alimentoycant,@valorcalorico,@talla,@peso,@imc,@circcintura,@circcadera,@porcgrasa,@porcmusculo,@porcagua,@dietacompleta,@motivocompleta,@dietaequilibrada,@carbohidratos,@motivo2dietaeq,@dietavariada,@motivodietavar,@dietaadecuada,@azucares,@motivo2dietaadec,@dietasufic,@motivo1dietasufic,@motivo2dietasufic,@dietainocua,@motivodietainocua,@diagnutric,@objtratamiento,@tratamnutricional,@medico,null,@proteina,@grasa,@irritantes,@condimentos,@alcohol,@grasas)", con)
                '            da.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                '            da.SelectCommand.Parameters.Add("@exped", SqlDbType.Int).Value = Convert.ToInt32(Label6.Text)
                '            da.SelectCommand.Parameters.Add("@fechamodif", SqlDbType.DateTime).Value = Convert.ToDateTime(Label1.Text)
                '            If DropDownList1.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@consultaanterior", SqlDbType.VarChar).Value = TextBox5.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@consultaanterior", SqlDbType.VarChar).Value = "No"
                '            End If
                '            If DropDownList2.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@objetivocons", SqlDbType.VarChar).Value = TextBox6.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@objetivocons", SqlDbType.VarChar).Value = "No"
                '            End If
                '            da.SelectCommand.Parameters.Add("@pesobajo", SqlDbType.VarChar).Value = TextBox7.Text
                '            da.SelectCommand.Parameters.Add("@pesoalto", SqlDbType.VarChar).Value = TextBox8.Text
                '            da.SelectCommand.Parameters.Add("@pesopromedio", SqlDbType.VarChar).Value = TextBox9.Text
                '            If DropDownList3.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@alergicoalimento", SqlDbType.VarChar).Value = TextBox10.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@alergicoalimento", SqlDbType.VarChar).Value = "No"
                '            End If
                '            If DropDownList4.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@intolerantealimento", SqlDbType.VarChar).Value = TextBox11.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@intolerantealimento", SqlDbType.VarChar).Value = "No"
                '            End If
                '            da.SelectCommand.Parameters.Add("@alimnogustan", SqlDbType.VarChar).Value = TextBox12.Text
                '            da.SelectCommand.Parameters.Add("@alimgustan", SqlDbType.VarChar).Value = TextBox13.Text
                '            If DropDownList5.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@impedimentocomidas", SqlDbType.VarChar).Value = TextBox14.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@impedimentocomidas", SqlDbType.VarChar).Value = "No"
                '            End If
                '            da.SelectCommand.Parameters.Add("@sintomaalimentos", SqlDbType.VarChar).Value = TextBox15.Text
                '            da.SelectCommand.Parameters.Add("@alimentoscausantes", SqlDbType.VarChar).Value = TextBox16.Text
                '            da.SelectCommand.Parameters.Add("@alimentosalivian", SqlDbType.VarChar).Value = TextBox17.Text

                '            If DropDownList7.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@actividadfisica", SqlDbType.VarChar).Value = TextBox18.Text
                '                da.SelectCommand.Parameters.Add("@tiempoacfisica", SqlDbType.VarChar).Value = TextBox19.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@actividadfisica", SqlDbType.VarChar).Value = "No"
                '                da.SelectCommand.Parameters.Add("@tiempoacfisica", SqlDbType.VarChar).Value = ""
                '            End If

                '            da.SelectCommand.Parameters.Add("@tiempocomida", SqlDbType.VarChar).Value = DropDownList17.Text
                '            da.SelectCommand.Parameters.Add("@lugarcomida", SqlDbType.VarChar).Value = TextBox38.Text
                '            da.SelectCommand.Parameters.Add("@horariocomida", SqlDbType.VarChar).Value = TextBox39.Text
                '            da.SelectCommand.Parameters.Add("@alimentoycant", SqlDbType.VarChar).Value = TextBox40.Text

                '            da.SelectCommand.Parameters.Add("@valorcalorico", SqlDbType.VarChar).Value = TextBox41.Text

                '            da.SelectCommand.Parameters.Add("@talla", SqlDbType.VarChar).Value = TextBox21.Text
                '            da.SelectCommand.Parameters.Add("@peso", SqlDbType.VarChar).Value = TextBox22.Text

                '            da.SelectCommand.Parameters.Add("@imc", SqlDbType.VarChar).Value = TextBox23.Text
                '            da.SelectCommand.Parameters.Add("@circcintura", SqlDbType.VarChar).Value = TextBox24.Text
                '            da.SelectCommand.Parameters.Add("@circcadera", SqlDbType.VarChar).Value = TextBox25.Text
                '            da.SelectCommand.Parameters.Add("@porcgrasa", SqlDbType.VarChar).Value = TextBox26.Text
                '            da.SelectCommand.Parameters.Add("@porcmusculo", SqlDbType.VarChar).Value = TextBox27.Text
                '            da.SelectCommand.Parameters.Add("@porcagua", SqlDbType.VarChar).Value = TextBox28.Text

                '            If DropDownList8.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietacompleta", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietacompleta", SqlDbType.VarChar).Value = DropDownList8.Text
                '            End If
                '            If DropDownList8.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@motivocompleta", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@motivocompleta", SqlDbType.VarChar).Value = TextBox29.Text
                '            End If
                '            If DropDownList9.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietaequilibrada", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@carbohidratos", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@proteina", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@grasa", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@motivo2dietaeq", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietaequilibrada", SqlDbType.VarChar).Value = DropDownList9.Text

                '                If CheckBox2.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@carbohidratos", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@carbohidratos", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox1.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@proteina", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@proteina", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox3.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@grasa", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@grasa", SqlDbType.Bit).Value = False
                '                End If
                '                da.SelectCommand.Parameters.Add("@motivo2dietaeq", SqlDbType.VarChar).Value = TextBox30.Text
                '            End If
                '            If DropDownList11.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietavariada", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivodietavar", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietavariada", SqlDbType.VarChar).Value = DropDownList11.Text
                '                da.SelectCommand.Parameters.Add("@motivodietavar", SqlDbType.VarChar).Value = TextBox31.Text
                '            End If
                '            If DropDownList12.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietaadecuada", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@grasas", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@azucares", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@irritantes", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@condimientos", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@alcohol", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@motivo2dietaadec", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietaadecuada", SqlDbType.VarChar).Value = DropDownList12.Text
                '                If CheckBox4.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@grasas", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@grasas", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox5.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@azucares", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@azucares", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox6.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@irritantes", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@irritantes", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox7.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@condimentos", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@condimientos", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox8.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@alcohol", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@alcohol", SqlDbType.Bit).Value = False
                '                End If
                '                da.SelectCommand.Parameters.Add("@motivo2dietaadec", SqlDbType.VarChar).Value = TextBox32.Text
                '            End If
                '            If DropDownList14.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietasufic", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivo1dietasufic", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivo2dietasufic", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietasufic", SqlDbType.VarChar).Value = DropDownList14.Text
                '                da.SelectCommand.Parameters.Add("@motivo1dietasufic", SqlDbType.VarChar).Value = DropDownList15.Text
                '                da.SelectCommand.Parameters.Add("@motivo2dietasufic", SqlDbType.VarChar).Value = TextBox33.Text

                '            End If
                '            If DropDownList16.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietainocua", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivodietainocua", SqlDbType.VarChar).Value = TextBox34.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietainocua", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivodietainocua", SqlDbType.VarChar).Value = TextBox34.Text
                '            End If
                '            da.SelectCommand.Parameters.Add("@diagnutric", SqlDbType.VarChar).Value = TextBox35.Text
                '            da.SelectCommand.Parameters.Add("@objtratamiento", SqlDbType.VarChar).Value = TextBox36.Text
                '            da.SelectCommand.Parameters.Add("@tratamnutricional", SqlDbType.VarChar).Value = TextBox37.Text
                '            da.SelectCommand.Parameters.Add("@medico", SqlDbType.VarChar).Value = Label7.Text
                '            da.SelectCommand.ExecuteNonQuery()
                '            con.Close()
                '        Catch ex As Exception
                '            MsgBox(ex.Message)
                '            con.Close()
                '        End Try
                '    End If

                '    If DropDownList18.Text <> "--Seleccionar--" Then
                '        Try

                '            'Dim tb As TextBox = divPassenger.FindControl("txtlugar" & numeroRegistro)
                '            'MsgBox(tb.Text)
                '            'Dim tb2 As TextBox = divPassenger.FindControl("txthorario" & numeroRegistro)
                '            'Dim tb3 As TextBox = divPassenger.FindControl("txtalimycant" & numeroRegistro)
                '            'Dim tb4 As TextBox = divPassenger.FindControl("txtvalcalor" & numeroRegistro)
                '            'Dim cmb As DropDownList = divPassenger.FindControl("cmb" & numeroRegistro)
                '            If con.State = ConnectionState.Open Then
                '                con.Close()
                '            End If
                '            con.Open()
                '            da = New SqlDataAdapter("insert into nutricional values(@folio,@exped, @fechamodif,@consultaanterior,@objetivocons,@pesobajo,@pesoalto,@pesopromedio,@alergicoalimento,@intolerantealimento,@alimnogustan,@alimgustan,@impedimentocomidas,@sintomaalimentos,@alimentoscausantes,@alimentosalivian,@actividadfisica,@tiempoacfisica,@tiempocomida,@lugarcomida,@horariocomida,@alimentoycant,@valorcalorico,@talla,@peso,@imc,@circcintura,@circcadera,@porcgrasa,@porcmusculo,@porcagua,@dietacompleta,@motivocompleta,@dietaequilibrada,@carbohidratos,@motivo2dietaeq,@dietavariada,@motivodietavar,@dietaadecuada,@azucares,@motivo2dietaadec,@dietasufic,@motivo1dietasufic,@motivo2dietasufic,@dietainocua,@motivodietainocua,@diagnutric,@objtratamiento,@tratamnutricional,@medico,null,@proteina,@grasa,@irritantes,@condimentos,@alcohol,@grasas)", con)
                '            da.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                '            da.SelectCommand.Parameters.Add("@exped", SqlDbType.Int).Value = Label6.Text
                '            da.SelectCommand.Parameters.Add("@fechamodif", SqlDbType.DateTime).Value = Convert.ToDateTime(Label1.Text)
                '            If DropDownList1.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@consultaanterior", SqlDbType.VarChar).Value = TextBox5.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@consultaanterior", SqlDbType.VarChar).Value = "No"
                '            End If
                '            If DropDownList2.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@objetivocons", SqlDbType.VarChar).Value = TextBox6.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@objetivocons", SqlDbType.VarChar).Value = "No"
                '            End If
                '            da.SelectCommand.Parameters.Add("@pesobajo", SqlDbType.VarChar).Value = TextBox7.Text
                '            da.SelectCommand.Parameters.Add("@pesoalto", SqlDbType.VarChar).Value = TextBox8.Text
                '            da.SelectCommand.Parameters.Add("@pesopromedio", SqlDbType.VarChar).Value = TextBox9.Text
                '            If DropDownList3.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@alergicoalimento", SqlDbType.VarChar).Value = TextBox10.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@alergicoalimento", SqlDbType.VarChar).Value = "No"
                '            End If
                '            If DropDownList4.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@intolerantealimento", SqlDbType.VarChar).Value = TextBox11.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@intolerantealimento", SqlDbType.VarChar).Value = "No"
                '            End If
                '            da.SelectCommand.Parameters.Add("@alimnogustan", SqlDbType.VarChar).Value = TextBox12.Text
                '            da.SelectCommand.Parameters.Add("@alimgustan", SqlDbType.VarChar).Value = TextBox13.Text
                '            If DropDownList5.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@impedimentocomidas", SqlDbType.VarChar).Value = TextBox14.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@impedimentocomidas", SqlDbType.VarChar).Value = "No"
                '            End If
                '            da.SelectCommand.Parameters.Add("@sintomaalimentos", SqlDbType.VarChar).Value = TextBox15.Text
                '            da.SelectCommand.Parameters.Add("@alimentoscausantes", SqlDbType.VarChar).Value = TextBox16.Text
                '            da.SelectCommand.Parameters.Add("@alimentosalivian", SqlDbType.VarChar).Value = TextBox17.Text

                '            If DropDownList7.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@actividadfisica", SqlDbType.VarChar).Value = TextBox18.Text
                '                da.SelectCommand.Parameters.Add("@tiempoacfisica", SqlDbType.VarChar).Value = TextBox19.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@actividadfisica", SqlDbType.VarChar).Value = "No"
                '                da.SelectCommand.Parameters.Add("@tiempoacfisica", SqlDbType.VarChar).Value = ""
                '            End If

                '            da.SelectCommand.Parameters.Add("@tiempocomida", SqlDbType.VarChar).Value = DropDownList18.Text
                '            da.SelectCommand.Parameters.Add("@lugarcomida", SqlDbType.VarChar).Value = TextBox42.Text
                '            da.SelectCommand.Parameters.Add("@horariocomida", SqlDbType.VarChar).Value = TextBox43.Text
                '            da.SelectCommand.Parameters.Add("@alimentoycant", SqlDbType.VarChar).Value = TextBox44.Text

                '            da.SelectCommand.Parameters.Add("@valorcalorico", SqlDbType.VarChar).Value = TextBox45.Text

                '            da.SelectCommand.Parameters.Add("@talla", SqlDbType.VarChar).Value = TextBox21.Text

                '            da.SelectCommand.Parameters.Add("@peso", SqlDbType.VarChar).Value = TextBox22.Text


                '            da.SelectCommand.Parameters.Add("@imc", SqlDbType.VarChar).Value = TextBox23.Text
                '            da.SelectCommand.Parameters.Add("@circcintura", SqlDbType.VarChar).Value = TextBox24.Text
                '            da.SelectCommand.Parameters.Add("@circcadera", SqlDbType.VarChar).Value = TextBox25.Text

                '            da.SelectCommand.Parameters.Add("@porcgrasa", SqlDbType.VarChar).Value = TextBox26.Text

                '            da.SelectCommand.Parameters.Add("@porcmusculo", SqlDbType.VarChar).Value = TextBox27.Text


                '            da.SelectCommand.Parameters.Add("@porcagua", SqlDbType.VarChar).Value = TextBox28.Text

                '            If DropDownList8.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietacompleta", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietacompleta", SqlDbType.VarChar).Value = DropDownList8.Text
                '            End If
                '            If DropDownList8.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@motivocompleta", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@motivocompleta", SqlDbType.VarChar).Value = TextBox29.Text
                '            End If
                '            If DropDownList9.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietaequilibrada", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@carbohidratos", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@proteina", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@grasa", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@motivo2dietaeq", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietaequilibrada", SqlDbType.VarChar).Value = DropDownList9.Text

                '                If CheckBox2.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@carbohidratos", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@carbohidratos", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox1.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@proteina", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@proteina", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox3.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@grasa", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@grasa", SqlDbType.Bit).Value = False
                '                End If
                '                da.SelectCommand.Parameters.Add("@motivo2dietaeq", SqlDbType.VarChar).Value = TextBox30.Text
                '            End If
                '            If DropDownList11.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietavariada", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivodietavar", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietavariada", SqlDbType.VarChar).Value = DropDownList11.Text
                '                da.SelectCommand.Parameters.Add("@motivodietavar", SqlDbType.VarChar).Value = TextBox31.Text
                '            End If
                '            If DropDownList12.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietaadecuada", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@grasas", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@azucares", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@irritantes", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@condimientos", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@alcohol", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@motivo2dietaadec", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietaadecuada", SqlDbType.VarChar).Value = DropDownList12.Text
                '                If CheckBox4.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@grasas", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@grasas", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox5.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@azucares", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@azucares", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox6.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@irritantes", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@irritantes", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox7.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@condimentos", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@condimientos", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox8.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@alcohol", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@alcohol", SqlDbType.Bit).Value = False
                '                End If
                '                da.SelectCommand.Parameters.Add("@motivo2dietaadec", SqlDbType.VarChar).Value = TextBox32.Text
                '            End If
                '            If DropDownList14.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietasufic", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivo1dietasufic", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivo2dietasufic", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietasufic", SqlDbType.VarChar).Value = DropDownList14.Text
                '                da.SelectCommand.Parameters.Add("@motivo1dietasufic", SqlDbType.VarChar).Value = DropDownList15.Text
                '                da.SelectCommand.Parameters.Add("@motivo2dietasufic", SqlDbType.VarChar).Value = TextBox33.Text

                '            End If
                '            If DropDownList16.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietainocua", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivodietainocua", SqlDbType.VarChar).Value = TextBox34.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietainocua", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivodietainocua", SqlDbType.VarChar).Value = TextBox34.Text
                '            End If
                '            da.SelectCommand.Parameters.Add("@diagnutric", SqlDbType.VarChar).Value = TextBox35.Text
                '            da.SelectCommand.Parameters.Add("@objtratamiento", SqlDbType.VarChar).Value = TextBox36.Text
                '            da.SelectCommand.Parameters.Add("@tratamnutricional", SqlDbType.VarChar).Value = TextBox37.Text
                '            da.SelectCommand.Parameters.Add("@medico", SqlDbType.VarChar).Value = Label7.Text
                '            da.SelectCommand.ExecuteNonQuery()
                '            con.Close()
                '        Catch ex As Exception
                '            MsgBox(ex.Message)
                '            con.Close()
                '        End Try
                '    End If

                '    If DropDownList19.Text <> "--Seleccionar--" Then
                '        Try

                '            'Dim tb As TextBox = divPassenger.FindControl("txtlugar" & numeroRegistro)
                '            'MsgBox(tb.Text)
                '            'Dim tb2 As TextBox = divPassenger.FindControl("txthorario" & numeroRegistro)
                '            'Dim tb3 As TextBox = divPassenger.FindControl("txtalimycant" & numeroRegistro)
                '            'Dim tb4 As TextBox = divPassenger.FindControl("txtvalcalor" & numeroRegistro)
                '            'Dim cmb As DropDownList = divPassenger.FindControl("cmb" & numeroRegistro)
                '            If con.State = ConnectionState.Open Then
                '                con.Close()
                '            End If
                '            con.Open()
                '            da = New SqlDataAdapter("insert into nutricional values(@folio,@exped, @fechamodif,@consultaanterior,@objetivocons,@pesobajo,@pesoalto,@pesopromedio,@alergicoalimento,@intolerantealimento,@alimnogustan,@alimgustan,@impedimentocomidas,@sintomaalimentos,@alimentoscausantes,@alimentosalivian,@actividadfisica,@tiempoacfisica,@tiempocomida,@lugarcomida,@horariocomida,@alimentoycant,@valorcalorico,@talla,@peso,@imc,@circcintura,@circcadera,@porcgrasa,@porcmusculo,@porcagua,@dietacompleta,@motivocompleta,@dietaequilibrada,@carbohidratos,@motivo2dietaeq,@dietavariada,@motivodietavar,@dietaadecuada,@azucares,@motivo2dietaadec,@dietasufic,@motivo1dietasufic,@motivo2dietasufic,@dietainocua,@motivodietainocua,@diagnutric,@objtratamiento,@tratamnutricional,@medico,null,@proteina,@grasa,@irritantes,@condimentos,@alcohol,@grasas)", con)
                '            da.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                '            da.SelectCommand.Parameters.Add("@exped", SqlDbType.Int).Value = Label6.Text
                '            da.SelectCommand.Parameters.Add("@fechamodif", SqlDbType.DateTime).Value = Convert.ToDateTime(Label1.Text)
                '            If DropDownList1.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@consultaanterior", SqlDbType.VarChar).Value = TextBox5.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@consultaanterior", SqlDbType.VarChar).Value = "No"
                '            End If
                '            If DropDownList2.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@objetivocons", SqlDbType.VarChar).Value = TextBox6.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@objetivocons", SqlDbType.VarChar).Value = "No"
                '            End If
                '            da.SelectCommand.Parameters.Add("@pesobajo", SqlDbType.VarChar).Value = TextBox7.Text
                '            da.SelectCommand.Parameters.Add("@pesoalto", SqlDbType.VarChar).Value = TextBox8.Text
                '            da.SelectCommand.Parameters.Add("@pesopromedio", SqlDbType.VarChar).Value = TextBox9.Text
                '            If DropDownList3.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@alergicoalimento", SqlDbType.VarChar).Value = TextBox10.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@alergicoalimento", SqlDbType.VarChar).Value = "No"
                '            End If
                '            If DropDownList4.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@intolerantealimento", SqlDbType.VarChar).Value = TextBox11.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@intolerantealimento", SqlDbType.VarChar).Value = "No"
                '            End If
                '            da.SelectCommand.Parameters.Add("@alimnogustan", SqlDbType.VarChar).Value = TextBox12.Text
                '            da.SelectCommand.Parameters.Add("@alimgustan", SqlDbType.VarChar).Value = TextBox13.Text
                '            If DropDownList5.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@impedimentocomidas", SqlDbType.VarChar).Value = TextBox14.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@impedimentocomidas", SqlDbType.VarChar).Value = "No"
                '            End If
                '            da.SelectCommand.Parameters.Add("@sintomaalimentos", SqlDbType.VarChar).Value = TextBox15.Text
                '            da.SelectCommand.Parameters.Add("@alimentoscausantes", SqlDbType.VarChar).Value = TextBox16.Text
                '            da.SelectCommand.Parameters.Add("@alimentosalivian", SqlDbType.VarChar).Value = TextBox17.Text

                '            If DropDownList7.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@actividadfisica", SqlDbType.VarChar).Value = TextBox18.Text
                '                da.SelectCommand.Parameters.Add("@tiempoacfisica", SqlDbType.VarChar).Value = TextBox19.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@actividadfisica", SqlDbType.VarChar).Value = "No"
                '                da.SelectCommand.Parameters.Add("@tiempoacfisica", SqlDbType.VarChar).Value = ""
                '            End If

                '            da.SelectCommand.Parameters.Add("@tiempocomida", SqlDbType.VarChar).Value = DropDownList19.Text
                '            da.SelectCommand.Parameters.Add("@lugarcomida", SqlDbType.VarChar).Value = TextBox46.Text
                '            da.SelectCommand.Parameters.Add("@horariocomida", SqlDbType.VarChar).Value = TextBox47.Text
                '            da.SelectCommand.Parameters.Add("@alimentoycant", SqlDbType.VarChar).Value = TextBox48.Text

                '            da.SelectCommand.Parameters.Add("@valorcalorico", SqlDbType.VarChar).Value = TextBox48.Text

                '            da.SelectCommand.Parameters.Add("@talla", SqlDbType.VarChar).Value = TextBox21.Text

                '            da.SelectCommand.Parameters.Add("@peso", SqlDbType.VarChar).Value = TextBox22.Text


                '            da.SelectCommand.Parameters.Add("@imc", SqlDbType.VarChar).Value = TextBox23.Text
                '            da.SelectCommand.Parameters.Add("@circcintura", SqlDbType.VarChar).Value = TextBox24.Text
                '            da.SelectCommand.Parameters.Add("@circcadera", SqlDbType.VarChar).Value = TextBox25.Text

                '            da.SelectCommand.Parameters.Add("@porcgrasa", SqlDbType.VarChar).Value = TextBox26.Text

                '            da.SelectCommand.Parameters.Add("@porcmusculo", SqlDbType.VarChar).Value = TextBox27.Text

                '            da.SelectCommand.Parameters.Add("@porcagua", SqlDbType.VarChar).Value = TextBox28.Text

                '            If DropDownList8.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietacompleta", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietacompleta", SqlDbType.VarChar).Value = DropDownList8.Text
                '            End If
                '            If DropDownList8.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@motivocompleta", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@motivocompleta", SqlDbType.VarChar).Value = TextBox29.Text
                '            End If
                '            If DropDownList9.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietaequilibrada", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@carbohidratos", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@proteina", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@grasa", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@motivo2dietaeq", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietaequilibrada", SqlDbType.VarChar).Value = DropDownList9.Text

                '                If CheckBox2.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@carbohidratos", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@carbohidratos", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox1.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@proteina", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@proteina", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox3.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@grasa", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@grasa", SqlDbType.Bit).Value = False
                '                End If
                '                da.SelectCommand.Parameters.Add("@motivo2dietaeq", SqlDbType.VarChar).Value = TextBox30.Text
                '            End If
                '            If DropDownList11.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietavariada", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivodietavar", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietavariada", SqlDbType.VarChar).Value = DropDownList11.Text
                '                da.SelectCommand.Parameters.Add("@motivodietavar", SqlDbType.VarChar).Value = TextBox31.Text
                '            End If
                '            If DropDownList12.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietaadecuada", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@grasas", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@azucares", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@irritantes", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@condimientos", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@alcohol", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@motivo2dietaadec", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietaadecuada", SqlDbType.VarChar).Value = DropDownList12.Text
                '                If CheckBox4.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@grasas", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@grasas", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox5.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@azucares", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@azucares", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox6.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@irritantes", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@irritantes", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox7.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@condimentos", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@condimientos", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox8.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@alcohol", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@alcohol", SqlDbType.Bit).Value = False
                '                End If
                '                da.SelectCommand.Parameters.Add("@motivo2dietaadec", SqlDbType.VarChar).Value = TextBox32.Text
                '            End If
                '            If DropDownList14.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietasufic", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivo1dietasufic", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivo2dietasufic", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietasufic", SqlDbType.VarChar).Value = DropDownList14.Text
                '                da.SelectCommand.Parameters.Add("@motivo1dietasufic", SqlDbType.VarChar).Value = DropDownList15.Text
                '                da.SelectCommand.Parameters.Add("@motivo2dietasufic", SqlDbType.VarChar).Value = TextBox33.Text

                '            End If
                '            If DropDownList16.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietainocua", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivodietainocua", SqlDbType.VarChar).Value = TextBox34.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietainocua", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivodietainocua", SqlDbType.VarChar).Value = TextBox34.Text
                '            End If
                '            da.SelectCommand.Parameters.Add("@diagnutric", SqlDbType.VarChar).Value = TextBox35.Text
                '            da.SelectCommand.Parameters.Add("@objtratamiento", SqlDbType.VarChar).Value = TextBox36.Text
                '            da.SelectCommand.Parameters.Add("@tratamnutricional", SqlDbType.VarChar).Value = TextBox37.Text
                '            da.SelectCommand.Parameters.Add("@medico", SqlDbType.VarChar).Value = Label7.Text
                '            da.SelectCommand.ExecuteNonQuery()
                '            con.Close()
                '        Catch ex As Exception
                '            MsgBox(ex.Message)
                '            con.Close()
                '        End Try
                '    End If

                '    If DropDownList20.Text <> "--Seleccionar--" Then
                '        Try

                '            'Dim tb As TextBox = divPassenger.FindControl("txtlugar" & numeroRegistro)
                '            'MsgBox(tb.Text)
                '            'Dim tb2 As TextBox = divPassenger.FindControl("txthorario" & numeroRegistro)
                '            'Dim tb3 As TextBox = divPassenger.FindControl("txtalimycant" & numeroRegistro)
                '            'Dim tb4 As TextBox = divPassenger.FindControl("txtvalcalor" & numeroRegistro)
                '            'Dim cmb As DropDownList = divPassenger.FindControl("cmb" & numeroRegistro)
                '            If con.State = ConnectionState.Open Then
                '                con.Close()
                '            End If
                '            con.Open()
                '            da = New SqlDataAdapter("insert into nutricional values(@folio,@exped, @fechamodif,@consultaanterior,@objetivocons,@pesobajo,@pesoalto,@pesopromedio,@alergicoalimento,@intolerantealimento,@alimnogustan,@alimgustan,@impedimentocomidas,@sintomaalimentos,@alimentoscausantes,@alimentosalivian,@actividadfisica,@tiempoacfisica,@tiempocomida,@lugarcomida,@horariocomida,@alimentoycant,@valorcalorico,@talla,@peso,@imc,@circcintura,@circcadera,@porcgrasa,@porcmusculo,@porcagua,@dietacompleta,@motivocompleta,@dietaequilibrada,@carbohidratos,@motivo2dietaeq,@dietavariada,@motivodietavar,@dietaadecuada,@azucares,@motivo2dietaadec,@dietasufic,@motivo1dietasufic,@motivo2dietasufic,@dietainocua,@motivodietainocua,@diagnutric,@objtratamiento,@tratamnutricional,@medico,null,@proteina,@grasa,@irritantes,@condimentos,@alcohol,@grasas)", con)
                '            da.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                '            da.SelectCommand.Parameters.Add("@exped", SqlDbType.Int).Value = Label6.Text
                '            da.SelectCommand.Parameters.Add("@fechamodif", SqlDbType.DateTime).Value = Convert.ToDateTime(Label1.Text)
                '            If DropDownList1.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@consultaanterior", SqlDbType.VarChar).Value = TextBox5.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@consultaanterior", SqlDbType.VarChar).Value = "No"
                '            End If
                '            If DropDownList2.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@objetivocons", SqlDbType.VarChar).Value = TextBox6.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@objetivocons", SqlDbType.VarChar).Value = "No"
                '            End If
                '            da.SelectCommand.Parameters.Add("@pesobajo", SqlDbType.VarChar).Value = TextBox7.Text
                '            da.SelectCommand.Parameters.Add("@pesoalto", SqlDbType.VarChar).Value = TextBox8.Text
                '            da.SelectCommand.Parameters.Add("@pesopromedio", SqlDbType.VarChar).Value = TextBox9.Text
                '            If DropDownList3.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@alergicoalimento", SqlDbType.VarChar).Value = TextBox10.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@alergicoalimento", SqlDbType.VarChar).Value = "No"
                '            End If
                '            If DropDownList4.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@intolerantealimento", SqlDbType.VarChar).Value = TextBox11.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@intolerantealimento", SqlDbType.VarChar).Value = "No"
                '            End If
                '            da.SelectCommand.Parameters.Add("@alimnogustan", SqlDbType.VarChar).Value = TextBox12.Text
                '            da.SelectCommand.Parameters.Add("@alimgustan", SqlDbType.VarChar).Value = TextBox13.Text
                '            If DropDownList5.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@impedimentocomidas", SqlDbType.VarChar).Value = TextBox14.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@impedimentocomidas", SqlDbType.VarChar).Value = "No"
                '            End If
                '            da.SelectCommand.Parameters.Add("@sintomaalimentos", SqlDbType.VarChar).Value = TextBox15.Text
                '            da.SelectCommand.Parameters.Add("@alimentoscausantes", SqlDbType.VarChar).Value = TextBox16.Text
                '            da.SelectCommand.Parameters.Add("@alimentosalivian", SqlDbType.VarChar).Value = TextBox17.Text

                '            If DropDownList7.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@actividadfisica", SqlDbType.VarChar).Value = TextBox18.Text
                '                da.SelectCommand.Parameters.Add("@tiempoacfisica", SqlDbType.VarChar).Value = TextBox19.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@actividadfisica", SqlDbType.VarChar).Value = "No"
                '                da.SelectCommand.Parameters.Add("@tiempoacfisica", SqlDbType.VarChar).Value = ""
                '            End If

                '            da.SelectCommand.Parameters.Add("@tiempocomida", SqlDbType.VarChar).Value = DropDownList20.Text
                '            da.SelectCommand.Parameters.Add("@lugarcomida", SqlDbType.VarChar).Value = TextBox50.Text
                '            da.SelectCommand.Parameters.Add("@horariocomida", SqlDbType.VarChar).Value = TextBox51.Text
                '            da.SelectCommand.Parameters.Add("@alimentoycant", SqlDbType.VarChar).Value = TextBox52.Text

                '            da.SelectCommand.Parameters.Add("@valorcalorico", SqlDbType.VarChar).Value = TextBox53.Text


                '            da.SelectCommand.Parameters.Add("@talla", SqlDbType.VarChar).Value = TextBox21.Text


                '            da.SelectCommand.Parameters.Add("@peso", SqlDbType.VarChar).Value = TextBox22.Text


                '            da.SelectCommand.Parameters.Add("@imc", SqlDbType.VarChar).Value = TextBox23.Text
                '            da.SelectCommand.Parameters.Add("@circcintura", SqlDbType.VarChar).Value = TextBox24.Text
                '            da.SelectCommand.Parameters.Add("@circcadera", SqlDbType.VarChar).Value = TextBox25.Text

                '            da.SelectCommand.Parameters.Add("@porcgrasa", SqlDbType.VarChar).Value = TextBox26.Text

                '            da.SelectCommand.Parameters.Add("@porcmusculo", SqlDbType.VarChar).Value = TextBox27.Text

                '            da.SelectCommand.Parameters.Add("@porcagua", SqlDbType.VarChar).Value = TextBox28.Text

                '            da.SelectCommand.Parameters.Add("@dietacompleta", SqlDbType.VarChar).Value = DropDownList8.Text

                '            da.SelectCommand.Parameters.Add("@motivocompleta", SqlDbType.VarChar).Value = TextBox29.Text
                '            If DropDownList9.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietaequilibrada", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@carbohidratos", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@proteina", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@grasa", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@motivo2dietaeq", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietaequilibrada", SqlDbType.VarChar).Value = DropDownList9.Text

                '                If CheckBox2.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@carbohidratos", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@carbohidratos", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox1.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@proteina", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@proteina", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox3.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@grasa", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@grasa", SqlDbType.Bit).Value = False
                '                End If
                '                da.SelectCommand.Parameters.Add("@motivo2dietaeq", SqlDbType.VarChar).Value = TextBox30.Text
                '            End If
                '            If DropDownList11.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietavariada", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivodietavar", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietavariada", SqlDbType.VarChar).Value = DropDownList11.Text
                '                da.SelectCommand.Parameters.Add("@motivodietavar", SqlDbType.VarChar).Value = TextBox31.Text
                '            End If
                '            If DropDownList12.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietaadecuada", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@grasas", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@azucares", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@irritantes", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@condimientos", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@alcohol", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@motivo2dietaadec", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietaadecuada", SqlDbType.VarChar).Value = DropDownList12.Text
                '                If CheckBox4.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@grasas", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@grasas", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox5.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@azucares", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@azucares", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox6.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@irritantes", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@irritantes", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox7.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@condimentos", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@condimientos", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox8.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@alcohol", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@alcohol", SqlDbType.Bit).Value = False
                '                End If
                '                da.SelectCommand.Parameters.Add("@motivo2dietaadec", SqlDbType.VarChar).Value = TextBox32.Text
                '            End If
                '            If DropDownList14.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietasufic", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivo1dietasufic", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivo2dietasufic", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietasufic", SqlDbType.VarChar).Value = DropDownList14.Text
                '                da.SelectCommand.Parameters.Add("@motivo1dietasufic", SqlDbType.VarChar).Value = DropDownList15.Text
                '                da.SelectCommand.Parameters.Add("@motivo2dietasufic", SqlDbType.VarChar).Value = TextBox33.Text

                '            End If
                '            If DropDownList16.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietainocua", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivodietainocua", SqlDbType.VarChar).Value = TextBox34.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietainocua", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivodietainocua", SqlDbType.VarChar).Value = TextBox34.Text
                '            End If
                '            da.SelectCommand.Parameters.Add("@diagnutric", SqlDbType.VarChar).Value = TextBox35.Text
                '            da.SelectCommand.Parameters.Add("@objtratamiento", SqlDbType.VarChar).Value = TextBox36.Text
                '            da.SelectCommand.Parameters.Add("@tratamnutricional", SqlDbType.VarChar).Value = TextBox37.Text
                '            da.SelectCommand.Parameters.Add("@medico", SqlDbType.VarChar).Value = Label7.Text
                '            da.SelectCommand.ExecuteNonQuery()
                '            con.Close()
                '        Catch ex As Exception
                '            MsgBox(ex.Message)
                '            con.Close()
                '        End Try
                '    End If

                '    If DropDownList21.Text <> "--Seleccionar--" Then
                '        Try

                '            'Dim tb As TextBox = divPassenger.FindControl("txtlugar" & numeroRegistro)
                '            'MsgBox(tb.Text)
                '            'Dim tb2 As TextBox = divPassenger.FindControl("txthorario" & numeroRegistro)
                '            'Dim tb3 As TextBox = divPassenger.FindControl("txtalimycant" & numeroRegistro)
                '            'Dim tb4 As TextBox = divPassenger.FindControl("txtvalcalor" & numeroRegistro)
                '            'Dim cmb As DropDownList = divPassenger.FindControl("cmb" & numeroRegistro)
                '            If con.State = ConnectionState.Open Then
                '                con.Close()
                '            End If
                '            con.Open()
                '            da = New SqlDataAdapter("insert into nutricional values(@folio,@exped, @fechamodif,@consultaanterior,@objetivocons,@pesobajo,@pesoalto,@pesopromedio,@alergicoalimento,@intolerantealimento,@alimnogustan,@alimgustan,@impedimentocomidas,@sintomaalimentos,@alimentoscausantes,@alimentosalivian,@actividadfisica,@tiempoacfisica,@tiempocomida,@lugarcomida,@horariocomida,@alimentoycant,@valorcalorico,@talla,@peso,@imc,@circcintura,@circcadera,@porcgrasa,@porcmusculo,@porcagua,@dietacompleta,@motivocompleta,@dietaequilibrada,@carbohidratos,@motivo2dietaeq,@dietavariada,@motivodietavar,@dietaadecuada,@azucares,@motivo2dietaadec,@dietasufic,@motivo1dietasufic,@motivo2dietasufic,@dietainocua,@motivodietainocua,@diagnutric,@objtratamiento,@tratamnutricional,@medico,null,@proteina,@grasa,@irritantes,@condimentos,@alcohol,@grasas)", con)
                '            da.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                '            da.SelectCommand.Parameters.Add("@exped", SqlDbType.Int).Value = Label6.Text
                '            da.SelectCommand.Parameters.Add("@fechamodif", SqlDbType.DateTime).Value = Convert.ToDateTime(Label1.Text)
                '            If DropDownList1.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@consultaanterior", SqlDbType.VarChar).Value = TextBox5.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@consultaanterior", SqlDbType.VarChar).Value = "No"
                '            End If
                '            If DropDownList2.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@objetivocons", SqlDbType.VarChar).Value = TextBox6.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@objetivocons", SqlDbType.VarChar).Value = "No"
                '            End If
                '            da.SelectCommand.Parameters.Add("@pesobajo", SqlDbType.VarChar).Value = TextBox7.Text
                '            da.SelectCommand.Parameters.Add("@pesoalto", SqlDbType.VarChar).Value = TextBox8.Text
                '            da.SelectCommand.Parameters.Add("@pesopromedio", SqlDbType.VarChar).Value = TextBox9.Text
                '            If DropDownList3.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@alergicoalimento", SqlDbType.VarChar).Value = TextBox10.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@alergicoalimento", SqlDbType.VarChar).Value = "No"
                '            End If
                '            If DropDownList4.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@intolerantealimento", SqlDbType.VarChar).Value = TextBox11.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@intolerantealimento", SqlDbType.VarChar).Value = "No"
                '            End If
                '            da.SelectCommand.Parameters.Add("@alimnogustan", SqlDbType.VarChar).Value = TextBox12.Text
                '            da.SelectCommand.Parameters.Add("@alimgustan", SqlDbType.VarChar).Value = TextBox13.Text
                '            If DropDownList5.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@impedimentocomidas", SqlDbType.VarChar).Value = TextBox14.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@impedimentocomidas", SqlDbType.VarChar).Value = "No"
                '            End If
                '            da.SelectCommand.Parameters.Add("@sintomaalimentos", SqlDbType.VarChar).Value = TextBox15.Text
                '            da.SelectCommand.Parameters.Add("@alimentoscausantes", SqlDbType.VarChar).Value = TextBox16.Text
                '            da.SelectCommand.Parameters.Add("@alimentosalivian", SqlDbType.VarChar).Value = TextBox17.Text

                '            If DropDownList7.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@actividadfisica", SqlDbType.VarChar).Value = TextBox18.Text
                '                da.SelectCommand.Parameters.Add("@tiempoacfisica", SqlDbType.VarChar).Value = TextBox19.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@actividadfisica", SqlDbType.VarChar).Value = "No"
                '                da.SelectCommand.Parameters.Add("@tiempoacfisica", SqlDbType.VarChar).Value = ""
                '            End If

                '            da.SelectCommand.Parameters.Add("@tiempocomida", SqlDbType.VarChar).Value = DropDownList21.Text
                '            da.SelectCommand.Parameters.Add("@lugarcomida", SqlDbType.VarChar).Value = TextBox54.Text
                '            da.SelectCommand.Parameters.Add("@horariocomida", SqlDbType.VarChar).Value = TextBox55.Text
                '            da.SelectCommand.Parameters.Add("@alimentoycant", SqlDbType.VarChar).Value = TextBox56.Text

                '            da.SelectCommand.Parameters.Add("@valorcalorico", SqlDbType.VarChar).Value = TextBox57.Text

                '            da.SelectCommand.Parameters.Add("@talla", SqlDbType.VarChar).Value = TextBox21.Text

                '            da.SelectCommand.Parameters.Add("@peso", SqlDbType.VarChar).Value = TextBox22.Text

                '            da.SelectCommand.Parameters.Add("@imc", SqlDbType.VarChar).Value = TextBox23.Text
                '            da.SelectCommand.Parameters.Add("@circcintura", SqlDbType.VarChar).Value = TextBox24.Text
                '            da.SelectCommand.Parameters.Add("@circcadera", SqlDbType.VarChar).Value = TextBox25.Text

                '            da.SelectCommand.Parameters.Add("@porcgrasa", SqlDbType.VarChar).Value = TextBox26.Text

                '            da.SelectCommand.Parameters.Add("@porcmusculo", SqlDbType.VarChar).Value = TextBox27.Text

                '            da.SelectCommand.Parameters.Add("@porcagua", SqlDbType.VarChar).Value = TextBox28.Text
                '            If DropDownList8.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietacompleta", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietacompleta", SqlDbType.VarChar).Value = DropDownList8.Text
                '            End If
                '            If DropDownList8.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@motivocompleta", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@motivocompleta", SqlDbType.VarChar).Value = TextBox29.Text
                '            End If
                '            If DropDownList9.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietaequilibrada", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@carbohidratos", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@proteina", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@grasa", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@motivo2dietaeq", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietaequilibrada", SqlDbType.VarChar).Value = DropDownList9.Text

                '                If CheckBox2.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@carbohidratos", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@carbohidratos", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox1.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@proteina", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@proteina", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox3.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@grasa", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@grasa", SqlDbType.Bit).Value = False
                '                End If
                '                da.SelectCommand.Parameters.Add("@motivo2dietaeq", SqlDbType.VarChar).Value = TextBox30.Text
                '            End If
                '            If DropDownList11.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietavariada", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivodietavar", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietavariada", SqlDbType.VarChar).Value = DropDownList11.Text
                '                da.SelectCommand.Parameters.Add("@motivodietavar", SqlDbType.VarChar).Value = TextBox31.Text
                '            End If
                '            If DropDownList12.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietaadecuada", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@grasas", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@azucares", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@irritantes", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@condimientos", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@alcohol", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@motivo2dietaadec", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietaadecuada", SqlDbType.VarChar).Value = DropDownList12.Text
                '                If CheckBox4.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@grasas", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@grasas", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox5.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@azucares", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@azucares", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox6.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@irritantes", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@irritantes", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox7.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@condimentos", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@condimientos", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox8.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@alcohol", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@alcohol", SqlDbType.Bit).Value = False
                '                End If
                '                da.SelectCommand.Parameters.Add("@motivo2dietaadec", SqlDbType.VarChar).Value = TextBox32.Text
                '            End If
                '            If DropDownList14.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietasufic", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivo1dietasufic", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivo2dietasufic", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietasufic", SqlDbType.VarChar).Value = DropDownList14.Text
                '                da.SelectCommand.Parameters.Add("@motivo1dietasufic", SqlDbType.VarChar).Value = DropDownList15.Text
                '                da.SelectCommand.Parameters.Add("@motivo2dietasufic", SqlDbType.VarChar).Value = TextBox33.Text

                '            End If
                '            If DropDownList16.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietainocua", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivodietainocua", SqlDbType.VarChar).Value = TextBox34.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietainocua", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivodietainocua", SqlDbType.VarChar).Value = TextBox34.Text
                '            End If
                '            da.SelectCommand.Parameters.Add("@diagnutric", SqlDbType.VarChar).Value = TextBox35.Text
                '            da.SelectCommand.Parameters.Add("@objtratamiento", SqlDbType.VarChar).Value = TextBox36.Text
                '            da.SelectCommand.Parameters.Add("@tratamnutricional", SqlDbType.VarChar).Value = TextBox37.Text
                '            da.SelectCommand.Parameters.Add("@medico", SqlDbType.VarChar).Value = Label7.Text
                '            da.SelectCommand.ExecuteNonQuery()
                '            con.Close()
                '        Catch ex As Exception
                '            MsgBox(ex.Message)
                '            con.Close()
                '        End Try
                '    End If

                '    If DropDownList22.Text <> "--Seleccionar--" Then
                '        Try

                '            'Dim tb As TextBox = divPassenger.FindControl("txtlugar" & numeroRegistro)
                '            'MsgBox(tb.Text)
                '            'Dim tb2 As TextBox = divPassenger.FindControl("txthorario" & numeroRegistro)
                '            'Dim tb3 As TextBox = divPassenger.FindControl("txtalimycant" & numeroRegistro)
                '            'Dim tb4 As TextBox = divPassenger.FindControl("txtvalcalor" & numeroRegistro)
                '            'Dim cmb As DropDownList = divPassenger.FindControl("cmb" & numeroRegistro)
                '            If con.State = ConnectionState.Open Then
                '                con.Close()
                '            End If
                '            con.Open()
                '            da = New SqlDataAdapter("insert into nutricional values(@folio,@exped, @fechamodif,@consultaanterior,@objetivocons,@pesobajo,@pesoalto,@pesopromedio,@alergicoalimento,@intolerantealimento,@alimnogustan,@alimgustan,@impedimentocomidas,@sintomaalimentos,@alimentoscausantes,@alimentosalivian,@actividadfisica,@tiempoacfisica,@tiempocomida,@lugarcomida,@horariocomida,@alimentoycant,@valorcalorico,@talla,@peso,@imc,@circcintura,@circcadera,@porcgrasa,@porcmusculo,@porcagua,@dietacompleta,@motivocompleta,@dietaequilibrada,@carbohidratos,@motivo2dietaeq,@dietavariada,@motivodietavar,@dietaadecuada,@azucares,@motivo2dietaadec,@dietasufic,@motivo1dietasufic,@motivo2dietasufic,@dietainocua,@motivodietainocua,@diagnutric,@objtratamiento,@tratamnutricional,@medico,null,@proteina,@grasa,@irritantes,@condimentos,@alcohol,@grasas)", con)
                '            da.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                '            da.SelectCommand.Parameters.Add("@exped", SqlDbType.Int).Value = Label6.Text
                '            da.SelectCommand.Parameters.Add("@fechamodif", SqlDbType.DateTime).Value = Convert.ToDateTime(Label1.Text)
                '            If DropDownList1.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@consultaanterior", SqlDbType.VarChar).Value = TextBox5.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@consultaanterior", SqlDbType.VarChar).Value = "No"
                '            End If
                '            If DropDownList2.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@objetivocons", SqlDbType.VarChar).Value = TextBox6.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@objetivocons", SqlDbType.VarChar).Value = "No"
                '            End If
                '            da.SelectCommand.Parameters.Add("@pesobajo", SqlDbType.VarChar).Value = TextBox7.Text
                '            da.SelectCommand.Parameters.Add("@pesoalto", SqlDbType.VarChar).Value = TextBox8.Text
                '            da.SelectCommand.Parameters.Add("@pesopromedio", SqlDbType.VarChar).Value = TextBox9.Text
                '            If DropDownList3.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@alergicoalimento", SqlDbType.VarChar).Value = TextBox10.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@alergicoalimento", SqlDbType.VarChar).Value = "No"
                '            End If
                '            If DropDownList4.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@intolerantealimento", SqlDbType.VarChar).Value = TextBox11.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@intolerantealimento", SqlDbType.VarChar).Value = "No"
                '            End If
                '            da.SelectCommand.Parameters.Add("@alimnogustan", SqlDbType.VarChar).Value = TextBox12.Text
                '            da.SelectCommand.Parameters.Add("@alimgustan", SqlDbType.VarChar).Value = TextBox13.Text
                '            If DropDownList5.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@impedimentocomidas", SqlDbType.VarChar).Value = TextBox14.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@impedimentocomidas", SqlDbType.VarChar).Value = "No"
                '            End If
                '            da.SelectCommand.Parameters.Add("@sintomaalimentos", SqlDbType.VarChar).Value = TextBox15.Text
                '            da.SelectCommand.Parameters.Add("@alimentoscausantes", SqlDbType.VarChar).Value = TextBox16.Text
                '            da.SelectCommand.Parameters.Add("@alimentosalivian", SqlDbType.VarChar).Value = TextBox17.Text

                '            If DropDownList7.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@actividadfisica", SqlDbType.VarChar).Value = TextBox18.Text
                '                da.SelectCommand.Parameters.Add("@tiempoacfisica", SqlDbType.VarChar).Value = TextBox19.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@actividadfisica", SqlDbType.VarChar).Value = "No"
                '                da.SelectCommand.Parameters.Add("@tiempoacfisica", SqlDbType.VarChar).Value = ""
                '            End If

                '            da.SelectCommand.Parameters.Add("@tiempocomida", SqlDbType.VarChar).Value = DropDownList22.Text
                '            da.SelectCommand.Parameters.Add("@lugarcomida", SqlDbType.VarChar).Value = TextBox58.Text
                '            da.SelectCommand.Parameters.Add("@horariocomida", SqlDbType.VarChar).Value = TextBox59.Text
                '            da.SelectCommand.Parameters.Add("@alimentoycant", SqlDbType.VarChar).Value = TextBox60.Text

                '            da.SelectCommand.Parameters.Add("@valorcalorico", SqlDbType.VarChar).Value = TextBox61.Text

                '            da.SelectCommand.Parameters.Add("@talla", SqlDbType.VarChar).Value = TextBox21.Text

                '            da.SelectCommand.Parameters.Add("@peso", SqlDbType.VarChar).Value = TextBox22.Text

                '            da.SelectCommand.Parameters.Add("@imc", SqlDbType.VarChar).Value = TextBox23.Text
                '            da.SelectCommand.Parameters.Add("@circcintura", SqlDbType.VarChar).Value = TextBox24.Text
                '            da.SelectCommand.Parameters.Add("@circcadera", SqlDbType.VarChar).Value = TextBox25.Text

                '            da.SelectCommand.Parameters.Add("@porcgrasa", SqlDbType.VarChar).Value = TextBox26.Text

                '            da.SelectCommand.Parameters.Add("@porcmusculo", SqlDbType.VarChar).Value = TextBox27.Text

                '            da.SelectCommand.Parameters.Add("@porcagua", SqlDbType.VarChar).Value = TextBox28.Text

                '            da.SelectCommand.Parameters.Add("@dietacompleta", SqlDbType.VarChar).Value = DropDownList8.Text

                '            If DropDownList8.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@motivocompleta", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@motivocompleta", SqlDbType.VarChar).Value = TextBox29.Text
                '            End If
                '            If DropDownList9.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietaequilibrada", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@carbohidratos", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@proteina", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@grasa", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@motivo2dietaeq", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietaequilibrada", SqlDbType.VarChar).Value = DropDownList9.Text
                '                If CheckBox2.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@carbohidratos", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@carbohidratos", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox1.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@proteina", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@proteina", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox3.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@grasa", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@grasa", SqlDbType.Bit).Value = False
                '                End If
                '                da.SelectCommand.Parameters.Add("@motivo2dietaeq", SqlDbType.VarChar).Value = TextBox30.Text
                '            End If
                '            If DropDownList11.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietavariada", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivodietavar", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietavariada", SqlDbType.VarChar).Value = DropDownList11.Text
                '                da.SelectCommand.Parameters.Add("@motivodietavar", SqlDbType.VarChar).Value = TextBox31.Text
                '            End If
                '            If DropDownList12.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietaadecuada", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@grasas", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@azucares", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@irritantes", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@condimientos", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@alcohol", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@motivo2dietaadec", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietaadecuada", SqlDbType.VarChar).Value = DropDownList12.Text
                '                If CheckBox4.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@grasas", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@grasas", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox5.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@azucares", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@azucares", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox6.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@irritantes", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@irritantes", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox7.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@condimentos", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@condimientos", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox8.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@alcohol", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@alcohol", SqlDbType.Bit).Value = False
                '                End If
                '                da.SelectCommand.Parameters.Add("@motivo2dietaadec", SqlDbType.VarChar).Value = TextBox32.Text
                '            End If
                '            If DropDownList14.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietasufic", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivo1dietasufic", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivo2dietasufic", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietasufic", SqlDbType.VarChar).Value = DropDownList14.Text
                '                da.SelectCommand.Parameters.Add("@motivo1dietasufic", SqlDbType.VarChar).Value = DropDownList15.Text
                '                da.SelectCommand.Parameters.Add("@motivo2dietasufic", SqlDbType.VarChar).Value = TextBox33.Text

                '            End If
                '            If DropDownList16.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietainocua", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivodietainocua", SqlDbType.VarChar).Value = TextBox34.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietainocua", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivodietainocua", SqlDbType.VarChar).Value = TextBox34.Text
                '            End If
                '            da.SelectCommand.Parameters.Add("@diagnutric", SqlDbType.VarChar).Value = TextBox35.Text
                '            da.SelectCommand.Parameters.Add("@objtratamiento", SqlDbType.VarChar).Value = TextBox36.Text
                '            da.SelectCommand.Parameters.Add("@tratamnutricional", SqlDbType.VarChar).Value = TextBox37.Text
                '            da.SelectCommand.Parameters.Add("@medico", SqlDbType.VarChar).Value = Label7.Text
                '            da.SelectCommand.ExecuteNonQuery()
                '            con.Close()
                '        Catch ex As Exception
                '            MsgBox(ex.Message)
                '            con.Close()
                '        End Try
                '    End If

                '    If DropDownList23.Text <> "--Seleccionar--" Then
                '        Try

                '            'Dim tb As TextBox = divPassenger.FindControl("txtlugar" & numeroRegistro)
                '            'MsgBox(tb.Text)
                '            'Dim tb2 As TextBox = divPassenger.FindControl("txthorario" & numeroRegistro)
                '            'Dim tb3 As TextBox = divPassenger.FindControl("txtalimycant" & numeroRegistro)
                '            'Dim tb4 As TextBox = divPassenger.FindControl("txtvalcalor" & numeroRegistro)
                '            'Dim cmb As DropDownList = divPassenger.FindControl("cmb" & numeroRegistro)
                '            If con.State = ConnectionState.Open Then
                '                con.Close()
                '            End If
                '            con.Open()
                '            da = New SqlDataAdapter("insert into nutricional values(@folio,@exped, @fechamodif,@consultaanterior,@objetivocons,@pesobajo,@pesoalto,@pesopromedio,@alergicoalimento,@intolerantealimento,@alimnogustan,@alimgustan,@impedimentocomidas,@sintomaalimentos,@alimentoscausantes,@alimentosalivian,@actividadfisica,@tiempoacfisica,@tiempocomida,@lugarcomida,@horariocomida,@alimentoycant,@valorcalorico,@talla,@peso,@imc,@circcintura,@circcadera,@porcgrasa,@porcmusculo,@porcagua,@dietacompleta,@motivocompleta,@dietaequilibrada,@carbohidratos,@motivo2dietaeq,@dietavariada,@motivodietavar,@dietaadecuada,@azucares,@motivo2dietaadec,@dietasufic,@motivo1dietasufic,@motivo2dietasufic,@dietainocua,@motivodietainocua,@diagnutric,@objtratamiento,@tratamnutricional,@medico,null,@proteina,@grasa,@irritantes,@condimentos,@alcohol,@grasas)", con)
                '            da.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                '            da.SelectCommand.Parameters.Add("@exped", SqlDbType.Int).Value = Label6.Text
                '            da.SelectCommand.Parameters.Add("@fechamodif", SqlDbType.DateTime).Value = Convert.ToDateTime(Label1.Text)
                '            If DropDownList1.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@consultaanterior", SqlDbType.VarChar).Value = TextBox5.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@consultaanterior", SqlDbType.VarChar).Value = "No"
                '            End If
                '            If DropDownList2.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@objetivocons", SqlDbType.VarChar).Value = TextBox6.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@objetivocons", SqlDbType.VarChar).Value = "No"
                '            End If
                '            da.SelectCommand.Parameters.Add("@pesobajo", SqlDbType.VarChar).Value = TextBox7.Text
                '            da.SelectCommand.Parameters.Add("@pesoalto", SqlDbType.VarChar).Value = TextBox8.Text
                '            da.SelectCommand.Parameters.Add("@pesopromedio", SqlDbType.VarChar).Value = TextBox9.Text
                '            If DropDownList3.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@alergicoalimento", SqlDbType.VarChar).Value = TextBox10.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@alergicoalimento", SqlDbType.VarChar).Value = "No"
                '            End If
                '            If DropDownList4.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@intolerantealimento", SqlDbType.VarChar).Value = TextBox11.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@intolerantealimento", SqlDbType.VarChar).Value = "No"
                '            End If
                '            da.SelectCommand.Parameters.Add("@alimnogustan", SqlDbType.VarChar).Value = TextBox12.Text
                '            da.SelectCommand.Parameters.Add("@alimgustan", SqlDbType.VarChar).Value = TextBox13.Text
                '            If DropDownList5.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@impedimentocomidas", SqlDbType.VarChar).Value = TextBox14.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@impedimentocomidas", SqlDbType.VarChar).Value = "No"
                '            End If
                '            da.SelectCommand.Parameters.Add("@sintomaalimentos", SqlDbType.VarChar).Value = TextBox15.Text
                '            da.SelectCommand.Parameters.Add("@alimentoscausantes", SqlDbType.VarChar).Value = TextBox16.Text
                '            da.SelectCommand.Parameters.Add("@alimentosalivian", SqlDbType.VarChar).Value = TextBox17.Text

                '            If DropDownList7.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@actividadfisica", SqlDbType.VarChar).Value = TextBox18.Text
                '                da.SelectCommand.Parameters.Add("@tiempoacfisica", SqlDbType.VarChar).Value = TextBox19.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@actividadfisica", SqlDbType.VarChar).Value = "No"
                '                da.SelectCommand.Parameters.Add("@tiempoacfisica", SqlDbType.VarChar).Value = ""
                '            End If

                '            da.SelectCommand.Parameters.Add("@tiempocomida", SqlDbType.VarChar).Value = DropDownList23.Text
                '            da.SelectCommand.Parameters.Add("@lugarcomida", SqlDbType.VarChar).Value = TextBox62.Text
                '            da.SelectCommand.Parameters.Add("@horariocomida", SqlDbType.VarChar).Value = TextBox63.Text
                '            da.SelectCommand.Parameters.Add("@alimentoycant", SqlDbType.VarChar).Value = TextBox64.Text

                '            da.SelectCommand.Parameters.Add("@valorcalorico", SqlDbType.VarChar).Value = TextBox65.Text

                '            da.SelectCommand.Parameters.Add("@talla", SqlDbType.VarChar).Value = TextBox21.Text

                '            da.SelectCommand.Parameters.Add("@peso", SqlDbType.VarChar).Value = TextBox22.Text


                '            da.SelectCommand.Parameters.Add("@imc", SqlDbType.VarChar).Value = TextBox23.Text
                '            da.SelectCommand.Parameters.Add("@circcintura", SqlDbType.VarChar).Value = TextBox24.Text
                '            da.SelectCommand.Parameters.Add("@circcadera", SqlDbType.VarChar).Value = TextBox25.Text

                '            da.SelectCommand.Parameters.Add("@porcgrasa", SqlDbType.VarChar).Value = TextBox26.Text

                '            da.SelectCommand.Parameters.Add("@porcmusculo", SqlDbType.VarChar).Value = TextBox27.Text

                '            da.SelectCommand.Parameters.Add("@porcagua", SqlDbType.VarChar).Value = TextBox28.Text

                '            If DropDownList8.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietacompleta", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietacompleta", SqlDbType.VarChar).Value = DropDownList8.Text
                '            End If
                '            If DropDownList8.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@motivocompleta", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@motivocompleta", SqlDbType.VarChar).Value = TextBox29.Text
                '            End If
                '            If DropDownList9.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietaequilibrada", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@carbohidratos", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@proteina", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@grasa", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@motivo2dietaeq", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietaequilibrada", SqlDbType.VarChar).Value = DropDownList9.Text

                '                If CheckBox2.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@carbohidratos", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@carbohidratos", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox1.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@proteina", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@proteina", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox3.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@grasa", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@grasa", SqlDbType.Bit).Value = False
                '                End If
                '                da.SelectCommand.Parameters.Add("@motivo2dietaeq", SqlDbType.VarChar).Value = TextBox30.Text
                '            End If
                '            If DropDownList11.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietavariada", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivodietavar", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietavariada", SqlDbType.VarChar).Value = DropDownList11.Text
                '                da.SelectCommand.Parameters.Add("@motivodietavar", SqlDbType.VarChar).Value = TextBox31.Text
                '            End If
                '            If DropDownList12.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietaadecuada", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@grasas", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@azucares", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@irritantes", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@condimientos", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@alcohol", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@motivo2dietaadec", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietaadecuada", SqlDbType.VarChar).Value = DropDownList12.Text
                '                If CheckBox4.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@grasas", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@grasas", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox5.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@azucares", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@azucares", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox6.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@irritantes", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@irritantes", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox7.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@condimentos", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@condimientos", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox8.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@alcohol", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@alcohol", SqlDbType.Bit).Value = False
                '                End If
                '                da.SelectCommand.Parameters.Add("@motivo2dietaadec", SqlDbType.VarChar).Value = TextBox32.Text
                '            End If
                '            If DropDownList14.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietasufic", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivo1dietasufic", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivo2dietasufic", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietasufic", SqlDbType.VarChar).Value = DropDownList14.Text
                '                da.SelectCommand.Parameters.Add("@motivo1dietasufic", SqlDbType.VarChar).Value = DropDownList15.Text
                '                da.SelectCommand.Parameters.Add("@motivo2dietasufic", SqlDbType.VarChar).Value = TextBox33.Text

                '            End If
                '            If DropDownList16.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietainocua", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivodietainocua", SqlDbType.VarChar).Value = TextBox34.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietainocua", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivodietainocua", SqlDbType.VarChar).Value = TextBox34.Text
                '            End If
                '            da.SelectCommand.Parameters.Add("@diagnutric", SqlDbType.VarChar).Value = TextBox35.Text
                '            da.SelectCommand.Parameters.Add("@objtratamiento", SqlDbType.VarChar).Value = TextBox36.Text
                '            da.SelectCommand.Parameters.Add("@tratamnutricional", SqlDbType.VarChar).Value = TextBox37.Text
                '            da.SelectCommand.Parameters.Add("@medico", SqlDbType.VarChar).Value = Label7.Text
                '            da.SelectCommand.ExecuteNonQuery()
                '            con.Close()
                '        Catch ex As Exception
                '            MsgBox(ex.Message)
                '            con.Close()
                '        End Try
                '    End If

                '    If DropDownList24.Text <> "--Seleccionar--" Then
                '        Try

                '            'Dim tb As TextBox = divPassenger.FindControl("txtlugar" & numeroRegistro)
                '            'MsgBox(tb.Text)
                '            'Dim tb2 As TextBox = divPassenger.FindControl("txthorario" & numeroRegistro)
                '            'Dim tb3 As TextBox = divPassenger.FindControl("txtalimycant" & numeroRegistro)
                '            'Dim tb4 As TextBox = divPassenger.FindControl("txtvalcalor" & numeroRegistro)
                '            'Dim cmb As DropDownList = divPassenger.FindControl("cmb" & numeroRegistro)
                '            If con.State = ConnectionState.Open Then
                '                con.Close()
                '            End If
                '            con.Open()
                '            da = New SqlDataAdapter("insert into nutricional values(@folio,@exped, @fechamodif,@consultaanterior,@objetivocons,@pesobajo,@pesoalto,@pesopromedio,@alergicoalimento,@intolerantealimento,@alimnogustan,@alimgustan,@impedimentocomidas,@sintomaalimentos,@alimentoscausantes,@alimentosalivian,@actividadfisica,@tiempoacfisica,@tiempocomida,@lugarcomida,@horariocomida,@alimentoycant,@valorcalorico,@talla,@peso,@imc,@circcintura,@circcadera,@porcgrasa,@porcmusculo,@porcagua,@dietacompleta,@motivocompleta,@dietaequilibrada,@carbohidratos,@motivo2dietaeq,@dietavariada,@motivodietavar,@dietaadecuada,@azucares,@motivo2dietaadec,@dietasufic,@motivo1dietasufic,@motivo2dietasufic,@dietainocua,@motivodietainocua,@diagnutric,@objtratamiento,@tratamnutricional,@medico,null,@proteina,@grasa,@irritantes,@condimentos,@alcohol,@grasas)", con)
                '            da.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                '            da.SelectCommand.Parameters.Add("@exped", SqlDbType.Int).Value = Label6.Text
                '            da.SelectCommand.Parameters.Add("@fechamodif", SqlDbType.DateTime).Value = Convert.ToDateTime(Label1.Text)
                '            If DropDownList1.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@consultaanterior", SqlDbType.VarChar).Value = TextBox5.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@consultaanterior", SqlDbType.VarChar).Value = "No"
                '            End If
                '            If DropDownList2.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@objetivocons", SqlDbType.VarChar).Value = TextBox6.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@objetivocons", SqlDbType.VarChar).Value = "No"
                '            End If
                '            da.SelectCommand.Parameters.Add("@pesobajo", SqlDbType.VarChar).Value = TextBox7.Text
                '            da.SelectCommand.Parameters.Add("@pesoalto", SqlDbType.VarChar).Value = TextBox8.Text
                '            da.SelectCommand.Parameters.Add("@pesopromedio", SqlDbType.VarChar).Value = TextBox9.Text
                '            If DropDownList3.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@alergicoalimento", SqlDbType.VarChar).Value = TextBox10.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@alergicoalimento", SqlDbType.VarChar).Value = "No"
                '            End If
                '            If DropDownList4.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@intolerantealimento", SqlDbType.VarChar).Value = TextBox11.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@intolerantealimento", SqlDbType.VarChar).Value = "No"
                '            End If
                '            da.SelectCommand.Parameters.Add("@alimnogustan", SqlDbType.VarChar).Value = TextBox12.Text
                '            da.SelectCommand.Parameters.Add("@alimgustan", SqlDbType.VarChar).Value = TextBox13.Text
                '            If DropDownList5.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@impedimentocomidas", SqlDbType.VarChar).Value = TextBox14.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@impedimentocomidas", SqlDbType.VarChar).Value = "No"
                '            End If
                '            da.SelectCommand.Parameters.Add("@sintomaalimentos", SqlDbType.VarChar).Value = TextBox15.Text
                '            da.SelectCommand.Parameters.Add("@alimentoscausantes", SqlDbType.VarChar).Value = TextBox16.Text
                '            da.SelectCommand.Parameters.Add("@alimentosalivian", SqlDbType.VarChar).Value = TextBox17.Text

                '            If DropDownList7.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@actividadfisica", SqlDbType.VarChar).Value = TextBox18.Text
                '                da.SelectCommand.Parameters.Add("@tiempoacfisica", SqlDbType.VarChar).Value = TextBox19.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@actividadfisica", SqlDbType.VarChar).Value = "No"
                '                da.SelectCommand.Parameters.Add("@tiempoacfisica", SqlDbType.VarChar).Value = ""
                '            End If

                '            da.SelectCommand.Parameters.Add("@tiempocomida", SqlDbType.VarChar).Value = DropDownList24.Text
                '            da.SelectCommand.Parameters.Add("@lugarcomida", SqlDbType.VarChar).Value = TextBox66.Text
                '            da.SelectCommand.Parameters.Add("@horariocomida", SqlDbType.VarChar).Value = TextBox67.Text
                '            da.SelectCommand.Parameters.Add("@alimentoycant", SqlDbType.VarChar).Value = TextBox68.Text

                '            da.SelectCommand.Parameters.Add("@valorcalorico", SqlDbType.VarChar).Value = TextBox69.Text

                '            da.SelectCommand.Parameters.Add("@talla", SqlDbType.VarChar).Value = TextBox21.Text

                '            da.SelectCommand.Parameters.Add("@peso", SqlDbType.VarChar).Value = TextBox22.Text


                '            da.SelectCommand.Parameters.Add("@imc", SqlDbType.VarChar).Value = TextBox23.Text
                '            da.SelectCommand.Parameters.Add("@circcintura", SqlDbType.VarChar).Value = TextBox24.Text
                '            da.SelectCommand.Parameters.Add("@circcadera", SqlDbType.VarChar).Value = TextBox25.Text

                '            da.SelectCommand.Parameters.Add("@porcgrasa", SqlDbType.VarChar).Value = TextBox26.Text


                '            da.SelectCommand.Parameters.Add("@porcmusculo", SqlDbType.VarChar).Value = TextBox27.Text

                '            da.SelectCommand.Parameters.Add("@porcagua", SqlDbType.VarChar).Value = TextBox28.Text

                '            da.SelectCommand.Parameters.Add("@dietacompleta", SqlDbType.VarChar).Value = DropDownList8.Text

                '            If DropDownList8.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@motivocompleta", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@motivocompleta", SqlDbType.VarChar).Value = TextBox29.Text
                '            End If
                '            If DropDownList9.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietaequilibrada", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@carbohidratos", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@proteina", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@grasa", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@motivo2dietaeq", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietaequilibrada", SqlDbType.VarChar).Value = DropDownList9.Text

                '                If CheckBox2.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@carbohidratos", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@carbohidratos", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox1.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@proteina", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@proteina", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox3.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@grasa", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@grasa", SqlDbType.Bit).Value = False
                '                End If
                '                da.SelectCommand.Parameters.Add("@motivo2dietaeq", SqlDbType.VarChar).Value = TextBox30.Text
                '            End If
                '            If DropDownList11.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietavariada", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivodietavar", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietavariada", SqlDbType.VarChar).Value = DropDownList11.Text
                '                da.SelectCommand.Parameters.Add("@motivodietavar", SqlDbType.VarChar).Value = TextBox31.Text
                '            End If
                '            If DropDownList12.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietaadecuada", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@grasas", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@azucares", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@irritantes", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@condimientos", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@alcohol", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@motivo2dietaadec", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietaadecuada", SqlDbType.VarChar).Value = DropDownList12.Text
                '                If CheckBox4.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@grasas", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@grasas", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox5.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@azucares", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@azucares", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox6.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@irritantes", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@irritantes", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox7.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@condimentos", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@condimientos", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox8.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@alcohol", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@alcohol", SqlDbType.Bit).Value = False
                '                End If
                '                da.SelectCommand.Parameters.Add("@motivo2dietaadec", SqlDbType.VarChar).Value = TextBox32.Text
                '            End If
                '            If DropDownList14.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietasufic", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivo1dietasufic", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivo2dietasufic", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietasufic", SqlDbType.VarChar).Value = DropDownList14.Text
                '                da.SelectCommand.Parameters.Add("@motivo1dietasufic", SqlDbType.VarChar).Value = DropDownList15.Text
                '                da.SelectCommand.Parameters.Add("@motivo2dietasufic", SqlDbType.VarChar).Value = TextBox33.Text

                '            End If
                '            If DropDownList16.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietainocua", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivodietainocua", SqlDbType.VarChar).Value = TextBox34.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietainocua", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivodietainocua", SqlDbType.VarChar).Value = TextBox34.Text
                '            End If
                '            da.SelectCommand.Parameters.Add("@diagnutric", SqlDbType.VarChar).Value = TextBox35.Text
                '            da.SelectCommand.Parameters.Add("@objtratamiento", SqlDbType.VarChar).Value = TextBox36.Text
                '            da.SelectCommand.Parameters.Add("@tratamnutricional", SqlDbType.VarChar).Value = TextBox37.Text
                '            da.SelectCommand.Parameters.Add("@medico", SqlDbType.VarChar).Value = Label7.Text
                '            da.SelectCommand.ExecuteNonQuery()
                '            con.Close()
                '        Catch ex As Exception
                '            MsgBox(ex.Message)
                '            con.Close()
                '        End Try
                '    End If

                '    If DropDownList25.Text <> "--Seleccionar--" Then
                '        Try

                '            'Dim tb As TextBox = divPassenger.FindControl("txtlugar" & numeroRegistro)
                '            'MsgBox(tb.Text)
                '            'Dim tb2 As TextBox = divPassenger.FindControl("txthorario" & numeroRegistro)
                '            'Dim tb3 As TextBox = divPassenger.FindControl("txtalimycant" & numeroRegistro)
                '            'Dim tb4 As TextBox = divPassenger.FindControl("txtvalcalor" & numeroRegistro)
                '            'Dim cmb As DropDownList = divPassenger.FindControl("cmb" & numeroRegistro)
                '            If con.State = ConnectionState.Open Then
                '                con.Close()
                '            End If
                '            con.Open()
                '            da = New SqlDataAdapter("insert into nutricional values(@folio,@exped, @fechamodif,@consultaanterior,@objetivocons,@pesobajo,@pesoalto,@pesopromedio,@alergicoalimento,@intolerantealimento,@alimnogustan,@alimgustan,@impedimentocomidas,@sintomaalimentos,@alimentoscausantes,@alimentosalivian,@actividadfisica,@tiempoacfisica,@tiempocomida,@lugarcomida,@horariocomida,@alimentoycant,@valorcalorico,@talla,@peso,@imc,@circcintura,@circcadera,@porcgrasa,@porcmusculo,@porcagua,@dietacompleta,@motivocompleta,@dietaequilibrada,@carbohidratos,@motivo2dietaeq,@dietavariada,@motivodietavar,@dietaadecuada,@azucares,@motivo2dietaadec,@dietasufic,@motivo1dietasufic,@motivo2dietasufic,@dietainocua,@motivodietainocua,@diagnutric,@objtratamiento,@tratamnutricional,@medico,null,@proteina,@grasa,@irritantes,@condimentos,@alcohol,@grasas)", con)
                '            da.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                '            da.SelectCommand.Parameters.Add("@exped", SqlDbType.Int).Value = Label6.Text
                '            da.SelectCommand.Parameters.Add("@fechamodif", SqlDbType.DateTime).Value = Convert.ToDateTime(Label1.Text)
                '            If DropDownList1.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@consultaanterior", SqlDbType.VarChar).Value = TextBox5.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@consultaanterior", SqlDbType.VarChar).Value = "No"
                '            End If
                '            If DropDownList2.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@objetivocons", SqlDbType.VarChar).Value = TextBox6.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@objetivocons", SqlDbType.VarChar).Value = "No"
                '            End If
                '            da.SelectCommand.Parameters.Add("@pesobajo", SqlDbType.VarChar).Value = TextBox7.Text
                '            da.SelectCommand.Parameters.Add("@pesoalto", SqlDbType.VarChar).Value = TextBox8.Text
                '            da.SelectCommand.Parameters.Add("@pesopromedio", SqlDbType.VarChar).Value = TextBox9.Text
                '            If DropDownList3.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@alergicoalimento", SqlDbType.VarChar).Value = TextBox10.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@alergicoalimento", SqlDbType.VarChar).Value = "No"
                '            End If
                '            If DropDownList4.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@intolerantealimento", SqlDbType.VarChar).Value = TextBox11.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@intolerantealimento", SqlDbType.VarChar).Value = "No"
                '            End If
                '            da.SelectCommand.Parameters.Add("@alimnogustan", SqlDbType.VarChar).Value = TextBox12.Text
                '            da.SelectCommand.Parameters.Add("@alimgustan", SqlDbType.VarChar).Value = TextBox13.Text
                '            If DropDownList5.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@impedimentocomidas", SqlDbType.VarChar).Value = TextBox14.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@impedimentocomidas", SqlDbType.VarChar).Value = "No"
                '            End If
                '            da.SelectCommand.Parameters.Add("@sintomaalimentos", SqlDbType.VarChar).Value = TextBox15.Text
                '            da.SelectCommand.Parameters.Add("@alimentoscausantes", SqlDbType.VarChar).Value = TextBox16.Text
                '            da.SelectCommand.Parameters.Add("@alimentosalivian", SqlDbType.VarChar).Value = TextBox17.Text

                '            If DropDownList7.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@actividadfisica", SqlDbType.VarChar).Value = TextBox18.Text
                '                da.SelectCommand.Parameters.Add("@tiempoacfisica", SqlDbType.VarChar).Value = TextBox19.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@actividadfisica", SqlDbType.VarChar).Value = "No"
                '                da.SelectCommand.Parameters.Add("@tiempoacfisica", SqlDbType.VarChar).Value = ""
                '            End If

                '            da.SelectCommand.Parameters.Add("@tiempocomida", SqlDbType.VarChar).Value = DropDownList25.Text
                '            da.SelectCommand.Parameters.Add("@lugarcomida", SqlDbType.VarChar).Value = TextBox70.Text
                '            da.SelectCommand.Parameters.Add("@horariocomida", SqlDbType.VarChar).Value = TextBox71.Text
                '            da.SelectCommand.Parameters.Add("@alimentoycant", SqlDbType.VarChar).Value = TextBox72.Text

                '            da.SelectCommand.Parameters.Add("@valorcalorico", SqlDbType.VarChar).Value = TextBox73.Text

                '            da.SelectCommand.Parameters.Add("@talla", SqlDbType.VarChar).Value = TextBox21.Text

                '            da.SelectCommand.Parameters.Add("@peso", SqlDbType.VarChar).Value = TextBox22.Text


                '            da.SelectCommand.Parameters.Add("@imc", SqlDbType.VarChar).Value = TextBox23.Text
                '            da.SelectCommand.Parameters.Add("@circcintura", SqlDbType.VarChar).Value = TextBox24.Text
                '            da.SelectCommand.Parameters.Add("@circcadera", SqlDbType.VarChar).Value = TextBox25.Text

                '            da.SelectCommand.Parameters.Add("@porcgrasa", SqlDbType.VarChar).Value = TextBox26.Text

                '            da.SelectCommand.Parameters.Add("@porcmusculo", SqlDbType.VarChar).Value = TextBox27.Text

                '            da.SelectCommand.Parameters.Add("@porcagua", SqlDbType.VarChar).Value = TextBox28.Text

                '            If DropDownList8.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietacompleta", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietacompleta", SqlDbType.VarChar).Value = DropDownList8.Text
                '            End If
                '            If DropDownList8.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@motivocompleta", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@motivocompleta", SqlDbType.VarChar).Value = TextBox29.Text
                '            End If
                '            If DropDownList9.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietaequilibrada", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@carbohidratos", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@proteina", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@grasa", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@motivo2dietaeq", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietaequilibrada", SqlDbType.VarChar).Value = DropDownList9.Text

                '                If CheckBox2.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@carbohidratos", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@carbohidratos", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox1.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@proteina", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@proteina", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox3.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@grasa", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@grasa", SqlDbType.Bit).Value = False
                '                End If
                '                da.SelectCommand.Parameters.Add("@motivo2dietaeq", SqlDbType.VarChar).Value = TextBox30.Text
                '            End If
                '            If DropDownList11.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietavariada", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivodietavar", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietavariada", SqlDbType.VarChar).Value = DropDownList11.Text
                '                da.SelectCommand.Parameters.Add("@motivodietavar", SqlDbType.VarChar).Value = TextBox31.Text
                '            End If
                '            If DropDownList12.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietaadecuada", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@grasas", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@azucares", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@irritantes", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@condimientos", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@alcohol", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@motivo2dietaadec", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietaadecuada", SqlDbType.VarChar).Value = DropDownList12.Text
                '                If CheckBox4.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@grasas", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@grasas", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox5.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@azucares", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@azucares", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox6.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@irritantes", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@irritantes", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox7.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@condimentos", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@condimientos", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox8.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@alcohol", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@alcohol", SqlDbType.Bit).Value = False
                '                End If
                '                da.SelectCommand.Parameters.Add("@motivo2dietaadec", SqlDbType.VarChar).Value = TextBox32.Text
                '            End If
                '            If DropDownList14.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietasufic", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivo1dietasufic", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivo2dietasufic", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietasufic", SqlDbType.VarChar).Value = DropDownList14.Text
                '                da.SelectCommand.Parameters.Add("@motivo1dietasufic", SqlDbType.VarChar).Value = DropDownList15.Text
                '                da.SelectCommand.Parameters.Add("@motivo2dietasufic", SqlDbType.VarChar).Value = TextBox33.Text

                '            End If
                '            If DropDownList16.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietainocua", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivodietainocua", SqlDbType.VarChar).Value = TextBox34.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietainocua", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivodietainocua", SqlDbType.VarChar).Value = TextBox34.Text
                '            End If
                '            da.SelectCommand.Parameters.Add("@diagnutric", SqlDbType.VarChar).Value = TextBox35.Text
                '            da.SelectCommand.Parameters.Add("@objtratamiento", SqlDbType.VarChar).Value = TextBox36.Text
                '            da.SelectCommand.Parameters.Add("@tratamnutricional", SqlDbType.VarChar).Value = TextBox37.Text
                '            da.SelectCommand.Parameters.Add("@medico", SqlDbType.VarChar).Value = Label7.Text
                '            da.SelectCommand.ExecuteNonQuery()
                '            con.Close()
                '        Catch ex As Exception
                '            MsgBox(ex.Message)
                '            con.Close()
                '        End Try
                '    End If

                '    If DropDownList26.Text <> "--Seleccionar--" Then
                '        Try

                '            'Dim tb As TextBox = divPassenger.FindControl("txtlugar" & numeroRegistro)
                '            'MsgBox(tb.Text)
                '            'Dim tb2 As TextBox = divPassenger.FindControl("txthorario" & numeroRegistro)
                '            'Dim tb3 As TextBox = divPassenger.FindControl("txtalimycant" & numeroRegistro)
                '            'Dim tb4 As TextBox = divPassenger.FindControl("txtvalcalor" & numeroRegistro)
                '            'Dim cmb As DropDownList = divPassenger.FindControl("cmb" & numeroRegistro)
                '            If con.State = ConnectionState.Open Then
                '                con.Close()
                '            End If
                '            con.Open()
                '            da = New SqlDataAdapter("insert into nutricional values(@folio,@exped, @fechamodif,@consultaanterior,@objetivocons,@pesobajo,@pesoalto,@pesopromedio,@alergicoalimento,@intolerantealimento,@alimnogustan,@alimgustan,@impedimentocomidas,@sintomaalimentos,@alimentoscausantes,@alimentosalivian,@actividadfisica,@tiempoacfisica,@tiempocomida,@lugarcomida,@horariocomida,@alimentoycant,@valorcalorico,@talla,@peso,@imc,@circcintura,@circcadera,@porcgrasa,@porcmusculo,@porcagua,@dietacompleta,@motivocompleta,@dietaequilibrada,@carbohidratos,@motivo2dietaeq,@dietavariada,@motivodietavar,@dietaadecuada,@azucares,@motivo2dietaadec,@dietasufic,@motivo1dietasufic,@motivo2dietasufic,@dietainocua,@motivodietainocua,@diagnutric,@objtratamiento,@tratamnutricional,@medico,null,@proteina,@grasa,@irritantes,@condimentos,@alcohol,@grasas)", con)
                '            da.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                '            da.SelectCommand.Parameters.Add("@exped", SqlDbType.Int).Value = Label6.Text
                '            da.SelectCommand.Parameters.Add("@fechamodif", SqlDbType.DateTime).Value = Convert.ToDateTime(Label1.Text)
                '            If DropDownList1.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@consultaanterior", SqlDbType.VarChar).Value = TextBox5.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@consultaanterior", SqlDbType.VarChar).Value = "No"
                '            End If
                '            If DropDownList2.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@objetivocons", SqlDbType.VarChar).Value = TextBox6.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@objetivocons", SqlDbType.VarChar).Value = "No"
                '            End If
                '            da.SelectCommand.Parameters.Add("@pesobajo", SqlDbType.VarChar).Value = TextBox7.Text
                '            da.SelectCommand.Parameters.Add("@pesoalto", SqlDbType.VarChar).Value = TextBox8.Text
                '            da.SelectCommand.Parameters.Add("@pesopromedio", SqlDbType.VarChar).Value = TextBox9.Text
                '            If DropDownList3.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@alergicoalimento", SqlDbType.VarChar).Value = TextBox10.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@alergicoalimento", SqlDbType.VarChar).Value = "No"
                '            End If
                '            If DropDownList4.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@intolerantealimento", SqlDbType.VarChar).Value = TextBox11.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@intolerantealimento", SqlDbType.VarChar).Value = "No"
                '            End If
                '            da.SelectCommand.Parameters.Add("@alimnogustan", SqlDbType.VarChar).Value = TextBox12.Text
                '            da.SelectCommand.Parameters.Add("@alimgustan", SqlDbType.VarChar).Value = TextBox13.Text
                '            If DropDownList5.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@impedimentocomidas", SqlDbType.VarChar).Value = TextBox14.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@impedimentocomidas", SqlDbType.VarChar).Value = "No"
                '            End If
                '            da.SelectCommand.Parameters.Add("@sintomaalimentos", SqlDbType.VarChar).Value = TextBox15.Text
                '            da.SelectCommand.Parameters.Add("@alimentoscausantes", SqlDbType.VarChar).Value = TextBox16.Text
                '            da.SelectCommand.Parameters.Add("@alimentosalivian", SqlDbType.VarChar).Value = TextBox17.Text

                '            If DropDownList7.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@actividadfisica", SqlDbType.VarChar).Value = TextBox18.Text
                '                da.SelectCommand.Parameters.Add("@tiempoacfisica", SqlDbType.VarChar).Value = TextBox19.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@actividadfisica", SqlDbType.VarChar).Value = "No"
                '                da.SelectCommand.Parameters.Add("@tiempoacfisica", SqlDbType.VarChar).Value = ""
                '            End If

                '            da.SelectCommand.Parameters.Add("@tiempocomida", SqlDbType.VarChar).Value = DropDownList26.Text
                '            da.SelectCommand.Parameters.Add("@lugarcomida", SqlDbType.VarChar).Value = TextBox74.Text
                '            da.SelectCommand.Parameters.Add("@horariocomida", SqlDbType.VarChar).Value = TextBox75.Text
                '            da.SelectCommand.Parameters.Add("@alimentoycant", SqlDbType.VarChar).Value = TextBox76.Text

                '            da.SelectCommand.Parameters.Add("@valorcalorico", SqlDbType.VarChar).Value = TextBox77.Text

                '            da.SelectCommand.Parameters.Add("@talla", SqlDbType.VarChar).Value = TextBox21.Text

                '            da.SelectCommand.Parameters.Add("@peso", SqlDbType.VarChar).Value = TextBox22.Text


                '            da.SelectCommand.Parameters.Add("@imc", SqlDbType.VarChar).Value = TextBox23.Text
                '            da.SelectCommand.Parameters.Add("@circcintura", SqlDbType.VarChar).Value = TextBox24.Text
                '            da.SelectCommand.Parameters.Add("@circcadera", SqlDbType.VarChar).Value = TextBox25.Text

                '            da.SelectCommand.Parameters.Add("@porcgrasa", SqlDbType.VarChar).Value = TextBox26.Text

                '            da.SelectCommand.Parameters.Add("@porcmusculo", SqlDbType.VarChar).Value = TextBox27.Text

                '            da.SelectCommand.Parameters.Add("@porcagua", SqlDbType.VarChar).Value = TextBox28.Text

                '            If DropDownList8.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietacompleta", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietacompleta", SqlDbType.VarChar).Value = DropDownList8.Text
                '            End If
                '            If DropDownList8.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@motivocompleta", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@motivocompleta", SqlDbType.VarChar).Value = TextBox29.Text
                '            End If
                '            If DropDownList9.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietaequilibrada", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@carbohidratos", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@proteina", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@grasa", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@motivo2dietaeq", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietaequilibrada", SqlDbType.VarChar).Value = DropDownList9.Text

                '                If CheckBox2.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@carbohidratos", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@carbohidratos", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox1.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@proteina", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@proteina", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox3.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@grasa", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@grasa", SqlDbType.Bit).Value = False
                '                End If
                '                da.SelectCommand.Parameters.Add("@motivo2dietaeq", SqlDbType.VarChar).Value = TextBox30.Text
                '            End If
                '            If DropDownList11.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietavariada", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivodietavar", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietavariada", SqlDbType.VarChar).Value = DropDownList11.Text
                '                da.SelectCommand.Parameters.Add("@motivodietavar", SqlDbType.VarChar).Value = TextBox31.Text
                '            End If
                '            If DropDownList12.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietaadecuada", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@grasas", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@azucares", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@irritantes", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@condimientos", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@alcohol", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@motivo2dietaadec", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietaadecuada", SqlDbType.VarChar).Value = DropDownList12.Text
                '                If CheckBox4.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@grasas", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@grasas", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox5.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@azucares", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@azucares", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox6.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@irritantes", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@irritantes", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox7.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@condimentos", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@condimientos", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox8.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@alcohol", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@alcohol", SqlDbType.Bit).Value = False
                '                End If
                '                da.SelectCommand.Parameters.Add("@motivo2dietaadec", SqlDbType.VarChar).Value = TextBox32.Text
                '            End If
                '            If DropDownList14.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietasufic", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivo1dietasufic", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivo2dietasufic", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietasufic", SqlDbType.VarChar).Value = DropDownList14.Text
                '                da.SelectCommand.Parameters.Add("@motivo1dietasufic", SqlDbType.VarChar).Value = DropDownList15.Text
                '                da.SelectCommand.Parameters.Add("@motivo2dietasufic", SqlDbType.VarChar).Value = TextBox33.Text

                '            End If
                '            If DropDownList16.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietainocua", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivodietainocua", SqlDbType.VarChar).Value = TextBox34.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietainocua", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivodietainocua", SqlDbType.VarChar).Value = TextBox34.Text
                '            End If
                '            da.SelectCommand.Parameters.Add("@diagnutric", SqlDbType.VarChar).Value = TextBox35.Text
                '            da.SelectCommand.Parameters.Add("@objtratamiento", SqlDbType.VarChar).Value = TextBox36.Text
                '            da.SelectCommand.Parameters.Add("@tratamnutricional", SqlDbType.VarChar).Value = TextBox37.Text
                '            da.SelectCommand.Parameters.Add("@medico", SqlDbType.VarChar).Value = Label7.Text
                '            da.SelectCommand.ExecuteNonQuery()
                '            con.Close()
                '        Catch ex As Exception
                '            MsgBox(ex.Message)
                '            con.Close()
                '        End Try
                '    End If
                '    If DropDownList16.Text = "--Seleccionar--" And DropDownList17.Text = "--Seleccionar--" And DropDownList18.Text = "--Seleccionar--" And DropDownList19.Text = "--Seleccionar--" And DropDownList20.Text = "--Seleccionar--" And DropDownList21.Text = "--Seleccionar--" And DropDownList22.Text = "--Seleccionar--" And DropDownList23.Text = "--Seleccionar--" And DropDownList24.Text = "--Seleccionar--" And DropDownList25.Text = "--Seleccionar--" And DropDownList26.Text = "--Seleccionar--" Then
                '        Try

                '            'Dim tb As TextBox = divPassenger.FindControl("txtlugar" & numeroRegistro)
                '            'MsgBox(tb.Text)
                '            'Dim tb2 As TextBox = divPassenger.FindControl("txthorario" & numeroRegistro)
                '            'Dim tb3 As TextBox = divPassenger.FindControl("txtalimycant" & numeroRegistro)
                '            'Dim tb4 As TextBox = divPassenger.FindControl("txtvalcalor" & numeroRegistro)
                '            'Dim cmb As DropDownList = divPassenger.FindControl("cmb" & numeroRegistro)
                '            If con.State = ConnectionState.Open Then
                '                con.Close()
                '            End If
                '            con.Open()
                '            da = New SqlDataAdapter("update nutricional set fechamodif=@fechamodif, consultaanterior=@consultaanterior, objetivosconsant=@objetivocons, pesobajo=@pesobajo, pesoalto=@pesoalto, pesopromedio=@pesopromedio, alergicoalimento=@alergicoalimento, intolerantealimento=@intolerantealimento, alimnogustan=@alimnogustan, alimgustan=@alimgustan, impedimentocomidas=@impedimentocomidas, sintomaalimentos=@sintomaalimentos, alimentoscausantes=@alimentoscausantes, alimentosalivian=@alimentosalivian, actividadfisica=@actividadfisica, tiempoacfisica=@tiempoacfisica, talla=@talla, peso=@peso, imc=@imc, circcintura=@circcintura, circcadera=@circcadera, porcgrasa=@porcgrasa, porcmusculo=@porcmusculo, porcagua=@porcagua, dietacompleta=@dietacompleta, motivocompleta=@motivocompleta, dietaequilibrada=@dietaequilibrada, carbohidratos=@carbohidratos, motivo2dietaeq=@motivo2dietaeq, dietavariada=@dietavariada, motivodietavar=@motivodietavar, dietaadecuada=@dietaadecuada, azucares=@azucares, motivo2dietaadec=@motivo2dietaadec, dietasufic=@dietasufic, motivo1dietasufic=@motivo1dietasufic, motivo2dietasufic=@motivo2dietasufic, dietainocua=@dietainocua, motivodietainocua=@motivodietainocua, diagnutric=@diagnutric, objtratamiento=@objtratamiento, tratamnutricional=@tratamnutricional, medico=@medico, proteina=@proteina, grasa=@grasa, irritantes=@irritantes, condimentos=@condimentos, alcohol=@alcohol, grasas=@grasas where folionota=@folio and pacienteid=@exped", con)
                '            da.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Session("numnota")
                '            da.SelectCommand.Parameters.Add("@exped", SqlDbType.Int).Value = Label6.Text
                '            da.SelectCommand.Parameters.Add("@fechamodif", SqlDbType.DateTime).Value = Convert.ToDateTime(Label1.Text)
                '            If DropDownList1.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@consultaanterior", SqlDbType.VarChar).Value = TextBox5.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@consultaanterior", SqlDbType.VarChar).Value = "No"
                '            End If
                '            If DropDownList2.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@objetivocons", SqlDbType.VarChar).Value = TextBox6.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@objetivocons", SqlDbType.VarChar).Value = "No"
                '            End If
                '            da.SelectCommand.Parameters.Add("@pesobajo", SqlDbType.VarChar).Value = TextBox7.Text
                '            da.SelectCommand.Parameters.Add("@pesoalto", SqlDbType.VarChar).Value = TextBox8.Text
                '            da.SelectCommand.Parameters.Add("@pesopromedio", SqlDbType.VarChar).Value = TextBox9.Text
                '            If DropDownList3.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@alergicoalimento", SqlDbType.VarChar).Value = TextBox10.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@alergicoalimento", SqlDbType.VarChar).Value = "No"
                '            End If
                '            If DropDownList4.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@intolerantealimento", SqlDbType.VarChar).Value = TextBox11.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@intolerantealimento", SqlDbType.VarChar).Value = "No"
                '            End If
                '            da.SelectCommand.Parameters.Add("@alimnogustan", SqlDbType.VarChar).Value = TextBox12.Text
                '            da.SelectCommand.Parameters.Add("@alimgustan", SqlDbType.VarChar).Value = TextBox13.Text
                '            If DropDownList5.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@impedimentocomidas", SqlDbType.VarChar).Value = TextBox14.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@impedimentocomidas", SqlDbType.VarChar).Value = "No"
                '            End If
                '            da.SelectCommand.Parameters.Add("@sintomaalimentos", SqlDbType.VarChar).Value = TextBox15.Text
                '            da.SelectCommand.Parameters.Add("@alimentoscausantes", SqlDbType.VarChar).Value = TextBox16.Text
                '            da.SelectCommand.Parameters.Add("@alimentosalivian", SqlDbType.VarChar).Value = TextBox17.Text

                '            If DropDownList7.SelectedValue = "Si" Then
                '                da.SelectCommand.Parameters.Add("@actividadfisica", SqlDbType.VarChar).Value = TextBox18.Text
                '                da.SelectCommand.Parameters.Add("@tiempoacfisica", SqlDbType.VarChar).Value = TextBox19.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@actividadfisica", SqlDbType.VarChar).Value = "No"
                '                da.SelectCommand.Parameters.Add("@tiempoacfisica", SqlDbType.VarChar).Value = ""
                '            End If
                '            da.SelectCommand.Parameters.Add("@talla", SqlDbType.VarChar).Value = TextBox21.Text
                '            da.SelectCommand.Parameters.Add("@peso", SqlDbType.VarChar).Value = TextBox22.Text
                '            da.SelectCommand.Parameters.Add("@imc", SqlDbType.VarChar).Value = TextBox23.Text
                '            da.SelectCommand.Parameters.Add("@circcintura", SqlDbType.VarChar).Value = TextBox24.Text
                '            da.SelectCommand.Parameters.Add("@circcadera", SqlDbType.VarChar).Value = TextBox25.Text
                '            da.SelectCommand.Parameters.Add("@porcgrasa", SqlDbType.VarChar).Value = TextBox26.Text
                '            da.SelectCommand.Parameters.Add("@porcmusculo", SqlDbType.VarChar).Value = TextBox27.Text
                '            da.SelectCommand.Parameters.Add("@porcagua", SqlDbType.VarChar).Value = TextBox28.Text
                '            If DropDownList8.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietacompleta", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietacompleta", SqlDbType.VarChar).Value = DropDownList8.Text
                '            End If
                '            If DropDownList8.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@motivocompleta", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@motivocompleta", SqlDbType.VarChar).Value = TextBox29.Text
                '            End If
                '            If DropDownList9.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietaequilibrada", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@carbohidratos", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@proteina", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@grasa", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@motivo2dietaeq", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietaequilibrada", SqlDbType.VarChar).Value = DropDownList9.Text

                '                If CheckBox2.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@carbohidratos", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@carbohidratos", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox1.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@proteina", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@proteina", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox3.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@grasa", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@grasa", SqlDbType.Bit).Value = False
                '                End If
                '                da.SelectCommand.Parameters.Add("@motivo2dietaeq", SqlDbType.VarChar).Value = TextBox30.Text
                '            End If
                '            If DropDownList11.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietavariada", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivodietavar", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietavariada", SqlDbType.VarChar).Value = DropDownList11.Text
                '                da.SelectCommand.Parameters.Add("@motivodietavar", SqlDbType.VarChar).Value = TextBox31.Text
                '            End If
                '            If DropDownList12.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietaadecuada", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@grasas", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@azucares", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@irritantes", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@condimientos", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@alcohol", SqlDbType.Bit).Value = False
                '                da.SelectCommand.Parameters.Add("@motivo2dietaadec", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietaadecuada", SqlDbType.VarChar).Value = DropDownList12.Text
                '                If CheckBox4.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@grasas", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@grasas", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox5.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@azucares", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@azucares", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox6.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@irritantes", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@irritantes", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox7.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@condimentos", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@condimientos", SqlDbType.Bit).Value = False
                '                End If
                '                If CheckBox8.Checked = True Then
                '                    da.SelectCommand.Parameters.Add("@alcohol", SqlDbType.Bit).Value = True
                '                Else
                '                    da.SelectCommand.Parameters.Add("@alcohol", SqlDbType.Bit).Value = False
                '                End If
                '                da.SelectCommand.Parameters.Add("@motivo2dietaadec", SqlDbType.VarChar).Value = TextBox32.Text
                '            End If
                '            If DropDownList14.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietasufic", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivo1dietasufic", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivo2dietasufic", SqlDbType.VarChar).Value = ""
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietasufic", SqlDbType.VarChar).Value = DropDownList14.Text
                '                da.SelectCommand.Parameters.Add("@motivo1dietasufic", SqlDbType.VarChar).Value = DropDownList15.Text
                '                da.SelectCommand.Parameters.Add("@motivo2dietasufic", SqlDbType.VarChar).Value = TextBox33.Text

                '            End If
                '            If DropDownList16.Text = "--Seleccionar--" Then
                '                da.SelectCommand.Parameters.Add("@dietainocua", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivodietainocua", SqlDbType.VarChar).Value = TextBox34.Text
                '            Else
                '                da.SelectCommand.Parameters.Add("@dietainocua", SqlDbType.VarChar).Value = ""
                '                da.SelectCommand.Parameters.Add("@motivodietainocua", SqlDbType.VarChar).Value = TextBox34.Text
                '            End If
                '            da.SelectCommand.Parameters.Add("@diagnutric", SqlDbType.VarChar).Value = TextBox35.Text
                '            da.SelectCommand.Parameters.Add("@objtratamiento", SqlDbType.VarChar).Value = TextBox36.Text
                '            da.SelectCommand.Parameters.Add("@tratamnutricional", SqlDbType.VarChar).Value = TextBox37.Text
                '            da.SelectCommand.Parameters.Add("@medico", SqlDbType.VarChar).Value = Label7.Text
                '            da.SelectCommand.ExecuteNonQuery()
                '            con.Close()
                '        Catch ex As Exception
                '            MsgBox(ex.Message)
                '            con.Close()
                '        End Try
                '    End If

            Catch ex As Exception
            Finally
                Response.Redirect("~/Gracias.aspx", False)
            End Try
        End If


    End Sub

    Protected Sub DropDownList12_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList12.SelectedIndexChanged
        If DropDownList12.Text = "No" Then
            CheckBox4.Visible = True
            CheckBox5.Visible = True
            CheckBox6.Visible = True
            CheckBox7.Visible = True
            CheckBox8.Visible = True
            TextBox32.Visible = True
        Else
            CheckBox4.Visible = False
            CheckBox5.Visible = False
            CheckBox6.Visible = False
            CheckBox7.Visible = False
            CheckBox8.Visible = False
            TextBox32.Visible = False
        End If
    End Sub

    Protected Sub DropDownList14_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList14.SelectedIndexChanged
        If DropDownList14.Text = "No" Then
            Label72.Visible = True
            DropDownList15.Visible = True
            TextBox33.Visible = True
        Else
            Label72.Visible = False
            DropDownList15.Visible = False
            TextBox33.Visible = False
        End If
    End Sub

    Protected Sub DropDownList16_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList16.SelectedIndexChanged
        If DropDownList16.Text = "No" Then
            TextBox34.Visible = True
            Label73.Visible = True
        Else
            TextBox34.Visible = False
            Label73.Visible = False
        End If
    End Sub

    Protected Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton1.Click
        Session("contador") += 1
    End Sub
End Class