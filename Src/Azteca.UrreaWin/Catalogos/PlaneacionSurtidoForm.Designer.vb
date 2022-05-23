Imports Azteca.Business.Urrea

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlaneacionSurtidoForm
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
        Dim Style1 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style2 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style3 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style4 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style5 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlaneacionSurtidoForm))
        Dim Style6 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style7 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style8 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCantSurtidores = New System.Windows.Forms.NumericUpDown()
        Me.txtCantEmpacadores = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpHoraInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpLineasReales = New System.Windows.Forms.DateTimePicker()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.General = New System.Windows.Forms.GroupBox()
        Me.cboVersion = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtReferencia = New Azteca.Windows.Controls.CITextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tabConfiguracion = New Azteca.Windows.Controls.CITab()
        Me.pagCentralCompras = New System.Windows.Forms.TabPage()
        Me.gbxCentrosCompra = New Azteca.Windows.Controls.CIGroupBox()
        Me.cboOperadores = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.bsOperadores = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdCajasCompletas = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.bsCajasCompletas = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbBancos = New Azteca.Windows.Controls.CIToolBar()
        Me.btnGenerarCajasCompletas = New System.Windows.Forms.ToolStripButton()
        Me.iLstTabs = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtCantSurtidores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantEmpacadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.General.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.tabConfiguracion.SuspendLayout()
        Me.pagCentralCompras.SuspendLayout()
        Me.gbxCentrosCompra.SuspendLayout()
        CType(Me.cboOperadores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsOperadores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdCajasCompletas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCajasCompletas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbBancos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.General)
        Me.Panel1.Location = New System.Drawing.Point(4, 138)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1970, 158)
        Me.Panel1.TabIndex = 32
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dtpFechaFinal)
        Me.GroupBox3.Controls.Add(Me.dtpFechaInicial)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(1396, 9)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(366, 152)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rango Fechas Información"
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(170, 86)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(170, 26)
        Me.dtpFechaFinal.TabIndex = 7
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(170, 42)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(170, 26)
        Me.dtpFechaInicial.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fecha Final:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 20)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Fecha Inicial:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCantSurtidores)
        Me.GroupBox2.Controls.Add(Me.txtCantEmpacadores)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(1058, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(314, 151)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Usuarios"
        '
        'txtCantSurtidores
        '
        Me.txtCantSurtidores.Location = New System.Drawing.Point(186, 92)
        Me.txtCantSurtidores.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCantSurtidores.Name = "txtCantSurtidores"
        Me.txtCantSurtidores.Size = New System.Drawing.Size(100, 26)
        Me.txtCantSurtidores.TabIndex = 7
        Me.txtCantSurtidores.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'txtCantEmpacadores
        '
        Me.txtCantEmpacadores.Location = New System.Drawing.Point(186, 32)
        Me.txtCantEmpacadores.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCantEmpacadores.Name = "txtCantEmpacadores"
        Me.txtCantEmpacadores.Size = New System.Drawing.Size(100, 26)
        Me.txtCantEmpacadores.TabIndex = 6
        Me.txtCantEmpacadores.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Surtidores:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Montacargas:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpHoraInicio)
        Me.GroupBox1.Controls.Add(Me.dtpLineasReales)
        Me.GroupBox1.Controls.Add(Me.lblHora)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(554, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(486, 154)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Configuración del Plan"
        '
        'dtpHoraInicio
        '
        Me.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraInicio.Location = New System.Drawing.Point(182, 34)
        Me.dtpHoraInicio.Name = "dtpHoraInicio"
        Me.dtpHoraInicio.ShowUpDown = True
        Me.dtpHoraInicio.Size = New System.Drawing.Size(200, 26)
        Me.dtpHoraInicio.TabIndex = 0
        '
        'dtpLineasReales
        '
        Me.dtpLineasReales.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpLineasReales.Location = New System.Drawing.Point(182, 92)
        Me.dtpLineasReales.Name = "dtpLineasReales"
        Me.dtpLineasReales.Size = New System.Drawing.Size(200, 26)
        Me.dtpLineasReales.TabIndex = 3
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Location = New System.Drawing.Point(44, 35)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(111, 20)
        Me.lblHora.TabIndex = 1
        Me.lblHora.Text = "Hora de Inicio:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Lineas Reales:"
        '
        'General
        '
        Me.General.Controls.Add(Me.cboVersion)
        Me.General.Controls.Add(Me.Label5)
        Me.General.Controls.Add(Me.txtReferencia)
        Me.General.Controls.Add(Me.Label4)
        Me.General.Location = New System.Drawing.Point(15, 9)
        Me.General.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.General.Name = "General"
        Me.General.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.General.Size = New System.Drawing.Size(524, 151)
        Me.General.TabIndex = 8
        Me.General.TabStop = False
        Me.General.Text = "Propiedades"
        '
        'cboVersion
        '
        Me.cboVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVersion.Enabled = False
        Me.cboVersion.FormattingEnabled = True
        Me.cboVersion.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.cboVersion.Location = New System.Drawing.Point(166, 97)
        Me.cboVersion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboVersion.Name = "cboVersion"
        Me.cboVersion.Size = New System.Drawing.Size(130, 28)
        Me.cboVersion.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(78, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Versión:"
        '
        'txtReferencia
        '
        Me.txtReferencia.BackColor = System.Drawing.SystemColors.Window
        Me.txtReferencia.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtReferencia.Location = New System.Drawing.Point(166, 46)
        Me.txtReferencia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtReferencia.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtReferencia.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.RequiredField = True
        Me.txtReferencia.Size = New System.Drawing.Size(310, 26)
        Me.txtReferencia.TabIndex = 3
        Me.txtReferencia.UIName = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Referencia :"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.tabConfiguracion)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 298)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1924, 729)
        Me.Panel2.TabIndex = 33
        '
        'tabConfiguracion
        '
        Me.tabConfiguracion.Controls.Add(Me.pagCentralCompras)
        Me.tabConfiguracion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tabConfiguracion.ImageList = Me.iLstTabs
        Me.tabConfiguracion.Location = New System.Drawing.Point(0, 4)
        Me.tabConfiguracion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tabConfiguracion.Name = "tabConfiguracion"
        Me.tabConfiguracion.SelectedIndex = 0
        Me.tabConfiguracion.Size = New System.Drawing.Size(1924, 725)
        Me.tabConfiguracion.TabIndex = 2
        '
        'pagCentralCompras
        '
        Me.pagCentralCompras.Controls.Add(Me.gbxCentrosCompra)
        Me.pagCentralCompras.ImageIndex = 0
        Me.pagCentralCompras.Location = New System.Drawing.Point(4, 39)
        Me.pagCentralCompras.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pagCentralCompras.Name = "pagCentralCompras"
        Me.pagCentralCompras.Size = New System.Drawing.Size(1916, 682)
        Me.pagCentralCompras.TabIndex = 3
        Me.pagCentralCompras.Text = "Plan CDU"
        Me.pagCentralCompras.UseVisualStyleBackColor = True
        '
        'gbxCentrosCompra
        '
        Me.gbxCentrosCompra.Controls.Add(Me.cboOperadores)
        Me.gbxCentrosCompra.Controls.Add(Me.grdCajasCompletas)
        Me.gbxCentrosCompra.Controls.Add(Me.tbBancos)
        Me.gbxCentrosCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxCentrosCompra.Location = New System.Drawing.Point(0, 0)
        Me.gbxCentrosCompra.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbxCentrosCompra.Name = "gbxCentrosCompra"
        Me.gbxCentrosCompra.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbxCentrosCompra.Size = New System.Drawing.Size(1916, 682)
        Me.gbxCentrosCompra.TabIndex = 45
        Me.gbxCentrosCompra.TabStop = False
        '
        'cboOperadores
        '
        Me.cboOperadores.AllowColMove = True
        Me.cboOperadores.AllowColSelect = True
        Me.cboOperadores.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboOperadores.AlternatingRows = True
        Me.cboOperadores.CaptionStyle = Style1
        Me.cboOperadores.ColumnCaptionHeight = 17
        Me.cboOperadores.ColumnFooterHeight = 17
        Me.cboOperadores.DataSource = Me.bsOperadores
        Me.cboOperadores.DisplayMember = "Operario"
        Me.cboOperadores.DropdownWidth = C1.Win.C1TrueDBGrid.DropdownWidthEnum.Column
        Me.cboOperadores.EvenRowStyle = Style2
        Me.cboOperadores.ExtendRightColumn = True
        Me.cboOperadores.FetchRowStyles = False
        Me.cboOperadores.FooterStyle = Style3
        Me.cboOperadores.HeadingStyle = Style4
        Me.cboOperadores.HighLightRowStyle = Style5
        Me.cboOperadores.Images.Add(CType(resources.GetObject("cboOperadores.Images"), System.Drawing.Image))
        Me.cboOperadores.Location = New System.Drawing.Point(696, 251)
        Me.cboOperadores.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboOperadores.Name = "cboOperadores"
        Me.cboOperadores.OddRowStyle = Style6
        Me.cboOperadores.RecordSelectorStyle = Style7
        Me.cboOperadores.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboOperadores.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboOperadores.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboOperadores.ScrollTips = False
        Me.cboOperadores.Size = New System.Drawing.Size(107, 228)
        Me.cboOperadores.Style = Style8
        Me.cboOperadores.TabIndex = 56
        Me.cboOperadores.TabStop = False
        Me.cboOperadores.Text = "C1TrueDBDropdown1"
        Me.cboOperadores.ValueMember = "Operario"
        Me.cboOperadores.Visible = False
        Me.cboOperadores.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        Me.cboOperadores.PropBag = resources.GetString("cboOperadores.PropBag")
        '
        'grdCajasCompletas
        '
        Me.grdCajasCompletas.DataSource = Me.bsCajasCompletas
        Me.grdCajasCompletas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdCajasCompletas.Images.Add(CType(resources.GetObject("grdCajasCompletas.Images"), System.Drawing.Image))
        Me.grdCajasCompletas.Location = New System.Drawing.Point(4, 63)
        Me.grdCajasCompletas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grdCajasCompletas.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.grdCajasCompletas.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.Simple
        Me.grdCajasCompletas.Name = "grdCajasCompletas"
        Me.grdCajasCompletas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdCajasCompletas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdCajasCompletas.PreviewInfo.ZoomFactor = 75.0R
        Me.grdCajasCompletas.PrintInfo.PageSettings = CType(resources.GetObject("grdCajasCompletas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdCajasCompletas.Size = New System.Drawing.Size(1908, 614)
        Me.grdCajasCompletas.TabIndex = 55
        Me.grdCajasCompletas.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        Me.grdCajasCompletas.PropBag = resources.GetString("grdCajasCompletas.PropBag")
        '
        'tbBancos
        '
        Me.tbBancos.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbBancos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGenerarCajasCompletas})
        Me.tbBancos.Location = New System.Drawing.Point(4, 24)
        Me.tbBancos.Name = "tbBancos"
        Me.tbBancos.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.tbBancos.Size = New System.Drawing.Size(1908, 39)
        Me.tbBancos.TabIndex = 54
        Me.tbBancos.Text = "CiToolBar4"
        '
        'btnGenerarCajasCompletas
        '
        Me.btnGenerarCajasCompletas.Image = CType(resources.GetObject("btnGenerarCajasCompletas.Image"), System.Drawing.Image)
        Me.btnGenerarCajasCompletas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGenerarCajasCompletas.Name = "btnGenerarCajasCompletas"
        Me.btnGenerarCajasCompletas.Size = New System.Drawing.Size(109, 36)
        Me.btnGenerarCajasCompletas.Text = "Generar"
        '
        'iLstTabs
        '
        Me.iLstTabs.ImageStream = CType(resources.GetObject("iLstTabs.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.iLstTabs.TransparentColor = System.Drawing.Color.Transparent
        Me.iLstTabs.Images.SetKeyName(0, "CajasCompletas")
        Me.iLstTabs.Images.SetKeyName(1, "Resto.png")
        Me.iLstTabs.Images.SetKeyName(2, "priority.png")
        '
        'PlaneacionSurtidoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1049)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.Name = "PlaneacionSurtidoForm"
        Me.Text = "PlaneacionSurtidoForm"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtCantSurtidores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantEmpacadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.General.ResumeLayout(False)
        Me.General.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.tabConfiguracion.ResumeLayout(False)
        Me.pagCentralCompras.ResumeLayout(False)
        Me.gbxCentrosCompra.ResumeLayout(False)
        Me.gbxCentrosCompra.PerformLayout()
        CType(Me.cboOperadores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsOperadores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdCajasCompletas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCajasCompletas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbBancos.ResumeLayout(False)
        Me.tbBancos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New PlanSurtidoFacade()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents General As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpHoraInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpLineasReales As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboVersion As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtReferencia As Azteca.Windows.Controls.CITextBox
    Friend WithEvents tabConfiguracion As Azteca.Windows.Controls.CITab
    Friend WithEvents pagCentralCompras As System.Windows.Forms.TabPage
    Friend WithEvents gbxCentrosCompra As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents iLstTabs As System.Windows.Forms.ImageList
    Friend WithEvents txtCantSurtidores As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtCantEmpacadores As System.Windows.Forms.NumericUpDown
    Friend WithEvents tbBancos As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnGenerarCajasCompletas As System.Windows.Forms.ToolStripButton
    Friend WithEvents bsCajasCompletas As System.Windows.Forms.BindingSource
    Friend WithEvents grdCajasCompletas As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboOperadores As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents bsOperadores As System.Windows.Forms.BindingSource
End Class
