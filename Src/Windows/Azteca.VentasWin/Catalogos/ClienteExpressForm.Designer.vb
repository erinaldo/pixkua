<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClienteExpressForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClienteExpressForm))
        Me.grpIntegracionFact = New Azteca.Windows.Controls.CIGroupBox()
        Me.cboAddenda = New Azteca.Windows.Contabilidad.AddendasCombobox()
        Me.txtNumProveedor = New Azteca.Windows.Controls.CITextBox()
        Me.txtGLNTienda = New Azteca.Windows.Controls.CITextBox()
        Me.txtGLN = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel22 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel21 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel20 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel19 = New Azteca.Windows.Controls.CILabel()
        Me.grpDatosFiscales = New Azteca.Windows.Controls.CIGroupBox()
        Me.cboMetodoPago = New Azteca.Windows.Ventas.MetodoPagoComboBox()
        Me.txtCuentaPago = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel25 = New Azteca.Windows.Controls.CILabel()
        Me.txtRazonSocial = New Azteca.Windows.Controls.CITextBox()
        Me.txtRFC = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel26 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel11 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel12 = New Azteca.Windows.Controls.CILabel()
        Me.txtCalleFis = New Azteca.Windows.Controls.CITextBox()
        Me.txtPoblacionFis = New Azteca.Windows.Controls.General.PoblacionSelector()
        Me.CiLabel13 = New Azteca.Windows.Controls.CILabel()
        Me.txtCPFis = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel14 = New Azteca.Windows.Controls.CILabel()
        Me.txtColoniaFis = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel15 = New Azteca.Windows.Controls.CILabel()
        Me.txtNumIntFis = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel16 = New Azteca.Windows.Controls.CILabel()
        Me.txtNumExtFis = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel17 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel18 = New Azteca.Windows.Controls.CILabel()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.txtCorreo = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.selListaPrecios = New Azteca.Windows.Ventas.ListaPreciosSelector()
        Me.lblListaPrecios = New Azteca.Windows.Controls.CILabel()
        Me.grpIntegracionFact.SuspendLayout()
        Me.grpDatosFiscales.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpIntegracionFact
        '
        Me.grpIntegracionFact.Controls.Add(Me.cboAddenda)
        Me.grpIntegracionFact.Controls.Add(Me.txtNumProveedor)
        Me.grpIntegracionFact.Controls.Add(Me.txtGLNTienda)
        Me.grpIntegracionFact.Controls.Add(Me.txtGLN)
        Me.grpIntegracionFact.Controls.Add(Me.CiLabel22)
        Me.grpIntegracionFact.Controls.Add(Me.CiLabel21)
        Me.grpIntegracionFact.Controls.Add(Me.CiLabel20)
        Me.grpIntegracionFact.Controls.Add(Me.CiLabel19)
        Me.grpIntegracionFact.Location = New System.Drawing.Point(64, 361)
        Me.grpIntegracionFact.Name = "grpIntegracionFact"
        Me.grpIntegracionFact.Size = New System.Drawing.Size(549, 114)
        Me.grpIntegracionFact.TabIndex = 33
        Me.grpIntegracionFact.TabStop = False
        Me.grpIntegracionFact.Text = "Integración"
        '
        'cboAddenda
        '
        Me.cboAddenda.AddNoneItem = True
        Me.cboAddenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAddenda.FormattingEnabled = True
        Me.cboAddenda.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboAddenda.ItemsTable = Nothing
        Me.cboAddenda.Location = New System.Drawing.Point(90, 22)
        Me.cboAddenda.Name = "cboAddenda"
        Me.cboAddenda.NoneItemText = "[Ninguna]"
        Me.cboAddenda.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboAddenda.Size = New System.Drawing.Size(192, 21)
        Me.cboAddenda.TabIndex = 0
        Me.cboAddenda.UIName = Nothing
        '
        'txtNumProveedor
        '
        Me.txtNumProveedor.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNumProveedor.Digits = True
        Me.txtNumProveedor.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNumProveedor.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumProveedor.Location = New System.Drawing.Point(90, 71)
        Me.txtNumProveedor.MaxLength = 13
        Me.txtNumProveedor.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumProveedor.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumProveedor.Name = "txtNumProveedor"
        Me.txtNumProveedor.Size = New System.Drawing.Size(132, 20)
        Me.txtNumProveedor.TabIndex = 3
        '
        'txtGLNTienda
        '
        Me.txtGLNTienda.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtGLNTienda.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtGLNTienda.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtGLNTienda.Location = New System.Drawing.Point(369, 48)
        Me.txtGLNTienda.MaxLength = 13
        Me.txtGLNTienda.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtGLNTienda.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtGLNTienda.Name = "txtGLNTienda"
        Me.txtGLNTienda.Size = New System.Drawing.Size(132, 20)
        Me.txtGLNTienda.TabIndex = 2
        '
        'txtGLN
        '
        Me.txtGLN.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtGLN.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtGLN.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtGLN.Location = New System.Drawing.Point(90, 47)
        Me.txtGLN.MaxLength = 13
        Me.txtGLN.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtGLN.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtGLN.Name = "txtGLN"
        Me.txtGLN.Size = New System.Drawing.Size(132, 20)
        Me.txtGLN.TabIndex = 1
        '
        'CiLabel22
        '
        Me.CiLabel22.AutoSize = True
        Me.CiLabel22.Location = New System.Drawing.Point(12, 74)
        Me.CiLabel22.Name = "CiLabel22"
        Me.CiLabel22.Size = New System.Drawing.Size(79, 13)
        Me.CiLabel22.TabIndex = 6
        Me.CiLabel22.Text = "No. Proveedor:"
        '
        'CiLabel21
        '
        Me.CiLabel21.AutoSize = True
        Me.CiLabel21.Location = New System.Drawing.Point(303, 51)
        Me.CiLabel21.Name = "CiLabel21"
        Me.CiLabel21.Size = New System.Drawing.Size(68, 13)
        Me.CiLabel21.TabIndex = 4
        Me.CiLabel21.Text = "GLN Tienda:"
        '
        'CiLabel20
        '
        Me.CiLabel20.AutoSize = True
        Me.CiLabel20.Location = New System.Drawing.Point(17, 51)
        Me.CiLabel20.Name = "CiLabel20"
        Me.CiLabel20.Size = New System.Drawing.Size(32, 13)
        Me.CiLabel20.TabIndex = 2
        Me.CiLabel20.Text = "GLN:"
        '
        'CiLabel19
        '
        Me.CiLabel19.AutoSize = True
        Me.CiLabel19.Location = New System.Drawing.Point(12, 25)
        Me.CiLabel19.Name = "CiLabel19"
        Me.CiLabel19.Size = New System.Drawing.Size(53, 13)
        Me.CiLabel19.TabIndex = 0
        Me.CiLabel19.Text = "Addenda:"
        '
        'grpDatosFiscales
        '
        Me.grpDatosFiscales.Controls.Add(Me.cboMetodoPago)
        Me.grpDatosFiscales.Controls.Add(Me.txtCuentaPago)
        Me.grpDatosFiscales.Controls.Add(Me.CiLabel25)
        Me.grpDatosFiscales.Controls.Add(Me.txtRazonSocial)
        Me.grpDatosFiscales.Controls.Add(Me.txtRFC)
        Me.grpDatosFiscales.Controls.Add(Me.CiLabel26)
        Me.grpDatosFiscales.Controls.Add(Me.CiLabel11)
        Me.grpDatosFiscales.Controls.Add(Me.CiLabel12)
        Me.grpDatosFiscales.Controls.Add(Me.txtCalleFis)
        Me.grpDatosFiscales.Controls.Add(Me.txtPoblacionFis)
        Me.grpDatosFiscales.Controls.Add(Me.CiLabel13)
        Me.grpDatosFiscales.Controls.Add(Me.txtCPFis)
        Me.grpDatosFiscales.Controls.Add(Me.CiLabel14)
        Me.grpDatosFiscales.Controls.Add(Me.txtColoniaFis)
        Me.grpDatosFiscales.Controls.Add(Me.CiLabel15)
        Me.grpDatosFiscales.Controls.Add(Me.txtNumIntFis)
        Me.grpDatosFiscales.Controls.Add(Me.CiLabel16)
        Me.grpDatosFiscales.Controls.Add(Me.txtNumExtFis)
        Me.grpDatosFiscales.Controls.Add(Me.CiLabel17)
        Me.grpDatosFiscales.Controls.Add(Me.CiLabel18)
        Me.grpDatosFiscales.Location = New System.Drawing.Point(64, 157)
        Me.grpDatosFiscales.Name = "grpDatosFiscales"
        Me.grpDatosFiscales.Size = New System.Drawing.Size(549, 198)
        Me.grpDatosFiscales.TabIndex = 32
        Me.grpDatosFiscales.TabStop = False
        Me.grpDatosFiscales.Text = "Datos Fiscales"
        '
        'cboMetodoPago
        '
        Me.cboMetodoPago.AddNoneItem = True
        Me.cboMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMetodoPago.FormattingEnabled = True
        Me.cboMetodoPago.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboMetodoPago.ItemsTable = Nothing
        Me.cboMetodoPago.Location = New System.Drawing.Point(89, 162)
        Me.cboMetodoPago.Name = "cboMetodoPago"
        Me.cboMetodoPago.NoneItemText = "[NO IDENTIFICADO]"
        Me.cboMetodoPago.RequiredField = True
        Me.cboMetodoPago.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboMetodoPago.Size = New System.Drawing.Size(193, 21)
        Me.cboMetodoPago.TabIndex = 8
        Me.cboMetodoPago.UIName = "Método de Pago"
        '
        'txtCuentaPago
        '
        Me.txtCuentaPago.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCuentaPago.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCuentaPago.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCuentaPago.Location = New System.Drawing.Point(369, 162)
        Me.txtCuentaPago.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCuentaPago.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCuentaPago.Name = "txtCuentaPago"
        Me.txtCuentaPago.Size = New System.Drawing.Size(166, 20)
        Me.txtCuentaPago.TabIndex = 9
        '
        'CiLabel25
        '
        Me.CiLabel25.AutoSize = True
        Me.CiLabel25.Location = New System.Drawing.Point(12, 165)
        Me.CiLabel25.Name = "CiLabel25"
        Me.CiLabel25.Size = New System.Drawing.Size(74, 13)
        Me.CiLabel25.TabIndex = 36
        Me.CiLabel25.Text = "Método Pago:"
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtRazonSocial.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtRazonSocial.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtRazonSocial.Location = New System.Drawing.Point(90, 43)
        Me.txtRazonSocial.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRazonSocial.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.RequiredField = True
        Me.txtRazonSocial.Size = New System.Drawing.Size(445, 20)
        Me.txtRazonSocial.TabIndex = 1
        Me.txtRazonSocial.UIName = "Razon Social"
        '
        'txtRFC
        '
        Me.txtRFC.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtRFC.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtRFC.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtRFC.Location = New System.Drawing.Point(90, 20)
        Me.txtRFC.MaxLength = 13
        Me.txtRFC.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRFC.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.RegularExpression = resources.GetString("txtRFC.RegularExpression")
        Me.txtRFC.RequiredField = True
        Me.txtRFC.Size = New System.Drawing.Size(141, 20)
        Me.txtRFC.TabIndex = 0
        Me.txtRFC.UIName = "RFC"
        '
        'CiLabel26
        '
        Me.CiLabel26.AutoSize = True
        Me.CiLabel26.Location = New System.Drawing.Point(285, 165)
        Me.CiLabel26.Name = "CiLabel26"
        Me.CiLabel26.Size = New System.Drawing.Size(87, 13)
        Me.CiLabel26.TabIndex = 37
        Me.CiLabel26.Text = "Cuenta de Pago:"
        '
        'CiLabel11
        '
        Me.CiLabel11.AutoSize = True
        Me.CiLabel11.Location = New System.Drawing.Point(12, 46)
        Me.CiLabel11.Name = "CiLabel11"
        Me.CiLabel11.Size = New System.Drawing.Size(73, 13)
        Me.CiLabel11.TabIndex = 2
        Me.CiLabel11.Text = "Razón Social:"
        '
        'CiLabel12
        '
        Me.CiLabel12.AutoSize = True
        Me.CiLabel12.Location = New System.Drawing.Point(12, 23)
        Me.CiLabel12.Name = "CiLabel12"
        Me.CiLabel12.Size = New System.Drawing.Size(31, 13)
        Me.CiLabel12.TabIndex = 0
        Me.CiLabel12.Text = "RFC:"
        '
        'txtCalleFis
        '
        Me.txtCalleFis.BackColor = System.Drawing.SystemColors.Window
        Me.txtCalleFis.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCalleFis.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCalleFis.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCalleFis.Location = New System.Drawing.Point(90, 66)
        Me.txtCalleFis.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalleFis.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalleFis.Name = "txtCalleFis"
        Me.txtCalleFis.RequiredField = True
        Me.txtCalleFis.Size = New System.Drawing.Size(445, 20)
        Me.txtCalleFis.TabIndex = 2
        Me.txtCalleFis.UIName = "Calle"
        '
        'txtPoblacionFis
        '
        Me.txtPoblacionFis.AnySite = False
        Me.txtPoblacionFis.AutoClear = False
        Me.txtPoblacionFis.AutoLock = False
        Me.txtPoblacionFis.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtPoblacionFis.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtPoblacionFis.EditorAssembly = "Azteca.Windows"
        Me.txtPoblacionFis.EditorClass = "Azteca.Windows.Forms.General.CatalogoPoblaciones"
        Me.txtPoblacionFis.EditorTitle = "Editar población..."
        Me.txtPoblacionFis.Key = 0
        Me.txtPoblacionFis.Linked = False
        Me.txtPoblacionFis.Location = New System.Drawing.Point(89, 134)
        Me.txtPoblacionFis.Name = "txtPoblacionFis"
        Me.txtPoblacionFis.RequiredField = True
        Me.txtPoblacionFis.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.txtPoblacionFis.Size = New System.Drawing.Size(446, 23)
        Me.txtPoblacionFis.TabIndex = 7
        Me.txtPoblacionFis.TextWidth = 70
        Me.txtPoblacionFis.UIName = "Población"
        '
        'CiLabel13
        '
        Me.CiLabel13.AutoSize = True
        Me.CiLabel13.Location = New System.Drawing.Point(12, 69)
        Me.CiLabel13.Name = "CiLabel13"
        Me.CiLabel13.Size = New System.Drawing.Size(33, 13)
        Me.CiLabel13.TabIndex = 4
        Me.CiLabel13.Text = "Calle:"
        '
        'txtCPFis
        '
        Me.txtCPFis.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCPFis.Digits = True
        Me.txtCPFis.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCPFis.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCPFis.Location = New System.Drawing.Point(453, 112)
        Me.txtCPFis.MaxLength = 5
        Me.txtCPFis.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCPFis.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCPFis.Name = "txtCPFis"
        Me.txtCPFis.RequiredField = True
        Me.txtCPFis.Size = New System.Drawing.Size(82, 20)
        Me.txtCPFis.TabIndex = 6
        Me.txtCPFis.UIName = "Código Postal"
        '
        'CiLabel14
        '
        Me.CiLabel14.AutoSize = True
        Me.CiLabel14.Location = New System.Drawing.Point(12, 115)
        Me.CiLabel14.Name = "CiLabel14"
        Me.CiLabel14.Size = New System.Drawing.Size(45, 13)
        Me.CiLabel14.TabIndex = 10
        Me.CiLabel14.Text = "Colonia:"
        '
        'txtColoniaFis
        '
        Me.txtColoniaFis.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtColoniaFis.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtColoniaFis.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtColoniaFis.Location = New System.Drawing.Point(89, 112)
        Me.txtColoniaFis.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColoniaFis.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColoniaFis.Name = "txtColoniaFis"
        Me.txtColoniaFis.RequiredField = True
        Me.txtColoniaFis.Size = New System.Drawing.Size(217, 20)
        Me.txtColoniaFis.TabIndex = 5
        Me.txtColoniaFis.UIName = "Colonia"
        '
        'CiLabel15
        '
        Me.CiLabel15.AutoSize = True
        Me.CiLabel15.Location = New System.Drawing.Point(12, 92)
        Me.CiLabel15.Name = "CiLabel15"
        Me.CiLabel15.Size = New System.Drawing.Size(65, 13)
        Me.CiLabel15.TabIndex = 6
        Me.CiLabel15.Text = "No. Exterior:"
        '
        'txtNumIntFis
        '
        Me.txtNumIntFis.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNumIntFis.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNumIntFis.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumIntFis.Location = New System.Drawing.Point(234, 89)
        Me.txtNumIntFis.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumIntFis.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumIntFis.Name = "txtNumIntFis"
        Me.txtNumIntFis.Size = New System.Drawing.Size(70, 20)
        Me.txtNumIntFis.TabIndex = 4
        Me.txtNumIntFis.UIName = Nothing
        '
        'CiLabel16
        '
        Me.CiLabel16.AutoSize = True
        Me.CiLabel16.Location = New System.Drawing.Point(166, 92)
        Me.CiLabel16.Name = "CiLabel16"
        Me.CiLabel16.Size = New System.Drawing.Size(62, 13)
        Me.CiLabel16.TabIndex = 8
        Me.CiLabel16.Text = "No. Interior:"
        '
        'txtNumExtFis
        '
        Me.txtNumExtFis.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNumExtFis.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNumExtFis.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumExtFis.Location = New System.Drawing.Point(90, 89)
        Me.txtNumExtFis.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExtFis.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExtFis.Name = "txtNumExtFis"
        Me.txtNumExtFis.RequiredField = True
        Me.txtNumExtFis.Size = New System.Drawing.Size(70, 20)
        Me.txtNumExtFis.TabIndex = 3
        Me.txtNumExtFis.UIName = "No. exterior"
        '
        'CiLabel17
        '
        Me.CiLabel17.AutoSize = True
        Me.CiLabel17.Location = New System.Drawing.Point(372, 115)
        Me.CiLabel17.Name = "CiLabel17"
        Me.CiLabel17.Size = New System.Drawing.Size(75, 13)
        Me.CiLabel17.TabIndex = 12
        Me.CiLabel17.Text = "Código Postal:"
        '
        'CiLabel18
        '
        Me.CiLabel18.AutoSize = True
        Me.CiLabel18.Location = New System.Drawing.Point(12, 138)
        Me.CiLabel18.Name = "CiLabel18"
        Me.CiLabel18.Size = New System.Drawing.Size(57, 13)
        Me.CiLabel18.TabIndex = 14
        Me.CiLabel18.Text = "Población:"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(154, 108)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(213, 20)
        Me.txtNombre.TabIndex = 0
        Me.txtNombre.UIName = "Nombre"
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(73, 111)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(47, 13)
        Me.CiLabel1.TabIndex = 34
        Me.CiLabel1.Text = "Nombre:"
        '
        'txtCorreo
        '
        Me.txtCorreo.BackColor = System.Drawing.SystemColors.Window
        Me.txtCorreo.CharacterCasing = Azteca.Windows.Controls.CaseType.Lower
        Me.txtCorreo.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCorreo.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCorreo.Location = New System.Drawing.Point(420, 109)
        Me.txtCorreo.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCorreo.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.RegularExpression = resources.GetString("txtCorreo.RegularExpression")
        Me.txtCorreo.Size = New System.Drawing.Size(176, 20)
        Me.txtCorreo.TabIndex = 1
        Me.txtCorreo.UIName = "Correo Electrónico"
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.Location = New System.Drawing.Point(373, 112)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(41, 13)
        Me.CiLabel4.TabIndex = 36
        Me.CiLabel4.Text = "Correo:"
        '
        'selListaPrecios
        '
        Me.selListaPrecios.AnySite = False
        Me.selListaPrecios.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selListaPrecios.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.selListaPrecios.EditorAssembly = "Azteca.VentasWin"
        Me.selListaPrecios.EditorClass = "Azteca.Windows.Ventas.ListaPreciosForm"
        Me.selListaPrecios.EditorTitle = "Editar datos de Lista de precios..."
        Me.selListaPrecios.Key = 0
        Me.selListaPrecios.Linked = False
        Me.selListaPrecios.Location = New System.Drawing.Point(154, 130)
        Me.selListaPrecios.Name = "selListaPrecios"
        Me.selListaPrecios.RequiredField = True
        Me.selListaPrecios.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selListaPrecios.Size = New System.Drawing.Size(442, 23)
        Me.selListaPrecios.TabIndex = 2
        Me.selListaPrecios.UIName = "Lista de Precios"
        '
        'lblListaPrecios
        '
        Me.lblListaPrecios.AutoSize = True
        Me.lblListaPrecios.Location = New System.Drawing.Point(70, 135)
        Me.lblListaPrecios.Name = "lblListaPrecios"
        Me.lblListaPrecios.Size = New System.Drawing.Size(85, 13)
        Me.lblListaPrecios.TabIndex = 39
        Me.lblListaPrecios.Text = "Lista de Precios:"
        '
        'ClienteExpressForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 501)
        Me.Controls.Add(Me.lblListaPrecios)
        Me.Controls.Add(Me.selListaPrecios)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.CiLabel4)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.grpIntegracionFact)
        Me.Controls.Add(Me.grpDatosFiscales)
        Me.Name = "ClienteExpressForm"
        Me.Text = "ClienteExpressForm"
        Me.Controls.SetChildIndex(Me.grpDatosFiscales, 0)
        Me.Controls.SetChildIndex(Me.grpIntegracionFact, 0)
        Me.Controls.SetChildIndex(Me.CiLabel1, 0)
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.CiLabel4, 0)
        Me.Controls.SetChildIndex(Me.txtCorreo, 0)
        Me.Controls.SetChildIndex(Me.selListaPrecios, 0)
        Me.Controls.SetChildIndex(Me.lblListaPrecios, 0)
        Me.grpIntegracionFact.ResumeLayout(False)
        Me.grpIntegracionFact.PerformLayout()
        Me.grpDatosFiscales.ResumeLayout(False)
        Me.grpDatosFiscales.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpIntegracionFact As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents cboAddenda As Azteca.Windows.Contabilidad.AddendasCombobox
    Friend WithEvents txtNumProveedor As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtGLNTienda As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtGLN As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel22 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel21 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel20 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel19 As Azteca.Windows.Controls.CILabel
    Friend WithEvents grpDatosFiscales As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents txtRazonSocial As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtRFC As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel11 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel12 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCalleFis As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtPoblacionFis As Azteca.Windows.Controls.General.PoblacionSelector
    Friend WithEvents CiLabel13 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCPFis As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel14 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtColoniaFis As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel15 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNumIntFis As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel16 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNumExtFis As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel17 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel18 As Azteca.Windows.Controls.CILabel

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Facade = New Azteca.Business.Ventas.ClienteFacade
    End Sub
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboMetodoPago As Azteca.Windows.Ventas.MetodoPagoComboBox
    Friend WithEvents txtCuentaPago As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel25 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel26 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCorreo As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
    Friend WithEvents selListaPrecios As Azteca.Windows.Ventas.ListaPreciosSelector
    Friend WithEvents lblListaPrecios As Azteca.Windows.Controls.CILabel
End Class
