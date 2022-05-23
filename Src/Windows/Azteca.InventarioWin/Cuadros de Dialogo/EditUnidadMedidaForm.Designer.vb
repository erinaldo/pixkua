<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditUnidadMedidaForm
    Inherits Azteca.Windows.Forms.BaseForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditUnidadMedidaForm))
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.btnAceptar = New Azteca.Windows.Controls.CIButton()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.chkBase = New Azteca.Windows.Controls.CICheckBox()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.txtFactor = New Azteca.Windows.Controls.CITextBox()
        Me.chkActivo = New Azteca.Windows.Controls.CICheckBox()
        Me.cboTipo = New Azteca.Windows.Inventario.TiposUnidadComboBox()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.txtAbreviatura = New Azteca.Windows.Controls.CITextBox()
        Me.chkFraccionable = New Azteca.Windows.Controls.CICheckBox()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(375, 174)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(294, 174)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 11
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(21, 42)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(47, 13)
        Me.CiLabel1.TabIndex = 2
        Me.CiLabel1.Text = "Nombre:"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(21, 15)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(31, 13)
        Me.CiLabel2.TabIndex = 0
        Me.CiLabel2.Text = "Tipo:"
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(21, 140)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(40, 13)
        Me.CiLabel3.TabIndex = 8
        Me.CiLabel3.Text = "Factor:"
        '
        'chkBase
        '
        Me.chkBase.AutoSize = True
        Me.chkBase.Location = New System.Drawing.Point(91, 91)
        Me.chkBase.Name = "chkBase"
        Me.chkBase.Size = New System.Drawing.Size(158, 17)
        Me.chkBase.TabIndex = 6
        Me.chkBase.Text = "Utilizar como la unidad base"
        Me.chkBase.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(91, 39)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(260, 20)
        Me.txtNombre.TabIndex = 3
        '
        'txtFactor
        '
        Me.txtFactor.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtFactor.Digits = True
        Me.txtFactor.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtFactor.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtFactor.Location = New System.Drawing.Point(91, 137)
        Me.txtFactor.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFactor.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFactor.Name = "txtFactor"
        Me.txtFactor.Size = New System.Drawing.Size(73, 20)
        Me.txtFactor.TabIndex = 9
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.Location = New System.Drawing.Point(91, 163)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 10
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboTipo.ItemsTable = Nothing
        Me.cboTipo.Location = New System.Drawing.Point(91, 12)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboTipo.Size = New System.Drawing.Size(260, 21)
        Me.cboTipo.TabIndex = 1
        Me.cboTipo.UIName = Nothing
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.Location = New System.Drawing.Point(21, 67)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(64, 13)
        Me.CiLabel4.TabIndex = 4
        Me.CiLabel4.Text = "Abreviatura:"
        '
        'txtAbreviatura
        '
        Me.txtAbreviatura.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtAbreviatura.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtAbreviatura.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtAbreviatura.Location = New System.Drawing.Point(91, 65)
        Me.txtAbreviatura.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAbreviatura.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Size = New System.Drawing.Size(73, 20)
        Me.txtAbreviatura.TabIndex = 5
        '
        'chkFraccionable
        '
        Me.chkFraccionable.AutoSize = True
        Me.chkFraccionable.Location = New System.Drawing.Point(91, 114)
        Me.chkFraccionable.Name = "chkFraccionable"
        Me.chkFraccionable.Size = New System.Drawing.Size(113, 17)
        Me.chkFraccionable.TabIndex = 7
        Me.chkFraccionable.Text = "Permite fracciones"
        Me.chkFraccionable.UseVisualStyleBackColor = True
        '
        'EditUnidadMedidaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 209)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkFraccionable)
        Me.Controls.Add(Me.txtAbreviatura)
        Me.Controls.Add(Me.CiLabel4)
        Me.Controls.Add(Me.cboTipo)
        Me.Controls.Add(Me.chkActivo)
        Me.Controls.Add(Me.txtFactor)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.chkBase)
        Me.Controls.Add(Me.CiLabel3)
        Me.Controls.Add(Me.CiLabel2)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Name = "EditUnidadMedidaForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Editar Unidad de Medida"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnAceptar As Azteca.Windows.Controls.CIButton
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents chkBase As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtFactor As Azteca.Windows.Controls.CITextBox
    Friend WithEvents chkActivo As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents cboTipo As Azteca.Windows.Inventario.TiposUnidadComboBox
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtAbreviatura As Azteca.Windows.Controls.CITextBox
    Friend WithEvents chkFraccionable As Azteca.Windows.Controls.CICheckBox
End Class
