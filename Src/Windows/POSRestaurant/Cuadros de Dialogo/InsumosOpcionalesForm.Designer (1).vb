<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsumosOpcionalesForm
    Inherits Azteca.Windows.Forms.BaseForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InsumosOpcionalesForm))
        Me.pnlInsumos = New Azteca.Windows.Controls.CIPanel()
        Me.bottonPrueba = New Azteca.Windows.MultiSeleccionButtonsControl()
        Me.btnAceptar = New Azteca.Windows.Controls.CIButton()
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.pnlInsumos.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlInsumos
        '
        Me.pnlInsumos.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnlInsumos.Controls.Add(Me.bottonPrueba)
        Me.pnlInsumos.GradientColorA = System.Drawing.SystemColors.ControlLight
        Me.pnlInsumos.GradientColorB = System.Drawing.SystemColors.ControlDark
        Me.pnlInsumos.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlInsumos.Location = New System.Drawing.Point(8, 8)
        Me.pnlInsumos.Name = "pnlInsumos"
        Me.pnlInsumos.Size = New System.Drawing.Size(384, 472)
        Me.pnlInsumos.TabIndex = 18
        Me.pnlInsumos.UseGradient = False
        '
        'bottonPrueba
        '
        Me.bottonPrueba.Descripcion = "Descripcion"
        Me.bottonPrueba.Key = 0
        Me.bottonPrueba.Location = New System.Drawing.Point(4, 4)
        Me.bottonPrueba.MostrarNumeric = False
        Me.bottonPrueba.Name = "bottonPrueba"
        Me.bottonPrueba.Seleccionado = False
        Me.bottonPrueba.Size = New System.Drawing.Size(372, 36)
        Me.bottonPrueba.TabIndex = 21
        Me.bottonPrueba.Valor = New Decimal(New Integer() {0, 0, 0, 0})
        Me.bottonPrueba.Visible = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.Transparent
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(413, 8)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(103, 63)
        Me.btnAceptar.TabIndex = 19
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(413, 77)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(103, 63)
        Me.btnCancelar.TabIndex = 20
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'InsumosOpcionalesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(537, 492)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.pnlInsumos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "InsumosOpcionalesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingredientes Opcionales"
        Me.pnlInsumos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlInsumos As Azteca.Windows.Controls.CIPanel
    Friend WithEvents btnAceptar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents bottonPrueba As Azteca.Windows.MultiSeleccionButtonsControl
End Class
