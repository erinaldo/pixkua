<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GeneradorPagosForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GeneradorPagosForm))
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
        Me.grdCheques = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsPendientes = New System.Windows.Forms.BindingSource(Me.components)
        Me.dropChequera = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.bsChequeras = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbxCheques = New Azteca.Windows.Controls.CIGroupBox()
        Me.dropPagoTipo = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.bsPagosTipo = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbxFiltros = New Azteca.Windows.Controls.CIGroupBox()
        Me.opEmitidos = New Azteca.Windows.Controls.CIRadioButton()
        Me.optVencidos = New Azteca.Windows.Controls.CIRadioButton()
        Me.dtpFechaIni = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.dtpFechaFin = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.lblFechaIni = New Azteca.Windows.Controls.CILabel()
        Me.tbBancos = New Azteca.Windows.Controls.CIToolBar()
        Me.btnGenerar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnConsultar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        CType(Me.grdCheques, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dropChequera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsChequeras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxCheques.SuspendLayout()
        CType(Me.dropPagoTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPagosTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxFiltros.SuspendLayout()
        Me.tbBancos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdCheques
        '
        Me.grdCheques.DataSource = Me.bsPendientes
        Me.grdCheques.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdCheques.FilterBar = True
        Me.grdCheques.Images.Add(CType(resources.GetObject("grdCheques.Images"), System.Drawing.Image))
        Me.grdCheques.Images.Add(CType(resources.GetObject("grdCheques.Images1"), System.Drawing.Image))
        Me.grdCheques.Location = New System.Drawing.Point(3, 116)
        Me.grdCheques.Name = "grdCheques"
        Me.grdCheques.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdCheques.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdCheques.PreviewInfo.ZoomFactor = 75.0R
        Me.grdCheques.PrintInfo.PageSettings = CType(resources.GetObject("grdCheques.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdCheques.RowHeight = 17
        Me.grdCheques.Size = New System.Drawing.Size(995, 409)
        Me.grdCheques.TabIndex = 42
        Me.grdCheques.Text = "AzTrueDBGrid1"
        Me.grdCheques.PropBag = resources.GetString("grdCheques.PropBag")
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
        Me.dropChequera.DataSource = Me.bsChequeras
        Me.dropChequera.DisplayMember = "Nombre"
        Me.dropChequera.EvenRowStyle = Style2
        Me.dropChequera.FetchRowStyles = False
        Me.dropChequera.FooterStyle = Style3
        Me.dropChequera.HeadingStyle = Style4
        Me.dropChequera.HighLightRowStyle = Style5
        Me.dropChequera.Images.Add(CType(resources.GetObject("dropChequera.Images"), System.Drawing.Image))
        Me.dropChequera.Location = New System.Drawing.Point(42, 174)
        Me.dropChequera.Name = "dropChequera"
        Me.dropChequera.OddRowStyle = Style6
        Me.dropChequera.RecordSelectorStyle = Style7
        Me.dropChequera.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.dropChequera.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.dropChequera.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.dropChequera.ScrollTips = False
        Me.dropChequera.Size = New System.Drawing.Size(439, 78)
        Me.dropChequera.Style = Style8
        Me.dropChequera.TabIndex = 51
        Me.dropChequera.TabStop = False
        Me.dropChequera.Text = "C1TrueDBDropdown1"
        Me.dropChequera.ValueMember = "IdChequera"
        Me.dropChequera.ValueTranslate = True
        Me.dropChequera.Visible = False
        Me.dropChequera.PropBag = resources.GetString("dropChequera.PropBag")
        '
        'gbxCheques
        '
        Me.gbxCheques.Controls.Add(Me.dropPagoTipo)
        Me.gbxCheques.Controls.Add(Me.dropChequera)
        Me.gbxCheques.Controls.Add(Me.grdCheques)
        Me.gbxCheques.Controls.Add(Me.gbxFiltros)
        Me.gbxCheques.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxCheques.Location = New System.Drawing.Point(0, 39)
        Me.gbxCheques.Name = "gbxCheques"
        Me.gbxCheques.Size = New System.Drawing.Size(1001, 528)
        Me.gbxCheques.TabIndex = 52
        Me.gbxCheques.TabStop = False
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
        Me.dropPagoTipo.DataSource = Me.bsPagosTipo
        Me.dropPagoTipo.DisplayMember = "Nombre"
        Me.dropPagoTipo.EvenRowStyle = Style10
        Me.dropPagoTipo.FetchRowStyles = False
        Me.dropPagoTipo.FooterStyle = Style11
        Me.dropPagoTipo.HeadingStyle = Style12
        Me.dropPagoTipo.HighLightRowStyle = Style13
        Me.dropPagoTipo.Images.Add(CType(resources.GetObject("dropPagoTipo.Images"), System.Drawing.Image))
        Me.dropPagoTipo.Location = New System.Drawing.Point(506, 174)
        Me.dropPagoTipo.Name = "dropPagoTipo"
        Me.dropPagoTipo.OddRowStyle = Style14
        Me.dropPagoTipo.RecordSelectorStyle = Style15
        Me.dropPagoTipo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.dropPagoTipo.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.dropPagoTipo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.dropPagoTipo.ScrollTips = False
        Me.dropPagoTipo.Size = New System.Drawing.Size(305, 78)
        Me.dropPagoTipo.Style = Style16
        Me.dropPagoTipo.TabIndex = 53
        Me.dropPagoTipo.TabStop = False
        Me.dropPagoTipo.Text = "dropPagoTipo"
        Me.dropPagoTipo.ValueMember = "IdPagoTipo"
        Me.dropPagoTipo.ValueTranslate = True
        Me.dropPagoTipo.Visible = False
        Me.dropPagoTipo.PropBag = resources.GetString("dropPagoTipo.PropBag")
        '
        'gbxFiltros
        '
        Me.gbxFiltros.Controls.Add(Me.opEmitidos)
        Me.gbxFiltros.Controls.Add(Me.optVencidos)
        Me.gbxFiltros.Controls.Add(Me.dtpFechaIni)
        Me.gbxFiltros.Controls.Add(Me.CiLabel2)
        Me.gbxFiltros.Controls.Add(Me.dtpFechaFin)
        Me.gbxFiltros.Controls.Add(Me.lblFechaIni)
        Me.gbxFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbxFiltros.Location = New System.Drawing.Point(3, 16)
        Me.gbxFiltros.Name = "gbxFiltros"
        Me.gbxFiltros.Size = New System.Drawing.Size(995, 100)
        Me.gbxFiltros.TabIndex = 52
        Me.gbxFiltros.TabStop = False
        Me.gbxFiltros.Text = "Filtros"
        '
        'opEmitidos
        '
        Me.opEmitidos.AutoSize = True
        Me.opEmitidos.Location = New System.Drawing.Point(152, 42)
        Me.opEmitidos.Name = "opEmitidos"
        Me.opEmitidos.Size = New System.Drawing.Size(254, 17)
        Me.opEmitidos.TabIndex = 22
        Me.opEmitidos.Text = "Contra-Recibos Emitidos en el Rango de Fechas"
        Me.opEmitidos.UseVisualStyleBackColor = True
        '
        'optVencidos
        '
        Me.optVencidos.AutoSize = True
        Me.optVencidos.Checked = True
        Me.optVencidos.Location = New System.Drawing.Point(152, 18)
        Me.optVencidos.Name = "optVencidos"
        Me.optVencidos.Size = New System.Drawing.Size(259, 17)
        Me.optVencidos.TabIndex = 21
        Me.optVencidos.TabStop = True
        Me.optVencidos.Text = "Contra-Recibos Vencidos en el Rango de Fechas"
        Me.optVencidos.UseVisualStyleBackColor = True
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaIni.Location = New System.Drawing.Point(152, 66)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(211, 20)
        Me.dtpFechaIni.TabIndex = 17
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(399, 69)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(65, 13)
        Me.CiLabel2.TabIndex = 20
        Me.CiLabel2.Text = "Fecha Final:"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaFin.Location = New System.Drawing.Point(470, 65)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(210, 20)
        Me.dtpFechaFin.TabIndex = 19
        '
        'lblFechaIni
        '
        Me.lblFechaIni.AutoSize = True
        Me.lblFechaIni.Location = New System.Drawing.Point(83, 69)
        Me.lblFechaIni.Name = "lblFechaIni"
        Me.lblFechaIni.Size = New System.Drawing.Size(70, 13)
        Me.lblFechaIni.TabIndex = 18
        Me.lblFechaIni.Text = "Fecha Inicial:"
        '
        'tbBancos
        '
        Me.tbBancos.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbBancos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGenerar, Me.ToolStripSeparator1, Me.btnConsultar, Me.ToolStripSeparator2, Me.btnCancelar})
        Me.tbBancos.Location = New System.Drawing.Point(0, 0)
        Me.tbBancos.Name = "tbBancos"
        Me.tbBancos.Size = New System.Drawing.Size(1001, 39)
        Me.tbBancos.TabIndex = 53
        Me.tbBancos.Text = "CiToolBar4"
        '
        'btnGenerar
        '
        Me.btnGenerar.Image = CType(resources.GetObject("btnGenerar.Image"), System.Drawing.Image)
        Me.btnGenerar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(119, 36)
        Me.btnGenerar.Text = "Generar Pagos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'btnConsultar
        '
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(94, 36)
        Me.btnConsultar.Text = "Consultar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(89, 36)
        Me.btnCancelar.Text = "Cancelar"
        '
        'GeneradorPagosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 567)
        Me.Controls.Add(Me.gbxCheques)
        Me.Controls.Add(Me.tbBancos)
        Me.Name = "GeneradorPagosForm"
        Me.Text = "Generador de pagos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdCheques, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dropChequera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsChequeras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxCheques.ResumeLayout(False)
        CType(Me.dropPagoTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPagosTipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxFiltros.ResumeLayout(False)
        Me.gbxFiltros.PerformLayout()
        Me.tbBancos.ResumeLayout(False)
        Me.tbBancos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdCheques As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents dropChequera As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents gbxCheques As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents tbBancos As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents gbxFiltros As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents btnConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGenerar As System.Windows.Forms.ToolStripButton
    Friend WithEvents bsChequeras As System.Windows.Forms.BindingSource
    Friend WithEvents bsPendientes As System.Windows.Forms.BindingSource
    Friend WithEvents dropPagoTipo As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents opEmitidos As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents optVencidos As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents dtpFechaIni As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents dtpFechaFin As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents lblFechaIni As Azteca.Windows.Controls.CILabel
    Friend WithEvents bsPagosTipo As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
End Class
