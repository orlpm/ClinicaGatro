Imports System.Data.SqlClient
Public Class Eliminar
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Request.Params("id2") IsNot Nothing Then
            Session("numnota") = Request.Params("id2")
            Session("buscaarea") = Request.Params("area")
        End If


        Dim da1, da2 As New SqlDataAdapter
        Dim dr1, dr2 As SqlDataReader
        If Session("Buscaarea") = "Nutricional" Then
            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da1 = New SqlDataAdapter("select distinct fechamodif from nutricional where folionota=@folio", con)
                da1.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Convert.ToInt32(Session("numnota"))
                dr1 = da1.SelectCommand.ExecuteReader
                dr1.Read()
                Label1.Text = dr1(0)
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da2 = New SqlDataAdapter("select nombres+' '+appaterno+' '+apmaterno from paciente,nutricional where folionota=@folio and paciente.pacienteid=nutricional.pacienteid", con)
                da2.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Convert.ToInt32(Session("numnota"))
                dr2 = da2.SelectCommand.ExecuteReader
                dr2.Read()
                Label2.Text = dr2(0)
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Label3.Text = Session("numnota")
            Label4.Text = Session("buscaarea")
        ElseIf Session("Buscaarea") = "Psicogastroenterología" Then
            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da1 = New SqlDataAdapter("select distinct fechamodif from psico where folionota=@folio", con)
                da1.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Convert.ToInt32(Session("numnota"))
                dr1 = da1.SelectCommand.ExecuteReader
                dr1.Read()
                Label1.Text = dr1(0)
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da2 = New SqlDataAdapter("select nombres+' '+appaterno+' '+apmaterno from paciente,psico where folionota=@folio and paciente.pacienteid=psico.pacienteid", con)
                da2.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Convert.ToInt32(Session("numnota"))
                dr2 = da2.SelectCommand.ExecuteReader
                dr2.Read()
                Label2.Text = dr2(0)
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Label3.Text = Session("numnota")
            Label4.Text = Session("buscaarea")
        ElseIf Session("Buscaarea") = "Gastroquirúrgica" Then
            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da1 = New SqlDataAdapter("select distinct fechamodif from gastro where folionota=@folio", con)
                da1.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Convert.ToInt32(Session("numnota"))
                dr1 = da1.SelectCommand.ExecuteReader
                dr1.Read()
                Label1.Text = dr1(0)
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da2 = New SqlDataAdapter("select nombres+' '+appaterno+' '+apmaterno from paciente,gastro where folionota=@folio and paciente.pacienteid=gastro.pacienteid", con)
                da2.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Convert.ToInt32(Session("numnota"))
                dr2 = da2.SelectCommand.ExecuteReader
                dr2.Read()
                Label2.Text = dr2(0)
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Label3.Text = Session("numnota")
            Label4.Text = Session("buscaarea")
        End If
    End Sub

    

    Protected Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim da1 As New SqlDataAdapter
        If Session("Buscaarea") = "Nutricional" Then
            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da1 = New SqlDataAdapter("delete from nutricional where folionota=@folio", con)
                da1.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Convert.ToInt32(Session("numnota"))
                da1.SelectCommand.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Response.Redirect("~/Pacientes/ListaPacientes.aspx")
            End Try
            
        ElseIf Session("Buscaarea") = "Psicogastroenterología" Then
            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da1 = New SqlDataAdapter("delete from psico where folionota=@folio", con)
                da1.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Convert.ToInt32(Session("numnota"))
                da1.SelectCommand.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Response.Redirect("~/Pacientes/ListaPacientes.aspx")
            End Try
            
        ElseIf Session("Buscaarea") = "Gastroquirúrgica" Then
            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da1 = New SqlDataAdapter("delete from gastro where folionota=@folio", con)
                da1.SelectCommand.Parameters.Add("@folio", SqlDbType.Int).Value = Convert.ToInt32(Session("numnota"))
                da1.SelectCommand.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Response.Redirect("~/Pacientes/ListaPacientes.aspx")
            End Try
            
        End If
        
    End Sub
End Class