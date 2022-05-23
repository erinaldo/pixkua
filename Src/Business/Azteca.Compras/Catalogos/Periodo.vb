Partial Class PeriodoFacade

    Public Function LoadList(ByVal sessionID As Guid, ByVal idEmpresa As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtReturn As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PeriodoService(sessionID, Connection)
            dtReturn = Svc.LoadList(idEmpresa)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtReturn
    End Function


    Public Sub Cerrar(ByVal sessionID As Guid, ByVal idPeriodo As Integer)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PeriodoService(sessionID, Connection)
            Svc.Cerrar(idPeriodo)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub

    Public Sub Abrir(ByVal sessionID As Guid, ByVal idPeriodo As Integer)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PeriodoService(sessionID, Connection)
            Svc.Abrir(idPeriodo)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub

End Class

Partial Class PeriodoService
    Public Function LoadList(ByVal idEmpresa As Integer) As DataTable
        Dim dt As New DataTable
        Try
            Dim fx As New FunctionSQL("Purchasing", "fxPeriodosCBO", Connection, Transaction)
            fx.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            fx.FillDataTable(dt)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Periodos.", ex)
        End Try
        Return dt
    End Function

    Public Sub Abrir(ByVal idPeriodo As Integer)
        Try
            Dim sp As New StoredProcedure("Purchasing", "PeriodosAbrir", Me.Connection, Me.Transaction)
            sp.Parameters.Add("@IdPeriodo", DbType.Int32).Value = idPeriodo
            sp.Execute()
        Catch ex As Exception
            Throw New Exception("Problemas al intentar abrir el Periodo", ex)
        End Try
    End Sub

    Public Sub Cerrar(ByVal idPeriodo As Integer)
        Try
            Dim sp As New StoredProcedure("Purchasing", "PeriodosCerrar", Me.Connection, Me.Transaction)
            sp.Parameters.Add("@IdPeriodo", DbType.Int32).Value = idPeriodo
            sp.Execute()
        Catch ex As Exception
            Throw New Exception("Problemas al intentar cerrar el periodo", ex)
        End Try
    End Sub

End Class