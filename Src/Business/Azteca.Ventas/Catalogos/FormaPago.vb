Partial Class FormaPagoService

    Public Function LoadList() As DataTable
        Try
            Dim fxList As New FunctionSQL("Sales", "fxFormasPagoCBO", Connection, Transaction)
            Dim dtList As DataTable = fxList.GetTable("FormasPago")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de formas de pago.", ex)
        End Try
    End Function

    Public Function LoadButtonsList(ByVal idSucursal As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Restaurant", "fxFormasPagoDataButtons", Connection, Transaction)
            fxList.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            Dim dtList As DataTable = fxList.GetTable("FormasPago")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Formas de pago.", ex)
        End Try
    End Function

End Class


Partial Class FormaPagoFacade

    Public Function LoadList(ByVal sessionID As GUID) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New FormaPagoService(sessionID, Connection, Transaction)
            dtList = Svc.LoadList()
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function LoadButtonsList(ByVal sessionID As GUID, ByVal idSucursal As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New FormaPagoService(sessionID, Connection, Transaction)
            dtList = Svc.LoadButtonsList(idSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

End Class
