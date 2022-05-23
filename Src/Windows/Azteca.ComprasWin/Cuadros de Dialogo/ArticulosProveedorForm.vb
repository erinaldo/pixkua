Public Class ArticulosProveedorForm
    Private SelectionMode As Boolean
    Private IdProveedor, IdZona As Integer
    Private _SelectedItems As ProveedoresDS.ArticulosDataTable

    Private ProveedorFac As ProveedorFacade
    Private Proveedor As ProveedorInfo
    Private ZonaFac As ZonaCompraFacade
    Private Zona As ZonaCompraInfo
    Private Articulos As ProveedoresDS.ArticulosDataTable

    Public ReadOnly Property SelectedItems As ProveedoresDS.ArticulosDataTable
        Get
            Return _SelectedItems
        End Get
    End Property

    Private Sub CargarArticulos()
        Articulos = ProveedorFac.CargarArticulos(App.Session.SessionID, IdProveedor, IdZona)
        'Si se abrió en modo de selección, agregar columna al dataset de articulos
        If SelectionMode Then
            Dim dcSel As New DataColumn("Sel", GetType(Boolean))
            dcSel.DefaultValue = False
            Articulos.Columns.Add(dcSel)
        End If
        bsArticulos.DataSource = Articulos
        grdArticulos.Rebind(True)
    End Sub

    Public Overloads Function ShowDialog(owner As Form, idZona As Integer, idProveedor As Integer, selectionMode As Boolean) As DialogResult
        Me.IdProveedor = idProveedor
        Me.IdZona = idZona
        Me.SelectionMode = selectionMode
        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub ArticulosProveedorForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            ProveedorFac = New ProveedorFacade
            Proveedor = ProveedorFac.GetDetail(App.Session.SessionID, IdProveedor, False)
            ZonaFac = New ZonaCompraFacade
            Zona = ZonaFac.GetDetail(App.Session.SessionID, IdZona, False)
            _SelectedItems = New ProveedoresDS.ArticulosDataTable
            '
            lblProveedor.Text = Proveedor.Nombre
            lblZona.Text = Zona.Nombre
            CargarArticulos()
            'Si no se abrió en modo de selección, ocultar los campos que no sean necesarios
            If Not SelectionMode Then
                cmdAceptar.Visible = False
                cmdCancelar.Visible = False
                grdArticulos.Splits(0).DisplayColumns("S").Visible = False
            Else
                grdArticulos.ShowEditButton = False
                grdArticulos.ShowDeleteButton = False
                ControlBox = False
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnNuevoArticulo_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdAgregarArticulo.Click
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            Dim frmArticulo As New EditArticuloProveedorForm
            If frmArticulo.ShowDialog(Me, IdZona, IdProveedor, 0) = System.Windows.Forms.DialogResult.OK Then
                CargarArticulos()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub EditarArticulo()
        Dim drArticulo As ProveedoresDS.ArticulosRow = CType(CType(bsArticulos.Current, DataRowView).Row, ProveedoresDS.ArticulosRow)
        Dim frmArticulo As New EditArticuloProveedorForm
        If frmArticulo.ShowDialog(Me, IdZona, IdProveedor, drArticulo.IdArticuloStock) = System.Windows.Forms.DialogResult.OK Then
            CargarArticulos()
        End If
    End Sub

    Private Sub gridArticulos_DeleteButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdArticulos.DeleteButtonClick
        If bsArticulos.Current IsNot Nothing Then
            Dim drArticulo As ProveedoresDS.ArticulosRow = CType(CType(bsArticulos.Current, DataRowView).Row, ProveedoresDS.ArticulosRow)
            Dim Resp As DialogResult = MessageBox.Show("¿Está seguro que desea quitar el artículo seleccionado?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Resp = System.Windows.Forms.DialogResult.Yes Then
                Try
                    System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                    ProveedorFac.EliminarArticulo(App.Session.SessionID, IdZona, IdProveedor, drArticulo.IdArticuloStock)
                    bsArticulos.RemoveCurrent()
                Catch ex As Exception
                    MsgInfo.Show(ex)
                Finally
                    System.Windows.Forms.Cursor.Current = Cursors.Default
                End Try
            End If
        End If
    End Sub

    Private Sub gridArticulos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdArticulos.DoubleClick
        If bsArticulos.Current IsNot Nothing Then
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Try
                EditarArticulo()
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub gridArticulos_EditButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdArticulos.EditButtonClick
        If bsArticulos.Current IsNot Nothing Then
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Try
                EditarArticulo()
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdCancelar.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdAceptar.Click
        grdArticulos.UpdateData()
        Dim Selected = From A In Articulos
                      Where CBool(A!Sel) = True

        If Selected.Count > 0 Then
            For Each dr As ProveedoresDS.ArticulosRow In Selected
                _SelectedItems.ImportRow(dr)
            Next
            DialogResult = System.Windows.Forms.DialogResult.OK
        Else
            MessageBox.Show("Debe seleccionar al menos un artículo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class