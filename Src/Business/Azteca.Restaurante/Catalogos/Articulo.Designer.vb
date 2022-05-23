''' <summary>
''' Paquete de información que representa un Articulo
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class ArticuloInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"

    Public Property IdCategoria As Integer

    Public Property Imagen As Byte()

    Public Property Color As String

    Public Property IdCuenta As Integer

    Public Property ArticuloStock As Azteca.Business.Inventario.ArticuloStockInfo

#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
        ArticuloStock = New Azteca.Business.Inventario.ArticuloStockInfo(sessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Articulos
''' </summary>
''' <remarks></remarks>
Public Class ArticuloService
    Inherits CatalogService(Of ArticuloInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Restaurant", "Articulos", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idArticulo As Integer, ByRef Articulo As ArticuloInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idArticulo, Articulo, checkStatus)

        With Articulo
            .IdCategoria = CInt(ItemInfo("IdCategoria"))
            If Not IsDBNull(ItemInfo("Imagen")) Then
                .Imagen = CType(ItemInfo("Imagen"), Byte())
            End If
            .Color = CStr(ItemInfo("Color"))
            .IdCuenta = CInt(ItemInfo("IdCuenta"))

            Dim ArtStockSvc As New Inventario.ArticuloStockService(SessionID, Me.Connection, Me.Transaction)
            ArtStockSvc.GetDetail(CInt(ItemInfo("IdArticuloStock")), .ArticuloStock, False)
        End With
    End Sub

    Public Overrides Function Update(ByVal Articulo As ArticuloInfo) As Integer
        Dim ArtStockSvc As New Inventario.ArticuloStockService(SessionID, Me.Connection, Me.Transaction)
        ArtStockSvc.Update(Articulo.ArticuloStock)

        With Me.SPUpdate.Parameters
            .Add("@IdArticuloStock", DbType.Int32).Value = Articulo.ArticuloStock.Identity
            .Add("@IdCategoria", DbType.Int32).Value = Articulo.IdCategoria
            If Articulo.Imagen Is Nothing Then
                .Add("@Imagen", DbType.Binary).Value = DBNull.Value
            Else
                .Add("@Imagen", DbType.Binary).Value = Articulo.Imagen
            End If
            .Add("@Color", DbType.String).Value = Articulo.Color
            .Add("@IdCuenta", DbType.Int32).Value = Articulo.IdCuenta
        End With
        Return MyBase.Update(Articulo)
    End Function

    Public Overrides Function Create() As ArticuloInfo
        Return New ArticuloInfo(sessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de Articulos
''' </summary>
''' <remarks></remarks>
Public Class ArticuloFacade
    Inherits CatalogFacade(Of ArticuloInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un ArticuloInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As ArticuloInfo
        Dim ArticuloSvc As New ArticuloService(sessionID)
        Return ArticuloSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de Articulos
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idArticulo">Identificador del Articulo que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idArticulo As Integer)
        Dim ArticuloSvc As New ArticuloService(sessionID)
        Delete(ArticuloSvc, idArticulo)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Articulo con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idArticulo">ID de Articulo que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idArticulo As Integer) As Boolean
        Dim ArticuloSvc As New ArticuloService(sessionID)
        Return Exists(ArticuloSvc, idArticulo)
    End Function

    ''' <summary>
    ''' Verifica si existe un Articulo con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim ArticuloSvc As New ArticuloService(sessionID)
        Return Exists(ArticuloSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Articulo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idArticulo">Identificador de Articulo a consultar</param>
    ''' <returns>Paquete de información de tipo ArticuloInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idArticulo As Integer) As ArticuloInfo
        Return Me.GetDetail(sessionID, idArticulo, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Articulo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idArticulo">Identificador de Articulo</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Articulo.</param>
    ''' <returns>Paquete de información de tipo ArticuloInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idArticulo As Integer, ByVal checkStatus As Boolean) As ArticuloInfo
        Dim ArticuloSvc As New ArticuloService(sessionID)
        Dim ArticuloInf As New ArticuloInfo(sessionID)
        GetDetail(ArticuloSvc, ArticuloInf, idArticulo, checkStatus)
        Return ArticuloInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un Articulo en base a su codigo de usuario
    ''' y verifica que el Articulo esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información ArticuloInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As ArticuloInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Articulo en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Articulo</param>
    ''' <returns>Paquete de información ArticuloInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As ArticuloInfo
        Dim ArticuloInf As New ArticuloInfo(sessionID)
        Dim ArticuloSvc As New ArticuloService(sessionID)
        GetDetail(ArticuloSvc, ArticuloInf, userCode, idSucursal, checkStatus)
        Return ArticuloInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Articulo.
    ''' </summary>
    ''' <param name="Articulo">Paquete de información del tipo ArticuloInfo con la información a actualizar</param>
    ''' <returns>Identificador de Articulo, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Articulo As ArticuloInfo) As Integer
        Dim ArticuloSvc As New ArticuloService(Articulo.SessionID)
        Return Update(ArticuloSvc, Articulo)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim ArticuloSvc As New ArticuloService(sessionID)
        Return GetNumberOfPages(ArticuloSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Articulos que coincidan con las condiciones especificadas.
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
    ''' Busca Articulos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim ArticuloSvc As New ArticuloService(sessionID)
        Return GetSearchResult(ArticuloSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Articulos.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim ArticuloSvc As New ArticuloService(sessionID)
        Return GetSearchStructure(ArticuloSvc)
    End Function

#End Region

End Class
