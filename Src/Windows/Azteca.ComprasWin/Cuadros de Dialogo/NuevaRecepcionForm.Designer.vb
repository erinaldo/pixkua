<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevaRecepcionForm
    Inherits Azteca.Windows.Forms.BaseForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevaRecepcionForm))
        Me.tlbMenu = New C1.Win.C1Command.C1ToolBar()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdAceptar = New C1.Win.C1Command.C1Command()
        Me.cmdCancelar = New C1.Win.C1Command.C1Command()
        Me.btnAceptar = New C1.Win.C1Command.C1CommandLink()
        Me.btnCancelar = New C1.Win.C1Command.C1CommandLink()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.grpFactura = New Azteca.Windows.Controls.CIGroupBox()
        Me.btnSelFactura = New Azteca.Windows.Controls.CIButton()
        Me.txtTotalFact = New Azteca.Windows.Controls.CITextBox()
        Me.txtRetencionesFact = New Azteca.Windows.Controls.CITextBox()
        Me.txtImpuestosFact = New Azteca.Windows.Controls.CITextBox()
        Me.txtSubTotalFact = New Azteca.Windows.Controls.CITextBox()
        Me.txtUUID = New Azteca.Windows.Controls.CITextBox()
        Me.txtFolio = New Azteca.Windows.Controls.CITextBox()
        Me.txtSerie = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel7 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel6 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel5 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.imlPartidas = New System.Windows.Forms.ImageList(Me.components)
        Me.bsArticulos = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsServicios = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdArticulos = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.grdServicios = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.grpRecepcion = New Azteca.Windows.Controls.CIGroupBox()
        Me.cboDivisa = New Azteca.Windows.Contabilidad.DivisasComboBox()
        Me.CiLabel13 = New Azteca.Windows.Controls.CILabel()
        Me.txtFlete = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel12 = New Azteca.Windows.Controls.CILabel()
        Me.txtTotalRec = New Azteca.Windows.Controls.CITextBox()
        Me.txtRetencionesRec = New Azteca.Windows.Controls.CITextBox()
        Me.txtImpuestosRec = New Azteca.Windows.Controls.CITextBox()
        Me.txtSubTotalRec = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel8 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel9 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel10 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel11 = New Azteca.Windows.Controls.CILabel()
        Me.tabPartidas = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagArticulos = New C1.Win.C1Command.C1DockingTabPage()
        Me.pagServicios = New C1.Win.C1Command.C1DockingTabPage()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFactura.SuspendLayout()
        CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRecepcion.SuspendLayout()
        CType(Me.tabPartidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPartidas.SuspendLayout()
        Me.pagArticulos.SuspendLayout()
        Me.pagServicios.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlbMenu
        '
        Me.tlbMenu.AccessibleName = "Tool Bar"
        Me.tlbMenu.AutoSize = False
        Me.tlbMenu.CommandHolder = Me.C1CommandHolder1
        Me.tlbMenu.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.btnAceptar, Me.btnCancelar})
        Me.tlbMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlbMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.tlbMenu.MinButtonSize = 32
        Me.tlbMenu.Movable = False
        Me.tlbMenu.Name = "tlbMenu"
        Me.tlbMenu.Size = New System.Drawing.Size(1023, 37)
        Me.tlbMenu.Text = "C1ToolBar1"
        Me.tlbMenu.VisualStyle = C1.Win.C1Command.VisualStyle.System
        Me.tlbMenu.VisualStyleBase = C1.Win.C1Command.VisualStyle.System
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
        Me.cmdAceptar.ShortcutText = ""
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.ShortcutText = ""
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
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(28, 34)
        Me.CiLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(45, 17)
        Me.CiLabel1.TabIndex = 0
        Me.CiLabel1.Text = "Serie:"
        '
        'grpFactura
        '
        Me.grpFactura.Controls.Add(Me.btnSelFactura)
        Me.grpFactura.Controls.Add(Me.txtTotalFact)
        Me.grpFactura.Controls.Add(Me.txtRetencionesFact)
        Me.grpFactura.Controls.Add(Me.txtImpuestosFact)
        Me.grpFactura.Controls.Add(Me.txtSubTotalFact)
        Me.grpFactura.Controls.Add(Me.txtUUID)
        Me.grpFactura.Controls.Add(Me.txtFolio)
        Me.grpFactura.Controls.Add(Me.txtSerie)
        Me.grpFactura.Controls.Add(Me.CiLabel7)
        Me.grpFactura.Controls.Add(Me.CiLabel6)
        Me.grpFactura.Controls.Add(Me.CiLabel5)
        Me.grpFactura.Controls.Add(Me.CiLabel4)
        Me.grpFactura.Controls.Add(Me.CiLabel3)
        Me.grpFactura.Controls.Add(Me.CiLabel2)
        Me.grpFactura.Controls.Add(Me.CiLabel1)
        Me.grpFactura.Location = New System.Drawing.Point(16, 44)
        Me.grpFactura.Margin = New System.Windows.Forms.Padding(4)
        Me.grpFactura.Name = "grpFactura"
        Me.grpFactura.Padding = New System.Windows.Forms.Padding(4)
        Me.grpFactura.Size = New System.Drawing.Size(625, 233)
        Me.grpFactura.TabIndex = 0
        Me.grpFactura.TabStop = False
        Me.grpFactura.Text = "Factura"
        '
        'btnSelFactura
        '
        Me.btnSelFactura.Location = New System.Drawing.Point(447, 28)
        Me.btnSelFactura.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSelFactura.Name = "btnSelFactura"
        Me.btnSelFactura.Size = New System.Drawing.Size(164, 28)
        Me.btnSelFactura.TabIndex = 3
        Me.btnSelFactura.Text = "Seleccionar Factura"
        Me.btnSelFactura.UseVisualStyleBackColor = True
        '
        'txtTotalFact
        '
        Me.txtTotalFact.Digits = True
        Me.txtTotalFact.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtTotalFact.Format = "C"
        Me.txtTotalFact.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTotalFact.Location = New System.Drawing.Point(129, 191)
        Me.txtTotalFact.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalFact.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotalFact.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotalFact.Name = "txtTotalFact"
        Me.txtTotalFact.ReadOnly = True
        Me.txtTotalFact.Size = New System.Drawing.Size(168, 22)
        Me.txtTotalFact.TabIndex = 13
        Me.txtTotalFact.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRetencionesFact
        '
        Me.txtRetencionesFact.Digits = True
        Me.txtRetencionesFact.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtRetencionesFact.Format = "C"
        Me.txtRetencionesFact.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtRetencionesFact.Location = New System.Drawing.Point(129, 159)
        Me.txtRetencionesFact.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRetencionesFact.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRetencionesFact.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRetencionesFact.Name = "txtRetencionesFact"
        Me.txtRetencionesFact.ReadOnly = True
        Me.txtRetencionesFact.Size = New System.Drawing.Size(168, 22)
        Me.txtRetencionesFact.TabIndex = 11
        Me.txtRetencionesFact.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImpuestosFact
        '
        Me.txtImpuestosFact.Digits = True
        Me.txtImpuestosFact.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtImpuestosFact.Format = "C"
        Me.txtImpuestosFact.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtImpuestosFact.Location = New System.Drawing.Point(129, 127)
        Me.txtImpuestosFact.Margin = New System.Windows.Forms.Padding(4)
        Me.txtImpuestosFact.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtImpuestosFact.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtImpuestosFact.Name = "txtImpuestosFact"
        Me.txtImpuestosFact.ReadOnly = True
        Me.txtImpuestosFact.Size = New System.Drawing.Size(168, 22)
        Me.txtImpuestosFact.TabIndex = 9
        Me.txtImpuestosFact.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotalFact
        '
        Me.txtSubTotalFact.Digits = True
        Me.txtSubTotalFact.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtSubTotalFact.Format = "C"
        Me.txtSubTotalFact.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtSubTotalFact.Location = New System.Drawing.Point(129, 95)
        Me.txtSubTotalFact.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSubTotalFact.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSubTotalFact.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSubTotalFact.Name = "txtSubTotalFact"
        Me.txtSubTotalFact.ReadOnly = True
        Me.txtSubTotalFact.Size = New System.Drawing.Size(168, 22)
        Me.txtSubTotalFact.TabIndex = 7
        Me.txtSubTotalFact.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUUID
        '
        Me.txtUUID.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtUUID.Location = New System.Drawing.Point(129, 63)
        Me.txtUUID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUUID.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtUUID.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtUUID.Name = "txtUUID"
        Me.txtUUID.ReadOnly = True
        Me.txtUUID.Size = New System.Drawing.Size(308, 22)
        Me.txtUUID.TabIndex = 5
        '
        'txtFolio
        '
        Me.txtFolio.Digits = True
        Me.txtFolio.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtFolio.Location = New System.Drawing.Point(335, 31)
        Me.txtFolio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFolio.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFolio.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.ReadOnly = True
        Me.txtFolio.Size = New System.Drawing.Size(103, 22)
        Me.txtFolio.TabIndex = 2
        '
        'txtSerie
        '
        Me.txtSerie.BackColor = System.Drawing.SystemColors.Window
        Me.txtSerie.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtSerie.Location = New System.Drawing.Point(129, 31)
        Me.txtSerie.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSerie.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSerie.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.ReadOnly = True
        Me.txtSerie.Size = New System.Drawing.Size(145, 22)
        Me.txtSerie.TabIndex = 1
        '
        'CiLabel7
        '
        Me.CiLabel7.AutoSize = True
        Me.CiLabel7.Location = New System.Drawing.Point(28, 194)
        Me.CiLabel7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CiLabel7.Name = "CiLabel7"
        Me.CiLabel7.Size = New System.Drawing.Size(44, 17)
        Me.CiLabel7.TabIndex = 12
        Me.CiLabel7.Text = "Total:"
        '
        'CiLabel6
        '
        Me.CiLabel6.AutoSize = True
        Me.CiLabel6.Location = New System.Drawing.Point(28, 162)
        Me.CiLabel6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CiLabel6.Name = "CiLabel6"
        Me.CiLabel6.Size = New System.Drawing.Size(91, 17)
        Me.CiLabel6.TabIndex = 10
        Me.CiLabel6.Text = "Retenciones:"
        '
        'CiLabel5
        '
        Me.CiLabel5.AutoSize = True
        Me.CiLabel5.Location = New System.Drawing.Point(28, 130)
        Me.CiLabel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CiLabel5.Name = "CiLabel5"
        Me.CiLabel5.Size = New System.Drawing.Size(76, 17)
        Me.CiLabel5.TabIndex = 8
        Me.CiLabel5.Text = "Impuestos:"
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.Location = New System.Drawing.Point(28, 98)
        Me.CiLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(73, 17)
        Me.CiLabel4.TabIndex = 6
        Me.CiLabel4.Text = "Sub Total:"
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(28, 66)
        Me.CiLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(45, 17)
        Me.CiLabel3.TabIndex = 4
        Me.CiLabel3.Text = "UUID:"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(284, 34)
        Me.CiLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(42, 17)
        Me.CiLabel2.TabIndex = 2
        Me.CiLabel2.Text = "Folio:"
        '
        'imlPartidas
        '
        Me.imlPartidas.ImageStream = CType(resources.GetObject("imlPartidas.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlPartidas.TransparentColor = System.Drawing.Color.Transparent
        Me.imlPartidas.Images.SetKeyName(0, "Articulos")
        Me.imlPartidas.Images.SetKeyName(1, "Servicios")
        '
        'bsArticulos
        '
        Me.bsArticulos.Filter = ""
        '
        'bsServicios
        '
        Me.bsServicios.Filter = ""
        '
        'grdArticulos
        '
        Me.grdArticulos.CellTips = C1.Win.C1TrueDBGrid.CellTipEnum.Anchored
        Me.grdArticulos.DataSource = Me.bsArticulos
        Me.grdArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdArticulos.Images.Add(CType(resources.GetObject("grdArticulos.Images"), System.Drawing.Image))
        Me.grdArticulos.Location = New System.Drawing.Point(0, 0)
        Me.grdArticulos.Name = "grdArticulos"
        Me.grdArticulos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdArticulos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdArticulos.PreviewInfo.ZoomFactor = 75.0R
        Me.grdArticulos.PrintInfo.PageSettings = CType(resources.GetObject("grdArticulos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdArticulos.Size = New System.Drawing.Size(989, 260)
        Me.grdArticulos.TabIndex = 2
        Me.grdArticulos.Text = "AzTrueDBGrid1"
        Me.grdArticulos.PropBag = resources.GetString("grdArticulos.PropBag")
        '
        'grdServicios
        '
        Me.grdServicios.CellTips = C1.Win.C1TrueDBGrid.CellTipEnum.Anchored
        Me.grdServicios.DataSource = Me.bsServicios
        Me.grdServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdServicios.Images.Add(CType(resources.GetObject("grdServicios.Images"), System.Drawing.Image))
        Me.grdServicios.Location = New System.Drawing.Point(0, 0)
        Me.grdServicios.Name = "grdServicios"
        Me.grdServicios.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdServicios.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdServicios.PreviewInfo.ZoomFactor = 75.0R
        Me.grdServicios.PrintInfo.PageSettings = CType(resources.GetObject("grdServicios.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdServicios.Size = New System.Drawing.Size(989, 260)
        Me.grdServicios.TabIndex = 2
        Me.grdServicios.Text = "AzTrueDBGrid1"
        Me.grdServicios.PropBag = resources.GetString("grdServicios.PropBag")
        '
        'grpRecepcion
        '
        Me.grpRecepcion.Controls.Add(Me.cboDivisa)
        Me.grpRecepcion.Controls.Add(Me.CiLabel13)
        Me.grpRecepcion.Controls.Add(Me.txtFlete)
        Me.grpRecepcion.Controls.Add(Me.CiLabel12)
        Me.grpRecepcion.Controls.Add(Me.txtTotalRec)
        Me.grpRecepcion.Controls.Add(Me.txtRetencionesRec)
        Me.grpRecepcion.Controls.Add(Me.txtImpuestosRec)
        Me.grpRecepcion.Controls.Add(Me.txtSubTotalRec)
        Me.grpRecepcion.Controls.Add(Me.CiLabel8)
        Me.grpRecepcion.Controls.Add(Me.CiLabel9)
        Me.grpRecepcion.Controls.Add(Me.CiLabel10)
        Me.grpRecepcion.Controls.Add(Me.CiLabel11)
        Me.grpRecepcion.Location = New System.Drawing.Point(649, 44)
        Me.grpRecepcion.Margin = New System.Windows.Forms.Padding(4)
        Me.grpRecepcion.Name = "grpRecepcion"
        Me.grpRecepcion.Padding = New System.Windows.Forms.Padding(4)
        Me.grpRecepcion.Size = New System.Drawing.Size(357, 233)
        Me.grpRecepcion.TabIndex = 1
        Me.grpRecepcion.TabStop = False
        Me.grpRecepcion.Text = "Recepción"
        '
        'cboDivisa
        '
        Me.cboDivisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDivisa.Enabled = False
        Me.cboDivisa.FormattingEnabled = True
        Me.cboDivisa.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboDivisa.ItemsTable = Nothing
        Me.cboDivisa.Location = New System.Drawing.Point(128, 25)
        Me.cboDivisa.Name = "cboDivisa"
        Me.cboDivisa.Size = New System.Drawing.Size(169, 24)
        Me.cboDivisa.TabIndex = 1
        Me.cboDivisa.UIName = Nothing
        '
        'CiLabel13
        '
        Me.CiLabel13.AutoSize = True
        Me.CiLabel13.Location = New System.Drawing.Point(27, 28)
        Me.CiLabel13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CiLabel13.Name = "CiLabel13"
        Me.CiLabel13.Size = New System.Drawing.Size(50, 17)
        Me.CiLabel13.TabIndex = 0
        Me.CiLabel13.Text = "Divisa:"
        '
        'txtFlete
        '
        Me.txtFlete.Digits = True
        Me.txtFlete.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtFlete.Format = "C"
        Me.txtFlete.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtFlete.Location = New System.Drawing.Point(128, 154)
        Me.txtFlete.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFlete.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFlete.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFlete.Name = "txtFlete"
        Me.txtFlete.Size = New System.Drawing.Size(169, 22)
        Me.txtFlete.TabIndex = 9
        Me.txtFlete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CiLabel12
        '
        Me.CiLabel12.AutoSize = True
        Me.CiLabel12.Location = New System.Drawing.Point(27, 158)
        Me.CiLabel12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CiLabel12.Name = "CiLabel12"
        Me.CiLabel12.Size = New System.Drawing.Size(43, 17)
        Me.CiLabel12.TabIndex = 8
        Me.CiLabel12.Text = "Flete:"
        '
        'txtTotalRec
        '
        Me.txtTotalRec.Digits = True
        Me.txtTotalRec.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtTotalRec.Format = "C"
        Me.txtTotalRec.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTotalRec.Location = New System.Drawing.Point(128, 186)
        Me.txtTotalRec.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalRec.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotalRec.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotalRec.Name = "txtTotalRec"
        Me.txtTotalRec.ReadOnly = True
        Me.txtTotalRec.Size = New System.Drawing.Size(169, 22)
        Me.txtTotalRec.TabIndex = 11
        Me.txtTotalRec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRetencionesRec
        '
        Me.txtRetencionesRec.Digits = True
        Me.txtRetencionesRec.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtRetencionesRec.Format = "C"
        Me.txtRetencionesRec.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtRetencionesRec.Location = New System.Drawing.Point(128, 122)
        Me.txtRetencionesRec.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRetencionesRec.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRetencionesRec.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRetencionesRec.Name = "txtRetencionesRec"
        Me.txtRetencionesRec.ReadOnly = True
        Me.txtRetencionesRec.Size = New System.Drawing.Size(169, 22)
        Me.txtRetencionesRec.TabIndex = 7
        Me.txtRetencionesRec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImpuestosRec
        '
        Me.txtImpuestosRec.Digits = True
        Me.txtImpuestosRec.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtImpuestosRec.Format = "C"
        Me.txtImpuestosRec.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtImpuestosRec.Location = New System.Drawing.Point(128, 90)
        Me.txtImpuestosRec.Margin = New System.Windows.Forms.Padding(4)
        Me.txtImpuestosRec.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtImpuestosRec.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtImpuestosRec.Name = "txtImpuestosRec"
        Me.txtImpuestosRec.ReadOnly = True
        Me.txtImpuestosRec.Size = New System.Drawing.Size(169, 22)
        Me.txtImpuestosRec.TabIndex = 5
        Me.txtImpuestosRec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotalRec
        '
        Me.txtSubTotalRec.Digits = True
        Me.txtSubTotalRec.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtSubTotalRec.Format = "C"
        Me.txtSubTotalRec.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtSubTotalRec.Location = New System.Drawing.Point(128, 58)
        Me.txtSubTotalRec.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSubTotalRec.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSubTotalRec.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSubTotalRec.Name = "txtSubTotalRec"
        Me.txtSubTotalRec.ReadOnly = True
        Me.txtSubTotalRec.Size = New System.Drawing.Size(169, 22)
        Me.txtSubTotalRec.TabIndex = 3
        Me.txtSubTotalRec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CiLabel8
        '
        Me.CiLabel8.AutoSize = True
        Me.CiLabel8.Location = New System.Drawing.Point(27, 190)
        Me.CiLabel8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CiLabel8.Name = "CiLabel8"
        Me.CiLabel8.Size = New System.Drawing.Size(44, 17)
        Me.CiLabel8.TabIndex = 10
        Me.CiLabel8.Text = "Total:"
        '
        'CiLabel9
        '
        Me.CiLabel9.AutoSize = True
        Me.CiLabel9.Location = New System.Drawing.Point(27, 126)
        Me.CiLabel9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CiLabel9.Name = "CiLabel9"
        Me.CiLabel9.Size = New System.Drawing.Size(91, 17)
        Me.CiLabel9.TabIndex = 6
        Me.CiLabel9.Text = "Retenciones:"
        '
        'CiLabel10
        '
        Me.CiLabel10.AutoSize = True
        Me.CiLabel10.Location = New System.Drawing.Point(27, 94)
        Me.CiLabel10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CiLabel10.Name = "CiLabel10"
        Me.CiLabel10.Size = New System.Drawing.Size(76, 17)
        Me.CiLabel10.TabIndex = 4
        Me.CiLabel10.Text = "Impuestos:"
        '
        'CiLabel11
        '
        Me.CiLabel11.AutoSize = True
        Me.CiLabel11.Location = New System.Drawing.Point(27, 62)
        Me.CiLabel11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CiLabel11.Name = "CiLabel11"
        Me.CiLabel11.Size = New System.Drawing.Size(73, 17)
        Me.CiLabel11.TabIndex = 2
        Me.CiLabel11.Text = "Sub Total:"
        '
        'tabPartidas
        '
        Me.tabPartidas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabPartidas.Controls.Add(Me.pagArticulos)
        Me.tabPartidas.Controls.Add(Me.pagServicios)
        Me.tabPartidas.ImageList = Me.imlPartidas
        Me.tabPartidas.Location = New System.Drawing.Point(16, 284)
        Me.tabPartidas.Margin = New System.Windows.Forms.Padding(4)
        Me.tabPartidas.Name = "tabPartidas"
        Me.tabPartidas.SelectedIndex = 1
        Me.tabPartidas.Size = New System.Drawing.Size(991, 302)
        Me.tabPartidas.TabIndex = 4
        Me.tabPartidas.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabPartidas.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabPartidas.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagArticulos
        '
        Me.pagArticulos.Controls.Add(Me.grdArticulos)
        Me.pagArticulos.ImageIndex = 0
        Me.pagArticulos.Location = New System.Drawing.Point(1, 41)
        Me.pagArticulos.Name = "pagArticulos"
        Me.pagArticulos.Size = New System.Drawing.Size(989, 260)
        Me.pagArticulos.TabIndex = 0
        Me.pagArticulos.Text = "Artículos"
        '
        'pagServicios
        '
        Me.pagServicios.Controls.Add(Me.grdServicios)
        Me.pagServicios.ImageIndex = 1
        Me.pagServicios.Location = New System.Drawing.Point(1, 41)
        Me.pagServicios.Name = "pagServicios"
        Me.pagServicios.Size = New System.Drawing.Size(989, 260)
        Me.pagServicios.TabIndex = 1
        Me.pagServicios.Text = "Servicios"
        '
        'NuevaRecepcionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 601)
        Me.ControlBox = False
        Me.Controls.Add(Me.tabPartidas)
        Me.Controls.Add(Me.grpRecepcion)
        Me.Controls.Add(Me.grpFactura)
        Me.Controls.Add(Me.tlbMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "NuevaRecepcionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nueva recepción de orden de compra"
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFactura.ResumeLayout(False)
        Me.grpFactura.PerformLayout()
        CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRecepcion.ResumeLayout(False)
        Me.grpRecepcion.PerformLayout()
        CType(Me.tabPartidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPartidas.ResumeLayout(False)
        Me.pagArticulos.ResumeLayout(False)
        Me.pagServicios.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlbMenu As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents cmdAceptar As C1.Win.C1Command.C1Command
    Friend WithEvents cmdCancelar As C1.Win.C1Command.C1Command
    Friend WithEvents btnAceptar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents btnCancelar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents grpFactura As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents btnSelFactura As Azteca.Windows.Controls.CIButton
    Friend WithEvents txtTotalFact As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtRetencionesFact As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtImpuestosFact As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtSubTotalFact As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtUUID As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtFolio As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtSerie As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel7 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel6 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel5 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents imlPartidas As System.Windows.Forms.ImageList
    Friend WithEvents bsArticulos As System.Windows.Forms.BindingSource
    Friend WithEvents bsServicios As System.Windows.Forms.BindingSource
    Friend WithEvents grdArticulos As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents grdServicios As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents grpRecepcion As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents txtTotalRec As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtRetencionesRec As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtImpuestosRec As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtSubTotalRec As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel8 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel9 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel10 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel11 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtFlete As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel12 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel13 As Azteca.Windows.Controls.CILabel
    Friend WithEvents tabPartidas As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagArticulos As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagServicios As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents cboDivisa As Azteca.Windows.Contabilidad.DivisasComboBox
End Class
