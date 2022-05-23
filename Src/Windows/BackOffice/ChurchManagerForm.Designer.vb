<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChurchManagerForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChurchManagerForm))
        Dim C1TopicPage4 As C1.Win.C1Command.C1TopicPage = New C1.Win.C1Command.C1TopicPage()
        Dim C1TopicLink6 As C1.Win.C1Command.C1TopicLink = New C1.Win.C1Command.C1TopicLink()
        Dim C1TopicLink7 As C1.Win.C1Command.C1TopicLink = New C1.Win.C1Command.C1TopicLink()
        Dim C1TopicLink8 As C1.Win.C1Command.C1TopicLink = New C1.Win.C1Command.C1TopicLink()
        Dim C1TopicPage5 As C1.Win.C1Command.C1TopicPage = New C1.Win.C1Command.C1TopicPage()
        Dim C1TopicLink9 As C1.Win.C1Command.C1TopicLink = New C1.Win.C1Command.C1TopicLink()
        Dim C1TopicPage6 As C1.Win.C1Command.C1TopicPage = New C1.Win.C1Command.C1TopicPage()
        Dim C1TopicLink10 As C1.Win.C1Command.C1TopicLink = New C1.Win.C1Command.C1TopicLink()
        Me.imlEstatus = New System.Windows.Forms.ImageList(Me.components)
        Me.lvwProcesos = New System.Windows.Forms.ListView()
        Me.colProceso = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDescr = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.imlSmallIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.pagIglesia = New C1.Win.C1Command.C1OutPage()
        Me.tlbIglesia = New C1.Win.C1Command.C1ToolBar()
        Me.CommandHolder = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdTogle = New C1.Win.C1Command.C1Command()
        Me.cmdChangeUser = New C1.Win.C1Command.C1Command()
        Me.cmdChangeSite = New C1.Win.C1Command.C1Command()
        Me.cmdExit = New C1.Win.C1Command.C1Command()
        Me.cmdChangeServer = New C1.Win.C1Command.C1Command()
        Me.NotiIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.tlbConfig = New C1.Win.C1Command.C1ToolBar()
        Me.pagConfiguracion = New C1.Win.C1Command.C1OutPage()
        Me.btnChangeCompany = New C1.Win.C1Command.C1CommandLink()
        Me.splOptions = New System.Windows.Forms.SplitContainer()
        Me.TopicBar = New C1.Win.C1Command.C1TopicBar()
        Me.btnChangeServer = New C1.Win.C1Command.C1CommandLink()
        Me.btnChangeUser = New C1.Win.C1Command.C1CommandLink()
        Me.btnExit = New C1.Win.C1Command.C1CommandLink()
        Me.btnToggle = New C1.Win.C1Command.C1CommandLink()
        Me.CommandDock = New C1.Win.C1Command.C1CommandDock()
        Me.tlbMain = New C1.Win.C1Command.C1ToolBar()
        Me.OutBarMenu = New C1.Win.C1Command.C1OutBar()
        Me.pnlFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusBar = New System.Windows.Forms.StatusStrip()
        Me.pnlStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pgb = New System.Windows.Forms.ToolStripProgressBar()
        Me.pnlUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.splMain = New System.Windows.Forms.SplitContainer()
        Me.pagIglesia.SuspendLayout()
        CType(Me.CommandHolder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagConfiguracion.SuspendLayout()
        CType(Me.splOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splOptions.Panel1.SuspendLayout()
        Me.splOptions.Panel2.SuspendLayout()
        Me.splOptions.SuspendLayout()
        CType(Me.TopicBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandDock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CommandDock.SuspendLayout()
        CType(Me.OutBarMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OutBarMenu.SuspendLayout()
        Me.StatusBar.SuspendLayout()
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
        Me.lvwProcesos.Size = New System.Drawing.Size(606, 654)
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
        'pagIglesia
        '
        Me.pagIglesia.Controls.Add(Me.tlbIglesia)
        Me.pagIglesia.Image = Global.Azteca.Windows.My.Resources.MenuIcons.iglesia
        Me.pagIglesia.Name = "pagIglesia"
        Me.pagIglesia.Size = New System.Drawing.Size(211, 582)
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
        Me.tlbIglesia.Size = New System.Drawing.Size(211, 582)
        Me.tlbIglesia.Tag = "7"
        Me.tlbIglesia.Text = "Page2"
        Me.tlbIglesia.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'CommandHolder
        '
        Me.CommandHolder.Commands.Add(Me.cmdTogle)
        Me.CommandHolder.Commands.Add(Me.cmdChangeUser)
        Me.CommandHolder.Commands.Add(Me.cmdChangeSite)
        Me.CommandHolder.Commands.Add(Me.cmdExit)
        Me.CommandHolder.Commands.Add(Me.cmdChangeServer)
        Me.CommandHolder.Owner = Me
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
        'NotiIcon
        '
        Me.NotiIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotiIcon.Icon = CType(resources.GetObject("NotiIcon.Icon"), System.Drawing.Icon)
        Me.NotiIcon.Text = "Pixkua"
        Me.NotiIcon.Visible = True
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
        Me.tlbConfig.Size = New System.Drawing.Size(211, 546)
        Me.tlbConfig.Tag = "100"
        Me.tlbConfig.Text = "Page2"
        Me.tlbConfig.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tlbConfig.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagConfiguracion
        '
        Me.pagConfiguracion.Controls.Add(Me.tlbConfig)
        Me.pagConfiguracion.Image = CType(resources.GetObject("pagConfiguracion.Image"), System.Drawing.Image)
        Me.pagConfiguracion.Name = "pagConfiguracion"
        Me.pagConfiguracion.Size = New System.Drawing.Size(211, 546)
        Me.pagConfiguracion.Tag = "100"
        Me.pagConfiguracion.Text = "Configuración"
        '
        'btnChangeCompany
        '
        Me.btnChangeCompany.Command = Me.cmdChangeSite
        Me.btnChangeCompany.SortOrder = 2
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
        Me.splOptions.Size = New System.Drawing.Size(767, 654)
        Me.splOptions.SplitterDistance = 606
        Me.splOptions.SplitterWidth = 3
        Me.splOptions.TabIndex = 12
        '
        'TopicBar
        '
        Me.TopicBar.AutoScrollMinSize = New System.Drawing.Size(0, 267)
        Me.TopicBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TopicBar.Location = New System.Drawing.Point(0, 0)
        Me.TopicBar.Name = "TopicBar"
        C1TopicPage4.ImageList = Me.imlEstatus
        C1TopicLink6.ImageIndex = 1
        C1TopicLink6.Text = "Empresa"
        C1TopicLink7.ImageIndex = 2
        C1TopicLink7.Text = "Sucursal"
        C1TopicLink8.ImageIndex = 0
        C1TopicLink8.Text = "Usuario"
        C1TopicPage4.Links.Add(C1TopicLink6)
        C1TopicPage4.Links.Add(C1TopicLink7)
        C1TopicPage4.Links.Add(C1TopicLink8)
        C1TopicPage4.Text = "Información de Login"
        C1TopicPage5.ImageList = Me.imlEstatus
        C1TopicLink9.ImageIndex = 5
        C1TopicLink9.Text = "Conexión"
        C1TopicPage5.Links.Add(C1TopicLink9)
        C1TopicPage5.Text = "Conexión"
        C1TopicPage6.ImageList = Me.imlEstatus
        C1TopicLink10.ImageIndex = 3
        C1TopicLink10.Text = "Versión"
        C1TopicPage6.Links.Add(C1TopicLink10)
        C1TopicPage6.Text = "Información General"
        Me.TopicBar.Pages.Add(C1TopicPage4)
        Me.TopicBar.Pages.Add(C1TopicPage5)
        Me.TopicBar.Pages.Add(C1TopicPage6)
        Me.TopicBar.Size = New System.Drawing.Size(158, 654)
        Me.TopicBar.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.TopicBar.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'btnChangeServer
        '
        Me.btnChangeServer.Command = Me.cmdChangeServer
        Me.btnChangeServer.Delimiter = True
        Me.btnChangeServer.SortOrder = 3
        '
        'btnChangeUser
        '
        Me.btnChangeUser.Command = Me.cmdChangeUser
        Me.btnChangeUser.SortOrder = 1
        '
        'btnExit
        '
        Me.btnExit.Command = Me.cmdExit
        Me.btnExit.SortOrder = 4
        '
        'btnToggle
        '
        Me.btnToggle.Command = Me.cmdTogle
        '
        'CommandDock
        '
        Me.CommandDock.AutoSize = False
        Me.CommandDock.Controls.Add(Me.tlbMain)
        Me.CommandDock.Id = 2
        Me.CommandDock.Location = New System.Drawing.Point(0, 0)
        Me.CommandDock.Name = "CommandDock"
        Me.CommandDock.Size = New System.Drawing.Size(982, 42)
        '
        'tlbMain
        '
        Me.tlbMain.AccessibleName = "Tool Bar"
        Me.tlbMain.CommandHolder = Me.CommandHolder
        Me.tlbMain.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.btnToggle, Me.btnChangeUser, Me.btnChangeCompany, Me.btnChangeServer, Me.btnExit})
        Me.tlbMain.Location = New System.Drawing.Point(0, 0)
        Me.tlbMain.MinButtonSize = 40
        Me.tlbMain.Name = "tlbMain"
        Me.tlbMain.Size = New System.Drawing.Size(216, 42)
        Me.tlbMain.Text = "Main ToolBar"
        Me.tlbMain.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tlbMain.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'OutBarMenu
        '
        Me.OutBarMenu.Controls.Add(Me.pagIglesia)
        Me.OutBarMenu.Controls.Add(Me.pagConfiguracion)
        Me.OutBarMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OutBarMenu.Location = New System.Drawing.Point(0, 0)
        Me.OutBarMenu.Name = "OutBarMenu"
        Me.OutBarMenu.SelectedIndex = 1
        Me.OutBarMenu.Size = New System.Drawing.Size(211, 654)
        Me.OutBarMenu.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.OutBarMenu.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
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
        'StatusBar
        '
        Me.StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pnlStatus, Me.pgb, Me.pnlUsuario, Me.pnlFecha})
        Me.StatusBar.Location = New System.Drawing.Point(0, 696)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(982, 25)
        Me.StatusBar.TabIndex = 16
        '
        'pnlStatus
        '
        Me.pnlStatus.AutoSize = False
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(798, 20)
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
        Me.splMain.Size = New System.Drawing.Size(982, 654)
        Me.splMain.SplitterDistance = 211
        Me.splMain.TabIndex = 17
        '
        'ChurchManagerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 721)
        Me.Controls.Add(Me.splMain)
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.CommandDock)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ChurchManagerForm"
        Me.Text = "ChurchManagerForm"
        Me.pagIglesia.ResumeLayout(False)
        CType(Me.CommandHolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagConfiguracion.ResumeLayout(False)
        Me.splOptions.Panel1.ResumeLayout(False)
        Me.splOptions.Panel2.ResumeLayout(False)
        CType(Me.splOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splOptions.ResumeLayout(False)
        CType(Me.TopicBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandDock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CommandDock.ResumeLayout(False)
        CType(Me.OutBarMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OutBarMenu.ResumeLayout(False)
        Me.StatusBar.ResumeLayout(False)
        Me.StatusBar.PerformLayout()
        Me.splMain.Panel1.ResumeLayout(False)
        Me.splMain.Panel2.ResumeLayout(False)
        CType(Me.splMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splMain.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvwProcesos As System.Windows.Forms.ListView
    Private WithEvents imlEstatus As System.Windows.Forms.ImageList
    Friend WithEvents pagIglesia As C1.Win.C1Command.C1OutPage
    Friend WithEvents tlbIglesia As C1.Win.C1Command.C1ToolBar
    Friend WithEvents CommandHolder As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents cmdTogle As C1.Win.C1Command.C1Command
    Friend WithEvents cmdChangeUser As C1.Win.C1Command.C1Command
    Friend WithEvents cmdChangeSite As C1.Win.C1Command.C1Command
    Friend WithEvents cmdExit As C1.Win.C1Command.C1Command
    Friend WithEvents cmdChangeServer As C1.Win.C1Command.C1Command
    Friend WithEvents NotiIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents tlbConfig As C1.Win.C1Command.C1ToolBar
    Friend WithEvents pagConfiguracion As C1.Win.C1Command.C1OutPage
    Friend WithEvents btnChangeCompany As C1.Win.C1Command.C1CommandLink
    Friend WithEvents splOptions As System.Windows.Forms.SplitContainer
    Friend WithEvents TopicBar As C1.Win.C1Command.C1TopicBar
    Friend WithEvents btnChangeServer As C1.Win.C1Command.C1CommandLink
    Friend WithEvents btnChangeUser As C1.Win.C1Command.C1CommandLink
    Friend WithEvents btnExit As C1.Win.C1Command.C1CommandLink
    Friend WithEvents btnToggle As C1.Win.C1Command.C1CommandLink
    Friend WithEvents CommandDock As C1.Win.C1Command.C1CommandDock
    Friend WithEvents tlbMain As C1.Win.C1Command.C1ToolBar
    Friend WithEvents OutBarMenu As C1.Win.C1Command.C1OutBar
    Private WithEvents pnlFecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusBar As System.Windows.Forms.StatusStrip
    Private WithEvents pnlStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pgb As System.Windows.Forms.ToolStripProgressBar
    Private WithEvents pnlUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents splMain As System.Windows.Forms.SplitContainer
    Private WithEvents colProceso As System.Windows.Forms.ColumnHeader
    Private WithEvents colDescr As System.Windows.Forms.ColumnHeader
    Private WithEvents imlSmallIcons As System.Windows.Forms.ImageList
End Class
