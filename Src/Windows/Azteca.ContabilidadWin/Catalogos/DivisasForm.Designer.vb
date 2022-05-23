<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DivisasForm
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
        Me.txtAbreviatura = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.txtTipo = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.txtSerie = New Azteca.Windows.Controls.CITextBox()
        Me.SuspendLayout()
        '
        'txtAbreviatura
        '
        Me.txtAbreviatura.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtAbreviatura.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtAbreviatura.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtAbreviatura.Location = New System.Drawing.Point(150, 175)
        Me.txtAbreviatura.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAbreviatura.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.RequiredField = True
        Me.txtAbreviatura.Size = New System.Drawing.Size(100, 20)
        Me.txtAbreviatura.TabIndex = 7
        Me.txtAbreviatura.UIName = "Abreviatura"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(69, 178)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(64, 13)
        Me.CiLabel2.TabIndex = 6
        Me.CiLabel2.Text = "Abreviatura:"
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(69, 102)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(47, 13)
        Me.CiLabel1.TabIndex = 0
        Me.CiLabel1.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(150, 99)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(225, 20)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.UIName = "Nombre"
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(69, 128)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(31, 13)
        Me.CiLabel3.TabIndex = 2
        Me.CiLabel3.Text = "Tipo:"
        '
        'txtTipo
        '
        Me.txtTipo.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtTipo.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtTipo.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTipo.Location = New System.Drawing.Point(150, 125)
        Me.txtTipo.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTipo.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.RequiredField = True
        Me.txtTipo.Size = New System.Drawing.Size(225, 20)
        Me.txtTipo.TabIndex = 3
        Me.txtTipo.UIName = "Tipo"
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.Location = New System.Drawing.Point(69, 152)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(75, 13)
        Me.CiLabel4.TabIndex = 4
        Me.CiLabel4.Text = "Serie Banxico:"
        '
        'txtSerie
        '
        Me.txtSerie.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtSerie.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtSerie.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtSerie.Location = New System.Drawing.Point(150, 149)
        Me.txtSerie.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSerie.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(100, 20)
        Me.txtSerie.TabIndex = 5
        Me.txtSerie.UIName = "Serie"
        '
        'DivisasForm
        '
        Me.AllowRecordNavigation = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 245)
        Me.Controls.Add(Me.txtSerie)
        Me.Controls.Add(Me.CiLabel4)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.CiLabel3)
        Me.Controls.Add(Me.txtAbreviatura)
        Me.Controls.Add(Me.CiLabel2)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.txtNombre)
        Me.Name = "DivisasForm"
        Me.Text = "DivisasForm"
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.CiLabel1, 0)
        Me.Controls.SetChildIndex(Me.CiLabel2, 0)
        Me.Controls.SetChildIndex(Me.txtAbreviatura, 0)
        Me.Controls.SetChildIndex(Me.CiLabel3, 0)
        Me.Controls.SetChildIndex(Me.txtTipo, 0)
        Me.Controls.SetChildIndex(Me.CiLabel4, 0)
        Me.Controls.SetChildIndex(Me.txtSerie, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New DivisaFacade

    End Sub
    Friend WithEvents txtAbreviatura As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtTipo As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtSerie As Azteca.Windows.Controls.CITextBox
End Class
