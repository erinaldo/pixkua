<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PacientesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PacientesForm))
        Me.tabArticulos = New Azteca.Windows.Controls.CITab()
        Me.tabGenerales = New System.Windows.Forms.TabPage()
        Me.selListaPrecios = New Azteca.Windows.Ventas.ListaPreciosSelector()
        Me.lblListaPrecios = New Azteca.Windows.Controls.CILabel()
        Me.CiGroupBox1 = New Azteca.Windows.Controls.CIGroupBox()
        Me.txtCalle = New Azteca.Windows.Controls.CITextBox()
        Me.txtPoblacion = New Azteca.Windows.Controls.General.PoblacionSelector()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.txtCodPos = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel5 = New Azteca.Windows.Controls.CILabel()
        Me.txtColonia = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel6 = New Azteca.Windows.Controls.CILabel()
        Me.txtNumInt = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel7 = New Azteca.Windows.Controls.CILabel()
        Me.txtNumExt = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel8 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel9 = New Azteca.Windows.Controls.CILabel()
        Me.chkAfiliado = New Azteca.Windows.Controls.CICheckBox()
        Me.lblTelefono = New Azteca.Windows.Controls.CILabel()
        Me.txtTel = New Azteca.Windows.Controls.CITextBox()
        Me.rbFemenino = New Azteca.Windows.Controls.CIRadioButton()
        Me.rdbMasculino = New Azteca.Windows.Controls.CIRadioButton()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.dtpFechaNac = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.tabFacturacion = New System.Windows.Forms.TabPage()
        Me.txtRazonSocial = New Azteca.Windows.Controls.CITextBox()
        Me.txtRFC = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel11 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel12 = New Azteca.Windows.Controls.CILabel()
        Me.chkFacturable = New Azteca.Windows.Controls.CICheckBox()
        Me.grpDatosFiscales = New Azteca.Windows.Controls.CIGroupBox()
        Me.txtCopiar = New Azteca.Windows.Controls.CIButton()
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
        Me.iLstTabs = New System.Windows.Forms.ImageList(Me.components)
        Me.txtCorreo = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.tabArticulos.SuspendLayout()
        Me.tabGenerales.SuspendLayout()
        Me.CiGroupBox1.SuspendLayout()
        Me.tabFacturacion.SuspendLayout()
        Me.grpDatosFiscales.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabArticulos
        '
        Me.tabArticulos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabArticulos.Controls.Add(Me.tabGenerales)
        Me.tabArticulos.Controls.Add(Me.tabFacturacion)
        Me.tabArticulos.Location = New System.Drawing.Point(27, 90)
        Me.tabArticulos.Name = "tabArticulos"
        Me.tabArticulos.SelectedIndex = 0
        Me.tabArticulos.Size = New System.Drawing.Size(557, 340)
        Me.tabArticulos.TabIndex = 3
        '
        'tabGenerales
        '
        Me.tabGenerales.Controls.Add(Me.selListaPrecios)
        Me.tabGenerales.Controls.Add(Me.lblListaPrecios)
        Me.tabGenerales.Controls.Add(Me.CiGroupBox1)
        Me.tabGenerales.Controls.Add(Me.chkAfiliado)
        Me.tabGenerales.Controls.Add(Me.lblTelefono)
        Me.tabGenerales.Controls.Add(Me.txtCorreo)
        Me.tabGenerales.Controls.Add(Me.txtTel)
        Me.tabGenerales.Controls.Add(Me.rbFemenino)
        Me.tabGenerales.Controls.Add(Me.rdbMasculino)
        Me.tabGenerales.Controls.Add(Me.CiLabel2)
        Me.tabGenerales.Controls.Add(Me.dtpFechaNac)
        Me.tabGenerales.Controls.Add(Me.txtNombre)
        Me.tabGenerales.Controls.Add(Me.CiLabel1)
        Me.tabGenerales.Controls.Add(Me.CiLabel4)
        Me.tabGenerales.ImageIndex = 1
        Me.tabGenerales.Location = New System.Drawing.Point(4, 22)
        Me.tabGenerales.Name = "tabGenerales"
        Me.tabGenerales.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGenerales.Size = New System.Drawing.Size(549, 314)
        Me.tabGenerales.TabIndex = 0
        Me.tabGenerales.Text = "Datos Generales"
        Me.tabGenerales.UseVisualStyleBackColor = True
        '
        'selListaPrecios
        '
        Me.selListaPrecios.AnySite = False
        Me.selListaPrecios.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selListaPrecios.EditorAssembly = "Azteca.VentasWin"
        Me.selListaPrecios.EditorClass = "Azteca.Windows.Ventas.ListaPreciosForm"
        Me.selListaPrecios.EditorTitle = "Editar datos de Lista de precios..."
        Me.selListaPrecios.Key = 0
        Me.selListaPrecios.Linked = False
        Me.selListaPrecios.Location = New System.Drawing.Point(116, 116)
        Me.selListaPrecios.Name = "selListaPrecios"
        Me.selListaPrecios.Size = New System.Drawing.Size(400, 23)
        Me.selListaPrecios.TabIndex = 7
        Me.selListaPrecios.UIName = "Lista de Precios"
        '
        'lblListaPrecios
        '
        Me.lblListaPrecios.AutoSize = True
        Me.lblListaPrecios.Location = New System.Drawing.Point(22, 118)
        Me.lblListaPrecios.Name = "lblListaPrecios"
        Me.lblListaPrecios.Size = New System.Drawing.Size(85, 13)
        Me.lblListaPrecios.TabIndex = 51
        Me.lblListaPrecios.Text = "Lista de Precios:"
        '
        'CiGroupBox1
        '
        Me.CiGroupBox1.Controls.Add(Me.txtCalle)
        Me.CiGroupBox1.Controls.Add(Me.txtPoblacion)
        Me.CiGroupBox1.Controls.Add(Me.CiLabel3)
        Me.CiGroupBox1.Controls.Add(Me.txtCodPos)
        Me.CiGroupBox1.Controls.Add(Me.CiLabel5)
        Me.CiGroupBox1.Controls.Add(Me.txtColonia)
        Me.CiGroupBox1.Controls.Add(Me.CiLabel6)
        Me.CiGroupBox1.Controls.Add(Me.txtNumInt)
        Me.CiGroupBox1.Controls.Add(Me.CiLabel7)
        Me.CiGroupBox1.Controls.Add(Me.txtNumExt)
        Me.CiGroupBox1.Controls.Add(Me.CiLabel8)
        Me.CiGroupBox1.Controls.Add(Me.CiLabel9)
        Me.CiGroupBox1.Location = New System.Drawing.Point(6, 138)
        Me.CiGroupBox1.Name = "CiGroupBox1"
        Me.CiGroupBox1.Size = New System.Drawing.Size(526, 158)
        Me.CiGroupBox1.TabIndex = 61
        Me.CiGroupBox1.TabStop = False
        Me.CiGroupBox1.Text = "Domicilio"
        '
        'txtCalle
        '
        Me.txtCalle.BackColor = System.Drawing.SystemColors.Window
        Me.txtCalle.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCalle.Location = New System.Drawing.Point(112, 27)
        Me.txtCalle.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalle.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.RequiredField = True
        Me.txtCalle.Size = New System.Drawing.Size(398, 20)
        Me.txtCalle.TabIndex = 0
        Me.txtCalle.UIName = "Calle"
        '
        'txtPoblacion
        '
        Me.txtPoblacion.AnySite = False
        Me.txtPoblacion.AutoClear = False
        Me.txtPoblacion.AutoLock = False
        Me.txtPoblacion.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtPoblacion.EditorAssembly = "Azteca.Windows"
        Me.txtPoblacion.EditorClass = "Azteca.Windows.Forms.General.CatalogoPoblaciones"
        Me.txtPoblacion.EditorTitle = "Editar población..."
        Me.txtPoblacion.Key = 0
        Me.txtPoblacion.Linked = False
        Me.txtPoblacion.Location = New System.Drawing.Point(111, 95)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.RequiredField = True
        Me.txtPoblacion.Size = New System.Drawing.Size(399, 23)
        Me.txtPoblacion.TabIndex = 4
        Me.txtPoblacion.TextWidth = 70
        Me.txtPoblacion.UIName = "Población"
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(16, 30)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(33, 13)
        Me.CiLabel3.TabIndex = 4
        Me.CiLabel3.Text = "Calle:"
        '
        'txtCodPos
        '
        Me.txtCodPos.Digits = True
        Me.txtCodPos.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCodPos.Location = New System.Drawing.Point(111, 124)
        Me.txtCodPos.MaxLength = 5
        Me.txtCodPos.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCodPos.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCodPos.Name = "txtCodPos"
        Me.txtCodPos.RequiredField = True
        Me.txtCodPos.Size = New System.Drawing.Size(82, 20)
        Me.txtCodPos.TabIndex = 5
        Me.txtCodPos.UIName = "Código Postal"
        '
        'CiLabel5
        '
        Me.CiLabel5.AutoSize = True
        Me.CiLabel5.Location = New System.Drawing.Point(16, 76)
        Me.CiLabel5.Name = "CiLabel5"
        Me.CiLabel5.Size = New System.Drawing.Size(45, 13)
        Me.CiLabel5.TabIndex = 10
        Me.CiLabel5.Text = "Colonia:"
        '
        'txtColonia
        '
        Me.txtColonia.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtColonia.Location = New System.Drawing.Point(111, 73)
        Me.txtColonia.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColonia.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.RequiredField = True
        Me.txtColonia.Size = New System.Drawing.Size(217, 20)
        Me.txtColonia.TabIndex = 3
        Me.txtColonia.UIName = "Colonia"
        '
        'CiLabel6
        '
        Me.CiLabel6.AutoSize = True
        Me.CiLabel6.Location = New System.Drawing.Point(16, 53)
        Me.CiLabel6.Name = "CiLabel6"
        Me.CiLabel6.Size = New System.Drawing.Size(65, 13)
        Me.CiLabel6.TabIndex = 6
        Me.CiLabel6.Text = "No. Exterior:"
        '
        'txtNumInt
        '
        Me.txtNumInt.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumInt.Location = New System.Drawing.Point(257, 50)
        Me.txtNumInt.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumInt.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumInt.Name = "txtNumInt"
        Me.txtNumInt.Size = New System.Drawing.Size(70, 20)
        Me.txtNumInt.TabIndex = 2
        Me.txtNumInt.UIName = Nothing
        '
        'CiLabel7
        '
        Me.CiLabel7.AutoSize = True
        Me.CiLabel7.Location = New System.Drawing.Point(189, 53)
        Me.CiLabel7.Name = "CiLabel7"
        Me.CiLabel7.Size = New System.Drawing.Size(62, 13)
        Me.CiLabel7.TabIndex = 8
        Me.CiLabel7.Text = "No. Interior:"
        '
        'txtNumExt
        '
        Me.txtNumExt.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumExt.Location = New System.Drawing.Point(112, 50)
        Me.txtNumExt.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExt.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExt.Name = "txtNumExt"
        Me.txtNumExt.RequiredField = True
        Me.txtNumExt.Size = New System.Drawing.Size(70, 20)
        Me.txtNumExt.TabIndex = 1
        Me.txtNumExt.UIName = "No. exterior"
        '
        'CiLabel8
        '
        Me.CiLabel8.AutoSize = True
        Me.CiLabel8.Location = New System.Drawing.Point(15, 127)
        Me.CiLabel8.Name = "CiLabel8"
        Me.CiLabel8.Size = New System.Drawing.Size(75, 13)
        Me.CiLabel8.TabIndex = 12
        Me.CiLabel8.Text = "Código Postal:"
        '
        'CiLabel9
        '
        Me.CiLabel9.AutoSize = True
        Me.CiLabel9.Location = New System.Drawing.Point(16, 99)
        Me.CiLabel9.Name = "CiLabel9"
        Me.CiLabel9.Size = New System.Drawing.Size(57, 13)
        Me.CiLabel9.TabIndex = 14
        Me.CiLabel9.Text = "Población:"
        '
        'chkAfiliado
        '
        Me.chkAfiliado.AutoSize = True
        Me.chkAfiliado.Location = New System.Drawing.Point(378, 94)
        Me.chkAfiliado.Name = "chkAfiliado"
        Me.chkAfiliado.Size = New System.Drawing.Size(60, 17)
        Me.chkAfiliado.TabIndex = 6
        Me.chkAfiliado.Text = "Afiliado"
        Me.chkAfiliado.UseVisualStyleBackColor = True
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(22, 71)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefono.TabIndex = 59
        Me.lblTelefono.Text = "Telefono:"
        '
        'txtTel
        '
        Me.txtTel.BackColor = System.Drawing.SystemColors.Window
        Me.txtTel.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTel.Location = New System.Drawing.Point(116, 68)
        Me.txtTel.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTel.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(210, 20)
        Me.txtTel.TabIndex = 2
        Me.txtTel.UIName = "Telefono"
        '
        'rbFemenino
        '
        Me.rbFemenino.AutoSize = True
        Me.rbFemenino.Location = New System.Drawing.Point(378, 67)
        Me.rbFemenino.Name = "rbFemenino"
        Me.rbFemenino.Size = New System.Drawing.Size(71, 17)
        Me.rbFemenino.TabIndex = 4
        Me.rbFemenino.Text = "Femenino"
        Me.rbFemenino.UseVisualStyleBackColor = True
        '
        'rdbMasculino
        '
        Me.rdbMasculino.AutoSize = True
        Me.rdbMasculino.Checked = True
        Me.rdbMasculino.Location = New System.Drawing.Point(378, 44)
        Me.rdbMasculino.Name = "rdbMasculino"
        Me.rdbMasculino.Size = New System.Drawing.Size(73, 17)
        Me.rdbMasculino.TabIndex = 3
        Me.rdbMasculino.TabStop = True
        Me.rdbMasculino.Text = "Masculino"
        Me.rdbMasculino.UseVisualStyleBackColor = True
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(20, 46)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(93, 13)
        Me.CiLabel2.TabIndex = 55
        Me.CiLabel2.Text = "Fecha Nacimiento"
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNac.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaNac.Location = New System.Drawing.Point(116, 44)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Size = New System.Drawing.Size(210, 20)
        Me.dtpFechaNac.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(116, 20)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(407, 20)
        Me.txtNombre.TabIndex = 0
        Me.txtNombre.UIName = "Nombre"
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(20, 23)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(47, 13)
        Me.CiLabel1.TabIndex = 52
        Me.CiLabel1.Text = "Nombre:"
        '
        'tabFacturacion
        '
        Me.tabFacturacion.Controls.Add(Me.txtRazonSocial)
        Me.tabFacturacion.Controls.Add(Me.txtRFC)
        Me.tabFacturacion.Controls.Add(Me.CiLabel11)
        Me.tabFacturacion.Controls.Add(Me.CiLabel12)
        Me.tabFacturacion.Controls.Add(Me.chkFacturable)
        Me.tabFacturacion.Controls.Add(Me.grpDatosFiscales)
        Me.tabFacturacion.ImageIndex = 0
        Me.tabFacturacion.Location = New System.Drawing.Point(4, 22)
        Me.tabFacturacion.Name = "tabFacturacion"
        Me.tabFacturacion.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFacturacion.Size = New System.Drawing.Size(549, 314)
        Me.tabFacturacion.TabIndex = 1
        Me.tabFacturacion.Text = "Datos Facturacion"
        Me.tabFacturacion.UseVisualStyleBackColor = True
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtRazonSocial.Location = New System.Drawing.Point(127, 63)
        Me.txtRazonSocial.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRazonSocial.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(400, 20)
        Me.txtRazonSocial.TabIndex = 1
        Me.txtRazonSocial.UIName = "Razon Social"
        '
        'txtRFC
        '
        Me.txtRFC.BackColor = System.Drawing.SystemColors.Window
        Me.txtRFC.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtRFC.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtRFC.Location = New System.Drawing.Point(127, 40)
        Me.txtRFC.MaxLength = 13
        Me.txtRFC.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRFC.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.RegularExpression = resources.GetString("txtRFC.RegularExpression")
        Me.txtRFC.Size = New System.Drawing.Size(141, 20)
        Me.txtRFC.TabIndex = 0
        Me.txtRFC.UIName = "RFC"
        '
        'CiLabel11
        '
        Me.CiLabel11.AutoSize = True
        Me.CiLabel11.Location = New System.Drawing.Point(31, 66)
        Me.CiLabel11.Name = "CiLabel11"
        Me.CiLabel11.Size = New System.Drawing.Size(73, 13)
        Me.CiLabel11.TabIndex = 54
        Me.CiLabel11.Text = "Razón Social:"
        '
        'CiLabel12
        '
        Me.CiLabel12.AutoSize = True
        Me.CiLabel12.Location = New System.Drawing.Point(31, 43)
        Me.CiLabel12.Name = "CiLabel12"
        Me.CiLabel12.Size = New System.Drawing.Size(31, 13)
        Me.CiLabel12.TabIndex = 51
        Me.CiLabel12.Text = "RFC:"
        '
        'chkFacturable
        '
        Me.chkFacturable.AutoSize = True
        Me.chkFacturable.Location = New System.Drawing.Point(30, 17)
        Me.chkFacturable.Name = "chkFacturable"
        Me.chkFacturable.Size = New System.Drawing.Size(76, 17)
        Me.chkFacturable.TabIndex = 50
        Me.chkFacturable.Text = "Facturable"
        Me.chkFacturable.UseVisualStyleBackColor = True
        '
        'grpDatosFiscales
        '
        Me.grpDatosFiscales.Controls.Add(Me.txtCopiar)
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
        Me.grpDatosFiscales.Location = New System.Drawing.Point(17, 95)
        Me.grpDatosFiscales.Name = "grpDatosFiscales"
        Me.grpDatosFiscales.Size = New System.Drawing.Size(526, 190)
        Me.grpDatosFiscales.TabIndex = 43
        Me.grpDatosFiscales.TabStop = False
        Me.grpDatosFiscales.Text = "Domicilio Fiscal"
        '
        'txtCopiar
        '
        Me.txtCopiar.Location = New System.Drawing.Point(112, 19)
        Me.txtCopiar.Name = "txtCopiar"
        Me.txtCopiar.Size = New System.Drawing.Size(398, 25)
        Me.txtCopiar.TabIndex = 0
        Me.txtCopiar.Text = "Copiar domicilio del paciente"
        Me.txtCopiar.UseVisualStyleBackColor = True
        '
        'txtCalleFis
        '
        Me.txtCalleFis.BackColor = System.Drawing.SystemColors.Window
        Me.txtCalleFis.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCalleFis.Location = New System.Drawing.Point(112, 51)
        Me.txtCalleFis.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalleFis.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalleFis.Name = "txtCalleFis"
        Me.txtCalleFis.Size = New System.Drawing.Size(398, 20)
        Me.txtCalleFis.TabIndex = 1
        Me.txtCalleFis.UIName = "Calle"
        '
        'txtPoblacionFis
        '
        Me.txtPoblacionFis.AnySite = False
        Me.txtPoblacionFis.AutoClear = False
        Me.txtPoblacionFis.AutoLock = False
        Me.txtPoblacionFis.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtPoblacionFis.EditorAssembly = "Azteca.Windows"
        Me.txtPoblacionFis.EditorClass = "Azteca.Windows.Forms.General.CatalogoPoblaciones"
        Me.txtPoblacionFis.EditorTitle = "Editar población..."
        Me.txtPoblacionFis.Key = 0
        Me.txtPoblacionFis.Linked = False
        Me.txtPoblacionFis.Location = New System.Drawing.Point(111, 119)
        Me.txtPoblacionFis.Name = "txtPoblacionFis"
        Me.txtPoblacionFis.Size = New System.Drawing.Size(399, 23)
        Me.txtPoblacionFis.TabIndex = 5
        Me.txtPoblacionFis.TextWidth = 70
        Me.txtPoblacionFis.UIName = "Población"
        '
        'CiLabel13
        '
        Me.CiLabel13.AutoSize = True
        Me.CiLabel13.Location = New System.Drawing.Point(16, 54)
        Me.CiLabel13.Name = "CiLabel13"
        Me.CiLabel13.Size = New System.Drawing.Size(33, 13)
        Me.CiLabel13.TabIndex = 4
        Me.CiLabel13.Text = "Calle:"
        '
        'txtCPFis
        '
        Me.txtCPFis.Digits = True
        Me.txtCPFis.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCPFis.Location = New System.Drawing.Point(111, 148)
        Me.txtCPFis.MaxLength = 5
        Me.txtCPFis.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCPFis.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCPFis.Name = "txtCPFis"
        Me.txtCPFis.Size = New System.Drawing.Size(82, 20)
        Me.txtCPFis.TabIndex = 6
        Me.txtCPFis.UIName = "Código Postal"
        '
        'CiLabel14
        '
        Me.CiLabel14.AutoSize = True
        Me.CiLabel14.Location = New System.Drawing.Point(16, 100)
        Me.CiLabel14.Name = "CiLabel14"
        Me.CiLabel14.Size = New System.Drawing.Size(45, 13)
        Me.CiLabel14.TabIndex = 10
        Me.CiLabel14.Text = "Colonia:"
        '
        'txtColoniaFis
        '
        Me.txtColoniaFis.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtColoniaFis.Location = New System.Drawing.Point(111, 97)
        Me.txtColoniaFis.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColoniaFis.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColoniaFis.Name = "txtColoniaFis"
        Me.txtColoniaFis.Size = New System.Drawing.Size(217, 20)
        Me.txtColoniaFis.TabIndex = 4
        Me.txtColoniaFis.UIName = "Colonia"
        '
        'CiLabel15
        '
        Me.CiLabel15.AutoSize = True
        Me.CiLabel15.Location = New System.Drawing.Point(16, 77)
        Me.CiLabel15.Name = "CiLabel15"
        Me.CiLabel15.Size = New System.Drawing.Size(65, 13)
        Me.CiLabel15.TabIndex = 6
        Me.CiLabel15.Text = "No. Exterior:"
        '
        'txtNumIntFis
        '
        Me.txtNumIntFis.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumIntFis.Location = New System.Drawing.Point(257, 74)
        Me.txtNumIntFis.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumIntFis.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumIntFis.Name = "txtNumIntFis"
        Me.txtNumIntFis.Size = New System.Drawing.Size(70, 20)
        Me.txtNumIntFis.TabIndex = 3
        Me.txtNumIntFis.UIName = Nothing
        '
        'CiLabel16
        '
        Me.CiLabel16.AutoSize = True
        Me.CiLabel16.Location = New System.Drawing.Point(189, 77)
        Me.CiLabel16.Name = "CiLabel16"
        Me.CiLabel16.Size = New System.Drawing.Size(62, 13)
        Me.CiLabel16.TabIndex = 8
        Me.CiLabel16.Text = "No. Interior:"
        '
        'txtNumExtFis
        '
        Me.txtNumExtFis.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumExtFis.Location = New System.Drawing.Point(112, 74)
        Me.txtNumExtFis.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExtFis.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExtFis.Name = "txtNumExtFis"
        Me.txtNumExtFis.Size = New System.Drawing.Size(70, 20)
        Me.txtNumExtFis.TabIndex = 2
        Me.txtNumExtFis.UIName = "No. exterior"
        '
        'CiLabel17
        '
        Me.CiLabel17.AutoSize = True
        Me.CiLabel17.Location = New System.Drawing.Point(15, 151)
        Me.CiLabel17.Name = "CiLabel17"
        Me.CiLabel17.Size = New System.Drawing.Size(75, 13)
        Me.CiLabel17.TabIndex = 12
        Me.CiLabel17.Text = "Código Postal:"
        '
        'CiLabel18
        '
        Me.CiLabel18.AutoSize = True
        Me.CiLabel18.Location = New System.Drawing.Point(16, 123)
        Me.CiLabel18.Name = "CiLabel18"
        Me.CiLabel18.Size = New System.Drawing.Size(57, 13)
        Me.CiLabel18.TabIndex = 14
        Me.CiLabel18.Text = "Población:"
        '
        'iLstTabs
        '
        Me.iLstTabs.ImageStream = CType(resources.GetObject("iLstTabs.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.iLstTabs.TransparentColor = System.Drawing.Color.Transparent
        Me.iLstTabs.Images.SetKeyName(0, "mask_32.png")
        Me.iLstTabs.Images.SetKeyName(1, "food_32.png")
        '
        'txtCorreo
        '
        Me.txtCorreo.BackColor = System.Drawing.SystemColors.Window
        Me.txtCorreo.CharacterCasing = Azteca.Windows.Controls.CaseType.Lower
        Me.txtCorreo.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCorreo.Location = New System.Drawing.Point(116, 92)
        Me.txtCorreo.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCorreo.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.RegularExpression = resources.GetString("txtCorreo.RegularExpression")
        Me.txtCorreo.Size = New System.Drawing.Size(210, 20)
        Me.txtCorreo.TabIndex = 5
        Me.txtCorreo.UIName = "Correo Electrónico"
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.Location = New System.Drawing.Point(22, 94)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(41, 13)
        Me.CiLabel4.TabIndex = 54
        Me.CiLabel4.Text = "Correo:"
        '
        'PacientesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 475)
        Me.Controls.Add(Me.tabArticulos)
        Me.Name = "PacientesForm"
        Me.Text = "PacientesForm"
        Me.Controls.SetChildIndex(Me.tabArticulos, 0)
        Me.tabArticulos.ResumeLayout(False)
        Me.tabGenerales.ResumeLayout(False)
        Me.tabGenerales.PerformLayout()
        Me.CiGroupBox1.ResumeLayout(False)
        Me.CiGroupBox1.PerformLayout()
        Me.tabFacturacion.ResumeLayout(False)
        Me.tabFacturacion.PerformLayout()
        Me.grpDatosFiscales.ResumeLayout(False)
        Me.grpDatosFiscales.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabArticulos As Azteca.Windows.Controls.CITab
    Friend WithEvents tabGenerales As System.Windows.Forms.TabPage
    Friend WithEvents chkAfiliado As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents lblTelefono As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtTel As Azteca.Windows.Controls.CITextBox
    Friend WithEvents rbFemenino As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents rdbMasculino As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents dtpFechaNac As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents tabFacturacion As System.Windows.Forms.TabPage
    Friend WithEvents chkFacturable As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents grpDatosFiscales As Azteca.Windows.Controls.CIGroupBox
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
    Friend WithEvents CiGroupBox1 As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents txtCalle As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtPoblacion As Azteca.Windows.Controls.General.PoblacionSelector
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCodPos As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel5 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtColonia As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel6 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNumInt As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel7 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNumExt As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel8 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel9 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtRazonSocial As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtRFC As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel11 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel12 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCopiar As Azteca.Windows.Controls.CIButton
    Friend WithEvents iLstTabs As System.Windows.Forms.ImageList
    Friend WithEvents lblListaPrecios As Azteca.Windows.Controls.CILabel
    Friend WithEvents selListaPrecios As Azteca.Windows.Ventas.ListaPreciosSelector

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Facade = New PacienteFacade
    End Sub
    Friend WithEvents txtCorreo As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
End Class
