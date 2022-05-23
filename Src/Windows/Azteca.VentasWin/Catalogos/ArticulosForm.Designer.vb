<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArticulosForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ArticulosForm))
        Dim Style1 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style2 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style3 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style4 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style5 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style6 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style7 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style8 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Me.txtModelo = New Azteca.Windows.Controls.CITextBox()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel5 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.grdPresentaciones = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsPresentaciones = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboClasificaciones = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.bsClasificaciones = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdClasificaciones = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsGruposClasif = New System.Windows.Forms.BindingSource(Me.components)
        Me.imlArticulos = New System.Windows.Forms.ImageList(Me.components)
        Me.tabArticulos = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagGeneral = New C1.Win.C1Command.C1DockingTabPage()
        Me.cboTipoUnidad = New Azteca.Windows.Inventario.TiposUnidadComboBox()
        Me.cboUnidadMedida = New Azteca.Windows.Inventario.UnidadesMedidaComboBox()
        Me.pagPresentaciones = New C1.Win.C1Command.C1DockingTabPage()
        Me.AzToolBar1 = New Azteca.Windows.Controls.AZToolBar()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdAgregarPresentacion = New C1.Win.C1Command.C1Command()
        Me.cmdZonasVenta = New C1.Win.C1Command.C1Command()
        Me.cmdAdminTallasColores = New C1.Win.C1Command.C1Command()
        Me.btnAgregarPresentacion = New C1.Win.C1Command.C1CommandLink()
        Me.btnZonasVenta = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.pagClasificaciones = New C1.Win.C1Command.C1DockingTabPage()
        Me.cboMarca = New Azteca.Windows.Ventas.MarcasComboBox()
        Me.txtEstCom = New Azteca.Windows.Ventas.EstructuraComercialSelector()
        CType(Me.grdPresentaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPresentaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboClasificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsClasificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdClasificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsGruposClasif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabArticulos.SuspendLayout()
        Me.pagGeneral.SuspendLayout()
        Me.pagPresentaciones.SuspendLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagClasificaciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtModelo
        '
        Me.txtModelo.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtModelo.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtModelo.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtModelo.Location = New System.Drawing.Point(382, 69)
        Me.txtModelo.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtModelo.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(88, 20)
        Me.txtModelo.TabIndex = 8
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(117, 16)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(353, 20)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.UIName = "Nombre"
        '
        'CiLabel5
        '
        Me.CiLabel5.AutoSize = True
        Me.CiLabel5.Location = New System.Drawing.Point(21, 99)
        Me.CiLabel5.Name = "CiLabel5"
        Me.CiLabel5.Size = New System.Drawing.Size(77, 13)
        Me.CiLabel5.TabIndex = 9
        Me.CiLabel5.Text = "Est. Comercial:"
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.Location = New System.Drawing.Point(331, 72)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(45, 13)
        Me.CiLabel4.TabIndex = 7
        Me.CiLabel4.Text = "Modelo:"
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(21, 72)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(40, 13)
        Me.CiLabel3.TabIndex = 5
        Me.CiLabel3.Text = "Marca:"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(21, 44)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(90, 13)
        Me.CiLabel2.TabIndex = 2
        Me.CiLabel2.Text = "Unidad de Venta:"
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(21, 19)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(47, 13)
        Me.CiLabel1.TabIndex = 0
        Me.CiLabel1.Text = "Nombre:"
        '
        'grdPresentaciones
        '
        Me.grdPresentaciones.DataSource = Me.bsPresentaciones
        Me.grdPresentaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdPresentaciones.FetchRowStyles = True
        Me.grdPresentaciones.FilterBar = True
        Me.grdPresentaciones.IDCatalogField = "IdArticuloStock"
        Me.grdPresentaciones.Images.Add(CType(resources.GetObject("grdPresentaciones.Images"), System.Drawing.Image))
        Me.grdPresentaciones.Location = New System.Drawing.Point(0, 38)
        Me.grdPresentaciones.Name = "grdPresentaciones"
        Me.grdPresentaciones.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdPresentaciones.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdPresentaciones.PreviewInfo.ZoomFactor = 75.0R
        Me.grdPresentaciones.PrintInfo.PageSettings = CType(resources.GetObject("grdPresentaciones.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdPresentaciones.Size = New System.Drawing.Size(660, 280)
        Me.grdPresentaciones.TabIndex = 1
        Me.grdPresentaciones.PropBag = resources.GetString("grdPresentaciones.PropBag")
        '
        'bsPresentaciones
        '
        Me.bsPresentaciones.AllowNew = False
        '
        'cboClasificaciones
        '
        Me.cboClasificaciones.AllowColMove = True
        Me.cboClasificaciones.AllowColSelect = True
        Me.cboClasificaciones.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboClasificaciones.AlternatingRows = False
        Me.cboClasificaciones.CaptionStyle = Style1
        Me.cboClasificaciones.ColumnCaptionHeight = 17
        Me.cboClasificaciones.ColumnFooterHeight = 17
        Me.cboClasificaciones.DataSource = Me.bsClasificaciones
        Me.cboClasificaciones.DisplayMember = "Nombre"
        Me.cboClasificaciones.EvenRowStyle = Style2
        Me.cboClasificaciones.ExtendRightColumn = True
        Me.cboClasificaciones.FetchRowStyles = False
        Me.cboClasificaciones.FooterStyle = Style3
        Me.cboClasificaciones.HeadingStyle = Style4
        Me.cboClasificaciones.HighLightRowStyle = Style5
        Me.cboClasificaciones.Images.Add(CType(resources.GetObject("cboClasificaciones.Images"), System.Drawing.Image))
        Me.cboClasificaciones.Location = New System.Drawing.Point(139, 70)
        Me.cboClasificaciones.Name = "cboClasificaciones"
        Me.cboClasificaciones.OddRowStyle = Style6
        Me.cboClasificaciones.RecordSelectorStyle = Style7
        Me.cboClasificaciones.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboClasificaciones.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboClasificaciones.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboClasificaciones.ScrollTips = False
        Me.cboClasificaciones.Size = New System.Drawing.Size(439, 179)
        Me.cboClasificaciones.Style = Style8
        Me.cboClasificaciones.TabIndex = 3
        Me.cboClasificaciones.TabStop = False
        Me.cboClasificaciones.Text = "C1TrueDBDropdown1"
        Me.cboClasificaciones.ValueMember = "IdClasificacion"
        Me.cboClasificaciones.ValueTranslate = True
        Me.cboClasificaciones.Visible = False
        Me.cboClasificaciones.PropBag = resources.GetString("cboClasificaciones.PropBag")
        '
        'grdClasificaciones
        '
        Me.grdClasificaciones.DataSource = Me.bsGruposClasif
        Me.grdClasificaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdClasificaciones.ExtendRightColumn = True
        Me.grdClasificaciones.FetchRowStyles = True
        Me.grdClasificaciones.Images.Add(CType(resources.GetObject("grdClasificaciones.Images"), System.Drawing.Image))
        Me.grdClasificaciones.Location = New System.Drawing.Point(0, 0)
        Me.grdClasificaciones.Name = "grdClasificaciones"
        Me.grdClasificaciones.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdClasificaciones.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdClasificaciones.PreviewInfo.ZoomFactor = 75.0R
        Me.grdClasificaciones.PrintInfo.PageSettings = CType(resources.GetObject("grdClasificaciones.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdClasificaciones.Size = New System.Drawing.Size(660, 318)
        Me.grdClasificaciones.TabIndex = 2
        Me.grdClasificaciones.Text = "AzTrueDBGrid1"
        Me.grdClasificaciones.PropBag = resources.GetString("grdClasificaciones.PropBag")
        '
        'imlArticulos
        '
        Me.imlArticulos.ImageStream = CType(resources.GetObject("imlArticulos.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlArticulos.TransparentColor = System.Drawing.Color.Transparent
        Me.imlArticulos.Images.SetKeyName(0, "General")
        Me.imlArticulos.Images.SetKeyName(1, "Presentaciones")
        Me.imlArticulos.Images.SetKeyName(2, "market_32.png")
        Me.imlArticulos.Images.SetKeyName(3, "Clasificaciones.png")
        '
        'tabArticulos
        '
        Me.tabArticulos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabArticulos.Controls.Add(Me.pagGeneral)
        Me.tabArticulos.Controls.Add(Me.pagPresentaciones)
        Me.tabArticulos.Controls.Add(Me.pagClasificaciones)
        Me.tabArticulos.ImageList = Me.imlArticulos
        Me.tabArticulos.Location = New System.Drawing.Point(10, 90)
        Me.tabArticulos.Name = "tabArticulos"
        Me.tabArticulos.SelectedIndex = 2
        Me.tabArticulos.Size = New System.Drawing.Size(662, 360)
        Me.tabArticulos.TabIndex = 32
        Me.tabArticulos.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabArticulos.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabArticulos.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagGeneral
        '
        Me.pagGeneral.Controls.Add(Me.cboMarca)
        Me.pagGeneral.Controls.Add(Me.CiLabel1)
        Me.pagGeneral.Controls.Add(Me.CiLabel2)
        Me.pagGeneral.Controls.Add(Me.txtEstCom)
        Me.pagGeneral.Controls.Add(Me.CiLabel3)
        Me.pagGeneral.Controls.Add(Me.txtModelo)
        Me.pagGeneral.Controls.Add(Me.CiLabel4)
        Me.pagGeneral.Controls.Add(Me.cboTipoUnidad)
        Me.pagGeneral.Controls.Add(Me.CiLabel5)
        Me.pagGeneral.Controls.Add(Me.cboUnidadMedida)
        Me.pagGeneral.Controls.Add(Me.txtNombre)
        Me.pagGeneral.ImageIndex = 0
        Me.pagGeneral.Location = New System.Drawing.Point(1, 41)
        Me.pagGeneral.Name = "pagGeneral"
        Me.pagGeneral.Size = New System.Drawing.Size(660, 318)
        Me.pagGeneral.TabIndex = 0
        Me.pagGeneral.Text = "General"
        '
        'cboTipoUnidad
        '
        Me.cboTipoUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoUnidad.FormattingEnabled = True
        Me.cboTipoUnidad.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboTipoUnidad.ItemsTable = Nothing
        Me.cboTipoUnidad.Location = New System.Drawing.Point(117, 42)
        Me.cboTipoUnidad.Name = "cboTipoUnidad"
        Me.cboTipoUnidad.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboTipoUnidad.Size = New System.Drawing.Size(131, 21)
        Me.cboTipoUnidad.TabIndex = 3
        Me.cboTipoUnidad.UIName = Nothing
        '
        'cboUnidadMedida
        '
        Me.cboUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnidadMedida.FormattingEnabled = True
        Me.cboUnidadMedida.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboUnidadMedida.ItemsTable = Nothing
        Me.cboUnidadMedida.Location = New System.Drawing.Point(254, 41)
        Me.cboUnidadMedida.Name = "cboUnidadMedida"
        Me.cboUnidadMedida.RequiredField = True
        Me.cboUnidadMedida.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboUnidadMedida.Size = New System.Drawing.Size(216, 21)
        Me.cboUnidadMedida.TabIndex = 4
        Me.cboUnidadMedida.UIName = "Unidad Medida"
        '
        'pagPresentaciones
        '
        Me.pagPresentaciones.Controls.Add(Me.grdPresentaciones)
        Me.pagPresentaciones.Controls.Add(Me.AzToolBar1)
        Me.pagPresentaciones.ImageIndex = 2
        Me.pagPresentaciones.Location = New System.Drawing.Point(1, 41)
        Me.pagPresentaciones.Name = "pagPresentaciones"
        Me.pagPresentaciones.Size = New System.Drawing.Size(660, 318)
        Me.pagPresentaciones.TabIndex = 1
        Me.pagPresentaciones.Text = "Presentaciones"
        '
        'AzToolBar1
        '
        Me.AzToolBar1.AccessibleName = "Tool Bar"
        Me.AzToolBar1.AutoSize = False
        Me.AzToolBar1.CommandHolder = Me.C1CommandHolder1
        Me.AzToolBar1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.btnAgregarPresentacion, Me.btnZonasVenta, Me.C1CommandLink1})
        Me.AzToolBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.AzToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.AzToolBar1.MinButtonSize = 32
        Me.AzToolBar1.Movable = False
        Me.AzToolBar1.Name = "AzToolBar1"
        Me.AzToolBar1.Size = New System.Drawing.Size(660, 38)
        Me.AzToolBar1.Text = "AzToolBar1"
        Me.AzToolBar1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdAgregarPresentacion)
        Me.C1CommandHolder1.Commands.Add(Me.cmdZonasVenta)
        Me.C1CommandHolder1.Commands.Add(Me.cmdAdminTallasColores)
        Me.C1CommandHolder1.Owner = Me
        '
        'cmdAgregarPresentacion
        '
        Me.cmdAgregarPresentacion.Image = CType(resources.GetObject("cmdAgregarPresentacion.Image"), System.Drawing.Image)
        Me.cmdAgregarPresentacion.Name = "cmdAgregarPresentacion"
        Me.cmdAgregarPresentacion.ShortcutText = ""
        Me.cmdAgregarPresentacion.Text = "Agregar Presentación"
        '
        'cmdZonasVenta
        '
        Me.cmdZonasVenta.Image = CType(resources.GetObject("cmdZonasVenta.Image"), System.Drawing.Image)
        Me.cmdZonasVenta.Name = "cmdZonasVenta"
        Me.cmdZonasVenta.ShortcutText = ""
        Me.cmdZonasVenta.Text = "Zonas de Venta"
        '
        'cmdAdminTallasColores
        '
        Me.cmdAdminTallasColores.Image = CType(resources.GetObject("cmdAdminTallasColores.Image"), System.Drawing.Image)
        Me.cmdAdminTallasColores.Name = "cmdAdminTallasColores"
        Me.cmdAdminTallasColores.ShortcutText = ""
        Me.cmdAdminTallasColores.Text = "Ayudante para Administrar Tallas y Colores"
        '
        'btnAgregarPresentacion
        '
        Me.btnAgregarPresentacion.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnAgregarPresentacion.Command = Me.cmdAgregarPresentacion
        '
        'btnZonasVenta
        '
        Me.btnZonasVenta.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnZonasVenta.Command = Me.cmdZonasVenta
        Me.btnZonasVenta.Delimiter = True
        Me.btnZonasVenta.SortOrder = 1
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink1.Command = Me.cmdAdminTallasColores
        Me.C1CommandLink1.Delimiter = True
        Me.C1CommandLink1.SortOrder = 2
        '
        'pagClasificaciones
        '
        Me.pagClasificaciones.Controls.Add(Me.cboClasificaciones)
        Me.pagClasificaciones.Controls.Add(Me.grdClasificaciones)
        Me.pagClasificaciones.ImageIndex = 3
        Me.pagClasificaciones.Location = New System.Drawing.Point(1, 41)
        Me.pagClasificaciones.Name = "pagClasificaciones"
        Me.pagClasificaciones.Size = New System.Drawing.Size(660, 318)
        Me.pagClasificaciones.TabIndex = 2
        Me.pagClasificaciones.Text = "Clasificaciones"
        '
        'cboMarca
        '
        Me.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMarca.FormattingEnabled = True
        Me.cboMarca.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboMarca.ItemsTable = Nothing
        Me.cboMarca.Location = New System.Drawing.Point(117, 69)
        Me.cboMarca.Name = "cboMarca"
        Me.cboMarca.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboMarca.Size = New System.Drawing.Size(208, 21)
        Me.cboMarca.TabIndex = 6
        Me.cboMarca.UIName = Nothing
        '
        'txtEstCom
        '
        Me.txtEstCom.AnySite = False
        Me.txtEstCom.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtEstCom.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtEstCom.EditorAssembly = "Azteca.VentasWin"
        Me.txtEstCom.EditorClass = "Azteca.Windows.Ventas.EstComercialForm"
        Me.txtEstCom.EditorTitle = "Editar nodo de estructura comercial..."
        Me.txtEstCom.Key = 0
        Me.txtEstCom.Linked = False
        Me.txtEstCom.Location = New System.Drawing.Point(117, 96)
        Me.txtEstCom.Name = "txtEstCom"
        Me.txtEstCom.RequiredField = True
        Me.txtEstCom.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.txtEstCom.Size = New System.Drawing.Size(353, 23)
        Me.txtEstCom.TabIndex = 10
        Me.txtEstCom.UIName = "Estructura Comercial"
        '
        'ArticulosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 478)
        Me.Controls.Add(Me.tabArticulos)
        Me.KeyMode = Azteca.Windows.Forms.BusinessForms.CatalogForm.UserKeyMode.UserDefined
        Me.Name = "ArticulosForm"
        Me.Text = "ArticulosForm"
        Me.Controls.SetChildIndex(Me.tabArticulos, 0)
        CType(Me.grdPresentaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPresentaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboClasificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsClasificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdClasificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsGruposClasif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabArticulos.ResumeLayout(False)
        Me.pagGeneral.ResumeLayout(False)
        Me.pagGeneral.PerformLayout()
        Me.pagPresentaciones.ResumeLayout(False)
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagClasificaciones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New ArticuloFacade
    End Sub
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel5 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtModelo As Azteca.Windows.Controls.CITextBox
    Friend WithEvents cboTipoUnidad As Azteca.Windows.Inventario.TiposUnidadComboBox
    Friend WithEvents cboUnidadMedida As Azteca.Windows.Inventario.UnidadesMedidaComboBox
    Friend WithEvents txtEstCom As Azteca.Windows.Ventas.EstructuraComercialSelector
    Friend WithEvents cboMarca As Azteca.Windows.Ventas.MarcasComboBox
    Friend WithEvents grdPresentaciones As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents cboClasificaciones As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents grdClasificaciones As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents tabArticulos As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagGeneral As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagPresentaciones As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents AzToolBar1 As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents cmdAgregarPresentacion As C1.Win.C1Command.C1Command
    Friend WithEvents cmdZonasVenta As C1.Win.C1Command.C1Command
    Friend WithEvents btnAgregarPresentacion As C1.Win.C1Command.C1CommandLink
    Friend WithEvents pagClasificaciones As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents btnZonasVenta As C1.Win.C1Command.C1CommandLink
    Private WithEvents imlArticulos As System.Windows.Forms.ImageList
    Private WithEvents bsPresentaciones As System.Windows.Forms.BindingSource
    Private WithEvents bsClasificaciones As System.Windows.Forms.BindingSource
    Private WithEvents bsGruposClasif As System.Windows.Forms.BindingSource
    Friend WithEvents cmdAdminTallasColores As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
End Class
