Imports Microsoft.Reporting.WinForms

Public Class ExistenciasForm

    Private Sub ImprimirInventarioActual()
        'Cargar información del informe
        Dim AlmacenSvc As New AlmacenFacade
        Dim dtInventario As New DataTable
        If (chkMostrarExistenciasCero.Checked = True) Then
            dtInventario = AlmacenSvc.GetInformeInventarioActualAll(App.Session.SessionID, CInt(cboArea.SelectedValue), CInt(cboAlmacen.SelectedValue), App.DefaultSite.Identity)
        Else
            dtInventario = AlmacenSvc.GetInformeInventarioActual(App.Session.SessionID, CInt(cboArea.SelectedValue), CInt(cboAlmacen.SelectedValue))
        End If


        'Generar parametros
        Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
        Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))
        Parametros.Add(New ReportParameter("Area", cboArea.Text))
        Parametros.Add(New ReportParameter("IncluirCostoEstandar", chkIncluirCostoEstandar.Checked.ToString))
        Parametros.Add(New ReportParameter("IncluirExistenciaCero", chkMostrarExistenciasCero.Checked.ToString))
        'Configurar reporte
        Dim frmFacturas As New ReportForm
        frmFacturas.LocalReport.ReportEmbeddedResource = "Azteca.Windows.Inventario.InventarioActualRPT.rdlc"


        frmFacturas.LocalReport.DataSources.Add(New ReportDataSource("Inventario", dtInventario))
        frmFacturas.LocalReport.SetParameters(Parametros)
        frmFacturas.Show("Informe de Inventario")
    End Sub

    Private Sub ImprimirHistorico()
        'Cargar información del informe
        Dim AlmacenSvc As New AlmacenFacade
        Dim dtInventario As DataTable = AlmacenSvc.GetInformeInventarioHistorico(App.Session.SessionID, dtpFechaIni.Value, dtpFechaFin.Value, CInt(cboArea.SelectedValue), CInt(cboAlmacen.SelectedValue))
        'Generar parametros
        Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
        Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))
        Parametros.Add(New ReportParameter("Area", cboArea.Text))
        Parametros.Add(New ReportParameter("FechaIni", dtpFechaIni.Value.ToString("dd/MM/yyyy")))
        Parametros.Add(New ReportParameter("FechaFin", dtpFechaFin.Value.ToString("dd/MM/yyyy")))
        'Configurar reporte
        Dim frmFacturas As New ReportForm
        frmFacturas.LocalReport.ReportEmbeddedResource = "Azteca.Windows.Inventario.InventarioHistRPT.rdlc"
        frmFacturas.LocalReport.DataSources.Add(New ReportDataSource("Inventario", dtInventario))
        frmFacturas.LocalReport.SetParameters(Parametros)
        frmFacturas.Show("Informe de Inventario")
    End Sub

    Private Sub ExistenciasForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dtpFechaIni.Value = Date.Today
            dtpFechaFin.Value = Date.Today
            cboArea.LoadListByUsuario(App.Session.User.Identity)
        Catch ex As Exception
            MsgInfo.Show(ex)
            Close()
        End Try
    End Sub

    Private Sub rdbActual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbActual.CheckedChanged
        dtpFechaIni.Enabled = False
        dtpFechaFin.Enabled = False
    End Sub

    Private Sub rdbHistorico_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbHistorico.CheckedChanged
        dtpFechaIni.Enabled = True
        dtpFechaFin.Enabled = True
    End Sub

    Private Sub cboArea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboArea.SelectedIndexChanged
        If cboArea.SelectedIndex >= 0 Then
            Try
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                cboAlmacen.LoadListByArea(CInt(cboArea.SelectedValue), App.Session.User.Identity, TipoAccesoAlmacen.Lectura)
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdImprimir.Click
        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            If rdbActual.Checked Then
                ImprimirInventarioActual()
            Else
                ImprimirHistorico()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub
End Class