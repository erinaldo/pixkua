<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ZonasCompraForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ZonasCompraForm))
        Me.grdProveedores = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsProveedores = New System.Windows.Forms.BindingSource(Me.components)
        Me.tlbProveedores = New Azteca.Windows.Controls.AZToolBar()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdArticulos = New C1.Win.C1Command.C1Command()
        Me.cmdServicios = New C1.Win.C1Command.C1Command()
        Me.btnArticulos = New C1.Win.C1Command.C1CommandLink()
        Me.btnServicios = New C1.Win.C1Command.C1CommandLink()
        Me.imlZona = New System.Windows.Forms.ImageList(Me.components)
        Me.tabZona = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagProveedores = New C1.Win.C1Command.C1DockingTabPage()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.lblNombre = New Azteca.Windows.Controls.CILabel()
        CType(Me.grdProveedores,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.bsProveedores,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.C1CommandHolder1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tabZona,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabZona.SuspendLayout
        Me.pagProveedores.SuspendLayout
        Me.SuspendLayout
        '
        'grdProveedores
        '
        Me.grdProveedores.AllowUpdate = false
        Me.grdProveedores.AlternatingRows = true
        Me.grdProveedores.AutoClear = False
        Me.grdProveedores.DataSource = Me.bsProveedores
        Me.grdProveedores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdProveedores.FilterBar = True
        Me.grdProveedores.Images.Add(CType(resources.GetObject("grdProveedores.Images"), System.Drawing.Image))
        Me.grdProveedores.Location = New System.Drawing.Point(0, 37)
        Me.grdProveedores.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.grdProveedores.Name = "grdProveedores"
        Me.grdProveedores.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdProveedores.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdProveedores.PreviewInfo.ZoomFactor = 75.0R
        Me.grdProveedores.PrintInfo.PageSettings = CType(resources.GetObject("grdProveedores.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdProveedores.Size = New System.Drawing.Size(834, 207)
        Me.grdProveedores.TabIndex = 2
        Me.grdProveedores.Text = "AzTrueDBGrid1"
        Me.grdProveedores.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdProveedores.PropBag = resources.GetString("grdProveedores.PropBag")
        '
        'tlbProveedores
        '
        Me.tlbProveedores.AccessibleName = "Tool Bar"
        Me.tlbProveedores.AutoSize = False
        Me.tlbProveedores.CommandHolder = Me.C1CommandHolder1
        Me.tlbProveedores.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.btnArticulos, Me.btnServicios})
        Me.tlbProveedores.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbProveedores.Location = New System.Drawing.Point(0, 0)
        Me.tlbProveedores.MinButtonSize = 32
        Me.tlbProveedores.Movable = False
        Me.tlbProveedores.Name = "tlbProveedores"
        Me.tlbProveedores.Size = New System.Drawing.Size(834, 37)
        Me.tlbProveedores.Text = "AzToolBar1"
        Me.tlbProveedores.VisualStyle = C1.Win.C1Command.VisualStyle.Office2003Blue
        Me.tlbProveedores.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2003Blue
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdArticulos)
        Me.C1CommandHolder1.Commands.Add(Me.cmdServicios)
        Me.C1CommandHolder1.Owner = Me
        '
        'cmdArticulos
        '
        Me.cmdArticulos.Enabled = False
        Me.cmdArticulos.Image = CType(resources.GetObject("cmdArticulos.Image"), System.Drawing.Image)
        Me.cmdArticulos.Name = "cmdArticulos"
        Me.cmdArticulos.Text = "Artículos"
        '
        'cmdServicios
        '
        Me.cmdServicios.Enabled = False
        Me.cmdServicios.Image = CType(resources.GetObject("cmdServicios.Image"), System.Drawing.Image)
        Me.cmdServicios.Name = "cmdServicios"
        Me.cmdServicios.Text = "Servicios"
        '
        'btnArticulos
        '
        Me.btnArticulos.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnArticulos.Command = Me.cmdArticulos
        Me.btnArticulos.ToolTipText = "Editar los artículos que el proveedor vende en ésta zona."
        '
        'btnServicios
        '
        Me.btnServicios.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnServicios.Command = Me.cmdServicios
        Me.btnServicios.SortOrder = 1
        Me.btnServicios.ToolTipText = "Editar la lista de servicios que el proveedor proporciona en ésta zona"
        '
        'imlZona
        '
        Me.imlZona.ImageStream = CType(resources.GetObject("imlZona.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlZona.TransparentColor = System.Drawing.Color.Transparent
        Me.imlZona.Images.SetKeyName(0, "General")
        Me.imlZona.Images.SetKeyName(1, "Zonas")
        Me.imlZona.Images.SetKeyName(2, "Proveedor")
        '
        'tabZona
        '
        Me.tabZona.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabZona.Controls.Add(Me.pagProveedores)
        Me.tabZona.ImageList = Me.imlZona
        Me.tabZona.Location = New System.Drawing.Point(12, 124)
        Me.tabZona.Name = "tabZona"
        Me.tabZona.Size = New System.Drawing.Size(836, 286)
        Me.tabZona.TabIndex = 32
        Me.tabZona.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabZona.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabZona.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagProveedores
        '
        Me.pagProveedores.Controls.Add(Me.grdProveedores)
        Me.pagProveedores.Controls.Add(Me.tlbProveedores)
        Me.pagProveedores.ImageIndex = 2
        Me.pagProveedores.Location = New System.Drawing.Point(1, 41)
        Me.pagProveedores.Name = "pagProveedores"
        Me.pagProveedores.Size = New System.Drawing.Size(834, 244)
        Me.pagProveedores.TabIndex = 0
        Me.pagProveedores.Text = "       Proveedores           .      "
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(63, 95)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(419, 20)
        Me.txtNombre.TabIndex = 37
        Me.txtNombre.UIName = "Nombre"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(10, 98)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 36
        Me.lblNombre.Text = "Nombre:"
        '
        'ZonasCompraForm
        '
        Me.AllowRecordNavigation = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 441)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.tabZona)
        Me.Name = "ZonasCompraForm"
        Me.Text = "ZonasCompraForm"
        Me.Controls.SetChildIndex(Me.tabZona, 0)
        Me.Controls.SetChildIndex(Me.lblNombre, 0)
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        CType(Me.grdProveedores,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.bsProveedores,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.C1CommandHolder1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tabZona,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabZona.ResumeLayout(false)
        Me.pagProveedores.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New ZonaCompraFacade
    End Sub
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents imlZona As System.Windows.Forms.ImageList
    Friend WithEvents tlbProveedores As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents cmdArticulos As C1.Win.C1Command.C1Command
    Friend WithEvents cmdServicios As C1.Win.C1Command.C1Command
    Friend WithEvents btnArticulos As C1.Win.C1Command.C1CommandLink
    Friend WithEvents btnServicios As C1.Win.C1Command.C1CommandLink
    Friend WithEvents grdProveedores As Azteca.Windows.Controls.AZTrueDBGrid
    Private WithEvents bsProveedores As System.Windows.Forms.BindingSource
    Friend WithEvents tabZona As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagProveedores As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblNombre As Azteca.Windows.Controls.CILabel
End Class
