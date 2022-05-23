Partial Class AlmacenService

#Region "Generales"

    Public Function LoadList(ByVal idSucursal As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Inventory", "fxAlmacenesCBO", Connection, Transaction)
            fxList.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            Dim dtList As DataTable = fxList.GetTable("Almacenes")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de almacenes.", ex)
        End Try
    End Function

    Public Function LoadList(ByVal idSucursal As Integer, ByVal idUsuario As Integer, ByVal acceso As TipoAccesoAlmacen) As DataTable
        Try
            Dim fxList As New FunctionSQL("Inventory", "fxAlmacenesByUsuarioCBO", Connection, Transaction)
            fxList.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            fxList.Parameters.Add("@IdArea", DbType.Int32).Value = 0
            fxList.Parameters.Add("@IdUsuario", DbType.Int32).Value = idUsuario
            fxList.Parameters.Add("@Acceso", DbType.Int32).Value = CInt(acceso)
            Dim dtList As DataTable = fxList.GetTable("Almacenes")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de almacenes.", ex)
        End Try
    End Function

    Public Function LoadListByArea(ByVal idArea As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Inventory", "fxAlmacenesByAreaCBO", Connection, Transaction)
            fxList.Parameters.Add("@IdArea", DbType.Int32).Value = idArea
            Dim dtList As DataTable = fxList.GetTable("Almacenes")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de almacenes.", ex)
        End Try
    End Function

    Public Function LoadListByArea(ByVal idArea As Integer, ByVal idUsuario As Integer, ByVal acceso As TipoAccesoAlmacen) As DataTable
        Try
            'Cargar información del área para determinar sucursal
            Dim AreaSvc As New AreaService(sessionID, Connection, Transaction)
            Dim Area As AreaInfo = AreaSvc.GetDetailFromCache(idArea)
            '
            Dim fxList As New FunctionSQL("Inventory", "fxAlmacenesByUsuarioCBO", Connection, Transaction)
            fxList.Parameters.Add("@IdSucursal", DbType.Int32).Value = Area.IdSucursal
            fxList.Parameters.Add("@IdArea", DbType.Int32).Value = idArea
            fxList.Parameters.Add("@IdUsuario", DbType.Int32).Value = idUsuario
            fxList.Parameters.Add("@Acceso", DbType.Int32).Value = CInt(acceso)
            Dim dtList As DataTable = fxList.GetTable("Almacenes")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de almacenes.", ex)
        End Try
    End Function

    Public Function LoadPasillos(ByVal idAlmacen As Integer) As DataTable
        Try
            Dim fxPasillos As New FunctionSQL("Inventory", "fxAlmacenPasillosSEL", Connection, Transaction)
            fxPasillos.Parameters.Add("@IdAlmacen", DbType.Int32).Value = idAlmacen
            Dim Pasillos As New DataTable
            fxPasillos.FillDataTable(Pasillos)
            Return Pasillos
        Catch ex As Exception
            Throw New BusinessException("Error al cargar los Pasillos del almacen " & idAlmacen.ToString, ex)
        End Try
    End Function

#End Region

#Region "Inventario"

    Public Sub MoverApartado(ByVal idAlmacen As Integer, ByVal idArticuloStock As Integer, ByVal Cantidad As Decimal, ByVal idUnidadMedida As Integer, ByVal tipo As TipoMovimiento)
        Try
            'Convertir cantidad a la unidad de medida base
            Dim UnidadMedidaSvc As New UnidadMedidaService(sessionID, Connection, Transaction)
            Dim UnidadMedida As UnidadMedidaInfo = UnidadMedidaSvc.GetDetailFromCache(idUnidadMedida)
            Dim CantidadBase As Decimal = Cantidad * UnidadMedida.Factor
            '
            Dim spInventario As New StoredProcedure("Inventory", "InventarioUPD", Connection, Transaction)
            spInventario.Parameters.Add("@IdAlmacen", DbType.Int32).Value = idAlmacen
            spInventario.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idArticuloStock
            spInventario.Parameters.Add("@Disponible", DbType.Decimal).Value = 0
            spInventario.Parameters.Add("@Apartado", DbType.Decimal).Value = CantidadBase
            spInventario.Parameters.Add("@Transito", DbType.Decimal).Value = 0
            If tipo = TipoMovimiento.Entrada Then
                spInventario.Parameters.Add("@Direccion", DbType.Int32).Value = 1
            Else
                spInventario.Parameters.Add("@Direccion", DbType.Int32).Value = -1
            End If
            spInventario.Parameters.Add("@UserUpdate", DbType.Int32).Value = Session.User.Identity
            spInventario.Parameters.Add("@LastUpdate", DbType.DateTime).Value = Date.Now
            spInventario.Parameters.Add("@PCUpdate", DbType.String).Value = Session.WorkStation
            spInventario.Execute()
        Catch ex As Exception
            Throw New BusinessException("Error al actualizar el apartado del inventario.", ex)
        End Try
    End Sub

    Public Sub MoverTransito(ByVal idAlmacen As Integer, ByVal idArticuloStock As Integer, ByVal Cantidad As Decimal, ByVal idUnidadMedida As Integer, ByVal tipo As TipoMovimiento)
        Try
            'Convertir cantidad a la unidad de medida base
            Dim UnidadMedidaSvc As New UnidadMedidaService(sessionID, Connection, Transaction)
            Dim UnidadMedida As UnidadMedidaInfo = UnidadMedidaSvc.GetDetailFromCache(idUnidadMedida)
            Dim CantidadBase As Decimal = Cantidad * UnidadMedida.Factor
            '
            Dim spInventario As New StoredProcedure("Inventory", "InventarioUPD", Connection, Transaction)
            spInventario.Parameters.Add("@IdAlmacen", DbType.Int32).Value = idAlmacen
            spInventario.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idArticuloStock
            spInventario.Parameters.Add("@Disponible", DbType.Decimal).Value = 0
            spInventario.Parameters.Add("@Apartado", DbType.Decimal).Value = 0
            spInventario.Parameters.Add("@Transito", DbType.Decimal).Value = CantidadBase
            If tipo = TipoMovimiento.Entrada Then
                spInventario.Parameters.Add("@Direccion", DbType.Int32).Value = 1
            Else
                spInventario.Parameters.Add("@Direccion", DbType.Int32).Value = -1
            End If
            spInventario.Parameters.Add("@UserUpdate", DbType.Int32).Value = Session.User.Identity
            spInventario.Parameters.Add("@LastUpdate", DbType.DateTime).Value = Date.Now
            spInventario.Parameters.Add("@PCUpdate", DbType.String).Value = Session.WorkStation
            spInventario.Execute()
        Catch ex As Exception
            Throw New BusinessException("Error al actualizar el transito del inventario.", ex)
        End Try
    End Sub

    Public Function GetInformeInventarioActual(ByVal idArea As Integer, ByVal idAlmacen As Integer) As DataTable
        Try
            Dim fxInventario As New FunctionSQL("Inventory", "fxInventarioActualRPT", Connection, Transaction)
            fxInventario.Parameters.Add("@IdArea", DbType.Int32).Value = idArea
            fxInventario.Parameters.Add("@IdAlmacen", DbType.Int32).Value = idAlmacen
            fxInventario.Parameters.Add("@IdUsuario", DbType.Int32).Value = Session.User.Identity
            Dim dtInventario As DataTable = fxInventario.GetTable("Inventario")
            Return dtInventario
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la información del inventario actual.", ex)
        End Try
    End Function

    Public Function GetInformeInventarioActualAll(ByVal idArea As Integer, ByVal idAlmacen As Integer, ByVal idSucursal As Integer) As DataTable
        Try
            Dim fxInventario As New FunctionSQL("Inventory", "fxInventarioActualAllRPT", Connection, Transaction)
            fxInventario.Parameters.Add("@IdArea", DbType.Int32).Value = idArea
            fxInventario.Parameters.Add("@IdAlmacen", DbType.Int32).Value = idAlmacen
            fxInventario.Parameters.Add("@IdUsuario", DbType.Int32).Value = Session.User.Identity
            fxInventario.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            Dim dtInventario As DataTable = fxInventario.GetTable("Inventario")
            Return dtInventario
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la información del inventario actual.", ex)
        End Try
    End Function


    Public Function GetInformeInventarioHistorico(ByVal fechaInicial As Date, ByVal fechaFinal As Date, ByVal idArea As Integer, ByVal idAlmacen As Integer) As DataTable
        Try
            Dim fxInventario As New FunctionSQL("Inventory", "fxInventarioHistRPT", Connection, Transaction)
            fxInventario.Parameters.Add("@FechaIni", DbType.DateTime).Value = fechaInicial
            fxInventario.Parameters.Add("@FechaFin", DbType.DateTime).Value = fechaFinal
            fxInventario.Parameters.Add("@IdArea", DbType.Int32).Value = idArea
            fxInventario.Parameters.Add("@IdAlmacen", DbType.Int32).Value = idAlmacen
            fxInventario.Parameters.Add("@IdUsuario", DbType.Int32).Value = Session.User.Identity
            Dim dtInventario As DataTable = fxInventario.GetTable("Inventario")
            Return dtInventario
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la información del inventario actual.", ex)
        End Try
    End Function

    Public Function GetInformeKardex(ByVal idAlmacen As Integer, ByVal fechaInicial As Date, ByVal fechaFinal As Date, ByVal idArticuloStock As Integer) As DataTable
        Try
            Dim fxKardex As New FunctionSQL("Inventory", "fxKardexInventarioRPT", Connection, Transaction)
            fxKardex.Parameters.Add("@IdAlmacen", DbType.Int32).Value = idAlmacen
            fxKardex.Parameters.Add("@FechaIni", DbType.DateTime).Value = fechaInicial
            fxKardex.Parameters.Add("@FechaFin", DbType.DateTime).Value = fechaFinal
            fxKardex.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idArticuloStock
            Dim dtKardex As DataTable = fxKardex.GetTable("Kardex")
            Return dtKardex
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la información del kardex de inventario.", ex)
        End Try
    End Function

    Public Function GetStock(ByVal idAlmacen As Integer) As DataTable
        Try
            Dim fxInventario As New FunctionSQL("Inventory", "fxAlmacenStock", Connection, Transaction)
            fxInventario.Parameters.Add("@IdAlmacen", DbType.Int32).Value = idAlmacen
            Dim dtInventario As DataTable = fxInventario.GetTable("Inventario")
            Return dtInventario
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el inventario del almacén (" & idAlmacen.ToString & ")", ex)
        End Try
    End Function

    Public Function GetStockInfo(ByVal idAlmacen As Integer, ByVal idArticuloStock As Integer) As StockInfo
        Try
            Dim fxInventario As New FunctionSQL("Inventory", "fxInventarioSEL", Connection, Transaction)
            fxInventario.Parameters.Add("@IdAlmacen", DbType.Int32).Value = idAlmacen
            fxInventario.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idArticuloStock
            Dim dtInventario As DataTable = fxInventario.GetTable("Inventario")
            Dim Info As New StockInfo
            If dtInventario.Rows.Count > 0 Then
                Dim drStock As DataRow = dtInventario.Rows(0)
                With Info
                    ._Disponible = CDec(drStock("Disponible"))
                    ._Apartado = CDec(drStock("Apartado"))
                    ._Transito = CDec(drStock("Transito"))
                    ._CostoPromedio = CDec(drStock("CostoPromedio"))
                    ._UltimoCosto = CDec(drStock("CostoUltimo"))
                    ._Ubicacion = CStr(drStock("Ubicacion"))
                End With
            End If
            Return Info
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la información de stock del almacén (" & idAlmacen.ToString & ") y artículo (" & idArticuloStock & ")", ex)
        End Try
    End Function

    Public Function GetInformeInventarioBySegmento(ByVal idUsuario As Integer, ByVal idSucursal As Integer, ByVal idArea As Integer, ByVal idAlmacen As Integer, ByVal idTipo As Integer, ByVal idFamilia As Integer) As DataTable
        Try
            Dim fxInventario As New FunctionSQL("Inventory", "fxInventarioBySegmentoRPT", Connection, Transaction)
            fxInventario.Parameters.Add("@IdUsuario", DbType.Int32).Value = Session.User.Identity
            fxInventario.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            fxInventario.Parameters.Add("@IdArea", DbType.Int32).Value = idArea
            fxInventario.Parameters.Add("@IdAlmacen", DbType.Int32).Value = idAlmacen
            fxInventario.Parameters.Add("@IdTipo", DbType.Int32).Value = idTipo
            fxInventario.Parameters.Add("@IdFamilia", DbType.Int32).Value = idFamilia

            Dim dtInventario As DataTable = fxInventario.GetTable("Inventario")
            Return dtInventario
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la información del inventario actual por segmento.", ex)
        End Try
    End Function

    Public Function GetInformeInventarioProduccionProceso(ByVal idUsuario As Integer, ByVal idSucursal As Integer, ByVal fechaIni As DateTime, ByVal fechaFin As DateTime, ByVal idArticuloStockInsumo As Integer, ByVal idArticuloStockFabricado As Integer, ByVal statusProduccion As String, ByVal usarRangoFechas As Boolean) As DataTable
        Try
            Dim fxInventario As New FunctionSQL("Inventory", "fxInventarioProduccionProcesoRPT", Connection, Transaction)
            fxInventario.Parameters.Add("@FechaIni", DbType.DateTime).Value = fechaIni
            fxInventario.Parameters.Add("@FechaFin", DbType.DateTime).Value = fechaFin
            fxInventario.Parameters.Add("@IdArticuloStockInsumo", DbType.Int32).Value = idArticuloStockInsumo
            fxInventario.Parameters.Add("@IdArticuloStockFabricado", DbType.Int32).Value = idArticuloStockFabricado
            fxInventario.Parameters.Add("@StatusProduccion", DbType.String).Value = statusProduccion
            fxInventario.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            fxInventario.Parameters.Add("@IdUsuario", DbType.Int32).Value = Session.User.Identity
            fxInventario.Parameters.Add("@UsarRangoFechas", DbType.Boolean).Value = usarRangoFechas

            Dim dtInventario As DataTable = fxInventario.GetTable("Inventario")
            Return dtInventario
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la información del inventario de produccion en proceso.", ex)
        End Try
    End Function

#End Region

#Region "Accesos"

    Public Function LoadAccesos(ByVal idAlmacen As Integer) As ObjectAccessDS.UsuariosDataTable
        Try
            Dim fxAccesos As New FunctionSQL("Inventory", "fxAlmacenAccesosSEL", Connection, Transaction)
            fxAccesos.Parameters.Add("@IdAlmacen", DbType.Int32).Value = idAlmacen
            Dim dtAccesos As New ObjectAccessDS.UsuariosDataTable
            fxAccesos.FillDataTable(dtAccesos)
            dtAccesos.Columns("Entrada").DefaultValue = "False"
            dtAccesos.Columns("Salida").DefaultValue = "False"
            Return dtAccesos
        Catch ex As Exception
            Throw New BusinessException("Error al cargar los accesos del almacén.", ex)
        End Try
    End Function

    Public Sub SaveAccesos(ByVal idAlmacen As Integer, ByVal usuarios As ObjectAccessDS.UsuariosDataTable)
        Try
            Dim comUpdate As New DbCommand("Inventory.AlmacenAccesosUPD", Connection, Transaction)
            comUpdate.CommandType = CommandType.StoredProcedure
            comUpdate.Parameters.Add("@IdAlmacen", DbType.Int32).Value = idAlmacen
            comUpdate.Parameters.Add("@IdUsuario", DbType.Int32, "IdUsuario")
            comUpdate.Parameters.Add("@Entrada", DbType.Boolean, "Entrada")
            comUpdate.Parameters.Add("@Salida", DbType.Boolean, "Salida")
            '
            Dim comDelete As New DbCommand("Inventory.AlmacenAccesosDEL", Connection, Transaction)
            comDelete.CommandType = CommandType.StoredProcedure
            comDelete.Parameters.Add("@IdAlmacen", DbType.Int32).Value = idAlmacen
            comDelete.Parameters.Add("@IdUsuario", DbType.Int32, "IdUsuario")
            '
            Dim da As New DataAdapter()
            da.InsertCommand = comUpdate
            da.UpdateCommand = comUpdate
            da.DeleteCommand = comDelete
            da.Update(usuarios)
        Catch concurrencyEx As DBConcurrencyException

        Catch ex As Exception
            Throw New BusinessException("Error al guardar los accesos del almacén.", ex)
        End Try
    End Sub

    Public Function CargarUsuarioAccesos(ByVal idUsuario As Integer) As UsuarioAccesosDS.AlmacenesDataTable
        Try
            Dim fxAlmacenes As New FunctionSQL("Inventory", "fxUsuarioAlmacenesSEL", Connection, Transaction)
            fxAlmacenes.Parameters.Add("@IdUsuario", DbType.Int32).Value = idUsuario
            Dim dtAlmacenes As New UsuarioAccesosDS.AlmacenesDataTable
            fxAlmacenes.FillDataTable(dtAlmacenes)
            Return dtAlmacenes
        Catch ex As Exception
            Throw New BusinessException("Error al cargar los accesos del usuario: " & idUsuario.ToString, ex)
        End Try
    End Function

    Public Sub GuardarUsuarioAccesos(ByVal idUsuario As Integer, ByVal dtAlmacenes As UsuarioAccesosDS.AlmacenesDataTable)
        Try
            Dim comUpdate As New DbCommand("Inventory.UsuarioAlmacenesUPD", Connection, Transaction)
            comUpdate.CommandType = CommandType.StoredProcedure
            comUpdate.Parameters.Add("@IdAlmacen", DbType.Int32, "IdAlmacen")
            comUpdate.Parameters.Add("@IdUsuario", DbType.Int32).Value = idUsuario
            comUpdate.Parameters.Add("@Entrada", DbType.Boolean, "Entrada")
            comUpdate.Parameters.Add("@Salida", DbType.Boolean, "Salida")
            comUpdate.Parameters.Add("@Selected", DbType.Boolean, "Selected")
            '
            Dim da As New DataAdapter()
            da.UpdateCommand = comUpdate
            da.Update(dtAlmacenes)
        Catch concurrencyEx As DBConcurrencyException

        Catch ex As Exception
            Throw New BusinessException("Error al guardar los accesos del usuario: " & idUsuario.ToString, ex)
        End Try
    End Sub

#End Region

#Region "Ubicaciones"
    Public Sub UbicacionesUPD(IdAlmacen As Integer, Almacen As AlmacenInfo)
        'Verificar si hay filas eliminadas, si es así, entonces ejecutar primero
        Dim DeletedRows As HierarchyDS.HierarchyDataTable = CType(Almacen.UbicacionesNodesTable.GetChanges(DataRowState.Deleted), HierarchyDS.HierarchyDataTable)
        If DeletedRows IsNot Nothing Then
            'Se establece como regla, que el stored Procedure que llena la Tabla de detalles propiedad del DocumentInfo, contendra los campos "Id" y "IdTitulo" para el Id de la tabla de detalle y el Numero de documento que lo enlaza con el titulo, respectivamente.
            Dim cmdDelete As New DbCommand("Inventory.UbicacionesDEL", Me.Connection, Me.Transaction)
            cmdDelete.CommandType = CommandType.StoredProcedure
            cmdDelete.Parameters.Add("@ID", DbType.Int32, "IdUbicacion")
            Dim da As New DataAdapter
            da.DeleteCommand = cmdDelete
            da.Update(DeletedRows)
        End If

        'Verificar si hay filas nuevas o modificadas
        'Dim UpdatedRows As DataTable = Almacen.UbicacionesNodesTable.GetChanges(DataRowState.Added Or DataRowState.Modified)
        'If UpdatedRows IsNot Nothing Then
        Dim dv As New DataView(Almacen.UbicacionesNodesTable, "", "Identity,Orden", DataViewRowState.CurrentRows)

        For Each dr As DataRowView In dv
            Dim drUbic As HierarchyDS.HierarchyRow = CType(dr.Row, HierarchyDS.HierarchyRow)

            Dim Ubicacion As New UbicacionInfo(Me.SessionID)
            Ubicacion.setIdentity(CInt(drUbic("IdUbicacion")))
            Ubicacion.Nombre = drUbic.Nombre
            Ubicacion.IdAlmacen = IdAlmacen
            Ubicacion.IdUbicacionTipo = CInt(drUbic("IdUbicacionTipo"))
            Ubicacion.IdImpresora = CInt(drUbic("IdImpresora"))
            Ubicacion.IdCuenta = CInt(drUbic("IdCuenta"))
            Ubicacion.Status = CatalogState.Active
            Ubicacion.IdEmpresa = Almacen.IdEmpresa
            Ubicacion.IdSucursal = Almacen.IdSucursal
            Ubicacion.IdPadre = drUbic.IdPadre
            Ubicacion.Orden = drUbic.Orden
            'Si son de los recien agregados, los ligamos por el Identity, IdentityPadre
            If CInt(drUbic("IdUbicacion")) = 0 And CInt(drUbic("IdentityPadre")) <> 0 Then
                Dim drPadre As HierarchyDS.HierarchyRow = Almacen.UbicacionesNodesTable.FindByIdentity(CInt(drUbic("IdentityPadre")))
                If Not IsNothing(drPadre) Then
                    Ubicacion.IdPadre = CInt(drPadre("IdUbicacion"))
                End If
            End If

            Dim UbicSvc As New UbicacionService(Me.SessionID, Me.Connection, Me.Transaction)
            dr("IdUbicacion") = UbicSvc.Update(Ubicacion)
        Next
        'End If


    End Sub

#End Region

End Class


Partial Class AlmacenFacade

#Region "Generales"

    Public Function LoadList(ByVal sessionID As Guid, ByVal idSucursal As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New AlmacenService(sessionID, Connection, Transaction)
            dtList = Svc.LoadList(idSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function LoadList(ByVal sessionID As Guid, ByVal idSucursal As Integer, ByVal idUsuario As Integer, ByVal acceso As TipoAccesoAlmacen) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New AlmacenService(sessionID, Connection, Transaction)
            dtList = Svc.LoadList(idSucursal, idUsuario, acceso)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function LoadListByArea(ByVal sessionID As Guid, ByVal idArea As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New AlmacenService(sessionID, Connection, Transaction)
            dtList = Svc.LoadListByArea(idArea)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function LoadListByArea(ByVal sessionID As Guid, ByVal idArea As Integer, ByVal idUsuario As Integer, ByVal acceso As TipoAccesoAlmacen) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New AlmacenService(sessionID, Connection, Transaction)
            dtList = Svc.LoadListByArea(idArea, idUsuario, acceso)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList

    End Function

    Public Function LoadPasillos(ByVal sessionID As Guid, ByVal idAlmacen As Integer) As DataTable
        ValidateSession(sessionID)
        Dim PasillosTable As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New AlmacenService(sessionID, Connection, Transaction)
            PasillosTable = Svc.LoadPasillos(idAlmacen)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return PasillosTable
    End Function

#End Region

#Region "Inventario"

    Public Function GetStock(ByVal sessionID As Guid, ByVal idAlmacen As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtInventario As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New AlmacenService(sessionID, Connection, Transaction)
            dtInventario = Svc.GetStock(idAlmacen)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtInventario
    End Function

    Public Function GetStockInfo(ByVal sessionID As Guid, ByVal idAlmacen As Integer, ByVal idArticuloStock As Integer) As StockInfo
        ValidateSession(sessionID)
        Dim Info As StockInfo = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New AlmacenService(sessionID, Connection, Transaction)
            Info = Svc.GetStockInfo(idAlmacen, idArticuloStock)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Info
    End Function

    Public Function GetInformeInventarioActual(ByVal sessionID As Guid, ByVal idArea As Integer) As DataTable
        Return GetInformeInventarioActual(sessionID, idArea, 0)
    End Function


    Public Function GetInformeInventarioActual(ByVal sessionID As Guid, ByVal idArea As Integer, ByVal idAlmacen As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtInventario As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New AlmacenService(sessionID, Connection, Transaction)
            dtInventario = Svc.GetInformeInventarioActual(idArea, idAlmacen)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtInventario
    End Function

    Public Function GetInformeInventarioActualAll(ByVal sessionID As Guid, ByVal idArea As Integer, ByVal idAlmacen As Integer, ByVal idSucursal As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtInventario As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New AlmacenService(sessionID, Connection, Transaction)
            dtInventario = Svc.GetInformeInventarioActualAll(idArea, idAlmacen, idSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtInventario
    End Function

    Public Function GetInformeInventarioHistorico(ByVal sessionID As Guid, ByVal fechaInicial As Date, ByVal fechaFinal As Date, ByVal idArea As Integer, ByVal idAlmacen As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtInventario As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New AlmacenService(sessionID, Connection, Transaction)
            dtInventario = Svc.GetInformeInventarioHistorico(fechaInicial, fechaFinal, idArea, idAlmacen)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtInventario
    End Function

    Public Function GetInformeKardex(ByVal sessionID As Guid, ByVal idAlmacen As Integer, ByVal fechaInicial As Date, ByVal fechaFinal As Date, ByVal idArticuloStock As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtKardex As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New AlmacenService(sessionID, Connection, Transaction)
            dtKardex = Svc.GetInformeKardex(idAlmacen, fechaInicial, fechaFinal, idArticuloStock)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtKardex
    End Function

    Public Function GetInformeInventarioBySegmento(ByVal sessionID As Guid, ByVal idUsuario As Integer, ByVal idSucursal As Integer, ByVal idArea As Integer, ByVal idAlmacen As Integer, ByVal idTipo As Integer, ByVal idFamilia As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtInventario As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New AlmacenService(sessionID, Connection, Transaction)
            dtInventario = Svc.GetInformeInventarioBySegmento(idUsuario, idSucursal, idArea, idAlmacen, idTipo, idFamilia)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtInventario
    End Function

    Public Function GetInformeInventarioProduccionProceso(ByVal sessionID As Guid, ByVal idUsuario As Integer, ByVal idSucursal As Integer, ByVal fechaIni As DateTime, ByVal fechaFin As DateTime, ByVal idArticuloStockInsumo As Integer, ByVal idArticuloStockFabricado As Integer, ByVal StatusProduccion As String, ByVal usarRangoFechas As Boolean) As DataTable
        ValidateSession(sessionID)
        Dim dtInventario As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New AlmacenService(sessionID, Connection, Transaction)
            dtInventario = Svc.GetInformeInventarioProduccionProceso(idUsuario, idSucursal, fechaIni, fechaFin, idArticuloStockInsumo, idArticuloStockFabricado, StatusProduccion, usarRangoFechas)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtInventario
    End Function

#End Region

#Region "Accesos"

    Public Function LoadAccesos(ByVal sessionID As Guid, ByVal idAlmacen As Integer) As ObjectAccessDS.UsuariosDataTable
        ValidateSession(sessionID)
        Dim dtAccesos As New ObjectAccessDS.UsuariosDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New AlmacenService(sessionID, Connection, Transaction)
            dtAccesos = Svc.LoadAccesos(idAlmacen)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtAccesos
    End Function

    Public Sub SaveAccesos(ByVal sessionID As Guid, ByVal idAlmacen As Integer, ByVal usuarios As ObjectAccessDS.UsuariosDataTable)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New AlmacenService(sessionID, Connection, Transaction)
                Svc.SaveAccesos(idAlmacen, usuarios)
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

    Public Function CargarUsuarioAccesos(ByVal sessionID As Guid, ByVal idUsuario As Integer) As UsuarioAccesosDS.AlmacenesDataTable
        ValidateSession(sessionID)
        Dim dtAlmacenes As New UsuarioAccesosDS.AlmacenesDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New AlmacenService(sessionID, Connection)
            dtAlmacenes = Svc.CargarUsuarioAccesos(idUsuario)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtAlmacenes
    End Function

    Public Sub GuardarUsuarioAccesos(ByVal sessionID As Guid, ByVal idUsuario As Integer, ByVal dtAlmacenes As UsuarioAccesosDS.AlmacenesDataTable)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New AlmacenService(sessionID, Connection, Transaction)
                Svc.GuardarUsuarioAccesos(idUsuario, dtAlmacenes)
                DataServices.CommitTransaction(Transaction)
            Catch exc As Exception
                DataServices.RollbackTransaction(Transaction)
                Throw exc
            End Try
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub

#End Region

#Region "Ubicaciones"
    'Public Sub UbicacionesUPD(SessionId As Guid, Almacen As AlmacenInfo, UbicacionesNodesTable As HierarchyDS.HierarchyDataTable)
    '    ValidateSession(SessionId)
    '    Try
    '        Connection = DataServices.OpenConnection
    '        Try
    '            Transaction = DataServices.BeginTransaction(Connection)
    '            Dim Svc As New AlmacenService(SessionId, Connection, Transaction)
    '            Svc.UbicacionesUPD(Almacen)
    '            DataServices.CommitTransaction(Transaction)
    '        Catch ex As Exception
    '            DataServices.RollbackTransaction(Transaction)
    '            Throw ex
    '        End Try
    '    Catch ex As Exception
    '        HandleException(ex)
    '    Finally
    '        DataServices.CloseConnection(Connection)
    '    End Try
    'End Sub
#End Region

End Class

<Serializable()> _
Public Enum TipoAccesoAlmacen
    Lectura = 0
    Entrada = 1
    Salida = 2
    Ambos = 3
End Enum