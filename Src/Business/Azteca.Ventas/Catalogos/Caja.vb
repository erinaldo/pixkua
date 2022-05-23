Partial Class CajaService

#Region "General"

    Public Function LoadList(ByVal IdSucursal As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Sales", "fxCajasCBO", Connection, Transaction)
            fxList.Parameters.Add("@IdSucursal", DbType.Int32).Value = IdSucursal
            Dim dtList As DataTable = fxList.GetTable("Cajas")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Cajas.", ex)
        End Try
    End Function

#End Region

#Region "Cortes"

    Public Function GetCorteActual(ByVal idCaja As Integer) As Guid
        Try
            Dim fxCorte As New FunctionSQL("Sales", "fxCorteActual", Connection, Transaction)
            fxCorte.Parameters.Add("@IdCaja", DbType.Int32).Value = idCaja
            Dim IdCorte As Guid = CType(fxCorte.GetScalar, Guid)
            Return IdCorte
        Catch ex As Exception
            Throw New BusinessException("Error al obtener el corte actual de la caja.", ex)
        End Try
    End Function

    Public Function LoadCorteDetalle(ByVal idCorte As Guid) As CajaDS.CorteDetalleDataTable
        Dim dtList As New CajaDS.CorteDetalleDataTable()
        Try
            Dim fxList As New FunctionSQL("Sales", "fxCorteDetailRPT", Connection, Transaction)
            fxList.Parameters.Add("@IdCorte", DbType.Guid).Value = idCorte
            fxList.FillDataTable(dtList)
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el corte.", ex)
        End Try
    End Function

    Public Function LoadCortes(ByVal IdSucursal As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Sales", "fxCajasCortesLST", Connection, Transaction)
            fxList.Parameters.Add("@IdSucursal", DbType.Int32).Value = IdSucursal
            Dim dtList As DataTable = fxList.GetTable("Cajas")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de cortes.", ex)
        End Try
    End Function

    Public Function LoadCortes(ByVal IdCaja As Integer, ByVal fechaIni As Date, ByVal fechaFin As Date) As DataTable
        Try
            Dim fxList As New FunctionSQL("Sales", "fxCortesLST", Connection, Transaction)
            fxList.Parameters.Add("@IdCaja", DbType.Int32).Value = IdCaja
            fxList.Parameters.Add("@FechaIni", DbType.DateTime).Value = fechaIni.ToShortDateString
            fxList.Parameters.Add("@FechaFin", DbType.DateTime).Value = fechaFin.ToShortDateString
            Dim dtList As DataTable = fxList.GetTable("Cortes")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Cordes de la caja seleccionada.", ex)
        End Try
    End Function

    Public Function LoadCortes(ByVal fechaIni As Date, ByVal fechaFin As Date, IdSucursal As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Sales", "fxCortesByIdSucural", Connection, Transaction)
            fxList.Parameters.Add("@IdSucursal", DbType.Int32).Value = IdSucursal
            fxList.Parameters.Add("@FechaIni", DbType.DateTime).Value = fechaIni.ToShortDateString
            fxList.Parameters.Add("@FechaFin", DbType.DateTime).Value = fechaFin.ToShortDateString
            Dim dtList As DataTable = fxList.GetTable("Cortes")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Cortes de la sucursal.", ex)
        End Try
    End Function

    Public Sub Abrir(ByVal idCaja As Integer, ByVal idCajero As Integer, ByVal idTurno As Integer)
        Try
            Dim sp As New StoredProcedure("Sales", "CorteAbrir", Connection, Transaction)
            sp.Parameters.Add("@IdCaja", DbType.Int32).Value = idCaja
            sp.Parameters.Add("@Idcajero", DbType.Int32).Value = idCajero
            sp.Parameters.Add("@IdTurno", DbType.Int32).Value = idTurno
            sp.Execute()

        Catch exCustom As CustomErrorException
            Throw exCustom
        Catch ex As Exception
            Throw New BusinessException("Error al abrir la caja.", ex)
        End Try
    End Sub

    Public Sub Cerrar(ByVal idCorte As Guid)
        Try
            'Cargar información del corte
            Dim Info As CorteInfo = LoadCorteInfo(idCorte)
            'Cargar información de la caja
            Dim Caja As New CajaInfo(SessionID)
            Dim CajaSvc As New CajaService(SessionID, Connection, Transaction)
            CajaSvc.GetDetail(Info.IdCaja, Caja, False)
            'Verificar si la caja tiene configurada la factura global al hacer corte
            If Caja.GenerarFacturaGlobal Then
                Dim VentaSvc As New VentaService(SessionID, Connection, Transaction)
                VentaSvc.GenerarFacturaGlobal(idCorte)
            End If
            Dim sp As New StoredProcedure("Sales", "CorteCerrar", Connection, Transaction)
            sp.Parameters.Add("@IdCorte", DbType.Guid).Value = idCorte
            sp.Execute()
        Catch exCustom As CustomErrorException
            Throw exCustom
        Catch ex As Exception
            Throw New BusinessException("Error al cerrar la caja.", ex)
        End Try
    End Sub

    Public Function LoadCortePrintInfo(ByVal IdCorte As Guid) As InformesDS.CorteCajaDataTable
        Dim dtList As New InformesDS.CorteCajaDataTable
        Try
            Dim fxList As New FunctionSQL("Sales", "fxCorteRPT", Connection, Transaction)
            fxList.Parameters.Add("@IdCorte", DbType.Guid).Value = IdCorte
            fxList.FillDataTable(dtList)
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar los datos del informe de corte.", ex)
        End Try
    End Function

    Public Function LoadCorteInfo(idCorte As Guid) As CorteInfo
        Dim Info As CorteInfo = New CorteInfo()
        Try
            Dim fxInfo As New FunctionSQL("Sales", "fxCorteSEL", Connection, Transaction)
            fxInfo.Parameters.Add("@IdCorte", DbType.Guid).Value = idCorte
            Dim dtInfo As DataTable = fxInfo.GetTable("Corte")
            If dtInfo.Rows.Count > 0 Then
                Dim dr As DataRow = dtInfo.Rows(0)
                With Info
                    .IdCaja = CInt(dr("IdCaja"))
                    .IdCajero = CInt(dr("IdCajero"))
                    .FechaApertura = CDate(dr("FechaApertura"))
                    If dr("FechaCierre") Is DBNull.Value Then
                        .FechaCierre = New Date(2000, 1, 1)
                        .Cerrado = False
                    Else
                        .FechaCierre = CDate(dr("FechaCierre"))
                        .Cerrado = True
                    End If
                End With
            Else
                Throw New BusinessException("No se encontró el corte: " & idCorte.ToString())
            End If
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la información del corte de caja: " & idCorte.ToString(), ex)
        End Try
        Return Info
    End Function


#End Region

End Class


Partial Class CajaFacade

#Region "General"

    Public Function LoadList(ByVal sessionID As Guid, ByVal IdSucursal As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CajaService(sessionID, Connection, Transaction)
            dtList = Svc.LoadList(IdSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

#End Region

#Region "Cortes"

    Public Function LoadCorteInfo(sessionID As Guid, idCorte As Guid) As CorteInfo
        ValidateSession(sessionID)
        Dim Info As CorteInfo = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CajaService(sessionID, Connection, Transaction)
            Info = Svc.LoadCorteInfo(idCorte)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Info
    End Function


    Public Function LoadCorteDetalle(ByVal sessionID As Guid, ByVal idCorte As Guid) As CajaDS.CorteDetalleDataTable
        ValidateSession(sessionID)
        Dim dtList As CajaDS.CorteDetalleDataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CajaService(sessionID, Connection, Transaction)
            dtList = Svc.LoadCorteDetalle(idCorte)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function


    Public Function LoadCortes(ByVal sessionID As Guid, ByVal idSucursal As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CajaService(sessionID, Connection, Transaction)
            dtList = Svc.LoadCortes(idSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function LoadCortes(ByVal sessionID As Guid, ByVal idCaja As Integer, ByVal fechaIni As Date, ByVal fechaFin As Date) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CajaService(sessionID, Connection, Transaction)
            dtList = Svc.LoadCortes(idCaja, fechaIni, fechaFin)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function LoadCortes(ByVal sessionID As Guid, ByVal fechaIni As Date, ByVal fechaFin As Date, ByVal idSucursal As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CajaService(sessionID, Connection, Transaction)
            dtList = Svc.LoadCortes(fechaIni, fechaFin, idSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Sub Abrir(ByVal sessionID As Guid, ByVal idCaja As Integer, ByVal idCajero As Integer, ByVal idTurno As Integer)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New CajaService(sessionID, Connection, Transaction)
                Svc.Abrir(idCaja, idCajero, idTurno)
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

    Public Sub Cerrar(ByVal sessionID As Guid, ByVal idCorte As Guid)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New CajaService(sessionID, Connection, Transaction)
                Svc.Cerrar(idCorte)
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

    Public Function LoadCortePrintInfo(ByVal sessionID As Guid, ByVal idCorte As Guid) As InformesDS.CorteCajaDataTable
        ValidateSession(sessionID)
        Dim dtList As InformesDS.CorteCajaDataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CajaService(sessionID, Connection, Transaction)
            dtList = Svc.LoadCortePrintInfo(idCorte)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

#End Region

End Class
