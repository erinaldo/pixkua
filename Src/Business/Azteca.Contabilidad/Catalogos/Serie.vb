Imports Azteca.Kernel

Partial Class SerieService

#Region "Metodoso Privados"
    Private Sub CargarFolios(ByVal serie As SerieInfo)
        Try
            Dim fxFolios As New FunctionSQL("Accounting", "fxCFDSerieFoliosSEL", Connection, Transaction)
            fxFolios.Parameters.Add("@IdCFDSerie", DbType.Int32).Value = serie.Identity
            fxFolios.FillDataTable(serie.Folios)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar los folios de la serie.", ex)
        End Try
    End Sub
#End Region

    Public Function LoadList(ByVal idEmpresa As Integer) As DataTable
        Try
            Dim fxSeries As New FunctionSQL("Accounting", "fxCFDSeriesCBO", Connection, Transaction)
            fxSeries.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            Dim dtSeries As DataTable = fxSeries.GetTable("Series")
            Return dtSeries
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de series de facturación.", ex)
        End Try
    End Function

    Public Sub RegistrarFolios(ByVal idSerie As Integer, ByVal anioAprobacion As Integer, ByVal numeroAprobacion As Integer, ByVal folioInicial As Integer, ByVal folioFinal As Integer)
        Try
            Dim spRegistrar As New StoredProcedure("Accounting", "CFDFoliosRegistrar", Connection, Transaction)
            spRegistrar.Parameters.Add("@IdCFDSerie", DbType.Int32).Value = idSerie
            spRegistrar.Parameters.Add("@AnioAprobacion", DbType.Int32).Value = anioAprobacion
            spRegistrar.Parameters.Add("@NumAprobacion", DbType.Int32).Value = numeroAprobacion
            spRegistrar.Parameters.Add("@FolioInicial", DbType.Int32).Value = folioInicial
            spRegistrar.Parameters.Add("@FolioFinal", DbType.Int32).Value = folioFinal
            spRegistrar.Parameters.Add("@UserUpdate", DbType.Int32).Value = Session.User.Identity
            spRegistrar.Parameters.Add("@PCUpdate", DbType.String).Value = Session.WorkStation
            spRegistrar.Execute()
        Catch ex As Exception
            Throw New BusinessException("Error al registrar la autorización de folios.", ex)
        End Try
    End Sub

    Public Overloads Function GetDetail(ByVal idSerie As Integer, ByVal checkStatus As Boolean, ByVal loadFolios As Boolean) As SerieInfo
        Try
            Dim Serie As New SerieInfo(sessionID)
            Dim SerieSvc As New SerieService(sessionID, Connection, Transaction)
            SerieSvc.GetDetail(idSerie, Serie, checkStatus)
            'Cargar lista de folios
            If loadFolios Then CargarFolios(Serie)
            Return Serie
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el detalle de la serie de comprobantes", ex)
        End Try
    End Function

    Public Overloads Function GetDetailFromCache(ByVal idSerie As Integer) As SerieInfo
        Try
            Dim CacheKey As String = "CFDSerie" & idSerie.ToString
            Dim SerieInf As New SerieInfo(sessionID)
            If Cache.Item(CacheKey) Is Nothing Then
                Dim SerieSvc As New SerieService(sessionID, Connection, Transaction)
                SerieInf = SerieSvc.GetDetail(idSerie, False, True)
            Else
                SerieInf = CType(Cache.Item(CacheKey), SerieInfo)
            End If
            Return SerieInf
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la información de la serie del caché", ex)
        End Try
    End Function

End Class




Partial Class SerieFacade

    Public Function LoadList(ByVal sessionID As GUID, ByVal idEmpresa As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtSeries As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New SerieService(sessionID, Connection, Transaction)
            dtSeries = Svc.LoadList(idEmpresa)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtSeries
    End Function


    Public Sub RegistrarFolios(ByVal sessionID As GUID, ByVal idSerie As Integer, ByVal anioAprobacion As Integer, ByVal numeroAprobacion As Integer, ByVal folioInicial As Integer, ByVal folioFinal As Integer)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New SerieService(sessionID, Connection, Transaction)
                Svc.RegistrarFolios(idSerie, anioAprobacion, numeroAprobacion, folioInicial, folioFinal)
                DataServices.CommitTransaction(Transaction)
            Catch ex As Exception
                DataServices.RollbackTransaction(Transaction)
                Throw ex
            End Try
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub

    Public Overloads Function GetDetail(ByVal sessionID As GUID, ByVal idSerie As Integer, ByVal checkStatus As Boolean, ByVal loadFolios As Boolean) As SerieInfo
        ValidateSession(sessionID)
        Dim Serie As New SerieInfo(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New SerieService(sessionID, Connection, Transaction)
            Serie = Svc.GetDetail(idSerie, checkStatus, loadFolios)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Serie
    End Function

End Class