<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecibirFacturaForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecibirFacturaForm))
        Dim Style1 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style2 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style3 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style4 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style5 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style6 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style7 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style8 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.txtFolder = New Azteca.Windows.Controls.CITextBox()
        Me.dlgFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.grdComprobantes = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsComprobantes = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSelFolder = New Azteca.Windows.Controls.CIButton()
        Me.tlbMenu = New Azteca.Windows.Controls.AZToolBar()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdBuscar = New C1.Win.C1Command.C1Command()
        Me.cmdGuardar = New C1.Win.C1Command.C1Command()
        Me.cmdCancelar = New C1.Win.C1Command.C1Command()
        Me.btnBuscar = New C1.Win.C1Command.C1CommandLink()
        Me.btnGuardar = New C1.Win.C1Command.C1CommandLink()
        Me.btnCancelar = New C1.Win.C1Command.C1CommandLink()
        Me.bsDivisas = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboDivisas = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        CType(Me.grdComprobantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsComprobantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDivisas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDivisas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(10, 45)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(179, 13)
        Me.CiLabel1.TabIndex = 5
        Me.CiLabel1.Text = "Repositorio de facturas electrónicas:"
        '
        'txtFolder
        '
        Me.txtFolder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFolder.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtFolder.Location = New System.Drawing.Point(195, 42)
        Me.txtFolder.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFolder.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFolder.Name = "txtFolder"
        Me.txtFolder.ReadOnly = True
        Me.txtFolder.Size = New System.Drawing.Size(681, 20)
        Me.txtFolder.TabIndex = 6
        '
        'grdComprobantes
        '
        Me.grdComprobantes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdComprobantes.CellTips = C1.Win.C1TrueDBGrid.CellTipEnum.Anchored
        Me.grdComprobantes.DataSource = Me.bsComprobantes
        Me.grdComprobantes.FetchRowStyles = True
        Me.grdComprobantes.Images.Add(CType(resources.GetObject("grdComprobantes.Images"), System.Drawing.Image))
        Me.grdComprobantes.Images.Add(CType(resources.GetObject("grdComprobantes.Images1"), System.Drawing.Image))
        Me.grdComprobantes.Location = New System.Drawing.Point(12, 68)
        Me.grdComprobantes.Name = "grdComprobantes"
        Me.grdComprobantes.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdComprobantes.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdComprobantes.PreviewInfo.ZoomFactor = 75.0R
        Me.grdComprobantes.PrintInfo.PageSettings = CType(resources.GetObject("grdComprobantes.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdComprobantes.Size = New System.Drawing.Size(896, 404)
        Me.grdComprobantes.TabIndex = 9
        Me.grdComprobantes.Text = "AzTrueDBGrid1"
        Me.grdComprobantes.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.grdComprobantes.PropBag = resources.GetString("grdComprobantes.PropBag")
        '
        'btnSelFolder
        '
        Me.btnSelFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelFolder.Image = Global.Azteca.Windows.Compras.My.Resources.Resources.Folder_Blue
        Me.btnSelFolder.Location = New System.Drawing.Point(875, 42)
        Me.btnSelFolder.Name = "btnSelFolder"
        Me.btnSelFolder.Size = New System.Drawing.Size(33, 23)
        Me.btnSelFolder.TabIndex = 7
        Me.btnSelFolder.UseVisualStyleBackColor = True
        '
        'tlbMenu
        '
        Me.tlbMenu.AccessibleName = "Tool Bar"
        Me.tlbMenu.AutoSize = False
        Me.tlbMenu.CommandHolder = Me.C1CommandHolder1
        Me.tlbMenu.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.btnBuscar, Me.btnGuardar, Me.btnCancelar})
        Me.tlbMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlbMenu.MinButtonSize = 32
        Me.tlbMenu.Movable = False
        Me.tlbMenu.Name = "tlbMenu"
        Me.tlbMenu.Size = New System.Drawing.Size(920, 36)
        Me.tlbMenu.Text = "AzToolBar1"
        Me.tlbMenu.VisualStyle = C1.Win.C1Command.VisualStyle.Office2003Silver
        Me.tlbMenu.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2003Silver
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdBuscar)
        Me.C1CommandHolder1.Commands.Add(Me.cmdGuardar)
        Me.C1CommandHolder1.Commands.Add(Me.cmdCancelar)
        Me.C1CommandHolder1.Owner = Me
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Image = CType(resources.GetObject("cmdBuscar.Image"), System.Drawing.Image)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.ShortcutText = ""
        Me.cmdBuscar.Text = "Buscar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.Image"), System.Drawing.Image)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.ShortcutText = ""
        Me.cmdGuardar.Text = "Guardar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.ShortcutText = ""
        Me.cmdCancelar.Text = "Cancelar"
        '
        'btnBuscar
        '
        Me.btnBuscar.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnBuscar.Command = Me.cmdBuscar
        '
        'btnGuardar
        '
        Me.btnGuardar.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnGuardar.Command = Me.cmdGuardar
        Me.btnGuardar.SortOrder = 1
        '
        'btnCancelar
        '
        Me.btnCancelar.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnCancelar.Command = Me.cmdCancelar
        Me.btnCancelar.Delimiter = True
        Me.btnCancelar.SortOrder = 2
        '
        'cboDivisas
        '
        Me.cboDivisas.AllowColMove = True
        Me.cboDivisas.AllowColSelect = True
        Me.cboDivisas.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboDivisas.AlternatingRows = False
        Me.cboDivisas.CaptionStyle = Style1
        Me.cboDivisas.ColumnCaptionHeight = 17
        Me.cboDivisas.ColumnFooterHeight = 17
        Me.cboDivisas.DataSource = Me.bsDivisas
        Me.cboDivisas.DisplayMember = "Nombre"
        Me.cboDivisas.EvenRowStyle = Style2
        Me.cboDivisas.ExtendRightColumn = True
        Me.cboDivisas.FetchRowStyles = False
        Me.cboDivisas.FooterStyle = Style3
        Me.cboDivisas.HeadingStyle = Style4
        Me.cboDivisas.HighLightRowStyle = Style5
        Me.cboDivisas.Images.Add(CType(resources.GetObject("cboDivisas.Images"), System.Drawing.Image))
        Me.cboDivisas.Location = New System.Drawing.Point(445, 132)
        Me.cboDivisas.Name = "cboDivisas"
        Me.cboDivisas.OddRowStyle = Style6
        Me.cboDivisas.RecordSelectorStyle = Style7
        Me.cboDivisas.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboDivisas.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboDivisas.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboDivisas.ScrollTips = False
        Me.cboDivisas.Size = New System.Drawing.Size(228, 236)
        Me.cboDivisas.Style = Style8
        Me.cboDivisas.TabIndex = 10
        Me.cboDivisas.TabStop = False
        Me.cboDivisas.Text = "C1TrueDBDropdown1"
        Me.cboDivisas.ValueMember = "IdDivisa"
        Me.cboDivisas.ValueTranslate = True
        Me.cboDivisas.Visible = False
        Me.cboDivisas.PropBag = resources.GetString("cboDivisas.PropBag")
        '
        'RecibirFacturaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 484)
        Me.ControlBox = False
        Me.Controls.Add(Me.cboDivisas)
        Me.Controls.Add(Me.tlbMenu)
        Me.Controls.Add(Me.grdComprobantes)
        Me.Controls.Add(Me.txtFolder)
        Me.Controls.Add(Me.btnSelFolder)
        Me.Controls.Add(Me.CiLabel1)
        Me.Name = "RecibirFacturaForm"
        Me.Text = "Buscar y validar archivos de CFD"
        CType(Me.grdComprobantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsComprobantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDivisas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDivisas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtFolder As Azteca.Windows.Controls.CITextBox
    Friend WithEvents btnSelFolder As Azteca.Windows.Controls.CIButton
    Friend WithEvents grdComprobantes As Azteca.Windows.Controls.AZTrueDBGrid

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Friend WithEvents tlbMenu As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents cmdBuscar As C1.Win.C1Command.C1Command
    Friend WithEvents cmdGuardar As C1.Win.C1Command.C1Command
    Friend WithEvents btnBuscar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents btnGuardar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdCancelar As C1.Win.C1Command.C1Command
    Friend WithEvents btnCancelar As C1.Win.C1Command.C1CommandLink
    Private WithEvents dlgFolder As System.Windows.Forms.FolderBrowserDialog
    Private WithEvents bsComprobantes As System.Windows.Forms.BindingSource
    Friend WithEvents bsDivisas As System.Windows.Forms.BindingSource
    Friend WithEvents cboDivisas As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
End Class
