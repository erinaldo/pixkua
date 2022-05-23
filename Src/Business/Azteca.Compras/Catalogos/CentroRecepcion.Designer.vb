''' <summary>
''' Paquete de información que representa un CentroRecepcion
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class CentroRecepcionInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property IdCuenta As Integer

    Public Property IdAlmacen As Integer

    Public Property Calle As String

    Public Property Colonia As String

    Public Property CP As String

    Public Property NumExt As String

    Public Property NumInt As String

    Public Property IdPoblacion As Integer

    Public Property IdMunicipio As Integer

    Public Property Tel1 As String

    Public Property Tel2 As String

    Public Property Fax As String


#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As Guid)
        MyBase.New(sessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de CentrosRecepcion
''' </summary>
''' <remarks></remarks>
Public Class CentroRecepcionService
    Inherits CatalogService(Of CentroRecepcionInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As guid)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As guid, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As guid, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Purchasing", "CentrosRecepcion", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idCentroRecepcion As Integer, ByRef CentroRecepcion As CentroRecepcionInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idCentroRecepcion, CentroRecepcion, checkStatus)
        With CentroRecepcion
            .Nombre = CStr(ItemInfo("Nombre"))
            .IdCuenta = CInt(ItemInfo("IdCuenta"))
            .IdAlmacen = CInt(ItemInfo("IdAlmacen"))
            .Calle = CStr(ItemInfo("Calle"))
            .Colonia = CStr(ItemInfo("Colonia"))
            .CP = CStr(ItemInfo("CP"))
            .NumExt = CStr(ItemInfo("NumExt"))
            .NumInt = CStr(ItemInfo("NumInt"))
            .IdPoblacion = CInt(ItemInfo("IdPoblacion"))
            .IdMunicipio = CInt(ItemInfo("IdMunicipio"))
            .Tel1 = CStr(ItemInfo("Tel1"))
            .Tel2 = CStr(ItemInfo("Tel2"))
            .Fax = CStr(ItemInfo("Fax"))

        End With
    End Sub

    Public Overrides Function Update(ByVal CentroRecepcion As CentroRecepcionInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = CentroRecepcion.Nombre
            .Add("@IdCuenta", DbType.Int32).Value = CentroRecepcion.IdCuenta
            .Add("@IdAlmacen", DbType.Int32).Value = CentroRecepcion.IdAlmacen
            .Add("@Calle", DbType.String).Value = CentroRecepcion.Calle
            .Add("@Colonia", DbType.String).Value = CentroRecepcion.Colonia
            .Add("@CP", DbType.String).Value = CentroRecepcion.CP
            .Add("@NumExt", DbType.String).Value = CentroRecepcion.NumExt
            .Add("@NumInt", DbType.String).Value = CentroRecepcion.NumInt
            .Add("@IdPoblacion", DbType.Int32).Value = CentroRecepcion.IdPoblacion
            .Add("@IdMunicipio", DbType.Int32).Value = CentroRecepcion.IdMunicipio
            .Add("@Tel1", DbType.String).Value = CentroRecepcion.Tel1
            .Add("@Tel2", DbType.String).Value = CentroRecepcion.Tel2
            .Add("@Fax", DbType.String).Value = CentroRecepcion.Fax

        End With
        Return MyBase.Update(CentroRecepcion)
    End Function

    Public Overrides Function Create() As CentroRecepcionInfo
        Return New CentroRecepcionInfo(sessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de CentrosRecepcion
''' </summary>
''' <remarks></remarks>
''' 
Public Class CentroRecepcionFacade
    Inherits CatalogFacade(Of CentroRecepcionInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un CentroRecepcionInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As guid) As CentroRecepcionInfo
        Dim CentroRecepcionSvc As New CentroRecepcionService(sessionID)
        Return CentroRecepcionSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de CentrosRecepcion
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCentroRecepcion">Identificador del CentroRecepcion que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As guid, ByVal idCentroRecepcion As Integer)
        Dim CentroRecepcionSvc As New CentroRecepcionService(sessionID)
        Delete(CentroRecepcionSvc, idCentroRecepcion)
    End Sub

    ''' <summary>
    ''' Verifica si existe un CentroRecepcion con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCentroRecepcion">ID de CentroRecepcion que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As guid, ByVal idCentroRecepcion As Integer) As Boolean
        Dim CentroRecepcionSvc As New CentroRecepcionService(sessionID)
        Return Exists(CentroRecepcionSvc, idCentroRecepcion)
    End Function

    ''' <summary>
    ''' Verifica si existe un CentroRecepcion con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As guid, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim CentroRecepcionSvc As New CentroRecepcionService(sessionID)
        Return Exists(CentroRecepcionSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un CentroRecepcion.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCentroRecepcion">Identificador de CentroRecepcion a consultar</param>
    ''' <returns>Paquete de información de tipo CentroRecepcionInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As guid, ByVal idCentroRecepcion As Integer) As CentroRecepcionInfo
        Return Me.GetDetail(sessionID, idCentroRecepcion, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un CentroRecepcion.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCentroRecepcion">Identificador de CentroRecepcion</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del CentroRecepcion.</param>
    ''' <returns>Paquete de información de tipo CentroRecepcionInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As guid, ByVal idCentroRecepcion As Integer, ByVal checkStatus As Boolean) As CentroRecepcionInfo
        Dim CentroRecepcionSvc As New CentroRecepcionService(sessionID)
        Dim CentroRecepcionInf As New CentroRecepcionInfo(sessionID)
        GetDetail(CentroRecepcionSvc, CentroRecepcionInf, idCentroRecepcion, checkStatus)
        Return CentroRecepcionInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un CentroRecepcion en base a su codigo de usuario
    ''' y verifica que el CentroRecepcion esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información CentroRecepcionInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As guid, ByVal userCode As String, ByVal idSucursal As Integer) As CentroRecepcionInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un CentroRecepcion en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del CentroRecepcion</param>
    ''' <returns>Paquete de información CentroRecepcionInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As guid, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As CentroRecepcionInfo
        Dim CentroRecepcionInf As New CentroRecepcionInfo(sessionID)
        Dim CentroRecepcionSvc As New CentroRecepcionService(sessionID)
        GetDetail(CentroRecepcionSvc, CentroRecepcionInf, userCode, idSucursal, checkStatus)
        Return CentroRecepcionInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un CentroRecepcion.
    ''' </summary>
    ''' <param name="CentroRecepcion">Paquete de información del tipo CentroRecepcionInfo con la información a actualizar</param>
    ''' <returns>Identificador de CentroRecepcion, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal CentroRecepcion As CentroRecepcionInfo) As Integer
        Dim CentroRecepcionSvc As New CentroRecepcionService(CentroRecepcion.SessionID)
        Return Update(CentroRecepcionSvc, CentroRecepcion)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim CentroRecepcionSvc As New CentroRecepcionService(sessionID)
        Return GetNumberOfPages(CentroRecepcionSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca CentrosRecepcion que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca CentrosRecepcion que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim CentroRecepcionSvc As New CentroRecepcionService(sessionID)
        Return GetSearchResult(CentroRecepcionSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de CentrosRecepcion.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As guid) As System.Data.DataSet
        Dim CentroRecepcionSvc As New CentroRecepcionService(sessionID)
        Return GetSearchStructure(CentroRecepcionSvc)
    End Function

#End Region

End Class
