Partial Class CajeroFacade
    Public Function LoadList(ByVal sessionID As Guid, ByVal IdSucursal As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CajeroService(sessionID, Connection, Transaction)
            dtList = Svc.LoadList(IdSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

   
End Class

Partial Class CajeroService
    Public Function LoadList(ByVal IdSucursal As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Sales", "fxCajerosCBO", Connection, Transaction)
            fxList.Parameters.Add("@IdSucursal", DbType.Int32).Value = IdSucursal
            Dim dtList As DataTable = fxList.GetTable("Cajeros")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Cajeros.", ex)
        End Try
    End Function

    
End Class
