<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SacerdotesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SacerdotesForm))
        Me.iLstTabs = New System.Windows.Forms.ImageList(Me.components)
        Me.tabLaboral = New System.Windows.Forms.TabPage()
        Me.txtNombreCorto = New Azteca.Windows.Controls.CITextBox()
        Me.txtRFC = New Azteca.Windows.Controls.CITextBox()
        Me.txtCURP = New Azteca.Windows.Controls.CITextBox()
        Me.txtIMSS = New Azteca.Windows.Controls.CITextBox()
        Me.txtTitulo = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.lblRFC = New Azteca.Windows.Controls.CILabel()
        Me.lblCURP = New Azteca.Windows.Controls.CILabel()
        Me.lblIMSS = New Azteca.Windows.Controls.CILabel()
        Me.dtpFechaIngreso = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.lblTitulo = New Azteca.Windows.Controls.CILabel()
        Me.tabDomicilio = New System.Windows.Forms.TabPage()
        Me.txtNumInt = New Azteca.Windows.Controls.CITextBox()
        Me.txtCP = New Azteca.Windows.Controls.CITextBox()
        Me.txtColonia = New Azteca.Windows.Controls.CITextBox()
        Me.txtNumExt = New Azteca.Windows.Controls.CITextBox()
        Me.txtCalle = New Azteca.Windows.Controls.CITextBox()
        Me.lblNumInt = New Azteca.Windows.Controls.CILabel()
        Me.txtPoblacion = New Azteca.Windows.Controls.General.PoblacionSelector()
        Me.lblEstadoInf = New Azteca.Windows.Controls.CILabel()
        Me.lblEstado = New Azteca.Windows.Controls.CILabel()
        Me.lblPoblacion = New Azteca.Windows.Controls.CILabel()
        Me.lblCodigoPostal = New Azteca.Windows.Controls.CILabel()
        Me.lblNumExt = New Azteca.Windows.Controls.CILabel()
        Me.lblColonia = New Azteca.Windows.Controls.CILabel()
        Me.lblCalle = New Azteca.Windows.Controls.CILabel()
        Me.tabSacerdotes = New Azteca.Windows.Controls.CITab()
        Me.tabGenerales = New System.Windows.Forms.TabPage()
        Me.txtApellidoM = New Azteca.Windows.Controls.CITextBox()
        Me.txtCorreo = New Azteca.Windows.Controls.CITextBox()
        Me.txtCelular = New Azteca.Windows.Controls.CITextBox()
        Me.txtTelOficina = New Azteca.Windows.Controls.CITextBox()
        Me.txtTelCasa = New Azteca.Windows.Controls.CITextBox()
        Me.txtApellidoP = New Azteca.Windows.Controls.CITextBox()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.lblCorreo = New Azteca.Windows.Controls.CILabel()
        Me.lblCelular = New Azteca.Windows.Controls.CILabel()
        Me.lblTelOficina = New Azteca.Windows.Controls.CILabel()
        Me.lblTelCasa = New Azteca.Windows.Controls.CILabel()
        Me.lblApellidos = New Azteca.Windows.Controls.CILabel()
        Me.lblNombre = New Azteca.Windows.Controls.CILabel()
        Me.chkActivo = New Azteca.Windows.Controls.CICheckBox()
        Me.dtpFechaNacimiento = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.lblfechaNacimiento = New Azteca.Windows.Controls.CILabel()
        Me.lblSexo = New Azteca.Windows.Controls.CILabel()
        Me.rbtFemenino = New Azteca.Windows.Controls.CIRadioButton()
        Me.rbtMasculino = New Azteca.Windows.Controls.CIRadioButton()
        Me.tabLaboral.SuspendLayout()
        Me.tabDomicilio.SuspendLayout()
        Me.tabSacerdotes.SuspendLayout()
        Me.tabGenerales.SuspendLayout()
        Me.SuspendLayout()
        '
        'iLstTabs
        '
        Me.iLstTabs.ImageStream = CType(resources.GetObject("iLstTabs.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.iLstTabs.TransparentColor = System.Drawing.Color.Transparent
        Me.iLstTabs.Images.SetKeyName(0, "mask_32.png")
        Me.iLstTabs.Images.SetKeyName(1, "administrator_32.png")
        Me.iLstTabs.Images.SetKeyName(2, "book_32.png")
        Me.iLstTabs.Images.SetKeyName(3, "hand_32.png")
        Me.iLstTabs.Images.SetKeyName(4, "home_32.png")
        Me.iLstTabs.Images.SetKeyName(5, "Sacerdote.png")
        '
        'tabLaboral
        '
        Me.tabLaboral.Controls.Add(Me.txtNombreCorto)
        Me.tabLaboral.Controls.Add(Me.txtRFC)
        Me.tabLaboral.Controls.Add(Me.txtCURP)
        Me.tabLaboral.Controls.Add(Me.txtIMSS)
        Me.tabLaboral.Controls.Add(Me.txtTitulo)
        Me.tabLaboral.Controls.Add(Me.CiLabel3)
        Me.tabLaboral.Controls.Add(Me.lblRFC)
        Me.tabLaboral.Controls.Add(Me.lblCURP)
        Me.tabLaboral.Controls.Add(Me.lblIMSS)
        Me.tabLaboral.Controls.Add(Me.dtpFechaIngreso)
        Me.tabLaboral.Controls.Add(Me.CiLabel1)
        Me.tabLaboral.Controls.Add(Me.lblTitulo)
        Me.tabLaboral.ImageIndex = 2
        Me.tabLaboral.Location = New System.Drawing.Point(4, 39)
        Me.tabLaboral.Name = "tabLaboral"
        Me.tabLaboral.Size = New System.Drawing.Size(574, 299)
        Me.tabLaboral.TabIndex = 2
        Me.tabLaboral.Text = "Inf. Personal"
        Me.tabLaboral.UseVisualStyleBackColor = True
        '
        'txtNombreCorto
        '
        Me.txtNombreCorto.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombreCorto.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombreCorto.Location = New System.Drawing.Point(134, 54)
        Me.txtNombreCorto.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombreCorto.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombreCorto.Name = "txtNombreCorto"
        Me.txtNombreCorto.Size = New System.Drawing.Size(280, 20)
        Me.txtNombreCorto.TabIndex = 1
        Me.txtNombreCorto.UIName = "Nombre"
        '
        'txtRFC
        '
        Me.txtRFC.BackColor = System.Drawing.SystemColors.Window
        Me.txtRFC.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtRFC.Location = New System.Drawing.Point(134, 158)
        Me.txtRFC.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRFC.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(200, 20)
        Me.txtRFC.TabIndex = 5
        Me.txtRFC.UIName = "IMSS"
        '
        'txtCURP
        '
        Me.txtCURP.BackColor = System.Drawing.SystemColors.Window
        Me.txtCURP.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCURP.Location = New System.Drawing.Point(134, 132)
        Me.txtCURP.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCURP.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCURP.Name = "txtCURP"
        Me.txtCURP.Size = New System.Drawing.Size(200, 20)
        Me.txtCURP.TabIndex = 4
        Me.txtCURP.UIName = "IMSS"
        '
        'txtIMSS
        '
        Me.txtIMSS.BackColor = System.Drawing.SystemColors.Window
        Me.txtIMSS.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtIMSS.Location = New System.Drawing.Point(134, 106)
        Me.txtIMSS.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtIMSS.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtIMSS.Name = "txtIMSS"
        Me.txtIMSS.Size = New System.Drawing.Size(200, 20)
        Me.txtIMSS.TabIndex = 3
        Me.txtIMSS.UIName = "IMSS"
        '
        'txtTitulo
        '
        Me.txtTitulo.BackColor = System.Drawing.SystemColors.Window
        Me.txtTitulo.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTitulo.Location = New System.Drawing.Point(134, 28)
        Me.txtTitulo.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTitulo.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(280, 20)
        Me.txtTitulo.TabIndex = 0
        Me.txtTitulo.UIName = "Nombre"
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(39, 57)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(72, 13)
        Me.CiLabel3.TabIndex = 42
        Me.CiLabel3.Text = "Nombre Corto"
        '
        'lblRFC
        '
        Me.lblRFC.AutoSize = True
        Me.lblRFC.Location = New System.Drawing.Point(39, 154)
        Me.lblRFC.Name = "lblRFC"
        Me.lblRFC.Size = New System.Drawing.Size(28, 13)
        Me.lblRFC.TabIndex = 40
        Me.lblRFC.Text = "RFC"
        '
        'lblCURP
        '
        Me.lblCURP.AutoSize = True
        Me.lblCURP.Location = New System.Drawing.Point(39, 130)
        Me.lblCURP.Name = "lblCURP"
        Me.lblCURP.Size = New System.Drawing.Size(37, 13)
        Me.lblCURP.TabIndex = 38
        Me.lblCURP.Text = "CURP"
        '
        'lblIMSS
        '
        Me.lblIMSS.AutoSize = True
        Me.lblIMSS.Location = New System.Drawing.Point(39, 107)
        Me.lblIMSS.Name = "lblIMSS"
        Me.lblIMSS.Size = New System.Drawing.Size(73, 13)
        Me.lblIMSS.TabIndex = 36
        Me.lblIMSS.Text = "Seguro Social"
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(134, 80)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaIngreso.TabIndex = 2
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(39, 83)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(75, 13)
        Me.CiLabel1.TabIndex = 26
        Me.CiLabel1.Text = "Fecha Ingreso"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(39, 31)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(33, 13)
        Me.lblTitulo.TabIndex = 24
        Me.lblTitulo.Text = "Titulo"
        '
        'tabDomicilio
        '
        Me.tabDomicilio.Controls.Add(Me.txtNumInt)
        Me.tabDomicilio.Controls.Add(Me.txtCP)
        Me.tabDomicilio.Controls.Add(Me.txtColonia)
        Me.tabDomicilio.Controls.Add(Me.txtNumExt)
        Me.tabDomicilio.Controls.Add(Me.txtCalle)
        Me.tabDomicilio.Controls.Add(Me.lblNumInt)
        Me.tabDomicilio.Controls.Add(Me.txtPoblacion)
        Me.tabDomicilio.Controls.Add(Me.lblEstadoInf)
        Me.tabDomicilio.Controls.Add(Me.lblEstado)
        Me.tabDomicilio.Controls.Add(Me.lblPoblacion)
        Me.tabDomicilio.Controls.Add(Me.lblCodigoPostal)
        Me.tabDomicilio.Controls.Add(Me.lblNumExt)
        Me.tabDomicilio.Controls.Add(Me.lblColonia)
        Me.tabDomicilio.Controls.Add(Me.lblCalle)
        Me.tabDomicilio.ImageIndex = 4
        Me.tabDomicilio.Location = New System.Drawing.Point(4, 39)
        Me.tabDomicilio.Name = "tabDomicilio"
        Me.tabDomicilio.Size = New System.Drawing.Size(574, 299)
        Me.tabDomicilio.TabIndex = 4
        Me.tabDomicilio.Text = "Domicilio"
        Me.tabDomicilio.UseVisualStyleBackColor = True
        '
        'txtNumInt
        '
        Me.txtNumInt.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumInt.Location = New System.Drawing.Point(352, 63)
        Me.txtNumInt.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumInt.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumInt.Name = "txtNumInt"
        Me.txtNumInt.Size = New System.Drawing.Size(70, 20)
        Me.txtNumInt.TabIndex = 2
        Me.txtNumInt.UIName = Nothing
        '
        'txtCP
        '
        Me.txtCP.Digits = True
        Me.txtCP.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCP.Location = New System.Drawing.Point(122, 115)
        Me.txtCP.MaxLength = 5
        Me.txtCP.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCP.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(70, 20)
        Me.txtCP.TabIndex = 4
        Me.txtCP.UIName = Nothing
        '
        'txtColonia
        '
        Me.txtColonia.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtColonia.Location = New System.Drawing.Point(122, 89)
        Me.txtColonia.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColonia.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(300, 20)
        Me.txtColonia.TabIndex = 3
        Me.txtColonia.UIName = Nothing
        '
        'txtNumExt
        '
        Me.txtNumExt.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumExt.Location = New System.Drawing.Point(122, 63)
        Me.txtNumExt.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExt.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExt.Name = "txtNumExt"
        Me.txtNumExt.Size = New System.Drawing.Size(70, 20)
        Me.txtNumExt.TabIndex = 1
        Me.txtNumExt.UIName = Nothing
        '
        'txtCalle
        '
        Me.txtCalle.BackColor = System.Drawing.SystemColors.Window
        Me.txtCalle.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCalle.Location = New System.Drawing.Point(122, 37)
        Me.txtCalle.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalle.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(300, 20)
        Me.txtCalle.TabIndex = 0
        Me.txtCalle.UIName = Nothing
        '
        'lblNumInt
        '
        Me.lblNumInt.AutoSize = True
        Me.lblNumInt.Location = New System.Drawing.Point(284, 66)
        Me.lblNumInt.Name = "lblNumInt"
        Me.lblNumInt.Size = New System.Drawing.Size(62, 13)
        Me.lblNumInt.TabIndex = 27
        Me.lblNumInt.Text = "No. Interior:"
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
        Me.txtPoblacion.FieldName = Nothing
        Me.txtPoblacion.Key = 0
        Me.txtPoblacion.Linked = False
        Me.txtPoblacion.Location = New System.Drawing.Point(122, 141)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.Size = New System.Drawing.Size(300, 23)
        Me.txtPoblacion.TabIndex = 5
        Me.txtPoblacion.TextWidth = 70
        Me.txtPoblacion.UIName = Nothing
        '
        'lblEstadoInf
        '
        Me.lblEstadoInf.AutoSize = True
        Me.lblEstadoInf.Location = New System.Drawing.Point(121, 173)
        Me.lblEstadoInf.Name = "lblEstadoInf"
        Me.lblEstadoInf.Size = New System.Drawing.Size(46, 13)
        Me.lblEstadoInf.TabIndex = 25
        Me.lblEstadoInf.Text = "[Estado]"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(39, 173)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(43, 13)
        Me.lblEstado.TabIndex = 24
        Me.lblEstado.Text = "Estado:"
        '
        'lblPoblacion
        '
        Me.lblPoblacion.AutoSize = True
        Me.lblPoblacion.Location = New System.Drawing.Point(39, 146)
        Me.lblPoblacion.Name = "lblPoblacion"
        Me.lblPoblacion.Size = New System.Drawing.Size(57, 13)
        Me.lblPoblacion.TabIndex = 19
        Me.lblPoblacion.Text = "Población:"
        '
        'lblCodigoPostal
        '
        Me.lblCodigoPostal.AutoSize = True
        Me.lblCodigoPostal.Location = New System.Drawing.Point(39, 118)
        Me.lblCodigoPostal.Name = "lblCodigoPostal"
        Me.lblCodigoPostal.Size = New System.Drawing.Size(75, 13)
        Me.lblCodigoPostal.TabIndex = 18
        Me.lblCodigoPostal.Text = "Código Postal:"
        '
        'lblNumExt
        '
        Me.lblNumExt.AutoSize = True
        Me.lblNumExt.Location = New System.Drawing.Point(39, 66)
        Me.lblNumExt.Name = "lblNumExt"
        Me.lblNumExt.Size = New System.Drawing.Size(65, 13)
        Me.lblNumExt.TabIndex = 17
        Me.lblNumExt.Text = "No. Exterior:"
        '
        'lblColonia
        '
        Me.lblColonia.AutoSize = True
        Me.lblColonia.Location = New System.Drawing.Point(39, 93)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(45, 13)
        Me.lblColonia.TabIndex = 16
        Me.lblColonia.Text = "Colonia:"
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Location = New System.Drawing.Point(39, 40)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(33, 13)
        Me.lblCalle.TabIndex = 15
        Me.lblCalle.Text = "Calle:"
        '
        'tabSacerdotes
        '
        Me.tabSacerdotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabSacerdotes.Controls.Add(Me.tabGenerales)
        Me.tabSacerdotes.Controls.Add(Me.tabDomicilio)
        Me.tabSacerdotes.Controls.Add(Me.tabLaboral)
        Me.tabSacerdotes.ImageList = Me.iLstTabs
        Me.tabSacerdotes.Location = New System.Drawing.Point(12, 90)
        Me.tabSacerdotes.Name = "tabSacerdotes"
        Me.tabSacerdotes.SelectedIndex = 0
        Me.tabSacerdotes.Size = New System.Drawing.Size(582, 342)
        Me.tabSacerdotes.TabIndex = 2
        '
        'tabGenerales
        '
        Me.tabGenerales.Controls.Add(Me.txtApellidoM)
        Me.tabGenerales.Controls.Add(Me.txtCorreo)
        Me.tabGenerales.Controls.Add(Me.txtCelular)
        Me.tabGenerales.Controls.Add(Me.txtTelOficina)
        Me.tabGenerales.Controls.Add(Me.txtTelCasa)
        Me.tabGenerales.Controls.Add(Me.txtApellidoP)
        Me.tabGenerales.Controls.Add(Me.txtNombre)
        Me.tabGenerales.Controls.Add(Me.CiLabel2)
        Me.tabGenerales.Controls.Add(Me.lblCorreo)
        Me.tabGenerales.Controls.Add(Me.lblCelular)
        Me.tabGenerales.Controls.Add(Me.lblTelOficina)
        Me.tabGenerales.Controls.Add(Me.lblTelCasa)
        Me.tabGenerales.Controls.Add(Me.lblApellidos)
        Me.tabGenerales.Controls.Add(Me.lblNombre)
        Me.tabGenerales.Controls.Add(Me.chkActivo)
        Me.tabGenerales.Controls.Add(Me.dtpFechaNacimiento)
        Me.tabGenerales.Controls.Add(Me.lblfechaNacimiento)
        Me.tabGenerales.Controls.Add(Me.lblSexo)
        Me.tabGenerales.Controls.Add(Me.rbtFemenino)
        Me.tabGenerales.Controls.Add(Me.rbtMasculino)
        Me.tabGenerales.ImageIndex = 5
        Me.tabGenerales.Location = New System.Drawing.Point(4, 39)
        Me.tabGenerales.Name = "tabGenerales"
        Me.tabGenerales.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGenerales.Size = New System.Drawing.Size(574, 299)
        Me.tabGenerales.TabIndex = 0
        Me.tabGenerales.Text = "Datos Generales"
        Me.tabGenerales.UseVisualStyleBackColor = True
        '
        'txtApellidoM
        '
        Me.txtApellidoM.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtApellidoM.Location = New System.Drawing.Point(134, 59)
        Me.txtApellidoM.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtApellidoM.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtApellidoM.Name = "txtApellidoM"
        Me.txtApellidoM.RequiredField = True
        Me.txtApellidoM.Size = New System.Drawing.Size(186, 20)
        Me.txtApellidoM.TabIndex = 2
        Me.txtApellidoM.UIName = "Apellido Materno"
        '
        'txtCorreo
        '
        Me.txtCorreo.CharacterCasing = Azteca.Windows.Controls.CaseType.Lower
        Me.txtCorreo.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCorreo.Location = New System.Drawing.Point(134, 151)
        Me.txtCorreo.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCorreo.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(264, 20)
        Me.txtCorreo.TabIndex = 6
        Me.txtCorreo.UIName = Nothing
        '
        'txtCelular
        '
        Me.txtCelular.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCelular.Location = New System.Drawing.Point(134, 128)
        Me.txtCelular.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCelular.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(125, 20)
        Me.txtCelular.TabIndex = 5
        Me.txtCelular.UIName = Nothing
        '
        'txtTelOficina
        '
        Me.txtTelOficina.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTelOficina.Location = New System.Drawing.Point(134, 105)
        Me.txtTelOficina.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTelOficina.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTelOficina.Name = "txtTelOficina"
        Me.txtTelOficina.Size = New System.Drawing.Size(125, 20)
        Me.txtTelOficina.TabIndex = 4
        Me.txtTelOficina.UIName = Nothing
        '
        'txtTelCasa
        '
        Me.txtTelCasa.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTelCasa.Location = New System.Drawing.Point(134, 82)
        Me.txtTelCasa.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTelCasa.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTelCasa.Name = "txtTelCasa"
        Me.txtTelCasa.Size = New System.Drawing.Size(125, 20)
        Me.txtTelCasa.TabIndex = 3
        Me.txtTelCasa.UIName = Nothing
        '
        'txtApellidoP
        '
        Me.txtApellidoP.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtApellidoP.Location = New System.Drawing.Point(134, 36)
        Me.txtApellidoP.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtApellidoP.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtApellidoP.Name = "txtApellidoP"
        Me.txtApellidoP.RequiredField = True
        Me.txtApellidoP.Size = New System.Drawing.Size(186, 20)
        Me.txtApellidoP.TabIndex = 1
        Me.txtApellidoP.UIName = "Apellido Paterno"
        '
        'txtNombre
        '
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(134, 13)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(264, 20)
        Me.txtNombre.TabIndex = 0
        Me.txtNombre.UIName = "Nombre"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(41, 62)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(89, 13)
        Me.CiLabel2.TabIndex = 38
        Me.CiLabel2.Text = "Apellido Materno:"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(41, 154)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(41, 13)
        Me.lblCorreo.TabIndex = 46
        Me.lblCorreo.Text = "Correo:"
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Location = New System.Drawing.Point(41, 131)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(42, 13)
        Me.lblCelular.TabIndex = 44
        Me.lblCelular.Text = "Celular:"
        '
        'lblTelOficina
        '
        Me.lblTelOficina.AutoSize = True
        Me.lblTelOficina.Location = New System.Drawing.Point(41, 109)
        Me.lblTelOficina.Name = "lblTelOficina"
        Me.lblTelOficina.Size = New System.Drawing.Size(88, 13)
        Me.lblTelOficina.TabIndex = 42
        Me.lblTelOficina.Text = "Telefono Oficina:"
        '
        'lblTelCasa
        '
        Me.lblTelCasa.AutoSize = True
        Me.lblTelCasa.Location = New System.Drawing.Point(41, 85)
        Me.lblTelCasa.Name = "lblTelCasa"
        Me.lblTelCasa.Size = New System.Drawing.Size(79, 13)
        Me.lblTelCasa.TabIndex = 40
        Me.lblTelCasa.Text = "Telefono Casa:"
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Location = New System.Drawing.Point(41, 39)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(87, 13)
        Me.lblApellidos.TabIndex = 36
        Me.lblApellidos.Text = "Apellido Paterno:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(41, 16)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 34
        Me.lblNombre.Text = "Nombre:"
        '
        'chkActivo
        '
        Me.chkActivo.AutoClear = False
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.Location = New System.Drawing.Point(134, 251)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 8
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(134, 199)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaNacimiento.TabIndex = 7
        '
        'lblfechaNacimiento
        '
        Me.lblfechaNacimiento.AutoSize = True
        Me.lblfechaNacimiento.Location = New System.Drawing.Point(41, 202)
        Me.lblfechaNacimiento.Name = "lblfechaNacimiento"
        Me.lblfechaNacimiento.Size = New System.Drawing.Size(93, 13)
        Me.lblfechaNacimiento.TabIndex = 24
        Me.lblfechaNacimiento.Text = "Fecha Nacimiento"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(41, 180)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(31, 13)
        Me.lblSexo.TabIndex = 23
        Me.lblSexo.Text = "Sexo"
        '
        'rbtFemenino
        '
        Me.rbtFemenino.AutoSize = True
        Me.rbtFemenino.Location = New System.Drawing.Point(263, 176)
        Me.rbtFemenino.Name = "rbtFemenino"
        Me.rbtFemenino.Size = New System.Drawing.Size(71, 17)
        Me.rbtFemenino.TabIndex = 22
        Me.rbtFemenino.Text = "Femenino"
        Me.rbtFemenino.UseVisualStyleBackColor = True
        '
        'rbtMasculino
        '
        Me.rbtMasculino.AutoSize = True
        Me.rbtMasculino.Checked = True
        Me.rbtMasculino.Location = New System.Drawing.Point(137, 176)
        Me.rbtMasculino.Name = "rbtMasculino"
        Me.rbtMasculino.Size = New System.Drawing.Size(73, 17)
        Me.rbtMasculino.TabIndex = 21
        Me.rbtMasculino.TabStop = True
        Me.rbtMasculino.Text = "Masculino"
        Me.rbtMasculino.UseVisualStyleBackColor = True
        '
        'SacerdotesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 460)
        Me.Controls.Add(Me.tabSacerdotes)
        Me.Name = "SacerdotesForm"
        Me.Text = "SacerdotesForm"
        Me.Controls.SetChildIndex(Me.tabSacerdotes, 0)
        Me.tabLaboral.ResumeLayout(False)
        Me.tabLaboral.PerformLayout()
        Me.tabDomicilio.ResumeLayout(False)
        Me.tabDomicilio.PerformLayout()
        Me.tabSacerdotes.ResumeLayout(False)
        Me.tabGenerales.ResumeLayout(False)
        Me.tabGenerales.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New SacerdoteFacade()
    End Sub
    Friend WithEvents iLstTabs As System.Windows.Forms.ImageList
    Friend WithEvents tabLaboral As System.Windows.Forms.TabPage
    Friend WithEvents txtNombreCorto As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtRFC As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtCURP As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtIMSS As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtTitulo As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblRFC As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCURP As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblIMSS As Azteca.Windows.Controls.CILabel
    Friend WithEvents dtpFechaIngreso As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblTitulo As Azteca.Windows.Controls.CILabel
    Friend WithEvents tabDomicilio As System.Windows.Forms.TabPage
    Friend WithEvents txtNumInt As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtCP As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtColonia As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtNumExt As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtCalle As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblNumInt As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtPoblacion As Azteca.Windows.Controls.General.PoblacionSelector
    Friend WithEvents lblEstadoInf As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblEstado As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblPoblacion As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCodigoPostal As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblNumExt As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblColonia As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCalle As Azteca.Windows.Controls.CILabel
    Friend WithEvents tabSacerdotes As Azteca.Windows.Controls.CITab
    Friend WithEvents tabGenerales As System.Windows.Forms.TabPage
    Friend WithEvents txtApellidoM As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtCorreo As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtCelular As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtTelOficina As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtTelCasa As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtApellidoP As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCorreo As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCelular As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblTelOficina As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblTelCasa As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblApellidos As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblNombre As Azteca.Windows.Controls.CILabel
    Friend WithEvents chkActivo As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents dtpFechaNacimiento As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents lblfechaNacimiento As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblSexo As Azteca.Windows.Controls.CILabel
    Friend WithEvents rbtFemenino As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents rbtMasculino As Azteca.Windows.Controls.CIRadioButton
End Class
