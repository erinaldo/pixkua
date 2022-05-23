Public Class PuntoVentaForm
    Private OperacionTipo As OperacionEnum = OperacionEnum.Ninguna
    Private Venta As Azteca.Business.Ventas.VentaInfo
    Private idClienteGenerico As Integer = 0

#Region "Inicializar Aplicacion"
    Private Config As String = String.Empty
    Private LogedIn As Boolean = False
    Private buffer As PolicyBuffer

    Private Sub InicializarAplicacion()
        Try
            Azteca.Windows.App.InitSystem("Pixkua")
            Azteca.Windows.General.LicenseStorage.CreateLicenseCache()
            'Desplegar versión del programa
            ''''''lvwInfo.Items(4).Text = "Version " & My.Application.Info.Version.ToString
            'Mostrar pantalla de splash
            SplashForm.ShowDialog()
            'Verificar si el sistema utiliza un servidor de aplicaciones
            Dim UsesRemoteCalls As Boolean = CBool(System.Configuration.ConfigurationManager.AppSettings("UseRemoteCalls"))
            'Si no se utiliza un servidor de aplicaciones cargar conexión a servidor de datos
            If Not UsesRemoteCalls Then
                Azteca.Kernel.Server.Initialize("PixkuaPOS", True)
                'Si no se encontró archivo de conexión, pedir información de conexión
                If Not Azteca.Kernel.Server.TestConnection Then
                    MessageBox.Show("Por favor verifique la información de conexión al servidor de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ConfigureDataAccess()
                    Azteca.Kernel.Server.Initialize("PixkuaPOS", True)
                End If
                ''''''lvwInfo.Items(5).Text = "NO REMOTING"
                'lvwInfo.Items.Add(Azteca.Kernel.Server.ServerName, "Servidor")
            Else
                'Si se presionó F2 durante el splash, permitir cambiar la configuración de comunicación
                ''If SplashForm.ChangeConfig Then ConfigureRemoteConnection()
                'Limpiar canales registrados
                For Each channel As System.Runtime.Remoting.Channels.IChannel In System.Runtime.Remoting.Channels.ChannelServices.RegisteredChannels
                    System.Runtime.Remoting.Channels.ChannelServices.UnregisterChannel(channel)
                Next
                'Obtener el tipo de configuración de remoting
                Config = "REMOTING ACTIVADO"
                'Config = Registry.GetValue("Remoting", "Type", "LAN")
                'Select Case Config
                '    Case "LAN"
                '        System.Runtime.Remoting.RemotingConfiguration.Configure("LAN.config", False)
                '    Case "WEB"
                '        System.Runtime.Remoting.RemotingConfiguration.Configure("WEB.config", False)
                '    Case "TEST"
                '        System.Runtime.Remoting.RemotingConfiguration.Configure("Test.config", False)
                '    Case Else
                '        System.Runtime.Remoting.RemotingConfiguration.Configure("Pixcua.exe.config", False)
                'End Select
                System.Runtime.Remoting.RemotingConfiguration.Configure("Pixkua.exe.config", False)

            End If
            LoginUser()

            If Not IsNothing(App.Session.SessionID) Then
                Context.Initialize()
                'Cargar de forma asincrona los cachés necesarios
                lblCajeroTXT.Text = "[" & Context.SessionTerminal.Caja & "] - " & Context.SessionTerminal.Cajero
                cmdHerramientas.Visible = Context.HerramientasForm.Length > 0
                Dim TaskCache As New Task(Sub() Context.CargarCaches())
                TaskCache.Start()
            End If

        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try

    End Sub


#Region "Metodos Privados"
    Private Sub ConfigureDataAccess()
        Dim frmConfig As New DataConfigForm()
        frmConfig.ShowDialog()
        Azteca.Kernel.Server.Initialize("Pixcua", True)
    End Sub

    Private Sub LoginUser()
        Dim Login As New Azteca.Windows.Forms.LoginForm()
        If Login.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            LogedIn = True
            InitializeContext()
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            LoadSiteConfiguration()
            ''''''Me.pnlUsuario.Text = App.Session.User.UserName
            ''''''Me.pnlFecha.Text = App.Session.BussinesDate.ToLongDateString
        Else
            If Not LogedIn Then Me.Close()
        End If
    End Sub

    Private Sub InitializeContext()
        ''''''Azteca.Windows.Ventas.Context.Initialize()
    End Sub

    Private Sub LoadSiteConfiguration()
        ''''''LoadMenu()
        ''''''DisplayUserInfo()
        'QuitarHuerfanos(CType(tvwMenu.Nodes(0), StructureNode))
        If App.DefaultCompany.Logo IsNot Nothing Then
            Dim msLogo As New MemoryStream(App.DefaultCompany.Logo)
            Dim Logo As Image = Image.FromStream(msLogo)
            ''''''Dim BackImage As New Bitmap(Logo, lvwProcesos.Width, lvwProcesos.Height)
            ''''''lvwProcesos.BackgroundImage = BackImage
        End If
        buffer = New PolicyBuffer()
    End Sub


#End Region

#End Region

#Region "Manejo de eventos"

    Private Sub PuntoVentaForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            InicializarAplicacion()
            'Resetear Pantalla
            PantallaEstado(EstadoPantallaEnum.SinOperacion)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As System.EventArgs) Handles txtCodigo.TextChanged
        LimpiarArticulo()
    End Sub

    Private Sub PuntoVentaForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 112 Then 'F1'
            IniciarVenta() : Me.KeyPreview = False
        ElseIf e.KeyCode = 113 Then 'F2'
            IniciarDevolucion() : Me.KeyPreview = False
        ElseIf e.KeyCode = 114 Then 'F3'
            Facturar() : Me.KeyPreview = False
        ElseIf e.KeyCode = 118 Then 'F7'
            Herramientas()
        ElseIf e.KeyCode = 36 Then
            If btnCorteAbrir.Enabled Then AbrirCorte()
        ElseIf e.KeyCode = 35 Then
            If btnCorteCerrar.Enabled Then CerrarCorte()
        ElseIf e.KeyCode = 122 Then 'F11' Imprimir corte
            If btnCortePrint.Enabled Then ImprimirCorte()
        ElseIf e.KeyCode = 123 Then 'F12' SAlir
            SalirPOS()
        End If
    End Sub

    Private Sub lvwDetalle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvwDetalle.KeyDown
        If e.KeyCode = 45 Then 'INS
            CambiarCantidad()
        ElseIf e.KeyCode = 46 Then 'DEL
            EliminarArticulo()
        ElseIf e.KeyCode = 113 Then 'F2
            CambiarDescripcion()
        ElseIf e.KeyCode = 114 Then 'F3
            CambiarPrecio()
        ElseIf e.KeyCode = 115 Then 'F4
            AplicarDescuentoIndividual()
        ElseIf e.KeyCode = 13 Then
            PantallaEstado(EstadoPantallaEnum.EditandoDetalleOK)
        End If
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = 112 Then 'F1'

        ElseIf e.KeyCode = 113 Then 'F2'
            If Venta.Articulos.Rows.Count + Venta.Servicios.Count > 0 Then PantallaEstado(EstadoPantallaEnum.EditandoDetalle)
        ElseIf e.KeyCode = 114 Then 'F3'Buscar
            Busqueda()
        ElseIf e.KeyCode = 115 Then 'F4'Buscar X Estructura Venta
            BusquedaEstCom()
        ElseIf e.KeyCode = 116 Then 'F5' Cobranza
            Cobranza()
        ElseIf e.KeyCode = 117 Then 'F6' Cancelar
            CancelarCaptura()
        ElseIf e.KeyCode = 118 Then 'F7' Herramientas 
            Herramientas()
        ElseIf e.KeyCode = 123 Then 'F12' Salir
            SalirPOS()
        ElseIf e.KeyCode = 13 Then 'Enter' Codigo Capturado
            Dim Artfac As New PresentacionFacade
            Dim Servfac As New ServicioFacade
            Dim ArticuloSelTable As ArticulosDS.ArticulosVentaPOSDataTable = Artfac.GetPOSInfo(App.Session.SessionID, txtCodigo.Text, Ventas.Context.UnidadNegocio.IdZonaVenta)

            If ArticuloSelTable.Rows.Count > 0 Then
                ArticuloSelected(ArticuloSelTable)
            Else
                If Servfac.Exists(App.Session.SessionID, txtCodigo.Text, App.DefaultSite.Identity) Then
                    ServicioSelected(txtCodigo.Text)
                Else
                    MessageBox.Show("El articulo/servicio no existe o no esta disponible en la zona de venta", "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            End If
        End If

    End Sub

    Private Sub cmdEditar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        PantallaEstado(EstadoPantallaEnum.EditandoDetalle)
    End Sub

    Private Sub cmdEdicionOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdEditarOk.Click
        TerminarEdicion()
    End Sub

    Private Sub cmdCantidad_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCantidad.Click
        CambiarCantidad()
    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        EliminarArticulo()
    End Sub

    Private Sub cmdCambioPrecio_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCambioPrecio.Click
        CambiarPrecio()
    End Sub

    Private Sub cmdDesctoIndividual_ClickButtonArea(Sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles cmdDesctoIndividual.ClickButtonArea
        AplicarDescuentoIndividual()
    End Sub

    Private Sub cmdCambioDescripcion_ClickButtonArea(Sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles cmdCambioDescripcion.ClickButtonArea
        CambiarDescripcion()
    End Sub

    Private Sub cmdPagar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPagar.Click
        Cobranza()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        CancelarCaptura()
    End Sub

    Private Sub cmdVenta_ClickButtonArea(Sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles cmdVenta.ClickButtonArea
        IniciarVenta()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        SalirPOS()
    End Sub

    Private Sub btnAbrirCorte_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCorteAbrir.Click
        AbrirCorte()
    End Sub

    Private Sub btnCorteCerrar_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnCorteCerrar.ClickButtonArea
        CerrarCorte()
    End Sub

    Private Sub btnCortePrint_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnCortePrint.ClickButtonArea
        ImprimirCorte()
    End Sub

    Private Sub cmdFacturar_ClickButtonArea(Sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles cmdFacturar.ClickButtonArea
        Facturar()
    End Sub

    Private Sub cmdBuscarArt_ClickButtonArea(Sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles cmdBuscarArt.ClickButtonArea
        Busqueda()
    End Sub

    Private Sub cmdBuscarEstCom_ClickButtonArea(Sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles cmdBuscarEstCom.ClickButtonArea
        BusquedaEstCom()
    End Sub

    Private Sub cmdHerramientas_ClickButtonArea(Sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles cmdHerramientas.ClickButtonArea
        Herramientas()
    End Sub

    Private Sub ArticuloSelected(ByVal IdArticuloStock As Integer)
        Dim Artfac As New PresentacionFacade
        Dim ArticuloSelTable As ArticulosDS.ArticulosVentaPOSDataTable = Artfac.GetPOSInfo(App.Session.SessionID, IdArticuloStock, Ventas.Context.UnidadNegocio.IdZonaVenta)

        If ArticuloSelTable.Rows.Count = 0 Then
            MessageBox.Show("El articulo no existe o no esta disponible en la zona de venta", "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            Dim drArticulo As ArticulosDS.ArticulosVentaPOSRow = CType(ArticuloSelTable.Rows(0), ArticulosDS.ArticulosVentaPOSRow)
            Dim Precio As PrecioInfo = getPrecioArticulo(IdArticuloStock, 0)
            AgregarArticulo(drArticulo, Precio)
        End If

        txtCodigo.Focus()

    End Sub

    Private Sub ArticuloSelected(ByVal Codigo As String)
        Try
            Dim Artfac As New PresentacionFacade
            Dim ArticuloSelTable As ArticulosDS.ArticulosVentaPOSDataTable = Artfac.GetPOSInfo(App.Session.SessionID, Codigo, Ventas.Context.UnidadNegocio.IdZonaVenta)

            If ArticuloSelTable.Rows.Count = 0 Then
                MessageBox.Show("El articulo no existe o no esta disponible en la zona de venta", "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else
                Dim drArticulo As ArticulosDS.ArticulosVentaPOSRow = CType(ArticuloSelTable.Rows(0), ArticulosDS.ArticulosVentaPOSRow)
                Dim IdArticuloStock As Integer = CInt(drArticulo("IdArticuloStock"))
                Dim Precio As PrecioInfo = getPrecioArticulo(IdArticuloStock, 0)
                AgregarArticulo(drArticulo, Precio)
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

        txtCodigo.Focus()
    End Sub

    Private Sub ArticuloSelected(ArticuloSelTable As ArticulosDS.ArticulosVentaPOSDataTable)
        Try
            If ArticuloSelTable.Rows.Count = 0 Then
                MessageBox.Show("El articulo no existe o no esta disponible en la zona de venta", "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else
                Dim drArticulo As ArticulosDS.ArticulosVentaPOSRow = CType(ArticuloSelTable.Rows(0), ArticulosDS.ArticulosVentaPOSRow)
                Dim IdArticuloStock As Integer = CInt(drArticulo("IdArticuloStock"))
                Dim Precio As PrecioInfo = getPrecioArticulo(IdArticuloStock, 0)
                AgregarArticulo(drArticulo, Precio)
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
        txtCodigo.Focus()
    End Sub


    Private Sub ServicioSelected(ByVal Codigo As String)
        Try
            Dim Servfac As New ServicioFacade

            'Dim ServiciosSelTable As ArticulosDS.ArticulosVentaPOSDataTable = Servfac.GetPOSInfo(App.Session.SessionID, Codigo, Ventas.Context.UnidadNegocio.IdZonaVenta)

            If Not Servfac.Exists(App.Session.SessionID, Codigo, App.DefaultSite.Identity) Then
                MessageBox.Show("El servicio no existe o no esta disponible en la zona de venta", "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else
                Dim Servicio As ServicioInfo = Servfac.GetDetail(App.Session.SessionID, Codigo, App.DefaultSite.Identity)
                Dim IdServicio As Integer = Servicio.Identity 'CInt(drArticulo("IdServicio"))
                Dim Precio As PrecioInfo = getPrecioServicio(IdServicio, 0)
                AgregarServicio(Servicio, Precio)
            End If

            txtCodigo.Focus()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
       
    End Sub

#End Region

#Region "Metodos Privados"
    Private Sub AbrirCorte()
        Try
            Dim cajafac As New CajaFacade
            Dim Caja As CajaInfo = cajafac.GetDetail(App.Session.SessionID, Context.SessionTerminal.IdCaja)

            If Caja.IdCorteActual <> New Guid("00000000000000000000000000000000") Then
                MessageBox.Show("La caja tiene  un corte abierto", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            Dim frm As New AbrirCajaForm
            frm.StartPosition = FormStartPosition.CenterParent
            If frm.ShowDialog(Me, Context.SessionTerminal.IdCaja, Context.SessionTerminal.Caja) = System.Windows.Forms.DialogResult.OK Then
                Context.ReiniciarSesion()
                PantallaEstado(EstadoPantallaEnum.SinOperacion)
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

    End Sub

    Private Sub CerrarCorte()
        If MessageBox.Show("Esta seguro de querer hacer el cierre del Corte Caja?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
            Try
                Dim CajaFac As New CajaFacade
                CajaFac.Cerrar(App.Session.SessionID, Context.SessionTerminal.IdCorteActual)
                MessageBox.Show("Se ha realizado el cierre de la caja", "Corte", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Context.ReiniciarSesion()
                PantallaEstado(EstadoPantallaEnum.SinOperacion)
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        End If
    End Sub

    Private Sub ImprimirCorte()
        Try
            Dim frm As New ImpresionCorteForm
            If frm.ShowDialog(Me, Context.SessionTerminal.IdCaja, Context.SessionTerminal.Caja) = System.Windows.Forms.DialogResult.OK Then

            End If


            'Dim CajaFac As New CajaFacade
            'Dim dtCorte As Azteca.Business.Ventas.InformesDS.CorteCajaDataTable = CajaFac.LoadCortePrintInfo(App.Session.SessionID, Context.SessionTerminal.IdCorteActual)
            ''Definir parametros del informe
            'Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
            'Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))
            'Parametros.Add(New ReportParameter("Sucursal", App.DefaultSite.NombreLargo))

            ''Mostrar vista previa de la venta
            'Dim frmReport As New ReportForm
            'frmReport.LocalReport.ReportEmbeddedResource = "Azteca.Windows.Ventas.Retail.CorteCajaRPT.rdlc"
            'frmReport.LocalReport.DataSources.Add(New ReportDataSource("Corte", CType(dtCorte, DataTable)))
            'frmReport.LocalReport.SetParameters(Parametros)
            'frmReport.Show("Corte de caja")
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

    End Sub

    Private Function SeleccionaCliente() As ClienteInfo
        Dim Cliente As ClienteInfo = Nothing

        If Context.ClientesForm.Trim.Length > 0 Then
            If Context.ClientesForm = "Pacientes" Then
                Dim frm As New Azteca.Windows.Medicina.PacienteSearch
                If frm.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    Cliente = frm.Cliente
                Else
                    Dim frmP As New Azteca.Windows.Medicina.PacientesForm
                    If frmP.ShowDialog(0, "Agregar Cliente") = System.Windows.Forms.DialogResult.OK Then
                        Cliente = CType(frmP.PackageInfo, Azteca.Business.Medicina.PacienteInfo).Cliente
                    End If
                End If
            ElseIf Context.ClientesForm = "ClientesExpress" Then
                Dim frm As New selClienteForm
                If frm.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    Cliente = frm.Cliente
                End If
            ElseIf Context.ClientesForm = "Clientes" Then

            End If
        End If

        Return Cliente
    End Function

    Private Sub IniciarVenta()
        Try
    
            Dim idCliente As Integer = 0

            'Cliente Generico default
            lblCajeroTXT.Text = "[" & Context.SessionTerminal.Caja & "] - " & Context.SessionTerminal.Cajero
            lblClienteText.Text = "[" & Ventas.Context.UnidadNegocio.IdClienteGenerico & "] - " & "Cliente General"
            idCliente = Ventas.Context.UnidadNegocio.IdClienteGenerico

            Dim Cliente As ClienteInfo = SeleccionaCliente()
            If Not IsNothing(Cliente) Then
                idCliente = Cliente.Identity
                lblClienteText.Text = "[" & Cliente.UserCode & "] - " & Cliente.Nombre
            End If


            'Datos de la venta
            Venta = New Azteca.Business.Ventas.VentaInfo(App.Session.SessionID)
            Venta.IdCliente = idCliente
            Venta.Hora = Date.Today '': Venta.IdReferencia = Comanda.Identity
            Venta.IdSucursal = App.DefaultSite.Identity
            Venta.Observaciones = "POS"
            Venta.Origen = Azteca.Business.Ventas.OrigenVenta.POS : Venta.IdSucursal = App.DefaultSite.Identity
            Venta.IdDivisa = Ventas.Context.UnidadNegocio.IdDivisaBase
            Venta.IdTerminal = Context.SessionTerminal.IdTerminal
            Venta.IdCaja = Context.SessionTerminal.IdCaja
            OperacionTipo = OperacionEnum.Venta
            lblOperacion.Text = "Venta"
            PantallaEstado(EstadoPantallaEnum.EnOperacion)
            txtCodigo.Focus()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

    End Sub

    Private Sub IniciarDevolucion()
        Venta.IdSucursal = App.DefaultSite.Identity
        Venta.Observaciones = "POS"
        Venta.Origen = Azteca.Business.Ventas.OrigenVenta.POS : Venta.IdSucursal = App.DefaultSite.Identity
        OperacionTipo = OperacionEnum.Devolucion

        lblOperacion.Text = "Devolucion"
        PantallaEstado(EstadoPantallaEnum.EnOperacion)
        txtCodigo.Focus()

    End Sub

    Private Sub Facturar()
        lblOperacion.Text = "Facturando Venta"
        OperacionTipo = OperacionEnum.Facturando
        PantallaEstado(EstadoPantallaEnum.EnOperacion)

        Dim Facturar As New FacturarVentaForm
        Facturar.ShowDialog()

        OperacionTipo = OperacionEnum.Ninguna
        PantallaEstado(EstadoPantallaEnum.SinOperacion)

    End Sub

    Private Function getPrecioArticulo(IdArticuloStock As Integer, PrecioFijo As Decimal) As PrecioInfo
        Dim Artfac As New PresentacionFacade
        Dim Precio As PrecioInfo = Nothing

        If Ventas.Context.UnidadNegocio.TipoPrecio = TipoPrecio.ZonasVenta Then
            Precio = Artfac.GetPrecio(App.Session.SessionID, IdArticuloStock, PrecioFijo, Ventas.Context.UnidadNegocio.IdZonaVenta)
        ElseIf Ventas.Context.UnidadNegocio.TipoPrecio = Business.Ventas.TipoPrecio.ListaPrecio Then
            Precio = Artfac.GetPrecio(App.Session.SessionID, IdArticuloStock, Venta.IdCliente, App.DefaultSite.Identity, PrecioFijo)
        End If

        Return Precio
    End Function

    Private Function getPrecioServicio(IdServicio As Integer, PrecioFijo As Decimal) As PrecioInfo
        Dim Servfac As New ServicioFacade
        Dim Precio As PrecioInfo = Nothing

        If Ventas.Context.UnidadNegocio.TipoPrecio = TipoPrecio.ZonasVenta Then
            Precio = Servfac.GetPrecio(App.Session.SessionID, IdServicio, Venta.IdCliente, App.DefaultSite.Identity)
        ElseIf Ventas.Context.UnidadNegocio.TipoPrecio = Business.Ventas.TipoPrecio.ListaPrecio Then
            Precio = Servfac.GetPrecio(App.Session.SessionID, IdServicio, Venta.IdCliente, App.DefaultSite.Identity, PrecioFijo)
        End If

        Return Precio
    End Function

    Private Sub AgregarArticulo(drArticuloSel As ArticulosDS.ArticulosVentaPOSRow, Precio As PrecioInfo) '(ByVal drArticuloSel As ArticulosDS.ArticulosVentaPOSRow)
        txtCodigo.Text = ""
        Dim drArticulo As Azteca.Business.Ventas.DetalleVentaDS.ArticulosRow = Venta.Articulos.FindByIdArticuloStock(drArticuloSel.IdArticuloStock)
        If drArticulo Is Nothing Then
            drArticulo = Venta.Articulos.NewArticulosRow
            lblDescripcion.Text = drArticuloSel.Articulo
            txtCantidad.Text = "1"

            drArticulo.IdArticuloStock = drArticuloSel.IdArticuloStock : drArticulo.Cantidad = CDec(txtCantidad.Text) : drArticulo.Codigo = drArticuloSel.Codigo : drArticulo.Descripcion = drArticuloSel.Articulo

            drArticulo.IdDivisa = Precio.IdDivisa : drArticulo.PrecioUnitario = Precio.Precio
            'Impuestos
            drArticulo.IdImpuesto1 = Precio.IdImpuesto1 : drArticulo.IdImpuesto2 = Precio.IdImpuesto2 : drArticulo.IdImpuesto3 = Precio.IdImpuesto3 : drArticulo.IdImpuesto4 = Precio.IdImpuesto4 : drArticulo.IdImpuesto5 = Precio.IdImpuesto5
            drArticulo.PorcImpTras1 = Precio.PorcentajeImpuesto1 : drArticulo.PorcImpTras2 = Precio.PorcentajeImpuesto2 : drArticulo.PorcImpTras3 = Precio.PorcentajeImpuesto3 : drArticulo.PorcImpTras4 = Precio.PorcentajeImpuesto4 : drArticulo.PorcImpTras5 = Precio.PorcentajeImpuesto5
            drArticulo.MontoImpTras1 = Precio.MontoImpuesto1 : drArticulo.MontoImpTras2 = Precio.MontoImpuesto2 : drArticulo.MontoImpTras3 = Precio.MontoImpuesto3 : drArticulo.MontoImpTras4 = Precio.MontoImpuesto4 : drArticulo.MontoImpTras5 = Precio.MontoImpuesto5
            'Descuentos
            drArticulo.PorcDescuento1 = Precio.PorcentajeDescuento1 : drArticulo.PorcDescuento2 = Precio.PorcentajeDescuento2 : drArticulo.PorcDescuento3 = Precio.PorcentajeDescuento3 : drArticulo.PorcDescuento4 = Precio.PorcentajeDescuento4 : drArticulo.PorcDescuento5 = Precio.PorcentajeDescuento5
            drArticulo.MontoDesc1 = Precio.MontoDescuento1 : drArticulo.MontoDesc2 = Precio.MontoDescuento2 : drArticulo.MontoDesc3 = Precio.MontoDescuento3 : drArticulo.MontoDesc4 = Precio.MontoDescuento4 : drArticulo.MontoDesc5 = Precio.MontoDescuento5

            drArticulo.IdUnidadMedida = drArticuloSel.IdUnidadMedida
            drArticulo.UnidadMedida = drArticuloSel.UMV
            Venta.Articulos.AddArticulosRow(drArticulo)
        Else
            lblDescripcion.Text = drArticulo.Descripcion
            txtCantidad.Text = "1"
            drArticulo.Cantidad = drArticulo.Cantidad + CDec(txtCantidad.Text)
        End If

        lblTotal.Text = Format(drArticulo.PrecioUnitario + _
                        drArticulo.MontoImpTras1 + drArticulo.MontoImpTras2 + drArticulo.MontoImpTras3 + drArticulo.MontoImpTras4 + drArticulo.MontoImpTras5 _
                        , "0.00")

        Venta.CalcularTotales(Ventas.Context.UnidadNegocio.PoliticaDescuento)
        fillVenta()
        lvwDetalle.EnsureVisible(Venta.Articulos.Rows.Count + Venta.Servicios.Count - 1)
        txtCodigo.Focus()
    End Sub

    Private Sub AgregarServicio(Servicio As ServicioInfo, Precio As PrecioInfo) '(ByVal drArticuloSel As ArticulosDS.ArticulosVentaPOSRow)
        txtCodigo.Text = ""
        Dim drServicio As Azteca.Business.Ventas.DetalleVentaDS.ServiciosRow 'Venta.Servicios.findByIdServicio(Servicio.Identity)
        'Dim dv As New DataView(Venta.Servicios, "IdServicio=" & Servicio.Identity, "", DataViewRowState.CurrentRows)

        'If drServicio Is Nothing Then
        drServicio = Venta.Servicios.NewServiciosRow
        lblDescripcion.Text = Servicio.Nombre
        txtCantidad.Text = "1"

        drServicio.IdServicio = Servicio.Identity : drServicio.Cantidad = CDec(txtCantidad.Text) : drServicio.Codigo = Servicio.UserCode : drServicio.Descripcion = Servicio.Nombre

        drServicio.IdDivisa = Precio.IdDivisa : drServicio.PrecioUnitario = Precio.Precio
        'Impuestos
        drServicio.IdImpuesto1 = Precio.IdImpuesto1 : drServicio.IdImpuesto2 = Precio.IdImpuesto2 : drServicio.IdImpuesto3 = Precio.IdImpuesto3 : drServicio.IdImpuesto4 = Precio.IdImpuesto4 : drServicio.IdImpuesto5 = Precio.IdImpuesto5
        drServicio.PorcImpTras1 = Precio.PorcentajeImpuesto1 : drServicio.PorcImpTras2 = Precio.PorcentajeImpuesto2 : drServicio.PorcImpTras3 = Precio.PorcentajeImpuesto3 : drServicio.PorcImpTras4 = Precio.PorcentajeImpuesto4 : drServicio.PorcImpTras5 = Precio.PorcentajeImpuesto5
        drServicio.MontoImpTras1 = Precio.MontoImpuesto1 : drServicio.MontoImpTras2 = Precio.MontoImpuesto2 : drServicio.MontoImpTras3 = Precio.MontoImpuesto3 : drServicio.MontoImpTras4 = Precio.MontoImpuesto4 : drServicio.MontoImpTras5 = Precio.MontoImpuesto5
        'Descuentos
        drServicio.PorcDescuento1 = Precio.PorcentajeDescuento1 : drServicio.PorcDescuento2 = Precio.PorcentajeDescuento2 : drServicio.PorcDescuento3 = Precio.PorcentajeDescuento3 : drServicio.PorcDescuento4 = Precio.PorcentajeDescuento4 : drServicio.PorcDescuento5 = Precio.PorcentajeDescuento5
        drServicio.MontoDesc1 = Precio.MontoDescuento1 : drServicio.MontoDesc2 = Precio.MontoDescuento2 : drServicio.MontoDesc3 = Precio.MontoDescuento3 : drServicio.MontoDesc4 = Precio.MontoDescuento4 : drServicio.MontoDesc5 = Precio.MontoDescuento5

        Venta.Servicios.AddServiciosRow(drServicio)
        'Else
        'lblDescripcion.Text = drServicio.Descripcion
        'txtCantidad.Text = "1"
        'drServicio.Cantidad = drServicio.Cantidad + CDec(txtCantidad.Text)
        'End If

        lblTotal.Text = Format(drServicio.PrecioUnitario + _
                        drServicio.MontoImpTras1 + drServicio.MontoImpTras2 + drServicio.MontoImpTras3 + drServicio.MontoImpTras4 + drServicio.MontoImpTras5 _
                        , "0.00")

        Venta.CalcularTotales(Ventas.Context.UnidadNegocio.PoliticaDescuento)
        fillVenta()
        lvwDetalle.EnsureVisible(Venta.Articulos.Rows.Count + Venta.Servicios.Rows.Count - 1)
        txtCodigo.Focus()

    End Sub

    Private Sub LimpiarArticulo()
        'txtCodigo.Text = ""
        txtCantidad.Text = ""
        lblDescripcion.Text = ""
        lblTotal.Text = ""
    End Sub

    Private Sub fillVenta()
        lvwDetalle.BeginUpdate()
        lvwDetalle.Items.Clear()
        ''Dim vwOrdenes As New DataView(dtOrdenes, "", "Fecha DESC, SUCURSAL", DataViewRowState.CurrentRows)
        For Each dr As Azteca.Business.Ventas.DetalleVentaDS.ArticulosRow In Venta.Articulos
            Dim Item As New ListViewItem(dr.Codigo, 0)
            Dim PrecioConImpuestos As Decimal = dr.PrecioUnitario + dr.MontoImpTras1 + dr.MontoImpTras2 + dr.MontoImpTras3
            Dim PrecioConImpuestosDesctos As Decimal = dr.PrecioUnitario + dr.MontoImpTras1 + dr.MontoImpTras2 + dr.MontoImpTras3 - dr.MontoDesc1 - dr.MontoDesc2 - dr.MontoDesc3
            Item.SubItems.Add((dr.Descripcion.ToString))
            Item.SubItems.Add((dr.Cantidad.ToString("#0")))
            Item.SubItems.Add(dr.UnidadMedida) ''unidad
            Item.SubItems.Add((PrecioConImpuestos.ToString("#0.00")))
            Item.SubItems.Add((PrecioConImpuestosDesctos.ToString("#0.00")))
            Item.SubItems.Add(((PrecioConImpuestosDesctos) * dr.Cantidad).ToString("#0.00"))
            Item.Tag = CType(dr, Azteca.Business.Ventas.DetalleVentaDS.ArticulosRow)
            lvwDetalle.Items.Add(Item)
        Next
        For Each dr As Azteca.Business.Ventas.DetalleVentaDS.ServiciosRow In Venta.Servicios
            Dim Item As New ListViewItem(dr.Codigo, 0)
            Dim PrecioConImpuestos As Decimal = dr.PrecioUnitario + dr.MontoImpTras1 + dr.MontoImpTras2 + dr.MontoImpTras3
            Dim PrecioConImpuestosDesctos As Decimal = dr.PrecioUnitario + dr.MontoImpTras1 + dr.MontoImpTras2 + dr.MontoImpTras3 - dr.MontoDesc1 - dr.MontoDesc2 - dr.MontoDesc3
            Item.SubItems.Add((dr.Descripcion.ToString))
            Item.SubItems.Add((dr.Cantidad.ToString("#0")))
            Item.SubItems.Add("") ''unidad
            Item.SubItems.Add((PrecioConImpuestos.ToString("#0.00")))
            Item.SubItems.Add((PrecioConImpuestosDesctos.ToString("#0.00")))
            Item.SubItems.Add(((PrecioConImpuestosDesctos) * dr.Cantidad).ToString("#0.00"))
            Item.Tag = CType(dr, Azteca.Business.Ventas.DetalleVentaDS.ServiciosRow)
            lvwDetalle.Items.Add(Item)
        Next

        lvwDetalle.EndUpdate()

        lblTotCantidadTXT.Text = Venta.TotalCantidad.ToString("#0.00")
        lblTotSubtotalTXT.Text = Venta.SubTotal.ToString("#0.00")
        lblTotImpuestoTXT.Text = Venta.TotalIVA.ToString("#0.00")
        lblTotDescuentosTXT.Text = Venta.TotalDescuentos.ToString("#0.00")
        lblTotTotalTXT.Text = Venta.Total.ToString("#0.00")

    End Sub

    Private Sub PantallaEstado(ByVal Estado As EstadoPantallaEnum)

        btnCorteCerrar.Enabled = False
        btnCortePrint.Enabled = False
        btnCorteAbrir.Enabled = False

        cmdVenta.Enabled = CBool(IIf(OperacionTipo = OperacionEnum.Ninguna, True, False))
        cmdDevolucion.Enabled = CBool(IIf(OperacionTipo = OperacionEnum.Ninguna, True, False))
        cmdFacturar.Enabled = CBool(IIf(OperacionTipo = OperacionEnum.Ninguna, True, False))

        cmdCancelar.Enabled = CBool(IIf(OperacionTipo = OperacionEnum.Ninguna, False, True))
        cmdPagar.Enabled = CBool(IIf(OperacionTipo = OperacionEnum.Ninguna, False, True))


        If Estado = EstadoPantallaEnum.EnOperacion Then
            txtCodigo.Enabled = True
            txtCantidad.Enabled = True
            'Detalle
            cmdEditar.Enabled = True
            cmdCantidad.Enabled = False
            cmdEliminar.Enabled = False
            cmdCambioPrecio.Enabled = False
            cmdHerramientas.Enabled = False
            lvwDetalle.Enabled = True
            txtCodigo.Focus()
        ElseIf Estado = EstadoPantallaEnum.SinOperacion Then
            btnCorteCerrar.Enabled = Context.SessionTerminal.CorteAbierto
            btnCortePrint.Enabled = Context.SessionTerminal.CorteAbierto
            btnCorteAbrir.Enabled = Not Context.SessionTerminal.CorteAbierto
            lblDescripcion.Text = ""
            txtCodigo.Text = "" : txtCodigo.Enabled = False
            txtCantidad.Text = "0.00" : txtCantidad.Enabled = False
            lblOperacion.Text = "" : ResetTotales()
            lblTotal.Text = "0.00"
            Venta = New VentaInfo(App.Session.SessionID)
            cmdVenta.Enabled = Context.SessionTerminal.CorteAbierto : cmdDevolucion.Enabled = Context.SessionTerminal.CorteAbierto : cmdPagar.Enabled = False : cmdCancelar.Enabled = False
            'Detalle
            lvwDetalle.Enabled = False : cmdEditar.Enabled = False
            cmdCantidad.Enabled = False : cmdEliminar.Enabled = False
            cmdHerramientas.Enabled = cmdHerramientas.Visible = True
            fillVenta()
            Me.KeyPreview = True
        ElseIf Estado = EstadoPantallaEnum.EditandoDetalle Then
            If Venta.Articulos.Rows.Count + Venta.Servicios.Rows.Count = 0 Then Exit Sub
            pnlSeleccion.Enabled = False
            pnlPie.Enabled = False
            cmdEditar.Visible = False
            cmdEditarOk.Visible = True
            cmdCantidad.Enabled = True
            cmdEliminar.Enabled = True
            cmdCambioPrecio.Enabled = True
            cmdCambioDescripcion.Enabled = True
            cmdDesctoIndividual.Enabled = True
            lvwDetalle.Focus()
            'Se coloca en el ultimo elemento 
            lvwDetalle.SelectedIndices.Clear()
            lvwDetalle.SelectedIndices.Add(Venta.Articulos.Rows.Count + Venta.Servicios.Rows.Count - 1)
            lvwDetalle.EnsureVisible(Venta.Articulos.Rows.Count + Venta.Servicios.Rows.Count - 1)
        ElseIf Estado = EstadoPantallaEnum.EditandoDetalleOK Then
            pnlSeleccion.Enabled = True
            pnlPie.Enabled = True
            cmdEditar.Visible = True
            cmdEditarOk.Visible = False
            cmdCantidad.Enabled = False
            cmdEliminar.Enabled = False
            cmdCambioPrecio.Enabled = False
            cmdCambioDescripcion.Enabled = False
            cmdDesctoIndividual.Enabled = False
            txtCodigo.Focus()
        End If

        cmdBuscarArt.Enabled = txtCodigo.Enabled : cmdBuscarEstCom.Enabled = txtCodigo.Enabled
    End Sub

    Private Sub ResetTotales()
        lblTotCantidadTXT.Text = "0.00" : lblTotSubtotalTXT.Text = "0.00" : lblTotDescuentosTXT.Text = "0.00" : lblTotImpuestoTXT.Text = "0.00" : lblTotTotalTXT.Text = "0.00"
    End Sub

    Private Sub EliminarArticulo()
        For Each item As ListViewItem In lvwDetalle.SelectedItems
            If TypeOf lvwDetalle.SelectedItems(0).Tag Is Azteca.Business.Ventas.DetalleVentaDS.ArticulosRow Then
                Dim dr As Azteca.Business.Ventas.DetalleVentaDS.ArticulosRow = CType(item.Tag, Azteca.Business.Ventas.DetalleVentaDS.ArticulosRow)
                Venta.Articulos.RemoveArticulosRow(dr)
            Else
                Dim dr As Azteca.Business.Ventas.DetalleVentaDS.ServiciosRow = CType(item.Tag, Azteca.Business.Ventas.DetalleVentaDS.ServiciosRow)
                Venta.Servicios.RemoveServiciosRow(dr)
            End If
        Next
        Venta.CalcularTotales(Ventas.Context.UnidadNegocio.PoliticaDescuento)
        fillVenta()
    End Sub

    Private Sub CambiarCantidad()
        Dim Cantidad As Decimal = 0
        Dim ServicioIs As Boolean = False
        Dim drA As Azteca.Business.Ventas.DetalleVentaDS.ArticulosRow = Nothing
        Dim drS As Azteca.Business.Ventas.DetalleVentaDS.ServiciosRow = Nothing

        If TypeOf lvwDetalle.SelectedItems(0).Tag Is Azteca.Business.Ventas.DetalleVentaDS.ArticulosRow Then
            drA = CType(lvwDetalle.SelectedItems(0).Tag, Azteca.Business.Ventas.DetalleVentaDS.ArticulosRow)
            Cantidad = drA.Cantidad
        Else
            drS = CType(lvwDetalle.SelectedItems(0).Tag, Azteca.Business.Ventas.DetalleVentaDS.ServiciosRow)
            Cantidad = drS.Cantidad
            ServicioIs = True
        End If

        Dim frm As New EditCantidadForm
        If frm.ShowDialog(Cantidad) = System.Windows.Forms.DialogResult.OK Then
            If ServicioIs Then
                drS.Cantidad = frm.Cantidad
            Else
                drA.Cantidad = frm.Cantidad
            End If

        End If

        Venta.CalcularTotales(Ventas.Context.UnidadNegocio.PoliticaDescuento)
        fillVenta()
        PantallaEstado(EstadoPantallaEnum.EditandoDetalleOK)

    End Sub

    Private Sub CambiarPrecio()
        Dim drA As Azteca.Business.Ventas.DetalleVentaDS.ArticulosRow = Nothing
        Dim drS As Azteca.Business.Ventas.DetalleVentaDS.ServiciosRow = Nothing
        Dim PrecioAct As Decimal = 0

        If TypeOf lvwDetalle.SelectedItems(0).Tag Is Azteca.Business.Ventas.DetalleVentaDS.ArticulosRow Then
            drA = CType(lvwDetalle.SelectedItems(0).Tag, Azteca.Business.Ventas.DetalleVentaDS.ArticulosRow)
            PrecioAct = drA.PrecioUnitario + drA.MontoImpTras1 + drA.MontoImpTras2 + drA.MontoImpTras3 + drA.MontoImpTras4 + drA.MontoImpTras5
        Else
            drS = CType(lvwDetalle.SelectedItems(0).Tag, Azteca.Business.Ventas.DetalleVentaDS.ServiciosRow)
            PrecioAct = drS.PrecioUnitario + drS.MontoImpTras1 + drS.MontoImpTras2 + drS.MontoImpTras3 + drS.MontoImpTras4 + drS.MontoImpTras5
        End If

        Dim frm As New editPrecioForm
        If frm.ShowDialog(PrecioAct) = System.Windows.Forms.DialogResult.OK Then
            If TypeOf lvwDetalle.SelectedItems(0).Tag Is Azteca.Business.Ventas.DetalleVentaDS.ArticulosRow Then
                Dim Precio As PrecioInfo = getPrecioArticulo(drA.IdArticuloStock, frm.Cantidad)
                drA.MontoDesc1 = Precio.MontoDescuento1 : drA.MontoDesc2 = Precio.MontoDescuento2 : drA.MontoDesc3 = Precio.MontoDescuento3 : drA.MontoDesc4 = Precio.MontoDescuento4 : drA.MontoDesc5 = Precio.MontoDescuento5
                drA.MontoImpTras1 = Precio.MontoImpuesto1 : drA.MontoImpTras2 = Precio.MontoImpuesto2 : drA.MontoImpTras3 = Precio.MontoImpuesto3 : drA.MontoImpTras4 = Precio.MontoImpuesto4 : drA.MontoImpTras5 = Precio.MontoImpuesto5
                drA.PrecioUnitario = Precio.Precio
            Else
                Dim Precio As PrecioInfo = getPrecioServicio(drS.IdServicio, frm.Cantidad)
                drS.MontoDesc1 = Precio.MontoDescuento1 : drS.MontoDesc2 = Precio.MontoDescuento2 : drS.MontoDesc3 = Precio.MontoDescuento3 : drS.MontoDesc4 = Precio.MontoDescuento4 : drS.MontoDesc5 = Precio.MontoDescuento5
                drS.MontoImpTras1 = Precio.MontoImpuesto1 : drS.MontoImpTras2 = Precio.MontoImpuesto2 : drS.MontoImpTras3 = Precio.MontoImpuesto3 : drS.MontoImpTras4 = Precio.MontoImpuesto4 : drS.MontoImpTras5 = Precio.MontoImpuesto5
                drS.PrecioUnitario = Precio.Precio

            End If
        End If

        Venta.CalcularTotales(Ventas.Context.UnidadNegocio.PoliticaDescuento)
        fillVenta()
        PantallaEstado(EstadoPantallaEnum.EditandoDetalleOK)
    End Sub

    Private Sub CambiarDescripcion()
        Dim Descripcion As String = ""
        Dim ServicioIs As Boolean = False
        Dim drA As Azteca.Business.Ventas.DetalleVentaDS.ArticulosRow = Nothing
        Dim drS As Azteca.Business.Ventas.DetalleVentaDS.ServiciosRow = Nothing

        If TypeOf lvwDetalle.SelectedItems(0).Tag Is Azteca.Business.Ventas.DetalleVentaDS.ArticulosRow Then
            drA = CType(lvwDetalle.SelectedItems(0).Tag, Azteca.Business.Ventas.DetalleVentaDS.ArticulosRow)
            Descripcion = drA.Descripcion
        Else
            drS = CType(lvwDetalle.SelectedItems(0).Tag, Azteca.Business.Ventas.DetalleVentaDS.ServiciosRow)
            Descripcion = drS.Descripcion
            ServicioIs = True
        End If

        Dim frm As New ediDescripcionForm
        If frm.ShowDialog(Descripcion) = System.Windows.Forms.DialogResult.OK Then
            If ServicioIs Then
                drS.Descripcion = frm.Descripcion
            Else
                drA.Descripcion = frm.Descripcion
            End If

            fillVenta()
        End If

        PantallaEstado(EstadoPantallaEnum.EditandoDetalleOK)
    End Sub

    Private Sub TerminarEdicion()
        PantallaEstado(EstadoPantallaEnum.EditandoDetalleOK)
    End Sub

    Private Sub CancelarCaptura()
        If MessageBox.Show("Esta seguro q desea cancelar la operacion actual?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            Venta = New Azteca.Business.Ventas.VentaInfo(App.Session.SessionID)
            fillVenta()
            OperacionTipo = OperacionEnum.Ninguna
            PantallaEstado(EstadoPantallaEnum.SinOperacion)
        End If
    End Sub

    Private Sub Herramientas()
        'Muestra una pantalla con las herramientas necesarias de cada implementacion
        If Context.HerramientasForm = "Azteca.MedicinaWin" Then
            Dim form As New Azteca.Windows.Medicina.HerramientasPOSForm
            form.ShowDialog()
        End If
    End Sub

    Private Sub Cobranza()
        Try
            If Venta.TotalCantidad = 0 Then
                Exit Sub
            End If

            Dim frm As New CobranzaForm
            Dim IdPedidoTipo As Integer = 0
            If OperacionTipo = OperacionEnum.Venta Then IdPedidoTipo = 1 Else IdPedidoTipo = 2
            Dim pd As New System.Drawing.Printing.PrintDocument
            Dim frmDescto As New DescuentoForm
            Dim PorcDescto As Decimal = 0
            Dim VentaTotal As Decimal = Venta.Total
            If frmDescto.ShowDialog(0) = System.Windows.Forms.DialogResult.OK Then
                PorcDescto = frmDescto.Cantidad
                VentaTotal = VentaTotal * ((100 - frmDescto.Cantidad) / 100)
            End If

            If frm.ShowDialog(IdPedidoTipo, VentaTotal) = System.Windows.Forms.DialogResult.OK Then
                Dim VentaTable As DataTable, VentaUbicacionesTable As DataTable
                Try
                    Dim VentaFac As New VentaFacade
                    If PorcDescto > 0 Then AplicarDescuentoGlobal(PorcDescto)

                    'Aplicar la venta y obtener los datos de impresión
                    Dim ds As DataSet = VentaFac.SaveApplyToPrint(App.Session.SessionID, Venta, frm.FormasPagoTable, Ventas.Context.UnidadNegocio.IdAlmacen)
                    VentaTable = ds.Tables(0)
                    VentaUbicacionesTable = ds.Tables(1)
                Catch ex As Exception
                    If PorcDescto > 0 Then AplicarDescuentoGlobal(0)
                    Throw ex
                End Try

                Try
                    'Imprime el ticket
                    PrintTicketPOS(VentaTable)

                    'Agrupas las impresoras de las ubicaciones pa enviar la impresion del ticket por ubicacion
                    Dim Items = From U In VentaUbicacionesTable
                    Group By U!IdPrinter, U!Impresora Into Group

                    'Para cada impresora se envia los articulos involucrados
                    For Each Item In Items
                        Dim UbicacionTable As New DataTable
                        UbicacionTable = VentaUbicacionesTable.Copy()
                        UbicacionTable.Rows.Clear()
                        Dim dv As New DataView(VentaUbicacionesTable, "IdPrinter=" & CStr(Item.IdPrinter), "", DataViewRowState.CurrentRows)
                        For Each drArt As DataRowView In dv
                            UbicacionTable.ImportRow(drArt.Row)
                        Next
                        PrintTicketUbicacion(UbicacionTable, CStr(Item.Impresora))
                    Next

                Catch ex As Exception
                    MessageBox.Show("Se presentó un problema al momento de imprimir el Ticket." & ControlChars.CrLf & "Sin embargo la venta se realizó correctamente.", "Verfique la configuración de la Impresión", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try

                OperacionTipo = OperacionEnum.Ninguna
                PantallaEstado(EstadoPantallaEnum.SinOperacion)
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

    End Sub

    Private Sub PrintTicketPOS(VentaTable As DataTable)
        Dim pd As New System.Drawing.Printing.PrintDocument

        If Ventas.Context.UnidadNegocio.IdFormatoTicketPOS > 0 Then
            If Mid(Context.FormatoTicket, 1, 13) = "<Report xmlns" Then 'rdcl 
                Dim frmVenta As New ReportForm
                Dim Reader As New System.IO.StringReader(Context.FormatoTicket)
                frmVenta.LocalReport.LoadReportDefinition(Reader)
                frmVenta.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("TicketVenta", CType(VentaTable, DataTable)))
                frmVenta.PrintToPrinter(pd.PrinterSettings.PrinterName)
                'frmVenta.PrintToPrinter(Context.SessionTerminal.ImpresoraPath)
            Else 'xml
                Dim Reporte As New Azteca.Windows.Printing.Report
                Reporte.Load(Context.FormatoTicketPOS)
                Dim Engine As New Azteca.Windows.Printing.PrintEngine(Reporte)
                Engine.Data = VentaTable
                Engine.PrintReport(Context.SessionTerminal.ImpresoraPath)
            End If
        End If
    End Sub

    Private Sub PrintTicketUbicacion(VentaUbicacionesTable As DataTable, Impresora As String)
        Dim pd As New System.Drawing.Printing.PrintDocument
        If Ventas.Context.UnidadNegocio.IdFormatoTicketUbicacionPOS > 0 Then
            If Mid(Context.FormatoTicketUbicacion, 1, 13) = "<Report xmlns" Then 'rdcl 
                Dim frmVenta As New ReportForm
                Dim Reader As New System.IO.StringReader(Context.FormatoTicketUbicacion)
                frmVenta.LocalReport.LoadReportDefinition(Reader)
                frmVenta.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("TicketUbicacion", CType(VentaUbicacionesTable, DataTable)))
                frmVenta.PrintToPrinter(Impresora)
                'frmVenta.PrintToPrinter(Context.SessionTerminal.ImpresoraPath)
            Else 'xml
                Dim Reporte As New Azteca.Windows.Printing.Report
                Reporte.Load(Context.FormatoTicketUbicacionPOS)
                Dim Engine As New Azteca.Windows.Printing.PrintEngine(Reporte)
                Engine.Data = VentaUbicacionesTable
                Engine.PrintReport(Impresora)
            End If
        End If
    End Sub

    Private Sub SalirPOS()
        If MessageBox.Show("Esta seguro q desea abandonar la pantalla?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub AplicarDescuentoGlobal(PorcDescto As Decimal)
        For Each item As Azteca.Business.Ventas.DetalleVentaDS.ArticulosRow In Venta.Articulos
            With item
                .PorcDescuento3 = PorcDescto / 100
                If Ventas.Context.UnidadNegocio.PoliticaDescuento = PoliticaDescuento.DespuesImpuestos Then
                    .MontoDesc3 = (.PrecioUnitario + .MontoImpTras1 + +.MontoImpTras2 + .MontoImpTras3 + .MontoImpTras4 + .MontoImpTras5 _
                                   - .MontoDesc1 - .MontoDesc2 - .MontoDesc3 - .MontoDesc4) * .PorcDescuento3
                Else
                    .MontoDesc3 = (.PrecioUnitario - .MontoDesc1 - .MontoDesc2 - .MontoDesc3 - .MontoDesc4) * .PorcDescuento3
                End If
            End With
        Next
        Venta.CalcularTotales(Ventas.Context.UnidadNegocio.PoliticaDescuento)
    End Sub

    Private Sub AplicarDescuentoIndividual()
        Dim frmDescto As New DescuentoForm
        Dim drA As Azteca.Business.Ventas.DetalleVentaDS.ArticulosRow = Nothing
        Dim drS As Azteca.Business.Ventas.DetalleVentaDS.ServiciosRow = Nothing

        If TypeOf lvwDetalle.SelectedItems(0).Tag Is Azteca.Business.Ventas.DetalleVentaDS.ArticulosRow Then
            drA = CType(lvwDetalle.SelectedItems(0).Tag, Azteca.Business.Ventas.DetalleVentaDS.ArticulosRow)
            With drA
                If frmDescto.ShowDialog(.PorcDescuento2 * 100, "Descuento Individual") = System.Windows.Forms.DialogResult.OK Then
                    .PorcDescuento2 = frmDescto.Cantidad / 100
                    .MontoDesc2 = 0
                    If Ventas.Context.UnidadNegocio.PoliticaDescuento = PoliticaDescuento.DespuesImpuestos Then
                        .MontoDesc2 = (.PrecioUnitario + .MontoImpTras1 + +.MontoImpTras2 + .MontoImpTras3 + .MontoImpTras4 + .MontoImpTras5 _
                                       - .MontoDesc1 - .MontoDesc2 - .MontoDesc3 - .MontoDesc4) * .PorcDescuento2
                    Else
                        .MontoDesc2 = (.PrecioUnitario - .MontoDesc1 - .MontoDesc2 - .MontoDesc3 - .MontoDesc4) * .PorcDescuento2
                    End If
                End If
            End With
        Else
            drS = CType(lvwDetalle.SelectedItems(0).Tag, Azteca.Business.Ventas.DetalleVentaDS.ServiciosRow)
            With drS
                If frmDescto.ShowDialog(.PorcDescuento2 * 100, "Descuento Individual") = System.Windows.Forms.DialogResult.OK Then
                    .PorcDescuento2 = frmDescto.Cantidad / 100
                    .MontoDesc2 = 0
                    If Ventas.Context.UnidadNegocio.PoliticaDescuento = PoliticaDescuento.DespuesImpuestos Then
                        .MontoDesc2 = (.PrecioUnitario + .MontoImpTras1 + +.MontoImpTras2 + .MontoImpTras3 + .MontoImpTras4 + .MontoImpTras5 _
                                       - .MontoDesc1 - .MontoDesc2 - .MontoDesc3 - .MontoDesc4) * .PorcDescuento2
                    Else
                        .MontoDesc2 = (.PrecioUnitario - .MontoDesc1 - .MontoDesc2 - .MontoDesc3 - .MontoDesc4) * .PorcDescuento2
                    End If
                End If
            End With

        End If

        Venta.CalcularTotales(Ventas.Context.UnidadNegocio.PoliticaDescuento)
        fillVenta()
        PantallaEstado(EstadoPantallaEnum.EditandoDetalleOK)
    End Sub

#Region "Busqueda"


    Private Sub Busqueda()
        Dim ArtPres As New Azteca.Business.Ventas.PresentacionFacade

        Dim frmSearch As New Azteca.Windows.Forms.BusinessForms.CatalogListForm
        Azteca.Windows.Forms.BusinessForms.CatalogListForm.QueryOnLoad = True
        frmSearch.Filter = "[Zona Venta]='" & Context.ZonaVenta & "'"
        If frmSearch.ShowDialog(Me, ArtPres) = System.Windows.Forms.DialogResult.OK Then
            Dim Id As String = CStr(frmSearch.SelectedItem)
            If Id <> "0" Then ArticuloSelected(CInt(Id))
        End If
    End Sub


    Private Sub BusquedaEstCom()
        Dim frm As New EstructuraVentaForm
        If frm.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim frmArt As New ArticulosSlideForm
            If frmArt.ShowDialog(frm.IdentityEstCom) = System.Windows.Forms.DialogResult.OK Then
                ArticuloSelected(CInt(frmArt.IdArticuloStock))
            End If
        End If

        'Dim IdArt As String = ""
        'Dim EstCom As New Azteca.Business.Ventas.EstructuraComercialFacade
        'Dim frmEstVta As New MsgHierarchyForm
        'frmEstVta.StartPosition = FormStartPosition.CenterScreen
        'If frmEstVta.ShowDialog(EstCom, EstCom, Nothing) = System.Windows.Forms.DialogResult.OK Then
        '    Dim IdEstVen As Integer = frmEstVta.SelectedId
        '    Dim EstComFac As New EstructuraComercialFacade

        '    Dim ArtPres As New Azteca.Business.Ventas.PresentacionFacade
        '    Dim frmSearch As New Azteca.Windows.Forms.BusinessForms.CatalogListForm
        '    frmSearch.Filter = "[Zona Venta]='" & Context.ZonaVenta & "' AND [Estructura Comercial]='" & EstCom.GetDetail(App.Session.SessionID, IdEstVen).NamedPath & "'"
        '    If frmSearch.ShowDialog(Me, ArtPres) = System.Windows.Forms.DialogResult.OK Then
        '        Dim Id As String = CStr(frmSearch.SelectedItem)
        '        If Id <> "0" Then ArticuloSelected(CInt(Id))
        '    End If
        'End If
    End Sub

#End Region

#End Region

   
End Class

#Region "Enumedaros"

Public Enum EstadoPantallaEnum
    EnOperacion
    SinOperacion
    EditandoDetalle
    EditandoDetalleOK
End Enum

Public Enum OperacionEnum
    Ninguna
    Venta
    Devolucion
    Facturando
End Enum

Public Enum TipoPrecio As Integer
    ListaPrecio
    ZonasVenta
End Enum

#End Region