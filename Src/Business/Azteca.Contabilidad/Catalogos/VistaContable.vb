Partial Class VistaContableFacade

    Public Function LoadList(ByVal sessionID As Guid) As DataTable
        Return LoadList(sessionID, 0)
    End Function

    Public Function LoadList(ByVal sessionID As Guid, ByVal IdDocumentoTipo As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dt As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New VistaContableService(sessionID, Connection)
            dt = Svc.LoadList(IdDocumentoTipo)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dt
    End Function

    Public Function ValidaRac(ByVal sessionID As Guid, ByVal IdVistaContableTit As Integer, ByVal IdRacTit As Integer) As String
        ValidateSession(sessionID)
        Dim ret As String = ""
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New VistaContableService(sessionID, Connection)
            ret = Svc.ValidaRac(IdVistaContableTit, IdRacTit)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return ret
    End Function

End Class

Partial Class VistaContableService
    Public Function LoadList(ByVal IdDocumentoTipo As Integer) As DataTable
        Dim dtReturn As New DataTable()
        Try
            Dim fx As New FunctionSQL("Accounting", "fxVistasContablesTitCBO", Connection, Transaction)
            fx.Parameters.Add("@IdDocumentoTipo", DbType.Int32).Value = IdDocumentoTipo
            dtReturn = fx.GetTable()
        Catch ex As Exception
            Throw New BusinessException("Error al cargar los vistas contables", ex)
        End Try
        Return dtReturn
    End Function

    Public Function ValidaRac(ByVal IdVistaContableTit As Integer, ByVal IdRacTit As Integer) As String
        Dim strReturn As String = ""
        Try
            Dim fx As New FunctionSQL("Accounting", "fxVistasContablesValidaRAC", Connection, Transaction)
            fx.Parameters.Add("@IdVistaContableTit", DbType.Int32).Value = IdVistaContableTit
            fx.Parameters.Add("@IdRacTit", DbType.Int32).Value = IdRacTit
            strReturn = CStr(fx.GetScalar())
        Catch ex As Exception
            Throw New BusinessException("Error al validar las entidades del RAC", ex)
        End Try
        Return strReturn
    End Function


End Class