<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfiguracionEmpresaForm
    Inherits Azteca.Windows.Forms.BaseForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfiguracionEmpresaForm))
        Dim Style25 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style26 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style27 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style28 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style29 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style30 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style31 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style32 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style33 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style34 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style35 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style36 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style37 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style38 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style39 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style40 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style41 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style42 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style43 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style44 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style45 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style46 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style47 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style48 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Me.tabConfiguracion = New Azteca.Windows.Controls.CITab()
        Me.pagCentralCompras = New System.Windows.Forms.TabPage()
        Me.gbxCentrosCompra = New Azteca.Windows.Controls.CIGroupBox()
        Me.grdCentrales = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsCentrales = New System.Windows.Forms.BindingSource(Me.components)
        Me.dropOperador = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.bsRemitentes = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbCentralCompras = New Azteca.Windows.Controls.CIToolBar()
        Me.btnCentralComprasAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnCentralComprasRefresh = New System.Windows.Forms.ToolStripButton()
        Me.dropRemitentes = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.pagCentrosRecepcion = New System.Windows.Forms.TabPage()
        Me.gbxCentrosRecepcion = New Azteca.Windows.Controls.CIGroupBox()
        Me.grdCentrosRecepcion = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsCentrosRecepcion = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbCentrosRecepcion = New Azteca.Windows.Controls.CIToolBar()
        Me.btnCentrosRecepcionAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnCentrosRecepcionRefresh = New System.Windows.Forms.ToolStripButton()
        Me.dropAlmacenes = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.bsAlmacenes = New System.Windows.Forms.BindingSource(Me.components)
        Me.CiToolBar2 = New Azteca.Windows.Controls.CIToolBar()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.pagCategorias = New System.Windows.Forms.TabPage()
        Me.CiGroupBox1 = New Azteca.Windows.Controls.CIGroupBox()
        Me.grdCategoriasPresupuestales = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsCategoriaPresupuestal = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbCategoriaPresupuestal = New Azteca.Windows.Controls.CIToolBar()
        Me.btnCatPresupNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnArticulosCat = New System.Windows.Forms.ToolStripButton()
        Me.btnServiciosCat = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCatPresupRefresh = New System.Windows.Forms.ToolStripButton()
        Me.pagTiposGastos = New System.Windows.Forms.TabPage()
        Me.CiGroupBox2 = New Azteca.Windows.Controls.CIGroupBox()
        Me.grdGastosTipos = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsGastosTipos = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbGastosTipos = New Azteca.Windows.Controls.CIToolBar()
        Me.btnGastosAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnGastosRefresh = New System.Windows.Forms.ToolStripButton()
        Me.pagDepartamentos = New System.Windows.Forms.TabPage()
        Me.gbxDepartamentosP = New Azteca.Windows.Controls.CIGroupBox()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.cboCaja = New Azteca.Windows.Tesoreria.CajasComboBox()
        Me.tabDepartamento = New Azteca.Windows.Controls.CITab()
        Me.pagGastosCategoriasPresup = New System.Windows.Forms.TabPage()
        Me.gbxDeptosCategorias = New Azteca.Windows.Controls.CIGroupBox()
        Me.grdDepartamentoCategorias = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsDepartamentoCategorias = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbDeptosCategoria = New Azteca.Windows.Controls.CIToolBar()
        Me.btnDeptosCategoriaAdd = New System.Windows.Forms.ToolStripButton()
        Me.pagGastosConceptos = New System.Windows.Forms.TabPage()
        Me.gbxDeptoConceptos = New Azteca.Windows.Controls.CIGroupBox()
        Me.grdDepartamentoConceptos = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsDepartamentoConceptos = New System.Windows.Forms.BindingSource(Me.components)
        Me.CiToolBar1 = New Azteca.Windows.Controls.CIToolBar()
        Me.btnDeptoGastoConceptoAdd = New System.Windows.Forms.ToolStripButton()
        Me.iLstDepartamento = New System.Windows.Forms.ImageList(Me.components)
        Me.cboCentralComprasDepto = New Azteca.Windows.Compras.CentralComprasComboBox()
        Me.optCategorizado = New Azteca.Windows.Controls.CIRadioButton()
        Me.optGlobal = New Azteca.Windows.Controls.CIRadioButton()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.optNoUtilizar = New Azteca.Windows.Controls.CIRadioButton()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.lblCuenta = New Azteca.Windows.Controls.CILabel()
        Me.selCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.trvwDepartamentos = New Azteca.Windows.Controls.HierarchyViewer()
        Me.imlDeptos = New System.Windows.Forms.ImageList(Me.components)
        Me.tbDepartamentos = New Azteca.Windows.Controls.CIToolBar()
        Me.btnDeptosSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDeptosAccesos = New System.Windows.Forms.ToolStripButton()
        Me.btnDeptosAsignarCtrosRecibo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDeptosRefresh = New System.Windows.Forms.ToolStripButton()
        Me.iLstTabs = New System.Windows.Forms.ImageList(Me.components)
        Me.ColorWithAlpha1 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha2 = New Azteca.Windows.ColorWithAlpha()
        Me.bsOperadores = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlTitulo = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.lblConfiguracion = New Azteca.Windows.Controls.CILabel()
        Me.tabConfiguracion.SuspendLayout()
        Me.pagCentralCompras.SuspendLayout()
        Me.gbxCentrosCompra.SuspendLayout()
        CType(Me.grdCentrales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCentrales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dropOperador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsRemitentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbCentralCompras.SuspendLayout()
        CType(Me.dropRemitentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagCentrosRecepcion.SuspendLayout()
        Me.gbxCentrosRecepcion.SuspendLayout()
        CType(Me.grdCentrosRecepcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCentrosRecepcion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbCentrosRecepcion.SuspendLayout()
        CType(Me.dropAlmacenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAlmacenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CiToolBar2.SuspendLayout()
        Me.pagCategorias.SuspendLayout()
        Me.CiGroupBox1.SuspendLayout()
        CType(Me.grdCategoriasPresupuestales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCategoriaPresupuestal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbCategoriaPresupuestal.SuspendLayout()
        Me.pagTiposGastos.SuspendLayout()
        Me.CiGroupBox2.SuspendLayout()
        CType(Me.grdGastosTipos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsGastosTipos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbGastosTipos.SuspendLayout()
        Me.pagDepartamentos.SuspendLayout()
        Me.gbxDepartamentosP.SuspendLayout()
        Me.tabDepartamento.SuspendLayout()
        Me.pagGastosCategoriasPresup.SuspendLayout()
        Me.gbxDeptosCategorias.SuspendLayout()
        CType(Me.grdDepartamentoCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDepartamentoCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbDeptosCategoria.SuspendLayout()
        Me.pagGastosConceptos.SuspendLayout()
        Me.gbxDeptoConceptos.SuspendLayout()
        CType(Me.grdDepartamentoConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDepartamentoConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CiToolBar1.SuspendLayout()
        Me.tbDepartamentos.SuspendLayout()
        CType(Me.bsOperadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabConfiguracion
        '
        Me.tabConfiguracion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabConfiguracion.Controls.Add(Me.pagCentralCompras)
        Me.tabConfiguracion.Controls.Add(Me.pagCentrosRecepcion)
        Me.tabConfiguracion.Controls.Add(Me.pagCategorias)
        Me.tabConfiguracion.Controls.Add(Me.pagTiposGastos)
        Me.tabConfiguracion.Controls.Add(Me.pagDepartamentos)
        Me.tabConfiguracion.ImageList = Me.iLstTabs
        Me.tabConfiguracion.Location = New System.Drawing.Point(12, 59)
        Me.tabConfiguracion.Name = "tabConfiguracion"
        Me.tabConfiguracion.SelectedIndex = 0
        Me.tabConfiguracion.Size = New System.Drawing.Size(1102, 453)
        Me.tabConfiguracion.TabIndex = 0
        '
        'pagCentralCompras
        '
        Me.pagCentralCompras.Controls.Add(Me.gbxCentrosCompra)
        Me.pagCentralCompras.ImageKey = "Centrales"
        Me.pagCentralCompras.Location = New System.Drawing.Point(4, 39)
        Me.pagCentralCompras.Name = "pagCentralCompras"
        Me.pagCentralCompras.Size = New System.Drawing.Size(1094, 410)
        Me.pagCentralCompras.TabIndex = 3
        Me.pagCentralCompras.Text = "Central de Compras"
        Me.pagCentralCompras.UseVisualStyleBackColor = True
        '
        'gbxCentrosCompra
        '
        Me.gbxCentrosCompra.Controls.Add(Me.grdCentrales)
        Me.gbxCentrosCompra.Controls.Add(Me.dropOperador)
        Me.gbxCentrosCompra.Controls.Add(Me.tbCentralCompras)
        Me.gbxCentrosCompra.Controls.Add(Me.dropRemitentes)
        Me.gbxCentrosCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxCentrosCompra.Location = New System.Drawing.Point(0, 0)
        Me.gbxCentrosCompra.Name = "gbxCentrosCompra"
        Me.gbxCentrosCompra.Size = New System.Drawing.Size(1094, 410)
        Me.gbxCentrosCompra.TabIndex = 45
        Me.gbxCentrosCompra.TabStop = False
        '
        'grdCentrales
        '
        Me.grdCentrales.AlternatingRows = True
        Me.grdCentrales.DataSource = Me.bsCentrales
        Me.grdCentrales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdCentrales.Enabled = False
        Me.grdCentrales.IDCatalogField = "IdCentral"
        Me.grdCentrales.Images.Add(CType(resources.GetObject("grdCentrales.Images"), System.Drawing.Image))
        Me.grdCentrales.Images.Add(CType(resources.GetObject("grdCentrales.Images1"), System.Drawing.Image))
        Me.grdCentrales.Location = New System.Drawing.Point(3, 55)
        Me.grdCentrales.Name = "grdCentrales"
        Me.grdCentrales.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdCentrales.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdCentrales.PreviewInfo.ZoomFactor = 75.0R
        Me.grdCentrales.PrintInfo.PageSettings = CType(resources.GetObject("grdCentrales.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdCentrales.RowHeight = 16
        Me.grdCentrales.Size = New System.Drawing.Size(1088, 352)
        Me.grdCentrales.TabIndex = 41
        Me.grdCentrales.Text = "AzTrueDBGrid1"
        Me.grdCentrales.PropBag = resources.GetString("grdCentrales.PropBag")
        '
        'dropOperador
        '
        Me.dropOperador.AllowColMove = True
        Me.dropOperador.AllowColSelect = True
        Me.dropOperador.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.dropOperador.AlternatingRows = False
        Me.dropOperador.CaptionStyle = Style25
        Me.dropOperador.ColumnCaptionHeight = 17
        Me.dropOperador.ColumnFooterHeight = 17
        Me.dropOperador.DataSource = Me.bsRemitentes
        Me.dropOperador.DisplayMember = "Nombre"
        Me.dropOperador.EvenRowStyle = Style26
        Me.dropOperador.ExtendRightColumn = True
        Me.dropOperador.FetchRowStyles = False
        Me.dropOperador.FooterStyle = Style27
        Me.dropOperador.HeadingStyle = Style28
        Me.dropOperador.HighLightRowStyle = Style29
        Me.dropOperador.Images.Add(CType(resources.GetObject("dropOperador.Images"), System.Drawing.Image))
        Me.dropOperador.Location = New System.Drawing.Point(555, 130)
        Me.dropOperador.Name = "dropOperador"
        Me.dropOperador.OddRowStyle = Style30
        Me.dropOperador.RecordSelectorStyle = Style31
        Me.dropOperador.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.dropOperador.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.dropOperador.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.dropOperador.ScrollTips = False
        Me.dropOperador.Size = New System.Drawing.Size(232, 101)
        Me.dropOperador.Style = Style32
        Me.dropOperador.TabIndex = 44
        Me.dropOperador.TabStop = False
        Me.dropOperador.Text = "C1TrueDBDropdown1"
        Me.dropOperador.ValueMember = "IdOperador"
        Me.dropOperador.ValueTranslate = True
        Me.dropOperador.Visible = False
        Me.dropOperador.PropBag = resources.GetString("dropOperador.PropBag")
        '
        'tbCentralCompras
        '
        Me.tbCentralCompras.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbCentralCompras.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCentralComprasAdd, Me.btnCentralComprasRefresh})
        Me.tbCentralCompras.Location = New System.Drawing.Point(3, 16)
        Me.tbCentralCompras.Name = "tbCentralCompras"
        Me.tbCentralCompras.Size = New System.Drawing.Size(1088, 39)
        Me.tbCentralCompras.TabIndex = 42
        Me.tbCentralCompras.Text = "CiToolBar4"
        '
        'btnCentralComprasAdd
        '
        Me.btnCentralComprasAdd.Enabled = False
        Me.btnCentralComprasAdd.Image = CType(resources.GetObject("btnCentralComprasAdd.Image"), System.Drawing.Image)
        Me.btnCentralComprasAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCentralComprasAdd.Name = "btnCentralComprasAdd"
        Me.btnCentralComprasAdd.Size = New System.Drawing.Size(185, 36)
        Me.btnCentralComprasAdd.Text = "Nueva Central de Compras"
        '
        'btnCentralComprasRefresh
        '
        Me.btnCentralComprasRefresh.Image = CType(resources.GetObject("btnCentralComprasRefresh.Image"), System.Drawing.Image)
        Me.btnCentralComprasRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCentralComprasRefresh.Name = "btnCentralComprasRefresh"
        Me.btnCentralComprasRefresh.Size = New System.Drawing.Size(95, 36)
        Me.btnCentralComprasRefresh.Text = "Actualizar"
        '
        'dropRemitentes
        '
        Me.dropRemitentes.AllowColMove = True
        Me.dropRemitentes.AllowColSelect = True
        Me.dropRemitentes.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.dropRemitentes.AlternatingRows = False
        Me.dropRemitentes.CaptionStyle = Style33
        Me.dropRemitentes.ColumnCaptionHeight = 17
        Me.dropRemitentes.ColumnFooterHeight = 17
        Me.dropRemitentes.DataSource = Me.bsRemitentes
        Me.dropRemitentes.DisplayMember = "Nombre"
        Me.dropRemitentes.EvenRowStyle = Style34
        Me.dropRemitentes.ExtendRightColumn = True
        Me.dropRemitentes.FetchRowStyles = False
        Me.dropRemitentes.FooterStyle = Style35
        Me.dropRemitentes.HeadingStyle = Style36
        Me.dropRemitentes.HighLightRowStyle = Style37
        Me.dropRemitentes.Images.Add(CType(resources.GetObject("dropRemitentes.Images"), System.Drawing.Image))
        Me.dropRemitentes.Location = New System.Drawing.Point(227, 130)
        Me.dropRemitentes.Name = "dropRemitentes"
        Me.dropRemitentes.OddRowStyle = Style38
        Me.dropRemitentes.RecordSelectorStyle = Style39
        Me.dropRemitentes.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.dropRemitentes.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.dropRemitentes.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.dropRemitentes.ScrollTips = False
        Me.dropRemitentes.Size = New System.Drawing.Size(359, 101)
        Me.dropRemitentes.Style = Style40
        Me.dropRemitentes.TabIndex = 43
        Me.dropRemitentes.TabStop = False
        Me.dropRemitentes.Text = "C1TrueDBDropdown1"
        Me.dropRemitentes.ValueMember = "IdRemitenteMail"
        Me.dropRemitentes.ValueTranslate = True
        Me.dropRemitentes.Visible = False
        Me.dropRemitentes.PropBag = resources.GetString("dropRemitentes.PropBag")
        '
        'pagCentrosRecepcion
        '
        Me.pagCentrosRecepcion.Controls.Add(Me.gbxCentrosRecepcion)
        Me.pagCentrosRecepcion.Controls.Add(Me.dropAlmacenes)
        Me.pagCentrosRecepcion.Controls.Add(Me.CiToolBar2)
        Me.pagCentrosRecepcion.ImageKey = "CentrosRec"
        Me.pagCentrosRecepcion.Location = New System.Drawing.Point(4, 39)
        Me.pagCentrosRecepcion.Name = "pagCentrosRecepcion"
        Me.pagCentrosRecepcion.Size = New System.Drawing.Size(1094, 457)
        Me.pagCentrosRecepcion.TabIndex = 2
        Me.pagCentrosRecepcion.Text = "Centros de Recepción"
        Me.pagCentrosRecepcion.UseVisualStyleBackColor = True
        '
        'gbxCentrosRecepcion
        '
        Me.gbxCentrosRecepcion.Controls.Add(Me.grdCentrosRecepcion)
        Me.gbxCentrosRecepcion.Controls.Add(Me.tbCentrosRecepcion)
        Me.gbxCentrosRecepcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxCentrosRecepcion.Location = New System.Drawing.Point(0, 0)
        Me.gbxCentrosRecepcion.Name = "gbxCentrosRecepcion"
        Me.gbxCentrosRecepcion.Size = New System.Drawing.Size(1094, 457)
        Me.gbxCentrosRecepcion.TabIndex = 46
        Me.gbxCentrosRecepcion.TabStop = False
        '
        'grdCentrosRecepcion
        '
        Me.grdCentrosRecepcion.AlternatingRows = True
        Me.grdCentrosRecepcion.DataSource = Me.bsCentrosRecepcion
        Me.grdCentrosRecepcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdCentrosRecepcion.Enabled = False
        Me.grdCentrosRecepcion.IDCatalogField = "IdCentroRecepcion"
        Me.grdCentrosRecepcion.Images.Add(CType(resources.GetObject("grdCentrosRecepcion.Images"), System.Drawing.Image))
        Me.grdCentrosRecepcion.Images.Add(CType(resources.GetObject("grdCentrosRecepcion.Images1"), System.Drawing.Image))
        Me.grdCentrosRecepcion.Location = New System.Drawing.Point(3, 55)
        Me.grdCentrosRecepcion.Name = "grdCentrosRecepcion"
        Me.grdCentrosRecepcion.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdCentrosRecepcion.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdCentrosRecepcion.PreviewInfo.ZoomFactor = 75.0R
        Me.grdCentrosRecepcion.PrintInfo.PageSettings = CType(resources.GetObject("grdCentrosRecepcion.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdCentrosRecepcion.RowHeight = 17
        Me.grdCentrosRecepcion.Size = New System.Drawing.Size(1088, 399)
        Me.grdCentrosRecepcion.TabIndex = 39
        Me.grdCentrosRecepcion.Text = "AzTrueDBGrid1"
        Me.grdCentrosRecepcion.PropBag = resources.GetString("grdCentrosRecepcion.PropBag")
        '
        'tbCentrosRecepcion
        '
        Me.tbCentrosRecepcion.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbCentrosRecepcion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCentrosRecepcionAdd, Me.btnCentrosRecepcionRefresh})
        Me.tbCentrosRecepcion.Location = New System.Drawing.Point(3, 16)
        Me.tbCentrosRecepcion.Name = "tbCentrosRecepcion"
        Me.tbCentrosRecepcion.Size = New System.Drawing.Size(1088, 39)
        Me.tbCentrosRecepcion.TabIndex = 43
        Me.tbCentrosRecepcion.Text = "CiToolBar4"
        '
        'btnCentrosRecepcionAdd
        '
        Me.btnCentrosRecepcionAdd.Enabled = False
        Me.btnCentrosRecepcionAdd.Image = CType(resources.GetObject("btnCentrosRecepcionAdd.Image"), System.Drawing.Image)
        Me.btnCentrosRecepcionAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCentrosRecepcionAdd.Name = "btnCentrosRecepcionAdd"
        Me.btnCentrosRecepcionAdd.Size = New System.Drawing.Size(191, 36)
        Me.btnCentrosRecepcionAdd.Text = "Nuevo Centro de Recepción"
        '
        'btnCentrosRecepcionRefresh
        '
        Me.btnCentrosRecepcionRefresh.Image = CType(resources.GetObject("btnCentrosRecepcionRefresh.Image"), System.Drawing.Image)
        Me.btnCentrosRecepcionRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCentrosRecepcionRefresh.Name = "btnCentrosRecepcionRefresh"
        Me.btnCentrosRecepcionRefresh.Size = New System.Drawing.Size(95, 36)
        Me.btnCentrosRecepcionRefresh.Text = "Actualizar"
        '
        'dropAlmacenes
        '
        Me.dropAlmacenes.AllowColMove = True
        Me.dropAlmacenes.AllowColSelect = True
        Me.dropAlmacenes.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.dropAlmacenes.AlternatingRows = False
        Me.dropAlmacenes.CaptionStyle = Style41
        Me.dropAlmacenes.ColumnCaptionHeight = 17
        Me.dropAlmacenes.ColumnFooterHeight = 17
        Me.dropAlmacenes.DataSource = Me.bsAlmacenes
        Me.dropAlmacenes.DisplayMember = "Nombre"
        Me.dropAlmacenes.EvenRowStyle = Style42
        Me.dropAlmacenes.ExtendRightColumn = True
        Me.dropAlmacenes.FetchRowStyles = False
        Me.dropAlmacenes.FooterStyle = Style43
        Me.dropAlmacenes.HeadingStyle = Style44
        Me.dropAlmacenes.HighLightRowStyle = Style45
        Me.dropAlmacenes.Images.Add(CType(resources.GetObject("dropAlmacenes.Images"), System.Drawing.Image))
        Me.dropAlmacenes.Location = New System.Drawing.Point(721, 157)
        Me.dropAlmacenes.Name = "dropAlmacenes"
        Me.dropAlmacenes.OddRowStyle = Style46
        Me.dropAlmacenes.RecordSelectorStyle = Style47
        Me.dropAlmacenes.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.dropAlmacenes.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.dropAlmacenes.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.dropAlmacenes.ScrollTips = False
        Me.dropAlmacenes.Size = New System.Drawing.Size(232, 101)
        Me.dropAlmacenes.Style = Style48
        Me.dropAlmacenes.TabIndex = 45
        Me.dropAlmacenes.TabStop = False
        Me.dropAlmacenes.Text = "C1TrueDBDropdown1"
        Me.dropAlmacenes.ValueMember = "IdAlmacen"
        Me.dropAlmacenes.ValueTranslate = True
        Me.dropAlmacenes.Visible = False
        Me.dropAlmacenes.PropBag = resources.GetString("dropAlmacenes.PropBag")
        '
        'CiToolBar2
        '
        Me.CiToolBar2.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.CiToolBar2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.CiToolBar2.Location = New System.Drawing.Point(0, 0)
        Me.CiToolBar2.Name = "CiToolBar2"
        Me.CiToolBar2.Size = New System.Drawing.Size(1094, 39)
        Me.CiToolBar2.TabIndex = 38
        Me.CiToolBar2.Text = "CiToolBar2"
        Me.CiToolBar2.Visible = False
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton1.Text = "ToolStripButton2"
        '
        'pagCategorias
        '
        Me.pagCategorias.Controls.Add(Me.CiGroupBox1)
        Me.pagCategorias.ImageKey = "Categorias"
        Me.pagCategorias.Location = New System.Drawing.Point(4, 39)
        Me.pagCategorias.Name = "pagCategorias"
        Me.pagCategorias.Size = New System.Drawing.Size(1094, 457)
        Me.pagCategorias.TabIndex = 4
        Me.pagCategorias.Text = "Categorias Presupuestales"
        Me.pagCategorias.UseVisualStyleBackColor = True
        '
        'CiGroupBox1
        '
        Me.CiGroupBox1.Controls.Add(Me.grdCategoriasPresupuestales)
        Me.CiGroupBox1.Controls.Add(Me.tbCategoriaPresupuestal)
        Me.CiGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CiGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.CiGroupBox1.Name = "CiGroupBox1"
        Me.CiGroupBox1.Size = New System.Drawing.Size(1094, 457)
        Me.CiGroupBox1.TabIndex = 39
        Me.CiGroupBox1.TabStop = False
        '
        'grdCategoriasPresupuestales
        '
        Me.grdCategoriasPresupuestales.AlternatingRows = True
        Me.grdCategoriasPresupuestales.DataSource = Me.bsCategoriaPresupuestal
        Me.grdCategoriasPresupuestales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdCategoriasPresupuestales.Enabled = False
        Me.grdCategoriasPresupuestales.IDCatalogField = "IdCategoriaPresupuestal"
        Me.grdCategoriasPresupuestales.Images.Add(CType(resources.GetObject("grdCategoriasPresupuestales.Images"), System.Drawing.Image))
        Me.grdCategoriasPresupuestales.Images.Add(CType(resources.GetObject("grdCategoriasPresupuestales.Images1"), System.Drawing.Image))
        Me.grdCategoriasPresupuestales.Location = New System.Drawing.Point(3, 55)
        Me.grdCategoriasPresupuestales.Name = "grdCategoriasPresupuestales"
        Me.grdCategoriasPresupuestales.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdCategoriasPresupuestales.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdCategoriasPresupuestales.PreviewInfo.ZoomFactor = 75.0R
        Me.grdCategoriasPresupuestales.PrintInfo.PageSettings = CType(resources.GetObject("grdCategoriasPresupuestales.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdCategoriasPresupuestales.RowHeight = 17
        Me.grdCategoriasPresupuestales.Size = New System.Drawing.Size(1088, 399)
        Me.grdCategoriasPresupuestales.TabIndex = 45
        Me.grdCategoriasPresupuestales.Text = "AzTrueDBGrid1"
        Me.grdCategoriasPresupuestales.PropBag = resources.GetString("grdCategoriasPresupuestales.PropBag")
        '
        'tbCategoriaPresupuestal
        '
        Me.tbCategoriaPresupuestal.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbCategoriaPresupuestal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCatPresupNew, Me.ToolStripSeparator4, Me.btnArticulosCat, Me.btnServiciosCat, Me.ToolStripSeparator3, Me.btnCatPresupRefresh})
        Me.tbCategoriaPresupuestal.Location = New System.Drawing.Point(3, 16)
        Me.tbCategoriaPresupuestal.Name = "tbCategoriaPresupuestal"
        Me.tbCategoriaPresupuestal.Size = New System.Drawing.Size(1088, 39)
        Me.tbCategoriaPresupuestal.TabIndex = 44
        Me.tbCategoriaPresupuestal.Text = "CiToolBar4"
        '
        'btnCatPresupNew
        '
        Me.btnCatPresupNew.Enabled = False
        Me.btnCatPresupNew.Image = CType(resources.GetObject("btnCatPresupNew.Image"), System.Drawing.Image)
        Me.btnCatPresupNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCatPresupNew.Name = "btnCatPresupNew"
        Me.btnCatPresupNew.Size = New System.Drawing.Size(201, 36)
        Me.btnCatPresupNew.Text = "Nueva Categoria Presupuestal"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'btnArticulosCat
        '
        Me.btnArticulosCat.Image = Global.Azteca.Windows.Compras.My.Resources.Resources.Articulo_32
        Me.btnArticulosCat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnArticulosCat.Name = "btnArticulosCat"
        Me.btnArticulosCat.Size = New System.Drawing.Size(90, 36)
        Me.btnArticulosCat.Text = "Artículos"
        '
        'btnServiciosCat
        '
        Me.btnServiciosCat.Image = CType(resources.GetObject("btnServiciosCat.Image"), System.Drawing.Image)
        Me.btnServiciosCat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnServiciosCat.Name = "btnServiciosCat"
        Me.btnServiciosCat.Size = New System.Drawing.Size(89, 36)
        Me.btnServiciosCat.Text = "Servicios"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'btnCatPresupRefresh
        '
        Me.btnCatPresupRefresh.Image = CType(resources.GetObject("btnCatPresupRefresh.Image"), System.Drawing.Image)
        Me.btnCatPresupRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCatPresupRefresh.Name = "btnCatPresupRefresh"
        Me.btnCatPresupRefresh.Size = New System.Drawing.Size(95, 36)
        Me.btnCatPresupRefresh.Text = "Actualizar"
        '
        'pagTiposGastos
        '
        Me.pagTiposGastos.Controls.Add(Me.CiGroupBox2)
        Me.pagTiposGastos.ImageKey = "ConceptosGastos"
        Me.pagTiposGastos.Location = New System.Drawing.Point(4, 39)
        Me.pagTiposGastos.Name = "pagTiposGastos"
        Me.pagTiposGastos.Size = New System.Drawing.Size(1094, 457)
        Me.pagTiposGastos.TabIndex = 5
        Me.pagTiposGastos.Text = "Conceptos de Gastos"
        Me.pagTiposGastos.UseVisualStyleBackColor = True
        '
        'CiGroupBox2
        '
        Me.CiGroupBox2.Controls.Add(Me.grdGastosTipos)
        Me.CiGroupBox2.Controls.Add(Me.tbGastosTipos)
        Me.CiGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CiGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.CiGroupBox2.Name = "CiGroupBox2"
        Me.CiGroupBox2.Size = New System.Drawing.Size(1094, 457)
        Me.CiGroupBox2.TabIndex = 47
        Me.CiGroupBox2.TabStop = False
        '
        'grdGastosTipos
        '
        Me.grdGastosTipos.AccessibleDescription = ""
        Me.grdGastosTipos.AlternatingRows = True
        Me.grdGastosTipos.DataSource = Me.bsGastosTipos
        Me.grdGastosTipos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdGastosTipos.Enabled = False
        Me.grdGastosTipos.IDCatalogField = "IdGastoConceptoTipo"
        Me.grdGastosTipos.Images.Add(CType(resources.GetObject("grdGastosTipos.Images"), System.Drawing.Image))
        Me.grdGastosTipos.Images.Add(CType(resources.GetObject("grdGastosTipos.Images1"), System.Drawing.Image))
        Me.grdGastosTipos.Location = New System.Drawing.Point(3, 55)
        Me.grdGastosTipos.Name = "grdGastosTipos"
        Me.grdGastosTipos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdGastosTipos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdGastosTipos.PreviewInfo.ZoomFactor = 75.0R
        Me.grdGastosTipos.PrintInfo.PageSettings = CType(resources.GetObject("grdGastosTipos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdGastosTipos.RowHeight = 17
        Me.grdGastosTipos.Size = New System.Drawing.Size(1088, 399)
        Me.grdGastosTipos.TabIndex = 39
        Me.grdGastosTipos.Text = "AzTrueDBGrid1"
        Me.grdGastosTipos.PropBag = resources.GetString("grdGastosTipos.PropBag")
        '
        'tbGastosTipos
        '
        Me.tbGastosTipos.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbGastosTipos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGastosAdd, Me.btnGastosRefresh})
        Me.tbGastosTipos.Location = New System.Drawing.Point(3, 16)
        Me.tbGastosTipos.Name = "tbGastosTipos"
        Me.tbGastosTipos.Size = New System.Drawing.Size(1088, 39)
        Me.tbGastosTipos.TabIndex = 43
        Me.tbGastosTipos.Text = "CiToolBar4"
        '
        'btnGastosAdd
        '
        Me.btnGastosAdd.Enabled = False
        Me.btnGastosAdd.Image = CType(resources.GetObject("btnGastosAdd.Image"), System.Drawing.Image)
        Me.btnGastosAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGastosAdd.Name = "btnGastosAdd"
        Me.btnGastosAdd.Size = New System.Drawing.Size(154, 36)
        Me.btnGastosAdd.Text = "Nuevo Tipo de Gasto"
        '
        'btnGastosRefresh
        '
        Me.btnGastosRefresh.Image = CType(resources.GetObject("btnGastosRefresh.Image"), System.Drawing.Image)
        Me.btnGastosRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGastosRefresh.Name = "btnGastosRefresh"
        Me.btnGastosRefresh.Size = New System.Drawing.Size(95, 36)
        Me.btnGastosRefresh.Text = "Actualizar"
        '
        'pagDepartamentos
        '
        Me.pagDepartamentos.Controls.Add(Me.gbxDepartamentosP)
        Me.pagDepartamentos.Controls.Add(Me.trvwDepartamentos)
        Me.pagDepartamentos.Controls.Add(Me.tbDepartamentos)
        Me.pagDepartamentos.ImageKey = "Departamentos"
        Me.pagDepartamentos.Location = New System.Drawing.Point(4, 39)
        Me.pagDepartamentos.Name = "pagDepartamentos"
        Me.pagDepartamentos.Padding = New System.Windows.Forms.Padding(3)
        Me.pagDepartamentos.Size = New System.Drawing.Size(1094, 457)
        Me.pagDepartamentos.TabIndex = 0
        Me.pagDepartamentos.Text = "Departamentos"
        Me.pagDepartamentos.UseVisualStyleBackColor = True
        '
        'gbxDepartamentosP
        '
        Me.gbxDepartamentosP.BackColor = System.Drawing.SystemColors.Menu
        Me.gbxDepartamentosP.Controls.Add(Me.CiLabel3)
        Me.gbxDepartamentosP.Controls.Add(Me.cboCaja)
        Me.gbxDepartamentosP.Controls.Add(Me.tabDepartamento)
        Me.gbxDepartamentosP.Controls.Add(Me.cboCentralComprasDepto)
        Me.gbxDepartamentosP.Controls.Add(Me.optCategorizado)
        Me.gbxDepartamentosP.Controls.Add(Me.optGlobal)
        Me.gbxDepartamentosP.Controls.Add(Me.CiLabel2)
        Me.gbxDepartamentosP.Controls.Add(Me.optNoUtilizar)
        Me.gbxDepartamentosP.Controls.Add(Me.CiLabel1)
        Me.gbxDepartamentosP.Controls.Add(Me.lblCuenta)
        Me.gbxDepartamentosP.Controls.Add(Me.selCuenta)
        Me.gbxDepartamentosP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxDepartamentosP.Location = New System.Drawing.Point(360, 42)
        Me.gbxDepartamentosP.Name = "gbxDepartamentosP"
        Me.gbxDepartamentosP.Size = New System.Drawing.Size(731, 412)
        Me.gbxDepartamentosP.TabIndex = 49
        Me.gbxDepartamentosP.TabStop = False
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(383, 44)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(153, 13)
        Me.CiLabel3.TabIndex = 58
        Me.CiLabel3.Text = "Reposición de Gastos en Caja:"
        '
        'cboCaja
        '
        Me.cboCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCaja.FormattingEnabled = True
        Me.cboCaja.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboCaja.ItemsTable = Nothing
        Me.cboCaja.Location = New System.Drawing.Point(542, 40)
        Me.cboCaja.Name = "cboCaja"
        Me.cboCaja.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboCaja.Size = New System.Drawing.Size(183, 21)
        Me.cboCaja.TabIndex = 57
        Me.cboCaja.UIName = Nothing
        '
        'tabDepartamento
        '
        Me.tabDepartamento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDepartamento.Controls.Add(Me.pagGastosCategoriasPresup)
        Me.tabDepartamento.Controls.Add(Me.pagGastosConceptos)
        Me.tabDepartamento.ImageList = Me.iLstDepartamento
        Me.tabDepartamento.Location = New System.Drawing.Point(13, 92)
        Me.tabDepartamento.Name = "tabDepartamento"
        Me.tabDepartamento.SelectedIndex = 0
        Me.tabDepartamento.Size = New System.Drawing.Size(712, 314)
        Me.tabDepartamento.TabIndex = 56
        '
        'pagGastosCategoriasPresup
        '
        Me.pagGastosCategoriasPresup.Controls.Add(Me.gbxDeptosCategorias)
        Me.pagGastosCategoriasPresup.ImageKey = "Categorias"
        Me.pagGastosCategoriasPresup.Location = New System.Drawing.Point(4, 31)
        Me.pagGastosCategoriasPresup.Name = "pagGastosCategoriasPresup"
        Me.pagGastosCategoriasPresup.Padding = New System.Windows.Forms.Padding(3)
        Me.pagGastosCategoriasPresup.Size = New System.Drawing.Size(704, 279)
        Me.pagGastosCategoriasPresup.TabIndex = 0
        Me.pagGastosCategoriasPresup.Text = "Categorias Presupuestales"
        Me.pagGastosCategoriasPresup.UseVisualStyleBackColor = True
        '
        'gbxDeptosCategorias
        '
        Me.gbxDeptosCategorias.Controls.Add(Me.grdDepartamentoCategorias)
        Me.gbxDeptosCategorias.Controls.Add(Me.tbDeptosCategoria)
        Me.gbxDeptosCategorias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxDeptosCategorias.Enabled = False
        Me.gbxDeptosCategorias.Location = New System.Drawing.Point(3, 3)
        Me.gbxDeptosCategorias.Name = "gbxDeptosCategorias"
        Me.gbxDeptosCategorias.Size = New System.Drawing.Size(698, 273)
        Me.gbxDeptosCategorias.TabIndex = 47
        Me.gbxDeptosCategorias.TabStop = False
        '
        'grdDepartamentoCategorias
        '
        Me.grdDepartamentoCategorias.AlternatingRows = True
        Me.grdDepartamentoCategorias.DataSource = Me.bsDepartamentoCategorias
        Me.grdDepartamentoCategorias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDepartamentoCategorias.IDCatalogField = "IdCategoriaPresupuestal"
        Me.grdDepartamentoCategorias.Images.Add(CType(resources.GetObject("grdDepartamentoCategorias.Images"), System.Drawing.Image))
        Me.grdDepartamentoCategorias.Location = New System.Drawing.Point(3, 55)
        Me.grdDepartamentoCategorias.Name = "grdDepartamentoCategorias"
        Me.grdDepartamentoCategorias.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdDepartamentoCategorias.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdDepartamentoCategorias.PreviewInfo.ZoomFactor = 75.0R
        Me.grdDepartamentoCategorias.PrintInfo.PageSettings = CType(resources.GetObject("grdDepartamentoCategorias.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdDepartamentoCategorias.RowHeight = 17
        Me.grdDepartamentoCategorias.ShowEditButton = False
        Me.grdDepartamentoCategorias.Size = New System.Drawing.Size(692, 215)
        Me.grdDepartamentoCategorias.TabIndex = 46
        Me.grdDepartamentoCategorias.Text = "AzTrueDBGrid1"
        Me.grdDepartamentoCategorias.PropBag = resources.GetString("grdDepartamentoCategorias.PropBag")
        '
        'tbDeptosCategoria
        '
        Me.tbDeptosCategoria.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbDeptosCategoria.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnDeptosCategoriaAdd})
        Me.tbDeptosCategoria.Location = New System.Drawing.Point(3, 16)
        Me.tbDeptosCategoria.Name = "tbDeptosCategoria"
        Me.tbDeptosCategoria.Size = New System.Drawing.Size(692, 39)
        Me.tbDeptosCategoria.TabIndex = 45
        Me.tbDeptosCategoria.Text = "CiToolBar4"
        '
        'btnDeptosCategoriaAdd
        '
        Me.btnDeptosCategoriaAdd.Image = CType(resources.GetObject("btnDeptosCategoriaAdd.Image"), System.Drawing.Image)
        Me.btnDeptosCategoriaAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDeptosCategoriaAdd.Name = "btnDeptosCategoriaAdd"
        Me.btnDeptosCategoriaAdd.Size = New System.Drawing.Size(209, 36)
        Me.btnDeptosCategoriaAdd.Text = "Agregar Categoria Presupuestal"
        '
        'pagGastosConceptos
        '
        Me.pagGastosConceptos.Controls.Add(Me.gbxDeptoConceptos)
        Me.pagGastosConceptos.ImageKey = "Conceptos"
        Me.pagGastosConceptos.Location = New System.Drawing.Point(4, 31)
        Me.pagGastosConceptos.Name = "pagGastosConceptos"
        Me.pagGastosConceptos.Padding = New System.Windows.Forms.Padding(3)
        Me.pagGastosConceptos.Size = New System.Drawing.Size(704, 279)
        Me.pagGastosConceptos.TabIndex = 1
        Me.pagGastosConceptos.Text = "Conceptos de Gastos"
        Me.pagGastosConceptos.UseVisualStyleBackColor = True
        '
        'gbxDeptoConceptos
        '
        Me.gbxDeptoConceptos.Controls.Add(Me.grdDepartamentoConceptos)
        Me.gbxDeptoConceptos.Controls.Add(Me.CiToolBar1)
        Me.gbxDeptoConceptos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxDeptoConceptos.Location = New System.Drawing.Point(3, 3)
        Me.gbxDeptoConceptos.Name = "gbxDeptoConceptos"
        Me.gbxDeptoConceptos.Size = New System.Drawing.Size(698, 273)
        Me.gbxDeptoConceptos.TabIndex = 48
        Me.gbxDeptoConceptos.TabStop = False
        '
        'grdDepartamentoConceptos
        '
        Me.grdDepartamentoConceptos.AlternatingRows = True
        Me.grdDepartamentoConceptos.DataSource = Me.bsDepartamentoConceptos
        Me.grdDepartamentoConceptos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDepartamentoConceptos.IDCatalogField = "IdGastoConcepto"
        Me.grdDepartamentoConceptos.Images.Add(CType(resources.GetObject("grdDepartamentoConceptos.Images"), System.Drawing.Image))
        Me.grdDepartamentoConceptos.Location = New System.Drawing.Point(3, 55)
        Me.grdDepartamentoConceptos.Name = "grdDepartamentoConceptos"
        Me.grdDepartamentoConceptos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdDepartamentoConceptos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdDepartamentoConceptos.PreviewInfo.ZoomFactor = 75.0R
        Me.grdDepartamentoConceptos.PrintInfo.PageSettings = CType(resources.GetObject("grdDepartamentoConceptos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdDepartamentoConceptos.RowHeight = 17
        Me.grdDepartamentoConceptos.ShowEditButton = False
        Me.grdDepartamentoConceptos.Size = New System.Drawing.Size(692, 215)
        Me.grdDepartamentoConceptos.TabIndex = 46
        Me.grdDepartamentoConceptos.Text = "AzTrueDBGrid1"
        Me.grdDepartamentoConceptos.PropBag = resources.GetString("grdDepartamentoConceptos.PropBag")
        '
        'CiToolBar1
        '
        Me.CiToolBar1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.CiToolBar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnDeptoGastoConceptoAdd})
        Me.CiToolBar1.Location = New System.Drawing.Point(3, 16)
        Me.CiToolBar1.Name = "CiToolBar1"
        Me.CiToolBar1.Size = New System.Drawing.Size(692, 39)
        Me.CiToolBar1.TabIndex = 45
        Me.CiToolBar1.Text = "CiToolBar4"
        '
        'btnDeptoGastoConceptoAdd
        '
        Me.btnDeptoGastoConceptoAdd.Image = CType(resources.GetObject("btnDeptoGastoConceptoAdd.Image"), System.Drawing.Image)
        Me.btnDeptoGastoConceptoAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDeptoGastoConceptoAdd.Name = "btnDeptoGastoConceptoAdd"
        Me.btnDeptoGastoConceptoAdd.Size = New System.Drawing.Size(189, 36)
        Me.btnDeptoGastoConceptoAdd.Text = "Agregar Concepto de Gasto"
        '
        'iLstDepartamento
        '
        Me.iLstDepartamento.ImageStream = CType(resources.GetObject("iLstDepartamento.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.iLstDepartamento.TransparentColor = System.Drawing.Color.Transparent
        Me.iLstDepartamento.Images.SetKeyName(0, "Categorias")
        Me.iLstDepartamento.Images.SetKeyName(1, "Conceptos")
        '
        'cboCentralComprasDepto
        '
        Me.cboCentralComprasDepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCentralComprasDepto.FormattingEnabled = True
        Me.cboCentralComprasDepto.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboCentralComprasDepto.ItemsTable = Nothing
        Me.cboCentralComprasDepto.Location = New System.Drawing.Point(180, 40)
        Me.cboCentralComprasDepto.Name = "cboCentralComprasDepto"
        Me.cboCentralComprasDepto.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboCentralComprasDepto.Size = New System.Drawing.Size(197, 21)
        Me.cboCentralComprasDepto.TabIndex = 55
        Me.cboCentralComprasDepto.UIName = Nothing
        '
        'optCategorizado
        '
        Me.optCategorizado.AutoSize = True
        Me.optCategorizado.Location = New System.Drawing.Point(342, 67)
        Me.optCategorizado.Name = "optCategorizado"
        Me.optCategorizado.Size = New System.Drawing.Size(87, 17)
        Me.optCategorizado.TabIndex = 54
        Me.optCategorizado.Text = "Categorizado"
        Me.optCategorizado.UseVisualStyleBackColor = True
        '
        'optGlobal
        '
        Me.optGlobal.AutoSize = True
        Me.optGlobal.Location = New System.Drawing.Point(245, 69)
        Me.optGlobal.Name = "optGlobal"
        Me.optGlobal.Size = New System.Drawing.Size(55, 17)
        Me.optGlobal.TabIndex = 53
        Me.optGlobal.Text = "Global"
        Me.optGlobal.UseVisualStyleBackColor = True
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(10, 69)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(122, 13)
        Me.CiLabel2.TabIndex = 52
        Me.CiLabel2.Text = "Administrar presupuesto:"
        '
        'optNoUtilizar
        '
        Me.optNoUtilizar.AutoSize = True
        Me.optNoUtilizar.Checked = True
        Me.optNoUtilizar.Location = New System.Drawing.Point(138, 67)
        Me.optNoUtilizar.Name = "optNoUtilizar"
        Me.optNoUtilizar.Size = New System.Drawing.Size(76, 17)
        Me.optNoUtilizar.TabIndex = 51
        Me.optNoUtilizar.TabStop = True
        Me.optNoUtilizar.Text = "No maneja"
        Me.optNoUtilizar.UseVisualStyleBackColor = True
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(10, 44)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(169, 13)
        Me.CiLabel1.TabIndex = 25
        Me.CiLabel1.Text = "Central de Compras para Ordenes:"
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Location = New System.Drawing.Point(10, 16)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(131, 13)
        Me.lblCuenta.TabIndex = 24
        Me.lblCuenta.Text = "Cuenta del Departamento:"
        '
        'selCuenta
        '
        Me.selCuenta.AnySite = False
        Me.selCuenta.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selCuenta.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.selCuenta.EditorAssembly = "Azteca.ContabilidadWin"
        Me.selCuenta.EditorClass = "Azteca.Windows.Contabilidad.CuentaForm"
        Me.selCuenta.EditorTitle = "Editar Cuenta..."
        Me.selCuenta.Key = 0
        Me.selCuenta.Linked = False
        Me.selCuenta.Location = New System.Drawing.Point(180, 11)
        Me.selCuenta.Name = "selCuenta"
        Me.selCuenta.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selCuenta.Size = New System.Drawing.Size(545, 23)
        Me.selCuenta.TabIndex = 23
        Me.selCuenta.TextWidth = 100
        '
        'trvwDepartamentos
        '
        Me.trvwDepartamentos.Dock = System.Windows.Forms.DockStyle.Left
        Me.trvwDepartamentos.ImageIndex = 0
        Me.trvwDepartamentos.ImageList = Me.imlDeptos
        Me.trvwDepartamentos.Location = New System.Drawing.Point(3, 42)
        Me.trvwDepartamentos.Name = "trvwDepartamentos"
        Me.trvwDepartamentos.SelectedImageIndex = 0
        Me.trvwDepartamentos.Size = New System.Drawing.Size(357, 412)
        Me.trvwDepartamentos.TabIndex = 48
        '
        'imlDeptos
        '
        Me.imlDeptos.ImageStream = CType(resources.GetObject("imlDeptos.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlDeptos.TransparentColor = System.Drawing.Color.Transparent
        Me.imlDeptos.Images.SetKeyName(0, "BaseBlue_16.png")
        '
        'tbDepartamentos
        '
        Me.tbDepartamentos.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbDepartamentos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnDeptosSave, Me.ToolStripSeparator2, Me.btnDeptosAccesos, Me.btnDeptosAsignarCtrosRecibo, Me.ToolStripSeparator1, Me.btnDeptosRefresh})
        Me.tbDepartamentos.Location = New System.Drawing.Point(3, 3)
        Me.tbDepartamentos.Name = "tbDepartamentos"
        Me.tbDepartamentos.Size = New System.Drawing.Size(1088, 39)
        Me.tbDepartamentos.TabIndex = 0
        Me.tbDepartamentos.Text = "CiToolBar1"
        '
        'btnDeptosSave
        '
        Me.btnDeptosSave.Enabled = False
        Me.btnDeptosSave.Image = CType(resources.GetObject("btnDeptosSave.Image"), System.Drawing.Image)
        Me.btnDeptosSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDeptosSave.Name = "btnDeptosSave"
        Me.btnDeptosSave.Size = New System.Drawing.Size(85, 36)
        Me.btnDeptosSave.Text = "Guardar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'btnDeptosAccesos
        '
        Me.btnDeptosAccesos.Enabled = False
        Me.btnDeptosAccesos.Image = CType(resources.GetObject("btnDeptosAccesos.Image"), System.Drawing.Image)
        Me.btnDeptosAccesos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDeptosAccesos.Name = "btnDeptosAccesos"
        Me.btnDeptosAccesos.Size = New System.Drawing.Size(86, 36)
        Me.btnDeptosAccesos.Text = "Accesos"
        '
        'btnDeptosAsignarCtrosRecibo
        '
        Me.btnDeptosAsignarCtrosRecibo.Enabled = False
        Me.btnDeptosAsignarCtrosRecibo.Image = CType(resources.GetObject("btnDeptosAsignarCtrosRecibo.Image"), System.Drawing.Image)
        Me.btnDeptosAsignarCtrosRecibo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDeptosAsignarCtrosRecibo.Name = "btnDeptosAsignarCtrosRecibo"
        Me.btnDeptosAsignarCtrosRecibo.Size = New System.Drawing.Size(158, 36)
        Me.btnDeptosAsignarCtrosRecibo.Text = "Centros de Recepción"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'btnDeptosRefresh
        '
        Me.btnDeptosRefresh.Image = CType(resources.GetObject("btnDeptosRefresh.Image"), System.Drawing.Image)
        Me.btnDeptosRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDeptosRefresh.Name = "btnDeptosRefresh"
        Me.btnDeptosRefresh.Size = New System.Drawing.Size(95, 36)
        Me.btnDeptosRefresh.Text = "Actualizar"
        '
        'iLstTabs
        '
        Me.iLstTabs.ImageStream = CType(resources.GetObject("iLstTabs.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.iLstTabs.TransparentColor = System.Drawing.Color.Transparent
        Me.iLstTabs.Images.SetKeyName(0, "Departamentos")
        Me.iLstTabs.Images.SetKeyName(1, "Categorias")
        Me.iLstTabs.Images.SetKeyName(2, "Centrales")
        Me.iLstTabs.Images.SetKeyName(3, "CentrosRec")
        Me.iLstTabs.Images.SetKeyName(4, "ConceptosGastos")
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
        Me.pnlTitulo.Size = New System.Drawing.Size(1126, 44)
        Me.pnlTitulo.TabIndex = 46
        '
        'lblConfiguracion
        '
        Me.lblConfiguracion.BackColor = System.Drawing.Color.Transparent
        Me.lblConfiguracion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblConfiguracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfiguracion.ForeColor = System.Drawing.Color.SlateGray
        Me.lblConfiguracion.Location = New System.Drawing.Point(0, 0)
        Me.lblConfiguracion.Name = "lblConfiguracion"
        Me.lblConfiguracion.Size = New System.Drawing.Size(1126, 44)
        Me.lblConfiguracion.TabIndex = 35
        Me.lblConfiguracion.Text = "Configuración del Módulo de Compras"
        Me.lblConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ConfiguracionEmpresaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1126, 520)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Controls.Add(Me.tabConfiguracion)
        Me.Name = "ConfiguracionEmpresaForm"
        Me.Text = "ConfiguracionEmpresaForm"
        Me.tabConfiguracion.ResumeLayout(False)
        Me.pagCentralCompras.ResumeLayout(False)
        Me.gbxCentrosCompra.ResumeLayout(False)
        Me.gbxCentrosCompra.PerformLayout()
        CType(Me.grdCentrales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCentrales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dropOperador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsRemitentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbCentralCompras.ResumeLayout(False)
        Me.tbCentralCompras.PerformLayout()
        CType(Me.dropRemitentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagCentrosRecepcion.ResumeLayout(False)
        Me.pagCentrosRecepcion.PerformLayout()
        Me.gbxCentrosRecepcion.ResumeLayout(False)
        Me.gbxCentrosRecepcion.PerformLayout()
        CType(Me.grdCentrosRecepcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCentrosRecepcion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbCentrosRecepcion.ResumeLayout(False)
        Me.tbCentrosRecepcion.PerformLayout()
        CType(Me.dropAlmacenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAlmacenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CiToolBar2.ResumeLayout(False)
        Me.CiToolBar2.PerformLayout()
        Me.pagCategorias.ResumeLayout(False)
        Me.CiGroupBox1.ResumeLayout(False)
        Me.CiGroupBox1.PerformLayout()
        CType(Me.grdCategoriasPresupuestales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCategoriaPresupuestal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbCategoriaPresupuestal.ResumeLayout(False)
        Me.tbCategoriaPresupuestal.PerformLayout()
        Me.pagTiposGastos.ResumeLayout(False)
        Me.CiGroupBox2.ResumeLayout(False)
        Me.CiGroupBox2.PerformLayout()
        CType(Me.grdGastosTipos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsGastosTipos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbGastosTipos.ResumeLayout(False)
        Me.tbGastosTipos.PerformLayout()
        Me.pagDepartamentos.ResumeLayout(False)
        Me.pagDepartamentos.PerformLayout()
        Me.gbxDepartamentosP.ResumeLayout(False)
        Me.gbxDepartamentosP.PerformLayout()
        Me.tabDepartamento.ResumeLayout(False)
        Me.pagGastosCategoriasPresup.ResumeLayout(False)
        Me.gbxDeptosCategorias.ResumeLayout(False)
        Me.gbxDeptosCategorias.PerformLayout()
        CType(Me.grdDepartamentoCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDepartamentoCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbDeptosCategoria.ResumeLayout(False)
        Me.tbDeptosCategoria.PerformLayout()
        Me.pagGastosConceptos.ResumeLayout(False)
        Me.gbxDeptoConceptos.ResumeLayout(False)
        Me.gbxDeptoConceptos.PerformLayout()
        CType(Me.grdDepartamentoConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDepartamentoConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CiToolBar1.ResumeLayout(False)
        Me.CiToolBar1.PerformLayout()
        Me.tbDepartamentos.ResumeLayout(False)
        Me.tbDepartamentos.PerformLayout()
        CType(Me.bsOperadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitulo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabConfiguracion As Azteca.Windows.Controls.CITab
    Friend WithEvents pagDepartamentos As System.Windows.Forms.TabPage
    Friend WithEvents tbDepartamentos As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents iLstTabs As System.Windows.Forms.ImageList
    Friend WithEvents pagCentrosRecepcion As System.Windows.Forms.TabPage
    Friend WithEvents grdCentrosRecepcion As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents CiToolBar2 As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDeptosSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents pagCentralCompras As System.Windows.Forms.TabPage
    Friend WithEvents grdCentrales As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents tbCentralCompras As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnCentralComprasAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCentralComprasRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbCentrosRecepcion As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnCentrosRecepcionRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCentrosRecepcionAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDeptosRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents bsCentrales As System.Windows.Forms.BindingSource
    Friend WithEvents bsRemitentes As System.Windows.Forms.BindingSource
    Friend WithEvents dropRemitentes As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents dropOperador As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents bsOperadores As System.Windows.Forms.BindingSource
    Friend WithEvents bsCentrosRecepcion As System.Windows.Forms.BindingSource
    Friend WithEvents ColorWithAlpha1 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents bsAlmacenes As System.Windows.Forms.BindingSource
    Friend WithEvents dropAlmacenes As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents gbxCentrosCompra As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents gbxCentrosRecepcion As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents trvwDepartamentos As Azteca.Windows.Controls.HierarchyViewer
    Friend WithEvents gbxDepartamentosP As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents btnDeptosAccesos As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDeptosAsignarCtrosRecibo As System.Windows.Forms.ToolStripButton
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCuenta As Azteca.Windows.Controls.CILabel
    Friend WithEvents selCuenta As Azteca.Windows.Contabilidad.CuentaSelector
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents pagCategorias As System.Windows.Forms.TabPage
    Friend WithEvents CiGroupBox1 As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents bsCategoriaPresupuestal As System.Windows.Forms.BindingSource
    Friend WithEvents tbCategoriaPresupuestal As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnCatPresupRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCatPresupNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents optNoUtilizar As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents gbxDeptosCategorias As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents tbDeptosCategoria As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnDeptosCategoriaAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdCategoriasPresupuestales As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents optCategorizado As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents optGlobal As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents cboCentralComprasDepto As Azteca.Windows.Compras.CentralComprasComboBox
    Friend WithEvents grdDepartamentoCategorias As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents bsDepartamentoCategorias As System.Windows.Forms.BindingSource
    Friend WithEvents pagTiposGastos As System.Windows.Forms.TabPage
    Friend WithEvents CiGroupBox2 As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents grdGastosTipos As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents bsGastosTipos As System.Windows.Forms.BindingSource
    Friend WithEvents tbGastosTipos As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnGastosRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGastosAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents tabDepartamento As Azteca.Windows.Controls.CITab
    Friend WithEvents pagGastosCategoriasPresup As System.Windows.Forms.TabPage
    Friend WithEvents pagGastosConceptos As System.Windows.Forms.TabPage
    Friend WithEvents gbxDeptoConceptos As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents grdDepartamentoConceptos As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents CiToolBar1 As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnDeptoGastoConceptoAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents iLstDepartamento As System.Windows.Forms.ImageList
    Friend WithEvents bsDepartamentoConceptos As System.Windows.Forms.BindingSource
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboCaja As Azteca.Windows.Tesoreria.CajasComboBox
    Friend WithEvents imlDeptos As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnArticulosCat As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnServiciosCat As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents pnlTitulo As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents lblConfiguracion As Azteca.Windows.Controls.CILabel
End Class
