<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductosInsumosSelForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductosInsumosSelForm))
        Me.cboUnidadMedida = New Azteca.Windows.Inventario.UnidadesMedidaComboBox()
        Me.txtCantidad = New Azteca.Windows.Controls.CITextBox()
        Me.upDownPorcMerca = New Azteca.Windows.Controls.CINumericUpDown()
        Me.chkOpcional = New Azteca.Windows.Controls.CICheckBox()
        Me.lblInsumo = New Azteca.Windows.Controls.CILabel()
        Me.lblPorcMerma = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.lblCantidad = New Azteca.Windows.Controls.CILabel()
        Me.lblUnidad = New Azteca.Windows.Controls.CILabel()
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.btnAceptar = New Azteca.Windows.Controls.CIButton()
        Me.selInsumos = New Azteca.Windows.Produccion.InsumoSelector()
        CType(Me.upDownPorcMerca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboUnidadMedida
        '
        Me.cboUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnidadMedida.FormattingEnabled = True
        Me.cboUnidadMedida.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboUnidadMedida.ItemsTable = Nothing
        Me.cboUnidadMedida.Location = New System.Drawing.Point(80, 67)
        Me.cboUnidadMedida.Name = "cboUnidadMedida"
        Me.cboUnidadMedida.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboUnidadMedida.Size = New System.Drawing.Size(269, 21)
        Me.cboUnidadMedida.TabIndex = 2
        Me.cboUnidadMedida.UIName = Nothing
        '
        'txtCantidad
        '
        Me.txtCantidad.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCantidad.Digits = True
        Me.txtCantidad.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtCantidad.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCantidad.Location = New System.Drawing.Point(80, 43)
        Me.txtCantidad.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantidad.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(68, 20)
        Me.txtCantidad.TabIndex = 1
        '
        'upDownPorcMerca
        '
        Me.upDownPorcMerca.HighlightColor = System.Drawing.SystemColors.Info
        Me.upDownPorcMerca.Location = New System.Drawing.Point(80, 115)
        Me.upDownPorcMerca.Name = "upDownPorcMerca"
        Me.upDownPorcMerca.Size = New System.Drawing.Size(100, 20)
        Me.upDownPorcMerca.TabIndex = 3
        '
        'chkOpcional
        '
        Me.chkOpcional.AutoSize = True
        Me.chkOpcional.Location = New System.Drawing.Point(80, 143)
        Me.chkOpcional.Name = "chkOpcional"
        Me.chkOpcional.Size = New System.Drawing.Size(68, 17)
        Me.chkOpcional.TabIndex = 4
        Me.chkOpcional.Text = "Opcional"
        Me.chkOpcional.UseVisualStyleBackColor = True
        '
        'lblInsumo
        '
        Me.lblInsumo.AutoSize = True
        Me.lblInsumo.Location = New System.Drawing.Point(33, 22)
        Me.lblInsumo.Name = "lblInsumo"
        Me.lblInsumo.Size = New System.Drawing.Size(41, 13)
        Me.lblInsumo.TabIndex = 39
        Me.lblInsumo.Text = "Insumo"
        '
        'lblPorcMerma
        '
        Me.lblPorcMerma.AutoSize = True
        Me.lblPorcMerma.Location = New System.Drawing.Point(24, 117)
        Me.lblPorcMerma.Name = "lblPorcMerma"
        Me.lblPorcMerma.Size = New System.Drawing.Size(50, 13)
        Me.lblPorcMerma.TabIndex = 40
        Me.lblPorcMerma.Text = "% Merma"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(7, 96)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(69, 13)
        Me.CiLabel2.TabIndex = 41
        Me.CiLabel2.Text = "Requisitar en"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(25, 46)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(49, 13)
        Me.lblCantidad.TabIndex = 42
        Me.lblCantidad.Text = "Cantidad"
        '
        'lblUnidad
        '
        Me.lblUnidad.AutoSize = True
        Me.lblUnidad.Location = New System.Drawing.Point(31, 71)
        Me.lblUnidad.Name = "lblUnidad"
        Me.lblUnidad.Size = New System.Drawing.Size(41, 13)
        Me.lblUnidad.TabIndex = 43
        Me.lblUnidad.Text = "Unidad"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(286, 169)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(205, 169)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'selInsumos
        '
        Me.selInsumos.AnySite = False
        Me.selInsumos.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selInsumos.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.selInsumos.EditorAssembly = "Azteca.ProduccionWin"
        Me.selInsumos.EditorClass = "Azteca.Windows.Produccion.InsumosForm"
        Me.selInsumos.EditorTitle = "Editar insumos..."
        Me.selInsumos.Key = 0
        Me.selInsumos.Linked = False
        Me.selInsumos.Location = New System.Drawing.Point(80, 18)
        Me.selInsumos.Name = "selInsumos"
        Me.selInsumos.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selInsumos.ShowEditButton = True
        Me.selInsumos.Size = New System.Drawing.Size(269, 23)
        Me.selInsumos.TabIndex = 0
        '
        'ProductosInsumosSelForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 203)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblUnidad)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.CiLabel2)
        Me.Controls.Add(Me.lblPorcMerma)
        Me.Controls.Add(Me.lblInsumo)
        Me.Controls.Add(Me.chkOpcional)
        Me.Controls.Add(Me.upDownPorcMerca)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.cboUnidadMedida)
        Me.Controls.Add(Me.selInsumos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProductosInsumosSelForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "edicion de insumos..."
        CType(Me.upDownPorcMerca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents selInsumos As Azteca.Windows.Produccion.InsumoSelector
    Friend WithEvents cboUnidadMedida As Azteca.Windows.Inventario.UnidadesMedidaComboBox
    Friend WithEvents txtCantidad As Azteca.Windows.Controls.CITextBox
    Friend WithEvents upDownPorcMerca As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents chkOpcional As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents lblInsumo As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblPorcMerma As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCantidad As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblUnidad As Azteca.Windows.Controls.CILabel
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnAceptar As Azteca.Windows.Controls.CIButton
End Class
