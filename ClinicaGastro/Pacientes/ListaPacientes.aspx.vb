Imports System.Data.SqlClient
Public Class ListaPacientes
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GridView1.DataSourceID = SqlDataSource1.ID
        GridView1.DataBind()

        Dim da As New SqlDataAdapter
        Dim ds As New DataSet

        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da = New SqlDataAdapter("select distinct prepacienteid as 'Noprepaciente', nombre+' '+appaterno+' '+apmaterno as 'Nombre', fechacreacion as 'FechaIngreso' from prepacientes", con)
            da.Fill(ds)
            GridView2.DataSource = ds.Tables(0)
            GridView2.DataBind()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        Session("Expediente") = GridView1.SelectedRow.Cells(0).Text
        MsgBox(Session("Expediente"))
        Response.Redirect("\Pacientes\ExpCompleto.aspx?Expediente={0}")


    End Sub


    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        
        GridView1.DataSourceID = SqlDataSource2.ID
        GridView1.DataBind()
    End Sub
    Protected Function checkLink(myid As Object) As String
        Dim myLinkString As String = String.Empty
       
        myLinkString = "~\NuevoPaciente.aspx"
              
            Return myLinkString

        
    End Function
   
End Class