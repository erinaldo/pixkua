Public Class BancosForm

    Private Sub BancosForm_AddingItem(sender As Object, e As System.EventArgs) Handles Me.AddingItem
        Dim info As BancoInfo = CType(Me.PackageInfo, BancoInfo)
        bsChequeras.DataSource = info.Chequeras
        grdChequeras.Rebind(True)
    End Sub

    Private Sub BancosForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim CajasFac As New CajaFacade
        bsCajas.DataSource = CajasFac.List(App.Session.SessionID, App.DefaultCompany.Identity)
        dropCajas.Rebind(True)

        Dim Formatos As New Kernel.General.FormatManager
        bsFormatos.DataSource = Formatos.LoadList(App.Session.SessionID, App.DefaultCompany.Identity, App.DefaultSite.Identity, Kernel.General.FormatosTiposEnum.Cheques)
        dropFormatos.Rebind(True)

        Dim info As BancoInfo = CType(Me.PackageInfo, BancoInfo)
        bsChequeras.DataSource = info.Chequeras
        grdChequeras.Rebind(True)
    End Sub

    Private Sub BancosForm_LoadingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As BancoInfo = CType(Me.PackageInfo, BancoInfo)
        With info
            txtNombre.Text = .Nombre
            If .IdCuenta > 0 Then selCuenta.LoadInfo(.IdCuenta)
        End With
        bsChequeras.DataSource = info.Chequeras
        grdChequeras.Rebind(True)
    End Sub

    Private Sub BancosForm_SavingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As BancoInfo = CType(Me.PackageInfo, BancoInfo)
        With info
            .Nombre = txtNombre.Text
            .IdCuenta = selCuenta.Key
        End With
    End Sub

    Private Sub grdChequeras_BeforeColUpdate(sender As Object, e As C1.Win.C1TrueDBGrid.BeforeColUpdateEventArgs) Handles grdChequeras.BeforeColUpdate
        Try
            If e.Column.Name = "Cuenta" Then
                'Validar que se haya especificado una cuenta válida
                If Val(grdChequeras.Columns("Cuenta").Value) <= 0 Then Return
                Dim CuentaFac As New Azteca.Business.Contabilidad.CuentaFacade
                If CuentaFac.Exists(App.Session.SessionID, grdChequeras.Columns("Cuenta").Value.ToString, App.DefaultSite.Identity) Then
                    Dim Cuenta As Azteca.Business.Contabilidad.CuentaInfo = CuentaFac.GetDetail(App.Session.SessionID, grdChequeras.Columns("Cuenta").Value.ToString, App.DefaultSite.Identity, False)
                    grdChequeras.Columns("IdCuenta").Value = Cuenta.Identity
                    grdChequeras.Columns("Concepto").Value = Cuenta.Nombre
                Else
                    e.Cancel = True
                    MessageBox.Show("La cuenta especificada no existe.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdChequeras_ButtonClick(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdChequeras.ButtonClick
        Try
            If e.Column.Name = "Cuenta" Then
                Dim CuentaFac As New Azteca.Business.Contabilidad.CuentaFacade
                Dim frmSearch As New Azteca.Windows.Forms.MsgHierarchyForm
                frmSearch.StartPosition = FormStartPosition.CenterParent
                If frmSearch.ShowDialog(CuentaFac, CuentaFac) = System.Windows.Forms.DialogResult.OK Then
                    Dim Cuenta As Azteca.Business.Contabilidad.CuentaInfo = CuentaFac.GetDetail(App.Session.SessionID, frmSearch.SelectedId, False)
                    grdChequeras.Columns("IdCuenta").Value = Cuenta.Identity
                    grdChequeras.Columns("Cuenta").Value = Cuenta.UserCode
                    grdChequeras.Columns("Concepto").Value = Cuenta.Nombre
                End If
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub
End Class