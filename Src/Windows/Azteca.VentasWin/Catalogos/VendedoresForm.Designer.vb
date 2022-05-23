<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VendedoresForm
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
        Me.lblEmpleado = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel5 = New Azteca.Windows.Controls.CILabel()
        Me.selCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.selEmpleado = New Azteca.Windows.RH.EmpleadoSelector()
        Me.SuspendLayout()
        '
        'lblEmpleado
        '
        Me.lblEmpleado.AutoSize = True
        Me.lblEmpleado.Location = New System.Drawing.Point(55, 111)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(57, 13)
        Me.lblEmpleado.TabIndex = 30
        Me.lblEmpleado.Text = "Empleado:"
        '
        'CiLabel5
        '
        Me.CiLabel5.AutoSize = True
        Me.CiLabel5.Location = New System.Drawing.Point(55, 136)
        Me.CiLabel5.Name = "CiLabel5"
        Me.CiLabel5.Size = New System.Drawing.Size(44, 13)
        Me.CiLabel5.TabIndex = 28
        Me.CiLabel5.Text = "Cuenta:"
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
        Me.selCuenta.Location = New System.Drawing.Point(118, 132)
        Me.selCuenta.Name = "selCuenta"
        Me.selCuenta.Size = New System.Drawing.Size(386, 23)
        Me.selCuenta.TabIndex = 27
        Me.selCuenta.TextWidth = 100
        '
        'selEmpleado
        '
        Me.selEmpleado.AnySite = False
        Me.selEmpleado.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selEmpleado.EditorAssembly = "Azteca.RHWin"
        Me.selEmpleado.EditorClass = "Azteca.Windows.RH.EmpleadosForm"
        Me.selEmpleado.EditorTitle = "Editar datos de articulo..."
        Me.selEmpleado.Key = 0
        Me.selEmpleado.Linked = False
        Me.selEmpleado.Location = New System.Drawing.Point(118, 107)
        Me.selEmpleado.Name = "selEmpleado"
        Me.selEmpleado.RequiredField = True
        Me.selEmpleado.Size = New System.Drawing.Size(386, 23)
        Me.selEmpleado.TabIndex = 26
        '
        'VendedoresForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 220)
        Me.Controls.Add(Me.lblEmpleado)
        Me.Controls.Add(Me.CiLabel5)
        Me.Controls.Add(Me.selCuenta)
        Me.Controls.Add(Me.selEmpleado)
        Me.KeyMode = Azteca.Windows.Forms.BusinessForms.CatalogForm.UserKeyMode.UserDefined
        Me.Name = "VendedoresForm"
        Me.Text = "VendedoresForm"
        Me.Controls.SetChildIndex(Me.selEmpleado, 0)
        Me.Controls.SetChildIndex(Me.selCuenta, 0)
        Me.Controls.SetChildIndex(Me.CiLabel5, 0)
        Me.Controls.SetChildIndex(Me.lblEmpleado, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Facade = New VendedorFacade
    End Sub
    Friend WithEvents lblEmpleado As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel5 As Azteca.Windows.Controls.CILabel
    Friend WithEvents selCuenta As Azteca.Windows.Contabilidad.CuentaSelector
    Friend WithEvents selEmpleado As Azteca.Windows.RH.EmpleadoSelector

End Class
