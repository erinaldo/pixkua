Partial Class SalaService

    Public Function GetSalaByUser(idUsuario As Integer) As SalaInfo
        Try
            Dim IdUsuarioToLoad = idUsuario
            If IdUsuarioToLoad = 0 Then IdUsuarioToLoad = Session.User.Identity
            Dim fxSalaId As New FunctionSQL("Medicine", "fxSalaByUser", Connection, Transaction)
            fxSalaId.Parameters.Add("@IdUsuario", DbType.Int32).Value = IdUsuarioToLoad
            Dim IdDoctor As Integer = CInt(fxSalaId.GetScalar)
            If IdDoctor > 0 Then
                Dim SalaSvc As New SalaService(SessionID, Connection, Transaction)
                Dim SalaInf As New SalaInfo(SessionID)
                SalaSvc.GetDetail(IdDoctor, SalaInf, False)
                Return SalaInf
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw New BusinessException("Error al obtener la información de la Sala perteneciente al usuario: " & idUsuario)
        End Try
    End Function


    Public Function Search(keyword As String) As DataTable
        Try
            Dim fxSearch As New FunctionSQL("Medicine", "fxSalasSearch", Connection, Transaction)
            fxSearch.Parameters.Add("@Keyword", DbType.String).Value = keyword
            Dim dtResult As DataTable = fxSearch.GetTable()
            Return dtResult
        Catch ex As Exception
            Throw New BusinessException("Error al realizar la búsqueda por palabra clave: '" & keyword & "'", ex)
        End Try
    End Function

    Public Function LoadList() As DataTable
        Dim dtList As DataTable = Nothing
        Try
            Dim fxList As New FunctionSQL("Medicine", "fxSalasCBO", Connection, Transaction)
            fxList.Parameters.Add("@IdUsuario", DbType.Int32).Value = Session.User.Identity
            dtList = fxList.GetTable()
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de salas.", ex)
        End Try
        Return dtList
    End Function

    Public Function AgendarEvento(evento As EventoSala) As EventoSala
        Try
            Dim spAgendar As New StoredProcedure("Medicine", "AgendaSalasUPD", Connection, Transaction)
            spAgendar.Parameters.Add("@IdAgendaSala", DbType.Int32, ParameterDirection.InputOutput).Value = evento.ID
            spAgendar.Parameters.Add("@IdSala", DbType.Int32).Value = evento.IdSala
            spAgendar.Parameters.Add("@FechaIni", DbType.DateTime).Value = evento.FechaInicial
            spAgendar.Parameters.Add("@FechaFin", DbType.DateTime).Value = evento.FechaFinal
            spAgendar.Parameters.Add("@FechaRegistro", DbType.DateTime).Value = evento.FechaRegistro
            spAgendar.Parameters.Add("@IdDoctor", DbType.Int32).Value = evento.IdDoctor
            spAgendar.Parameters.Add("@IdPaciente", DbType.Int32).Value = evento.IdPaciente
            spAgendar.Parameters.Add("@Observaciones", DbType.String).Value = evento.Observaciones
            spAgendar.Execute()
            'Recuperar Identificador del evento
            evento.ID = CInt(spAgendar.Parameters("@IdAgendaSala").Value)
        Catch ex As Exception
            Throw New BusinessException("Error al agregar o actualizar el evento.", ex)
        End Try
        Return evento
    End Function

    Public Sub EliminarEvento(idEvento As Integer)
        Try
            Dim spEliminar As New StoredProcedure("Medicine", "AgendaSalaDEL", Connection, Transaction)
            spEliminar.Parameters.Add("@IdAgendaSala", DbType.Int32).Value = idEvento
            spEliminar.Execute()
        Catch ex As Exception
            Throw New BusinessException("Error al eliminar el evento: " & idEvento.ToString(), ex)
        End Try
    End Sub

    Public Function CargarAgenda(idSala As Integer, fechaInicial As Date, fechaFinal As Date) As System.Collections.Generic.List(Of EventoSala)
        Dim Agenda As New List(Of EventoSala)
        Try
            Dim fxAgenda As New FunctionSQL("Medicine", "fxAgendaSalaSEL", Connection, Transaction)
            fxAgenda.Parameters.Add("@IdSala", DbType.Int32).Value = idSala
            fxAgenda.Parameters.Add("@FechaIni", DbType.DateTime).Value = fechaInicial
            fxAgenda.Parameters.Add("@FechaFin", DbType.DateTime).Value = fechaFinal
            Dim dtAgenda As DataTable = fxAgenda.GetTable()
            For Each dr As DataRow In dtAgenda.Rows
                Dim Evento As New EventoSala
                With Evento
                    .ID = CInt(dr("IdAgendaSala"))
                    .FechaInicial = CDate(dr("FechaIni"))
                    .FechaFinal = CDate(dr("FechaFin"))
                    .FechaRegistro = CDate(dr("FechaRegistro"))
                    .IdDoctor = CInt(dr("IdDoctor"))
                    .Doctor = dr("Doctor").ToString()
                    .IdPaciente = CInt(dr("IdPaciente"))
                    .Paciente = dr("Paciente").ToString()
                    .Observaciones = dr("Observaciones").ToString()
                End With
                Agenda.Add(Evento)
            Next
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la agenda de la sala.", ex)
        End Try
        Return Agenda
    End Function


    Public Sub AddUser(idSala As Integer, idUsuario As Integer)
        Try
            Dim SP As New StoredProcedure("Medicine", "SalaUsuarioINS", Connection, Transaction)
            SP.Parameters.Add("@IdSala", System.Data.DbType.Int32).Value = idSala
            SP.Parameters.Add("@IdUsuario", System.Data.DbType.Int32).Value = idUsuario
            SP.Execute()
        Catch ex As Exception
            Throw New BusinessException("Error al agregar el usuario al Sala.", ex)
        End Try
    End Sub

    Public Sub RemoveUser(idSala As Integer, idUsuario As Integer)
        Try
            Dim SP As New StoredProcedure("Medicine", "SalaUsuarioDEL", Connection, Transaction)
            SP.Parameters.Add("@IdSala", System.Data.DbType.Int32).Value = idSala
            SP.Parameters.Add("@IdUsuario", System.Data.DbType.Int32).Value = idUsuario
            SP.Execute()
        Catch ex As Exception
            Throw New BusinessException("Error al eliminar el usuario de la Sala.", ex)
        End Try
    End Sub

    Public Function LoadUserAccess(IdSala As Integer) As DataTable
        Dim dtRet As New DataTable
        Try
            Dim Fn As New FunctionSQL("Medicine", "fxSalasUsuariosList", Connection, Transaction)
            Fn.Parameters.Add("@IdSala", System.Data.DbType.Int32).Value = IdSala
            Fn.FillDataTable(dtRet)
        Catch ex As Exception
            Throw New BusinessException("Error al obtener datos de Usuarios de la Sala.", ex)
        End Try
        Return dtRet
    End Function

    'public void UpdateUser(int idAlmacen, int idUsuario, byte entrada, byte salida)
    '{
    '    Try
    '    {
    '        StoredProcedure SP = new StoredProcedure("Inventory", "AlmacenesUsuariosUPD", Connection, Transaction);
    '        SP.Parameters.Add("@IdAlmacen", System.Data.DbType.Int32).Value = idAlmacen;
    '        SP.Parameters.Add("@IdUsuario", System.Data.DbType.Int32).Value = idUsuario;
    '        SP.Parameters.Add("@Entrada", System.Data.DbType.Byte).Value = entrada;
    '        SP.Parameters.Add("@Salida", System.Data.DbType.Byte).Value = salida;
    '        SP.Execute();
    '    }
    '    catch (Exception ex)
    '    {
    '        throw new BusinessException("Error al actualizar el usuario al Almacén.", ex);
    '    }
    '}
End Class

Partial Class SalaFacade

    Public Function GetSalaByUser(sessionID As Guid, idUsuario As Integer) As SalaInfo
        Dim Sala As SalaInfo = Nothing
        Try
            Connection = DataServices.OpenConnection()
            Dim Svc As New SalaService(sessionID, Connection, Transaction)
            Sala = Svc.GetSalaByUser(idUsuario)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Sala
    End Function


    Public Sub ChangeStatus(sessionID As Guid, itemID As Integer, active As Boolean)
        Try
            Connection = DataServices.OpenConnection()
            Dim Svc As New SalaService(sessionID, Connection, Transaction)
            Svc.ChangeStatus(itemID, active)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub

    Public Function Search(sessionID As Guid, keyword As String) As DataTable
        Dim dtResult As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection()
            Dim Svc As New SalaService(sessionID, Connection, Transaction)
            dtResult = Svc.Search(keyword)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtResult
    End Function

    Public Function GetTotalRows(sessionID As Guid, idSite As Integer, conditions As Azteca.Kernel.Search.SearchConditionCollection) As Integer
        Dim TotalRows As Integer = 0
        Try
            Connection = DataServices.OpenConnection()
            Dim Svc As New SalaService(sessionID, Connection, Transaction)
            TotalRows = Svc.GetTotalRows(idSite, conditions)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return TotalRows
    End Function

    Public Function LoadList(sessionID As Guid) As DataTable
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection()
            Dim Svc As New SalaService(sessionID, Connection, Transaction)
            dtList = Svc.LoadList()
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function AgendarEvento(sessionID As Guid, evento As EventoSala) As EventoSala
        Dim RetEvento As New EventoSala()
        Try
            Connection = DataServices.OpenConnection()
            Try
                Transaction = Connection.BeginTransaction
                Dim Svc As New SalaService(sessionID, Connection, Transaction)
                RetEvento = Svc.AgendarEvento(evento)
                Transaction.Commit()
            Catch ex As Exception
                Transaction.Rollback()
                Throw ex
            End Try
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return RetEvento
    End Function

    Public Sub EliminarEvento(sessionID As Guid, idEvento As Integer)
        Try
            Connection = DataServices.OpenConnection()
            Try
                Transaction = Connection.BeginTransaction
                Dim Svc As New SalaService(sessionID, Connection, Transaction)
                Svc.EliminarEvento(idEvento)
                Transaction.Commit()
            Catch ex As Exception
                Transaction.Rollback()
                Throw ex
            End Try
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub

    Public Function CargarAgenda(sessionID As Guid, idSala As Integer, fechaInicial As Date, fechaFinal As Date) As System.Collections.Generic.List(Of EventoSala)
        Dim Agenda As New List(Of EventoSala)
        Try
            Connection = DataServices.OpenConnection()
            Dim Svc As New SalaService(sessionID, Connection, Transaction)
            Agenda = Svc.CargarAgenda(idSala, fechaInicial, fechaFinal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Agenda
    End Function

    Public Sub AddUser(sessionID As Guid, idSala As Integer, idUsuario As Integer)
        Try
            Connection = DataServices.OpenConnection()
            Try
                Transaction = Connection.BeginTransaction()
                Dim Service As New SalaService(sessionID, Connection, Transaction)
                Service.AddUser(idSala, idUsuario)
                Transaction.Commit()
            Catch ex As Exception
                HandleException(ex)
                Transaction.Rollback()
            End Try
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub

    'public void UpdateUser(Guid sessionID, int idAlmacen, int idUsuario, byte entrada, byte salida)
    '{
    '    ValidateSession(sessionID);
    '        Try
    '    {
    '        Connection = DataServices.OpenConnection();
    '            Try
    '        {
    '            Transaction = Connection.BeginTransaction();
    '            Service = new AlmacenService(sessionID, Connection, Transaction);
    '            Service.UpdateUser(idAlmacen, idUsuario, entrada, salida);
    '            Transaction.Commit();
    '        }
    '        catch (Exception ex)
    '        {
    '            HandlException(ex);
    '            Transaction.Rollback();
    '        }
    '    }
    '    catch (Exception ex)
    '    {
    '        HandlException(ex);
    '    }
    '            Finally
    '    {
    '        DataServices.CloseConnection(Connection);
    '    }
    '}

    Public Sub RemoveUser(sessionID As Guid, idSala As Integer, idUsuario As Integer)
        Try
            Connection = DataServices.OpenConnection()
            Try
                Transaction = Connection.BeginTransaction()
                Dim Service = New SalaService(sessionID, Connection, Transaction)
                Service.RemoveUser(idSala, idUsuario)
                Transaction.Commit()
        Catch ex As Exception
                HandleException(ex)
                Transaction.Rollback()
            End Try
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub

    Public Function LoadUserAccess(sessionID As Guid, idSala As Integer) As DataTable
        Dim dtRet As New DataTable
        Try
            Connection = DataServices.OpenConnection()
            Dim Service As New SalaService(sessionID, Connection)
            dtRet = Service.LoadUserAccess(idSala)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtRet
    End Function

End Class