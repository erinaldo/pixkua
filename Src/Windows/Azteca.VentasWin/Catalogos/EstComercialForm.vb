Public Class EstComercialForm

    Private Sub EstComercialForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
        chkActivo.Checked = True
    End Sub

    Private Sub EstComercialForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EstComercialForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim Nodo As EstructuraComercialInfo = CType(PackageInfo, EstructuraComercialInfo)
        With Nodo
            txtNombre.Text = .Nombre
            txtPadre.Text = String.Empty
            If .IdPadre > 0 Then txtPadre.LoadInfo(.IdPadre)
            txtNivel.Text = .Nivel.ToString
            txtRuta.Text = .NamedPath
            chkActivo.Checked = (.Status = CatalogState.Active)
        End With
    End Sub

    Private Sub EstComercialForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim Nodo As EstructuraComercialInfo = CType(PackageInfo, EstructuraComercialInfo)
        With Nodo
            .Nombre = txtNombre.Text
            .IdPadre = txtPadre.Key
            If chkActivo.Checked Then
                .Status = CatalogState.Active
            Else
                .Status = CatalogState.Inactive
            End If
        End With
    End Sub
End Class