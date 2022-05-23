<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeguimientoEgresosForm
    Inherits Azteca.Windows.Forms.BaseForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SeguimientoEgresosForm))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Gastos", "Poliza", "Poliza2"}, 0)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Facturas de Gasto", 1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Requisiciones", 2)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Ordenes", 3)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Recepciones", 4)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Facturas de Entregas", 5)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Contrarecibos", 6)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Pagos", 7)
        Dim DesignerRectTracker1 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim CBlendItems1 As Azteca.Windows.Controls.cBlendItems = New Azteca.Windows.Controls.cBlendItems()
        Dim DesignerRectTracker2 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Me.dtpFechaIni = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.lblFechaFin = New Azteca.Windows.Controls.CILabel()
        Me.dtpFechaFin = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.lblFechaIni = New Azteca.Windows.Controls.CILabel()
        Me.iLst64 = New System.Windows.Forms.ImageList(Me.components)
        Me.ColorWithAlpha1 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha2 = New Azteca.Windows.ColorWithAlpha()
        Me.lvwDetalle = New Azteca.Windows.Controls.CIListView()
        Me.lvwDocumentos = New Azteca.Windows.Controls.CIListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grdGastos = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsSeguimiento = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboDocumentos = New Azteca.Windows.Controls.CIComboBox()
        Me.lblDocumento = New Azteca.Windows.Controls.CILabel()
        Me.txtDocumento = New Azteca.Windows.Controls.CITextBox()
        Me.lblFolioDoc = New Azteca.Windows.Controls.CILabel()
        Me.lblFactura = New Azteca.Windows.Controls.CILabel()
        Me.txtFactura = New Azteca.Windows.Controls.CITextBox()
        Me.lblSerie = New Azteca.Windows.Controls.CILabel()
        Me.txtSerie = New Azteca.Windows.Controls.CITextBox()
        Me.lblFolio = New Azteca.Windows.Controls.CILabel()
        Me.txtFolio = New Azteca.Windows.Controls.CITextBox()
        Me.tbPresupuesto = New Azteca.Windows.Controls.CIToolBar()
        Me.btnConsultar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.splitDocumentos = New System.Windows.Forms.SplitContainer()
        Me.pnlSeleccion = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha3 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha4 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha5 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha6 = New Azteca.Windows.ColorWithAlpha()
        Me.btnClosePol = New Azteca.Windows.Controls.ButtonPlus()
        Me.grdPolizas = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsPolizas = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblPoliza = New Azteca.Windows.Controls.CILabel()
        Me.cboChequeras = New Azteca.Windows.Tesoreria.ChequerasComboBox()
        Me.lblChequera = New Azteca.Windows.Controls.CILabel()
        Me.cboCaja = New Azteca.Windows.Tesoreria.CajasComboBox()
        Me.lblCaja = New Azteca.Windows.Controls.CILabel()
        CType(Me.grdGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSeguimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbPresupuesto.SuspendLayout()
        CType(Me.splitDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitDocumentos.Panel1.SuspendLayout()
        Me.splitDocumentos.Panel2.SuspendLayout()
        Me.splitDocumentos.SuspendLayout()
        Me.pnlSeleccion.SuspendLayout()
        CType(Me.grdPolizas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPolizas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFechaIni.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaIni.Location = New System.Drawing.Point(152, 46)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(211, 20)
        Me.dtpFechaIni.TabIndex = 66
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Location = New System.Drawing.Point(371, 50)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(65, 13)
        Me.lblFechaFin.TabIndex = 69
        Me.lblFechaFin.Text = "Fecha Final:"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaFin.Location = New System.Drawing.Point(442, 46)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(210, 20)
        Me.dtpFechaFin.TabIndex = 68
        '
        'lblFechaIni
        '
        Me.lblFechaIni.AutoSize = True
        Me.lblFechaIni.Location = New System.Drawing.Point(72, 49)
        Me.lblFechaIni.Name = "lblFechaIni"
        Me.lblFechaIni.Size = New System.Drawing.Size(70, 13)
        Me.lblFechaIni.TabIndex = 67
        Me.lblFechaIni.Text = "Fecha Inicial:"
        '
        'iLst64
        '
        Me.iLst64.ImageStream = CType(resources.GetObject("iLst64.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.iLst64.TransparentColor = System.Drawing.Color.Transparent
        Me.iLst64.Images.SetKeyName(0, "payment_64.png")
        Me.iLst64.Images.SetKeyName(1, "invoice_64.png")
        Me.iLst64.Images.SetKeyName(2, "Requisicion_64.png")
        Me.iLst64.Images.SetKeyName(3, "Orden.png")
        Me.iLst64.Images.SetKeyName(4, "dispatch_order_64.png")
        Me.iLst64.Images.SetKeyName(5, "invoice_64.png")
        Me.iLst64.Images.SetKeyName(6, "stamped_paper_64.png")
        Me.iLst64.Images.SetKeyName(7, "check_64.png")
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.White
        Me.ColorWithAlpha1.Parent = Nothing
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.SystemColors.ActiveCaption
        Me.ColorWithAlpha2.Parent = Nothing
        '
        'lvwDetalle
        '
        Me.lvwDetalle.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwDetalle.FullRowSelect = True
        Me.lvwDetalle.HideSelection = False
        Me.lvwDetalle.LargeImageList = Me.iLst64
        Me.lvwDetalle.Location = New System.Drawing.Point(0, 0)
        Me.lvwDetalle.MultiSelect = False
        Me.lvwDetalle.Name = "lvwDetalle"
        Me.lvwDetalle.Size = New System.Drawing.Size(1039, 146)
        Me.lvwDetalle.SmallImageList = Me.iLst64
        Me.lvwDetalle.TabIndex = 85
        Me.lvwDetalle.UseCompatibleStateImageBehavior = False
        '
        'lvwDocumentos
        '
        Me.lvwDocumentos.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwDocumentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwDocumentos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvwDocumentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwDocumentos.FullRowSelect = True
        Me.lvwDocumentos.HideSelection = False
        Me.lvwDocumentos.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8})
        Me.lvwDocumentos.LargeImageList = Me.iLst64
        Me.lvwDocumentos.Location = New System.Drawing.Point(0, 0)
        Me.lvwDocumentos.MultiSelect = False
        Me.lvwDocumentos.Name = "lvwDocumentos"
        Me.lvwDocumentos.Size = New System.Drawing.Size(1039, 101)
        Me.lvwDocumentos.SmallImageList = Me.iLst64
        Me.lvwDocumentos.TabIndex = 86
        Me.lvwDocumentos.UseCompatibleStateImageBehavior = False
        '
        'grdGastos
        '
        Me.grdGastos.AlternatingRows = True
        Me.grdGastos.DataSource = Me.bsSeguimiento
        Me.grdGastos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grdGastos.FilterBar = True
        Me.grdGastos.Images.Add(CType(resources.GetObject("grdGastos.Images"), System.Drawing.Image))
        Me.grdGastos.Location = New System.Drawing.Point(0, 146)
        Me.grdGastos.Name = "grdGastos"
        Me.grdGastos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdGastos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdGastos.PreviewInfo.ZoomFactor = 75.0R
        Me.grdGastos.PrintInfo.PageSettings = CType(resources.GetObject("grdGastos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdGastos.RowHeight = 17
        Me.grdGastos.Size = New System.Drawing.Size(1039, 125)
        Me.grdGastos.TabIndex = 71
        Me.grdGastos.Text = "AzTrueDBGrid1"
        Me.grdGastos.PropBag = resources.GetString("grdGastos.PropBag")
        '
        'cboDocumentos
        '
        Me.cboDocumentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDocumentos.FormattingEnabled = True
        Me.cboDocumentos.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboDocumentos.Items.AddRange(New Object() {"ID. de Gastos", "Factura Recibida de Gasto", "ID. de Requisicion", "ID. de Orden de Compra", "ID. de Recepciones de Ordenes de Compra", "Factura Recibida de Orden", "ID. de Contrarecibo", "ID. de Pago", "Folio de Pago"})
        Me.cboDocumentos.ItemsTable = Nothing
        Me.cboDocumentos.Location = New System.Drawing.Point(153, 71)
        Me.cboDocumentos.Name = "cboDocumentos"
        Me.cboDocumentos.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboDocumentos.Size = New System.Drawing.Size(210, 21)
        Me.cboDocumentos.TabIndex = 73
        Me.cboDocumentos.UIName = Nothing
        '
        'lblDocumento
        '
        Me.lblDocumento.AutoSize = True
        Me.lblDocumento.Location = New System.Drawing.Point(73, 75)
        Me.lblDocumento.Name = "lblDocumento"
        Me.lblDocumento.Size = New System.Drawing.Size(65, 13)
        Me.lblDocumento.TabIndex = 74
        Me.lblDocumento.Text = "Documento:"
        '
        'txtDocumento
        '
        Me.txtDocumento.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtDocumento.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtDocumento.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtDocumento.Location = New System.Drawing.Point(442, 71)
        Me.txtDocumento.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDocumento.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(210, 20)
        Me.txtDocumento.TabIndex = 76
        Me.txtDocumento.Visible = False
        '
        'lblFolioDoc
        '
        Me.lblFolioDoc.AutoSize = True
        Me.lblFolioDoc.Location = New System.Drawing.Point(371, 74)
        Me.lblFolioDoc.Name = "lblFolioDoc"
        Me.lblFolioDoc.Size = New System.Drawing.Size(32, 13)
        Me.lblFolioDoc.TabIndex = 77
        Me.lblFolioDoc.Text = "Folio:"
        Me.lblFolioDoc.Visible = False
        '
        'lblFactura
        '
        Me.lblFactura.AutoSize = True
        Me.lblFactura.Location = New System.Drawing.Point(518, 75)
        Me.lblFactura.Name = "lblFactura"
        Me.lblFactura.Size = New System.Drawing.Size(46, 13)
        Me.lblFactura.TabIndex = 79
        Me.lblFactura.Text = "Factura:"
        Me.lblFactura.Visible = False
        '
        'txtFactura
        '
        Me.txtFactura.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtFactura.Digits = True
        Me.txtFactura.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtFactura.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtFactura.Location = New System.Drawing.Point(570, 72)
        Me.txtFactura.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFactura.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(82, 20)
        Me.txtFactura.TabIndex = 78
        Me.txtFactura.Visible = False
        '
        'lblSerie
        '
        Me.lblSerie.AutoSize = True
        Me.lblSerie.Location = New System.Drawing.Point(371, 74)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(34, 13)
        Me.lblSerie.TabIndex = 81
        Me.lblSerie.Text = "Serie:"
        Me.lblSerie.Visible = False
        '
        'txtSerie
        '
        Me.txtSerie.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtSerie.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtSerie.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtSerie.Location = New System.Drawing.Point(442, 72)
        Me.txtSerie.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSerie.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(70, 20)
        Me.txtSerie.TabIndex = 80
        Me.txtSerie.Visible = False
        '
        'lblFolio
        '
        Me.lblFolio.AutoSize = True
        Me.lblFolio.Location = New System.Drawing.Point(672, 75)
        Me.lblFolio.Name = "lblFolio"
        Me.lblFolio.Size = New System.Drawing.Size(32, 13)
        Me.lblFolio.TabIndex = 83
        Me.lblFolio.Text = "Folio:"
        Me.lblFolio.Visible = False
        '
        'txtFolio
        '
        Me.txtFolio.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtFolio.Digits = True
        Me.txtFolio.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtFolio.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtFolio.Location = New System.Drawing.Point(710, 72)
        Me.txtFolio.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFolio.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(82, 20)
        Me.txtFolio.TabIndex = 82
        Me.txtFolio.Visible = False
        '
        'tbPresupuesto
        '
        Me.tbPresupuesto.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbPresupuesto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnConsultar, Me.ToolStripSeparator1})
        Me.tbPresupuesto.Location = New System.Drawing.Point(0, 0)
        Me.tbPresupuesto.Name = "tbPresupuesto"
        Me.tbPresupuesto.Size = New System.Drawing.Size(1043, 39)
        Me.tbPresupuesto.TabIndex = 84
        Me.tbPresupuesto.Text = "CiToolBar1"
        '
        'btnConsultar
        '
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(94, 36)
        Me.btnConsultar.Text = "Consultar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'splitDocumentos
        '
        Me.splitDocumentos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.splitDocumentos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.splitDocumentos.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitDocumentos.Location = New System.Drawing.Point(0, 98)
        Me.splitDocumentos.Name = "splitDocumentos"
        Me.splitDocumentos.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitDocumentos.Panel1
        '
        Me.splitDocumentos.Panel1.Controls.Add(Me.lvwDocumentos)
        '
        'splitDocumentos.Panel2
        '
        Me.splitDocumentos.Panel2.Controls.Add(Me.pnlSeleccion)
        Me.splitDocumentos.Panel2.Controls.Add(Me.lvwDetalle)
        Me.splitDocumentos.Panel2.Controls.Add(Me.grdGastos)
        Me.splitDocumentos.Size = New System.Drawing.Size(1043, 384)
        Me.splitDocumentos.SplitterDistance = 105
        Me.splitDocumentos.TabIndex = 85
        '
        'pnlSeleccion
        '
        Me.pnlSeleccion.BackColor = System.Drawing.Color.White
        Me.pnlSeleccion.Border = True
        Me.pnlSeleccion.BorderColor = System.Drawing.Color.Orange
        Me.pnlSeleccion.Colors.Add(Me.ColorWithAlpha3)
        Me.pnlSeleccion.Colors.Add(Me.ColorWithAlpha4)
        Me.pnlSeleccion.Colors.Add(Me.ColorWithAlpha5)
        Me.pnlSeleccion.ColorsClick.Add(Me.ColorWithAlpha6)
        Me.pnlSeleccion.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlSeleccion.Controls.Add(Me.btnClosePol)
        Me.pnlSeleccion.Controls.Add(Me.grdPolizas)
        Me.pnlSeleccion.Controls.Add(Me.lblPoliza)
        Me.pnlSeleccion.CornerRadius = 25
        Me.pnlSeleccion.Corners = CType((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight), Azteca.Windows.Corner)
        Me.pnlSeleccion.Gradient = True
        Me.pnlSeleccion.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.pnlSeleccion.GradientOffset = 1.0!
        Me.pnlSeleccion.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlSeleccion.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlSeleccion.Grayscale = False
        Me.pnlSeleccion.Image = Nothing
        Me.pnlSeleccion.ImageAlpha = 75
        Me.pnlSeleccion.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlSeleccion.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlSeleccion.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlSeleccion.Location = New System.Drawing.Point(372, 14)
        Me.pnlSeleccion.Name = "pnlSeleccion"
        Me.pnlSeleccion.Rounded = True
        Me.pnlSeleccion.Size = New System.Drawing.Size(200, 116)
        Me.pnlSeleccion.TabIndex = 86
        Me.pnlSeleccion.Visible = False
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = System.Drawing.Color.White
        Me.ColorWithAlpha3.Parent = Me.pnlSeleccion
        '
        'ColorWithAlpha4
        '
        Me.ColorWithAlpha4.Alpha = 255
        Me.ColorWithAlpha4.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorWithAlpha4.Parent = Me.pnlSeleccion
        '
        'ColorWithAlpha5
        '
        Me.ColorWithAlpha5.Alpha = 255
        Me.ColorWithAlpha5.Color = System.Drawing.Color.White
        Me.ColorWithAlpha5.Parent = Me.pnlSeleccion
        '
        'ColorWithAlpha6
        '
        Me.ColorWithAlpha6.Alpha = 255
        Me.ColorWithAlpha6.Color = System.Drawing.SystemColors.Control
        Me.ColorWithAlpha6.Parent = Me.pnlSeleccion
        '
        'btnClosePol
        '
        Me.btnClosePol.AutoLock = False
        DesignerRectTracker1.IsActive = True
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnClosePol.CenterPtTracker = DesignerRectTracker1
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))}
        CBlendItems1.iPoint = New Single() {0.0!, 0.5!, 1.0!}
        Me.btnClosePol.ColorFillBlend = CBlendItems1
        Me.btnClosePol.ColorFillSolid = System.Drawing.SystemColors.Control
        Me.btnClosePol.Corners.All = CType(6, Short)
        Me.btnClosePol.Corners.LowerLeft = CType(6, Short)
        Me.btnClosePol.Corners.LowerRight = CType(6, Short)
        Me.btnClosePol.Corners.UpperLeft = CType(6, Short)
        Me.btnClosePol.Corners.UpperRight = CType(6, Short)
        Me.btnClosePol.FillType = Azteca.Windows.Controls.ButtonPlus.eFillType.GradientLinear
        Me.btnClosePol.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnClosePol.FocalPoints.CenterPtX = 0.5!
        Me.btnClosePol.FocalPoints.CenterPtY = 0.6666667!
        Me.btnClosePol.FocalPoints.FocusPtX = 0.0!
        Me.btnClosePol.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnClosePol.FocusPtTracker = DesignerRectTracker2
        Me.btnClosePol.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnClosePol.ForeColor = System.Drawing.Color.White
        Me.btnClosePol.Image = Nothing
        Me.btnClosePol.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnClosePol.ImageIndex = 0
        Me.btnClosePol.ImageSize = New System.Drawing.Size(16, 16)
        Me.btnClosePol.Location = New System.Drawing.Point(166, 2)
        Me.btnClosePol.Name = "btnClosePol"
        Me.btnClosePol.Shape = Azteca.Windows.Controls.ButtonPlus.eShape.Rectangle
        Me.btnClosePol.SideImage = Nothing
        Me.btnClosePol.SideImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClosePol.SideImageSize = New System.Drawing.Size(48, 48)
        Me.btnClosePol.Size = New System.Drawing.Size(22, 18)
        Me.btnClosePol.TabIndex = 89
        Me.btnClosePol.Text = "X"
        Me.btnClosePol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnClosePol.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.btnClosePol.TextMargin = New System.Windows.Forms.Padding(2)
        Me.btnClosePol.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.btnClosePol.UseMnemonic = True
        '
        'grdPolizas
        '
        Me.grdPolizas.BackColor = System.Drawing.Color.LemonChiffon
        Me.grdPolizas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdPolizas.ColumnHeaders = False
        Me.grdPolizas.DataSource = Me.bsPolizas
        Me.grdPolizas.Images.Add(CType(resources.GetObject("grdPolizas.Images"), System.Drawing.Image))
        Me.grdPolizas.Images.Add(CType(resources.GetObject("grdPolizas.Images1"), System.Drawing.Image))
        Me.grdPolizas.Location = New System.Drawing.Point(4, 22)
        Me.grdPolizas.Name = "grdPolizas"
        Me.grdPolizas.Padding = New System.Windows.Forms.Padding(5)
        Me.grdPolizas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdPolizas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdPolizas.PreviewInfo.ZoomFactor = 75.0R
        Me.grdPolizas.PrintInfo.PageSettings = CType(resources.GetObject("grdPolizas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdPolizas.RecordSelectors = False
        Me.grdPolizas.RowDivider.Color = System.Drawing.Color.White
        Me.grdPolizas.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.grdPolizas.RowSubDividerColor = System.Drawing.Color.White
        Me.grdPolizas.Size = New System.Drawing.Size(191, 89)
        Me.grdPolizas.TabIndex = 1
        Me.grdPolizas.Text = "AzTrueDBGrid1"
        Me.grdPolizas.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.grdPolizas.PropBag = resources.GetString("grdPolizas.PropBag")
        '
        'lblPoliza
        '
        Me.lblPoliza.BackColor = System.Drawing.Color.Transparent
        Me.lblPoliza.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoliza.ForeColor = System.Drawing.Color.Sienna
        Me.lblPoliza.Location = New System.Drawing.Point(0, 0)
        Me.lblPoliza.Name = "lblPoliza"
        Me.lblPoliza.Size = New System.Drawing.Size(200, 19)
        Me.lblPoliza.TabIndex = 0
        Me.lblPoliza.Text = "Polizas"
        Me.lblPoliza.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cboChequeras
        '
        Me.cboChequeras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboChequeras.FormattingEnabled = True
        Me.cboChequeras.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboChequeras.ItemsTable = Nothing
        Me.cboChequeras.Location = New System.Drawing.Point(442, 71)
        Me.cboChequeras.Name = "cboChequeras"
        Me.cboChequeras.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboChequeras.Size = New System.Drawing.Size(210, 21)
        Me.cboChequeras.TabIndex = 86
        Me.cboChequeras.UIName = Nothing
        Me.cboChequeras.Visible = False
        '
        'lblChequera
        '
        Me.lblChequera.AutoSize = True
        Me.lblChequera.Location = New System.Drawing.Point(371, 75)
        Me.lblChequera.Name = "lblChequera"
        Me.lblChequera.Size = New System.Drawing.Size(53, 13)
        Me.lblChequera.TabIndex = 87
        Me.lblChequera.Text = "Chequera"
        Me.lblChequera.Visible = False
        '
        'cboCaja
        '
        Me.cboCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCaja.FormattingEnabled = True
        Me.cboCaja.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboCaja.ItemsTable = Nothing
        Me.cboCaja.Location = New System.Drawing.Point(710, 46)
        Me.cboCaja.Name = "cboCaja"
        Me.cboCaja.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboCaja.Size = New System.Drawing.Size(168, 21)
        Me.cboCaja.TabIndex = 88
        Me.cboCaja.UIName = Nothing
        Me.cboCaja.Visible = False
        '
        'lblCaja
        '
        Me.lblCaja.AutoSize = True
        Me.lblCaja.Location = New System.Drawing.Point(672, 49)
        Me.lblCaja.Name = "lblCaja"
        Me.lblCaja.Size = New System.Drawing.Size(31, 13)
        Me.lblCaja.TabIndex = 89
        Me.lblCaja.Text = "Caja:"
        Me.lblCaja.Visible = False
        '
        'SeguimientoEgresosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 482)
        Me.Controls.Add(Me.lblCaja)
        Me.Controls.Add(Me.cboCaja)
        Me.Controls.Add(Me.lblChequera)
        Me.Controls.Add(Me.splitDocumentos)
        Me.Controls.Add(Me.tbPresupuesto)
        Me.Controls.Add(Me.lblFolio)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.lblSerie)
        Me.Controls.Add(Me.txtSerie)
        Me.Controls.Add(Me.lblFactura)
        Me.Controls.Add(Me.txtFactura)
        Me.Controls.Add(Me.lblFolioDoc)
        Me.Controls.Add(Me.txtDocumento)
        Me.Controls.Add(Me.lblDocumento)
        Me.Controls.Add(Me.cboDocumentos)
        Me.Controls.Add(Me.dtpFechaIni)
        Me.Controls.Add(Me.lblFechaFin)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.lblFechaIni)
        Me.Controls.Add(Me.cboChequeras)
        Me.Name = "SeguimientoEgresosForm"
        Me.Text = "SeguimientoEgresosForm"
        CType(Me.grdGastos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSeguimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbPresupuesto.ResumeLayout(False)
        Me.tbPresupuesto.PerformLayout()
        Me.splitDocumentos.Panel1.ResumeLayout(False)
        Me.splitDocumentos.Panel2.ResumeLayout(False)
        CType(Me.splitDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitDocumentos.ResumeLayout(False)
        Me.pnlSeleccion.ResumeLayout(False)
        CType(Me.grdPolizas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPolizas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpFechaIni As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents lblFechaFin As Azteca.Windows.Controls.CILabel
    Friend WithEvents dtpFechaFin As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents lblFechaIni As Azteca.Windows.Controls.CILabel
    Friend WithEvents iLst64 As System.Windows.Forms.ImageList
    Friend WithEvents bsSeguimiento As System.Windows.Forms.BindingSource
    Friend WithEvents cboDocumentos As Azteca.Windows.Controls.CIComboBox
    Friend WithEvents lblDocumento As Azteca.Windows.Controls.CILabel
    Friend WithEvents grdGastos As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents txtDocumento As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblFolioDoc As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblFactura As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtFactura As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblSerie As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtSerie As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblFolio As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtFolio As Azteca.Windows.Controls.CITextBox
    Friend WithEvents tbPresupuesto As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lvwDetalle As Azteca.Windows.Controls.CIListView
    Friend WithEvents lvwDocumentos As Azteca.Windows.Controls.CIListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColorWithAlpha1 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents splitDocumentos As System.Windows.Forms.SplitContainer
    Friend WithEvents pnlSeleccion As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha3 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha4 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha5 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha6 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents grdPolizas As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents lblPoliza As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboChequeras As Azteca.Windows.Tesoreria.ChequerasComboBox
    Friend WithEvents lblChequera As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboCaja As Azteca.Windows.Tesoreria.CajasComboBox
    Friend WithEvents lblCaja As Azteca.Windows.Controls.CILabel
    Friend WithEvents bsPolizas As System.Windows.Forms.BindingSource
    Friend WithEvents btnClosePol As Azteca.Windows.Controls.ButtonPlus
End Class
