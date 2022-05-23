<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VistaContableForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VistaContableForm))
        Me.lblDescripcion = New Azteca.Windows.Controls.CILabel()
        Me.lblObjeto = New Azteca.Windows.Controls.CILabel()
        Me.txtDescripcion = New Azteca.Windows.Controls.CITextBox()
        Me.txtObjeto = New Azteca.Windows.Controls.CITextBox()
        Me.tabDetalle = New Azteca.Windows.Controls.CITab()
        Me.tabEntidades = New System.Windows.Forms.TabPage()
        Me.gbxEntidades = New Azteca.Windows.Controls.CIGroupBox()
        Me.grdEntidad = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsEntidades = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabImportes = New System.Windows.Forms.TabPage()
        Me.gbxImportes = New Azteca.Windows.Controls.CIGroupBox()
        Me.grdImportes = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsImportes = New System.Windows.Forms.BindingSource(Me.components)
        Me.iLstTab = New System.Windows.Forms.ImageList(Me.components)
        Me.colColumnaEnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEntidad = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colColumnaImp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colImporte = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.txtSchema = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.txtIdObjeto = New Azteca.Windows.Controls.CITextBox()
        Me.lblCampoLLave = New Azteca.Windows.Controls.CILabel()
        Me.txtReferencia = New Azteca.Windows.Controls.CITextBox()
        Me.lblReferencia = New Azteca.Windows.Controls.CILabel()
        Me.lblDocumento = New Azteca.Windows.Controls.CILabel()
        Me.selTipoDocto = New Azteca.Windows.Controls.DocumentoTipoSelector()
        Me.tabDetalle.SuspendLayout()
        Me.tabEntidades.SuspendLayout()
        Me.gbxEntidades.SuspendLayout()
        CType(Me.grdEntidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsEntidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabImportes.SuspendLayout()
        Me.gbxImportes.SuspendLayout()
        CType(Me.grdImportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsImportes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(43, 96)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcion.TabIndex = 18
        Me.lblDescripcion.Text = "Descripcion"
        '
        'lblObjeto
        '
        Me.lblObjeto.AutoSize = True
        Me.lblObjeto.Location = New System.Drawing.Point(43, 164)
        Me.lblObjeto.Name = "lblObjeto"
        Me.lblObjeto.Size = New System.Drawing.Size(38, 13)
        Me.lblObjeto.TabIndex = 19
        Me.lblObjeto.Text = "Objeto"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtDescripcion.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtDescripcion.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtDescripcion.Location = New System.Drawing.Point(128, 93)
        Me.txtDescripcion.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDescripcion.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(373, 20)
        Me.txtDescripcion.TabIndex = 20
        '
        'txtObjeto
        '
        Me.txtObjeto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObjeto.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtObjeto.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtObjeto.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtObjeto.Location = New System.Drawing.Point(128, 161)
        Me.txtObjeto.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtObjeto.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtObjeto.Name = "txtObjeto"
        Me.txtObjeto.Size = New System.Drawing.Size(220, 20)
        Me.txtObjeto.TabIndex = 21
        '
        'tabDetalle
        '
        Me.tabDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDetalle.Controls.Add(Me.tabEntidades)
        Me.tabDetalle.Controls.Add(Me.tabImportes)
        Me.tabDetalle.ImageList = Me.iLstTab
        Me.tabDetalle.Location = New System.Drawing.Point(128, 210)
        Me.tabDetalle.Name = "tabDetalle"
        Me.tabDetalle.SelectedIndex = 0
        Me.tabDetalle.Size = New System.Drawing.Size(373, 368)
        Me.tabDetalle.TabIndex = 22
        '
        'tabEntidades
        '
        Me.tabEntidades.Controls.Add(Me.gbxEntidades)
        Me.tabEntidades.ImageIndex = 0
        Me.tabEntidades.Location = New System.Drawing.Point(4, 39)
        Me.tabEntidades.Name = "tabEntidades"
        Me.tabEntidades.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEntidades.Size = New System.Drawing.Size(365, 325)
        Me.tabEntidades.TabIndex = 0
        Me.tabEntidades.Text = "Entidades"
        Me.tabEntidades.UseVisualStyleBackColor = True
        '
        'gbxEntidades
        '
        Me.gbxEntidades.Controls.Add(Me.grdEntidad)
        Me.gbxEntidades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxEntidades.Location = New System.Drawing.Point(3, 3)
        Me.gbxEntidades.Name = "gbxEntidades"
        Me.gbxEntidades.Size = New System.Drawing.Size(359, 319)
        Me.gbxEntidades.TabIndex = 23
        Me.gbxEntidades.TabStop = False
        '
        'grdEntidad
        '
        Me.grdEntidad.AlternatingRows = True
        Me.grdEntidad.DataSource = Me.bsEntidades
        Me.grdEntidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdEntidad.Images.Add(CType(resources.GetObject("grdEntidad.Images"), System.Drawing.Image))
        Me.grdEntidad.Location = New System.Drawing.Point(3, 16)
        Me.grdEntidad.Name = "grdEntidad"
        Me.grdEntidad.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdEntidad.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdEntidad.PreviewInfo.ZoomFactor = 75.0R
        Me.grdEntidad.PrintInfo.PageSettings = CType(resources.GetObject("grdEntidad.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdEntidad.ShowDeleteButton = False
        Me.grdEntidad.ShowEditButton = False
        Me.grdEntidad.Size = New System.Drawing.Size(353, 300)
        Me.grdEntidad.TabIndex = 27
        Me.grdEntidad.PropBag = resources.GetString("grdEntidad.PropBag")
        '
        'tabImportes
        '
        Me.tabImportes.Controls.Add(Me.gbxImportes)
        Me.tabImportes.ImageIndex = 1
        Me.tabImportes.Location = New System.Drawing.Point(4, 39)
        Me.tabImportes.Name = "tabImportes"
        Me.tabImportes.Padding = New System.Windows.Forms.Padding(3)
        Me.tabImportes.Size = New System.Drawing.Size(365, 348)
        Me.tabImportes.TabIndex = 1
        Me.tabImportes.Text = "Importes"
        Me.tabImportes.UseVisualStyleBackColor = True
        '
        'gbxImportes
        '
        Me.gbxImportes.Controls.Add(Me.grdImportes)
        Me.gbxImportes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxImportes.Location = New System.Drawing.Point(3, 3)
        Me.gbxImportes.Name = "gbxImportes"
        Me.gbxImportes.Size = New System.Drawing.Size(359, 342)
        Me.gbxImportes.TabIndex = 24
        Me.gbxImportes.TabStop = False
        '
        'grdImportes
        '
        Me.grdImportes.AlternatingRows = True
        Me.grdImportes.DataSource = Me.bsImportes
        Me.grdImportes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdImportes.Images.Add(CType(resources.GetObject("grdImportes.Images"), System.Drawing.Image))
        Me.grdImportes.Location = New System.Drawing.Point(3, 16)
        Me.grdImportes.Name = "grdImportes"
        Me.grdImportes.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdImportes.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdImportes.PreviewInfo.ZoomFactor = 75.0R
        Me.grdImportes.PrintInfo.PageSettings = CType(resources.GetObject("grdImportes.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdImportes.ShowDeleteButton = False
        Me.grdImportes.ShowEditButton = False
        Me.grdImportes.Size = New System.Drawing.Size(353, 323)
        Me.grdImportes.TabIndex = 27
        Me.grdImportes.PropBag = resources.GetString("grdImportes.PropBag")
        '
        'iLstTab
        '
        Me.iLstTab.ImageStream = CType(resources.GetObject("iLstTab.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.iLstTab.TransparentColor = System.Drawing.Color.Transparent
        Me.iLstTab.Images.SetKeyName(0, "Entidades.png")
        Me.iLstTab.Images.SetKeyName(1, "sign_dollar_32.png")
        '
        'colColumnaEnt
        '
        Me.colColumnaEnt.DataPropertyName = "Columna"
        Me.colColumnaEnt.HeaderText = "Columna"
        Me.colColumnaEnt.Name = "colColumnaEnt"
        Me.colColumnaEnt.ReadOnly = True
        '
        'colEntidad
        '
        Me.colEntidad.DataPropertyName = "Entidad"
        Me.colEntidad.HeaderText = "Entidad"
        Me.colEntidad.Name = "colEntidad"
        Me.colEntidad.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colEntidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colEntidad.Width = 150
        '
        'colColumnaImp
        '
        Me.colColumnaImp.DataPropertyName = "Columna"
        Me.colColumnaImp.HeaderText = "Columna"
        Me.colColumnaImp.Name = "colColumnaImp"
        Me.colColumnaImp.ReadOnly = True
        '
        'colImporte
        '
        Me.colImporte.DataPropertyName = "Importe"
        Me.colImporte.HeaderText = "Importe"
        Me.colImporte.Name = "colImporte"
        Me.colImporte.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colImporte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colImporte.Width = 150
        '
        'txtSchema
        '
        Me.txtSchema.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSchema.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtSchema.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtSchema.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtSchema.Location = New System.Drawing.Point(128, 138)
        Me.txtSchema.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSchema.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSchema.Name = "txtSchema"
        Me.txtSchema.Size = New System.Drawing.Size(220, 20)
        Me.txtSchema.TabIndex = 24
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(43, 141)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(46, 13)
        Me.CiLabel1.TabIndex = 23
        Me.CiLabel1.Text = "Schema"
        '
        'txtIdObjeto
        '
        Me.txtIdObjeto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIdObjeto.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtIdObjeto.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtIdObjeto.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtIdObjeto.Location = New System.Drawing.Point(128, 185)
        Me.txtIdObjeto.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtIdObjeto.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtIdObjeto.Name = "txtIdObjeto"
        Me.txtIdObjeto.Size = New System.Drawing.Size(113, 20)
        Me.txtIdObjeto.TabIndex = 26
        '
        'lblCampoLLave
        '
        Me.lblCampoLLave.AutoSize = True
        Me.lblCampoLLave.Location = New System.Drawing.Point(43, 188)
        Me.lblCampoLLave.Name = "lblCampoLLave"
        Me.lblCampoLLave.Size = New System.Drawing.Size(69, 13)
        Me.lblCampoLLave.TabIndex = 25
        Me.lblCampoLLave.Text = "Campo Llave"
        '
        'txtReferencia
        '
        Me.txtReferencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtReferencia.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtReferencia.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtReferencia.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtReferencia.Location = New System.Drawing.Point(345, 168)
        Me.txtReferencia.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtReferencia.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(156, 20)
        Me.txtReferencia.TabIndex = 28
        '
        'lblReferencia
        '
        Me.lblReferencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblReferencia.AutoSize = True
        Me.lblReferencia.Location = New System.Drawing.Point(280, 188)
        Me.lblReferencia.Name = "lblReferencia"
        Me.lblReferencia.Size = New System.Drawing.Size(59, 13)
        Me.lblReferencia.TabIndex = 27
        Me.lblReferencia.Text = "Referencia"
        '
        'lblDocumento
        '
        Me.lblDocumento.AutoSize = True
        Me.lblDocumento.Location = New System.Drawing.Point(43, 118)
        Me.lblDocumento.Name = "lblDocumento"
        Me.lblDocumento.Size = New System.Drawing.Size(62, 13)
        Me.lblDocumento.TabIndex = 30
        Me.lblDocumento.Text = "Documento"
        '
        'selTipoDocto
        '
        Me.selTipoDocto.AnySite = False
        Me.selTipoDocto.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selTipoDocto.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.selTipoDocto.EditorAssembly = "Azteca.Kernel"
        Me.selTipoDocto.EditorClass = "Azteca.Kernel.TipoDocumentoForm"
        Me.selTipoDocto.EditorTitle = "Editar Tipo de documento..."
        Me.selTipoDocto.Key = 0
        Me.selTipoDocto.Linked = False
        Me.selTipoDocto.Location = New System.Drawing.Point(129, 114)
        Me.selTipoDocto.Name = "selTipoDocto"
        Me.selTipoDocto.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selTipoDocto.Size = New System.Drawing.Size(372, 23)
        Me.selTipoDocto.TabIndex = 29
        '
        'VistaContableForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 617)
        Me.Controls.Add(Me.lblDocumento)
        Me.Controls.Add(Me.selTipoDocto)
        Me.Controls.Add(Me.txtReferencia)
        Me.Controls.Add(Me.lblReferencia)
        Me.Controls.Add(Me.txtIdObjeto)
        Me.Controls.Add(Me.lblCampoLLave)
        Me.Controls.Add(Me.txtSchema)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.tabDetalle)
        Me.Controls.Add(Me.txtObjeto)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.lblObjeto)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Name = "VistaContableForm"
        Me.Text = "VistaContableForm"
        Me.Controls.SetChildIndex(Me.lblDescripcion, 0)
        Me.Controls.SetChildIndex(Me.lblObjeto, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.txtObjeto, 0)
        Me.Controls.SetChildIndex(Me.tabDetalle, 0)
        Me.Controls.SetChildIndex(Me.CiLabel1, 0)
        Me.Controls.SetChildIndex(Me.txtSchema, 0)
        Me.Controls.SetChildIndex(Me.lblCampoLLave, 0)
        Me.Controls.SetChildIndex(Me.txtIdObjeto, 0)
        Me.Controls.SetChildIndex(Me.lblReferencia, 0)
        Me.Controls.SetChildIndex(Me.txtReferencia, 0)
        Me.Controls.SetChildIndex(Me.selTipoDocto, 0)
        Me.Controls.SetChildIndex(Me.lblDocumento, 0)
        Me.tabDetalle.ResumeLayout(False)
        Me.tabEntidades.ResumeLayout(False)
        Me.gbxEntidades.ResumeLayout(False)
        CType(Me.grdEntidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsEntidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabImportes.ResumeLayout(False)
        Me.gbxImportes.ResumeLayout(False)
        CType(Me.grdImportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsImportes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Facade = New VistaContableFacade
        LicenseModule = Kernel.Licensing.LicenseModule.Accounting
    End Sub
    Friend WithEvents lblDescripcion As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblObjeto As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtDescripcion As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtObjeto As Azteca.Windows.Controls.CITextBox
    Friend WithEvents tabDetalle As Azteca.Windows.Controls.CITab
    Friend WithEvents tabEntidades As System.Windows.Forms.TabPage
    Friend WithEvents tabImportes As System.Windows.Forms.TabPage
    Friend WithEvents gbxEntidades As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents grdEntidad As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents gbxImportes As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents grdImportes As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents colColumnaEnt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEntidad As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colColumnaImp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colImporte As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents txtSchema As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtIdObjeto As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblCampoLLave As Azteca.Windows.Controls.CILabel
    Friend WithEvents iLstTab As System.Windows.Forms.ImageList
    Friend WithEvents txtReferencia As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblReferencia As Azteca.Windows.Controls.CILabel
    Friend WithEvents bsEntidades As System.Windows.Forms.BindingSource
    Friend WithEvents bsImportes As System.Windows.Forms.BindingSource
    Friend WithEvents lblDocumento As Azteca.Windows.Controls.CILabel
    Friend WithEvents selTipoDocto As Azteca.Windows.Controls.DocumentoTipoSelector

End Class
