<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CED_MestroIngForm
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

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New MaestroIngFacade
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CED_MestroIngForm))
        Me.AzDockingTab1 = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagInsumos = New C1.Win.C1Command.C1DockingTabPage()
        Me.gbxDetalle = New Azteca.Windows.Controls.CIGroupBox()
        Me.grdInsumos = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsInsumos = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbMenu = New Azteca.Windows.Controls.CIToolBar()
        Me.tlbAgregarArticulo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.tabAreas = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagEnsambles = New C1.Win.C1Command.C1DockingTabPage()
        Me.CiGroupBox1 = New Azteca.Windows.Controls.CIGroupBox()
        Me.grdEnsambles = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsEnsambles = New System.Windows.Forms.BindingSource(Me.components)
        Me.CiToolBar1 = New Azteca.Windows.Controls.CIToolBar()
        Me.tlbAgregarEnsamble = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblProducto = New Azteca.Windows.Controls.CILabel()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.txtVersion = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.txtCantDeseada = New Azteca.Windows.Controls.CITextBox()
        Me.lblArticulo = New Azteca.Windows.Controls.CILabel()
        Me.selArticuloStock = New Azteca.Windows.Inventario.ArticuloStockSelector()
        Me.EmpleadoSelector1 = New Azteca.Windows.RH.EmpleadoSelector()
        CType(Me.AzDockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AzDockingTab1.SuspendLayout()
        Me.pagInsumos.SuspendLayout()
        Me.gbxDetalle.SuspendLayout()
        CType(Me.grdInsumos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsInsumos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbMenu.SuspendLayout()
        CType(Me.tabAreas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAreas.SuspendLayout()
        Me.pagEnsambles.SuspendLayout()
        Me.CiGroupBox1.SuspendLayout()
        CType(Me.grdEnsambles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsEnsambles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CiToolBar1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'AzDockingTab1
        '
        Me.AzDockingTab1.Controls.Add(Me.pagInsumos)
        Me.AzDockingTab1.Location = New System.Drawing.Point(2, 431)
        Me.AzDockingTab1.Name = "AzDockingTab1"
        Me.AzDockingTab1.Size = New System.Drawing.Size(945, 293)
        Me.AzDockingTab1.TabIndex = 64
        Me.AzDockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.AzDockingTab1.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.AzDockingTab1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagInsumos
        '
        Me.pagInsumos.Controls.Add(Me.gbxDetalle)
        Me.pagInsumos.Image = CType(resources.GetObject("pagInsumos.Image"), System.Drawing.Image)
        Me.pagInsumos.Location = New System.Drawing.Point(1, 41)
        Me.pagInsumos.Name = "pagInsumos"
        Me.pagInsumos.Size = New System.Drawing.Size(943, 251)
        Me.pagInsumos.TabIndex = 0
        Me.pagInsumos.Text = "Insumos"
        '
        'gbxDetalle
        '
        Me.gbxDetalle.Controls.Add(Me.grdInsumos)
        Me.gbxDetalle.Controls.Add(Me.tbMenu)
        Me.gbxDetalle.Location = New System.Drawing.Point(3, 3)
        Me.gbxDetalle.Name = "gbxDetalle"
        Me.gbxDetalle.Size = New System.Drawing.Size(937, 237)
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
        Me.grdInsumos.Location = New System.Drawing.Point(3, 45)
        Me.grdInsumos.Name = "grdInsumos"
        Me.grdInsumos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdInsumos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdInsumos.PreviewInfo.ZoomFactor = 75.0R
        Me.grdInsumos.PrintInfo.PageSettings = CType(resources.GetObject("grdInsumos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdInsumos.Size = New System.Drawing.Size(931, 189)
        Me.grdInsumos.TabIndex = 29
        Me.grdInsumos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdInsumos.PropBag = resources.GetString("grdInsumos.PropBag")
        '
        'tbMenu
        '
        Me.tbMenu.ImageScalingSize = New System.Drawing.Size(22, 22)
        Me.tbMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlbAgregarArticulo, Me.ToolStripButton6})
        Me.tbMenu.Location = New System.Drawing.Point(3, 16)
        Me.tbMenu.Name = "tbMenu"
        Me.tbMenu.Size = New System.Drawing.Size(931, 29)
        Me.tbMenu.TabIndex = 28
        Me.tbMenu.Text = "CiToolBar1"
        '
        'tlbAgregarArticulo
        '
        Me.tlbAgregarArticulo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlbAgregarArticulo.Image = Global.Azteca.Windows.Produccion.My.Resources.Resources.add_32x32
        Me.tlbAgregarArticulo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbAgregarArticulo.Name = "tlbAgregarArticulo"
        Me.tlbAgregarArticulo.Size = New System.Drawing.Size(26, 26)
        Me.tlbAgregarArticulo.Text = "ToolStripButton5"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = Global.Azteca.Windows.Produccion.My.Resources.Resources.delete_32x32
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(26, 26)
        Me.ToolStripButton6.Text = "ToolStripButton6"
        '
        'tabAreas
        '
        Me.tabAreas.Controls.Add(Me.pagEnsambles)
        Me.tabAreas.Location = New System.Drawing.Point(1, 193)
        Me.tabAreas.Name = "tabAreas"
        Me.tabAreas.Size = New System.Drawing.Size(945, 232)
        Me.tabAreas.TabIndex = 65
        Me.tabAreas.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabAreas.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabAreas.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagEnsambles
        '
        Me.pagEnsambles.Controls.Add(Me.CiGroupBox1)
        Me.pagEnsambles.Image = CType(resources.GetObject("pagEnsambles.Image"), System.Drawing.Image)
        Me.pagEnsambles.Location = New System.Drawing.Point(1, 41)
        Me.pagEnsambles.Name = "pagEnsambles"
        Me.pagEnsambles.Size = New System.Drawing.Size(943, 190)
        Me.pagEnsambles.TabIndex = 1
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
        Me.CiGroupBox1.Size = New System.Drawing.Size(937, 184)
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
        Me.grdEnsambles.Location = New System.Drawing.Point(3, 45)
        Me.grdEnsambles.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.grdEnsambles.Name = "grdEnsambles"
        Me.grdEnsambles.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdEnsambles.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdEnsambles.PreviewInfo.ZoomFactor = 75.0R
        Me.grdEnsambles.PrintInfo.PageSettings = CType(resources.GetObject("grdEnsambles.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdEnsambles.Size = New System.Drawing.Size(931, 136)
        Me.grdEnsambles.TabIndex = 30
        Me.grdEnsambles.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdEnsambles.PropBag = resources.GetString("grdEnsambles.PropBag")
        '
        'CiToolBar1
        '
        Me.CiToolBar1.ImageScalingSize = New System.Drawing.Size(22, 22)
        Me.CiToolBar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlbAgregarEnsamble, Me.ToolStripButton8})
        Me.CiToolBar1.Location = New System.Drawing.Point(3, 16)
        Me.CiToolBar1.Name = "CiToolBar1"
        Me.CiToolBar1.Size = New System.Drawing.Size(931, 29)
        Me.CiToolBar1.TabIndex = 28
        Me.CiToolBar1.Text = "CiToolBar1"
        '
        'tlbAgregarEnsamble
        '
        Me.tlbAgregarEnsamble.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlbAgregarEnsamble.Image = Global.Azteca.Windows.Produccion.My.Resources.Resources.add_32x32
        Me.tlbAgregarEnsamble.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbAgregarEnsamble.Name = "tlbAgregarEnsamble"
        Me.tlbAgregarEnsamble.Size = New System.Drawing.Size(26, 26)
        Me.tlbAgregarEnsamble.Text = "ToolStripButton7"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = Global.Azteca.Windows.Produccion.My.Resources.Resources.delete_32x32
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(26, 26)
        Me.ToolStripButton8.Text = "ToolStripButton8"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.EmpleadoSelector1)
        Me.Panel3.Controls.Add(Me.lblProducto)
        Me.Panel3.Controls.Add(Me.txtNombre)
        Me.Panel3.Controls.Add(Me.CiLabel3)
        Me.Panel3.Controls.Add(Me.txtVersion)
        Me.Panel3.Controls.Add(Me.CiLabel1)
        Me.Panel3.Controls.Add(Me.txtCantDeseada)
        Me.Panel3.Controls.Add(Me.lblArticulo)
        Me.Panel3.Controls.Add(Me.selArticuloStock)
        Me.Panel3.Location = New System.Drawing.Point(1, 90)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(945, 97)
        Me.Panel3.TabIndex = 65
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(17, 20)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(66, 13)
        Me.lblProducto.TabIndex = 65
        Me.lblProducto.Text = "Descripción:"
        '
        'txtNombre
        '
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(98, 20)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(412, 20)
        Me.txtNombre.TabIndex = 66
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(630, 59)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(42, 13)
        Me.CiLabel3.TabIndex = 63
        Me.CiLabel3.Text = "Versión"
        '
        'txtVersion
        '
        Me.txtVersion.Digits = True
        Me.txtVersion.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtVersion.Location = New System.Drawing.Point(678, 56)
        Me.txtVersion.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtVersion.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(125, 20)
        Me.txtVersion.TabIndex = 64
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(620, 20)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(52, 13)
        Me.CiLabel1.TabIndex = 61
        Me.CiLabel1.Text = "Cantidad:"
        '
        'txtCantDeseada
        '
        Me.txtCantDeseada.Digits = True
        Me.txtCantDeseada.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtCantDeseada.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCantDeseada.Location = New System.Drawing.Point(678, 17)
        Me.txtCantDeseada.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantDeseada.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantDeseada.Name = "txtCantDeseada"
        Me.txtCantDeseada.RequiredField = True
        Me.txtCantDeseada.Size = New System.Drawing.Size(125, 20)
        Me.txtCantDeseada.TabIndex = 62
        '
        'lblArticulo
        '
        Me.lblArticulo.AutoSize = True
        Me.lblArticulo.Location = New System.Drawing.Point(38, 53)
        Me.lblArticulo.Name = "lblArticulo"
        Me.lblArticulo.Size = New System.Drawing.Size(45, 13)
        Me.lblArticulo.TabIndex = 60
        Me.lblArticulo.Text = "Articulo:"
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
        Me.selArticuloStock.Location = New System.Drawing.Point(98, 53)
        Me.selArticuloStock.Name = "selArticuloStock"
        Me.selArticuloStock.ShowEditButton = True
        Me.selArticuloStock.Size = New System.Drawing.Size(412, 23)
        Me.selArticuloStock.TabIndex = 59
        Me.selArticuloStock.TextWidth = 100
        '
        'EmpleadoSelector1
        '
        Me.EmpleadoSelector1.AnySite = False
        Me.EmpleadoSelector1.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.EmpleadoSelector1.EditorAssembly = "Azteca.RHWin"
        Me.EmpleadoSelector1.EditorClass = "Azteca.Windows.RH.EmpleadosForm"
        Me.EmpleadoSelector1.EditorTitle = "Editar datos de articulo..."
        Me.EmpleadoSelector1.Key = 0
        Me.EmpleadoSelector1.Linked = False
        Me.EmpleadoSelector1.Location = New System.Drawing.Point(250, 74)
        Me.EmpleadoSelector1.Name = "EmpleadoSelector1"
        Me.EmpleadoSelector1.Size = New System.Drawing.Size(231, 23)
        Me.EmpleadoSelector1.TabIndex = 67
        '
        'CED_MestroIngForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 720)
        Me.Controls.Add(Me.AzDockingTab1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.tabAreas)
        Me.Name = "CED_MestroIngForm"
        Me.Text = "CED_MestroIngForm"
        Me.Controls.SetChildIndex(Me.tabAreas, 0)
        Me.Controls.SetChildIndex(Me.Panel3, 0)
        Me.Controls.SetChildIndex(Me.AzDockingTab1, 0)
        CType(Me.AzDockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AzDockingTab1.ResumeLayout(False)
        Me.pagInsumos.ResumeLayout(False)
        Me.gbxDetalle.ResumeLayout(False)
        Me.gbxDetalle.PerformLayout()
        CType(Me.grdInsumos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsInsumos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbMenu.ResumeLayout(False)
        Me.tbMenu.PerformLayout()
        CType(Me.tabAreas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAreas.ResumeLayout(False)
        Me.pagEnsambles.ResumeLayout(False)
        Me.CiGroupBox1.ResumeLayout(False)
        Me.CiGroupBox1.PerformLayout()
        CType(Me.grdEnsambles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsEnsambles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CiToolBar1.ResumeLayout(False)
        Me.CiToolBar1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AzDockingTab1 As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagInsumos As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents gbxDetalle As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents grdInsumos As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents tbMenu As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents tlbAgregarArticulo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tabAreas As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagEnsambles As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents CiGroupBox1 As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents grdEnsambles As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents CiToolBar1 As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents tlbAgregarEnsamble As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtVersion As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCantDeseada As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblArticulo As Azteca.Windows.Controls.CILabel
    Friend WithEvents selArticuloStock As Azteca.Windows.Inventario.ArticuloStockSelector
    Friend WithEvents lblProducto As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents bsEnsambles As System.Windows.Forms.BindingSource
    Friend WithEvents bsInsumos As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadoSelector1 As Azteca.Windows.RH.EmpleadoSelector
End Class
