Imports Azteca.Kernel

Partial Class RetencionService

    Public Function GetDetailFromCache(idRetencion As Integer) As RetencionInfo
        Try
            Dim CacheKey As String = "Retencion_" & idRetencion.ToString
            Dim Retencion As New RetencionInfo(SessionID)
            If Cache.Contains(CacheKey) Then
                Retencion = CType(Cache.Item(CacheKey), RetencionInfo)
            Else
                Dim RetencionSvc As New RetencionService(SessionID, Connection, Transaction)
                RetencionSvc.GetDetail(idRetencion, Retencion, False)
                Cache.Add(CacheKey, Retencion, TimeSpan.FromHours(12))
            End If
            Return Retencion
        Catch ex As Exception
            Throw New BusinessException("Error al obtener la información de la retención desde el caché", ex)
        End Try
    End Function

    Public Function LoadList(idEmpresa As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Accounting", "fxRetencionesCBO", Connection, Transaction)
            'fxList.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            Dim dtList As DataTable = fxList.GetTable("Retenciones")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de retenciones.", ex)
        End Try
    End Function

End Class



Partial Class RetencionFacade

    Public Function LoadList(sessionID As Guid, idEmpresa As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtRetenciones As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New RetencionService(sessionID, Connection)
            dtRetenciones = Svc.LoadList(idEmpresa)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtRetenciones
    End Function


End Class