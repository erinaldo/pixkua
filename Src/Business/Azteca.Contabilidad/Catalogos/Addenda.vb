Partial Class AddendaService

    Public Function LoadList() As DataTable
        Try
            Dim fxList As New FunctionSQL("Accounting", "fxCFDAddendasCBO", Connection, Transaction)
            Dim dtList As DataTable = fxList.GetTable("Addendas")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de addendas.", ex)
        End Try
    End Function

End Class


Partial Class AddendaFacade

    Public Function LoadList(ByVal sessionID As Guid) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New AddendaService(sessionID, Connection, Transaction)
            dtList = Svc.LoadList()
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

End Class
