Public Class ProveedoresServicioForm
    Private SelectionMode As Boolean
    Private IdZona, IdServicio As Integer
    Private ZonaFac As ZonaCompraFacade
    Private Zona As ZonaCompraInfo
    Private Servicio As ServicioInfo
    Private ServicioFac As ServicioFacade
    Private Proveedores As ServiciosDS.ProveedoresDataTable

    Private _SelectedItem As ServiciosDS.ProveedoresRow

    Public ReadOnly Property SelectedItem As ServiciosDS.ProveedoresRow
        Get
            Return _SelectedItem
        End Get
    End Property

    Private Sub CargarProveedores()
        Dim ProveedorFac As New ProveedorFacade
        Proveedores = ProveedorFac.LoadListByServicio(App.Session.SessionID, IdZona, IdServicio)
        bsProveedores.DataSource = Proveedores
        grdProveedores.Rebind(True)
    End Sub

    Public Overloads Function ShowDialog(owner As Form, idZona As Integer, idServicio As Integer, selectionMode As Boolean) As DialogResult
        Me.IdZona = idZona
        Me.IdServicio = idServicio
        Me.SelectionMode = selectionMode
        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub ProveedoresServicioForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            ZonaFac = New ZonaCompraFacade
            ServicioFac = New ServicioFacade
            '
            Zona = ZonaFac.GetDetail(App.Session.SessionID, IdZona, False)
            Servicio = ServicioFac.GetDetail(App.Session.SessionID, IdServicio, False)
            '
            lblZona.Text = Zona.Nombre
            lblServicio.Text = Servicio.Nombre
            If SelectionMode Then
                cmdAceptar.Visible = True
                cmdCancelar.Visible = True
                ControlBox = False
            Else
                cmdAceptar.Visible = False
                cmdCancelar.Visible = False
            End If
            CargarProveedores()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub cmdAgregarProveedor_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdAgregarProveedor.Click
        Try
            Dim frmEdit As New EditServicioProveedorForm
            If frmEdit.ShowDialog(Me, IdZona, 0, IdServicio) = System.Windows.Forms.DialogResult.OK Then
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
                Dim drProveedor As ServiciosDS.ProveedoresRow = CType(CType(bsProveedores.Current, DataRowView).Row, ServiciosDS.ProveedoresRow)
                Dim ProveedorFac As New ProveedorFacade
                ProveedorFac.SetServicioDefault(App.Session.SessionID, IdZona, drProveedor.IdProveedor, IdServicio)
                For Each dr As ServiciosDS.ProveedoresRow In Proveedores
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
                    Dim drProveedor As ServiciosDS.ProveedoresRow = CType(CType(bsProveedores.Current, DataRowView).Row, ServiciosDS.ProveedoresRow)
                    Dim ProveedorFac As New ProveedorFacade
                    ProveedorFac.EliminarServicio(App.Session.SessionID, IdZona, drProveedor.IdProveedor, IdServicio)
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
                Dim drProveedor As ServiciosDS.ProveedoresRow = CType(CType(bsProveedores.Current, DataRowView).Row, ServiciosDS.ProveedoresRow)
                Dim frmEdit As New EditServicioProveedorForm
                If frmEdit.ShowDialog(Me, IdZona, drProveedor.IdProveedor, IdServicio) = System.Windows.Forms.DialogResult.OK Then
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
                _SelectedItem = CType(CType(bsProveedores.Current, DataRowView).Row, ServiciosDS.ProveedoresRow)
                DialogResult = System.Windows.Forms.DialogResult.OK
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        Else
            MessageBox.Show("Debe seleccionar o agregar un proveedor.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdCancelar.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub
End Class