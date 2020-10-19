Imports System.Data.SqlClient
Public Class EncuestaIngreso
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim da As New SqlDataadapter
        'Dim ds As New DataSet
        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    da = New SqlDataAdapter("", con)
        '    da.Fill(ds)
        '    Me.GridView1.DataSource = ds.Tables(0)
        '    Me.GridView1.DataBind()
        '    con.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        GridView1.DataSourceID = SqlDataSource1.ID
        GridView1.DataBind()

    End Sub

End Class