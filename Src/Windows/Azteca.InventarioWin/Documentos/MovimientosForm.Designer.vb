<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MovimientosForm
    Inherits Azteca.Windows.Forms.BusinessForms.DocumentForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MovimientosForm))
        Dim Style1 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style2 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style3 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style4 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style5 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style6 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style7 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style8 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.grpTipo = New Azteca.Windows.Controls.CIGroupBox()
        Me.rdbSalida = New Azteca.Windows.Controls.CIRadioButton()
        Me.rdbEntrada = New Azteca.Windows.Controls.CIRadioButton()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel5 = New Azteca.Windows.Controls.CILabel()
        Me.txtNotas = New Azteca.Windows.Controls.CITextBox()
        Me.txtFechaAplicado = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel6 = New Azteca.Windows.Controls.CILabel()
        Me.txtTotalFlete = New Azteca.Windows.Controls.CITextBox()
        Me.txtTotalCosto = New Azteca.Windows.Controls.CITextBox()
        Me.txtTotalCant = New Azteca.Windows.Controls.CITextBox()
        Me.cboAlmacen = New Azteca.Windows.Inventario.AlmacenesComboBox()
        Me.cboConcepto = New Azteca.Windows.Inventario.ConceptosComboBox()
        Me.imlMovimiento = New System.Windows.Forms.ImageList(Me.components)
        Me.bsDetalle = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboUnidades = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.bsUnidades = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdPartidas = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.tabMovimiento = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagMovimiento = New C1.Win.C1Command.C1DockingTabPage()
        Me.txtOrdenTrabajo = New System.Windows.Forms.TextBox()
        Me.CiLabel7 = New Azteca.Windows.Controls.CILabel()
        Me.pagNotas = New C1.Win.C1Command.C1DockingTabPage()
        Me.grpTipo.SuspendLayout()
        CType(Me.bsDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdPartidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabMovimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMovimiento.SuspendLayout()
        Me.pagMovimiento.SuspendLayout()
        Me.pagNotas.SuspendLayout()
        Me.SuspendLayout()
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel1.Location = New System.Drawing.Point(21, 115)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(51, 13)
        Me.CiLabel1.TabIndex = 3
        Me.CiLabel1.Text = "Almacén:"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel2.Location = New System.Drawing.Point(21, 88)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(56, 13)
        Me.CiLabel2.TabIndex = 1
        Me.CiLabel2.Text = "Concepto:"
        '
        'grpTipo
        '
        Me.grpTipo.BackColor = System.Drawing.Color.Transparent
        Me.grpTipo.Controls.Add(Me.rdbSalida)
        Me.grpTipo.Controls.Add(Me.rdbEntrada)
        Me.grpTipo.Location = New System.Drawing.Point(83, 8)
        Me.grpTipo.Name = "grpTipo"
        Me.grpTipo.Size = New System.Drawing.Size(258, 71)
        Me.grpTipo.TabIndex = 0
        Me.grpTipo.TabStop = False
        Me.grpTipo.Text = "Tipo de Movimiento"
        '
        'rdbSalida
        '
        Me.rdbSalida.AutoSize = True
        Me.rdbSalida.Location = New System.Drawing.Point(22, 42)
        Me.rdbSalida.Name = "rdbSalida"
        Me.rdbSalida.Size = New System.Drawing.Size(54, 17)
        Me.rdbSalida.TabIndex = 1
        Me.rdbSalida.Text = "Salida"
        Me.rdbSalida.UseVisualStyleBackColor = True
        '
        'rdbEntrada
        '
        Me.rdbEntrada.AutoSize = True
        Me.rdbEntrada.Checked = True
        Me.rdbEntrada.Location = New System.Drawing.Point(22, 19)
        Me.rdbEntrada.Name = "rdbEntrada"
        Me.rdbEntrada.Size = New System.Drawing.Size(62, 17)
        Me.rdbEntrada.TabIndex = 0
        Me.rdbEntrada.TabStop = True
        Me.rdbEntrada.Text = "Entrada"
        Me.rdbEntrada.UseVisualStyleBackColor = True
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel3.Location = New System.Drawing.Point(349, 43)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(79, 13)
        Me.CiLabel3.TabIndex = 7
        Me.CiLabel3.Text = "Total Cantidad:"
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel4.Location = New System.Drawing.Point(349, 69)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(64, 13)
        Me.CiLabel4.TabIndex = 9
        Me.CiLabel4.Text = "Total Costo:"
        '
        'CiLabel5
        '
        Me.CiLabel5.AutoSize = True
        Me.CiLabel5.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel5.Location = New System.Drawing.Point(349, 17)
        Me.CiLabel5.Name = "CiLabel5"
        Me.CiLabel5.Size = New System.Drawing.Size(33, 13)
        Me.CiLabel5.TabIndex = 5
        Me.CiLabel5.Text = "Flete:"
        '
        'txtNotas
        '
        Me.txtNotas.BackColor = System.Drawing.SystemColors.Window
        Me.txtNotas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNotas.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNotas.Location = New System.Drawing.Point(0, 0)
        Me.txtNotas.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNotas.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNotas.Multiline = True
        Me.txtNotas.Name = "txtNotas"
        Me.txtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtNotas.Size = New System.Drawing.Size(702, 156)
        Me.txtNotas.TabIndex = 46
        Me.txtNotas.WordWrap = False
        '
        'txtFechaAplicado
        '
        Me.txtFechaAplicado.AutoLock = False
        Me.txtFechaAplicado.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtFechaAplicado.Location = New System.Drawing.Point(447, 90)
        Me.txtFechaAplicado.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFechaAplicado.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFechaAplicado.Name = "txtFechaAplicado"
        Me.txtFechaAplicado.ReadOnly = True
        Me.txtFechaAplicado.Size = New System.Drawing.Size(161, 20)
        Me.txtFechaAplicado.TabIndex = 12
        '
        'CiLabel6
        '
        Me.CiLabel6.AutoSize = True
        Me.CiLabel6.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel6.Location = New System.Drawing.Point(349, 94)
        Me.CiLabel6.Name = "CiLabel6"
        Me.CiLabel6.Size = New System.Drawing.Size(92, 13)
        Me.CiLabel6.TabIndex = 11
        Me.CiLabel6.Text = "Fecha Aplicación:"
        '
        'txtTotalFlete
        '
        Me.txtTotalFlete.Digits = True
        Me.txtTotalFlete.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtTotalFlete.Format = "C"
        Me.txtTotalFlete.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTotalFlete.Location = New System.Drawing.Point(447, 12)
        Me.txtTotalFlete.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotalFlete.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotalFlete.Name = "txtTotalFlete"
        Me.txtTotalFlete.Size = New System.Drawing.Size(110, 20)
        Me.txtTotalFlete.TabIndex = 6
        Me.txtTotalFlete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalCosto
        '
        Me.txtTotalCosto.AutoLock = False
        Me.txtTotalCosto.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTotalCosto.Location = New System.Drawing.Point(447, 64)
        Me.txtTotalCosto.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotalCosto.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotalCosto.Name = "txtTotalCosto"
        Me.txtTotalCosto.ReadOnly = True
        Me.txtTotalCosto.Size = New System.Drawing.Size(110, 20)
        Me.txtTotalCosto.TabIndex = 10
        Me.txtTotalCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalCant
        '
        Me.txtTotalCant.AutoLock = False
        Me.txtTotalCant.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTotalCant.Location = New System.Drawing.Point(447, 38)
        Me.txtTotalCant.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotalCant.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotalCant.Name = "txtTotalCant"
        Me.txtTotalCant.ReadOnly = True
        Me.txtTotalCant.Size = New System.Drawing.Size(110, 20)
        Me.txtTotalCant.TabIndex = 8
        Me.txtTotalCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboAlmacen
        '
        Me.cboAlmacen.BackColor = System.Drawing.SystemColors.Window
        Me.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacen.FormattingEnabled = True
        Me.cboAlmacen.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboAlmacen.ItemsTable = Nothing
        Me.cboAlmacen.Location = New System.Drawing.Point(83, 112)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.RequiredField = True
        Me.cboAlmacen.Size = New System.Drawing.Size(258, 21)
        Me.cboAlmacen.TabIndex = 4
        Me.cboAlmacen.UIName = "Almacén"
        '
        'cboConcepto
        '
        Me.cboConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConcepto.FormattingEnabled = True
        Me.cboConcepto.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboConcepto.ItemsTable = Nothing
        Me.cboConcepto.Location = New System.Drawing.Point(83, 85)
        Me.cboConcepto.Name = "cboConcepto"
        Me.cboConcepto.RequiredField = True
        Me.cboConcepto.Size = New System.Drawing.Size(258, 21)
        Me.cboConcepto.TabIndex = 2
        Me.cboConcepto.UIName = "Concepto"
        '
        'imlMovimiento
        '
        Me.imlMovimiento.ImageStream = CType(resources.GetObject("imlMovimiento.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlMovimiento.TransparentColor = System.Drawing.Color.Transparent
        Me.imlMovimiento.Images.SetKeyName(0, "Movimiento")
        Me.imlMovimiento.Images.SetKeyName(1, "Notas")
        '
        'cboUnidades
        '
        Me.cboUnidades.AllowColMove = True
        Me.cboUnidades.AllowColSelect = True
        Me.cboUnidades.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboUnidades.AlternatingRows = True
        Me.cboUnidades.CaptionStyle = Style1
        Me.cboUnidades.ColumnCaptionHeight = 17
        Me.cboUnidades.ColumnFooterHeight = 17
        Me.cboUnidades.DataSource = Me.bsUnidades
        Me.cboUnidades.DisplayMember = "IdUnidadMedida"
        Me.cboUnidades.EvenRowStyle = Style2
        Me.cboUnidades.ExtendRightColumn = True
        Me.cboUnidades.FetchRowStyles = False
        Me.cboUnidades.FooterStyle = Style3
        Me.cboUnidades.HeadingStyle = Style4
        Me.cboUnidades.HighLightRowStyle = Style5
        Me.cboUnidades.Images.Add(CType(resources.GetObject("cboUnidades.Images"), System.Drawing.Image))
        Me.cboUnidades.Location = New System.Drawing.Point(376, 316)
        Me.cboUnidades.Name = "cboUnidades"
        Me.cboUnidades.OddRowStyle = Style6
        Me.cboUnidades.RecordSelectorStyle = Style7
        Me.cboUnidades.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboUnidades.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboUnidades.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboUnidades.ScrollTips = False
        Me.cboUnidades.Size = New System.Drawing.Size(264, 162)
        Me.cboUnidades.Style = Style8
        Me.cboUnidades.TabIndex = 44
        Me.cboUnidades.TabStop = False
        Me.cboUnidades.Text = "C1TrueDBDropdown1"
        Me.cboUnidades.ValueMember = "IdUnidadMedida"
        Me.cboUnidades.Visible = False
        Me.cboUnidades.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.cboUnidades.PropBag = resources.GetString("cboUnidades.PropBag")
        '
        'grdPartidas
        '
        Me.grdPartidas.AllowAddNew = True
        Me.grdPartidas.AllowDelete = True
        Me.grdPartidas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPartidas.DataSource = Me.bsDetalle
        Me.grdPartidas.Images.Add(CType(resources.GetObject("grdPartidas.Images"), System.Drawing.Image))
        Me.grdPartidas.Images.Add(CType(resources.GetObject("grdPartidas.Images1"), System.Drawing.Image))
        Me.grdPartidas.Location = New System.Drawing.Point(12, 294)
        Me.grdPartidas.Name = "grdPartidas"
        Me.grdPartidas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdPartidas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdPartidas.PreviewInfo.ZoomFactor = 75.0R
        Me.grdPartidas.PrintInfo.PageSettings = CType(resources.GetObject("grdPartidas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdPartidas.Size = New System.Drawing.Size(703, 180)
        Me.grdPartidas.TabIndex = 43
        Me.grdPartidas.Text = "AzTrueDBGrid1"
        Me.grdPartidas.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdPartidas.PropBag = resources.GetString("grdPartidas.PropBag")
        '
        'tabMovimiento
        '
        Me.tabMovimiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMovimiento.Controls.Add(Me.pagMovimiento)
        Me.tabMovimiento.Controls.Add(Me.pagNotas)
        Me.tabMovimiento.ImageList = Me.imlMovimiento
        Me.tabMovimiento.Location = New System.Drawing.Point(12, 90)
        Me.tabMovimiento.Name = "tabMovimiento"
        Me.tabMovimiento.SelectedIndex = 1
        Me.tabMovimiento.SelectedTabBold = True
        Me.tabMovimiento.Size = New System.Drawing.Size(704, 198)
        Me.tabMovimiento.TabIndex = 45
        Me.tabMovimiento.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabMovimiento.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabMovimiento.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagMovimiento
        '
        Me.pagMovimiento.Controls.Add(Me.txtOrdenTrabajo)
        Me.pagMovimiento.Controls.Add(Me.CiLabel7)
        Me.pagMovimiento.Controls.Add(Me.txtFechaAplicado)
        Me.pagMovimiento.Controls.Add(Me.grpTipo)
        Me.pagMovimiento.Controls.Add(Me.CiLabel6)
        Me.pagMovimiento.Controls.Add(Me.cboConcepto)
        Me.pagMovimiento.Controls.Add(Me.txtTotalFlete)
        Me.pagMovimiento.Controls.Add(Me.cboAlmacen)
        Me.pagMovimiento.Controls.Add(Me.txtTotalCosto)
        Me.pagMovimiento.Controls.Add(Me.CiLabel3)
        Me.pagMovimiento.Controls.Add(Me.txtTotalCant)
        Me.pagMovimiento.Controls.Add(Me.CiLabel2)
        Me.pagMovimiento.Controls.Add(Me.CiLabel4)
        Me.pagMovimiento.Controls.Add(Me.CiLabel5)
        Me.pagMovimiento.Controls.Add(Me.CiLabel1)
        Me.pagMovimiento.ImageIndex = 0
        Me.pagMovimiento.Location = New System.Drawing.Point(1, 41)
        Me.pagMovimiento.Name = "pagMovimiento"
        Me.pagMovimiento.Size = New System.Drawing.Size(702, 156)
        Me.pagMovimiento.TabIndex = 0
        Me.pagMovimiento.Text = "Movimiento"
        '
        'txtOrdenTrabajo
        '
        Me.txtOrdenTrabajo.Location = New System.Drawing.Point(448, 115)
        Me.txtOrdenTrabajo.Name = "txtOrdenTrabajo"
        Me.txtOrdenTrabajo.Size = New System.Drawing.Size(160, 20)
        Me.txtOrdenTrabajo.TabIndex = 14
        '
        'CiLabel7
        '
        Me.CiLabel7.AutoSize = True
        Me.CiLabel7.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel7.Location = New System.Drawing.Point(347, 118)
        Me.CiLabel7.Name = "CiLabel7"
        Me.CiLabel7.Size = New System.Drawing.Size(62, 13)
        Me.CiLabel7.TabIndex = 13
        Me.CiLabel7.Text = "Referencia:"
        '
        'pagNotas
        '
        Me.pagNotas.Controls.Add(Me.txtNotas)
        Me.pagNotas.ImageIndex = 1
        Me.pagNotas.Location = New System.Drawing.Point(1, 41)
        Me.pagNotas.Name = "pagNotas"
        Me.pagNotas.Size = New System.Drawing.Size(702, 156)
        Me.pagNotas.TabIndex = 1
        Me.pagNotas.Text = "Notas"
        '
        'MovimientosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 502)
        Me.Controls.Add(Me.tabMovimiento)
        Me.Controls.Add(Me.cboUnidades)
        Me.Controls.Add(Me.grdPartidas)
        Me.Name = "MovimientosForm"
        Me.Text = "MovimientosForm"
        Me.Controls.SetChildIndex(Me.grdPartidas, 0)
        Me.Controls.SetChildIndex(Me.cboUnidades, 0)
        Me.Controls.SetChildIndex(Me.tabMovimiento, 0)
        Me.grpTipo.ResumeLayout(False)
        Me.grpTipo.PerformLayout()
        CType(Me.bsDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdPartidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabMovimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMovimiento.ResumeLayout(False)
        Me.pagMovimiento.ResumeLayout(False)
        Me.pagMovimiento.PerformLayout()
        Me.pagNotas.ResumeLayout(False)
        Me.pagNotas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New MovimientoFacade
        SetDocumentType("Entrada")
        LicenseModule = Kernel.Licensing.LicenseModule.Inventory
    End Sub
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboConcepto As Azteca.Windows.Inventario.ConceptosComboBox
    Friend WithEvents cboAlmacen As Azteca.Windows.Inventario.AlmacenesComboBox
    Friend WithEvents grpTipo As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents rdbSalida As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents rdbEntrada As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel5 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNotas As Azteca.Windows.Controls.CITextBox
    Friend WithEvents bsDetalle As System.Windows.Forms.BindingSource
    Friend WithEvents imlMovimiento As System.Windows.Forms.ImageList
    Friend WithEvents txtTotalFlete As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtTotalCosto As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtTotalCant As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtFechaAplicado As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel6 As Azteca.Windows.Controls.CILabel
    Friend WithEvents grdPartidas As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents cboUnidades As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents bsUnidades As System.Windows.Forms.BindingSource
    Friend WithEvents tabMovimiento As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagMovimiento As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagNotas As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents CiLabel7 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtOrdenTrabajo As System.Windows.Forms.TextBox
End Class
