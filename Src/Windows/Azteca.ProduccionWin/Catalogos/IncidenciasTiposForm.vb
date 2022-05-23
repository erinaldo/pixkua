Public Class IncidenciasTiposForm

 

    Private Sub IncidenciasTiposForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub IncidenciasTiposForm_LoadingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As IncidenciaTipoInfo = CType(Me.PackageInfo, IncidenciaTipoInfo)

        With info
            txtNombre.Text = .Nombre
            SelCuenta.LoadInfo(.IdCuenta)
            chkNoContabilizar.Checked = .NoContabilizar
        End With
    End Sub

    Private Sub IncidenciasTiposForm_SavingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As IncidenciaTipoInfo = CType(Me.PackageInfo, IncidenciaTipoInfo)
        With info
            info.Nombre = txtNombre.Text
            info.IdCuenta = SelCuenta.Key
            info.NoContabilizar = chkNoContabilizar.Checked
        End With
    End Sub

    Private Sub SelCuenta_InfoLoaded(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelCuenta.InfoLoaded

    End Sub
End Class