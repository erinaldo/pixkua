<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdenesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrdenesForm))
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
        Me.lblCentroRecepcion = New Azteca.Windows.Controls.CILabel()
        Me.lblDepartamento = New Azteca.Windows.Controls.CILabel()
        Me.lblPresupuesto = New Azteca.Windows.Controls.CILabel()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdNuevaRecepcion = New C1.Win.C1Command.C1Command()
        Me.imlOrden = New System.Windows.Forms.ImageList(Me.components)
        Me.txtTotal = New Azteca.Windows.Controls.CITextBox()
        Me.txtDescuentos = New Azteca.Windows.Controls.CITextBox()
        Me.txtRetenciones = New Azteca.Windows.Controls.CITextBox()
        Me.txtImpuestos = New Azteca.Windows.Controls.CITextBox()
        Me.txtSubTotal = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel8 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel7 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel6 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel5 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.cboDivisa = New Azteca.Windows.Contabilidad.DivisasComboBox()
        Me.CiLabel13 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.grdRecepciones = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsRecepciones = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsArticulos = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsServicios = New System.Windows.Forms.BindingSource(Me.components)
        Me.imlPartidas = New System.Windows.Forms.ImageList(Me.components)
        Me.cboCategoriasArt = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.bsCategoriasArt = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdArticulos = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.cboCategoriasServ = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.bsCategoriasServ = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdServicios = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.tabOrden = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagGeneral = New C1.Win.C1Command.C1DockingTabPage()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.txtObervaciones = New Azteca.Windows.Controls.CITextBox()
        Me.cboPresupuesto = New Azteca.Windows.Compras.PresupuestoComboBox()
        Me.cboDepartamento = New Azteca.Windows.Compras.DepartamentoComboBox()
        Me.cboCentrosRecep = New Azteca.Windows.Compras.CentrosRecepcionComboBox()
        Me.txtProveedor = New Azteca.Windows.Compras.ProveedoresSelector()
        Me.pagRecepciones = New C1.Win.C1Command.C1DockingTabPage()
        Me.tlbRecepciones = New Azteca.Windows.Controls.AZToolBar()
        Me.btnNuevaRecepcion = New C1.Win.C1Command.C1CommandLink()
        Me.tabPartidas = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagArticulos = New C1.Win.C1Command.C1DockingTabPage()
        Me.pagServicios = New C1.Win.C1Command.C1DockingTabPage()
        Me.cmsReimpresion = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReimpresiónDeCódigoDeBarrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdRecepciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsRecepciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCategoriasArt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCategoriasArt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCategoriasServ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCategoriasServ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabOrden.SuspendLayout()
        Me.pagGeneral.SuspendLayout()
        Me.pagRecepciones.SuspendLayout()
        CType(Me.tabPartidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPartidas.SuspendLayout()
        Me.pagArticulos.SuspendLayout()
        Me.pagServicios.SuspendLayout()
        Me.cmsReimpresion.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCentroRecepcion
        '
        Me.lblCentroRecepcion.AutoSize = True
        Me.lblCentroRecepcion.Location = New System.Drawing.Point(6, 67)
        Me.lblCentroRecepcion.Name = "lblCentroRecepcion"
        Me.lblCentroRecepcion.Size = New System.Drawing.Size(125, 17)
        Me.lblCentroRecepcion.TabIndex = 69
        Me.lblCentroRecepcion.Text = "Centro Recepción:"
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.Location = New System.Drawing.Point(6, 40)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(102, 17)
        Me.lblDepartamento.TabIndex = 71
        Me.lblDepartamento.Text = "Departamento:"
        '
        'lblPresupuesto
        '
        Me.lblPresupuesto.AutoSize = True
        Me.lblPresupuesto.Location = New System.Drawing.Point(6, 94)
        Me.lblPresupuesto.Name = "lblPresupuesto"
        Me.lblPresupuesto.Size = New System.Drawing.Size(92, 17)
        Me.lblPresupuesto.TabIndex = 67
        Me.lblPresupuesto.Text = "Presupuesto:"
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdNuevaRecepcion)
        Me.C1CommandHolder1.Owner = Me
        '
        'cmdNuevaRecepcion
        '
        Me.cmdNuevaRecepcion.Enabled = False
        Me.cmdNuevaRecepcion.Image = CType(resources.GetObject("cmdNuevaRecepcion.Image"), System.Drawing.Image)
        Me.cmdNuevaRecepcion.Name = "cmdNuevaRecepcion"
        Me.cmdNuevaRecepcion.ShortcutText = ""
        Me.cmdNuevaRecepcion.Text = "Nueva Recepción"
        '
        'imlOrden
        '
        Me.imlOrden.ImageStream = CType(resources.GetObject("imlOrden.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlOrden.TransparentColor = System.Drawing.Color.Transparent
        Me.imlOrden.Images.SetKeyName(0, "Generales")
        Me.imlOrden.Images.SetKeyName(1, "Recepciones")
        '
        'txtTotal
        '
        Me.txtTotal.AutoLock = False
        Me.txtTotal.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTotal.Location = New System.Drawing.Point(504, 167)
        Me.txtTotal.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotal.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(136, 22)
        Me.txtTotal.TabIndex = 86
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDescuentos
        '
        Me.txtDescuentos.AutoLock = False
        Me.txtDescuentos.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtDescuentos.Location = New System.Drawing.Point(504, 141)
        Me.txtDescuentos.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDescuentos.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDescuentos.Name = "txtDescuentos"
        Me.txtDescuentos.ReadOnly = True
        Me.txtDescuentos.Size = New System.Drawing.Size(136, 22)
        Me.txtDescuentos.TabIndex = 84
        Me.txtDescuentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRetenciones
        '
        Me.txtRetenciones.AutoLock = False
        Me.txtRetenciones.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtRetenciones.Location = New System.Drawing.Point(504, 115)
        Me.txtRetenciones.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRetenciones.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRetenciones.Name = "txtRetenciones"
        Me.txtRetenciones.ReadOnly = True
        Me.txtRetenciones.Size = New System.Drawing.Size(136, 22)
        Me.txtRetenciones.TabIndex = 82
        Me.txtRetenciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImpuestos
        '
        Me.txtImpuestos.AutoLock = False
        Me.txtImpuestos.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtImpuestos.Location = New System.Drawing.Point(504, 89)
        Me.txtImpuestos.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtImpuestos.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtImpuestos.Name = "txtImpuestos"
        Me.txtImpuestos.ReadOnly = True
        Me.txtImpuestos.Size = New System.Drawing.Size(136, 22)
        Me.txtImpuestos.TabIndex = 80
        Me.txtImpuestos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotal
        '
        Me.txtSubTotal.AutoLock = False
        Me.txtSubTotal.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtSubTotal.Location = New System.Drawing.Point(504, 64)
        Me.txtSubTotal.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSubTotal.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(136, 22)
        Me.txtSubTotal.TabIndex = 78
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CiLabel8
        '
        Me.CiLabel8.AutoSize = True
        Me.CiLabel8.Location = New System.Drawing.Point(402, 170)
        Me.CiLabel8.Name = "CiLabel8"
        Me.CiLabel8.Size = New System.Drawing.Size(44, 17)
        Me.CiLabel8.TabIndex = 85
        Me.CiLabel8.Text = "Total:"
        '
        'CiLabel7
        '
        Me.CiLabel7.AutoSize = True
        Me.CiLabel7.Location = New System.Drawing.Point(401, 144)
        Me.CiLabel7.Name = "CiLabel7"
        Me.CiLabel7.Size = New System.Drawing.Size(123, 17)
        Me.CiLabel7.TabIndex = 83
        Me.CiLabel7.Text = "Total Descuentos:"
        '
        'CiLabel6
        '
        Me.CiLabel6.AutoSize = True
        Me.CiLabel6.Location = New System.Drawing.Point(401, 119)
        Me.CiLabel6.Name = "CiLabel6"
        Me.CiLabel6.Size = New System.Drawing.Size(127, 17)
        Me.CiLabel6.TabIndex = 81
        Me.CiLabel6.Text = "Total Retenciones:"
        '
        'CiLabel5
        '
        Me.CiLabel5.AutoSize = True
        Me.CiLabel5.Location = New System.Drawing.Point(401, 92)
        Me.CiLabel5.Name = "CiLabel5"
        Me.CiLabel5.Size = New System.Drawing.Size(112, 17)
        Me.CiLabel5.TabIndex = 79
        Me.CiLabel5.Text = "Total Impuestos:"
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.Location = New System.Drawing.Point(402, 67)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(73, 17)
        Me.CiLabel4.TabIndex = 77
        Me.CiLabel4.Text = "Sub Total:"
        '
        'cboDivisa
        '
        Me.cboDivisa.AutoClear = False
        Me.cboDivisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDivisa.FormattingEnabled = True
        Me.cboDivisa.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboDivisa.ItemsTable = Nothing
        Me.cboDivisa.Location = New System.Drawing.Point(504, 37)
        Me.cboDivisa.Name = "cboDivisa"
        Me.cboDivisa.RequiredField = True
        Me.cboDivisa.Size = New System.Drawing.Size(136, 24)
        Me.cboDivisa.TabIndex = 76
        Me.cboDivisa.UIName = "Divisa"
        '
        'CiLabel13
        '
        Me.CiLabel13.AutoSize = True
        Me.CiLabel13.Location = New System.Drawing.Point(402, 40)
        Me.CiLabel13.Name = "CiLabel13"
        Me.CiLabel13.Size = New System.Drawing.Size(50, 17)
        Me.CiLabel13.TabIndex = 75
        Me.CiLabel13.Text = "Divisa:"
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(6, 11)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(78, 17)
        Me.CiLabel1.TabIndex = 73
        Me.CiLabel1.Text = "Proveedor:"
        '
        'grdRecepciones
        '
        Me.grdRecepciones.AllowUpdate = False
        Me.grdRecepciones.DataSource = Me.bsRecepciones
        Me.grdRecepciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdRecepciones.Images.Add(CType(resources.GetObject("grdRecepciones.Images"), System.Drawing.Image))
        Me.grdRecepciones.Images.Add(CType(resources.GetObject("grdRecepciones.Images1"), System.Drawing.Image))
        Me.grdRecepciones.Location = New System.Drawing.Point(0, 32)
        Me.grdRecepciones.Name = "grdRecepciones"
        Me.grdRecepciones.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdRecepciones.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdRecepciones.PreviewInfo.ZoomFactor = 75.0R
        Me.grdRecepciones.PrintInfo.PageSettings = CType(resources.GetObject("grdRecepciones.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdRecepciones.Size = New System.Drawing.Size(1070, 230)
        Me.grdRecepciones.TabIndex = 0
        Me.grdRecepciones.Text = "AzTrueDBGrid1"
        Me.grdRecepciones.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdRecepciones.PropBag = resources.GetString("grdRecepciones.PropBag")
        '
        'bsArticulos
        '
        Me.bsArticulos.Filter = ""
        '
        'bsServicios
        '
        Me.bsServicios.Filter = ""
        '
        'imlPartidas
        '
        Me.imlPartidas.ImageStream = CType(resources.GetObject("imlPartidas.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlPartidas.TransparentColor = System.Drawing.Color.Transparent
        Me.imlPartidas.Images.SetKeyName(0, "Articulos")
        Me.imlPartidas.Images.SetKeyName(1, "Servicios")
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
        Me.cboCategoriasArt.Location = New System.Drawing.Point(426, 26)
        Me.cboCategoriasArt.Name = "cboCategoriasArt"
        Me.cboCategoriasArt.OddRowStyle = Style6
        Me.cboCategoriasArt.RecordSelectorStyle = Style7
        Me.cboCategoriasArt.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCategoriasArt.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboCategoriasArt.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCategoriasArt.ScrollTips = False
        Me.cboCategoriasArt.Size = New System.Drawing.Size(273, 147)
        Me.cboCategoriasArt.Style = Style8
        Me.cboCategoriasArt.TabIndex = 77
        Me.cboCategoriasArt.TabStop = False
        Me.cboCategoriasArt.ValueMember = "IdCategoriaPresupuestal"
        Me.cboCategoriasArt.Visible = False
        Me.cboCategoriasArt.PropBag = resources.GetString("cboCategoriasArt.PropBag")
        '
        'grdArticulos
        '
        Me.grdArticulos.AllowAddNew = True
        Me.grdArticulos.AllowDelete = True
        Me.grdArticulos.CellTips = C1.Win.C1TrueDBGrid.CellTipEnum.Anchored
        Me.grdArticulos.ContextMenuStrip = Me.cmsReimpresion
        Me.grdArticulos.DataSource = Me.bsArticulos
        Me.grdArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdArticulos.Images.Add(CType(resources.GetObject("grdArticulos.Images"), System.Drawing.Image))
        Me.grdArticulos.Images.Add(CType(resources.GetObject("grdArticulos.Images1"), System.Drawing.Image))
        Me.grdArticulos.Images.Add(CType(resources.GetObject("grdArticulos.Images2"), System.Drawing.Image))
        Me.grdArticulos.Images.Add(CType(resources.GetObject("grdArticulos.Images3"), System.Drawing.Image))
        Me.grdArticulos.Images.Add(CType(resources.GetObject("grdArticulos.Images4"), System.Drawing.Image))
        Me.grdArticulos.Location = New System.Drawing.Point(0, 0)
        Me.grdArticulos.Name = "grdArticulos"
        Me.grdArticulos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdArticulos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdArticulos.PreviewInfo.ZoomFactor = 75.0R
        Me.grdArticulos.PrintInfo.PageSettings = CType(resources.GetObject("grdArticulos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdArticulos.Size = New System.Drawing.Size(1070, 155)
        Me.grdArticulos.TabIndex = 2
        Me.grdArticulos.Text = "AzTrueDBGrid1"
        Me.grdArticulos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdArticulos.PropBag = resources.GetString("grdArticulos.PropBag")
        '
        'cboCategoriasServ
        '
        Me.cboCategoriasServ.AllowColMove = True
        Me.cboCategoriasServ.AllowColSelect = True
        Me.cboCategoriasServ.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboCategoriasServ.AlternatingRows = False
        Me.cboCategoriasServ.CaptionStyle = Style9
        Me.cboCategoriasServ.ColumnCaptionHeight = 17
        Me.cboCategoriasServ.ColumnFooterHeight = 17
        Me.cboCategoriasServ.DataSource = Me.bsCategoriasServ
        Me.cboCategoriasServ.DisplayMember = "Nombre"
        Me.cboCategoriasServ.EvenRowStyle = Style10
        Me.cboCategoriasServ.ExtendRightColumn = True
        Me.cboCategoriasServ.FetchRowStyles = False
        Me.cboCategoriasServ.FooterStyle = Style11
        Me.cboCategoriasServ.HeadingStyle = Style12
        Me.cboCategoriasServ.HighLightRowStyle = Style13
        Me.cboCategoriasServ.Images.Add(CType(resources.GetObject("cboCategoriasServ.Images"), System.Drawing.Image))
        Me.cboCategoriasServ.Location = New System.Drawing.Point(335, 3)
        Me.cboCategoriasServ.Name = "cboCategoriasServ"
        Me.cboCategoriasServ.OddRowStyle = Style14
        Me.cboCategoriasServ.RecordSelectorStyle = Style15
        Me.cboCategoriasServ.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCategoriasServ.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboCategoriasServ.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCategoriasServ.ScrollTips = False
        Me.cboCategoriasServ.Size = New System.Drawing.Size(273, 147)
        Me.cboCategoriasServ.Style = Style16
        Me.cboCategoriasServ.TabIndex = 74
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
        Me.grdServicios.Images.Add(CType(resources.GetObject("grdServicios.Images4"), System.Drawing.Image))
        Me.grdServicios.Location = New System.Drawing.Point(0, 0)
        Me.grdServicios.Name = "grdServicios"
        Me.grdServicios.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdServicios.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdServicios.PreviewInfo.ZoomFactor = 75.0R
        Me.grdServicios.PrintInfo.PageSettings = CType(resources.GetObject("grdServicios.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdServicios.Size = New System.Drawing.Size(1070, 155)
        Me.grdServicios.TabIndex = 2
        Me.grdServicios.Text = "AzTrueDBGrid1"
        Me.grdServicios.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdServicios.PropBag = resources.GetString("grdServicios.PropBag")
        '
        'tabOrden
        '
        Me.tabOrden.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabOrden.Controls.Add(Me.pagGeneral)
        Me.tabOrden.Controls.Add(Me.pagRecepciones)
        Me.tabOrden.ImageList = Me.imlOrden
        Me.tabOrden.Location = New System.Drawing.Point(11, 118)
        Me.tabOrden.Margin = New System.Windows.Forms.Padding(4)
        Me.tabOrden.Name = "tabOrden"
        Me.tabOrden.SelectedIndex = 1
        Me.tabOrden.Size = New System.Drawing.Size(1072, 304)
        Me.tabOrden.TabIndex = 76
        Me.tabOrden.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabOrden.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabOrden.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagGeneral
        '
        Me.pagGeneral.Controls.Add(Me.CiLabel2)
        Me.pagGeneral.Controls.Add(Me.txtObervaciones)
        Me.pagGeneral.Controls.Add(Me.txtTotal)
        Me.pagGeneral.Controls.Add(Me.CiLabel1)
        Me.pagGeneral.Controls.Add(Me.txtDescuentos)
        Me.pagGeneral.Controls.Add(Me.txtRetenciones)
        Me.pagGeneral.Controls.Add(Me.txtImpuestos)
        Me.pagGeneral.Controls.Add(Me.lblCentroRecepcion)
        Me.pagGeneral.Controls.Add(Me.txtSubTotal)
        Me.pagGeneral.Controls.Add(Me.lblPresupuesto)
        Me.pagGeneral.Controls.Add(Me.CiLabel8)
        Me.pagGeneral.Controls.Add(Me.CiLabel7)
        Me.pagGeneral.Controls.Add(Me.lblDepartamento)
        Me.pagGeneral.Controls.Add(Me.CiLabel6)
        Me.pagGeneral.Controls.Add(Me.CiLabel5)
        Me.pagGeneral.Controls.Add(Me.CiLabel13)
        Me.pagGeneral.Controls.Add(Me.CiLabel4)
        Me.pagGeneral.Controls.Add(Me.cboDivisa)
        Me.pagGeneral.Controls.Add(Me.cboPresupuesto)
        Me.pagGeneral.Controls.Add(Me.cboDepartamento)
        Me.pagGeneral.Controls.Add(Me.cboCentrosRecep)
        Me.pagGeneral.Controls.Add(Me.txtProveedor)
        Me.pagGeneral.ImageIndex = 0
        Me.pagGeneral.Location = New System.Drawing.Point(1, 41)
        Me.pagGeneral.Name = "pagGeneral"
        Me.pagGeneral.Size = New System.Drawing.Size(1070, 262)
        Me.pagGeneral.TabIndex = 0
        Me.pagGeneral.Text = "General"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(6, 122)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(107, 17)
        Me.CiLabel2.TabIndex = 88
        Me.CiLabel2.Text = "Observaciones:"
        '
        'txtObervaciones
        '
        Me.txtObervaciones.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtObervaciones.Location = New System.Drawing.Point(116, 118)
        Me.txtObervaciones.MaxValue = New Decimal(New Integer() {256, 0, 0, 0})
        Me.txtObervaciones.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtObervaciones.Multiline = True
        Me.txtObervaciones.Name = "txtObervaciones"
        Me.txtObervaciones.Size = New System.Drawing.Size(245, 69)
        Me.txtObervaciones.TabIndex = 87
        '
        'cboPresupuesto
        '
        Me.cboPresupuesto.AutoClear = False
        Me.cboPresupuesto.AutoLock = False
        Me.cboPresupuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPresupuesto.FormattingEnabled = True
        Me.cboPresupuesto.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboPresupuesto.ItemsTable = Nothing
        Me.cboPresupuesto.Location = New System.Drawing.Point(116, 91)
        Me.cboPresupuesto.Name = "cboPresupuesto"
        Me.cboPresupuesto.Size = New System.Drawing.Size(245, 24)
        Me.cboPresupuesto.TabIndex = 70
        Me.cboPresupuesto.UIName = Nothing
        '
        'cboDepartamento
        '
        Me.cboDepartamento.AutoClear = False
        Me.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepartamento.FormattingEnabled = True
        Me.cboDepartamento.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboDepartamento.ItemsTable = Nothing
        Me.cboDepartamento.Location = New System.Drawing.Point(116, 37)
        Me.cboDepartamento.Name = "cboDepartamento"
        Me.cboDepartamento.RequiredField = True
        Me.cboDepartamento.Size = New System.Drawing.Size(245, 24)
        Me.cboDepartamento.TabIndex = 72
        Me.cboDepartamento.UIName = Nothing
        '
        'cboCentrosRecep
        '
        Me.cboCentrosRecep.AutoClear = False
        Me.cboCentrosRecep.BackColor = System.Drawing.SystemColors.Window
        Me.cboCentrosRecep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCentrosRecep.FormattingEnabled = True
        Me.cboCentrosRecep.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboCentrosRecep.ItemsTable = Nothing
        Me.cboCentrosRecep.Location = New System.Drawing.Point(116, 64)
        Me.cboCentrosRecep.Name = "cboCentrosRecep"
        Me.cboCentrosRecep.RequiredField = True
        Me.cboCentrosRecep.Size = New System.Drawing.Size(245, 24)
        Me.cboCentrosRecep.TabIndex = 68
        Me.cboCentrosRecep.UIName = Nothing
        '
        'txtProveedor
        '
        Me.txtProveedor.AnySite = False
        Me.txtProveedor.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtProveedor.EditorAssembly = "Azteca.ComprasWin"
        Me.txtProveedor.EditorClass = "Azteca.Windows.Compras.ProveedoresForm"
        Me.txtProveedor.EditorTitle = "Editar proveedores..."
        Me.txtProveedor.Key = 0
        Me.txtProveedor.Linked = False
        Me.txtProveedor.Location = New System.Drawing.Point(116, 8)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.RequiredField = True
        Me.txtProveedor.Size = New System.Drawing.Size(524, 23)
        Me.txtProveedor.TabIndex = 74
        '
        'pagRecepciones
        '
        Me.pagRecepciones.Controls.Add(Me.grdRecepciones)
        Me.pagRecepciones.Controls.Add(Me.tlbRecepciones)
        Me.pagRecepciones.ImageIndex = 1
        Me.pagRecepciones.Location = New System.Drawing.Point(1, 41)
        Me.pagRecepciones.Name = "pagRecepciones"
        Me.pagRecepciones.Size = New System.Drawing.Size(1070, 262)
        Me.pagRecepciones.TabIndex = 1
        Me.pagRecepciones.Text = "Recepciones"
        '
        'tlbRecepciones
        '
        Me.tlbRecepciones.AccessibleName = "Tool Bar"
        Me.tlbRecepciones.AutoLock = False
        Me.tlbRecepciones.AutoSize = False
        Me.tlbRecepciones.CommandHolder = Me.C1CommandHolder1
        Me.tlbRecepciones.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.btnNuevaRecepcion})
        Me.tlbRecepciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbRecepciones.Location = New System.Drawing.Point(0, 0)
        Me.tlbRecepciones.MinButtonSize = 32
        Me.tlbRecepciones.Movable = False
        Me.tlbRecepciones.Name = "tlbRecepciones"
        Me.tlbRecepciones.Size = New System.Drawing.Size(1070, 32)
        Me.tlbRecepciones.Text = "AzToolBar1"
        Me.tlbRecepciones.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tlbRecepciones.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'btnNuevaRecepcion
        '
        Me.btnNuevaRecepcion.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnNuevaRecepcion.Command = Me.cmdNuevaRecepcion
        '
        'tabPartidas
        '
        Me.tabPartidas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabPartidas.Controls.Add(Me.pagArticulos)
        Me.tabPartidas.Controls.Add(Me.pagServicios)
        Me.tabPartidas.ImageList = Me.imlPartidas
        Me.tabPartidas.Location = New System.Drawing.Point(12, 430)
        Me.tabPartidas.Margin = New System.Windows.Forms.Padding(4)
        Me.tabPartidas.Name = "tabPartidas"
        Me.tabPartidas.SelectedIndex = 1
        Me.tabPartidas.Size = New System.Drawing.Size(1072, 197)
        Me.tabPartidas.TabIndex = 79
        Me.tabPartidas.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabPartidas.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabPartidas.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagArticulos
        '
        Me.pagArticulos.Controls.Add(Me.cboCategoriasArt)
        Me.pagArticulos.Controls.Add(Me.grdArticulos)
        Me.pagArticulos.ImageIndex = 0
        Me.pagArticulos.Location = New System.Drawing.Point(1, 41)
        Me.pagArticulos.Name = "pagArticulos"
        Me.pagArticulos.Size = New System.Drawing.Size(1070, 155)
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
        Me.pagServicios.Size = New System.Drawing.Size(1070, 155)
        Me.pagServicios.TabIndex = 1
        Me.pagServicios.Text = "Servicios"
        '
        'cmsReimpresion
        '
        Me.cmsReimpresion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReimpresiónDeCódigoDeBarrasToolStripMenuItem})
        Me.cmsReimpresion.Name = "cmsReimpresion"
        Me.cmsReimpresion.Size = New System.Drawing.Size(302, 28)
        '
        'ReimpresiónDeCódigoDeBarrasToolStripMenuItem
        '
        Me.ReimpresiónDeCódigoDeBarrasToolStripMenuItem.Name = "ReimpresiónDeCódigoDeBarrasToolStripMenuItem"
        Me.ReimpresiónDeCódigoDeBarrasToolStripMenuItem.Size = New System.Drawing.Size(301, 24)
        Me.ReimpresiónDeCódigoDeBarrasToolStripMenuItem.Text = "Reimpresión de Código de Barras"
        '
        'OrdenesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 661)
        Me.Controls.Add(Me.tabOrden)
        Me.Controls.Add(Me.tabPartidas)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "OrdenesForm"
        Me.Text = "OrdenesForm"
        Me.Controls.SetChildIndex(Me.tabPartidas, 0)
        Me.Controls.SetChildIndex(Me.tabOrden, 0)
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdRecepciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsRecepciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCategoriasArt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCategoriasArt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCategoriasServ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCategoriasServ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabOrden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabOrden.ResumeLayout(False)
        Me.pagGeneral.ResumeLayout(False)
        Me.pagGeneral.PerformLayout()
        Me.pagRecepciones.ResumeLayout(False)
        CType(Me.tabPartidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPartidas.ResumeLayout(False)
        Me.pagArticulos.ResumeLayout(False)
        Me.pagServicios.ResumeLayout(False)
        Me.cmsReimpresion.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LicenseModule = Kernel.Licensing.LicenseModule.Purchasing
        Facade = New OrdenFacade
        SetDocumentType("OrdenCompra")
    End Sub
    Friend WithEvents cboCentrosRecep As Azteca.Windows.Compras.CentrosRecepcionComboBox
    Friend WithEvents lblCentroRecepcion As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblDepartamento As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboPresupuesto As Azteca.Windows.Compras.PresupuestoComboBox
    Friend WithEvents cboDepartamento As Azteca.Windows.Compras.DepartamentoComboBox
    Friend WithEvents lblPresupuesto As Azteca.Windows.Controls.CILabel
    Friend WithEvents imlOrden As System.Windows.Forms.ImageList
    Friend WithEvents bsArticulos As System.Windows.Forms.BindingSource
    Friend WithEvents bsServicios As System.Windows.Forms.BindingSource
    Friend WithEvents imlPartidas As System.Windows.Forms.ImageList
    Friend WithEvents grdArticulos As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents grdServicios As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents grdRecepciones As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents bsRecepciones As System.Windows.Forms.BindingSource
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtProveedor As Azteca.Windows.Compras.ProveedoresSelector
    Friend WithEvents cboDivisa As Azteca.Windows.Contabilidad.DivisasComboBox
    Friend WithEvents CiLabel13 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtTotal As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtDescuentos As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtRetenciones As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtImpuestos As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtSubTotal As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel8 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel7 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel6 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel5 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
    Friend WithEvents bsCategoriasArt As System.Windows.Forms.BindingSource
    Friend WithEvents bsCategoriasServ As System.Windows.Forms.BindingSource
    Friend WithEvents cboCategoriasArt As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents cboCategoriasServ As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents cmdNuevaRecepcion As C1.Win.C1Command.C1Command
    Friend WithEvents tabOrden As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagGeneral As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagRecepciones As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents tlbRecepciones As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents btnNuevaRecepcion As C1.Win.C1Command.C1CommandLink
    Friend WithEvents tabPartidas As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagArticulos As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagServicios As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtObervaciones As Azteca.Windows.Controls.CITextBox
    Friend WithEvents cmsReimpresion As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ReimpresiónDeCódigoDeBarrasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
