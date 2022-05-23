Partial Class ArticuloFacade
    Public Function LoadListDataButtons(ByVal sessionID As GUID, ByVal idSucursal As Integer) As ArticulosConfigDS.ArticuloDataTable
        ValidateSession(sessionID)
        Dim dtList As New ArticulosConfigDS.ArticuloDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ArticuloService(sessionID, Connection, Transaction)
            dtList = Svc.LoadListDataButtons(idSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function getArticuloFromArticuloStock(ByVal sessionID As Guid, ByVal idArticuloStock As Integer) As Integer
        Dim Id As Integer = 0
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ArticuloService(sessionID, Connection, Transaction)
            Id = Svc.getArticuloFromArticuloStock(idArticuloStock)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Id
    End Function

End Class

Partial Class ArticuloService

    Public Function LoadListDataButtons(ByVal idSucursal As Integer) As ArticulosConfigDS.ArticuloDataTable
        Try
            Dim fxList As New FunctionSQL("Restaurant", "fxArticulosDataButtons", Connection, Transaction)
            fxList.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            Dim dtList As New ArticulosConfigDS.ArticuloDataTable
            fxList.FillDataTable(dtList)
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de articulos.", ex)
        End Try
    End Function

    Public Function getArticuloFromArticuloStock(ByVal idArticuloStock As Integer) As Integer
        Try
            Dim fxList As New FunctionSQL("Restaurant", "fxGetArticuloFromArticuloStock", Connection, Transaction)
            fxList.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idArticuloStock
            Return CInt(fxList.GetScalar)
        Catch ex As Exception
            Throw New BusinessException("Error al obtener el articulo de restaurante desde el articulo de inventario.", ex)
        End Try
    End Function

End Class
