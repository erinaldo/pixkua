Imports Microsoft.Reporting.WinForms

Public Class SiguimientoOTFormRpt

    Public Overloads Function ShowDialog(ByVal owner As Form) As DialogResult


        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub SiguimientoOTFormRpt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

       
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnGenerar_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerar.Click
        'Obtenemos los datos del reporte
        Dim otFac As New OrdenTrabajoFacade
        Dim dtDataReport As DataTable

        'Cargar informacion del informe
        dtDataReport = otFac.GetInformeSeguimiento(App.Session.SessionID, dtpFechaIni.Value, dtpFechaFin.Value)

        'Generar Parametros
        Dim Parametros As New List(Of ReportParameter)
        Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))
        Parametros.Add(New ReportParameter("FechaIni", dtpFechaIni.Value.ToString("dd/MM/yyyy")))
        Parametros.Add(New ReportParameter("FechaFin", dtpFechaFin.Value.ToString("dd/MM/yyyy")))

        'Configurar reporte
        Dim frmFacturas As New ReportForm
        frmFacturas.LocalReport.ReportEmbeddedResource = "Azteca.Windows.Produccion.SeguimientoOT_RPT.rdlc"
        frmFacturas.LocalReport.DataSources.Add(New ReportDataSource("DataSeguimiento", dtDataReport))
        frmFacturas.LocalReport.SetParameters(Parametros)
        frmFacturas.Show("Informe - Seguimiento Orden de Trabajo")
    End Sub
End Class