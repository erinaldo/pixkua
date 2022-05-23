Partial Class TallaService

    Public Function LoadList() As DataTable
        Try
            Dim fxList As New FunctionSQL("Inventory", "fxTallasCBO", Connection, Transaction)
            Dim dtList As DataTable = fxList.GetTable("Tallas")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de tallas", ex)
        End Try
    End Function

End Class



Partial Class TallaFacade

    Public Function LoadList(sessionID As Guid) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection()
            Dim Svc As New TallaService(sessionID, Connection)
            dtList = Svc.LoadList()
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

End Class
