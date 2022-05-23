<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ButtonTouch
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ColorWithAlpha1 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha2 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha3 = New Azteca.Windows.ColorWithAlpha()
        Me.pnl = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha5 = New Azteca.Windows.ColorWithAlpha()
        Me.clrAzul = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha8 = New Azteca.Windows.ColorWithAlpha()
        Me.btn = New Azteca.Windows.Controls.CIButton()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.RoyalBlue
        Me.ColorWithAlpha1.Parent = Nothing
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.White
        Me.ColorWithAlpha2.Parent = Nothing
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = System.Drawing.SystemColors.ActiveCaptionText
        Me.ColorWithAlpha3.Parent = Nothing
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.Transparent
        Me.pnl.Border = True
        Me.pnl.BorderColor = System.Drawing.Color.MediumBlue
        Me.pnl.Colors.Add(Me.ColorWithAlpha5)
        Me.pnl.Colors.Add(Me.clrAzul)
        Me.pnl.Colors.Add(Me.ColorWithAlpha8)
        Me.pnl.ContentPadding = New System.Windows.Forms.Padding(1)
        Me.pnl.Controls.Add(Me.btn)
        Me.pnl.CornerRadius = 20
        Me.pnl.Corners = CType((((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight) _
                    Or Azteca.Windows.Corner.BottomLeft) _
                    Or Azteca.Windows.Corner.BottomRight), Azteca.Windows.Corner)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Gradient = True
        Me.pnl.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnl.GradientOffset = 1.0!
        Me.pnl.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnl.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnl.Grayscale = False
        Me.pnl.Image = Nothing
        Me.pnl.ImageAlpha = 75
        Me.pnl.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnl.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnl.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Rounded = True
        Me.pnl.Size = New System.Drawing.Size(98, 81)
        Me.pnl.TabIndex = 0
        '
        'ColorWithAlpha5
        '
        Me.ColorWithAlpha5.Alpha = 127
        Me.ColorWithAlpha5.Color = System.Drawing.Color.White
        Me.ColorWithAlpha5.Parent = Me.pnl
        '
        'clrAzul
        '
        Me.clrAzul.Alpha = 127
        Me.clrAzul.Color = System.Drawing.Color.MediumBlue
        Me.clrAzul.Parent = Me.pnl
        '
        'ColorWithAlpha8
        '
        Me.ColorWithAlpha8.Alpha = 127
        Me.ColorWithAlpha8.Color = System.Drawing.Color.White
        Me.ColorWithAlpha8.Parent = Me.pnl
        '
        'btn
        '
        Me.btn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn.FlatAppearance.BorderSize = 0
        Me.btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn.Location = New System.Drawing.Point(4, 13)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(90, 57)
        Me.btn.TabIndex = 0
        Me.btn.Text = "CiButton1"
        Me.btn.UseVisualStyleBackColor = True
        '
        'ButtonTouch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.pnl)
        Me.Name = "ButtonTouch"
        Me.Size = New System.Drawing.Size(98, 81)
        Me.pnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ColorWithAlpha1 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha3 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents pnl As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha5 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents clrAzul As Azteca.Windows.ColorWithAlpha
    Friend WithEvents btn As Azteca.Windows.Controls.CIButton
    Friend WithEvents ColorWithAlpha8 As Azteca.Windows.ColorWithAlpha

End Class
