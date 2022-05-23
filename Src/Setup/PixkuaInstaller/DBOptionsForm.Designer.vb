<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DBOptionsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DBOptionsForm))
        Me.picBanner = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.picCreate = New System.Windows.Forms.PictureBox()
        Me.picConnect = New System.Windows.Forms.PictureBox()
        Me.rdbConnect = New System.Windows.Forms.RadioButton()
        Me.rdbCreate = New System.Windows.Forms.RadioButton()
        Me.rdbContinuar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCreate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picConnect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBanner
        '
        Me.picBanner.Image = Global.Azteca.Windows.Installer.My.Resources.Resources.SetupBanner
        Me.picBanner.Location = New System.Drawing.Point(1, 2)
        Me.picBanner.Name = "picBanner"
        Me.picBanner.Size = New System.Drawing.Size(499, 73)
        Me.picBanner.TabIndex = 8
        Me.picBanner.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(406, 47)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Seleccione una opción"
        '
        'picCreate
        '
        Me.picCreate.Image = CType(resources.GetObject("picCreate.Image"), System.Drawing.Image)
        Me.picCreate.Location = New System.Drawing.Point(18, 203)
        Me.picCreate.Name = "picCreate"
        Me.picCreate.Size = New System.Drawing.Size(64, 64)
        Me.picCreate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picCreate.TabIndex = 10
        Me.picCreate.TabStop = False
        '
        'picConnect
        '
        Me.picConnect.Image = CType(resources.GetObject("picConnect.Image"), System.Drawing.Image)
        Me.picConnect.Location = New System.Drawing.Point(18, 95)
        Me.picConnect.Name = "picConnect"
        Me.picConnect.Size = New System.Drawing.Size(64, 64)
        Me.picConnect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picConnect.TabIndex = 11
        Me.picConnect.TabStop = False
        '
        'rdbConnect
        '
        Me.rdbConnect.Checked = True
        Me.rdbConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbConnect.Location = New System.Drawing.Point(88, 95)
        Me.rdbConnect.Name = "rdbConnect"
        Me.rdbConnect.Size = New System.Drawing.Size(353, 64)
        Me.rdbConnect.TabIndex = 12
        Me.rdbConnect.TabStop = True
        Me.rdbConnect.Text = "Conectar a una base de datos existente o un servidor de aplicaciones"
        Me.rdbConnect.UseVisualStyleBackColor = True
        '
        'rdbCreate
        '
        Me.rdbCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbCreate.Location = New System.Drawing.Point(88, 203)
        Me.rdbCreate.Name = "rdbCreate"
        Me.rdbCreate.Size = New System.Drawing.Size(353, 64)
        Me.rdbCreate.TabIndex = 13
        Me.rdbCreate.Text = "Crear una nueva base de datos en blanco"
        Me.rdbCreate.UseVisualStyleBackColor = True
        '
        'rdbContinuar
        '
        Me.rdbContinuar.Location = New System.Drawing.Point(230, 305)
        Me.rdbContinuar.Name = "rdbContinuar"
        Me.rdbContinuar.Size = New System.Drawing.Size(75, 23)
        Me.rdbContinuar.TabIndex = 14
        Me.rdbContinuar.Text = "Continuar >"
        Me.rdbContinuar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(311, 305)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(130, 23)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "Configurar después"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'DBOptionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 340)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.rdbContinuar)
        Me.Controls.Add(Me.rdbCreate)
        Me.Controls.Add(Me.rdbConnect)
        Me.Controls.Add(Me.picConnect)
        Me.Controls.Add(Me.picCreate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.picBanner)
        Me.Name = "DBOptionsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Opciones de acceso a datos"
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCreate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picConnect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picBanner As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents picCreate As System.Windows.Forms.PictureBox
    Friend WithEvents picConnect As System.Windows.Forms.PictureBox
    Friend WithEvents rdbConnect As System.Windows.Forms.RadioButton
    Friend WithEvents rdbCreate As System.Windows.Forms.RadioButton
    Friend WithEvents rdbContinuar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
