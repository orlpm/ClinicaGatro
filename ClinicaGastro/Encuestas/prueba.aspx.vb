Imports System
Imports System.Configuration
Imports System.Data
Imports System.Linq
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.HtmlControls
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Xml.Linq

' include iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.html.simpleparser
Imports iTextSharp.text.pdf
Imports System.Text
Imports System.IO
Public Class prueba
    Inherits System.Web.UI.Page
    Private datapdf As New DataTable()
    Public Overrides Sub VerifyRenderingInServerForm(ByVal control As System.Web.UI.Control)
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        datapdf.Columns.Add("ID", GetType(Integer))
        datapdf.Columns.Add("Nombre", GetType(String))
        datapdf.Columns.Add("Dirección", GetType(String))
        datapdf.Columns.Add("Fecha", GetType(DateTime))

        '
        ' Here we add five DataRows.
        '
        datapdf.Rows.Add(25, "José", "México", DateTime.Now)
        datapdf.Rows.Add(50, "DeveloperJI", "Distrito Federal", DateTime.Now)
        datapdf.Rows.Add(10, "Juan", "Morelos", DateTime.Now)
        datapdf.Rows.Add(21, "Fernanda", "Aguascalientes", DateTime.Now)
        datapdf.Rows.Add(100, "Alejandra", "Hidalgo", DateTime.Now)

        GridView1.DataSource = datapdf
        GridView1.DataBind()
    End Sub

    Protected Sub btnExportasPDF_Click(sender As Object, e As EventArgs) Handles btnExportasPDF.Click
        If Not IsPostBack Then
            Dim sw As New StringWriter()
            Dim hw As New HtmlTextWriter(sw)
            Response.ContentType = "application/pdf"
            Response.AddHeader("content-disposition", "attachment;filename=TestPage.pdf")
            Response.Cache.SetCacheability(HttpCacheability.NoCache)

            exporta.RenderControl(hw)
            Dim sr As New StringReader(sw.ToString())
            Dim pdfDoc As New Document(PageSize.A4, 10.0F, 10.0F, 100.0F, 0.0F)
            Dim htmlparser As New HTMLWorker(pdfDoc)
            PdfWriter.GetInstance(pdfDoc, Response.OutputStream)
            pdfDoc.Open()
            htmlparser.Parse(sr)
            pdfDoc.Close()



            Response.Write(pdfDoc)

            Response.Close()
        End If


        




    End Sub
End Class