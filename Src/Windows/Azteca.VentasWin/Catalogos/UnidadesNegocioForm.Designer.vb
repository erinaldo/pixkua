<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnidadesNegocioForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UnidadesNegocioForm))
        Me.txtPagWeb = New Azteca.Windows.Controls.CITextBox()
        Me.txtCorreo = New Azteca.Windows.Controls.CITextBox()
        Me.txtFax = New Azteca.Windows.Controls.CITextBox()
        Me.lblCorreo = New Azteca.Windows.Controls.CILabel()
        Me.lblPagWeb = New Azteca.Windows.Controls.CILabel()
        Me.lblFax = New Azteca.Windows.Controls.CILabel()
        Me.lblTel2 = New Azteca.Windows.Controls.CILabel()
        Me.txtTel2 = New Azteca.Windows.Controls.CITextBox()
        Me.txtTel1 = New Azteca.Windows.Controls.CITextBox()
        Me.lblTel1 = New Azteca.Windows.Controls.CILabel()
        Me.cboEmpresa = New Azteca.Windows.Controls.Security.EmpresasComboBox()
        Me.lblEmpresa = New Azteca.Windows.Controls.CILabel()
        Me.lblNombreCorto = New Azteca.Windows.Controls.CILabel()
        Me.lblNombreLargo = New Azteca.Windows.Controls.CILabel()
        Me.txtNombreCorto = New Azteca.Windows.Controls.CITextBox()
        Me.txtNombreLargo = New Azteca.Windows.Controls.CITextBox()
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
        Me.CiLabel15 = New Azteca.Windows.Controls.CILabel()
        Me.cboFormatoFactura = New Azteca.Windows.Controls.FormatosComboBox()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.txtSerieFact = New Azteca.Windows.Contabilidad.SerieSelector()
        Me.CiLabel17 = New Azteca.Windows.Controls.CILabel()
        Me.CiGroupBox2 = New Azteca.Windows.Controls.CIGroupBox()
        Me.cboRegion = New Azteca.Windows.Ventas.RegionesComboBox()
        Me.cboDivisaBase = New Azteca.Windows.Contabilidad.DivisasComboBox()
        Me.txtGLN = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel16 = New Azteca.Windows.Controls.CILabel()
        Me.cboZonaVenta = New Azteca.Windows.Ventas.ZonasVentaComboBox()
        Me.CiLabel7 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel12 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel13 = New Azteca.Windows.Controls.CILabel()
        Me.grpTipoPrecio = New Azteca.Windows.Controls.CIGroupBox()
        Me.rdbZonasVenta = New Azteca.Windows.Controls.CIRadioButton()
        Me.rdbListaPrecio = New Azteca.Windows.Controls.CIRadioButton()
        Me.txtSerieDev = New Azteca.Windows.Contabilidad.SerieSelector()
        Me.CiLabel5 = New Azteca.Windows.Controls.CILabel()
        Me.cboFormatoDev = New Azteca.Windows.Controls.FormatosComboBox()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.grpModoAfectacion = New Azteca.Windows.Controls.CIGroupBox()
        Me.rdbAfectInvBatch = New Azteca.Windows.Controls.CIRadioButton()
        Me.rdbAfectInvLinea = New Azteca.Windows.Controls.CIRadioButton()
        Me.cboAlmacen = New Azteca.Windows.Inventario.AlmacenesComboBox()
        Me.chkAfectarInv = New Azteca.Windows.Controls.CICheckBox()
        Me.grpNotificaciones = New Azteca.Windows.Controls.CIGroupBox()
        Me.CiGroupBox1 = New Azteca.Windows.Controls.CIGroupBox()
        Me.CiLabel6 = New Azteca.Windows.Controls.CILabel()
        Me.nudPorcentajeFolios = New Azteca.Windows.Controls.CINumericUpDown()
        Me.CiCheckBox3 = New Azteca.Windows.Controls.CICheckBox()
        Me.CiCheckBox2 = New Azteca.Windows.Controls.CICheckBox()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.chkEnviarFact = New Azteca.Windows.Controls.CICheckBox()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.cboRemitente = New Azteca.Windows.Mail.RemitentesComboBox()
        Me.cboTicketPOS = New Azteca.Windows.Controls.FormatosComboBox()
        Me.CiLabel10 = New Azteca.Windows.Controls.CILabel()
        Me.cboTicketPedimento = New Azteca.Windows.Controls.FormatosComboBox()
        Me.CiLabel9 = New Azteca.Windows.Controls.CILabel()
        Me.cboTicketComanda = New Azteca.Windows.Controls.FormatosComboBox()
        Me.CiLabel8 = New Azteca.Windows.Controls.CILabel()
        Me.imlUN = New System.Windows.Forms.ImageList(Me.components)
        Me.tabUnidadNegocio = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagGeneral = New C1.Win.C1Command.C1DockingTabPage()
        Me.pagDomicilio = New C1.Win.C1Command.C1DockingTabPage()
        Me.pagFacturacion = New C1.Win.C1Command.C1DockingTabPage()
        Me.txtClienteGenFact = New Azteca.Windows.Ventas.ClienteSelector()
        Me.pagVentas = New C1.Win.C1Command.C1DockingTabPage()
        Me.grpPoliticaDescuento = New Azteca.Windows.Controls.CIGroupBox()
        Me.rdbDescDespImp = New Azteca.Windows.Controls.CIRadioButton()
        Me.rdbDescAntesImp = New Azteca.Windows.Controls.CIRadioButton()
        Me.CiLabel11 = New Azteca.Windows.Controls.CILabel()
        Me.txtClienteGen = New Azteca.Windows.Ventas.ClienteSelector()
        Me.pagDevoluciones = New C1.Win.C1Command.C1DockingTabPage()
        Me.pagInventario = New C1.Win.C1Command.C1DockingTabPage()
        Me.pagNotificaciones = New C1.Win.C1Command.C1DockingTabPage()
        Me.pagPuntoVenta = New C1.Win.C1Command.C1DockingTabPage()
        Me.cboFormatoCortePOS = New Azteca.Windows.Controls.FormatosComboBox()
        Me.CiLabel14 = New Azteca.Windows.Controls.CILabel()
        Me.cboFormatoUbicacionPOS = New Azteca.Windows.Controls.FormatosComboBox()
        Me.lblFormatoUbicacionPOS = New Azteca.Windows.Controls.CILabel()
        Me.CiGroupBox2.SuspendLayout()
        Me.grpTipoPrecio.SuspendLayout()
        Me.grpModoAfectacion.SuspendLayout()
        Me.grpNotificaciones.SuspendLayout()
        Me.CiGroupBox1.SuspendLayout()
        CType(Me.nudPorcentajeFolios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabUnidadNegocio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabUnidadNegocio.SuspendLayout()
        Me.pagGeneral.SuspendLayout()
        Me.pagDomicilio.SuspendLayout()
        Me.pagFacturacion.SuspendLayout()
        Me.pagVentas.SuspendLayout()
        Me.grpPoliticaDescuento.SuspendLayout()
        Me.pagDevoluciones.SuspendLayout()
        Me.pagInventario.SuspendLayout()
        Me.pagNotificaciones.SuspendLayout()
        Me.pagPuntoVenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPagWeb
        '
        Me.txtPagWeb.CharacterCasing = Azteca.Windows.Controls.CaseType.Lower
        Me.txtPagWeb.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtPagWeb.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtPagWeb.Location = New System.Drawing.Point(107, 144)
        Me.txtPagWeb.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPagWeb.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPagWeb.Name = "txtPagWeb"
        Me.txtPagWeb.Size = New System.Drawing.Size(334, 20)
        Me.txtPagWeb.TabIndex = 15
        '
        'txtCorreo
        '
        Me.txtCorreo.CharacterCasing = Azteca.Windows.Controls.CaseType.Lower
        Me.txtCorreo.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCorreo.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCorreo.Location = New System.Drawing.Point(260, 121)
        Me.txtCorreo.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCorreo.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(181, 20)
        Me.txtCorreo.TabIndex = 13
        '
        'txtFax
        '
        Me.txtFax.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtFax.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtFax.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtFax.Location = New System.Drawing.Point(107, 118)
        Me.txtFax.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFax.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(100, 20)
        Me.txtFax.TabIndex = 11
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(213, 121)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(41, 13)
        Me.lblCorreo.TabIndex = 12
        Me.lblCorreo.Text = "Correo:"
        '
        'lblPagWeb
        '
        Me.lblPagWeb.AutoSize = True
        Me.lblPagWeb.BackColor = System.Drawing.Color.Transparent
        Me.lblPagWeb.Location = New System.Drawing.Point(24, 147)
        Me.lblPagWeb.Name = "lblPagWeb"
        Me.lblPagWeb.Size = New System.Drawing.Size(69, 13)
        Me.lblPagWeb.TabIndex = 14
        Me.lblPagWeb.Text = "Página Web:"
        '
        'lblFax
        '
        Me.lblFax.AutoSize = True
        Me.lblFax.BackColor = System.Drawing.Color.Transparent
        Me.lblFax.Location = New System.Drawing.Point(24, 121)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(27, 13)
        Me.lblFax.TabIndex = 10
        Me.lblFax.Text = "Fax:"
        '
        'lblTel2
        '
        Me.lblTel2.AutoSize = True
        Me.lblTel2.Location = New System.Drawing.Point(220, 95)
        Me.lblTel2.Name = "lblTel2"
        Me.lblTel2.Size = New System.Drawing.Size(34, 13)
        Me.lblTel2.TabIndex = 8
        Me.lblTel2.Text = "Tel 2:"
        '
        'txtTel2
        '
        Me.txtTel2.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtTel2.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtTel2.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTel2.Location = New System.Drawing.Point(260, 92)
        Me.txtTel2.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTel2.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTel2.Name = "txtTel2"
        Me.txtTel2.Size = New System.Drawing.Size(100, 20)
        Me.txtTel2.TabIndex = 9
        '
        'txtTel1
        '
        Me.txtTel1.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtTel1.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtTel1.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTel1.Location = New System.Drawing.Point(107, 92)
        Me.txtTel1.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTel1.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTel1.Name = "txtTel1"
        Me.txtTel1.Size = New System.Drawing.Size(100, 20)
        Me.txtTel1.TabIndex = 7
        '
        'lblTel1
        '
        Me.lblTel1.AutoSize = True
        Me.lblTel1.BackColor = System.Drawing.Color.Transparent
        Me.lblTel1.Location = New System.Drawing.Point(24, 95)
        Me.lblTel1.Name = "lblTel1"
        Me.lblTel1.Size = New System.Drawing.Size(61, 13)
        Me.lblTel1.TabIndex = 6
        Me.lblTel1.Text = "Teléfono 1:"
        '
        'cboEmpresa
        '
        Me.cboEmpresa.BackColor = System.Drawing.SystemColors.Window
        Me.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpresa.FormattingEnabled = True
        Me.cboEmpresa.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboEmpresa.ItemsTable = Nothing
        Me.cboEmpresa.Location = New System.Drawing.Point(107, 13)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.RequiredField = True
        Me.cboEmpresa.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboEmpresa.Size = New System.Drawing.Size(334, 21)
        Me.cboEmpresa.TabIndex = 1
        Me.cboEmpresa.UIName = "Campo de Empresa"
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.BackColor = System.Drawing.Color.Transparent
        Me.lblEmpresa.Location = New System.Drawing.Point(24, 16)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(51, 13)
        Me.lblEmpresa.TabIndex = 0
        Me.lblEmpresa.Text = "Empresa:"
        '
        'lblNombreCorto
        '
        Me.lblNombreCorto.AutoSize = True
        Me.lblNombreCorto.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreCorto.Location = New System.Drawing.Point(24, 43)
        Me.lblNombreCorto.Name = "lblNombreCorto"
        Me.lblNombreCorto.Size = New System.Drawing.Size(75, 13)
        Me.lblNombreCorto.TabIndex = 2
        Me.lblNombreCorto.Text = "Nombre Corto:"
        '
        'lblNombreLargo
        '
        Me.lblNombreLargo.AutoSize = True
        Me.lblNombreLargo.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreLargo.Location = New System.Drawing.Point(24, 69)
        Me.lblNombreLargo.Name = "lblNombreLargo"
        Me.lblNombreLargo.Size = New System.Drawing.Size(77, 13)
        Me.lblNombreLargo.TabIndex = 4
        Me.lblNombreLargo.Text = "Nombre Largo:"
        '
        'txtNombreCorto
        '
        Me.txtNombreCorto.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombreCorto.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombreCorto.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombreCorto.Location = New System.Drawing.Point(107, 40)
        Me.txtNombreCorto.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombreCorto.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombreCorto.Name = "txtNombreCorto"
        Me.txtNombreCorto.RequiredField = True
        Me.txtNombreCorto.Size = New System.Drawing.Size(334, 20)
        Me.txtNombreCorto.TabIndex = 3
        Me.txtNombreCorto.UIName = "Nombre Corto"
        '
        'txtNombreLargo
        '
        Me.txtNombreLargo.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombreLargo.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombreLargo.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombreLargo.Location = New System.Drawing.Point(107, 66)
        Me.txtNombreLargo.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombreLargo.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombreLargo.Name = "txtNombreLargo"
        Me.txtNombreLargo.Size = New System.Drawing.Size(334, 20)
        Me.txtNombreLargo.TabIndex = 5
        Me.txtNombreLargo.UIName = "Nombre Largo"
        '
        'txtPoblacion
        '
        Me.txtPoblacion.AnySite = False
        Me.txtPoblacion.AutoClear = False
        Me.txtPoblacion.AutoLock = False
        Me.txtPoblacion.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtPoblacion.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtPoblacion.EditorAssembly = "Azteca.Windows"
        Me.txtPoblacion.EditorClass = "Azteca.Windows.Forms.General.CatalogoPoblaciones"
        Me.txtPoblacion.EditorTitle = "Editar población..."
        Me.txtPoblacion.Key = 0
        Me.txtPoblacion.Linked = False
        Me.txtPoblacion.Location = New System.Drawing.Point(150, 135)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.RequiredField = True
        Me.txtPoblacion.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.txtPoblacion.Size = New System.Drawing.Size(300, 23)
        Me.txtPoblacion.TabIndex = 11
        Me.txtPoblacion.TextWidth = 70
        Me.txtPoblacion.UIName = "Población"
        '
        'txtCP
        '
        Me.txtCP.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCP.Digits = True
        Me.txtCP.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCP.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCP.Location = New System.Drawing.Point(150, 109)
        Me.txtCP.MaxLength = 5
        Me.txtCP.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCP.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(70, 20)
        Me.txtCP.TabIndex = 9
        Me.txtCP.UIName = Nothing
        '
        'txtColonia
        '
        Me.txtColonia.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtColonia.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtColonia.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtColonia.Location = New System.Drawing.Point(150, 83)
        Me.txtColonia.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColonia.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(300, 20)
        Me.txtColonia.TabIndex = 7
        Me.txtColonia.UIName = Nothing
        '
        'txtNumInt
        '
        Me.txtNumInt.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNumInt.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNumInt.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumInt.Location = New System.Drawing.Point(297, 57)
        Me.txtNumInt.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumInt.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumInt.Name = "txtNumInt"
        Me.txtNumInt.Size = New System.Drawing.Size(70, 20)
        Me.txtNumInt.TabIndex = 5
        Me.txtNumInt.UIName = Nothing
        '
        'txtNumExt
        '
        Me.txtNumExt.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNumExt.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNumExt.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumExt.Location = New System.Drawing.Point(150, 57)
        Me.txtNumExt.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExt.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExt.Name = "txtNumExt"
        Me.txtNumExt.Size = New System.Drawing.Size(70, 20)
        Me.txtNumExt.TabIndex = 3
        Me.txtNumExt.UIName = Nothing
        '
        'txtCalle
        '
        Me.txtCalle.BackColor = System.Drawing.SystemColors.Window
        Me.txtCalle.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCalle.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCalle.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCalle.Location = New System.Drawing.Point(150, 31)
        Me.txtCalle.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalle.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(300, 20)
        Me.txtCalle.TabIndex = 1
        Me.txtCalle.UIName = Nothing
        '
        'lblPoblacion
        '
        Me.lblPoblacion.AutoSize = True
        Me.lblPoblacion.BackColor = System.Drawing.Color.Transparent
        Me.lblPoblacion.Location = New System.Drawing.Point(69, 141)
        Me.lblPoblacion.Name = "lblPoblacion"
        Me.lblPoblacion.Size = New System.Drawing.Size(57, 13)
        Me.lblPoblacion.TabIndex = 10
        Me.lblPoblacion.Text = "Población:"
        '
        'lblCodigoPostal
        '
        Me.lblCodigoPostal.AutoSize = True
        Me.lblCodigoPostal.BackColor = System.Drawing.Color.Transparent
        Me.lblCodigoPostal.Location = New System.Drawing.Point(69, 112)
        Me.lblCodigoPostal.Name = "lblCodigoPostal"
        Me.lblCodigoPostal.Size = New System.Drawing.Size(75, 13)
        Me.lblCodigoPostal.TabIndex = 8
        Me.lblCodigoPostal.Text = "Código Postal:"
        '
        'lblNumInt
        '
        Me.lblNumInt.AutoSize = True
        Me.lblNumInt.BackColor = System.Drawing.Color.Transparent
        Me.lblNumInt.Location = New System.Drawing.Point(229, 57)
        Me.lblNumInt.Name = "lblNumInt"
        Me.lblNumInt.Size = New System.Drawing.Size(62, 13)
        Me.lblNumInt.TabIndex = 4
        Me.lblNumInt.Text = "No. Interior:"
        '
        'lblNumExt
        '
        Me.lblNumExt.AutoSize = True
        Me.lblNumExt.BackColor = System.Drawing.Color.Transparent
        Me.lblNumExt.Location = New System.Drawing.Point(69, 60)
        Me.lblNumExt.Name = "lblNumExt"
        Me.lblNumExt.Size = New System.Drawing.Size(65, 13)
        Me.lblNumExt.TabIndex = 2
        Me.lblNumExt.Text = "No. Exterior:"
        '
        'lblColonia
        '
        Me.lblColonia.AutoSize = True
        Me.lblColonia.BackColor = System.Drawing.Color.Transparent
        Me.lblColonia.Location = New System.Drawing.Point(69, 86)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(45, 13)
        Me.lblColonia.TabIndex = 6
        Me.lblColonia.Text = "Colonia:"
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.BackColor = System.Drawing.Color.Transparent
        Me.lblCalle.Location = New System.Drawing.Point(69, 34)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(33, 13)
        Me.lblCalle.TabIndex = 0
        Me.lblCalle.Text = "Calle:"
        '
        'CiLabel15
        '
        Me.CiLabel15.AutoSize = True
        Me.CiLabel15.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel15.Location = New System.Drawing.Point(22, 46)
        Me.CiLabel15.Name = "CiLabel15"
        Me.CiLabel15.Size = New System.Drawing.Size(162, 13)
        Me.CiLabel15.TabIndex = 5
        Me.CiLabel15.Text = "Cliente Genérico de Facturación:"
        '
        'cboFormatoFactura
        '
        Me.cboFormatoFactura.BackColor = System.Drawing.SystemColors.Window
        Me.cboFormatoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormatoFactura.FormattingEnabled = True
        Me.cboFormatoFactura.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboFormatoFactura.ItemsTable = Nothing
        Me.cboFormatoFactura.Location = New System.Drawing.Point(190, 16)
        Me.cboFormatoFactura.Name = "cboFormatoFactura"
        Me.cboFormatoFactura.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboFormatoFactura.Size = New System.Drawing.Size(293, 21)
        Me.cboFormatoFactura.TabIndex = 1
        Me.cboFormatoFactura.UIName = "Formato Factura"
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel1.Location = New System.Drawing.Point(22, 19)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(102, 13)
        Me.CiLabel1.TabIndex = 0
        Me.CiLabel1.Text = "Formato de Factura:"
        '
        'txtSerieFact
        '
        Me.txtSerieFact.AnySite = False
        Me.txtSerieFact.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtSerieFact.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtSerieFact.EditorAssembly = "Azteca.ContabilidadWin"
        Me.txtSerieFact.EditorClass = "Azteca.Windows.Contabilidad.SeriesForm"
        Me.txtSerieFact.EditorTitle = "Editar serie de comprobantes fiscales..."
        Me.txtSerieFact.Key = 0
        Me.txtSerieFact.Linked = False
        Me.txtSerieFact.Location = New System.Drawing.Point(190, 72)
        Me.txtSerieFact.Name = "txtSerieFact"
        Me.txtSerieFact.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.txtSerieFact.Size = New System.Drawing.Size(293, 23)
        Me.txtSerieFact.TabIndex = 3
        Me.txtSerieFact.UIName = "Serie Facturas"
        '
        'CiLabel17
        '
        Me.CiLabel17.AutoSize = True
        Me.CiLabel17.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel17.Location = New System.Drawing.Point(22, 80)
        Me.CiLabel17.Name = "CiLabel17"
        Me.CiLabel17.Size = New System.Drawing.Size(34, 13)
        Me.CiLabel17.TabIndex = 2
        Me.CiLabel17.Text = "Serie:"
        '
        'CiGroupBox2
        '
        Me.CiGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.CiGroupBox2.Controls.Add(Me.cboRegion)
        Me.CiGroupBox2.Controls.Add(Me.cboDivisaBase)
        Me.CiGroupBox2.Controls.Add(Me.txtGLN)
        Me.CiGroupBox2.Controls.Add(Me.CiLabel16)
        Me.CiGroupBox2.Controls.Add(Me.cboZonaVenta)
        Me.CiGroupBox2.Controls.Add(Me.CiLabel7)
        Me.CiGroupBox2.Controls.Add(Me.CiLabel12)
        Me.CiGroupBox2.Controls.Add(Me.CiLabel13)
        Me.CiGroupBox2.Location = New System.Drawing.Point(27, 9)
        Me.CiGroupBox2.Name = "CiGroupBox2"
        Me.CiGroupBox2.Size = New System.Drawing.Size(515, 139)
        Me.CiGroupBox2.TabIndex = 0
        Me.CiGroupBox2.TabStop = False
        '
        'cboRegion
        '
        Me.cboRegion.BackColor = System.Drawing.SystemColors.Window
        Me.cboRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRegion.FormattingEnabled = True
        Me.cboRegion.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboRegion.ItemsTable = Nothing
        Me.cboRegion.Location = New System.Drawing.Point(106, 19)
        Me.cboRegion.Name = "cboRegion"
        Me.cboRegion.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboRegion.Size = New System.Drawing.Size(239, 21)
        Me.cboRegion.TabIndex = 1
        Me.cboRegion.UIName = "Región"
        '
        'cboDivisaBase
        '
        Me.cboDivisaBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDivisaBase.FormattingEnabled = True
        Me.cboDivisaBase.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboDivisaBase.ItemsTable = Nothing
        Me.cboDivisaBase.Location = New System.Drawing.Point(106, 99)
        Me.cboDivisaBase.Name = "cboDivisaBase"
        Me.cboDivisaBase.RequiredField = True
        Me.cboDivisaBase.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboDivisaBase.Size = New System.Drawing.Size(239, 21)
        Me.cboDivisaBase.TabIndex = 7
        Me.cboDivisaBase.UIName = "Divisa Base"
        '
        'txtGLN
        '
        Me.txtGLN.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtGLN.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtGLN.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtGLN.Location = New System.Drawing.Point(106, 73)
        Me.txtGLN.MaxLength = 13
        Me.txtGLN.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtGLN.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtGLN.Name = "txtGLN"
        Me.txtGLN.Size = New System.Drawing.Size(239, 20)
        Me.txtGLN.TabIndex = 5
        '
        'CiLabel16
        '
        Me.CiLabel16.AutoSize = True
        Me.CiLabel16.Location = New System.Drawing.Point(14, 76)
        Me.CiLabel16.Name = "CiLabel16"
        Me.CiLabel16.Size = New System.Drawing.Size(32, 13)
        Me.CiLabel16.TabIndex = 4
        Me.CiLabel16.Text = "GLN:"
        '
        'cboZonaVenta
        '
        Me.cboZonaVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboZonaVenta.FormattingEnabled = True
        Me.cboZonaVenta.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboZonaVenta.ItemsTable = Nothing
        Me.cboZonaVenta.Location = New System.Drawing.Point(106, 46)
        Me.cboZonaVenta.Name = "cboZonaVenta"
        Me.cboZonaVenta.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboZonaVenta.Size = New System.Drawing.Size(239, 21)
        Me.cboZonaVenta.TabIndex = 3
        Me.cboZonaVenta.UIName = "Zona Ventas"
        '
        'CiLabel7
        '
        Me.CiLabel7.AutoSize = True
        Me.CiLabel7.Location = New System.Drawing.Point(14, 102)
        Me.CiLabel7.Name = "CiLabel7"
        Me.CiLabel7.Size = New System.Drawing.Size(66, 13)
        Me.CiLabel7.TabIndex = 6
        Me.CiLabel7.Text = "Divisa Base:"
        '
        'CiLabel12
        '
        Me.CiLabel12.AutoSize = True
        Me.CiLabel12.Location = New System.Drawing.Point(14, 22)
        Me.CiLabel12.Name = "CiLabel12"
        Me.CiLabel12.Size = New System.Drawing.Size(44, 13)
        Me.CiLabel12.TabIndex = 0
        Me.CiLabel12.Text = "Región:"
        '
        'CiLabel13
        '
        Me.CiLabel13.AutoSize = True
        Me.CiLabel13.Location = New System.Drawing.Point(14, 49)
        Me.CiLabel13.Name = "CiLabel13"
        Me.CiLabel13.Size = New System.Drawing.Size(86, 13)
        Me.CiLabel13.TabIndex = 2
        Me.CiLabel13.Text = "Zona de Ventas:"
        '
        'grpTipoPrecio
        '
        Me.grpTipoPrecio.BackColor = System.Drawing.Color.Transparent
        Me.grpTipoPrecio.Controls.Add(Me.rdbZonasVenta)
        Me.grpTipoPrecio.Controls.Add(Me.rdbListaPrecio)
        Me.grpTipoPrecio.Location = New System.Drawing.Point(27, 154)
        Me.grpTipoPrecio.Name = "grpTipoPrecio"
        Me.grpTipoPrecio.Size = New System.Drawing.Size(220, 78)
        Me.grpTipoPrecio.TabIndex = 1
        Me.grpTipoPrecio.TabStop = False
        Me.grpTipoPrecio.Text = "Modalidad de Precios"
        '
        'rdbZonasVenta
        '
        Me.rdbZonasVenta.AutoSize = True
        Me.rdbZonasVenta.Location = New System.Drawing.Point(17, 42)
        Me.rdbZonasVenta.Name = "rdbZonasVenta"
        Me.rdbZonasVenta.Size = New System.Drawing.Size(195, 17)
        Me.rdbZonasVenta.TabIndex = 1
        Me.rdbZonasVenta.Text = "Utilizar precios de la zona de ventas"
        Me.rdbZonasVenta.UseVisualStyleBackColor = True
        '
        'rdbListaPrecio
        '
        Me.rdbListaPrecio.AutoSize = True
        Me.rdbListaPrecio.Checked = True
        Me.rdbListaPrecio.Location = New System.Drawing.Point(17, 19)
        Me.rdbListaPrecio.Name = "rdbListaPrecio"
        Me.rdbListaPrecio.Size = New System.Drawing.Size(129, 17)
        Me.rdbListaPrecio.TabIndex = 0
        Me.rdbListaPrecio.TabStop = True
        Me.rdbListaPrecio.Text = "Utilizar lista de precios"
        Me.rdbListaPrecio.UseVisualStyleBackColor = True
        '
        'txtSerieDev
        '
        Me.txtSerieDev.AnySite = False
        Me.txtSerieDev.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtSerieDev.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtSerieDev.EditorAssembly = "Azteca.ContabilidadWin"
        Me.txtSerieDev.EditorClass = "Azteca.Windows.Contabilidad.SeriesForm"
        Me.txtSerieDev.EditorTitle = "Editar serie de comprobantes fiscales..."
        Me.txtSerieDev.Key = 0
        Me.txtSerieDev.Linked = False
        Me.txtSerieDev.Location = New System.Drawing.Point(157, 44)
        Me.txtSerieDev.Name = "txtSerieDev"
        Me.txtSerieDev.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.txtSerieDev.Size = New System.Drawing.Size(252, 23)
        Me.txtSerieDev.TabIndex = 3
        Me.txtSerieDev.UIName = "Serie Devoluciones"
        '
        'CiLabel5
        '
        Me.CiLabel5.AutoSize = True
        Me.CiLabel5.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel5.Location = New System.Drawing.Point(20, 44)
        Me.CiLabel5.Name = "CiLabel5"
        Me.CiLabel5.Size = New System.Drawing.Size(34, 13)
        Me.CiLabel5.TabIndex = 2
        Me.CiLabel5.Text = "Serie:"
        '
        'cboFormatoDev
        '
        Me.cboFormatoDev.BackColor = System.Drawing.SystemColors.Window
        Me.cboFormatoDev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormatoDev.FormattingEnabled = True
        Me.cboFormatoDev.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboFormatoDev.ItemsTable = Nothing
        Me.cboFormatoDev.Location = New System.Drawing.Point(157, 17)
        Me.cboFormatoDev.Name = "cboFormatoDev"
        Me.cboFormatoDev.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboFormatoDev.Size = New System.Drawing.Size(252, 21)
        Me.cboFormatoDev.TabIndex = 1
        Me.cboFormatoDev.UIName = "Formato Devoluciones"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel2.Location = New System.Drawing.Point(20, 20)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(131, 13)
        Me.CiLabel2.TabIndex = 0
        Me.CiLabel2.Text = "Formato de Devoluciones:"
        '
        'grpModoAfectacion
        '
        Me.grpModoAfectacion.BackColor = System.Drawing.Color.Transparent
        Me.grpModoAfectacion.Controls.Add(Me.rdbAfectInvBatch)
        Me.grpModoAfectacion.Controls.Add(Me.rdbAfectInvLinea)
        Me.grpModoAfectacion.Enabled = False
        Me.grpModoAfectacion.Location = New System.Drawing.Point(23, 66)
        Me.grpModoAfectacion.Name = "grpModoAfectacion"
        Me.grpModoAfectacion.Size = New System.Drawing.Size(289, 77)
        Me.grpModoAfectacion.TabIndex = 2
        Me.grpModoAfectacion.TabStop = False
        Me.grpModoAfectacion.Text = "Modo de Afectación"
        '
        'rdbAfectInvBatch
        '
        Me.rdbAfectInvBatch.AutoSize = True
        Me.rdbAfectInvBatch.Location = New System.Drawing.Point(32, 42)
        Me.rdbAfectInvBatch.Name = "rdbAfectInvBatch"
        Me.rdbAfectInvBatch.Size = New System.Drawing.Size(151, 17)
        Me.rdbAfectInvBatch.TabIndex = 1
        Me.rdbAfectInvBatch.Text = "Afectar inventario por lotes"
        Me.rdbAfectInvBatch.UseVisualStyleBackColor = True
        '
        'rdbAfectInvLinea
        '
        Me.rdbAfectInvLinea.AutoSize = True
        Me.rdbAfectInvLinea.Checked = True
        Me.rdbAfectInvLinea.Location = New System.Drawing.Point(32, 19)
        Me.rdbAfectInvLinea.Name = "rdbAfectInvLinea"
        Me.rdbAfectInvLinea.Size = New System.Drawing.Size(150, 17)
        Me.rdbAfectInvLinea.TabIndex = 0
        Me.rdbAfectInvLinea.TabStop = True
        Me.rdbAfectInvLinea.Text = "Afectar inventario en línea"
        Me.rdbAfectInvLinea.UseVisualStyleBackColor = True
        '
        'cboAlmacen
        '
        Me.cboAlmacen.AutoLock = False
        Me.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacen.FormattingEnabled = True
        Me.cboAlmacen.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboAlmacen.ItemsTable = Nothing
        Me.cboAlmacen.Location = New System.Drawing.Point(23, 39)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboAlmacen.Size = New System.Drawing.Size(289, 21)
        Me.cboAlmacen.TabIndex = 1
        Me.cboAlmacen.UIName = Nothing
        '
        'chkAfectarInv
        '
        Me.chkAfectarInv.AutoSize = True
        Me.chkAfectarInv.BackColor = System.Drawing.Color.Transparent
        Me.chkAfectarInv.Location = New System.Drawing.Point(23, 16)
        Me.chkAfectarInv.Name = "chkAfectarInv"
        Me.chkAfectarInv.Size = New System.Drawing.Size(193, 17)
        Me.chkAfectarInv.TabIndex = 0
        Me.chkAfectarInv.Text = "Descontar existencias del almacén:"
        Me.chkAfectarInv.UseVisualStyleBackColor = False
        '
        'grpNotificaciones
        '
        Me.grpNotificaciones.BackColor = System.Drawing.Color.Transparent
        Me.grpNotificaciones.Controls.Add(Me.CiGroupBox1)
        Me.grpNotificaciones.Controls.Add(Me.CiLabel4)
        Me.grpNotificaciones.Controls.Add(Me.chkEnviarFact)
        Me.grpNotificaciones.Location = New System.Drawing.Point(27, 41)
        Me.grpNotificaciones.Name = "grpNotificaciones"
        Me.grpNotificaciones.Size = New System.Drawing.Size(390, 207)
        Me.grpNotificaciones.TabIndex = 2
        Me.grpNotificaciones.TabStop = False
        Me.grpNotificaciones.Text = "Notificaciones"
        '
        'CiGroupBox1
        '
        Me.CiGroupBox1.Controls.Add(Me.CiLabel6)
        Me.CiGroupBox1.Controls.Add(Me.nudPorcentajeFolios)
        Me.CiGroupBox1.Controls.Add(Me.CiCheckBox3)
        Me.CiGroupBox1.Controls.Add(Me.CiCheckBox2)
        Me.CiGroupBox1.Location = New System.Drawing.Point(21, 83)
        Me.CiGroupBox1.Name = "CiGroupBox1"
        Me.CiGroupBox1.Size = New System.Drawing.Size(348, 99)
        Me.CiGroupBox1.TabIndex = 2
        Me.CiGroupBox1.TabStop = False
        Me.CiGroupBox1.Text = "Notificaciones del operador"
        '
        'CiLabel6
        '
        Me.CiLabel6.AutoSize = True
        Me.CiLabel6.Location = New System.Drawing.Point(236, 56)
        Me.CiLabel6.Name = "CiLabel6"
        Me.CiLabel6.Size = New System.Drawing.Size(15, 13)
        Me.CiLabel6.TabIndex = 1
        Me.CiLabel6.Text = "%"
        '
        'nudPorcentajeFolios
        '
        Me.nudPorcentajeFolios.HighlightColor = System.Drawing.SystemColors.Info
        Me.nudPorcentajeFolios.Location = New System.Drawing.Point(185, 54)
        Me.nudPorcentajeFolios.Minimum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nudPorcentajeFolios.Name = "nudPorcentajeFolios"
        Me.nudPorcentajeFolios.Size = New System.Drawing.Size(45, 20)
        Me.nudPorcentajeFolios.TabIndex = 0
        Me.nudPorcentajeFolios.Value = New Decimal(New Integer() {90, 0, 0, 0})
        '
        'CiCheckBox3
        '
        Me.CiCheckBox3.AutoSize = True
        Me.CiCheckBox3.Location = New System.Drawing.Point(27, 57)
        Me.CiCheckBox3.Name = "CiCheckBox3"
        Me.CiCheckBox3.Size = New System.Drawing.Size(152, 17)
        Me.CiCheckBox3.TabIndex = 3
        Me.CiCheckBox3.Text = "Notificar folios utilizados al:"
        Me.CiCheckBox3.UseVisualStyleBackColor = True
        '
        'CiCheckBox2
        '
        Me.CiCheckBox2.AutoSize = True
        Me.CiCheckBox2.Location = New System.Drawing.Point(27, 34)
        Me.CiCheckBox2.Name = "CiCheckBox2"
        Me.CiCheckBox2.Size = New System.Drawing.Size(150, 17)
        Me.CiCheckBox2.TabIndex = 1
        Me.CiCheckBox2.Text = "Notificar envio de facturas"
        Me.CiCheckBox2.UseVisualStyleBackColor = True
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.Location = New System.Drawing.Point(18, 67)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(105, 13)
        Me.CiLabel4.TabIndex = 1
        Me.CiLabel4.Text = "Notificar al operador:"
        '
        'chkEnviarFact
        '
        Me.chkEnviarFact.AutoSize = True
        Me.chkEnviarFact.Location = New System.Drawing.Point(21, 29)
        Me.chkEnviarFact.Name = "chkEnviarFact"
        Me.chkEnviarFact.Size = New System.Drawing.Size(145, 17)
        Me.chkEnviarFact.TabIndex = 0
        Me.chkEnviarFact.Text = "Enviar facturas al cliente "
        Me.chkEnviarFact.UseVisualStyleBackColor = True
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel3.Location = New System.Drawing.Point(24, 17)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(141, 13)
        Me.CiLabel3.TabIndex = 0
        Me.CiLabel3.Text = "Remitente de notificaciones:"
        '
        'cboRemitente
        '
        Me.cboRemitente.AutoLock = False
        Me.cboRemitente.BackColor = System.Drawing.SystemColors.Window
        Me.cboRemitente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRemitente.FormattingEnabled = True
        Me.cboRemitente.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboRemitente.ItemsTable = Nothing
        Me.cboRemitente.Location = New System.Drawing.Point(171, 14)
        Me.cboRemitente.Name = "cboRemitente"
        Me.cboRemitente.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboRemitente.Size = New System.Drawing.Size(246, 21)
        Me.cboRemitente.TabIndex = 1
        Me.cboRemitente.UIName = Nothing
        '
        'cboTicketPOS
        '
        Me.cboTicketPOS.BackColor = System.Drawing.SystemColors.Window
        Me.cboTicketPOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTicketPOS.FormattingEnabled = True
        Me.cboTicketPOS.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboTicketPOS.ItemsTable = Nothing
        Me.cboTicketPOS.Location = New System.Drawing.Point(225, 17)
        Me.cboTicketPOS.Name = "cboTicketPOS"
        Me.cboTicketPOS.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboTicketPOS.Size = New System.Drawing.Size(230, 21)
        Me.cboTicketPOS.TabIndex = 7
        Me.cboTicketPOS.UIName = "Formato Factura"
        '
        'CiLabel10
        '
        Me.CiLabel10.AutoSize = True
        Me.CiLabel10.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel10.Location = New System.Drawing.Point(31, 19)
        Me.CiLabel10.Name = "CiLabel10"
        Me.CiLabel10.Size = New System.Drawing.Size(121, 13)
        Me.CiLabel10.TabIndex = 6
        Me.CiLabel10.Text = "Formato de Ticket POS:"
        '
        'cboTicketPedimento
        '
        Me.cboTicketPedimento.BackColor = System.Drawing.SystemColors.Window
        Me.cboTicketPedimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTicketPedimento.FormattingEnabled = True
        Me.cboTicketPedimento.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboTicketPedimento.ItemsTable = Nothing
        Me.cboTicketPedimento.Location = New System.Drawing.Point(225, 130)
        Me.cboTicketPedimento.Name = "cboTicketPedimento"
        Me.cboTicketPedimento.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboTicketPedimento.Size = New System.Drawing.Size(230, 21)
        Me.cboTicketPedimento.TabIndex = 5
        Me.cboTicketPedimento.UIName = "Formato Factura"
        '
        'CiLabel9
        '
        Me.CiLabel9.AutoSize = True
        Me.CiLabel9.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel9.Location = New System.Drawing.Point(31, 133)
        Me.CiLabel9.Name = "CiLabel9"
        Me.CiLabel9.Size = New System.Drawing.Size(164, 13)
        Me.CiLabel9.TabIndex = 4
        Me.CiLabel9.Text = "Formato de Ticket de Pedimento:"
        '
        'cboTicketComanda
        '
        Me.cboTicketComanda.BackColor = System.Drawing.SystemColors.Window
        Me.cboTicketComanda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTicketComanda.FormattingEnabled = True
        Me.cboTicketComanda.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboTicketComanda.ItemsTable = Nothing
        Me.cboTicketComanda.Location = New System.Drawing.Point(225, 103)
        Me.cboTicketComanda.Name = "cboTicketComanda"
        Me.cboTicketComanda.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboTicketComanda.Size = New System.Drawing.Size(230, 21)
        Me.cboTicketComanda.TabIndex = 3
        Me.cboTicketComanda.UIName = "Formato Factura"
        '
        'CiLabel8
        '
        Me.CiLabel8.AutoSize = True
        Me.CiLabel8.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel8.Location = New System.Drawing.Point(31, 105)
        Me.CiLabel8.Name = "CiLabel8"
        Me.CiLabel8.Size = New System.Drawing.Size(159, 13)
        Me.CiLabel8.TabIndex = 2
        Me.CiLabel8.Text = "Formato de Ticket de Comanda:"
        '
        'imlUN
        '
        Me.imlUN.ImageStream = CType(resources.GetObject("imlUN.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlUN.TransparentColor = System.Drawing.Color.Transparent
        Me.imlUN.Images.SetKeyName(0, "Domicilio")
        Me.imlUN.Images.SetKeyName(1, "General")
        Me.imlUN.Images.SetKeyName(2, "Facturacion")
        Me.imlUN.Images.SetKeyName(3, "Ventas")
        Me.imlUN.Images.SetKeyName(4, "Inventario")
        Me.imlUN.Images.SetKeyName(5, "Devoluciones")
        Me.imlUN.Images.SetKeyName(6, "Info")
        Me.imlUN.Images.SetKeyName(7, "cashbox_32.png")
        '
        'tabUnidadNegocio
        '
        Me.tabUnidadNegocio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabUnidadNegocio.Controls.Add(Me.pagGeneral)
        Me.tabUnidadNegocio.Controls.Add(Me.pagDomicilio)
        Me.tabUnidadNegocio.Controls.Add(Me.pagFacturacion)
        Me.tabUnidadNegocio.Controls.Add(Me.pagVentas)
        Me.tabUnidadNegocio.Controls.Add(Me.pagDevoluciones)
        Me.tabUnidadNegocio.Controls.Add(Me.pagInventario)
        Me.tabUnidadNegocio.Controls.Add(Me.pagNotificaciones)
        Me.tabUnidadNegocio.Controls.Add(Me.pagPuntoVenta)
        Me.tabUnidadNegocio.ImageList = Me.imlUN
        Me.tabUnidadNegocio.Location = New System.Drawing.Point(12, 89)
        Me.tabUnidadNegocio.MultiLine = True
        Me.tabUnidadNegocio.Name = "tabUnidadNegocio"
        Me.tabUnidadNegocio.SelectedIndex = 3
        Me.tabUnidadNegocio.Size = New System.Drawing.Size(634, 348)
        Me.tabUnidadNegocio.TabIndex = 32
        Me.tabUnidadNegocio.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabUnidadNegocio.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabUnidadNegocio.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagGeneral
        '
        Me.pagGeneral.Controls.Add(Me.lblEmpresa)
        Me.pagGeneral.Controls.Add(Me.txtPagWeb)
        Me.pagGeneral.Controls.Add(Me.txtNombreLargo)
        Me.pagGeneral.Controls.Add(Me.txtCorreo)
        Me.pagGeneral.Controls.Add(Me.txtNombreCorto)
        Me.pagGeneral.Controls.Add(Me.txtFax)
        Me.pagGeneral.Controls.Add(Me.lblNombreLargo)
        Me.pagGeneral.Controls.Add(Me.lblCorreo)
        Me.pagGeneral.Controls.Add(Me.lblNombreCorto)
        Me.pagGeneral.Controls.Add(Me.lblPagWeb)
        Me.pagGeneral.Controls.Add(Me.cboEmpresa)
        Me.pagGeneral.Controls.Add(Me.lblFax)
        Me.pagGeneral.Controls.Add(Me.lblTel1)
        Me.pagGeneral.Controls.Add(Me.lblTel2)
        Me.pagGeneral.Controls.Add(Me.txtTel1)
        Me.pagGeneral.Controls.Add(Me.txtTel2)
        Me.pagGeneral.ImageIndex = 1
        Me.pagGeneral.Location = New System.Drawing.Point(1, 79)
        Me.pagGeneral.Name = "pagGeneral"
        Me.pagGeneral.Size = New System.Drawing.Size(632, 268)
        Me.pagGeneral.TabIndex = 0
        Me.pagGeneral.Text = "Datos Generales"
        '
        'pagDomicilio
        '
        Me.pagDomicilio.Controls.Add(Me.txtPoblacion)
        Me.pagDomicilio.Controls.Add(Me.lblCalle)
        Me.pagDomicilio.Controls.Add(Me.txtCP)
        Me.pagDomicilio.Controls.Add(Me.lblColonia)
        Me.pagDomicilio.Controls.Add(Me.txtColonia)
        Me.pagDomicilio.Controls.Add(Me.lblNumExt)
        Me.pagDomicilio.Controls.Add(Me.txtNumInt)
        Me.pagDomicilio.Controls.Add(Me.lblNumInt)
        Me.pagDomicilio.Controls.Add(Me.txtNumExt)
        Me.pagDomicilio.Controls.Add(Me.lblCodigoPostal)
        Me.pagDomicilio.Controls.Add(Me.txtCalle)
        Me.pagDomicilio.Controls.Add(Me.lblPoblacion)
        Me.pagDomicilio.ImageIndex = 0
        Me.pagDomicilio.Location = New System.Drawing.Point(1, 79)
        Me.pagDomicilio.Name = "pagDomicilio"
        Me.pagDomicilio.Size = New System.Drawing.Size(632, 268)
        Me.pagDomicilio.TabIndex = 1
        Me.pagDomicilio.Text = "Domicilio"
        '
        'pagFacturacion
        '
        Me.pagFacturacion.Controls.Add(Me.txtClienteGenFact)
        Me.pagFacturacion.Controls.Add(Me.CiLabel1)
        Me.pagFacturacion.Controls.Add(Me.CiLabel15)
        Me.pagFacturacion.Controls.Add(Me.CiLabel17)
        Me.pagFacturacion.Controls.Add(Me.cboFormatoFactura)
        Me.pagFacturacion.Controls.Add(Me.txtSerieFact)
        Me.pagFacturacion.ImageIndex = 2
        Me.pagFacturacion.Location = New System.Drawing.Point(1, 79)
        Me.pagFacturacion.Name = "pagFacturacion"
        Me.pagFacturacion.Size = New System.Drawing.Size(632, 268)
        Me.pagFacturacion.TabIndex = 2
        Me.pagFacturacion.Text = "Facturación"
        '
        'txtClienteGenFact
        '
        Me.txtClienteGenFact.AnySite = False
        Me.txtClienteGenFact.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtClienteGenFact.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtClienteGenFact.EditorAssembly = "Azteca.VentasWin"
        Me.txtClienteGenFact.EditorClass = "Azteca.Windows.Ventas.ClientesForm"
        Me.txtClienteGenFact.EditorTitle = "Editar datos de cliente..."
        Me.txtClienteGenFact.Key = 0
        Me.txtClienteGenFact.Linked = False
        Me.txtClienteGenFact.Location = New System.Drawing.Point(190, 43)
        Me.txtClienteGenFact.Name = "txtClienteGenFact"
        Me.txtClienteGenFact.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.txtClienteGenFact.Size = New System.Drawing.Size(293, 23)
        Me.txtClienteGenFact.TabIndex = 6
        '
        'pagVentas
        '
        Me.pagVentas.Controls.Add(Me.grpPoliticaDescuento)
        Me.pagVentas.Controls.Add(Me.CiLabel11)
        Me.pagVentas.Controls.Add(Me.CiGroupBox2)
        Me.pagVentas.Controls.Add(Me.grpTipoPrecio)
        Me.pagVentas.Controls.Add(Me.txtClienteGen)
        Me.pagVentas.ImageIndex = 3
        Me.pagVentas.Location = New System.Drawing.Point(1, 79)
        Me.pagVentas.Name = "pagVentas"
        Me.pagVentas.Size = New System.Drawing.Size(632, 268)
        Me.pagVentas.TabIndex = 3
        Me.pagVentas.Text = "Ventas"
        '
        'grpPoliticaDescuento
        '
        Me.grpPoliticaDescuento.BackColor = System.Drawing.Color.Transparent
        Me.grpPoliticaDescuento.Controls.Add(Me.rdbDescDespImp)
        Me.grpPoliticaDescuento.Controls.Add(Me.rdbDescAntesImp)
        Me.grpPoliticaDescuento.Location = New System.Drawing.Point(253, 154)
        Me.grpPoliticaDescuento.Name = "grpPoliticaDescuento"
        Me.grpPoliticaDescuento.Size = New System.Drawing.Size(289, 78)
        Me.grpPoliticaDescuento.TabIndex = 4
        Me.grpPoliticaDescuento.TabStop = False
        Me.grpPoliticaDescuento.Text = "Política de Descuentos"
        '
        'rdbDescDespImp
        '
        Me.rdbDescDespImp.AutoSize = True
        Me.rdbDescDespImp.Checked = True
        Me.rdbDescDespImp.Location = New System.Drawing.Point(26, 42)
        Me.rdbDescDespImp.Name = "rdbDescDespImp"
        Me.rdbDescDespImp.Size = New System.Drawing.Size(201, 17)
        Me.rdbDescDespImp.TabIndex = 1
        Me.rdbDescDespImp.TabStop = True
        Me.rdbDescDespImp.Text = "Descuentos DESPUES de impuestos"
        Me.rdbDescDespImp.UseVisualStyleBackColor = True
        '
        'rdbDescAntesImp
        '
        Me.rdbDescAntesImp.AutoSize = True
        Me.rdbDescAntesImp.Location = New System.Drawing.Point(26, 19)
        Me.rdbDescAntesImp.Name = "rdbDescAntesImp"
        Me.rdbDescAntesImp.Size = New System.Drawing.Size(186, 17)
        Me.rdbDescAntesImp.TabIndex = 0
        Me.rdbDescAntesImp.Text = "Descuentos ANTES de impuestos"
        Me.rdbDescAntesImp.UseVisualStyleBackColor = True
        '
        'CiLabel11
        '
        Me.CiLabel11.AutoSize = True
        Me.CiLabel11.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel11.Location = New System.Drawing.Point(24, 244)
        Me.CiLabel11.Name = "CiLabel11"
        Me.CiLabel11.Size = New System.Drawing.Size(88, 13)
        Me.CiLabel11.TabIndex = 3
        Me.CiLabel11.Text = "Cliente Genérico:"
        '
        'txtClienteGen
        '
        Me.txtClienteGen.AnySite = False
        Me.txtClienteGen.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtClienteGen.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtClienteGen.EditorAssembly = "Azteca.VentasWin"
        Me.txtClienteGen.EditorClass = "Azteca.Windows.Ventas.ClientesForm"
        Me.txtClienteGen.EditorTitle = "Editar datos de cliente..."
        Me.txtClienteGen.Key = 0
        Me.txtClienteGen.Linked = False
        Me.txtClienteGen.Location = New System.Drawing.Point(118, 238)
        Me.txtClienteGen.Name = "txtClienteGen"
        Me.txtClienteGen.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.txtClienteGen.Size = New System.Drawing.Size(308, 23)
        Me.txtClienteGen.TabIndex = 2
        '
        'pagDevoluciones
        '
        Me.pagDevoluciones.Controls.Add(Me.txtSerieDev)
        Me.pagDevoluciones.Controls.Add(Me.CiLabel2)
        Me.pagDevoluciones.Controls.Add(Me.CiLabel5)
        Me.pagDevoluciones.Controls.Add(Me.cboFormatoDev)
        Me.pagDevoluciones.ImageIndex = 5
        Me.pagDevoluciones.Location = New System.Drawing.Point(1, 79)
        Me.pagDevoluciones.Name = "pagDevoluciones"
        Me.pagDevoluciones.Size = New System.Drawing.Size(632, 268)
        Me.pagDevoluciones.TabIndex = 4
        Me.pagDevoluciones.Text = "Devoluciones"
        '
        'pagInventario
        '
        Me.pagInventario.Controls.Add(Me.grpModoAfectacion)
        Me.pagInventario.Controls.Add(Me.chkAfectarInv)
        Me.pagInventario.Controls.Add(Me.cboAlmacen)
        Me.pagInventario.ImageIndex = 4
        Me.pagInventario.Location = New System.Drawing.Point(1, 79)
        Me.pagInventario.Name = "pagInventario"
        Me.pagInventario.Size = New System.Drawing.Size(632, 268)
        Me.pagInventario.TabIndex = 5
        Me.pagInventario.Text = "Inventario"
        '
        'pagNotificaciones
        '
        Me.pagNotificaciones.Controls.Add(Me.grpNotificaciones)
        Me.pagNotificaciones.Controls.Add(Me.CiLabel3)
        Me.pagNotificaciones.Controls.Add(Me.cboRemitente)
        Me.pagNotificaciones.ImageIndex = 6
        Me.pagNotificaciones.Location = New System.Drawing.Point(1, 79)
        Me.pagNotificaciones.Name = "pagNotificaciones"
        Me.pagNotificaciones.Size = New System.Drawing.Size(632, 268)
        Me.pagNotificaciones.TabIndex = 6
        Me.pagNotificaciones.Text = "Notificaciones"
        '
        'pagPuntoVenta
        '
        Me.pagPuntoVenta.Controls.Add(Me.cboFormatoUbicacionPOS)
        Me.pagPuntoVenta.Controls.Add(Me.lblFormatoUbicacionPOS)
        Me.pagPuntoVenta.Controls.Add(Me.cboFormatoCortePOS)
        Me.pagPuntoVenta.Controls.Add(Me.CiLabel14)
        Me.pagPuntoVenta.Controls.Add(Me.cboTicketPOS)
        Me.pagPuntoVenta.Controls.Add(Me.CiLabel10)
        Me.pagPuntoVenta.Controls.Add(Me.CiLabel8)
        Me.pagPuntoVenta.Controls.Add(Me.cboTicketPedimento)
        Me.pagPuntoVenta.Controls.Add(Me.cboTicketComanda)
        Me.pagPuntoVenta.Controls.Add(Me.CiLabel9)
        Me.pagPuntoVenta.ImageIndex = 7
        Me.pagPuntoVenta.Location = New System.Drawing.Point(1, 79)
        Me.pagPuntoVenta.Name = "pagPuntoVenta"
        Me.pagPuntoVenta.Size = New System.Drawing.Size(632, 268)
        Me.pagPuntoVenta.TabIndex = 7
        Me.pagPuntoVenta.Text = "Punto de Venta"
        '
        'cboFormatoCortePOS
        '
        Me.cboFormatoCortePOS.BackColor = System.Drawing.SystemColors.Window
        Me.cboFormatoCortePOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormatoCortePOS.FormattingEnabled = True
        Me.cboFormatoCortePOS.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboFormatoCortePOS.ItemsTable = Nothing
        Me.cboFormatoCortePOS.Location = New System.Drawing.Point(225, 47)
        Me.cboFormatoCortePOS.Name = "cboFormatoCortePOS"
        Me.cboFormatoCortePOS.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboFormatoCortePOS.Size = New System.Drawing.Size(230, 21)
        Me.cboFormatoCortePOS.TabIndex = 9
        Me.cboFormatoCortePOS.UIName = "Formato Factura"
        '
        'CiLabel14
        '
        Me.CiLabel14.AutoSize = True
        Me.CiLabel14.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel14.Location = New System.Drawing.Point(31, 49)
        Me.CiLabel14.Name = "CiLabel14"
        Me.CiLabel14.Size = New System.Drawing.Size(116, 13)
        Me.CiLabel14.TabIndex = 8
        Me.CiLabel14.Text = "Formato de Corte POS:"
        '
        'cboFormatoUbicacionPOS
        '
        Me.cboFormatoUbicacionPOS.BackColor = System.Drawing.SystemColors.Window
        Me.cboFormatoUbicacionPOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormatoUbicacionPOS.FormattingEnabled = True
        Me.cboFormatoUbicacionPOS.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboFormatoUbicacionPOS.ItemsTable = Nothing
        Me.cboFormatoUbicacionPOS.Location = New System.Drawing.Point(225, 76)
        Me.cboFormatoUbicacionPOS.Name = "cboFormatoUbicacionPOS"
        Me.cboFormatoUbicacionPOS.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboFormatoUbicacionPOS.Size = New System.Drawing.Size(230, 21)
        Me.cboFormatoUbicacionPOS.TabIndex = 11
        Me.cboFormatoUbicacionPOS.UIName = "Formato Factura"
        '
        'lblFormatoUbicacionPOS
        '
        Me.lblFormatoUbicacionPOS.AutoSize = True
        Me.lblFormatoUbicacionPOS.BackColor = System.Drawing.Color.Transparent
        Me.lblFormatoUbicacionPOS.Location = New System.Drawing.Point(31, 78)
        Me.lblFormatoUbicacionPOS.Name = "lblFormatoUbicacionPOS"
        Me.lblFormatoUbicacionPOS.Size = New System.Drawing.Size(187, 13)
        Me.lblFormatoUbicacionPOS.TabIndex = 10
        Me.lblFormatoUbicacionPOS.Text = "Formato de Ticket de Ubicacion POS:"
        '
        'UnidadesNegocioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 465)
        Me.Controls.Add(Me.tabUnidadNegocio)
        Me.KeyMode = Azteca.Windows.Forms.BusinessForms.CatalogForm.UserKeyMode.UserDefined
        Me.Name = "UnidadesNegocioForm"
        Me.Text = "UnidadesNegocioForm"
        Me.Controls.SetChildIndex(Me.tabUnidadNegocio, 0)
        Me.CiGroupBox2.ResumeLayout(False)
        Me.CiGroupBox2.PerformLayout()
        Me.grpTipoPrecio.ResumeLayout(False)
        Me.grpTipoPrecio.PerformLayout()
        Me.grpModoAfectacion.ResumeLayout(False)
        Me.grpModoAfectacion.PerformLayout()
        Me.grpNotificaciones.ResumeLayout(False)
        Me.grpNotificaciones.PerformLayout()
        Me.CiGroupBox1.ResumeLayout(False)
        Me.CiGroupBox1.PerformLayout()
        CType(Me.nudPorcentajeFolios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabUnidadNegocio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabUnidadNegocio.ResumeLayout(False)
        Me.pagGeneral.ResumeLayout(False)
        Me.pagGeneral.PerformLayout()
        Me.pagDomicilio.ResumeLayout(False)
        Me.pagDomicilio.PerformLayout()
        Me.pagFacturacion.ResumeLayout(False)
        Me.pagFacturacion.PerformLayout()
        Me.pagVentas.ResumeLayout(False)
        Me.pagVentas.PerformLayout()
        Me.grpPoliticaDescuento.ResumeLayout(False)
        Me.grpPoliticaDescuento.PerformLayout()
        Me.pagDevoluciones.ResumeLayout(False)
        Me.pagDevoluciones.PerformLayout()
        Me.pagInventario.ResumeLayout(False)
        Me.pagInventario.PerformLayout()
        Me.pagNotificaciones.ResumeLayout(False)
        Me.pagNotificaciones.PerformLayout()
        Me.pagPuntoVenta.ResumeLayout(False)
        Me.pagPuntoVenta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New Azteca.Business.Ventas.UnidadNegocioFacade
    End Sub
    Friend WithEvents txtPagWeb As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtCorreo As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtFax As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblCorreo As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblPagWeb As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblFax As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblTel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtTel2 As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtTel1 As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblTel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboEmpresa As Azteca.Windows.Controls.Security.EmpresasComboBox
    Friend WithEvents lblEmpresa As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblNombreCorto As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblNombreLargo As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNombreCorto As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtNombreLargo As Azteca.Windows.Controls.CITextBox
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
    Friend WithEvents imlUN As System.Windows.Forms.ImageList
    Friend WithEvents grpTipoPrecio As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents CiLabel13 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel12 As Azteca.Windows.Controls.CILabel
    Friend WithEvents rdbZonasVenta As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents rdbListaPrecio As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents cboZonaVenta As Azteca.Windows.Ventas.ZonasVentaComboBox
    Friend WithEvents cboRegion As Azteca.Windows.Ventas.RegionesComboBox
    Friend WithEvents CiLabel16 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtGLN As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel17 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtSerieFact As Azteca.Windows.Contabilidad.SerieSelector
    Friend WithEvents chkAfectarInv As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents cboFormatoFactura As Azteca.Windows.Controls.FormatosComboBox
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboFormatoDev As Azteca.Windows.Controls.FormatosComboBox
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtSerieDev As Azteca.Windows.Contabilidad.SerieSelector
    Friend WithEvents CiLabel5 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtClienteGenFact As Azteca.Windows.Ventas.ClienteSelector
    Friend WithEvents CiLabel15 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboRemitente As Azteca.Windows.Mail.RemitentesComboBox
    Friend WithEvents chkEnviarFact As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents grpNotificaciones As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents CiGroupBox1 As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents CiLabel6 As Azteca.Windows.Controls.CILabel
    Friend WithEvents nudPorcentajeFolios As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents CiCheckBox3 As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents CiCheckBox2 As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboDivisaBase As Azteca.Windows.Contabilidad.DivisasComboBox
    Friend WithEvents CiLabel7 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboTicketPOS As Azteca.Windows.Controls.FormatosComboBox
    Friend WithEvents CiLabel10 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboTicketPedimento As Azteca.Windows.Controls.FormatosComboBox
    Friend WithEvents CiLabel9 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboTicketComanda As Azteca.Windows.Controls.FormatosComboBox
    Friend WithEvents CiLabel8 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboAlmacen As Azteca.Windows.Inventario.AlmacenesComboBox
    Friend WithEvents CiGroupBox2 As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents grpModoAfectacion As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents rdbAfectInvBatch As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents rdbAfectInvLinea As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents tabUnidadNegocio As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagGeneral As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagDomicilio As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagFacturacion As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagVentas As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagDevoluciones As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagInventario As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagNotificaciones As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagPuntoVenta As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents CiLabel11 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtClienteGen As Azteca.Windows.Ventas.ClienteSelector
    Friend WithEvents cboFormatoCortePOS As Azteca.Windows.Controls.FormatosComboBox
    Friend WithEvents CiLabel14 As Azteca.Windows.Controls.CILabel
    Friend WithEvents grpPoliticaDescuento As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents rdbDescDespImp As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents rdbDescAntesImp As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents cboFormatoUbicacionPOS As Azteca.Windows.Controls.FormatosComboBox
    Friend WithEvents lblFormatoUbicacionPOS As Azteca.Windows.Controls.CILabel
End Class
