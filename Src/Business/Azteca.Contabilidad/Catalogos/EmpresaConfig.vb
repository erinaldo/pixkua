<Serializable()> _
Public Class EmpresaConfigInfo
    Friend _IdEmpresa As Integer
    Friend _Empresa As String = String.Empty

    Public ReadOnly Property IdEmpresa As Integer
        Get
            Return _IdEmpresa
        End Get
    End Property

    Public ReadOnly Property Empresa As String
        Get
            Return _Empresa
        End Get
    End Property

    Public Property FormatoContable As String = String.Empty

    Public Property BaseDatos As String = String.Empty

    Public Property IdServicio As Integer

    Public Property Niveles As Integer

    Public Property RegimenFiscal As String = String.Empty

    Public Property IdTimbrador As Integer

End Class

Public Class EmpresaConfigService
    Private Connection As IDbConnection
    Private Transaction As IDbTransaction
    Private Session As SessionInfo
    Protected SessionID As Guid

    Public Sub New(ByVal sessionID As GUID, ByVal connection As IDbConnection, ByVal transaction As IDbTransaction)
        Me.SessionID = sessionID
        Me.Connection = connection
        Me.Transaction = transaction
        Session = Azteca.Kernel.Server.Sessions(sessionID)
    End Sub

    Public Function GetDetailFromCache(idEmpresa As Integer) As EmpresaConfigInfo
        Dim CacheKey As String = "EmpresaConfig_" & idEmpresa.ToString
        Dim EmpresaConfig As New EmpresaConfigInfo()
        If Azteca.Kernel.Cache.Contains(CacheKey) Then
            EmpresaConfig = CType(Azteca.Kernel.Cache.Item(CacheKey), EmpresaConfigInfo)
        Else
            Dim EmpresaConfigSvc As New EmpresaConfigService(SessionID, Connection, Transaction)
            EmpresaConfig = EmpresaConfigSvc.GetDetail(idEmpresa)
            Azteca.Kernel.Cache.Add(CacheKey, EmpresaConfig, TimeSpan.FromDays(2))
        End If
        Return EmpresaConfig
    End Function

    Public Function GetDetail(ByVal idEmpresa As Integer) As EmpresaConfigInfo
        Try
            Dim fxConfig As New FunctionSQL("Accounting", "fxEmpresasConfigSEL", Connection, Transaction)
            fxConfig.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            Dim dtConfig As DataTable = fxConfig.GetTable
            Dim Config As New EmpresaConfigInfo
            If dtConfig.Rows.Count > 0 Then
                Dim drConfig As DataRow = dtConfig(0)
                With Config
                    ._IdEmpresa = CInt(drConfig("IdEmpresa"))
                    ._Empresa = CStr(drConfig("Empresa"))
                    .FormatoContable = drConfig("FormatoContable").ToString
                    .BaseDatos = drConfig("BaseDatos").ToString
                    .IdServicio = CInt(drConfig("IdServicio"))
                    .Niveles = CInt(drConfig("Niveles"))
                    .RegimenFiscal = drConfig("RegimenFiscal").ToString
                    .IdTimbrador = CInt(drConfig("IdTimbrador"))
                End With
                Return Config
            Else
                Return Config
            End If
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la configuración de la empresa: " & idEmpresa.ToString, ex)
        End Try
    End Function

    Public Sub Update(ByVal configuracion As EmpresaConfigInfo)
        Try
            Dim sp As New StoredProcedure("Accounting", "EmpresasConfigUPD", Connection, Transaction)
            sp.Parameters.Add("@IdEmpresa", DbType.Int32).Value = configuracion.IdEmpresa
            sp.Parameters.Add("@FormatoContable", DbType.String).Value = configuracion.FormatoContable
            sp.Parameters.Add("@BaseDatos", DbType.String).Value = configuracion.BaseDatos
            sp.Parameters.Add("@IdServicio", DbType.Int32).Value = configuracion.IdServicio
            sp.Parameters.Add("@Niveles", DbType.Int32).Value = configuracion.Niveles
            sp.Parameters.Add("@RegimenFiscal", DbType.String).Value = configuracion.RegimenFiscal
            sp.Parameters.Add("@IdTimbrador", DbType.Int32).Value = configuracion.IdTimbrador
            sp.Parameters.Add("@LastUpdate", DbType.DateTime).Value = Date.Now
            sp.Parameters.Add("@PCUpdate", DbType.String).Value = Session.WorkStation
            sp.Parameters.Add("@UserUpdate", DbType.Int32).Value = Session.User.Identity
            '
            sp.Execute()
            Azteca.Kernel.Cache.Remove("EmpresaConfig_" & configuracion.IdEmpresa.ToString)
        Catch concurrencyEx As DBConcurrencyException

        Catch ex As Exception
            Throw New BusinessException("Error al guardar la configuración de las empresas.", ex)
        End Try
    End Sub

End Class


Public Class EmpresaConfigFacade
    Inherits Azteca.Kernel.RemoteObject

    Private Connection As IDbConnection
    Private Transaction As IDbTransaction

    Private Sub HandleException(ByVal ex As Exception)
        Azteca.Kernel.General.AppEventLog.LogException(ex)
        Throw ex
    End Sub

    Public Sub Update(ByVal sessionID As Guid, ByVal EmpresaConfig As EmpresaConfigInfo)
        Dim Configuracion As New SucursalesConfigDS.SucursalesDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New EmpresaConfigService(sessionID, Connection, Transaction)
            Svc.Update(EmpresaConfig)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub

    Public Function GetDetail(ByVal sessionID As Guid, ByVal idEmpresa As Integer) As EmpresaConfigInfo
        Dim Configuracion As New EmpresaConfigInfo
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New EmpresaConfigService(sessionID, Connection, Transaction)
            Configuracion = Svc.GetDetail(idEmpresa)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Configuracion
    End Function

End Class