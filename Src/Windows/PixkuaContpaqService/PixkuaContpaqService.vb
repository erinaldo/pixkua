Imports System.ServiceProcess
Public Class PixkuaContpaqService
    Inherits System.ServiceProcess.ServiceBase

    Private EventViewer As Azteca.Kernel.General.AppEventLogFacade
    Private UserContpaq As String
    Private PwdContPaq As String
    Private CuentaAjustes As String
    Private CuentaAjustesIdSeg As Integer
    Private TimerMinutes As Integer
    Private EmpresaContPaqAliasBDD As String
    Private IdServicio As String

    Public Session As Azteca.Kernel.Security.UserSession
    Private TransacTimer As System.Timers.Timer
    Private Procesando As Boolean = False

    Private BaseDatosAnt As String = "", PrimerEmpresa As Boolean = True


    Protected Overrides Sub OnStop()
        If Not gSdkSesion Is Nothing Then
            If gSdkSesion.conexionActiva Then
                gSdkSesion.cierraEmpresa()
            End If
        End If
        MyBase.OnStop()
    End Sub

    Protected Overrides Sub OnStart(ByVal args() As String)
        Try
            'Azteca.Windows.App.InitSystem("Exportar polizas de Pixkua a Contpaq")
            'Si el archivo de conexión existe, verificar que se pueda realizar conexión 
            'Azteca.Kernel.Server.Initialize("Pixkua-Interfaz Contpaq", True)
            Dim UsesRemoteCalls As Boolean = CBool(System.Configuration.ConfigurationManager.AppSettings("UseRemoteCalls"))
            'Si no se utiliza un servidor de aplicaciones cargar conexión a servidor de datos
            If Not UsesRemoteCalls Then
                'Si no se encontró archivo de conexión, pedir información de conexión
                If Not System.IO.File.Exists(My.Application.Info.DirectoryPath & "\DataConfig.xml") Then
                    Diagnostics.EventLog.WriteEntry("Pixkua-Interfaz Contpaq", "Por favor verifique la información de conexión al servidor de datos[DataConfig].", EventLogEntryType.Information)
                    ConfigureDataAccess()
                Else
                    'Si el archivo de conexión existe, verificar que se pueda realizar conexión 
                    Azteca.Kernel.Server.Initialize("Pixcua", True)
                End If
            Else
                'Limpiar canales registrados
                For Each channel As System.Runtime.Remoting.Channels.IChannel In System.Runtime.Remoting.Channels.ChannelServices.RegisteredChannels
                    System.Runtime.Remoting.Channels.ChannelServices.UnregisterChannel(channel)
                Next
                'Obtener el tipo de configuración de remoting
                Dim Config As String = "WEB" ''Registry.GetValue("Remoting", "Type", "LAN")
                Select Case Config
                    Case "LAN"
                        System.Runtime.Remoting.RemotingConfiguration.Configure("LAN.config", False)
                    Case "WEB"
                        System.Runtime.Remoting.RemotingConfiguration.Configure("WEB.config", False)
                    Case "TEST"
                        System.Runtime.Remoting.RemotingConfiguration.Configure("Test.config", False)
                    Case Else
                        System.Runtime.Remoting.RemotingConfiguration.Configure("Pixcua.exe.config", False)
                End Select
            End If

            Dim UserPixkua As String = System.Configuration.ConfigurationManager.AppSettings("UserPixkua")
            Dim PwdPixkua As String = System.Configuration.ConfigurationManager.AppSettings("PwdPixkua")
            UserContpaq = System.Configuration.ConfigurationManager.AppSettings("UserContPaq")
            PwdContPaq = System.Configuration.ConfigurationManager.AppSettings("PwdContPaq")
            EmpresaContPaqAliasBDD = System.Configuration.ConfigurationManager.AppSettings("EmpresaContPaqAliasBDD")
            CuentaAjustes = System.Configuration.ConfigurationManager.AppSettings("CuentaAjustes")
            CuentaAjustesIdSeg = System.Configuration.ConfigurationManager.AppSettings("CuentaAjustesIdSeg")
            TimerMinutes = System.Configuration.ConfigurationManager.AppSettings("TimerMinutes")
            IdServicio = System.Configuration.ConfigurationManager.AppSettings("IdServicio")

            'Inicializar objetos de Contpaq
            iniciaObjetosSdk()

            'Abrir session de Pixkua
            Dim user As New Azteca.Kernel.Security.UsuarioFacade
            Session = user.LogIn(UserPixkua, PwdPixkua, My.Computer.Name)
            Debug.Print(UserContpaq & "-" & PwdContPaq & "-" & EmpresaContPaqAliasBDD)

            If Session IsNot Nothing Then
                'Iniciar proceso de transacciones en cola
                Diagnostics.EventLog.WriteEntry("Pixkua-Interfaz Contpaq", "Iniciando timer de proceso de transacciones", EventLogEntryType.Information)
                TransacTimer = New System.Timers.Timer(TimerMinutes * 60000)
                AddHandler TransacTimer.Elapsed, AddressOf ExportarPolizas
                TransacTimer.Start()

                Diagnostics.EventLog.WriteEntry("Pixkua-Interfaz Contpaq", "Servidor Pixkua-Contpaq iniciado", EventLogEntryType.Information)
            Else
                Diagnostics.EventLog.WriteEntry("Pixkua-Interfaz Contpaq", "Error al crear sesión en sistema Pixkua. Nombre de usuario o password incorrecto.", EventLogEntryType.Error)
            End If

        Catch ex As Exception
            EventLog.WriteEntry("Pixkua-Interfaz Contpaq", ex.ToString, EventLogEntryType.Error)
        End Try

    End Sub

    Private Sub ConfigureDataAccess()
        Azteca.Kernel.Server.Initialize("Pixkua-Interfaz Contpaq", True)
    End Sub

    Private Sub ExportarPolizas(ByVal sender As Object, ByVal e As System.Timers.ElapsedEventArgs)

        If Procesando Then Exit Sub

        Try
            'Procesando = True
            TransacTimer.Stop()
            Dim concepto As String = "Polizas generadas desde Pixkua"
            Dim PolFac As New PolizaFacade
            Dim PendientesDataTable As DataTable = PolFac.ContpaqLogList(Nothing, Date.Today, CInt(Val(IdServicio)))
            Dim dv As New DataView(PendientesDataTable, "", "BaseDatos", System.Data.DataViewRowState.CurrentRows)
            For Each drPol As DataRowView In dv
                If BaseDatosAnt <> drPol("BaseDatos").ToString Then
                    If Not PrimerEmpresa Then
                        Diagnostics.EventLog.WriteEntry("Pixkua-Interfaz Contpaq", "Cerrando Empresa Anterior[" & BaseDatosAnt & "]", EventLogEntryType.Information)
                        cierraEmpresaAnterior()
                    End If

                    'Diagnostics.EventLog.WriteEntry("Pixkua-Interfaz Contpaq", "Abriendo Empresa[" & drPol("BaseDatos").ToString & "]", EventLogEntryType.Information)
                    If gSdkSesion.abreEmpresa(drPol("BaseDatos").ToString) = 0 Then 'Abrimos la nueva empresa
                        Throw New Exception("Problemas al abrir la empresa[" & drPol("BaseDatos").ToString & "]")
                    End If
                    Diagnostics.EventLog.WriteEntry("Pixkua-Interfaz Contpaq", "Abrio Empresa[" & drPol("BaseDatos").ToString & "]", EventLogEntryType.Information)
                    PrimerEmpresa = False
                End If

                Diagnostics.EventLog.WriteEntry("Pixkua-Interfaz Contpaq", "Preparando Poliza[" & drPol("Nombre") & "]." & drPol("idPolizaTit").ToString, EventLogEntryType.Information)
                Dim PolInfo As New PolizaInfo(Session)
                PolInfo = PolFac.GetDetail(Session, drPol("idPolizaTit").ToString)
                Try
                    Exportacion(concepto, PolInfo)
                    Diagnostics.EventLog.WriteEntry("Pixkua-Interfaz Contpaq", "Poliza Importada[" & drPol("Nombre") & "]." & drPol("idPolizaTit").ToString, EventLogEntryType.Information)
                Catch ex As Exception
                    Diagnostics.EventLog.WriteEntry("Pixkua-Interfaz Contpaq", gSdkSesion.UltimoMsjError & ControlChars.CrLf & ex.ToString(), EventLogEntryType.Error)
                End Try
                BaseDatosAnt = drPol("BaseDatos").ToString
            Next
        Catch ex As Exception
            Diagnostics.EventLog.WriteEntry("Pixkua-Interfaz Contpaq", gSdkSesion.UltimoMsjError & ControlChars.CrLf & ex.ToString(), EventLogEntryType.Error)
        Finally
            'If BaseDatosAnt <> "" Then gSdkSesion.cierraEmpresa() 'Cerramos la empresa anterior
            TransacTimer.Start()
            'Procesando = False
        End Try

    End Sub

    Private Sub CierraEmpresaAnterior()
        Try
            gSdkSesion.cierraEmpresa() 'Cerramos la empresa anterior
            BaseDatosAnt = ""
        Catch ex As Exception
            Diagnostics.EventLog.WriteEntry("Pixkua-Interfaz Contpaq", "No se logro cerrar la empresa [" & BaseDatosAnt & "].", EventLogEntryType.Information)
            BaseDatosAnt = ""
        End Try

    End Sub

#Region "Importar Poliza a Contpac"

    'Declaración de variables locales
    Public gSdkSesion As SDKCONTPAQNGLib.TSdkSesion

    'Public gSdkListaEmpresas As SDKCONTPAQNGLib.TSdkListaEmpresas
    'Public gSdkHojaElectronica As SDKCONTPAQNGLib.TSdkHojaElectronica
    'Public gSdkPoliza As SDKCONTPAQNGLib.TSdkPoliza
    'Public gSdkCuenta As SDKCONTPAQNGLib.TSdkCuenta
    'Public gSdkMovpoliza As SDKCONTPAQNGLib.TSdkMovimientoPoliza

    'Public Function ConvertContpacTipoPoliza(ByVal Tipo As PolizaTipoEnum) As SDKCONTPAQNGLib.ETIPOPOLIZA
    '    Select Case Tipo
    '        Case Is = PolizaTipoEnum.DeOrden
    '            Return SDKCONTPAQNGLib.ETIPOPOLIZA.TIPO_ORDEN
    '        Case Is = PolizaTipoEnum.Diario
    '            Return SDKCONTPAQNGLib.ETIPOPOLIZA.TIPO_DIARIO
    '        Case Is = PolizaTipoEnum.Egresos
    '            Return SDKCONTPAQNGLib.ETIPOPOLIZA.TIPO_EGRESOS
    '        Case Is = PolizaTipoEnum.Estadisticas
    '            Return SDKCONTPAQNGLib.ETIPOPOLIZA.TIPO_ESTADISTICAS
    '        Case Is = PolizaTipoEnum.Ingresos
    '            Return SDKCONTPAQNGLib.ETIPOPOLIZA.TIPO_INGRESOS
    '    End Select
    'End Function

    'Public Function ConvertContpacTipoPoliza(ByVal Tipo As String) As SDKCONTPAQNGLib.ETIPOPOLIZA
    '    Select Case Tipo
    '        Case "D"
    '            Return SDKCONTPAQNGLib.ETIPOPOLIZA.TIPO_DIARIO
    '        Case "I"
    '            Return SDKCONTPAQNGLib.ETIPOPOLIZA.TIPO_INGRESOS
    '        Case "E"
    '            Return SDKCONTPAQNGLib.ETIPOPOLIZA.TIPO_EGRESOS
    '        Case "S"
    '            Return SDKCONTPAQNGLib.ETIPOPOLIZA.TIPO_ESTADISTICAS
    '        Case "O"
    '            Return SDKCONTPAQNGLib.ETIPOPOLIZA.TIPO_ORDEN
    '    End Select
    'End Function

    Private Sub iniciaObjetosSdk()

        Try
            gSdkSesion = New SDKCONTPAQNGLib.TSdkSesion

            If gSdkSesion.conexionActiva = 0 Then
                gSdkSesion.iniciaConexion()
            End If

            If CInt(gSdkSesion.conexionActiva) = 1 And CInt(gSdkSesion.ingresoUsuario) = 0 Then
                gSdkSesion.firmaUsuarioParams(UserContpaq, PwdContPaq) ''("supervisor", "quinac")
            End If

            'gSdkListaEmpresas = New SDKCONTPAQNGLib.TSdkListaEmpresas
            'gSdkListaEmpresas.buscaPrimero()

            ''FrmEmpresas.ShowDialog() ---------ctConcentrados

            'If Len(EmpresaContPaqAliasBDD) = 0 Then Throw New Exception("No se localizo la cadena de conexion para importar la informacion")

            'gSdkSesion.abreEmpresa(EmpresaContPaqAliasBDD)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Exportacion(ByVal Concepto As String, ByVal PolInfo As PolizaInfo)
        Dim gSdkPoliza As New SDKCONTPAQNGLib.TSdkPoliza
        Dim gSdkCuenta As New SDKCONTPAQNGLib.TSdkCuenta
        Try

            Dim MovimientosDescartados As Boolean = False

            '//Establece la sesión para el Sdk de Pólizas y llena los datos correspondientes
            gSdkCuenta.setSesion(gSdkSesion) : gSdkPoliza.setSesion(gSdkSesion)
            gSdkPoliza = New SDKCONTPAQNGLib.TSdkPoliza
            gSdkPoliza.setSesion(gSdkSesion)
            gSdkPoliza.Fecha = PolInfo.Fecha : gSdkPoliza.Numero = PolInfo.Folio : gSdkPoliza.Concepto = "Poliza de Pixkua" 'PolInfo.Descripcion
            gSdkPoliza.Tipo = PolInfo.IdPolizaTipo
            If PolInfo.AfectarSistemaExterno Then
                gSdkPoliza.Clase = SDKCONTPAQNGLib.ECLASEPOLIZA.CLASE_AFECTAR
            Else
                gSdkPoliza.Clase = SDKCONTPAQNGLib.ECLASEPOLIZA.CLASE_SINAFECTAR
            End If
            gSdkPoliza.Diario = 0 ''CInt(edtDiario.Text)
            gSdkPoliza.SistOrigen = SDKCONTPAQNGLib.ESISTORIGEN.ORIG_EXION

            Dim cont As Integer = 1, Cargos As Decimal = 0, Abonos As Decimal = 0, Abono0_Cargo1 As Boolean, Importe As Decimal
            Dim dv As New DataView(PolInfo.Details, "", "IdReferencia,Orden", DataViewRowState.CurrentRows)

            For Each dr As DataRowView In dv
                Dim drMovto As PolizasDS.PolizasDetRow = CType(dr.Row, PolizasDS.PolizasDetRow)

                'Agregamos el movimiento mientras no se haya descartado un movimiento previo de la poliza
                If Not MovimientosDescartados Then
                    If drMovto.Abono <> 0 Then
                        Abono0_Cargo1 = False : Importe = drMovto.Abono
                    Else
                        Abono0_Cargo1 = True : Importe = drMovto.Cargo
                    End If

                    'Agrega Movimiento
                    If Not addMovimiento(gSdkPoliza, cont, PolInfo.Identity, PolInfo.Fecha, drMovto.Cuenta, drMovto.CuentaName, drMovto.Referencia, Abono0_Cargo1, Importe, drMovto.IdSegmento) Then
                        MarcarImportacion(PolInfo.Identity, 7, "La cuenta [" & drMovto.Cuenta & "] no pudo ser validada:" & gSdkPoliza.UltimoMsjError)
                        Throw New Exception("La cuenta [" & drMovto.Cuenta & "] no pudo ser validada")
                        MovimientosDescartados = True
                    Else
                        Cargos = Cargos + Decimal.Round(drMovto.Cargo, 2)
                        Abonos = Abonos + Decimal.Round(drMovto.Abono, 2)
                    End If
                End If
            Next

            'Exportamos la Poliza siempre y cuando los movimientos hayan sido agregados completos
            If Decimal.Round(Cargos, 2) <> Decimal.Round(Abonos, 2) And Not MovimientosDescartados Then
                Importe = Abonos - Cargos
                If Not addMovimiento(gSdkPoliza, cont, PolInfo.Identity, PolInfo.Identity, CuentaAjustes, "ajuste decimal", "", True, Importe, CuentaAjustesIdSeg) Then
                    MarcarImportacion(PolInfo.Identity, 7, "Error al asignar la cuenta de ajuste de decimales:" & gSdkPoliza.UltimoMsjError)
                    Throw New Exception("Error al asignar la cuenta de ajuste de decimales")
                End If
            End If

            If dv.Count > 0 And Not MovimientosDescartados Then
                If gSdkPoliza.crea = 0 Then
                    MarcarImportacion(PolInfo.Identity, 7, "Hubo un error al enviar la Póliza a CONTPAQ i:" & gSdkPoliza.UltimoMsjError & " Sesion:" & gSdkSesion.UltimoMsjError)
                    Throw New Exception("Hubo un error al enviar la Póliza a CONTPAQ i:" & gSdkSesion.UltimoMsjError)
                Else
                    MarcarImportacion(PolInfo.Identity, 3, "")
                End If
            End If

        Catch ex As Exception
            MarcarImportacion(PolInfo.Identity, 7, "Error al estar importando la poliza[" & PolInfo.Identity & "]:" & gSdkPoliza.UltimoMsjError & " Sesion:" & gSdkSesion.UltimoMsjError)
            Throw New Exception("Error al estar importando la poliza[" & PolInfo.Identity & "]", ex)
        End Try

    End Sub

    Private Function addMovimiento(ByVal gSdkPoliza As SDKCONTPAQNGLib.TSdkPoliza, ByRef cont As Integer, ByVal IdPolizaTit As String, ByVal Fecha As DateTime, _
                                    ByVal Cuenta As String, ByVal Concepto As String, ByVal Referencia As String, _
                                    ByVal Abono0_Cargo1 As Boolean, ByVal Importe As Decimal, ByVal IdSegmento As Integer) As Boolean
        'Guardamos el detalle
        Dim gSdkMovpoliza = New SDKCONTPAQNGLib.TSdkMovimientoPoliza
        '// Limpia los valores anteriores
        gSdkMovpoliza.iniciarInfo()

        ''llena movimiento
        gSdkMovpoliza.setSesion(gSdkSesion)
        gSdkMovpoliza.NumMovto = cont
        gSdkMovpoliza.CodigoCuenta = CStr(Cuenta).Replace("-", "")
        gSdkMovpoliza.Concepto = Concepto
        gSdkMovpoliza.Referencia = Referencia.Replace(" ", "")
        gSdkMovpoliza.Diario = 0 ''CInt(edtDiarioCuenta1.Text)
        If Abono0_Cargo1 = 0 Then
            gSdkMovpoliza.TipoMovto = SDKCONTPAQNGLib.ETIPOIMPORTEMOVPOLIZA.MOVPOLIZA_ABONO
        Else
            gSdkMovpoliza.TipoMovto = SDKCONTPAQNGLib.ETIPOIMPORTEMOVPOLIZA.MOVPOLIZA_CARGO
        End If
        gSdkMovpoliza.Importe = Decimal.Round(Importe, 2)
        gSdkMovpoliza.SegmentoNegocio = IdSegmento

        Dim CuentaTmp As String = gSdkMovpoliza.CodigoCuenta
        If CuentaTmp.Trim.Length > 1 Then
            If gSdkPoliza.agregaMovimiento(gSdkMovpoliza) <> 0 Then
                Debug.Print(gSdkMovpoliza.CodigoCuenta & " - " & Referencia & " Contador:" & cont & " Contra:" & gSdkPoliza.NumeroMovtos & " Cargos:" & gSdkPoliza.Cargos & " Abonos:" & gSdkPoliza.Abonos)
                cont = cont + 1
            Else
                Debug.Print("No se logro validar la cuenta [" & Cuenta & "] con la referencia [" & Referencia & "] con documento de Poliza:" & IdPolizaTit & " el dia [" & Fecha & "]")
                Return False
            End If
        Else
            Debug.Print("No se logro validar la cuenta [" & Cuenta & "] con la referencia [" & Referencia & "] con documento de la poliza:" & IdPolizaTit & " el dia [" & Fecha & "]")
            Return False
        End If

        Return True

    End Function

    Private Sub MarcarImportacion(ByVal idPolizaTit As String, ByVal IdStatus As Integer, ByVal Mensaje As String)
        Try
            Dim polFac As New PolizaFacade
            polFac.AplicarStatus(Session, idPolizaTit, IdStatus, Mensaje)
        Catch ex As Exception
            EventLog.WriteEntry("Pixkua-Interfaz Contpaq", "Poliza importada pero no actualizada [" & idPolizaTit & "]. " & ex.ToString, EventLogEntryType.Error)
        End Try
    End Sub

#End Region

End Class
