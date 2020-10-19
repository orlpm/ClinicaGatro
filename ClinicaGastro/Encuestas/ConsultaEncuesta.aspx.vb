Imports System.Data.SqlClient
Public Class ConsultaEncuesta
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim da, da1, da2, da3, da4, da5, da6, da7, da8, da9, da10, da11, da12, da13 As New SqlDataAdapter
        Dim dr, dr1, dr2, dr3, dr4, dr5, dr6, dr7, dr8, dr9, dr10, dr11, dr12, dr13 As SqlDataReader
        If Request.Params("Encuesta") IsNot Nothing Then
            Session("enc") = Request.Params("Encuesta")
        End If
        If Not IsPostBack Then
            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da = New SqlDataAdapter("Select Nombre from encuestaingreso where encuestaingresoid=@encuesta", con)
                da.SelectCommand.Parameters.Add("@encuesta", SqlDbType.Int).Value = Session("enc")
                dr = da.SelectCommand.ExecuteReader
                dr.Read()
                Label1.Text = dr(0)
                con.Close()
            Catch ex As Exception

            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da1 = New SqlDataAdapter("Select edad from encuestaingreso where encuestaingresoid=@encuesta", con)
                da1.SelectCommand.Parameters.Add("@encuesta", SqlDbType.Int).Value = Session("enc")
                dr1 = da1.SelectCommand.ExecuteReader
                dr1.Read()
                Label2.Text = dr1(0)
                con.Close()
            Catch ex As Exception

            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da2 = New SqlDataAdapter("Select Email from encuestaingreso where encuestaingresoid=@encuesta", con)
                da2.SelectCommand.Parameters.Add("@encuesta", SqlDbType.Int).Value = Session("enc")
                dr2 = da2.SelectCommand.ExecuteReader
                dr2.Read()
                Label3.Text = dr2(0)
                con.Close()
            Catch ex As Exception

            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da3 = New SqlDataAdapter("Select Direccion from encuestaingreso where encuestaingresoid=@encuesta", con)
                da3.SelectCommand.Parameters.Add("@encuesta", SqlDbType.Int).Value = Session("enc")
                dr3 = da3.SelectCommand.ExecuteReader
                dr3.Read()
                Label4.Text = dr3(0)
                con.Close()
            Catch ex As Exception

            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da4 = New SqlDataAdapter("Select delegacion from encuestaingreso where encuestaingresoid=@encuesta", con)
                da4.SelectCommand.Parameters.Add("@encuesta", SqlDbType.Int).Value = Session("enc")
                dr4 = da4.SelectCommand.ExecuteReader
                dr4.Read()
                Label5.Text = dr4(0)
                con.Close()
            Catch ex As Exception

            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da5 = New SqlDataAdapter("Select CP from encuestaingreso where encuestaingresoid=@encuesta", con)
                da5.SelectCommand.Parameters.Add("@encuesta", SqlDbType.Int).Value = Session("enc")
                dr5 = da5.SelectCommand.ExecuteReader
                dr5.Read()
                Label6.Text = dr5(0)
                con.Close()
            Catch ex As Exception

            End Try
            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da6 = New SqlDataAdapter("Select telefono from encuestaingreso where encuestaingresoid=@encuesta", con)
                da6.SelectCommand.Parameters.Add("@encuesta", SqlDbType.Int).Value = Session("enc")
                dr6 = da6.SelectCommand.ExecuteReader
                dr6.Read()
                Label7.Text = dr6(0)
                con.Close()
            Catch ex As Exception

            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da7 = New SqlDataAdapter("Select familiar from encuestaingreso where encuestaingresoid=@encuesta", con)
                da7.SelectCommand.Parameters.Add("@encuesta", SqlDbType.Int).Value = Session("enc")
                dr7 = da7.SelectCommand.ExecuteReader
                dr7.Read()
                Label8.Text = dr7(0)
                con.Close()
            Catch ex As Exception

            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da8 = New SqlDataAdapter("Select ocupacion from encuestaingreso where encuestaingresoid=@encuesta", con)
                da8.SelectCommand.Parameters.Add("@encuesta", SqlDbType.Int).Value = Session("enc")
                dr8 = da8.SelectCommand.ExecuteReader
                dr8.Read()
                Label9.Text = dr8(0)
                con.Close()
            Catch ex As Exception

            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da9 = New SqlDataAdapter("Select entero from encuestaingreso where encuestaingresoid=@encuesta", con)
                da9.SelectCommand.Parameters.Add("@encuesta", SqlDbType.Int).Value = Session("enc")
                dr9 = da9.SelectCommand.ExecuteReader
                dr9.Read()
                Label10.Text = dr9(0)
                con.Close()
            Catch ex As Exception

            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da10 = New SqlDataAdapter("Select institucion from encuestaingreso where encuestaingresoid=@encuesta", con)
                da10.SelectCommand.Parameters.Add("@encuesta", SqlDbType.Int).Value = Session("enc")
                dr10 = da10.SelectCommand.ExecuteReader
                dr10.Read()
                Label11.Text = dr10(0)
                con.Close()
            Catch ex As Exception

            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da11 = New SqlDataAdapter("Select recomendacion from encuestaingreso where encuestaingresoid=@encuesta", con)
                da11.SelectCommand.Parameters.Add("@encuesta", SqlDbType.Int).Value = Session("enc")
                dr11 = da11.SelectCommand.ExecuteReader
                dr11.Read()
                Label12.Text = dr11(0)
                con.Close()
            Catch ex As Exception

            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da12 = New SqlDataAdapter("Select cuando from encuestaingreso where encuestaingresoid=@encuesta", con)
                da12.SelectCommand.Parameters.Add("@encuesta", SqlDbType.Int).Value = Session("enc")
                dr12 = da12.SelectCommand.ExecuteReader
                dr12.Read()
                Label13.Text = dr12(0)
                con.Close()
            Catch ex As Exception

            End Try

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da13 = New SqlDataAdapter("Select otro from encuestaingreso where encuestaingresoid=@encuesta", con)
                da13.SelectCommand.Parameters.Add("@encuesta", SqlDbType.Int).Value = Session("enc")
                dr13 = da13.SelectCommand.ExecuteReader
                dr13.Read()
                Label14.Text = dr13(0)
                con.Close()
            Catch ex As Exception

            End Try
        End If
    End Sub

End Class