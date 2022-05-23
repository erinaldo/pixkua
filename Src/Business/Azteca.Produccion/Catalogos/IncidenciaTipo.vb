Imports Azteca.Kernel

Partial Class IncidenciaTipoService

    Public Function List(ByVal idEmpresa As Integer) As IncidenciasDS.TiposDataTable
        Dim dt As New IncidenciasDS.TiposDataTable

        Try
            Dim fx As New FunctionSQL("Production", "fxIncidenciasTiposListSEL", Connection, Transaction)
            fx.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            fx.FillDataTable(dt)
        Catch ex As Exception
            Throw New Exception("Error al obtener la lista de Tipos de Incidencias", ex)
        End Try

        Return dt
    End Function

End Class

Partial Class IncidenciaTipoFacade

    Public Function List(ByVal sessionID As Guid, ByVal idEmpresa As Integer) As IncidenciasDS.TiposDataTable
        Dim IncidenciasTiposDT As IncidenciasDS.TiposDataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim svc As New IncidenciaTipoService(sessionID, Connection)
            IncidenciasTiposDT = svc.List(idEmpresa)

        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try

        Return IncidenciasTiposDT
    End Function

End Class


