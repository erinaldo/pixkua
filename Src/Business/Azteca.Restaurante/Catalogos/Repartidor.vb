Partial Class RepartidorService

    Public Function LoadList(ByVal idSucursal As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Restaurant", "fxRepartidoresCBO", Connection, Transaction)
            fxList.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            Dim dtList As DataTable = fxList.GetTable("Repartidores")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Repartidores.", ex)
        End Try
    End Function


End Class

Partial Class RepartidorFacade
    Public Function LoadList(ByVal sessionID As Guid, ByVal idSucursal As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New RepartidorService(sessionID, Connection, Transaction)
            dtList = Svc.LoadList(idSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

End Class