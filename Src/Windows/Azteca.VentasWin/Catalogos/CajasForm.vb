Public Class CajasForm

    Private Sub CajasForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cboImpresora.LoadList()
    End Sub

    Private Sub CajasForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
    End Sub

    Private Sub CajasForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As CajaInfo = CType(Me.PackageInfo, CajaInfo)
        With info

            txtNombre.Text = .Nombre
            cboImpresora.SelectedValue = .IdImpresora
            If .IdCuenta > 0 Then selCuenta.LoadInfo(.IdCuenta)
            chkFactGlobal.Checked = .GenerarFacturaGlobal
        End With
    End Sub

    Private Sub CajasForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As CajaInfo = CType(Me.PackageInfo, CajaInfo)
        With info
            .Nombre = txtNombre.Text
            .IdImpresora = CInt(cboImpresora.SelectedValue)
            .IdCuenta = selCuenta.Key
            .GenerarFacturaGlobal = chkFactGlobal.Checked
        End With
    End Sub


    Private Sub CiLabel1_Click(sender As System.Object, e As System.EventArgs) Handles CiLabel1.Click

    End Sub
    Private Sub txtNombre_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNombre.TextChanged

    End Sub
    Private Sub CiLabel24_Click(sender As System.Object, e As System.EventArgs) Handles CiLabel24.Click

    End Sub
    Private Sub lblImpresora_Click(sender As System.Object, e As System.EventArgs) Handles lblImpresora.Click

    End Sub
    Private Sub selCuenta_InfoLoaded(sender As System.Object, e As System.EventArgs) Handles selCuenta.InfoLoaded

    End Sub
    Private Sub cboImpresora_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboImpresora.SelectedIndexChanged

    End Sub
End Class