Public Class IncidenciasForm

    Private Sub IncidenciasForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.selTipoIncidencia.LoadList(App.DefaultCompany.Identity)
    End Sub

    Private Sub IncidenciasForm_LoadingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As IncidenciaInfo = CType(Me.PackageInfo, IncidenciaInfo)

        With info
            txtNombre.Text = info.Nombre
            SelCuenta.LoadInfo(info.IdCuenta)
            selTipoIncidencia.SelectedValue = info.IdTipoIncidencia
        End With
    End Sub

    Private Sub IncidenciasForm_SavingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As IncidenciaInfo = CType(Me.PackageInfo, IncidenciaInfo)

        With info
            info.Nombre = txtNombre.Text
            info.IdTipoIncidencia = CInt(selTipoIncidencia.SelectedValue)
            info.IdCuenta = SelCuenta.Key
        End With
    End Sub
End Class