<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigRemoteConecctionForm
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfigRemoteConecctionForm))
        Me.btnAceptar = New Azteca.Windows.Controls.CIButton()
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.rdbLAN = New Azteca.Windows.Controls.CIRadioButton()
        Me.rdbWEB = New Azteca.Windows.Controls.CIRadioButton()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.lblConfig = New Azteca.Windows.Controls.CILabel()
        Me.grpChangeConfig = New Azteca.Windows.Controls.CIGroupBox()
        Me.rdbTest = New Azteca.Windows.Controls.CIRadioButton()
        Me.grpChangeConfig.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(267, 134)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(348, 134)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'rdbLAN
        '
        Me.rdbLAN.Checked = True
        Me.rdbLAN.Image = CType(resources.GetObject("rdbLAN.Image"), System.Drawing.Image)
        Me.rdbLAN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rdbLAN.Location = New System.Drawing.Point(6, 19)
        Me.rdbLAN.Name = "rdbLAN"
        Me.rdbLAN.Size = New System.Drawing.Size(135, 27)
        Me.rdbLAN.TabIndex = 2
        Me.rdbLAN.TabStop = True
        Me.rdbLAN.Text = "Configuración LAN"
        Me.rdbLAN.UseVisualStyleBackColor = True
        '
        'rdbWEB
        '
        Me.rdbWEB.Image = CType(resources.GetObject("rdbWEB.Image"), System.Drawing.Image)
        Me.rdbWEB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rdbWEB.Location = New System.Drawing.Point(6, 52)
        Me.rdbWEB.Name = "rdbWEB"
        Me.rdbWEB.Size = New System.Drawing.Size(135, 24)
        Me.rdbWEB.TabIndex = 3
        Me.rdbWEB.Text = "Configuración WEB"
        Me.rdbWEB.UseVisualStyleBackColor = True
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(306, 12)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(108, 13)
        Me.CiLabel1.TabIndex = 4
        Me.CiLabel1.Text = "Configuración Actual:"
        '
        'lblConfig
        '
        Me.lblConfig.BackColor = System.Drawing.Color.Gray
        Me.lblConfig.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfig.ForeColor = System.Drawing.Color.Blue
        Me.lblConfig.Location = New System.Drawing.Point(306, 25)
        Me.lblConfig.Name = "lblConfig"
        Me.lblConfig.Size = New System.Drawing.Size(108, 30)
        Me.lblConfig.TabIndex = 5
        Me.lblConfig.Text = "LAN"
        Me.lblConfig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpChangeConfig
        '
        Me.grpChangeConfig.Controls.Add(Me.rdbTest)
        Me.grpChangeConfig.Controls.Add(Me.rdbLAN)
        Me.grpChangeConfig.Controls.Add(Me.rdbWEB)
        Me.grpChangeConfig.Location = New System.Drawing.Point(12, 12)
        Me.grpChangeConfig.Name = "grpChangeConfig"
        Me.grpChangeConfig.Size = New System.Drawing.Size(288, 116)
        Me.grpChangeConfig.TabIndex = 6
        Me.grpChangeConfig.TabStop = False
        Me.grpChangeConfig.Text = "Cambiar configuración a:"
        '
        'rdbTest
        '
        Me.rdbTest.Image = CType(resources.GetObject("rdbTest.Image"), System.Drawing.Image)
        Me.rdbTest.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rdbTest.Location = New System.Drawing.Point(6, 82)
        Me.rdbTest.Name = "rdbTest"
        Me.rdbTest.Size = New System.Drawing.Size(135, 24)
        Me.rdbTest.TabIndex = 4
        Me.rdbTest.Text = "Pruebas"
        Me.rdbTest.UseVisualStyleBackColor = True
        '
        'ConfigRemoteConecctionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 169)
        Me.Controls.Add(Me.grpChangeConfig)
        Me.Controls.Add(Me.lblConfig)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Name = "ConfigRemoteConecctionForm"
        Me.Text = "Configuración de conexión Remota"
        Me.grpChangeConfig.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAceptar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents rdbLAN As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents rdbWEB As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblConfig As Azteca.Windows.Controls.CILabel
    Friend WithEvents grpChangeConfig As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents rdbTest As Azteca.Windows.Controls.CIRadioButton
End Class
