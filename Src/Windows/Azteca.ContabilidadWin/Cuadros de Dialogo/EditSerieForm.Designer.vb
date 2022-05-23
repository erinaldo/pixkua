<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditSerieForm
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
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.btnAceptar = New Azteca.Windows.Controls.CIButton()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.txtSerie = New Azteca.Windows.Controls.CITextBox()
        Me.txtCertificado = New Azteca.Windows.Controls.CITextBox()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = Global.Azteca.Windows.Contabilidad.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(296, 121)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Image = Global.Azteca.Windows.Contabilidad.My.Resources.Resources.button_ok
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(215, 121)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(42, 48)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(34, 13)
        Me.CiLabel1.TabIndex = 0
        Me.CiLabel1.Text = "Serie:"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(16, 22)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(60, 13)
        Me.CiLabel2.TabIndex = 4
        Me.CiLabel2.Text = "Certificado:"
        '
        'txtSerie
        '
        Me.txtSerie.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtSerie.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtSerie.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtSerie.Location = New System.Drawing.Point(82, 45)
        Me.txtSerie.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSerie.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(114, 20)
        Me.txtSerie.TabIndex = 1
        '
        'txtCertificado
        '
        Me.txtCertificado.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCertificado.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCertificado.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCertificado.Location = New System.Drawing.Point(82, 19)
        Me.txtCertificado.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCertificado.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCertificado.Name = "txtCertificado"
        Me.txtCertificado.ReadOnly = True
        Me.txtCertificado.Size = New System.Drawing.Size(289, 20)
        Me.txtCertificado.TabIndex = 5
        '
        'EditSerieForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 156)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtCertificado)
        Me.Controls.Add(Me.txtSerie)
        Me.Controls.Add(Me.CiLabel2)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Name = "EditSerieForm"
        Me.Text = "Editar serie de comprobantes fiscales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnAceptar As Azteca.Windows.Controls.CIButton
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtSerie As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtCertificado As Azteca.Windows.Controls.CITextBox
End Class
