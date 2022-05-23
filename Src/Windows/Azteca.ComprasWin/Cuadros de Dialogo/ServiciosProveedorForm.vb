Public Class ServiciosProveedorForm
    Private IdProveedor, IdZona As Integer
    Private SelectionMode As Boolean
    Private ProveedorFac As ProveedorFacade
    Private Proveedor As ProveedorInfo
    Private ZonaFac As ZonaCompraFacade
    Private Zona As ZonaCompraInfo
    Private Servicios As ProveedoresDS.ServiciosDataTable

    Private _SelectedItems As ProveedoresDS.ServiciosDataTable

    Public ReadOnly Property SelectedItems As ProveedoresDS.ServiciosDataTable
        Get
            Return _SelectedItems
        End Get
    End Property


    Private Sub CargarServicios()
        Servicios = ProveedorFac.CargarServicios(App.Session.SessionID, IdProveedor, IdZona)
        'Si se abrió en modo de selección, agregar columna al dataset de servicios
        If SelectionMode Then
            Dim dcSel As New DataColumn("Sel", GetType(Boolean))
            dcSel.DefaultValue = False
            Servicios.Columns.Add(dcSel)
        End If
        bsServicios.DataSource = Servicios
        grdServicios.Rebind(True)
    End Sub

    Public Overloads Function ShowDialog(owner As Form, idZona As Integer, idProveedor As Integer, SelectionMode As Boolean) As DialogResult
        Me.IdProveedor = idProveedor
        Me.IdZona = idZona
        Me.SelectionMode = SelectionMode
        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub ServiciosProveedorForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            ProveedorFac = New ProveedorFacade
            Proveedor = ProveedorFac.GetDetail(App.Session.SessionID, IdProveedor, False)
            ZonaFac = New ZonaCompraFacade
            Zona = ZonaFac.GetDetail(App.Session.SessionID, IdZona, False)
            _SelectedItems = New ProveedoresDS.ServiciosDataTable

            lblProveedor.Text = Proveedor.Nombre
            lblZona.Text = Zona.Nombre
            'Si no se abrió en modo de selección, ocultar los campos que no sean necesarios
            If Not SelectionMode Then
                cmdAceptar.Visible = False
                cmdCancelar.Visible = False
                grdServicios.Splits(0).DisplayColumns("S").Visible = False
            Else
                grdServicios.ShowEditButton = False
                grdServicios.ShowDeleteButton = False
            End If
            CargarServicios()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub


    Private Sub btnNuevoServ_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdAgregarServicio.Click
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            Dim frmServicio As New EditServicioProveedorForm
            If frmServicio.ShowDialog(Me, IdZona, IdProveedor, 0) = System.Windows.Forms.DialogResult.OK Then
                CargarServicios()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub EditarServicio()
        Dim drServicio As ProveedoresDS.ServiciosRow = CType(CType(bsServicios.Current, DataRowView).Row, ProveedoresDS.ServiciosRow)
        Dim frmServicio As New EditServicioProveedorForm
        If frmServicio.ShowDialog(Me, IdZona, IdProveedor, drServicio.IdServicio) = System.Windows.Forms.DialogResult.OK Then
            CargarServicios()
        End If
    End Sub

    Private Sub gridServicios_DeleteButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdServicios.DeleteButtonClick
        If bsServicios.Current IsNot Nothing Then
            Dim drServicio As ProveedoresDS.ServiciosRow = CType(CType(bsServicios.Current, DataRowView).Row, ProveedoresDS.ServiciosRow)
            Dim Resp As DialogResult = MessageBox.Show("¿Está seguro que desea quitar el servicio seleccionado?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Resp = System.Windows.Forms.DialogResult.Yes Then
                Try
                    System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                    ProveedorFac.EliminarServicio(App.Session.SessionID, IdZona, IdProveedor, drServicio.IdServicio)
                    bsServicios.RemoveCurrent()
                Catch ex As Exception
                    MsgInfo.Show(ex)
                Finally
                    System.Windows.Forms.Cursor.Current = Cursors.Default
                End Try
            End If
        End If
    End Sub

    Private Sub gridServicios_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdServicios.DoubleClick
        If bsServicios.Current IsNot Nothing Then
            Try
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                EditarServicio()
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub gridServicios_EditButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdServicios.EditButtonClick
        If bsServicios.Current IsNot Nothing Then
            Try
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                EditarServicio()
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        End If
    End Sub


    Private Sub btnAceptar_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdAceptar.Click
        grdServicios.UpdateData()
        Dim Selected = From S In Servicios
                      Where CBool(S!Sel) = True

        If Selected.Count > 0 Then
            For Each dr As ProveedoresDS.ServiciosRow In Selected
                _SelectedItems.ImportRow(dr)
            Next
            DialogResult = System.Windows.Forms.DialogResult.OK
        Else
            MessageBox.Show("Debe seleccionar al menos un servicio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdCancelar.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

End Class