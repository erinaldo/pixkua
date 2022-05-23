Public Class MesasForm

    Private Sub MesasForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboCentrosConsumo.LoadList()
    End Sub

    Private Sub MesasForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As MesaInfo = CType(Me.PackageInfo, MesaInfo)
        With info
            txtDescripcion.Text = .Descripcion
            cboCentrosConsumo.SelectedValue = .IdCentroConsumo
            selCuenta.LoadInfo(.IdCuenta)
        End With
    End Sub

    Private Sub MesasForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As MesaInfo = CType(Me.PackageInfo, MesaInfo)
        With info
            .Descripcion = txtDescripcion.Text
            .IdCentroConsumo = CInt(cboCentrosConsumo.SelectedValue)
            .IdCuenta = CInt(selCuenta.Key)
        End With
    End Sub

End Class