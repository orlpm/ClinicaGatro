Imports System.Data.SqlClient
Public Class login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero As Integer
        Dim da As New SqlDataAdapter
        Dim con As New SqlConnection
        Dim dr As SqlDataReader
        con = New SqlConnection("server=JORGEMIJANGOS\SQLEXPRESS;database=acautocontrol;user=jorge;password=mijangos")

        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da = New SqlDataAdapter("consulta", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@usu", SqlDbType.VarChar).Value = usu.Text
            da.SelectCommand.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass.Text
            dr = da.SelectCommand.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                numero = 1
                Session("usuario") = dr.Item(0)
            Else
                numero = 0

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            numero = 0
        End Try

        If numero = 1 Then
            Response.Redirect("pagina2.aspx")

        End If
        
    End Sub
End Class