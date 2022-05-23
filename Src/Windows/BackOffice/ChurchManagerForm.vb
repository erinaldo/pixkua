Imports Azteca.Data
Imports Azteca.Kernel
Imports Azteca.Kernel.General
Imports Azteca.Kernel.Security
Imports Azteca.Windows.Forms
Imports Azteca.Windows.Forms.Security
Imports System.IO
Imports System.Threading.Tasks
Imports System.Drawing

Public Class ChurchManagerForm

    Private LogedIn As Boolean = False
    Private ViewMenuIndex As Integer
    Private Config As String = String.Empty

#Region "Implementacion"


    Private Sub ManagerForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Azteca.Windows.App.InitSystem("Pixkua")
            Azteca.Windows.General.LicenseStorage.CreateLicenseCache()
            Me.Text = "Back Office"
            'Desplegar versión del programa
            TopicBar.Pages(2).Links(0).Text = "Version " & My.Application.Info.Version.ToString
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
                TopicBar.Pages(1).Links(0).Text = "NO REMOTING"
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
                TopicBar.Pages(1).Links(0).Text = Config
            End If
            LoginUser()
            'Cargar de forma asincrona los cachés necesarios
            Dim TaskCache = Task.Factory.StartNew(Sub() CargarCaches())
            TaskCache.Wait()
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub OutBarMenu_CommandClick(ByVal sender As Object, ByVal e As C1.Win.C1Command.ClickEventArgs)
        Try
            Dim Command As C1.Win.C1Command.C1Command = CType(sender, C1.Win.C1Command.C1Command)
            Dim IdModulo As Integer = CInt(Command.UserData)
            MostrarOpciones(IdModulo)
            For Each AuxCommand As C1.Win.C1Command.C1Command In CommandHolder.Commands
                If AuxCommand.Category = "Menu" Then AuxCommand.Checked = False
            Next
            Command.Checked = True
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub lvwProcesos_ItemActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwProcesos.ItemActivate
        Try
            If lvwProcesos.SelectedItems.Count > 0 Then
                Dim item As StrucItem = CType(lvwProcesos.SelectedItems(0), StrucItem)
                EjecutarProceso(item.ID)
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub OutBarMenu_PageClick(ByVal sender As Object, ByVal e As C1.Win.C1Command.PageClickEventArgs) Handles OutBarMenu.PageClick
        Dim IdCategoria As Integer = CInt(e.Page.Tag)
        Dim tlbCategoria As C1.Win.C1Command.C1ToolBar = GetCategoryToolBar(IdCategoria)
        If tlbCategoria.CommandLinks.Count > 0 Then tlbCategoria.CommandLinks(0).Command.PerformClick()
    End Sub

#End Region

#Region "Metodos Privados"

    Private Sub ClearMenu()
        
        tlbConfig.CommandLinks.Clear()
        tlbIglesia.CommandLinks.Clear()
    End Sub

    Private Function GetCategoryToolBar(ByVal idCategoria As Integer) As C1.Win.C1Command.C1ToolBar
        Select Case idCategoria
            
            Case 7
                Return tlbIglesia
            Case 100
                Return tlbConfig
            Case Else
                Throw New Exception("Categoría de módulos no válida.")
        End Select
    End Function

    Private Sub LoadMenu()
        ClearMenu()
        lvwProcesos.Items.Clear()
        'Obtener lista de módulos raíz
        Dim dvModulos As New DataView(App.UserMenu.Modulos, "IdParent=0", "Orden", DataViewRowState.CurrentRows)
        For Each drModulo As DataRowView In dvModulos
            Dim moduloRow As ModuleStructure.ModulosRow = CType(drModulo.Row, ModuleStructure.ModulosRow)
            Dim ModuleCommand As New C1.Win.C1Command.C1Command()
            Dim ModuleLink As New C1.Win.C1Command.C1CommandLink(ModuleCommand)
            With ModuleCommand
                .UserData = moduloRow.IdModulo
                .Text = moduloRow.Modulo
                'Cargar imágen del módulo
                Dim imagenMod As Image = LoadIcon(moduloRow.ImageFile)
                If imagenMod IsNot Nothing Then
                    Try
                        .Image = imagenMod
                    Catch ex As Exception

                    End Try
                End If
                .CheckAutoToggle = True
                .Checked = False
                .Category = "Menu"
            End With
            CommandHolder.Commands.Add(ModuleCommand)
            AddHandler ModuleCommand.Click, AddressOf OutBarMenu_CommandClick
            Dim tlbCategory As C1.Win.C1Command.C1ToolBar = GetCategoryToolBar(moduloRow.IdCategoria)
            tlbCategory.CommandLinks.Add(ModuleLink)
        Next
        'Seleccionar la primera página y el primer módulo
        OutBarMenu.SelectedIndex = 0
        Dim Page As C1.Win.C1Command.C1OutPage = OutBarMenu.SelectedPage
        Dim ToolBar As C1.Win.C1Command.C1ToolBar = GetCategoryToolBar(CInt(Page.Tag))
        If ToolBar.CommandLinks.Count > 0 Then ToolBar.CommandLinks(0).Command.PerformClick()
    End Sub

    Private Function LoadIcon(ByVal imageFile As String) As Image
        Dim imagen As Image = Nothing
        Try
            imagen = CType(My.Resources.MenuIcons.ResourceManager.GetObject(imageFile), Image)
            Return imagen
        Catch MissingEx As Resources.MissingManifestResourceException
            Return Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function FormExists(ByVal Form As BaseForm) As Boolean
        Dim frm As BaseForm
        For Each frm In Me.OwnedForms
            If frm.GetType Is Form.GetType Then
                frm.Activate()
                frm.WindowState = FormWindowState.Normal
                frm.BringToFront()
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub ConfigureDataAccess()
        Dim frmConfig As New DataConfigForm()
        frmConfig.ShowDialog()
    End Sub

    Private Sub ConfigureRemoteConnection()
        Dim frmConfig As New ConfigRemoteConecctionForm
        frmConfig.ShowDialog()
    End Sub


    Private Sub MostrarOpciones(ByVal idModulo As Integer)
        lvwProcesos.BeginUpdate()
        lvwProcesos.Items.Clear()
        'Cargar los sub modulos del módulo principal especificado
        Dim dvSubModulos As New DataView(App.UserMenu.Modulos, "IdParent=" & CStr(idModulo), "Orden", DataViewRowState.CurrentRows)
        If dvSubModulos.Count > 0 Then
            For Each drModulo As DataRowView In dvSubModulos
                Dim moduloRow As ModuleStructure.ModulosRow = CType(drModulo.Row, ModuleStructure.ModulosRow)
                Dim SubModulo As New ListViewGroup(moduloRow.Modulo)
                'Mostrar los procesos que pertenecen a este sub modulo
                Dim dvProcesos As New DataView(App.UserMenu.Procesos, "IdModulo=" & CStr(moduloRow.IdModulo), "Orden", DataViewRowState.CurrentRows)
                For Each drProceso As DataRowView In dvProcesos
                    Dim procRow As ModuleStructure.ProcesosRow = CType(drProceso.Row, ModuleStructure.ProcesosRow)
                    'Obtener la llave de la imagen a utilizar    
                    Dim ImageKey As String = procRow.ImageFile
                    If Not imlSmallIcons.Images.ContainsKey(procRow.ImageFile) Then
                        Dim imagenProc As Image = LoadIcon(procRow.ImageFile)
                        If imagenProc IsNot Nothing Then
                            Try
                                imlSmallIcons.Images.Add(procRow.ImageFile, imagenProc)
                            Catch ex As Exception
                                ImageKey = "Proceso"
                            End Try
                        Else
                            ImageKey = "Proceso"
                        End If
                    End If
                    Dim procItem As New StrucItem(procRow.Proceso, ImageKey, ItemType.Process)
                    procItem.ID = procRow.IdProceso
                    procItem.Group = SubModulo
                    'Si el tipo de vista del list view es de detalle, agregar los mismos
                    Dim itemDescr As ListViewItem.ListViewSubItem = procItem.SubItems.Add(procRow.Descr)
                    If lvwProcesos.View = View.Tile Then
                        itemDescr.ForeColor = Color.Gray
                        procItem.SubItems.Add(itemDescr)
                    End If
                    lvwProcesos.Items.Add(procItem)
                Next
                lvwProcesos.Groups.Add(SubModulo)
            Next
        End If
        lvwProcesos.EndUpdate()
    End Sub

    Private Sub EjecutarProceso(ByVal idProceso As Integer)
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            Dim ProcesoFac As New ProcesoFacade
            Dim ProcesoRow As Azteca.Kernel.Security.ModuleStructure.ProcesosRow = App.UserMenu.Procesos.FindByIdProceso(idProceso)
            Dim Ensamblado As System.Reflection.Assembly = System.Reflection.Assembly.Load(ProcesoRow.Ensamblado)
            Dim frmProc As Azteca.Windows.Forms.BaseForm = CType(Ensamblado.CreateInstance(ProcesoRow._Namespace & "." & ProcesoRow.Clase, False), Azteca.Windows.Forms.BaseForm)
            If frmProc IsNot Nothing Then
                If Not FormExists(frmProc) Then
                    frmProc.Text = ProcesoRow.Proceso
                    frmProc.Politicas = GetPoliticas(ProcesoRow.IdProceso)
                    frmProc.IdProceso = ProcesoRow.IdProceso
                    frmProc.Owner = Me
                    frmProc.StartPosition = FormStartPosition.CenterScreen
                    'Buscar en el imagelist si hay un ícono para ésta forma
                    Dim Imagen As Bitmap = CType(imlSmallIcons.Images(ProcesoRow.ImageFile), Bitmap)
                    If Imagen Is Nothing Then
                        Imagen = CType(imlSmallIcons.Images("Proceso"), Bitmap)
                        frmProc.Icon = Drawing.Icon.FromHandle(Imagen.GetHicon)
                    Else
                        frmProc.Icon = Drawing.Icon.FromHandle(Imagen.GetHicon)
                    End If
                    frmProc.Show()
                End If
            Else
                MessageBox.Show("No se puede cargar la opción seleccionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub QuitarHuerfanos(ByVal ParentNode As StructureNode)
        For Each currentNode As StructureNode In ParentNode.Nodes
            QuitarHuerfanos(currentNode)
            If currentNode.NodeType = StructureNodeType.Module And currentNode.Nodes.Count = 0 Then currentNode.Remove()
        Next
    End Sub

    Private Function GetPoliticas(ByVal idProceso As Integer) As PoliticasCollection
        Dim politicas As PoliticasCollection
        If App.Policies.ContainsKey(idProceso) Then
            politicas = App.Policies(idProceso)
        Else
            Dim procesoFac As New ProcesoFacade()
            politicas = procesoFac.LoadPolicies(App.Session.SessionID, App.DefaultSite.Identity, App.Session.User.Identity, idProceso)
            App.Policies.Add(idProceso, politicas)
        End If
        Return politicas
    End Function

    Private Sub DisplayUserInfo()
        TopicBar.Pages(0).Links(0).Text = App.DefaultCompany.Nombre 'Empresa
        TopicBar.Pages(0).Links(1).Text = App.DefaultSite.Nombre 'Sucursal
        TopicBar.Pages(0).Links(2).Text = App.Session.User.Persona.Nombre & " " & App.Session.User.Persona.ApellidoP & " " & App.Session.User.Persona.ApellidoM
    End Sub

    Private Sub LoadSiteConfiguration()
        LoadMenu()
        DisplayUserInfo()
        'QuitarHuerfanos(CType(tvwMenu.Nodes(0), StructureNode))
    End Sub

    Private Sub LoginUser()
        Dim Login As New Azteca.Windows.Forms.LoginForm()
        If Login.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            LogedIn = True
            InitializeContext()
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            LoadSiteConfiguration()
            Me.pnlUsuario.Text = App.Session.User.UserName
            Me.pnlFecha.Text = App.Session.BussinesDate.ToLongDateString
        Else
            If Not LogedIn Then Me.Close()
        End If
    End Sub

    Private Sub InitializeContext()
        Azteca.Windows.Ventas.Context.Initialize()
        Azteca.Windows.Contabilidad.Context.Initialize()
    End Sub


#End Region

#Region "Metodos de Carga de Caché"

    Private Sub CargarCacheArticulos()
        Try
            'Cargar lista de artículos vendibles
            'Dim ArticuloFac As New Azteca.Inventario.ArticuloStockFacade
            'Dim Articulos As Azteca.Inventario.ArticuloStockDictionary = ArticuloFac.CargarArticulosVendiblesCollection(App.Session.SessionID)
            'For Each Articulo As Azteca.Inventario.ArticuloStockInfo In Articulos.Values
            '    If Not Azteca.Windows.Inventario.InventoryCache.ArticulosVendibles.ContainsKey(Articulo.UserCode) Then Azteca.Windows.Inventario.InventoryCache.ArticulosVendibles.Add(Articulo.UserCode, Articulo)
            'Next
        Catch ex As Exception
            AppEventLog.WriteEntry("No se logró cargar el caché de artículos: " & ex.ToString, EventLogType.Error, My.Computer.Name, App.SystemName, EventLogRepository.File)
        End Try
    End Sub

    Private Sub CargarCacheUnidadesMedida()
        'Try
        '    Dim UnidadFac As New Azteca.Inventario.UnidadMedidaFacade
        '    Dim dtUnidades As DataTable = UnidadFac.GetSearchResult(App.Session.SessionID, App.DefaultSite.Identity, Nothing, Nothing).Tables(0)
        '    For Each dr As DataRow In dtUnidades.Rows
        '        Dim IdUnidad As Integer = CInt(dr("IdUnidadMedida"))
        '        Dim UnidadInf As Azteca.Inventario.UnidadMedidaInfo = UnidadFac.GetDetailFromCache(App.Session.SessionID, IdUnidad)
        '        Azteca.Windows.Inventario.InventoryCache.UnidadesMedida.Add(IdUnidad, UnidadInf)
        '    Next
        'Catch ex As Exception
        '    AppEventLog.WriteEntry("Error al cargar el caché de unidades de medida: " & ex.ToString, EventLogType.Error, My.Computer.Name, App.SystemName, EventLogRepository.File)
        'End Try
    End Sub

    Private Sub CargarCaches()
        CargarCacheUnidadesMedida()
        CargarCacheArticulos()
    End Sub

#End Region

#Region "Toolbar"

    Private Sub cmdChangeUser_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdChangeUser.Click
        If Me.MdiChildren.Length = 0 Then
            LoginUser()
        Else
            MessageBox.Show("Primero debe cerrar todas las ventanas abiertas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdChangeSite_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdChangeSite.Click
        If Me.OwnedForms.Length = 0 Then
            Dim siteForm As New DefaultSiteForm()
            siteForm.ShowDialog()
            LoadSiteConfiguration()
            InitializeContext()
        Else
            MessageBox.Show("Primero debe cerrar todas las ventanas abiertas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdChangeServer_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdChangeServer.Click
        Try
            Dim frmConfig As New ConfigRemoteConecctionForm
            If frmConfig.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                MessageBox.Show("Debe reiniciar Pixcua para que los cambios surtan efecto.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdExit.Click
        Close()
    End Sub

    Private Sub cmdTogle_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdTogle.Click
        Try
            splMain.Panel1Collapsed = Not splMain.Panel1Collapsed
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub


#End Region
End Class