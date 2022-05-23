<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdenesTrabajoForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrdenesTrabajoForm))
        Me.chkExigirRecepcion = New Azteca.Windows.Controls.CICheckBox()
        Me.chkEntregasParciales = New Azteca.Windows.Controls.CICheckBox()
        Me.lblCuenta = New Azteca.Windows.Controls.CILabel()
        Me.lblArticulo = New Azteca.Windows.Controls.CILabel()
        Me.lblProducto = New Azteca.Windows.Controls.CILabel()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.txtCantDeseada = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.txtFolioPedido = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.txtVersion = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.dtpFechaPromEntrega = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.tabAreas = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagInsumos = New C1.Win.C1Command.C1DockingTabPage()
        Me.gbxDetalle = New Azteca.Windows.Controls.CIGroupBox()
        Me.grdInsumos = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsInsumos = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbMenu = New Azteca.Windows.Controls.CIToolBar()
        Me.btnNuevoArt = New System.Windows.Forms.ToolStripButton()
        Me.tabServicios = New C1.Win.C1Command.C1DockingTabPage()
        Me.CiGroupBox2 = New Azteca.Windows.Controls.CIGroupBox()
        Me.grdServicios = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.mnuServicios = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bsServicios = New System.Windows.Forms.BindingSource(Me.components)
        Me.CiToolBar2 = New Azteca.Windows.Controls.CIToolBar()
        Me.btnNuevoServicio = New System.Windows.Forms.ToolStripButton()
        Me.pagEnsambles = New C1.Win.C1Command.C1DockingTabPage()
        Me.CiGroupBox1 = New Azteca.Windows.Controls.CIGroupBox()
        Me.grdEnsambles = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsEnsambles = New System.Windows.Forms.BindingSource(Me.components)
        Me.CiToolBar1 = New Azteca.Windows.Controls.CIToolBar()
        Me.btnNuevoEnsamble = New System.Windows.Forms.ToolStripButton()
        Me.C1DockingTabPage1 = New C1.Win.C1Command.C1DockingTabPage()
        Me.txtObervaciones = New Azteca.Windows.Controls.CITextBox()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.CiLabel5 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel6 = New Azteca.Windows.Controls.CILabel()
        Me.dtpFechaRecepcion = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.CiLabel7 = New Azteca.Windows.Controls.CILabel()
        Me.cmdImprimir = New System.Windows.Forms.Button()
        Me.cmdClonar = New System.Windows.Forms.Button()
        Me.dtpFechaRequerida = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.CiLabel8 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel9 = New Azteca.Windows.Controls.CILabel()
        Me.txtCantPlanillas = New Azteca.Windows.Controls.CITextBox()
        Me.cboArea = New System.Windows.Forms.ComboBox()
        Me.CiLabel10 = New Azteca.Windows.Controls.CILabel()
        Me.selCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.gbTipoOrden = New System.Windows.Forms.GroupBox()
        Me.rdbTipoMaestroIng = New System.Windows.Forms.RadioButton()
        Me.rdbTipoOrdenTrabajo = New System.Windows.Forms.RadioButton()
        Me.cboAlmacenPT = New Azteca.Windows.Inventario.AlmacenesComboBox()
        Me.cboAlmacenInsumos = New Azteca.Windows.Inventario.AlmacenesComboBox()
        Me.selArticuloStock = New Azteca.Windows.Inventario.ArticuloStockSelector()
        CType(Me.tabAreas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAreas.SuspendLayout()
        Me.pagInsumos.SuspendLayout()
        Me.gbxDetalle.SuspendLayout()
        CType(Me.grdInsumos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsInsumos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbMenu.SuspendLayout()
        Me.tabServicios.SuspendLayout()
        Me.CiGroupBox2.SuspendLayout()
        CType(Me.grdServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuServicios.SuspendLayout()
        CType(Me.bsServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CiToolBar2.SuspendLayout()
        Me.pagEnsambles.SuspendLayout()
        Me.CiGroupBox1.SuspendLayout()
        CType(Me.grdEnsambles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsEnsambles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CiToolBar1.SuspendLayout()
        Me.C1DockingTabPage1.SuspendLayout()
        Me.gbTipoOrden.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkExigirRecepcion
        '
        Me.chkExigirRecepcion.AutoSize = True
        Me.chkExigirRecepcion.Location = New System.Drawing.Point(619, 257)
        Me.chkExigirRecepcion.Name = "chkExigirRecepcion"
        Me.chkExigirRecepcion.Size = New System.Drawing.Size(165, 17)
        Me.chkExigirRecepcion.TabIndex = 53
        Me.chkExigirRecepcion.Text = "Exigir la recepción al entregar"
        Me.chkExigirRecepcion.UseVisualStyleBackColor = True
        '
        'chkEntregasParciales
        '
        Me.chkEntregasParciales.AutoSize = True
        Me.chkEntregasParciales.Location = New System.Drawing.Point(619, 231)
        Me.chkEntregasParciales.Name = "chkEntregasParciales"
        Me.chkEntregasParciales.Size = New System.Drawing.Size(149, 17)
        Me.chkEntregasParciales.TabIndex = 52
        Me.chkEntregasParciales.Text = "Permitir entregas parciales"
        Me.chkEntregasParciales.UseVisualStyleBackColor = True
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Location = New System.Drawing.Point(59, 183)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(41, 13)
        Me.lblCuenta.TabIndex = 46
        Me.lblCuenta.Text = "Cuenta"
        '
        'lblArticulo
        '
        Me.lblArticulo.AutoSize = True
        Me.lblArticulo.Location = New System.Drawing.Point(61, 160)
        Me.lblArticulo.Name = "lblArticulo"
        Me.lblArticulo.Size = New System.Drawing.Size(42, 13)
        Me.lblArticulo.TabIndex = 44
        Me.lblArticulo.Text = "Articulo"
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(40, 138)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(63, 13)
        Me.lblProducto.TabIndex = 41
        Me.lblProducto.Text = "Descripción"
        '
        'txtNombre
        '
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(121, 138)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(412, 20)
        Me.txtNombre.TabIndex = 42
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(25, 211)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(78, 13)
        Me.CiLabel1.TabIndex = 55
        Me.CiLabel1.Text = "Cant. Deseada"
        '
        'txtCantDeseada
        '
        Me.txtCantDeseada.Digits = True
        Me.txtCantDeseada.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtCantDeseada.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCantDeseada.Location = New System.Drawing.Point(121, 208)
        Me.txtCantDeseada.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantDeseada.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantDeseada.Name = "txtCantDeseada"
        Me.txtCantDeseada.RequiredField = True
        Me.txtCantDeseada.Size = New System.Drawing.Size(101, 20)
        Me.txtCantDeseada.TabIndex = 56
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(556, 105)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(80, 13)
        Me.CiLabel2.TabIndex = 57
        Me.CiLabel2.Text = "Folio de Pedido"
        '
        'txtFolioPedido
        '
        Me.txtFolioPedido.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtFolioPedido.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtFolioPedido.Location = New System.Drawing.Point(645, 99)
        Me.txtFolioPedido.MaxLength = 18
        Me.txtFolioPedido.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFolioPedido.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFolioPedido.Name = "txtFolioPedido"
        Me.txtFolioPedido.Size = New System.Drawing.Size(139, 20)
        Me.txtFolioPedido.TabIndex = 58
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(58, 235)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(42, 13)
        Me.CiLabel3.TabIndex = 59
        Me.CiLabel3.Text = "Versión"
        '
        'txtVersion
        '
        Me.txtVersion.Digits = True
        Me.txtVersion.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtVersion.Location = New System.Drawing.Point(121, 234)
        Me.txtVersion.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtVersion.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(101, 20)
        Me.txtVersion.TabIndex = 60
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.Location = New System.Drawing.Point(559, 155)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(77, 13)
        Me.CiLabel4.TabIndex = 61
        Me.CiLabel4.Text = "Fecha Entrega"
        '
        'dtpFechaPromEntrega
        '
        Me.dtpFechaPromEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaPromEntrega.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaPromEntrega.Location = New System.Drawing.Point(645, 152)
        Me.dtpFechaPromEntrega.Name = "dtpFechaPromEntrega"
        Me.dtpFechaPromEntrega.Size = New System.Drawing.Size(139, 20)
        Me.dtpFechaPromEntrega.TabIndex = 62
        '
        'tabAreas
        '
        Me.tabAreas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabAreas.Controls.Add(Me.pagInsumos)
        Me.tabAreas.Controls.Add(Me.tabServicios)
        Me.tabAreas.Controls.Add(Me.pagEnsambles)
        Me.tabAreas.Controls.Add(Me.C1DockingTabPage1)
        Me.tabAreas.Location = New System.Drawing.Point(10, 294)
        Me.tabAreas.Name = "tabAreas"
        Me.tabAreas.Size = New System.Drawing.Size(781, 353)
        Me.tabAreas.TabIndex = 63
        Me.tabAreas.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabAreas.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabAreas.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagInsumos
        '
        Me.pagInsumos.Controls.Add(Me.gbxDetalle)
        Me.pagInsumos.Image = CType(resources.GetObject("pagInsumos.Image"), System.Drawing.Image)
        Me.pagInsumos.Location = New System.Drawing.Point(1, 41)
        Me.pagInsumos.Name = "pagInsumos"
        Me.pagInsumos.Size = New System.Drawing.Size(779, 311)
        Me.pagInsumos.TabIndex = 0
        Me.pagInsumos.Text = "Insumos/Consumibles"
        '
        'gbxDetalle
        '
        Me.gbxDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxDetalle.Controls.Add(Me.grdInsumos)
        Me.gbxDetalle.Controls.Add(Me.tbMenu)
        Me.gbxDetalle.Location = New System.Drawing.Point(3, 3)
        Me.gbxDetalle.Name = "gbxDetalle"
        Me.gbxDetalle.Size = New System.Drawing.Size(773, 269)
        Me.gbxDetalle.TabIndex = 55
        Me.gbxDetalle.TabStop = False
        '
        'grdInsumos
        '
        Me.grdInsumos.DataSource = Me.bsInsumos
        Me.grdInsumos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdInsumos.FetchRowStyles = True
        Me.grdInsumos.FilterBar = True
        Me.grdInsumos.IDCatalogField = "IdArticuloStock"
        Me.grdInsumos.Images.Add(CType(resources.GetObject("grdInsumos.Images"), System.Drawing.Image))
        Me.grdInsumos.Location = New System.Drawing.Point(3, 55)
        Me.grdInsumos.Name = "grdInsumos"
        Me.grdInsumos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdInsumos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdInsumos.PreviewInfo.ZoomFactor = 75.0R
        Me.grdInsumos.PrintInfo.PageSettings = CType(resources.GetObject("grdInsumos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdInsumos.Size = New System.Drawing.Size(767, 211)
        Me.grdInsumos.TabIndex = 29
        Me.grdInsumos.TabStop = False
        Me.grdInsumos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        Me.grdInsumos.PropBag = resources.GetString("grdInsumos.PropBag")
        '
        'tbMenu
        '
        Me.tbMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoArt})
        Me.tbMenu.Location = New System.Drawing.Point(3, 16)
        Me.tbMenu.Name = "tbMenu"
        Me.tbMenu.Size = New System.Drawing.Size(767, 39)
        Me.tbMenu.TabIndex = 28
        Me.tbMenu.Text = "CiToolBar1"
        '
        'btnNuevoArt
        '
        Me.btnNuevoArt.Image = CType(resources.GetObject("btnNuevoArt.Image"), System.Drawing.Image)
        Me.btnNuevoArt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevoArt.Name = "btnNuevoArt"
        Me.btnNuevoArt.Size = New System.Drawing.Size(162, 36)
        Me.btnNuevoArt.Text = "Incluir articulo insumo"
        '
        'tabServicios
        '
        Me.tabServicios.Controls.Add(Me.CiGroupBox2)
        Me.tabServicios.Image = Global.Azteca.Windows.Produccion.My.Resources.Resources.Servicios32X32
        Me.tabServicios.Location = New System.Drawing.Point(1, 41)
        Me.tabServicios.Name = "tabServicios"
        Me.tabServicios.Size = New System.Drawing.Size(779, 311)
        Me.tabServicios.TabIndex = 1
        Me.tabServicios.Text = "Servicios"
        '
        'CiGroupBox2
        '
        Me.CiGroupBox2.Controls.Add(Me.grdServicios)
        Me.CiGroupBox2.Controls.Add(Me.CiToolBar2)
        Me.CiGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CiGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.CiGroupBox2.Name = "CiGroupBox2"
        Me.CiGroupBox2.Size = New System.Drawing.Size(779, 311)
        Me.CiGroupBox2.TabIndex = 56
        Me.CiGroupBox2.TabStop = False
        '
        'grdServicios
        '
        Me.grdServicios.ContextMenuStrip = Me.mnuServicios
        Me.grdServicios.DataSource = Me.bsServicios
        Me.grdServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdServicios.FetchRowStyles = True
        Me.grdServicios.FilterBar = True
        Me.grdServicios.IDCatalogField = "IdEnsamble"
        Me.grdServicios.Images.Add(CType(resources.GetObject("grdServicios.Images"), System.Drawing.Image))
        Me.grdServicios.Location = New System.Drawing.Point(3, 55)
        Me.grdServicios.Name = "grdServicios"
        Me.grdServicios.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdServicios.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdServicios.PreviewInfo.ZoomFactor = 75.0R
        Me.grdServicios.PrintInfo.PageSettings = CType(resources.GetObject("grdServicios.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdServicios.Size = New System.Drawing.Size(773, 253)
        Me.grdServicios.TabIndex = 31
        Me.grdServicios.TabStop = False
        Me.grdServicios.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        Me.grdServicios.PropBag = resources.GetString("grdServicios.PropBag")
        '
        'mnuServicios
        '
        Me.mnuServicios.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.mnuServicios.Name = "mnuServicios"
        Me.mnuServicios.Size = New System.Drawing.Size(118, 48)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Image = Global.Azteca.Windows.Produccion.My.Resources.Resources.Edit_24
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.Azteca.Windows.Produccion.My.Resources.Resources.delete_32x32
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'CiToolBar2
        '
        Me.CiToolBar2.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.CiToolBar2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoServicio})
        Me.CiToolBar2.Location = New System.Drawing.Point(3, 16)
        Me.CiToolBar2.Name = "CiToolBar2"
        Me.CiToolBar2.Size = New System.Drawing.Size(773, 39)
        Me.CiToolBar2.TabIndex = 28
        Me.CiToolBar2.Text = "CiToolBar1"
        '
        'btnNuevoServicio
        '
        Me.btnNuevoServicio.Image = CType(resources.GetObject("btnNuevoServicio.Image"), System.Drawing.Image)
        Me.btnNuevoServicio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevoServicio.Name = "btnNuevoServicio"
        Me.btnNuevoServicio.Size = New System.Drawing.Size(129, 36)
        Me.btnNuevoServicio.Text = "Agregar Servicio"
        '
        'pagEnsambles
        '
        Me.pagEnsambles.Controls.Add(Me.CiGroupBox1)
        Me.pagEnsambles.Image = CType(resources.GetObject("pagEnsambles.Image"), System.Drawing.Image)
        Me.pagEnsambles.Location = New System.Drawing.Point(1, 41)
        Me.pagEnsambles.Name = "pagEnsambles"
        Me.pagEnsambles.Size = New System.Drawing.Size(779, 311)
        Me.pagEnsambles.TabIndex = 2
        Me.pagEnsambles.Text = "Ensambles"
        '
        'CiGroupBox1
        '
        Me.CiGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CiGroupBox1.Controls.Add(Me.grdEnsambles)
        Me.CiGroupBox1.Controls.Add(Me.CiToolBar1)
        Me.CiGroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.CiGroupBox1.Name = "CiGroupBox1"
        Me.CiGroupBox1.Size = New System.Drawing.Size(773, 269)
        Me.CiGroupBox1.TabIndex = 56
        Me.CiGroupBox1.TabStop = False
        '
        'grdEnsambles
        '
        Me.grdEnsambles.DataSource = Me.bsEnsambles
        Me.grdEnsambles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdEnsambles.FetchRowStyles = True
        Me.grdEnsambles.FilterBar = True
        Me.grdEnsambles.IDCatalogField = "IdEnsamble"
        Me.grdEnsambles.Images.Add(CType(resources.GetObject("grdEnsambles.Images"), System.Drawing.Image))
        Me.grdEnsambles.Location = New System.Drawing.Point(3, 55)
        Me.grdEnsambles.Name = "grdEnsambles"
        Me.grdEnsambles.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdEnsambles.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdEnsambles.PreviewInfo.ZoomFactor = 75.0R
        Me.grdEnsambles.PrintInfo.PageSettings = CType(resources.GetObject("grdEnsambles.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdEnsambles.Size = New System.Drawing.Size(767, 211)
        Me.grdEnsambles.TabIndex = 30
        Me.grdEnsambles.TabStop = False
        Me.grdEnsambles.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        Me.grdEnsambles.PropBag = resources.GetString("grdEnsambles.PropBag")
        '
        'CiToolBar1
        '
        Me.CiToolBar1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.CiToolBar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoEnsamble})
        Me.CiToolBar1.Location = New System.Drawing.Point(3, 16)
        Me.CiToolBar1.Name = "CiToolBar1"
        Me.CiToolBar1.Size = New System.Drawing.Size(767, 39)
        Me.CiToolBar1.TabIndex = 28
        Me.CiToolBar1.Text = "CiToolBar1"
        '
        'btnNuevoEnsamble
        '
        Me.btnNuevoEnsamble.Image = CType(resources.GetObject("btnNuevoEnsamble.Image"), System.Drawing.Image)
        Me.btnNuevoEnsamble.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevoEnsamble.Name = "btnNuevoEnsamble"
        Me.btnNuevoEnsamble.Size = New System.Drawing.Size(130, 36)
        Me.btnNuevoEnsamble.Text = "Incluir Ensamble"
        '
        'C1DockingTabPage1
        '
        Me.C1DockingTabPage1.Controls.Add(Me.txtObervaciones)
        Me.C1DockingTabPage1.Image = Global.Azteca.Windows.Produccion.My.Resources.Resources.comment_edit_32x32
        Me.C1DockingTabPage1.Location = New System.Drawing.Point(1, 41)
        Me.C1DockingTabPage1.Name = "C1DockingTabPage1"
        Me.C1DockingTabPage1.Size = New System.Drawing.Size(779, 311)
        Me.C1DockingTabPage1.TabIndex = 3
        Me.C1DockingTabPage1.Text = "Obervaciones"
        '
        'txtObervaciones
        '
        Me.txtObervaciones.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtObervaciones.Location = New System.Drawing.Point(17, 3)
        Me.txtObervaciones.MaxValue = New Decimal(New Integer() {256, 0, 0, 0})
        Me.txtObervaciones.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtObervaciones.Multiline = True
        Me.txtObervaciones.Name = "txtObervaciones"
        Me.txtObervaciones.Size = New System.Drawing.Size(756, 127)
        Me.txtObervaciones.TabIndex = 43
        '
        'btnImprimir
        '
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(23, 23)
        '
        'CiLabel5
        '
        Me.CiLabel5.AutoSize = True
        Me.CiLabel5.Location = New System.Drawing.Point(228, 211)
        Me.CiLabel5.Name = "CiLabel5"
        Me.CiLabel5.Size = New System.Drawing.Size(105, 13)
        Me.CiLabel5.TabIndex = 64
        Me.CiLabel5.Text = "Almacen de Insumos"
        '
        'CiLabel6
        '
        Me.CiLabel6.AutoSize = True
        Me.CiLabel6.Location = New System.Drawing.Point(253, 238)
        Me.CiLabel6.Name = "CiLabel6"
        Me.CiLabel6.Size = New System.Drawing.Size(80, 13)
        Me.CiLabel6.TabIndex = 66
        Me.CiLabel6.Text = "Almacen de PT"
        '
        'dtpFechaRecepcion
        '
        Me.dtpFechaRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaRecepcion.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaRecepcion.Location = New System.Drawing.Point(645, 126)
        Me.dtpFechaRecepcion.Name = "dtpFechaRecepcion"
        Me.dtpFechaRecepcion.Size = New System.Drawing.Size(139, 20)
        Me.dtpFechaRecepcion.TabIndex = 69
        '
        'CiLabel7
        '
        Me.CiLabel7.AutoSize = True
        Me.CiLabel7.Location = New System.Drawing.Point(544, 129)
        Me.CiLabel7.Name = "CiLabel7"
        Me.CiLabel7.Size = New System.Drawing.Size(92, 13)
        Me.CiLabel7.TabIndex = 68
        Me.CiLabel7.Text = "Fecha Recepción"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.BackgroundImage = Global.Azteca.Windows.Produccion.My.Resources.Resources.Print_16x16
        Me.cmdImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdImprimir.Location = New System.Drawing.Point(752, 59)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(32, 32)
        Me.cmdImprimir.TabIndex = 70
        Me.cmdImprimir.UseVisualStyleBackColor = True
        '
        'cmdClonar
        '
        Me.cmdClonar.BackgroundImage = Global.Azteca.Windows.Produccion.My.Resources.Resources.Clone_32x32
        Me.cmdClonar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdClonar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClonar.Location = New System.Drawing.Point(711, 60)
        Me.cmdClonar.Name = "cmdClonar"
        Me.cmdClonar.Size = New System.Drawing.Size(32, 32)
        Me.cmdClonar.TabIndex = 71
        Me.cmdClonar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdClonar.UseVisualStyleBackColor = True
        '
        'dtpFechaRequerida
        '
        Me.dtpFechaRequerida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaRequerida.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaRequerida.Location = New System.Drawing.Point(645, 178)
        Me.dtpFechaRequerida.Name = "dtpFechaRequerida"
        Me.dtpFechaRequerida.Size = New System.Drawing.Size(139, 20)
        Me.dtpFechaRequerida.TabIndex = 73
        '
        'CiLabel8
        '
        Me.CiLabel8.AutoSize = True
        Me.CiLabel8.Location = New System.Drawing.Point(547, 181)
        Me.CiLabel8.Name = "CiLabel8"
        Me.CiLabel8.Size = New System.Drawing.Size(89, 13)
        Me.CiLabel8.TabIndex = 72
        Me.CiLabel8.Text = "Fecha Requerida"
        '
        'CiLabel9
        '
        Me.CiLabel9.AutoSize = True
        Me.CiLabel9.Location = New System.Drawing.Point(9, 262)
        Me.CiLabel9.Name = "CiLabel9"
        Me.CiLabel9.Size = New System.Drawing.Size(91, 13)
        Me.CiLabel9.TabIndex = 74
        Me.CiLabel9.Text = "Cant. de Planillas:"
        '
        'txtCantPlanillas
        '
        Me.txtCantPlanillas.Digits = True
        Me.txtCantPlanillas.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCantPlanillas.Location = New System.Drawing.Point(121, 260)
        Me.txtCantPlanillas.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantPlanillas.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantPlanillas.Name = "txtCantPlanillas"
        Me.txtCantPlanillas.Size = New System.Drawing.Size(101, 20)
        Me.txtCantPlanillas.TabIndex = 75
        '
        'cboArea
        '
        Me.cboArea.FormattingEnabled = True
        Me.cboArea.Items.AddRange(New Object() {"Flexografía", "Offset"})
        Me.cboArea.Location = New System.Drawing.Point(339, 262)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(194, 21)
        Me.cboArea.TabIndex = 76
        '
        'CiLabel10
        '
        Me.CiLabel10.AutoSize = True
        Me.CiLabel10.Location = New System.Drawing.Point(301, 266)
        Me.CiLabel10.Name = "CiLabel10"
        Me.CiLabel10.Size = New System.Drawing.Size(32, 13)
        Me.CiLabel10.TabIndex = 77
        Me.CiLabel10.Text = "Area:"
        '
        'selCuenta
        '
        Me.selCuenta.AnySite = False
        Me.selCuenta.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selCuenta.EditorAssembly = "Azteca.ContabilidadWin"
        Me.selCuenta.EditorClass = "Azteca.Windows.Contabilidad.CuentaForm"
        Me.selCuenta.EditorTitle = "Editar Cuenta..."
        Me.selCuenta.Key = 0
        Me.selCuenta.Linked = False
        Me.selCuenta.Location = New System.Drawing.Point(121, 182)
        Me.selCuenta.Name = "selCuenta"
        Me.selCuenta.Size = New System.Drawing.Size(412, 23)
        Me.selCuenta.TabIndex = 45
        Me.selCuenta.TextWidth = 100
        '
        'gbTipoOrden
        '
        Me.gbTipoOrden.Controls.Add(Me.rdbTipoMaestroIng)
        Me.gbTipoOrden.Controls.Add(Me.rdbTipoOrdenTrabajo)
        Me.gbTipoOrden.Location = New System.Drawing.Point(121, 90)
        Me.gbTipoOrden.Name = "gbTipoOrden"
        Me.gbTipoOrden.Size = New System.Drawing.Size(420, 42)
        Me.gbTipoOrden.TabIndex = 78
        Me.gbTipoOrden.TabStop = False
        Me.gbTipoOrden.Text = "Tipo de Orden"
        '
        'rdbTipoMaestroIng
        '
        Me.rdbTipoMaestroIng.AutoSize = True
        Me.rdbTipoMaestroIng.Location = New System.Drawing.Point(250, 15)
        Me.rdbTipoMaestroIng.Name = "rdbTipoMaestroIng"
        Me.rdbTipoMaestroIng.Size = New System.Drawing.Size(127, 17)
        Me.rdbTipoMaestroIng.TabIndex = 1
        Me.rdbTipoMaestroIng.Text = "Maestro de Ingenieria"
        Me.rdbTipoMaestroIng.UseVisualStyleBackColor = True
        '
        'rdbTipoOrdenTrabajo
        '
        Me.rdbTipoOrdenTrabajo.AutoSize = True
        Me.rdbTipoOrdenTrabajo.Checked = True
        Me.rdbTipoOrdenTrabajo.Location = New System.Drawing.Point(110, 15)
        Me.rdbTipoOrdenTrabajo.Name = "rdbTipoOrdenTrabajo"
        Me.rdbTipoOrdenTrabajo.Size = New System.Drawing.Size(93, 17)
        Me.rdbTipoOrdenTrabajo.TabIndex = 0
        Me.rdbTipoOrdenTrabajo.TabStop = True
        Me.rdbTipoOrdenTrabajo.Text = "Orden Trabajo"
        Me.rdbTipoOrdenTrabajo.UseVisualStyleBackColor = True
        '
        'cboAlmacenPT
        '
        Me.cboAlmacenPT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacenPT.FormattingEnabled = True
        Me.cboAlmacenPT.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboAlmacenPT.ItemsTable = Nothing
        Me.cboAlmacenPT.Location = New System.Drawing.Point(339, 235)
        Me.cboAlmacenPT.Name = "cboAlmacenPT"
        Me.cboAlmacenPT.Size = New System.Drawing.Size(194, 21)
        Me.cboAlmacenPT.TabIndex = 67
        Me.cboAlmacenPT.UIName = Nothing
        '
        'cboAlmacenInsumos
        '
        Me.cboAlmacenInsumos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacenInsumos.FormattingEnabled = True
        Me.cboAlmacenInsumos.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboAlmacenInsumos.ItemsTable = Nothing
        Me.cboAlmacenInsumos.Location = New System.Drawing.Point(339, 208)
        Me.cboAlmacenInsumos.Name = "cboAlmacenInsumos"
        Me.cboAlmacenInsumos.Size = New System.Drawing.Size(194, 21)
        Me.cboAlmacenInsumos.TabIndex = 65
        Me.cboAlmacenInsumos.UIName = Nothing
        '
        'selArticuloStock
        '
        Me.selArticuloStock.AnySite = False
        Me.selArticuloStock.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selArticuloStock.EditorAssembly = "Azteca.InventarioWin"
        Me.selArticuloStock.EditorClass = "Azteca.Windows.Inventario.ArticulosStockForm"
        Me.selArticuloStock.EditorTitle = "Editar Articulos de inventario..."
        Me.selArticuloStock.Key = 0
        Me.selArticuloStock.Linked = False
        Me.selArticuloStock.Location = New System.Drawing.Point(121, 159)
        Me.selArticuloStock.Name = "selArticuloStock"
        Me.selArticuloStock.ShowEditButton = True
        Me.selArticuloStock.Size = New System.Drawing.Size(412, 23)
        Me.selArticuloStock.TabIndex = 43
        Me.selArticuloStock.TextWidth = 100
        '
        'OrdenesTrabajoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 682)
        Me.Controls.Add(Me.gbTipoOrden)
        Me.Controls.Add(Me.CiLabel10)
        Me.Controls.Add(Me.cboArea)
        Me.Controls.Add(Me.CiLabel9)
        Me.Controls.Add(Me.txtCantPlanillas)
        Me.Controls.Add(Me.dtpFechaRequerida)
        Me.Controls.Add(Me.CiLabel8)
        Me.Controls.Add(Me.cmdClonar)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.dtpFechaRecepcion)
        Me.Controls.Add(Me.CiLabel7)
        Me.Controls.Add(Me.cboAlmacenPT)
        Me.Controls.Add(Me.CiLabel6)
        Me.Controls.Add(Me.cboAlmacenInsumos)
        Me.Controls.Add(Me.CiLabel5)
        Me.Controls.Add(Me.tabAreas)
        Me.Controls.Add(Me.dtpFechaPromEntrega)
        Me.Controls.Add(Me.CiLabel4)
        Me.Controls.Add(Me.CiLabel3)
        Me.Controls.Add(Me.txtVersion)
        Me.Controls.Add(Me.CiLabel2)
        Me.Controls.Add(Me.txtFolioPedido)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.chkExigirRecepcion)
        Me.Controls.Add(Me.txtCantDeseada)
        Me.Controls.Add(Me.chkEntregasParciales)
        Me.Controls.Add(Me.lblCuenta)
        Me.Controls.Add(Me.selCuenta)
        Me.Controls.Add(Me.lblArticulo)
        Me.Controls.Add(Me.selArticuloStock)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.txtNombre)
        Me.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Name = "OrdenesTrabajoForm"
        Me.Text = "OrdenesTrabajoForm"
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.lblProducto, 0)
        Me.Controls.SetChildIndex(Me.selArticuloStock, 0)
        Me.Controls.SetChildIndex(Me.lblArticulo, 0)
        Me.Controls.SetChildIndex(Me.selCuenta, 0)
        Me.Controls.SetChildIndex(Me.lblCuenta, 0)
        Me.Controls.SetChildIndex(Me.chkEntregasParciales, 0)
        Me.Controls.SetChildIndex(Me.txtCantDeseada, 0)
        Me.Controls.SetChildIndex(Me.chkExigirRecepcion, 0)
        Me.Controls.SetChildIndex(Me.CiLabel1, 0)
        Me.Controls.SetChildIndex(Me.txtFolioPedido, 0)
        Me.Controls.SetChildIndex(Me.CiLabel2, 0)
        Me.Controls.SetChildIndex(Me.txtVersion, 0)
        Me.Controls.SetChildIndex(Me.CiLabel3, 0)
        Me.Controls.SetChildIndex(Me.CiLabel4, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaPromEntrega, 0)
        Me.Controls.SetChildIndex(Me.tabAreas, 0)
        Me.Controls.SetChildIndex(Me.CiLabel5, 0)
        Me.Controls.SetChildIndex(Me.cboAlmacenInsumos, 0)
        Me.Controls.SetChildIndex(Me.CiLabel6, 0)
        Me.Controls.SetChildIndex(Me.cboAlmacenPT, 0)
        Me.Controls.SetChildIndex(Me.CiLabel7, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaRecepcion, 0)
        Me.Controls.SetChildIndex(Me.cmdImprimir, 0)
        Me.Controls.SetChildIndex(Me.cmdClonar, 0)
        Me.Controls.SetChildIndex(Me.CiLabel8, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaRequerida, 0)
        Me.Controls.SetChildIndex(Me.txtCantPlanillas, 0)
        Me.Controls.SetChildIndex(Me.CiLabel9, 0)
        Me.Controls.SetChildIndex(Me.cboArea, 0)
        Me.Controls.SetChildIndex(Me.CiLabel10, 0)
        Me.Controls.SetChildIndex(Me.gbTipoOrden, 0)
        CType(Me.tabAreas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAreas.ResumeLayout(False)
        Me.pagInsumos.ResumeLayout(False)
        Me.gbxDetalle.ResumeLayout(False)
        Me.gbxDetalle.PerformLayout()
        CType(Me.grdInsumos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsInsumos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbMenu.ResumeLayout(False)
        Me.tbMenu.PerformLayout()
        Me.tabServicios.ResumeLayout(False)
        Me.CiGroupBox2.ResumeLayout(False)
        Me.CiGroupBox2.PerformLayout()
        CType(Me.grdServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuServicios.ResumeLayout(False)
        CType(Me.bsServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CiToolBar2.ResumeLayout(False)
        Me.CiToolBar2.PerformLayout()
        Me.pagEnsambles.ResumeLayout(False)
        Me.CiGroupBox1.ResumeLayout(False)
        Me.CiGroupBox1.PerformLayout()
        CType(Me.grdEnsambles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsEnsambles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CiToolBar1.ResumeLayout(False)
        Me.CiToolBar1.PerformLayout()
        Me.C1DockingTabPage1.ResumeLayout(False)
        Me.C1DockingTabPage1.PerformLayout()
        Me.gbTipoOrden.ResumeLayout(False)
        Me.gbTipoOrden.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Facade = New OrdenTrabajoFacade
        LicenseModule = Kernel.Licensing.LicenseModule.Manufacturing

    End Sub
    Friend WithEvents chkExigirRecepcion As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents chkEntregasParciales As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents lblCuenta As Azteca.Windows.Controls.CILabel
    Friend WithEvents selCuenta As Azteca.Windows.Contabilidad.CuentaSelector
    Friend WithEvents lblArticulo As Azteca.Windows.Controls.CILabel
    Friend WithEvents selArticuloStock As Azteca.Windows.Inventario.ArticuloStockSelector
    Friend WithEvents lblProducto As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCantDeseada As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtFolioPedido As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtVersion As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
    Friend WithEvents dtpFechaPromEntrega As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents bsInsumos As System.Windows.Forms.BindingSource
    Friend WithEvents tabAreas As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagInsumos As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents gbxDetalle As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents tbMenu As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnNuevoArt As System.Windows.Forms.ToolStripButton
    'vick
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents pagEnsambles As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents CiGroupBox1 As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents CiToolBar1 As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnNuevoEnsamble As System.Windows.Forms.ToolStripButton
    Friend WithEvents bsEnsambles As System.Windows.Forms.BindingSource
    Friend WithEvents grdInsumos As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents grdEnsambles As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents CiLabel5 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboAlmacenInsumos As Azteca.Windows.Inventario.AlmacenesComboBox
    Friend WithEvents cboAlmacenPT As Azteca.Windows.Inventario.AlmacenesComboBox
    Friend WithEvents CiLabel6 As Azteca.Windows.Controls.CILabel
    Friend WithEvents dtpFechaRecepcion As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents CiLabel7 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cmdImprimir As System.Windows.Forms.Button
    Friend WithEvents cmdClonar As System.Windows.Forms.Button
    Friend WithEvents C1DockingTabPage1 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents txtObervaciones As Azteca.Windows.Controls.CITextBox
    Friend WithEvents dtpFechaRequerida As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents CiLabel8 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel9 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCantPlanillas As Azteca.Windows.Controls.CITextBox
    Friend WithEvents cboArea As System.Windows.Forms.ComboBox
    Friend WithEvents CiLabel10 As Azteca.Windows.Controls.CILabel
    Friend WithEvents gbTipoOrden As System.Windows.Forms.GroupBox
    Friend WithEvents rdbTipoMaestroIng As System.Windows.Forms.RadioButton
    Friend WithEvents rdbTipoOrdenTrabajo As System.Windows.Forms.RadioButton
    Friend WithEvents tabServicios As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents CiGroupBox2 As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents CiToolBar2 As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnNuevoServicio As System.Windows.Forms.ToolStripButton
    Friend WithEvents bsServicios As System.Windows.Forms.BindingSource
    Friend WithEvents grdServicios As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents mnuServicios As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
