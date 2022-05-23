<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BeneficiariosForm
    Inherits Azteca.Windows.Forms.BusinessForms.CatalogForm

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
        Me.lblCuenta = New Azteca.Windows.Controls.CILabel()
        Me.selCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.txtRazonSocial = New Azteca.Windows.Controls.CITextBox()
        Me.lblNombre = New Azteca.Windows.Controls.CILabel()
        Me.lblBanco = New Azteca.Windows.Controls.CILabel()
        Me.txtCLABE = New Azteca.Windows.Controls.CITextBox()
        Me.lblCLABE = New Azteca.Windows.Controls.CILabel()
        Me.chkLeyenda = New Azteca.Windows.Controls.CICheckBox()
        Me.cboBanco = New Azteca.Windows.Tesoreria.BancosComboBox()
        Me.upDownDiasCredito = New Azteca.Windows.Controls.CINumericUpDown()
        Me.lblDiasCredito = New Azteca.Windows.Controls.CILabel()
        CType(Me.upDownDiasCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Location = New System.Drawing.Point(17, 191)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(44, 13)
        Me.lblCuenta.TabIndex = 42
        Me.lblCuenta.Text = "Cuenta:"
        '
        'selCuenta
        '
        Me.selCuenta.AnySite = False
        Me.selCuenta.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selCuenta.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.selCuenta.EditorAssembly = "Azteca.ContabilidadWin"
        Me.selCuenta.EditorClass = "Azteca.Windows.Contabilidad.CuentaForm"
        Me.selCuenta.EditorTitle = "Editar Cuenta..."
        Me.selCuenta.Key = 0
        Me.selCuenta.Linked = False
        Me.selCuenta.Location = New System.Drawing.Point(96, 187)
        Me.selCuenta.Name = "selCuenta"
        Me.selCuenta.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selCuenta.Size = New System.Drawing.Size(385, 23)
        Me.selCuenta.TabIndex = 41
        Me.selCuenta.TextWidth = 100
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.BackColor = System.Drawing.SystemColors.Window
        Me.txtRazonSocial.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtRazonSocial.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtRazonSocial.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtRazonSocial.Location = New System.Drawing.Point(96, 109)
        Me.txtRazonSocial.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRazonSocial.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.RequiredField = True
        Me.txtRazonSocial.Size = New System.Drawing.Size(385, 20)
        Me.txtRazonSocial.TabIndex = 40
        Me.txtRazonSocial.UIName = "Nombre"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(17, 112)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(73, 13)
        Me.lblNombre.TabIndex = 39
        Me.lblNombre.Text = "Razon Social:"
        '
        'lblBanco
        '
        Me.lblBanco.AutoSize = True
        Me.lblBanco.Location = New System.Drawing.Point(17, 138)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(41, 13)
        Me.lblBanco.TabIndex = 45
        Me.lblBanco.Text = "Banco:"
        '
        'txtCLABE
        '
        Me.txtCLABE.BackColor = System.Drawing.SystemColors.Window
        Me.txtCLABE.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCLABE.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCLABE.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCLABE.Location = New System.Drawing.Point(359, 135)
        Me.txtCLABE.MaxLength = 18
        Me.txtCLABE.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCLABE.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCLABE.Name = "txtCLABE"
        Me.txtCLABE.Size = New System.Drawing.Size(122, 20)
        Me.txtCLABE.TabIndex = 47
        '
        'lblCLABE
        '
        Me.lblCLABE.AutoSize = True
        Me.lblCLABE.Location = New System.Drawing.Point(309, 140)
        Me.lblCLABE.Name = "lblCLABE"
        Me.lblCLABE.Size = New System.Drawing.Size(44, 13)
        Me.lblCLABE.TabIndex = 46
        Me.lblCLABE.Text = "CLABE:"
        '
        'chkLeyenda
        '
        Me.chkLeyenda.AutoClear = False
        Me.chkLeyenda.AutoSize = True
        Me.chkLeyenda.Checked = True
        Me.chkLeyenda.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLeyenda.Location = New System.Drawing.Point(97, 216)
        Me.chkLeyenda.Name = "chkLeyenda"
        Me.chkLeyenda.Size = New System.Drawing.Size(355, 17)
        Me.chkLeyenda.TabIndex = 48
        Me.chkLeyenda.Text = "Imprimir leyenda de ""Abono en cuenta de beneficiario"" a sus cheques"
        Me.chkLeyenda.UseVisualStyleBackColor = True
        '
        'cboBanco
        '
        Me.cboBanco.AddNoneItem = True
        Me.cboBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBanco.FormattingEnabled = True
        Me.cboBanco.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboBanco.ItemsTable = Nothing
        Me.cboBanco.Location = New System.Drawing.Point(96, 135)
        Me.cboBanco.Name = "cboBanco"
        Me.cboBanco.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboBanco.Size = New System.Drawing.Size(207, 21)
        Me.cboBanco.TabIndex = 44
        Me.cboBanco.UIName = Nothing
        '
        'upDownDiasCredito
        '
        Me.upDownDiasCredito.Enabled = False
        Me.upDownDiasCredito.HighlightColor = System.Drawing.SystemColors.Info
        Me.upDownDiasCredito.Location = New System.Drawing.Point(97, 163)
        Me.upDownDiasCredito.Maximum = New Decimal(New Integer() {365, 0, 0, 0})
        Me.upDownDiasCredito.Name = "upDownDiasCredito"
        Me.upDownDiasCredito.Size = New System.Drawing.Size(52, 20)
        Me.upDownDiasCredito.TabIndex = 79
        Me.upDownDiasCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDiasCredito
        '
        Me.lblDiasCredito.AutoSize = True
        Me.lblDiasCredito.Location = New System.Drawing.Point(17, 164)
        Me.lblDiasCredito.Name = "lblDiasCredito"
        Me.lblDiasCredito.Size = New System.Drawing.Size(67, 13)
        Me.lblDiasCredito.TabIndex = 80
        Me.lblDiasCredito.Text = "Dias Credito:"
        '
        'BeneficiariosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 303)
        Me.Controls.Add(Me.lblDiasCredito)
        Me.Controls.Add(Me.upDownDiasCredito)
        Me.Controls.Add(Me.chkLeyenda)
        Me.Controls.Add(Me.txtCLABE)
        Me.Controls.Add(Me.lblCLABE)
        Me.Controls.Add(Me.lblBanco)
        Me.Controls.Add(Me.cboBanco)
        Me.Controls.Add(Me.lblCuenta)
        Me.Controls.Add(Me.selCuenta)
        Me.Controls.Add(Me.txtRazonSocial)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "BeneficiariosForm"
        Me.Text = "BeneficiariosForm"
        Me.Controls.SetChildIndex(Me.lblNombre, 0)
        Me.Controls.SetChildIndex(Me.txtRazonSocial, 0)
        Me.Controls.SetChildIndex(Me.selCuenta, 0)
        Me.Controls.SetChildIndex(Me.lblCuenta, 0)
        Me.Controls.SetChildIndex(Me.cboBanco, 0)
        Me.Controls.SetChildIndex(Me.lblBanco, 0)
        Me.Controls.SetChildIndex(Me.lblCLABE, 0)
        Me.Controls.SetChildIndex(Me.txtCLABE, 0)
        Me.Controls.SetChildIndex(Me.chkLeyenda, 0)
        Me.Controls.SetChildIndex(Me.upDownDiasCredito, 0)
        Me.Controls.SetChildIndex(Me.lblDiasCredito, 0)
        CType(Me.upDownDiasCredito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Facade = New BeneficiarioFacade
    End Sub
    Friend WithEvents lblCuenta As Azteca.Windows.Controls.CILabel
    Friend WithEvents selCuenta As Azteca.Windows.Contabilidad.CuentaSelector
    Friend WithEvents txtRazonSocial As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblNombre As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboBanco As Azteca.Windows.Tesoreria.BancosComboBox
    Friend WithEvents lblBanco As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCLABE As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblCLABE As Azteca.Windows.Controls.CILabel
    Friend WithEvents chkLeyenda As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents upDownDiasCredito As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents lblDiasCredito As Azteca.Windows.Controls.CILabel
End Class
