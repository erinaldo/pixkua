<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CategoriasForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CategoriasForm))
        Me.lblCuenta = New Azteca.Windows.Controls.CILabel()
        Me.tabCategoria = New Azteca.Windows.Controls.CITab()
        Me.tabGenerales = New System.Windows.Forms.TabPage()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.lblNombre = New Azteca.Windows.Controls.CILabel()
        Me.gbxDetalle = New Azteca.Windows.Controls.CIGroupBox()
        Me.grdArt = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsArticulos = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbMenu = New Azteca.Windows.Controls.CIToolBar()
        Me.btnNuevoArt = New System.Windows.Forms.ToolStripButton()
        Me.selCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.tabPresentacion = New System.Windows.Forms.TabPage()
        Me.lblColorBOX = New Azteca.Windows.Controls.CILabel()
        Me.cmdColor = New Azteca.Windows.Controls.CIButton()
        Me.lblColor = New Azteca.Windows.Controls.CILabel()
        Me.lbImagen = New Azteca.Windows.Controls.CILabel()
        Me.picMngrImage = New Azteca.Windows.Controls.CIPictureManager()
        Me.iLstTabs = New System.Windows.Forms.ImageList(Me.components)
        Me.dlgColor = New System.Windows.Forms.ColorDialog()
        Me.tabCategoria.SuspendLayout()
        Me.tabGenerales.SuspendLayout()
        Me.gbxDetalle.SuspendLayout()
        CType(Me.grdArt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbMenu.SuspendLayout()
        Me.tabPresentacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Location = New System.Drawing.Point(44, 37)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(41, 13)
        Me.lblCuenta.TabIndex = 25
        Me.lblCuenta.Text = "Cuenta"
        '
        'tabCategoria
        '
        Me.tabCategoria.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabCategoria.Controls.Add(Me.tabGenerales)
        Me.tabCategoria.Controls.Add(Me.tabPresentacion)
        Me.tabCategoria.ImageList = Me.iLstTabs
        Me.tabCategoria.Location = New System.Drawing.Point(12, 90)
        Me.tabCategoria.Name = "tabCategoria"
        Me.tabCategoria.SelectedIndex = 0
        Me.tabCategoria.Size = New System.Drawing.Size(541, 331)
        Me.tabCategoria.TabIndex = 26
        '
        'tabGenerales
        '
        Me.tabGenerales.Controls.Add(Me.txtNombre)
        Me.tabGenerales.Controls.Add(Me.lblNombre)
        Me.tabGenerales.Controls.Add(Me.gbxDetalle)
        Me.tabGenerales.Controls.Add(Me.lblCuenta)
        Me.tabGenerales.Controls.Add(Me.selCuenta)
        Me.tabGenerales.ImageIndex = 1
        Me.tabGenerales.Location = New System.Drawing.Point(4, 39)
        Me.tabGenerales.Name = "tabGenerales"
        Me.tabGenerales.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGenerales.Size = New System.Drawing.Size(533, 288)
        Me.tabGenerales.TabIndex = 0
        Me.tabGenerales.Text = "Datos Generales"
        Me.tabGenerales.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(90, 10)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(417, 20)
        Me.txtNombre.TabIndex = 27
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(42, 13)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 26
        Me.lblNombre.Text = "Nombre"
        '
        'gbxDetalle
        '
        Me.gbxDetalle.Controls.Add(Me.grdArt)
        Me.gbxDetalle.Controls.Add(Me.tbMenu)
        Me.gbxDetalle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbxDetalle.Location = New System.Drawing.Point(3, 61)
        Me.gbxDetalle.Name = "gbxDetalle"
        Me.gbxDetalle.Size = New System.Drawing.Size(527, 224)
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
        Me.grdArt.ShowDeleteButton = False
        Me.grdArt.ShowEditButton = False
        Me.grdArt.Size = New System.Drawing.Size(521, 166)
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
        Me.selCuenta.Location = New System.Drawing.Point(90, 32)
        Me.selCuenta.Name = "selCuenta"
        Me.selCuenta.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selCuenta.Size = New System.Drawing.Size(230, 23)
        Me.selCuenta.TabIndex = 24
        Me.selCuenta.TextWidth = 100
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
        Me.tabPresentacion.Size = New System.Drawing.Size(533, 302)
        Me.tabPresentacion.TabIndex = 1
        Me.tabPresentacion.Text = "Presentacion"
        Me.tabPresentacion.UseVisualStyleBackColor = True
        '
        'lblColorBOX
        '
        Me.lblColorBOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblColorBOX.Location = New System.Drawing.Point(170, 180)
        Me.lblColorBOX.Name = "lblColorBOX"
        Me.lblColorBOX.Size = New System.Drawing.Size(104, 23)
        Me.lblColorBOX.TabIndex = 30
        '
        'cmdColor
        '
        Me.cmdColor.Location = New System.Drawing.Point(275, 179)
        Me.cmdColor.Name = "cmdColor"
        Me.cmdColor.Size = New System.Drawing.Size(26, 25)
        Me.cmdColor.TabIndex = 29
        Me.cmdColor.UseVisualStyleBackColor = True
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(125, 185)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(31, 13)
        Me.lblColor.TabIndex = 28
        Me.lblColor.Text = "Color"
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
        Me.iLstTabs.Images.SetKeyName(1, "cake_32.png")
        '
        'CategoriasForm
        '
        Me.AllowRecordNavigation = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 449)
        Me.Controls.Add(Me.tabCategoria)
        Me.Name = "CategoriasForm"
        Me.Text = "CategoriasForm"
        Me.Controls.SetChildIndex(Me.tabCategoria, 0)
        Me.tabCategoria.ResumeLayout(False)
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
    Friend WithEvents selCuenta As Azteca.Windows.Contabilidad.CuentaSelector
    Friend WithEvents lblCuenta As Azteca.Windows.Controls.CILabel
    Friend WithEvents tabCategoria As Azteca.Windows.Controls.CITab
    Friend WithEvents tabGenerales As System.Windows.Forms.TabPage
    Friend WithEvents gbxDetalle As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents grdArt As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents tbMenu As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnNuevoArt As System.Windows.Forms.ToolStripButton
    Friend WithEvents tabPresentacion As System.Windows.Forms.TabPage
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblNombre As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblColorBOX As Azteca.Windows.Controls.CILabel
    Friend WithEvents cmdColor As Azteca.Windows.Controls.CIButton
    Friend WithEvents lblColor As Azteca.Windows.Controls.CILabel
    Friend WithEvents lbImagen As Azteca.Windows.Controls.CILabel
    Friend WithEvents picMngrImage As Azteca.Windows.Controls.CIPictureManager
    Friend WithEvents dlgColor As System.Windows.Forms.ColorDialog

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Facade = New Azteca.Business.Restaurante.CategoriaFacade

    End Sub
    Friend WithEvents iLstTabs As System.Windows.Forms.ImageList
    Friend WithEvents bsArticulos As System.Windows.Forms.BindingSource
End Class
