<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CentrosRecepcionForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CentrosRecepcionForm))
        Me.lblAlmacen = New Azteca.Windows.Controls.CILabel()
        Me.cboAlmacenes = New Azteca.Windows.Inventario.AlmacenesComboBox()
        Me.lblCuenta = New Azteca.Windows.Controls.CILabel()
        Me.selCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.lblNombre = New Azteca.Windows.Controls.CILabel()
        Me.lblMunicipio = New Azteca.Windows.Controls.CILabel()
        Me.txtMunicipio = New Azteca.Windows.Controls.General.MunicipioSelector()
        Me.txtFax = New Azteca.Windows.Controls.CITextBox()
        Me.lblFax = New Azteca.Windows.Controls.CILabel()
        Me.txtTel2 = New Azteca.Windows.Controls.CITextBox()
        Me.lblTel2 = New Azteca.Windows.Controls.CILabel()
        Me.txtTel1 = New Azteca.Windows.Controls.CITextBox()
        Me.lblTel1 = New Azteca.Windows.Controls.CILabel()
        Me.txtPoblacion = New Azteca.Windows.Controls.General.PoblacionSelector()
        Me.txtCP = New Azteca.Windows.Controls.CITextBox()
        Me.txtColonia = New Azteca.Windows.Controls.CITextBox()
        Me.txtNumInt = New Azteca.Windows.Controls.CITextBox()
        Me.txtNumExt = New Azteca.Windows.Controls.CITextBox()
        Me.txtCalle = New Azteca.Windows.Controls.CITextBox()
        Me.lblPoblacion = New Azteca.Windows.Controls.CILabel()
        Me.lblCodigoPostal = New Azteca.Windows.Controls.CILabel()
        Me.lblNumInt = New Azteca.Windows.Controls.CILabel()
        Me.lblNumExt = New Azteca.Windows.Controls.CILabel()
        Me.lblColonia = New Azteca.Windows.Controls.CILabel()
        Me.lblCalle = New Azteca.Windows.Controls.CILabel()
        Me.imlTab = New System.Windows.Forms.ImageList(Me.components)
        Me.tabCentrosRecepcion = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagGeneral = New C1.Win.C1Command.C1DockingTabPage()
        Me.pagNotificaciones = New C1.Win.C1Command.C1DockingTabPage()
        CType(Me.tabCentrosRecepcion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCentrosRecepcion.SuspendLayout()
        Me.pagGeneral.SuspendLayout()
        Me.pagNotificaciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAlmacen
        '
        Me.lblAlmacen.AutoSize = True
        Me.lblAlmacen.BackColor = System.Drawing.Color.Transparent
        Me.lblAlmacen.Location = New System.Drawing.Point(15, 75)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(51, 13)
        Me.lblAlmacen.TabIndex = 35
        Me.lblAlmacen.Text = "Almacen:"
        '
        'cboAlmacenes
        '
        Me.cboAlmacenes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacenes.FormattingEnabled = True
        Me.cboAlmacenes.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboAlmacenes.ItemsTable = Nothing
        Me.cboAlmacenes.Location = New System.Drawing.Point(72, 72)
        Me.cboAlmacenes.Name = "cboAlmacenes"
        Me.cboAlmacenes.Size = New System.Drawing.Size(345, 21)
        Me.cboAlmacenes.TabIndex = 34
        Me.cboAlmacenes.UIName = Nothing
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.BackColor = System.Drawing.Color.Transparent
        Me.lblCuenta.Location = New System.Drawing.Point(15, 45)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(44, 13)
        Me.lblCuenta.TabIndex = 32
        Me.lblCuenta.Text = "Cuenta:"
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
        Me.selCuenta.Location = New System.Drawing.Point(72, 43)
        Me.selCuenta.Name = "selCuenta"
        Me.selCuenta.Size = New System.Drawing.Size(345, 23)
        Me.selCuenta.TabIndex = 31
        Me.selCuenta.TextWidth = 100
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(72, 17)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(345, 20)
        Me.txtNombre.TabIndex = 30
        Me.txtNombre.UIName = "Nombre"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Location = New System.Drawing.Point(15, 19)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 29
        Me.lblNombre.Text = "Nombre:"
        '
        'lblMunicipio
        '
        Me.lblMunicipio.AutoSize = True
        Me.lblMunicipio.BackColor = System.Drawing.Color.Transparent
        Me.lblMunicipio.Location = New System.Drawing.Point(21, 176)
        Me.lblMunicipio.Name = "lblMunicipio"
        Me.lblMunicipio.Size = New System.Drawing.Size(55, 13)
        Me.lblMunicipio.TabIndex = 57
        Me.lblMunicipio.Text = "Municipio:"
        '
        'txtMunicipio
        '
        Me.txtMunicipio.AnySite = False
        Me.txtMunicipio.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtMunicipio.EditorAssembly = "Azteca.Windows"
        Me.txtMunicipio.EditorClass = "Azteca.Windows.Forms.General.CatalogoMunicipios"
        Me.txtMunicipio.EditorTitle = "Editar municipio..."
        Me.txtMunicipio.Key = 0
        Me.txtMunicipio.Linked = False
        Me.txtMunicipio.Location = New System.Drawing.Point(102, 171)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(369, 23)
        Me.txtMunicipio.TabIndex = 56
        Me.txtMunicipio.TextWidth = 70
        Me.txtMunicipio.UIName = "Municipio"
        '
        'txtFax
        '
        Me.txtFax.Digits = True
        Me.txtFax.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtFax.Location = New System.Drawing.Point(235, 95)
        Me.txtFax.MaxLength = 10
        Me.txtFax.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFax.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFax.Name = "txtFax"
        Me.txtFax.RegularExpression = "\d{5}"
        Me.txtFax.Size = New System.Drawing.Size(70, 20)
        Me.txtFax.TabIndex = 55
        Me.txtFax.UIName = "Telefono 2"
        '
        'lblFax
        '
        Me.lblFax.AutoSize = True
        Me.lblFax.BackColor = System.Drawing.Color.Transparent
        Me.lblFax.Location = New System.Drawing.Point(192, 98)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(27, 13)
        Me.lblFax.TabIndex = 54
        Me.lblFax.Text = "Fax:"
        '
        'txtTel2
        '
        Me.txtTel2.Digits = True
        Me.txtTel2.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTel2.Location = New System.Drawing.Point(235, 121)
        Me.txtTel2.MaxLength = 10
        Me.txtTel2.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTel2.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTel2.Name = "txtTel2"
        Me.txtTel2.RegularExpression = "\d{5}"
        Me.txtTel2.Size = New System.Drawing.Size(70, 20)
        Me.txtTel2.TabIndex = 53
        Me.txtTel2.UIName = "Telefono 2"
        '
        'lblTel2
        '
        Me.lblTel2.AutoSize = True
        Me.lblTel2.BackColor = System.Drawing.Color.Transparent
        Me.lblTel2.Location = New System.Drawing.Point(192, 124)
        Me.lblTel2.Name = "lblTel2"
        Me.lblTel2.Size = New System.Drawing.Size(37, 13)
        Me.lblTel2.TabIndex = 52
        Me.lblTel2.Text = "Tel. 2:"
        '
        'txtTel1
        '
        Me.txtTel1.Digits = True
        Me.txtTel1.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTel1.Location = New System.Drawing.Point(102, 119)
        Me.txtTel1.MaxLength = 10
        Me.txtTel1.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTel1.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTel1.Name = "txtTel1"
        Me.txtTel1.RegularExpression = "\d{5}"
        Me.txtTel1.Size = New System.Drawing.Size(70, 20)
        Me.txtTel1.TabIndex = 51
        Me.txtTel1.UIName = "Telefono 1"
        '
        'lblTel1
        '
        Me.lblTel1.AutoSize = True
        Me.lblTel1.BackColor = System.Drawing.Color.Transparent
        Me.lblTel1.Location = New System.Drawing.Point(21, 122)
        Me.lblTel1.Name = "lblTel1"
        Me.lblTel1.Size = New System.Drawing.Size(37, 13)
        Me.lblTel1.TabIndex = 50
        Me.lblTel1.Text = "Tel. 1:"
        '
        'txtPoblacion
        '
        Me.txtPoblacion.AnySite = False
        Me.txtPoblacion.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtPoblacion.EditorAssembly = "Azteca.Windows"
        Me.txtPoblacion.EditorClass = "Azteca.Windows.Forms.General.CatalogoPoblaciones"
        Me.txtPoblacion.EditorTitle = "Editar población..."
        Me.txtPoblacion.Key = 0
        Me.txtPoblacion.Linked = False
        Me.txtPoblacion.Location = New System.Drawing.Point(102, 146)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.Size = New System.Drawing.Size(369, 23)
        Me.txtPoblacion.TabIndex = 49
        Me.txtPoblacion.TextWidth = 70
        Me.txtPoblacion.UIName = "Pobación"
        '
        'txtCP
        '
        Me.txtCP.Digits = True
        Me.txtCP.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCP.Location = New System.Drawing.Point(102, 93)
        Me.txtCP.MaxLength = 5
        Me.txtCP.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCP.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCP.Name = "txtCP"
        Me.txtCP.RegularExpression = "\d{5}"
        Me.txtCP.Size = New System.Drawing.Size(70, 20)
        Me.txtCP.TabIndex = 47
        Me.txtCP.UIName = "Código Postal"
        '
        'txtColonia
        '
        Me.txtColonia.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtColonia.Location = New System.Drawing.Point(102, 67)
        Me.txtColonia.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColonia.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(300, 20)
        Me.txtColonia.TabIndex = 45
        Me.txtColonia.UIName = "Colonia"
        '
        'txtNumInt
        '
        Me.txtNumInt.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumInt.Location = New System.Drawing.Point(235, 43)
        Me.txtNumInt.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumInt.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumInt.Name = "txtNumInt"
        Me.txtNumInt.Size = New System.Drawing.Size(70, 20)
        Me.txtNumInt.TabIndex = 43
        Me.txtNumInt.UIName = Nothing
        '
        'txtNumExt
        '
        Me.txtNumExt.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumExt.Location = New System.Drawing.Point(102, 41)
        Me.txtNumExt.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExt.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExt.Name = "txtNumExt"
        Me.txtNumExt.Size = New System.Drawing.Size(70, 20)
        Me.txtNumExt.TabIndex = 41
        Me.txtNumExt.UIName = "Num. Exterior"
        '
        'txtCalle
        '
        Me.txtCalle.BackColor = System.Drawing.SystemColors.Window
        Me.txtCalle.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCalle.Location = New System.Drawing.Point(102, 15)
        Me.txtCalle.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalle.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(300, 20)
        Me.txtCalle.TabIndex = 39
        Me.txtCalle.UIName = "Calle"
        '
        'lblPoblacion
        '
        Me.lblPoblacion.AutoSize = True
        Me.lblPoblacion.BackColor = System.Drawing.Color.Transparent
        Me.lblPoblacion.Location = New System.Drawing.Point(21, 150)
        Me.lblPoblacion.Name = "lblPoblacion"
        Me.lblPoblacion.Size = New System.Drawing.Size(57, 13)
        Me.lblPoblacion.TabIndex = 48
        Me.lblPoblacion.Text = "Población:"
        '
        'lblCodigoPostal
        '
        Me.lblCodigoPostal.AutoSize = True
        Me.lblCodigoPostal.BackColor = System.Drawing.Color.Transparent
        Me.lblCodigoPostal.Location = New System.Drawing.Point(21, 96)
        Me.lblCodigoPostal.Name = "lblCodigoPostal"
        Me.lblCodigoPostal.Size = New System.Drawing.Size(75, 13)
        Me.lblCodigoPostal.TabIndex = 46
        Me.lblCodigoPostal.Text = "Código Postal:"
        '
        'lblNumInt
        '
        Me.lblNumInt.AutoSize = True
        Me.lblNumInt.BackColor = System.Drawing.Color.Transparent
        Me.lblNumInt.Location = New System.Drawing.Point(168, 46)
        Me.lblNumInt.Name = "lblNumInt"
        Me.lblNumInt.Size = New System.Drawing.Size(62, 13)
        Me.lblNumInt.TabIndex = 42
        Me.lblNumInt.Text = "No. Interior:"
        '
        'lblNumExt
        '
        Me.lblNumExt.AutoSize = True
        Me.lblNumExt.BackColor = System.Drawing.Color.Transparent
        Me.lblNumExt.Location = New System.Drawing.Point(21, 44)
        Me.lblNumExt.Name = "lblNumExt"
        Me.lblNumExt.Size = New System.Drawing.Size(65, 13)
        Me.lblNumExt.TabIndex = 40
        Me.lblNumExt.Text = "No. Exterior:"
        '
        'lblColonia
        '
        Me.lblColonia.AutoSize = True
        Me.lblColonia.BackColor = System.Drawing.Color.Transparent
        Me.lblColonia.Location = New System.Drawing.Point(21, 70)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(45, 13)
        Me.lblColonia.TabIndex = 44
        Me.lblColonia.Text = "Colonia:"
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.BackColor = System.Drawing.Color.Transparent
        Me.lblCalle.Location = New System.Drawing.Point(21, 18)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(33, 13)
        Me.lblCalle.TabIndex = 38
        Me.lblCalle.Text = "Calle:"
        '
        'imlTab
        '
        Me.imlTab.ImageStream = CType(resources.GetObject("imlTab.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlTab.TransparentColor = System.Drawing.Color.Transparent
        Me.imlTab.Images.SetKeyName(0, "General_32.png")
        Me.imlTab.Images.SetKeyName(1, "House")
        '
        'tabCentrosRecepcion
        '
        Me.tabCentrosRecepcion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabCentrosRecepcion.Controls.Add(Me.pagGeneral)
        Me.tabCentrosRecepcion.Controls.Add(Me.pagNotificaciones)
        Me.tabCentrosRecepcion.ImageList = Me.imlTab
        Me.tabCentrosRecepcion.Location = New System.Drawing.Point(10, 99)
        Me.tabCentrosRecepcion.Name = "tabCentrosRecepcion"
        Me.tabCentrosRecepcion.SelectedIndex = 1
        Me.tabCentrosRecepcion.Size = New System.Drawing.Size(514, 274)
        Me.tabCentrosRecepcion.TabIndex = 63
        Me.tabCentrosRecepcion.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2003
        Me.tabCentrosRecepcion.VisualStyle = C1.Win.C1Command.VisualStyle.Office2003Blue
        Me.tabCentrosRecepcion.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2003Blue
        '
        'pagGeneral
        '
        Me.pagGeneral.Controls.Add(Me.lblAlmacen)
        Me.pagGeneral.Controls.Add(Me.lblNombre)
        Me.pagGeneral.Controls.Add(Me.cboAlmacenes)
        Me.pagGeneral.Controls.Add(Me.txtNombre)
        Me.pagGeneral.Controls.Add(Me.lblCuenta)
        Me.pagGeneral.Controls.Add(Me.selCuenta)
        Me.pagGeneral.ImageIndex = 0
        Me.pagGeneral.Location = New System.Drawing.Point(1, 41)
        Me.pagGeneral.Name = "pagGeneral"
        Me.pagGeneral.Size = New System.Drawing.Size(512, 232)
        Me.pagGeneral.TabIndex = 0
        Me.pagGeneral.Text = "General"
        '
        'pagNotificaciones
        '
        Me.pagNotificaciones.Controls.Add(Me.lblMunicipio)
        Me.pagNotificaciones.Controls.Add(Me.lblCalle)
        Me.pagNotificaciones.Controls.Add(Me.txtMunicipio)
        Me.pagNotificaciones.Controls.Add(Me.lblColonia)
        Me.pagNotificaciones.Controls.Add(Me.txtFax)
        Me.pagNotificaciones.Controls.Add(Me.lblNumExt)
        Me.pagNotificaciones.Controls.Add(Me.lblFax)
        Me.pagNotificaciones.Controls.Add(Me.lblNumInt)
        Me.pagNotificaciones.Controls.Add(Me.txtTel2)
        Me.pagNotificaciones.Controls.Add(Me.lblCodigoPostal)
        Me.pagNotificaciones.Controls.Add(Me.lblTel2)
        Me.pagNotificaciones.Controls.Add(Me.lblPoblacion)
        Me.pagNotificaciones.Controls.Add(Me.txtTel1)
        Me.pagNotificaciones.Controls.Add(Me.txtCalle)
        Me.pagNotificaciones.Controls.Add(Me.lblTel1)
        Me.pagNotificaciones.Controls.Add(Me.txtNumExt)
        Me.pagNotificaciones.Controls.Add(Me.txtPoblacion)
        Me.pagNotificaciones.Controls.Add(Me.txtNumInt)
        Me.pagNotificaciones.Controls.Add(Me.txtCP)
        Me.pagNotificaciones.Controls.Add(Me.txtColonia)
        Me.pagNotificaciones.ImageIndex = 1
        Me.pagNotificaciones.Location = New System.Drawing.Point(1, 41)
        Me.pagNotificaciones.Name = "pagNotificaciones"
        Me.pagNotificaciones.Size = New System.Drawing.Size(512, 232)
        Me.pagNotificaciones.TabIndex = 1
        Me.pagNotificaciones.Text = "Domicilio"
        '
        'CentrosRecepcionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 401)
        Me.Controls.Add(Me.tabCentrosRecepcion)
        Me.Name = "CentrosRecepcionForm"
        Me.Text = "CentrosRecepcionForm"
        Me.Controls.SetChildIndex(Me.tabCentrosRecepcion, 0)
        CType(Me.tabCentrosRecepcion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCentrosRecepcion.ResumeLayout(False)
        Me.pagGeneral.ResumeLayout(False)
        Me.pagGeneral.PerformLayout()
        Me.pagNotificaciones.ResumeLayout(False)
        Me.pagNotificaciones.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Facade = New CentroRecepcionFacade
    End Sub
    Friend WithEvents lblMunicipio As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtMunicipio As Azteca.Windows.Controls.General.MunicipioSelector
    Friend WithEvents txtFax As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblFax As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtTel2 As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblTel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtTel1 As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblTel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtPoblacion As Azteca.Windows.Controls.General.PoblacionSelector
    Friend WithEvents txtCP As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtColonia As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtNumInt As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtNumExt As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtCalle As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblPoblacion As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCodigoPostal As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblNumInt As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblNumExt As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblColonia As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCalle As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCuenta As Azteca.Windows.Controls.CILabel
    Friend WithEvents selCuenta As Azteca.Windows.Contabilidad.CuentaSelector
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblNombre As Azteca.Windows.Controls.CILabel
    Friend WithEvents imlTab As System.Windows.Forms.ImageList
    Friend WithEvents lblAlmacen As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboAlmacenes As Azteca.Windows.Inventario.AlmacenesComboBox
    Friend WithEvents tabCentrosRecepcion As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagGeneral As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagNotificaciones As C1.Win.C1Command.C1DockingTabPage
End Class
