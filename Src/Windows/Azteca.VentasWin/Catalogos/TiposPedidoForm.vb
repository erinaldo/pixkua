Public Class TiposPedidoForm

    Private Sub TiposPedidoForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
        chkActivo.Checked = True
    End Sub

    Private Sub TiposPedidoForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TiposPedidoForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim TipoPedido As TipoPedidoInfo = CType(PackageInfo, TipoPedidoInfo)
        With TipoPedido
            txtNombre.Text = .Nombre
            txtCuenta.Text = String.Empty
            If .IdCuenta > 0 Then txtCuenta.LoadInfo(.IdCuenta)
            chkActivo.Checked = (.Status = CatalogState.Active)
        End With
    End Sub

    Private Sub TiposPedidoForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim TipoPedido As TipoPedidoInfo = CType(PackageInfo, TipoPedidoInfo)
        With TipoPedido
            .Nombre = txtNombre.Text
            .IdCuenta = txtCuenta.Key
            If chkActivo.Checked Then
                .Status = CatalogState.Active
            Else
                .Status = CatalogState.Inactive
            End If
        End With
    End Sub
End Class