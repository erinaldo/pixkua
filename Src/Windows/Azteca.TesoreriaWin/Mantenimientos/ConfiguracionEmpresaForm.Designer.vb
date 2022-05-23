<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfiguracionEmpresaForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfiguracionEmpresaForm))
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
        Me.gbxCentrosCompra = New Azteca.Windows.Controls.CIGroupBox()
        Me.grdCajas = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsCajas = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbCajas = New Azteca.Windows.Controls.AZToolBar()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdCajaActualizar = New C1.Win.C1Command.C1Command()
        Me.cmdCajaNew = New C1.Win.C1Command.C1Command()
        Me.cmdBancoRefresh = New C1.Win.C1Command.C1Command()
        Me.cmdBancoAdd = New C1.Win.C1Command.C1Command()
        Me.btn = New C1.Win.C1Command.C1CommandLink()
        Me.btnCajaNew = New C1.Win.C1Command.C1CommandLink()
        Me.dropOperador = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.dropRemitentes = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.lblCajas = New Azteca.Windows.Controls.CILabel()
        Me.gbxBancos = New Azteca.Windows.Controls.CIGroupBox()
        Me.grdBancos = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsBancos = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbBancos = New Azteca.Windows.Controls.AZToolBar()
        Me.btnBancoRefresh = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.lblBancosTitulo = New Azteca.Windows.Controls.CILabel()
        Me.iLstTab = New System.Windows.Forms.ImageList(Me.components)
        Me.pnlTitulo = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha2 = New Azteca.Windows.ColorWithAlpha()
        Me.lblConfiguracion = New Azteca.Windows.Controls.CILabel()
        Me.tabConfig = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagCajas = New C1.Win.C1Command.C1DockingTabPage()
        Me.pagBancos = New C1.Win.C1Command.C1DockingTabPage()
        Me.gbxCentrosCompra.SuspendLayout()
        CType(Me.grdCajas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCajas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dropOperador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dropRemitentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxBancos.SuspendLayout()
        CType(Me.grdBancos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsBancos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitulo.SuspendLayout()
        CType(Me.tabConfig, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabConfig.SuspendLayout()
        Me.pagCajas.SuspendLayout()
        Me.pagBancos.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxCentrosCompra
        '
        Me.gbxCentrosCompra.Controls.Add(Me.grdCajas)
        Me.gbxCentrosCompra.Controls.Add(Me.tbCajas)
        Me.gbxCentrosCompra.Controls.Add(Me.dropOperador)
        Me.gbxCentrosCompra.Controls.Add(Me.dropRemitentes)
        Me.gbxCentrosCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxCentrosCompra.Location = New System.Drawing.Point(0, 37)
        Me.gbxCentrosCompra.Name = "gbxCentrosCompra"
        Me.gbxCentrosCompra.Size = New System.Drawing.Size(885, 313)
        Me.gbxCentrosCompra.TabIndex = 47
        Me.gbxCentrosCompra.TabStop = False
        '
        'grdCajas
        '
        Me.grdCajas.AlternatingRows = True
        Me.grdCajas.DataSource = Me.bsCajas
        Me.grdCajas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdCajas.Enabled = False
        Me.grdCajas.IDCatalogField = "IdCaja"
        Me.grdCajas.Images.Add(CType(resources.GetObject("grdCajas.Images"), System.Drawing.Image))
        Me.grdCajas.Images.Add(CType(resources.GetObject("grdCajas.Images1"), System.Drawing.Image))
        Me.grdCajas.Location = New System.Drawing.Point(3, 49)
        Me.grdCajas.Name = "grdCajas"
        Me.grdCajas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdCajas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdCajas.PreviewInfo.ZoomFactor = 75.0R
        Me.grdCajas.PrintInfo.PageSettings = CType(resources.GetObject("grdCajas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdCajas.RowHeight = 16
        Me.grdCajas.Size = New System.Drawing.Size(879, 261)
        Me.grdCajas.TabIndex = 41
        Me.grdCajas.Text = "AzTrueDBGrid1"
        Me.grdCajas.PropBag = resources.GetString("grdCajas.PropBag")
        '
        'tbCajas
        '
        Me.tbCajas.AccessibleName = "Tool Bar"
        Me.tbCajas.AutoSize = False
        Me.tbCajas.CommandHolder = Me.C1CommandHolder1
        Me.tbCajas.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.btn, Me.btnCajaNew})
        Me.tbCajas.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbCajas.Location = New System.Drawing.Point(3, 16)
        Me.tbCajas.MinButtonSize = 32
        Me.tbCajas.Movable = False
        Me.tbCajas.Name = "tbCajas"
        Me.tbCajas.Size = New System.Drawing.Size(879, 33)
        Me.tbCajas.Text = "AzToolBar1"
        Me.tbCajas.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2003Blue
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdCajaActualizar)
        Me.C1CommandHolder1.Commands.Add(Me.cmdCajaNew)
        Me.C1CommandHolder1.Commands.Add(Me.cmdBancoRefresh)
        Me.C1CommandHolder1.Commands.Add(Me.cmdBancoAdd)
        Me.C1CommandHolder1.Owner = Me
        '
        'cmdCajaActualizar
        '
        Me.cmdCajaActualizar.Image = CType(resources.GetObject("cmdCajaActualizar.Image"), System.Drawing.Image)
        Me.cmdCajaActualizar.Name = "cmdCajaActualizar"
        Me.cmdCajaActualizar.Text = "Actualizar"
        '
        'cmdCajaNew
        '
        Me.cmdCajaNew.Enabled = False
        Me.cmdCajaNew.Image = CType(resources.GetObject("cmdCajaNew.Image"), System.Drawing.Image)
        Me.cmdCajaNew.Name = "cmdCajaNew"
        Me.cmdCajaNew.Text = "Nueva Caja de Pago"
        '
        'cmdBancoRefresh
        '
        Me.cmdBancoRefresh.Image = CType(resources.GetObject("cmdBancoRefresh.Image"), System.Drawing.Image)
        Me.cmdBancoRefresh.Name = "cmdBancoRefresh"
        Me.cmdBancoRefresh.Text = "Actualizar"
        '
        'cmdBancoAdd
        '
        Me.cmdBancoAdd.Enabled = False
        Me.cmdBancoAdd.Image = CType(resources.GetObject("cmdBancoAdd.Image"), System.Drawing.Image)
        Me.cmdBancoAdd.Name = "cmdBancoAdd"
        Me.cmdBancoAdd.Text = "Nuevo Banco"
        '
        'btn
        '
        Me.btn.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btn.Command = Me.cmdCajaActualizar
        '
        'btnCajaNew
        '
        Me.btnCajaNew.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnCajaNew.Command = Me.cmdCajaNew
        Me.btnCajaNew.SortOrder = 1
        '
        'dropOperador
        '
        Me.dropOperador.AllowColMove = True
        Me.dropOperador.AllowColSelect = True
        Me.dropOperador.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.dropOperador.AlternatingRows = False
        Me.dropOperador.CaptionStyle = Style1
        Me.dropOperador.ColumnCaptionHeight = 17
        Me.dropOperador.ColumnFooterHeight = 17
        Me.dropOperador.DisplayMember = "Nombre"
        Me.dropOperador.EvenRowStyle = Style2
        Me.dropOperador.ExtendRightColumn = True
        Me.dropOperador.FetchRowStyles = False
        Me.dropOperador.FooterStyle = Style3
        Me.dropOperador.HeadingStyle = Style4
        Me.dropOperador.HighLightRowStyle = Style5
        Me.dropOperador.Images.Add(CType(resources.GetObject("dropOperador.Images"), System.Drawing.Image))
        Me.dropOperador.Location = New System.Drawing.Point(555, 130)
        Me.dropOperador.Name = "dropOperador"
        Me.dropOperador.OddRowStyle = Style6
        Me.dropOperador.RecordSelectorStyle = Style7
        Me.dropOperador.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.dropOperador.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.dropOperador.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.dropOperador.ScrollTips = False
        Me.dropOperador.Size = New System.Drawing.Size(232, 101)
        Me.dropOperador.Style = Style8
        Me.dropOperador.TabIndex = 44
        Me.dropOperador.TabStop = False
        Me.dropOperador.Text = "C1TrueDBDropdown1"
        Me.dropOperador.ValueMember = "IdOperador"
        Me.dropOperador.ValueTranslate = True
        Me.dropOperador.Visible = False
        Me.dropOperador.PropBag = resources.GetString("dropOperador.PropBag")
        '
        'dropRemitentes
        '
        Me.dropRemitentes.AllowColMove = True
        Me.dropRemitentes.AllowColSelect = True
        Me.dropRemitentes.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.dropRemitentes.AlternatingRows = False
        Me.dropRemitentes.CaptionStyle = Style9
        Me.dropRemitentes.ColumnCaptionHeight = 17
        Me.dropRemitentes.ColumnFooterHeight = 17
        Me.dropRemitentes.DisplayMember = "Nombre"
        Me.dropRemitentes.EvenRowStyle = Style10
        Me.dropRemitentes.ExtendRightColumn = True
        Me.dropRemitentes.FetchRowStyles = False
        Me.dropRemitentes.FooterStyle = Style11
        Me.dropRemitentes.HeadingStyle = Style12
        Me.dropRemitentes.HighLightRowStyle = Style13
        Me.dropRemitentes.Images.Add(CType(resources.GetObject("dropRemitentes.Images"), System.Drawing.Image))
        Me.dropRemitentes.Location = New System.Drawing.Point(227, 130)
        Me.dropRemitentes.Name = "dropRemitentes"
        Me.dropRemitentes.OddRowStyle = Style14
        Me.dropRemitentes.RecordSelectorStyle = Style15
        Me.dropRemitentes.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.dropRemitentes.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.dropRemitentes.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.dropRemitentes.ScrollTips = False
        Me.dropRemitentes.Size = New System.Drawing.Size(359, 101)
        Me.dropRemitentes.Style = Style16
        Me.dropRemitentes.TabIndex = 43
        Me.dropRemitentes.TabStop = False
        Me.dropRemitentes.Text = "C1TrueDBDropdown1"
        Me.dropRemitentes.ValueMember = "IdRemitenteMail"
        Me.dropRemitentes.ValueTranslate = True
        Me.dropRemitentes.Visible = False
        Me.dropRemitentes.PropBag = resources.GetString("dropRemitentes.PropBag")
        '
        'lblCajas
        '
        Me.lblCajas.BackColor = System.Drawing.Color.Transparent
        Me.lblCajas.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCajas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCajas.ForeColor = System.Drawing.Color.Gray
        Me.lblCajas.Location = New System.Drawing.Point(0, 0)
        Me.lblCajas.Name = "lblCajas"
        Me.lblCajas.Size = New System.Drawing.Size(885, 37)
        Me.lblCajas.TabIndex = 46
        Me.lblCajas.Text = "Central de emisión de Pagos"
        Me.lblCajas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbxBancos
        '
        Me.gbxBancos.Controls.Add(Me.grdBancos)
        Me.gbxBancos.Controls.Add(Me.tbBancos)
        Me.gbxBancos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxBancos.Location = New System.Drawing.Point(0, 37)
        Me.gbxBancos.Name = "gbxBancos"
        Me.gbxBancos.Size = New System.Drawing.Size(885, 313)
        Me.gbxBancos.TabIndex = 49
        Me.gbxBancos.TabStop = False
        '
        'grdBancos
        '
        Me.grdBancos.AlternatingRows = True
        Me.grdBancos.DataSource = Me.bsBancos
        Me.grdBancos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdBancos.Enabled = False
        Me.grdBancos.IDCatalogField = "IdBanco"
        Me.grdBancos.Images.Add(CType(resources.GetObject("grdBancos.Images"), System.Drawing.Image))
        Me.grdBancos.Images.Add(CType(resources.GetObject("grdBancos.Images1"), System.Drawing.Image))
        Me.grdBancos.Location = New System.Drawing.Point(3, 47)
        Me.grdBancos.Name = "grdBancos"
        Me.grdBancos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdBancos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdBancos.PreviewInfo.ZoomFactor = 75.0R
        Me.grdBancos.PrintInfo.PageSettings = CType(resources.GetObject("grdBancos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdBancos.RowHeight = 16
        Me.grdBancos.Size = New System.Drawing.Size(879, 263)
        Me.grdBancos.TabIndex = 41
        Me.grdBancos.Text = "AzTrueDBGrid1"
        Me.grdBancos.PropBag = resources.GetString("grdBancos.PropBag")
        '
        'tbBancos
        '
        Me.tbBancos.AccessibleName = "Tool Bar"
        Me.tbBancos.AutoSize = False
        Me.tbBancos.CommandHolder = Me.C1CommandHolder1
        Me.tbBancos.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.btnBancoRefresh, Me.C1CommandLink1})
        Me.tbBancos.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbBancos.Location = New System.Drawing.Point(3, 16)
        Me.tbBancos.MinButtonSize = 32
        Me.tbBancos.Movable = False
        Me.tbBancos.Name = "tbBancos"
        Me.tbBancos.Size = New System.Drawing.Size(879, 31)
        Me.tbBancos.Text = "AzToolBar2"
        Me.tbBancos.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2003Blue
        '
        'btnBancoRefresh
        '
        Me.btnBancoRefresh.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnBancoRefresh.Command = Me.cmdBancoRefresh
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink1.Command = Me.cmdBancoAdd
        Me.C1CommandLink1.SortOrder = 1
        '
        'lblBancosTitulo
        '
        Me.lblBancosTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblBancosTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblBancosTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBancosTitulo.ForeColor = System.Drawing.Color.Gray
        Me.lblBancosTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblBancosTitulo.Name = "lblBancosTitulo"
        Me.lblBancosTitulo.Size = New System.Drawing.Size(885, 37)
        Me.lblBancosTitulo.TabIndex = 48
        Me.lblBancosTitulo.Text = "Listado de Bancos que administra la Empresa"
        Me.lblBancosTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'iLstTab
        '
        Me.iLstTab.ImageStream = CType(resources.GetObject("iLstTab.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.iLstTab.TransparentColor = System.Drawing.Color.Transparent
        Me.iLstTab.Images.SetKeyName(0, "Caja_64.png")
        Me.iLstTab.Images.SetKeyName(1, "bank_32.png")
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.Transparent
        Me.pnlTitulo.Border = True
        Me.pnlTitulo.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlTitulo.Colors.Add(Me.ColorWithAlpha1)
        Me.pnlTitulo.Colors.Add(Me.ColorWithAlpha2)
        Me.pnlTitulo.ContentPadding = New System.Windows.Forms.Padding(14, 3, 15, 3)
        Me.pnlTitulo.Controls.Add(Me.lblConfiguracion)
        Me.pnlTitulo.CornerRadius = 10
        Me.pnlTitulo.Corners = CType((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight), Azteca.Windows.Corner)
        Me.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitulo.Gradient = True
        Me.pnlTitulo.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlTitulo.GradientOffset = 1.0!
        Me.pnlTitulo.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlTitulo.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlTitulo.Grayscale = False
        Me.pnlTitulo.Image = Nothing
        Me.pnlTitulo.ImageAlpha = 75
        Me.pnlTitulo.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlTitulo.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlTitulo.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Rounded = True
        Me.pnlTitulo.Size = New System.Drawing.Size(911, 44)
        Me.pnlTitulo.TabIndex = 45
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.LightSteelBlue
        Me.ColorWithAlpha1.Parent = Me.pnlTitulo
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.LightSteelBlue
        Me.ColorWithAlpha2.Parent = Me.pnlTitulo
        '
        'lblConfiguracion
        '
        Me.lblConfiguracion.BackColor = System.Drawing.Color.Transparent
        Me.lblConfiguracion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblConfiguracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfiguracion.ForeColor = System.Drawing.Color.SlateGray
        Me.lblConfiguracion.Location = New System.Drawing.Point(0, 0)
        Me.lblConfiguracion.Name = "lblConfiguracion"
        Me.lblConfiguracion.Size = New System.Drawing.Size(911, 44)
        Me.lblConfiguracion.TabIndex = 35
        Me.lblConfiguracion.Text = "Configuración del Módulo de Tesoreria"
        Me.lblConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabConfig
        '
        Me.tabConfig.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabConfig.Controls.Add(Me.pagCajas)
        Me.tabConfig.Controls.Add(Me.pagBancos)
        Me.tabConfig.ImageList = Me.iLstTab
        Me.tabConfig.Location = New System.Drawing.Point(12, 48)
        Me.tabConfig.Name = "tabConfig"
        Me.tabConfig.SelectedIndex = 1
        Me.tabConfig.Size = New System.Drawing.Size(887, 392)
        Me.tabConfig.TabIndex = 45
        Me.tabConfig.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2003
        Me.tabConfig.VisualStyle = C1.Win.C1Command.VisualStyle.Office2003Blue
        Me.tabConfig.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2003Blue
        '
        'pagCajas
        '
        Me.pagCajas.Controls.Add(Me.gbxCentrosCompra)
        Me.pagCajas.Controls.Add(Me.lblCajas)
        Me.pagCajas.ImageIndex = 0
        Me.pagCajas.Location = New System.Drawing.Point(1, 41)
        Me.pagCajas.Name = "pagCajas"
        Me.pagCajas.Size = New System.Drawing.Size(885, 350)
        Me.pagCajas.TabIndex = 0
        Me.pagCajas.Text = "Cajas"
        '
        'pagBancos
        '
        Me.pagBancos.Controls.Add(Me.gbxBancos)
        Me.pagBancos.Controls.Add(Me.lblBancosTitulo)
        Me.pagBancos.ImageIndex = 1
        Me.pagBancos.Location = New System.Drawing.Point(1, 41)
        Me.pagBancos.Name = "pagBancos"
        Me.pagBancos.Size = New System.Drawing.Size(885, 350)
        Me.pagBancos.TabIndex = 1
        Me.pagBancos.Text = "Bancos"
        '
        'ConfiguracionEmpresaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 447)
        Me.Controls.Add(Me.tabConfig)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Name = "ConfiguracionEmpresaForm"
        Me.Text = "ConfiguracionEmpresaForm"
        Me.gbxCentrosCompra.ResumeLayout(False)
        CType(Me.grdCajas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCajas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dropOperador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dropRemitentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxBancos.ResumeLayout(False)
        CType(Me.grdBancos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsBancos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitulo.ResumeLayout(False)
        CType(Me.tabConfig, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabConfig.ResumeLayout(False)
        Me.pagCajas.ResumeLayout(False)
        Me.pagBancos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents iLstTab As System.Windows.Forms.ImageList
    Friend WithEvents gbxCentrosCompra As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents grdCajas As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents dropOperador As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents dropRemitentes As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents lblCajas As Azteca.Windows.Controls.CILabel
    Friend WithEvents pnlTitulo As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents lblConfiguracion As Azteca.Windows.Controls.CILabel
    Friend WithEvents gbxBancos As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents grdBancos As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents lblBancosTitulo As Azteca.Windows.Controls.CILabel
    Friend WithEvents bsBancos As System.Windows.Forms.BindingSource
    Friend WithEvents tabConfig As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagCajas As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagBancos As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents tbCajas As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents cmdCajaActualizar As C1.Win.C1Command.C1Command
    Friend WithEvents btn As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdCajaNew As C1.Win.C1Command.C1Command
    Friend WithEvents btnCajaNew As C1.Win.C1Command.C1CommandLink
    Friend WithEvents tbBancos As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents btnBancoRefresh As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdBancoRefresh As C1.Win.C1Command.C1Command
    Friend WithEvents cmdBancoAdd As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Private WithEvents bsCajas As System.Windows.Forms.BindingSource
End Class
