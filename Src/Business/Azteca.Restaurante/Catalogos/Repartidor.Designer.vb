''' <summary>
''' Paquete de información que representa un Repartidor
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class RepartidorInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property IdUsuario As Integer

    Public Property IdCuenta As Integer

    Public Property NombreCorto As String


#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As Guid)
        MyBase.New(sessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Repartidores
''' </summary>
''' <remarks></remarks>
Public Class RepartidorService
    Inherits CatalogService(Of RepartidorInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As Guid)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As Guid, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As Guid, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Restaurant", "Repartidores", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idRepartidor As Integer, ByRef Repartidor As RepartidorInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idRepartidor, Repartidor, checkStatus)
        With Repartidor
            .IdUsuario = CInt(ItemInfo("IdUsuario"))
            .IdCuenta = CInt(ItemInfo("IdCuenta"))
            .NombreCorto = CStr(ItemInfo("NombreCorto"))

        End With
    End Sub

    Public Overrides Function Update(ByVal Repartidor As RepartidorInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@IdUsuario", DbType.Int32).Value = Repartidor.IdUsuario
            .Add("@IdCuenta", DbType.Int32).Value = Repartidor.IdCuenta
            .Add("@NombreCorto", DbType.String).Value = Repartidor.NombreCorto

        End With
        Return MyBase.Update(Repartidor)
    End Function

    Public Overrides Function Create() As RepartidorInfo
        Return New RepartidorInfo(SessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de Repartidores
''' </summary>
''' <remarks></remarks>
Public Class RepartidorFacade
    Inherits CatalogFacade(Of RepartidorInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un RepartidorInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As Guid) As RepartidorInfo
        Dim RepartidorSvc As New RepartidorService(sessionID)
        Return RepartidorSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de Repartidores
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idRepartidor">Identificador del Repartidor que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As Guid, ByVal idRepartidor As Integer)
        Dim RepartidorSvc As New RepartidorService(sessionID)
        Delete(RepartidorSvc, idRepartidor)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Repartidor con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idRepartidor">ID de Repartidor que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As Guid, ByVal idRepartidor As Integer) As Boolean
        Dim RepartidorSvc As New RepartidorService(sessionID)
        Return Exists(RepartidorSvc, idRepartidor)
    End Function

    ''' <summary>
    ''' Verifica si existe un Repartidor con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim RepartidorSvc As New RepartidorService(sessionID)
        Return Exists(RepartidorSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Repartidor.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idRepartidor">Identificador de Repartidor a consultar</param>
    ''' <returns>Paquete de información de tipo RepartidorInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As Guid, ByVal idRepartidor As Integer) As RepartidorInfo
        Return Me.GetDetail(sessionID, idRepartidor, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Repartidor.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idRepartidor">Identificador de Repartidor</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Repartidor.</param>
    ''' <returns>Paquete de información de tipo RepartidorInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As Guid, ByVal idRepartidor As Integer, ByVal checkStatus As Boolean) As RepartidorInfo
        Dim RepartidorSvc As New RepartidorService(sessionID)
        Dim RepartidorInf As New RepartidorInfo(sessionID)
        GetDetail(RepartidorSvc, RepartidorInf, idRepartidor, checkStatus)
        Return RepartidorInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un Repartidor en base a su codigo de usuario
    ''' y verifica que el Repartidor esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información RepartidorInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As RepartidorInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Repartidor en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Repartidor</param>
    ''' <returns>Paquete de información RepartidorInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As Guid, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As RepartidorInfo
        Dim RepartidorInf As New RepartidorInfo(sessionID)
        Dim RepartidorSvc As New RepartidorService(sessionID)
        GetDetail(RepartidorSvc, RepartidorInf, userCode, idSucursal, checkStatus)
        Return RepartidorInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Repartidor.
    ''' </summary>
    ''' <param name="Repartidor">Paquete de información del tipo RepartidorInfo con la información a actualizar</param>
    ''' <returns>Identificador de Repartidor, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Repartidor As RepartidorInfo) As Integer
        Dim RepartidorSvc As New RepartidorService(Repartidor.SessionID)
        Return Update(RepartidorSvc, Repartidor)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim RepartidorSvc As New RepartidorService(sessionID)
        Return GetNumberOfPages(RepartidorSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Repartidores que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca Repartidores que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim RepartidorSvc As New RepartidorService(sessionID)
        Return GetSearchResult(RepartidorSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Repartidores.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As Guid) As System.Data.DataSet
        Dim RepartidorSvc As New RepartidorService(sessionID)
        Return GetSearchStructure(RepartidorSvc)
    End Function

#End Region

End Class
