Partial Class MeseroFacade
    Public Function LoadDataButtons(ByVal sessionID As GUID, ByVal idSucursal As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New MeseroService(sessionID, Connection, Transaction)
            dtList = Svc.LoadDataButtons(idSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

End Class

Partial Class MeseroService
    Public Function LoadDataButtons(ByVal idSucursal As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Restaurant", "fxMeserosDataButtons", Connection, Transaction)
            fxList.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            Dim dtList As DataTable = fxList.GetTable("Meseros")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Meseros.", ex)
        End Try
    End Function

End Class

