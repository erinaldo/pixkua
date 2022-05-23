<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductosForm
    Inherits Azteca.Windows.Forms.BusinessForms.CatalogForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Style1 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style2 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style3 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style4 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style5 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductosForm))
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
        Dim Style17 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style18 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style19 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style20 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style21 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style22 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style23 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style24 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style25 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style26 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style27 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style28 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style29 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style30 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style31 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style32 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Me.lblProducto = New Azteca.Windows.Controls.CILabel()
        Me.txtDescripcion = New Azteca.Windows.Controls.CITextBox()
        Me.lblArticulo = New Azteca.Windows.Controls.CILabel()
        Me.lblCuenta = New Azteca.Windows.Controls.CILabel()
        Me.lblCantidad = New Azteca.Windows.Controls.CILabel()
        Me.bsInsumos = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtCantidad = New Azteca.Windows.Controls.CITextBox()
        Me.lblMultiplos = New Azteca.Windows.Controls.CILabel()
        Me.txtMultiplos = New Azteca.Windows.Controls.CITextBox()
        Me.chkEntregasParciales = New Azteca.Windows.Controls.CICheckBox()
        Me.chkExigirRecepcion = New Azteca.Windows.Controls.CICheckBox()
        Me.colIdInsumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colArticuloStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUnidadMedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMetaAlmacen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPorcMerma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOpcional = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.tabAreas = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagInsumos = New C1.Win.C1Command.C1DockingTabPage()
        Me.dropMetaAlmacen = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.bsMetaAlmacenes = New System.Windows.Forms.BindingSource(Me.components)
        Me.dropUnidadMedida = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.bsUnidadMedida = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdInsumos = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.pagEnsambles = New C1.Win.C1Command.C1DockingTabPage()
        Me.drpMetaAlmacenP = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.dropUnidadesMedidaP = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.bsUnidadMedidaP = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdSubProductos = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsSubProductos = New System.Windows.Forms.BindingSource(Me.components)
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.btnInsumosAdd = New C1.Win.C1Command.C1Command()
        Me.btnProductosAdd = New C1.Win.C1Command.C1Command()
        Me.cboUnidadMedida = New Azteca.Windows.Inventario.UnidadesMedidaComboBox()
        Me.selCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.selArticuloStock = New Azteca.Windows.Inventario.ArticuloStockSelector()
        CType(Me.bsInsumos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabAreas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAreas.SuspendLayout()
        Me.pagInsumos.SuspendLayout()
        CType(Me.dropMetaAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsMetaAlmacenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dropUnidadMedida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsUnidadMedida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdInsumos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagEnsambles.SuspendLayout()
        CType(Me.drpMetaAlmacenP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dropUnidadesMedidaP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsUnidadMedidaP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSubProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSubProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(69, 93)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(50, 13)
        Me.lblProducto.TabIndex = 21
        Me.lblProducto.Text = "Producto"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtDescripcion.Location = New System.Drawing.Point(121, 90)
        Me.txtDescripcion.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDescripcion.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(414, 20)
        Me.txtDescripcion.TabIndex = 22
        '
        'lblArticulo
        '
        Me.lblArticulo.AutoSize = True
        Me.lblArticulo.Location = New System.Drawing.Point(75, 115)
        Me.lblArticulo.Name = "lblArticulo"
        Me.lblArticulo.Size = New System.Drawing.Size(42, 13)
        Me.lblArticulo.TabIndex = 24
        Me.lblArticulo.Text = "Articulo"
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Location = New System.Drawing.Point(73, 138)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(41, 13)
        Me.lblCuenta.TabIndex = 32
        Me.lblCuenta.Text = "Cuenta"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(65, 161)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(179, 13)
        Me.lblCantidad.TabIndex = 33
        Me.lblCantidad.Text = "Formula para producir la cantidad de"
        '
        'txtCantidad
        '
        Me.txtCantidad.Digits = True
        Me.txtCantidad.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtCantidad.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCantidad.Location = New System.Drawing.Point(250, 158)
        Me.txtCantidad.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantidad.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(101, 20)
        Me.txtCantidad.TabIndex = 35
        '
        'lblMultiplos
        '
        Me.lblMultiplos.AutoSize = True
        Me.lblMultiplos.Location = New System.Drawing.Point(537, 163)
        Me.lblMultiplos.Name = "lblMultiplos"
        Me.lblMultiplos.Size = New System.Drawing.Size(122, 13)
        Me.lblMultiplos.TabIndex = 37
        Me.lblMultiplos.Text = ".Producir en multiplos de"
        '
        'txtMultiplos
        '
        Me.txtMultiplos.Digits = True
        Me.txtMultiplos.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtMultiplos.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtMultiplos.Location = New System.Drawing.Point(665, 160)
        Me.txtMultiplos.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtMultiplos.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtMultiplos.Name = "txtMultiplos"
        Me.txtMultiplos.Size = New System.Drawing.Size(100, 20)
        Me.txtMultiplos.TabIndex = 38
        '
        'chkEntregasParciales
        '
        Me.chkEntregasParciales.AutoSize = True
        Me.chkEntregasParciales.Location = New System.Drawing.Point(247, 184)
        Me.chkEntregasParciales.Name = "chkEntregasParciales"
        Me.chkEntregasParciales.Size = New System.Drawing.Size(149, 17)
        Me.chkEntregasParciales.TabIndex = 39
        Me.chkEntregasParciales.Text = "Permitir entregas parciales"
        Me.chkEntregasParciales.UseVisualStyleBackColor = True
        '
        'chkExigirRecepcion
        '
        Me.chkExigirRecepcion.AutoSize = True
        Me.chkExigirRecepcion.Location = New System.Drawing.Point(402, 185)
        Me.chkExigirRecepcion.Name = "chkExigirRecepcion"
        Me.chkExigirRecepcion.Size = New System.Drawing.Size(165, 17)
        Me.chkExigirRecepcion.TabIndex = 40
        Me.chkExigirRecepcion.Text = "Exigir la recepción al entregar"
        Me.chkExigirRecepcion.UseVisualStyleBackColor = True
        '
        'colIdInsumo
        '
        Me.colIdInsumo.DataPropertyName = "IdInsumo"
        Me.colIdInsumo.HeaderText = "IdInsumo"
        Me.colIdInsumo.MinimumWidth = 2
        Me.colIdInsumo.Name = "colIdInsumo"
        Me.colIdInsumo.ReadOnly = True
        Me.colIdInsumo.Width = 2
        '
        'colArticuloStock
        '
        Me.colArticuloStock.DataPropertyName = "Insumo"
        Me.colArticuloStock.HeaderText = "Insumo"
        Me.colArticuloStock.Name = "colArticuloStock"
        Me.colArticuloStock.ReadOnly = True
        Me.colArticuloStock.Width = 190
        '
        'colUnidadMedida
        '
        Me.colUnidadMedida.DataPropertyName = "UnidadMedida"
        Me.colUnidadMedida.HeaderText = "UnidadMedida"
        Me.colUnidadMedida.Name = "colUnidadMedida"
        Me.colUnidadMedida.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colUnidadMedida.Width = 120
        '
        'colCantidad
        '
        Me.colCantidad.DataPropertyName = "Cantidad"
        Me.colCantidad.HeaderText = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Width = 80
        '
        'colMetaAlmacen
        '
        Me.colMetaAlmacen.DataPropertyName = "MetaAlmacen"
        Me.colMetaAlmacen.HeaderText = "Requisitar desde.."
        Me.colMetaAlmacen.Name = "colMetaAlmacen"
        Me.colMetaAlmacen.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colMetaAlmacen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colMetaAlmacen.Width = 170
        '
        'colPorcMerma
        '
        Me.colPorcMerma.DataPropertyName = "PorcMerma"
        Me.colPorcMerma.HeaderText = "% Merma"
        Me.colPorcMerma.Name = "colPorcMerma"
        Me.colPorcMerma.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colPorcMerma.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colPorcMerma.Width = 60
        '
        'colOpcional
        '
        Me.colOpcional.DataPropertyName = "Opcional"
        Me.colOpcional.HeaderText = "Opcional"
        Me.colOpcional.Name = "colOpcional"
        Me.colOpcional.Width = 70
        '
        'tabAreas
        '
        Me.tabAreas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabAreas.Controls.Add(Me.pagInsumos)
        Me.tabAreas.Controls.Add(Me.pagEnsambles)
        Me.tabAreas.Location = New System.Drawing.Point(12, 208)
        Me.tabAreas.Name = "tabAreas"
        Me.tabAreas.SelectedIndex = 1
        Me.tabAreas.Size = New System.Drawing.Size(857, 328)
        Me.tabAreas.TabIndex = 41
        Me.tabAreas.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabAreas.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabAreas.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagInsumos
        '
        Me.pagInsumos.Controls.Add(Me.dropMetaAlmacen)
        Me.pagInsumos.Controls.Add(Me.dropUnidadMedida)
        Me.pagInsumos.Controls.Add(Me.grdInsumos)
        Me.pagInsumos.Image = CType(resources.GetObject("pagInsumos.Image"), System.Drawing.Image)
        Me.pagInsumos.Location = New System.Drawing.Point(1, 41)
        Me.pagInsumos.Name = "pagInsumos"
        Me.pagInsumos.Size = New System.Drawing.Size(855, 286)
        Me.pagInsumos.TabIndex = 0
        Me.pagInsumos.Text = "Insumos"
        '
        'dropMetaAlmacen
        '
        Me.dropMetaAlmacen.AllowColMove = True
        Me.dropMetaAlmacen.AllowColSelect = True
        Me.dropMetaAlmacen.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.dropMetaAlmacen.AlternatingRows = False
        Me.dropMetaAlmacen.CaptionStyle = Style1
        Me.dropMetaAlmacen.ColumnCaptionHeight = 17
        Me.dropMetaAlmacen.ColumnFooterHeight = 17
        Me.dropMetaAlmacen.DataSource = Me.bsMetaAlmacenes
        Me.dropMetaAlmacen.DisplayMember = "MetaAlmacen"
        Me.dropMetaAlmacen.EvenRowStyle = Style2
        Me.dropMetaAlmacen.FetchRowStyles = False
        Me.dropMetaAlmacen.FooterStyle = Style3
        Me.dropMetaAlmacen.HeadingStyle = Style4
        Me.dropMetaAlmacen.HighLightRowStyle = Style5
        Me.dropMetaAlmacen.Images.Add(CType(resources.GetObject("dropMetaAlmacen.Images"), System.Drawing.Image))
        Me.dropMetaAlmacen.Location = New System.Drawing.Point(555, 35)
        Me.dropMetaAlmacen.Name = "dropMetaAlmacen"
        Me.dropMetaAlmacen.OddRowStyle = Style6
        Me.dropMetaAlmacen.RecordSelectorStyle = Style7
        Me.dropMetaAlmacen.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.dropMetaAlmacen.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.dropMetaAlmacen.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.dropMetaAlmacen.ScrollTips = False
        Me.dropMetaAlmacen.Size = New System.Drawing.Size(277, 135)
        Me.dropMetaAlmacen.Style = Style8
        Me.dropMetaAlmacen.TabIndex = 51
        Me.dropMetaAlmacen.TabStop = False
        Me.dropMetaAlmacen.Text = "C1TrueDBDropdown1"
        Me.dropMetaAlmacen.ValueMember = "IdMetaAlmacen"
        Me.dropMetaAlmacen.ValueTranslate = True
        Me.dropMetaAlmacen.Visible = False
        Me.dropMetaAlmacen.PropBag = resources.GetString("dropMetaAlmacen.PropBag")
        '
        'dropUnidadMedida
        '
        Me.dropUnidadMedida.AllowColMove = True
        Me.dropUnidadMedida.AllowColSelect = True
        Me.dropUnidadMedida.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.dropUnidadMedida.AlternatingRows = False
        Me.dropUnidadMedida.CaptionStyle = Style9
        Me.dropUnidadMedida.ColumnCaptionHeight = 17
        Me.dropUnidadMedida.ColumnFooterHeight = 17
        Me.dropUnidadMedida.DataSource = Me.bsUnidadMedida
        Me.dropUnidadMedida.DisplayMember = "Nombre"
        Me.dropUnidadMedida.EvenRowStyle = Style10
        Me.dropUnidadMedida.FetchRowStyles = False
        Me.dropUnidadMedida.FooterStyle = Style11
        Me.dropUnidadMedida.HeadingStyle = Style12
        Me.dropUnidadMedida.HighLightRowStyle = Style13
        Me.dropUnidadMedida.Images.Add(CType(resources.GetObject("dropUnidadMedida.Images"), System.Drawing.Image))
        Me.dropUnidadMedida.Location = New System.Drawing.Point(398, 35)
        Me.dropUnidadMedida.Name = "dropUnidadMedida"
        Me.dropUnidadMedida.OddRowStyle = Style14
        Me.dropUnidadMedida.RecordSelectorStyle = Style15
        Me.dropUnidadMedida.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.dropUnidadMedida.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.dropUnidadMedida.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.dropUnidadMedida.ScrollTips = False
        Me.dropUnidadMedida.Size = New System.Drawing.Size(326, 135)
        Me.dropUnidadMedida.Style = Style16
        Me.dropUnidadMedida.TabIndex = 50
        Me.dropUnidadMedida.TabStop = False
        Me.dropUnidadMedida.Text = "C1TrueDBDropdown1"
        Me.dropUnidadMedida.ValueMember = "IdUnidadMedida"
        Me.dropUnidadMedida.ValueTranslate = True
        Me.dropUnidadMedida.Visible = False
        Me.dropUnidadMedida.PropBag = resources.GetString("dropUnidadMedida.PropBag")
        '
        'grdInsumos
        '
        Me.grdInsumos.AllowAddNew = True
        Me.grdInsumos.DataSource = Me.bsInsumos
        Me.grdInsumos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdInsumos.Images.Add(CType(resources.GetObject("grdInsumos.Images"), System.Drawing.Image))
        Me.grdInsumos.Images.Add(CType(resources.GetObject("grdInsumos.Images1"), System.Drawing.Image))
        Me.grdInsumos.Images.Add(CType(resources.GetObject("grdInsumos.Images2"), System.Drawing.Image))
        Me.grdInsumos.Location = New System.Drawing.Point(0, 0)
        Me.grdInsumos.Name = "grdInsumos"
        Me.grdInsumos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdInsumos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdInsumos.PreviewInfo.ZoomFactor = 75.0R
        Me.grdInsumos.PrintInfo.PageSettings = CType(resources.GetObject("grdInsumos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdInsumos.Size = New System.Drawing.Size(855, 286)
        Me.grdInsumos.TabIndex = 29
        Me.grdInsumos.Text = "AzTrueDBGrid1"
        Me.grdInsumos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdInsumos.PropBag = resources.GetString("grdInsumos.PropBag")
        '
        'pagEnsambles
        '
        Me.pagEnsambles.Controls.Add(Me.drpMetaAlmacenP)
        Me.pagEnsambles.Controls.Add(Me.dropUnidadesMedidaP)
        Me.pagEnsambles.Controls.Add(Me.grdSubProductos)
        Me.pagEnsambles.Image = CType(resources.GetObject("pagEnsambles.Image"), System.Drawing.Image)
        Me.pagEnsambles.Location = New System.Drawing.Point(1, 41)
        Me.pagEnsambles.Name = "pagEnsambles"
        Me.pagEnsambles.Size = New System.Drawing.Size(855, 286)
        Me.pagEnsambles.TabIndex = 1
        Me.pagEnsambles.Text = "Ensambles"
        '
        'drpMetaAlmacenP
        '
        Me.drpMetaAlmacenP.AllowColMove = True
        Me.drpMetaAlmacenP.AllowColSelect = True
        Me.drpMetaAlmacenP.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.drpMetaAlmacenP.AlternatingRows = False
        Me.drpMetaAlmacenP.CaptionStyle = Style17
        Me.drpMetaAlmacenP.ColumnCaptionHeight = 17
        Me.drpMetaAlmacenP.ColumnFooterHeight = 17
        Me.drpMetaAlmacenP.DataSource = Me.bsMetaAlmacenes
        Me.drpMetaAlmacenP.DisplayMember = "MetaAlmacen"
        Me.drpMetaAlmacenP.EvenRowStyle = Style18
        Me.drpMetaAlmacenP.FetchRowStyles = False
        Me.drpMetaAlmacenP.FooterStyle = Style19
        Me.drpMetaAlmacenP.HeadingStyle = Style20
        Me.drpMetaAlmacenP.HighLightRowStyle = Style21
        Me.drpMetaAlmacenP.Images.Add(CType(resources.GetObject("drpMetaAlmacenP.Images"), System.Drawing.Image))
        Me.drpMetaAlmacenP.Location = New System.Drawing.Point(605, 73)
        Me.drpMetaAlmacenP.Name = "drpMetaAlmacenP"
        Me.drpMetaAlmacenP.OddRowStyle = Style22
        Me.drpMetaAlmacenP.RecordSelectorStyle = Style23
        Me.drpMetaAlmacenP.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.drpMetaAlmacenP.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.drpMetaAlmacenP.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.drpMetaAlmacenP.ScrollTips = False
        Me.drpMetaAlmacenP.Size = New System.Drawing.Size(277, 135)
        Me.drpMetaAlmacenP.Style = Style24
        Me.drpMetaAlmacenP.TabIndex = 52
        Me.drpMetaAlmacenP.TabStop = False
        Me.drpMetaAlmacenP.Text = "C1TrueDBDropdown1"
        Me.drpMetaAlmacenP.ValueMember = "IdMetaAlmacen"
        Me.drpMetaAlmacenP.ValueTranslate = True
        Me.drpMetaAlmacenP.Visible = False
        Me.drpMetaAlmacenP.PropBag = resources.GetString("drpMetaAlmacenP.PropBag")
        '
        'dropUnidadesMedidaP
        '
        Me.dropUnidadesMedidaP.AllowColMove = True
        Me.dropUnidadesMedidaP.AllowColSelect = True
        Me.dropUnidadesMedidaP.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.dropUnidadesMedidaP.AlternatingRows = False
        Me.dropUnidadesMedidaP.CaptionStyle = Style25
        Me.dropUnidadesMedidaP.ColumnCaptionHeight = 17
        Me.dropUnidadesMedidaP.ColumnFooterHeight = 17
        Me.dropUnidadesMedidaP.DataSource = Me.bsUnidadMedidaP
        Me.dropUnidadesMedidaP.DisplayMember = "Nombre"
        Me.dropUnidadesMedidaP.EvenRowStyle = Style26
        Me.dropUnidadesMedidaP.FetchRowStyles = False
        Me.dropUnidadesMedidaP.FooterStyle = Style27
        Me.dropUnidadesMedidaP.HeadingStyle = Style28
        Me.dropUnidadesMedidaP.HighLightRowStyle = Style29
        Me.dropUnidadesMedidaP.Images.Add(CType(resources.GetObject("dropUnidadesMedidaP.Images"), System.Drawing.Image))
        Me.dropUnidadesMedidaP.Location = New System.Drawing.Point(398, 73)
        Me.dropUnidadesMedidaP.Name = "dropUnidadesMedidaP"
        Me.dropUnidadesMedidaP.OddRowStyle = Style30
        Me.dropUnidadesMedidaP.RecordSelectorStyle = Style31
        Me.dropUnidadesMedidaP.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.dropUnidadesMedidaP.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.dropUnidadesMedidaP.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.dropUnidadesMedidaP.ScrollTips = False
        Me.dropUnidadesMedidaP.Size = New System.Drawing.Size(326, 135)
        Me.dropUnidadesMedidaP.Style = Style32
        Me.dropUnidadesMedidaP.TabIndex = 51
        Me.dropUnidadesMedidaP.TabStop = False
        Me.dropUnidadesMedidaP.Text = "C1TrueDBDropdown1"
        Me.dropUnidadesMedidaP.ValueMember = "IdUnidadMedida"
        Me.dropUnidadesMedidaP.ValueTranslate = True
        Me.dropUnidadesMedidaP.Visible = False
        Me.dropUnidadesMedidaP.PropBag = resources.GetString("dropUnidadesMedidaP.PropBag")
        '
        'grdSubProductos
        '
        Me.grdSubProductos.AllowAddNew = True
        Me.grdSubProductos.DataSource = Me.bsSubProductos
        Me.grdSubProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdSubProductos.Images.Add(CType(resources.GetObject("grdSubProductos.Images"), System.Drawing.Image))
        Me.grdSubProductos.Images.Add(CType(resources.GetObject("grdSubProductos.Images1"), System.Drawing.Image))
        Me.grdSubProductos.Images.Add(CType(resources.GetObject("grdSubProductos.Images2"), System.Drawing.Image))
        Me.grdSubProductos.Location = New System.Drawing.Point(0, 0)
        Me.grdSubProductos.Name = "grdSubProductos"
        Me.grdSubProductos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdSubProductos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdSubProductos.PreviewInfo.ZoomFactor = 75.0R
        Me.grdSubProductos.PrintInfo.PageSettings = CType(resources.GetObject("grdSubProductos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdSubProductos.Size = New System.Drawing.Size(855, 286)
        Me.grdSubProductos.TabIndex = 30
        Me.grdSubProductos.Text = "AzTrueDBGrid1"
        Me.grdSubProductos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdSubProductos.PropBag = resources.GetString("grdSubProductos.PropBag")
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.btnInsumosAdd)
        Me.C1CommandHolder1.Commands.Add(Me.btnProductosAdd)
        Me.C1CommandHolder1.Owner = Me
        '
        'btnInsumosAdd
        '
        Me.btnInsumosAdd.Image = CType(resources.GetObject("btnInsumosAdd.Image"), System.Drawing.Image)
        Me.btnInsumosAdd.Name = "btnInsumosAdd"
        Me.btnInsumosAdd.ShortcutText = ""
        Me.btnInsumosAdd.Text = "Agregar Insumo"
        '
        'btnProductosAdd
        '
        Me.btnProductosAdd.Image = CType(resources.GetObject("btnProductosAdd.Image"), System.Drawing.Image)
        Me.btnProductosAdd.Name = "btnProductosAdd"
        Me.btnProductosAdd.ShortcutText = ""
        Me.btnProductosAdd.Text = "Agregar Producto"
        '
        'cboUnidadMedida
        '
        Me.cboUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnidadMedida.FormattingEnabled = True
        Me.cboUnidadMedida.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboUnidadMedida.ItemsTable = Nothing
        Me.cboUnidadMedida.Location = New System.Drawing.Point(353, 158)
        Me.cboUnidadMedida.Name = "cboUnidadMedida"
        Me.cboUnidadMedida.Size = New System.Drawing.Size(182, 21)
        Me.cboUnidadMedida.TabIndex = 36
        Me.cboUnidadMedida.UIName = Nothing
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
        Me.selCuenta.Location = New System.Drawing.Point(121, 134)
        Me.selCuenta.Name = "selCuenta"
        Me.selCuenta.Size = New System.Drawing.Size(414, 23)
        Me.selCuenta.TabIndex = 31
        Me.selCuenta.TextWidth = 100
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
        Me.selArticuloStock.Location = New System.Drawing.Point(121, 111)
        Me.selArticuloStock.Name = "selArticuloStock"
        Me.selArticuloStock.ShowEditButton = True
        Me.selArticuloStock.Size = New System.Drawing.Size(414, 23)
        Me.selArticuloStock.TabIndex = 23
        Me.selArticuloStock.TextWidth = 100
        '
        'ProductosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 564)
        Me.Controls.Add(Me.tabAreas)
        Me.Controls.Add(Me.chkExigirRecepcion)
        Me.Controls.Add(Me.chkEntregasParciales)
        Me.Controls.Add(Me.txtMultiplos)
        Me.Controls.Add(Me.lblMultiplos)
        Me.Controls.Add(Me.cboUnidadMedida)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.lblCuenta)
        Me.Controls.Add(Me.selCuenta)
        Me.Controls.Add(Me.lblArticulo)
        Me.Controls.Add(Me.selArticuloStock)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Name = "ProductosForm"
        Me.Text = "ProductosForm"
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.lblProducto, 0)
        Me.Controls.SetChildIndex(Me.selArticuloStock, 0)
        Me.Controls.SetChildIndex(Me.lblArticulo, 0)
        Me.Controls.SetChildIndex(Me.selCuenta, 0)
        Me.Controls.SetChildIndex(Me.lblCuenta, 0)
        Me.Controls.SetChildIndex(Me.lblCantidad, 0)
        Me.Controls.SetChildIndex(Me.txtCantidad, 0)
        Me.Controls.SetChildIndex(Me.cboUnidadMedida, 0)
        Me.Controls.SetChildIndex(Me.lblMultiplos, 0)
        Me.Controls.SetChildIndex(Me.txtMultiplos, 0)
        Me.Controls.SetChildIndex(Me.chkEntregasParciales, 0)
        Me.Controls.SetChildIndex(Me.chkExigirRecepcion, 0)
        Me.Controls.SetChildIndex(Me.tabAreas, 0)
        CType(Me.bsInsumos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabAreas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAreas.ResumeLayout(False)
        Me.pagInsumos.ResumeLayout(False)
        CType(Me.dropMetaAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsMetaAlmacenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dropUnidadMedida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsUnidadMedida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdInsumos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagEnsambles.ResumeLayout(False)
        CType(Me.drpMetaAlmacenP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dropUnidadesMedidaP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsUnidadMedidaP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSubProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSubProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Facade = New ProductoFacade
        LicenseModule = Kernel.Licensing.LicenseModule.Manufacturing
    End Sub
    Friend WithEvents lblProducto As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtDescripcion As Azteca.Windows.Controls.CITextBox
    Friend WithEvents selArticuloStock As Azteca.Windows.Inventario.ArticuloStockSelector
    Friend WithEvents lblArticulo As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCuenta As Azteca.Windows.Controls.CILabel
    Friend WithEvents selCuenta As Azteca.Windows.Contabilidad.CuentaSelector
    Friend WithEvents lblCantidad As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCantidad As Azteca.Windows.Controls.CITextBox
    Friend WithEvents cboUnidadMedida As Azteca.Windows.Inventario.UnidadesMedidaComboBox
    Friend WithEvents lblMultiplos As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtMultiplos As Azteca.Windows.Controls.CITextBox
    Friend WithEvents chkEntregasParciales As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents chkExigirRecepcion As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents tabAreas As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents lnkcmd As C1.Win.C1Command.C1Command
    Friend WithEvents btnInsumoAdd As C1.Win.C1Command.C1Command
    Friend WithEvents pagInsumos As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagEnsambles As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents btnInsumosAdd As C1.Win.C1Command.C1Command
    Private WithEvents bsInsumos As System.Windows.Forms.BindingSource
    Private WithEvents colIdInsumo As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents colArticuloStock As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents colUnidadMedida As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents colCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents colMetaAlmacen As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents colPorcMerma As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents colOpcional As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btnProductosAdd As C1.Win.C1Command.C1Command
    Friend WithEvents grdInsumos As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents grdSubProductos As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents dropUnidadMedida As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents dropUnidadesMedidaP As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents dropMetaAlmacen As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents drpMetaAlmacenP As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Private WithEvents bsSubProductos As System.Windows.Forms.BindingSource
    Private WithEvents bsUnidadMedida As System.Windows.Forms.BindingSource
    Private WithEvents bsUnidadMedidaP As System.Windows.Forms.BindingSource
    Private WithEvents bsMetaAlmacenes As System.Windows.Forms.BindingSource

End Class
