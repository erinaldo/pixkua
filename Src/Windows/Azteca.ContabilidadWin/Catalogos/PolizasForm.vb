Public Class PolizasForm

#Region "Implementacion de la forma"

    Private Sub PolizasForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
        bsRacs.DataSource = Nothing
    End Sub

    Private Sub PolizasForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillCombos()
    End Sub

    Private Sub PolizasForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As PolizaPerfilInfo = CType(PackageInfo, PolizaPerfilInfo)
        With info
            txtNombre.Text = .Descripcion
            cboPolizaOrigen.SelectedValue = .IdPolizaOrigen
            cboPolizaTipo.SelectedValue = .IdPolizaTipo
            cboSumarizacion.SelectedValue = .IdPolizaSumarizacion
            chkAcumulable.Checked = .Acumulable
            chkAfectar.Checked = .AfectarSistemaExterno
            cboVista.SelectedValue = .IdVistaContableTit
        End With
    End Sub

    Private Sub PolizasForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As PolizaPerfilInfo = CType(PackageInfo, PolizaPerfilInfo)
        With info
            .Descripcion = txtNombre.Text
            .IdPolizaOrigen = CInt(cboPolizaOrigen.SelectedValue)
            .IdPolizaTipo = CInt(cboPolizaTipo.SelectedValue)
            .IdPolizaSumarizacion = CInt(cboSumarizacion.SelectedValue)
            .Acumulable = chkAcumulable.Checked
            .AfectarSistemaExterno = chkAfectar.Checked
            .IdVistaContableTit = (cboVista.SelectedValue)
            .IdDocumentoTipo = 0 ''''''
        End With
    End Sub
#End Region

#Region "Eventos"
    Private Sub btnOrigenNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New PolizaOrigenForm
        If frm.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim PolFac As New PolizaPerfilFacade
            cboPolizaOrigen.DataSource = PolFac.getPolizasOrigenCBO(App.Session.SessionID)
        End If
    End Sub

#End Region

#Region "Eventos Racs"
    Private Sub btnRacAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRacAdd.Click
        Dim info As PolizaPerfilInfo = CType(PackageInfo, PolizaPerfilInfo)

        Dim frm As New RacForm
        frm.LoadingList(CInt(cboVista.SelectedValue))
        If frm.ShowDialog(Me, PackageInfo.Identity, 0) = System.Windows.Forms.DialogResult.OK Then
            fillRacs()
        End If

    End Sub

    Private Sub btnRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefrescar.Click
        Dim info As PolizaPerfilInfo = CType(PackageInfo, PolizaPerfilInfo)
        If info.Identity = 0 Then
            MessageBox.Show("Debe guardar primero el perfil de poliza para poder consultar sus Racs", "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        Try
            fillRacs()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdRacs_DeleteButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdRacs.DeleteButtonClick
        Try
            Dim racfac As New RacFacade
            racfac.Delete(App.Session.SessionID, e.ID)
            fillRacs()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdRacs_EditButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdRacs.EditButtonClick
        Dim info As PolizaPerfilInfo = CType(PackageInfo, PolizaPerfilInfo)

        If info.Identity = 0 Then
            MessageBox.Show("Debe guardar primero el perfil de poliza para poder consultar sus Racs", "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        Dim frm As New RacForm
        frm.LoadingList(CInt(cboVista.SelectedValue))
        If frm.ShowDialog(Me, PackageInfo.Identity, e.ID) = System.Windows.Forms.DialogResult.OK Then
            fillRacs()
        End If
    End Sub

#End Region

#Region "Racs  Metodos Privados"
    Private Sub FillCombos()
        Dim PolFac As New PolizaPerfilFacade
        cboPolizaOrigen.DisplayMember = "Descripcion" : cboPolizaOrigen.ValueMember = "Id" : cboPolizaOrigen.DataSource = PolFac.getPolizasOrigenCBO(App.Session.SessionID)
        cboPolizaTipo.DisplayMember = "Descripcion" : cboPolizaTipo.ValueMember = "Id" : cboPolizaTipo.DataSource = PolFac.getPolizasTiposCBO(App.Session.SessionID)
        cboSumarizacion.DisplayMember = "Descripcion" : cboSumarizacion.ValueMember = "Id" : cboSumarizacion.DataSource = PolFac.getPolizasSumarizacionesCBO(App.Session.SessionID)
        Dim VistaFac As New VistaContableFacade
        cboVista.DisplayMember = "Descripcion" : cboVista.ValueMember = "Id" : cboVista.DataSource = VistaFac.LoadList(App.Session.SessionID, 0)
    End Sub

    Private Sub fillRacs()
        Dim info As PolizaPerfilInfo = CType(PackageInfo, PolizaPerfilInfo)
        Dim PolizaPerfilfac As New PolizaPerfilFacade
        bsRacs.DataSource = PolizaPerfilfac.RacsList(App.Session.SessionID, info.Identity)
        grdRacs.Rebind(True)
    End Sub

#End Region

End Class