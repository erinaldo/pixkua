<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditCertificadoDigitalForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditCertificadoDigitalForm))
        Me.txtPassword = New Azteca.Windows.Controls.CITextBox()
        Me.btnSelPK = New Azteca.Windows.Controls.CIButton()
        Me.btnSelCert = New Azteca.Windows.Controls.CIButton()
        Me.txtPrivateKey = New Azteca.Windows.Controls.CITextBox()
        Me.txtCertificate = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel6 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel5 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.btnChangeCert = New Azteca.Windows.Controls.CIButton()
        Me.dlgCertificate = New System.Windows.Forms.OpenFileDialog()
        Me.dlgPrivateKey = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'txtPassword
        '
        Me.txtPassword.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtPassword.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtPassword.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtPassword.Location = New System.Drawing.Point(111, 64)
        Me.txtPassword.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPassword.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(133, 20)
        Me.txtPassword.TabIndex = 7
        '
        'btnSelPK
        '
        Me.btnSelPK.Location = New System.Drawing.Point(408, 35)
        Me.btnSelPK.Name = "btnSelPK"
        Me.btnSelPK.Size = New System.Drawing.Size(35, 23)
        Me.btnSelPK.TabIndex = 14
        Me.btnSelPK.Text = "..."
        Me.btnSelPK.UseVisualStyleBackColor = True
        '
        'btnSelCert
        '
        Me.btnSelCert.Location = New System.Drawing.Point(408, 9)
        Me.btnSelCert.Name = "btnSelCert"
        Me.btnSelCert.Size = New System.Drawing.Size(35, 23)
        Me.btnSelCert.TabIndex = 13
        Me.btnSelCert.Text = "..."
        Me.btnSelCert.UseVisualStyleBackColor = True
        '
        'txtPrivateKey
        '
        Me.txtPrivateKey.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtPrivateKey.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtPrivateKey.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtPrivateKey.Location = New System.Drawing.Point(111, 38)
        Me.txtPrivateKey.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPrivateKey.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPrivateKey.Name = "txtPrivateKey"
        Me.txtPrivateKey.ReadOnly = True
        Me.txtPrivateKey.Size = New System.Drawing.Size(291, 20)
        Me.txtPrivateKey.TabIndex = 5
        '
        'txtCertificate
        '
        Me.txtCertificate.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCertificate.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCertificate.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCertificate.Location = New System.Drawing.Point(111, 12)
        Me.txtCertificate.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCertificate.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCertificate.Name = "txtCertificate"
        Me.txtCertificate.ReadOnly = True
        Me.txtCertificate.Size = New System.Drawing.Size(291, 20)
        Me.txtCertificate.TabIndex = 3
        '
        'CiLabel6
        '
        Me.CiLabel6.AutoSize = True
        Me.CiLabel6.Location = New System.Drawing.Point(32, 67)
        Me.CiLabel6.Name = "CiLabel6"
        Me.CiLabel6.Size = New System.Drawing.Size(73, 13)
        Me.CiLabel6.TabIndex = 6
        Me.CiLabel6.Text = "Password PK:"
        '
        'CiLabel5
        '
        Me.CiLabel5.AutoSize = True
        Me.CiLabel5.Location = New System.Drawing.Point(30, 41)
        Me.CiLabel5.Name = "CiLabel5"
        Me.CiLabel5.Size = New System.Drawing.Size(75, 13)
        Me.CiLabel5.TabIndex = 4
        Me.CiLabel5.Text = "Llave Privada:"
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.Location = New System.Drawing.Point(45, 15)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(60, 13)
        Me.CiLabel4.TabIndex = 2
        Me.CiLabel4.Text = "Certificado:"
        '
        'btnChangeCert
        '
        Me.btnChangeCert.Image = CType(resources.GetObject("btnChangeCert.Image"), System.Drawing.Image)
        Me.btnChangeCert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChangeCert.Location = New System.Drawing.Point(306, 88)
        Me.btnChangeCert.Name = "btnChangeCert"
        Me.btnChangeCert.Size = New System.Drawing.Size(137, 23)
        Me.btnChangeCert.TabIndex = 8
        Me.btnChangeCert.Text = "Cambiar Certificado..."
        Me.btnChangeCert.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnChangeCert.UseVisualStyleBackColor = True
        '
        'dlgCertificate
        '
        Me.dlgCertificate.Filter = "Certificado de Seguridad (*.cer)|*.cer"
        Me.dlgCertificate.Title = "Seleccione certificado..."
        '
        'dlgPrivateKey
        '
        Me.dlgPrivateKey.Filter = "Llave privada (*.key)|*.key"
        Me.dlgPrivateKey.Title = "Seleccione archivo de llave privada..."
        '
        'EditCertificadoDigitalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 124)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btnSelPK)
        Me.Controls.Add(Me.txtCertificate)
        Me.Controls.Add(Me.btnSelCert)
        Me.Controls.Add(Me.btnChangeCert)
        Me.Controls.Add(Me.txtPrivateKey)
        Me.Controls.Add(Me.CiLabel4)
        Me.Controls.Add(Me.CiLabel5)
        Me.Controls.Add(Me.CiLabel6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditCertificadoDigitalForm"
        Me.Text = "Configuración de Certificado para Facturación"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnChangeCert As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnSelPK As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnSelCert As Azteca.Windows.Controls.CIButton
    Friend WithEvents txtPrivateKey As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtCertificate As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel6 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel5 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtPassword As Azteca.Windows.Controls.CITextBox
    Friend WithEvents dlgCertificate As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dlgPrivateKey As System.Windows.Forms.OpenFileDialog
End Class
