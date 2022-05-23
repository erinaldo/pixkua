Partial Class CentroProduccionFacade
    Public Function LoadList(ByVal sessionID As GUID, ByVal idSucursal As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CentroProduccionService(sessionID, Connection, Transaction)
            dtList = Svc.LoadList(idSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function LoadDataButtons(ByVal sessionID As GUID, ByVal idSucursal As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CentroProduccionService(sessionID, Connection, Transaction)
            dtList = Svc.LoadDataButtons(idSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function


    Public Function loadArticulos(ByVal sessionID As GUID, ByVal idSucursal As Integer) As ArticulosConfigDS.ArticuloCentroProdDataTable
        ValidateSession(sessionID)
        Dim dtList As New ArticulosConfigDS.ArticuloCentroProdDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CentroProduccionService(sessionID, Connection, Transaction)
            dtList = Svc.loadArticulos(idSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

End Class

Partial Class CentroProduccionService
    Public Function LoadList(ByVal idSucursal As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Restaurant", "fxCentrosProduccionCBO", Connection, Transaction)
            fxList.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            Dim dtList As DataTable = fxList.GetTable("CentrosProduccion")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de centros de producción.", ex)
        End Try
    End Function

    Public Function LoaddataButtons(ByVal idSucursal As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Restaurant", "fxCentrosProduccionDataButtons", Connection, Transaction)
            fxList.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            Dim dtList As DataTable = fxList.GetTable("CentrosProduccion")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de centros de producción.", ex)
        End Try
    End Function

    Public Function loadArticulos(ByVal idSucursal As Integer) As ArticulosConfigDS.ArticuloCentroProdDataTable
        Dim dt As New ArticulosConfigDS.ArticuloCentroProdDataTable
        Try
            Dim fx As New FunctionSQL("Restaurant", "fxCentrosProduccionArticulosLST", Connection, Transaction)
            fx.Parameters.Add("@idSucursal", DbType.Int32).Value = idSucursal
            fx.FillDataTable(dt)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de articulos.", ex)
        End Try
        Return dt
    End Function


End Class