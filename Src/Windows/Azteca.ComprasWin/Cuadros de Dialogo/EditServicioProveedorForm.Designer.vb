<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditServicioProveedorForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditServicioProveedorForm))
        Me.txtProveedor = New Azteca.Windows.Compras.ProveedoresSelector()
        Me.cboZona = New Azteca.Windows.Compras.ZonasComboBox()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.txtServicio = New Azteca.Windows.Compras.ServicioSelector()
        Me.nudDiasEntrega = New Azteca.Windows.Controls.CINumericUpDown()
        Me.nudDiasCredito = New Azteca.Windows.Controls.CINumericUpDown()
        Me.CiLabel11 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel10 = New Azteca.Windows.Controls.CILabel()
        Me.cboDivisa = New Azteca.Windows.Contabilidad.DivisasComboBox()
        Me.CiLabel8 = New Azteca.Windows.Controls.CILabel()
        Me.txtPrecio = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel7 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel14 = New Azteca.Windows.Controls.CILabel()
        Me.cboImpuesto3 = New Azteca.Windows.Contabilidad.ImpuestosComboBox()
        Me.CiLabel13 = New Azteca.Windows.Controls.CILabel()
        Me.cboImpuesto2 = New Azteca.Windows.Contabilidad.ImpuestosComboBox()
        Me.CiLabel12 = New Azteca.Windows.Controls.CILabel()
        Me.cboImpuesto1 = New Azteca.Windows.Contabilidad.ImpuestosComboBox()
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.btnAceptar = New Azteca.Windows.Controls.CIButton()
        Me.CiLabel18 = New Azteca.Windows.Controls.CILabel()
        Me.nudDesc3 = New Azteca.Windows.Controls.CINumericUpDown()
        Me.CiLabel19 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel16 = New Azteca.Windows.Controls.CILabel()
        Me.nudDesc2 = New Azteca.Windows.Controls.CINumericUpDown()
        Me.CiLabel17 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel15 = New Azteca.Windows.Controls.CILabel()
        Me.nudDesc1 = New Azteca.Windows.Controls.CINumericUpDown()
        Me.CiLabel9 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel20 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel21 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel22 = New Azteca.Windows.Controls.CILabel()
        Me.cboRetencion1 = New Azteca.Windows.Contabilidad.RetencionesComboBox()
        Me.cboRetencion2 = New Azteca.Windows.Contabilidad.RetencionesComboBox()
        Me.cboRetencion3 = New Azteca.Windows.Contabilidad.RetencionesComboBox()
        Me.AzDockingTab1 = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagCondiciones = New C1.Win.C1Command.C1DockingTabPage()
        Me.tabMontos = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagImpuestos = New C1.Win.C1Command.C1DockingTabPage()
        Me.pagRetenciones = New C1.Win.C1Command.C1DockingTabPage()
        Me.pagDescuentos = New C1.Win.C1Command.C1DockingTabPage()
        CType(Me.nudDiasEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDiasCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDesc3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDesc2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDesc1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AzDockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AzDockingTab1.SuspendLayout()
        Me.pagCondiciones.SuspendLayout()
        CType(Me.tabMontos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMontos.SuspendLayout()
        Me.pagImpuestos.SuspendLayout()
        Me.pagRetenciones.SuspendLayout()
        Me.pagDescuentos.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtProveedor
        '
        Me.txtProveedor.AnySite = False
        Me.txtProveedor.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtProveedor.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtProveedor.EditorAssembly = "Azteca.ComprasWin"
        Me.txtProveedor.EditorClass = "Azteca.Windows.Compras.ProveedoresForm"
        Me.txtProveedor.EditorTitle = "Editar proveedores..."
        Me.txtProveedor.Key = 0
        Me.txtProveedor.Linked = False
        Me.txtProveedor.Location = New System.Drawing.Point(114, 39)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.txtProveedor.Size = New System.Drawing.Size(394, 23)
        Me.txtProveedor.TabIndex = 3
        '
        'cboZona
        '
        Me.cboZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboZona.FormattingEnabled = True
        Me.cboZona.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboZona.ItemsTable = Nothing
        Me.cboZona.Location = New System.Drawing.Point(114, 12)
        Me.cboZona.Name = "cboZona"
        Me.cboZona.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboZona.Size = New System.Drawing.Size(237, 21)
        Me.cboZona.TabIndex = 1
        Me.cboZona.UIName = Nothing
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(11, 44)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(59, 13)
        Me.CiLabel2.TabIndex = 2
        Me.CiLabel2.Text = "Proveedor:"
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(11, 15)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(89, 13)
        Me.CiLabel1.TabIndex = 0
        Me.CiLabel1.Text = "Zona de Compra:"
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(11, 72)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(48, 13)
        Me.CiLabel3.TabIndex = 4
        Me.CiLabel3.Text = "Servicio:"
        '
        'txtServicio
        '
        Me.txtServicio.AnySite = False
        Me.txtServicio.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtServicio.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtServicio.EditorAssembly = "Azteca.ComprasWin"
        Me.txtServicio.EditorClass = "Azteca.Windows.Compras.ServiciosForm"
        Me.txtServicio.EditorTitle = "Editar servicios..."
        Me.txtServicio.Key = 0
        Me.txtServicio.Linked = False
        Me.txtServicio.Location = New System.Drawing.Point(114, 68)
        Me.txtServicio.Name = "txtServicio"
        Me.txtServicio.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.txtServicio.Size = New System.Drawing.Size(394, 23)
        Me.txtServicio.TabIndex = 5
        '
        'nudDiasEntrega
        '
        Me.nudDiasEntrega.HighlightColor = System.Drawing.SystemColors.Info
        Me.nudDiasEntrega.Location = New System.Drawing.Point(278, 62)
        Me.nudDiasEntrega.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudDiasEntrega.Name = "nudDiasEntrega"
        Me.nudDiasEntrega.Size = New System.Drawing.Size(60, 20)
        Me.nudDiasEntrega.TabIndex = 14
        '
        'nudDiasCredito
        '
        Me.nudDiasCredito.HighlightColor = System.Drawing.SystemColors.Info
        Me.nudDiasCredito.Location = New System.Drawing.Point(120, 62)
        Me.nudDiasCredito.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudDiasCredito.Name = "nudDiasCredito"
        Me.nudDiasCredito.Size = New System.Drawing.Size(60, 20)
        Me.nudDiasCredito.TabIndex = 12
        '
        'CiLabel11
        '
        Me.CiLabel11.AutoSize = True
        Me.CiLabel11.Location = New System.Drawing.Point(186, 64)
        Me.CiLabel11.Name = "CiLabel11"
        Me.CiLabel11.Size = New System.Drawing.Size(86, 13)
        Me.CiLabel11.TabIndex = 13
        Me.CiLabel11.Text = "Dias de Entrega:"
        '
        'CiLabel10
        '
        Me.CiLabel10.AutoSize = True
        Me.CiLabel10.Location = New System.Drawing.Point(17, 64)
        Me.CiLabel10.Name = "CiLabel10"
        Me.CiLabel10.Size = New System.Drawing.Size(82, 13)
        Me.CiLabel10.TabIndex = 11
        Me.CiLabel10.Text = "Dias de Crédito:"
        '
        'cboDivisa
        '
        Me.cboDivisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDivisa.FormattingEnabled = True
        Me.cboDivisa.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboDivisa.ItemsTable = Nothing
        Me.cboDivisa.Location = New System.Drawing.Point(120, 35)
        Me.cboDivisa.Name = "cboDivisa"
        Me.cboDivisa.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboDivisa.Size = New System.Drawing.Size(218, 21)
        Me.cboDivisa.TabIndex = 10
        Me.cboDivisa.UIName = Nothing
        '
        'CiLabel8
        '
        Me.CiLabel8.AutoSize = True
        Me.CiLabel8.Location = New System.Drawing.Point(17, 38)
        Me.CiLabel8.Name = "CiLabel8"
        Me.CiLabel8.Size = New System.Drawing.Size(39, 13)
        Me.CiLabel8.TabIndex = 9
        Me.CiLabel8.Text = "Divisa:"
        '
        'txtPrecio
        '
        Me.txtPrecio.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtPrecio.Digits = True
        Me.txtPrecio.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtPrecio.Format = "C"
        Me.txtPrecio.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtPrecio.Location = New System.Drawing.Point(120, 9)
        Me.txtPrecio.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPrecio.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 8
        '
        'CiLabel7
        '
        Me.CiLabel7.AutoSize = True
        Me.CiLabel7.Location = New System.Drawing.Point(17, 12)
        Me.CiLabel7.Name = "CiLabel7"
        Me.CiLabel7.Size = New System.Drawing.Size(40, 13)
        Me.CiLabel7.TabIndex = 7
        Me.CiLabel7.Text = "Precio:"
        '
        'CiLabel14
        '
        Me.CiLabel14.AutoSize = True
        Me.CiLabel14.Location = New System.Drawing.Point(17, 69)
        Me.CiLabel14.Name = "CiLabel14"
        Me.CiLabel14.Size = New System.Drawing.Size(62, 13)
        Me.CiLabel14.TabIndex = 20
        Me.CiLabel14.Text = "Impuesto 3:"
        '
        'cboImpuesto3
        '
        Me.cboImpuesto3.AddNoneItem = True
        Me.cboImpuesto3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboImpuesto3.FormattingEnabled = True
        Me.cboImpuesto3.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboImpuesto3.ItemsTable = Nothing
        Me.cboImpuesto3.Location = New System.Drawing.Point(93, 66)
        Me.cboImpuesto3.Name = "cboImpuesto3"
        Me.cboImpuesto3.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboImpuesto3.Size = New System.Drawing.Size(178, 21)
        Me.cboImpuesto3.TabIndex = 21
        Me.cboImpuesto3.UIName = Nothing
        '
        'CiLabel13
        '
        Me.CiLabel13.AutoSize = True
        Me.CiLabel13.Location = New System.Drawing.Point(17, 42)
        Me.CiLabel13.Name = "CiLabel13"
        Me.CiLabel13.Size = New System.Drawing.Size(62, 13)
        Me.CiLabel13.TabIndex = 18
        Me.CiLabel13.Text = "Impuesto 2:"
        '
        'cboImpuesto2
        '
        Me.cboImpuesto2.AddNoneItem = True
        Me.cboImpuesto2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboImpuesto2.FormattingEnabled = True
        Me.cboImpuesto2.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboImpuesto2.ItemsTable = Nothing
        Me.cboImpuesto2.Location = New System.Drawing.Point(93, 39)
        Me.cboImpuesto2.Name = "cboImpuesto2"
        Me.cboImpuesto2.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboImpuesto2.Size = New System.Drawing.Size(178, 21)
        Me.cboImpuesto2.TabIndex = 19
        Me.cboImpuesto2.UIName = Nothing
        '
        'CiLabel12
        '
        Me.CiLabel12.AutoSize = True
        Me.CiLabel12.Location = New System.Drawing.Point(17, 15)
        Me.CiLabel12.Name = "CiLabel12"
        Me.CiLabel12.Size = New System.Drawing.Size(62, 13)
        Me.CiLabel12.TabIndex = 16
        Me.CiLabel12.Text = "Impuesto 1:"
        '
        'cboImpuesto1
        '
        Me.cboImpuesto1.AddNoneItem = True
        Me.cboImpuesto1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboImpuesto1.FormattingEnabled = True
        Me.cboImpuesto1.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboImpuesto1.ItemsTable = Nothing
        Me.cboImpuesto1.Location = New System.Drawing.Point(93, 12)
        Me.cboImpuesto1.Name = "cboImpuesto1"
        Me.cboImpuesto1.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboImpuesto1.Size = New System.Drawing.Size(178, 21)
        Me.cboImpuesto1.TabIndex = 17
        Me.cboImpuesto1.UIName = Nothing
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(432, 355)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 40
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(349, 355)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 39
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'CiLabel18
        '
        Me.CiLabel18.AutoSize = True
        Me.CiLabel18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiLabel18.Location = New System.Drawing.Point(153, 66)
        Me.CiLabel18.Name = "CiLabel18"
        Me.CiLabel18.Size = New System.Drawing.Size(21, 16)
        Me.CiLabel18.TabIndex = 38
        Me.CiLabel18.Text = "%"
        '
        'nudDesc3
        '
        Me.nudDesc3.HighlightColor = System.Drawing.SystemColors.Info
        Me.nudDesc3.Location = New System.Drawing.Point(94, 64)
        Me.nudDesc3.Name = "nudDesc3"
        Me.nudDesc3.Size = New System.Drawing.Size(53, 20)
        Me.nudDesc3.TabIndex = 37
        '
        'CiLabel19
        '
        Me.CiLabel19.AutoSize = True
        Me.CiLabel19.Location = New System.Drawing.Point(17, 66)
        Me.CiLabel19.Name = "CiLabel19"
        Me.CiLabel19.Size = New System.Drawing.Size(71, 13)
        Me.CiLabel19.TabIndex = 36
        Me.CiLabel19.Text = "Descuento 3:"
        '
        'CiLabel16
        '
        Me.CiLabel16.AutoSize = True
        Me.CiLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiLabel16.Location = New System.Drawing.Point(153, 40)
        Me.CiLabel16.Name = "CiLabel16"
        Me.CiLabel16.Size = New System.Drawing.Size(21, 16)
        Me.CiLabel16.TabIndex = 35
        Me.CiLabel16.Text = "%"
        '
        'nudDesc2
        '
        Me.nudDesc2.HighlightColor = System.Drawing.SystemColors.Info
        Me.nudDesc2.Location = New System.Drawing.Point(94, 38)
        Me.nudDesc2.Name = "nudDesc2"
        Me.nudDesc2.Size = New System.Drawing.Size(53, 20)
        Me.nudDesc2.TabIndex = 34
        '
        'CiLabel17
        '
        Me.CiLabel17.AutoSize = True
        Me.CiLabel17.Location = New System.Drawing.Point(17, 40)
        Me.CiLabel17.Name = "CiLabel17"
        Me.CiLabel17.Size = New System.Drawing.Size(71, 13)
        Me.CiLabel17.TabIndex = 33
        Me.CiLabel17.Text = "Descuento 2:"
        '
        'CiLabel15
        '
        Me.CiLabel15.AutoSize = True
        Me.CiLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiLabel15.Location = New System.Drawing.Point(153, 14)
        Me.CiLabel15.Name = "CiLabel15"
        Me.CiLabel15.Size = New System.Drawing.Size(21, 16)
        Me.CiLabel15.TabIndex = 32
        Me.CiLabel15.Text = "%"
        '
        'nudDesc1
        '
        Me.nudDesc1.HighlightColor = System.Drawing.SystemColors.Info
        Me.nudDesc1.Location = New System.Drawing.Point(94, 12)
        Me.nudDesc1.Name = "nudDesc1"
        Me.nudDesc1.Size = New System.Drawing.Size(53, 20)
        Me.nudDesc1.TabIndex = 31
        '
        'CiLabel9
        '
        Me.CiLabel9.AutoSize = True
        Me.CiLabel9.Location = New System.Drawing.Point(17, 14)
        Me.CiLabel9.Name = "CiLabel9"
        Me.CiLabel9.Size = New System.Drawing.Size(71, 13)
        Me.CiLabel9.TabIndex = 30
        Me.CiLabel9.Text = "Descuento 1:"
        '
        'CiLabel20
        '
        Me.CiLabel20.AutoSize = True
        Me.CiLabel20.Location = New System.Drawing.Point(17, 69)
        Me.CiLabel20.Name = "CiLabel20"
        Me.CiLabel20.Size = New System.Drawing.Size(68, 13)
        Me.CiLabel20.TabIndex = 27
        Me.CiLabel20.Text = "Retención 3:"
        '
        'CiLabel21
        '
        Me.CiLabel21.AutoSize = True
        Me.CiLabel21.Location = New System.Drawing.Point(17, 42)
        Me.CiLabel21.Name = "CiLabel21"
        Me.CiLabel21.Size = New System.Drawing.Size(68, 13)
        Me.CiLabel21.TabIndex = 24
        Me.CiLabel21.Text = "Retención 2:"
        '
        'CiLabel22
        '
        Me.CiLabel22.AutoSize = True
        Me.CiLabel22.Location = New System.Drawing.Point(17, 15)
        Me.CiLabel22.Name = "CiLabel22"
        Me.CiLabel22.Size = New System.Drawing.Size(68, 13)
        Me.CiLabel22.TabIndex = 22
        Me.CiLabel22.Text = "Retención 1:"
        '
        'cboRetencion1
        '
        Me.cboRetencion1.AddNoneItem = True
        Me.cboRetencion1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRetencion1.FormattingEnabled = True
        Me.cboRetencion1.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboRetencion1.ItemsTable = Nothing
        Me.cboRetencion1.Location = New System.Drawing.Point(91, 12)
        Me.cboRetencion1.Name = "cboRetencion1"
        Me.cboRetencion1.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboRetencion1.Size = New System.Drawing.Size(181, 21)
        Me.cboRetencion1.TabIndex = 23
        Me.cboRetencion1.UIName = Nothing
        '
        'cboRetencion2
        '
        Me.cboRetencion2.AddNoneItem = True
        Me.cboRetencion2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRetencion2.FormattingEnabled = True
        Me.cboRetencion2.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboRetencion2.ItemsTable = Nothing
        Me.cboRetencion2.Location = New System.Drawing.Point(91, 39)
        Me.cboRetencion2.Name = "cboRetencion2"
        Me.cboRetencion2.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboRetencion2.Size = New System.Drawing.Size(181, 21)
        Me.cboRetencion2.TabIndex = 25
        Me.cboRetencion2.UIName = Nothing
        '
        'cboRetencion3
        '
        Me.cboRetencion3.AddNoneItem = True
        Me.cboRetencion3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRetencion3.FormattingEnabled = True
        Me.cboRetencion3.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboRetencion3.ItemsTable = Nothing
        Me.cboRetencion3.Location = New System.Drawing.Point(91, 66)
        Me.cboRetencion3.Name = "cboRetencion3"
        Me.cboRetencion3.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboRetencion3.Size = New System.Drawing.Size(181, 21)
        Me.cboRetencion3.TabIndex = 28
        Me.cboRetencion3.UIName = Nothing
        '
        'AzDockingTab1
        '
        Me.AzDockingTab1.Controls.Add(Me.pagCondiciones)
        Me.AzDockingTab1.Location = New System.Drawing.Point(12, 97)
        Me.AzDockingTab1.Name = "AzDockingTab1"
        Me.AzDockingTab1.SelectedTabBold = True
        Me.AzDockingTab1.Size = New System.Drawing.Size(496, 122)
        Me.AzDockingTab1.TabIndex = 41
        Me.AzDockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.AzDockingTab1.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.AzDockingTab1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagCondiciones
        '
        Me.pagCondiciones.Controls.Add(Me.CiLabel7)
        Me.pagCondiciones.Controls.Add(Me.txtPrecio)
        Me.pagCondiciones.Controls.Add(Me.CiLabel8)
        Me.pagCondiciones.Controls.Add(Me.cboDivisa)
        Me.pagCondiciones.Controls.Add(Me.CiLabel10)
        Me.pagCondiciones.Controls.Add(Me.CiLabel11)
        Me.pagCondiciones.Controls.Add(Me.nudDiasCredito)
        Me.pagCondiciones.Controls.Add(Me.nudDiasEntrega)
        Me.pagCondiciones.Location = New System.Drawing.Point(1, 24)
        Me.pagCondiciones.Name = "pagCondiciones"
        Me.pagCondiciones.Size = New System.Drawing.Size(494, 97)
        Me.pagCondiciones.TabIndex = 0
        Me.pagCondiciones.Text = "Condiciones de compra"
        '
        'tabMontos
        '
        Me.tabMontos.Controls.Add(Me.pagImpuestos)
        Me.tabMontos.Controls.Add(Me.pagRetenciones)
        Me.tabMontos.Controls.Add(Me.pagDescuentos)
        Me.tabMontos.Location = New System.Drawing.Point(12, 224)
        Me.tabMontos.Name = "tabMontos"
        Me.tabMontos.SelectedIndex = 2
        Me.tabMontos.SelectedTabBold = True
        Me.tabMontos.Size = New System.Drawing.Size(496, 122)
        Me.tabMontos.TabIndex = 42
        Me.tabMontos.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabMontos.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabMontos.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagImpuestos
        '
        Me.pagImpuestos.Controls.Add(Me.CiLabel12)
        Me.pagImpuestos.Controls.Add(Me.cboImpuesto1)
        Me.pagImpuestos.Controls.Add(Me.cboImpuesto2)
        Me.pagImpuestos.Controls.Add(Me.CiLabel13)
        Me.pagImpuestos.Controls.Add(Me.cboImpuesto3)
        Me.pagImpuestos.Controls.Add(Me.CiLabel14)
        Me.pagImpuestos.Location = New System.Drawing.Point(1, 24)
        Me.pagImpuestos.Name = "pagImpuestos"
        Me.pagImpuestos.Size = New System.Drawing.Size(494, 97)
        Me.pagImpuestos.TabIndex = 0
        Me.pagImpuestos.Text = "Impuestos"
        '
        'pagRetenciones
        '
        Me.pagRetenciones.Controls.Add(Me.CiLabel22)
        Me.pagRetenciones.Controls.Add(Me.CiLabel21)
        Me.pagRetenciones.Controls.Add(Me.cboRetencion3)
        Me.pagRetenciones.Controls.Add(Me.CiLabel20)
        Me.pagRetenciones.Controls.Add(Me.cboRetencion2)
        Me.pagRetenciones.Controls.Add(Me.cboRetencion1)
        Me.pagRetenciones.Location = New System.Drawing.Point(1, 24)
        Me.pagRetenciones.Name = "pagRetenciones"
        Me.pagRetenciones.Size = New System.Drawing.Size(494, 97)
        Me.pagRetenciones.TabIndex = 1
        Me.pagRetenciones.Text = "Retenciones"
        '
        'pagDescuentos
        '
        Me.pagDescuentos.Controls.Add(Me.CiLabel9)
        Me.pagDescuentos.Controls.Add(Me.nudDesc1)
        Me.pagDescuentos.Controls.Add(Me.CiLabel18)
        Me.pagDescuentos.Controls.Add(Me.CiLabel15)
        Me.pagDescuentos.Controls.Add(Me.nudDesc3)
        Me.pagDescuentos.Controls.Add(Me.CiLabel17)
        Me.pagDescuentos.Controls.Add(Me.CiLabel19)
        Me.pagDescuentos.Controls.Add(Me.nudDesc2)
        Me.pagDescuentos.Controls.Add(Me.CiLabel16)
        Me.pagDescuentos.Location = New System.Drawing.Point(1, 24)
        Me.pagDescuentos.Name = "pagDescuentos"
        Me.pagDescuentos.Size = New System.Drawing.Size(494, 97)
        Me.pagDescuentos.TabIndex = 2
        Me.pagDescuentos.Text = "Descuentos"
        '
        'EditServicioProveedorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 390)
        Me.ControlBox = False
        Me.Controls.Add(Me.tabMontos)
        Me.Controls.Add(Me.AzDockingTab1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtServicio)
        Me.Controls.Add(Me.CiLabel3)
        Me.Controls.Add(Me.txtProveedor)
        Me.Controls.Add(Me.cboZona)
        Me.Controls.Add(Me.CiLabel2)
        Me.Controls.Add(Me.CiLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "EditServicioProveedorForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Editar información de compra de servicio"
        CType(Me.nudDiasEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDiasCredito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDesc3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDesc2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDesc1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AzDockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AzDockingTab1.ResumeLayout(False)
        Me.pagCondiciones.ResumeLayout(False)
        Me.pagCondiciones.PerformLayout()
        CType(Me.tabMontos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMontos.ResumeLayout(False)
        Me.pagImpuestos.ResumeLayout(False)
        Me.pagImpuestos.PerformLayout()
        Me.pagRetenciones.ResumeLayout(False)
        Me.pagRetenciones.PerformLayout()
        Me.pagDescuentos.ResumeLayout(False)
        Me.pagDescuentos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtProveedor As Azteca.Windows.Compras.ProveedoresSelector
    Friend WithEvents cboZona As Azteca.Windows.Compras.ZonasComboBox
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtServicio As Azteca.Windows.Compras.ServicioSelector
    Friend WithEvents nudDiasEntrega As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents nudDiasCredito As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents CiLabel11 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel10 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboDivisa As Azteca.Windows.Contabilidad.DivisasComboBox
    Friend WithEvents CiLabel8 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtPrecio As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel7 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel14 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboImpuesto3 As Azteca.Windows.Contabilidad.ImpuestosComboBox
    Friend WithEvents CiLabel13 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboImpuesto2 As Azteca.Windows.Contabilidad.ImpuestosComboBox
    Friend WithEvents CiLabel12 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboImpuesto1 As Azteca.Windows.Contabilidad.ImpuestosComboBox
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnAceptar As Azteca.Windows.Controls.CIButton
    Friend WithEvents CiLabel18 As Azteca.Windows.Controls.CILabel
    Friend WithEvents nudDesc3 As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents CiLabel19 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel16 As Azteca.Windows.Controls.CILabel
    Friend WithEvents nudDesc2 As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents CiLabel17 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel15 As Azteca.Windows.Controls.CILabel
    Friend WithEvents nudDesc1 As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents CiLabel9 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel20 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel21 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel22 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboRetencion1 As Azteca.Windows.Contabilidad.RetencionesComboBox
    Friend WithEvents cboRetencion2 As Azteca.Windows.Contabilidad.RetencionesComboBox
    Friend WithEvents cboRetencion3 As Azteca.Windows.Contabilidad.RetencionesComboBox
    Friend WithEvents AzDockingTab1 As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagCondiciones As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents tabMontos As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagImpuestos As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagRetenciones As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagDescuentos As C1.Win.C1Command.C1DockingTabPage
End Class
