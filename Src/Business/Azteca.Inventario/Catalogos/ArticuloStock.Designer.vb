Imports Azteca.Kernel

''' <summary>
''' Paquete de información que representa un ArticuloStock
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class ArticuloStockInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"
    Friend _IdTipoUnidadMedida As Integer
    Friend _UnidadMedida As String = String.Empty
    Friend _UnidadMedidaInfo As UnidadMedidaInfo
#End Region

#Region "Propiedades"
    Public Property Nombre As String = String.Empty

    Public Property Descripcion As String = String.Empty

    Public ReadOnly Property IdTipoUnidadMedida As Integer
        Get
            Return _IdTipoUnidadMedida
        End Get
    End Property

    Public ReadOnly Property UnidadMedida As String
        Get
            Return _UnidadMedida
        End Get
    End Property

    Public ReadOnly Property UnidadMedidaInfo As UnidadMedidaInfo
        Get
            Return _UnidadMedidaInfo
        End Get
    End Property

    Public ReadOnly Property TotalCosto As Decimal
        Get
            Return CostoMaterial + CostoCarga + CostoLabor + CostoServicio
        End Get
    End Property

    Public Property IdUnidadMedida As Integer

    Public Property StockMax As Decimal

    Public Property StockMin As Decimal

    Public Property PuntoReorden As Decimal

    Public Property UltimoCosto As Decimal

    Public Property CostoPromedio As Decimal

    Public Property Orden As Integer

    Public Property EAN As String = String.Empty

    Public Property Origen As String = String.Empty

    Public Property IdCuenta As Integer

    Public Property Imagen As Byte()

    Public Property IdColor As Integer

    Public Property IdTalla As Integer

    Public Property CostoMaterial As Decimal

    Public Property CostoLabor As Decimal

    Public Property CostoServicio As Decimal

    Public Property CostoCarga As Decimal

    Public Property IdTipo As Integer

    Public Property IdFamilia As Integer

    Public Property VersionMaster As Integer

    Public Property FactorFabricacion As Integer

    Public Property CantidadFija As Int16



#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
        _UnidadMedidaInfo = New UnidadMedidaInfo(sessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de ArticulosStock
''' </summary>
''' <remarks></remarks>
Public Class ArticuloStockService
    Inherits CatalogService(Of ArticuloStockInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Inventory", "ArticulosStock", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran

    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idArticuloStock As Integer, ByRef ArticuloStock As ArticuloStockInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idArticuloStock, ArticuloStock, checkStatus)
        With ArticuloStock
            .Nombre = CStr(ItemInfo("Nombre"))
            .Descripcion = CStr(ItemInfo("Descripcion"))
            .IdUnidadMedida = CInt(ItemInfo("IdUnidadMedida"))
            ._IdTipoUnidadMedida = CInt(ItemInfo("IdUnidadMedidaTipo"))
            ._UnidadMedida = ItemInfo("UnidadMedida").ToString
            .StockMax = CDec(ItemInfo("StockMax"))
            .StockMin = CDec(ItemInfo("StockMin"))
            .PuntoReorden = CDec(ItemInfo("PuntoReorden"))
            .UltimoCosto = CDec(ItemInfo("UltimoCosto"))
            .CostoPromedio = CDec(ItemInfo("CostoPromedio"))
            .Orden = CInt(ItemInfo("Orden"))
            .EAN = CStr(ItemInfo("EAN"))
            .Origen = CStr(ItemInfo("Origen"))
            .IdCuenta = CInt(ItemInfo("IdCuenta"))
            .IdTalla = CInt(ItemInfo("IdTalla"))
            .IdColor = CInt(ItemInfo("IdColor"))

            Dim umFac = New UnidadMedidaFacade()
            ._UnidadMedidaInfo = umFac.GetDetail(SessionID, .IdUnidadMedida)

            If (ItemInfo("CostoMaterial") IsNot DBNull.Value) Then
                .CostoMaterial = CDec(ItemInfo("CostoMaterial")) * ._UnidadMedidaInfo.Factor
            End If
            If (ItemInfo("CostoLabor") IsNot DBNull.Value) Then
                .CostoLabor = CDec(ItemInfo("CostoLabor")) * ._UnidadMedidaInfo.Factor
            End If
            If (ItemInfo("CostoServicio") IsNot DBNull.Value) Then
                .CostoServicio = CDec(ItemInfo("CostoServicio")) * ._UnidadMedidaInfo.Factor
            End If
            If (ItemInfo("CostoCarga") IsNot DBNull.Value) Then
                .CostoCarga = CDec(ItemInfo("CostoCarga")) * ._UnidadMedidaInfo.Factor
            End If
            If (ItemInfo("IdTipo") IsNot DBNull.Value) Then
                .IdTipo = CInt(ItemInfo("IdTipo"))
            End If
            If (ItemInfo("IdFamilia") IsNot DBNull.Value) Then
                .IdFamilia = CInt(ItemInfo("IdFamilia"))
            End If

            If (ItemInfo("VersionMaster") IsNot DBNull.Value) Then
                .VersionMaster = CInt(ItemInfo("VersionMaster"))
            End If

            If (ItemInfo("FactorFabricacion") IsNot DBNull.Value) Then
                .FactorFabricacion = CInt(ItemInfo("FactorFabricacion"))
            End If

            If (ItemInfo("CantidadFija") IsNot DBNull.Value) Then
                .CantidadFija = CInt(ItemInfo("CantidadFija"))
            End If

        End With
    End Sub

    Public Overrides Function Update(ByVal ArticuloStock As ArticuloStockInfo) As Integer
        If Azteca.Kernel.Cache.Item("ArticuloStock" & ArticuloStock.Identity) IsNot Nothing Then Azteca.Kernel.Cache.Remove("ArticuloStock" & ArticuloStock.Identity)
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = ArticuloStock.Nombre
            .Add("@Descripcion", DbType.String).Value = ArticuloStock.Descripcion
            .Add("@IdUnidadMedida", DbType.Int32).Value = ArticuloStock.IdUnidadMedida
            .Add("@StockMax", DbType.Decimal).Value = ArticuloStock.StockMax
            .Add("@StockMin", DbType.Decimal).Value = ArticuloStock.StockMin
            .Add("@PuntoReorden", DbType.Decimal).Value = ArticuloStock.PuntoReorden
            .Add("@UltimoCosto", DbType.Decimal).Value = ArticuloStock.UltimoCosto
            .Add("@CostoPromedio", DbType.Decimal).Value = ArticuloStock.CostoPromedio
            .Add("@Orden", DbType.Int32).Value = ArticuloStock.Orden
            .Add("@EAN", DbType.String).Value = ArticuloStock.EAN
            .Add("@Origen", DbType.String).Value = ArticuloStock.Origen
            .Add("@IdCuenta", DbType.Int32).Value = ArticuloStock.IdCuenta
            If ArticuloStock.Imagen Is Nothing Then
                .Add("@Imagen", DbType.Binary).Value = DBNull.Value
            Else
                .Add("@Imagen", DbType.Binary).Value = ArticuloStock.Imagen
            End If
            .Add("@IdTalla", DbType.Int32).Value = ArticuloStock.IdTalla
            .Add("@IdColor", DbType.Int32).Value = ArticuloStock.IdColor

            Dim umFac As New UnidadMedidaFacade()
            If (ArticuloStock.UnidadMedidaInfo.Identity = 0) Then
                ArticuloStock._UnidadMedidaInfo = umFac.GetDetail(SessionID, ArticuloStock.IdUnidadMedida)
            End If

            .Add("@CostoMaterial", DbType.Decimal).Value = ArticuloStock.CostoMaterial / ArticuloStock.UnidadMedidaInfo.Factor
            .Add("@CostoLabor", DbType.Decimal).Value = ArticuloStock.CostoLabor / ArticuloStock.UnidadMedidaInfo.Factor
            .Add("@CostoServicio", DbType.Decimal).Value = ArticuloStock.CostoServicio / ArticuloStock.UnidadMedidaInfo.Factor
            .Add("@CostoCarga", DbType.Decimal).Value = ArticuloStock.CostoCarga / ArticuloStock.UnidadMedidaInfo.Factor
            .Add("@IdTipo", DbType.Int32).Value = ArticuloStock.IdTipo
            .Add("@IdFamilia", DbType.Int32).Value = ArticuloStock.IdFamilia
            .Add("@VersionMaster", DbType.Int32).Value = ArticuloStock.VersionMaster
            .Add("@FactorFabricacion", DbType.Int32).Value = ArticuloStock.FactorFabricacion
            .Add("@CantidadFija", DbType.Int16).Value = ArticuloStock.CantidadFija

        End With
        Dim IdArticuloStock As Integer = MyBase.Update(ArticuloStock)
        Dim CacheKey As String = "ArticuloStock" & IdArticuloStock
        If Cache.Item(CacheKey) IsNot Nothing Then Cache.Remove(CacheKey)
        Return IdArticuloStock
    End Function

    Public Overrides Function Create() As ArticuloStockInfo
        Return New ArticuloStockInfo(sessionID)
    End Function

    Public Shadows Function CodeToID(ByVal codigo As String, ByVal idSucursal As Integer) As Integer
        Return MyBase.CodeToID(codigo, idSucursal)
    End Function
#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de ArticulosStock
''' </summary>
''' <remarks></remarks>
Public Class ArticuloStockFacade
    Inherits CatalogFacade(Of ArticuloStockInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un ArticuloStockInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As ArticuloStockInfo
        Dim ArticuloStockSvc As New ArticuloStockService(sessionID)
        Return ArticuloStockSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de ArticulosStock
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idArticuloStock">Identificador del ArticuloStock que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idArticuloStock As Integer)
        Dim ArticuloStockSvc As New ArticuloStockService(sessionID)
        Delete(ArticuloStockSvc, idArticuloStock)
    End Sub

    ''' <summary>
    ''' Verifica si existe un ArticuloStock con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idArticuloStock">ID de ArticuloStock que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idArticuloStock As Integer) As Boolean
        Dim ArticuloStockSvc As New ArticuloStockService(sessionID)
        Return Exists(ArticuloStockSvc, idArticuloStock)
    End Function

    ''' <summary>
    ''' Verifica si existe un ArticuloStock con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim ArticuloStockSvc As New ArticuloStockService(sessionID)
        Return Exists(ArticuloStockSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un ArticuloStock.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idArticuloStock">Identificador de ArticuloStock a consultar</param>
    ''' <returns>Paquete de información de tipo ArticuloStockInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idArticuloStock As Integer) As ArticuloStockInfo
        Return Me.GetDetail(sessionID, idArticuloStock, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un ArticuloStock.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idArticuloStock">Identificador de ArticuloStock</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del ArticuloStock.</param>
    ''' <returns>Paquete de información de tipo ArticuloStockInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idArticuloStock As Integer, ByVal checkStatus As Boolean) As ArticuloStockInfo
        Dim ArticuloStockSvc As New ArticuloStockService(sessionID)
        Dim ArticuloStockInf As New ArticuloStockInfo(sessionID)
        GetDetail(ArticuloStockSvc, ArticuloStockInf, idArticuloStock, checkStatus)
        Return ArticuloStockInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un ArticuloStock en base a su codigo de usuario
    ''' y verifica que el ArticuloStock esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información ArticuloStockInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As ArticuloStockInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un ArticuloStock en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del ArticuloStock</param>
    ''' <returns>Paquete de información ArticuloStockInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As ArticuloStockInfo
        Dim ArticuloStockInf As New ArticuloStockInfo(sessionID)
        Dim ArticuloStockSvc As New ArticuloStockService(sessionID)
        GetDetail(ArticuloStockSvc, ArticuloStockInf, userCode, idSucursal, checkStatus)
        Return ArticuloStockInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un ArticuloStock.
    ''' </summary>
    ''' <param name="ArticuloStock">Paquete de información del tipo ArticuloStockInfo con la información a actualizar</param>
    ''' <returns>Identificador de ArticuloStock, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal ArticuloStock As ArticuloStockInfo) As Integer
        Dim ArticuloStockSvc As New ArticuloStockService(ArticuloStock.SessionID)
        Return Update(ArticuloStockSvc, ArticuloStock)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim ArticuloStockSvc As New ArticuloStockService(sessionID)
        Return GetNumberOfPages(ArticuloStockSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca ArticulosStock que coincidan con las condiciones especificadas.
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
    ''' Busca ArticulosStock que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim ArticuloStockSvc As New ArticuloStockService(sessionID)
        Return GetSearchResult(ArticuloStockSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de ArticulosStock.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim ArticuloStockSvc As New ArticuloStockService(sessionID)
        Return GetSearchStructure(ArticuloStockSvc)
    End Function

#End Region

End Class
