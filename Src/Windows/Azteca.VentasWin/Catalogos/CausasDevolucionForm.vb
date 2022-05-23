Public Class CausasDevolucionForm

    Private Sub CausasDevolucionForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
        chkActivo.Checked = True
    End Sub

    Private Sub CausasDevolucionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CausasDevolucionForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim Causa As CausaDevolucionInfo = CType(PackageInfo, CausaDevolucionInfo)
        With Causa
            txtNombre.Text = .Nombre
            txtCuenta.Text = String.Empty
            If .IdCuenta > 0 Then txtCuenta.LoadInfo(.IdCuenta)
            chkActivo.Checked = (.Status = CatalogState.Active)
        End With
    End Sub

    Private Sub CausasDevolucionForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim Causa As CausaDevolucionInfo = CType(PackageInfo, CausaDevolucionInfo)
        With Causa
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