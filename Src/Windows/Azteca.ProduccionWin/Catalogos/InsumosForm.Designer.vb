<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsumosForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InsumosForm))
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.txtDescripcion = New Azteca.Windows.Controls.CITextBox()
        Me.selCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.lblCuenta = New Azteca.Windows.Controls.CILabel()
        Me.gbxDetalle = New Azteca.Windows.Controls.CIGroupBox()
        Me.grdArt = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.tbMenu = New Azteca.Windows.Controls.CIToolBar()
        Me.btnNuevoArt = New System.Windows.Forms.ToolStripButton()
        Me.lblUnidadMedida = New Azteca.Windows.Controls.CILabel()
        Me.bsArticulos = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboUnidadMedida = New Azteca.Windows.Inventario.UnidadesMedidaComboBox()
        Me.gbxDetalle.SuspendLayout()
        CType(Me.grdArt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbMenu.SuspendLayout()
        CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(79, 98)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(41, 13)
        Me.CiLabel1.TabIndex = 19
        Me.CiLabel1.Text = "Insumo"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtDescripcion.Location = New System.Drawing.Point(126, 95)
        Me.txtDescripcion.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDescripcion.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(372, 20)
        Me.txtDescripcion.TabIndex = 20
        '
        'selCuenta
        '
        Me.selCuenta.AnySite = False
        Me.selCuenta.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selCuenta.EditorAssembly = "Azteca.ContabilidadWin"
        Me.selCuenta.EditorClass = "Azteca.Windows.Contabilidad.CuentaForm"
        Me.selCuenta.EditorTitle = "Editar Cuenta..."
        Me.selCuenta.Key = 0
        Me.selCuenta.Linked = False
        Me.selCuenta.Location = New System.Drawing.Point(126, 147)
        Me.selCuenta.Name = "selCuenta"
        Me.selCuenta.Size = New System.Drawing.Size(372, 23)
        Me.selCuenta.TabIndex = 29
        Me.selCuenta.TextWidth = 100
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Location = New System.Drawing.Point(79, 150)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(41, 13)
        Me.lblCuenta.TabIndex = 30
        Me.lblCuenta.Text = "Cuenta"
        '
        'gbxDetalle
        '
        Me.gbxDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxDetalle.Controls.Add(Me.grdArt)
        Me.gbxDetalle.Controls.Add(Me.tbMenu)
        Me.gbxDetalle.Location = New System.Drawing.Point(5, 171)
        Me.gbxDetalle.Name = "gbxDetalle"
        Me.gbxDetalle.Size = New System.Drawing.Size(527, 295)
        Me.gbxDetalle.TabIndex = 31
        Me.gbxDetalle.TabStop = False
        '
        'grdArt
        '
        Me.grdArt.AlternatingRows = True
        Me.grdArt.DataSource = Me.bsArticulos
        Me.grdArt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdArt.Images.Add(CType(resources.GetObject("grdArt.Images"), System.Drawing.Image))
        Me.grdArt.Location = New System.Drawing.Point(3, 55)
        Me.grdArt.Name = "grdArt"
        Me.grdArt.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdArt.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdArt.PreviewInfo.ZoomFactor = 75.0R
        Me.grdArt.PrintInfo.PageSettings = CType(resources.GetObject("grdArt.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdArt.ShowEditButton = False
        Me.grdArt.Size = New System.Drawing.Size(521, 237)
        Me.grdArt.TabIndex = 27
        Me.grdArt.PropBag = resources.GetString("grdArt.PropBag")
        '
        'tbMenu
        '
        Me.tbMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoArt})
        Me.tbMenu.Location = New System.Drawing.Point(3, 16)
        Me.tbMenu.Name = "tbMenu"
        Me.tbMenu.Size = New System.Drawing.Size(521, 39)
        Me.tbMenu.TabIndex = 28
        Me.tbMenu.Text = "CiToolBar1"
        '
        'btnNuevoArt
        '
        Me.btnNuevoArt.Image = CType(resources.GetObject("btnNuevoArt.Image"), System.Drawing.Image)
        Me.btnNuevoArt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevoArt.Name = "btnNuevoArt"
        Me.btnNuevoArt.Size = New System.Drawing.Size(162, 36)
        Me.btnNuevoArt.Text = "Incluir articulo insumo"
        '
        'lblUnidadMedida
        '
        Me.lblUnidadMedida.AutoSize = True
        Me.lblUnidadMedida.Location = New System.Drawing.Point(12, 123)
        Me.lblUnidadMedida.Name = "lblUnidadMedida"
        Me.lblUnidadMedida.Size = New System.Drawing.Size(108, 13)
        Me.lblUnidadMedida.TabIndex = 33
        Me.lblUnidadMedida.Text = "Medida de Utilización"
        '
        'cboUnidadMedida
        '
        Me.cboUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnidadMedida.FormattingEnabled = True
        Me.cboUnidadMedida.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboUnidadMedida.ItemsTable = Nothing
        Me.cboUnidadMedida.Location = New System.Drawing.Point(126, 121)
        Me.cboUnidadMedida.Name = "cboUnidadMedida"
        Me.cboUnidadMedida.Size = New System.Drawing.Size(372, 21)
        Me.cboUnidadMedida.TabIndex = 34
        Me.cboUnidadMedida.UIName = Nothing
        '
        'InsumosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 480)
        Me.Controls.Add(Me.cboUnidadMedida)
        Me.Controls.Add(Me.lblUnidadMedida)
        Me.Controls.Add(Me.gbxDetalle)
        Me.Controls.Add(Me.lblCuenta)
        Me.Controls.Add(Me.selCuenta)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Name = "InsumosForm"
        Me.Text = "InsumosForm"
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.CiLabel1, 0)
        Me.Controls.SetChildIndex(Me.selCuenta, 0)
        Me.Controls.SetChildIndex(Me.lblCuenta, 0)
        Me.Controls.SetChildIndex(Me.gbxDetalle, 0)
        Me.Controls.SetChildIndex(Me.lblUnidadMedida, 0)
        Me.Controls.SetChildIndex(Me.cboUnidadMedida, 0)
        Me.gbxDetalle.ResumeLayout(False)
        Me.gbxDetalle.PerformLayout()
        CType(Me.grdArt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbMenu.ResumeLayout(False)
        Me.tbMenu.PerformLayout()
        CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Facade = New InsumoFacade
        LicenseModule = Kernel.Licensing.LicenseModule.Manufacturing
    End Sub
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtDescripcion As Azteca.Windows.Controls.CITextBox
    Friend WithEvents selCuenta As Azteca.Windows.Contabilidad.CuentaSelector
    Friend WithEvents lblCuenta As Azteca.Windows.Controls.CILabel
    Friend WithEvents gbxDetalle As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents grdArt As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents tbMenu As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnNuevoArt As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblUnidadMedida As Azteca.Windows.Controls.CILabel
    Friend WithEvents bsArticulos As System.Windows.Forms.BindingSource
    Friend WithEvents cboUnidadMedida As Azteca.Windows.Inventario.UnidadesMedidaComboBox
End Class
