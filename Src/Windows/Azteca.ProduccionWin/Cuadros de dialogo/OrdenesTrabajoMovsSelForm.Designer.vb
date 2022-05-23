<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdenesTrabajoMovsSelForm
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrdenesTrabajoMovsSelForm))
        Me.tabPartidas = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagArticulos = New C1.Win.C1Command.C1DockingTabPage()
        Me.grdGeneral = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.cmsRecEnt = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.bsMovimientos = New System.Windows.Forms.BindingSource(Me.components)
        Me.C1DockingTabPage3 = New C1.Win.C1Command.C1DockingTabPage()
        Me.grdProcesos = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.cmsProcesos = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuFinalizarProceso = New System.Windows.Forms.ToolStripMenuItem()
        Me.bsProcesos = New System.Windows.Forms.BindingSource(Me.components)
        Me.pagServicios = New C1.Win.C1Command.C1DockingTabPage()
        Me.grdRecEnt = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.C1DockingTabPage1 = New C1.Win.C1Command.C1DockingTabPage()
        Me.grdIncidencias = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.cmsMenuIncidencias = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.bsIncidencias = New System.Windows.Forms.BindingSource(Me.components)
        Me.C1DockingTabPage2 = New C1.Win.C1Command.C1DockingTabPage()
        Me.grdInventario = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.lblOrdenTrabajo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.tabPartidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPartidas.SuspendLayout()
        Me.pagArticulos.SuspendLayout()
        CType(Me.grdGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsRecEnt.SuspendLayout()
        CType(Me.bsMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage3.SuspendLayout()
        CType(Me.grdProcesos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsProcesos.SuspendLayout()
        CType(Me.bsProcesos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagServicios.SuspendLayout()
        CType(Me.grdRecEnt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage1.SuspendLayout()
        CType(Me.grdIncidencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsMenuIncidencias.SuspendLayout()
        CType(Me.bsIncidencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage2.SuspendLayout()
        CType(Me.grdInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabPartidas
        '
        Me.tabPartidas.Controls.Add(Me.pagArticulos)
        Me.tabPartidas.Controls.Add(Me.C1DockingTabPage3)
        Me.tabPartidas.Controls.Add(Me.pagServicios)
        Me.tabPartidas.Controls.Add(Me.C1DockingTabPage1)
        Me.tabPartidas.Controls.Add(Me.C1DockingTabPage2)
        Me.tabPartidas.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tabPartidas.Location = New System.Drawing.Point(0, 42)
        Me.tabPartidas.Name = "tabPartidas"
        Me.tabPartidas.Size = New System.Drawing.Size(966, 346)
        Me.tabPartidas.TabIndex = 80
        Me.tabPartidas.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabPartidas.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabPartidas.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagArticulos
        '
        Me.pagArticulos.Controls.Add(Me.grdGeneral)
        Me.pagArticulos.Image = Global.Azteca.Windows.Produccion.My.Resources.Resources.AddIncidencias_32px1
        Me.pagArticulos.Location = New System.Drawing.Point(1, 41)
        Me.pagArticulos.Name = "pagArticulos"
        Me.pagArticulos.Size = New System.Drawing.Size(964, 304)
        Me.pagArticulos.TabIndex = 0
        Me.pagArticulos.Text = "General"
        '
        'grdGeneral
        '
        Me.grdGeneral.AllowUpdate = False
        Me.grdGeneral.ContextMenuStrip = Me.cmsRecEnt
        Me.grdGeneral.DataSource = Me.bsMovimientos
        Me.grdGeneral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdGeneral.FilterBar = True
        Me.grdGeneral.Images.Add(CType(resources.GetObject("grdGeneral.Images"), System.Drawing.Image))
        Me.grdGeneral.Location = New System.Drawing.Point(0, 0)
        Me.grdGeneral.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.grdGeneral.Name = "grdGeneral"
        Me.grdGeneral.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdGeneral.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdGeneral.PreviewInfo.ZoomFactor = 75.0R
        Me.grdGeneral.PrintInfo.PageSettings = CType(resources.GetObject("grdGeneral.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdGeneral.Size = New System.Drawing.Size(964, 304)
        Me.grdGeneral.TabIndex = 0
        Me.grdGeneral.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        Me.grdGeneral.PropBag = resources.GetString("grdGeneral.PropBag")
        '
        'cmsRecEnt
        '
        Me.cmsRecEnt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsModificar})
        Me.cmsRecEnt.Name = "cmsRecEnt"
        Me.cmsRecEnt.Size = New System.Drawing.Size(156, 26)
        '
        'cmsModificar
        '
        Me.cmsModificar.Image = Global.Azteca.Windows.Produccion.My.Resources.Resources.Edit_24
        Me.cmsModificar.Name = "cmsModificar"
        Me.cmsModificar.Size = New System.Drawing.Size(155, 22)
        Me.cmsModificar.Text = "Editar Cantidad"
        '
        'C1DockingTabPage3
        '
        Me.C1DockingTabPage3.Controls.Add(Me.grdProcesos)
        Me.C1DockingTabPage3.Image = Global.Azteca.Windows.Produccion.My.Resources.Resources.next_24
        Me.C1DockingTabPage3.Location = New System.Drawing.Point(1, 41)
        Me.C1DockingTabPage3.Name = "C1DockingTabPage3"
        Me.C1DockingTabPage3.Size = New System.Drawing.Size(964, 304)
        Me.C1DockingTabPage3.TabIndex = 2
        Me.C1DockingTabPage3.Text = "Procesos"
        '
        'grdProcesos
        '
        Me.grdProcesos.AllowUpdate = False
        Me.grdProcesos.ContextMenuStrip = Me.cmsProcesos
        Me.grdProcesos.DataSource = Me.bsProcesos
        Me.grdProcesos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdProcesos.FilterBar = True
        Me.grdProcesos.Images.Add(CType(resources.GetObject("grdProcesos.Images"), System.Drawing.Image))
        Me.grdProcesos.Location = New System.Drawing.Point(0, 0)
        Me.grdProcesos.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.grdProcesos.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.None
        Me.grdProcesos.Name = "grdProcesos"
        Me.grdProcesos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdProcesos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdProcesos.PreviewInfo.ZoomFactor = 75.0R
        Me.grdProcesos.PrintInfo.PageSettings = CType(resources.GetObject("grdProcesos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdProcesos.Size = New System.Drawing.Size(964, 304)
        Me.grdProcesos.TabIndex = 2
        Me.grdProcesos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        Me.grdProcesos.PropBag = resources.GetString("grdProcesos.PropBag")
        '
        'cmsProcesos
        '
        Me.cmsProcesos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFinalizarProceso})
        Me.cmsProcesos.Name = "cmsRecEnt"
        Me.cmsProcesos.Size = New System.Drawing.Size(163, 48)
        '
        'mnuFinalizarProceso
        '
        Me.mnuFinalizarProceso.Image = Global.Azteca.Windows.Produccion.My.Resources.Resources.close_workorder1
        Me.mnuFinalizarProceso.Name = "mnuFinalizarProceso"
        Me.mnuFinalizarProceso.Size = New System.Drawing.Size(162, 22)
        Me.mnuFinalizarProceso.Text = "Finalizar Proceso"
        '
        'pagServicios
        '
        Me.pagServicios.Controls.Add(Me.grdRecEnt)
        Me.pagServicios.Image = Global.Azteca.Windows.Produccion.My.Resources.Resources.RecibirWO_32px
        Me.pagServicios.Location = New System.Drawing.Point(1, 41)
        Me.pagServicios.Name = "pagServicios"
        Me.pagServicios.Size = New System.Drawing.Size(964, 304)
        Me.pagServicios.TabIndex = 3
        Me.pagServicios.Text = "Rec - Ent"
        '
        'grdRecEnt
        '
        Me.grdRecEnt.AllowUpdate = False
        Me.grdRecEnt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdRecEnt.FilterBar = True
        Me.grdRecEnt.Images.Add(CType(resources.GetObject("grdRecEnt.Images"), System.Drawing.Image))
        Me.grdRecEnt.Location = New System.Drawing.Point(0, 0)
        Me.grdRecEnt.Name = "grdRecEnt"
        Me.grdRecEnt.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdRecEnt.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdRecEnt.PreviewInfo.ZoomFactor = 75.0R
        Me.grdRecEnt.PrintInfo.PageSettings = CType(resources.GetObject("grdRecEnt.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdRecEnt.Size = New System.Drawing.Size(964, 304)
        Me.grdRecEnt.TabIndex = 1
        Me.grdRecEnt.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        Me.grdRecEnt.PropBag = resources.GetString("grdRecEnt.PropBag")
        '
        'C1DockingTabPage1
        '
        Me.C1DockingTabPage1.Controls.Add(Me.grdIncidencias)
        Me.C1DockingTabPage1.Image = Global.Azteca.Windows.Produccion.My.Resources.Resources.AddIncidencias_32px2
        Me.C1DockingTabPage1.Location = New System.Drawing.Point(1, 41)
        Me.C1DockingTabPage1.Name = "C1DockingTabPage1"
        Me.C1DockingTabPage1.Size = New System.Drawing.Size(964, 304)
        Me.C1DockingTabPage1.TabIndex = 4
        Me.C1DockingTabPage1.Text = "Incidencias"
        '
        'grdIncidencias
        '
        Me.grdIncidencias.AllowUpdate = False
        Me.grdIncidencias.ContextMenuStrip = Me.cmsMenuIncidencias
        Me.grdIncidencias.DataSource = Me.bsIncidencias
        Me.grdIncidencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdIncidencias.FilterBar = True
        Me.grdIncidencias.Images.Add(CType(resources.GetObject("grdIncidencias.Images"), System.Drawing.Image))
        Me.grdIncidencias.Location = New System.Drawing.Point(0, 0)
        Me.grdIncidencias.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.grdIncidencias.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.None
        Me.grdIncidencias.Name = "grdIncidencias"
        Me.grdIncidencias.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdIncidencias.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdIncidencias.PreviewInfo.ZoomFactor = 75.0R
        Me.grdIncidencias.PrintInfo.PageSettings = CType(resources.GetObject("grdIncidencias.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdIncidencias.Size = New System.Drawing.Size(964, 304)
        Me.grdIncidencias.TabIndex = 1
        Me.grdIncidencias.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        Me.grdIncidencias.PropBag = resources.GetString("grdIncidencias.PropBag")
        '
        'cmsMenuIncidencias
        '
        Me.cmsMenuIncidencias.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.cmsMenuIncidencias.Name = "cmsRecEnt"
        Me.cmsMenuIncidencias.Size = New System.Drawing.Size(164, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.Azteca.Windows.Produccion.My.Resources.Resources.close_workorder1
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(163, 22)
        Me.ToolStripMenuItem1.Text = "Cerrar Incidencia"
        '
        'C1DockingTabPage2
        '
        Me.C1DockingTabPage2.Controls.Add(Me.grdInventario)
        Me.C1DockingTabPage2.Image = Global.Azteca.Windows.Produccion.My.Resources.Resources.inve_32
        Me.C1DockingTabPage2.Location = New System.Drawing.Point(1, 41)
        Me.C1DockingTabPage2.Name = "C1DockingTabPage2"
        Me.C1DockingTabPage2.Size = New System.Drawing.Size(964, 304)
        Me.C1DockingTabPage2.TabIndex = 5
        Me.C1DockingTabPage2.Text = "Inventario"
        '
        'grdInventario
        '
        Me.grdInventario.AllowUpdate = False
        Me.grdInventario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdInventario.Images.Add(CType(resources.GetObject("grdInventario.Images"), System.Drawing.Image))
        Me.grdInventario.Location = New System.Drawing.Point(0, 0)
        Me.grdInventario.Name = "grdInventario"
        Me.grdInventario.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdInventario.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdInventario.PreviewInfo.ZoomFactor = 75.0R
        Me.grdInventario.PrintInfo.PageSettings = CType(resources.GetObject("grdInventario.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdInventario.Size = New System.Drawing.Size(964, 304)
        Me.grdInventario.TabIndex = 0
        Me.grdInventario.PropBag = resources.GetString("grdInventario.PropBag")
        '
        'lblOrdenTrabajo
        '
        Me.lblOrdenTrabajo.AutoSize = True
        Me.lblOrdenTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrdenTrabajo.Location = New System.Drawing.Point(420, 0)
        Me.lblOrdenTrabajo.Name = "lblOrdenTrabajo"
        Me.lblOrdenTrabajo.Size = New System.Drawing.Size(101, 31)
        Me.lblOrdenTrabajo.TabIndex = 81
        Me.lblOrdenTrabajo.Text = "Label1"
        Me.lblOrdenTrabajo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblOrdenTrabajo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(966, 36)
        Me.Panel1.TabIndex = 0
        '
        'OrdenesTrabajoMovsSelForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 388)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tabPartidas)
        Me.Name = "OrdenesTrabajoMovsSelForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OrdenesTrabajoMovsSelForm"
        CType(Me.tabPartidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPartidas.ResumeLayout(False)
        Me.pagArticulos.ResumeLayout(False)
        CType(Me.grdGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsRecEnt.ResumeLayout(False)
        CType(Me.bsMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage3.ResumeLayout(False)
        CType(Me.grdProcesos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsProcesos.ResumeLayout(False)
        CType(Me.bsProcesos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagServicios.ResumeLayout(False)
        CType(Me.grdRecEnt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage1.ResumeLayout(False)
        CType(Me.grdIncidencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsMenuIncidencias.ResumeLayout(False)
        CType(Me.bsIncidencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage2.ResumeLayout(False)
        CType(Me.grdInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabPartidas As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagArticulos As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagServicios As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1DockingTabPage1 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents lblOrdenTrabajo As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grdGeneral As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents grdRecEnt As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents grdIncidencias As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1DockingTabPage2 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents grdInventario As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents bsMovimientos As System.Windows.Forms.BindingSource
    Friend WithEvents cmsRecEnt As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsModificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bsIncidencias As System.Windows.Forms.BindingSource
    Friend WithEvents cmsMenuIncidencias As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents C1DockingTabPage3 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents grdProcesos As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents bsProcesos As System.Windows.Forms.BindingSource
    Friend WithEvents cmsProcesos As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuFinalizarProceso As System.Windows.Forms.ToolStripMenuItem
End Class
