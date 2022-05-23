<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CajasForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CajasForm))
        Me.lblCuenta = New Azteca.Windows.Controls.CILabel()
        Me.selCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.lblNombre = New Azteca.Windows.Controls.CILabel()
        Me.imlCajas = New System.Windows.Forms.ImageList(Me.components)
        Me.gbxAccesos = New Azteca.Windows.Controls.CIGroupBox()
        Me.grdAccesos = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsAccesos = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbAccesos = New Azteca.Windows.Controls.CIToolBar()
        Me.btnRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnUsuariosAdd = New System.Windows.Forms.ToolStripButton()
        Me.cboChequera = New Azteca.Windows.Tesoreria.ChequerasComboBox()
        Me.lblPredeterminada = New Azteca.Windows.Controls.CILabel()
        Me.iLst = New System.Windows.Forms.ImageList(Me.components)
        Me.tabCajas = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagAccesos = New C1.Win.C1Command.C1DockingTabPage()
        Me.gbxAccesos.SuspendLayout()
        CType(Me.grdAccesos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAccesos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbAccesos.SuspendLayout()
        CType(Me.tabCajas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCajas.SuspendLayout()
        Me.pagAccesos.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Location = New System.Drawing.Point(55, 147)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(44, 13)
        Me.lblCuenta.TabIndex = 32
        Me.lblCuenta.Text = "Cuenta:"
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
        Me.selCuenta.Location = New System.Drawing.Point(189, 147)
        Me.selCuenta.Name = "selCuenta"
        Me.selCuenta.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selCuenta.Size = New System.Drawing.Size(326, 23)
        Me.selCuenta.TabIndex = 31
        Me.selCuenta.TextWidth = 100
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(189, 95)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(326, 20)
        Me.txtNombre.TabIndex = 30
        Me.txtNombre.UIName = "Nombre"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(54, 98)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 29
        Me.lblNombre.Text = "Nombre:"
        '
        'imlCajas
        '
        Me.imlCajas.ImageStream = CType(resources.GetObject("imlCajas.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlCajas.TransparentColor = System.Drawing.Color.Transparent
        Me.imlCajas.Images.SetKeyName(0, "General")
        Me.imlCajas.Images.SetKeyName(1, "keys32.png")
        '
        'gbxAccesos
        '
        Me.gbxAccesos.Controls.Add(Me.grdAccesos)
        Me.gbxAccesos.Controls.Add(Me.tbAccesos)
        Me.gbxAccesos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxAccesos.Location = New System.Drawing.Point(0, 0)
        Me.gbxAccesos.Name = "gbxAccesos"
        Me.gbxAccesos.Size = New System.Drawing.Size(579, 199)
        Me.gbxAccesos.TabIndex = 63
        Me.gbxAccesos.TabStop = False
        '
        'grdAccesos
        '
        Me.grdAccesos.AlternatingRows = True
        Me.grdAccesos.DataSource = Me.bsAccesos
        Me.grdAccesos.IDCatalogField = "IdUsuario"
        Me.grdAccesos.Images.Add(CType(resources.GetObject("grdAccesos.Images"), System.Drawing.Image))
        Me.grdAccesos.Location = New System.Drawing.Point(3, 55)
        Me.grdAccesos.Name = "grdAccesos"
        Me.grdAccesos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdAccesos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdAccesos.PreviewInfo.ZoomFactor = 75.0R
        Me.grdAccesos.PrintInfo.PageSettings = CType(resources.GetObject("grdAccesos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdAccesos.ShowEditButton = False
        Me.grdAccesos.Size = New System.Drawing.Size(547, 132)
        Me.grdAccesos.TabIndex = 43
        Me.grdAccesos.Text = "DataGridViewCatalog1"
        Me.grdAccesos.PropBag = resources.GetString("grdAccesos.PropBag")
        '
        'tbAccesos
        '
        Me.tbAccesos.Dock = System.Windows.Forms.DockStyle.None
        Me.tbAccesos.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbAccesos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnRefrescar, Me.btnSave, Me.ToolStripSeparator2, Me.btnUsuariosAdd})
        Me.tbAccesos.Location = New System.Drawing.Point(3, 16)
        Me.tbAccesos.Name = "tbAccesos"
        Me.tbAccesos.Size = New System.Drawing.Size(279, 39)
        Me.tbAccesos.TabIndex = 42
        Me.tbAccesos.Text = "CiToolBar4"
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Image = CType(resources.GetObject("btnRefrescar.Image"), System.Drawing.Image)
        Me.btnRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(91, 36)
        Me.btnRefrescar.Text = "Refrescar"
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 36)
        Me.btnSave.Text = "Guardar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'btnUsuariosAdd
        '
        Me.btnUsuariosAdd.Enabled = False
        Me.btnUsuariosAdd.Image = CType(resources.GetObject("btnUsuariosAdd.Image"), System.Drawing.Image)
        Me.btnUsuariosAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUsuariosAdd.Name = "btnUsuariosAdd"
        Me.btnUsuariosAdd.Size = New System.Drawing.Size(85, 36)
        Me.btnUsuariosAdd.Text = "Agregar"
        '
        'cboChequera
        '
        Me.cboChequera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboChequera.FormattingEnabled = True
        Me.cboChequera.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboChequera.ItemsTable = Nothing
        Me.cboChequera.Location = New System.Drawing.Point(189, 120)
        Me.cboChequera.Name = "cboChequera"
        Me.cboChequera.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboChequera.Size = New System.Drawing.Size(221, 21)
        Me.cboChequera.TabIndex = 65
        Me.cboChequera.UIName = Nothing
        '
        'lblPredeterminada
        '
        Me.lblPredeterminada.AutoSize = True
        Me.lblPredeterminada.Location = New System.Drawing.Point(54, 123)
        Me.lblPredeterminada.Name = "lblPredeterminada"
        Me.lblPredeterminada.Size = New System.Drawing.Size(130, 13)
        Me.lblPredeterminada.TabIndex = 66
        Me.lblPredeterminada.Text = "Chequera Predeterminada"
        '
        'iLst
        '
        Me.iLst.ImageStream = CType(resources.GetObject("iLst.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.iLst.TransparentColor = System.Drawing.Color.Transparent
        Me.iLst.Images.SetKeyName(0, "keys32.png")
        '
        'tabCajas
        '
        Me.tabCajas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabCajas.Controls.Add(Me.pagAccesos)
        Me.tabCajas.ImageList = Me.iLst
        Me.tabCajas.Location = New System.Drawing.Point(5, 185)
        Me.tabCajas.Name = "tabCajas"
        Me.tabCajas.Size = New System.Drawing.Size(581, 241)
        Me.tabCajas.TabIndex = 68
        Me.tabCajas.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2003
        Me.tabCajas.VisualStyle = C1.Win.C1Command.VisualStyle.Office2003Blue
        Me.tabCajas.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2003Blue
        '
        'pagAccesos
        '
        Me.pagAccesos.Controls.Add(Me.gbxAccesos)
        Me.pagAccesos.ImageIndex = 0
        Me.pagAccesos.Location = New System.Drawing.Point(1, 41)
        Me.pagAccesos.Name = "pagAccesos"
        Me.pagAccesos.Size = New System.Drawing.Size(579, 199)
        Me.pagAccesos.TabIndex = 0
        Me.pagAccesos.Text = "Accesos"
        '
        'CajasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 454)
        Me.Controls.Add(Me.tabCajas)
        Me.Controls.Add(Me.lblPredeterminada)
        Me.Controls.Add(Me.cboChequera)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblCuenta)
        Me.Controls.Add(Me.selCuenta)
        Me.Name = "CajasForm"
        Me.Text = "CajasForm"
        Me.Controls.SetChildIndex(Me.selCuenta, 0)
        Me.Controls.SetChildIndex(Me.lblCuenta, 0)
        Me.Controls.SetChildIndex(Me.lblNombre, 0)
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.cboChequera, 0)
        Me.Controls.SetChildIndex(Me.lblPredeterminada, 0)
        Me.Controls.SetChildIndex(Me.tabCajas, 0)
        Me.gbxAccesos.ResumeLayout(False)
        Me.gbxAccesos.PerformLayout()
        CType(Me.grdAccesos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAccesos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbAccesos.ResumeLayout(False)
        Me.tbAccesos.PerformLayout()
        CType(Me.tabCajas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCajas.ResumeLayout(False)
        Me.pagAccesos.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Me.Facade = New CajaFacade

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Friend WithEvents lblCuenta As Azteca.Windows.Controls.CILabel
    Friend WithEvents selCuenta As Azteca.Windows.Contabilidad.CuentaSelector
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblNombre As Azteca.Windows.Controls.CILabel
    Friend WithEvents imlCajas As System.Windows.Forms.ImageList
    Friend WithEvents gbxAccesos As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents tbAccesos As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnUsuariosAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents bsAccesos As System.Windows.Forms.BindingSource
    Friend WithEvents grdAccesos As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents cboChequera As Azteca.Windows.Tesoreria.ChequerasComboBox
    Friend WithEvents lblPredeterminada As Azteca.Windows.Controls.CILabel
    Friend WithEvents iLst As System.Windows.Forms.ImageList
    Friend WithEvents tabCajas As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagAccesos As C1.Win.C1Command.C1DockingTabPage
End Class
