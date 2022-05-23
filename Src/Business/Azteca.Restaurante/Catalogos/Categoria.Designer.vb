''' <summary>
''' Paquete de información que representa un Categoria
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class CategoriaInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property Imagen As Byte()

    Public Property Color As String

    Public Property IdCuenta As Integer

    Public Property ArticulosTable As ArticulosConfigDS.CentroProduccionArticuloDataTable

#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
        ArticulosTable = New ArticulosConfigDS.CentroProduccionArticuloDataTable
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Categorias
''' </summary>
''' <remarks></remarks>
Public Class CategoriaService
    Inherits CatalogService(Of CategoriaInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Restaurant", "Categorias", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idCategoria As Integer, ByRef Categoria As CategoriaInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idCategoria, Categoria, checkStatus)
        With Categoria
            .Nombre = CStr(ItemInfo("Nombre"))
            If Not IsDBNull(ItemInfo("Imagen")) Then
                .Imagen = CType(ItemInfo("Imagen"), Byte())
            End If
            If Val(CStr(ItemInfo("Color"))) <> 0 Then .Color = CStr(ItemInfo("Color"))
            .IdCuenta = CInt(ItemInfo("IdCuenta"))
        End With
        loadArticulos(Categoria)
    End Sub

    Public Overrides Function Update(ByVal Categoria As CategoriaInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = Categoria.Nombre
            If Categoria.Imagen Is Nothing Then
                .Add("@Imagen", DbType.Binary).Value = DBNull.Value
            Else
                .Add("@Imagen", DbType.Binary).Value = Categoria.Imagen
            End If
            .Add("@Color", DbType.String).Value = Categoria.Color
            .Add("@IdCuenta", DbType.Int32).Value = Categoria.IdCuenta
        End With
        Dim Id As Integer = MyBase.Update(Categoria)
        setArticulos(Categoria)
        Return Id
    End Function

    Public Overrides Function Create() As CategoriaInfo
        Return New CategoriaInfo(sessionID)
    End Function

#End Region

#Region "Metodos Privados"
    Private Sub loadArticulos(ByVal info As CategoriaInfo)
        Try
            info.ArticulosTable.Rows.Clear()
            Dim fx As New FunctionSQL("Restaurant", "fxCategoriasArticulosSEL", Connection, Transaction)
            fx.Parameters.Add("@IdCategoria", DbType.Int32).Value = info.Identity
            fx.FillDataTable(info.ArticulosTable)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de articulos.", ex)
        End Try

    End Sub

    Private Sub setArticulos(ByVal info As CategoriaInfo)
        Try
            'Definir comando de actualización de detalle de racs
            Dim cmdInsert As New Azteca.Data.DbCommand("Restaurant.CategoriasArticulosUPD", Connection, Transaction)
            cmdInsert.CommandType = CommandType.StoredProcedure

            cmdInsert.Parameters.Add("@IdCategoria", DbType.Int32).Value = info.Identity
            cmdInsert.Parameters.Add("@IdArticulo", DbType.Int32, "IdArticulo")

            Dim cmdDelete As New Azteca.Data.DbCommand("Restaurant.CategoriasArticulosDEL", Connection, Transaction)
            cmdDelete.Parameters.Add("@IdCategoria", DbType.Int32).Value = info.Identity
            cmdDelete.Parameters.Add("@IdArticulo", DbType.Int32, "IdArticulo")

            cmdDelete.CommandType = CommandType.StoredProcedure

            'Actualizar Articulos
            Dim da As New Azteca.Data.DataAdapter()
            da.UpdateCommand = cmdInsert
            da.InsertCommand = cmdInsert
            da.DeleteCommand = cmdDelete
            da.Update(info.ArticulosTable)
        Catch concurrencyEx As System.Data.DBConcurrencyException
        Catch ex As Exception
            Throw New BusinessException("Error al guardar la lista de articulos.", ex)
        End Try
    End Sub

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de Categorias
''' </summary>
''' <remarks></remarks>
Public Class CategoriaFacade
    Inherits CatalogFacade(Of CategoriaInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un CategoriaInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As CategoriaInfo
        Dim CategoriaSvc As New CategoriaService(sessionID)
        Return CategoriaSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de Categorias
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCategoria">Identificador del Categoria que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idCategoria As Integer)
        Dim CategoriaSvc As New CategoriaService(sessionID)
        Delete(CategoriaSvc, idCategoria)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Categoria con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCategoria">ID de Categoria que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idCategoria As Integer) As Boolean
        Dim CategoriaSvc As New CategoriaService(sessionID)
        Return Exists(CategoriaSvc, idCategoria)
    End Function

    ''' <summary>
    ''' Verifica si existe un Categoria con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim CategoriaSvc As New CategoriaService(sessionID)
        Return Exists(CategoriaSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Categoria.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCategoria">Identificador de Categoria a consultar</param>
    ''' <returns>Paquete de información de tipo CategoriaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idCategoria As Integer) As CategoriaInfo
        Return Me.GetDetail(sessionID, idCategoria, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Categoria.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCategoria">Identificador de Categoria</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Categoria.</param>
    ''' <returns>Paquete de información de tipo CategoriaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idCategoria As Integer, ByVal checkStatus As Boolean) As CategoriaInfo
        Dim CategoriaSvc As New CategoriaService(sessionID)
        Dim CategoriaInf As New CategoriaInfo(sessionID)
        GetDetail(CategoriaSvc, CategoriaInf, idCategoria, checkStatus)
        Return CategoriaInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un Categoria en base a su codigo de usuario
    ''' y verifica que el Categoria esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información CategoriaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As CategoriaInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Categoria en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Categoria</param>
    ''' <returns>Paquete de información CategoriaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As CategoriaInfo
        Dim CategoriaInf As New CategoriaInfo(sessionID)
        Dim CategoriaSvc As New CategoriaService(sessionID)
        GetDetail(CategoriaSvc, CategoriaInf, userCode, idSucursal, checkStatus)
        Return CategoriaInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Categoria.
    ''' </summary>
    ''' <param name="Categoria">Paquete de información del tipo CategoriaInfo con la información a actualizar</param>
    ''' <returns>Identificador de Categoria, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Categoria As CategoriaInfo) As Integer
        Dim CategoriaSvc As New CategoriaService(Categoria.SessionID)
        Return Update(CategoriaSvc, Categoria)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim CategoriaSvc As New CategoriaService(sessionID)
        Return GetNumberOfPages(CategoriaSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Categorias que coincidan con las condiciones especificadas.
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
    ''' Busca Categorias que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim CategoriaSvc As New CategoriaService(sessionID)
        Return GetSearchResult(CategoriaSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Categorias.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim CategoriaSvc As New CategoriaService(sessionID)
        Return GetSearchStructure(CategoriaSvc)
    End Function

#End Region

End Class
