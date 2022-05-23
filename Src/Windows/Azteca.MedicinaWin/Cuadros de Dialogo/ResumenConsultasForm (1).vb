Imports Microsoft.Reporting.WinForms

Public Class ResumenConsultasForm

    Private Sub ResumenConsultasForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblEmpresa.Text = App.DefaultCompany.NombreLargo
        lblReporte.Text = "Resumen de Consultas"
        Dim Imagen As Byte() = App.DefaultCompany.Logo

        Dim ms As New System.IO.MemoryStream(Imagen)
        picLogoEmpresa.Image = System.Drawing.Image.FromStream(ms)
        ms.Close()

        dtpFechaIni.Value = Date.Today
        dtpFechaFin.Value = Date.Today
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        Try
            ' Cargar información de impresión
            Dim DoctorFac As New DoctorFacade
            Dim dtSource As DataTable = DoctorFac.ResumenConsultas(App.Session.SessionID, Me.dtpFechaIni.Value, Me.dtpFechaFin.Value)

            'Definir parametros del informe
            Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
            Parametros.Add(New ReportParameter("TituloReporte", "Resumen de Consultas Medicas por Periodo:[" & dtpFechaIni.Value.ToShortDateString & " al " & dtpFechaFin.Value.ToShortDateString & "]"))

            Dim frm As New Azteca.Windows.Forms.ReportForm
            frm.LocalReport.ReportEmbeddedResource = "Azteca.Windows.Medicina.ResumenConsultas.rdlc"
            frm.LocalReport.DataSources.Add(New ReportDataSource("Empresa", CType(getEmpresaTableRPT(), DataTable)))
            frm.LocalReport.DataSources.Add(New ReportDataSource("ResumenConsultas", CType(dtSource, DataTable)))

            frm.LocalReport.SetParameters(Parametros)
            frm.Show("Facturación")
        Catch ex As Exception
            Azteca.Windows.Forms.MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Function getEmpresaTableRPT() As DataTable
        Dim LogoTable As New DataTable
        LogoTable.Columns.Add("Nombre", System.Type.GetType("System.String"))
        LogoTable.Columns.Add("Logo", System.Type.GetType("System.Byte[]"))

        Dim row As DataRow = LogoTable.NewRow
        row("Nombre") = App.DefaultCompany.NombreLargo
        row("Logo") = App.DefaultCompany.Logo
        LogoTable.Rows.Add(row)
        Return LogoTable
    End Function
End Class