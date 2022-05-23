Public Class GeneradorOrdenesForm
    Private Requisiciones As GeneradorOrdenesDS.RequisicionesDataTable
    Private Proveedores As GeneradorOrdenesDS.ProveedoresDataTable
    Private Ordenes As GeneradorOrdenesDS
    Private Centrales As DataTable

#Region "Metodos Privados"

    Private Function ProveedoresAsignados() As Boolean
        Dim vwNoAsignados As New DataView(Proveedores, "IdProveedor=0", String.Empty, DataViewRowState.CurrentRows)
        Return Not vwNoAsignados.Count > 0
    End Function

    Private Function GetRequisicionesSel() As GeneradorOrdenesDS.RequisicionesDataTable
        Dim RequisicionesSel As New GeneradorOrdenesDS.RequisicionesDataTable
        Dim Selected = From R In Requisiciones
                     Where R.Sel = True

        For Each dr In Selected
            RequisicionesSel.ImportRow(dr)
        Next
        Return RequisicionesSel
    End Function

    Private Sub AsignarProveedores(requisiciones As GeneradorOrdenesDS.RequisicionesDataTable)
        Dim OrdenFac As New OrdenFacade
        Proveedores = OrdenFac.AsignarProveedores(App.Session.SessionID, requisiciones)
        bsProveedores.DataSource = Proveedores
        grdProveedores.Rebind(True)
    End Sub

    Private Sub CargarRequisiciones()
        Dim RequisicionFac As New RequisicionFacade
        Requisiciones = RequisicionFac.PendientesList(App.Session.SessionID, CInt(cboCentral.SelectedValue), Date.Today.AddDays(-180), Date.Today)
        bsRequisiciones.DataSource = Requisiciones
        grdRequisiciones.Rebind(True)
    End Sub

    Private Sub GenerarOrdenes()
        Ordenes = New GeneradorOrdenesDS
        '
        Dim RequisicionesSel As GeneradorOrdenesDS.RequisicionesDataTable = GetRequisicionesSel()
        'Asignar datos de proveedor a las requisiciones
        For Each drRequisicion As GeneradorOrdenesDS.RequisicionesRow In RequisicionesSel
            Dim drProveedor As GeneradorOrdenesDS.ProveedoresRow = Proveedores.FindByIdZonaCompraIdServicioIdArticuloStock(drRequisicion.IdZonaCompra, drRequisicion.IdServicio, drRequisicion.IdArticuloStock)
            With drRequisicion
                .IdProveedor = drProveedor.IdProveedor
                .CodigoProveedor = drProveedor.CodigoProveedor
                .NombreProveedor = drProveedor.NombreProveedor
                'Si las unidades de medida de la requisición y la del proveedor son distintias, realizar conversión
                If .IdUnidadMedida <> drProveedor.IdUnidadMedida Then
                    Dim UnidadMedidaFac As New Azteca.Business.Inventario.UnidadMedidaFacade
                    Try
                        .Cantidad = UnidadMedidaFac.ConvertirCantidad(App.Session.SessionID, .Cantidad, .IdUnidadMedida, drProveedor.IdUnidadMedida)
                    Catch ex As Exception
                        Throw New Azteca.Kernel.BusinessStructure.BusinessException("Error al convertir la unidad de medida del artículo: " & drRequisicion.Codigo & "-" & drRequisicion.Descripcion, ex)
                    End Try
                    .IdUnidadMedida = drProveedor.IdUnidadMedida
                    .UnidadMedida = drProveedor.UnidadMedida
                End If
                .PrecioUnitario = drProveedor.PrecioUnitario
                .IdDivisa = drProveedor.IdDivisa
                .Divisa = drProveedor.Divisa
                .IdImpuesto1 = drProveedor.IdImpuesto1
                .IdImpuesto2 = drProveedor.IdImpuesto2
                .IdImpuesto3 = drProveedor.IdImpuesto3
                .Impuesto1 = drProveedor.Impuesto1
                .Impuesto2 = drProveedor.Impuesto2
                .Impuesto3 = drProveedor.Impuesto3
                .IdRetencion1 = drProveedor.IdRetencion1
                .IdRetencion2 = drProveedor.IdRetencion2
                .IdRetencion3 = drProveedor.IdRetencion3
                .Retencion1 = drProveedor.Retencion1
                .Retencion2 = drProveedor.Retencion2
                .Retencion3 = drProveedor.Retencion3
            End With
        Next

        Dim Documentos = From R In RequisicionesSel
                      Group By R.IdProveedor, R.CodigoProveedor, R.NombreProveedor, R.IdDivisa, R.Divisa, R.IdCentroRecepcion, R.CentroRecepcion, R.IdCentralCompras, R.CentralCompras, R.IdZonaCompra, R.ZonaCompra
                      Into Details = Group

        Dim OrdenCounter As Integer = 0
        For Each Orden In Documentos
            OrdenCounter += 1
            'Crear registro para título de la orden
            Dim drOrden As GeneradorOrdenesDS.OrdenesTitRow = Ordenes.OrdenesTit.NewOrdenesTitRow
            With drOrden
                .IdOrden = OrdenCounter
                .IdProveedor = Orden.IdProveedor
                .CodigoProveedor = Orden.CodigoProveedor
                .NombreProveedor = Orden.NombreProveedor
                .IdDivisa = Orden.IdDivisa
                .Divisa = Orden.Divisa
                .IdCentroRecepcion = Orden.IdCentroRecepcion
                .CentroRecepcion = Orden.CentroRecepcion
                .IdCentralCompras = Orden.IdCentralCompras
                .CentralCompras = Orden.CentralCompras
                .IdZonaCompra = Orden.IdZonaCompra
                .ZonaCompra = Orden.ZonaCompra
            End With
            Ordenes.OrdenesTit.AddOrdenesTitRow(drOrden)
            'Crear registros de detalle
            For Each Detail In Orden.Details
                Dim drPartida As GeneradorOrdenesDS.OrdenesDetRow = Ordenes.OrdenesDet.NewOrdenesDetRow
                With drPartida
                    .IdOrden = OrdenCounter
                    .IdArticuloStock = Detail.IdArticuloStock
                    .IdServicio = Detail.IdServicio
                    .Cantidad = Detail.Cantidad
                    .IdUnidadMedida = Detail.IdUnidadMedida
                    .PrecioUnitario = Detail.PrecioUnitario
                    .IdImpuesto1 = Detail.IdImpuesto1
                    .IdImpuesto2 = Detail.IdImpuesto2
                    .IdImpuesto3 = Detail.IdImpuesto3
                    .IdRetencion1 = Detail.IdRetencion1
                    .IdRetencion2 = Detail.IdRetencion2
                    .IdRetencion3 = Detail.IdRetencion3
                    .Codigo = Detail.Codigo
                    .Descripcion = Detail.Descripcion
                    .UnidadMedida = Detail.UnidadMedida
                    .Impuesto1 = Detail.Impuesto1
                    .Impuesto2 = Detail.Impuesto2
                    .Impuesto3 = Detail.Impuesto3
                    .Retencion1 = Detail.Retencion1
                    .Retencion2 = Detail.Retencion2
                    .Retencion3 = Detail.Retencion3
                    .IdPresupuesto = Detail.IdPresupuesto
                    .IdCategoriaPresupuestal = Detail.IdCategoriaPresupuestal
                    .IdRequisicion = Detail.IdRequisicion
                End With
                Ordenes.OrdenesDet.AddOrdenesDetRow(drPartida)
            Next
        Next
        '
        bsOrdenes.DataSource = Ordenes.OrdenesTit
        grdOrdenes.Rebind(True)
        bsOrdenesDet.DataSource = Ordenes.OrdenesDet
        grdOrdenesDet.Rebind(True)
    End Sub

    Private Sub GuardarOdenes()
        Dim OrdenFac As New OrdenFacade
        Ordenes = OrdenFac.GenerarOrdenes(App.Session.SessionID, App.DefaultSite.Identity, Ordenes)
        bsOrdenes.DataSource = Ordenes.OrdenesTit
        grdOrdenes.Rebind(True)
        bsOrdenesDet.DataSource = Ordenes.OrdenesDet
        grdOrdenesDet.Rebind(True)
    End Sub

#End Region

#Region "Implementacion"

    Private Sub GeneradorOrdenesForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Dim CentralFac As New CentralFacade
            Centrales = CentralFac.List(App.Session.SessionID, App.DefaultCompany.Identity)
            bsCentrales.DataSource = Centrales
            cboCentral.Rebind(True)
            If bsCentrales.Count > 0 Then
                cboCentral.SelectedIndex = 0
                CargarRequisiciones()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnAtras_Click(sender As System.Object, e As System.EventArgs) Handles btnAtras.Click
        If tabGenerador.SelectedIndex >= 1 Then tabGenerador.SelectedIndex -= 1
        btnAtras.Visible = Not (tabGenerador.SelectedIndex = 0)
        If tabGenerador.SelectedIndex < 2 Then
            btnSiguiente.Text = "Siguiente >"
        Else
            btnSiguiente.Text = "Generar"
        End If
        If tabGenerador.SelectedIndex = 1 Then
            grdProveedores.Refresh()
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As System.Object, e As System.EventArgs) Handles btnSiguiente.Click
        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            If tabGenerador.SelectedIndex = 0 Then 'La pantalla actual es la selección de requisiciones
                Dim RequisicionesSel As GeneradorOrdenesDS.RequisicionesDataTable = GetRequisicionesSel()
                If RequisicionesSel.Count > 0 Then
                    AsignarProveedores(RequisicionesSel)
                Else
                    MessageBox.Show("Debe seleccionar al menos una requisición", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If
            ElseIf tabGenerador.SelectedIndex = 1 Then
                If ProveedoresAsignados() Then
                    GenerarOrdenes()
                Else
                    MessageBox.Show("Debe asignar un proveedor a todos los artículos y servicios", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If
            Else
                GuardarOdenes()
                btnAtras.Visible = False
                btnSiguiente.Visible = False
                btnCancelar.Visible = False
                btnCerrar.Visible = True
                grdOrdenes.Splits(0).DisplayColumns("X").Visible = True
                If bsOrdenes.Count > 0 Then
                    Return
                Else
                    DialogResult = System.Windows.Forms.DialogResult.OK
                End If
            End If
            '
            If tabGenerador.SelectedIndex <= 1 Then tabGenerador.SelectedIndex += 1
            btnAtras.Visible = Not (tabGenerador.SelectedIndex = 0)
            If tabGenerador.SelectedIndex < 2 Then
                btnSiguiente.Text = "Siguiente >"
            Else
                btnSiguiente.Text = "Generar"
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

#End Region

#Region "Implementacion Requisiciones"

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        If cboCentral.SelectedIndex >= 0 Then
            Try
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                btnActualizar.Enabled = False
                CargarRequisiciones()
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
                btnActualizar.Enabled = True
            End Try
        End If
    End Sub

    Private Sub cboCentral_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cboCentral.SelectedValueChanged
        bsRequisiciones.DataSource = Nothing
        grdRequisiciones.Rebind(True)
    End Sub

    Private Sub btnInvReq_Click(sender As System.Object, e As System.EventArgs) Handles btnInvReq.Click
        Try
            For Each dr As GeneradorOrdenesDS.RequisicionesRow In Requisiciones
                dr.Sel = Not dr.Sel
            Next
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

#End Region

#Region "Implementacion Proveedores"

    Private Sub grdProveedores_BeforeColUpdate(sender As Object, e As C1.Win.C1TrueDBGrid.BeforeColUpdateEventArgs) Handles grdProveedores.BeforeColUpdate
        Try
            Dim ProveedorFac As New ProveedorFacade
            If grdProveedores.Columns("Código Prov.").Text.Trim = String.Empty Then Return
            Dim Codigo As String = grdProveedores.Columns("Código Prov.").Text.Trim
            Dim IdZonaCompra As Integer = CInt(grdProveedores.Columns("IdZonaCompra").Value)
            If ProveedorFac.Exists(App.Session.SessionID, Codigo, App.DefaultSite.Identity) Then
                Dim drvPartida As DataRowView = CType(bsProveedores.Current, DataRowView)
                Dim IdProveedor As Integer = ProveedorFac.GetIDByCode(Codigo, App.DefaultSite.Identity)
                Dim IdArticuloStock As Integer = CInt(drvPartida("IdArticuloStock"))
                Dim IdServicio As Integer = CInt(drvPartida("IdServicio"))
                If IdArticuloStock > 0 Then
                    Dim ArticuloInf As CompraArticuloInfo = ProveedorFac.CargarArticuloFromCache(App.Session.SessionID, IdZonaCompra, IdProveedor, IdArticuloStock)
                    If ArticuloInf IsNot Nothing Then
                        'Checar que el artículo no se encuentre en otra partida
                        With ArticuloInf
                            drvPartida("IdProveedor") = IdProveedor
                            drvPartida("NombreProveedor") = .NombreProveedor
                            drvPartida("IdUnidadMedida") = .IdUnidadMedida
                            drvPartida("IdDivisa") = .IdDivisa
                            drvPartida("IdImpuesto1") = .IdImpuesto1
                            drvPartida("IdImpuesto2") = .IdImpuesto2
                            drvPartida("IdImpuesto3") = .IdImpuesto3
                            drvPartida("IdRetencion1") = .IdRetencion1
                            drvPartida("IdRetencion2") = .IdRetencion2
                            drvPartida("IdRetencion3") = .IdRetencion3
                            grdProveedores.Columns("UnidadMedida").Value = .UnidadMedida
                            grdProveedores.Columns("Precio U.").Value = .Costo
                            grdProveedores.Columns("Divisa").Text = .Divisa
                            grdProveedores.Columns("Impuesto1").Text = .Impuesto1
                            grdProveedores.Columns("Impuesto2").Text = .Impuesto2
                            grdProveedores.Columns("Impuesto3").Text = .Impuesto3
                            grdProveedores.Columns("Retencion1").Text = .Retencion1
                            grdProveedores.Columns("Retencion2").Text = .Retencion2
                            grdProveedores.Columns("Retencion3").Text = .Retencion3
                        End With
                    Else
                        MessageBox.Show("El proveedor seleccionado no tiene asignado éste artículo." & ControlChars.NewLine & "De clic al botón de buscar para ver o modificar la lista de proveedores asignados al artículo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        e.Cancel = True
                    End If
                ElseIf IdServicio > 0 Then
                    Dim ServicioInf As CompraServicioInfo = ProveedorFac.CargarServicioFromCache(App.Session.SessionID, IdZonaCompra, IdProveedor, IdServicio)
                    If ServicioInf IsNot Nothing Then
                        With ServicioInf
                            drvPartida("IdProveedor") = IdProveedor
                            drvPartida("NombreProveedor") = .NombreProveedor
                            drvPartida("IdDivisa") = .IdDivisa
                            drvPartida("IdImpuesto1") = .IdImpuesto1
                            drvPartida("IdImpuesto2") = .IdImpuesto2
                            drvPartida("IdImpuesto3") = .IdImpuesto3
                            drvPartida("IdRetencion1") = .IdRetencion1
                            drvPartida("IdRetencion2") = .IdRetencion2
                            drvPartida("IdRetencion3") = .IdRetencion3
                            grdProveedores.Columns("Precio U.").Value = .Costo
                            grdProveedores.Columns("Divisa").Text = .Divisa
                            grdProveedores.Columns("Impuesto1").Text = .Impuesto1
                            grdProveedores.Columns("Impuesto2").Text = .Impuesto2
                            grdProveedores.Columns("Impuesto3").Text = .Impuesto3
                            grdProveedores.Columns("Retencion1").Text = .Retencion1
                            grdProveedores.Columns("Retencion2").Text = .Retencion2
                            grdProveedores.Columns("Retencion3").Text = .Retencion3
                        End With
                    Else
                        MessageBox.Show("El proveedor seleccionado no tiene asignado éste servicio." & ControlChars.NewLine & "De clic al botón de buscar para ver o modificar la lista de proveedores asignados al servicio.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        e.Cancel = True
                    End If
                End If
            Else
                MessageBox.Show("El código de artículo no existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                e.Cancel = True
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdProveedores_ButtonClick(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdProveedores.ButtonClick
        Try
            Dim ProveedorFac As New ProveedorFacade
            Dim IdZonaCompra As Integer = CInt(grdProveedores.Columns("IdZonaCompra").Value)
            Dim drvPartida As DataRowView = CType(bsProveedores.Current, DataRowView)
            Dim IdArticuloStock As Integer = CInt(drvPartida("IdArticuloStock"))
            Dim IdServicio As Integer = CInt(drvPartida("IdServicio"))

            If e.Column.Name = "Código Prov." Then
                If IdArticuloStock > 0 Then
                    'Mostrar pantalla de búsqueda para que el usuario seleccione un artículo
                    Dim frmProveedores As New ProveedoresArticuloForm
                    If frmProveedores.ShowDialog(Me, IdZonaCompra, IdArticuloStock, True) = System.Windows.Forms.DialogResult.OK Then
                        Dim drProveedor As ArticulosDS.ProveedoresRow = frmProveedores.SelectedItem
                        'Asinar datos del proveedor
                        With drProveedor
                            drvPartida("IdProveedor") = .IdProveedor
                            drvPartida("CodigoProveedor") = .Codigo
                            drvPartida("NombreProveedor") = .Nombre
                            drvPartida("IdUnidadMedida") = .IdUnidadMedida
                            drvPartida("IdDivisa") = .IdDivisa
                            drvPartida("IdImpuesto1") = .IdImpuesto1
                            drvPartida("IdImpuesto2") = .IdImpuesto2
                            drvPartida("IdImpuesto3") = .IdImpuesto3
                            drvPartida("IdRetencion1") = .IdRetencion1
                            drvPartida("IdRetencion2") = .IdRetencion2
                            drvPartida("IdRetencion3") = .IdRetencion3
                            grdProveedores.Columns("UnidadMedida").Value = .UnidadMedida
                            grdProveedores.Columns("Precio U.").Value = .Costo
                            grdProveedores.Columns("Divisa").Text = .Divisa
                            grdProveedores.Columns("Impuesto1").Text = .Impuesto1
                            grdProveedores.Columns("Impuesto2").Text = .Impuesto2
                            grdProveedores.Columns("Impuesto3").Text = .Impuesto3
                            grdProveedores.Columns("Retencion1").Text = .Retencion1
                            grdProveedores.Columns("Retencion2").Text = .Retencion2
                            grdProveedores.Columns("Retencion3").Text = .Retencion3
                        End With
                        grdProveedores.Refresh()
                        grdProveedores.UpdateData()
                    End If
                ElseIf IdServicio > 0 Then
                    'Mostrar pantalla de búsqueda para que el usuario seleccione un artículo
                    Dim frmProveedores As New ProveedoresServicioForm
                    If frmProveedores.ShowDialog(Me, IdZonaCompra, IdServicio, True) = System.Windows.Forms.DialogResult.OK Then
                        Dim drProveedor As ServiciosDS.ProveedoresRow = frmProveedores.SelectedItem
                        'Asinar datos del proveedor
                        With drProveedor
                            drvPartida("IdProveedor") = .IdProveedor
                            drvPartida("CodigoProveedor") = .Codigo
                            drvPartida("NombreProveedor") = .RazonSocial
                            drvPartida("IdDivisa") = .IdDivisa
                            drvPartida("IdImpuesto1") = .IdImpuesto1
                            drvPartida("IdImpuesto2") = .IdImpuesto2
                            drvPartida("IdImpuesto3") = .IdImpuesto3
                            drvPartida("IdRetencion1") = .IdRetencion1
                            drvPartida("IdRetencion2") = .IdRetencion2
                            drvPartida("IdRetencion3") = .IdRetencion3
                            grdProveedores.Columns("Precio U.").Value = .Costo
                            grdProveedores.Columns("Divisa").Text = .Divisa
                            grdProveedores.Columns("Impuesto1").Text = .Impuesto1
                            grdProveedores.Columns("Impuesto2").Text = .Impuesto2
                            grdProveedores.Columns("Impuesto3").Text = .Impuesto3
                            grdProveedores.Columns("Retencion1").Text = .Retencion1
                            grdProveedores.Columns("Retencion2").Text = .Retencion2
                            grdProveedores.Columns("Retencion3").Text = .Retencion3
                        End With
                        grdProveedores.Refresh()
                        grdProveedores.UpdateData()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdProveedores_FetchCellStyle(sender As Object, e As C1.Win.C1TrueDBGrid.FetchCellStyleEventArgs) Handles grdProveedores.FetchCellStyle
        Try
            If e.Column.Name = "Código Prov." Then
                Dim IdProveedor As Integer = CInt(grdProveedores.Columns("IdProveedor").CellValue(e.Row))
                If IdProveedor = 0 Then e.CellStyle.BackColor = Drawing.Color.Orange
            End If
        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "Implementacion Ordenes"

    Private Sub grdOrdenes_BeforeOpen(sender As Object, e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles grdOrdenes.BeforeOpen
        If bsOrdenes.Current IsNot Nothing Then
            Dim drOrden As GeneradorOrdenesDS.OrdenesTitRow = CType(CType(bsOrdenes.Current, DataRowView).Row, GeneradorOrdenesDS.OrdenesTitRow)
            bsOrdenesDet.Filter = "IdOrden=" & drOrden.IdOrden.ToString
        End If
    End Sub

    Private Sub grdOrdenes_FetchCellTips(sender As Object, e As C1.Win.C1TrueDBGrid.FetchCellTipsEventArgs) Handles grdOrdenes.FetchCellTips
        Dim ErrorText As String = grdOrdenes.Columns("Error").CellText(e.Row)
        If ErrorText.Trim <> String.Empty Then
            e.CellTip = ErrorText
        End If
    End Sub

    Private Sub grdOrdenesDet_GroupAggregate(sender As Object, e As C1.Win.C1TrueDBGrid.GroupTextEventArgs) Handles grdOrdenesDet.GroupAggregate
        If e.Col.Name = "Descripción" Then
            e.Text = grdOrdenesDet.Columns("Descripción").CellText(e.StartRowIndex)
        ElseIf e.Col.Name = "Unidad Medida" Then
            e.Text = grdOrdenesDet.Columns("Unidad Medida").CellText(e.StartRowIndex)
        End If
    End Sub

#End Region

End Class