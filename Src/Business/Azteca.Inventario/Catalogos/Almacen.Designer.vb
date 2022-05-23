''' <summary>
''' Paquete de información que representa un Almacen
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class AlmacenInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property PermiteNegativos As Boolean

    Public Property RequiereCapturaFisico As Boolean

    Public Property IdArea As Integer

    Public Property IdCuenta As Integer

    Public Property PasillosTable As DataTable

    Public Property UbicacionesNodesTable As HierarchyDS.HierarchyDataTable

#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As Guid)
        MyBase.New(sessionID)
        Me.PasillosTable = New DataTable
        UbicacionesNodesTable = New HierarchyDS.HierarchyDataTable
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Almacenes
''' </summary>
''' <remarks></remarks>
Public Class AlmacenService
    Inherits CatalogService(Of AlmacenInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Inventory", "Almacenes", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idAlmacen As Integer, ByRef Almacen As AlmacenInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idAlmacen, Almacen, checkStatus)
        With Almacen
            .Nombre = CStr(ItemInfo("Nombre"))
            .PermiteNegativos = CBool(ItemInfo("PermiteNegativos"))
            .RequiereCapturaFisico = CBool(ItemInfo("ReqCapturaFisico"))
            .IdArea = CInt(ItemInfo("IdArea"))
            .IdCuenta = CInt(ItemInfo("IdCuenta"))
        End With
    End Sub

    Public Overrides Function Update(ByVal Almacen As AlmacenInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = Almacen.Nombre
            .Add("@PermiteNegativos", DbType.Boolean).Value = Almacen.PermiteNegativos
            .Add("@ReqCapturaFisico", DbType.Boolean).Value = Almacen.RequiereCapturaFisico
            .Add("@IdArea", DbType.Int32).Value = Almacen.IdArea
            .Add("@IdCuenta", DbType.Int32).Value = Almacen.IdCuenta
        End With
        Dim identity As Integer = MyBase.Update(Almacen)
        UbicacionesUPD(identity, Almacen)
        Return identity
    End Function

    Public Overrides Function Create() As AlmacenInfo
        Return New AlmacenInfo(sessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de Almacenes
''' </summary>
''' <remarks></remarks>
Public Class AlmacenFacade
    Inherits CatalogFacade(Of AlmacenInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un AlmacenInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As Guid) As AlmacenInfo
        Dim AlmacenSvc As New AlmacenService(sessionID)
        Return AlmacenSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de Almacenes
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idAlmacen">Identificador del Almacen que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As Guid, ByVal idAlmacen As Integer)
        Dim AlmacenSvc As New AlmacenService(sessionID)
        Delete(AlmacenSvc, idAlmacen)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Almacen con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idAlmacen">ID de Almacen que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As Guid, ByVal idAlmacen As Integer) As Boolean
        Dim AlmacenSvc As New AlmacenService(sessionID)
        Return Exists(AlmacenSvc, idAlmacen)
    End Function

    ''' <summary>
    ''' Verifica si existe un Almacen con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim AlmacenSvc As New AlmacenService(sessionID)
        Return Exists(AlmacenSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Almacen.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idAlmacen">Identificador de Almacen a consultar</param>
    ''' <returns>Paquete de información de tipo AlmacenInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As Guid, ByVal idAlmacen As Integer) As AlmacenInfo
        Return Me.GetDetail(sessionID, idAlmacen, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Almacen.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idAlmacen">Identificador de Almacen</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Almacen.</param>
    ''' <returns>Paquete de información de tipo AlmacenInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idAlmacen As Integer, ByVal checkStatus As Boolean) As AlmacenInfo
        Dim AlmacenSvc As New AlmacenService(sessionID)
        Dim AlmacenInf As New AlmacenInfo(sessionID)
        GetDetail(AlmacenSvc, AlmacenInf, idAlmacen, checkStatus)
        Return AlmacenInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un Almacen en base a su codigo de usuario
    ''' y verifica que el Almacen esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información AlmacenInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As AlmacenInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Almacen en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Almacen</param>
    ''' <returns>Paquete de información AlmacenInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As AlmacenInfo
        Dim AlmacenInf As New AlmacenInfo(sessionID)
        Dim AlmacenSvc As New AlmacenService(sessionID)
        GetDetail(AlmacenSvc, AlmacenInf, userCode, idSucursal, checkStatus)
        Return AlmacenInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Almacen.
    ''' </summary>
    ''' <param name="Almacen">Paquete de información del tipo AlmacenInfo con la información a actualizar</param>
    ''' <returns>Identificador de Almacen, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Almacen As AlmacenInfo) As Integer
        Dim AlmacenSvc As New AlmacenService(Almacen.SessionID)
        Return Update(AlmacenSvc, Almacen)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim AlmacenSvc As New AlmacenService(sessionID)
        Return GetNumberOfPages(AlmacenSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Almacenes que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca Almacenes que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim AlmacenSvc As New AlmacenService(sessionID)
        Return GetSearchResult(AlmacenSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Almacenes.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim AlmacenSvc As New AlmacenService(sessionID)
        Return GetSearchStructure(AlmacenSvc)
    End Function

#End Region

End Class
