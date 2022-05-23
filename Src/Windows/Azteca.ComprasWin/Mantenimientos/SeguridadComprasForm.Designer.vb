<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeguridadComprasForm
    Inherits Azteca.Windows.Forms.Forma

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SeguridadComprasForm))
        Me.imlSeguridad = New System.Windows.Forms.ImageList(Me.components)
        Me.tabSeguridad = New Azteca.Windows.Controls.CITab()
        Me.pagCentral = New System.Windows.Forms.TabPage()
        Me.grdCentral = New Azteca.Windows.Controls.CIDataGridView()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsCentralesCompra = New System.Windows.Forms.BindingSource(Me.components)
        Me.pagDepartamentos = New System.Windows.Forms.TabPage()
        Me.grdDepartamentos = New Azteca.Windows.Controls.CIDataGridView()
        Me.colSelArea = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colArea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsDepartamentos = New System.Windows.Forms.BindingSource(Me.components)
        Me.pagCentrosRecepcion = New System.Windows.Forms.TabPage()
        Me.grdCentrosRecepcion = New Azteca.Windows.Controls.CIDataGridView()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsCentrosRecepcion = New System.Windows.Forms.BindingSource(Me.components)
        Me.tlbMenu = New Azteca.Windows.Controls.CIToolBar()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.txtUsuario = New Azteca.Windows.Controls.Security.UsuarioSelector()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.tabSeguridad.SuspendLayout()
        Me.pagCentral.SuspendLayout()
        CType(Me.grdCentral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCentralesCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagDepartamentos.SuspendLayout()
        CType(Me.grdDepartamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDepartamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagCentrosRecepcion.SuspendLayout()
        CType(Me.grdCentrosRecepcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCentrosRecepcion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlbMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'imlSeguridad
        '
        Me.imlSeguridad.ImageStream = CType(resources.GetObject("imlSeguridad.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlSeguridad.TransparentColor = System.Drawing.Color.Transparent
        Me.imlSeguridad.Images.SetKeyName(0, "Departamentos")
        Me.imlSeguridad.Images.SetKeyName(1, "CentroRecepcion")
        Me.imlSeguridad.Images.SetKeyName(2, "customers_32.png")
        '
        'tabSeguridad
        '
        Me.tabSeguridad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabSeguridad.Controls.Add(Me.pagCentral)
        Me.tabSeguridad.Controls.Add(Me.pagDepartamentos)
        Me.tabSeguridad.Controls.Add(Me.pagCentrosRecepcion)
        Me.tabSeguridad.ImageList = Me.imlSeguridad
        Me.tabSeguridad.Location = New System.Drawing.Point(12, 77)
        Me.tabSeguridad.Name = "tabSeguridad"
        Me.tabSeguridad.SelectedIndex = 0
        Me.tabSeguridad.Size = New System.Drawing.Size(516, 272)
        Me.tabSeguridad.TabIndex = 5
        '
        'pagCentral
        '
        Me.pagCentral.Controls.Add(Me.grdCentral)
        Me.pagCentral.ImageIndex = 2
        Me.pagCentral.Location = New System.Drawing.Point(4, 39)
        Me.pagCentral.Name = "pagCentral"
        Me.pagCentral.Size = New System.Drawing.Size(508, 229)
        Me.pagCentral.TabIndex = 2
        Me.pagCentral.Text = "Centrales de Compra"
        Me.pagCentral.UseVisualStyleBackColor = True
        '
        'grdCentral
        '
        Me.grdCentral.AllowUserToAddRows = False
        Me.grdCentral.AllowUserToDeleteRows = False
        Me.grdCentral.AutoGenerateColumns = False
        Me.grdCentral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCentral.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn1})
        Me.grdCentral.DataSource = Me.bsCentralesCompra
        Me.grdCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdCentral.Location = New System.Drawing.Point(0, 0)
        Me.grdCentral.Name = "grdCentral"
        Me.grdCentral.Size = New System.Drawing.Size(508, 229)
        Me.grdCentral.TabIndex = 1
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Selected"
        Me.DataGridViewCheckBoxColumn1.HeaderText = ""
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 30
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Central de Compra"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'pagDepartamentos
        '
        Me.pagDepartamentos.Controls.Add(Me.grdDepartamentos)
        Me.pagDepartamentos.ImageKey = "Departamentos"
        Me.pagDepartamentos.Location = New System.Drawing.Point(4, 39)
        Me.pagDepartamentos.Name = "pagDepartamentos"
        Me.pagDepartamentos.Padding = New System.Windows.Forms.Padding(3)
        Me.pagDepartamentos.Size = New System.Drawing.Size(508, 229)
        Me.pagDepartamentos.TabIndex = 0
        Me.pagDepartamentos.Text = "Departamentos"
        Me.pagDepartamentos.UseVisualStyleBackColor = True
        '
        'grdDepartamentos
        '
        Me.grdDepartamentos.AllowUserToAddRows = False
        Me.grdDepartamentos.AllowUserToDeleteRows = False
        Me.grdDepartamentos.AutoGenerateColumns = False
        Me.grdDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDepartamentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSelArea, Me.colArea})
        Me.grdDepartamentos.DataSource = Me.bsDepartamentos
        Me.grdDepartamentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDepartamentos.Location = New System.Drawing.Point(3, 3)
        Me.grdDepartamentos.Name = "grdDepartamentos"
        Me.grdDepartamentos.Size = New System.Drawing.Size(502, 223)
        Me.grdDepartamentos.TabIndex = 1
        '
        'colSelArea
        '
        Me.colSelArea.DataPropertyName = "Selected"
        Me.colSelArea.HeaderText = ""
        Me.colSelArea.Name = "colSelArea"
        Me.colSelArea.Width = 30
        '
        'colArea
        '
        Me.colArea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colArea.DataPropertyName = "Nombre"
        Me.colArea.HeaderText = "Departamento"
        Me.colArea.Name = "colArea"
        Me.colArea.ReadOnly = True
        Me.colArea.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colArea.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'pagCentrosRecepcion
        '
        Me.pagCentrosRecepcion.Controls.Add(Me.grdCentrosRecepcion)
        Me.pagCentrosRecepcion.ImageKey = "CentroRecepcion"
        Me.pagCentrosRecepcion.Location = New System.Drawing.Point(4, 39)
        Me.pagCentrosRecepcion.Name = "pagCentrosRecepcion"
        Me.pagCentrosRecepcion.Padding = New System.Windows.Forms.Padding(3)
        Me.pagCentrosRecepcion.Size = New System.Drawing.Size(508, 229)
        Me.pagCentrosRecepcion.TabIndex = 1
        Me.pagCentrosRecepcion.Text = "Centros de Recepción"
        Me.pagCentrosRecepcion.UseVisualStyleBackColor = True
        '
        'grdCentrosRecepcion
        '
        Me.grdCentrosRecepcion.AllowUserToAddRows = False
        Me.grdCentrosRecepcion.AllowUserToDeleteRows = False
        Me.grdCentrosRecepcion.AutoGenerateColumns = False
        Me.grdCentrosRecepcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCentrosRecepcion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn2})
        Me.grdCentrosRecepcion.DataSource = Me.bsCentrosRecepcion
        Me.grdCentrosRecepcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdCentrosRecepcion.Location = New System.Drawing.Point(3, 3)
        Me.grdCentrosRecepcion.Name = "grdCentrosRecepcion"
        Me.grdCentrosRecepcion.Size = New System.Drawing.Size(502, 223)
        Me.grdCentrosRecepcion.TabIndex = 1
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Selected"
        Me.DataGridViewCheckBoxColumn2.HeaderText = ""
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Width = 30
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Centro de Recepción"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'tlbMenu
        '
        Me.tlbMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tlbMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGuardar})
        Me.tlbMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlbMenu.Name = "tlbMenu"
        Me.tlbMenu.Size = New System.Drawing.Size(540, 39)
        Me.tlbMenu.TabIndex = 11
        Me.tlbMenu.Text = "CiToolBar1"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(135, 36)
        Me.btnGuardar.Text = "Guardar Cambios"
        '
        'txtUsuario
        '
        Me.txtUsuario.AnySite = False
        Me.txtUsuario.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtUsuario.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtUsuario.EditorAssembly = "Azteca.Windows"
        Me.txtUsuario.EditorClass = "Azteca.Windows.Forms.Security.CatalogoUsuarios"
        Me.txtUsuario.EditorTitle = "Editar usuario..."
        Me.txtUsuario.Key = 0
        Me.txtUsuario.Linked = False
        Me.txtUsuario.Location = New System.Drawing.Point(70, 48)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.txtUsuario.Size = New System.Drawing.Size(360, 23)
        Me.txtUsuario.TabIndex = 13
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(13, 52)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(46, 13)
        Me.CiLabel1.TabIndex = 12
        Me.CiLabel1.Text = "Usuario:"
        '
        'SeguridadComprasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 374)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.tlbMenu)
        Me.Controls.Add(Me.tabSeguridad)
        Me.Name = "SeguridadComprasForm"
        Me.Text = "SeguridadComprasForm"
        Me.Controls.SetChildIndex(Me.tabSeguridad, 0)
        Me.Controls.SetChildIndex(Me.tlbMenu, 0)
        Me.Controls.SetChildIndex(Me.CiLabel1, 0)
        Me.Controls.SetChildIndex(Me.txtUsuario, 0)
        Me.tabSeguridad.ResumeLayout(False)
        Me.pagCentral.ResumeLayout(False)
        CType(Me.grdCentral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCentralesCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagDepartamentos.ResumeLayout(False)
        CType(Me.grdDepartamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDepartamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagCentrosRecepcion.ResumeLayout(False)
        CType(Me.grdCentrosRecepcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCentrosRecepcion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlbMenu.ResumeLayout(False)
        Me.tlbMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imlSeguridad As System.Windows.Forms.ImageList
    Friend WithEvents tabSeguridad As Azteca.Windows.Controls.CITab
    Friend WithEvents pagDepartamentos As System.Windows.Forms.TabPage
    Friend WithEvents pagCentrosRecepcion As System.Windows.Forms.TabPage
    Friend WithEvents tlbMenu As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtUsuario As Azteca.Windows.Controls.Security.UsuarioSelector
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents bsDepartamentos As System.Windows.Forms.BindingSource
    Friend WithEvents bsCentrosRecepcion As System.Windows.Forms.BindingSource
    Friend WithEvents grdDepartamentos As Azteca.Windows.Controls.CIDataGridView
    Friend WithEvents colSelArea As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colArea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bsCentralesCompra As System.Windows.Forms.BindingSource
    Friend WithEvents grdCentrosRecepcion As Azteca.Windows.Controls.CIDataGridView
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pagCentral As System.Windows.Forms.TabPage
    Friend WithEvents grdCentral As Azteca.Windows.Controls.CIDataGridView
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
