Imports Azteca.Business.Contabilidad

''' <summary>
''' Paquete de información que representa un Orden
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class OrdenInfo
	Inherits DocumentInfo
	
#Region "Variables Privadas"
    Friend _FechaEntrega As Date
    Friend _IdPeriodo As Integer
    Friend _SubTotal As Decimal
    Friend _TotalImpuestosTrasladados As Decimal
    Friend _TotalImpuestosRetenidos As Decimal
    Friend _TotalDescuentos As Decimal
    Friend _Flete As Decimal
    Friend _Total As Decimal

    Private _Articulos As DetalleOrdenDS.ArticulosDataTable
    Private _Servicios As DetalleOrdenDS.ServiciosDataTable

#End Region

#Region "Propiedades"

    Public ReadOnly Property IdPeriodo As Integer
        Get
            Return _IdPeriodo
        End Get
    End Property

    Public Property IdProveedor As Integer

    Public Property IdDepartamento As Integer

    Public Property IdPresupuesto As Integer

    Public Property IdCentroRecepcion As Integer

    Public Property IdCentralCompras As Integer

    Public ReadOnly Property FechaEntrega As Date
        Get
            Return _FechaEntrega
        End Get
    End Property

    Public Property Referencia As String = String.Empty

    Public Property IdReferencia As String = String.Empty

    Public Property Origen As String = String.Empty

    Public Property IdDivisa As Integer

    Public Property TipoCambio As Decimal

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

    Public ReadOnly Property Flete As Decimal
        Get
            Return _Flete
        End Get
    End Property

    Public ReadOnly Property Total As Decimal
        Get
            Return _Total
        End Get
    End Property

    Public Property Observaciones As String = String.Empty
    Public Property FolioExt As String = String.Empty

    Public ReadOnly Property Articulos As DetalleOrdenDS.ArticulosDataTable
        Get
            Return _Articulos
        End Get
    End Property

    Public ReadOnly Property Servicios As DetalleOrdenDS.ServiciosDataTable
        Get
            Return _Servicios
        End Get
    End Property


#End Region

#Region "Constructor"

    Public Sub New(ByVal sessionID As Guid)
        MyBase.New(sessionID)
        _Articulos = New DetalleOrdenDS.ArticulosDataTable
        _Servicios = New DetalleOrdenDS.ServiciosDataTable
    End Sub

#End Region

#Region "Metodos"

    Public Sub CalcularTotales()
        ''Servicios
        Dim TotalesServicios = Aggregate D In Me.Servicios
                      Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached
                      Into TotalCantidad = Sum(D.Cantidad), SubTotal = Sum(D.Cantidad * D.CostoUnitario),
                        TotalDescuentos = Sum((D.MontoDesc1 + D.MontoDesc2 + D.MontoDesc3) * D.Cantidad)

        Dim Impuesto1Servicios = From D In Me.Servicios
                        Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpTras1 > 0
                        Group By Porcentaje = D.PorcImpTras1
                        Into Group, SubTotal = Sum((D.CostoUnitario - D.MontoDesc1 - D.MontoDesc2 - D.MontoDesc3) * D.Cantidad)

        Dim Retencion1Servicios = From D In Me.Servicios
                         Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpRet1 > 0
                         Group By Porcentaje = D.PorcImpRet1
                         Into Group, SubTotal = Sum((D.CostoUnitario - D.MontoDesc1 - D.MontoDesc2 - D.MontoDesc3) * D.Cantidad)
        ''Articulos
        Dim TotalesArticulos = Aggregate D In Me.Articulos
              Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached
              Into TotalCantidad = Sum(D.Cantidad), SubTotal = Sum(D.Cantidad * D.CostoUnitario),
              TotalDescuentos = Sum((D.MontoDesc1 + D.MontoDesc2 + D.MontoDesc3) * D.Cantidad)


        Dim Impuesto1Articulos = From D In Me.Articulos
                        Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpTras1 > 0
                        Group By Porcentaje = D.PorcImpTras1
                        Into Group, SubTotal = Sum((D.CostoUnitario - D.MontoDesc1 - D.MontoDesc2 - D.MontoDesc3) * D.Cantidad)

        Dim Retencion1Articulos = From D In Me.Articulos
                         Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached AndAlso D.PorcImpRet1 > 0
                         Group By Porcentaje = D.PorcImpRet1
                         Into Group, SubTotal = Sum((D.CostoUnitario - D.MontoDesc1 - D.MontoDesc2 - D.MontoDesc3) * D.Cantidad)


        With Me
            ._SubTotal = Decimal.Round(TotalesServicios.SubTotal + TotalesArticulos.SubTotal, 4)
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

            ._Total = Decimal.Round(._SubTotal + ._TotalImpuestosTrasladados - ._TotalImpuestosRetenidos - ._TotalDescuentos, 4) + _Flete
        End With

    End Sub

    Public Sub AsignarCosto(ByVal drPartida As DataRow, ByVal costo As CostoInfo)
        With costo
            drPartida("CostoUnitario") = .Costo
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
''' Proveedor de servicios para el manejo del catálogo de OrdenesTit
''' </summary>
''' <remarks></remarks>
Public Class OrdenService
    Inherits DocumentService(Of OrdenInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Purchasing", "OrdenesTit", "<<DETAILS_TABLE>>", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub

#End Region

#Region "Metodos de DocumentService"

    Public Overrides Sub ApplyWorkflow(ByVal IdOrden As String, ByVal IdStatus As Integer, ByVal fechaTrabajo As Date)
        MyBase.ApplyWorkflow(IdOrden, IdStatus, fechaTrabajo)
    End Sub

    Public Overrides Sub CancelWorkflow(ByVal IdOrden As String, ByVal IdStatus As Integer)
        MyBase.CancelWorkflow(IdOrden, IdStatus)
    End Sub

    Public Overrides Function Create() As OrdenInfo
        Return New OrdenInfo(SessionID)
    End Function

    Public Overrides Sub GetDetail(ByVal idOrden As String, ByRef Orden As OrdenInfo)
        MyBase.GetDetail(idOrden, Orden)
        With Orden
            .Fecha = CDate(DocInfo("Fecha"))
            ._IdPeriodo = CInt(DocInfo("IdPeriodo"))
            .IdProveedor = CInt(DocInfo("IdProveedor"))
            .IdPresupuesto = CInt(DocInfo("IdPresupuesto"))
            .IdDepartamento = CInt(DocInfo("IdDepartamento"))
            .IdCentroRecepcion = CInt(DocInfo("IdCentroRecepcion"))
            .IdCentralCompras = CInt(DocInfo("IdCentralCompras"))
            If DocInfo("FechaEntrega") IsNot DBNull.Value Then
                ._FechaEntrega = CDate(DocInfo("FechaEntrega"))
            End If
            .Referencia = CStr(DocInfo("Referencia"))
            .IdReferencia = CStr(DocInfo("IdReferencia"))
            .Origen = CStr(DocInfo("Origen"))
            .IdDivisa = CInt(DocInfo("IdDivisa"))
            .TipoCambio = CDec(DocInfo("TipoCambio"))
            ._SubTotal = CDec(DocInfo("SubTotal"))
            ._TotalImpuestosTrasladados = CDec(DocInfo("TotalImpuestosTras"))
            ._TotalImpuestosRetenidos = CDec(DocInfo("TotalImpuestosRet"))
            ._TotalDescuentos = CDec(DocInfo("TotalDescuentos"))
            ._Flete = CDec(DocInfo("Flete"))
            ._Total = CDec(DocInfo("Total"))
            .Observaciones = CStr(DocInfo("Observaciones"))
            .FolioExt = CStr(DocInfo("FolioExt"))
        End With
    End Sub

    Public Overrides Function Update(ByVal Orden As OrdenInfo) As OrdenInfo
        AsignarCostos(Orden)
        Validate(Orden)
        Orden.CalcularTotales()
        With Me.SPUpdate.Parameters
            .Add("@IdProveedor", DbType.Int32).Value = Orden.IdProveedor
            .Add("@IdDepartamento", DbType.Int32).Value = Orden.IdDepartamento
            .Add("@IdPresupuesto", DbType.Int32).Value = Orden.IdPresupuesto
            .Add("@IdCentroRecepcion", DbType.Int32).Value = Orden.IdCentroRecepcion
            .Add("@IdCentralCompras", DbType.Int32).Value = Orden.IdCentralCompras
            .Add("@Referencia", DbType.String).Value = Orden.Referencia
            .Add("@IdReferencia", DbType.String).Value = Orden.IdReferencia
            .Add("@Origen", DbType.String).Value = Orden.Origen
            .Add("@IdDivisa", DbType.Int32).Value = Orden.IdDivisa
            .Add("@TipoCambio", DbType.Decimal).Value = Orden.TipoCambio
            .Add("@SubTotal", DbType.Decimal).Value = Orden.SubTotal
            .Add("@TotalImpuestosTras", DbType.Decimal).Value = Orden.TotalImpuestosTrasladados
            .Add("@TotalImpuestosRet", DbType.Decimal).Value = Orden.TotalImpuestosRetenidos
            .Add("@TotalDescuentos", DbType.Decimal).Value = Orden.TotalDescuentos
            .Add("@Flete", DbType.Decimal).Value = Orden.Flete
            .Add("@Total", DbType.Decimal).Value = Orden.Total
            .Add("@Observaciones", DbType.String).Value = Orden.Observaciones
        End With
        Return MyBase.Update(Orden)
    End Function

#End Region

#Region "Metodos Privados"

    Private Function GetCentralCompras(idCentral As Integer) As CentralInfo
        Dim CentralSvc As New CentralService(SessionID, Connection, Transaction)
        Return CentralSvc.GetDetailFromCache(idCentral)
    End Function


    Private Sub AsignarCostos(orden As OrdenInfo)
        Dim Central As CentralInfo = GetCentralCompras(orden.IdCentralCompras)
        'Asignar costos de artículos
        For Each drArticulo As DetalleOrdenDS.ArticulosRow In orden.Articulos
            If drArticulo.CostoUnitario = 0 Then
                Dim ProveedorSvc As New ProveedorService(SessionID, Connection, Transaction)
                Dim Costo As CostoInfo = ProveedorSvc.GetCostoArticulo(Central.IdZonaCompra, orden.IdProveedor, drArticulo.IdArticuloStock)
                orden.AsignarCosto(drArticulo, Costo)
            End If
        Next
        'Asignar costos de servicios
        For Each drServicio As DetalleOrdenDS.ServiciosRow In orden.Servicios
            If drServicio.CostoUnitario = 0 Then
                Dim ProveedorSvc As New ProveedorService(SessionID, Connection, Transaction)
                Dim Costo As CostoInfo = ProveedorSvc.GetCostoServicio(Central.IdZonaCompra, orden.IdProveedor, drServicio.IdServicio)
                orden.AsignarCosto(drServicio, Costo)
            End If
        Next
    End Sub


    Protected Overrides Sub GetDocumentDetail(document As OrdenInfo)
        Try
            Dim Orden As OrdenInfo = CType(document, OrdenInfo)
            'Cargar servicios
            Dim fxServicios As New FunctionSQL("Purchasing", "fxOrdenServiciosSEL", Connection, Transaction)
            fxServicios.Parameters.Add("@IdOrdenTit", DbType.String).Value = Orden.Identity
            fxServicios.Parameters.Add("@IdUsuario", DbType.Int32).Value = Session.User.Identity
            fxServicios.FillDataTable(Orden.Servicios)
            'Cargar artículos
            Dim fxArticulos As New FunctionSQL("Purchasing", "fxOrdenArticulosSEL", Connection, Transaction)
            fxArticulos.Parameters.Add("@IdOrdenTit", DbType.String).Value = Orden.Identity
            fxArticulos.Parameters.Add("@IdUsuario", DbType.Int32).Value = Session.User.Identity
            fxArticulos.FillDataTable(Orden.Articulos)

        Catch ex As Exception
            Throw New BusinessException("Error al cargar las partidas de la orden de compra.", ex)
        End Try
    End Sub

    Protected Overrides Sub UpdateDocumentDetail(document As OrdenInfo)
        Try
            Dim Orden As OrdenInfo = CType(document, OrdenInfo)
            Dim comDelete As New DbCommand("Purchasing.OrdenesDetDEL", Connection, Transaction)
            With comDelete
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@IdOrdenTit", DbType.String).Value = document.Identity
                .Parameters.Add("@IdArticuloStock", DbType.Int32, "IdArticuloStock")
                .Parameters.Add("@IdServicio", DbType.Int32, "IdServicio")
            End With
            '
            Dim comUpdateServicios As New DbCommand("Purchasing.OrdenesDetUPD", Connection, Transaction)
            With comUpdateServicios
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@IdOrdenDet", DbType.Int32, "IdOrdenDET")
                .Parameters("@IdOrdenDet").Direction = ParameterDirection.InputOutput
                .Parameters.Add("@IdOrdenTit", DbType.String).Value = document.Identity
                .Parameters.Add("@Fecha", DbType.DateTime).Value = document.Fecha
                .Parameters.Add("@IdServicio", DbType.Int32, "IdServicio")
                .Parameters.Add("@IdArticuloStock", DbType.Int32).Value = 0
                .Parameters.Add("@Observaciones", DbType.String, "Observaciones")
                .Parameters.Add("@Cantidad", DbType.Decimal, "Cantidad")
                .Parameters.Add("@Recibido", DbType.Decimal).Value = 0
                .Parameters.Add("@IdUnidadMedida", DbType.Int32).Value = 0
                .Parameters.Add("@CostoUnitario", DbType.Decimal, "CostoUnitario")
                .Parameters.Add("@IdPresupuesto", DbType.Int32, "IdPresupuesto")
                .Parameters.Add("@IdCategoriaPresupuestal", DbType.Int32, "IdCategoriaPresupuestal")
                .Parameters.Add("@IdRequisicion", DbType.String, "IdRequisicion")
                .Parameters.Add("@FechaRequisicion", DbType.Date, "FechaRequisicion")
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
                .Parameters.Add("@Referencia1", DbType.String, "Referencia1")
                .Parameters.Add("@Referencia2", DbType.String, "Referencia2")

            End With
            'Definir adaptador
            Dim daServicios As New DataAdapter()
            daServicios.DeleteCommand = comDelete
            daServicios.UpdateCommand = comUpdateServicios
            daServicios.InsertCommand = comUpdateServicios
            'Ejecutar primero con las filas eliminadas para evitar conflictos con el unique key
            Dim DeletedRows As DataTable = Orden.Servicios.GetChanges(DataRowState.Deleted)
            If DeletedRows IsNot Nothing Then daServicios.Update(DeletedRows)
            Dim vwDeleted As New DataView(Orden.Servicios, String.Empty, String.Empty, DataViewRowState.Deleted)
            For Each drv As DataRowView In vwDeleted
                drv.Row.AcceptChanges()
            Next
            daServicios.Update(Orden.Servicios)
            Orden.Servicios.AcceptChanges()

            '======================================
            'Guardar ahora el detalle de articulos
            '======================================
            '
            Dim comUpdateArticulos As New DbCommand("Purchasing.OrdenesDetUPD", Connection, Transaction)
            With comUpdateArticulos
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@IdOrdenDet", DbType.Int32, "IdOrdenDet")
                .Parameters("@IdOrdenDet").Direction = ParameterDirection.InputOutput
                .Parameters.Add("@IdOrdenTit", DbType.String).Value = document.Identity
                .Parameters.Add("@Fecha", DbType.DateTime).Value = document.Fecha
                .Parameters.Add("@IdServicio", DbType.Int32).Value = 0
                .Parameters.Add("@IdArticuloStock", DbType.Int32, "IdArticuloStock")
                .Parameters.Add("@Observaciones", DbType.String, "Observaciones")
                .Parameters.Add("@Cantidad", DbType.Decimal, "Cantidad")
                .Parameters.Add("@Recibido", DbType.Decimal).Value = 0
                .Parameters.Add("@IdUnidadMedida", DbType.Int32, "IdUnidadMedida")
                .Parameters.Add("@CostoUnitario", DbType.Decimal, "CostoUnitario")
                .Parameters.Add("@IdPresupuesto", DbType.Int32, "IdPresupuesto")
                .Parameters.Add("@IdCategoriaPresupuestal", DbType.Int32, "IdCategoriaPresupuestal")
                .Parameters.Add("@IdRequisicion", DbType.String, "IdRequisicion")
                .Parameters.Add("@FechaRequisicion", DbType.Date, "FechaRequisicion")
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
                .Parameters.Add("@Referencia1", DbType.String, "Referencia1")
                .Parameters.Add("@Referencia2", DbType.String, "Referencia2")
            End With
            Dim daArticulos As New DataAdapter
            daArticulos.DeleteCommand = comDelete
            daArticulos.UpdateCommand = comUpdateArticulos
            daArticulos.InsertCommand = comUpdateArticulos
            'Ejecutar primero con las filas eliminadas para evitar conflictos con el unique key
            DeletedRows = Orden.Articulos.GetChanges(DataRowState.Deleted)
            If DeletedRows IsNot Nothing Then daArticulos.Update(DeletedRows)
            vwDeleted = New DataView(Orden.Articulos, String.Empty, String.Empty, DataViewRowState.Deleted)
            For Each drv As DataRowView In vwDeleted
                drv.Row.AcceptChanges()
            Next
            daArticulos.Update(Orden.Articulos)
            Orden.Articulos.AcceptChanges()
        Catch ex As Exception
            Throw New BusinessException("Error al guardar las partidas de la orden de compra.", ex)
        End Try
    End Sub

    Private Sub Validate(ByVal orden As OrdenInfo)
        'Cargar información de la central de compras
        Dim CentralSvc As New CentralService(SessionID, Connection, Transaction)
        Dim Central As CentralInfo = CentralSvc.GetDetailFromCache(orden.IdCentralCompras)
        '
        Dim DivisaSvc As New DivisaService(SessionID, Connection, Transaction)
        'Verificar que se haya capturado por lo menos un artículo o un servicio
        If orden.Servicios.Count = 0 And orden.Articulos.Count = 0 Then
            Throw New BusinessException("El documento debe contener por lo menos un servicio o un artículo.")
        End If

        'Verificar si existen artículos o servicios con divisas diferentes a las del documento
        Dim DivisasServ = From D In orden.Servicios
                         Where D.IdDivisa <> orden.IdDivisa

        Dim DivisasArt = From D In orden.Articulos
                        Where D.IdDivisa <> orden.IdDivisa

        If DivisasServ.Count > 1 Or DivisasArt.Count > 1 Then
            Throw New BusinessException("No se pueden combinar servicios o artículos con diferente divisa a la del documento.")
        End If

        If orden.IdDepartamento > 0 Then
            'Obtener información del departamento
            Dim DeptoSvc As New DepartamentoService(SessionID, Connection, Transaction)
            Dim DeptoInfo As DepartamentoInfo = DeptoSvc.GetDetailFromCache(orden.IdDepartamento)

            'Validar artículos
            For Each drArticulo As DetalleOrdenDS.ArticulosRow In orden.Articulos
                Dim ProveedorSvc As New ProveedorService(SessionID, Connection, Transaction)
                'Verificar que el artículo esté asignado a éste proveedor
                If Not ProveedorSvc.VendeArticulo(Central.IdZonaCompra, orden.IdProveedor, drArticulo.IdArticuloStock) Then
                    Throw New BusinessException("La orden contiene el artículo: " & drArticulo.Codigo & "(" & drArticulo.Descripcion & ") que no está asignado al proveedor de la orden.")
                End If
                'Si el departamento no tiene presupuesto o es global, quitar categoria presupuestal
                If DeptoInfo.TipoAdmonPresupuesto = TipoAdmonPresupuestoEnum.No Or DeptoInfo.TipoAdmonPresupuesto = TipoAdmonPresupuestoEnum.Global_Depto Then
                    If drArticulo.IdCategoriaPresupuestal > 0 Then drArticulo.IdCategoriaPresupuestal = 0
                End If
                'Si el departamento tiene presupuesto categorizado, verificar que se haya elegido una categoria
                If DeptoInfo.TipoAdmonPresupuesto = TipoAdmonPresupuestoEnum.Categorizado Then
                    If drArticulo.IdCategoriaPresupuestal = 0 Then Throw New BusinessException("El artículo: " & drArticulo.Codigo & "(" & drArticulo.Descripcion & ") no tiene asignada una categoría presupuestal.")
                End If
            Next

            'Validar servicios
            For Each drServicio As DetalleOrdenDS.ServiciosRow In orden.Servicios
                Dim ProveedorSvc As New ProveedorService(SessionID, Connection, Transaction)
                'Verificar que el servicio esté asignado a éste proveedor
                If Not ProveedorSvc.VendeServicio(Central.IdZonaCompra, orden.IdProveedor, drServicio.IdServicio) Then
                    Throw New BusinessException("La orden contiene el servicio: " & drServicio.Codigo & "(" & drServicio.Descripcion & ") que no está asignado al proveedor de la orden.")
                End If
                'Si el departamento no tiene presupuesto o es global, quitar categoria presupuestal
                If DeptoInfo.TipoAdmonPresupuesto = TipoAdmonPresupuestoEnum.No Or DeptoInfo.TipoAdmonPresupuesto = TipoAdmonPresupuestoEnum.Global_Depto Then
                    If drServicio.IdCategoriaPresupuestal > 0 Then drServicio.IdCategoriaPresupuestal = 0
                End If
                'Si el departamento tiene presupuesto categorizado, verificar que se haya elegido una categoria
                If DeptoInfo.TipoAdmonPresupuesto = TipoAdmonPresupuestoEnum.Categorizado Then
                    If drServicio.IdCategoriaPresupuestal = 0 Then Throw New BusinessException("El servicio: " & drServicio.Codigo & "(" & drServicio.Descripcion & ") no tiene asignada una categoría presupuestal.")
                End If
            Next
        End If
        orden.TipoCambio = DivisaSvc.GetTipoCambioActual(orden.IdDivisa)
    End Sub

    Private Function GetOrigen(ByVal origen As String) As OrigenOrden
        Select Case origen
            Case "M"
                Return OrigenOrden.Manual
            Case "G"
                Return OrigenOrden.Generador
            Case "S"
                Return OrigenOrden.Mantenimiento
            Case "P"
                Return OrigenOrden.Produccion
            Case Else
                Return OrigenOrden.Manual
        End Select
    End Function

    Private Function GetOrigen(ByVal origen As OrigenOrden) As String
        Select Case origen
            Case OrigenOrden.Manual
                Return "M"
            Case OrigenOrden.Generador
                Return "G"
            Case OrigenOrden.Produccion
                Return "P"
            Case OrigenOrden.Mantenimiento
                Return "S"
            Case Else
                Return "M"
        End Select
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del documento de OrdenesTit
''' </summary>
''' <remarks></remarks>
Public Class OrdenFacade
	Inherits DocumentFacade(Of OrdenInfo)
        
#Region "Metodos de DocumentFacade"

    ''' <summary>
    ''' Generar las acciones necesarias para el flujo de trabajo OrdenInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Sub ApplyWorkflow(ByVal sessionID As GUID, ByVal IdOrden As String, ByVal IdStatus As Integer, fechaTrabajo as Date)
        Dim OrdenSvc As New OrdenService(sessionID)
        ApplyWorkflow(OrdenSvc, IdOrden, IdStatus, fechaTrabajo)
    End Sub

    ''' <summary>
    ''' Cancelar las acciones de regreso al flujo de trabajo OrdenInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Sub CancelWorkflow(ByVal sessionID As GUID, ByVal IdOrden As String, ByVal IdStatus As Integer)
        Dim OrdenSvc As New OrdenService(sessionID)
        CancelWorkflow(OrdenSvc, IdOrden, IdStatus)
    End Sub


    ''' <summary>
    ''' Crea una nueva instancia de un OrdenInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As OrdenInfo
		Dim OrdenSvc As New OrdenService(sessionID)
		Return OrdenSvc.Create()
    End Function

    ''' <summary>
    ''' Actualiza la información de un Orden.
    ''' </summary>
    ''' <param name="Orden">Paquete de información del tipo OrdenInfo con la información a actualizar</param>
    ''' <returns>Identificador de Orden, si es nuevo, regresa el .</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Orden As OrdenInfo) As OrdenInfo
    	Dim OrdenSvc As New OrdenService(Orden.SessionID)
		Return Update(OrdenSvc, Ctype(Orden,OrdenInfo))
    End Function
    

    ''' <summary>
    ''' Elimina un elemento del documento de OrdenesTit
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idOrden">Identificador del Orden que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idOrden As string)
		Dim OrdenSvc As New OrdenService(sessionID)
		Delete(OrdenSvc, idOrden)
    End Sub
	
    ''' <summary>
    ''' Verifica si existe un Orden con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idOrden">ID de Orden que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idOrden As string) As Boolean
		Dim OrdenSvc As New OrdenService(sessionID)
		Return Exists(OrdenSvc, idOrden)
    End Function

    
    ''' <summary>
    ''' Obtiene la información de un Orden.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idOrden">Identificador de Orden a consultar</param>
    ''' <returns>Paquete de información de tipo OrdenInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idOrden As string) As OrdenInfo
        Return Me.GetDetail(sessionID, idOrden, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Orden.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idOrden">Identificador de Orden</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Orden.</param>
    ''' <returns>Paquete de información de tipo OrdenInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idOrden As string, checkStatus As Boolean) As OrdenInfo
   		Dim OrdenSvc As New OrdenService(sessionID)
        Dim OrdenInf As New OrdenInfo(sessionID)
		GetDetail(OrdenSvc, OrdenInf, idOrden)
        Return OrdenInf        
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection) As Integer
    	Dim OrdenSvc As New OrdenService(sessionID)
    	Return GetNumberOfPages(OrdenSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca OrdenesTit que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
		Dim OrdenSvc As New OrdenService(sessionID)
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca OrdenesTit que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
    	Dim OrdenSvc As New OrdenService(sessionID)
    	Return GetSearchResult(OrdenSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de OrdenesTit.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
    	Dim OrdenSvc As New OrdenService(sessionID)
    	Return GetSearchStructure(OrdenSvc)
    End Function

#End Region

End Class


Public Enum OrigenOrden
    Manual
    Generador
    Produccion
    Mantenimiento
    Ventas
End Enum