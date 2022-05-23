Public Class UbicacionTipoForm

    Private Sub UbicacionTipo_LoadingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As UbicacionTipoInfo = CType(Me.PackageInfo, UbicacionTipoInfo)
        With info
            txtNombre.Text = .Nombre
            If .IdCuenta > 0 Then selCuenta.LoadInfo(.IdCuenta)
        End With
    End Sub

    Private Sub UbicacionTipo_SavingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As UbicacionTipoInfo = CType(Me.PackageInfo, UbicacionTipoInfo)
        With info
            .Nombre = txtNombre.Text
            .IdCuenta = selCuenta.Key
        End With
    End Sub

End Class