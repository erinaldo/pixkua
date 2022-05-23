Partial Class MetodoPagoService

    Public Function LoadList(idEmpresa As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Sales", "fxMetodosPagoCBO", Connection, Transaction)
            fxList.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            Dim dtList As DataTable = fxList.GetTable("MetodosPago")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de métodos de pago.", ex)
        End Try
    End Function

End Class



Partial Class MetodoPagoFacade

    Public Function LoadList(sessionID As Guid, idEmpresa As Integer) As DataTable
        Dim dtList As DataTable = Nothing
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New MetodoPagoService(sessionID, Connection, Transaction)
            dtList = Svc.LoadList(idEmpresa)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

End Class