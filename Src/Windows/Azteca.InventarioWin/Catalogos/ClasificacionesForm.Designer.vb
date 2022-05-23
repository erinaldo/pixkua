<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClasificacionesForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClasificacionesForm))
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.chkRequerido = New Azteca.Windows.Controls.CICheckBox()
        Me.cboEntidad = New Azteca.Windows.Controls.CIComboBox()
        Me.bsClasificaciones = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdClasificaciones = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.tabClasificaciones = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagClasificaciones = New C1.Win.C1Command.C1DockingTabPage()
        CType(Me.bsClasificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdClasificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabClasificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabClasificaciones.SuspendLayout()
        Me.pagClasificaciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(13, 125)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(39, 13)
        Me.CiLabel1.TabIndex = 2
        Me.CiLabel1.Text = "Grupo:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(65, 122)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(225, 20)
        Me.txtNombre.TabIndex = 3
        Me.txtNombre.UIName = "Nombre"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(13, 98)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(46, 13)
        Me.CiLabel2.TabIndex = 0
        Me.CiLabel2.Text = "Entidad:"
        '
        'chkRequerido
        '
        Me.chkRequerido.AutoSize = True
        Me.chkRequerido.Location = New System.Drawing.Point(339, 97)
        Me.chkRequerido.Name = "chkRequerido"
        Me.chkRequerido.Size = New System.Drawing.Size(75, 17)
        Me.chkRequerido.TabIndex = 4
        Me.chkRequerido.Text = "Requerido"
        Me.chkRequerido.UseVisualStyleBackColor = True
        '
        'cboEntidad
        '
        Me.cboEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEntidad.FormattingEnabled = True
        Me.cboEntidad.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboEntidad.ItemsTable = Nothing
        Me.cboEntidad.Location = New System.Drawing.Point(65, 95)
        Me.cboEntidad.Name = "cboEntidad"
        Me.cboEntidad.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboEntidad.Size = New System.Drawing.Size(225, 21)
        Me.cboEntidad.TabIndex = 1
        Me.cboEntidad.UIName = Nothing
        '
        'grdClasificaciones
        '
        Me.grdClasificaciones.AllowAddNew = True
        Me.grdClasificaciones.AllowDelete = True
        Me.grdClasificaciones.DataSource = Me.bsClasificaciones
        Me.grdClasificaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdClasificaciones.ExtendRightColumn = True
        Me.grdClasificaciones.Images.Add(CType(resources.GetObject("grdClasificaciones.Images"), System.Drawing.Image))
        Me.grdClasificaciones.Images.Add(CType(resources.GetObject("grdClasificaciones.Images1"), System.Drawing.Image))
        Me.grdClasificaciones.Location = New System.Drawing.Point(0, 0)
        Me.grdClasificaciones.Name = "grdClasificaciones"
        Me.grdClasificaciones.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdClasificaciones.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdClasificaciones.PreviewInfo.ZoomFactor = 75.0R
        Me.grdClasificaciones.PrintInfo.PageSettings = CType(resources.GetObject("grdClasificaciones.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdClasificaciones.Size = New System.Drawing.Size(699, 173)
        Me.grdClasificaciones.TabIndex = 6
        Me.grdClasificaciones.Text = "AzTrueDBGrid1"
        Me.grdClasificaciones.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdClasificaciones.PropBag = resources.GetString("grdClasificaciones.PropBag")
        '
        'tabClasificaciones
        '
        Me.tabClasificaciones.Controls.Add(Me.pagClasificaciones)
        Me.tabClasificaciones.Location = New System.Drawing.Point(12, 148)
        Me.tabClasificaciones.Name = "tabClasificaciones"
        Me.tabClasificaciones.Size = New System.Drawing.Size(701, 198)
        Me.tabClasificaciones.TabIndex = 32
        Me.tabClasificaciones.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabClasificaciones.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabClasificaciones.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagClasificaciones
        '
        Me.pagClasificaciones.Controls.Add(Me.grdClasificaciones)
        Me.pagClasificaciones.Location = New System.Drawing.Point(1, 24)
        Me.pagClasificaciones.Name = "pagClasificaciones"
        Me.pagClasificaciones.Size = New System.Drawing.Size(699, 173)
        Me.pagClasificaciones.TabIndex = 0
        Me.pagClasificaciones.Text = "Clasificaciones"
        '
        'ClasificacionesForm
        '
        Me.AllowRecordNavigation = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 374)
        Me.Controls.Add(Me.tabClasificaciones)
        Me.Controls.Add(Me.cboEntidad)
        Me.Controls.Add(Me.chkRequerido)
        Me.Controls.Add(Me.CiLabel2)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.txtNombre)
        Me.Name = "ClasificacionesForm"
        Me.Text = "ClasificacionesForm"
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.CiLabel1, 0)
        Me.Controls.SetChildIndex(Me.CiLabel2, 0)
        Me.Controls.SetChildIndex(Me.chkRequerido, 0)
        Me.Controls.SetChildIndex(Me.cboEntidad, 0)
        Me.Controls.SetChildIndex(Me.tabClasificaciones, 0)
        CType(Me.bsClasificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdClasificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabClasificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabClasificaciones.ResumeLayout(False)
        Me.pagClasificaciones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New GrupoClasificacionesFacade
        LicenseModule = Kernel.Licensing.LicenseModule.Inventory
    End Sub
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents chkRequerido As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents cboEntidad As Azteca.Windows.Controls.CIComboBox
    Friend WithEvents bsClasificaciones As System.Windows.Forms.BindingSource
    Friend WithEvents grdClasificaciones As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents tabClasificaciones As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagClasificaciones As C1.Win.C1Command.C1DockingTabPage
End Class
