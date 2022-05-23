Public Class BeneficiariosForm

    Private Sub BeneficiariosForm_AddingItem(sender As Object, e As System.EventArgs) Handles Me.AddingItem
    End Sub

    Private Sub BeneficiariosForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cboBanco.LoadList()
    End Sub

    Private Sub BeneficiariosForm_LoadingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As BeneficiarioInfo = CType(Me.PackageInfo, BeneficiarioInfo)
        With info
            txtRazonSocial.Text = .RazonSocial
            cboBanco.SelectedValue = .IdBanco
            txtCLABE.Text = .CLABE
            If .IdCuenta > 0 Then selCuenta.LoadInfo(.IdCuenta)
            chkLeyenda.Checked = .LeyendaCheque
            upDownDiasCredito.Value = .DiasCredito
        End With
    End Sub

    Private Sub BeneficiariosForm_SavingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As BeneficiarioInfo = CType(Me.PackageInfo, BeneficiarioInfo)
        With info
            .RazonSocial = txtRazonSocial.Text
            .IdBanco = CInt(cboBanco.SelectedValue)
            .CLABE = txtCLABE.Text
            .IdCuenta = selCuenta.Key
            .LeyendaCheque = chkLeyenda.Checked
            .DiasCredito = upDownDiasCredito.Value
        End With
    End Sub
End Class