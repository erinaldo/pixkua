Public Class ToolBarStatus
    Public Property SiguienteWF As Boolean
    Public Property RecibirEntregar As Boolean
    Public Property AgregarIncidencia As Boolean
    Public Property CerrarIncidencia As Boolean
    Public Property CerrarOT As Boolean
    Public Property SurtirInsumos As Boolean
    Public Property DescargarPT As Boolean

    Public Sub ToolBarStatus()
        SiguienteWF = False
        RecibirEntregar = False
        AgregarIncidencia = False
        CerrarIncidencia = False
        CerrarOT = False
        SurtirInsumos = False
        DescargarPT = False
    End Sub
End Class

Public Enum WorkFlowStatus As Integer
    Guardado = 1
    Liberado = 2
    EnEspera = 3
    Cerrado = 4
    Cancelado = 5
End Enum

Public Structure TipoMovimientoOT
    Const InicioProceso = "IP"
    Const FinProceso = "FP"
    Const InicioIncidencia = "II"
    Const FinIncidencia = "FI"
    Const EntregaMaterial = "EM"
    Const RecepcionMaterial = "RM"
End Structure

''' <summary>
''' Paquete de información que representa un OrdenTrabajo
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class OrdenTrabajoInfo
    Inherits CatalogInfo

#Region "Campos Privados"

    Friend _Aplicado As Boolean
    Friend _Cerrado As Boolean

#End Region

#Region "Propiedades"

    Public Property WorkFlowStatus As WorkFlowStatus

    Public Property Nombre As String

    Public Property Fecha As Date

    Public Property IdArticuloStock As Integer

    Public Property CantDeseada As Decimal

    Public Property CantRecibida As Decimal

    Public Property Version As Integer

    Public Property IdOrdenTrabajoTipo As Integer

    Public Property FechaPromEntrega As Date

    Public Property FechaRecepcion As Date

    Public Property HoraAplicado As Date

    Public Property HoraCierre As Date

    Public Property EntregasParciales As Boolean

    Public Property ExigirRecepcion As Boolean

    Public Property Observaciones As String

    Public Property IdCuenta As Integer

    Public Property Insumos As OrdenesTrabajoDS.InsumosDataTable

    Public Property Ensambles As OrdenesTrabajoDS.EnsamblesDataTable

    Public Property Servicios As OrdenesTrabajoDS.ServiciosDataTable

    Public Property IdAlmacenInsumos As Integer

    Public Property IdAlmacenPT As Integer

    Public Property FechaEnsambleUltimaRecepcion As Date

    Public Property FechaEnsambleUltimaEntrega As Date

    Public Property EnsambleAnterior As EnsambleInfo

    Public Property EnsambleSiguiente As EnsambleInfo

    Public Property EnsambleActual As EnsambleInfo

    Public Property IncidenciaActual As IncidenciaInfo

    Public Property FolioPedido As String

    Public Property FechaRequerida As DateTime

    Public Property CantidadPlanillas As Integer

    Public Property Area As String

    Public Property Tipo As String


    Public ReadOnly Property Aplicado As Boolean
        Get
            Return _Aplicado
        End Get
    End Property

    Public ReadOnly Property Cerrado As Boolean
        Get
            Return _Cerrado
        End Get
    End Property


#End Region

#Region "Constructor"
    Public Sub New(ByVal sessionID As Guid)
        MyBase.New(sessionID)

        'Inicializacion
        Insumos = New OrdenesTrabajoDS.InsumosDataTable
        Servicios = New OrdenesTrabajoDS.ServiciosDataTable
        Ensambles = New OrdenesTrabajoDS.EnsamblesDataTable
        EnsambleSiguiente = New EnsambleInfo(sessionID)
        EnsambleActual = New EnsambleInfo(sessionID)
        IncidenciaActual = New IncidenciaInfo(sessionID)
        Observaciones = String.Empty
        FolioPedido = String.Empty
        Area = String.Empty
        Tipo = String.Empty


    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de OrdenesTrabajo
''' </summary>
''' <remarks></remarks>
Public Class OrdenTrabajoService
    Inherits CatalogService(Of OrdenTrabajoInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As Guid)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As Guid, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As Guid, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Production", "OrdenesTrabajo", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idOrdenTrabajo As Integer, ByRef OrdenTrabajo As OrdenTrabajoInfo, checkStatus As Boolean)
        MyBase.GetDetail(idOrdenTrabajo, OrdenTrabajo, checkStatus)
        With OrdenTrabajo
            .Nombre = CStr(ItemInfo("Nombre"))
            .Fecha = CDate(ItemInfo("Fecha"))
            .IdArticuloStock = CInt(ItemInfo("IdArticuloStock"))
            .CantDeseada = CDec(ItemInfo("CantDeseada"))
            .CantRecibida = CDec(ItemInfo("CantRecibida"))
            .Version = CInt(ItemInfo("Version"))
            .IdOrdenTrabajoTipo = CInt(ItemInfo("IdOrdenTrabajoTipo"))
            .FechaPromEntrega = CDate(ItemInfo("FechaPromEntrega"))
            .FechaRecepcion = CDate(ItemInfo("FechaRecepcion"))
            If (ItemInfo("HoraLiberado") Is DBNull.Value) Then
                ._Aplicado = False
            Else
                ._Aplicado = True
                .HoraAplicado = CDate(ItemInfo("HoraLiberado"))
            End If

            If (ItemInfo("HoraCierre") Is DBNull.Value) Then
                ._Cerrado = False
            Else
                ._Cerrado = True
                .HoraCierre = CDate(ItemInfo("HoraCierre"))
            End If

            If (ItemInfo("FechaEnsambleUltimaRecepcion") IsNot DBNull.Value) Then
                .FechaEnsambleUltimaRecepcion = CDate(ItemInfo("FechaEnsambleUltimaRecepcion"))
            End If

            If (ItemInfo("FechaEnsambleUltimaEntrega") IsNot DBNull.Value) Then
                .FechaEnsambleUltimaEntrega = CDate(ItemInfo("FechaEnsambleUltimaEntrega"))
            End If

            .EntregasParciales = CBool(ItemInfo("EntregasParciales"))
            .ExigirRecepcion = CBool(ItemInfo("ExigirRecepcion"))
            .Observaciones = CStr(ItemInfo("Observaciones"))
            .IdCuenta = CInt(ItemInfo("IdCuenta"))
            .WorkFlowStatus = GetWorkFlowStatus(CShort(ItemInfo("IdWorkFlow")))
            .IdAlmacenInsumos = CInt(ItemInfo("IdAlmacenInsumos"))
            .IdAlmacenPT = CInt(ItemInfo("IdAlmacenPT"))
            .Insumos = LoadInsumosOT(.Identity)
            .Servicios = LoadServiciosOT(.Identity)
            .Ensambles = LoadEnsamblesOT(.Identity)
            .EnsambleSiguiente = GetEnsambleSiguienteSEL(.Identity)
            .EnsambleAnterior = GetEnsambleAnteriorSEL(.Identity)

            Dim EnsambleFac As New EnsambleFacade()
            Dim EnsambleSvc As New EnsambleService(Session.SessionID)
            Dim IncidenciaFac As New IncidenciaFacade()

            If (ItemInfo("IdEnsambleActual") IsNot DBNull.Value) Then
                If (CInt(ItemInfo("IdEnsambleActual")) > 0) Then
                    .EnsambleActual = EnsambleFac.GetDetail(Session.SessionID, CInt(ItemInfo("IdEnsambleActual")))
                    .EnsambleActual.Movimientos = LoadMovimientosByOT(idOrdenTrabajo, CInt(ItemInfo("IdEnsambleActual")))
                Else
                    .EnsambleActual = New EnsambleInfo(Session.SessionID)
                End If
            End If

            If (ItemInfo("IdIncidenciaActual") IsNot DBNull.Value) Then
                If (CInt(ItemInfo("IdIncidenciaActual")) > 0) Then
                    .IncidenciaActual = IncidenciaFac.GetDetail(Session.SessionID, CInt(ItemInfo("IdIncidenciaActual")))
                Else
                    .IncidenciaActual = New IncidenciaInfo(Session.SessionID)
                End If

            End If

            .FolioPedido = CStr(ItemInfo("FolioPedido"))
            .FechaRequerida = (CDate(ItemInfo("FechaRequerida")))
            If (ItemInfo("CantidadPlanillas") IsNot DBNull.Value) Then
                .CantidadPlanillas = CInt(ItemInfo("CantidadPlanillas"))
            Else
                .CantidadPlanillas = 0
            End If

            If (ItemInfo("Area") IsNot DBNull.Value) Then
                .Area = CStr(ItemInfo("Area"))
            Else
                .Area = String.Empty
            End If

            .Tipo = CStr(ItemInfo("Tipo"))


        End With
    End Sub

    Public Overrides Function Update(ByVal OrdenTrabajo As OrdenTrabajoInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = OrdenTrabajo.Nombre
            .Add("@Fecha", DbType.DateTime).Value = Date.Now()
            .Add("@IdArticuloStock", DbType.Int32).Value = OrdenTrabajo.IdArticuloStock
            .Add("@CantDeseada", DbType.Decimal).Value = OrdenTrabajo.CantDeseada
            .Add("@CantRecibida", DbType.Decimal).Value = OrdenTrabajo.CantRecibida
            .Add("@Version", DbType.Int32).Value = OrdenTrabajo.Version
            .Add("@IdOrdenTrabajoTipo", DbType.Int32).Value = OrdenTrabajo.IdOrdenTrabajoTipo
            .Add("@FechaPromEntrega", DbType.DateTime).Value = OrdenTrabajo.FechaPromEntrega
            .Add("@EntregasParciales", DbType.Boolean).Value = OrdenTrabajo.EntregasParciales
            .Add("@FechaRecepcion", DbType.Date).Value = OrdenTrabajo.FechaRecepcion
            .Add("@ExigirRecepcion", DbType.Boolean).Value = OrdenTrabajo.ExigirRecepcion
            .Add("@Observaciones", DbType.String).Value = OrdenTrabajo.Observaciones
            .Add("@IdCuenta", DbType.Int32).Value = OrdenTrabajo.IdCuenta
            .Add("@IdAlmacenInsumos", DbType.Int32).Value = OrdenTrabajo.IdAlmacenInsumos
            .Add("@IdAlmacenPT", DbType.Int32).Value = OrdenTrabajo.IdAlmacenPT
            .Add("@FolioPedido", DbType.String).Value = OrdenTrabajo.FolioPedido
            .Add("@FechaRequerida", DbType.DateTime).Value = OrdenTrabajo.FechaRequerida
            .Add("@CantidadPlanillas ", DbType.Int32).Value = OrdenTrabajo.CantidadPlanillas
            .Add("@Area", DbType.String).Value = OrdenTrabajo.Area
            .Add("@Tipo", DbType.String).Value = OrdenTrabajo.Tipo

        End With
        Dim ID As Integer = MyBase.Update(OrdenTrabajo)
        'Call saveInsumos(OrdenTrabajo)
        'Call saveEnsambles(OrdenTrabajo)

        Return ID
    End Function

    Public Overrides Function Create() As OrdenTrabajoInfo
        Return New OrdenTrabajoInfo(SessionID)
    End Function

#End Region


#Region "Metodos Privados"

    Public Function GetWorkFlowStatus(ByVal WorkFlowStatus As WorkFlowStatus) As Short
        Dim ValueStatus As Short = 0

        If (WorkFlowStatus = Produccion.WorkFlowStatus.Guardado) Then
            ValueStatus = 1
        ElseIf (WorkFlowStatus = Produccion.WorkFlowStatus.Liberado) Then
            ValueStatus = 2
        ElseIf (WorkFlowStatus = Produccion.WorkFlowStatus.EnEspera) Then
            ValueStatus = 3
        ElseIf (WorkFlowStatus = Produccion.WorkFlowStatus.Cerrado) Then
            ValueStatus = 4
        ElseIf (WorkFlowStatus = Produccion.WorkFlowStatus.Cancelado) Then
            ValueStatus = 5
        End If

        Return ValueStatus
    End Function

    Public Function GetWorkFlowStatus(ByVal IdWorkFlowStatus As Short) As WorkFlowStatus
        Dim WorkFlowStatus As WorkFlowStatus

        If (IdWorkFlowStatus = 1) Then
            WorkFlowStatus = Produccion.WorkFlowStatus.Guardado
        ElseIf (IdWorkFlowStatus = 2) Then
            WorkFlowStatus = Produccion.WorkFlowStatus.Liberado
        ElseIf (IdWorkFlowStatus = 3) Then
            WorkFlowStatus = Produccion.WorkFlowStatus.EnEspera
        ElseIf (IdWorkFlowStatus = 4) Then
            WorkFlowStatus = Produccion.WorkFlowStatus.Cerrado
        ElseIf (IdWorkFlowStatus = 5) Then
            WorkFlowStatus = Produccion.WorkFlowStatus.Cancelado
        End If

        Return WorkFlowStatus
    End Function

    'Private Sub loadArticulos(ByVal info As OrdenTrabajoInfo)
    '    Try
    '        info.Insumos.Rows.Clear()
    '        Dim fx As New FunctionSQL("Production", "[fxOrdenesTrabajoInsumosSEL]", Connection, Transaction)
    '        fx.Parameters.Add("@IdOrdenTrabajo", DbType.Int32).Value = info.Identity
    '        fx.FillDataTable(info.Insumos)
    '    Catch ex As Exception
    '        Throw New BusinessException("Error al cargar la lista de articulos.", ex)
    '    End Try

    'End Sub

    'Private Sub saveInsumos(ByVal info As OrdenTrabajoInfo)
    '    Try
    '        'Definir comando de actualización de detalle de racs
    '        Dim cmdInsert As New Azteca.Data.DbCommand("[Production].[OrdenesTrabajoInsumosUPD]", Connection, Transaction)
    '        cmdInsert.CommandType = CommandType.StoredProcedure

    '        cmdInsert.Parameters.Add("@IdOrdenTrabajo", DbType.Int32).Value = info.Identity
    '        cmdInsert.Parameters.Add("@IdArticuloStock", DbType.Int32, "IdArticuloStock")
    '        cmdInsert.Parameters.Add("@Cantidad", DbType.Decimal, "Cantidad")
    '        cmdInsert.Parameters.Add("@IdUnidadMedida", DbType.Int32, "IdUnidadMedida")
    '        cmdInsert.Parameters.Add("@Costo", DbType.Decimal, "Costo")
    '        cmdInsert.Parameters.Add("@Surtir", DbType.Boolean, "Surtir")

    '        Dim cmdDelete As New Azteca.Data.DbCommand("[Production].[OrdenesTrabajoInsumosDEL]", Connection, Transaction)
    '        cmdDelete.Parameters.Add("@IdOrdenTrabajo", DbType.Int32).Value = info.Identity
    '        cmdDelete.Parameters.Add("@IdArticuloStock", DbType.Int32, "IdArticuloStock")
    '        cmdDelete.CommandType = CommandType.StoredProcedure

    '        'Actualizar Articulos
    '        Dim da As New Azteca.Data.DataAdapter()
    '        da.UpdateCommand = cmdInsert
    '        da.InsertCommand = cmdInsert
    '        da.DeleteCommand = cmdDelete
    '        da.Update(info.Insumos)
    '    Catch concurrencyEx As System.Data.DBConcurrencyException
    '    Catch ex As Exception
    '        Throw New BusinessException("Error al guardar la lista de articulos.", ex)
    '    End Try

    'End Sub

    'Private Sub loadEnsambles(ByVal info As OrdenTrabajoInfo)
    '    Try
    '        info.Ensambles.Rows.Clear()
    '        Dim fx As New FunctionSQL("Production", "[fxOrdenesTrabajoEnsamblesSEL]", Connection, Transaction)
    '        fx.Parameters.Add("@IdOrdenTrabajo", DbType.Int32).Value = info.Identity
    '        fx.FillDataTable(info.Ensambles)
    '    Catch ex As Exception
    '        Throw New BusinessException("Error al cargar la lista de ensambles.", ex)
    '    End Try

    'End Sub

    'Private Sub saveEnsambles(ByVal info As OrdenTrabajoInfo)
    '    Try
    '        'Definir comando de actualización de detalle de racs
    '        Dim cmdInsert As New Azteca.Data.DbCommand("[Production].[OrdenesTrabajoEnsamblesUPD]", Connection, Transaction)
    '        cmdInsert.CommandType = CommandType.StoredProcedure

    '        cmdInsert.Parameters.Add("@IdOrdenTrabajo", DbType.Int32).Value = info.Identity
    '        cmdInsert.Parameters.Add("@IdEnsamble", DbType.Int32, "IdEnsamble")
    '        cmdInsert.Parameters.Add("@Orden", DbType.Int32, "Orden")

    '        Dim cmdDelete As New Azteca.Data.DbCommand("[Production].[OrdenesTrabajoEnsamblesDEL]", Connection, Transaction)
    '        cmdDelete.Parameters.Add("@IdOrdenTrabajo", DbType.Int32).Value = info.Identity
    '        cmdDelete.Parameters.Add("@IdEnsamble", DbType.Int32, "IdEnsamble")
    '        cmdDelete.CommandType = CommandType.StoredProcedure

    '        'Actualizar Articulos
    '        Dim da As New Azteca.Data.DataAdapter()
    '        da.UpdateCommand = cmdInsert
    '        da.InsertCommand = cmdInsert
    '        da.DeleteCommand = cmdDelete
    '        da.Update(info.Ensambles)
    '    Catch concurrencyEx As System.Data.DBConcurrencyException
    '    Catch ex As Exception
    '        Throw New BusinessException("Error al guardar la lista de articulos.", ex)
    '    End Try

    'End Sub

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de OrdenesTrabajo
''' </summary>
''' <remarks></remarks>
Public Class OrdenTrabajoFacade
    Inherits CatalogFacade(Of OrdenTrabajoInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un OrdenTrabajoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As Guid) As OrdenTrabajoInfo
        Dim OrdenTrabajoSvc As New OrdenTrabajoService(sessionID)
        Return OrdenTrabajoSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de OrdenesTrabajo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idOrdenTrabajo">Identificador del OrdenTrabajo que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As Guid, ByVal idOrdenTrabajo As Integer)
        Dim OrdenTrabajoSvc As New OrdenTrabajoService(sessionID)
        Delete(OrdenTrabajoSvc, idOrdenTrabajo)
    End Sub

    ''' <summary>
    ''' Verifica si existe un OrdenTrabajo con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idOrdenTrabajo">ID de OrdenTrabajo que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As Guid, ByVal idOrdenTrabajo As Integer) As Boolean
        Dim OrdenTrabajoSvc As New OrdenTrabajoService(sessionID)
        Return Exists(OrdenTrabajoSvc, idOrdenTrabajo)
    End Function

    ''' <summary>
    ''' Verifica si existe un OrdenTrabajo con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim OrdenTrabajoSvc As New OrdenTrabajoService(sessionID)
        Return Exists(OrdenTrabajoSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un OrdenTrabajo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idOrdenTrabajo">Identificador de OrdenTrabajo a consultar</param>
    ''' <returns>Paquete de información de tipo OrdenTrabajoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As Guid, ByVal idOrdenTrabajo As Integer) As OrdenTrabajoInfo
        Return Me.GetDetail(sessionID, idOrdenTrabajo, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un OrdenTrabajo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idOrdenTrabajo">Identificador de OrdenTrabajo</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del OrdenTrabajo.</param>
    ''' <returns>Paquete de información de tipo OrdenTrabajoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As Guid, ByVal idOrdenTrabajo As Integer, checkStatus As Boolean) As OrdenTrabajoInfo
        Dim OrdenTrabajoSvc As New OrdenTrabajoService(sessionID)
        Dim OrdenTrabajoInf As New OrdenTrabajoInfo(sessionID)
        GetDetail(OrdenTrabajoSvc, OrdenTrabajoInf, idOrdenTrabajo, checkStatus)
        Return OrdenTrabajoInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un OrdenTrabajo en base a su codigo de usuario
    ''' y verifica que el OrdenTrabajo esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información OrdenTrabajoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As OrdenTrabajoInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un OrdenTrabajo en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del OrdenTrabajo</param>
    ''' <returns>Paquete de información OrdenTrabajoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As Guid, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As OrdenTrabajoInfo
        Dim OrdenTrabajoInf As New OrdenTrabajoInfo(sessionID)
        Dim OrdenTrabajoSvc As New OrdenTrabajoService(sessionID)
        GetDetail(OrdenTrabajoSvc, OrdenTrabajoInf, userCode, idSucursal, checkStatus)
        Return OrdenTrabajoInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un OrdenTrabajo.
    ''' </summary>
    ''' <param name="OrdenTrabajo">Paquete de información del tipo OrdenTrabajoInfo con la información a actualizar</param>
    ''' <returns>Identificador de OrdenTrabajo, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal OrdenTrabajo As OrdenTrabajoInfo) As Integer
        Dim OrdenTrabajoSvc As New OrdenTrabajoService(OrdenTrabajo.SessionID)
        Return Update(OrdenTrabajoSvc, OrdenTrabajo)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim OrdenTrabajoSvc As New OrdenTrabajoService(sessionID)
        Return GetNumberOfPages(OrdenTrabajoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca OrdenesTrabajo que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca OrdenesTrabajo que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim OrdenTrabajoSvc As New OrdenTrabajoService(sessionID)
        Return GetSearchResult(OrdenTrabajoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de OrdenesTrabajo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As Guid) As System.Data.DataSet
        Dim OrdenTrabajoSvc As New OrdenTrabajoService(sessionID)
        Return GetSearchStructure(OrdenTrabajoSvc)
    End Function

#End Region

End Class
