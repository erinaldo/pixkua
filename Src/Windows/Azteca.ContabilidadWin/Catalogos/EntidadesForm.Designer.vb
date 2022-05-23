<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntidadesForm
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
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.lblCampoPK = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.txtCampoPK = New Azteca.Windows.Controls.CITextBox()
        Me.txtSchema = New Azteca.Windows.Controls.CITextBox()
        Me.lblCampoName = New Azteca.Windows.Controls.CILabel()
        Me.txtCampoName = New Azteca.Windows.Controls.CITextBox()
        Me.txtObjeto = New Azteca.Windows.Controls.CITextBox()
        Me.lblObjeto = New Azteca.Windows.Controls.CILabel()
        Me.txtAlias = New Azteca.Windows.Controls.CITextBox()
        Me.lblAlias = New Azteca.Windows.Controls.CILabel()
        Me.SuspendLayout()
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(98, 113)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(44, 13)
        Me.CiLabel1.TabIndex = 2
        Me.CiLabel1.Text = "Nombre"
        '
        'lblCampoPK
        '
        Me.lblCampoPK.AutoSize = True
        Me.lblCampoPK.Location = New System.Drawing.Point(85, 160)
        Me.lblCampoPK.Name = "lblCampoPK"
        Me.lblCampoPK.Size = New System.Drawing.Size(57, 13)
        Me.lblCampoPK.TabIndex = 10
        Me.lblCampoPK.Text = "Campo PK"
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(96, 136)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(46, 13)
        Me.CiLabel3.TabIndex = 4
        Me.CiLabel3.Text = "Schema"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(150, 110)
        Me.txtNombre.MaxLength = 32
        Me.txtNombre.MaxValue = New Decimal(New Integer() {64, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(255, 20)
        Me.txtNombre.TabIndex = 3
        '
        'txtCampoPK
        '
        Me.txtCampoPK.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCampoPK.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCampoPK.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCampoPK.Location = New System.Drawing.Point(150, 157)
        Me.txtCampoPK.MaxValue = New Decimal(New Integer() {32, 0, 0, 0})
        Me.txtCampoPK.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCampoPK.Name = "txtCampoPK"
        Me.txtCampoPK.RequiredField = True
        Me.txtCampoPK.Size = New System.Drawing.Size(164, 20)
        Me.txtCampoPK.TabIndex = 11
        '
        'txtSchema
        '
        Me.txtSchema.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtSchema.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtSchema.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtSchema.Location = New System.Drawing.Point(150, 133)
        Me.txtSchema.MaxValue = New Decimal(New Integer() {64, 0, 0, 0})
        Me.txtSchema.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSchema.Name = "txtSchema"
        Me.txtSchema.RequiredField = True
        Me.txtSchema.Size = New System.Drawing.Size(164, 20)
        Me.txtSchema.TabIndex = 5
        '
        'lblCampoName
        '
        Me.lblCampoName.AutoSize = True
        Me.lblCampoName.Location = New System.Drawing.Point(318, 161)
        Me.lblCampoName.Name = "lblCampoName"
        Me.lblCampoName.Size = New System.Drawing.Size(80, 13)
        Me.lblCampoName.TabIndex = 12
        Me.lblCampoName.Text = "Campo Nombre"
        '
        'txtCampoName
        '
        Me.txtCampoName.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCampoName.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCampoName.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCampoName.Location = New System.Drawing.Point(403, 158)
        Me.txtCampoName.MaxValue = New Decimal(New Integer() {32, 0, 0, 0})
        Me.txtCampoName.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCampoName.Name = "txtCampoName"
        Me.txtCampoName.RequiredField = True
        Me.txtCampoName.Size = New System.Drawing.Size(171, 20)
        Me.txtCampoName.TabIndex = 13
        '
        'txtObjeto
        '
        Me.txtObjeto.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtObjeto.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtObjeto.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtObjeto.Location = New System.Drawing.Point(402, 134)
        Me.txtObjeto.MaxValue = New Decimal(New Integer() {64, 0, 0, 0})
        Me.txtObjeto.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtObjeto.Name = "txtObjeto"
        Me.txtObjeto.RequiredField = True
        Me.txtObjeto.Size = New System.Drawing.Size(171, 20)
        Me.txtObjeto.TabIndex = 7
        '
        'lblObjeto
        '
        Me.lblObjeto.AutoSize = True
        Me.lblObjeto.Location = New System.Drawing.Point(358, 140)
        Me.lblObjeto.Name = "lblObjeto"
        Me.lblObjeto.Size = New System.Drawing.Size(38, 13)
        Me.lblObjeto.TabIndex = 6
        Me.lblObjeto.Text = "Objeto"
        '
        'txtAlias
        '
        Me.txtAlias.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtAlias.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtAlias.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtAlias.Location = New System.Drawing.Point(616, 135)
        Me.txtAlias.MaxValue = New Decimal(New Integer() {5, 0, 0, 0})
        Me.txtAlias.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.RequiredField = True
        Me.txtAlias.Size = New System.Drawing.Size(56, 20)
        Me.txtAlias.TabIndex = 9
        '
        'lblAlias
        '
        Me.lblAlias.AutoSize = True
        Me.lblAlias.Location = New System.Drawing.Point(582, 139)
        Me.lblAlias.Name = "lblAlias"
        Me.lblAlias.Size = New System.Drawing.Size(29, 13)
        Me.lblAlias.TabIndex = 8
        Me.lblAlias.Text = "Alias"
        '
        'EntidadesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 230)
        Me.Controls.Add(Me.txtAlias)
        Me.Controls.Add(Me.lblAlias)
        Me.Controls.Add(Me.txtObjeto)
        Me.Controls.Add(Me.lblObjeto)
        Me.Controls.Add(Me.txtCampoName)
        Me.Controls.Add(Me.lblCampoName)
        Me.Controls.Add(Me.txtSchema)
        Me.Controls.Add(Me.txtCampoPK)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.CiLabel3)
        Me.Controls.Add(Me.lblCampoPK)
        Me.Controls.Add(Me.CiLabel1)
        Me.Name = "EntidadesForm"
        Me.Text = "EntidadesForm"
        Me.Controls.SetChildIndex(Me.CiLabel1, 0)
        Me.Controls.SetChildIndex(Me.lblCampoPK, 0)
        Me.Controls.SetChildIndex(Me.CiLabel3, 0)
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.txtCampoPK, 0)
        Me.Controls.SetChildIndex(Me.txtSchema, 0)
        Me.Controls.SetChildIndex(Me.lblCampoName, 0)
        Me.Controls.SetChildIndex(Me.txtCampoName, 0)
        Me.Controls.SetChildIndex(Me.lblObjeto, 0)
        Me.Controls.SetChildIndex(Me.txtObjeto, 0)
        Me.Controls.SetChildIndex(Me.lblAlias, 0)
        Me.Controls.SetChildIndex(Me.txtAlias, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCampoPK As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtCampoPK As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtSchema As Azteca.Windows.Controls.CITextBox

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Facade = New EntidadFacade
        LicenseModule = Kernel.Licensing.LicenseModule.Accounting
    End Sub
    Friend WithEvents lblCampoName As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCampoName As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtObjeto As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblObjeto As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtAlias As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblAlias As Azteca.Windows.Controls.CILabel
End Class
