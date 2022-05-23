<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DescargasSATForm
    Inherits Azteca.Windows.Forms.Forma

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
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.lblUltActualizacion = New Azteca.Windows.Controls.CILabel()
        Me.btnActualizar = New Azteca.Windows.Controls.CIButton()
        Me.grpActualizacionLinea = New Azteca.Windows.Controls.CIGroupBox()
        Me.chkCertificados = New Azteca.Windows.Controls.CICheckBox()
        Me.chkFolios = New Azteca.Windows.Controls.CICheckBox()
        Me.CiGroupBox2 = New Azteca.Windows.Controls.CIGroupBox()
        Me.btnManual = New Azteca.Windows.Controls.CIButton()
        Me.btnSelCerts = New Azteca.Windows.Controls.CIButton()
        Me.btnSelFolios = New Azteca.Windows.Controls.CIButton()
        Me.txtArchivoCert = New Azteca.Windows.Controls.CITextBox()
        Me.txtArchivoFolios = New Azteca.Windows.Controls.CITextBox()
        Me.lblArchivosCert = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.grpActualizacionLinea.SuspendLayout()
        Me.CiGroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(14, 34)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(105, 13)
        Me.CiLabel1.TabIndex = 5
        Me.CiLabel1.Text = "Ultima Actualización:"
        '
        'lblUltActualizacion
        '
        Me.lblUltActualizacion.BackColor = System.Drawing.SystemColors.Info
        Me.lblUltActualizacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUltActualizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUltActualizacion.Location = New System.Drawing.Point(125, 29)
        Me.lblUltActualizacion.Name = "lblUltActualizacion"
        Me.lblUltActualizacion.Size = New System.Drawing.Size(179, 23)
        Me.lblUltActualizacion.TabIndex = 6
        Me.lblUltActualizacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(310, 29)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(86, 23)
        Me.btnActualizar.TabIndex = 7
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'grpActualizacionLinea
        '
        Me.grpActualizacionLinea.Controls.Add(Me.chkCertificados)
        Me.grpActualizacionLinea.Controls.Add(Me.chkFolios)
        Me.grpActualizacionLinea.Controls.Add(Me.lblUltActualizacion)
        Me.grpActualizacionLinea.Controls.Add(Me.btnActualizar)
        Me.grpActualizacionLinea.Controls.Add(Me.CiLabel1)
        Me.grpActualizacionLinea.Location = New System.Drawing.Point(12, 12)
        Me.grpActualizacionLinea.Name = "grpActualizacionLinea"
        Me.grpActualizacionLinea.Size = New System.Drawing.Size(461, 130)
        Me.grpActualizacionLinea.TabIndex = 8
        Me.grpActualizacionLinea.TabStop = False
        Me.grpActualizacionLinea.Text = "Actualización en línea"
        '
        'chkCertificados
        '
        Me.chkCertificados.AutoSize = True
        Me.chkCertificados.Checked = True
        Me.chkCertificados.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCertificados.Location = New System.Drawing.Point(125, 91)
        Me.chkCertificados.Name = "chkCertificados"
        Me.chkCertificados.Size = New System.Drawing.Size(124, 17)
        Me.chkCertificados.TabIndex = 9
        Me.chkCertificados.Text = "Certificados Digitales"
        Me.chkCertificados.UseVisualStyleBackColor = True
        '
        'chkFolios
        '
        Me.chkFolios.AutoSize = True
        Me.chkFolios.Checked = True
        Me.chkFolios.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFolios.Location = New System.Drawing.Point(125, 68)
        Me.chkFolios.Name = "chkFolios"
        Me.chkFolios.Size = New System.Drawing.Size(111, 17)
        Me.chkFolios.TabIndex = 8
        Me.chkFolios.Text = "Folios Autorizados"
        Me.chkFolios.UseVisualStyleBackColor = True
        '
        'CiGroupBox2
        '
        Me.CiGroupBox2.Controls.Add(Me.btnManual)
        Me.CiGroupBox2.Controls.Add(Me.btnSelCerts)
        Me.CiGroupBox2.Controls.Add(Me.btnSelFolios)
        Me.CiGroupBox2.Controls.Add(Me.txtArchivoCert)
        Me.CiGroupBox2.Controls.Add(Me.txtArchivoFolios)
        Me.CiGroupBox2.Controls.Add(Me.lblArchivosCert)
        Me.CiGroupBox2.Controls.Add(Me.CiLabel2)
        Me.CiGroupBox2.Location = New System.Drawing.Point(12, 148)
        Me.CiGroupBox2.Name = "CiGroupBox2"
        Me.CiGroupBox2.Size = New System.Drawing.Size(461, 137)
        Me.CiGroupBox2.TabIndex = 9
        Me.CiGroupBox2.TabStop = False
        Me.CiGroupBox2.Text = "Actualización Manual"
        '
        'btnManual
        '
        Me.btnManual.Location = New System.Drawing.Point(310, 91)
        Me.btnManual.Name = "btnManual"
        Me.btnManual.Size = New System.Drawing.Size(130, 23)
        Me.btnManual.TabIndex = 6
        Me.btnManual.Text = "Iniciar Actualización"
        Me.btnManual.UseVisualStyleBackColor = True
        '
        'btnSelCerts
        '
        Me.btnSelCerts.Location = New System.Drawing.Point(402, 62)
        Me.btnSelCerts.Name = "btnSelCerts"
        Me.btnSelCerts.Size = New System.Drawing.Size(38, 23)
        Me.btnSelCerts.TabIndex = 5
        Me.btnSelCerts.Text = "..."
        Me.btnSelCerts.UseVisualStyleBackColor = True
        '
        'btnSelFolios
        '
        Me.btnSelFolios.Location = New System.Drawing.Point(402, 34)
        Me.btnSelFolios.Name = "btnSelFolios"
        Me.btnSelFolios.Size = New System.Drawing.Size(38, 23)
        Me.btnSelFolios.TabIndex = 4
        Me.btnSelFolios.Text = "..."
        Me.btnSelFolios.UseVisualStyleBackColor = True
        '
        'txtArchivoCert
        '
        Me.txtArchivoCert.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtArchivoCert.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtArchivoCert.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtArchivoCert.Location = New System.Drawing.Point(156, 62)
        Me.txtArchivoCert.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtArchivoCert.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtArchivoCert.Name = "txtArchivoCert"
        Me.txtArchivoCert.ReadOnly = True
        Me.txtArchivoCert.Size = New System.Drawing.Size(240, 20)
        Me.txtArchivoCert.TabIndex = 3
        '
        'txtArchivoFolios
        '
        Me.txtArchivoFolios.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtArchivoFolios.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtArchivoFolios.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtArchivoFolios.Location = New System.Drawing.Point(156, 36)
        Me.txtArchivoFolios.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtArchivoFolios.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtArchivoFolios.Name = "txtArchivoFolios"
        Me.txtArchivoFolios.ReadOnly = True
        Me.txtArchivoFolios.Size = New System.Drawing.Size(240, 20)
        Me.txtArchivoFolios.TabIndex = 2
        '
        'lblArchivosCert
        '
        Me.lblArchivosCert.AutoSize = True
        Me.lblArchivosCert.Location = New System.Drawing.Point(31, 65)
        Me.lblArchivosCert.Name = "lblArchivosCert"
        Me.lblArchivosCert.Size = New System.Drawing.Size(119, 13)
        Me.lblArchivosCert.TabIndex = 1
        Me.lblArchivosCert.Text = "Archivo de Certificados:"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(31, 39)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(88, 13)
        Me.CiLabel2.TabIndex = 0
        Me.CiLabel2.Text = "Archivo de folios:"
        '
        'dlgOpen
        '
        Me.dlgOpen.Filter = "Archivos de texto|*.txt"
        Me.dlgOpen.Title = "Seleccione archivo de actualización"
        '
        'DescargasSATForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 324)
        Me.Controls.Add(Me.CiGroupBox2)
        Me.Controls.Add(Me.grpActualizacionLinea)
        Me.Name = "DescargasSATForm"
        Me.Text = "DescargasSATForm"
        Me.Controls.SetChildIndex(Me.grpActualizacionLinea, 0)
        Me.Controls.SetChildIndex(Me.CiGroupBox2, 0)
        Me.grpActualizacionLinea.ResumeLayout(False)
        Me.grpActualizacionLinea.PerformLayout()
        Me.CiGroupBox2.ResumeLayout(False)
        Me.CiGroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblUltActualizacion As Azteca.Windows.Controls.CILabel
    Friend WithEvents btnActualizar As Azteca.Windows.Controls.CIButton
    Friend WithEvents grpActualizacionLinea As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents chkCertificados As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents chkFolios As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents CiGroupBox2 As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents btnManual As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnSelCerts As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnSelFolios As Azteca.Windows.Controls.CIButton
    Friend WithEvents txtArchivoCert As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtArchivoFolios As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblArchivosCert As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents dlgOpen As System.Windows.Forms.OpenFileDialog

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class
