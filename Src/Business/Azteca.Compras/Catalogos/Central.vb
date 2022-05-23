Imports Azteca.Kernel

Partial Class CentralService
    Public Function CargarUsuarioAccesos(ByVal idUsuario As Integer) As UsuariosAccesoDS.CentralesDataTable
        Try
            Dim fx As New FunctionSQL("Purchasing", "fxUsuarioCentralSEL", Connection, Transaction)
            fx.Parameters.Add("@IdUsuario", DbType.Int32).Value = idUsuario
            Dim dt As New UsuariosAccesoDS.CentralesDataTable
            fx.FillDataTable(dt)
            Return dt
        Catch ex As Exception
            Throw New BusinessException("Error al cargar los accesos del usuario: " & idUsuario.ToString, ex)
        End Try
    End Function

    Public Sub GuardarUsuarioAccesos(ByVal idUsuario As Integer, ByVal dtCentrosRecep As UsuariosAccesoDS.CentralesDataTable)
        Try
            Dim comUpdate As New DbCommand("Purchasing.UsuarioCentralUPD", Connection, Transaction)
            comUpdate.CommandType = CommandType.StoredProcedure
            comUpdate.Parameters.Add("@IdCentral", DbType.Int32, "IdCentral")
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


    Public Function GetDetailFromCache(idCentral As Integer) As CentralInfo
        Try
            Dim CacheKey As String = "Purchasing_Centrales" & idCentral.ToString
            Dim Central As New CentralInfo(SessionID)
            If Not Cache.Contains(CacheKey) Then
                Dim CentralSvc As New CentralService(SessionID, Connection, Transaction)
                CentralSvc.GetDetail(idCentral, Central, False)
                Cache.Add(CacheKey, Central, TimeSpan.FromDays(1))
            Else
                Central = CType(Cache.Item(CacheKey), CentralInfo)
            End If
            Return Central
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la información de la central: " & idCentral & " desde el caché")
        End Try
    End Function

    Public Function List(ByVal idEmpresa As Integer) As ConfiguracionDS.CentralesDataTable
        Dim dt As New ConfiguracionDS.CentralesDataTable
        Try
            Dim fx As New FunctionSQL("Purchasing", "fxCentralesListSEL", Connection, Transaction)
            fx.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            fx.FillDataTable(dt)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Centrales.", ex)
        End Try
        Return dt
    End Function

    Public Sub UpdateList(ByVal idEmpresa As Integer, ByVal idSucursal As Integer, ByVal CentralesTable As ConfiguracionDS.CentralesDataTable)
        Try
            Dim da As New DataAdapter
            Dim cmd As New Azteca.Data.DbCommand("Purchasing.CentralesUPD", Me.Connection, Me.Transaction)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Id", DbType.Int32, "IdCentral")
            cmd.Parameters.Add("@Codigo", DbType.String, "IdCentral")
            cmd.Parameters.Add("@Nombre", DbType.String, "Nombre")
            cmd.Parameters.Add("@IdRemitente", DbType.Int32, "IdRemitente")
            cmd.Parameters.Add("@IdOperador", DbType.Int32, "IdOperador")
            cmd.Parameters.Add("@EnviarOC", DbType.Boolean, "EnviarOC")
            cmd.Parameters.Add("@NotificarOC", DbType.Boolean, "NotificarOC")
            cmd.Parameters.Add("@IdCuenta", DbType.Int32, "IdCuenta")

            cmd.Parameters.Add("@IdStatus", DbType.Int32).Value = 1
            cmd.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            cmd.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            cmd.Parameters.Add("@LastUpdate", DbType.DateTime).Value = Date.Today
            cmd.Parameters.Add("@PCUpdate", DbType.String).Value = Session.WorkStation
            cmd.Parameters.Add("@UserUpdate", DbType.Int32).Value = Session.User.Identity

            Dim cmdDEL As New Azteca.Data.DbCommand("Purchasing.CentralesDEL", Me.Connection, Me.Transaction)
            cmdDEL.Parameters.Add("@Id", DbType.Int32, "IdCentral")
            cmdDEL.CommandType = CommandType.StoredProcedure

            da.UpdateCommand = cmd : da.InsertCommand = cmd : da.DeleteCommand = cmdDEL
            da.Update(CentralesTable)

        Catch ex As Exception
            Throw New Exception("Problemas al intentar guardar las Centrales de Compras", ex)
        End Try

    End Sub
End Class

Partial Class CentralFacade
    Public Function CargarUsuarioAccesos(ByVal sessionID As Guid, ByVal idUsuario As Integer) As UsuariosAccesoDS.CentralesDataTable
        ValidateSession(sessionID)
        Dim dt As New UsuariosAccesoDS.CentralesDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CentralService(sessionID, Connection)
            dt = Svc.CargarUsuarioAccesos(idUsuario)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dt
    End Function

    Public Sub GuardarUsuarioAccesos(ByVal sessionID As Guid, ByVal idUsuario As Integer, ByVal dtCentralesCompra As UsuariosAccesoDS.CentralesDataTable)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New CentralService(sessionID, Connection, Transaction)
                Svc.GuardarUsuarioAccesos(idUsuario, dtCentralesCompra)
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

    Public Function List(ByVal sessionID As Guid, ByVal idEmpresa As Integer) As ConfiguracionDS.CentralesDataTable
        ValidateSession(sessionID)
        Dim dtProveedores As ConfiguracionDS.CentralesDataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CentralService(sessionID, Connection)
            dtProveedores = Svc.List(idEmpresa)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtProveedores
    End Function

    Public Sub UpdateList(ByVal sessionID As Guid, ByVal idEmpresa As Integer, ByVal idSucursal As Integer, ByVal CentralesTable As ConfiguracionDS.CentralesDataTable)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CentralService(sessionID, Connection)
            Svc.UpdateList(idEmpresa, idSucursal, CentralesTable)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub

End Class