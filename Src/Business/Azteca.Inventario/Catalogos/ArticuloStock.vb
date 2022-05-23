

Partial Class ArticuloStockService

#Region "Generales"
    Public Function GetImagen(IdArticuloStock As Integer) As Byte()
        Dim imagen As Byte() = Nothing
        Try
            Dim fx As New FunctionSQL("Inventory", "fxArticulosStockFotoSEL", Connection, Transaction)
            fx.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = IdArticuloStock
            Dim dt As DataTable = fx.GetTable
            If dt.Rows.Count > 0 Then
                imagen = CType(dt(0)("Foto"), Byte())
            End If
        Catch ex As Exception
            Throw New BusinessException("Error al cargar información de la fotografia del artículo.", ex)
        End Try
        Return imagen
    End Function

    Public Function GetDetailFromCache(ByVal idArticuloStock As Integer) As ArticuloStockInfo
        Try
            Dim CacheKey As String = "ArticuloStock" & idArticuloStock
            Dim ArticuloStock As New ArticuloStockInfo(sessionID)
            If Azteca.Kernel.Cache.Item(CacheKey) Is Nothing Then
                Dim Svc As New ArticuloStockService(sessionID, Connection, Transaction)
                Svc.GetDetail(idArticuloStock, ArticuloStock, False)
                Azteca.Kernel.Cache.Add(CacheKey, ArticuloStock, TimeSpan.FromDays(1))
            Else
                ArticuloStock = CType(Azteca.Kernel.Cache.Item(CacheKey), ArticuloStockInfo)
            End If
            Return ArticuloStock
        Catch ex As Exception
            Throw New BusinessException("Error al cargar información del artículo desde el caché.", ex)
        End Try
    End Function

    Public Function GetDetailFromCache(ByVal codigo As String, ByVal idSucursal As Integer) As ArticuloStockInfo
        Try
            'Cargar información de la sucursal (para determinar la empresa y evitar conflictos de codigo)
            Dim SucursalSvc As New SucursalService(sessionID, Connection, Transaction)
            Dim Sucursal As SucursalInfo = SucursalSvc.GetDetailFromCache(idSucursal)
            '
            Dim CacheKey As String = "ArticuloStock_Code_" & Sucursal.IdEmpresa & "_" & codigo
            Dim ArticuloStock As New ArticuloStockInfo(sessionID)
            If Azteca.Kernel.Cache.Item(CacheKey) Is Nothing Then
                Dim Svc As New ArticuloStockService(sessionID, Connection, Transaction)
                Svc.GetDetail(codigo, idSucursal, ArticuloStock, False)
                Azteca.Kernel.Cache.Add(CacheKey, ArticuloStock, TimeSpan.FromDays(1))
            Else
                ArticuloStock = CType(Azteca.Kernel.Cache.Item(CacheKey), ArticuloStockInfo)
            End If
            Return ArticuloStock
        Catch ex As Exception
            Throw New BusinessException("Error al cargar información del artículo desde el caché.", ex)
        End Try
    End Function

#End Region

#Region "Inventario"

    Public Function CargarInfoInventario(ByVal idSucursal As Integer, ByVal idArticuloStock As Integer) As DataTable
        Try
            Dim fxInfo As New FunctionSQL("Inventory", "fxArticuloInventarioInfoSEL", Connection, Transaction)
            fxInfo.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            fxInfo.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idArticuloStock
            fxInfo.Parameters.Add("@IdUsuario", DbType.Int32).Value = Session.User.Identity
            Dim dtInfo As DataTable = fxInfo.GetTable("Info")
            Return dtInfo
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la información de inventario del artículo.", ex)
        End Try
    End Function

    Public Sub GuardarInfoInventario(ByVal idArticuloStock As Integer, ByVal info As DataTable)
        Try

        Catch ex As Exception

        End Try
    End Sub

    Public Function GetStock(ByVal idArticuloStock As Integer, ByVal idAlmacen As Integer) As Decimal
        Try
            Dim fxStock As New FunctionSQL("Inventory", "fxArticuloStockDisponible", Connection, Transaction)
            fxStock.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idArticuloStock
            fxStock.Parameters.Add("@IdAlmacen", DbType.Int32).Value = idAlmacen
            Return CDec(fxStock.GetScalar)
        Catch ex As Exception
            Throw New BusinessException("Error al obtener la existencia disponible del artículo con ID " & idArticuloStock)
        End Try
    End Function

#End Region

#Region "Clasificaciones"

    Public Function CargarClasificaciones(ByVal idArticuloStock As Integer) As DataTable
        Try
            Dim fxClasificaciones As New FunctionSQL("Inventory", "fxClasificacionesArticuloSEL", Connection, Transaction)
            fxClasificaciones.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idArticuloStock
            Dim dtClasificaciones As DataTable = fxClasificaciones.GetTable("Clasificaciones")
            Return dtClasificaciones
        Catch ex As Exception
            Throw New BusinessException("Error al cargar las clasificaciones del artículo.", ex)
        End Try
    End Function

    Public Sub GuardarClasificaciones(ByVal idArticuloStock As Integer, ByVal clasificaciones As DataTable)
        Try
            Dim comUpdate As New DbCommand("Inventory.ClasificacionesArticulosUPD", Connection, Transaction)
            comUpdate.CommandType = CommandType.StoredProcedure
            comUpdate.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idArticuloStock
            comUpdate.Parameters.Add("@IdClasificacionGrupo", DbType.Int32, "IdGrupo")
            comUpdate.Parameters.Add("@IdClasificacion", DbType.Int32, "IdClasificacion")
            '
            Dim da As New DataAdapter
            da.UpdateCommand = comUpdate
            da.Update(clasificaciones)
        Catch concurrencyEx As DBConcurrencyException

        Catch ex As Exception
            Throw New BusinessException("Error al guardar las clasificaciones del artículo.", ex)
        End Try
    End Sub

#End Region

#Region "Utilitario de Costos"

    Public Function GetCompraDetalleMaterial(ByVal idArticuloStock As Integer, ByVal fechaIni As DateTime, ByVal fechaFin As DateTime, ByVal usarUltimaRecepcion As Boolean, ByVal statusDocumentos As String, ByVal statusProduccion As String) As DataTable
        Dim dtDetalle As New DataTable()
        Try
            Dim fxInfo As New FunctionSQL("Inventory", "fxCostoCompraDetalleMat", Connection, Transaction)
            fxInfo.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idArticuloStock
            fxInfo.Parameters.Add("@FechaIni", DbType.DateTime).Value = fechaIni
            fxInfo.Parameters.Add("@FechaFin", DbType.DateTime).Value = fechaFin
            fxInfo.Parameters.Add("@UsarUltimaRecepcion", DbType.Boolean).Value = usarUltimaRecepcion
            fxInfo.Parameters.Add("@StatusDocumentos", DbType.String).Value = statusDocumentos
            fxInfo.Parameters.Add("@StatusProduccion", DbType.String).Value = statusProduccion
            fxInfo.FillDataTable(dtDetalle)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el detalle del costo.", ex)
        End Try
        Return dtDetalle
    End Function

    Public Function GetVentaDetalleMaterial(ByVal idArticuloStock As Integer, ByVal fechaIni As DateTime, ByVal fechaFin As DateTime, ByVal usarUltimaRecepcion As Boolean, ByVal statusDocumentos As String, ByVal statusProduccion As String) As DataTable
        Dim dtDetalle As New DataTable()
        Try
            Dim fxInfo As New FunctionSQL("Inventory", "fxCostoVentaDetalleMat", Connection, Transaction)
            fxInfo.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idArticuloStock
            fxInfo.Parameters.Add("@FechaIni", DbType.DateTime).Value = fechaIni
            fxInfo.Parameters.Add("@FechaFin", DbType.DateTime).Value = fechaFin
            fxInfo.Parameters.Add("@UsarUltimaRecepcion", DbType.Boolean).Value = usarUltimaRecepcion
            fxInfo.Parameters.Add("@StatusDocumentos", DbType.String).Value = statusDocumentos
            fxInfo.Parameters.Add("@StatusProduccion", DbType.String).Value = statusProduccion
            fxInfo.FillDataTable(dtDetalle)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el detalle del costo.", ex)
        End Try
        Return dtDetalle
    End Function

    Public Sub GuardarCostosUtilitario(ByVal ArticulosCostos As DataTable)
        Try
            For Each item As DataRow In ArticulosCostos.Rows
                Dim comUpdate As New DbCommand("Inventory.CostosArticulosUPD", Connection, Transaction)

                If (Boolean.Parse(item("Check").ToString())) Then
                    comUpdate.CommandType = CommandType.StoredProcedure
                    comUpdate.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = CInt(item("IdArticuloStock"))
                    comUpdate.Parameters.Add("@CostoMaterial", DbType.Decimal).Value = CDec(item("NuevoCostoMaterial"))
                    comUpdate.Parameters.Add("@CostoLabor", DbType.Decimal).Value = CDec(item("NuevoCostoLabor"))
                    comUpdate.Parameters.Add("@CostoServicio", DbType.Decimal).Value = CDec(item("NuevoCostoServicio"))
                    comUpdate.Parameters.Add("@CostoCarga", DbType.Decimal).Value = CDec(item("NuevoCostoCarga"))
                    comUpdate.ExecuteNonQuery()
                End If
            Next
        Catch concurrencyEx As DBConcurrencyException

        Catch ex As Exception
            Throw New BusinessException("Error al guardar los costos del artículo.", ex)
        End Try
    End Sub

    Public Function CargarArticulosUtilitario(ByVal idSucursal As Integer, ByVal categoria As String) As UtilitarioCostosDS.ArticulosDataTable

        Try
            Dim fxInfo As New FunctionSQL("Inventory", "fxUtilitarioCostosList", Connection, Transaction)
            fxInfo.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            fxInfo.Parameters.Add("@IdUsuario", DbType.Int32).Value = Session.User.Identity
            fxInfo.Parameters.Add("@Categoria", DbType.String).Value = categoria
            Dim dtArticulos = New UtilitarioCostosDS.ArticulosDataTable
            fxInfo.FillDataTable(dtArticulos)
            Return dtArticulos
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de articulos del utilitario.", ex)
        End Try
    End Function

    Public Function GetCostoByCategoria(ByVal idSucursal As Integer, ByVal idArticuloStock As Integer, ByVal categoria As String, ByVal fechaIni As DateTime, ByVal fechaFin As DateTime, ByVal usarUltimaRecepcion As Boolean, ByVal statusDocumentos As String, ByVal statusProduccion As String) As ArticuloCostoInfo
        Dim costoInfo As New ArticuloCostoInfo()
        Dim dr As IDataReader = Nothing
        Try
            Dim fxInfo As New FunctionSQL("Inventory", "fxCostoArticuloByCategoria", Connection, Transaction)
            fxInfo.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            fxInfo.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idArticuloStock
            fxInfo.Parameters.Add("@Categoria", DbType.String).Value = categoria
            fxInfo.Parameters.Add("@FechaIni", DbType.DateTime).Value = fechaIni
            fxInfo.Parameters.Add("@FechaFin", DbType.DateTime).Value = fechaFin
            fxInfo.Parameters.Add("@UsarUltimaRecepcion", DbType.Boolean).Value = usarUltimaRecepcion
            fxInfo.Parameters.Add("@StatusDocumentos", DbType.String).Value = statusDocumentos
            fxInfo.Parameters.Add("@StatusProduccion", DbType.String).Value = statusProduccion

            dr = fxInfo.GetReader(CommandBehavior.SingleRow)
            If (dr.Read) Then
                'Cargar los rubros de costos
                With costoInfo
                    ._IdArticuloStock = CInt(dr("IdArticuloStock"))
                    ._CostoMaterial = CDec(dr("CostoMaterial"))
                    ._CostoLabor = CDec(dr("CostoLabor"))
                    ._CostoServicio = CDec(dr("CostoServicio"))
                    ._CostoCarga = CDec(dr("CostoCarga"))
                    ._BaseCalculo = dr("BaseCalculo").ToString()
                    ._CostoMaterialBase = CDec(dr("CostoMaterialBase"))
                    ._CostoLaborBase = CDec(dr("CostoLaborBase"))
                    ._CostoServicioBase = CDec(dr("CostoServicioBase"))
                    ._CostoCargaBase = CDec(dr("CostoCargaBase"))
                End With
            End If
            Return costoInfo
        Catch ex As Exception
            Throw New BusinessException(ex.Message, ex)
        Finally
            If Not dr Is Nothing Then
                dr.Close()
            End If
        End Try
    End Function

    Public Function GetCostoByIssue(ByVal idSucursal As Integer, ByVal idArticuloStock As Integer) As Decimal
        Dim CostoMaterial As Decimal = 0
        Try
            Dim CostoInfo As New ArticuloCostoInfo()
            Dim FechaIni As DateTime = New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
            Dim FechaFin As DateTime = Date.Today
            CostoInfo = GetCostoByCategoria(idSucursal, idArticuloStock, "C", FechaIni, FechaFin, True, "1,3,9", "")
            Return CostoInfo.CostoMaterialBase
        Catch ex As Exception
            Throw New BusinessException(ex.Message, ex)
        End Try
    End Function

    Public Sub ProcesarManoObra(ByVal fechaPeriodo As DateTime, ByVal pcUpdate As String, ByVal idUserCreate As Integer, ByVal regenerarHistorico As Boolean, ByVal limitarFechaPeriodo As Boolean)
        Try

            Dim comUpdate As New DbCommand("Production.ManoObraUPD", Connection, Transaction)

            comUpdate.CommandType = CommandType.StoredProcedure
            comUpdate.Parameters.Add("@FechaPeriodo", DbType.DateTime).Value = fechaPeriodo
            comUpdate.Parameters.Add("@PCUpdate", DbType.String).Value = pcUpdate
            comUpdate.Parameters.Add("@UserCreate", DbType.Int32).Value = idUserCreate
            comUpdate.Parameters.Add("@RegenerarHistorico", DbType.Boolean).Value = regenerarHistorico
            comUpdate.Parameters.Add("@LimitarFechaPeriodo", DbType.Decimal).Value = limitarFechaPeriodo
            comUpdate.ExecuteNonQuery()

        Catch ex As Exception
            Throw New BusinessException("Error al guardar los costos del artículo.", ex)
        End Try
    End Sub


#End Region



End Class





Partial Class ArticuloStockFacade

#Region "Generales"
    Public Function GetImagen(sessionID As Guid, IdArticuloStock As Integer) As Byte()
        ValidateSession(sessionID)
        Dim Imagen As Byte()
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ArticuloStockService(sessionID, Connection, Transaction)
            Imagen = Svc.GetImagen(IdArticuloStock)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Imagen
    End Function

    Public Function GetDetailFromCache(ByVal sessionID As Guid, ByVal idArticuloStock As Integer) As ArticuloStockInfo
        ValidateSession(sessionID)
        Dim ArticuloStock As ArticuloStockInfo = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ArticuloStockService(sessionID, Connection, Transaction)
            ArticuloStock = Svc.GetDetailFromCache(idArticuloStock)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return ArticuloStock
    End Function

    Public Function GetDetailFromCache(ByVal sessionID As Guid, ByVal codigo As String, ByVal idSucursal As Integer) As ArticuloStockInfo
        ValidateSession(sessionID)
        Dim ArticuloStock As ArticuloStockInfo = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ArticuloStockService(sessionID, Connection, Transaction)
            ArticuloStock = Svc.GetDetailFromCache(codigo, idSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return ArticuloStock
    End Function

#End Region

#Region "Inventario"

    Public Function CargarInfoInventario(ByVal sessionID As Guid, ByVal idSucursal As Integer, ByVal idArticuloStock As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtInfo As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ArticuloStockService(sessionID, Connection, Transaction)
            dtInfo = Svc.CargarInfoInventario(idSucursal, idArticuloStock)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtInfo
    End Function

    Public Sub GuardarInfoInventario(ByVal sessionID As Guid, ByVal idArticuloStock As Integer, ByVal info As DataTable)

    End Sub



    Public Function GetStock(ByVal sessionID As Guid, ByVal idArticuloStock As Integer, ByVal idAlmacen As Integer) As Decimal
        ValidateSession(sessionID)
        Dim Stock As Decimal = 0
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ArticuloStockService(sessionID, Connection, Transaction)
            Stock = Svc.GetStock(idArticuloStock, idAlmacen)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Stock
    End Function

#End Region

#Region "Clasificaciones"

    Public Function CargarClasificaciones(ByVal sessionID As Guid, ByVal idArticuloStock As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtClasificaciones As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ArticuloStockService(sessionID, Connection, Transaction)
            dtClasificaciones = Svc.CargarClasificaciones(idArticuloStock)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtClasificaciones
    End Function

    Public Sub GuardarClasificaciones(ByVal sessionID As Guid, ByVal idArticuloStock As Integer, ByVal clasificaciones As DataTable)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New ArticuloStockService(sessionID, Connection, Transaction)
                Svc.GuardarClasificaciones(idArticuloStock, clasificaciones)
                DataServices.CommitTransaction(Transaction)
            Catch ex As Exception
                DataServices.RollbackTransaction(Transaction)
                Throw ex
            End Try
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub

#End Region

#Region "Utilitario de Costos"

    Public Function GetCompraDetalleMaterial(ByVal sessionID As Guid, ByVal idArticuloStock As Integer, ByVal fechaIni As DateTime, ByVal fechaFin As DateTime, ByVal usarUltimaRecepcion As Boolean, ByVal statusDocumentos As String, ByVal statusProduccion As String) As DataTable
        ValidateSession(sessionID)
        Dim dtDetalle As New DataTable()
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ArticuloStockService(sessionID, Connection, Transaction)
            dtDetalle = Svc.GetCompraDetalleMaterial(idArticuloStock, fechaIni, fechaFin, usarUltimaRecepcion, statusDocumentos, statusProduccion)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtDetalle
    End Function

    Public Function GetVentaDetalleMaterial(ByVal sessionID As Guid, ByVal idArticuloStock As Integer, ByVal fechaIni As DateTime, ByVal fechaFin As DateTime, ByVal usarUltimaRecepcion As Boolean, ByVal statusDocumentos As String, ByVal statusProduccion As String) As DataTable
        ValidateSession(sessionID)
        Dim dtDetalle As New DataTable()
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ArticuloStockService(sessionID, Connection, Transaction)
            dtDetalle = Svc.GetVentaDetalleMaterial(idArticuloStock, fechaIni, fechaFin, usarUltimaRecepcion, statusDocumentos, statusProduccion)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtDetalle
    End Function

    Public Sub GuardarCostosUtilitario(ByVal sessionID As Guid, ByVal articulosCostos As DataTable)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New ArticuloStockService(sessionID, Connection, Transaction)
                Svc.GuardarCostosUtilitario(articulosCostos)
                DataServices.CommitTransaction(Transaction)
            Catch ex As Exception
                DataServices.RollbackTransaction(Transaction)
                Throw ex
            End Try
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub

    Public Function CargarArticulosUtilitario(ByVal sessionID As Guid, ByVal idSucursal As Integer, ByVal categoria As String) As UtilitarioCostosDS.ArticulosDataTable
        ValidateSession(sessionID)
        Dim dtInfo As New UtilitarioCostosDS.ArticulosDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ArticuloStockService(sessionID, Connection, Transaction)
            dtInfo = Svc.CargarArticulosUtilitario(idSucursal, categoria)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtInfo
    End Function

    Public Function GetCostoByCategoria(ByVal sessionID As Guid, ByVal idSucursal As Integer, ByVal idArticuloStock As Integer, ByVal categoria As String, ByVal fechaIni As DateTime, ByVal fechaFin As DateTime, ByVal usarUltimaRecepcion As Boolean, ByVal statusDocumentos As String, ByVal statusProduccion As String) As ArticuloCostoInfo
        ValidateSession(sessionID)
        Dim dtInfo As New ArticuloCostoInfo()
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ArticuloStockService(sessionID, Connection, Transaction)
            dtInfo = Svc.GetCostoByCategoria(idSucursal, idArticuloStock, categoria, fechaIni, fechaFin, usarUltimaRecepcion, statusDocumentos, statusProduccion)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtInfo
    End Function

    'Public Sub ProcesarManoObra(ByVal sessionID As Guid, ByVal fechaPeriodo As DateTime, ByVal pcUpdate As String, ByVal idUserCreate As Integer, ByVal regenerarHistorico As Boolean, ByVal limitarFechaPeriodo As Boolean)
    '    ValidateSession(sessionID)
    '    Dim dtInfo As New ArticuloCostoInfo()
    '    Try
    '        Connection = DataServices.OpenConnection
    '        Dim Svc As New ArticuloStockService(sessionID, Connection, Transaction)
    '        dtInfo = Svc.ProcesarManoObra(idSucursal, idArticuloStock, categoria, fechaIni, fechaFin, usarUltimaRecepcion, statusDocumentos, statusProduccion)
    '    Catch ex As Exception
    '        HandleException(ex)
    '    Finally
    '        DataServices.CloseConnection(Connection)
    '    End Try
    '    Return dtInfo
    'End Sub


#End Region


End Class