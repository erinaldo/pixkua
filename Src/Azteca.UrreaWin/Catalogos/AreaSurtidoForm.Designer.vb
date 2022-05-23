Imports Azteca.Business.Urrea

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AreaSurtidoForm
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

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New AreaSurtidoFacade
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.txtCapacidadHoraXUsuario = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.numCantUsuariosDef = New System.Windows.Forms.NumericUpDown()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.cboIdGrupoAreaSurtido = New Azteca.Windows.Urrea.GrupoAreasSurtido()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        CType(Me.numCantUsuariosDef, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(121, 114)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(249, 20)
        Me.txtNombre.TabIndex = 0
        Me.txtNombre.UIName = "Nombre"
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(68, 117)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(47, 13)
        Me.CiLabel1.TabIndex = 54
        Me.CiLabel1.Text = "Nombre:"
        '
        'txtCapacidadHoraXUsuario
        '
        Me.txtCapacidadHoraXUsuario.BackColor = System.Drawing.SystemColors.Window
        Me.txtCapacidadHoraXUsuario.Digits = True
        Me.txtCapacidadHoraXUsuario.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCapacidadHoraXUsuario.Location = New System.Drawing.Point(121, 143)
        Me.txtCapacidadHoraXUsuario.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCapacidadHoraXUsuario.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCapacidadHoraXUsuario.Name = "txtCapacidadHoraXUsuario"
        Me.txtCapacidadHoraXUsuario.RequiredField = True
        Me.txtCapacidadHoraXUsuario.Size = New System.Drawing.Size(73, 20)
        Me.txtCapacidadHoraXUsuario.TabIndex = 1
        Me.txtCapacidadHoraXUsuario.UIName = "Nombre"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(30, 146)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(85, 13)
        Me.CiLabel2.TabIndex = 56
        Me.CiLabel2.Text = "CapacidaXHora:"
        '
        'numCantUsuariosDef
        '
        Me.numCantUsuariosDef.Location = New System.Drawing.Point(297, 144)
        Me.numCantUsuariosDef.Name = "numCantUsuariosDef"
        Me.numCantUsuariosDef.Size = New System.Drawing.Size(73, 20)
        Me.numCantUsuariosDef.TabIndex = 2
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(211, 146)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(79, 13)
        Me.CiLabel3.TabIndex = 58
        Me.CiLabel3.Text = "Cant. Usuarios:"
        '
        'cboIdGrupoAreaSurtido
        '
        Me.cboIdGrupoAreaSurtido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIdGrupoAreaSurtido.FormattingEnabled = True
        Me.cboIdGrupoAreaSurtido.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboIdGrupoAreaSurtido.ItemsTable = Nothing
        Me.cboIdGrupoAreaSurtido.Location = New System.Drawing.Point(121, 173)
        Me.cboIdGrupoAreaSurtido.Name = "cboIdGrupoAreaSurtido"
        Me.cboIdGrupoAreaSurtido.Size = New System.Drawing.Size(249, 21)
        Me.cboIdGrupoAreaSurtido.TabIndex = 3
        Me.cboIdGrupoAreaSurtido.UIName = Nothing
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.Location = New System.Drawing.Point(76, 176)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(39, 13)
        Me.CiLabel4.TabIndex = 60
        Me.CiLabel4.Text = "Grupo:"
        '
        'AreaSurtidoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 255)
        Me.Controls.Add(Me.CiLabel4)
        Me.Controls.Add(Me.cboIdGrupoAreaSurtido)
        Me.Controls.Add(Me.CiLabel3)
        Me.Controls.Add(Me.numCantUsuariosDef)
        Me.Controls.Add(Me.CiLabel2)
        Me.Controls.Add(Me.txtCapacidadHoraXUsuario)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.CiLabel1)
        Me.KeyMode = Azteca.Windows.Forms.BusinessForms.CatalogForm.UserKeyMode.UserDefined
        Me.Name = "AreaSurtidoForm"
        Me.Text = "AreaSurtidoForm"
        Me.Controls.SetChildIndex(Me.CiLabel1, 0)
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.txtCapacidadHoraXUsuario, 0)
        Me.Controls.SetChildIndex(Me.CiLabel2, 0)
        Me.Controls.SetChildIndex(Me.numCantUsuariosDef, 0)
        Me.Controls.SetChildIndex(Me.CiLabel3, 0)
        Me.Controls.SetChildIndex(Me.cboIdGrupoAreaSurtido, 0)
        Me.Controls.SetChildIndex(Me.CiLabel4, 0)
        CType(Me.numCantUsuariosDef, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCapacidadHoraXUsuario As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents numCantUsuariosDef As System.Windows.Forms.NumericUpDown
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboIdGrupoAreaSurtido As Azteca.Windows.Urrea.GrupoAreasSurtido
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
End Class
