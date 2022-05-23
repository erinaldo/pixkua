Partial Class MesaFacade
    Public Function LoadDataButtons(ByVal sessionID As GUID, ByVal idCentroConsumo As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New MesaService(sessionID, Connection, Transaction)
            dtList = Svc.LoadDataButtons(idCentroConsumo)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

End Class

Partial Class MesaService
    Public Function LoadDataButtons(ByVal idCentroConsumo As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Restaurant", "fxMesaDataButtons", Connection, Transaction)
            fxList.Parameters.Add("@IdCentroConsumo", DbType.Int32).Value = idCentroConsumo
            Dim dtList As DataTable = fxList.GetTable("Meseros")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Mesas.", ex)
        End Try
    End Function

End Class