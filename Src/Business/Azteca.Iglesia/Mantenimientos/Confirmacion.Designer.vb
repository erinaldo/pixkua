''' <summary>
''' Paquete de información que representa un Confirmacion
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class ConfirmacionInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Libro As Integer

    Public Property Pagina As Integer

    Public Property Acta As Integer

    Public Property Fecha As Date

    Public Property IdSolicitante As Integer

    Public Property Padrino1 As String

    Public Property GeneroPadrino1 As String

    Public Property Padrino2 As String

    Public Property GeneroPadrino2 As String

    Public Property IdSacerdote As Integer

    Public Property Conferida As String

    Public Property FechaExpedicion As DateTime

    Public Property IdParroquia As Integer


#End Region
	
#Region "Constructor"
    Public Sub New(ByVal session As Guid)
        MyBase.New(session)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Confirmaciones
''' </summary>
''' <remarks></remarks>
Public Class ConfirmacionService
    Inherits CatalogService(Of ConfirmacionInfo)

#Region "Constructores"
    Public Sub New(ByVal session As Guid)
        Me.New(session, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal session As Guid, ByVal cnn As IDbConnection)
        Me.New(session, cnn, Nothing)
    End Sub

    Public Sub New(ByVal session As Guid, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Church", "Confirmaciones", session)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idConfirmacion As Integer, ByRef Confirmacion As ConfirmacionInfo, checkStatus As Boolean)
        MyBase.GetDetail(idConfirmacion, Confirmacion, checkStatus)
        With Confirmacion
            .Libro = CInt(ItemInfo("Libro"))
            .Pagina = CInt(ItemInfo("Pagina"))
            .Acta = CInt(ItemInfo("Acta"))
            .Fecha = CDate(ItemInfo("Fecha"))
            .IdSolicitante = CInt(ItemInfo("IdSolicitante"))
            .Padrino1 = CStr(ItemInfo("Padrino1"))
            .GeneroPadrino1 = CStr(ItemInfo("GeneroPadrino1"))
            .Padrino2 = CStr(ItemInfo("Padrino2"))
            .GeneroPadrino2 = CStr(ItemInfo("GeneroPadrino2"))
            .IdSacerdote = CInt(ItemInfo("IdSacerdote"))
            .Conferida = CStr(ItemInfo("Conferida"))
            .FechaExpedicion = CDate(ItemInfo("FechaExpedicion"))
            .IdParroquia = CInt(ItemInfo("IdParroquia"))

        End With
    End Sub

    Public Overrides Function Update(ByVal Confirmacion As ConfirmacionInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Libro", DbType.Int32).Value = Confirmacion.Libro
            .Add("@Pagina", DbType.Int32).Value = Confirmacion.Pagina
            .Add("@Acta", DbType.Int32).Value = Confirmacion.Acta
            .Add("@Fecha", DbType.DateTime).Value = Confirmacion.Fecha
            .Add("@IdSolicitante", DbType.Int32).Value = Confirmacion.IdSolicitante
            .Add("@Padrino1", DbType.String).Value = Confirmacion.Padrino1
            .Add("@GeneroPadrino1", DbType.String).Value = Confirmacion.GeneroPadrino1
            .Add("@Padrino2", DbType.String).Value = Confirmacion.Padrino2
            .Add("@GeneroPadrino2", DbType.String).Value = Confirmacion.GeneroPadrino2
            .Add("@IdSacerdote", DbType.Int32).Value = Confirmacion.IdSacerdote
            .Add("@Conferida", DbType.String).Value = Confirmacion.Conferida
            .Add("@FechaExpedicion", DbType.DateTime).Value = Confirmacion.FechaExpedicion
            .Add("@IdParroquia", DbType.Int32).Value = Confirmacion.IdParroquia

        End With
        Return MyBase.Update(Confirmacion)
    End Function

    Public Overrides Function Create() As ConfirmacionInfo
        Return New ConfirmacionInfo(SessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de Confirmaciones
''' </summary>
''' <remarks></remarks>
Public Class ConfirmacionFacade
    Inherits CatalogFacade(Of ConfirmacionInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un ConfirmacionInfo
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal session As Guid) As ConfirmacionInfo
        Dim ConfirmacionSvc As New ConfirmacionService(session)
        Return ConfirmacionSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de Confirmaciones
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idConfirmacion">Identificador del Confirmacion que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal session As Guid, ByVal idConfirmacion As Integer)
        Dim ConfirmacionSvc As New ConfirmacionService(session)
        Delete(ConfirmacionSvc, idConfirmacion)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Confirmacion con el Identificador especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idConfirmacion">ID de Confirmacion que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal session As Guid, ByVal idConfirmacion As Integer) As Boolean
        Dim ConfirmacionSvc As New ConfirmacionService(session)
        Return Exists(ConfirmacionSvc, idConfirmacion)
    End Function

    ''' <summary>
    ''' Verifica si existe un Confirmacion con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim ConfirmacionSvc As New ConfirmacionService(session)
        Return Exists(ConfirmacionSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Confirmacion.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idConfirmacion">Identificador de Confirmacion a consultar</param>
    ''' <returns>Paquete de información de tipo ConfirmacionInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As Guid, ByVal idConfirmacion As Integer) As ConfirmacionInfo
        Return Me.GetDetail(session, idConfirmacion, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Confirmacion.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idConfirmacion">Identificador de Confirmacion</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Confirmacion.</param>
    ''' <returns>Paquete de información de tipo ConfirmacionInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As Guid, ByVal idConfirmacion As Integer, checkStatus As Boolean) As ConfirmacionInfo
        Dim ConfirmacionSvc As New ConfirmacionService(session)
        Dim ConfirmacionInf As New ConfirmacionInfo(session)
        GetDetail(ConfirmacionSvc, ConfirmacionInf, idConfirmacion, checkStatus)
        Return ConfirmacionInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un Confirmacion en base a su codigo de usuario
    ''' y verifica que el Confirmacion esté activo.
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información ConfirmacionInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As ConfirmacionInfo
        Return Me.GetDetail(session, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Confirmacion en base a su codigo de usuario
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Confirmacion</param>
    ''' <returns>Paquete de información ConfirmacionInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As ConfirmacionInfo
        Dim ConfirmacionInf As New ConfirmacionInfo(session)
        Dim ConfirmacionSvc As New ConfirmacionService(session)
        GetDetail(ConfirmacionSvc, ConfirmacionInf, userCode, idSucursal, checkStatus)
        Return ConfirmacionInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Confirmacion.
    ''' </summary>
    ''' <param name="Confirmacion">Paquete de información del tipo ConfirmacionInfo con la información a actualizar</param>
    ''' <returns>Identificador de Confirmacion, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Confirmacion As ConfirmacionInfo) As Integer
        Dim ConfirmacionSvc As New ConfirmacionService(Confirmacion.SessionID)
        Return Update(ConfirmacionSvc, Confirmacion)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal session As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim ConfirmacionSvc As New ConfirmacionService(session)
        Return GetNumberOfPages(ConfirmacionSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Confirmaciones que coincidan con las condiciones especificadas.
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
    ''' Busca Confirmaciones que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal session As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim ConfirmacionSvc As New ConfirmacionService(session)
        Return GetSearchResult(ConfirmacionSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Confirmaciones.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal session As Guid) As System.Data.DataSet
        Dim ConfirmacionSvc As New ConfirmacionService(session)
        Return GetSearchStructure(ConfirmacionSvc)
    End Function

#End Region

End Class
