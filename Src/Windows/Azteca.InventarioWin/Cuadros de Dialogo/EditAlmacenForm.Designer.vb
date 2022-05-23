<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditAlmacenForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditAlmacenForm))
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.btnAceptar = New Azteca.Windows.Controls.CIButton()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.chkActivo = New Azteca.Windows.Controls.CICheckBox()
        Me.chkPermiteNeg = New Azteca.Windows.Controls.CICheckBox()
        Me.chkReqCapturaFisico = New Azteca.Windows.Controls.CICheckBox()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.cboArea = New Azteca.Windows.Inventario.AreasComboBox()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.txtCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(376, 185)
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
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(295, 185)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(20, 41)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(47, 13)
        Me.CiLabel1.TabIndex = 2
        Me.CiLabel1.Text = "Nombre:"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(20, 14)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(32, 13)
        Me.CiLabel2.TabIndex = 0
        Me.CiLabel2.Text = "Área:"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.Location = New System.Drawing.Point(73, 97)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 6
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'chkPermiteNeg
        '
        Me.chkPermiteNeg.AutoSize = True
        Me.chkPermiteNeg.Location = New System.Drawing.Point(73, 120)
        Me.chkPermiteNeg.Name = "chkPermiteNeg"
        Me.chkPermiteNeg.Size = New System.Drawing.Size(112, 17)
        Me.chkPermiteNeg.TabIndex = 7
        Me.chkPermiteNeg.Text = "Permite Negativos"
        Me.chkPermiteNeg.UseVisualStyleBackColor = True
        '
        'chkReqCapturaFisico
        '
        Me.chkReqCapturaFisico.AutoSize = True
        Me.chkReqCapturaFisico.Location = New System.Drawing.Point(73, 142)
        Me.chkReqCapturaFisico.Name = "chkReqCapturaFisico"
        Me.chkReqCapturaFisico.Size = New System.Drawing.Size(201, 17)
        Me.chkReqCapturaFisico.TabIndex = 8
        Me.chkReqCapturaFisico.Text = "Requiere captura de inventario físico"
        Me.chkReqCapturaFisico.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(73, 38)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(228, 20)
        Me.txtNombre.TabIndex = 3
        '
        'cboArea
        '
        Me.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboArea.FormattingEnabled = True
        Me.cboArea.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboArea.ItemsTable = Nothing
        Me.cboArea.Location = New System.Drawing.Point(73, 11)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboArea.Size = New System.Drawing.Size(228, 21)
        Me.cboArea.TabIndex = 1
        Me.cboArea.UIName = Nothing
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(20, 69)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(44, 13)
        Me.CiLabel3.TabIndex = 4
        Me.CiLabel3.Text = "Cuenta:"
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
        Me.txtCuenta.Location = New System.Drawing.Point(73, 64)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.txtCuenta.Size = New System.Drawing.Size(378, 23)
        Me.txtCuenta.TabIndex = 5
        '
        'EditAlmacenForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 220)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.CiLabel3)
        Me.Controls.Add(Me.cboArea)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.chkReqCapturaFisico)
        Me.Controls.Add(Me.chkPermiteNeg)
        Me.Controls.Add(Me.chkActivo)
        Me.Controls.Add(Me.CiLabel2)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Name = "EditAlmacenForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Editar información de almacén"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnAceptar As Azteca.Windows.Controls.CIButton
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents chkActivo As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents chkPermiteNeg As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents chkReqCapturaFisico As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents cboArea As Azteca.Windows.Inventario.AreasComboBox
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCuenta As Azteca.Windows.Contabilidad.CuentaSelector
End Class
