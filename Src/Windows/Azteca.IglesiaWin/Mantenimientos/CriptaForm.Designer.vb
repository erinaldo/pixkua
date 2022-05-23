<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CriptaForm
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

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New CriptaFacade()
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

   

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CriptaForm))
        Me.tabSacerdotes = New Azteca.Windows.Controls.CITab()
        Me.tabGenerales = New System.Windows.Forms.TabPage()
        Me.cmdImprimir = New System.Windows.Forms.Button()
        Me.dtpFechaCenizas3 = New System.Windows.Forms.DateTimePicker()
        Me.txtCenizasDe3 = New Azteca.Windows.Controls.CITextBox()
        Me.dtpFechaCenizas2 = New System.Windows.Forms.DateTimePicker()
        Me.txtCenizasDe2 = New Azteca.Windows.Controls.CITextBox()
        Me.dtpFechaCenizas1 = New System.Windows.Forms.DateTimePicker()
        Me.txtCenizasDe = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.txtObservaciones = New Azteca.Windows.Controls.CITextBox()
        Me.chkPagado = New Azteca.Windows.Controls.CICheckBox()
        Me.txtNumeroCripta = New Azteca.Windows.Controls.CITextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.txtCorreo = New Azteca.Windows.Controls.CITextBox()
        Me.txtCelular = New Azteca.Windows.Controls.CITextBox()
        Me.txtTelefonoCasa = New Azteca.Windows.Controls.CITextBox()
        Me.txtNombrePlaca = New Azteca.Windows.Controls.CITextBox()
        Me.lblCorreo = New Azteca.Windows.Controls.CILabel()
        Me.chkFN = New Azteca.Windows.Controls.CICheckBox()
        Me.lblTelOficina = New Azteca.Windows.Controls.CILabel()
        Me.lblTelCasa = New Azteca.Windows.Controls.CILabel()
        Me.lblNombre = New Azteca.Windows.Controls.CILabel()
        Me.chkActivo = New Azteca.Windows.Controls.CICheckBox()
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
        Me.iLstTabs = New System.Windows.Forms.ImageList(Me.components)
        Me.txtTitular = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.txtBeneficiario = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel5 = New Azteca.Windows.Controls.CILabel()
        Me.txtNumeroContrato = New Azteca.Windows.Controls.CITextBox()
        Me.tabSacerdotes.SuspendLayout()
        Me.tabGenerales.SuspendLayout()
        Me.tabDomicilio.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabSacerdotes
        '
        Me.tabSacerdotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabSacerdotes.Controls.Add(Me.tabGenerales)
        Me.tabSacerdotes.Controls.Add(Me.tabDomicilio)
        Me.tabSacerdotes.ImageList = Me.iLstTabs
        Me.tabSacerdotes.Location = New System.Drawing.Point(12, 89)
        Me.tabSacerdotes.Name = "tabSacerdotes"
        Me.tabSacerdotes.SelectedIndex = 0
        Me.tabSacerdotes.Size = New System.Drawing.Size(627, 357)
        Me.tabSacerdotes.TabIndex = 76
        '
        'tabGenerales
        '
        Me.tabGenerales.Controls.Add(Me.txtNumeroContrato)
        Me.tabGenerales.Controls.Add(Me.CiLabel5)
        Me.tabGenerales.Controls.Add(Me.txtBeneficiario)
        Me.tabGenerales.Controls.Add(Me.CiLabel4)
        Me.tabGenerales.Controls.Add(Me.txtTitular)
        Me.tabGenerales.Controls.Add(Me.CiLabel1)
        Me.tabGenerales.Controls.Add(Me.cmdImprimir)
        Me.tabGenerales.Controls.Add(Me.dtpFechaCenizas3)
        Me.tabGenerales.Controls.Add(Me.txtCenizasDe3)
        Me.tabGenerales.Controls.Add(Me.dtpFechaCenizas2)
        Me.tabGenerales.Controls.Add(Me.txtCenizasDe2)
        Me.tabGenerales.Controls.Add(Me.dtpFechaCenizas1)
        Me.tabGenerales.Controls.Add(Me.txtCenizasDe)
        Me.tabGenerales.Controls.Add(Me.CiLabel2)
        Me.tabGenerales.Controls.Add(Me.txtObservaciones)
        Me.tabGenerales.Controls.Add(Me.chkPagado)
        Me.tabGenerales.Controls.Add(Me.txtNumeroCripta)
        Me.tabGenerales.Controls.Add(Me.Label6)
        Me.tabGenerales.Controls.Add(Me.CiLabel3)
        Me.tabGenerales.Controls.Add(Me.txtCorreo)
        Me.tabGenerales.Controls.Add(Me.txtCelular)
        Me.tabGenerales.Controls.Add(Me.txtTelefonoCasa)
        Me.tabGenerales.Controls.Add(Me.txtNombrePlaca)
        Me.tabGenerales.Controls.Add(Me.lblCorreo)
        Me.tabGenerales.Controls.Add(Me.chkFN)
        Me.tabGenerales.Controls.Add(Me.lblTelOficina)
        Me.tabGenerales.Controls.Add(Me.lblTelCasa)
        Me.tabGenerales.Controls.Add(Me.lblNombre)
        Me.tabGenerales.Controls.Add(Me.chkActivo)
        Me.tabGenerales.ImageIndex = 2
        Me.tabGenerales.Location = New System.Drawing.Point(4, 39)
        Me.tabGenerales.Name = "tabGenerales"
        Me.tabGenerales.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGenerales.Size = New System.Drawing.Size(619, 314)
        Me.tabGenerales.TabIndex = 0
        Me.tabGenerales.Text = "Datos Generales"
        Me.tabGenerales.UseVisualStyleBackColor = True
        '
        'cmdImprimir
        '
        Me.cmdImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.Location = New System.Drawing.Point(279, 270)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(96, 30)
        Me.cmdImprimir.TabIndex = 166
        Me.cmdImprimir.Text = "Imprimir"
        Me.cmdImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdImprimir.UseVisualStyleBackColor = True
        '
        'dtpFechaCenizas3
        '
        Me.dtpFechaCenizas3.Location = New System.Drawing.Point(402, 241)
        Me.dtpFechaCenizas3.Name = "dtpFechaCenizas3"
        Me.dtpFechaCenizas3.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaCenizas3.TabIndex = 165
        '
        'txtCenizasDe3
        '
        Me.txtCenizasDe3.CharacterCasing = Azteca.Windows.Controls.CaseType.Lower
        Me.txtCenizasDe3.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCenizasDe3.Location = New System.Drawing.Point(402, 215)
        Me.txtCenizasDe3.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCenizasDe3.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCenizasDe3.Name = "txtCenizasDe3"
        Me.txtCenizasDe3.Size = New System.Drawing.Size(200, 20)
        Me.txtCenizasDe3.TabIndex = 164
        Me.txtCenizasDe3.UIName = Nothing
        '
        'dtpFechaCenizas2
        '
        Me.dtpFechaCenizas2.Location = New System.Drawing.Point(402, 181)
        Me.dtpFechaCenizas2.Name = "dtpFechaCenizas2"
        Me.dtpFechaCenizas2.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaCenizas2.TabIndex = 163
        '
        'txtCenizasDe2
        '
        Me.txtCenizasDe2.CharacterCasing = Azteca.Windows.Controls.CaseType.Lower
        Me.txtCenizasDe2.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCenizasDe2.Location = New System.Drawing.Point(402, 155)
        Me.txtCenizasDe2.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCenizasDe2.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCenizasDe2.Name = "txtCenizasDe2"
        Me.txtCenizasDe2.Size = New System.Drawing.Size(200, 20)
        Me.txtCenizasDe2.TabIndex = 14
        Me.txtCenizasDe2.UIName = Nothing
        '
        'dtpFechaCenizas1
        '
        Me.dtpFechaCenizas1.Location = New System.Drawing.Point(402, 124)
        Me.dtpFechaCenizas1.Name = "dtpFechaCenizas1"
        Me.dtpFechaCenizas1.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaCenizas1.TabIndex = 10
        '
        'txtCenizasDe
        '
        Me.txtCenizasDe.CharacterCasing = Azteca.Windows.Controls.CaseType.Lower
        Me.txtCenizasDe.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCenizasDe.Location = New System.Drawing.Point(402, 98)
        Me.txtCenizasDe.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCenizasDe.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCenizasDe.Name = "txtCenizasDe"
        Me.txtCenizasDe.Size = New System.Drawing.Size(200, 20)
        Me.txtCenizasDe.TabIndex = 9
        Me.txtCenizasDe.UIName = Nothing
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(399, 76)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(62, 13)
        Me.CiLabel2.TabIndex = 158
        Me.CiLabel2.Text = "Cenizas de:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = Azteca.Windows.Controls.CaseType.Lower
        Me.txtObservaciones.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtObservaciones.Location = New System.Drawing.Point(111, 181)
        Me.txtObservaciones.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtObservaciones.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(264, 80)
        Me.txtObservaciones.TabIndex = 157
        Me.txtObservaciones.UIName = Nothing
        '
        'chkPagado
        '
        Me.chkPagado.AutoSize = True
        Me.chkPagado.Location = New System.Drawing.Point(402, 14)
        Me.chkPagado.Name = "chkPagado"
        Me.chkPagado.Size = New System.Drawing.Size(63, 17)
        Me.chkPagado.TabIndex = 7
        Me.chkPagado.Text = "Pagado"
        Me.chkPagado.UseVisualStyleBackColor = True
        '
        'txtNumeroCripta
        '
        Me.txtNumeroCripta.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumeroCripta.Location = New System.Drawing.Point(111, 17)
        Me.txtNumeroCripta.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumeroCripta.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumeroCripta.Name = "txtNumeroCripta"
        Me.txtNumeroCripta.RequiredField = True
        Me.txtNumeroCripta.Size = New System.Drawing.Size(103, 20)
        Me.txtNumeroCripta.TabIndex = 1
        Me.txtNumeroCripta.UIName = "Serie"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 155
        Me.Label6.Text = "Num. de Cripta"
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(18, 181)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(81, 13)
        Me.CiLabel3.TabIndex = 78
        Me.CiLabel3.Text = "Observaciones:"
        '
        'txtCorreo
        '
        Me.txtCorreo.CharacterCasing = Azteca.Windows.Controls.CaseType.Lower
        Me.txtCorreo.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCorreo.Location = New System.Drawing.Point(111, 98)
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
        Me.txtCelular.Location = New System.Drawing.Point(300, 69)
        Me.txtCelular.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCelular.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(75, 20)
        Me.txtCelular.TabIndex = 4
        Me.txtCelular.UIName = Nothing
        '
        'txtTelefonoCasa
        '
        Me.txtTelefonoCasa.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTelefonoCasa.Location = New System.Drawing.Point(111, 69)
        Me.txtTelefonoCasa.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTelefonoCasa.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTelefonoCasa.Name = "txtTelefonoCasa"
        Me.txtTelefonoCasa.Size = New System.Drawing.Size(125, 20)
        Me.txtTelefonoCasa.TabIndex = 3
        Me.txtTelefonoCasa.UIName = Nothing
        '
        'txtNombrePlaca
        '
        Me.txtNombrePlaca.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombrePlaca.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombrePlaca.Location = New System.Drawing.Point(111, 43)
        Me.txtNombrePlaca.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombrePlaca.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombrePlaca.Name = "txtNombrePlaca"
        Me.txtNombrePlaca.RequiredField = True
        Me.txtNombrePlaca.Size = New System.Drawing.Size(264, 20)
        Me.txtNombrePlaca.TabIndex = 3
        Me.txtNombrePlaca.UIName = "Nombre"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(18, 101)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(41, 13)
        Me.lblCorreo.TabIndex = 46
        Me.lblCorreo.Text = "Correo:"
        '
        'chkFN
        '
        Me.chkFN.AutoSize = True
        Me.chkFN.Location = New System.Drawing.Point(402, 45)
        Me.chkFN.Name = "chkFN"
        Me.chkFN.Size = New System.Drawing.Size(40, 17)
        Me.chkFN.TabIndex = 8
        Me.chkFN.Text = "FN"
        Me.chkFN.UseVisualStyleBackColor = True
        '
        'lblTelOficina
        '
        Me.lblTelOficina.AutoSize = True
        Me.lblTelOficina.Location = New System.Drawing.Point(252, 72)
        Me.lblTelOficina.Name = "lblTelOficina"
        Me.lblTelOficina.Size = New System.Drawing.Size(42, 13)
        Me.lblTelOficina.TabIndex = 42
        Me.lblTelOficina.Text = "Celular:"
        '
        'lblTelCasa
        '
        Me.lblTelCasa.AutoSize = True
        Me.lblTelCasa.Location = New System.Drawing.Point(18, 72)
        Me.lblTelCasa.Name = "lblTelCasa"
        Me.lblTelCasa.Size = New System.Drawing.Size(79, 13)
        Me.lblTelCasa.TabIndex = 40
        Me.lblTelCasa.Text = "Telefono Casa:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(18, 46)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(77, 13)
        Me.lblNombre.TabIndex = 34
        Me.lblNombre.Text = "Nombre Placa:"
        '
        'chkActivo
        '
        Me.chkActivo.AutoClear = False
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.Location = New System.Drawing.Point(111, 278)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 15
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
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
        Me.tabDomicilio.Size = New System.Drawing.Size(619, 314)
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
        'txtTitular
        '
        Me.txtTitular.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTitular.Location = New System.Drawing.Point(111, 127)
        Me.txtTitular.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTitular.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTitular.Name = "txtTitular"
        Me.txtTitular.Size = New System.Drawing.Size(264, 20)
        Me.txtTitular.TabIndex = 167
        Me.txtTitular.UIName = Nothing
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(18, 130)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(39, 13)
        Me.CiLabel1.TabIndex = 168
        Me.CiLabel1.Text = "Titular:"
        '
        'txtBeneficiario
        '
        Me.txtBeneficiario.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtBeneficiario.Location = New System.Drawing.Point(111, 155)
        Me.txtBeneficiario.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtBeneficiario.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtBeneficiario.Name = "txtBeneficiario"
        Me.txtBeneficiario.Size = New System.Drawing.Size(264, 20)
        Me.txtBeneficiario.TabIndex = 169
        Me.txtBeneficiario.UIName = Nothing
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.Location = New System.Drawing.Point(18, 158)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(65, 13)
        Me.CiLabel4.TabIndex = 170
        Me.CiLabel4.Text = "Beneficiario:"
        '
        'CiLabel5
        '
        Me.CiLabel5.AutoSize = True
        Me.CiLabel5.Location = New System.Drawing.Point(223, 21)
        Me.CiLabel5.Name = "CiLabel5"
        Me.CiLabel5.Size = New System.Drawing.Size(78, 13)
        Me.CiLabel5.TabIndex = 171
        Me.CiLabel5.Text = "Num. Contrato:"
        '
        'txtNumeroContrato
        '
        Me.txtNumeroContrato.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumeroContrato.Location = New System.Drawing.Point(300, 18)
        Me.txtNumeroContrato.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumeroContrato.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumeroContrato.Name = "txtNumeroContrato"
        Me.txtNumeroContrato.Size = New System.Drawing.Size(75, 20)
        Me.txtNumeroContrato.TabIndex = 172
        Me.txtNumeroContrato.UIName = Nothing
        '
        'CriptaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 475)
        Me.Controls.Add(Me.tabSacerdotes)
        Me.Name = "CriptaForm"
        Me.Text = "CriptaForm"
        Me.Controls.SetChildIndex(Me.tabSacerdotes, 0)
        Me.tabSacerdotes.ResumeLayout(False)
        Me.tabGenerales.ResumeLayout(False)
        Me.tabGenerales.PerformLayout()
        Me.tabDomicilio.ResumeLayout(False)
        Me.tabDomicilio.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub



    Friend WithEvents tabSacerdotes As Azteca.Windows.Controls.CITab
    Friend WithEvents tabGenerales As System.Windows.Forms.TabPage
    Friend WithEvents txtNumeroCripta As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCorreo As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtCelular As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtTelefonoCasa As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtNombrePlaca As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblCorreo As Azteca.Windows.Controls.CILabel
    Friend WithEvents chkFN As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents lblTelOficina As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblTelCasa As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblNombre As Azteca.Windows.Controls.CILabel
    Friend WithEvents chkActivo As Azteca.Windows.Controls.CICheckBox
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
    Friend WithEvents iLstTabs As System.Windows.Forms.ImageList
    Friend WithEvents dtpFechaCenizas3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCenizasDe3 As Azteca.Windows.Controls.CITextBox
    Friend WithEvents dtpFechaCenizas2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCenizasDe2 As Azteca.Windows.Controls.CITextBox
    Friend WithEvents dtpFechaCenizas1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCenizasDe As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtObservaciones As Azteca.Windows.Controls.CITextBox
    Friend WithEvents chkPagado As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cmdImprimir As System.Windows.Forms.Button
    Friend WithEvents txtBeneficiario As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtTitular As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNumeroContrato As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel5 As Azteca.Windows.Controls.CILabel
End Class
