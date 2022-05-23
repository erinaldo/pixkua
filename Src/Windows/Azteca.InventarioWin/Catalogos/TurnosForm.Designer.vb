<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TurnosForm
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
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.dtpHoraIni = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.dtpHoraFin = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.SuspendLayout()
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(20, 106)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(44, 13)
        Me.CiLabel1.TabIndex = 0
        Me.CiLabel1.Text = "Nombe:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(89, 103)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(332, 20)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.UIName = "Nombre"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(20, 157)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(58, 13)
        Me.CiLabel2.TabIndex = 4
        Me.CiLabel2.Text = "Hora Final:"
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(20, 131)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(63, 13)
        Me.CiLabel3.TabIndex = 2
        Me.CiLabel3.Text = "Hora Inicial:"
        '
        'dtpHoraIni
        '
        Me.dtpHoraIni.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraIni.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpHoraIni.Location = New System.Drawing.Point(89, 129)
        Me.dtpHoraIni.Name = "dtpHoraIni"
        Me.dtpHoraIni.ShowUpDown = True
        Me.dtpHoraIni.Size = New System.Drawing.Size(94, 20)
        Me.dtpHoraIni.TabIndex = 3
        '
        'dtpHoraFin
        '
        Me.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraFin.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpHoraFin.Location = New System.Drawing.Point(89, 155)
        Me.dtpHoraFin.Name = "dtpHoraFin"
        Me.dtpHoraFin.ShowUpDown = True
        Me.dtpHoraFin.Size = New System.Drawing.Size(94, 20)
        Me.dtpHoraFin.TabIndex = 5
        '
        'TurnosForm
        '
        Me.AllowRecordNavigation = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 260)
        Me.Controls.Add(Me.dtpHoraFin)
        Me.Controls.Add(Me.dtpHoraIni)
        Me.Controls.Add(Me.CiLabel3)
        Me.Controls.Add(Me.CiLabel2)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.txtNombre)
        Me.Name = "TurnosForm"
        Me.Text = "TurnosForm"
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.CiLabel1, 0)
        Me.Controls.SetChildIndex(Me.CiLabel2, 0)
        Me.Controls.SetChildIndex(Me.CiLabel3, 0)
        Me.Controls.SetChildIndex(Me.dtpHoraIni, 0)
        Me.Controls.SetChildIndex(Me.dtpHoraFin, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New TurnoFacade
        LicenseModule = Kernel.Licensing.LicenseModule.Inventory
    End Sub
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents dtpHoraIni As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents dtpHoraFin As Azteca.Windows.Controls.CIDateTimePicker
End Class
