<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MetodoPagoSELForm
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
        Me.btnAceptar = New Azteca.Windows.Controls.CIButton()
        Me.cboMetodoPago = New Azteca.Windows.Ventas.MetodoPagoComboBox()
        Me.txtCuentaPago = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel25 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel26 = New Azteca.Windows.Controls.CILabel()
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Image = Global.Azteca.Windows.Ventas.My.Resources.Resources.button_ok
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(248, 143)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(79, 23)
        Me.btnAceptar.TabIndex = 10
        Me.btnAceptar.Text = "Continuar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'cboMetodoPago
        '
        Me.cboMetodoPago.AddNoneItem = True
        Me.cboMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMetodoPago.FormattingEnabled = True
        Me.cboMetodoPago.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboMetodoPago.ItemsTable = Nothing
        Me.cboMetodoPago.Location = New System.Drawing.Point(105, 23)
        Me.cboMetodoPago.Name = "cboMetodoPago"
        Me.cboMetodoPago.NoneItemText = "[NO IDENTIFICADO]"
        Me.cboMetodoPago.RequiredField = True
        Me.cboMetodoPago.Size = New System.Drawing.Size(223, 21)
        Me.cboMetodoPago.TabIndex = 38
        Me.cboMetodoPago.UIName = "Método de Pago"
        '
        'txtCuentaPago
        '
        Me.txtCuentaPago.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCuentaPago.Location = New System.Drawing.Point(105, 50)
        Me.txtCuentaPago.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCuentaPago.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCuentaPago.Name = "txtCuentaPago"
        Me.txtCuentaPago.Size = New System.Drawing.Size(223, 20)
        Me.txtCuentaPago.TabIndex = 39
        '
        'CiLabel25
        '
        Me.CiLabel25.AutoSize = True
        Me.CiLabel25.Location = New System.Drawing.Point(12, 26)
        Me.CiLabel25.Name = "CiLabel25"
        Me.CiLabel25.Size = New System.Drawing.Size(74, 13)
        Me.CiLabel25.TabIndex = 40
        Me.CiLabel25.Text = "Método Pago:"
        '
        'CiLabel26
        '
        Me.CiLabel26.AutoSize = True
        Me.CiLabel26.Location = New System.Drawing.Point(12, 53)
        Me.CiLabel26.Name = "CiLabel26"
        Me.CiLabel26.Size = New System.Drawing.Size(87, 13)
        Me.CiLabel26.TabIndex = 41
        Me.CiLabel26.Text = "Cuenta de Pago:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = Global.Azteca.Windows.Ventas.My.Resources.Resources.cancel
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(333, 143)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'MetodoPagoSELForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 178)
        Me.ControlBox = False
        Me.Controls.Add(Me.cboMetodoPago)
        Me.Controls.Add(Me.txtCuentaPago)
        Me.Controls.Add(Me.CiLabel25)
        Me.Controls.Add(Me.CiLabel26)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Name = "MetodoPagoSELForm"
        Me.Text = "Especificar método y cuenta de pago"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAceptar As Azteca.Windows.Controls.CIButton
    Friend WithEvents cboMetodoPago As Azteca.Windows.Ventas.MetodoPagoComboBox
    Friend WithEvents txtCuentaPago As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel25 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel26 As Azteca.Windows.Controls.CILabel
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
End Class
