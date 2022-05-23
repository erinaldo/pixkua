<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditEmbarqueForm
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditEmbarqueForm))
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.lblOrden = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel12 = New Azteca.Windows.Controls.CILabel()
        Me.txtTipoCambio = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel11 = New Azteca.Windows.Controls.CILabel()
        Me.txtDivisa = New Azteca.Windows.Controls.CITextBox()
        Me.txtTotal = New Azteca.Windows.Controls.CITextBox()
        Me.txtDescuentos = New Azteca.Windows.Controls.CITextBox()
        Me.txtRetenciones = New Azteca.Windows.Controls.CITextBox()
        Me.txtImpuestos = New Azteca.Windows.Controls.CITextBox()
        Me.txtSubTotal = New Azteca.Windows.Controls.CITextBox()
        Me.txtTotalCant = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel8 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel7 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel6 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel5 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel13 = New Azteca.Windows.Controls.CILabel()
        Me.imlTab = New System.Windows.Forms.ImageList(Me.components)
        Me.bsArticulos = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsUnidades = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdArticulos = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.tlbMenh = New Azteca.Windows.Controls.AZToolBar()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdAceptar = New C1.Win.C1Command.C1Command()
        Me.cmdCancelar = New C1.Win.C1Command.C1Command()
        Me.btnAceptar = New C1.Win.C1Command.C1CommandLink()
        Me.btnCancelar = New C1.Win.C1Command.C1CommandLink()
        Me.CiLabel14 = New Azteca.Windows.Controls.CILabel()
        Me.btnSelDomicilioEntrega = New Azteca.Windows.Controls.CIButton()
        Me.lblCalle = New Azteca.Windows.Controls.CILabel()
        Me.txtPoblacion = New Azteca.Windows.Controls.General.PoblacionSelector()
        Me.txtCalle = New Azteca.Windows.Controls.CITextBox()
        Me.lblColonia = New Azteca.Windows.Controls.CILabel()
        Me.lblPoblacion = New Azteca.Windows.Controls.CILabel()
        Me.txtCP = New Azteca.Windows.Controls.CITextBox()
        Me.txtNumExt = New Azteca.Windows.Controls.CITextBox()
        Me.lblNumExt = New Azteca.Windows.Controls.CILabel()
        Me.lblCodigoPostal = New Azteca.Windows.Controls.CILabel()
        Me.txtColonia = New Azteca.Windows.Controls.CITextBox()
        Me.txtNumInt = New Azteca.Windows.Controls.CITextBox()
        Me.lblNumInt = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel15 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel16 = New Azteca.Windows.Controls.CILabel()
        Me.rdbCompleto = New Azteca.Windows.Controls.CIRadioButton()
        Me.rdbParcial = New Azteca.Windows.Controls.CIRadioButton()
        CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(43, 77)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(39, 13)
        Me.CiLabel1.TabIndex = 0
        Me.CiLabel1.Text = "Orden:"
        '
        'lblOrden
        '
        Me.lblOrden.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOrden.Location = New System.Drawing.Point(134, 76)
        Me.lblOrden.Name = "lblOrden"
        Me.lblOrden.Size = New System.Drawing.Size(150, 19)
        Me.lblOrden.TabIndex = 2
        '
        'CiLabel12
        '
        Me.CiLabel12.AutoSize = True
        Me.CiLabel12.Location = New System.Drawing.Point(43, 152)
        Me.CiLabel12.Name = "CiLabel12"
        Me.CiLabel12.Size = New System.Drawing.Size(84, 13)
        Me.CiLabel12.TabIndex = 39
        Me.CiLabel12.Text = "Tipo de Cambio:"
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.AutoLock = False
        Me.txtTipoCambio.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtTipoCambio.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtTipoCambio.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTipoCambio.Location = New System.Drawing.Point(134, 152)
        Me.txtTipoCambio.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTipoCambio.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.ReadOnly = True
        Me.txtTipoCambio.Size = New System.Drawing.Size(150, 20)
        Me.txtTipoCambio.TabIndex = 38
        Me.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CiLabel11
        '
        Me.CiLabel11.AutoSize = True
        Me.CiLabel11.Location = New System.Drawing.Point(44, 126)
        Me.CiLabel11.Name = "CiLabel11"
        Me.CiLabel11.Size = New System.Drawing.Size(39, 13)
        Me.CiLabel11.TabIndex = 37
        Me.CiLabel11.Text = "Divisa:"
        '
        'txtDivisa
        '
        Me.txtDivisa.AutoLock = False
        Me.txtDivisa.BackColor = System.Drawing.SystemColors.Control
        Me.txtDivisa.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtDivisa.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtDivisa.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtDivisa.Location = New System.Drawing.Point(134, 127)
        Me.txtDivisa.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDivisa.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDivisa.Name = "txtDivisa"
        Me.txtDivisa.ReadOnly = True
        Me.txtDivisa.Size = New System.Drawing.Size(150, 20)
        Me.txtDivisa.TabIndex = 36
        '
        'txtTotal
        '
        Me.txtTotal.AutoLock = False
        Me.txtTotal.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtTotal.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtTotal.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTotal.Location = New System.Drawing.Point(660, 103)
        Me.txtTotal.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotal.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(120, 20)
        Me.txtTotal.TabIndex = 35
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDescuentos
        '
        Me.txtDescuentos.AutoLock = False
        Me.txtDescuentos.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtDescuentos.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtDescuentos.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtDescuentos.Location = New System.Drawing.Point(660, 77)
        Me.txtDescuentos.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDescuentos.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDescuentos.Name = "txtDescuentos"
        Me.txtDescuentos.ReadOnly = True
        Me.txtDescuentos.Size = New System.Drawing.Size(120, 20)
        Me.txtDescuentos.TabIndex = 33
        Me.txtDescuentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRetenciones
        '
        Me.txtRetenciones.AutoLock = False
        Me.txtRetenciones.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtRetenciones.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtRetenciones.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtRetenciones.Location = New System.Drawing.Point(411, 125)
        Me.txtRetenciones.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRetenciones.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRetenciones.Name = "txtRetenciones"
        Me.txtRetenciones.ReadOnly = True
        Me.txtRetenciones.Size = New System.Drawing.Size(120, 20)
        Me.txtRetenciones.TabIndex = 31
        Me.txtRetenciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImpuestos
        '
        Me.txtImpuestos.AutoLock = False
        Me.txtImpuestos.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtImpuestos.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtImpuestos.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtImpuestos.Location = New System.Drawing.Point(411, 99)
        Me.txtImpuestos.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtImpuestos.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtImpuestos.Name = "txtImpuestos"
        Me.txtImpuestos.ReadOnly = True
        Me.txtImpuestos.Size = New System.Drawing.Size(120, 20)
        Me.txtImpuestos.TabIndex = 29
        Me.txtImpuestos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotal
        '
        Me.txtSubTotal.AutoLock = False
        Me.txtSubTotal.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtSubTotal.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtSubTotal.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtSubTotal.Location = New System.Drawing.Point(411, 74)
        Me.txtSubTotal.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSubTotal.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(120, 20)
        Me.txtSubTotal.TabIndex = 27
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalCant
        '
        Me.txtTotalCant.AutoLock = False
        Me.txtTotalCant.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotalCant.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtTotalCant.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtTotalCant.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTotalCant.Location = New System.Drawing.Point(134, 101)
        Me.txtTotalCant.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotalCant.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotalCant.Name = "txtTotalCant"
        Me.txtTotalCant.ReadOnly = True
        Me.txtTotalCant.Size = New System.Drawing.Size(150, 20)
        Me.txtTotalCant.TabIndex = 25
        Me.txtTotalCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CiLabel8
        '
        Me.CiLabel8.AutoSize = True
        Me.CiLabel8.Location = New System.Drawing.Point(558, 106)
        Me.CiLabel8.Name = "CiLabel8"
        Me.CiLabel8.Size = New System.Drawing.Size(34, 13)
        Me.CiLabel8.TabIndex = 34
        Me.CiLabel8.Text = "Total:"
        '
        'CiLabel7
        '
        Me.CiLabel7.AutoSize = True
        Me.CiLabel7.Location = New System.Drawing.Point(557, 80)
        Me.CiLabel7.Name = "CiLabel7"
        Me.CiLabel7.Size = New System.Drawing.Size(94, 13)
        Me.CiLabel7.TabIndex = 32
        Me.CiLabel7.Text = "Total Descuentos:"
        '
        'CiLabel6
        '
        Me.CiLabel6.AutoSize = True
        Me.CiLabel6.Location = New System.Drawing.Point(308, 129)
        Me.CiLabel6.Name = "CiLabel6"
        Me.CiLabel6.Size = New System.Drawing.Size(97, 13)
        Me.CiLabel6.TabIndex = 30
        Me.CiLabel6.Text = "Total Retenciones:"
        '
        'CiLabel5
        '
        Me.CiLabel5.AutoSize = True
        Me.CiLabel5.Location = New System.Drawing.Point(308, 102)
        Me.CiLabel5.Name = "CiLabel5"
        Me.CiLabel5.Size = New System.Drawing.Size(85, 13)
        Me.CiLabel5.TabIndex = 28
        Me.CiLabel5.Text = "Total Impuestos:"
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.Location = New System.Drawing.Point(309, 77)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(56, 13)
        Me.CiLabel4.TabIndex = 26
        Me.CiLabel4.Text = "Sub Total:"
        '
        'CiLabel13
        '
        Me.CiLabel13.AutoSize = True
        Me.CiLabel13.Location = New System.Drawing.Point(43, 104)
        Me.CiLabel13.Name = "CiLabel13"
        Me.CiLabel13.Size = New System.Drawing.Size(79, 13)
        Me.CiLabel13.TabIndex = 24
        Me.CiLabel13.Text = "Total Cantidad:"
        '
        'imlTab
        '
        Me.imlTab.ImageStream = CType(resources.GetObject("imlTab.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlTab.TransparentColor = System.Drawing.Color.Transparent
        Me.imlTab.Images.SetKeyName(0, "General")
        Me.imlTab.Images.SetKeyName(1, "Domicilio")
        Me.imlTab.Images.SetKeyName(2, "Factura")
        '
        'bsArticulos
        '
        Me.bsArticulos.Filter = ""
        '
        'grdArticulos
        '
        Me.grdArticulos.AllowUpdate = False
        Me.grdArticulos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdArticulos.DataSource = Me.bsArticulos
        Me.grdArticulos.Images.Add(CType(resources.GetObject("grdArticulos.Images"), System.Drawing.Image))
        Me.grdArticulos.Images.Add(CType(resources.GetObject("grdArticulos.Images1"), System.Drawing.Image))
        Me.grdArticulos.Location = New System.Drawing.Point(13, 443)
        Me.grdArticulos.Name = "grdArticulos"
        Me.grdArticulos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdArticulos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdArticulos.PreviewInfo.ZoomFactor = 75.0R
        Me.grdArticulos.PrintInfo.PageSettings = CType(resources.GetObject("grdArticulos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdArticulos.Size = New System.Drawing.Size(768, 148)
        Me.grdArticulos.TabIndex = 47
        Me.grdArticulos.Text = "AzTrueDBGrid1"
        Me.grdArticulos.PropBag = resources.GetString("grdArticulos.PropBag")
        '
        'tlbMenh
        '
        Me.tlbMenh.AccessibleName = "Tool Bar"
        Me.tlbMenh.AutoSize = False
        Me.tlbMenh.CommandHolder = Me.C1CommandHolder1
        Me.tlbMenh.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.btnAceptar, Me.btnCancelar})
        Me.tlbMenh.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbMenh.Location = New System.Drawing.Point(0, 0)
        Me.tlbMenh.MinButtonSize = 32
        Me.tlbMenh.Movable = False
        Me.tlbMenh.Name = "tlbMenh"
        Me.tlbMenh.Size = New System.Drawing.Size(793, 35)
        Me.tlbMenh.Text = "AzToolBar1"
        Me.tlbMenh.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdAceptar)
        Me.C1CommandHolder1.Commands.Add(Me.cmdCancelar)
        Me.C1CommandHolder1.Owner = Me
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnAceptar.Command = Me.cmdAceptar
        '
        'btnCancelar
        '
        Me.btnCancelar.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnCancelar.Command = Me.cmdCancelar
        Me.btnCancelar.SortOrder = 1
        '
        'CiLabel14
        '
        Me.CiLabel14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CiLabel14.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CiLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiLabel14.Location = New System.Drawing.Point(9, 38)
        Me.CiLabel14.Name = "CiLabel14"
        Me.CiLabel14.Size = New System.Drawing.Size(771, 21)
        Me.CiLabel14.TabIndex = 48
        Me.CiLabel14.Text = "Datos Generales del Embarque"
        Me.CiLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSelDomicilioEntrega
        '
        Me.btnSelDomicilioEntrega.Location = New System.Drawing.Point(440, 221)
        Me.btnSelDomicilioEntrega.Name = "btnSelDomicilioEntrega"
        Me.btnSelDomicilioEntrega.Size = New System.Drawing.Size(128, 23)
        Me.btnSelDomicilioEntrega.TabIndex = 61
        Me.btnSelDomicilioEntrega.Text = "Seleccionar Domicilio"
        Me.btnSelDomicilioEntrega.UseVisualStyleBackColor = True
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Location = New System.Drawing.Point(45, 227)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(33, 13)
        Me.lblCalle.TabIndex = 49
        Me.lblCalle.Text = "Calle:"
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
        Me.txtPoblacion.Location = New System.Drawing.Point(134, 328)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.txtPoblacion.Size = New System.Drawing.Size(300, 23)
        Me.txtPoblacion.TabIndex = 60
        Me.txtPoblacion.TextWidth = 70
        Me.txtPoblacion.UIName = "Población"
        '
        'txtCalle
        '
        Me.txtCalle.BackColor = System.Drawing.SystemColors.Window
        Me.txtCalle.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCalle.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCalle.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCalle.Location = New System.Drawing.Point(134, 224)
        Me.txtCalle.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalle.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(300, 20)
        Me.txtCalle.TabIndex = 50
        Me.txtCalle.UIName = Nothing
        '
        'lblColonia
        '
        Me.lblColonia.AutoSize = True
        Me.lblColonia.Location = New System.Drawing.Point(45, 279)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(45, 13)
        Me.lblColonia.TabIndex = 55
        Me.lblColonia.Text = "Colonia:"
        '
        'lblPoblacion
        '
        Me.lblPoblacion.AutoSize = True
        Me.lblPoblacion.Location = New System.Drawing.Point(45, 331)
        Me.lblPoblacion.Name = "lblPoblacion"
        Me.lblPoblacion.Size = New System.Drawing.Size(57, 13)
        Me.lblPoblacion.TabIndex = 59
        Me.lblPoblacion.Text = "Población:"
        '
        'txtCP
        '
        Me.txtCP.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCP.Digits = True
        Me.txtCP.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCP.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCP.Location = New System.Drawing.Point(134, 302)
        Me.txtCP.MaxLength = 5
        Me.txtCP.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCP.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(70, 20)
        Me.txtCP.TabIndex = 58
        Me.txtCP.UIName = Nothing
        '
        'txtNumExt
        '
        Me.txtNumExt.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNumExt.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNumExt.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumExt.Location = New System.Drawing.Point(134, 250)
        Me.txtNumExt.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExt.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExt.Name = "txtNumExt"
        Me.txtNumExt.Size = New System.Drawing.Size(70, 20)
        Me.txtNumExt.TabIndex = 52
        Me.txtNumExt.UIName = Nothing
        '
        'lblNumExt
        '
        Me.lblNumExt.AutoSize = True
        Me.lblNumExt.Location = New System.Drawing.Point(45, 253)
        Me.lblNumExt.Name = "lblNumExt"
        Me.lblNumExt.Size = New System.Drawing.Size(65, 13)
        Me.lblNumExt.TabIndex = 51
        Me.lblNumExt.Text = "No. Exterior:"
        '
        'lblCodigoPostal
        '
        Me.lblCodigoPostal.AutoSize = True
        Me.lblCodigoPostal.Location = New System.Drawing.Point(45, 305)
        Me.lblCodigoPostal.Name = "lblCodigoPostal"
        Me.lblCodigoPostal.Size = New System.Drawing.Size(75, 13)
        Me.lblCodigoPostal.TabIndex = 57
        Me.lblCodigoPostal.Text = "Código Postal:"
        '
        'txtColonia
        '
        Me.txtColonia.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtColonia.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtColonia.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtColonia.Location = New System.Drawing.Point(134, 276)
        Me.txtColonia.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColonia.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(300, 20)
        Me.txtColonia.TabIndex = 56
        Me.txtColonia.UIName = Nothing
        '
        'txtNumInt
        '
        Me.txtNumInt.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNumInt.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNumInt.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumInt.Location = New System.Drawing.Point(281, 247)
        Me.txtNumInt.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumInt.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumInt.Name = "txtNumInt"
        Me.txtNumInt.Size = New System.Drawing.Size(70, 20)
        Me.txtNumInt.TabIndex = 54
        Me.txtNumInt.UIName = Nothing
        '
        'lblNumInt
        '
        Me.lblNumInt.AutoSize = True
        Me.lblNumInt.Location = New System.Drawing.Point(213, 250)
        Me.lblNumInt.Name = "lblNumInt"
        Me.lblNumInt.Size = New System.Drawing.Size(62, 13)
        Me.lblNumInt.TabIndex = 53
        Me.lblNumInt.Text = "No. Interior:"
        '
        'CiLabel15
        '
        Me.CiLabel15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CiLabel15.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CiLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiLabel15.Location = New System.Drawing.Point(9, 185)
        Me.CiLabel15.Name = "CiLabel15"
        Me.CiLabel15.Size = New System.Drawing.Size(771, 21)
        Me.CiLabel15.TabIndex = 62
        Me.CiLabel15.Text = "Domicilio de Entrega"
        Me.CiLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CiLabel16
        '
        Me.CiLabel16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CiLabel16.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CiLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiLabel16.Location = New System.Drawing.Point(9, 364)
        Me.CiLabel16.Name = "CiLabel16"
        Me.CiLabel16.Size = New System.Drawing.Size(771, 21)
        Me.CiLabel16.TabIndex = 63
        Me.CiLabel16.Text = "Artículos"
        Me.CiLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rdbCompleto
        '
        Me.rdbCompleto.AutoSize = True
        Me.rdbCompleto.Checked = True
        Me.rdbCompleto.Location = New System.Drawing.Point(47, 397)
        Me.rdbCompleto.Name = "rdbCompleto"
        Me.rdbCompleto.Size = New System.Drawing.Size(238, 17)
        Me.rdbCompleto.TabIndex = 64
        Me.rdbCompleto.TabStop = True
        Me.rdbCompleto.Text = "Generar un embarque con todos los artículos"
        Me.rdbCompleto.UseVisualStyleBackColor = True
        '
        'rdbParcial
        '
        Me.rdbParcial.AutoSize = True
        Me.rdbParcial.Location = New System.Drawing.Point(46, 420)
        Me.rdbParcial.Name = "rdbParcial"
        Me.rdbParcial.Size = New System.Drawing.Size(162, 17)
        Me.rdbParcial.TabIndex = 65
        Me.rdbParcial.Text = "Generar un embarque parcial"
        Me.rdbParcial.UseVisualStyleBackColor = True
        '
        'EditEmbarqueForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 603)
        Me.ControlBox = False
        Me.Controls.Add(Me.rdbParcial)
        Me.Controls.Add(Me.rdbCompleto)
        Me.Controls.Add(Me.CiLabel16)
        Me.Controls.Add(Me.CiLabel15)
        Me.Controls.Add(Me.btnSelDomicilioEntrega)
        Me.Controls.Add(Me.lblCalle)
        Me.Controls.Add(Me.txtPoblacion)
        Me.Controls.Add(Me.txtCalle)
        Me.Controls.Add(Me.lblColonia)
        Me.Controls.Add(Me.lblPoblacion)
        Me.Controls.Add(Me.txtCP)
        Me.Controls.Add(Me.txtNumExt)
        Me.Controls.Add(Me.lblNumExt)
        Me.Controls.Add(Me.lblCodigoPostal)
        Me.Controls.Add(Me.txtColonia)
        Me.Controls.Add(Me.txtNumInt)
        Me.Controls.Add(Me.lblNumInt)
        Me.Controls.Add(Me.CiLabel12)
        Me.Controls.Add(Me.txtTipoCambio)
        Me.Controls.Add(Me.lblOrden)
        Me.Controls.Add(Me.CiLabel11)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.txtDivisa)
        Me.Controls.Add(Me.CiLabel14)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtDescuentos)
        Me.Controls.Add(Me.tlbMenh)
        Me.Controls.Add(Me.txtRetenciones)
        Me.Controls.Add(Me.txtImpuestos)
        Me.Controls.Add(Me.grdArticulos)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.txtTotalCant)
        Me.Controls.Add(Me.CiLabel13)
        Me.Controls.Add(Me.CiLabel4)
        Me.Controls.Add(Me.CiLabel5)
        Me.Controls.Add(Me.CiLabel6)
        Me.Controls.Add(Me.CiLabel7)
        Me.Controls.Add(Me.CiLabel8)
        Me.MinimizeBox = False
        Me.Name = "EditEmbarqueForm"
        Me.Text = "Nuevo Embarque"
        CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblOrden As Azteca.Windows.Controls.CILabel
    Friend WithEvents grdArticulos As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents tlbMenh As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents cmdAceptar As C1.Win.C1Command.C1Command
    Friend WithEvents cmdCancelar As C1.Win.C1Command.C1Command
    Friend WithEvents btnAceptar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents btnCancelar As C1.Win.C1Command.C1CommandLink
    Private WithEvents imlTab As System.Windows.Forms.ImageList
    Private WithEvents bsArticulos As System.Windows.Forms.BindingSource
    Friend WithEvents CiLabel12 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtTipoCambio As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel11 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtDivisa As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtTotal As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtDescuentos As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtRetenciones As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtImpuestos As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtSubTotal As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtTotalCant As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel8 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel7 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel6 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel5 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel13 As Azteca.Windows.Controls.CILabel
    Friend WithEvents rdbParcial As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents rdbCompleto As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents CiLabel16 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel15 As Azteca.Windows.Controls.CILabel
    Friend WithEvents btnSelDomicilioEntrega As Azteca.Windows.Controls.CIButton
    Friend WithEvents lblCalle As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtPoblacion As Azteca.Windows.Controls.General.PoblacionSelector
    Friend WithEvents txtCalle As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblColonia As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblPoblacion As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCP As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtNumExt As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblNumExt As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCodigoPostal As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtColonia As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtNumInt As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblNumInt As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel14 As Azteca.Windows.Controls.CILabel
    Private WithEvents bsUnidades As System.Windows.Forms.BindingSource
End Class
