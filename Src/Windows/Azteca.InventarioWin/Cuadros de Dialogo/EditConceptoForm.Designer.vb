<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditConceptoForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditConceptoForm))
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.btnAceptar = New Azteca.Windows.Controls.CIButton()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.chkAutomatico = New Azteca.Windows.Controls.CICheckBox()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.chkActivo = New Azteca.Windows.Controls.CICheckBox()
        Me.cboClasificacion = New Azteca.Windows.Inventario.ClasificacionesConceptosComboBox()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.cboTipo = New Azteca.Windows.Controls.CIComboBox()
        Me.nudDiasVig = New Azteca.Windows.Controls.CINumericUpDown()
        Me.CiLabel5 = New Azteca.Windows.Controls.CILabel()
        Me.txtCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        CType(Me.nudDiasVig, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(311, 201)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(230, 201)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 12
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(12, 19)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(69, 13)
        Me.CiLabel1.TabIndex = 0
        Me.CiLabel1.Text = "Clasificación:"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(12, 45)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(47, 13)
        Me.CiLabel2.TabIndex = 2
        Me.CiLabel2.Text = "Nombre:"
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(12, 73)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(31, 13)
        Me.CiLabel3.TabIndex = 4
        Me.CiLabel3.Text = "Tipo:"
        '
        'chkAutomatico
        '
        Me.chkAutomatico.AutoSize = True
        Me.chkAutomatico.Location = New System.Drawing.Point(87, 130)
        Me.chkAutomatico.Name = "chkAutomatico"
        Me.chkAutomatico.Size = New System.Drawing.Size(79, 17)
        Me.chkAutomatico.TabIndex = 10
        Me.chkAutomatico.Text = "Automatico"
        Me.chkAutomatico.UseVisualStyleBackColor = True
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.Location = New System.Drawing.Point(240, 73)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(75, 13)
        Me.CiLabel4.TabIndex = 6
        Me.CiLabel4.Text = "Dias Vigencia:"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.Location = New System.Drawing.Point(87, 153)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 11
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'cboClasificacion
        '
        Me.cboClasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClasificacion.FormattingEnabled = True
        Me.cboClasificacion.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboClasificacion.ItemsTable = Nothing
        Me.cboClasificacion.Location = New System.Drawing.Point(87, 16)
        Me.cboClasificacion.Name = "cboClasificacion"
        Me.cboClasificacion.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboClasificacion.Size = New System.Drawing.Size(299, 21)
        Me.cboClasificacion.TabIndex = 1
        Me.cboClasificacion.UIName = Nothing
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(87, 43)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(299, 20)
        Me.txtNombre.TabIndex = 3
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboTipo.Items.AddRange(New Object() {"Entrada", "Salida", "Traspaso"})
        Me.cboTipo.ItemsTable = Nothing
        Me.cboTipo.Location = New System.Drawing.Point(87, 69)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboTipo.Size = New System.Drawing.Size(147, 21)
        Me.cboTipo.TabIndex = 5
        Me.cboTipo.UIName = Nothing
        '
        'nudDiasVig
        '
        Me.nudDiasVig.HighlightColor = System.Drawing.SystemColors.Info
        Me.nudDiasVig.Location = New System.Drawing.Point(321, 71)
        Me.nudDiasVig.Maximum = New Decimal(New Integer() {365, 0, 0, 0})
        Me.nudDiasVig.Name = "nudDiasVig"
        Me.nudDiasVig.Size = New System.Drawing.Size(65, 20)
        Me.nudDiasVig.TabIndex = 7
        '
        'CiLabel5
        '
        Me.CiLabel5.AutoSize = True
        Me.CiLabel5.Location = New System.Drawing.Point(12, 99)
        Me.CiLabel5.Name = "CiLabel5"
        Me.CiLabel5.Size = New System.Drawing.Size(44, 13)
        Me.CiLabel5.TabIndex = 8
        Me.CiLabel5.Text = "Cuenta:"
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
        Me.txtCuenta.Location = New System.Drawing.Point(87, 96)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.txtCuenta.Size = New System.Drawing.Size(299, 23)
        Me.txtCuenta.TabIndex = 9
        '
        'EditConceptoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 236)
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.CiLabel5)
        Me.Controls.Add(Me.nudDiasVig)
        Me.Controls.Add(Me.cboTipo)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.cboClasificacion)
        Me.Controls.Add(Me.chkActivo)
        Me.Controls.Add(Me.CiLabel4)
        Me.Controls.Add(Me.chkAutomatico)
        Me.Controls.Add(Me.CiLabel3)
        Me.Controls.Add(Me.CiLabel2)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Name = "EditConceptoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Editar concepto de movimientos de inventario"
        CType(Me.nudDiasVig, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnAceptar As Azteca.Windows.Controls.CIButton
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents chkAutomatico As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
    Friend WithEvents chkActivo As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents cboClasificacion As Azteca.Windows.Inventario.ClasificacionesConceptosComboBox
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents cboTipo As Azteca.Windows.Controls.CIComboBox
    Friend WithEvents nudDiasVig As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents CiLabel5 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCuenta As Azteca.Windows.Contabilidad.CuentaSelector
End Class
