<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RACitem
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
        Me.rbtnCuenta = New Azteca.Windows.Controls.CIRadioButton()
        Me.rbtnEntidad = New Azteca.Windows.Controls.CIRadioButton()
        Me.chkRojo = New Azteca.Windows.Controls.CICheckBox()
        Me.cboImporte = New Azteca.Windows.Controls.CIComboBox()
        Me.lblImporte = New Azteca.Windows.Controls.CILabel()
        Me.rbtnAbono = New Azteca.Windows.Controls.CIRadioButton()
        Me.rbtnCargo = New Azteca.Windows.Controls.CIRadioButton()
        Me.gbxAfectador = New Azteca.Windows.Controls.CIGroupBox()
        Me.gbxCuenta = New Azteca.Windows.Controls.CIGroupBox()
        Me.chkIsConceptoEntidad = New Azteca.Windows.Controls.CICheckBox()
        Me.gbxImporte = New Azteca.Windows.Controls.CIGroupBox()
        Me.btnOrigenNew = New Azteca.Windows.Controls.CIButton()
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.btnAceptar = New Azteca.Windows.Controls.CIButton()
        Me.selEntidad = New Azteca.Windows.Contabilidad.EntidadSelector()
        Me.selCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.gbxAfectador.SuspendLayout()
        Me.gbxCuenta.SuspendLayout()
        Me.gbxImporte.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbtnCuenta
        '
        Me.rbtnCuenta.AutoSize = True
        Me.rbtnCuenta.Checked = True
        Me.rbtnCuenta.Location = New System.Drawing.Point(77, 26)
        Me.rbtnCuenta.Name = "rbtnCuenta"
        Me.rbtnCuenta.Size = New System.Drawing.Size(59, 17)
        Me.rbtnCuenta.TabIndex = 0
        Me.rbtnCuenta.TabStop = True
        Me.rbtnCuenta.Text = "Cuenta"
        Me.rbtnCuenta.UseVisualStyleBackColor = True
        '
        'rbtnEntidad
        '
        Me.rbtnEntidad.AutoSize = True
        Me.rbtnEntidad.Location = New System.Drawing.Point(77, 53)
        Me.rbtnEntidad.Name = "rbtnEntidad"
        Me.rbtnEntidad.Size = New System.Drawing.Size(61, 17)
        Me.rbtnEntidad.TabIndex = 1
        Me.rbtnEntidad.Text = "Entidad"
        Me.rbtnEntidad.UseVisualStyleBackColor = True
        '
        'chkRojo
        '
        Me.chkRojo.AutoSize = True
        Me.chkRojo.Location = New System.Drawing.Point(145, 53)
        Me.chkRojo.Name = "chkRojo"
        Me.chkRojo.Size = New System.Drawing.Size(186, 17)
        Me.chkRojo.TabIndex = 2
        Me.chkRojo.Text = "Considerar el Importe en Negativo"
        Me.chkRojo.UseVisualStyleBackColor = True
        '
        'cboImporte
        '
        Me.cboImporte.AutoClear = False
        Me.cboImporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboImporte.FormattingEnabled = True
        Me.cboImporte.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboImporte.ItemsTable = Nothing
        Me.cboImporte.Location = New System.Drawing.Point(145, 26)
        Me.cboImporte.Name = "cboImporte"
        Me.cboImporte.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboImporte.Size = New System.Drawing.Size(246, 21)
        Me.cboImporte.TabIndex = 3
        Me.cboImporte.UIName = Nothing
        '
        'lblImporte
        '
        Me.lblImporte.AutoSize = True
        Me.lblImporte.Location = New System.Drawing.Point(94, 29)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(42, 13)
        Me.lblImporte.TabIndex = 4
        Me.lblImporte.Text = "Importe"
        '
        'rbtnAbono
        '
        Me.rbtnAbono.AutoSize = True
        Me.rbtnAbono.Location = New System.Drawing.Point(77, 42)
        Me.rbtnAbono.Name = "rbtnAbono"
        Me.rbtnAbono.Size = New System.Drawing.Size(56, 17)
        Me.rbtnAbono.TabIndex = 6
        Me.rbtnAbono.Text = "Abono"
        Me.rbtnAbono.UseVisualStyleBackColor = True
        '
        'rbtnCargo
        '
        Me.rbtnCargo.AutoSize = True
        Me.rbtnCargo.Checked = True
        Me.rbtnCargo.Location = New System.Drawing.Point(77, 19)
        Me.rbtnCargo.Name = "rbtnCargo"
        Me.rbtnCargo.Size = New System.Drawing.Size(53, 17)
        Me.rbtnCargo.TabIndex = 5
        Me.rbtnCargo.TabStop = True
        Me.rbtnCargo.Text = "Cargo"
        Me.rbtnCargo.UseVisualStyleBackColor = True
        '
        'gbxAfectador
        '
        Me.gbxAfectador.Controls.Add(Me.rbtnCargo)
        Me.gbxAfectador.Controls.Add(Me.rbtnAbono)
        Me.gbxAfectador.Location = New System.Drawing.Point(23, 12)
        Me.gbxAfectador.Name = "gbxAfectador"
        Me.gbxAfectador.Size = New System.Drawing.Size(480, 70)
        Me.gbxAfectador.TabIndex = 7
        Me.gbxAfectador.TabStop = False
        Me.gbxAfectador.Text = "Afectador"
        '
        'gbxCuenta
        '
        Me.gbxCuenta.Controls.Add(Me.selEntidad)
        Me.gbxCuenta.Controls.Add(Me.selCuenta)
        Me.gbxCuenta.Controls.Add(Me.chkIsConceptoEntidad)
        Me.gbxCuenta.Controls.Add(Me.rbtnCuenta)
        Me.gbxCuenta.Controls.Add(Me.rbtnEntidad)
        Me.gbxCuenta.Location = New System.Drawing.Point(23, 89)
        Me.gbxCuenta.Name = "gbxCuenta"
        Me.gbxCuenta.Size = New System.Drawing.Size(480, 104)
        Me.gbxCuenta.TabIndex = 8
        Me.gbxCuenta.TabStop = False
        Me.gbxCuenta.Text = "Cuenta"
        '
        'chkIsConceptoEntidad
        '
        Me.chkIsConceptoEntidad.AutoSize = True
        Me.chkIsConceptoEntidad.Location = New System.Drawing.Point(144, 76)
        Me.chkIsConceptoEntidad.Name = "chkIsConceptoEntidad"
        Me.chkIsConceptoEntidad.Size = New System.Drawing.Size(246, 17)
        Me.chkIsConceptoEntidad.TabIndex = 3
        Me.chkIsConceptoEntidad.Text = "Considerar Nombre de entidad como concepto"
        Me.chkIsConceptoEntidad.UseVisualStyleBackColor = True
        '
        'gbxImporte
        '
        Me.gbxImporte.Controls.Add(Me.btnOrigenNew)
        Me.gbxImporte.Controls.Add(Me.cboImporte)
        Me.gbxImporte.Controls.Add(Me.chkRojo)
        Me.gbxImporte.Controls.Add(Me.lblImporte)
        Me.gbxImporte.Location = New System.Drawing.Point(23, 199)
        Me.gbxImporte.Name = "gbxImporte"
        Me.gbxImporte.Size = New System.Drawing.Size(480, 79)
        Me.gbxImporte.TabIndex = 11
        Me.gbxImporte.TabStop = False
        Me.gbxImporte.Text = "Importe"
        '
        'btnOrigenNew
        '
        Me.btnOrigenNew.Image = Global.Azteca.Windows.Contabilidad.My.Resources.Resources.filenew
        Me.btnOrigenNew.Location = New System.Drawing.Point(396, 24)
        Me.btnOrigenNew.Name = "btnOrigenNew"
        Me.btnOrigenNew.Size = New System.Drawing.Size(27, 24)
        Me.btnOrigenNew.TabIndex = 29
        Me.btnOrigenNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOrigenNew.UseVisualStyleBackColor = True
        Me.btnOrigenNew.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = Global.Azteca.Windows.Contabilidad.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(428, 293)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Image = Global.Azteca.Windows.Contabilidad.My.Resources.Resources.button_ok
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(347, 293)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'selEntidad
        '
        Me.selEntidad.AnySite = False
        Me.selEntidad.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.selEntidad.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.selEntidad.EditorAssembly = "Azteca.ContabilidadWin"
        Me.selEntidad.EditorClass = "Azteca.Windows.Contabilidad.EntidadesForm"
        Me.selEntidad.EditorTitle = "Editar entidad contable..."
        Me.selEntidad.Enabled = False
        Me.selEntidad.Key = 0
        Me.selEntidad.Linked = False
        Me.selEntidad.Location = New System.Drawing.Point(145, 47)
        Me.selEntidad.Name = "selEntidad"
        Me.selEntidad.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selEntidad.Size = New System.Drawing.Size(136, 23)
        Me.selEntidad.TabIndex = 6
        Me.selEntidad.TextWidth = 90
        '
        'selCuenta
        '
        Me.selCuenta.AnySite = False
        Me.selCuenta.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.selCuenta.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.selCuenta.EditorAssembly = "Azteca.ContabilidadWin"
        Me.selCuenta.EditorClass = "Azteca.Windows.Contabilidad.CuentaForm"
        Me.selCuenta.EditorTitle = "Editar Cuenta..."
        Me.selCuenta.Key = 0
        Me.selCuenta.Linked = False
        Me.selCuenta.Location = New System.Drawing.Point(145, 25)
        Me.selCuenta.Name = "selCuenta"
        Me.selCuenta.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selCuenta.Size = New System.Drawing.Size(136, 23)
        Me.selCuenta.TabIndex = 5
        Me.selCuenta.TextWidth = 90
        '
        'RACitem
        '
        Me.ClientSize = New System.Drawing.Size(533, 328)
        Me.Controls.Add(Me.gbxImporte)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.gbxCuenta)
        Me.Controls.Add(Me.gbxAfectador)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "RACitem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.gbxAfectador.ResumeLayout(False)
        Me.gbxAfectador.PerformLayout()
        Me.gbxCuenta.ResumeLayout(False)
        Me.gbxCuenta.PerformLayout()
        Me.gbxImporte.ResumeLayout(False)
        Me.gbxImporte.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rbtnCuenta As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents rbtnEntidad As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents chkRojo As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents cboImporte As Azteca.Windows.Controls.CIComboBox
    Friend WithEvents lblImporte As Azteca.Windows.Controls.CILabel
    Friend WithEvents rbtnAbono As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents rbtnCargo As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents gbxAfectador As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents gbxCuenta As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents chkIsConceptoEntidad As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents selCuenta As Azteca.Windows.Contabilidad.CuentaSelector
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnAceptar As Azteca.Windows.Controls.CIButton
    Friend WithEvents gbxImporte As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents btnOrigenNew As Azteca.Windows.Controls.CIButton
    Friend WithEvents selEntidad As Azteca.Windows.Contabilidad.EntidadSelector
End Class
