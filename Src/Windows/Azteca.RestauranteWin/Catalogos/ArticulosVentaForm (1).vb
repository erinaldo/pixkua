Public Class ArticulosVentaForm

    Public Overrides Sub AgregarPresentacion()
        Dim ArticuloFac As New Azteca.Business.Ventas.ArticuloFacade
        Dim frmArticulosRestaurante As New ArticulosForm
        frmArticulosRestaurante.StartPosition = FormStartPosition.CenterParent
        With frmArticulosRestaurante
            .LoadLists()
            .txtNombre.Text = MyBase.Articulo_Nombre '' txtNombre.Text
            .cboTipoUnidad.SelectedValue = MyBase.Articulo_IdTipoUnidad '' cboTipoUnidad.SelectedValue
            .cboUnidadMedida.SelectedValue = MyBase.Articulo_IdUnidadMedida '' cboUnidadMedida.SelectedValue
            .txtNombre.Focus()
        End With

        'Si el artículo aun no contiene ninguna presentación, sugerir datos y código de este artículo
        If MyBase.Articulo_Presentaciones.Count = 0 Then
            If frmArticulosRestaurante.ShowDialog(Me, Code, "Agregar presentación del artículo de restaurante") = System.Windows.Forms.DialogResult.OK Then
                Dim ArtRestauranteInfo As ArticuloInfo = CType(frmArticulosRestaurante.PackageInfo, ArticuloInfo)
                ArticuloFac.AgregarPresentacion(App.Session.SessionID, PackageInfo.Identity, ArtRestauranteInfo.ArticuloStock.Identity)
                CargarPresentaciones()
            End If
        Else
            If frmArticulosRestaurante.ShowDialog(Me, String.Empty, "Agregar presentación del artículo de restaurante") = System.Windows.Forms.DialogResult.OK Then
                Dim ArtRestauranteInfo As ArticuloInfo = CType(frmArticulosRestaurante.PackageInfo, ArticuloInfo)
                ArticuloFac.AgregarPresentacion(App.Session.SessionID, PackageInfo.Identity, frmArticulosRestaurante.PackageInfo.Identity)
                CargarPresentaciones()
            End If
        End If
    End Sub

    Public Overrides Sub ShowEditPresentacion()
        Dim Artfac As New ArticuloFacade
        'se trae el id del articulo stock. A partir de el se obtiene el del articulo del restaurante pa mostrarlo en la forma de catalogo
        Dim IdArticuloRest As Integer = Artfac.getArticuloFromArticuloStock(App.Session.SessionID, MyBase.Articulo_IdArticuloStockEditing)

        Dim frmArticulosRest As New ArticulosForm
        frmArticulosRest.StartPosition = FormStartPosition.CenterParent
        If frmArticulosRest.ShowDialog(Me, IdArticuloRest, "Editar presentación del artículo") = System.Windows.Forms.DialogResult.OK Then
            CargarPresentaciones()
        End If
    End Sub

End Class