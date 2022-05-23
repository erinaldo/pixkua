<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminFacturasForm
    Inherits Azteca.Windows.Forms.Forma

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminFacturasForm))
        Me.tlbMenu = New Azteca.Windows.Controls.CIToolBar()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.btnVerFactura = New System.Windows.Forms.ToolStripButton()
        Me.btnGetXML = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelarFactura = New System.Windows.Forms.ToolStripButton()
        Me.btnEnviar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnImprimirLista = New System.Windows.Forms.ToolStripButton()
        Me.bsFacturas = New System.Windows.Forms.BindingSource(Me.components)
        Me.grpFiltros = New Azteca.Windows.Controls.CIGroupBox()
        Me.cboSucursal = New Azteca.Windows.Controls.Security.SucursalComboBox()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.txtCliente = New Azteca.Windows.Ventas.ClienteSelector()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.dtpFechaFin = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.dtpFechaIni = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.dlgSaveXML = New System.Windows.Forms.SaveFileDialog()
        Me.grdFacturas = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.tlbMenu.SuspendLayout()
        CType(Me.bsFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltros.SuspendLayout()
        CType(Me.grdFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlbMenu
        '
        Me.tlbMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tlbMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnVerFactura, Me.btnGetXML, Me.btnCancelarFactura, Me.btnEnviar, Me.ToolStripSeparator1, Me.btnImprimirLista})
        Me.tlbMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlbMenu.Name = "tlbMenu"
        Me.tlbMenu.Size = New System.Drawing.Size(865, 39)
        Me.tlbMenu.TabIndex = 5
        Me.tlbMenu.Text = "CiToolBar1"
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.Azteca.Windows.Ventas.My.Resources.Resources.invoice_search32
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(125, 36)
        Me.btnBuscar.Text = "Buscar Facturas"
        '
        'btnVerFactura
        '
        Me.btnVerFactura.Enabled = False
        Me.btnVerFactura.Image = Global.Azteca.Windows.Ventas.My.Resources.Resources.invoice_zoom32
        Me.btnVerFactura.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnVerFactura.Name = "btnVerFactura"
        Me.btnVerFactura.Size = New System.Drawing.Size(102, 36)
        Me.btnVerFactura.Text = "Ver Factura"
        '
        'btnGetXML
        '
        Me.btnGetXML.Enabled = False
        Me.btnGetXML.Image = Global.Azteca.Windows.Ventas.My.Resources.Resources.xml_32
        Me.btnGetXML.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGetXML.Name = "btnGetXML"
        Me.btnGetXML.Size = New System.Drawing.Size(122, 36)
        Me.btnGetXML.Text = "Descargar XML"
        '
        'btnCancelarFactura
        '
        Me.btnCancelarFactura.Enabled = False
        Me.btnCancelarFactura.Image = Global.Azteca.Windows.Ventas.My.Resources.Resources.invoice_close32
        Me.btnCancelarFactura.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelarFactura.Name = "btnCancelarFactura"
        Me.btnCancelarFactura.Size = New System.Drawing.Size(131, 36)
        Me.btnCancelarFactura.Text = "Cancelar Factura"
        '
        'btnEnviar
        '
        Me.btnEnviar.Image = Global.Azteca.Windows.Ventas.My.Resources.Resources.invoice_mail_32
        Me.btnEnviar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(133, 36)
        Me.btnEnviar.Text = "Enviar Por E-Mail"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'btnImprimirLista
        '
        Me.btnImprimirLista.Enabled = False
        Me.btnImprimirLista.Image = Global.Azteca.Windows.Ventas.My.Resources.Resources.printer_32
        Me.btnImprimirLista.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimirLista.Name = "btnImprimirLista"
        Me.btnImprimirLista.Size = New System.Drawing.Size(116, 36)
        Me.btnImprimirLista.Text = "Imprimir Lista"
        Me.btnImprimirLista.ToolTipText = "Imprimir lista de facturas"
        '
        'grpFiltros
        '
        Me.grpFiltros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltros.Controls.Add(Me.cboSucursal)
        Me.grpFiltros.Controls.Add(Me.CiLabel4)
        Me.grpFiltros.Controls.Add(Me.txtCliente)
        Me.grpFiltros.Controls.Add(Me.CiLabel3)
        Me.grpFiltros.Controls.Add(Me.dtpFechaFin)
        Me.grpFiltros.Controls.Add(Me.dtpFechaIni)
        Me.grpFiltros.Controls.Add(Me.CiLabel2)
        Me.grpFiltros.Controls.Add(Me.CiLabel1)
        Me.grpFiltros.Location = New System.Drawing.Point(12, 42)
        Me.grpFiltros.Name = "grpFiltros"
        Me.grpFiltros.Size = New System.Drawing.Size(841, 83)
        Me.grpFiltros.TabIndex = 7
        Me.grpFiltros.TabStop = False
        Me.grpFiltros.Text = "Filtros"
        '
        'cboSucursal
        '
        Me.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSucursal.FormattingEnabled = True
        Me.cboSucursal.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboSucursal.ItemsTable = Nothing
        Me.cboSucursal.Location = New System.Drawing.Point(102, 47)
        Me.cboSucursal.Name = "cboSucursal"
        Me.cboSucursal.Size = New System.Drawing.Size(200, 21)
        Me.cboSucursal.TabIndex = 7
        Me.cboSucursal.UIName = Nothing
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.Location = New System.Drawing.Point(45, 50)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(51, 13)
        Me.CiLabel4.TabIndex = 6
        Me.CiLabel4.Text = "Sucursal:"
        '
        'txtCliente
        '
        Me.txtCliente.AnySite = False
        Me.txtCliente.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtCliente.EditorAssembly = "Azteca.VentasWin"
        Me.txtCliente.EditorClass = "Azteca.Windows.Ventas.ClientesForm"
        Me.txtCliente.EditorTitle = "Editar datos de cliente..."
        Me.txtCliente.Key = 0
        Me.txtCliente.Linked = False
        Me.txtCliente.Location = New System.Drawing.Point(379, 47)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(194, 23)
        Me.txtCliente.TabIndex = 5
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(331, 53)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(42, 13)
        Me.CiLabel3.TabIndex = 4
        Me.CiLabel3.Text = "Cliente:"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaFin.Location = New System.Drawing.Point(379, 21)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaFin.TabIndex = 3
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaIni.Location = New System.Drawing.Point(102, 21)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaIni.TabIndex = 2
        Me.dtpFechaIni.Value = New Date(2010, 9, 24, 0, 0, 0, 0)
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(308, 25)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(65, 13)
        Me.CiLabel2.TabIndex = 1
        Me.CiLabel2.Text = "Fecha Final:"
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(26, 25)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(70, 13)
        Me.CiLabel1.TabIndex = 0
        Me.CiLabel1.Text = "Fecha Inicial:"
        '
        'dlgSaveXML
        '
        Me.dlgSaveXML.Filter = "Archivos xml|*.xml"
        Me.dlgSaveXML.Title = "Guardar archivo xml"
        '
        'grdFacturas
        '
        Me.grdFacturas.AllowUpdate = False
        Me.grdFacturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdFacturas.DataSource = Me.bsFacturas
        Me.grdFacturas.FetchRowStyles = True
        Me.grdFacturas.FilterBar = True
        Me.grdFacturas.Images.Add(CType(resources.GetObject("grdFacturas.Images"), System.Drawing.Image))
        Me.grdFacturas.Location = New System.Drawing.Point(12, 131)
        Me.grdFacturas.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.grdFacturas.Name = "grdFacturas"
        Me.grdFacturas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdFacturas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdFacturas.PreviewInfo.ZoomFactor = 75.0R
        Me.grdFacturas.PrintInfo.PageSettings = CType(resources.GetObject("grdFacturas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdFacturas.Size = New System.Drawing.Size(841, 280)
        Me.grdFacturas.TabIndex = 8
        Me.grdFacturas.Text = "C1TrueDBGrid1"
        Me.grdFacturas.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdFacturas.PropBag = resources.GetString("grdFacturas.PropBag")
        '
        'AdminFacturasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 439)
        Me.Controls.Add(Me.grdFacturas)
        Me.Controls.Add(Me.grpFiltros)
        Me.Controls.Add(Me.tlbMenu)
        Me.Name = "AdminFacturasForm"
        Me.Text = "ImpresionFacturasForm"
        Me.Controls.SetChildIndex(Me.tlbMenu, 0)
        Me.Controls.SetChildIndex(Me.grpFiltros, 0)
        Me.Controls.SetChildIndex(Me.grdFacturas, 0)
        Me.tlbMenu.ResumeLayout(False)
        Me.tlbMenu.PerformLayout()
        CType(Me.bsFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltros.ResumeLayout(False)
        Me.grpFiltros.PerformLayout()
        CType(Me.grdFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tlbMenu As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents bsFacturas As System.Windows.Forms.BindingSource
    Friend WithEvents btnVerFactura As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnImprimirLista As System.Windows.Forms.ToolStripButton
    Friend WithEvents grpFiltros As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents dtpFechaFin As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents dtpFechaIni As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCliente As Azteca.Windows.Ventas.ClienteSelector
    Friend WithEvents btnCancelarFactura As System.Windows.Forms.ToolStripButton
    Friend WithEvents cboSucursal As Azteca.Windows.Controls.Security.SucursalComboBox
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
    Friend WithEvents btnGetXML As System.Windows.Forms.ToolStripButton
    Friend WithEvents dlgSaveXML As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnEnviar As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdFacturas As C1.Win.C1TrueDBGrid.C1TrueDBGrid
End Class
