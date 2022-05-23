Public Class SeguridadComprasForm
    Private dtCentrosRecepcion As UsuariosAccesoDS.CentrosRecepcionDataTable
    Private dtDepartamentos As UsuariosAccesoDS.DepartamentosDataTable
    Private dtCentrales As UsuariosAccesoDS.CentralesDataTable
    Private CentroRecepFac As CentroRecepcionFacade
    Private DeptoFac As DepartamentoFacade
    Private CentralFac As CentralFacade

    Private Sub txtUsuario_InfoLoaded(sender As System.Object, e As System.EventArgs) Handles txtUsuario.InfoLoaded
        If txtUsuario.Key > 0 Then
            Try
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                dtCentrosRecepcion = CentroRecepFac.CargarUsuarioAccesos(App.Session.SessionID, txtUsuario.Key)
                dtDepartamentos = DeptoFac.CargarUsuarioAccesos(App.Session.SessionID, txtUsuario.Key)
                dtCentrales = CentralFac.CargarUsuarioAccesos(App.Session.SessionID, txtUsuario.Key)
                bsCentrosRecepcion.DataSource = dtCentrosRecepcion
                bsDepartamentos.DataSource = dtDepartamentos
                bsCentralesCompra.DataSource = dtCentrales
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub txtUsuario_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsuario.TextChanged
        If txtUsuario.Key = 0 Then
            bsDepartamentos.DataSource = Nothing
            bsCentralesCompra.DataSource = Nothing
            bsCentrosRecepcion.DataSource = Nothing
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            CentroRecepFac.GuardarUsuarioAccesos(App.Session.SessionID, txtUsuario.Key, dtCentrosRecepcion)
            dtCentrosRecepcion.AcceptChanges()
            DeptoFac.GuardarUsuarioAccesos(App.Session.SessionID, txtUsuario.Key, dtDepartamentos)
            dtDepartamentos.AcceptChanges()
            CentralFac.GuardarUsuarioAccesos(App.Session.SessionID, txtUsuario.Key, dtCentrales)
            dtCentrales.AcceptChanges()
            MessageBox.Show("Los cambios han sido guardados con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub SeguridadComprasForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CentroRecepFac = New CentroRecepcionFacade
        DeptoFac = New DepartamentoFacade
        CentralFac = New CentralFacade
    End Sub
End Class