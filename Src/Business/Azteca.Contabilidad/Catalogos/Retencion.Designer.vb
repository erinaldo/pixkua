''' <summary>
''' Paquete de información que representa un Retencion
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class RetencionInfo
    Inherits CatalogInfo

#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property Porcentaje As Decimal

    Public Property Abreviatura As String

    Public Property TipoRetencion As Integer


#End Region

#Region "Constructor"
    Public Sub New(ByVal SessionID As Guid)
        MyBase.New(SessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Retenciones
''' </summary>
''' <remarks></remarks>
Public Class RetencionService
    Inherits CatalogService(Of RetencionInfo)

#Region "Constructores"
    Public Sub New(ByVal SessionID As Guid)
        Me.New(SessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal SessionID As Guid, ByVal cnn As IDbConnection)
        Me.New(SessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal SessionID As Guid, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Accounting", "Retenciones", SessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idRetencion As Integer, ByRef Retencion As RetencionInfo, checkStatus As Boolean)
        MyBase.GetDetail(idRetencion, Retencion, checkStatus)
        With Retencion
            .Nombre = CStr(ItemInfo("Nombre"))
            .Porcentaje = CDec(ItemInfo("Porcentaje"))
            .Abreviatura = CStr(ItemInfo("Abrev"))
            .TipoRetencion = CInt(ItemInfo("TipoRetencion"))
        End With
    End Sub

    Public Overrides Function Update(ByVal Retencion As RetencionInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = Retencion.Nombre
            .Add("@Porcentaje", DbType.Decimal).Value = Retencion.Porcentaje
            .Add("@Abrev", DbType.String).Value = Retencion.Abreviatura
            .Add("@TipoRetencion", DbType.Int32).Value = Retencion.TipoRetencion
        End With
        Dim IdRetencion As Integer = MyBase.Update(Retencion)
        Azteca.Kernel.Cache.Remove("Retencion_" & IdRetencion.ToString)
        Return IdRetencion
    End Function

    Public Overrides Function Create() As RetencionInfo
        Return New RetencionInfo(SessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de Retenciones
''' </summary>
''' <remarks></remarks>
Public Class RetencionFacade
    Inherits CatalogFacade(Of RetencionInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un RetencionInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal SessionID As Guid) As RetencionInfo
        Dim RetencionSvc As New RetencionService(SessionID)
        Return RetencionSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de Retenciones
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idRetencion">Identificador del Retencion que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal SessionID As Guid, ByVal idRetencion As Integer)
        Dim RetencionSvc As New RetencionService(SessionID)
        Delete(RetencionSvc, idRetencion)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Retencion con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idRetencion">ID de Retencion que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal SessionID As Guid, ByVal idRetencion As Integer) As Boolean
        Dim RetencionSvc As New RetencionService(SessionID)
        Return Exists(RetencionSvc, idRetencion)
    End Function

    ''' <summary>
    ''' Verifica si existe un Retencion con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal SessionID As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim RetencionSvc As New RetencionService(SessionID)
        Return Exists(RetencionSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Retencion.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idRetencion">Identificador de Retencion a consultar</param>
    ''' <returns>Paquete de información de tipo RetencionInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal SessionID As Guid, ByVal idRetencion As Integer) As RetencionInfo
        Return Me.GetDetail(SessionID, idRetencion, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Retencion.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idRetencion">Identificador de Retencion</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Retencion.</param>
    ''' <returns>Paquete de información de tipo RetencionInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal SessionID As Guid, ByVal idRetencion As Integer, checkStatus As Boolean) As RetencionInfo
        Dim RetencionSvc As New RetencionService(SessionID)
        Dim RetencionInf As New RetencionInfo(SessionID)
        GetDetail(RetencionSvc, RetencionInf, idRetencion, checkStatus)
        Return RetencionInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un Retencion en base a su codigo de usuario
    ''' y verifica que el Retencion esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información RetencionInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal SessionID As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As RetencionInfo
        Return Me.GetDetail(SessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Retencion en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Retencion</param>
    ''' <returns>Paquete de información RetencionInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal SessionID As Guid, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As RetencionInfo
        Dim RetencionInf As New RetencionInfo(SessionID)
        Dim RetencionSvc As New RetencionService(SessionID)
        GetDetail(RetencionSvc, RetencionInf, userCode, idSucursal, checkStatus)
        Return RetencionInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Retencion.
    ''' </summary>
    ''' <param name="Retencion">Paquete de información del tipo RetencionInfo con la información a actualizar</param>
    ''' <returns>Identificador de Retencion, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Retencion As RetencionInfo) As Integer
        Dim RetencionSvc As New RetencionService(Retencion.SessionID)
        Return Update(RetencionSvc, Retencion)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal SessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim RetencionSvc As New RetencionService(SessionID)
        Return GetNumberOfPages(RetencionSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Retenciones que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal SessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(SessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca Retenciones que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal SessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim RetencionSvc As New RetencionService(SessionID)
        Return GetSearchResult(RetencionSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Retenciones.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal SessionID As Guid) As System.Data.DataSet
        Dim RetencionSvc As New RetencionService(SessionID)
        Return GetSearchStructure(RetencionSvc)
    End Function

#End Region

End Class
