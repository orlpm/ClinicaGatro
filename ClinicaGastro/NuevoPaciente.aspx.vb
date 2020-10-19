Imports System.Data.SqlClient
Public Class NuevoPaciente
    Inherits System.Web.UI.Page
    Public prep As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim da, da1, da2, da3, da4, da5 As New SqlDataAdapter
        Dim dr, dr1, dr2, dr3, dr4, dr5 As SqlDataReader
        If Not IsPostBack Then
            If Request.Params("prep") IsNot Nothing Then
                Session("prepac") = Request.Params("prep")
                prep = Request.Params("prep")
                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    da5 = New SqlDataAdapter("select nombre from prepacientes where prepacienteid=@id", con)
                    da5.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("prepac")
                    dr5 = da5.SelectCommand.ExecuteReader
                    dr5.Read()
                    If dr5.HasRows Then
                        Label6.Text = dr5(0)
                        Label6.Visible = True
                        TextBox5.Visible = False
                    Else
                        Label6.Visible = False
                        TextBox5.Visible = True
                    End If
                    con.Close()
                Catch ex As Exception

                End Try
                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    da = New SqlDataAdapter("select mail from prepacientes where prepacienteid=@id", con)
                    da.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("prepac")
                    dr = da.SelectCommand.ExecuteReader
                    dr.Read()
                    Label1.Text = dr(0)
                    Label1.Visible = True
                    TextBox1.Visible = False
                    con.Close()
                Catch ex As Exception

                End Try
                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    da1 = New SqlDataAdapter("select appaterno from prepacientes where prepacienteid=@id", con)
                    da1.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("prepac")
                    dr1 = da1.SelectCommand.ExecuteReader
                    dr1.Read()
                    Label2.Text = dr1(0)
                    Label2.Visible = True
                    TextBox2.Visible = False
                    con.Close()
                Catch ex As Exception

                End Try

                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    da2 = New SqlDataAdapter("select apmaterno from prepacientes where prepacienteid=@id", con)
                    da2.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("prepac")
                    dr2 = da2.SelectCommand.ExecuteReader
                    dr2.Read()
                    Label3.Text = dr2(0)
                    Label3.Visible = True
                    TextBox3.Visible = False
                    con.Close()
                Catch ex As Exception

                End Try

                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    da3 = New SqlDataAdapter("select fechanacimiento from prepacientes where prepacienteid=@id", con)
                    da3.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("prepac")
                    dr3 = da3.SelectCommand.ExecuteReader
                    dr3.Read()
                    Label4.Text = dr3(0)
                    Label4.Visible = True
                    TextBox4.Visible = False
                    con.Close()
                Catch ex As Exception

                End Try

                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    da4 = New SqlDataAdapter("select genero from prepacientes where prepacienteid=@id", con)
                    da4.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session("prepac")
                    dr4 = da4.SelectCommand.ExecuteReader
                    dr4.Read()
                    Label5.Text = dr4(0)
                    If Label5.Text = "2" Then
                        DropDownList1.Text = "Hombre"
                        DropDownList1.Enabled = False
                    ElseIf Label5.Text = "1" Then
                        DropDownList1.Text = "Mujer"
                        DropDownList1.Enabled = False
                    End If
                    con.Close()
                Catch ex As Exception

                End Try
            End If
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim da, da1, da2 As New SqlDataAdapter
        Dim appat, apmat As String
        If TextBox2.Visible = True Then
            If TextBox2.Text = "" Then
                appat = "XXXXXX"
            Else
                appat = TextBox2.Text
            End If
        Else
            If Label2.Text = "" Then
                appat = "XXXXXX"
            Else
                appat = Label2.Text
            End If
        End If

        If TextBox3.Visible = True Then
            If TextBox3.Text = "" Then
                apmat = "XXXXXX"
            Else
                apmat = TextBox3.Text
            End If
        Else
            If Label3.Text = "" Then
                apmat = "XXXXXX"
            Else
                apmat = Label3.Text
            End If
        End If
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da = New SqlDataAdapter("insert into paciente (fechacreacion,Nombres,ApPaterno,ApMaterno,talla,peso,temperatura,Nacimiento,Genero,Gesta,Para,Cesarea,Aborto,digestivo1,digestivo2,digestivo3,digestivo4,digestivo5,digestivo6,mail) values(getdate(),@nombre,@appat,@apmat,'0','0','0',@nacim,@genero,'0','0','0','0','0','0','0','0','0','0',@mail)", con)
            If TextBox1.Visible = True Then
                da.SelectCommand.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = TextBox1.Text
            Else
                da.SelectCommand.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = Label1.Text
            End If
            da.SelectCommand.Parameters.Add("@appat", SqlDbType.NVarChar).Value = appat
            da.SelectCommand.Parameters.Add("@apmat", SqlDbType.NVarChar).Value = apmat
            If TextBox4.Visible = True Then
                da.SelectCommand.Parameters.Add("@nacim", SqlDbType.DateTime).Value = CDate(TextBox4.Text)
            Else
                da.SelectCommand.Parameters.Add("@nacim", SqlDbType.DateTime).Value = CDate(Label4.Text)
            End If
            If DropDownList1.Text = "Hombre" Then
                da.SelectCommand.Parameters.Add("@genero", SqlDbType.NVarChar).Value = "2"
            ElseIf DropDownList1.Text = "Mujer" Then
                da.SelectCommand.Parameters.Add("@genero", SqlDbType.NVarChar).Value = "1"
            End If
            If TextBox5.Visible = True Then
                da.SelectCommand.Parameters.Add("@mail", SqlDbType.VarChar).Value = TextBox5.Text
            Else
                da.SelectCommand.Parameters.Add("@mail", SqlDbType.VarChar).Value = Label6.Text
            End If
            da.SelectCommand.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()

        Finally
            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                da1 = New SqlDataAdapter("insert into usuarios values((select max(id)+1 from usuarios),@nombre,@appat,@apmat,'Paciente',null,null,null,@mail,substring(@nombre,1,3)+substring(@appat,1,3)+substring(@apmat,1,3),cast(cast(@fecha as date) as nvarchar),'1','4')", con)
                If TextBox1.Visible = True Then
                    da1.SelectCommand.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = TextBox1.Text
                Else
                    da1.SelectCommand.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = Label1.Text
                End If
                
                da1.SelectCommand.Parameters.Add("@appat", SqlDbType.NVarChar).Value = appat
                da1.SelectCommand.Parameters.Add("@apmat", SqlDbType.NVarChar).Value = apmat
                If TextBox4.Visible = True Then
                    da1.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime).Value = CDate(TextBox4.Text)
                Else
                    da1.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime).Value = CDate(Label4.Text)
                End If
                If TextBox5.Visible = True Then
                    da1.SelectCommand.Parameters.Add("@mail", SqlDbType.VarChar).Value = TextBox5.Text
                Else
                    da1.SelectCommand.Parameters.Add("@mail", SqlDbType.VarChar).Value = Label6.Text
                End If
                da1.SelectCommand.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                If Session("prepac") IsNot Nothing Then
                    Try
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        da2 = New SqlDataAdapter("delete from prepacientes where prepacienteid=@pac", con)
                        da2.SelectCommand.Parameters.Add("@pac", SqlDbType.Int).Value = Session("prepac")
                        da2.SelectCommand.ExecuteNonQuery()
                        con.Close()
                    Catch ex As Exception
                    Finally
                        Response.Redirect("~/FinGSRS.aspx" & "?nombre=" & Label1.Text & "&appat=" & appat & "&apmat=" & apmat & "&fecnac='" & Label4.Text & "'")
                    End Try
                Else
                    Response.Redirect("~/FinGSRS.aspx" & "?nombre=" & TextBox1.Text & "&appat=" & appat & "&apmat=" & apmat & "&fecnac='" & TextBox4.Text & "'")
                End If
                


            End Try


        End Try
    End Sub
End Class