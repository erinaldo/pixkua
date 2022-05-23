<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CentrosProduccionForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CentrosProduccionForm))
        Me.tabCentroProduccion = New Azteca.Windows.Controls.CITab()
        Me.tabGenerales = New System.Windows.Forms.TabPage()
        Me.cboImpresora = New Azteca.Windows.Controls.ImpresorasComboBox()
        Me.lblLineaProdccion = New Azteca.Windows.Controls.CILabel()
        Me.lblPrinter = New Azteca.Windows.Controls.CILabel()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.lblNombre = New Azteca.Windows.Controls.CILabel()
        Me.lblCuenta = New Azteca.Windows.Controls.CILabel()
        Me.selCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.gbxDetalle = New Azteca.Windows.Controls.CIGroupBox()
        Me.grdArt = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsArticulos = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbMenu = New Azteca.Windows.Controls.CIToolBar()
        Me.btnNuevoArt = New System.Windows.Forms.ToolStripButton()
        Me.tabPresentacion = New System.Windows.Forms.TabPage()
        Me.lblColorBOX = New Azteca.Windows.Controls.CILabel()
        Me.cmdColor = New Azteca.Windows.Controls.CIButton()
        Me.lblColor = New Azteca.Windows.Controls.CILabel()
        Me.lbImagen = New Azteca.Windows.Controls.CILabel()
        Me.picMngrImage = New Azteca.Windows.Controls.CIPictureManager()
        Me.iLstTabs = New System.Windows.Forms.ImageList(Me.components)
        Me.tabCentroProduccion.SuspendLayout()
        Me.tabGenerales.SuspendLayout()
        Me.gbxDetalle.SuspendLayout()
        CType(Me.grdArt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbMenu.SuspendLayout()
        Me.tabPresentacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabCentroProduccion
        '
        Me.tabCentroProduccion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabCentroProduccion.Controls.Add(Me.tabGenerales)
        Me.tabCentroProduccion.Controls.Add(Me.tabPresentacion)
        Me.tabCentroProduccion.ImageList = Me.iLstTabs
        Me.tabCentroProduccion.Location = New System.Drawing.Point(7, 90)
        Me.tabCentroProduccion.Name = "tabCentroProduccion"
        Me.tabCentroProduccion.SelectedIndex = 0
        Me.tabCentroProduccion.Size = New System.Drawing.Size(541, 346)
        Me.tabCentroProduccion.TabIndex = 35
        '
        'tabGenerales
        '
        Me.tabGenerales.Controls.Add(Me.cboImpresora)
        Me.tabGenerales.Controls.Add(Me.lblLineaProdccion)
        Me.tabGenerales.Controls.Add(Me.lblPrinter)
        Me.tabGenerales.Controls.Add(Me.txtNombre)
        Me.tabGenerales.Controls.Add(Me.lblNombre)
        Me.tabGenerales.Controls.Add(Me.lblCuenta)
        Me.tabGenerales.Controls.Add(Me.selCuenta)
        Me.tabGenerales.Controls.Add(Me.gbxDetalle)
        Me.tabGenerales.ImageIndex = 1
        Me.tabGenerales.Location = New System.Drawing.Point(4, 39)
        Me.tabGenerales.Name = "tabGenerales"
        Me.tabGenerales.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGenerales.Size = New System.Drawing.Size(533, 303)
        Me.tabGenerales.TabIndex = 0
        Me.tabGenerales.Text = "Datos Generales"
        Me.tabGenerales.UseVisualStyleBackColor = True
        '
        'cboImpresora
        '
        Me.cboImpresora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboImpresora.FormattingEnabled = True
        Me.cboImpresora.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboImpresora.ItemsTable = Nothing
        Me.cboImpresora.Location = New System.Drawing.Point(128, 67)
        Me.cboImpresora.Name = "cboImpresora"
        Me.cboImpresora.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboImpresora.Size = New System.Drawing.Size(369, 21)
        Me.cboImpresora.TabIndex = 42
        Me.cboImpresora.UIName = Nothing
        '
        'lblLineaProdccion
        '
        Me.lblLineaProdccion.AutoSize = True
        Me.lblLineaProdccion.Location = New System.Drawing.Point(18, 94)
        Me.lblLineaProdccion.Name = "lblLineaProdccion"
        Me.lblLineaProdccion.Size = New System.Drawing.Size(105, 13)
        Me.lblLineaProdccion.TabIndex = 41
        Me.lblLineaProdccion.Text = "Linea de Producción"
        '
        'lblPrinter
        '
        Me.lblPrinter.AutoSize = True
        Me.lblPrinter.Location = New System.Drawing.Point(70, 68)
        Me.lblPrinter.Name = "lblPrinter"
        Me.lblPrinter.Size = New System.Drawing.Size(53, 13)
        Me.lblPrinter.TabIndex = 39
        Me.lblPrinter.Text = "Impresora"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(128, 18)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(370, 20)
        Me.txtNombre.TabIndex = 38
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(81, 21)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 37
        Me.lblNombre.Text = "Nombre"
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Location = New System.Drawing.Point(83, 45)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(41, 13)
        Me.lblCuenta.TabIndex = 36
        Me.lblCuenta.Text = "Cuenta"
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
        Me.selCuenta.Location = New System.Drawing.Point(128, 41)
        Me.selCuenta.Name = "selCuenta"
        Me.selCuenta.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selCuenta.Size = New System.Drawing.Size(230, 23)
        Me.selCuenta.TabIndex = 35
        Me.selCuenta.TextWidth = 100
        '
        'gbxDetalle
        '
        Me.gbxDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxDetalle.Controls.Add(Me.grdArt)
        Me.gbxDetalle.Controls.Add(Me.tbMenu)
        Me.gbxDetalle.Location = New System.Drawing.Point(3, 119)
        Me.gbxDetalle.Name = "gbxDetalle"
        Me.gbxDetalle.Size = New System.Drawing.Size(527, 181)
        Me.gbxDetalle.TabIndex = 24
        Me.gbxDetalle.TabStop = False
        '
        'grdArt
        '
        Me.grdArt.AlternatingRows = True
        Me.grdArt.DataSource = Me.bsArticulos
        Me.grdArt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdArt.IDCatalogField = "IdArticulo"
        Me.grdArt.Images.Add(CType(resources.GetObject("grdArt.Images"), System.Drawing.Image))
        Me.grdArt.Location = New System.Drawing.Point(3, 55)
        Me.grdArt.Name = "grdArt"
        Me.grdArt.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdArt.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdArt.PreviewInfo.ZoomFactor = 75.0R
        Me.grdArt.PrintInfo.PageSettings = CType(resources.GetObject("grdArt.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdArt.ShowEditButton = False
        Me.grdArt.Size = New System.Drawing.Size(521, 123)
        Me.grdArt.TabIndex = 27
        Me.grdArt.PropBag = resources.GetString("grdArt.PropBag")
        '
        'tbMenu
        '
        Me.tbMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoArt})
        Me.tbMenu.Location = New System.Drawing.Point(3, 16)
        Me.tbMenu.Name = "tbMenu"
        Me.tbMenu.Size = New System.Drawing.Size(521, 39)
        Me.tbMenu.TabIndex = 28
        Me.tbMenu.Text = "CiToolBar1"
        '
        'btnNuevoArt
        '
        Me.btnNuevoArt.Image = CType(resources.GetObject("btnNuevoArt.Image"), System.Drawing.Image)
        Me.btnNuevoArt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevoArt.Name = "btnNuevoArt"
        Me.btnNuevoArt.Size = New System.Drawing.Size(119, 36)
        Me.btnNuevoArt.Text = "Incluir articulo"
        '
        'tabPresentacion
        '
        Me.tabPresentacion.Controls.Add(Me.lblColorBOX)
        Me.tabPresentacion.Controls.Add(Me.cmdColor)
        Me.tabPresentacion.Controls.Add(Me.lblColor)
        Me.tabPresentacion.Controls.Add(Me.lbImagen)
        Me.tabPresentacion.Controls.Add(Me.picMngrImage)
        Me.tabPresentacion.ImageIndex = 0
        Me.tabPresentacion.Location = New System.Drawing.Point(4, 39)
        Me.tabPresentacion.Name = "tabPresentacion"
        Me.tabPresentacion.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPresentacion.Size = New System.Drawing.Size(533, 317)
        Me.tabPresentacion.TabIndex = 1
        Me.tabPresentacion.Text = "Presentacion"
        Me.tabPresentacion.UseVisualStyleBackColor = True
        '
        'lblColorBOX
        '
        Me.lblColorBOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblColorBOX.Location = New System.Drawing.Point(170, 180)
        Me.lblColorBOX.Name = "lblColorBOX"
        Me.lblColorBOX.Size = New System.Drawing.Size(128, 23)
        Me.lblColorBOX.TabIndex = 30
        Me.lblColorBOX.Visible = False
        '
        'cmdColor
        '
        Me.cmdColor.Location = New System.Drawing.Point(301, 179)
        Me.cmdColor.Name = "cmdColor"
        Me.cmdColor.Size = New System.Drawing.Size(26, 25)
        Me.cmdColor.TabIndex = 29
        Me.cmdColor.UseVisualStyleBackColor = True
        Me.cmdColor.Visible = False
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(125, 185)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(31, 13)
        Me.lblColor.TabIndex = 28
        Me.lblColor.Text = "Color"
        Me.lblColor.Visible = False
        '
        'lbImagen
        '
        Me.lbImagen.AutoSize = True
        Me.lbImagen.Location = New System.Drawing.Point(114, 40)
        Me.lbImagen.Name = "lbImagen"
        Me.lbImagen.Size = New System.Drawing.Size(42, 13)
        Me.lbImagen.TabIndex = 27
        Me.lbImagen.Text = "Imagen"
        '
        'picMngrImage
        '
        Me.picMngrImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picMngrImage.Image = Nothing
        Me.picMngrImage.Location = New System.Drawing.Point(173, 40)
        Me.picMngrImage.Name = "picMngrImage"
        Me.picMngrImage.Size = New System.Drawing.Size(125, 123)
        Me.picMngrImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
        Me.picMngrImage.TabIndex = 0
        Me.picMngrImage.UIName = Nothing
        '
        'iLstTabs
        '
        Me.iLstTabs.ImageStream = CType(resources.GetObject("iLstTabs.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.iLstTabs.TransparentColor = System.Drawing.Color.Transparent
        Me.iLstTabs.Images.SetKeyName(0, "mask_32.png")
        Me.iLstTabs.Images.SetKeyName(1, "industry_32.png")
        '
        'CentrosProduccionForm
        '
        Me.AllowRecordNavigation = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 464)
        Me.Controls.Add(Me.tabCentroProduccion)
        Me.Name = "CentrosProduccionForm"
        Me.Text = "CentrosProduccionForm"
        Me.Controls.SetChildIndex(Me.tabCentroProduccion, 0)
        Me.tabCentroProduccion.ResumeLayout(False)
        Me.tabGenerales.ResumeLayout(False)
        Me.tabGenerales.PerformLayout()
        Me.gbxDetalle.ResumeLayout(False)
        Me.gbxDetalle.PerformLayout()
        CType(Me.grdArt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbMenu.ResumeLayout(False)
        Me.tbMenu.PerformLayout()
        Me.tabPresentacion.ResumeLayout(False)
        Me.tabPresentacion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Facade = New CentroProduccionFacade
    End Sub
    Friend WithEvents tabCentroProduccion As Azteca.Windows.Controls.CITab
    Friend WithEvents tabGenerales As System.Windows.Forms.TabPage
    Friend WithEvents lblPrinter As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblNombre As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCuenta As Azteca.Windows.Controls.CILabel
    Friend WithEvents selCuenta As Azteca.Windows.Contabilidad.CuentaSelector
    Friend WithEvents gbxDetalle As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents grdArt As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents tbMenu As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnNuevoArt As System.Windows.Forms.ToolStripButton
    Friend WithEvents tabPresentacion As System.Windows.Forms.TabPage
    Friend WithEvents lblColorBOX As Azteca.Windows.Controls.CILabel
    Friend WithEvents cmdColor As Azteca.Windows.Controls.CIButton
    Friend WithEvents lblColor As Azteca.Windows.Controls.CILabel
    Friend WithEvents lbImagen As Azteca.Windows.Controls.CILabel
    Friend WithEvents picMngrImage As Azteca.Windows.Controls.CIPictureManager
    Friend WithEvents lblLineaProdccion As Azteca.Windows.Controls.CILabel
    Friend WithEvents iLstTabs As System.Windows.Forms.ImageList
    Friend WithEvents cboImpresora As Azteca.Windows.Controls.ImpresorasComboBox
    Friend WithEvents bsArticulos As System.Windows.Forms.BindingSource
End Class
