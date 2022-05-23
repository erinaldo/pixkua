<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductosEnsamblesSelForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductosEnsamblesSelForm))
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.btnAceptar = New Azteca.Windows.Controls.CIButton()
        Me.lblUnidad = New Azteca.Windows.Controls.CILabel()
        Me.lblCantidad = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.lblPorcMerma = New Azteca.Windows.Controls.CILabel()
        Me.lblProducto = New Azteca.Windows.Controls.CILabel()
        Me.chkOpcional = New Azteca.Windows.Controls.CICheckBox()
        Me.upDownPorcMerca = New Azteca.Windows.Controls.CINumericUpDown()
        Me.txtCantidad = New Azteca.Windows.Controls.CITextBox()
        Me.cboUnidadMedida = New Azteca.Windows.Inventario.UnidadesMedidaComboBox()
        Me.selProducto = New Azteca.Windows.Produccion.ProductoSelector()
        Me.chkOrdenSeparada = New Azteca.Windows.Controls.CICheckBox()
        CType(Me.upDownPorcMerca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(295, 195)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 50
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(214, 195)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 49
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lblUnidad
        '
        Me.lblUnidad.AutoSize = True
        Me.lblUnidad.Location = New System.Drawing.Point(53, 81)
        Me.lblUnidad.Name = "lblUnidad"
        Me.lblUnidad.Size = New System.Drawing.Size(41, 13)
        Me.lblUnidad.TabIndex = 55
        Me.lblUnidad.Text = "Unidad"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(47, 56)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(49, 13)
        Me.lblCantidad.TabIndex = 54
        Me.lblCantidad.Text = "Cantidad"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(25, 103)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(69, 13)
        Me.CiLabel2.TabIndex = 53
        Me.CiLabel2.Text = "Requisitar en"
        '
        'lblPorcMerma
        '
        Me.lblPorcMerma.AutoSize = True
        Me.lblPorcMerma.Location = New System.Drawing.Point(44, 127)
        Me.lblPorcMerma.Name = "lblPorcMerma"
        Me.lblPorcMerma.Size = New System.Drawing.Size(50, 13)
        Me.lblPorcMerma.TabIndex = 52
        Me.lblPorcMerma.Text = "% Merma"
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(44, 27)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(50, 13)
        Me.lblProducto.TabIndex = 51
        Me.lblProducto.Text = "Producto"
        '
        'chkOpcional
        '
        Me.chkOpcional.AutoSize = True
        Me.chkOpcional.Location = New System.Drawing.Point(102, 153)
        Me.chkOpcional.Name = "chkOpcional"
        Me.chkOpcional.Size = New System.Drawing.Size(68, 17)
        Me.chkOpcional.TabIndex = 48
        Me.chkOpcional.Text = "Opcional"
        Me.chkOpcional.UseVisualStyleBackColor = True
        '
        'upDownPorcMerca
        '
        Me.upDownPorcMerca.HighlightColor = System.Drawing.SystemColors.Info
        Me.upDownPorcMerca.Location = New System.Drawing.Point(102, 125)
        Me.upDownPorcMerca.Name = "upDownPorcMerca"
        Me.upDownPorcMerca.Size = New System.Drawing.Size(100, 20)
        Me.upDownPorcMerca.TabIndex = 47
        '
        'txtCantidad
        '
        Me.txtCantidad.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCantidad.Digits = True
        Me.txtCantidad.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtCantidad.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCantidad.Location = New System.Drawing.Point(102, 53)
        Me.txtCantidad.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantidad.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(68, 20)
        Me.txtCantidad.TabIndex = 45
        '
        'cboUnidadMedida
        '
        Me.cboUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnidadMedida.FormattingEnabled = True
        Me.cboUnidadMedida.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboUnidadMedida.ItemsTable = Nothing
        Me.cboUnidadMedida.Location = New System.Drawing.Point(102, 77)
        Me.cboUnidadMedida.Name = "cboUnidadMedida"
        Me.cboUnidadMedida.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboUnidadMedida.Size = New System.Drawing.Size(269, 21)
        Me.cboUnidadMedida.TabIndex = 46
        Me.cboUnidadMedida.UIName = Nothing
        '
        'selProducto
        '
        Me.selProducto.AnySite = False
        Me.selProducto.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selProducto.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.selProducto.EditorAssembly = "Azteca.ProduccionWin"
        Me.selProducto.EditorClass = "Azteca.Windows.Produccion.ProductosForm"
        Me.selProducto.EditorTitle = "Editar Productos..."
        Me.selProducto.Key = 0
        Me.selProducto.Linked = False
        Me.selProducto.Location = New System.Drawing.Point(102, 27)
        Me.selProducto.Name = "selProducto"
        Me.selProducto.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selProducto.Size = New System.Drawing.Size(231, 23)
        Me.selProducto.TabIndex = 56
        Me.selProducto.TextWidth = 68
        '
        'chkOrdenSeparada
        '
        Me.chkOrdenSeparada.AutoSize = True
        Me.chkOrdenSeparada.Location = New System.Drawing.Point(227, 153)
        Me.chkOrdenSeparada.Name = "chkOrdenSeparada"
        Me.chkOrdenSeparada.Size = New System.Drawing.Size(104, 17)
        Me.chkOrdenSeparada.TabIndex = 57
        Me.chkOrdenSeparada.Text = "Orden Separada"
        Me.chkOrdenSeparada.UseVisualStyleBackColor = True
        '
        'ProductosEnsamblesSelForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 230)
        Me.Controls.Add(Me.chkOrdenSeparada)
        Me.Controls.Add(Me.selProducto)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblUnidad)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.CiLabel2)
        Me.Controls.Add(Me.lblPorcMerma)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.chkOpcional)
        Me.Controls.Add(Me.upDownPorcMerca)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.cboUnidadMedida)
        Me.Name = "ProductosEnsamblesSelForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edición de Ensambles..."
        CType(Me.upDownPorcMerca,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnAceptar As Azteca.Windows.Controls.CIButton
    Friend WithEvents lblUnidad As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCantidad As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblPorcMerma As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblProducto As Azteca.Windows.Controls.CILabel
    Friend WithEvents chkOpcional As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents upDownPorcMerca As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents txtCantidad As Azteca.Windows.Controls.CITextBox
    Friend WithEvents cboUnidadMedida As Azteca.Windows.Inventario.UnidadesMedidaComboBox
    Friend WithEvents selProducto As Azteca.Windows.Produccion.ProductoSelector
    Friend WithEvents chkOrdenSeparada As Azteca.Windows.Controls.CICheckBox
End Class
