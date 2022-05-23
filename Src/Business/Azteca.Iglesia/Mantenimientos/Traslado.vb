Partial Public Class TrasladoService

    Public Function InformeTraslado(ByVal idTraslado As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Church", "fxTraslado", Connection, Transaction)
            fxList.Parameters.Add("@IdTraslado", DbType.Int32).Value = idTraslado
            Dim dtList As DataTable = fxList.GetTable("Traslado")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el acta de confirmacion.", ex)
        End Try
    End Function

End Class

Partial Public Class TrasladoFacade

    Public Function InformeTraslado(ByVal sessionID As Guid, ByVal idTraslado As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New TrasladoService(sessionID, Connection, Transaction)
            dtList = Svc.InformeTraslado(idTraslado)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

End Class
