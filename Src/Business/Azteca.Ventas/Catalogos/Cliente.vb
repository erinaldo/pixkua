Partial Class ClienteService

#Region "Clasificaciones"

    Public Function CargarClasificaciones(ByVal idCliente As Integer) As DataTable
        Try
            Dim fxClasificaciones As New FunctionSQL("Sales", "fxClasificacionesClienteSEL", Connection, Transaction)
            fxClasificaciones.Parameters.Add("@IdCliente", DbType.Int32).Value = idCliente
            Dim dtClasificaciones As DataTable = fxClasificaciones.GetTable("Clasificaciones")
            Return dtClasificaciones
        Catch ex As Exception
            Throw New BusinessException("Error al cargar las clasificaciones del cliente.", ex)
        End Try
    End Function

    Public Sub GuardarClasificaciones(ByVal idCliente As Integer, ByVal clasificaciones As DataTable)
        Try
            Dim comUpdate As New DbCommand("Sales.ClasificacionesClientesUPD", Connection, Transaction)
            comUpdate.CommandType = CommandType.StoredProcedure
            comUpdate.Parameters.Add("@IdCliente", DbType.Int32).Value = idCliente
            comUpdate.Parameters.Add("@IdClasificacionGrupo", DbType.Int32, "IdGrupo")
            comUpdate.Parameters.Add("@IdClasificacion", DbType.Int32, "IdClasificacion")
            '
            Dim da As New DataAdapter
            da.UpdateCommand = comUpdate
            da.Update(clasificaciones)
        Catch concurrencyEx As DBConcurrencyException

        Catch ex As Exception
            Throw New BusinessException("Error al guardar las clasificaciones del cliente.", ex)
        End Try
    End Sub

#End Region

End Class


Partial Class ClienteFacade
#Region "Clasificaciones"

    Public Function CargarClasificaciones(ByVal sessionID As Guid, ByVal idCliente As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtClasificaciones As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ClienteService(sessionID, Connection, Transaction)
            dtClasificaciones = Svc.CargarClasificaciones(idCliente)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtClasificaciones
    End Function

    Public Sub GuardarClasificaciones(ByVal sessionID As Guid, ByVal idCliente As Integer, ByVal clasificaciones As DataTable)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New ClienteService(sessionID, Connection, Transaction)
                Svc.GuardarClasificaciones(idCliente, clasificaciones)
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