Public Class SeguridadInventarioForm
    Private AlmacenFac As AlmacenFacade
    Private AreaFac As AreaFacade
    Private dtAlmacenes As UsuarioAccesosDS.AlmacenesDataTable
    Private dtAreas As UsuarioAccesosDS.AreasDataTable

    Private Sub SeguridadInventarioForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AlmacenFac = New AlmacenFacade
        AreaFac = New AreaFacade
    End Sub

    Private Sub txtUsuario_InfoLoaded(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsuario.InfoLoaded
        If txtUsuario.Key > 0 Then
            Try
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                dtAlmacenes = AlmacenFac.CargarUsuarioAccesos(App.Session.SessionID, txtUsuario.Key)
                dtAreas = AreaFac.CargarUsuarioAccesos(App.Session.SessionID, txtUsuario.Key)
                bsAlmacenes.DataSource = dtAlmacenes
                bsAreas.DataSource = dtAreas
                cboSucursal.LoadList(App.DefaultCompany.Identity, txtUsuario.Key)
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub cboSucursal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSucursal.SelectedIndexChanged
        If cboSucursal.SelectedIndex >= 0 Then
            Try
                bsAreas.Filter = "IdSucursal=" & cboSucursal.SelectedValue.ToString
                bsAlmacenes.Filter = "IdSucursal=" & cboSucursal.SelectedValue.ToString
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        End If
    End Sub

    Private Sub txtUsuario_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If txtUsuario.Key = 0 Then
            cboSucursal.DataSource = Nothing
            bsAlmacenes.DataSource = Nothing
            bsAreas.DataSource = Nothing
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdGuardar.Click
        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            AreaFac.GuardarUsuarioAccesos(App.Session.SessionID, txtUsuario.Key, dtAreas)
            dtAreas.AcceptChanges()
            AlmacenFac.GuardarUsuarioAccesos(App.Session.SessionID, txtUsuario.Key, dtAlmacenes)
            dtAlmacenes.AcceptChanges()
            MessageBox.Show("Los cambios han sido guardados con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub
End Class