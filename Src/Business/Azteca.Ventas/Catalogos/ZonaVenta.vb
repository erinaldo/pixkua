Partial Class ZonaVentaService

    Public Function LoadList(ByVal idEmpresa As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Sales", "fxZonasVentaCBO", Connection, Transaction)
            fxList.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            Dim dtList As DataTable = fxList.GetTable("ZonasVenta")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de zonas de venta.", ex)
        End Try
    End Function

End Class


Partial Class ZonaVentaFacade

    Public Function LoadList(ByVal sessionID As GUID, ByVal idEmpresa As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ZonaVentaService(sessionID, Connection, Transaction)
            dtList = Svc.LoadList(idEmpresa)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

End Class
