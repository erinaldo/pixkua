Imports Azteca.Data
Imports Azteca.Kernel
Imports Azteca.Kernel.General
Imports Azteca.Kernel.Security
Imports Azteca.Windows
Imports Azteca.Windows.Forms
Imports Azteca.Windows.Forms.Security
Imports System.IO
Imports System.Threading.Tasks
Imports System.Drawing

Public Class MainForm
    Private LogedIn As Boolean = False

#Region "Metodos Privados"

    Private Sub ConfigureDataAccess()
        Dim frmConfig As New DataConfigForm()
        frmConfig.ShowDialog()
    End Sub

    Private Sub ConfigureRemoteConnection()
        Dim frmConfig As New ConfigRemoteConecctionForm
        frmConfig.ShowDialog()
    End Sub

    Private Sub InitializeContext()
        Context.Initialize()
        Azteca.Windows.Ventas.Context.Initialize()
        Azteca.Windows.Contabilidad.Context.Initialize()
    End Sub

    Private Sub LoginUser()
        Dim Login As New Azteca.Windows.Forms.LoginForm()
        If Login.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            LogedIn = True
            InitializeContext()
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            pnlUsuario.Text = App.Session.User.UserName
            pnlEmpresa.Text = App.DefaultCompany.Nombre
            pnlSucursal.Text = App.DefaultSite.Nombre
            pnlFecha.Text = App.Session.BussinesDate.ToLongDateString

            'Si es la primera vez que se configura una empresa
            Dim ConfigMgr As New Azteca.Kernel.Configuration.ConfigurationFacade
            Dim Inicio As Boolean = CBool(ConfigMgr.GetSystemParameter("Configuracion/InicioExpress", "Inicio"))
            If Inicio Then
                Dim frm As New ConfiguracionInicialForm
                If frm.ShowDialog = Windows.Forms.DialogResult.Cancel Then
                    Me.Close()
                End If
            End If
        Else
            If Not LogedIn Then Me.Close()
        End If
    End Sub

    Private Sub Ejecutar(form As BaseForm, commandObject As Object)
        Try
            Dim Command As C1.Win.C1Command.C1Command = CType(commandObject, C1.Win.C1Command.C1Command)
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            'form.MdiParent = Me            
            form.Text = Command.Text
            If Command.Image IsNot Nothing Then
                Dim Imagen As Bitmap = CType(Command.Image, Bitmap)
                form.Icon = System.Drawing.Icon.FromHandle(Imagen.GetHicon)
            End If
            form.Show()
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

#End Region

#Region "Implementacion"

    Private Sub MainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Azteca.Windows.App.InitSystem("Pixkua")
            Azteca.Windows.General.LicenseStorage.CreateLicenseCache()
            Me.Text = "Pixkua - Facturación"
            OutlookBar.SelectedPage = pagFacturacion
            'Mostrar pantalla de splash
            SplashForm.ShowDialog()
            'Verificar si el sistema utiliza un servidor de aplicaciones
            Dim UsesRemoteCalls As Boolean = CBool(System.Configuration.ConfigurationManager.AppSettings("UseRemoteCalls"))
            'Si no se utiliza un servidor de aplicaciones cargar conexión a servidor de datos
            If Not UsesRemoteCalls Then
                Azteca.Kernel.Server.Initialize("Pixkua", True)
                'Si el archivo de conexión existe, verificar que se pueda realizar conexión 
                If Not Azteca.Kernel.Server.TestConnection Then
                    MessageBox.Show("No se pudo establecer conexión con el servidor de datos." & ControlChars.NewLine & "Verifique la información de conexión..", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ConfigureDataAccess()
                    Azteca.Kernel.Server.Initialize("Pixkua", True)
                End If
            Else
                'Si se presionó F2 durante el splash, permitir cambiar la configuración de comunicación
                'If SplashForm.ChangeConfig Then ConfigureRemoteConnection()
                'Limpiar canales registrados
                For Each channel As System.Runtime.Remoting.Channels.IChannel In System.Runtime.Remoting.Channels.ChannelServices.RegisteredChannels
                    System.Runtime.Remoting.Channels.ChannelServices.UnregisterChannel(channel)
                Next
                System.Runtime.Remoting.RemotingConfiguration.Configure("PixkuaInvoice.exe.config", False)
            End If
            'Configuración predeterminada de controles y formas
            App.LicensedApplication = False
            Azteca.Windows.Controls.Selector.EnableEditSecurity = False
            Azteca.Windows.Controls.Selector.UseOptimizedSearchDialog = False
            Azteca.Windows.Forms.BusinessForms.CatalogListForm.QueryOnLoad = True

            LoginUser()
            'Cargar de forma asincrona los cachés necesarios
            'Dim TaskCache = Task.Factory.StartNew(Sub() CargarCaches())
            'TaskCache.Wait()
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

#End Region

#Region "Facturacion"

    Private Sub cmdAdminFacturas_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdAdminFacturas.Click
        Dim frm As New VentasExpressAdminForm ' Azteca.Windows.Ventas.AdminVentasForm
        'frm.WindowState = FormWindowState.Maximized
        Ejecutar(frm, cmdAdminFacturas)
    End Sub

    Private Sub cmdAdminNotas_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdAdminNotas.Click
        Dim frm As New Azteca.Windows.Contabilidad.NotasAdminForm
        'frm.WindowState = FormWindowState.Maximized
        Ejecutar(frm, cmdAdminNotas)
    End Sub
#End Region

#Region "Recepcion"

    Private Sub cmdSATDownloads_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdSATDownloads.Click
        Dim frm As New Azteca.Windows.Compras.DescargasSATForm
        Ejecutar(frm, cmdSATDownloads)
    End Sub

    Private Sub cmdAlmacenDigital_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdAlmacenDigital.Click
        Dim frm As New Azteca.Windows.Compras.AlmacenDigitalForm
        frm.StartPosition = FormStartPosition.CenterParent
        Ejecutar(frm, cmdAlmacenDigital)
    End Sub

#End Region

#Region "Catalogos"

    Private Sub cmdClientes_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdClientes.Click
        Dim frm As New ClientesAdminForm 'Azteca.Windows.Ventas.ClientesForm
        Ejecutar(frm, cmdClientes)
    End Sub

    Private Sub cmdArticulos_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdArticulos.Click
        Dim frm As New ArticulosAdminForm
        Ejecutar(frm, cmdArticulos)
    End Sub

    Private Sub cmdServicios_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdServicios.Click
        Dim frm As New ServiciosAdminForm
        Ejecutar(frm, cmdServicios)
    End Sub

    Private Sub cmdEmpresas_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdEmpresas.Click
        Dim frm As New EmpresaAdminForm
        Ejecutar(frm, cmdEmpresas)
    End Sub

    Private Sub cmdCertificados_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdCertificados.Click
        Dim frm As New CertificadosAdminForm
        Ejecutar(frm, cmdCertificados)
    End Sub

    Private Sub cmdUnidadesNegocio_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdUnidadesNegocio.Click
        Dim frm As New UnidadesNegocioAdminForm
        Ejecutar(frm, cmdUnidadesNegocio)
    End Sub

#End Region


    Private Sub cmdTipoCambio_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdTipoCambio.Click
        Dim frm As New Azteca.Windows.Contabilidad.TiposCambioForm
        Ejecutar(frm, cmdTipoCambio)
    End Sub

    Private Sub cmdInventarioEyS_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdInventarioEyS.Click
        Dim frm As New Azteca.Windows.Inventario.MovimientosForm
        Ejecutar(frm, cmdInventarioEyS)
    End Sub

    Private Sub cmdRegistroUserCFDI_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdRegistroUserCFDI.Click
        Dim frm As New RegistroTimbradoForm
        Ejecutar(frm, cmdRegistroUserCFDI)
    End Sub

    Private Sub cmdEventViewer_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdEventViewer.Click
        Dim frm As New Azteca.Windows.Forms.VisorSucesosForm
        Ejecutar(frm, cmdEventViewer)
    End Sub

    Private Sub cmdListaPrecios_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdListaPrecios.Click
        Dim frm As New ListaPreciosAdminForm
        Ejecutar(frm, cmdListaPrecios)
    End Sub


    Private Sub barInformes_LinkClick(sender As Object, e As C1.Win.C1Command.C1TopicBarClickEventArgs) Handles barInformes.LinkClick
        If e.Link.Tag = "Kardex" Then
            Dim frm As New Inventario.KardexInventarioForm
            frm.Text = "Kardex de Movimientos de Inventario"
            frm.ShowDialog()
        ElseIf e.Link.Tag = "Existencias" Then
            Dim frm As New Inventario.ExistenciasForm
            frm.Text = "Existencias de almacen"
            frm.ShowDialog()
        ElseIf e.Link.Tag = "PorPeriodo" Then
            Dim frm As New Ventas.FacturacionInformesForm
            frm.Text = "Facturación por Periodo"
            frm.ShowDialog()
        ElseIf e.Link.Tag = "PorCliente" Then
            Dim frm As New Ventas.FacturacionInformesCteForm
            frm.Text = "Facturación por Cliente"
            frm.ShowDialog()
        ElseIf e.Link.Tag = "PorArticulo" Then
            Dim frm As New Ventas.FacturacionPorArticuloForm
            frm.Text = "Facturación por Articulo"
            frm.ShowDialog()
        End If
    End Sub

    Private Sub cmdCambiarPassword_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdCambiarPassword.Click
        Dim frm As New Azteca.Windows.Forms.Security.CambiarPwdForm
        Ejecutar(frm, cmdCambiarPassword)
    End Sub

    Private Sub cmdDivisas_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdDivisas.Click
        Dim frm As New Azteca.Windows.Contabilidad.DivisasForm
        Ejecutar(frm, cmdDivisas)
    End Sub

    Private Sub cmdMetodosPago_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdMetodosPago.Click
        Dim frm As New Azteca.Windows.Ventas.MetodoPagoForm
        Ejecutar(frm, cmdMetodosPago)
    End Sub

    Private Sub cmdFormatos_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdFormatos.Click
        Dim frm As New Azteca.Windows.Printing.AdminFormatosForm
        Ejecutar(frm, cmdFormatos)
    End Sub

    Private Sub cmdUnidadesMedida_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdUnidadesMedida.Click
        Dim frm As New Azteca.Windows.Inventario.UnidadesMedidaForm
        Ejecutar(frm, cmdUnidadesMedida)
    End Sub

    Private Sub cmdNotaConceptos_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdNotaConceptos.Click
        Dim frm As New Azteca.Windows.Contabilidad.ConceptosNotasForm
        Ejecutar(frm, cmdNotaConceptos)
    End Sub

End Class
