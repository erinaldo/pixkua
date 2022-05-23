<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditArticuloProveedorForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditArticuloProveedorForm))
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.cboZona = New Azteca.Windows.Compras.ZonasComboBox()
        Me.txtProveedor = New Azteca.Windows.Compras.ProveedoresSelector()
        Me.txtArticulo = New Azteca.Windows.Inventario.ArticuloStockSelector()
        Me.CiLabel7 = New Azteca.Windows.Controls.CILabel()
        Me.txtPrecio = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel8 = New Azteca.Windows.Controls.CILabel()
        Me.cboDivisa = New Azteca.Windows.Contabilidad.DivisasComboBox()
        Me.cboImpuesto1 = New Azteca.Windows.Contabilidad.ImpuestosComboBox()
        Me.CiLabel9 = New Azteca.Windows.Controls.CILabel()
        Me.cboUnidadMedida = New Azteca.Windows.Inventario.UnidadesMedidaComboBox()
        Me.CiLabel10 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel11 = New Azteca.Windows.Controls.CILabel()
        Me.nudDiasCredito = New Azteca.Windows.Controls.CINumericUpDown()
        Me.nudDiasEntrega = New Azteca.Windows.Controls.CINumericUpDown()
        Me.CiLabel12 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel13 = New Azteca.Windows.Controls.CILabel()
        Me.cboImpuesto2 = New Azteca.Windows.Contabilidad.ImpuestosComboBox()
        Me.CiLabel14 = New Azteca.Windows.Controls.CILabel()
        Me.cboImpuesto3 = New Azteca.Windows.Contabilidad.ImpuestosComboBox()
        Me.CiLabel5 = New Azteca.Windows.Controls.CILabel()
        Me.nudDesc1 = New Azteca.Windows.Controls.CINumericUpDown()
        Me.CiLabel15 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel16 = New Azteca.Windows.Controls.CILabel()
        Me.nudDesc2 = New Azteca.Windows.Controls.CINumericUpDown()
        Me.CiLabel17 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel18 = New Azteca.Windows.Controls.CILabel()
        Me.nudDesc3 = New Azteca.Windows.Controls.CINumericUpDown()
        Me.CiLabel19 = New Azteca.Windows.Controls.CILabel()
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.btnAceptar = New Azteca.Windows.Controls.CIButton()
        Me.tabCondiciones = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagCondiciones = New C1.Win.C1Command.C1DockingTabPage()
        Me.tabImpuestos = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagImpuestos = New C1.Win.C1Command.C1DockingTabPage()
        CType(Me.nudDiasCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDiasEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDesc1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDesc2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDesc3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabCondiciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCondiciones.SuspendLayout()
        Me.pagCondiciones.SuspendLayout()
        CType(Me.tabImpuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabImpuestos.SuspendLayout()
        Me.pagImpuestos.SuspendLayout()
        Me.SuspendLayout()
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(12, 18)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(89, 13)
        Me.CiLabel1.TabIndex = 0
        Me.CiLabel1.Text = "Zona de Compra:"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(12, 47)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(59, 13)
        Me.CiLabel2.TabIndex = 2
        Me.CiLabel2.Text = "Proveedor:"
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(12, 76)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(47, 13)
        Me.CiLabel3.TabIndex = 4
        Me.CiLabel3.Text = "Artículo:"
        '
        'cboZona
        '
        Me.cboZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboZona.FormattingEnabled = True
        Me.cboZona.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboZona.ItemsTable = Nothing
        Me.cboZona.Location = New System.Drawing.Point(115, 15)
        Me.cboZona.Name = "cboZona"
        Me.cboZona.Size = New System.Drawing.Size(237, 21)
        Me.cboZona.TabIndex = 1
        Me.cboZona.UIName = Nothing
        '
        'txtProveedor
        '
        Me.txtProveedor.AnySite = False
        Me.txtProveedor.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtProveedor.EditorAssembly = "Azteca.ComprasWin"
        Me.txtProveedor.EditorClass = "Azteca.Windows.Compras.ProveedoresForm"
        Me.txtProveedor.EditorTitle = "Editar proveedores..."
        Me.txtProveedor.Key = 0
        Me.txtProveedor.Linked = False
        Me.txtProveedor.Location = New System.Drawing.Point(115, 42)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(394, 23)
        Me.txtProveedor.TabIndex = 3
        '
        'txtArticulo
        '
        Me.txtArticulo.AnySite = False
        Me.txtArticulo.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtArticulo.EditorAssembly = "Azteca.InventarioWin"
        Me.txtArticulo.EditorClass = "Azteca.Windows.Inventario.ArticulosStockForm"
        Me.txtArticulo.EditorTitle = "Editar Articulos de inventario..."
        Me.txtArticulo.Key = 0
        Me.txtArticulo.Linked = False
        Me.txtArticulo.Location = New System.Drawing.Point(115, 71)
        Me.txtArticulo.Name = "txtArticulo"
        Me.txtArticulo.Size = New System.Drawing.Size(394, 23)
        Me.txtArticulo.TabIndex = 5
        '
        'CiLabel7
        '
        Me.CiLabel7.AutoSize = True
        Me.CiLabel7.Location = New System.Drawing.Point(15, 12)
        Me.CiLabel7.Name = "CiLabel7"
        Me.CiLabel7.Size = New System.Drawing.Size(40, 13)
        Me.CiLabel7.TabIndex = 7
        Me.CiLabel7.Text = "Precio:"
        '
        'txtPrecio
        '
        Me.txtPrecio.CausesValidation = False
        Me.txtPrecio.Digits = True
        Me.txtPrecio.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtPrecio.Format = "C4"
        Me.txtPrecio.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtPrecio.Location = New System.Drawing.Point(118, 9)
        Me.txtPrecio.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPrecio.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 8
        '
        'CiLabel8
        '
        Me.CiLabel8.AutoSize = True
        Me.CiLabel8.Location = New System.Drawing.Point(15, 38)
        Me.CiLabel8.Name = "CiLabel8"
        Me.CiLabel8.Size = New System.Drawing.Size(39, 13)
        Me.CiLabel8.TabIndex = 9
        Me.CiLabel8.Text = "Divisa:"
        '
        'cboDivisa
        '
        Me.cboDivisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDivisa.FormattingEnabled = True
        Me.cboDivisa.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboDivisa.ItemsTable = Nothing
        Me.cboDivisa.Location = New System.Drawing.Point(118, 35)
        Me.cboDivisa.Name = "cboDivisa"
        Me.cboDivisa.Size = New System.Drawing.Size(218, 21)
        Me.cboDivisa.TabIndex = 10
        Me.cboDivisa.UIName = Nothing
        '
        'cboImpuesto1
        '
        Me.cboImpuesto1.AddNoneItem = True
        Me.cboImpuesto1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboImpuesto1.FormattingEnabled = True
        Me.cboImpuesto1.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboImpuesto1.ItemsTable = Nothing
        Me.cboImpuesto1.Location = New System.Drawing.Point(82, 12)
        Me.cboImpuesto1.Name = "cboImpuesto1"
        Me.cboImpuesto1.Size = New System.Drawing.Size(135, 21)
        Me.cboImpuesto1.TabIndex = 20
        Me.cboImpuesto1.UIName = Nothing
        '
        'CiLabel9
        '
        Me.CiLabel9.AutoSize = True
        Me.CiLabel9.Location = New System.Drawing.Point(15, 64)
        Me.CiLabel9.Name = "CiLabel9"
        Me.CiLabel9.Size = New System.Drawing.Size(97, 13)
        Me.CiLabel9.TabIndex = 11
        Me.CiLabel9.Text = "Unidad de Medida:"
        '
        'cboUnidadMedida
        '
        Me.cboUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnidadMedida.FormattingEnabled = True
        Me.cboUnidadMedida.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboUnidadMedida.ItemsTable = Nothing
        Me.cboUnidadMedida.Location = New System.Drawing.Point(118, 61)
        Me.cboUnidadMedida.Name = "cboUnidadMedida"
        Me.cboUnidadMedida.Size = New System.Drawing.Size(218, 21)
        Me.cboUnidadMedida.TabIndex = 13
        Me.cboUnidadMedida.UIName = Nothing
        '
        'CiLabel10
        '
        Me.CiLabel10.AutoSize = True
        Me.CiLabel10.Location = New System.Drawing.Point(15, 90)
        Me.CiLabel10.Name = "CiLabel10"
        Me.CiLabel10.Size = New System.Drawing.Size(82, 13)
        Me.CiLabel10.TabIndex = 14
        Me.CiLabel10.Text = "Dias de Crédito:"
        '
        'CiLabel11
        '
        Me.CiLabel11.AutoSize = True
        Me.CiLabel11.Location = New System.Drawing.Point(184, 90)
        Me.CiLabel11.Name = "CiLabel11"
        Me.CiLabel11.Size = New System.Drawing.Size(86, 13)
        Me.CiLabel11.TabIndex = 16
        Me.CiLabel11.Text = "Dias de Entrega:"
        '
        'nudDiasCredito
        '
        Me.nudDiasCredito.HighlightColor = System.Drawing.SystemColors.Info
        Me.nudDiasCredito.Location = New System.Drawing.Point(118, 88)
        Me.nudDiasCredito.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudDiasCredito.Name = "nudDiasCredito"
        Me.nudDiasCredito.Size = New System.Drawing.Size(60, 20)
        Me.nudDiasCredito.TabIndex = 15
        '
        'nudDiasEntrega
        '
        Me.nudDiasEntrega.HighlightColor = System.Drawing.SystemColors.Info
        Me.nudDiasEntrega.Location = New System.Drawing.Point(276, 88)
        Me.nudDiasEntrega.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudDiasEntrega.Name = "nudDiasEntrega"
        Me.nudDiasEntrega.Size = New System.Drawing.Size(60, 20)
        Me.nudDiasEntrega.TabIndex = 17
        '
        'CiLabel12
        '
        Me.CiLabel12.AutoSize = True
        Me.CiLabel12.Location = New System.Drawing.Point(14, 15)
        Me.CiLabel12.Name = "CiLabel12"
        Me.CiLabel12.Size = New System.Drawing.Size(62, 13)
        Me.CiLabel12.TabIndex = 19
        Me.CiLabel12.Text = "Impuesto 1:"
        '
        'CiLabel13
        '
        Me.CiLabel13.AutoSize = True
        Me.CiLabel13.Location = New System.Drawing.Point(14, 42)
        Me.CiLabel13.Name = "CiLabel13"
        Me.CiLabel13.Size = New System.Drawing.Size(62, 13)
        Me.CiLabel13.TabIndex = 21
        Me.CiLabel13.Text = "Impuesto 2:"
        '
        'cboImpuesto2
        '
        Me.cboImpuesto2.AddNoneItem = True
        Me.cboImpuesto2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboImpuesto2.FormattingEnabled = True
        Me.cboImpuesto2.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboImpuesto2.ItemsTable = Nothing
        Me.cboImpuesto2.Location = New System.Drawing.Point(82, 39)
        Me.cboImpuesto2.Name = "cboImpuesto2"
        Me.cboImpuesto2.Size = New System.Drawing.Size(135, 21)
        Me.cboImpuesto2.TabIndex = 22
        Me.cboImpuesto2.UIName = Nothing
        '
        'CiLabel14
        '
        Me.CiLabel14.AutoSize = True
        Me.CiLabel14.Location = New System.Drawing.Point(14, 69)
        Me.CiLabel14.Name = "CiLabel14"
        Me.CiLabel14.Size = New System.Drawing.Size(62, 13)
        Me.CiLabel14.TabIndex = 23
        Me.CiLabel14.Text = "Impuesto 3:"
        '
        'cboImpuesto3
        '
        Me.cboImpuesto3.AddNoneItem = True
        Me.cboImpuesto3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboImpuesto3.FormattingEnabled = True
        Me.cboImpuesto3.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboImpuesto3.ItemsTable = Nothing
        Me.cboImpuesto3.Location = New System.Drawing.Point(82, 66)
        Me.cboImpuesto3.Name = "cboImpuesto3"
        Me.cboImpuesto3.Size = New System.Drawing.Size(135, 21)
        Me.cboImpuesto3.TabIndex = 24
        Me.cboImpuesto3.UIName = Nothing
        '
        'CiLabel5
        '
        Me.CiLabel5.AutoSize = True
        Me.CiLabel5.Location = New System.Drawing.Point(248, 15)
        Me.CiLabel5.Name = "CiLabel5"
        Me.CiLabel5.Size = New System.Drawing.Size(71, 13)
        Me.CiLabel5.TabIndex = 25
        Me.CiLabel5.Text = "Descuento 1:"
        '
        'nudDesc1
        '
        Me.nudDesc1.DecimalPlaces = 2
        Me.nudDesc1.HighlightColor = System.Drawing.SystemColors.Info
        Me.nudDesc1.Location = New System.Drawing.Point(325, 13)
        Me.nudDesc1.Name = "nudDesc1"
        Me.nudDesc1.Size = New System.Drawing.Size(53, 20)
        Me.nudDesc1.TabIndex = 26
        '
        'CiLabel15
        '
        Me.CiLabel15.AutoSize = True
        Me.CiLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiLabel15.Location = New System.Drawing.Point(384, 15)
        Me.CiLabel15.Name = "CiLabel15"
        Me.CiLabel15.Size = New System.Drawing.Size(21, 16)
        Me.CiLabel15.TabIndex = 27
        Me.CiLabel15.Text = "%"
        '
        'CiLabel16
        '
        Me.CiLabel16.AutoSize = True
        Me.CiLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiLabel16.Location = New System.Drawing.Point(384, 41)
        Me.CiLabel16.Name = "CiLabel16"
        Me.CiLabel16.Size = New System.Drawing.Size(21, 16)
        Me.CiLabel16.TabIndex = 30
        Me.CiLabel16.Text = "%"
        '
        'nudDesc2
        '
        Me.nudDesc2.DecimalPlaces = 2
        Me.nudDesc2.HighlightColor = System.Drawing.SystemColors.Info
        Me.nudDesc2.Location = New System.Drawing.Point(325, 39)
        Me.nudDesc2.Name = "nudDesc2"
        Me.nudDesc2.Size = New System.Drawing.Size(53, 20)
        Me.nudDesc2.TabIndex = 29
        '
        'CiLabel17
        '
        Me.CiLabel17.AutoSize = True
        Me.CiLabel17.Location = New System.Drawing.Point(248, 41)
        Me.CiLabel17.Name = "CiLabel17"
        Me.CiLabel17.Size = New System.Drawing.Size(71, 13)
        Me.CiLabel17.TabIndex = 28
        Me.CiLabel17.Text = "Descuento 2:"
        '
        'CiLabel18
        '
        Me.CiLabel18.AutoSize = True
        Me.CiLabel18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiLabel18.Location = New System.Drawing.Point(384, 67)
        Me.CiLabel18.Name = "CiLabel18"
        Me.CiLabel18.Size = New System.Drawing.Size(21, 16)
        Me.CiLabel18.TabIndex = 33
        Me.CiLabel18.Text = "%"
        '
        'nudDesc3
        '
        Me.nudDesc3.DecimalPlaces = 2
        Me.nudDesc3.HighlightColor = System.Drawing.SystemColors.Info
        Me.nudDesc3.Location = New System.Drawing.Point(325, 65)
        Me.nudDesc3.Name = "nudDesc3"
        Me.nudDesc3.Size = New System.Drawing.Size(53, 20)
        Me.nudDesc3.TabIndex = 32
        '
        'CiLabel19
        '
        Me.CiLabel19.AutoSize = True
        Me.CiLabel19.Location = New System.Drawing.Point(248, 67)
        Me.CiLabel19.Name = "CiLabel19"
        Me.CiLabel19.Size = New System.Drawing.Size(71, 13)
        Me.CiLabel19.TabIndex = 31
        Me.CiLabel19.Text = "Descuento 3:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(434, 390)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 35
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(351, 390)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 34
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'tabCondiciones
        '
        Me.tabCondiciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabCondiciones.Controls.Add(Me.pagCondiciones)
        Me.tabCondiciones.Location = New System.Drawing.Point(15, 100)
        Me.tabCondiciones.Name = "tabCondiciones"
        Me.tabCondiciones.SelectedTabBold = True
        Me.tabCondiciones.Size = New System.Drawing.Size(494, 148)
        Me.tabCondiciones.TabIndex = 36
        Me.tabCondiciones.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabCondiciones.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabCondiciones.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagCondiciones
        '
        Me.pagCondiciones.Controls.Add(Me.CiLabel7)
        Me.pagCondiciones.Controls.Add(Me.txtPrecio)
        Me.pagCondiciones.Controls.Add(Me.CiLabel8)
        Me.pagCondiciones.Controls.Add(Me.cboDivisa)
        Me.pagCondiciones.Controls.Add(Me.CiLabel9)
        Me.pagCondiciones.Controls.Add(Me.cboUnidadMedida)
        Me.pagCondiciones.Controls.Add(Me.CiLabel10)
        Me.pagCondiciones.Controls.Add(Me.CiLabel11)
        Me.pagCondiciones.Controls.Add(Me.nudDiasCredito)
        Me.pagCondiciones.Controls.Add(Me.nudDiasEntrega)
        Me.pagCondiciones.Location = New System.Drawing.Point(1, 24)
        Me.pagCondiciones.Name = "pagCondiciones"
        Me.pagCondiciones.Size = New System.Drawing.Size(492, 123)
        Me.pagCondiciones.TabIndex = 0
        Me.pagCondiciones.Text = "Condiciones de compra"
        '
        'tabImpuestos
        '
        Me.tabImpuestos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabImpuestos.Controls.Add(Me.pagImpuestos)
        Me.tabImpuestos.Location = New System.Drawing.Point(15, 253)
        Me.tabImpuestos.Name = "tabImpuestos"
        Me.tabImpuestos.SelectedTabBold = True
        Me.tabImpuestos.Size = New System.Drawing.Size(494, 128)
        Me.tabImpuestos.TabIndex = 37
        Me.tabImpuestos.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabImpuestos.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabImpuestos.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagImpuestos
        '
        Me.pagImpuestos.Controls.Add(Me.CiLabel12)
        Me.pagImpuestos.Controls.Add(Me.cboImpuesto1)
        Me.pagImpuestos.Controls.Add(Me.CiLabel18)
        Me.pagImpuestos.Controls.Add(Me.cboImpuesto2)
        Me.pagImpuestos.Controls.Add(Me.nudDesc3)
        Me.pagImpuestos.Controls.Add(Me.CiLabel13)
        Me.pagImpuestos.Controls.Add(Me.CiLabel19)
        Me.pagImpuestos.Controls.Add(Me.cboImpuesto3)
        Me.pagImpuestos.Controls.Add(Me.CiLabel16)
        Me.pagImpuestos.Controls.Add(Me.CiLabel14)
        Me.pagImpuestos.Controls.Add(Me.nudDesc2)
        Me.pagImpuestos.Controls.Add(Me.CiLabel5)
        Me.pagImpuestos.Controls.Add(Me.CiLabel17)
        Me.pagImpuestos.Controls.Add(Me.nudDesc1)
        Me.pagImpuestos.Controls.Add(Me.CiLabel15)
        Me.pagImpuestos.Location = New System.Drawing.Point(1, 24)
        Me.pagImpuestos.Name = "pagImpuestos"
        Me.pagImpuestos.Size = New System.Drawing.Size(492, 103)
        Me.pagImpuestos.TabIndex = 0
        Me.pagImpuestos.Text = "Impuestos y descuentos"
        '
        'EditArticuloProveedorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 425)
        Me.ControlBox = False
        Me.Controls.Add(Me.tabImpuestos)
        Me.Controls.Add(Me.tabCondiciones)
        Me.Controls.Add(Me.txtArticulo)
        Me.Controls.Add(Me.txtProveedor)
        Me.Controls.Add(Me.cboZona)
        Me.Controls.Add(Me.CiLabel3)
        Me.Controls.Add(Me.CiLabel2)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "EditArticuloProveedorForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Editar información de compra de artículo"
        CType(Me.nudDiasCredito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDiasEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDesc1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDesc2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDesc3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabCondiciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCondiciones.ResumeLayout(False)
        Me.pagCondiciones.ResumeLayout(False)
        Me.pagCondiciones.PerformLayout()
        CType(Me.tabImpuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabImpuestos.ResumeLayout(False)
        Me.pagImpuestos.ResumeLayout(False)
        Me.pagImpuestos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnAceptar As Azteca.Windows.Controls.CIButton
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboZona As Azteca.Windows.Compras.ZonasComboBox
    Friend WithEvents txtProveedor As Azteca.Windows.Compras.ProveedoresSelector
    Friend WithEvents txtArticulo As Azteca.Windows.Inventario.ArticuloStockSelector
    Friend WithEvents CiLabel7 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtPrecio As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel8 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboDivisa As Azteca.Windows.Contabilidad.DivisasComboBox
    Friend WithEvents cboImpuesto1 As Azteca.Windows.Contabilidad.ImpuestosComboBox
    Friend WithEvents CiLabel9 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboUnidadMedida As Azteca.Windows.Inventario.UnidadesMedidaComboBox
    Friend WithEvents CiLabel10 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel11 As Azteca.Windows.Controls.CILabel
    Friend WithEvents nudDiasCredito As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents nudDiasEntrega As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents CiLabel12 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel13 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboImpuesto2 As Azteca.Windows.Contabilidad.ImpuestosComboBox
    Friend WithEvents CiLabel14 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboImpuesto3 As Azteca.Windows.Contabilidad.ImpuestosComboBox
    Friend WithEvents CiLabel5 As Azteca.Windows.Controls.CILabel
    Friend WithEvents nudDesc1 As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents CiLabel15 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel16 As Azteca.Windows.Controls.CILabel
    Friend WithEvents nudDesc2 As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents CiLabel17 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel18 As Azteca.Windows.Controls.CILabel
    Friend WithEvents nudDesc3 As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents CiLabel19 As Azteca.Windows.Controls.CILabel
    Friend WithEvents tabCondiciones As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagCondiciones As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents tabImpuestos As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagImpuestos As C1.Win.C1Command.C1DockingTabPage
End Class
