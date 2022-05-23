Public Class RegletasForm

    Private Sub RegletasForm_AddingItem(sender As Object, e As System.EventArgs) Handles Me.AddingItem
        Dim Regleta As RegletaInfo = CType(PackageInfo, RegletaInfo)
        bsTallas.DataSource = Regleta.TallasTable
        grdTallas.Rebind(True)
    End Sub


    Private Sub RegletasForm_LoadingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim Regleta As RegletaInfo = CType(PackageInfo, RegletaInfo)
        With Regleta
            txtNombre.Text = .Nombre
            If selCuenta.Key > 0 Then selCuenta.LoadInfo(.IdCuenta)
            bsTallas.DataSource = .TallasTable
            grdTallas.Rebind(True)
        End With
    End Sub

    Private Sub RegletasForm_SavingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim Regleta As RegletaInfo = CType(PackageInfo, RegletaInfo)
        With Regleta
            .Nombre = txtNombre.Text
            .IdCuenta = selCuenta.Key
        End With
    End Sub

End Class