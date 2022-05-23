Partial Class TraspasoService

    Public Function GetInforme(ByVal idTraspaso As String) As DataTable
        Try
            Dim fxInforme As New FunctionSQL("Inventory", "fxTraspasoRPT", Connection, Transaction)
            fxInforme.Parameters.Add("@IdTraspasoTit", DbType.String).Value = idTraspaso
            Dim dtInforme As DataTable = fxInforme.GetTable("Informe")
            Return dtInforme
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la información de impresión del traspaso", ex)
        End Try
    End Function

End Class


Partial Class TraspasoFacade

    Public Function GetInforme(ByVal sessionID As Guid, ByVal idTraspaso As String) As DataTable
        ValidateSession(sessionID)
        Dim dtInforme As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New TraspasoService(sessionID, Connection)
            dtInforme = Svc.GetInforme(idTraspaso)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtInforme
    End Function

End Class