<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetalleCorteForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetalleCorteForm))
        Me.grdDetalle = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsCierre = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdTotales = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsTitulo = New System.Windows.Forms.BindingSource(Me.components)
        Me.splitCorte = New System.Windows.Forms.SplitContainer()
        Me.splitEncabezado = New System.Windows.Forms.SplitContainer()
        Me.lblFechaCierre = New Azteca.Windows.Controls.CILabel()
        Me.lblFechaApertura = New Azteca.Windows.Controls.CILabel()
        Me.lblCaja = New Azteca.Windows.Controls.CILabel()
        Me.lblCorteCaja = New Azteca.Windows.Controls.CILabel()
        Me.AzToolBar1 = New Azteca.Windows.Controls.AZToolBar()
        Me.cmdLnkRegresar = New C1.Win.C1Command.C1Command()
        Me.tbCajas = New Azteca.Windows.Controls.AZToolBar()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdLnkImprimir = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink3 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdLnkImpresionPOS = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink4 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandControl1 = New C1.Win.C1Command.C1CommandControl()
        Me.btnSalir = New Azteca.Windows.Controls.CIButton()
        Me.CiStatusBar1 = New Azteca.Windows.Controls.CIStatusBar()
        Me.iLstMenu = New System.Windows.Forms.ImageList(Me.components)
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        CType(Me.grdDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCierre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdTotales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitCorte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitCorte.Panel1.SuspendLayout()
        Me.splitCorte.Panel2.SuspendLayout()
        Me.splitCorte.SuspendLayout()
        CType(Me.splitEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitEncabezado.Panel1.SuspendLayout()
        Me.splitEncabezado.Panel2.SuspendLayout()
        Me.splitEncabezado.SuspendLayout()
        Me.AzToolBar1.SuspendLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdDetalle
        '
        Me.grdDetalle.AllowUpdate = False
        Me.grdDetalle.AlternatingRows = True
        Me.grdDetalle.DataSource = Me.bsCierre
        Me.grdDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDetalle.FilterBar = True
        Me.grdDetalle.Images.Add(CType(resources.GetObject("grdDetalle.Images"), System.Drawing.Image))
        Me.grdDetalle.Location = New System.Drawing.Point(0, 0)
        Me.grdDetalle.Name = "grdDetalle"
        Me.grdDetalle.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdDetalle.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdDetalle.PreviewInfo.ZoomFactor = 75.0R
        Me.grdDetalle.PrintInfo.PageSettings = CType(resources.GetObject("grdDetalle.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdDetalle.Size = New System.Drawing.Size(902, 292)
        Me.grdDetalle.TabIndex = 0
        Me.grdDetalle.Text = "Detalle del Corte"
        Me.grdDetalle.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdDetalle.PropBag = resources.GetString("grdDetalle.PropBag")
        '
        'grdTotales
        '
        Me.grdTotales.AllowUpdate = False
        Me.grdTotales.AlternatingRows = True
        Me.grdTotales.ColumnFooters = True
        Me.grdTotales.DataSource = Me.bsTitulo
        Me.grdTotales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdTotales.Images.Add(CType(resources.GetObject("grdTotales.Images"), System.Drawing.Image))
        Me.grdTotales.Location = New System.Drawing.Point(0, 33)
        Me.grdTotales.Name = "grdTotales"
        Me.grdTotales.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdTotales.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdTotales.PreviewInfo.ZoomFactor = 75.0R
        Me.grdTotales.PrintInfo.PageSettings = CType(resources.GetObject("grdTotales.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdTotales.Size = New System.Drawing.Size(373, 136)
        Me.grdTotales.TabIndex = 1
        Me.grdTotales.Text = "AzTrueDBGrid2"
        Me.grdTotales.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdTotales.PropBag = resources.GetString("grdTotales.PropBag")
        '
        'splitCorte
        '
        Me.splitCorte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitCorte.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitCorte.Location = New System.Drawing.Point(0, 0)
        Me.splitCorte.Name = "splitCorte"
        Me.splitCorte.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitCorte.Panel1
        '
        Me.splitCorte.Panel1.Controls.Add(Me.splitEncabezado)
        '
        'splitCorte.Panel2
        '
        Me.splitCorte.Panel2.Controls.Add(Me.grdDetalle)
        Me.splitCorte.Size = New System.Drawing.Size(902, 465)
        Me.splitCorte.SplitterDistance = 169
        Me.splitCorte.TabIndex = 2
        '
        'splitEncabezado
        '
        Me.splitEncabezado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitEncabezado.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.splitEncabezado.Location = New System.Drawing.Point(0, 0)
        Me.splitEncabezado.Name = "splitEncabezado"
        '
        'splitEncabezado.Panel1
        '
        Me.splitEncabezado.Panel1.BackColor = System.Drawing.Color.White
        Me.splitEncabezado.Panel1.Controls.Add(Me.lblFechaCierre)
        Me.splitEncabezado.Panel1.Controls.Add(Me.lblFechaApertura)
        Me.splitEncabezado.Panel1.Controls.Add(Me.lblCaja)
        Me.splitEncabezado.Panel1.Controls.Add(Me.lblCorteCaja)
        Me.splitEncabezado.Panel1.Controls.Add(Me.AzToolBar1)
        '
        'splitEncabezado.Panel2
        '
        Me.splitEncabezado.Panel2.Controls.Add(Me.grdTotales)
        Me.splitEncabezado.Panel2.Controls.Add(Me.tbCajas)
        Me.splitEncabezado.Size = New System.Drawing.Size(902, 169)
        Me.splitEncabezado.SplitterDistance = 525
        Me.splitEncabezado.TabIndex = 0
        '
        'lblFechaCierre
        '
        Me.lblFechaCierre.BackColor = System.Drawing.Color.White
        Me.lblFechaCierre.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFechaCierre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaCierre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFechaCierre.Location = New System.Drawing.Point(0, 122)
        Me.lblFechaCierre.Name = "lblFechaCierre"
        Me.lblFechaCierre.Size = New System.Drawing.Size(525, 23)
        Me.lblFechaCierre.TabIndex = 11
        Me.lblFechaCierre.Text = "          Fecha Cierre"
        '
        'lblFechaApertura
        '
        Me.lblFechaApertura.BackColor = System.Drawing.Color.White
        Me.lblFechaApertura.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFechaApertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaApertura.ForeColor = System.Drawing.Color.Green
        Me.lblFechaApertura.Location = New System.Drawing.Point(0, 99)
        Me.lblFechaApertura.Name = "lblFechaApertura"
        Me.lblFechaApertura.Size = New System.Drawing.Size(525, 23)
        Me.lblFechaApertura.TabIndex = 10
        Me.lblFechaApertura.Text = "          Fecha Apertura"
        '
        'lblCaja
        '
        Me.lblCaja.BackColor = System.Drawing.Color.White
        Me.lblCaja.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaja.ForeColor = System.Drawing.Color.Black
        Me.lblCaja.Location = New System.Drawing.Point(0, 76)
        Me.lblCaja.Name = "lblCaja"
        Me.lblCaja.Size = New System.Drawing.Size(525, 23)
        Me.lblCaja.TabIndex = 7
        Me.lblCaja.Text = "     Caja"
        '
        'lblCorteCaja
        '
        Me.lblCorteCaja.BackColor = System.Drawing.Color.White
        Me.lblCorteCaja.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCorteCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorteCaja.ForeColor = System.Drawing.Color.Navy
        Me.lblCorteCaja.Location = New System.Drawing.Point(0, 33)
        Me.lblCorteCaja.Name = "lblCorteCaja"
        Me.lblCorteCaja.Size = New System.Drawing.Size(525, 43)
        Me.lblCorteCaja.TabIndex = 5
        Me.lblCorteCaja.Text = "Corte de Caja"
        '
        'AzToolBar1
        '
        Me.AzToolBar1.AccessibleName = "Tool Bar"
        Me.AzToolBar1.AutoSize = False
        Me.AzToolBar1.CommandHolder = Nothing
        Me.AzToolBar1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink4})
        Me.AzToolBar1.Controls.Add(Me.btnSalir)
        Me.AzToolBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.AzToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.AzToolBar1.MinButtonSize = 32
        Me.AzToolBar1.Movable = False
        Me.AzToolBar1.Name = "AzToolBar1"
        Me.AzToolBar1.Size = New System.Drawing.Size(525, 33)
        Me.AzToolBar1.Text = "AzToolBar1"
        Me.AzToolBar1.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Blue
        Me.AzToolBar1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue
        '
        'cmdLnkRegresar
        '
        Me.cmdLnkRegresar.ImageIndex = 1
        Me.cmdLnkRegresar.Name = "cmdLnkRegresar"
        Me.cmdLnkRegresar.ShortcutText = ""
        Me.cmdLnkRegresar.Text = "Regresar"
        '
        'tbCajas
        '
        Me.tbCajas.AccessibleName = "Tool Bar"
        Me.tbCajas.AutoSize = False
        Me.tbCajas.CommandHolder = Nothing
        Me.tbCajas.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink1, Me.C1CommandLink3})
        Me.tbCajas.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbCajas.Location = New System.Drawing.Point(0, 0)
        Me.tbCajas.MinButtonSize = 32
        Me.tbCajas.Movable = False
        Me.tbCajas.Name = "tbCajas"
        Me.tbCajas.Size = New System.Drawing.Size(373, 33)
        Me.tbCajas.Text = "AzToolBar1"
        Me.tbCajas.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Blue
        Me.tbCajas.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink1.Command = Me.cmdLnkImprimir
        '
        'cmdLnkImprimir
        '
        Me.cmdLnkImprimir.ImageIndex = 0
        Me.cmdLnkImprimir.Name = "cmdLnkImprimir"
        Me.cmdLnkImprimir.ShortcutText = ""
        Me.cmdLnkImprimir.Text = "Impresión Gráfica"
        '
        'C1CommandLink3
        '
        Me.C1CommandLink3.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink3.Command = Me.cmdLnkImpresionPOS
        Me.C1CommandLink3.Delimiter = True
        Me.C1CommandLink3.SortOrder = 1
        '
        'cmdLnkImpresionPOS
        '
        Me.cmdLnkImpresionPOS.ImageIndex = 0
        Me.cmdLnkImpresionPOS.Name = "cmdLnkImpresionPOS"
        Me.cmdLnkImpresionPOS.ShortcutText = ""
        Me.cmdLnkImpresionPOS.Text = "Impresión de Texto"
        '
        'C1CommandLink4
        '
        Me.C1CommandLink4.Command = Me.C1CommandControl1
        '
        'C1CommandControl1
        '
        Me.C1CommandControl1.Control = Me.btnSalir
        Me.C1CommandControl1.Name = "C1CommandControl1"
        Me.C1CommandControl1.ShortcutText = ""
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(2, 5)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 0
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'CiStatusBar1
        '
        Me.CiStatusBar1.Location = New System.Drawing.Point(0, 465)
        Me.CiStatusBar1.Name = "CiStatusBar1"
        Me.CiStatusBar1.Size = New System.Drawing.Size(902, 22)
        Me.CiStatusBar1.TabIndex = 3
        Me.CiStatusBar1.Text = "CiStatusBar1"
        '
        'iLstMenu
        '
        Me.iLstMenu.ImageStream = CType(resources.GetObject("iLstMenu.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.iLstMenu.TransparentColor = System.Drawing.Color.Transparent
        Me.iLstMenu.Images.SetKeyName(0, "Caja_64.png")
        Me.iLstMenu.Images.SetKeyName(1, "back_32.png")
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdLnkImprimir)
        Me.C1CommandHolder1.Commands.Add(Me.cmdLnkRegresar)
        Me.C1CommandHolder1.Commands.Add(Me.cmdLnkImpresionPOS)
        Me.C1CommandHolder1.Commands.Add(Me.C1CommandControl1)
        Me.C1CommandHolder1.ImageList = Me.iLstMenu
        Me.C1CommandHolder1.Owner = Me
        '
        'DetalleCorteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(902, 487)
        Me.Controls.Add(Me.splitCorte)
        Me.Controls.Add(Me.CiStatusBar1)
        Me.Name = "DetalleCorteForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle del Cierre de Caja..."
        CType(Me.grdDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCierre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdTotales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitCorte.Panel1.ResumeLayout(False)
        Me.splitCorte.Panel2.ResumeLayout(False)
        CType(Me.splitCorte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitCorte.ResumeLayout(False)
        Me.splitEncabezado.Panel1.ResumeLayout(False)
        Me.splitEncabezado.Panel2.ResumeLayout(False)
        CType(Me.splitEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitEncabezado.ResumeLayout(False)
        Me.AzToolBar1.ResumeLayout(False)
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdDetalle As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents grdTotales As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents splitCorte As System.Windows.Forms.SplitContainer
    Friend WithEvents splitEncabezado As System.Windows.Forms.SplitContainer
    Friend WithEvents CiStatusBar1 As Azteca.Windows.Controls.CIStatusBar
    Friend WithEvents lblCorteCaja As Azteca.Windows.Controls.CILabel
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents lblCaja As Azteca.Windows.Controls.CILabel
    Friend WithEvents AzToolBar1 As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents tbCajas As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink3 As C1.Win.C1Command.C1CommandLink
    Private WithEvents cmdLnkImprimir As C1.Win.C1Command.C1Command
    Private WithEvents iLstMenu As System.Windows.Forms.ImageList
    Private WithEvents cmdLnkImpresionPOS As C1.Win.C1Command.C1Command
    Private WithEvents cmdLnkRegresar As C1.Win.C1Command.C1Command
    Friend WithEvents lblFechaCierre As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblFechaApertura As Azteca.Windows.Controls.CILabel
    Friend WithEvents btnSalir As Azteca.Windows.Controls.CIButton
    Friend WithEvents C1CommandLink4 As C1.Win.C1Command.C1CommandLink
    Private WithEvents bsCierre As System.Windows.Forms.BindingSource
    Private WithEvents bsTitulo As System.Windows.Forms.BindingSource
    Private WithEvents C1CommandControl1 As C1.Win.C1Command.C1CommandControl
End Class
