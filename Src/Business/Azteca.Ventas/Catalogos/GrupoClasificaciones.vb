Partial Class GrupoClasificacionesService

    Public Function CargarEntidades() As DataTable
        Try
            Dim fxEntidades As New FunctionSQL("Sales", "fxClasificacionesEntidadesCBO", Connection, Transaction)
            Dim dtEntidades As DataTable = fxEntidades.GetTable("Entidades")
            Return dtEntidades
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de entidades", ex)
        End Try
    End Function

    Public Function CargarClasificaciones(ByVal idEntidad As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Sales", "fxClasificacionesCBO", Connection, Transaction)
            fxList.Parameters.Add("@IdEntidad", DbType.Int32).Value = idEntidad
            Dim dtList As DataTable = fxList.GetTable("Clasificaciones")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de clasificaciones.", ex)
        End Try
    End Function

End Class



Partial Class GrupoClasificacionesFacade

    Public Function CargarEntidades(ByVal sessionID As GUID) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New GrupoClasificacionesService(sessionID, Connection)
            dtList = Svc.CargarEntidades()
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function CargarClasificaciones(ByVal sessionID As GUID, ByVal idEntidad As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New GrupoClasificacionesService(sessionID, Connection)
            dtList = Svc.CargarClasificaciones(idEntidad)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function


End Class