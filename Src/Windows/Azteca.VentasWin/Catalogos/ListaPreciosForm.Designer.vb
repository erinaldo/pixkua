<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaPreciosForm
    Inherits Azteca.Windows.Forms.BusinessForms.CatalogForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Style1 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style2 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style3 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style4 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style5 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListaPreciosForm))
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
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.lblNombre = New Azteca.Windows.Controls.CILabel()
        Me.dropDivisaArt = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.bsDivisasArt = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdArticulos = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsArticulos = New System.Windows.Forms.BindingSource(Me.components)
        Me.dropDivisaSvc = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.bsDivisaSvc = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdServicios = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsServicios = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdClientes = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsClientes = New System.Windows.Forms.BindingSource(Me.components)
        Me.iLstTabs = New System.Windows.Forms.ImageList(Me.components)
        Me.tabListaPrecios = New C1.Win.C1Command.C1DockingTab()
        Me.pagArticulos = New C1.Win.C1Command.C1DockingTabPage()
        Me.tlbArticulos = New Azteca.Windows.Controls.AZToolBar()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdProgramarArt = New C1.Win.C1Command.C1Command()
        Me.cmdAsignarArt = New C1.Win.C1Command.C1Command()
        Me.cmdAsignarSvc = New C1.Win.C1Command.C1Command()
        Me.cmdProgramarSvc = New C1.Win.C1Command.C1Command()
        Me.cmdAddCustomer = New C1.Win.C1Command.C1Command()
        Me.cmdSaveClientes = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.pagServicios = New C1.Win.C1Command.C1DockingTabPage()
        Me.tlbServicios = New Azteca.Windows.Controls.AZToolBar()
        Me.C1CommandLink3 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink4 = New C1.Win.C1Command.C1CommandLink()
        Me.pagClientes = New C1.Win.C1Command.C1DockingTabPage()
        Me.tlbClientes = New Azteca.Windows.Controls.AZToolBar()
        Me.C1CommandLink5 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink6 = New C1.Win.C1Command.C1CommandLink()
        CType(Me.dropDivisaArt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDivisasArt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dropDivisaSvc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDivisaSvc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabListaPrecios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabListaPrecios.SuspendLayout()
        Me.pagArticulos.SuspendLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagServicios.SuspendLayout()
        Me.pagClientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(62, 93)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(420, 20)
        Me.txtNombre.TabIndex = 30
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(9, 96)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 29
        Me.lblNombre.Text = "Nombre:"
        '
        'dropDivisaArt
        '
        Me.dropDivisaArt.AllowColMove = True
        Me.dropDivisaArt.AllowColSelect = True
        Me.dropDivisaArt.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.dropDivisaArt.AlternatingRows = False
        Me.dropDivisaArt.CaptionStyle = Style1
        Me.dropDivisaArt.ColumnCaptionHeight = 17
        Me.dropDivisaArt.ColumnFooterHeight = 17
        Me.dropDivisaArt.DataSource = Me.bsDivisasArt
        Me.dropDivisaArt.DisplayMember = "Nombre"
        Me.dropDivisaArt.EvenRowStyle = Style2
        Me.dropDivisaArt.FetchRowStyles = False
        Me.dropDivisaArt.FooterStyle = Style3
        Me.dropDivisaArt.HeadingStyle = Style4
        Me.dropDivisaArt.HighLightRowStyle = Style5
        Me.dropDivisaArt.Images.Add(CType(resources.GetObject("dropDivisaArt.Images"), System.Drawing.Image))
        Me.dropDivisaArt.Location = New System.Drawing.Point(288, 71)
        Me.dropDivisaArt.Name = "dropDivisaArt"
        Me.dropDivisaArt.OddRowStyle = Style6
        Me.dropDivisaArt.RecordSelectorStyle = Style7
        Me.dropDivisaArt.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.dropDivisaArt.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.dropDivisaArt.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.dropDivisaArt.ScrollTips = False
        Me.dropDivisaArt.Size = New System.Drawing.Size(357, 179)
        Me.dropDivisaArt.Style = Style8
        Me.dropDivisaArt.TabIndex = 47
        Me.dropDivisaArt.TabStop = False
        Me.dropDivisaArt.Text = "C1TrueDBDropdown1"
        Me.dropDivisaArt.ValueMember = "IdDivisa"
        Me.dropDivisaArt.ValueTranslate = True
        Me.dropDivisaArt.Visible = False
        Me.dropDivisaArt.PropBag = resources.GetString("dropDivisaArt.PropBag")
        '
        'grdArticulos
        '
        Me.grdArticulos.DataSource = Me.bsArticulos
        Me.grdArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdArticulos.ExtendRightColumn = True
        Me.grdArticulos.FilterBar = True
        Me.grdArticulos.Images.Add(CType(resources.GetObject("grdArticulos.Images"), System.Drawing.Image))
        Me.grdArticulos.Location = New System.Drawing.Point(0, 32)
        Me.grdArticulos.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.Simple
        Me.grdArticulos.Name = "grdArticulos"
        Me.grdArticulos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdArticulos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdArticulos.PreviewInfo.ZoomFactor = 75.0R
        Me.grdArticulos.PrintInfo.PageSettings = CType(resources.GetObject("grdArticulos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdArticulos.Size = New System.Drawing.Size(845, 290)
        Me.grdArticulos.TabIndex = 29
        Me.grdArticulos.Text = "AzTrueDBGrid1"
        Me.grdArticulos.PropBag = resources.GetString("grdArticulos.PropBag")
        '
        'dropDivisaSvc
        '
        Me.dropDivisaSvc.AllowColMove = True
        Me.dropDivisaSvc.AllowColSelect = True
        Me.dropDivisaSvc.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.dropDivisaSvc.AlternatingRows = False
        Me.dropDivisaSvc.CaptionStyle = Style9
        Me.dropDivisaSvc.ColumnCaptionHeight = 17
        Me.dropDivisaSvc.ColumnFooterHeight = 17
        Me.dropDivisaSvc.DataSource = Me.bsDivisaSvc
        Me.dropDivisaSvc.DisplayMember = "Nombre"
        Me.dropDivisaSvc.EvenRowStyle = Style10
        Me.dropDivisaSvc.FetchRowStyles = False
        Me.dropDivisaSvc.FooterStyle = Style11
        Me.dropDivisaSvc.HeadingStyle = Style12
        Me.dropDivisaSvc.HighLightRowStyle = Style13
        Me.dropDivisaSvc.Images.Add(CType(resources.GetObject("dropDivisaSvc.Images"), System.Drawing.Image))
        Me.dropDivisaSvc.Location = New System.Drawing.Point(71, 78)
        Me.dropDivisaSvc.Name = "dropDivisaSvc"
        Me.dropDivisaSvc.OddRowStyle = Style14
        Me.dropDivisaSvc.RecordSelectorStyle = Style15
        Me.dropDivisaSvc.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.dropDivisaSvc.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.dropDivisaSvc.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.dropDivisaSvc.ScrollTips = False
        Me.dropDivisaSvc.Size = New System.Drawing.Size(369, 185)
        Me.dropDivisaSvc.Style = Style16
        Me.dropDivisaSvc.TabIndex = 48
        Me.dropDivisaSvc.TabStop = False
        Me.dropDivisaSvc.Text = "C1TrueDBDropdown1"
        Me.dropDivisaSvc.ValueMember = "IdDivisa"
        Me.dropDivisaSvc.ValueTranslate = True
        Me.dropDivisaSvc.Visible = False
        Me.dropDivisaSvc.PropBag = resources.GetString("dropDivisaSvc.PropBag")
        '
        'grdServicios
        '
        Me.grdServicios.DataSource = Me.bsServicios
        Me.grdServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdServicios.ExtendRightColumn = True
        Me.grdServicios.FilterBar = True
        Me.grdServicios.Images.Add(CType(resources.GetObject("grdServicios.Images"), System.Drawing.Image))
        Me.grdServicios.Location = New System.Drawing.Point(0, 34)
        Me.grdServicios.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.Simple
        Me.grdServicios.Name = "grdServicios"
        Me.grdServicios.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdServicios.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdServicios.PreviewInfo.ZoomFactor = 75.0R
        Me.grdServicios.PrintInfo.PageSettings = CType(resources.GetObject("grdServicios.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdServicios.Size = New System.Drawing.Size(845, 288)
        Me.grdServicios.TabIndex = 29
        Me.grdServicios.Text = "AzTrueDBGrid1"
        Me.grdServicios.PropBag = resources.GetString("grdServicios.PropBag")
        '
        'grdClientes
        '
        Me.grdClientes.AlternatingRows = True
        Me.grdClientes.DataSource = Me.bsClientes
        Me.grdClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdClientes.FilterBar = True
        Me.grdClientes.Images.Add(CType(resources.GetObject("grdClientes.Images"), System.Drawing.Image))
        Me.grdClientes.Location = New System.Drawing.Point(0, 34)
        Me.grdClientes.Name = "grdClientes"
        Me.grdClientes.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdClientes.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdClientes.PreviewInfo.ZoomFactor = 75.0R
        Me.grdClientes.PrintInfo.PageSettings = CType(resources.GetObject("grdClientes.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdClientes.Size = New System.Drawing.Size(845, 288)
        Me.grdClientes.TabIndex = 30
        Me.grdClientes.Text = "AzTrueDBGrid1"
        Me.grdClientes.PropBag = resources.GetString("grdClientes.PropBag")
        '
        'iLstTabs
        '
        Me.iLstTabs.ImageStream = CType(resources.GetObject("iLstTabs.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.iLstTabs.TransparentColor = System.Drawing.Color.Transparent
        Me.iLstTabs.Images.SetKeyName(0, "Articulos")
        Me.iLstTabs.Images.SetKeyName(1, "Servicios")
        Me.iLstTabs.Images.SetKeyName(2, "Clientes")
        '
        'tabListaPrecios
        '
        Me.tabListaPrecios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabListaPrecios.Controls.Add(Me.pagArticulos)
        Me.tabListaPrecios.Controls.Add(Me.pagServicios)
        Me.tabListaPrecios.Controls.Add(Me.pagClientes)
        Me.tabListaPrecios.ImageList = Me.iLstTabs
        Me.tabListaPrecios.Location = New System.Drawing.Point(12, 119)
        Me.tabListaPrecios.Name = "tabListaPrecios"
        Me.tabListaPrecios.SelectedIndex = 2
        Me.tabListaPrecios.Size = New System.Drawing.Size(847, 364)
        Me.tabListaPrecios.TabIndex = 32
        Me.tabListaPrecios.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabListaPrecios.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabListaPrecios.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagArticulos
        '
        Me.pagArticulos.Controls.Add(Me.grdArticulos)
        Me.pagArticulos.Controls.Add(Me.tlbArticulos)
        Me.pagArticulos.Controls.Add(Me.dropDivisaArt)
        Me.pagArticulos.ImageIndex = 0
        Me.pagArticulos.Location = New System.Drawing.Point(1, 41)
        Me.pagArticulos.Name = "pagArticulos"
        Me.pagArticulos.Size = New System.Drawing.Size(845, 322)
        Me.pagArticulos.TabIndex = 0
        Me.pagArticulos.Text = "Artículos"
        '
        'tlbArticulos
        '
        Me.tlbArticulos.AccessibleName = "Tool Bar"
        Me.tlbArticulos.AutoSize = False
        Me.tlbArticulos.CommandHolder = Me.C1CommandHolder1
        Me.tlbArticulos.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink2, Me.C1CommandLink1})
        Me.tlbArticulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbArticulos.Location = New System.Drawing.Point(0, 0)
        Me.tlbArticulos.MinButtonSize = 32
        Me.tlbArticulos.Movable = False
        Me.tlbArticulos.Name = "tlbArticulos"
        Me.tlbArticulos.Size = New System.Drawing.Size(845, 32)
        Me.tlbArticulos.Text = "AzToolBar1"
        Me.tlbArticulos.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdProgramarArt)
        Me.C1CommandHolder1.Commands.Add(Me.cmdAsignarArt)
        Me.C1CommandHolder1.Commands.Add(Me.cmdAsignarSvc)
        Me.C1CommandHolder1.Commands.Add(Me.cmdProgramarSvc)
        Me.C1CommandHolder1.Commands.Add(Me.cmdAddCustomer)
        Me.C1CommandHolder1.Commands.Add(Me.cmdSaveClientes)
        Me.C1CommandHolder1.Owner = Me
        '
        'cmdProgramarArt
        '
        Me.cmdProgramarArt.Enabled = False
        Me.cmdProgramarArt.Image = CType(resources.GetObject("cmdProgramarArt.Image"), System.Drawing.Image)
        Me.cmdProgramarArt.Name = "cmdProgramarArt"
        Me.cmdProgramarArt.ShortcutText = ""
        Me.cmdProgramarArt.Text = "Programar Cambio"
        Me.cmdProgramarArt.ToolTipText = "Programar cambio de precios"
        '
        'cmdAsignarArt
        '
        Me.cmdAsignarArt.Image = CType(resources.GetObject("cmdAsignarArt.Image"), System.Drawing.Image)
        Me.cmdAsignarArt.Name = "cmdAsignarArt"
        Me.cmdAsignarArt.ShortcutText = ""
        Me.cmdAsignarArt.Text = "Asignación Múltiple"
        Me.cmdAsignarArt.ToolTipText = "Asignar precio a varios artículos a la vez"
        '
        'cmdAsignarSvc
        '
        Me.cmdAsignarSvc.Image = CType(resources.GetObject("cmdAsignarSvc.Image"), System.Drawing.Image)
        Me.cmdAsignarSvc.Name = "cmdAsignarSvc"
        Me.cmdAsignarSvc.ShortcutText = ""
        Me.cmdAsignarSvc.Text = "Asignación Múltiple"
        Me.cmdAsignarSvc.ToolTipText = "Asignar precio a varios servicios a la vez"
        '
        'cmdProgramarSvc
        '
        Me.cmdProgramarSvc.Enabled = False
        Me.cmdProgramarSvc.Image = CType(resources.GetObject("cmdProgramarSvc.Image"), System.Drawing.Image)
        Me.cmdProgramarSvc.Name = "cmdProgramarSvc"
        Me.cmdProgramarSvc.ShortcutText = ""
        Me.cmdProgramarSvc.Text = "Programar Cambio"
        Me.cmdProgramarSvc.ToolTipText = "Programar cambio de precio"
        '
        'cmdAddCustomer
        '
        Me.cmdAddCustomer.Image = CType(resources.GetObject("cmdAddCustomer.Image"), System.Drawing.Image)
        Me.cmdAddCustomer.Name = "cmdAddCustomer"
        Me.cmdAddCustomer.ShortcutText = ""
        Me.cmdAddCustomer.Text = "Agregar Clientes"
        '
        'cmdSaveClientes
        '
        Me.cmdSaveClientes.Image = CType(resources.GetObject("cmdSaveClientes.Image"), System.Drawing.Image)
        Me.cmdSaveClientes.Name = "cmdSaveClientes"
        Me.cmdSaveClientes.ShortcutText = ""
        Me.cmdSaveClientes.Text = "Guardar"
        '
        'C1CommandLink2
        '
        Me.C1CommandLink2.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink2.Command = Me.cmdAsignarArt
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink1.Command = Me.cmdProgramarArt
        Me.C1CommandLink1.SortOrder = 1
        '
        'pagServicios
        '
        Me.pagServicios.Controls.Add(Me.grdServicios)
        Me.pagServicios.Controls.Add(Me.dropDivisaSvc)
        Me.pagServicios.Controls.Add(Me.tlbServicios)
        Me.pagServicios.ImageIndex = 1
        Me.pagServicios.Location = New System.Drawing.Point(1, 41)
        Me.pagServicios.Name = "pagServicios"
        Me.pagServicios.Size = New System.Drawing.Size(845, 322)
        Me.pagServicios.TabIndex = 1
        Me.pagServicios.Text = "Servicios"
        '
        'tlbServicios
        '
        Me.tlbServicios.AccessibleName = "Tool Bar"
        Me.tlbServicios.AutoSize = False
        Me.tlbServicios.CommandHolder = Me.C1CommandHolder1
        Me.tlbServicios.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink3, Me.C1CommandLink4})
        Me.tlbServicios.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbServicios.Location = New System.Drawing.Point(0, 0)
        Me.tlbServicios.MinButtonSize = 32
        Me.tlbServicios.Movable = False
        Me.tlbServicios.Name = "tlbServicios"
        Me.tlbServicios.Size = New System.Drawing.Size(845, 34)
        Me.tlbServicios.Text = "AzToolBar1"
        Me.tlbServicios.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'C1CommandLink3
        '
        Me.C1CommandLink3.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink3.Command = Me.cmdAsignarSvc
        '
        'C1CommandLink4
        '
        Me.C1CommandLink4.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink4.Command = Me.cmdProgramarSvc
        Me.C1CommandLink4.SortOrder = 1
        '
        'pagClientes
        '
        Me.pagClientes.Controls.Add(Me.grdClientes)
        Me.pagClientes.Controls.Add(Me.tlbClientes)
        Me.pagClientes.ImageIndex = 2
        Me.pagClientes.Location = New System.Drawing.Point(1, 41)
        Me.pagClientes.Name = "pagClientes"
        Me.pagClientes.Size = New System.Drawing.Size(845, 322)
        Me.pagClientes.TabIndex = 2
        Me.pagClientes.Text = "Clientes"
        '
        'tlbClientes
        '
        Me.tlbClientes.AccessibleName = "Tool Bar"
        Me.tlbClientes.AutoSize = False
        Me.tlbClientes.CommandHolder = Me.C1CommandHolder1
        Me.tlbClientes.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink5, Me.C1CommandLink6})
        Me.tlbClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbClientes.Location = New System.Drawing.Point(0, 0)
        Me.tlbClientes.MinButtonSize = 32
        Me.tlbClientes.Movable = False
        Me.tlbClientes.Name = "tlbClientes"
        Me.tlbClientes.Size = New System.Drawing.Size(845, 34)
        Me.tlbClientes.Text = "AzToolBar1"
        Me.tlbClientes.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'C1CommandLink5
        '
        Me.C1CommandLink5.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink5.Command = Me.cmdAddCustomer
        '
        'C1CommandLink6
        '
        Me.C1CommandLink6.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink6.Command = Me.cmdSaveClientes
        Me.C1CommandLink6.SortOrder = 1
        '
        'ListaPreciosForm
        '
        Me.AllowRecordNavigation = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 511)
        Me.Controls.Add(Me.tabListaPrecios)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "ListaPreciosForm"
        Me.Text = "ListaPreciosForm"
        Me.Controls.SetChildIndex(Me.lblNombre, 0)
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.tabListaPrecios, 0)
        CType(Me.dropDivisaArt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDivisasArt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dropDivisaSvc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDivisaSvc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabListaPrecios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabListaPrecios.ResumeLayout(False)
        Me.pagArticulos.ResumeLayout(False)
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagServicios.ResumeLayout(False)
        Me.pagClientes.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblNombre As Azteca.Windows.Controls.CILabel


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Facade = New ListaPreciosFacade
    End Sub
    Friend WithEvents grdArticulos As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents dropDivisaArt As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents dropDivisaSvc As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents grdServicios As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents grdClientes As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents tabListaPrecios As C1.Win.C1Command.C1DockingTab
    Friend WithEvents pagArticulos As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents tlbArticulos As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents cmdProgramarArt As C1.Win.C1Command.C1Command
    Friend WithEvents cmdAsignarArt As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents pagServicios As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagClientes As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents tlbServicios As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents C1CommandLink3 As C1.Win.C1Command.C1CommandLink
    Private WithEvents iLstTabs As System.Windows.Forms.ImageList
    Private WithEvents bsArticulos As System.Windows.Forms.BindingSource
    Private WithEvents bsDivisasArt As System.Windows.Forms.BindingSource
    Private WithEvents bsServicios As System.Windows.Forms.BindingSource
    Private WithEvents bsClientes As System.Windows.Forms.BindingSource
    Private WithEvents bsDivisaSvc As System.Windows.Forms.BindingSource
    Friend WithEvents cmdAsignarSvc As C1.Win.C1Command.C1Command
    Friend WithEvents cmdProgramarSvc As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink4 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents tlbClientes As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents C1CommandLink5 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdAddCustomer As C1.Win.C1Command.C1Command
    Friend WithEvents cmdSaveClientes As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink6 As C1.Win.C1Command.C1CommandLink
End Class
