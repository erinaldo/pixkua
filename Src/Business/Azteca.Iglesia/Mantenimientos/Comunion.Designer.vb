''' <summary>
''' Paquete de información que representa un Comunion
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class ComunionInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Libro As Integer

    Public Property Pagina As Integer

    Public Property IdSacerdoteCertifica As Integer

    Public Property IdParroquiaSacerdoteCer As Integer

    Public Property IdSolicitante As Integer

    Public Property IdSacerdoteCelebra As Integer

    Public Property Padrinos As String

    Public Property Fecha As Date

    Public Property FechaExpedicion As Date




#End Region
	
#Region "Constructor"
    Public Sub New(ByVal session As Guid)
        MyBase.New(session)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Comuniones
''' </summary>
''' <remarks></remarks>
Public Class ComunionService
    Inherits CatalogService(Of ComunionInfo)

#Region "Constructores"
    Public Sub New(ByVal session As Guid)
        Me.New(session, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal session As Guid, ByVal cnn As IDbConnection)
        Me.New(session, cnn, Nothing)
    End Sub

    Public Sub New(ByVal session As Guid, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Church", "Comuniones", session)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idComunion As Integer, ByRef Comunion As ComunionInfo, checkStatus As Boolean)
        MyBase.GetDetail(idComunion, Comunion, checkStatus)
        With Comunion
            .Libro = CInt(ItemInfo("Libro"))
            .Pagina = CInt(ItemInfo("Pagina"))
            .IdSacerdoteCertifica = CInt(ItemInfo("IdSacerdoteCertifica"))
            .IdParroquiaSacerdoteCer = CInt(ItemInfo("IdParroquiaSacerdoteCer"))
            .IdSolicitante = CInt(ItemInfo("IdSolicitante"))
            .IdSacerdoteCelebra = CInt(ItemInfo("IdSacerdoteCelebra"))
            .Padrinos = CStr(ItemInfo("Padrinos"))
            .Fecha = CDate(ItemInfo("Fecha"))
            .FechaExpedicion = CDate(ItemInfo("FechaExpedicion"))


        End With
    End Sub

    Public Overrides Function Update(ByVal Comunion As ComunionInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Libro", DbType.Int32).Value = Comunion.Libro
            .Add("@Pagina", DbType.Int32).Value = Comunion.Pagina
            .Add("@IdSacerdoteCertifica", DbType.Int32).Value = Comunion.IdSacerdoteCertifica
            .Add("@IdParroquiaSacerdoteCer", DbType.Int32).Value = Comunion.IdParroquiaSacerdoteCer
            .Add("@IdSolicitante", DbType.Int32).Value = Comunion.IdSolicitante
            .Add("@IdSacerdoteCelebra", DbType.Int32).Value = Comunion.IdSacerdoteCelebra
            .Add("@Padrinos", DbType.String).Value = Comunion.Padrinos
            .Add("@Fecha", DbType.DateTime).Value = Comunion.Fecha
            .Add("@FechaExpedicion", DbType.DateTime).Value = Comunion.FechaExpedicion


        End With
        Return MyBase.Update(Comunion)
    End Function

    Public Overrides Function Create() As ComunionInfo
        Return New ComunionInfo(SessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de Comuniones
''' </summary>
''' <remarks></remarks>
Public Class ComunionFacade
    Inherits CatalogFacade(Of ComunionInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un ComunionInfo
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal session As Guid) As ComunionInfo
        Dim ComunionSvc As New ComunionService(session)
        Return ComunionSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de Comuniones
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idComunion">Identificador del Comunion que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal session As Guid, ByVal idComunion As Integer)
        Dim ComunionSvc As New ComunionService(session)
        Delete(ComunionSvc, idComunion)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Comunion con el Identificador especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idComunion">ID de Comunion que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal session As Guid, ByVal idComunion As Integer) As Boolean
        Dim ComunionSvc As New ComunionService(session)
        Return Exists(ComunionSvc, idComunion)
    End Function

    ''' <summary>
    ''' Verifica si existe un Comunion con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim ComunionSvc As New ComunionService(session)
        Return Exists(ComunionSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Comunion.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idComunion">Identificador de Comunion a consultar</param>
    ''' <returns>Paquete de información de tipo ComunionInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As Guid, ByVal idComunion As Integer) As ComunionInfo
        Return Me.GetDetail(session, idComunion, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Comunion.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idComunion">Identificador de Comunion</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Comunion.</param>
    ''' <returns>Paquete de información de tipo ComunionInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As Guid, ByVal idComunion As Integer, checkStatus As Boolean) As ComunionInfo
        Dim ComunionSvc As New ComunionService(session)
        Dim ComunionInf As New ComunionInfo(session)
        GetDetail(ComunionSvc, ComunionInf, idComunion, checkStatus)
        Return ComunionInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un Comunion en base a su codigo de usuario
    ''' y verifica que el Comunion esté activo.
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información ComunionInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As ComunionInfo
        Return Me.GetDetail(session, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Comunion en base a su codigo de usuario
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Comunion</param>
    ''' <returns>Paquete de información ComunionInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As ComunionInfo
        Dim ComunionInf As New ComunionInfo(session)
        Dim ComunionSvc As New ComunionService(session)
        GetDetail(ComunionSvc, ComunionInf, userCode, idSucursal, checkStatus)
        Return ComunionInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Comunion.
    ''' </summary>
    ''' <param name="Comunion">Paquete de información del tipo ComunionInfo con la información a actualizar</param>
    ''' <returns>Identificador de Comunion, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Comunion As ComunionInfo) As Integer
        Dim ComunionSvc As New ComunionService(Comunion.SessionID)
        Return Update(ComunionSvc, Comunion)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal session As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim ComunionSvc As New ComunionService(session)
        Return GetNumberOfPages(ComunionSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Comuniones que coincidan con las condiciones especificadas.
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
    ''' Busca Comuniones que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal session As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim ComunionSvc As New ComunionService(session)
        Return GetSearchResult(ComunionSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Comuniones.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal session As Guid) As System.Data.DataSet
        Dim ComunionSvc As New ComunionService(session)
        Return GetSearchStructure(ComunionSvc)
    End Function

#End Region

End Class
