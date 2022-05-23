Imports Azteca.Kernel

Partial Class DepartamentoService
    Public Function CargarUsuarioAccesos(ByVal idUsuario As Integer) As UsuariosAccesoDS.DepartamentosDataTable
        Try
            Dim fx As New FunctionSQL("Purchasing", "fxUsuarioDepartamentoSEL", Connection, Transaction)
            fx.Parameters.Add("@IdUsuario", DbType.Int32).Value = idUsuario
            Dim dt As New UsuariosAccesoDS.DepartamentosDataTable
            fx.FillDataTable(dt)
            Return dt
        Catch ex As Exception
            Throw New BusinessException("Error al cargar los accesos del usuario: " & idUsuario.ToString, ex)
        End Try
    End Function

    Public Sub GuardarUsuarioAccesos(ByVal idUsuario As Integer, ByVal dtCentrosRecep As UsuariosAccesoDS.DepartamentosDataTable)
        Try
            Dim comUpdate As New DbCommand("Purchasing.UsuarioDepartamentoUPD", Connection, Transaction)
            comUpdate.CommandType = CommandType.StoredProcedure
            comUpdate.Parameters.Add("@IdDepartamento", DbType.Int32, "IdDepartamento")
            comUpdate.Parameters.Add("@IdUsuario", DbType.Int32).Value = idUsuario
            comUpdate.Parameters.Add("@Selected", DbType.Boolean, "Selected")
            '
            Dim da As New DataAdapter()
            da.UpdateCommand = comUpdate
            da.Update(dtCentrosRecep)
        Catch concurrencyEx As DBConcurrencyException

        Catch ex As Exception
            Throw New BusinessException("Error al guardar los accesos del usuario: " & idUsuario.ToString, ex)
        End Try
    End Sub

    Public Function GetDetailFromCache(idDepartamento As Integer) As DepartamentoInfo
        Try
            Dim Departamento As New DepartamentoInfo(SessionID)
            Dim CacheKey As String = "Purchasing_Departamentos" & idDepartamento.ToString
            If Not Cache.Contains(CacheKey) Then
                Dim Svc As New DepartamentoService(SessionID, Connection, Transaction)
                Svc.GetDetail(idDepartamento, Departamento, False)
                Cache.Add(CacheKey, Departamento, TimeSpan.FromDays(1))
            Else
                Departamento = CType(Cache.Item(CacheKey), DepartamentoInfo)
            End If
            Return Departamento
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la información del departamento " & idDepartamento & " del caché.", ex)
        End Try
    End Function

    Public Function HasAccess(ByVal idDepartmento As Integer, IdUsuario As Integer) As Boolean
        Try
            Dim fx As New FunctionSQL("Purchasing", "fxDepartamentosUserAcceso", Connection, Transaction)
            fx.Parameters.Add("@IdDepartmento", DbType.Int32).Value = idDepartmento
            fx.Parameters.Add("@IdUsuario", DbType.Int32).Value = IdUsuario
            Return CBool(fx.GetScalar)
        Catch ex As Exception
            Throw New BusinessException("Error al validar el acceso al Departamento.", ex)
        End Try
    End Function

    Public Function PresupuestosActivos(ByVal IdDepartamento As Integer) As DataTable
        Dim dt As New DataTable
        Try
            Dim fx As New FunctionSQL("Purchasing", "fxDepartamentosPresupActivos", Connection, Transaction)
            fx.Parameters.Add("@IdDepartamento", DbType.Int32).Value = IdDepartamento
            fx.FillDataTable(dt)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Presupuestos activos para el departamento.", ex)
        End Try
        Return dt
    End Function

    Public Function LoadConceptos(ByVal idDepartmento As Integer) As DataTable
        Dim dt As New DataTable
        Try
            Dim fx As New FunctionSQL("Purchasing", "fxDepartamentosGastosConceptosSEL", Connection, Transaction)
            fx.Parameters.Add("@IdDepartmento", DbType.Int32).Value = idDepartmento
            fx.FillDataTable(dt)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Conceptos.", ex)
        End Try
        Return dt
    End Function

    Public Function LoadList(idEmpresa As Integer, ByVal idUsuario As Integer) As DataTable
        Dim dt As New DataTable
        Try
            Dim fx As New FunctionSQL("Purchasing", "fxDepartamentosCBO", Connection, Transaction)
            fx.Parameters.Add("@IdUsuario", DbType.Int32).Value = idUsuario
            fx.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            fx.FillDataTable(dt)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Departamentos.", ex)
        End Try
        Return dt
    End Function

    Public Function AccesosList(ByVal idDepartamento As Integer) As ConfiguracionDS.DepartamentosAccesosDataTable
        Dim dt As New ConfiguracionDS.DepartamentosAccesosDataTable
        Try
            Dim fx As New FunctionSQL("Purchasing", "fxDepartamentosAccesosSEL", Connection, Transaction)
            fx.Parameters.Add("@IdDepartamento", DbType.Int32).Value = idDepartamento
            fx.FillDataTable(dt)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Departamentos.", ex)
        End Try
        Return dt
    End Function

    Public Sub AccesosSave(ByVal sessionID As Guid, ByVal idDepartamento As Integer, ByVal AccesosTable As ConfiguracionDS.DepartamentosAccesosDataTable)
        Try
            Dim da As New DataAdapter
            Dim cmd As New Azteca.Data.DbCommand("Purchasing.DepartamentosAccesosSave", Me.Connection, Me.Transaction)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@IdDepartamento", DbType.Int32).Value = idDepartamento
            cmd.Parameters.Add("@IdUsuario", DbType.Int32, "IdUsuario")
            cmd.Parameters.Add("@PCUpdate", DbType.String).Value = Session.WorkStation
            cmd.Parameters.Add("@UserUpdate", DbType.Int32).Value = Session.User.Identity

            Dim cmdDEL As New Azteca.Data.DbCommand("Purchasing.DepartamentosAccesosDEL", Me.Connection, Me.Transaction)
            cmdDEL.Parameters.Add("@IdDepartamento", DbType.Int32).Value = idDepartamento
            cmdDEL.Parameters.Add("@IdUsuario", DbType.Int32, "IdUsuario")
            cmdDEL.CommandType = CommandType.StoredProcedure

            da.UpdateCommand = cmd : da.InsertCommand = cmd : da.DeleteCommand = cmdDEL
            da.Update(AccesosTable)

        Catch ex As Exception
            Throw New Exception("Problemas al intentar guardar los accesos a los departamentos", ex)
        End Try
    End Sub

    Public Function CentrosRecepcionList(ByVal idDepartamento As Integer) As ConfiguracionDS.DepartamentosCentrosRecepcionDataTable
        Dim dt As New ConfiguracionDS.DepartamentosCentrosRecepcionDataTable
        Try
            Dim fx As New FunctionSQL("Purchasing", "fxDepartamentosCentrosRecepcionSEL", Connection, Transaction)
            fx.Parameters.Add("@IdDepartamento", DbType.Int32).Value = idDepartamento
            fx.FillDataTable(dt)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Departamentos.", ex)
        End Try
        Return dt
    End Function

    Public Sub CentrosRecepcionSave(ByVal sessionID As Guid, ByVal idDepartamento As Integer, ByVal AccesosTable As ConfiguracionDS.DepartamentosCentrosRecepcionDataTable)
        Try
            Dim da As New DataAdapter
            Dim cmd As New Azteca.Data.DbCommand("Purchasing.DepartamentosCentrosRecepcionSave", Me.Connection, Me.Transaction)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@IdDepartamento", DbType.Int32).Value = idDepartamento
            cmd.Parameters.Add("@IdCentroRecepcion", DbType.Int32, "IdCentroRecepcion")
            cmd.Parameters.Add("@PCUpdate", DbType.String).Value = Session.WorkStation
            cmd.Parameters.Add("@UserUpdate", DbType.Int32).Value = Session.User.Identity

            Dim cmdDEL As New Azteca.Data.DbCommand("Purchasing.DepartamentosCentrosRecepcionDEL", Me.Connection, Me.Transaction)
            cmdDEL.Parameters.Add("@IdDepartamento", DbType.Int32).Value = idDepartamento
            cmdDEL.Parameters.Add("@IdCentroRecepcion", DbType.Int32, "IdCentroRecepcion")
            cmdDEL.CommandType = CommandType.StoredProcedure

            da.UpdateCommand = cmd : da.InsertCommand = cmd : da.DeleteCommand = cmdDEL
            da.Update(AccesosTable)

        Catch ex As Exception
            Throw New Exception("Problemas al intentar guardar los Centros de Recepcion del departamento", ex)
        End Try
    End Sub

End Class

Partial Class DepartamentoFacade

    Public Function CargarUsuarioAccesos(ByVal sessionID As Guid, ByVal idUsuario As Integer) As UsuariosAccesoDS.DepartamentosDataTable
        ValidateSession(sessionID)
        Dim dt As New UsuariosAccesoDS.DepartamentosDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New DepartamentoService(sessionID, Connection)
            dt = Svc.CargarUsuarioAccesos(idUsuario)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dt
    End Function

    Public Sub GuardarUsuarioAccesos(ByVal sessionID As Guid, ByVal idUsuario As Integer, ByVal dtDepartamentos As UsuariosAccesoDS.DepartamentosDataTable)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New DepartamentoService(sessionID, Connection, Transaction)
                Svc.GuardarUsuarioAccesos(idUsuario, dtDepartamentos)
                DataServices.CommitTransaction(Transaction)
            Catch exc As Exception
                DataServices.RollbackTransaction(Transaction)
                Throw exc
            End Try
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub


    Public Function HasAccess(ByVal sessionID As Guid, ByVal idDepartamento As Integer, IdUsuario As Integer) As Boolean
        ValidateSession(sessionID)
        Dim valueRet As Boolean = False
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New DepartamentoService(sessionID, Connection)
            valueRet = Svc.HasAccess(idDepartamento, IdUsuario)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return valueRet
    End Function


    Public Function PresupuestosActivos(ByVal sessionID As Guid, ByVal idDepartamento As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtReturn As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New DepartamentoService(sessionID, Connection)
            dtReturn = Svc.PresupuestosActivos(idDepartamento)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtReturn
    End Function

    Public Function LoadConceptos(ByVal sessionID As Guid, ByVal idDepartamento As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtReturn As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New DepartamentoService(sessionID, Connection)
            dtReturn = Svc.loadConceptos(idDepartamento)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtReturn
    End Function

    Public Function LoadList(ByVal sessionID As Guid, idEmpresa As Integer, ByVal idUsuario As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtReturn As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New DepartamentoService(sessionID, Connection)
            dtReturn = Svc.LoadList(idUsuario, idEmpresa)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtReturn
    End Function


    Public Function AccesosList(ByVal sessionID As Guid, ByVal idDepartamento As Integer) As ConfiguracionDS.DepartamentosAccesosDataTable
        ValidateSession(sessionID)
        Dim dtReturn As ConfiguracionDS.DepartamentosAccesosDataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New DepartamentoService(sessionID, Connection)
            dtReturn = Svc.AccesosList(idDepartamento)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtReturn
    End Function

    Public Sub AccesosSave(ByVal sessionID As Guid, ByVal idDepartamento As Integer, ByVal AccesosTable As ConfiguracionDS.DepartamentosAccesosDataTable)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New DepartamentoService(sessionID, Connection)
            Svc.AccesosSave(sessionID, idDepartamento, AccesosTable)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub


    Public Function CentrosRecepcionList(ByVal sessionID As Guid, ByVal idDepartamento As Integer) As ConfiguracionDS.DepartamentosCentrosRecepcionDataTable
        ValidateSession(sessionID)
        Dim dtReturn As ConfiguracionDS.DepartamentosCentrosRecepcionDataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New DepartamentoService(sessionID, Connection)
            dtReturn = Svc.CentrosRecepcionList(idDepartamento)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtReturn
    End Function

    Public Sub CentrosRecepcionSave(ByVal sessionID As Guid, ByVal idDepartamento As Integer, ByVal AccesosTable As ConfiguracionDS.DepartamentosCentrosRecepcionDataTable)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New DepartamentoService(sessionID, Connection)
            Svc.CentrosRecepcionSave(sessionID, idDepartamento, AccesosTable)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub

End Class