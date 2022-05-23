Public Class ZonasCompraForm
    Private Proveedores As DataTable

    Private Sub CargarProveedores()
        Dim ProveedorFac As New ProveedorFacade
        Proveedores = ProveedorFac.LoadList(App.Session.SessionID, App.DefaultCompany.Identity)
        bsProveedores.DataSource = Proveedores
        grdProveedores.Rebind(True)
    End Sub

    Private Sub ZonasCompraForm_AddingItem(sender As Object, e As System.EventArgs) Handles Me.AddingItem
        cmdArticulos.Enabled = False
        cmdServicios.Enabled = False
    End Sub

    Private Sub ZonasCompraForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            CargarProveedores()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub ZonasCompraForm_LoadingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim Zona As ZonaCompraInfo = CType(PackageInfo, ZonaCompraInfo)
        With Zona
            txtNombre.Text = .Nombre
        End With
        cmdArticulos.Enabled = True
        cmdServicios.Enabled = True
    End Sub

    Private Sub ZonasCompraForm_SavingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim Zona As ZonaCompraInfo = CType(PackageInfo, ZonaCompraInfo)
        With Zona
            .Nombre = txtNombre.Text
        End With
        cmdArticulos.Enabled = True
        cmdServicios.Enabled = True
    End Sub

    Private Sub cmdArticulos_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdArticulos.Click
        Dim Zona As ZonaCompraInfo = CType(PackageInfo, ZonaCompraInfo)
        If bsProveedores.Current IsNot Nothing Then
            Try
                Dim IdProveedor As Integer = CInt(grdProveedores.Columns("IdProveedor").Value)
                Dim frmArticulos As New ArticulosProveedorForm
                If frmArticulos.ShowDialog(Me, Zona.Identity, IdProveedor, False) = System.Windows.Forms.DialogResult.OK Then

                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        End If
    End Sub

    Private Sub cmdServicios_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdServicios.Click
        Dim Zona As ZonaCompraInfo = CType(PackageInfo, ZonaCompraInfo)
        If bsProveedores.Current IsNot Nothing Then
            Try
                Dim IdProveedor As Integer = CInt(grdProveedores.Columns("IdProveedor").Value)
                Dim frmServicios As New ServiciosProveedorForm
                If frmServicios.ShowDialog(Me, Zona.Identity, IdProveedor, False) = System.Windows.Forms.DialogResult.OK Then

                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        End If
    End Sub

End Class