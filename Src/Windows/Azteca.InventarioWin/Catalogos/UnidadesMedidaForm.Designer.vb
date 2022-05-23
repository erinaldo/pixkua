<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnidadesMedidaForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UnidadesMedidaForm))
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.grdUnidades = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsUnidades = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabUnidades = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagUnidades = New C1.Win.C1Command.C1DockingTabPage()
        Me.AzToolBar1 = New Azteca.Windows.Controls.AZToolBar()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.btnAddUnidad = New C1.Win.C1Command.C1CommandLink()
        Me.cmdAddUnidad = New C1.Win.C1Command.C1Command()
        CType(Me.grdUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabUnidades.SuspendLayout()
        Me.pagUnidades.SuspendLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(7, 105)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(83, 13)
        Me.CiLabel1.TabIndex = 0
        Me.CiLabel1.Text = "Tipo de Unidad:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(96, 102)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(386, 20)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.UIName = "Nombre"
        '
        'grdUnidades
        '
        Me.grdUnidades.DataSource = Me.bsUnidades
        Me.grdUnidades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdUnidades.FetchRowStyles = True
        Me.grdUnidades.FilterBar = True
        Me.grdUnidades.IDCatalogField = "IdUnidadMedida"
        Me.grdUnidades.Images.Add(CType(resources.GetObject("grdUnidades.Images"), System.Drawing.Image))
        Me.grdUnidades.Location = New System.Drawing.Point(0, 34)
        Me.grdUnidades.Name = "grdUnidades"
        Me.grdUnidades.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdUnidades.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdUnidades.PreviewInfo.ZoomFactor = 75.0R
        Me.grdUnidades.PrintInfo.PageSettings = CType(resources.GetObject("grdUnidades.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdUnidades.Size = New System.Drawing.Size(610, 271)
        Me.grdUnidades.TabIndex = 1
        Me.grdUnidades.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdUnidades.PropBag = resources.GetString("grdUnidades.PropBag")
        '
        'bsUnidades
        '
        Me.bsUnidades.AllowNew = False
        '
        'tabUnidades
        '
        Me.tabUnidades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabUnidades.Controls.Add(Me.pagUnidades)
        Me.tabUnidades.Location = New System.Drawing.Point(10, 130)
        Me.tabUnidades.Name = "tabUnidades"
        Me.tabUnidades.Size = New System.Drawing.Size(612, 330)
        Me.tabUnidades.TabIndex = 32
        Me.tabUnidades.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabUnidades.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabUnidades.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagUnidades
        '
        Me.pagUnidades.Controls.Add(Me.grdUnidades)
        Me.pagUnidades.Controls.Add(Me.AzToolBar1)
        Me.pagUnidades.Location = New System.Drawing.Point(1, 24)
        Me.pagUnidades.Name = "pagUnidades"
        Me.pagUnidades.Size = New System.Drawing.Size(610, 305)
        Me.pagUnidades.TabIndex = 0
        Me.pagUnidades.Text = "Unidades de Medida"
        '
        'AzToolBar1
        '
        Me.AzToolBar1.AccessibleName = "Tool Bar"
        Me.AzToolBar1.AutoSize = False
        Me.AzToolBar1.CommandHolder = Me.C1CommandHolder1
        Me.AzToolBar1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.btnAddUnidad})
        Me.AzToolBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.AzToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.AzToolBar1.MinButtonSize = 32
        Me.AzToolBar1.Movable = False
        Me.AzToolBar1.Name = "AzToolBar1"
        Me.AzToolBar1.Size = New System.Drawing.Size(610, 34)
        Me.AzToolBar1.Text = "AzToolBar1"
        Me.AzToolBar1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdAddUnidad)
        Me.C1CommandHolder1.Owner = Me
        '
        'btnAddUnidad
        '
        Me.btnAddUnidad.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnAddUnidad.Command = Me.cmdAddUnidad
        '
        'cmdAddUnidad
        '
        Me.cmdAddUnidad.Image = CType(resources.GetObject("cmdAddUnidad.Image"), System.Drawing.Image)
        Me.cmdAddUnidad.Name = "cmdAddUnidad"
        Me.cmdAddUnidad.Text = "Nueva Unidad de Medida"
        '
        'UnidadesMedidaForm
        '
        Me.AllowRecordNavigation = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 488)
        Me.Controls.Add(Me.tabUnidades)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.txtNombre)
        Me.Name = "UnidadesMedidaForm"
        Me.Text = "UnidadMedidaForm"
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.CiLabel1, 0)
        Me.Controls.SetChildIndex(Me.tabUnidades, 0)
        CType(Me.grdUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabUnidades.ResumeLayout(False)
        Me.pagUnidades.ResumeLayout(False)
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New TipoUnidadMedidaFacade
        LicenseModule = Kernel.Licensing.LicenseModule.Inventory
    End Sub
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents bsUnidades As System.Windows.Forms.BindingSource
    Friend WithEvents grdUnidades As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents tabUnidades As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagUnidades As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents AzToolBar1 As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents cmdAddUnidad As C1.Win.C1Command.C1Command
    Friend WithEvents btnAddUnidad As C1.Win.C1Command.C1CommandLink
End Class
