Imports Azteca.Business.Ventas
Imports Azteca.Windows
Imports Azteca.Business.Inventario
Imports Azteca.Kernel.BusinessStructure
Imports Azteca.Business.Contabilidad

Public Class VentaExpresstForm
    Private ArticuloFac As PresentacionFacade
    Private ServicioFac As ServicioFacade
    Private UnidadMedidaFac As Azteca.Business.Inventario.UnidadMedidaFacade
    Private UnidadesMedida As DataTable
    Private FormatoFactura As String

    Private Sub selCliente_InfoLoaded(sender As System.Object, e As System.EventArgs) Handles txtCliente.InfoLoaded
        Dim ClienteInf As ClienteInfo = CType(txtCliente.PackageInfo, ClienteInfo)
        With ClienteInf
            txtRFC.Text = .RFC : txtRazonSocial.Text = .RazonSocial
            txtDomicilio.Text = "Calle: " & .CalleFiscal & " #" & .NumExtFiscal & IIf(.NumInt.Length > 0, " Int.", "").ToString & .NumIntFiscal & " Col." & .ColoniaFiscal
            Dim Poblacionfac As New Azteca.Kernel.General.PoblacionFacade
            Dim Poblacion As Azteca.Kernel.General.PoblacionInfo = Poblacionfac.GetDetail(App.Session.SessionID, .IdPoblacionFiscal)
            txtPoblacion.Text = Poblacion.Poblacion & " ," & Poblacion.Municipio
            If .LimiteCredito > 0 Then
                rdbCredito.Checked = True
            Else
                rdbContado.Checked = True
            End If
        End With
    End Sub

#Region "Implementacion"

    Private Sub VentasForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
        Dim Venta As VentaInfo = CType(PackageInfo, VentaInfo)
        bsServicios.DataSource = Venta.Servicios
        bsArticulos.DataSource = Venta.Articulos
        grdArticulos.Rebind(True)
        grdServicios.Rebind(True)
        MostrarTotales()
        cboDivisa.SelectedValue = Context.UnidadNegocio.IdDivisaBase
        If cboCaja.Items.Count > 0 Then cboCaja.SelectedIndex = 0
    End Sub

    Private Sub VentasForm_ItemSaved(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ItemSaved
        MostrarTotales()
    End Sub

    Private Sub VentasForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ArticuloFac = New PresentacionFacade
            ServicioFac = New ServicioFacade
            UnidadMedidaFac = New Azteca.Business.Inventario.UnidadMedidaFacade
            'Cargar unidades de medida
            UnidadesMedida = UnidadMedidaFac.LoadList(App.Session.SessionID)
            bsUnidades.DataSource = UnidadesMedida
            cboUnidades.DataSource = bsUnidades
            cboUnidades.Rebind(True)
            'Cargar formato de factura asignado a la sucursal
            Dim FormatMgr As New Azteca.Kernel.General.FormatManager
            FormatoFactura = FormatMgr.LoadFormat(App.Session.SessionID, Context.UnidadNegocio.IdFormatoFacturas)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub VentasForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim Venta As VentaInfo = CType(PackageInfo, VentaInfo)
        With Venta
            txtCliente.LoadInfo(.IdCliente)
            'txtVendedor.Text = String.Empty
            'If .IdVendedor > 0 Then txtVendedor.LoadInfo(.IdVendedor)
            cboCaja.SelectedValue = .IdCaja
            cboDivisa.SelectedValue = .IdDivisa
            txtNotas.Text = .Observaciones
            If .CondicionesPago = CondicionesPago.Contado Then
                rdbContado.Checked = True
            Else
                rdbCredito.Checked = True
            End If
            CargarEmpaquetados(Venta)
            MostrarTotales()
            bsServicios.DataSource = .Servicios
            bsArticulos.DataSource = .Articulos
            grdArticulos.Rebind(True)
            grdServicios.Rebind(True)
        End With
    End Sub

    Private Sub VentasForm_LoadingLists(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LoadingLists
        cboDivisa.LoadList()
        cboCaja.LoadList()
        cboDivisa.SelectedValue = Context.UnidadNegocio.IdDivisaBase
        cboCaja.SelectedIndex = 0
    End Sub

    Private Sub VentasForm_PrintingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PrintingItem
        Dim Venta As VentaInfo = CType(PackageInfo, VentaInfo)
        Dim VentaFac As New VentaFacade
        If Venta.Status = WorkflowSteps.Invoice Or (Venta.Status = WorkflowSteps.Cancel And Venta.FolioFactura > 0) Then
            'Cargar información del certificado
            Dim SerieFac As New SerieFacade
            Dim Serie As SerieInfo = SerieFac.GetDetail(App.Session.SessionID, Venta.IdSerie, False)
            Dim CertificadoFac As New CertificadoFacade
            Dim Certifiado As CertificadoInfo = CertificadoFac.GetDetail(App.Session.SessionID, Serie.IdCertificado, False)

            'Cargar información de la factura
            Dim dtFactura As Azteca.Business.Ventas.InformesDS.FacturasDataTable = VentaFac.LoadFacturaPrintInfo(App.Session.SessionID, Venta.IdSerie, Venta.FolioFactura, Venta.UUIDFactura)
            'Mostrar vista previa de la factura
            Dim frmFactura As New ReportForm
            Dim Reader As New System.IO.StringReader(FormatoFactura)
            frmFactura.LocalReport.LoadReportDefinition(Reader)
            frmFactura.LocalReport.DataSources.Add(New ReportDataSource("Facturas", CType(dtFactura, DataTable)))
            Dim ComprobanteFac As New ComprobanteFiscalFacade
            Dim Comprobante As ComprobanteFiscalInfo = ComprobanteFac.Load(App.Session.SessionID, Venta.IdSerie, Venta.FolioFactura, Venta.UUIDFactura)
            Dim Imagenes As New Azteca.Business.Contabilidad.InformesDS.ImagenesDataTable
            Dim dr As Azteca.Business.Contabilidad.InformesDS.ImagenesRow = Imagenes.NewImagenesRow
            dr.Logo = App.DefaultCompany.Logo
            dr.QrCode = Comprobante.QrCode
            Imagenes.AddImagenesRow(dr)
            frmFactura.LocalReport.DataSources.Add(New ReportDataSource("Imagenes", CType(Imagenes, DataTable)))
            frmFactura.Show("Factura " & Venta.SerieFactura & "-" & Venta.FolioFactura.ToString)
        Else
            'Cargar información de impresión de la venta
            Dim dtVenta As DataTable = VentaFac.LoadPrintInfo(App.Session.SessionID, Venta.Identity)
            'Definir parametros del informe
            Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
            Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))
            'Mostrar vista previa de la venta
            Dim frmVenta As New ReportForm
            frmVenta.LocalReport.ReportEmbeddedResource = "PixkuaInvoice.Orden.rdlc"
            frmVenta.LocalReport.DataSources.Add(New ReportDataSource("Venta", CType(dtVenta, DataTable)))
            frmVenta.LocalReport.SetParameters(Parametros)
            frmVenta.Show("Orden de Venta " & Venta.Identity)
        End If
    End Sub

    Private Sub VentasForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        grdArticulos.UpdateData()
        grdServicios.UpdateData()
        Dim Venta As VentaInfo = CType(PackageInfo, VentaInfo)
        With Venta
            .IdCliente = txtCliente.Key
            .IdVendedor = 0 'txtVendedor.Key
            .IdCaja = CInt(cboCaja.SelectedValue)
            .IdDivisa = CInt(cboDivisa.SelectedValue)
            .Observaciones = txtNotas.Text
            If rdbContado.Checked Then
                .CondicionesPago = CondicionesPago.Contado
            Else
                .CondicionesPago = CondicionesPago.Credito
            End If
            .Origen = OrigenVenta.Manual
            .Hora = Date.Now
            .IdTerminal = 0
        End With
        GuardarEmpaquetados(Venta)
    End Sub

    Protected Overrides Sub OnApplyingItem(ByVal e As Forms.BusinessForms.DocumentStatusEventArgs)
        Dim Venta As VentaInfo = CType(PackageInfo, VentaInfo)
        If e.IdStatus = WorkflowSteps.Apply Then
            If Venta.CondicionesPago = CondicionesPago.Contado Then
                Dim frmFormaPago As New Azteca.Windows.Ventas.SelectFormaPagoForm
                If frmFormaPago.ShowDialog(Me, Venta) = System.Windows.Forms.DialogResult.OK Then
                    If Venta.IdSucursal = 0 Then Venta.IdSucursal = App.DefaultSite.Identity
                    MessageBox.Show("La venta ha sido aplicada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                Dim VentaFac As New VentaFacade
                VentaFac.Aplicar(App.Session.SessionID, Venta.Identity, App.Session.BussinesDate)
            End If
            LoadItem(PackageInfo.Identity)
        ElseIf e.IdStatus = WorkflowSteps.Invoice Then
            Dim frmMetodoPago As New Azteca.Windows.Ventas.MetodoPagoSELForm
            If frmMetodoPago.ShowDialog(txtCliente.Key) = System.Windows.Forms.DialogResult.OK Then
                Try
                    System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                    MyBase.OnApplyingItem(e)
                Catch ex As Exception
                    MsgInfo.Show(ex)
                Finally
                    System.Windows.Forms.Cursor.Current = Cursors.Default
                End Try
            End If
        Else
            MyBase.OnApplyingItem(e)
        End If
    End Sub

    Public Overrides Sub OnItemApplied(ByVal e As Azteca.Windows.Forms.BusinessForms.DocumentStatusEventArgs)
        Try
            MostrarTotales()
            MyBase.OnItemApplied(e)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub cboDivisa_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDivisa.SelectedIndexChanged
        Try
            If cboDivisa.SelectedIndex >= 0 Then
                txtDivisa.Text = cboDivisa.Text
                'Obtener el tipo de cambio
                Dim DivisaFac As New Azteca.Business.Contabilidad.DivisaFacade
                txtTipoCambio.Text = DivisaFac.GetTipoCambioActual(App.Session.SessionID, Context.UnidadNegocio.IdDivisaBase).ToString
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

#End Region

#Region "Implementacion Articulos"

    Private Sub grdArticulos_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdArticulos.AfterColUpdate
        Try
            Dim Venta As VentaInfo = CType(PackageInfo, VentaInfo)
            If e.Column.Name = "U.M." Then
                Dim drvPartida As DataRowView = CType(bsArticulos.Current, DataRowView)
                grdArticulos.Columns("Descripción U.M.").Text = cboUnidades.Columns("Nombre").Text
                Dim IdUnidadMedida As Integer = CInt(cboUnidades.Columns("ID").Value)
                grdArticulos.Columns("Existencia").Text = ConvertirCantidad(CDec(drvPartida("ExistenciaBase")), IdUnidadMedida, 1).ToString
                grdArticulos.Columns("Unidades").Text = "0"
            ElseIf e.Column.Name = "Código" Then
                grdArticulos.UpdateData()
            End If
            MostrarTotales()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdArticulos_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdArticulos.AfterDelete
        Try
            Dim Venta As VentaInfo = CType(PackageInfo, VentaInfo)
            MostrarTotales()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdArticulos_AfterInsert(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdArticulos.AfterInsert
        Dim Venta As VentaInfo = CType(PackageInfo, VentaInfo)
        Try
            MostrarTotales()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdArticulos_BeforeColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColEditEventArgs) Handles grdArticulos.BeforeColEdit
        Try
            'Validar que se haya capturado los datos del encabezado
            If Not ValidHeader() Then
                e.Cancel = True
                Return
            End If
            'Si se está intenando editar una columna sin haber seleccionado el código de artículo no permitirlo
            If e.Column.Name <> "Código" AndAlso grdArticulos.Columns("Código").Text = String.Empty Then
                e.Cancel = True
                MessageBox.Show("Primero debe capturar el código del artículo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim drvPartida As DataRowView = CType(bsArticulos.Current, DataRowView)
                Dim IdUnidadMedidaTipo As Integer = CInt(drvPartida("IdUnidadMedidaTipo"))
                Dim IdUnidadMedida As Integer = CInt(drvPartida("IdUnidadMedida"))
                If e.Column.Name = "Cantidad" Then
                    'Si el tipo de unidad es de piezas (y cajas)
                    If IdUnidadMedidaTipo = 1 Then
                        grdArticulos.Columns(e.ColIndex).EditMask = "000000000"
                    Else
                        grdArticulos.Columns(e.ColIndex).EditMask = String.Empty
                    End If
                ElseIf e.Column.Name = "Unidades" Then
                    'Si el tipo de unidad no es de cajas, deshabilitar campo de unidades
                    If (IdUnidadMedidaTipo > 1 Or IdUnidadMedida = 1) Then e.Cancel = True
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub grdArticulos_BeforeColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColUpdateEventArgs) Handles grdArticulos.BeforeColUpdate
        If bsArticulos.Current IsNot Nothing Then
            Dim Venta As VentaInfo = CType(PackageInfo, VentaInfo)
            Try
                If e.Column.Name = "Código" Then
                    'Verificar que se haya capturado un código de artículo
                    If grdArticulos.Columns("Código").Text.Trim = String.Empty Then Return
                    Dim Codigo As String = grdArticulos.Columns("Código").Text.Trim
                    If Context.Articulos.ContainsKey(Codigo) OrElse ArticuloFac.Exists(App.Session.SessionID, Codigo, App.DefaultSite.Identity) Then
                        Dim ArticuloInf As Azteca.Business.Inventario.ArticuloStockInfo
                        'Checar si el artículo se encuentra en el caché, si no, cargarlo
                        If Context.Articulos.ContainsKey(Codigo) Then
                            ArticuloInf = Context.Articulos(Codigo)
                        Else
                            ArticuloInf = ArticuloFac.GetDetailFromCache(App.Session.SessionID, Codigo, App.DefaultSite.Identity)
                            Context.Articulos.Add(Codigo, ArticuloInf)
                        End If
                        If Venta.Articulos.FindByIdArticuloStock(ArticuloInf.Identity) Is Nothing Then
                            Dim ArticuloVenta As ArticuloInfo = GetArticuloVenta(ArticuloInf.Identity)
                            With ArticuloInf
                                Dim Info As Azteca.Business.Inventario.StockInfo = CargarStockInfo(.Identity)
                                Dim drvPartida As DataRowView = CType(bsArticulos.Current, DataRowView)
                                grdArticulos.Columns("Descripción").Text = .Nombre
                                grdArticulos.Columns("UnidadMedida").Value = ArticuloVenta.UnidadMedida
                                drvPartida("Cantidad") = 1
                                drvPartida("IdArticuloStock") = .Identity
                                drvPartida("IdUnidadMedida") = ArticuloVenta.IdUnidadMedida
                                drvPartida("IdUnidadMedidaTipo") = ArticuloVenta.IdTipoUnidadMedida
                                'Cargar información de precio
                                Dim Precio As PrecioInfo = ArticuloFac.GetPrecio(App.Session.SessionID, .Identity, txtCliente.Key, App.DefaultSite.Identity)
                                'Validar precio de artículo
                                If ValidarPrecio(Precio) Then
                                    Venta.AsignarPrecio(drvPartida.Row, Precio)
                                Else
                                    e.Cancel = True
                                    Return
                                End If
                                'Cargar existencia en el almacén
                                drvPartida("ExistenciaBase") = Info.Existencia
                                drvPartida("Existencia") = ConvertirCantidad(Info.Existencia, ArticuloVenta.IdUnidadMedida, 1)
                                bsUnidades.Filter = "IdUnidadMedidaTipo=" & ArticuloVenta.IdTipoUnidadMedida
                            End With
                        Else
                            MessageBox.Show("El artículo ya existe en otra partida.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            e.Cancel = True
                        End If
                    Else
                        MessageBox.Show("El código de artículo no existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        e.Cancel = True
                    End If
                Else
                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        End If
    End Sub

    Private Sub grdArticulos_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdArticulos.ButtonClick
        Dim Venta As VentaInfo = CType(PackageInfo, VentaInfo)
        Try
            If e.Column.Name = "Código" And Venta.Status = Azteca.Kernel.BusinessStructure.WorkflowSteps.Save Then
                'Validar que el almacén esté seleccionado un almacén
                If Not ValidHeader() Then Return
                'Mostrar pantalla de búsqueda para que el usuario seleccione un artículo
                Dim frmSearch As New Azteca.Windows.Forms.BusinessForms.CatalogListForm
                If frmSearch.ShowDialog(Me, ArticuloFac) = System.Windows.Forms.DialogResult.OK Then
                    Dim IdArticulo As Integer = CInt(frmSearch.SelectedItem)
                    If Venta.Articulos.FindByIdArticuloStock(IdArticulo) Is Nothing Then
                        Dim Articulo As Azteca.Business.Inventario.ArticuloStockInfo = ArticuloFac.GetDetail(App.Session.SessionID, IdArticulo)
                        If Not Context.Articulos.ContainsKey(Articulo.UserCode) Then Context.Articulos.Add(Articulo.UserCode, Articulo)
                        Dim ArticuloVenta As ArticuloInfo = GetArticuloVenta(Articulo.Identity)
                        Dim drPartida As DetalleVentaDS.ArticulosRow
                        If grdArticulos.AddNewMode = C1.Win.C1TrueDBGrid.AddNewModeEnum.AddNewCurrent Then
                            drPartida = Venta.Articulos.NewArticulosRow
                        Else
                            drPartida = CType(CType(bsArticulos.Current, DataRowView).Row, DetalleVentaDS.ArticulosRow)
                        End If
                        'Cargar información de precio
                        Dim Precio As PrecioInfo = ArticuloFac.GetPrecio(App.Session.SessionID, Articulo.Identity, txtCliente.Key, App.DefaultSite.Identity)
                        'Validar precio de artículo
                        If ValidarPrecio(Precio) Then
                            Venta.AsignarPrecio(drPartida, Precio)
                        Else
                            Return
                        End If
                        'Asinar datos del artículo
                        With drPartida
                            Dim Info As StockInfo = CargarStockInfo(Articulo.Identity)
                            .IdArticuloStock = Articulo.Identity
                            .Codigo = Articulo.UserCode
                            .Descripcion = Articulo.Nombre
                            .UnidadMedida = ArticuloVenta.UnidadMedida
                            .Cantidad = 1
                            .IdUnidadMedida = ArticuloVenta.IdUnidadMedida
                            .IdUnidadMedidaTipo = ArticuloVenta.IdTipoUnidadMedida
                            .ExistenciaBase = Info.Existencia
                            .Existencia = ConvertirCantidad(.ExistenciaBase, .IdUnidadMedida, 1)
                        End With
                        If drPartida.RowState = DataRowState.Detached Then Venta.Articulos.AddArticulosRow(drPartida)
                        bsUnidades.Filter = "IdUnidadMedidaTipo=" & ArticuloVenta.IdTipoUnidadMedida
                    Else
                        MessageBox.Show("El artículo ya existe en otra partida.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
                'Filtrar unidades de medida del mismo tipo que el artículo
            ElseIf e.Column.Name = "U.M." And bsArticulos.Current IsNot Nothing Then
                Dim dr As DataRowView = CType(bsArticulos.Current, DataRowView)
                bsUnidades.Filter = "IdUnidadMedidaTipo=" & CInt(dr("IdUnidadMedidaTipo")).ToString
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdArticulos_FetchCellStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchCellStyleEventArgs) Handles grdArticulos.FetchCellStyle
        Try
            Dim Venta As VentaInfo = CType(PackageInfo, VentaInfo)
            Dim IdUnidadMedida As Integer = CInt(Val(grdArticulos.Columns("U.M.").CellValue(e.Row)))
            Dim IdUnidadMedidaTipo As Integer = CInt(Val(grdArticulos.Columns("IdUnidadMedidaTipo").CellValue(e.Row)))
            If Venta.Status > 1 Or IdUnidadMedida = 0 Then Return

            'Si el tipo de unidad no es de cajas, deshabilitar campo de unidades
            If e.Column.Name = "Unidades" And (IdUnidadMedidaTipo > 1 Or IdUnidadMedida = 1) Then
                e.CellStyle.BackColor = Drawing.Color.LightGray
            End If

            'Si es una salida y no hay existencia suficiente, marcar campo de cantidad y de unidades
            If e.Column.Name = "Cantidad" Or e.Column.Name = "Unidades" Then
                Dim UnidadMedida As Azteca.Business.Inventario.UnidadMedidaInfo = GetUnidadMedida(IdUnidadMedida)
                Dim CantidadEmp As Azteca.Business.Inventario.Empaquetado
                If IdUnidadMedidaTipo = 1 And IdUnidadMedida > 0 Then
                    CantidadEmp = New Azteca.Business.Inventario.Empaquetado(CInt(grdArticulos.Columns("Cantidad").CellValue(e.Row)), CInt(grdArticulos.Columns("Unidades").CellValue(e.Row)), UnidadMedida.Factor)
                Else
                    CantidadEmp = New Azteca.Business.Inventario.Empaquetado(CDec(grdArticulos.Columns("Cantidad").CellValue(e.Row)), UnidadMedida.Factor)
                End If
                Dim Cantidad As Decimal = CantidadEmp.ToDecimal * UnidadMedida.Factor
                Dim Existencia As Decimal = CDec(grdArticulos.Columns("ExistenciaBase").CellValue(e.Row))
                If Existencia < Cantidad Then
                    e.CellStyle.BackColor = Drawing.Color.Orange
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub


#End Region

#Region "Implementacion Servicios"

    Private Sub grdServicios_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdServicios.AfterColUpdate
        Try
            Dim Venta As VentaInfo = CType(PackageInfo, VentaInfo)
            If e.Column.Name = "P. Unitario" Then
                Dim drvPartida As DataRowView = CType(bsServicios.Current, DataRowView)
                Dim Precio As PrecioInfo = ServicioFac.GetPrecio(App.Session.SessionID, CInt(drvPartida("IdServicio")), txtCliente.Key, App.DefaultSite.Identity, CDec(grdServicios.Columns("P. Unitario").Value))
                Venta.AsignarPrecio(drvPartida.Row, Precio)
            End If
            grdArticulos.UpdateData()
            MostrarTotales()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdServicios_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdServicios.AfterDelete
        Try
            MostrarTotales()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdServicios_AfterInsert(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdServicios.AfterInsert
        Dim Venta As VentaInfo = CType(PackageInfo, VentaInfo)
        Try
            MostrarTotales()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdServicios_BeforeColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColEditEventArgs) Handles grdServicios.BeforeColEdit
        Try
            'Validar que se haya capturado los datos del encabezado
            If Not ValidHeader() Then
                e.Cancel = True
                Return
            End If
            'Si se está intenando editar una columna sin haber seleccionado el código de servicio no permitirlo
            If e.Column.Name <> "Código" AndAlso grdServicios.Columns("Código").Text = String.Empty Then
                e.Cancel = True
                MessageBox.Show("Primero debe capturar el código del servicio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'Si no es un servicio de concepto libre, no permitir editar las celdas de descripcion y precio unitario
                If e.Column.Name = "Descripción" Or e.Column.Name = "P. Unitario" Then
                    If Not CBool(grdServicios.Columns("ConceptoLibre").Value) Then e.Cancel = True
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub grdServicios_BeforeColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColUpdateEventArgs) Handles grdServicios.BeforeColUpdate
        If bsServicios.Current IsNot Nothing Then
            Dim Venta As VentaInfo = CType(PackageInfo, VentaInfo)
            Try
                If e.Column.Name = "Código" Then
                    'Verificar que se haya capturado un código de artículo
                    If grdServicios.Columns("Código").Text.Trim = String.Empty Then Return
                    Dim Codigo As String = grdServicios.Columns("Código").Text.Trim
                    If Context.Servicios.ContainsKey(Codigo) OrElse ServicioFac.Exists(App.Session.SessionID, Codigo, App.DefaultSite.Identity) Then
                        Dim ServicioInf As ServicioInfo
                        'Checar si el artículo se encuentra en el caché, si no, cargarlo
                        If Context.Servicios.ContainsKey(Codigo) Then
                            ServicioInf = Context.Servicios(Codigo)
                        Else
                            ServicioInf = ServicioFac.GetDetailFromCache(App.Session.SessionID, Codigo, App.DefaultSite.Identity)
                            Context.Servicios.Add(Codigo, ServicioInf)
                        End If
                        With ServicioInf
                            Dim drvPartida As DataRowView = CType(bsServicios.Current, DataRowView)
                            grdServicios.Columns("Descripción").Text = .Nombre
                            drvPartida("Cantidad") = 1
                            drvPartida("IdServicio") = .Identity
                            drvPartida("ConceptoLibre") = .ConceptoLibre
                            'Cargar información de precio
                            Dim Precio As PrecioInfo = ServicioFac.GetPrecio(App.Session.SessionID, .Identity, txtCliente.Key, App.DefaultSite.Identity)
                            'Validar precio de servicio
                            If ValidarPrecio(Precio) Then
                                Venta.AsignarPrecio(drvPartida.Row, Precio)
                            Else
                                e.Cancel = True
                                Return
                            End If
                        End With
                    Else
                        MessageBox.Show("El código de servicio no existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        e.Cancel = True
                    End If
                Else
                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        End If
    End Sub

    Private Sub grdServicios_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdServicios.ButtonClick
        Dim Venta As VentaInfo = CType(PackageInfo, VentaInfo)
        Try
            If e.Column.Name = "Código" And Venta.Status = WorkflowSteps.Save Then
                'Validar que el almacén esté seleccionado un almacén
                If Not ValidHeader() Then Return
                'Mostrar pantalla de búsqueda para que el usuario seleccione un artículo
                Dim frmSearch As New Azteca.Windows.Forms.BusinessForms.CatalogListForm
                If frmSearch.ShowDialog(Me, ServicioFac) = System.Windows.Forms.DialogResult.OK Then
                    Dim IdServicio As Integer = CInt(frmSearch.SelectedItem)
                    Dim Servicio As ServicioInfo = ServicioFac.GetDetail(App.Session.SessionID, IdServicio, False)
                    If Not Context.Servicios.ContainsKey(Servicio.UserCode) Then Context.Servicios.Add(Servicio.UserCode, Servicio)
                    Dim drPartida As DetalleVentaDS.ServiciosRow
                    If grdServicios.AddNewMode = C1.Win.C1TrueDBGrid.AddNewModeEnum.AddNewCurrent Then
                        drPartida = Venta.Servicios.NewServiciosRow
                    Else
                        drPartida = CType(CType(bsServicios.Current, DataRowView).Row, DetalleVentaDS.ServiciosRow)
                    End If
                    'Cargar información de precio
                    Dim Precio As PrecioInfo = ServicioFac.GetPrecio(App.Session.SessionID, Servicio.Identity, txtCliente.Key, App.DefaultSite.Identity)
                    'Validar precio de servicio
                    If ValidarPrecio(Precio) Then
                        Venta.AsignarPrecio(drPartida, Precio)
                    Else
                        Return
                    End If
                    'Asignar datos del servicio
                    With drPartida
                        .IdServicio = Servicio.Identity
                        .Codigo = Servicio.UserCode
                        .Descripcion = Servicio.Nombre
                        .Cantidad = 1
                        .ConceptoLibre = Servicio.ConceptoLibre
                    End With
                    If drPartida.RowState = DataRowState.Detached Then Venta.Servicios.AddServiciosRow(drPartida)
                End If
            End If
            If e.Column.Name = "Descripción" And Venta.Status = WorkflowSteps.Save Then
                Dim drPartida As DetalleVentaDS.ServiciosRow = CType(CType(bsServicios.Current, DataRowView).Row, DetalleVentaDS.ServiciosRow)
                'Mostrar el formulario de notas
                Dim frmNotas As New NotesForm
                If frmNotas.ShowDialog(Me, grdServicios.Columns("Descripción").Text, False) = System.Windows.Forms.DialogResult.OK Then
                    grdServicios.Columns("Descripción").Text = frmNotas.Notes
                    grdServicios.UpdateData()
                End If
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdServicios_FetchCellStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchCellStyleEventArgs) Handles grdServicios.FetchCellStyle
        Try
            Dim Venta As VentaInfo = CType(PackageInfo, VentaInfo)
            'Si no es un servicio de concepto libre, sombrear celdas de descripcion y precio unitario
            If (e.Column.Name = "Descripción" Or e.Column.Name = "P. Unitario") And Not CBool(grdServicios.Columns("ConceptoLibre").CellValue(e.Row)) Then
                e.CellStyle.BackColor = Drawing.Color.LightGray

            End If
            If e.Column.Name = "Descripción" And CBool(grdServicios.Columns("ConceptoLibre").CellValue(e.Row)) Then
                e.Column.Button = True
            End If
        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "Metodos Privados"

    Private Function GetArticuloVenta(idArticuloStock As Integer) As ArticuloInfo
        Dim ArticuloVentaFac As New ArticuloFacade
        Dim ArticuloInf As ArticuloInfo
        If Context.ArticulosVenta.ContainsKey(idArticuloStock) Then
            ArticuloInf = Context.ArticulosVenta(idArticuloStock)
        Else
            Dim IdArticulo As Integer = ArticuloFac.GetArticuloVentaID(App.Session.SessionID, idArticuloStock)
            ArticuloInf = ArticuloVentaFac.GetDetailFromCache(App.Session.SessionID, IdArticulo)
            Context.ArticulosVenta.Add(idArticuloStock, ArticuloInf)
        End If
        Return ArticuloInf
    End Function

    Private Sub GuardarEmpaquetados(ByVal venta As VentaInfo)
        For Each drPartida As DetalleVentaDS.ArticulosRow In venta.Articulos
            If drPartida.RowState <> DataRowState.Deleted Then
                Dim UnidadInf As UnidadMedidaInfo = GetUnidadMedida(drPartida.IdUnidadMedida)
                'Si la unidad de medida son cajas, separar cajas y unidades
                If UnidadInf.IdTipoUnidad = 1 And UnidadInf.Identity > 0 Then
                    Dim Cantidad As New Empaquetado(CInt(drPartida.CantidadAux), drPartida.UnidadesAux, UnidadInf.Factor)
                    drPartida.Cantidad = Cantidad.ToDecimal
                Else
                    drPartida.Cantidad = drPartida.CantidadAux
                End If
            End If
        Next
    End Sub

    Private Sub CargarEmpaquetados(ByVal venta As VentaInfo)
        For Each drPartida As DetalleVentaDS.ArticulosRow In venta.Articulos
            If drPartida.RowState <> DataRowState.Deleted Then
                Dim UnidadInf As UnidadMedidaInfo = GetUnidadMedida(drPartida.IdUnidadMedida)
                'Si la unidad de medida son cajas, separar cajas y unidades
                If UnidadInf.IdTipoUnidad = 1 And UnidadInf.Identity > 0 Then
                    Dim Cantidad As New Azteca.Business.Inventario.Empaquetado(drPartida.Cantidad, UnidadInf.Factor)
                    drPartida.CantidadAux = Cantidad.Cajas
                    drPartida.UnidadesAux = Cantidad.Unidades
                Else
                    drPartida.CantidadAux = drPartida.Cantidad
                End If
            End If
        Next
    End Sub

    Private Function CargarStockInfo(ByVal idArticuloStock As Integer) As StockInfo
        Dim AlmacenFac As New Azteca.Business.Inventario.AlmacenFacade
        Return AlmacenFac.GetStockInfo(App.Session.SessionID, Context.UnidadNegocio.IdAlmacen, idArticuloStock)
    End Function

    Private Sub MostrarTotales()
        Dim Venta As VentaInfo = CType(PackageInfo, VentaInfo)
        GuardarEmpaquetados(Venta)
        Venta.CalcularTotales(Ventas.Context.UnidadNegocio.PoliticaDescuento)
        With Venta
            txtFactura.Text = .SerieFactura.Trim & "-" & .FolioFactura.ToString
            If .FolioFactura > 0 Then
                txtFechaFactura.Text = .FechaFactura.ToString("dd-MM-yyyy HH:mm:ss")
            Else
                txtFechaFactura.Text = String.Empty
            End If
            txtTotalCant.Text = Venta.TotalCantidad.ToString("N0")
            txtSubTotal.Text = Venta.SubTotal.ToString("C")
            txtImpuestos.Text = Venta.TotalImpuestosTrasladados.ToString("C")
            txtRetenciones.Text = Venta.TotalImpuestosRetenidos.ToString("C")
            txtDescuentos.Text = Venta.TotalDescuentos.ToString("C")
            txtTotal.Text = Venta.Total.ToString("C")
            txtDivisa.Text = cboDivisa.Text
        End With
    End Sub

    Private Function GetUnidadMedida(ByVal idUnidadMedida As Integer) As Azteca.Business.Inventario.UnidadMedidaInfo
        Dim UnidadMedidaInf As Azteca.Business.Inventario.UnidadMedidaInfo
        If Context.UnidadesMedida.ContainsKey(idUnidadMedida) Then
            UnidadMedidaInf = Context.UnidadesMedida(idUnidadMedida)
        Else
            Dim UnidadMedidaFac As New Azteca.Business.Inventario.UnidadMedidaFacade
            UnidadMedidaInf = UnidadMedidaFac.GetDetailFromCache(App.Session.SessionID, idUnidadMedida)
        End If
        Return UnidadMedidaInf
    End Function

    Private Function ConvertirCantidad(ByVal cantidad As Decimal, ByVal idUnidadMedida As Integer, ByVal tipoConversion As Integer) As Decimal
        Dim UnidadMedidaInf As Azteca.Business.Inventario.UnidadMedidaInfo = GetUnidadMedida(idUnidadMedida)
        'Convertir desde unidad base a unidades multiplo
        If tipoConversion = 1 Then
            Return cantidad / UnidadMedidaInf.Factor
        Else 'Convertir unidad múltiplo a unidad base
            Return cantidad * UnidadMedidaInf.Factor
        End If
    End Function

    Private Function ValidHeader() As Boolean
        ValidHeader = False
        If txtCliente.Key = 0 Then
            MessageBox.Show("Primero debe elegir un cliente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboDivisa.SelectedIndex = -1 Then
            MessageBox.Show("Primero debe seleccionar la divisa del documento.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Return True
        End If
    End Function

    Private Function ValidarPrecio(ByVal precio As PrecioInfo) As Boolean
        ValidarPrecio = False
        If precio.Precio = 0 Then
            MessageBox.Show("El precio del artículo debe ser mayor a cero", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf precio.IdDivisa <> CInt(cboDivisa.SelectedValue) Then
            MessageBox.Show("La divisa de los artículos debe corresponder a la divisa del documento", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Return True
        End If
    End Function

#End Region

End Class