<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarFoliosComprobantesForm
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
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.txtNumAprobacion = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.txtAnioAprobacion = New Azteca.Windows.Controls.CITextBox()
        Me.txtFolioFinal = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.txtCertificado = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel5 = New Azteca.Windows.Controls.CILabel()
        Me.txtFolioInicial = New Azteca.Windows.Controls.CITextBox()
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.btnRegistrar = New Azteca.Windows.Controls.CIButton()
        Me.CiLabel6 = New Azteca.Windows.Controls.CILabel()
        Me.txtSerie = New Azteca.Windows.Controls.CITextBox()
        Me.SuspendLayout()
        '
        'CiLabel1
        '
        Me.CiLabel1.Location = New System.Drawing.Point(12, 64)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(109, 18)
        Me.CiLabel1.TabIndex = 2
        Me.CiLabel1.Text = "No. Aprobación:"
        Me.CiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNumAprobacion
        '
        Me.txtNumAprobacion.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNumAprobacion.Digits = True
        Me.txtNumAprobacion.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNumAprobacion.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumAprobacion.Location = New System.Drawing.Point(127, 64)
        Me.txtNumAprobacion.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumAprobacion.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumAprobacion.Name = "txtNumAprobacion"
        Me.txtNumAprobacion.Size = New System.Drawing.Size(105, 20)
        Me.txtNumAprobacion.TabIndex = 3
        '
        'CiLabel2
        '
        Me.CiLabel2.Location = New System.Drawing.Point(12, 90)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(109, 18)
        Me.CiLabel2.TabIndex = 4
        Me.CiLabel2.Text = "Año Aprobación:"
        Me.CiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CiLabel3
        '
        Me.CiLabel3.Location = New System.Drawing.Point(12, 141)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(109, 18)
        Me.CiLabel3.TabIndex = 8
        Me.CiLabel3.Text = "Folio Final:"
        Me.CiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAnioAprobacion
        '
        Me.txtAnioAprobacion.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtAnioAprobacion.Digits = True
        Me.txtAnioAprobacion.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtAnioAprobacion.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtAnioAprobacion.Location = New System.Drawing.Point(127, 90)
        Me.txtAnioAprobacion.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAnioAprobacion.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAnioAprobacion.Name = "txtAnioAprobacion"
        Me.txtAnioAprobacion.Size = New System.Drawing.Size(105, 20)
        Me.txtAnioAprobacion.TabIndex = 5
        '
        'txtFolioFinal
        '
        Me.txtFolioFinal.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtFolioFinal.Digits = True
        Me.txtFolioFinal.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtFolioFinal.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtFolioFinal.Location = New System.Drawing.Point(127, 141)
        Me.txtFolioFinal.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFolioFinal.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFolioFinal.Name = "txtFolioFinal"
        Me.txtFolioFinal.Size = New System.Drawing.Size(105, 20)
        Me.txtFolioFinal.TabIndex = 9
        '
        'CiLabel4
        '
        Me.CiLabel4.Location = New System.Drawing.Point(12, 12)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(109, 18)
        Me.CiLabel4.TabIndex = 0
        Me.CiLabel4.Text = "Certificado:"
        Me.CiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCertificado
        '
        Me.txtCertificado.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCertificado.Digits = True
        Me.txtCertificado.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCertificado.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCertificado.Location = New System.Drawing.Point(127, 12)
        Me.txtCertificado.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCertificado.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCertificado.Name = "txtCertificado"
        Me.txtCertificado.ReadOnly = True
        Me.txtCertificado.Size = New System.Drawing.Size(238, 20)
        Me.txtCertificado.TabIndex = 1
        '
        'CiLabel5
        '
        Me.CiLabel5.Location = New System.Drawing.Point(12, 118)
        Me.CiLabel5.Name = "CiLabel5"
        Me.CiLabel5.Size = New System.Drawing.Size(109, 18)
        Me.CiLabel5.TabIndex = 6
        Me.CiLabel5.Text = "Folio Inicial:"
        Me.CiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFolioInicial
        '
        Me.txtFolioInicial.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtFolioInicial.Digits = True
        Me.txtFolioInicial.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtFolioInicial.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtFolioInicial.Location = New System.Drawing.Point(127, 116)
        Me.txtFolioInicial.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFolioInicial.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFolioInicial.Name = "txtFolioInicial"
        Me.txtFolioInicial.Size = New System.Drawing.Size(105, 20)
        Me.txtFolioInicial.TabIndex = 7
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = Global.Azteca.Windows.Contabilidad.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(290, 186)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegistrar.Image = Global.Azteca.Windows.Contabilidad.My.Resources.Resources.button_ok
        Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistrar.Location = New System.Drawing.Point(209, 186)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistrar.TabIndex = 10
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'CiLabel6
        '
        Me.CiLabel6.Location = New System.Drawing.Point(12, 38)
        Me.CiLabel6.Name = "CiLabel6"
        Me.CiLabel6.Size = New System.Drawing.Size(109, 18)
        Me.CiLabel6.TabIndex = 12
        Me.CiLabel6.Text = "Serie:"
        Me.CiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSerie
        '
        Me.txtSerie.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtSerie.Digits = True
        Me.txtSerie.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtSerie.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtSerie.Location = New System.Drawing.Point(127, 38)
        Me.txtSerie.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSerie.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.ReadOnly = True
        Me.txtSerie.Size = New System.Drawing.Size(105, 20)
        Me.txtSerie.TabIndex = 13
        '
        'RegistrarFoliosComprobantesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 221)
        Me.Controls.Add(Me.txtSerie)
        Me.Controls.Add(Me.CiLabel6)
        Me.Controls.Add(Me.txtFolioInicial)
        Me.Controls.Add(Me.CiLabel5)
        Me.Controls.Add(Me.txtCertificado)
        Me.Controls.Add(Me.CiLabel4)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.txtFolioFinal)
        Me.Controls.Add(Me.txtAnioAprobacion)
        Me.Controls.Add(Me.CiLabel3)
        Me.Controls.Add(Me.CiLabel2)
        Me.Controls.Add(Me.txtNumAprobacion)
        Me.Controls.Add(Me.CiLabel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RegistrarFoliosComprobantesForm"
        Me.Text = "Registro de Solicitud de Folios para Facturación"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNumAprobacion As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtAnioAprobacion As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtFolioFinal As Azteca.Windows.Controls.CITextBox
    Friend WithEvents btnRegistrar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCertificado As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel5 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtFolioInicial As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel6 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtSerie As Azteca.Windows.Controls.CITextBox
End Class
