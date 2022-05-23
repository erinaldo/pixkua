<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PolizasForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PolizasForm))
        Me.lblNombre = New Azteca.Windows.Controls.CILabel()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.chkAcumulable = New Azteca.Windows.Controls.CICheckBox()
        Me.CiComboBox4 = New Azteca.Windows.Controls.CIComboBox()
        Me.cboSumarizacion = New Azteca.Windows.Controls.CIComboBox()
        Me.cboPolizaTipo = New Azteca.Windows.Controls.CIComboBox()
        Me.cboPolizaOrigen = New Azteca.Windows.Controls.CIComboBox()
        Me.lblWorkflow = New Azteca.Windows.Controls.CILabel()
        Me.lblSumarizacion = New Azteca.Windows.Controls.CILabel()
        Me.lblTipo = New Azteca.Windows.Controls.CILabel()
        Me.lblOrigen = New Azteca.Windows.Controls.CILabel()
        Me.gbxClientes = New Azteca.Windows.Controls.CIGroupBox()
        Me.grdRacs = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsRacs = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbClientesMenu = New Azteca.Windows.Controls.CIToolBar()
        Me.btnRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnRacAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.chkExportarse = New Azteca.Windows.Controls.CICheckBox()
        Me.gbxSistemaExterno = New Azteca.Windows.Controls.CIGroupBox()
        Me.chkAfectar = New Azteca.Windows.Controls.CICheckBox()
        Me.iLstTabs = New System.Windows.Forms.ImageList(Me.components)
        Me.cboVista = New Azteca.Windows.Controls.CIComboBox()
        Me.lblVista = New Azteca.Windows.Controls.CILabel()
        Me.Tab = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagGenerales = New C1.Win.C1Command.C1DockingTabPage()
        Me.pagRac = New C1.Win.C1Command.C1DockingTabPage()
        Me.pagExportar = New C1.Win.C1Command.C1DockingTabPage()
        Me.gbxClientes.SuspendLayout()
        CType(Me.grdRacs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsRacs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbClientesMenu.SuspendLayout()
        Me.gbxSistemaExterno.SuspendLayout()
        CType(Me.Tab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab.SuspendLayout()
        Me.pagGenerales.SuspendLayout()
        Me.pagRac.SuspendLayout()
        Me.pagExportar.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(17, 91)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 20
        Me.lblNombre.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(100, 87)
        Me.txtNombre.MaxLength = 64
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(503, 20)
        Me.txtNombre.TabIndex = 21
        '
        'chkAcumulable
        '
        Me.chkAcumulable.BackColor = System.Drawing.Color.Transparent
        Me.chkAcumulable.Location = New System.Drawing.Point(115, 157)
        Me.chkAcumulable.Name = "chkAcumulable"
        Me.chkAcumulable.Size = New System.Drawing.Size(368, 22)
        Me.chkAcumulable.TabIndex = 29
        Me.chkAcumulable.Text = "Los movimientos se van acumulando para  contabilizarlos manualmente"
        Me.chkAcumulable.UseVisualStyleBackColor = False
        '
        'CiComboBox4
        '
        Me.CiComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CiComboBox4.FormattingEnabled = True
        Me.CiComboBox4.HighlightColor = System.Drawing.SystemColors.Info
        Me.CiComboBox4.ItemsTable = Nothing
        Me.CiComboBox4.Location = New System.Drawing.Point(115, 120)
        Me.CiComboBox4.Name = "CiComboBox4"
        Me.CiComboBox4.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.CiComboBox4.Size = New System.Drawing.Size(237, 21)
        Me.CiComboBox4.TabIndex = 26
        Me.CiComboBox4.UIName = Nothing
        '
        'cboSumarizacion
        '
        Me.cboSumarizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSumarizacion.FormattingEnabled = True
        Me.cboSumarizacion.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboSumarizacion.ItemsTable = Nothing
        Me.cboSumarizacion.Location = New System.Drawing.Point(115, 72)
        Me.cboSumarizacion.Name = "cboSumarizacion"
        Me.cboSumarizacion.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboSumarizacion.Size = New System.Drawing.Size(237, 21)
        Me.cboSumarizacion.TabIndex = 27
        Me.cboSumarizacion.UIName = Nothing
        '
        'cboPolizaTipo
        '
        Me.cboPolizaTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPolizaTipo.FormattingEnabled = True
        Me.cboPolizaTipo.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboPolizaTipo.ItemsTable = Nothing
        Me.cboPolizaTipo.Location = New System.Drawing.Point(115, 49)
        Me.cboPolizaTipo.Name = "cboPolizaTipo"
        Me.cboPolizaTipo.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboPolizaTipo.Size = New System.Drawing.Size(237, 21)
        Me.cboPolizaTipo.TabIndex = 26
        Me.cboPolizaTipo.UIName = Nothing
        '
        'cboPolizaOrigen
        '
        Me.cboPolizaOrigen.BackColor = System.Drawing.SystemColors.Window
        Me.cboPolizaOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPolizaOrigen.FormattingEnabled = True
        Me.cboPolizaOrigen.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboPolizaOrigen.ItemsTable = Nothing
        Me.cboPolizaOrigen.Location = New System.Drawing.Point(115, 26)
        Me.cboPolizaOrigen.Name = "cboPolizaOrigen"
        Me.cboPolizaOrigen.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboPolizaOrigen.Size = New System.Drawing.Size(237, 21)
        Me.cboPolizaOrigen.TabIndex = 25
        Me.cboPolizaOrigen.UIName = Nothing
        '
        'lblWorkflow
        '
        Me.lblWorkflow.AutoSize = True
        Me.lblWorkflow.BackColor = System.Drawing.Color.Transparent
        Me.lblWorkflow.Location = New System.Drawing.Point(24, 124)
        Me.lblWorkflow.Name = "lblWorkflow"
        Me.lblWorkflow.Size = New System.Drawing.Size(87, 13)
        Me.lblWorkflow.TabIndex = 24
        Me.lblWorkflow.Text = "Flujo operacional"
        '
        'lblSumarizacion
        '
        Me.lblSumarizacion.AutoSize = True
        Me.lblSumarizacion.BackColor = System.Drawing.Color.Transparent
        Me.lblSumarizacion.Location = New System.Drawing.Point(24, 75)
        Me.lblSumarizacion.Name = "lblSumarizacion"
        Me.lblSumarizacion.Size = New System.Drawing.Size(70, 13)
        Me.lblSumarizacion.TabIndex = 23
        Me.lblSumarizacion.Text = "Sumarización"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.BackColor = System.Drawing.Color.Transparent
        Me.lblTipo.Location = New System.Drawing.Point(24, 53)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(28, 13)
        Me.lblTipo.TabIndex = 22
        Me.lblTipo.Text = "Tipo"
        '
        'lblOrigen
        '
        Me.lblOrigen.AutoSize = True
        Me.lblOrigen.BackColor = System.Drawing.Color.Transparent
        Me.lblOrigen.Location = New System.Drawing.Point(24, 29)
        Me.lblOrigen.Name = "lblOrigen"
        Me.lblOrigen.Size = New System.Drawing.Size(38, 13)
        Me.lblOrigen.TabIndex = 21
        Me.lblOrigen.Text = "Origen"
        '
        'gbxClientes
        '
        Me.gbxClientes.Controls.Add(Me.grdRacs)
        Me.gbxClientes.Controls.Add(Me.tbClientesMenu)
        Me.gbxClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxClientes.Location = New System.Drawing.Point(0, 0)
        Me.gbxClientes.Name = "gbxClientes"
        Me.gbxClientes.Size = New System.Drawing.Size(501, 229)
        Me.gbxClientes.TabIndex = 26
        Me.gbxClientes.TabStop = False
        '
        'grdRacs
        '
        Me.grdRacs.AllowDelete = True
        Me.grdRacs.AlternatingRows = True
        Me.grdRacs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdRacs.DataSource = Me.bsRacs
        Me.grdRacs.IDCatalogField = "IdRacTit"
        Me.grdRacs.Images.Add(CType(resources.GetObject("grdRacs.Images"), System.Drawing.Image))
        Me.grdRacs.Location = New System.Drawing.Point(3, 55)
        Me.grdRacs.Name = "grdRacs"
        Me.grdRacs.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdRacs.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdRacs.PreviewInfo.ZoomFactor = 75.0R
        Me.grdRacs.PrintInfo.PageSettings = CType(resources.GetObject("grdRacs.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdRacs.Size = New System.Drawing.Size(495, 171)
        Me.grdRacs.TabIndex = 30
        Me.grdRacs.Text = "AzTrueDBGrid1"
        Me.grdRacs.PropBag = resources.GetString("grdRacs.PropBag")
        '
        'tbClientesMenu
        '
        Me.tbClientesMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbClientesMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnRefrescar, Me.ToolStripSeparator5, Me.btnRacAdd, Me.ToolStripSeparator6})
        Me.tbClientesMenu.Location = New System.Drawing.Point(3, 16)
        Me.tbClientesMenu.Name = "tbClientesMenu"
        Me.tbClientesMenu.Size = New System.Drawing.Size(495, 39)
        Me.tbClientesMenu.TabIndex = 31
        Me.tbClientesMenu.Text = "CiToolBar3"
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Image = CType(resources.GetObject("btnRefrescar.Image"), System.Drawing.Image)
        Me.btnRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(98, 36)
        Me.btnRefrescar.Text = "Actualizar "
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 39)
        '
        'btnRacAdd
        '
        Me.btnRacAdd.Image = CType(resources.GetObject("btnRacAdd.Image"), System.Drawing.Image)
        Me.btnRacAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRacAdd.Name = "btnRacAdd"
        Me.btnRacAdd.Size = New System.Drawing.Size(131, 36)
        Me.btnRacAdd.Text = "Crear Nuevo Rac"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 39)
        '
        'chkExportarse
        '
        Me.chkExportarse.AutoSize = True
        Me.chkExportarse.BackColor = System.Drawing.Color.Transparent
        Me.chkExportarse.Location = New System.Drawing.Point(57, 27)
        Me.chkExportarse.Name = "chkExportarse"
        Me.chkExportarse.Size = New System.Drawing.Size(161, 17)
        Me.chkExportarse.TabIndex = 30
        Me.chkExportarse.Text = "Exportarse a sistema externo"
        Me.chkExportarse.UseVisualStyleBackColor = False
        '
        'gbxSistemaExterno
        '
        Me.gbxSistemaExterno.BackColor = System.Drawing.Color.Transparent
        Me.gbxSistemaExterno.Controls.Add(Me.chkAfectar)
        Me.gbxSistemaExterno.Location = New System.Drawing.Point(56, 57)
        Me.gbxSistemaExterno.Name = "gbxSistemaExterno"
        Me.gbxSistemaExterno.Size = New System.Drawing.Size(398, 152)
        Me.gbxSistemaExterno.TabIndex = 0
        Me.gbxSistemaExterno.TabStop = False
        Me.gbxSistemaExterno.Text = "Sistema Externo"
        '
        'chkAfectar
        '
        Me.chkAfectar.AutoSize = True
        Me.chkAfectar.Location = New System.Drawing.Point(48, 29)
        Me.chkAfectar.Name = "chkAfectar"
        Me.chkAfectar.Size = New System.Drawing.Size(268, 17)
        Me.chkAfectar.TabIndex = 29
        Me.chkAfectar.Text = "Afectar en el sistema externo las polizas exportadas"
        Me.chkAfectar.UseVisualStyleBackColor = True
        '
        'iLstTabs
        '
        Me.iLstTabs.ImageStream = CType(resources.GetObject("iLstTabs.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.iLstTabs.TransparentColor = System.Drawing.Color.Transparent
        Me.iLstTabs.Images.SetKeyName(0, "accounting_32.png")
        Me.iLstTabs.Images.SetKeyName(1, "balance_32.png")
        Me.iLstTabs.Images.SetKeyName(2, "export_database_32.png")
        '
        'cboVista
        '
        Me.cboVista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVista.FormattingEnabled = True
        Me.cboVista.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboVista.ItemsTable = Nothing
        Me.cboVista.Location = New System.Drawing.Point(100, 110)
        Me.cboVista.Name = "cboVista"
        Me.cboVista.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboVista.Size = New System.Drawing.Size(263, 21)
        Me.cboVista.TabIndex = 31
        Me.cboVista.UIName = Nothing
        '
        'lblVista
        '
        Me.lblVista.AutoSize = True
        Me.lblVista.Location = New System.Drawing.Point(17, 114)
        Me.lblVista.Name = "lblVista"
        Me.lblVista.Size = New System.Drawing.Size(77, 13)
        Me.lblVista.TabIndex = 30
        Me.lblVista.Text = "Vista  contable"
        '
        'Tab
        '
        Me.Tab.Controls.Add(Me.pagGenerales)
        Me.Tab.Controls.Add(Me.pagRac)
        Me.Tab.Controls.Add(Me.pagExportar)
        Me.Tab.ImageList = Me.iLstTabs
        Me.Tab.Location = New System.Drawing.Point(100, 137)
        Me.Tab.Name = "Tab"
        Me.Tab.Size = New System.Drawing.Size(503, 271)
        Me.Tab.TabIndex = 30
        Me.Tab.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2003
        Me.Tab.VisualStyle = C1.Win.C1Command.VisualStyle.Office2003Blue
        Me.Tab.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2003Blue
        '
        'pagGenerales
        '
        Me.pagGenerales.Controls.Add(Me.lblOrigen)
        Me.pagGenerales.Controls.Add(Me.cboSumarizacion)
        Me.pagGenerales.Controls.Add(Me.cboPolizaOrigen)
        Me.pagGenerales.Controls.Add(Me.chkAcumulable)
        Me.pagGenerales.Controls.Add(Me.cboPolizaTipo)
        Me.pagGenerales.Controls.Add(Me.lblWorkflow)
        Me.pagGenerales.Controls.Add(Me.CiComboBox4)
        Me.pagGenerales.Controls.Add(Me.lblSumarizacion)
        Me.pagGenerales.Controls.Add(Me.lblTipo)
        Me.pagGenerales.ImageIndex = 0
        Me.pagGenerales.Location = New System.Drawing.Point(1, 41)
        Me.pagGenerales.Name = "pagGenerales"
        Me.pagGenerales.Size = New System.Drawing.Size(501, 229)
        Me.pagGenerales.TabIndex = 0
        Me.pagGenerales.Text = "Generales"
        '
        'pagRac
        '
        Me.pagRac.Controls.Add(Me.gbxClientes)
        Me.pagRac.ImageIndex = 1
        Me.pagRac.Location = New System.Drawing.Point(1, 41)
        Me.pagRac.Name = "pagRac"
        Me.pagRac.Size = New System.Drawing.Size(501, 229)
        Me.pagRac.TabIndex = 1
        Me.pagRac.Text = "Racs"
        '
        'pagExportar
        '
        Me.pagExportar.Controls.Add(Me.chkExportarse)
        Me.pagExportar.Controls.Add(Me.gbxSistemaExterno)
        Me.pagExportar.ImageIndex = 2
        Me.pagExportar.Location = New System.Drawing.Point(1, 41)
        Me.pagExportar.Name = "pagExportar"
        Me.pagExportar.Size = New System.Drawing.Size(501, 229)
        Me.pagExportar.TabIndex = 2
        Me.pagExportar.Text = "Exportar"
        '
        'PolizasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 448)
        Me.Controls.Add(Me.Tab)
        Me.Controls.Add(Me.cboVista)
        Me.Controls.Add(Me.lblVista)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtNombre)
        Me.Name = "PolizasForm"
        Me.Text = "PolizasForm"
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.lblNombre, 0)
        Me.Controls.SetChildIndex(Me.lblVista, 0)
        Me.Controls.SetChildIndex(Me.cboVista, 0)
        Me.Controls.SetChildIndex(Me.Tab, 0)
        Me.gbxClientes.ResumeLayout(False)
        Me.gbxClientes.PerformLayout()
        CType(Me.grdRacs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsRacs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbClientesMenu.ResumeLayout(False)
        Me.tbClientesMenu.PerformLayout()
        Me.gbxSistemaExterno.ResumeLayout(False)
        Me.gbxSistemaExterno.PerformLayout()
        CType(Me.Tab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab.ResumeLayout(False)
        Me.pagGenerales.ResumeLayout(False)
        Me.pagGenerales.PerformLayout()
        Me.pagRac.ResumeLayout(False)
        Me.pagExportar.ResumeLayout(False)
        Me.pagExportar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombre As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiComboBox4 As Azteca.Windows.Controls.CIComboBox
    Friend WithEvents cboSumarizacion As Azteca.Windows.Controls.CIComboBox
    Friend WithEvents cboPolizaTipo As Azteca.Windows.Controls.CIComboBox
    Friend WithEvents cboPolizaOrigen As Azteca.Windows.Controls.CIComboBox
    Friend WithEvents lblWorkflow As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblSumarizacion As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblTipo As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblOrigen As Azteca.Windows.Controls.CILabel
    Friend WithEvents gbxSistemaExterno As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents chkAfectar As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents chkAcumulable As Azteca.Windows.Controls.CICheckBox
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Facade = New PolizaPerfilFacade
        LicenseModule = Kernel.Licensing.LicenseModule.Accounting
    End Sub
    Friend WithEvents chkExportarse As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents gbxClientes As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents grdRacs As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents tbClientesMenu As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnRacAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents iLstTabs As System.Windows.Forms.ImageList
    Friend WithEvents bsRacs As System.Windows.Forms.BindingSource
    Friend WithEvents cboVista As Azteca.Windows.Controls.CIComboBox
    Friend WithEvents lblVista As Azteca.Windows.Controls.CILabel
    Friend WithEvents Tab As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagGenerales As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagRac As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagExportar As C1.Win.C1Command.C1DockingTabPage
End Class
