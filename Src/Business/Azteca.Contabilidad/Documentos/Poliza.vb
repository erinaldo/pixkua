Partial Class PolizaService

#Region "Monitor de polizas"

    Public Sub AplicarStatus(ByVal IdPolizaTit As String, ByVal idStatus As Integer, ByVal Mensaje As String)
        Try
            Me.ApplyWorkflow(IdPolizaTit, idStatus, Date.Today)

            If Mensaje.Length > 0 Then
                Dim sp As New StoredProcedure("Accounting", "PolizasLogINS", Me.Connection, Me.Transaction)
                sp.Parameters.Add("@IdPolizaTit", System.Data.DbType.String).Value = IdPolizaTit
                sp.Parameters.Add("@idStatus", System.Data.DbType.Int32).Value = idStatus
                sp.Parameters.Add("@Mensaje", System.Data.DbType.String).Value = Mensaje
                sp.Execute()
            End If
        Catch ex As Exception
            Throw New BusinessException(ex.ToString)
        End Try
    End Sub

    Public Function HistoricoLST(ByVal FechaIni As DateTime, ByVal FechaFin As DateTime, ByVal IdPolizaOrigen As Integer) As DataTable
        Dim dtPoliza As New DataTable 'ConcentradorBaseDS.DetalleDataTable
        Try
            Dim fx As New FunctionSQL("Accounting", "fxPolizasHistoricoList", Me.Connection, Me.Transaction)
            fx.Parameters.Add("@FechaIni", DbType.DateTime).Value = FechaIni.ToShortDateString
            fx.Parameters.Add("@FechaFin", DbType.DateTime).Value = FechaFin.ToShortDateString
            fx.Parameters.Add("@IdPolizaOrigen", DbType.Int32).Value = IdPolizaOrigen
            fx.FillDataTable(dtPoliza)
        Catch ex As Exception
            Throw New BusinessException(ex.ToString)
        End Try
        Return dtPoliza
    End Function

    Public Function ContpaqLogList(ByVal Fecha As DateTime, ByVal IdServicio As Integer) As DataTable
        Dim dtPoliza As New DataTable
        Try
            Dim fx As New FunctionSQL("Accounting", "fxPolizaContpaqLogList", Me.Connection, Me.Transaction)
            fx.Parameters.Add("@Fecha", DbType.DateTime).Value = Date.Today
            fx.Parameters.Add("@IdServicio", DbType.Int32).Value = IdServicio
            fx.FillDataTable(dtPoliza)
        Catch ex As Exception
            Throw New BusinessException(ex.ToString)
        End Try
        Return dtPoliza
    End Function

    Public Function PendientesPorEmpresa(ByVal FechaIni As DateTime, ByVal FechaFin As DateTime) As DataTable
        Dim dtEmpresas As New DataTable
        Try
            Dim fx As New FunctionSQL("Accounting", "fxEmpresasPolizasPendientesLST", Me.Connection, Me.Transaction)
            fx.Parameters.Add("@FechaIni", DbType.DateTime).Value = FechaIni.ToShortDateString
            fx.Parameters.Add("@FechaFin", DbType.DateTime).Value = FechaFin.ToShortDateString
            fx.FillDataTable(dtEmpresas)
        Catch ex As Exception
            Throw New BusinessException(ex.ToString)
        End Try
        Return dtEmpresas
    End Function

#End Region

#Region "Informes"
    Public Function InformesList(ByVal IdUsuario As Integer) As DataTable
        Dim dtPoliza As New DataTable
        Try
            Dim fx As New FunctionSQL("Accounting", "fxInformesCBO", Me.Connection, Me.Transaction)
            fx.Parameters.Add("@IdUsuario", DbType.Int32).Value = IdUsuario
            dtPoliza = fx.GetTable
        Catch ex As Exception
            Throw New BusinessException(ex.ToString)
        End Try
        Return dtPoliza
    End Function

    Public Function BalanceGral(ByVal IdEmpresa As Integer, ByVal IdEjercicioFiscalTit As String, ByVal Mes As Integer) As InformesDS.BalanceGralDataTable
        Dim dtPoliza As New InformesDS.BalanceGralDataTable
        Try
            Dim fx As New FunctionSQL("Accounting", "fxBalanceGralRPT", Me.Connection, Me.Transaction)
            fx.Parameters.Add("@IdEmpresa", DbType.Int32).Value = IdEmpresa
            fx.Parameters.Add("@IdEjercicioFiscalTit", DbType.String).Value = IdEjercicioFiscalTit
            fx.Parameters.Add("@Mes", DbType.Int32).Value = Mes
            fx.FillDataTable(dtPoliza)
        Catch ex As Exception
            Throw New BusinessException(ex.ToString)
        End Try
        Return dtPoliza
    End Function
    Public Function EstadoResultados(ByVal IdEmpresa As Integer, ByVal IdEjercicioFiscalTit As String, ByVal Mes As Integer) As InformesDS.EstadoResultadosDataTable
        Dim dtPoliza As New InformesDS.EstadoResultadosDataTable
        Try
        Dim fx As New FunctionSQL("Accounting", "fxEstadoResultadosRPT", Me.Connection, Me.Transaction)
        fx.Parameters.Add("@IdEmpresa", DbType.Int32).Value = IdEmpresa
        fx.Parameters.Add("@IdEjercicioFiscalTit", DbType.String).Value = IdEjercicioFiscalTit
        fx.Parameters.Add("@Mes", DbType.Int32).Value = Mes
        fx.FillDataTable(dtPoliza)
        Catch ex As Exception
            Throw New BusinessException(ex.ToString)
        End Try
        Return dtPoliza
    End Function
    Public Function InformeData(IdPolizaTit As String) As InformesDS.PolizaInformeDataTable
        Dim dtPoliza As New InformesDS.PolizaInformeDataTable
        Try
            Dim fx As New FunctionSQL("Accounting", "fxPolizaRPT", Me.Connection, Me.Transaction)
            fx.Parameters.Add("@IdPolizaTit", DbType.String).Value = IdPolizaTit
            fx.FillDataTable(dtPoliza)
        Catch ex As Exception
            Throw New BusinessException(ex.ToString)
        End Try
        Return dtPoliza
    End Function

#End Region

End Class

Partial Class PolizaFacade

#Region "Monitor de polizas"

    Public Sub AplicarStatus(ByVal sessionID As Guid, ByVal IdPolizaTit As String, ByVal idStatus As Integer, ByVal Mensaje As String)
        Try
            Connection = DataServices.OpenConnection
            Try
                Me.Transaction = Connection.BeginTransaction
                Dim Polizasvc As New PolizaService(sessionID, Connection, Transaction)
                Polizasvc.AplicarStatus(IdPolizaTit, idStatus, Mensaje)
                Me.Transaction.Commit()
            Catch exc As Exception
                Me.Transaction.Rollback()
                Throw exc
            End Try
        Catch ex As Exception
            Throw New Exception("Problemas al obtener el listado de Polizas", ex) 'HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub

    Public Function HistoricoLST(ByVal sessionID As GUID, ByVal FechaIni As DateTime, ByVal FechaFin As DateTime, ByVal IdPolizaOrigen As Integer) As DataTable
        Try
            Connection = DataServices.OpenConnection
            Try
                Dim Polizasvc As New PolizaService(sessionID, Connection, Transaction)
                Return Polizasvc.HistoricoLST(FechaIni, FechaFin, IdPolizaOrigen)
            Catch exc As Exception
                Throw exc
            End Try
        Catch ex As Exception
            Throw New Exception("Problemas al obtener el listado de Polizas", ex) 'HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Function

    Public Function ContpaqLogList(ByVal sessionID As GUID, ByVal Fecha As DateTime, ByVal IdServicio As Integer) As DataTable 'ConcentradorBaseDS.DetalleDataTable
        Try
            Connection = DataServices.OpenConnection
            Try
                Dim Polizasvc As New PolizaService(sessionID, Connection, Transaction)
                Return Polizasvc.ContpaqLogList(Fecha, IdServicio)
            Catch exc As Exception
                Throw exc
            End Try
        Catch ex As Exception
            Throw New Exception("Problemas al obtener el listado de Polizas", ex) 'HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Function

    Public Function PendientesPorEmpresa(ByVal sessionID As GUID, ByVal FechaIni As DateTime, ByVal FechaFin As DateTime) As DataTable
        Try
            Connection = DataServices.OpenConnection
            Try
                Dim Polizasvc As New PolizaService(sessionID, Connection, Transaction)
                Return Polizasvc.PendientesPorEmpresa(FechaIni, FechaFin)
            Catch exc As Exception
                Throw exc
            End Try
        Catch ex As Exception
            Throw New Exception("Problemas al obtener el listado de Polizas", ex) 'HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Function

#End Region

#Region "Informes"
    Public Function InformesList(ByVal sessionID As Guid, ByVal IdUsuario As Integer) As DataTable
        Try
            Connection = DataServices.OpenConnection
            Try
                Dim Polizasvc As New PolizaService(sessionID, Connection, Transaction)
                Return Polizasvc.InformesList(IdUsuario)
            Catch exc As Exception
                Throw exc
            End Try
        Catch ex As Exception
            Throw New Exception("Problemas al obtener la lista de los informes contables", ex) 'HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Function


    Public Function BalanceGral(ByVal sessionID As Guid, ByVal IdEmpresa As Integer, ByVal IdEjercicioFiscalTit As String, ByVal Mes As Integer) As InformesDS.BalanceGralDataTable
        Try
            Connection = DataServices.OpenConnection
            Try
                Dim Polizasvc As New PolizaService(sessionID, Connection, Transaction)
                Return Polizasvc.BalanceGral(IdEmpresa, IdEjercicioFiscalTit, Mes)
            Catch exc As Exception
                Throw exc
            End Try
        Catch ex As Exception
            Throw New Exception("Problemas al obtener los datos del informe del Balance Gral", ex) 'HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Function
    Public Function EstadoResultados(ByVal sessionID As Guid, ByVal IdEmpresa As Integer, ByVal IdEjercicioFiscalTit As String, ByVal Mes As Integer) As InformesDS.EstadoResultadosDataTable
        Try
            Connection = DataServices.OpenConnection
            Try
                Dim Polizasvc As New PolizaService(sessionID, Connection, Transaction)
                Return Polizasvc.EstadoResultados(IdEmpresa, IdEjercicioFiscalTit, Mes)
            Catch exc As Exception
                Throw exc
            End Try
        Catch ex As Exception
            Throw New Exception("Problemas al obtener los datos del informe de estado de resultados", ex) 'HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Function

    Public Function InformeData(ByVal sessionID As Guid, IdPolizaTit As String) As InformesDS.PolizaInformeDataTable
        Try
            Connection = DataServices.OpenConnection
            Try
                Dim Polizasvc As New PolizaService(sessionID, Connection, Transaction)
                Return Polizasvc.InformeData(IdPolizaTit)
            Catch exc As Exception
                Throw exc
            End Try
        Catch ex As Exception
            Throw New Exception("Problemas al obtener los datos del informe de Poliza", ex) 'HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Function
#End Region

End Class

Partial Class PolizaInfo

    Public Shared Sub InterfazContpaq(ByVal FileName As String, ByVal PolInfo As PolizaInfo, ByVal PreObservacion As String) ', _
        Dim ReferenciaAnt As String = ""
        Dim IdPolizaTipo As Integer = PolInfo.IdPolizaTipo
        Dim IdPolizaClase As String = "" ' getIdClasePoliza(ClasePoliza)
        Dim IdSistemaOrigen As String = "" 'getIdSistemaOrigenPoliza(SistemaOrigenPoliza)
        Dim idPolizaImpresa As String = "" 'IIf(PolizaImpresa, "1", "2")

        Dim myStreamWriter As System.IO.StreamWriter = Nothing

        Dim sConcepto As String = "" 'Se guarda el concepto para repetirlo en todos los movimientos (solicitud de Tesoreria y contabilidad)

        Try
            'Se crea el archivo
            If System.IO.File.Exists(FileName) Then
                myStreamWriter = System.IO.File.AppendText(FileName)  'System.IO.File.CreateText(FileName)
                myStreamWriter.Write(ControlChars.CrLf)
            Else
                myStreamWriter = System.IO.File.CreateText(FileName)   'System.IO.File.CreateText(FileName)
                myStreamWriter.Write("F" & ControlChars.CrLf)
            End If

            Dim dv As New DataView(PolInfo.Details, "", "Referencia,Orden", DataViewRowState.CurrentRows)
            For Each drPol As DataRowView In dv
                Dim drItem As PolizasDS.PolizasDetRow = CType(drPol.Row, PolizasDS.PolizasDetRow)

                'Para cada referencia
                If ReferenciaAnt <> drItem.Referencia Then ''or dritem.status<>IdStatuaAnt then
                    'Se arma la cadena de datos para el TITULO de La referencia actual
                    Dim Linea As String = "P " & Format(PolInfo.Fecha, "yyyyMMdd") & " " & IdPolizaTipo & " "  '1-13
                    Linea = Linea & Space(8 - PolInfo.Folio.ToString.Length) & PolInfo.Folio & " " & IdPolizaClase & " " & Space(4)
                    Linea = Linea & PreObservacion & drItem.Observaciones & Space(100 - CStr(PreObservacion & drItem.Observaciones).Length) & " " & IdSistemaOrigen & " " & idPolizaImpresa & " " 'Nombre-Concepto de la Poliza

                    myStreamWriter.Write(Linea & ControlChars.CrLf)
                End If

                'Se arma la cadena de datos para el DETALLE de La Referencia actual
                Dim Detalle As String
                If drItem.IdSegmento = 0 Then
                    Detalle = "N " & Space(2 - drItem.IdSegmento.ToString.Length) & drItem.IdSegmento & ControlChars.CrLf
                    Detalle = Detalle & "M " & CuentaSinGuiones(drItem.Cuenta) & Space(20 - CStr(CuentaSinGuiones(drItem.Cuenta)).Length) & " "
                Else
                    Detalle = "M " & CuentaSinGuiones(drItem.Cuenta) & Space(20 - CStr(CuentaSinGuiones(drItem.Cuenta)).Length) & " "
                End If

                Detalle = Detalle & Space(10 - drItem.Referencia.ToString.Length) & drItem.Referencia & " " 'Referencia
                Detalle = Detalle & CStr(IIf(drItem.Cargo <> 0, "1 ", "2 "))
                Detalle = Detalle & CStr(IIf(drItem.Cargo <> 0, Space(16 - Format(drItem.Cargo, "############0.00").Length) & Format(drItem.Cargo, "############0.00"), _
                                                          Space(16 - Format(drItem.Abono, "############0.00").Length) & Format(drItem.Abono, "############0.00")) & Space(5))
                Detalle = Detalle & CStr(IIf(drItem.Cargo <> 0, Space(16 - Format(0, "############0.00").Length) & Format(0, "############0.00"), _
                                                          Space(16 - Format(0, "############0.00").Length) & Format(0, "############0.00")) & " ")

                sConcepto = drItem.Observaciones

                If Len(sConcepto) > 30 Then
                    Detalle = Detalle & Mid(sConcepto, 1, 30)
                Else
                    Detalle = Detalle & sConcepto & Space(30 - CStr(sConcepto).Length) & " "
                End If

                myStreamWriter.Write(Detalle & ControlChars.CrLf)

                ReferenciaAnt = drItem.Referencia

            Next
            myStreamWriter.Flush()
        Catch exc As Exception
            ' Show the error to the user.
            Throw New Exception("Error al generar el Archivo de Interfaz", exc)
        Finally
            ' Close the object if it has been created.
            If Not myStreamWriter Is Nothing Then
                myStreamWriter.Close()
            End If
        End Try
    End Sub

    Private Shared Function CuentaSinGuiones(ByVal Cuenta As String) As String
        Return Cuenta.Replace("-", "").Trim
    End Function

End Class