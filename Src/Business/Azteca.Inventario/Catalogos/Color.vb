Partial Class ColorService

    Public Function LoadList(idEmpresa As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Inventory", "fxColoresCBO", Connection, Transaction)
            fxList.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            Dim dtList As DataTable = fxList.GetTable()
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de colores.", ex)
        End Try
    End Function

End Class



Partial Class ColorFacade

    Public Function LoadList(sessionID As Guid, idEmpresa As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ColorService(sessionID, Connection, Transaction)
            dtList = Svc.LoadList(idEmpresa)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

End Class