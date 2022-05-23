<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdenTrabajoServiciosForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrdenTrabajoServiciosForm))
        Me.txtCosto = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.txtCantDeseada = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.lblArticulo = New Azteca.Windows.Controls.CILabel()
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.btnAceptar = New Azteca.Windows.Controls.CIButton()
        Me.selServicio = New Azteca.Windows.Compras.ServicioSelector()
        Me.SuspendLayout()
        '
        'txtCosto
        '
        Me.txtCosto.Digits = True
        Me.txtCosto.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtCosto.Format = "C3"
        Me.txtCosto.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCosto.Location = New System.Drawing.Point(230, 45)
        Me.txtCosto.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCosto.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(112, 20)
        Me.txtCosto.TabIndex = 2
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(190, 49)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(34, 13)
        Me.CiLabel3.TabIndex = 73
        Me.CiLabel3.Text = "Costo"
        '
        'txtCantDeseada
        '
        Me.txtCantDeseada.Digits = True
        Me.txtCantDeseada.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCantDeseada.Location = New System.Drawing.Point(66, 45)
        Me.txtCantDeseada.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantDeseada.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantDeseada.Name = "txtCantDeseada"
        Me.txtCantDeseada.Size = New System.Drawing.Size(92, 20)
        Me.txtCantDeseada.TabIndex = 1
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(11, 48)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(49, 13)
        Me.CiLabel1.TabIndex = 72
        Me.CiLabel1.Text = "Cantidad"
        '
        'lblArticulo
        '
        Me.lblArticulo.AutoSize = True
        Me.lblArticulo.Location = New System.Drawing.Point(14, 16)
        Me.lblArticulo.Name = "lblArticulo"
        Me.lblArticulo.Size = New System.Drawing.Size(45, 13)
        Me.lblArticulo.TabIndex = 71
        Me.lblArticulo.Text = "Servicio"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(267, 87)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(186, 87)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'selServicio
        '
        Me.selServicio.AnySite = False
        Me.selServicio.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selServicio.EditorAssembly = "Azteca.ComprasWin"
        Me.selServicio.EditorClass = "Azteca.Windows.Compras.ServiciosForm"
        Me.selServicio.EditorTitle = "Editar servicios..."
        Me.selServicio.Key = 0
        Me.selServicio.Linked = False
        Me.selServicio.Location = New System.Drawing.Point(66, 12)
        Me.selServicio.Name = "selServicio"
        Me.selServicio.Size = New System.Drawing.Size(231, 23)
        Me.selServicio.TabIndex = 0
        '
        'OrdenTrabajoServiciosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 122)
        Me.Controls.Add(Me.selServicio)
        Me.Controls.Add(Me.txtCosto)
        Me.Controls.Add(Me.CiLabel3)
        Me.Controls.Add(Me.txtCantDeseada)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblArticulo)
        Me.Name = "OrdenTrabajoServiciosForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OrdenTrabajoServiciosForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCosto As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCantDeseada As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnAceptar As Azteca.Windows.Controls.CIButton
    Friend WithEvents lblArticulo As Azteca.Windows.Controls.CILabel
    Friend WithEvents selServicio As Azteca.Windows.Compras.ServicioSelector
End Class
