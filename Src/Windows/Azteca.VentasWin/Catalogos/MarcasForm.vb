Public Class MarcasForm

    Private Sub MarcasForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim Marca As MarcaInfo = CType(PackageInfo, MarcaInfo)
        With Marca
            txtNombre.Text = .Nombre
            txtCuenta.Text = String.Empty
            txtCuenta.LoadInfo(.IdCuenta)
        End With
    End Sub

    Private Sub MarcasForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim Marca As MarcaInfo = CType(PackageInfo, MarcaInfo)
        With Marca
            .Nombre = txtNombre.Text
            .IdCuenta = txtCuenta.Key
        End With
    End Sub
End Class