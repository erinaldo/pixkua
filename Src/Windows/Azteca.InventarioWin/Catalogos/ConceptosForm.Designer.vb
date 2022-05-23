<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConceptosForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConceptosForm))
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.grdConceptos = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsConceptos = New System.Windows.Forms.BindingSource(Me.components)
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdAddConcepto = New C1.Win.C1Command.C1Command()
        Me.pagConceptos = New C1.Win.C1Command.C1DockingTabPage()
        Me.tabConceptos = New Azteca.Windows.Controls.AZDockingTab()
        Me.AzToolBar1 = New Azteca.Windows.Controls.AZToolBar()
        Me.btnAddConcepto = New C1.Win.C1Command.C1CommandLink()
        CType(Me.grdConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagConceptos.SuspendLayout()
        CType(Me.tabConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabConceptos.SuspendLayout()
        Me.SuspendLayout()
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(7, 95)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(57, 13)
        Me.CiLabel1.TabIndex = 19
        Me.CiLabel1.Text = "Categoría:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(69, 92)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(413, 20)
        Me.txtNombre.TabIndex = 20
        Me.txtNombre.UIName = "Nombre"
        '
        'grdConceptos
        '
        Me.grdConceptos.DataSource = Me.bsConceptos
        Me.grdConceptos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdConceptos.FetchRowStyles = True
        Me.grdConceptos.FilterBar = True
        Me.grdConceptos.IDCatalogField = "IdConcepto"
        Me.grdConceptos.Images.Add(CType(resources.GetObject("grdConceptos.Images"), System.Drawing.Image))
        Me.grdConceptos.Location = New System.Drawing.Point(0, 34)
        Me.grdConceptos.Name = "grdConceptos"
        Me.grdConceptos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdConceptos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdConceptos.PreviewInfo.ZoomFactor = 75.0R
        Me.grdConceptos.PrintInfo.PageSettings = CType(resources.GetObject("grdConceptos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdConceptos.Size = New System.Drawing.Size(601, 214)
        Me.grdConceptos.TabIndex = 1
        Me.grdConceptos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdConceptos.PropBag = resources.GetString("grdConceptos.PropBag")
        '
        'bsConceptos
        '
        Me.bsConceptos.AllowNew = False
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdAddConcepto)
        Me.C1CommandHolder1.Owner = Me
        '
        'cmdAddConcepto
        '
        Me.cmdAddConcepto.Image = Global.Azteca.Windows.Inventario.My.Resources.Resources.Conceptos_add_32
        Me.cmdAddConcepto.Name = "cmdAddConcepto"
        Me.cmdAddConcepto.Text = "Agregar Concepto"
        '
        'pagConceptos
        '
        Me.pagConceptos.Controls.Add(Me.grdConceptos)
        Me.pagConceptos.Controls.Add(Me.AzToolBar1)
        Me.pagConceptos.Location = New System.Drawing.Point(1, 24)
        Me.pagConceptos.Name = "pagConceptos"
        Me.pagConceptos.Size = New System.Drawing.Size(601, 248)
        Me.pagConceptos.TabIndex = 1
        Me.pagConceptos.Text = "Conceptos"
        '
        'tabConceptos
        '
        Me.tabConceptos.Controls.Add(Me.pagConceptos)
        Me.tabConceptos.Location = New System.Drawing.Point(10, 118)
        Me.tabConceptos.Name = "tabConceptos"
        Me.tabConceptos.SelectedIndex = 1
        Me.tabConceptos.Size = New System.Drawing.Size(603, 273)
        Me.tabConceptos.TabIndex = 32
        Me.tabConceptos.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabConceptos.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabConceptos.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'AzToolBar1
        '
        Me.AzToolBar1.AccessibleName = "Tool Bar"
        Me.AzToolBar1.AutoSize = False
        Me.AzToolBar1.CommandHolder = Me.C1CommandHolder1
        Me.AzToolBar1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.btnAddConcepto})
        Me.AzToolBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.AzToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.AzToolBar1.MinButtonSize = 32
        Me.AzToolBar1.Movable = False
        Me.AzToolBar1.Name = "AzToolBar1"
        Me.AzToolBar1.Size = New System.Drawing.Size(601, 34)
        Me.AzToolBar1.Text = "AzToolBar1"
        Me.AzToolBar1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'btnAddConcepto
        '
        Me.btnAddConcepto.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnAddConcepto.Command = Me.cmdAddConcepto
        '
        'ConceptosForm
        '
        Me.AllowRecordNavigation = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 419)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.tabConceptos)
        Me.Name = "ConceptosForm"
        Me.Text = "ConceptosForm"
        Me.Controls.SetChildIndex(Me.tabConceptos, 0)
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.CiLabel1, 0)
        CType(Me.grdConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagConceptos.ResumeLayout(False)
        CType(Me.tabConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabConceptos.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New ClasificacionConceptoFacade
        LicenseModule = Kernel.Licensing.LicenseModule.Inventory
    End Sub
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents grdConceptos As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents cmdAddConcepto As C1.Win.C1Command.C1Command
    Friend WithEvents tabConceptos As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagConceptos As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents AzToolBar1 As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents btnAddConcepto As C1.Win.C1Command.C1CommandLink
    Private WithEvents bsConceptos As System.Windows.Forms.BindingSource
End Class
