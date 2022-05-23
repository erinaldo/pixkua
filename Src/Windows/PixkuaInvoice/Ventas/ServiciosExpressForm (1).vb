Imports Azteca.Business.Ventas
Imports Azteca.Windows

Public Class ServiciosExpressForm
    Private ListaPrecios As New DataTable
    Public ServicioRow As ZonasVentaDS.ServiciosRow

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

    Private Sub ServiciosExpressForm_AddingItem(sender As Object, e As System.EventArgs) Handles Me.AddingItem
        CargaListaPrecios(0)
    End Sub

    Private Sub ServiciosExpressForm_ItemSaved(sender As Object, e As System.EventArgs) Handles Me.ItemSaved
        'Guardamos la lista de precios
        Try
            chkConceptoLibre.Focus()
            Dim PreciosFac As New Azteca.Business.Ventas.ListaPreciosFacade
            Dim PreciosTable As DataTable = CType(bsListasPrecio.DataSource, DataTable)
            PreciosFac.ServiciosPreciosSave(App.Session.SessionID, PackageInfo.Identity, PreciosTable)

            With ServicioRow
                'Dim Articulo As Azteca.Business.Inventario.ArticuloStockInfo = CType(selArticuloStock.PackageInfo, Azteca.Business.Inventario.ArticuloStockInfo)
                '.CodigoArticulo = Articulo.UserCode
                '.NombreArticulo = Articulo.Nombre
                '.Precio = CInt(Val(txtPrecio.Text))
                .IdDivisa = CInt(cboDivisa.SelectedValue)
                '.Divisa = cboDivisa.Text
                '.DiasEntrega = CInt(nudDiasEntrega.Value)
                .IdServicio = PackageInfo.Identity
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

        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally

        End Try
    End Sub

    Private Sub ServiciosExpressForm_LoadingItem(sender As Object, e As Azteca.Windows.Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim Servicio As ServicioInfo = CType(PackageInfo, ServicioInfo)
        With Servicio
            txtNombre.Text = .Nombre
            chkConceptoLibre.Checked = .ConceptoLibre
            CargaListaPrecios(.Identity)
            CargaImpuestos()
        End With
    End Sub

    Private Sub ServiciosExpressForm_LoadingLists(sender As Object, e As System.EventArgs) Handles Me.LoadingLists
        cboImpuesto1.LoadList()
        cboImpuesto2.LoadList()
        cboImpuesto3.LoadList()
        cboDivisa.LoadList()
        Dim ConfigMgr As New Azteca.Kernel.Configuration.ConfigurationFacade
        Dim IdDivisaBase As Integer = CInt(ConfigMgr.GetSystemParameter("Configuracion/Contabilidad/Divisas", "Base"))
        cboDivisa.SelectedValue = IdDivisaBase
    End Sub

    Private Sub ServiciosExpressForm_SavingItem(sender As Object, e As Azteca.Windows.Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim Servicio As ServicioInfo = CType(PackageInfo, ServicioInfo)
        With Servicio
            .Nombre = txtNombre.Text
            .ConceptoLibre = chkConceptoLibre.Checked
            .IdEstructuraComercial = 1
        End With
    End Sub

    Private Sub CargaListaPrecios(IdServicio As Integer)
        Dim PreciosFac As New Azteca.Business.Ventas.ListaPreciosFacade
        ListaPrecios = PreciosFac.ServicioPreciosList(App.Session.SessionID, IdServicio, App.DefaultSite.Identity)
        bsListasPrecio.DataSource = ListaPrecios
        grdListasPrecio.Rebind(True)
    End Sub

    Private Sub CargaImpuestos()
        cboDivisa.SelectedValue = ServicioRow.IdDivisa
        cboImpuesto1.SelectedValue = ServicioRow.IdImpuesto1
        cboImpuesto2.SelectedValue = ServicioRow.IdImpuesto2
        cboImpuesto3.SelectedValue = ServicioRow.IdImpuesto3
        nudPorcRetencion1.Value = ServicioRow.PorcRetencion1 * 100
        nudPorcRetencion2.Value = ServicioRow.PorcRetencion2 * 100
        nudPorcRetencion3.Value = ServicioRow.PorcRetencion3 * 100
    End Sub

   
End Class