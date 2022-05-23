''' <summary>
''' Paquete de información que representa un Producto
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class ProductoInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property IdArticuloStock As Integer

    Public Property Cantidad As Decimal

    Public Property IdUnidadMedida As Integer

    Public Property MultiploProduccion As Integer

    Public Property EntregasParciales As Boolean

    Public Property ExigirRecepcion As Boolean

    Public Property IdCuenta As Integer

    Public Property InsumosTable As ProductosDS.InsumosDataTable

    Public Property EnsambladosTable As ProductosDS.EnsabladosDataTable

#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
        InsumosTable = New ProductosDS.InsumosDataTable
        EnsambladosTable = New ProductosDS.EnsabladosDataTable
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Productos
''' </summary>
''' <remarks></remarks>
Public Class ProductoService
    Inherits CatalogService(Of ProductoInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Production", "Productos", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idProducto As Integer, ByRef Producto As ProductoInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idProducto, Producto, checkStatus)
        With Producto
            .Nombre = CStr(ItemInfo("Nombre"))
            .IdArticuloStock = CInt(ItemInfo("IdArticuloStock"))
            .Cantidad = CDec(ItemInfo("Cantidad"))
            .IdUnidadMedida = CInt(ItemInfo("IdUnidadMedida"))
            .MultiploProduccion = CInt(ItemInfo("MultiploProduccion"))
            .EntregasParciales = CBool(ItemInfo("EntregasParciales"))
            .ExigirRecepcion = CBool(ItemInfo("ExigirRecepcion"))
            .IdCuenta = CInt(ItemInfo("IdCuenta"))
            loadInsumos(Producto)
            loadEnsamblados(Producto)
        End With
    End Sub

    Public Overrides Function Update(ByVal Producto As ProductoInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = Producto.Nombre
            .Add("@IdArticuloStock", DbType.Int32).Value = Producto.IdArticuloStock
            .Add("@Cantidad", DbType.Decimal).Value = Producto.Cantidad
            .Add("@IdUnidadMedida", DbType.Int32).Value = Producto.IdUnidadMedida
            .Add("@MultiploProduccion", DbType.Int32).Value = Producto.MultiploProduccion
            .Add("@EntregasParciales", DbType.Boolean).Value = Producto.EntregasParciales
            .Add("@ExigirRecepcion", DbType.Boolean).Value = Producto.ExigirRecepcion
            .Add("@IdCuenta", DbType.Int32).Value = Producto.IdCuenta
            saveInsumos(Producto)
            saveEnsamblados(Producto)
        End With
        Return MyBase.Update(Producto)
    End Function

    Public Overrides Function Create() As ProductoInfo
        Return New ProductoInfo(sessionID)
    End Function

#End Region

#Region "Metodos Privados"


    Private Sub loadInsumos(ByVal info As ProductoInfo)
        Try
            info.InsumosTable.Rows.Clear()
            Dim fx As New FunctionSQL("Production", "fxProductosInsumosSEL", Connection, Transaction)
            fx.Parameters.Add("@IdProducto", DbType.Int32).Value = info.Identity
            fx.FillDataTable(info.InsumosTable)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de insumos.", ex)
        End Try
    End Sub

    Private Sub loadEnsamblados(ByVal info As ProductoInfo)
        Try
            info.EnsambladosTable.Rows.Clear()
            Dim fx As New FunctionSQL("Production", "fxProductosEnsamblesSEL", Connection, Transaction)
            fx.Parameters.Add("@IdProducto", DbType.Int32).Value = info.Identity
            fx.FillDataTable(info.EnsambladosTable)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de ensamblados.", ex)
        End Try
    End Sub

    Private Sub saveInsumos(ByVal info As ProductoInfo)
        Try
            Dim cmdInsert As New Azteca.Data.DbCommand("Production.ProductosInsumosUPD", Connection, Transaction)
            cmdInsert.CommandType = CommandType.StoredProcedure

            cmdInsert.Parameters.Add("@IdProducto", DbType.Int32).Value = info.Identity
            cmdInsert.Parameters.Add("@IdInsumo", DbType.Int32, "IdInsumo")
            cmdInsert.Parameters.Add("@IdUnidadMedida", DbType.Int32, "IdUnidadMedida")
            cmdInsert.Parameters.Add("@Cantidad", DbType.Decimal, "Cantidad")
            cmdInsert.Parameters.Add("@IdMetaAlmacen", DbType.Int32, "IdMetaAlmacen")
            cmdInsert.Parameters.Add("@PorcMerma", DbType.Int32, "PorcMerma")
            cmdInsert.Parameters.Add("@Opcional", DbType.Boolean, "Opcional")

            Dim cmdDelete As New Azteca.Data.DbCommand("Production.ProductosInsumosDEL", Connection, Transaction)
            cmdDelete.Parameters.Add("@IdProducto", DbType.Int32).Value = info.Identity
            cmdDelete.Parameters.Add("@IdInsumo", DbType.Int32, "IdInsumo")
            cmdDelete.CommandType = CommandType.StoredProcedure

            'Actualizar Insumos
            Dim da As New Azteca.Data.DataAdapter()
            da.UpdateCommand = cmdInsert
            da.InsertCommand = cmdInsert
            da.DeleteCommand = cmdDelete
            da.Update(info.InsumosTable)
        Catch concurrencyEx As System.Data.DBConcurrencyException
        Catch ex As Exception
            Throw New BusinessException("Error al guardar la lista de insumos.", ex)
        End Try

    End Sub

    Private Sub saveEnsamblados(ByVal info As ProductoInfo)
        Try
            Dim cmdInsert As New Azteca.Data.DbCommand("Production.ProductosEnsamblesUPD", Connection, Transaction)
            cmdInsert.CommandType = CommandType.StoredProcedure

            cmdInsert.Parameters.Add("@IdProducto", DbType.Int32).Value = info.Identity
            cmdInsert.Parameters.Add("@IdSubProducto", DbType.Int32, "IdSubProducto")
            cmdInsert.Parameters.Add("@IdUnidadMedida", DbType.Int32, "IdUnidadMedida")
            cmdInsert.Parameters.Add("@Cantidad", DbType.Decimal, "Cantidad")
            cmdInsert.Parameters.Add("@IdMetaAlmacen", DbType.Int32, "IdMetaAlmacen")
            cmdInsert.Parameters.Add("@PorcMerma", DbType.Int32, "PorcMerma")
            cmdInsert.Parameters.Add("@Opcional", DbType.Boolean, "Opcional")
            cmdInsert.Parameters.Add("@OrdenSeparada", DbType.Boolean, "OrdenSeparada")

            Dim cmdDelete As New Azteca.Data.DbCommand("Production.ProductosEnsamblesDEL", Connection, Transaction)
            cmdDelete.Parameters.Add("@IdProducto", DbType.Int32).Value = info.Identity
            cmdDelete.Parameters.Add("@IdSubProducto", DbType.Int32, "IdSubProducto")
            cmdDelete.CommandType = CommandType.StoredProcedure

            'Actualizar Insumos
            Dim da As New Azteca.Data.DataAdapter()
            da.UpdateCommand = cmdInsert
            da.InsertCommand = cmdInsert
            da.DeleteCommand = cmdDelete
            da.Update(info.EnsambladosTable)
        Catch concurrencyEx As System.Data.DBConcurrencyException
        Catch ex As Exception
            Throw New BusinessException("Error al guardar la lista de ensamblados.", ex)
        End Try
    End Sub

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de Productos
''' </summary>
''' <remarks></remarks>
Public Class ProductoFacade
    Inherits CatalogFacade(Of ProductoInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un ProductoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As ProductoInfo
        Dim ProductoSvc As New ProductoService(sessionID)
        Return ProductoSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de Productos
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idProducto">Identificador del Producto que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idProducto As Integer)
        Dim ProductoSvc As New ProductoService(sessionID)
        Delete(ProductoSvc, idProducto)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Producto con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idProducto">ID de Producto que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idProducto As Integer) As Boolean
        Dim ProductoSvc As New ProductoService(sessionID)
        Return Exists(ProductoSvc, idProducto)
    End Function

    ''' <summary>
    ''' Verifica si existe un Producto con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim ProductoSvc As New ProductoService(sessionID)
        Return Exists(ProductoSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Producto.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idProducto">Identificador de Producto a consultar</param>
    ''' <returns>Paquete de información de tipo ProductoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idProducto As Integer) As ProductoInfo
        Return Me.GetDetail(sessionID, idProducto, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Producto.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idProducto">Identificador de Producto</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Producto.</param>
    ''' <returns>Paquete de información de tipo ProductoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idProducto As Integer, ByVal checkStatus As Boolean) As ProductoInfo
        Dim ProductoSvc As New ProductoService(sessionID)
        Dim ProductoInf As New ProductoInfo(sessionID)
        GetDetail(ProductoSvc, ProductoInf, idProducto, checkStatus)
        Return ProductoInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un Producto en base a su codigo de usuario
    ''' y verifica que el Producto esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información ProductoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As ProductoInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Producto en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Producto</param>
    ''' <returns>Paquete de información ProductoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As ProductoInfo
        Dim ProductoInf As New ProductoInfo(sessionID)
        Dim ProductoSvc As New ProductoService(sessionID)
        GetDetail(ProductoSvc, ProductoInf, userCode, idSucursal, checkStatus)
        Return ProductoInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Producto.
    ''' </summary>
    ''' <param name="Producto">Paquete de información del tipo ProductoInfo con la información a actualizar</param>
    ''' <returns>Identificador de Producto, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Producto As ProductoInfo) As Integer
        Dim ProductoSvc As New ProductoService(Producto.SessionID)
        Return Update(ProductoSvc, Producto)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim ProductoSvc As New ProductoService(sessionID)
        Return GetNumberOfPages(ProductoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Productos que coincidan con las condiciones especificadas.
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
    ''' Busca Productos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim ProductoSvc As New ProductoService(sessionID)
        Return GetSearchResult(ProductoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Productos.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim ProductoSvc As New ProductoService(sessionID)
        Return GetSearchStructure(ProductoSvc)
    End Function

#End Region

End Class
