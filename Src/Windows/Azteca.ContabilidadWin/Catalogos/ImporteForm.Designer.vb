<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImporteForm
    Inherits Azteca.Windows.Forms.BusinessForms.CatalogForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.lblDescripcion = New Azteca.Windows.Controls.CILabel()
        Me.lblImporte = New Azteca.Windows.Controls.CILabel()
        Me.txtDescripcion = New Azteca.Windows.Controls.CITextBox()
        Me.txtImporte = New Azteca.Windows.Controls.CITextBox()
        Me.SuspendLayout()
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(59, 115)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcion.TabIndex = 18
        Me.lblDescripcion.Text = "Descripcion"
        '
        'lblImporte
        '
        Me.lblImporte.AutoSize = True
        Me.lblImporte.Location = New System.Drawing.Point(77, 140)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(45, 13)
        Me.lblImporte.TabIndex = 19
        Me.lblImporte.Text = "Importe "
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtDescripcion.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtDescripcion.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtDescripcion.Location = New System.Drawing.Point(123, 112)
        Me.txtDescripcion.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDescripcion.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(245, 20)
        Me.txtDescripcion.TabIndex = 20
        '
        'txtImporte
        '
        Me.txtImporte.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtImporte.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtImporte.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtImporte.Location = New System.Drawing.Point(123, 137)
        Me.txtImporte.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtImporte.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(167, 20)
        Me.txtImporte.TabIndex = 21
        '
        'ImporteForm
        '
        Me.AllowRecordNavigation = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 211)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.lblImporte)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Name = "ImporteForm"
        Me.Text = "ImporteForm"
        Me.Controls.SetChildIndex(Me.lblDescripcion, 0)
        Me.Controls.SetChildIndex(Me.lblImporte, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.txtImporte, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Facade = New ImporteFacade
        LicenseModule = Kernel.Licensing.LicenseModule.Accounting
    End Sub
    Friend WithEvents lblDescripcion As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblImporte As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtDescripcion As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtImporte As Azteca.Windows.Controls.CITextBox

End Class
