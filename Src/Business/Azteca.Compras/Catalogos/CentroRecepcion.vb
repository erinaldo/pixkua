Partial Class CentroRecepcionService

    Public Function CargarUsuarioAccesos(ByVal idUsuario As Integer) As UsuariosAccesoDS.CentrosRecepcionDataTable
        Try
            Dim fx As New FunctionSQL("Purchasing", "fxUsuarioCentroRecepcionSEL", Connection, Transaction)
            fx.Parameters.Add("@IdUsuario", DbType.Int32).Value = idUsuario
            Dim dt As New UsuariosAccesoDS.CentrosRecepcionDataTable
            fx.FillDataTable(dt)
            Return dt
        Catch ex As Exception
            Throw New BusinessException("Error al cargar los accesos del usuario: " & idUsuario.ToString, ex)
        End Try
    End Function

    Public Sub GuardarUsuarioAccesos(ByVal idUsuario As Integer, ByVal dtCentrosRecep As UsuariosAccesoDS.CentrosRecepcionDataTable)
        Try
            Dim comUpdate As New DbCommand("Purchasing.UsuarioCentroRecepcionUPD", Connection, Transaction)
            comUpdate.CommandType = CommandType.StoredProcedure
            comUpdate.Parameters.Add("@IdCentroRecepcion", DbType.Int32, "IdCentroRecepcion")
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


    Public Function List(ByVal idEmpresa As Integer) As ConfiguracionDS.CentrosRecepcionDataTable
        Dim dt As New ConfiguracionDS.CentrosRecepcionDataTable
        Try
            Dim fx As New FunctionSQL("Purchasing", "fxCentrosRecepcionListSEL", Connection, Transaction)
            fx.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            fx.FillDataTable(dt)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Centros de Recepción.", ex)
        End Try
        Return dt
    End Function

    Public Sub UpdateList(ByVal idEmpresa As Integer, ByVal idSucursal As Integer, ByVal CentrosRecepcionTable As ConfiguracionDS.CentrosRecepcionDataTable)
        Try
            Dim da As New DataAdapter
            Dim cmd As New Azteca.Data.DbCommand("Purchasing.CentrosRecepcionUPD", Me.Connection, Me.Transaction)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Id", DbType.Int32, "IdCentroRecepcion")
            cmd.Parameters.Add("@Codigo", DbType.String, "IdCentroRecepcion")
            cmd.Parameters.Add("@Nombre", DbType.String, "Nombre")
            cmd.Parameters.Add("@IdCuenta", DbType.Int32, "IdCuenta")
            cmd.Parameters.Add("@IdAlmacen", DbType.Int32, "IdAlmacen")
            cmd.Parameters.Add("@Calle", DbType.String, "Calle")
            cmd.Parameters.Add("@Colonia", DbType.String, "Colonia")
            cmd.Parameters.Add("@CP", DbType.String, "CP")
            cmd.Parameters.Add("@NumExt", DbType.String, "NumExt")
            cmd.Parameters.Add("@NumInt", DbType.String, "NumInt")
            cmd.Parameters.Add("@IdPoblacion", DbType.Int32, "IdPoblacion")
            cmd.Parameters.Add("@IdMunicipio", DbType.Int32, "IdMunicipio")
            cmd.Parameters.Add("@Tel1", DbType.String, "Tel1")
            cmd.Parameters.Add("@Tel2", DbType.String, "Tel2")
            cmd.Parameters.Add("@Fax", DbType.String, "Fax")

            cmd.Parameters.Add("@IdStatus", DbType.Int32).Value = 1
            cmd.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            cmd.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            cmd.Parameters.Add("@LastUpdate", DbType.DateTime).Value = Date.Today
            cmd.Parameters.Add("@PCUpdate", DbType.String).Value = Session.WorkStation
            cmd.Parameters.Add("@UserUpdate", DbType.Int32).Value = Session.User.Identity

            Dim cmdDEL As New Azteca.Data.DbCommand("Purchasing.CentrosRecepcionDEL", Me.Connection, Me.Transaction)
            cmdDEL.Parameters.Add("@Id", DbType.Int32, "IdCentroRecepcion")
            cmdDEL.CommandType = CommandType.StoredProcedure

            da.UpdateCommand = cmd : da.InsertCommand = cmd : da.DeleteCommand = cmdDEL
            da.Update(CentrosRecepcionTable)

        Catch ex As Exception
            Throw New Exception("Problemas al intentar guardar las Centro de Recepcion", ex)
        End Try

    End Sub

End Class

Partial Class CentroRecepcionFacade
    Public Function CargarUsuarioAccesos(ByVal sessionID As Guid, ByVal idUsuario As Integer) As UsuariosAccesoDS.CentrosRecepcionDataTable
        ValidateSession(sessionID)
        Dim dt As New UsuariosAccesoDS.CentrosRecepcionDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CentroRecepcionService(sessionID, Connection)
            dt = Svc.CargarUsuarioAccesos(idUsuario)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dt
    End Function

    Public Sub GuardarUsuarioAccesos(ByVal sessionID As Guid, ByVal idUsuario As Integer, ByVal dtCentrosRecepcion As UsuariosAccesoDS.CentrosRecepcionDataTable)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New CentroRecepcionService(sessionID, Connection, Transaction)
                Svc.GuardarUsuarioAccesos(idUsuario, dtCentrosRecepcion)
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

    Public Function List(ByVal sessionID As Guid, ByVal idEmpresa As Integer) As ConfiguracionDS.CentrosRecepcionDataTable
        ValidateSession(sessionID)
        Dim dtReturn As ConfiguracionDS.CentrosRecepcionDataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CentroRecepcionService(sessionID, Connection)
            dtReturn = Svc.List(idEmpresa)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtReturn
    End Function

    Public Sub UpdateList(ByVal sessionID As Guid, ByVal idEmpresa As Integer, ByVal idSucursal As Integer, ByVal CentrosRecepcionTable As ConfiguracionDS.CentrosRecepcionDataTable)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CentroRecepcionService(sessionID, Connection)
            Svc.UpdateList(idEmpresa, idSucursal, CentrosRecepcionTable)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub


End Class
