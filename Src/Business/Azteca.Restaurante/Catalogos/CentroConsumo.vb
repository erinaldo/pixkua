Partial Class CentroConsumoFacade

    Public Function LoadList(ByVal sessionID As GUID, ByVal idSucursal As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CentroConsumoService(sessionID, Connection, Transaction)
            dtList = Svc.LoadList(idSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function LoadDataButtons(ByVal sessionID As GUID, ByVal idMesero As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CentroConsumoService(sessionID, Connection, Transaction)
            dtList = Svc.LoadDataButtons(idMesero)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

End Class

Partial Class CentroConsumoService

    Public Function LoadList(ByVal idSucursal As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Restaurant", "fxCentrosConsumoCBO", Connection, Transaction)
            fxList.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            Dim dtList As DataTable = fxList.GetTable("CentrosConsumo")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de centros de consumo.", ex)
        End Try
    End Function

    Public Function LoadDataButtons(ByVal idMesero As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Restaurant", "fxCentrosConsumoLoadButtons", Connection, Transaction)
            fxList.Parameters.Add("@IdMesero", DbType.Int32).Value = idMesero
            Dim dtList As DataTable = fxList.GetTable("CentrosConsumo")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de centros de consumo.", ex)
        End Try
    End Function

End Class
