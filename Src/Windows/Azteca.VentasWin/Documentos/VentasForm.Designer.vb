<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentasForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentasForm))
        Dim Style1 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style2 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style3 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style4 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style5 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style6 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style7 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style8 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Me.CiGroupBox2 = New Azteca.Windows.Controls.CIGroupBox()
        Me.cboCaja = New Azteca.Windows.Ventas.CajaCombobox()
        Me.CiLabel15 = New Azteca.Windows.Controls.CILabel()
        Me.grpCondicionesPago = New Azteca.Windows.Controls.CIGroupBox()
        Me.rdbCredito = New Azteca.Windows.Controls.CIRadioButton()
        Me.rdbContado = New Azteca.Windows.Controls.CIRadioButton()
        Me.cboDivisa = New Azteca.Windows.Contabilidad.DivisasComboBox()
        Me.CiLabel13 = New Azteca.Windows.Controls.CILabel()
        Me.CiGroupBox1 = New Azteca.Windows.Controls.CIGroupBox()
        Me.txtVendedor = New Azteca.Windows.Ventas.VendedorSelector()
        Me.CiLabel14 = New Azteca.Windows.Controls.CILabel()
        Me.txtCliente = New Azteca.Windows.Ventas.ClienteSelector()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel12 = New Azteca.Windows.Controls.CILabel()
        Me.txtTipoCambio = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel11 = New Azteca.Windows.Controls.CILabel()
        Me.txtDivisa = New Azteca.Windows.Controls.CITextBox()
        Me.txtTotal = New Azteca.Windows.Controls.CITextBox()
        Me.txtDescuentos = New Azteca.Windows.Controls.CITextBox()
        Me.txtRetenciones = New Azteca.Windows.Controls.CITextBox()
        Me.txtImpuestos = New Azteca.Windows.Controls.CITextBox()
        Me.txtSubTotal = New Azteca.Windows.Controls.CITextBox()
        Me.txtTotalCant = New Azteca.Windows.Controls.CITextBox()
        Me.txtFechaFactura = New Azteca.Windows.Controls.CITextBox()
        Me.txtFactura = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel10 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel9 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel8 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel7 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel6 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel5 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.txtReferencia = New Azteca.Windows.Controls.CITextBox()
        Me.txtOrdenCompra = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel17 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel16 = New Azteca.Windows.Controls.CILabel()
        Me.txtNotas = New Azteca.Windows.Controls.CITextBox()
        Me.imlVenta = New System.Windows.Forms.ImageList(Me.components)
        Me.cboUnidades = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.bsUnidades = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdArticulos = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsArticulos = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdServicios = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsServicios = New System.Windows.Forms.BindingSource(Me.components)
        Me.imlPartidas = New System.Windows.Forms.ImageList(Me.components)
        Me.tabDocumento = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagGeneral = New C1.Win.C1Command.C1DockingTabPage()
        Me.pagFacturacion = New C1.Win.C1Command.C1DockingTabPage()
        Me.pagNotas = New C1.Win.C1Command.C1DockingTabPage()
        Me.CiLabel21 = New Azteca.Windows.Controls.CILabel()
        Me.OrdenTrabajoSel = New Azteca.Windows.Produccion.OrdenTrabajoSelector()
        Me.CiLabel20 = New Azteca.Windows.Controls.CILabel()
        Me.txtFolioFacturaExt = New Azteca.Windows.Controls.CITextBox()
        Me.C1DockingTabPage1 = New C1.Win.C1Command.C1DockingTabPage()
        Me.dtpFechaPedimento = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.txtAduana = New Azteca.Windows.Controls.CITextBox()
        Me.txtNumPedimento = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel19 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel18 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.tabPartidas = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagArticulos = New C1.Win.C1Command.C1DockingTabPage()
        Me.pagServicios = New C1.Win.C1Command.C1DockingTabPage()
        Me.CiGroupBox2.SuspendLayout()
        Me.grpCondicionesPago.SuspendLayout()
        Me.CiGroupBox1.SuspendLayout()
        CType(Me.cboUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDocumento.SuspendLayout()
        Me.pagGeneral.SuspendLayout()
        Me.pagFacturacion.SuspendLayout()
        Me.pagNotas.SuspendLayout()
        Me.C1DockingTabPage1.SuspendLayout()
        CType(Me.tabPartidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPartidas.SuspendLayout()
        Me.pagArticulos.SuspendLayout()
        Me.pagServicios.SuspendLayout()
        Me.SuspendLayout()
        '
        'CiGroupBox2
        '
        Me.CiGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CiGroupBox2.Controls.Add(Me.cboCaja)
        Me.CiGroupBox2.Controls.Add(Me.CiLabel15)
        Me.CiGroupBox2.Controls.Add(Me.grpCondicionesPago)
        Me.CiGroupBox2.Controls.Add(Me.cboDivisa)
        Me.CiGroupBox2.Controls.Add(Me.CiLabel13)
        Me.CiGroupBox2.Location = New System.Drawing.Point(463, 13)
        Me.CiGroupBox2.Name = "CiGroupBox2"
        Me.CiGroupBox2.Size = New System.Drawing.Size(316, 162)
        Me.CiGroupBox2.TabIndex = 8
        Me.CiGroupBox2.TabStop = False
        '
        'cboCaja
        '
        Me.cboCaja.AutoClear = False
        Me.cboCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCaja.FormattingEnabled = True
        Me.cboCaja.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboCaja.ItemsTable = Nothing
        Me.cboCaja.Location = New System.Drawing.Point(95, 16)
        Me.cboCaja.Name = "cboCaja"
        Me.cboCaja.RequiredField = True
        Me.cboCaja.Size = New System.Drawing.Size(200, 21)
        Me.cboCaja.TabIndex = 1
        Me.cboCaja.UIName = "Caja"
        '
        'CiLabel15
        '
        Me.CiLabel15.AutoSize = True
        Me.CiLabel15.Location = New System.Drawing.Point(12, 19)
        Me.CiLabel15.Name = "CiLabel15"
        Me.CiLabel15.Size = New System.Drawing.Size(31, 13)
        Me.CiLabel15.TabIndex = 0
        Me.CiLabel15.Text = "Caja:"
        '
        'grpCondicionesPago
        '
        Me.grpCondicionesPago.Controls.Add(Me.rdbCredito)
        Me.grpCondicionesPago.Controls.Add(Me.rdbContado)
        Me.grpCondicionesPago.Enabled = False
        Me.grpCondicionesPago.Location = New System.Drawing.Point(95, 97)
        Me.grpCondicionesPago.Name = "grpCondicionesPago"
        Me.grpCondicionesPago.Size = New System.Drawing.Size(200, 48)
        Me.grpCondicionesPago.TabIndex = 4
        Me.grpCondicionesPago.TabStop = False
        Me.grpCondicionesPago.Text = "Condiciones de Pago"
        '
        'rdbCredito
        '
        Me.rdbCredito.AutoSize = True
        Me.rdbCredito.Location = New System.Drawing.Point(110, 19)
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
        Me.rdbContado.Location = New System.Drawing.Point(23, 19)
        Me.rdbContado.Name = "rdbContado"
        Me.rdbContado.Size = New System.Drawing.Size(65, 17)
        Me.rdbContado.TabIndex = 0
        Me.rdbContado.TabStop = True
        Me.rdbContado.Text = "Contado"
        Me.rdbContado.UseVisualStyleBackColor = True
        '
        'cboDivisa
        '
        Me.cboDivisa.AutoClear = False
        Me.cboDivisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDivisa.FormattingEnabled = True
        Me.cboDivisa.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboDivisa.ItemsTable = Nothing
        Me.cboDivisa.Location = New System.Drawing.Point(95, 43)
        Me.cboDivisa.Name = "cboDivisa"
        Me.cboDivisa.RequiredField = True
        Me.cboDivisa.Size = New System.Drawing.Size(200, 21)
        Me.cboDivisa.TabIndex = 3
        Me.cboDivisa.UIName = "Divisa"
        '
        'CiLabel13
        '
        Me.CiLabel13.AutoSize = True
        Me.CiLabel13.Location = New System.Drawing.Point(12, 46)
        Me.CiLabel13.Name = "CiLabel13"
        Me.CiLabel13.Size = New System.Drawing.Size(39, 13)
        Me.CiLabel13.TabIndex = 2
        Me.CiLabel13.Text = "Divisa:"
        '
        'CiGroupBox1
        '
        Me.CiGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CiGroupBox1.Controls.Add(Me.txtVendedor)
        Me.CiGroupBox1.Controls.Add(Me.CiLabel14)
        Me.CiGroupBox1.Controls.Add(Me.txtCliente)
        Me.CiGroupBox1.Controls.Add(Me.CiLabel1)
        Me.CiGroupBox1.Location = New System.Drawing.Point(9, 13)
        Me.CiGroupBox1.Name = "CiGroupBox1"
        Me.CiGroupBox1.Size = New System.Drawing.Size(448, 162)
        Me.CiGroupBox1.TabIndex = 7
        Me.CiGroupBox1.TabStop = False
        '
        'txtVendedor
        '
        Me.txtVendedor.AnySite = False
        Me.txtVendedor.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtVendedor.EditorAssembly = "Azteca.VentasWin"
        Me.txtVendedor.EditorClass = "Azteca.Windows.Ventas.VendedoresForm"
        Me.txtVendedor.EditorTitle = "Editar datos de vendedor..."
        Me.txtVendedor.Key = 0
        Me.txtVendedor.Linked = False
        Me.txtVendedor.Location = New System.Drawing.Point(80, 48)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.RequiredField = True
        Me.txtVendedor.Size = New System.Drawing.Size(351, 23)
        Me.txtVendedor.TabIndex = 3
        Me.txtVendedor.UIName = "Vendedor"
        '
        'CiLabel14
        '
        Me.CiLabel14.AutoSize = True
        Me.CiLabel14.Location = New System.Drawing.Point(11, 53)
        Me.CiLabel14.Name = "CiLabel14"
        Me.CiLabel14.Size = New System.Drawing.Size(56, 13)
        Me.CiLabel14.TabIndex = 2
        Me.CiLabel14.Text = "Vendedor:"
        '
        'txtCliente
        '
        Me.txtCliente.AnySite = False
        Me.txtCliente.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtCliente.EditorAssembly = "Azteca.VentasWin"
        Me.txtCliente.EditorClass = "Azteca.Windows.Ventas.ClientesForm"
        Me.txtCliente.EditorTitle = "Editar datos de cliente..."
        Me.txtCliente.Key = 0
        Me.txtCliente.Linked = False
        Me.txtCliente.Location = New System.Drawing.Point(80, 19)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(351, 23)
        Me.txtCliente.TabIndex = 1
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(11, 24)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(42, 13)
        Me.CiLabel1.TabIndex = 0
        Me.CiLabel1.Text = "Cliente:"
        '
        'CiLabel12
        '
        Me.CiLabel12.AutoSize = True
        Me.CiLabel12.Location = New System.Drawing.Point(18, 123)
        Me.CiLabel12.Name = "CiLabel12"
        Me.CiLabel12.Size = New System.Drawing.Size(84, 13)
        Me.CiLabel12.TabIndex = 19
        Me.CiLabel12.Text = "Tipo de Cambio:"
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.AutoLock = False
        Me.txtTipoCambio.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTipoCambio.Location = New System.Drawing.Point(108, 123)
        Me.txtTipoCambio.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTipoCambio.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.ReadOnly = True
        Me.txtTipoCambio.Size = New System.Drawing.Size(120, 20)
        Me.txtTipoCambio.TabIndex = 18
        Me.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CiLabel11
        '
        Me.CiLabel11.AutoSize = True
        Me.CiLabel11.Location = New System.Drawing.Point(18, 97)
        Me.CiLabel11.Name = "CiLabel11"
        Me.CiLabel11.Size = New System.Drawing.Size(39, 13)
        Me.CiLabel11.TabIndex = 17
        Me.CiLabel11.Text = "Divisa:"
        '
        'txtDivisa
        '
        Me.txtDivisa.AutoLock = False
        Me.txtDivisa.BackColor = System.Drawing.SystemColors.Control
        Me.txtDivisa.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtDivisa.Location = New System.Drawing.Point(108, 98)
        Me.txtDivisa.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDivisa.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDivisa.Name = "txtDivisa"
        Me.txtDivisa.ReadOnly = True
        Me.txtDivisa.Size = New System.Drawing.Size(120, 20)
        Me.txtDivisa.TabIndex = 16
        '
        'txtTotal
        '
        Me.txtTotal.AutoLock = False
        Me.txtTotal.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTotal.Location = New System.Drawing.Point(342, 120)
        Me.txtTotal.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotal.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(120, 20)
        Me.txtTotal.TabIndex = 15
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDescuentos
        '
        Me.txtDescuentos.AutoLock = False
        Me.txtDescuentos.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtDescuentos.Location = New System.Drawing.Point(342, 94)
        Me.txtDescuentos.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDescuentos.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDescuentos.Name = "txtDescuentos"
        Me.txtDescuentos.ReadOnly = True
        Me.txtDescuentos.Size = New System.Drawing.Size(120, 20)
        Me.txtDescuentos.TabIndex = 13
        Me.txtDescuentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRetenciones
        '
        Me.txtRetenciones.AutoLock = False
        Me.txtRetenciones.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtRetenciones.Location = New System.Drawing.Point(342, 68)
        Me.txtRetenciones.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRetenciones.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRetenciones.Name = "txtRetenciones"
        Me.txtRetenciones.ReadOnly = True
        Me.txtRetenciones.Size = New System.Drawing.Size(120, 20)
        Me.txtRetenciones.TabIndex = 11
        Me.txtRetenciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImpuestos
        '
        Me.txtImpuestos.AutoLock = False
        Me.txtImpuestos.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtImpuestos.Location = New System.Drawing.Point(342, 42)
        Me.txtImpuestos.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtImpuestos.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtImpuestos.Name = "txtImpuestos"
        Me.txtImpuestos.ReadOnly = True
        Me.txtImpuestos.Size = New System.Drawing.Size(120, 20)
        Me.txtImpuestos.TabIndex = 9
        Me.txtImpuestos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotal
        '
        Me.txtSubTotal.AutoLock = False
        Me.txtSubTotal.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtSubTotal.Location = New System.Drawing.Point(342, 17)
        Me.txtSubTotal.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSubTotal.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(120, 20)
        Me.txtSubTotal.TabIndex = 7
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalCant
        '
        Me.txtTotalCant.AutoLock = False
        Me.txtTotalCant.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTotalCant.Location = New System.Drawing.Point(108, 72)
        Me.txtTotalCant.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotalCant.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotalCant.Name = "txtTotalCant"
        Me.txtTotalCant.ReadOnly = True
        Me.txtTotalCant.Size = New System.Drawing.Size(120, 20)
        Me.txtTotalCant.TabIndex = 5
        Me.txtTotalCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFechaFactura
        '
        Me.txtFechaFactura.AutoLock = False
        Me.txtFechaFactura.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtFechaFactura.Location = New System.Drawing.Point(108, 46)
        Me.txtFechaFactura.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFechaFactura.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFechaFactura.Name = "txtFechaFactura"
        Me.txtFechaFactura.ReadOnly = True
        Me.txtFechaFactura.Size = New System.Drawing.Size(120, 20)
        Me.txtFechaFactura.TabIndex = 3
        '
        'txtFactura
        '
        Me.txtFactura.AutoLock = False
        Me.txtFactura.BackColor = System.Drawing.SystemColors.Window
        Me.txtFactura.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtFactura.Location = New System.Drawing.Point(108, 21)
        Me.txtFactura.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFactura.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.ReadOnly = True
        Me.txtFactura.Size = New System.Drawing.Size(120, 20)
        Me.txtFactura.TabIndex = 1
        '
        'CiLabel10
        '
        Me.CiLabel10.AutoSize = True
        Me.CiLabel10.Location = New System.Drawing.Point(18, 45)
        Me.CiLabel10.Name = "CiLabel10"
        Me.CiLabel10.Size = New System.Drawing.Size(79, 13)
        Me.CiLabel10.TabIndex = 2
        Me.CiLabel10.Text = "Fecha Factura:"
        '
        'CiLabel9
        '
        Me.CiLabel9.AutoSize = True
        Me.CiLabel9.Location = New System.Drawing.Point(18, 20)
        Me.CiLabel9.Name = "CiLabel9"
        Me.CiLabel9.Size = New System.Drawing.Size(46, 13)
        Me.CiLabel9.TabIndex = 0
        Me.CiLabel9.Text = "Factura:"
        '
        'CiLabel8
        '
        Me.CiLabel8.AutoSize = True
        Me.CiLabel8.Location = New System.Drawing.Point(240, 123)
        Me.CiLabel8.Name = "CiLabel8"
        Me.CiLabel8.Size = New System.Drawing.Size(34, 13)
        Me.CiLabel8.TabIndex = 14
        Me.CiLabel8.Text = "Total:"
        '
        'CiLabel7
        '
        Me.CiLabel7.AutoSize = True
        Me.CiLabel7.Location = New System.Drawing.Point(239, 97)
        Me.CiLabel7.Name = "CiLabel7"
        Me.CiLabel7.Size = New System.Drawing.Size(94, 13)
        Me.CiLabel7.TabIndex = 12
        Me.CiLabel7.Text = "Total Descuentos:"
        '
        'CiLabel6
        '
        Me.CiLabel6.AutoSize = True
        Me.CiLabel6.Location = New System.Drawing.Point(239, 72)
        Me.CiLabel6.Name = "CiLabel6"
        Me.CiLabel6.Size = New System.Drawing.Size(97, 13)
        Me.CiLabel6.TabIndex = 10
        Me.CiLabel6.Text = "Total Retenciones:"
        '
        'CiLabel5
        '
        Me.CiLabel5.AutoSize = True
        Me.CiLabel5.Location = New System.Drawing.Point(239, 45)
        Me.CiLabel5.Name = "CiLabel5"
        Me.CiLabel5.Size = New System.Drawing.Size(85, 13)
        Me.CiLabel5.TabIndex = 8
        Me.CiLabel5.Text = "Total Impuestos:"
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.Location = New System.Drawing.Point(240, 20)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(56, 13)
        Me.CiLabel4.TabIndex = 6
        Me.CiLabel4.Text = "Sub Total:"
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(18, 71)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(79, 13)
        Me.CiLabel3.TabIndex = 4
        Me.CiLabel3.Text = "Total Cantidad:"
        '
        'txtReferencia
        '
        Me.txtReferencia.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtReferencia.Location = New System.Drawing.Point(119, 74)
        Me.txtReferencia.MaxLength = 18
        Me.txtReferencia.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtReferencia.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(197, 20)
        Me.txtReferencia.TabIndex = 4
        '
        'txtOrdenCompra
        '
        Me.txtOrdenCompra.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtOrdenCompra.Location = New System.Drawing.Point(119, 15)
        Me.txtOrdenCompra.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtOrdenCompra.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtOrdenCompra.Name = "txtOrdenCompra"
        Me.txtOrdenCompra.Size = New System.Drawing.Size(197, 20)
        Me.txtOrdenCompra.TabIndex = 3
        '
        'CiLabel17
        '
        Me.CiLabel17.AutoSize = True
        Me.CiLabel17.Location = New System.Drawing.Point(20, 77)
        Me.CiLabel17.Name = "CiLabel17"
        Me.CiLabel17.Size = New System.Drawing.Size(62, 13)
        Me.CiLabel17.TabIndex = 2
        Me.CiLabel17.Text = "Referencia:"
        '
        'CiLabel16
        '
        Me.CiLabel16.AutoSize = True
        Me.CiLabel16.Location = New System.Drawing.Point(20, 15)
        Me.CiLabel16.Name = "CiLabel16"
        Me.CiLabel16.Size = New System.Drawing.Size(93, 13)
        Me.CiLabel16.TabIndex = 1
        Me.CiLabel16.Text = "Orden de Compra:"
        '
        'txtNotas
        '
        Me.txtNotas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNotas.BackColor = System.Drawing.SystemColors.Window
        Me.txtNotas.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNotas.Location = New System.Drawing.Point(322, 15)
        Me.txtNotas.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNotas.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNotas.Multiline = True
        Me.txtNotas.Name = "txtNotas"
        Me.txtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtNotas.Size = New System.Drawing.Size(453, 122)
        Me.txtNotas.TabIndex = 0
        Me.txtNotas.WordWrap = False
        '
        'imlVenta
        '
        Me.imlVenta.ImageStream = CType(resources.GetObject("imlVenta.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlVenta.TransparentColor = System.Drawing.Color.Transparent
        Me.imlVenta.Images.SetKeyName(0, "General")
        Me.imlVenta.Images.SetKeyName(1, "Facturacion")
        Me.imlVenta.Images.SetKeyName(2, "Notas")
        '
        'cboUnidades
        '
        Me.cboUnidades.AllowColMove = True
        Me.cboUnidades.AllowColSelect = True
        Me.cboUnidades.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboUnidades.AlternatingRows = True
        Me.cboUnidades.CaptionStyle = Style1
        Me.cboUnidades.ColumnCaptionHeight = 17
        Me.cboUnidades.ColumnFooterHeight = 17
        Me.cboUnidades.DataSource = Me.bsUnidades
        Me.cboUnidades.DisplayMember = "IdUnidadMedida"
        Me.cboUnidades.EvenRowStyle = Style2
        Me.cboUnidades.ExtendRightColumn = True
        Me.cboUnidades.FetchRowStyles = False
        Me.cboUnidades.FooterStyle = Style3
        Me.cboUnidades.HeadingStyle = Style4
        Me.cboUnidades.HighLightRowStyle = Style5
        Me.cboUnidades.Images.Add(CType(resources.GetObject("cboUnidades.Images"), System.Drawing.Image))
        Me.cboUnidades.Location = New System.Drawing.Point(289, 32)
        Me.cboUnidades.Name = "cboUnidades"
        Me.cboUnidades.OddRowStyle = Style6
        Me.cboUnidades.RecordSelectorStyle = Style7
        Me.cboUnidades.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboUnidades.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboUnidades.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboUnidades.ScrollTips = False
        Me.cboUnidades.Size = New System.Drawing.Size(264, 162)
        Me.cboUnidades.Style = Style8
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
        Me.grdArticulos.Size = New System.Drawing.Size(788, 124)
        Me.grdArticulos.TabIndex = 2
        Me.grdArticulos.Text = "AzTrueDBGrid1"
        Me.grdArticulos.PropBag = resources.GetString("grdArticulos.PropBag")
        '
        'bsArticulos
        '
        Me.bsArticulos.Filter = ""
        '
        'grdServicios
        '
        Me.grdServicios.AllowAddNew = True
        Me.grdServicios.AllowDelete = True
        Me.grdServicios.DataSource = Me.bsServicios
        Me.grdServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdServicios.Images.Add(CType(resources.GetObject("grdServicios.Images"), System.Drawing.Image))
        Me.grdServicios.Images.Add(CType(resources.GetObject("grdServicios.Images1"), System.Drawing.Image))
        Me.grdServicios.Location = New System.Drawing.Point(0, 0)
        Me.grdServicios.Name = "grdServicios"
        Me.grdServicios.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdServicios.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdServicios.PreviewInfo.ZoomFactor = 75.0R
        Me.grdServicios.PrintInfo.PageSettings = CType(resources.GetObject("grdServicios.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdServicios.Size = New System.Drawing.Size(788, 124)
        Me.grdServicios.TabIndex = 2
        Me.grdServicios.Text = "AzTrueDBGrid1"
        Me.grdServicios.PropBag = resources.GetString("grdServicios.PropBag")
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
        'tabDocumento
        '
        Me.tabDocumento.Controls.Add(Me.pagGeneral)
        Me.tabDocumento.Controls.Add(Me.pagFacturacion)
        Me.tabDocumento.Controls.Add(Me.pagNotas)
        Me.tabDocumento.Controls.Add(Me.C1DockingTabPage1)
        Me.tabDocumento.ImageList = Me.imlVenta
        Me.tabDocumento.Location = New System.Drawing.Point(12, 90)
        Me.tabDocumento.Name = "tabDocumento"
        Me.tabDocumento.SelectedIndex = 3
        Me.tabDocumento.Size = New System.Drawing.Size(790, 233)
        Me.tabDocumento.TabIndex = 38
        Me.tabDocumento.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabDocumento.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabDocumento.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagGeneral
        '
        Me.pagGeneral.Controls.Add(Me.CiGroupBox2)
        Me.pagGeneral.Controls.Add(Me.CiGroupBox1)
        Me.pagGeneral.ImageIndex = 0
        Me.pagGeneral.Location = New System.Drawing.Point(1, 41)
        Me.pagGeneral.Name = "pagGeneral"
        Me.pagGeneral.Size = New System.Drawing.Size(788, 191)
        Me.pagGeneral.TabIndex = 0
        Me.pagGeneral.Text = "General"
        '
        'pagFacturacion
        '
        Me.pagFacturacion.Controls.Add(Me.CiLabel12)
        Me.pagFacturacion.Controls.Add(Me.CiLabel9)
        Me.pagFacturacion.Controls.Add(Me.txtTipoCambio)
        Me.pagFacturacion.Controls.Add(Me.CiLabel3)
        Me.pagFacturacion.Controls.Add(Me.CiLabel11)
        Me.pagFacturacion.Controls.Add(Me.CiLabel4)
        Me.pagFacturacion.Controls.Add(Me.txtDivisa)
        Me.pagFacturacion.Controls.Add(Me.CiLabel5)
        Me.pagFacturacion.Controls.Add(Me.txtTotal)
        Me.pagFacturacion.Controls.Add(Me.CiLabel6)
        Me.pagFacturacion.Controls.Add(Me.txtDescuentos)
        Me.pagFacturacion.Controls.Add(Me.CiLabel7)
        Me.pagFacturacion.Controls.Add(Me.txtRetenciones)
        Me.pagFacturacion.Controls.Add(Me.CiLabel8)
        Me.pagFacturacion.Controls.Add(Me.txtImpuestos)
        Me.pagFacturacion.Controls.Add(Me.CiLabel10)
        Me.pagFacturacion.Controls.Add(Me.txtSubTotal)
        Me.pagFacturacion.Controls.Add(Me.txtFactura)
        Me.pagFacturacion.Controls.Add(Me.txtTotalCant)
        Me.pagFacturacion.Controls.Add(Me.txtFechaFactura)
        Me.pagFacturacion.ImageIndex = 1
        Me.pagFacturacion.Location = New System.Drawing.Point(1, 41)
        Me.pagFacturacion.Name = "pagFacturacion"
        Me.pagFacturacion.Size = New System.Drawing.Size(788, 191)
        Me.pagFacturacion.TabIndex = 1
        Me.pagFacturacion.Text = "Facturación"
        '
        'pagNotas
        '
        Me.pagNotas.Controls.Add(Me.CiLabel21)
        Me.pagNotas.Controls.Add(Me.OrdenTrabajoSel)
        Me.pagNotas.Controls.Add(Me.CiLabel20)
        Me.pagNotas.Controls.Add(Me.txtFolioFacturaExt)
        Me.pagNotas.Controls.Add(Me.txtReferencia)
        Me.pagNotas.Controls.Add(Me.CiLabel16)
        Me.pagNotas.Controls.Add(Me.txtOrdenCompra)
        Me.pagNotas.Controls.Add(Me.txtNotas)
        Me.pagNotas.Controls.Add(Me.CiLabel17)
        Me.pagNotas.ImageIndex = 2
        Me.pagNotas.Location = New System.Drawing.Point(1, 41)
        Me.pagNotas.Name = "pagNotas"
        Me.pagNotas.Size = New System.Drawing.Size(788, 191)
        Me.pagNotas.TabIndex = 2
        Me.pagNotas.Text = "Notas"
        '
        'CiLabel21
        '
        Me.CiLabel21.AutoSize = True
        Me.CiLabel21.Location = New System.Drawing.Point(20, 153)
        Me.CiLabel21.Name = "CiLabel21"
        Me.CiLabel21.Size = New System.Drawing.Size(87, 13)
        Me.CiLabel21.TabIndex = 8
        Me.CiLabel21.Text = "Orden / Entrada:"
        '
        'OrdenTrabajoSel
        '
        Me.OrdenTrabajoSel.AnySite = False
        Me.OrdenTrabajoSel.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.OrdenTrabajoSel.EditorAssembly = "Azteca.ProduccionWin"
        Me.OrdenTrabajoSel.EditorClass = "Azteca.Windows.Produccion.OrdenesTrabajoForm"
        Me.OrdenTrabajoSel.EditorTitle = "Editar Orden de Trabajo..."
        Me.OrdenTrabajoSel.Key = 0
        Me.OrdenTrabajoSel.Linked = False
        Me.OrdenTrabajoSel.Location = New System.Drawing.Point(119, 149)
        Me.OrdenTrabajoSel.Name = "OrdenTrabajoSel"
        Me.OrdenTrabajoSel.Size = New System.Drawing.Size(656, 23)
        Me.OrdenTrabajoSel.TabIndex = 7
        '
        'CiLabel20
        '
        Me.CiLabel20.AutoSize = True
        Me.CiLabel20.Location = New System.Drawing.Point(20, 46)
        Me.CiLabel20.Name = "CiLabel20"
        Me.CiLabel20.Size = New System.Drawing.Size(71, 13)
        Me.CiLabel20.TabIndex = 5
        Me.CiLabel20.Text = "Folio Factura:"
        '
        'txtFolioFacturaExt
        '
        Me.txtFolioFacturaExt.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtFolioFacturaExt.Location = New System.Drawing.Point(119, 43)
        Me.txtFolioFacturaExt.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFolioFacturaExt.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFolioFacturaExt.Name = "txtFolioFacturaExt"
        Me.txtFolioFacturaExt.Size = New System.Drawing.Size(197, 20)
        Me.txtFolioFacturaExt.TabIndex = 6
        '
        'C1DockingTabPage1
        '
        Me.C1DockingTabPage1.Controls.Add(Me.dtpFechaPedimento)
        Me.C1DockingTabPage1.Controls.Add(Me.txtAduana)
        Me.C1DockingTabPage1.Controls.Add(Me.txtNumPedimento)
        Me.C1DockingTabPage1.Controls.Add(Me.CiLabel19)
        Me.C1DockingTabPage1.Controls.Add(Me.CiLabel18)
        Me.C1DockingTabPage1.Controls.Add(Me.CiLabel2)
        Me.C1DockingTabPage1.Location = New System.Drawing.Point(1, 41)
        Me.C1DockingTabPage1.Name = "C1DockingTabPage1"
        Me.C1DockingTabPage1.Size = New System.Drawing.Size(788, 191)
        Me.C1DockingTabPage1.TabIndex = 3
        Me.C1DockingTabPage1.Text = "Importación"
        '
        'dtpFechaPedimento
        '
        Me.dtpFechaPedimento.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaPedimento.Location = New System.Drawing.Point(124, 52)
        Me.dtpFechaPedimento.Name = "dtpFechaPedimento"
        Me.dtpFechaPedimento.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaPedimento.TabIndex = 5
        '
        'txtAduana
        '
        Me.txtAduana.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtAduana.Location = New System.Drawing.Point(124, 78)
        Me.txtAduana.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAduana.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAduana.Name = "txtAduana"
        Me.txtAduana.Size = New System.Drawing.Size(200, 20)
        Me.txtAduana.TabIndex = 4
        '
        'txtNumPedimento
        '
        Me.txtNumPedimento.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumPedimento.Location = New System.Drawing.Point(124, 23)
        Me.txtNumPedimento.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumPedimento.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumPedimento.Name = "txtNumPedimento"
        Me.txtNumPedimento.Size = New System.Drawing.Size(116, 20)
        Me.txtNumPedimento.TabIndex = 3
        '
        'CiLabel19
        '
        Me.CiLabel19.AutoSize = True
        Me.CiLabel19.Location = New System.Drawing.Point(25, 85)
        Me.CiLabel19.Name = "CiLabel19"
        Me.CiLabel19.Size = New System.Drawing.Size(47, 13)
        Me.CiLabel19.TabIndex = 2
        Me.CiLabel19.Text = "Aduana:"
        '
        'CiLabel18
        '
        Me.CiLabel18.AutoSize = True
        Me.CiLabel18.Location = New System.Drawing.Point(25, 58)
        Me.CiLabel18.Name = "CiLabel18"
        Me.CiLabel18.Size = New System.Drawing.Size(40, 13)
        Me.CiLabel18.TabIndex = 1
        Me.CiLabel18.Text = "Fecha:"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(25, 26)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(93, 13)
        Me.CiLabel2.TabIndex = 0
        Me.CiLabel2.Text = "Núm. Documento:"
        '
        'tabPartidas
        '
        Me.tabPartidas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabPartidas.Controls.Add(Me.pagArticulos)
        Me.tabPartidas.Controls.Add(Me.pagServicios)
        Me.tabPartidas.ImageList = Me.imlPartidas
        Me.tabPartidas.Location = New System.Drawing.Point(12, 329)
        Me.tabPartidas.Name = "tabPartidas"
        Me.tabPartidas.SelectedIndex = 1
        Me.tabPartidas.Size = New System.Drawing.Size(790, 166)
        Me.tabPartidas.TabIndex = 39
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
        Me.pagArticulos.Size = New System.Drawing.Size(788, 124)
        Me.pagArticulos.TabIndex = 0
        Me.pagArticulos.Text = "Artículos"
        '
        'pagServicios
        '
        Me.pagServicios.Controls.Add(Me.grdServicios)
        Me.pagServicios.ImageIndex = 1
        Me.pagServicios.Location = New System.Drawing.Point(1, 41)
        Me.pagServicios.Name = "pagServicios"
        Me.pagServicios.Size = New System.Drawing.Size(788, 124)
        Me.pagServicios.TabIndex = 1
        Me.pagServicios.Text = "Servicios"
        '
        'VentasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 523)
        Me.Controls.Add(Me.tabPartidas)
        Me.Controls.Add(Me.tabDocumento)
        Me.Name = "VentasForm"
        Me.Text = "VentasForm"
        Me.Controls.SetChildIndex(Me.tabDocumento, 0)
        Me.Controls.SetChildIndex(Me.tabPartidas, 0)
        Me.CiGroupBox2.ResumeLayout(False)
        Me.CiGroupBox2.PerformLayout()
        Me.grpCondicionesPago.ResumeLayout(False)
        Me.grpCondicionesPago.PerformLayout()
        Me.CiGroupBox1.ResumeLayout(False)
        Me.CiGroupBox1.PerformLayout()
        CType(Me.cboUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDocumento.ResumeLayout(False)
        Me.pagGeneral.ResumeLayout(False)
        Me.pagFacturacion.ResumeLayout(False)
        Me.pagFacturacion.PerformLayout()
        Me.pagNotas.ResumeLayout(False)
        Me.pagNotas.PerformLayout()
        Me.C1DockingTabPage1.ResumeLayout(False)
        Me.C1DockingTabPage1.PerformLayout()
        CType(Me.tabPartidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPartidas.ResumeLayout(False)
        Me.pagArticulos.ResumeLayout(False)
        Me.pagServicios.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New VentaFacade
        SetDocumentType("Venta")
    End Sub
    Friend WithEvents imlVenta As System.Windows.Forms.ImageList
    Friend WithEvents bsArticulos As System.Windows.Forms.BindingSource
    Friend WithEvents bsServicios As System.Windows.Forms.BindingSource
    Friend WithEvents imlPartidas As System.Windows.Forms.ImageList
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents grpCondicionesPago As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents rdbCredito As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents rdbContado As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents txtNotas As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtTotal As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtDescuentos As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtRetenciones As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtImpuestos As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtSubTotal As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtTotalCant As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtFechaFactura As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtFactura As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel10 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel9 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel8 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel7 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel6 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel5 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCliente As Azteca.Windows.Ventas.ClienteSelector
    Friend WithEvents CiLabel11 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtDivisa As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel12 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtTipoCambio As Azteca.Windows.Controls.CITextBox
    Friend WithEvents grdArticulos As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents cboDivisa As Azteca.Windows.Contabilidad.DivisasComboBox
    Friend WithEvents CiLabel13 As Azteca.Windows.Controls.CILabel
    Friend WithEvents bsUnidades As System.Windows.Forms.BindingSource
    Friend WithEvents cboUnidades As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents grdServicios As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents CiGroupBox2 As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents cboCaja As Azteca.Windows.Ventas.CajaCombobox
    Friend WithEvents CiLabel15 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiGroupBox1 As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents CiLabel14 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtReferencia As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtOrdenCompra As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel17 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel16 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtVendedor As Azteca.Windows.Ventas.VendedorSelector
    Friend WithEvents tabDocumento As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagGeneral As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagFacturacion As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagNotas As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents tabPartidas As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagArticulos As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagServicios As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1DockingTabPage1 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents dtpFechaPedimento As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents txtAduana As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtNumPedimento As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel19 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel18 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel20 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtFolioFacturaExt As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel21 As Azteca.Windows.Controls.CILabel
    Friend WithEvents OrdenTrabajoSel As Azteca.Windows.Produccion.OrdenTrabajoSelector
End Class
