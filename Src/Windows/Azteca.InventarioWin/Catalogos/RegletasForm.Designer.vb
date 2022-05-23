<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegletasForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegletasForm))
        Me.tabRegletas = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagClasificaciones = New C1.Win.C1Command.C1DockingTabPage()
        Me.bsTallas = New System.Windows.Forms.BindingSource(Me.components)
        Me.imlTallas = New System.Windows.Forms.ImageList(Me.components)
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.selCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.lblCuenta = New Azteca.Windows.Controls.CILabel()
        Me.grdTallas = New Azteca.Windows.Controls.AZTrueDBGrid()
        CType(Me.tabRegletas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabRegletas.SuspendLayout()
        Me.pagClasificaciones.SuspendLayout()
        CType(Me.bsTallas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdTallas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabRegletas
        '
        Me.tabRegletas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabRegletas.Controls.Add(Me.pagClasificaciones)
        Me.tabRegletas.ImageList = Me.imlTallas
        Me.tabRegletas.Location = New System.Drawing.Point(24, 154)
        Me.tabRegletas.Name = "tabRegletas"
        Me.tabRegletas.Size = New System.Drawing.Size(458, 260)
        Me.tabRegletas.TabIndex = 35
        Me.tabRegletas.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabRegletas.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabRegletas.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagClasificaciones
        '
        Me.pagClasificaciones.Controls.Add(Me.grdTallas)
        Me.pagClasificaciones.ImageIndex = 0
        Me.pagClasificaciones.Location = New System.Drawing.Point(1, 41)
        Me.pagClasificaciones.Name = "pagClasificaciones"
        Me.pagClasificaciones.Size = New System.Drawing.Size(456, 218)
        Me.pagClasificaciones.TabIndex = 0
        Me.pagClasificaciones.Text = "Tallas"
        '
        'imlTallas
        '
        Me.imlTallas.ImageStream = CType(resources.GetObject("imlTallas.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlTallas.TransparentColor = System.Drawing.Color.Transparent
        Me.imlTallas.Images.SetKeyName(0, "square_32.png")
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(55, 97)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(47, 13)
        Me.CiLabel1.TabIndex = 33
        Me.CiLabel1.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(120, 94)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(361, 20)
        Me.txtNombre.TabIndex = 34
        Me.txtNombre.UIName = "Nombre"
        '
        'selCuenta
        '
        Me.selCuenta.AnySite = False
        Me.selCuenta.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selCuenta.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.selCuenta.EditorAssembly = "Azteca.ContabilidadWin"
        Me.selCuenta.EditorClass = "Azteca.Windows.Contabilidad.CuentaForm"
        Me.selCuenta.EditorTitle = "Editar Cuenta..."
        Me.selCuenta.Key = 0
        Me.selCuenta.Linked = False
        Me.selCuenta.Location = New System.Drawing.Point(120, 116)
        Me.selCuenta.Name = "selCuenta"
        Me.selCuenta.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selCuenta.Size = New System.Drawing.Size(361, 23)
        Me.selCuenta.TabIndex = 36
        Me.selCuenta.TextWidth = 100
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Location = New System.Drawing.Point(55, 120)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(44, 13)
        Me.lblCuenta.TabIndex = 37
        Me.lblCuenta.Text = "Cuenta:"
        '
        'grdTallas
        '
        Me.grdTallas.AllowAddNew = True
        Me.grdTallas.AllowDelete = True
        Me.grdTallas.DataSource = Me.bsTallas
        Me.grdTallas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdTallas.Images.Add(CType(resources.GetObject("grdTallas.Images"), System.Drawing.Image))
        Me.grdTallas.Location = New System.Drawing.Point(0, 0)
        Me.grdTallas.Name = "grdTallas"
        Me.grdTallas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdTallas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdTallas.PreviewInfo.ZoomFactor = 75.0R
        Me.grdTallas.PrintInfo.PageSettings = CType(resources.GetObject("AzTrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdTallas.Size = New System.Drawing.Size(456, 218)
        Me.grdTallas.TabIndex = 0
        Me.grdTallas.Text = "AzTrueDBGrid1"
        Me.grdTallas.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdTallas.PropBag = resources.GetString("grdTallas.PropBag")
        '
        'RegletasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 442)
        Me.Controls.Add(Me.lblCuenta)
        Me.Controls.Add(Me.selCuenta)
        Me.Controls.Add(Me.tabRegletas)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.CiLabel1)
        Me.Name = "RegletasForm"
        Me.Text = "RegletasForm"
        Me.Controls.SetChildIndex(Me.CiLabel1, 0)
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.tabRegletas, 0)
        Me.Controls.SetChildIndex(Me.selCuenta, 0)
        Me.Controls.SetChildIndex(Me.lblCuenta, 0)
        CType(Me.tabRegletas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabRegletas.ResumeLayout(False)
        Me.pagClasificaciones.ResumeLayout(False)
        CType(Me.bsTallas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdTallas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabRegletas As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagClasificaciones As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents imlTallas As System.Windows.Forms.ImageList
    Friend WithEvents bsTallas As System.Windows.Forms.BindingSource
    Friend WithEvents selCuenta As Azteca.Windows.Contabilidad.CuentaSelector
    Friend WithEvents lblCuenta As Azteca.Windows.Controls.CILabel

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Facade = New RegletaFacade
    End Sub
    Friend WithEvents grdTallas As Azteca.Windows.Controls.AZTrueDBGrid

End Class
