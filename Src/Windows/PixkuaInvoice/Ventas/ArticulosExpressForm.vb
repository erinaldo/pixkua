Imports Azteca.Business.Ventas
Imports Azteca.Windows

Public Class ArticulosExpressForm
    Private ListaPrecios As New DataTable
    Public ArticuloRow As ZonasVentaDS.ArticulosRow

    Private Sub cmdAddListaPrecios_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdAddListaPrecios.Click
        Dim Nombre As String = String.Empty
        Try
            Nombre = MsgInput.GetString("Nueva Lista de Precios", "")
            If Nombre.Length = 0 Then Exit Sub
        Catch ex As Exception
            Exit Sub
        End Try

        Try
            Dim Lista As New Azteca.Business.Ventas.ListaPreciosInfo(App.Session.SessionID)
            Lista.Nombre = Nombre : Lista.Status = Azteca.Kernel.BusinessStructure.CatalogState.Active : Lista.IdSucursal = App.DefaultSite.Identity : Lista.IdEmpresa = App.DefaultCompany.Identity

            Dim ListaPreciosFac As New Azteca.Business.Ventas.ListaPreciosFacade
            ListaPreciosFac.Update(Lista)
            CargaListaPrecios(PackageInfo.Identity)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

    End Sub

    Private Sub ArticulosExpressForm_AddingItem(sender As Object, e As System.EventArgs) Handles Me.AddingItem
        CargaListaPrecios(0)
    End Sub

    Private Sub ArticulosExpressForm_ItemSaved(sender As Object, e As System.EventArgs) Handles Me.ItemSaved
        With ArticuloRow
            'Dim Articulo As Azteca.Business.Inventario.ArticuloStockInfo = CType(selArticuloStock.PackageInfo, Azteca.Business.Inventario.ArticuloStockInfo)
            '.CodigoArticulo = Articulo.UserCode
            '.NombreArticulo = Articulo.Nombre
            '.Precio = CInt(Val(txtPrecio.Text))
            .IdDivisa = CInt(cboDivisa.SelectedValue)
            '.Divisa = cboDivisa.Text
            '.DiasEntrega = CInt(nudDiasEntrega.Value)
            .IdImpuesto1 = CInt(cboImpuesto1.SelectedValue)
            .IdImpuesto2 = CInt(cboImpuesto2.SelectedValue)
            .IdImpuesto3 = CInt(cboImpuesto3.SelectedValue)
            .Impuesto1 = cboImpuesto1.Text
            .Impuesto2 = cboImpuesto2.Text
            .Impuesto3 = cboImpuesto3.Text
            .PorcRetencion1 = nudPorcRetencion1.Value / 100D
            .PorcRetencion2 = nudPorcRetencion2.Value / 100D
            .PorcRetencion3 = nudPorcRetencion3.Value / 100D
        End With
    End Sub

    Private Sub ArticulosExpressForm_LoadingItem(sender As Object, e As Azteca.Windows.Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim Articulo As ArticuloInfo = CType(PackageInfo, ArticuloInfo)
        With Articulo
            txtNombre.Text = .Nombre
            cboTipoUnidad.SelectedValue = .IdTipoUnidadMedida
            cboUnidadMedida.SelectedValue = .IdUnidadMedida
            'cboMarca.SelectedValue = .IdMarca
            'txtModelo.Text = .Modelo
            'txtEstCom.Text = String.Empty
            'If .IdEstCom > 0 Then txtEstCom.LoadInfo(.IdEstCom)
            '.IdCategoriaFlujo = 0
            CargaListaPrecios(.Identity)
            CargaImpuestos()
        End With
    End Sub

    Private Sub ArticulosExpressForm_LoadingLists(sender As Object, e As System.EventArgs) Handles Me.LoadingLists
        cboTipoUnidad.LoadList()
        cboImpuesto1.LoadList()
        cboImpuesto2.LoadList()
        cboImpuesto3.LoadList()
        cboDivisa.LoadList()
        Dim ConfigMgr As New Azteca.Kernel.Configuration.ConfigurationFacade
        Dim IdDivisaBase As Integer = CInt(ConfigMgr.GetSystemParameter("Configuracion/Contabilidad/Divisas", "Base"))
        cboDivisa.SelectedValue = IdDivisaBase
    End Sub

    Private Sub ArticulosExpressForm_SavingItem(sender As Object, e As Azteca.Windows.Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim Articulo As ArticuloInfo = CType(PackageInfo, ArticuloInfo)
        With Articulo
            .Nombre = txtNombre.Text
            .IdUnidadMedida = CInt(cboUnidadMedida.SelectedValue)
            .IdEstCom = 1
            .Modelo = ""
            .IdMarca = 1
        End With
    End Sub

    

    Private Sub cboTipoUnidad_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboTipoUnidad.SelectedIndexChanged
        If cboTipoUnidad.DataSource Is Nothing Then Exit Sub
        cboUnidadMedida.FilterExpression = "IdUnidadMedidaTipo=" & CInt(cboTipoUnidad.SelectedValue)
        cboUnidadMedida.LoadList()
    End Sub

    Private Sub grdListasPrecio_ButtonClick(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdListasPrecio.ButtonClick
        If bsListasPrecio.Current Is Nothing Then Exit Sub

        Dim row As DataRowView = CType(bsListasPrecio.Current, DataRowView)

        Dim frm As New Azteca.Windows.Ventas.ListaPreciosForm
        If frm.ShowDialog(CInt(row("IdListaPrecio")), "Editar Lista de Precios...") = System.Windows.Forms.DialogResult.OK Then
            CargaListaPrecios(PackageInfo.Identity)
        End If
    End Sub

    Private Sub CargaListaPrecios(IdArticulo As Integer)
        Dim PreciosFac As New Azteca.Business.Ventas.ListaPreciosFacade
        ListaPrecios = PreciosFac.ArticuloPreciosList(App.Session.SessionID, IdArticulo, App.DefaultSite.Identity)
        bsListasPrecio.DataSource = ListaPrecios
        grdListasPrecio.Rebind(True)
    End Sub

    Private Sub CargaImpuestos()
        cboDivisa.SelectedValue = ArticuloRow.IdDivisa
        cboImpuesto1.SelectedValue = ArticuloRow.IdImpuesto1
        cboImpuesto2.SelectedValue = ArticuloRow.IdImpuesto2
        cboImpuesto3.SelectedValue = ArticuloRow.IdImpuesto3
        nudPorcRetencion1.Value = ArticuloRow.PorcRetencion1 * 100
        nudPorcRetencion2.Value = ArticuloRow.PorcRetencion2 * 100
        nudPorcRetencion3.Value = ArticuloRow.PorcRetencion3 * 100
    End Sub

#Region "Metodos Sobrecargados"

    Protected Overrides Sub OnSaveItem(ByVal e As InfoEntryEventArgs)
        Dim ArtFac As New ArticuloFacade
        Dim ArtInf As ArticuloInfo = CType(PackageInfo, ArticuloInfo)
        cboDivisa.Focus()
        Dim PreciosTable As DataTable = CType(bsListasPrecio.DataSource, DataTable)

        ''''''If txtCodigo.Text <> Code Then txtCodigo.Text = Code
        ''''''MyBase.OnSaveItem(e)
        ArticulosExpressForm_SavingItem(Me, Nothing)

        If e.Cancel Then Return
        PackageInfo.UserCode = Me.CodeTextBox.Text ' txtCodigo.Text.Trim
        'Si no tiene una sucursal asignada, entonces asignar la sucursal actual en sesión
        If PackageInfo.IdSucursal = 0 Then PackageInfo.IdSucursal = App.DefaultSite.Identity
        If PackageInfo.IdEmpresa = 0 Then PackageInfo.IdEmpresa = App.DefaultCompany.Identity
        Dim ItemID As String = CStr(ArtFac.UpdateOnInventory(App.Session.SessionID, ArtInf, PreciosTable)) '' PackageInfo))
        'Guardamos el dato del recien articulo stock q se agrego para asignarlo al articulo de la zona de venta donde se va a colocar
        If ArticuloRow.IdArticuloStock = 0 Then ArticuloRow.IdArticuloStock = ArtFac.IdArticulostockExpressAdd

        PackageInfo = Facade.GetDetail(App.Session.SessionID, CInt(ItemID), False)
        'Si la llave es autogenerada y no se tiene un código, entonces asignar al código el identity
        If KeyMode = UserKeyMode.Autogenerated AndAlso PackageInfo.UserCode = String.Empty Then PackageInfo.UserCode = ItemID
        If KeyMode = UserKeyMode.Autogenerated Then
            e.Code = ItemID
        Else
            e.Code = PackageInfo.UserCode
        End If
        ''Si se activo la navegación entre registros, entonces cargar la tabla de navegación y sincronizar
        'If AllowRecordNavigation Then
        '    LoadNavigationTable()
        '    SyncCurrentRecord(CInt(ItemID))
        'End If
        If Me.CodeTextBox.Text = String.Empty Then Me.CodeTextBox.Text = ItemID
        'Mostrar mensaje de actualización si la opción está activada
        ''''''If ShowSaveMsg Then
        MessageBox.Show("Los cambios han sido actualizados con éxito.", "Información actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

#End Region



   
End Class