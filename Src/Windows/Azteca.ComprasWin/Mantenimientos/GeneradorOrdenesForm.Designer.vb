<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GeneradorOrdenesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GeneradorOrdenesForm))
        Me.tabGenerador = New C1.Win.C1Command.C1DockingTab()
        Me.pagRequisiciones = New C1.Win.C1Command.C1DockingTabPage()
        Me.cboCentral = New Azteca.Windows.Controls.AZComboBox()
        Me.bsCentrales = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnInvReq = New Azteca.Windows.Controls.AZButton()
        Me.btnActualizar = New Azteca.Windows.Controls.AZButton()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.lblTitle = New Azteca.Windows.Controls.CILabel()
        Me.grdRequisiciones = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.bsRequisiciones = New System.Windows.Forms.BindingSource(Me.components)
        Me.pagSelProveedores = New C1.Win.C1Command.C1DockingTabPage()
        Me.grdProveedores = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.bsProveedores = New System.Windows.Forms.BindingSource(Me.components)
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.pagGenOrdenes = New C1.Win.C1Command.C1DockingTabPage()
        Me.grdOrdenesDet = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsOrdenesDet = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdOrdenes = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsOrdenes = New System.Windows.Forms.BindingSource(Me.components)
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.btnCancelar = New Azteca.Windows.Controls.AZButton()
        Me.btnAtras = New Azteca.Windows.Controls.AZButton()
        Me.btnSiguiente = New Azteca.Windows.Controls.AZButton()
        Me.btnCerrar = New Azteca.Windows.Controls.AZButton()
        CType(Me.tabGenerador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabGenerador.SuspendLayout()
        Me.pagRequisiciones.SuspendLayout()
        CType(Me.cboCentral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCentrales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdRequisiciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsRequisiciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagSelProveedores.SuspendLayout()
        CType(Me.grdProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagGenOrdenes.SuspendLayout()
        CType(Me.grdOrdenesDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsOrdenesDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabGenerador
        '
        Me.tabGenerador.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabGenerador.Controls.Add(Me.pagRequisiciones)
        Me.tabGenerador.Controls.Add(Me.pagSelProveedores)
        Me.tabGenerador.Controls.Add(Me.pagGenOrdenes)
        Me.tabGenerador.Location = New System.Drawing.Point(12, 12)
        Me.tabGenerador.Name = "tabGenerador"
        Me.tabGenerador.ShowTabs = False
        Me.tabGenerador.Size = New System.Drawing.Size(976, 421)
        Me.tabGenerador.TabIndex = 6
        Me.tabGenerador.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabGenerador.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabGenerador.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagRequisiciones
        '
        Me.pagRequisiciones.Controls.Add(Me.cboCentral)
        Me.pagRequisiciones.Controls.Add(Me.btnInvReq)
        Me.pagRequisiciones.Controls.Add(Me.btnActualizar)
        Me.pagRequisiciones.Controls.Add(Me.CiLabel3)
        Me.pagRequisiciones.Controls.Add(Me.lblTitle)
        Me.pagRequisiciones.Controls.Add(Me.grdRequisiciones)
        Me.pagRequisiciones.Location = New System.Drawing.Point(1, 1)
        Me.pagRequisiciones.Name = "pagRequisiciones"
        Me.pagRequisiciones.Size = New System.Drawing.Size(974, 419)
        Me.pagRequisiciones.TabIndex = 0
        Me.pagRequisiciones.Text = "Page1"
        '
        'cboCentral
        '
        Me.cboCentral.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboCentral.AutoClear = False
        Me.cboCentral.AutoLock = False
        Me.cboCentral.Caption = ""
        Me.cboCentral.CaptionHeight = 17
        Me.cboCentral.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboCentral.ColumnCaptionHeight = 17
        Me.cboCentral.ColumnFooterHeight = 17
        Me.cboCentral.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboCentral.ContentHeight = 15
        Me.cboCentral.DataSource = Me.bsCentrales
        Me.cboCentral.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboCentral.DisplayMember = "Nombre"
        Me.cboCentral.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboCentral.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentral.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCentral.EditorHeight = 15
        Me.cboCentral.EnterTab = False
        Me.cboCentral.ExtendRightColumn = True
        Me.cboCentral.FilterExpression = Nothing
        Me.cboCentral.Images.Add(CType(resources.GetObject("cboCentral.Images"), System.Drawing.Image))
        Me.cboCentral.ItemHeight = 15
        Me.cboCentral.ItemsTable = Nothing
        Me.cboCentral.Location = New System.Drawing.Point(111, 30)
        Me.cboCentral.MatchEntryTimeout = CType(2000, Long)
        Me.cboCentral.MaxDropDownItems = CType(5, Short)
        Me.cboCentral.MaxLength = 32767
        Me.cboCentral.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboCentral.Name = "cboCentral"
        Me.cboCentral.NoneItemText = Nothing
        Me.cboCentral.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboCentral.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCentral.Size = New System.Drawing.Size(236, 21)
        Me.cboCentral.SortExpression = "Nombre"
        Me.cboCentral.TabIndex = 17
        Me.cboCentral.UIName = Nothing
        Me.cboCentral.ValueMember = "IdCentral"
        Me.cboCentral.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue
        Me.cboCentral.PropBag = resources.GetString("cboCentral.PropBag")
        '
        'bsCentrales
        '
        Me.bsCentrales.Sort = "Nombre"
        '
        'btnInvReq
        '
        Me.btnInvReq.Location = New System.Drawing.Point(494, 26)
        Me.btnInvReq.Name = "btnInvReq"
        Me.btnInvReq.Size = New System.Drawing.Size(106, 28)
        Me.btnInvReq.TabIndex = 15
        Me.btnInvReq.Text = "Invertir Selección"
        Me.btnInvReq.UseVisualStyleBackColor = True
        Me.btnInvReq.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.btnInvReq.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(353, 26)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(135, 28)
        Me.btnActualizar.TabIndex = 16
        Me.btnActualizar.Text = "Cargar Requisiciones"
        Me.btnActualizar.UseVisualStyleBackColor = True
        Me.btnActualizar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.btnActualizar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(3, 34)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(102, 13)
        Me.CiLabel3.TabIndex = 13
        Me.CiLabel3.Text = "Central de Compras:"
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.BackColor = System.Drawing.SystemColors.Info
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(974, 23)
        Me.lblTitle.TabIndex = 12
        Me.lblTitle.Text = "Paso 1 de 3 - Seleccione las requisiciones"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grdRequisiciones
        '
        Me.grdRequisiciones.AlternatingRows = True
        Me.grdRequisiciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdRequisiciones.DataSource = Me.bsRequisiciones
        Me.grdRequisiciones.FilterBar = True
        Me.grdRequisiciones.Images.Add(CType(resources.GetObject("grdRequisiciones.Images"), System.Drawing.Image))
        Me.grdRequisiciones.Location = New System.Drawing.Point(0, 60)
        Me.grdRequisiciones.Name = "grdRequisiciones"
        Me.grdRequisiciones.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdRequisiciones.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdRequisiciones.PreviewInfo.ZoomFactor = 75.0R
        Me.grdRequisiciones.PrintInfo.PageSettings = CType(resources.GetObject("grdRequisiciones.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdRequisiciones.Size = New System.Drawing.Size(974, 359)
        Me.grdRequisiciones.TabIndex = 11
        Me.grdRequisiciones.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdRequisiciones.PropBag = resources.GetString("grdRequisiciones.PropBag")
        '
        'pagSelProveedores
        '
        Me.pagSelProveedores.Controls.Add(Me.grdProveedores)
        Me.pagSelProveedores.Controls.Add(Me.CiLabel1)
        Me.pagSelProveedores.Location = New System.Drawing.Point(1, 1)
        Me.pagSelProveedores.Name = "pagSelProveedores"
        Me.pagSelProveedores.Size = New System.Drawing.Size(974, 419)
        Me.pagSelProveedores.TabIndex = 1
        Me.pagSelProveedores.Text = "Page2"
        '
        'grdProveedores
        '
        Me.grdProveedores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdProveedores.DataSource = Me.bsProveedores
        Me.grdProveedores.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveDown
        Me.grdProveedores.FilterBar = True
        Me.grdProveedores.Images.Add(CType(resources.GetObject("grdProveedores.Images"), System.Drawing.Image))
        Me.grdProveedores.Images.Add(CType(resources.GetObject("grdProveedores.Images1"), System.Drawing.Image))
        Me.grdProveedores.Location = New System.Drawing.Point(0, 26)
        Me.grdProveedores.Name = "grdProveedores"
        Me.grdProveedores.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdProveedores.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdProveedores.PreviewInfo.ZoomFactor = 75.0R
        Me.grdProveedores.PrintInfo.PageSettings = CType(resources.GetObject("grdProveedores.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdProveedores.Size = New System.Drawing.Size(974, 393)
        Me.grdProveedores.TabIndex = 14
        Me.grdProveedores.Text = "C1TrueDBGrid1"
        Me.grdProveedores.PropBag = resources.GetString("grdProveedores.PropBag")
        '
        'CiLabel1
        '
        Me.CiLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CiLabel1.BackColor = System.Drawing.SystemColors.Info
        Me.CiLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiLabel1.Location = New System.Drawing.Point(0, 0)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(974, 23)
        Me.CiLabel1.TabIndex = 13
        Me.CiLabel1.Text = "Paso 2 de 3 - Elija el proveedor de cada artículo o servicio"
        Me.CiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pagGenOrdenes
        '
        Me.pagGenOrdenes.Controls.Add(Me.grdOrdenesDet)
        Me.pagGenOrdenes.Controls.Add(Me.grdOrdenes)
        Me.pagGenOrdenes.Controls.Add(Me.CiLabel2)
        Me.pagGenOrdenes.Location = New System.Drawing.Point(1, 1)
        Me.pagGenOrdenes.Name = "pagGenOrdenes"
        Me.pagGenOrdenes.Size = New System.Drawing.Size(974, 419)
        Me.pagGenOrdenes.TabIndex = 2
        Me.pagGenOrdenes.Text = "Page3"
        '
        'grdOrdenesDet
        '
        Me.grdOrdenesDet.AllowUpdate = False
        Me.grdOrdenesDet.DataSource = Me.bsOrdenesDet
        Me.grdOrdenesDet.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy
        Me.grdOrdenesDet.FilterBar = True
        Me.grdOrdenesDet.GroupByCaption = "Arrastre una columna para agrupar por esa columna"
        Me.grdOrdenesDet.Images.Add(CType(resources.GetObject("grdOrdenesDet.Images"), System.Drawing.Image))
        Me.grdOrdenesDet.Location = New System.Drawing.Point(23, 94)
        Me.grdOrdenesDet.Name = "grdOrdenesDet"
        Me.grdOrdenesDet.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdOrdenesDet.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdOrdenesDet.PreviewInfo.ZoomFactor = 75.0R
        Me.grdOrdenesDet.PrintInfo.PageSettings = CType(resources.GetObject("grdOrdenesDet.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdOrdenesDet.Size = New System.Drawing.Size(708, 212)
        Me.grdOrdenesDet.TabIndex = 15
        Me.grdOrdenesDet.TabStop = False
        Me.grdOrdenesDet.Text = "AzTrueDBGrid1"
        Me.grdOrdenesDet.PropBag = resources.GetString("grdOrdenesDet.PropBag")
        '
        'grdOrdenes
        '
        Me.grdOrdenes.AllowUpdate = False
        Me.grdOrdenes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdOrdenes.CellTips = C1.Win.C1TrueDBGrid.CellTipEnum.Anchored
        Me.grdOrdenes.ChildGrid = Me.grdOrdenesDet
        Me.grdOrdenes.DataSource = Me.bsOrdenes
        Me.grdOrdenes.Images.Add(CType(resources.GetObject("grdOrdenes.Images"), System.Drawing.Image))
        Me.grdOrdenes.Images.Add(CType(resources.GetObject("grdOrdenes.Images1"), System.Drawing.Image))
        Me.grdOrdenes.Location = New System.Drawing.Point(0, 26)
        Me.grdOrdenes.Name = "grdOrdenes"
        Me.grdOrdenes.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdOrdenes.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdOrdenes.PreviewInfo.ZoomFactor = 75.0R
        Me.grdOrdenes.PrintInfo.PageSettings = CType(resources.GetObject("grdOrdenes.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdOrdenes.Size = New System.Drawing.Size(974, 393)
        Me.grdOrdenes.TabIndex = 14
        Me.grdOrdenes.Text = "AzTrueDBGrid1"
        Me.grdOrdenes.PropBag = resources.GetString("grdOrdenes.PropBag")
        '
        'bsOrdenes
        '
        Me.bsOrdenes.Filter = "Generada=False"
        '
        'CiLabel2
        '
        Me.CiLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CiLabel2.BackColor = System.Drawing.SystemColors.Info
        Me.CiLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiLabel2.Location = New System.Drawing.Point(0, 0)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(974, 23)
        Me.CiLabel2.TabIndex = 13
        Me.CiLabel2.Text = "Paso Final - Seleccione las ordenes que desea generar"
        Me.CiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(669, 438)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 28)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        Me.btnCancelar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.btnCancelar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(750, 438)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(75, 28)
        Me.btnAtras.TabIndex = 12
        Me.btnAtras.Text = "< Atrás"
        Me.btnAtras.UseVisualStyleBackColor = True
        Me.btnAtras.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.btnAtras.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(831, 438)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(75, 28)
        Me.btnSiguiente.TabIndex = 13
        Me.btnSiguiente.Text = "Siguiente >"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        Me.btnSiguiente.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.btnSiguiente.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(912, 438)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 28)
        Me.btnCerrar.TabIndex = 14
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        Me.btnCerrar.Visible = False
        Me.btnCerrar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.btnCerrar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'GeneradorOrdenesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 494)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.tabGenerador)
        Me.Name = "GeneradorOrdenesForm"
        Me.Text = "Asistente para generación de ordenes de compra"
        Me.Controls.SetChildIndex(Me.tabGenerador, 0)
        Me.Controls.SetChildIndex(Me.btnCancelar, 0)
        Me.Controls.SetChildIndex(Me.btnAtras, 0)
        Me.Controls.SetChildIndex(Me.btnSiguiente, 0)
        Me.Controls.SetChildIndex(Me.btnCerrar, 0)
        CType(Me.tabGenerador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabGenerador.ResumeLayout(False)
        Me.pagRequisiciones.ResumeLayout(False)
        Me.pagRequisiciones.PerformLayout()
        CType(Me.cboCentral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCentrales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdRequisiciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsRequisiciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagSelProveedores.ResumeLayout(False)
        CType(Me.grdProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagGenOrdenes.ResumeLayout(False)
        CType(Me.grdOrdenesDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsOrdenesDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bsRequisiciones As System.Windows.Forms.BindingSource
    Friend WithEvents tabGenerador As C1.Win.C1Command.C1DockingTab
    Friend WithEvents pagRequisiciones As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagSelProveedores As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagGenOrdenes As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents lblTitle As Azteca.Windows.Controls.CILabel
    Friend WithEvents grdRequisiciones As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents grdProveedores As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents bsProveedores As System.Windows.Forms.BindingSource
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents grdOrdenes As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents bsOrdenes As System.Windows.Forms.BindingSource
    Friend WithEvents grdOrdenesDet As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents bsOrdenesDet As System.Windows.Forms.BindingSource
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.AZButton
    Friend WithEvents btnAtras As Azteca.Windows.Controls.AZButton
    Friend WithEvents btnSiguiente As Azteca.Windows.Controls.AZButton
    Friend WithEvents btnCerrar As Azteca.Windows.Controls.AZButton
    Friend WithEvents btnInvReq As Azteca.Windows.Controls.AZButton
    Friend WithEvents btnActualizar As Azteca.Windows.Controls.AZButton
    Friend WithEvents bsCentrales As System.Windows.Forms.BindingSource
    Friend WithEvents cboCentral As Azteca.Windows.Controls.AZComboBox

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LicenseModule = Kernel.Licensing.LicenseModule.Purchasing
    End Sub
End Class
