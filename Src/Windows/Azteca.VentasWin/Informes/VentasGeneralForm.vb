Public Class VentasGeneralForm

    Private Sub cboSucursal_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub chkFiltroSucursal_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkFiltroSucursal.CheckedChanged
        cboEmpresas.Enabled = chkFiltroSucursal.Checked
        cboSucursal.Enabled = chkFiltroSucursal.Checked
    End Sub



    Private Sub tlbIImprimir_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles tlbIImprimir.Click
        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            ImprimirVentasGeneral()
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub ImprimirVentasGeneral()
        'Cargar información del informe
        Dim VentasFac As New VentaFacade
        Dim dtVentasGen As DataTable
        Dim IdSucursal As Integer = 0

        If (chkFiltroSucursal.Checked) Then
            IdSucursal = CInt(cboSucursal.SelectedValue)
        End If

        dtVentasGen = VentasFac.InformeVentasGeneral(App.Session.SessionID, dtpFechaIni.Value, dtpFechaFin.Value, ClienteSel.Key, ArticuloSel.Key, IdSucursal, App.DefaultSite.Identity)
        'Generar parametros
        Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
        Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))
        'Configurar reporte
        Dim frmFacturas As New ReportForm
        frmFacturas.LocalReport.ReportEmbeddedResource = "Azteca.Windows.Ventas.VentasGeneralRPT.rdlc"
        frmFacturas.LocalReport.DataSources.Add(New ReportDataSource("VentasGen", dtVentasGen))
        frmFacturas.LocalReport.SetParameters(Parametros)
        frmFacturas.Show("Informe de Ventas General")
    End Sub

    Private Sub VentasGeneralForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cboEmpresas.LoadList(App.Session.User.Identity)
    End Sub

    Private Sub cboEmpresas_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboEmpresas.SelectedIndexChanged

    End Sub
End Class