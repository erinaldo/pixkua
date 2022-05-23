Partial Class PagoService

    Public Function LoadPrint(ByVal IdPagoTit As String) As InformesDS.PagoRPTDataTable
        Dim dtList As New InformesDS.PagoRPTDataTable
        Try
            Dim fxList As New FunctionSQL("Treasury", "fxPagosRPT", Connection, Transaction)
            fxList.Parameters.Add("@IdPagoTit", DbType.String).Value = IdPagoTit
            fxList.FillDataTable(dtList)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la los datos de impresión.", ex)
        End Try
        Return dtList
    End Function

    Public Function LoadList(ByVal FechaIni As Date, ByVal FechaFin As Date, ByVal IdCaja As Integer) As DataTable
        Dim dtList As DataTable = Nothing
        Try
            Dim fxList As New FunctionSQL("Treasury", "fxPagosList", Connection, Transaction)
            fxList.Parameters.Add("@FechaIni", DbType.DateTime).Value = FechaIni
            fxList.Parameters.Add("@FechaFin", DbType.DateTime).Value = FechaFin
            fxList.Parameters.Add("@IdCaja", DbType.Int32).Value = IdCaja
            dtList = fxList.GetTable
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Pagos generados.", ex)
        End Try
        Return dtList
    End Function

    Public Function PendientesEmitidosList(ByVal FechaIni As Date, ByVal FechaFin As Date, ByVal IdCaja As Integer) As PagosDS.ContrarecibosPorPagarDataTable
        Dim dtList As New PagosDS.ContrarecibosPorPagarDataTable
        Try
            Dim fxList As New FunctionSQL("Treasury", "fxContrarecibosPendPagoEmitidos", Connection, Transaction)
            fxList.Parameters.Add("@FechaIni", DbType.DateTime).Value = FechaIni
            fxList.Parameters.Add("@FechaFin", DbType.DateTime).Value = FechaFin
            fxList.Parameters.Add("@IdCaja", DbType.Int32).Value = IdCaja
            fxList.FillDataTable(dtList)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Pagos Pendientes.", ex)
        End Try
        Return dtList
    End Function

    Public Function AntiguedadSaldos(FechaIni As Date, FechaFin As Date, LapsoDias As Integer) As InformesDS.AntiguedadSaldosDataTable
        Dim dtList As New InformesDS.AntiguedadSaldosDataTable
        Try
            Dim fxList As New FunctionSQL("Treasury", "fxAntiguedadSaldosRPT", Connection, Transaction)
            fxList.Parameters.Add("@FechaIni", DbType.DateTime).Value = FechaIni
            fxList.Parameters.Add("@FechaFin", DbType.DateTime).Value = FechaFin
            fxList.Parameters.Add("@LapsoDias", DbType.Int32).Value = LapsoDias
            fxList.FillDataTable(dtList)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar los datos del informe.", ex)
        End Try
        Return dtList
    End Function


    Public Function PendientesVencidosList(ByVal FechaIni As Date, ByVal FechaFin As Date, ByVal IdCaja As Integer) As PagosDS.ContrarecibosPorPagarDataTable
        Dim dtList As New PagosDS.ContrarecibosPorPagarDataTable
        Try
            Dim fxList As New FunctionSQL("Treasury", "fxContrarecibosPendPagoVencidos", Connection, Transaction)
            fxList.Parameters.Add("@FechaIni", DbType.DateTime).Value = FechaIni
            fxList.Parameters.Add("@FechaFin", DbType.DateTime).Value = FechaFin
            fxList.Parameters.Add("@IdCaja", DbType.Int32).Value = IdCaja
            fxList.FillDataTable(dtList)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Pagos Pendientes.", ex)
        End Try
        Return dtList
    End Function

    Public Function ArchiveroDigital(FechaIni As Date, FechaFin As Date, IdGasto As String, SerieGasto As String, FacturaGasto As Integer, _
                                    IdRequisicion As String, IdOrdenTit As String, IdRecepcionTit As String, SerieRecep As String, FacturaRecep As Integer, _
                                    IdContrareciboTit As String, IdPago As String, IdChequera As Integer, FolioPago As Integer) As PagosDS
        Dim dsPagos As New PagosDS
        Try
            Dim fxList As New FunctionSQL("Treasury", "fxPagosArchiveroDig", Connection, Transaction)

            fxList.Parameters.Add("@FechaIni", DbType.DateTime).Value = FechaIni.ToShortDateString
            fxList.Parameters.Add("@FechaFin", DbType.DateTime).Value = FechaFin.ToShortDateString
            fxList.Parameters.Add("@IdGasto", DbType.String).Value = IdGasto
            fxList.Parameters.Add("@SerieGasto", DbType.String).Value = SerieGasto
            fxList.Parameters.Add("@FacturaGasto", DbType.Int32).Value = FacturaGasto
            fxList.Parameters.Add("@IdRequisicion", DbType.String).Value = IdRequisicion
            fxList.Parameters.Add("@IdOrdenTit", DbType.String).Value = IdOrdenTit
            fxList.Parameters.Add("@IdRecepcionTit", DbType.String).Value = IdRecepcionTit
            fxList.Parameters.Add("@SerieRecep", DbType.String).Value = SerieRecep
            fxList.Parameters.Add("@FacturaRecep", DbType.Int32).Value = FacturaRecep
            fxList.Parameters.Add("@IdContrareciboTit", DbType.String).Value = IdContrareciboTit
            fxList.Parameters.Add("@IdPago", DbType.String).Value = IdPago
            fxList.Parameters.Add("@IdChequera", DbType.Int32).Value = IdChequera
            fxList.Parameters.Add("@FolioPago", DbType.Int32).Value = FolioPago
            fxList.FillDataTable(dsPagos.ArchiveroDigital)

            'Obtenemos todos los documentos para traernos las polizas q genero cada uno
            If dsPagos.ArchiveroDigital.Rows.Count > 0 Then
                Dim DocumentosPolizas As String = ""
                For Each dr As PagosDS.ArchiveroDigitalRow In dsPagos.ArchiveroDigital
                    If Not dr.IsIdGastoNull Then DocumentosPolizas = dr.IdGasto
                    If Not dr.IsIdRequisicionNull Then DocumentosPolizas = DocumentosPolizas & IIf(DocumentosPolizas.Length > 0, ",", "") & dr.IdRequisicion
                    If Not dr.IsIdOrdenTitNull Then DocumentosPolizas = DocumentosPolizas & IIf(DocumentosPolizas.Length > 0, ",", "") & dr.IdOrdenTit
                    If Not dr.IsIdRecepcionTitNull Then DocumentosPolizas = DocumentosPolizas & IIf(DocumentosPolizas.Length > 0, ",", "") & dr.IdRecepcionTit
                    If Not dr.IsIdContrareciboTitNull Then DocumentosPolizas = DocumentosPolizas & IIf(DocumentosPolizas.Length > 0, ",", "") & dr.IdContrareciboTit
                    If Not dr.IsIdPagoTitNull Then DocumentosPolizas = DocumentosPolizas & IIf(DocumentosPolizas.Length > 0, ",", "") & dr.IdPagoTit

                    'DocumentosPolizas = DocumentosPolizas & IIf(dr.IsIdGastoNull, "''", dr.IdGasto) & _
                    '                                        IIf(dr.IsIdRequisicionNull, "", "," & dr.IdRequisicion) & _
                    '                                        IIf(dr.IsIdOrdenTitNull, "", "," & dr.IdOrdenTit) & _
                    '                                        IIf(dr.IsIdRecepcionTitNull, "", "," & dr.IdRecepcionTit) & _
                    '                                        IIf(dr.IsIdContrareciboTitNull, "", "," & dr.IdContrareciboTit) & _
                    '                                        IIf(dr.IsIdPagoTitNull, "", "," & dr.IdPagoTit)
                Next
                fxList = New FunctionSQL("Treasury", "fxPagosArchiveroDigPolizas", Connection, Transaction)
                fxList.Parameters.Add("@FechaIni", DbType.DateTime).Value = FechaIni.ToShortDateString
                fxList.Parameters.Add("@FechaFin", DbType.DateTime).Value = FechaFin.ToShortDateString
                fxList.Parameters.Add("@IdsDocumentos", DbType.String).Value = Replace(DocumentosPolizas, "'',", "")
                fxList.FillDataTable(dsPagos.ArchiveroPolizas)
            End If
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el Archivero Digital de pagos.", ex)
        End Try
        Return dsPagos

    End Function

    Public Sub Generar(IdCaja As Integer, PagosTable As PagosDS.PagosDataTable, ContrarecibosSelTable As PagosDS.ContrarecibosPorPagarDataTable)
        Try


        Catch ex As Exception
            Throw New BusinessException("Error al generar los pagos", ex)
        End Try
    End Sub
End Class


Partial Class PagoFacade
    Public Function LoadPrint(ByVal sessionID As Guid, IdPagoTit As String) As InformesDS.PagoRPTDataTable
        ValidateSession(sessionID)
        Dim dtList As New InformesDS.PagoRPTDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PagoService(sessionID, Connection, Transaction)
            dtList = Svc.LoadPrint(IdPagoTit)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function LoadList(ByVal sessionID As Guid, ByVal FechaIni As Date, ByVal FechaFin As Date, ByVal IdCaja As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PagoService(sessionID, Connection, Transaction)
            dtList = Svc.LoadList(FechaIni, FechaFin, IdCaja)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function PendientesEmitidosList(ByVal sessionID As Guid, ByVal FechaIni As Date, ByVal FechaFin As Date, ByVal IdCaja As Integer) As PagosDS.ContrarecibosPorPagarDataTable
        ValidateSession(sessionID)
        Dim dtList As New PagosDS.ContrarecibosPorPagarDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PagoService(sessionID, Connection, Transaction)
            dtList = Svc.PendientesEmitidosList(FechaIni, FechaFin, IdCaja)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function PendientesVencidosList(ByVal sessionID As Guid, ByVal FechaIni As Date, ByVal FechaFin As Date, ByVal IdCaja As Integer) As PagosDS.ContrarecibosPorPagarDataTable
        ValidateSession(sessionID)
        Dim dtList As New PagosDS.ContrarecibosPorPagarDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PagoService(sessionID, Connection, Transaction)
            dtList = Svc.PendientesVencidosList(FechaIni, FechaFin, IdCaja)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function AntiguedadSaldos(sessionID As Guid, FechaIni As Date, FechaFin As Date, LapsoDias As Integer) As InformesDS.AntiguedadSaldosDataTable
        ValidateSession(sessionID)
        Dim dtList As New InformesDS.AntiguedadSaldosDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PagoService(sessionID, Connection, Transaction)
            dtList = Svc.AntiguedadSaldos(FechaIni, FechaFin, LapsoDias)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Sub Generar(ByVal sessionID As Guid, IdCaja As Integer, IdSucursal As Integer, PagosTable As PagosDS.PagosDataTable, ContrarecibosSelTable As PagosDS.ContrarecibosPorPagarDataTable)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Me.Transaction = Connection.BeginTransaction
                'Armamos el info de cada uno de los pagos y lo guardamos
                For Each rowHeader As PagosDS.PagosRow In PagosTable
                    Dim info As New PagoInfo(sessionID)
                    info.IdCaja = IdCaja
                    info.IdBeneficiario = rowHeader.IdBeneficiario
                    info.IdChequera = rowHeader.IdChequera
                    info.IdPagoTipo = rowHeader.IdPagoTipo
                    info.Monto = rowHeader.Total
                    info.IdSucursal = IdSucursal
                    'Asignaoms el detalle correspondiente detalle del pago
                    Dim dv As New DataView(ContrarecibosSelTable, "IdAgrupador=" & rowHeader.IdAgrupador, "", DataViewRowState.CurrentRows)
                    For Each dr As DataRowView In dv
                        Dim rowDetail As PagosDS.ContrarecibosPorPagarRow = CType(dr.Row, PagosDS.ContrarecibosPorPagarRow)
                        info.Details.AddDetalleRow(rowDetail.IdContrareciboTit, rowDetail.Total)
                    Next
                    Dim Svc As New PagoService(sessionID, Connection, Transaction)
                    info = Svc.Update(info)
                    Svc.ApplyWorkflow(info.Identity, WorkflowSteps.Apply, info.Fecha)
                Next
                Me.Transaction.Commit()
            Catch ex As Exception
                Me.Transaction.Rollback()
                Throw ex
            End Try
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub

    Public Function ArchiveroDigital(ByVal sessionID As Guid, FechaIni As Date, FechaFin As Date, IdGasto As String, SerieGasto As String, FacturaGasto As Integer, _
                                   IdRequisicion As String, IdOrdenTit As String, IdRecepcionTit As String, SerieRecep As String, FacturaRecep As Integer, _
                                   IdContrareciboTit As String, IdPago As String, IdChequera As Integer, FolioPago As Integer) As PagosDS
        ValidateSession(sessionID)
        Dim dtList As New PagosDS
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PagoService(sessionID, Connection, Transaction)
            dtList = Svc.ArchiveroDigital(FechaIni, FechaFin, IdGasto, SerieGasto, FacturaGasto, _
                                   IdRequisicion, IdOrdenTit, IdRecepcionTit, SerieRecep, FacturaRecep, _
                                   IdContrareciboTit, IdPago, IdChequera, FolioPago)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function
End Class
