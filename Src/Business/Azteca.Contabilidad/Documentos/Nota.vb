Imports Azteca.Kernel.General
Imports Microsoft.Reporting.WinForms

Partial Class NotaFacade
#Region "Generales"

    Public Function LoadList(ByVal sessionID As Guid, ByVal FechaIni As Date, ByVal FechaFin As Date, ByVal IdUsuario As Integer, ByVal IdSucursal As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New NotaService(sessionID, Connection, Transaction)
            dtList = Svc.LoadList(FechaIni, FechaFin, IdUsuario, IdSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function


    Public Sub EnviarComprobante(ByVal sessionID As Guid, ByVal correo As String, ByVal fechaComprobante As Date, ByVal idCFDSerie As Integer, ByVal folio As Integer, UUID As String, ByVal idSucursal As Integer, Mensaje As String, IdRemitente As Integer)
        ValidateSession(sessionID)
        Dim dtComprobante As New InformesDS.ComprobantesFiscalesDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New NotaService(sessionID, Connection)
            Svc.EnviarComprobante(correo, fechaComprobante, idCFDSerie, folio, UUID, idSucursal, Mensaje, IdRemitente)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub
#End Region

End Class

Partial Class NotaService

#Region "Facturacion"

    Public Function Facturar(ByVal nota As NotaInfo) As ComprobanteFiscalInfo
        'Crear y llenar un objeto del CFD
        Dim Comprobante As ComprobanteFiscalInfo = CreateCFD(nota)
        'Cargar información de sucursal
        Dim ConfigFac As New SucursalConfigService(sessionID, Connection, Transaction)
        Dim SucursalConfig As SucursalConfigInfo = ConfigFac.CargarConfiguracion(nota.IdSucursal)
        Dim IdSerie As Integer = 0
        If nota.Tipo = TipoNota.Cargo Then
            IdSerie = SucursalConfig.IdSerieNotasCargo
        Else
            IdSerie = SucursalConfig.IdSerieNotasCredito
        End If
        If IdSerie = 0 Then Throw New BusinessException("La sucursal (" & nota.IdSucursal.ToString & ") a la que pertenece la nota no tiene configurada una serie de facturación.")
        'Generar comprobante fiscal en la base de datos
        Dim ComprobanteSvc As New ComprobanteFiscalService(sessionID, Connection, Transaction)
        Comprobante = ComprobanteSvc.Generar(IdSerie, Comprobante)
        'Actualizar información de la factura en la venta
        Dim spFacturar As New StoredProcedure("Accounting", "NotasTitGenerar", Connection, Transaction)
        spFacturar.Parameters.Add("@IdNotaTit", DbType.String).Value = nota.Identity
        spFacturar.Parameters.Add("@IdCFDSerie", DbType.Int32).Value = Comprobante.IdSerie
        spFacturar.Parameters.Add("@Folio", DbType.Int32).Value = Comprobante.Folio
        spFacturar.Parameters.Add("@UUID", DbType.String).Value = Comprobante.UUID
        spFacturar.Parameters.Add("@Fecha", DbType.DateTime).Value = Comprobante.Fecha
        spFacturar.Execute()
        Return Comprobante
    End Function


    Private Function CreateCFD(ByVal nota As NotaInfo) As ComprobanteFiscalInfo
        Dim DivisaSvc As New DivisaService(sessionID, Connection, Transaction)
        Dim Divisa As DivisaInfo = DivisaSvc.GetDetailFromCache(nota.IdDivisa)
        'Obtener información de la unidad de negocios
        Dim SucursalSvc As New SucursalService(sessionID, Connection, Transaction)
        Dim Sucursal As SucursalInfo = SucursalSvc.GetDetailFromCache(nota.IdSucursal)
        'Obtener información de la empresa
        Dim EmpresaSvc As New EmpresaService(sessionID, Connection, Transaction)
        Dim Empresa As EmpresaInfo = EmpresaSvc.GetDetailFromCache(Sucursal.IdEmpresa)
        'Crear comprobante fiscal
        Dim Comprobante As New ComprobanteFiscalInfo(sessionID)
        With Comprobante
            .IdCliente = nota.IdCliente
            .Credito = False
            .DiasCredito = 0
            .FechaDocumento = nota.Fecha
            .IdDocumento = nota.Identity
            .GLNBuyer = String.Empty
            .GLNStore = String.Empty
            .GLNSeller = String.Empty
            .SellerID = String.Empty
            .IdAddenda = 0
            .Referencia = String.Empty
            If nota.Tipo = TipoNota.Cargo Then
                .TipoComprobante = TipoComprobante.Ingreso
                .TipoDocumento = TipoCFD.NotaCargo
            Else
                .TipoComprobante = TipoComprobante.Egreso
                .TipoDocumento = TipoCFD.NotaCredito
            End If
            .FormaPago = "PAGO EN UNA SOLA EXHIBICION"
            .IdSucursal = nota.IdSucursal
            .IdDivisa = nota.IdDivisa
            .Divisa = Divisa.Abreviatura
            .TipoCambio = DivisaSvc.GetTipoCambioActual(.IdDivisa)
            '
            CreateEmisor(Comprobante, Empresa, Sucursal)
            .LugarExpedicion = .Emisor.LugarExpedicion.Municipio & ", " & .Emisor.LugarExpedicion.Estado & ", " & .Emisor.LugarExpedicion.Pais
            CreateReceptor(Comprobante, nota)
            CreateConceptos(Comprobante, nota)
            CreateImpuestos(Comprobante, nota)
        End With
        '
        Return Comprobante
    End Function

    Private Sub CreateEmisor(ByVal comprobante As ComprobanteFiscalInfo, ByVal empresa As EmpresaInfo, ByVal sucursal As SucursalInfo)
        With comprobante.Emisor
            .RFC = empresa.RFC
            .Nombre = empresa.RazonSocial
            With .DomicilioFiscal
                .Calle = empresa.Calle
                .NumExt = empresa.NumExt
                .NumInt = empresa.NumInt
                .Colonia = empresa.Colonia
                Dim PoblacionSvc As New PoblacionService(sessionID, Connection, Transaction)
                Dim PoblacionInf As PoblacionInfo = PoblacionSvc.GetDetailFromCache(empresa.IdPoblacion)
                .Localidad = PoblacionInf.Poblacion
                .Municipio = PoblacionInf.Municipio
                .Estado = PoblacionInf.Estado
                .Pais = PoblacionInf.Pais
                .CodigoPostal = empresa.CodigoPostal
            End With
            '
            With .LugarExpedicion
                .Calle = sucursal.Calle
                .NumExt = sucursal.NumExt
                .NumInt = sucursal.NumInt
                .Colonia = sucursal.Colonia
                Dim PoblacionSvc As New PoblacionService(sessionID, Connection, Transaction)
                Dim PoblacionInf As PoblacionInfo = PoblacionSvc.GetDetailFromCache(sucursal.IdPoblacion)
                .Localidad = PoblacionInf.Poblacion
                .Municipio = PoblacionInf.Municipio
                .Estado = PoblacionInf.Estado
                .Pais = PoblacionInf.Pais
                .CodigoPostal = sucursal.CP
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

    Private Sub CreateReceptor(ByVal comprobante As ComprobanteFiscalInfo, ByVal nota As NotaInfo)
        With comprobante.Receptor
            .RFC = nota.RFC
            .Nombre = nota.RazonSocial
            With .Domicilio
                .Calle = nota.Calle
                .NumExt = nota.NumExt
                .NumInt = nota.NumInt
                .Colonia = nota.Colonia
                Dim PoblacionSvc As New PoblacionService(sessionID, Connection, Transaction)
                Dim PoblacionInf As PoblacionInfo = PoblacionSvc.GetDetailFromCache(nota.IdPoblacion)
                .Localidad = PoblacionInf.Poblacion
                .Municipio = PoblacionInf.Municipio
                .Estado = PoblacionInf.Estado
                .Pais = PoblacionInf.Pais
                .CodigoPostal = nota.CP
            End With
            '
            With .DomicilioEnvio
                .Calle = nota.Calle
                .NumExt = nota.NumExt
                .NumInt = nota.NumInt
                .Colonia = nota.Colonia
                .CodigoPostal = nota.CP
                Dim PoblacionSvc As New PoblacionService(sessionID, Connection, Transaction)
                Dim PoblacionInf As PoblacionInfo = PoblacionSvc.GetDetailFromCache(nota.IdPoblacion)
                .Localidad = PoblacionInf.Poblacion
                .Municipio = PoblacionInf.Municipio
                .Estado = PoblacionInf.Estado
                .Pais = PoblacionInf.Pais
            End With
        End With
    End Sub

    Private Sub CreateConceptos(ByVal comprobante As ComprobanteFiscalInfo, ByVal nota As NotaInfo)
        'Agregar los conceptos de servicios en la venta
        For Each drPartida As DetalleNotaDS.DetalleRow In nota.Details
            Dim Concepto As New ConceptoInfo
            With Concepto
                .Codigo = drPartida.CodigoConcepto
                .EAN = drPartida.CodigoConcepto
                .Descripcion = drPartida.Concepto
                .Cantidad = 1
                .CantidadConsumo = 1
                .ValorUnitario = drPartida.Monto
                .FechaDocumento = nota.Fecha
                .IdDocumento = nota.Identity
                .Referencia = drPartida.Referencia
                .MontoDescuento1 = 0
                .MontoDescuento2 = 0
                .MontoDescuento3 = 0
                .MontoDescuento4 = 0
                .MontoDescuento5 = 0
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
                .PorcentajeDescuento1 = 0
                .PorcentajeDescuento2 = 0
                .PorcentajeDescuento3 = 0
                .PorcentajeDescuento4 = 0
                .PorcentajeDescuento5 = 0
            End With
            comprobante.Conceptos.Add(Concepto)
        Next
    End Sub

    Private Sub CreateImpuestos(ByVal comprobante As ComprobanteFiscalInfo, ByVal nota As NotaInfo)
        With comprobante.Impuestos
            With .Traslados
                Dim IVA = From D In nota.Details
                Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpTras1 > 0
                Group By Porcentaje = D.PorcImpTras1
                Into Group, SubTotal = Sum(D.Monto)
                'Calcular tasas de iva e importes de los servicios
                For Each TasaIVA In IVA
                    Dim Traslado As New TrasladoInfo()
                    Traslado.Impuesto = TipoImpuestoTraslado.IVA
                    Traslado.Tasa = TasaIVA.Porcentaje * 100D
                    Traslado.Importe = TasaIVA.SubTotal * TasaIVA.Porcentaje
                    .Add(Traslado)
                Next
                'Calcular tasas de ieps e importes de los servicios
                Dim IEPS = From D In nota.Details
                Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpTras2 > 0
                Group By Porcentaje = D.PorcImpTras2
                Into Group, SubTotal = Sum(D.Monto)

                For Each TasaIEPS In IEPS
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
                Dim IVA = Aggregate D In nota.Details
                Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpRet1 > 0
                Into Sum(D.Monto)

                If IVA > 0 Then
                    Dim Retencion As New RetencionCFDInfo
                    Retencion.Impuesto = TipoImpuestoRetencion.IVA
                    Retencion.Importe = IVA
                    .Add(Retencion)
                End If
            End With
        End With
    End Sub

    Public Sub EnviarComprobante(ByVal correo As String, ByVal fechaComprobante As Date, ByVal idCFDSerie As Integer, ByVal folio As Integer, UUID As String, ByVal idSucursal As Integer, Mensaje As String, IdRemitente As Integer)
        Try
            Dim ComprobanteSvc As New ComprobanteFiscalService(SessionID, Connection, Transaction)
            Dim Comprobante As ComprobanteFiscalInfo = ComprobanteSvc.Load(fechaComprobante, idCFDSerie, folio, UUID)
            ''Obtener información de la unidad de negocios
            'Dim UnidadNegocioSvc As New UnidadNegocioService(SessionID, Connection, Transaction)
            'Dim UnidadNegocio As UnidadNegocioInfo = UnidadNegocioSvc.GetDetailFromCacheByIdSucursal(idSucursal)
            'Dim Idremitente as integer=UnidadNegocio.IdRemitente
            Dim RemitenteSvc As New Azteca.Kernel.Mail.RemitenteService(SessionID, Connection, Transaction)
            'Cargar información del remitente
            Dim Remitente As New Azteca.Kernel.Mail.RemitenteInfo(SessionID)
            RemitenteSvc.GetDetail(IdRemitente, Remitente, False)
            'Crear mensaje de email y adjuntar xml y pdf
            Dim Email As New Chilkat.Email
            Dim Success As Boolean = Email.AddTo(String.Empty, correo)
            If Not Success Then Throw New BusinessException("Error al establecer el destinatario de correo. " & Email.LastErrorText)
            Email.Subject = "Factura Electrónica " & Comprobante.Serie.Trim & Comprobante.Folio.ToString
            Email.Body = Mensaje
            'Obtener xml y pdf del comprobante fiscal
            Dim xml As String = ComprobanteSvc.LoadXML(Comprobante.IdSerie, Comprobante.Folio, Comprobante.UUID)
            Dim pdf As Byte() = GenerarNotaPDF(idSucursal, Comprobante)
            Email.AddStringAttachment(Comprobante.Serie.Trim & Comprobante.Folio.ToString & ".xml", xml)
            Email.AddDataAttachment2(Comprobante.Serie.Trim & Comprobante.Folio.ToString & ".pdf", pdf, "PDF")
            RemitenteSvc.SendMail(Remitente, Email)
        Catch ex As Exception
            Throw New BusinessException("Error al enviar la factura por correo electrónico.", ex)
        End Try
    End Sub

    Private Function GenerarNotaPDF(idSucursal As Integer, comprobante As ComprobanteFiscalInfo) As Byte()
        Try
            Dim SucursalConfSvc As New SucursalConfigService(SessionID, Me.Connection, Me.Transaction)
            Dim SucursalConf As SucursalConfigInfo = SucursalConfSvc.CargarConfiguracion(idSucursal)

            Dim SucursalSvc As New SucursalService(SessionID, Me.Connection, Me.Transaction)
            Dim Sucursal As New SucursalInfo(Me.Session.SessionID)
            SucursalSvc.GetDetail(idSucursal, Sucursal, False)

            'Cargar información de la empresa
            Dim EmpresaSvc As New EmpresaService(SessionID, Connection, Transaction)
            Dim Empresa As EmpresaInfo = EmpresaSvc.GetDetailFromCache(Sucursal.IdEmpresa)

            'Cargar información de la Nota
            Dim ComprobanteSvc As New ComprobanteFiscalService(SessionID, Connection, Transaction)
            Dim dtComprobante As InformesDS.ComprobantesFiscalesDataTable = ComprobanteSvc.LoadPrintInfo(comprobante.IdSerie, comprobante.Folio, comprobante.UUID)

            'Cargar información del logo y el QR            
            Dim Imagenes As New Azteca.Business.Contabilidad.InformesDS.ImagenesDataTable
            Dim dr As Azteca.Business.Contabilidad.InformesDS.ImagenesRow = Imagenes.NewImagenesRow
            dr.Logo = Empresa.Logo
            dr.QrCode = comprobante.QrCode
            Imagenes.AddImagenesRow(dr)
            'Cargar formato de factura asignado a la sucursal
            Dim Report As New LocalReport()
            Dim FormatMgr As New Azteca.Kernel.General.FormatManager

            Dim FormatoFactura As String = ""
            If comprobante.TipoDocumento = TipoCFD.NotaCargo Then
                FormatoFactura = FormatMgr.LoadFormatFromCache(SessionID, SucursalConf.IdFormatoNotasCargo)
            Else
                FormatoFactura = FormatMgr.LoadFormatFromCache(SessionID, SucursalConf.IdFormatoNotasCredito)
            End If

            Dim Reader As New System.IO.StringReader(FormatoFactura)
            Report.LoadReportDefinition(Reader)
            '
            Report.DataSources.Add(New ReportDataSource("Imagenes", CType(Imagenes, DataTable)))
            Report.DataSources.Add(New ReportDataSource("Comprobantes", CType(dtComprobante, DataTable)))
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
            Throw New BusinessException("Error al descargar la Nota en formato PDF desde el servidor de informes.", ex)
        End Try
    End Function
#End Region

#Region "Generales"
    Public Function LoadList(ByVal FechaIni As Date, ByVal FechaFin As Date, ByVal IdUsuario As Integer, ByVal IdSucursal As Integer) As DataTable
        Dim dtList As DataTable = Nothing
        Try
            Dim fxList As New FunctionSQL("Accounting", "fxNotasList", Connection, Transaction)
            fxList.Parameters.Add("@FechaIni", DbType.DateTime).Value = FechaIni
            fxList.Parameters.Add("@FechaFin", DbType.DateTime).Value = FechaFin
            fxList.Parameters.Add("@IdUsuario", DbType.Int32).Value = IdUsuario
            fxList.Parameters.Add("@IdSucursal", DbType.Int32).Value = IdSucursal
            dtList = fxList.GetTable
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Notas.", ex)
        End Try
        Return dtList
    End Function
#End Region

End Class
