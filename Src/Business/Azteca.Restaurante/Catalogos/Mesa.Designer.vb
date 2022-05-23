''' <summary>
''' Paquete de información que representa un Mesa
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class MesaInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Descripcion As String

    Public Property IdCentroConsumo As Integer

    Public Property IdCuenta As Integer


#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Mesas
''' </summary>
''' <remarks></remarks>
Public Class MesaService
    Inherits CatalogService(Of MesaInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Restaurant", "Mesas", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idMesa As Integer, ByRef Mesa As MesaInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idMesa, Mesa, checkStatus)
        With Mesa
            .Descripcion = CStr(ItemInfo("Descripcion"))
            .IdCentroConsumo = CInt(ItemInfo("IdCentroConsumo"))
            .IdCuenta = CInt(ItemInfo("IdCuenta"))

        End With
    End Sub

    Public Overrides Function Update(ByVal Mesa As MesaInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Descripcion", DbType.String).Value = Mesa.Descripcion
            .Add("@IdCentroConsumo", DbType.Int32).Value = Mesa.IdCentroConsumo
            .Add("@IdCuenta", DbType.Int32).Value = Mesa.IdCuenta

        End With
        Return MyBase.Update(Mesa)
    End Function

    Public Overrides Function Create() As MesaInfo
        Return New MesaInfo(sessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de Mesas
''' </summary>
''' <remarks></remarks>
Public Class MesaFacade
    Inherits CatalogFacade(Of MesaInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un MesaInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As MesaInfo
        Dim MesaSvc As New MesaService(sessionID)
        Return MesaSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de Mesas
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idMesa">Identificador del Mesa que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idMesa As Integer)
        Dim MesaSvc As New MesaService(sessionID)
        Delete(MesaSvc, idMesa)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Mesa con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idMesa">ID de Mesa que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idMesa As Integer) As Boolean
        Dim MesaSvc As New MesaService(sessionID)
        Return Exists(MesaSvc, idMesa)
    End Function

    ''' <summary>
    ''' Verifica si existe un Mesa con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim MesaSvc As New MesaService(sessionID)
        Return Exists(MesaSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Mesa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idMesa">Identificador de Mesa a consultar</param>
    ''' <returns>Paquete de información de tipo MesaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idMesa As Integer) As MesaInfo
        Return Me.GetDetail(sessionID, idMesa, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Mesa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idMesa">Identificador de Mesa</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Mesa.</param>
    ''' <returns>Paquete de información de tipo MesaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idMesa As Integer, ByVal checkStatus As Boolean) As MesaInfo
        Dim MesaSvc As New MesaService(sessionID)
        Dim MesaInf As New MesaInfo(sessionID)
        GetDetail(MesaSvc, MesaInf, idMesa, checkStatus)
        Return MesaInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un Mesa en base a su codigo de usuario
    ''' y verifica que el Mesa esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información MesaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As MesaInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Mesa en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Mesa</param>
    ''' <returns>Paquete de información MesaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As MesaInfo
        Dim MesaInf As New MesaInfo(sessionID)
        Dim MesaSvc As New MesaService(sessionID)
        GetDetail(MesaSvc, MesaInf, userCode, idSucursal, checkStatus)
        Return MesaInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Mesa.
    ''' </summary>
    ''' <param name="Mesa">Paquete de información del tipo MesaInfo con la información a actualizar</param>
    ''' <returns>Identificador de Mesa, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Mesa As MesaInfo) As Integer
        Dim MesaSvc As New MesaService(Mesa.SessionID)
        Return Update(MesaSvc, Mesa)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim MesaSvc As New MesaService(sessionID)
        Return GetNumberOfPages(MesaSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Mesas que coincidan con las condiciones especificadas.
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
    ''' Busca Mesas que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim MesaSvc As New MesaService(sessionID)
        Return GetSearchResult(MesaSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Mesas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim MesaSvc As New MesaService(sessionID)
        Return GetSearchStructure(MesaSvc)
    End Function

#End Region

End Class
