Partial Class EntidadService
    Public Function LoadList(ByVal IdVistaContableTit As Integer) As DataTable
        Dim dtReturn As New DataTable()
        Try
            Dim fx As New FunctionSQL("Accounting", "fxVistasContablesEntidadesCBO", Connection, Transaction)
            fx.Parameters.Add("@IdVistaContableTit", DbType.Int32).Value = IdVistaContableTit
            dtReturn = fx.GetTable()
        Catch ex As Exception
            Throw New BusinessException("Error al cargar las Entidades de la vista contable", ex)
        End Try
        Return dtReturn
    End Function
End Class


Partial Class EntidadFacade
    Public Function LoadList(ByVal sessionID As Guid, ByVal IdVistaContableTit As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dt As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New EntidadService(sessionID, Connection)
            dt = Svc.LoadList(IdVistaContableTit)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dt
    End Function
End Class


