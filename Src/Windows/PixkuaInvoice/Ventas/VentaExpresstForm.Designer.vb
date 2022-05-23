<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentaExpresstForm
    Inherits Azteca.Windows.Forms.BusinessForms.DocumentForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentaExpresstForm))
        Dim Style9 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style10 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style11 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style12 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style13 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style14 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style15 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style16 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Me.imlPartidas = New System.Windows.Forms.ImageList(Me.components)
        Me.imlVenta = New System.Windows.Forms.ImageList(Me.components)
        Me.txtReferencia = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel16 = New Azteca.Windows.Controls.CILabel()
        Me.txtOrdenCompra = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel17 = New Azteca.Windows.Controls.CILabel()
        Me.bsUnidades = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsServicios = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsArticulos = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabPartidas = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagArticulos = New C1.Win.C1Command.C1DockingTabPage()
        Me.cboUnidades = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.grdArticulos = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.pagServicios = New C1.Win.C1Command.C1DockingTabPage()
        Me.grdServicios = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.lblObservacines = New Azteca.Windows.Controls.CILabel()
        Me.txtNotas = New Azteca.Windows.Controls.CITextBox()
        Me.CiGroupBox2 = New Azteca.Windows.Controls.CIGroupBox()
        Me.CiLabel12 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel9 = New Azteca.Windows.Controls.CILabel()
        Me.txtTipoCambio = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel11 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.txtDivisa = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel5 = New Azteca.Windows.Controls.CILabel()
        Me.txtTotal = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel6 = New Azteca.Windows.Controls.CILabel()
        Me.txtDescuentos = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel7 = New Azteca.Windows.Controls.CILabel()
        Me.txtRetenciones = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel8 = New Azteca.Windows.Controls.CILabel()
        Me.txtImpuestos = New Azteca.Windows.Controls.CITextBox()
        Me.lblFechaFactura = New Azteca.Windows.Controls.CILabel()
        Me.txtSubTotal = New Azteca.Windows.Controls.CITextBox()
        Me.txtFactura = New Azteca.Windows.Controls.CITextBox()
        Me.txtTotalCant = New Azteca.Windows.Controls.CITextBox()
        Me.txtFechaFactura = New Azteca.Windows.Controls.CITextBox()
        Me.CiGroupBox1 = New Azteca.Windows.Controls.CIGroupBox()
        Me.txtPoblacion = New Azteca.Windows.Controls.CILabel()
        Me.txtDomicilio = New Azteca.Windows.Controls.CILabel()
        Me.txtRazonSocial = New Azteca.Windows.Controls.CILabel()
        Me.txtRFC = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel14 = New Azteca.Windows.Controls.CILabel()
        Me.lblDomicilio = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel23 = New Azteca.Windows.Controls.CILabel()
        Me.lblCliente = New Azteca.Windows.Controls.CILabel()
        Me.grpCondicionesPago = New Azteca.Windows.Controls.CIGroupBox()
        Me.rdbCredito = New Azteca.Windows.Controls.CIRadioButton()
        Me.rdbContado = New Azteca.Windows.Controls.CIRadioButton()
        Me.cboCaja = New Azteca.Windows.Ventas.CajaCombobox()
        Me.cboDivisa = New Azteca.Windows.Contabilidad.DivisasComboBox()
        Me.CiLabel13 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel15 = New Azteca.Windows.Controls.CILabel()
        Me.txtCliente = New PixkuaInvoice.ClienteExpressSelector()
        CType(Me.bsUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabPartidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPartidas.SuspendLayout()
        Me.pagArticulos.SuspendLayout()
        CType(Me.cboUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagServicios.SuspendLayout()
        CType(Me.grdServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CiGroupBox2.SuspendLayout()
        Me.CiGroupBox1.SuspendLayout()
        Me.grpCondicionesPago.SuspendLayout()
        Me.SuspendLayout()
        '
        'imlPartidas
        '
        Me.imlPartidas.ImageStream = CType(resources.GetObject("imlPartidas.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlPartidas.TransparentColor = System.Drawing.Color.Transparent
        Me.imlPartidas.Images.SetKeyName(0, "Articulos")
        Me.imlPartidas.Images.SetKeyName(1, "Servicios")
        '
        'imlVenta
        '
        Me.imlVenta.ImageStream = CType(resources.GetObject("imlVenta.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlVenta.TransparentColor = System.Drawing.Color.Transparent
        Me.imlVenta.Images.SetKeyName(0, "General")
        Me.imlVenta.Images.SetKeyName(1, "Facturacion")
        Me.imlVenta.Images.SetKeyName(2, "Notas")
        '
        'txtReferencia
        '
        Me.txtReferencia.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtReferencia.Location = New System.Drawing.Point(553, 293)
        Me.txtReferencia.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtReferencia.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(197, 20)
        Me.txtReferencia.TabIndex = 4
        '
        'CiLabel16
        '
        Me.CiLabel16.AutoSize = True
        Me.CiLabel16.Location = New System.Drawing.Point(458, 321)
        Me.CiLabel16.Name = "CiLabel16"
        Me.CiLabel16.Size = New System.Drawing.Size(93, 13)
        Me.CiLabel16.TabIndex = 1
        Me.CiLabel16.Text = "Orden de Compra:"
        '
        'txtOrdenCompra
        '
        Me.txtOrdenCompra.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtOrdenCompra.Location = New System.Drawing.Point(553, 316)
        Me.txtOrdenCompra.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtOrdenCompra.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtOrdenCompra.Name = "txtOrdenCompra"
        Me.txtOrdenCompra.Size = New System.Drawing.Size(197, 20)
        Me.txtOrdenCompra.TabIndex = 3
        '
        'CiLabel17
        '
        Me.CiLabel17.AutoSize = True
        Me.CiLabel17.Location = New System.Drawing.Point(458, 299)
        Me.CiLabel17.Name = "CiLabel17"
        Me.CiLabel17.Size = New System.Drawing.Size(62, 13)
        Me.CiLabel17.TabIndex = 2
        Me.CiLabel17.Text = "Referencia:"
        '
        'bsServicios
        '
        Me.bsServicios.Filter = ""
        '
        'bsArticulos
        '
        Me.bsArticulos.Filter = ""
        '
        'tabPartidas
        '
        Me.tabPartidas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabPartidas.Controls.Add(Me.pagArticulos)
        Me.tabPartidas.Controls.Add(Me.pagServicios)
        Me.tabPartidas.ImageList = Me.imlPartidas
        Me.tabPartidas.Location = New System.Drawing.Point(2, 357)
        Me.tabPartidas.Name = "tabPartidas"
        Me.tabPartidas.SelectedIndex = 1
        Me.tabPartidas.Size = New System.Drawing.Size(940, 213)
        Me.tabPartidas.TabIndex = 40
        Me.tabPartidas.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabPartidas.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabPartidas.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagArticulos
        '
        Me.pagArticulos.Controls.Add(Me.cboUnidades)
        Me.pagArticulos.Controls.Add(Me.grdArticulos)
        Me.pagArticulos.ImageIndex = 0
        Me.pagArticulos.Location = New System.Drawing.Point(1, 41)
        Me.pagArticulos.Name = "pagArticulos"
        Me.pagArticulos.Size = New System.Drawing.Size(938, 171)
        Me.pagArticulos.TabIndex = 0
        Me.pagArticulos.Text = "Artículos"
        '
        'cboUnidades
        '
        Me.cboUnidades.AllowColMove = True
        Me.cboUnidades.AllowColSelect = True
        Me.cboUnidades.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboUnidades.AlternatingRows = True
        Me.cboUnidades.CaptionStyle = Style9
        Me.cboUnidades.ColumnCaptionHeight = 17
        Me.cboUnidades.ColumnFooterHeight = 17
        Me.cboUnidades.DataSource = Me.bsUnidades
        Me.cboUnidades.DisplayMember = "IdUnidadMedida"
        Me.cboUnidades.EvenRowStyle = Style10
        Me.cboUnidades.ExtendRightColumn = True
        Me.cboUnidades.FetchRowStyles = False
        Me.cboUnidades.FooterStyle = Style11
        Me.cboUnidades.HeadingStyle = Style12
        Me.cboUnidades.HighLightRowStyle = Style13
        Me.cboUnidades.Images.Add(CType(resources.GetObject("cboUnidades.Images"), System.Drawing.Image))
        Me.cboUnidades.Location = New System.Drawing.Point(289, 32)
        Me.cboUnidades.Name = "cboUnidades"
        Me.cboUnidades.OddRowStyle = Style14
        Me.cboUnidades.RecordSelectorStyle = Style15
        Me.cboUnidades.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboUnidades.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboUnidades.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboUnidades.ScrollTips = False
        Me.cboUnidades.Size = New System.Drawing.Size(264, 162)
        Me.cboUnidades.Style = Style16
        Me.cboUnidades.TabIndex = 46
        Me.cboUnidades.TabStop = False
        Me.cboUnidades.Text = "C1TrueDBDropdown1"
        Me.cboUnidades.ValueMember = "IdUnidadMedida"
        Me.cboUnidades.Visible = False
        Me.cboUnidades.PropBag = resources.GetString("cboUnidades.PropBag")
        '
        'grdArticulos
        '
        Me.grdArticulos.AllowAddNew = True
        Me.grdArticulos.AllowDelete = True
        Me.grdArticulos.DataSource = Me.bsArticulos
        Me.grdArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdArticulos.Images.Add(CType(resources.GetObject("grdArticulos.Images"), System.Drawing.Image))
        Me.grdArticulos.Images.Add(CType(resources.GetObject("grdArticulos.Images1"), System.Drawing.Image))
        Me.grdArticulos.Location = New System.Drawing.Point(0, 0)
        Me.grdArticulos.Name = "grdArticulos"
        Me.grdArticulos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdArticulos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdArticulos.PreviewInfo.ZoomFactor = 75.0R
        Me.grdArticulos.PrintInfo.PageSettings = CType(resources.GetObject("grdArticulos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdArticulos.Size = New System.Drawing.Size(938, 171)
        Me.grdArticulos.TabIndex = 2
        Me.grdArticulos.Text = "AzTrueDBGrid1"
        Me.grdArticulos.PropBag = resources.GetString("grdArticulos.PropBag")
        '
        'pagServicios
        '
        Me.pagServicios.Controls.Add(Me.grdServicios)
        Me.pagServicios.ImageIndex = 1
        Me.pagServicios.Location = New System.Drawing.Point(1, 41)
        Me.pagServicios.Name = "pagServicios"
        Me.pagServicios.Size = New System.Drawing.Size(938, 171)
        Me.pagServicios.TabIndex = 1
        Me.pagServicios.Text = "Servicios"
        '
        'grdServicios
        '
        Me.grdServicios.AllowAddNew = True
        Me.grdServicios.AllowDelete = True
        Me.grdServicios.DataSource = Me.bsServicios
        Me.grdServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdServicios.Images.Add(CType(resources.GetObject("grdServicios.Images"), System.Drawing.Image))
        Me.grdServicios.Images.Add(CType(resources.GetObject("grdServicios.Images1"), System.Drawing.Image))
        Me.grdServicios.Images.Add(CType(resources.GetObject("grdServicios.Images2"), System.Drawing.Image))
        Me.grdServicios.Location = New System.Drawing.Point(0, 0)
        Me.grdServicios.Name = "grdServicios"
        Me.grdServicios.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdServicios.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdServicios.PreviewInfo.ZoomFactor = 75.0R
        Me.grdServicios.PrintInfo.PageSettings = CType(resources.GetObject("grdServicios.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdServicios.Size = New System.Drawing.Size(938, 171)
        Me.grdServicios.TabIndex = 2
        Me.grdServicios.Text = "AzTrueDBGrid1"
        Me.grdServicios.PropBag = resources.GetString("grdServicios.PropBag")
        '
        'lblObservacines
        '
        Me.lblObservacines.AutoSize = True
        Me.lblObservacines.Location = New System.Drawing.Point(6, 259)
        Me.lblObservacines.Name = "lblObservacines"
        Me.lblObservacines.Size = New System.Drawing.Size(78, 13)
        Me.lblObservacines.TabIndex = 41
        Me.lblObservacines.Text = "Observaciones"
        '
        'txtNotas
        '
        Me.txtNotas.BackColor = System.Drawing.SystemColors.Window
        Me.txtNotas.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNotas.Location = New System.Drawing.Point(90, 256)
        Me.txtNotas.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNotas.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNotas.Multiline = True
        Me.txtNotas.Name = "txtNotas"
        Me.txtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotas.Size = New System.Drawing.Size(356, 95)
        Me.txtNotas.TabIndex = 44
        Me.txtNotas.WordWrap = False
        '
        'CiGroupBox2
        '
        Me.CiGroupBox2.Controls.Add(Me.grpCondicionesPago)
        Me.CiGroupBox2.Controls.Add(Me.CiLabel12)
        Me.CiGroupBox2.Controls.Add(Me.CiLabel9)
        Me.CiGroupBox2.Controls.Add(Me.txtTipoCambio)
        Me.CiGroupBox2.Controls.Add(Me.CiLabel3)
        Me.CiGroupBox2.Controls.Add(Me.CiLabel11)
        Me.CiGroupBox2.Controls.Add(Me.CiLabel4)
        Me.CiGroupBox2.Controls.Add(Me.txtDivisa)
        Me.CiGroupBox2.Controls.Add(Me.CiLabel5)
        Me.CiGroupBox2.Controls.Add(Me.txtTotal)
        Me.CiGroupBox2.Controls.Add(Me.CiLabel6)
        Me.CiGroupBox2.Controls.Add(Me.txtDescuentos)
        Me.CiGroupBox2.Controls.Add(Me.CiLabel7)
        Me.CiGroupBox2.Controls.Add(Me.txtRetenciones)
        Me.CiGroupBox2.Controls.Add(Me.CiLabel8)
        Me.CiGroupBox2.Controls.Add(Me.txtImpuestos)
        Me.CiGroupBox2.Controls.Add(Me.lblFechaFactura)
        Me.CiGroupBox2.Controls.Add(Me.txtSubTotal)
        Me.CiGroupBox2.Controls.Add(Me.txtFactura)
        Me.CiGroupBox2.Controls.Add(Me.txtTotalCant)
        Me.CiGroupBox2.Controls.Add(Me.txtFechaFactura)
        Me.CiGroupBox2.Location = New System.Drawing.Point(452, 95)
        Me.CiGroupBox2.Name = "CiGroupBox2"
        Me.CiGroupBox2.Size = New System.Drawing.Size(492, 192)
        Me.CiGroupBox2.TabIndex = 43
        Me.CiGroupBox2.TabStop = False
        '
        'CiLabel12
        '
        Me.CiLabel12.AutoSize = True
        Me.CiLabel12.Location = New System.Drawing.Point(20, 113)
        Me.CiLabel12.Name = "CiLabel12"
        Me.CiLabel12.Size = New System.Drawing.Size(84, 13)
        Me.CiLabel12.TabIndex = 39
        Me.CiLabel12.Text = "Tipo de Cambio:"
        '
        'CiLabel9
        '
        Me.CiLabel9.AutoSize = True
        Me.CiLabel9.Location = New System.Drawing.Point(20, 22)
        Me.CiLabel9.Name = "CiLabel9"
        Me.CiLabel9.Size = New System.Drawing.Size(46, 13)
        Me.CiLabel9.TabIndex = 20
        Me.CiLabel9.Text = "Factura:"
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.AutoLock = False
        Me.txtTipoCambio.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTipoCambio.Location = New System.Drawing.Point(110, 113)
        Me.txtTipoCambio.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTipoCambio.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.ReadOnly = True
        Me.txtTipoCambio.Size = New System.Drawing.Size(120, 20)
        Me.txtTipoCambio.TabIndex = 38
        Me.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(20, 67)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(79, 13)
        Me.CiLabel3.TabIndex = 24
        Me.CiLabel3.Text = "Total Cantidad:"
        '
        'CiLabel11
        '
        Me.CiLabel11.AutoSize = True
        Me.CiLabel11.Location = New System.Drawing.Point(20, 90)
        Me.CiLabel11.Name = "CiLabel11"
        Me.CiLabel11.Size = New System.Drawing.Size(39, 13)
        Me.CiLabel11.TabIndex = 37
        Me.CiLabel11.Text = "Divisa:"
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.Location = New System.Drawing.Point(242, 22)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(56, 13)
        Me.CiLabel4.TabIndex = 26
        Me.CiLabel4.Text = "Sub Total:"
        '
        'txtDivisa
        '
        Me.txtDivisa.AutoLock = False
        Me.txtDivisa.BackColor = System.Drawing.SystemColors.Control
        Me.txtDivisa.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtDivisa.Location = New System.Drawing.Point(110, 91)
        Me.txtDivisa.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDivisa.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDivisa.Name = "txtDivisa"
        Me.txtDivisa.ReadOnly = True
        Me.txtDivisa.Size = New System.Drawing.Size(120, 20)
        Me.txtDivisa.TabIndex = 36
        '
        'CiLabel5
        '
        Me.CiLabel5.AutoSize = True
        Me.CiLabel5.Location = New System.Drawing.Point(241, 44)
        Me.CiLabel5.Name = "CiLabel5"
        Me.CiLabel5.Size = New System.Drawing.Size(85, 13)
        Me.CiLabel5.TabIndex = 28
        Me.CiLabel5.Text = "Total Impuestos:"
        '
        'txtTotal
        '
        Me.txtTotal.AutoLock = False
        Me.txtTotal.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTotal.Location = New System.Drawing.Point(344, 110)
        Me.txtTotal.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotal.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(120, 20)
        Me.txtTotal.TabIndex = 35
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CiLabel6
        '
        Me.CiLabel6.AutoSize = True
        Me.CiLabel6.Location = New System.Drawing.Point(241, 68)
        Me.CiLabel6.Name = "CiLabel6"
        Me.CiLabel6.Size = New System.Drawing.Size(97, 13)
        Me.CiLabel6.TabIndex = 30
        Me.CiLabel6.Text = "Total Retenciones:"
        '
        'txtDescuentos
        '
        Me.txtDescuentos.AutoLock = False
        Me.txtDescuentos.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtDescuentos.Location = New System.Drawing.Point(344, 87)
        Me.txtDescuentos.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDescuentos.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDescuentos.Name = "txtDescuentos"
        Me.txtDescuentos.ReadOnly = True
        Me.txtDescuentos.Size = New System.Drawing.Size(120, 20)
        Me.txtDescuentos.TabIndex = 33
        Me.txtDescuentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CiLabel7
        '
        Me.CiLabel7.AutoSize = True
        Me.CiLabel7.Location = New System.Drawing.Point(241, 90)
        Me.CiLabel7.Name = "CiLabel7"
        Me.CiLabel7.Size = New System.Drawing.Size(94, 13)
        Me.CiLabel7.TabIndex = 32
        Me.CiLabel7.Text = "Total Descuentos:"
        '
        'txtRetenciones
        '
        Me.txtRetenciones.AutoLock = False
        Me.txtRetenciones.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtRetenciones.Location = New System.Drawing.Point(344, 64)
        Me.txtRetenciones.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRetenciones.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRetenciones.Name = "txtRetenciones"
        Me.txtRetenciones.ReadOnly = True
        Me.txtRetenciones.Size = New System.Drawing.Size(120, 20)
        Me.txtRetenciones.TabIndex = 31
        Me.txtRetenciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CiLabel8
        '
        Me.CiLabel8.AutoSize = True
        Me.CiLabel8.Location = New System.Drawing.Point(242, 113)
        Me.CiLabel8.Name = "CiLabel8"
        Me.CiLabel8.Size = New System.Drawing.Size(34, 13)
        Me.CiLabel8.TabIndex = 34
        Me.CiLabel8.Text = "Total:"
        '
        'txtImpuestos
        '
        Me.txtImpuestos.AutoLock = False
        Me.txtImpuestos.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtImpuestos.Location = New System.Drawing.Point(344, 41)
        Me.txtImpuestos.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtImpuestos.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtImpuestos.Name = "txtImpuestos"
        Me.txtImpuestos.ReadOnly = True
        Me.txtImpuestos.Size = New System.Drawing.Size(120, 20)
        Me.txtImpuestos.TabIndex = 29
        Me.txtImpuestos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblFechaFactura
        '
        Me.lblFechaFactura.AutoSize = True
        Me.lblFechaFactura.Location = New System.Drawing.Point(20, 44)
        Me.lblFechaFactura.Name = "lblFechaFactura"
        Me.lblFechaFactura.Size = New System.Drawing.Size(79, 13)
        Me.lblFechaFactura.TabIndex = 22
        Me.lblFechaFactura.Text = "Fecha Factura:"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.AutoLock = False
        Me.txtSubTotal.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtSubTotal.Location = New System.Drawing.Point(344, 19)
        Me.txtSubTotal.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSubTotal.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(120, 20)
        Me.txtSubTotal.TabIndex = 27
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFactura
        '
        Me.txtFactura.AutoLock = False
        Me.txtFactura.BackColor = System.Drawing.SystemColors.Control
        Me.txtFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFactura.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtFactura.Location = New System.Drawing.Point(110, 21)
        Me.txtFactura.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFactura.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.ReadOnly = True
        Me.txtFactura.Size = New System.Drawing.Size(120, 20)
        Me.txtFactura.TabIndex = 21
        '
        'txtTotalCant
        '
        Me.txtTotalCant.AutoLock = False
        Me.txtTotalCant.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTotalCant.Location = New System.Drawing.Point(110, 68)
        Me.txtTotalCant.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotalCant.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotalCant.Name = "txtTotalCant"
        Me.txtTotalCant.ReadOnly = True
        Me.txtTotalCant.Size = New System.Drawing.Size(120, 20)
        Me.txtTotalCant.TabIndex = 25
        Me.txtTotalCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFechaFactura
        '
        Me.txtFechaFactura.AutoLock = False
        Me.txtFechaFactura.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtFechaFactura.Location = New System.Drawing.Point(110, 45)
        Me.txtFechaFactura.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFechaFactura.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFechaFactura.Name = "txtFechaFactura"
        Me.txtFechaFactura.ReadOnly = True
        Me.txtFechaFactura.Size = New System.Drawing.Size(120, 20)
        Me.txtFechaFactura.TabIndex = 23
        '
        'CiGroupBox1
        '
        Me.CiGroupBox1.Controls.Add(Me.txtPoblacion)
        Me.CiGroupBox1.Controls.Add(Me.txtDomicilio)
        Me.CiGroupBox1.Controls.Add(Me.txtRazonSocial)
        Me.CiGroupBox1.Controls.Add(Me.txtRFC)
        Me.CiGroupBox1.Controls.Add(Me.CiLabel2)
        Me.CiGroupBox1.Controls.Add(Me.CiLabel14)
        Me.CiGroupBox1.Controls.Add(Me.lblDomicilio)
        Me.CiGroupBox1.Controls.Add(Me.CiLabel23)
        Me.CiGroupBox1.Controls.Add(Me.txtCliente)
        Me.CiGroupBox1.Controls.Add(Me.lblCliente)
        Me.CiGroupBox1.Location = New System.Drawing.Point(9, 95)
        Me.CiGroupBox1.Name = "CiGroupBox1"
        Me.CiGroupBox1.Size = New System.Drawing.Size(437, 154)
        Me.CiGroupBox1.TabIndex = 42
        Me.CiGroupBox1.TabStop = False
        '
        'txtPoblacion
        '
        Me.txtPoblacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtPoblacion.ForeColor = System.Drawing.Color.Blue
        Me.txtPoblacion.Location = New System.Drawing.Point(99, 121)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.Size = New System.Drawing.Size(334, 17)
        Me.txtPoblacion.TabIndex = 26
        '
        'txtDomicilio
        '
        Me.txtDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtDomicilio.ForeColor = System.Drawing.Color.Blue
        Me.txtDomicilio.Location = New System.Drawing.Point(99, 85)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(334, 32)
        Me.txtDomicilio.TabIndex = 25
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtRazonSocial.ForeColor = System.Drawing.Color.Blue
        Me.txtRazonSocial.Location = New System.Drawing.Point(99, 64)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(334, 17)
        Me.txtRazonSocial.TabIndex = 24
        '
        'txtRFC
        '
        Me.txtRFC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtRFC.ForeColor = System.Drawing.Color.Blue
        Me.txtRFC.Location = New System.Drawing.Point(99, 42)
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(124, 17)
        Me.txtRFC.TabIndex = 23
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(22, 66)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(73, 13)
        Me.CiLabel2.TabIndex = 16
        Me.CiLabel2.Text = "Razón Social:"
        '
        'CiLabel14
        '
        Me.CiLabel14.AutoSize = True
        Me.CiLabel14.Location = New System.Drawing.Point(22, 44)
        Me.CiLabel14.Name = "CiLabel14"
        Me.CiLabel14.Size = New System.Drawing.Size(31, 13)
        Me.CiLabel14.TabIndex = 15
        Me.CiLabel14.Text = "RFC:"
        '
        'lblDomicilio
        '
        Me.lblDomicilio.AutoSize = True
        Me.lblDomicilio.Location = New System.Drawing.Point(22, 87)
        Me.lblDomicilio.Name = "lblDomicilio"
        Me.lblDomicilio.Size = New System.Drawing.Size(52, 13)
        Me.lblDomicilio.TabIndex = 17
        Me.lblDomicilio.Text = "Domicilio:"
        '
        'CiLabel23
        '
        Me.CiLabel23.AutoSize = True
        Me.CiLabel23.Location = New System.Drawing.Point(22, 123)
        Me.CiLabel23.Name = "CiLabel23"
        Me.CiLabel23.Size = New System.Drawing.Size(57, 13)
        Me.CiLabel23.TabIndex = 22
        Me.CiLabel23.Text = "Población:"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(22, 20)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 13)
        Me.lblCliente.TabIndex = 0
        Me.lblCliente.Text = "Cliente:"
        '
        'grpCondicionesPago
        '
        Me.grpCondicionesPago.Controls.Add(Me.rdbCredito)
        Me.grpCondicionesPago.Controls.Add(Me.rdbContado)
        Me.grpCondicionesPago.Location = New System.Drawing.Point(23, 139)
        Me.grpCondicionesPago.Name = "grpCondicionesPago"
        Me.grpCondicionesPago.Size = New System.Drawing.Size(207, 40)
        Me.grpCondicionesPago.TabIndex = 4
        Me.grpCondicionesPago.TabStop = False
        Me.grpCondicionesPago.Text = "Condiciones de Pago"
        '
        'rdbCredito
        '
        Me.rdbCredito.AutoSize = True
        Me.rdbCredito.Location = New System.Drawing.Point(23, 17)
        Me.rdbCredito.Name = "rdbCredito"
        Me.rdbCredito.Size = New System.Drawing.Size(58, 17)
        Me.rdbCredito.TabIndex = 1
        Me.rdbCredito.Text = "Crédito"
        Me.rdbCredito.UseVisualStyleBackColor = True
        '
        'rdbContado
        '
        Me.rdbContado.AutoSize = True
        Me.rdbContado.Checked = True
        Me.rdbContado.Location = New System.Drawing.Point(100, 17)
        Me.rdbContado.Name = "rdbContado"
        Me.rdbContado.Size = New System.Drawing.Size(65, 17)
        Me.rdbContado.TabIndex = 0
        Me.rdbContado.TabStop = True
        Me.rdbContado.Text = "Contado"
        Me.rdbContado.UseVisualStyleBackColor = True
        '
        'cboCaja
        '
        Me.cboCaja.AutoClear = False
        Me.cboCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCaja.FormattingEnabled = True
        Me.cboCaja.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboCaja.ItemsTable = Nothing
        Me.cboCaja.Location = New System.Drawing.Point(744, 77)
        Me.cboCaja.Name = "cboCaja"
        Me.cboCaja.RequiredField = True
        Me.cboCaja.Size = New System.Drawing.Size(200, 21)
        Me.cboCaja.TabIndex = 1
        Me.cboCaja.UIName = "Caja"
        Me.cboCaja.Visible = False
        '
        'cboDivisa
        '
        Me.cboDivisa.AutoClear = False
        Me.cboDivisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDivisa.FormattingEnabled = True
        Me.cboDivisa.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboDivisa.ItemsTable = Nothing
        Me.cboDivisa.Location = New System.Drawing.Point(744, 63)
        Me.cboDivisa.Name = "cboDivisa"
        Me.cboDivisa.RequiredField = True
        Me.cboDivisa.Size = New System.Drawing.Size(200, 21)
        Me.cboDivisa.TabIndex = 3
        Me.cboDivisa.UIName = "Divisa"
        Me.cboDivisa.Visible = False
        '
        'CiLabel13
        '
        Me.CiLabel13.AutoSize = True
        Me.CiLabel13.Location = New System.Drawing.Point(699, 65)
        Me.CiLabel13.Name = "CiLabel13"
        Me.CiLabel13.Size = New System.Drawing.Size(39, 13)
        Me.CiLabel13.TabIndex = 2
        Me.CiLabel13.Text = "Divisa:"
        Me.CiLabel13.Visible = False
        '
        'CiLabel15
        '
        Me.CiLabel15.AutoSize = True
        Me.CiLabel15.Location = New System.Drawing.Point(706, 81)
        Me.CiLabel15.Name = "CiLabel15"
        Me.CiLabel15.Size = New System.Drawing.Size(31, 13)
        Me.CiLabel15.TabIndex = 0
        Me.CiLabel15.Text = "Caja:"
        Me.CiLabel15.Visible = False
        '
        'txtCliente
        '
        Me.txtCliente.AnySite = False
        Me.txtCliente.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtCliente.EditorAssembly = "PixkuaInvoice"
        Me.txtCliente.EditorClass = "PixkuaInvoice.ClienteExpressForm"
        Me.txtCliente.EditorTitle = "Editar datos de cliente..."
        Me.txtCliente.Key = 0
        Me.txtCliente.Linked = False
        Me.txtCliente.Location = New System.Drawing.Point(97, 15)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.RequiredField = True
        Me.txtCliente.ShowEditButton = True
        Me.txtCliente.Size = New System.Drawing.Size(334, 23)
        Me.txtCliente.TabIndex = 4
        '
        'VentaExpresstForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 594)
        Me.Controls.Add(Me.lblObservacines)
        Me.Controls.Add(Me.cboDivisa)
        Me.Controls.Add(Me.CiLabel13)
        Me.Controls.Add(Me.cboCaja)
        Me.Controls.Add(Me.txtNotas)
        Me.Controls.Add(Me.CiLabel15)
        Me.Controls.Add(Me.CiGroupBox2)
        Me.Controls.Add(Me.CiGroupBox1)
        Me.Controls.Add(Me.txtOrdenCompra)
        Me.Controls.Add(Me.CiLabel16)
        Me.Controls.Add(Me.txtReferencia)
        Me.Controls.Add(Me.tabPartidas)
        Me.Controls.Add(Me.CiLabel17)
        Me.Name = "VentaExpresstForm"
        Me.Text = "VentaExpresstForm"
        Me.Controls.SetChildIndex(Me.CiLabel17, 0)
        Me.Controls.SetChildIndex(Me.tabPartidas, 0)
        Me.Controls.SetChildIndex(Me.txtReferencia, 0)
        Me.Controls.SetChildIndex(Me.CiLabel16, 0)
        Me.Controls.SetChildIndex(Me.txtOrdenCompra, 0)
        Me.Controls.SetChildIndex(Me.CiGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.CiGroupBox2, 0)
        Me.Controls.SetChildIndex(Me.CiLabel15, 0)
        Me.Controls.SetChildIndex(Me.txtNotas, 0)
        Me.Controls.SetChildIndex(Me.cboCaja, 0)
        Me.Controls.SetChildIndex(Me.CiLabel13, 0)
        Me.Controls.SetChildIndex(Me.cboDivisa, 0)
        Me.Controls.SetChildIndex(Me.lblObservacines, 0)
        CType(Me.bsUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabPartidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPartidas.ResumeLayout(False)
        Me.pagArticulos.ResumeLayout(False)
        CType(Me.cboUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagServicios.ResumeLayout(False)
        CType(Me.grdServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CiGroupBox2.ResumeLayout(False)
        Me.CiGroupBox2.PerformLayout()
        Me.CiGroupBox1.ResumeLayout(False)
        Me.CiGroupBox1.PerformLayout()
        Me.grpCondicionesPago.ResumeLayout(False)
        Me.grpCondicionesPago.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bsUnidades As System.Windows.Forms.BindingSource
    Friend WithEvents bsServicios As System.Windows.Forms.BindingSource
    Friend WithEvents bsArticulos As System.Windows.Forms.BindingSource
    Friend WithEvents imlPartidas As System.Windows.Forms.ImageList
    Friend WithEvents imlVenta As System.Windows.Forms.ImageList
    Friend WithEvents txtReferencia As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel16 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtOrdenCompra As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel17 As Azteca.Windows.Controls.CILabel
    Friend WithEvents tabPartidas As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagArticulos As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents cboUnidades As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents grdArticulos As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents pagServicios As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents grdServicios As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents lblObservacines As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNotas As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiGroupBox2 As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents CiLabel12 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel9 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtTipoCambio As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel11 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtDivisa As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel5 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtTotal As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel6 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtDescuentos As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel7 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtRetenciones As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel8 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtImpuestos As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblFechaFactura As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtSubTotal As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtFactura As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtTotalCant As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtFechaFactura As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiGroupBox1 As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents grpCondicionesPago As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents rdbCredito As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents rdbContado As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents cboCaja As Azteca.Windows.Ventas.CajaCombobox
    Friend WithEvents cboDivisa As Azteca.Windows.Contabilidad.DivisasComboBox
    Friend WithEvents CiLabel13 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel15 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCliente As PixkuaInvoice.ClienteExpressSelector
    Friend WithEvents lblCliente As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel14 As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblDomicilio As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel23 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtRazonSocial As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtRFC As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtPoblacion As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtDomicilio As Azteca.Windows.Controls.CILabel

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New Azteca.Business.Ventas.VentaFacade
        SetDocumentType("Venta")

    End Sub
End Class
