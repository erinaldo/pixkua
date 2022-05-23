<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MultiSeleccionButtonsControl
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
        Me.btnOpcion = New Azteca.Windows.Controls.CIButton()
        Me.AzNumericEdit1 = New Azteca.Windows.Controls.AZNumericEdit()
        Me.lblDescripcion = New Azteca.Windows.Controls.CILabel()
        CType(Me.AzNumericEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOpcion
        '
        Me.btnOpcion.Location = New System.Drawing.Point(0, 0)
        Me.btnOpcion.Name = "btnOpcion"
        Me.btnOpcion.Size = New System.Drawing.Size(47, 36)
        Me.btnOpcion.TabIndex = 17
        Me.btnOpcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOpcion.UseVisualStyleBackColor = False
        '
        'AzNumericEdit1
        '
        Me.AzNumericEdit1.AutoClear = False
        Me.AzNumericEdit1.AutoLock = False
        Me.AzNumericEdit1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.AzNumericEdit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.AzNumericEdit1.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AzNumericEdit1.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.AzNumericEdit1.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.AzNumericEdit1.EnterTab = False
        Me.AzNumericEdit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AzNumericEdit1.Location = New System.Drawing.Point(169, 3)
        Me.AzNumericEdit1.Name = "AzNumericEdit1"
        Me.AzNumericEdit1.Size = New System.Drawing.Size(200, 29)
        Me.AzNumericEdit1.TabIndex = 18
        Me.AzNumericEdit1.Tag = Nothing
        Me.AzNumericEdit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.AzNumericEdit1.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.AzNumericEdit1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.AzNumericEdit1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'lblDescripcion
        '
        Me.lblDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.lblDescripcion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblDescripcion.Location = New System.Drawing.Point(52, 3)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(113, 29)
        Me.lblDescripcion.TabIndex = 19
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MultiSeleccionButtonsControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.AzNumericEdit1)
        Me.Controls.Add(Me.btnOpcion)
        Me.Name = "MultiSeleccionButtonsControl"
        Me.Size = New System.Drawing.Size(372, 36)
        CType(Me.AzNumericEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOpcion As Azteca.Windows.Controls.CIButton
    Friend WithEvents AzNumericEdit1 As Azteca.Windows.Controls.AZNumericEdit
    Friend WithEvents lblDescripcion As Azteca.Windows.Controls.CILabel

End Class
