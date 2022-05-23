Public Class CentrosRecepcionForm

    Private Sub CentrosRecepcionForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As CentroRecepcionInfo = CType(Me.PackageInfo, CentroRecepcionInfo)
        With info
            txtNombre.Text = .Nombre
            If .IdCuenta > 0 Then selCuenta.LoadInfo(.IdCuenta)
            cboAlmacenes.SelectedValue = .IdAlmacen
            txtCalle.Text = .Calle
            txtNumExt.Text = .NumExt
            txtNumInt.Text = .NumInt
            txtColonia.Text = .Colonia
            txtCP.Text = .CP
            If .IdPoblacion > 0 Then txtPoblacion.LoadInfo(.IdPoblacion)
            If .IdMunicipio > 0 Then txtMunicipio.LoadInfo(.IdMunicipio)
            txtTel1.Text = .Tel1
            txtTel2.Text = .Tel2
            txtFax.Text = .Fax
        End With
    End Sub

    Private Sub CentrosRecepcionForm_LoadingLists(sender As Object, e As System.EventArgs) Handles Me.LoadingLists
        cboAlmacenes.LoadList()
    End Sub

    Private Sub CentrosRecepcionForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As CentroRecepcionInfo = CType(Me.PackageInfo, CentroRecepcionInfo)
        With info
            .Nombre = txtNombre.Text
            .IdCuenta = selCuenta.Key
            .IdAlmacen = CInt(cboAlmacenes.SelectedValue)
            .Calle = txtCalle.Text
            .NumExt = txtNumExt.Text
            .NumInt = txtNumInt.Text
            .Colonia = txtColonia.Text
            .CP = txtCP.Text
            .IdPoblacion = txtPoblacion.Key
            .IdMunicipio = txtMunicipio.Key
            .Tel1 = txtTel1.Text
            .Tel2 = txtTel2.Text
            .Fax = txtFax.Text
        End With
    End Sub

End Class