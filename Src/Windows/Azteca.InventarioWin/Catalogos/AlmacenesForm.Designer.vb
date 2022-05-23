<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlmacenesForm
    Inherits Azteca.Windows.Forms.BusinessForms.CatalogForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlmacenesForm))
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.chkReqCapturaFisico = New Azteca.Windows.Controls.CICheckBox()
        Me.chkPermiteNeg = New Azteca.Windows.Controls.CICheckBox()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.imlAreas = New System.Windows.Forms.ImageList(Me.components)
        Me.bsPasillos = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabUbicaciones = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagUbicaciones = New C1.Win.C1Command.C1DockingTabPage()
        Me.split = New System.Windows.Forms.SplitContainer()
        Me.tvwHierarchy = New Azteca.Windows.Controls.CITreeView()
        Me.mnuHierarchy = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuNuevoNodo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEliminarNodo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSubir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBajar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExpandir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuActualizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.lmgTree = New System.Windows.Forms.ImageList(Me.components)
        Me.AzToolBar1 = New Azteca.Windows.Controls.AZToolBar()
        Me.clnkAgregar = New C1.Win.C1Command.C1CommandLink()
        Me.cmdAgregar = New C1.Win.C1Command.C1Command()
        Me.clnkEditar = New C1.Win.C1Command.C1CommandLink()
        Me.cmdEditar = New C1.Win.C1Command.C1Command()
        Me.clnkSubir = New C1.Win.C1Command.C1CommandLink()
        Me.cmdSubir = New C1.Win.C1Command.C1Command()
        Me.clnkBajar = New C1.Win.C1Command.C1CommandLink()
        Me.cmdBajar = New C1.Win.C1Command.C1Command()
        Me.clnkActualizar = New C1.Win.C1Command.C1CommandLink()
        Me.cmdActualizar = New C1.Win.C1Command.C1Command()
        Me.lblTipo = New Azteca.Windows.Controls.CILabel()
        Me.txtNivel = New Azteca.Windows.Controls.CITextBox()
        Me.lblPath = New Azteca.Windows.Controls.CILabel()
        Me.txtPath = New Azteca.Windows.Controls.CITextBox()
        Me.lblNivel = New Azteca.Windows.Controls.CILabel()
        Me.cboImpresora = New Azteca.Windows.Controls.ImpresorasComboBox()
        Me.selCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.lblImpresora = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel24 = New Azteca.Windows.Controls.CILabel()
        Me.txtNombreUbicacion = New Azteca.Windows.Controls.CITextBox()
        Me.lblNombreUbicacion = New Azteca.Windows.Controls.CILabel()
        Me.tlbAlmacenes = New Azteca.Windows.Controls.AZToolBar()
        Me.btnAplicar = New C1.Win.C1Command.C1CommandLink()
        Me.cmdAplicar = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdCancelar = New C1.Win.C1Command.C1Command()
        Me.CiLabel5 = New Azteca.Windows.Controls.CILabel()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.imlHierarchy = New System.Windows.Forms.ImageList(Me.components)
        Me.txtCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.cboUbicacionTipo = New Azteca.Windows.Inventario.UbicacionTipoCombobox()
        Me.cboArea = New Azteca.Windows.Inventario.AreasComboBox()
        CType(Me.bsPasillos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabUbicaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabUbicaciones.SuspendLayout()
        Me.pagUbicaciones.SuspendLayout()
        CType(Me.split, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.split.Panel1.SuspendLayout()
        Me.split.Panel2.SuspendLayout()
        Me.split.SuspendLayout()
        Me.mnuHierarchy.SuspendLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(68, 148)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(44, 13)
        Me.CiLabel3.TabIndex = 36
        Me.CiLabel3.Text = "Cuenta:"
        '
        'txtNombre
        '
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(121, 117)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(361, 20)
        Me.txtNombre.TabIndex = 35
        '
        'chkReqCapturaFisico
        '
        Me.chkReqCapturaFisico.AutoSize = True
        Me.chkReqCapturaFisico.Location = New System.Drawing.Point(121, 199)
        Me.chkReqCapturaFisico.Name = "chkReqCapturaFisico"
        Me.chkReqCapturaFisico.Size = New System.Drawing.Size(201, 17)
        Me.chkReqCapturaFisico.TabIndex = 40
        Me.chkReqCapturaFisico.Text = "Requiere captura de inventario físico"
        Me.chkReqCapturaFisico.UseVisualStyleBackColor = True
        '
        'chkPermiteNeg
        '
        Me.chkPermiteNeg.AutoSize = True
        Me.chkPermiteNeg.Location = New System.Drawing.Point(121, 176)
        Me.chkPermiteNeg.Name = "chkPermiteNeg"
        Me.chkPermiteNeg.Size = New System.Drawing.Size(112, 17)
        Me.chkPermiteNeg.TabIndex = 39
        Me.chkPermiteNeg.Text = "Permite Negativos"
        Me.chkPermiteNeg.UseVisualStyleBackColor = True
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(68, 93)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(32, 13)
        Me.CiLabel2.TabIndex = 32
        Me.CiLabel2.Text = "Área:"
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(68, 120)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(47, 13)
        Me.CiLabel1.TabIndex = 34
        Me.CiLabel1.Text = "Nombre:"
        '
        'imlAreas
        '
        Me.imlAreas.ImageStream = CType(resources.GetObject("imlAreas.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlAreas.TransparentColor = System.Drawing.Color.Transparent
        Me.imlAreas.Images.SetKeyName(0, "library_32.png")
        Me.imlAreas.Images.SetKeyName(1, "network_rack_32.png")
        '
        'bsPasillos
        '
        Me.bsPasillos.AllowNew = True
        '
        'tabUbicaciones
        '
        Me.tabUbicaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabUbicaciones.Controls.Add(Me.pagUbicaciones)
        Me.tabUbicaciones.ImageList = Me.imlAreas
        Me.tabUbicaciones.Location = New System.Drawing.Point(5, 222)
        Me.tabUbicaciones.Name = "tabUbicaciones"
        Me.tabUbicaciones.SelectedIndex = 1
        Me.tabUbicaciones.Size = New System.Drawing.Size(818, 346)
        Me.tabUbicaciones.TabIndex = 41
        Me.tabUbicaciones.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabUbicaciones.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabUbicaciones.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagUbicaciones
        '
        Me.pagUbicaciones.Controls.Add(Me.split)
        Me.pagUbicaciones.Controls.Add(Me.CiLabel5)
        Me.pagUbicaciones.ImageIndex = 0
        Me.pagUbicaciones.Location = New System.Drawing.Point(1, 41)
        Me.pagUbicaciones.Name = "pagUbicaciones"
        Me.pagUbicaciones.Size = New System.Drawing.Size(816, 304)
        Me.pagUbicaciones.TabIndex = 0
        Me.pagUbicaciones.Text = "Ubicaciones"
        '
        'split
        '
        Me.split.BackColor = System.Drawing.Color.Transparent
        Me.split.Dock = System.Windows.Forms.DockStyle.Top
        Me.split.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.split.Location = New System.Drawing.Point(0, 37)
        Me.split.Name = "split"
        '
        'split.Panel1
        '
        Me.split.Panel1.Controls.Add(Me.tvwHierarchy)
        Me.split.Panel1.Controls.Add(Me.AzToolBar1)
        '
        'split.Panel2
        '
        Me.split.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.split.Panel2.Controls.Add(Me.cboUbicacionTipo)
        Me.split.Panel2.Controls.Add(Me.lblTipo)
        Me.split.Panel2.Controls.Add(Me.txtNivel)
        Me.split.Panel2.Controls.Add(Me.lblPath)
        Me.split.Panel2.Controls.Add(Me.txtPath)
        Me.split.Panel2.Controls.Add(Me.lblNivel)
        Me.split.Panel2.Controls.Add(Me.cboImpresora)
        Me.split.Panel2.Controls.Add(Me.selCuenta)
        Me.split.Panel2.Controls.Add(Me.lblImpresora)
        Me.split.Panel2.Controls.Add(Me.CiLabel24)
        Me.split.Panel2.Controls.Add(Me.txtNombreUbicacion)
        Me.split.Panel2.Controls.Add(Me.lblNombreUbicacion)
        Me.split.Panel2.Controls.Add(Me.tlbAlmacenes)
        Me.split.Panel2.Enabled = False
        Me.split.Size = New System.Drawing.Size(816, 264)
        Me.split.SplitterDistance = 351
        Me.split.TabIndex = 57
        '
        'tvwHierarchy
        '
        Me.tvwHierarchy.AllowDrop = True
        Me.tvwHierarchy.ContextMenuStrip = Me.mnuHierarchy
        Me.tvwHierarchy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvwHierarchy.ImageIndex = 0
        Me.tvwHierarchy.ImageList = Me.lmgTree
        Me.tvwHierarchy.Location = New System.Drawing.Point(0, 34)
        Me.tvwHierarchy.Name = "tvwHierarchy"
        Me.tvwHierarchy.SelectedImageIndex = 0
        Me.tvwHierarchy.Size = New System.Drawing.Size(351, 230)
        Me.tvwHierarchy.StateImageList = Me.lmgTree
        Me.tvwHierarchy.TabIndex = 57
        '
        'mnuHierarchy
        '
        Me.mnuHierarchy.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNuevoNodo, Me.mnuEliminarNodo, Me.ToolStripMenuItem1, Me.mnuSubir, Me.mnuBajar, Me.ToolStripMenuItem2, Me.mnuExpandir, Me.mnuActualizar})
        Me.mnuHierarchy.Name = "mnuEstCom"
        Me.mnuHierarchy.Size = New System.Drawing.Size(153, 148)
        '
        'mnuNuevoNodo
        '
        Me.mnuNuevoNodo.Image = CType(resources.GetObject("mnuNuevoNodo.Image"), System.Drawing.Image)
        Me.mnuNuevoNodo.Name = "mnuNuevoNodo"
        Me.mnuNuevoNodo.Size = New System.Drawing.Size(152, 22)
        Me.mnuNuevoNodo.Text = "Nuevo Nodo..."
        '
        'mnuEliminarNodo
        '
        Me.mnuEliminarNodo.Enabled = False
        Me.mnuEliminarNodo.Image = CType(resources.GetObject("mnuEliminarNodo.Image"), System.Drawing.Image)
        Me.mnuEliminarNodo.Name = "mnuEliminarNodo"
        Me.mnuEliminarNodo.Size = New System.Drawing.Size(152, 22)
        Me.mnuEliminarNodo.Text = "Eliminar Nodo"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'mnuSubir
        '
        Me.mnuSubir.Image = CType(resources.GetObject("mnuSubir.Image"), System.Drawing.Image)
        Me.mnuSubir.Name = "mnuSubir"
        Me.mnuSubir.Size = New System.Drawing.Size(152, 22)
        Me.mnuSubir.Text = "Subir Nodo"
        '
        'mnuBajar
        '
        Me.mnuBajar.Image = CType(resources.GetObject("mnuBajar.Image"), System.Drawing.Image)
        Me.mnuBajar.Name = "mnuBajar"
        Me.mnuBajar.Size = New System.Drawing.Size(152, 22)
        Me.mnuBajar.Text = "Bajar Nodo"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(149, 6)
        '
        'mnuExpandir
        '
        Me.mnuExpandir.Name = "mnuExpandir"
        Me.mnuExpandir.Size = New System.Drawing.Size(152, 22)
        Me.mnuExpandir.Text = "Expandir Nodo"
        '
        'mnuActualizar
        '
        Me.mnuActualizar.Image = CType(resources.GetObject("mnuActualizar.Image"), System.Drawing.Image)
        Me.mnuActualizar.Name = "mnuActualizar"
        Me.mnuActualizar.Size = New System.Drawing.Size(152, 22)
        Me.mnuActualizar.Text = "Actualizar"
        '
        'lmgTree
        '
        Me.lmgTree.ImageStream = CType(resources.GetObject("lmgTree.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.lmgTree.TransparentColor = System.Drawing.Color.Transparent
        Me.lmgTree.Images.SetKeyName(0, "library_16.png")
        '
        'AzToolBar1
        '
        Me.AzToolBar1.AccessibleName = "Tool Bar"
        Me.AzToolBar1.AutoSize = False
        Me.AzToolBar1.CommandHolder = Nothing
        Me.AzToolBar1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.clnkAgregar, Me.clnkEditar, Me.clnkSubir, Me.clnkBajar, Me.clnkActualizar})
        Me.AzToolBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.AzToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.AzToolBar1.MinButtonSize = 32
        Me.AzToolBar1.Movable = False
        Me.AzToolBar1.Name = "AzToolBar1"
        Me.AzToolBar1.Size = New System.Drawing.Size(351, 34)
        Me.AzToolBar1.Text = "AzToolBar1"
        Me.AzToolBar1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'clnkAgregar
        '
        Me.clnkAgregar.Command = Me.cmdAgregar
        Me.clnkAgregar.Text = "New Command"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Image = CType(resources.GetObject("cmdAgregar.Image"), System.Drawing.Image)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.ShortcutText = ""
        '
        'clnkEditar
        '
        Me.clnkEditar.Command = Me.cmdEditar
        Me.clnkEditar.SortOrder = 1
        Me.clnkEditar.Text = "New Command"
        '
        'cmdEditar
        '
        Me.cmdEditar.Image = CType(resources.GetObject("cmdEditar.Image"), System.Drawing.Image)
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.ShortcutText = ""
        '
        'clnkSubir
        '
        Me.clnkSubir.Command = Me.cmdSubir
        Me.clnkSubir.SortOrder = 2
        Me.clnkSubir.Text = "New Command"
        '
        'cmdSubir
        '
        Me.cmdSubir.Image = CType(resources.GetObject("cmdSubir.Image"), System.Drawing.Image)
        Me.cmdSubir.Name = "cmdSubir"
        Me.cmdSubir.ShortcutText = ""
        '
        'clnkBajar
        '
        Me.clnkBajar.Command = Me.cmdBajar
        Me.clnkBajar.SortOrder = 3
        Me.clnkBajar.Text = "New Command"
        '
        'cmdBajar
        '
        Me.cmdBajar.Image = CType(resources.GetObject("cmdBajar.Image"), System.Drawing.Image)
        Me.cmdBajar.Name = "cmdBajar"
        Me.cmdBajar.ShortcutText = ""
        '
        'clnkActualizar
        '
        Me.clnkActualizar.Command = Me.cmdActualizar
        Me.clnkActualizar.SortOrder = 4
        Me.clnkActualizar.Text = "New Command"
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Image = CType(resources.GetObject("cmdActualizar.Image"), System.Drawing.Image)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.ShortcutText = ""
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(13, 81)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(31, 13)
        Me.lblTipo.TabIndex = 55
        Me.lblTipo.Text = "Tipo:"
        '
        'txtNivel
        '
        Me.txtNivel.AutoLock = False
        Me.txtNivel.Digits = True
        Me.txtNivel.Enabled = False
        Me.txtNivel.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNivel.Location = New System.Drawing.Point(79, 206)
        Me.txtNivel.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNivel.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNivel.Name = "txtNivel"
        Me.txtNivel.ReadOnly = True
        Me.txtNivel.Size = New System.Drawing.Size(65, 20)
        Me.txtNivel.TabIndex = 54
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Location = New System.Drawing.Point(13, 159)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(32, 13)
        Me.lblPath.TabIndex = 51
        Me.lblPath.Text = "Path:"
        '
        'txtPath
        '
        Me.txtPath.AutoLock = False
        Me.txtPath.Enabled = False
        Me.txtPath.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtPath.Location = New System.Drawing.Point(78, 154)
        Me.txtPath.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPath.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPath.Multiline = True
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(341, 46)
        Me.txtPath.TabIndex = 52
        '
        'lblNivel
        '
        Me.lblNivel.AutoSize = True
        Me.lblNivel.Location = New System.Drawing.Point(13, 208)
        Me.lblNivel.Name = "lblNivel"
        Me.lblNivel.Size = New System.Drawing.Size(34, 13)
        Me.lblNivel.TabIndex = 53
        Me.lblNivel.Text = "Nivel:"
        '
        'cboImpresora
        '
        Me.cboImpresora.AddNoneItem = True
        Me.cboImpresora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboImpresora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboImpresora.FormattingEnabled = True
        Me.cboImpresora.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboImpresora.ItemsTable = Nothing
        Me.cboImpresora.Location = New System.Drawing.Point(78, 102)
        Me.cboImpresora.Name = "cboImpresora"
        Me.cboImpresora.Size = New System.Drawing.Size(361, 21)
        Me.cboImpresora.TabIndex = 47
        Me.cboImpresora.UIName = Nothing
        '
        'selCuenta
        '
        Me.selCuenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.selCuenta.AnySite = False
        Me.selCuenta.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selCuenta.EditorAssembly = "Azteca.ContabilidadWin"
        Me.selCuenta.EditorClass = "Azteca.Windows.Contabilidad.CuentaForm"
        Me.selCuenta.EditorTitle = "Editar Cuenta..."
        Me.selCuenta.Key = 0
        Me.selCuenta.Linked = False
        Me.selCuenta.Location = New System.Drawing.Point(78, 125)
        Me.selCuenta.Name = "selCuenta"
        Me.selCuenta.Size = New System.Drawing.Size(362, 23)
        Me.selCuenta.TabIndex = 49
        Me.selCuenta.TextWidth = 100
        '
        'lblImpresora
        '
        Me.lblImpresora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblImpresora.AutoSize = True
        Me.lblImpresora.BackColor = System.Drawing.Color.Transparent
        Me.lblImpresora.Location = New System.Drawing.Point(13, 105)
        Me.lblImpresora.Name = "lblImpresora"
        Me.lblImpresora.Size = New System.Drawing.Size(56, 13)
        Me.lblImpresora.TabIndex = 46
        Me.lblImpresora.Text = "Impresora:"
        '
        'CiLabel24
        '
        Me.CiLabel24.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CiLabel24.AutoSize = True
        Me.CiLabel24.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel24.Location = New System.Drawing.Point(13, 129)
        Me.CiLabel24.Name = "CiLabel24"
        Me.CiLabel24.Size = New System.Drawing.Size(44, 13)
        Me.CiLabel24.TabIndex = 48
        Me.CiLabel24.Text = "Cuenta:"
        '
        'txtNombreUbicacion
        '
        Me.txtNombreUbicacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreUbicacion.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombreUbicacion.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombreUbicacion.Location = New System.Drawing.Point(78, 53)
        Me.txtNombreUbicacion.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombreUbicacion.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombreUbicacion.Name = "txtNombreUbicacion"
        Me.txtNombreUbicacion.Size = New System.Drawing.Size(362, 20)
        Me.txtNombreUbicacion.TabIndex = 45
        Me.txtNombreUbicacion.UIName = "Nombre"
        '
        'lblNombreUbicacion
        '
        Me.lblNombreUbicacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNombreUbicacion.AutoSize = True
        Me.lblNombreUbicacion.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreUbicacion.Location = New System.Drawing.Point(13, 56)
        Me.lblNombreUbicacion.Name = "lblNombreUbicacion"
        Me.lblNombreUbicacion.Size = New System.Drawing.Size(66, 13)
        Me.lblNombreUbicacion.TabIndex = 44
        Me.lblNombreUbicacion.Text = "Descripción:"
        '
        'tlbAlmacenes
        '
        Me.tlbAlmacenes.AccessibleName = "Tool Bar"
        Me.tlbAlmacenes.AutoSize = False
        Me.tlbAlmacenes.CommandHolder = Nothing
        Me.tlbAlmacenes.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.btnAplicar, Me.C1CommandLink1})
        Me.tlbAlmacenes.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbAlmacenes.Location = New System.Drawing.Point(0, 0)
        Me.tlbAlmacenes.MinButtonSize = 32
        Me.tlbAlmacenes.Movable = False
        Me.tlbAlmacenes.Name = "tlbAlmacenes"
        Me.tlbAlmacenes.Size = New System.Drawing.Size(461, 34)
        Me.tlbAlmacenes.Text = "AzToolBar1"
        Me.tlbAlmacenes.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'btnAplicar
        '
        Me.btnAplicar.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnAplicar.Command = Me.cmdAplicar
        Me.btnAplicar.Text = "Aplicar"
        '
        'cmdAplicar
        '
        Me.cmdAplicar.Image = Global.Azteca.Windows.Inventario.My.Resources.Resources.button_ok
        Me.cmdAplicar.Name = "cmdAplicar"
        Me.cmdAplicar.ShortcutText = ""
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink1.Command = Me.cmdCancelar
        Me.C1CommandLink1.SortOrder = 1
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Image = Global.Azteca.Windows.Inventario.My.Resources.Resources.button_cancel
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.ShortcutText = ""
        Me.cmdCancelar.Text = "Cancelar"
        '
        'CiLabel5
        '
        Me.CiLabel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.CiLabel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.CiLabel5.Location = New System.Drawing.Point(0, 0)
        Me.CiLabel5.Name = "CiLabel5"
        Me.CiLabel5.Size = New System.Drawing.Size(816, 37)
        Me.CiLabel5.TabIndex = 56
        Me.CiLabel5.Text = "   Definición de la distribucion de espacios del almácen"
        Me.CiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdAplicar)
        Me.C1CommandHolder1.Commands.Add(Me.cmdCancelar)
        Me.C1CommandHolder1.Commands.Add(Me.cmdAgregar)
        Me.C1CommandHolder1.Commands.Add(Me.cmdEditar)
        Me.C1CommandHolder1.Commands.Add(Me.cmdSubir)
        Me.C1CommandHolder1.Commands.Add(Me.cmdBajar)
        Me.C1CommandHolder1.Commands.Add(Me.cmdActualizar)
        Me.C1CommandHolder1.Owner = Me
        '
        'imlHierarchy
        '
        Me.imlHierarchy.ImageStream = CType(resources.GetObject("imlHierarchy.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlHierarchy.TransparentColor = System.Drawing.Color.Transparent
        Me.imlHierarchy.Images.SetKeyName(0, "agt_internet.png")
        '
        'txtCuenta
        '
        Me.txtCuenta.AnySite = False
        Me.txtCuenta.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtCuenta.EditorAssembly = "Azteca.ContabilidadWin"
        Me.txtCuenta.EditorClass = "Azteca.Windows.Contabilidad.CuentaForm"
        Me.txtCuenta.EditorTitle = "Editar Cuenta..."
        Me.txtCuenta.Key = 0
        Me.txtCuenta.Linked = False
        Me.txtCuenta.Location = New System.Drawing.Point(121, 143)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(361, 23)
        Me.txtCuenta.TabIndex = 37
        Me.txtCuenta.TextWidth = 100
        '
        'cboUbicacionTipo
        '
        Me.cboUbicacionTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUbicacionTipo.FormattingEnabled = True
        Me.cboUbicacionTipo.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboUbicacionTipo.ItemsTable = Nothing
        Me.cboUbicacionTipo.Location = New System.Drawing.Point(79, 75)
        Me.cboUbicacionTipo.Name = "cboUbicacionTipo"
        Me.cboUbicacionTipo.Size = New System.Drawing.Size(360, 21)
        Me.cboUbicacionTipo.TabIndex = 57
        Me.cboUbicacionTipo.UIName = Nothing
        '
        'cboArea
        '
        Me.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboArea.FormattingEnabled = True
        Me.cboArea.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboArea.ItemsTable = Nothing
        Me.cboArea.Location = New System.Drawing.Point(121, 90)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.RequiredField = True
        Me.cboArea.Size = New System.Drawing.Size(228, 21)
        Me.cboArea.TabIndex = 33
        Me.cboArea.UIName = Nothing
        '
        'AlmacenesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 596)
        Me.Controls.Add(Me.tabUbicaciones)
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.CiLabel3)
        Me.Controls.Add(Me.cboArea)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.chkReqCapturaFisico)
        Me.Controls.Add(Me.chkPermiteNeg)
        Me.Controls.Add(Me.CiLabel2)
        Me.Controls.Add(Me.CiLabel1)
        Me.Name = "AlmacenesForm"
        Me.Text = "AlmacenesForm"
        Me.Controls.SetChildIndex(Me.CiLabel1, 0)
        Me.Controls.SetChildIndex(Me.CiLabel2, 0)
        Me.Controls.SetChildIndex(Me.chkPermiteNeg, 0)
        Me.Controls.SetChildIndex(Me.chkReqCapturaFisico, 0)
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.cboArea, 0)
        Me.Controls.SetChildIndex(Me.CiLabel3, 0)
        Me.Controls.SetChildIndex(Me.txtCuenta, 0)
        Me.Controls.SetChildIndex(Me.tabUbicaciones, 0)
        CType(Me.bsPasillos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabUbicaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabUbicaciones.ResumeLayout(False)
        Me.pagUbicaciones.ResumeLayout(False)
        Me.split.Panel1.ResumeLayout(False)
        Me.split.Panel2.ResumeLayout(False)
        Me.split.Panel2.PerformLayout()
        CType(Me.split, System.ComponentModel.ISupportInitialize).EndInit()
        Me.split.ResumeLayout(False)
        Me.mnuHierarchy.ResumeLayout(False)
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Facade = New AlmacenFacade
    End Sub
    Friend WithEvents txtCuenta As Azteca.Windows.Contabilidad.CuentaSelector
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboArea As Azteca.Windows.Inventario.AreasComboBox
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents chkReqCapturaFisico As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents chkPermiteNeg As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents tabUbicaciones As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagUbicaciones As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Private WithEvents imlAreas As System.Windows.Forms.ImageList
    Private WithEvents bsPasillos As System.Windows.Forms.BindingSource
    Friend WithEvents imlHierarchy As System.Windows.Forms.ImageList
    Friend WithEvents mnuHierarchy As System.Windows.Forms.ContextMenuStrip
    Private WithEvents mnuNuevoNodo As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents mnuEliminarNodo As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents mnuSubir As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents mnuBajar As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents mnuExpandir As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents mnuActualizar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CiLabel5 As Azteca.Windows.Controls.CILabel
    Friend WithEvents split As System.Windows.Forms.SplitContainer
    Friend WithEvents tvwHierarchy As Azteca.Windows.Controls.CITreeView
    Friend WithEvents cboImpresora As Azteca.Windows.Controls.ImpresorasComboBox
    Friend WithEvents selCuenta As Azteca.Windows.Contabilidad.CuentaSelector
    Friend WithEvents lblImpresora As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel24 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNombreUbicacion As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblNombreUbicacion As Azteca.Windows.Controls.CILabel
    Friend WithEvents tlbAlmacenes As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents btnAplicar As C1.Win.C1Command.C1CommandLink
    Private WithEvents cmdAplicar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Private WithEvents cmdCancelar As C1.Win.C1Command.C1Command
    Friend WithEvents lblTipo As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNivel As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblPath As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtPath As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblNivel As Azteca.Windows.Controls.CILabel
    Friend WithEvents AzToolBar1 As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents clnkAgregar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents clnkEditar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents clnkBajar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents clnkActualizar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents clnkSubir As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cboUbicacionTipo As Azteca.Windows.Inventario.UbicacionTipoCombobox
    Private WithEvents cmdAgregar As C1.Win.C1Command.C1Command
    Private WithEvents cmdEditar As C1.Win.C1Command.C1Command
    Private WithEvents cmdSubir As C1.Win.C1Command.C1Command
    Private WithEvents cmdBajar As C1.Win.C1Command.C1Command
    Private WithEvents cmdActualizar As C1.Win.C1Command.C1Command
    Friend WithEvents lmgTree As System.Windows.Forms.ImageList

End Class
