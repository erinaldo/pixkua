Imports Azteca.Kernel

Partial Class AreaService

#Region "General"

    Public Function GetDetailFromCache(ByVal idArea As Integer) As AreaInfo
        Dim CacheKey As String = "Area" & idArea.ToString
        Dim Area As New AreaInfo(sessionID)
        If Cache.Contains(CacheKey) Then
            Area = CType(Cache.Item(CacheKey), AreaInfo)
        Else
            Dim AreaSvc As New AreaService(sessionID, Connection, Transaction)
            AreaSvc.GetDetail(idArea, Area, False)
            Cache.Add(CacheKey, Area, TimeSpan.FromDays(1))
        End If
        Return Area
    End Function

    Public Function LoadList(ByVal idSucursal As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Inventory", "fxAreasCBO", Connection, Transaction)
            fxList.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            Dim dtList As DataTable = fxList.GetTable("Areas")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de áreas.", ex)
        End Try
    End Function

    Public Function LoadListByUsuario(ByVal idUsuario As Integer, ByVal IdSucursal As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Inventory", "fxAreasByUsuarioSEL", Connection, Transaction)
            fxList.Parameters.Add("@IdUsuario", DbType.Int32).Value = idUsuario
            fxList.Parameters.Add("@IdSucursal", DbType.Int32).Value = IdSucursal
            Dim dtList As DataTable = fxList.GetTable("Areas")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de áreas.", ex)
        End Try
    End Function

    Public Function LoadAlmacenes(ByVal idArea As Integer) As AreasDS.AlmacenesDataTable
        Try
            Dim fxAlmacenes As New FunctionSQL("Inventory", "fxAreaAlmacenesSEL", Connection, Transaction)
            fxAlmacenes.Parameters.Add("@IdArea", DbType.Int32).Value = idArea
            Dim Almacenes As New AreasDS.AlmacenesDataTable
            fxAlmacenes.FillDataTable(Almacenes)
            Return Almacenes
        Catch ex As Exception
            Throw New BusinessException("Error al cargar los almacenes del área " & idArea.ToString, ex)
        End Try
    End Function

#End Region

#Region "Cortes"

    Public Function LoadCorte(ByVal idCorte As Guid) As CorteInfo
        Dim Corte As New CorteInfo
        Try
            Dim fxCorte As New FunctionSQL("Inventory", "fxCorteSEL", Connection, Transaction)
            fxCorte.Parameters.Add("@IdCorte", DbType.String).Value = idCorte.ToString
            Dim dtCorte As DataTable = fxCorte.GetTable("Corte")
            If dtCorte.Rows.Count > 0 Then
                Dim drCorte As DataRow = dtCorte.Rows(0)
                With Corte
                    ._IdArea = CInt(drCorte("IdArea"))
                    ._IdTurno = CInt(drCorte("IdTurno"))
                    ._FechaApertura = CDate(drCorte("HoraApertura"))
                    If drCorte("HoraCierre") Is DBNull.Value Then
                        ._Cerrado = False
                    Else
                        ._Cerrado = True
                        ._FechaCierre = CDate(drCorte("HoraCierre"))
                    End If
                    ._IdUsuarioApertura = CInt(drCorte("IdUsuarioApertura"))
                    ._IdUsuarioCierre = CInt(drCorte("IdUsuarioCierre"))
                    ._Area = drCorte("Area").ToString
                    ._Turno = drCorte("Turno").ToString
                End With
            End If
            Return Corte
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la información del corte de inventario", ex)
        End Try
    End Function

    Public Function LoadCortes(ByVal idSucursal As Integer, ByVal idUsuario As Integer) As DataTable
        Try
            Dim fxCortes As New FunctionSQL("Inventory", "fxCortesSEL", Connection, Transaction)
            fxCortes.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            fxCortes.Parameters.Add("@IdUsuario", DbType.Int32).Value = idUsuario
            Dim dtCortes As New DataTable("Cortes")
            fxCortes.FillDataTable(dtCortes)
            Return dtCortes
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de cortes de inventario.", ex)
        End Try
    End Function

    Public Sub AbrirCorte(ByVal idArea As Integer, ByVal idTurno As Integer)
        Try
            Dim spAbrir As New StoredProcedure("Inventory", "CorteAbrir", Connection, Transaction)
            spAbrir.Parameters.Add("@IdArea", DbType.Int32).Value = idArea
            spAbrir.Parameters.Add("@IdTurno", DbType.Int32).Value = idTurno
            spAbrir.Parameters.Add("@IdUsuario", DbType.Int32).Value = Session.User.Identity
            spAbrir.Execute()
        Catch ex As Exception
            Throw New BusinessException("Error al abrir el turno de inventario.", ex)
        End Try
    End Sub

    Public Sub CerrarCorte(ByVal idCorte As Guid, ByVal ajustarInventario As Boolean)
        Try
            Dim Corte As CorteInfo = LoadCorte(idCorte)
            Dim IdConceptoEntrada As Integer = CInt(Azteca.Kernel.Configuration.ConfigurationManager.SystemConfiguration.GetValue("Configuracion/Inventario/Conceptos", "AjusteEntrada"))
            Dim IdConceptoSalida As Integer = CInt(Azteca.Kernel.Configuration.ConfigurationManager.SystemConfiguration.GetValue("Configuracion/Inventario/Conceptos", "AjusteSalida"))
            '
            If ajustarInventario Then
                Dim Inventario As AreasDS.InventarioFisicoDataTable = CargarInventarioFisico(Corte.IdArea)
                '
                Dim InventarioFisico = From I In Inventario
                                Group By IdAlmacen = I.IdAlmacen, Nombre = I.Almacen Into Articulos = Group

                For Each Almacen In InventarioFisico
                    'Crear un movimiento de entrada y uno de salida donde se acumularán los artículos
                    Dim Entrada As New MovimientoInfo(SessionID)
                    With Entrada
                        .IdAlmacen = Almacen.IdAlmacen
                        .Direccion = TipoMovimiento.Entrada
                        .Fecha = Date.Today
                        .IdConcepto = IdConceptoEntrada
                        .Observaciones = "Entrada por ajuste de inventario físico"
                    End With
                    Dim Salida As New MovimientoInfo(SessionID)
                    With Salida
                        .IdAlmacen = Almacen.IdAlmacen
                        .Direccion = TipoMovimiento.Salida
                        .Fecha = Date.Today
                        .IdConcepto = IdConceptoSalida
                        .Observaciones = "Salida por ajuste de inventario físico"
                    End With
                    'Agregar artículos a cada documento
                    For Each drArticulo As AreasDS.InventarioFisicoRow In Almacen.Articulos
                        If drArticulo.Diferencia <> 0 Then
                            Dim drPartida As DetalleMovimientoDS.DetalleRow
                            If drArticulo.Diferencia > 0 Then
                                drPartida = Entrada.Details.NewDetalleRow
                            Else
                                drPartida = Salida.Details.NewDetalleRow
                            End If
                            With drPartida
                                .IdArticuloStock = drArticulo.IdArticuloStock
                                .Cantidad = Math.Abs(drArticulo.Diferencia)
                                .IdUnidadMedida = drArticulo.IdUnidadMedida
                                .CostoUnitario = drArticulo.CostoPromedio
                            End With
                            If drArticulo.Diferencia > 0 Then
                                Entrada.Details.AddDetalleRow(drPartida)
                            Else
                                Salida.Details.AddDetalleRow(drPartida)
                            End If
                        End If
                    Next
                    'Guardar y aplicar movimientos
                    If Entrada.Details.Count > 0 Then
                        Dim Svc As New MovimientoService(SessionID, Connection, Transaction)
                        Entrada = Svc.Update(Entrada)
                        Svc.ApplyWorkflow(Entrada.Identity, WorkflowSteps.Apply, Date.Today)
                    End If
                    If Salida.Details.Count > 0 Then
                        Dim Svc As New MovimientoService(SessionID, Connection, Transaction)
                        Salida = Svc.Update(Salida)
                        Svc.ApplyWorkflow(Salida.Identity, WorkflowSteps.Apply, Date.Today)
                    End If
                Next
            End If
            '
            Dim spCerrar As New StoredProcedure("Inventory", "CorteCerrar", Connection, Transaction)
            spCerrar.Parameters.Add("@IdCorte", DbType.String).Value = idCorte.ToString
            spCerrar.Parameters.Add("@IdUsuario", DbType.Int32).Value = Session.User.Identity
            spCerrar.Parameters.Add("@PCUpdate", DbType.String).Value = Session.WorkStation
            spCerrar.Execute()
        Catch ex As Exception
            Throw New BusinessException("Error al cerrar el turno de inventario.", ex)
        End Try
    End Sub

#End Region

#Region "Turnos"

    Public Function LoadTurnos(ByVal idArea As Integer) As AreasDS.TurnosDataTable
        Try
            Dim fxTurnos As New FunctionSQL("Inventory", "fxTurnosByAreaSEL", Connection, Transaction)
            fxTurnos.Parameters.Add("@IdArea", DbType.Int32).Value = idArea
            Dim dtTurnos As New AreasDS.TurnosDataTable
            fxTurnos.FillDataTable(dtTurnos)
            Return dtTurnos
        Catch ex As Exception
            Throw New BusinessException("Error al cargar los turnos del área.", ex)
        End Try
    End Function

    Public Sub AsignarTurno(ByVal idArea As Integer, ByVal idTurno As Integer, ByVal secuencia As Integer)
        Try
            Dim spAsignar As New StoredProcedure("Inventory", "TurnosAreasUPD", Connection, Transaction)
            spAsignar.Parameters.Add("@IdArea", DbType.Int32).Value = idArea
            spAsignar.Parameters.Add("@IdTurno", DbType.Int32).Value = idTurno
            spAsignar.Parameters.Add("@Secuencia", DbType.Int32).Value = secuencia
            spAsignar.Execute()
        Catch ex As Exception
            Throw New BusinessException("Error al asignar el turno al área.", ex)
        End Try
    End Sub

    Public Sub QuitarTurno(ByVal idArea As Integer, ByVal idTurno As Integer)
        Try
            Dim spDelete As New StoredProcedure("Inventory", "TurnosAreasDEL", Connection, Transaction)
            spDelete.Parameters.Add("@IdArea", DbType.Int32).Value = idArea
            spDelete.Parameters.Add("@IdTurno", DbType.Int32).Value = idTurno
            spDelete.Execute()
        Catch ex As Exception
            Throw New BusinessException("Error al quitar el turno del área.", ex)
        End Try
    End Sub

#End Region

#Region "Accesos"
    Public Function CargarUsuarioAccesos(ByVal idUsuario As Integer) As UsuarioAccesosDS.AreasDataTable
        Try
            Dim fxAreas As New FunctionSQL("Inventory", "fxUsuarioAreasSEL", Connection, Transaction)
            fxAreas.Parameters.Add("@IdUsuario", DbType.Int32).Value = idUsuario
            Dim dtAreas As New UsuarioAccesosDS.AreasDataTable
            fxAreas.FillDataTable(dtAreas)
            Return dtAreas
        Catch ex As Exception
            Throw New BusinessException("Error al cargar los accesos del usuario: " & idUsuario.ToString, ex)
        End Try
    End Function

    Public Sub GuardarUsuarioAccesos(ByVal idUsuario As Integer, ByVal areas As UsuarioAccesosDS.AreasDataTable)
        Try
            Dim comUpdate As New DbCommand("Inventory.UsuarioAreasUPD", Connection, Transaction)
            comUpdate.CommandType = CommandType.StoredProcedure
            comUpdate.Parameters.Add("@IdArea", DbType.Int32, "IdArea")
            comUpdate.Parameters.Add("@IdUsuario", DbType.Int32).Value = idUsuario
            comUpdate.Parameters.Add("@Selected", DbType.Boolean, "Selected")
            '
            Dim da As New DataAdapter()
            da.UpdateCommand = comUpdate
            da.Update(areas)
        Catch concurrencyEx As DBConcurrencyException

        Catch ex As Exception
            Throw New BusinessException("Error al guardar los accesos del usuario: " & idUsuario.ToString, ex)
        End Try
    End Sub

#End Region

#Region "Inventario Fisico"

    Public Function CargarInventarioFisico(ByVal idArea As Integer) As AreasDS.InventarioFisicoDataTable
        Try
            Dim fxInventario As New FunctionSQL("Inventory", "fxInventarioFisicoSEL", Connection, Transaction)
            fxInventario.Parameters.Add("@IdArea", DbType.Int32).Value = idArea
            Dim Inventario As New AreasDS.InventarioFisicoDataTable
            fxInventario.FillDataTable(Inventario)
            'Calcular la diferencia y los empaquetados
            For Each dr As AreasDS.InventarioFisicoRow In Inventario
                dr.Diferencia = dr.Fisico - dr.Teorico
                Dim UnidadSvc As New UnidadMedidaService(SessionID, Connection, Transaction)
                Dim UnidadInf As UnidadMedidaInfo = UnidadSvc.GetDetailFromCache(dr.IdUnidadMedida)
                'Si la unidad de medida son cajas, separar cajas y unidades
                If UnidadInf.IdTipoUnidad = 1 Then
                    Dim Teorico As New Empaquetado(dr.Teorico, UnidadInf.Factor)
                    Dim Fisico As New Empaquetado(dr.Fisico, UnidadInf.Factor)
                    Dim Diferencia As New Empaquetado(dr.Diferencia, UnidadInf.Factor)
                    '
                    dr.CantidadTeorico = Teorico.Cajas
                    dr.UnidadesTeorico = Teorico.Unidades
                    dr.CantidadFisico = Fisico.Cajas
                    dr.UnidadesFisico = Fisico.Unidades
                    dr.CantidadDiferencia = Diferencia.Cajas
                    dr.UnidadesDiferencia = Diferencia.Unidades
                Else
                    dr.CantidadTeorico = dr.Teorico
                    dr.CantidadFisico = dr.Fisico                    
                    dr.CantidadDiferencia = dr.Diferencia                    
                End If
            Next
            Inventario.AcceptChanges()
            Return Inventario
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el inventario físico del área (" & idArea.ToString & ")", ex)
        End Try
    End Function

    Public Sub GuardarInventarioFisico(ByVal idCorte As Guid, ByVal inventarioFisico As AreasDS.InventarioFisicoDataTable)
        Try
            'Validar que el corte sea un corte válido
            If idCorte = Guid.Empty Then Throw New BusinessException("No se puede guardar el inventario físico por que el área no tiene un corte abierto.")
            Dim Corte As CorteInfo = LoadCorte(idCorte)
            If Corte.Cerrado Then Throw New BusinessException("No se puede guardar el inventario físico en éste corte por que ya está cerrado.")
            '
            For Each dr As AreasDS.InventarioFisicoRow In inventarioFisico
                'Si se trata de un artículo con unidad de medida en cajas o paquetes, calcular cantidad en formato decimal
                If (dr.UnidadesTeorico > 0 Or dr.UnidadesFisico > 0) Then
                    Dim Teorico As New Empaquetado(CInt(dr.CantidadTeorico), CInt(dr.UnidadesTeorico), dr.Factor)
                    Dim Fisico As New Empaquetado(CInt(dr.CantidadFisico), CInt(dr.UnidadesFisico), dr.Factor)
                    dr.Teorico = Teorico.ToDecimal
                    dr.Fisico = Fisico.ToDecimal
                Else
                    dr.Teorico = dr.CantidadTeorico
                    dr.Fisico = dr.CantidadFisico
                End If
                'Actualizar registro en la base de datos
                Dim spUpdate As New StoredProcedure("Inventory", "InventarioFisicoUPD", Connection, Transaction)
                With spUpdate
                    .Parameters.Add("@IdCorte", DbType.Guid).Value = idCorte
                    .Parameters.Add("@IdAlmacen", DbType.Int32).Value = dr.IdAlmacen
                    .Parameters.Add("@IdArticuloStock", DbType.Int32).Value = dr.IdArticuloStock
                    .Parameters.Add("@Teorico", DbType.Decimal).Value = dr.Teorico
                    .Parameters.Add("@Fisico", DbType.Decimal).Value = dr.Fisico
                    .Execute()
                End With
            Next
        Catch ex As Exception
            Throw New BusinessException("Error al guardar la captura de inventario físico.", ex)
        End Try
    End Sub

#End Region

End Class


Partial Class AreaFacade

#Region "General"

    Public Function LoadList(ByVal sessionID As GUID, ByVal idSucursal As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New AreaService(sessionID, Connection, Transaction)
            dtList = Svc.LoadList(idSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function LoadListByUsuario(ByVal sessionID As GUID, ByVal idUsuario As Integer, ByVal IdSucursal As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New AreaService(sessionID, Connection, Transaction)
            dtList = Svc.LoadListByUsuario(idUsuario, IdSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function LoadListByUsuario(ByVal sessionID As GUID, ByVal idUsuario As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New AreaService(sessionID, Connection, Transaction)
            dtList = Svc.LoadListByUsuario(idUsuario, 0)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function LoadAlmacenes(ByVal sessionID As GUID, ByVal idArea As Integer) As AreasDS.AlmacenesDataTable
        ValidateSession(sessionID)
        Dim Almacenes As New AreasDS.AlmacenesDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New AreaService(sessionID, Connection, Transaction)
            Almacenes = Svc.LoadAlmacenes(idArea)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Almacenes
    End Function

#End Region

#Region "Cortes"

    Public Function LoadCorte(ByVal sessionID As Guid, ByVal idCorte As Guid) As CorteInfo
        ValidateSession(sessionID)
        Dim Corte As New CorteInfo
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New AreaService(sessionID, Connection, Transaction)
            Corte = Svc.LoadCorte(idCorte)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Corte
    End Function

    Public Function LoadCortes(ByVal sessionID As Guid, ByVal idSucursal As Integer, ByVal idUsuario As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtCortes As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New AreaService(sessionID, Connection, Transaction)
            dtCortes = Svc.LoadCortes(idSucursal, idUsuario)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtCortes
    End Function


    Public Sub AbrirCorte(ByVal sessionID As Guid, ByVal idArea As Integer, ByVal idTurno As Integer)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New AreaService(sessionID, Connection, Transaction)
                Svc.AbrirCorte(idArea, idTurno)
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

    Public Sub CerrarTurno(ByVal sessionID As Guid, ByVal idCorte As Guid, ByVal ajustarInventario As Boolean)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New AreaService(sessionID, Connection, Transaction)
                Svc.CerrarCorte(idCorte, ajustarInventario)
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

#Region "Turnos"

    Public Function LoadTurnos(ByVal sessionID As Guid, ByVal idArea As Integer) As AreasDS.TurnosDataTable
        ValidateSession(sessionID)
        Dim dtTurnos As New AreasDS.TurnosDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New AreaService(sessionID, Connection, Transaction)
            dtTurnos = Svc.LoadTurnos(idArea)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtTurnos
    End Function

    Public Sub AsignarTurno(ByVal sessionID As Guid, ByVal idArea As Integer, ByVal idTurno As Integer, ByVal secuencia As Integer)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New AreaService(sessionID, Connection, Transaction)
                Svc.AsignarTurno(idArea, idTurno, secuencia)
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

    Public Sub QuitarTurno(ByVal sessionID As Guid, ByVal idArea As Integer, ByVal idTurno As Integer)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New AreaService(sessionID, Connection, Transaction)
                Svc.QuitarTurno(idArea, idTurno)
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

#Region "Accesos"


    Public Function CargarUsuarioAccesos(ByVal sessionID As Guid, ByVal idUsuario As Integer) As UsuarioAccesosDS.AreasDataTable
        ValidateSession(sessionID)
        Dim dtAreas As New UsuarioAccesosDS.AreasDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New AreaService(sessionID, Connection, Transaction)
            dtAreas = Svc.CargarUsuarioAccesos(idUsuario)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtAreas
    End Function

    Public Sub GuardarUsuarioAccesos(ByVal sessionID As Guid, ByVal idUsuario As Integer, ByVal areas As UsuarioAccesosDS.AreasDataTable)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New AreaService(sessionID, Connection, Transaction)
                Svc.GuardarUsuarioAccesos(idUsuario, areas)
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

#Region "Inventario Fisico"

    Public Function CargarInventarioFisico(ByVal sessionID As Guid, ByVal idArea As Integer) As AreasDS.InventarioFisicoDataTable
        ValidateSession(sessionID)
        Dim Inventario As AreasDS.InventarioFisicoDataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New AreaService(sessionID, Connection, Transaction)
            Inventario = Svc.CargarInventarioFisico(idArea)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Inventario
    End Function

    Public Sub GuardarInventarioFisico(ByVal sessionId As Guid, ByVal idCorte As Guid, ByVal inventarioFisico As AreasDS.InventarioFisicoDataTable)
        ValidateSession(sessionId)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New AreaService(sessionId, Connection, Transaction)
                Svc.GuardarInventarioFisico(idCorte, inventarioFisico)
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

End Class