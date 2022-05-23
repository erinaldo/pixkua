<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArticulosVentaForm
    Inherits Azteca.Windows.Ventas.ArticulosForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ArticulosVentaForm))
        Dim Style9 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style10 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style11 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style12 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style13 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style14 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style15 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style16 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Me.imlArticulos = New System.Windows.Forms.ImageList(Me.components)
        Me.pagGeneral = New System.Windows.Forms.TabPage()
        Me.cboMarca = New Azteca.Windows.Ventas.MarcasComboBox()
        Me.chkActivo = New Azteca.Windows.Controls.CICheckBox()
        Me.txtEstCom = New Azteca.Windows.Ventas.EstructuraComercialSelector()
        Me.txtModelo = New Azteca.Windows.Controls.CITextBox()
        Me.cboTipoUnidad = New Azteca.Windows.Inventario.TiposUnidadComboBox()
        Me.cboUnidadMedida = New Azteca.Windows.Inventario.UnidadesMedidaComboBox()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel5 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.pagPresentaciones = New System.Windows.Forms.TabPage()
        Me.grdPresentaciones = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsPresentaciones = New System.Windows.Forms.BindingSource(Me.components)
        Me.tlbPresentaciones = New Azteca.Windows.Controls.CIToolBar()
        Me.btnAddPresentacion = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnZonas = New System.Windows.Forms.ToolStripButton()
        Me.pagClasificaciones = New System.Windows.Forms.TabPage()
        Me.cboClasificaciones = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.bsClasificaciones = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdClasificaciones = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsGruposClasif = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grdPresentaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPresentaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlbPresentaciones.SuspendLayout()
        CType(Me.cboClasificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsClasificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdClasificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsGruposClasif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'pagGeneral
        '
        Me.pagGeneral.ImageKey = "General"
        Me.pagGeneral.Location = New System.Drawing.Point(4, 39)
        Me.pagGeneral.Name = "pagGeneral"
        Me.pagGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.pagGeneral.Size = New System.Drawing.Size(652, 265)
        Me.pagGeneral.TabIndex = 0
        Me.pagGeneral.Text = "General"
        Me.pagGeneral.UseVisualStyleBackColor = True
        '
        'cboMarca
        '
        Me.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMarca.FormattingEnabled = True
        Me.cboMarca.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboMarca.ItemsTable = Nothing
        Me.cboMarca.Location = New System.Drawing.Point(112, 81)
        Me.cboMarca.Name = "cboMarca"
        Me.cboMarca.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboMarca.Size = New System.Drawing.Size(208, 21)
        Me.cboMarca.TabIndex = 6
        Me.cboMarca.UIName = Nothing
        '
        'chkActivo
        '
        Me.chkActivo.AutoClear = False
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.Location = New System.Drawing.Point(112, 137)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 11
        Me.chkActivo.Text = "Activa"
        Me.chkActivo.UseVisualStyleBackColor = True
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
        Me.txtEstCom.Location = New System.Drawing.Point(112, 108)
        Me.txtEstCom.Name = "txtEstCom"
        Me.txtEstCom.RequiredField = True
        Me.txtEstCom.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.txtEstCom.Size = New System.Drawing.Size(353, 23)
        Me.txtEstCom.TabIndex = 10
        Me.txtEstCom.UIName = "Estructura Comercial"
        '
        'txtModelo
        '
        Me.txtModelo.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtModelo.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtModelo.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtModelo.Location = New System.Drawing.Point(377, 81)
        Me.txtModelo.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtModelo.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(88, 20)
        Me.txtModelo.TabIndex = 8
        '
        'cboTipoUnidad
        '
        Me.cboTipoUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoUnidad.FormattingEnabled = True
        Me.cboTipoUnidad.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboTipoUnidad.ItemsTable = Nothing
        Me.cboTipoUnidad.Location = New System.Drawing.Point(112, 54)
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
        Me.cboUnidadMedida.Location = New System.Drawing.Point(249, 53)
        Me.cboUnidadMedida.Name = "cboUnidadMedida"
        Me.cboUnidadMedida.RequiredField = True
        Me.cboUnidadMedida.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboUnidadMedida.Size = New System.Drawing.Size(216, 21)
        Me.cboUnidadMedida.TabIndex = 4
        Me.cboUnidadMedida.UIName = "Unidad Medida"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(112, 28)
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
        Me.CiLabel5.Location = New System.Drawing.Point(16, 111)
        Me.CiLabel5.Name = "CiLabel5"
        Me.CiLabel5.Size = New System.Drawing.Size(77, 13)
        Me.CiLabel5.TabIndex = 9
        Me.CiLabel5.Text = "Est. Comercial:"
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.Location = New System.Drawing.Point(326, 84)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(45, 13)
        Me.CiLabel4.TabIndex = 7
        Me.CiLabel4.Text = "Modelo:"
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(16, 84)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(40, 13)
        Me.CiLabel3.TabIndex = 5
        Me.CiLabel3.Text = "Marca:"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(16, 56)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(90, 13)
        Me.CiLabel2.TabIndex = 2
        Me.CiLabel2.Text = "Unidad de Venta:"
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(16, 31)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(47, 13)
        Me.CiLabel1.TabIndex = 0
        Me.CiLabel1.Text = "Nombre:"
        '
        'pagPresentaciones
        '
        Me.pagPresentaciones.ImageKey = "Presentaciones"
        Me.pagPresentaciones.Location = New System.Drawing.Point(4, 39)
        Me.pagPresentaciones.Name = "pagPresentaciones"
        Me.pagPresentaciones.Padding = New System.Windows.Forms.Padding(3)
        Me.pagPresentaciones.Size = New System.Drawing.Size(652, 265)
        Me.pagPresentaciones.TabIndex = 1
        Me.pagPresentaciones.Text = "Presentaciones"
        Me.pagPresentaciones.UseVisualStyleBackColor = True
        '
        'grdPresentaciones
        '
        Me.grdPresentaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPresentaciones.DataSource = Me.bsPresentaciones
        Me.grdPresentaciones.FetchRowStyles = True
        Me.grdPresentaciones.FilterBar = True
        Me.grdPresentaciones.IDCatalogField = "IdArticuloStock"
        Me.grdPresentaciones.Images.Add(CType(resources.GetObject("grdPresentaciones.Images"), System.Drawing.Image))
        Me.grdPresentaciones.Location = New System.Drawing.Point(6, 45)
        Me.grdPresentaciones.Name = "grdPresentaciones"
        Me.grdPresentaciones.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdPresentaciones.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdPresentaciones.PreviewInfo.ZoomFactor = 75.0R
        Me.grdPresentaciones.PrintInfo.PageSettings = CType(resources.GetObject("grdPresentaciones.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdPresentaciones.Size = New System.Drawing.Size(640, 216)
        Me.grdPresentaciones.TabIndex = 1
        Me.grdPresentaciones.PropBag = resources.GetString("grdPresentaciones.PropBag")
        '
        'bsPresentaciones
        '
        Me.bsPresentaciones.AllowNew = False
        '
        'tlbPresentaciones
        '
        Me.tlbPresentaciones.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tlbPresentaciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAddPresentacion, Me.ToolStripSeparator1, Me.btnZonas})
        Me.tlbPresentaciones.Location = New System.Drawing.Point(3, 3)
        Me.tlbPresentaciones.Name = "tlbPresentaciones"
        Me.tlbPresentaciones.Size = New System.Drawing.Size(646, 25)
        Me.tlbPresentaciones.TabIndex = 0
        '
        'btnAddPresentacion
        '
        Me.btnAddPresentacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAddPresentacion.Name = "btnAddPresentacion"
        Me.btnAddPresentacion.Size = New System.Drawing.Size(124, 22)
        Me.btnAddPresentacion.Text = "Agregar Presentación"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnZonas
        '
        Me.btnZonas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnZonas.Name = "btnZonas"
        Me.btnZonas.Size = New System.Drawing.Size(92, 22)
        Me.btnZonas.Text = "Zonas de Venta"
        '
        'pagClasificaciones
        '
        Me.pagClasificaciones.ImageIndex = 3
        Me.pagClasificaciones.Location = New System.Drawing.Point(4, 39)
        Me.pagClasificaciones.Name = "pagClasificaciones"
        Me.pagClasificaciones.Size = New System.Drawing.Size(652, 265)
        Me.pagClasificaciones.TabIndex = 2
        Me.pagClasificaciones.Text = "Clasificaciones"
        Me.pagClasificaciones.UseVisualStyleBackColor = True
        '
        'cboClasificaciones
        '
        Me.cboClasificaciones.AllowColMove = True
        Me.cboClasificaciones.AllowColSelect = True
        Me.cboClasificaciones.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboClasificaciones.AlternatingRows = False
        Me.cboClasificaciones.CaptionStyle = Style9
        Me.cboClasificaciones.ColumnCaptionHeight = 17
        Me.cboClasificaciones.ColumnFooterHeight = 17
        Me.cboClasificaciones.DataSource = Me.bsClasificaciones
        Me.cboClasificaciones.DisplayMember = "Nombre"
        Me.cboClasificaciones.EvenRowStyle = Style10
        Me.cboClasificaciones.ExtendRightColumn = True
        Me.cboClasificaciones.FetchRowStyles = False
        Me.cboClasificaciones.FooterStyle = Style11
        Me.cboClasificaciones.HeadingStyle = Style12
        Me.cboClasificaciones.HighLightRowStyle = Style13
        Me.cboClasificaciones.Images.Add(CType(resources.GetObject("cboClasificaciones.Images"), System.Drawing.Image))
        Me.cboClasificaciones.Location = New System.Drawing.Point(131, 59)
        Me.cboClasificaciones.Name = "cboClasificaciones"
        Me.cboClasificaciones.OddRowStyle = Style14
        Me.cboClasificaciones.RecordSelectorStyle = Style15
        Me.cboClasificaciones.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboClasificaciones.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboClasificaciones.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboClasificaciones.ScrollTips = False
        Me.cboClasificaciones.Size = New System.Drawing.Size(439, 179)
        Me.cboClasificaciones.Style = Style16
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
        Me.grdClasificaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdClasificaciones.DataSource = Me.bsGruposClasif
        Me.grdClasificaciones.ExtendRightColumn = True
        Me.grdClasificaciones.FetchRowStyles = True
        Me.grdClasificaciones.Images.Add(CType(resources.GetObject("grdClasificaciones.Images"), System.Drawing.Image))
        Me.grdClasificaciones.Location = New System.Drawing.Point(3, 5)
        Me.grdClasificaciones.Name = "grdClasificaciones"
        Me.grdClasificaciones.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdClasificaciones.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdClasificaciones.PreviewInfo.ZoomFactor = 75.0R
        Me.grdClasificaciones.PrintInfo.PageSettings = CType(resources.GetObject("grdClasificaciones.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdClasificaciones.Size = New System.Drawing.Size(646, 259)
        Me.grdClasificaciones.TabIndex = 2
        Me.grdClasificaciones.Text = "AzTrueDBGrid1"
        Me.grdClasificaciones.PropBag = resources.GetString("grdClasificaciones.PropBag")
        '
        'ArticulosVentaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 421)
        Me.Name = "ArticulosVentaForm"
        Me.Text = "ArticulosVentaForm"
        CType(Me.grdPresentaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPresentaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlbPresentaciones.ResumeLayout(False)
        Me.tlbPresentaciones.PerformLayout()
        CType(Me.cboClasificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsClasificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdClasificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsGruposClasif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboMarca As Azteca.Windows.Ventas.MarcasComboBox
    Friend WithEvents chkActivo As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents txtEstCom As Azteca.Windows.Ventas.EstructuraComercialSelector
    Friend WithEvents txtModelo As Azteca.Windows.Controls.CITextBox
    Friend WithEvents cboTipoUnidad As Azteca.Windows.Inventario.TiposUnidadComboBox
    Friend WithEvents cboUnidadMedida As Azteca.Windows.Inventario.UnidadesMedidaComboBox
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel5 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents grdPresentaciones As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents bsPresentaciones As System.Windows.Forms.BindingSource
    Friend WithEvents tlbPresentaciones As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnAddPresentacion As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnZonas As System.Windows.Forms.ToolStripButton
    Friend WithEvents cboClasificaciones As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents bsClasificaciones As System.Windows.Forms.BindingSource
    Friend WithEvents grdClasificaciones As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents bsGruposClasif As System.Windows.Forms.BindingSource
    Friend WithEvents imlArticulos As System.Windows.Forms.ImageList
    Friend WithEvents pagGeneral As System.Windows.Forms.TabPage
    Friend WithEvents pagPresentaciones As System.Windows.Forms.TabPage
    Friend WithEvents pagClasificaciones As System.Windows.Forms.TabPage
End Class
