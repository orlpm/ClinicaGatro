Imports System.Data.SqlClient
Public Class encuesta1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub DropDownList2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList2.SelectedIndexChanged
        If DropDownList2.SelectedValue = "Otro" Then
            TextBox9.Visible = False
            lblotro.Visible = False
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim da As New SqlDataAdapter


        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da = New SqlDataAdapter("insert into EncuestaIngreso values(@nombre,@edad,@mail,@direccion,@delegacion,@cp,@tel,@familiar,@ocupacion,@entero,@institucion,@recomendacion,@cuando,@otro)", con)
            da.SelectCommand.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = TextBox1.Text
            da.SelectCommand.Parameters.Add("@edad", SqlDbType.Int).Value = TextBox2.Text
            da.SelectCommand.Parameters.Add("@mail", SqlDbType.NVarChar).Value = TextBox3.Text
            da.SelectCommand.Parameters.Add("@direccion", SqlDbType.NVarChar).Value = TextBox4.Text
            da.SelectCommand.Parameters.Add("@delegacion", SqlDbType.NVarChar).Value = TextBox5.Text
            da.SelectCommand.Parameters.Add("@cp", SqlDbType.NVarChar).Value = TextBox6.Text
            da.SelectCommand.Parameters.Add("@tel", SqlDbType.NVarChar).Value = TextBox7.Text
            da.SelectCommand.Parameters.Add("@familiar", SqlDbType.NVarChar).Value = TextBox8.Text
            da.SelectCommand.Parameters.Add("@ocupacion", SqlDbType.VarChar).Value = DropDownList1.Text
            da.SelectCommand.Parameters.Add("@entero", SqlDbType.NVarChar).Value = DropDownList2.Text
            If DropDownList2.Text = "Mi institución tiene convenio" Then
                da.SelectCommand.Parameters.Add("@institucion", SqlDbType.NVarChar).Value = TextBox10.Text
            Else
                da.SelectCommand.Parameters.Add("@institucion", SqlDbType.NVarChar).Value = DBNull.Value
            End If
            If DropDownList2.Text = "Recomendación" Then
                da.SelectCommand.Parameters.Add("@recomendacion", SqlDbType.NVarChar).Value = TextBox11.Text
            Else
                da.SelectCommand.Parameters.Add("@recomendacion", SqlDbType.NVarChar).Value = DBNull.Value
            End If
            da.SelectCommand.Parameters.Add("@cuando", SqlDbType.NVarChar).Value = DropDownList3.Text
            da.SelectCommand.Parameters.Add("@otro", SqlDbType.NVarChar).Value = TextBox9.Text
            da.SelectCommand.ExecuteNonQuery()
            con.Close()
            Response.Redirect("/Gracias.aspx")
        Catch ex As Exception
            con.Close()
        End Try
    End Sub
End Class