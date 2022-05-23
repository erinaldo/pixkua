

Partial Class EnsambleService

   

    Public Function List(ByVal idEmpresa As Integer) As OrdenesTrabajoDS.EnsamblesCBODataTable
        Dim dt As New OrdenesTrabajoDS.EnsamblesCBODataTable

        Try
            Dim fx As New FunctionSQL("Production", "[fxEnsamblesComboBox]", Connection, Transaction)
            fx.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            fx.FillDataTable(dt)
        Catch ex As Exception
            Throw New Exception("Error al obtener la lista de ensambles", ex)
        End Try

        Return dt
    End Function

    Public Function LoadListByOT(ByVal idOrdenTrabajo As Integer) As OrdenesTrabajoDS.EnsamblesCBODataTable
        Dim dt As New OrdenesTrabajoDS.EnsamblesCBODataTable

        Try
            Dim fx As New FunctionSQL("Production", "[fxEnsamblesComboBoxByOT]", Connection, Transaction)
            fx.Parameters.Add("@IdOrdenTrabajo", DbType.Int32).Value = idOrdenTrabajo
            fx.FillDataTable(dt)
        Catch ex As Exception
            Throw New Exception("Error al obtener la lista de ensambles por OT", ex)
        End Try

        Return dt
    End Function

    

End Class

Partial Class EnsambleFacade

    

    Public Function List(ByVal sessionID As Guid, ByVal idEmpresa As Integer) As OrdenesTrabajoDS.EnsamblesCBODataTable
        Dim EnsamblesDT As New OrdenesTrabajoDS.EnsamblesCBODataTable
        Try
            Connection = DataServices.OpenConnection
            Dim svc As New EnsambleService(sessionID, Connection)
            EnsamblesDT = svc.List(idEmpresa)

        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try

        Return EnsamblesDT
    End Function

    Public Function LoadListByOT(ByVal sessionID As Guid, ByVal idOrdenTrabajo As Integer) As OrdenesTrabajoDS.EnsamblesCBODataTable
        Dim EnsamblesDT As New OrdenesTrabajoDS.EnsamblesCBODataTable
        Try
            Connection = DataServices.OpenConnection
            Dim svc As New EnsambleService(sessionID, Connection)
            EnsamblesDT = svc.LoadListByOT(idOrdenTrabajo)

        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try

        Return EnsamblesDT
    End Function

    

End Class

