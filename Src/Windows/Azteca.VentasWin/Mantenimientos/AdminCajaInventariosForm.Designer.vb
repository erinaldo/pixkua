<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminCajaInventariosForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminCajaInventariosForm))
        Me.tlbMenu = New Azteca.Windows.Controls.CIToolBar()
        Me.btnVerCortes = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnInventarioApply = New System.Windows.Forms.ToolStripButton()
        Me.lblDesde = New Azteca.Windows.Controls.CILabel()
        Me.dtpFechaIni = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.bsCortes = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdCortes = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.lblHasta = New Azteca.Windows.Controls.CILabel()
        Me.dtpFechaFin = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.tlbMenu.SuspendLayout()
        CType(Me.bsCortes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdCortes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlbMenu
        '
        Me.tlbMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tlbMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnVerCortes, Me.ToolStripSeparator1, Me.btnInventarioApply})
        Me.tlbMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlbMenu.Name = "tlbMenu"
        Me.tlbMenu.Size = New System.Drawing.Size(925, 39)
        Me.tlbMenu.TabIndex = 21
        Me.tlbMenu.Text = "CiToolBar1"
        '
        'btnVerCortes
        '
        Me.btnVerCortes.Image = Global.Azteca.Windows.Ventas.My.Resources.Resources.Informe
        Me.btnVerCortes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnVerCortes.Name = "btnVerCortes"
        Me.btnVerCortes.Size = New System.Drawing.Size(120, 36)
        Me.btnVerCortes.Text = "Lista de Cortes"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'btnInventarioApply
        '
        Me.btnInventarioApply.Image = CType(resources.GetObject("btnInventarioApply.Image"), System.Drawing.Image)
        Me.btnInventarioApply.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInventarioApply.Name = "btnInventarioApply"
        Me.btnInventarioApply.Size = New System.Drawing.Size(137, 36)
        Me.btnInventarioApply.Text = "Afectar Inventario"
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.Location = New System.Drawing.Point(41, 50)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(38, 13)
        Me.lblDesde.TabIndex = 20
        Me.lblDesde.Text = "Desde"
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaIni.Location = New System.Drawing.Point(85, 47)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(197, 20)
        Me.dtpFechaIni.TabIndex = 19
        '
        'grdCortes
        '
        Me.grdCortes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdCortes.DataSource = Me.bsCortes
        Me.grdCortes.Images.Add(CType(resources.GetObject("grdCortes.Images"), System.Drawing.Image))
        Me.grdCortes.Location = New System.Drawing.Point(0, 89)
        Me.grdCortes.Name = "grdCortes"
        Me.grdCortes.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdCortes.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdCortes.PreviewInfo.ZoomFactor = 75.0R
        Me.grdCortes.PrintInfo.PageSettings = CType(resources.GetObject("grdCortes.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdCortes.Size = New System.Drawing.Size(925, 338)
        Me.grdCortes.TabIndex = 22
        Me.grdCortes.Text = "AzTrueDBGrid1"
        Me.grdCortes.PropBag = resources.GetString("grdCortes.PropBag")
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Location = New System.Drawing.Point(295, 50)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(35, 13)
        Me.lblHasta.TabIndex = 24
        Me.lblHasta.Text = "Hasta"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaFin.Location = New System.Drawing.Point(336, 47)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(197, 20)
        Me.dtpFechaFin.TabIndex = 23
        '
        'AdminCajaInventariosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 426)
        Me.Controls.Add(Me.lblHasta)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.grdCortes)
        Me.Controls.Add(Me.tlbMenu)
        Me.Controls.Add(Me.lblDesde)
        Me.Controls.Add(Me.dtpFechaIni)
        Me.Name = "AdminCajaInventariosForm"
        Me.Text = "AdminCajaInventariosForm"
        Me.tlbMenu.ResumeLayout(False)
        Me.tlbMenu.PerformLayout()
        CType(Me.bsCortes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdCortes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tlbMenu As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnVerCortes As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnInventarioApply As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblDesde As Azteca.Windows.Controls.CILabel
    Friend WithEvents dtpFechaIni As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents bsCortes As System.Windows.Forms.BindingSource
    Friend WithEvents grdCortes As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents lblHasta As Azteca.Windows.Controls.CILabel
    Friend WithEvents dtpFechaFin As Azteca.Windows.Controls.CIDateTimePicker
End Class
