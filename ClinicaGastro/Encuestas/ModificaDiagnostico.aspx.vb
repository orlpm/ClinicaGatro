Imports System.Data.SqlClient
Public Class ModificaDiagnostico
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim da1, da2, da3, da4 As New SqlDataAdapter
        Dim dr1, dr2, dr3, dr4 As SqlDataReader
        If Request.Params("id2") IsNot Nothing Then
            Session("numnota") = Request.Params("id2")
            Session("buscaarea") = Request.Params("area")
        End If

        If Session("buscaarea") = "Nutricional" Then
            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da1 = New SqlDataAdapter("select distinct fechamodif from nutricional where folionota=@folionota", con)
                da1.SelectCommand.Parameters.Add("@folionota", SqlDbType.Int).Value = Convert.ToInt32(Session("numnota"))
                dr1 = da1.SelectCommand.ExecuteReader()
                dr1.Read()
                Label1.Text = dr1(0)
                con.Close()
            Catch ex As Exception

            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da2 = New SqlDataAdapter("select nombres+' '+appaterno+' '+apmaterno from paciente,nutricional where folionota=@folio and paciente.pacienteid=nutricional.pacienteid", con)
                da2.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Convert.ToInt32(Session("numnota"))
                dr2 = da2.SelectCommand.ExecuteReader()
                dr2.Read()
                Label2.Text = dr2(0)
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da3 = New SqlDataAdapter("select distinct diagnutric from nutricional where folionota=@folionota", con)
                da3.SelectCommand.Parameters.Add("@folionota", SqlDbType.Int).Value = Convert.ToInt32(Session("numnota"))
                dr3 = da3.SelectCommand.ExecuteReader()
                dr3.Read()
                Label3.Text = dr3(0)
                con.Close()
            Catch ex As Exception

            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da4 = New SqlDataAdapter("select distinct estadodiagnostico from nutricional where folionota=@folionota", con)
                da4.SelectCommand.Parameters.Add("@folionota", SqlDbType.Int).Value = Convert.ToInt32(Session("numnota"))
                dr4 = da4.SelectCommand.ExecuteReader()
                dr4.Read()
                If String.IsNullOrEmpty(dr4(0)) Then
                    DropDownList1.Text = "--Seleccionar--"
                Else
                    DropDownList1.Text = dr4(0)
                End If
                con.Close()
            Catch ex As Exception

            End Try
            Label5.Text = Session("numnota")
            Label6.Text = Session("buscaarea")
        ElseIf Session("buscaarea") = "Psicogastroenterología" Then
            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da1 = New SqlDataAdapter("select distinct fechamodif from psico where folionota=@folionota", con)
                da1.SelectCommand.Parameters.Add("@folionota", SqlDbType.Int).Value = Convert.ToInt32(Session("numnota"))
                dr1 = da1.SelectCommand.ExecuteReader()
                dr1.Read()
                Label1.Text = dr1(0)
                con.Close()
            Catch ex As Exception

            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da2 = New SqlDataAdapter("select nombres+' '+appaterno+' '+apmaterno from paciente,psico where folionota=@folio and paciente.pacienteid=psico.pacienteid", con)
                da2.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Convert.ToInt32(Session("numnota"))
                dr2 = da2.SelectCommand.ExecuteReader()
                dr2.Read()
                Label2.Text = dr2(0)
                con.Close()
            Catch ex As Exception

            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da3 = New SqlDataAdapter("select distinct impdiagnostica from psico where folionota=@folionota", con)
                da3.SelectCommand.Parameters.Add("@folionota", SqlDbType.Int).Value = Convert.ToInt32(Session("numnota"))
                dr3 = da3.SelectCommand.ExecuteReader()
                dr3.Read()
                Label3.Text = dr3(0)
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da4 = New SqlDataAdapter("select distinct estadodiagnostico from psico where folionota=@folionota", con)
                da4.SelectCommand.Parameters.Add("@folionota", SqlDbType.Int).Value = Convert.ToInt32(Session("numnota"))
                dr4 = da4.SelectCommand.ExecuteReader()
                dr4.Read()
                If String.IsNullOrEmpty(dr4(0)) Then
                    DropDownList1.Text = "--Seleccionar--"
                Else
                    DropDownList1.Text = dr4(0)
                End If
                con.Close()
            Catch ex As Exception

            End Try
            Label5.Text = Session("numnota")
            Label6.Text = Session("buscaarea")
        ElseIf Session("buscaarea") = "Gastroquirúrgica" Then
            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da1 = New SqlDataAdapter("select distinct fechamodif from gastro where folionota=@folionota", con)
                da1.SelectCommand.Parameters.Add("@folionota", SqlDbType.Int).Value = Convert.ToInt32(Session("numnota"))
                dr1 = da1.SelectCommand.ExecuteReader()
                dr1.Read()
                Label1.Text = dr1(0)
                con.Close()
            Catch ex As Exception

            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da2 = New SqlDataAdapter("select nombres+' '+appaterno+' '+apmaterno from paciente,gastro where folionota=@folio and paciente.pacienteid=gastro.pacienteid", con)
                da2.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Convert.ToInt32(Session("numnota"))
                dr2 = da2.SelectCommand.ExecuteReader()
                dr2.Read()
                Label2.Text = dr2(0)
                con.Close()
            Catch ex As Exception

            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da3 = New SqlDataAdapter("select distinct diagnostico from gastro where folionota=@folionota", con)
                da3.SelectCommand.Parameters.Add("@folionota", SqlDbType.Int).Value = Convert.ToInt32(Session("numnota"))
                dr3 = da3.SelectCommand.ExecuteReader()
                dr3.Read()
                Label3.Text = dr3(0)
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da4 = New SqlDataAdapter("select distinct estadodiagnostico from gastro where folionota=@folionota", con)
                da4.SelectCommand.Parameters.Add("@folionota", SqlDbType.Int).Value = Convert.ToInt32(Session("numnota"))
                dr4 = da4.SelectCommand.ExecuteReader()
                dr4.Read()
                If String.IsNullOrEmpty(dr4(0)) Then
                    DropDownList1.Text = "--Seleccionar--"
                Else
                    DropDownList1.Text = dr4(0)
                End If
                con.Close()
            Catch ex As Exception

            End Try
            Label5.Text = Session("numnota")
            Label6.Text = Session("buscaarea")
        End If





    End Sub

    
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim da As New SqlDataAdapter


        If Session("buscaarea") = "Nutricional" Then
            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da = New SqlDataAdapter("update nutricional set estadodiagnostico=@edodiag where folionota=@folio", con)
                da.SelectCommand.Parameters.Add("@edodiag", SqlDbType.VarChar).Value = DropDownList1.SelectedValue
                da.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Convert.ToInt32(Session("numnota"))
                da.SelectCommand.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Response.Redirect("~/Pacientes/ListaPacientes.aspx")
            End Try
        ElseIf Session("buscaarea") = "Psicogastroenterología" Then
            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

                con.Open()
                da = New SqlDataAdapter("update psico set estadodiagnostico=@edodiag where folionota=@folio", con)
                da.SelectCommand.Parameters.Add("@edodiag", SqlDbType.VarChar).Value = DropDownList1.SelectedValue
                da.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Convert.ToInt32(Session("numnota"))
                da.SelectCommand.ExecuteNonQuery()
                con.Close()

            Catch ex As Exception
            Finally
                Response.Redirect("~/Pacientes/ListaPacientes.aspx")
            End Try
        ElseIf Session("buscaarea") = "Gastroquirúrgica" Then
            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da = New SqlDataAdapter("update gastro set estadodiagnostico=@edodiag where folionota=@folio", con)
                da.SelectCommand.Parameters.Add("@edodiag", SqlDbType.VarChar).Value = DropDownList1.SelectedValue
                da.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Convert.ToInt32(Session("numnota"))
                da.SelectCommand.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
        Finally
            Response.Redirect("~/Pacientes/ListaPacientes.aspx")
        End Try
        End If

    End Sub
End Class