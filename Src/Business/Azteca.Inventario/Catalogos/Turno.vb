Partial Class TurnoService

    Public Function LoadList() As DataTable
        Try
            Dim fxTurnos As New FunctionSQL("Inventory", "fxTurnosCBO", Connection, Transaction)
            Dim dtTurnos As DataTable = fxTurnos.GetTable("Turnos")
            Return dtTurnos
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de turnos.", ex)
        End Try
    End Function

End Class


Partial Class TurnoFacade

    Public Function LoadList(ByVal sessionID As GUID) As DataTable
        ValidateSession(sessionID)
        Dim dtList As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New TurnoService(sessionID, Connection, Transaction)
            dtList = Svc.LoadList
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

End Class