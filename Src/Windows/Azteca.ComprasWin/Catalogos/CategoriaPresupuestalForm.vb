Public Class CategoriaPresupuestalForm

    Private Sub CategoriaPresupuestalForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem

    End Sub

    Private Sub CategoriaPresupuestalForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CategoriaPresupuestalForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As CategoriaPresupuestalInfo = CType(Me.PackageInfo, CategoriaPresupuestalInfo)
        With info
            txtNombre.Text = .Nombre
            If .IdCuenta > 0 Then selCuenta.LoadInfo(.IdCuenta)

        End With
    End Sub

    Private Sub CategoriaPresupuestalForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As CategoriaPresupuestalInfo = CType(Me.PackageInfo, CategoriaPresupuestalInfo)
        With info
            .Nombre = txtNombre.Text
            .IdCuenta = selCuenta.Key
            .IdCategoriaFlujo = 0
        End With
    End Sub

End Class