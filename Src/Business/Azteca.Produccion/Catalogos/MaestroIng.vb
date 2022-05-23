Partial Class MaestroIngService

    Public Sub SaveEnsambleOT(ByVal idOrdenTrabajo As Integer, ByVal EnsambleRow As OrdenesTrabajoDS.EnsamblesRow)
        Try
            Dim cmdInsert As New StoredProcedure("Production", "OrdenesTrabajoEnsamblesUPD", Connection, Transaction)
            cmdInsert.Parameters.Add("@IdOrdenTrabajo", DbType.Int32).Value = idOrdenTrabajo
            cmdInsert.Parameters.Add("@IdEnsamble", DbType.Int32).Value = EnsambleRow.IdEnsamble
            cmdInsert.Parameters.Add("@Orden", DbType.Int16).Value = EnsambleRow.Orden
            cmdInsert.Execute()
        Catch ex As Exception
            Throw New BusinessException("Error al asignar el ensamble a la OT.", ex)
        End Try
    End Sub

    Public Function LoadEnsamblesMG(ByVal idMaestroIng As Integer) As MaestrosIngDS.EnsamblesDataTable
        Dim dt As New MaestrosIngDS.EnsamblesDataTable
        Try
            Dim fx As New FunctionSQL("Production", "fxMaestrosIngEnsamblesSEL", Connection, Transaction)
            fx.Parameters.Add("@IdMaestroIng", DbType.Int32).Value = idMaestroIng
            fx.FillDataTable(dt)
            Return dt
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de ensambles.", ex)
        End Try
    End Function

    Public Function LoadInsumosMG(ByVal idMaestroIng As Integer, ByVal idEnsamble As Integer) As MaestrosIngDS.InsumosDataTable
        Dim dt As New MaestrosIngDS.InsumosDataTable()
        Try
            Dim fx As New FunctionSQL("Production", "fxMaestrosIngInsumosSEL", Connection, Transaction)
            fx.Parameters.Add("@IdMaestroIng", DbType.Int32).Value = idMaestroIng
            fx.Parameters.Add("@IdEnsamble", DbType.Int32).Value = idEnsamble
            fx.FillDataTable(dt)
            Return dt
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de insumos.", ex)
        End Try
    End Function

End Class

Partial Class MaestroIngFacade

    Public Sub SaveEnsambleOT(ByVal sessionID As Guid, ByVal idOrdenTrabajo As Integer, ByVal EnsambleRow As OrdenesTrabajoDS.EnsamblesRow)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New OrdenTrabajoService(sessionID, Connection, Transaction)
                Svc.SaveEnsambleOT(idOrdenTrabajo, EnsambleRow)
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

    Public Function LoadEnsamblesMG(ByVal sessionID As Guid, ByVal idMaestroIng As Integer) As MaestrosIngDS.EnsamblesDataTable

        ValidateSession(sessionID)
        Dim dtList As New MaestrosIngDS.EnsamblesDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New MaestroIngService(sessionID, Connection, Transaction)
            dtList = Svc.LoadEnsamblesMG(idMaestroIng)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function LoadInsumosMG(ByVal sessionID As Guid, ByVal idMaestroIng As Integer, ByVal idEnsamble As Integer) As MaestrosIngDS.InsumosDataTable

        ValidateSession(sessionID)
        Dim dtList As New MaestrosIngDS.InsumosDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New MaestroIngService(sessionID, Connection, Transaction)
            dtList = Svc.LoadInsumosMG(idMaestroIng, idEnsamble)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

End Class


