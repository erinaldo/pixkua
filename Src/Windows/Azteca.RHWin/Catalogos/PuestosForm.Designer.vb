<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PuestosForm
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
        Me.grpEstCom = New Azteca.Windows.Controls.CIGroupBox()
        Me.lblCuenta = New Azteca.Windows.Controls.CILabel()
        Me.selCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.selPuesto = New Azteca.Windows.RH.PuestoSelector()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.txtRuta = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.txtNivel = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.chkActivo = New Azteca.Windows.Controls.CICheckBox()
        Me.grpEstCom.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpEstCom
        '
        Me.grpEstCom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEstCom.Controls.Add(Me.lblCuenta)
        Me.grpEstCom.Controls.Add(Me.selCuenta)
        Me.grpEstCom.Controls.Add(Me.selPuesto)
        Me.grpEstCom.Controls.Add(Me.txtNombre)
        Me.grpEstCom.Controls.Add(Me.CiLabel1)
        Me.grpEstCom.Controls.Add(Me.txtRuta)
        Me.grpEstCom.Controls.Add(Me.CiLabel2)
        Me.grpEstCom.Controls.Add(Me.txtNivel)
        Me.grpEstCom.Controls.Add(Me.CiLabel3)
        Me.grpEstCom.Controls.Add(Me.CiLabel4)
        Me.grpEstCom.Controls.Add(Me.chkActivo)
        Me.grpEstCom.Location = New System.Drawing.Point(276, 76)
        Me.grpEstCom.Name = "grpEstCom"
        Me.grpEstCom.Size = New System.Drawing.Size(419, 271)
        Me.grpEstCom.TabIndex = 38
        Me.grpEstCom.TabStop = False
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Location = New System.Drawing.Point(23, 118)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(41, 13)
        Me.lblCuenta.TabIndex = 27
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
        Me.selCuenta.Location = New System.Drawing.Point(70, 112)
        Me.selCuenta.Name = "selCuenta"
        Me.selCuenta.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selCuenta.Size = New System.Drawing.Size(110, 23)
        Me.selCuenta.TabIndex = 26
        '
        'selPuesto
        '
        Me.selPuesto.AnySite = False
        Me.selPuesto.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selPuesto.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.selPuesto.EditorAssembly = "Azteca.RHWin"
        Me.selPuesto.EditorClass = "Azteca.Windows.RH.PuestosForm"
        Me.selPuesto.EditorTitle = "Editar nodo de estructura comercial..."
        Me.selPuesto.Key = 0
        Me.selPuesto.Linked = False
        Me.selPuesto.Location = New System.Drawing.Point(70, 42)
        Me.selPuesto.Name = "selPuesto"
        Me.selPuesto.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selPuesto.Size = New System.Drawing.Size(110, 23)
        Me.selPuesto.TabIndex = 9
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(70, 19)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(177, 20)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.UIName = "Nombre"
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(26, 22)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(47, 13)
        Me.CiLabel1.TabIndex = 0
        Me.CiLabel1.Text = "Nombre:"
        '
        'txtRuta
        '
        Me.txtRuta.AutoLock = False
        Me.txtRuta.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtRuta.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtRuta.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtRuta.Location = New System.Drawing.Point(70, 89)
        Me.txtRuta.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRuta.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.ReadOnly = True
        Me.txtRuta.Size = New System.Drawing.Size(148, 20)
        Me.txtRuta.TabIndex = 7
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(6, 47)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(67, 13)
        Me.CiLabel2.TabIndex = 2
        Me.CiLabel2.Text = "Nodo Padre:"
        '
        'txtNivel
        '
        Me.txtNivel.AutoLock = False
        Me.txtNivel.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNivel.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNivel.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNivel.Location = New System.Drawing.Point(70, 67)
        Me.txtNivel.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNivel.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNivel.Name = "txtNivel"
        Me.txtNivel.ReadOnly = True
        Me.txtNivel.Size = New System.Drawing.Size(70, 20)
        Me.txtNivel.TabIndex = 5
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(39, 70)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(34, 13)
        Me.CiLabel3.TabIndex = 4
        Me.CiLabel3.Text = "Nivel:"
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.Location = New System.Drawing.Point(40, 95)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(33, 13)
        Me.CiLabel4.TabIndex = 6
        Me.CiLabel4.Text = "Ruta:"
        '
        'chkActivo
        '
        Me.chkActivo.AutoClear = False
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.Location = New System.Drawing.Point(70, 154)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 8
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'PuestosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 379)
        Me.Controls.Add(Me.grpEstCom)
        Me.Name = "PuestosForm"
        Me.Text = "PuestosForm"
        Me.Controls.SetChildIndex(Me.grpEstCom, 0)
        Me.grpEstCom.ResumeLayout(False)
        Me.grpEstCom.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New PuestoFacade
        HierarchyFacade = New PuestoFacade
    End Sub
    Friend WithEvents grpEstCom As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtRuta As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNivel As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
    Friend WithEvents chkActivo As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents selPuesto As Azteca.Windows.RH.PuestoSelector
    Friend WithEvents lblCuenta As Azteca.Windows.Controls.CILabel
    Friend WithEvents selCuenta As Azteca.Windows.Contabilidad.CuentaSelector
End Class
