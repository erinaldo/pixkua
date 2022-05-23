<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DomicilioEditForm
    Inherits Azteca.Windows.Forms.BaseForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DomicilioEditForm))
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
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.btnAceptar = New Azteca.Windows.Controls.CIButton()
        Me.txtTel1 = New Azteca.Windows.Controls.CITextBox()
        Me.lblTel1 = New Azteca.Windows.Controls.CILabel()
        Me.txtTel2 = New Azteca.Windows.Controls.CITextBox()
        Me.lblTel2 = New Azteca.Windows.Controls.CILabel()
        Me.txtFax = New Azteca.Windows.Controls.CITextBox()
        Me.lblFax = New Azteca.Windows.Controls.CILabel()
        Me.txtMunicipio = New Azteca.Windows.Controls.General.MunicipioSelector()
        Me.lblMunicipio = New Azteca.Windows.Controls.CILabel()
        Me.SuspendLayout()
        '
        'txtPoblacion
        '
        Me.txtPoblacion.AnySite = False
        Me.txtPoblacion.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtPoblacion.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtPoblacion.EditorAssembly = "Azteca.Windows"
        Me.txtPoblacion.EditorClass = "Azteca.Windows.Forms.General.CatalogoPoblaciones"
        Me.txtPoblacion.EditorTitle = "Editar población..."
        Me.txtPoblacion.Key = 0
        Me.txtPoblacion.Linked = False
        Me.txtPoblacion.Location = New System.Drawing.Point(92, 148)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.txtPoblacion.Size = New System.Drawing.Size(300, 23)
        Me.txtPoblacion.TabIndex = 25
        Me.txtPoblacion.TextWidth = 70
        Me.txtPoblacion.UIName = "Pobación"
        '
        'txtCP
        '
        Me.txtCP.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCP.Digits = True
        Me.txtCP.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCP.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCP.Location = New System.Drawing.Point(92, 95)
        Me.txtCP.MaxLength = 5
        Me.txtCP.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCP.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCP.Name = "txtCP"
        Me.txtCP.RegularExpression = "\d{5}"
        Me.txtCP.Size = New System.Drawing.Size(70, 20)
        Me.txtCP.TabIndex = 23
        Me.txtCP.UIName = "Código Postal"
        '
        'txtColonia
        '
        Me.txtColonia.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtColonia.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtColonia.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtColonia.Location = New System.Drawing.Point(92, 69)
        Me.txtColonia.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColonia.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(300, 20)
        Me.txtColonia.TabIndex = 21
        Me.txtColonia.UIName = "Colonia"
        '
        'txtNumInt
        '
        Me.txtNumInt.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNumInt.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNumInt.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumInt.Location = New System.Drawing.Point(239, 43)
        Me.txtNumInt.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumInt.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumInt.Name = "txtNumInt"
        Me.txtNumInt.Size = New System.Drawing.Size(70, 20)
        Me.txtNumInt.TabIndex = 19
        Me.txtNumInt.UIName = Nothing
        '
        'txtNumExt
        '
        Me.txtNumExt.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNumExt.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNumExt.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumExt.Location = New System.Drawing.Point(92, 43)
        Me.txtNumExt.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExt.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExt.Name = "txtNumExt"
        Me.txtNumExt.Size = New System.Drawing.Size(70, 20)
        Me.txtNumExt.TabIndex = 17
        Me.txtNumExt.UIName = "Num. Exterior"
        '
        'txtCalle
        '
        Me.txtCalle.BackColor = System.Drawing.SystemColors.Window
        Me.txtCalle.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCalle.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCalle.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCalle.Location = New System.Drawing.Point(92, 17)
        Me.txtCalle.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalle.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(300, 20)
        Me.txtCalle.TabIndex = 15
        Me.txtCalle.UIName = "Calle"
        '
        'lblPoblacion
        '
        Me.lblPoblacion.AutoSize = True
        Me.lblPoblacion.Location = New System.Drawing.Point(11, 152)
        Me.lblPoblacion.Name = "lblPoblacion"
        Me.lblPoblacion.Size = New System.Drawing.Size(57, 13)
        Me.lblPoblacion.TabIndex = 24
        Me.lblPoblacion.Text = "Población:"
        '
        'lblCodigoPostal
        '
        Me.lblCodigoPostal.AutoSize = True
        Me.lblCodigoPostal.Location = New System.Drawing.Point(11, 98)
        Me.lblCodigoPostal.Name = "lblCodigoPostal"
        Me.lblCodigoPostal.Size = New System.Drawing.Size(75, 13)
        Me.lblCodigoPostal.TabIndex = 22
        Me.lblCodigoPostal.Text = "Código Postal:"
        '
        'lblNumInt
        '
        Me.lblNumInt.AutoSize = True
        Me.lblNumInt.Location = New System.Drawing.Point(172, 46)
        Me.lblNumInt.Name = "lblNumInt"
        Me.lblNumInt.Size = New System.Drawing.Size(62, 13)
        Me.lblNumInt.TabIndex = 18
        Me.lblNumInt.Text = "No. Interior:"
        '
        'lblNumExt
        '
        Me.lblNumExt.AutoSize = True
        Me.lblNumExt.Location = New System.Drawing.Point(11, 46)
        Me.lblNumExt.Name = "lblNumExt"
        Me.lblNumExt.Size = New System.Drawing.Size(65, 13)
        Me.lblNumExt.TabIndex = 16
        Me.lblNumExt.Text = "No. Exterior:"
        '
        'lblColonia
        '
        Me.lblColonia.AutoSize = True
        Me.lblColonia.Location = New System.Drawing.Point(11, 72)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(45, 13)
        Me.lblColonia.TabIndex = 20
        Me.lblColonia.Text = "Colonia:"
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Location = New System.Drawing.Point(11, 20)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(33, 13)
        Me.lblCalle.TabIndex = 14
        Me.lblCalle.Text = "Calle:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(317, 205)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 29
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(234, 205)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 28
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtTel1
        '
        Me.txtTel1.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtTel1.Digits = True
        Me.txtTel1.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtTel1.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTel1.Location = New System.Drawing.Point(92, 121)
        Me.txtTel1.MaxLength = 5
        Me.txtTel1.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTel1.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTel1.Name = "txtTel1"
        Me.txtTel1.RegularExpression = "\d{5}"
        Me.txtTel1.Size = New System.Drawing.Size(70, 20)
        Me.txtTel1.TabIndex = 31
        Me.txtTel1.UIName = "Telefono 1"
        '
        'lblTel1
        '
        Me.lblTel1.AutoSize = True
        Me.lblTel1.Location = New System.Drawing.Point(11, 124)
        Me.lblTel1.Name = "lblTel1"
        Me.lblTel1.Size = New System.Drawing.Size(37, 13)
        Me.lblTel1.TabIndex = 30
        Me.lblTel1.Text = "Tel. 1:"
        '
        'txtTel2
        '
        Me.txtTel2.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtTel2.Digits = True
        Me.txtTel2.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtTel2.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTel2.Location = New System.Drawing.Point(239, 121)
        Me.txtTel2.MaxLength = 5
        Me.txtTel2.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTel2.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTel2.Name = "txtTel2"
        Me.txtTel2.RegularExpression = "\d{5}"
        Me.txtTel2.Size = New System.Drawing.Size(70, 20)
        Me.txtTel2.TabIndex = 33
        Me.txtTel2.UIName = "Telefono 2"
        '
        'lblTel2
        '
        Me.lblTel2.AutoSize = True
        Me.lblTel2.Location = New System.Drawing.Point(196, 124)
        Me.lblTel2.Name = "lblTel2"
        Me.lblTel2.Size = New System.Drawing.Size(37, 13)
        Me.lblTel2.TabIndex = 32
        Me.lblTel2.Text = "Tel. 2:"
        '
        'txtFax
        '
        Me.txtFax.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtFax.Digits = True
        Me.txtFax.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtFax.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtFax.Location = New System.Drawing.Point(239, 95)
        Me.txtFax.MaxLength = 5
        Me.txtFax.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFax.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFax.Name = "txtFax"
        Me.txtFax.RegularExpression = "\d{5}"
        Me.txtFax.Size = New System.Drawing.Size(70, 20)
        Me.txtFax.TabIndex = 35
        Me.txtFax.UIName = "Telefono 2"
        '
        'lblFax
        '
        Me.lblFax.AutoSize = True
        Me.lblFax.Location = New System.Drawing.Point(196, 98)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(27, 13)
        Me.lblFax.TabIndex = 34
        Me.lblFax.Text = "Fax:"
        '
        'txtMunicipio
        '
        Me.txtMunicipio.AnySite = False
        Me.txtMunicipio.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtMunicipio.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtMunicipio.EditorAssembly = "Azteca.Windows"
        Me.txtMunicipio.EditorClass = "Azteca.Windows.Forms.General.CatalogoMunicipios"
        Me.txtMunicipio.EditorTitle = "Editar municipio..."
        Me.txtMunicipio.Key = 0
        Me.txtMunicipio.Linked = False
        Me.txtMunicipio.Location = New System.Drawing.Point(92, 173)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.txtMunicipio.Size = New System.Drawing.Size(300, 23)
        Me.txtMunicipio.TabIndex = 36
        Me.txtMunicipio.TextWidth = 70
        Me.txtMunicipio.UIName = "Municipio"
        '
        'lblMunicipio
        '
        Me.lblMunicipio.AutoSize = True
        Me.lblMunicipio.Location = New System.Drawing.Point(11, 178)
        Me.lblMunicipio.Name = "lblMunicipio"
        Me.lblMunicipio.Size = New System.Drawing.Size(55, 13)
        Me.lblMunicipio.TabIndex = 37
        Me.lblMunicipio.Text = "Municipio:"
        '
        'DomicilioEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(404, 240)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblMunicipio)
        Me.Controls.Add(Me.txtMunicipio)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.lblFax)
        Me.Controls.Add(Me.txtTel2)
        Me.Controls.Add(Me.lblTel2)
        Me.Controls.Add(Me.txtTel1)
        Me.Controls.Add(Me.lblTel1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtPoblacion)
        Me.Controls.Add(Me.txtCP)
        Me.Controls.Add(Me.txtColonia)
        Me.Controls.Add(Me.txtNumInt)
        Me.Controls.Add(Me.txtNumExt)
        Me.Controls.Add(Me.txtCalle)
        Me.Controls.Add(Me.lblPoblacion)
        Me.Controls.Add(Me.lblCodigoPostal)
        Me.Controls.Add(Me.lblNumInt)
        Me.Controls.Add(Me.lblNumExt)
        Me.Controls.Add(Me.lblColonia)
        Me.Controls.Add(Me.lblCalle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "DomicilioEditForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Domicilio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnAceptar As Azteca.Windows.Controls.CIButton
    Friend WithEvents txtTel1 As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblTel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtTel2 As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblTel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtFax As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblFax As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtMunicipio As Azteca.Windows.Controls.General.MunicipioSelector
    Friend WithEvents lblMunicipio As Azteca.Windows.Controls.CILabel
End Class
