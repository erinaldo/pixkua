Partial Public Class IncidenciaRegistroService

    Public Function LoadDatosBapi(ByVal fechaIni As DateTime, ByVal fechaFin As DateTime) As DataTable
        Try
            Dim fxList As New FunctionSQL("CDU", "fxDatosBapi", Connection, Transaction)
            fxList.Parameters.Add("@FechaIni", DbType.DateTime).Value = fechaIni
            fxList.Parameters.Add("@FechaFin", DbType.DateTime).Value = fechaFin
            Dim dtList As DataTable = fxList.GetTable("Datos")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de paquetes de la Bapi.", ex)
        End Try
    End Function

End Class

Partial Public Class IncidenciaRegistroFacade

    Public Function LoadDatosBapi(ByVal sessionID As Guid, ByVal fechaIni As DateTime, ByVal fechaFin As DateTime) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New IncidenciaRegistroService(sessionID, Connection, Transaction)
            dtList = Svc.LoadDatosBapi(fechaIni, fechaFin)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

End Class
