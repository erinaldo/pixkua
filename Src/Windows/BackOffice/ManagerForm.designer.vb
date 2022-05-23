<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerForm
    Inherits Azteca.Windows.Forms.BaseForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManagerForm))
        Dim C1TopicPage1 As C1.Win.C1Command.C1TopicPage = New C1.Win.C1Command.C1TopicPage()
        Dim C1TopicLink1 As C1.Win.C1Command.C1TopicLink = New C1.Win.C1Command.C1TopicLink()
        Dim C1TopicLink2 As C1.Win.C1Command.C1TopicLink = New C1.Win.C1Command.C1TopicLink()
        Dim C1TopicLink3 As C1.Win.C1Command.C1TopicLink = New C1.Win.C1Command.C1TopicLink()
        Dim C1TopicPage2 As C1.Win.C1Command.C1TopicPage = New C1.Win.C1Command.C1TopicPage()
        Dim C1TopicLink4 As C1.Win.C1Command.C1TopicLink = New C1.Win.C1Command.C1TopicLink()
        Dim C1TopicPage3 As C1.Win.C1Command.C1TopicPage = New C1.Win.C1Command.C1TopicPage()
        Dim C1TopicLink5 As C1.Win.C1Command.C1TopicLink = New C1.Win.C1Command.C1TopicLink()
        Me.imlEstatus = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusBar = New System.Windows.Forms.StatusStrip()
        Me.pnlStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pgb = New System.Windows.Forms.ToolStripProgressBar()
        Me.pnlUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pnlFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.OutBarMenu = New C1.Win.C1Command.C1OutBar()
        Me.pagFinanzas = New C1.Win.C1Command.C1OutPage()
        Me.tlbFinanzas = New C1.Win.C1Command.C1ToolBar()
        Me.CommandHolder = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdTogle = New C1.Win.C1Command.C1Command()
        Me.cmdChangeUser = New C1.Win.C1Command.C1Command()
        Me.cmdChangeSite = New C1.Win.C1Command.C1Command()
        Me.cmdExit = New C1.Win.C1Command.C1Command()
        Me.cmdChangeServer = New C1.Win.C1Command.C1Command()
        Me.pagLogistica = New C1.Win.C1Command.C1OutPage()
        Me.tlbLogistica = New C1.Win.C1Command.C1ToolBar()
        Me.pagManufactura = New C1.Win.C1Command.C1OutPage()
        Me.tlbManufactura = New C1.Win.C1Command.C1ToolBar()
        Me.pagComercial = New C1.Win.C1Command.C1OutPage()
        Me.tlbComercial = New C1.Win.C1Command.C1ToolBar()
        Me.pagRH = New C1.Win.C1Command.C1OutPage()
        Me.tlbRH = New C1.Win.C1Command.C1ToolBar()
        Me.pagIglesia = New C1.Win.C1Command.C1OutPage()
        Me.tlbIglesia = New C1.Win.C1Command.C1ToolBar()
        Me.pagConfiguracion = New C1.Win.C1Command.C1OutPage()
        Me.tlbConfig = New C1.Win.C1Command.C1ToolBar()
        Me.NotiIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.lvwProcesos = New System.Windows.Forms.ListView()
        Me.colProceso = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDescr = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.imlSmallIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.splOptions = New System.Windows.Forms.SplitContainer()
        Me.TopicBar = New C1.Win.C1Command.C1TopicBar()
        Me.CommandDock = New C1.Win.C1Command.C1CommandDock()
        Me.tlbMain = New C1.Win.C1Command.C1ToolBar()
        Me.btnToggle = New C1.Win.C1Command.C1CommandLink()
        Me.btnChangeUser = New C1.Win.C1Command.C1CommandLink()
        Me.btnChangeCompany = New C1.Win.C1Command.C1CommandLink()
        Me.btnChangeServer = New C1.Win.C1Command.C1CommandLink()
        Me.btnExit = New C1.Win.C1Command.C1CommandLink()
        Me.splMain = New System.Windows.Forms.SplitContainer()
        Me.StatusBar.SuspendLayout()
        CType(Me.OutBarMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OutBarMenu.SuspendLayout()
        Me.pagFinanzas.SuspendLayout()
        CType(Me.CommandHolder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagLogistica.SuspendLayout()
        Me.pagManufactura.SuspendLayout()
        Me.pagComercial.SuspendLayout()
        Me.pagRH.SuspendLayout()
        Me.pagIglesia.SuspendLayout()
        Me.pagConfiguracion.SuspendLayout()
        CType(Me.splOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splOptions.Panel1.SuspendLayout()
        Me.splOptions.Panel2.SuspendLayout()
        Me.splOptions.SuspendLayout()
        CType(Me.TopicBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandDock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CommandDock.SuspendLayout()
        CType(Me.splMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splMain.Panel1.SuspendLayout()
        Me.splMain.Panel2.SuspendLayout()
        Me.splMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'imlEstatus
        '
        Me.imlEstatus.ImageStream = CType(resources.GetObject("imlEstatus.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlEstatus.TransparentColor = System.Drawing.Color.Transparent
        Me.imlEstatus.Images.SetKeyName(0, "Usuario")
        Me.imlEstatus.Images.SetKeyName(1, "Empresa")
        Me.imlEstatus.Images.SetKeyName(2, "Sucursal")
        Me.imlEstatus.Images.SetKeyName(3, "Version")
        Me.imlEstatus.Images.SetKeyName(4, "Mensajes")
        Me.imlEstatus.Images.SetKeyName(5, "Conexion")
        '
        'StatusBar
        '
        Me.StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pnlStatus, Me.pgb, Me.pnlUsuario, Me.pnlFecha})
        Me.StatusBar.Location = New System.Drawing.Point(0, 642)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(966, 25)
        Me.StatusBar.TabIndex = 2
        '
        'pnlStatus
        '
        Me.pnlStatus.AutoSize = False
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(782, 20)
        Me.pnlStatus.Spring = True
        Me.pnlStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pgb
        '
        Me.pgb.AutoSize = False
        Me.pgb.Name = "pgb"
        Me.pgb.Size = New System.Drawing.Size(100, 19)
        '
        'pnlUsuario
        '
        Me.pnlUsuario.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.pnlUsuario.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.pnlUsuario.Image = CType(resources.GetObject("pnlUsuario.Image"), System.Drawing.Image)
        Me.pnlUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.pnlUsuario.Name = "pnlUsuario"
        Me.pnlUsuario.Size = New System.Drawing.Size(67, 20)
        Me.pnlUsuario.Text = "Usuario"
        '
        'pnlFecha
        '
        Me.pnlFecha.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.pnlFecha.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.pnlFecha.Image = CType(resources.GetObject("pnlFecha.Image"), System.Drawing.Image)
        Me.pnlFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.pnlFecha.Name = "pnlFecha"
        Me.pnlFecha.Size = New System.Drawing.Size(58, 20)
        Me.pnlFecha.Text = "Fecha"
        '
        'OutBarMenu
        '
        Me.OutBarMenu.Controls.Add(Me.pagFinanzas)
        Me.OutBarMenu.Controls.Add(Me.pagLogistica)
        Me.OutBarMenu.Controls.Add(Me.pagManufactura)
        Me.OutBarMenu.Controls.Add(Me.pagComercial)
        Me.OutBarMenu.Controls.Add(Me.pagRH)
        Me.OutBarMenu.Controls.Add(Me.pagIglesia)
        Me.OutBarMenu.Controls.Add(Me.pagConfiguracion)
        Me.OutBarMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OutBarMenu.Location = New System.Drawing.Point(0, 0)
        Me.OutBarMenu.Name = "OutBarMenu"
        Me.OutBarMenu.SelectedIndex = 1
        Me.OutBarMenu.Size = New System.Drawing.Size(211, 600)
        Me.OutBarMenu.VisualStyle = C1.Win.C1Command.VisualStyle.Office2003Silver
        Me.OutBarMenu.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2003Silver
        '
        'pagFinanzas
        '
        Me.pagFinanzas.Controls.Add(Me.tlbFinanzas)
        Me.pagFinanzas.Image = CType(resources.GetObject("pagFinanzas.Image"), System.Drawing.Image)
        Me.pagFinanzas.Name = "pagFinanzas"
        Me.pagFinanzas.Size = New System.Drawing.Size(211, 348)
        Me.pagFinanzas.Tag = "2"
        Me.pagFinanzas.Text = "Finanzas"
        '
        'tlbFinanzas
        '
        Me.tlbFinanzas.AccessibleName = "Tool Bar"
        Me.tlbFinanzas.AutoSize = False
        Me.tlbFinanzas.ButtonLookVert = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.tlbFinanzas.CommandHolder = Me.CommandHolder
        Me.tlbFinanzas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlbFinanzas.Horizontal = False
        Me.tlbFinanzas.Location = New System.Drawing.Point(0, 0)
        Me.tlbFinanzas.MinButtonSize = 96
        Me.tlbFinanzas.Movable = False
        Me.tlbFinanzas.Name = "tlbFinanzas"
        Me.tlbFinanzas.Size = New System.Drawing.Size(211, 348)
        Me.tlbFinanzas.Tag = "2"
        Me.tlbFinanzas.Text = "Page1"
        Me.tlbFinanzas.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2003Silver
        '
        'CommandHolder
        '
        Me.CommandHolder.Commands.Add(Me.cmdTogle)
        Me.CommandHolder.Commands.Add(Me.cmdChangeUser)
        Me.CommandHolder.Commands.Add(Me.cmdChangeSite)
        Me.CommandHolder.Commands.Add(Me.cmdExit)
        Me.CommandHolder.Commands.Add(Me.cmdChangeServer)
        Me.CommandHolder.Owner = Me
        Me.CommandHolder.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Black
        '
        'cmdTogle
        '
        Me.cmdTogle.CheckAutoToggle = True
        Me.cmdTogle.Checked = True
        Me.cmdTogle.Image = CType(resources.GetObject("cmdTogle.Image"), System.Drawing.Image)
        Me.cmdTogle.Name = "cmdTogle"
        Me.cmdTogle.ShortcutText = ""
        Me.cmdTogle.Text = "Ocultar Menu"
        '
        'cmdChangeUser
        '
        Me.cmdChangeUser.Image = CType(resources.GetObject("cmdChangeUser.Image"), System.Drawing.Image)
        Me.cmdChangeUser.Name = "cmdChangeUser"
        Me.cmdChangeUser.ShortcutText = ""
        Me.cmdChangeUser.Text = "Cambiar Usuario"
        '
        'cmdChangeSite
        '
        Me.cmdChangeSite.Image = CType(resources.GetObject("cmdChangeSite.Image"), System.Drawing.Image)
        Me.cmdChangeSite.Name = "cmdChangeSite"
        Me.cmdChangeSite.ShortcutText = ""
        Me.cmdChangeSite.Text = "Cambiar Sucursal"
        '
        'cmdExit
        '
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.ShortcutText = ""
        Me.cmdExit.Text = "Cambiar Servidor"
        '
        'cmdChangeServer
        '
        Me.cmdChangeServer.Image = CType(resources.GetObject("cmdChangeServer.Image"), System.Drawing.Image)
        Me.cmdChangeServer.Name = "cmdChangeServer"
        Me.cmdChangeServer.ShortcutText = ""
        Me.cmdChangeServer.Text = "Salir"
        '
        'pagLogistica
        '
        Me.pagLogistica.Controls.Add(Me.tlbLogistica)
        Me.pagLogistica.Image = CType(resources.GetObject("pagLogistica.Image"), System.Drawing.Image)
        Me.pagLogistica.Name = "pagLogistica"
        Me.pagLogistica.Size = New System.Drawing.Size(211, 348)
        Me.pagLogistica.Tag = "3"
        Me.pagLogistica.Text = "Logística"
        '
        'tlbLogistica
        '
        Me.tlbLogistica.AccessibleName = "Tool Bar"
        Me.tlbLogistica.AutoSize = False
        Me.tlbLogistica.ButtonLookVert = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.tlbLogistica.CommandHolder = Me.CommandHolder
        Me.tlbLogistica.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlbLogistica.Horizontal = False
        Me.tlbLogistica.Location = New System.Drawing.Point(0, 0)
        Me.tlbLogistica.MinButtonSize = 96
        Me.tlbLogistica.Movable = False
        Me.tlbLogistica.Name = "tlbLogistica"
        Me.tlbLogistica.Size = New System.Drawing.Size(211, 348)
        Me.tlbLogistica.Tag = "3"
        Me.tlbLogistica.Text = "Page2"
        Me.tlbLogistica.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2003Silver
        '
        'pagManufactura
        '
        Me.pagManufactura.Controls.Add(Me.tlbManufactura)
        Me.pagManufactura.Image = CType(resources.GetObject("pagManufactura.Image"), System.Drawing.Image)
        Me.pagManufactura.Name = "pagManufactura"
        Me.pagManufactura.Size = New System.Drawing.Size(211, 348)
        Me.pagManufactura.Tag = "4"
        Me.pagManufactura.Text = "Manufactura"
        '
        'tlbManufactura
        '
        Me.tlbManufactura.AccessibleName = "Tool Bar"
        Me.tlbManufactura.AutoSize = False
        Me.tlbManufactura.ButtonLookVert = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.tlbManufactura.CommandHolder = Me.CommandHolder
        Me.tlbManufactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlbManufactura.Horizontal = False
        Me.tlbManufactura.Location = New System.Drawing.Point(0, 0)
        Me.tlbManufactura.MinButtonSize = 96
        Me.tlbManufactura.Movable = False
        Me.tlbManufactura.Name = "tlbManufactura"
        Me.tlbManufactura.Size = New System.Drawing.Size(211, 348)
        Me.tlbManufactura.Tag = "4"
        Me.tlbManufactura.Text = "Page1"
        Me.tlbManufactura.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2003Silver
        '
        'pagComercial
        '
        Me.pagComercial.Controls.Add(Me.tlbComercial)
        Me.pagComercial.Image = CType(resources.GetObject("pagComercial.Image"), System.Drawing.Image)
        Me.pagComercial.Name = "pagComercial"
        Me.pagComercial.Size = New System.Drawing.Size(211, 348)
        Me.pagComercial.Tag = "1"
        Me.pagComercial.Text = "Comercial"
        '
        'tlbComercial
        '
        Me.tlbComercial.AccessibleName = "Tool Bar"
        Me.tlbComercial.AutoSize = False
        Me.tlbComercial.ButtonLookVert = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.tlbComercial.CommandHolder = Me.CommandHolder
        Me.tlbComercial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlbComercial.Horizontal = False
        Me.tlbComercial.Location = New System.Drawing.Point(0, 0)
        Me.tlbComercial.MinButtonSize = 96
        Me.tlbComercial.Movable = False
        Me.tlbComercial.Name = "tlbComercial"
        Me.tlbComercial.Size = New System.Drawing.Size(211, 348)
        Me.tlbComercial.Tag = "1"
        Me.tlbComercial.Text = "Page1"
        Me.tlbComercial.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2003Silver
        '
        'pagRH
        '
        Me.pagRH.Controls.Add(Me.tlbRH)
        Me.pagRH.Image = CType(resources.GetObject("pagRH.Image"), System.Drawing.Image)
        Me.pagRH.Name = "pagRH"
        Me.pagRH.Size = New System.Drawing.Size(211, 348)
        Me.pagRH.Tag = "5"
        Me.pagRH.Text = "Recursos Humanos"
        '
        'tlbRH
        '
        Me.tlbRH.AccessibleName = "Tool Bar"
        Me.tlbRH.AutoSize = False
        Me.tlbRH.ButtonLookVert = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.tlbRH.CommandHolder = Me.CommandHolder
        Me.tlbRH.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlbRH.Horizontal = False
        Me.tlbRH.Location = New System.Drawing.Point(0, 0)
        Me.tlbRH.MinButtonSize = 96
        Me.tlbRH.Movable = False
        Me.tlbRH.Name = "tlbRH"
        Me.tlbRH.Size = New System.Drawing.Size(211, 348)
        Me.tlbRH.Text = "Page1"
        Me.tlbRH.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2003Silver
        '
        'pagIglesia
        '
        Me.pagIglesia.Controls.Add(Me.tlbIglesia)
        Me.pagIglesia.Image = Global.Azteca.Windows.My.Resources.MenuIcons.iglesia
        Me.pagIglesia.Name = "pagIglesia"
        Me.pagIglesia.Size = New System.Drawing.Size(211, 348)
        Me.pagIglesia.Tag = "7"
        Me.pagIglesia.Text = "Iglesia"
        '
        'tlbIglesia
        '
        Me.tlbIglesia.AccessibleName = "Tool Bar"
        Me.tlbIglesia.AutoSize = False
        Me.tlbIglesia.ButtonLookVert = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.tlbIglesia.CommandHolder = Me.CommandHolder
        Me.tlbIglesia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlbIglesia.Horizontal = False
        Me.tlbIglesia.Location = New System.Drawing.Point(0, 0)
        Me.tlbIglesia.MinButtonSize = 72
        Me.tlbIglesia.Movable = False
        Me.tlbIglesia.Name = "tlbIglesia"
        Me.tlbIglesia.Size = New System.Drawing.Size(211, 348)
        Me.tlbIglesia.Tag = "7"
        Me.tlbIglesia.Text = "Page2"
        Me.tlbIglesia.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2003Silver
        '
        'pagConfiguracion
        '
        Me.pagConfiguracion.Controls.Add(Me.tlbConfig)
        Me.pagConfiguracion.Image = CType(resources.GetObject("pagConfiguracion.Image"), System.Drawing.Image)
        Me.pagConfiguracion.Name = "pagConfiguracion"
        Me.pagConfiguracion.Size = New System.Drawing.Size(211, 312)
        Me.pagConfiguracion.Tag = "100"
        Me.pagConfiguracion.Text = "Configuración"
        '
        'tlbConfig
        '
        Me.tlbConfig.AccessibleName = "Tool Bar"
        Me.tlbConfig.AutoSize = False
        Me.tlbConfig.ButtonLookVert = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.tlbConfig.CommandHolder = Me.CommandHolder
        Me.tlbConfig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlbConfig.Horizontal = False
        Me.tlbConfig.Location = New System.Drawing.Point(0, 0)
        Me.tlbConfig.MinButtonSize = 72
        Me.tlbConfig.Movable = False
        Me.tlbConfig.Name = "tlbConfig"
        Me.tlbConfig.Size = New System.Drawing.Size(211, 312)
        Me.tlbConfig.Tag = "100"
        Me.tlbConfig.Text = "Page2"
        Me.tlbConfig.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2003Silver
        '
        'NotiIcon
        '
        Me.NotiIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotiIcon.Icon = CType(resources.GetObject("NotiIcon.Icon"), System.Drawing.Icon)
        Me.NotiIcon.Text = "Pixkua"
        Me.NotiIcon.Visible = True
        '
        'lvwProcesos
        '
        Me.lvwProcesos.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwProcesos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvwProcesos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colProceso, Me.colDescr})
        Me.lvwProcesos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwProcesos.HideSelection = False
        Me.lvwProcesos.HotTracking = True
        Me.lvwProcesos.HoverSelection = True
        Me.lvwProcesos.LargeImageList = Me.imlSmallIcons
        Me.lvwProcesos.Location = New System.Drawing.Point(0, 0)
        Me.lvwProcesos.MultiSelect = False
        Me.lvwProcesos.Name = "lvwProcesos"
        Me.lvwProcesos.ShowItemToolTips = True
        Me.lvwProcesos.Size = New System.Drawing.Size(588, 600)
        Me.lvwProcesos.SmallImageList = Me.imlSmallIcons
        Me.lvwProcesos.TabIndex = 9
        Me.lvwProcesos.UseCompatibleStateImageBehavior = False
        Me.lvwProcesos.View = System.Windows.Forms.View.Tile
        '
        'colProceso
        '
        Me.colProceso.Text = "Proceso"
        Me.colProceso.Width = 149
        '
        'colDescr
        '
        Me.colDescr.Text = "Descripción"
        Me.colDescr.Width = 280
        '
        'imlSmallIcons
        '
        Me.imlSmallIcons.ImageStream = CType(resources.GetObject("imlSmallIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlSmallIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.imlSmallIcons.Images.SetKeyName(0, "Proceso")
        '
        'splOptions
        '
        Me.splOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splOptions.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.splOptions.Location = New System.Drawing.Point(0, 0)
        Me.splOptions.Name = "splOptions"
        '
        'splOptions.Panel1
        '
        Me.splOptions.Panel1.Controls.Add(Me.lvwProcesos)
        '
        'splOptions.Panel2
        '
        Me.splOptions.Panel2.Controls.Add(Me.TopicBar)
        Me.splOptions.Size = New System.Drawing.Size(751, 600)
        Me.splOptions.SplitterDistance = 588
        Me.splOptions.SplitterWidth = 3
        Me.splOptions.TabIndex = 12
        '
        'TopicBar
        '
        Me.TopicBar.AutoScrollMinSize = New System.Drawing.Size(0, 267)
        Me.TopicBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TopicBar.Location = New System.Drawing.Point(0, 0)
        Me.TopicBar.Name = "TopicBar"
        C1TopicPage1.ImageList = Me.imlEstatus
        C1TopicLink1.ImageIndex = 1
        C1TopicLink1.Text = "Empresa"
        C1TopicLink2.ImageIndex = 2
        C1TopicLink2.Text = "Sucursal"
        C1TopicLink3.ImageIndex = 0
        C1TopicLink3.Text = "Usuario"
        C1TopicPage1.Links.Add(C1TopicLink1)
        C1TopicPage1.Links.Add(C1TopicLink2)
        C1TopicPage1.Links.Add(C1TopicLink3)
        C1TopicPage1.Text = "Información de Login"
        C1TopicPage2.ImageList = Me.imlEstatus
        C1TopicLink4.ImageIndex = 5
        C1TopicLink4.Text = "Conexión"
        C1TopicPage2.Links.Add(C1TopicLink4)
        C1TopicPage2.Text = "Conexión"
        C1TopicPage3.ImageList = Me.imlEstatus
        C1TopicLink5.ImageIndex = 3
        C1TopicLink5.Text = "Versión"
        C1TopicPage3.Links.Add(C1TopicLink5)
        C1TopicPage3.Text = "Información General"
        Me.TopicBar.Pages.Add(C1TopicPage1)
        Me.TopicBar.Pages.Add(C1TopicPage2)
        Me.TopicBar.Pages.Add(C1TopicPage3)
        Me.TopicBar.Size = New System.Drawing.Size(160, 600)
        Me.TopicBar.VisualStyle = C1.Win.C1Command.VisualStyle.Office2003Silver
        Me.TopicBar.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2003Silver
        '
        'CommandDock
        '
        Me.CommandDock.AutoSize = False
        Me.CommandDock.Controls.Add(Me.tlbMain)
        Me.CommandDock.Id = 2
        Me.CommandDock.Location = New System.Drawing.Point(0, 0)
        Me.CommandDock.Name = "CommandDock"
        Me.CommandDock.Size = New System.Drawing.Size(966, 42)
        '
        'tlbMain
        '
        Me.tlbMain.AccessibleName = "Tool Bar"
        Me.tlbMain.CommandHolder = Me.CommandHolder
        Me.tlbMain.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.btnToggle, Me.btnChangeUser, Me.btnChangeCompany, Me.btnChangeServer, Me.btnExit})
        Me.tlbMain.Location = New System.Drawing.Point(0, 0)
        Me.tlbMain.MinButtonSize = 40
        Me.tlbMain.Name = "tlbMain"
        Me.tlbMain.Size = New System.Drawing.Size(214, 40)
        Me.tlbMain.Text = "Main ToolBar"
        Me.tlbMain.VisualStyle = C1.Win.C1Command.VisualStyle.Office2003Silver
        Me.tlbMain.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2003Silver
        '
        'btnToggle
        '
        Me.btnToggle.Command = Me.cmdTogle
        '
        'btnChangeUser
        '
        Me.btnChangeUser.Command = Me.cmdChangeUser
        Me.btnChangeUser.SortOrder = 1
        '
        'btnChangeCompany
        '
        Me.btnChangeCompany.Command = Me.cmdChangeSite
        Me.btnChangeCompany.SortOrder = 2
        '
        'btnChangeServer
        '
        Me.btnChangeServer.Command = Me.cmdChangeServer
        Me.btnChangeServer.Delimiter = True
        Me.btnChangeServer.SortOrder = 3
        '
        'btnExit
        '
        Me.btnExit.Command = Me.cmdExit
        Me.btnExit.SortOrder = 4
        '
        'splMain
        '
        Me.splMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splMain.Location = New System.Drawing.Point(0, 42)
        Me.splMain.Name = "splMain"
        '
        'splMain.Panel1
        '
        Me.splMain.Panel1.Controls.Add(Me.OutBarMenu)
        '
        'splMain.Panel2
        '
        Me.splMain.Panel2.Controls.Add(Me.splOptions)
        Me.splMain.Size = New System.Drawing.Size(966, 600)
        Me.splMain.SplitterDistance = 211
        Me.splMain.TabIndex = 14
        '
        'ManagerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 667)
        Me.Controls.Add(Me.splMain)
        Me.Controls.Add(Me.CommandDock)
        Me.Controls.Add(Me.StatusBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "ManagerForm"
        Me.Text = "ManagerForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusBar.ResumeLayout(False)
        Me.StatusBar.PerformLayout()
        CType(Me.OutBarMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OutBarMenu.ResumeLayout(False)
        Me.pagFinanzas.ResumeLayout(False)
        CType(Me.CommandHolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagLogistica.ResumeLayout(False)
        Me.pagManufactura.ResumeLayout(False)
        Me.pagComercial.ResumeLayout(False)
        Me.pagRH.ResumeLayout(False)
        Me.pagIglesia.ResumeLayout(False)
        Me.pagConfiguracion.ResumeLayout(False)
        Me.splOptions.Panel1.ResumeLayout(False)
        Me.splOptions.Panel2.ResumeLayout(False)
        CType(Me.splOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splOptions.ResumeLayout(False)
        CType(Me.TopicBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandDock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CommandDock.ResumeLayout(False)
        Me.splMain.Panel1.ResumeLayout(False)
        Me.splMain.Panel2.ResumeLayout(False)
        CType(Me.splMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splMain.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusBar As System.Windows.Forms.StatusStrip
    Friend WithEvents pgb As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents NotiIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents lvwProcesos As System.Windows.Forms.ListView
    Friend WithEvents colProceso As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDescr As System.Windows.Forms.ColumnHeader
    Friend WithEvents imlSmallIcons As System.Windows.Forms.ImageList
    Friend WithEvents splOptions As System.Windows.Forms.SplitContainer
    Friend WithEvents OutBarMenu As C1.Win.C1Command.C1OutBar
    Friend WithEvents pagFinanzas As C1.Win.C1Command.C1OutPage
    Friend WithEvents tlbFinanzas As C1.Win.C1Command.C1ToolBar
    Friend WithEvents CommandHolder As C1.Win.C1Command.C1CommandHolder
    Private WithEvents imlEstatus As System.Windows.Forms.ImageList
    Private WithEvents pnlUsuario As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents pnlFecha As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents pnlStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pagComercial As C1.Win.C1Command.C1OutPage
    Friend WithEvents tlbComercial As C1.Win.C1Command.C1ToolBar
    Friend WithEvents pagLogistica As C1.Win.C1Command.C1OutPage
    Friend WithEvents tlbLogistica As C1.Win.C1Command.C1ToolBar
    Friend WithEvents pagManufactura As C1.Win.C1Command.C1OutPage
    Friend WithEvents tlbManufactura As C1.Win.C1Command.C1ToolBar
    Friend WithEvents pagConfiguracion As C1.Win.C1Command.C1OutPage
    Friend WithEvents tlbConfig As C1.Win.C1Command.C1ToolBar
    Friend WithEvents TopicBar As C1.Win.C1Command.C1TopicBar
    Friend WithEvents cmdTogle As C1.Win.C1Command.C1Command
    Friend WithEvents cmdChangeUser As C1.Win.C1Command.C1Command
    Friend WithEvents cmdChangeSite As C1.Win.C1Command.C1Command
    Friend WithEvents cmdExit As C1.Win.C1Command.C1Command
    Friend WithEvents cmdChangeServer As C1.Win.C1Command.C1Command
    Friend WithEvents CommandDock As C1.Win.C1Command.C1CommandDock
    Friend WithEvents tlbMain As C1.Win.C1Command.C1ToolBar
    Friend WithEvents btnToggle As C1.Win.C1Command.C1CommandLink
    Friend WithEvents btnChangeUser As C1.Win.C1Command.C1CommandLink
    Friend WithEvents btnChangeCompany As C1.Win.C1Command.C1CommandLink
    Friend WithEvents btnChangeServer As C1.Win.C1Command.C1CommandLink
    Friend WithEvents btnExit As C1.Win.C1Command.C1CommandLink
    Friend WithEvents splMain As System.Windows.Forms.SplitContainer
    Friend WithEvents pagRH As C1.Win.C1Command.C1OutPage
    Friend WithEvents tlbRH As C1.Win.C1Command.C1ToolBar
    Friend WithEvents pagIglesia As C1.Win.C1Command.C1OutPage
    Friend WithEvents tlbIglesia As C1.Win.C1Command.C1ToolBar
End Class
