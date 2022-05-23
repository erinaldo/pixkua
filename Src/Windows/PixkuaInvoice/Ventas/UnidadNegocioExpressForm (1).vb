Imports Azteca.Windows
Imports Azteca.Business.Ventas

Public Class UnidadNegocioExpressForm

    Private Sub UnidadesNegocioForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'LoadItem(Context.UnidadNegocio.Identity)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub UnidadesNegocioForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim UnidadNegocio As UnidadNegocioInfo = CType(PackageInfo, UnidadNegocioInfo)
        'cboRegion.LoadList(UnidadNegocio.IdEmpresa)
        'cboZonaVenta.LoadList(UnidadNegocio.IdEmpresa)
        cboFormatoFactura.LoadList(UnidadNegocio.IdEmpresa, UnidadNegocio.IdSucursal)
        cboFormatoDev.LoadList(UnidadNegocio.IdEmpresa, UnidadNegocio.IdSucursal)
        'cboRemitente.LoadList(UnidadNegocio.IdEmpresa)

        'cboTicketComanda.LoadList(UnidadNegocio.IdEmpresa, UnidadNegocio.IdSucursal)
        'cboTicketPedimento.LoadList(UnidadNegocio.IdEmpresa, UnidadNegocio.IdSucursal)
        'cboTicketPOS.LoadList(UnidadNegocio.IdEmpresa, UnidadNegocio.IdSucursal)

        'cboAlmacen.LoadList(UnidadNegocio.IdSucursal)
        With UnidadNegocio
            'Facturación            
            txtSerieFact.Text = String.Empty
            If .IdSerieFacturas > 0 Then txtSerieFact.LoadInfo(.IdSerieFacturas)
            cboFormatoFactura.SelectedValue = .IdFormatoFacturas
            'txtClienteGenFact.Text = String.Empty
            'If .IdClienteFacturacion > 0 Then txtClienteGenFact.LoadInfo(.IdClienteFacturacion)
            'Devoluciones
            cboFormatoDev.SelectedValue = .IdFormatoDevoluciones
            If .IdSerieDevoluciones > 0 Then txtSerieDev.LoadInfo(.IdSerieDevoluciones)
            'Inventario
            chkAfectarInv.Checked = .AfectarInventario
            'cboAlmacen.SelectedValue = .IdAlmacen
            'If .AfectarInventarioLinea Then
            'rdbAfectInvLinea.Checked = True
            'Else
            'rdbAfectInvBatch.Checked = True
            'End If
            'Ventas
            'cboRegion.SelectedValue = .IdRegion
            'cboZonaVenta.SelectedValue = .IdZonaVenta
            'If .TipoPrecio = TipoPrecio.ListaPrecio Then
            'rdbListaPrecio.Checked = True
            'Else
            'rdbZonasVenta.Checked = True
            'End If
            cboDivisaBase.SelectedValue = .IdDivisaBase
            'txtClienteGen.Text = String.Empty
            'If .IdClienteGenerico > 0 Then txtClienteGen.LoadInfo(.IdClienteGenerico)
            txtGLN.Text = .GLN
            With .Sucursal
                'Datos Generales
                txtNombreCorto.Text = .Nombre
                'txtNombreLargo.Text = .NombreLargo
                cboEmpresa.SelectedValue = .IdEmpresa
                'txtTel1.Text = .Telefono1
                'txtTel2.Text = .Telefono2
                'txtFax.Text = .Fax
                'txtCorreo.Text = .Correo
                'txtPagWeb.Text = .PaginaWeb
                'Domicilio
                txtCalle.Text = .Calle
                txtNumExt.Text = .NumExt
                txtNumInt.Text = .NumInt
                txtColonia.Text = .Colonia
                txtCP.Text = .CP
                'Cargar información de la población
                txtPoblacion.Text = CStr(.IdPoblacion)
                txtPoblacion.LoadInfo()
                '
                .Status = UnidadNegocio.Status
                .UserCode = UnidadNegocio.UserCode
            End With
            'Notificaciones
            chkEnviarFact.Checked = .EnviarFacturas
            'cboRemitente.SelectedValue = .IdRemitente
            'Punto de venta
            'cboTicketComanda.SelectedValue = .IdFormatoTicketComanda
            'cboTicketPedimento.SelectedValue = .IdFormatoTicketPedimento
            'cboTicketPOS.SelectedValue = .IdFormatoTicketPOS

        End With
    End Sub

    Private Sub UnidadesNegocioForm_LoadingLists(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LoadingLists
        cboEmpresa.LoadList()
        cboDivisaBase.LoadList()
        cboEmpresa.LoadList()
    End Sub

    Private Sub UnidadesNegocioForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim UnidadNegocio As UnidadNegocioInfo = CType(PackageInfo, UnidadNegocioInfo)
        With UnidadNegocio
            .Nombre = txtNombreCorto.Text
            .IdEmpresa = CInt(cboEmpresa.SelectedValue)

            'Facturación
            .SerieFacturas = String.Empty
            .IdSerieFacturas = txtSerieFact.Key
            .FacturacionElectronica = True
            .IdFormatoFacturas = CInt(cboFormatoFactura.SelectedValue)
            '.IdClienteFacturacion = txtClienteGenFact.Key
            'Devoluciones
            .IdSerieDevoluciones = txtSerieDev.Key
            .IdFormatoDevoluciones = CInt(cboFormatoDev.SelectedValue)
            'Inventario
            .AfectarInventario = chkAfectarInv.Checked
            '.IdAlmacen = CInt(cboAlmacen.SelectedValue)
            '.AfectarInventarioLinea = rdbAfectInvLinea.Checked
            'Ventas
            '.IdRegion = CInt(cboRegion.SelectedValue)
            '.IdZonaVenta = CInt(cboZonaVenta.SelectedValue)
            'If rdbListaPrecio.Checked Then
            ' .TipoPrecio = TipoPrecio.ListaPrecio
            'Else
            '.TipoPrecio = TipoPrecio.ZonasVenta
            'End If
            .IdDivisaBase = CInt(cboDivisaBase.SelectedValue)
            '.IdClienteGenerico = txtClienteGen.Key
            .GLN = txtGLN.Text
            'Guardar información de la sucursal
            With .Sucursal
                'Datos Generales
                .Nombre = txtNombreCorto.Text
                .NombreLargo = txtNombreCorto.Text ' txtNombreLargo.Text
                .IdEmpresa = CInt(cboEmpresa.SelectedValue)
                '   .Telefono1 = txtTel1.Text
                '   .Telefono2 = txtTel2.Text
                '  .Fax = txtFax.Text
                ' .Correo = txtCorreo.Text
                '.PaginaWeb = txtPagWeb.Text
                'Domicilio
                .Calle = txtCalle.Text
                .NumExt = txtNumExt.Text
                .NumInt = txtNumInt.Text
                .Colonia = txtColonia.Text
                .CP = txtCP.Text
                .IdPoblacion = txtPoblacion.Key
                '
                .Status = UnidadNegocio.Status
                .UserCode = UnidadNegocio.UserCode
            End With
            ''Notificaciones
            .EnviarFacturas = chkEnviarFact.Checked
            '.IdRemitente = CInt(cboRemitente.SelectedValue)
            ''Punto de venta
            '.IdFormatoTicketComanda = CInt(cboTicketComanda.SelectedValue)
            '.IdFormatoTicketPedimento = CInt(cboTicketPedimento.SelectedValue)
            '.IdFormatoTicketPOS = CInt(cboTicketPOS.SelectedValue)
        End With

    End Sub

    'Private Sub selSerie_InfoLoaded(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSerieFact.InfoLoaded
    '    Try
    '        If txtSerieFact.Key > 0 Then
    '            Dim SerieInf As Azteca.Business.Contabilidad.SerieInfo = CType(txtSerieFact.PackageInfo, Azteca.Business.Contabilidad.SerieInfo)
    '        End If
    '    Catch ex As Exception
    '        MsgInfo.Show(ex)
    '    End Try
    'End Sub

End Class