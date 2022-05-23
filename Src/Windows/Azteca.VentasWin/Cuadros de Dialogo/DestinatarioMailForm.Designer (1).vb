<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DestinatarioMailForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DestinatarioMailForm))
        Me.lblPara = New Azteca.Windows.Controls.CILabel()
        Me.lblCC = New Azteca.Windows.Controls.CILabel()
        Me.lblMensaje = New Azteca.Windows.Controls.CILabel()
        Me.txtPara = New Azteca.Windows.Controls.CITextBox()
        Me.txtCC = New Azteca.Windows.Controls.CITextBox()
        Me.txtMensaje = New Azteca.Windows.Controls.CITextBox()
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.btnAceptar = New Azteca.Windows.Controls.CIButton()
        Me.SuspendLayout()
        '
        'lblPara
        '
        Me.lblPara.AutoSize = True
        Me.lblPara.Location = New System.Drawing.Point(35, 42)
        Me.lblPara.Name = "lblPara"
        Me.lblPara.Size = New System.Drawing.Size(39, 13)
        Me.lblPara.TabIndex = 0
        Me.lblPara.Text = "PARA:"
        '
        'lblCC
        '
        Me.lblCC.AutoSize = True
        Me.lblCC.Location = New System.Drawing.Point(35, 68)
        Me.lblCC.Name = "lblCC"
        Me.lblCC.Size = New System.Drawing.Size(24, 13)
        Me.lblCC.TabIndex = 1
        Me.lblCC.Text = "CC:"
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Location = New System.Drawing.Point(35, 93)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(60, 13)
        Me.lblMensaje.TabIndex = 2
        Me.lblMensaje.Text = "MENSAJE:"
        '
        'txtPara
        '
        Me.txtPara.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtPara.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtPara.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtPara.Location = New System.Drawing.Point(101, 42)
        Me.txtPara.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPara.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPara.Name = "txtPara"
        Me.txtPara.RegularExpression = resources.GetString("txtPara.RegularExpression")
        Me.txtPara.Size = New System.Drawing.Size(226, 20)
        Me.txtPara.TabIndex = 3
        '
        'txtCC
        '
        Me.txtCC.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCC.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCC.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCC.Location = New System.Drawing.Point(101, 65)
        Me.txtCC.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCC.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCC.Name = "txtCC"
        Me.txtCC.Size = New System.Drawing.Size(226, 20)
        Me.txtCC.TabIndex = 4
        '
        'txtMensaje
        '
        Me.txtMensaje.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtMensaje.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtMensaje.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtMensaje.Location = New System.Drawing.Point(101, 86)
        Me.txtMensaje.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtMensaje.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(226, 102)
        Me.txtMensaje.TabIndex = 5
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(252, 205)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 90
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(171, 205)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 89
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'DestinatarioMailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 240)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtMensaje)
        Me.Controls.Add(Me.txtCC)
        Me.Controls.Add(Me.txtPara)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.lblCC)
        Me.Controls.Add(Me.lblPara)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DestinatarioMailForm"
        Me.Text = "Destinatario de correo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPara As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCC As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblMensaje As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtPara As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtCC As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtMensaje As Azteca.Windows.Controls.CITextBox
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnAceptar As Azteca.Windows.Controls.CIButton
End Class
