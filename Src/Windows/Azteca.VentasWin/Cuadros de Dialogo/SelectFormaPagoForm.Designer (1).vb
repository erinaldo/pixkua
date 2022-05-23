<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectFormaPagoForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectFormaPagoForm))
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.btnAceptar = New Azteca.Windows.Controls.CIButton()
        Me.rdbSingle = New Azteca.Windows.Controls.CIRadioButton()
        Me.rdbMultiple = New Azteca.Windows.Controls.CIRadioButton()
        Me.bsFormasPago = New System.Windows.Forms.BindingSource(Me.components)
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.txtTotal = New Azteca.Windows.Controls.CITextBox()
        Me.txtSaldo = New Azteca.Windows.Controls.CITextBox()
        Me.grdFormasPago = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.lblRecibo = New Azteca.Windows.Controls.CILabel()
        Me.txtRecibo = New Azteca.Windows.Controls.CITextBox()
        Me.txtCambio = New Azteca.Windows.Controls.CITextBox()
        Me.lblCambio = New Azteca.Windows.Controls.CILabel()
        Me.cboFormaPago = New Azteca.Windows.Ventas.FormasPagoComboBox()
        CType(Me.bsFormasPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdFormasPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = Global.Azteca.Windows.Ventas.My.Resources.Resources.cancel
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(283, 344)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Image = Global.Azteca.Windows.Ventas.My.Resources.Resources.button_ok
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(202, 344)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 8
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'rdbSingle
        '
        Me.rdbSingle.AutoSize = True
        Me.rdbSingle.Checked = True
        Me.rdbSingle.Location = New System.Drawing.Point(33, 107)
        Me.rdbSingle.Name = "rdbSingle"
        Me.rdbSingle.Size = New System.Drawing.Size(138, 17)
        Me.rdbSingle.TabIndex = 4
        Me.rdbSingle.TabStop = True
        Me.rdbSingle.Text = "Una sola forma de pago"
        Me.rdbSingle.UseVisualStyleBackColor = True
        '
        'rdbMultiple
        '
        Me.rdbMultiple.AutoSize = True
        Me.rdbMultiple.Location = New System.Drawing.Point(33, 163)
        Me.rdbMultiple.Name = "rdbMultiple"
        Me.rdbMultiple.Size = New System.Drawing.Size(142, 17)
        Me.rdbMultiple.TabIndex = 6
        Me.rdbMultiple.Text = "Multiples formas de pago"
        Me.rdbMultiple.UseVisualStyleBackColor = True
        '
        'bsFormasPago
        '
        Me.bsFormasPago.AllowNew = False
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(172, 12)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(74, 13)
        Me.CiLabel1.TabIndex = 0
        Me.CiLabel1.Text = "Total a Pagar:"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(209, 37)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(37, 13)
        Me.CiLabel2.TabIndex = 2
        Me.CiLabel2.Text = "Saldo:"
        '
        'txtTotal
        '
        Me.txtTotal.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtTotal.Digits = True
        Me.txtTotal.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtTotal.Format = "C"
        Me.txtTotal.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTotal.Location = New System.Drawing.Point(252, 9)
        Me.txtTotal.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotal.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(106, 20)
        Me.txtTotal.TabIndex = 1
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSaldo
        '
        Me.txtSaldo.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtSaldo.Digits = True
        Me.txtSaldo.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtSaldo.Format = "C"
        Me.txtSaldo.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtSaldo.Location = New System.Drawing.Point(252, 35)
        Me.txtSaldo.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSaldo.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.Size = New System.Drawing.Size(106, 20)
        Me.txtSaldo.TabIndex = 3
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grdFormasPago
        '
        Me.grdFormasPago.DataSource = Me.bsFormasPago
        Me.grdFormasPago.ExtendRightColumn = True
        Me.grdFormasPago.Images.Add(CType(resources.GetObject("grdFormasPago.Images"), System.Drawing.Image))
        Me.grdFormasPago.Location = New System.Drawing.Point(51, 186)
        Me.grdFormasPago.Name = "grdFormasPago"
        Me.grdFormasPago.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdFormasPago.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdFormasPago.PreviewInfo.ZoomFactor = 75.0R
        Me.grdFormasPago.PrintInfo.PageSettings = CType(resources.GetObject("grdFormasPago.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdFormasPago.Size = New System.Drawing.Size(307, 140)
        Me.grdFormasPago.TabIndex = 10
        Me.grdFormasPago.Text = "AzTrueDBGrid1"
        Me.grdFormasPago.PropBag = resources.GetString("grdFormasPago.PropBag")
        '
        'lblRecibo
        '
        Me.lblRecibo.AutoSize = True
        Me.lblRecibo.Location = New System.Drawing.Point(202, 62)
        Me.lblRecibo.Name = "lblRecibo"
        Me.lblRecibo.Size = New System.Drawing.Size(44, 13)
        Me.lblRecibo.TabIndex = 11
        Me.lblRecibo.Text = "Recibo:"
        Me.lblRecibo.Visible = False
        '
        'txtRecibo
        '
        Me.txtRecibo.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtRecibo.Digits = True
        Me.txtRecibo.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtRecibo.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtRecibo.Location = New System.Drawing.Point(252, 60)
        Me.txtRecibo.MaxLength = 10
        Me.txtRecibo.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRecibo.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRecibo.Name = "txtRecibo"
        Me.txtRecibo.Size = New System.Drawing.Size(106, 20)
        Me.txtRecibo.TabIndex = 12
        Me.txtRecibo.Visible = False
        '
        'txtCambio
        '
        Me.txtCambio.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCambio.Digits = True
        Me.txtCambio.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtCambio.Format = "C"
        Me.txtCambio.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCambio.Location = New System.Drawing.Point(253, 84)
        Me.txtCambio.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCambio.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCambio.Name = "txtCambio"
        Me.txtCambio.ReadOnly = True
        Me.txtCambio.Size = New System.Drawing.Size(106, 20)
        Me.txtCambio.TabIndex = 14
        Me.txtCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCambio.Visible = False
        '
        'lblCambio
        '
        Me.lblCambio.AutoSize = True
        Me.lblCambio.Location = New System.Drawing.Point(201, 87)
        Me.lblCambio.Name = "lblCambio"
        Me.lblCambio.Size = New System.Drawing.Size(45, 13)
        Me.lblCambio.TabIndex = 13
        Me.lblCambio.Text = "Cambio:"
        Me.lblCambio.Visible = False
        '
        'cboFormaPago
        '
        Me.cboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormaPago.FormattingEnabled = True
        Me.cboFormaPago.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboFormaPago.ItemsTable = Nothing
        Me.cboFormaPago.Location = New System.Drawing.Point(51, 130)
        Me.cboFormaPago.Name = "cboFormaPago"
        Me.cboFormaPago.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboFormaPago.Size = New System.Drawing.Size(307, 21)
        Me.cboFormaPago.TabIndex = 5
        Me.cboFormaPago.UIName = Nothing
        '
        'SelectFormaPagoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 379)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtCambio)
        Me.Controls.Add(Me.lblCambio)
        Me.Controls.Add(Me.txtRecibo)
        Me.Controls.Add(Me.lblRecibo)
        Me.Controls.Add(Me.grdFormasPago)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.CiLabel2)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.cboFormaPago)
        Me.Controls.Add(Me.rdbMultiple)
        Me.Controls.Add(Me.rdbSingle)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Name = "SelectFormaPagoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Seleccione la forma de pago"
        CType(Me.bsFormasPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdFormasPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnAceptar As Azteca.Windows.Controls.CIButton
    Friend WithEvents rdbSingle As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents rdbMultiple As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents cboFormaPago As Azteca.Windows.Ventas.FormasPagoComboBox
    Friend WithEvents bsFormasPago As System.Windows.Forms.BindingSource
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtTotal As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtSaldo As Azteca.Windows.Controls.CITextBox
    Friend WithEvents grdFormasPago As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents lblRecibo As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtRecibo As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtCambio As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblCambio As Azteca.Windows.Controls.CILabel
End Class
