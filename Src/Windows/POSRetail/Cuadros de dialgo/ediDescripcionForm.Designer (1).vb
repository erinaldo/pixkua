<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ediDescripcionForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ediDescripcionForm))
        Me.lblEtiqueta = New Azteca.Windows.Controls.CILabel()
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.btnAceptar = New Azteca.Windows.Controls.CIButton()
        Me.pnlUsuario = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha2 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha3 = New Azteca.Windows.ColorWithAlpha()
        Me.txtDescripcion = New Azteca.Windows.Controls.CITextBox()
        Me.pnlUsuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEtiqueta
        '
        Me.lblEtiqueta.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblEtiqueta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEtiqueta.ForeColor = System.Drawing.Color.Olive
        Me.lblEtiqueta.Location = New System.Drawing.Point(0, 0)
        Me.lblEtiqueta.Name = "lblEtiqueta"
        Me.lblEtiqueta.Size = New System.Drawing.Size(658, 28)
        Me.lblEtiqueta.TabIndex = 32
        Me.lblEtiqueta.Text = "Editando la Descripción . . ."
        Me.lblEtiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancelar.FlatAppearance.BorderSize = 2
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(331, 121)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 31
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAceptar.FlatAppearance.BorderSize = 2
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(250, 121)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 30
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'pnlUsuario
        '
        Me.pnlUsuario.BackColor = System.Drawing.Color.Transparent
        Me.pnlUsuario.Border = False
        Me.pnlUsuario.BorderColor = System.Drawing.Color.Olive
        Me.pnlUsuario.Colors.Add(Me.ColorWithAlpha1)
        Me.pnlUsuario.Colors.Add(Me.ColorWithAlpha2)
        Me.pnlUsuario.Colors.Add(Me.ColorWithAlpha3)
        Me.pnlUsuario.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlUsuario.Controls.Add(Me.txtDescripcion)
        Me.pnlUsuario.CornerRadius = 30
        Me.pnlUsuario.Corners = CType((((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight) _
            Or Azteca.Windows.Corner.BottomLeft) _
            Or Azteca.Windows.Corner.BottomRight), Azteca.Windows.Corner)
        Me.pnlUsuario.Gradient = True
        Me.pnlUsuario.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlUsuario.GradientOffset = 1.0!
        Me.pnlUsuario.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlUsuario.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlUsuario.Grayscale = False
        Me.pnlUsuario.Image = Nothing
        Me.pnlUsuario.ImageAlpha = 75
        Me.pnlUsuario.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlUsuario.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlUsuario.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlUsuario.Location = New System.Drawing.Point(13, 36)
        Me.pnlUsuario.Name = "pnlUsuario"
        Me.pnlUsuario.Rounded = True
        Me.pnlUsuario.Size = New System.Drawing.Size(632, 76)
        Me.pnlUsuario.TabIndex = 29
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ColorWithAlpha1.Parent = Me.pnlUsuario
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorWithAlpha2.Parent = Me.pnlUsuario
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ColorWithAlpha3.Parent = Me.pnlUsuario
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtDescripcion.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtDescripcion.Location = New System.Drawing.Point(24, 25)
        Me.txtDescripcion.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDescripcion.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(586, 29)
        Me.txtDescripcion.TabIndex = 4
        '
        'ediDescripcionForm
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(658, 148)
        Me.Controls.Add(Me.lblEtiqueta)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.pnlUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "ediDescripcionForm"
        Me.pnlUsuario.ResumeLayout(False)
        Me.pnlUsuario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblEtiqueta As Azteca.Windows.Controls.CILabel
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnAceptar As Azteca.Windows.Controls.CIButton
    Friend WithEvents pnlUsuario As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents txtDescripcion As Azteca.Windows.Controls.CITextBox
    Friend WithEvents ColorWithAlpha1 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha3 As Azteca.Windows.ColorWithAlpha
End Class
