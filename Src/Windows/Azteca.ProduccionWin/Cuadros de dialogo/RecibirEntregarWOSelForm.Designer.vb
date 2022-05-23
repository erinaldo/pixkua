<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecibirEntregarWOSelForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecibirEntregarWOSelForm))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboTipoMovimiento = New System.Windows.Forms.ComboBox()
        Me.txtCantidad = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblOrdenTrabajo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.btnAceptar = New Azteca.Windows.Controls.CIButton()
        Me.cboEnsambles = New Azteca.Windows.Produccion.EnsamblesComboBox(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New Azteca.Windows.Controls.CITextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUnidadMedida = New Azteca.Windows.Controls.CITextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipo:"
        '
        'cboTipoMovimiento
        '
        Me.cboTipoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoMovimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoMovimiento.FormattingEnabled = True
        Me.cboTipoMovimiento.Items.AddRange(New Object() {"Recepcion", "Entrega"})
        Me.cboTipoMovimiento.Location = New System.Drawing.Point(19, 177)
        Me.cboTipoMovimiento.Name = "cboTipoMovimiento"
        Me.cboTipoMovimiento.Size = New System.Drawing.Size(199, 32)
        Me.cboTipoMovimiento.TabIndex = 3
        '
        'txtCantidad
        '
        Me.txtCantidad.Digits = True
        Me.txtCantidad.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCantidad.Location = New System.Drawing.Point(229, 180)
        Me.txtCantidad.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantidad.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(85, 29)
        Me.txtCantidad.TabIndex = 59
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiLabel1.Location = New System.Drawing.Point(226, 157)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(64, 17)
        Me.CiLabel1.TabIndex = 58
        Me.CiLabel1.Text = "Cantidad"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblOrdenTrabajo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(303, 76)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Orden de Trabajo"
        '
        'lblOrdenTrabajo
        '
        Me.lblOrdenTrabajo.AutoSize = True
        Me.lblOrdenTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrdenTrabajo.Location = New System.Drawing.Point(106, 32)
        Me.lblOrdenTrabajo.Name = "lblOrdenTrabajo"
        Me.lblOrdenTrabajo.Size = New System.Drawing.Size(101, 24)
        Me.lblOrdenTrabajo.TabIndex = 63
        Me.lblOrdenTrabajo.Text = "OT-00000"
        Me.lblOrdenTrabajo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 17)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Ensamble:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelar.Location = New System.Drawing.Point(201, 389)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(113, 41)
        Me.btnCancelar.TabIndex = 64
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAceptar.Location = New System.Drawing.Point(82, 389)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(113, 41)
        Me.btnAceptar.TabIndex = 63
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'cboEnsambles
        '
        Me.cboEnsambles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEnsambles.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEnsambles.FormattingEnabled = True
        Me.cboEnsambles.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboEnsambles.ItemsTable = Nothing
        Me.cboEnsambles.Location = New System.Drawing.Point(19, 112)
        Me.cboEnsambles.Name = "cboEnsambles"
        Me.cboEnsambles.Size = New System.Drawing.Size(295, 32)
        Me.cboEnsambles.TabIndex = 65
        Me.cboEnsambles.UIName = Nothing
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 277)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 17)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Observaciones:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtObservaciones.Location = New System.Drawing.Point(19, 297)
        Me.txtObservaciones.MaxLength = 128
        Me.txtObservaciones.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtObservaciones.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(295, 65)
        Me.txtObservaciones.TabIndex = 67
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 17)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "UM:"
        '
        'txtUnidadMedida
        '
        Me.txtUnidadMedida.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtUnidadMedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnidadMedida.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtUnidadMedida.Location = New System.Drawing.Point(55, 227)
        Me.txtUnidadMedida.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtUnidadMedida.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtUnidadMedida.Name = "txtUnidadMedida"
        Me.txtUnidadMedida.ReadOnly = True
        Me.txtUnidadMedida.Size = New System.Drawing.Size(259, 29)
        Me.txtUnidadMedida.TabIndex = 69
        '
        'RecibirEntregarWOSelForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 442)
        Me.Controls.Add(Me.txtUnidadMedida)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboEnsambles)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.cboTipoMovimiento)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.Name = "RecibirEntregarWOSelForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recibir - Entregar - OT"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboTipoMovimiento As System.Windows.Forms.ComboBox
    Friend WithEvents txtCantidad As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblOrdenTrabajo As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnAceptar As Azteca.Windows.Controls.CIButton
    Friend WithEvents cboEnsambles As Azteca.Windows.Produccion.EnsamblesComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUnidadMedida As Azteca.Windows.Controls.CITextBox
End Class
