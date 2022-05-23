Partial Class GastoService
    Public Function LoadPrintInfo(IdGasto As String) As InformesDS.GastosDataTable
        Dim dtList As New InformesDS.GastosDataTable
        Try
            Dim fxList As New FunctionSQL("Purchasing", "fxGastosRPT", Connection, Transaction)
            fxList.Parameters.Add("@IdGasto", DbType.String).Value = IdGasto
            fxList.FillDataTable(dtList)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar los datos del informe.", ex)
        End Try
        Return dtList
    End Function

    Public Function LoadList(ByVal FechaIni As Date, ByVal FechaFin As Date, ByVal IdUsuario As Integer, ByVal IdSucursal As Integer) As DataTable
        Dim dtList As DataTable = Nothing
        Try
            Dim fxList As New FunctionSQL("Purchasing", "fxGastosList", Connection, Transaction)
            fxList.Parameters.Add("@FechaIni", DbType.DateTime).Value = FechaIni
            fxList.Parameters.Add("@FechaFin", DbType.DateTime).Value = FechaFin
            fxList.Parameters.Add("@IdUsuario", DbType.Int32).Value = IdUsuario
            fxList.Parameters.Add("@IdSucursal", DbType.Int32).Value = IdSucursal
            dtList = fxList.GetTable
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de gastos.", ex)
        End Try
        Return dtList
    End Function

    Public Overloads Sub Update(idSucursal As Integer, Modalidad As String, TipoBeneficiario As String, IdBeneficiario As Integer, idDepartamento As Integer, idPresupuesto As Integer, _
                                idMoneda As Integer, Observaciones As String, GastosTable As GastosDS.DetalleDataTable, Impuestos As DataTable, Retenciones As DataTable)
        Try
            'Generar las requisiciones de los artículos
            For Each drGasto As GastosDS.DetalleRow In GastosTable
                Dim cont As Integer = 1
                If drGasto.RowState = DataRowState.Deleted Then Continue For
                Dim Gasto As New GastoInfo(SessionID)
                With Gasto
                    .Fecha = Date.Today
                    .IdDepartamento = idDepartamento
                    .IdGastoConcepto = drGasto.IdGastoConcepto
                    .IdPresupuesto = idPresupuesto
                    .IdCategoriaPresupuestal = drGasto.IdCategoriaPresupuestal
                    .IdDivisa = idMoneda
                    .TipoCambio = 0
                    .ModalidadPago = Modalidad ' CStr(IIf(optComprobacion.Checked, "C", "R"))
                    .IdBeneficiario = IdBeneficiario : .TipoBeneficiario = TipoBeneficiario
                    .Notas = Observaciones
                    .IdProveedor = drGasto.IdProveedor
                    .SerieFactura = drGasto.Serie
                    .FolioFactura = drGasto.Factura
                    .AnioAprobacion = drGasto.AnioAprobacion
                    .NumAprobacion = drGasto.NumAprobacion
                    .SubTotal = drGasto.Subtotal
                    .IdCategoriaPresupuestal = drGasto.IdCategoriaPresupuestal
                    .IdSucursal = idSucursal
                    For Each dr As DataRowView In New DataView(Impuestos, "Partida=" & drGasto.Partida, "", DataViewRowState.CurrentRows)
                        If cont = 1 And CDec(dr("Monto")) > 0 Then
                            .IdImpuesto1 = CInt(dr("IdImpuesto")) : .PorcImp1 = CDec(dr("Porcentaje")) / 100 : .MontoImp1 = CDec(dr("Monto")) : cont = cont + 1
                        ElseIf cont = 2 And CDec(dr("Monto")) > 0 Then
                            .IdImpuesto2 = CInt(dr("IdImpuesto")) : .PorcImp2 = CDec(dr("Porcentaje")) / 100 : .MontoImp2 = CDec(dr("Monto")) : cont = cont + 1
                        ElseIf cont = 3 And CDec(dr("Monto")) > 0 Then
                            .IdImpuesto3 = CInt(dr("IdImpuesto")) : .PorcImp3 = CDec(dr("Porcentaje")) / 100 : .MontoImp3 = CDec(dr("Monto")) : cont = cont + 1
                        End If
                    Next
                    cont = 1
                    For Each dr As DataRowView In New DataView(Retenciones, "Partida=" & drGasto.Partida, "", DataViewRowState.CurrentRows)
                        If cont = 1 And CDec(dr("Monto")) > 0 Then
                            .IdRetencion1 = CInt(dr("IdRetencion")) : .PorcRetencion1 = CDec(dr("Porcentaje")) / 100 : .MontoRetencion1 = CDec(dr("Monto")) : cont = cont + 1
                        ElseIf cont = 2 And CDec(dr("Monto")) > 0 Then
                            .IdRetencion2 = CInt(dr("IdRetencion")) : .PorcRetencion2 = CDec(dr("Porcentaje")) / 100 : .MontoRetencion2 = CDec(dr("Monto")) : cont = cont + 1
                        ElseIf cont = 3 And CDec(dr("Monto")) > 0 Then
                            .IdRetencion3 = CInt(dr("IdRetencion")) : .PorcRetencion3 = CDec(dr("Porcentaje")) / 100 : .MontoRetencion3 = CDec(dr("Monto")) : cont = cont + 1
                        End If
                    Next

                    .Total = .SubTotal + .MontoImp1 + .MontoImp2 + .MontoImp3 - .MontoRetencion1 - .MontoRetencion2 - .MontoRetencion3
                End With

                Dim GastoSvc As New GastoService(SessionID, Connection, Transaction)
                Gasto = GastoSvc.Update(Gasto)
            Next
        Catch ex As Exception
            Throw New BusinessException("Error al guardar el lote de Gastos.", ex)
        End Try
    End Sub

End Class

Partial Class GastoFacade
    Public Function LoadPrintInfo(ByVal sessionID As Guid, ByVal IdGasto As String) As InformesDS.GastosDataTable
        ValidateSession(sessionID)
        Dim dtRet As New InformesDS.GastosDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New GastoService(sessionID, Connection, Transaction)
            dtRet = Svc.LoadPrintInfo(IdGasto)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtRet
    End Function

    Public Function LoadList(ByVal sessionID As Guid, ByVal FechaIni As Date, ByVal FechaFin As Date, ByVal IdUsuario As Integer, ByVal IdSucursal As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New GastoService(sessionID, Connection, Transaction)
            dtList = Svc.LoadList(FechaIni, FechaFin, IdUsuario, IdSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Overloads Sub Update(sessionID As Guid, idSucursal As Integer, Modalidad As String, TipoBeneficiario As String, IdBeneficiario As Integer, idDepartamento As Integer, _
                                idPresupuesto As Integer, idMoneda As Integer, Observaciones As String, GastosTable As GastosDS.DetalleDataTable, Impuestos As DataTable, Retenciones As DataTable)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New GastoService(sessionID, Connection, Transaction)
                Svc.Update(idSucursal, Modalidad, TipoBeneficiario, IdBeneficiario, idDepartamento, idPresupuesto, idMoneda, Observaciones, GastosTable, Impuestos, Retenciones)
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

End Class
