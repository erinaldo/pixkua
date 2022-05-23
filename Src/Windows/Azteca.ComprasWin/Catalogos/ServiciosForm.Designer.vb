<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServiciosForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ServiciosForm))
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.grdZonas = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsZonas = New System.Windows.Forms.BindingSource(Me.components)
        Me.tlbZona = New Azteca.Windows.Controls.AZToolBar()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdProveedores = New C1.Win.C1Command.C1Command()
        Me.btnProveedores = New C1.Win.C1Command.C1CommandLink()
        Me.imlServicio = New System.Windows.Forms.ImageList(Me.components)
        Me.tabServicio = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagGenerales = New C1.Win.C1Command.C1DockingTabPage()
        Me.pagZonas = New C1.Win.C1Command.C1DockingTabPage()
        CType(Me.grdZonas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsZonas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabServicio.SuspendLayout()
        Me.pagGenerales.SuspendLayout()
        Me.pagZonas.SuspendLayout()
        Me.SuspendLayout()
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(16, 18)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(47, 13)
        Me.CiLabel1.TabIndex = 25
        Me.CiLabel1.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(69, 15)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(332, 20)
        Me.txtNombre.TabIndex = 26
        Me.txtNombre.UIName = "Nombre"
        '
        'grdZonas
        '
        Me.grdZonas.AllowUpdate = False
        Me.grdZonas.DataSource = Me.bsZonas
        Me.grdZonas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdZonas.ExtendRightColumn = True
        Me.grdZonas.Images.Add(CType(resources.GetObject("grdZonas.Images"), System.Drawing.Image))
        Me.grdZonas.Location = New System.Drawing.Point(0, 37)
        Me.grdZonas.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.grdZonas.Name = "grdZonas"
        Me.grdZonas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdZonas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdZonas.PreviewInfo.ZoomFactor = 75.0R
        Me.grdZonas.PrintInfo.PageSettings = CType(resources.GetObject("grdZonas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdZonas.Size = New System.Drawing.Size(491, 206)
        Me.grdZonas.TabIndex = 1
        Me.grdZonas.Text = "AzTrueDBGrid1"
        Me.grdZonas.PropBag = resources.GetString("grdZonas.PropBag")
        '
        'tlbZona
        '
        Me.tlbZona.AccessibleName = "Tool Bar"
        Me.tlbZona.AutoSize = False
        Me.tlbZona.CommandHolder = Me.C1CommandHolder1
        Me.tlbZona.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.btnProveedores})
        Me.tlbZona.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbZona.Location = New System.Drawing.Point(0, 0)
        Me.tlbZona.MinButtonSize = 32
        Me.tlbZona.Movable = False
        Me.tlbZona.Name = "tlbZona"
        Me.tlbZona.Size = New System.Drawing.Size(491, 37)
        Me.tlbZona.Text = "AzToolBar1"
        Me.tlbZona.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tlbZona.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdProveedores)
        Me.C1CommandHolder1.Owner = Me
        '
        'cmdProveedores
        '
        Me.cmdProveedores.Image = CType(resources.GetObject("cmdProveedores.Image"), System.Drawing.Image)
        Me.cmdProveedores.Name = "cmdProveedores"
        Me.cmdProveedores.Text = "Proveedores"
        Me.cmdProveedores.ToolTipText = "Editar los proveedores asignados en la zona"
        '
        'btnProveedores
        '
        Me.btnProveedores.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnProveedores.Command = Me.cmdProveedores
        '
        'imlServicio
        '
        Me.imlServicio.ImageStream = CType(resources.GetObject("imlServicio.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlServicio.TransparentColor = System.Drawing.Color.Transparent
        Me.imlServicio.Images.SetKeyName(0, "General")
        Me.imlServicio.Images.SetKeyName(1, "Zonas")
        '
        'tabServicio
        '
        Me.tabServicio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabServicio.Controls.Add(Me.pagGenerales)
        Me.tabServicio.Controls.Add(Me.pagZonas)
        Me.tabServicio.ImageList = Me.imlServicio
        Me.tabServicio.Location = New System.Drawing.Point(12, 90)
        Me.tabServicio.Name = "tabServicio"
        Me.tabServicio.SelectedIndex = 1
        Me.tabServicio.Size = New System.Drawing.Size(493, 285)
        Me.tabServicio.TabIndex = 64
        Me.tabServicio.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabServicio.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabServicio.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagGenerales
        '
        Me.pagGenerales.Controls.Add(Me.txtNombre)
        Me.pagGenerales.Controls.Add(Me.CiLabel1)
        Me.pagGenerales.ImageIndex = 0
        Me.pagGenerales.Location = New System.Drawing.Point(1, 41)
        Me.pagGenerales.Name = "pagGenerales"
        Me.pagGenerales.Size = New System.Drawing.Size(491, 243)
        Me.pagGenerales.TabIndex = 0
        Me.pagGenerales.Text = "General"
        '
        'pagZonas
        '
        Me.pagZonas.Controls.Add(Me.grdZonas)
        Me.pagZonas.Controls.Add(Me.tlbZona)
        Me.pagZonas.ImageIndex = 1
        Me.pagZonas.Location = New System.Drawing.Point(1, 41)
        Me.pagZonas.Name = "pagZonas"
        Me.pagZonas.Size = New System.Drawing.Size(491, 243)
        Me.pagZonas.TabIndex = 1
        Me.pagZonas.Text = "Zonas de Compra"
        '
        'ServiciosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 403)
        Me.Controls.Add(Me.tabServicio)
        Me.KeyMode = Azteca.Windows.Forms.BusinessForms.CatalogForm.UserKeyMode.UserDefined
        Me.Name = "ServiciosForm"
        Me.Text = "ServiciosForm"
        Me.Controls.SetChildIndex(Me.tabServicio, 0)
        CType(Me.grdZonas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsZonas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabServicio.ResumeLayout(False)
        Me.pagGenerales.ResumeLayout(False)
        Me.pagGenerales.PerformLayout()
        Me.pagZonas.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New ServicioFacade
    End Sub
    Friend WithEvents imlServicio As System.Windows.Forms.ImageList
    Friend WithEvents grdZonas As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents tlbZona As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents cmdProveedores As C1.Win.C1Command.C1Command
    Friend WithEvents btnProveedores As C1.Win.C1Command.C1CommandLink
    Private WithEvents bsZonas As System.Windows.Forms.BindingSource
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents tabServicio As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagGenerales As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagZonas As C1.Win.C1Command.C1DockingTabPage
End Class
