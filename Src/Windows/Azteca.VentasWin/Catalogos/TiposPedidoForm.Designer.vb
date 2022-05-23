<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TiposPedidoForm
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
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.txtCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.chkActivo = New Azteca.Windows.Controls.CICheckBox()
        Me.SuspendLayout()
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(18, 121)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(44, 13)
        Me.CiLabel2.TabIndex = 21
        Me.CiLabel2.Text = "Cuenta:"
        '
        'txtCuenta
        '
        Me.txtCuenta.AnySite = False
        Me.txtCuenta.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtCuenta.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCuenta.EditorAssembly = "Azteca.ContabilidadWin"
        Me.txtCuenta.EditorClass = "Azteca.Windows.Contabilidad.CuentaForm"
        Me.txtCuenta.EditorTitle = "Editar Cuenta..."
        Me.txtCuenta.Key = 0
        Me.txtCuenta.Linked = False
        Me.txtCuenta.Location = New System.Drawing.Point(71, 118)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.txtCuenta.Size = New System.Drawing.Size(326, 23)
        Me.txtCuenta.TabIndex = 22
        Me.txtCuenta.TextWidth = 100
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(18, 95)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(47, 13)
        Me.CiLabel1.TabIndex = 19
        Me.CiLabel1.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(71, 92)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(326, 20)
        Me.txtNombre.TabIndex = 20
        Me.txtNombre.UIName = "Nombre"
        '
        'chkActivo
        '
        Me.chkActivo.AutoClear = False
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.Location = New System.Drawing.Point(72, 147)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 23
        Me.chkActivo.Text = "Activa"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'TiposPedidoForm
        '
        Me.AllowRecordNavigation = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 231)
        Me.Controls.Add(Me.CiLabel2)
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.chkActivo)
        Me.Name = "TiposPedidoForm"
        Me.Text = "TiposPedidoForm"
        Me.Controls.SetChildIndex(Me.chkActivo, 0)
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.CiLabel1, 0)
        Me.Controls.SetChildIndex(Me.txtCuenta, 0)
        Me.Controls.SetChildIndex(Me.CiLabel2, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New TipoPedidoFacade
    End Sub
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCuenta As Azteca.Windows.Contabilidad.CuentaSelector
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents chkActivo As Azteca.Windows.Controls.CICheckBox
End Class
