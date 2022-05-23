<Serializable()> _
Public Class SucursalConfigInfo
    Friend _IdSucursal As Integer
    Friend _IdSerieNotasCargo As Integer
    Friend _IdSerieNotasCredito As Integer
    Friend _IdFormatoNotasCargo As Integer
    Friend _IdFormatoNotasCredito As Integer

    Public ReadOnly Property IdSucursal As Integer
        Get
            Return _IdSucursal
        End Get
    End Property

    Public ReadOnly Property IdSerieNotasCargo As Integer
        Get
            Return _IdSerieNotasCargo
        End Get
    End Property

    Public ReadOnly Property IdSerieNotasCredito As Integer
        Get
            Return _IdSerieNotasCredito
        End Get
    End Property

    Public ReadOnly Property IdFormatoNotasCargo As Integer
        Get
            Return _IdFormatoNotasCargo
        End Get
    End Property

    Public ReadOnly Property IdFormatoNotasCredito As Integer
        Get
            Return _IdFormatoNotasCredito
        End Get
    End Property

End Class

Public Class SucursalConfigService
    Private Connection As IDbConnection
    Private Transaction As IDbTransaction
    Private Session As SessionInfo
    Protected SessionID As Guid

    Public Sub New(ByVal sessionID As GUID, ByVal connection As IDbConnection, ByVal transaction As IDbTransaction)
        Me.SessionID = SessionID
        Me.Connection = connection
        Me.Transaction = transaction
        Session = Azteca.Kernel.Server.Sessions(sessionID)
    End Sub

    Public Function CargarConfiguraciones(ByVal idEmpresa As Integer) As SucursalesConfigDS.SucursalesDataTable
        Try
            Dim fxConfig As New FunctionSQL("Accounting", "fxSucursalesConfigList", Connection, Transaction)
            fxConfig.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            Dim Config As New SucursalesConfigDS.SucursalesDataTable
            fxConfig.FillDataTable(Config)
            Return Config
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la configuración de las sucursales", ex)
        End Try
    End Function

    Public Function CargarConfiguracion(ByVal idSucursal As Integer) As SucursalConfigInfo
        Try
            Dim fxConfig As New FunctionSQL("Accounting", "fxSucursalesConfigSEL", Connection, Transaction)
            fxConfig.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            Dim dtConfig As New SucursalesConfigDS.SucursalesDataTable
            fxConfig.FillDataTable(dtConfig)
            Dim Config As New SucursalConfigInfo
            If dtConfig.Count > 0 Then
                Dim drConfig As SucursalesConfigDS.SucursalesRow = dtConfig(0)
                With Config
                    ._IdSucursal = drConfig.IdSucursal
                    ._IdFormatoNotasCargo = drConfig.IdFormatoNotaCargo
                    ._IdFormatoNotasCredito = drConfig.IdFormatoNotaCredito
                    ._IdSerieNotasCargo = drConfig.IdSerieNotasCargo
                    ._IdSerieNotasCredito = drConfig.IdSerieNotasCredito
                End With
                Return Config
            Else
                Return Config
            End If
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la configuración de la sucursal: " & idSucursal.ToString, ex)
        End Try
    End Function

    Public Sub GuardarConfiguracion(ByVal configuracion As SucursalesConfigDS.SucursalesDataTable)
        Try
            Dim comUpdate As New DbCommand("Accounting.SucursalesConfigUPD", Connection, Transaction)
            comUpdate.CommandType = CommandType.StoredProcedure
            comUpdate.Parameters.Add("@IdSucursal", DbType.Int32, "IdSucursal")
            comUpdate.Parameters.Add("@IdSerieNotasCargo", DbType.Int32, "IdSerieNotasCargo")
            comUpdate.Parameters.Add("@IdSerieNotasCredito", DbType.Int32, "IdSerieNotasCredito")
            comUpdate.Parameters.Add("@IdFormatoNotaCargo", DbType.Int32, "IdFormatoNotaCargo")
            comUpdate.Parameters.Add("@IdFormatoNotaCredito", DbType.Int32, "IdFormatoNotaCredito")
            comUpdate.Parameters.Add("@LastUpdate", DbType.DateTime).Value = Date.Now
            comUpdate.Parameters.Add("@PCUpdate", DbType.String).Value = Session.WorkStation
            comUpdate.Parameters.Add("@UserUpdate", DbType.Int32).Value = Session.User.Identity
            '
            Dim da As New DataAdapter
            da.UpdateCommand = comUpdate
            da.Update(configuracion)
        Catch concurrencyEx As DBConcurrencyException

        Catch ex As Exception
            Throw New BusinessException("Error al guardar la configuración de las sucursales.", ex)
        End Try
    End Sub
End Class


Public Class SucursalConfigFacade
    Inherits Azteca.Kernel.RemoteObject

    Private Connection As IDbConnection
    Private Transaction As IDbTransaction

    Private Sub HandleException(ByVal ex As Exception)
        Azteca.Kernel.General.AppEventLog.LogException(ex)
        Throw ex
    End Sub

    Public Function CargarConfiguraciones(ByVal sessionID As GUID, ByVal idEmpresa As Integer) As SucursalesConfigDS.SucursalesDataTable
        Dim Configuracion As New SucursalesConfigDS.SucursalesDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New SucursalConfigService(sessionID, Connection, Transaction)
            Configuracion = Svc.CargarConfiguraciones(idEmpresa)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Configuracion
    End Function

    Public Function CargarConfiguracion(ByVal sessionID As GUID, ByVal idSucursal As Integer) As SucursalConfigInfo
        Dim Configuracion As New SucursalConfigInfo
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New SucursalConfigService(sessionID, Connection, Transaction)
            Configuracion = Svc.CargarConfiguracion(idSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Configuracion
    End Function


    Public Sub GuardarConfiguracion(ByVal sessionID As GUID, ByVal configuracion As SucursalesConfigDS.SucursalesDataTable)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New SucursalConfigService(sessionID, Connection, Transaction)
                Svc.GuardarConfiguracion(configuracion)
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