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
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.chkConceptoLibre = New Azteca.Windows.Controls.CICheckBox()
        Me.txtEstCom = New Azteca.Windows.Ventas.EstructuraComercialSelector()
        Me.tabServicios = New Azteca.Windows.Controls.CITab()
        Me.pagGeneral = New System.Windows.Forms.TabPage()
        Me.txtCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.pagZonas = New System.Windows.Forms.TabPage()
        Me.tlbZonas = New Azteca.Windows.Controls.CIToolBar()
        Me.btnAgregarZona = New System.Windows.Forms.ToolStripButton()
        Me.grdZonas = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsZonas = New System.Windows.Forms.BindingSource(Me.components)
        Me.imlServicios = New System.Windows.Forms.ImageList(Me.components)
        Me.tabServicios.SuspendLayout()
        Me.pagGeneral.SuspendLayout()
        Me.pagZonas.SuspendLayout()
        Me.tlbZonas.SuspendLayout()
        CType(Me.grdZonas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsZonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(16, 27)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(47, 13)
        Me.CiLabel1.TabIndex = 0
        Me.CiLabel1.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(129, 24)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(290, 20)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.UIName = "Nombre"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(16, 53)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(107, 13)
        Me.CiLabel2.TabIndex = 2
        Me.CiLabel2.Text = "Estructura Comercial:"
        '
        'chkConceptoLibre
        '
        Me.chkConceptoLibre.AutoSize = True
        Me.chkConceptoLibre.Location = New System.Drawing.Point(129, 118)
        Me.chkConceptoLibre.Name = "chkConceptoLibre"
        Me.chkConceptoLibre.Size = New System.Drawing.Size(131, 17)
        Me.chkConceptoLibre.TabIndex = 6
        Me.chkConceptoLibre.Text = "Permite concepto libre"
        Me.chkConceptoLibre.UseVisualStyleBackColor = True
        '
        'txtEstCom
        '
        Me.txtEstCom.AnySite = False
        Me.txtEstCom.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtEstCom.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtEstCom.EditorAssembly = "Azteca.VentasWin"
        Me.txtEstCom.EditorClass = "Azteca.Windows.Ventas.EstComercialForm"
        Me.txtEstCom.EditorTitle = "Editar nodo de estructura comercial..."
        Me.txtEstCom.Key = 0
        Me.txtEstCom.Linked = False
        Me.txtEstCom.Location = New System.Drawing.Point(129, 50)
        Me.txtEstCom.Name = "txtEstCom"
        Me.txtEstCom.RequiredField = True
        Me.txtEstCom.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.txtEstCom.Size = New System.Drawing.Size(290, 23)
        Me.txtEstCom.TabIndex = 3
        Me.txtEstCom.UIName = "Est. Comercial"
        '
        'tabServicios
        '
        Me.tabServicios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabServicios.Controls.Add(Me.pagGeneral)
        Me.tabServicios.Controls.Add(Me.pagZonas)
        Me.tabServicios.ImageList = Me.imlServicios
        Me.tabServicios.ItemSize = New System.Drawing.Size(71, 32)
        Me.tabServicios.Location = New System.Drawing.Point(0, 90)
        Me.tabServicios.Name = "tabServicios"
        Me.tabServicios.SelectedIndex = 0
        Me.tabServicios.Size = New System.Drawing.Size(555, 274)
        Me.tabServicios.TabIndex = 18
        '
        'pagGeneral
        '
        Me.pagGeneral.Controls.Add(Me.txtCuenta)
        Me.pagGeneral.Controls.Add(Me.CiLabel3)
        Me.pagGeneral.Controls.Add(Me.txtNombre)
        Me.pagGeneral.Controls.Add(Me.txtEstCom)
        Me.pagGeneral.Controls.Add(Me.chkConceptoLibre)
        Me.pagGeneral.Controls.Add(Me.CiLabel1)
        Me.pagGeneral.Controls.Add(Me.CiLabel2)
        Me.pagGeneral.ImageKey = "General"
        Me.pagGeneral.Location = New System.Drawing.Point(4, 36)
        Me.pagGeneral.Name = "pagGeneral"
        Me.pagGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.pagGeneral.Size = New System.Drawing.Size(547, 234)
        Me.pagGeneral.TabIndex = 0
        Me.pagGeneral.Text = "General"
        Me.pagGeneral.UseVisualStyleBackColor = True
        '
        'txtCuenta
        '
        Me.txtCuenta.AnySite = False
        Me.txtCuenta.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtCuenta.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCuenta.EditorAssembly = "Azteca.ContabilidadWin"
        Me.txtCuenta.EditorClass = "Azteca.Windows.Contabilidad.CuentaForm"
        Me.txtCuenta.EditorTitle = "Editar Cuenta..."
        Me.txtCuenta.Key = 0
        Me.txtCuenta.Linked = False
        Me.txtCuenta.Location = New System.Drawing.Point(129, 79)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.txtCuenta.Size = New System.Drawing.Size(290, 23)
        Me.txtCuenta.TabIndex = 5
        Me.txtCuenta.TextWidth = 100
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(16, 82)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(44, 13)
        Me.CiLabel3.TabIndex = 4
        Me.CiLabel3.Text = "Cuenta:"
        '
        'pagZonas
        '
        Me.pagZonas.Controls.Add(Me.tlbZonas)
        Me.pagZonas.Controls.Add(Me.grdZonas)
        Me.pagZonas.ImageKey = "Zonas"
        Me.pagZonas.Location = New System.Drawing.Point(4, 36)
        Me.pagZonas.Name = "pagZonas"
        Me.pagZonas.Padding = New System.Windows.Forms.Padding(3)
        Me.pagZonas.Size = New System.Drawing.Size(547, 245)
        Me.pagZonas.TabIndex = 1
        Me.pagZonas.Text = "Zonas de Venta"
        Me.pagZonas.UseVisualStyleBackColor = True
        '
        'tlbZonas
        '
        Me.tlbZonas.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tlbZonas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAgregarZona})
        Me.tlbZonas.Location = New System.Drawing.Point(3, 3)
        Me.tlbZonas.Name = "tlbZonas"
        Me.tlbZonas.Size = New System.Drawing.Size(541, 39)
        Me.tlbZonas.TabIndex = 1
        '
        'btnAgregarZona
        '
        Me.btnAgregarZona.Image = Global.Azteca.Windows.Ventas.My.Resources.Resources.Zonas_add_32
        Me.btnAgregarZona.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgregarZona.Name = "btnAgregarZona"
        Me.btnAgregarZona.Size = New System.Drawing.Size(115, 36)
        Me.btnAgregarZona.Text = "Agregar Zona"
        '
        'grdZonas
        '
        Me.grdZonas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdZonas.DataSource = Me.bsZonas
        Me.grdZonas.FilterBar = True
        Me.grdZonas.IDCatalogField = "IdZonaVenta"
        Me.grdZonas.Images.Add(CType(resources.GetObject("grdZonas.Images"), System.Drawing.Image))
        Me.grdZonas.Location = New System.Drawing.Point(3, 45)
        Me.grdZonas.Name = "grdZonas"
        Me.grdZonas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdZonas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdZonas.PreviewInfo.ZoomFactor = 75.0R
        Me.grdZonas.PrintInfo.PageSettings = CType(resources.GetObject("grdZonas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdZonas.Size = New System.Drawing.Size(541, 197)
        Me.grdZonas.TabIndex = 0
        Me.grdZonas.PropBag = resources.GetString("grdZonas.PropBag")
        '
        'imlServicios
        '
        Me.imlServicios.ImageStream = CType(resources.GetObject("imlServicios.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlServicios.TransparentColor = System.Drawing.Color.Transparent
        Me.imlServicios.Images.SetKeyName(0, "General")
        Me.imlServicios.Images.SetKeyName(1, "Zonas")
        '
        'ServiciosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 389)
        Me.Controls.Add(Me.tabServicios)
        Me.KeyMode = Azteca.Windows.Forms.BusinessForms.CatalogForm.UserKeyMode.UserDefined
        Me.Name = "ServiciosForm"
        Me.Text = "ServiciosForm"
        Me.Controls.SetChildIndex(Me.tabServicios, 0)
        Me.tabServicios.ResumeLayout(False)
        Me.pagGeneral.ResumeLayout(False)
        Me.pagGeneral.PerformLayout()
        Me.pagZonas.ResumeLayout(False)
        Me.pagZonas.PerformLayout()
        Me.tlbZonas.ResumeLayout(False)
        Me.tlbZonas.PerformLayout()
        CType(Me.grdZonas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsZonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New ServicioFacade
    End Sub
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents chkConceptoLibre As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents txtEstCom As Azteca.Windows.Ventas.EstructuraComercialSelector
    Friend WithEvents tabServicios As Azteca.Windows.Controls.CITab
    Friend WithEvents pagGeneral As System.Windows.Forms.TabPage
    Friend WithEvents pagZonas As System.Windows.Forms.TabPage
    Friend WithEvents tlbZonas As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnAgregarZona As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdZonas As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents bsZonas As System.Windows.Forms.BindingSource
    Friend WithEvents imlServicios As System.Windows.Forms.ImageList
    Friend WithEvents txtCuenta As Azteca.Windows.Contabilidad.CuentaSelector
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
End Class
