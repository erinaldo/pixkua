Imports Azteca.Business.Ventas
Public NotInheritable Class Context
    Private Sub New()

    End Sub

#Region "Variables shared"
    'Private Shared _UnidadNegocio As UnidadNegocioInfo
    Private Shared _FormatoTicketPOS As Xml.XmlDocument
    Private Shared _FormatoTicketUbicacionPOS As Xml.XmlDocument
    Private Shared _FormatoTicket As String = ""
    Private Shared _FormatoTicketUbicacion As String = ""
    Private Shared _FormatoFactura As String = ""
    Private Shared _ZonaVenta As String = ""
    Private Shared _FormasPagoPorPedidoTable As DataTable
    Private Shared _IdTipoVenta As Integer
    Private Shared _IdTipoDevolucion As Integer

    Private Shared _ClientesForm As String
    Private Shared _HerramientasForm As String
    Private Shared _sessionTerminal As SessionTerminal
#End Region

#Region "Propiedades Publicas"

    'Public Shared ReadOnly Property UnidadNegocio As UnidadNegocioInfo
    '    Get
    '        Return _UnidadNegocio
    '    End Get
    'End Property

    Public Shared ReadOnly Property FormatoTicketPOS As Xml.XmlDocument
        Get
            Return _FormatoTicketPOS
        End Get
    End Property

    Public Shared ReadOnly Property FormatoTicketUbicacionPOS As Xml.XmlDocument
        Get
            Return _FormatoTicketUbicacionPOS
        End Get
    End Property

    Public Shared ReadOnly Property FormatoTicket As String
        Get
            Return _FormatoTicket
        End Get
    End Property

    Public Shared ReadOnly Property FormatoTicketUbicacion As String
        Get
            Return _FormatoTicketUbicacion
        End Get
    End Property

    Public Shared ReadOnly Property ZonaVenta As String
        Get
            Return _ZonaVenta
        End Get
    End Property

    Public Shared ReadOnly Property SessionTerminal As SessionTerminal
        Get
            Return _sessionTerminal
        End Get
    End Property

    Public Shared ReadOnly Property FormatoFactura As String
        Get
            Return _FormatoFactura
        End Get
    End Property

    Public Shared ReadOnly Property ClientesForm As String
        Get
            Return _ClientesForm
        End Get
    End Property
    Public Shared ReadOnly Property HerramientasForm As String
        Get
            Return _HerramientasForm
        End Get
    End Property

    'Public Shared ReadOnly Property Servicios As System.Collections.Generic.Dictionary(Of String, ServicioInfo)
    '    Get
    '        Return _Servicios
    '    End Get
    'End Property
#End Region

    'Private Shared _Articulos As New System.Collections.Generic.Dictionary(Of String, )
    'Private Shared _Servicios As New System.Collections.Generic.Dictionary(Of String, ServicioInfo)

    Public Shared Sub Initialize()
        If IsNothing(App.Session.SessionID) Then Exit Sub

        Ventas.Context.Initialize()
        _sessionTerminal = New SessionTerminal(App.Session)

        Dim FormatMgr As New Azteca.Kernel.General.FormatManager()
        If Ventas.Context.UnidadNegocio.IdFormatoTicketPOS > 0 Then
            'Cargar formato de impresión
            _FormatoTicket = FormatMgr.LoadFormat(App.Session.SessionID, Ventas.Context.UnidadNegocio.IdFormatoTicketPOS)
            _FormatoTicketPOS = New Xml.XmlDocument
            _FormatoTicketPOS.LoadXml(_FormatoTicket)
        End If

        If Ventas.Context.UnidadNegocio.IdFormatoTicketUbicacionPOS > 0 Then
            'Cargar formato de impresión
            _FormatoTicketUbicacion = FormatMgr.LoadFormat(App.Session.SessionID, Ventas.Context.UnidadNegocio.IdFormatoTicketUbicacionPOS)
            _FormatoTicketUbicacionPOS = New Xml.XmlDocument
            _FormatoTicketUbicacionPOS.LoadXml(_FormatoTicketUbicacion)
        End If

        If Ventas.Context.UnidadNegocio.IdZonaVenta > 0 Then
            Dim ZonaFac As New ZonaVentaFacade
            _ZonaVenta = ZonaFac.GetDetail(App.Session.SessionID, Ventas.Context.UnidadNegocio.IdZonaVenta).Nombre
        End If

        'Cargar formato de factura asignado a la sucursal
        _FormatoFactura = FormatMgr.LoadFormat(App.Session.SessionID, Ventas.Context.UnidadNegocio.IdFormatoFacturas)

        Dim config As New Azteca.Kernel.Configuration.ConfigurationFacade
        _IdTipoVenta = CInt(config.GetSystemParameter("Configuracion/Documentos/Tipos", "Venta"))
        _IdTipoDevolucion = CInt(Val(config.GetSystemParameter("Configuracion/Documentos/Tipos", "Devolucion")))
        _ClientesForm = CStr(config.GetSystemParameter("Configuracion/Ventas/POS/", "ClientesForm"))
        _HerramientasForm = CStr(config.GetSystemParameter("Configuracion/Ventas/POS/", "HerramientasForm"))

        If Not SessionTerminal.CorteAbierto Then
            MessageBox.Show("No existe un corte Activo para la Terminal {" & SessionTerminal.Terminal & "} ", "Información Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Public Shared Sub ReiniciarSesion()
        _sessionTerminal = New SessionTerminal(App.Session)
    End Sub


    Public Shared Sub CargarCaches()

    End Sub

End Class

Public Class SessionTerminal
    Public IdTerminal As Integer
    Public Terminal As String
    Public IdCaja As Integer
    Public IdCorteActual As Guid
    Public IdCajero As Integer
    Public Caja As String
    Public ImpresoraPath As String
    Public Cajero As String
    Public CorteAbierto As Boolean = False

    Public Sub New(ByVal Session As Azteca.Kernel.Security.SessionInfo)
        AbrirSession(Session)
    End Sub

    Private Sub AbrirSession(ByVal Session As Azteca.Kernel.Security.SessionInfo)
        Dim IdTerminal As Integer = 0
        Try
            IdTerminal = CInt(System.Configuration.ConfigurationManager.AppSettings("IdTerminal"))
        Catch ex As Exception
            IdTerminal = 0
        End Try

        Dim TerminalFac As New TerminalFacade
        Dim dtTerminal As DataTable = Nothing
        If IdTerminal = 0 Then
            dtTerminal = TerminalFac.LogIn(Session.SessionID, App.DefaultSite.Identity)
        Else
            dtTerminal = TerminalFac.LogInID(Session.SessionID, IdTerminal)
        End If

        If dtTerminal.Rows.Count = 0 Then
            MessageBox.Show("Esta estación de trabajo {" & App.Session.WorkStation & "} no esta definida como terminal POS." & ControlChars.CrLf & _
                             "Agreguela en el catálogo de Terminales del BackOffice", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End ''Termina la aplicacion
        Else
            Me.IdTerminal = CInt(dtTerminal(0)("IdTerminal"))
            Me.Terminal = CStr(dtTerminal(0)("Terminal"))
            Me.IdCaja = CInt(dtTerminal(0)("IdCaja"))
            Me.IdCorteActual = CType(dtTerminal(0)("IdCorteActual"), Guid)
            Me.IdCajero = CInt(dtTerminal(0)("IdCajero"))
            Me.Cajero = CStr(dtTerminal(0)("Cajero"))
            Me.Caja = CStr(dtTerminal(0)("Caja"))
            Me.ImpresoraPath = CStr(dtTerminal(0)("ImpresoraPath"))
            If Me.IdCorteActual <> New Guid("00000000000000000000000000000000") Then Me.CorteAbierto = True
        End If

    End Sub
End Class

