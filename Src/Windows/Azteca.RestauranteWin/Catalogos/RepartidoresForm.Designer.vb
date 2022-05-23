<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepartidoresForm
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
        Me.txtNombreCorto = New Azteca.Windows.Controls.CITextBox()
        Me.lblNombreCorto = New Azteca.Windows.Controls.CILabel()
        Me.lblUsuario = New Azteca.Windows.Controls.CILabel()
        Me.selUsuario = New Azteca.Windows.Controls.Security.UsuarioSelector()
        Me.lblCuenta = New Azteca.Windows.Controls.CILabel()
        Me.selCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.SuspendLayout()
        '
        'txtNombreCorto
        '
        Me.txtNombreCorto.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombreCorto.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombreCorto.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombreCorto.Location = New System.Drawing.Point(85, 134)
        Me.txtNombreCorto.MaxLength = 32
        Me.txtNombreCorto.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombreCorto.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombreCorto.Name = "txtNombreCorto"
        Me.txtNombreCorto.Size = New System.Drawing.Size(205, 20)
        Me.txtNombreCorto.TabIndex = 50
        '
        'lblNombreCorto
        '
        Me.lblNombreCorto.AutoSize = True
        Me.lblNombreCorto.Location = New System.Drawing.Point(3, 137)
        Me.lblNombreCorto.Name = "lblNombreCorto"
        Me.lblNombreCorto.Size = New System.Drawing.Size(72, 13)
        Me.lblNombreCorto.TabIndex = 49
        Me.lblNombreCorto.Text = "Nombre Corto"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(31, 113)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 48
        Me.lblUsuario.Text = "Usuario"
        '
        'selUsuario
        '
        Me.selUsuario.AnySite = False
        Me.selUsuario.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selUsuario.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.selUsuario.EditorAssembly = "Azteca.Windows"
        Me.selUsuario.EditorClass = "Azteca.Windows.Forms.Security.CatalogoUsuarios"
        Me.selUsuario.EditorTitle = "Editar usuario..."
        Me.selUsuario.Key = 0
        Me.selUsuario.Linked = False
        Me.selUsuario.Location = New System.Drawing.Point(85, 108)
        Me.selUsuario.Name = "selUsuario"
        Me.selUsuario.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selUsuario.Size = New System.Drawing.Size(194, 23)
        Me.selUsuario.TabIndex = 47
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Location = New System.Drawing.Point(33, 161)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(41, 13)
        Me.lblCuenta.TabIndex = 46
        Me.lblCuenta.Text = "Cuenta"
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
        Me.selCuenta.Location = New System.Drawing.Point(85, 157)
        Me.selCuenta.Name = "selCuenta"
        Me.selCuenta.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selCuenta.Size = New System.Drawing.Size(230, 23)
        Me.selCuenta.TabIndex = 45
        Me.selCuenta.TextWidth = 100
        '
        'RepartidoresForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 282)
        Me.Controls.Add(Me.txtNombreCorto)
        Me.Controls.Add(Me.lblNombreCorto)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.selUsuario)
        Me.Controls.Add(Me.lblCuenta)
        Me.Controls.Add(Me.selCuenta)
        Me.Name = "RepartidoresForm"
        Me.Text = "RepartidoresForm"
        Me.Controls.SetChildIndex(Me.selCuenta, 0)
        Me.Controls.SetChildIndex(Me.lblCuenta, 0)
        Me.Controls.SetChildIndex(Me.selUsuario, 0)
        Me.Controls.SetChildIndex(Me.lblUsuario, 0)
        Me.Controls.SetChildIndex(Me.lblNombreCorto, 0)
        Me.Controls.SetChildIndex(Me.txtNombreCorto, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombreCorto As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblNombreCorto As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblUsuario As Azteca.Windows.Controls.CILabel
    Friend WithEvents selUsuario As Azteca.Windows.Controls.Security.UsuarioSelector
    Friend WithEvents lblCuenta As Azteca.Windows.Controls.CILabel
    Friend WithEvents selCuenta As Azteca.Windows.Contabilidad.CuentaSelector

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Facade = New RepartidorFacade
    End Sub

End Class
