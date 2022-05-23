<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstComercialForm
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
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.chkActivo = New Azteca.Windows.Controls.CICheckBox()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.txtNivel = New Azteca.Windows.Controls.CITextBox()
        Me.txtRuta = New Azteca.Windows.Controls.CITextBox()
        Me.txtPadre = New Azteca.Windows.Ventas.EstructuraComercialSelector()
        Me.grpEstCom = New Azteca.Windows.Controls.CIGroupBox()
        Me.grpEstCom.SuspendLayout()
        Me.SuspendLayout()
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
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(26, 51)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(67, 13)
        Me.CiLabel2.TabIndex = 2
        Me.CiLabel2.Text = "Nodo Padre:"
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(26, 77)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(34, 13)
        Me.CiLabel3.TabIndex = 4
        Me.CiLabel3.Text = "Nivel:"
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.Location = New System.Drawing.Point(26, 103)
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
        Me.chkActivo.Location = New System.Drawing.Point(99, 126)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 8
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(99, 19)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(244, 20)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.UIName = "Nombre"
        '
        'txtNivel
        '
        Me.txtNivel.AutoLock = False
        Me.txtNivel.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNivel.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNivel.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNivel.Location = New System.Drawing.Point(99, 74)
        Me.txtNivel.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNivel.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNivel.Name = "txtNivel"
        Me.txtNivel.ReadOnly = True
        Me.txtNivel.Size = New System.Drawing.Size(70, 20)
        Me.txtNivel.TabIndex = 5
        '
        'txtRuta
        '
        Me.txtRuta.AutoLock = False
        Me.txtRuta.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtRuta.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtRuta.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtRuta.Location = New System.Drawing.Point(99, 100)
        Me.txtRuta.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRuta.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.ReadOnly = True
        Me.txtRuta.Size = New System.Drawing.Size(244, 20)
        Me.txtRuta.TabIndex = 7
        '
        'txtPadre
        '
        Me.txtPadre.AnySite = False
        Me.txtPadre.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtPadre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtPadre.EditorAssembly = "Azteca.VentasWin"
        Me.txtPadre.EditorClass = "Azteca.Windows.Ventas.EstComercialForm"
        Me.txtPadre.EditorTitle = "Editar nodo de estructura comercial..."
        Me.txtPadre.Key = 0
        Me.txtPadre.Linked = False
        Me.txtPadre.Location = New System.Drawing.Point(99, 45)
        Me.txtPadre.Name = "txtPadre"
        Me.txtPadre.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.txtPadre.Size = New System.Drawing.Size(244, 23)
        Me.txtPadre.TabIndex = 3
        '
        'grpEstCom
        '
        Me.grpEstCom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEstCom.Controls.Add(Me.txtNombre)
        Me.grpEstCom.Controls.Add(Me.txtPadre)
        Me.grpEstCom.Controls.Add(Me.CiLabel1)
        Me.grpEstCom.Controls.Add(Me.txtRuta)
        Me.grpEstCom.Controls.Add(Me.CiLabel2)
        Me.grpEstCom.Controls.Add(Me.txtNivel)
        Me.grpEstCom.Controls.Add(Me.CiLabel3)
        Me.grpEstCom.Controls.Add(Me.CiLabel4)
        Me.grpEstCom.Controls.Add(Me.chkActivo)
        Me.grpEstCom.Location = New System.Drawing.Point(257, 78)
        Me.grpEstCom.Name = "grpEstCom"
        Me.grpEstCom.Size = New System.Drawing.Size(349, 261)
        Me.grpEstCom.TabIndex = 37
        Me.grpEstCom.TabStop = False
        '
        'EstComercialForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 374)
        Me.Controls.Add(Me.grpEstCom)
        Me.Name = "EstComercialForm"
        Me.Text = "EstComercialForm"
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
        Facade = New EstructuraComercialFacade
        HierarchyFacade = New EstructuraComercialFacade
    End Sub
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
    Friend WithEvents chkActivo As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtNivel As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtRuta As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtPadre As Azteca.Windows.Ventas.EstructuraComercialSelector
    Friend WithEvents grpEstCom As Azteca.Windows.Controls.CIGroupBox
End Class
