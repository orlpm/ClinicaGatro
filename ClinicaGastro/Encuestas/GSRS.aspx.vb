Imports System.Data.SqlClient
Public Class GSRS
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    

    

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim preg1 As Int32 = 0
        Dim preg2 As Int32 = 0
        Dim preg3 As Int32 = 0
        Dim preg4 As Int32 = 0
        Dim preg5 As Int32 = 0
        Dim preg6 As Int32 = 0
        Dim preg7 As Int32 = 0
        Dim preg8 As Int32 = 0
        Dim preg9 As Int32 = 0
        Dim preg10 As Int32 = 0
        Dim preg11 As Int32 = 0
        Dim preg12 As Int32 = 0
        Dim preg13 As Int32 = 0
        Dim preg14 As Int32 = 0
        Dim preg15 As Int32 = 0
        Dim GSRS, CONSTIP, REFLUJO, DIARREA, INDIGESTION, DOLOR As Decimal

        Dim DA, da1, da2 As New SqlDataAdapter

        If DropDownList2.SelectedValue = "Sin molestias" Then
            preg1 = 1
        ElseIf DropDownList2.SelectedValue = "Ligero Malestar" Then
            preg1 = 2
        ElseIf DropDownList2.SelectedValue = "Malestar Leve" Then
            preg1 = 3
        ElseIf DropDownList2.SelectedValue = "Malestar Moderado" Then
            preg1 = 4
        ElseIf DropDownList2.SelectedValue = "Malestar Moderado a Severo" Then
            preg1 = 5
        ElseIf DropDownList2.SelectedValue = "Malestar Severo" Then
            preg1 = 6
        ElseIf DropDownList2.SelectedValue = "Malestar muy Severo" Then
            preg1 = 7
        End If

        If DropDownList8.SelectedValue = "Sin molestias" Then
            preg2 = 1
        ElseIf DropDownList8.SelectedValue = "Ligero Malestar" Then
            preg2 = 2
        ElseIf DropDownList8.SelectedValue = "Malestar Leve" Then
            preg2 = 3
        ElseIf DropDownList8.SelectedValue = "Malestar Moderado" Then
            preg2 = 4
        ElseIf DropDownList8.SelectedValue = "Malestar Moderado a Severo" Then
            preg2 = 5
        ElseIf DropDownList8.SelectedValue = "Malestar Severo" Then
            preg2 = 6
        ElseIf DropDownList8.SelectedValue = "Malestar muy Severo" Then
            preg2 = 7
        End If

        If DropDownList9.SelectedValue = "Sin molestias" Then
            preg3 = 1
        ElseIf DropDownList9.SelectedValue = "Ligero Malestar" Then
            preg3 = 2
        ElseIf DropDownList9.SelectedValue = "Malestar Leve" Then
            preg3 = 3
        ElseIf DropDownList9.SelectedValue = "Malestar Moderado" Then
            preg3 = 4
        ElseIf DropDownList9.SelectedValue = "Malestar Moderado a Severo" Then
            preg3 = 5
        ElseIf DropDownList9.SelectedValue = "Malestar Severo" Then
            preg3 = 6
        ElseIf DropDownList9.SelectedValue = "Malestar muy Severo" Then
            preg3 = 7
        End If

        If DropDownList10.SelectedValue = "Sin molestias" Then
            preg4 = 1
        ElseIf DropDownList10.SelectedValue = "Ligero Malestar" Then
            preg4 = 2
        ElseIf DropDownList10.SelectedValue = "Malestar Leve" Then
            preg4 = 3
        ElseIf DropDownList10.SelectedValue = "Malestar Moderado" Then
            preg4 = 4
        ElseIf DropDownList10.SelectedValue = "Malestar Moderado a Severo" Then
            preg4 = 5
        ElseIf DropDownList10.SelectedValue = "Malestar Severo" Then
            preg4 = 6
        ElseIf DropDownList10.SelectedValue = "Malestar muy Severo" Then
            preg4 = 7
        End If

        If DropDownList11.SelectedValue = "Sin molestias" Then
            preg5 = 1
        ElseIf DropDownList11.SelectedValue = "Ligero Malestar" Then
            preg5 = 2
        ElseIf DropDownList11.SelectedValue = "Malestar Leve" Then
            preg5 = 3
        ElseIf DropDownList11.SelectedValue = "Malestar Moderado" Then
            preg5 = 4
        ElseIf DropDownList11.SelectedValue = "Malestar Moderado a Severo" Then
            preg5 = 5
        ElseIf DropDownList11.SelectedValue = "Malestar Severo" Then
            preg5 = 6
        ElseIf DropDownList11.SelectedValue = "Malestar muy Severo" Then
            preg5 = 7
        End If

        If DropDownList12.SelectedValue = "Sin molestias" Then
            preg6 = 1
        ElseIf DropDownList12.SelectedValue = "Ligero Malestar" Then
            preg6 = 2
        ElseIf DropDownList12.SelectedValue = "Malestar Leve" Then
            preg6 = 3
        ElseIf DropDownList12.SelectedValue = "Malestar Moderado" Then
            preg6 = 4
        ElseIf DropDownList12.SelectedValue = "Malestar Moderado a Severo" Then
            preg6 = 5
        ElseIf DropDownList12.SelectedValue = "Malestar Severo" Then
            preg6 = 6
        ElseIf DropDownList12.SelectedValue = "Malestar muy Severo" Then
            preg6 = 7
        End If

        If DropDownList13.SelectedValue = "Sin molestias" Then
            preg7 = 1
        ElseIf DropDownList13.SelectedValue = "Ligero Malestar" Then
            preg7 = 2
        ElseIf DropDownList13.SelectedValue = "Malestar Leve" Then
            preg7 = 3
        ElseIf DropDownList13.SelectedValue = "Malestar Moderado" Then
            preg7 = 4
        ElseIf DropDownList13.SelectedValue = "Malestar Moderado a Severo" Then
            preg7 = 5
        ElseIf DropDownList13.SelectedValue = "Malestar Severo" Then
            preg7 = 6
        ElseIf DropDownList13.SelectedValue = "Malestar muy Severo" Then
            preg7 = 7
        End If

       
        If DropDownList14.SelectedValue = "Sin molestias" Then
            preg8 = 1
        ElseIf DropDownList14.SelectedValue = "Ligero Malestar" Then
            preg8 = 2
        ElseIf DropDownList14.SelectedValue = "Malestar Leve" Then
            preg8 = 3
        ElseIf DropDownList14.SelectedValue = "Malestar Moderado" Then
            preg8 = 4
        ElseIf DropDownList14.SelectedValue = "Malestar Moderado a Severo" Then
            preg8 = 5
        ElseIf DropDownList14.SelectedValue = "Malestar Severo" Then
            preg8 = 6
        ElseIf DropDownList14.SelectedValue = "Malestar muy Severo" Then
            preg8 = 7
        End If

        If DropDownList15.SelectedValue = "Sin molestias" Then
            preg9 = 1
        ElseIf DropDownList15.SelectedValue = "Ligero Malestar" Then
            preg9 = 2
        ElseIf DropDownList15.SelectedValue = "Malestar Leve" Then
            preg9 = 3
        ElseIf DropDownList15.SelectedValue = "Malestar Moderado" Then
            preg9 = 4
        ElseIf DropDownList15.SelectedValue = "Malestar Moderado a Severo" Then
            preg9 = 5
        ElseIf DropDownList15.SelectedValue = "Malestar Severo" Then
            preg9 = 6
        ElseIf DropDownList15.SelectedValue = "Malestar muy Severo" Then
            preg9 = 7
        End If

        If DropDownList16.SelectedValue = "Sin molestias" Then
            preg10 = 1
        ElseIf DropDownList16.SelectedValue = "Ligero Malestar" Then
            preg10 = 2
        ElseIf DropDownList16.SelectedValue = "Malestar Leve" Then
            preg10 = 3
        ElseIf DropDownList16.SelectedValue = "Malestar Moderado" Then
            preg10 = 4
        ElseIf DropDownList16.SelectedValue = "Malestar Moderado a Severo" Then
            preg10 = 5
        ElseIf DropDownList16.SelectedValue = "Malestar Severo" Then
            preg10 = 6
        ElseIf DropDownList16.SelectedValue = "Malestar muy Severo" Then
            preg10 = 7
        End If

        If DropDownList17.SelectedValue = "Sin molestias" Then
            preg11 = 1
        ElseIf DropDownList17.SelectedValue = "Ligero Malestar" Then
            preg11 = 2
        ElseIf DropDownList17.SelectedValue = "Malestar Leve" Then
            preg11 = 3
        ElseIf DropDownList17.SelectedValue = "Malestar Moderado" Then
            preg11 = 4
        ElseIf DropDownList17.SelectedValue = "Malestar Moderado a Severo" Then
            preg11 = 5
        ElseIf DropDownList17.SelectedValue = "Malestar Severo" Then
            preg11 = 6
        ElseIf DropDownList17.SelectedValue = "Malestar muy Severo" Then
            preg11 = 7
        End If

        If DropDownList18.SelectedValue = "Sin molestias" Then
            preg12 = 1
        ElseIf DropDownList18.SelectedValue = "Ligero Malestar" Then
            preg12 = 2
        ElseIf DropDownList18.SelectedValue = "Malestar Leve" Then
            preg12 = 3
        ElseIf DropDownList18.SelectedValue = "Malestar Moderado" Then
            preg12 = 4
        ElseIf DropDownList18.SelectedValue = "Malestar Moderado a Severo" Then
            preg12 = 5
        ElseIf DropDownList18.SelectedValue = "Malestar Severo" Then
            preg12 = 6
        ElseIf DropDownList18.SelectedValue = "Malestar muy Severo" Then
            preg12 = 7
        End If

        If DropDownList19.SelectedValue = "Sin molestias" Then
            preg13 = 1
        ElseIf DropDownList19.SelectedValue = "Ligero Malestar" Then
            preg13 = 2
        ElseIf DropDownList19.SelectedValue = "Malestar Leve" Then
            preg13 = 3
        ElseIf DropDownList19.SelectedValue = "Malestar Moderado" Then
            preg13 = 4
        ElseIf DropDownList19.SelectedValue = "Malestar Moderado a Severo" Then
            preg13 = 5
        ElseIf DropDownList19.SelectedValue = "Malestar Severo" Then
            preg13 = 6
        ElseIf DropDownList19.SelectedValue = "Malestar muy Severo" Then
            preg13 = 7
        End If

        If DropDownList20.SelectedValue = "Sin molestias" Then
            preg14 = 1
        ElseIf DropDownList20.SelectedValue = "Ligero Malestar" Then
            preg14 = 2
        ElseIf DropDownList20.SelectedValue = "Malestar Leve" Then
            preg14 = 3
        ElseIf DropDownList20.SelectedValue = "Malestar Moderado" Then
            preg14 = 4
        ElseIf DropDownList20.SelectedValue = "Malestar Moderado a Severo" Then
            preg14 = 5
        ElseIf DropDownList20.SelectedValue = "Malestar Severo" Then
            preg14 = 6
        ElseIf DropDownList20.SelectedValue = "Malestar muy Severo" Then
            preg14 = 7
        End If

        If DropDownList21.SelectedValue = "Sin molestias" Then
            preg15 = 1
        ElseIf DropDownList21.SelectedValue = "Ligero Malestar" Then
            preg15 = 2
        ElseIf DropDownList21.SelectedValue = "Malestar Leve" Then
            preg15 = 3
        ElseIf DropDownList21.SelectedValue = "Malestar Moderado" Then
            preg15 = 4
        ElseIf DropDownList21.SelectedValue = "Malestar Moderado a Severo" Then
            preg15 = 5
        ElseIf DropDownList21.SelectedValue = "Malestar Severo" Then
            preg15 = 6
        ElseIf DropDownList21.SelectedValue = "Malestar muy Severo" Then
            preg15 = 7
        End If

        GSRS = (preg1 + preg2 + preg3 + preg4 + preg5 + preg6 + preg7 + preg8 + preg9 + preg10 + preg11 + preg12 + preg13 + preg14 + preg15) / 15
        CONSTIP = (preg6 + preg7 + preg8) / 3
        DIARREA = (preg13 + preg14 + preg15) / 3
        REFLUJO = (preg1 + preg2) / 2
        INDIGESTION = (preg9 + preg10 + preg11 + preg12) / 4
        DOLOR = (preg3 + preg4 + preg5) / 3
        Try
            If con1.State = ConnectionState.Open Then
                con1.Close()
            End If
            con1.Open()
            da1 = New SqlDataAdapter("insert into prepacientes values((select folio+1 from foliosprepacientes),(select getdate()),@nombre,@appat,@apmat,cast(@nacim as date),@genero,@mail)", con1)
            da1.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar).Value = TextBox1.Text
            If String.IsNullOrEmpty(TextBox3.Text) Then
                da1.SelectCommand.Parameters.Add("@appat", SqlDbType.VarChar).Value = "XXXXXX"
            Else
                da1.SelectCommand.Parameters.Add("@appat", SqlDbType.VarChar).Value = TextBox3.Text
            End If
            If String.IsNullOrEmpty(TextBox2.Text) Then
                da1.SelectCommand.Parameters.Add("@apmat", SqlDbType.VarChar).Value = "XXXXXX"
            Else
                da1.SelectCommand.Parameters.Add("@apmat", SqlDbType.VarChar).Value = TextBox2.Text
            End If

            da1.SelectCommand.Parameters.Add("@nacim", SqlDbType.DateTime).Value = TextBox4.Text
            If DropDownList1.Text = "Hombre" Then
                da1.SelectCommand.Parameters.Add("@genero", SqlDbType.Int).Value = "2"
            ElseIf DropDownList1.Text = "Mujer" Then
                da1.SelectCommand.Parameters.Add("@genero", SqlDbType.Int).Value = "1"
            End If
            da1.SelectCommand.Parameters.Add("@mail", SqlDbType.VarChar).Value = TextBox5.Text
            da1.SelectCommand.ExecuteNonQuery()
            con1.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Try

                If CON.State = ConnectionState.Open Then
                    CON.Close()
                End If
                CON.Open()
                DA = New SqlDataAdapter("insert into gsrs values((select prepacienteid from prepacientes where nombre=@nombre and appaterno=@appaterno and apmaterno=@apmaterno and fechanacimiento=cast(@nacim as date)),@fechaing,@preg1,@preg2,@preg3,@preg4,@preg5,@preg6,@preg7,@preg8,@preg9,@preg10,@preg11,@preg12,@preg13,@preg14,@preg15,@reflujo,@abdom,@constip,@indig,@diarrea,@global)", con)
                DA.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar).Value = TextBox1.Text
                If String.IsNullOrEmpty(TextBox3.Text) Then
                    DA.SelectCommand.Parameters.Add("@appaterno", SqlDbType.VarChar).Value = "XXXXXX"
                Else
                    DA.SelectCommand.Parameters.Add("@appaterno", SqlDbType.VarChar).Value = TextBox3.Text
                End If
                If String.IsNullOrEmpty(TextBox2.Text) Then
                    DA.SelectCommand.Parameters.Add("@apmaterno", SqlDbType.VarChar).Value = "XXXXXX"
                Else
                    DA.SelectCommand.Parameters.Add("@apmaterno", SqlDbType.VarChar).Value = TextBox2.Text
                End If

                DA.SelectCommand.Parameters.Add("@nacim", SqlDbType.DateTime).Value = TextBox4.Text
                DA.SelectCommand.Parameters.Add("@fechaing", SqlDbType.DateTime).Value = DateTime.Now
                DA.SelectCommand.Parameters.AddWithValue("@PREG1", preg1)
                DA.SelectCommand.Parameters.AddWithValue("@preg2", preg2)
                DA.SelectCommand.Parameters.AddWithValue("@preg3", preg3)
                DA.SelectCommand.Parameters.AddWithValue("@preg4", preg4)
                DA.SelectCommand.Parameters.AddWithValue("@preg5", preg5)
                DA.SelectCommand.Parameters.AddWithValue("@preg6", preg6)
                DA.SelectCommand.Parameters.AddWithValue("@preg7", preg7)
                DA.SelectCommand.Parameters.AddWithValue("@preg8", preg8)
                DA.SelectCommand.Parameters.AddWithValue("@preg9", preg9)
                DA.SelectCommand.Parameters.AddWithValue("@preg10", preg10)
                DA.SelectCommand.Parameters.AddWithValue("@preg11", preg11)
                DA.SelectCommand.Parameters.AddWithValue("@preg12", preg12)
                DA.SelectCommand.Parameters.AddWithValue("@preg13", preg13)
                DA.SelectCommand.Parameters.AddWithValue("@preg14", preg14)
                DA.SelectCommand.Parameters.AddWithValue("@preg15", preg15)
                DA.SelectCommand.Parameters.AddWithValue("@reflujo", REFLUJO)
                DA.SelectCommand.Parameters.AddWithValue("@abdom", DOLOR)
                DA.SelectCommand.Parameters.AddWithValue("@constip", CONSTIP)
                DA.SelectCommand.Parameters.AddWithValue("@indig", INDIGESTION)
                DA.SelectCommand.Parameters.AddWithValue("@diarrea", DIARREA)
                DA.SelectCommand.Parameters.AddWithValue("@global", GSRS)
                DA.SelectCommand.ExecuteNonQuery()
                CON.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
                CON.Close()
            Finally
                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    da2 = New SqlDataAdapter("update foliosprepacientes set folio+=1", con)
                    da2.SelectCommand.ExecuteNonQuery()
                    con.Close()
                Catch ex As Exception
                Finally
                    Response.Redirect("/default.aspx", False)
                End Try

                '    End Try
                'End Try

                'Try
                '    If con1.State = ConnectionState.Open Then
                '        con1.Close()
                '    End If
                '    con1.Open()
                '    da2 = New SqlDataAdapter("insert into usuarios values((select max(id)+1 from usuarios) ,@nombre,@appat,@apmat,'Paciente',null,null,null,null,substring(@nombre,1,3)+substring(@appat,1,3)+substring(@apmat,1,3),cast(cast(@fecha as date) as nvarchar),'1','4')", con1)
                '    da2.SelectCommand.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = TextBox1.Text
                '    If TextBox2.Text = "" Then
                '        da2.SelectCommand.Parameters.Add("@appat", SqlDbType.NVarChar).Value = "XXXXXX"
                '    Else
                '        da2.SelectCommand.Parameters.Add("@appat", SqlDbType.NVarChar).Value = TextBox3.Text
                '    End If
                '    If TextBox3.Text = "" Then
                '        da2.SelectCommand.Parameters.Add("@apmat", SqlDbType.NVarChar).Value = "XXXXXX"
                '    Else
                '        da2.SelectCommand.Parameters.Add("@apmat", SqlDbType.NVarChar).Value = TextBox2.Text
                '    End If

                '    da2.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime).Value = CDate(TextBox4.Text)
                '    da2.SelectCommand.ExecuteNonQuery()
                '    con1.Close()
                'Catch ex As Exception
                '    MsgBox(ex.Message)
                'Finally

            End Try
        End Try
    End Sub
End Class