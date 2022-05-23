Partial Class BancoService
    Public Function List(ByVal idEmpresa As Integer) As DataTable
        Dim dt As New DataTable
        Try
            Dim fx As New FunctionSQL("Treasury", "fxBancosListSEL", Connection, Transaction)
            fx.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            fx.FillDataTable(dt)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de bancos.", ex)
        End Try
        Return dt
    End Function

End Class

Partial Class BancoFacade
    Public Function List(ByVal sessionID As Guid, ByVal idEmpresa As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dt As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New BancoService(sessionID, Connection)
            dt = Svc.List(idEmpresa)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dt
    End Function

End Class