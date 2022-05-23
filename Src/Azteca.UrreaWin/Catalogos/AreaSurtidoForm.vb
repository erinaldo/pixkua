Public Class AreaSurtidoForm

    Private Sub AreaSurtidoForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cboIdGrupoAreaSurtido.LoadList()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AreaSurtidoForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Try
            Dim areaInfo As AreaSurtidoInfo = CType(PackageInfo, AreaSurtidoInfo)

            txtNombre.Text = areaInfo.Nombre
            txtCapacidadHoraXUsuario.Text = areaInfo.CapacidadHoraXUsuario
            numCantUsuariosDef.Value = areaInfo.CantUsuariosDef
            cboIdGrupoAreaSurtido.SelectedValue = areaInfo.IdGrupoAreaSurtido

        Catch ex As Exception

        End Try
    End Sub

    Private Sub AreaSurtidoForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Try
            Dim areaInfo As AreaSurtidoInfo = CType(PackageInfo, AreaSurtidoInfo)

            areaInfo.Nombre = txtNombre.Text
            areaInfo.CapacidadHoraXUsuario = txtCapacidadHoraXUsuario.Text
            areaInfo.CantUsuariosDef = numCantUsuariosDef.Value
            areaInfo.IdGrupoAreaSurtido = cboIdGrupoAreaSurtido.SelectedValue
            areaInfo.IdSucursal = App.DefaultSite.Identity
            areaInfo.IdEmpresa = App.DefaultCompany.Identity

        Catch ex As Exception

        End Try
    End Sub

    Private Sub AreaSurtidoForm_AddingItem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.AddingItem
        numCantUsuariosDef.Value = 0
    End Sub
End Class