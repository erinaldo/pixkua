Public Class DepartamentosAccesosForm
    Private UsuariosTable As ConfiguracionDS.DepartamentosAccesosDataTable
    Private _IdDepartamento As Integer

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal IdDepartamento As Integer) As DialogResult
        Dim DeptoFac As New DepartamentoFacade
        _IdDepartamento = IdDepartamento
        UsuariosTable = DeptoFac.AccesosList(App.Session.SessionID, IdDepartamento)
        bsAccesos.DataSource = UsuariosTable
        grdUsuarios.Rebind(True)
        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub btnUsuariosAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsuariosAdd.Click
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            Dim UsuariosFac As New Azteca.Kernel.Security.UsuarioFacade

            Dim lst As Azteca.Kernel.Search.IdentityList = Azteca.Windows.Forms.MsgList.Show(UsuariosFac, Nothing, True)
            For Each Id As String In lst
                Dim drExist As ConfiguracionDS.DepartamentosAccesosRow = UsuariosTable.FindByIdUsuario(CInt(Id))
                If drExist Is Nothing Then
                    'Obtenemos los datos del usuario
                    Dim userInfo As Azteca.Kernel.Security.UsuarioInfo = UsuariosFac.GetDetail(App.Session.SessionID, CInt(Id))
                    Dim drNew As ConfiguracionDS.DepartamentosAccesosRow = UsuariosTable.NewDepartamentosAccesosRow
                    With drNew
                        .IdUsuario = userInfo.Identity : .Usuario = userInfo.UserCode : .Nombre = userInfo.Persona.Nombre + " " + userInfo.Persona.ApellidoP + " " + userInfo.Persona.ApellidoM
                    End With
                    UsuariosTable.AddDepartamentosAccesosRow(drNew)
                Else
                    MessageBox.Show("El Usuario[" & drExist.Nombre & "] ya está incluido en el Departamento", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            Next
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub


    Private Sub btnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            Dim DeptoFac As New DepartamentoFacade
            DeptoFac.AccesosSave(App.Session.SessionID, _IdDepartamento, UsuariosTable)
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            MessageBox.Show("Se ha guardado la información", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdUsuarios_DeleteButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdUsuarios.DeleteButtonClick
        Try
            Dim dv As New DataView(UsuariosTable, "IdUsuario=" & e.ID, "", DataViewRowState.CurrentRows)
            dv(0).Delete()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub
End Class