Public Class PuestosForm

    Private Sub PuestosForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem

    End Sub

    Private Sub PuestosForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chkActivo.Checked = True
    End Sub

    Private Sub PuestosForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim Nodo As PuestoInfo = CType(PackageInfo, PuestoInfo)
        With Nodo
            txtNombre.Text = .Nombre
            selPuesto.Text = String.Empty
            If .IdPadre > 0 Then selPuesto.LoadInfo(.IdPadre)
            selCuenta.Text = String.Empty
            If .IdCuenta > 0 Then selCuenta.LoadInfo(.IdCuenta)
            txtNivel.Text = .Nivel.ToString
            txtRuta.Text = .NamedPath
            chkActivo.Checked = (.Status = CatalogState.Active)
        End With
    End Sub

    Private Sub PuestosForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim Nodo As PuestoInfo = CType(PackageInfo, PuestoInfo)
        With Nodo
            .Nombre = txtNombre.Text
            .IdPadre = selPuesto.Key
            .IdCuenta = selCuenta.Key
            If chkActivo.Checked Then
                .Status = CatalogState.Active
            Else
                .Status = CatalogState.Inactive
            End If
        End With
    End Sub
End Class