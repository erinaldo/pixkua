<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClasificacionesForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClasificacionesForm))
        Me.grdClasificaciones = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.cboEntidad = New Azteca.Windows.Controls.CIComboBox()
        Me.chkRequerido = New Azteca.Windows.Controls.CICheckBox()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.chkActivo = New Azteca.Windows.Controls.CICheckBox()
        Me.bsClasificaciones = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grdClasificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsClasificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdClasificaciones
        '
        Me.grdClasificaciones.AllowAddNew = True
        Me.grdClasificaciones.AllowDelete = True
        Me.grdClasificaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdClasificaciones.DataSource = Me.bsClasificaciones
        Me.grdClasificaciones.ExtendRightColumn = True
        Me.grdClasificaciones.Images.Add(CType(resources.GetObject("grdClasificaciones.Images"), System.Drawing.Image))
        Me.grdClasificaciones.Images.Add(CType(resources.GetObject("grdClasificaciones.Images1"), System.Drawing.Image))
        Me.grdClasificaciones.Location = New System.Drawing.Point(11, 138)
        Me.grdClasificaciones.Name = "grdClasificaciones"
        Me.grdClasificaciones.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdClasificaciones.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdClasificaciones.PreviewInfo.ZoomFactor = 75.0R
        Me.grdClasificaciones.PrintInfo.PageSettings = CType(resources.GetObject("grdClasificaciones.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdClasificaciones.Size = New System.Drawing.Size(750, 253)
        Me.grdClasificaciones.TabIndex = 25
        Me.grdClasificaciones.Text = "AzTrueDBGrid1"
        Me.grdClasificaciones.PropBag = resources.GetString("grdClasificaciones.PropBag")
        '
        'cboEntidad
        '
        Me.cboEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEntidad.FormattingEnabled = True
        Me.cboEntidad.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboEntidad.ItemsTable = Nothing
        Me.cboEntidad.Location = New System.Drawing.Point(71, 82)
        Me.cboEntidad.Name = "cboEntidad"
        Me.cboEntidad.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboEntidad.Size = New System.Drawing.Size(212, 21)
        Me.cboEntidad.TabIndex = 20
        Me.cboEntidad.UIName = Nothing
        '
        'chkRequerido
        '
        Me.chkRequerido.AutoSize = True
        Me.chkRequerido.Location = New System.Drawing.Point(299, 84)
        Me.chkRequerido.Name = "chkRequerido"
        Me.chkRequerido.Size = New System.Drawing.Size(75, 17)
        Me.chkRequerido.TabIndex = 23
        Me.chkRequerido.Text = "Requerido"
        Me.chkRequerido.UseVisualStyleBackColor = True
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(19, 85)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(46, 13)
        Me.CiLabel2.TabIndex = 19
        Me.CiLabel2.Text = "Entidad:"
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(19, 112)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(39, 13)
        Me.CiLabel1.TabIndex = 21
        Me.CiLabel1.Text = "Grupo:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(71, 109)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(212, 20)
        Me.txtNombre.TabIndex = 22
        Me.txtNombre.UIName = "Nombre"
        '
        'chkActivo
        '
        Me.chkActivo.AutoClear = False
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.Location = New System.Drawing.Point(299, 107)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 24
        Me.chkActivo.Text = "Activa"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'ClasificacionesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 426)
        Me.Controls.Add(Me.grdClasificaciones)
        Me.Controls.Add(Me.cboEntidad)
        Me.Controls.Add(Me.chkRequerido)
        Me.Controls.Add(Me.CiLabel2)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.chkActivo)
        Me.Name = "ClasificacionesForm"
        Me.Text = "ClasificacionesForm"
        Me.Controls.SetChildIndex(Me.chkActivo, 0)
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.CiLabel1, 0)
        Me.Controls.SetChildIndex(Me.CiLabel2, 0)
        Me.Controls.SetChildIndex(Me.chkRequerido, 0)
        Me.Controls.SetChildIndex(Me.cboEntidad, 0)
        Me.Controls.SetChildIndex(Me.grdClasificaciones, 0)
        CType(Me.grdClasificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsClasificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdClasificaciones As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents cboEntidad As Azteca.Windows.Controls.CIComboBox
    Friend WithEvents chkRequerido As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents chkActivo As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents bsClasificaciones As System.Windows.Forms.BindingSource

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Facade = New GrupoClasificacionesFacade
        LicenseModule = Kernel.Licensing.LicenseModule.Sales
    End Sub
End Class
