<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MetaAlmacenesForm
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
        Dim Style9 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style10 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style11 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style12 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style13 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MetaAlmacenesForm))
        Dim Style14 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style15 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style16 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.tabAsignaciones = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagAsignaciones = New C1.Win.C1Command.C1DockingTabPage()
        Me.grdAsignaciones = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsAsignaciones = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboAlmacenes = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.bsAlmacenes = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.tabAsignaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAsignaciones.SuspendLayout()
        Me.pagAsignaciones.SuspendLayout()
        CType(Me.grdAsignaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAsignaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAlmacenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAlmacenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(7, 93)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(47, 13)
        Me.CiLabel1.TabIndex = 32
        Me.CiLabel1.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(69, 90)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(413, 20)
        Me.txtNombre.TabIndex = 33
        Me.txtNombre.UIName = "Nombre"
        '
        'tabAsignaciones
        '
        Me.tabAsignaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabAsignaciones.Controls.Add(Me.pagAsignaciones)
        Me.tabAsignaciones.Location = New System.Drawing.Point(12, 116)
        Me.tabAsignaciones.Name = "tabAsignaciones"
        Me.tabAsignaciones.Size = New System.Drawing.Size(470, 230)
        Me.tabAsignaciones.TabIndex = 34
        Me.tabAsignaciones.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabAsignaciones.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabAsignaciones.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagAsignaciones
        '
        Me.pagAsignaciones.Controls.Add(Me.cboAlmacenes)
        Me.pagAsignaciones.Controls.Add(Me.grdAsignaciones)
        Me.pagAsignaciones.Location = New System.Drawing.Point(1, 24)
        Me.pagAsignaciones.Name = "pagAsignaciones"
        Me.pagAsignaciones.Size = New System.Drawing.Size(468, 205)
        Me.pagAsignaciones.TabIndex = 0
        Me.pagAsignaciones.Text = "Asignaciones"
        '
        'grdAsignaciones
        '
        Me.grdAsignaciones.DataSource = Me.bsAsignaciones
        Me.grdAsignaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdAsignaciones.ExtendRightColumn = True
        Me.grdAsignaciones.FilterBar = True
        Me.grdAsignaciones.Images.Add(CType(resources.GetObject("grdAsignaciones.Images"), System.Drawing.Image))
        Me.grdAsignaciones.Location = New System.Drawing.Point(0, 0)
        Me.grdAsignaciones.Name = "grdAsignaciones"
        Me.grdAsignaciones.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdAsignaciones.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdAsignaciones.PreviewInfo.ZoomFactor = 75.0R
        Me.grdAsignaciones.PrintInfo.PageSettings = CType(resources.GetObject("AzTrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdAsignaciones.Size = New System.Drawing.Size(468, 205)
        Me.grdAsignaciones.TabIndex = 0
        Me.grdAsignaciones.Text = "AzTrueDBGrid1"
        Me.grdAsignaciones.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdAsignaciones.PropBag = resources.GetString("grdAsignaciones.PropBag")
        '
        'cboAlmacenes
        '
        Me.cboAlmacenes.AllowColMove = True
        Me.cboAlmacenes.AllowColSelect = True
        Me.cboAlmacenes.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboAlmacenes.AlternatingRows = False
        Me.cboAlmacenes.CaptionStyle = Style9
        Me.cboAlmacenes.ColumnCaptionHeight = 17
        Me.cboAlmacenes.ColumnFooterHeight = 17
        Me.cboAlmacenes.DataSource = Me.bsAlmacenes
        Me.cboAlmacenes.DisplayMember = "Nombre"
        Me.cboAlmacenes.EvenRowStyle = Style10
        Me.cboAlmacenes.ExtendRightColumn = True
        Me.cboAlmacenes.FetchRowStyles = False
        Me.cboAlmacenes.FooterStyle = Style11
        Me.cboAlmacenes.HeadingStyle = Style12
        Me.cboAlmacenes.HighLightRowStyle = Style13
        Me.cboAlmacenes.Images.Add(CType(resources.GetObject("cboAlmacenes.Images"), System.Drawing.Image))
        Me.cboAlmacenes.Location = New System.Drawing.Point(16, 55)
        Me.cboAlmacenes.Name = "cboAlmacenes"
        Me.cboAlmacenes.OddRowStyle = Style14
        Me.cboAlmacenes.RecordSelectorStyle = Style15
        Me.cboAlmacenes.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboAlmacenes.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboAlmacenes.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboAlmacenes.ScrollTips = False
        Me.cboAlmacenes.Size = New System.Drawing.Size(261, 147)
        Me.cboAlmacenes.Style = Style16
        Me.cboAlmacenes.TabIndex = 1
        Me.cboAlmacenes.TabStop = False
        Me.cboAlmacenes.Text = "C1TrueDBDropdown1"
        Me.cboAlmacenes.ValueMember = "IdAlmacen"
        Me.cboAlmacenes.Visible = False
        Me.cboAlmacenes.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.cboAlmacenes.PropBag = resources.GetString("cboAlmacenes.PropBag")
        '
        'MetaAlmacenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 374)
        Me.Controls.Add(Me.tabAsignaciones)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.txtNombre)
        Me.Name = "MetaAlmacenes"
        Me.Text = "MetaAlmacenes"
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.CiLabel1, 0)
        Me.Controls.SetChildIndex(Me.tabAsignaciones, 0)
        CType(Me.tabAsignaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAsignaciones.ResumeLayout(False)
        Me.pagAsignaciones.ResumeLayout(False)
        CType(Me.grdAsignaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAsignaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAlmacenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAlmacenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New MetaAlmacenFacade
    End Sub
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents tabAsignaciones As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagAsignaciones As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents grdAsignaciones As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents bsAsignaciones As System.Windows.Forms.BindingSource
    Friend WithEvents cboAlmacenes As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents bsAlmacenes As System.Windows.Forms.BindingSource
End Class
