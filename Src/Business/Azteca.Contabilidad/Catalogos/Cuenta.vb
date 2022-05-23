Partial Class CuentaFacade
    Public Function CuentasOrdenCBO(ByVal sessionID As Guid) As DataTable
        ValidateSession(sessionID)
        Dim dtAlmacenes As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CuentaService(sessionID, Connection)
            dtAlmacenes = Svc.CuentasOrdenCBO()
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtAlmacenes
    End Function


    Public Function CuentasTipoCBO(ByVal sessionID As Guid) As DataTable
        ValidateSession(sessionID)
        Dim dtAlmacenes As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CuentaService(sessionID, Connection)
            dtAlmacenes = Svc.CuentasTipoCBO()
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtAlmacenes
    End Function

    Public Function CuentasFormatoCBO(ByVal sessionID As GUID) As DataTable
        ValidateSession(sessionID)
        Dim dtAlmacenes As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CuentaService(sessionID, Connection)
            dtAlmacenes = Svc.CuentasFormatoCBO()
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtAlmacenes
    End Function

    Public Function ImportesCBO(ByVal sessionID As GUID) As DataTable
        ValidateSession(sessionID)
        Dim dt As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CuentaService(sessionID, Connection)
            dt = Svc.ImportesCBO()
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dt
    End Function

    Public Sub Importar(ByVal sessionID As GUID, ByVal IdEmpresa As Integer)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New CuentaService(sessionID, Connection, Transaction)
                Svc.Importar(IdEmpresa)
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


    Public Sub ImportarFile(ByVal sessionID As GUID, ByVal dtCuentas As CuentasDS.ImportacionDataTable, ByVal IdEmpresa As Integer)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New CuentaService(sessionID, Connection, Transaction)
                Svc.LoadFile(dtCuentas)
                Svc.ImportarFromFile(IdEmpresa)
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

Partial Class CuentaService
    Public Function CuentasOrdenCBO() As DataTable
        Dim dt As DataTable
        Try
            Dim fx As New FunctionSQL("Accounting", "fxCuentaOrdenCBO", Connection, Transaction)
            dt = fx.GetTable("OrdenCuenta")
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista orden de cuentas.", ex)
        End Try
        Return dt
    End Function


    Public Function CuentasTipoCBO() As DataTable
        Dim dtAlmacenes As DataTable
        Try
            Dim fxAlmacenes As New FunctionSQL("Accounting", "fxCuentaTipoCBO", Connection, Transaction)
            dtAlmacenes = fxAlmacenes.GetTable("TipoCuenta")
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista tipo de cuentas|.", ex)
        End Try
        Return dtAlmacenes
    End Function

    Public Function ImportesCBO() As DataTable
        Dim dt As DataTable
        Try
            Dim fx As New FunctionSQL("Accounting", "fxImportesCBO", Connection, Transaction)
            dt = fx.GetTable("Importes")
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de importes", ex)
        End Try
        Return dt
    End Function


    Public Function CuentasFormatoCBO() As DataTable
        Dim dtAlmacenes As DataTable
        Try
            Dim fxAlmacenes As New FunctionSQL("Accounting", "fxCuentaFormatoCBO", Connection, Transaction)
            dtAlmacenes = fxAlmacenes.GetTable("TipoCuenta")
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de formatos de cuenta|.", ex)
        End Try
        Return dtAlmacenes
    End Function

    Public Sub Importar(ByVal idEmpresa As Integer)
        Try
            Dim sp As New StoredProcedure("Accounting", "CuentasImportar", Connection, Transaction)
            sp.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            sp.CommandTimeOut = 0
            sp.Execute()
        Catch ex As Exception
            Throw New BusinessException("Error al importar las cuentas.", ex)
        End Try
    End Sub

    Public Sub ImportarFromFile(ByVal idEmpresa As Integer)
        Try
            Dim sp As New StoredProcedure("Accounting", "CuentasImportarFile", Connection, Transaction)
            sp.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            sp.CommandTimeOut = 0
            sp.Execute()
        Catch ex As Exception
            Throw New BusinessException("Error al importar las cuentas.", ex)
        End Try
    End Sub


    Public Sub LoadFile(ByVal CuentasTable As CuentasDS.ImportacionDataTable)
        Try
            Dim spDEL As New StoredProcedure("Accounting", "CuentasImportarDEL", Connection, Transaction)
            spDEL.CommandTimeOut = 0
            spDEL.Execute()

            Dim daNew As New Azteca.Data.DataAdapter
            Dim cmdExt As New Azteca.Data.DbCommand("Accounting.CuentasImportarINS", Me.Connection, Me.Transaction)
            cmdExt.CommandType = CommandType.StoredProcedure
            cmdExt.Parameters.Add("@Codigo", DbType.String, "Codigo")
            cmdExt.Parameters.Add("@Nombre", DbType.String, "Nombre")
            cmdExt.Parameters.Add("@Tipo", DbType.String, "Tipo")
            cmdExt.Parameters.Add("@Padre", DbType.String, "Padre")
            cmdExt.Parameters.Add("@SegNeg", DbType.Boolean, "SegNeg")

            daNew.UpdateCommand = cmdExt : daNew.InsertCommand = cmdExt
            daNew.Update(CuentasTable)

        Catch ex As Exception
            Throw New BusinessException("Error al cargar las cuentas.", ex)
        End Try
    End Sub

End Class

<Serializable()> _
Public Enum Contabilidad_AfectadorEnum
    Cargo = 0
    Abono = 1
End Enum