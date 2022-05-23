<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnsamblesForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SelCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboTipoRecurso = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtHorasLabor = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel5 = New Azteca.Windows.Controls.CILabel()
        Me.txtCostoLabor = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel6 = New Azteca.Windows.Controls.CILabel()
        Me.txtHorasMaquina = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.txtCostoMaquina = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.cboTipoUnidadRecepcion = New Azteca.Windows.Inventario.TiposUnidadComboBox()
        Me.cboUnidadRecepcion = New Azteca.Windows.Inventario.UnidadesMedidaComboBox()
        Me.cboTipoUnidadEntrega = New Azteca.Windows.Inventario.TiposUnidadComboBox()
        Me.cboUnidadEntrega = New Azteca.Windows.Inventario.UnidadesMedidaComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 316)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Cuenta"
        '
        'SelCuenta
        '
        Me.SelCuenta.AnySite = False
        Me.SelCuenta.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.SelCuenta.EditorAssembly = "Azteca.ContabilidadWin"
        Me.SelCuenta.EditorClass = "Azteca.Windows.Contabilidad.CuentaForm"
        Me.SelCuenta.EditorTitle = "Editar Cuenta..."
        Me.SelCuenta.Key = 0
        Me.SelCuenta.Linked = False
        Me.SelCuenta.Location = New System.Drawing.Point(121, 316)
        Me.SelCuenta.Name = "SelCuenta"
        Me.SelCuenta.Size = New System.Drawing.Size(361, 23)
        Me.SelCuenta.TabIndex = 41
        Me.SelCuenta.TextWidth = 100
        '
        'txtNombre
        '
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(121, 103)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(361, 20)
        Me.txtNombre.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Nombre"
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(48, 131)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(67, 13)
        Me.CiLabel3.TabIndex = 43
        Me.CiLabel3.Text = "Entrega UM:"
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(33, 158)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(82, 13)
        Me.CiLabel1.TabIndex = 46
        Me.CiLabel1.Text = "Recepcion UM:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(177, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Tipo Recurso"
        '
        'cboTipoRecurso
        '
        Me.cboTipoRecurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoRecurso.FormattingEnabled = True
        Me.cboTipoRecurso.Items.AddRange(New Object() {"MAQUINA", "PERSONA", "GRUPO", "EXTERNO"})
        Me.cboTipoRecurso.Location = New System.Drawing.Point(254, 193)
        Me.cboTipoRecurso.Name = "cboTipoRecurso"
        Me.cboTipoRecurso.Size = New System.Drawing.Size(228, 21)
        Me.cboTipoRecurso.TabIndex = 52
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtHorasLabor)
        Me.GroupBox1.Controls.Add(Me.CiLabel5)
        Me.GroupBox1.Controls.Add(Me.txtCostoLabor)
        Me.GroupBox1.Controls.Add(Me.CiLabel6)
        Me.GroupBox1.Controls.Add(Me.txtHorasMaquina)
        Me.GroupBox1.Controls.Add(Me.CiLabel4)
        Me.GroupBox1.Controls.Add(Me.txtCostoMaquina)
        Me.GroupBox1.Controls.Add(Me.CiLabel2)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 225)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(446, 80)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Costos Estandar"
        '
        'txtHorasLabor
        '
        Me.txtHorasLabor.Digits = True
        Me.txtHorasLabor.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtHorasLabor.Format = "N2"
        Me.txtHorasLabor.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtHorasLabor.Location = New System.Drawing.Point(123, 48)
        Me.txtHorasLabor.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtHorasLabor.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtHorasLabor.Name = "txtHorasLabor"
        Me.txtHorasLabor.Size = New System.Drawing.Size(89, 20)
        Me.txtHorasLabor.TabIndex = 2
        Me.txtHorasLabor.Text = "0"
        '
        'CiLabel5
        '
        Me.CiLabel5.AutoSize = True
        Me.CiLabel5.Location = New System.Drawing.Point(279, 48)
        Me.CiLabel5.Name = "CiLabel5"
        Me.CiLabel5.Size = New System.Drawing.Size(67, 13)
        Me.CiLabel5.TabIndex = 80
        Me.CiLabel5.Text = "Costo Labor:"
        '
        'txtCostoLabor
        '
        Me.txtCostoLabor.Digits = True
        Me.txtCostoLabor.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtCostoLabor.Format = "C2"
        Me.txtCostoLabor.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCostoLabor.Location = New System.Drawing.Point(352, 45)
        Me.txtCostoLabor.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCostoLabor.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCostoLabor.Name = "txtCostoLabor"
        Me.txtCostoLabor.Size = New System.Drawing.Size(88, 20)
        Me.txtCostoLabor.TabIndex = 3
        Me.txtCostoLabor.Text = "0"
        '
        'CiLabel6
        '
        Me.CiLabel6.AutoSize = True
        Me.CiLabel6.Location = New System.Drawing.Point(61, 51)
        Me.CiLabel6.Name = "CiLabel6"
        Me.CiLabel6.Size = New System.Drawing.Size(56, 13)
        Me.CiLabel6.TabIndex = 78
        Me.CiLabel6.Text = "Hrs Labor:"
        '
        'txtHorasMaquina
        '
        Me.txtHorasMaquina.Digits = True
        Me.txtHorasMaquina.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtHorasMaquina.Format = "N2"
        Me.txtHorasMaquina.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtHorasMaquina.Location = New System.Drawing.Point(123, 19)
        Me.txtHorasMaquina.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtHorasMaquina.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtHorasMaquina.Name = "txtHorasMaquina"
        Me.txtHorasMaquina.Size = New System.Drawing.Size(89, 20)
        Me.txtHorasMaquina.TabIndex = 0
        Me.txtHorasMaquina.Text = "0"
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.Location = New System.Drawing.Point(265, 22)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(81, 13)
        Me.CiLabel4.TabIndex = 76
        Me.CiLabel4.Text = "Costo Maquina:"
        '
        'txtCostoMaquina
        '
        Me.txtCostoMaquina.Digits = True
        Me.txtCostoMaquina.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtCostoMaquina.Format = "C2"
        Me.txtCostoMaquina.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCostoMaquina.Location = New System.Drawing.Point(352, 19)
        Me.txtCostoMaquina.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCostoMaquina.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCostoMaquina.Name = "txtCostoMaquina"
        Me.txtCostoMaquina.Size = New System.Drawing.Size(88, 20)
        Me.txtCostoMaquina.TabIndex = 1
        Me.txtCostoMaquina.Text = "0"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(47, 22)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(70, 13)
        Me.CiLabel2.TabIndex = 74
        Me.CiLabel2.Text = "Hrs Maquina:"
        '
        'cboTipoUnidadRecepcion
        '
        Me.cboTipoUnidadRecepcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoUnidadRecepcion.FormattingEnabled = True
        Me.cboTipoUnidadRecepcion.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboTipoUnidadRecepcion.ItemsTable = Nothing
        Me.cboTipoUnidadRecepcion.Location = New System.Drawing.Point(121, 155)
        Me.cboTipoUnidadRecepcion.Name = "cboTipoUnidadRecepcion"
        Me.cboTipoUnidadRecepcion.Size = New System.Drawing.Size(127, 21)
        Me.cboTipoUnidadRecepcion.TabIndex = 47
        Me.cboTipoUnidadRecepcion.UIName = Nothing
        '
        'cboUnidadRecepcion
        '
        Me.cboUnidadRecepcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnidadRecepcion.FormattingEnabled = True
        Me.cboUnidadRecepcion.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboUnidadRecepcion.ItemsTable = Nothing
        Me.cboUnidadRecepcion.Location = New System.Drawing.Point(254, 155)
        Me.cboUnidadRecepcion.Name = "cboUnidadRecepcion"
        Me.cboUnidadRecepcion.RequiredField = True
        Me.cboUnidadRecepcion.Size = New System.Drawing.Size(228, 21)
        Me.cboUnidadRecepcion.TabIndex = 48
        Me.cboUnidadRecepcion.UIName = "Unidad Medida"
        '
        'cboTipoUnidadEntrega
        '
        Me.cboTipoUnidadEntrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoUnidadEntrega.FormattingEnabled = True
        Me.cboTipoUnidadEntrega.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboTipoUnidadEntrega.ItemsTable = Nothing
        Me.cboTipoUnidadEntrega.Location = New System.Drawing.Point(121, 128)
        Me.cboTipoUnidadEntrega.Name = "cboTipoUnidadEntrega"
        Me.cboTipoUnidadEntrega.Size = New System.Drawing.Size(127, 21)
        Me.cboTipoUnidadEntrega.TabIndex = 44
        Me.cboTipoUnidadEntrega.UIName = Nothing
        '
        'cboUnidadEntrega
        '
        Me.cboUnidadEntrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnidadEntrega.FormattingEnabled = True
        Me.cboUnidadEntrega.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboUnidadEntrega.ItemsTable = Nothing
        Me.cboUnidadEntrega.Location = New System.Drawing.Point(254, 128)
        Me.cboUnidadEntrega.Name = "cboUnidadEntrega"
        Me.cboUnidadEntrega.RequiredField = True
        Me.cboUnidadEntrega.Size = New System.Drawing.Size(228, 21)
        Me.cboUnidadEntrega.TabIndex = 45
        Me.cboUnidadEntrega.UIName = "Unidad Medida"
        '
        'EnsamblesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 380)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cboTipoRecurso)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.cboTipoUnidadRecepcion)
        Me.Controls.Add(Me.cboUnidadRecepcion)
        Me.Controls.Add(Me.CiLabel3)
        Me.Controls.Add(Me.cboTipoUnidadEntrega)
        Me.Controls.Add(Me.cboUnidadEntrega)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SelCuenta)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EnsamblesForm"
        Me.Text = "EnsamblesForm"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.SelCuenta, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.cboUnidadEntrega, 0)
        Me.Controls.SetChildIndex(Me.cboTipoUnidadEntrega, 0)
        Me.Controls.SetChildIndex(Me.CiLabel3, 0)
        Me.Controls.SetChildIndex(Me.cboUnidadRecepcion, 0)
        Me.Controls.SetChildIndex(Me.cboTipoUnidadRecepcion, 0)
        Me.Controls.SetChildIndex(Me.CiLabel1, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.cboTipoRecurso, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Facade = New EnsambleFacade
    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SelCuenta As Azteca.Windows.Contabilidad.CuentaSelector
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Public WithEvents cboTipoUnidadEntrega As Azteca.Windows.Inventario.TiposUnidadComboBox
    Public WithEvents cboUnidadEntrega As Azteca.Windows.Inventario.UnidadesMedidaComboBox
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Public WithEvents cboTipoUnidadRecepcion As Azteca.Windows.Inventario.TiposUnidadComboBox
    Public WithEvents cboUnidadRecepcion As Azteca.Windows.Inventario.UnidadesMedidaComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboTipoRecurso As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtHorasLabor As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel5 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCostoLabor As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel6 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtHorasMaquina As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCostoMaquina As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel



End Class
