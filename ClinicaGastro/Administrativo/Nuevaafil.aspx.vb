Imports System.Data.SqlClient
Public Class Nuevaafil
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim da As New SqlDataAdapter
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da = New SqlDataAdapter("insert into afiliaciones values(@nombreafil,@direccionafil,@fechaafil,@empresa,@afil1,@afil2,null)", con)
            da.SelectCommand.Parameters.Add("@nombreafil", SqlDbType.NVarChar).Value = TextBox1.Text
            da.SelectCommand.Parameters.Add("@direccionafil", SqlDbType.NVarChar).Value = TextBox2.Text
            da.SelectCommand.Parameters.Add("@fechaafil", SqlDbType.Date).Value = TextBox3.Text
            da.SelectCommand.Parameters.Add("@empresa", SqlDbType.NVarChar).Value = TextBox4.Text
            da.SelectCommand.Parameters.Add("@afil1", SqlDbType.NVarChar).Value = TextBox5.Text
            da.SelectCommand.Parameters.Add("@afil2", SqlDbType.NVarChar).Value = TextBox6.Text
            da.SelectCommand.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            Response.Redirect("~/FinAfiliacion.aspx")
        End Try
    End Sub
End Class