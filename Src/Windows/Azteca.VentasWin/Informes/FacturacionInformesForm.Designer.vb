<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacturacionInformesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FacturacionInformesForm))
        Me.ColorWithAlpha1 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha2 = New Azteca.Windows.ColorWithAlpha()
        Me.lblFechaIni = New Azteca.Windows.Controls.CILabel()
        Me.dtpFechaFin = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.dtpFechaIni = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.btnAceptar = New Azteca.Windows.Controls.CIButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.lblReporte = New System.Windows.Forms.Label()
        Me.picLogoEmpresa = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.picLogoEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ColorWithAlpha1.Parent = Nothing
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ColorWithAlpha2.Parent = Nothing
        '
        'lblFechaIni
        '
        Me.lblFechaIni.AutoSize = True
        Me.lblFechaIni.Location = New System.Drawing.Point(71, 96)
        Me.lblFechaIni.Name = "lblFechaIni"
        Me.lblFechaIni.Size = New System.Drawing.Size(70, 13)
        Me.lblFechaIni.TabIndex = 84
        Me.lblFechaIni.Text = "Fecha Inicial:"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaFin.Location = New System.Drawing.Point(147, 117)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(210, 20)
        Me.dtpFechaFin.TabIndex = 85
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(76, 117)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(65, 13)
        Me.CiLabel2.TabIndex = 86
        Me.CiLabel2.Text = "Fecha Final:"
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaIni.Location = New System.Drawing.Point(147, 91)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(211, 20)
        Me.dtpFechaIni.TabIndex = 83
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(443, 156)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 88
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(362, 156)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 87
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblEmpresa)
        Me.Panel1.Controls.Add(Me.lblReporte)
        Me.Panel1.Controls.Add(Me.picLogoEmpresa)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.Gray
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(539, 71)
        Me.Panel1.TabIndex = 98
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresa.Location = New System.Drawing.Point(13, 9)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(153, 16)
        Me.lblEmpresa.TabIndex = 2
        Me.lblEmpresa.Text = "Nombre de la Empresa"
        '
        'lblReporte
        '
        Me.lblReporte.AutoSize = True
        Me.lblReporte.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReporte.Location = New System.Drawing.Point(11, 37)
        Me.lblReporte.Name = "lblReporte"
        Me.lblReporte.Size = New System.Drawing.Size(229, 27)
        Me.lblReporte.TabIndex = 1
        Me.lblReporte.Text = "Nombre del Reporte"
        '
        'picLogoEmpresa
        '
        Me.picLogoEmpresa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picLogoEmpresa.Image = CType(resources.GetObject("picLogoEmpresa.Image"), System.Drawing.Image)
        Me.picLogoEmpresa.Location = New System.Drawing.Point(427, 5)
        Me.picLogoEmpresa.Name = "picLogoEmpresa"
        Me.picLogoEmpresa.Size = New System.Drawing.Size(97, 63)
        Me.picLogoEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogoEmpresa.TabIndex = 0
        Me.picLogoEmpresa.TabStop = False
        '
        'FacturacionInformesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 188)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblFechaIni)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.CiLabel2)
        Me.Controls.Add(Me.dtpFechaIni)
        Me.Name = "FacturacionInformesForm"
        Me.Text = "Informe de Facturación"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picLogoEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ColorWithAlpha1 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents lblFechaIni As Azteca.Windows.Controls.CILabel
    Friend WithEvents dtpFechaFin As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents dtpFechaIni As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnAceptar As Azteca.Windows.Controls.CIButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents lblReporte As System.Windows.Forms.Label
    Friend WithEvents picLogoEmpresa As System.Windows.Forms.PictureBox
End Class
