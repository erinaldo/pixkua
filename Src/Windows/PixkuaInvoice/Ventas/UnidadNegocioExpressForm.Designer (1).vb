<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnidadNegocioExpressForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UnidadNegocioExpressForm))
        Me.lblEmpresa = New Azteca.Windows.Controls.CILabel()
        Me.txtNombreCorto = New Azteca.Windows.Controls.CITextBox()
        Me.lblNombreCorto = New Azteca.Windows.Controls.CILabel()
        Me.cboEmpresa = New Azteca.Windows.Controls.Security.EmpresasComboBox()
        Me.txtPoblacion = New Azteca.Windows.Controls.General.PoblacionSelector()
        Me.lblCalle = New Azteca.Windows.Controls.CILabel()
        Me.txtCP = New Azteca.Windows.Controls.CITextBox()
        Me.lblColonia = New Azteca.Windows.Controls.CILabel()
        Me.txtColonia = New Azteca.Windows.Controls.CITextBox()
        Me.lblNumExt = New Azteca.Windows.Controls.CILabel()
        Me.txtNumInt = New Azteca.Windows.Controls.CITextBox()
        Me.lblNumInt = New Azteca.Windows.Controls.CILabel()
        Me.txtNumExt = New Azteca.Windows.Controls.CITextBox()
        Me.lblCodigoPostal = New Azteca.Windows.Controls.CILabel()
        Me.txtCalle = New Azteca.Windows.Controls.CITextBox()
        Me.lblPoblacion = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel17 = New Azteca.Windows.Controls.CILabel()
        Me.cboFormatoFactura = New Azteca.Windows.Controls.FormatosComboBox()
        Me.txtSerieFact = New Azteca.Windows.Contabilidad.SerieSelector()
        Me.txtSerieDev = New Azteca.Windows.Contabilidad.SerieSelector()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel5 = New Azteca.Windows.Controls.CILabel()
        Me.cboFormatoDev = New Azteca.Windows.Controls.FormatosComboBox()
        Me.chkAfectarInv = New Azteca.Windows.Controls.CICheckBox()
        Me.pnGrales = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.pnlEncabezadoGrales = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New Azteca.Windows.ColorWithAlpha()
        Me.pnlInventarioTitulo = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha2 = New Azteca.Windows.ColorWithAlpha()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lblInventario = New Azteca.Windows.Controls.CILabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblGenerales = New Azteca.Windows.Controls.CILabel()
        Me.pnlDomicilio = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.pnlDomicilioTitulo = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblDomicilio = New Azteca.Windows.Controls.CILabel()
        Me.pnlFacturacion = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.pnlfacturacionTitulo = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblFacturacion = New Azteca.Windows.Controls.CILabel()
        Me.pnlInventario = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.pnlEmpresa = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.pnlEmpresaTitulo = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lblEmpresaTit = New Azteca.Windows.Controls.CILabel()
        Me.cboDivisaBase = New Azteca.Windows.Contabilidad.DivisasComboBox()
        Me.txtGLN = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel16 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel7 = New Azteca.Windows.Controls.CILabel()
        Me.pnlNotificaciones = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.pnlNofificacionesTit = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.lblNotificacionesTitulo = New Azteca.Windows.Controls.CILabel()
        Me.CiGroupBox1 = New Azteca.Windows.Controls.CIGroupBox()
        Me.CiLabel6 = New Azteca.Windows.Controls.CILabel()
        Me.nudPorcentajeFolios = New Azteca.Windows.Controls.CINumericUpDown()
        Me.CiCheckBox3 = New Azteca.Windows.Controls.CICheckBox()
        Me.CiCheckBox2 = New Azteca.Windows.Controls.CICheckBox()
        Me.chkEnviarFact = New Azteca.Windows.Controls.CICheckBox()
        Me.pnGrales.SuspendLayout()
        Me.pnlEncabezadoGrales.SuspendLayout()
        Me.pnlInventarioTitulo.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDomicilio.SuspendLayout()
        Me.pnlDomicilioTitulo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFacturacion.SuspendLayout()
        Me.pnlfacturacionTitulo.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInventario.SuspendLayout()
        Me.pnlEmpresa.SuspendLayout()
        Me.pnlEmpresaTitulo.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNotificaciones.SuspendLayout()
        Me.pnlNofificacionesTit.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CiGroupBox1.SuspendLayout()
        CType(Me.nudPorcentajeFolios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.BackColor = System.Drawing.Color.Transparent
        Me.lblEmpresa.Location = New System.Drawing.Point(33, 44)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(51, 13)
        Me.lblEmpresa.TabIndex = 32
        Me.lblEmpresa.Text = "Empresa:"
        '
        'txtNombreCorto
        '
        Me.txtNombreCorto.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombreCorto.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombreCorto.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombreCorto.Location = New System.Drawing.Point(477, 41)
        Me.txtNombreCorto.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombreCorto.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombreCorto.Name = "txtNombreCorto"
        Me.txtNombreCorto.RequiredField = True
        Me.txtNombreCorto.Size = New System.Drawing.Size(345, 20)
        Me.txtNombreCorto.TabIndex = 1
        Me.txtNombreCorto.UIName = "Nombre Corto"
        '
        'lblNombreCorto
        '
        Me.lblNombreCorto.AutoSize = True
        Me.lblNombreCorto.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreCorto.Location = New System.Drawing.Point(417, 43)
        Me.lblNombreCorto.Name = "lblNombreCorto"
        Me.lblNombreCorto.Size = New System.Drawing.Size(44, 13)
        Me.lblNombreCorto.TabIndex = 34
        Me.lblNombreCorto.Text = "Nombre"
        '
        'cboEmpresa
        '
        Me.cboEmpresa.BackColor = System.Drawing.SystemColors.Window
        Me.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpresa.FormattingEnabled = True
        Me.cboEmpresa.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboEmpresa.ItemsTable = Nothing
        Me.cboEmpresa.Location = New System.Drawing.Point(89, 40)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.RequiredField = True
        Me.cboEmpresa.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboEmpresa.Size = New System.Drawing.Size(256, 21)
        Me.cboEmpresa.TabIndex = 0
        Me.cboEmpresa.UIName = "Campo de Empresa"
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
        Me.txtPoblacion.Location = New System.Drawing.Point(93, 128)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.RequiredField = True
        Me.txtPoblacion.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.txtPoblacion.Size = New System.Drawing.Size(254, 23)
        Me.txtPoblacion.TabIndex = 5
        Me.txtPoblacion.TextWidth = 70
        Me.txtPoblacion.UIName = "Población"
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.BackColor = System.Drawing.Color.Transparent
        Me.lblCalle.Location = New System.Drawing.Point(17, 42)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(33, 13)
        Me.lblCalle.TabIndex = 36
        Me.lblCalle.Text = "Calle:"
        '
        'txtCP
        '
        Me.txtCP.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCP.Digits = True
        Me.txtCP.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCP.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCP.Location = New System.Drawing.Point(93, 106)
        Me.txtCP.MaxLength = 5
        Me.txtCP.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCP.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(70, 20)
        Me.txtCP.TabIndex = 4
        Me.txtCP.UIName = Nothing
        '
        'lblColonia
        '
        Me.lblColonia.AutoSize = True
        Me.lblColonia.BackColor = System.Drawing.Color.Transparent
        Me.lblColonia.Location = New System.Drawing.Point(17, 88)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(45, 13)
        Me.lblColonia.TabIndex = 42
        Me.lblColonia.Text = "Colonia:"
        '
        'txtColonia
        '
        Me.txtColonia.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtColonia.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtColonia.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtColonia.Location = New System.Drawing.Point(93, 83)
        Me.txtColonia.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColonia.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(254, 20)
        Me.txtColonia.TabIndex = 3
        Me.txtColonia.UIName = Nothing
        '
        'lblNumExt
        '
        Me.lblNumExt.AutoSize = True
        Me.lblNumExt.BackColor = System.Drawing.Color.Transparent
        Me.lblNumExt.Location = New System.Drawing.Point(17, 65)
        Me.lblNumExt.Name = "lblNumExt"
        Me.lblNumExt.Size = New System.Drawing.Size(65, 13)
        Me.lblNumExt.TabIndex = 38
        Me.lblNumExt.Text = "No. Exterior:"
        '
        'txtNumInt
        '
        Me.txtNumInt.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNumInt.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNumInt.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumInt.Location = New System.Drawing.Point(277, 60)
        Me.txtNumInt.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumInt.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumInt.Name = "txtNumInt"
        Me.txtNumInt.Size = New System.Drawing.Size(70, 20)
        Me.txtNumInt.TabIndex = 2
        Me.txtNumInt.UIName = Nothing
        '
        'lblNumInt
        '
        Me.lblNumInt.AutoSize = True
        Me.lblNumInt.BackColor = System.Drawing.Color.Transparent
        Me.lblNumInt.Location = New System.Drawing.Point(169, 64)
        Me.lblNumInt.Name = "lblNumInt"
        Me.lblNumInt.Size = New System.Drawing.Size(62, 13)
        Me.lblNumInt.TabIndex = 40
        Me.lblNumInt.Text = "No. Interior:"
        '
        'txtNumExt
        '
        Me.txtNumExt.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNumExt.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNumExt.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumExt.Location = New System.Drawing.Point(93, 60)
        Me.txtNumExt.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExt.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExt.Name = "txtNumExt"
        Me.txtNumExt.Size = New System.Drawing.Size(70, 20)
        Me.txtNumExt.TabIndex = 1
        Me.txtNumExt.UIName = Nothing
        '
        'lblCodigoPostal
        '
        Me.lblCodigoPostal.AutoSize = True
        Me.lblCodigoPostal.BackColor = System.Drawing.Color.Transparent
        Me.lblCodigoPostal.Location = New System.Drawing.Point(17, 110)
        Me.lblCodigoPostal.Name = "lblCodigoPostal"
        Me.lblCodigoPostal.Size = New System.Drawing.Size(75, 13)
        Me.lblCodigoPostal.TabIndex = 44
        Me.lblCodigoPostal.Text = "Código Postal:"
        '
        'txtCalle
        '
        Me.txtCalle.BackColor = System.Drawing.SystemColors.Window
        Me.txtCalle.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCalle.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCalle.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCalle.Location = New System.Drawing.Point(93, 37)
        Me.txtCalle.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalle.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(254, 20)
        Me.txtCalle.TabIndex = 0
        Me.txtCalle.UIName = Nothing
        '
        'lblPoblacion
        '
        Me.lblPoblacion.AutoSize = True
        Me.lblPoblacion.BackColor = System.Drawing.Color.Transparent
        Me.lblPoblacion.Location = New System.Drawing.Point(17, 134)
        Me.lblPoblacion.Name = "lblPoblacion"
        Me.lblPoblacion.Size = New System.Drawing.Size(57, 13)
        Me.lblPoblacion.TabIndex = 46
        Me.lblPoblacion.Text = "Población:"
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel1.Location = New System.Drawing.Point(19, 49)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(102, 13)
        Me.CiLabel1.TabIndex = 48
        Me.CiLabel1.Text = "Formato de Factura:"
        '
        'CiLabel17
        '
        Me.CiLabel17.AutoSize = True
        Me.CiLabel17.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel17.Location = New System.Drawing.Point(19, 74)
        Me.CiLabel17.Name = "CiLabel17"
        Me.CiLabel17.Size = New System.Drawing.Size(34, 13)
        Me.CiLabel17.TabIndex = 50
        Me.CiLabel17.Text = "Serie:"
        '
        'cboFormatoFactura
        '
        Me.cboFormatoFactura.BackColor = System.Drawing.SystemColors.Window
        Me.cboFormatoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormatoFactura.FormattingEnabled = True
        Me.cboFormatoFactura.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboFormatoFactura.ItemsTable = Nothing
        Me.cboFormatoFactura.Location = New System.Drawing.Point(147, 46)
        Me.cboFormatoFactura.Name = "cboFormatoFactura"
        Me.cboFormatoFactura.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboFormatoFactura.Size = New System.Drawing.Size(277, 21)
        Me.cboFormatoFactura.TabIndex = 0
        Me.cboFormatoFactura.UIName = "Formato Factura"
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
        Me.txtSerieFact.Location = New System.Drawing.Point(79, 69)
        Me.txtSerieFact.Name = "txtSerieFact"
        Me.txtSerieFact.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.txtSerieFact.Size = New System.Drawing.Size(345, 23)
        Me.txtSerieFact.TabIndex = 1
        Me.txtSerieFact.UIName = "Serie Facturas"
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
        Me.txtSerieDev.Location = New System.Drawing.Point(79, 116)
        Me.txtSerieDev.Name = "txtSerieDev"
        Me.txtSerieDev.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.txtSerieDev.Size = New System.Drawing.Size(345, 23)
        Me.txtSerieDev.TabIndex = 3
        Me.txtSerieDev.UIName = "Serie Devoluciones"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel2.Location = New System.Drawing.Point(19, 99)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(131, 13)
        Me.CiLabel2.TabIndex = 52
        Me.CiLabel2.Text = "Formato de Devoluciones:"
        '
        'CiLabel5
        '
        Me.CiLabel5.AutoSize = True
        Me.CiLabel5.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel5.Location = New System.Drawing.Point(19, 120)
        Me.CiLabel5.Name = "CiLabel5"
        Me.CiLabel5.Size = New System.Drawing.Size(34, 13)
        Me.CiLabel5.TabIndex = 54
        Me.CiLabel5.Text = "Serie:"
        '
        'cboFormatoDev
        '
        Me.cboFormatoDev.BackColor = System.Drawing.SystemColors.Window
        Me.cboFormatoDev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormatoDev.FormattingEnabled = True
        Me.cboFormatoDev.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboFormatoDev.ItemsTable = Nothing
        Me.cboFormatoDev.Location = New System.Drawing.Point(147, 94)
        Me.cboFormatoDev.Name = "cboFormatoDev"
        Me.cboFormatoDev.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboFormatoDev.Size = New System.Drawing.Size(277, 21)
        Me.cboFormatoDev.TabIndex = 2
        Me.cboFormatoDev.UIName = "Formato Devoluciones"
        '
        'chkAfectarInv
        '
        Me.chkAfectarInv.AutoSize = True
        Me.chkAfectarInv.BackColor = System.Drawing.Color.Transparent
        Me.chkAfectarInv.Location = New System.Drawing.Point(95, 54)
        Me.chkAfectarInv.Name = "chkAfectarInv"
        Me.chkAfectarInv.Size = New System.Drawing.Size(193, 17)
        Me.chkAfectarInv.TabIndex = 0
        Me.chkAfectarInv.Text = "Descontar existencias del almacén:"
        Me.chkAfectarInv.UseVisualStyleBackColor = False
        '
        'pnGrales
        '
        Me.pnGrales.BackColor = System.Drawing.Color.Transparent
        Me.pnGrales.Border = True
        Me.pnGrales.BorderColor = System.Drawing.Color.Blue
        Me.pnGrales.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnGrales.Controls.Add(Me.cboDivisaBase)
        Me.pnGrales.Controls.Add(Me.txtGLN)
        Me.pnGrales.Controls.Add(Me.CiLabel16)
        Me.pnGrales.Controls.Add(Me.CiLabel7)
        Me.pnGrales.Controls.Add(Me.pnlEncabezadoGrales)
        Me.pnGrales.CornerRadius = 20
        Me.pnGrales.Corners = CType((((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight) _
            Or Azteca.Windows.Corner.BottomLeft) _
            Or Azteca.Windows.Corner.BottomRight), Azteca.Windows.Corner)
        Me.pnGrales.Gradient = True
        Me.pnGrales.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnGrales.GradientOffset = 1.0!
        Me.pnGrales.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnGrales.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnGrales.Grayscale = False
        Me.pnGrales.Image = Nothing
        Me.pnGrales.ImageAlpha = 75
        Me.pnGrales.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnGrales.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnGrales.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnGrales.Location = New System.Drawing.Point(17, 352)
        Me.pnGrales.Name = "pnGrales"
        Me.pnGrales.Rounded = True
        Me.pnGrales.Size = New System.Drawing.Size(387, 86)
        Me.pnGrales.TabIndex = 57
        '
        'pnlEncabezadoGrales
        '
        Me.pnlEncabezadoGrales.BackColor = System.Drawing.Color.Transparent
        Me.pnlEncabezadoGrales.Border = True
        Me.pnlEncabezadoGrales.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlEncabezadoGrales.Colors.Add(Me.ColorWithAlpha1)
        Me.pnlEncabezadoGrales.Colors.Add(Me.ColorWithAlpha2)
        Me.pnlEncabezadoGrales.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlEncabezadoGrales.Controls.Add(Me.PictureBox2)
        Me.pnlEncabezadoGrales.Controls.Add(Me.lblGenerales)
        Me.pnlEncabezadoGrales.CornerRadius = 20
        Me.pnlEncabezadoGrales.Corners = CType((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight), Azteca.Windows.Corner)
        Me.pnlEncabezadoGrales.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlEncabezadoGrales.Gradient = True
        Me.pnlEncabezadoGrales.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlEncabezadoGrales.GradientOffset = 1.0!
        Me.pnlEncabezadoGrales.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlEncabezadoGrales.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlEncabezadoGrales.Grayscale = False
        Me.pnlEncabezadoGrales.Image = Nothing
        Me.pnlEncabezadoGrales.ImageAlpha = 75
        Me.pnlEncabezadoGrales.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlEncabezadoGrales.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlEncabezadoGrales.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlEncabezadoGrales.Location = New System.Drawing.Point(0, 0)
        Me.pnlEncabezadoGrales.Name = "pnlEncabezadoGrales"
        Me.pnlEncabezadoGrales.Rounded = True
        Me.pnlEncabezadoGrales.Size = New System.Drawing.Size(387, 31)
        Me.pnlEncabezadoGrales.TabIndex = 0
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ColorWithAlpha1.Parent = Me.pnlNofificacionesTit
        '
        'pnlInventarioTitulo
        '
        Me.pnlInventarioTitulo.BackColor = System.Drawing.Color.Transparent
        Me.pnlInventarioTitulo.Border = True
        Me.pnlInventarioTitulo.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlInventarioTitulo.Colors.Add(Me.ColorWithAlpha1)
        Me.pnlInventarioTitulo.Colors.Add(Me.ColorWithAlpha2)
        Me.pnlInventarioTitulo.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlInventarioTitulo.Controls.Add(Me.PictureBox4)
        Me.pnlInventarioTitulo.Controls.Add(Me.lblInventario)
        Me.pnlInventarioTitulo.CornerRadius = 20
        Me.pnlInventarioTitulo.Corners = CType((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight), Azteca.Windows.Corner)
        Me.pnlInventarioTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlInventarioTitulo.Gradient = True
        Me.pnlInventarioTitulo.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlInventarioTitulo.GradientOffset = 1.0!
        Me.pnlInventarioTitulo.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlInventarioTitulo.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlInventarioTitulo.Grayscale = False
        Me.pnlInventarioTitulo.Image = Nothing
        Me.pnlInventarioTitulo.ImageAlpha = 75
        Me.pnlInventarioTitulo.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlInventarioTitulo.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlInventarioTitulo.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlInventarioTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlInventarioTitulo.Name = "pnlInventarioTitulo"
        Me.pnlInventarioTitulo.Rounded = True
        Me.pnlInventarioTitulo.Size = New System.Drawing.Size(392, 30)
        Me.pnlInventarioTitulo.TabIndex = 0
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ColorWithAlpha2.Parent = Me.pnlNofificacionesTit
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(20, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(39, 31)
        Me.PictureBox4.TabIndex = 61
        Me.PictureBox4.TabStop = False
        '
        'lblInventario
        '
        Me.lblInventario.BackColor = System.Drawing.Color.Transparent
        Me.lblInventario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInventario.ForeColor = System.Drawing.Color.White
        Me.lblInventario.Location = New System.Drawing.Point(0, 0)
        Me.lblInventario.Name = "lblInventario"
        Me.lblInventario.Size = New System.Drawing.Size(392, 30)
        Me.lblInventario.TabIndex = 58
        Me.lblInventario.Text = "               Inventario"
        Me.lblInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(18, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(39, 31)
        Me.PictureBox2.TabIndex = 36
        Me.PictureBox2.TabStop = False
        '
        'lblGenerales
        '
        Me.lblGenerales.BackColor = System.Drawing.Color.Transparent
        Me.lblGenerales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblGenerales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenerales.ForeColor = System.Drawing.Color.White
        Me.lblGenerales.Location = New System.Drawing.Point(0, 0)
        Me.lblGenerales.Name = "lblGenerales"
        Me.lblGenerales.Size = New System.Drawing.Size(387, 31)
        Me.lblGenerales.TabIndex = 58
        Me.lblGenerales.Tag = "               "
        Me.lblGenerales.Text = "               Generales"
        Me.lblGenerales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlDomicilio
        '
        Me.pnlDomicilio.BackColor = System.Drawing.Color.Transparent
        Me.pnlDomicilio.Border = True
        Me.pnlDomicilio.BorderColor = System.Drawing.Color.Blue
        Me.pnlDomicilio.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlDomicilio.Controls.Add(Me.pnlDomicilioTitulo)
        Me.pnlDomicilio.Controls.Add(Me.lblCalle)
        Me.pnlDomicilio.Controls.Add(Me.lblPoblacion)
        Me.pnlDomicilio.Controls.Add(Me.txtCalle)
        Me.pnlDomicilio.Controls.Add(Me.lblCodigoPostal)
        Me.pnlDomicilio.Controls.Add(Me.txtNumExt)
        Me.pnlDomicilio.Controls.Add(Me.lblNumInt)
        Me.pnlDomicilio.Controls.Add(Me.lblNumExt)
        Me.pnlDomicilio.Controls.Add(Me.txtColonia)
        Me.pnlDomicilio.Controls.Add(Me.lblColonia)
        Me.pnlDomicilio.Controls.Add(Me.txtCP)
        Me.pnlDomicilio.Controls.Add(Me.txtPoblacion)
        Me.pnlDomicilio.Controls.Add(Me.txtNumInt)
        Me.pnlDomicilio.CornerRadius = 20
        Me.pnlDomicilio.Corners = CType((((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight) _
            Or Azteca.Windows.Corner.BottomLeft) _
            Or Azteca.Windows.Corner.BottomRight), Azteca.Windows.Corner)
        Me.pnlDomicilio.Gradient = True
        Me.pnlDomicilio.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlDomicilio.GradientOffset = 1.0!
        Me.pnlDomicilio.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlDomicilio.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlDomicilio.Grayscale = False
        Me.pnlDomicilio.Image = Nothing
        Me.pnlDomicilio.ImageAlpha = 75
        Me.pnlDomicilio.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlDomicilio.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlDomicilio.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlDomicilio.Location = New System.Drawing.Point(14, 191)
        Me.pnlDomicilio.Name = "pnlDomicilio"
        Me.pnlDomicilio.Rounded = True
        Me.pnlDomicilio.Size = New System.Drawing.Size(390, 155)
        Me.pnlDomicilio.TabIndex = 58
        '
        'pnlDomicilioTitulo
        '
        Me.pnlDomicilioTitulo.BackColor = System.Drawing.Color.Transparent
        Me.pnlDomicilioTitulo.Border = True
        Me.pnlDomicilioTitulo.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlDomicilioTitulo.Colors.Add(Me.ColorWithAlpha1)
        Me.pnlDomicilioTitulo.Colors.Add(Me.ColorWithAlpha2)
        Me.pnlDomicilioTitulo.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlDomicilioTitulo.Controls.Add(Me.PictureBox1)
        Me.pnlDomicilioTitulo.Controls.Add(Me.lblDomicilio)
        Me.pnlDomicilioTitulo.CornerRadius = 20
        Me.pnlDomicilioTitulo.Corners = CType((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight), Azteca.Windows.Corner)
        Me.pnlDomicilioTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDomicilioTitulo.Gradient = True
        Me.pnlDomicilioTitulo.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlDomicilioTitulo.GradientOffset = 1.0!
        Me.pnlDomicilioTitulo.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlDomicilioTitulo.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlDomicilioTitulo.Grayscale = False
        Me.pnlDomicilioTitulo.Image = Nothing
        Me.pnlDomicilioTitulo.ImageAlpha = 75
        Me.pnlDomicilioTitulo.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlDomicilioTitulo.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlDomicilioTitulo.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlDomicilioTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlDomicilioTitulo.Name = "pnlDomicilioTitulo"
        Me.pnlDomicilioTitulo.Rounded = True
        Me.pnlDomicilioTitulo.Size = New System.Drawing.Size(390, 32)
        Me.pnlDomicilioTitulo.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(20, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 31)
        Me.PictureBox1.TabIndex = 59
        Me.PictureBox1.TabStop = False
        '
        'lblDomicilio
        '
        Me.lblDomicilio.BackColor = System.Drawing.Color.Transparent
        Me.lblDomicilio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDomicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDomicilio.ForeColor = System.Drawing.Color.White
        Me.lblDomicilio.Location = New System.Drawing.Point(0, 0)
        Me.lblDomicilio.Name = "lblDomicilio"
        Me.lblDomicilio.Size = New System.Drawing.Size(390, 32)
        Me.lblDomicilio.TabIndex = 58
        Me.lblDomicilio.Text = "               Domicilio "
        Me.lblDomicilio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlFacturacion
        '
        Me.pnlFacturacion.BackColor = System.Drawing.Color.Transparent
        Me.pnlFacturacion.Border = True
        Me.pnlFacturacion.BorderColor = System.Drawing.Color.Blue
        Me.pnlFacturacion.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlFacturacion.Controls.Add(Me.cboFormatoDev)
        Me.pnlFacturacion.Controls.Add(Me.pnlfacturacionTitulo)
        Me.pnlFacturacion.Controls.Add(Me.CiLabel1)
        Me.pnlFacturacion.Controls.Add(Me.txtSerieFact)
        Me.pnlFacturacion.Controls.Add(Me.txtSerieDev)
        Me.pnlFacturacion.Controls.Add(Me.cboFormatoFactura)
        Me.pnlFacturacion.Controls.Add(Me.CiLabel5)
        Me.pnlFacturacion.Controls.Add(Me.CiLabel17)
        Me.pnlFacturacion.Controls.Add(Me.CiLabel2)
        Me.pnlFacturacion.CornerRadius = 20
        Me.pnlFacturacion.Corners = CType((((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight) _
            Or Azteca.Windows.Corner.BottomLeft) _
            Or Azteca.Windows.Corner.BottomRight), Azteca.Windows.Corner)
        Me.pnlFacturacion.Gradient = True
        Me.pnlFacturacion.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlFacturacion.GradientOffset = 1.0!
        Me.pnlFacturacion.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlFacturacion.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlFacturacion.Grayscale = False
        Me.pnlFacturacion.Image = Nothing
        Me.pnlFacturacion.ImageAlpha = 75
        Me.pnlFacturacion.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlFacturacion.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlFacturacion.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlFacturacion.Location = New System.Drawing.Point(414, 191)
        Me.pnlFacturacion.Name = "pnlFacturacion"
        Me.pnlFacturacion.Rounded = True
        Me.pnlFacturacion.Size = New System.Drawing.Size(459, 155)
        Me.pnlFacturacion.TabIndex = 58
        '
        'pnlfacturacionTitulo
        '
        Me.pnlfacturacionTitulo.BackColor = System.Drawing.Color.Transparent
        Me.pnlfacturacionTitulo.Border = True
        Me.pnlfacturacionTitulo.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlfacturacionTitulo.Colors.Add(Me.ColorWithAlpha1)
        Me.pnlfacturacionTitulo.Colors.Add(Me.ColorWithAlpha2)
        Me.pnlfacturacionTitulo.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlfacturacionTitulo.Controls.Add(Me.PictureBox3)
        Me.pnlfacturacionTitulo.Controls.Add(Me.lblFacturacion)
        Me.pnlfacturacionTitulo.CornerRadius = 20
        Me.pnlfacturacionTitulo.Corners = CType((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight), Azteca.Windows.Corner)
        Me.pnlfacturacionTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlfacturacionTitulo.Gradient = True
        Me.pnlfacturacionTitulo.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlfacturacionTitulo.GradientOffset = 1.0!
        Me.pnlfacturacionTitulo.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlfacturacionTitulo.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlfacturacionTitulo.Grayscale = False
        Me.pnlfacturacionTitulo.Image = Nothing
        Me.pnlfacturacionTitulo.ImageAlpha = 75
        Me.pnlfacturacionTitulo.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlfacturacionTitulo.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlfacturacionTitulo.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlfacturacionTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlfacturacionTitulo.Name = "pnlfacturacionTitulo"
        Me.pnlfacturacionTitulo.Rounded = True
        Me.pnlfacturacionTitulo.Size = New System.Drawing.Size(459, 32)
        Me.pnlfacturacionTitulo.TabIndex = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(18, -1)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(39, 31)
        Me.PictureBox3.TabIndex = 60
        Me.PictureBox3.TabStop = False
        '
        'lblFacturacion
        '
        Me.lblFacturacion.BackColor = System.Drawing.Color.Transparent
        Me.lblFacturacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFacturacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFacturacion.ForeColor = System.Drawing.Color.White
        Me.lblFacturacion.Location = New System.Drawing.Point(0, 0)
        Me.lblFacturacion.Name = "lblFacturacion"
        Me.lblFacturacion.Size = New System.Drawing.Size(459, 32)
        Me.lblFacturacion.TabIndex = 58
        Me.lblFacturacion.Text = "               Facturación"
        Me.lblFacturacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlInventario
        '
        Me.pnlInventario.BackColor = System.Drawing.Color.Transparent
        Me.pnlInventario.Border = True
        Me.pnlInventario.BorderColor = System.Drawing.Color.Blue
        Me.pnlInventario.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlInventario.Controls.Add(Me.pnlInventarioTitulo)
        Me.pnlInventario.Controls.Add(Me.chkAfectarInv)
        Me.pnlInventario.CornerRadius = 20
        Me.pnlInventario.Corners = CType((((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight) _
            Or Azteca.Windows.Corner.BottomLeft) _
            Or Azteca.Windows.Corner.BottomRight), Azteca.Windows.Corner)
        Me.pnlInventario.Gradient = True
        Me.pnlInventario.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlInventario.GradientOffset = 1.0!
        Me.pnlInventario.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlInventario.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlInventario.Grayscale = False
        Me.pnlInventario.Image = Nothing
        Me.pnlInventario.ImageAlpha = 75
        Me.pnlInventario.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlInventario.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlInventario.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlInventario.Location = New System.Drawing.Point(12, 444)
        Me.pnlInventario.Name = "pnlInventario"
        Me.pnlInventario.Rounded = True
        Me.pnlInventario.Size = New System.Drawing.Size(392, 86)
        Me.pnlInventario.TabIndex = 58
        '
        'pnlEmpresa
        '
        Me.pnlEmpresa.BackColor = System.Drawing.Color.Transparent
        Me.pnlEmpresa.Border = True
        Me.pnlEmpresa.BorderColor = System.Drawing.Color.Blue
        Me.pnlEmpresa.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlEmpresa.Controls.Add(Me.pnlEmpresaTitulo)
        Me.pnlEmpresa.Controls.Add(Me.cboEmpresa)
        Me.pnlEmpresa.Controls.Add(Me.lblEmpresa)
        Me.pnlEmpresa.Controls.Add(Me.lblNombreCorto)
        Me.pnlEmpresa.Controls.Add(Me.txtNombreCorto)
        Me.pnlEmpresa.CornerRadius = 20
        Me.pnlEmpresa.Corners = CType((((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight) _
            Or Azteca.Windows.Corner.BottomLeft) _
            Or Azteca.Windows.Corner.BottomRight), Azteca.Windows.Corner)
        Me.pnlEmpresa.Gradient = True
        Me.pnlEmpresa.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlEmpresa.GradientOffset = 1.0!
        Me.pnlEmpresa.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlEmpresa.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlEmpresa.Grayscale = False
        Me.pnlEmpresa.Image = Nothing
        Me.pnlEmpresa.ImageAlpha = 75
        Me.pnlEmpresa.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlEmpresa.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlEmpresa.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlEmpresa.Location = New System.Drawing.Point(16, 112)
        Me.pnlEmpresa.Name = "pnlEmpresa"
        Me.pnlEmpresa.Rounded = True
        Me.pnlEmpresa.Size = New System.Drawing.Size(857, 72)
        Me.pnlEmpresa.TabIndex = 58
        '
        'pnlEmpresaTitulo
        '
        Me.pnlEmpresaTitulo.BackColor = System.Drawing.Color.Transparent
        Me.pnlEmpresaTitulo.Border = True
        Me.pnlEmpresaTitulo.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlEmpresaTitulo.Colors.Add(Me.ColorWithAlpha1)
        Me.pnlEmpresaTitulo.Colors.Add(Me.ColorWithAlpha2)
        Me.pnlEmpresaTitulo.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlEmpresaTitulo.Controls.Add(Me.PictureBox5)
        Me.pnlEmpresaTitulo.Controls.Add(Me.lblEmpresaTit)
        Me.pnlEmpresaTitulo.CornerRadius = 20
        Me.pnlEmpresaTitulo.Corners = CType((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight), Azteca.Windows.Corner)
        Me.pnlEmpresaTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlEmpresaTitulo.Gradient = True
        Me.pnlEmpresaTitulo.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlEmpresaTitulo.GradientOffset = 1.0!
        Me.pnlEmpresaTitulo.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlEmpresaTitulo.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlEmpresaTitulo.Grayscale = False
        Me.pnlEmpresaTitulo.Image = Nothing
        Me.pnlEmpresaTitulo.ImageAlpha = 75
        Me.pnlEmpresaTitulo.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlEmpresaTitulo.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlEmpresaTitulo.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlEmpresaTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlEmpresaTitulo.Name = "pnlEmpresaTitulo"
        Me.pnlEmpresaTitulo.Rounded = True
        Me.pnlEmpresaTitulo.Size = New System.Drawing.Size(857, 31)
        Me.pnlEmpresaTitulo.TabIndex = 0
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox5.Location = New System.Drawing.Point(18, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(39, 31)
        Me.PictureBox5.TabIndex = 36
        Me.PictureBox5.TabStop = False
        '
        'lblEmpresaTit
        '
        Me.lblEmpresaTit.BackColor = System.Drawing.Color.Transparent
        Me.lblEmpresaTit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblEmpresaTit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresaTit.ForeColor = System.Drawing.Color.White
        Me.lblEmpresaTit.Location = New System.Drawing.Point(0, 0)
        Me.lblEmpresaTit.Name = "lblEmpresaTit"
        Me.lblEmpresaTit.Size = New System.Drawing.Size(857, 31)
        Me.lblEmpresaTit.TabIndex = 58
        Me.lblEmpresaTit.Tag = "               "
        Me.lblEmpresaTit.Text = "               Sucursal"
        Me.lblEmpresaTit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboDivisaBase
        '
        Me.cboDivisaBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDivisaBase.FormattingEnabled = True
        Me.cboDivisaBase.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboDivisaBase.ItemsTable = Nothing
        Me.cboDivisaBase.Location = New System.Drawing.Point(88, 37)
        Me.cboDivisaBase.Name = "cboDivisaBase"
        Me.cboDivisaBase.RequiredField = True
        Me.cboDivisaBase.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboDivisaBase.Size = New System.Drawing.Size(256, 21)
        Me.cboDivisaBase.TabIndex = 0
        Me.cboDivisaBase.UIName = "Divisa Base"
        '
        'txtGLN
        '
        Me.txtGLN.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtGLN.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtGLN.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtGLN.Location = New System.Drawing.Point(88, 61)
        Me.txtGLN.MaxLength = 13
        Me.txtGLN.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtGLN.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtGLN.Name = "txtGLN"
        Me.txtGLN.Size = New System.Drawing.Size(256, 20)
        Me.txtGLN.TabIndex = 1
        '
        'CiLabel16
        '
        Me.CiLabel16.AutoSize = True
        Me.CiLabel16.Location = New System.Drawing.Point(20, 64)
        Me.CiLabel16.Name = "CiLabel16"
        Me.CiLabel16.Size = New System.Drawing.Size(32, 13)
        Me.CiLabel16.TabIndex = 8
        Me.CiLabel16.Text = "GLN:"
        '
        'CiLabel7
        '
        Me.CiLabel7.AutoSize = True
        Me.CiLabel7.Location = New System.Drawing.Point(18, 42)
        Me.CiLabel7.Name = "CiLabel7"
        Me.CiLabel7.Size = New System.Drawing.Size(66, 13)
        Me.CiLabel7.TabIndex = 10
        Me.CiLabel7.Text = "Divisa Base:"
        '
        'pnlNotificaciones
        '
        Me.pnlNotificaciones.BackColor = System.Drawing.Color.Transparent
        Me.pnlNotificaciones.Border = True
        Me.pnlNotificaciones.BorderColor = System.Drawing.Color.Blue
        Me.pnlNotificaciones.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlNotificaciones.Controls.Add(Me.CiGroupBox1)
        Me.pnlNotificaciones.Controls.Add(Me.pnlNofificacionesTit)
        Me.pnlNotificaciones.Controls.Add(Me.chkEnviarFact)
        Me.pnlNotificaciones.CornerRadius = 20
        Me.pnlNotificaciones.Corners = CType((((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight) _
            Or Azteca.Windows.Corner.BottomLeft) _
            Or Azteca.Windows.Corner.BottomRight), Azteca.Windows.Corner)
        Me.pnlNotificaciones.Gradient = True
        Me.pnlNotificaciones.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlNotificaciones.GradientOffset = 1.0!
        Me.pnlNotificaciones.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlNotificaciones.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlNotificaciones.Grayscale = False
        Me.pnlNotificaciones.Image = Nothing
        Me.pnlNotificaciones.ImageAlpha = 75
        Me.pnlNotificaciones.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlNotificaciones.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlNotificaciones.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlNotificaciones.Location = New System.Drawing.Point(417, 352)
        Me.pnlNotificaciones.Name = "pnlNotificaciones"
        Me.pnlNotificaciones.Rounded = True
        Me.pnlNotificaciones.Size = New System.Drawing.Size(456, 176)
        Me.pnlNotificaciones.TabIndex = 58
        '
        'pnlNofificacionesTit
        '
        Me.pnlNofificacionesTit.BackColor = System.Drawing.Color.Transparent
        Me.pnlNofificacionesTit.Border = True
        Me.pnlNofificacionesTit.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlNofificacionesTit.Colors.Add(Me.ColorWithAlpha1)
        Me.pnlNofificacionesTit.Colors.Add(Me.ColorWithAlpha2)
        Me.pnlNofificacionesTit.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlNofificacionesTit.Controls.Add(Me.PictureBox6)
        Me.pnlNofificacionesTit.Controls.Add(Me.lblNotificacionesTitulo)
        Me.pnlNofificacionesTit.CornerRadius = 20
        Me.pnlNofificacionesTit.Corners = CType((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight), Azteca.Windows.Corner)
        Me.pnlNofificacionesTit.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlNofificacionesTit.Gradient = True
        Me.pnlNofificacionesTit.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlNofificacionesTit.GradientOffset = 1.0!
        Me.pnlNofificacionesTit.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlNofificacionesTit.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlNofificacionesTit.Grayscale = False
        Me.pnlNofificacionesTit.Image = Nothing
        Me.pnlNofificacionesTit.ImageAlpha = 75
        Me.pnlNofificacionesTit.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlNofificacionesTit.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlNofificacionesTit.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlNofificacionesTit.Location = New System.Drawing.Point(0, 0)
        Me.pnlNofificacionesTit.Name = "pnlNofificacionesTit"
        Me.pnlNofificacionesTit.Rounded = True
        Me.pnlNofificacionesTit.Size = New System.Drawing.Size(456, 31)
        Me.pnlNofificacionesTit.TabIndex = 0
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox6.Location = New System.Drawing.Point(18, 0)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(39, 31)
        Me.PictureBox6.TabIndex = 36
        Me.PictureBox6.TabStop = False
        '
        'lblNotificacionesTitulo
        '
        Me.lblNotificacionesTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblNotificacionesTitulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNotificacionesTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotificacionesTitulo.ForeColor = System.Drawing.Color.White
        Me.lblNotificacionesTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblNotificacionesTitulo.Name = "lblNotificacionesTitulo"
        Me.lblNotificacionesTitulo.Size = New System.Drawing.Size(456, 31)
        Me.lblNotificacionesTitulo.TabIndex = 58
        Me.lblNotificacionesTitulo.Tag = "               "
        Me.lblNotificacionesTitulo.Text = "               Notificaciones"
        Me.lblNotificacionesTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CiGroupBox1
        '
        Me.CiGroupBox1.Controls.Add(Me.CiLabel6)
        Me.CiGroupBox1.Controls.Add(Me.nudPorcentajeFolios)
        Me.CiGroupBox1.Controls.Add(Me.CiCheckBox3)
        Me.CiGroupBox1.Controls.Add(Me.CiCheckBox2)
        Me.CiGroupBox1.Location = New System.Drawing.Point(37, 78)
        Me.CiGroupBox1.Name = "CiGroupBox1"
        Me.CiGroupBox1.Size = New System.Drawing.Size(384, 85)
        Me.CiGroupBox1.TabIndex = 2
        Me.CiGroupBox1.TabStop = False
        Me.CiGroupBox1.Text = "Notificaciones del operador"
        Me.CiGroupBox1.Visible = False
        '
        'CiLabel6
        '
        Me.CiLabel6.AutoSize = True
        Me.CiLabel6.Location = New System.Drawing.Point(240, 53)
        Me.CiLabel6.Name = "CiLabel6"
        Me.CiLabel6.Size = New System.Drawing.Size(15, 13)
        Me.CiLabel6.TabIndex = 1
        Me.CiLabel6.Text = "%"
        '
        'nudPorcentajeFolios
        '
        Me.nudPorcentajeFolios.HighlightColor = System.Drawing.SystemColors.Info
        Me.nudPorcentajeFolios.Location = New System.Drawing.Point(189, 51)
        Me.nudPorcentajeFolios.Minimum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nudPorcentajeFolios.Name = "nudPorcentajeFolios"
        Me.nudPorcentajeFolios.Size = New System.Drawing.Size(45, 20)
        Me.nudPorcentajeFolios.TabIndex = 1
        Me.nudPorcentajeFolios.Value = New Decimal(New Integer() {90, 0, 0, 0})
        '
        'CiCheckBox3
        '
        Me.CiCheckBox3.AutoSize = True
        Me.CiCheckBox3.Location = New System.Drawing.Point(31, 54)
        Me.CiCheckBox3.Name = "CiCheckBox3"
        Me.CiCheckBox3.Size = New System.Drawing.Size(152, 17)
        Me.CiCheckBox3.TabIndex = 3
        Me.CiCheckBox3.Text = "Notificar folios utilizados al:"
        Me.CiCheckBox3.UseVisualStyleBackColor = True
        '
        'CiCheckBox2
        '
        Me.CiCheckBox2.AutoSize = True
        Me.CiCheckBox2.Location = New System.Drawing.Point(31, 31)
        Me.CiCheckBox2.Name = "CiCheckBox2"
        Me.CiCheckBox2.Size = New System.Drawing.Size(150, 17)
        Me.CiCheckBox2.TabIndex = 0
        Me.CiCheckBox2.Text = "Notificar envio de facturas"
        Me.CiCheckBox2.UseVisualStyleBackColor = True
        '
        'chkEnviarFact
        '
        Me.chkEnviarFact.AutoSize = True
        Me.chkEnviarFact.Location = New System.Drawing.Point(42, 55)
        Me.chkEnviarFact.Name = "chkEnviarFact"
        Me.chkEnviarFact.Size = New System.Drawing.Size(229, 17)
        Me.chkEnviarFact.TabIndex = 0
        Me.chkEnviarFact.Text = "Enviar facturas automáticamente al cliente "
        Me.chkEnviarFact.UseVisualStyleBackColor = True
        '
        'UnidadNegocioExpressForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 556)
        Me.Controls.Add(Me.pnlNotificaciones)
        Me.Controls.Add(Me.pnlEmpresa)
        Me.Controls.Add(Me.pnlInventario)
        Me.Controls.Add(Me.pnlFacturacion)
        Me.Controls.Add(Me.pnlDomicilio)
        Me.Controls.Add(Me.pnGrales)
        Me.Name = "UnidadNegocioExpressForm"
        Me.Text = "UnidadNegocioExpressForm"
        Me.Controls.SetChildIndex(Me.pnGrales, 0)
        Me.Controls.SetChildIndex(Me.pnlDomicilio, 0)
        Me.Controls.SetChildIndex(Me.pnlFacturacion, 0)
        Me.Controls.SetChildIndex(Me.pnlInventario, 0)
        Me.Controls.SetChildIndex(Me.pnlEmpresa, 0)
        Me.Controls.SetChildIndex(Me.pnlNotificaciones, 0)
        Me.pnGrales.ResumeLayout(False)
        Me.pnGrales.PerformLayout()
        Me.pnlEncabezadoGrales.ResumeLayout(False)
        Me.pnlInventarioTitulo.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDomicilio.ResumeLayout(False)
        Me.pnlDomicilio.PerformLayout()
        Me.pnlDomicilioTitulo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFacturacion.ResumeLayout(False)
        Me.pnlFacturacion.PerformLayout()
        Me.pnlfacturacionTitulo.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInventario.ResumeLayout(False)
        Me.pnlInventario.PerformLayout()
        Me.pnlEmpresa.ResumeLayout(False)
        Me.pnlEmpresa.PerformLayout()
        Me.pnlEmpresaTitulo.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNotificaciones.ResumeLayout(False)
        Me.pnlNotificaciones.PerformLayout()
        Me.pnlNofificacionesTit.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CiGroupBox1.ResumeLayout(False)
        Me.CiGroupBox1.PerformLayout()
        CType(Me.nudPorcentajeFolios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEmpresa As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNombreCorto As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblNombreCorto As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboEmpresa As Azteca.Windows.Controls.Security.EmpresasComboBox
    Friend WithEvents txtPoblacion As Azteca.Windows.Controls.General.PoblacionSelector
    Friend WithEvents lblCalle As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCP As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblColonia As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtColonia As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblNumExt As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNumInt As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblNumInt As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNumExt As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblCodigoPostal As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCalle As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblPoblacion As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel17 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboFormatoFactura As Azteca.Windows.Controls.FormatosComboBox
    Friend WithEvents txtSerieFact As Azteca.Windows.Contabilidad.SerieSelector
    Friend WithEvents txtSerieDev As Azteca.Windows.Contabilidad.SerieSelector
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel5 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboFormatoDev As Azteca.Windows.Controls.FormatosComboBox
    Friend WithEvents chkAfectarInv As Azteca.Windows.Controls.CICheckBox

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Facade = New Azteca.Business.Ventas.UnidadNegocioFacade
    End Sub
    Friend WithEvents pnGrales As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents pnlEncabezadoGrales As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents pnlInventarioTitulo As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha2 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents lblInventario As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblGenerales As Azteca.Windows.Controls.CILabel
    Friend WithEvents pnlDomicilio As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents pnlDomicilioTitulo As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents lblDomicilio As Azteca.Windows.Controls.CILabel
    Friend WithEvents pnlFacturacion As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents pnlfacturacionTitulo As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents lblFacturacion As Azteca.Windows.Controls.CILabel
    Friend WithEvents pnlInventario As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlEmpresaTitulo As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents lblEmpresaTit As Azteca.Windows.Controls.CILabel
    Friend WithEvents pnlEmpresa As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents cboDivisaBase As Azteca.Windows.Contabilidad.DivisasComboBox
    Friend WithEvents txtGLN As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel16 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel7 As Azteca.Windows.Controls.CILabel
    Friend WithEvents pnlNofificacionesTit As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents lblNotificacionesTitulo As Azteca.Windows.Controls.CILabel
    Friend WithEvents pnlNotificaciones As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents CiGroupBox1 As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents CiLabel6 As Azteca.Windows.Controls.CILabel
    Friend WithEvents nudPorcentajeFolios As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents CiCheckBox3 As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents CiCheckBox2 As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents chkEnviarFact As Azteca.Windows.Controls.CICheckBox


End Class
