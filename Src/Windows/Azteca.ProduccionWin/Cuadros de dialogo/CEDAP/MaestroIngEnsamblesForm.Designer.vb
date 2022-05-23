<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaestroIngEnsamblesForm
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MaestroIngEnsamblesForm))
        Me.txtOrden = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.cboEnsamble = New Azteca.Windows.Produccion.EnsamblesComboBox(Me.components)
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.btnAceptar = New Azteca.Windows.Controls.CIButton()
        Me.txtDensidad = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtKgMin = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel7 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel8 = New Azteca.Windows.Controls.CILabel()
        Me.txtVelocidadCalandra = New Azteca.Windows.Controls.CITextBox()
        Me.txtLaminas = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel5 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel6 = New Azteca.Windows.Controls.CILabel()
        Me.txtEspesor = New Azteca.Windows.Controls.CITextBox()
        Me.txtAnchoLamina = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtOrden
        '
        Me.txtOrden.Digits = True
        Me.txtOrden.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtOrden.Location = New System.Drawing.Point(74, 46)
        Me.txtOrden.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtOrden.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.Size = New System.Drawing.Size(61, 20)
        Me.txtOrden.TabIndex = 77
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(19, 46)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(39, 13)
        Me.CiLabel1.TabIndex = 76
        Me.CiLabel1.Text = "Orden:"
        '
        'cboEnsamble
        '
        Me.cboEnsamble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEnsamble.FormattingEnabled = True
        Me.cboEnsamble.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboEnsamble.ItemsTable = Nothing
        Me.cboEnsamble.Location = New System.Drawing.Point(74, 12)
        Me.cboEnsamble.Name = "cboEnsamble"
        Me.cboEnsamble.Size = New System.Drawing.Size(234, 21)
        Me.cboEnsamble.TabIndex = 75
        Me.cboEnsamble.UIName = Nothing
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(15, 15)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(56, 13)
        Me.CiLabel3.TabIndex = 74
        Me.CiLabel3.Text = "Ensamble:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(235, 289)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 73
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(143, 289)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 72
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtDensidad
        '
        Me.txtDensidad.Digits = True
        Me.txtDensidad.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtDensidad.Location = New System.Drawing.Point(21, 49)
        Me.txtDensidad.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDensidad.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDensidad.Name = "txtDensidad"
        Me.txtDensidad.Size = New System.Drawing.Size(92, 20)
        Me.txtDensidad.TabIndex = 79
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(18, 33)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(95, 13)
        Me.CiLabel2.TabIndex = 78
        Me.CiLabel2.Text = "Densidad (g/cm3):"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtKgMin)
        Me.GroupBox1.Controls.Add(Me.CiLabel7)
        Me.GroupBox1.Controls.Add(Me.CiLabel8)
        Me.GroupBox1.Controls.Add(Me.txtVelocidadCalandra)
        Me.GroupBox1.Controls.Add(Me.txtLaminas)
        Me.GroupBox1.Controls.Add(Me.CiLabel5)
        Me.GroupBox1.Controls.Add(Me.CiLabel6)
        Me.GroupBox1.Controls.Add(Me.txtEspesor)
        Me.GroupBox1.Controls.Add(Me.txtAnchoLamina)
        Me.GroupBox1.Controls.Add(Me.CiLabel4)
        Me.GroupBox1.Controls.Add(Me.CiLabel2)
        Me.GroupBox1.Controls.Add(Me.txtDensidad)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 189)
        Me.GroupBox1.TabIndex = 80
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Especificaciones"
        '
        'txtKgMin
        '
        Me.txtKgMin.Digits = True
        Me.txtKgMin.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtKgMin.Location = New System.Drawing.Point(152, 145)
        Me.txtKgMin.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtKgMin.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtKgMin.Name = "txtKgMin"
        Me.txtKgMin.Size = New System.Drawing.Size(115, 20)
        Me.txtKgMin.TabIndex = 89
        '
        'CiLabel7
        '
        Me.CiLabel7.AutoSize = True
        Me.CiLabel7.Location = New System.Drawing.Point(149, 129)
        Me.CiLabel7.Name = "CiLabel7"
        Me.CiLabel7.Size = New System.Drawing.Size(44, 13)
        Me.CiLabel7.TabIndex = 88
        Me.CiLabel7.Text = "KG/Min"
        '
        'CiLabel8
        '
        Me.CiLabel8.AutoSize = True
        Me.CiLabel8.Location = New System.Drawing.Point(18, 129)
        Me.CiLabel8.Name = "CiLabel8"
        Me.CiLabel8.Size = New System.Drawing.Size(100, 13)
        Me.CiLabel8.TabIndex = 86
        Me.CiLabel8.Text = "V. Calandra(m/min):"
        '
        'txtVelocidadCalandra
        '
        Me.txtVelocidadCalandra.Digits = True
        Me.txtVelocidadCalandra.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtVelocidadCalandra.Location = New System.Drawing.Point(21, 145)
        Me.txtVelocidadCalandra.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtVelocidadCalandra.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtVelocidadCalandra.Name = "txtVelocidadCalandra"
        Me.txtVelocidadCalandra.Size = New System.Drawing.Size(92, 20)
        Me.txtVelocidadCalandra.TabIndex = 87
        '
        'txtLaminas
        '
        Me.txtLaminas.Digits = True
        Me.txtLaminas.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtLaminas.Location = New System.Drawing.Point(152, 94)
        Me.txtLaminas.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLaminas.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLaminas.Name = "txtLaminas"
        Me.txtLaminas.Size = New System.Drawing.Size(115, 20)
        Me.txtLaminas.TabIndex = 85
        '
        'CiLabel5
        '
        Me.CiLabel5.AutoSize = True
        Me.CiLabel5.Location = New System.Drawing.Point(149, 78)
        Me.CiLabel5.Name = "CiLabel5"
        Me.CiLabel5.Size = New System.Drawing.Size(71, 13)
        Me.CiLabel5.TabIndex = 84
        Me.CiLabel5.Text = "# de Laminas"
        '
        'CiLabel6
        '
        Me.CiLabel6.AutoSize = True
        Me.CiLabel6.Location = New System.Drawing.Point(18, 78)
        Me.CiLabel6.Name = "CiLabel6"
        Me.CiLabel6.Size = New System.Drawing.Size(70, 13)
        Me.CiLabel6.TabIndex = 82
        Me.CiLabel6.Text = "Espesor(mm):"
        '
        'txtEspesor
        '
        Me.txtEspesor.Digits = True
        Me.txtEspesor.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtEspesor.Location = New System.Drawing.Point(21, 94)
        Me.txtEspesor.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtEspesor.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtEspesor.Name = "txtEspesor"
        Me.txtEspesor.Size = New System.Drawing.Size(92, 20)
        Me.txtEspesor.TabIndex = 83
        '
        'txtAnchoLamina
        '
        Me.txtAnchoLamina.Digits = True
        Me.txtAnchoLamina.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtAnchoLamina.Location = New System.Drawing.Point(152, 49)
        Me.txtAnchoLamina.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAnchoLamina.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAnchoLamina.Name = "txtAnchoLamina"
        Me.txtAnchoLamina.Size = New System.Drawing.Size(115, 20)
        Me.txtAnchoLamina.TabIndex = 81
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.Location = New System.Drawing.Point(149, 33)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(118, 13)
        Me.CiLabel4.TabIndex = 80
        Me.CiLabel4.Text = "Ancho de Lamina (mm):"
        '
        'MaestroIngEnsamblesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 324)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtOrden)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.cboEnsamble)
        Me.Controls.Add(Me.CiLabel3)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Name = "MaestroIngEnsamblesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MaestroIngEnsamblesForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOrden As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboEnsamble As Azteca.Windows.Produccion.EnsamblesComboBox
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnAceptar As Azteca.Windows.Controls.CIButton
    Friend WithEvents txtDensidad As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtKgMin As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel7 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel8 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtVelocidadCalandra As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtLaminas As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel5 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel6 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtEspesor As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtAnchoLamina As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
End Class
