Public Class RetencionesForm

    Private Sub RetencionesForm_AddingItem(sender As Object, e As System.EventArgs) Handles Me.AddingItem
    End Sub

    Private Sub RetencionesForm_LoadingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim Retencion As RetencionInfo = CType(PackageInfo, RetencionInfo)
        With Retencion
            txtNombre.Text = .Nombre
            txtAbreviatura.Text = .Abreviatura
            nudPorcentaje.Value = .Porcentaje * 100D
            cboTipoRetencion.SelectedIndex = .TipoRetencion - 1
        End With
    End Sub

    Private Sub RetencionesForm_SavingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim Retencion As RetencionInfo = CType(PackageInfo, RetencionInfo)
        With Retencion
            .Nombre = txtNombre.Text
            .Abreviatura = txtAbreviatura.Text
            .Porcentaje = nudPorcentaje.Value / 100D
            .TipoRetencion = cboTipoRetencion.SelectedIndex + 1
            
        End With

    End Sub
End Class