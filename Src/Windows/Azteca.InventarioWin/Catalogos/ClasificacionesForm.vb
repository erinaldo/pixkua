Public Class ClasificacionesForm

    Private Sub CargarEntidades()
        Dim GrupoFac As New GrupoClasificacionesFacade
        Dim dtEntidades As DataTable = GrupoFac.CargarEntidades(App.Session.SessionID)
        cboEntidad.DataSource = dtEntidades
        cboEntidad.DisplayMember = "Nombre"
        cboEntidad.ValueMember = "IdClasificacionEntidad"
    End Sub

    Private Sub ClasificacionesForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
        Dim Grupo As GrupoClasificacionesInfo = CType(PackageInfo, GrupoClasificacionesInfo)
        bsClasificaciones.DataSource = Grupo.Clasificaciones
        grdClasificaciones.Rebind(True)
    End Sub

    Private Sub ClasificacionesForm_ItemSaved(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ItemSaved
        Dim Grupo As GrupoClasificacionesInfo = CType(PackageInfo, GrupoClasificacionesInfo)
        LoadItem(Grupo.Identity)
        Grupo = CType(PackageInfo, GrupoClasificacionesInfo)
        bsClasificaciones.DataSource = Grupo.Clasificaciones
        grdClasificaciones.Rebind(True)
    End Sub

    Private Sub ClasificacionesForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            grdClasificaciones.Columns("Cuenta").EditMask = App.DefaultCompany.FormatoContable
        Catch ex As Exception
            MsgInfo.Show(ex)
            Close()
        End Try
    End Sub

    Private Sub ClasificacionesForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim Grupo As GrupoClasificacionesInfo = CType(PackageInfo, GrupoClasificacionesInfo)
        With Grupo
            cboEntidad.SelectedValue = .IdEntidad
            txtNombre.Text = .Nombre
            chkRequerido.Checked = .Requerido
        End With
        bsClasificaciones.DataSource = Grupo.Clasificaciones
        grdClasificaciones.Rebind(True)
    End Sub

    Private Sub ClasificacionesForm_LoadingLists(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LoadingLists
        CargarEntidades()
    End Sub

    Private Sub ClasificacionesForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim Grupo As GrupoClasificacionesInfo = CType(PackageInfo, GrupoClasificacionesInfo)
        With Grupo
            .IdEntidad = CInt(cboEntidad.SelectedValue)
            .Nombre = txtNombre.Text
            .Requerido = chkRequerido.Checked
        End With
    End Sub

#Region "Clasificaciones"

    Private Sub grdClasificaciones_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdClasificaciones.AfterColUpdate
        Try
            If e.Column.Name = "Clasificación" Then
                grdClasificaciones.UpdateData()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdClasificaciones_BeforeColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColEditEventArgs) Handles grdClasificaciones.BeforeColEdit
        If e.Column.Name <> "Clasificación" And grdClasificaciones.Columns("Clasificación").Text.Trim = String.Empty Then
            e.Cancel = True
            MessageBox.Show("Primero debe capturar el nombre de la clasificación", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub grdClasificaciones_BeforeColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColUpdateEventArgs) Handles grdClasificaciones.BeforeColUpdate
        Dim Grupo As GrupoClasificacionesInfo = CType(PackageInfo, GrupoClasificacionesInfo)
        If e.Column.Name = "Clasificación" Then
            Try
                'Verificar que no exista otra clasificación con el mismo nombre
                If Grupo.Clasificaciones.FindByNombre(grdClasificaciones.Columns("Clasificación").Text) IsNot Nothing Then
                    e.Cancel = True
                    MessageBox.Show("Ya existe una clasificación con el mismo nombre.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        End If
        '
        If bsClasificaciones.Current IsNot Nothing AndAlso e.Column.Name = "Cuenta" Then
            Try
                'Validar que se haya especificado una cuenta válida
                If Val(grdClasificaciones.Columns("Cuenta").Value) <= 0 Then Return
                Dim CuentaFac As New Azteca.Business.Contabilidad.CuentaFacade
                If CuentaFac.Exists(App.Session.SessionID, grdClasificaciones.Columns("Cuenta").Value.ToString, App.DefaultSite.Identity) Then
                    Dim Cuenta As Azteca.Business.Contabilidad.CuentaInfo = CuentaFac.GetDetail(App.Session.SessionID, grdClasificaciones.Columns("Cuenta").Value.ToString, App.DefaultSite.Identity, False)
                    grdClasificaciones.Columns("IdCuenta").Value = Cuenta.Identity
                    grdClasificaciones.Columns("Descripción").Value = Cuenta.Nombre
                Else
                    e.Cancel = True
                    MessageBox.Show("La cuenta especificada no existe.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        End If

    End Sub

    Private Sub grdClasificaciones_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdClasificaciones.ButtonClick
        If bsClasificaciones.Current IsNot Nothing Then
            Try
                If e.Column.Name = "Cuenta" Then
                    Dim CuentaFac As New Azteca.Business.Contabilidad.CuentaFacade
                    Dim frmSearch As New Azteca.Windows.Forms.MsgHierarchyForm
                    If frmSearch.ShowDialog(CuentaFac, CuentaFac) = System.Windows.Forms.DialogResult.OK Then
                        Dim Cuenta As Azteca.Business.Contabilidad.CuentaInfo = CuentaFac.GetDetail(App.Session.SessionID, frmSearch.SelectedId, False)
                        grdClasificaciones.Columns("IdCuenta").Value = Cuenta.Identity
                        grdClasificaciones.Columns("Cuenta").Value = Cuenta.UserCode
                        grdClasificaciones.Columns("Descripción").Value = Cuenta.Nombre
                    End If
                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        End If
    End Sub

#End Region

End Class