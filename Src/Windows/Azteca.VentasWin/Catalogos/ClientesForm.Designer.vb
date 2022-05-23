<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientesForm))
        Dim Style1 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style2 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style3 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style4 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style5 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style6 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style7 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style8 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Me.tabClientes = New Azteca.Windows.Controls.CITab()
        Me.pagGeneral = New System.Windows.Forms.TabPage()
        Me.txtPagWeb = New Azteca.Windows.Controls.CITextBox()
        Me.txtCorreo = New Azteca.Windows.Controls.CITextBox()
        Me.txtFax = New Azteca.Windows.Controls.CITextBox()
        Me.txtTel = New Azteca.Windows.Controls.CITextBox()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel5 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.pagDomicilio = New System.Windows.Forms.TabPage()
        Me.txtPoblacion = New Azteca.Windows.Controls.General.PoblacionSelector()
        Me.txtCP = New Azteca.Windows.Controls.CITextBox()
        Me.txtColonia = New Azteca.Windows.Controls.CITextBox()
        Me.txtNumInt = New Azteca.Windows.Controls.CITextBox()
        Me.txtNumExt = New Azteca.Windows.Controls.CITextBox()
        Me.txtCalle = New Azteca.Windows.Controls.CITextBox()
        Me.lblPoblacion = New Azteca.Windows.Controls.CILabel()
        Me.lblCodigoPostal = New Azteca.Windows.Controls.CILabel()
        Me.lblNumInt = New Azteca.Windows.Controls.CILabel()
        Me.lblNumExt = New Azteca.Windows.Controls.CILabel()
        Me.lblColonia = New Azteca.Windows.Controls.CILabel()
        Me.lblCalle = New Azteca.Windows.Controls.CILabel()
        Me.pagFiscales = New System.Windows.Forms.TabPage()
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
        Me.txtRazonSocial = New Azteca.Windows.Controls.CITextBox()
        Me.txtRFC = New Azteca.Windows.Controls.CITextBox()
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
        Me.chkFacturable = New Azteca.Windows.Controls.CICheckBox()
        Me.pagVentas = New System.Windows.Forms.TabPage()
        Me.CiGroupBox2 = New Azteca.Windows.Controls.CIGroupBox()
        Me.txtCuentaPago = New Azteca.Windows.Controls.CITextBox()
        Me.cboMetodoPago = New Azteca.Windows.Ventas.MetodoPagoComboBox()
        Me.CiLabel26 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel25 = New Azteca.Windows.Controls.CILabel()
        Me.selListaPrecios = New Azteca.Windows.Ventas.ListaPreciosSelector()
        Me.selGrupoDescuentos = New Azteca.Windows.Ventas.GrupoDescuentosSelector()
        Me.CiGroupBox1 = New Azteca.Windows.Controls.CIGroupBox()
        Me.rdbCredito = New Azteca.Windows.Controls.CIRadioButton()
        Me.rdbContado = New Azteca.Windows.Controls.CIRadioButton()
        Me.txtSaldoCredito = New Azteca.Windows.Controls.CITextBox()
        Me.txtDiasCredito = New Azteca.Windows.Controls.CITextBox()
        Me.txtLimiteCredito = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel23 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel9 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel10 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel8 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel7 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel6 = New Azteca.Windows.Controls.CILabel()
        Me.pagContactos = New System.Windows.Forms.TabPage()
        Me.tlbContactos = New Azteca.Windows.Controls.CIToolBar()
        Me.btnNuevoContacto = New System.Windows.Forms.ToolStripButton()
        Me.grdContactos = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsContactos = New System.Windows.Forms.BindingSource(Me.components)
        Me.pagClasificaciones = New System.Windows.Forms.TabPage()
        Me.cboClasificaciones = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.bsClasificaciones = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdClasificaciones = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsGruposClasif = New System.Windows.Forms.BindingSource(Me.components)
        Me.pagContabilidad = New System.Windows.Forms.TabPage()
        Me.txtCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.CiLabel24 = New Azteca.Windows.Controls.CILabel()
        Me.imlClientes = New System.Windows.Forms.ImageList(Me.components)
        Me.tabClientes.SuspendLayout()
        Me.pagGeneral.SuspendLayout()
        Me.pagDomicilio.SuspendLayout()
        Me.pagFiscales.SuspendLayout()
        Me.grpIntegracionFact.SuspendLayout()
        Me.grpDatosFiscales.SuspendLayout()
        Me.pagVentas.SuspendLayout()
        Me.CiGroupBox2.SuspendLayout()
        Me.CiGroupBox1.SuspendLayout()
        Me.pagContactos.SuspendLayout()
        Me.tlbContactos.SuspendLayout()
        CType(Me.grdContactos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsContactos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagClasificaciones.SuspendLayout()
        CType(Me.cboClasificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsClasificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdClasificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsGruposClasif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagContabilidad.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabClientes
        '
        Me.tabClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabClientes.Controls.Add(Me.pagGeneral)
        Me.tabClientes.Controls.Add(Me.pagDomicilio)
        Me.tabClientes.Controls.Add(Me.pagFiscales)
        Me.tabClientes.Controls.Add(Me.pagVentas)
        Me.tabClientes.Controls.Add(Me.pagContactos)
        Me.tabClientes.Controls.Add(Me.pagClasificaciones)
        Me.tabClientes.Controls.Add(Me.pagContabilidad)
        Me.tabClientes.ImageList = Me.imlClientes
        Me.tabClientes.ItemSize = New System.Drawing.Size(87, 32)
        Me.tabClientes.Location = New System.Drawing.Point(12, 90)
        Me.tabClientes.Name = "tabClientes"
        Me.tabClientes.SelectedIndex = 0
        Me.tabClientes.Size = New System.Drawing.Size(712, 373)
        Me.tabClientes.TabIndex = 0
        '
        'pagGeneral
        '
        Me.pagGeneral.Controls.Add(Me.txtPagWeb)
        Me.pagGeneral.Controls.Add(Me.txtCorreo)
        Me.pagGeneral.Controls.Add(Me.txtFax)
        Me.pagGeneral.Controls.Add(Me.txtTel)
        Me.pagGeneral.Controls.Add(Me.txtNombre)
        Me.pagGeneral.Controls.Add(Me.CiLabel5)
        Me.pagGeneral.Controls.Add(Me.CiLabel4)
        Me.pagGeneral.Controls.Add(Me.CiLabel3)
        Me.pagGeneral.Controls.Add(Me.CiLabel2)
        Me.pagGeneral.Controls.Add(Me.CiLabel1)
        Me.pagGeneral.ImageKey = "General"
        Me.pagGeneral.Location = New System.Drawing.Point(4, 36)
        Me.pagGeneral.Name = "pagGeneral"
        Me.pagGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.pagGeneral.Size = New System.Drawing.Size(704, 333)
        Me.pagGeneral.TabIndex = 0
        Me.pagGeneral.Text = "General"
        Me.pagGeneral.UseVisualStyleBackColor = True
        '
        'txtPagWeb
        '
        Me.txtPagWeb.BackColor = System.Drawing.SystemColors.Window
        Me.txtPagWeb.CharacterCasing = Azteca.Windows.Controls.CaseType.Lower
        Me.txtPagWeb.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtPagWeb.Location = New System.Drawing.Point(112, 96)
        Me.txtPagWeb.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPagWeb.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPagWeb.Name = "txtPagWeb"
        Me.txtPagWeb.Size = New System.Drawing.Size(162, 20)
        Me.txtPagWeb.TabIndex = 9
        '
        'txtCorreo
        '
        Me.txtCorreo.BackColor = System.Drawing.SystemColors.Window
        Me.txtCorreo.CharacterCasing = Azteca.Windows.Controls.CaseType.Lower
        Me.txtCorreo.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCorreo.Location = New System.Drawing.Point(112, 70)
        Me.txtCorreo.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCorreo.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.RegularExpression = resources.GetString("txtCorreo.RegularExpression")
        Me.txtCorreo.Size = New System.Drawing.Size(162, 20)
        Me.txtCorreo.TabIndex = 7
        Me.txtCorreo.UIName = "Correo Electrónico"
        '
        'txtFax
        '
        Me.txtFax.BackColor = System.Drawing.SystemColors.Window
        Me.txtFax.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtFax.Location = New System.Drawing.Point(313, 41)
        Me.txtFax.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFax.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(162, 20)
        Me.txtFax.TabIndex = 5
        '
        'txtTel
        '
        Me.txtTel.BackColor = System.Drawing.SystemColors.Window
        Me.txtTel.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTel.Location = New System.Drawing.Point(112, 41)
        Me.txtTel.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTel.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(162, 20)
        Me.txtTel.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(112, 15)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(363, 20)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.UIName = "Nombre"
        '
        'CiLabel5
        '
        Me.CiLabel5.AutoSize = True
        Me.CiLabel5.Location = New System.Drawing.Point(37, 99)
        Me.CiLabel5.Name = "CiLabel5"
        Me.CiLabel5.Size = New System.Drawing.Size(69, 13)
        Me.CiLabel5.TabIndex = 8
        Me.CiLabel5.Text = "Página Web:"
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.Location = New System.Drawing.Point(37, 73)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(41, 13)
        Me.CiLabel4.TabIndex = 6
        Me.CiLabel4.Text = "Correo:"
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(280, 45)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(27, 13)
        Me.CiLabel3.TabIndex = 4
        Me.CiLabel3.Text = "Fax:"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(37, 45)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(57, 13)
        Me.CiLabel2.TabIndex = 2
        Me.CiLabel2.Text = "Telefonos:"
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(37, 18)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(47, 13)
        Me.CiLabel1.TabIndex = 0
        Me.CiLabel1.Text = "Nombre:"
        '
        'pagDomicilio
        '
        Me.pagDomicilio.Controls.Add(Me.txtPoblacion)
        Me.pagDomicilio.Controls.Add(Me.txtCP)
        Me.pagDomicilio.Controls.Add(Me.txtColonia)
        Me.pagDomicilio.Controls.Add(Me.txtNumInt)
        Me.pagDomicilio.Controls.Add(Me.txtNumExt)
        Me.pagDomicilio.Controls.Add(Me.txtCalle)
        Me.pagDomicilio.Controls.Add(Me.lblPoblacion)
        Me.pagDomicilio.Controls.Add(Me.lblCodigoPostal)
        Me.pagDomicilio.Controls.Add(Me.lblNumInt)
        Me.pagDomicilio.Controls.Add(Me.lblNumExt)
        Me.pagDomicilio.Controls.Add(Me.lblColonia)
        Me.pagDomicilio.Controls.Add(Me.lblCalle)
        Me.pagDomicilio.ImageKey = "Domicilio"
        Me.pagDomicilio.Location = New System.Drawing.Point(4, 36)
        Me.pagDomicilio.Name = "pagDomicilio"
        Me.pagDomicilio.Padding = New System.Windows.Forms.Padding(3)
        Me.pagDomicilio.Size = New System.Drawing.Size(704, 333)
        Me.pagDomicilio.TabIndex = 1
        Me.pagDomicilio.Text = "Domicilio"
        Me.pagDomicilio.UseVisualStyleBackColor = True
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
        Me.txtPoblacion.Location = New System.Drawing.Point(101, 125)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.Size = New System.Drawing.Size(300, 23)
        Me.txtPoblacion.TabIndex = 23
        Me.txtPoblacion.TextWidth = 70
        Me.txtPoblacion.UIName = "Población"
        '
        'txtCP
        '
        Me.txtCP.Digits = True
        Me.txtCP.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCP.Location = New System.Drawing.Point(101, 99)
        Me.txtCP.MaxLength = 5
        Me.txtCP.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCP.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(70, 20)
        Me.txtCP.TabIndex = 21
        Me.txtCP.UIName = Nothing
        '
        'txtColonia
        '
        Me.txtColonia.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtColonia.Location = New System.Drawing.Point(101, 73)
        Me.txtColonia.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColonia.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(300, 20)
        Me.txtColonia.TabIndex = 19
        Me.txtColonia.UIName = Nothing
        '
        'txtNumInt
        '
        Me.txtNumInt.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumInt.Location = New System.Drawing.Point(248, 47)
        Me.txtNumInt.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumInt.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumInt.Name = "txtNumInt"
        Me.txtNumInt.Size = New System.Drawing.Size(70, 20)
        Me.txtNumInt.TabIndex = 17
        Me.txtNumInt.UIName = Nothing
        '
        'txtNumExt
        '
        Me.txtNumExt.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumExt.Location = New System.Drawing.Point(101, 47)
        Me.txtNumExt.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExt.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExt.Name = "txtNumExt"
        Me.txtNumExt.Size = New System.Drawing.Size(70, 20)
        Me.txtNumExt.TabIndex = 15
        Me.txtNumExt.UIName = Nothing
        '
        'txtCalle
        '
        Me.txtCalle.BackColor = System.Drawing.SystemColors.Window
        Me.txtCalle.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCalle.Location = New System.Drawing.Point(101, 21)
        Me.txtCalle.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalle.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(300, 20)
        Me.txtCalle.TabIndex = 13
        Me.txtCalle.UIName = Nothing
        '
        'lblPoblacion
        '
        Me.lblPoblacion.AutoSize = True
        Me.lblPoblacion.Location = New System.Drawing.Point(20, 128)
        Me.lblPoblacion.Name = "lblPoblacion"
        Me.lblPoblacion.Size = New System.Drawing.Size(57, 13)
        Me.lblPoblacion.TabIndex = 22
        Me.lblPoblacion.Text = "Población:"
        '
        'lblCodigoPostal
        '
        Me.lblCodigoPostal.AutoSize = True
        Me.lblCodigoPostal.Location = New System.Drawing.Point(20, 102)
        Me.lblCodigoPostal.Name = "lblCodigoPostal"
        Me.lblCodigoPostal.Size = New System.Drawing.Size(75, 13)
        Me.lblCodigoPostal.TabIndex = 20
        Me.lblCodigoPostal.Text = "Código Postal:"
        '
        'lblNumInt
        '
        Me.lblNumInt.AutoSize = True
        Me.lblNumInt.Location = New System.Drawing.Point(180, 47)
        Me.lblNumInt.Name = "lblNumInt"
        Me.lblNumInt.Size = New System.Drawing.Size(62, 13)
        Me.lblNumInt.TabIndex = 16
        Me.lblNumInt.Text = "No. Interior:"
        '
        'lblNumExt
        '
        Me.lblNumExt.AutoSize = True
        Me.lblNumExt.Location = New System.Drawing.Point(20, 50)
        Me.lblNumExt.Name = "lblNumExt"
        Me.lblNumExt.Size = New System.Drawing.Size(65, 13)
        Me.lblNumExt.TabIndex = 14
        Me.lblNumExt.Text = "No. Exterior:"
        '
        'lblColonia
        '
        Me.lblColonia.AutoSize = True
        Me.lblColonia.Location = New System.Drawing.Point(20, 76)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(45, 13)
        Me.lblColonia.TabIndex = 18
        Me.lblColonia.Text = "Colonia:"
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Location = New System.Drawing.Point(20, 24)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(33, 13)
        Me.lblCalle.TabIndex = 12
        Me.lblCalle.Text = "Calle:"
        '
        'pagFiscales
        '
        Me.pagFiscales.Controls.Add(Me.grpIntegracionFact)
        Me.pagFiscales.Controls.Add(Me.grpDatosFiscales)
        Me.pagFiscales.Controls.Add(Me.chkFacturable)
        Me.pagFiscales.ImageKey = "Facturacion"
        Me.pagFiscales.Location = New System.Drawing.Point(4, 36)
        Me.pagFiscales.Name = "pagFiscales"
        Me.pagFiscales.Padding = New System.Windows.Forms.Padding(3)
        Me.pagFiscales.Size = New System.Drawing.Size(704, 333)
        Me.pagFiscales.TabIndex = 2
        Me.pagFiscales.Text = "Facturación"
        Me.pagFiscales.UseVisualStyleBackColor = True
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
        Me.grpIntegracionFact.Enabled = False
        Me.grpIntegracionFact.Location = New System.Drawing.Point(19, 220)
        Me.grpIntegracionFact.Name = "grpIntegracionFact"
        Me.grpIntegracionFact.Size = New System.Drawing.Size(632, 114)
        Me.grpIntegracionFact.TabIndex = 2
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
        Me.cboAddenda.Location = New System.Drawing.Point(111, 22)
        Me.cboAddenda.Name = "cboAddenda"
        Me.cboAddenda.NoneItemText = "[Ninguna]"
        Me.cboAddenda.Size = New System.Drawing.Size(206, 21)
        Me.cboAddenda.TabIndex = 1
        Me.cboAddenda.UIName = Nothing
        '
        'txtNumProveedor
        '
        Me.txtNumProveedor.Digits = True
        Me.txtNumProveedor.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumProveedor.Location = New System.Drawing.Point(111, 77)
        Me.txtNumProveedor.MaxLength = 13
        Me.txtNumProveedor.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumProveedor.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumProveedor.Name = "txtNumProveedor"
        Me.txtNumProveedor.Size = New System.Drawing.Size(132, 20)
        Me.txtNumProveedor.TabIndex = 7
        '
        'txtGLNTienda
        '
        Me.txtGLNTienda.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtGLNTienda.Location = New System.Drawing.Point(315, 51)
        Me.txtGLNTienda.MaxLength = 13
        Me.txtGLNTienda.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtGLNTienda.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtGLNTienda.Name = "txtGLNTienda"
        Me.txtGLNTienda.Size = New System.Drawing.Size(132, 20)
        Me.txtGLNTienda.TabIndex = 5
        '
        'txtGLN
        '
        Me.txtGLN.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtGLN.Location = New System.Drawing.Point(111, 51)
        Me.txtGLN.MaxLength = 13
        Me.txtGLN.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtGLN.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtGLN.Name = "txtGLN"
        Me.txtGLN.Size = New System.Drawing.Size(132, 20)
        Me.txtGLN.TabIndex = 3
        '
        'CiLabel22
        '
        Me.CiLabel22.AutoSize = True
        Me.CiLabel22.Location = New System.Drawing.Point(26, 80)
        Me.CiLabel22.Name = "CiLabel22"
        Me.CiLabel22.Size = New System.Drawing.Size(79, 13)
        Me.CiLabel22.TabIndex = 6
        Me.CiLabel22.Text = "No. Proveedor:"
        '
        'CiLabel21
        '
        Me.CiLabel21.AutoSize = True
        Me.CiLabel21.Location = New System.Drawing.Point(249, 54)
        Me.CiLabel21.Name = "CiLabel21"
        Me.CiLabel21.Size = New System.Drawing.Size(68, 13)
        Me.CiLabel21.TabIndex = 4
        Me.CiLabel21.Text = "GLN Tienda:"
        '
        'CiLabel20
        '
        Me.CiLabel20.AutoSize = True
        Me.CiLabel20.Location = New System.Drawing.Point(26, 54)
        Me.CiLabel20.Name = "CiLabel20"
        Me.CiLabel20.Size = New System.Drawing.Size(32, 13)
        Me.CiLabel20.TabIndex = 2
        Me.CiLabel20.Text = "GLN:"
        '
        'CiLabel19
        '
        Me.CiLabel19.AutoSize = True
        Me.CiLabel19.Location = New System.Drawing.Point(26, 25)
        Me.CiLabel19.Name = "CiLabel19"
        Me.CiLabel19.Size = New System.Drawing.Size(53, 13)
        Me.CiLabel19.TabIndex = 0
        Me.CiLabel19.Text = "Addenda:"
        '
        'grpDatosFiscales
        '
        Me.grpDatosFiscales.Controls.Add(Me.txtRazonSocial)
        Me.grpDatosFiscales.Controls.Add(Me.txtRFC)
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
        Me.grpDatosFiscales.Enabled = False
        Me.grpDatosFiscales.Location = New System.Drawing.Point(19, 29)
        Me.grpDatosFiscales.Name = "grpDatosFiscales"
        Me.grpDatosFiscales.Size = New System.Drawing.Size(632, 185)
        Me.grpDatosFiscales.TabIndex = 1
        Me.grpDatosFiscales.TabStop = False
        Me.grpDatosFiscales.Text = "Datos Fiscales"
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtRazonSocial.Location = New System.Drawing.Point(89, 45)
        Me.txtRazonSocial.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRazonSocial.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(367, 20)
        Me.txtRazonSocial.TabIndex = 3
        '
        'txtRFC
        '
        Me.txtRFC.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtRFC.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtRFC.Location = New System.Drawing.Point(89, 19)
        Me.txtRFC.MaxLength = 13
        Me.txtRFC.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRFC.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.RegularExpression = resources.GetString("txtRFC.RegularExpression")
        Me.txtRFC.Size = New System.Drawing.Size(141, 20)
        Me.txtRFC.TabIndex = 1
        '
        'CiLabel11
        '
        Me.CiLabel11.AutoSize = True
        Me.CiLabel11.Location = New System.Drawing.Point(10, 48)
        Me.CiLabel11.Name = "CiLabel11"
        Me.CiLabel11.Size = New System.Drawing.Size(73, 13)
        Me.CiLabel11.TabIndex = 2
        Me.CiLabel11.Text = "Razón Social:"
        '
        'CiLabel12
        '
        Me.CiLabel12.AutoSize = True
        Me.CiLabel12.Location = New System.Drawing.Point(10, 19)
        Me.CiLabel12.Name = "CiLabel12"
        Me.CiLabel12.Size = New System.Drawing.Size(31, 13)
        Me.CiLabel12.TabIndex = 0
        Me.CiLabel12.Text = "RFC:"
        '
        'txtCalleFis
        '
        Me.txtCalleFis.BackColor = System.Drawing.SystemColors.Window
        Me.txtCalleFis.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCalleFis.Location = New System.Drawing.Point(89, 71)
        Me.txtCalleFis.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalleFis.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalleFis.Name = "txtCalleFis"
        Me.txtCalleFis.Size = New System.Drawing.Size(367, 20)
        Me.txtCalleFis.TabIndex = 5
        Me.txtCalleFis.UIName = Nothing
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
        Me.txtPoblacionFis.Location = New System.Drawing.Point(89, 149)
        Me.txtPoblacionFis.Name = "txtPoblacionFis"
        Me.txtPoblacionFis.Size = New System.Drawing.Size(367, 23)
        Me.txtPoblacionFis.TabIndex = 15
        Me.txtPoblacionFis.TextWidth = 70
        Me.txtPoblacionFis.UIName = Nothing
        '
        'CiLabel13
        '
        Me.CiLabel13.AutoSize = True
        Me.CiLabel13.Location = New System.Drawing.Point(10, 74)
        Me.CiLabel13.Name = "CiLabel13"
        Me.CiLabel13.Size = New System.Drawing.Size(33, 13)
        Me.CiLabel13.TabIndex = 4
        Me.CiLabel13.Text = "Calle:"
        '
        'txtCPFis
        '
        Me.txtCPFis.Digits = True
        Me.txtCPFis.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCPFis.Location = New System.Drawing.Point(393, 123)
        Me.txtCPFis.MaxLength = 5
        Me.txtCPFis.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCPFis.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCPFis.Name = "txtCPFis"
        Me.txtCPFis.Size = New System.Drawing.Size(63, 20)
        Me.txtCPFis.TabIndex = 13
        Me.txtCPFis.UIName = Nothing
        '
        'CiLabel14
        '
        Me.CiLabel14.AutoSize = True
        Me.CiLabel14.Location = New System.Drawing.Point(10, 123)
        Me.CiLabel14.Name = "CiLabel14"
        Me.CiLabel14.Size = New System.Drawing.Size(45, 13)
        Me.CiLabel14.TabIndex = 10
        Me.CiLabel14.Text = "Colonia:"
        '
        'txtColoniaFis
        '
        Me.txtColoniaFis.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtColoniaFis.Location = New System.Drawing.Point(89, 123)
        Me.txtColoniaFis.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColoniaFis.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColoniaFis.Name = "txtColoniaFis"
        Me.txtColoniaFis.Size = New System.Drawing.Size(217, 20)
        Me.txtColoniaFis.TabIndex = 11
        Me.txtColoniaFis.UIName = Nothing
        '
        'CiLabel15
        '
        Me.CiLabel15.AutoSize = True
        Me.CiLabel15.Location = New System.Drawing.Point(10, 97)
        Me.CiLabel15.Name = "CiLabel15"
        Me.CiLabel15.Size = New System.Drawing.Size(65, 13)
        Me.CiLabel15.TabIndex = 6
        Me.CiLabel15.Text = "No. Exterior:"
        '
        'txtNumIntFis
        '
        Me.txtNumIntFis.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumIntFis.Location = New System.Drawing.Point(236, 97)
        Me.txtNumIntFis.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumIntFis.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumIntFis.Name = "txtNumIntFis"
        Me.txtNumIntFis.Size = New System.Drawing.Size(70, 20)
        Me.txtNumIntFis.TabIndex = 9
        Me.txtNumIntFis.UIName = Nothing
        '
        'CiLabel16
        '
        Me.CiLabel16.AutoSize = True
        Me.CiLabel16.Location = New System.Drawing.Point(168, 97)
        Me.CiLabel16.Name = "CiLabel16"
        Me.CiLabel16.Size = New System.Drawing.Size(62, 13)
        Me.CiLabel16.TabIndex = 8
        Me.CiLabel16.Text = "No. Interior:"
        '
        'txtNumExtFis
        '
        Me.txtNumExtFis.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumExtFis.Location = New System.Drawing.Point(89, 97)
        Me.txtNumExtFis.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExtFis.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExtFis.Name = "txtNumExtFis"
        Me.txtNumExtFis.Size = New System.Drawing.Size(70, 20)
        Me.txtNumExtFis.TabIndex = 7
        Me.txtNumExtFis.UIName = Nothing
        '
        'CiLabel17
        '
        Me.CiLabel17.AutoSize = True
        Me.CiLabel17.Location = New System.Drawing.Point(312, 123)
        Me.CiLabel17.Name = "CiLabel17"
        Me.CiLabel17.Size = New System.Drawing.Size(75, 13)
        Me.CiLabel17.TabIndex = 12
        Me.CiLabel17.Text = "Código Postal:"
        '
        'CiLabel18
        '
        Me.CiLabel18.AutoSize = True
        Me.CiLabel18.Location = New System.Drawing.Point(10, 151)
        Me.CiLabel18.Name = "CiLabel18"
        Me.CiLabel18.Size = New System.Drawing.Size(57, 13)
        Me.CiLabel18.TabIndex = 14
        Me.CiLabel18.Text = "Población:"
        '
        'chkFacturable
        '
        Me.chkFacturable.AutoSize = True
        Me.chkFacturable.Location = New System.Drawing.Point(19, 6)
        Me.chkFacturable.Name = "chkFacturable"
        Me.chkFacturable.Size = New System.Drawing.Size(96, 17)
        Me.chkFacturable.TabIndex = 0
        Me.chkFacturable.Text = "Solicita factura"
        Me.chkFacturable.UseVisualStyleBackColor = True
        '
        'pagVentas
        '
        Me.pagVentas.Controls.Add(Me.CiGroupBox2)
        Me.pagVentas.Controls.Add(Me.selListaPrecios)
        Me.pagVentas.Controls.Add(Me.selGrupoDescuentos)
        Me.pagVentas.Controls.Add(Me.CiGroupBox1)
        Me.pagVentas.Controls.Add(Me.CiLabel8)
        Me.pagVentas.Controls.Add(Me.CiLabel7)
        Me.pagVentas.Controls.Add(Me.CiLabel6)
        Me.pagVentas.ImageKey = "Ventas"
        Me.pagVentas.Location = New System.Drawing.Point(4, 36)
        Me.pagVentas.Name = "pagVentas"
        Me.pagVentas.Size = New System.Drawing.Size(704, 333)
        Me.pagVentas.TabIndex = 4
        Me.pagVentas.Text = "Ventas"
        Me.pagVentas.UseVisualStyleBackColor = True
        '
        'CiGroupBox2
        '
        Me.CiGroupBox2.Controls.Add(Me.txtCuentaPago)
        Me.CiGroupBox2.Controls.Add(Me.cboMetodoPago)
        Me.CiGroupBox2.Controls.Add(Me.CiLabel26)
        Me.CiGroupBox2.Controls.Add(Me.CiLabel25)
        Me.CiGroupBox2.Location = New System.Drawing.Point(303, 116)
        Me.CiGroupBox2.Name = "CiGroupBox2"
        Me.CiGroupBox2.Size = New System.Drawing.Size(330, 171)
        Me.CiGroupBox2.TabIndex = 7
        Me.CiGroupBox2.TabStop = False
        '
        'txtCuentaPago
        '
        Me.txtCuentaPago.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCuentaPago.Location = New System.Drawing.Point(121, 54)
        Me.txtCuentaPago.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCuentaPago.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCuentaPago.Name = "txtCuentaPago"
        Me.txtCuentaPago.Size = New System.Drawing.Size(193, 20)
        Me.txtCuentaPago.TabIndex = 9
        '
        'cboMetodoPago
        '
        Me.cboMetodoPago.AddNoneItem = True
        Me.cboMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMetodoPago.FormattingEnabled = True
        Me.cboMetodoPago.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboMetodoPago.ItemsTable = Nothing
        Me.cboMetodoPago.Location = New System.Drawing.Point(121, 27)
        Me.cboMetodoPago.Name = "cboMetodoPago"
        Me.cboMetodoPago.NoneItemText = "[NO IDENTIFICADO]"
        Me.cboMetodoPago.Size = New System.Drawing.Size(193, 21)
        Me.cboMetodoPago.TabIndex = 8
        Me.cboMetodoPago.UIName = Nothing
        '
        'CiLabel26
        '
        Me.CiLabel26.AutoSize = True
        Me.CiLabel26.Location = New System.Drawing.Point(17, 57)
        Me.CiLabel26.Name = "CiLabel26"
        Me.CiLabel26.Size = New System.Drawing.Size(87, 13)
        Me.CiLabel26.TabIndex = 7
        Me.CiLabel26.Text = "Cuenta de Pago:"
        '
        'CiLabel25
        '
        Me.CiLabel25.AutoSize = True
        Me.CiLabel25.Location = New System.Drawing.Point(17, 32)
        Me.CiLabel25.Name = "CiLabel25"
        Me.CiLabel25.Size = New System.Drawing.Size(89, 13)
        Me.CiLabel25.TabIndex = 6
        Me.CiLabel25.Text = "Método de Pago:"
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
        Me.selListaPrecios.Location = New System.Drawing.Point(139, 22)
        Me.selListaPrecios.Name = "selListaPrecios"
        Me.selListaPrecios.Size = New System.Drawing.Size(331, 23)
        Me.selListaPrecios.TabIndex = 5
        '
        'selGrupoDescuentos
        '
        Me.selGrupoDescuentos.AnySite = False
        Me.selGrupoDescuentos.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selGrupoDescuentos.EditorAssembly = "Azteca.VentasWin"
        Me.selGrupoDescuentos.EditorClass = "Azteca.Windows.Ventas.GrupoDescuentosForm"
        Me.selGrupoDescuentos.EditorTitle = "Editar datos de Grupo de Descuentos..."
        Me.selGrupoDescuentos.Key = 0
        Me.selGrupoDescuentos.Linked = False
        Me.selGrupoDescuentos.Location = New System.Drawing.Point(139, 51)
        Me.selGrupoDescuentos.Name = "selGrupoDescuentos"
        Me.selGrupoDescuentos.Size = New System.Drawing.Size(331, 23)
        Me.selGrupoDescuentos.TabIndex = 4
        '
        'CiGroupBox1
        '
        Me.CiGroupBox1.Controls.Add(Me.rdbCredito)
        Me.CiGroupBox1.Controls.Add(Me.rdbContado)
        Me.CiGroupBox1.Controls.Add(Me.txtSaldoCredito)
        Me.CiGroupBox1.Controls.Add(Me.txtDiasCredito)
        Me.CiGroupBox1.Controls.Add(Me.txtLimiteCredito)
        Me.CiGroupBox1.Controls.Add(Me.CiLabel23)
        Me.CiGroupBox1.Controls.Add(Me.CiLabel9)
        Me.CiGroupBox1.Controls.Add(Me.CiLabel10)
        Me.CiGroupBox1.Location = New System.Drawing.Point(22, 116)
        Me.CiGroupBox1.Name = "CiGroupBox1"
        Me.CiGroupBox1.Size = New System.Drawing.Size(275, 171)
        Me.CiGroupBox1.TabIndex = 3
        Me.CiGroupBox1.TabStop = False
        Me.CiGroupBox1.Text = "Condiciones de Pago"
        '
        'rdbCredito
        '
        Me.rdbCredito.AutoSize = True
        Me.rdbCredito.Location = New System.Drawing.Point(20, 51)
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
        Me.rdbContado.Location = New System.Drawing.Point(20, 28)
        Me.rdbContado.Name = "rdbContado"
        Me.rdbContado.Size = New System.Drawing.Size(65, 17)
        Me.rdbContado.TabIndex = 0
        Me.rdbContado.TabStop = True
        Me.rdbContado.Text = "Contado"
        Me.rdbContado.UseVisualStyleBackColor = True
        '
        'txtSaldoCredito
        '
        Me.txtSaldoCredito.AutoLock = False
        Me.txtSaldoCredito.Digits = True
        Me.txtSaldoCredito.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtSaldoCredito.Format = "C"
        Me.txtSaldoCredito.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtSaldoCredito.Location = New System.Drawing.Point(154, 133)
        Me.txtSaldoCredito.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSaldoCredito.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSaldoCredito.Name = "txtSaldoCredito"
        Me.txtSaldoCredito.ReadOnly = True
        Me.txtSaldoCredito.Size = New System.Drawing.Size(98, 20)
        Me.txtSaldoCredito.TabIndex = 7
        Me.txtSaldoCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiasCredito
        '
        Me.txtDiasCredito.Digits = True
        Me.txtDiasCredito.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtDiasCredito.Format = "N0"
        Me.txtDiasCredito.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtDiasCredito.Location = New System.Drawing.Point(154, 107)
        Me.txtDiasCredito.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDiasCredito.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDiasCredito.Name = "txtDiasCredito"
        Me.txtDiasCredito.Size = New System.Drawing.Size(98, 20)
        Me.txtDiasCredito.TabIndex = 5
        Me.txtDiasCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLimiteCredito
        '
        Me.txtLimiteCredito.Digits = True
        Me.txtLimiteCredito.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtLimiteCredito.Format = "C"
        Me.txtLimiteCredito.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtLimiteCredito.Location = New System.Drawing.Point(154, 81)
        Me.txtLimiteCredito.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLimiteCredito.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLimiteCredito.Name = "txtLimiteCredito"
        Me.txtLimiteCredito.Size = New System.Drawing.Size(98, 20)
        Me.txtLimiteCredito.TabIndex = 3
        Me.txtLimiteCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CiLabel23
        '
        Me.CiLabel23.AutoSize = True
        Me.CiLabel23.Location = New System.Drawing.Point(58, 136)
        Me.CiLabel23.Name = "CiLabel23"
        Me.CiLabel23.Size = New System.Drawing.Size(88, 13)
        Me.CiLabel23.TabIndex = 6
        Me.CiLabel23.Text = "Saldo de Crédito:"
        '
        'CiLabel9
        '
        Me.CiLabel9.AutoSize = True
        Me.CiLabel9.Location = New System.Drawing.Point(58, 84)
        Me.CiLabel9.Name = "CiLabel9"
        Me.CiLabel9.Size = New System.Drawing.Size(90, 13)
        Me.CiLabel9.TabIndex = 2
        Me.CiLabel9.Text = "Límite de Crédito:"
        '
        'CiLabel10
        '
        Me.CiLabel10.AutoSize = True
        Me.CiLabel10.Location = New System.Drawing.Point(58, 110)
        Me.CiLabel10.Name = "CiLabel10"
        Me.CiLabel10.Size = New System.Drawing.Size(82, 13)
        Me.CiLabel10.TabIndex = 4
        Me.CiLabel10.Text = "Dias de Crédito:"
        '
        'CiLabel8
        '
        Me.CiLabel8.AutoSize = True
        Me.CiLabel8.Location = New System.Drawing.Point(19, 80)
        Me.CiLabel8.Name = "CiLabel8"
        Me.CiLabel8.Size = New System.Drawing.Size(98, 13)
        Me.CiLabel8.TabIndex = 2
        Me.CiLabel8.Text = "Gama de Artículos:"
        '
        'CiLabel7
        '
        Me.CiLabel7.AutoSize = True
        Me.CiLabel7.Location = New System.Drawing.Point(19, 53)
        Me.CiLabel7.Name = "CiLabel7"
        Me.CiLabel7.Size = New System.Drawing.Size(114, 13)
        Me.CiLabel7.TabIndex = 1
        Me.CiLabel7.Text = "Grupo de Descuentos:"
        '
        'CiLabel6
        '
        Me.CiLabel6.AutoSize = True
        Me.CiLabel6.Location = New System.Drawing.Point(19, 25)
        Me.CiLabel6.Name = "CiLabel6"
        Me.CiLabel6.Size = New System.Drawing.Size(70, 13)
        Me.CiLabel6.TabIndex = 0
        Me.CiLabel6.Text = "Lista Precios:"
        '
        'pagContactos
        '
        Me.pagContactos.Controls.Add(Me.tlbContactos)
        Me.pagContactos.Controls.Add(Me.grdContactos)
        Me.pagContactos.ImageKey = "Contactos"
        Me.pagContactos.Location = New System.Drawing.Point(4, 36)
        Me.pagContactos.Name = "pagContactos"
        Me.pagContactos.Padding = New System.Windows.Forms.Padding(3)
        Me.pagContactos.Size = New System.Drawing.Size(704, 333)
        Me.pagContactos.TabIndex = 3
        Me.pagContactos.Text = "Contactos"
        Me.pagContactos.UseVisualStyleBackColor = True
        '
        'tlbContactos
        '
        Me.tlbContactos.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tlbContactos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoContacto})
        Me.tlbContactos.Location = New System.Drawing.Point(3, 3)
        Me.tlbContactos.Name = "tlbContactos"
        Me.tlbContactos.Size = New System.Drawing.Size(698, 39)
        Me.tlbContactos.TabIndex = 1
        Me.tlbContactos.Text = "tlbContactos"
        '
        'btnNuevoContacto
        '
        Me.btnNuevoContacto.Image = Global.Azteca.Windows.Ventas.My.Resources.Resources.ContactAdd32
        Me.btnNuevoContacto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevoContacto.Name = "btnNuevoContacto"
        Me.btnNuevoContacto.Size = New System.Drawing.Size(130, 36)
        Me.btnNuevoContacto.Text = "Nuevo Contacto"
        '
        'grdContactos
        '
        Me.grdContactos.AlternatingRows = True
        Me.grdContactos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdContactos.DataSource = Me.bsContactos
        Me.grdContactos.FilterBar = True
        Me.grdContactos.IDCatalogField = "IdPersona"
        Me.grdContactos.Images.Add(CType(resources.GetObject("grdContactos.Images"), System.Drawing.Image))
        Me.grdContactos.Location = New System.Drawing.Point(6, 45)
        Me.grdContactos.Name = "grdContactos"
        Me.grdContactos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdContactos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdContactos.PreviewInfo.ZoomFactor = 75.0R
        Me.grdContactos.PrintInfo.PageSettings = CType(resources.GetObject("grdContactos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdContactos.Size = New System.Drawing.Size(692, 294)
        Me.grdContactos.TabIndex = 0
        Me.grdContactos.PropBag = resources.GetString("grdContactos.PropBag")
        '
        'pagClasificaciones
        '
        Me.pagClasificaciones.Controls.Add(Me.cboClasificaciones)
        Me.pagClasificaciones.Controls.Add(Me.grdClasificaciones)
        Me.pagClasificaciones.ImageIndex = 6
        Me.pagClasificaciones.Location = New System.Drawing.Point(4, 36)
        Me.pagClasificaciones.Name = "pagClasificaciones"
        Me.pagClasificaciones.Size = New System.Drawing.Size(704, 333)
        Me.pagClasificaciones.TabIndex = 6
        Me.pagClasificaciones.Text = "Clasificaciones"
        Me.pagClasificaciones.UseVisualStyleBackColor = True
        '
        'cboClasificaciones
        '
        Me.cboClasificaciones.AllowColMove = True
        Me.cboClasificaciones.AllowColSelect = True
        Me.cboClasificaciones.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboClasificaciones.AlternatingRows = False
        Me.cboClasificaciones.CaptionStyle = Style1
        Me.cboClasificaciones.ColumnCaptionHeight = 17
        Me.cboClasificaciones.ColumnFooterHeight = 17
        Me.cboClasificaciones.DataSource = Me.bsClasificaciones
        Me.cboClasificaciones.DisplayMember = "Nombre"
        Me.cboClasificaciones.EvenRowStyle = Style2
        Me.cboClasificaciones.ExtendRightColumn = True
        Me.cboClasificaciones.FetchRowStyles = False
        Me.cboClasificaciones.FooterStyle = Style3
        Me.cboClasificaciones.HeadingStyle = Style4
        Me.cboClasificaciones.HighLightRowStyle = Style5
        Me.cboClasificaciones.Images.Add(CType(resources.GetObject("cboClasificaciones.Images"), System.Drawing.Image))
        Me.cboClasificaciones.Location = New System.Drawing.Point(223, 87)
        Me.cboClasificaciones.Name = "cboClasificaciones"
        Me.cboClasificaciones.OddRowStyle = Style6
        Me.cboClasificaciones.RecordSelectorStyle = Style7
        Me.cboClasificaciones.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboClasificaciones.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboClasificaciones.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboClasificaciones.ScrollTips = False
        Me.cboClasificaciones.Size = New System.Drawing.Size(301, 199)
        Me.cboClasificaciones.Style = Style8
        Me.cboClasificaciones.TabIndex = 3
        Me.cboClasificaciones.TabStop = False
        Me.cboClasificaciones.Text = "C1TrueDBDropdown1"
        Me.cboClasificaciones.ValueMember = "IdClasificacion"
        Me.cboClasificaciones.ValueTranslate = True
        Me.cboClasificaciones.Visible = False
        Me.cboClasificaciones.PropBag = resources.GetString("cboClasificaciones.PropBag")
        '
        'grdClasificaciones
        '
        Me.grdClasificaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdClasificaciones.DataSource = Me.bsGruposClasif
        Me.grdClasificaciones.ExtendRightColumn = True
        Me.grdClasificaciones.FetchRowStyles = True
        Me.grdClasificaciones.Images.Add(CType(resources.GetObject("grdClasificaciones.Images"), System.Drawing.Image))
        Me.grdClasificaciones.Location = New System.Drawing.Point(42, 13)
        Me.grdClasificaciones.Name = "grdClasificaciones"
        Me.grdClasificaciones.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdClasificaciones.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdClasificaciones.PreviewInfo.ZoomFactor = 75.0R
        Me.grdClasificaciones.PrintInfo.PageSettings = CType(resources.GetObject("grdClasificaciones.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdClasificaciones.Size = New System.Drawing.Size(612, 317)
        Me.grdClasificaciones.TabIndex = 2
        Me.grdClasificaciones.Text = "AzTrueDBGrid1"
        Me.grdClasificaciones.PropBag = resources.GetString("grdClasificaciones.PropBag")
        '
        'pagContabilidad
        '
        Me.pagContabilidad.Controls.Add(Me.txtCuenta)
        Me.pagContabilidad.Controls.Add(Me.CiLabel24)
        Me.pagContabilidad.ImageKey = "Contabilidad"
        Me.pagContabilidad.Location = New System.Drawing.Point(4, 36)
        Me.pagContabilidad.Name = "pagContabilidad"
        Me.pagContabilidad.Padding = New System.Windows.Forms.Padding(3)
        Me.pagContabilidad.Size = New System.Drawing.Size(704, 333)
        Me.pagContabilidad.TabIndex = 5
        Me.pagContabilidad.Text = "Contabilidad"
        Me.pagContabilidad.UseVisualStyleBackColor = True
        '
        'txtCuenta
        '
        Me.txtCuenta.AnySite = False
        Me.txtCuenta.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtCuenta.EditorAssembly = "Azteca.ContabilidadWin"
        Me.txtCuenta.EditorClass = "Azteca.Windows.Contabilidad.CuentaForm"
        Me.txtCuenta.EditorTitle = "Editar Cuenta..."
        Me.txtCuenta.Key = 0
        Me.txtCuenta.Linked = False
        Me.txtCuenta.Location = New System.Drawing.Point(80, 27)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(380, 23)
        Me.txtCuenta.TabIndex = 1
        Me.txtCuenta.TextWidth = 100
        '
        'CiLabel24
        '
        Me.CiLabel24.AutoSize = True
        Me.CiLabel24.Location = New System.Drawing.Point(30, 31)
        Me.CiLabel24.Name = "CiLabel24"
        Me.CiLabel24.Size = New System.Drawing.Size(44, 13)
        Me.CiLabel24.TabIndex = 0
        Me.CiLabel24.Text = "Cuenta:"
        '
        'imlClientes
        '
        Me.imlClientes.ImageStream = CType(resources.GetObject("imlClientes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlClientes.TransparentColor = System.Drawing.Color.Transparent
        Me.imlClientes.Images.SetKeyName(0, "General")
        Me.imlClientes.Images.SetKeyName(1, "Domicilio")
        Me.imlClientes.Images.SetKeyName(2, "Facturacion")
        Me.imlClientes.Images.SetKeyName(3, "Ventas")
        Me.imlClientes.Images.SetKeyName(4, "Contactos")
        Me.imlClientes.Images.SetKeyName(5, "Contabilidad")
        Me.imlClientes.Images.SetKeyName(6, "Clasificaciones.png")
        '
        'ClientesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 497)
        Me.Controls.Add(Me.tabClientes)
        Me.KeyMode = Azteca.Windows.Forms.BusinessForms.CatalogForm.UserKeyMode.UserDefined
        Me.Name = "ClientesForm"
        Me.Text = "ClientesForm"
        Me.Controls.SetChildIndex(Me.tabClientes, 0)
        Me.tabClientes.ResumeLayout(False)
        Me.pagGeneral.ResumeLayout(False)
        Me.pagGeneral.PerformLayout()
        Me.pagDomicilio.ResumeLayout(False)
        Me.pagDomicilio.PerformLayout()
        Me.pagFiscales.ResumeLayout(False)
        Me.pagFiscales.PerformLayout()
        Me.grpIntegracionFact.ResumeLayout(False)
        Me.grpIntegracionFact.PerformLayout()
        Me.grpDatosFiscales.ResumeLayout(False)
        Me.grpDatosFiscales.PerformLayout()
        Me.pagVentas.ResumeLayout(False)
        Me.pagVentas.PerformLayout()
        Me.CiGroupBox2.ResumeLayout(False)
        Me.CiGroupBox2.PerformLayout()
        Me.CiGroupBox1.ResumeLayout(False)
        Me.CiGroupBox1.PerformLayout()
        Me.pagContactos.ResumeLayout(False)
        Me.pagContactos.PerformLayout()
        Me.tlbContactos.ResumeLayout(False)
        Me.tlbContactos.PerformLayout()
        CType(Me.grdContactos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsContactos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagClasificaciones.ResumeLayout(False)
        CType(Me.cboClasificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsClasificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdClasificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsGruposClasif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagContabilidad.ResumeLayout(False)
        Me.pagContabilidad.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New Azteca.Business.Ventas.ClienteFacade
    End Sub
    Friend WithEvents tabClientes As Azteca.Windows.Controls.CITab
    Friend WithEvents pagGeneral As System.Windows.Forms.TabPage
    Friend WithEvents pagDomicilio As System.Windows.Forms.TabPage
    Friend WithEvents pagFiscales As System.Windows.Forms.TabPage
    Friend WithEvents pagVentas As System.Windows.Forms.TabPage
    Friend WithEvents pagContactos As System.Windows.Forms.TabPage
    Friend WithEvents imlClientes As System.Windows.Forms.ImageList
    Friend WithEvents CiLabel5 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents chkFacturable As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents CiLabel10 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel9 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel8 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel7 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel6 As Azteca.Windows.Controls.CILabel
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
    Friend WithEvents txtPoblacion As Azteca.Windows.Controls.General.PoblacionSelector
    Friend WithEvents txtCP As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtColonia As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtNumInt As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtNumExt As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtCalle As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblPoblacion As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCodigoPostal As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblNumInt As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblNumExt As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblColonia As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCalle As Azteca.Windows.Controls.CILabel
    Friend WithEvents grpIntegracionFact As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents CiLabel22 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel21 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel20 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel19 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiGroupBox1 As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents CiLabel23 As Azteca.Windows.Controls.CILabel
    Friend WithEvents grdContactos As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents bsContactos As System.Windows.Forms.BindingSource
    Friend WithEvents txtPagWeb As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtCorreo As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtFax As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtTel As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtNumProveedor As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtGLNTienda As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtGLN As Azteca.Windows.Controls.CITextBox
    Friend WithEvents cboAddenda As Azteca.Windows.Contabilidad.AddendasCombobox
    Friend WithEvents txtSaldoCredito As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtDiasCredito As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtLimiteCredito As Azteca.Windows.Controls.CITextBox
    Friend WithEvents tlbContactos As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnNuevoContacto As System.Windows.Forms.ToolStripButton
    Friend WithEvents rdbCredito As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents rdbContado As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents pagContabilidad As System.Windows.Forms.TabPage
    Friend WithEvents txtCuenta As Azteca.Windows.Contabilidad.CuentaSelector
    Friend WithEvents CiLabel24 As Azteca.Windows.Controls.CILabel
    Friend WithEvents selListaPrecios As Azteca.Windows.Ventas.ListaPreciosSelector
    Friend WithEvents selGrupoDescuentos As Azteca.Windows.Ventas.GrupoDescuentosSelector
    Friend WithEvents pagClasificaciones As System.Windows.Forms.TabPage
    Friend WithEvents bsGruposClasif As System.Windows.Forms.BindingSource
    Friend WithEvents bsClasificaciones As System.Windows.Forms.BindingSource
    Friend WithEvents cboClasificaciones As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents grdClasificaciones As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents CiGroupBox2 As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents txtCuentaPago As Azteca.Windows.Controls.CITextBox
    Friend WithEvents cboMetodoPago As Azteca.Windows.Ventas.MetodoPagoComboBox
    Friend WithEvents CiLabel26 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel25 As Azteca.Windows.Controls.CILabel
End Class
