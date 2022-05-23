<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasillosForm
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
        Me.cboImpresora = New Azteca.Windows.Controls.ImpresorasComboBox()
        Me.selCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.lblImpresora = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel24 = New Azteca.Windows.Controls.CILabel()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.cboAlmacen = New Azteca.Windows.Inventario.AlmacenesComboBox()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.SuspendLayout()
        '
        'cboImpresora
        '
        Me.cboImpresora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboImpresora.FormattingEnabled = True
        Me.cboImpresora.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboImpresora.ItemsTable = Nothing
        Me.cboImpresora.Location = New System.Drawing.Point(121, 171)
        Me.cboImpresora.Name = "cboImpresora"
        Me.cboImpresora.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboImpresora.Size = New System.Drawing.Size(361, 21)
        Me.cboImpresora.TabIndex = 35
        Me.cboImpresora.UIName = Nothing
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
        Me.selCuenta.Location = New System.Drawing.Point(121, 194)
        Me.selCuenta.Name = "selCuenta"
        Me.selCuenta.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selCuenta.Size = New System.Drawing.Size(362, 23)
        Me.selCuenta.TabIndex = 37
        Me.selCuenta.TextWidth = 100
        '
        'lblImpresora
        '
        Me.lblImpresora.AutoSize = True
        Me.lblImpresora.Location = New System.Drawing.Point(61, 174)
        Me.lblImpresora.Name = "lblImpresora"
        Me.lblImpresora.Size = New System.Drawing.Size(56, 13)
        Me.lblImpresora.TabIndex = 34
        Me.lblImpresora.Text = "Impresora:"
        '
        'CiLabel24
        '
        Me.CiLabel24.AutoSize = True
        Me.CiLabel24.Location = New System.Drawing.Point(61, 198)
        Me.CiLabel24.Name = "CiLabel24"
        Me.CiLabel24.Size = New System.Drawing.Size(44, 13)
        Me.CiLabel24.TabIndex = 36
        Me.CiLabel24.Text = "Cuenta:"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(121, 147)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(362, 20)
        Me.txtNombre.TabIndex = 33
        Me.txtNombre.UIName = "Nombre"
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(61, 150)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(47, 13)
        Me.CiLabel1.TabIndex = 32
        Me.CiLabel1.Text = "Nombre:"
        '
        'cboAlmacen
        '
        Me.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacen.FormattingEnabled = True
        Me.cboAlmacen.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboAlmacen.ItemsTable = Nothing
        Me.cboAlmacen.Location = New System.Drawing.Point(121, 121)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.RequiredField = True
        Me.cboAlmacen.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboAlmacen.Size = New System.Drawing.Size(361, 21)
        Me.cboAlmacen.TabIndex = 38
        Me.cboAlmacen.UIName = Nothing
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(61, 124)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(51, 13)
        Me.CiLabel2.TabIndex = 39
        Me.CiLabel2.Text = "Almacen:"
        '
        'PasillosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 281)
        Me.Controls.Add(Me.CiLabel2)
        Me.Controls.Add(Me.cboAlmacen)
        Me.Controls.Add(Me.cboImpresora)
        Me.Controls.Add(Me.selCuenta)
        Me.Controls.Add(Me.lblImpresora)
        Me.Controls.Add(Me.CiLabel24)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.CiLabel1)
        Me.Name = "PasillosForm"
        Me.Text = "PasillosForm"
        Me.Controls.SetChildIndex(Me.CiLabel1, 0)
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.CiLabel24, 0)
        Me.Controls.SetChildIndex(Me.lblImpresora, 0)
        Me.Controls.SetChildIndex(Me.selCuenta, 0)
        Me.Controls.SetChildIndex(Me.cboImpresora, 0)
        Me.Controls.SetChildIndex(Me.cboAlmacen, 0)
        Me.Controls.SetChildIndex(Me.CiLabel2, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Facade = New PasilloFacade

    End Sub
    Friend WithEvents cboImpresora As Azteca.Windows.Controls.ImpresorasComboBox
    Friend WithEvents selCuenta As Azteca.Windows.Contabilidad.CuentaSelector
    Friend WithEvents lblImpresora As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel24 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboAlmacen As Azteca.Windows.Inventario.AlmacenesComboBox
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
End Class
