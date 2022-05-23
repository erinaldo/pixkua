''' <summary>
''' Paquete de información que representa un GrupoClasificaciones
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class GrupoClasificacionesInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"
    Private _Clasificaciones As ClasificacionesDS.ClasificacionesDataTable
#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property Requerido As Boolean

    Public Property IdEntidad As Integer

    Public ReadOnly Property Clasificaciones As ClasificacionesDS.ClasificacionesDataTable
        Get
            Return _Clasificaciones
        End Get
    End Property

#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
        _Clasificaciones = New ClasificacionesDS.ClasificacionesDataTable
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de ClasificacionesGrupos
''' </summary>
''' <remarks></remarks>
Public Class GrupoClasificacionesService
    Inherits CatalogService(Of GrupoClasificacionesInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Inventory", "ClasificacionesGrupos", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos Privados"

    Private Sub CargarClasificaciones(ByVal idGrupo As Integer, ByVal grupo As GrupoClasificacionesInfo)
        Try
            Dim fxClasificaciones As New FunctionSQL("Inventory", "fxClasificacionesSEL", Connection, Transaction)
            fxClasificaciones.Parameters.Add("@IdGrupo", DbType.Int32).Value = idGrupo
            fxClasificaciones.FillDataTable(grupo.Clasificaciones)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar las clasificaciones del grupo.", ex)
        End Try
    End Sub

    Private Sub GuardarClasificaciones(ByVal idGrupo As Integer, ByVal grupo As GrupoClasificacionesInfo)
        Try
            Dim comUpdate As New DbCommand("Inventory.ClasificacionesUPD", Connection, Transaction)
            comUpdate.CommandType = CommandType.StoredProcedure
            comUpdate.Parameters.Add("@IdClasificacion", DbType.Int32, "IdClasificacion")
            comUpdate.Parameters.Add("@IdClasificacionGrupo", DbType.Int32).Value = idGrupo
            comUpdate.Parameters.Add("@Nombre", DbType.String, "Nombre")
            comUpdate.Parameters.Add("@Valor", DbType.Int32, "Valor")
            comUpdate.Parameters.Add("@Referencia", DbType.String, "Referencia")
            comUpdate.Parameters.Add("@IdCuenta", DbType.Int32, "IdCuenta")
            '
            Dim comDelete As New DbCommand("Inventory.ClasificacionesDEL", Connection, Transaction)
            comDelete.CommandType = CommandType.StoredProcedure
            comDelete.Parameters.Add("@IdClasificacion", DbType.Int32, "IdClasificacion")
            '
            Dim da As New DataAdapter()
            da.InsertCommand = comUpdate
            da.UpdateCommand = comUpdate
            da.DeleteCommand = comDelete
            da.Update(grupo.Clasificaciones)
        Catch concurrencyEx As DBConcurrencyException

        Catch ex As Exception
            Throw New BusinessException("Error al guardar las clasificaciones del grupo.", ex)
        End Try
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idGrupoClasificaciones As Integer, ByRef GrupoClasificaciones As GrupoClasificacionesInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idGrupoClasificaciones, GrupoClasificaciones, checkStatus)
        With GrupoClasificaciones
            .Nombre = CStr(ItemInfo("Nombre"))
            .Requerido = CBool(ItemInfo("Requerido"))
            .IdEntidad = CInt(ItemInfo("IdClasificacionEntidad"))
        End With
        CargarClasificaciones(idGrupoClasificaciones, GrupoClasificaciones)
    End Sub

    Public Overrides Function Update(ByVal GrupoClasificaciones As GrupoClasificacionesInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = GrupoClasificaciones.Nombre
            .Add("@Requerido", DbType.Boolean).Value = GrupoClasificaciones.Requerido
            .Add("@IdClasificacionEntidad", DbType.Int32).Value = GrupoClasificaciones.IdEntidad
        End With
        Dim IdGrupo As Integer = MyBase.Update(GrupoClasificaciones)
        GuardarClasificaciones(IdGrupo, GrupoClasificaciones)
        Return IdGrupo
    End Function

    Public Overrides Function Create() As GrupoClasificacionesInfo
        Return New GrupoClasificacionesInfo(sessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de ClasificacionesGrupos
''' </summary>
''' <remarks></remarks>
Public Class GrupoClasificacionesFacade
    Inherits CatalogFacade(Of GrupoClasificacionesInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un GrupoClasificacionesInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As GrupoClasificacionesInfo
        Dim GrupoClasificacionesSvc As New GrupoClasificacionesService(sessionID)
        Return GrupoClasificacionesSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de ClasificacionesGrupos
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idGrupoClasificaciones">Identificador del GrupoClasificaciones que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idGrupoClasificaciones As Integer)
        Dim GrupoClasificacionesSvc As New GrupoClasificacionesService(sessionID)
        Delete(GrupoClasificacionesSvc, idGrupoClasificaciones)
    End Sub

    ''' <summary>
    ''' Verifica si existe un GrupoClasificaciones con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idGrupoClasificaciones">ID de GrupoClasificaciones que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idGrupoClasificaciones As Integer) As Boolean
        Dim GrupoClasificacionesSvc As New GrupoClasificacionesService(sessionID)
        Return Exists(GrupoClasificacionesSvc, idGrupoClasificaciones)
    End Function

    ''' <summary>
    ''' Verifica si existe un GrupoClasificaciones con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim GrupoClasificacionesSvc As New GrupoClasificacionesService(sessionID)
        Return Exists(GrupoClasificacionesSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un GrupoClasificaciones.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idGrupoClasificaciones">Identificador de GrupoClasificaciones a consultar</param>
    ''' <returns>Paquete de información de tipo GrupoClasificacionesInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idGrupoClasificaciones As Integer) As GrupoClasificacionesInfo
        Return Me.GetDetail(sessionID, idGrupoClasificaciones, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un GrupoClasificaciones.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idGrupoClasificaciones">Identificador de GrupoClasificaciones</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del GrupoClasificaciones.</param>
    ''' <returns>Paquete de información de tipo GrupoClasificacionesInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idGrupoClasificaciones As Integer, ByVal checkStatus As Boolean) As GrupoClasificacionesInfo
        Dim GrupoClasificacionesSvc As New GrupoClasificacionesService(sessionID)
        Dim GrupoClasificacionesInf As New GrupoClasificacionesInfo(sessionID)
        GetDetail(GrupoClasificacionesSvc, GrupoClasificacionesInf, idGrupoClasificaciones, checkStatus)
        Return GrupoClasificacionesInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un GrupoClasificaciones en base a su codigo de usuario
    ''' y verifica que el GrupoClasificaciones esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información GrupoClasificacionesInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As GrupoClasificacionesInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un GrupoClasificaciones en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del GrupoClasificaciones</param>
    ''' <returns>Paquete de información GrupoClasificacionesInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As GrupoClasificacionesInfo
        Dim GrupoClasificacionesInf As New GrupoClasificacionesInfo(sessionID)
        Dim GrupoClasificacionesSvc As New GrupoClasificacionesService(sessionID)
        GetDetail(GrupoClasificacionesSvc, GrupoClasificacionesInf, userCode, idSucursal, checkStatus)
        Return GrupoClasificacionesInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un GrupoClasificaciones.
    ''' </summary>
    ''' <param name="GrupoClasificaciones">Paquete de información del tipo GrupoClasificacionesInfo con la información a actualizar</param>
    ''' <returns>Identificador de GrupoClasificaciones, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal GrupoClasificaciones As GrupoClasificacionesInfo) As Integer
        Dim GrupoClasificacionesSvc As New GrupoClasificacionesService(GrupoClasificaciones.SessionID)
        Return Update(GrupoClasificacionesSvc, GrupoClasificaciones)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim GrupoClasificacionesSvc As New GrupoClasificacionesService(sessionID)
        Return GetNumberOfPages(GrupoClasificacionesSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca ClasificacionesGrupos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca ClasificacionesGrupos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim GrupoClasificacionesSvc As New GrupoClasificacionesService(sessionID)
        Return GetSearchResult(GrupoClasificacionesSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de ClasificacionesGrupos.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim GrupoClasificacionesSvc As New GrupoClasificacionesService(sessionID)
        Return GetSearchStructure(GrupoClasificacionesSvc)
    End Function

#End Region

End Class
