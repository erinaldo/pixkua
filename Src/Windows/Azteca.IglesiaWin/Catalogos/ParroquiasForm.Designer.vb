<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParroquiasForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ParroquiasForm))
        Me.chkFactElectronica = New Azteca.Windows.Controls.CICheckBox()
        Me.iLstTabs = New System.Windows.Forms.ImageList(Me.components)
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
        Me.tabGenerales = New System.Windows.Forms.TabPage()
        Me.txtNumero = New Azteca.Windows.Controls.CITextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.SacerdoteSel = New Azteca.Windows.Iglesia.SacerdoteSelector()
        Me.txtArquidiocesis = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.txtRazonSocial = New Azteca.Windows.Controls.CITextBox()
        Me.txtCorreo = New Azteca.Windows.Controls.CITextBox()
        Me.txtPaginaWeb = New Azteca.Windows.Controls.CITextBox()
        Me.txtFax = New Azteca.Windows.Controls.CITextBox()
        Me.txtTelefono = New Azteca.Windows.Controls.CITextBox()
        Me.txtRFC = New Azteca.Windows.Controls.CITextBox()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.lblCorreo = New Azteca.Windows.Controls.CILabel()
        Me.lblCelular = New Azteca.Windows.Controls.CILabel()
        Me.lblTelOficina = New Azteca.Windows.Controls.CILabel()
        Me.lblTelCasa = New Azteca.Windows.Controls.CILabel()
        Me.lblApellidos = New Azteca.Windows.Controls.CILabel()
        Me.lblNombre = New Azteca.Windows.Controls.CILabel()
        Me.chkActivo = New Azteca.Windows.Controls.CICheckBox()
        Me.tabSacerdotes = New Azteca.Windows.Controls.CITab()
        Me.tabDomicilio.SuspendLayout()
        Me.tabGenerales.SuspendLayout()
        Me.tabSacerdotes.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkFactElectronica
        '
        Me.chkFactElectronica.AutoSize = True
        Me.chkFactElectronica.Location = New System.Drawing.Point(280, 174)
        Me.chkFactElectronica.Name = "chkFactElectronica"
        Me.chkFactElectronica.Size = New System.Drawing.Size(118, 17)
        Me.chkFactElectronica.TabIndex = 74
        Me.chkFactElectronica.Text = "Factura Electrónica"
        Me.chkFactElectronica.UseVisualStyleBackColor = True
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
        Me.tabDomicilio.Size = New System.Drawing.Size(519, 294)
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
        Me.txtPoblacion.RequiredField = True
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
        'tabGenerales
        '
        Me.tabGenerales.Controls.Add(Me.txtNumero)
        Me.tabGenerales.Controls.Add(Me.Label6)
        Me.tabGenerales.Controls.Add(Me.CiLabel3)
        Me.tabGenerales.Controls.Add(Me.SacerdoteSel)
        Me.tabGenerales.Controls.Add(Me.txtArquidiocesis)
        Me.tabGenerales.Controls.Add(Me.CiLabel1)
        Me.tabGenerales.Controls.Add(Me.txtRazonSocial)
        Me.tabGenerales.Controls.Add(Me.txtCorreo)
        Me.tabGenerales.Controls.Add(Me.txtPaginaWeb)
        Me.tabGenerales.Controls.Add(Me.txtFax)
        Me.tabGenerales.Controls.Add(Me.txtTelefono)
        Me.tabGenerales.Controls.Add(Me.txtRFC)
        Me.tabGenerales.Controls.Add(Me.txtNombre)
        Me.tabGenerales.Controls.Add(Me.CiLabel2)
        Me.tabGenerales.Controls.Add(Me.lblCorreo)
        Me.tabGenerales.Controls.Add(Me.lblCelular)
        Me.tabGenerales.Controls.Add(Me.chkFactElectronica)
        Me.tabGenerales.Controls.Add(Me.lblTelOficina)
        Me.tabGenerales.Controls.Add(Me.lblTelCasa)
        Me.tabGenerales.Controls.Add(Me.lblApellidos)
        Me.tabGenerales.Controls.Add(Me.lblNombre)
        Me.tabGenerales.Controls.Add(Me.chkActivo)
        Me.tabGenerales.ImageIndex = 2
        Me.tabGenerales.Location = New System.Drawing.Point(4, 39)
        Me.tabGenerales.Name = "tabGenerales"
        Me.tabGenerales.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGenerales.Size = New System.Drawing.Size(519, 294)
        Me.tabGenerales.TabIndex = 0
        Me.tabGenerales.Text = "Datos Generales"
        Me.tabGenerales.UseVisualStyleBackColor = True
        '
        'txtNumero
        '
        Me.txtNumero.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumero.Location = New System.Drawing.Point(328, 13)
        Me.txtNumero.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumero.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.RequiredField = True
        Me.txtNumero.Size = New System.Drawing.Size(70, 20)
        Me.txtNumero.TabIndex = 154
        Me.txtNumero.UIName = "Serie"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(273, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 155
        Me.Label6.Text = "Numero"
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(41, 231)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(59, 13)
        Me.CiLabel3.TabIndex = 78
        Me.CiLabel3.Text = "Sacerdote:"
        '
        'SacerdoteSel
        '
        Me.SacerdoteSel.AnySite = False
        Me.SacerdoteSel.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.SacerdoteSel.EditorAssembly = "Azteca.IglesiaWin"
        Me.SacerdoteSel.EditorClass = "Azteca.Windows.Iglesia.SacerdotesForm"
        Me.SacerdoteSel.EditorTitle = "Editar los datos del Sacerdote..."
        Me.SacerdoteSel.Key = 0
        Me.SacerdoteSel.Linked = False
        Me.SacerdoteSel.Location = New System.Drawing.Point(134, 227)
        Me.SacerdoteSel.Name = "SacerdoteSel"
        Me.SacerdoteSel.Size = New System.Drawing.Size(332, 23)
        Me.SacerdoteSel.TabIndex = 77
        '
        'txtArquidiocesis
        '
        Me.txtArquidiocesis.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtArquidiocesis.Location = New System.Drawing.Point(134, 149)
        Me.txtArquidiocesis.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtArquidiocesis.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtArquidiocesis.Name = "txtArquidiocesis"
        Me.txtArquidiocesis.Size = New System.Drawing.Size(264, 20)
        Me.txtArquidiocesis.TabIndex = 75
        Me.txtArquidiocesis.UIName = Nothing
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(41, 152)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(69, 13)
        Me.CiLabel1.TabIndex = 76
        Me.CiLabel1.Text = "Arquidiocesis"
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtRazonSocial.Location = New System.Drawing.Point(134, 97)
        Me.txtRazonSocial.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRazonSocial.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(186, 20)
        Me.txtRazonSocial.TabIndex = 2
        Me.txtRazonSocial.UIName = "Apellido Materno"
        '
        'txtCorreo
        '
        Me.txtCorreo.CharacterCasing = Azteca.Windows.Controls.CaseType.Lower
        Me.txtCorreo.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCorreo.Location = New System.Drawing.Point(134, 201)
        Me.txtCorreo.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCorreo.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(264, 20)
        Me.txtCorreo.TabIndex = 6
        Me.txtCorreo.UIName = Nothing
        '
        'txtPaginaWeb
        '
        Me.txtPaginaWeb.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtPaginaWeb.Location = New System.Drawing.Point(134, 175)
        Me.txtPaginaWeb.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPaginaWeb.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPaginaWeb.Name = "txtPaginaWeb"
        Me.txtPaginaWeb.Size = New System.Drawing.Size(125, 20)
        Me.txtPaginaWeb.TabIndex = 5
        Me.txtPaginaWeb.UIName = Nothing
        '
        'txtFax
        '
        Me.txtFax.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtFax.Location = New System.Drawing.Point(323, 123)
        Me.txtFax.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFax.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(75, 20)
        Me.txtFax.TabIndex = 4
        Me.txtFax.UIName = Nothing
        '
        'txtTelefono
        '
        Me.txtTelefono.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTelefono.Location = New System.Drawing.Point(134, 123)
        Me.txtTelefono.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTelefono.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(125, 20)
        Me.txtTelefono.TabIndex = 3
        Me.txtTelefono.UIName = Nothing
        '
        'txtRFC
        '
        Me.txtRFC.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtRFC.Location = New System.Drawing.Point(134, 71)
        Me.txtRFC.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRFC.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(186, 20)
        Me.txtRFC.TabIndex = 1
        Me.txtRFC.UIName = "Apellido Paterno"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(134, 45)
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
        Me.CiLabel2.Location = New System.Drawing.Point(41, 100)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(70, 13)
        Me.CiLabel2.TabIndex = 38
        Me.CiLabel2.Text = "RazonSocial:"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(41, 204)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(41, 13)
        Me.lblCorreo.TabIndex = 46
        Me.lblCorreo.Text = "Correo:"
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Location = New System.Drawing.Point(41, 178)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(58, 13)
        Me.lblCelular.TabIndex = 44
        Me.lblCelular.Text = "Pag. Web:"
        '
        'lblTelOficina
        '
        Me.lblTelOficina.AutoSize = True
        Me.lblTelOficina.Location = New System.Drawing.Point(290, 126)
        Me.lblTelOficina.Name = "lblTelOficina"
        Me.lblTelOficina.Size = New System.Drawing.Size(27, 13)
        Me.lblTelOficina.TabIndex = 42
        Me.lblTelOficina.Text = "Fax:"
        '
        'lblTelCasa
        '
        Me.lblTelCasa.AutoSize = True
        Me.lblTelCasa.Location = New System.Drawing.Point(41, 126)
        Me.lblTelCasa.Name = "lblTelCasa"
        Me.lblTelCasa.Size = New System.Drawing.Size(49, 13)
        Me.lblTelCasa.TabIndex = 40
        Me.lblTelCasa.Text = "Telefono"
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Location = New System.Drawing.Point(41, 74)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(31, 13)
        Me.lblApellidos.TabIndex = 36
        Me.lblApellidos.Text = "RFC:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(41, 48)
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
        Me.chkActivo.Location = New System.Drawing.Point(134, 263)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 8
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'tabSacerdotes
        '
        Me.tabSacerdotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabSacerdotes.Controls.Add(Me.tabGenerales)
        Me.tabSacerdotes.Controls.Add(Me.tabDomicilio)
        Me.tabSacerdotes.ImageList = Me.iLstTabs
        Me.tabSacerdotes.Location = New System.Drawing.Point(12, 90)
        Me.tabSacerdotes.Name = "tabSacerdotes"
        Me.tabSacerdotes.SelectedIndex = 0
        Me.tabSacerdotes.Size = New System.Drawing.Size(527, 337)
        Me.tabSacerdotes.TabIndex = 75
        '
        'ParroquiasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 455)
        Me.Controls.Add(Me.tabSacerdotes)
        Me.Name = "ParroquiasForm"
        Me.Text = "ParroquiasForm"
        Me.Controls.SetChildIndex(Me.tabSacerdotes, 0)
        Me.tabDomicilio.ResumeLayout(False)
        Me.tabDomicilio.PerformLayout()
        Me.tabGenerales.ResumeLayout(False)
        Me.tabGenerales.PerformLayout()
        Me.tabSacerdotes.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New ParroquiaFacade
    End Sub
    Friend WithEvents chkFactElectronica As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents iLstTabs As System.Windows.Forms.ImageList
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
    Friend WithEvents tabGenerales As System.Windows.Forms.TabPage
    Friend WithEvents txtRazonSocial As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtCorreo As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtPaginaWeb As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtFax As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtTelefono As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtRFC As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCorreo As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCelular As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblTelOficina As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblTelCasa As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblApellidos As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblNombre As Azteca.Windows.Controls.CILabel
    Friend WithEvents chkActivo As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents tabSacerdotes As Azteca.Windows.Controls.CITab
    Friend WithEvents txtArquidiocesis As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents SacerdoteSel As Azteca.Windows.Iglesia.SacerdoteSelector
    Friend WithEvents txtNumero As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
