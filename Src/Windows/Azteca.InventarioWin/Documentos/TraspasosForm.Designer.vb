<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TraspasosForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TraspasosForm))
        Dim Style1 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style2 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style3 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style4 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style5 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style6 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style7 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style8 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Me.imlMovimiento = New System.Windows.Forms.ImageList(Me.components)
        Me.cboAlmacenDest = New Azteca.Windows.Inventario.AlmacenesComboBox()
        Me.CiLabel7 = New Azteca.Windows.Controls.CILabel()
        Me.txtFechaAplicado = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel6 = New Azteca.Windows.Controls.CILabel()
        Me.txtFlete = New Azteca.Windows.Controls.CITextBox()
        Me.txtTotalCosto = New Azteca.Windows.Controls.CITextBox()
        Me.txtTotalCant = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel5 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.cboAlmacenOrig = New Azteca.Windows.Inventario.AlmacenesComboBox()
        Me.cboConcepto = New Azteca.Windows.Inventario.ConceptosComboBox()
        Me.txtNotas = New Azteca.Windows.Controls.CITextBox()
        Me.bsDetalle = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsUnidades = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboUnidades = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.grdPartidas = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.tabTraspaso = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagTraspaso = New C1.Win.C1Command.C1DockingTabPage()
        Me.txtOrdenTrabajo = New System.Windows.Forms.TextBox()
        Me.CiLabel8 = New Azteca.Windows.Controls.CILabel()
        Me.pagNotas = New C1.Win.C1Command.C1DockingTabPage()
        CType(Me.bsDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdPartidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabTraspaso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTraspaso.SuspendLayout()
        Me.pagTraspaso.SuspendLayout()
        Me.pagNotas.SuspendLayout()
        Me.SuspendLayout()
        '
        'imlMovimiento
        '
        Me.imlMovimiento.ImageStream = CType(resources.GetObject("imlMovimiento.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlMovimiento.TransparentColor = System.Drawing.Color.Transparent
        Me.imlMovimiento.Images.SetKeyName(0, "Movimiento")
        Me.imlMovimiento.Images.SetKeyName(1, "Notas")
        '
        'cboAlmacenDest
        '
        Me.cboAlmacenDest.BackColor = System.Drawing.SystemColors.Window
        Me.cboAlmacenDest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacenDest.FormattingEnabled = True
        Me.cboAlmacenDest.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboAlmacenDest.ItemsTable = Nothing
        Me.cboAlmacenDest.Location = New System.Drawing.Point(129, 63)
        Me.cboAlmacenDest.Name = "cboAlmacenDest"
        Me.cboAlmacenDest.RequiredField = True
        Me.cboAlmacenDest.Size = New System.Drawing.Size(258, 21)
        Me.cboAlmacenDest.TabIndex = 5
        Me.cboAlmacenDest.UIName = "Almacén Destino"
        '
        'CiLabel7
        '
        Me.CiLabel7.AutoSize = True
        Me.CiLabel7.Location = New System.Drawing.Point(14, 66)
        Me.CiLabel7.Name = "CiLabel7"
        Me.CiLabel7.Size = New System.Drawing.Size(90, 13)
        Me.CiLabel7.TabIndex = 4
        Me.CiLabel7.Text = "Almacén Destino:"
        '
        'txtFechaAplicado
        '
        Me.txtFechaAplicado.AutoLock = False
        Me.txtFechaAplicado.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtFechaAplicado.Location = New System.Drawing.Point(500, 87)
        Me.txtFechaAplicado.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFechaAplicado.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFechaAplicado.Name = "txtFechaAplicado"
        Me.txtFechaAplicado.ReadOnly = True
        Me.txtFechaAplicado.Size = New System.Drawing.Size(161, 20)
        Me.txtFechaAplicado.TabIndex = 13
        '
        'CiLabel6
        '
        Me.CiLabel6.AutoSize = True
        Me.CiLabel6.Location = New System.Drawing.Point(402, 91)
        Me.CiLabel6.Name = "CiLabel6"
        Me.CiLabel6.Size = New System.Drawing.Size(92, 13)
        Me.CiLabel6.TabIndex = 12
        Me.CiLabel6.Text = "Fecha Aplicación:"
        '
        'txtFlete
        '
        Me.txtFlete.Digits = True
        Me.txtFlete.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtFlete.Format = "C"
        Me.txtFlete.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtFlete.Location = New System.Drawing.Point(500, 61)
        Me.txtFlete.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFlete.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFlete.Name = "txtFlete"
        Me.txtFlete.Size = New System.Drawing.Size(110, 20)
        Me.txtFlete.TabIndex = 11
        Me.txtFlete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalCosto
        '
        Me.txtTotalCosto.AutoLock = False
        Me.txtTotalCosto.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTotalCosto.Location = New System.Drawing.Point(500, 35)
        Me.txtTotalCosto.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotalCosto.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotalCosto.Name = "txtTotalCosto"
        Me.txtTotalCosto.ReadOnly = True
        Me.txtTotalCosto.Size = New System.Drawing.Size(110, 20)
        Me.txtTotalCosto.TabIndex = 9
        Me.txtTotalCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalCant
        '
        Me.txtTotalCant.AutoLock = False
        Me.txtTotalCant.BackColor = System.Drawing.SystemColors.Control
        Me.txtTotalCant.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTotalCant.Location = New System.Drawing.Point(500, 9)
        Me.txtTotalCant.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotalCant.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotalCant.Name = "txtTotalCant"
        Me.txtTotalCant.ReadOnly = True
        Me.txtTotalCant.Size = New System.Drawing.Size(110, 20)
        Me.txtTotalCant.TabIndex = 7
        Me.txtTotalCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CiLabel5
        '
        Me.CiLabel5.AutoSize = True
        Me.CiLabel5.Location = New System.Drawing.Point(402, 66)
        Me.CiLabel5.Name = "CiLabel5"
        Me.CiLabel5.Size = New System.Drawing.Size(33, 13)
        Me.CiLabel5.TabIndex = 10
        Me.CiLabel5.Text = "Flete:"
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(14, 39)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(85, 13)
        Me.CiLabel1.TabIndex = 2
        Me.CiLabel1.Text = "Almacén Origen:"
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.Location = New System.Drawing.Point(402, 40)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(64, 13)
        Me.CiLabel4.TabIndex = 8
        Me.CiLabel4.Text = "Total Costo:"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(14, 12)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(56, 13)
        Me.CiLabel2.TabIndex = 0
        Me.CiLabel2.Text = "Concepto:"
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(402, 14)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(79, 13)
        Me.CiLabel3.TabIndex = 6
        Me.CiLabel3.Text = "Total Cantidad:"
        '
        'cboAlmacenOrig
        '
        Me.cboAlmacenOrig.BackColor = System.Drawing.SystemColors.Window
        Me.cboAlmacenOrig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacenOrig.FormattingEnabled = True
        Me.cboAlmacenOrig.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboAlmacenOrig.ItemsTable = Nothing
        Me.cboAlmacenOrig.Location = New System.Drawing.Point(129, 36)
        Me.cboAlmacenOrig.Name = "cboAlmacenOrig"
        Me.cboAlmacenOrig.RequiredField = True
        Me.cboAlmacenOrig.Size = New System.Drawing.Size(258, 21)
        Me.cboAlmacenOrig.TabIndex = 3
        Me.cboAlmacenOrig.UIName = "Almacén Origen"
        '
        'cboConcepto
        '
        Me.cboConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConcepto.FormattingEnabled = True
        Me.cboConcepto.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboConcepto.ItemsTable = Nothing
        Me.cboConcepto.Location = New System.Drawing.Point(129, 9)
        Me.cboConcepto.Name = "cboConcepto"
        Me.cboConcepto.RequiredField = True
        Me.cboConcepto.Size = New System.Drawing.Size(258, 21)
        Me.cboConcepto.TabIndex = 1
        Me.cboConcepto.UIName = "Concepto"
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
        Me.txtNotas.Size = New System.Drawing.Size(692, 131)
        Me.txtNotas.TabIndex = 46
        Me.txtNotas.WordWrap = False
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
        Me.cboUnidades.Location = New System.Drawing.Point(441, 301)
        Me.cboUnidades.Name = "cboUnidades"
        Me.cboUnidades.OddRowStyle = Style6
        Me.cboUnidades.RecordSelectorStyle = Style7
        Me.cboUnidades.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboUnidades.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboUnidades.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboUnidades.ScrollTips = False
        Me.cboUnidades.Size = New System.Drawing.Size(264, 162)
        Me.cboUnidades.Style = Style8
        Me.cboUnidades.TabIndex = 45
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
        Me.grdPartidas.Location = New System.Drawing.Point(12, 267)
        Me.grdPartidas.Name = "grdPartidas"
        Me.grdPartidas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdPartidas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdPartidas.PreviewInfo.ZoomFactor = 75.0R
        Me.grdPartidas.PrintInfo.PageSettings = CType(resources.GetObject("grdPartidas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdPartidas.Size = New System.Drawing.Size(694, 175)
        Me.grdPartidas.TabIndex = 1
        Me.grdPartidas.Text = "AzTrueDBGrid1"
        Me.grdPartidas.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdPartidas.PropBag = resources.GetString("grdPartidas.PropBag")
        '
        'tabTraspaso
        '
        Me.tabTraspaso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabTraspaso.Controls.Add(Me.pagTraspaso)
        Me.tabTraspaso.Controls.Add(Me.pagNotas)
        Me.tabTraspaso.ImageList = Me.imlMovimiento
        Me.tabTraspaso.Location = New System.Drawing.Point(12, 88)
        Me.tabTraspaso.Name = "tabTraspaso"
        Me.tabTraspaso.SelectedIndex = 1
        Me.tabTraspaso.Size = New System.Drawing.Size(694, 173)
        Me.tabTraspaso.TabIndex = 46
        Me.tabTraspaso.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabTraspaso.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabTraspaso.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagTraspaso
        '
        Me.pagTraspaso.Controls.Add(Me.txtOrdenTrabajo)
        Me.pagTraspaso.Controls.Add(Me.CiLabel8)
        Me.pagTraspaso.Controls.Add(Me.cboAlmacenDest)
        Me.pagTraspaso.Controls.Add(Me.CiLabel2)
        Me.pagTraspaso.Controls.Add(Me.CiLabel7)
        Me.pagTraspaso.Controls.Add(Me.cboConcepto)
        Me.pagTraspaso.Controls.Add(Me.txtFechaAplicado)
        Me.pagTraspaso.Controls.Add(Me.cboAlmacenOrig)
        Me.pagTraspaso.Controls.Add(Me.CiLabel6)
        Me.pagTraspaso.Controls.Add(Me.CiLabel3)
        Me.pagTraspaso.Controls.Add(Me.txtFlete)
        Me.pagTraspaso.Controls.Add(Me.CiLabel4)
        Me.pagTraspaso.Controls.Add(Me.txtTotalCosto)
        Me.pagTraspaso.Controls.Add(Me.CiLabel1)
        Me.pagTraspaso.Controls.Add(Me.txtTotalCant)
        Me.pagTraspaso.Controls.Add(Me.CiLabel5)
        Me.pagTraspaso.ImageIndex = 0
        Me.pagTraspaso.Location = New System.Drawing.Point(1, 41)
        Me.pagTraspaso.Name = "pagTraspaso"
        Me.pagTraspaso.Size = New System.Drawing.Size(692, 131)
        Me.pagTraspaso.TabIndex = 0
        Me.pagTraspaso.Text = "Traspaso"
        '
        'txtOrdenTrabajo
        '
        Me.txtOrdenTrabajo.Location = New System.Drawing.Point(129, 88)
        Me.txtOrdenTrabajo.Name = "txtOrdenTrabajo"
        Me.txtOrdenTrabajo.Size = New System.Drawing.Size(139, 20)
        Me.txtOrdenTrabajo.TabIndex = 15
        '
        'CiLabel8
        '
        Me.CiLabel8.AutoSize = True
        Me.CiLabel8.Location = New System.Drawing.Point(14, 91)
        Me.CiLabel8.Name = "CiLabel8"
        Me.CiLabel8.Size = New System.Drawing.Size(62, 13)
        Me.CiLabel8.TabIndex = 14
        Me.CiLabel8.Text = "Referencia:"
        '
        'pagNotas
        '
        Me.pagNotas.Controls.Add(Me.txtNotas)
        Me.pagNotas.ImageIndex = 1
        Me.pagNotas.Location = New System.Drawing.Point(1, 41)
        Me.pagNotas.Name = "pagNotas"
        Me.pagNotas.Size = New System.Drawing.Size(692, 131)
        Me.pagNotas.TabIndex = 1
        Me.pagNotas.Text = "Notas"
        '
        'TraspasosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 467)
        Me.Controls.Add(Me.tabTraspaso)
        Me.Controls.Add(Me.cboUnidades)
        Me.Controls.Add(Me.grdPartidas)
        Me.Name = "TraspasosForm"
        Me.Text = "TraspasosForm"
        Me.Controls.SetChildIndex(Me.grdPartidas, 0)
        Me.Controls.SetChildIndex(Me.cboUnidades, 0)
        Me.Controls.SetChildIndex(Me.tabTraspaso, 0)
        CType(Me.bsDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdPartidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabTraspaso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTraspaso.ResumeLayout(False)
        Me.pagTraspaso.ResumeLayout(False)
        Me.pagTraspaso.PerformLayout()
        Me.pagNotas.ResumeLayout(False)
        Me.pagNotas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New TraspasoFacade
        SetDocumentType("Traspaso")
        LicenseModule = Kernel.Licensing.LicenseModule.Inventory
    End Sub
    Friend WithEvents imlMovimiento As System.Windows.Forms.ImageList
    Friend WithEvents cboAlmacenDest As Azteca.Windows.Inventario.AlmacenesComboBox
    Friend WithEvents CiLabel7 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtFechaAplicado As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel6 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtFlete As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtTotalCosto As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtTotalCant As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel5 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboAlmacenOrig As Azteca.Windows.Inventario.AlmacenesComboBox
    Friend WithEvents cboConcepto As Azteca.Windows.Inventario.ConceptosComboBox
    Friend WithEvents txtNotas As Azteca.Windows.Controls.CITextBox
    Friend WithEvents bsDetalle As System.Windows.Forms.BindingSource
    Friend WithEvents bsUnidades As System.Windows.Forms.BindingSource
    Friend WithEvents cboUnidades As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents grdPartidas As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents tabTraspaso As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagTraspaso As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagNotas As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents txtOrdenTrabajo As System.Windows.Forms.TextBox
    Friend WithEvents CiLabel8 As Azteca.Windows.Controls.CILabel
End Class
