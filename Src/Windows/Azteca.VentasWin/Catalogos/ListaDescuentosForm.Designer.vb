<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaDescuentosForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListaDescuentosForm))
        Me.bsArticulos = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsClientes = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsServicios = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.lblNombre = New Azteca.Windows.Controls.CILabel()
        Me.iLstTabs = New System.Windows.Forms.ImageList(Me.components)
        Me.tabListaPrecios = New Azteca.Windows.Controls.CITab()
        Me.tabArticulos = New System.Windows.Forms.TabPage()
        Me.gbxDetalle = New Azteca.Windows.Controls.CIGroupBox()
        Me.grdArticulos = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.tabServicios = New System.Windows.Forms.TabPage()
        Me.gbxServicios = New Azteca.Windows.Controls.CIGroupBox()
        Me.grdServicios = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.tabClientes = New System.Windows.Forms.TabPage()
        Me.gbxClientes = New Azteca.Windows.Controls.CIGroupBox()
        Me.grdClientes = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.tbClientes = New Azteca.Windows.Controls.CIToolBar()
        Me.btnCtesRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCtesAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCtesSave = New System.Windows.Forms.ToolStripButton()
        CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabListaPrecios.SuspendLayout()
        Me.tabArticulos.SuspendLayout()
        Me.gbxDetalle.SuspendLayout()
        CType(Me.grdArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabServicios.SuspendLayout()
        Me.gbxServicios.SuspendLayout()
        CType(Me.grdServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabClientes.SuspendLayout()
        Me.gbxClientes.SuspendLayout()
        CType(Me.grdClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbClientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(64, 101)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(498, 20)
        Me.txtNombre.TabIndex = 36
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(14, 104)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 35
        Me.lblNombre.Text = "Nombre"
        '
        'iLstTabs
        '
        Me.iLstTabs.ImageStream = CType(resources.GetObject("iLstTabs.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.iLstTabs.TransparentColor = System.Drawing.Color.Transparent
        Me.iLstTabs.Images.SetKeyName(0, "Servicios")
        Me.iLstTabs.Images.SetKeyName(1, "Clientes")
        Me.iLstTabs.Images.SetKeyName(2, "Articulos")
        '
        'tabListaPrecios
        '
        Me.tabListaPrecios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabListaPrecios.Controls.Add(Me.tabArticulos)
        Me.tabListaPrecios.Controls.Add(Me.tabServicios)
        Me.tabListaPrecios.Controls.Add(Me.tabClientes)
        Me.tabListaPrecios.ImageList = Me.iLstTabs
        Me.tabListaPrecios.Location = New System.Drawing.Point(12, 127)
        Me.tabListaPrecios.Name = "tabListaPrecios"
        Me.tabListaPrecios.SelectedIndex = 0
        Me.tabListaPrecios.Size = New System.Drawing.Size(659, 303)
        Me.tabListaPrecios.TabIndex = 37
        '
        'tabArticulos
        '
        Me.tabArticulos.Controls.Add(Me.gbxDetalle)
        Me.tabArticulos.ImageKey = "Articulos"
        Me.tabArticulos.Location = New System.Drawing.Point(4, 39)
        Me.tabArticulos.Name = "tabArticulos"
        Me.tabArticulos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabArticulos.Size = New System.Drawing.Size(651, 260)
        Me.tabArticulos.TabIndex = 0
        Me.tabArticulos.Text = "Articulos"
        Me.tabArticulos.UseVisualStyleBackColor = True
        '
        'gbxDetalle
        '
        Me.gbxDetalle.Controls.Add(Me.grdArticulos)
        Me.gbxDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxDetalle.Location = New System.Drawing.Point(3, 3)
        Me.gbxDetalle.Name = "gbxDetalle"
        Me.gbxDetalle.Size = New System.Drawing.Size(645, 254)
        Me.gbxDetalle.TabIndex = 29
        Me.gbxDetalle.TabStop = False
        '
        'grdArticulos
        '
        Me.grdArticulos.DataSource = Me.bsArticulos
        Me.grdArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdArticulos.FilterBar = True
        Me.grdArticulos.Images.Add(CType(resources.GetObject("grdArticulos.Images"), System.Drawing.Image))
        Me.grdArticulos.Location = New System.Drawing.Point(3, 16)
        Me.grdArticulos.Name = "grdArticulos"
        Me.grdArticulos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdArticulos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdArticulos.PreviewInfo.ZoomFactor = 75.0R
        Me.grdArticulos.PrintInfo.PageSettings = CType(resources.GetObject("grdArticulos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdArticulos.Size = New System.Drawing.Size(639, 235)
        Me.grdArticulos.TabIndex = 29
        Me.grdArticulos.Text = "AzTrueDBGrid1"
        Me.grdArticulos.PropBag = resources.GetString("grdArticulos.PropBag")
        '
        'tabServicios
        '
        Me.tabServicios.Controls.Add(Me.gbxServicios)
        Me.tabServicios.ImageKey = "Servicios"
        Me.tabServicios.Location = New System.Drawing.Point(4, 39)
        Me.tabServicios.Name = "tabServicios"
        Me.tabServicios.Padding = New System.Windows.Forms.Padding(3)
        Me.tabServicios.Size = New System.Drawing.Size(651, 260)
        Me.tabServicios.TabIndex = 1
        Me.tabServicios.Text = "Servicios"
        Me.tabServicios.UseVisualStyleBackColor = True
        Me.tabServicios.UseWaitCursor = True
        '
        'gbxServicios
        '
        Me.gbxServicios.Controls.Add(Me.grdServicios)
        Me.gbxServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxServicios.Location = New System.Drawing.Point(3, 3)
        Me.gbxServicios.Name = "gbxServicios"
        Me.gbxServicios.Size = New System.Drawing.Size(645, 254)
        Me.gbxServicios.TabIndex = 30
        Me.gbxServicios.TabStop = False
        Me.gbxServicios.UseWaitCursor = True
        '
        'grdServicios
        '
        Me.grdServicios.DataSource = Me.bsServicios
        Me.grdServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdServicios.FilterBar = True
        Me.grdServicios.Images.Add(CType(resources.GetObject("grdServicios.Images"), System.Drawing.Image))
        Me.grdServicios.Location = New System.Drawing.Point(3, 16)
        Me.grdServicios.Name = "grdServicios"
        Me.grdServicios.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdServicios.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdServicios.PreviewInfo.ZoomFactor = 75.0R
        Me.grdServicios.PrintInfo.PageSettings = CType(resources.GetObject("grdServicios.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdServicios.Size = New System.Drawing.Size(639, 235)
        Me.grdServicios.TabIndex = 29
        Me.grdServicios.Text = "AzTrueDBGrid1"
        Me.grdServicios.UseWaitCursor = True
        Me.grdServicios.PropBag = resources.GetString("grdServicios.PropBag")
        '
        'tabClientes
        '
        Me.tabClientes.Controls.Add(Me.gbxClientes)
        Me.tabClientes.ImageKey = "Clientes"
        Me.tabClientes.Location = New System.Drawing.Point(4, 39)
        Me.tabClientes.Name = "tabClientes"
        Me.tabClientes.Size = New System.Drawing.Size(651, 260)
        Me.tabClientes.TabIndex = 2
        Me.tabClientes.Text = "Clientes"
        Me.tabClientes.UseVisualStyleBackColor = True
        '
        'gbxClientes
        '
        Me.gbxClientes.Controls.Add(Me.grdClientes)
        Me.gbxClientes.Controls.Add(Me.tbClientes)
        Me.gbxClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxClientes.Location = New System.Drawing.Point(0, 0)
        Me.gbxClientes.Name = "gbxClientes"
        Me.gbxClientes.Size = New System.Drawing.Size(651, 260)
        Me.gbxClientes.TabIndex = 25
        Me.gbxClientes.TabStop = False
        '
        'grdClientes
        '
        Me.grdClientes.AlternatingRows = True
        Me.grdClientes.DataSource = Me.bsClientes
        Me.grdClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdClientes.FilterBar = True
        Me.grdClientes.Images.Add(CType(resources.GetObject("grdClientes.Images"), System.Drawing.Image))
        Me.grdClientes.Location = New System.Drawing.Point(3, 55)
        Me.grdClientes.Name = "grdClientes"
        Me.grdClientes.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdClientes.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdClientes.PreviewInfo.ZoomFactor = 75.0R
        Me.grdClientes.PrintInfo.PageSettings = CType(resources.GetObject("grdClientes.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdClientes.Size = New System.Drawing.Size(645, 202)
        Me.grdClientes.TabIndex = 30
        Me.grdClientes.Text = "AzTrueDBGrid1"
        Me.grdClientes.PropBag = resources.GetString("grdClientes.PropBag")
        '
        'tbClientes
        '
        Me.tbClientes.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbClientes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCtesRefresh, Me.ToolStripSeparator7, Me.btnCtesAdd, Me.ToolStripSeparator8, Me.btnCtesSave})
        Me.tbClientes.Location = New System.Drawing.Point(3, 16)
        Me.tbClientes.Name = "tbClientes"
        Me.tbClientes.Size = New System.Drawing.Size(645, 39)
        Me.tbClientes.TabIndex = 31
        Me.tbClientes.Text = "CiToolBar3"
        '
        'btnCtesRefresh
        '
        Me.btnCtesRefresh.Image = CType(resources.GetObject("btnCtesRefresh.Image"), System.Drawing.Image)
        Me.btnCtesRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCtesRefresh.Name = "btnCtesRefresh"
        Me.btnCtesRefresh.Size = New System.Drawing.Size(98, 36)
        Me.btnCtesRefresh.Text = "Actualizar "
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 39)
        '
        'btnCtesAdd
        '
        Me.btnCtesAdd.Image = CType(resources.GetObject("btnCtesAdd.Image"), System.Drawing.Image)
        Me.btnCtesAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCtesAdd.Name = "btnCtesAdd"
        Me.btnCtesAdd.Size = New System.Drawing.Size(116, 36)
        Me.btnCtesAdd.Text = "Incluir Cliente"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 39)
        '
        'btnCtesSave
        '
        Me.btnCtesSave.Image = CType(resources.GetObject("btnCtesSave.Image"), System.Drawing.Image)
        Me.btnCtesSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCtesSave.Name = "btnCtesSave"
        Me.btnCtesSave.Size = New System.Drawing.Size(85, 36)
        Me.btnCtesSave.Text = "Guardar"
        '
        'ListaDescuentosForm
        '
        Me.AllowRecordNavigation = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 455)
        Me.Controls.Add(Me.tabListaPrecios)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "ListaDescuentosForm"
        Me.Text = "ListasDescuentosForm"
        Me.Controls.SetChildIndex(Me.lblNombre, 0)
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.tabListaPrecios, 0)
        CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabListaPrecios.ResumeLayout(False)
        Me.tabArticulos.ResumeLayout(False)
        Me.gbxDetalle.ResumeLayout(False)
        CType(Me.grdArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabServicios.ResumeLayout(False)
        Me.gbxServicios.ResumeLayout(False)
        CType(Me.grdServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabClientes.ResumeLayout(False)
        Me.gbxClientes.ResumeLayout(False)
        Me.gbxClientes.PerformLayout()
        CType(Me.grdClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbClientes.ResumeLayout(False)
        Me.tbClientes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bsArticulos As System.Windows.Forms.BindingSource
    Friend WithEvents bsClientes As System.Windows.Forms.BindingSource
    Friend WithEvents bsServicios As System.Windows.Forms.BindingSource
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblNombre As Azteca.Windows.Controls.CILabel
    Friend WithEvents iLstTabs As System.Windows.Forms.ImageList
    Friend WithEvents tabListaPrecios As Azteca.Windows.Controls.CITab
    Friend WithEvents tabArticulos As System.Windows.Forms.TabPage
    Friend WithEvents gbxDetalle As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents grdArticulos As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents tabServicios As System.Windows.Forms.TabPage
    Friend WithEvents gbxServicios As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents grdServicios As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents tabClientes As System.Windows.Forms.TabPage
    Friend WithEvents gbxClientes As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents grdClientes As Azteca.Windows.Controls.AZTrueDBGrid

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Facade = New GrupoDescuentosFacade
    End Sub
    Friend WithEvents tbClientes As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnCtesRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCtesAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCtesSave As System.Windows.Forms.ToolStripButton

End Class
