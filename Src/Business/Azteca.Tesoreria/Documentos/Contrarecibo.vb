Partial Class ContrareciboService
    Public Function LoadPrintInfo(ByVal FechaIni As Date, ByVal FechaFin As Date, Ids As String) As InformesDS.ContrarecibosDataTable
        Dim dtList As New InformesDS.ContrarecibosDataTable
        Try
            Dim fxList As New FunctionSQL("Treasury", "fxContrarecibosRPT", Connection, Transaction)
            fxList.Parameters.Add("@FechaIni", DbType.DateTime).Value = FechaIni.ToShortDateString
            fxList.Parameters.Add("@FechaFin", DbType.DateTime).Value = FechaFin.ToShortDateString
            fxList.Parameters.Add("@Ids", DbType.String).Value = Ids
            fxList.FillDataTable(dtList)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar los datos del informe.", ex)
        End Try
        Return dtList
    End Function

    Public Function LoadList(ByVal FechaIni As Date, ByVal FechaFin As Date, ByVal IdCaja As Integer) As DataTable
        Dim dtList As DataTable = Nothing
        Try
            Dim fxList As New FunctionSQL("Treasury", "fxContrarecibosList", Connection, Transaction)
            fxList.Parameters.Add("@FechaIni", DbType.DateTime).Value = FechaIni
            fxList.Parameters.Add("@FechaFin", DbType.DateTime).Value = FechaFin
            fxList.Parameters.Add("@IdCaja", DbType.Int32).Value = IdCaja
            dtList = fxList.GetTable
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Contrarecibos.", ex)
        End Try
        Return dtList
    End Function
End Class

Partial Class ContrareciboFacade

    Public Function LoadList(ByVal sessionID As Guid, ByVal FechaIni As Date, ByVal FechaFin As Date, ByVal IdCaja As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ContrareciboService(sessionID, Connection, Transaction)
            dtList = Svc.LoadList(FechaIni, FechaFin, IdCaja)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function LoadPrintInfo(ByVal sessionID As Guid, ByVal FechaIni As Date, ByVal FechaFin As Date, Ids As String) As InformesDS.ContrarecibosDataTable
        ValidateSession(sessionID)
        Dim dtRet As New InformesDS.ContrarecibosDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ContrareciboService(sessionID, Connection, Transaction)
            dtRet = Svc.LoadPrintInfo(FechaIni, FechaFin, Ids)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtRet
    End Function
End Class