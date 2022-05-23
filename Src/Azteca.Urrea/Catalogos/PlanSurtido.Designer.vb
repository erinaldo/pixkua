Imports Azteca.Kernel.BusinessStructure
Imports Azteca.Kernel.Search

''' <summary>
''' Paquete de información que representa un PlanSurtido
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class PlanSurtidoInfo
    Inherits CatalogInfo

#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Referencia As String

    Public Property Version As Short

    Public Property HoraInicio As Date

    Public Property LineasReales As Date

    Public Property CantEmpacadores As Integer

    Public Property CantSurtidores As Integer

    Public Property CajasCompletas As PlanSurtidoDS.PlanesCajasCompletasDataTable

#End Region

#Region "Constructor"
    Public Sub New(ByVal session As Guid)

        MyBase.New(session)
        CajasCompletas = New PlanSurtidoDS.PlanesCajasCompletasDataTable()
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de PlanesSurtido
''' </summary>
''' <remarks></remarks>
Partial Public Class PlanSurtidoService
    Inherits CatalogService(Of PlanSurtidoInfo)

#Region "Constructores"
    Public Sub New(ByVal session As Guid)
        Me.New(session, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal session As Guid, ByVal cnn As IDbConnection)
        Me.New(session, cnn, Nothing)
    End Sub

    Public Sub New(ByVal session As Guid, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("CDU", "PlanesSurtido", session)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idPlanSurtido As Integer, ByRef PlanSurtido As PlanSurtidoInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idPlanSurtido, PlanSurtido, checkStatus)
        With PlanSurtido
            .Referencia = CStr(ItemInfo("Referencia"))
            .Version = CShort(ItemInfo("Version"))
            .HoraInicio = CDate(ItemInfo("HoraInicio"))
            .LineasReales = CDate(ItemInfo("LineasReales"))
            .CantEmpacadores = CInt(ItemInfo("CantEmpacadores"))
            .CantSurtidores = CInt(ItemInfo("CantSurtidores"))
            .IdEmpresa = CInt(ItemInfo("IdEmpresa"))

            .CajasCompletas = GetLines(idPlanSurtido)

        End With
    End Sub

    Private Function GetLines(ByVal idPlanSurtido As Integer) As PlanSurtidoDS.PlanesCajasCompletasDataTable
        Dim dtList As New PlanSurtidoDS.PlanesCajasCompletasDataTable()
        Try
            Dim fxList As New FunctionSQL("[CDU]", "[fxPlanesSurtidoLineLST]", Connection, Transaction)
            fxList.Parameters.Add("@IdPlanSurtido", DbType.Int32).Value = idPlanSurtido
            fxList.FillDataTable(dtList)
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al obtener el detalle del plan de surtido", ex)
        End Try
    End Function

    Public Overrides Function Update(ByVal PlanSurtido As PlanSurtidoInfo) As Integer
        Dim identity As Integer
        With Me.SPUpdate.Parameters
            .Add("@Referencia", DbType.String).Value = PlanSurtido.Referencia
            .Add("@Version", DbType.Int16).Value = PlanSurtido.Version
            .Add("@HoraInicio", DbType.DateTime).Value = PlanSurtido.HoraInicio
            .Add("@LineasReales", DbType.DateTime).Value = PlanSurtido.LineasReales
            .Add("@CantEmpacadores", DbType.Int32).Value = PlanSurtido.CantEmpacadores
            .Add("@CantSurtidores", DbType.Int32).Value = PlanSurtido.CantSurtidores
        End With

        identity = MyBase.Update(PlanSurtido)
        SaveLines(PlanSurtido)

        Return identity
    End Function

    Private Sub SaveLines(ByVal info As PlanSurtidoInfo)
        Try
            Dim cmdUPD As New DbCommand("CDU.PlanesSurtidoLineUPD", Connection, Transaction)

            cmdUPD.Parameters.Add("IdPlanSurtidoLine", DbType.Int32, "IdPlanSurtidoLine")
            cmdUPD.Parameters.Add("IdPlanSurtido", DbType.Int32).Value = info.Identity
            cmdUPD.Parameters.Add("IdGrupoAreaSurtido", DbType.Int32, "IdGrupoAreaSurtido")
            cmdUPD.Parameters.Add("IdAreaSurtido", DbType.Int32, "IdAreaSurtido")
            cmdUPD.Parameters.Add("CantidadOrdenado", DbType.Decimal, "CantCajaLineaOrdenado")
            cmdUPD.Parameters.Add("CapacidadHoraXUsuario", DbType.Int32, "CapacidadHoraXUsuario")
            cmdUPD.Parameters.Add("CantUsuariosDef", DbType.Int32, "CantUsuarios")
            cmdUPD.Parameters.Add("UsuarioAsignado", DbType.String, "UsuarioAsignado")
            cmdUPD.Parameters.Add("Operario", DbType.String, "Operario")
            cmdUPD.Parameters.Add("H7", DbType.Int32, "H7")
            cmdUPD.Parameters.Add("H8", DbType.Int32, "H8")
            cmdUPD.Parameters.Add("H9", DbType.Int32, "H9")
            cmdUPD.Parameters.Add("H10", DbType.Int32, "H10")
            cmdUPD.Parameters.Add("H11", DbType.Int32, "H11")
            cmdUPD.Parameters.Add("H12", DbType.Int32, "H12")
            cmdUPD.Parameters.Add("H13", DbType.Int32, "H13")
            cmdUPD.Parameters.Add("H14", DbType.Int32, "H14")
            cmdUPD.Parameters.Add("H15", DbType.Int32, "H15")
            cmdUPD.Parameters.Add("H16", DbType.Int32, "H16")
            cmdUPD.Parameters.Add("H17", DbType.Int32, "H17")
            cmdUPD.Parameters.Add("H18", DbType.Int32, "H18")
            cmdUPD.Parameters.Add("H19", DbType.Int32, "H19")
            cmdUPD.Parameters.Add("H20", DbType.Int32, "H20")
            cmdUPD.Parameters.Add("H21", DbType.Int32, "H21")
            cmdUPD.Parameters.Add("H22", DbType.Int32, "H22")
            cmdUPD.Parameters.Add("@UserUpdate", DbType.Int32).Value = info.UserUpdate
            cmdUPD.CommandType = CommandType.StoredProcedure

            Dim da As New DataAdapter()
            da.InsertCommand = cmdUPD
            da.UpdateCommand = cmdUPD

            da.Update(info.CajasCompletas)
            info.CajasCompletas.AcceptChanges()

        Catch ex As Exception
            Throw New Exception("Error al actualizar las lineas de la planeación", ex)
        End Try
    End Sub

    Public Overrides Function Create() As PlanSurtidoInfo
        Return New PlanSurtidoInfo(SessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de PlanesSurtido
''' </summary>
''' <remarks></remarks>
Partial Public Class PlanSurtidoFacade
    Inherits CatalogFacade(Of PlanSurtidoInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un PlanSurtidoInfo
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal session As Guid) As PlanSurtidoInfo
        Dim PlanSurtidoSvc As New PlanSurtidoService(session)
        Return PlanSurtidoSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de PlanesSurtido
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idPlanSurtido">Identificador del PlanSurtido que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal session As Guid, ByVal idPlanSurtido As Integer)
        Dim PlanSurtidoSvc As New PlanSurtidoService(session)
        Delete(PlanSurtidoSvc, idPlanSurtido)
    End Sub

    ''' <summary>
    ''' Verifica si existe un PlanSurtido con el Identificador especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idPlanSurtido">ID de PlanSurtido que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal session As Guid, ByVal idPlanSurtido As Integer) As Boolean
        Dim PlanSurtidoSvc As New PlanSurtidoService(session)
        Return Exists(PlanSurtidoSvc, idPlanSurtido)
    End Function

    ''' <summary>
    ''' Verifica si existe un PlanSurtido con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim PlanSurtidoSvc As New PlanSurtidoService(session)
        Return Exists(PlanSurtidoSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un PlanSurtido.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idPlanSurtido">Identificador de PlanSurtido a consultar</param>
    ''' <returns>Paquete de información de tipo PlanSurtidoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As Guid, ByVal idPlanSurtido As Integer) As PlanSurtidoInfo
        Return Me.GetDetail(session, idPlanSurtido, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un PlanSurtido.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idPlanSurtido">Identificador de PlanSurtido</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del PlanSurtido.</param>
    ''' <returns>Paquete de información de tipo PlanSurtidoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As Guid, ByVal idPlanSurtido As Integer, ByVal checkStatus As Boolean) As PlanSurtidoInfo
        Dim PlanSurtidoSvc As New PlanSurtidoService(session)
        Dim PlanSurtidoInf As New PlanSurtidoInfo(session)
        GetDetail(PlanSurtidoSvc, PlanSurtidoInf, idPlanSurtido, checkStatus)
        Return PlanSurtidoInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un PlanSurtido en base a su codigo de usuario
    ''' y verifica que el PlanSurtido esté activo.
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información PlanSurtidoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As PlanSurtidoInfo
        Return Me.GetDetail(session, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un PlanSurtido en base a su codigo de usuario
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del PlanSurtido</param>
    ''' <returns>Paquete de información PlanSurtidoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As PlanSurtidoInfo
        Dim PlanSurtidoInf As New PlanSurtidoInfo(session)
        Dim PlanSurtidoSvc As New PlanSurtidoService(session)
        GetDetail(PlanSurtidoSvc, PlanSurtidoInf, userCode, idSucursal, checkStatus)
        Return PlanSurtidoInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un PlanSurtido.
    ''' </summary>
    ''' <param name="PlanSurtido">Paquete de información del tipo PlanSurtidoInfo con la información a actualizar</param>
    ''' <returns>Identificador de PlanSurtido, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal PlanSurtido As PlanSurtidoInfo) As Integer
        Dim PlanSurtidoSvc As New PlanSurtidoService(PlanSurtido.SessionID)
        Return Update(PlanSurtidoSvc, PlanSurtido)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal session As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim PlanSurtidoSvc As New PlanSurtidoService(session)
        Return GetNumberOfPages(PlanSurtidoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca PlanesSurtido que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal session As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(session, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca PlanesSurtido que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal session As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim PlanSurtidoSvc As New PlanSurtidoService(session)
        Return GetSearchResult(PlanSurtidoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de PlanesSurtido.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal session As Guid) As System.Data.DataSet
        Dim PlanSurtidoSvc As New PlanSurtidoService(session)
        Return GetSearchStructure(PlanSurtidoSvc)
    End Function

#End Region

End Class
