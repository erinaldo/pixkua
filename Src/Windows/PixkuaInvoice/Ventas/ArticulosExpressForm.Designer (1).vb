<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArticulosExpressForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ArticulosExpressForm))
        Dim Style1 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style2 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style3 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style4 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style5 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style6 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style7 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style8 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.imlArt = New System.Windows.Forms.ImageList(Me.components)
        Me.tabArticulos = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagListas = New C1.Win.C1Command.C1DockingTabPage()
        Me.grdListasPrecio = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsListasPrecio = New System.Windows.Forms.BindingSource(Me.components)
        Me.AzToolBar1 = New Azteca.Windows.Controls.AZToolBar()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdAddListaPrecios = New C1.Win.C1Command.C1Command()
        Me.btnAgregarPresentacion = New C1.Win.C1Command.C1CommandLink()
        Me.cboAlmacen = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.cboTipoUnidad = New Azteca.Windows.Inventario.TiposUnidadComboBox()
        Me.cboUnidadMedida = New Azteca.Windows.Inventario.UnidadesMedidaComboBox()
        Me.grpImpuestos = New Azteca.Windows.Controls.CIGroupBox()
        Me.CiLabel14 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel13 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel12 = New Azteca.Windows.Controls.CILabel()
        Me.cboImpuesto3 = New Azteca.Windows.Contabilidad.ImpuestosComboBox()
        Me.nudPorcRetencion3 = New Azteca.Windows.Controls.CINumericUpDown()
        Me.CiLabel10 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel11 = New Azteca.Windows.Controls.CILabel()
        Me.cboImpuesto2 = New Azteca.Windows.Contabilidad.ImpuestosComboBox()
        Me.nudPorcRetencion2 = New Azteca.Windows.Controls.CINumericUpDown()
        Me.CiLabel8 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel9 = New Azteca.Windows.Controls.CILabel()
        Me.cboImpuesto1 = New Azteca.Windows.Contabilidad.ImpuestosComboBox()
        Me.nudPorcRetencion1 = New Azteca.Windows.Controls.CINumericUpDown()
        Me.CiLabel5 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel7 = New Azteca.Windows.Controls.CILabel()
        Me.cboDivisa = New Azteca.Windows.Contabilidad.DivisasComboBox()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        CType(Me.tabArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabArticulos.SuspendLayout()
        Me.pagListas.SuspendLayout()
        CType(Me.grdListasPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsListasPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpImpuestos.SuspendLayout()
        CType(Me.nudPorcRetencion3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPorcRetencion2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPorcRetencion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(6, 106)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(47, 13)
        Me.CiLabel1.TabIndex = 0
        Me.CiLabel1.Text = "Nombre:"
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(6, 129)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(109, 13)
        Me.CiLabel3.TabIndex = 2
        Me.CiLabel3.Text = "Unidad de Inventario:"
        '
        'imlArt
        '
        Me.imlArt.ImageStream = CType(resources.GetObject("imlArt.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlArt.TransparentColor = System.Drawing.Color.Transparent
        Me.imlArt.Images.SetKeyName(0, "General")
        Me.imlArt.Images.SetKeyName(1, "Series")
        '
        'tabArticulos
        '
        Me.tabArticulos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabArticulos.Controls.Add(Me.pagListas)
        Me.tabArticulos.ImageList = Me.imlArt
        Me.tabArticulos.Location = New System.Drawing.Point(0, 271)
        Me.tabArticulos.Name = "tabArticulos"
        Me.tabArticulos.Size = New System.Drawing.Size(487, 265)
        Me.tabArticulos.TabIndex = 7
        Me.tabArticulos.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabArticulos.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabArticulos.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagListas
        '
        Me.pagListas.Controls.Add(Me.grdListasPrecio)
        Me.pagListas.Controls.Add(Me.AzToolBar1)
        Me.pagListas.Controls.Add(Me.cboAlmacen)
        Me.pagListas.ImageIndex = 1
        Me.pagListas.Location = New System.Drawing.Point(1, 41)
        Me.pagListas.Name = "pagListas"
        Me.pagListas.Size = New System.Drawing.Size(485, 223)
        Me.pagListas.TabIndex = 1
        Me.pagListas.Text = "        Listas de Precios  "
        '
        'grdListasPrecio
        '
        Me.grdListasPrecio.DataSource = Me.bsListasPrecio
        Me.grdListasPrecio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdListasPrecio.FilterBar = True
        Me.grdListasPrecio.Images.Add(CType(resources.GetObject("grdListasPrecio.Images"), System.Drawing.Image))
        Me.grdListasPrecio.Images.Add(CType(resources.GetObject("grdListasPrecio.Images1"), System.Drawing.Image))
        Me.grdListasPrecio.Location = New System.Drawing.Point(0, 38)
        Me.grdListasPrecio.Name = "grdListasPrecio"
        Me.grdListasPrecio.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdListasPrecio.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdListasPrecio.PreviewInfo.ZoomFactor = 75.0R
        Me.grdListasPrecio.PrintInfo.PageSettings = CType(resources.GetObject("grdListasPrecio.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdListasPrecio.Size = New System.Drawing.Size(485, 185)
        Me.grdListasPrecio.TabIndex = 1
        Me.grdListasPrecio.Text = "AzTrueDBGrid1"
        Me.grdListasPrecio.PropBag = resources.GetString("grdListasPrecio.PropBag")
        '
        'AzToolBar1
        '
        Me.AzToolBar1.AccessibleName = "Tool Bar"
        Me.AzToolBar1.AutoSize = False
        Me.AzToolBar1.CommandHolder = Me.C1CommandHolder1
        Me.AzToolBar1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.btnAgregarPresentacion})
        Me.AzToolBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.AzToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.AzToolBar1.MinButtonSize = 32
        Me.AzToolBar1.Movable = False
        Me.AzToolBar1.Name = "AzToolBar1"
        Me.AzToolBar1.Size = New System.Drawing.Size(485, 38)
        Me.AzToolBar1.Text = "AzToolBar1"
        Me.AzToolBar1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdAddListaPrecios)
        Me.C1CommandHolder1.Owner = Me
        '
        'cmdAddListaPrecios
        '
        Me.cmdAddListaPrecios.Image = CType(resources.GetObject("cmdAddListaPrecios.Image"), System.Drawing.Image)
        Me.cmdAddListaPrecios.Name = "cmdAddListaPrecios"
        Me.cmdAddListaPrecios.ShortcutText = ""
        Me.cmdAddListaPrecios.Text = "Agregar Lista de Precios"
        '
        'btnAgregarPresentacion
        '
        Me.btnAgregarPresentacion.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnAgregarPresentacion.Command = Me.cmdAddListaPrecios
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
        Me.cboAlmacen.DisplayMember = "Nombre"
        Me.cboAlmacen.EvenRowStyle = Style2
        Me.cboAlmacen.ExtendRightColumn = True
        Me.cboAlmacen.FetchRowStyles = False
        Me.cboAlmacen.FooterStyle = Style3
        Me.cboAlmacen.HeadingStyle = Style4
        Me.cboAlmacen.HighLightRowStyle = Style5
        Me.cboAlmacen.Images.Add(CType(resources.GetObject("cboAlmacen.Images"), System.Drawing.Image))
        Me.cboAlmacen.Location = New System.Drawing.Point(196, 67)
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
        'txtNombre
        '
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(121, 103)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(361, 20)
        Me.txtNombre.TabIndex = 1
        '
        'cboTipoUnidad
        '
        Me.cboTipoUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoUnidad.FormattingEnabled = True
        Me.cboTipoUnidad.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboTipoUnidad.ItemsTable = Nothing
        Me.cboTipoUnidad.Location = New System.Drawing.Point(121, 126)
        Me.cboTipoUnidad.Name = "cboTipoUnidad"
        Me.cboTipoUnidad.RequiredField = True
        Me.cboTipoUnidad.Size = New System.Drawing.Size(165, 21)
        Me.cboTipoUnidad.TabIndex = 3
        Me.cboTipoUnidad.UIName = "Tipo Unidad"
        '
        'cboUnidadMedida
        '
        Me.cboUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnidadMedida.FormattingEnabled = True
        Me.cboUnidadMedida.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboUnidadMedida.ItemsTable = Nothing
        Me.cboUnidadMedida.Location = New System.Drawing.Point(301, 126)
        Me.cboUnidadMedida.Name = "cboUnidadMedida"
        Me.cboUnidadMedida.RequiredField = True
        Me.cboUnidadMedida.Size = New System.Drawing.Size(181, 21)
        Me.cboUnidadMedida.TabIndex = 4
        Me.cboUnidadMedida.UIName = "Unidad Medida"
        '
        'grpImpuestos
        '
        Me.grpImpuestos.Controls.Add(Me.CiLabel14)
        Me.grpImpuestos.Controls.Add(Me.CiLabel13)
        Me.grpImpuestos.Controls.Add(Me.CiLabel12)
        Me.grpImpuestos.Controls.Add(Me.cboImpuesto3)
        Me.grpImpuestos.Controls.Add(Me.nudPorcRetencion3)
        Me.grpImpuestos.Controls.Add(Me.CiLabel10)
        Me.grpImpuestos.Controls.Add(Me.CiLabel11)
        Me.grpImpuestos.Controls.Add(Me.cboImpuesto2)
        Me.grpImpuestos.Controls.Add(Me.nudPorcRetencion2)
        Me.grpImpuestos.Controls.Add(Me.CiLabel8)
        Me.grpImpuestos.Controls.Add(Me.CiLabel9)
        Me.grpImpuestos.Controls.Add(Me.cboImpuesto1)
        Me.grpImpuestos.Controls.Add(Me.nudPorcRetencion1)
        Me.grpImpuestos.Controls.Add(Me.CiLabel5)
        Me.grpImpuestos.Controls.Add(Me.CiLabel7)
        Me.grpImpuestos.ForeColor = System.Drawing.SystemColors.Highlight
        Me.grpImpuestos.Location = New System.Drawing.Point(1, 149)
        Me.grpImpuestos.Name = "grpImpuestos"
        Me.grpImpuestos.Size = New System.Drawing.Size(481, 89)
        Me.grpImpuestos.TabIndex = 5
        Me.grpImpuestos.TabStop = False
        Me.grpImpuestos.Text = "Impuestos"
        '
        'CiLabel14
        '
        Me.CiLabel14.AutoSize = True
        Me.CiLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiLabel14.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CiLabel14.Location = New System.Drawing.Point(365, 66)
        Me.CiLabel14.Name = "CiLabel14"
        Me.CiLabel14.Size = New System.Drawing.Size(21, 16)
        Me.CiLabel14.TabIndex = 14
        Me.CiLabel14.Text = "%"
        '
        'CiLabel13
        '
        Me.CiLabel13.AutoSize = True
        Me.CiLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiLabel13.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CiLabel13.Location = New System.Drawing.Point(365, 43)
        Me.CiLabel13.Name = "CiLabel13"
        Me.CiLabel13.Size = New System.Drawing.Size(21, 16)
        Me.CiLabel13.TabIndex = 11
        Me.CiLabel13.Text = "%"
        '
        'CiLabel12
        '
        Me.CiLabel12.AutoSize = True
        Me.CiLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiLabel12.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CiLabel12.Location = New System.Drawing.Point(365, 20)
        Me.CiLabel12.Name = "CiLabel12"
        Me.CiLabel12.Size = New System.Drawing.Size(21, 16)
        Me.CiLabel12.TabIndex = 8
        Me.CiLabel12.Text = "%"
        '
        'cboImpuesto3
        '
        Me.cboImpuesto3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboImpuesto3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.cboImpuesto3.FormattingEnabled = True
        Me.cboImpuesto3.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboImpuesto3.ItemsTable = Nothing
        Me.cboImpuesto3.Location = New System.Drawing.Point(120, 61)
        Me.cboImpuesto3.Name = "cboImpuesto3"
        Me.cboImpuesto3.Size = New System.Drawing.Size(110, 21)
        Me.cboImpuesto3.TabIndex = 5
        Me.cboImpuesto3.UIName = Nothing
        '
        'nudPorcRetencion3
        '
        Me.nudPorcRetencion3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.nudPorcRetencion3.HighlightColor = System.Drawing.SystemColors.Info
        Me.nudPorcRetencion3.Location = New System.Drawing.Point(301, 62)
        Me.nudPorcRetencion3.Name = "nudPorcRetencion3"
        Me.nudPorcRetencion3.Size = New System.Drawing.Size(58, 20)
        Me.nudPorcRetencion3.TabIndex = 6
        '
        'CiLabel10
        '
        Me.CiLabel10.AutoSize = True
        Me.CiLabel10.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CiLabel10.Location = New System.Drawing.Point(52, 64)
        Me.CiLabel10.Name = "CiLabel10"
        Me.CiLabel10.Size = New System.Drawing.Size(62, 13)
        Me.CiLabel10.TabIndex = 4
        Me.CiLabel10.Text = "Impuesto 3:"
        '
        'CiLabel11
        '
        Me.CiLabel11.AutoSize = True
        Me.CiLabel11.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CiLabel11.Location = New System.Drawing.Point(236, 64)
        Me.CiLabel11.Name = "CiLabel11"
        Me.CiLabel11.Size = New System.Drawing.Size(59, 13)
        Me.CiLabel11.TabIndex = 12
        Me.CiLabel11.Text = "Retención:"
        '
        'cboImpuesto2
        '
        Me.cboImpuesto2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboImpuesto2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.cboImpuesto2.FormattingEnabled = True
        Me.cboImpuesto2.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboImpuesto2.ItemsTable = Nothing
        Me.cboImpuesto2.Location = New System.Drawing.Point(120, 38)
        Me.cboImpuesto2.Name = "cboImpuesto2"
        Me.cboImpuesto2.Size = New System.Drawing.Size(110, 21)
        Me.cboImpuesto2.TabIndex = 3
        Me.cboImpuesto2.UIName = Nothing
        '
        'nudPorcRetencion2
        '
        Me.nudPorcRetencion2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.nudPorcRetencion2.HighlightColor = System.Drawing.SystemColors.Info
        Me.nudPorcRetencion2.Location = New System.Drawing.Point(301, 40)
        Me.nudPorcRetencion2.Name = "nudPorcRetencion2"
        Me.nudPorcRetencion2.Size = New System.Drawing.Size(58, 20)
        Me.nudPorcRetencion2.TabIndex = 4
        '
        'CiLabel8
        '
        Me.CiLabel8.AutoSize = True
        Me.CiLabel8.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CiLabel8.Location = New System.Drawing.Point(52, 41)
        Me.CiLabel8.Name = "CiLabel8"
        Me.CiLabel8.Size = New System.Drawing.Size(62, 13)
        Me.CiLabel8.TabIndex = 2
        Me.CiLabel8.Text = "Impuesto 2:"
        '
        'CiLabel9
        '
        Me.CiLabel9.AutoSize = True
        Me.CiLabel9.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CiLabel9.Location = New System.Drawing.Point(236, 41)
        Me.CiLabel9.Name = "CiLabel9"
        Me.CiLabel9.Size = New System.Drawing.Size(59, 13)
        Me.CiLabel9.TabIndex = 9
        Me.CiLabel9.Text = "Retención:"
        '
        'cboImpuesto1
        '
        Me.cboImpuesto1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboImpuesto1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.cboImpuesto1.FormattingEnabled = True
        Me.cboImpuesto1.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboImpuesto1.ItemsTable = Nothing
        Me.cboImpuesto1.Location = New System.Drawing.Point(120, 15)
        Me.cboImpuesto1.Name = "cboImpuesto1"
        Me.cboImpuesto1.Size = New System.Drawing.Size(110, 21)
        Me.cboImpuesto1.TabIndex = 0
        Me.cboImpuesto1.UIName = Nothing
        '
        'nudPorcRetencion1
        '
        Me.nudPorcRetencion1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.nudPorcRetencion1.HighlightColor = System.Drawing.SystemColors.Info
        Me.nudPorcRetencion1.Location = New System.Drawing.Point(301, 18)
        Me.nudPorcRetencion1.Name = "nudPorcRetencion1"
        Me.nudPorcRetencion1.Size = New System.Drawing.Size(58, 20)
        Me.nudPorcRetencion1.TabIndex = 2
        '
        'CiLabel5
        '
        Me.CiLabel5.AutoSize = True
        Me.CiLabel5.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CiLabel5.Location = New System.Drawing.Point(52, 18)
        Me.CiLabel5.Name = "CiLabel5"
        Me.CiLabel5.Size = New System.Drawing.Size(62, 13)
        Me.CiLabel5.TabIndex = 0
        Me.CiLabel5.Text = "Impuesto 1:"
        '
        'CiLabel7
        '
        Me.CiLabel7.AutoSize = True
        Me.CiLabel7.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CiLabel7.Location = New System.Drawing.Point(236, 18)
        Me.CiLabel7.Name = "CiLabel7"
        Me.CiLabel7.Size = New System.Drawing.Size(59, 13)
        Me.CiLabel7.TabIndex = 1
        Me.CiLabel7.Text = "Retención:"
        '
        'cboDivisa
        '
        Me.cboDivisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDivisa.FormattingEnabled = True
        Me.cboDivisa.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboDivisa.ItemsTable = Nothing
        Me.cboDivisa.Location = New System.Drawing.Point(121, 244)
        Me.cboDivisa.Name = "cboDivisa"
        Me.cboDivisa.RequiredField = True
        Me.cboDivisa.Size = New System.Drawing.Size(239, 21)
        Me.cboDivisa.TabIndex = 6
        Me.cboDivisa.UIName = "Divisa"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel2.Location = New System.Drawing.Point(53, 247)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(39, 13)
        Me.CiLabel2.TabIndex = 7
        Me.CiLabel2.Text = "Divisa:"
        '
        'ArticulosExpressForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 557)
        Me.Controls.Add(Me.cboDivisa)
        Me.Controls.Add(Me.CiLabel2)
        Me.Controls.Add(Me.grpImpuestos)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.tabArticulos)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.CiLabel3)
        Me.Controls.Add(Me.cboTipoUnidad)
        Me.Controls.Add(Me.cboUnidadMedida)
        Me.Name = "ArticulosExpressForm"
        Me.Text = "ArticulosExpressForm"
        Me.Controls.SetChildIndex(Me.cboUnidadMedida, 0)
        Me.Controls.SetChildIndex(Me.cboTipoUnidad, 0)
        Me.Controls.SetChildIndex(Me.CiLabel3, 0)
        Me.Controls.SetChildIndex(Me.CiLabel1, 0)
        Me.Controls.SetChildIndex(Me.tabArticulos, 0)
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.grpImpuestos, 0)
        Me.Controls.SetChildIndex(Me.CiLabel2, 0)
        Me.Controls.SetChildIndex(Me.cboDivisa, 0)
        CType(Me.tabArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabArticulos.ResumeLayout(False)
        Me.pagListas.ResumeLayout(False)
        CType(Me.grdListasPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsListasPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpImpuestos.ResumeLayout(False)
        Me.grpImpuestos.PerformLayout()
        CType(Me.nudPorcRetencion3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPorcRetencion2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPorcRetencion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Public WithEvents cboTipoUnidad As Azteca.Windows.Inventario.TiposUnidadComboBox
    Public WithEvents cboUnidadMedida As Azteca.Windows.Inventario.UnidadesMedidaComboBox
    Friend WithEvents tabArticulos As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagListas As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents cboAlmacen As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents grdListasPrecio As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents cmdAddListaPrecios As C1.Win.C1Command.C1Command
    Friend WithEvents AzToolBar1 As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents btnAgregarPresentacion As C1.Win.C1Command.C1CommandLink

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Facade = New Azteca.Business.Ventas.ArticuloFacade
    End Sub
    Private WithEvents imlArt As System.Windows.Forms.ImageList
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Private WithEvents bsListasPrecio As System.Windows.Forms.BindingSource
    Friend WithEvents grpImpuestos As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents CiLabel14 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel13 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel12 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboImpuesto3 As Azteca.Windows.Contabilidad.ImpuestosComboBox
    Friend WithEvents nudPorcRetencion3 As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents CiLabel10 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel11 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboImpuesto2 As Azteca.Windows.Contabilidad.ImpuestosComboBox
    Friend WithEvents nudPorcRetencion2 As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents CiLabel8 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel9 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboImpuesto1 As Azteca.Windows.Contabilidad.ImpuestosComboBox
    Friend WithEvents nudPorcRetencion1 As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents CiLabel5 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel7 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboDivisa As Azteca.Windows.Contabilidad.DivisasComboBox
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel

End Class
