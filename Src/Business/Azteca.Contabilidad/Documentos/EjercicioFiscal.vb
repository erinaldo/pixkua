Partial Class EjercicioFiscalFacade
    Public Function GetUltimoEjercicio(ByVal sessionID As Guid, ByVal idEmpresa As Integer) As Integer
        ValidateSession(sessionID)

        Dim Ultimo As Integer = 0
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New EjercicioFiscalService(sessionID, Connection, Transaction)
            Ultimo = Svc.GetUltimoEjercicio(idEmpresa)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Ultimo
    End Function

    Public Function LoadList(ByVal sessionID As Guid, ByVal idEmpresa As Integer) As DataTable
        ValidateSession(sessionID)

        Dim dt As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New EjercicioFiscalService(sessionID, Connection, Transaction)
            dt = Svc.LoadList(idEmpresa)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dt
    End Function

    Public Sub PeriodoAbrir(ByVal sessionID As Guid, ByVal IdEjercicioTit As String, ByVal Mes As Integer)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Me.Transaction = Connection.BeginTransaction
                Dim Svc As New EjercicioFiscalService(sessionID, Connection, Transaction)
                Svc.PeriodoAbrir(IdEjercicioTit, Mes)
                Transaction.Commit()
            Catch ex As Exception
                Transaction.Rollback()
            End Try
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub

    Public Sub PeriodoCerrar(ByVal sessionID As Guid, ByVal IdEjercicioTit As String, ByVal Mes As Integer)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Me.Transaction = Connection.BeginTransaction
                Dim Svc As New EjercicioFiscalService(sessionID, Connection, Transaction)
                Svc.PeriodoCerrar(IdEjercicioTit, Mes)
                Transaction.Commit()
            Catch ex As Exception
                Transaction.Rollback()
            End Try
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub

End Class

Partial Class EjercicioFiscalService
    Public Sub PeriodoAbrir(ByVal IdEjercicioTit As String, ByVal Mes As Integer)
        Try
            Dim sp As New StoredProcedure("Accounting", "EjerciciosFiscalesPeriodoAbrir", Me.Connection, Me.Transaction)
            sp.Parameters.Add("IdEjercicioFiscalTit", DbType.String).Value = IdEjercicioTit
            sp.Parameters.Add("Mes", DbType.Int32).Value = Mes
            sp.Execute()
        Catch ex As Exception
            Throw New BusinessException("No se logro abrir el periodo.", ex)
        End Try
    End Sub

    Public Sub PeriodoCerrar(ByVal IdEjercicioTit As String, ByVal Mes As Integer)
        Try
            Dim sp As New StoredProcedure("Accounting", "EjerciciosFiscalesPeriodoCerrar", Me.Connection, Me.Transaction)
            sp.Parameters.Add("IdEjercicioFiscalTit", DbType.String).Value = IdEjercicioTit
            sp.Parameters.Add("Mes", DbType.Int32).Value = Mes
            sp.Execute()
        Catch ex As Exception
            Throw New BusinessException("No se logro cerrar el periodo.", ex)
        End Try
    End Sub

    Public Function LoadList(ByVal idEmpresa As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Accounting", "fxEjerciciosFiscalesTitCBO", Connection, Transaction)
            fxList.Parameters.Add("@idEmpresa", DbType.Int32).Value = idEmpresa
            Dim dtList As DataTable = fxList.GetTable("EjerciciosFiscales")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Ejercicios fiscales.", ex)
        End Try
    End Function


    Public Function GetUltimoEjercicio(ByVal idEmpresa As Integer) As Integer
        Try
            Dim fxList As New FunctionSQL("Accounting", "fxEjerciciosFiscalesUltimo", Connection, Transaction)
            fxList.Parameters.Add("@idEmpresa", DbType.Int32).Value = idEmpresa
            Dim Ultimo As Integer = CInt(fxList.GetScalar)
            Return Ultimo
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Ejercicios fiscales.", ex)
        End Try
    End Function

End Class

Partial Class EjercicioFiscalInfo
    Public Function NuevoEjercicio(ByVal UltimoAnio As Integer, ByVal EjercicioInfo As EjercicioFiscalInfo) As EjercicioFiscalInfo
        Try
            EjercicioInfo.Fecha = New Date(UltimoAnio + 1, 1, 1)
            EjercicioInfo.FechaIni = New Date(UltimoAnio + 1, 1, 1)
            EjercicioInfo.FechaFin = New Date(UltimoAnio + 1, 12, 31)
            'Se agregan todos los periodos del anio como activos
            For Mes As Integer = EjercicioInfo.FechaIni.Month To EjercicioInfo.FechaFin.Month
                Dim dr As EjercicioFiscalDS.PeriodosRow = EjercicioInfo.PeriodosTable.NewPeriodosRow
                dr.Mes = Mes : dr.Activo = 1
                EjercicioInfo.PeriodosTable.AddPeriodosRow(dr)
            Next
        Catch ex As Exception
            'msginfo.show(ex)
        End Try
        Return EjercicioInfo
    End Function

End Class