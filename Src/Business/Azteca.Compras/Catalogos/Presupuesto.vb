Partial Class PresupuestoService

    Public Sub Autorizar(IdPresupuesto As Integer)
        Try
            Dim sp As New StoredProcedure("Purchasing", "PresupuestoAutoriza", Me.Connection, Me.Transaction)
            sp.Parameters.Add("@IdPresupuesto", DbType.Int32).Value = IdPresupuesto
            sp.Execute()
        Catch ex As Exception
            Throw New BusinessException("Error al Autorizar el Presupuesto.", ex)
        End Try
    End Sub

    Public Function fromPeriodoDeptoToID(ByVal idPeriodo As Integer, ByVal IdDepartamento As Integer) As Integer
        Try
            Dim fx As New FunctionSQL("Purchasing", "fxPresupuestosExistsFromPeriodoDepto", Me.Connection, Me.Transaction)
            fx.Parameters.Add("@IdPeriodo", DbType.Int32).Value = idPeriodo
            fx.Parameters.Add("@IdDepartamento", DbType.Int32).Value = IdDepartamento
            Return CInt(fx.GetScalar)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar los datos del Presupuesto.", ex)
        End Try
    End Function

    Public Function LoadList(ByVal idEmpresa As Integer) As DataTable
        Dim dt As New DataTable
        Try
            Dim fx As New FunctionSQL("Purchasing", "fxPresupuestosCBO", Connection, Transaction)
            fx.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            fx.FillDataTable(dt)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Presupuestos.", ex)
        End Try
        Return dt
    End Function

    Public Function LoadPrintInfo(ByVal IdPeriodo As Integer) As InformesDS.PresupuestosDataTable
        Dim dt As New InformesDS.PresupuestosDataTable
        Try
            Dim fx As New FunctionSQL("Purchasing", "fxPresupuestoRPT", Connection, Transaction)
            fx.Parameters.Add("@IdPeriodo", DbType.Int32).Value = IdPeriodo
            fx.Parameters.Add("@IdUsuario", DbType.Int32).Value = Session.User.Identity
            fx.FillDataTable(dt)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar los datos del informe de Presupuestos.", ex)
        End Try
        Return dt
    End Function
End Class

Partial Class PresupuestoFacade
    Public Sub Autorizar(ByVal sessionID As Guid, IdPresupuesto As Integer)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PresupuestoService(sessionID, Connection)
            Svc.Autorizar(IdPresupuesto)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub

    Public Function getFromPeriodoDepto(ByVal sessionID As Guid, ByVal idPeriodo As Integer, ByVal IdDepartamento As Integer, ByVal IdSucursal As Integer) As PresupuestoInfo
        ValidateSession(sessionID)
        Dim Presupuesto As New PresupuestoInfo(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PresupuestoService(sessionID, Connection)
            'Verificamos si el presupuesto ya fue autorizado
            Dim IdPresupuesto As Integer = Svc.fromPeriodoDeptoToID(idPeriodo, IdDepartamento)
            If IdPresupuesto > 0 Then
                Svc.GetDetail(IdPresupuesto, Presupuesto, False)
            Else
                'Enviamos un nuevo presupuesto en estatus G de guardado para su posterior autorizacion
                Dim DeptoSvc As New DepartamentoService(sessionID, Connection, Transaction)
                Dim DeptoInfo As New DepartamentoInfo(sessionID)
                DeptoSvc.GetDetail(IdDepartamento, DeptoInfo, False)

                Presupuesto.Estatus = "G"
                Presupuesto.IdPeriodo = idPeriodo
                Presupuesto.IdDepartamento = IdDepartamento : Presupuesto.Status = CatalogState.Active : Presupuesto.IdSucursal = IdSucursal
                Presupuesto._TipoPresupuesto = DeptoInfo.TipoAdmonPresupuesto
                If Presupuesto.TipoPresupuesto = TipoAdmonPresupuestoEnum.Categorizado Then Svc.LoadCategorias(Presupuesto)
            End If
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Presupuesto
    End Function


    Public Function LoadList(ByVal sessionID As Guid, ByVal idEmpresa As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtReturn As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PresupuestoService(sessionID, Connection)
            dtReturn = Svc.LoadList(idEmpresa)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtReturn
    End Function


    Public Function LoadPrintInfo(ByVal sessionID As Guid, ByVal idPeriodo As Integer) As InformesDS.PresupuestosDataTable
        ValidateSession(sessionID)
        Dim dtReturn As InformesDS.PresupuestosDataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PresupuestoService(sessionID, Connection)
            dtReturn = Svc.LoadPrintInfo(idPeriodo)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtReturn
    End Function
End Class