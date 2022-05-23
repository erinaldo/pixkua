<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditPartidasForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditPartidasForm))
        Me.txtCantidad = New Azteca.Windows.Controls.CITextBox()
        Me.txtCodigo = New Azteca.Windows.Controls.CITextBox()
        Me.lblDescripcion = New Azteca.Windows.Controls.CILabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnAgregar = New Azteca.Windows.Controls.CIButton()
        Me.txtAlmacen = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.btnTerminar = New Azteca.Windows.Controls.CIButton()
        Me.lblCajas = New Azteca.Windows.Controls.CILabel()
        Me.lblCodigo = New Azteca.Windows.Controls.CILabel()
        Me.txtExistencia = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.txtUnidad = New Azteca.Windows.Controls.CITextBox()
        Me.SuspendLayout()
        '
        'txtCantidad
        '
        Me.txtCantidad.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCantidad.Digits = True
        Me.txtCantidad.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCantidad.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCantidad.Location = New System.Drawing.Point(318, 13)
        Me.txtCantidad.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantidad.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(75, 20)
        Me.txtCantidad.TabIndex = 3
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCodigo.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCodigo.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCodigo.Location = New System.Drawing.Point(99, 13)
        Me.txtCodigo.MaxLength = 18
        Me.txtCodigo.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCodigo.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(132, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'lblDescripcion
        '
        Me.lblDescripcion.BackColor = System.Drawing.SystemColors.Control
        Me.lblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(10, 36)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(695, 85)
        Me.lblDescripcion.TabIndex = 6
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.Image = Global.Azteca.Windows.Inventario.My.Resources.Resources.add_16
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(549, 128)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 11
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnAgregar, "Agregar partida con la información actual")
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtAlmacen
        '
        Me.txtAlmacen.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtAlmacen.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtAlmacen.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtAlmacen.Location = New System.Drawing.Point(99, 131)
        Me.txtAlmacen.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAlmacen.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.ReadOnly = True
        Me.txtAlmacen.Size = New System.Drawing.Size(176, 20)
        Me.txtAlmacen.TabIndex = 8
        Me.txtAlmacen.TabStop = False
        '
        'CiLabel1
        '
        Me.CiLabel1.Image = Global.Azteca.Windows.Inventario.My.Resources.Resources.inventory_32
        Me.CiLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CiLabel1.Location = New System.Drawing.Point(281, 124)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(93, 32)
        Me.CiLabel1.TabIndex = 9
        Me.CiLabel1.Text = "Existencia:"
        Me.CiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CiLabel3
        '
        Me.CiLabel3.Image = Global.Azteca.Windows.Inventario.My.Resources.Resources.warehouse_32
        Me.CiLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CiLabel3.Location = New System.Drawing.Point(0, 124)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(93, 32)
        Me.CiLabel3.TabIndex = 7
        Me.CiLabel3.Text = "Almacén:"
        Me.CiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnTerminar
        '
        Me.btnTerminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTerminar.Image = CType(resources.GetObject("btnTerminar.Image"), System.Drawing.Image)
        Me.btnTerminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTerminar.Location = New System.Drawing.Point(630, 128)
        Me.btnTerminar.Name = "btnTerminar"
        Me.btnTerminar.Size = New System.Drawing.Size(75, 23)
        Me.btnTerminar.TabIndex = 12
        Me.btnTerminar.TabStop = False
        Me.btnTerminar.Text = "Terminar"
        Me.btnTerminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTerminar.UseVisualStyleBackColor = True
        '
        'lblCajas
        '
        Me.lblCajas.Image = CType(resources.GetObject("lblCajas.Image"), System.Drawing.Image)
        Me.lblCajas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCajas.Location = New System.Drawing.Point(237, 13)
        Me.lblCajas.Name = "lblCajas"
        Me.lblCajas.Size = New System.Drawing.Size(75, 20)
        Me.lblCajas.TabIndex = 2
        Me.lblCajas.Text = "Cantidad:"
        Me.lblCajas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCodigo
        '
        Me.lblCodigo.Image = CType(resources.GetObject("lblCodigo.Image"), System.Drawing.Image)
        Me.lblCodigo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCodigo.Location = New System.Drawing.Point(7, 13)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(86, 20)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código:"
        Me.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtExistencia
        '
        Me.txtExistencia.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtExistencia.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtExistencia.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtExistencia.Location = New System.Drawing.Point(380, 131)
        Me.txtExistencia.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtExistencia.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtExistencia.Name = "txtExistencia"
        Me.txtExistencia.ReadOnly = True
        Me.txtExistencia.Size = New System.Drawing.Size(102, 20)
        Me.txtExistencia.TabIndex = 10
        Me.txtExistencia.TabStop = False
        Me.txtExistencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(399, 16)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(44, 13)
        Me.CiLabel2.TabIndex = 4
        Me.CiLabel2.Text = "Unidad:"
        '
        'txtUnidad
        '
        Me.txtUnidad.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtUnidad.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtUnidad.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtUnidad.Location = New System.Drawing.Point(449, 14)
        Me.txtUnidad.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtUnidad.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.ReadOnly = True
        Me.txtUnidad.Size = New System.Drawing.Size(175, 20)
        Me.txtUnidad.TabIndex = 5
        Me.txtUnidad.TabStop = False
        '
        'EditPartidasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 163)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtUnidad)
        Me.Controls.Add(Me.CiLabel2)
        Me.Controls.Add(Me.txtExistencia)
        Me.Controls.Add(Me.txtAlmacen)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.CiLabel3)
        Me.Controls.Add(Me.btnTerminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblCajas)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.txtCodigo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditPartidasForm"
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
    Friend WithEvents btnTerminar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnAgregar As Azteca.Windows.Controls.CIButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtAlmacen As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtExistencia As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtUnidad As Azteca.Windows.Controls.CITextBox
End Class
