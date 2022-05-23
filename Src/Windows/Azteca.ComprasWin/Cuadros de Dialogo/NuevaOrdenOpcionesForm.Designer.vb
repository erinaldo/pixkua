<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevaOrdenOpcionesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevaOrdenOpcionesForm))
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdAceptar = New C1.Win.C1Command.C1Command()
        Me.cmdCancelar = New C1.Win.C1Command.C1Command()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdbOrdenSimple = New Azteca.Windows.Controls.CIRadioButton()
        Me.rdbOrdenMult = New Azteca.Windows.Controls.CIRadioButton()
        Me.rdbGenerador = New Azteca.Windows.Controls.CIRadioButton()
        Me.CiRadioButton1 = New Azteca.Windows.Controls.CIRadioButton()
        Me.tlbMenu = New C1.Win.C1Command.C1ToolBar()
        Me.btnAceptar = New C1.Win.C1Command.C1CommandLink()
        Me.btnCancelar = New C1.Win.C1Command.C1CommandLink()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdAceptar)
        Me.C1CommandHolder1.Commands.Add(Me.cmdCancelar)
        Me.C1CommandHolder1.Owner = Me
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Text = "Cancelar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 61)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(444, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "¿Que acción desea realizar?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rdbOrdenSimple
        '
        Me.rdbOrdenSimple.AutoSize = True
        Me.rdbOrdenSimple.Checked = True
        Me.rdbOrdenSimple.Location = New System.Drawing.Point(109, 65)
        Me.rdbOrdenSimple.Name = "rdbOrdenSimple"
        Me.rdbOrdenSimple.Size = New System.Drawing.Size(280, 17)
        Me.rdbOrdenSimple.TabIndex = 3
        Me.rdbOrdenSimple.TabStop = True
        Me.rdbOrdenSimple.Text = "Crear orden de un sólo departamento y/o presupuesto"
        Me.rdbOrdenSimple.UseVisualStyleBackColor = True
        '
        'rdbOrdenMult
        '
        Me.rdbOrdenMult.AutoSize = True
        Me.rdbOrdenMult.Enabled = False
        Me.rdbOrdenMult.Location = New System.Drawing.Point(109, 88)
        Me.rdbOrdenMult.Name = "rdbOrdenMult"
        Me.rdbOrdenMult.Size = New System.Drawing.Size(284, 17)
        Me.rdbOrdenMult.TabIndex = 4
        Me.rdbOrdenMult.Text = "Crear orden de varios departamentos y/o presupuestos"
        Me.rdbOrdenMult.UseVisualStyleBackColor = True
        '
        'rdbGenerador
        '
        Me.rdbGenerador.AutoSize = True
        Me.rdbGenerador.Location = New System.Drawing.Point(109, 111)
        Me.rdbGenerador.Name = "rdbGenerador"
        Me.rdbGenerador.Size = New System.Drawing.Size(299, 17)
        Me.rdbGenerador.TabIndex = 5
        Me.rdbGenerador.Text = "Utilizar el asistente para crear ordenes de las requisiciones"
        Me.rdbGenerador.UseVisualStyleBackColor = True
        '
        'CiRadioButton1
        '
        Me.CiRadioButton1.AutoSize = True
        Me.CiRadioButton1.Enabled = False
        Me.CiRadioButton1.Location = New System.Drawing.Point(109, 134)
        Me.CiRadioButton1.Name = "CiRadioButton1"
        Me.CiRadioButton1.Size = New System.Drawing.Size(362, 17)
        Me.CiRadioButton1.TabIndex = 7
        Me.CiRadioButton1.Text = "Utilizar el asistente para crear ordenes de artículos en punto de reorden"
        Me.CiRadioButton1.UseVisualStyleBackColor = True
        '
        'tlbMenu
        '
        Me.tlbMenu.AccessibleName = "Tool Bar"
        Me.tlbMenu.AutoSize = False
        Me.tlbMenu.CommandHolder = Me.C1CommandHolder1
        Me.tlbMenu.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.btnAceptar, Me.btnCancelar})
        Me.tlbMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlbMenu.MinButtonSize = 32
        Me.tlbMenu.Movable = False
        Me.tlbMenu.Name = "tlbMenu"
        Me.tlbMenu.Size = New System.Drawing.Size(611, 33)
        Me.tlbMenu.Text = "C1ToolBar1"
        Me.tlbMenu.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tlbMenu.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'btnAceptar
        '
        Me.btnAceptar.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnAceptar.Command = Me.cmdAceptar
        '
        'btnCancelar
        '
        Me.btnCancelar.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnCancelar.Command = Me.cmdCancelar
        Me.btnCancelar.SortOrder = 1
        '
        'NuevaOrdenOpcionesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 186)
        Me.ControlBox = False
        Me.Controls.Add(Me.CiRadioButton1)
        Me.Controls.Add(Me.rdbGenerador)
        Me.Controls.Add(Me.rdbOrdenMult)
        Me.Controls.Add(Me.rdbOrdenSimple)
        Me.Controls.Add(Me.tlbMenu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "NuevaOrdenOpcionesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nueva orden de compra"
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents cmdAceptar As C1.Win.C1Command.C1Command
    Friend WithEvents cmdCancelar As C1.Win.C1Command.C1Command
    Friend WithEvents rdbGenerador As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents rdbOrdenMult As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents rdbOrdenSimple As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CiRadioButton1 As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents tlbMenu As C1.Win.C1Command.C1ToolBar
    Friend WithEvents btnAceptar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents btnCancelar As C1.Win.C1Command.C1CommandLink
End Class
