<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidosForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PedidosForm))
        Dim Style33 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style34 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style35 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style36 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style37 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style38 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style39 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style40 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Me.imlPedido = New System.Windows.Forms.ImageList(Me.components)
        Me.bsUnidades = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsArticulos = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsServicios = New System.Windows.Forms.BindingSource(Me.components)
        Me.imlPartidas = New System.Windows.Forms.ImageList(Me.components)
        Me.tabVenta = New Azteca.Windows.Controls.CITab()
        Me.pagGeneral = New System.Windows.Forms.TabPage()
        Me.CiGroupBox2 = New Azteca.Windows.Controls.CIGroupBox()
        Me.txtReferencia = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel17 = New Azteca.Windows.Controls.CILabel()
        Me.txtOrdenCompra = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel16 = New Azteca.Windows.Controls.CILabel()
        Me.lblTipoCambio = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.cboDivisa = New Azteca.Windows.Contabilidad.DivisasComboBox()
        Me.CiLabel13 = New Azteca.Windows.Controls.CILabel()
        Me.CiGroupBox1 = New Azteca.Windows.Controls.CIGroupBox()
        Me.cboVendedor = New Azteca.Windows.Ventas.VendedoresComboBox()
        Me.dtpFecha = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.CiLabel15 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel14 = New Azteca.Windows.Controls.CILabel()
        Me.txtCliente = New Azteca.Windows.Ventas.ClienteSelector()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.pagEmbarques = New System.Windows.Forms.TabPage()
        Me.tlbEmbarques = New C1.Win.C1Command.C1ToolBar()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdNuevoEmbarque = New C1.Win.C1Command.C1Command()
        Me.btnNuevoEmbarque = New C1.Win.C1Command.C1CommandLink()
        Me.grdEmbarques = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsEmbarques = New System.Windows.Forms.BindingSource(Me.components)
        Me.pagEntregaSvc = New System.Windows.Forms.TabPage()
        Me.pagNotas = New System.Windows.Forms.TabPage()
        Me.txtNotas = New Azteca.Windows.Controls.CITextBox()
        Me.tabPartidas = New Azteca.Windows.Controls.CITab()
        Me.pagArticulos = New System.Windows.Forms.TabPage()
        Me.cboUnidades = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.grdArticulos = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.pagServicios = New System.Windows.Forms.TabPage()
        Me.grdServicios = New Azteca.Windows.Controls.AZTrueDBGrid()
        CType(Me.bsUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabVenta.SuspendLayout()
        Me.pagGeneral.SuspendLayout()
        Me.CiGroupBox2.SuspendLayout()
        Me.CiGroupBox1.SuspendLayout()
        Me.pagEmbarques.SuspendLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEmbarques, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsEmbarques, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagNotas.SuspendLayout()
        Me.tabPartidas.SuspendLayout()
        Me.pagArticulos.SuspendLayout()
        CType(Me.cboUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagServicios.SuspendLayout()
        CType(Me.grdServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imlPedido
        '
        Me.imlPedido.ImageStream = CType(resources.GetObject("imlPedido.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlPedido.TransparentColor = System.Drawing.Color.Transparent
        Me.imlPedido.Images.SetKeyName(0, "General")
        Me.imlPedido.Images.SetKeyName(1, "Facturacion")
        Me.imlPedido.Images.SetKeyName(2, "Notas")
        Me.imlPedido.Images.SetKeyName(3, "Embarques")
        Me.imlPedido.Images.SetKeyName(4, "Servicios")
        '
        'bsArticulos
        '
        Me.bsArticulos.Filter = ""
        '
        'bsServicios
        '
        Me.bsServicios.Filter = ""
        '
        'imlPartidas
        '
        Me.imlPartidas.ImageStream = CType(resources.GetObject("imlPartidas.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlPartidas.TransparentColor = System.Drawing.Color.Transparent
        Me.imlPartidas.Images.SetKeyName(0, "Articulos")
        Me.imlPartidas.Images.SetKeyName(1, "Servicios")
        '
        'tabVenta
        '
        Me.tabVenta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabVenta.Controls.Add(Me.pagGeneral)
        Me.tabVenta.Controls.Add(Me.pagEmbarques)
        Me.tabVenta.Controls.Add(Me.pagEntregaSvc)
        Me.tabVenta.Controls.Add(Me.pagNotas)
        Me.tabVenta.ImageList = Me.imlPedido
        Me.tabVenta.ItemSize = New System.Drawing.Size(71, 32)
        Me.tabVenta.Location = New System.Drawing.Point(12, 85)
        Me.tabVenta.Name = "tabVenta"
        Me.tabVenta.SelectedIndex = 0
        Me.tabVenta.Size = New System.Drawing.Size(848, 235)
        Me.tabVenta.TabIndex = 37
        '
        'pagGeneral
        '
        Me.pagGeneral.Controls.Add(Me.CiGroupBox2)
        Me.pagGeneral.Controls.Add(Me.CiGroupBox1)
        Me.pagGeneral.ImageKey = "General"
        Me.pagGeneral.Location = New System.Drawing.Point(4, 36)
        Me.pagGeneral.Name = "pagGeneral"
        Me.pagGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.pagGeneral.Size = New System.Drawing.Size(840, 195)
        Me.pagGeneral.TabIndex = 0
        Me.pagGeneral.Text = "General"
        Me.pagGeneral.UseVisualStyleBackColor = True
        '
        'CiGroupBox2
        '
        Me.CiGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CiGroupBox2.Controls.Add(Me.txtReferencia)
        Me.CiGroupBox2.Controls.Add(Me.CiLabel17)
        Me.CiGroupBox2.Controls.Add(Me.txtOrdenCompra)
        Me.CiGroupBox2.Controls.Add(Me.CiLabel16)
        Me.CiGroupBox2.Controls.Add(Me.lblTipoCambio)
        Me.CiGroupBox2.Controls.Add(Me.CiLabel2)
        Me.CiGroupBox2.Controls.Add(Me.cboDivisa)
        Me.CiGroupBox2.Controls.Add(Me.CiLabel13)
        Me.CiGroupBox2.Location = New System.Drawing.Point(541, 9)
        Me.CiGroupBox2.Name = "CiGroupBox2"
        Me.CiGroupBox2.Size = New System.Drawing.Size(293, 183)
        Me.CiGroupBox2.TabIndex = 8
        Me.CiGroupBox2.TabStop = False
        '
        'txtReferencia
        '
        Me.txtReferencia.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtReferencia.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtReferencia.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtReferencia.Location = New System.Drawing.Point(110, 96)
        Me.txtReferencia.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtReferencia.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(167, 20)
        Me.txtReferencia.TabIndex = 11
        '
        'CiLabel17
        '
        Me.CiLabel17.AutoSize = True
        Me.CiLabel17.Location = New System.Drawing.Point(11, 99)
        Me.CiLabel17.Name = "CiLabel17"
        Me.CiLabel17.Size = New System.Drawing.Size(62, 13)
        Me.CiLabel17.TabIndex = 10
        Me.CiLabel17.Text = "Referencia:"
        '
        'txtOrdenCompra
        '
        Me.txtOrdenCompra.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtOrdenCompra.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtOrdenCompra.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtOrdenCompra.Location = New System.Drawing.Point(110, 70)
        Me.txtOrdenCompra.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtOrdenCompra.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtOrdenCompra.Name = "txtOrdenCompra"
        Me.txtOrdenCompra.Size = New System.Drawing.Size(167, 20)
        Me.txtOrdenCompra.TabIndex = 9
        '
        'CiLabel16
        '
        Me.CiLabel16.AutoSize = True
        Me.CiLabel16.Location = New System.Drawing.Point(11, 75)
        Me.CiLabel16.Name = "CiLabel16"
        Me.CiLabel16.Size = New System.Drawing.Size(93, 13)
        Me.CiLabel16.TabIndex = 8
        Me.CiLabel16.Text = "Orden de Compra:"
        '
        'lblTipoCambio
        '
        Me.lblTipoCambio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTipoCambio.Location = New System.Drawing.Point(110, 48)
        Me.lblTipoCambio.Name = "lblTipoCambio"
        Me.lblTipoCambio.Size = New System.Drawing.Size(167, 19)
        Me.lblTipoCambio.TabIndex = 7
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(10, 49)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(84, 13)
        Me.CiLabel2.TabIndex = 6
        Me.CiLabel2.Text = "Tipo de Cambio:"
        '
        'cboDivisa
        '
        Me.cboDivisa.AutoClear = False
        Me.cboDivisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDivisa.FormattingEnabled = True
        Me.cboDivisa.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboDivisa.ItemsTable = Nothing
        Me.cboDivisa.Location = New System.Drawing.Point(110, 21)
        Me.cboDivisa.Name = "cboDivisa"
        Me.cboDivisa.RequiredField = True
        Me.cboDivisa.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboDivisa.Size = New System.Drawing.Size(167, 21)
        Me.cboDivisa.TabIndex = 5
        Me.cboDivisa.UIName = "Divisa"
        '
        'CiLabel13
        '
        Me.CiLabel13.AutoSize = True
        Me.CiLabel13.Location = New System.Drawing.Point(11, 24)
        Me.CiLabel13.Name = "CiLabel13"
        Me.CiLabel13.Size = New System.Drawing.Size(39, 13)
        Me.CiLabel13.TabIndex = 4
        Me.CiLabel13.Text = "Divisa:"
        '
        'CiGroupBox1
        '
        Me.CiGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CiGroupBox1.Controls.Add(Me.cboVendedor)
        Me.CiGroupBox1.Controls.Add(Me.dtpFecha)
        Me.CiGroupBox1.Controls.Add(Me.CiLabel15)
        Me.CiGroupBox1.Controls.Add(Me.CiLabel14)
        Me.CiGroupBox1.Controls.Add(Me.txtCliente)
        Me.CiGroupBox1.Controls.Add(Me.CiLabel1)
        Me.CiGroupBox1.Location = New System.Drawing.Point(6, 9)
        Me.CiGroupBox1.Name = "CiGroupBox1"
        Me.CiGroupBox1.Size = New System.Drawing.Size(529, 183)
        Me.CiGroupBox1.TabIndex = 7
        Me.CiGroupBox1.TabStop = False
        '
        'cboVendedor
        '
        Me.cboVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVendedor.FormattingEnabled = True
        Me.cboVendedor.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboVendedor.ItemsTable = Nothing
        Me.cboVendedor.Location = New System.Drawing.Point(76, 72)
        Me.cboVendedor.Name = "cboVendedor"
        Me.cboVendedor.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboVendedor.Size = New System.Drawing.Size(234, 21)
        Me.cboVendedor.TabIndex = 5
        Me.cboVendedor.UIName = "Vendedor"
        '
        'dtpFecha
        '
        Me.dtpFecha.AutoLock = False
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFecha.Location = New System.Drawing.Point(76, 19)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(234, 20)
        Me.dtpFecha.TabIndex = 4
        Me.dtpFecha.Value = New Date(2011, 10, 6, 0, 0, 0, 0)
        '
        'CiLabel15
        '
        Me.CiLabel15.AutoSize = True
        Me.CiLabel15.Location = New System.Drawing.Point(7, 21)
        Me.CiLabel15.Name = "CiLabel15"
        Me.CiLabel15.Size = New System.Drawing.Size(40, 13)
        Me.CiLabel15.TabIndex = 3
        Me.CiLabel15.Text = "Fecha:"
        '
        'CiLabel14
        '
        Me.CiLabel14.AutoSize = True
        Me.CiLabel14.Location = New System.Drawing.Point(7, 75)
        Me.CiLabel14.Name = "CiLabel14"
        Me.CiLabel14.Size = New System.Drawing.Size(56, 13)
        Me.CiLabel14.TabIndex = 2
        Me.CiLabel14.Text = "Vendedor:"
        '
        'txtCliente
        '
        Me.txtCliente.AnySite = False
        Me.txtCliente.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtCliente.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCliente.EditorAssembly = "Azteca.VentasWin"
        Me.txtCliente.EditorClass = "Azteca.Windows.Ventas.ClientesForm"
        Me.txtCliente.EditorTitle = "Editar datos de cliente..."
        Me.txtCliente.Key = 0
        Me.txtCliente.Linked = False
        Me.txtCliente.Location = New System.Drawing.Point(76, 43)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.txtCliente.Size = New System.Drawing.Size(414, 23)
        Me.txtCliente.TabIndex = 1
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(7, 48)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(42, 13)
        Me.CiLabel1.TabIndex = 0
        Me.CiLabel1.Text = "Cliente:"
        '
        'pagEmbarques
        '
        Me.pagEmbarques.Controls.Add(Me.tlbEmbarques)
        Me.pagEmbarques.Controls.Add(Me.grdEmbarques)
        Me.pagEmbarques.ImageKey = "Embarques"
        Me.pagEmbarques.Location = New System.Drawing.Point(4, 36)
        Me.pagEmbarques.Name = "pagEmbarques"
        Me.pagEmbarques.Padding = New System.Windows.Forms.Padding(3)
        Me.pagEmbarques.Size = New System.Drawing.Size(840, 195)
        Me.pagEmbarques.TabIndex = 3
        Me.pagEmbarques.Text = "Embarques"
        Me.pagEmbarques.UseVisualStyleBackColor = True
        '
        'tlbEmbarques
        '
        Me.tlbEmbarques.AccessibleName = "Tool Bar"
        Me.tlbEmbarques.AutoSize = False
        Me.tlbEmbarques.CommandHolder = Me.C1CommandHolder1
        Me.tlbEmbarques.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.btnNuevoEmbarque})
        Me.tlbEmbarques.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbEmbarques.Location = New System.Drawing.Point(3, 3)
        Me.tlbEmbarques.MinButtonSize = 32
        Me.tlbEmbarques.Movable = False
        Me.tlbEmbarques.Name = "tlbEmbarques"
        Me.tlbEmbarques.Size = New System.Drawing.Size(834, 33)
        Me.tlbEmbarques.Text = "C1ToolBar1"
        Me.tlbEmbarques.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdNuevoEmbarque)
        Me.C1CommandHolder1.Owner = Me
        '
        'cmdNuevoEmbarque
        '
        Me.cmdNuevoEmbarque.Image = CType(resources.GetObject("cmdNuevoEmbarque.Image"), System.Drawing.Image)
        Me.cmdNuevoEmbarque.Name = "cmdNuevoEmbarque"
        Me.cmdNuevoEmbarque.Text = "Nuevo Embarque"
        '
        'btnNuevoEmbarque
        '
        Me.btnNuevoEmbarque.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnNuevoEmbarque.Command = Me.cmdNuevoEmbarque
        '
        'grdEmbarques
        '
        Me.grdEmbarques.AllowUpdate = False
        Me.grdEmbarques.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdEmbarques.DataSource = Me.bsEmbarques
        Me.grdEmbarques.Images.Add(CType(resources.GetObject("grdEmbarques.Images"), System.Drawing.Image))
        Me.grdEmbarques.Location = New System.Drawing.Point(3, 42)
        Me.grdEmbarques.Name = "grdEmbarques"
        Me.grdEmbarques.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdEmbarques.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdEmbarques.PreviewInfo.ZoomFactor = 75.0R
        Me.grdEmbarques.PrintInfo.PageSettings = CType(resources.GetObject("grdEmbarques.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdEmbarques.Size = New System.Drawing.Size(831, 147)
        Me.grdEmbarques.TabIndex = 0
        Me.grdEmbarques.Text = "AzTrueDBGrid1"
        Me.grdEmbarques.PropBag = resources.GetString("grdEmbarques.PropBag")
        '
        'pagEntregaSvc
        '
        Me.pagEntregaSvc.ImageKey = "Servicios"
        Me.pagEntregaSvc.Location = New System.Drawing.Point(4, 36)
        Me.pagEntregaSvc.Name = "pagEntregaSvc"
        Me.pagEntregaSvc.Size = New System.Drawing.Size(840, 195)
        Me.pagEntregaSvc.TabIndex = 4
        Me.pagEntregaSvc.Text = "Facturación Servicios"
        Me.pagEntregaSvc.UseVisualStyleBackColor = True
        '
        'pagNotas
        '
        Me.pagNotas.Controls.Add(Me.txtNotas)
        Me.pagNotas.ImageKey = "Notas"
        Me.pagNotas.Location = New System.Drawing.Point(4, 36)
        Me.pagNotas.Name = "pagNotas"
        Me.pagNotas.Padding = New System.Windows.Forms.Padding(3)
        Me.pagNotas.Size = New System.Drawing.Size(928, 195)
        Me.pagNotas.TabIndex = 2
        Me.pagNotas.Text = "Notas"
        Me.pagNotas.UseVisualStyleBackColor = True
        '
        'txtNotas
        '
        Me.txtNotas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNotas.BackColor = System.Drawing.SystemColors.Window
        Me.txtNotas.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNotas.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNotas.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNotas.Location = New System.Drawing.Point(6, 6)
        Me.txtNotas.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNotas.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNotas.Multiline = True
        Me.txtNotas.Name = "txtNotas"
        Me.txtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtNotas.Size = New System.Drawing.Size(764, 205)
        Me.txtNotas.TabIndex = 0
        Me.txtNotas.WordWrap = False
        '
        'tabPartidas
        '
        Me.tabPartidas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabPartidas.Controls.Add(Me.pagArticulos)
        Me.tabPartidas.Controls.Add(Me.pagServicios)
        Me.tabPartidas.ImageList = Me.imlPartidas
        Me.tabPartidas.ItemSize = New System.Drawing.Size(76, 32)
        Me.tabPartidas.Location = New System.Drawing.Point(12, 326)
        Me.tabPartidas.Name = "tabPartidas"
        Me.tabPartidas.SelectedIndex = 0
        Me.tabPartidas.Size = New System.Drawing.Size(848, 284)
        Me.tabPartidas.TabIndex = 38
        '
        'pagArticulos
        '
        Me.pagArticulos.Controls.Add(Me.cboUnidades)
        Me.pagArticulos.Controls.Add(Me.grdArticulos)
        Me.pagArticulos.ImageKey = "Articulos"
        Me.pagArticulos.Location = New System.Drawing.Point(4, 36)
        Me.pagArticulos.Name = "pagArticulos"
        Me.pagArticulos.Padding = New System.Windows.Forms.Padding(3)
        Me.pagArticulos.Size = New System.Drawing.Size(840, 244)
        Me.pagArticulos.TabIndex = 0
        Me.pagArticulos.Text = "Artículos"
        Me.pagArticulos.UseVisualStyleBackColor = True
        '
        'cboUnidades
        '
        Me.cboUnidades.AllowColMove = True
        Me.cboUnidades.AllowColSelect = True
        Me.cboUnidades.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboUnidades.AlternatingRows = True
        Me.cboUnidades.CaptionStyle = Style33
        Me.cboUnidades.ColumnCaptionHeight = 17
        Me.cboUnidades.ColumnFooterHeight = 17
        Me.cboUnidades.DataSource = Me.bsUnidades
        Me.cboUnidades.DisplayMember = "IdUnidadMedida"
        Me.cboUnidades.EvenRowStyle = Style34
        Me.cboUnidades.ExtendRightColumn = True
        Me.cboUnidades.FetchRowStyles = False
        Me.cboUnidades.FooterStyle = Style35
        Me.cboUnidades.HeadingStyle = Style36
        Me.cboUnidades.HighLightRowStyle = Style37
        Me.cboUnidades.Images.Add(CType(resources.GetObject("cboUnidades.Images"), System.Drawing.Image))
        Me.cboUnidades.Location = New System.Drawing.Point(284, 37)
        Me.cboUnidades.Name = "cboUnidades"
        Me.cboUnidades.OddRowStyle = Style38
        Me.cboUnidades.RecordSelectorStyle = Style39
        Me.cboUnidades.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboUnidades.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboUnidades.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboUnidades.ScrollTips = False
        Me.cboUnidades.Size = New System.Drawing.Size(264, 179)
        Me.cboUnidades.Style = Style40
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
        Me.grdArticulos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdArticulos.ColumnFooters = True
        Me.grdArticulos.DataSource = Me.bsArticulos
        Me.grdArticulos.Images.Add(CType(resources.GetObject("grdArticulos.Images"), System.Drawing.Image))
        Me.grdArticulos.Images.Add(CType(resources.GetObject("grdArticulos.Images1"), System.Drawing.Image))
        Me.grdArticulos.Location = New System.Drawing.Point(3, 3)
        Me.grdArticulos.Name = "grdArticulos"
        Me.grdArticulos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdArticulos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdArticulos.PreviewInfo.ZoomFactor = 75.0R
        Me.grdArticulos.PrintInfo.PageSettings = CType(resources.GetObject("grdArticulos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdArticulos.Size = New System.Drawing.Size(837, 241)
        Me.grdArticulos.TabIndex = 2
        Me.grdArticulos.Text = "AzTrueDBGrid1"
        Me.grdArticulos.PropBag = resources.GetString("grdArticulos.PropBag")
        '
        'pagServicios
        '
        Me.pagServicios.Controls.Add(Me.grdServicios)
        Me.pagServicios.ImageKey = "Servicios"
        Me.pagServicios.Location = New System.Drawing.Point(4, 36)
        Me.pagServicios.Name = "pagServicios"
        Me.pagServicios.Padding = New System.Windows.Forms.Padding(3)
        Me.pagServicios.Size = New System.Drawing.Size(928, 244)
        Me.pagServicios.TabIndex = 1
        Me.pagServicios.Text = "Servicios"
        Me.pagServicios.UseVisualStyleBackColor = True
        '
        'grdServicios
        '
        Me.grdServicios.AllowAddNew = True
        Me.grdServicios.AllowDelete = True
        Me.grdServicios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdServicios.DataSource = Me.bsServicios
        Me.grdServicios.Images.Add(CType(resources.GetObject("grdServicios.Images"), System.Drawing.Image))
        Me.grdServicios.Images.Add(CType(resources.GetObject("grdServicios.Images1"), System.Drawing.Image))
        Me.grdServicios.Location = New System.Drawing.Point(3, 6)
        Me.grdServicios.Name = "grdServicios"
        Me.grdServicios.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdServicios.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdServicios.PreviewInfo.ZoomFactor = 75.0R
        Me.grdServicios.PrintInfo.PageSettings = CType(resources.GetObject("grdServicios.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdServicios.Size = New System.Drawing.Size(770, 210)
        Me.grdServicios.TabIndex = 2
        Me.grdServicios.Text = "AzTrueDBGrid1"
        Me.grdServicios.PropBag = resources.GetString("grdServicios.PropBag")
        '
        'PedidosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 635)
        Me.Controls.Add(Me.tabPartidas)
        Me.Controls.Add(Me.tabVenta)
        Me.Name = "PedidosForm"
        Me.Text = "PedidosForm"
        Me.Controls.SetChildIndex(Me.tabVenta, 0)
        Me.Controls.SetChildIndex(Me.tabPartidas, 0)
        CType(Me.bsUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabVenta.ResumeLayout(False)
        Me.pagGeneral.ResumeLayout(False)
        Me.CiGroupBox2.ResumeLayout(False)
        Me.CiGroupBox2.PerformLayout()
        Me.CiGroupBox1.ResumeLayout(False)
        Me.CiGroupBox1.PerformLayout()
        Me.pagEmbarques.ResumeLayout(False)
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEmbarques, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsEmbarques, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagNotas.ResumeLayout(False)
        Me.pagNotas.PerformLayout()
        Me.tabPartidas.ResumeLayout(False)
        Me.pagArticulos.ResumeLayout(False)
        CType(Me.cboUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagServicios.ResumeLayout(False)
        CType(Me.grdServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New PedidoFacade
        SetDocumentType("PedidoVenta")
    End Sub
    Friend WithEvents tabVenta As Azteca.Windows.Controls.CITab
    Friend WithEvents pagGeneral As System.Windows.Forms.TabPage
    Friend WithEvents CiGroupBox2 As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents cboDivisa As Azteca.Windows.Contabilidad.DivisasComboBox
    Friend WithEvents CiLabel13 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiGroupBox1 As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents CiLabel14 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCliente As Azteca.Windows.Ventas.ClienteSelector
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents pagNotas As System.Windows.Forms.TabPage
    Friend WithEvents txtNotas As Azteca.Windows.Controls.CITextBox
    Friend WithEvents tabPartidas As Azteca.Windows.Controls.CITab
    Friend WithEvents pagArticulos As System.Windows.Forms.TabPage
    Friend WithEvents cboUnidades As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents grdArticulos As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents pagServicios As System.Windows.Forms.TabPage
    Friend WithEvents grdServicios As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents lblTipoCambio As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents dtpFecha As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents CiLabel15 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboVendedor As Azteca.Windows.Ventas.VendedoresComboBox
    Friend WithEvents pagEmbarques As System.Windows.Forms.TabPage
    Friend WithEvents pagEntregaSvc As System.Windows.Forms.TabPage
    Friend WithEvents txtReferencia As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel17 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtOrdenCompra As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel16 As Azteca.Windows.Controls.CILabel
    Friend WithEvents grdEmbarques As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents bsEmbarques As System.Windows.Forms.BindingSource
    Friend WithEvents tlbEmbarques As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents cmdNuevoEmbarque As C1.Win.C1Command.C1Command
    Friend WithEvents btnNuevoEmbarque As C1.Win.C1Command.C1CommandLink
    Private WithEvents imlPedido As System.Windows.Forms.ImageList
    Private WithEvents bsUnidades As System.Windows.Forms.BindingSource
    Private WithEvents bsArticulos As System.Windows.Forms.BindingSource
    Private WithEvents bsServicios As System.Windows.Forms.BindingSource
    Private WithEvents imlPartidas As System.Windows.Forms.ImageList
End Class
