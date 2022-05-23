<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ColoresForm
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
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.lblColorBOX = New Azteca.Windows.Controls.CILabel()
        Me.cmdColor = New Azteca.Windows.Controls.CIButton()
        Me.lblColor = New Azteca.Windows.Controls.CILabel()
        Me.dlgColor = New System.Windows.Forms.ColorDialog()
        Me.txtReferencia = New Azteca.Windows.Controls.CITextBox()
        Me.lblReferencia = New Azteca.Windows.Controls.CILabel()
        Me.SuspendLayout()
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Location = New System.Drawing.Point(56, 127)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(44, 13)
        Me.lblCuenta.TabIndex = 41
        Me.lblCuenta.Text = "Cuenta:"
        '
        'selCuenta
        '
        Me.selCuenta.AnySite = False
        Me.selCuenta.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selCuenta.EditorAssembly = "Azteca.ContabilidadWin"
        Me.selCuenta.EditorClass = "Azteca.Windows.Contabilidad.CuentaForm"
        Me.selCuenta.EditorTitle = "Editar Cuenta..."
        Me.selCuenta.Key = 0
        Me.selCuenta.Linked = False
        Me.selCuenta.Location = New System.Drawing.Point(121, 123)
        Me.selCuenta.Name = "selCuenta"
        Me.selCuenta.Size = New System.Drawing.Size(361, 23)
        Me.selCuenta.TabIndex = 40
        Me.selCuenta.TextWidth = 100
        '
        'txtNombre
        '
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(121, 101)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(361, 20)
        Me.txtNombre.TabIndex = 39
        Me.txtNombre.UIName = "Nombre"
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(56, 104)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(47, 13)
        Me.CiLabel1.TabIndex = 38
        Me.CiLabel1.Text = "Nombre:"
        '
        'lblColorBOX
        '
        Me.lblColorBOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblColorBOX.Location = New System.Drawing.Point(121, 148)
        Me.lblColorBOX.Name = "lblColorBOX"
        Me.lblColorBOX.Size = New System.Drawing.Size(104, 23)
        Me.lblColorBOX.TabIndex = 44
        '
        'cmdColor
        '
        Me.cmdColor.Location = New System.Drawing.Point(226, 147)
        Me.cmdColor.Name = "cmdColor"
        Me.cmdColor.Size = New System.Drawing.Size(26, 25)
        Me.cmdColor.TabIndex = 43
        Me.cmdColor.UseVisualStyleBackColor = True
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(56, 153)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(31, 13)
        Me.lblColor.TabIndex = 42
        Me.lblColor.Text = "Color"
        '
        'txtReferencia
        '
        Me.txtReferencia.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtReferencia.Location = New System.Drawing.Point(121, 178)
        Me.txtReferencia.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtReferencia.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.RequiredField = True
        Me.txtReferencia.Size = New System.Drawing.Size(131, 20)
        Me.txtReferencia.TabIndex = 46
        Me.txtReferencia.UIName = "Nombre"
        '
        'lblReferencia
        '
        Me.lblReferencia.AutoSize = True
        Me.lblReferencia.Location = New System.Drawing.Point(56, 181)
        Me.lblReferencia.Name = "lblReferencia"
        Me.lblReferencia.Size = New System.Drawing.Size(62, 13)
        Me.lblReferencia.TabIndex = 45
        Me.lblReferencia.Text = "Referencia:"
        '
        'ColoresForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 250)
        Me.Controls.Add(Me.txtReferencia)
        Me.Controls.Add(Me.lblReferencia)
        Me.Controls.Add(Me.lblColorBOX)
        Me.Controls.Add(Me.cmdColor)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.lblCuenta)
        Me.Controls.Add(Me.selCuenta)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.CiLabel1)
        Me.Name = "ColoresForm"
        Me.Text = "ColoresForm"
        Me.Controls.SetChildIndex(Me.CiLabel1, 0)
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.selCuenta, 0)
        Me.Controls.SetChildIndex(Me.lblCuenta, 0)
        Me.Controls.SetChildIndex(Me.lblColor, 0)
        Me.Controls.SetChildIndex(Me.cmdColor, 0)
        Me.Controls.SetChildIndex(Me.lblColorBOX, 0)
        Me.Controls.SetChildIndex(Me.lblReferencia, 0)
        Me.Controls.SetChildIndex(Me.txtReferencia, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.facade = New ColorFacade
    End Sub
    Friend WithEvents lblCuenta As Azteca.Windows.Controls.CILabel
    Friend WithEvents selCuenta As Azteca.Windows.Contabilidad.CuentaSelector
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblColorBOX As Azteca.Windows.Controls.CILabel
    Friend WithEvents cmdColor As Azteca.Windows.Controls.CIButton
    Friend WithEvents lblColor As Azteca.Windows.Controls.CILabel
    Friend WithEvents dlgColor As System.Windows.Forms.ColorDialog
    Friend WithEvents txtReferencia As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblReferencia As Azteca.Windows.Controls.CILabel

End Class
