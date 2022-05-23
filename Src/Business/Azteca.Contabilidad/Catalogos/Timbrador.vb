Partial Class TimbradorService

    Public Function LoadList() As DataTable
        Try
            Dim fxList As New FunctionSQL("Accounting", "fxTimbradoresCBO", Connection, Transaction)
            Dim dtList As DataTable = fxList.GetTable("Timbradores")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de timbradores.", ex)
        End Try
    End Function

    Public Function GetDetailFromCache(idTimbrador As Integer) As TimbradorInfo
        Dim CacheKey As String = "Timbrador_" & idTimbrador
        Dim Timbrador As New TimbradorInfo(SessionID)
        Try
            If Azteca.Kernel.Cache.Contains(CacheKey) Then
                Timbrador = CType(Azteca.Kernel.Cache.Item(CacheKey), TimbradorInfo)
            Else
                Dim TimbradorSvc As New TimbradorService(SessionID, Connection, Transaction)
                TimbradorSvc.GetDetail(idTimbrador, Timbrador, False)
                Azteca.Kernel.Cache.Add(CacheKey, Timbrador, TimeSpan.FromDays(1))
            End If
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la información del timbrador desde el caché", ex)
        End Try
        Return Timbrador
    End Function

End Class



Partial Class TimbradorFacade

    Public Function LoadList(sessionID As Guid) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New TimbradorService(sessionID, Connection)
            dtList = Svc.LoadList()
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de timbradores.", ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

End Class

