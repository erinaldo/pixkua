Imports Azteca.Business.Inventario
Imports Azteca.Business.Produccion
Imports Microsoft.Reporting.WinForms

Public Class UtilitarioCostosForm

    Dim seleccion As Boolean = False

    Private Sub Panel3_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Utilitario_de_Costos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub tlbActualizar_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles tlbActualizar.Click
        Call ActualizarListaArticulos()
    End Sub

    Private Sub ActualizarListaArticulos(ByVal categoria As String)
        Try
            Cursor = Cursors.WaitCursor
            Dim inventarioFac = New ArticuloStockFacade()
            bsArticulos.DataSource = inventarioFac.CargarArticulosUtilitario(App.Session.SessionID, App.DefaultSite.Identity, categoria)
            dtArticulos.Rebind(True)
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub ActualizarListaArticulos()
        Try
            Cursor = Cursors.WaitCursor
            Dim filtro As String
            If (rdbFiltroComprados.Checked) Then
                filtro = FiltroCategoria.Comprados
            ElseIf (rdgFiltroFabricados.Checked) Then
                filtro = FiltroCategoria.Fabricados
            Else
                filtro = FiltroCategoria.Todos
            End If
            Call ActualizarListaArticulos(filtro)
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub chkMostrarCategorias_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkMostrarCategorias.CheckedChanged
        dtArticulos.Splits(0).DisplayColumns("CostoMaterial").Visible = chkMostrarCategorias.Checked
        dtArticulos.Splits(0).DisplayColumns("CostoCarga").Visible = chkMostrarCategorias.Checked
        dtArticulos.Splits(0).DisplayColumns("CostoLabor").Visible = chkMostrarCategorias.Checked
        dtArticulos.Splits(0).DisplayColumns("CostoServicio").Visible = chkMostrarCategorias.Checked

        dtArticulos.Splits(0).DisplayColumns("NuevoCostoMaterial").Visible = chkMostrarCategorias.Checked
        dtArticulos.Splits(0).DisplayColumns("NuevoCostoCarga").Visible = chkMostrarCategorias.Checked
        dtArticulos.Splits(0).DisplayColumns("NuevoCostoLabor").Visible = chkMostrarCategorias.Checked
        dtArticulos.Splits(0).DisplayColumns("NuevoCostoServicio").Visible = chkMostrarCategorias.Checked
    End Sub


    Private Sub tlbRecalcular_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles tlbRecalcular.Click
        Try
            Dim dtItemsSelected = New DataTable
            Dim ArticuloFac = New ArticuloStockFacade()
            Dim count As Integer
            Dim rowsCount As Integer
            Dim progressPorc As Integer

            MsgWorking.Show(Me)
            dtArticulos.UpdateData()
            dtItemsSelected = CType(bsArticulos.DataSource, UtilitarioCostosDS.ArticulosDataTable).GetChanges()
            rowsCount = dtItemsSelected.Rows.Count
            If (rowsCount > 0) Then
                For Each item As DataRow In dtItemsSelected.Rows
                    
                    If (Boolean.Parse(item("Check").ToString())) Then
                        count += 1
                        progressPorc = 100 - CInt(((rowsCount - count) / rowsCount) * 100)
                        MsgWorking.SetProgress("Articulo: " & item("Codigo").ToString() & " - " & item("Descripcion").ToString(), progressPorc)

                        Dim numRow As Integer
                        numRow = bsArticulos.Find("IdArticuloStock", item("IdArticuloStock"))
                        Dim drvRow As DataRowView = CType(bsArticulos.Item(numRow), DataRowView)
                        Dim CostoInfo As New ArticuloCostoInfo()
                        CostoInfo = ArticuloFac.GetCostoByCategoria(App.Session.SessionID, App.DefaultSite.Identity, CInt(item("IdArticuloStock")), item("Categoria").ToString(), dtpFechaInicio.Value, dtpFechaFin.Value, chkUsarUltimaRecepcion.Checked, GetStatusDocumentos(), GetStatusProduccion())
                        drvRow("NuevoCostoMaterial") = CostoInfo.CostoMaterial
                        drvRow("NuevoCostoLabor") = CostoInfo.CostoLabor
                        drvRow("NuevoCostoServicio") = CostoInfo.CostoServicio
                        drvRow("NuevoCostoCarga") = CostoInfo.CostoCarga
                        drvRow("NuevoCostoActual") = CostoInfo.CostoTotal
                        drvRow("BaseCalculo") = CostoInfo.BaseCalculo
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Error al obtener los nuevos costos: " & ex.Message, "erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            dtArticulos.Rebind(True)
            MsgWorking.Close()
        End Try
    End Sub

    Private Function GetStatusDocumentos() As String
        Dim resStatus As String = String.Empty
        If (chkTodo.Checked) Then
            resStatus = CType(WorkflowSteps.Save, String) & "," & CType(WorkflowSteps.Apply, String) & _
                "," & CType(WorkflowSteps.Close, String) & "," & CType(WorkflowSteps.Cancel, String)
        Else
            If (chkGuardado.Checked) Then
                resStatus &= CType(WorkflowSteps.Save, String) & ","
            End If
            If (chkAplicado.Checked) Then
                resStatus &= CType(WorkflowSteps.Apply, String) & ","
            End If
            If (chkCerrado.Checked) Then
                resStatus &= CType(WorkflowSteps.Close, String) & ","
            End If
            If (chkCancelado.Checked) Then
                resStatus &= CType(WorkflowSteps.Cancel, String)
            End If
        End If
        Return resStatus
    End Function

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

    Private Sub chkCalcularPorTipo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCalcularPorTipo.CheckedChanged
        rdbComprados.Enabled = chkCalcularPorTipo.Checked
        rdbFabricados.Enabled = chkCalcularPorTipo.Checked
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub tlbInvertirSeleccion_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles tlbInvertirSeleccion.Click
        Try
            Cursor = Cursors.WaitCursor
            dtArticulos.UpdateData()
            For i As Integer = 0 To dtArticulos.RowCount - 1
                Dim drvRow As DataRowView = CType(bsArticulos.Item(i), DataRowView)
                drvRow("Check") = Not Boolean.Parse(drvRow("Check").ToString())
            Next i
            Call CambiarImagenInvertir()
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            Cursor = Cursors.Default
            dtArticulos.Rebind(True)
        End Try
    End Sub

    Private Sub CambiarImagenInvertir()
        seleccion = Not seleccion
        If (seleccion) Then
            tlbInvertirSeleccion.Image = My.Resources.DesSeleccionar_24x24
        Else
            tlbInvertirSeleccion.Image = My.Resources.SeleccionarTodo_24x24
        End If
    End Sub

    Private Sub rdgFiltroFabricados_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdgFiltroFabricados.CheckedChanged
        Call ActualizarListaArticulos(FiltroCategoria.Fabricados)
    End Sub

    Structure FiltroCategoria
        Const Fabricados = "F"
        Const Comprados = "C"
        Const Todos = "T"
    End Structure

    Private Sub rdbFiltroComprados_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbFiltroComprados.CheckedChanged
        Call ActualizarListaArticulos(FiltroCategoria.Comprados)
    End Sub

    Private Sub rdbFiltroTodos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbFiltroTodos.CheckedChanged
        Call ActualizarListaArticulos(FiltroCategoria.Todos)
    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub chkTodo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTodo.CheckedChanged
        chkGuardado.Enabled = Not chkTodo.Checked
        chkAplicado.Enabled = Not chkTodo.Checked
        chkRetenido.Enabled = Not chkTodo.Checked
        chkCerrado.Enabled = Not chkTodo.Checked
        chkCancelado.Enabled = Not chkTodo.Checked

        chkGuardado.Checked = chkTodo.Checked
        chkAplicado.Checked = chkTodo.Checked
        chkRetenido.Checked = chkTodo.Checked
        chkCerrado.Checked = chkTodo.Checked
        chkCancelado.Checked = chkTodo.Checked
    End Sub

    Private Sub tlbCerrar_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles tlbCerrar.Click
        Me.Close()
    End Sub

    Private Sub tlbGuardar_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles tlbGuardar.Click
        Cursor = Cursors.WaitCursor
        Try
            dtArticulos.UpdateData()
            Dim articulosCostos As New DataTable()
            Dim ArticuloFac As New ArticuloStockFacade()
            articulosCostos = CType(bsArticulos.DataSource, DataTable).GetChanges()
            ArticuloFac.GuardarCostosUtilitario(App.Session.SessionID, articulosCostos)
            Call ActualizarListaArticulos()
        Catch ex As Exception
            MessageBox.Show("Error al guardar los nuevos costos", "Mas detalles en el visor de sucesos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub tlbGuardar_CommandLinkAdded(sender As System.Object, e As C1.Win.C1Command.CommandLinkEventArgs) Handles tlbGuardar.CommandLinkAdded

    End Sub

    Private Sub DetalleDelCostoMaterialToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DetalleDelCostoMaterialToolStripMenuItem.Click

        Try
            Cursor = Cursors.WaitCursor

            Dim idArticuloStock As Integer = CInt(bsArticulos.Current("IdArticuloStock"))
            Dim Categoria As String = bsArticulos.Current("Categoria").ToString()
            Dim articuloFac As New ArticuloStockFacade()
            Dim dtDetalle As New DataTable
            Dim pathReport As String = String.Empty
            Dim title As String = String.Empty

            If (Categoria = "C") Then
                dtDetalle = articuloFac.GetCompraDetalleMaterial(App.Session.SessionID, idArticuloStock, dtpFechaInicio.Value, dtpFechaFin.Value, chkUsarUltimaRecepcion.Checked, GetStatusDocumentos(), GetStatusProduccion())
                pathReport = "Azteca.Windows.Inventario.UC_CompraDetMaterial.rdlc"
                title = "DETALLE DE ORDENES DE COMPRA"
            ElseIf (Categoria = "F") Then
                dtDetalle = articuloFac.GetVentaDetalleMaterial(App.Session.SessionID, idArticuloStock, dtpFechaInicio.Value, dtpFechaFin.Value, chkUsarUltimaRecepcion.Checked, GetStatusDocumentos(), GetStatusProduccion())
                pathReport = "Azteca.Windows.Inventario.UC_VentaDetMaterialRPT.rdlc"
                title = "DETALLE ORDENES DE TRABAJO"
            End If

            'Generar parametros
            Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
            Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))
            Parametros.Add(New ReportParameter("Titulo", title))

            'Configurar reporte
            Dim frmFacturas As New ReportForm
            frmFacturas.LocalReport.ReportEmbeddedResource = pathReport
            frmFacturas.LocalReport.DataSources.Add(New ReportDataSource("Detalle", dtDetalle))
            frmFacturas.LocalReport.SetParameters(Parametros)
            frmFacturas.Show("Detalle del Costo - Material")

        Catch ex As Exception
            MessageBox.Show("Error al obtener el detalle del costo del material: " & ex.Message, "error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Default
        End Try

    End Sub

    
    
    Private Sub cmdProcesarManoObra_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdProcesarManoObra.Click
        Try

            Dim MOForm = New ManoObraForm

            If (MOForm.DialogResult = System.Windows.Forms.DialogResult.OK) Then

            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub
End Class