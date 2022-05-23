Imports Azteca.Kernel

Partial Class ArticuloService

#Region "Metodos Generales"

    Public Function GetDetailFromCache(idArticulo As Integer) As ArticuloInfo
        Dim CacheKey As String = "Articulo_" & idArticulo.ToString
        Dim Articulo As New ArticuloInfo(SessionID)
        Try
            If Cache.Contains(CacheKey) Then
                Articulo = CType(Cache.Item(CacheKey), ArticuloInfo)
            Else
                Dim ArticuloSvc As New ArticuloService(SessionID, Connection, Transaction)
                ArticuloSvc.GetDetail(idArticulo, Articulo, False)
                Cache.Add(CacheKey, Articulo, TimeSpan.FromDays(1))
            End If
            Return Articulo
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el artículo desde el caché", ex)
        End Try
    End Function

    Public Function ListaExpress(ByVal idSucursal As Integer) As DataTable
        Try
            Dim fxPresentaciones As New FunctionSQL("Sales", "fxArticulosExpresList", Connection, Transaction)
            fxPresentaciones.Parameters.Add("@idSucursal", DbType.Int32).Value = idSucursal
            Dim dtPresentaciones As New DataTable
            fxPresentaciones.FillDataTable(dtPresentaciones)
            Return dtPresentaciones
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lita de artículos ", ex)
        End Try
    End Function

    Public Function PresentacionesFotoList(ByVal idEstructuraCompra As Integer) As DataTable
        Try
            Dim fxPresentaciones As New FunctionSQL("Sales", "fxArticulosFotoEnEstCom", Connection, Transaction)
            fxPresentaciones.Parameters.Add("@idEstCom", DbType.Int32).Value = idEstructuraCompra
            Dim dtPresentaciones As New DataTable
            fxPresentaciones.FillDataTable(dtPresentaciones)
            Return dtPresentaciones
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lita de artículos ", ex)
        End Try
    End Function

    Public Function ColoresList(ByVal idArticulo As Integer) As ArticulosDS.ColoresDataTable
        Try
            Dim fx As New FunctionSQL("Sales", "fxArticulosColoresSEL", Connection, Transaction)
            fx.Parameters.Add("@IdArticulo", DbType.Int32).Value = idArticulo
            Dim dt As New ArticulosDS.ColoresDataTable
            fx.FillDataTable(dt)
            Return dt
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de colores ", ex)
        End Try
    End Function

    Public Function PresentacionesTallaColorList(ByVal idArticulo As Integer) As ArticulosDS.TallasColoresDataTable
        Try
            Dim fx As New FunctionSQL("Sales", "fxArticulosPresTallaColorList", Connection, Transaction)
            fx.Parameters.Add("@IdArticulo", DbType.Int32).Value = idArticulo
            Dim dt As New ArticulosDS.TallasColoresDataTable
            fx.FillDataTable(dt)
            Return dt
        Catch ex As Exception
            Throw New BusinessException("Error al cargar las Presentaciones de Talla/Color", ex)
        End Try
    End Function


    Public Sub ColoresSave(idArticulo As Integer, ColoresTable As DataTable)
        Try
            'Si no se manejan colores, no guarda nada
            If New DataView(ColoresTable, "Sel=1", "", DataViewRowState.CurrentRows).Count = 0 Then Exit Sub

            Dim cmd As New Azteca.Data.DbCommand("Sales.ArticulosColoresUPD", Me.Connection, Me.Transaction)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@IdArticulo", DbType.Int32).Value = idArticulo
            cmd.Parameters.Add("@IdColor", DbType.Int32, "IdColor")
            cmd.Parameters.Add("@Sel", DbType.Boolean, "Sel")

            Dim da As New DataAdapter
            da.UpdateCommand = cmd
            da.Update(ColoresTable)
        Catch ex As Exception
            Throw New Exception("Error al guardar la lista de colores que administra el Articulo", ex)
        End Try
    End Sub

    Public Sub setRegleta(IdArticulo As Integer, IdRegleta As Integer)
        Try
            Dim sp As New StoredProcedure("Sales", "ArticuloRegletaUPD", Me.Connection, Me.Transaction)
            sp.Parameters.Add("@IdArticulo", DbType.Int32).Value = IdArticulo
            sp.Parameters.Add("@IdRegleta", DbType.Int32).Value = IdRegleta
            sp.Execute()
        Catch ex As Exception
            Throw New Exception("Error al establecer la regleta para el Articulo", ex)
        End Try
    End Sub

#End Region

#Region "Presentaciones"

    Public Function LoadPresentaciones(ByVal idArticulo As Integer) As ArticulosDS.PresentacionesDataTable
        Try
            Dim fxPresentaciones As New FunctionSQL("Sales", "fxArticuloPresentaciones", Connection, Transaction)
            fxPresentaciones.Parameters.Add("@IdArticulo", DbType.Int32).Value = idArticulo
            Dim dtPresentaciones As New ArticulosDS.PresentacionesDataTable
            fxPresentaciones.FillDataTable(dtPresentaciones)
            Return dtPresentaciones
        Catch ex As Exception
            Throw New BusinessException("Error al cargar las presentaciones del artículo " & idArticulo.ToString, ex)
        End Try
    End Function

    Public Sub AgregarPresentacion(ByVal idArticulo As Integer, ByVal idArticuloStock As Integer)
        Try
            Dim fxExiste As New FunctionSQL("Sales", "fxArticuloPresentacionExists", Connection, Transaction)
            fxExiste.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idArticuloStock
            If Not CBool(fxExiste.GetScalar) Then
                Try
                    Dim spAdd As New StoredProcedure("Sales", "ArticulosPresentacionesUPD", Connection, Transaction)
                    spAdd.Parameters.Add("@IdArticulo", DbType.Int32).Value = idArticulo
                    spAdd.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idArticuloStock
                    spAdd.Execute()
                Catch ex As Exception
                    Throw New BusinessException("Error al guardar las presentaciones del artículo", ex)
                End Try
            Else
                Throw New BusinessException("La presentación ya está asignada a otro artículo.")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub QuitarPresentacion(ByVal idArticulo As Integer, ByVal idArticuloStock As Integer)
        Try
            Dim spDelete As New StoredProcedure("Sales", "ArticulosPresentacionesDEL", Connection, Transaction)
            spDelete.Parameters.Add("@IdArticulo", DbType.Int32).Value = idArticulo
            spDelete.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idArticuloStock
            spDelete.Execute()
        Catch ex As Exception
            Throw New BusinessException("Error al remover la presentación del artículo.", ex)
        End Try
    End Sub

#End Region

#Region "Clasificaciones"

    Public Function CargarClasificaciones(ByVal idArticulo As Integer) As DataTable
        Try
            Dim fxClasificaciones As New FunctionSQL("Sales", "fxClasificacionesArticulosSEL", Connection, Transaction)
            fxClasificaciones.Parameters.Add("@IdArticulo", DbType.Int32).Value = idArticulo
            Dim dtClasificaciones As DataTable = fxClasificaciones.GetTable("Clasificaciones")
            Return dtClasificaciones
        Catch ex As Exception
            Throw New BusinessException("Error al cargar las clasificaciones del Articulo.", ex)
        End Try
    End Function

    Public Sub GuardarClasificaciones(ByVal idArticulo As Integer, ByVal clasificaciones As DataTable)
        Try
            Dim comUpdate As New DbCommand("Sales.ClasificacionesArticulosUPD", Connection, Transaction)
            comUpdate.CommandType = CommandType.StoredProcedure
            comUpdate.Parameters.Add("@IdArticulo", DbType.Int32).Value = idArticulo
            comUpdate.Parameters.Add("@IdClasificacionGrupo", DbType.Int32, "IdGrupo")
            comUpdate.Parameters.Add("@IdClasificacion", DbType.Int32, "IdClasificacion")
            '
            Dim da As New DataAdapter
            da.UpdateCommand = comUpdate
            da.Update(clasificaciones)
        Catch concurrencyEx As DBConcurrencyException

        Catch ex As Exception
            Throw New BusinessException("Error al guardar las clasificaciones del articulo.", ex)
        End Try
    End Sub

#End Region

#Region "Precios"

    Public Function GetPrecio(ByVal idArticuloStock As Integer, ByVal idCliente As Integer, ByVal idSucursal As Integer) As PrecioInfo
        Return GetPrecio(idArticuloStock, idCliente, idSucursal, 0)
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

#End Region


End Class



Partial Class ArticuloFacade
    Public Property IdArticulostockExpressAdd As Integer

#Region "Metodos Generales"
    Public Function UpdateOnInventory(SessionID As Guid, ByVal Articulo As ArticuloInfo, PreciosTable As DataTable) As Integer
        ValidateSession(SessionID)
        Dim IdArtVenta As Integer
        Try
            Connection = DataServices.OpenConnection
            Try
                Dim NewItem As Boolean = Articulo.Identity = 0

                Transaction = DataServices.BeginTransaction(Connection)

                Dim Svc As New ArticuloService(SessionID, Connection, Transaction)
                IdArtVenta = Svc.Update(Articulo)

                Dim SvcStock As New Azteca.Business.Inventario.ArticuloStockService(SessionID, Connection, Transaction)
                Dim ArtStock As New Azteca.Business.Inventario.ArticuloStockInfo(SessionID)
                If Not NewItem Then
                    'Obtenemos el Codigo Stock relacionado con este articulo de venta
                    SvcStock.GetDetail(Articulo.UserCode, Articulo.IdSucursal, ArtStock, True)
                End If

                'Actualizamos los datos del Art de venta para el de Stock
                ArtStock.UserCode = Articulo.UserCode : ArtStock.EAN = "" : ArtStock.IdCuenta = 0
                ArtStock.Nombre = Articulo.Nombre : ArtStock.Descripcion = Articulo.Nombre
                ArtStock.IdEmpresa = Articulo.IdEmpresa : ArtStock.IdSucursal = Articulo.IdSucursal
                ArtStock.IdUnidadMedida = Articulo.IdUnidadMedida
                ArtStock.Orden = 0 : ArtStock.Origen = "" : ArtStock.PuntoReorden = 0 : ArtStock.Status = Articulo.Status : ArtStock.StockMax = 0 : ArtStock.StockMin = 0
                Dim IdArtStock As Integer = SvcStock.Update(ArtStock)

                'Si es nuevo, agregamos la relacion en la venta
                If NewItem Then Svc.AgregarPresentacion(IdArtVenta, IdArtStock)

                IdArticulostockExpressAdd = IdArtStock
                'Guardamos las listas de precios
                Dim ListaPreciosSvc As New ListaPreciosService(SessionID, Connection, Transaction)
                ListaPreciosSvc.ArticulosPreciosSave(IdArtStock, PreciosTable)

                DataServices.CommitTransaction(Transaction)
                Return IdArtVenta
            Catch ex As Exception
                DataServices.RollbackTransaction(Transaction)
                Throw ex
            End Try
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try

        Return IdArtVenta

    End Function



    Public Function GetDetailFromCache(sessionID As Guid, idArticulo As Integer) As ArticuloInfo
        ValidateSession(sessionID)
        Dim Articulo As ArticuloInfo = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ArticuloService(sessionID, Connection, Transaction)
            Articulo = Svc.GetDetailFromCache(idArticulo)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Articulo
    End Function

    Public Function ListaExpress(ByVal sessionID As Guid, ByVal idSucursal As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtLista As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ArticuloService(sessionID, Connection, Transaction)
            dtLista = Svc.ListaExpress(idSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtLista
    End Function

    Public Function PresentacionesFotoList(ByVal sessionID As Guid, ByVal idEstructuraCompra As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtLista As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ArticuloService(sessionID, Connection, Transaction)
            dtLista = Svc.PresentacionesFotoList(idEstructuraCompra)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtLista
    End Function

    Public Function ColoresList(ByVal sessionID As Guid, ByVal idArticulo As Integer) As ArticulosDS.ColoresDataTable
        ValidateSession(sessionID)
        Dim dtLista As New ArticulosDS.ColoresDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ArticuloService(sessionID, Connection, Transaction)
            dtLista = Svc.ColoresList(idArticulo)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtLista
    End Function

    Public Function PresentacionesTallaColorList(ByVal sessionID As Guid, ByVal idArticulo As Integer) As ArticulosDS.TallasColoresDataTable
        ValidateSession(sessionID)
        Dim dtLista As New ArticulosDS.TallasColoresDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ArticuloService(sessionID, Connection, Transaction)
            dtLista = Svc.PresentacionesTallaColorList(idArticulo)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtLista
    End Function

    Public Sub savePresentacionesTallaColor(ByVal sessionID As Guid, ArticuloInfo As ArticuloInfo, TallaColorTable As ArticulosDS.TallasColoresDataTable, ColoresTable As ArticulosDS.ColoresDataTable)
        Dim Svc As Azteca.Business.Inventario.ArticuloStockService
        Dim SvcArt As ArticuloService

        ValidateSession(sessionID)
        Try

            Connection = DataServices.OpenConnection

            Try
                Transaction = Connection.BeginTransaction()
                For Each drArt As ArticulosDS.TallasColoresRow In TallaColorTable
                    Dim NuevaPresentacion As Boolean = True
                    'Agregamos el articulo de cada talla/color seleccionada
                    Dim ArtStockInfo As New Azteca.Business.Inventario.ArticuloStockInfo(sessionID)
                    Svc = New Azteca.Business.Inventario.ArticuloStockService(sessionID, Connection, Transaction)
                    If Svc.Exists(drArt.Codigo, ArticuloInfo.IdSucursal) Then
                        NuevaPresentacion = False
                        Svc.GetDetail(drArt.Codigo, ArticuloInfo.IdSucursal, ArtStockInfo, False)
                    End If
                    With ArtStockInfo
                        .UserCode = drArt.Codigo
                        .Nombre = ArticuloInfo.Nombre & CStr(IIf(drArt.IdColor > 0, " Color:" & drArt.Color, "")) & CStr(IIf(drArt.IdTalla > 0, " Talla:" & drArt.Talla, ""))
                        .Descripcion = ArticuloInfo.Nombre & CStr(IIf(drArt.IdColor > 0, " Color:" & drArt.Color, "")) & CStr(IIf(drArt.IdTalla > 0, " Talla:" & drArt.Talla, ""))
                        .IdTalla = drArt.IdTalla
                        .IdColor = drArt.IdColor
                        .StockMax = 1 : .StockMin = 1 : .PuntoReorden = 1
                        .EAN = drArt.Codigo
                        .IdUnidadMedida = ArticuloInfo.IdUnidadMedida
                        .IdSucursal = ArticuloInfo.IdSucursal : .IdEmpresa = ArticuloInfo.IdEmpresa
                        .Status = CatalogState.Active
                    End With
                    Svc.Update(ArtStockInfo)

                    'Agregamos la presentacion al Articulo siempre y cuando sea una presentacion nueva
                    If NuevaPresentacion Then
                        SvcArt = New ArticuloService(sessionID, Connection, Transaction)
                        SvcArt.AgregarPresentacion(ArticuloInfo.Identity, ArtStockInfo.Identity)
                    End If
                Next

                'Guardamos los colores que maneja este Articulo
                SvcArt = New ArticuloService(sessionID, Connection, Transaction)
                SvcArt.ColoresSave(ArticuloInfo.Identity, ColoresTable)
                SvcArt.setRegleta(ArticuloInfo.Identity, ArticuloInfo.IdRegleta)


                Transaction.Commit()
            Catch ex As Exception
                Transaction.Rollback()
                Throw New Exception("Error al Generar las Presentaciones de Talla/Color", ex)
            End Try
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try


    End Sub

#End Region

#Region "Presentaciones"

    Public Function LoadPresentaciones(ByVal sessionID As Guid, ByVal idArticulo As Integer) As ArticulosDS.PresentacionesDataTable
        ValidateSession(sessionID)
        Dim dtPresentaciones As New ArticulosDS.PresentacionesDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ArticuloService(sessionID, Connection, Transaction)
            dtPresentaciones = Svc.LoadPresentaciones(idArticulo)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtPresentaciones
    End Function

    Public Sub AgregarPresentacion(ByVal sessionID As Guid, ByVal idArticulo As Integer, ByVal idArticuloStock As Integer)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New ArticuloService(sessionID, Connection, Transaction)
                Svc.AgregarPresentacion(idArticulo, idArticuloStock)
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

    Public Sub QuitarPresentacion(ByVal sessionID As Guid, ByVal idArticulo As Integer, ByVal idArticuloStock As Integer)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New ArticuloService(sessionID, Connection, Transaction)
                Svc.QuitarPresentacion(idArticulo, idArticuloStock)
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

#Region "Clasificaciones"

    Public Function CargarClasificaciones(ByVal sessionID As Guid, ByVal idArticulo As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtClasificaciones As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ArticuloService(sessionID, Connection, Transaction)
            dtClasificaciones = Svc.CargarClasificaciones(idArticulo)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtClasificaciones
    End Function

    Public Sub GuardarClasificaciones(ByVal sessionID As Guid, ByVal idArticulo As Integer, ByVal clasificaciones As DataTable)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New ArticuloService(sessionID, Connection, Transaction)
                Svc.GuardarClasificaciones(idArticulo, clasificaciones)
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

#Region "Precios"

    Public Function GetPrecio(ByVal sessionID As Guid, ByVal idArticuloStock As Integer, ByVal idCliente As Integer, ByVal idSucursal As Integer) As PrecioInfo
        Dim Svc As New ArticuloService(sessionID, Me.Connection, Me.Transaction)
        Return Svc.GetPrecio(idArticuloStock, idCliente, idSucursal)
    End Function

    Public Function GetPrecio(ByVal sessionID As Guid, ByVal idArticuloStock As Integer, ByVal idCliente As Integer, ByVal idSucursal As Integer, ByVal precioFijo As Decimal) As PrecioInfo
        Dim Svc As New ArticuloService(sessionID, Me.Connection, Me.Transaction)
        Return Svc.GetPrecio(idArticuloStock, idCliente, idSucursal, precioFijo)
    End Function

#End Region

End Class