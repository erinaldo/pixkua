Partial Class UbicacionTipoFacade
    Public Function LoadList(ByVal sessionID As Guid, ByVal idSucursal As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtProveedores As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New UbicacionTipoService(sessionID, Connection)
            dtProveedores = Svc.LoadList(idSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtProveedores
    End Function
End Class

Partial Class UbicacionTipoService
    Public Function LoadList(ByVal IdSucursal As Integer) As DataTable
        Dim dt As New DataTable
        Try
            Dim fx As New FunctionSQL("Inventory", "fxUbicacionesTipoCBO", Connection, Transaction)
            fx.Parameters.Add("@IdSucursal", DbType.Int32).Value = IdSucursal
            fx.FillDataTable(dt)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Tipos de Ubicaciones.", ex)
        End Try
        Return dt
    End Function
End Class