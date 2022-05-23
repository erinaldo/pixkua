<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class selClienteForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(selClienteForm))
        Me.ColorWithAlpha1 = New Azteca.Windows.ColorWithAlpha()
        Me.pnlUsuario = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha2 = New Azteca.Windows.ColorWithAlpha()
        Me.selCliente = New Azteca.Windows.Ventas.Retail.ClienteExpressSelector()
        Me.lblCliente = New Azteca.Windows.Controls.CILabel()
        Me.btnAceptar = New Azteca.Windows.Controls.CIButton()
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.pnlUsuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ColorWithAlpha1.Parent = Me.pnlUsuario
        '
        'pnlUsuario
        '
        Me.pnlUsuario.BackColor = System.Drawing.Color.Transparent
        Me.pnlUsuario.Border = False
        Me.pnlUsuario.BorderColor = System.Drawing.Color.Olive
        Me.pnlUsuario.Colors.Add(Me.ColorWithAlpha1)
        Me.pnlUsuario.Colors.Add(Me.ColorWithAlpha2)
        Me.pnlUsuario.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlUsuario.Controls.Add(Me.selCliente)
        Me.pnlUsuario.Controls.Add(Me.lblCliente)
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
        Me.pnlUsuario.Location = New System.Drawing.Point(6, 6)
        Me.pnlUsuario.Name = "pnlUsuario"
        Me.pnlUsuario.Rounded = True
        Me.pnlUsuario.Size = New System.Drawing.Size(341, 85)
        Me.pnlUsuario.TabIndex = 22
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorWithAlpha2.Parent = Me.pnlUsuario
        '
        'selCliente
        '
        Me.selCliente.AnySite = False
        Me.selCliente.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selCliente.EditorAssembly = "Azteca.VentasWin"
        Me.selCliente.EditorClass = "Azteca.Windows.Ventas.ClienteExpressForm"
        Me.selCliente.EditorTitle = "Editar datos de cliente..."
        Me.selCliente.Key = 0
        Me.selCliente.Linked = False
        Me.selCliente.Location = New System.Drawing.Point(23, 35)
        Me.selCliente.Name = "selCliente"
        Me.selCliente.ShowEditButton = True
        Me.selCliente.Size = New System.Drawing.Size(219, 23)
        Me.selCliente.TabIndex = 4
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.ForeColor = System.Drawing.Color.White
        Me.lblCliente.Location = New System.Drawing.Point(20, 16)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(56, 16)
        Me.lblCliente.TabIndex = 3
        Me.lblCliente.Text = "Cliente"
        '
        'btnAceptar
        '
        Me.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAceptar.FlatAppearance.BorderSize = 2
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(173, 97)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 23
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancelar.FlatAppearance.BorderSize = 2
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(254, 97)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 24
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'selClienteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(353, 126)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.pnlUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "selClienteForm"
        Me.Text = "Selección de cliente..."
        Me.pnlUsuario.ResumeLayout(False)
        Me.pnlUsuario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ColorWithAlpha1 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents pnlUsuario As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents selCliente As ClienteExpressSelector 'Azteca.Windows.Ventas.ClienteSelector
    Friend WithEvents lblCliente As Azteca.Windows.Controls.CILabel
    Friend WithEvents btnAceptar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton

End Class
