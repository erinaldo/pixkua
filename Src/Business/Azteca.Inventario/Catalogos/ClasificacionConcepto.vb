Partial Class ClasificacionConceptoService

    Public Function CargarConceptos(ByVal idClasificacion As Integer) As DataTable
        Try
            Dim fxConceptos As New FunctionSQL("Inventory", "fxClasificacionConceptosSEL", Connection, Transaction)
            fxConceptos.Parameters.Add("@IdClasificacion", DbType.Int32).Value = idClasificacion
            Dim dtConceptos As DataTable = fxConceptos.GetTable("Conceptos")
            Return dtConceptos
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de conceptos de la clasificación.", ex)
        End Try
    End Function

    Public Function LoadList(ByVal idEmpresa As Integer) As DataTable
        Try
            Dim fxClasificaciones As New FunctionSQL("Inventory", "fxConceptosClasificacionesCBO", Connection, Transaction)
            fxClasificaciones.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            Dim dtClasificaciones As DataTable = fxClasificaciones.GetTable("Clasificaciones")
            Return dtClasificaciones
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de clasificaciones.", ex)
        End Try
    End Function
End Class


Partial Class ClasificacionConceptoFacade

    Public Function CargarConceptos(ByVal sessionID As GUID, ByVal idClasificacion As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtConceptos As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ClasificacionConceptoService(sessionID, Connection, Transaction)
            dtConceptos = Svc.CargarConceptos(idClasificacion)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtConceptos
    End Function

    Public Function LoadList(ByVal sessionID As GUID, ByVal idEmpresa As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtClasificaciones As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ClasificacionConceptoService(sessionID, Connection, Transaction)
            dtClasificaciones = Svc.LoadList(idEmpresa)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtClasificaciones
    End Function

End Class