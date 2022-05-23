<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BancosForm
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
        Dim Style1 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style2 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style3 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style4 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style5 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BancosForm))
        Dim Style6 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style7 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style8 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style9 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style10 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style11 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style12 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style13 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style14 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style15 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style16 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Me.lblCuenta = New Azteca.Windows.Controls.CILabel()
        Me.selCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.lblNombre = New Azteca.Windows.Controls.CILabel()
        Me.dropCajas = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.bsCajas = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdChequeras = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsChequeras = New System.Windows.Forms.BindingSource(Me.components)
        Me.dropFormatos = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.bsFormatos = New System.Windows.Forms.BindingSource(Me.components)
        Me.iLstTab = New System.Windows.Forms.ImageList(Me.components)
        Me.tabBancos = New Azteca.Windows.Controls.AZDockingTab()
        Me.C1DockingTabPage1 = New C1.Win.C1Command.C1DockingTabPage()
        CType(Me.dropCajas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCajas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdChequeras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsChequeras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dropFormatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsFormatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabBancos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBancos.SuspendLayout()
        Me.C1DockingTabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Location = New System.Drawing.Point(55, 129)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(44, 13)
        Me.lblCuenta.TabIndex = 37
        Me.lblCuenta.Text = "Cuenta:"
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
        Me.selCuenta.Location = New System.Drawing.Point(121, 125)
        Me.selCuenta.Name = "selCuenta"
        Me.selCuenta.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selCuenta.Size = New System.Drawing.Size(326, 23)
        Me.selCuenta.TabIndex = 36
        Me.selCuenta.TextWidth = 100
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(121, 99)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(326, 20)
        Me.txtNombre.TabIndex = 35
        Me.txtNombre.UIName = "Nombre"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(55, 102)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 34
        Me.lblNombre.Text = "Nombre:"
        '
        'dropCajas
        '
        Me.dropCajas.AllowColMove = True
        Me.dropCajas.AllowColSelect = True
        Me.dropCajas.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.dropCajas.AlternatingRows = True
        Me.dropCajas.CaptionStyle = Style1
        Me.dropCajas.ColumnCaptionHeight = 17
        Me.dropCajas.ColumnFooterHeight = 17
        Me.dropCajas.DataSource = Me.bsCajas
        Me.dropCajas.DisplayMember = "Caja"
        Me.dropCajas.EvenRowStyle = Style2
        Me.dropCajas.FetchRowStyles = False
        Me.dropCajas.FooterStyle = Style3
        Me.dropCajas.HeadingStyle = Style4
        Me.dropCajas.HighLightRowStyle = Style5
        Me.dropCajas.Images.Add(CType(resources.GetObject("dropCajas.Images"), System.Drawing.Image))
        Me.dropCajas.Location = New System.Drawing.Point(278, 59)
        Me.dropCajas.Name = "dropCajas"
        Me.dropCajas.OddRowStyle = Style6
        Me.dropCajas.RecordSelectorStyle = Style7
        Me.dropCajas.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.dropCajas.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.dropCajas.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.dropCajas.ScrollTips = False
        Me.dropCajas.Size = New System.Drawing.Size(306, 135)
        Me.dropCajas.Style = Style8
        Me.dropCajas.TabIndex = 50
        Me.dropCajas.TabStop = False
        Me.dropCajas.Text = "C1TrueDBDropdown1"
        Me.dropCajas.ValueMember = "IdCaja"
        Me.dropCajas.ValueTranslate = True
        Me.dropCajas.Visible = False
        Me.dropCajas.PropBag = resources.GetString("dropCajas.PropBag")
        '
        'grdChequeras
        '
        Me.grdChequeras.AllowAddNew = True
        Me.grdChequeras.DataSource = Me.bsChequeras
        Me.grdChequeras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdChequeras.IDCatalogField = "IdCaja"
        Me.grdChequeras.Images.Add(CType(resources.GetObject("grdChequeras.Images"), System.Drawing.Image))
        Me.grdChequeras.Images.Add(CType(resources.GetObject("grdChequeras.Images1"), System.Drawing.Image))
        Me.grdChequeras.Images.Add(CType(resources.GetObject("grdChequeras.Images2"), System.Drawing.Image))
        Me.grdChequeras.Location = New System.Drawing.Point(0, 0)
        Me.grdChequeras.Name = "grdChequeras"
        Me.grdChequeras.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdChequeras.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdChequeras.PreviewInfo.ZoomFactor = 75.0R
        Me.grdChequeras.PrintInfo.PageSettings = CType(resources.GetObject("grdChequeras.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdChequeras.RowHeight = 16
        Me.grdChequeras.ShowEditButton = False
        Me.grdChequeras.Size = New System.Drawing.Size(918, 197)
        Me.grdChequeras.TabIndex = 41
        Me.grdChequeras.Text = "AzTrueDBGrid1"
        Me.grdChequeras.PropBag = resources.GetString("grdChequeras.PropBag")
        '
        'dropFormatos
        '
        Me.dropFormatos.AllowColMove = True
        Me.dropFormatos.AllowColSelect = True
        Me.dropFormatos.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.dropFormatos.AlternatingRows = True
        Me.dropFormatos.CaptionStyle = Style9
        Me.dropFormatos.ColumnCaptionHeight = 17
        Me.dropFormatos.ColumnFooterHeight = 17
        Me.dropFormatos.DataSource = Me.bsFormatos
        Me.dropFormatos.DisplayMember = "Nombre"
        Me.dropFormatos.EvenRowStyle = Style10
        Me.dropFormatos.FetchRowStyles = False
        Me.dropFormatos.FooterStyle = Style11
        Me.dropFormatos.HeadingStyle = Style12
        Me.dropFormatos.HighLightRowStyle = Style13
        Me.dropFormatos.Images.Add(CType(resources.GetObject("dropFormatos.Images"), System.Drawing.Image))
        Me.dropFormatos.Location = New System.Drawing.Point(590, 63)
        Me.dropFormatos.Name = "dropFormatos"
        Me.dropFormatos.OddRowStyle = Style14
        Me.dropFormatos.RecordSelectorStyle = Style15
        Me.dropFormatos.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.dropFormatos.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.dropFormatos.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.dropFormatos.ScrollTips = False
        Me.dropFormatos.Size = New System.Drawing.Size(306, 135)
        Me.dropFormatos.Style = Style16
        Me.dropFormatos.TabIndex = 51
        Me.dropFormatos.TabStop = False
        Me.dropFormatos.Text = "C1TrueDBDropdown1"
        Me.dropFormatos.ValueMember = "IdFormato"
        Me.dropFormatos.ValueTranslate = True
        Me.dropFormatos.Visible = False
        Me.dropFormatos.PropBag = resources.GetString("dropFormatos.PropBag")
        '
        'iLstTab
        '
        Me.iLstTab.ImageStream = CType(resources.GetObject("iLstTab.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.iLstTab.TransparentColor = System.Drawing.Color.Transparent
        Me.iLstTab.Images.SetKeyName(0, "check_32.png")
        '
        'tabBancos
        '
        Me.tabBancos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabBancos.Controls.Add(Me.C1DockingTabPage1)
        Me.tabBancos.ImageList = Me.iLstTab
        Me.tabBancos.Location = New System.Drawing.Point(12, 154)
        Me.tabBancos.Name = "tabBancos"
        Me.tabBancos.Size = New System.Drawing.Size(920, 239)
        Me.tabBancos.TabIndex = 52
        Me.tabBancos.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2003
        Me.tabBancos.VisualStyle = C1.Win.C1Command.VisualStyle.Office2003Blue
        Me.tabBancos.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2003Blue
        '
        'C1DockingTabPage1
        '
        Me.C1DockingTabPage1.Controls.Add(Me.dropFormatos)
        Me.C1DockingTabPage1.Controls.Add(Me.dropCajas)
        Me.C1DockingTabPage1.Controls.Add(Me.grdChequeras)
        Me.C1DockingTabPage1.ImageIndex = 0
        Me.C1DockingTabPage1.Location = New System.Drawing.Point(1, 41)
        Me.C1DockingTabPage1.Name = "C1DockingTabPage1"
        Me.C1DockingTabPage1.Size = New System.Drawing.Size(918, 197)
        Me.C1DockingTabPage1.TabIndex = 0
        Me.C1DockingTabPage1.Text = "Chequeras"
        '
        'BancosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 421)
        Me.Controls.Add(Me.selCuenta)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblCuenta)
        Me.Controls.Add(Me.tabBancos)
        Me.Name = "BancosForm"
        Me.Text = "BancosForm"
        Me.Controls.SetChildIndex(Me.tabBancos, 0)
        Me.Controls.SetChildIndex(Me.lblCuenta, 0)
        Me.Controls.SetChildIndex(Me.lblNombre, 0)
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.selCuenta, 0)
        CType(Me.dropCajas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCajas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdChequeras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsChequeras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dropFormatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsFormatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabBancos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBancos.ResumeLayout(False)
        Me.C1DockingTabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCuenta As Azteca.Windows.Controls.CILabel
    Friend WithEvents selCuenta As Azteca.Windows.Contabilidad.CuentaSelector
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblNombre As Azteca.Windows.Controls.CILabel
    Friend WithEvents grdChequeras As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents dropCajas As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents bsCajas As System.Windows.Forms.BindingSource

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Facade = New BancoFacade
    End Sub
    Friend WithEvents bsChequeras As System.Windows.Forms.BindingSource
    Friend WithEvents iLstTab As System.Windows.Forms.ImageList
    Friend WithEvents dropFormatos As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents bsFormatos As System.Windows.Forms.BindingSource
    Friend WithEvents tabBancos As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents C1DockingTabPage1 As C1.Win.C1Command.C1DockingTabPage
End Class
