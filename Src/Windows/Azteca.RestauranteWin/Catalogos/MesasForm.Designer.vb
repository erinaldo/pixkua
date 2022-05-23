<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MesasForm
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
        Me.txtDescripcion = New Azteca.Windows.Controls.CITextBox()
        Me.lblDescripcion = New Azteca.Windows.Controls.CILabel()
        Me.lblCuenta = New Azteca.Windows.Controls.CILabel()
        Me.selCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.lblCentroConsumo = New Azteca.Windows.Controls.CILabel()
        Me.cboCentrosConsumo = New Azteca.Windows.Restaurante.CentrosConsumoCombobox()
        Me.SuspendLayout()
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtDescripcion.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtDescripcion.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtDescripcion.Location = New System.Drawing.Point(136, 110)
        Me.txtDescripcion.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDescripcion.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(359, 20)
        Me.txtDescripcion.TabIndex = 31
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(67, 113)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcion.TabIndex = 30
        Me.lblDescripcion.Text = "Descripcion"
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Location = New System.Drawing.Point(89, 162)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(41, 13)
        Me.lblCuenta.TabIndex = 29
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
        Me.selCuenta.Location = New System.Drawing.Point(136, 158)
        Me.selCuenta.Name = "selCuenta"
        Me.selCuenta.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selCuenta.Size = New System.Drawing.Size(230, 23)
        Me.selCuenta.TabIndex = 28
        Me.selCuenta.TextWidth = 100
        '
        'lblCentroConsumo
        '
        Me.lblCentroConsumo.AutoSize = True
        Me.lblCentroConsumo.Location = New System.Drawing.Point(30, 137)
        Me.lblCentroConsumo.Name = "lblCentroConsumo"
        Me.lblCentroConsumo.Size = New System.Drawing.Size(100, 13)
        Me.lblCentroConsumo.TabIndex = 33
        Me.lblCentroConsumo.Text = "Centro de Consumo"
        '
        'cboCentrosConsumo
        '
        Me.cboCentrosConsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCentrosConsumo.FormattingEnabled = True
        Me.cboCentrosConsumo.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboCentrosConsumo.ItemsTable = Nothing
        Me.cboCentrosConsumo.Location = New System.Drawing.Point(136, 134)
        Me.cboCentrosConsumo.Name = "cboCentrosConsumo"
        Me.cboCentrosConsumo.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboCentrosConsumo.Size = New System.Drawing.Size(359, 21)
        Me.cboCentrosConsumo.TabIndex = 32
        Me.cboCentrosConsumo.UIName = Nothing
        '
        'MesasForm
        '
        Me.AllowRecordNavigation = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 268)
        Me.Controls.Add(Me.lblCentroConsumo)
        Me.Controls.Add(Me.cboCentrosConsumo)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblCuenta)
        Me.Controls.Add(Me.selCuenta)
        Me.Name = "MesasForm"
        Me.Text = "MesasForm"
        Me.Controls.SetChildIndex(Me.selCuenta, 0)
        Me.Controls.SetChildIndex(Me.lblCuenta, 0)
        Me.Controls.SetChildIndex(Me.lblDescripcion, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.cboCentrosConsumo, 0)
        Me.Controls.SetChildIndex(Me.lblCentroConsumo, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Facade = New MesaFacade
    End Sub
    Friend WithEvents txtDescripcion As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblDescripcion As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCuenta As Azteca.Windows.Controls.CILabel
    Friend WithEvents selCuenta As Azteca.Windows.Contabilidad.CuentaSelector
    Friend WithEvents cboCentrosConsumo As Azteca.Windows.Restaurante.CentrosConsumoCombobox
    Friend WithEvents lblCentroConsumo As Azteca.Windows.Controls.CILabel

End Class
