Public Class CategoriaPresupuestalArticulosAdmin
    Private ArticulosTable As ConfiguracionDS.CategoriasPresupuestalesArticulosDataTable
    Private _IdCategoria As Integer

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal IdCategoriaPresupuestal As Integer) As DialogResult
        Dim CatPresupFac As New CategoriaPresupuestalFacade
        _IdCategoria = IdCategoriaPresupuestal
        ArticulosTable = CatPresupFac.ArticulosList(App.Session.SessionID, IdCategoriaPresupuestal)
        bsArticulos.DataSource = ArticulosTable
        grdArticulos.Rebind(True)
        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub btnArticulosAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArticulosAdd.Click
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            Dim ArticulosFac As New Azteca.Business.Inventario.ArticuloStockFacade

            Dim lst As Azteca.Kernel.Search.IdentityList = Azteca.Windows.Forms.MsgList.Show(ArticulosFac, Nothing, True)
            For Each Id As String In lst
                Dim drExist As ConfiguracionDS.CategoriasPresupuestalesArticulosRow = ArticulosTable.FindByIdArticuloStock(CInt(Id))
                If drExist Is Nothing Then
                    'Obtenemos los datos del usuario
                    Dim ArtStockInfo As Azteca.Business.Inventario.ArticuloStockInfo = ArticulosFac.GetDetail(App.Session.SessionID, CInt(Id))
                    Dim drNew As ConfiguracionDS.CategoriasPresupuestalesArticulosRow = ArticulosTable.NewCategoriasPresupuestalesArticulosRow
                    With drNew
                        .IdArticuloStock = ArtStockInfo.Identity : .Codigo = ArtStockInfo.UserCode : .Articulo = ArtStockInfo.Nombre
                    End With
                    ArticulosTable.AddCategoriasPresupuestalesArticulosRow(drNew)
                Else
                    MessageBox.Show("El Articulo [" & drExist.Articulo & "] ya está incluido en la Categoria Presupuestal", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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
            CatPresupFac.ArticulosSave(App.Session.SessionID, _IdCategoria, ArticulosTable)
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            MessageBox.Show("Se ha guardado la información", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdArticulos_DeleteButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdArticulos.DeleteButtonClick
        Try
            Dim dv As New DataView(ArticulosTable, "IdArticuloStock=" & e.ID, "", DataViewRowState.CurrentRows)
            dv(0).Delete()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub
End Class