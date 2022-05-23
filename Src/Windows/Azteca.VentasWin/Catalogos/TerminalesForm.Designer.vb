<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TerminalesForm
    Inherits Azteca.Windows.Forms.BusinessForms.CatalogForm

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
        Me.selCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.CiLabel24 = New Azteca.Windows.Controls.CILabel()
        Me.chkActivo = New Azteca.Windows.Controls.CICheckBox()
        Me.lblCaja = New Azteca.Windows.Controls.CILabel()
        Me.cboCaja = New Azteca.Windows.Ventas.CajaCombobox()
        Me.txtPC = New Azteca.Windows.Controls.CITextBox()
        Me.lblPC = New Azteca.Windows.Controls.CILabel()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.SuspendLayout()
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
        Me.selCuenta.Location = New System.Drawing.Point(90, 157)
        Me.selCuenta.Name = "selCuenta"
        Me.selCuenta.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selCuenta.Size = New System.Drawing.Size(315, 23)
        Me.selCuenta.TabIndex = 28
        '
        'CiLabel24
        '
        Me.CiLabel24.AutoSize = True
        Me.CiLabel24.Location = New System.Drawing.Point(38, 161)
        Me.CiLabel24.Name = "CiLabel24"
        Me.CiLabel24.Size = New System.Drawing.Size(44, 13)
        Me.CiLabel24.TabIndex = 27
        Me.CiLabel24.Text = "Cuenta:"
        '
        'chkActivo
        '
        Me.chkActivo.AutoClear = False
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.Location = New System.Drawing.Point(90, 190)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 26
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'lblCaja
        '
        Me.lblCaja.AutoSize = True
        Me.lblCaja.Location = New System.Drawing.Point(38, 138)
        Me.lblCaja.Name = "lblCaja"
        Me.lblCaja.Size = New System.Drawing.Size(31, 13)
        Me.lblCaja.TabIndex = 29
        Me.lblCaja.Text = "Caja:"
        '
        'cboCaja
        '
        Me.cboCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCaja.FormattingEnabled = True
        Me.cboCaja.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboCaja.ItemsTable = Nothing
        Me.cboCaja.Location = New System.Drawing.Point(90, 134)
        Me.cboCaja.Name = "cboCaja"
        Me.cboCaja.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboCaja.Size = New System.Drawing.Size(315, 21)
        Me.cboCaja.TabIndex = 30
        Me.cboCaja.UIName = Nothing
        '
        'txtPC
        '
        Me.txtPC.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtPC.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtPC.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtPC.Location = New System.Drawing.Point(90, 109)
        Me.txtPC.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPC.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPC.Name = "txtPC"
        Me.txtPC.Size = New System.Drawing.Size(162, 20)
        Me.txtPC.TabIndex = 31
        '
        'lblPC
        '
        Me.lblPC.AutoSize = True
        Me.lblPC.Location = New System.Drawing.Point(38, 112)
        Me.lblPC.Name = "lblPC"
        Me.lblPC.Size = New System.Drawing.Size(21, 13)
        Me.lblPC.TabIndex = 32
        Me.lblPC.Text = "PC"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(91, 83)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(315, 20)
        Me.txtNombre.TabIndex = 34
        Me.txtNombre.UIName = "Nombre"
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(38, 86)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(47, 13)
        Me.CiLabel1.TabIndex = 33
        Me.CiLabel1.Text = "Nombre:"
        '
        'TerminalesForm
        '
        Me.AllowRecordNavigation = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 261)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.lblPC)
        Me.Controls.Add(Me.txtPC)
        Me.Controls.Add(Me.cboCaja)
        Me.Controls.Add(Me.lblCaja)
        Me.Controls.Add(Me.selCuenta)
        Me.Controls.Add(Me.CiLabel24)
        Me.Controls.Add(Me.chkActivo)
        Me.Name = "TerminalesForm"
        Me.Text = "TerminalesForm"
        Me.Controls.SetChildIndex(Me.chkActivo, 0)
        Me.Controls.SetChildIndex(Me.CiLabel24, 0)
        Me.Controls.SetChildIndex(Me.selCuenta, 0)
        Me.Controls.SetChildIndex(Me.lblCaja, 0)
        Me.Controls.SetChildIndex(Me.cboCaja, 0)
        Me.Controls.SetChildIndex(Me.txtPC, 0)
        Me.Controls.SetChildIndex(Me.lblPC, 0)
        Me.Controls.SetChildIndex(Me.CiLabel1, 0)
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents selCuenta As Azteca.Windows.Contabilidad.CuentaSelector
    Friend WithEvents CiLabel24 As Azteca.Windows.Controls.CILabel
    Friend WithEvents chkActivo As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents lblCaja As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboCaja As Azteca.Windows.Ventas.CajaCombobox
    Friend WithEvents txtPC As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblPC As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Facade = New TerminalFacade
    End Sub

End Class
