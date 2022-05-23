Partial Class ServicioService

#Region "Metodos Generales"

    Public Function GetIdByCode(ByVal codigo As String, ByVal idSucursal As Integer) As Integer
        Return CodeToID(codigo, idSucursal)
    End Function

    Public Function LoadList(idEmpresa As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Purchasing", "fxServiciosCBO", Connection, Transaction)
            fxList.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            Dim dtList As DataTable = fxList.GetTable("Servicios")
            dtList.RemotingFormat = SerializationFormat.Binary

            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de servicios.", ex)
        End Try
    End Function

    Public Function GetDetailFromCache(idServicio As Integer) As ServicioInfo
        Dim CacheKey As String = "ServicioCompra" & idServicio.ToString
        Try
            Dim ServicioInf As New ServicioInfo(SessionID)
            If Azteca.Kernel.Cache.Item(CacheKey) Is Nothing Then
                Dim ServicioSvc As New ServicioService(SessionID, Connection, Transaction)
                ServicioSvc.GetDetail(idServicio, ServicioInf, False)
                Azteca.Kernel.Cache.Add(CacheKey, ServicioInf, TimeSpan.FromDays(1))
            Else
                ServicioInf = CType(Azteca.Kernel.Cache.Item(CacheKey), ServicioInfo)
            End If
            Return ServicioInf
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el servicio desde el caché de sistema.", ex)
        End Try
    End Function

    Public Function GetDetailFromCache(ByVal codigo As String, ByVal idSucursal As Integer) As ServicioInfo
        Try
            Dim IdServicio As Integer = GetIdByCode(codigo, idSucursal)
            Return GetDetailFromCache(IdServicio)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el servicio desde el caché de sistema.", ex)
        End Try
    End Function

#End Region


End Class


Partial Class ServicioFacade

#Region "Metodos Generales"

    Public Function LoadList(sessionID As Guid, idEmpresa As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ServicioService(sessionID, Connection)
            dtList = Svc.LoadList(idEmpresa)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function GetDetailFromCache(ByVal sessionID As Guid, ByVal idServicio As Integer) As ServicioInfo
        ValidateSession(sessionID)
        Dim ServicioInf As ServicioInfo = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ServicioService(sessionID, Connection)
            ServicioInf = Svc.GetDetailFromCache(idServicio)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return ServicioInf
    End Function

    Public Function GetDetailFromCache(ByVal sessionID As Guid, ByVal codigo As String, ByVal idSucursal As Integer) As ServicioInfo
        ValidateSession(sessionID)
        Dim ServicioInf As ServicioInfo = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ServicioService(sessionID, Connection)
            ServicioInf = Svc.GetDetailFromCache(codigo, idSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return ServicioInf
    End Function

#End Region

End Class