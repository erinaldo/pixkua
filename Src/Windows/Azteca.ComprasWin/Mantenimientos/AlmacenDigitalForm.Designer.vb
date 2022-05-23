<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlmacenDigitalForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlmacenDigitalForm))
        Me.grdComprobantes = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsComprobantes = New System.Windows.Forms.BindingSource(Me.components)
        Me.tlbMenu = New Azteca.Windows.Controls.AZToolBar()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdRecibir = New C1.Win.C1Command.C1Command()
        Me.cmdActualizar = New C1.Win.C1Command.C1Command()
        Me.cmdImprimir = New C1.Win.C1Command.C1Command()
        Me.cmdAdjuntos = New C1.Win.C1Command.C1Command()
        Me.cmdDescargarXML = New C1.Win.C1Command.C1Command()
        Me.btnRecibir = New C1.Win.C1Command.C1CommandLink()
        Me.btnImprimir = New C1.Win.C1Command.C1CommandLink()
        Me.btnDescargarXML = New C1.Win.C1Command.C1CommandLink()
        Me.btnActualizar = New C1.Win.C1Command.C1CommandLink()
        Me.grpPeriodo = New Azteca.Windows.Controls.CIGroupBox()
        Me.dtpFechaFin = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.dtpFechaIni = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.dlgSaveXML = New System.Windows.Forms.SaveFileDialog()
        Me.FolderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.grdComprobantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsComprobantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPeriodo.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdComprobantes
        '
        Me.grdComprobantes.AlternatingRows = True
        Me.grdComprobantes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdComprobantes.DataSource = Me.bsComprobantes
        Me.grdComprobantes.FilterBar = True
        Me.grdComprobantes.Images.Add(CType(resources.GetObject("grdComprobantes.Images"), System.Drawing.Image))
        Me.grdComprobantes.Location = New System.Drawing.Point(12, 118)
        Me.grdComprobantes.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.grdComprobantes.Name = "grdComprobantes"
        Me.grdComprobantes.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdComprobantes.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdComprobantes.PreviewInfo.ZoomFactor = 75.0R
        Me.grdComprobantes.PrintInfo.PageSettings = CType(resources.GetObject("grdComprobantes.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdComprobantes.Size = New System.Drawing.Size(804, 332)
        Me.grdComprobantes.TabIndex = 5
        Me.grdComprobantes.Text = "AzTrueDBGrid1"
        Me.grdComprobantes.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdComprobantes.PropBag = resources.GetString("grdComprobantes.PropBag")
        '
        'bsComprobantes
        '
        Me.bsComprobantes.Sort = "HoraComprobante DESC"
        '
        'tlbMenu
        '
        Me.tlbMenu.AccessibleName = "Tool Bar"
        Me.tlbMenu.AutoSize = False
        Me.tlbMenu.CommandHolder = Me.C1CommandHolder1
        Me.tlbMenu.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.btnRecibir, Me.btnImprimir, Me.btnDescargarXML, Me.btnActualizar})
        Me.tlbMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlbMenu.MinButtonSize = 32
        Me.tlbMenu.Movable = False
        Me.tlbMenu.Name = "tlbMenu"
        Me.tlbMenu.Size = New System.Drawing.Size(828, 33)
        Me.tlbMenu.Text = "AzToolBar1"
        Me.tlbMenu.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tlbMenu.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdRecibir)
        Me.C1CommandHolder1.Commands.Add(Me.cmdActualizar)
        Me.C1CommandHolder1.Commands.Add(Me.cmdImprimir)
        Me.C1CommandHolder1.Commands.Add(Me.cmdAdjuntos)
        Me.C1CommandHolder1.Commands.Add(Me.cmdDescargarXML)
        Me.C1CommandHolder1.Owner = Me
        '
        'cmdRecibir
        '
        Me.cmdRecibir.Image = CType(resources.GetObject("cmdRecibir.Image"), System.Drawing.Image)
        Me.cmdRecibir.Name = "cmdRecibir"
        Me.cmdRecibir.Text = "Recibir CFD"
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Image = CType(resources.GetObject("cmdActualizar.Image"), System.Drawing.Image)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Text = "Actualizar"
        Me.cmdActualizar.ToolTipText = "Actualizar lista de comprobantes"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Text = "Imprimir"
        '
        'cmdAdjuntos
        '
        Me.cmdAdjuntos.Image = CType(resources.GetObject("cmdAdjuntos.Image"), System.Drawing.Image)
        Me.cmdAdjuntos.Name = "cmdAdjuntos"
        Me.cmdAdjuntos.Text = "Documentos Adjuntos"
        '
        'cmdDescargarXML
        '
        Me.cmdDescargarXML.Image = CType(resources.GetObject("cmdDescargarXML.Image"), System.Drawing.Image)
        Me.cmdDescargarXML.Name = "cmdDescargarXML"
        Me.cmdDescargarXML.Text = "Descargar XML"
        '
        'btnRecibir
        '
        Me.btnRecibir.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnRecibir.Command = Me.cmdRecibir
        '
        'btnImprimir
        '
        Me.btnImprimir.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnImprimir.Command = Me.cmdImprimir
        Me.btnImprimir.SortOrder = 1
        '
        'btnDescargarXML
        '
        Me.btnDescargarXML.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnDescargarXML.Command = Me.cmdDescargarXML
        Me.btnDescargarXML.SortOrder = 2
        '
        'btnActualizar
        '
        Me.btnActualizar.Command = Me.cmdActualizar
        Me.btnActualizar.Delimiter = True
        Me.btnActualizar.SortOrder = 3
        '
        'grpPeriodo
        '
        Me.grpPeriodo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPeriodo.Controls.Add(Me.dtpFechaFin)
        Me.grpPeriodo.Controls.Add(Me.dtpFechaIni)
        Me.grpPeriodo.Controls.Add(Me.CiLabel2)
        Me.grpPeriodo.Controls.Add(Me.CiLabel1)
        Me.grpPeriodo.Location = New System.Drawing.Point(12, 39)
        Me.grpPeriodo.Name = "grpPeriodo"
        Me.grpPeriodo.Size = New System.Drawing.Size(804, 73)
        Me.grpPeriodo.TabIndex = 7
        Me.grpPeriodo.TabStop = False
        Me.grpPeriodo.Text = "Período de consulta"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaFin.Location = New System.Drawing.Point(236, 40)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaFin.TabIndex = 3
        Me.dtpFechaFin.Value = New Date(2012, 2, 19, 0, 0, 0, 0)
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaIni.Location = New System.Drawing.Point(20, 40)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaIni.TabIndex = 2
        Me.dtpFechaIni.Value = New Date(2012, 2, 19, 0, 0, 0, 0)
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(233, 24)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(65, 13)
        Me.CiLabel2.TabIndex = 1
        Me.CiLabel2.Text = "Fecha Final:"
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(17, 24)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(70, 13)
        Me.CiLabel1.TabIndex = 0
        Me.CiLabel1.Text = "Fecha Inicial:"
        '
        'dlgSaveXML
        '
        Me.dlgSaveXML.Filter = "Comprobantes Fiscales|*.xml"
        Me.dlgSaveXML.Title = "Descargar archivo xml"
        '
        'AlmacenDigitalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 475)
        Me.Controls.Add(Me.grpPeriodo)
        Me.Controls.Add(Me.tlbMenu)
        Me.Controls.Add(Me.grdComprobantes)
        Me.Name = "AlmacenDigitalForm"
        Me.Text = "AlmacenDigitalForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.grdComprobantes, 0)
        Me.Controls.SetChildIndex(Me.tlbMenu, 0)
        Me.Controls.SetChildIndex(Me.grpPeriodo, 0)
        CType(Me.grdComprobantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsComprobantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPeriodo.ResumeLayout(False)
        Me.grpPeriodo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdComprobantes As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents tlbMenu As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents cmdRecibir As C1.Win.C1Command.C1Command
    Friend WithEvents grpPeriodo As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents dtpFechaFin As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents dtpFechaIni As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents btnRecibir As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdActualizar As C1.Win.C1Command.C1Command
    Friend WithEvents btnActualizar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdImprimir As C1.Win.C1Command.C1Command
    Friend WithEvents btnImprimir As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdAdjuntos As C1.Win.C1Command.C1Command
    Private WithEvents bsComprobantes As System.Windows.Forms.BindingSource
    Friend WithEvents cmdDescargarXML As C1.Win.C1Command.C1Command
    Friend WithEvents btnDescargarXML As C1.Win.C1Command.C1CommandLink
    Friend WithEvents dlgSaveXML As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FolderBrowser As System.Windows.Forms.FolderBrowserDialog
End Class
