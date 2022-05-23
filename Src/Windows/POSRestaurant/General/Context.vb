Public NotInheritable Class Context
    Private Sub New()

    End Sub

#Region "Variables Privadas"
    Private Shared _UnidadNegocio As UnidadNegocioInfo

    Private Shared _FormatoTicketPedimento As String
    Private Shared _FormatoTicketPedimentoXML As Xml.XmlDocument
    Private Shared _FormatoTicketComanda As String
    Private Shared _FormatoTicketComandaXML As Xml.XmlDocument

    Private Shared _ArticulosTable As ArticulosConfigDS.ArticuloDataTable
    Private Shared _CentrosProduccionTable As DataTable
    Private Shared _CategoriasTable As DataTable
    Private Shared _ArticulosCentrosTable As ArticulosConfigDS.ArticuloCentroProdDataTable
    Private Shared _IdFormaPagoEfectivo As Integer
    Private Shared _FormasPagoTable As DataTable

    Private Shared _sessionTerminal As SessionTerminal
#End Region

#Region "Propiedades publicas"
    Public Shared ReadOnly Property UnidadNegocio As UnidadNegocioInfo
        Get
            Return _UnidadNegocio
        End Get
    End Property

    Public Shared ReadOnly Property ArticulosCentrosTable As ArticulosConfigDS.ArticuloCentroProdDataTable
        Get
            Return _ArticulosCentrosTable
        End Get
    End Property

    Public Shared ReadOnly Property CategoriasTable As DataTable
        Get
            Return _CategoriasTable
        End Get
    End Property

    Public Shared ReadOnly Property CentrosProduccionTable As DataTable
        Get
            Return _CentrosProduccionTable
        End Get
    End Property

    Public Shared ReadOnly Property FormasPagoTable As DataTable
        Get
            Return _FormasPagoTable
        End Get
    End Property

    Public Shared ReadOnly Property ArticulosTable As ArticulosConfigDS.ArticuloDataTable
        Get
            Return _ArticulosTable
        End Get
    End Property

    Public Shared ReadOnly Property IdFormaPagoEfectivo As Integer
        Get
            Return _IdFormaPagoEfectivo
        End Get
    End Property

    Public Shared ReadOnly Property SessionTerminal As SessionTerminal
        Get
            Return _sessionTerminal
        End Get
    End Property
#End Region

#Region "Inicializacion"

    Public Shared Sub Initialize()
        _sessionTerminal = New SessionTerminal(App.Session)


        Dim UnidadFac As New UnidadNegocioFacade
        _UnidadNegocio = UnidadFac.GetDetailByIdSucursal(App.Session.SessionID, App.DefaultSite.Identity)
        'Cargar formato de impresión
        If _UnidadNegocio.IdFormatoTicketPedimento > 0 Then
            Dim FormatMgr As New Azteca.Kernel.General.FormatManager()
            _FormatoTicketPedimento = FormatMgr.LoadFormat(App.Session.SessionID, _UnidadNegocio.IdFormatoTicketPedimento)
            _FormatoTicketPedimentoXML = New Xml.XmlDocument
            _FormatoTicketPedimentoXML.LoadXml(_FormatoTicketPedimento)
        End If

        If _UnidadNegocio.IdFormatoTicketComanda > 0 Then
            Dim FormatMgr As New Azteca.Kernel.General.FormatManager()
            _FormatoTicketComanda = FormatMgr.LoadFormat(App.Session.SessionID, _UnidadNegocio.IdFormatoTicketComanda)
            _FormatoTicketComandaXML = New Xml.XmlDocument
            _FormatoTicketComandaXML.LoadXml(_FormatoTicketComanda)
        End If

    End Sub

    Public Shared Sub InitializeCache()
        Try
            'Meseros
            'CentrosConsumo
            CargaCentrosProduccion()
            CargaCategorias()
            CargarArticulos()
            CargarFormasPago()
            Dim ConfFac As New Kernel.Configuration.ConfigurationFacade
            _IdFormaPagoEfectivo = ConfFac.GetSystemParameter("Configuracion/Ventas/FormasPago", "Efectivo")

        Catch ex As Exception
            Azteca.Windows.Forms.MsgInfo.Show(ex)
        End Try
    End Sub

    Public Shared Sub ReiniciarSesion()
        _sessionTerminal = New SessionTerminal(App.Session)
    End Sub

#End Region

#Region "Impresion de Ticket de Pedimento"

    Public Shared Sub PrintTicketPedimento(ByVal IdComandaTit As String)
        Try
            If Context.UnidadNegocio.IdFormatoTicketPedimento = 0 Then Exit Sub

            Dim IdCentroProduccion As Integer = 0, IdCentrosProdImpresos As String = ""
            Dim ComandaFac As New ComandaFacade
            Dim PedimentoGralTable As Azteca.Business.Restaurante.InformesDS.ComandaTicketPedimentoDataTable = ComandaFac.TicketPedimentoPrint(App.Session.SessionID, IdComandaTit)

            'Óbtnenemos todos los centros de produccion q estan incluidos en el detalle. Solo para aquellos q no se han entregado
            Dim CentrosProduccionTB As New DataTable("CentrosProduccion")
            Dim myDataColumn As New DataColumn("IdCentroProduccion")
            myDataColumn.DataType = System.Type.GetType("System.Int32")
            CentrosProduccionTB.Columns.Add(myDataColumn)
            'Dim ds As New DataSet
            'ds.Tables.Add(PedimentoGralTable)
            'ds.WriteXml("C:Pedimento.XML")

            Dim dv As New DataView(PedimentoGralTable, "", "IdCentroProduccion", DataViewRowState.CurrentRows)
            For Each dr As DataRowView In dv
                If IdCentroProduccion <> CInt(dr("IdCentroProduccion")) Then
                    Dim drNew As DataRow = CentrosProduccionTB.NewRow
                    drNew("IdCentroProduccion") = CInt(dr("IdCentroProduccion"))
                    CentrosProduccionTB.Rows.Add(drNew)
                End If
                IdCentroProduccion = CInt(dr("IdCentroProduccion"))
            Next

            'Mandamos a imprimir por cada centro de produccion
            For Each dr As DataRow In CentrosProduccionTB.Rows
                Dim PedimentoCloneTable As Azteca.Business.Restaurante.InformesDS.ComandaTicketPedimentoDataTable = PedimentoTableClone(dr("IdCentroProduccion"), PedimentoGralTable)
                Dim ImpresoraCentroProduccion As String = ""

                If PedimentoCloneTable(0).IsRutaNull Then
                    MessageBox.Show("No se ha establecido una impresora para el centro de producción [" & PedimentoCloneTable(0)("CentroProduccion") & "]", "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ImpresoraCentroProduccion = PedimentoCloneTable(0).Ruta
                    'Vamos a ver q tipo de formato trae el pedimento, Si es un formato xml o uno rdlc
                    If Mid(_FormatoTicketPedimento, 1, 13) = "<Report xmlns" Then 'rdcl 
                        Dim frmFactura As New ReportForm
                        Dim Reader As New System.IO.StringReader(_FormatoTicketPedimento)
                        frmFactura.LocalReport.LoadReportDefinition(Reader)
                        frmFactura.LocalReport.DataSources.Add(New ReportDataSource("TicketPedimento", CType(PedimentoCloneTable, DataTable)))
                        ''frmFactura.ShowDialog()
                        frmFactura.PrintToPrinter(ImpresoraCentroProduccion)
                    Else 'xml
                        Dim Ticket As New Azteca.Windows.Printing.Report
                        Ticket.Load(_FormatoTicketPedimentoXML)
                        Dim Engine As New Azteca.Windows.Printing.PrintEngine(Ticket)
                        Engine.Data = PedimentoCloneTable
                        Engine.PrintReport(ImpresoraCentroProduccion)
                    End If
                End If
                If IdCentrosProdImpresos.Length > 0 Then IdCentrosProdImpresos = IdCentrosProdImpresos + ","
                IdCentrosProdImpresos = IdCentrosProdImpresos + CStr(dr("IdCentroProduccion"))
            Next

            'Marcamos la cantidad Entregada de los centros de produccion.
            ComandaFac.MarcarPedimentoImpreso(App.Session.SessionID, IdComandaTit, IdCentrosProdImpresos)

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

    End Sub

    Private Shared Function PedimentoTableClone(ByVal idCentroProduccion As Integer, ByVal PedimentoGralTable As Azteca.Business.Restaurante.InformesDS.ComandaTicketPedimentoDataTable) As Azteca.Business.Restaurante.InformesDS.ComandaTicketPedimentoDataTable
        Dim PedimentoCloneTable As New Azteca.Business.Restaurante.InformesDS.ComandaTicketPedimentoDataTable
        Dim dv As New DataView(PedimentoGralTable, "IdCentroProduccion=" & idCentroProduccion, "", DataViewRowState.CurrentRows)
        For Each drv As DataRowView In dv
            PedimentoCloneTable.ImportRow(drv.Row)
        Next
        Return PedimentoCloneTable
    End Function

#End Region

#Region "Impresion Ticket Comanda"
    Public Shared Sub PrintTicketComanda(ByVal IdComandaTit As String, ByVal ImpresoraPath As String)
        Dim ComandaFac As New ComandaFacade
        If Context.UnidadNegocio.IdFormatoTicketComanda > 0 Then
            Dim ComandaTable As Azteca.Business.Restaurante.InformesDS.ComandaTicketDataTable = ComandaFac.TicketPrint(App.Session.SessionID, IdComandaTit)

            'Vamos a ver q tipo de formato trae el cheque, Si es un formato xml o uno rdlc
            If Mid(_FormatoTicketComanda, 1, 13) = "<Report xmlns" Then 'rdcl 
                Dim frmFactura As New ReportForm
                Dim Reader As New System.IO.StringReader(_FormatoTicketComanda)
                frmFactura.LocalReport.LoadReportDefinition(Reader)
                frmFactura.LocalReport.DataSources.Add(New ReportDataSource("ComandaTicket", CType(ComandaTable, DataTable)))
                frmFactura.PrintToPrinter(ImpresoraPath)
            Else 'xml
                Dim Ticket As New Azteca.Windows.Printing.Report
                Ticket.Load(_FormatoTicketComandaXML)
                Dim Engine As New Azteca.Windows.Printing.PrintEngine(Ticket)
                Engine.Data = ComandaTable
                Engine.PrintReport(ImpresoraPath)
            End If
        End If
    End Sub

#End Region

#Region "Carga de datos"

    Private Shared Sub CargaCategorias()
        Dim categoriaFac As New CategoriaFacade
        _CategoriasTable = categoriaFac.LoadDataButtons(App.Session.SessionID, App.DefaultSite.Identity)
    End Sub
    Private Shared Sub CargaCentrosProduccion()
        Dim CentroProdfac As New CentroProduccionFacade
        _CentrosProduccionTable = CentroProdfac.LoadDataButtons(App.Session.SessionID, App.DefaultSite.Identity)
        _ArticulosCentrosTable = CentroProdfac.loadArticulos(App.Session.SessionID, App.DefaultSite.Identity)
    End Sub
    Private Shared Sub CargarArticulos()
        Dim ArtFac As New Azteca.Business.Restaurante.ArticuloFacade
        _ArticulosTable = ArtFac.LoadListDataButtons(App.Session.SessionID, App.DefaultSite.Identity)
    End Sub

    Private Shared Sub CargarFormasPago()
        Dim formaPagoFac As New FormaPagoFacade
        _FormasPagoTable = formaPagoFac.LoadButtonsList(App.Session.SessionID, App.DefaultSite.Identity)
    End Sub


#End Region



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
