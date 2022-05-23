Public Class DepartamentosForm

    Private Sub DepartamentosForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
        chkActivo.Checked = True
    End Sub

    Private Sub DepartamentosForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim Nodo As DepartamentoInfo = CType(PackageInfo, DepartamentoInfo)
        With Nodo
            txtNombre.Text = .Nombre
            selDepartamento.Text = String.Empty
            If .IdPadre > 0 Then selDepartamento.LoadInfo(.IdPadre)
            selCuenta.Text = String.Empty
            If .IdCuenta > 0 Then selCuenta.LoadInfo(.IdCuenta)
            txtNivel.Text = .Nivel.ToString
            txtRuta.Text = .NamedPath
            chkActivo.Checked = (.Status = CatalogState.Active)
        End With
    End Sub

    Private Sub DepartamentosForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim Nodo As DepartamentoInfo = CType(PackageInfo, DepartamentoInfo)
        With Nodo
            .Nombre = txtNombre.Text
            .IdPadre = selDepartamento.Key
            .IdCuenta = selCuenta.Key
            If chkActivo.Checked Then
                .Status = CatalogState.Active
            Else
                .Status = CatalogState.Inactive
            End If
        End With
    End Sub

End Class