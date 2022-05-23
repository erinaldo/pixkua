<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CapturaInventarioFisicoForm
    Inherits Azteca.Windows.Forms.BaseForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CapturaInventarioFisicoForm))
        Me.grdArticulos = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsArticulos = New System.Windows.Forms.BindingSource(Me.components)
        Me.lstAlmacenes = New Azteca.Windows.Controls.AZList()
        Me.bsAlmacenes = New System.Windows.Forms.BindingSource(Me.components)
        Me.tlbMenu = New Azteca.Windows.Controls.AZToolBar()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdGuardar = New C1.Win.C1Command.C1Command()
        Me.cmdImprimir = New C1.Win.C1Command.C1Command()
        Me.cmdActualizarExistencias = New C1.Win.C1Command.C1Command()
        Me.btnGuardar = New C1.Win.C1Command.C1CommandLink()
        Me.btnImprimir = New C1.Win.C1Command.C1CommandLink()
        Me.btnActualizarExistencias = New C1.Win.C1Command.C1CommandLink()
        Me.cmdSave = New C1.Win.C1Command.C1Command()
        CType(Me.grdArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstAlmacenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAlmacenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdArticulos
        '
        Me.grdArticulos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdArticulos.DataSource = Me.bsArticulos
        Me.grdArticulos.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveDown
        Me.grdArticulos.FilterBar = True
        Me.grdArticulos.Images.Add(CType(resources.GetObject("grdArticulos.Images"), System.Drawing.Image))
        Me.grdArticulos.Location = New System.Drawing.Point(215, 39)
        Me.grdArticulos.Name = "grdArticulos"
        Me.grdArticulos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdArticulos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdArticulos.PreviewInfo.ZoomFactor = 75.0R
        Me.grdArticulos.PrintInfo.PageSettings = CType(resources.GetObject("grdArticulos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdArticulos.Size = New System.Drawing.Size(755, 426)
        Me.grdArticulos.TabIndex = 5
        Me.grdArticulos.Text = "AzTrueDBGrid1"
        Me.grdArticulos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdArticulos.PropBag = resources.GetString("grdArticulos.PropBag")
        '
        'lstAlmacenes
        '
        Me.lstAlmacenes.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.lstAlmacenes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstAlmacenes.AutoClear = False
        Me.lstAlmacenes.AutoLock = False
        Me.lstAlmacenes.Caption = ""
        Me.lstAlmacenes.CaptionHeight = 17
        Me.lstAlmacenes.ColumnCaptionHeight = 32
        Me.lstAlmacenes.ColumnFooterHeight = 17
        Me.lstAlmacenes.DataSource = Me.bsAlmacenes
        Me.lstAlmacenes.DeadAreaBackColor = System.Drawing.SystemColors.ControlDark
        Me.lstAlmacenes.DisplayMember = "Nombre"
        Me.lstAlmacenes.EnterTab = False
        Me.lstAlmacenes.ExtendRightColumn = True
        Me.lstAlmacenes.FilterExpression = Nothing
        Me.lstAlmacenes.Images.Add(CType(resources.GetObject("lstAlmacenes.Images"), System.Drawing.Image))
        Me.lstAlmacenes.Images.Add(CType(resources.GetObject("lstAlmacenes.Images1"), System.Drawing.Image))
        Me.lstAlmacenes.ItemHeight = 15
        Me.lstAlmacenes.ItemsTable = Nothing
        Me.lstAlmacenes.Location = New System.Drawing.Point(0, 39)
        Me.lstAlmacenes.MatchEntryTimeout = CType(2000, Long)
        Me.lstAlmacenes.Name = "lstAlmacenes"
        Me.lstAlmacenes.NoneItemText = Nothing
        Me.lstAlmacenes.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.lstAlmacenes.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.lstAlmacenes.Size = New System.Drawing.Size(209, 426)
        Me.lstAlmacenes.SortExpression = Nothing
        Me.lstAlmacenes.TabIndex = 6
        Me.lstAlmacenes.Text = "AzList1"
        Me.lstAlmacenes.UIName = Nothing
        Me.lstAlmacenes.ValueMember = "IdAlmacen"
        Me.lstAlmacenes.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue
        Me.lstAlmacenes.PropBag = resources.GetString("lstAlmacenes.PropBag")
        '
        'tlbMenu
        '
        Me.tlbMenu.AccessibleName = "Tool Bar"
        Me.tlbMenu.AutoSize = False
        Me.tlbMenu.CommandHolder = Me.C1CommandHolder1
        Me.tlbMenu.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.btnGuardar, Me.btnImprimir, Me.btnActualizarExistencias})
        Me.tlbMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlbMenu.MinButtonSize = 32
        Me.tlbMenu.Movable = False
        Me.tlbMenu.Name = "tlbMenu"
        Me.tlbMenu.Size = New System.Drawing.Size(970, 33)
        Me.tlbMenu.Text = "AzToolBar1"
        Me.tlbMenu.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tlbMenu.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdGuardar)
        Me.C1CommandHolder1.Commands.Add(Me.cmdImprimir)
        Me.C1CommandHolder1.Commands.Add(Me.cmdActualizarExistencias)
        Me.C1CommandHolder1.Commands.Add(Me.cmdSave)
        Me.C1CommandHolder1.Owner = Me
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.Image"), System.Drawing.Image)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.ToolTipText = "Guardar Cambios"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Text = "Imprimir"
        '
        'cmdActualizarExistencias
        '
        Me.cmdActualizarExistencias.Image = CType(resources.GetObject("cmdActualizarExistencias.Image"), System.Drawing.Image)
        Me.cmdActualizarExistencias.Name = "cmdActualizarExistencias"
        Me.cmdActualizarExistencias.Text = "Actualizar Existencias"
        '
        'btnGuardar
        '
        Me.btnGuardar.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnGuardar.Command = Me.cmdGuardar
        '
        'btnImprimir
        '
        Me.btnImprimir.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnImprimir.Command = Me.cmdImprimir
        Me.btnImprimir.SortOrder = 1
        Me.btnImprimir.ToolTipText = "Imprimir captura actual"
        '
        'btnActualizarExistencias
        '
        Me.btnActualizarExistencias.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnActualizarExistencias.Command = Me.cmdActualizarExistencias
        Me.btnActualizarExistencias.Delimiter = True
        Me.btnActualizarExistencias.SortOrder = 2
        Me.btnActualizarExistencias.ToolTipText = "Actualizar existencias teóricas"
        '
        'cmdSave
        '
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Text = "Guardar"
        '
        'CapturaInventarioFisicoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 471)
        Me.Controls.Add(Me.tlbMenu)
        Me.Controls.Add(Me.grdArticulos)
        Me.Controls.Add(Me.lstAlmacenes)
        Me.MinimizeBox = False
        Me.Name = "CapturaInventarioFisicoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Captura de Inventario Físico"
        CType(Me.grdArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstAlmacenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAlmacenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LicenseModule = Kernel.Licensing.LicenseModule.Inventory
    End Sub
    Friend WithEvents grdArticulos As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents lstAlmacenes As Azteca.Windows.Controls.AZList
    Friend WithEvents tlbMenu As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents cmdGuardar As C1.Win.C1Command.C1Command
    Friend WithEvents cmdImprimir As C1.Win.C1Command.C1Command
    Friend WithEvents btnGuardar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents btnImprimir As C1.Win.C1Command.C1CommandLink
    Private WithEvents bsArticulos As System.Windows.Forms.BindingSource
    Private WithEvents bsAlmacenes As System.Windows.Forms.BindingSource
    Friend WithEvents cmdActualizarExistencias As C1.Win.C1Command.C1Command
    Friend WithEvents btnActualizarExistencias As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdSave As C1.Win.C1Command.C1Command
End Class
