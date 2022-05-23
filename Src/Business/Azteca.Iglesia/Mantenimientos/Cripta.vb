Partial Public Class CriptaService
    Public Function GetCriptas() As DataTable
        Try
            Dim fxList As New FunctionSQL("Church", "fxCriptas", Connection, Transaction)
            fxList.Parameters.Add("@IdFechaIni", DbType.DateTime).Value = DateTime.Today
            fxList.Parameters.Add("@IdFechaFin", DbType.DateTime).Value = DateTime.Today
            Dim dtList As DataTable = fxList.GetTable("Criptas")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de criptas.", ex)
        End Try
    End Function
End Class

Partial Public Class CriptaFacade
    Public Function GetCriptas(ByVal sessionID As Guid) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CriptaService(sessionID, Connection, Transaction)
            dtList = Svc.GetCriptas()
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function
End Class
