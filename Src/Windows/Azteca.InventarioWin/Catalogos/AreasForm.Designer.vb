<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AreasForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AreasForm))
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.grdAlmacenes = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsAlmacenes = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdTurnos = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsTurnos = New System.Windows.Forms.BindingSource(Me.components)
        Me.imlAreas = New System.Windows.Forms.ImageList(Me.components)
        Me.tabAreas = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagAlmacenes = New C1.Win.C1Command.C1DockingTabPage()
        Me.tlbAlmacenes = New Azteca.Windows.Controls.AZToolBar()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdAddAlmacen = New C1.Win.C1Command.C1Command()
        Me.cmdSeguridad = New C1.Win.C1Command.C1Command()
        Me.cmdAddTurno = New C1.Win.C1Command.C1Command()
        Me.btnAddAlmacen = New C1.Win.C1Command.C1CommandLink()
        Me.btnSecurity = New C1.Win.C1Command.C1CommandLink()
        Me.pagTurnos = New C1.Win.C1Command.C1DockingTabPage()
        Me.tlbTurnos = New Azteca.Windows.Controls.AZToolBar()
        Me.btnAddTurno = New C1.Win.C1Command.C1CommandLink()
        CType(Me.grdAlmacenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAlmacenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdTurnos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTurnos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabAreas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAreas.SuspendLayout()
        Me.pagAlmacenes.SuspendLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagTurnos.SuspendLayout()
        Me.SuspendLayout()
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(12, 95)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(32, 13)
        Me.CiLabel1.TabIndex = 0
        Me.CiLabel1.Text = "Área:"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(58, 92)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(232, 20)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.UIName = "Nombre"
        '
        'grdAlmacenes
        '
        Me.grdAlmacenes.DataSource = Me.bsAlmacenes
        Me.grdAlmacenes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdAlmacenes.FetchRowStyles = True
        Me.grdAlmacenes.FilterBar = True
        Me.grdAlmacenes.IDCatalogField = "IdAlmacen"
        Me.grdAlmacenes.Images.Add(CType(resources.GetObject("grdAlmacenes.Images"), System.Drawing.Image))
        Me.grdAlmacenes.Location = New System.Drawing.Point(0, 34)
        Me.grdAlmacenes.Name = "grdAlmacenes"
        Me.grdAlmacenes.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdAlmacenes.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdAlmacenes.PreviewInfo.ZoomFactor = 75.0R
        Me.grdAlmacenes.PrintInfo.PageSettings = CType(resources.GetObject("grdAlmacenes.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdAlmacenes.Size = New System.Drawing.Size(508, 301)
        Me.grdAlmacenes.TabIndex = 1
        Me.grdAlmacenes.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdAlmacenes.PropBag = resources.GetString("grdAlmacenes.PropBag")
        '
        'bsAlmacenes
        '
        Me.bsAlmacenes.AllowNew = True
        '
        'grdTurnos
        '
        Me.grdTurnos.DataSource = Me.bsTurnos
        Me.grdTurnos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdTurnos.FilterBar = True
        Me.grdTurnos.Images.Add(CType(resources.GetObject("grdTurnos.Images"), System.Drawing.Image))
        Me.grdTurnos.Location = New System.Drawing.Point(0, 34)
        Me.grdTurnos.Name = "grdTurnos"
        Me.grdTurnos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdTurnos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdTurnos.PreviewInfo.ZoomFactor = 75.0R
        Me.grdTurnos.PrintInfo.PageSettings = CType(resources.GetObject("grdTurnos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdTurnos.ShowEditButton = False
        Me.grdTurnos.Size = New System.Drawing.Size(508, 301)
        Me.grdTurnos.TabIndex = 0
        Me.grdTurnos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdTurnos.PropBag = resources.GetString("grdTurnos.PropBag")
        '
        'imlAreas
        '
        Me.imlAreas.ImageStream = CType(resources.GetObject("imlAreas.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlAreas.TransparentColor = System.Drawing.Color.Transparent
        Me.imlAreas.Images.SetKeyName(0, "Almacenes")
        Me.imlAreas.Images.SetKeyName(1, "Turnos")
        Me.imlAreas.Images.SetKeyName(2, "AddTurno")
        '
        'tabAreas
        '
        Me.tabAreas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabAreas.Controls.Add(Me.pagAlmacenes)
        Me.tabAreas.Controls.Add(Me.pagTurnos)
        Me.tabAreas.ImageList = Me.imlAreas
        Me.tabAreas.Location = New System.Drawing.Point(12, 118)
        Me.tabAreas.Name = "tabAreas"
        Me.tabAreas.SelectedIndex = 1
        Me.tabAreas.Size = New System.Drawing.Size(510, 377)
        Me.tabAreas.TabIndex = 32
        Me.tabAreas.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabAreas.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabAreas.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagAlmacenes
        '
        Me.pagAlmacenes.Controls.Add(Me.grdAlmacenes)
        Me.pagAlmacenes.Controls.Add(Me.tlbAlmacenes)
        Me.pagAlmacenes.ImageIndex = 0
        Me.pagAlmacenes.Location = New System.Drawing.Point(1, 41)
        Me.pagAlmacenes.Name = "pagAlmacenes"
        Me.pagAlmacenes.Size = New System.Drawing.Size(508, 335)
        Me.pagAlmacenes.TabIndex = 0
        Me.pagAlmacenes.Text = "Almacenes"
        '
        'tlbAlmacenes
        '
        Me.tlbAlmacenes.AccessibleName = "Tool Bar"
        Me.tlbAlmacenes.AutoSize = False
        Me.tlbAlmacenes.CommandHolder = Me.C1CommandHolder1
        Me.tlbAlmacenes.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.btnAddAlmacen, Me.btnSecurity})
        Me.tlbAlmacenes.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbAlmacenes.Location = New System.Drawing.Point(0, 0)
        Me.tlbAlmacenes.MinButtonSize = 32
        Me.tlbAlmacenes.Movable = False
        Me.tlbAlmacenes.Name = "tlbAlmacenes"
        Me.tlbAlmacenes.Size = New System.Drawing.Size(508, 34)
        Me.tlbAlmacenes.Text = "AzToolBar1"
        Me.tlbAlmacenes.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdAddAlmacen)
        Me.C1CommandHolder1.Commands.Add(Me.cmdSeguridad)
        Me.C1CommandHolder1.Commands.Add(Me.cmdAddTurno)
        Me.C1CommandHolder1.Owner = Me
        '
        'cmdAddAlmacen
        '
        Me.cmdAddAlmacen.Image = CType(resources.GetObject("cmdAddAlmacen.Image"), System.Drawing.Image)
        Me.cmdAddAlmacen.Name = "cmdAddAlmacen"
        Me.cmdAddAlmacen.ShortcutText = ""
        Me.cmdAddAlmacen.Text = "Nuevo Almacén"
        '
        'cmdSeguridad
        '
        Me.cmdSeguridad.Image = CType(resources.GetObject("cmdSeguridad.Image"), System.Drawing.Image)
        Me.cmdSeguridad.Name = "cmdSeguridad"
        Me.cmdSeguridad.ShortcutText = ""
        Me.cmdSeguridad.Text = "Editar Seguridad del Almacén"
        '
        'cmdAddTurno
        '
        Me.cmdAddTurno.Image = CType(resources.GetObject("cmdAddTurno.Image"), System.Drawing.Image)
        Me.cmdAddTurno.Name = "cmdAddTurno"
        Me.cmdAddTurno.ShortcutText = ""
        Me.cmdAddTurno.Text = "Asignar Turno..."
        '
        'btnAddAlmacen
        '
        Me.btnAddAlmacen.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnAddAlmacen.Command = Me.cmdAddAlmacen
        '
        'btnSecurity
        '
        Me.btnSecurity.Command = Me.cmdSeguridad
        Me.btnSecurity.Delimiter = True
        Me.btnSecurity.SortOrder = 1
        '
        'pagTurnos
        '
        Me.pagTurnos.Controls.Add(Me.grdTurnos)
        Me.pagTurnos.Controls.Add(Me.tlbTurnos)
        Me.pagTurnos.ImageIndex = 1
        Me.pagTurnos.Location = New System.Drawing.Point(1, 41)
        Me.pagTurnos.Name = "pagTurnos"
        Me.pagTurnos.Size = New System.Drawing.Size(508, 335)
        Me.pagTurnos.TabIndex = 1
        Me.pagTurnos.Text = "Turnos"
        '
        'tlbTurnos
        '
        Me.tlbTurnos.AccessibleName = "Tool Bar"
        Me.tlbTurnos.AutoSize = False
        Me.tlbTurnos.CommandHolder = Me.C1CommandHolder1
        Me.tlbTurnos.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.btnAddTurno})
        Me.tlbTurnos.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbTurnos.Location = New System.Drawing.Point(0, 0)
        Me.tlbTurnos.MinButtonSize = 32
        Me.tlbTurnos.Movable = False
        Me.tlbTurnos.Name = "tlbTurnos"
        Me.tlbTurnos.Size = New System.Drawing.Size(508, 34)
        Me.tlbTurnos.Text = "AzToolBar2"
        Me.tlbTurnos.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'btnAddTurno
        '
        Me.btnAddTurno.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnAddTurno.Command = Me.cmdAddTurno
        '
        'AreasForm
        '
        Me.AllowRecordNavigation = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 523)
        Me.Controls.Add(Me.tabAreas)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.txtNombre)
        Me.Name = "AreasForm"
        Me.Text = "AreasForm"
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.CiLabel1, 0)
        Me.Controls.SetChildIndex(Me.tabAreas, 0)
        CType(Me.grdAlmacenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAlmacenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdTurnos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTurnos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabAreas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAreas.ResumeLayout(False)
        Me.pagAlmacenes.ResumeLayout(False)
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagTurnos.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New AreaFacade
        LicenseModule = Kernel.Licensing.LicenseModule.Inventory
    End Sub
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdAlmacenes As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdTurnos As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents tabAreas As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagAlmacenes As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagTurnos As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents tlbAlmacenes As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents cmdAddAlmacen As C1.Win.C1Command.C1Command
    Friend WithEvents cmdSeguridad As C1.Win.C1Command.C1Command
    Friend WithEvents btnAddAlmacen As C1.Win.C1Command.C1CommandLink
    Friend WithEvents btnSecurity As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdAddTurno As C1.Win.C1Command.C1Command
    Friend WithEvents tlbTurnos As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents btnAddTurno As C1.Win.C1Command.C1CommandLink
    Private WithEvents imlAreas As System.Windows.Forms.ImageList
    Private WithEvents bsAlmacenes As System.Windows.Forms.BindingSource
    Private WithEvents bsTurnos As System.Windows.Forms.BindingSource
End Class
