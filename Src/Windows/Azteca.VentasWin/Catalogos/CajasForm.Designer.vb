<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CajasForm
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
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel24 = New Azteca.Windows.Controls.CILabel()
        Me.lblImpresora = New Azteca.Windows.Controls.CILabel()
        Me.selCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.cboImpresora = New Azteca.Windows.Controls.ImpresorasComboBox()
        Me.chkFactGlobal = New Azteca.Windows.Controls.CICheckBox()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(76, 90)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(315, 20)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.UIName = "Nombre"
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(16, 93)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(47, 13)
        Me.CiLabel1.TabIndex = 0
        Me.CiLabel1.Text = "Nombre:"
        '
        'CiLabel24
        '
        Me.CiLabel24.AutoSize = True
        Me.CiLabel24.Location = New System.Drawing.Point(16, 141)
        Me.CiLabel24.Name = "CiLabel24"
        Me.CiLabel24.Size = New System.Drawing.Size(44, 13)
        Me.CiLabel24.TabIndex = 4
        Me.CiLabel24.Text = "Cuenta:"
        '
        'lblImpresora
        '
        Me.lblImpresora.AutoSize = True
        Me.lblImpresora.Location = New System.Drawing.Point(16, 117)
        Me.lblImpresora.Name = "lblImpresora"
        Me.lblImpresora.Size = New System.Drawing.Size(56, 13)
        Me.lblImpresora.TabIndex = 2
        Me.lblImpresora.Text = "Impresora:"
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
        Me.selCuenta.Location = New System.Drawing.Point(76, 137)
        Me.selCuenta.Name = "selCuenta"
        Me.selCuenta.Size = New System.Drawing.Size(315, 23)
        Me.selCuenta.TabIndex = 5
        Me.selCuenta.TextWidth = 100
        '
        'cboImpresora
        '
        Me.cboImpresora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboImpresora.FormattingEnabled = True
        Me.cboImpresora.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboImpresora.ItemsTable = Nothing
        Me.cboImpresora.Location = New System.Drawing.Point(76, 114)
        Me.cboImpresora.Name = "cboImpresora"
        Me.cboImpresora.Size = New System.Drawing.Size(314, 21)
        Me.cboImpresora.TabIndex = 3
        Me.cboImpresora.UIName = Nothing
        '
        'chkFactGlobal
        '
        Me.chkFactGlobal.AutoSize = True
        Me.chkFactGlobal.Location = New System.Drawing.Point(76, 166)
        Me.chkFactGlobal.Name = "chkFactGlobal"
        Me.chkFactGlobal.Size = New System.Drawing.Size(184, 17)
        Me.chkFactGlobal.TabIndex = 32
        Me.chkFactGlobal.Text = "Generar factura global en el corte"
        Me.chkFactGlobal.UseVisualStyleBackColor = True
        '
        'CajasForm
        '
        Me.AllowRecordNavigation = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 254)
        Me.Controls.Add(Me.chkFactGlobal)
        Me.Controls.Add(Me.cboImpresora)
        Me.Controls.Add(Me.selCuenta)
        Me.Controls.Add(Me.lblImpresora)
        Me.Controls.Add(Me.CiLabel24)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.CiLabel1)
        Me.Name = "CajasForm"
        Me.Text = "CajasForm"
        Me.Controls.SetChildIndex(Me.CiLabel1, 0)
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.CiLabel24, 0)
        Me.Controls.SetChildIndex(Me.lblImpresora, 0)
        Me.Controls.SetChildIndex(Me.selCuenta, 0)
        Me.Controls.SetChildIndex(Me.cboImpresora, 0)
        Me.Controls.SetChildIndex(Me.chkFactGlobal, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel24 As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblImpresora As Azteca.Windows.Controls.CILabel
    Friend WithEvents selCuenta As Azteca.Windows.Contabilidad.CuentaSelector
    Friend WithEvents cboImpresora As Azteca.Windows.Controls.ImpresorasComboBox

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Facade = New CajaFacade
    End Sub
    Friend WithEvents chkFactGlobal As Azteca.Windows.Controls.CICheckBox
End Class
