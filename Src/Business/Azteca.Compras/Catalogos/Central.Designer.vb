''' <summary>
''' Paquete de información que representa un Central
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class CentralInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property IdZonaCompra As Integer

    Public Property IdCaja As Integer

    Public Property IdCuenta As Integer

    Public Property IdRemitente As Integer

    Public Property IdOperador As Integer

    Public Property EnviarOC As Boolean

    Public Property NotificarOC As Boolean

    Public Property PresupuestoTipo As PresupuestoTipoEnum = PresupuestoTipoEnum.Departamental

#End Region

#Region "Constructor"
    Public Sub New(ByVal sessionid As Guid)
        MyBase.New(sessionid)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Centrales
''' </summary>
''' <remarks></remarks>
Public Class CentralService
    Inherits CatalogService(Of CentralInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As Guid)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As Guid, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As Guid, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Purchasing", "Centrales", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idCentral As Integer, ByRef Central As CentralInfo, checkStatus As Boolean)
        MyBase.GetDetail(idCentral, Central, checkStatus)
        With Central
            .Nombre = CStr(ItemInfo("Nombre"))
            .IdZonaCompra = CInt(ItemInfo("IdZonaCompra"))
            .IdCaja = CInt(ItemInfo("IdCaja"))
            .IdCuenta = CInt(ItemInfo("IdCuenta"))
            .IdRemitente = CInt(ItemInfo("IdRemitente"))
            .IdOperador = CInt(ItemInfo("IdOperador"))
            .EnviarOC = CBool(ItemInfo("EnviarOC"))
            .NotificarOC = CBool(ItemInfo("NotificarOC"))
        End With
    End Sub

    Public Overrides Function Update(ByVal Central As CentralInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = Central.Nombre
            .Add("@IdZonaCompra", DbType.Int32).Value = Central.IdZonaCompra
            .Add("@IdCaja", DbType.Int32).Value = Central.IdCaja
            .Add("@IdCuenta", DbType.Int32).Value = Central.IdCuenta
            .Add("@IdRemitente", DbType.Int32).Value = Central.IdRemitente
            .Add("@IdOperador", DbType.Int32).Value = Central.IdOperador
            .Add("@EnviarOC", DbType.Boolean).Value = Central.EnviarOC
            .Add("@NotificarOC", DbType.Boolean).Value = Central.NotificarOC
        End With
        Azteca.Kernel.Cache.Remove("Purchasing_Centrales" & Central.Identity.ToString)
        Return MyBase.Update(Central)
    End Function

    Public Overrides Function Create() As CentralInfo
        Return New CentralInfo(SessionID)
    End Function

#End Region

End Class



''' <summary>
''' Business Facade con servicios para el manejo del catálogo de Centrales
''' </summary>
''' <remarks></remarks>
''' 
Public Class CentralFacade
	Inherits CatalogFacade(Of CentralInfo)
        
#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un CentralInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionId As Guid) As CentralInfo
        Dim CentralSvc As New CentralService(sessionId)
        Return CentralSvc.Create()
    End Function
    
    ''' <summary>
    ''' Elimina un elemento del catálogo de Centrales
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCentral">Identificador del Central que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionId As Guid, ByVal idCentral As Integer)
        Dim CentralSvc As New CentralService(sessionId)
        Delete(CentralSvc, idCentral)
    End Sub
	
    ''' <summary>
    ''' Verifica si existe un Central con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCentral">ID de Central que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionId As Guid, ByVal idCentral As Integer) As Boolean
        Dim CentralSvc As New CentralService(sessionId)
        Return Exists(CentralSvc, idCentral)
    End Function

    ''' <summary>
    ''' Verifica si existe un Central con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionId As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim CentralSvc As New CentralService(sessionId)
        Return Exists(CentralSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Central.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCentral">Identificador de Central a consultar</param>
    ''' <returns>Paquete de información de tipo CentralInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionId As Guid, ByVal idCentral As Integer) As CentralInfo
        Return Me.GetDetail(sessionId, idCentral, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Central.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCentral">Identificador de Central</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Central.</param>
    ''' <returns>Paquete de información de tipo CentralInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionId As Guid, ByVal idCentral As Integer, ByVal checkStatus As Boolean) As CentralInfo
        Dim CentralSvc As New CentralService(sessionId)
        Dim CentralInf As New CentralInfo(sessionId)
        GetDetail(CentralSvc, CentralInf, idCentral, checkStatus)
        Return CentralInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un Central en base a su codigo de usuario
    ''' y verifica que el Central esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información CentralInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionId As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As CentralInfo
        Return Me.GetDetail(sessionId, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Central en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Central</param>
    ''' <returns>Paquete de información CentralInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionId As Guid, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As CentralInfo
        Dim CentralInf As New CentralInfo(sessionId)
        Dim CentralSvc As New CentralService(sessionId)
        GetDetail(CentralSvc, CentralInf, userCode, idSucursal, checkStatus)
        Return CentralInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Central.
    ''' </summary>
    ''' <param name="Central">Paquete de información del tipo CentralInfo con la información a actualizar</param>
    ''' <returns>Identificador de Central, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Central As CentralInfo) As Integer
        Dim CentralSvc As New CentralService(Central.SessionID)
		Return Update(CentralSvc, Central)
    End Function
	
    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionId As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim CentralSvc As New CentralService(sessionId)
        Return GetNumberOfPages(CentralSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Centrales que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionId As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(sessionId, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca Centrales que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionId As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim CentralSvc As New CentralService(sessionId)
        Return GetSearchResult(CentralSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Centrales.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionId As Guid) As System.Data.DataSet
        Dim CentralSvc As New CentralService(sessionId)
        Return GetSearchStructure(CentralSvc)
    End Function

#End Region

End Class

Public Enum PresupuestoTipoEnum
    Departamental = 0
    Categorizado = 1
End Enum

