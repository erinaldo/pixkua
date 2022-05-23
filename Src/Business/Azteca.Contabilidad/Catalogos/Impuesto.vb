Imports Azteca.Kernel
Partial Class ImpuestoService

    Public Function GetDetailFromCache(idImpuesto As Integer) As ImpuestoInfo
        Try
            Dim CacheKey As String = "Impuesto_" & idImpuesto.ToString
            Dim Impuesto As New ImpuestoInfo(SessionID)
            If Cache.Contains(CacheKey) Then
                Impuesto = CType(Cache.Item(CacheKey), ImpuestoInfo)
            Else
                Dim ImpuestoSvc As New ImpuestoService(SessionID, Connection, Transaction)
                ImpuestoSvc.GetDetail(idImpuesto, Impuesto, False)
                Cache.Add(CacheKey, Impuesto, TimeSpan.FromHours(12))
            End If
            Return Impuesto
        Catch ex As Exception
            Throw New BusinessException("Error al obtener la información del impuesto desde el caché", ex)
        End Try
    End Function

    Public Function LoadList() As DataTable
        Try
            Dim fxList As New FunctionSQL("Accounting", "fxImpuestosCBO", Connection, Transaction)
            Dim dtList As DataTable = fxList.GetTable("Impuestos")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de impuestos.", ex)
        End Try
    End Function

End Class


Partial Class ImpuestoFacade

    Public Function LoadList(ByVal sessionID As GUID) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ImpuestoService(sessionID, Connection, Transaction)
            dtList = Svc.LoadList()
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

End Class
