<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FlujoForm
    Inherits Azteca.Windows.Forms.BusinessForms.HierarchyForm

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
        Me.grpCuenta = New Azteca.Windows.Controls.CIGroupBox()
        Me.selPadre = New Azteca.Windows.Contabilidad.FlujoSelector()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.lblPadre = New Azteca.Windows.Controls.CILabel()
        Me.cboTipo = New Azteca.Windows.Controls.CIComboBox()
        Me.lblTipo = New Azteca.Windows.Controls.CILabel()
        Me.lblNombre = New Azteca.Windows.Controls.CILabel()
        Me.txtNivel = New Azteca.Windows.Controls.CITextBox()
        Me.lblPath = New Azteca.Windows.Controls.CILabel()
        Me.txtPath = New Azteca.Windows.Controls.CITextBox()
        Me.lblNivel = New Azteca.Windows.Controls.CILabel()
        Me.grpCuenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCuenta
        '
        Me.grpCuenta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCuenta.Controls.Add(Me.selPadre)
        Me.grpCuenta.Controls.Add(Me.txtNombre)
        Me.grpCuenta.Controls.Add(Me.lblPadre)
        Me.grpCuenta.Controls.Add(Me.cboTipo)
        Me.grpCuenta.Controls.Add(Me.lblTipo)
        Me.grpCuenta.Controls.Add(Me.lblNombre)
        Me.grpCuenta.Controls.Add(Me.txtNivel)
        Me.grpCuenta.Controls.Add(Me.lblPath)
        Me.grpCuenta.Controls.Add(Me.txtPath)
        Me.grpCuenta.Controls.Add(Me.lblNivel)
        Me.grpCuenta.Location = New System.Drawing.Point(261, 87)
        Me.grpCuenta.Name = "grpCuenta"
        Me.grpCuenta.Size = New System.Drawing.Size(407, 252)
        Me.grpCuenta.TabIndex = 49
        Me.grpCuenta.TabStop = False
        '
        'selPadre
        '
        Me.selPadre.AnySite = False
        Me.selPadre.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selPadre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.selPadre.EditorAssembly = "Azteca.ContabilidadWin"
        Me.selPadre.EditorClass = "Azteca.Windows.Contabilidad.FlujoForm"
        Me.selPadre.EditorTitle = "Editar nodo de Flujo..."
        Me.selPadre.Key = 0
        Me.selPadre.Linked = False
        Me.selPadre.Location = New System.Drawing.Point(85, 69)
        Me.selPadre.Name = "selPadre"
        Me.selPadre.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selPadre.Size = New System.Drawing.Size(231, 23)
        Me.selPadre.TabIndex = 48
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(85, 19)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(299, 20)
        Me.txtNombre.TabIndex = 16
        '
        'lblPadre
        '
        Me.lblPadre.AutoSize = True
        Me.lblPadre.Location = New System.Drawing.Point(17, 75)
        Me.lblPadre.Name = "lblPadre"
        Me.lblPadre.Size = New System.Drawing.Size(67, 13)
        Me.lblPadre.TabIndex = 43
        Me.lblPadre.Text = "Nodo Padre:"
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboTipo.Items.AddRange(New Object() {"Ingresos", "Egresos"})
        Me.cboTipo.ItemsTable = Nothing
        Me.cboTipo.Location = New System.Drawing.Point(85, 44)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.RequiredField = True
        Me.cboTipo.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboTipo.Size = New System.Drawing.Size(162, 21)
        Me.cboTipo.TabIndex = 18
        Me.cboTipo.UIName = Nothing
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(17, 47)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(28, 13)
        Me.lblTipo.TabIndex = 40
        Me.lblTipo.Text = "Tipo"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(17, 22)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 37
        Me.lblNombre.Text = "Nombre"
        '
        'txtNivel
        '
        Me.txtNivel.AutoLock = False
        Me.txtNivel.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNivel.Digits = True
        Me.txtNivel.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNivel.Enabled = False
        Me.txtNivel.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNivel.Location = New System.Drawing.Point(85, 179)
        Me.txtNivel.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNivel.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNivel.Name = "txtNivel"
        Me.txtNivel.ReadOnly = True
        Me.txtNivel.Size = New System.Drawing.Size(65, 20)
        Me.txtNivel.TabIndex = 47
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Location = New System.Drawing.Point(17, 103)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(32, 13)
        Me.lblPath.TabIndex = 44
        Me.lblPath.Text = "Path:"
        '
        'txtPath
        '
        Me.txtPath.AutoLock = False
        Me.txtPath.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtPath.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtPath.Enabled = False
        Me.txtPath.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtPath.Location = New System.Drawing.Point(85, 98)
        Me.txtPath.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPath.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPath.Multiline = True
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(299, 74)
        Me.txtPath.TabIndex = 45
        '
        'lblNivel
        '
        Me.lblNivel.AutoSize = True
        Me.lblNivel.Location = New System.Drawing.Point(17, 181)
        Me.lblNivel.Name = "lblNivel"
        Me.lblNivel.Size = New System.Drawing.Size(34, 13)
        Me.lblNivel.TabIndex = 46
        Me.lblNivel.Text = "Nivel:"
        '
        'FlujoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 374)
        Me.Controls.Add(Me.grpCuenta)
        Me.Name = "FlujoForm"
        Me.Text = "FlujoForm"
        Me.Controls.SetChildIndex(Me.grpCuenta, 0)
        Me.grpCuenta.ResumeLayout(False)
        Me.grpCuenta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpCuenta As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblPadre As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboTipo As Azteca.Windows.Controls.CIComboBox
    Friend WithEvents lblTipo As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblNombre As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNivel As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblPath As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtPath As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblNivel As Azteca.Windows.Controls.CILabel

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Facade = New Azteca.Business.Contabilidad.FlujoFacade
        Me.HierarchyFacade = New Azteca.Business.Contabilidad.FlujoFacade
        LicenseModule = Kernel.Licensing.LicenseModule.Accounting

    End Sub
    Friend WithEvents selPadre As Azteca.Windows.Contabilidad.FlujoSelector

End Class
