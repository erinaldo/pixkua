<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IncidenciasForm
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
        Me.components = New System.ComponentModel.Container()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SelCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.selTipoIncidencia = New Azteca.Windows.Produccion.IncidenciasTiposComboBox(Me.components)
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(126, 108)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(361, 20)
        Me.txtNombre.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Cuenta"
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
        Me.SelCuenta.Location = New System.Drawing.Point(126, 163)
        Me.SelCuenta.Name = "SelCuenta"
        Me.SelCuenta.Size = New System.Drawing.Size(361, 23)
        Me.SelCuenta.TabIndex = 37
        Me.SelCuenta.TextWidth = 100
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Tipo de Incidencia"
        '
        'selTipoIncidencia
        '
        Me.selTipoIncidencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.selTipoIncidencia.FormattingEnabled = True
        Me.selTipoIncidencia.HighlightColor = System.Drawing.SystemColors.Info
        Me.selTipoIncidencia.ItemsTable = Nothing
        Me.selTipoIncidencia.Location = New System.Drawing.Point(126, 134)
        Me.selTipoIncidencia.Name = "selTipoIncidencia"
        Me.selTipoIncidencia.Size = New System.Drawing.Size(206, 21)
        Me.selTipoIncidencia.TabIndex = 39
        Me.selTipoIncidencia.UIName = Nothing
        '
        'IncidenciasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 245)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.selTipoIncidencia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SelCuenta)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "IncidenciasForm"
        Me.Text = "IncidenciasForm"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.SelCuenta, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.selTipoIncidencia, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Facade = New IncidenciaFacade
    End Sub
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SelCuenta As Azteca.Windows.Contabilidad.CuentaSelector
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents selTipoIncidencia As Azteca.Windows.Produccion.IncidenciasTiposComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label


End Class
