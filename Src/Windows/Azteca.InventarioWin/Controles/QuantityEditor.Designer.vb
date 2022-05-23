<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuantityEditor
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.txtCantidad = New Azteca.Windows.Controls.CITextBox()
        Me.nudUnidades = New Azteca.Windows.Controls.CINumericUpDown()
        Me.lblUnidad = New Azteca.Windows.Controls.CILabel()
        CType(Me.nudUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCantidad
        '
        Me.txtCantidad.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCantidad.Digits = True
        Me.txtCantidad.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCantidad.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCantidad.Location = New System.Drawing.Point(0, 0)
        Me.txtCantidad.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantidad.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(50, 20)
        Me.txtCantidad.TabIndex = 0
        '
        'nudUnidades
        '
        Me.nudUnidades.HighlightColor = System.Drawing.SystemColors.Info
        Me.nudUnidades.Location = New System.Drawing.Point(51, 0)
        Me.nudUnidades.Name = "nudUnidades"
        Me.nudUnidades.Size = New System.Drawing.Size(50, 20)
        Me.nudUnidades.TabIndex = 1
        '
        'lblUnidad
        '
        Me.lblUnidad.BackColor = System.Drawing.SystemColors.Info
        Me.lblUnidad.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblUnidad.Location = New System.Drawing.Point(102, 0)
        Me.lblUnidad.Name = "lblUnidad"
        Me.lblUnidad.Size = New System.Drawing.Size(30, 20)
        Me.lblUnidad.TabIndex = 2
        Me.lblUnidad.Text = "[]"
        Me.lblUnidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'QuantityEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblUnidad)
        Me.Controls.Add(Me.nudUnidades)
        Me.Controls.Add(Me.txtCantidad)
        Me.Name = "QuantityEditor"
        Me.Size = New System.Drawing.Size(133, 20)
        CType(Me.nudUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCantidad As Azteca.Windows.Controls.CITextBox
    Friend WithEvents nudUnidades As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents lblUnidad As Azteca.Windows.Controls.CILabel

End Class
