Public Class EntidadesForm

    Private Sub EntidadesForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As EntidadInfo = CType(Me.PackageInfo, EntidadInfo)
        With info
            txtNombre.Text = .Entidad
            txtSchema.Text = .Schema
            txtObjeto.Text = .Objeto
            txtAlias.Text = .Aliass
            txtCampoPK.Text = .CampoPK
            txtCampoName.Text = .CampoName
        End With
    End Sub

    Private Sub EntidadesForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As EntidadInfo = CType(Me.PackageInfo, EntidadInfo)
        With info
            .Entidad = txtNombre.Text
            .Schema = txtSchema.Text
            .Objeto = txtObjeto.Text
            .Aliass = txtAlias.Text
            .CampoPK = txtCampoPK.Text
            .CampoName = txtCampoName.Text
        End With
    End Sub

End Class