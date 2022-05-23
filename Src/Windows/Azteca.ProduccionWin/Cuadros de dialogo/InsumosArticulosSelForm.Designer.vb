<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsumosArticulosSelForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InsumosArticulosSelForm))
        Me.selArticuloStock = New Azteca.Windows.Inventario.ArticuloStockSelector()
        Me.lblArticulo = New Azteca.Windows.Controls.CILabel()
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.btnAceptar = New Azteca.Windows.Controls.CIButton()
        Me.SuspendLayout()
        '
        'selArticuloStock
        '
        Me.selArticuloStock.AnySite = False
        Me.selArticuloStock.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selArticuloStock.EditorAssembly = "Azteca.InventarioWin"
        Me.selArticuloStock.EditorClass = "Azteca.Windows.Inventario.ArticulosStockForm"
        Me.selArticuloStock.EditorTitle = "Editar Articulos de inventario..."
        Me.selArticuloStock.Key = 0
        Me.selArticuloStock.Linked = False
        Me.selArticuloStock.Location = New System.Drawing.Point(66, 32)
        Me.selArticuloStock.Name = "selArticuloStock"
        Me.selArticuloStock.ShowEditButton = True
        Me.selArticuloStock.Size = New System.Drawing.Size(339, 23)
        Me.selArticuloStock.TabIndex = 0
        '
        'lblArticulo
        '
        Me.lblArticulo.AutoSize = True
        Me.lblArticulo.Location = New System.Drawing.Point(19, 36)
        Me.lblArticulo.Name = "lblArticulo"
        Me.lblArticulo.Size = New System.Drawing.Size(42, 13)
        Me.lblArticulo.TabIndex = 1
        Me.lblArticulo.Text = "Articulo"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(330, 68)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(249, 68)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'InsumosArticulosSelForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 103)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblArticulo)
        Me.Controls.Add(Me.selArticuloStock)
        Me.Name = "InsumosArticulosSelForm"
        Me.Text = "agregar articulo de inventario como insumo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents selArticuloStock As Azteca.Windows.Inventario.ArticuloStockSelector
    Friend WithEvents lblArticulo As Azteca.Windows.Controls.CILabel
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnAceptar As Azteca.Windows.Controls.CIButton
End Class
