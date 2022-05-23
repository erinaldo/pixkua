<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigureConectionForm
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.rdbNoRemoting = New System.Windows.Forms.RadioButton()
        Me.rdbRemoting = New System.Windows.Forms.RadioButton()
        Me.pnlNoRemoting = New System.Windows.Forms.Panel()
        Me.btnTestSQL = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rdbSQL = New System.Windows.Forms.RadioButton()
        Me.rdbWindowsAuth = New System.Windows.Forms.RadioButton()
        Me.txtDatabase = New System.Windows.Forms.TextBox()
        Me.txtDatabaseServer = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.pnlRemoting = New System.Windows.Forms.Panel()
        Me.cboFormato = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkCompresion = New System.Windows.Forms.CheckBox()
        Me.txtDirVirtual = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nudPuerto = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRemoteServer = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grpProtocolo = New System.Windows.Forms.GroupBox()
        Me.rdbHTTP = New System.Windows.Forms.RadioButton()
        Me.rdbTCP = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNoRemoting.SuspendLayout()
        Me.pnlRemoting.SuspendLayout()
        CType(Me.nudPuerto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProtocolo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(406, 47)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Configurar Conexión"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Azteca.Windows.Installer.My.Resources.Resources.SetupBanner
        Me.PictureBox1.Location = New System.Drawing.Point(1, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(499, 73)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'rdbNoRemoting
        '
        Me.rdbNoRemoting.AutoSize = True
        Me.rdbNoRemoting.Checked = True
        Me.rdbNoRemoting.Location = New System.Drawing.Point(50, 102)
        Me.rdbNoRemoting.Name = "rdbNoRemoting"
        Me.rdbNoRemoting.Size = New System.Drawing.Size(143, 17)
        Me.rdbNoRemoting.TabIndex = 11
        Me.rdbNoRemoting.TabStop = True
        Me.rdbNoRemoting.Text = "Conexión cliente-servidor"
        Me.rdbNoRemoting.UseVisualStyleBackColor = True
        '
        'rdbRemoting
        '
        Me.rdbRemoting.AutoSize = True
        Me.rdbRemoting.Location = New System.Drawing.Point(50, 125)
        Me.rdbRemoting.Name = "rdbRemoting"
        Me.rdbRemoting.Size = New System.Drawing.Size(265, 17)
        Me.rdbRemoting.TabIndex = 12
        Me.rdbRemoting.Text = "Conexión por medio de un servidor de aplicaciones"
        Me.rdbRemoting.UseVisualStyleBackColor = True
        '
        'pnlNoRemoting
        '
        Me.pnlNoRemoting.Controls.Add(Me.btnTestSQL)
        Me.pnlNoRemoting.Controls.Add(Me.txtPassword)
        Me.pnlNoRemoting.Controls.Add(Me.txtUsuario)
        Me.pnlNoRemoting.Controls.Add(Me.Label4)
        Me.pnlNoRemoting.Controls.Add(Me.Label3)
        Me.pnlNoRemoting.Controls.Add(Me.rdbSQL)
        Me.pnlNoRemoting.Controls.Add(Me.rdbWindowsAuth)
        Me.pnlNoRemoting.Controls.Add(Me.txtDatabase)
        Me.pnlNoRemoting.Controls.Add(Me.txtDatabaseServer)
        Me.pnlNoRemoting.Controls.Add(Me.Label2)
        Me.pnlNoRemoting.Controls.Add(Me.Label1)
        Me.pnlNoRemoting.Location = New System.Drawing.Point(50, 148)
        Me.pnlNoRemoting.Name = "pnlNoRemoting"
        Me.pnlNoRemoting.Size = New System.Drawing.Size(416, 219)
        Me.pnlNoRemoting.TabIndex = 13
        '
        'btnTestSQL
        '
        Me.btnTestSQL.Location = New System.Drawing.Point(183, 169)
        Me.btnTestSQL.Name = "btnTestSQL"
        Me.btnTestSQL.Size = New System.Drawing.Size(114, 23)
        Me.btnTestSQL.TabIndex = 14
        Me.btnTestSQL.Text = "Probar Conexión"
        Me.btnTestSQL.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Enabled = False
        Me.txtPassword.Location = New System.Drawing.Point(132, 143)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(165, 20)
        Me.txtPassword.TabIndex = 13
        '
        'txtUsuario
        '
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(132, 117)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(165, 20)
        Me.txtUsuario.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Contraseña:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Usuario:"
        '
        'rdbSQL
        '
        Me.rdbSQL.AutoSize = True
        Me.rdbSQL.Location = New System.Drawing.Point(29, 88)
        Me.rdbSQL.Name = "rdbSQL"
        Me.rdbSQL.Size = New System.Drawing.Size(171, 17)
        Me.rdbSQL.TabIndex = 9
        Me.rdbSQL.Text = "Inicio de sesión de SQL Server"
        Me.rdbSQL.UseVisualStyleBackColor = True
        '
        'rdbWindowsAuth
        '
        Me.rdbWindowsAuth.AutoSize = True
        Me.rdbWindowsAuth.Checked = True
        Me.rdbWindowsAuth.Location = New System.Drawing.Point(29, 65)
        Me.rdbWindowsAuth.Name = "rdbWindowsAuth"
        Me.rdbWindowsAuth.Size = New System.Drawing.Size(152, 17)
        Me.rdbWindowsAuth.TabIndex = 8
        Me.rdbWindowsAuth.TabStop = True
        Me.rdbWindowsAuth.Text = "Autenticación de Windows"
        Me.rdbWindowsAuth.UseVisualStyleBackColor = True
        '
        'txtDatabase
        '
        Me.txtDatabase.Location = New System.Drawing.Point(130, 39)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(167, 20)
        Me.txtDatabase.TabIndex = 7
        '
        'txtDatabaseServer
        '
        Me.txtDatabaseServer.Location = New System.Drawing.Point(130, 13)
        Me.txtDatabaseServer.Name = "txtDatabaseServer"
        Me.txtDatabaseServer.Size = New System.Drawing.Size(167, 20)
        Me.txtDatabaseServer.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Base de Datos:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Servidor:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(192, 382)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(136, 23)
        Me.btnAceptar.TabIndex = 14
        Me.btnAceptar.Text = "Aplicar Configuración"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(334, 382)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(132, 23)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "No Configurar ahora"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'pnlRemoting
        '
        Me.pnlRemoting.Controls.Add(Me.cboFormato)
        Me.pnlRemoting.Controls.Add(Me.Label9)
        Me.pnlRemoting.Controls.Add(Me.chkCompresion)
        Me.pnlRemoting.Controls.Add(Me.txtDirVirtual)
        Me.pnlRemoting.Controls.Add(Me.Label8)
        Me.pnlRemoting.Controls.Add(Me.nudPuerto)
        Me.pnlRemoting.Controls.Add(Me.Label7)
        Me.pnlRemoting.Controls.Add(Me.txtRemoteServer)
        Me.pnlRemoting.Controls.Add(Me.Label6)
        Me.pnlRemoting.Controls.Add(Me.grpProtocolo)
        Me.pnlRemoting.Location = New System.Drawing.Point(50, 148)
        Me.pnlRemoting.Name = "pnlRemoting"
        Me.pnlRemoting.Size = New System.Drawing.Size(416, 219)
        Me.pnlRemoting.TabIndex = 14
        Me.pnlRemoting.Visible = False
        '
        'cboFormato
        '
        Me.cboFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato.FormattingEnabled = True
        Me.cboFormato.Items.AddRange(New Object() {"Binario", "SOAP"})
        Me.cboFormato.Location = New System.Drawing.Point(152, 164)
        Me.cboFormato.Name = "cboFormato"
        Me.cboFormato.Size = New System.Drawing.Size(167, 21)
        Me.cboFormato.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(48, 166)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Formato:"
        '
        'chkCompresion
        '
        Me.chkCompresion.AutoSize = True
        Me.chkCompresion.Checked = True
        Me.chkCompresion.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCompresion.Location = New System.Drawing.Point(152, 191)
        Me.chkCompresion.Name = "chkCompresion"
        Me.chkCompresion.Size = New System.Drawing.Size(158, 17)
        Me.chkCompresion.TabIndex = 12
        Me.chkCompresion.Text = "Utilizar compresión de datos"
        Me.chkCompresion.UseVisualStyleBackColor = True
        '
        'txtDirVirtual
        '
        Me.txtDirVirtual.Enabled = False
        Me.txtDirVirtual.Location = New System.Drawing.Point(152, 138)
        Me.txtDirVirtual.Name = "txtDirVirtual"
        Me.txtDirVirtual.Size = New System.Drawing.Size(167, 20)
        Me.txtDirVirtual.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(48, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Directorio Virtual:"
        '
        'nudPuerto
        '
        Me.nudPuerto.Location = New System.Drawing.Point(152, 110)
        Me.nudPuerto.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.nudPuerto.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPuerto.Name = "nudPuerto"
        Me.nudPuerto.Size = New System.Drawing.Size(70, 20)
        Me.nudPuerto.TabIndex = 9
        Me.nudPuerto.Value = New Decimal(New Integer() {8089, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(48, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Puerto:"
        '
        'txtRemoteServer
        '
        Me.txtRemoteServer.Location = New System.Drawing.Point(152, 82)
        Me.txtRemoteServer.Name = "txtRemoteServer"
        Me.txtRemoteServer.Size = New System.Drawing.Size(167, 20)
        Me.txtRemoteServer.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Servidor Remoto:"
        '
        'grpProtocolo
        '
        Me.grpProtocolo.Controls.Add(Me.rdbHTTP)
        Me.grpProtocolo.Controls.Add(Me.rdbTCP)
        Me.grpProtocolo.Location = New System.Drawing.Point(29, 5)
        Me.grpProtocolo.Name = "grpProtocolo"
        Me.grpProtocolo.Size = New System.Drawing.Size(290, 66)
        Me.grpProtocolo.TabIndex = 1
        Me.grpProtocolo.TabStop = False
        Me.grpProtocolo.Text = "Protocolo"
        '
        'rdbHTTP
        '
        Me.rdbHTTP.AutoSize = True
        Me.rdbHTTP.Location = New System.Drawing.Point(22, 42)
        Me.rdbHTTP.Name = "rdbHTTP"
        Me.rdbHTTP.Size = New System.Drawing.Size(54, 17)
        Me.rdbHTTP.TabIndex = 1
        Me.rdbHTTP.Text = "HTTP"
        Me.rdbHTTP.UseVisualStyleBackColor = True
        '
        'rdbTCP
        '
        Me.rdbTCP.AutoSize = True
        Me.rdbTCP.Checked = True
        Me.rdbTCP.Location = New System.Drawing.Point(22, 19)
        Me.rdbTCP.Name = "rdbTCP"
        Me.rdbTCP.Size = New System.Drawing.Size(46, 17)
        Me.rdbTCP.TabIndex = 0
        Me.rdbTCP.TabStop = True
        Me.rdbTCP.Text = "TCP"
        Me.rdbTCP.UseVisualStyleBackColor = True
        '
        'ConfigureConectionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 415)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.rdbRemoting)
        Me.Controls.Add(Me.rdbNoRemoting)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pnlRemoting)
        Me.Controls.Add(Me.pnlNoRemoting)
        Me.Name = "ConfigureConectionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configuración de conexión"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNoRemoting.ResumeLayout(False)
        Me.pnlNoRemoting.PerformLayout()
        Me.pnlRemoting.ResumeLayout(False)
        Me.pnlRemoting.PerformLayout()
        CType(Me.nudPuerto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProtocolo.ResumeLayout(False)
        Me.grpProtocolo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents rdbNoRemoting As System.Windows.Forms.RadioButton
    Friend WithEvents rdbRemoting As System.Windows.Forms.RadioButton
    Friend WithEvents pnlNoRemoting As System.Windows.Forms.Panel
    Friend WithEvents txtDatabase As System.Windows.Forms.TextBox
    Friend WithEvents txtDatabaseServer As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rdbSQL As System.Windows.Forms.RadioButton
    Friend WithEvents rdbWindowsAuth As System.Windows.Forms.RadioButton
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents pnlRemoting As System.Windows.Forms.Panel
    Friend WithEvents grpProtocolo As System.Windows.Forms.GroupBox
    Friend WithEvents rdbHTTP As System.Windows.Forms.RadioButton
    Friend WithEvents rdbTCP As System.Windows.Forms.RadioButton
    Friend WithEvents nudPuerto As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtRemoteServer As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDirVirtual As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboFormato As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkCompresion As System.Windows.Forms.CheckBox
    Friend WithEvents btnTestSQL As System.Windows.Forms.Button
End Class
