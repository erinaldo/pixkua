Partial Class MovimientoService

    Public Sub SetEstatus(ByVal idMovimientoTit As String, ByVal idStatus As Integer)
        Try
            Dim spStatus As New StoredProcedure("Inventory", "MovimientoSetStatus", Connection, Transaction)
            spStatus.Parameters.Add("@IdMovimientoTit", DbType.String).Value = idMovimientoTit
            spStatus.Parameters.Add("@IdStatus", DbType.Int32).Value = idStatus
            spStatus.Execute()
        Catch ex As Exception
            Throw New BusinessException("Error al establecer el estatus del movimiento.", ex)
        End Try
    End Sub

    Public Function GetInforme(ByVal idMovimiento As String) As DataTable
        Try
            Dim fxInforme As New FunctionSQL("Inventory", "fxMovimientoRPT", Connection, Transaction)
            fxInforme.Parameters.Add("@IdMovimientoTit", DbType.String).Value = idMovimiento
            Dim dtInforme As DataTable = fxInforme.GetTable("Informe")
            Return dtInforme
        Catch ex As Exception
            Throw New BusinessException("Error al obtener la información del movimiento de almacén: " & idMovimiento, ex)
        End Try
    End Function

End Class




Partial Class MovimientoFacade

    Public Function GetInforme(ByVal sessionID As Guid, ByVal idMovimiento As String) As DataTable
        ValidateSession(sessionID)
        Dim dtInforme As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New MovimientoService(sessionID, Connection)
            dtInforme = Svc.GetInforme(idMovimiento)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtInforme
    End Function

End Class