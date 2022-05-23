<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PagosConfirmacionForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PagosConfirmacionForm))
        Dim Style1 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style2 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style3 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style4 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style5 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style6 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style7 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style8 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style9 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style10 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style11 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style12 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style13 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style14 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style15 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style16 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Me.tlbMenu = New Azteca.Windows.Controls.CIToolBar()
        Me.btnCerrarCorte = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.bsDetalle = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsTitulo = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlphaGradientPanel1 = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha2 = New Azteca.Windows.ColorWithAlpha()
        Me.lblListado = New Azteca.Windows.Controls.CILabel()
        Me.dropChequera = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.dropPagoTipo = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.grdTitulo = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.grdDetalle = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.tlbMenu.SuspendLayout()
        CType(Me.bsDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AlphaGradientPanel1.SuspendLayout()
        CType(Me.dropChequera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dropPagoTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlbMenu
        '
        Me.tlbMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tlbMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCerrarCorte, Me.btnCancelar, Me.ToolStripSeparator1})
        Me.tlbMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlbMenu.Name = "tlbMenu"
        Me.tlbMenu.Size = New System.Drawing.Size(993, 39)
        Me.tlbMenu.TabIndex = 7
        Me.tlbMenu.Text = "CiToolBar1"
        '
        'btnCerrarCorte
        '
        Me.btnCerrarCorte.Image = CType(resources.GetObject("btnCerrarCorte.Image"), System.Drawing.Image)
        Me.btnCerrarCorte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCerrarCorte.Name = "btnCerrarCorte"
        Me.btnCerrarCorte.Size = New System.Drawing.Size(153, 36)
        Me.btnCerrarCorte.Text = "Confirmar  y Generar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(89, 36)
        Me.btnCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'AlphaGradientPanel1
        '
        Me.AlphaGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.AlphaGradientPanel1.Border = True
        Me.AlphaGradientPanel1.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha1)
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha2)
        Me.AlphaGradientPanel1.ContentPadding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.AlphaGradientPanel1.Controls.Add(Me.lblListado)
        Me.AlphaGradientPanel1.CornerRadius = 10
        Me.AlphaGradientPanel1.Corners = CType((((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight) _
            Or Azteca.Windows.Corner.BottomLeft) _
            Or Azteca.Windows.Corner.BottomRight), Azteca.Windows.Corner)
        Me.AlphaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.AlphaGradientPanel1.Gradient = True
        Me.AlphaGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.AlphaGradientPanel1.GradientOffset = 1.0!
        Me.AlphaGradientPanel1.GradientSize = New System.Drawing.Size(0, 0)
        Me.AlphaGradientPanel1.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.AlphaGradientPanel1.Grayscale = False
        Me.AlphaGradientPanel1.Image = Nothing
        Me.AlphaGradientPanel1.ImageAlpha = 75
        Me.AlphaGradientPanel1.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.AlphaGradientPanel1.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.AlphaGradientPanel1.ImageSize = New System.Drawing.Size(48, 48)
        Me.AlphaGradientPanel1.Location = New System.Drawing.Point(0, 39)
        Me.AlphaGradientPanel1.Name = "AlphaGradientPanel1"
        Me.AlphaGradientPanel1.Rounded = True
        Me.AlphaGradientPanel1.Size = New System.Drawing.Size(993, 38)
        Me.AlphaGradientPanel1.TabIndex = 59
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorWithAlpha1.Parent = Me.AlphaGradientPanel1
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.White
        Me.ColorWithAlpha2.Parent = Me.AlphaGradientPanel1
        '
        'lblListado
        '
        Me.lblListado.AutoClear = True
        Me.lblListado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListado.ForeColor = System.Drawing.Color.Red
        Me.lblListado.Location = New System.Drawing.Point(0, 0)
        Me.lblListado.Name = "lblListado"
        Me.lblListado.Size = New System.Drawing.Size(993, 38)
        Me.lblListado.TabIndex = 0
        Me.lblListado.Text = "Listado de pagos a Generar"
        Me.lblListado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dropChequera
        '
        Me.dropChequera.AllowColMove = True
        Me.dropChequera.AllowColSelect = True
        Me.dropChequera.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.dropChequera.AlternatingRows = True
        Me.dropChequera.CaptionStyle = Style1
        Me.dropChequera.ColumnCaptionHeight = 17
        Me.dropChequera.ColumnFooterHeight = 17
        Me.dropChequera.DisplayMember = "Nombre"
        Me.dropChequera.EvenRowStyle = Style2
        Me.dropChequera.FetchRowStyles = False
        Me.dropChequera.FooterStyle = Style3
        Me.dropChequera.HeadingStyle = Style4
        Me.dropChequera.HighLightRowStyle = Style5
        Me.dropChequera.Images.Add(CType(resources.GetObject("dropChequera.Images"), System.Drawing.Image))
        Me.dropChequera.Location = New System.Drawing.Point(12, 152)
        Me.dropChequera.Name = "dropChequera"
        Me.dropChequera.OddRowStyle = Style6
        Me.dropChequera.RecordSelectorStyle = Style7
        Me.dropChequera.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.dropChequera.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.dropChequera.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.dropChequera.ScrollTips = False
        Me.dropChequera.Size = New System.Drawing.Size(439, 78)
        Me.dropChequera.Style = Style8
        Me.dropChequera.TabIndex = 61
        Me.dropChequera.TabStop = False
        Me.dropChequera.Text = "C1TrueDBDropdown1"
        Me.dropChequera.ValueMember = "IdChequera"
        Me.dropChequera.ValueTranslate = True
        Me.dropChequera.Visible = False
        Me.dropChequera.PropBag = resources.GetString("dropChequera.PropBag")
        '
        'dropPagoTipo
        '
        Me.dropPagoTipo.AllowColMove = True
        Me.dropPagoTipo.AllowColSelect = True
        Me.dropPagoTipo.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.dropPagoTipo.AlternatingRows = True
        Me.dropPagoTipo.CaptionStyle = Style9
        Me.dropPagoTipo.ColumnCaptionHeight = 17
        Me.dropPagoTipo.ColumnFooterHeight = 17
        Me.dropPagoTipo.DisplayMember = "Nombre"
        Me.dropPagoTipo.EvenRowStyle = Style10
        Me.dropPagoTipo.FetchRowStyles = False
        Me.dropPagoTipo.FooterStyle = Style11
        Me.dropPagoTipo.HeadingStyle = Style12
        Me.dropPagoTipo.HighLightRowStyle = Style13
        Me.dropPagoTipo.Images.Add(CType(resources.GetObject("dropPagoTipo.Images"), System.Drawing.Image))
        Me.dropPagoTipo.Location = New System.Drawing.Point(500, 152)
        Me.dropPagoTipo.Name = "dropPagoTipo"
        Me.dropPagoTipo.OddRowStyle = Style14
        Me.dropPagoTipo.RecordSelectorStyle = Style15
        Me.dropPagoTipo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.dropPagoTipo.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.dropPagoTipo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.dropPagoTipo.ScrollTips = False
        Me.dropPagoTipo.Size = New System.Drawing.Size(305, 78)
        Me.dropPagoTipo.Style = Style16
        Me.dropPagoTipo.TabIndex = 62
        Me.dropPagoTipo.TabStop = False
        Me.dropPagoTipo.Text = "dropPagoTipo"
        Me.dropPagoTipo.ValueMember = "IdPagoTipo"
        Me.dropPagoTipo.ValueTranslate = True
        Me.dropPagoTipo.Visible = False
        Me.dropPagoTipo.PropBag = resources.GetString("dropPagoTipo.PropBag")
        '
        'grdTitulo
        '
        Me.grdTitulo.AlternatingRows = True
        Me.grdTitulo.ChildGrid = Me.grdDetalle
        Me.grdTitulo.ColumnFooters = True
        Me.grdTitulo.DataSource = Me.bsTitulo
        Me.grdTitulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdTitulo.FilterBar = True
        Me.grdTitulo.Images.Add(CType(resources.GetObject("grdTitulo.Images"), System.Drawing.Image))
        Me.grdTitulo.Images.Add(CType(resources.GetObject("grdTitulo.Images1"), System.Drawing.Image))
        Me.grdTitulo.Location = New System.Drawing.Point(0, 77)
        Me.grdTitulo.Name = "grdTitulo"
        Me.grdTitulo.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdTitulo.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdTitulo.PreviewInfo.ZoomFactor = 75.0R
        Me.grdTitulo.PrintInfo.PageSettings = CType(resources.GetObject("grdTitulo.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdTitulo.RowHeight = 17
        Me.grdTitulo.Size = New System.Drawing.Size(993, 478)
        Me.grdTitulo.TabIndex = 60
        Me.grdTitulo.Text = "AzTrueDBGrid1"
        Me.grdTitulo.PropBag = resources.GetString("grdTitulo.PropBag")
        '
        'grdDetalle
        '
        Me.grdDetalle.AllowUpdate = False
        Me.grdDetalle.AlternatingRows = True
        Me.grdDetalle.ColumnFooters = True
        Me.grdDetalle.DataSource = Me.bsDetalle
        Me.grdDetalle.FilterBar = True
        Me.grdDetalle.Images.Add(CType(resources.GetObject("grdDetalle.Images"), System.Drawing.Image))
        Me.grdDetalle.Images.Add(CType(resources.GetObject("grdDetalle.Images1"), System.Drawing.Image))
        Me.grdDetalle.Location = New System.Drawing.Point(52, 246)
        Me.grdDetalle.Name = "grdDetalle"
        Me.grdDetalle.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdDetalle.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdDetalle.PreviewInfo.ZoomFactor = 75.0R
        Me.grdDetalle.PrintInfo.PageSettings = CType(resources.GetObject("grdDetalle.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdDetalle.RowHeight = 17
        Me.grdDetalle.Size = New System.Drawing.Size(687, 193)
        Me.grdDetalle.TabIndex = 63
        Me.grdDetalle.TabStop = False
        Me.grdDetalle.Text = "AzTrueDBGrid1"
        Me.grdDetalle.Visible = False
        Me.grdDetalle.PropBag = resources.GetString("grdDetalle.PropBag")
        '
        'PagosConfirmacionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 555)
        Me.ControlBox = False
        Me.Controls.Add(Me.grdDetalle)
        Me.Controls.Add(Me.dropChequera)
        Me.Controls.Add(Me.dropPagoTipo)
        Me.Controls.Add(Me.grdTitulo)
        Me.Controls.Add(Me.AlphaGradientPanel1)
        Me.Controls.Add(Me.tlbMenu)
        Me.Name = "PagosConfirmacionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confirmación de los Pagos a Generar..."
        Me.tlbMenu.ResumeLayout(False)
        Me.tlbMenu.PerformLayout()
        CType(Me.bsDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AlphaGradientPanel1.ResumeLayout(False)
        CType(Me.dropChequera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dropPagoTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tlbMenu As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnCerrarCorte As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents bsTitulo As System.Windows.Forms.BindingSource
    Friend WithEvents bsDetalle As System.Windows.Forms.BindingSource
    Friend WithEvents AlphaGradientPanel1 As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents lblListado As Azteca.Windows.Controls.CILabel
    Friend WithEvents dropChequera As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents dropPagoTipo As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents grdTitulo As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents grdDetalle As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
