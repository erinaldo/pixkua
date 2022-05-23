Partial Class VendedorService

    Public Function LoadList(ByVal idSucursal As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Sales", "fxVendedoresCBO", Connection, Transaction)
            fxList.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            Dim dtList As DataTable = fxList.GetTable("Vendedores")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de vendedores.", ex)
        End Try
    End Function

End Class


Partial Class VendedorFacade

    Public Function LoadList(ByVal sessionID As Guid, ByVal idSucursal As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New VendedorService(sessionID, Connection, Transaction)
            dtList = Svc.LoadList(idSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

End Class