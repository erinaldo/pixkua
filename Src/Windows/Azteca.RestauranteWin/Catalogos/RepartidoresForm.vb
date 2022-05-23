Public Class RepartidoresForm

    Private Sub RepartidoresForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As RepartidorInfo = CType(Me.PackageInfo, RepartidorInfo)
        With info
            selUsuario.LoadInfo(.IdUsuario)
            selCuenta.LoadInfo(.IdCuenta)
            txtNombreCorto.Text = .NombreCorto
            
        End With
    End Sub

    Private Sub RepartidoresForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As RepartidorInfo = CType(Me.PackageInfo, RepartidorInfo)
        With info
            .IdUsuario = selUsuario.Key
            .IdCuenta = selCuenta.Key
            .NombreCorto = txtNombreCorto.Text
            
        End With
    End Sub
End Class