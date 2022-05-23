<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdenesTrabajoEnsamblesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrdenesTrabajoEnsamblesForm))
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.btnAceptar = New Azteca.Windows.Controls.CIButton()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.txtOrden = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.txtHorasMaquina = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.txtCostoMaquina = New Azteca.Windows.Controls.CITextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtHorasLabor = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel5 = New Azteca.Windows.Controls.CILabel()
        Me.txtCostoLabor = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel6 = New Azteca.Windows.Controls.CILabel()
        Me.cboEnsamble = New Azteca.Windows.Produccion.EnsamblesComboBox(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(230, 218)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(149, 218)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(12, 9)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(56, 13)
        Me.CiLabel3.TabIndex = 68
        Me.CiLabel3.Text = "Ensamble:"
        '
        'txtOrden
        '
        Me.txtOrden.Digits = True
        Me.txtOrden.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtOrden.Location = New System.Drawing.Point(230, 25)
        Me.txtOrden.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtOrden.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.Size = New System.Drawing.Size(61, 20)
        Me.txtOrden.TabIndex = 1
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(227, 9)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(39, 13)
        Me.CiLabel1.TabIndex = 70
        Me.CiLabel1.Text = "Orden:"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(11, 34)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(70, 13)
        Me.CiLabel2.TabIndex = 74
        Me.CiLabel2.Text = "Hrs Maquina:"
        '
        'txtHorasMaquina
        '
        Me.txtHorasMaquina.Digits = True
        Me.txtHorasMaquina.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtHorasMaquina.Format = "N2"
        Me.txtHorasMaquina.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtHorasMaquina.Location = New System.Drawing.Point(14, 53)
        Me.txtHorasMaquina.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtHorasMaquina.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtHorasMaquina.Name = "txtHorasMaquina"
        Me.txtHorasMaquina.Size = New System.Drawing.Size(89, 20)
        Me.txtHorasMaquina.TabIndex = 0
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.Location = New System.Drawing.Point(118, 34)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(81, 13)
        Me.CiLabel4.TabIndex = 76
        Me.CiLabel4.Text = "Costo Maquina:"
        '
        'txtCostoMaquina
        '
        Me.txtCostoMaquina.Digits = True
        Me.txtCostoMaquina.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtCostoMaquina.Format = "C2"
        Me.txtCostoMaquina.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCostoMaquina.Location = New System.Drawing.Point(121, 53)
        Me.txtCostoMaquina.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCostoMaquina.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCostoMaquina.Name = "txtCostoMaquina"
        Me.txtCostoMaquina.Size = New System.Drawing.Size(88, 20)
        Me.txtCostoMaquina.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtHorasLabor)
        Me.GroupBox1.Controls.Add(Me.CiLabel5)
        Me.GroupBox1.Controls.Add(Me.txtCostoLabor)
        Me.GroupBox1.Controls.Add(Me.CiLabel6)
        Me.GroupBox1.Controls.Add(Me.txtHorasMaquina)
        Me.GroupBox1.Controls.Add(Me.CiLabel4)
        Me.GroupBox1.Controls.Add(Me.txtCostoMaquina)
        Me.GroupBox1.Controls.Add(Me.CiLabel2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 149)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Costos"
        '
        'txtHorasLabor
        '
        Me.txtHorasLabor.Digits = True
        Me.txtHorasLabor.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtHorasLabor.Format = "N2"
        Me.txtHorasLabor.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtHorasLabor.Location = New System.Drawing.Point(14, 103)
        Me.txtHorasLabor.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtHorasLabor.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtHorasLabor.Name = "txtHorasLabor"
        Me.txtHorasLabor.Size = New System.Drawing.Size(89, 20)
        Me.txtHorasLabor.TabIndex = 2
        '
        'CiLabel5
        '
        Me.CiLabel5.AutoSize = True
        Me.CiLabel5.Location = New System.Drawing.Point(118, 84)
        Me.CiLabel5.Name = "CiLabel5"
        Me.CiLabel5.Size = New System.Drawing.Size(67, 13)
        Me.CiLabel5.TabIndex = 80
        Me.CiLabel5.Text = "Costo Labor:"
        '
        'txtCostoLabor
        '
        Me.txtCostoLabor.Digits = True
        Me.txtCostoLabor.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtCostoLabor.Format = "C2"
        Me.txtCostoLabor.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCostoLabor.Location = New System.Drawing.Point(121, 103)
        Me.txtCostoLabor.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCostoLabor.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCostoLabor.Name = "txtCostoLabor"
        Me.txtCostoLabor.Size = New System.Drawing.Size(88, 20)
        Me.txtCostoLabor.TabIndex = 3
        '
        'CiLabel6
        '
        Me.CiLabel6.AutoSize = True
        Me.CiLabel6.Location = New System.Drawing.Point(11, 84)
        Me.CiLabel6.Name = "CiLabel6"
        Me.CiLabel6.Size = New System.Drawing.Size(56, 13)
        Me.CiLabel6.TabIndex = 78
        Me.CiLabel6.Text = "Hrs Labor:"
        '
        'cboEnsamble
        '
        Me.cboEnsamble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEnsamble.FormattingEnabled = True
        Me.cboEnsamble.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboEnsamble.ItemsTable = Nothing
        Me.cboEnsamble.Location = New System.Drawing.Point(12, 25)
        Me.cboEnsamble.Name = "cboEnsamble"
        Me.cboEnsamble.Size = New System.Drawing.Size(209, 21)
        Me.cboEnsamble.TabIndex = 0
        Me.cboEnsamble.UIName = Nothing
        '
        'OrdenesTrabajoEnsamblesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 253)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtOrden)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.cboEnsamble)
        Me.Controls.Add(Me.CiLabel3)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Name = "OrdenesTrabajoEnsamblesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EnsamblesForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnAceptar As Azteca.Windows.Controls.CIButton
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboEnsamble As Azteca.Windows.Produccion.EnsamblesComboBox
    Friend WithEvents txtOrden As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtHorasMaquina As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCostoMaquina As Azteca.Windows.Controls.CITextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtHorasLabor As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel5 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCostoLabor As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel6 As Azteca.Windows.Controls.CILabel
End Class
