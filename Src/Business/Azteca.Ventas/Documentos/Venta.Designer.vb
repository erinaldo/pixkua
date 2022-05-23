Imports Azteca.Business.Contabilidad

''' <summary>
''' Paquete de información que representa un Venta
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class VentaInfo
	Inherits DocumentInfo
	
#Region "Variables Privadas"
    Friend _Divisa As String
    Friend _TotalCantidad As Decimal
    Friend _SubTotal As Decimal
    Friend _TotalImpuestosTras As Decimal
    Friend _TotalImpuestosRet As Decimal
    Friend _TotalDescuentos As Decimal
    Friend _TotalFlete As Decimal
    Friend _TotalComision As Decimal
    Friend _Total As Decimal
    Friend _TotalIVA As Decimal
    Friend _TotalIEPS As Decimal
    Friend _FechaPago As Date
    Friend _IdSerie As Integer
    Friend _SerieFactura As String = String.Empty
    Friend _FolioFactura As Integer
    Friend _UUIDFactura As String
    Friend _FechaFactura As Date
    Friend _IdListaPrecio As Integer
    Friend _Pagado As Boolean
    Friend _Facturado As Boolean    
    Friend _IdSalida As String

    Private _Servicios As DetalleVentaDS.ServiciosDataTable
    Private _Articulos As DetalleVentaDS.ArticulosDataTable
#End Region

#Region "Propiedades"

    Public Property Hora As Date

    Public Property IdReferencia As String = String.Empty

    Public Property IdCliente As Integer

    Public Property IdVendedor As Integer

    Public Property IdTerminal As Integer

    Public Property IdCaja As Integer

    Public Property CondicionesPago As CondicionesPago

    Friend Loading As Boolean = False

    Public Property IdAlmacen As Integer

    Public Property AutoCalcularTotales As Boolean = True

    Public Property FolioFacturaExt As String

    Public Property IdOrdenTrabajo As Integer

    Public ReadOnly Property IdSalida As String
        Get
            Return _IdSalida
        End Get
    End Property

    Public ReadOnly Property FechaPago As Date
        Get
            Return _FechaPago
        End Get
    End Property

    Public ReadOnly Property Pagado As Boolean
        Get
            Return _Pagado
        End Get
    End Property

    Public ReadOnly Property IdSerie As Integer
        Get
            Return _IdSerie
        End Get
    End Property

    Public ReadOnly Property SerieFactura As String
        Get
            Return _SerieFactura
        End Get
    End Property

    Public ReadOnly Property FolioFactura As Integer
        Get
            Return _FolioFactura
        End Get
    End Property

    Public ReadOnly Property UUIDFactura As String
        Get
            Return _UUIDFactura
        End Get
    End Property

    Public ReadOnly Property FechaFactura As Date
        Get
            Return _FechaFactura
        End Get
    End Property

    Public ReadOnly Property Facturado As Boolean
        Get
            Return _Facturado
        End Get
    End Property

    Public ReadOnly Property IdListaPrecio As Integer
        Get
            Return _IdListaPrecio
        End Get
    End Property

    Public Property Origen As OrigenVenta

    Public Property Observaciones As String = String.Empty

    Public Property OrdenCompra As String = String.Empty

    Public ReadOnly Property TotalCantidad As Decimal
        Get
            Return _TotalCantidad
        End Get
    End Property

    Public Property IdDivisa As Integer

    Public ReadOnly Property Divisa As String
        Get
            Return _Divisa
        End Get
    End Property

    Public Property TipoCambio As Decimal

    Public ReadOnly Property SubTotal As Decimal
        Get
            Return _SubTotal
        End Get
    End Property

    Public ReadOnly Property TotalImpuestosTrasladados As Decimal
        Get
            Return _TotalImpuestosTras
        End Get
    End Property

    Public ReadOnly Property TotalImpuestosRetenidos As Decimal
        Get
            Return _TotalImpuestosRet
        End Get
    End Property

    Public ReadOnly Property TotalDescuentos As Decimal
        Get
            Return _TotalDescuentos
        End Get
    End Property

    Public ReadOnly Property TotalFlete As Decimal
        Get
            Return _TotalFlete
        End Get
    End Property

    Public ReadOnly Property TotalComision As Decimal
        Get
            Return _TotalComision
        End Get
    End Property

    Public ReadOnly Property Total As Decimal
        Get
            Return _Total
        End Get
    End Property

    Public ReadOnly Property TotalIVA As Decimal
        Get
            Return _TotalIVA
        End Get
    End Property

    Public ReadOnly Property TotalIEPS As Decimal
        Get
            Return _TotalIEPS
        End Get
    End Property

    Public ReadOnly Property Servicios As DetalleVentaDS.ServiciosDataTable
        Get
            Return _Servicios
        End Get
    End Property

    Public ReadOnly Property Articulos As DetalleVentaDS.ArticulosDataTable
        Get
            Return _Articulos
        End Get
    End Property

#End Region

#Region "Constructor"

    Public Sub New(ByVal sessionID As Guid)
        MyBase.New(sessionID)
        _Servicios = New DetalleVentaDS.ServiciosDataTable
        _Articulos = New DetalleVentaDS.ArticulosDataTable
    End Sub

#End Region

#Region "Metodos"

    Public Sub CalcularTotales(PoliticaDescuento As PoliticaDescuento)
        '
        If Not Me.AutoCalcularTotales Then Exit Sub

        With Me

            ''Servicios
            Dim TotalesServicios = Aggregate D In Me.Servicios
                          Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached
                          Into TotalCantidad = Sum(D.Cantidad), SubTotal = Sum(D.Cantidad * D.PrecioUnitario),
                            TotalDescuentos = Sum((D.MontoDesc1 + D.MontoDesc2 + D.MontoDesc3) * D.Cantidad),
                            TotalComision = Sum(D.MontoComision * D.Cantidad)
            ''Articulos
            Dim TotalesArticulos = Aggregate D In Me.Articulos
                  Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached
                  Into TotalCantidad = Sum(D.Cantidad), SubTotal = Sum(D.Cantidad * D.PrecioUnitario),
                  TotalDescuentos = Sum((D.MontoDesc1 + D.MontoDesc2 + D.MontoDesc3 + D.MontoDesc4 + D.MontoDesc5) * D.Cantidad),
                  TotalComision = Sum(D.MontoComision * D.Cantidad)



            'Para calcular impuestos debemos considerar si ya estan incluidos los descuentos antes o despues de calcularlos
            If PoliticaDescuento = Ventas.PoliticaDescuento.AntesImpuestos Then

                Dim Impuesto1Servicios = From D In Me.Servicios
                                Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpTras1 > 0
                                Group By Porcentaje = D.PorcImpTras1
                                Into Group, SubTotal = Sum((D.PrecioUnitario - D.MontoDesc1 - D.MontoDesc2 - D.MontoDesc3) * D.Cantidad)

                Dim Impuesto2Servicios = From D In Me.Servicios
                               Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpTras2 > 0
                               Group By Porcentaje = D.PorcImpTras2
                               Into Group, SubTotal = Sum((D.PrecioUnitario - D.MontoDesc1 - D.MontoDesc2 - D.MontoDesc3) * D.Cantidad)

                Dim Retencion1Servicios = From D In Me.Servicios
                                 Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpRet1 > 0
                                 Group By Porcentaje = D.PorcImpRet1
                                 Into Group, SubTotal = Sum((D.PrecioUnitario - D.MontoDesc1 - D.MontoDesc2 - D.MontoDesc3) * D.Cantidad)
                Dim Retencion2Servicios = From D In Me.Servicios
                                 Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpRet2 > 0
                                 Group By Porcentaje = D.PorcImpRet2
                                 Into Group, SubTotal = Sum((D.PrecioUnitario - D.MontoDesc1 - D.MontoDesc2 - D.MontoDesc3) * D.Cantidad)

                Dim Impuesto1Articulos = From D In Me.Articulos
                                Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpTras1 > 0
                                Group By Porcentaje = D.PorcImpTras1
                                Into Group, SubTotal = Sum((D.PrecioUnitario - D.MontoDesc1 - D.MontoDesc2 - D.MontoDesc3) * D.Cantidad)
                Dim Impuesto2Articulos = From D In Me.Articulos
                                Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpTras2 > 0
                                Group By Porcentaje = D.PorcImpTras2
                                Into Group, SubTotal = Sum((D.PrecioUnitario - D.MontoDesc1 - D.MontoDesc2 - D.MontoDesc3) * D.Cantidad)

                Dim Retencion1Articulos = From D In Me.Articulos
                                 Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpRet1 > 0
                                 Group By Porcentaje = D.PorcImpRet1
                                 Into Group, SubTotal = Sum((D.PrecioUnitario - D.MontoDesc1 - D.MontoDesc2 - D.MontoDesc3) * D.Cantidad)
                Dim Retencion2Articulos = From D In Me.Articulos
                                                Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpRet2 > 0
                                                Group By Porcentaje = D.PorcImpRet2
                                                Into Group, SubTotal = Sum((D.PrecioUnitario - D.MontoDesc1 - D.MontoDesc2 - D.MontoDesc3) * D.Cantidad)

                ''Impuestos trasladados
                ._TotalImpuestosTras = 0D
                For Each Tasa In Impuesto1Servicios
                    ._TotalImpuestosTras += (Tasa.SubTotal * Tasa.Porcentaje)
                Next
                For Each Tasa In Impuesto2Servicios
                    ._TotalImpuestosTras += (Tasa.SubTotal * Tasa.Porcentaje)
                Next

                For Each Tasa In Impuesto1Articulos
                    ._TotalImpuestosTras += (Tasa.SubTotal * Tasa.Porcentaje)
                Next
                For Each Tasa In Impuesto2Articulos
                    ._TotalImpuestosTras += (Tasa.SubTotal * Tasa.Porcentaje)
                Next
                ._TotalIVA = ._TotalImpuestosTras

                ''Impuestos retenidos
                ._TotalImpuestosRet = 0
                For Each Tasa In Retencion1Servicios
                    ._TotalImpuestosRet += (Tasa.SubTotal * Tasa.Porcentaje)
                Next
                For Each Tasa In Retencion2Servicios
                    ._TotalImpuestosRet += (Tasa.SubTotal * Tasa.Porcentaje)
                Next
                For Each Tasa In Retencion1Articulos
                    ._TotalImpuestosRet += (Tasa.SubTotal * Tasa.Porcentaje)
                Next
                For Each Tasa In Retencion2Articulos
                    ._TotalImpuestosRet += (Tasa.SubTotal * Tasa.Porcentaje)
                Next
            ElseIf PoliticaDescuento = Ventas.PoliticaDescuento.DespuesImpuestos Then

                Dim Impuesto1Servicios = From D In Me.Servicios
                               Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpTras1 > 0
                               Group By Porcentaje = D.PorcImpTras1
                               Into Group, SubTotal = Sum((D.PrecioUnitario) * D.Cantidad)

                Dim Impuesto2Servicios = From D In Me.Servicios
                               Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpTras2 > 0
                               Group By Porcentaje = D.PorcImpTras2
                               Into Group, SubTotal = Sum((D.PrecioUnitario) * D.Cantidad)

                Dim Retencion1Servicios = From D In Me.Servicios
                                 Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpRet1 > 0
                                 Group By Porcentaje = D.PorcImpRet1
                                 Into Group, SubTotal = Sum((D.PrecioUnitario) * D.Cantidad)

                Dim Retencion2Servicios = From D In Me.Servicios
                                 Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpRet2 > 0
                                 Group By Porcentaje = D.PorcImpRet2
                                 Into Group, SubTotal = Sum((D.PrecioUnitario) * D.Cantidad)

                Dim Impuesto1Articulos = From D In Me.Articulos
                                Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpTras1 > 0
                                Group By Porcentaje = D.PorcImpTras1
                                Into Group, SubTotal = Sum((D.PrecioUnitario) * D.Cantidad)

                Dim Impuesto2Articulos = From D In Me.Articulos
                                Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpTras2 > 0
                                Group By Porcentaje = D.PorcImpTras2
                                Into Group, SubTotal = Sum((D.PrecioUnitario) * D.Cantidad)

                Dim Retencion1Articulos = From D In Me.Articulos
                                 Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpRet1 > 0
                                 Group By Porcentaje = D.PorcImpRet1
                                 Into Group, SubTotal = Sum((D.PrecioUnitario) * D.Cantidad)
                Dim Retencion2Articulos = From D In Me.Articulos
                                                Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpRet2 > 0
                                                Group By Porcentaje = D.PorcImpRet2
                                                Into Group, SubTotal = Sum((D.PrecioUnitario) * D.Cantidad)

                ''Impuestos trasladados
                ._TotalImpuestosTras = 0D
                For Each Tasa In Impuesto1Servicios
                    ._TotalImpuestosTras += (Tasa.SubTotal * Tasa.Porcentaje)
                Next
                For Each Tasa In Impuesto2Servicios
                    ._TotalImpuestosTras += (Tasa.SubTotal * Tasa.Porcentaje)
                Next
                For Each Tasa In Impuesto1Articulos
                    ._TotalImpuestosTras += (Tasa.SubTotal * Tasa.Porcentaje)
                Next
                For Each Tasa In Impuesto2Articulos
                    ._TotalImpuestosTras += (Tasa.SubTotal * Tasa.Porcentaje)
                Next
                ._TotalIVA = ._TotalImpuestosTras

                ''Impuestos retenidos
                ._TotalImpuestosRet = 0
                For Each Tasa In Retencion1Servicios
                    ._TotalImpuestosRet += (Tasa.SubTotal * Tasa.Porcentaje)
                Next
                For Each Tasa In Retencion2Servicios
                    ._TotalImpuestosRet += (Tasa.SubTotal * Tasa.Porcentaje)
                Next

                For Each Tasa In Retencion1Articulos
                    ._TotalImpuestosRet += (Tasa.SubTotal * Tasa.Porcentaje)
                Next
                For Each Tasa In Retencion2Articulos
                    ._TotalImpuestosRet += (Tasa.SubTotal * Tasa.Porcentaje)
                Next

            End If


            ._TotalCantidad = Decimal.Round(TotalesServicios.TotalCantidad + TotalesArticulos.TotalCantidad, 2)
            ._SubTotal = Decimal.Round(TotalesServicios.SubTotal + TotalesArticulos.SubTotal, 2)
            ._TotalDescuentos = Decimal.Round(TotalesServicios.TotalDescuentos + TotalesArticulos.TotalDescuentos, 2)
            ._TotalComision = Decimal.Round(TotalesServicios.TotalComision + TotalesArticulos.TotalComision, 2)
            ._Total = Decimal.Round(._SubTotal + ._TotalImpuestosTras - ._TotalImpuestosRet - ._TotalDescuentos, 2)
        End With

    End Sub

    Public Sub AsignarPrecio(ByVal drPartida As DataRow, ByVal precio As PrecioInfo)
        With precio
            drPartida("PrecioUnitario") = .Precio
            drPartida("IdDivisa") = .IdDivisa
            drPartida("PorcDescuento1") = .PorcentajeDescuento1
            drPartida("PorcDescuento2") = .PorcentajeDescuento2
            drPartida("PorcDescuento3") = .PorcentajeDescuento3
            drPartida("PorcDescuento4") = .PorcentajeDescuento4
            drPartida("PorcDescuento5") = .PorcentajeDescuento5
            drPartida("MontoDesc1") = .MontoDescuento1
            drPartida("MontoDesc2") = .MontoDescuento2
            drPartida("MontoDesc3") = .MontoDescuento3
            drPartida("MontoDesc4") = .MontoDescuento4
            drPartida("MontoDesc5") = .MontoDescuento5
            drPartida("IdImpuesto1") = .IdImpuesto1
            drPartida("IdImpuesto2") = .IdImpuesto2
            drPartida("IdImpuesto3") = .IdImpuesto3
            drPartida("IdImpuesto4") = .IdImpuesto4
            drPartida("IdImpuesto5") = .IdImpuesto5
            drPartida("PorcImpTras1") = .PorcentajeImpuesto1
            drPartida("PorcImpTras2") = .PorcentajeImpuesto2
            drPartida("PorcImpTras3") = .PorcentajeImpuesto3
            drPartida("PorcImpTras4") = .PorcentajeImpuesto4
            drPartida("PorcImpTras5") = .PorcentajeImpuesto5
            drPartida("MontoImpTras1") = .MontoImpuesto1
            drPartida("MontoImpTras2") = .MontoImpuesto2
            drPartida("MontoImpTras3") = .MontoImpuesto3
            drPartida("MontoImpTras4") = .MontoImpuesto4
            drPartida("MontoImpTras5") = .MontoImpuesto5
            drPartida("PorcImpRet1") = .PorcentajeRetencion1
            drPartida("PorcImpRet2") = .PorcentajeRetencion2
            drPartida("PorcImpRet3") = .PorcentajeRetencion3
            drPartida("PorcImpRet4") = .PorcentajeRetencion4
            drPartida("PorcImpRet5") = .PorcentajeRetencion5
            drPartida("MontoImpRet1") = .MontoRetencion1
            drPartida("MontoImpRet2") = .MontoRetencion2
            drPartida("MontoImpRet3") = .MontoRetencion3
            drPartida("MontoImpRet4") = .MontoRetencion4
            drPartida("MontoImpRet5") = .MontoRetencion5
        End With
    End Sub


#End Region

End Class


''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class VentaService
    Inherits DocumentService(Of VentaInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As Guid)
        Me.New(sessionID, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As Guid, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As Guid, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Sales", "VentasTit", "VentasDet", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub

#End Region

#Region "Metodos de DocumentService"

    Public Overrides Sub ApplyWorkflow(ByVal IdVenta As String, ByVal IdStatus As Integer, ByVal fechaTrabajo As DateTime)
        Dim VentaSvc As New VentaService(SessionID, Connection, Transaction)
        'Cargar información de la venta
        Dim Venta As New VentaInfo(SessionID)
        VentaSvc.GetDetail(IdVenta, Venta)
        'Si el estatus actual es guardado, no se ha aplicado y se desea facturar, aplicar automáticamente
        If Venta.Status = WorkflowSteps.Save And IdStatus = WorkflowSteps.Invoice Then
            Aplicar(IdVenta, fechaTrabajo)
        End If
        '
        If IdStatus = WorkflowSteps.Invoice Then
            If Venta.Status <> WorkflowSteps.Apply Then
                Throw New Exception("La venta no puede ser facturada ya que su estatus actual es [" & Venta.StatusDescription & "]")
            End If
            Venta = New VentaInfo(SessionID)
            VentaSvc.GetDetail(IdVenta, Venta)
            Facturar(Venta)
        End If
        MyBase.ApplyWorkflow(IdVenta, IdStatus, fechaTrabajo)
    End Sub

    Public Overrides Sub CancelWorkflow(ByVal IdVenta As String, ByVal IdStatus As Integer)
        Dim VentaSvc As New VentaService(SessionID, Connection, Transaction)
        'Cargar información de la venta y generar factura
        Dim Venta As New VentaInfo(SessionID)
        VentaSvc.GetDetail(IdVenta, Venta)
        '
        If IdStatus = WorkflowSteps.Invoice Then
            'Cancelar comprobante fiscal asociado a la venta
            Dim ComprobanteSvc As New ComprobanteFiscalService(sessionID, Connection, Transaction)
            ComprobanteSvc.Cancelar(Venta.IdSerie, Venta.FolioFactura, Venta.UUIDFactura)
        End If
        'Determinar el estatus al que se enviará el documento
        Dim WorkflowSvc As New WorkflowServices(SessionID, Connection, Transaction)
        Dim PrevStatus As Integer = WorkflowSvc.GetPreviousStep(Venta.GetDocumentType, IdStatus)
        'Si el estatus terminará como cancelado, cancelar movimiento de almacén en caso de existir
        If (PrevStatus = WorkflowSteps.Cancel Or PrevStatus = WorkflowSteps.Save) And Venta.IdSalida.Trim <> String.Empty Then
            Dim MovimientoSvc As New Azteca.Business.Inventario.MovimientoService(SessionID, Connection, Transaction)
            MovimientoSvc.CancelWorkflow(Venta.IdSalida, WorkflowSteps.Apply)
        End If
        '
        MyBase.CancelWorkflow(IdVenta, IdStatus)
    End Sub

    Public Overrides Function Create() As VentaInfo
        Return New VentaInfo(sessionID)
    End Function


    Public Overrides Sub GetDetail(ByVal idVenta As String, ByRef Venta As VentaInfo)
        MyBase.GetDetail(idVenta, Venta)
        With Venta
            .Hora = CDate(Me.DocInfo("Hora"))
            .IdReferencia = CStr(Me.DocInfo("IdReferencia"))
            .IdCliente = CInt(Me.DocInfo("IdCliente"))
            .IdVendedor = CInt(Me.DocInfo("IdVendedor"))
            .IdTerminal = CInt(Me.DocInfo("IdTerminal"))
            .IdCaja = CInt(Me.DocInfo("IdCaja"))
            .CondicionesPago = GetCondicionesPago(CStr(Me.DocInfo("CondicionesPago")))
            If DocInfo("FechaPago") Is DBNull.Value Then
                ._Pagado = False
            Else
                ._Pagado = True
                ._FechaPago = CDate(Me.DocInfo("FechaPago"))
            End If
            ._IdSerie = CInt(DocInfo("IdCFDSerie"))
            ._SerieFactura = CStr(Me.DocInfo("SerieFactura")).Trim

            If (Me.DocInfo("FolioFacturaExt") Is DBNull.Value) Then
                .FolioFacturaExt = ""
            Else
                .FolioFacturaExt = CStr(Me.DocInfo("FolioFacturaExt"))
            End If

            ._FolioFactura = CInt(Me.DocInfo("FolioFactura"))
            ._UUIDFactura = DocInfo("UUIDFactura").ToString
            If DocInfo("FechaFactura") Is DBNull.Value Then
                ._Facturado = False
            Else
                ._Facturado = True
                ._FechaFactura = CDate(Me.DocInfo("FechaFactura"))
            End If
            ._IdListaPrecio = CInt(Me.DocInfo("IdListaPrecio"))
            .Observaciones = CStr(Me.DocInfo("Observaciones"))
            .OrdenCompra = CStr(Me.DocInfo("OrdenCompra"))

            If (Me.DocInfo("IdOrdenTrabajo") Is DBNull.Value) Then
                .IdOrdenTrabajo = 0
            Else
                .IdOrdenTrabajo = CInt(Me.DocInfo("IdOrdenTrabajo"))
            End If

            ._TotalCantidad = CDec(Me.DocInfo("TotalCantidad"))
            .IdDivisa = CInt(DocInfo("IdDivisa"))
            ._Divisa = DocInfo("Divisa").ToString
            .TipoCambio = CDec(DocInfo("TipoCambio"))
            ._SubTotal = CDec(Me.DocInfo("SubTotal"))
            ._TotalImpuestosTras = CDec(Me.DocInfo("TotalImpuestosTras"))
            ._TotalImpuestosRet = CDec(Me.DocInfo("TotalImpuestosRet"))
            ._TotalDescuentos = CDec(Me.DocInfo("TotalDescuentos"))
            ._TotalFlete = CDec(Me.DocInfo("TotalFlete"))
            ._TotalComision = CDec(Me.DocInfo("TotalComision"))
            ._Total = CDec(Me.DocInfo("Total"))
            ._TotalIVA = CDec(Me.DocInfo("TotalIVA"))
            ._TotalIEPS = CDec(Me.DocInfo("TotalIEPS"))
            .Origen = GetOrigen(CStr(Me.DocInfo("Origen")))
            ._IdSalida = DocInfo("IdSalida").ToString
            .IdAlmacen = CInt(DocInfo("IdAlmacen"))
            '
        End With
    End Sub

    Public Overrides Function Update(ByVal Venta As VentaInfo) As VentaInfo
        Validate(Venta)
        Dim unidadNegSvc As New UnidadNegocioService(Me.SessionID, Me.Connection, Me.Transaction)
        Dim UnidadNeg As UnidadNegocioInfo = unidadNegSvc.GetDetailFromCacheByIdSucursal(Venta.IdSucursal)
        Venta.CalcularTotales(UnidadNeg.PoliticaDescuento)

        With Me.SPUpdate.Parameters
            .Add("@Hora", DbType.DateTime).Value = Venta.Hora
            .Add("@IdReferencia", DbType.String).Value = Venta.IdReferencia
            .Add("@IdCliente", DbType.Int32).Value = Venta.IdCliente
            .Add("@IdVendedor", DbType.Int32).Value = Venta.IdVendedor
            .Add("@IdTerminal", DbType.Int32).Value = Venta.IdTerminal
            .Add("@IdCaja", DbType.Int32).Value = Venta.IdCaja
            .Add("@CondicionesPago", DbType.String).Value = GetCondicionesPago(Venta.CondicionesPago)
            .Add("@Observaciones", DbType.String).Value = Venta.Observaciones
            .Add("@OrdenCompra", DbType.String).Value = Venta.OrdenCompra
            .Add("@FolioFacturaExt", DbType.String).Value = Venta.FolioFacturaExt
            .Add("@IdOrdenTrabajo", DbType.Int32).Value = Venta.IdOrdenTrabajo
            .Add("@Origen", DbType.String).Value = GetOrigen(Venta.Origen)
            .Add("@TotalCantidad", DbType.Decimal).Value = Venta.TotalCantidad
            .Add("@IdDivisa", DbType.Int32).Value = Venta.IdDivisa
            .Add("@TipoCambio", DbType.Decimal).Value = Venta.TipoCambio
            .Add("@SubTotal", DbType.Decimal).Value = Venta.SubTotal
            .Add("@TotalImpuestosTras", DbType.Decimal).Value = Venta.TotalImpuestosTrasladados
            .Add("@TotalImpuestosRet", DbType.Decimal).Value = Venta.TotalImpuestosRetenidos
            .Add("@TotalDescuentos", DbType.Decimal).Value = Venta.TotalDescuentos
            .Add("@TotalFlete", DbType.Decimal).Value = Venta.TotalFlete
            .Add("@TotalComision", DbType.Decimal).Value = Venta.TotalComision
            .Add("@Total", DbType.Decimal).Value = Venta.Total
            .Add("@TotalIVA", DbType.Decimal).Value = Venta.TotalIVA
            .Add("@TotalIEPS", DbType.Decimal).Value = Venta.TotalIEPS
            .Add("@IdAlmacen", DbType.Int32).Value = Venta.IdAlmacen
        End With
        Return MyBase.Update(Venta)
    End Function

#End Region

#Region "Metidos Privados"

    Private Sub Validate(ByVal venta As VentaInfo)
        Dim DivisaSvc As New DivisaService(sessionID, Connection, Transaction)
        'Verificar que se haya capturado por lo menos un artículo o un servicio
        If venta.Servicios.Count = 0 And venta.Articulos.Count = 0 Then
            Throw New BusinessException("El documento debe contener por lo menos un servicio o un artículo.")
        End If

        Dim vwDivisasServ As New DataView(venta.Servicios, "IdDivisa <> " & venta.IdDivisa, String.Empty, DataViewRowState.CurrentRows)
        Dim vwDivisasArt As New DataView(venta.Articulos, "IdDivisa <> " & venta.IdDivisa, String.Empty, DataViewRowState.CurrentRows)

        If vwDivisasServ.Count > 1 Or vwDivisasArt.Count > 1 Then
            Throw New BusinessException("No se pueden combinar servicios o artículos con diferente divisa a la del documento.")
        End If

        venta.TipoCambio = DivisaSvc.GetTipoCambioActual(venta.IdDivisa)
    End Sub

    Private Sub ValidarCorte(ByVal idCaja As Integer)
        'Obtener el corte actual
        Dim Caja As New CajaService(SessionID, Connection, Transaction)
        Dim IdCorte As Guid = Caja.GetCorteActual(idCaja)
        If IdCorte = Guid.Empty Then
            Throw New BusinessException("No se puede guardar la venta por que la caja a la que pertenece no está abierta.")
        End If
    End Sub

    Protected Overrides Sub GetDocumentDetail(ByVal document As VentaInfo)
        Try
            Dim Venta As VentaInfo = CType(document, VentaInfo)
            'Cargar servicios
            Dim fxServicios As New FunctionSQL("Sales", "fxVentasServiciosSEL", Connection, Transaction)
            fxServicios.Parameters.Add("@IdVentaTit", DbType.String).Value = Venta.Identity
            fxServicios.Parameters.Add("@IdUsuario", DbType.Int32).Value = Session.User.Identity
            fxServicios.FillDataTable(Venta.Servicios)
            'Cargar artículos
            Dim fxArticulos As New FunctionSQL("Sales", "fxVentasArticulosSEL", Connection, Transaction)
            fxArticulos.Parameters.Add("@IdVentaTit", DbType.String).Value = Venta.Identity
            fxArticulos.Parameters.Add("@IdUsuario", DbType.Int32).Value = Session.User.Identity
            fxArticulos.FillDataTable(Venta.Articulos)
            '
        Catch ex As Exception
            Throw New BusinessException("Error al cargar las partidas de la venta.", ex)
        End Try
    End Sub

    Protected Overrides Sub UpdateDocumentDetail(ByVal document As VentaInfo)
        Try
            Dim Venta As VentaInfo = CType(document, VentaInfo)
            Dim comDeleteServicios As New DbCommand("Sales.VentasServiciosDEL", Connection, Transaction)
            With comDeleteServicios
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@IdVentaTit", DbType.String).Value = document.Identity
                .Parameters.Add("@IdServicio", DbType.Int32, "IdServicio")
                .Parameters.Add("@IdVentaDet", DbType.Int32, "IdVentaDet")
            End With
            '
            Dim comUpdateServicios As New DbCommand("Sales.VentasServiciosUPD", Connection, Transaction)
            With comUpdateServicios
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@IdVentaDet", DbType.Int32, "IdVentaDet")
                .Parameters("@IdVentaDet").Direction = ParameterDirection.InputOutput
                .Parameters.Add("@IdVentaTit", DbType.String).Value = Venta.Identity
                .Parameters.Add("@IdServicio", DbType.Int32, "IdServicio")
                .Parameters.Add("@IdArticuloStock", DbType.Int32).Value = 0
                .Parameters.Add("@Codigo", DbType.String, "Codigo")
                .Parameters.Add("@Descripcion", DbType.String, "Descripcion")
                .Parameters.Add("@Cantidad", DbType.Int32, "Cantidad")
                .Parameters.Add("@PrecioUnitario", DbType.Decimal, "PrecioUnitario")
                .Parameters.Add("@IdPromocion", DbType.Int32, "IdPromocion")
                .Parameters.Add("@PorcComision", DbType.Decimal, "PorcComision")
                .Parameters.Add("@MontoComision", DbType.Decimal, "MontoComision")
                .Parameters.Add("@PorcDescuento1", DbType.Decimal, "PorcDescuento1")
                .Parameters.Add("@PorcDescuento2", DbType.Decimal, "PorcDescuento2")
                .Parameters.Add("@PorcDescuento3", DbType.Decimal, "PorcDescuento3")
                .Parameters.Add("@PorcDescuento4", DbType.Decimal, "PorcDescuento4")
                .Parameters.Add("@PorcDescuento5", DbType.Decimal, "PorcDescuento5")
                .Parameters.Add("@MontoDesc1", DbType.Decimal, "MontoDesc1")
                .Parameters.Add("@MontoDesc2", DbType.Decimal, "MontoDesc2")
                .Parameters.Add("@MontoDesc3", DbType.Decimal, "MontoDesc3")
                .Parameters.Add("@MontoDesc4", DbType.Decimal, "MontoDesc4")
                .Parameters.Add("@MontoDesc5", DbType.Decimal, "MontoDesc5")
                .Parameters.Add("@IdImpuesto1", DbType.Int32, "IdImpuesto1")
                .Parameters.Add("@IdImpuesto2", DbType.Int32, "IdImpuesto2")
                .Parameters.Add("@IdImpuesto3", DbType.Int32, "IdImpuesto3")
                .Parameters.Add("@IdImpuesto4", DbType.Int32, "IdImpuesto4")
                .Parameters.Add("@IdImpuesto5", DbType.Int32, "IdImpuesto5")
                .Parameters.Add("@PorcImpTras1", DbType.Decimal, "PorcImpTras1")
                .Parameters.Add("@PorcImpTras2", DbType.Decimal, "PorcImpTras2")
                .Parameters.Add("@PorcImpTras3", DbType.Decimal, "PorcImpTras3")
                .Parameters.Add("@PorcImpTras4", DbType.Decimal, "PorcImpTras4")
                .Parameters.Add("@PorcImpTras5", DbType.Decimal, "PorcImpTras5")
                .Parameters.Add("@MontoImpTras1", DbType.Decimal, "MontoImpTras1")
                .Parameters.Add("@MontoImpTras2", DbType.Decimal, "MontoImpTras2")
                .Parameters.Add("@MontoImpTras3", DbType.Decimal, "MontoImpTras3")
                .Parameters.Add("@MontoImpTras4", DbType.Decimal, "MontoImpTras4")
                .Parameters.Add("@MontoImpTras5", DbType.Decimal, "MontoImpTras5")
                .Parameters.Add("@IdRetencion1", DbType.Int32, "IdRetencion1")
                .Parameters.Add("@IdRetencion2", DbType.Int32, "IdRetencion2")
                .Parameters.Add("@IdRetencion3", DbType.Int32, "IdRetencion3")
                .Parameters.Add("@IdRetencion4", DbType.Int32, "IdRetencion4")
                .Parameters.Add("@IdRetencion5", DbType.Int32, "IdRetencion5")
                .Parameters.Add("@PorcImpRet1", DbType.Decimal, "PorcImpRet1")
                .Parameters.Add("@PorcImpRet2", DbType.Decimal, "PorcImpRet2")
                .Parameters.Add("@PorcImpRet3", DbType.Decimal, "PorcImpRet3")
                .Parameters.Add("@PorcImpRet4", DbType.Decimal, "PorcImpRet4")
                .Parameters.Add("@PorcImpRet5", DbType.Decimal, "PorcImpRet5")
                .Parameters.Add("@MontoImpRet1", DbType.Decimal, "MontoImpRet1")
                .Parameters.Add("@MontoImpRet2", DbType.Decimal, "MontoImpRet2")
                .Parameters.Add("@MontoImpRet3", DbType.Decimal, "MontoImpRet3")
                .Parameters.Add("@MontoImpRet4", DbType.Decimal, "MontoImpRet4")
                .Parameters.Add("@MontoImpRet5", DbType.Decimal, "MontoImpRet5")
                .Parameters.Add("@NumPedimento", DbType.String, "NumPedimento")
                .Parameters.Add("@FechaPedimento", DbType.DateTime, "FechaPedimento")
                .Parameters.Add("@Aduana", DbType.String, "Aduana")
            End With
            'Definir adaptador
            Dim daServicios As New DataAdapter()
            daServicios.DeleteCommand = comDeleteServicios
            daServicios.UpdateCommand = comUpdateServicios
            daServicios.InsertCommand = comUpdateServicios
            'Ejecutar primero con las filas eliminadas para evitar conflictos con el unique key
            Dim DeletedRows As DataTable = Venta.Servicios.GetChanges(DataRowState.Deleted)
            If DeletedRows IsNot Nothing Then daServicios.Update(DeletedRows)
            Dim vwDeleted As New DataView(Venta.Servicios, String.Empty, String.Empty, DataViewRowState.Deleted)
            For Each drv As DataRowView In vwDeleted
                drv.Row.AcceptChanges()
            Next
            daServicios.Update(Venta.Servicios)
            Venta.Servicios.AcceptChanges()

            '======================================
            'Guardar ahora el detalle de articulos
            '======================================
            Dim comDeleteArticulos As New DbCommand("Sales.VentasArticulosDEL", Connection, Transaction)
            With comDeleteArticulos
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@IdVentaTit", DbType.String).Value = document.Identity
                .Parameters.Add("@IdArticuloStock", DbType.Int32, "IdArticuloStock")
            End With
            '
            Dim comUpdateArticulos As New DbCommand("Sales.VentasArticulosUPD", Connection, Transaction)
            With comUpdateArticulos
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@IdVentaTit", DbType.String).Value = Venta.Identity
                .Parameters.Add("@IdServicio", DbType.Int32).Value = 0
                .Parameters.Add("@IdArticuloStock", DbType.Int32, "IdArticuloStock")
                .Parameters.Add("@Codigo", DbType.String, "Codigo")
                .Parameters.Add("@Descripcion", DbType.String, "Descripcion")
                .Parameters.Add("@Cantidad", DbType.Int32, "Cantidad")
                .Parameters.Add("@IdUnidadMedida", DbType.Int32, "IdUnidadMedida")
                .Parameters.Add("@PrecioUnitario", DbType.Decimal, "PrecioUnitario")
                .Parameters.Add("@IdPromocion", DbType.Int32, "IdPromocion")
                .Parameters.Add("@PorcComision", DbType.Decimal, "PorcComision")
                .Parameters.Add("@MontoComision", DbType.Decimal, "MontoComision")
                .Parameters.Add("@Flete", DbType.Decimal, "Flete")
                .Parameters.Add("@PorcDescuento1", DbType.Decimal, "PorcDescuento1")
                .Parameters.Add("@PorcDescuento2", DbType.Decimal, "PorcDescuento2")
                .Parameters.Add("@PorcDescuento3", DbType.Decimal, "PorcDescuento3")
                .Parameters.Add("@PorcDescuento4", DbType.Decimal, "PorcDescuento4")
                .Parameters.Add("@PorcDescuento5", DbType.Decimal, "PorcDescuento5")
                .Parameters.Add("@MontoDesc1", DbType.Decimal, "MontoDesc1")
                .Parameters.Add("@MontoDesc2", DbType.Decimal, "MontoDesc2")
                .Parameters.Add("@MontoDesc3", DbType.Decimal, "MontoDesc3")
                .Parameters.Add("@MontoDesc4", DbType.Decimal, "MontoDesc4")
                .Parameters.Add("@MontoDesc5", DbType.Decimal, "MontoDesc5")
                .Parameters.Add("@IdImpuesto1", DbType.Int32, "IdImpuesto1")
                .Parameters.Add("@IdImpuesto2", DbType.Int32, "IdImpuesto2")
                .Parameters.Add("@IdImpuesto3", DbType.Int32, "IdImpuesto3")
                .Parameters.Add("@IdImpuesto4", DbType.Int32, "IdImpuesto4")
                .Parameters.Add("@IdImpuesto5", DbType.Int32, "IdImpuesto5")
                .Parameters.Add("@PorcImpTras1", DbType.Decimal, "PorcImpTras1")
                .Parameters.Add("@PorcImpTras2", DbType.Decimal, "PorcImpTras2")
                .Parameters.Add("@PorcImpTras3", DbType.Decimal, "PorcImpTras3")
                .Parameters.Add("@PorcImpTras4", DbType.Decimal, "PorcImpTras4")
                .Parameters.Add("@PorcImpTras5", DbType.Decimal, "PorcImpTras5")
                .Parameters.Add("@MontoImpTras1", DbType.Decimal, "MontoImpTras1")
                .Parameters.Add("@MontoImpTras2", DbType.Decimal, "MontoImpTras2")
                .Parameters.Add("@MontoImpTras3", DbType.Decimal, "MontoImpTras3")
                .Parameters.Add("@MontoImpTras4", DbType.Decimal, "MontoImpTras4")
                .Parameters.Add("@MontoImpTras5", DbType.Decimal, "MontoImpTras5")
                .Parameters.Add("@IdRetencion1", DbType.Int32, "IdRetencion1")
                .Parameters.Add("@IdRetencion2", DbType.Int32, "IdRetencion2")
                .Parameters.Add("@IdRetencion3", DbType.Int32, "IdRetencion3")
                .Parameters.Add("@IdRetencion4", DbType.Int32, "IdRetencion4")
                .Parameters.Add("@IdRetencion5", DbType.Int32, "IdRetencion5")
                .Parameters.Add("@PorcImpRet1", DbType.Decimal, "PorcImpRet1")
                .Parameters.Add("@PorcImpRet2", DbType.Decimal, "PorcImpRet2")
                .Parameters.Add("@PorcImpRet3", DbType.Decimal, "PorcImpRet3")
                .Parameters.Add("@PorcImpRet4", DbType.Decimal, "PorcImpRet4")
                .Parameters.Add("@PorcImpRet5", DbType.Decimal, "PorcImpRet5")
                .Parameters.Add("@MontoImpRet1", DbType.Decimal, "MontoImpRet1")
                .Parameters.Add("@MontoImpRet2", DbType.Decimal, "MontoImpRet2")
                .Parameters.Add("@MontoImpRet3", DbType.Decimal, "MontoImpRet3")
                .Parameters.Add("@MontoImpRet4", DbType.Decimal, "MontoImpRet4")
                .Parameters.Add("@MontoImpRet5", DbType.Decimal, "MontoImpRet5")
                .Parameters.Add("@NumPedimento", DbType.String, "NumPedimento")
                .Parameters.Add("@FechaPedimento", DbType.DateTime, "FechaPedimento")
                .Parameters.Add("@Aduana", DbType.String, "Aduana")
            End With
            Dim daArticulos As New DataAdapter
            daArticulos.DeleteCommand = comDeleteArticulos
            daArticulos.UpdateCommand = comUpdateArticulos
            daArticulos.InsertCommand = comUpdateArticulos
            'Ejecutar primero con las filas eliminadas para evitar conflictos con el unique key
            DeletedRows = Venta.Articulos.GetChanges(DataRowState.Deleted)
            If DeletedRows IsNot Nothing Then daArticulos.Update(DeletedRows)
            vwDeleted = New DataView(Venta.Articulos, String.Empty, String.Empty, DataViewRowState.Deleted)
            For Each drv As DataRowView In vwDeleted
                drv.Row.AcceptChanges()
            Next

            daArticulos.Update(Venta.Articulos)
            Venta.Articulos.AcceptChanges()
        Catch ex As Exception
            Throw New BusinessException("Error al guardar las partidas de la venta.", ex)
        End Try
    End Sub

    Private Function GetCondicionesPago(ByVal tipo As String) As CondicionesPago
        Select Case tipo
            Case "E"
                Return CondicionesPago.Contado
            Case "C"
                Return CondicionesPago.Credito
            Case Else
                Return CondicionesPago.Contado
        End Select
    End Function

    Private Function GetCondicionesPago(ByVal tipo As CondicionesPago) As String
        Select Case tipo
            Case CondicionesPago.Contado
                Return "E"
            Case CondicionesPago.Credito
                Return "C"
            Case Else
                Return "E"
        End Select
    End Function

    Private Function GetOrigen(ByVal origen As String) As OrigenVenta
        Select Case origen
            Case "M"
                Return OrigenVenta.Manual
            Case "P"
                Return OrigenVenta.POS
            Case "H"
                Return OrigenVenta.Movil
            Case "F"
                Return OrigenVenta.FacturaGlobal
            Case Else
                Return OrigenVenta.Manual
        End Select
    End Function

    Private Function GetOrigen(ByVal origen As OrigenVenta) As String
        Select Case origen
            Case OrigenVenta.Manual
                Return "M"
            Case OrigenVenta.POS
                Return "P"
            Case OrigenVenta.Movil
                Return "H"
            Case OrigenVenta.FacturaGlobal
                Return "F"
            Case Else
                Return "M"
        End Select
    End Function


#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del documento de VentasTit
''' </summary>
''' <remarks></remarks>
Public Class VentaFacade
    Inherits DocumentFacade(Of VentaInfo)

#Region "Metodos de DocumentFacade"

    ''' <summary>
    ''' Generar las acciones necesarias para el flujo de trabajo VentaInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Sub ApplyWorkflow(ByVal sessionID As Guid, ByVal IdVenta As String, ByVal IdStatus As Integer, ByVal FechaTrabajo As DateTime)
        Dim VentaSvc As New VentaService(sessionID)
        ApplyWorkflow(VentaSvc, IdVenta, IdStatus, FechaTrabajo)
    End Sub

    ''' <summary>
    ''' Cancelar las acciones de regreso al flujo de trabajo VentaInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Sub CancelWorkflow(ByVal sessionID As Guid, ByVal IdVenta As String, ByVal IdStatus As Integer)
        Dim VentaSvc As New VentaService(sessionID)
        CancelWorkflow(VentaSvc, IdVenta, IdStatus)
    End Sub


    ''' <summary>
    ''' Crea una nueva instancia de un VentaInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As Guid) As VentaInfo
        Dim VentaSvc As New VentaService(sessionID)
        Return VentaSvc.Create()
    End Function

    ''' <summary>
    ''' Actualiza la información de un Venta.
    ''' </summary>
    ''' <param name="Venta">Paquete de información del tipo VentaInfo con la información a actualizar</param>
    ''' <returns>Identificador de Venta, si es nuevo, regresa el .</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Venta As VentaInfo) As VentaInfo
        Dim VentaSvc As New VentaService(Venta.SessionID)
        Return Update(VentaSvc, CType(Venta, VentaInfo))
    End Function


    ''' <summary>
    ''' Elimina un elemento del documento de VentasTit
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idVenta">Identificador del Venta que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As Guid, ByVal idVenta As String)
        Dim VentaSvc As New VentaService(sessionID)
        Delete(VentaSvc, idVenta)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Venta con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idVenta">ID de Venta que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As Guid, ByVal idVenta As String) As Boolean
        Dim VentaSvc As New VentaService(sessionID)
        Return Exists(VentaSvc, idVenta)
    End Function


    ''' <summary>
    ''' Obtiene la información de un Venta.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idVenta">Identificador de Venta a consultar</param>
    ''' <returns>Paquete de información de tipo VentaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As Guid, ByVal idVenta As String) As VentaInfo
        Return Me.GetDetail(sessionID, idVenta, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Venta.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idVenta">Identificador de Venta</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Venta.</param>
    ''' <returns>Paquete de información de tipo VentaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As Guid, ByVal idVenta As String, ByVal checkStatus As Boolean) As VentaInfo
        Dim VentaSvc As New VentaService(sessionID)
        Dim VentaInf As New VentaInfo(sessionID)
        GetDetail(VentaSvc, VentaInf, idVenta)
        Return VentaInf
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim VentaSvc As New VentaService(sessionID)
        Return GetNumberOfPages(VentaSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca VentasTit que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Dim VentaSvc As New VentaService(sessionID)
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca VentasTit que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim VentaSvc As New VentaService(sessionID)
        Return GetSearchResult(VentaSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de VentasTit.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As Guid) As System.Data.DataSet
        Dim VentaSvc As New VentaService(sessionID)
        Return GetSearchStructure(VentaSvc)
    End Function

#End Region

End Class
