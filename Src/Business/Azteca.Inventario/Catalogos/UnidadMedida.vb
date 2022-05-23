Imports Azteca.Kernel

Partial Class UnidadMedidaService

    Public Function LoadList() As DataTable
        Try
            Dim CacheKey As String = "UnidadesMedida"
            Dim dtList As DataTable
            If Azteca.Kernel.Cache.Item(CacheKey) Is Nothing Then
                Dim fxList As New FunctionSQL("Inventory", "fxUnidadesMedidaCBO", Connection, Transaction)
                dtList = fxList.GetTable("UnidadesMedida")
                dtList.RemotingFormat = SerializationFormat.Binary
                Azteca.Kernel.Cache.Add(CacheKey, dtList, TimeSpan.FromHours(1))
            Else
                dtList = CType(Azteca.Kernel.Cache.Item(CacheKey), DataTable)
            End If            
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de unidades de medida.", ex)
        End Try
    End Function

    Public Function GetDetailFromCache(ByVal idUnidadMedida As Integer) As UnidadMedidaInfo
        Try
            Dim CacheKey As String = "UnidadMedida" & idUnidadMedida
            Dim UnidadMedida As New UnidadMedidaInfo(sessionID)
            If Cache.Item(CacheKey) Is Nothing Then
                Dim UnidadSvc As New UnidadMedidaService(sessionID, Connection, Transaction)
                UnidadSvc.GetDetail(idUnidadMedida, UnidadMedida, False)
                Cache.Add(CacheKey, UnidadMedida, TimeSpan.FromDays(1))
            Else
                UnidadMedida = CType(Cache.Item(CacheKey), UnidadMedidaInfo)
            End If
            Return UnidadMedida
        Catch ex As Exception
            Throw New BusinessException("Error al cargar información de la unidad de medida desde el caché.", ex)
        End Try
    End Function

    Public Function ConvertirCantidad(cantidad As Decimal, idUnidadMedidaOrigen As Integer, idUnidadMedidaDestino As Integer) As Decimal
        Try
            'Carga información de las unidades de medida
            Dim UnidadSvc As New UnidadMedidaService(SessionID, Connection, Transaction)
            Dim UnidadOrigen As UnidadMedidaInfo = UnidadSvc.GetDetailFromCache(idUnidadMedidaOrigen)
            Dim UnidadDestino As UnidadMedidaInfo = UnidadSvc.GetDetailFromCache(idUnidadMedidaDestino)
            'Validar que las unidades sean del mismo tipo
            If UnidadOrigen.IdTipoUnidad = UnidadDestino.IdTipoUnidad Then
                Dim Resultado As Decimal = (cantidad * UnidadOrigen.Factor) / UnidadDestino.Factor
                Return Resultado
            Else
                Throw New BusinessException("Las unidades de medida son de diferente tipo.")
            End If
        Catch ex As Exception
            Throw New BusinessException("Error al convertir unidades de medida", ex)
        End Try
    End Function

End Class


Partial Class UnidadMedidaFacade
    Public Function LoadList(ByVal sessionID As GUID) As DataTable
        ValidateSession(sessionID)
        Dim dtList As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New UnidadMedidaService(sessionID, Connection, Transaction)
            dtList = Svc.LoadList()
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function GetDetailFromCache(ByVal sessionID As GUID, ByVal idUnidadMedida As Integer) As UnidadMedidaInfo
        ValidateSession(sessionID)
        Dim UnidadMedida As UnidadMedidaInfo = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New UnidadMedidaService(sessionID, Connection, Transaction)
            UnidadMedida = Svc.GetDetailFromCache(idUnidadMedida)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return UnidadMedida
    End Function

    Public Function ConvertirCantidad(sessionID As Guid, cantidad As Decimal, idUnidadMedidaOrigen As Integer, idUnidadMedidaDestino As Integer) As Decimal
        ValidateSession(sessionID)
        Dim Resultado As Decimal = 0
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New UnidadMedidaService(sessionID, Connection, Transaction)
            Resultado = Svc.ConvertirCantidad(cantidad, idUnidadMedidaOrigen, idUnidadMedidaDestino)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Resultado
    End Function


End Class