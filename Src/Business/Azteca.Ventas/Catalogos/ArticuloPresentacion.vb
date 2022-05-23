Public Class PresentacionService
    Implements Azteca.Kernel.Search.ISearchable

#Region "Variables"
    Private _Cnn As IDbConnection
    Private _Tran As IDbTransaction
    Private _CatalogTable As String
    Private _CatalogSchema As String
    Private _Session As SessionInfo
    Protected SessionID As Guid
#End Region

#Region "Propiedades"
    Public Property Connection() As IDbConnection
        Get
            Return _Cnn
        End Get
        Set(ByVal Value As IDbConnection)
            _Cnn = Value
        End Set
    End Property

    Public Property Transaction() As IDbTransaction
        Get
            Return _Tran
        End Get
        Set(ByVal Value As IDbTransaction)
            _Tran = Value
        End Set
    End Property

    Public Property Session() As SessionInfo
        Get
            Return _Session
        End Get
        Set(ByVal Value As SessionInfo)
            _Session = Value
        End Set
    End Property

    Public ReadOnly Property CatalogTable() As String
        Get
            Return _CatalogTable
        End Get
    End Property

    Public ReadOnly Property CatalogSchema() As String
        Get
            Return _CatalogSchema
        End Get
    End Property
#End Region

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        Me._CatalogSchema = "Sales"
        Me._CatalogTable = "ArticulosPresentaciones"
        Me.SessionID = sessionID
        Me.Connection = cnn
        Me.Transaction = tran
        Session = Azteca.Kernel.Server.Sessions(sessionID)
    End Sub
#End Region

#Region "Search Interface"

    Public Function GetNumberOfPages(ByVal idSite As Integer, ByVal conditions As Kernel.Search.SearchConditionCollection) As Integer Implements Kernel.Search.ISearchable.GetNumberOfPages
        Dim sm As New Azteca.Kernel.Search.SearchManager(SessionID, Connection, Transaction)
        Return sm.GetNumberOfPages(CatalogSchema, CatalogTable, idSite, conditions)
    End Function

    Public Function GetSearchResult(ByVal idSite As Integer, ByVal conditions As Kernel.Search.SearchConditionCollection, ByVal order As Kernel.Search.SearchOrderCollection) As System.Data.DataSet Implements Kernel.Search.ISearchable.GetSearchResult
        Dim sm As New Azteca.Kernel.Search.SearchManager(SessionID, Connection, Transaction)
        Return sm.GetSearchStructure(CatalogSchema, CatalogTable)
    End Function

    Public Function GetSearchResult(ByVal idSite As Integer, ByVal conditions As Kernel.Search.SearchConditionCollection, ByVal order As Kernel.Search.SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet Implements Kernel.Search.ISearchable.GetSearchResult
        Dim sm As New Azteca.Kernel.Search.SearchManager(SessionID, Connection, Transaction)
        Return sm.Search(CatalogSchema, CatalogTable, idSite, conditions, order, page)
    End Function

    Public Function GetSearchStructure() As System.Data.DataSet Implements Kernel.Search.ISearchable.GetSearchStructure
        Dim sm As New Azteca.Kernel.Search.SearchManager(SessionID, Connection, Transaction)
        Return sm.GetSearchStructure(CatalogSchema, CatalogTable)
    End Function

#End Region

#Region "Metodos Generales"

    Public Function Exists(ByVal idArticuloStock As Integer) As Boolean
        Try
            Dim fxExists As New FunctionSQL("Sales", "fxArticuloPresentacionExists", Connection, Transaction)
            fxExists.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idArticuloStock
            Return CBool(fxExists.GetScalar)
        Catch ex As Exception
            Throw New BusinessException("Error al verificar la existencia del artículo: " & idArticuloStock, ex)
        End Try
    End Function

    Public Function Exists(ByVal codigo As String, ByVal idSucursal As Integer) As Boolean
        Try
            Dim ArticuloSvc As New Azteca.Business.Inventario.ArticuloStockService(SessionID, Connection, Transaction)
            Dim IdArticuloStock As Integer = ArticuloSvc.CodeToID(codigo, idSucursal)
            Return Exists(IdArticuloStock)
        Catch ex As Exception
            Throw New BusinessException("Error al verificar la existencia del artículo: " & codigo, ex)
        End Try
    End Function

    Public Function GetDetail(ByVal idArticuloStock As Integer) As Azteca.Business.Inventario.ArticuloStockInfo
        Try
            If Exists(idArticuloStock) Then
                Dim Articulo As New Azteca.Business.Inventario.ArticuloStockInfo(SessionID)
                Dim ArticuloSvc As New Azteca.Business.Inventario.ArticuloStockService(SessionID, Connection, Transaction)
                ArticuloSvc.GetDetail(idArticuloStock, Articulo, False)
                Return Articulo
            Else
                Throw New BusinessException("No se encontró el artículo o no está configurado para venta")
            End If
        Catch ex As Exception
            Throw New BusinessException("Error al cargar información del artículo: " & idArticuloStock.ToString, ex)
        End Try
    End Function

    Public Function GetDetail(ByVal codigo As String, ByVal idSucursal As Integer) As Azteca.Business.Inventario.ArticuloStockInfo
        Try
            If Exists(codigo, idSucursal) Then
                Dim Articulo As New Azteca.Business.Inventario.ArticuloStockInfo(SessionID)
                Dim ArticuloSvc As New Azteca.Business.Inventario.ArticuloStockService(SessionID, Connection, Transaction)
                ArticuloSvc.GetDetail(codigo, idSucursal, Articulo, False)
                Return Articulo
            Else
                Throw New BusinessException("No se encontró el artículo '" & codigo & "' o no está configurado para venta")
            End If
        Catch ex As Exception
            Throw New BusinessException("Error al cargar información del artículo: " & codigo, ex)
        End Try
    End Function

    Public Function GetDetailFromCache(ByVal idArticuloStock As Integer) As Azteca.Business.Inventario.ArticuloStockInfo
        Try
            If Exists(idArticuloStock) Then
                Dim ArticuloSvc As New Azteca.Business.Inventario.ArticuloStockService(SessionID, Connection, Transaction)
                Dim Articulo As Azteca.Business.Inventario.ArticuloStockInfo = ArticuloSvc.GetDetailFromCache(idArticuloStock)
                Return Articulo
            Else
                Throw New BusinessException("No se encontró el artículo o no está configurado para venta")
            End If
        Catch ex As Exception
            Throw New BusinessException("Error al cargar información del artículo: " & idArticuloStock.ToString, ex)
        End Try
    End Function

    Public Function GetDetailFromCache(ByVal codigo As String, ByVal idSucursal As Integer) As Azteca.Business.Inventario.ArticuloStockInfo
        Try
            If Exists(codigo, idSucursal) Then
                Dim ArticuloSvc As New Azteca.Business.Inventario.ArticuloStockService(SessionID, Connection, Transaction)
                Dim Articulo As Azteca.Business.Inventario.ArticuloStockInfo = ArticuloSvc.GetDetailFromCache(codigo, idSucursal)
                Return Articulo
            Else
                Throw New BusinessException("No se encontró el artículo o no está configurado para venta")
            End If
        Catch ex As Exception
            Throw New BusinessException("Error al cargar información del artículo: " & codigo, ex)
        End Try
    End Function


#End Region

#Region "Articulos"

    Public Function GetUnidadVentaID(idArticuloStock As Integer) As Integer
        Try
            Dim fxUnidad As New FunctionSQL("Sales", "fxArticuloUnidadVenta", Connection, Transaction)
            fxUnidad.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idArticuloStock
            Dim IdUnidad As Integer = CInt(fxUnidad.GetScalar)
            Return IdUnidad
        Catch ex As Exception
            Throw New BusinessException("Error al obtener el ID de la unidad de venta del artículo (" & idArticuloStock.ToString & ")", ex)
        End Try
    End Function

    Public Function GetArticuloVentaID(idArticuloStock As Integer) As Integer
        Try
            Dim fxArticulo As New FunctionSQL("Sales", "fxArticuloVentaID", Connection, Transaction)
            fxArticulo.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idArticuloStock
            Dim IdArticulo As Integer = CInt(fxArticulo.GetScalar)
            Return IdArticulo
        Catch ex As Exception
            Throw New BusinessException("Error al obtener el ID del artículo de venta (" & idArticuloStock.ToString & ")", ex)
        End Try
    End Function

#End Region

#Region "Precios"

    Public Function GetPrecio(ByVal idArticuloStock As Integer, ByVal idCliente As Integer, ByVal idSucursal As Integer) As PrecioInfo
        Return GetPrecio(idArticuloStock, idCliente, idSucursal, 0D)
    End Function

    Public Function GetPrecio(ByVal idArticuloStock As Integer, ByVal idCliente As Integer, ByVal idSucursal As Integer, ByVal precioFijo As Decimal) As PrecioInfo
        Try
            'Obtener la información de precio del articulo especificado
            Dim fxPrecio As New FunctionSQL("Sales", "fxPrecioArticuloCliente", Connection, Transaction)
            fxPrecio.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idArticuloStock
            fxPrecio.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            fxPrecio.Parameters.Add("@IdCliente", DbType.Int32).Value = idCliente
            fxPrecio.Parameters.Add("@PrecioFijo", DbType.Decimal).Value = precioFijo
            Dim dtPrecio As DataTable = fxPrecio.GetTable("Precios")
            Dim drPrecio As DataRow = dtPrecio.Rows(0)
            'Cargar información de precio en clase especial
            Dim Precio As New PrecioInfo()
            With Precio
                .Precio = CDec(drPrecio("Precio"))
                .IdDivisa = CInt(drPrecio("IdDivisa"))
                .TipoCambio = CDec(drPrecio("TipoCambio"))
                'IMPUESTOS
                .IdImpuesto1 = CInt(drPrecio("IdImpuesto1"))
                .IdImpuesto2 = CInt(drPrecio("IdImpuesto2"))
                .IdImpuesto3 = CInt(drPrecio("IdImpuesto3"))
                .IdImpuesto4 = CInt(drPrecio("IdImpuesto4"))
                .IdImpuesto5 = CInt(drPrecio("IdImpuesto5"))
                .PorcentajeImpuesto1 = CDec(drPrecio("PorcImpuesto1"))
                .PorcentajeImpuesto2 = CDec(drPrecio("PorcImpuesto2"))
                .PorcentajeImpuesto3 = CDec(drPrecio("PorcImpuesto3"))
                .PorcentajeImpuesto4 = CDec(drPrecio("PorcImpuesto4"))
                .PorcentajeImpuesto5 = CDec(drPrecio("PorcImpuesto5"))
                .MontoImpuesto1 = CDec(drPrecio("MontoImpuesto1"))
                .MontoImpuesto2 = CDec(drPrecio("MontoImpuesto2"))
                .MontoImpuesto3 = CDec(drPrecio("MontoImpuesto3"))
                .MontoImpuesto4 = CDec(drPrecio("MontoImpuesto4"))
                .MontoImpuesto5 = CDec(drPrecio("MontoImpuesto5"))
                'RETENCIONES
                .PorcentajeRetencion1 = CDec(drPrecio("PorcRetencion1"))
                .PorcentajeRetencion2 = CDec(drPrecio("PorcRetencion2"))
                .PorcentajeRetencion3 = CDec(drPrecio("PorcRetencion3"))
                .PorcentajeRetencion4 = CDec(drPrecio("PorcRetencion4"))
                .PorcentajeRetencion5 = CDec(drPrecio("PorcRetencion5"))
                .MontoRetencion1 = CDec(drPrecio("MontoRetencion1"))
                .MontoRetencion2 = CDec(drPrecio("MontoRetencion2"))
                .MontoRetencion3 = CDec(drPrecio("MontoRetencion3"))
                .MontoRetencion4 = CDec(drPrecio("MontoRetencion4"))
                .MontoRetencion5 = CDec(drPrecio("MontoRetencion5"))
                'DESCUENTOS
                .PorcentajeDescuento1 = CDec(drPrecio("PorcDescuento1"))
                .PorcentajeDescuento2 = CDec(drPrecio("PorcDescuento2"))
                .PorcentajeDescuento3 = CDec(drPrecio("PorcDescuento3"))
                .PorcentajeDescuento4 = CDec(drPrecio("PorcDescuento4"))
                .PorcentajeDescuento5 = CDec(drPrecio("PorcDescuento5"))
                .MontoDescuento1 = CDec(drPrecio("MontoDescuento1"))
                .MontoDescuento2 = CDec(drPrecio("MontoDescuento2"))
                .MontoDescuento3 = CDec(drPrecio("MontoDescuento3"))
                .MontoDescuento4 = CDec(drPrecio("MontoDescuento4"))
                .MontoDescuento5 = CDec(drPrecio("MontoDescuento5"))
            End With
            Return Precio
        Catch ex As Exception
            Throw New BusinessException("Error al obtener la información de precios del artículo.", ex)
        End Try
    End Function

    Public Function GetPrecio(ByVal idArticuloStock As Integer, PrecioFijo As Decimal, ByVal idZonaVenta As Integer) As PrecioInfo
        Try
            'Obtener la información de precio del articulo especificado
            Dim fxPrecio As New FunctionSQL("Sales", "fxPrecioArticuloZona", Connection, Transaction)
            fxPrecio.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idArticuloStock
            fxPrecio.Parameters.Add("@IdZonaVenta", DbType.Int32).Value = idZonaVenta
            fxPrecio.Parameters.Add("@PrecioFijo", DbType.Decimal).Value = PrecioFijo
            Dim dtPrecio As DataTable = fxPrecio.GetTable("Precios")
            Dim drPrecio As DataRow = dtPrecio.Rows(0)
            'Cargar información de precio en clase especial
            Dim Precio As New PrecioInfo()
            With Precio
                .Precio = CDec(drPrecio("Precio"))
                .IdDivisa = CInt(drPrecio("IdDivisa"))
                .TipoCambio = CDec(drPrecio("TipoCambio"))
                'IMPUESTOS
                .IdImpuesto1 = CInt(drPrecio("IdImpuesto1"))
                .IdImpuesto2 = CInt(drPrecio("IdImpuesto2"))
                .IdImpuesto3 = CInt(drPrecio("IdImpuesto3"))
                .IdImpuesto4 = CInt(drPrecio("IdImpuesto4"))
                .IdImpuesto5 = CInt(drPrecio("IdImpuesto5"))
                .PorcentajeImpuesto1 = CDec(drPrecio("PorcImpuesto1"))
                .PorcentajeImpuesto2 = CDec(drPrecio("PorcImpuesto2"))
                .PorcentajeImpuesto3 = CDec(drPrecio("PorcImpuesto3"))
                .PorcentajeImpuesto4 = CDec(drPrecio("PorcImpuesto4"))
                .PorcentajeImpuesto5 = CDec(drPrecio("PorcImpuesto5"))
                .MontoImpuesto1 = CDec(drPrecio("MontoImpuesto1"))
                .MontoImpuesto2 = CDec(drPrecio("MontoImpuesto2"))
                .MontoImpuesto3 = CDec(drPrecio("MontoImpuesto3"))
                .MontoImpuesto4 = CDec(drPrecio("MontoImpuesto4"))
                .MontoImpuesto5 = CDec(drPrecio("MontoImpuesto5"))
                'RETENCIONES
                .PorcentajeRetencion1 = CDec(drPrecio("PorcRetencion1"))
                .PorcentajeRetencion2 = CDec(drPrecio("PorcRetencion2"))
                .PorcentajeRetencion3 = CDec(drPrecio("PorcRetencion3"))
                .PorcentajeRetencion4 = CDec(drPrecio("PorcRetencion4"))
                .PorcentajeRetencion5 = CDec(drPrecio("PorcRetencion5"))
                .MontoRetencion1 = CDec(drPrecio("MontoRetencion1"))
                .MontoRetencion2 = CDec(drPrecio("MontoRetencion2"))
                .MontoRetencion3 = CDec(drPrecio("MontoRetencion3"))
                .MontoRetencion4 = CDec(drPrecio("MontoRetencion4"))
                .MontoRetencion5 = CDec(drPrecio("MontoRetencion5"))
                'DESCUENTOS
                .PorcentajeDescuento1 = CDec(drPrecio("PorcDescuento1"))
                .PorcentajeDescuento2 = CDec(drPrecio("PorcDescuento2"))
                .PorcentajeDescuento3 = CDec(drPrecio("PorcDescuento3"))
                .PorcentajeDescuento4 = CDec(drPrecio("PorcDescuento4"))
                .PorcentajeDescuento5 = CDec(drPrecio("PorcDescuento5"))
                .MontoDescuento1 = CDec(drPrecio("MontoDescuento1"))
                .MontoDescuento2 = CDec(drPrecio("MontoDescuento2"))
                .MontoDescuento3 = CDec(drPrecio("MontoDescuento3"))
                .MontoDescuento4 = CDec(drPrecio("MontoDescuento4"))
                .MontoDescuento5 = CDec(drPrecio("MontoDescuento5"))
            End With
            Return Precio
        Catch ex As Exception
            Throw New BusinessException("Error al obtener la información de precios del artículo.", ex)
        End Try
    End Function

#End Region

#Region "Inventario"

    Public Function GetStock(ByVal idArticuloStock As Integer, ByVal idAlmacen As Integer) As Decimal
        Dim ArticuloSvc As New Azteca.Business.Inventario.ArticuloStockService(SessionID, Connection, Transaction)
        Return ArticuloSvc.GetStock(idArticuloStock, idAlmacen)
    End Function
#End Region

#Region "Zonas"


    Public Function GetZonas(ByVal idArticuloStock As Integer) As ZonasVentaDS.ZonasDataTable
        Dim dtReturn As New ZonasVentaDS.ZonasDataTable
        Try
            Dim fxZonas As New FunctionSQL("Sales", "fxArticuloZonasVentaByArtStockSEL", Connection, Transaction)
            fxZonas.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idArticuloStock
            fxZonas.FillDataTable(dtReturn)
            Return dtReturn
        Catch ex As Exception
            Throw New BusinessException("Error al cargar las zonas de venta del artículo: " & idArticuloStock, ex)
        End Try
    End Function

    Public Sub SaveZonas(ByVal idArticuloStock As Integer, ByVal zonasVentaTable As ZonasVentaDS.ZonasDataTable)
        Try
            Dim comUpdate As New DbCommand("Sales.ArticulosZonaVentaUPD", Connection, Transaction)
            With comUpdate
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idArticuloStock
                .Parameters.Add("@IdZonaVenta", DbType.Int32, "IdZonaVenta")
                .Parameters.Add("@IdDivisa", DbType.Int32, "IdDivisa")
                .Parameters.Add("@Precio", DbType.Decimal, "Precio")
                .Parameters.Add("@DiasEntrega", DbType.Int32, "DiasEntrega")
                .Parameters.Add("@IdImpuesto1", DbType.Int32, "IdImpuesto1")
                .Parameters.Add("@IdImpuesto2", DbType.Int32, "IdImpuesto2")
                .Parameters.Add("@IdImpuesto3", DbType.Int32, "IdImpuesto3")
                .Parameters.Add("@PorcRetencion1", DbType.Decimal, "PorcRetencion1")
                .Parameters.Add("@PorcRetencion2", DbType.Decimal, "PorcRetencion2")
                .Parameters.Add("@PorcRetencion3", DbType.Decimal, "PorcRetencion3")
            End With
            '
            Dim comDelete As New DbCommand("Sales.ArticulosZonaVentaDEL", Connection, Transaction)
            With comDelete
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idArticuloStock
                .Parameters.Add("@IdZonaVenta", DbType.Int32, "IdZonaVenta")
            End With
            '
            Dim daUpdate As New DataAdapter()
            daUpdate.InsertCommand = comUpdate
            daUpdate.UpdateCommand = comUpdate
            daUpdate.DeleteCommand = comDelete
            daUpdate.Update(zonasVentaTable)
        Catch concurrencyEx As DBConcurrencyException

        Catch ex As Exception
            Throw New BusinessException("Error al guardar las zonas de venta.", ex)
        End Try
    End Sub


#End Region

#Region "POS"

    Public Function GetPOSInfo(ByVal IdArticuloStock As Integer, ByVal IdZonaVenta As Integer) As ArticulosDS.ArticulosVentaPOSDataTable
        Dim dtReturn As New ArticulosDS.ArticulosVentaPOSDataTable
        Try
            Dim fx As New FunctionSQL("Sales", "fxArticuloPresentacionSEL", Connection, Transaction)
            fx.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = IdArticuloStock
            fx.Parameters.Add("@IdZonaVenta", DbType.Int32).Value = IdZonaVenta
            fx.FillDataTable(dtReturn)
            Return dtReturn
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el detalle del articulo", ex)
        End Try
    End Function

    Public Function GetPOSInfo(ByVal Codigo As String, ByVal IdZonaVenta As Integer) As ArticulosDS.ArticulosVentaPOSDataTable
        Dim dtReturn As New ArticulosDS.ArticulosVentaPOSDataTable
        Try
            Dim fx As New FunctionSQL("Sales", "fxArticuloPresentacionSELbyCodigo", Connection, Transaction)
            fx.Parameters.Add("@Codigo", DbType.String).Value = Codigo
            fx.Parameters.Add("@IdZonaVenta", DbType.Int32).Value = IdZonaVenta
            fx.FillDataTable(dtReturn)
            Return dtReturn
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el detalle del articulo", ex)
        End Try
    End Function


#End Region

End Class

Public Class PresentacionFacade
    Inherits Azteca.Kernel.RemoteObject
    Implements Azteca.Kernel.Search.ISearchableFacade

#Region "Variables"
    Protected Connection As IDbConnection
    Protected Transaction As IDbTransaction
#End Region

#Region "Search Interface"

    Public Function GetNumberOfPages(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As Kernel.Search.SearchConditionCollection) As Integer Implements Kernel.Search.ISearchableFacade.GetNumberOfPages
        Try
            Connection = DataServices.OpenConnection
            Dim ArticuloPresentacionSvc As New PresentacionService(sessionID, Connection)
            Return ArticuloPresentacionSvc.GetNumberOfPages(idSite, conditions)
        Catch ex As Exception
            Throw ex
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Function

    Public Function GetSearchResult(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As Kernel.Search.SearchConditionCollection, ByVal order As Kernel.Search.SearchOrderCollection) As System.Data.DataSet Implements Kernel.Search.ISearchableFacade.GetSearchResult
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    Public Function GetSearchResult(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As Kernel.Search.SearchConditionCollection, ByVal order As Kernel.Search.SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet Implements Kernel.Search.ISearchableFacade.GetSearchResult
        Try
            Connection = DataServices.OpenConnection
            Dim ArticuloPresentacionSvc As New PresentacionService(sessionID, Connection)
            Return ArticuloPresentacionSvc.GetSearchResult(idSite, conditions, order, page)
        Catch ex As Exception
            Throw ex
        Finally
            DataServices.CloseConnection(Connection)
        End Try

    End Function

    Public Function GetSearchStructure(ByVal sessionID As Guid) As System.Data.DataSet Implements Kernel.Search.ISearchableFacade.GetSearchStructure
        Try
            Connection = DataServices.OpenConnection
            Dim ArticuloPresentacionSvc As New PresentacionService(sessionID, Connection)
            Return ArticuloPresentacionSvc.GetSearchStructure()
        Catch ex As Exception
            Throw ex
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Function

#End Region

#Region "Metodos Privados"

    Public Sub ValidateSession(ByVal sessionID As Guid)

    End Sub

    Public Sub HandleException(ByVal ex As Exception)
        If Azteca.Kernel.Server.LogExceptions Then Azteca.Kernel.General.AppEventLog.LogException(ex)
        If TypeOf (ex) Is BusinessException Then
            Throw ex
        Else
            Throw New BusinessException(ex.Message, ex)
        End If

    End Sub

#End Region

#Region "Metodos Publicos"

    Public Function Exists(ByVal sessionID As Guid, ByVal idArticuloStock As Integer) As Boolean
        ValidateSession(sessionID)
        Exists = False
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PresentacionService(sessionID, Connection)
            Return Svc.Exists(idArticuloStock)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Function

    Public Function Exists(ByVal sessionID As Guid, ByVal codigo As String, ByVal idSucursal As Integer) As Boolean
        ValidateSession(sessionID)
        Exists = False
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PresentacionService(sessionID, Connection)
            Return Svc.Exists(codigo, idSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Function

    Public Function GetDetail(ByVal sessionID As Guid, ByVal idArticuloStock As Integer) As Azteca.Business.Inventario.ArticuloStockInfo
        ValidateSession(sessionID)
        Dim Articulo As Azteca.Business.Inventario.ArticuloStockInfo = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PresentacionService(sessionID, Connection)
            Articulo = Svc.GetDetail(idArticuloStock)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Articulo
    End Function

    Public Function GetDetail(ByVal sessionID As Guid, ByVal codigo As String, ByVal idSucursal As Integer) As Azteca.Business.Inventario.ArticuloStockInfo
        ValidateSession(sessionID)
        Dim Articulo As Azteca.Business.Inventario.ArticuloStockInfo = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PresentacionService(sessionID, Connection)
            Articulo = Svc.GetDetail(codigo, idSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Articulo
    End Function

    Public Function GetDetailFromCache(ByVal sessionID As Guid, ByVal idArticuloStock As Integer) As Azteca.Business.Inventario.ArticuloStockInfo
        ValidateSession(sessionID)
        Dim Articulo As Azteca.Business.Inventario.ArticuloStockInfo = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PresentacionService(sessionID, Connection)
            Articulo = Svc.GetDetailFromCache(idArticuloStock)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Articulo
    End Function

    Public Function GetDetailFromCache(ByVal sessionID As Guid, ByVal codigo As String, ByVal idSucursal As Integer) As Azteca.Business.Inventario.ArticuloStockInfo
        ValidateSession(sessionID)
        Dim Articulo As Azteca.Business.Inventario.ArticuloStockInfo = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PresentacionService(sessionID, Connection)
            Articulo = Svc.GetDetailFromCache(codigo, idSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Articulo
    End Function


#End Region

#Region "Articulos"

    Public Function GetUnidadVentaID(sessionID As Guid, idArticuloStock As Integer) As Integer
        ValidateSession(sessionID)
        Dim IdUnidad As Integer = 0
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PresentacionService(sessionID, Connection)
            IdUnidad = Svc.GetUnidadVentaID(idArticuloStock)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return IdUnidad
    End Function

    Public Function GetArticuloVentaID(sessionID As Guid, idArticuloStock As Integer) As Integer
        ValidateSession(sessionID)
        Dim IdArticulo As Integer = 0
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PresentacionService(sessionID, Connection)
            IdArticulo = Svc.GetArticuloVentaID(idArticuloStock)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return IdArticulo
    End Function


#End Region

#Region "Precios"


    Public Function GetPrecio(ByVal sessionID As Guid, ByVal idArticuloStock As Integer, ByVal idCliente As Integer, ByVal idSucursal As Integer) As PrecioInfo
        Return GetPrecio(sessionID, idArticuloStock, idCliente, idSucursal, 0D)
    End Function

    Public Function GetPrecio(ByVal sessionID As Guid, ByVal idArticuloStock As Integer, ByVal idCliente As Integer, ByVal idSucursal As Integer, ByVal precioFijo As Decimal) As PrecioInfo
        ValidateSession(sessionID)
        Dim Precio As PrecioInfo = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PresentacionService(sessionID, Connection)
            Precio = Svc.GetPrecio(idArticuloStock, idCliente, idSucursal, precioFijo)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Precio
    End Function

    Public Function GetPrecio(ByVal sessionID As Guid, ByVal idArticuloStock As Integer, PrecioFijo As Decimal, ByVal idZonaVenta As Integer) As PrecioInfo
        ValidateSession(sessionID)
        Dim Precio As PrecioInfo = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PresentacionService(sessionID, Connection)
            Precio = Svc.GetPrecio(idArticuloStock, PrecioFijo, idZonaVenta)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Precio
    End Function

#End Region

#Region "Inventario"

    Public Function GetStock(ByVal sessionID As Guid, ByVal idArticuloStock As Integer, ByVal idAlmacen As Integer) As Decimal
        ValidateSession(sessionID)
        GetStock = 0D
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PresentacionService(sessionID, Connection)
            Return Svc.GetStock(idArticuloStock, idAlmacen)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Function

#End Region

#Region "POS"

    Public Function GetPOSInfo(ByVal sessionID As Guid, ByVal IdArticuloStock As Integer, ByVal IdZonaVenta As Integer) As ArticulosDS.ArticulosVentaPOSDataTable
        Dim dtReturn As ArticulosDS.ArticulosVentaPOSDataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PresentacionService(sessionID, Connection, Transaction)
            dtReturn = Svc.GetPOSInfo(IdArticuloStock, IdZonaVenta)
        Catch ex As Exception
            Throw ex
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtReturn
    End Function

    Public Function GetPOSInfo(ByVal sessionID As Guid, ByVal Codigo As String, ByVal IdZonaVenta As Integer) As ArticulosDS.ArticulosVentaPOSDataTable
        Dim dtReturn As ArticulosDS.ArticulosVentaPOSDataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PresentacionService(sessionID, Connection, Transaction)
            dtReturn = Svc.GetPOSInfo(Codigo, IdZonaVenta)
        Catch ex As Exception
            Throw ex
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtReturn
    End Function


#End Region

#Region "Zonas"

    Public Function GetZonas(ByVal sessionID As Guid, ByVal IdArticuloStock As Integer) As ZonasVentaDS.ZonasDataTable
        ValidateSession(sessionID)
        Dim dtZonas As ZonasVentaDS.ZonasDataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PresentacionService(sessionID, Connection, Transaction)
            dtZonas = Svc.GetZonas(IdArticuloStock)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtZonas
    End Function


    Public Sub SaveZonas(ByVal sessionID As Guid, ByVal idArticuloStock As Integer, ByVal ZonasVentaTable As ZonasVentaDS.ZonasDataTable)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PresentacionService(sessionID, Connection)
            Svc.SaveZonas(idArticuloStock, ZonasVentaTable)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub

#End Region

End Class
