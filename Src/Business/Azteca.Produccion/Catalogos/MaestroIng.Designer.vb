''' <summary>
''' Paquete de informaci�n que representa un MaestroIng
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class MaestroIngInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property Fecha As Date

    Public Property IdArticuloStock As Integer

    Public Property CantDeseada As Decimal

    Public Property Version As Integer

    Public Property IdEmpresa As Integer

    Public Property Insumos As MaestrosIngDS.InsumosDataTable

    Public Property Ensambles As MaestrosIngDS.EnsamblesDataTable

#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As Guid)
        MyBase.New(sessionID)

        'Inicializacion
        Insumos = New MaestrosIngDS.InsumosDataTable
        Ensambles = New MaestrosIngDS.EnsamblesDataTable
    End Sub
#End Region
	
End Class


''' <summary>
''' Proveedor de servicios para el manejo del cat�logo de MaestrosIng
''' </summary>
''' <remarks></remarks>
Public Class MaestroIngService
	Inherits CatalogService(Of MaestroIngInfo)
	
#Region "Constructores"
    Public Sub New(ByVal sessionID As Guid)
        Me.New(sessionID, Nothing, Nothing)

        
    End Sub

    Public Sub New(ByVal sessionID As Guid, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As Guid, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Production", "MaestrosIng", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idMaestroIng As Integer, ByRef MaestroIng As MaestroIngInfo, checkStatus As Boolean)
        MyBase.GetDetail(idMaestroIng, MaestroIng, checkStatus)
        With MaestroIng
            .Nombre = CStr(ItemInfo("Nombre"))
            .Fecha = CDate(ItemInfo("Fecha"))
            .IdArticuloStock = CInt(ItemInfo("IdArticuloStock"))
            .CantDeseada = CDec(ItemInfo("CantDeseada"))
            .Version = CInt(ItemInfo("Version"))

        End With
    End Sub

    Public Overrides Function Update(ByVal MaestroIng As MaestroIngInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = MaestroIng.Nombre
            .Add("@Fecha", DbType.Date).Value = Date.Now()
            .Add("@IdArticuloStock", DbType.Int32).Value = MaestroIng.IdArticuloStock
            .Add("@CantDeseada", DbType.Decimal).Value = MaestroIng.CantDeseada
            .Add("@Version", DbType.Int32).Value = MaestroIng.Version

        End With
        Return MyBase.Update(MaestroIng)
    End Function

    Public Overrides Function Create() As MaestroIngInfo
        Return New MaestroIngInfo(SessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del cat�logo de MaestrosIng
''' </summary>
''' <remarks></remarks>
Public Class MaestroIngFacade
    Inherits CatalogFacade(Of MaestroIngInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un MaestroIngInfo
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As Guid) As MaestroIngInfo
        Dim MaestroIngSvc As New MaestroIngService(sessionID)
        Return MaestroIngSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del cat�logo de MaestrosIng
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idMaestroIng">Identificador del MaestroIng que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As Guid, ByVal idMaestroIng As Integer)
        Dim MaestroIngSvc As New MaestroIngService(sessionID)
        Delete(MaestroIngSvc, idMaestroIng)
    End Sub

    ''' <summary>
    ''' Verifica si existe un MaestroIng con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idMaestroIng">ID de MaestroIng que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As Guid, ByVal idMaestroIng As Integer) As Boolean
        Dim MaestroIngSvc As New MaestroIngService(sessionID)
        Return Exists(MaestroIngSvc, idMaestroIng)
    End Function

    ''' <summary>
    ''' Verifica si existe un MaestroIng con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario b�scado</param>
    ''' <returns>True si existe un usuario con ese c�digo, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim MaestroIngSvc As New MaestroIngService(sessionID)
        Return Exists(MaestroIngSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un MaestroIng.
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idMaestroIng">Identificador de MaestroIng a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo MaestroIngInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As Guid, ByVal idMaestroIng As Integer) As MaestroIngInfo
        Return Me.GetDetail(sessionID, idMaestroIng, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un MaestroIng.
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idMaestroIng">Identificador de MaestroIng</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del MaestroIng.</param>
    ''' <returns>Paquete de informaci�n de tipo MaestroIngInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As Guid, ByVal idMaestroIng As Integer, checkStatus As Boolean) As MaestroIngInfo
        Dim MaestroIngSvc As New MaestroIngService(sessionID)
        Dim MaestroIngInf As New MaestroIngInfo(sessionID)
        GetDetail(MaestroIngSvc, MaestroIngInf, idMaestroIng, checkStatus)
        Return MaestroIngInf
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un MaestroIng en base a su codigo de usuario
    ''' y verifica que el MaestroIng est� activo.
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesion</param>
    ''' <param name="userCode">C�digo de usuario a buscar</param>
    ''' <returns>Paquete de informaci�n MaestroIngInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As MaestroIngInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un MaestroIng en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del MaestroIng</param>
    ''' <returns>Paquete de informaci�n MaestroIngInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As Guid, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As MaestroIngInfo
        Dim MaestroIngInf As New MaestroIngInfo(sessionID)
        Dim MaestroIngSvc As New MaestroIngService(sessionID)
        GetDetail(MaestroIngSvc, MaestroIngInf, userCode, idSucursal, checkStatus)
        Return MaestroIngInf
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un MaestroIng.
    ''' </summary>
    ''' <param name="MaestroIng">Paquete de informaci�n del tipo MaestroIngInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de MaestroIng, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal MaestroIng As MaestroIngInfo) As Integer
        Dim MaestroIngSvc As New MaestroIngService(MaestroIng.SessionID)
        Return Update(MaestroIngSvc, MaestroIng)
    End Function

    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesi�n que autoriza la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim MaestroIngSvc As New MaestroIngService(sessionID)
        Return GetNumberOfPages(MaestroIngSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca MaestrosIng que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca MaestrosIng que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim MaestroIngSvc As New MaestroIngService(sessionID)
        Return GetSearchResult(MaestroIngSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de MaestrosIng.
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesi�n que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As Guid) As System.Data.DataSet
        Dim MaestroIngSvc As New MaestroIngService(sessionID)
        Return GetSearchStructure(MaestroIngSvc)
    End Function

#End Region

End Class
