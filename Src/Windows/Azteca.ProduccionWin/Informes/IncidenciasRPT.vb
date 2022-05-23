Imports Microsoft.Reporting.WinForms

Public Class IncidenciasRPT

    Private Sub btnGenerar_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerar.Click
        'Obtenemos los datos del reporte
        Dim otFac As New OrdenTrabajoFacade
        Dim dtDataReport As DataTable

        'Cargar informacion del informe
        dtDataReport = otFac.GetInformeIncidencias(App.Session.SessionID, dtpFechaIni.Value, dtpFechaFin.Value)

        'Generar Parametros
        Dim Parametros As New List(Of ReportParameter)
        Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))
        Parametros.Add(New ReportParameter("FechaIni", dtpFechaIni.Value.ToString("dd/MM/yyyy")))
        Parametros.Add(New ReportParameter("FechaFin", dtpFechaFin.Value.ToString("dd/MM/yyyy")))

        'Configurar reporte
        Dim frmFacturas As New ReportForm
        frmFacturas.LocalReport.ReportEmbeddedResource = "Azteca.Windows.Produccion.IncidenciasRPT.rdlc"
        frmFacturas.LocalReport.DataSources.Add(New ReportDataSource("DataReport", dtDataReport))
        frmFacturas.LocalReport.SetParameters(Parametros)
        frmFacturas.Show("Informe - Seguimiento Orden de Trabajo")
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class