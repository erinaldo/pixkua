Imports Azteca.Business.Tesoreria

''' <summary>
''' Paquete de información que representa un Recepcion
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class RecepcionInfo
	Inherits DocumentInfo
	
#Region "Variables Privadas"
    Friend _IdOrden As String = String.Empty
    Friend _HoraRecepcion As Date
    Friend _IdEntrada As String = String.Empty
    Friend _FechaEntrada As Date
    Friend _IdContrareciboTit As String = String.Empty
    Friend _FechaContrarecibo As Date
    Friend _IdChequeTit As String = String.Empty
    Friend _FechaCheque As Date
    Friend _SubTotal As Decimal
    Friend _TotalImpuestosTrasladados As Decimal
    Friend _TotalImpuestosRetenidos As Decimal
    Friend _TotalDescuentos As Decimal
    Friend _Total As Decimal

    Private _Articulos As DetalleRecepcionDS.ArticulosDataTable
    Private _Servicios As DetalleRecepcionDS.ServiciosDataTable

#End Region

#Region "Propiedades"

    Public ReadOnly Property IdOrdenTit As String
        Get
            Return _IdOrden
        End Get
    End Property

    Public ReadOnly Property FechaOrden As Date
        Get
            Return GetDocumentDate(_IdOrden)
        End Get
    End Property

    Public ReadOnly Property HoraRecepcion As Date
        Get
            Return _HoraRecepcion
        End Get
    End Property

    Public ReadOnly Property IdEntrada As String
        Get
            Return _IdEntrada
        End Get
    End Property

    Public ReadOnly Property FechaEntrada As Date
        Get
            Return _FechaEntrada
        End Get
    End Property

    Public Property PagoAnticipado As Boolean = False

    Public ReadOnly Property IdContrareciboTit As String
        Get
            Return _IdContrareciboTit
        End Get
    End Property

    Public ReadOnly Property FechaContrarecibo As Date
        Get
            Return _FechaContrarecibo
        End Get
    End Property

    Public ReadOnly Property IdChequeTit As String
        Get
            Return _IdChequeTit
        End Get
    End Property

    Public ReadOnly Property FechaCheque As Date
        Get
            Return _FechaCheque
        End Get
    End Property

    Public Property SerieFactura As String = String.Empty

    Public Property FolioFactura As Integer

    Public Property UUIDFactura As String = String.Empty

    Public Property SerieNota As String = String.Empty

    Public Property FolioNota As Integer

    Public Property UUIDNota As String = String.Empty

    Public ReadOnly Property SubTotal As Decimal
        Get
            Return _SubTotal
        End Get
    End Property

    Public ReadOnly Property TotalImpuestosTrasladados As Decimal
        Get
            Return _TotalImpuestosTrasladados
        End Get
    End Property

    Public ReadOnly Property TotalImpuestosRetenidos As Decimal
        Get
            Return _TotalImpuestosRetenidos
        End Get
    End Property

    Public ReadOnly Property TotalDescuentos As Decimal
        Get
            Return _TotalDescuentos
        End Get
    End Property

    Public Property Flete As Decimal

    Public ReadOnly Property Total As Decimal
        Get
            Return _Total
        End Get
    End Property

    Public ReadOnly Property Articulos As DetalleRecepcionDS.ArticulosDataTable
        Get
            Return _Articulos
        End Get
    End Property

    Public ReadOnly Property Servicios As DetalleRecepcionDS.ServiciosDataTable
        Get
            Return _Servicios
        End Get
    End Property


#End Region

#Region "Constructor"
    Public Sub New(ByVal sessionID As Guid, idOrden As String)
        MyBase.New(sessionID)

        _IdOrden = idOrden
        _Articulos = New DetalleRecepcionDS.ArticulosDataTable
        _Servicios = New DetalleRecepcionDS.ServiciosDataTable
    End Sub
#End Region

#Region "Metodos"

    Public Sub CalcularTotales()
        ''Servicios
        Dim TotalesServicios = Aggregate D In Me.Servicios
                      Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached
                      Into TotalRecibido = Sum(D.Recibido), SubTotal = Sum(D.Recibido * D.CostoUnitario),
                        TotalDescuentos = Sum((D.MontoDesc1 + D.MontoDesc2 + D.MontoDesc3) * D.Recibido)

        Dim Impuesto1Servicios = From D In Me.Servicios
                        Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpTras1 > 0
                        Group By Porcentaje = D.PorcImpTras1
                        Into Group, SubTotal = Sum((D.CostoUnitario - D.MontoDesc1 - D.MontoDesc2 - D.MontoDesc3) * D.Recibido)

        Dim Retencion1Servicios = From D In Me.Servicios
                         Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpRet1 > 0
                         Group By Porcentaje = D.PorcImpRet1
                         Into Group, SubTotal = Sum((D.CostoUnitario - D.MontoDesc1 - D.MontoDesc2 - D.MontoDesc3) * D.Recibido)
        ''Articulos
        Dim TotalesArticulos = Aggregate D In Me.Articulos
              Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached
              Into TotalRecibido = Sum(D.Recibido), SubTotal = Sum(D.Recibido * D.CostoUnitario),
              TotalDescuentos = Sum((D.MontoDesc1 + D.MontoDesc2 + D.MontoDesc3) * D.Recibido)


        Dim Impuesto1Articulos = From D In Me.Articulos
                        Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpTras1 > 0
                        Group By Porcentaje = D.PorcImpTras1
                        Into Group, SubTotal = Sum((D.CostoUnitario - D.MontoDesc1 - D.MontoDesc2 - D.MontoDesc3) * D.Recibido)

        Dim Retencion1Articulos = From D In Me.Articulos
                         Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpRet1 > 0
                         Group By Porcentaje = D.PorcImpRet1
                         Into Group, SubTotal = Sum((D.CostoUnitario - D.MontoDesc1 - D.MontoDesc2 - D.MontoDesc3) * D.Recibido)


        With Me
            ._SubTotal = Decimal.Round(TotalesServicios.SubTotal + TotalesArticulos.SubTotal, 2)
            ._TotalDescuentos = Decimal.Round(TotalesServicios.TotalDescuentos + TotalesArticulos.TotalDescuentos, 2)
            ''Impuestos trasladados
            ._TotalImpuestosTrasladados = 0D
            For Each Tasa In Impuesto1Servicios
                ._TotalImpuestosTrasladados += (Tasa.SubTotal * Tasa.Porcentaje)
            Next
            For Each Tasa In Impuesto1Articulos
                ._TotalImpuestosTrasladados += (Tasa.SubTotal * Tasa.Porcentaje)
            Next
            ''Impuestos retenidos
            ._TotalImpuestosRetenidos = 0
            For Each Tasa In Retencion1Servicios
                ._TotalImpuestosRetenidos += (Tasa.SubTotal * Tasa.Porcentaje)
            Next
            For Each Tasa In Retencion1Articulos
                ._TotalImpuestosRetenidos += (Tasa.SubTotal * Tasa.Porcentaje)
            Next

            ._Total = Decimal.Round(._SubTotal + ._TotalImpuestosTrasladados - ._TotalImpuestosRetenidos - ._TotalDescuentos, 2) + Flete
        End With

    End Sub

    Public Sub AsignarCosto(ByVal drPartida As DataRow, ByVal costo As CostoInfo)
        With costo
            drPartida("CostoUnitario") = .Costo
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
            drPartida("IdRetencion1") = .IdRetencion1
            drPartida("IdRetencion2") = .IdRetencion2
            drPartida("IdRetencion3") = .IdRetencion3
            drPartida("IdRetencion4") = .IdRetencion4
            drPartida("IdRetencion5") = .IdRetencion5
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
''' Proveedor de servicios para el manejo del catálogo de RecepcionesTit
''' </summary>
''' <remarks></remarks>
Public Class RecepcionService
	Inherits DocumentService(Of RecepcionInfo)
	
#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Purchasing", "RecepcionesTit", "<<DETAILS_TABLE>>", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
    
#End Region

#Region "Metodos de DocumentService"

    Public Overrides Sub ApplyWorkflow(ByVal IdRecepcion As String, ByVal IdStatus As Integer, ByVal fechaTrabajo As Date)
        If IdStatus = WorkflowSteps.Apply Then
            'Cargar información de la recepción
            Dim Recepcion As New RecepcionInfo(SessionID, String.Empty)
            Dim RecepcionSvc As New RecepcionService(SessionID, Connection, Transaction)
            RecepcionSvc.GetDetail(IdRecepcion, Recepcion)
            '
            Dim IdEntrada As String = GenerarEntrada(Recepcion)
            Aplicar(Recepcion, IdEntrada)
            'Cargar información de la orden de compra para verificar si se ha recibido completamente
            Dim Orden As New OrdenInfo(SessionID)
            Dim OrdenSvc As New OrdenService(SessionID, Connection, Transaction)
            OrdenSvc.GetDetail(Recepcion.IdOrdenTit, Orden)
            '
            Dim TotalesArticulos = Aggregate A In Orden.Articulos
                                 Into Cantidad = Sum(A.Cantidad), Recibido = Sum(A.Recibido)

            Dim TotalesServicios = Aggregate S In Orden.Servicios
                                 Into Cantidad = Sum(S.Cantidad), Recibido = Sum(S.Recibido)

            'Si se ha recibido completamente la orden, cerrarla
            If TotalesArticulos.Cantidad = TotalesArticulos.Recibido AndAlso TotalesServicios.Cantidad = TotalesServicios.Recibido Then
                OrdenSvc.ApplyWorkflow(Orden.Identity, WorkflowSteps.Close, Date.Today)
            End If
            '
            GenerarContrerecibo(Recepcion)
        End If
        MyBase.ApplyWorkflow(IdRecepcion, IdStatus, fechaTrabajo)
    End Sub

    Public Overrides Sub CancelWorkflow(ByVal IdRecepcion As String, ByVal IdStatus As Integer)
        MyBase.CancelWorkflow(IdRecepcion, IdStatus)
    End Sub

	
    Public Overrides Function Create() As RecepcionInfo
        Return New RecepcionInfo(SessionID, String.Empty)
    End Function


    Public Overrides Sub GetDetail(ByVal idRecepcion As string, ByRef Recepcion As RecepcionInfo)
		MyBase.GetDetail(idRecepcion, Recepcion)
        With Recepcion
			.Fecha = CDate(DocInfo("Fecha"))
            ._IdOrden = CStr(DocInfo("IdOrdenTit"))
            ._HoraRecepcion = CDate(DocInfo("HoraRecepcion"))
            ._IdEntrada = CStr(DocInfo("IdEntrada")).Trim
            If .IdEntrada <> String.Empty Then ._FechaEntrada = CDate(DocInfo("FechaEntrada"))
			.PagoAnticipado = CBool(DocInfo("PagoAnticipado"))
            ._IdContrareciboTit = CStr(DocInfo("IdContrareciboTit")).Trim
            If .IdContrareciboTit <> String.Empty Then ._FechaContrarecibo = CDate(DocInfo("FechaContrarecibo"))
            ._IdChequeTit = CStr(DocInfo("IdChequeTit")).Trim
            If .IdChequeTit <> String.Empty Then ._FechaCheque = CDate(DocInfo("FechaCheque"))
			.SerieFactura = CStr(DocInfo("SerieFactura"))
			.FolioFactura = CInt(DocInfo("FolioFactura"))
			.UUIDFactura = CStr(DocInfo("UUIDFactura"))
			.SerieNota = CStr(DocInfo("SerieNota"))
			.FolioNota = CInt(DocInfo("FolioNota"))
            .UUIDNota = CStr(DocInfo("UUIDNota")).Trim
            ._SubTotal = CDec(DocInfo("SubTotal"))
            ._TotalImpuestosTrasladados = CDec(DocInfo("TotalImpuestosTras"))
            ._TotalImpuestosRetenidos = CDec(DocInfo("TotalImpuestosRet"))
            ._TotalDescuentos = CDec(DocInfo("TotalDescuentos"))
			.Flete = CDec(DocInfo("Flete"))
            ._Total = CDec(DocInfo("Total"))
		End With
    End Sub
	
    Public Overrides Function Update(ByVal Recepcion As RecepcionInfo) As RecepcionInfo
        Recepcion.CalcularTotales()
        With Me.SPUpdate.Parameters
            .Add("@IdOrdenTit", DbType.String).Value = Recepcion.IdOrdenTit
            .Add("@FechaOrden", DbType.DateTime).Value = Recepcion.FechaOrden
            .Add("@HoraRecepcion", DbType.DateTime).Value = Date.Now
            .Add("@PagoAnticipado", DbType.Boolean).Value = Recepcion.PagoAnticipado
            .Add("@SerieFactura", DbType.String).Value = Recepcion.SerieFactura
            .Add("@FolioFactura", DbType.Int32).Value = Recepcion.FolioFactura
            .Add("@UUIDFactura", DbType.String).Value = Recepcion.UUIDFactura
            .Add("@SerieNota", DbType.String).Value = Recepcion.SerieNota
            .Add("@FolioNota", DbType.Int32).Value = Recepcion.FolioNota
            .Add("@UUIDNota", DbType.String).Value = Recepcion.UUIDNota
            .Add("@SubTotal", DbType.Decimal).Value = Recepcion.SubTotal
            .Add("@TotalImpuestosTras", DbType.Decimal).Value = Recepcion.TotalImpuestosTrasladados
            .Add("@TotalImpuestosRet", DbType.Decimal).Value = Recepcion.TotalImpuestosRetenidos
            .Add("@TotalDescuentos", DbType.Decimal).Value = Recepcion.TotalDescuentos
            .Add("@Flete", DbType.Decimal).Value = Recepcion.Flete
            .Add("@Total", DbType.Decimal).Value = Recepcion.Total
        End With
        Dim Result As RecepcionInfo = MyBase.Update(Recepcion)
        ApplyWorkflow(Recepcion.Identity, WorkflowSteps.Apply, Date.Today)
        Return Result
    End Function

#End Region

#Region "Metodos Privados"


    Protected Overrides Sub GetDocumentDetail(document As RecepcionInfo)
        Try
            Dim Recepcion As RecepcionInfo = CType(document, RecepcionInfo)
            'Cargar servicios
            Dim fxServicios As New FunctionSQL("Purchasing", "fxRecepcionServiciosSEL", Connection, Transaction)
            fxServicios.Parameters.Add("@IdRecepcionTit", DbType.String).Value = Recepcion.Identity
            fxServicios.Parameters.Add("@IdUsuario", DbType.Int32).Value = Session.User.Identity
            fxServicios.FillDataTable(Recepcion.Servicios)
            'Cargar artículos
            Dim fxArticulos As New FunctionSQL("Purchasing", "fxRecepcionArticulosSEL", Connection, Transaction)
            fxArticulos.Parameters.Add("@IdRecepcionTit", DbType.String).Value = Recepcion.Identity
            fxArticulos.Parameters.Add("@IdUsuario", DbType.Int32).Value = Session.User.Identity
            fxArticulos.FillDataTable(Recepcion.Articulos)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar las partidas de la recepción de compra.", ex)
        End Try
    End Sub

    Protected Overrides Sub UpdateDocumentDetail(document As RecepcionInfo)
        Try
            Dim Recepcion As RecepcionInfo = CType(document, RecepcionInfo)
            Dim comDelete As New DbCommand("Purchasing.RecepcionesDetDEL", Connection, Transaction)
            With comDelete
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@IdRecepcionTit", DbType.String).Value = document.Identity
                .Parameters.Add("@IdArticuloStock", DbType.Int32, "IdArticuloStock")
                .Parameters.Add("@IdServicio", DbType.Int32, "IdServicio")
            End With
            '
            'Dim comUpdateServicios As New DbCommand("Purchasing.OrdenesDetUPD", Connection, Transaction)
            Dim comUpdateServicios As New DbCommand("Purchasing.RecepcionesDetUPD", Connection, Transaction)
            With comUpdateServicios
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@IdRecepcionTit", DbType.String).Value = document.Identity
                .Parameters.Add("@Fecha", DbType.DateTime).Value = document.Fecha
                .Parameters.Add("@IdServicio", DbType.Int32, "IdServicio")
                .Parameters.Add("@IdArticuloStock", DbType.Int32).Value = 0
                .Parameters.Add("@Cantidad", DbType.Decimal, "Cantidad")
                .Parameters.Add("@Recibido", DbType.Decimal, "Recibido")
                .Parameters.Add("@IdUnidadMedida", DbType.Int32).Value = 0
                .Parameters.Add("@CostoUnitario", DbType.Decimal, "CostoUnitario")
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
            End With
            'Definir adaptador
            Dim daServicios As New DataAdapter()
            daServicios.DeleteCommand = comDelete
            daServicios.UpdateCommand = comUpdateServicios
            daServicios.InsertCommand = comUpdateServicios
            'Ejecutar primero con las filas eliminadas para evitar conflictos con el unique key
            Dim DeletedRows As DataTable = Recepcion.Servicios.GetChanges(DataRowState.Deleted)
            If DeletedRows IsNot Nothing Then daServicios.Update(DeletedRows)
            Dim vwDeleted As New DataView(Recepcion.Servicios, String.Empty, String.Empty, DataViewRowState.Deleted)
            For Each drv As DataRowView In vwDeleted
                drv.Row.AcceptChanges()
            Next
            daServicios.Update(Recepcion.Servicios)
            Recepcion.Servicios.AcceptChanges()

            '======================================
            'Guardar ahora el detalle de articulos
            '======================================
            '
            Dim comUpdateArticulos As New DbCommand("Purchasing.RecepcionesDetUPD", Connection, Transaction)
            With comUpdateArticulos
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@IdRecepcionTit", DbType.String).Value = document.Identity
                .Parameters.Add("@Fecha", DbType.DateTime).Value = document.Fecha
                .Parameters.Add("@IdServicio", DbType.Int32).Value = 0
                .Parameters.Add("@IdArticuloStock", DbType.Int32, "IdArticuloStock")
                .Parameters.Add("@Cantidad", DbType.Decimal, "Cantidad")
                .Parameters.Add("@Recibido", DbType.Decimal, "Recibido")
                .Parameters.Add("@IdUnidadMedida", DbType.Int32, "IdUnidadMedida")
                .Parameters.Add("@CostoUnitario", DbType.Decimal, "CostoUnitario")
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
            End With
            Dim daArticulos As New DataAdapter
            daArticulos.DeleteCommand = comDelete
            daArticulos.UpdateCommand = comUpdateArticulos
            daArticulos.InsertCommand = comUpdateArticulos
            'Ejecutar primero con las filas eliminadas para evitar conflictos con el unique key
            DeletedRows = Recepcion.Articulos.GetChanges(DataRowState.Deleted)
            If DeletedRows IsNot Nothing Then daArticulos.Update(DeletedRows)
            vwDeleted = New DataView(Recepcion.Articulos, String.Empty, String.Empty, DataViewRowState.Deleted)
            For Each drv As DataRowView In vwDeleted
                drv.Row.AcceptChanges()
            Next
            daArticulos.Update(Recepcion.Articulos)
            Recepcion.Articulos.AcceptChanges()
        Catch ex As Exception
            Throw New BusinessException("Error al guardar las partidas de la recepción de compra.", ex)
        End Try
    End Sub

    Private Sub GenerarContrerecibo(recepcion As RecepcionInfo)
        Try
            'Cargar información de la orden de compra
            Dim OrdenSvc As New OrdenService(SessionID, Connection, Transaction)
            Dim OrdenInf As New OrdenInfo(SessionID)
            OrdenSvc.GetDetail(recepcion.IdOrdenTit, OrdenInf)
            'Cargar información del departamento de la orden de compra
            Dim DepartamentoSvc As New DepartamentoService(SessionID, Connection, Transaction)
            Dim DepartamentoInf As New DepartamentoInfo(Session.SessionID)
            If (OrdenInf.IdDepartamento > 0) Then
                DepartamentoInf = DepartamentoSvc.GetDetailFromCache(OrdenInf.IdDepartamento)
            End If
            'Cargar información de la central de compras
            Dim CentralSvc As New CentralService(SessionID, Connection, Transaction)
            Dim Central As New CentralInfo(Session.SessionID)
            If (OrdenInf.IdDepartamento > 0) Then
                Central = CentralSvc.GetDetailFromCache(DepartamentoInf.IdCentral)
            End If
            'Obtener el id de beneficiario del proveedor
            Dim BeneficiarioSvc As New BeneficiarioService(SessionID, Connection, Transaction)
            Dim IdBeneficiario As Integer = BeneficiarioSvc.GetIDByProveedor(OrdenInf.IdProveedor)
            'Obtener el tipo de cambio
            Dim DivisaSvc As New Azteca.Business.Contabilidad.DivisaService(SessionID, Connection, Transaction)
            Dim TipoCambio As Decimal = DivisaSvc.GetTipoCambioActual(OrdenInf.IdDivisa)
            If IdBeneficiario = 0 Then Throw New BusinessException("El proveedor de la orden " & recepcion.IdOrdenTit & " no se encuentra en el catálogo de beneficiarios.")
            'Crear un nuevo contrarecibo
            Dim Contrarecibo As New ContrareciboInfo(SessionID)
            With Contrarecibo
                If (OrdenInf.IdDepartamento > 0) Then
                    .IdCaja = Central.IdCaja
                Else
                    .IdCaja = 0
                End If
                .IdDocumento = recepcion.Identity
                .FechaDocumento = recepcion.Fecha
                .IdBeneficiario = IdBeneficiario
                .IdDivisa = OrdenInf.IdDivisa
                .TipoCambio = TipoCambio
                .Origen = OrigenContrarecibo.OrdenCompra
                .IdSucursal = recepcion.IdSucursal
            End With
            'Agregar artículos al detalle del contrarecibo
            For Each drArticulo As DetalleRecepcionDS.ArticulosRow In recepcion.Articulos
                Dim dr As DetalleContrareciboDS.DetalleRow = Contrarecibo.Details.NewDetalleRow
                dr.CodigoConcepto = drArticulo.Codigo
                dr.DescripcionConcepto = drArticulo.Descripcion
                dr.IdCuenta = drArticulo.IdCuenta
                dr.IdDepartamento = OrdenInf.IdDepartamento
                dr.Monto = drArticulo.CostoUnitario * drArticulo.Recibido
                dr.IdImpuesto1 = drArticulo.IdImpuesto1
                dr.IdImpuesto2 = drArticulo.IdImpuesto2
                dr.IdImpuesto3 = drArticulo.IdImpuesto3
                dr.IdImpuesto4 = drArticulo.IdImpuesto4
                dr.IdImpuesto5 = drArticulo.IdImpuesto5
                dr.PorcImpTras1 = drArticulo.PorcImpTras1
                dr.PorcImpTras2 = drArticulo.PorcImpTras2
                dr.PorcImpTras3 = drArticulo.PorcImpTras3
                dr.PorcImpTras4 = drArticulo.PorcImpTras4
                dr.PorcImpTras5 = drArticulo.PorcImpTras5
                dr.MontoImpTras1 = drArticulo.MontoImpTras1
                dr.MontoImpTras2 = drArticulo.MontoImpTras2
                dr.MontoImpTras3 = drArticulo.MontoImpTras3
                dr.MontoImpTras4 = drArticulo.MontoImpTras4
                dr.MontoImpTras5 = drArticulo.MontoImpTras5
                dr.IdRetencion1 = drArticulo.IdRetencion1
                dr.IdRetencion2 = drArticulo.IdRetencion2
                dr.IdRetencion3 = drArticulo.IdRetencion3
                dr.IdRetencion4 = drArticulo.IdRetencion4
                dr.IdRetencion5 = drArticulo.IdRetencion5
                dr.PorcImpRet1 = drArticulo.PorcImpRet1
                dr.PorcImpRet2 = drArticulo.PorcImpRet2
                dr.PorcImpRet3 = drArticulo.PorcImpRet3
                dr.PorcImpRet4 = drArticulo.PorcImpRet4
                dr.PorcImpRet5 = drArticulo.PorcImpRet5
                dr.MontoImpRet1 = drArticulo.MontoImpRet1
                dr.MontoImpRet2 = drArticulo.MontoImpRet2
                dr.MontoImpRet3 = drArticulo.MontoImpRet3
                dr.MontoImpRet4 = drArticulo.MontoImpRet4
                dr.MontoImpRet5 = drArticulo.MontoImpRet5

                Contrarecibo.Details.AddDetalleRow(dr)
            Next

            Dim ContrareciboSvc As New ContrareciboService(SessionID, Connection, Transaction)
            Contrarecibo = ContrareciboSvc.Update(Contrarecibo)
            ContrareciboSvc.ApplyWorkflow(Contrarecibo.Identity, WorkflowSteps.Apply, Date.Today)
        Catch ex As Exception
            Throw New BusinessException("Error al generar el contrarecibo de la recepción: " & recepcion.ToString, ex)
        End Try
    End Sub

#End Region
	
End Class


''' <summary>
''' Business Facade con servicios para el manejo del documento de RecepcionesTit
''' </summary>
''' <remarks></remarks>
Public Class RecepcionFacade
	Inherits DocumentFacade(Of RecepcionInfo)
        
#Region "Metodos de DocumentFacade"

    ''' <summary>
    ''' Generar las acciones necesarias para el flujo de trabajo RecepcionInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Sub ApplyWorkflow(ByVal sessionID As GUID, ByVal IdRecepcion As String, ByVal IdStatus As Integer, fechaTrabajo as Date)
        Dim RecepcionSvc As New RecepcionService(sessionID)
        ApplyWorkflow(RecepcionSvc, IdRecepcion, IdStatus, fechaTrabajo)
    End Sub

    ''' <summary>
    ''' Cancelar las acciones de regreso al flujo de trabajo RecepcionInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Sub CancelWorkflow(ByVal sessionID As GUID, ByVal IdRecepcion As String, ByVal IdStatus As Integer)
        Dim RecepcionSvc As New RecepcionService(sessionID)
        CancelWorkflow(RecepcionSvc, IdRecepcion, IdStatus)
    End Sub


    ''' <summary>
    ''' Crea una nueva instancia de un RecepcionInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As RecepcionInfo
		Dim RecepcionSvc As New RecepcionService(sessionID)
		Return RecepcionSvc.Create()
    End Function

    ''' <summary>
    ''' Actualiza la información de un Recepcion.
    ''' </summary>
    ''' <param name="Recepcion">Paquete de información del tipo RecepcionInfo con la información a actualizar</param>
    ''' <returns>Identificador de Recepcion, si es nuevo, regresa el .</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Recepcion As RecepcionInfo) As RecepcionInfo
    	Dim RecepcionSvc As New RecepcionService(Recepcion.SessionID)
		Return Update(RecepcionSvc, Ctype(Recepcion,RecepcionInfo))
    End Function
    

    ''' <summary>
    ''' Elimina un elemento del documento de RecepcionesTit
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idRecepcion">Identificador del Recepcion que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idRecepcion As string)
		Dim RecepcionSvc As New RecepcionService(sessionID)
		Delete(RecepcionSvc, idRecepcion)
    End Sub
	
    ''' <summary>
    ''' Verifica si existe un Recepcion con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idRecepcion">ID de Recepcion que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idRecepcion As string) As Boolean
		Dim RecepcionSvc As New RecepcionService(sessionID)
		Return Exists(RecepcionSvc, idRecepcion)
    End Function

    
    ''' <summary>
    ''' Obtiene la información de un Recepcion.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idRecepcion">Identificador de Recepcion a consultar</param>
    ''' <returns>Paquete de información de tipo RecepcionInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idRecepcion As string) As RecepcionInfo
        Return Me.GetDetail(sessionID, idRecepcion, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Recepcion.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idRecepcion">Identificador de Recepcion</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Recepcion.</param>
    ''' <returns>Paquete de información de tipo RecepcionInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idRecepcion As string, checkStatus As Boolean) As RecepcionInfo
   		Dim RecepcionSvc As New RecepcionService(sessionID)
        Dim RecepcionInf As New RecepcionInfo(sessionID, String.Empty)
		GetDetail(RecepcionSvc, RecepcionInf, idRecepcion)
        Return RecepcionInf        
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection) As Integer
    	Dim RecepcionSvc As New RecepcionService(sessionID)
    	Return GetNumberOfPages(RecepcionSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca RecepcionesTit que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
		Dim RecepcionSvc As New RecepcionService(sessionID)
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca RecepcionesTit que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
    	Dim RecepcionSvc As New RecepcionService(sessionID)
    	Return GetSearchResult(RecepcionSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de RecepcionesTit.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
    	Dim RecepcionSvc As New RecepcionService(sessionID)
    	Return GetSearchStructure(RecepcionSvc)
    End Function

#End Region

End Class
