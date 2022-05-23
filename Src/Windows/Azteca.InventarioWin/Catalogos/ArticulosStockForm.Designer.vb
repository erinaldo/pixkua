<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArticulosStockForm
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
        Dim Style1 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style2 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style3 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style4 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style5 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ArticulosStockForm))
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
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel8 = New Azteca.Windows.Controls.CILabel()
        Me.txtDescr = New Azteca.Windows.Controls.CITextBox()
        Me.txtEAN = New Azteca.Windows.Controls.CITextBox()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.grpStockAlm = New Azteca.Windows.Controls.CIGroupBox()
        Me.cboAlmacen = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.bsAlmacenes = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdDatosInv = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsDatosInv = New System.Windows.Forms.BindingSource(Me.components)
        Me.grpStockGeneral = New Azteca.Windows.Controls.CIGroupBox()
        Me.nudStockMax = New Azteca.Windows.Controls.CINumericUpDown()
        Me.nudPuntoReorden = New Azteca.Windows.Controls.CINumericUpDown()
        Me.CiLabel5 = New Azteca.Windows.Controls.CILabel()
        Me.nudStockMin = New Azteca.Windows.Controls.CINumericUpDown()
        Me.CiLabel6 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel7 = New Azteca.Windows.Controls.CILabel()
        Me.cboClasificaciones = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.bsClasificaciones = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdClasificaciones = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsGruposClasif = New System.Windows.Forms.BindingSource(Me.components)
        Me.imlArticulo = New System.Windows.Forms.ImageList(Me.components)
        Me.tabArticulos = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagGeneral = New C1.Win.C1Command.C1DockingTabPage()
        Me.txtFactorFab = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel19 = New Azteca.Windows.Controls.CILabel()
        Me.txtVersionMaster = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel18 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel17 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel16 = New Azteca.Windows.Controls.CILabel()
        Me.txtCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.pagStock = New C1.Win.C1Command.C1DockingTabPage()
        Me.pagClasificaciones = New C1.Win.C1Command.C1DockingTabPage()
        Me.pagFotografia = New C1.Win.C1Command.C1DockingTabPage()
        Me.picMngrImage = New Azteca.Windows.Controls.CIPictureManager()
        Me.C1DockingTabPage1 = New C1.Win.C1Command.C1DockingTabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCostoTotal = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel15 = New Azteca.Windows.Controls.CILabel()
        Me.txtCostoCarga = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel14 = New Azteca.Windows.Controls.CILabel()
        Me.txtCostoServicio = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel13 = New Azteca.Windows.Controls.CILabel()
        Me.txtCostoLabor = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel12 = New Azteca.Windows.Controls.CILabel()
        Me.txtCostoMaterial = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel11 = New Azteca.Windows.Controls.CILabel()
        Me.cboColor = New Azteca.Windows.Controls.CIComboBox()
        Me.cboTalla = New Azteca.Windows.Controls.CIComboBox()
        Me.CiLabel10 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel9 = New Azteca.Windows.Controls.CILabel()
        Me.cboTipo = New Azteca.Windows.Inventario.TiposArticulosComboBox()
        Me.cboFamilia = New Azteca.Windows.Inventario.FamiliasComboBox()
        Me.cboTipoUnidad = New Azteca.Windows.Inventario.TiposUnidadComboBox()
        Me.cboUnidadMedida = New Azteca.Windows.Inventario.UnidadesMedidaComboBox()
        Me.chkCantidadFija = New System.Windows.Forms.CheckBox()
        Me.grpStockAlm.SuspendLayout()
        CType(Me.cboAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAlmacenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDatosInv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDatosInv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpStockGeneral.SuspendLayout()
        CType(Me.nudStockMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPuntoReorden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStockMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboClasificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsClasificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdClasificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsGruposClasif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabArticulos.SuspendLayout()
        Me.pagGeneral.SuspendLayout()
        Me.pagStock.SuspendLayout()
        Me.pagClasificaciones.SuspendLayout()
        Me.pagFotografia.SuspendLayout()
        Me.C1DockingTabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(3, 16)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(47, 13)
        Me.CiLabel1.TabIndex = 0
        Me.CiLabel1.Text = "Nombre:"
        '
        'CiLabel8
        '
        Me.CiLabel8.AutoSize = True
        Me.CiLabel8.Location = New System.Drawing.Point(3, 97)
        Me.CiLabel8.Name = "CiLabel8"
        Me.CiLabel8.Size = New System.Drawing.Size(44, 13)
        Me.CiLabel8.TabIndex = 8
        Me.CiLabel8.Text = "Cuenta:"
        '
        'txtDescr
        '
        Me.txtDescr.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtDescr.Location = New System.Drawing.Point(118, 187)
        Me.txtDescr.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDescr.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDescr.Multiline = True
        Me.txtDescr.Name = "txtDescr"
        Me.txtDescr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescr.Size = New System.Drawing.Size(370, 87)
        Me.txtDescr.TabIndex = 11
        '
        'txtEAN
        '
        Me.txtEAN.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtEAN.Location = New System.Drawing.Point(118, 66)
        Me.txtEAN.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtEAN.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtEAN.Name = "txtEAN"
        Me.txtEAN.Size = New System.Drawing.Size(127, 20)
        Me.txtEAN.TabIndex = 6
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(118, 12)
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
        Me.CiLabel4.Location = New System.Drawing.Point(3, 70)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(32, 13)
        Me.CiLabel4.TabIndex = 5
        Me.CiLabel4.Text = "EAN:"
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(3, 42)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(109, 13)
        Me.CiLabel3.TabIndex = 2
        Me.CiLabel3.Text = "Unidad de Inventario:"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(3, 187)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(66, 13)
        Me.CiLabel2.TabIndex = 10
        Me.CiLabel2.Text = "Descripción:"
        '
        'grpStockAlm
        '
        Me.grpStockAlm.Controls.Add(Me.cboAlmacen)
        Me.grpStockAlm.Controls.Add(Me.grdDatosInv)
        Me.grpStockAlm.Location = New System.Drawing.Point(3, 124)
        Me.grpStockAlm.Name = "grpStockAlm"
        Me.grpStockAlm.Size = New System.Drawing.Size(608, 158)
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
        Me.cboAlmacen.Location = New System.Drawing.Point(161, 54)
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
        'bsAlmacenes
        '
        Me.bsAlmacenes.AllowNew = False
        '
        'grdDatosInv
        '
        Me.grdDatosInv.AllowAddNew = True
        Me.grdDatosInv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDatosInv.DataSource = Me.bsDatosInv
        Me.grdDatosInv.Images.Add(CType(resources.GetObject("grdDatosInv.Images"), System.Drawing.Image))
        Me.grdDatosInv.Images.Add(CType(resources.GetObject("grdDatosInv.Images1"), System.Drawing.Image))
        Me.grdDatosInv.Location = New System.Drawing.Point(6, 19)
        Me.grdDatosInv.Name = "grdDatosInv"
        Me.grdDatosInv.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdDatosInv.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdDatosInv.PreviewInfo.ZoomFactor = 75.0R
        Me.grdDatosInv.PrintInfo.PageSettings = CType(resources.GetObject("grdDatosInv.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdDatosInv.Size = New System.Drawing.Size(596, 133)
        Me.grdDatosInv.TabIndex = 0
        Me.grdDatosInv.Text = "AzTrueDBGrid1"
        Me.grdDatosInv.PropBag = resources.GetString("grdDatosInv.PropBag")
        '
        'grpStockGeneral
        '
        Me.grpStockGeneral.Controls.Add(Me.nudStockMax)
        Me.grpStockGeneral.Controls.Add(Me.nudPuntoReorden)
        Me.grpStockGeneral.Controls.Add(Me.CiLabel5)
        Me.grpStockGeneral.Controls.Add(Me.nudStockMin)
        Me.grpStockGeneral.Controls.Add(Me.CiLabel6)
        Me.grpStockGeneral.Controls.Add(Me.CiLabel7)
        Me.grpStockGeneral.Location = New System.Drawing.Point(3, 16)
        Me.grpStockGeneral.Name = "grpStockGeneral"
        Me.grpStockGeneral.Size = New System.Drawing.Size(608, 101)
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
        Me.cboClasificaciones.Location = New System.Drawing.Point(131, 57)
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
        Me.grdClasificaciones.Size = New System.Drawing.Size(614, 301)
        Me.grdClasificaciones.TabIndex = 0
        Me.grdClasificaciones.Text = "AzTrueDBGrid1"
        Me.grdClasificaciones.PropBag = resources.GetString("grdClasificaciones.PropBag")
        '
        'imlArticulo
        '
        Me.imlArticulo.ImageStream = CType(resources.GetObject("imlArticulo.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlArticulo.TransparentColor = System.Drawing.Color.Transparent
        Me.imlArticulo.Images.SetKeyName(0, "General")
        Me.imlArticulo.Images.SetKeyName(1, "Inventario")
        Me.imlArticulo.Images.SetKeyName(2, "Clasificaciones")
        Me.imlArticulo.Images.SetKeyName(3, "motion_blur_32.png")
        '
        'tabArticulos
        '
        Me.tabArticulos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabArticulos.Controls.Add(Me.pagGeneral)
        Me.tabArticulos.Controls.Add(Me.pagStock)
        Me.tabArticulos.Controls.Add(Me.pagClasificaciones)
        Me.tabArticulos.Controls.Add(Me.pagFotografia)
        Me.tabArticulos.Controls.Add(Me.C1DockingTabPage1)
        Me.tabArticulos.ImageList = Me.imlArticulo
        Me.tabArticulos.Location = New System.Drawing.Point(10, 90)
        Me.tabArticulos.Name = "tabArticulos"
        Me.tabArticulos.SelectedIndex = 4
        Me.tabArticulos.SelectedTabBold = True
        Me.tabArticulos.Size = New System.Drawing.Size(616, 343)
        Me.tabArticulos.TabIndex = 32
        Me.tabArticulos.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabArticulos.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabArticulos.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagGeneral
        '
        Me.pagGeneral.Controls.Add(Me.chkCantidadFija)
        Me.pagGeneral.Controls.Add(Me.txtFactorFab)
        Me.pagGeneral.Controls.Add(Me.CiLabel19)
        Me.pagGeneral.Controls.Add(Me.txtVersionMaster)
        Me.pagGeneral.Controls.Add(Me.CiLabel18)
        Me.pagGeneral.Controls.Add(Me.CiLabel17)
        Me.pagGeneral.Controls.Add(Me.CiLabel16)
        Me.pagGeneral.Controls.Add(Me.CiLabel1)
        Me.pagGeneral.Controls.Add(Me.CiLabel8)
        Me.pagGeneral.Controls.Add(Me.CiLabel2)
        Me.pagGeneral.Controls.Add(Me.CiLabel3)
        Me.pagGeneral.Controls.Add(Me.CiLabel4)
        Me.pagGeneral.Controls.Add(Me.txtNombre)
        Me.pagGeneral.Controls.Add(Me.txtDescr)
        Me.pagGeneral.Controls.Add(Me.txtEAN)
        Me.pagGeneral.Controls.Add(Me.txtCuenta)
        Me.pagGeneral.Controls.Add(Me.cboTipo)
        Me.pagGeneral.Controls.Add(Me.cboFamilia)
        Me.pagGeneral.Controls.Add(Me.cboTipoUnidad)
        Me.pagGeneral.Controls.Add(Me.cboUnidadMedida)
        Me.pagGeneral.ImageIndex = 0
        Me.pagGeneral.Location = New System.Drawing.Point(1, 41)
        Me.pagGeneral.Name = "pagGeneral"
        Me.pagGeneral.Size = New System.Drawing.Size(614, 301)
        Me.pagGeneral.TabIndex = 0
        Me.pagGeneral.Text = "General"
        '
        'txtFactorFab
        '
        Me.txtFactorFab.Digits = True
        Me.txtFactorFab.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtFactorFab.Location = New System.Drawing.Point(118, 158)
        Me.txtFactorFab.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFactorFab.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFactorFab.Name = "txtFactorFab"
        Me.txtFactorFab.RequiredField = True
        Me.txtFactorFab.Size = New System.Drawing.Size(51, 20)
        Me.txtFactorFab.TabIndex = 20
        '
        'CiLabel19
        '
        Me.CiLabel19.AutoSize = True
        Me.CiLabel19.Location = New System.Drawing.Point(3, 161)
        Me.CiLabel19.Name = "CiLabel19"
        Me.CiLabel19.Size = New System.Drawing.Size(113, 13)
        Me.CiLabel19.TabIndex = 19
        Me.CiLabel19.Text = "Factor de Fabricación:"
        '
        'txtVersionMaster
        '
        Me.txtVersionMaster.Digits = True
        Me.txtVersionMaster.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtVersionMaster.Location = New System.Drawing.Point(364, 67)
        Me.txtVersionMaster.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtVersionMaster.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtVersionMaster.Name = "txtVersionMaster"
        Me.txtVersionMaster.RequiredField = True
        Me.txtVersionMaster.Size = New System.Drawing.Size(51, 20)
        Me.txtVersionMaster.TabIndex = 18
        '
        'CiLabel18
        '
        Me.CiLabel18.AutoSize = True
        Me.CiLabel18.Location = New System.Drawing.Point(272, 69)
        Me.CiLabel18.Name = "CiLabel18"
        Me.CiLabel18.Size = New System.Drawing.Size(86, 13)
        Me.CiLabel18.TabIndex = 17
        Me.CiLabel18.Text = "Versión Maestro:"
        '
        'CiLabel17
        '
        Me.CiLabel17.AutoSize = True
        Me.CiLabel17.Location = New System.Drawing.Point(287, 127)
        Me.CiLabel17.Name = "CiLabel17"
        Me.CiLabel17.Size = New System.Drawing.Size(31, 13)
        Me.CiLabel17.TabIndex = 13
        Me.CiLabel17.Text = "Tipo:"
        '
        'CiLabel16
        '
        Me.CiLabel16.AutoSize = True
        Me.CiLabel16.Location = New System.Drawing.Point(3, 127)
        Me.CiLabel16.Name = "CiLabel16"
        Me.CiLabel16.Size = New System.Drawing.Size(42, 13)
        Me.CiLabel16.TabIndex = 12
        Me.CiLabel16.Text = "Familia:"
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
        Me.txtCuenta.Location = New System.Drawing.Point(118, 92)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(370, 23)
        Me.txtCuenta.TabIndex = 9
        Me.txtCuenta.TextWidth = 100
        '
        'pagStock
        '
        Me.pagStock.Controls.Add(Me.grpStockAlm)
        Me.pagStock.Controls.Add(Me.grpStockGeneral)
        Me.pagStock.ImageIndex = 1
        Me.pagStock.Location = New System.Drawing.Point(1, 41)
        Me.pagStock.Name = "pagStock"
        Me.pagStock.Size = New System.Drawing.Size(614, 301)
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
        Me.pagClasificaciones.Size = New System.Drawing.Size(614, 301)
        Me.pagClasificaciones.TabIndex = 2
        Me.pagClasificaciones.Text = "Clasificaciones"
        '
        'pagFotografia
        '
        Me.pagFotografia.Controls.Add(Me.picMngrImage)
        Me.pagFotografia.ImageIndex = 3
        Me.pagFotografia.Location = New System.Drawing.Point(1, 41)
        Me.pagFotografia.Name = "pagFotografia"
        Me.pagFotografia.Size = New System.Drawing.Size(614, 301)
        Me.pagFotografia.TabIndex = 3
        Me.pagFotografia.Text = "Fotografia"
        '
        'picMngrImage
        '
        Me.picMngrImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picMngrImage.Image = Nothing
        Me.picMngrImage.Location = New System.Drawing.Point(24, 23)
        Me.picMngrImage.Name = "picMngrImage"
        Me.picMngrImage.Size = New System.Drawing.Size(330, 253)
        Me.picMngrImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
        Me.picMngrImage.TabIndex = 28
        Me.picMngrImage.UIName = Nothing
        '
        'C1DockingTabPage1
        '
        Me.C1DockingTabPage1.Controls.Add(Me.GroupBox1)
        Me.C1DockingTabPage1.Controls.Add(Me.cboColor)
        Me.C1DockingTabPage1.Controls.Add(Me.cboTalla)
        Me.C1DockingTabPage1.Controls.Add(Me.CiLabel10)
        Me.C1DockingTabPage1.Controls.Add(Me.CiLabel9)
        Me.C1DockingTabPage1.Location = New System.Drawing.Point(1, 41)
        Me.C1DockingTabPage1.Name = "C1DockingTabPage1"
        Me.C1DockingTabPage1.Size = New System.Drawing.Size(614, 301)
        Me.C1DockingTabPage1.TabIndex = 4
        Me.C1DockingTabPage1.Text = "Propiedades"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCostoTotal)
        Me.GroupBox1.Controls.Add(Me.CiLabel15)
        Me.GroupBox1.Controls.Add(Me.txtCostoCarga)
        Me.GroupBox1.Controls.Add(Me.CiLabel14)
        Me.GroupBox1.Controls.Add(Me.txtCostoServicio)
        Me.GroupBox1.Controls.Add(Me.CiLabel13)
        Me.GroupBox1.Controls.Add(Me.txtCostoLabor)
        Me.GroupBox1.Controls.Add(Me.CiLabel12)
        Me.GroupBox1.Controls.Add(Me.txtCostoMaterial)
        Me.GroupBox1.Controls.Add(Me.CiLabel11)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(574, 135)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Costo Estandar"
        '
        'txtCostoTotal
        '
        Me.txtCostoTotal.Format = "N4"
        Me.txtCostoTotal.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCostoTotal.Location = New System.Drawing.Point(234, 92)
        Me.txtCostoTotal.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCostoTotal.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCostoTotal.Name = "txtCostoTotal"
        Me.txtCostoTotal.ReadOnly = True
        Me.txtCostoTotal.Size = New System.Drawing.Size(86, 20)
        Me.txtCostoTotal.TabIndex = 15
        '
        'CiLabel15
        '
        Me.CiLabel15.AutoSize = True
        Me.CiLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiLabel15.Location = New System.Drawing.Point(180, 95)
        Me.CiLabel15.Name = "CiLabel15"
        Me.CiLabel15.Size = New System.Drawing.Size(40, 13)
        Me.CiLabel15.TabIndex = 14
        Me.CiLabel15.Text = "Total:"
        '
        'txtCostoCarga
        '
        Me.txtCostoCarga.Digits = True
        Me.txtCostoCarga.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtCostoCarga.Format = "N4"
        Me.txtCostoCarga.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCostoCarga.Location = New System.Drawing.Point(234, 62)
        Me.txtCostoCarga.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCostoCarga.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCostoCarga.Name = "txtCostoCarga"
        Me.txtCostoCarga.Size = New System.Drawing.Size(86, 20)
        Me.txtCostoCarga.TabIndex = 13
        '
        'CiLabel14
        '
        Me.CiLabel14.AutoSize = True
        Me.CiLabel14.Location = New System.Drawing.Point(172, 65)
        Me.CiLabel14.Name = "CiLabel14"
        Me.CiLabel14.Size = New System.Drawing.Size(56, 13)
        Me.CiLabel14.TabIndex = 12
        Me.CiLabel14.Text = "Indirectos:"
        '
        'txtCostoServicio
        '
        Me.txtCostoServicio.Digits = True
        Me.txtCostoServicio.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtCostoServicio.Format = "N4"
        Me.txtCostoServicio.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCostoServicio.Location = New System.Drawing.Point(234, 33)
        Me.txtCostoServicio.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCostoServicio.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCostoServicio.Name = "txtCostoServicio"
        Me.txtCostoServicio.Size = New System.Drawing.Size(86, 20)
        Me.txtCostoServicio.TabIndex = 11
        '
        'CiLabel13
        '
        Me.CiLabel13.AutoSize = True
        Me.CiLabel13.Location = New System.Drawing.Point(180, 36)
        Me.CiLabel13.Name = "CiLabel13"
        Me.CiLabel13.Size = New System.Drawing.Size(48, 13)
        Me.CiLabel13.TabIndex = 10
        Me.CiLabel13.Text = "Servicio:"
        '
        'txtCostoLabor
        '
        Me.txtCostoLabor.Digits = True
        Me.txtCostoLabor.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtCostoLabor.Format = "N4"
        Me.txtCostoLabor.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCostoLabor.Location = New System.Drawing.Point(75, 59)
        Me.txtCostoLabor.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCostoLabor.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCostoLabor.Name = "txtCostoLabor"
        Me.txtCostoLabor.Size = New System.Drawing.Size(86, 20)
        Me.txtCostoLabor.TabIndex = 9
        '
        'CiLabel12
        '
        Me.CiLabel12.AutoSize = True
        Me.CiLabel12.Location = New System.Drawing.Point(32, 62)
        Me.CiLabel12.Name = "CiLabel12"
        Me.CiLabel12.Size = New System.Drawing.Size(37, 13)
        Me.CiLabel12.TabIndex = 8
        Me.CiLabel12.Text = "Labor:"
        '
        'txtCostoMaterial
        '
        Me.txtCostoMaterial.Digits = True
        Me.txtCostoMaterial.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtCostoMaterial.Format = "N4"
        Me.txtCostoMaterial.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCostoMaterial.Location = New System.Drawing.Point(75, 33)
        Me.txtCostoMaterial.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCostoMaterial.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCostoMaterial.Name = "txtCostoMaterial"
        Me.txtCostoMaterial.Size = New System.Drawing.Size(86, 20)
        Me.txtCostoMaterial.TabIndex = 7
        '
        'CiLabel11
        '
        Me.CiLabel11.AutoSize = True
        Me.CiLabel11.Location = New System.Drawing.Point(22, 36)
        Me.CiLabel11.Name = "CiLabel11"
        Me.CiLabel11.Size = New System.Drawing.Size(47, 13)
        Me.CiLabel11.TabIndex = 1
        Me.CiLabel11.Text = "Material:"
        '
        'cboColor
        '
        Me.cboColor.AddNoneItem = True
        Me.cboColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboColor.FormattingEnabled = True
        Me.cboColor.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboColor.ItemsTable = Nothing
        Me.cboColor.Location = New System.Drawing.Point(70, 46)
        Me.cboColor.Name = "cboColor"
        Me.cboColor.Size = New System.Drawing.Size(218, 21)
        Me.cboColor.TabIndex = 3
        Me.cboColor.UIName = Nothing
        '
        'cboTalla
        '
        Me.cboTalla.AddNoneItem = True
        Me.cboTalla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTalla.FormattingEnabled = True
        Me.cboTalla.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboTalla.ItemsTable = Nothing
        Me.cboTalla.Location = New System.Drawing.Point(70, 19)
        Me.cboTalla.Name = "cboTalla"
        Me.cboTalla.Size = New System.Drawing.Size(218, 21)
        Me.cboTalla.TabIndex = 2
        Me.cboTalla.UIName = Nothing
        '
        'CiLabel10
        '
        Me.CiLabel10.AutoSize = True
        Me.CiLabel10.Location = New System.Drawing.Point(17, 49)
        Me.CiLabel10.Name = "CiLabel10"
        Me.CiLabel10.Size = New System.Drawing.Size(34, 13)
        Me.CiLabel10.TabIndex = 1
        Me.CiLabel10.Text = "Color:"
        '
        'CiLabel9
        '
        Me.CiLabel9.AutoSize = True
        Me.CiLabel9.Location = New System.Drawing.Point(17, 22)
        Me.CiLabel9.Name = "CiLabel9"
        Me.CiLabel9.Size = New System.Drawing.Size(33, 13)
        Me.CiLabel9.TabIndex = 0
        Me.CiLabel9.Text = "Talla:"
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboTipo.ItemsTable = Nothing
        Me.cboTipo.Location = New System.Drawing.Point(328, 124)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(160, 21)
        Me.cboTipo.TabIndex = 16
        Me.cboTipo.UIName = Nothing
        '
        'cboFamilia
        '
        Me.cboFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFamilia.FormattingEnabled = True
        Me.cboFamilia.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboFamilia.ItemsTable = Nothing
        Me.cboFamilia.Location = New System.Drawing.Point(118, 124)
        Me.cboFamilia.Name = "cboFamilia"
        Me.cboFamilia.Size = New System.Drawing.Size(144, 21)
        Me.cboFamilia.TabIndex = 15
        Me.cboFamilia.UIName = Nothing
        '
        'cboTipoUnidad
        '
        Me.cboTipoUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoUnidad.FormattingEnabled = True
        Me.cboTipoUnidad.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboTipoUnidad.ItemsTable = Nothing
        Me.cboTipoUnidad.Location = New System.Drawing.Point(118, 39)
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
        Me.cboUnidadMedida.Location = New System.Drawing.Point(231, 38)
        Me.cboUnidadMedida.Name = "cboUnidadMedida"
        Me.cboUnidadMedida.RequiredField = True
        Me.cboUnidadMedida.Size = New System.Drawing.Size(184, 21)
        Me.cboUnidadMedida.TabIndex = 4
        Me.cboUnidadMedida.UIName = "Unidad Medida"
        '
        'chkCantidadFija
        '
        Me.chkCantidadFija.AutoSize = True
        Me.chkCantidadFija.Location = New System.Drawing.Point(328, 160)
        Me.chkCantidadFija.Name = "chkCantidadFija"
        Me.chkCantidadFija.Size = New System.Drawing.Size(120, 17)
        Me.chkCantidadFija.TabIndex = 21
        Me.chkCantidadFija.Text = "Cantidad Fija en OT"
        Me.chkCantidadFija.UseVisualStyleBackColor = True
        '
        'ArticulosStockForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 468)
        Me.Controls.Add(Me.tabArticulos)
        Me.KeyMode = Azteca.Windows.Forms.BusinessForms.CatalogForm.UserKeyMode.UserDefined
        Me.Name = "ArticulosStockForm"
        Me.Text = "ArticulosStockForm"
        Me.Controls.SetChildIndex(Me.tabArticulos, 0)
        Me.grpStockAlm.ResumeLayout(False)
        CType(Me.cboAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAlmacenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDatosInv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDatosInv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpStockGeneral.ResumeLayout(False)
        Me.grpStockGeneral.PerformLayout()
        CType(Me.nudStockMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPuntoReorden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStockMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboClasificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsClasificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdClasificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsGruposClasif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabArticulos.ResumeLayout(False)
        Me.pagGeneral.ResumeLayout(False)
        Me.pagGeneral.PerformLayout()
        Me.pagStock.ResumeLayout(False)
        Me.pagClasificaciones.ResumeLayout(False)
        Me.pagFotografia.ResumeLayout(False)
        Me.C1DockingTabPage1.ResumeLayout(False)
        Me.C1DockingTabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New ArticuloStockFacade
        LicenseModule = Kernel.Licensing.LicenseModule.Inventory
    End Sub
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtDescr As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtEAN As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents nudPuntoReorden As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents nudStockMin As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents nudStockMax As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents CiLabel7 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel6 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel5 As Azteca.Windows.Controls.CILabel
    Friend WithEvents imlArticulo As System.Windows.Forms.ImageList
    Public WithEvents cboTipoUnidad As Azteca.Windows.Inventario.TiposUnidadComboBox
    Public WithEvents cboUnidadMedida As Azteca.Windows.Inventario.UnidadesMedidaComboBox
    Public WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents grpStockGeneral As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents grpStockAlm As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents bsDatosInv As System.Windows.Forms.BindingSource
    Friend WithEvents grdDatosInv As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents cboAlmacen As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents bsAlmacenes As System.Windows.Forms.BindingSource
    Friend WithEvents grdClasificaciones As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents bsGruposClasif As System.Windows.Forms.BindingSource
    Friend WithEvents cboClasificaciones As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents bsClasificaciones As System.Windows.Forms.BindingSource
    Friend WithEvents txtCuenta As Azteca.Windows.Contabilidad.CuentaSelector
    Friend WithEvents CiLabel8 As Azteca.Windows.Controls.CILabel
    Friend WithEvents tabArticulos As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagGeneral As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagStock As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagClasificaciones As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagFotografia As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents picMngrImage As Azteca.Windows.Controls.CIPictureManager
    Friend WithEvents C1DockingTabPage1 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents CiLabel10 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel9 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboTalla As Azteca.Windows.Controls.CIComboBox
    Friend WithEvents CiLabel17 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel16 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboFamilia As Azteca.Windows.Inventario.FamiliasComboBox
    Friend WithEvents cboTipo As Azteca.Windows.Inventario.TiposArticulosComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCostoTotal As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel15 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCostoCarga As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel14 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCostoServicio As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel13 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCostoLabor As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel12 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCostoMaterial As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel11 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboColor As Azteca.Windows.Controls.CIComboBox
    Friend WithEvents txtFactorFab As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel19 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtVersionMaster As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel18 As Azteca.Windows.Controls.CILabel
    Friend WithEvents chkCantidadFija As System.Windows.Forms.CheckBox
End Class
