<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CapturaRequisicionesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CapturaRequisicionesForm))
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
        Dim Style17 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style18 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style19 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style20 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style21 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style22 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style23 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style24 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdGuardar = New C1.Win.C1Command.C1Command()
        Me.cmdCancelar = New C1.Win.C1Command.C1Command()
        Me.cboCentrosRecep = New Azteca.Windows.Compras.CentrosRecepcionComboBox()
        Me.lblCentroRecepcion = New Azteca.Windows.Controls.CILabel()
        Me.cboPresupuesto = New Azteca.Windows.Compras.PresupuestoComboBox()
        Me.lblPresupuesto = New Azteca.Windows.Controls.CILabel()
        Me.cboDepartamento = New Azteca.Windows.Compras.DepartamentoComboBox()
        Me.lblDepartamento = New Azteca.Windows.Controls.CILabel()
        Me.cboTipoRequisicion = New Azteca.Windows.Compras.RequisicionesTiposComboBox()
        Me.lblRequisicionTipo = New Azteca.Windows.Controls.CILabel()
        Me.cboCategoriasArt = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.bsCategoriasArt = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboUnidades = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.bsUnidades = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdArticulos = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsArticulos = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboCategoriasServ = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.bsCategoriasServ = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdServicios = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsServicios = New System.Windows.Forms.BindingSource(Me.components)
        Me.imlPartidas = New System.Windows.Forms.ImageList(Me.components)
        Me.tabHeader = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagGeneral = New C1.Win.C1Command.C1DockingTabPage()
        Me.tabPartidas = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagArticulos = New C1.Win.C1Command.C1DockingTabPage()
        Me.pagServicios = New C1.Win.C1Command.C1DockingTabPage()
        Me.tlbMenu = New Azteca.Windows.Controls.AZToolBar()
        Me.btnGuardar = New C1.Win.C1Command.C1CommandLink()
        Me.btnCancelar = New C1.Win.C1Command.C1CommandLink()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCategoriasArt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCategoriasArt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCategoriasServ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCategoriasServ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabHeader.SuspendLayout()
        Me.pagGeneral.SuspendLayout()
        CType(Me.tabPartidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPartidas.SuspendLayout()
        Me.pagArticulos.SuspendLayout()
        Me.pagServicios.SuspendLayout()
        Me.SuspendLayout()
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdGuardar)
        Me.C1CommandHolder1.Commands.Add(Me.cmdCancelar)
        Me.C1CommandHolder1.Owner = Me
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.Image"), System.Drawing.Image)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.ToolTipText = "Guardar requisición"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cboCentrosRecep
        '
        Me.cboCentrosRecep.AutoClear = False
        Me.cboCentrosRecep.BackColor = System.Drawing.SystemColors.Window
        Me.cboCentrosRecep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCentrosRecep.FormattingEnabled = True
        Me.cboCentrosRecep.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboCentrosRecep.ItemsTable = Nothing
        Me.cboCentrosRecep.Location = New System.Drawing.Point(128, 41)
        Me.cboCentrosRecep.Name = "cboCentrosRecep"
        Me.cboCentrosRecep.RequiredField = True
        Me.cboCentrosRecep.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboCentrosRecep.Size = New System.Drawing.Size(226, 21)
        Me.cboCentrosRecep.TabIndex = 5
        Me.cboCentrosRecep.UIName = Nothing
        '
        'lblCentroRecepcion
        '
        Me.lblCentroRecepcion.AutoSize = True
        Me.lblCentroRecepcion.Location = New System.Drawing.Point(18, 44)
        Me.lblCentroRecepcion.Name = "lblCentroRecepcion"
        Me.lblCentroRecepcion.Size = New System.Drawing.Size(96, 13)
        Me.lblCentroRecepcion.TabIndex = 4
        Me.lblCentroRecepcion.Text = "Centro Recepción:"
        '
        'cboPresupuesto
        '
        Me.cboPresupuesto.AutoClear = False
        Me.cboPresupuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPresupuesto.FormattingEnabled = True
        Me.cboPresupuesto.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboPresupuesto.ItemsTable = Nothing
        Me.cboPresupuesto.Location = New System.Drawing.Point(435, 14)
        Me.cboPresupuesto.Name = "cboPresupuesto"
        Me.cboPresupuesto.RequiredField = True
        Me.cboPresupuesto.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboPresupuesto.Size = New System.Drawing.Size(226, 21)
        Me.cboPresupuesto.TabIndex = 3
        Me.cboPresupuesto.UIName = Nothing
        '
        'lblPresupuesto
        '
        Me.lblPresupuesto.AutoSize = True
        Me.lblPresupuesto.Location = New System.Drawing.Point(360, 17)
        Me.lblPresupuesto.Name = "lblPresupuesto"
        Me.lblPresupuesto.Size = New System.Drawing.Size(69, 13)
        Me.lblPresupuesto.TabIndex = 2
        Me.lblPresupuesto.Text = "Presupuesto:"
        '
        'cboDepartamento
        '
        Me.cboDepartamento.AutoClear = False
        Me.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepartamento.FormattingEnabled = True
        Me.cboDepartamento.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboDepartamento.ItemsTable = Nothing
        Me.cboDepartamento.Location = New System.Drawing.Point(128, 14)
        Me.cboDepartamento.Name = "cboDepartamento"
        Me.cboDepartamento.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboDepartamento.Size = New System.Drawing.Size(226, 21)
        Me.cboDepartamento.TabIndex = 1
        Me.cboDepartamento.UIName = Nothing
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.Location = New System.Drawing.Point(18, 17)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(77, 13)
        Me.lblDepartamento.TabIndex = 0
        Me.lblDepartamento.Text = "Departamento:"
        '
        'cboTipoRequisicion
        '
        Me.cboTipoRequisicion.AutoClear = False
        Me.cboTipoRequisicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoRequisicion.FormattingEnabled = True
        Me.cboTipoRequisicion.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboTipoRequisicion.ItemsTable = Nothing
        Me.cboTipoRequisicion.Location = New System.Drawing.Point(128, 68)
        Me.cboTipoRequisicion.Name = "cboTipoRequisicion"
        Me.cboTipoRequisicion.RequiredField = True
        Me.cboTipoRequisicion.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboTipoRequisicion.Size = New System.Drawing.Size(226, 21)
        Me.cboTipoRequisicion.TabIndex = 7
        Me.cboTipoRequisicion.UIName = Nothing
        '
        'lblRequisicionTipo
        '
        Me.lblRequisicionTipo.AutoSize = True
        Me.lblRequisicionTipo.Location = New System.Drawing.Point(18, 71)
        Me.lblRequisicionTipo.Name = "lblRequisicionTipo"
        Me.lblRequisicionTipo.Size = New System.Drawing.Size(104, 13)
        Me.lblRequisicionTipo.TabIndex = 6
        Me.lblRequisicionTipo.Text = "Tipo de Requisición:"
        '
        'cboCategoriasArt
        '
        Me.cboCategoriasArt.AllowColMove = True
        Me.cboCategoriasArt.AllowColSelect = True
        Me.cboCategoriasArt.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboCategoriasArt.AlternatingRows = False
        Me.cboCategoriasArt.CaptionStyle = Style1
        Me.cboCategoriasArt.ColumnCaptionHeight = 17
        Me.cboCategoriasArt.ColumnFooterHeight = 17
        Me.cboCategoriasArt.DataSource = Me.bsCategoriasArt
        Me.cboCategoriasArt.DisplayMember = "Nombre"
        Me.cboCategoriasArt.EvenRowStyle = Style2
        Me.cboCategoriasArt.ExtendRightColumn = True
        Me.cboCategoriasArt.FetchRowStyles = False
        Me.cboCategoriasArt.FooterStyle = Style3
        Me.cboCategoriasArt.HeadingStyle = Style4
        Me.cboCategoriasArt.HighLightRowStyle = Style5
        Me.cboCategoriasArt.Images.Add(CType(resources.GetObject("cboCategoriasArt.Images"), System.Drawing.Image))
        Me.cboCategoriasArt.Location = New System.Drawing.Point(404, 24)
        Me.cboCategoriasArt.Name = "cboCategoriasArt"
        Me.cboCategoriasArt.OddRowStyle = Style6
        Me.cboCategoriasArt.RecordSelectorStyle = Style7
        Me.cboCategoriasArt.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCategoriasArt.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboCategoriasArt.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCategoriasArt.ScrollTips = False
        Me.cboCategoriasArt.Size = New System.Drawing.Size(273, 147)
        Me.cboCategoriasArt.Style = Style8
        Me.cboCategoriasArt.TabIndex = 72
        Me.cboCategoriasArt.TabStop = False
        Me.cboCategoriasArt.ValueMember = "IdCategoriaPresupuestal"
        Me.cboCategoriasArt.Visible = False
        Me.cboCategoriasArt.PropBag = resources.GetString("cboCategoriasArt.PropBag")
        '
        'cboUnidades
        '
        Me.cboUnidades.AllowColMove = True
        Me.cboUnidades.AllowColSelect = True
        Me.cboUnidades.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboUnidades.AlternatingRows = True
        Me.cboUnidades.CaptionStyle = Style9
        Me.cboUnidades.ColumnCaptionHeight = 17
        Me.cboUnidades.ColumnFooterHeight = 17
        Me.cboUnidades.DataSource = Me.bsUnidades
        Me.cboUnidades.DisplayMember = "IdUnidadMedida"
        Me.cboUnidades.EvenRowStyle = Style10
        Me.cboUnidades.ExtendRightColumn = True
        Me.cboUnidades.FetchRowStyles = False
        Me.cboUnidades.FooterStyle = Style11
        Me.cboUnidades.HeadingStyle = Style12
        Me.cboUnidades.HighLightRowStyle = Style13
        Me.cboUnidades.Images.Add(CType(resources.GetObject("cboUnidades.Images"), System.Drawing.Image))
        Me.cboUnidades.Location = New System.Drawing.Point(89, 24)
        Me.cboUnidades.Name = "cboUnidades"
        Me.cboUnidades.OddRowStyle = Style14
        Me.cboUnidades.RecordSelectorStyle = Style15
        Me.cboUnidades.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboUnidades.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboUnidades.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboUnidades.ScrollTips = False
        Me.cboUnidades.Size = New System.Drawing.Size(264, 147)
        Me.cboUnidades.Style = Style16
        Me.cboUnidades.TabIndex = 70
        Me.cboUnidades.TabStop = False
        Me.cboUnidades.Text = "C1TrueDBDropdown1"
        Me.cboUnidades.ValueMember = "IdUnidadMedida"
        Me.cboUnidades.Visible = False
        Me.cboUnidades.PropBag = resources.GetString("cboUnidades.PropBag")
        '
        'grdArticulos
        '
        Me.grdArticulos.AllowAddNew = True
        Me.grdArticulos.AllowDelete = True
        Me.grdArticulos.CellTips = C1.Win.C1TrueDBGrid.CellTipEnum.Anchored
        Me.grdArticulos.DataSource = Me.bsArticulos
        Me.grdArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdArticulos.Images.Add(CType(resources.GetObject("grdArticulos.Images"), System.Drawing.Image))
        Me.grdArticulos.Images.Add(CType(resources.GetObject("grdArticulos.Images1"), System.Drawing.Image))
        Me.grdArticulos.Images.Add(CType(resources.GetObject("grdArticulos.Images2"), System.Drawing.Image))
        Me.grdArticulos.Images.Add(CType(resources.GetObject("grdArticulos.Images3"), System.Drawing.Image))
        Me.grdArticulos.Location = New System.Drawing.Point(0, 0)
        Me.grdArticulos.Name = "grdArticulos"
        Me.grdArticulos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdArticulos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdArticulos.PreviewInfo.ZoomFactor = 75.0R
        Me.grdArticulos.PrintInfo.PageSettings = CType(resources.GetObject("grdArticulos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdArticulos.Size = New System.Drawing.Size(791, 168)
        Me.grdArticulos.TabIndex = 71
        Me.grdArticulos.Text = "AzTrueDBGrid1"
        Me.grdArticulos.PropBag = resources.GetString("grdArticulos.PropBag")
        '
        'cboCategoriasServ
        '
        Me.cboCategoriasServ.AllowColMove = True
        Me.cboCategoriasServ.AllowColSelect = True
        Me.cboCategoriasServ.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboCategoriasServ.AlternatingRows = False
        Me.cboCategoriasServ.CaptionStyle = Style17
        Me.cboCategoriasServ.ColumnCaptionHeight = 17
        Me.cboCategoriasServ.ColumnFooterHeight = 17
        Me.cboCategoriasServ.DataSource = Me.bsCategoriasServ
        Me.cboCategoriasServ.DisplayMember = "Nombre"
        Me.cboCategoriasServ.EvenRowStyle = Style18
        Me.cboCategoriasServ.ExtendRightColumn = True
        Me.cboCategoriasServ.FetchRowStyles = False
        Me.cboCategoriasServ.FooterStyle = Style19
        Me.cboCategoriasServ.HeadingStyle = Style20
        Me.cboCategoriasServ.HighLightRowStyle = Style21
        Me.cboCategoriasServ.Images.Add(CType(resources.GetObject("cboCategoriasServ.Images"), System.Drawing.Image))
        Me.cboCategoriasServ.Location = New System.Drawing.Point(411, 54)
        Me.cboCategoriasServ.Name = "cboCategoriasServ"
        Me.cboCategoriasServ.OddRowStyle = Style22
        Me.cboCategoriasServ.RecordSelectorStyle = Style23
        Me.cboCategoriasServ.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCategoriasServ.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboCategoriasServ.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCategoriasServ.ScrollTips = False
        Me.cboCategoriasServ.Size = New System.Drawing.Size(273, 147)
        Me.cboCategoriasServ.Style = Style24
        Me.cboCategoriasServ.TabIndex = 73
        Me.cboCategoriasServ.TabStop = False
        Me.cboCategoriasServ.Text = "C1TrueDBDropdown1"
        Me.cboCategoriasServ.ValueMember = "IdCategoriaPresupuestal"
        Me.cboCategoriasServ.Visible = False
        Me.cboCategoriasServ.PropBag = resources.GetString("cboCategoriasServ.PropBag")
        '
        'grdServicios
        '
        Me.grdServicios.AllowAddNew = True
        Me.grdServicios.AllowDelete = True
        Me.grdServicios.CellTips = C1.Win.C1TrueDBGrid.CellTipEnum.Anchored
        Me.grdServicios.DataSource = Me.bsServicios
        Me.grdServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdServicios.Images.Add(CType(resources.GetObject("grdServicios.Images"), System.Drawing.Image))
        Me.grdServicios.Images.Add(CType(resources.GetObject("grdServicios.Images1"), System.Drawing.Image))
        Me.grdServicios.Images.Add(CType(resources.GetObject("grdServicios.Images2"), System.Drawing.Image))
        Me.grdServicios.Images.Add(CType(resources.GetObject("grdServicios.Images3"), System.Drawing.Image))
        Me.grdServicios.Location = New System.Drawing.Point(0, 0)
        Me.grdServicios.Name = "grdServicios"
        Me.grdServicios.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdServicios.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdServicios.PreviewInfo.ZoomFactor = 75.0R
        Me.grdServicios.PrintInfo.PageSettings = CType(resources.GetObject("grdServicios.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdServicios.Size = New System.Drawing.Size(791, 168)
        Me.grdServicios.TabIndex = 3
        Me.grdServicios.Text = "AzTrueDBGrid1"
        Me.grdServicios.PropBag = resources.GetString("grdServicios.PropBag")
        '
        'imlPartidas
        '
        Me.imlPartidas.ImageStream = CType(resources.GetObject("imlPartidas.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlPartidas.TransparentColor = System.Drawing.Color.Transparent
        Me.imlPartidas.Images.SetKeyName(0, "Articulos")
        Me.imlPartidas.Images.SetKeyName(1, "Servicios")
        '
        'tabHeader
        '
        Me.tabHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabHeader.Controls.Add(Me.pagGeneral)
        Me.tabHeader.Location = New System.Drawing.Point(0, 31)
        Me.tabHeader.Name = "tabHeader"
        Me.tabHeader.Size = New System.Drawing.Size(795, 141)
        Me.tabHeader.TabIndex = 0
        Me.tabHeader.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabHeader.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabHeader.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagGeneral
        '
        Me.pagGeneral.Controls.Add(Me.cboTipoRequisicion)
        Me.pagGeneral.Controls.Add(Me.lblRequisicionTipo)
        Me.pagGeneral.Controls.Add(Me.cboCentrosRecep)
        Me.pagGeneral.Controls.Add(Me.lblPresupuesto)
        Me.pagGeneral.Controls.Add(Me.cboDepartamento)
        Me.pagGeneral.Controls.Add(Me.lblCentroRecepcion)
        Me.pagGeneral.Controls.Add(Me.cboPresupuesto)
        Me.pagGeneral.Controls.Add(Me.lblDepartamento)
        Me.pagGeneral.Location = New System.Drawing.Point(1, 24)
        Me.pagGeneral.Name = "pagGeneral"
        Me.pagGeneral.Size = New System.Drawing.Size(793, 116)
        Me.pagGeneral.TabIndex = 0
        Me.pagGeneral.Text = "General"
        '
        'tabPartidas
        '
        Me.tabPartidas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabPartidas.Controls.Add(Me.pagArticulos)
        Me.tabPartidas.Controls.Add(Me.pagServicios)
        Me.tabPartidas.ImageList = Me.imlPartidas
        Me.tabPartidas.Location = New System.Drawing.Point(1, 177)
        Me.tabPartidas.Name = "tabPartidas"
        Me.tabPartidas.SelectedIndex = 1
        Me.tabPartidas.Size = New System.Drawing.Size(793, 210)
        Me.tabPartidas.TabIndex = 71
        Me.tabPartidas.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabPartidas.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabPartidas.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagArticulos
        '
        Me.pagArticulos.Controls.Add(Me.cboCategoriasArt)
        Me.pagArticulos.Controls.Add(Me.cboUnidades)
        Me.pagArticulos.Controls.Add(Me.grdArticulos)
        Me.pagArticulos.ImageIndex = 0
        Me.pagArticulos.Location = New System.Drawing.Point(1, 41)
        Me.pagArticulos.Name = "pagArticulos"
        Me.pagArticulos.Size = New System.Drawing.Size(791, 168)
        Me.pagArticulos.TabIndex = 0
        Me.pagArticulos.Text = "Artículos"
        '
        'pagServicios
        '
        Me.pagServicios.Controls.Add(Me.cboCategoriasServ)
        Me.pagServicios.Controls.Add(Me.grdServicios)
        Me.pagServicios.ImageIndex = 1
        Me.pagServicios.Location = New System.Drawing.Point(1, 41)
        Me.pagServicios.Name = "pagServicios"
        Me.pagServicios.Size = New System.Drawing.Size(791, 168)
        Me.pagServicios.TabIndex = 1
        Me.pagServicios.Text = "Servicios"
        '
        'tlbMenu
        '
        Me.tlbMenu.AccessibleName = "Tool Bar"
        Me.tlbMenu.AutoSize = False
        Me.tlbMenu.CommandHolder = Me.C1CommandHolder1
        Me.tlbMenu.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.btnGuardar, Me.btnCancelar})
        Me.tlbMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlbMenu.MinButtonSize = 32
        Me.tlbMenu.Movable = False
        Me.tlbMenu.Name = "tlbMenu"
        Me.tlbMenu.Size = New System.Drawing.Size(795, 34)
        Me.tlbMenu.Text = "AzToolBar1"
        Me.tlbMenu.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tlbMenu.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'btnGuardar
        '
        Me.btnGuardar.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnGuardar.Command = Me.cmdGuardar
        '
        'btnCancelar
        '
        Me.btnCancelar.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnCancelar.Command = Me.cmdCancelar
        Me.btnCancelar.SortOrder = 1
        '
        'CapturaRequisicionesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 388)
        Me.ControlBox = False
        Me.Controls.Add(Me.tlbMenu)
        Me.Controls.Add(Me.tabPartidas)
        Me.Controls.Add(Me.tabHeader)
        Me.Name = "CapturaRequisicionesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Captura de requisiciones"
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCategoriasArt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCategoriasArt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCategoriasServ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCategoriasServ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabHeader.ResumeLayout(False)
        Me.pagGeneral.ResumeLayout(False)
        Me.pagGeneral.PerformLayout()
        CType(Me.tabPartidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPartidas.ResumeLayout(False)
        Me.pagArticulos.ResumeLayout(False)
        Me.pagServicios.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents cmdGuardar As C1.Win.C1Command.C1Command
    Friend WithEvents cmdCancelar As C1.Win.C1Command.C1Command
    Friend WithEvents bsArticulos As System.Windows.Forms.BindingSource
    Friend WithEvents imlPartidas As System.Windows.Forms.ImageList
    Friend WithEvents cboTipoRequisicion As Azteca.Windows.Compras.RequisicionesTiposComboBox
    Friend WithEvents cboCentrosRecep As Azteca.Windows.Compras.CentrosRecepcionComboBox
    Friend WithEvents lblRequisicionTipo As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCentroRecepcion As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblDepartamento As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboPresupuesto As Azteca.Windows.Compras.PresupuestoComboBox
    Friend WithEvents cboDepartamento As Azteca.Windows.Compras.DepartamentoComboBox
    Friend WithEvents lblPresupuesto As Azteca.Windows.Controls.CILabel
    Friend WithEvents bsServicios As System.Windows.Forms.BindingSource
    Friend WithEvents bsUnidades As System.Windows.Forms.BindingSource
    Friend WithEvents cboUnidades As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents grdArticulos As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents cboCategoriasArt As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents bsCategoriasArt As System.Windows.Forms.BindingSource
    Friend WithEvents grdServicios As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents cboCategoriasServ As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents bsCategoriasServ As System.Windows.Forms.BindingSource
    Friend WithEvents tabHeader As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagGeneral As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents tabPartidas As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagArticulos As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagServicios As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents tlbMenu As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents btnGuardar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents btnCancelar As C1.Win.C1Command.C1CommandLink
End Class
