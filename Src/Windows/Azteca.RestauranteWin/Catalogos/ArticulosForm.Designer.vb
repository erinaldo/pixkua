<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArticulosForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ArticulosForm))
        Me.tabArticulos = New Azteca.Windows.Controls.CITab()
        Me.tabGenerales = New System.Windows.Forms.TabPage()
        Me.cboTipoUnidad = New Azteca.Windows.Inventario.TiposUnidadComboBox()
        Me.cboUnidadMedida = New Azteca.Windows.Inventario.UnidadesMedidaComboBox()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.lbCategoria = New Azteca.Windows.Controls.CILabel()
        Me.cboCategorias = New Azteca.Windows.Restaurante.CategoriasComboBox()
        Me.lblCuenta = New Azteca.Windows.Controls.CILabel()
        Me.selCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.tabPresentacion = New System.Windows.Forms.TabPage()
        Me.lblColorBOX = New Azteca.Windows.Controls.CILabel()
        Me.cmdColor = New Azteca.Windows.Controls.CIButton()
        Me.lblColor = New Azteca.Windows.Controls.CILabel()
        Me.lbImagen = New Azteca.Windows.Controls.CILabel()
        Me.picMngrImage = New Azteca.Windows.Controls.CIPictureManager()
        Me.iLstTabs = New System.Windows.Forms.ImageList(Me.components)
        Me.dlgColor = New System.Windows.Forms.ColorDialog()
        Me.tabArticulos.SuspendLayout()
        Me.tabGenerales.SuspendLayout()
        Me.tabPresentacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabArticulos
        '
        Me.tabArticulos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabArticulos.Controls.Add(Me.tabGenerales)
        Me.tabArticulos.Controls.Add(Me.tabPresentacion)
        Me.tabArticulos.ImageList = Me.iLstTabs
        Me.tabArticulos.Location = New System.Drawing.Point(-4, 90)
        Me.tabArticulos.Name = "tabArticulos"
        Me.tabArticulos.SelectedIndex = 0
        Me.tabArticulos.Size = New System.Drawing.Size(541, 251)
        Me.tabArticulos.TabIndex = 27
        '
        'tabGenerales
        '
        Me.tabGenerales.Controls.Add(Me.cboTipoUnidad)
        Me.tabGenerales.Controls.Add(Me.cboUnidadMedida)
        Me.tabGenerales.Controls.Add(Me.txtNombre)
        Me.tabGenerales.Controls.Add(Me.CiLabel3)
        Me.tabGenerales.Controls.Add(Me.CiLabel1)
        Me.tabGenerales.Controls.Add(Me.lbCategoria)
        Me.tabGenerales.Controls.Add(Me.cboCategorias)
        Me.tabGenerales.Controls.Add(Me.lblCuenta)
        Me.tabGenerales.Controls.Add(Me.selCuenta)
        Me.tabGenerales.ImageIndex = 1
        Me.tabGenerales.Location = New System.Drawing.Point(4, 39)
        Me.tabGenerales.Name = "tabGenerales"
        Me.tabGenerales.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGenerales.Size = New System.Drawing.Size(533, 208)
        Me.tabGenerales.TabIndex = 0
        Me.tabGenerales.Text = "Datos Generales"
        Me.tabGenerales.UseVisualStyleBackColor = True
        '
        'cboTipoUnidad
        '
        Me.cboTipoUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoUnidad.FormattingEnabled = True
        Me.cboTipoUnidad.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboTipoUnidad.ItemsTable = Nothing
        Me.cboTipoUnidad.Location = New System.Drawing.Point(132, 43)
        Me.cboTipoUnidad.Name = "cboTipoUnidad"
        Me.cboTipoUnidad.Size = New System.Drawing.Size(107, 21)
        Me.cboTipoUnidad.TabIndex = 34
        Me.cboTipoUnidad.UIName = Nothing
        '
        'cboUnidadMedida
        '
        Me.cboUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnidadMedida.FormattingEnabled = True
        Me.cboUnidadMedida.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboUnidadMedida.ItemsTable = Nothing
        Me.cboUnidadMedida.Location = New System.Drawing.Point(245, 42)
        Me.cboUnidadMedida.Name = "cboUnidadMedida"
        Me.cboUnidadMedida.RequiredField = True
        Me.cboUnidadMedida.Size = New System.Drawing.Size(184, 21)
        Me.cboUnidadMedida.TabIndex = 35
        Me.cboUnidadMedida.UIName = "Unidad Medida"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(132, 16)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(297, 20)
        Me.txtNombre.TabIndex = 32
        Me.txtNombre.UIName = "Nombre"
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(17, 46)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(109, 13)
        Me.CiLabel3.TabIndex = 33
        Me.CiLabel3.Text = "Unidad de Inventario:"
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(17, 20)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(47, 13)
        Me.CiLabel1.TabIndex = 31
        Me.CiLabel1.Text = "Nombre:"
        '
        'lbCategoria
        '
        Me.lbCategoria.AutoSize = True
        Me.lbCategoria.Location = New System.Drawing.Point(17, 138)
        Me.lbCategoria.Name = "lbCategoria"
        Me.lbCategoria.Size = New System.Drawing.Size(52, 13)
        Me.lbCategoria.TabIndex = 28
        Me.lbCategoria.Text = "Categoria"
        '
        'cboCategorias
        '
        Me.cboCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategorias.FormattingEnabled = True
        Me.cboCategorias.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboCategorias.ItemsTable = Nothing
        Me.cboCategorias.Location = New System.Drawing.Point(132, 134)
        Me.cboCategorias.Name = "cboCategorias"
        Me.cboCategorias.Size = New System.Drawing.Size(275, 21)
        Me.cboCategorias.TabIndex = 27
        Me.cboCategorias.UIName = Nothing
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Location = New System.Drawing.Point(17, 113)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(41, 13)
        Me.lblCuenta.TabIndex = 25
        Me.lblCuenta.Text = "Cuenta"
        '
        'selCuenta
        '
        Me.selCuenta.AnySite = False
        Me.selCuenta.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selCuenta.EditorAssembly = "Azteca.ContabilidadWin"
        Me.selCuenta.EditorClass = "Azteca.Windows.Contabilidad.CuentaForm"
        Me.selCuenta.EditorTitle = "Editar Cuenta..."
        Me.selCuenta.Key = 0
        Me.selCuenta.Linked = False
        Me.selCuenta.Location = New System.Drawing.Point(132, 108)
        Me.selCuenta.Name = "selCuenta"
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
        Me.tabPresentacion.Size = New System.Drawing.Size(533, 208)
        Me.tabPresentacion.TabIndex = 1
        Me.tabPresentacion.Text = "Presentacion"
        Me.tabPresentacion.UseVisualStyleBackColor = True
        '
        'lblColorBOX
        '
        Me.lblColorBOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblColorBOX.Location = New System.Drawing.Point(170, 169)
        Me.lblColorBOX.Name = "lblColorBOX"
        Me.lblColorBOX.Size = New System.Drawing.Size(104, 23)
        Me.lblColorBOX.TabIndex = 30
        '
        'cmdColor
        '
        Me.cmdColor.Location = New System.Drawing.Point(275, 168)
        Me.cmdColor.Name = "cmdColor"
        Me.cmdColor.Size = New System.Drawing.Size(26, 25)
        Me.cmdColor.TabIndex = 29
        Me.cmdColor.UseVisualStyleBackColor = True
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(125, 174)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(31, 13)
        Me.lblColor.TabIndex = 28
        Me.lblColor.Text = "Color"
        '
        'lbImagen
        '
        Me.lbImagen.AutoSize = True
        Me.lbImagen.Location = New System.Drawing.Point(114, 29)
        Me.lbImagen.Name = "lbImagen"
        Me.lbImagen.Size = New System.Drawing.Size(42, 13)
        Me.lbImagen.TabIndex = 27
        Me.lbImagen.Text = "Imagen"
        '
        'picMngrImage
        '
        Me.picMngrImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picMngrImage.Image = Nothing
        Me.picMngrImage.Location = New System.Drawing.Point(173, 29)
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
        Me.iLstTabs.Images.SetKeyName(1, "food_32.png")
        '
        'ArticulosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 369)
        Me.Controls.Add(Me.tabArticulos)
        Me.KeyMode = Azteca.Windows.Forms.BusinessForms.CatalogForm.UserKeyMode.UserDefined
        Me.Name = "ArticulosForm"
        Me.Text = "ArticulosForm"
        Me.Controls.SetChildIndex(Me.tabArticulos, 0)
        Me.tabArticulos.ResumeLayout(False)
        Me.tabGenerales.ResumeLayout(False)
        Me.tabGenerales.PerformLayout()
        Me.tabPresentacion.ResumeLayout(False)
        Me.tabPresentacion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Facade = New Azteca.Business.Restaurante.ArticuloFacade
    End Sub
    Friend WithEvents tabArticulos As Azteca.Windows.Controls.CITab
    Friend WithEvents tabGenerales As System.Windows.Forms.TabPage
    Friend WithEvents lblCuenta As Azteca.Windows.Controls.CILabel
    Friend WithEvents selCuenta As Azteca.Windows.Contabilidad.CuentaSelector
    Friend WithEvents tabPresentacion As System.Windows.Forms.TabPage
    Friend WithEvents lblColorBOX As Azteca.Windows.Controls.CILabel
    Friend WithEvents cmdColor As Azteca.Windows.Controls.CIButton
    Friend WithEvents lblColor As Azteca.Windows.Controls.CILabel
    Friend WithEvents lbImagen As Azteca.Windows.Controls.CILabel
    Friend WithEvents picMngrImage As Azteca.Windows.Controls.CIPictureManager
    Friend WithEvents lbCategoria As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboCategorias As Azteca.Windows.Restaurante.CategoriasComboBox
    Friend WithEvents dlgColor As System.Windows.Forms.ColorDialog
    Friend WithEvents iLstTabs As System.Windows.Forms.ImageList
    Public WithEvents cboTipoUnidad As Azteca.Windows.Inventario.TiposUnidadComboBox
    Public WithEvents cboUnidadMedida As Azteca.Windows.Inventario.UnidadesMedidaComboBox
    Public WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
End Class
