<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProveedoresForm
    Inherits Azteca.Windows.Forms.BusinessForms.CatalogForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProveedoresForm))
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.nudDiasEntrega = New Azteca.Windows.Controls.CINumericUpDown()
        Me.txtPassword = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel14 = New Azteca.Windows.Controls.CILabel()
        Me.txtCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.CiLabel13 = New Azteca.Windows.Controls.CILabel()
        Me.txtFax = New Azteca.Windows.Controls.CITextBox()
        Me.lblFax = New Azteca.Windows.Controls.CILabel()
        Me.txtURL = New Azteca.Windows.Controls.CITextBox()
        Me.lblURL = New Azteca.Windows.Controls.CILabel()
        Me.txtCorreo = New Azteca.Windows.Controls.CITextBox()
        Me.txtTelefono = New Azteca.Windows.Controls.CITextBox()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.lblCorreo = New Azteca.Windows.Controls.CILabel()
        Me.lblTelOficina = New Azteca.Windows.Controls.CILabel()
        Me.lblNombre = New Azteca.Windows.Controls.CILabel()
        Me.txtPoblacion = New Azteca.Windows.Controls.General.PoblacionSelector()
        Me.lblEstadoInf = New Azteca.Windows.Controls.CILabel()
        Me.lblEstado = New Azteca.Windows.Controls.CILabel()
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
        Me.chkFactElectronica = New Azteca.Windows.Controls.CICheckBox()
        Me.txtRazonSocial = New Azteca.Windows.Controls.CITextBox()
        Me.lblRazonSocial = New Azteca.Windows.Controls.CILabel()
        Me.txtPoblacionFIS = New Azteca.Windows.Controls.General.PoblacionSelector()
        Me.CiLabel5 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel6 = New Azteca.Windows.Controls.CILabel()
        Me.txtCPFis = New Azteca.Windows.Controls.CITextBox()
        Me.txtColoniaFIS = New Azteca.Windows.Controls.CITextBox()
        Me.txtNumIntFIS = New Azteca.Windows.Controls.CITextBox()
        Me.txtNumExtFIS = New Azteca.Windows.Controls.CITextBox()
        Me.txtCalleFIS = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel7 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel8 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel9 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel10 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel11 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel12 = New Azteca.Windows.Controls.CILabel()
        Me.txtRFC = New Azteca.Windows.Controls.CITextBox()
        Me.lblRFC = New Azteca.Windows.Controls.CILabel()
        Me.grpCondicionesPago = New Azteca.Windows.Controls.CIGroupBox()
        Me.rdbAdelantado = New Azteca.Windows.Controls.CIRadioButton()
        Me.pnlCredito = New Azteca.Windows.Controls.CIPanel()
        Me.txtLimiteCredito = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.nudDiasCredito = New Azteca.Windows.Controls.CINumericUpDown()
        Me.txtSaldo = New Azteca.Windows.Controls.CITextBox()
        Me.rdbCredito = New Azteca.Windows.Controls.CIRadioButton()
        Me.rdbContado = New Azteca.Windows.Controls.CIRadioButton()
        Me.grpPagosElectronicos = New Azteca.Windows.Controls.CIGroupBox()
        Me.cboBanco = New Azteca.Windows.Tesoreria.BancosComboBox()
        Me.lblBanco = New Azteca.Windows.Controls.CILabel()
        Me.txtCLABE = New Azteca.Windows.Controls.CITextBox()
        Me.lblCLABE = New Azteca.Windows.Controls.CILabel()
        Me.chkLeyenda = New Azteca.Windows.Controls.CICheckBox()
        Me.grdContactos = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsContactos = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdZonas = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsZonas = New System.Windows.Forms.BindingSource(Me.components)
        Me.tlbZonas = New Azteca.Windows.Controls.AZToolBar()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdAgregarZona = New C1.Win.C1Command.C1Command()
        Me.cmdArticulos = New C1.Win.C1Command.C1Command()
        Me.cmdServicios = New C1.Win.C1Command.C1Command()
        Me.cmdNuevoContacto = New C1.Win.C1Command.C1Command()
        Me.btnArticulos = New C1.Win.C1Command.C1CommandLink()
        Me.btnServicios = New C1.Win.C1Command.C1CommandLink()
        Me.imlProveedores = New System.Windows.Forms.ImageList(Me.components)
        Me.tabProveedor = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagGeneral = New C1.Win.C1Command.C1DockingTabPage()
        Me.pagDomicilio = New C1.Win.C1Command.C1DockingTabPage()
        Me.pagFacturacion = New C1.Win.C1Command.C1DockingTabPage()
        Me.pagPagos = New C1.Win.C1Command.C1DockingTabPage()
        Me.pagContactos = New C1.Win.C1Command.C1DockingTabPage()
        Me.tlbContactos = New Azteca.Windows.Controls.AZToolBar()
        Me.btnNuevoContacto = New C1.Win.C1Command.C1CommandLink()
        Me.pagZonas = New C1.Win.C1Command.C1DockingTabPage()
        CType(Me.nudDiasEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCondicionesPago.SuspendLayout()
        Me.pnlCredito.SuspendLayout()
        CType(Me.nudDiasCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPagosElectronicos.SuspendLayout()
        CType(Me.grdContactos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsContactos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdZonas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsZonas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabProveedor.SuspendLayout()
        Me.pagGeneral.SuspendLayout()
        Me.pagDomicilio.SuspendLayout()
        Me.pagFacturacion.SuspendLayout()
        Me.pagPagos.SuspendLayout()
        Me.pagContactos.SuspendLayout()
        Me.pagZonas.SuspendLayout()
        Me.SuspendLayout()
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel4.Location = New System.Drawing.Point(18, 174)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(86, 13)
        Me.CiLabel4.TabIndex = 14
        Me.CiLabel4.Text = "Dias de Entrega:"
        '
        'nudDiasEntrega
        '
        Me.nudDiasEntrega.HighlightColor = System.Drawing.SystemColors.Info
        Me.nudDiasEntrega.Location = New System.Drawing.Point(114, 172)
        Me.nudDiasEntrega.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.nudDiasEntrega.Name = "nudDiasEntrega"
        Me.nudDiasEntrega.Size = New System.Drawing.Size(62, 20)
        Me.nudDiasEntrega.TabIndex = 15
        '
        'txtPassword
        '
        Me.txtPassword.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtPassword.Location = New System.Drawing.Point(113, 146)
        Me.txtPassword.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPassword.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(125, 20)
        Me.txtPassword.TabIndex = 13
        '
        'CiLabel14
        '
        Me.CiLabel14.AutoSize = True
        Me.CiLabel14.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel14.Location = New System.Drawing.Point(18, 149)
        Me.CiLabel14.Name = "CiLabel14"
        Me.CiLabel14.Size = New System.Drawing.Size(57, 13)
        Me.CiLabel14.TabIndex = 12
        Me.CiLabel14.Text = "Web Pwd:"
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
        Me.txtCuenta.Location = New System.Drawing.Point(113, 118)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(290, 23)
        Me.txtCuenta.TabIndex = 11
        Me.txtCuenta.TextWidth = 100
        Me.txtCuenta.UIName = "Cuenta Contable"
        '
        'CiLabel13
        '
        Me.CiLabel13.AutoSize = True
        Me.CiLabel13.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel13.Location = New System.Drawing.Point(18, 121)
        Me.CiLabel13.Name = "CiLabel13"
        Me.CiLabel13.Size = New System.Drawing.Size(44, 13)
        Me.CiLabel13.TabIndex = 10
        Me.CiLabel13.Text = "Cuenta:"
        '
        'txtFax
        '
        Me.txtFax.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtFax.Location = New System.Drawing.Point(277, 40)
        Me.txtFax.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFax.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(126, 20)
        Me.txtFax.TabIndex = 5
        Me.txtFax.UIName = Nothing
        '
        'lblFax
        '
        Me.lblFax.AutoSize = True
        Me.lblFax.BackColor = System.Drawing.Color.Transparent
        Me.lblFax.Location = New System.Drawing.Point(244, 43)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(27, 13)
        Me.lblFax.TabIndex = 4
        Me.lblFax.Text = "Fax:"
        '
        'txtURL
        '
        Me.txtURL.CharacterCasing = Azteca.Windows.Controls.CaseType.Lower
        Me.txtURL.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtURL.Location = New System.Drawing.Point(113, 92)
        Me.txtURL.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtURL.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(290, 20)
        Me.txtURL.TabIndex = 9
        '
        'lblURL
        '
        Me.lblURL.AutoSize = True
        Me.lblURL.BackColor = System.Drawing.Color.Transparent
        Me.lblURL.Location = New System.Drawing.Point(18, 95)
        Me.lblURL.Name = "lblURL"
        Me.lblURL.Size = New System.Drawing.Size(58, 13)
        Me.lblURL.TabIndex = 8
        Me.lblURL.Text = "Pág. Web:"
        '
        'txtCorreo
        '
        Me.txtCorreo.CharacterCasing = Azteca.Windows.Controls.CaseType.Lower
        Me.txtCorreo.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCorreo.Location = New System.Drawing.Point(113, 66)
        Me.txtCorreo.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCorreo.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.RegularExpression = "^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4" & _
    "}|[0-9]{1,3})(\]?)$"
        Me.txtCorreo.Size = New System.Drawing.Size(290, 20)
        Me.txtCorreo.TabIndex = 7
        Me.txtCorreo.UIName = "Correo"
        '
        'txtTelefono
        '
        Me.txtTelefono.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTelefono.Location = New System.Drawing.Point(113, 40)
        Me.txtTelefono.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTelefono.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(125, 20)
        Me.txtTelefono.TabIndex = 3
        Me.txtTelefono.UIName = Nothing
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(113, 14)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(290, 20)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.UIName = "Nombre"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.BackColor = System.Drawing.Color.Transparent
        Me.lblCorreo.Location = New System.Drawing.Point(18, 69)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(41, 13)
        Me.lblCorreo.TabIndex = 6
        Me.lblCorreo.Text = "Correo:"
        '
        'lblTelOficina
        '
        Me.lblTelOficina.AutoSize = True
        Me.lblTelOficina.BackColor = System.Drawing.Color.Transparent
        Me.lblTelOficina.Location = New System.Drawing.Point(18, 43)
        Me.lblTelOficina.Name = "lblTelOficina"
        Me.lblTelOficina.Size = New System.Drawing.Size(52, 13)
        Me.lblTelOficina.TabIndex = 2
        Me.lblTelOficina.Text = "Telefono:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Location = New System.Drawing.Point(18, 17)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre:"
        '
        'txtPoblacion
        '
        Me.txtPoblacion.AnySite = False
        Me.txtPoblacion.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtPoblacion.EditorAssembly = "Azteca.Windows"
        Me.txtPoblacion.EditorClass = "Azteca.Windows.Forms.General.CatalogoPoblaciones"
        Me.txtPoblacion.EditorTitle = "Editar población..."
        Me.txtPoblacion.Key = 0
        Me.txtPoblacion.Linked = False
        Me.txtPoblacion.Location = New System.Drawing.Point(97, 116)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.Size = New System.Drawing.Size(300, 23)
        Me.txtPoblacion.TabIndex = 11
        Me.txtPoblacion.TextWidth = 70
        Me.txtPoblacion.UIName = "Pobación"
        '
        'lblEstadoInf
        '
        Me.lblEstadoInf.AutoSize = True
        Me.lblEstadoInf.BackColor = System.Drawing.Color.Transparent
        Me.lblEstadoInf.Location = New System.Drawing.Point(95, 145)
        Me.lblEstadoInf.Name = "lblEstadoInf"
        Me.lblEstadoInf.Size = New System.Drawing.Size(46, 13)
        Me.lblEstadoInf.TabIndex = 13
        Me.lblEstadoInf.Text = "[Estado]"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.BackColor = System.Drawing.Color.Transparent
        Me.lblEstado.Location = New System.Drawing.Point(16, 145)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(43, 13)
        Me.lblEstado.TabIndex = 12
        Me.lblEstado.Text = "Estado:"
        '
        'txtCP
        '
        Me.txtCP.Digits = True
        Me.txtCP.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCP.Location = New System.Drawing.Point(97, 90)
        Me.txtCP.MaxLength = 5
        Me.txtCP.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCP.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCP.Name = "txtCP"
        Me.txtCP.RegularExpression = "\d{5}"
        Me.txtCP.Size = New System.Drawing.Size(70, 20)
        Me.txtCP.TabIndex = 9
        Me.txtCP.UIName = "Código Postal"
        '
        'txtColonia
        '
        Me.txtColonia.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtColonia.Location = New System.Drawing.Point(97, 64)
        Me.txtColonia.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColonia.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(300, 20)
        Me.txtColonia.TabIndex = 7
        Me.txtColonia.UIName = "Colonia"
        '
        'txtNumInt
        '
        Me.txtNumInt.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumInt.Location = New System.Drawing.Point(244, 38)
        Me.txtNumInt.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumInt.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumInt.Name = "txtNumInt"
        Me.txtNumInt.Size = New System.Drawing.Size(70, 20)
        Me.txtNumInt.TabIndex = 5
        Me.txtNumInt.UIName = Nothing
        '
        'txtNumExt
        '
        Me.txtNumExt.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumExt.Location = New System.Drawing.Point(97, 38)
        Me.txtNumExt.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExt.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExt.Name = "txtNumExt"
        Me.txtNumExt.Size = New System.Drawing.Size(70, 20)
        Me.txtNumExt.TabIndex = 3
        Me.txtNumExt.UIName = "Num. Exterior"
        '
        'txtCalle
        '
        Me.txtCalle.BackColor = System.Drawing.SystemColors.Window
        Me.txtCalle.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCalle.Location = New System.Drawing.Point(97, 12)
        Me.txtCalle.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalle.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(300, 20)
        Me.txtCalle.TabIndex = 1
        Me.txtCalle.UIName = "Calle"
        '
        'lblPoblacion
        '
        Me.lblPoblacion.AutoSize = True
        Me.lblPoblacion.BackColor = System.Drawing.Color.Transparent
        Me.lblPoblacion.Location = New System.Drawing.Point(16, 119)
        Me.lblPoblacion.Name = "lblPoblacion"
        Me.lblPoblacion.Size = New System.Drawing.Size(57, 13)
        Me.lblPoblacion.TabIndex = 10
        Me.lblPoblacion.Text = "Población:"
        '
        'lblCodigoPostal
        '
        Me.lblCodigoPostal.AutoSize = True
        Me.lblCodigoPostal.BackColor = System.Drawing.Color.Transparent
        Me.lblCodigoPostal.Location = New System.Drawing.Point(16, 93)
        Me.lblCodigoPostal.Name = "lblCodigoPostal"
        Me.lblCodigoPostal.Size = New System.Drawing.Size(75, 13)
        Me.lblCodigoPostal.TabIndex = 8
        Me.lblCodigoPostal.Text = "Código Postal:"
        '
        'lblNumInt
        '
        Me.lblNumInt.AutoSize = True
        Me.lblNumInt.BackColor = System.Drawing.Color.Transparent
        Me.lblNumInt.Location = New System.Drawing.Point(176, 41)
        Me.lblNumInt.Name = "lblNumInt"
        Me.lblNumInt.Size = New System.Drawing.Size(62, 13)
        Me.lblNumInt.TabIndex = 4
        Me.lblNumInt.Text = "No. Interior:"
        '
        'lblNumExt
        '
        Me.lblNumExt.AutoSize = True
        Me.lblNumExt.BackColor = System.Drawing.Color.Transparent
        Me.lblNumExt.Location = New System.Drawing.Point(16, 41)
        Me.lblNumExt.Name = "lblNumExt"
        Me.lblNumExt.Size = New System.Drawing.Size(65, 13)
        Me.lblNumExt.TabIndex = 2
        Me.lblNumExt.Text = "No. Exterior:"
        '
        'lblColonia
        '
        Me.lblColonia.AutoSize = True
        Me.lblColonia.BackColor = System.Drawing.Color.Transparent
        Me.lblColonia.Location = New System.Drawing.Point(16, 67)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(45, 13)
        Me.lblColonia.TabIndex = 6
        Me.lblColonia.Text = "Colonia:"
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.BackColor = System.Drawing.Color.Transparent
        Me.lblCalle.Location = New System.Drawing.Point(16, 18)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(33, 13)
        Me.lblCalle.TabIndex = 0
        Me.lblCalle.Text = "Calle:"
        '
        'chkFactElectronica
        '
        Me.chkFactElectronica.AutoSize = True
        Me.chkFactElectronica.BackColor = System.Drawing.Color.Transparent
        Me.chkFactElectronica.Location = New System.Drawing.Point(99, 218)
        Me.chkFactElectronica.Name = "chkFactElectronica"
        Me.chkFactElectronica.Size = New System.Drawing.Size(118, 17)
        Me.chkFactElectronica.TabIndex = 37
        Me.chkFactElectronica.Text = "Factura Electrónica"
        Me.chkFactElectronica.UseVisualStyleBackColor = False
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.BackColor = System.Drawing.SystemColors.Window
        Me.txtRazonSocial.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtRazonSocial.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtRazonSocial.Location = New System.Drawing.Point(97, 38)
        Me.txtRazonSocial.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRazonSocial.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(274, 20)
        Me.txtRazonSocial.TabIndex = 22
        '
        'lblRazonSocial
        '
        Me.lblRazonSocial.AutoSize = True
        Me.lblRazonSocial.BackColor = System.Drawing.Color.Transparent
        Me.lblRazonSocial.Location = New System.Drawing.Point(16, 41)
        Me.lblRazonSocial.Name = "lblRazonSocial"
        Me.lblRazonSocial.Size = New System.Drawing.Size(73, 13)
        Me.lblRazonSocial.TabIndex = 21
        Me.lblRazonSocial.Text = "Razón Social:"
        '
        'txtPoblacionFIS
        '
        Me.txtPoblacionFIS.AnySite = False
        Me.txtPoblacionFIS.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtPoblacionFIS.EditorAssembly = "Azteca.Windows"
        Me.txtPoblacionFIS.EditorClass = "Azteca.Windows.Forms.General.CatalogoPoblaciones"
        Me.txtPoblacionFIS.EditorTitle = "Editar población..."
        Me.txtPoblacionFIS.Key = 0
        Me.txtPoblacionFIS.Linked = False
        Me.txtPoblacionFIS.Location = New System.Drawing.Point(97, 158)
        Me.txtPoblacionFIS.Name = "txtPoblacionFIS"
        Me.txtPoblacionFIS.Size = New System.Drawing.Size(274, 23)
        Me.txtPoblacionFIS.TabIndex = 34
        Me.txtPoblacionFIS.TextWidth = 70
        Me.txtPoblacionFIS.UIName = "Pobación"
        '
        'CiLabel5
        '
        Me.CiLabel5.AutoSize = True
        Me.CiLabel5.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel5.Location = New System.Drawing.Point(96, 192)
        Me.CiLabel5.Name = "CiLabel5"
        Me.CiLabel5.Size = New System.Drawing.Size(46, 13)
        Me.CiLabel5.TabIndex = 36
        Me.CiLabel5.Text = "[Estado]"
        '
        'CiLabel6
        '
        Me.CiLabel6.AutoSize = True
        Me.CiLabel6.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel6.Location = New System.Drawing.Point(18, 192)
        Me.CiLabel6.Name = "CiLabel6"
        Me.CiLabel6.Size = New System.Drawing.Size(43, 13)
        Me.CiLabel6.TabIndex = 35
        Me.CiLabel6.Text = "Estado:"
        '
        'txtCPFis
        '
        Me.txtCPFis.Digits = True
        Me.txtCPFis.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCPFis.Location = New System.Drawing.Point(97, 133)
        Me.txtCPFis.MaxLength = 5
        Me.txtCPFis.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCPFis.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCPFis.Name = "txtCPFis"
        Me.txtCPFis.Size = New System.Drawing.Size(70, 20)
        Me.txtCPFis.TabIndex = 32
        Me.txtCPFis.UIName = "Código Postal"
        '
        'txtColoniaFIS
        '
        Me.txtColoniaFIS.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtColoniaFIS.Location = New System.Drawing.Point(97, 107)
        Me.txtColoniaFIS.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColoniaFIS.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColoniaFIS.Name = "txtColoniaFIS"
        Me.txtColoniaFIS.Size = New System.Drawing.Size(274, 20)
        Me.txtColoniaFIS.TabIndex = 30
        Me.txtColoniaFIS.UIName = "Colonia"
        '
        'txtNumIntFIS
        '
        Me.txtNumIntFIS.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumIntFIS.Location = New System.Drawing.Point(301, 84)
        Me.txtNumIntFIS.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumIntFIS.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumIntFIS.Name = "txtNumIntFIS"
        Me.txtNumIntFIS.Size = New System.Drawing.Size(70, 20)
        Me.txtNumIntFIS.TabIndex = 28
        Me.txtNumIntFIS.UIName = Nothing
        '
        'txtNumExtFIS
        '
        Me.txtNumExtFIS.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumExtFIS.Location = New System.Drawing.Point(97, 84)
        Me.txtNumExtFIS.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExtFIS.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExtFIS.Name = "txtNumExtFIS"
        Me.txtNumExtFIS.Size = New System.Drawing.Size(70, 20)
        Me.txtNumExtFIS.TabIndex = 26
        Me.txtNumExtFIS.UIName = "Num. Exterior"
        '
        'txtCalleFIS
        '
        Me.txtCalleFIS.BackColor = System.Drawing.SystemColors.Window
        Me.txtCalleFIS.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCalleFIS.Location = New System.Drawing.Point(97, 61)
        Me.txtCalleFIS.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalleFIS.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalleFIS.Name = "txtCalleFIS"
        Me.txtCalleFIS.Size = New System.Drawing.Size(274, 20)
        Me.txtCalleFIS.TabIndex = 24
        Me.txtCalleFIS.UIName = "Calle"
        '
        'CiLabel7
        '
        Me.CiLabel7.AutoSize = True
        Me.CiLabel7.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel7.Location = New System.Drawing.Point(16, 162)
        Me.CiLabel7.Name = "CiLabel7"
        Me.CiLabel7.Size = New System.Drawing.Size(57, 13)
        Me.CiLabel7.TabIndex = 33
        Me.CiLabel7.Text = "Población:"
        '
        'CiLabel8
        '
        Me.CiLabel8.AutoSize = True
        Me.CiLabel8.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel8.Location = New System.Drawing.Point(16, 136)
        Me.CiLabel8.Name = "CiLabel8"
        Me.CiLabel8.Size = New System.Drawing.Size(75, 13)
        Me.CiLabel8.TabIndex = 31
        Me.CiLabel8.Text = "Código Postal:"
        '
        'CiLabel9
        '
        Me.CiLabel9.AutoSize = True
        Me.CiLabel9.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel9.Location = New System.Drawing.Point(233, 87)
        Me.CiLabel9.Name = "CiLabel9"
        Me.CiLabel9.Size = New System.Drawing.Size(62, 13)
        Me.CiLabel9.TabIndex = 27
        Me.CiLabel9.Text = "No. Interior:"
        '
        'CiLabel10
        '
        Me.CiLabel10.AutoSize = True
        Me.CiLabel10.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel10.Location = New System.Drawing.Point(16, 84)
        Me.CiLabel10.Name = "CiLabel10"
        Me.CiLabel10.Size = New System.Drawing.Size(65, 13)
        Me.CiLabel10.TabIndex = 25
        Me.CiLabel10.Text = "No. Exterior:"
        '
        'CiLabel11
        '
        Me.CiLabel11.AutoSize = True
        Me.CiLabel11.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel11.Location = New System.Drawing.Point(16, 107)
        Me.CiLabel11.Name = "CiLabel11"
        Me.CiLabel11.Size = New System.Drawing.Size(45, 13)
        Me.CiLabel11.TabIndex = 29
        Me.CiLabel11.Text = "Colonia:"
        '
        'CiLabel12
        '
        Me.CiLabel12.AutoSize = True
        Me.CiLabel12.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel12.Location = New System.Drawing.Point(16, 64)
        Me.CiLabel12.Name = "CiLabel12"
        Me.CiLabel12.Size = New System.Drawing.Size(33, 13)
        Me.CiLabel12.TabIndex = 23
        Me.CiLabel12.Text = "Calle:"
        '
        'txtRFC
        '
        Me.txtRFC.BackColor = System.Drawing.SystemColors.Window
        Me.txtRFC.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtRFC.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtRFC.Location = New System.Drawing.Point(97, 12)
        Me.txtRFC.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRFC.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(125, 20)
        Me.txtRFC.TabIndex = 5
        Me.txtRFC.UIName = "RFC"
        '
        'lblRFC
        '
        Me.lblRFC.AutoSize = True
        Me.lblRFC.BackColor = System.Drawing.Color.Transparent
        Me.lblRFC.Location = New System.Drawing.Point(16, 15)
        Me.lblRFC.Name = "lblRFC"
        Me.lblRFC.Size = New System.Drawing.Size(31, 13)
        Me.lblRFC.TabIndex = 4
        Me.lblRFC.Text = "RFC:"
        '
        'grpCondicionesPago
        '
        Me.grpCondicionesPago.BackColor = System.Drawing.Color.Transparent
        Me.grpCondicionesPago.Controls.Add(Me.rdbAdelantado)
        Me.grpCondicionesPago.Controls.Add(Me.pnlCredito)
        Me.grpCondicionesPago.Controls.Add(Me.rdbCredito)
        Me.grpCondicionesPago.Controls.Add(Me.rdbContado)
        Me.grpCondicionesPago.Location = New System.Drawing.Point(23, 14)
        Me.grpCondicionesPago.Name = "grpCondicionesPago"
        Me.grpCondicionesPago.Size = New System.Drawing.Size(289, 188)
        Me.grpCondicionesPago.TabIndex = 0
        Me.grpCondicionesPago.TabStop = False
        Me.grpCondicionesPago.Text = "Condiciones de pago"
        '
        'rdbAdelantado
        '
        Me.rdbAdelantado.AutoSize = True
        Me.rdbAdelantado.Location = New System.Drawing.Point(19, 19)
        Me.rdbAdelantado.Name = "rdbAdelantado"
        Me.rdbAdelantado.Size = New System.Drawing.Size(124, 17)
        Me.rdbAdelantado.TabIndex = 0
        Me.rdbAdelantado.Text = "Pago por adelantado"
        Me.rdbAdelantado.UseVisualStyleBackColor = True
        '
        'pnlCredito
        '
        Me.pnlCredito.Controls.Add(Me.txtLimiteCredito)
        Me.pnlCredito.Controls.Add(Me.CiLabel1)
        Me.pnlCredito.Controls.Add(Me.CiLabel3)
        Me.pnlCredito.Controls.Add(Me.CiLabel2)
        Me.pnlCredito.Controls.Add(Me.nudDiasCredito)
        Me.pnlCredito.Controls.Add(Me.txtSaldo)
        Me.pnlCredito.Enabled = False
        Me.pnlCredito.GradientColorA = System.Drawing.SystemColors.ControlLight
        Me.pnlCredito.GradientColorB = System.Drawing.SystemColors.ControlDark
        Me.pnlCredito.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.pnlCredito.Location = New System.Drawing.Point(19, 88)
        Me.pnlCredito.Name = "pnlCredito"
        Me.pnlCredito.Size = New System.Drawing.Size(259, 89)
        Me.pnlCredito.TabIndex = 3
        Me.pnlCredito.UseGradient = False
        '
        'txtLimiteCredito
        '
        Me.txtLimiteCredito.BackColor = System.Drawing.SystemColors.Window
        Me.txtLimiteCredito.Digits = True
        Me.txtLimiteCredito.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtLimiteCredito.Format = "$#,##0.00"
        Me.txtLimiteCredito.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtLimiteCredito.Location = New System.Drawing.Point(105, 3)
        Me.txtLimiteCredito.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLimiteCredito.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLimiteCredito.Name = "txtLimiteCredito"
        Me.txtLimiteCredito.Size = New System.Drawing.Size(113, 20)
        Me.txtLimiteCredito.TabIndex = 1
        Me.txtLimiteCredito.Text = "$0.00"
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(11, 6)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(88, 13)
        Me.CiLabel1.TabIndex = 0
        Me.CiLabel1.Text = "Limite de Crédito:"
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(11, 59)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(82, 13)
        Me.CiLabel3.TabIndex = 4
        Me.CiLabel3.Text = "Dias de Crédito:"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(11, 33)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(37, 13)
        Me.CiLabel2.TabIndex = 2
        Me.CiLabel2.Text = "Saldo:"
        '
        'nudDiasCredito
        '
        Me.nudDiasCredito.HighlightColor = System.Drawing.SystemColors.Info
        Me.nudDiasCredito.Location = New System.Drawing.Point(105, 57)
        Me.nudDiasCredito.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.nudDiasCredito.Name = "nudDiasCredito"
        Me.nudDiasCredito.Size = New System.Drawing.Size(62, 20)
        Me.nudDiasCredito.TabIndex = 5
        '
        'txtSaldo
        '
        Me.txtSaldo.AutoLock = False
        Me.txtSaldo.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtSaldo.Location = New System.Drawing.Point(105, 30)
        Me.txtSaldo.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSaldo.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.Size = New System.Drawing.Size(113, 20)
        Me.txtSaldo.TabIndex = 3
        '
        'rdbCredito
        '
        Me.rdbCredito.AutoSize = True
        Me.rdbCredito.Location = New System.Drawing.Point(19, 65)
        Me.rdbCredito.Name = "rdbCredito"
        Me.rdbCredito.Size = New System.Drawing.Size(97, 17)
        Me.rdbCredito.TabIndex = 2
        Me.rdbCredito.Text = "Pago a crédito:"
        Me.rdbCredito.UseVisualStyleBackColor = True
        '
        'rdbContado
        '
        Me.rdbContado.AutoSize = True
        Me.rdbContado.Checked = True
        Me.rdbContado.Location = New System.Drawing.Point(19, 42)
        Me.rdbContado.Name = "rdbContado"
        Me.rdbContado.Size = New System.Drawing.Size(107, 17)
        Me.rdbContado.TabIndex = 1
        Me.rdbContado.TabStop = True
        Me.rdbContado.Text = "Pago de contado"
        Me.rdbContado.UseVisualStyleBackColor = True
        '
        'grpPagosElectronicos
        '
        Me.grpPagosElectronicos.BackColor = System.Drawing.Color.Transparent
        Me.grpPagosElectronicos.Controls.Add(Me.cboBanco)
        Me.grpPagosElectronicos.Controls.Add(Me.lblBanco)
        Me.grpPagosElectronicos.Controls.Add(Me.txtCLABE)
        Me.grpPagosElectronicos.Controls.Add(Me.lblCLABE)
        Me.grpPagosElectronicos.Location = New System.Drawing.Point(328, 14)
        Me.grpPagosElectronicos.Name = "grpPagosElectronicos"
        Me.grpPagosElectronicos.Size = New System.Drawing.Size(355, 92)
        Me.grpPagosElectronicos.TabIndex = 1
        Me.grpPagosElectronicos.TabStop = False
        Me.grpPagosElectronicos.Text = "Pagos Electrónicos"
        '
        'cboBanco
        '
        Me.cboBanco.AddNoneItem = True
        Me.cboBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBanco.FormattingEnabled = True
        Me.cboBanco.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboBanco.ItemsTable = Nothing
        Me.cboBanco.Location = New System.Drawing.Point(67, 25)
        Me.cboBanco.Name = "cboBanco"
        Me.cboBanco.Size = New System.Drawing.Size(221, 21)
        Me.cboBanco.TabIndex = 1
        Me.cboBanco.UIName = "Banco"
        '
        'lblBanco
        '
        Me.lblBanco.AutoSize = True
        Me.lblBanco.Location = New System.Drawing.Point(17, 25)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(41, 13)
        Me.lblBanco.TabIndex = 0
        Me.lblBanco.Text = "Banco:"
        '
        'txtCLABE
        '
        Me.txtCLABE.BackColor = System.Drawing.SystemColors.Window
        Me.txtCLABE.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCLABE.Location = New System.Drawing.Point(67, 52)
        Me.txtCLABE.MaxLength = 18
        Me.txtCLABE.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCLABE.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCLABE.Name = "txtCLABE"
        Me.txtCLABE.Size = New System.Drawing.Size(122, 20)
        Me.txtCLABE.TabIndex = 3
        '
        'lblCLABE
        '
        Me.lblCLABE.AutoSize = True
        Me.lblCLABE.Location = New System.Drawing.Point(17, 55)
        Me.lblCLABE.Name = "lblCLABE"
        Me.lblCLABE.Size = New System.Drawing.Size(44, 13)
        Me.lblCLABE.TabIndex = 2
        Me.lblCLABE.Text = "CLABE:"
        '
        'chkLeyenda
        '
        Me.chkLeyenda.AutoClear = False
        Me.chkLeyenda.AutoSize = True
        Me.chkLeyenda.BackColor = System.Drawing.Color.Transparent
        Me.chkLeyenda.Checked = True
        Me.chkLeyenda.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLeyenda.Location = New System.Drawing.Point(328, 122)
        Me.chkLeyenda.Name = "chkLeyenda"
        Me.chkLeyenda.Size = New System.Drawing.Size(355, 17)
        Me.chkLeyenda.TabIndex = 2
        Me.chkLeyenda.Text = "Imprimir leyenda de ""Abono en cuenta de beneficiario"" a sus cheques"
        Me.chkLeyenda.UseVisualStyleBackColor = False
        '
        'grdContactos
        '
        Me.grdContactos.AllowUpdate = False
        Me.grdContactos.AlternatingRows = True
        Me.grdContactos.DataSource = Me.bsContactos
        Me.grdContactos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdContactos.FilterBar = True
        Me.grdContactos.IDCatalogField = "IdPersona"
        Me.grdContactos.Images.Add(CType(resources.GetObject("grdContactos.Images"), System.Drawing.Image))
        Me.grdContactos.Location = New System.Drawing.Point(0, 34)
        Me.grdContactos.Name = "grdContactos"
        Me.grdContactos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdContactos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdContactos.PreviewInfo.ZoomFactor = 75.0R
        Me.grdContactos.PrintInfo.PageSettings = CType(resources.GetObject("grdContactos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdContactos.Size = New System.Drawing.Size(700, 250)
        Me.grdContactos.TabIndex = 2
        Me.grdContactos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdContactos.PropBag = resources.GetString("grdContactos.PropBag")
        '
        'grdZonas
        '
        Me.grdZonas.AllowUpdate = False
        Me.grdZonas.AutoClear = False
        Me.grdZonas.DataSource = Me.bsZonas
        Me.grdZonas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdZonas.ExtendRightColumn = True
        Me.grdZonas.Images.Add(CType(resources.GetObject("grdZonas.Images"), System.Drawing.Image))
        Me.grdZonas.Location = New System.Drawing.Point(0, 38)
        Me.grdZonas.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.grdZonas.Name = "grdZonas"
        Me.grdZonas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdZonas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdZonas.PreviewInfo.ZoomFactor = 75.0R
        Me.grdZonas.PrintInfo.PageSettings = CType(resources.GetObject("grdZonas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdZonas.Size = New System.Drawing.Size(700, 246)
        Me.grdZonas.TabIndex = 1
        Me.grdZonas.Text = "AzTrueDBGrid1"
        Me.grdZonas.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdZonas.PropBag = resources.GetString("grdZonas.PropBag")
        '
        'tlbZonas
        '
        Me.tlbZonas.AccessibleName = "Tool Bar"
        Me.tlbZonas.AutoSize = False
        Me.tlbZonas.CommandHolder = Me.C1CommandHolder1
        Me.tlbZonas.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.btnArticulos, Me.btnServicios})
        Me.tlbZonas.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbZonas.Location = New System.Drawing.Point(0, 0)
        Me.tlbZonas.MinButtonSize = 32
        Me.tlbZonas.Movable = False
        Me.tlbZonas.Name = "tlbZonas"
        Me.tlbZonas.Size = New System.Drawing.Size(700, 38)
        Me.tlbZonas.Text = "AzToolBar1"
        Me.tlbZonas.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tlbZonas.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdAgregarZona)
        Me.C1CommandHolder1.Commands.Add(Me.cmdArticulos)
        Me.C1CommandHolder1.Commands.Add(Me.cmdServicios)
        Me.C1CommandHolder1.Commands.Add(Me.cmdNuevoContacto)
        Me.C1CommandHolder1.Owner = Me
        '
        'cmdAgregarZona
        '
        Me.cmdAgregarZona.Image = CType(resources.GetObject("cmdAgregarZona.Image"), System.Drawing.Image)
        Me.cmdAgregarZona.Name = "cmdAgregarZona"
        Me.cmdAgregarZona.ShortcutText = ""
        Me.cmdAgregarZona.Text = "Agregar Zona"
        Me.cmdAgregarZona.ToolTipText = "Agregar una nueva zona de compra al proveedor actual"
        '
        'cmdArticulos
        '
        Me.cmdArticulos.Image = CType(resources.GetObject("cmdArticulos.Image"), System.Drawing.Image)
        Me.cmdArticulos.Name = "cmdArticulos"
        Me.cmdArticulos.ShortcutText = ""
        Me.cmdArticulos.Text = "Artículos"
        '
        'cmdServicios
        '
        Me.cmdServicios.Image = CType(resources.GetObject("cmdServicios.Image"), System.Drawing.Image)
        Me.cmdServicios.Name = "cmdServicios"
        Me.cmdServicios.ShortcutText = ""
        Me.cmdServicios.Text = "Servicios"
        '
        'cmdNuevoContacto
        '
        Me.cmdNuevoContacto.Image = CType(resources.GetObject("cmdNuevoContacto.Image"), System.Drawing.Image)
        Me.cmdNuevoContacto.Name = "cmdNuevoContacto"
        Me.cmdNuevoContacto.ShortcutText = ""
        Me.cmdNuevoContacto.Text = "Nuevo Contacto"
        '
        'btnArticulos
        '
        Me.btnArticulos.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnArticulos.Command = Me.cmdArticulos
        Me.btnArticulos.ToolTipText = "Editar los artículos que el proveedor vende en ésta zona."
        '
        'btnServicios
        '
        Me.btnServicios.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnServicios.Command = Me.cmdServicios
        Me.btnServicios.SortOrder = 1
        Me.btnServicios.ToolTipText = "Editar la lista de servicios que el proveedor proporciona en ésta zona"
        '
        'imlProveedores
        '
        Me.imlProveedores.ImageStream = CType(resources.GetObject("imlProveedores.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlProveedores.TransparentColor = System.Drawing.Color.Transparent
        Me.imlProveedores.Images.SetKeyName(0, "General")
        Me.imlProveedores.Images.SetKeyName(1, "House")
        Me.imlProveedores.Images.SetKeyName(2, "Factura")
        Me.imlProveedores.Images.SetKeyName(3, "Articulos")
        Me.imlProveedores.Images.SetKeyName(4, "Servicios")
        Me.imlProveedores.Images.SetKeyName(5, "Credito")
        Me.imlProveedores.Images.SetKeyName(6, "Contactos")
        Me.imlProveedores.Images.SetKeyName(7, "Zonas")
        Me.imlProveedores.Images.SetKeyName(8, "Pagos")
        '
        'tabProveedor
        '
        Me.tabProveedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabProveedor.Controls.Add(Me.pagGeneral)
        Me.tabProveedor.Controls.Add(Me.pagDomicilio)
        Me.tabProveedor.Controls.Add(Me.pagFacturacion)
        Me.tabProveedor.Controls.Add(Me.pagPagos)
        Me.tabProveedor.Controls.Add(Me.pagContactos)
        Me.tabProveedor.Controls.Add(Me.pagZonas)
        Me.tabProveedor.ImageList = Me.imlProveedores
        Me.tabProveedor.Location = New System.Drawing.Point(12, 95)
        Me.tabProveedor.Name = "tabProveedor"
        Me.tabProveedor.SelectedIndex = 1
        Me.tabProveedor.Size = New System.Drawing.Size(702, 326)
        Me.tabProveedor.TabIndex = 32
        Me.tabProveedor.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabProveedor.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabProveedor.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagGeneral
        '
        Me.pagGeneral.Controls.Add(Me.txtFax)
        Me.pagGeneral.Controls.Add(Me.lblFax)
        Me.pagGeneral.Controls.Add(Me.CiLabel4)
        Me.pagGeneral.Controls.Add(Me.txtNombre)
        Me.pagGeneral.Controls.Add(Me.nudDiasEntrega)
        Me.pagGeneral.Controls.Add(Me.lblNombre)
        Me.pagGeneral.Controls.Add(Me.txtPassword)
        Me.pagGeneral.Controls.Add(Me.lblTelOficina)
        Me.pagGeneral.Controls.Add(Me.CiLabel14)
        Me.pagGeneral.Controls.Add(Me.lblCorreo)
        Me.pagGeneral.Controls.Add(Me.txtCuenta)
        Me.pagGeneral.Controls.Add(Me.txtTelefono)
        Me.pagGeneral.Controls.Add(Me.CiLabel13)
        Me.pagGeneral.Controls.Add(Me.txtCorreo)
        Me.pagGeneral.Controls.Add(Me.lblURL)
        Me.pagGeneral.Controls.Add(Me.txtURL)
        Me.pagGeneral.ImageIndex = 0
        Me.pagGeneral.Location = New System.Drawing.Point(1, 41)
        Me.pagGeneral.Name = "pagGeneral"
        Me.pagGeneral.Size = New System.Drawing.Size(700, 284)
        Me.pagGeneral.TabIndex = 0
        Me.pagGeneral.Text = "General"
        '
        'pagDomicilio
        '
        Me.pagDomicilio.Controls.Add(Me.txtPoblacion)
        Me.pagDomicilio.Controls.Add(Me.txtCalle)
        Me.pagDomicilio.Controls.Add(Me.lblEstadoInf)
        Me.pagDomicilio.Controls.Add(Me.lblCalle)
        Me.pagDomicilio.Controls.Add(Me.lblEstado)
        Me.pagDomicilio.Controls.Add(Me.lblColonia)
        Me.pagDomicilio.Controls.Add(Me.txtCP)
        Me.pagDomicilio.Controls.Add(Me.lblNumExt)
        Me.pagDomicilio.Controls.Add(Me.txtColonia)
        Me.pagDomicilio.Controls.Add(Me.lblNumInt)
        Me.pagDomicilio.Controls.Add(Me.txtNumInt)
        Me.pagDomicilio.Controls.Add(Me.lblCodigoPostal)
        Me.pagDomicilio.Controls.Add(Me.txtNumExt)
        Me.pagDomicilio.Controls.Add(Me.lblPoblacion)
        Me.pagDomicilio.ImageIndex = 1
        Me.pagDomicilio.Location = New System.Drawing.Point(1, 41)
        Me.pagDomicilio.Name = "pagDomicilio"
        Me.pagDomicilio.Size = New System.Drawing.Size(700, 284)
        Me.pagDomicilio.TabIndex = 1
        Me.pagDomicilio.Text = "Domicilio"
        '
        'pagFacturacion
        '
        Me.pagFacturacion.Controls.Add(Me.txtPoblacionFIS)
        Me.pagFacturacion.Controls.Add(Me.chkFactElectronica)
        Me.pagFacturacion.Controls.Add(Me.txtNumIntFIS)
        Me.pagFacturacion.Controls.Add(Me.txtRazonSocial)
        Me.pagFacturacion.Controls.Add(Me.lblRFC)
        Me.pagFacturacion.Controls.Add(Me.lblRazonSocial)
        Me.pagFacturacion.Controls.Add(Me.txtRFC)
        Me.pagFacturacion.Controls.Add(Me.CiLabel12)
        Me.pagFacturacion.Controls.Add(Me.CiLabel5)
        Me.pagFacturacion.Controls.Add(Me.CiLabel11)
        Me.pagFacturacion.Controls.Add(Me.CiLabel6)
        Me.pagFacturacion.Controls.Add(Me.CiLabel10)
        Me.pagFacturacion.Controls.Add(Me.txtCPFis)
        Me.pagFacturacion.Controls.Add(Me.CiLabel9)
        Me.pagFacturacion.Controls.Add(Me.txtColoniaFIS)
        Me.pagFacturacion.Controls.Add(Me.CiLabel8)
        Me.pagFacturacion.Controls.Add(Me.CiLabel7)
        Me.pagFacturacion.Controls.Add(Me.txtNumExtFIS)
        Me.pagFacturacion.Controls.Add(Me.txtCalleFIS)
        Me.pagFacturacion.ImageIndex = 2
        Me.pagFacturacion.Location = New System.Drawing.Point(1, 41)
        Me.pagFacturacion.Name = "pagFacturacion"
        Me.pagFacturacion.Size = New System.Drawing.Size(700, 284)
        Me.pagFacturacion.TabIndex = 2
        Me.pagFacturacion.Text = "Facturación"
        '
        'pagPagos
        '
        Me.pagPagos.Controls.Add(Me.grpCondicionesPago)
        Me.pagPagos.Controls.Add(Me.grpPagosElectronicos)
        Me.pagPagos.Controls.Add(Me.chkLeyenda)
        Me.pagPagos.ImageIndex = 8
        Me.pagPagos.Location = New System.Drawing.Point(1, 41)
        Me.pagPagos.Name = "pagPagos"
        Me.pagPagos.Size = New System.Drawing.Size(700, 284)
        Me.pagPagos.TabIndex = 3
        Me.pagPagos.Text = "Pagos"
        '
        'pagContactos
        '
        Me.pagContactos.Controls.Add(Me.grdContactos)
        Me.pagContactos.Controls.Add(Me.tlbContactos)
        Me.pagContactos.ImageIndex = 6
        Me.pagContactos.Location = New System.Drawing.Point(1, 41)
        Me.pagContactos.Name = "pagContactos"
        Me.pagContactos.Size = New System.Drawing.Size(700, 284)
        Me.pagContactos.TabIndex = 4
        Me.pagContactos.Text = "Contactos"
        '
        'tlbContactos
        '
        Me.tlbContactos.AccessibleName = "Tool Bar"
        Me.tlbContactos.AutoSize = False
        Me.tlbContactos.CommandHolder = Me.C1CommandHolder1
        Me.tlbContactos.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.btnNuevoContacto})
        Me.tlbContactos.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbContactos.Location = New System.Drawing.Point(0, 0)
        Me.tlbContactos.MinButtonSize = 32
        Me.tlbContactos.Movable = False
        Me.tlbContactos.Name = "tlbContactos"
        Me.tlbContactos.Size = New System.Drawing.Size(700, 34)
        Me.tlbContactos.Text = "AzToolBar1"
        Me.tlbContactos.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'btnNuevoContacto
        '
        Me.btnNuevoContacto.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnNuevoContacto.Command = Me.cmdNuevoContacto
        '
        'pagZonas
        '
        Me.pagZonas.Controls.Add(Me.grdZonas)
        Me.pagZonas.Controls.Add(Me.tlbZonas)
        Me.pagZonas.ImageIndex = 7
        Me.pagZonas.Location = New System.Drawing.Point(1, 41)
        Me.pagZonas.Name = "pagZonas"
        Me.pagZonas.Size = New System.Drawing.Size(700, 284)
        Me.pagZonas.TabIndex = 5
        Me.pagZonas.Text = "Zonas de Compras"
        '
        'ProveedoresForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 452)
        Me.CodeFieldSize = New System.Drawing.Size(120, 20)
        Me.Controls.Add(Me.tabProveedor)
        Me.KeyMode = Azteca.Windows.Forms.BusinessForms.CatalogForm.UserKeyMode.UserDefined
        Me.Name = "ProveedoresForm"
        Me.Text = "Proveedores"
        Me.Controls.SetChildIndex(Me.tabProveedor, 0)
        CType(Me.nudDiasEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCondicionesPago.ResumeLayout(False)
        Me.grpCondicionesPago.PerformLayout()
        Me.pnlCredito.ResumeLayout(False)
        Me.pnlCredito.PerformLayout()
        CType(Me.nudDiasCredito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPagosElectronicos.ResumeLayout(False)
        Me.grpPagosElectronicos.PerformLayout()
        CType(Me.grdContactos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsContactos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdZonas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsZonas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabProveedor.ResumeLayout(False)
        Me.pagGeneral.ResumeLayout(False)
        Me.pagGeneral.PerformLayout()
        Me.pagDomicilio.ResumeLayout(False)
        Me.pagDomicilio.PerformLayout()
        Me.pagFacturacion.ResumeLayout(False)
        Me.pagFacturacion.PerformLayout()
        Me.pagPagos.ResumeLayout(False)
        Me.pagPagos.PerformLayout()
        Me.pagContactos.ResumeLayout(False)
        Me.pagZonas.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Facade = New ProveedorFacade
    End Sub

    Friend WithEvents txtURL As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblURL As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCorreo As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblCorreo As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblNombre As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtPoblacion As Azteca.Windows.Controls.General.PoblacionSelector
    Friend WithEvents lblEstadoInf As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblEstado As Azteca.Windows.Controls.CILabel
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
    Friend WithEvents txtFax As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblFax As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtTelefono As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblTelOficina As Azteca.Windows.Controls.CILabel
    Friend WithEvents imlProveedores As System.Windows.Forms.ImageList
    Friend WithEvents txtRFC As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblRFC As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtRazonSocial As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblRazonSocial As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtPoblacionFIS As Azteca.Windows.Controls.General.PoblacionSelector
    Friend WithEvents CiLabel5 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel6 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCPFis As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtColoniaFIS As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtNumIntFIS As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtNumExtFIS As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtCalleFIS As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel7 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel8 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel9 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel10 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel11 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel12 As Azteca.Windows.Controls.CILabel
    Friend WithEvents chkFactElectronica As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents txtCuenta As Azteca.Windows.Contabilidad.CuentaSelector
    Friend WithEvents CiLabel13 As Azteca.Windows.Controls.CILabel
    Friend WithEvents grdContactos As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents txtPassword As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel14 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
    Friend WithEvents nudDiasEntrega As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents tlbZonas As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents cmdAgregarZona As C1.Win.C1Command.C1Command
    Friend WithEvents cmdArticulos As C1.Win.C1Command.C1Command
    Friend WithEvents cmdServicios As C1.Win.C1Command.C1Command
    Friend WithEvents btnArticulos As C1.Win.C1Command.C1CommandLink
    Friend WithEvents btnServicios As C1.Win.C1Command.C1CommandLink
    Private WithEvents bsContactos As System.Windows.Forms.BindingSource
    Friend WithEvents grdZonas As Azteca.Windows.Controls.AZTrueDBGrid
    Private WithEvents bsZonas As System.Windows.Forms.BindingSource
    Friend WithEvents grpPagosElectronicos As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents cboBanco As Azteca.Windows.Tesoreria.BancosComboBox
    Friend WithEvents lblBanco As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCLABE As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblCLABE As Azteca.Windows.Controls.CILabel
    Friend WithEvents chkLeyenda As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents grpCondicionesPago As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents rdbAdelantado As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents rdbCredito As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents rdbContado As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents pnlCredito As Azteca.Windows.Controls.CIPanel
    Friend WithEvents txtLimiteCredito As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents nudDiasCredito As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents txtSaldo As Azteca.Windows.Controls.CITextBox
    Friend WithEvents tabProveedor As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagGeneral As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagDomicilio As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagFacturacion As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagPagos As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagContactos As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagZonas As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents cmdNuevoContacto As C1.Win.C1Command.C1Command
    Friend WithEvents tlbContactos As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents btnNuevoContacto As C1.Win.C1Command.C1CommandLink
End Class
