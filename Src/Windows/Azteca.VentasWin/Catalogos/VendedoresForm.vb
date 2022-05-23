Public Class VendedoresForm

    Private Sub VendedoresForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
    End Sub

    Private Sub VendedoresForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As VendedorInfo = CType(Me.PackageInfo, VendedorInfo)
        With info
            selEmpleado.LoadInfo(.IdEmpleado)
            selCuenta.LoadInfo(.IdCuenta)
        End With
    End Sub

    Private Sub VendedoresForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As VendedorInfo = CType(Me.PackageInfo, VendedorInfo)
        With info
            .IdEmpleado = selEmpleado.Key
            .IdCuenta = selCuenta.Key
        End With
    End Sub

    Private Sub VendedoresForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class