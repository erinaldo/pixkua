Partial Class CajaService

    Public Function ChequerasList(ByVal idCaja As Integer) As DataTable
        Dim dt As New DataTable
        Try
            Dim fx As New FunctionSQL("Treasury", "fxChequerasCBO", Connection, Transaction)
            fx.Parameters.Add("@IdCaja", DbType.Int32).Value = idCaja
            fx.FillDataTable(dt)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Chequeras.", ex)
        End Try
        Return dt
    End Function

    Public Function List(ByVal idEmpresa As Integer) As ConfiguracionDS.CajasDataTable
        Dim dt As New ConfiguracionDS.CajasDataTable
        Try
            Dim fx As New FunctionSQL("Treasury", "fxCajasListSEL", Connection, Transaction)
            fx.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            fx.FillDataTable(dt)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Cajas.", ex)
        End Try
        Return dt
    End Function

    Public Function LoadList(ByVal IdCaja As Integer) As DataTable
        Dim dt As New DataTable
        Try
            Dim fx As New FunctionSQL("Treasury", "fxCajasCBO", Connection, Transaction)
            fx.Parameters.Add("@IdCaja", DbType.Int32).Value = IdCaja
            fx.FillDataTable(dt)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Cajas.", ex)
        End Try
        Return dt
    End Function

    Public Function Accesos(ByVal idUsuario As Integer) As DataTable
        Dim dt As New DataTable
        Try
            Dim fx As New FunctionSQL("Treasury", "fxCajasAccesos", Connection, Transaction)
            fx.Parameters.Add("@IdUsuario", DbType.Int32).Value = idUsuario
            fx.FillDataTable(dt)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Cajas.", ex)
        End Try
        Return dt
    End Function

    Public Sub AccesosSave(IdCaja As Integer, AccesosTable As DataTable)
        Try
            'Definir comando de actualización 
            Dim cmdInsert As New Azteca.Data.DbCommand("Treasury.CajasAccesosUPD", Connection, Transaction)
            cmdInsert.CommandType = CommandType.StoredProcedure
            cmdInsert.Parameters.Add("@IdCaja", DbType.Int32).Value = IdCaja
            cmdInsert.Parameters.Add("@IdUsuario", DbType.Int32, "IdUsuario")

            Dim cmdDelete As New Azteca.Data.DbCommand("Treasury.CajasAccesosDEL", Connection, Transaction)
            cmdDelete.Parameters.Add("@IdCaja", DbType.Int32).Value = IdCaja
            cmdDelete.Parameters.Add("@IdUsuario", DbType.Int32, "IdUsuario")
            cmdDelete.CommandType = CommandType.StoredProcedure

            'Actualizar 
            Dim da As New Azteca.Data.DataAdapter()
            da.UpdateCommand = cmdInsert
            da.InsertCommand = cmdInsert
            da.DeleteCommand = cmdDelete
            da.Update(AccesosTable)
        Catch concurrencyEx As System.Data.DBConcurrencyException
        Catch ex As Exception
            Throw New BusinessException("Error al guardar la lista de Accesos a Caja.", ex)
        End Try
    End Sub

End Class

Partial Class CajaFacade

    Public Function ChequerasList(ByVal sessionID As Guid, ByVal IdCaja As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtProveedores As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CajaService(sessionID, Connection)
            dtProveedores = Svc.ChequerasList(IdCaja)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtProveedores
    End Function


    Public Function List(ByVal sessionID As Guid, ByVal idEmpresa As Integer) As ConfiguracionDS.CajasDataTable
        ValidateSession(sessionID)
        Dim dtProveedores As ConfiguracionDS.CajasDataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CajaService(sessionID, Connection)
            dtProveedores = Svc.List(idEmpresa)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtProveedores
    End Function

    Public Function LoadList(ByVal sessionID As Guid, ByVal idUsuario As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtProveedores As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CajaService(sessionID, Connection)
            dtProveedores = Svc.LoadList(idUsuario)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtProveedores
    End Function

    Public Function Accesos(ByVal sessionID As Guid, ByVal idCaja As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtProveedores As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CajaService(sessionID, Connection)
            dtProveedores = Svc.Accesos(idCaja)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtProveedores
    End Function

    Public Sub AccesosSave(sessionID As Guid, IdCaja As Integer, AccesosTable As DataTable)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CajaService(sessionID, Connection)
            Svc.AccesosSave(IdCaja, AccesosTable)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub

End Class