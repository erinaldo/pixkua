<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RetencionesForm
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
        Me.cboTipoRetencion = New Azteca.Windows.Controls.CIComboBox()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.nudPorcentaje = New Azteca.Windows.Controls.CINumericUpDown()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.txtAbreviatura = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        CType(Me.nudPorcentaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboTipoRetencion
        '
        Me.cboTipoRetencion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoRetencion.FormattingEnabled = True
        Me.cboTipoRetencion.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboTipoRetencion.Items.AddRange(New Object() {"IVA ", "ISR  "})
        Me.cboTipoRetencion.ItemsTable = Nothing
        Me.cboTipoRetencion.Location = New System.Drawing.Point(121, 101)
        Me.cboTipoRetencion.Name = "cboTipoRetencion"
        Me.cboTipoRetencion.RequiredField = True
        Me.cboTipoRetencion.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboTipoRetencion.Size = New System.Drawing.Size(92, 21)
        Me.cboTipoRetencion.TabIndex = 1
        Me.cboTipoRetencion.UIName = Nothing
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.Location = New System.Drawing.Point(33, 104)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(83, 13)
        Me.CiLabel4.TabIndex = 0
        Me.CiLabel4.Text = "Tipo Retención:"
        '
        'nudPorcentaje
        '
        Me.nudPorcentaje.DecimalPlaces = 2
        Me.nudPorcentaje.HighlightColor = System.Drawing.SystemColors.Info
        Me.nudPorcentaje.Location = New System.Drawing.Point(291, 155)
        Me.nudPorcentaje.Name = "nudPorcentaje"
        Me.nudPorcentaje.Size = New System.Drawing.Size(67, 20)
        Me.nudPorcentaje.TabIndex = 7
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(219, 158)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(61, 13)
        Me.CiLabel3.TabIndex = 6
        Me.CiLabel3.Text = "Porcentaje:"
        '
        'txtAbreviatura
        '
        Me.txtAbreviatura.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtAbreviatura.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtAbreviatura.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtAbreviatura.Location = New System.Drawing.Point(121, 155)
        Me.txtAbreviatura.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAbreviatura.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.RequiredField = True
        Me.txtAbreviatura.Size = New System.Drawing.Size(92, 20)
        Me.txtAbreviatura.TabIndex = 5
        Me.txtAbreviatura.UIName = "Abreviatura"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(33, 158)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(64, 13)
        Me.CiLabel2.TabIndex = 4
        Me.CiLabel2.Text = "Abreviatura:"
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(33, 132)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(47, 13)
        Me.CiLabel1.TabIndex = 2
        Me.CiLabel1.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(121, 129)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(237, 20)
        Me.txtNombre.TabIndex = 3
        Me.txtNombre.UIName = "Nombre"
        '
        'RetencionesForm
        '
        Me.AllowRecordNavigation = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 231)
        Me.Controls.Add(Me.cboTipoRetencion)
        Me.Controls.Add(Me.CiLabel4)
        Me.Controls.Add(Me.nudPorcentaje)
        Me.Controls.Add(Me.CiLabel3)
        Me.Controls.Add(Me.txtAbreviatura)
        Me.Controls.Add(Me.CiLabel2)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.txtNombre)
        Me.Name = "RetencionesForm"
        Me.Text = "RetencionesForm"
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.CiLabel1, 0)
        Me.Controls.SetChildIndex(Me.CiLabel2, 0)
        Me.Controls.SetChildIndex(Me.txtAbreviatura, 0)
        Me.Controls.SetChildIndex(Me.CiLabel3, 0)
        Me.Controls.SetChildIndex(Me.nudPorcentaje, 0)
        Me.Controls.SetChildIndex(Me.CiLabel4, 0)
        Me.Controls.SetChildIndex(Me.cboTipoRetencion, 0)
        CType(Me.nudPorcentaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboTipoRetencion As Azteca.Windows.Controls.CIComboBox
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
    Friend WithEvents nudPorcentaje As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtAbreviatura As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Facade = New RetencionFacade
    End Sub
End Class
