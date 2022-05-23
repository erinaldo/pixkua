Partial Class ContabilizadorDocumentosFacade
    Public Function loadWorkflowNew(ByVal sessionID As GUID, ByVal IdDocumentoTipo As Integer, ByVal info As ContabilizadorDocumentosInfo) As ContabilizadorDocumentosInfo
        ValidateSession(sessionID)
        Dim infoReturn As New ContabilizadorDocumentosInfo(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ContabilizadorDocumentosService(sessionID, Connection)
            infoReturn = Svc.loadWorkflowNew(IdDocumentoTipo, info)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return infoReturn
    End Function

    Public Function VariantesStatus(ByVal sessionID As GUID, ByVal IdVistaContableTit As Integer, ByVal IdContabilizacionDocumentoDet As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dt As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ContabilizadorDocumentosService(sessionID, Connection)
            dt = Svc.VariantesStatus(IdVistaContableTit, IdContabilizacionDocumentoDet)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dt
    End Function

    Public Sub CombinacionesSave(ByVal sessionID As GUID, ByVal IdCombinacionDocumentoDet As Integer, ByVal CombinacionesTable As DataTable)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New ContabilizadorDocumentosService(sessionID, Connection, Transaction)
                Svc.CombinacionesSave(IdCombinacionDocumentoDet, CombinacionesTable)
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

    Public Sub FiltrosSave(ByVal sessionID As GUID, ByVal IdCombinacionDocumentoDet As Integer, ByVal FiltrosTable As DataTable)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New ContabilizadorDocumentosService(sessionID, Connection, Transaction)
                Svc.FiltrosSave(IdCombinacionDocumentoDet, FiltrosTable)
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

    Public Function Filtrosload(ByVal sessionID As GUID, ByVal IdContabilizacionDocumentoDet As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dt As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ContabilizadorDocumentosService(sessionID, Connection)
            dt = Svc.Filtrosload(IdContabilizacionDocumentoDet)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dt
    End Function

End Class

Partial Class ContabilizadorDocumentosService
    Public Function loadWorkflowNew(ByVal IdDocumentoTipo As Integer, ByVal info As ContabilizadorDocumentosInfo) As ContabilizadorDocumentosInfo
        Try
            info.WorkflowTable = New ContabilizadorWorkflowDS.WorkflowContableDataTable
            Dim fx As New FunctionSQL("Accounting", "fxContabilizacionDocumentosDetSelNew", Connection, Transaction)
            fx.Parameters.Add("@IdDocumentoTipo", DbType.Int32).Value = IdDocumentoTipo
            fx.FillDataTable(info.WorkflowTable)
            Return info
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el flujo de trabajo", ex)
        End Try
    End Function

    Public Function VariantesStatus(ByVal IdVistaContableTit As Integer, ByVal IdContabilizacionDocumentoDet As Integer) As DataTable
        Dim dt As New DataTable
        Try
            Dim fx As New FunctionSQL("Accounting", "fxContabilizacionVariantesSEL", Connection, Transaction)
            fx.Parameters.Add("@IdVistaContableTit", DbType.Int32).Value = IdVistaContableTit
            fx.Parameters.Add("@IdContabilizacionDocumentoDet", DbType.Int32).Value = IdContabilizacionDocumentoDet
            dt = fx.GetTable
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el flujo de trabajo", ex)
        End Try
        Return dt
    End Function

    Public Sub CombinacionesSave(ByVal IdCombinacionDocumentoDet As Integer, ByVal CombinacionesTable As DataTable)
        Try
            Dim cmd As New DbCommand("Accounting.ContabilizacionCombinacionesUPD", Me.Connection, Me.Transaction)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@IdContabilizacionCombinacion", DbType.Int32, "IdContabilizacionCombinacion")
            cmd.Parameters.Add("@IdContabilizacionDocumentoDet", DbType.Int32).Value = IdCombinacionDocumentoDet
            cmd.Parameters.Add("@IdEntidad", DbType.Int32, "IdEntidad")
            cmd.Parameters.Add("@Sel", DbType.Int32, "SEL")

            Dim da As New Azteca.Data.DataAdapter
            da.UpdateCommand = cmd
            da.Update(CombinacionesTable)

            Dim dv As New DataView(CombinacionesTable, "IdContabilizacionCombinacion=0 And idEntidad>0", "", DataViewRowState.CurrentRows)

            'Actualizamos el filtro pivote en base a estas combinaciones
            Dim sp As New StoredProcedure("Accounting", "ContabilizacionDocumentosDetPivote", Connection, Transaction)
            sp.Parameters.Add("@IdContabilizacionDocumentoDet", DbType.Int32).Value = IdCombinacionDocumentoDet
            sp.Execute()

        Catch ex As Exception
            Throw New BusinessException("Error al cargar el flujo de trabajo", ex)
        End Try
    End Sub

    Public Function Filtrosload(ByVal IdContabilizacionDocumentoDet As Integer) As DataTable
        Dim dt As New DataTable
        Try
            Dim sp As New StoredProcedure("Accounting", "ContabilizacionFiltrosSEL", Connection, Transaction)
            sp.Parameters.Add("@IdContabilizacionDocumentoDet", DbType.Int32).Value = IdContabilizacionDocumentoDet
            dt = sp.GetTable
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el filtro con las combinaciones", ex)
        End Try
        Return dt
    End Function

    Public Sub FiltrosSave(ByVal IdCombinacionDocumentoDet As Integer, ByVal FiltrosTable As DataTable)
        Try
            Dim sp As New StoredProcedure("Accounting", "ContabilizacionFiltrosDEL", Me.Connection, Me.Transaction)
            sp.Parameters.Add("@IdContabilizacionDocumentoDet", DbType.Int32).Value = IdCombinacionDocumentoDet
            sp.Execute()

            For Each dr As DataRow In FiltrosTable.Rows
                If dr.RowState <> DataRowState.Modified Then dr.SetModified()
            Next

            Dim cmd As New DbCommand("Accounting.ContabilizacionFiltrosINS", Me.Connection, Me.Transaction)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@IdContabilizacionDocumentoDet", DbType.Int32).Value = IdCombinacionDocumentoDet
            cmd.Parameters.Add("@Filtro", DbType.String, "Filtro")
            cmd.Parameters.Add("@IdRacTit", DbType.Int32, "IdRacTit")

            Dim da As New Azteca.Data.DataAdapter
            da.InsertCommand = cmd : da.UpdateCommand = cmd
            da.Update(FiltrosTable)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el flujo de trabajo", ex)
        End Try
    End Sub
End Class