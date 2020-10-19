Imports System.Data.SqlClient

Public Class log
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim da, da1, da2 As New SqlDataAdapter
        Dim dr, dr1, dr2 As SqlDataReader


        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da = New SqlDataAdapter("select nivel from usuarios where usuario=@usuario and pass=@pass and activo=1", con)
            da.SelectCommand.Parameters.Add("@usuario", SqlDbType.VarChar).Value = TextBox1.Text
            da.SelectCommand.Parameters.Add("@pass", SqlDbType.VarChar).Value = TextBox2.Text
            dr = da.SelectCommand.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                Session("nivel") = dr(0)
                Session("usuario") = TextBox1.Text
            Else
                Session("nivel") = 0
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Try
                If con1.State = ConnectionState.Open Then
                    con1.Close()
                End If
                con1.Open()
                da1 = New SqlDataAdapter("select nombre+' '+appaterno+' '+apmaterno from usuarios where usuario=@usuario and pass=@pass", con1)
                da1.SelectCommand.Parameters.Add("@usuario", SqlDbType.VarChar).Value = TextBox1.Text
                da1.SelectCommand.Parameters.Add("@pass", SqlDbType.VarChar).Value = TextBox2.Text
                dr1 = da1.SelectCommand.ExecuteReader
                dr1.Read()
                If dr1.HasRows = True Then
                    
                    ConfigurationManager.AppSettings("nombreus") = dr1(0)
                    Session("nomus") = dr1(0)
                Else
                    ConfigurationManager.AppSettings("nombreus") = ""
                    Session("nomus") = ""
                End If
                con1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            
            End Try
        End Try
        
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da2 = New SqlDataAdapter("select cedula from usuarios where usuario=@usuario and pass=@pass", con)
            da2.SelectCommand.Parameters.Add("@usuario", SqlDbType.VarChar).Value = TextBox1.Text
            da2.SelectCommand.Parameters.Add("@pass", SqlDbType.VarChar).Value = TextBox2.Text
            dr2 = da2.SelectCommand.ExecuteReader
            dr2.Read()
            If dr2.HasRows = True Then
                ConfigurationManager.AppSettings("cedula") = dr2(0)
            Else
                ConfigurationManager.AppSettings("cedula") = ""
            End If
        Catch ex As Exception
        Finally
            Response.Redirect("Default.aspx")
        End Try
    End Sub

    Protected Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_Unload(sender As Object, e As EventArgs) Handles TextBox2.Unload

    End Sub
End Class