''' <summary>
''' Paquete de información que representa un Traspaso
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class TraspasoInfo
	Inherits DocumentInfo
	
#Region "Variables Privadas"
    Friend _HoraMovto As Date
    Friend _HoraApartado As Date
    Friend _HoraCarga As Date
    Friend _HoraAplicado As Date
    Friend _Apartado As Boolean
    Friend _Cargado As Boolean
    Friend _Movido As Boolean
    Friend _Aplicado As Boolean
    Friend _IdMovimientoEntrada As String
    Friend _IdMovimientoSalida As String
    Friend _TotalCantidad As Decimal
    Friend _TotalCosto As Decimal
    Friend _IdCorte As Guid

#End Region

#Region "Propiedades"

    Public ReadOnly Property HoraMovimiento As Date
        Get
            Return _HoraMovto
        End Get
    End Property

    Public ReadOnly Property HoraApartado As Date
        Get
            Return _HoraApartado
        End Get
    End Property

    Public ReadOnly Property HoraCarga As Date
        Get
            Return _HoraCarga
        End Get
    End Property

    Public ReadOnly Property HoraAplicado As Date
        Get
            Return _HoraAplicado
        End Get
    End Property

    Public ReadOnly Property Movido As Boolean
        Get
            Return _Movido
        End Get
    End Property

    Public ReadOnly Property Apartado As Boolean
        Get
            Return _Apartado
        End Get
    End Property

    Public ReadOnly Property Cargado As Boolean
        Get
            Return _Cargado
        End Get
    End Property

    Public ReadOnly Property Aplicado As Boolean
        Get
            Return _Aplicado
        End Get
    End Property


    Public Property IdConcepto As Integer

    Public Property IdAlmacenOrigen As Integer

    Public Property IdAlmacenDestino As Integer

    Public Property Referencia As String = String.Empty

    Public ReadOnly Property IdMovimientoEntrada As String
        Get
            Return _IdMovimientoEntrada
        End Get
    End Property

    Public ReadOnly Property IdMovimientoSalida As String
        Get
            Return _IdMovimientoSalida
        End Get
    End Property

    Public ReadOnly Property TotalCantidad As Decimal
        Get
            Return _TotalCantidad
        End Get
    End Property

    Public ReadOnly Property TotalCosto As Decimal
        Get
            Return _TotalCosto
        End Get
    End Property

    Public Property Flete As Decimal

    Public Property OrdenTrabajo As String = String.Empty

    Public ReadOnly Property IdCorte As Guid
        Get
            Return _IdCorte
        End Get
    End Property

    Public Property Observaciones As String = String.Empty

    Public ReadOnly Property Details() As DetalleTraspasoDS.DetalleDataTable
        Get
            Return CType(DetailsTable, DetalleTraspasoDS.DetalleDataTable)
        End Get
    End Property
#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
        DetailsTable = New DetalleTraspasoDS.DetalleDataTable
    End Sub
#End Region

#Region "Metodos Publicos"
    Public Sub CalcularTotales()
        Dim Totales = Aggregate D In Details
              Where D.RowState <> DataRowState.Deleted
              Into Cantidad = Sum(D.CantidadEnviada), Costo = Sum(D.CostoUnitario * D.CantidadEnviada)

        _TotalCantidad = Totales.Cantidad
        _TotalCosto = Totales.Costo + Flete
    End Sub

#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de TraspasosTit
''' </summary>
''' <remarks></remarks>
Public Class TraspasoService
    Inherits DocumentService(Of TraspasoInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Inventory", "TraspasosTit", "TraspasosDet", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub

#End Region

#Region "Metodos Privados"

    Private Function GenerarMovimiento(ByVal traspaso As TraspasoInfo, ByVal tipo As TipoMovimiento) As MovimientoInfo
        Dim Movimiento As New MovimientoInfo(SessionID)
        'Generar encabezado del movimiento
        With Movimiento
            .Fecha = Date.Today
            .IdConcepto = traspaso.IdConcepto
            If tipo = TipoMovimiento.Entrada Then
                .IdAlmacen = traspaso.IdAlmacenDestino
                .Direccion = TipoMovimiento.Entrada
            Else
                .IdAlmacen = traspaso.IdAlmacenOrigen
                .Direccion = TipoMovimiento.Salida
            End If
            .Referencia = traspaso.Identity
            .Observaciones = "Traspaso " & traspaso.Identity
            .Flete = traspaso.Flete
        End With
        'Generar detalle de movimiento
        For Each drPartidaTras As DetalleTraspasoDS.DetalleRow In traspaso.Details
            With drPartidaTras
                Dim drPartida As DetalleMovimientoDS.DetalleRow = Movimiento.Details.NewDetalleRow
                drPartida.IdArticuloStock = .IdArticuloStock
                If tipo = TipoMovimiento.Entrada Then
                    drPartida.Cantidad = .CantidadRecibida
                Else
                    drPartida.Cantidad = .CantidadEnviada
                End If
                drPartida.CostoUnitario = .CostoUnitario
                drPartida.IdUnidadMedida = .IdUnidadMedida
                Movimiento.Details.AddDetalleRow(drPartida)
            End With
        Next
        'Guardar movimiento en la base de datos
        Dim MovimientoSvc As New MovimientoService(SessionID, Connection, Transaction)
        Return MovimientoSvc.Update(Movimiento)
    End Function

#Region "Apply Workflow"

    Private Sub SetMovtos(ByVal traspaso As TraspasoInfo, ByVal idEntrada As String, ByVal idSalida As String)
        Dim spAplicar As New StoredProcedure("Inventory", "TraspasoAplicarMovtos", Connection, Transaction)
        spAplicar.Parameters.Add("@IdTraspasoTit", DbType.String).Value = traspaso.Identity
        spAplicar.Parameters.Add("@IdEntrada", DbType.String).Value = idEntrada
        spAplicar.Parameters.Add("@IdSalida", DbType.String).Value = idSalida
        spAplicar.Execute()
    End Sub

    Private Sub Aplicar(ByVal traspaso As TraspasoInfo, ByVal fechaTrabajo As Date)
        Try
            'Si el estatus está en estatus guardado, entonces se debe aplicar inmediatamente
            If traspaso.Status = WorkflowSteps.Save Then
                Dim Entrada As MovimientoInfo = GenerarMovimiento(traspaso, TipoMovimiento.Entrada)
                Dim Salida As MovimientoInfo = GenerarMovimiento(traspaso, TipoMovimiento.Salida)
                'Aplicar movimientos
                Dim EntradaSvc As New MovimientoService(sessionID, Connection, Transaction)
                Dim SalidaSvc As New MovimientoService(sessionID, Connection, Transaction)
                SalidaSvc.ApplyWorkflow(Salida.Identity, WorkflowSteps.Apply, fechaTrabajo)
                EntradaSvc.ApplyWorkflow(Entrada.Identity, WorkflowSteps.Apply, fechaTrabajo)
                SetMovtos(traspaso, Entrada.Identity, Salida.Identity)
            End If
            'Si el estatus es apartado o en transito, aplicar movimientos
            If traspaso.Status = WorkflowSteps.Reserve Or traspaso.Status = WorkflowSteps.Transport Then
                Dim EntradaSvc As New MovimientoService(sessionID, Connection, Transaction)
                Dim SalidaSvc As New MovimientoService(sessionID, Connection, Transaction)
                SalidaSvc.ApplyWorkflow(traspaso.IdMovimientoSalida, WorkflowSteps.Apply, fechaTrabajo)
                EntradaSvc.ApplyWorkflow(traspaso.IdMovimientoEntrada, WorkflowSteps.Apply, fechaTrabajo)
            End If
        Catch ex As Exception
            Throw New BusinessException("Error al aplicar el traspaso " & traspaso.Identity, ex)
        End Try
    End Sub

    Private Sub Apartar(ByVal traspaso As TraspasoInfo, ByVal fechaTrabajo As Date)
        Try
            'Se generan los movimientos y se deja la salida en apartado
            Dim Entrada As MovimientoInfo = GenerarMovimiento(traspaso, TipoMovimiento.Entrada)
            Dim Salida As MovimientoInfo = GenerarMovimiento(traspaso, TipoMovimiento.Salida)
            '
            Dim MovimientoSvc As New MovimientoService(sessionID, Connection, Transaction)
            'Enviar salida a apartado
            MovimientoSvc.ApplyWorkflow(traspaso.IdMovimientoSalida, WorkflowSteps.Reserve, fechaTrabajo)
            SetMovtos(traspaso, Entrada.Identity, Salida.Identity)
        Catch ex As Exception
            Throw New BusinessException("Error al apartar el traspaso " & traspaso.Identity, ex)
        End Try
    End Sub

    Private Sub Transportar(ByVal traspaso As TraspasoInfo, ByVal fechaTrabajo As Date)
        Try
            Dim Entrada As MovimientoInfo = GenerarMovimiento(traspaso, TipoMovimiento.Entrada)
            Dim Salida As MovimientoInfo = GenerarMovimiento(traspaso, TipoMovimiento.Salida)
            '
            Dim MovimientoSvc As New MovimientoService(sessionID, Connection, Transaction)
            'Enviar salida a transito
            MovimientoSvc.ApplyWorkflow(traspaso.IdMovimientoSalida, WorkflowSteps.Transport, fechaTrabajo)
            SetMovtos(traspaso, Entrada.Identity, Salida.Identity)
        Catch ex As Exception
            Throw New BusinessException("Error al transportar el traspaso " & traspaso.Identity, ex)
        End Try
    End Sub

#End Region

#Region "Cancel Workflow"

    Private Sub CancelarCarga(ByVal traspaso As TraspasoInfo)
        'Cancela un traspaso aplicado y regresa su estatus a apartado
        Dim EntradaSvc As New MovimientoService(sessionID, Connection, Transaction)
        'Se cancela movimiento de entrada
        EntradaSvc.CancelWorkflow(traspaso.IdMovimientoEntrada, WorkflowSteps.Apply)
        'Se genera un nuevo movimiento de entrada
        Dim Entrada As MovimientoInfo = GenerarMovimiento(traspaso, TipoMovimiento.Entrada)
        'Se establece id de la nueva entrada en el traspaso
        SetMovtos(traspaso, Entrada.Identity, traspaso.IdMovimientoSalida)
        'Establecer estatus de la salida en apartado
        Dim SalidaSvc As New MovimientoService(sessionID, Connection, Transaction)
        SalidaSvc.SetEstatus(traspaso.IdMovimientoSalida, WorkflowSteps.Reserve)
        'Incrementar el apartado en el inventario del almacén origen
        Dim AlmacenSvc As New AlmacenService(sessionID, Connection, Transaction)
        For Each drPartida As DetalleTraspasoDS.DetalleRow In traspaso.Details
            AlmacenSvc.MoverApartado(traspaso.IdAlmacenOrigen, drPartida.IdArticuloStock, drPartida.CantidadEnviada, drPartida.IdUnidadMedida, TipoMovimiento.Entrada)
        Next
    End Sub

    Private Sub CancelarRecepcion(ByVal traspaso As TraspasoInfo)
        'Cancela un traspaso aplicado y regresa su estatus a en transito        
        Dim EntradaSvc As New MovimientoService(sessionID, Connection, Transaction)
        'Se cancela movimiento de entrada
        EntradaSvc.CancelWorkflow(traspaso.IdMovimientoEntrada, WorkflowSteps.Apply)
        'Se genera un nuevo movimiento de entrada
        Dim Entrada As MovimientoInfo = GenerarMovimiento(traspaso, TipoMovimiento.Entrada)
        'Se establece id de la nueva entrada en el traspaso
        SetMovtos(traspaso, Entrada.Identity, traspaso.IdMovimientoSalida)
        'Establecer estatus de la salida en apartado
        Dim SalidaSvc As New MovimientoService(sessionID, Connection, Transaction)
        SalidaSvc.SetEstatus(traspaso.IdMovimientoSalida, WorkflowSteps.Transport)
        'Incrementar el transito en el inventario del almacén origen
        Dim AlmacenSvc As New AlmacenService(sessionID, Connection, Transaction)
        For Each drPartida As DetalleTraspasoDS.DetalleRow In traspaso.Details
            AlmacenSvc.MoverTransito(traspaso.IdAlmacenOrigen, drPartida.IdArticuloStock, drPartida.CantidadEnviada, drPartida.IdUnidadMedida, TipoMovimiento.Entrada)
        Next
    End Sub

    Private Sub CancelarAplicado(ByVal traspaso As TraspasoInfo)
        Dim WorkflowSvc As New WorkflowServices(sessionID, Connection, Transaction)
        Dim IdStatusAnterior As Integer = WorkflowSvc.GetPreviousStep(traspaso.GetDocumentType, traspaso.Status)
        'Si el documento se debe cancelar completamente
        If IdStatusAnterior <= 2 Then
            Dim EntradaSvc As New MovimientoService(sessionID, Connection, Transaction)
            Dim SalidaSvc As New MovimientoService(sessionID, Connection, Transaction)
            SalidaSvc.CancelWorkflow(traspaso.IdMovimientoSalida, WorkflowSteps.Apply)
            EntradaSvc.CancelWorkflow(traspaso.IdMovimientoEntrada, WorkflowSteps.Apply)
        End If
        'Si se debe dejar en estatus de apartado
        If IdStatusAnterior = WorkflowSteps.Reserve Then
            CancelarCarga(traspaso)
        End If
        'Si se debe dejar en estatus de transito
        If IdStatusAnterior = WorkflowSteps.Transport Then
            CancelarRecepcion(traspaso)
        End If
    End Sub

    Private Sub CancelarApartado(ByVal traspaso As TraspasoInfo)
        Dim MovimientoSvc As New MovimientoService(sessionID, Connection, Transaction)
        'Cancelar movimiento de salida y eliminar entrada
        MovimientoSvc.CancelWorkflow(traspaso.IdMovimientoSalida, WorkflowSteps.Reserve)
        MovimientoSvc.Delete(traspaso.IdMovimientoEntrada)
    End Sub

    Private Sub CancelarTransito(ByVal traspaso As TraspasoInfo)
        Dim WorkflowSvc As New WorkflowServices(sessionID, Connection, Transaction)
        Dim IdStatusAnterior As Integer = WorkflowSvc.GetPreviousStep(traspaso.GetDocumentType, traspaso.Status)
        'Si el documento quedaria como cancelado
        If IdStatusAnterior = WorkflowSteps.Cancel Then
            Dim MovimientoSvc As New MovimientoService(sessionID, Connection, Transaction)
            'Cancelar movimiento de salida
            MovimientoSvc.CancelWorkflow(traspaso.IdMovimientoSalida, WorkflowSteps.Reserve)
            'Eliminar movimiento de entrada
            MovimientoSvc.Delete(traspaso.IdMovimientoEntrada)
        ElseIf IdStatusAnterior = WorkflowSteps.Reserve Then
            Dim AlmacenSvc As New AlmacenService(sessionID, Connection, Transaction)
            'Si el paso anterior es quedar como apartado, decrementar transito e incrementar apartado
            For Each drPartida As DetalleTraspasoDS.DetalleRow In traspaso.Details
                AlmacenSvc.MoverTransito(traspaso.IdAlmacenOrigen, drPartida.IdArticuloStock, drPartida.CantidadEnviada, drPartida.IdUnidadMedida, TipoMovimiento.Salida)
                AlmacenSvc.MoverApartado(traspaso.IdAlmacenOrigen, drPartida.IdArticuloStock, drPartida.CantidadEnviada, drPartida.IdUnidadMedida, TipoMovimiento.Entrada)
            Next
            'Establecer movimiento de salida en estatus apartado
            Dim MovimientoSvc As New MovimientoService(sessionID, Connection, Transaction)
            MovimientoSvc.SetEstatus(traspaso.IdMovimientoSalida, WorkflowSteps.Reserve)
        End If
    End Sub
#End Region

#End Region

#Region "Metodos de DocumentService"

    Public Overrides Sub ApplyWorkflow(ByVal IdTraspaso As String, ByVal IdStatus As Integer, ByVal fechaTrabajo As Date)
        Dim TraspasoSvc As New TraspasoService(sessionID, Connection, Transaction)
        'Cargar información del traspaso
        Dim TraspasoInf As New TraspasoInfo(sessionID)
        TraspasoSvc.GetDetail(IdTraspaso, TraspasoInf)
        'Si el traspaso se está aplicando
        If IdStatus = WorkflowSteps.Apply Then
            Aplicar(TraspasoInf, fechaTrabajo)
        ElseIf IdStatus = WorkflowSteps.Reserve Then
            Apartar(TraspasoInf, fechaTrabajo)
        ElseIf IdStatus = WorkflowSteps.Transport Then
            Transportar(TraspasoInf, fechaTrabajo)
        End If
        MyBase.ApplyWorkflow(IdTraspaso, IdStatus, fechaTrabajo)
    End Sub

    Public Overrides Sub CancelWorkflow(ByVal IdTraspaso As String, ByVal IdStatus As Integer)
        Dim TraspasoSvc As New TraspasoService(sessionID, Connection, Transaction)
        'Cargar información del traspaso
        Dim TraspasoInf As New TraspasoInfo(sessionID)
        TraspasoSvc.GetDetail(IdTraspaso, TraspasoInf)
        Select Case IdStatus
            Case WorkflowSteps.Apply
                CancelarAplicado(TraspasoInf)
            Case WorkflowSteps.Reserve
                CancelarApartado(TraspasoInf)
            Case WorkflowSteps.Transport
                CancelarTransito(TraspasoInf)
        End Select
        MyBase.CancelWorkflow(IdTraspaso, IdStatus)
    End Sub

    Public Overrides Function Create() As TraspasoInfo
        Return New TraspasoInfo(sessionID)
    End Function

    Public Overrides Sub GetDetail(ByVal idTraspaso As String, ByRef traspaso As TraspasoInfo)
        MyBase.GetDetail(idTraspaso, traspaso)
        With traspaso
            .Fecha = CDate(DocInfo("Fecha"))
            If DocInfo("HoraMovto") Is DBNull.Value Then
                ._Movido = False
            Else
                ._Movido = True
                ._HoraMovto = CDate(DocInfo("HoraMovto"))
            End If
            If DocInfo("HoraApartado") Is DBNull.Value Then
                ._Apartado = False
            Else
                ._Apartado = True
                ._HoraApartado = CDate(DocInfo("HoraApartado"))
            End If
            If DocInfo("HoraCarga") Is DBNull.Value Then
                ._Cargado = False
            Else
                ._Cargado = True
                ._HoraCarga = CDate(DocInfo("HoraCarga"))
            End If
            If DocInfo("HoraAplicado") Is DBNull.Value Then
                ._Aplicado = False
            Else
                ._Aplicado = True
                ._HoraAplicado = CDate(DocInfo("HoraAplicado"))
            End If
            .IdConcepto = CInt(DocInfo("IdConcepto"))
            .IdAlmacenOrigen = CInt(DocInfo("IdAlmacenOrigen"))
            .IdAlmacenDestino = CInt(DocInfo("IdAlmacenDestino"))
            ._IdMovimientoEntrada = CStr(DocInfo("IdMovimientoIN"))
            ._IdMovimientoSalida = CStr(DocInfo("IdMovimientoOUT"))
            ._TotalCantidad = CDec(DocInfo("TotalCantidad"))
            ._TotalCosto = CDec(DocInfo("TotalCosto"))
            .Flete = CDec(DocInfo("TotalFlete"))
            .OrdenTrabajo = DocInfo("OrdenTrabajo").ToString()
            .Referencia = CStr(DocInfo("Referencia"))
            ._IdCorte = CType(DocInfo("IdCorte"), Guid)
            .Observaciones = CStr(DocInfo("Observaciones"))
        End With
    End Sub

    Public Overrides Function Update(ByVal traspaso As TraspasoInfo) As TraspasoInfo
        traspaso.CalcularTotales()
        With Me.SPUpdate.Parameters
            .Add("@IdConcepto", DbType.Int32).Value = traspaso.IdConcepto
            .Add("@IdAlmacenOrigen", DbType.Int32).Value = traspaso.IdAlmacenOrigen
            .Add("@IdAlmacenDestino", DbType.Int32).Value = traspaso.IdAlmacenDestino
            .Add("@Referencia", DbType.String).Value = traspaso.Referencia
            .Add("@Observaciones", DbType.String).Value = traspaso.Observaciones
            .Add("@TotalCantidad", DbType.Decimal).Value = traspaso.TotalCantidad
            .Add("@TotalCosto", DbType.Decimal).Value = traspaso.TotalCosto
            .Add("@Flete", DbType.Decimal).Value = traspaso.Flete
            .Add("@OrdenTrabajo", DbType.String).Value = traspaso.OrdenTrabajo
        End With
        Return MyBase.Update(traspaso)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del documento de TraspasosTit
''' </summary>
''' <remarks></remarks>
Public Class TraspasoFacade
    Inherits DocumentFacade(Of TraspasoInfo)

#Region "Metodos de DocumentFacade"

    ''' <summary>
    ''' Generar las acciones necesarias para el flujo de trabajo TraspasoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Sub ApplyWorkflow(ByVal sessionID As GUID, ByVal IdTraspaso As String, ByVal IdStatus As Integer, ByVal fechaTrabajo As Date)
        Dim TraspasoSvc As New TraspasoService(sessionID)
        ApplyWorkflow(TraspasoSvc, IdTraspaso, IdStatus, fechaTrabajo)
    End Sub

    ''' <summary>
    ''' Cancelar las acciones de regreso al flujo de trabajo TraspasoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Sub CancelWorkflow(ByVal sessionID As GUID, ByVal IdTraspaso As String, ByVal IdStatus As Integer)
        Dim TraspasoSvc As New TraspasoService(sessionID)
        CancelWorkflow(TraspasoSvc, IdTraspaso, IdStatus)
    End Sub


    ''' <summary>
    ''' Crea una nueva instancia de un TraspasoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As TraspasoInfo
        Dim TraspasoSvc As New TraspasoService(sessionID)
        Return TraspasoSvc.Create()
    End Function

    ''' <summary>
    ''' Actualiza la información de un Traspaso.
    ''' </summary>
    ''' <param name="Traspaso">Paquete de información del tipo TraspasoInfo con la información a actualizar</param>
    ''' <returns>Identificador de Traspaso, si es nuevo, regresa el .</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Traspaso As TraspasoInfo) As TraspasoInfo
        Dim TraspasoSvc As New TraspasoService(Traspaso.SessionID)
        Return Update(TraspasoSvc, CType(Traspaso, TraspasoInfo))
    End Function


    ''' <summary>
    ''' Elimina un elemento del documento de TraspasosTit
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idTraspaso">Identificador del Traspaso que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idTraspaso As String)
        Dim TraspasoSvc As New TraspasoService(sessionID)
        Delete(TraspasoSvc, idTraspaso)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Traspaso con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idTraspaso">ID de Traspaso que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idTraspaso As String) As Boolean
        Dim TraspasoSvc As New TraspasoService(sessionID)
        Return Exists(TraspasoSvc, idTraspaso)
    End Function


    ''' <summary>
    ''' Obtiene la información de un Traspaso.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idTraspaso">Identificador de Traspaso a consultar</param>
    ''' <returns>Paquete de información de tipo TraspasoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idTraspaso As String) As TraspasoInfo
        Return Me.GetDetail(sessionID, idTraspaso, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Traspaso.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idTraspaso">Identificador de Traspaso</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Traspaso.</param>
    ''' <returns>Paquete de información de tipo TraspasoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idTraspaso As String, ByVal checkStatus As Boolean) As TraspasoInfo
        Dim TraspasoSvc As New TraspasoService(sessionID)
        Dim TraspasoInf As New TraspasoInfo(sessionID)
        GetDetail(TraspasoSvc, TraspasoInf, idTraspaso)
        Return TraspasoInf
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim TraspasoSvc As New TraspasoService(sessionID)
        Return GetNumberOfPages(TraspasoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca TraspasosTit que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Dim TraspasoSvc As New TraspasoService(sessionID)
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca TraspasosTit que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim TraspasoSvc As New TraspasoService(sessionID)
        Return GetSearchResult(TraspasoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de TraspasosTit.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim TraspasoSvc As New TraspasoService(sessionID)
        Return GetSearchStructure(TraspasoSvc)
    End Function

#End Region

End Class
