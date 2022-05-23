Imports Microsoft.Reporting.WinForms
Public Class AntiguedadSaldosForm

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        Try
            ' Cargar información de impresión de los Presupuestos
            Dim PagoFac As New PagoFacade
            Dim dtSource As DataTable = PagoFac.AntiguedadSaldos(App.Session.SessionID, Me.dtpFechaIni.Value, Me.dtpFechaFin.Value, upDwnDias.Value)
            'Definir parametros del informe
            Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
            Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))

            'Mostrar vista previa de los presupuestos
            Dim frm As New ReportForm
            frm.LocalReport.ReportEmbeddedResource = "Azteca.Windows.Tesoreria.Antiguedad de Saldos.rdlc"
            frm.LocalReport.DataSources.Add(New ReportDataSource("AntiguedadInfo", CType(dtSource, DataTable)))
            frm.LocalReport.SetParameters(Parametros)
            frm.Show("Contrarecibos")
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

    End Sub

End Class