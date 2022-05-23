<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditServicioZonaForm
    Inherits Azteca.Windows.Forms.BaseForm

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
        Me.btnAceptar = New Azteca.Windows.Controls.CIButton()
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel5 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel6 = New Azteca.Windows.Controls.CILabel()
        Me.txtPrecio = New Azteca.Windows.Controls.CITextBox()
        Me.nudDiasEntrega = New Azteca.Windows.Controls.CINumericUpDown()
        Me.CiLabel7 = New Azteca.Windows.Controls.CILabel()
        Me.nudPorcRetencion1 = New Azteca.Windows.Controls.CINumericUpDown()
        Me.grpImpuestos = New Azteca.Windows.Controls.CIGroupBox()
        Me.CiLabel14 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel13 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel12 = New Azteca.Windows.Controls.CILabel()
        Me.cboImpuesto3 = New Azteca.Windows.Contabilidad.ImpuestosComboBox()
        Me.nudPorcRetencion3 = New Azteca.Windows.Controls.CINumericUpDown()
        Me.CiLabel10 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel11 = New Azteca.Windows.Controls.CILabel()
        Me.cboImpuesto2 = New Azteca.Windows.Contabilidad.ImpuestosComboBox()
        Me.nudPorcRetencion2 = New Azteca.Windows.Controls.CINumericUpDown()
        Me.CiLabel8 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel9 = New Azteca.Windows.Controls.CILabel()
        Me.cboImpuesto1 = New Azteca.Windows.Contabilidad.ImpuestosComboBox()
        Me.txtServicio = New Azteca.Windows.Ventas.ServicioSelector()
        Me.cboDivisa = New Azteca.Windows.Contabilidad.DivisasComboBox()
        Me.cboZona = New Azteca.Windows.Ventas.ZonasVentaComboBox()
        CType(Me.nudDiasEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPorcRetencion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpImpuestos.SuspendLayout()
        CType(Me.nudPorcRetencion3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPorcRetencion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Image = Global.Azteca.Windows.Ventas.My.Resources.Resources.button_ok
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(241, 264)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 11
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = Global.Azteca.Windows.Ventas.My.Resources.Resources.cancel
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(322, 264)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(20, 15)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(35, 13)
        Me.CiLabel1.TabIndex = 0
        Me.CiLabel1.Text = "Zona:"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(20, 43)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(48, 13)
        Me.CiLabel2.TabIndex = 2
        Me.CiLabel2.Text = "Servicio:"
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(195, 72)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(39, 13)
        Me.CiLabel3.TabIndex = 6
        Me.CiLabel3.Text = "Divisa:"
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.Location = New System.Drawing.Point(20, 71)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(40, 13)
        Me.CiLabel4.TabIndex = 4
        Me.CiLabel4.Text = "Precio:"
        '
        'CiLabel5
        '
        Me.CiLabel5.AutoSize = True
        Me.CiLabel5.Location = New System.Drawing.Point(17, 31)
        Me.CiLabel5.Name = "CiLabel5"
        Me.CiLabel5.Size = New System.Drawing.Size(62, 13)
        Me.CiLabel5.TabIndex = 0
        Me.CiLabel5.Text = "Impuesto 1:"
        '
        'CiLabel6
        '
        Me.CiLabel6.AutoSize = True
        Me.CiLabel6.Location = New System.Drawing.Point(20, 96)
        Me.CiLabel6.Name = "CiLabel6"
        Me.CiLabel6.Size = New System.Drawing.Size(71, 13)
        Me.CiLabel6.TabIndex = 8
        Me.CiLabel6.Text = "Dias Entrega:"
        '
        'txtPrecio
        '
        Me.txtPrecio.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtPrecio.Digits = True
        Me.txtPrecio.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtPrecio.Format = "C"
        Me.txtPrecio.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtPrecio.Location = New System.Drawing.Point(97, 68)
        Me.txtPrecio.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPrecio.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(92, 20)
        Me.txtPrecio.TabIndex = 5
        '
        'nudDiasEntrega
        '
        Me.nudDiasEntrega.HighlightColor = System.Drawing.SystemColors.Info
        Me.nudDiasEntrega.Location = New System.Drawing.Point(97, 94)
        Me.nudDiasEntrega.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.nudDiasEntrega.Name = "nudDiasEntrega"
        Me.nudDiasEntrega.Size = New System.Drawing.Size(92, 20)
        Me.nudDiasEntrega.TabIndex = 9
        '
        'CiLabel7
        '
        Me.CiLabel7.AutoSize = True
        Me.CiLabel7.Location = New System.Drawing.Point(201, 31)
        Me.CiLabel7.Name = "CiLabel7"
        Me.CiLabel7.Size = New System.Drawing.Size(59, 13)
        Me.CiLabel7.TabIndex = 6
        Me.CiLabel7.Text = "Retención:"
        '
        'nudPorcRetencion1
        '
        Me.nudPorcRetencion1.HighlightColor = System.Drawing.SystemColors.Info
        Me.nudPorcRetencion1.Location = New System.Drawing.Point(266, 31)
        Me.nudPorcRetencion1.Name = "nudPorcRetencion1"
        Me.nudPorcRetencion1.Size = New System.Drawing.Size(58, 20)
        Me.nudPorcRetencion1.TabIndex = 7
        '
        'grpImpuestos
        '
        Me.grpImpuestos.Controls.Add(Me.CiLabel14)
        Me.grpImpuestos.Controls.Add(Me.CiLabel13)
        Me.grpImpuestos.Controls.Add(Me.CiLabel12)
        Me.grpImpuestos.Controls.Add(Me.cboImpuesto3)
        Me.grpImpuestos.Controls.Add(Me.nudPorcRetencion3)
        Me.grpImpuestos.Controls.Add(Me.CiLabel10)
        Me.grpImpuestos.Controls.Add(Me.CiLabel11)
        Me.grpImpuestos.Controls.Add(Me.cboImpuesto2)
        Me.grpImpuestos.Controls.Add(Me.nudPorcRetencion2)
        Me.grpImpuestos.Controls.Add(Me.CiLabel8)
        Me.grpImpuestos.Controls.Add(Me.CiLabel9)
        Me.grpImpuestos.Controls.Add(Me.cboImpuesto1)
        Me.grpImpuestos.Controls.Add(Me.nudPorcRetencion1)
        Me.grpImpuestos.Controls.Add(Me.CiLabel5)
        Me.grpImpuestos.Controls.Add(Me.CiLabel7)
        Me.grpImpuestos.Location = New System.Drawing.Point(12, 129)
        Me.grpImpuestos.Name = "grpImpuestos"
        Me.grpImpuestos.Size = New System.Drawing.Size(383, 119)
        Me.grpImpuestos.TabIndex = 10
        Me.grpImpuestos.TabStop = False
        Me.grpImpuestos.Text = "Impuestos"
        '
        'CiLabel14
        '
        Me.CiLabel14.AutoSize = True
        Me.CiLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiLabel14.Location = New System.Drawing.Point(330, 87)
        Me.CiLabel14.Name = "CiLabel14"
        Me.CiLabel14.Size = New System.Drawing.Size(21, 16)
        Me.CiLabel14.TabIndex = 14
        Me.CiLabel14.Text = "%"
        '
        'CiLabel13
        '
        Me.CiLabel13.AutoSize = True
        Me.CiLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiLabel13.Location = New System.Drawing.Point(330, 60)
        Me.CiLabel13.Name = "CiLabel13"
        Me.CiLabel13.Size = New System.Drawing.Size(21, 16)
        Me.CiLabel13.TabIndex = 11
        Me.CiLabel13.Text = "%"
        '
        'CiLabel12
        '
        Me.CiLabel12.AutoSize = True
        Me.CiLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiLabel12.Location = New System.Drawing.Point(330, 33)
        Me.CiLabel12.Name = "CiLabel12"
        Me.CiLabel12.Size = New System.Drawing.Size(21, 16)
        Me.CiLabel12.TabIndex = 8
        Me.CiLabel12.Text = "%"
        '
        'cboImpuesto3
        '
        Me.cboImpuesto3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboImpuesto3.FormattingEnabled = True
        Me.cboImpuesto3.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboImpuesto3.ItemsTable = Nothing
        Me.cboImpuesto3.Location = New System.Drawing.Point(85, 82)
        Me.cboImpuesto3.Name = "cboImpuesto3"
        Me.cboImpuesto3.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboImpuesto3.Size = New System.Drawing.Size(110, 21)
        Me.cboImpuesto3.TabIndex = 5
        Me.cboImpuesto3.UIName = Nothing
        '
        'nudPorcRetencion3
        '
        Me.nudPorcRetencion3.HighlightColor = System.Drawing.SystemColors.Info
        Me.nudPorcRetencion3.Location = New System.Drawing.Point(266, 85)
        Me.nudPorcRetencion3.Name = "nudPorcRetencion3"
        Me.nudPorcRetencion3.Size = New System.Drawing.Size(58, 20)
        Me.nudPorcRetencion3.TabIndex = 13
        '
        'CiLabel10
        '
        Me.CiLabel10.AutoSize = True
        Me.CiLabel10.Location = New System.Drawing.Point(17, 85)
        Me.CiLabel10.Name = "CiLabel10"
        Me.CiLabel10.Size = New System.Drawing.Size(62, 13)
        Me.CiLabel10.TabIndex = 4
        Me.CiLabel10.Text = "Impuesto 3:"
        '
        'CiLabel11
        '
        Me.CiLabel11.AutoSize = True
        Me.CiLabel11.Location = New System.Drawing.Point(201, 85)
        Me.CiLabel11.Name = "CiLabel11"
        Me.CiLabel11.Size = New System.Drawing.Size(59, 13)
        Me.CiLabel11.TabIndex = 12
        Me.CiLabel11.Text = "Retención:"
        '
        'cboImpuesto2
        '
        Me.cboImpuesto2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboImpuesto2.FormattingEnabled = True
        Me.cboImpuesto2.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboImpuesto2.ItemsTable = Nothing
        Me.cboImpuesto2.Location = New System.Drawing.Point(85, 55)
        Me.cboImpuesto2.Name = "cboImpuesto2"
        Me.cboImpuesto2.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboImpuesto2.Size = New System.Drawing.Size(110, 21)
        Me.cboImpuesto2.TabIndex = 3
        Me.cboImpuesto2.UIName = Nothing
        '
        'nudPorcRetencion2
        '
        Me.nudPorcRetencion2.HighlightColor = System.Drawing.SystemColors.Info
        Me.nudPorcRetencion2.Location = New System.Drawing.Point(266, 58)
        Me.nudPorcRetencion2.Name = "nudPorcRetencion2"
        Me.nudPorcRetencion2.Size = New System.Drawing.Size(58, 20)
        Me.nudPorcRetencion2.TabIndex = 10
        '
        'CiLabel8
        '
        Me.CiLabel8.AutoSize = True
        Me.CiLabel8.Location = New System.Drawing.Point(17, 58)
        Me.CiLabel8.Name = "CiLabel8"
        Me.CiLabel8.Size = New System.Drawing.Size(59, 13)
        Me.CiLabel8.TabIndex = 2
        Me.CiLabel8.Text = "Impuesto2:"
        '
        'CiLabel9
        '
        Me.CiLabel9.AutoSize = True
        Me.CiLabel9.Location = New System.Drawing.Point(201, 58)
        Me.CiLabel9.Name = "CiLabel9"
        Me.CiLabel9.Size = New System.Drawing.Size(59, 13)
        Me.CiLabel9.TabIndex = 9
        Me.CiLabel9.Text = "Retención:"
        '
        'cboImpuesto1
        '
        Me.cboImpuesto1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboImpuesto1.FormattingEnabled = True
        Me.cboImpuesto1.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboImpuesto1.ItemsTable = Nothing
        Me.cboImpuesto1.Location = New System.Drawing.Point(85, 28)
        Me.cboImpuesto1.Name = "cboImpuesto1"
        Me.cboImpuesto1.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboImpuesto1.Size = New System.Drawing.Size(110, 21)
        Me.cboImpuesto1.TabIndex = 1
        Me.cboImpuesto1.UIName = Nothing
        '
        'txtServicio
        '
        Me.txtServicio.AnySite = False
        Me.txtServicio.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtServicio.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtServicio.EditorAssembly = "Azteca.VentasWin"
        Me.txtServicio.EditorClass = "Azteca.Windows.Ventas.ServiciosForm"
        Me.txtServicio.EditorTitle = "Editar datos de servicio..."
        Me.txtServicio.Key = 0
        Me.txtServicio.Linked = False
        Me.txtServicio.Location = New System.Drawing.Point(97, 39)
        Me.txtServicio.Name = "txtServicio"
        Me.txtServicio.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.txtServicio.Size = New System.Drawing.Size(298, 23)
        Me.txtServicio.TabIndex = 3
        '
        'cboDivisa
        '
        Me.cboDivisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDivisa.FormattingEnabled = True
        Me.cboDivisa.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboDivisa.ItemsTable = Nothing
        Me.cboDivisa.Location = New System.Drawing.Point(240, 69)
        Me.cboDivisa.Name = "cboDivisa"
        Me.cboDivisa.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboDivisa.Size = New System.Drawing.Size(155, 21)
        Me.cboDivisa.TabIndex = 7
        Me.cboDivisa.UIName = Nothing
        '
        'cboZona
        '
        Me.cboZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboZona.FormattingEnabled = True
        Me.cboZona.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboZona.ItemsTable = Nothing
        Me.cboZona.Location = New System.Drawing.Point(97, 12)
        Me.cboZona.Name = "cboZona"
        Me.cboZona.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboZona.Size = New System.Drawing.Size(298, 21)
        Me.cboZona.TabIndex = 1
        Me.cboZona.UIName = Nothing
        '
        'EditServicioZonaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 299)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpImpuestos)
        Me.Controls.Add(Me.nudDiasEntrega)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtServicio)
        Me.Controls.Add(Me.cboDivisa)
        Me.Controls.Add(Me.cboZona)
        Me.Controls.Add(Me.CiLabel6)
        Me.Controls.Add(Me.CiLabel4)
        Me.Controls.Add(Me.CiLabel3)
        Me.Controls.Add(Me.CiLabel2)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Name = "EditServicioZonaForm"
        Me.Text = "Editar información de zona del servicio"
        CType(Me.nudDiasEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPorcRetencion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpImpuestos.ResumeLayout(False)
        Me.grpImpuestos.PerformLayout()
        CType(Me.nudPorcRetencion3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPorcRetencion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAceptar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel5 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel6 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboZona As Azteca.Windows.Ventas.ZonasVentaComboBox
    Friend WithEvents cboDivisa As Azteca.Windows.Contabilidad.DivisasComboBox
    Friend WithEvents txtServicio As Azteca.Windows.Ventas.ServicioSelector
    Friend WithEvents txtPrecio As Azteca.Windows.Controls.CITextBox
    Friend WithEvents nudDiasEntrega As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents cboImpuesto1 As Azteca.Windows.Contabilidad.ImpuestosComboBox
    Friend WithEvents CiLabel7 As Azteca.Windows.Controls.CILabel
    Friend WithEvents nudPorcRetencion1 As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents grpImpuestos As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents CiLabel14 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel13 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel12 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboImpuesto3 As Azteca.Windows.Contabilidad.ImpuestosComboBox
    Friend WithEvents nudPorcRetencion3 As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents CiLabel10 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel11 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboImpuesto2 As Azteca.Windows.Contabilidad.ImpuestosComboBox
    Friend WithEvents nudPorcRetencion2 As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents CiLabel8 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel9 As Azteca.Windows.Controls.CILabel
End Class
