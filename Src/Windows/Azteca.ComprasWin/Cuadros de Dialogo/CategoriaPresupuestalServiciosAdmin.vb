Public Class CategoriaPresupuestalServiciosAdmin
    Private ServiciosTable As ConfiguracionDS.CategoriasPresupuestalesServiciosDataTable
    Private _IdCategoria As Integer

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal IdCategoriaPresupuestal As Integer) As DialogResult
        Dim CatPresupFac As New CategoriaPresupuestalFacade
        _IdCategoria = IdCategoriaPresupuestal
        ServiciosTable = CatPresupFac.ServiciosList(App.Session.SessionID, IdCategoriaPresupuestal)
        bsServicios.DataSource = ServiciosTable
        grdServicios.Rebind(True)
        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub btnServiciosAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnServiciosAdd.Click
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            Dim ServiciosFac As New ServicioFacade

            Dim lst As Azteca.Kernel.Search.IdentityList = Azteca.Windows.Forms.MsgList.Show(ServiciosFac, Nothing, True)
            For Each Id As String In lst
                Dim drExist As ConfiguracionDS.CategoriasPresupuestalesServiciosRow = ServiciosTable.FindByIdServicio(CInt(Id))
                If drExist Is Nothing Then
                    'Obtenemos los datos del servicio
                    Dim ServicioInfo As ServicioInfo = ServiciosFac.GetDetail(App.Session.SessionID, CInt(Id))
                    Dim drNew As ConfiguracionDS.CategoriasPresupuestalesServiciosRow = ServiciosTable.NewCategoriasPresupuestalesServiciosRow
                    With drNew
                        .IdServicio = ServicioInfo.Identity : .Servicio = ServicioInfo.Nombre
                    End With
                    ServiciosTable.AddCategoriasPresupuestalesServiciosRow(drNew)
                Else
                    MessageBox.Show("El Servicio [" & drExist.Servicio & "] ya está incluido en la Categoria Presupuestal", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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
            Dim CatPresupFac As New CategoriaPresupuestalFacade
            CatPresupFac.ServiciosSave(App.Session.SessionID, _IdCategoria, ServiciosTable)
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            MessageBox.Show("Se ha guardado la información", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdServicios_DeleteButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdServicios.DeleteButtonClick
        Try
            Dim dv As New DataView(ServiciosTable, "IdServicio=" & e.ID, "", DataViewRowState.CurrentRows)
            dv(0).Delete()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub
End Class