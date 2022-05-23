Partial Class PagoTipoService
    Public Function LoadList() As DataTable
        Dim dt As New DataTable
        Try
            Dim fx As New FunctionSQL("Treasury", "fxPagosTiposCBO", Connection, Transaction)
            fx.FillDataTable(dt)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Tipos de Pago.", ex)
        End Try
        Return dt
    End Function
End Class

Partial Class PagoTipoFacade
    Public Function LoadList(ByVal sessionID As Guid) As DataTable
        ValidateSession(sessionID)
        Dim dtProveedores As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PagoTipoService(sessionID, Connection)
            dtProveedores = Svc.LoadList()
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtProveedores
    End Function
End Class
