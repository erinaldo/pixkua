Imports Azteca.Business.Contabilidad
Imports Azteca.Business.Inventario
Imports Azteca.Kernel.General
Imports Microsoft.Reporting.WinForms

Partial Class VentaService

#Region "Aplicacion"

    Public Sub Aplicar(ByVal idVenta As String, ByVal fechaTrabajo As Date)
        Dim VentaSvc As New VentaService(SessionID, Connection, Transaction)
        'Cargar información de la venta
        Dim Venta As New VentaInfo(SessionID)
        VentaSvc.GetDetail(idVenta, Venta)
        'Validar que la caja esté abierta (tenga un corte válido)
        ValidarCorte(Venta.IdCaja)
        'Determinar el almacén desde el cual se hará la salida y si las salidas se realizan en línea
        Dim IdAlmacen As Integer = Venta.IdAlmacen
        Dim IdSalida As String = String.Empty
        Dim UnidadSvc As New UnidadNegocioService(SessionID, Connection, Transaction)
        Dim UnidadNeg As UnidadNegocioInfo = UnidadSvc.GetDetailFromCacheByIdSucursal(Venta.IdSucursal)
        If IdAlmacen = 0 Then IdAlmacen = UnidadNeg.IdAlmacen
        If UnidadNeg.AfectarInventario And UnidadNeg.AfectarInventarioLinea And IdAlmacen > 0 And Venta.Origen <> OrigenVenta.FacturaGlobal Then
            IdSalida = GenerarSalida(Venta, IdAlmacen)
        End If
        'Actualizar Id de la salida
        If IdSalida.Trim <> String.Empty Then
            Dim spAplicar As New StoredProcedure("Sales", "VentasTitAplicar", Connection, Transaction)
            spAplicar.Parameters.Add("@IdVentaTit", DbType.String).Value = idVenta
            spAplicar.Parameters.Add("@IdSalida", DbType.String).Value = IdSalida
            spAplicar.Execute()
        End If
        MyBase.ApplyWorkflow(idVenta, WorkflowSteps.Apply, fechaTrabajo)
    End Sub

    Public Sub Aplicar(ByVal idVenta As String, ByVal fechaTrabajo As Date, ByVal formasPago As DetalleVentaDS.FormasPagoDataTable)
        Try
            Aplicar(idVenta, fechaTrabajo)
            'Actualizar las formas de pago
            UpdateFormaPago(idVenta, formasPago)
        Catch ex As CustomErrorException
            Throw ex
        Catch ex As BusinessException
            Throw ex
        Catch ex As Exception
            Throw New BusinessException("Error al aplicar la venta: " & idVenta, ex)
        End Try
    End Sub

    Public Sub Aplicar(ByVal idVenta As String, ByVal fechaTrabajo As Date, ByVal idFormaPago As Integer, ByVal monto As Decimal)
        Try
            Aplicar(idVenta, fechaTrabajo)
            'Actualizar las formas de pago
            UpdateFormaPago(idVenta, idFormaPago, monto)
        Catch ex As Exception
            Throw New BusinessException("Error al aplicar la venta: " & idVenta, ex)
        End Try
    End Sub

#End Region

#Region "Formas de Pago"


    Private Sub DeleteFormasPago(ByVal idVentaTit As String)
        Try
            Dim spDelete As New StoredProcedure("Sales", "VentaFormasPagoDEL", Connection, Transaction)
            spDelete.Parameters.Add("@IdVentaTit", DbType.String).Value = idVentaTit
            spDelete.Execute()
        Catch ex As Exception
            Throw New BusinessException("Error al eliminar las formas de pago de la venta " & idVentaTit, ex)
        End Try
    End Sub

    Private Sub UpdateFormaPago(ByVal idVentaTit As String, ByVal idFormaPago As Integer, ByVal monto As Decimal)
        Try
            'Eliminar las formas de pago actual
            DeleteFormasPago(idVentaTit)
            'Insertar la nueva forma de pago
            Dim spUpdate As New StoredProcedure("Sales", "VentaFormaPagoUPD", Connection, Transaction)
            spUpdate.Parameters.Add("@IdVentaTit", DbType.String).Value = idVentaTit
            spUpdate.Parameters.Add("@IdFormaPago", DbType.Int32).Value = idFormaPago
            spUpdate.Parameters.Add("@Monto", DbType.Decimal).Value = monto
            spUpdate.Parameters.Add("@Cambio", DbType.Decimal).Value = 0
            spUpdate.Parameters.Add("@Referencia", DbType.String).Value = ""
            spUpdate.Parameters.Add("@UpdateHeader", DbType.Boolean).Value = True
            spUpdate.Execute()
        Catch ex As Exception
            Throw New BusinessException("Error al guardar la forma de pago de la venta " & idVentaTit, ex)
        End Try
    End Sub

    Private Sub UpdateFormaPago(ByVal idVentaTit As String, ByVal formasPago As DetalleVentaDS.FormasPagoDataTable)
        Try
            'Eliminar las formas de pago actual
            DeleteFormasPago(idVentaTit)
            'Insertar las formas de pago especificadas en la tabla
            For Each drFormaPago As DetalleVentaDS.FormasPagoRow In formasPago
                If drFormaPago.Monto > 0 Then
                    Dim spUpdate As New StoredProcedure("Sales", "VentaFormaPagoUPD", Connection, Transaction)
                    spUpdate.Parameters.Add("@IdVentaTit", DbType.String).Value = idVentaTit
                    spUpdate.Parameters.Add("@IdFormaPago", DbType.Int32).Value = drFormaPago.IdFormaPago
                    spUpdate.Parameters.Add("@Monto", DbType.Decimal).Value = drFormaPago.Monto
                    spUpdate.Parameters.Add("@Cambio", DbType.Decimal).Value = drFormaPago.Cambio
                    spUpdate.Parameters.Add("@Referencia", DbType.String).Value = drFormaPago.Referencia
                    spUpdate.Parameters.Add("@UpdateHeader", DbType.Boolean).Value = False
                    spUpdate.Execute()
                End If
            Next
        Catch ex As Exception
            Throw New BusinessException("Error al guardar las formas de pago de la venta " & idVentaTit, ex)
        End Try
    End Sub

#End Region

#Region "Facturacion"

    Public Function GetVentaFacturaGlobal(idCorte As Guid) As String
        Dim Result As Object = Nothing
        Try
            Dim fxID As New FunctionSQL("Sales", "fxFacturaGlobalCorte", Connection, Transaction)
            fxID.Parameters.Add("@IdCorte", DbType.Guid).Value = idCorte
            Result = fxID.GetScalar()
            If Result Is DBNull.Value Then
                Throw New BusinessException("No existe una factura global para el corte.")
            End If
        Catch ex As Exception
            Throw New BusinessException("Error al determinar la factura global del corte.", ex)
        End Try
        Return Result.ToString
    End Function

    Public Function FacturaGlobalExists(idSucursal As Integer, idCaja As Integer, fecha As Date) As Boolean
        Try
            Dim fxExists As New FunctionSQL("Sales", "fxFacturaGlobalExists", Connection, Transaction)
            fxExists.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            fxExists.Parameters.Add("@IdCaja", DbType.Int32).Value = idCaja
            fxExists.Parameters.Add("@Fecha", DbType.DateTime).Value = fecha
            Return CBool(fxExists.GetScalar)
        Catch ex As Exception
            Throw New BusinessException("Error al verificar la existencia de la factura global del " & fecha.ToShortDateString & ")", ex)
        End Try
    End Function

    Public Function CargarFacturasGlobales(idSucursal As Integer, fechaInicial As Date, fechaFinal As Date) As DataTable
        Try
            Dim fxFacturas As New FunctionSQL("Sales", "fxFacturaGlobalList", Connection, Transaction)
            fxFacturas.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            fxFacturas.Parameters.Add("@FechaIni", DbType.DateTime).Value = fechaInicial
            fxFacturas.Parameters.Add("@FechaFin", DbType.DateTime).Value = fechaFinal
            Dim dtVentas As DataTable = fxFacturas.GetTable("Facturas")
            Return dtVentas
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de facturas globales del periodo (" & fechaInicial.ToShortDateString & "-" & fechaFinal.ToShortDateString & ").", ex)
        End Try
    End Function

    Public Function CargarVentasFacturaGlobal(idSucursal As Integer, idCaja As Integer, fecha As Date) As DataTable
        Try
            Dim fxVentas As New FunctionSQL("Sales", "fxVentasFacturaGlobal", Connection, Transaction)
            fxVentas.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            fxVentas.Parameters.Add("@IdCaja", DbType.Int32).Value = idCaja
            fxVentas.Parameters.Add("@Fecha", DbType.DateTime).Value = fecha
            Dim dtVentas As DataTable = fxVentas.GetTable("Ventas")
            Return dtVentas
        Catch ex As Exception
            Throw New BusinessException("Error al cargar las ventas de la factura global del " & fecha.ToShortDateString & ")", ex)
        End Try
    End Function

    Public Function CargarVentasFacturaGlobal(idCorte As Guid, fechaApertura As Date) As DataTable
        Try
            Dim fxVentas As New FunctionSQL("Sales", "fxVentasGlobalByCorte", Connection, Transaction)
            fxVentas.Parameters.Add("@IdCorte", DbType.Guid).Value = idCorte
            fxVentas.Parameters.Add("@FechaApertura", DbType.DateTime).Value = fechaApertura
            Dim dtVentas As DataTable = fxVentas.GetTable("Ventas")
            Return dtVentas
        Catch ex As Exception
            Throw New BusinessException("Error al cargar las ventas del corte " & idCorte.ToString() & ")", ex)
        End Try
    End Function

    Public Function GenerarFacturaGlobal(idCorte As Guid) As ComprobanteFiscalInfo
        Dim Comprobante As ComprobanteFiscalInfo = Nothing
        Try
            Dim HoraCierre As Date = Date.Now
            'Cargar información del corte
            Dim CajaSvc As New CajaService(SessionID, Connection, Transaction)
            Dim Corte As CorteInfo = CajaSvc.LoadCorteInfo(idCorte)
            'Cargar informacion de la caja
            Dim Caja As New CajaInfo(SessionID)
            CajaSvc.GetDetail(Corte.IdCaja, Caja, False)
            'Cargar información de la factura global
            Dim UnidadNegocioSvc As New UnidadNegocioService(SessionID, Connection, Transaction)
            Dim UnidadNegocio As UnidadNegocioInfo = UnidadNegocioSvc.GetDetailFromCacheByIdSucursal(Caja.IdSucursal)
            'Cargar ventas no facturadas en el periodo
            Dim Ventas As DataTable = CargarVentasFacturaGlobal(idCorte, Corte.FechaApertura)
            'Crear objeto global de ventas
            Dim Venta As VentaInfo = New VentaInfo(SessionID)
            With Venta
                .Fecha = Date.Today
                .Hora = Date.Now
                .IdSucursal = Caja.IdSucursal
                .IdCliente = UnidadNegocio.IdClienteFacturacion
                .IdVendedor = 0
                .IdCaja = Corte.IdCaja
                .CondicionesPago = CondicionesPago.Contado
                .Observaciones = "FACTURA GLOBAL DEL CORTE: " & HoraCierre.ToString("dd/MM/yyyy HH:mm:ss")
                .Origen = OrigenVenta.FacturaGlobal
                .IdDivisa = UnidadNegocio.IdDivisaBase
            End With

            Dim Totales = From V In Ventas
                          Group V By Porcentaje = CDec(V!TasaIVA)
                          Into SubTotal = Sum(CDec(V!SubTotal)), Descuento = Sum(CDec(V!TotalDescuento)), Traslados = Sum(CDec(V!TotalTraslados)), Retenciones = Sum(CDec(V!TotalRetenciones)), Total = Sum(CDec(V!Total))

            For Each Tasa In Totales
                Dim drConcepto As DetalleVentaDS.ServiciosRow = Venta.Servicios.NewServiciosRow()
                With drConcepto
                    .IdServicio = 1
                    .Codigo = "1"
                    .Descripcion = "FACTURA GLOBAL DEL CORTE " & HoraCierre.ToString("dd/MM/yyyy HH:mm:ss") & ", TASA " & (Tasa.Porcentaje * 100).ToString() & " %"
                    .Cantidad = 1
                    .PrecioUnitario = Tasa.SubTotal
                    .MontoDesc1 = Tasa.Descuento
                    .PorcImpTras1 = Tasa.Porcentaje
                    .MontoImpTras1 = Tasa.Traslados
                    .IdDivisa = UnidadNegocio.IdDivisaBase
                    .IdImpuesto1 = 1
                End With
                Venta.Servicios.AddServiciosRow(drConcepto)
            Next
            'Guardar venta, aplicar y facturar
            Dim VentaSvc As New VentaService(SessionID, Connection, Transaction)
            Venta = VentaSvc.Update(Venta)
            VentaSvc.Aplicar(Venta.Identity, Date.Today)
            VentaSvc.ApplyWorkflow(Venta.Identity, WorkflowSteps.Invoice, Date.Today)
            '
            VentaSvc.GetDetail(Venta.Identity, Venta)
            Dim ComprobanteSvc As New ComprobanteFiscalService(SessionID, Connection, Transaction)
            Comprobante = ComprobanteSvc.Load(Venta.IdSerie, Venta.FolioFactura, Venta.UUIDFactura)
        Catch ex As Exception
            Throw New BusinessException("Error al generar la factura global del corte: " & Date.Now.ToString("dd/MM/yyyy HH:mm:ss"), ex)
        End Try
        Return Comprobante
    End Function


    Public Function GenerarFacturaGlobal(idSucursal As Integer, idCaja As Integer, fecha As Date) As ComprobanteFiscalInfo
        Dim Comprobante As ComprobanteFiscalInfo = Nothing
        Try
            'Cargar información de la factura global
            Dim UnidadNegocioSvc As New UnidadNegocioService(SessionID, Connection, Transaction)
            Dim UnidadNegocio As UnidadNegocioInfo = UnidadNegocioSvc.GetDetailFromCacheByIdSucursal(idSucursal)
            'Cargar ventas no facturadas en el periodo
            Dim Ventas As DataTable = CargarVentasFacturaGlobal(idSucursal, idCaja, fecha)
            'Crear objeto global de ventas
            Dim Venta As VentaInfo = New VentaInfo(SessionID)
            With Venta
                .Fecha = fecha
                .Hora = Date.Now
                .IdSucursal = idSucursal
                .IdCliente = UnidadNegocio.IdClienteFacturacion
                .IdVendedor = 0
                .IdCaja = idCaja
                .CondicionesPago = CondicionesPago.Contado
                .Observaciones = "FACTURA GLOBAL DEL " & fecha.ToShortDateString()
                .Origen = OrigenVenta.FacturaGlobal
                .IdDivisa = UnidadNegocio.IdDivisaBase
            End With

            Dim Totales = From V In Ventas
                          Group V By Porcentaje = CDec(V!TasaIVA)
                          Into SubTotal = Sum(CDec(V!SubTotal)), Descuento = Sum(CDec(V!TotalDescuento)), Traslados = Sum(CDec(V!TotalTraslados)), Retenciones = Sum(CDec(V!TotalRetenciones)), Total = Sum(CDec(V!Total))

            For Each Tasa In Totales
                Dim drConcepto As DetalleVentaDS.ServiciosRow = Venta.Servicios.NewServiciosRow()
                With drConcepto
                    .IdServicio = 1
                    .Codigo = "1"
                    .Descripcion = "FACTURA GLOBAL " & fecha.ToShortDateString() & ", TASA " & (Tasa.Porcentaje * 100).ToString() & " %"
                    .Cantidad = 1
                    .PrecioUnitario = Tasa.SubTotal
                    .MontoDesc1 = Tasa.Descuento
                    .PorcImpTras1 = Tasa.Porcentaje
                    .MontoImpTras1 = Tasa.Traslados
                    .IdDivisa = UnidadNegocio.IdDivisaBase
                    .IdImpuesto1 = 1
                End With
                Venta.Servicios.AddServiciosRow(drConcepto)
            Next

            'Venta.AutoCalcularTotales = False
            'Venta._TotalImpuestosTras = CDec(Venta.Servicios.Compute("SUM(MontoImpTras1)", ""))
            'Venta._TotalImpuestosRet = CDec(Venta.Servicios.Compute("SUM(MontoImpRet1)", ""))
            'Venta._TotalCantidad = 1
            'Venta._SubTotal = CDec(Venta.Servicios.Compute("SUM(PrecioUnitario)", ""))
            'Venta._TotalDescuentos = CDec(Venta.Servicios.Compute("SUM(MontoDesc1)", ""))
            'Venta._TotalComision = 0
            'Venta._Total = Decimal.Round(Venta._SubTotal + Venta._TotalImpuestosTras - Venta._TotalImpuestosRet - Venta._TotalDescuentos, 2)
            'Venta.Servicios(0).PorcImpTras1 = Venta._TotalImpuestosTras / Venta._SubTotal

            'Guardar venta, aplicar y facturar
            Dim VentaSvc As New VentaService(SessionID, Connection, Transaction)
            Venta = VentaSvc.Update(Venta)
            VentaSvc.Aplicar(Venta.Identity, Date.Today)
            VentaSvc.ApplyWorkflow(Venta.Identity, WorkflowSteps.Invoice, Date.Today)
            '
            VentaSvc.GetDetail(Venta.Identity, Venta)
            Dim ComprobanteSvc As New ComprobanteFiscalService(SessionID, Connection, Transaction)
            Comprobante = ComprobanteSvc.Load(Venta.IdSerie, Venta.FolioFactura, Venta.UUIDFactura)
        Catch ex As Exception
            Throw New BusinessException("Error al generar la factura global del " & fecha.ToShortDateString(), ex)
        End Try
        Return Comprobante
    End Function

    Public Function LoadFacturasList(ByVal fechaInicial As Date, ByVal fechaFinal As Date, ByVal idEmpresa As Integer, ByVal idSucursal As Integer, ByVal idCliente As Integer) As InformesDS.FacturasListDataTable
        Try
            Dim fxList As New FunctionSQL("Sales", "fxFacturasListRPT", Connection, Transaction)
            fxList.Parameters.Add("@FechaIni", DbType.DateTime).Value = fechaInicial
            fxList.Parameters.Add("@FechaFin", DbType.DateTime).Value = fechaFinal
            fxList.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            fxList.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            fxList.Parameters.Add("@IdCliente", DbType.Int32).Value = idCliente
            '
            Dim dtList As New InformesDS.FacturasListDataTable
            fxList.FillDataTable(dtList)
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de facturas.", ex)
        End Try
    End Function

    Public Function FacturacionPeriodo(ByVal idEmpresa As Integer, ByVal fechaInicial As Date, ByVal fechaFinal As Date, idCliente As Integer) As InformesDS.FacturacionVTADataTable
        Try
            Dim fxList As New FunctionSQL("Accounting", "fxComprobantesFiscalesRPT", Connection, Transaction)
            fxList.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            fxList.Parameters.Add("@FechaIni", DbType.DateTime).Value = fechaInicial.ToShortDateString
            fxList.Parameters.Add("@FechaFin", DbType.DateTime).Value = fechaFinal.ToShortDateString
            fxList.Parameters.Add("@IdCliente", DbType.Int32).Value = idCliente

            Dim dtList As New InformesDS.FacturacionVTADataTable
            fxList.FillDataTable(dtList)
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de facturas.", ex)
        End Try
    End Function

    Public Function FacturacionPorArticulo(ByVal idEmpresa As Integer, ByVal fechaInicial As Date, ByVal fechaFinal As Date) As InformesDS.FacturacionDetalleDataTable
        Try
            Dim fxList As New FunctionSQL("Accounting", "fxComprobantesFiscalesDetalleRPT", Connection, Transaction)
            fxList.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            fxList.Parameters.Add("@FechaIni", DbType.DateTime).Value = fechaInicial.ToShortDateString
            fxList.Parameters.Add("@FechaFin", DbType.DateTime).Value = fechaFinal.ToShortDateString
            Dim dtList As New InformesDS.FacturacionDetalleDataTable
            fxList.FillDataTable(dtList)
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de facturas.", ex)
        End Try
    End Function

    Public Function LoadFacturaPrintInfo(ByVal idSerie As Integer, ByVal folio As Integer, UUID As String) As InformesDS.FacturasDataTable
        Try
            'Cargar información del comprobante
            Dim ComprobanteSvc As New ComprobanteFiscalService(SessionID, Connection, Transaction)
            Dim Comprobante As ComprobanteFiscalInfo = ComprobanteSvc.Load(idSerie, folio, UUID)
            'Determinar la función del comprobante dependiendo de la versión
            Dim FunctionName As String = "fxFacturaRPT_V2"
            If CDec(Comprobante.Version) >= 3 Then FunctionName = "fxFacturaRPT_V3"

            Dim Factura As New InformesDS.FacturasDataTable
            '
            Dim fxFactura As New FunctionSQL("Sales", FunctionName, Connection, Transaction)
            fxFactura.Parameters.Add("@IdCFDSerie", DbType.Int32).Value = idSerie
            fxFactura.Parameters.Add("@Folio", DbType.Int32).Value = folio
            fxFactura.Parameters.Add("@UUID", DbType.String).Value = UUID
            fxFactura.FillDataTable(Factura)
            Return Factura
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la información de impresión de la factura. " & folio.ToString, ex)
        End Try
    End Function



    Private Sub CreateEmisor(ByVal comprobante As ComprobanteFiscalInfo, ByVal empresa As EmpresaInfo, ByVal unidadNegocio As UnidadNegocioInfo)
        With comprobante.Emisor
            .RFC = empresa.RFC
            .Nombre = empresa.RazonSocial
            With .DomicilioFiscal
                .Calle = empresa.Calle
                .NumExt = empresa.NumExt
                .NumInt = empresa.NumInt
                .Colonia = empresa.Colonia
                Dim PoblacionSvc As New PoblacionService(SessionID, Connection, Transaction)
                Dim PoblacionInf As PoblacionInfo = PoblacionSvc.GetDetailFromCache(empresa.IdPoblacion)
                .Localidad = PoblacionInf.Poblacion
                .Municipio = PoblacionInf.Municipio
                .Estado = PoblacionInf.Estado
                .Pais = PoblacionInf.Pais
                .CodigoPostal = empresa.CodigoPostal
            End With
            '
            With .LugarExpedicion
                .Calle = unidadNegocio.Sucursal.Calle
                .NumExt = unidadNegocio.Sucursal.NumExt
                .NumInt = unidadNegocio.Sucursal.NumInt
                .Colonia = unidadNegocio.Sucursal.Colonia
                Dim PoblacionSvc As New PoblacionService(SessionID, Connection, Transaction)
                Dim PoblacionInf As PoblacionInfo = PoblacionSvc.GetDetailFromCache(unidadNegocio.Sucursal.IdPoblacion)
                .Localidad = PoblacionInf.Poblacion
                .Municipio = PoblacionInf.Municipio
                .Estado = PoblacionInf.Estado
                .Pais = PoblacionInf.Pais
                .CodigoPostal = unidadNegocio.Sucursal.CP
            End With
            '
            Dim EmpresaConfigSvc As New EmpresaConfigService(SessionID, Connection, Transaction)
            Dim Config As EmpresaConfigInfo = EmpresaConfigSvc.GetDetailFromCache(empresa.Identity)
            Dim Regimenes As String() = Config.RegimenFiscal.Split(New Char() {ControlChars.Cr, ControlChars.Lf}, StringSplitOptions.RemoveEmptyEntries)
            For Each regimen As String In Regimenes
                .RegimenesFiscales.Add(regimen.Trim)
            Next
        End With
    End Sub

    Private Sub CreateReceptor(ByVal comprobante As ComprobanteFiscalInfo, ByVal cliente As ClienteInfo)
        With comprobante.Receptor
            .RFC = cliente.RFC
            .Nombre = cliente.RazonSocial
            With .Domicilio
                .Calle = cliente.CalleFiscal
                .NumExt = cliente.NumExtFiscal
                .NumInt = cliente.NumIntFiscal
                .Colonia = cliente.ColoniaFiscal
                Dim PoblacionSvc As New PoblacionService(SessionID, Connection, Transaction)
                Dim PoblacionInf As PoblacionInfo = PoblacionSvc.GetDetailFromCache(cliente.IdPoblacionFiscal)
                .Localidad = PoblacionInf.Poblacion
                .Municipio = PoblacionInf.Municipio
                .Estado = PoblacionInf.Estado
                .Pais = PoblacionInf.Pais
                .CodigoPostal = cliente.CPFiscal
            End With
            '
            With .DomicilioEnvio
                .Calle = cliente.Calle
                .NumExt = cliente.NumExt
                .NumInt = cliente.NumInt
                .Colonia = cliente.Colonia
                .CodigoPostal = cliente.CP
                If cliente.IdPoblacion > 0 Then
                    Dim PoblacionSvc As New PoblacionService(SessionID, Connection, Transaction)
                    Dim PoblacionInf As PoblacionInfo = PoblacionSvc.GetDetailFromCache(cliente.IdPoblacion)
                    .Localidad = PoblacionInf.Poblacion
                    .Municipio = PoblacionInf.Municipio
                    .Estado = PoblacionInf.Estado
                    .Pais = PoblacionInf.Pais
                End If
            End With
        End With
    End Sub

    Private Sub CreateConceptos(ByVal comprobante As ComprobanteFiscalInfo, ByVal venta As VentaInfo)
        'Agregar los conceptos de servicios en la venta
        For Each drPartida As DetalleVentaDS.ServiciosRow In venta.Servicios
            Dim Concepto As New Azteca.Business.Contabilidad.ConceptoInfo
            With Concepto
                .IdServicio = drPartida.IdServicio
                .Codigo = drPartida.Codigo
                .EAN = drPartida.Codigo
                .Descripcion = drPartida.Descripcion
                .Cantidad = drPartida.Cantidad
                .CantidadConsumo = 1
                .ValorUnitario = drPartida.PrecioUnitario
                .FechaDocumento = venta.Fecha
                .IdDocumento = venta.Identity
                .MontoDescuento1 = drPartida.MontoDesc1
                .MontoDescuento2 = drPartida.MontoDesc2
                .MontoDescuento3 = drPartida.MontoDesc3
                .MontoDescuento4 = drPartida.MontoDesc4
                .MontoDescuento5 = drPartida.MontoDesc5
                .PorcentajeImpuestoTrasladado1 = drPartida.PorcImpTras1
                .PorcentajeImpuestoTrasladado2 = drPartida.PorcImpTras2
                .PorcentajeImpuestoTrasladado3 = drPartida.PorcImpTras3
                .MontoImpuestoTrasladado1 = drPartida.MontoImpTras1
                .MontoImpuestoTrasladado2 = drPartida.MontoImpTras2
                .MontoImpuestoTrasladado3 = drPartida.MontoImpTras3
                .PorcentajeImpuestoRetenido1 = drPartida.PorcImpRet1
                .PorcentajeImpuestoRetenido2 = drPartida.PorcImpRet2
                .PorcentajeImpuestoRetenido3 = drPartida.PorcImpRet3
                .MontoImpuestoRetenido1 = drPartida.MontoImpRet1
                .MontoImpuestoRetenido2 = drPartida.MontoImpRet2
                .MontoImpuestoRetenido3 = drPartida.MontoImpRet3
                .PorcentajeDescuento1 = drPartida.PorcDescuento1
                .PorcentajeDescuento2 = drPartida.PorcDescuento2
                .PorcentajeDescuento3 = drPartida.PorcDescuento3
                .PorcentajeDescuento4 = drPartida.PorcDescuento4
                .PorcentajeDescuento5 = drPartida.PorcDescuento5
                If drPartida.NumPedimento <> String.Empty Then
                    Dim InfoAduana As New InformacionAduanera
                    InfoAduana.Numero = drPartida.NumPedimento
                    InfoAduana.Fecha = drPartida.FechaPedimento
                    InfoAduana.Aduana = drPartida.Aduana
                    .InformacionAduanera.Add(InfoAduana)
                End If
            End With
            comprobante.Conceptos.Add(Concepto)
        Next
        'Agregar los conceptos de articulos en la venta
        For Each drPartida As DetalleVentaDS.ArticulosRow In venta.Articulos
            Dim Concepto As New Azteca.Business.Contabilidad.ConceptoInfo
            With Concepto
                .IdServicio = drPartida.IdArticuloStock
                .Codigo = drPartida.Codigo
                .EAN = drPartida.Codigo
                .Descripcion = drPartida.Descripcion
                .Unidad = drPartida.UnidadMedida
                .Cantidad = drPartida.Cantidad
                .CantidadConsumo = 1
                .ValorUnitario = drPartida.PrecioUnitario
                .FechaDocumento = venta.Fecha
                .IdDocumento = venta.Identity
                .MontoDescuento1 = drPartida.MontoDesc1
                .MontoDescuento2 = drPartida.MontoDesc2
                .MontoDescuento3 = drPartida.MontoDesc3
                .MontoDescuento4 = drPartida.MontoDesc4
                .MontoDescuento5 = drPartida.MontoDesc5
                .PorcentajeImpuestoTrasladado1 = drPartida.PorcImpTras1
                .PorcentajeImpuestoTrasladado2 = drPartida.PorcImpTras2
                .PorcentajeImpuestoTrasladado3 = drPartida.PorcImpTras3
                .MontoImpuestoTrasladado1 = drPartida.MontoImpTras1
                .MontoImpuestoTrasladado2 = drPartida.MontoImpTras2
                .MontoImpuestoTrasladado3 = drPartida.MontoImpTras3
                .PorcentajeImpuestoRetenido1 = drPartida.PorcImpRet1
                .PorcentajeImpuestoRetenido2 = drPartida.PorcImpRet2
                .PorcentajeImpuestoRetenido3 = drPartida.PorcImpRet3
                .MontoImpuestoRetenido1 = drPartida.MontoImpRet1
                .MontoImpuestoRetenido2 = drPartida.MontoImpRet2
                .MontoImpuestoRetenido3 = drPartida.MontoImpRet3
                .PorcentajeDescuento1 = drPartida.PorcDescuento1
                .PorcentajeDescuento2 = drPartida.PorcDescuento2
                .PorcentajeDescuento3 = drPartida.PorcDescuento3
                .PorcentajeDescuento4 = drPartida.PorcDescuento4
                .PorcentajeDescuento5 = drPartida.PorcDescuento5
                'Verificar si el pedido contiene información aduanera
                If drPartida.NumPedimento <> String.Empty Then
                    Dim InfoAduana As New InformacionAduanera
                    InfoAduana.Numero = drPartida.NumPedimento
                    InfoAduana.Fecha = drPartida.FechaPedimento
                    InfoAduana.Aduana = drPartida.Aduana
                    .InformacionAduanera.Add(InfoAduana)
                End If
            End With
            comprobante.Conceptos.Add(Concepto)
        Next
    End Sub

    Private Sub CreateImpuestos(ByVal comprobante As ComprobanteFiscalInfo, ByVal venta As VentaInfo, unidadNegocio As UnidadNegocioInfo)
        With comprobante.Impuestos
            If unidadNegocio.PoliticaDescuento = PoliticaDescuento.AntesImpuestos Then
                With .Traslados
                    Dim IVAServicios = From D In venta.Servicios
                    Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpTras1 > 0
                    Group By Porcentaje = D.PorcImpTras1
                    Into Group, SubTotal = Sum((D.PrecioUnitario - D.MontoDesc1 - D.MontoDesc2 - D.MontoDesc3) * D.Cantidad)
                    'Calcular tasas de iva e importes de los servicios
                    For Each TasaIVA In IVAServicios
                        Dim Traslado As New TrasladoInfo()
                        Traslado.Impuesto = TipoImpuestoTraslado.IVA
                        Traslado.Tasa = TasaIVA.Porcentaje * 100D
                        Traslado.Importe = TasaIVA.SubTotal * TasaIVA.Porcentaje
                        .Add(Traslado)
                    Next
                    'Calcular tasas de ieps e importes de los servicios
                    Dim IEPSServicios = From D In venta.Servicios
                    Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpTras2 > 0
                    Group By Porcentaje = D.PorcImpTras2
                    Into Group, SubTotal = Sum((D.PrecioUnitario - D.MontoDesc1 - D.MontoDesc2 - D.MontoDesc3) * D.Cantidad)

                    For Each TasaIEPS In IEPSServicios
                        Dim Traslado As New TrasladoInfo()
                        Traslado.Impuesto = TipoImpuestoTraslado.IEPS
                        Traslado.Tasa = TasaIEPS.Porcentaje * 100D
                        Traslado.Importe = TasaIEPS.SubTotal * TasaIEPS.Porcentaje
                        .Add(Traslado)
                    Next
                    'Calcular tasa de iva e importe de los artículos
                    Dim IVAArticulos = From D In venta.Articulos
                    Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpTras1 > 0
                    Group By Porcentaje = D.PorcImpTras1
                    Into Group, SubTotal = Sum((D.PrecioUnitario - D.MontoDesc1 - D.MontoDesc2 - D.MontoDesc3) * D.Cantidad)
                    '
                    For Each TasaIVA In IVAArticulos
                        Dim Traslado As New TrasladoInfo()
                        Traslado.Impuesto = TipoImpuestoTraslado.IVA
                        Traslado.Tasa = TasaIVA.Porcentaje * 100D
                        Traslado.Importe = TasaIVA.SubTotal * TasaIVA.Porcentaje
                        .Add(Traslado)
                    Next
                    'Calcular tasa de IEPS
                    Dim IEPSArticulos = From D In venta.Articulos
                    Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpTras2 > 0
                    Group By Porcentaje = D.PorcImpTras2
                    Into Group, SubTotal = Sum((D.PrecioUnitario - D.MontoDesc1 - D.MontoDesc2 - D.MontoDesc3) * D.Cantidad)

                    For Each TasaIEPS In IEPSArticulos
                        Dim Traslado As New TrasladoInfo()
                        Traslado.Impuesto = TipoImpuestoTraslado.IEPS
                        Traslado.Tasa = TasaIEPS.Porcentaje * 100D
                        Traslado.Importe = TasaIEPS.SubTotal * TasaIEPS.Porcentaje
                        .Add(Traslado)
                    Next
                End With
                '
                With .Retenciones
                    'Calcular el IVA retenido de los servicios
                    Dim IVAServicios = Aggregate D In venta.Servicios
                    Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpRet1 > 0
                    Into Sum((D.PrecioUnitario - D.MontoDesc1 - D.MontoDesc2 - D.MontoDesc3) * D.Cantidad * D.PorcImpRet1)

                    If IVAServicios > 0 Then
                        Dim Retencion As New RetencionCFDInfo
                        Retencion.Impuesto = TipoImpuestoRetencion.IVA
                        Retencion.Importe = IVAServicios
                        .Add(Retencion)
                    End If
                End With
            Else
                With .Traslados
                    Dim IVAServicios = From D In venta.Servicios
                    Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpTras1 > 0
                    Group By Porcentaje = D.PorcImpTras1
                    Into Group, SubTotal = Sum((D.PrecioUnitario) * D.Cantidad)
                    'Calcular tasas de iva e importes de los servicios
                    For Each TasaIVA In IVAServicios
                        Dim Traslado As New TrasladoInfo()
                        Traslado.Impuesto = TipoImpuestoTraslado.IVA
                        Traslado.Tasa = TasaIVA.Porcentaje * 100D
                        Traslado.Importe = TasaIVA.SubTotal * TasaIVA.Porcentaje
                        .Add(Traslado)
                    Next
                    'Calcular tasas de ieps e importes de los servicios
                    Dim IEPSServicios = From D In venta.Servicios
                    Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpTras2 > 0
                    Group By Porcentaje = D.PorcImpTras2
                    Into Group, SubTotal = Sum((D.PrecioUnitario) * D.Cantidad)

                    For Each TasaIEPS In IEPSServicios
                        Dim Traslado As New TrasladoInfo()
                        Traslado.Impuesto = TipoImpuestoTraslado.IEPS
                        Traslado.Tasa = TasaIEPS.Porcentaje * 100D
                        Traslado.Importe = TasaIEPS.SubTotal * TasaIEPS.Porcentaje
                        .Add(Traslado)
                    Next
                    'Calcular tasa de iva e importe de los artículos
                    Dim IVAArticulos = From D In venta.Articulos
                    Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpTras1 > 0
                    Group By Porcentaje = D.PorcImpTras1
                    Into Group, SubTotal = Sum((D.PrecioUnitario) * D.Cantidad)
                    '
                    For Each TasaIVA In IVAArticulos
                        Dim Traslado As New TrasladoInfo()
                        Traslado.Impuesto = TipoImpuestoTraslado.IVA
                        Traslado.Tasa = TasaIVA.Porcentaje * 100D
                        Traslado.Importe = TasaIVA.SubTotal * TasaIVA.Porcentaje
                        .Add(Traslado)
                    Next
                    'Calcular tasa de IEPS
                    Dim IEPSArticulos = From D In venta.Articulos
                    Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpTras2 > 0
                    Group By Porcentaje = D.PorcImpTras2
                    Into Group, SubTotal = Sum((D.PrecioUnitario) * D.Cantidad)

                    For Each TasaIEPS In IEPSArticulos
                        Dim Traslado As New TrasladoInfo()
                        Traslado.Impuesto = TipoImpuestoTraslado.IEPS
                        Traslado.Tasa = TasaIEPS.Porcentaje * 100D
                        Traslado.Importe = TasaIEPS.SubTotal * TasaIEPS.Porcentaje
                        .Add(Traslado)
                    Next
                End With
                '
                With .Retenciones
                    'Calcular el IVA retenido de los servicios
                    Dim IVAServicios = Aggregate D In venta.Servicios
                    Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpRet1 > 0
                    Into Sum((D.PrecioUnitario) * D.Cantidad * D.PorcImpRet1)

                    If IVAServicios > 0 Then
                        Dim Retencion As New RetencionCFDInfo
                        Retencion.Impuesto = TipoImpuestoRetencion.IVA
                        Retencion.Importe = IVAServicios
                        .Add(Retencion)
                    End If
                End With
            End If
        End With
    End Sub

    Private Sub ValidarClienteFacturacion(ByVal cliente As ClienteInfo)
        If cliente.Facturable Then
            If cliente.RFC = String.Empty OrElse (cliente.RFC.Length < 12 Or cliente.RFC.Length > 13) Then
                Throw New BusinessException("El cliente no tiene un RFC válido.")
            ElseIf cliente.RazonSocial = String.Empty Then
                Throw New BusinessException("El cliente no tiene una razón social válida.")
            ElseIf cliente.IdPoblacionFiscal = 0 Then
                Throw New BusinessException("El cliente no tiene especificada su localidad fiscal")
            End If
        Else
            Throw New BusinessException("El cliente asignado no está marcado para facturación")
        End If
    End Sub

    Private Function CreateCFD(ByVal venta As VentaInfo, ByVal cliente As ClienteInfo) As ComprobanteFiscalInfo
        Dim DivisaSvc As New DivisaService(SessionID, Connection, Transaction)
        Dim Divisa As DivisaInfo = DivisaSvc.GetDetailFromCache(venta.IdDivisa)
        'Validar los datos fiscales del cliente
        ValidarClienteFacturacion(cliente)
        'Obtener información de la unidad de negocios
        Dim UnidadNegocioSvc As New UnidadNegocioService(SessionID, Connection, Transaction)
        Dim UnidadNegocio As UnidadNegocioInfo = UnidadNegocioSvc.GetDetailFromCacheByIdSucursal(venta.IdSucursal)
        'Obtener información de la empresa
        Dim EmpresaSvc As New EmpresaService(SessionID, Connection, Transaction)
        Dim Empresa As EmpresaInfo = EmpresaSvc.GetDetailFromCache(UnidadNegocio.Sucursal.IdEmpresa)
        'Crear comprobante fiscal
        Dim Comprobante As New ComprobanteFiscalInfo(SessionID)
        With Comprobante
            .IdCliente = cliente.Identity
            .Credito = (venta.CondicionesPago = CondicionesPago.Credito)
            .DiasCredito = cliente.DiasCredito
            .FechaDocumento = venta.Fecha
            .IdDocumento = venta.Identity
            If cliente.GLN.Trim <> String.Empty Then
                .GLNBuyer = cliente.GLN
            Else
                .GLNBuyer = CInt(Val(cliente.UserCode)).ToString("0000000000000")
            End If
            .GLNStore = cliente.GLNTienda
            .GLNSeller = UnidadNegocio.GLN
            .SellerID = cliente.NumProveedor.ToString
            .IdAddenda = cliente.IdComprobanteAddenda
            .Referencia = venta.OrdenCompra
            .TipoComprobante = TipoComprobante.Ingreso
            .TipoDocumento = TipoCFD.Factura
            .FormaPago = "PAGO EN UNA SOLA EXHIBICION"
            .IdSucursal = venta.IdSucursal
            .IdDivisa = venta.IdDivisa
            .Divisa = Divisa.Abreviatura
            .TipoCambio = DivisaSvc.GetTipoCambioActual(.IdDivisa)
            If cliente.IdMetodoPago > 0 Then
                .MetodoPago = cliente.MetodoPago
                .NumeroCuentaPago = cliente.CuentaPago
            End If
            '
            CreateEmisor(Comprobante, Empresa, UnidadNegocio)
            .LugarExpedicion = .Emisor.LugarExpedicion.Municipio & ", " & .Emisor.LugarExpedicion.Estado & ", " & .Emisor.LugarExpedicion.Pais
            CreateReceptor(Comprobante, cliente)
            CreateConceptos(Comprobante, venta)
            CreateImpuestos(Comprobante, venta, UnidadNegocio)
        End With
        '
        Return Comprobante
    End Function


    Public Function Facturar(ByVal venta As VentaInfo) As ComprobanteFiscalInfo
        'Obtener información del cliente
        Dim ClienteSvc As New ClienteService(SessionID, Connection, Transaction)
        Dim Cliente As New ClienteInfo(SessionID)
        ClienteSvc.GetDetail(venta.IdCliente, Cliente, False)
        'Crear y llenar un objeto del CFD
        Dim Comprobante As ComprobanteFiscalInfo = CreateCFD(venta, Cliente)
        'Obtener información de la unidad de negocios
        Dim UnidadNegocioSvc As New UnidadNegocioService(SessionID, Connection, Transaction)
        Dim UnidadNegocio As UnidadNegocioInfo = UnidadNegocioSvc.GetDetailFromCacheByIdSucursal(venta.IdSucursal)
        'Generar comprobante fiscal en la base de datos
        Dim ComprobanteSvc As New ComprobanteFiscalService(SessionID, Connection, Transaction)
        Comprobante = ComprobanteSvc.Generar(UnidadNegocio.IdSerieFacturas, Comprobante)
        'Actualizar información de la factura en la venta
        Dim spFacturar As New StoredProcedure("Sales", "VentasTitFacturar", Connection, Transaction)
        spFacturar.Parameters.Add("@IdVentaTit", DbType.String).Value = venta.Identity
        spFacturar.Parameters.Add("@IdCFDSerie", DbType.Int32).Value = Comprobante.IdSerie
        spFacturar.Parameters.Add("@SerieFactura", DbType.String).Value = Comprobante.Serie
        spFacturar.Parameters.Add("@FolioFactura", DbType.Int32).Value = Comprobante.Folio
        spFacturar.Parameters.Add("@UUID", DbType.String).Value = Comprobante.UUID
        spFacturar.Parameters.Add("@FechaFactura", DbType.DateTime).Value = Comprobante.Fecha
        spFacturar.Execute()
        'Si el cliente tiene registrada una dirección de correo electrónico, enviar factura
        If UnidadNegocio.IdRemitente > 0 And UnidadNegocio.EnviarFacturas And Cliente.Correo.Trim <> String.Empty Then
            Try
                Dim RemitenteSvc As New Azteca.Kernel.Mail.RemitenteService(SessionID, Connection, Transaction)
                'Cargar información del remitente
                Dim Remitente As New Azteca.Kernel.Mail.RemitenteInfo(SessionID)
                RemitenteSvc.GetDetail(UnidadNegocio.IdRemitente, Remitente, False)
                'Crear mensaje de email y adjuntar xml y pdf
                Dim Email As New Chilkat.Email
                Dim Success As Boolean = Email.AddTo(String.Empty, Cliente.Correo)
                If Not Success Then Throw New BusinessException("Error al establecer el destinatario de correo. " & Email.LastErrorText)
                Email.Subject = "Factura Electrónica " & Comprobante.Serie.Trim & Comprobante.Folio.ToString
                Email.Body = ""
                'Obtener xml y pdf del comprobante fiscal
                Dim xml As String = ComprobanteSvc.LoadXML(Comprobante.IdSerie, Comprobante.Folio, Comprobante.UUID)
                Dim pdf As Byte() = GenerarFacturaPDF(UnidadNegocio, Comprobante)
                Email.AddStringAttachment(Comprobante.Serie.Trim & Comprobante.Folio.ToString & ".xml", xml)
                Email.AddDataAttachment2(Comprobante.Serie.Trim & Comprobante.Folio.ToString & ".pdf", pdf, "PDF")
                RemitenteSvc.SendMail(Remitente, Email)
            Catch ex As Exception
                AppEventLog.LogException(ex)
            End Try
        End If
        Return Comprobante
    End Function

    Public Sub EnviarFactura(ByVal correo As String, ByVal fechaComprobante As Date, ByVal idCFDSerie As Integer, ByVal folio As Integer, UUID As String, ByVal idSucursal As Integer)
        EnviarFactura(correo, fechaComprobante, idCFDSerie, folio, UUID, idSucursal, "")
    End Sub

    Public Sub EnviarFactura(ByVal correo As String, ByVal fechaComprobante As Date, ByVal idCFDSerie As Integer, ByVal folio As Integer, UUID As String, ByVal idSucursal As Integer, Mensaje As String)
        Try
            Dim ComprobanteSvc As New ComprobanteFiscalService(SessionID, Connection, Transaction)
            Dim Comprobante As ComprobanteFiscalInfo = ComprobanteSvc.Load(fechaComprobante, idCFDSerie, folio, UUID)
            'Obtener información de la unidad de negocios
            Dim UnidadNegocioSvc As New UnidadNegocioService(SessionID, Connection, Transaction)
            Dim UnidadNegocio As UnidadNegocioInfo = UnidadNegocioSvc.GetDetailFromCacheByIdSucursal(idSucursal)
            Dim RemitenteSvc As New Azteca.Kernel.Mail.RemitenteService(SessionID, Connection, Transaction)
            'Cargar información del remitente
            Dim Remitente As New Azteca.Kernel.Mail.RemitenteInfo(SessionID)
            RemitenteSvc.GetDetail(UnidadNegocio.IdRemitente, Remitente, False)
            'Crear mensaje de email y adjuntar xml y pdf
            Dim Email As New Chilkat.Email
            Dim Success As Boolean = Email.AddTo(String.Empty, correo)
            If Not Success Then Throw New BusinessException("Error al establecer el destinatario de correo. " & Email.LastErrorText)
            Email.Subject = "Factura Electrónica " & Comprobante.Serie.Trim & Comprobante.Folio.ToString
            Email.Body = Mensaje
            'Obtener xml y pdf del comprobante fiscal
            Dim xml As String = ComprobanteSvc.LoadXML(Comprobante.IdSerie, Comprobante.Folio, Comprobante.UUID)
            Dim pdf As Byte() = GenerarFacturaPDF(UnidadNegocio, Comprobante)
            Email.AddStringAttachment(Comprobante.Serie.Trim & Comprobante.Folio.ToString & ".xml", xml)
            Email.AddDataAttachment2(Comprobante.Serie.Trim & Comprobante.Folio.ToString & ".pdf", pdf, "PDF")
            RemitenteSvc.SendMail(Remitente, Email)
        Catch ex As Exception
            Throw New BusinessException("Error al enviar la factura por correo electrónico.", ex)
        End Try
    End Sub

    Private Function GenerarFacturaPDF(ByVal unidadNegocio As UnidadNegocioInfo, comprobante As ComprobanteFiscalInfo) As Byte()
        Try
            'Cargar información de la empresa
            Dim EmpresaSvc As New EmpresaService(SessionID, Connection, Transaction)
            Dim Empresa As EmpresaInfo = EmpresaSvc.GetDetailFromCache(unidadNegocio.IdEmpresa)
            'Cargar información de la factura
            Dim VentaSvc As New VentaService(SessionID, Connection, Transaction)
            Dim dtFactura As InformesDS.FacturasDataTable = VentaSvc.LoadFacturaPrintInfo(comprobante.IdSerie, comprobante.Folio, comprobante.UUID)
            'Cargar información del logo y el QR            
            Dim Imagenes As New Azteca.Business.Contabilidad.InformesDS.ImagenesDataTable
            Dim dr As Azteca.Business.Contabilidad.InformesDS.ImagenesRow = Imagenes.NewImagenesRow
            dr.Logo = Empresa.Logo
            dr.QrCode = comprobante.QrCode
            Imagenes.AddImagenesRow(dr)
            'Cargar formato de factura asignado a la sucursal
            Dim Report As New LocalReport()
            Dim FormatMgr As New Azteca.Kernel.General.FormatManager
            Dim FormatoFactura As String = FormatMgr.LoadFormatFromCache(SessionID, unidadNegocio.IdFormatoFacturas)
            Dim Reader As New System.IO.StringReader(FormatoFactura)
            Report.LoadReportDefinition(Reader)
            '
            Report.DataSources.Add(New ReportDataSource("Imagenes", CType(Imagenes, DataTable)))
            Report.DataSources.Add(New ReportDataSource("Facturas", CType(dtFactura, DataTable)))
            '
            Dim mimeType As String = String.Empty
            Dim encoding As String = String.Empty
            Dim fileNameExtension As String = String.Empty

            Dim deviceInfo As String = _
              "<DeviceInfo>" + _
              "  <OutputFormat>PDF</OutputFormat>" & _
              "  <PageWidth>8.5in</PageWidth>" & _
              "  <PageHeight>11in</PageHeight>" & _
              "  <MarginTop>0.5in</MarginTop>" & _
              "  <MarginLeft>>0.5in</MarginLeft>" & _
              "  <MarginRight>>0.5in</MarginRight>" & _
              "  <MarginBottom>>0.5in</MarginBottom>" & _
              "</DeviceInfo>"
            '
            Dim warnings() As Warning = Nothing
            Dim streams() As String = Nothing
            Dim renderedBytes() As Byte = Report.Render("PDF", deviceInfo, mimeType, encoding, fileNameExtension, streams, warnings)
            Return renderedBytes
        Catch ex As Exception
            Throw New BusinessException("Error al descargar la factura en formato PDF desde el servidor de informes.", ex)
        End Try
    End Function

#End Region

#Region "Inventario"

    Private Function GenerarSalida(ByVal venta As VentaInfo, ByVal idAlmacen As Integer) As String
        Try
            Dim Salida As New MovimientoInfo(venta.SessionID)
            With Salida
                .IdAlmacen = idAlmacen
                .Direccion = TipoMovimiento.Salida
                .Fecha = Date.Today
                'Obtener el identificador de concepto de la salida por venta
                Dim IdConcepto As Integer = CInt(Azteca.Kernel.Configuration.ConfigurationManager.SystemConfiguration.GetValue("Configuracion/Inventario/Conceptos", "Venta"))
                .IdConcepto = IdConcepto
                .IdSucursal = venta.IdSucursal
                .Observaciones = "Venta: " & venta.Identity
                .Referencia = venta.Identity
            End With
            For Each drPartida As DetalleVentaDS.ArticulosRow In venta.Articulos
                Dim drArticulo As DetalleMovimientoDS.DetalleRow = Salida.Details.NewDetalleRow
                With drArticulo
                    .IdArticuloStock = drPartida.IdArticuloStock
                    .Cantidad = drPartida.Cantidad
                    .IdUnidadMedida = drPartida.IdUnidadMedida
                    .CostoUnitario = drPartida.PrecioUnitario
                End With
                Salida.Details.AddDetalleRow(drArticulo)
            Next
            If Salida.Details.Count > 0 Then
                Dim SalidaSvc As New MovimientoService(SessionID, Connection, Transaction)
                Salida = SalidaSvc.Update(Salida)
                SalidaSvc.ApplyWorkflow(Salida.Identity, WorkflowSteps.Apply, Date.Today)
                Return Salida.Identity
            Else
                Return String.Empty
            End If
        Catch ex As CustomErrorException
            Throw ex
        Catch ex As Exception
            Throw New BusinessException("Error al generar la salida de artículos de la venta.", ex)
        End Try
    End Function

#End Region

#Region "Informes"

    Public Function LoadPrintInfo(ByVal idVentaTit As String) As DataTable
        Try
            Dim fxVenta As New FunctionSQL("Sales", "fxVentaRPT", Connection, Transaction)
            fxVenta.Parameters.Add("@IdVentaTit", DbType.String).Value = idVentaTit
            Dim dtVenta As DataTable = fxVenta.GetTable("Informe")
            Return dtVenta
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la información de impresión del pedido " & idVentaTit, ex)
        End Try
    End Function

    Public Function InformeVentasGeneral(ByVal fechaIni As DateTime, ByVal fechaFin As DateTime, ByVal idCliente As Integer, ByVal idArticuloStock As Integer, ByVal idSucursal As Integer, ByVal idSucursalDefault As Integer) As DataTable
        Try
            Dim fxInventario As New FunctionSQL("Sales", "fxVentasGeneralRPT", Connection, Transaction)
            fxInventario.Parameters.Add("@FechaIni", DbType.DateTime).Value = fechaIni
            fxInventario.Parameters.Add("@FechaFin", DbType.DateTime).Value = fechaFin
            fxInventario.Parameters.Add("@IdCliente", DbType.Int32).Value = idCliente
            fxInventario.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idArticuloStock
            fxInventario.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            fxInventario.Parameters.Add("@IdSucursalDefault", DbType.Int32).Value = idSucursalDefault
            
            Dim dtVentasGeneral As DataTable = fxInventario.GetTable("VentasGen")
            Return dtVentasGeneral
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la información de las ventas generales.", ex)
        End Try
    End Function

    Public Function LoadPrintUbicaciones(ByVal idVentaTit As String, IdAlmacen As Integer) As DataTable
        Try
            Dim fxVenta As New FunctionSQL("Sales", "VentaUbicacionRPT", Connection, Transaction)
            fxVenta.Parameters.Add("@IdVentaTit", DbType.String).Value = idVentaTit
            fxVenta.Parameters.Add("@IdAlmacen", DbType.Int32).Value = IdAlmacen
            Dim dtVenta As DataTable = fxVenta.GetTable("Ubicaciones")
            Return dtVenta
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la información de impresión del pedido para la ubicación " & idVentaTit, ex)
        End Try
    End Function
#End Region

#Region "Generales"
    Public Function LoadList(ByVal FechaIni As Date, ByVal FechaFin As Date, ByVal IdUsuario As Integer, ByVal IdSucursal As Integer) As DataTable
        Dim dtList As DataTable = Nothing
        Try
            Dim fxList As New FunctionSQL("Sales", "fxVentasTitList", Connection, Transaction)
            fxList.Parameters.Add("@FechaIni", DbType.DateTime).Value = FechaIni
            fxList.Parameters.Add("@FechaFin", DbType.DateTime).Value = FechaFin
            fxList.Parameters.Add("@IdUsuario", DbType.Int32).Value = IdUsuario
            fxList.Parameters.Add("@IdSucursal", DbType.Int32).Value = IdSucursal
            dtList = fxList.GetTable
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de ventas.", ex)
        End Try
        Return dtList
    End Function
#End Region

End Class


Partial Class VentaFacade

#Region "Generales"
    Public Function SaveApplyToPrint(ByVal sessionID As Guid, ByVal Venta As VentaInfo, ByVal PagosTable As DetalleVentaDS.FormasPagoDataTable, idAlmacen As Integer) As DataSet
        ValidateSession(sessionID)
        Dim Svc As New VentaService(sessionID)
        Dim ds As New DataSet
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Svc = New VentaService(sessionID, Connection, Transaction)
                Venta = Svc.Update(Venta)
                Svc.Aplicar(Venta.Identity, Date.Today, PagosTable)
                DataServices.CommitTransaction(Transaction)
            Catch ex As Exception
                DataServices.RollbackTransaction(Transaction)
                Svc.resetIdentity(Venta)
                Throw ex
            End Try
            Dim dt As DataTable = Svc.LoadPrintInfo(Venta.Identity)
            ds.Tables.Add(dt)
            Dim Ubicacionestable As DataTable = Svc.LoadPrintUbicaciones(Venta.Identity, idAlmacen)
            ds.Tables.Add(Ubicacionestable)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return ds
    End Function

    Public Function LoadList(ByVal sessionID As Guid, ByVal FechaIni As Date, ByVal FechaFin As Date, ByVal IdUsuario As Integer, ByVal IdSucursal As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New VentaService(sessionID, Connection, Transaction)
            dtList = Svc.LoadList(FechaIni, FechaFin, IdUsuario, IdSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

#End Region

#Region "Aplicacion"

    Public Sub Aplicar(ByVal sessionID As Guid, ByVal idVenta As String, ByVal fechaTrabajo As Date)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New VentaService(sessionID, Connection, Transaction)
                Svc.Aplicar(idVenta, fechaTrabajo)
                DataServices.CommitTransaction(Transaction)
            Catch ex As Exception
                DataServices.RollbackTransaction(Transaction)
                Throw ex
            End Try
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub

    Public Sub Aplicar(ByVal sessionID As Guid, ByVal idVenta As String, ByVal fechaTrabajo As Date, ByVal formasPago As DetalleVentaDS.FormasPagoDataTable)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New VentaService(sessionID, Connection, Transaction)
                Svc.Aplicar(idVenta, fechaTrabajo, formasPago)
                DataServices.CommitTransaction(Transaction)
            Catch ex As Exception
                DataServices.RollbackTransaction(Transaction)
                Throw ex
            End Try
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub


    Public Sub Aplicar(ByVal sessionID As Guid, ByVal idVenta As String, ByVal fechaTrabajo As Date, ByVal idFormaPago As Integer, ByVal monto As Decimal)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New VentaService(sessionID, Connection, Transaction)
                Svc.Aplicar(idVenta, fechaTrabajo, idFormaPago, monto)
                DataServices.CommitTransaction(Transaction)
            Catch ex As Exception
                DataServices.RollbackTransaction(Transaction)
                Throw ex
            End Try
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub

#End Region

#Region "Facturacion"

    Public Function GenerarFacturaGlobal(sessionID As Guid, idSucursal As Integer, idCaja As Integer, fecha As Date) As ComprobanteFiscalInfo
        ValidateSession(sessionID)
        Dim Comprobante As ComprobanteFiscalInfo = Nothing
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New VentaService(sessionID, Connection, Transaction)
                Comprobante = Svc.GenerarFacturaGlobal(idSucursal, idCaja, fecha)
                DataServices.CommitTransaction(Transaction)
            Catch ex As Exception
                DataServices.RollbackTransaction(Transaction)
                Throw ex
            End Try
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Comprobante
    End Function

    Public Function FacturaGlobalExists(sessionID As Guid, idSucursal As Integer, idCaja As Integer, fecha As Date) As Boolean
        Dim Result As Boolean = False
        Try
            Connection = DataServices.OpenConnection
            Dim VentaSvc As New VentaService(sessionID, Connection, Transaction)
            Result = VentaSvc.FacturaGlobalExists(idSucursal, idCaja, fecha)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Result
    End Function


    Public Function CargarFacturasGlobales(sessionID As Guid, idSucursal As Integer, fechaInicial As Date, fechaFinal As Date) As DataTable
        Dim dtFacturas As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim VentaSvc As New VentaService(sessionID, Connection, Transaction)
            dtFacturas = VentaSvc.CargarFacturasGlobales(idSucursal, fechaInicial, fechaFinal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtFacturas
    End Function


    Public Function CargarVentasFacturaGlobal(sessionID As Guid, idSucursal As Integer, idCaja As Integer, fecha As Date) As DataTable
        Dim dtVentas As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim VentaSvc As New VentaService(sessionID, Connection, Transaction)
            dtVentas = VentaSvc.CargarVentasFacturaGlobal(idSucursal, idCaja, fecha)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtVentas
    End Function


    Public Function FacturacionPOS(ByVal sessionID As Guid, Venta As VentaInfo) As VentaInfo
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = Connection.BeginTransaction
                Dim Svc As New VentaService(sessionID, Connection, Transaction)
                Venta = Svc.Update(Venta)
                Svc.ApplyWorkflow(Venta.Identity, WorkflowSteps.Invoice, Date.Today)
                Svc.GetDetail(Venta.Identity, Venta)
                Transaction.Commit()
            Catch ex As Exception
                Transaction.Rollback()
                Throw ex
            End Try
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Venta
    End Function

    Public Function LoadFacturaPrintInfo(ByVal sessionID As Guid, ByVal idSerie As Integer, ByVal folio As Integer, UUID As String) As InformesDS.FacturasDataTable
        ValidateSession(sessionID)
        Dim dtFactura As New InformesDS.FacturasDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New VentaService(sessionID, Connection)
            dtFactura = Svc.LoadFacturaPrintInfo(idSerie, folio, UUID)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtFactura
    End Function

    Public Function LoadFacturasList(ByVal sessionID As Guid, ByVal fechaInicial As Date, ByVal fechaFinal As Date, ByVal idEmpresa As Integer, ByVal idSucursal As Integer, ByVal idCliente As Integer) As InformesDS.FacturasListDataTable
        ValidateSession(sessionID)
        Dim dtList As New InformesDS.FacturasListDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New VentaService(sessionID, Connection)
            dtList = Svc.LoadFacturasList(fechaInicial, fechaFinal, idEmpresa, idSucursal, idCliente)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Sub EnviarFactura(ByVal sessionID As Guid, ByVal correo As String, ByVal fechaComprobante As Date, ByVal idCFDSerie As Integer, ByVal folio As Integer, UUID As String, ByVal idSucursal As Integer)
        EnviarFactura(sessionID, correo, fechaComprobante, idCFDSerie, folio, UUID, idSucursal, "")
    End Sub

    Public Sub EnviarFactura(ByVal sessionID As Guid, ByVal correo As String, ByVal fechaComprobante As Date, ByVal idCFDSerie As Integer, ByVal folio As Integer, UUID As String, ByVal idSucursal As Integer, Mensaje As String)
        ValidateSession(sessionID)
        Dim dtFactura As New InformesDS.FacturasDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New VentaService(sessionID, Connection)
            Svc.EnviarFactura(correo, fechaComprobante, idCFDSerie, folio, UUID, idSucursal, Mensaje)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub

    Public Function FacturacionPeriodo(ByVal sessionID As Guid, ByVal idEmpresa As Integer, ByVal fechaInicial As Date, ByVal fechaFinal As Date, idCliente As Integer) As InformesDS.FacturacionVTADataTable
        ValidateSession(sessionID)
        Dim dtList As New InformesDS.FacturacionVTADataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New VentaService(sessionID, Connection)
            dtList = Svc.FacturacionPeriodo(idEmpresa, fechaInicial, fechaFinal, idCliente)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function FacturacionPorArticulo(ByVal sessionID As Guid, ByVal idEmpresa As Integer, ByVal fechaInicial As Date, ByVal fechaFinal As Date) As InformesDS.FacturacionDetalleDataTable
        ValidateSession(sessionID)
        Dim dtList As New InformesDS.FacturacionDetalleDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New VentaService(sessionID, Connection)
            dtList = Svc.FacturacionPorArticulo(idEmpresa, fechaInicial, fechaFinal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function


#End Region

#Region "Informes"

    Public Function LoadPrintInfo(ByVal sessionID As Guid, ByVal idVentaTit As String) As DataTable
        ValidateSession(sessionID)
        Dim dtVenta As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New VentaService(sessionID, Connection)
            dtVenta = Svc.LoadPrintInfo(idVentaTit)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtVenta
    End Function

    Public Function InformeVentasGeneral(ByVal sessionID As Guid, ByVal fechaIni As DateTime, ByVal fechaFin As DateTime, ByVal idCliente As Integer, ByVal idArticuloStock As Integer, ByVal idSucursal As Integer, ByVal idSucursalDefault As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtVenta As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New VentaService(sessionID, Connection)
            dtVenta = Svc.InformeVentasGeneral(fechaIni, fechaFin, idCliente, idArticuloStock, idSucursal, idSucursalDefault)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtVenta
    End Function

#End Region

End Class


Public Enum CondicionesPago
    Contado
    Credito
End Enum

Public Enum OrigenVenta
    Manual
    POS
    Movil
    FacturaGlobal
End Enum
