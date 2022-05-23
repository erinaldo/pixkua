<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActualizarTipoCambioForm
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
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.lblDivisa = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.txtCompra = New Azteca.Windows.Controls.CITextBox()
        Me.txtVenta = New Azteca.Windows.Controls.CITextBox()
        Me.btnActulizar = New Azteca.Windows.Controls.CIButton()
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.btnAceptar = New Azteca.Windows.Controls.CIButton()
        Me.SuspendLayout()
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(41, 23)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(39, 13)
        Me.CiLabel1.TabIndex = 0
        Me.CiLabel1.Text = "Divisa:"
        '
        'lblDivisa
        '
        Me.lblDivisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivisa.Location = New System.Drawing.Point(86, 19)
        Me.lblDivisa.Name = "lblDivisa"
        Me.lblDivisa.Size = New System.Drawing.Size(212, 21)
        Me.lblDivisa.TabIndex = 1
        Me.lblDivisa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(37, 46)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(46, 13)
        Me.CiLabel2.TabIndex = 2
        Me.CiLabel2.Text = "Compra:"
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(45, 72)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(38, 13)
        Me.CiLabel3.TabIndex = 3
        Me.CiLabel3.Text = "Venta:"
        '
        'txtCompra
        '
        Me.txtCompra.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCompra.Digits = True
        Me.txtCompra.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtCompra.Format = "C4"
        Me.txtCompra.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCompra.Location = New System.Drawing.Point(89, 43)
        Me.txtCompra.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCompra.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCompra.Name = "txtCompra"
        Me.txtCompra.Size = New System.Drawing.Size(82, 20)
        Me.txtCompra.TabIndex = 14
        Me.txtCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVenta
        '
        Me.txtVenta.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtVenta.Digits = True
        Me.txtVenta.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtVenta.Format = "C4"
        Me.txtVenta.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtVenta.Location = New System.Drawing.Point(89, 69)
        Me.txtVenta.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtVenta.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtVenta.Name = "txtVenta"
        Me.txtVenta.Size = New System.Drawing.Size(82, 20)
        Me.txtVenta.TabIndex = 15
        Me.txtVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnActulizar
        '
        Me.btnActulizar.Image = Global.Azteca.Windows.Contabilidad.My.Resources.Resources.world_upload_16
        Me.btnActulizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActulizar.Location = New System.Drawing.Point(89, 95)
        Me.btnActulizar.Name = "btnActulizar"
        Me.btnActulizar.Size = New System.Drawing.Size(142, 23)
        Me.btnActulizar.TabIndex = 16
        Me.btnActulizar.Text = "Consultar en BANXICO"
        Me.btnActulizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnActulizar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = Global.Azteca.Windows.Contabilidad.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(332, 171)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Image = Global.Azteca.Windows.Contabilidad.My.Resources.Resources.button_ok
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(251, 171)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 12
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'ActualizarTipoCambioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 206)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnActulizar)
        Me.Controls.Add(Me.txtVenta)
        Me.Controls.Add(Me.txtCompra)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.CiLabel3)
        Me.Controls.Add(Me.CiLabel2)
        Me.Controls.Add(Me.lblDivisa)
        Me.Controls.Add(Me.CiLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ActualizarTipoCambioForm"
        Me.Text = "Actualizar tipo de cambio de divisa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblDivisa As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnAceptar As Azteca.Windows.Controls.CIButton
    Friend WithEvents txtCompra As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtVenta As Azteca.Windows.Controls.CITextBox
    Friend WithEvents btnActulizar As Azteca.Windows.Controls.CIButton
End Class
