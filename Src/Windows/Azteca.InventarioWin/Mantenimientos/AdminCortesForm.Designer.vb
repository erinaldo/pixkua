<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminCortesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminCortesForm))
        Me.grdCortes = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsCortes = New System.Windows.Forms.BindingSource(Me.components)
        Me.tlbMenu = New Azteca.Windows.Controls.AZToolBar()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdAbrirCorte = New C1.Win.C1Command.C1Command()
        Me.cmdCerrarCorte = New C1.Win.C1Command.C1Command()
        Me.cmdCapturaFisico = New C1.Win.C1Command.C1Command()
        Me.btnAbrirCorte = New C1.Win.C1Command.C1CommandLink()
        Me.btnCerrarCorte = New C1.Win.C1Command.C1CommandLink()
        Me.btnCapturaFisico = New C1.Win.C1Command.C1CommandLink()
        CType(Me.grdCortes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCortes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdCortes
        '
        Me.grdCortes.AllowUpdate = False
        Me.grdCortes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdCortes.DataSource = Me.bsCortes
        Me.grdCortes.FetchRowStyles = True
        Me.grdCortes.FilterBar = True
        Me.grdCortes.Images.Add(CType(resources.GetObject("grdCortes.Images"), System.Drawing.Image))
        Me.grdCortes.Location = New System.Drawing.Point(12, 37)
        Me.grdCortes.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.grdCortes.Name = "grdCortes"
        Me.grdCortes.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdCortes.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdCortes.PreviewInfo.ZoomFactor = 75.0R
        Me.grdCortes.PrintInfo.PageSettings = CType(resources.GetObject("grdCortes.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdCortes.Size = New System.Drawing.Size(557, 312)
        Me.grdCortes.TabIndex = 5
        Me.grdCortes.Text = "AzTrueDBGrid1"
        Me.grdCortes.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdCortes.PropBag = resources.GetString("grdCortes.PropBag")
        '
        'bsCortes
        '
        '
        'tlbMenu
        '
        Me.tlbMenu.AccessibleName = "Tool Bar"
        Me.tlbMenu.AutoSize = False
        Me.tlbMenu.CommandHolder = Me.C1CommandHolder1
        Me.tlbMenu.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.btnAbrirCorte, Me.btnCerrarCorte, Me.btnCapturaFisico})
        Me.tlbMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlbMenu.MinButtonSize = 32
        Me.tlbMenu.Movable = False
        Me.tlbMenu.Name = "tlbMenu"
        Me.tlbMenu.Size = New System.Drawing.Size(581, 31)
        Me.tlbMenu.Text = "AzToolBar1"
        Me.tlbMenu.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tlbMenu.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdAbrirCorte)
        Me.C1CommandHolder1.Commands.Add(Me.cmdCerrarCorte)
        Me.C1CommandHolder1.Commands.Add(Me.cmdCapturaFisico)
        Me.C1CommandHolder1.Owner = Me
        '
        'cmdAbrirCorte
        '
        Me.cmdAbrirCorte.Enabled = False
        Me.cmdAbrirCorte.Image = CType(resources.GetObject("cmdAbrirCorte.Image"), System.Drawing.Image)
        Me.cmdAbrirCorte.Name = "cmdAbrirCorte"
        Me.cmdAbrirCorte.Text = "Abrir Corte"
        '
        'cmdCerrarCorte
        '
        Me.cmdCerrarCorte.Enabled = False
        Me.cmdCerrarCorte.Image = CType(resources.GetObject("cmdCerrarCorte.Image"), System.Drawing.Image)
        Me.cmdCerrarCorte.Name = "cmdCerrarCorte"
        Me.cmdCerrarCorte.Text = "Cerrar Corte"
        Me.cmdCerrarCorte.ToolTipText = "Cerrar Corte de Inventario Actual"
        '
        'cmdCapturaFisico
        '
        Me.cmdCapturaFisico.Enabled = False
        Me.cmdCapturaFisico.Image = CType(resources.GetObject("cmdCapturaFisico.Image"), System.Drawing.Image)
        Me.cmdCapturaFisico.Name = "cmdCapturaFisico"
        Me.cmdCapturaFisico.Text = "Inventario Físico"
        '
        'btnAbrirCorte
        '
        Me.btnAbrirCorte.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnAbrirCorte.Command = Me.cmdAbrirCorte
        Me.btnAbrirCorte.ToolTipText = "Abrir un nuevo corte de inventario"
        '
        'btnCerrarCorte
        '
        Me.btnCerrarCorte.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnCerrarCorte.Command = Me.cmdCerrarCorte
        Me.btnCerrarCorte.SortOrder = 1
        '
        'btnCapturaFisico
        '
        Me.btnCapturaFisico.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnCapturaFisico.Command = Me.cmdCapturaFisico
        Me.btnCapturaFisico.Delimiter = True
        Me.btnCapturaFisico.SortOrder = 2
        Me.btnCapturaFisico.ToolTipText = "Captura de inventario físico"
        '
        'AdminCortesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 374)
        Me.Controls.Add(Me.tlbMenu)
        Me.Controls.Add(Me.grdCortes)
        Me.Name = "AdminCortesForm"
        Me.Text = "AdminCierresForm"
        Me.Controls.SetChildIndex(Me.grdCortes, 0)
        Me.Controls.SetChildIndex(Me.tlbMenu, 0)
        CType(Me.grdCortes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCortes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LicenseModule = Kernel.Licensing.LicenseModule.Inventory
    End Sub
    Friend WithEvents grdCortes As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents tlbMenu As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents cmdAbrirCorte As C1.Win.C1Command.C1Command
    Friend WithEvents cmdCerrarCorte As C1.Win.C1Command.C1Command
    Friend WithEvents cmdCapturaFisico As C1.Win.C1Command.C1Command
    Friend WithEvents btnAbrirCorte As C1.Win.C1Command.C1CommandLink
    Friend WithEvents btnCerrarCorte As C1.Win.C1Command.C1CommandLink
    Friend WithEvents btnCapturaFisico As C1.Win.C1Command.C1CommandLink
    Private WithEvents bsCortes As System.Windows.Forms.BindingSource
End Class
