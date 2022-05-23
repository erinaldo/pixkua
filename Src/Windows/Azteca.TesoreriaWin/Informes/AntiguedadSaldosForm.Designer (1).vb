<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AntiguedadSaldosForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AntiguedadSaldosForm))
        Me.lblFechaIni = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.dtpFechaFin = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.dtpFechaIni = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.upDwnDias = New Azteca.Windows.Controls.CINumericUpDown()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.btnAceptar = New Azteca.Windows.Controls.CIButton()
        CType(Me.upDwnDias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFechaIni
        '
        Me.lblFechaIni.AutoSize = True
        Me.lblFechaIni.Location = New System.Drawing.Point(28, 23)
        Me.lblFechaIni.Name = "lblFechaIni"
        Me.lblFechaIni.Size = New System.Drawing.Size(70, 13)
        Me.lblFechaIni.TabIndex = 75
        Me.lblFechaIni.Text = "Fecha Inicial:"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(28, 51)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(65, 13)
        Me.CiLabel2.TabIndex = 77
        Me.CiLabel2.Text = "Fecha Final:"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaFin.Location = New System.Drawing.Point(114, 48)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(210, 20)
        Me.dtpFechaFin.TabIndex = 76
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaIni.Location = New System.Drawing.Point(114, 20)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(211, 20)
        Me.dtpFechaIni.TabIndex = 74
        '
        'upDwnDias
        '
        Me.upDwnDias.HighlightColor = System.Drawing.SystemColors.Info
        Me.upDwnDias.Location = New System.Drawing.Point(114, 74)
        Me.upDwnDias.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.upDwnDias.Name = "upDwnDias"
        Me.upDwnDias.Size = New System.Drawing.Size(59, 20)
        Me.upDwnDias.TabIndex = 79
        Me.upDwnDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.upDwnDias.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(28, 76)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(80, 13)
        Me.CiLabel1.TabIndex = 80
        Me.CiLabel1.Text = "Grupos de Dias"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(250, 104)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 82
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(169, 104)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 81
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'AntiguedadSaldosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 137)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.upDwnDias)
        Me.Controls.Add(Me.lblFechaIni)
        Me.Controls.Add(Me.CiLabel2)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.dtpFechaIni)
        Me.Name = "AntiguedadSaldosForm"
        Me.Text = "Antiguedad de Saldos"
        CType(Me.upDwnDias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFechaIni As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents dtpFechaFin As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents dtpFechaIni As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents upDwnDias As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnAceptar As Azteca.Windows.Controls.CIButton
End Class
