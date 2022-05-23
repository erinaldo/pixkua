<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IncidenciasTiposForm
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
        Me.SelCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkNoContabilizar = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'SelCuenta
        '
        Me.SelCuenta.AnySite = False
        Me.SelCuenta.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.SelCuenta.EditorAssembly = "Azteca.ContabilidadWin"
        Me.SelCuenta.EditorClass = "Azteca.Windows.Contabilidad.CuentaForm"
        Me.SelCuenta.EditorTitle = "Editar Cuenta..."
        Me.SelCuenta.Key = 0
        Me.SelCuenta.Linked = False
        Me.SelCuenta.Location = New System.Drawing.Point(183, 195)
        Me.SelCuenta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SelCuenta.Name = "SelCuenta"
        Me.SelCuenta.Size = New System.Drawing.Size(540, 23)
        Me.SelCuenta.TabIndex = 32
        Me.SelCuenta.TextWidth = 148
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(106, 157)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(182, 152)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(540, 26)
        Me.txtNombre.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(114, 198)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Cuenta"
        '
        'chkNoContabilizar
        '
        Me.chkNoContabilizar.AutoSize = True
        Me.chkNoContabilizar.Location = New System.Drawing.Point(182, 254)
        Me.chkNoContabilizar.Name = "chkNoContabilizar"
        Me.chkNoContabilizar.Size = New System.Drawing.Size(142, 24)
        Me.chkNoContabilizar.TabIndex = 36
        Me.chkNoContabilizar.Text = "No Contabilizar"
        Me.chkNoContabilizar.UseVisualStyleBackColor = True
        '
        'IncidenciasTiposForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 325)
        Me.Controls.Add(Me.chkNoContabilizar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SelCuenta)
        Me.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.Name = "IncidenciasTiposForm"
        Me.Text = "Tipos de Incidencias"
        Me.Controls.SetChildIndex(Me.SelCuenta, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.chkNoContabilizar, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Facade = New IncidenciaTipoFacade
    End Sub

    Friend WithEvents SelCuenta As Azteca.Windows.Contabilidad.CuentaSelector
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkNoContabilizar As System.Windows.Forms.CheckBox
End Class
