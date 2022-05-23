''' <summary>
''' Paquete de información que representa un CategoriaPresupuestal
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class CategoriaPresupuestalInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property IdCuenta As Integer

    Public Property IdCategoriaFlujo As Integer


#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As Guid)
        MyBase.New(sessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de CategoriasPresupuestales
''' </summary>
''' <remarks></remarks>
Public Class CategoriaPresupuestalService
    Inherits CatalogService(Of CategoriaPresupuestalInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As guid)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As guid, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As guid, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Purchasing", "CategoriasPresupuestales", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idCategoriaPresupuestal As Integer, ByRef CategoriaPresupuestal As CategoriaPresupuestalInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idCategoriaPresupuestal, CategoriaPresupuestal, checkStatus)
        With CategoriaPresupuestal
            .Nombre = CStr(ItemInfo("Nombre"))
            .IdCuenta = CInt(ItemInfo("IdCuenta"))
            .IdCategoriaFlujo = CInt(ItemInfo("IdCategoriaFlujo"))

        End With
    End Sub

    Public Overrides Function Update(ByVal CategoriaPresupuestal As CategoriaPresupuestalInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = CategoriaPresupuestal.Nombre
            .Add("@IdCuenta", DbType.Int32).Value = CategoriaPresupuestal.IdCuenta
            '.Add("@IdCategoriaFlujo", DbType.Int32).Value = CategoriaPresupuestal.IdCategoriaFlujo

        End With
        Return MyBase.Update(CategoriaPresupuestal)
    End Function

    Public Overrides Function Create() As CategoriaPresupuestalInfo
        Return New CategoriaPresupuestalInfo(sessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de CategoriasPresupuestales
''' </summary>
''' <remarks></remarks>
Public Class CategoriaPresupuestalFacade
    Inherits CatalogFacade(Of CategoriaPresupuestalInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un CategoriaPresupuestalInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As guid) As CategoriaPresupuestalInfo
        Dim CategoriaPresupuestalSvc As New CategoriaPresupuestalService(sessionID)
        Return CategoriaPresupuestalSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de CategoriasPresupuestales
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCategoriaPresupuestal">Identificador del CategoriaPresupuestal que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As guid, ByVal idCategoriaPresupuestal As Integer)
        Dim CategoriaPresupuestalSvc As New CategoriaPresupuestalService(sessionID)
        Delete(CategoriaPresupuestalSvc, idCategoriaPresupuestal)
    End Sub

    ''' <summary>
    ''' Verifica si existe un CategoriaPresupuestal con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCategoriaPresupuestal">ID de CategoriaPresupuestal que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As guid, ByVal idCategoriaPresupuestal As Integer) As Boolean
        Dim CategoriaPresupuestalSvc As New CategoriaPresupuestalService(sessionID)
        Return Exists(CategoriaPresupuestalSvc, idCategoriaPresupuestal)
    End Function

    ''' <summary>
    ''' Verifica si existe un CategoriaPresupuestal con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As guid, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim CategoriaPresupuestalSvc As New CategoriaPresupuestalService(sessionID)
        Return Exists(CategoriaPresupuestalSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un CategoriaPresupuestal.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCategoriaPresupuestal">Identificador de CategoriaPresupuestal a consultar</param>
    ''' <returns>Paquete de información de tipo CategoriaPresupuestalInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As guid, ByVal idCategoriaPresupuestal As Integer) As CategoriaPresupuestalInfo
        Return Me.GetDetail(sessionID, idCategoriaPresupuestal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un CategoriaPresupuestal.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCategoriaPresupuestal">Identificador de CategoriaPresupuestal</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del CategoriaPresupuestal.</param>
    ''' <returns>Paquete de información de tipo CategoriaPresupuestalInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As guid, ByVal idCategoriaPresupuestal As Integer, ByVal checkStatus As Boolean) As CategoriaPresupuestalInfo
        Dim CategoriaPresupuestalSvc As New CategoriaPresupuestalService(sessionID)
        Dim CategoriaPresupuestalInf As New CategoriaPresupuestalInfo(sessionID)
        GetDetail(CategoriaPresupuestalSvc, CategoriaPresupuestalInf, idCategoriaPresupuestal, checkStatus)
        Return CategoriaPresupuestalInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un CategoriaPresupuestal en base a su codigo de usuario
    ''' y verifica que el CategoriaPresupuestal esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información CategoriaPresupuestalInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As guid, ByVal userCode As String, ByVal idSucursal As Integer) As CategoriaPresupuestalInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un CategoriaPresupuestal en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del CategoriaPresupuestal</param>
    ''' <returns>Paquete de información CategoriaPresupuestalInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As guid, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As CategoriaPresupuestalInfo
        Dim CategoriaPresupuestalInf As New CategoriaPresupuestalInfo(sessionID)
        Dim CategoriaPresupuestalSvc As New CategoriaPresupuestalService(sessionID)
        GetDetail(CategoriaPresupuestalSvc, CategoriaPresupuestalInf, userCode, idSucursal, checkStatus)
        Return CategoriaPresupuestalInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un CategoriaPresupuestal.
    ''' </summary>
    ''' <param name="CategoriaPresupuestal">Paquete de información del tipo CategoriaPresupuestalInfo con la información a actualizar</param>
    ''' <returns>Identificador de CategoriaPresupuestal, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal CategoriaPresupuestal As CategoriaPresupuestalInfo) As Integer
        Dim CategoriaPresupuestalSvc As New CategoriaPresupuestalService(CategoriaPresupuestal.SessionID)
        Return Update(CategoriaPresupuestalSvc, CategoriaPresupuestal)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim CategoriaPresupuestalSvc As New CategoriaPresupuestalService(sessionID)
        Return GetNumberOfPages(CategoriaPresupuestalSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca CategoriasPresupuestales que coincidan con las condiciones especificadas.
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
    ''' Busca CategoriasPresupuestales que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim CategoriaPresupuestalSvc As New CategoriaPresupuestalService(sessionID)
        Return GetSearchResult(CategoriaPresupuestalSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de CategoriasPresupuestales.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As guid) As System.Data.DataSet
        Dim CategoriaPresupuestalSvc As New CategoriaPresupuestalService(sessionID)
        Return GetSearchStructure(CategoriaPresupuestalSvc)
    End Function

#End Region

End Class
