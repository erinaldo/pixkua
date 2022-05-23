<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditPartidaServicioForm
    Inherits Azteca.Windows.Forms.BaseForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditPartidaServicioForm))
        Me.lblCajas = New Azteca.Windows.Controls.CILabel()
        Me.txtCantidad = New Azteca.Windows.Controls.CITextBox()
        Me.lblCodigo = New Azteca.Windows.Controls.CILabel()
        Me.txtCodigo = New Azteca.Windows.Controls.CITextBox()
        Me.lblDescripcion = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.txtPrecio = New Azteca.Windows.Controls.CITextBox()
        Me.btnTerminar = New Azteca.Windows.Controls.CIButton()
        Me.btnAgregar = New Azteca.Windows.Controls.CIButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtDescripcion = New Azteca.Windows.Controls.CITextBox()
        Me.txtDivisa = New Azteca.Windows.Controls.CITextBox()
        Me.SuspendLayout()
        '
        'lblCajas
        '
        Me.lblCajas.Image = CType(resources.GetObject("lblCajas.Image"), System.Drawing.Image)
        Me.lblCajas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCajas.Location = New System.Drawing.Point(198, 13)
        Me.lblCajas.Name = "lblCajas"
        Me.lblCajas.Size = New System.Drawing.Size(75, 20)
        Me.lblCajas.TabIndex = 2
        Me.lblCajas.Text = "Cantidad:"
        Me.lblCajas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCantidad
        '
        Me.txtCantidad.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCantidad.Digits = True
        Me.txtCantidad.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCantidad.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCantidad.Location = New System.Drawing.Point(279, 13)
        Me.txtCantidad.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantidad.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(75, 20)
        Me.txtCantidad.TabIndex = 3
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCodigo
        '
        Me.lblCodigo.Image = CType(resources.GetObject("lblCodigo.Image"), System.Drawing.Image)
        Me.lblCodigo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCodigo.Location = New System.Drawing.Point(7, 13)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(73, 20)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código"
        Me.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCodigo.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCodigo.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCodigo.Location = New System.Drawing.Point(85, 13)
        Me.txtCodigo.MaxLength = 18
        Me.txtCodigo.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCodigo.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(107, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'lblDescripcion
        '
        Me.lblDescripcion.BackColor = System.Drawing.SystemColors.Control
        Me.lblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(3, 61)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(702, 60)
        Me.lblDescripcion.TabIndex = 8
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CiLabel3
        '
        Me.CiLabel3.Image = CType(resources.GetObject("CiLabel3.Image"), System.Drawing.Image)
        Me.CiLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CiLabel3.Location = New System.Drawing.Point(360, 13)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(58, 20)
        Me.CiLabel3.TabIndex = 4
        Me.CiLabel3.Text = "Precio"
        Me.CiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPrecio
        '
        Me.txtPrecio.BackColor = System.Drawing.SystemColors.Control
        Me.txtPrecio.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtPrecio.Digits = True
        Me.txtPrecio.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtPrecio.Format = "C"
        Me.txtPrecio.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtPrecio.Location = New System.Drawing.Point(424, 13)
        Me.txtPrecio.MaxLength = 18
        Me.txtPrecio.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPrecio.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.ReadOnly = True
        Me.txtPrecio.Size = New System.Drawing.Size(83, 20)
        Me.txtPrecio.TabIndex = 5
        Me.txtPrecio.TabStop = False
        Me.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnTerminar
        '
        Me.btnTerminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTerminar.Image = CType(resources.GetObject("btnTerminar.Image"), System.Drawing.Image)
        Me.btnTerminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTerminar.Location = New System.Drawing.Point(630, 124)
        Me.btnTerminar.Name = "btnTerminar"
        Me.btnTerminar.Size = New System.Drawing.Size(75, 23)
        Me.btnTerminar.TabIndex = 10
        Me.btnTerminar.TabStop = False
        Me.btnTerminar.Text = "Terminar"
        Me.btnTerminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTerminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.Image = Global.Azteca.Windows.Ventas.My.Resources.Resources.add_16
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(549, 124)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 9
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnAgregar, "Agregar partida con la información actual")
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtDescripcion.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtDescripcion.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtDescripcion.Location = New System.Drawing.Point(3, 39)
        Me.txtDescripcion.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDescripcion.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(702, 20)
        Me.txtDescripcion.TabIndex = 7
        Me.txtDescripcion.TabStop = False
        '
        'txtDivisa
        '
        Me.txtDivisa.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtDivisa.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtDivisa.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtDivisa.Location = New System.Drawing.Point(513, 12)
        Me.txtDivisa.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDivisa.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDivisa.Name = "txtDivisa"
        Me.txtDivisa.ReadOnly = True
        Me.txtDivisa.Size = New System.Drawing.Size(192, 20)
        Me.txtDivisa.TabIndex = 6
        Me.txtDivisa.TabStop = False
        '
        'EditPartidaServicioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 159)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtDivisa)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.CiLabel3)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.btnTerminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblCajas)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.txtCodigo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditPartidaServicioForm"
        Me.Text = "Captura de partidas para servicios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCajas As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCantidad As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblCodigo As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCodigo As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblDescripcion As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtPrecio As Azteca.Windows.Controls.CITextBox
    Friend WithEvents btnTerminar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnAgregar As Azteca.Windows.Controls.CIButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtDescripcion As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtDivisa As Azteca.Windows.Controls.CITextBox
End Class
