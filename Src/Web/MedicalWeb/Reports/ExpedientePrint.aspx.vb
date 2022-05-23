Imports Azteca.Data
Imports Microsoft.Reporting.WebForms
Imports System.IO

Public Class ExpedientePrint
    Inherits System.Web.UI.Page
    Private IdPaciente As Integer

    Private Function GenerarPDF() As Byte()
        Dim Connection As IDbConnection = Nothing
        Try
            Connection = DataServices.OpenConnection()
            'Cargar información del expediente
            Dim fxExpediente As New FunctionSQL("Medicine", "fxExpedienteRPT", Connection, Nothing)
            fxExpediente.Parameters.Add("@IdPaciente", DbType.Int32).Value = IdPaciente
            Dim dtExpediente As DataTable = fxExpediente.GetTable()

            'Cargar información del expediente
            Dim fxEmpresa As New FunctionSQL("dbo", "fxEmpresasSEL", Connection, Nothing)
            fxEmpresa.Parameters.Add("@IdEmpresa", DbType.Int32).Value = 1
            fxEmpresa.Parameters.Add("@IdUsuario", DbType.Int32).Value = 1
            Dim dtEmpresa As DataTable = fxEmpresa.GetTable()


            'Cargar formato de factura asignado a la sucursal
            Dim Report As New LocalReport()
            Dim reader As TextReader = File.OpenText(Server.MapPath("Expediente.rdlc"))
            Report.LoadReportDefinition(reader)
            Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)

            Parametros.Add(New ReportParameter("TituloReporte", "Expediente Clínico"))
            'Parametros.Add(New ReportParameter("NombreCedula", NombreCedula))
            Report.SetParameters(Parametros)
            Report.DataSources.Add(New ReportDataSource("ReportData", dtExpediente))
            'Report.DataSources.Add(New ReportDataSource("Empresa", CType(getEmpresaTableRPT(), DataTable)))
            Report.DataSources.Add(New ReportDataSource("Empresa", dtEmpresa))
            '
            Dim mimeType As String = String.Empty
            Dim encoding As String = String.Empty
            Dim fileNameExtension As String = String.Empty

            Dim deviceInfo As String = _
              "<DeviceInfo>" + _
              "  <OutputFormat>PDF</OutputFormat>" & _
              "  <PageWidth>8.5in</PageWidth>" & _
              "  <PageHeight>11in</PageHeight>" & _
              "  <MarginTop>0.5in</MarginTop>" & _
              "  <MarginLeft>>0.5in</MarginLeft>" & _
              "  <MarginRight>>0.5in</MarginRight>" & _
              "  <MarginBottom>>0.5in</MarginBottom>" & _
              "</DeviceInfo>"
            '
            Dim warnings() As Warning = Nothing
            Dim streams() As String = Nothing
            Dim renderedBytes() As Byte = Report.Render("PDF", deviceInfo, mimeType, encoding, fileNameExtension, streams, warnings)
            reader.Close()
            reader.Dispose()
            'Dim writer As FileStream = File.OpenWrite("C:\Publica\Factura.pdf")
            'writer.Write(renderedBytes, 0, renderedBytes.Count - 1)
            'writer.Close()
            'writer.Dispose()
            Return renderedBytes
        Catch ex As Exception
            Throw New Exception("Error al descargar el expediente.", ex)
        End Try
    End Function


    Private Function getEmpresaTableRPT() As DataTable
        Dim LogoTable As New DataTable
        LogoTable.Columns.Add("Nombre", System.Type.GetType("System.String"))
        LogoTable.Columns.Add("Logo", System.Type.GetType("System.Byte[]"))

        Dim row As DataRow = LogoTable.NewRow
        row("Nombre") = "Empresa" ''App.DefaultCompany.NombreLargo
        row("Logo") = Nothing ''App.DefaultCompany.Logo
        LogoTable.Rows.Add(row)
        Return LogoTable
    End Function


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdPaciente = CInt(Request.QueryString("IdPaciente"))
        If Not Page.IsPostBack Then
            Dim ExpedientePDF As Byte() = GenerarPDF()
            '
            Response.ClearContent()
            Response.ContentType = "application/pdf"
            Response.AddHeader("content-length", ExpedientePDF.Length.ToString())
            Response.BufferOutput = True
            'Response.AddHeader("Content-Disposition", "attachment; filename=Expediente_" & IdPaciente & ".pdf")
            Response.AddHeader("content-disposition", "inline; filename=Expediente_" & IdPaciente & ".pdf")
            Response.BinaryWrite(ExpedientePDF)
            Response.End()
        End If
    End Sub


End Class