Imports Azteca.Business.Inventario

Public Class ProveedoresArticuloForm
    Private SelectionMode As Boolean
    Private IdZona, IdArticuloStock As Integer
    Private ZonaFac As ZonaCompraFacade
    Private Zona As ZonaCompraInfo
    Private ArticuloFac As ArticuloStockFacade
    Private ArticuloStock As ArticuloStockInfo
    Private Proveedores As ArticulosDS.ProveedoresDataTable

    Private _SelectedItem As ArticulosDS.ProveedoresRow

    Public ReadOnly Property SelectedItem As ArticulosDS.ProveedoresRow
        Get
            Return _SelectedItem
        End Get
    End Property

    Private Sub CargarProveedores()
        Dim ProveedorFac As New ProveedorFacade
        Proveedores = ProveedorFac.LoadListByArticulo(App.Session.SessionID, IdZona, IdArticuloStock)
        bsProveedores.DataSource = Proveedores
        grdProveedores.Rebind(True)
    End Sub

    Public Overloads Function ShowDialog(owner As Form, idZona As Integer, idArticuloStock As Integer, selectionMode As Boolean) As DialogResult
        Me.IdZona = idZona
        Me.IdArticuloStock = idArticuloStock
        Me.SelectionMode = selectionMode
        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub ProveedoresArticuloForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            ZonaFac = New ZonaCompraFacade
            Zona = ZonaFac.GetDetail(App.Session.SessionID, IdZona, False)
            ArticuloFac = New ArticuloStockFacade
            ArticuloStock = ArticuloFac.GetDetail(App.Session.SessionID, IdArticuloStock, False)
            '
            lblArticulo.Text = ArticuloStock.Nombre
            lblZona.Text = Zona.Nombre
            CargarProveedores()
            If SelectionMode Then
                cmdAceptar.Visible = True
                cmdCancelar.Visible = True
                ControlBox = False
            Else
                cmdAceptar.Visible = False
                cmdCancelar.Visible = False
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub cmdAgregarProveedor_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdAgregarProveedor.Click
        Try
            Dim frmEdit As New EditArticuloProveedorForm
            If frmEdit.ShowDialog(Me, IdZona, 0, IdArticuloStock) = System.Windows.Forms.DialogResult.OK Then
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                CargarProveedores()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub cmdSetDefault_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdSetDefault.Click
        If bsProveedores.Current IsNot Nothing Then
            Try
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                Dim drProveedor As ArticulosDS.ProveedoresRow = CType(CType(bsProveedores.Current, DataRowView).Row, ArticulosDS.ProveedoresRow)
                Dim ProveedorFac As New ProveedorFacade
                ProveedorFac.SetArticuloDefault(App.Session.SessionID, IdZona, drProveedor.IdProveedor, IdArticuloStock)
                For Each dr As ArticulosDS.ProveedoresRow In Proveedores
                    dr.Predeterminado = False
                    dr.PredeterminadoDescr = "NO"
                Next
                drProveedor.Predeterminado = True
                drProveedor.PredeterminadoDescr = "SI"
                Proveedores.AcceptChanges()
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub grdProveedores_DeleteButtonClick(sender As Object, e As Controls.GridViewCatalogButtonEventArgs) Handles grdProveedores.DeleteButtonClick
        If bsProveedores.Current IsNot Nothing Then
            Dim Resp As DialogResult = MessageBox.Show("¿Está seguro que desea quitar el proveedor seleccionado?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Resp = System.Windows.Forms.DialogResult.Yes Then
                Try
                    System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                    Dim drProveedor As ArticulosDS.ProveedoresRow = CType(CType(bsProveedores.Current, DataRowView).Row, ArticulosDS.ProveedoresRow)
                    Dim ProveedorFac As New ProveedorFacade
                    ProveedorFac.EliminarArticulo(App.Session.SessionID, IdZona, drProveedor.IdProveedor, IdArticuloStock)
                    bsProveedores.RemoveCurrent()
                Catch ex As Exception
                    MsgInfo.Show(ex)
                Finally
                    System.Windows.Forms.Cursor.Current = Cursors.Default
                End Try
            End If
        End If
    End Sub

    Private Sub grdProveedores_EditButtonClick(sender As Object, e As Controls.GridViewCatalogButtonEventArgs) Handles grdProveedores.EditButtonClick
        If bsProveedores.Current IsNot Nothing Then
            Try
                Dim drProveedor As ArticulosDS.ProveedoresRow = CType(CType(bsProveedores.Current, DataRowView).Row, ArticulosDS.ProveedoresRow)
                Dim frmEdit As New EditArticuloProveedorForm
                If frmEdit.ShowDialog(Me, IdZona, drProveedor.IdProveedor, IdArticuloStock) = System.Windows.Forms.DialogResult.OK Then
                    System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                    CargarProveedores()
                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            End Try
        End If
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdAceptar.Click
        If bsProveedores.Current IsNot Nothing Then
            Try
                _SelectedItem = CType(CType(bsProveedores.Current, DataRowView).Row, ArticulosDS.ProveedoresRow)
                DialogResult = System.Windows.Forms.DialogResult.OK
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        Else
            MessageBox.Show("Debe seleccionar o agregar un proveedor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdCancelar.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub
End Class