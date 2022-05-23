Public Class CajerosForm

    Private Sub CajerosForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem

    End Sub

    Private Sub CajerosForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As CajeroInfo = CType(Me.PackageInfo, CajeroInfo)
        With info
            selEmpleado.LoadInfo(.IdEmpleado)
            selUsuario.LoadInfo(.IdUsuario)
            selCuenta.LoadInfo(.IdCuenta)
        End With
    End Sub

    Private Sub CajerosForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As CajeroInfo = CType(Me.PackageInfo, CajeroInfo)
        With info
            .IdEmpleado = selEmpleado.Key
            .IdUsuario = selUsuario.Key
            .IdCuenta = selCuenta.Key
        End With

    End Sub

    Private Sub CajerosForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class