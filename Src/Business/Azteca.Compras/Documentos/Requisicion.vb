Imports Azteca.Business.Inventario

Partial Class RequisicionService

    Public Function LoadList(ByVal FechaIni As Date, ByVal FechaFin As Date, ByVal IdUsuario As Integer, ByVal IdSucursal As Integer) As DataTable
        Dim dtList As DataTable = Nothing
        Try
            Dim fxList As New FunctionSQL("Purchasing", "fxRequisicionesList", Connection, Transaction)
            fxList.Parameters.Add("@FechaIni", DbType.DateTime).Value = FechaIni
            fxList.Parameters.Add("@FechaFin", DbType.DateTime).Value = FechaFin
            fxList.Parameters.Add("@IdUsuario", DbType.Int32).Value = IdUsuario
            fxList.Parameters.Add("@IdSucursal", DbType.Int32).Value = IdSucursal
            dtList = fxList.GetTable
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de requisiciones.", ex)
        End Try
        Return dtList
    End Function

    Public Function TiposList(ByVal IdUsuario As Integer) As DataTable
        Dim dtList As DataTable = Nothing
        Try
            Dim fxList As New FunctionSQL("Purchasing", "fxRequisicionesTiposCBO", Connection, Transaction)
            fxList.Parameters.Add("@IdUsuario", DbType.Int32).Value = IdUsuario
            dtList = fxList.GetTable
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de tipos de requisiciones.", ex)
        End Try
        Return dtList
    End Function

    Public Overloads Sub Update(idSucursal As Integer, idTipoRequisicion As Integer, idDepartamento As Integer, idPresupuesto As Integer, idCentroRecepcion As Integer, requisiciones As RequisicionesDS)
        Try
            'Generar las requisiciones de los artículos
            For Each drArticulo As RequisicionesDS.ArticulosRow In requisiciones.Articulos
                If drArticulo.RowState = DataRowState.Deleted Then Continue For
                Dim Requisicion As New RequisicionInfo(SessionID)
                With Requisicion
                    .Fecha = Date.Today
                    .IdArticuloStock = drArticulo.IdArticuloStock
                    .IdServicio = 0
                    .IdRequisicionTipo = idTipoRequisicion
                    .IdDepartamento = idDepartamento
                    .IdPresupuesto = idPresupuesto
                    .IdCentroRecepcion = idCentroRecepcion
                    .Observaciones = drArticulo.Observaciones
                    If drArticulo.Unidades > 0 Then
                        Dim UnidadSvc As New UnidadMedidaService(SessionID, Connection, Transaction)
                        Dim UnidadInf As UnidadMedidaInfo = UnidadSvc.GetDetailFromCache(drArticulo.IdUnidadMedida)
                        Dim Cantidad As New Empaquetado(CInt(drArticulo.Cantidad), drArticulo.Unidades, UnidadInf.Factor)
                        .Cantidad = Cantidad.ToDecimal
                    Else
                        .Cantidad = drArticulo.Cantidad
                    End If
                    .IdUnidadMedida = drArticulo.IdUnidadMedida
                    .IdCategoriaPresupuestal = drArticulo.IdCategoriaPresupuestal
                    .IdSucursal = idSucursal
                End With
                Dim RequisicionSvc As New RequisicionService(SessionID, Connection, Transaction)
                Requisicion = RequisicionSvc.Update(Requisicion)
            Next

            'Generar las requisiciones de los servicios
            For Each drServicio As RequisicionesDS.ServiciosRow In requisiciones.Servicios
                If drServicio.RowState = DataRowState.Deleted Then Continue For
                Dim Requisicion As New RequisicionInfo(SessionID)
                With Requisicion
                    .Fecha = Date.Today
                    .IdArticuloStock = 0
                    .IdServicio = drServicio.IdServicio
                    .IdRequisicionTipo = idTipoRequisicion
                    .IdDepartamento = idDepartamento
                    .IdPresupuesto = idPresupuesto
                    .IdCentroRecepcion = idCentroRecepcion
                    .Observaciones = drServicio.Observaciones
                    .Cantidad = drServicio.Cantidad
                    .IdUnidadMedida = 0
                    .IdCategoriaPresupuestal = drServicio.IdCategoriaPresupuestal
                    .IdSucursal = idSucursal
                End With
                Dim RequisicionSvc As New RequisicionService(SessionID, Connection, Transaction)
                Requisicion = RequisicionSvc.Update(Requisicion)
            Next
        Catch ex As Exception
            Throw New BusinessException("Error al guardar el lote de requisiciones.", ex)
        End Try
    End Sub

    Public Function PendientesList(idCentral As Integer, fechaInicial As Date, fechaFinal As Date) As GeneradorOrdenesDS.RequisicionesDataTable
        Try
            Dim fxList As New FunctionSQL("Purchasing", "fxRequisicionesPendientes", Connection, Transaction)
            fxList.Parameters.Add("@IdCentralCompras", DbType.Int32).Value = idCentral
            fxList.Parameters.Add("@FechaIni", DbType.DateTime).Value = fechaInicial
            fxList.Parameters.Add("@FechaFin", DbType.Date).Value = fechaFinal
            Dim Requisiciones As New GeneradorOrdenesDS.RequisicionesDataTable
            fxList.FillDataTable(Requisiciones)
            Return Requisiciones
        Catch ex As Exception
            Throw New BusinessException("Error al cargar las requisiciones pendientes", ex)
        End Try
    End Function

End Class



Partial Class RequisicionFacade

    Public Function LoadList(ByVal sessionID As Guid, ByVal FechaIni As Date, ByVal FechaFin As Date, ByVal IdUsuario As Integer, ByVal IdSucursal As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New RequisicionService(sessionID, Connection, Transaction)
            dtList = Svc.LoadList(FechaIni, FechaFin, IdUsuario, IdSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function TiposList(ByVal sessionID As Guid, ByVal IdUsuario As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New RequisicionService(sessionID, Connection, Transaction)
            dtList = Svc.TiposList(IdUsuario)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Overloads Sub Update(sessionID As Guid, idSucursal As Integer, idTipoRequisicion As Integer, idDepartamento As Integer, idPresupuesto As Integer, idCentroRecepcion As Integer, requisiciones As RequisicionesDS)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New RequisicionService(sessionID, Connection, Transaction)
                Svc.Update(idSucursal, idTipoRequisicion, idDepartamento, idPresupuesto, idCentroRecepcion, requisiciones)
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

    Public Function PendientesList(sessionID As Guid, idCentral As Integer, fechaInicial As Date, fechaFinal As Date) As GeneradorOrdenesDS.RequisicionesDataTable
        ValidateSession(sessionID)
        Dim dtList As New GeneradorOrdenesDS.RequisicionesDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New RequisicionService(sessionID, Connection, Transaction)
            dtList = Svc.PendientesList(idCentral, fechaInicial, fechaFinal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function


End Class

