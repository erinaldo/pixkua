<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdenesTrabajoInsumosSelForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrdenesTrabajoInsumosSelForm))
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.btnAceptar = New Azteca.Windows.Controls.CIButton()
        Me.lblArticulo = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.txtCantDeseada = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.chkSurtir = New Azteca.Windows.Controls.CICheckBox()
        Me.lblTituloMerma = New Azteca.Windows.Controls.CILabel()
        Me.txtCosto = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.cboUnidadMedida = New Azteca.Windows.Inventario.UnidadesMedidaComboBox()
        Me.selArticuloStock = New Azteca.Windows.Inventario.ArticuloStockSelector()
        Me.txtMerma = New Azteca.Windows.Controls.CITextBox()
        Me.rdbCantidad = New System.Windows.Forms.RadioButton()
        Me.rdbPorcentaje = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(358, 151)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(277, 151)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 6
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lblArticulo
        '
        Me.lblArticulo.AutoSize = True
        Me.lblArticulo.Location = New System.Drawing.Point(47, 12)
        Me.lblArticulo.Name = "lblArticulo"
        Me.lblArticulo.Size = New System.Drawing.Size(42, 13)
        Me.lblArticulo.TabIndex = 10
        Me.lblArticulo.Text = "Articulo"
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(40, 44)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(49, 13)
        Me.CiLabel1.TabIndex = 13
        Me.CiLabel1.Text = "Cantidad"
        '
        'txtCantDeseada
        '
        Me.txtCantDeseada.Digits = True
        Me.txtCantDeseada.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCantDeseada.Location = New System.Drawing.Point(95, 41)
        Me.txtCantDeseada.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantDeseada.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantDeseada.Name = "txtCantDeseada"
        Me.txtCantDeseada.Size = New System.Drawing.Size(119, 20)
        Me.txtCantDeseada.TabIndex = 1
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(10, 102)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(79, 13)
        Me.CiLabel2.TabIndex = 60
        Me.CiLabel2.Text = "Unidad Medida"
        '
        'chkSurtir
        '
        Me.chkSurtir.AutoSize = True
        Me.chkSurtir.Location = New System.Drawing.Point(95, 126)
        Me.chkSurtir.Name = "chkSurtir"
        Me.chkSurtir.Size = New System.Drawing.Size(50, 17)
        Me.chkSurtir.TabIndex = 4
        Me.chkSurtir.Text = "Surtir"
        Me.chkSurtir.UseVisualStyleBackColor = True
        '
        'lblTituloMerma
        '
        Me.lblTituloMerma.AutoSize = True
        Me.lblTituloMerma.Location = New System.Drawing.Point(224, 44)
        Me.lblTituloMerma.Name = "lblTituloMerma"
        Me.lblTituloMerma.Size = New System.Drawing.Size(49, 13)
        Me.lblTituloMerma.TabIndex = 62
        Me.lblTituloMerma.Text = "Merma #"
        '
        'txtCosto
        '
        Me.txtCosto.Digits = True
        Me.txtCosto.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtCosto.Format = "C3"
        Me.txtCosto.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCosto.Location = New System.Drawing.Point(95, 69)
        Me.txtCosto.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCosto.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(119, 20)
        Me.txtCosto.TabIndex = 2
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(55, 73)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(34, 13)
        Me.CiLabel3.TabIndex = 65
        Me.CiLabel3.Text = "Costo"
        '
        'cboUnidadMedida
        '
        Me.cboUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnidadMedida.FormattingEnabled = True
        Me.cboUnidadMedida.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboUnidadMedida.ItemsTable = Nothing
        Me.cboUnidadMedida.Location = New System.Drawing.Point(95, 99)
        Me.cboUnidadMedida.Name = "cboUnidadMedida"
        Me.cboUnidadMedida.RequiredField = True
        Me.cboUnidadMedida.Size = New System.Drawing.Size(338, 21)
        Me.cboUnidadMedida.TabIndex = 5
        Me.cboUnidadMedida.UIName = "Unidad Medida"
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
        Me.selArticuloStock.Location = New System.Drawing.Point(95, 12)
        Me.selArticuloStock.Name = "selArticuloStock"
        Me.selArticuloStock.ShowEditButton = True
        Me.selArticuloStock.Size = New System.Drawing.Size(339, 23)
        Me.selArticuloStock.TabIndex = 0
        '
        'txtMerma
        '
        Me.txtMerma.Digits = True
        Me.txtMerma.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtMerma.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtMerma.Location = New System.Drawing.Point(274, 41)
        Me.txtMerma.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtMerma.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtMerma.Name = "txtMerma"
        Me.txtMerma.Size = New System.Drawing.Size(70, 20)
        Me.txtMerma.TabIndex = 66
        '
        'rdbCantidad
        '
        Me.rdbCantidad.AutoSize = True
        Me.rdbCantidad.Checked = True
        Me.rdbCantidad.Location = New System.Drawing.Point(357, 42)
        Me.rdbCantidad.Name = "rdbCantidad"
        Me.rdbCantidad.Size = New System.Drawing.Size(67, 17)
        Me.rdbCantidad.TabIndex = 67
        Me.rdbCantidad.TabStop = True
        Me.rdbCantidad.Text = "Cantidad"
        Me.rdbCantidad.UseVisualStyleBackColor = True
        '
        'rdbPorcentaje
        '
        Me.rdbPorcentaje.AutoSize = True
        Me.rdbPorcentaje.Location = New System.Drawing.Point(357, 70)
        Me.rdbPorcentaje.Name = "rdbPorcentaje"
        Me.rdbPorcentaje.Size = New System.Drawing.Size(76, 17)
        Me.rdbPorcentaje.TabIndex = 68
        Me.rdbPorcentaje.Text = "Porcentaje"
        Me.rdbPorcentaje.UseVisualStyleBackColor = True
        '
        'OrdenesTrabajoInsumosSelForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 186)
        Me.Controls.Add(Me.rdbPorcentaje)
        Me.Controls.Add(Me.rdbCantidad)
        Me.Controls.Add(Me.txtMerma)
        Me.Controls.Add(Me.txtCosto)
        Me.Controls.Add(Me.CiLabel3)
        Me.Controls.Add(Me.lblTituloMerma)
        Me.Controls.Add(Me.chkSurtir)
        Me.Controls.Add(Me.CiLabel2)
        Me.Controls.Add(Me.cboUnidadMedida)
        Me.Controls.Add(Me.txtCantDeseada)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblArticulo)
        Me.Controls.Add(Me.selArticuloStock)
        Me.Name = "OrdenesTrabajoInsumosSelForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar articulo como insumo a la orden de trabajo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnAceptar As Azteca.Windows.Controls.CIButton
    Friend WithEvents lblArticulo As Azteca.Windows.Controls.CILabel
    Friend WithEvents selArticuloStock As Azteca.Windows.Inventario.ArticuloStockSelector
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCantDeseada As Azteca.Windows.Controls.CITextBox
    Public WithEvents cboUnidadMedida As Azteca.Windows.Inventario.UnidadesMedidaComboBox
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents chkSurtir As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents lblTituloMerma As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCosto As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtMerma As Azteca.Windows.Controls.CITextBox
    Friend WithEvents rdbCantidad As System.Windows.Forms.RadioButton
    Friend WithEvents rdbPorcentaje As System.Windows.Forms.RadioButton
End Class
