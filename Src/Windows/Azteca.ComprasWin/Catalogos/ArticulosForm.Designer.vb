<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArticulosForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ArticulosForm))
        Dim Style1 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style2 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style3 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style4 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style5 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style6 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style7 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style8 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style9 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style10 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style11 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style12 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style13 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style14 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style15 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style16 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Me.bsAlmacenes = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsDatosInv = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsClasificaciones = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsGruposClasif = New System.Windows.Forms.BindingSource(Me.components)
        Me.imlArticulo = New System.Windows.Forms.ImageList(Me.components)
        Me.CiLabel8 = New Azteca.Windows.Controls.CILabel()
        Me.txtDescr = New Azteca.Windows.Controls.CITextBox()
        Me.txtEAN = New Azteca.Windows.Controls.CITextBox()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.grpStockAlm = New Azteca.Windows.Controls.CIGroupBox()
        Me.cboAlmacen = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.grdDatosInv = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.grpStockGeneral = New Azteca.Windows.Controls.CIGroupBox()
        Me.nudStockMax = New Azteca.Windows.Controls.CINumericUpDown()
        Me.nudPuntoReorden = New Azteca.Windows.Controls.CINumericUpDown()
        Me.CiLabel5 = New Azteca.Windows.Controls.CILabel()
        Me.nudStockMin = New Azteca.Windows.Controls.CINumericUpDown()
        Me.CiLabel6 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel7 = New Azteca.Windows.Controls.CILabel()
        Me.cboClasificaciones = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.grdClasificaciones = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.AzToolBar1 = New Azteca.Windows.Controls.AZToolBar()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdProveedores = New C1.Win.C1Command.C1Command()
        Me.btnProveedores = New C1.Win.C1Command.C1CommandLink()
        Me.grdZonas = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsZonas = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabArticulos = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagGeneral = New C1.Win.C1Command.C1DockingTabPage()
        Me.txtCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.cboTipoUnidad = New Azteca.Windows.Inventario.TiposUnidadComboBox()
        Me.cboUnidadMedida = New Azteca.Windows.Inventario.UnidadesMedidaComboBox()
        Me.pagStock = New C1.Win.C1Command.C1DockingTabPage()
        Me.pagClasificaciones = New C1.Win.C1Command.C1DockingTabPage()
        Me.pagZonas = New C1.Win.C1Command.C1DockingTabPage()
        Me.pagCategorias = New C1.Win.C1Command.C1DockingTabPage()
        CType(Me.bsAlmacenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDatosInv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsClasificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsGruposClasif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpStockAlm.SuspendLayout()
        CType(Me.cboAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDatosInv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpStockGeneral.SuspendLayout()
        CType(Me.nudStockMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPuntoReorden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStockMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboClasificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdClasificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdZonas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsZonas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabArticulos.SuspendLayout()
        Me.pagGeneral.SuspendLayout()
        Me.pagStock.SuspendLayout()
        Me.pagClasificaciones.SuspendLayout()
        Me.pagZonas.SuspendLayout()
        Me.SuspendLayout()
        '
        'bsAlmacenes
        '
        Me.bsAlmacenes.AllowNew = False
        '
        'imlArticulo
        '
        Me.imlArticulo.ImageStream = CType(resources.GetObject("imlArticulo.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlArticulo.TransparentColor = System.Drawing.Color.Transparent
        Me.imlArticulo.Images.SetKeyName(0, "General")
        Me.imlArticulo.Images.SetKeyName(1, "Inventario")
        Me.imlArticulo.Images.SetKeyName(2, "Clasificaciones")
        Me.imlArticulo.Images.SetKeyName(3, "Zonas")
        Me.imlArticulo.Images.SetKeyName(4, "Categorias")
        '
        'CiLabel8
        '
        Me.CiLabel8.AutoSize = True
        Me.CiLabel8.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel8.Location = New System.Drawing.Point(14, 94)
        Me.CiLabel8.Name = "CiLabel8"
        Me.CiLabel8.Size = New System.Drawing.Size(44, 13)
        Me.CiLabel8.TabIndex = 8
        Me.CiLabel8.Text = "Cuenta:"
        '
        'txtDescr
        '
        Me.txtDescr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescr.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtDescr.Location = New System.Drawing.Point(129, 118)
        Me.txtDescr.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDescr.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDescr.Multiline = True
        Me.txtDescr.Name = "txtDescr"
        Me.txtDescr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescr.Size = New System.Drawing.Size(466, 194)
        Me.txtDescr.TabIndex = 11
        '
        'txtEAN
        '
        Me.txtEAN.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtEAN.Location = New System.Drawing.Point(129, 63)
        Me.txtEAN.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtEAN.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtEAN.Name = "txtEAN"
        Me.txtEAN.Size = New System.Drawing.Size(165, 20)
        Me.txtEAN.TabIndex = 6
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(129, 9)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(297, 20)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.UIName = "Nombre"
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel4.Location = New System.Drawing.Point(14, 67)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(32, 13)
        Me.CiLabel4.TabIndex = 5
        Me.CiLabel4.Text = "EAN:"
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel3.Location = New System.Drawing.Point(14, 39)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(109, 13)
        Me.CiLabel3.TabIndex = 2
        Me.CiLabel3.Text = "Unidad de Inventario:"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel2.Location = New System.Drawing.Point(14, 119)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(66, 13)
        Me.CiLabel2.TabIndex = 10
        Me.CiLabel2.Text = "Descripción:"
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel1.Location = New System.Drawing.Point(14, 13)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(47, 13)
        Me.CiLabel1.TabIndex = 0
        Me.CiLabel1.Text = "Nombre:"
        '
        'grpStockAlm
        '
        Me.grpStockAlm.BackColor = System.Drawing.Color.Transparent
        Me.grpStockAlm.Controls.Add(Me.cboAlmacen)
        Me.grpStockAlm.Controls.Add(Me.grdDatosInv)
        Me.grpStockAlm.Location = New System.Drawing.Point(13, 121)
        Me.grpStockAlm.Name = "grpStockAlm"
        Me.grpStockAlm.Size = New System.Drawing.Size(526, 158)
        Me.grpStockAlm.TabIndex = 7
        Me.grpStockAlm.TabStop = False
        Me.grpStockAlm.Text = "Valores por Almacén"
        '
        'cboAlmacen
        '
        Me.cboAlmacen.AllowColMove = True
        Me.cboAlmacen.AllowColSelect = True
        Me.cboAlmacen.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboAlmacen.AlternatingRows = False
        Me.cboAlmacen.CaptionStyle = Style1
        Me.cboAlmacen.ColumnCaptionHeight = 17
        Me.cboAlmacen.ColumnFooterHeight = 17
        Me.cboAlmacen.DataSource = Me.bsAlmacenes
        Me.cboAlmacen.DisplayMember = "Nombre"
        Me.cboAlmacen.EvenRowStyle = Style2
        Me.cboAlmacen.ExtendRightColumn = True
        Me.cboAlmacen.FetchRowStyles = False
        Me.cboAlmacen.FooterStyle = Style3
        Me.cboAlmacen.HeadingStyle = Style4
        Me.cboAlmacen.HighLightRowStyle = Style5
        Me.cboAlmacen.Images.Add(CType(resources.GetObject("cboAlmacen.Images"), System.Drawing.Image))
        Me.cboAlmacen.Location = New System.Drawing.Point(162, 48)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.OddRowStyle = Style6
        Me.cboAlmacen.RecordSelectorStyle = Style7
        Me.cboAlmacen.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboAlmacen.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboAlmacen.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboAlmacen.ScrollTips = False
        Me.cboAlmacen.Size = New System.Drawing.Size(305, 149)
        Me.cboAlmacen.Style = Style8
        Me.cboAlmacen.TabIndex = 19
        Me.cboAlmacen.TabStop = False
        Me.cboAlmacen.Text = "C1TrueDBDropdown1"
        Me.cboAlmacen.ValueMember = "IdAlmacen"
        Me.cboAlmacen.ValueTranslate = True
        Me.cboAlmacen.Visible = False
        Me.cboAlmacen.PropBag = resources.GetString("cboAlmacen.PropBag")
        '
        'grdDatosInv
        '
        Me.grdDatosInv.AllowAddNew = True
        Me.grdDatosInv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDatosInv.DataSource = Me.bsDatosInv
        Me.grdDatosInv.Images.Add(CType(resources.GetObject("grdDatosInv.Images"), System.Drawing.Image))
        Me.grdDatosInv.Location = New System.Drawing.Point(6, 19)
        Me.grdDatosInv.Name = "grdDatosInv"
        Me.grdDatosInv.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdDatosInv.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdDatosInv.PreviewInfo.ZoomFactor = 75.0R
        Me.grdDatosInv.PrintInfo.PageSettings = CType(resources.GetObject("grdDatosInv.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdDatosInv.Size = New System.Drawing.Size(495, 133)
        Me.grdDatosInv.TabIndex = 0
        Me.grdDatosInv.Text = "AzTrueDBGrid1"
        Me.grdDatosInv.PropBag = resources.GetString("grdDatosInv.PropBag")
        '
        'grpStockGeneral
        '
        Me.grpStockGeneral.BackColor = System.Drawing.Color.Transparent
        Me.grpStockGeneral.Controls.Add(Me.nudStockMax)
        Me.grpStockGeneral.Controls.Add(Me.nudPuntoReorden)
        Me.grpStockGeneral.Controls.Add(Me.CiLabel5)
        Me.grpStockGeneral.Controls.Add(Me.nudStockMin)
        Me.grpStockGeneral.Controls.Add(Me.CiLabel6)
        Me.grpStockGeneral.Controls.Add(Me.CiLabel7)
        Me.grpStockGeneral.Location = New System.Drawing.Point(13, 13)
        Me.grpStockGeneral.Name = "grpStockGeneral"
        Me.grpStockGeneral.Size = New System.Drawing.Size(526, 101)
        Me.grpStockGeneral.TabIndex = 6
        Me.grpStockGeneral.TabStop = False
        Me.grpStockGeneral.Text = "Generales"
        '
        'nudStockMax
        '
        Me.nudStockMax.HighlightColor = System.Drawing.SystemColors.Info
        Me.nudStockMax.Location = New System.Drawing.Point(123, 19)
        Me.nudStockMax.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudStockMax.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudStockMax.Name = "nudStockMax"
        Me.nudStockMax.Size = New System.Drawing.Size(75, 20)
        Me.nudStockMax.TabIndex = 1
        Me.nudStockMax.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudPuntoReorden
        '
        Me.nudPuntoReorden.HighlightColor = System.Drawing.SystemColors.Info
        Me.nudPuntoReorden.Location = New System.Drawing.Point(123, 71)
        Me.nudPuntoReorden.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudPuntoReorden.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPuntoReorden.Name = "nudPuntoReorden"
        Me.nudPuntoReorden.Size = New System.Drawing.Size(75, 20)
        Me.nudPuntoReorden.TabIndex = 5
        Me.nudPuntoReorden.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'CiLabel5
        '
        Me.CiLabel5.AutoSize = True
        Me.CiLabel5.Location = New System.Drawing.Point(20, 19)
        Me.CiLabel5.Name = "CiLabel5"
        Me.CiLabel5.Size = New System.Drawing.Size(77, 13)
        Me.CiLabel5.TabIndex = 0
        Me.CiLabel5.Text = "Stock Máximo:"
        '
        'nudStockMin
        '
        Me.nudStockMin.HighlightColor = System.Drawing.SystemColors.Info
        Me.nudStockMin.Location = New System.Drawing.Point(123, 45)
        Me.nudStockMin.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudStockMin.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudStockMin.Name = "nudStockMin"
        Me.nudStockMin.Size = New System.Drawing.Size(75, 20)
        Me.nudStockMin.TabIndex = 3
        Me.nudStockMin.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'CiLabel6
        '
        Me.CiLabel6.AutoSize = True
        Me.CiLabel6.Location = New System.Drawing.Point(20, 45)
        Me.CiLabel6.Name = "CiLabel6"
        Me.CiLabel6.Size = New System.Drawing.Size(76, 13)
        Me.CiLabel6.TabIndex = 2
        Me.CiLabel6.Text = "Stock Mínimo:"
        '
        'CiLabel7
        '
        Me.CiLabel7.AutoSize = True
        Me.CiLabel7.Location = New System.Drawing.Point(20, 71)
        Me.CiLabel7.Name = "CiLabel7"
        Me.CiLabel7.Size = New System.Drawing.Size(97, 13)
        Me.CiLabel7.TabIndex = 4
        Me.CiLabel7.Text = "Punto de Reorden:"
        '
        'cboClasificaciones
        '
        Me.cboClasificaciones.AllowColMove = True
        Me.cboClasificaciones.AllowColSelect = True
        Me.cboClasificaciones.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboClasificaciones.AlternatingRows = False
        Me.cboClasificaciones.CaptionStyle = Style9
        Me.cboClasificaciones.ColumnCaptionHeight = 17
        Me.cboClasificaciones.ColumnFooterHeight = 17
        Me.cboClasificaciones.DataSource = Me.bsClasificaciones
        Me.cboClasificaciones.DisplayMember = "Nombre"
        Me.cboClasificaciones.EvenRowStyle = Style10
        Me.cboClasificaciones.ExtendRightColumn = True
        Me.cboClasificaciones.FetchRowStyles = False
        Me.cboClasificaciones.FooterStyle = Style11
        Me.cboClasificaciones.HeadingStyle = Style12
        Me.cboClasificaciones.HighLightRowStyle = Style13
        Me.cboClasificaciones.Images.Add(CType(resources.GetObject("cboClasificaciones.Images"), System.Drawing.Image))
        Me.cboClasificaciones.Location = New System.Drawing.Point(87, 60)
        Me.cboClasificaciones.Name = "cboClasificaciones"
        Me.cboClasificaciones.OddRowStyle = Style14
        Me.cboClasificaciones.RecordSelectorStyle = Style15
        Me.cboClasificaciones.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboClasificaciones.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboClasificaciones.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboClasificaciones.ScrollTips = False
        Me.cboClasificaciones.Size = New System.Drawing.Size(294, 199)
        Me.cboClasificaciones.Style = Style16
        Me.cboClasificaciones.TabIndex = 1
        Me.cboClasificaciones.TabStop = False
        Me.cboClasificaciones.Text = "C1TrueDBDropdown1"
        Me.cboClasificaciones.ValueMember = "IdClasificacion"
        Me.cboClasificaciones.Visible = False
        Me.cboClasificaciones.PropBag = resources.GetString("cboClasificaciones.PropBag")
        '
        'grdClasificaciones
        '
        Me.grdClasificaciones.DataSource = Me.bsGruposClasif
        Me.grdClasificaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdClasificaciones.ExtendRightColumn = True
        Me.grdClasificaciones.FetchRowStyles = True
        Me.grdClasificaciones.Images.Add(CType(resources.GetObject("grdClasificaciones.Images"), System.Drawing.Image))
        Me.grdClasificaciones.Location = New System.Drawing.Point(0, 0)
        Me.grdClasificaciones.Name = "grdClasificaciones"
        Me.grdClasificaciones.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdClasificaciones.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdClasificaciones.PreviewInfo.ZoomFactor = 75.0R
        Me.grdClasificaciones.PrintInfo.PageSettings = CType(resources.GetObject("grdClasificaciones.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdClasificaciones.Size = New System.Drawing.Size(695, 341)
        Me.grdClasificaciones.TabIndex = 0
        Me.grdClasificaciones.Text = "AzTrueDBGrid1"
        Me.grdClasificaciones.PropBag = resources.GetString("grdClasificaciones.PropBag")
        '
        'AzToolBar1
        '
        Me.AzToolBar1.AccessibleName = "Tool Bar"
        Me.AzToolBar1.AutoSize = False
        Me.AzToolBar1.CommandHolder = Me.C1CommandHolder1
        Me.AzToolBar1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.btnProveedores})
        Me.AzToolBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.AzToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.AzToolBar1.MinButtonSize = 32
        Me.AzToolBar1.Movable = False
        Me.AzToolBar1.Name = "AzToolBar1"
        Me.AzToolBar1.Size = New System.Drawing.Size(695, 33)
        Me.AzToolBar1.Text = "AzToolBar1"
        Me.AzToolBar1.VisualStyle = C1.Win.C1Command.VisualStyle.Office2003Blue
        Me.AzToolBar1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2003Blue
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdProveedores)
        Me.C1CommandHolder1.Owner = Me
        '
        'cmdProveedores
        '
        Me.cmdProveedores.Image = CType(resources.GetObject("cmdProveedores.Image"), System.Drawing.Image)
        Me.cmdProveedores.Name = "cmdProveedores"
        Me.cmdProveedores.ShortcutText = ""
        Me.cmdProveedores.Text = "Proveedores"
        '
        'btnProveedores
        '
        Me.btnProveedores.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnProveedores.Command = Me.cmdProveedores
        Me.btnProveedores.ToolTipText = "Administrar proveedores de éste artículo"
        '
        'grdZonas
        '
        Me.grdZonas.AllowUpdate = False
        Me.grdZonas.DataSource = Me.bsZonas
        Me.grdZonas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdZonas.ExtendRightColumn = True
        Me.grdZonas.Images.Add(CType(resources.GetObject("grdZonas.Images"), System.Drawing.Image))
        Me.grdZonas.Location = New System.Drawing.Point(0, 33)
        Me.grdZonas.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.grdZonas.Name = "grdZonas"
        Me.grdZonas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdZonas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdZonas.PreviewInfo.ZoomFactor = 75.0R
        Me.grdZonas.PrintInfo.PageSettings = CType(resources.GetObject("grdZonas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdZonas.Size = New System.Drawing.Size(695, 308)
        Me.grdZonas.TabIndex = 2
        Me.grdZonas.Text = "AzTrueDBGrid1"
        Me.grdZonas.PropBag = resources.GetString("grdZonas.PropBag")
        '
        'tabArticulos
        '
        Me.tabArticulos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabArticulos.Controls.Add(Me.pagGeneral)
        Me.tabArticulos.Controls.Add(Me.pagStock)
        Me.tabArticulos.Controls.Add(Me.pagClasificaciones)
        Me.tabArticulos.Controls.Add(Me.pagZonas)
        Me.tabArticulos.Controls.Add(Me.pagCategorias)
        Me.tabArticulos.ImageList = Me.imlArticulo
        Me.tabArticulos.Location = New System.Drawing.Point(10, 90)
        Me.tabArticulos.Name = "tabArticulos"
        Me.tabArticulos.SelectedIndex = 4
        Me.tabArticulos.Size = New System.Drawing.Size(697, 383)
        Me.tabArticulos.TabIndex = 12
        Me.tabArticulos.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2003
        Me.tabArticulos.VisualStyle = C1.Win.C1Command.VisualStyle.Office2003Blue
        Me.tabArticulos.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2003Blue
        '
        'pagGeneral
        '
        Me.pagGeneral.Controls.Add(Me.txtCuenta)
        Me.pagGeneral.Controls.Add(Me.CiLabel1)
        Me.pagGeneral.Controls.Add(Me.CiLabel8)
        Me.pagGeneral.Controls.Add(Me.CiLabel2)
        Me.pagGeneral.Controls.Add(Me.CiLabel3)
        Me.pagGeneral.Controls.Add(Me.CiLabel4)
        Me.pagGeneral.Controls.Add(Me.txtDescr)
        Me.pagGeneral.Controls.Add(Me.txtNombre)
        Me.pagGeneral.Controls.Add(Me.txtEAN)
        Me.pagGeneral.Controls.Add(Me.cboTipoUnidad)
        Me.pagGeneral.Controls.Add(Me.cboUnidadMedida)
        Me.pagGeneral.ImageIndex = 0
        Me.pagGeneral.Location = New System.Drawing.Point(1, 41)
        Me.pagGeneral.Name = "pagGeneral"
        Me.pagGeneral.Size = New System.Drawing.Size(695, 341)
        Me.pagGeneral.TabIndex = 0
        Me.pagGeneral.Text = "General"
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
        Me.txtCuenta.Location = New System.Drawing.Point(129, 89)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(466, 23)
        Me.txtCuenta.TabIndex = 9
        Me.txtCuenta.TextWidth = 100
        '
        'cboTipoUnidad
        '
        Me.cboTipoUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoUnidad.FormattingEnabled = True
        Me.cboTipoUnidad.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboTipoUnidad.ItemsTable = Nothing
        Me.cboTipoUnidad.Location = New System.Drawing.Point(129, 36)
        Me.cboTipoUnidad.Name = "cboTipoUnidad"
        Me.cboTipoUnidad.Size = New System.Drawing.Size(107, 21)
        Me.cboTipoUnidad.TabIndex = 3
        Me.cboTipoUnidad.UIName = Nothing
        '
        'cboUnidadMedida
        '
        Me.cboUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnidadMedida.FormattingEnabled = True
        Me.cboUnidadMedida.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboUnidadMedida.ItemsTable = Nothing
        Me.cboUnidadMedida.Location = New System.Drawing.Point(242, 35)
        Me.cboUnidadMedida.Name = "cboUnidadMedida"
        Me.cboUnidadMedida.RequiredField = True
        Me.cboUnidadMedida.Size = New System.Drawing.Size(184, 21)
        Me.cboUnidadMedida.TabIndex = 4
        Me.cboUnidadMedida.UIName = "Unidad Medida"
        '
        'pagStock
        '
        Me.pagStock.Controls.Add(Me.grpStockAlm)
        Me.pagStock.Controls.Add(Me.grpStockGeneral)
        Me.pagStock.ImageIndex = 1
        Me.pagStock.Location = New System.Drawing.Point(1, 41)
        Me.pagStock.Name = "pagStock"
        Me.pagStock.Size = New System.Drawing.Size(695, 341)
        Me.pagStock.TabIndex = 1
        Me.pagStock.Text = "Stock"
        '
        'pagClasificaciones
        '
        Me.pagClasificaciones.Controls.Add(Me.cboClasificaciones)
        Me.pagClasificaciones.Controls.Add(Me.grdClasificaciones)
        Me.pagClasificaciones.ImageIndex = 2
        Me.pagClasificaciones.Location = New System.Drawing.Point(1, 41)
        Me.pagClasificaciones.Name = "pagClasificaciones"
        Me.pagClasificaciones.Size = New System.Drawing.Size(695, 341)
        Me.pagClasificaciones.TabIndex = 2
        Me.pagClasificaciones.Text = "Clasificaciones"
        '
        'pagZonas
        '
        Me.pagZonas.Controls.Add(Me.grdZonas)
        Me.pagZonas.Controls.Add(Me.AzToolBar1)
        Me.pagZonas.ImageIndex = 3
        Me.pagZonas.Location = New System.Drawing.Point(1, 41)
        Me.pagZonas.Name = "pagZonas"
        Me.pagZonas.Size = New System.Drawing.Size(695, 341)
        Me.pagZonas.TabIndex = 3
        Me.pagZonas.Text = "Zonas de Compra"
        '
        'pagCategorias
        '
        Me.pagCategorias.ImageIndex = 4
        Me.pagCategorias.Location = New System.Drawing.Point(1, 41)
        Me.pagCategorias.Name = "pagCategorias"
        Me.pagCategorias.Size = New System.Drawing.Size(695, 341)
        Me.pagCategorias.TabIndex = 4
        Me.pagCategorias.Text = "Categorias Presupuestales"
        '
        'ArticulosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 501)
        Me.Controls.Add(Me.tabArticulos)
        Me.KeyMode = Azteca.Windows.Forms.BusinessForms.CatalogForm.UserKeyMode.UserDefined
        Me.Name = "ArticulosForm"
        Me.Text = "ArticulosForm"
        Me.Controls.SetChildIndex(Me.tabArticulos, 0)
        CType(Me.bsAlmacenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDatosInv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsClasificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsGruposClasif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpStockAlm.ResumeLayout(False)
        CType(Me.cboAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDatosInv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpStockGeneral.ResumeLayout(False)
        Me.grpStockGeneral.PerformLayout()
        CType(Me.nudStockMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPuntoReorden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStockMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboClasificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdClasificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdZonas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsZonas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabArticulos.ResumeLayout(False)
        Me.pagGeneral.ResumeLayout(False)
        Me.pagGeneral.PerformLayout()
        Me.pagStock.ResumeLayout(False)
        Me.pagClasificaciones.ResumeLayout(False)
        Me.pagZonas.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New Azteca.Business.Inventario.ArticuloStockFacade
    End Sub
    Friend WithEvents txtCuenta As Azteca.Windows.Contabilidad.CuentaSelector
    Friend WithEvents CiLabel8 As Azteca.Windows.Controls.CILabel
    Public WithEvents cboTipoUnidad As Azteca.Windows.Inventario.TiposUnidadComboBox
    Public WithEvents cboUnidadMedida As Azteca.Windows.Inventario.UnidadesMedidaComboBox
    Friend WithEvents txtDescr As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtEAN As Azteca.Windows.Controls.CITextBox
    Public WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents grpStockAlm As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents cboAlmacen As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents grdDatosInv As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents grpStockGeneral As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents nudStockMax As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents nudPuntoReorden As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents CiLabel5 As Azteca.Windows.Controls.CILabel
    Friend WithEvents nudStockMin As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents CiLabel6 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel7 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboClasificaciones As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents grdClasificaciones As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents grdZonas As Azteca.Windows.Controls.AZTrueDBGrid
    Private WithEvents bsAlmacenes As System.Windows.Forms.BindingSource
    Private WithEvents bsDatosInv As System.Windows.Forms.BindingSource
    Private WithEvents bsClasificaciones As System.Windows.Forms.BindingSource
    Private WithEvents bsGruposClasif As System.Windows.Forms.BindingSource
    Private WithEvents imlArticulo As System.Windows.Forms.ImageList
    Private WithEvents bsZonas As System.Windows.Forms.BindingSource
    Friend WithEvents AzToolBar1 As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents cmdProveedores As C1.Win.C1Command.C1Command
    Friend WithEvents tabArticulos As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagGeneral As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagStock As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagClasificaciones As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagZonas As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagCategorias As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents btnProveedores As C1.Win.C1Command.C1CommandLink
End Class
