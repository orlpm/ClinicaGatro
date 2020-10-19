Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class ListaMedicos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If ConfigurationManager.AppSettings("nivelus") = 1 Then
            Me.menu2.Visible = True
        Else
            Me.menu2.Visible = False
        End If
    End Sub
    
    Private Sub GridView1_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles GridView1.RowDataBound
        For Each tc As TableCell In e.Row.Cells
            tc.Attributes("style") = "border-color-bottom: #c3cecc"
        Next
        If e.Row.RowType = DataControlRowType.DataRow Then
            Dim checkBox As CheckBox = TryCast(e.Row.Cells(0).Controls(0), CheckBox)
            checkBox.Enabled = True
        End If
    End Sub

    Private Sub GridView1_RowEditing(sender As Object, e As GridViewEditEventArgs) Handles GridView1.RowEditing
        
    End Sub

    
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        For Each fila As GridViewRow In GridView1.Rows
            Dim chkbox As CheckBox = TryCast(fila.Cells(0).Controls(0), CheckBox)
            If chkbox.Checked = False Then
                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    da = New SqlDataAdapter("update usuarios set activo=0 where usuario=@usuario and activo=1", con)
                    da.SelectCommand.Parameters.Add("@usuario", SqlDbType.VarChar).Value = fila.Cells(5).Text
                    da.SelectCommand.ExecuteNonQuery()
                    con.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    con.Close()
                Finally
                    Response.Redirect("ListaMedicos.aspx")
                End Try
            End If
        Next
    End Sub
End Class