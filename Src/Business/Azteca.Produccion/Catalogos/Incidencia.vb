Partial Class IncidenciaService

    Public Function LoadList() As OrdenesTrabajoDS.IncidenciasCBODataTable
        Dim dt As New OrdenesTrabajoDS.IncidenciasCBODataTable

        Try
            Dim fx As New FunctionSQL("Production", "[fxIncidenciasCBO]", Connection, Transaction)
            fx.FillDataTable(dt)
        Catch ex As Exception
            Throw New Exception("Error al obtener la lista de incidencias", ex)
        End Try

        Return dt
    End Function

End Class

Partial Class IncidenciaFacade

    Public Function LoadList(ByVal sessionID As Guid) As OrdenesTrabajoDS.IncidenciasCBODataTable
        Dim DT As New OrdenesTrabajoDS.IncidenciasCBODataTable
        Try
            Connection = DataServices.OpenConnection
            Dim svc As New IncidenciaService(sessionID, Connection)
            DT = svc.LoadList()

        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try

        Return DT
    End Function

End Class


