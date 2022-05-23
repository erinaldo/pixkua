''' <summary>
''' Paquete de informaci�n que representa un Region
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class RegionInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property IdSucursalCalendario As Integer


#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del cat�logo de Regiones
''' </summary>
''' <remarks></remarks>
Public Class RegionService
    Inherits CatalogService(Of RegionInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Sales", "Regiones", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idRegion As Integer, ByRef Region As RegionInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idRegion, Region, checkStatus)
        With Region
            .Nombre = CStr(Me.ItemInfo("Nombre"))
            .IdSucursalCalendario = CInt(Me.ItemInfo("IdSucursalCalendario"))

        End With
    End Sub

    Public Overrides Function Update(ByVal Region As RegionInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = Region.Nombre
            .Add("@IdSucursalCalendario", DbType.Int32).Value = Region.IdSucursalCalendario

        End With
        Return MyBase.Update(Region)
    End Function

    Public Overrides Function Create() As RegionInfo
        Return New RegionInfo(sessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del cat�logo de Regiones
''' </summary>
''' <remarks></remarks>
Public Class RegionFacade
    Inherits CatalogFacade(Of RegionInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un RegionInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As RegionInfo
        Dim RegionSvc As New RegionService(sessionID)
        Return RegionSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del cat�logo de Regiones
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idRegion">Identificador del Region que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idRegion As Integer)
        Dim RegionSvc As New RegionService(sessionID)
        Delete(RegionSvc, idRegion)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Region con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idRegion">ID de Region que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idRegion As Integer) As Boolean
        Dim RegionSvc As New RegionService(sessionID)
        Return Exists(RegionSvc, idRegion)
    End Function

    ''' <summary>
    ''' Verifica si existe un Region con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario b�scado</param>
    ''' <returns>True si existe un usuario con ese c�digo, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim RegionSvc As New RegionService(sessionID)
        Return Exists(RegionSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Region.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idRegion">Identificador de Region a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo RegionInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idRegion As Integer) As RegionInfo
        Return Me.GetDetail(sessionID, idRegion, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Region.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idRegion">Identificador de Region</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Region.</param>
    ''' <returns>Paquete de informaci�n de tipo RegionInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idRegion As Integer, ByVal checkStatus As Boolean) As RegionInfo
        Dim RegionSvc As New RegionService(sessionID)
        Dim RegionInf As New RegionInfo(sessionID)
        GetDetail(RegionSvc, RegionInf, idRegion, checkStatus)
        Return RegionInf
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Region en base a su codigo de usuario
    ''' y verifica que el Region est� activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario a buscar</param>
    ''' <returns>Paquete de informaci�n RegionInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As RegionInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Region en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Region</param>
    ''' <returns>Paquete de informaci�n RegionInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As RegionInfo
        Dim RegionInf As New RegionInfo(sessionID)
        Dim RegionSvc As New RegionService(sessionID)
        GetDetail(RegionSvc, RegionInf, userCode, idSucursal, checkStatus)
        Return RegionInf
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un Region.
    ''' </summary>
    ''' <param name="Region">Paquete de informaci�n del tipo RegionInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de Region, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Region As RegionInfo) As Integer
        Dim RegionSvc As New RegionService(Region.SessionID)
        Return Update(RegionSvc, Region)
    End Function

    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim RegionSvc As New RegionService(sessionID)
        Return GetNumberOfPages(RegionSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Regiones que coincidan con las condiciones especificadas.
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
    ''' Busca Regiones que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim RegionSvc As New RegionService(sessionID)
        Return GetSearchResult(RegionSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de Regiones.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim RegionSvc As New RegionService(sessionID)
        Return GetSearchStructure(RegionSvc)
    End Function

#End Region

End Class
