Public Class ImpuestosForm

    Private Sub ImpuestosForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
    End Sub

    Private Sub ImpuestosForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ImpuestosForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim Impuesto As ImpuestoInfo = CType(PackageInfo, ImpuestoInfo)
        With Impuesto
            txtNombre.Text = .Nombre
            txtAbreviatura.Text = .Abreviatura
            nudPorcentaje.Value = .Porcentaje * 100D
            cboTipoImpuesto.SelectedIndex = .TipoImpuestoTransaladado - 1
        End With
    End Sub

    Private Sub ImpuestosForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim Impuesto As ImpuestoInfo = CType(PackageInfo, ImpuestoInfo)
        With Impuesto
            .Nombre = txtNombre.Text
            .Abreviatura = txtAbreviatura.Text
            .Porcentaje = nudPorcentaje.Value / 100D
            .TipoImpuestoTransaladado = cboTipoImpuesto.SelectedIndex + 1
        End With
    End Sub

End Class