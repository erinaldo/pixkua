Partial Class ZonaCompraService

    Public Function LoadList(idEmpresa As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Purchasing", "fxZonasCompraCBO", Connection, Transaction)
            fxList.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            Dim dtList As DataTable = fxList.GetTable("Zonas")
            dtList.RemotingFormat = SerializationFormat.Binary
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de zonas de compra.", ex)
        End Try
    End Function

    Public Function LoadList(idEmpresa As Integer, idUsuario As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Purchasing", "fxZonasCompraCBO", Connection, Transaction)
            fxList.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            Dim dtList As DataTable = fxList.GetTable("Zonas")
            dtList.RemotingFormat = SerializationFormat.Binary
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de zonas de compra.", ex)
        End Try
    End Function


End Class


Partial Class ZonaCompraFacade

    Public Function LoadList(sessionID As Guid, idEmpresa As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ZonaCompraService(sessionID, Connection)
            dtList = Svc.LoadList(idEmpresa)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function LoadList(sessionID As Guid, idEmpresa As Integer, idUsuario As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ZonaCompraService(sessionID, Connection)
            dtList = Svc.LoadList(idEmpresa, idUsuario)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function


End Class