<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacturaGlobalForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FacturaGlobalForm))
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.tlbMenu = New Azteca.Windows.Controls.AZToolBar()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdCargar = New C1.Win.C1Command.C1Command()
        Me.cmdNuevaFactura = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.grpPeriodo = New Azteca.Windows.Controls.CIGroupBox()
        Me.dtpFechaFin = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.dtpFechaIni = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.bsFacturas = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdFacturas = New Azteca.Windows.Controls.AZTrueDBGrid()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPeriodo.SuspendLayout()
        CType(Me.bsFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(23, 31)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(70, 13)
        Me.CiLabel1.TabIndex = 1
        Me.CiLabel1.Text = "Fecha Inicial:"
        '
        'tlbMenu
        '
        Me.tlbMenu.AccessibleName = "Tool Bar"
        Me.tlbMenu.AutoSize = False
        Me.tlbMenu.CommandHolder = Me.C1CommandHolder1
        Me.tlbMenu.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink1, Me.C1CommandLink2})
        Me.tlbMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlbMenu.MinButtonSize = 32
        Me.tlbMenu.Movable = False
        Me.tlbMenu.Name = "tlbMenu"
        Me.tlbMenu.Size = New System.Drawing.Size(792, 32)
        Me.tlbMenu.Text = "AzToolBar1"
        Me.tlbMenu.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tlbMenu.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdCargar)
        Me.C1CommandHolder1.Commands.Add(Me.cmdNuevaFactura)
        Me.C1CommandHolder1.Owner = Me
        '
        'cmdCargar
        '
        Me.cmdCargar.Image = CType(resources.GetObject("cmdCargar.Image"), System.Drawing.Image)
        Me.cmdCargar.Name = "cmdCargar"
        Me.cmdCargar.ShortcutText = ""
        Me.cmdCargar.Text = "Actualizar Lista"
        Me.cmdCargar.ToolTipText = "Cargar lista de facturas globales del periodo"
        '
        'cmdNuevaFactura
        '
        Me.cmdNuevaFactura.Image = CType(resources.GetObject("cmdNuevaFactura.Image"), System.Drawing.Image)
        Me.cmdNuevaFactura.Name = "cmdNuevaFactura"
        Me.cmdNuevaFactura.ShortcutText = ""
        Me.cmdNuevaFactura.Text = "Nueva Factura"
        Me.cmdNuevaFactura.ToolTipText = "Crear una nueva factura global"
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink1.Command = Me.cmdCargar
        '
        'C1CommandLink2
        '
        Me.C1CommandLink2.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink2.Command = Me.cmdNuevaFactura
        Me.C1CommandLink2.SortOrder = 1
        '
        'grpPeriodo
        '
        Me.grpPeriodo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPeriodo.Controls.Add(Me.dtpFechaFin)
        Me.grpPeriodo.Controls.Add(Me.dtpFechaIni)
        Me.grpPeriodo.Controls.Add(Me.CiLabel2)
        Me.grpPeriodo.Controls.Add(Me.CiLabel1)
        Me.grpPeriodo.Location = New System.Drawing.Point(12, 47)
        Me.grpPeriodo.Name = "grpPeriodo"
        Me.grpPeriodo.Size = New System.Drawing.Size(768, 95)
        Me.grpPeriodo.TabIndex = 3
        Me.grpPeriodo.TabStop = False
        Me.grpPeriodo.Text = "Periodo de consulta"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaFin.Location = New System.Drawing.Point(104, 55)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaFin.TabIndex = 4
        Me.dtpFechaFin.Value = New Date(2013, 3, 28, 0, 0, 0, 0)
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaIni.Location = New System.Drawing.Point(104, 29)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaIni.TabIndex = 3
        Me.dtpFechaIni.Value = New Date(2013, 3, 28, 0, 0, 0, 0)
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(23, 61)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(65, 13)
        Me.CiLabel2.TabIndex = 2
        Me.CiLabel2.Text = "Fecha Final:"
        '
        'grdFacturas
        '
        Me.grdFacturas.AllowUpdate = False
        Me.grdFacturas.AlternatingRows = True
        Me.grdFacturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdFacturas.DataSource = Me.bsFacturas
        Me.grdFacturas.FilterBar = True
        Me.grdFacturas.Images.Add(CType(resources.GetObject("grdFacturas.Images"), System.Drawing.Image))
        Me.grdFacturas.Images.Add(CType(resources.GetObject("grdFacturas.Images1"), System.Drawing.Image))
        Me.grdFacturas.Location = New System.Drawing.Point(12, 148)
        Me.grdFacturas.Name = "grdFacturas"
        Me.grdFacturas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdFacturas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdFacturas.PreviewInfo.ZoomFactor = 75.0R
        Me.grdFacturas.PrintInfo.PageSettings = CType(resources.GetObject("grdFacturas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdFacturas.Size = New System.Drawing.Size(768, 322)
        Me.grdFacturas.TabIndex = 4
        Me.grdFacturas.Text = "AzTrueDBGrid1"
        Me.grdFacturas.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        Me.grdFacturas.PropBag = resources.GetString("grdFacturas.PropBag")
        '
        'FacturaGlobalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 498)
        Me.Controls.Add(Me.grdFacturas)
        Me.Controls.Add(Me.grpPeriodo)
        Me.Controls.Add(Me.tlbMenu)
        Me.Name = "FacturaGlobalForm"
        Me.Text = "FacturaGlobalForm"
        Me.Controls.SetChildIndex(Me.tlbMenu, 0)
        Me.Controls.SetChildIndex(Me.grpPeriodo, 0)
        Me.Controls.SetChildIndex(Me.grdFacturas, 0)
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPeriodo.ResumeLayout(False)
        Me.grpPeriodo.PerformLayout()
        CType(Me.bsFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents tlbMenu As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdCargar As C1.Win.C1Command.C1Command
    Friend WithEvents grdFacturas As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents bsFacturas As System.Windows.Forms.BindingSource
    Friend WithEvents grpPeriodo As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents dtpFechaFin As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents dtpFechaIni As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cmdNuevaFactura As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
End Class
