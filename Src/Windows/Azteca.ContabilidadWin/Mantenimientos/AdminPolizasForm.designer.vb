<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPolizasForm
    Inherits Azteca.Windows.Forms.BaseForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminPolizasForm))
        Me.BrowseFile = New System.Windows.Forms.FolderBrowserDialog()
        Me.tabAdministrador = New Azteca.Windows.Controls.CITab()
        Me.tabLog = New System.Windows.Forms.TabPage()
        Me.cboPolizaOrigen = New Azteca.Windows.Controls.CIComboBox()
        Me.lblOrigen = New Azteca.Windows.Controls.CILabel()
        Me.btnConsultar = New Azteca.Windows.Controls.CIButton()
        Me.dtpFechaIni = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.dtpFechaFin = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.lblFechaIni = New Azteca.Windows.Controls.CILabel()
        Me.lvwPolizas = New Azteca.Windows.Controls.CIListView()
        Me.colId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colFecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSucursal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colOrigen = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTipo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMensaje = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.menuPoliza = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInterfazTexto = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEncolar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EliminarEnPixcuaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.tabServicios = New System.Windows.Forms.TabPage()
        Me.lblTimer = New Azteca.Windows.Controls.CILabel()
        Me.tlbMenu = New Azteca.Windows.Controls.CIToolBar()
        Me.btnDetener = New System.Windows.Forms.ToolStripButton()
        Me.btnIniciar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.lvwEmpresas = New Azteca.Windows.Controls.CIListView()
        Me.colEmpresa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBaseDatos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colIdServicio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPendientes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tmrRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.tabAdministrador.SuspendLayout()
        Me.tabLog.SuspendLayout()
        Me.menuPoliza.SuspendLayout()
        Me.tabServicios.SuspendLayout()
        Me.tlbMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'BrowseFile
        '
        Me.BrowseFile.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'tabAdministrador
        '
        Me.tabAdministrador.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabAdministrador.Controls.Add(Me.tabLog)
        Me.tabAdministrador.Controls.Add(Me.tabServicios)
        Me.tabAdministrador.Location = New System.Drawing.Point(21, 11)
        Me.tabAdministrador.Multiline = True
        Me.tabAdministrador.Name = "tabAdministrador"
        Me.tabAdministrador.SelectedIndex = 0
        Me.tabAdministrador.Size = New System.Drawing.Size(763, 438)
        Me.tabAdministrador.TabIndex = 16
        Me.tabAdministrador.TabStop = False
        '
        'tabLog
        '
        Me.tabLog.Controls.Add(Me.cboPolizaOrigen)
        Me.tabLog.Controls.Add(Me.lblOrigen)
        Me.tabLog.Controls.Add(Me.btnConsultar)
        Me.tabLog.Controls.Add(Me.dtpFechaIni)
        Me.tabLog.Controls.Add(Me.CiLabel2)
        Me.tabLog.Controls.Add(Me.dtpFechaFin)
        Me.tabLog.Controls.Add(Me.lblFechaIni)
        Me.tabLog.Controls.Add(Me.lvwPolizas)
        Me.tabLog.ImageIndex = 0
        Me.tabLog.Location = New System.Drawing.Point(4, 22)
        Me.tabLog.Name = "tabLog"
        Me.tabLog.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLog.Size = New System.Drawing.Size(755, 412)
        Me.tabLog.TabIndex = 0
        Me.tabLog.Text = "Historico"
        Me.tabLog.UseVisualStyleBackColor = True
        '
        'cboPolizaOrigen
        '
        Me.cboPolizaOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPolizaOrigen.FormattingEnabled = True
        Me.cboPolizaOrigen.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboPolizaOrigen.ItemsTable = Nothing
        Me.cboPolizaOrigen.Location = New System.Drawing.Point(82, 16)
        Me.cboPolizaOrigen.Name = "cboPolizaOrigen"
        Me.cboPolizaOrigen.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboPolizaOrigen.Size = New System.Drawing.Size(528, 21)
        Me.cboPolizaOrigen.TabIndex = 26
        Me.cboPolizaOrigen.UIName = Nothing
        '
        'lblOrigen
        '
        Me.lblOrigen.AutoSize = True
        Me.lblOrigen.Location = New System.Drawing.Point(43, 19)
        Me.lblOrigen.Name = "lblOrigen"
        Me.lblOrigen.Size = New System.Drawing.Size(38, 13)
        Me.lblOrigen.TabIndex = 18
        Me.lblOrigen.Text = "Origen"
        '
        'btnConsultar
        '
        Me.btnConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultar.Location = New System.Drawing.Point(671, 382)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(67, 23)
        Me.btnConsultar.TabIndex = 17
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaIni.Location = New System.Drawing.Point(82, 43)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(211, 20)
        Me.dtpFechaIni.TabIndex = 13
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(329, 46)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(65, 13)
        Me.CiLabel2.TabIndex = 16
        Me.CiLabel2.Text = "Fecha Final:"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaFin.Location = New System.Drawing.Point(400, 42)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(210, 20)
        Me.dtpFechaFin.TabIndex = 15
        '
        'lblFechaIni
        '
        Me.lblFechaIni.AutoSize = True
        Me.lblFechaIni.Location = New System.Drawing.Point(13, 46)
        Me.lblFechaIni.Name = "lblFechaIni"
        Me.lblFechaIni.Size = New System.Drawing.Size(70, 13)
        Me.lblFechaIni.TabIndex = 14
        Me.lblFechaIni.Text = "Fecha Inicial:"
        '
        'lvwPolizas
        '
        Me.lvwPolizas.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwPolizas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwPolizas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colId, Me.colFecha, Me.colSucursal, Me.colOrigen, Me.colTipo, Me.colStatus, Me.colMensaje})
        Me.lvwPolizas.ContextMenuStrip = Me.menuPoliza
        Me.lvwPolizas.FullRowSelect = True
        Me.lvwPolizas.GridLines = True
        Me.lvwPolizas.HotTracking = True
        Me.lvwPolizas.HoverSelection = True
        Me.lvwPolizas.LargeImageList = Me.ImageList1
        Me.lvwPolizas.Location = New System.Drawing.Point(16, 77)
        Me.lvwPolizas.MultiSelect = False
        Me.lvwPolizas.Name = "lvwPolizas"
        Me.lvwPolizas.Size = New System.Drawing.Size(722, 296)
        Me.lvwPolizas.SmallImageList = Me.ImageList1
        Me.lvwPolizas.StateImageList = Me.ImageList1
        Me.lvwPolizas.TabIndex = 9
        Me.lvwPolizas.UseCompatibleStateImageBehavior = False
        Me.lvwPolizas.View = System.Windows.Forms.View.Details
        '
        'colId
        '
        Me.colId.Text = "Identificador"
        Me.colId.Width = 126
        '
        'colFecha
        '
        Me.colFecha.Text = "Fecha"
        Me.colFecha.Width = 92
        '
        'colSucursal
        '
        Me.colSucursal.Text = "Sucursal"
        Me.colSucursal.Width = 98
        '
        'colOrigen
        '
        Me.colOrigen.Text = "Origen"
        Me.colOrigen.Width = 71
        '
        'colTipo
        '
        Me.colTipo.Text = "Tipo"
        Me.colTipo.Width = 72
        '
        'colStatus
        '
        Me.colStatus.Text = "Estatus"
        Me.colStatus.Width = 89
        '
        'colMensaje
        '
        Me.colMensaje.Text = "Mensaje"
        Me.colMensaje.Width = 146
        '
        'menuPoliza
        '
        Me.menuPoliza.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.mnuInterfazTexto, Me.mnuEncolar, Me.ToolStripSeparator1, Me.EliminarEnPixcuaToolStripMenuItem})
        Me.menuPoliza.Name = "menuPoliza"
        Me.menuPoliza.Size = New System.Drawing.Size(259, 98)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'mnuInterfazTexto
        '
        Me.mnuInterfazTexto.Name = "mnuInterfazTexto"
        Me.mnuInterfazTexto.Size = New System.Drawing.Size(258, 22)
        Me.mnuInterfazTexto.Text = "Generar interfaz de texto a contpaq"
        '
        'mnuEncolar
        '
        Me.mnuEncolar.Name = "mnuEncolar"
        Me.mnuEncolar.Size = New System.Drawing.Size(258, 22)
        Me.mnuEncolar.Text = "Volver a encolar..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(255, 6)
        '
        'EliminarEnPixcuaToolStripMenuItem
        '
        Me.EliminarEnPixcuaToolStripMenuItem.Name = "EliminarEnPixcuaToolStripMenuItem"
        Me.EliminarEnPixcuaToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.EliminarEnPixcuaToolStripMenuItem.Text = "Eliminar en pixcua..."
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Aceptar.gif")
        Me.ImageList1.Images.SetKeyName(1, "cancelar.gif")
        Me.ImageList1.Images.SetKeyName(2, "Espera.png")
        '
        'tabServicios
        '
        Me.tabServicios.Controls.Add(Me.lblTimer)
        Me.tabServicios.Controls.Add(Me.tlbMenu)
        Me.tabServicios.Controls.Add(Me.lvwEmpresas)
        Me.tabServicios.Location = New System.Drawing.Point(4, 22)
        Me.tabServicios.Name = "tabServicios"
        Me.tabServicios.Size = New System.Drawing.Size(755, 412)
        Me.tabServicios.TabIndex = 2
        Me.tabServicios.Text = "Empresas->Servicio"
        Me.tabServicios.UseVisualStyleBackColor = True
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Location = New System.Drawing.Point(16, 51)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(194, 13)
        Me.lblTimer.TabIndex = 16
        Me.lblTimer.Text = "La información se actualizará en 15 seg"
        '
        'tlbMenu
        '
        Me.tlbMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tlbMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnDetener, Me.btnIniciar, Me.ToolStripSeparator2})
        Me.tlbMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlbMenu.Name = "tlbMenu"
        Me.tlbMenu.Size = New System.Drawing.Size(755, 39)
        Me.tlbMenu.TabIndex = 11
        Me.tlbMenu.Text = "CiToolBar1"
        '
        'btnDetener
        '
        Me.btnDetener.Enabled = False
        Me.btnDetener.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDetener.Name = "btnDetener"
        Me.btnDetener.Size = New System.Drawing.Size(52, 36)
        Me.btnDetener.Text = "Detener"
        '
        'btnIniciar
        '
        Me.btnIniciar.Enabled = False
        Me.btnIniciar.Image = CType(resources.GetObject("btnIniciar.Image"), System.Drawing.Image)
        Me.btnIniciar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(75, 36)
        Me.btnIniciar.Text = "Iniciar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'lvwEmpresas
        '
        Me.lvwEmpresas.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwEmpresas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwEmpresas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colEmpresa, Me.colBaseDatos, Me.colIdServicio, Me.colPendientes})
        Me.lvwEmpresas.ContextMenuStrip = Me.menuPoliza
        Me.lvwEmpresas.FullRowSelect = True
        Me.lvwEmpresas.GridLines = True
        Me.lvwEmpresas.HotTracking = True
        Me.lvwEmpresas.HoverSelection = True
        Me.lvwEmpresas.LargeImageList = Me.ImageList1
        Me.lvwEmpresas.Location = New System.Drawing.Point(16, 77)
        Me.lvwEmpresas.MultiSelect = False
        Me.lvwEmpresas.Name = "lvwEmpresas"
        Me.lvwEmpresas.Size = New System.Drawing.Size(594, 277)
        Me.lvwEmpresas.SmallImageList = Me.ImageList1
        Me.lvwEmpresas.StateImageList = Me.ImageList1
        Me.lvwEmpresas.TabIndex = 10
        Me.lvwEmpresas.UseCompatibleStateImageBehavior = False
        Me.lvwEmpresas.View = System.Windows.Forms.View.Details
        '
        'colEmpresa
        '
        Me.colEmpresa.Text = "Empresa"
        Me.colEmpresa.Width = 288
        '
        'colBaseDatos
        '
        Me.colBaseDatos.Text = "Base de Datos"
        Me.colBaseDatos.Width = 154
        '
        'colIdServicio
        '
        Me.colIdServicio.Text = "IdServicio"
        Me.colIdServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colPendientes
        '
        Me.colPendientes.Text = "Pendientes"
        Me.colPendientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colPendientes.Width = 65
        '
        'tmrRefresh
        '
        Me.tmrRefresh.Interval = 1000
        '
        'AdminPolizasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 461)
        Me.Controls.Add(Me.tabAdministrador)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AdminPolizasForm"
        Me.Text = "InterfazForm"
        Me.tabAdministrador.ResumeLayout(False)
        Me.tabLog.ResumeLayout(False)
        Me.tabLog.PerformLayout()
        Me.menuPoliza.ResumeLayout(False)
        Me.tabServicios.ResumeLayout(False)
        Me.tabServicios.PerformLayout()
        Me.tlbMenu.ResumeLayout(False)
        Me.tlbMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BrowseFile As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents tabAdministrador As Azteca.Windows.Controls.CITab
    Friend WithEvents tabLog As System.Windows.Forms.TabPage
    Friend WithEvents lvwPolizas As Azteca.Windows.Controls.CIListView
    Friend WithEvents colId As System.Windows.Forms.ColumnHeader
    Friend WithEvents colFecha As System.Windows.Forms.ColumnHeader
    Friend WithEvents colSucursal As System.Windows.Forms.ColumnHeader
    Friend WithEvents colOrigen As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTipo As System.Windows.Forms.ColumnHeader
    Friend WithEvents colStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnConsultar As Azteca.Windows.Controls.CIButton
    Friend WithEvents dtpFechaIni As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents dtpFechaFin As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents lblFechaIni As Azteca.Windows.Controls.CILabel
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents menuPoliza As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEncolar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EliminarEnPixcuaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblOrigen As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboPolizaOrigen As Azteca.Windows.Controls.CIComboBox
    Friend WithEvents mnuInterfazTexto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tabServicios As System.Windows.Forms.TabPage
    Friend WithEvents lvwEmpresas As Azteca.Windows.Controls.CIListView
    Friend WithEvents colEmpresa As System.Windows.Forms.ColumnHeader
    Friend WithEvents colBaseDatos As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPendientes As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblTimer As Azteca.Windows.Controls.CILabel
    Friend WithEvents tlbMenu As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnDetener As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnIniciar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tmrRefresh As System.Windows.Forms.Timer
    Friend WithEvents colIdServicio As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMensaje As System.Windows.Forms.ColumnHeader

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LicenseModule = Kernel.Licensing.LicenseModule.Accounting
    End Sub
End Class
