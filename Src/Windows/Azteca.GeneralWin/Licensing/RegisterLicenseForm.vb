Public Class RegisterLicenseForm
    Private Licencias As LicenciasDS.LicenciasDataTable
    Private LicManager As Azteca.Kernel.Licensing.LicenseManager

    Private Sub FillLicenseList()
        Licencias = LicenseStorage.LoadLicenses()
        bsLicencias.DataSource = Licencias
        grdLicencias.Rebind(True)
    End Sub

    Private Sub RegisterLicenseForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Licencias = New LicenciasDS.LicenciasDataTable
            LicManager = New Azteca.Kernel.Licensing.LicenseManager
            If Not LicManager.RegistrationCodesExists Then LicManager.CreateRegistrationCodes()
            FillLicenseList()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnAplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicar.Click
        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            grdLicencias.UpdateData()
            LicenseStorage.SaveLicenses(Licencias)
            LicenseStorage.CreateLicenseCache()
            MessageBox.Show("Los cambios han sido actualizados con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub grdLicencias_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdLicencias.AfterColUpdate
        If e.Column.Name = "Licencia" Then
            Dim RegCode As Guid = New Guid(grdLicencias.Columns("Código de Registro").Text)
            If LicManager.ValidateLicenseCode(RegCode, grdLicencias.Columns("Licencia").Text) Then
                grdLicencias.Columns("").Value = 2
            Else
                grdLicencias.Columns("").Value = 0
            End If
        End If
    End Sub
End Class