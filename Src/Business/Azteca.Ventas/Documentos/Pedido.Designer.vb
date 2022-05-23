Imports Azteca.Business.Contabilidad

''' <summary>
''' Paquete de información que representa un Pedido
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class PedidoInfo
	Inherits DocumentInfo
	
#Region "Variables Privadas"
    Friend _Divisa As String
    Friend _TotalCantidad As Decimal
    Friend _TotalSaldo As Decimal
    Friend _SubTotal As Decimal
    Friend _TotalImpuestosTras As Decimal
    Friend _TotalImpuestosRet As Decimal
    Friend _TotalDescuentos As Decimal
    Friend _TotalFlete As Decimal
    Friend _TotalComision As Decimal
    Friend _Total As Decimal
    Friend _TotalIVA As Decimal
    Friend _TotalIEPS As Decimal
    Friend _IdListaPrecio As Integer
    Friend _Cerrado As Boolean


    Private _Articulos As DetallePedidoDS.ArticulosDataTable
    Private _Servicios As DetallePedidoDS.ServiciosDataTable
#End Region

#Region "Propiedades"

    Public Property Hora As Date

    Public Property IdPedidoTipo As Integer

    Public Property IdCliente As Integer

    Public Property IdVendedor As Integer

    Public Property IdAlmacen As Integer

    Public Property FechaEmbarque As Date

    Public Property FechaEntrega As Date

    Public Property CalleEntrega As String

    Public Property Cruce1Entrega As String

    Public Property Cruce2Entrega As String

    Public Property NumExtEntrega As String

    Public Property NumIntEntrega As String

    Public Property ColoniaEntrega As String

    Public Property CPEntrega As String

    Public Property IdPoblacionEntrega As Integer

    Public ReadOnly Property IdListaPrecio As Integer
        Get
            Return _IdListaPrecio
        End Get
    End Property

    Public Property OrdenCompra As String

    Public Property IdReferencia As String

    Public Property Observaciones As String

    Public ReadOnly Property Divisa As String
        Get
            Return _Divisa
        End Get
    End Property

    Public ReadOnly Property TotalCantidad As Decimal
        Get
            Return _TotalCantidad
        End Get
    End Property

    Public ReadOnly Property TotalSaldo As Decimal
        Get
            Return _TotalSaldo
        End Get
    End Property

    Public Property IdDivisa As Integer

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

    Public ReadOnly Property Servicios As DetallePedidoDS.ServiciosDataTable
        Get
            Return _Servicios
        End Get
    End Property

    Public ReadOnly Property Articulos As DetallePedidoDS.ArticulosDataTable
        Get
            Return _Articulos
        End Get
    End Property

#End Region
	
#Region "Constructor"
	Public Sub New(ByVal sessionID As GUID)
		MyBase.New(sessionID)
        _Articulos = New DetallePedidoDS.ArticulosDataTable
        _Servicios = New DetallePedidoDS.ServiciosDataTable
	End Sub
#End Region

#Region "Metodos"

    Public Sub CalcularTotales()
        ''Servicios
        Dim TotalesServicios = Aggregate D In Me.Servicios
                      Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached
                      Into TotalCantidad = Sum(D.Cantidad), SubTotal = Sum(D.Cantidad * D.PrecioUnitario),
                        TotalDescuentos = Sum((D.MontoDesc1 + D.MontoDesc2 + D.MontoDesc3) * D.Cantidad),
                        TotalComision = Sum(D.MontoComision * D.Cantidad)

        Dim Impuesto1Servicios = From D In Me.Servicios
                        Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpTras1 > 0
                        Group By Porcentaje = D.PorcImpTras1
                        Into Group, SubTotal = Sum((D.PrecioUnitario - D.MontoDesc1 - D.MontoDesc2 - D.MontoDesc3) * D.Cantidad)

        Dim Retencion1Servicios = From D In Me.Servicios
                         Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpRet1 > 0
                         Group By Porcentaje = D.PorcImpRet1
                         Into Group, SubTotal = Sum((D.PrecioUnitario - D.MontoDesc1 - D.MontoDesc2 - D.MontoDesc3) * D.Cantidad)
        ''Articulos
        Dim TotalesArticulos = Aggregate D In Me.Articulos
              Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached
              Into TotalCantidad = Sum(D.Cantidad), SubTotal = Sum(D.Cantidad * D.PrecioUnitario),
              TotalDescuentos = Sum((D.MontoDesc1 + D.MontoDesc2 + D.MontoDesc3) * D.Cantidad),
              TotalComision = Sum(D.MontoComision * D.Cantidad)

        Dim Impuesto1Articulos = From D In Me.Articulos
                        Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpTras1 > 0
                        Group By Porcentaje = D.PorcImpTras1
                        Into Group, SubTotal = Sum((D.PrecioUnitario - D.MontoDesc1 - D.MontoDesc2 - D.MontoDesc3) * D.Cantidad)

        Dim Retencion1Articulos = From D In Me.Articulos
                         Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpRet1 > 0
                         Group By Porcentaje = D.PorcImpRet1
                         Into Group, SubTotal = Sum((D.PrecioUnitario - D.MontoDesc1 - D.MontoDesc2 - D.MontoDesc3) * D.Cantidad)


        With Me
            ._TotalCantidad = Decimal.Round(TotalesServicios.TotalCantidad + TotalesArticulos.TotalCantidad, 2)
            ._SubTotal = Decimal.Round(TotalesServicios.SubTotal + TotalesArticulos.SubTotal, 2)
            ._TotalDescuentos = Decimal.Round(TotalesServicios.TotalDescuentos + TotalesArticulos.TotalDescuentos, 2)
            ._TotalComision = Decimal.Round(TotalesServicios.TotalComision + TotalesArticulos.TotalComision, 2)
            ''Impuestos trasladados
            ._TotalImpuestosTras = 0D
            For Each Tasa In Impuesto1Servicios
                ._TotalImpuestosTras += (Tasa.SubTotal * Tasa.Porcentaje)
            Next
            For Each Tasa In Impuesto1Articulos
                ._TotalImpuestosTras += (Tasa.SubTotal * Tasa.Porcentaje)
            Next
            ._TotalIVA = ._TotalImpuestosTras
            ''Impuestos retenidos
            ._TotalImpuestosRet = 0
            For Each Tasa In Retencion1Servicios
                ._TotalImpuestosRet += (Tasa.SubTotal * Tasa.Porcentaje)
            Next
            For Each Tasa In Retencion1Articulos
                ._TotalImpuestosRet += (Tasa.SubTotal * Tasa.Porcentaje)
            Next

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
''' Proveedor de servicios para el manejo del catálogo de PedidosTit
''' </summary>
''' <remarks></remarks>
Public Class PedidoService
	Inherits DocumentService(Of PedidoInfo)
	
#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Sales", "PedidosTit", "PedidosDet", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
    
#End Region

#Region "Metodos de DocumentService"

    Public Overrides Sub ApplyWorkflow(ByVal IdPedido As String, ByVal IdStatus As Integer, ByVal fechaTrabajo As Date)
        MyBase.ApplyWorkflow(IdPedido, IdStatus, fechaTrabajo)
    End Sub

    Public Overrides Sub CancelWorkflow(ByVal IdPedido As String, ByVal IdStatus As Integer)
        MyBase.CancelWorkflow(IdPedido, IdStatus)
    End Sub

	
    Public Overrides Function Create() As PedidoInfo
		Return New PedidoInfo(SessionID)
    End Function


    Public Overrides Sub GetDetail(ByVal idPedido As string, ByRef Pedido As PedidoInfo)
		MyBase.GetDetail(idPedido, Pedido)
        With Pedido
			.Fecha = CDate(DocInfo("Fecha"))
			.Hora = CDate(DocInfo("Hora"))
			.IdPedidoTipo = CInt(DocInfo("IdPedidoTipo"))
			.IdCliente = CInt(DocInfo("IdCliente"))
			.IdVendedor = CInt(DocInfo("IdVendedor"))
			.IdAlmacen = CInt(DocInfo("IdAlmacen"))
			.FechaEmbarque = CDate(DocInfo("FechaEmbarque"))
			.FechaEntrega = CDate(DocInfo("FechaEntrega"))
			.CalleEntrega = CStr(DocInfo("CalleEntrega"))
			.Cruce1Entrega = CStr(DocInfo("Cruce1Entrega"))
			.Cruce2Entrega = CStr(DocInfo("Cruce2Entrega"))
			.NumExtEntrega = CStr(DocInfo("NumExtEntrega"))
			.NumIntEntrega = CStr(DocInfo("NumIntEntrega"))
			.ColoniaEntrega = CStr(DocInfo("ColoniaEntrega"))
			.CPEntrega = CStr(DocInfo("CPEntrega"))
			.IdPoblacionEntrega = CInt(DocInfo("IdPoblacionEntrega"))
            ._IdListaPrecio = CInt(Me.DocInfo("IdListaPrecio"))
            .Observaciones = CStr(Me.DocInfo("Observaciones"))
            .OrdenCompra = CStr(Me.DocInfo("OrdenCompra"))
            ._TotalCantidad = CDec(Me.DocInfo("TotalCantidad"))
            ._TotalSaldo = CDec(Me.DocInfo("TotalSaldo"))
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
        End With
    End Sub
	
    Public Overrides Function Update(ByVal pedido As PedidoInfo) As PedidoInfo
        Validate(pedido)
        pedido.CalcularTotales()
        With Me.SPUpdate.Parameters

            .Add("@Hora", DbType.DateTime).Value = pedido.Hora
            .Add("@IdPedidoTipo", DbType.Int32).Value = pedido.IdPedidoTipo
            .Add("@IdCliente", DbType.Int32).Value = pedido.IdCliente
            .Add("@IdVendedor", DbType.Int32).Value = pedido.IdVendedor
            .Add("@IdAlmacen", DbType.Int32).Value = pedido.IdAlmacen
            .Add("@FechaEmbarque", DbType.DateTime).Value = pedido.FechaEmbarque
            .Add("@FechaEntrega", DbType.DateTime).Value = pedido.FechaEntrega

            '.Add("@CalleEntrega", DbType.String).Value = pedido.CalleEntrega
            '.Add("@Cruce1Entrega", DbType.String).Value = pedido.Cruce1Entrega
            '.Add("@Cruce2Entrega", DbType.String).Value = pedido.Cruce2Entrega
            '.Add("@NumExtEntrega", DbType.String).Value = pedido.NumExtEntrega
            '.Add("@NumIntEntrega", DbType.String).Value = pedido.NumIntEntrega
            '.Add("@ColoniaEntrega", DbType.String).Value = pedido.ColoniaEntrega
            '.Add("@CPEntrega", DbType.String).Value = pedido.CPEntrega
            '.Add("@IdPoblacionEntrega", DbType.Int32).Value = pedido.IdPoblacionEntrega

            .Add("@OrdenCompra", DbType.String).Value = pedido.OrdenCompra
            .Add("@IdReferencia", DbType.String).Value = pedido.IdReferencia
            .Add("@Observaciones", DbType.String).Value = pedido.Observaciones
            .Add("@TotalCantidad", DbType.Decimal).Value = pedido.TotalCantidad
            .Add("@TotalSaldo", DbType.Decimal).Value = pedido.TotalSaldo
            .Add("@IdDivisa", DbType.Int32).Value = pedido.IdDivisa
            .Add("@TipoCambio", DbType.Decimal).Value = pedido.TipoCambio
            .Add("@SubTotal", DbType.Decimal).Value = pedido.SubTotal
            .Add("@TotalImpuestosTras", DbType.Decimal).Value = pedido.TotalImpuestosTrasladados
            .Add("@TotalImpuestosRet", DbType.Decimal).Value = pedido.TotalImpuestosRetenidos
            .Add("@TotalDescuentos", DbType.Decimal).Value = pedido.TotalDescuentos
            .Add("@TotalFlete", DbType.Decimal).Value = pedido.TotalFlete
            .Add("@TotalComision", DbType.Decimal).Value = pedido.TotalComision
            .Add("@Total", DbType.Decimal).Value = pedido.Total
            .Add("@TotalIVA", DbType.Decimal).Value = pedido.TotalIVA
            .Add("@TotalIEPS", DbType.Decimal).Value = pedido.TotalIEPS
        End With
        Return MyBase.Update(Pedido)
    End Function

#End Region

#Region "Metodos Privados"

    Private Sub Validate(ByVal pedido As PedidoInfo)
        Dim DivisaSvc As New DivisaService(SessionID, Connection, Transaction)
        'Verificar que se haya capturado por lo menos un artículo o un servicio
        If pedido.Servicios.Count = 0 And pedido.Articulos.Count = 0 Then
            Throw New BusinessException("El documento debe contener por lo menos un servicio o un artículo.")
        End If

        'Verificar si existen artículos o servicios con divisas diferentes a las del documento
        Dim DivisasServ = From D In pedido.Servicios
                         Where D.IdDivisa <> pedido.IdDivisa

        Dim DivisasArt = From D In pedido.Articulos
                        Where D.IdDivisa <> pedido.IdDivisa

        If DivisasServ.Count > 1 Or DivisasArt.Count > 1 Then
            Throw New BusinessException("No se pueden combinar servicios o artículos con diferente divisa a la del documento.")
        End If

        pedido.TipoCambio = DivisaSvc.GetTipoCambioActual(pedido.IdDivisa)
    End Sub

    Private Sub CargarEmpaquetados(ByVal pedido As PedidoInfo)
        For Each drPartida As DetallePedidoDS.ArticulosRow In pedido.Articulos
            If drPartida.RowState <> DataRowState.Deleted Then
                Dim UnidadSvc As New Azteca.Business.Inventario.UnidadMedidaService(SessionID, Connection, Transaction)
                Dim UnidadInf As Azteca.Business.Inventario.UnidadMedidaInfo = UnidadSvc.GetDetailFromCache(drPartida.IdUnidadMedida)
                'Si la unidad de medida son cajas, separar cajas y unidades
                If UnidadInf.IdTipoUnidad = 1 And UnidadInf.Identity > 0 Then
                    Dim Cantidad As New Azteca.Business.Inventario.Empaquetado(drPartida.Cantidad, UnidadInf.Factor)
                    drPartida.Cantidad = Cantidad.Cajas
                    drPartida.Unidades = Cantidad.Unidades
                End If
            End If
        Next
    End Sub

    Protected Overrides Sub GetDocumentDetail(ByVal document As PedidoInfo)
        Try
            'Cargar servicios
            Dim fxServicios As New FunctionSQL("Sales", "fxPedidosServiciosSEL", Connection, Transaction)
            fxServicios.Parameters.Add("@IdPedidoTit", DbType.String).Value = document.Identity
            fxServicios.Parameters.Add("@IdUsuario", DbType.Int32).Value = Session.User.Identity
            fxServicios.FillDataTable(document.Servicios)
            'Cargar artículos
            Dim fxArticulos As New FunctionSQL("Sales", "fxPedidosArticulosSEL", Connection, Transaction)
            fxArticulos.Parameters.Add("@IdPedidoTit", DbType.String).Value = document.Identity
            fxArticulos.Parameters.Add("@IdUsuario", DbType.Int32).Value = Session.User.Identity
            fxArticulos.FillDataTable(document.Articulos)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar las partidas del pedido.", ex)
        End Try
    End Sub

    Protected Overrides Sub UpdateDocumentDetail(ByVal document As PedidoInfo)
        Try
            Dim comDeleteServicios As New DbCommand("Sales.PedidosServiciosDEL", Connection, Transaction)
            With comDeleteServicios
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@IdPedidoTit", DbType.String).Value = document.Identity
                .Parameters.Add("@IdServicio", DbType.Int32, "IdServicio")
                .Parameters.Add("@IdPedidoDet", DbType.Int32, "IdPedidoDet")
            End With
            '
            Dim comUpdateServicios As New DbCommand("Sales.PedidosServiciosUPD", Connection, Transaction)
            With comUpdateServicios
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@IdPedidoDet", DbType.Int32, "IdPedidoDet")
                .Parameters("@IdPedidoDet").Direction = ParameterDirection.InputOutput
                .Parameters.Add("@IdPedidoTit", DbType.String).Value = document.Identity
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
            End With
            'Definir adaptador
            Dim daServicios As New DataAdapter()
            daServicios.DeleteCommand = comDeleteServicios
            daServicios.UpdateCommand = comUpdateServicios
            daServicios.InsertCommand = comUpdateServicios
            'Ejecutar primero con las filas eliminadas para evitar conflictos con el unique key
            Dim DeletedRows As DataTable = document.Servicios.GetChanges(DataRowState.Deleted)
            If DeletedRows IsNot Nothing Then daServicios.Update(DeletedRows)
            Dim vwDeleted As New DataView(document.Servicios, String.Empty, String.Empty, DataViewRowState.Deleted)
            For Each drv As DataRowView In vwDeleted
                drv.Row.AcceptChanges()
            Next
            daServicios.Update(document.Servicios)
            document.Servicios.AcceptChanges()

            '======================================
            'Guardar ahora el detalle de articulos
            '======================================
            Dim comDeleteArticulos As New DbCommand("Sales.PedidosArticulosDEL", Connection, Transaction)
            With comDeleteArticulos
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@IdPedidoTit", DbType.String).Value = document.Identity
                .Parameters.Add("@IdArticuloStock", DbType.Int32, "IdArticuloStock")
            End With
            '
            Dim comUpdateArticulos As New DbCommand("Sales.PedidosArticulosUPD", Connection, Transaction)
            With comUpdateArticulos
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@IdPedidoTit", DbType.String).Value = document.Identity
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
            End With
            Dim daArticulos As New DataAdapter
            daArticulos.DeleteCommand = comDeleteArticulos
            daArticulos.UpdateCommand = comUpdateArticulos
            daArticulos.InsertCommand = comUpdateArticulos
            'Ejecutar primero con las filas eliminadas para evitar conflictos con el unique key
            DeletedRows = document.Articulos.GetChanges(DataRowState.Deleted)
            If DeletedRows IsNot Nothing Then daArticulos.Update(DeletedRows)
            vwDeleted = New DataView(document.Articulos, String.Empty, String.Empty, DataViewRowState.Deleted)
            For Each drv As DataRowView In vwDeleted
                drv.Row.AcceptChanges()
            Next
            daArticulos.Update(document.Articulos)
            document.Articulos.AcceptChanges()
        Catch ex As Exception
            Throw New BusinessException("Error al guardar las partidas del pedido.", ex)
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


#End Region
	
End Class


''' <summary>
''' Business Facade con servicios para el manejo del documento de PedidosTit
''' </summary>
''' <remarks></remarks>
Public Class PedidoFacade
	Inherits DocumentFacade(Of PedidoInfo)
        
#Region "Metodos de DocumentFacade"

    ''' <summary>
    ''' Generar las acciones necesarias para el flujo de trabajo PedidoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Sub ApplyWorkflow(ByVal sessionID As GUID, ByVal IdPedido As String, ByVal IdStatus As Integer, fechaTrabajo as Date)
        Dim PedidoSvc As New PedidoService(sessionID)
        ApplyWorkflow(PedidoSvc, IdPedido, IdStatus, fechaTrabajo)
    End Sub

    ''' <summary>
    ''' Cancelar las acciones de regreso al flujo de trabajo PedidoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Sub CancelWorkflow(ByVal sessionID As GUID, ByVal IdPedido As String, ByVal IdStatus As Integer)
        Dim PedidoSvc As New PedidoService(sessionID)
        CancelWorkflow(PedidoSvc, IdPedido, IdStatus)
    End Sub


    ''' <summary>
    ''' Crea una nueva instancia de un PedidoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As PedidoInfo
		Dim PedidoSvc As New PedidoService(sessionID)
		Return PedidoSvc.Create()
    End Function

    ''' <summary>
    ''' Actualiza la información de un Pedido.
    ''' </summary>
    ''' <param name="Pedido">Paquete de información del tipo PedidoInfo con la información a actualizar</param>
    ''' <returns>Identificador de Pedido, si es nuevo, regresa el .</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Pedido As PedidoInfo) As PedidoInfo
    	Dim PedidoSvc As New PedidoService(Pedido.SessionID)
		Return Update(PedidoSvc, Ctype(Pedido,PedidoInfo))
    End Function
    

    ''' <summary>
    ''' Elimina un elemento del documento de PedidosTit
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idPedido">Identificador del Pedido que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idPedido As string)
		Dim PedidoSvc As New PedidoService(sessionID)
		Delete(PedidoSvc, idPedido)
    End Sub
	
    ''' <summary>
    ''' Verifica si existe un Pedido con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idPedido">ID de Pedido que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idPedido As string) As Boolean
		Dim PedidoSvc As New PedidoService(sessionID)
		Return Exists(PedidoSvc, idPedido)
    End Function

    
    ''' <summary>
    ''' Obtiene la información de un Pedido.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idPedido">Identificador de Pedido a consultar</param>
    ''' <returns>Paquete de información de tipo PedidoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idPedido As string) As PedidoInfo
        Return Me.GetDetail(sessionID, idPedido, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Pedido.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idPedido">Identificador de Pedido</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Pedido.</param>
    ''' <returns>Paquete de información de tipo PedidoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idPedido As string, checkStatus As Boolean) As PedidoInfo
   		Dim PedidoSvc As New PedidoService(sessionID)
        Dim PedidoInf As New PedidoInfo(sessionID)
		GetDetail(PedidoSvc, PedidoInf, idPedido)
        Return PedidoInf        
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection) As Integer
    	Dim PedidoSvc As New PedidoService(sessionID)
    	Return GetNumberOfPages(PedidoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca PedidosTit que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
		Dim PedidoSvc As New PedidoService(sessionID)
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca PedidosTit que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
    	Dim PedidoSvc As New PedidoService(sessionID)
    	Return GetSearchResult(PedidoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de PedidosTit.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
    	Dim PedidoSvc As New PedidoService(sessionID)
    	Return GetSearchStructure(PedidoSvc)
    End Function

#End Region

End Class
