Imports Azteca.Kernel

Partial Class ConceptoService

    Public Function LoadList() As DataTable
        Try
            Dim fxList As New FunctionSQL("Inventory", "fxConceptosCBO", Connection, Transaction)
            Dim dtList As DataTable = fxList.GetTable("Conceptos")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de de conceptos.", ex)
        End Try
    End Function

    Public Function GetDetailFromCache(ByVal idConcepto As Integer) As ConceptoInfo
        Try
            Dim CacheKey As String = "ConceptoInventario" & idConcepto
            Dim Concepto As New ConceptoInfo(sessionID)
            If Cache.Item(CacheKey) Is Nothing Then
                Dim ConceptoSvc As New ConceptoService(sessionID, Connection, Transaction)
                ConceptoSvc.GetDetail(idConcepto, Concepto, False)
                Cache.Add(CacheKey, Concepto, TimeSpan.FromDays(1))
            Else
                Concepto = CType(Cache.Item(CacheKey), ConceptoInfo)
            End If
            Return Concepto
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la información del concepto desde el caché.", ex)
        End Try
    End Function

End Class


Partial Class ConceptoFacade

    Public Function LoadList(ByVal sessionID As GUID) As DataTable
        ValidateSession(sessionID)
        Dim dtList As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ConceptoService(sessionID, Connection, Transaction)
            dtList = Svc.LoadList()
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function GetDetailFromCache(ByVal sessionID As GUID, ByVal idConcepto As Integer) As ConceptoInfo
        ValidateSession(sessionID)
        Dim Concepto As ConceptoInfo = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ConceptoService(sessionID, Connection, Transaction)
            Concepto = Svc.GetDetailFromCache(idConcepto)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Concepto
    End Function


End Class
