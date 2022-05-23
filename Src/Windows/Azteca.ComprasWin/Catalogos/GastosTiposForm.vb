Public Class GastosTiposForm

    Private Sub grdConceptos_BeforeColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColUpdateEventArgs) Handles grdConceptos.BeforeColUpdate
        Try
            If e.Column.Name = "Cuenta" Then
                'Validar que se haya especificado una cuenta válida
                If Val(grdConceptos.Columns("Cuenta").Value) <= 0 Then Return
                Dim CuentaFac As New Azteca.Business.Contabilidad.CuentaFacade
                If CuentaFac.Exists(App.Session.SessionID, grdConceptos.Columns("Cuenta").Value.ToString, App.DefaultSite.Identity) Then
                    Dim Cuenta As Azteca.Business.Contabilidad.CuentaInfo = CuentaFac.GetDetail(App.Session.SessionID, grdConceptos.Columns("Cuenta").Value.ToString, App.DefaultSite.Identity, False)
                    grdConceptos.Columns("IdCuenta").Value = Cuenta.Identity
                    grdConceptos.Columns("Descripcion").Value = Cuenta.Nombre
                Else
                    e.Cancel = True
                    MessageBox.Show("La cuenta especificada no existe.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdConceptos_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdConceptos.ButtonClick
        Try
            If e.Column.Name = "Cuenta" Then
                Dim CuentaFac As New Azteca.Business.Contabilidad.CuentaFacade
                Dim frmSearch As New Azteca.Windows.Forms.MsgHierarchyForm
                frmSearch.StartPosition = FormStartPosition.CenterParent
                If frmSearch.ShowDialog(CuentaFac, CuentaFac) = System.Windows.Forms.DialogResult.OK Then
                    Dim Cuenta As Azteca.Business.Contabilidad.CuentaInfo = CuentaFac.GetDetail(App.Session.SessionID, frmSearch.SelectedId, False)
                    grdConceptos.Columns("IdCuenta").Value = Cuenta.Identity
                    grdConceptos.Columns("Cuenta").Value = Cuenta.UserCode
                    grdConceptos.Columns("Descripcion").Value = Cuenta.Nombre
                End If
            End If

            If e.Column.Name = "Imp." Then

            End If


        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub GastosTiposForm_AddingItem(sender As Object, e As System.EventArgs) Handles Me.AddingItem
        Dim info As GastoConceptoTipoInfo = CType(PackageInfo, GastoConceptoTipoInfo)
        bsConceptos.DataSource = info.ConceptosTable
        grdConceptos.Rebind(True)
    End Sub

    Private Sub GastosTiposForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim info As GastoConceptoTipoInfo = CType(PackageInfo, GastoConceptoTipoInfo)
        bsConceptos.DataSource = info.ConceptosTable
        grdConceptos.Rebind(True)
    End Sub

    Private Sub GastosTiposForm_LoadingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As GastoConceptoTipoInfo = CType(PackageInfo, GastoConceptoTipoInfo)
        With info
            txtNombre.Text = .Nombre
            If .IdCuenta > 0 Then selCuenta.LoadInfo(.IdCuenta)
        End With
        bsConceptos.DataSource = info.ConceptosTable
        grdConceptos.Rebind(True)
    End Sub

    Private Sub GastosTiposForm_LoadingLists(sender As Object, e As System.EventArgs) Handles Me.LoadingLists
        Dim CatPresupFac As New CategoriaPresupuestalFacade
        bsCatPresup.DataSource = CatPresupFac.List(App.Session.SessionID, App.DefaultCompany.Identity)
        dropCategorias.Rebind(True)

    End Sub

    Private Sub GastosTiposForm_SavingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As GastoConceptoTipoInfo = CType(PackageInfo, GastoConceptoTipoInfo)
        With info
            .Nombre = txtNombre.Text
            .IdCuenta = selCuenta.Key
        End With
    End Sub

End Class