Public Class MetodoPagoForm

    Private Sub MetodoPagoForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim FormaPago As MetodoPagoInfo = CType(PackageInfo, MetodoPagoInfo)
        With FormaPago
            txtNombre.Text = .Nombre
        End With
    End Sub

    Private Sub MetodoPagoForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim FormaPago As MetodoPagoInfo = CType(PackageInfo, MetodoPagoInfo)
        With FormaPago
            .Nombre = txtNombre.Text
        End With
    End Sub

End Class