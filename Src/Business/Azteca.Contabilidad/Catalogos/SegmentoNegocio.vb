Partial Class SegmentoNegocioFacade
    Public Function SegmentosNegocioCBO(ByVal sessionID As GUID, ByVal IdEmpresa As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dt As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New SegmentoNegocioService(sessionID, Connection)
            dt = Svc.SegmentosNegocioCBO(IdEmpresa)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dt
    End Function

End Class

Partial Class SegmentoNegocioService
    Public Function SegmentosNegocioCBO(ByVal IdEmpresa As Integer) As DataTable
        Dim dtReturn As New DataTable()
        Try
            Dim fx As New FunctionSQL("Accounting", "fxSegmentosNegocioCBO", Connection, Transaction)
            fx.Parameters.Add("@IdEmpresa", DbType.Int32).Value = IdEmpresa
            dtReturn = fx.GetTable()
        Catch ex As Exception
            Throw New BusinessException("Error al cargar los segmentos de negocio", ex)
        End Try
        Return dtReturn
    End Function

End Class