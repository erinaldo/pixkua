<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextboxNumberTouch
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
        Me.cmdAccion = New Azteca.Windows.Controls.CIButton()
        Me.ColorWithAlpha1 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha2 = New Azteca.Windows.ColorWithAlpha()
        Me.txtCaptura = New Azteca.Windows.Controls.CITextBox()
        Me.SuspendLayout()
        '
        'cmdAccion
        '
        Me.cmdAccion.Location = New System.Drawing.Point(172, 3)
        Me.cmdAccion.Name = "cmdAccion"
        Me.cmdAccion.Size = New System.Drawing.Size(75, 23)
        Me.cmdAccion.TabIndex = 1
        Me.cmdAccion.Tag = "0"
        Me.cmdAccion.Text = "Editar"
        Me.cmdAccion.UseVisualStyleBackColor = True
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Olive
        Me.ColorWithAlpha1.Parent = Nothing
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorWithAlpha2.Parent = Nothing
        '
        'txtCaptura
        '
        Me.txtCaptura.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCaptura.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCaptura.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaptura.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCaptura.Location = New System.Drawing.Point(3, 3)
        Me.txtCaptura.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCaptura.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCaptura.Name = "txtCaptura"
        Me.txtCaptura.Size = New System.Drawing.Size(164, 23)
        Me.txtCaptura.TabIndex = 0
        Me.txtCaptura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextboxNumberTouch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.cmdAccion)
        Me.Controls.Add(Me.txtCaptura)
        Me.Name = "TextboxNumberTouch"
        Me.Size = New System.Drawing.Size(253, 29)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdAccion As Azteca.Windows.Controls.CIButton
    Friend WithEvents ColorWithAlpha1 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents txtCaptura As Azteca.Windows.Controls.CITextBox

End Class
