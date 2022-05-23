<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroTimbradoForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroTimbradoForm))
        Me.ColorWithAlpha1 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha2 = New Azteca.Windows.ColorWithAlpha()
        Me.tabLogin = New C1.Win.C1Command.C1DockingTab()
        Me.pagLogin = New C1.Win.C1Command.C1DockingTabPage()
        Me.lblPruebas = New Azteca.Windows.Controls.CILabel()
        Me.lblUsuario = New C1.Win.C1Input.C1Label()
        Me.lblPwd = New C1.Win.C1Input.C1Label()
        Me.CiPanel3 = New Azteca.Windows.Controls.CIPanel()
        Me.lblDescripcionCertificados = New Azteca.Windows.Controls.CILabel()
        Me.lblCertificados = New Azteca.Windows.Controls.CILabel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnCancelar = New C1.Win.C1Input.C1Button()
        Me.btnAceptar = New C1.Win.C1Input.C1Button()
        Me.txtUsuario = New C1.Win.C1Input.C1TextBox()
        Me.txtPassword = New C1.Win.C1Input.C1TextBox()
        Me.lblAunNo = New System.Windows.Forms.Label()
        Me.lnkPagina = New System.Windows.Forms.LinkLabel()
        CType(Me.tabLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabLogin.SuspendLayout()
        Me.pagLogin.SuspendLayout()
        CType(Me.lblUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPwd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CiPanel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.White
        Me.ColorWithAlpha1.Parent = Nothing
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorWithAlpha2.Parent = Nothing
        '
        'tabLogin
        '
        Me.tabLogin.Controls.Add(Me.pagLogin)
        Me.tabLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabLogin.Location = New System.Drawing.Point(0, 0)
        Me.tabLogin.Name = "tabLogin"
        Me.tabLogin.ShowTabs = False
        Me.tabLogin.Size = New System.Drawing.Size(423, 258)
        Me.tabLogin.TabIndex = 16
        Me.tabLogin.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabLogin.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabLogin.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagLogin
        '
        Me.pagLogin.Controls.Add(Me.lnkPagina)
        Me.pagLogin.Controls.Add(Me.lblAunNo)
        Me.pagLogin.Controls.Add(Me.lblPwd)
        Me.pagLogin.Controls.Add(Me.lblUsuario)
        Me.pagLogin.Controls.Add(Me.lblPruebas)
        Me.pagLogin.Controls.Add(Me.CiPanel3)
        Me.pagLogin.Controls.Add(Me.btnCancelar)
        Me.pagLogin.Controls.Add(Me.btnAceptar)
        Me.pagLogin.Controls.Add(Me.txtUsuario)
        Me.pagLogin.Controls.Add(Me.txtPassword)
        Me.pagLogin.Location = New System.Drawing.Point(1, 1)
        Me.pagLogin.Name = "pagLogin"
        Me.pagLogin.Size = New System.Drawing.Size(421, 256)
        Me.pagLogin.TabIndex = 0
        Me.pagLogin.TabStop = False
        Me.pagLogin.Text = "Inicio de Sesión"
        '
        'lblPruebas
        '
        Me.lblPruebas.AutoSize = True
        Me.lblPruebas.BackColor = System.Drawing.Color.Transparent
        Me.lblPruebas.ForeColor = System.Drawing.Color.Red
        Me.lblPruebas.Location = New System.Drawing.Point(104, 196)
        Me.lblPruebas.Name = "lblPruebas"
        Me.lblPruebas.Size = New System.Drawing.Size(188, 13)
        Me.lblPruebas.TabIndex = 20
        Me.lblPruebas.Text = "Usuario actual habilitado para pruebas"
        '
        'lblUsuario
        '
        Me.lblUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUsuario.ForeColor = System.Drawing.Color.Black
        Me.lblUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblUsuario.Location = New System.Drawing.Point(71, 137)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(76, 18)
        Me.lblUsuario.TabIndex = 3
        Me.lblUsuario.Tag = Nothing
        Me.lblUsuario.Text = "Usuario:"
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblUsuario.TextDetached = True
        Me.lblUsuario.Value = "Usuario:"
        '
        'lblPwd
        '
        Me.lblPwd.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPwd.ForeColor = System.Drawing.Color.Black
        Me.lblPwd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPwd.Location = New System.Drawing.Point(71, 165)
        Me.lblPwd.Name = "lblPwd"
        Me.lblPwd.Size = New System.Drawing.Size(76, 18)
        Me.lblPwd.TabIndex = 1
        Me.lblPwd.Tag = Nothing
        Me.lblPwd.Text = "Contraseña:"
        Me.lblPwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPwd.TextDetached = True
        Me.lblPwd.Value = "Contraseña:"
        '
        'CiPanel3
        '
        Me.CiPanel3.BackgroundImage = CType(resources.GetObject("CiPanel3.BackgroundImage"), System.Drawing.Image)
        Me.CiPanel3.Controls.Add(Me.lblDescripcionCertificados)
        Me.CiPanel3.Controls.Add(Me.lblCertificados)
        Me.CiPanel3.Controls.Add(Me.PictureBox3)
        Me.CiPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.CiPanel3.GradientColorA = System.Drawing.SystemColors.ControlLight
        Me.CiPanel3.GradientColorB = System.Drawing.SystemColors.ControlDark
        Me.CiPanel3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.CiPanel3.Location = New System.Drawing.Point(0, 0)
        Me.CiPanel3.Name = "CiPanel3"
        Me.CiPanel3.Size = New System.Drawing.Size(421, 70)
        Me.CiPanel3.TabIndex = 72
        Me.CiPanel3.UseGradient = False
        '
        'lblDescripcionCertificados
        '
        Me.lblDescripcionCertificados.BackColor = System.Drawing.Color.Transparent
        Me.lblDescripcionCertificados.Location = New System.Drawing.Point(6, 36)
        Me.lblDescripcionCertificados.Name = "lblDescripcionCertificados"
        Me.lblDescripcionCertificados.Size = New System.Drawing.Size(262, 28)
        Me.lblDescripcionCertificados.TabIndex = 19
        Me.lblDescripcionCertificados.Text = "Capture el usuario y contraseña que le proporcionamos al adquirir sus folios de t" & _
    "imbrado"
        '
        'lblCertificados
        '
        Me.lblCertificados.AutoSize = True
        Me.lblCertificados.BackColor = System.Drawing.Color.Transparent
        Me.lblCertificados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCertificados.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblCertificados.Location = New System.Drawing.Point(3, 2)
        Me.lblCertificados.Name = "lblCertificados"
        Me.lblCertificados.Size = New System.Drawing.Size(261, 16)
        Me.lblCertificados.TabIndex = 9
        Me.lblCertificados.Text = "Gracias por registrarse con nosotros"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(325, 7)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(77, 60)
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(325, 222)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        Me.btnCancelar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.btnCancelar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(244, 222)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 6
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        Me.btnAceptar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.btnAceptar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'txtUsuario
        '
        Me.txtUsuario.AutoSize = False
        Me.txtUsuario.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.Location = New System.Drawing.Point(153, 137)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(156, 20)
        Me.txtUsuario.TabIndex = 2
        Me.txtUsuario.Tag = Nothing
        Me.txtUsuario.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.txtUsuario.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'txtPassword
        '
        Me.txtPassword.AutoSize = False
        Me.txtPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.HideSelection = False
        Me.txtPassword.Location = New System.Drawing.Point(153, 163)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(156, 20)
        Me.txtPassword.TabIndex = 0
        Me.txtPassword.Tag = Nothing
        Me.txtPassword.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.txtPassword.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'lblAunNo
        '
        Me.lblAunNo.BackColor = System.Drawing.Color.Transparent
        Me.lblAunNo.Location = New System.Drawing.Point(3, 80)
        Me.lblAunNo.Name = "lblAunNo"
        Me.lblAunNo.Size = New System.Drawing.Size(415, 44)
        Me.lblAunNo.TabIndex = 101
        Me.lblAunNo.Text = "Si aún no se registra con nosotros lo invitamos a conocer nuestro servicio de Tim" & _
    "brado para la Facturación  Electrónica. Visite nuestra página"
        Me.lblAunNo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lnkPagina
        '
        Me.lnkPagina.AutoSize = True
        Me.lnkPagina.BackColor = System.Drawing.Color.Transparent
        Me.lnkPagina.Location = New System.Drawing.Point(130, 110)
        Me.lnkPagina.Name = "lnkPagina"
        Me.lnkPagina.Size = New System.Drawing.Size(125, 13)
        Me.lnkPagina.TabIndex = 100
        Me.lnkPagina.TabStop = True
        Me.lnkPagina.Text = "www.AztecaSoftware.mx"
        '
        'RegistroTimbradoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 258)
        Me.Controls.Add(Me.tabLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RegistroTimbradoForm"
        Me.Text = "Registro de Timbrado..."
        CType(Me.tabLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabLogin.ResumeLayout(False)
        Me.pagLogin.ResumeLayout(False)
        Me.pagLogin.PerformLayout()
        CType(Me.lblUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPwd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CiPanel3.ResumeLayout(False)
        Me.CiPanel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ColorWithAlpha1 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents tabLogin As C1.Win.C1Command.C1DockingTab
    Friend WithEvents pagLogin As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents lblPwd As C1.Win.C1Input.C1Label
    Friend WithEvents lblUsuario As C1.Win.C1Input.C1Label
    Friend WithEvents btnCancelar As C1.Win.C1Input.C1Button
    Friend WithEvents btnAceptar As C1.Win.C1Input.C1Button
    Friend WithEvents txtUsuario As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtPassword As C1.Win.C1Input.C1TextBox
    Friend WithEvents CiPanel3 As Azteca.Windows.Controls.CIPanel
    Friend WithEvents lblDescripcionCertificados As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCertificados As Azteca.Windows.Controls.CILabel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblPruebas As Azteca.Windows.Controls.CILabel
    Friend WithEvents lnkPagina As System.Windows.Forms.LinkLabel
    Friend WithEvents lblAunNo As System.Windows.Forms.Label
End Class
