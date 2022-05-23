Imports Microsoft.Reporting.WinForms
Imports Azteca.Business.Produccion

Public Class InventarioProcesoForm

    Private Sub InventarioProcesoForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub chkFiltroFechas_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkFiltroFechas.CheckedChanged
        dtpFechaInicio.Enabled = chkFiltroFechas.Checked
        dtpFechaFin.Enabled = chkFiltroFechas.Checked
    End Sub

    Private Sub chkTodo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTodo.CheckedChanged
        Dim value As Boolean = chkTodo.Checked
        chkGuardado.Checked = value
        chkAplicado.Checked = value
        chkRetenido.Checked = value
        chkCerrado.Checked = value
        chkCancelado.Checked = value
    End Sub

    Private Sub tlbImprimir_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles tlbImprimir.Click
        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            ImprimirInventarioSegmento()
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub ImprimirInventarioSegmento()
        'Cargar información del informe
        Dim AlmacenSvc As New AlmacenFacade
        Dim dtInventario As New DataTable
        Dim IdArticuloStockFabricado As Integer = 0
        Dim IdArticuloStockInsumo As Integer = 0
        Dim TipoReporte As String

        If (ArticuloSel.Key > 0 And rdbInsumos.Checked) Then
            IdArticuloStockInsumo = ArticuloSel.Key
        ElseIf (ArticuloSel.Key > 0 And rdbProductosFabricados.Checked) Then
            IdArticuloStockFabricado = ArticuloSel.Key
        End If

        If (rdbInsumos.Checked) Then
            TipoReporte = "Insumos"
        Else
            TipoReporte = "Fabricados"
        End If

        dtInventario = AlmacenSvc.GetInformeInventarioProduccionProceso(App.Session.SessionID, App.Session.User.Identity, App.DefaultSite.Identity, dtpFechaInicio.Value, dtpFechaFin.Value, IdArticuloStockInsumo, IdArticuloStockFabricado, GetStatusProduccion(), chkFiltroFechas.Checked)

        'Generar parametros
        Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
        Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))
        Parametros.Add(New ReportParameter("TipoReporte", TipoReporte))
        Parametros.Add(New ReportParameter("UsarFechas", chkFiltroFechas.Checked.ToString()))
        Parametros.Add(New ReportParameter("FechaIni", dtpFechaInicio.Value.ToShortDateString()))
        Parametros.Add(New ReportParameter("FechaFin", dtpFechaFin.Value.ToShortDateString()))
        'Configurar reporte
        Dim frmFacturas As New ReportForm
        frmFacturas.LocalReport.ReportEmbeddedResource = "Azteca.Windows.Inventario.InventarioProcesoRPT.rdlc"
        frmFacturas.LocalReport.DataSources.Add(New ReportDataSource("Inventario", dtInventario))
        frmFacturas.LocalReport.SetParameters(Parametros)
        frmFacturas.Show("Informe de Inventario Producción en Proceso")
    End Sub

    Private Function GetStatusProduccion() As String
        Dim resStatus As String = String.Empty
        If (chkTodo.Checked) Then
            resStatus = CType(WorkFlowStatus.Guardado, String) & "," & CType(WorkFlowStatus.Liberado, String) & "," & _
                CType(WorkFlowStatus.Cerrado, String) & "," & CType(WorkFlowStatus.EnEspera, String) & "," & resStatus & CType(WorkFlowStatus.Cancelado, String)
        Else
            If (chkGuardado.Checked) Then
                resStatus &= CType(WorkFlowStatus.Guardado, String) & ","
            End If
            If (chkAplicado.Checked) Then
                resStatus &= CType(WorkFlowStatus.Liberado, String) & ","
            End If
            If (chkCerrado.Checked) Then
                resStatus &= CType(WorkFlowStatus.Cerrado, String) & ","
            End If
            If (chkRetenido.Checked) Then
                resStatus &= CType(WorkFlowStatus.EnEspera, String) & ","
            End If
            If (chkCancelado.Checked) Then
                resStatus &= CType(WorkFlowStatus.Cancelado, String)
            End If
        End If
        Return resStatus
    End Function
End Class