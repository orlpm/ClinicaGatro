Imports System.Data.SqlClient
Public Class AltaMedicos
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
            da = New SqlDataAdapter("insert into usuarios values((select max(id)+1 from usuarios),@nombre,@appat,@apmat,@tipo,@cedula,@ocupacion,@telefono,@mail,@mail,@pass,'1',@nivel)", con)
            da.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar).Value = TextBox1.Text
            da.SelectCommand.Parameters.Add("@appat", SqlDbType.VarChar).Value = TextBox2.Text
            da.SelectCommand.Parameters.Add("@apmat", SqlDbType.VarChar).Value = TextBox3.Text
            da.SelectCommand.Parameters.Add("@tipo", SqlDbType.VarChar).Value = DropDownList1.SelectedValue
            da.SelectCommand.Parameters.Add("@cedula", SqlDbType.VarChar).Value = TextBox4.Text
            da.SelectCommand.Parameters.Add("@ocupacion", SqlDbType.VarChar).Value = TextBox5.Text
            da.SelectCommand.Parameters.Add("@telefono", SqlDbType.VarChar).Value = TextBox6.Text
            da.SelectCommand.Parameters.Add("@mail", SqlDbType.VarChar).Value = TextBox7.Text
            da.SelectCommand.Parameters.Add("@pass", SqlDbType.VarChar).Value = TextBox8.Text
            If DropDownList1.SelectedValue = "Administrador" Then
                da.SelectCommand.Parameters.Add("@nivel", SqlDbType.Int).Value = 1
            ElseIf DropDownList1.SelectedValue = "Medico" Then
                da.SelectCommand.Parameters.Add("@nivel", SqlDbType.Int).Value = 2
            ElseIf DropDownList1.SelectedValue = "Administrativo" Then
                da.SelectCommand.Parameters.Add("@nivel", SqlDbType.Int).Value = 3
            End If
            da.SelectCommand.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)
        Finally
            Response.Redirect("/Default.aspx")
        End Try
    End Sub
End Class