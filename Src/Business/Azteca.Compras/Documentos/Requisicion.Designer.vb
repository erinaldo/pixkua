''' <summary>
''' Paquete de información que representa un Requisicion
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class RequisicionInfo
	Inherits DocumentInfo
	
#Region "Variables Privadas"

#End Region

#Region "Propiedades"
    Public Property IdArticuloStock As Integer

    Public Property IdServicio As Integer

    Public Property IdRequisicionTipo As Integer

    Public Property IdDepartamento As Integer

    Public Property IdPresupuesto As Integer

    Public Property IdCentroRecepcion As Integer

    Public Property Observaciones As String

    Public Property Cantidad As Decimal

    Public Property IdUnidadMedida As Integer

    Public Property IdCategoriaPresupuestal As Integer

    Public Property IdOrdenTit As String

    Public Property FechaOrden As Date


    '  'Se debe de agregar un Dataset con este nombre y con esta tabla incluida.
    '  'Esta tabla es el resultado simetrico de la funcion fxRequisicionDetSEL
    '   Public ReadOnly Property Details() As DetalleRequisicionDS.DetalleDataTableDataTable
    '        Get
    '            Return CType(DetailsTable, DetalleRequisicionDS.DetalleDataTable)
    '        End Get
    '    End Property
#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As Guid)
        MyBase.New(sessionID)
        '' DetailsTable = New DetalleRequisicionDS.DetalleDataTable
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Requisiciones
''' </summary>
''' <remarks></remarks>
Public Class RequisicionService
    Inherits DocumentService(Of RequisicionInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As guid)
        Me.New(sessionID, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As guid, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As guid, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Purchasing", "Requisiciones", "", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub

#End Region



#Region "Metodos de DocumentService"

    Public Overrides Sub ApplyWorkflow(ByVal IdRequisicion As String, ByVal IdStatus As Integer, ByVal FechaTrabajo As Date)
        MyBase.ApplyWorkflow(IdRequisicion, IdStatus, FechaTrabajo)
    End Sub

    Public Overrides Sub CancelWorkflow(ByVal IdRequisicion As String, ByVal IdStatus As Integer)
        MyBase.CancelWorkflow(IdRequisicion, IdStatus)
    End Sub


    Public Overrides Function Create() As RequisicionInfo
        Return New RequisicionInfo(SessionID)
    End Function


    Public Overrides Sub GetDetail(ByVal idRequisicion As String, ByRef Requisicion As RequisicionInfo)
        MyBase.GetDetail(idRequisicion, Requisicion)
        With Requisicion
            .IdRequisicionTipo = CInt(DocInfo("IdRequisicionTipo"))
            .IdDepartamento = CInt(DocInfo("IdDepartamento"))
            .IdPresupuesto = CInt(DocInfo("IdPresupuesto"))
            .IdCentroRecepcion = CInt(DocInfo("IdCentroRecepcion"))
            .IdArticuloStock = CInt(DocInfo("IdArticuloStock"))
            .IdServicio = CInt(DocInfo("IdServicio"))
            .Cantidad = CDec(DocInfo("Cantidad"))
            .IdUnidadMedida = CInt(DocInfo("IdUnidadMedida"))
            .IdCategoriaPresupuestal = CInt(DocInfo("IdCategoriaPresupuestal"))
            .Observaciones = CStr(DocInfo("Observaciones"))
            .IdOrdenTit = CStr(DocInfo("IdOrdenTit"))
            If Not IsDBNull(DocInfo("FechaOrden")) Then .FechaOrden = CDate(DocInfo("FechaOrden"))

        End With
    End Sub

    Public Overrides Function Update(ByVal Requisicion As RequisicionInfo) As RequisicionInfo
        With Me.SPUpdate.Parameters
            .Add("@IdArticuloStock", DbType.Int32).Value = Requisicion.IdArticuloStock
            .Add("@IdServicio", DbType.Int32).Value = Requisicion.IdServicio
            .Add("@IdRequisicionTipo", DbType.Int32).Value = Requisicion.IdRequisicionTipo
            .Add("@IdDepartamento", DbType.Int32).Value = Requisicion.IdDepartamento
            .Add("@IdPresupuesto", DbType.Int32).Value = Requisicion.IdPresupuesto
            .Add("@IdCentroRecepcion", DbType.Int32).Value = Requisicion.IdCentroRecepcion
            .Add("@Observaciones", DbType.String).Value = Requisicion.Observaciones
            .Add("@Cantidad", DbType.Decimal).Value = Requisicion.Cantidad
            .Add("@IdUnidadMedida", DbType.Int32).Value = Requisicion.IdUnidadMedida
            .Add("@IdCategoriaPresupuestal", DbType.Int32).Value = Requisicion.IdCategoriaPresupuestal
            '.Add("@IdOrdenTit", DbType.String).Value = Requisicion.IdOrdenTit
            '.Add("@FechaOrden", DbType.DateTime).Value = Requisicion.FechaOrden
        End With
        Return MyBase.Update(Requisicion)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del documento de Requisiciones
''' </summary>
''' <remarks></remarks>
Public Class RequisicionFacade
    Inherits DocumentFacade(Of RequisicionInfo)

#Region "Metodos de DocumentFacade"

    ''' <summary>
    ''' Generar las acciones necesarias para el flujo de trabajo RequisicionInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Sub ApplyWorkflow(ByVal sessionID As Guid, ByVal IdRequisicion As String, ByVal IdStatus As Integer, ByVal FechaTrabajo As Date)
        Dim RequisicionSvc As New RequisicionService(sessionID)
        ApplyWorkflow(RequisicionSvc, IdRequisicion, IdStatus, FechaTrabajo)
    End Sub

    ''' <summary>
    ''' Cancelar las acciones de regreso al flujo de trabajo RequisicionInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Sub CancelWorkflow(ByVal sessionID As Guid, ByVal IdRequisicion As String, ByVal IdStatus As Integer)
        Dim RequisicionSvc As New RequisicionService(sessionID)
        CancelWorkflow(RequisicionSvc, IdRequisicion, IdStatus)
    End Sub


    ''' <summary>
    ''' Crea una nueva instancia de un RequisicionInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As Guid) As RequisicionInfo
        Dim RequisicionSvc As New RequisicionService(sessionID)
        Return RequisicionSvc.Create()
    End Function

    ''' <summary>
    ''' Actualiza la información de un Requisicion.
    ''' </summary>
    ''' <param name="Requisicion">Paquete de información del tipo RequisicionInfo con la información a actualizar</param>
    ''' <returns>Identificador de Requisicion, si es nuevo, regresa el .</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Requisicion As RequisicionInfo) As RequisicionInfo
        Dim RequisicionSvc As New RequisicionService(Requisicion.SessionID)
        Return Update(RequisicionSvc, CType(Requisicion, RequisicionInfo))
    End Function


    ''' <summary>
    ''' Elimina un elemento del documento de Requisiciones
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idRequisicion">Identificador del Requisicion que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As Guid, ByVal idRequisicion As String)
        Dim RequisicionSvc As New RequisicionService(sessionID)
        Delete(RequisicionSvc, idRequisicion)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Requisicion con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idRequisicion">ID de Requisicion que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As Guid, ByVal idRequisicion As String) As Boolean
        Dim RequisicionSvc As New RequisicionService(sessionID)
        Return Exists(RequisicionSvc, idRequisicion)
    End Function


    ''' <summary>
    ''' Obtiene la información de un Requisicion.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idRequisicion">Identificador de Requisicion a consultar</param>
    ''' <returns>Paquete de información de tipo RequisicionInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As Guid, ByVal idRequisicion As String) As RequisicionInfo
        Return Me.GetDetail(sessionID, idRequisicion, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Requisicion.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idRequisicion">Identificador de Requisicion</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Requisicion.</param>
    ''' <returns>Paquete de información de tipo RequisicionInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As guid, ByVal idRequisicion As String, ByVal checkStatus As Boolean) As RequisicionInfo
        Dim RequisicionSvc As New RequisicionService(sessionID)
        Dim RequisicionInf As New RequisicionInfo(sessionID)
        GetDetail(RequisicionSvc, RequisicionInf, idRequisicion)
        Return RequisicionInf
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim RequisicionSvc As New RequisicionService(sessionID)
        Return GetNumberOfPages(RequisicionSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Requisiciones que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Dim RequisicionSvc As New RequisicionService(sessionID)
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca Requisiciones que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim RequisicionSvc As New RequisicionService(sessionID)
        Return GetSearchResult(RequisicionSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Requisiciones.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As guid) As System.Data.DataSet
        Dim RequisicionSvc As New RequisicionService(sessionID)
        Return GetSearchStructure(RequisicionSvc)
    End Function

#End Region

End Class
