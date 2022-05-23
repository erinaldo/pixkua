Public Class PasillosForm
    Private Sub PasillosForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
    End Sub

    Private Sub PasillosForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As PasilloInfo = CType(Me.PackageInfo, PasilloInfo)
        With info
            txtNombre.Text = .Nombre
            cboAlmacen.SelectedValue = .IdAlmacen
            cboImpresora.SelectedValue = .IdImpresora
            If .IdCuenta > 0 Then selCuenta.LoadInfo(.IdCuenta)
        End With
    End Sub

    Private Sub PasillosForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As PasilloInfo = CType(Me.PackageInfo, PasilloInfo)
        With info
            .Nombre = txtNombre.Text
            .IdAlmacen = CInt(cboAlmacen.SelectedValue)
            .IdImpresora = CInt(cboImpresora.SelectedValue)
            .IdCuenta = selCuenta.Key
        End With
    End Sub

    Private Sub PasillosForm_LoadingLists(sender As Object, e As System.EventArgs) Handles Me.LoadingLists
        cboImpresora.LoadList()
        cboAlmacen.LoadList(App.DefaultSite.Identity)
    End Sub

End Class