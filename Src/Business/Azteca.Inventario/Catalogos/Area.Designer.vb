''' <summary>
''' Paquete de informaci�n que representa un Area
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class AreaInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"
    Friend _IdCorteActual As Guid
#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property IdCuenta As Integer

    Public ReadOnly Property IdCorteActual As Guid
        Get
            Return _IdCorteActual
        End Get
    End Property

#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del cat�logo de Areas
''' </summary>
''' <remarks></remarks>
Public Class AreaService
    Inherits CatalogService(Of AreaInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Inventory", "Areas", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idArea As Integer, ByRef Area As AreaInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idArea, Area, checkStatus)
        With Area
            .Nombre = CStr(ItemInfo("Nombre"))
            .IdCuenta = CInt(ItemInfo("IdCuenta"))
            ._IdCorteActual = CType(ItemInfo("IdCorteActual"), Guid)
        End With
    End Sub

    Public Overrides Function Update(ByVal Area As AreaInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = Area.Nombre
            .Add("@IdCuenta", DbType.Int32).Value = Area.IdCuenta
        End With
        Dim CacheKey As String = "Area" & Area.Identity.ToString
        Azteca.Kernel.Cache.Remove(CacheKey)
        Return MyBase.Update(Area)
    End Function

    Public Overrides Function Create() As AreaInfo
        Return New AreaInfo(sessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del cat�logo de Areas
''' </summary>
''' <remarks></remarks>
Public Class AreaFacade
    Inherits CatalogFacade(Of AreaInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un AreaInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As AreaInfo
        Dim AreaSvc As New AreaService(sessionID)
        Return AreaSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del cat�logo de Areas
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idArea">Identificador del Area que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idArea As Integer)
        Dim AreaSvc As New AreaService(sessionID)
        Delete(AreaSvc, idArea)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Area con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idArea">ID de Area que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idArea As Integer) As Boolean
        Dim AreaSvc As New AreaService(sessionID)
        Return Exists(AreaSvc, idArea)
    End Function

    ''' <summary>
    ''' Verifica si existe un Area con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario b�scado</param>
    ''' <returns>True si existe un usuario con ese c�digo, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim AreaSvc As New AreaService(sessionID)
        Return Exists(AreaSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Area.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idArea">Identificador de Area a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo AreaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idArea As Integer) As AreaInfo
        Return Me.GetDetail(sessionID, idArea, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Area.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idArea">Identificador de Area</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Area.</param>
    ''' <returns>Paquete de informaci�n de tipo AreaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idArea As Integer, ByVal checkStatus As Boolean) As AreaInfo
        Dim AreaSvc As New AreaService(sessionID)
        Dim AreaInf As New AreaInfo(sessionID)
        GetDetail(AreaSvc, AreaInf, idArea, checkStatus)
        Return AreaInf
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Area en base a su codigo de usuario
    ''' y verifica que el Area est� activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario a buscar</param>
    ''' <returns>Paquete de informaci�n AreaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As AreaInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Area en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Area</param>
    ''' <returns>Paquete de informaci�n AreaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As AreaInfo
        Dim AreaInf As New AreaInfo(sessionID)
        Dim AreaSvc As New AreaService(sessionID)
        GetDetail(AreaSvc, AreaInf, userCode, idSucursal, checkStatus)
        Return AreaInf
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un Area.
    ''' </summary>
    ''' <param name="Area">Paquete de informaci�n del tipo AreaInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de Area, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Area As AreaInfo) As Integer
        Dim AreaSvc As New AreaService(Area.SessionID)
        Return Update(AreaSvc, Area)
    End Function

    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim AreaSvc As New AreaService(sessionID)
        Return GetNumberOfPages(AreaSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Areas que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca Areas que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim AreaSvc As New AreaService(sessionID)
        Return GetSearchResult(AreaSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de Areas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim AreaSvc As New AreaService(sessionID)
        Return GetSearchStructure(AreaSvc)
    End Function

#End Region

End Class
