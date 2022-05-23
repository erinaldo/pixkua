Public Class CajasForm

    Private Sub CajasForm_AddingItem(sender As Object, e As System.EventArgs) Handles Me.AddingItem
        btnSave.Enabled = False : btnUsuariosAdd.Enabled = False
    End Sub

    Private Sub CajasForm_LoadingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As CajaInfo = CType(Me.PackageInfo, CajaInfo)
        With info
            txtNombre.Text = .Nombre
            If .IdCuenta > 0 Then selCuenta.LoadInfo(.IdCuenta)
            cboChequera.LoadList(PackageInfo.Identity)
            cboChequera.SelectedValue = .IdChequeraPredeterminada
        End With
        btnSave.Enabled = False : btnUsuariosAdd.Enabled = False
    End Sub

    Private Sub CajasForm_SavingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As CajaInfo = CType(Me.PackageInfo, CajaInfo)
        With info
            .Nombre = txtNombre.Text
            .IdCuenta = selCuenta.Key
            .IdChequeraPredeterminada = CInt(cboChequera.SelectedValue)
        End With
    End Sub

    Private Sub btnRefrescar_Click(sender As System.Object, e As System.EventArgs) Handles btnRefrescar.Click
        If PackageInfo.Identity = 0 Then
            MessageBox.Show("Debe guardar primero la información", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        Try
            Dim CajaFac As New CajaFacade
            bsAccesos.DataSource = CajaFac.Accesos(App.Session.SessionID, PackageInfo.Identity)
            grdAccesos.Rebind(True)
            btnSave.Enabled = True : btnUsuariosAdd.Enabled = True
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If PackageInfo.Identity = 0 Then
            MessageBox.Show("Debe guardar primero la información", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        Try
            Dim CajaFac As New CajaFacade
            CajaFac.AccesosSave(App.Session.SessionID, PackageInfo.Identity, CType(bsAccesos.DataSource, DataTable))
            MessageBox.Show("La información de accesos ha sido guardada", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnUsuariosAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnUsuariosAdd.Click
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            Dim UsuariosFac As New Azteca.Kernel.Security.UsuarioFacade
            Dim UsuariosTable As DataTable = CType(bsAccesos.DataSource, DataTable)

            Dim lst As Azteca.Kernel.Search.IdentityList = Azteca.Windows.Forms.MsgList.Show(UsuariosFac, Nothing, True)
            For Each Id As String In lst
                Dim drExist As DataRow = FindByIdUsuario(CInt(Id))
                If drExist Is Nothing Then
                    'Obtenemos los datos del usuario
                    Dim userInfo As Azteca.Kernel.Security.UsuarioInfo = UsuariosFac.GetDetail(App.Session.SessionID, CInt(Id))
                    Dim drNew As DataRow = UsuariosTable.NewRow
                    drNew("IdUsuario") = userInfo.Identity : drNew("Usuario") = userInfo.UserCode : drNew("Nombre") = userInfo.Persona.Nombre + " " + userInfo.Persona.ApellidoP + " " + userInfo.Persona.ApellidoM
                    UsuariosTable.Rows.Add(drNew)
                Else
                    MessageBox.Show("El Usuario[" & drExist("Nombre") & "] ya está incluido en la caja", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            Next
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Function FindByIdUsuario(Id As Integer) As DataRow
        Dim dr As DataRow = Nothing
        Dim dv As New DataView(CType(bsAccesos.DataSource, DataTable), "IdUsuario=" & Id, "", DataViewRowState.CurrentRows)
        If dv.Count > 0 Then Return dv(0).Row
        Return dr
    End Function

    Private Sub grdAccesos_DeleteButtonClick(sender As Object, e As Controls.GridViewCatalogButtonEventArgs) Handles grdAccesos.DeleteButtonClick
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            Dim dv As New DataView(CType(bsAccesos.DataSource, DataTable), "IdUsuario=" & e.ID, "", DataViewRowState.CurrentRows)
            If dv.Count > 0 Then dv(0).Row.Delete()
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

  
    Private Sub cboChequera_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub
End Class