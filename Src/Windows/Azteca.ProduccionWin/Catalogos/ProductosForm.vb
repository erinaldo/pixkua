Imports Azteca.Business.Inventario

Public Class ProductosForm

#Region "Implementación de la forma"

    Private Sub ProductosForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboUnidadMedida.LoadList()
        bsUnidadMedida.DataSource = cboUnidadMedida.ItemsTable
        dropUnidadMedida.Rebind(True)

        bsUnidadMedidaP.DataSource = cboUnidadMedida.ItemsTable
        dropUnidadesMedidaP.Rebind(True)

    End Sub


    Private Sub ProductosForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
        Dim info As New ProductoInfo(App.Session.SessionID)
        bsInsumos.DataSource = info.InsumosTable
        grdInsumos.Rebind(True)
        bsSubProductos.DataSource = info.EnsambladosTable
        grdSubProductos.Rebind(True)
    End Sub

    
    Private Sub ProductosForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As ProductoInfo = CType(Me.PackageInfo, ProductoInfo)
        With info
            txtDescripcion.Text = .Nombre
            selArticuloStock.LoadInfo(.IdArticuloStock)
            selCuenta.LoadInfo(.IdCuenta)
            txtCantidad.Text = .Cantidad.ToString
            cboUnidadMedida.SelectedValue = .IdUnidadMedida
            txtMultiplos.Text = .MultiploProduccion.ToString
            chkEntregasParciales.Checked = .EntregasParciales
            chkExigirRecepcion.Checked = .ExigirRecepcion
        End With
        bsInsumos.DataSource = info.InsumosTable
        grdInsumos.Rebind(True)
        bsSubProductos.DataSource = info.EnsambladosTable
        grdSubProductos.Rebind(True)
    End Sub

    Private Sub ProductosForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As ProductoInfo = CType(Me.PackageInfo, ProductoInfo)
        With info
            .Nombre = txtDescripcion.Text
            .IdArticuloStock = selArticuloStock.Key
            .IdCuenta = selCuenta.Key
            .Cantidad = CDec(Val(txtCantidad.Text))
            .IdUnidadMedida = CInt(cboUnidadMedida.SelectedValue)
            .MultiploProduccion = CInt(txtMultiplos.Text)
            .EntregasParciales = chkEntregasParciales.Checked
            .ExigirRecepcion = chkExigirRecepcion.Checked
        End With
    End Sub

#End Region

#Region "Implementacion de Insumos"

    Private Sub grdInsumos_ButtonClick(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdInsumos.ButtonClick
        If PackageInfo.Identity > 0 Then
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Try
                Dim info As ProductoInfo = CType(Me.PackageInfo, ProductoInfo)

                If e.Column.Name = "X" Then
                    grdInsumos.Delete() : grdInsumos.Refresh()
                ElseIf e.Column.Name = "Codigo" Then
                    Dim InsumoFac As New InsumoFacade
                    'Dim InsumoFac As New ArticuloStockFacade

                    Dim frmSearch As New MsgSearch
                    If frmSearch.ShowDialog(InsumoFac) = System.Windows.Forms.DialogResult.OK Then
                        Dim Insumo As InsumoInfo = InsumoFac.GetDetail(App.Session.SessionID, CInt(frmSearch.SelectedItem))
                        'Dim Insumo As ArticuloStockInfo = InsumoFac.GetDetail(App.Session.SessionID, CInt(frmSearch.SelectedItem))
                        grdInsumos.Columns("IdInsumo").Value = Insumo.Identity
                        grdInsumos.Columns("Insumo").Value = Insumo.Nombre
                        grdInsumos.Columns("IdUnidadMedida").Value = Insumo.IdUnidadMedida

                    End If
                ElseIf e.Column.Name = "Unidad de Medida" Then
                    loadComboUnidadesMedida(CInt(grdInsumos.Columns("IdUnidadMedida").Value), grdInsumos)
                End If

            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        Else
            MessageBox.Show("Primero debe guardar la información del producto.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub grdInsumos_BeforeColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColUpdateEventArgs) Handles grdInsumos.BeforeColUpdate
        Try
            If e.Column.Name = "Codigo" Then
                'Validar que se haya especificado una cuenta válida
                If Val(grdInsumos.Columns("Codigo").Value) <= 0 Then Return
                Dim InsumoFac As New InsumoFacade
                If InsumoFac.Exists(App.Session.SessionID, grdInsumos.Columns("Codigo").Value.ToString, App.DefaultSite.Identity) Then
                    Dim Insumo As InsumoInfo = InsumoFac.GetDetail(App.Session.SessionID, grdInsumos.Columns("Codigo").Value.ToString, App.DefaultSite.Identity, False)
                    grdInsumos.Columns("IdInsumo").Value = Insumo.Identity
                    grdInsumos.Columns("Insumo").Value = Insumo.Nombre
                    grdInsumos.Columns("IdUnidadMedida").Value = Insumo.IdUnidadMedida
                Else
                    e.Cancel = True
                    MessageBox.Show("El código de Insumo especificado no existe.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

#End Region

#Region "Implementacion de Ensambles"

    Private Sub grdProductos_ButtonClick(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdSubProductos.ButtonClick
        If PackageInfo.Identity > 0 Then
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Try
                Dim info As ProductoInfo = CType(Me.PackageInfo, ProductoInfo)

                If e.Column.Name = "X" Then
                    grdSubProductos.Delete() : grdSubProductos.Refresh()
                ElseIf e.Column.Name = "Codigo" Then
                    Dim ProductoFac As New ProductoFacade
                    Dim frmSearch As New MsgSearch
                    If frmSearch.ShowDialog(ProductoFac) = System.Windows.Forms.DialogResult.OK Then
                        Dim Producto As ProductoInfo = ProductoFac.GetDetail(App.Session.SessionID, CInt(frmSearch.SelectedItem))
                        grdSubProductos.Columns("IdSubProducto").Value = Producto.Identity
                        grdSubProductos.Columns("Producto").Value = Producto.Nombre
                        grdSubProductos.Columns("IdUnidadMedida").Value = Producto.IdUnidadMedida
                    End If
                ElseIf e.Column.Name = "Unidad de Medida" Then
                    loadComboUnidadesMedida(CInt(grdSubProductos.Columns("IdUnidadMedida").Value), grdSubProductos)
                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        Else
            MessageBox.Show("Primero debe guardar la información del producto.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub grdProductos_BeforeColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColUpdateEventArgs) Handles grdSubProductos.BeforeColUpdate
        Try
            If e.Column.Name = "Codigo" Then
                'Validar que se haya especificado una cuenta válida
                If Val(grdSubProductos.Columns("Codigo").Value) <= 0 Then Return
                Dim ProductoFac As New ProductoFacade
                If ProductoFac.Exists(App.Session.SessionID, grdSubProductos.Columns("Codigo").Value.ToString, App.DefaultSite.Identity) Then
                    Dim Producto As ProductoInfo = ProductoFac.GetDetail(App.Session.SessionID, grdSubProductos.Columns("Codigo").Value.ToString, App.DefaultSite.Identity, False)
                    grdSubProductos.Columns("IdSubProducto").Value = Producto.Identity
                    grdSubProductos.Columns("Producto").Value = Producto.Nombre
                    grdSubProductos.Columns("IdUnidadMedida").Value = Producto.IdUnidadMedida
                Else
                    e.Cancel = True
                    MessageBox.Show("El código de Producto especificado no existe.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub loadComboUnidadesMedida(IdUnidadMedidaActual As Integer, grid As Azteca.Windows.Controls.AZTrueDBGrid)
        Dim dv As New DataView(cboUnidadMedida.ItemsTable, "IdUnidadMedida=" & IdUnidadMedidaActual, "", DataViewRowState.CurrentRows)

        If grid.Name = "grdInsumos" Then
            bsUnidadMedida.Filter = "IdUnidadMedidaTipo=" & CStr(dv(0)("IdUnidadMedidaTipo"))
        Else
            bsUnidadMedidaP.Filter = "IdUnidadMedidaTipo=" & CStr(dv(0)("IdUnidadMedidaTipo"))
        End If

    End Sub


#End Region


End Class