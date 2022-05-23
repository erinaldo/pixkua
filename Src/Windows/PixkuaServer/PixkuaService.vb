Imports System.ServiceProcess
Imports Azteca.Data
Imports Azteca.Kernel.Security
Imports Azteca.Kernel.General
Imports Azteca.Kernel.BusinessStructure
Imports Azteca.Business.Contabilidad

Public Class PixkuaService
    Private ScheduleTimer As System.Timers.Timer
    Private Session As SessionInfo
    Private Configuracion As ConfigurationInfo

    Protected Overrides Sub OnStart(ByVal args() As String)
        Try
            Dim ApplicationFolder As String = System.Configuration.ConfigurationManager.AppSettings("ApplicationFolder")
            System.Runtime.Remoting.RemotingConfiguration.Configure("PixkuaServer.exe.config", False)
            Azteca.Kernel.Server.Initialize("Pixkua Server", True, ApplicationFolder, ApplicationFolder, Azteca.Kernel.SessionRepository.Memory)
            AppEventLog.WriteEntry("Cargando parámetros de configuración", EventLogType.Information, My.Computer.Name, EventLogRepository.File)
            'Cargar configuración del servidor
            Configuracion = New ConfigurationInfo
            Configuracion.CargarConfiguracion()
            'Crear una sesión con el usuario especificado en configuración
            AppEventLog.WriteEntry("Creando sesión para procesos de servidor", EventLogType.Information, My.Computer.Name, EventLogRepository.File)
            Dim UsuarioFac As New UsuarioFacade()
            If Configuracion.Sesion.UserName.Trim <> String.Empty Then
                Session = UsuarioFac.LogIn(Configuracion.Sesion.UserName, Configuracion.Sesion.Password, My.Computer.Name)
                If Session IsNot Nothing Then
                    'Iniciar timer de ejecución de trabajos programados
                    AppEventLog.WriteEntry("Iniciando temporizador de tareas programadas", EventLogType.Information, My.Computer.Name, EventLogRepository.File)
                    ScheduleTimer = New System.Timers.Timer("60000")
                    AddHandler ScheduleTimer.Elapsed, AddressOf ScheduleTimer_Elapsed
                    ScheduleTimer.Start()
                Else
                    Throw New BusinessException("Error al crear sesión en sistema pixcua. Nombre de usuario o password incorrecto.")
                End If
            End If
            AppEventLog.WriteEntry("Servidor Pixkua iniciado", EventLogType.Information, My.Computer.Name, EventLogRepository.File)
        Catch ex As Exception
            AppEventLog.LogException(ex)
            Throw New Azteca.Kernel.AztecaException("Error al iniciar el servidor de aplicaciones de Pixkua", ex)
        End Try
    End Sub

    Protected Overrides Sub OnStop()
        If ScheduleTimer IsNot Nothing Then ScheduleTimer.Stop()
    End Sub

    Private Sub ScheduleTimer_Elapsed(ByVal sender As Object, ByVal e As System.Timers.ElapsedEventArgs)
        Try
            If Configuracion.FacturaElectronica.ArchivosValidacion.DescargaAutomatica AndAlso IsHoraActual(Configuracion.FacturaElectronica.ArchivosValidacion.HoraDescarga) Then
                DescargarArchivosSAT()
            End If
        Catch ex As Exception
            AppEventLog.LogException(ex)
        End Try
    End Sub

#Region "Metodos Privados"

    Private Function IsHoraActual(ByVal hora As Date) As Boolean
        Return (Date.Now.Hour = hora.Hour AndAlso Date.Now.Minute = hora.Minute)
    End Function

    Private Sub DescargarArchivosSAT()
        Dim SAT As New SATFacade
        SAT.GuardarCertificados(Session.SessionID)
        SAT.GuardarFoliosAutorizados(Session.SessionID)
        AppEventLog.WriteEntry("Archivos de validación descargados exitosamente desde servidor del SAT.", EventLogType.Information)
    End Sub

#End Region

End Class
