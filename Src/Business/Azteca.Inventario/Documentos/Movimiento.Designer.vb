Public Enum TipoMovimiento
    Entrada = 1
    Salida = -1
End Enum

''' <summary>
''' Paquete de información que representa un Movimiento
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class MovimientoInfo
	Inherits DocumentInfo
	
#Region "Variables Privadas"
    Friend _HoraMovimiento As Date
    Friend _HoraApartado As Date
    Friend _HoraCarga As Date
    Friend _HoraAplicado As Date
    Friend _Apartado As Boolean
    Friend _Cargado As Boolean
    Friend _Movido As Boolean
    Friend _Aplicado As Boolean
    Friend _TotalCantidad As Decimal
    Friend _TotalCosto As Decimal
    Friend _IdCorte As Guid
#End Region

#Region "Propiedades"

    Public Property Direccion As TipoMovimiento

    Public Property Referencia As String = String.Empty

    Public Property Observaciones As String = String.Empty

    Public Property IdConcepto As Integer

    Public Property IdAlmacen As Integer

    Public ReadOnly Property IdCorte As Guid
        Get
            Return _IdCorte
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

    Public ReadOnly Property HoraMovimiento As Date
        Get
            Return _HoraMovimiento
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

    Public ReadOnly Property Details() As DetalleMovimientoDS.DetalleDataTable
        Get
            Return CType(DetailsTable, DetalleMovimientoDS.DetalleDataTable)
        End Get
    End Property
#End Region

#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
        DetailsTable = New DetalleMovimientoDS.DetalleDataTable
    End Sub
#End Region

#Region "Metodos Publicos"

    Public Sub CalcularTotales()
        Dim Totales = Aggregate D In Details
              Where D.RowState <> DataRowState.Deleted
              Into Cantidad = Sum(D.Cantidad), Costo = Sum(D.CostoUnitario * D.Cantidad)

        _TotalCantidad = Totales.Cantidad
        _TotalCosto = Totales.Costo + Flete
    End Sub

#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de MovimientosTit
''' </summary>
''' <remarks></remarks>
Public Class MovimientoService
    Inherits DocumentService(Of MovimientoInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Inventory", "MovimientosTit", "MovimientosDet", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub

#End Region

#Region "Metodos de DocumentService"

    Public Overrides Sub ApplyWorkflow(ByVal IdMovimiento As String, ByVal IdStatus As Integer, ByVal fechaTrabajo As Date)
        MyBase.ApplyWorkflow(IdMovimiento, IdStatus, fechaTrabajo)
    End Sub

    Public Overrides Sub CancelWorkflow(ByVal IdMovimiento As String, ByVal IdStatus As Integer)
        MyBase.CancelWorkflow(IdMovimiento, IdStatus)
    End Sub

    Public Overrides Function Create() As MovimientoInfo
        Return New MovimientoInfo(sessionID)
    End Function

    Public Overrides Sub GetDetail(ByVal idMovimiento As String, ByRef movimiento As MovimientoInfo)
        MyBase.GetDetail(idMovimiento, Movimiento)
        With Movimiento
            .Fecha = CDate(DocInfo("Fecha"))
            If DocInfo("HoraMovto") Is DBNull.Value Then
                ._Movido = False
            Else
                ._Movido = True
                ._HoraMovimiento = CDate(DocInfo("HoraMovto"))
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
            .IdAlmacen = CInt(DocInfo("IdAlmacen"))
            ._TotalCantidad = CDec(DocInfo("TotalCantidad"))
            ._TotalCosto = CDec(DocInfo("TotalCosto"))
            .Flete = CDec(DocInfo("TotalFlete"))
            .OrdenTrabajo = DocInfo("OrdenTrabajo").ToString()
            .Direccion = GetTipoMovimiento(CShort(DocInfo("Direccion")))
            .Referencia = CStr(DocInfo("Referencia"))
            ._IdCorte = CType(DocInfo("IdCorte"), Guid)
            .Observaciones = CStr(DocInfo("Observaciones"))
        End With
    End Sub

    Public Overrides Function Update(ByVal movimiento As MovimientoInfo) As MovimientoInfo
        Validate(movimiento)
        With Me.SPUpdate.Parameters
            .Add("@IdConcepto", DbType.Int32).Value = movimiento.IdConcepto
            .Add("@IdAlmacen", DbType.Int32).Value = movimiento.IdAlmacen
            .Add("@TotalCantidad", DbType.Decimal).Value = movimiento.TotalCantidad
            .Add("@TotalCosto", DbType.Decimal).Value = movimiento.TotalCosto
            .Add("@TotalFlete", DbType.Decimal).Value = movimiento.Flete
            .Add("@OrdenTrabajo", DbType.String).Value = movimiento.OrdenTrabajo
            .Add("@Direccion", DbType.Int16).Value = GetTipoMovimiento(movimiento.Direccion)
            .Add("@Referencia", DbType.String).Value = movimiento.Referencia
            .Add("@Observaciones", DbType.String).Value = movimiento.Observaciones
        End With
        Return MyBase.Update(movimiento)
    End Function

#End Region

#Region "Metodos Privados"

    Private Sub Validate(ByVal movimiento As MovimientoInfo)
        Dim MovtoOriginal As New MovimientoInfo(SessionID)
        Dim Svc As New MovimientoService(SessionID, Connection, Transaction)
        If movimiento.Identity <> String.Empty Then
            Svc.GetDetail(movimiento.Identity, MovtoOriginal)            
        End If

        If movimiento.IdAlmacen <= 0 Then
            Throw New BusinessException("No se puede guardar un movimiento sin un almacén válido")
        ElseIf movimiento.IdConcepto <= 0 Then
            Throw New BusinessException("No se puede guardar un movimiento sin un concepto válido")
        ElseIf movimiento.Identity <> String.Empty AndAlso movimiento.IdConcepto <> MovtoOriginal.IdConcepto Then
            Throw New BusinessException("No se puede cambiar el concepto de un movimiento previamente guardado.")
        End If
        'Validar que las partidas tengan cantidades mayores a cero
        Dim CantidadesInvalidas = From D In movimiento.Details
                                Where D.Cantidad <= 0

        If CantidadesInvalidas.Count > 0 Then
            Throw New BusinessException("No se puede guardar el movimiento. Todas las partidas deben contener una cantidad mayor o igual a cero.")
        End If
    End Sub

    Public Function GetTipoMovimiento(ByVal tipo As TipoMovimiento) As Short
        If tipo = TipoMovimiento.Entrada Then
            Return 1
        Else
            Return -1
        End If
    End Function

    Public Function GetTipoMovimiento(ByVal tipo As Short) As TipoMovimiento
        If tipo = 1 Then
            Return TipoMovimiento.Entrada
        Else
            Return TipoMovimiento.Salida
        End If
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del documento de MovimientosTit
''' </summary>
''' <remarks></remarks>
Public Class MovimientoFacade
    Inherits DocumentFacade(Of MovimientoInfo)

#Region "Metodos de DocumentFacade"

    ''' <summary>
    ''' Generar las acciones necesarias para el flujo de trabajo MovimientoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Sub ApplyWorkflow(ByVal sessionID As GUID, ByVal IdMovimiento As String, ByVal IdStatus As Integer, ByVal fechaTrabajo As Date)
        Dim MovimientoSvc As New MovimientoService(sessionID)
        ApplyWorkflow(MovimientoSvc, IdMovimiento, IdStatus, fechaTrabajo)
    End Sub

    ''' <summary>
    ''' Cancelar las acciones de regreso al flujo de trabajo MovimientoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Sub CancelWorkflow(ByVal sessionID As GUID, ByVal IdMovimiento As String, ByVal IdStatus As Integer)
        Dim MovimientoSvc As New MovimientoService(sessionID)
        CancelWorkflow(MovimientoSvc, IdMovimiento, IdStatus)
    End Sub


    ''' <summary>
    ''' Crea una nueva instancia de un MovimientoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As MovimientoInfo
        Dim MovimientoSvc As New MovimientoService(sessionID)
        Return MovimientoSvc.Create()
    End Function

    ''' <summary>
    ''' Actualiza la información de un Movimiento.
    ''' </summary>
    ''' <param name="Movimiento">Paquete de información del tipo MovimientoInfo con la información a actualizar</param>
    ''' <returns>Identificador de Movimiento, si es nuevo, regresa el .</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Movimiento As MovimientoInfo) As MovimientoInfo
        Dim MovimientoSvc As New MovimientoService(Movimiento.SessionID)
        Return Update(MovimientoSvc, CType(Movimiento, MovimientoInfo))
    End Function


    ''' <summary>
    ''' Elimina un elemento del documento de MovimientosTit
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idMovimiento">Identificador del Movimiento que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idMovimiento As String)
        Dim MovimientoSvc As New MovimientoService(sessionID)
        Delete(MovimientoSvc, idMovimiento)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Movimiento con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idMovimiento">ID de Movimiento que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idMovimiento As String) As Boolean
        Dim MovimientoSvc As New MovimientoService(sessionID)
        Return Exists(MovimientoSvc, idMovimiento)
    End Function


    ''' <summary>
    ''' Obtiene la información de un Movimiento.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idMovimiento">Identificador de Movimiento a consultar</param>
    ''' <returns>Paquete de información de tipo MovimientoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idMovimiento As String) As MovimientoInfo
        Return Me.GetDetail(sessionID, idMovimiento, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Movimiento.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idMovimiento">Identificador de Movimiento</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Movimiento.</param>
    ''' <returns>Paquete de información de tipo MovimientoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idMovimiento As String, ByVal checkStatus As Boolean) As MovimientoInfo
        Dim MovimientoSvc As New MovimientoService(sessionID)
        Dim MovimientoInf As New MovimientoInfo(sessionID)
        GetDetail(MovimientoSvc, MovimientoInf, idMovimiento)
        Return MovimientoInf
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim MovimientoSvc As New MovimientoService(sessionID)
        Return GetNumberOfPages(MovimientoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca MovimientosTit que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Dim MovimientoSvc As New MovimientoService(sessionID)
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca MovimientosTit que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim MovimientoSvc As New MovimientoService(sessionID)
        Return GetSearchResult(MovimientoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de MovimientosTit.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim MovimientoSvc As New MovimientoService(sessionID)
        Return GetSearchStructure(MovimientoSvc)
    End Function

#End Region

End Class
