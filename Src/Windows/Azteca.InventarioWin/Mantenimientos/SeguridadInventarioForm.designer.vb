<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeguridadInventarioForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SeguridadInventarioForm))
        Me.tabAccesos = New Azteca.Windows.Controls.CITab()
        Me.pagAreas = New System.Windows.Forms.TabPage()
        Me.grdAreas = New Azteca.Windows.Controls.CIDataGridView()
        Me.colSelArea = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colArea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsAreas = New System.Windows.Forms.BindingSource(Me.components)
        Me.pagAlmacenes = New System.Windows.Forms.TabPage()
        Me.grdAlmacenes = New Azteca.Windows.Controls.CIDataGridView()
        Me.colSelAlmacen = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colAreaAlmacen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAlmacen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEntrada = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colSalida = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.bsAlmacenes = New System.Windows.Forms.BindingSource(Me.components)
        Me.imlInventario = New System.Windows.Forms.ImageList(Me.components)
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.cboSucursal = New Azteca.Windows.Controls.Security.SucursalComboBox()
        Me.txtUsuario = New Azteca.Windows.Controls.Security.UsuarioSelector()
        Me.tlbMenu = New Azteca.Windows.Controls.AZToolBar()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdGuardar = New C1.Win.C1Command.C1Command()
        Me.btnGuardar = New C1.Win.C1Command.C1CommandLink()
        Me.tabAccesos.SuspendLayout()
        Me.pagAreas.SuspendLayout()
        CType(Me.grdAreas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAreas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagAlmacenes.SuspendLayout()
        CType(Me.grdAlmacenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAlmacenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabAccesos
        '
        Me.tabAccesos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabAccesos.Controls.Add(Me.pagAreas)
        Me.tabAccesos.Controls.Add(Me.pagAlmacenes)
        Me.tabAccesos.ImageList = Me.imlInventario
        Me.tabAccesos.Location = New System.Drawing.Point(12, 98)
        Me.tabAccesos.Name = "tabAccesos"
        Me.tabAccesos.SelectedIndex = 0
        Me.tabAccesos.Size = New System.Drawing.Size(507, 316)
        Me.tabAccesos.TabIndex = 5
        '
        'pagAreas
        '
        Me.pagAreas.Controls.Add(Me.grdAreas)
        Me.pagAreas.ImageKey = "Areas"
        Me.pagAreas.Location = New System.Drawing.Point(4, 39)
        Me.pagAreas.Name = "pagAreas"
        Me.pagAreas.Padding = New System.Windows.Forms.Padding(3)
        Me.pagAreas.Size = New System.Drawing.Size(499, 273)
        Me.pagAreas.TabIndex = 0
        Me.pagAreas.Text = "Areas"
        Me.pagAreas.UseVisualStyleBackColor = True
        '
        'grdAreas
        '
        Me.grdAreas.AllowUserToAddRows = False
        Me.grdAreas.AllowUserToDeleteRows = False
        Me.grdAreas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdAreas.AutoGenerateColumns = False
        Me.grdAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdAreas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSelArea, Me.colArea})
        Me.grdAreas.DataSource = Me.bsAreas
        Me.grdAreas.Location = New System.Drawing.Point(6, 6)
        Me.grdAreas.Name = "grdAreas"
        Me.grdAreas.Size = New System.Drawing.Size(490, 261)
        Me.grdAreas.TabIndex = 0
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
        Me.colArea.HeaderText = "Area"
        Me.colArea.Name = "colArea"
        Me.colArea.ReadOnly = True
        Me.colArea.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colArea.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'bsAreas
        '
        Me.bsAreas.AllowNew = False
        '
        'pagAlmacenes
        '
        Me.pagAlmacenes.Controls.Add(Me.grdAlmacenes)
        Me.pagAlmacenes.ImageKey = "Almacenes"
        Me.pagAlmacenes.Location = New System.Drawing.Point(4, 39)
        Me.pagAlmacenes.Name = "pagAlmacenes"
        Me.pagAlmacenes.Padding = New System.Windows.Forms.Padding(3)
        Me.pagAlmacenes.Size = New System.Drawing.Size(499, 273)
        Me.pagAlmacenes.TabIndex = 1
        Me.pagAlmacenes.Text = "Almacenes"
        Me.pagAlmacenes.UseVisualStyleBackColor = True
        '
        'grdAlmacenes
        '
        Me.grdAlmacenes.AllowUserToAddRows = False
        Me.grdAlmacenes.AllowUserToDeleteRows = False
        Me.grdAlmacenes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdAlmacenes.AutoGenerateColumns = False
        Me.grdAlmacenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdAlmacenes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSelAlmacen, Me.colAreaAlmacen, Me.colAlmacen, Me.colEntrada, Me.colSalida})
        Me.grdAlmacenes.DataSource = Me.bsAlmacenes
        Me.grdAlmacenes.Location = New System.Drawing.Point(6, 6)
        Me.grdAlmacenes.Name = "grdAlmacenes"
        Me.grdAlmacenes.Size = New System.Drawing.Size(487, 267)
        Me.grdAlmacenes.TabIndex = 0
        '
        'colSelAlmacen
        '
        Me.colSelAlmacen.DataPropertyName = "Selected"
        Me.colSelAlmacen.HeaderText = ""
        Me.colSelAlmacen.Name = "colSelAlmacen"
        Me.colSelAlmacen.Width = 30
        '
        'colAreaAlmacen
        '
        Me.colAreaAlmacen.DataPropertyName = "Area"
        Me.colAreaAlmacen.HeaderText = "Área"
        Me.colAreaAlmacen.Name = "colAreaAlmacen"
        Me.colAreaAlmacen.ReadOnly = True
        Me.colAreaAlmacen.Width = 80
        '
        'colAlmacen
        '
        Me.colAlmacen.DataPropertyName = "Nombre"
        Me.colAlmacen.HeaderText = "Almacén"
        Me.colAlmacen.Name = "colAlmacen"
        Me.colAlmacen.ReadOnly = True
        Me.colAlmacen.Width = 200
        '
        'colEntrada
        '
        Me.colEntrada.DataPropertyName = "Entrada"
        Me.colEntrada.HeaderText = "Entrada"
        Me.colEntrada.Name = "colEntrada"
        Me.colEntrada.Width = 60
        '
        'colSalida
        '
        Me.colSalida.DataPropertyName = "Salida"
        Me.colSalida.HeaderText = "Salida"
        Me.colSalida.Name = "colSalida"
        Me.colSalida.Width = 60
        '
        'bsAlmacenes
        '
        Me.bsAlmacenes.AllowNew = False
        '
        'imlInventario
        '
        Me.imlInventario.ImageStream = CType(resources.GetObject("imlInventario.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlInventario.TransparentColor = System.Drawing.Color.Transparent
        Me.imlInventario.Images.SetKeyName(0, "Areas")
        Me.imlInventario.Images.SetKeyName(1, "Almacenes")
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(15, 46)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(46, 13)
        Me.CiLabel1.TabIndex = 7
        Me.CiLabel1.Text = "Usuario:"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(15, 74)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(51, 13)
        Me.CiLabel2.TabIndex = 8
        Me.CiLabel2.Text = "Sucursal:"
        '
        'cboSucursal
        '
        Me.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSucursal.FormattingEnabled = True
        Me.cboSucursal.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboSucursal.ItemsTable = Nothing
        Me.cboSucursal.Location = New System.Drawing.Point(72, 71)
        Me.cboSucursal.Name = "cboSucursal"
        Me.cboSucursal.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboSucursal.Size = New System.Drawing.Size(318, 21)
        Me.cboSucursal.TabIndex = 9
        Me.cboSucursal.UIName = Nothing
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
        Me.txtUsuario.Location = New System.Drawing.Point(72, 42)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.txtUsuario.Size = New System.Drawing.Size(318, 23)
        Me.txtUsuario.TabIndex = 11
        '
        'tlbMenu
        '
        Me.tlbMenu.AccessibleName = "Tool Bar"
        Me.tlbMenu.AutoSize = False
        Me.tlbMenu.CommandHolder = Me.C1CommandHolder1
        Me.tlbMenu.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.btnGuardar})
        Me.tlbMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlbMenu.MinButtonSize = 32
        Me.tlbMenu.Movable = False
        Me.tlbMenu.Name = "tlbMenu"
        Me.tlbMenu.Size = New System.Drawing.Size(519, 34)
        Me.tlbMenu.Text = "AzToolBar1"
        Me.tlbMenu.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tlbMenu.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdGuardar)
        Me.C1CommandHolder1.Owner = Me
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.Image"), System.Drawing.Image)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Text = "Guardar Cambios"
        '
        'btnGuardar
        '
        Me.btnGuardar.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnGuardar.Command = Me.cmdGuardar
        '
        'SeguridadInventarioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 439)
        Me.Controls.Add(Me.tlbMenu)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.cboSucursal)
        Me.Controls.Add(Me.CiLabel2)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.tabAccesos)
        Me.Name = "SeguridadInventarioForm"
        Me.Text = "SeguridadInventarioForm"
        Me.Controls.SetChildIndex(Me.tabAccesos, 0)
        Me.Controls.SetChildIndex(Me.CiLabel1, 0)
        Me.Controls.SetChildIndex(Me.CiLabel2, 0)
        Me.Controls.SetChildIndex(Me.cboSucursal, 0)
        Me.Controls.SetChildIndex(Me.txtUsuario, 0)
        Me.Controls.SetChildIndex(Me.tlbMenu, 0)
        Me.tabAccesos.ResumeLayout(False)
        Me.pagAreas.ResumeLayout(False)
        CType(Me.grdAreas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAreas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagAlmacenes.ResumeLayout(False)
        CType(Me.grdAlmacenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAlmacenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabAccesos As Azteca.Windows.Controls.CITab
    Friend WithEvents pagAreas As System.Windows.Forms.TabPage
    Friend WithEvents pagAlmacenes As System.Windows.Forms.TabPage
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboSucursal As Azteca.Windows.Controls.Security.SucursalComboBox
    Friend WithEvents grdAreas As Azteca.Windows.Controls.CIDataGridView
    Friend WithEvents grdAlmacenes As Azteca.Windows.Controls.CIDataGridView
    Friend WithEvents bsAreas As System.Windows.Forms.BindingSource
    Friend WithEvents bsAlmacenes As System.Windows.Forms.BindingSource
    Friend WithEvents txtUsuario As Azteca.Windows.Controls.Security.UsuarioSelector
    Friend WithEvents colSelArea As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colArea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSelAlmacen As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colAreaAlmacen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAlmacen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEntrada As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colSalida As System.Windows.Forms.DataGridViewCheckBoxColumn

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LicenseModule = Kernel.Licensing.LicenseModule.Inventory
    End Sub
    Friend WithEvents tlbMenu As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents cmdGuardar As C1.Win.C1Command.C1Command
    Friend WithEvents btnGuardar As C1.Win.C1Command.C1CommandLink
    Private WithEvents imlInventario As System.Windows.Forms.ImageList
End Class
