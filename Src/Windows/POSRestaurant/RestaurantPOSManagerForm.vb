Imports Azteca.Data
Imports Azteca.Kernel
Imports Azteca.Kernel.General
Imports Azteca.Kernel.Security
Imports Azteca.Windows.Forms
Imports Azteca.Windows.Forms.Security
Imports System.IO
Imports System.Threading.Tasks
Imports System.Drawing


Public Class RestaurantPOSManagerForm
    Private Config As String = String.Empty
    Private LogedIn As Boolean = False
    Private buffer As PolicyBuffer

#Region "Metodos Privados"
    Private Sub ConfigureDataAccess()
        Dim frmConfig As New DataConfigForm()
        frmConfig.ShowDialog()
        Azteca.Kernel.Server.Initialize("Pixcua", True)
    End Sub

    Private Sub LoginUser()
        'Dim Login As New Azteca.Windows.Forms.LoginForm()
        Dim Login As New LoginForm
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

    Private Sub CargarCaches()
        Context.InitializeCache()

    End Sub

#End Region


    Private Sub ManagerForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Azteca.Windows.App.InitSystem("Pixkua")
            Me.Text = "Back Office"
            'Desplegar versión del programa
            ''''''lvwInfo.Items(4).Text = "Version " & My.Application.Info.Version.ToString
            'Mostrar pantalla de splash
            SplashForm.ShowDialog()
            'Verificar si el sistema utiliza un servidor de aplicaciones
            Dim UsesRemoteCalls As Boolean = CBool(System.Configuration.ConfigurationManager.AppSettings("UseRemoteCalls"))
            'Si no se utiliza un servidor de aplicaciones cargar conexión a servidor de datos
            If Not UsesRemoteCalls Then
                'Si no se encontró archivo de conexión, pedir información de conexión
                If Not File.Exists(My.Application.Info.DirectoryPath & "\DataConfig.xml") Then
                    MessageBox.Show("Por favor verifique la información de conexión al servidor de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ConfigureDataAccess()
                Else
                    'Si el archivo de conexión existe, verificar que se pueda realizar conexión 
                    Azteca.Kernel.Server.Initialize("PixkuaPOS", True)
                    If Not Azteca.Kernel.Server.TestConnection Then
                        MessageBox.Show("No se pudo establecer conexión con el servidor de datos." & ControlChars.NewLine & "Se cargará la información de conexión anterior, verifique que sea correcta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ConfigureDataAccess()
                    End If
                End If
                ''''''lvwInfo.Items(5).Text = "NO REMOTING"
                'lvwInfo.Items.Add(Azteca.Kernel.Server.ServerName, "Servidor")
            Else
                'Si se presionó F2 durante el splash, permitir cambiar la configuración de comunicación
                'If SplashForm.ChangeConfig Then ConfigureRemoteConnection()
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
                ''''''lvwInfo.Items(5).Text = Config
            End If
            LoginUser()
            Context.Initialize()
            'Cargar de forma asincrona los cachés necesarios
            Dim TaskCache As New Task(Sub() CargarCaches())
            TaskCache.Start()
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try

    End Sub

    Private Sub CargarDatosBase()

    End Sub

    Private Sub pnlMenu_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlMenu.Resize
        Dim BotonX As Integer = cmdServicioMesa.Width
        Dim BotonY As Integer = cmdServicioMesa.Height

        Dim Separacion As Integer = cmdComidaRapida.Left - (cmdServicioMesa.Left + cmdServicioMesa.Width)
        Dim MargenVertical As Integer = (pnlMenu.Width - (BotonX * 3) + (Separacion * 3)) / 2
        Dim MargenHorizontal As Integer = (pnlMenu.Height - BotonY) / 2

        cmdServicioMesa.Left = MargenVertical
        cmdComidaRapida.Left = MargenVertical + BotonX + Separacion
        cmdServicioDomicilio.Left = MargenVertical + (BotonX * 2) + (Separacion * 2)

        cmdServicioMesa.Top = MargenHorizontal
        cmdComidaRapida.Top = MargenHorizontal
        cmdServicioDomicilio.Top = MargenHorizontal

        btnSalir.Left = cmdComidaRapida.Left

    End Sub

    Private Sub cmdComidaRapida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdComidaRapida.Click
        Dim frm As New ComidaRapidaForm
        frm.ShowDialog()
    End Sub

    Private Sub cmdServicioDomicilio_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdServicioDomicilio.Click
        Dim frmVtaDomicilio As New ServicioDomicilioForm
        frmVtaDomicilio.ShowDialog()
    End Sub

    Private Sub cmdServicioMesa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdServicioMesa.Click
        Dim frm As New MeserosSelForm
        If frm.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub btnSalir_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnSalir.ClickButtonArea
        Me.Close()
    End Sub
End Class