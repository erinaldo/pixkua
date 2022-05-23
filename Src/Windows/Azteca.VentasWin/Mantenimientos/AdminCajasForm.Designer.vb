<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminCajasForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminCajasForm))
        Me.tlbMenu = New Azteca.Windows.Controls.CIToolBar()
        Me.btnVerCortes = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAbrir = New System.Windows.Forms.ToolStripButton()
        Me.btnCerrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnImpresionCorte = New System.Windows.Forms.ToolStripButton()
        Me.grdCajas = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsCajas = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblCajas = New Azteca.Windows.Controls.CILabel()
        Me.tlbMenu.SuspendLayout()
        CType(Me.grdCajas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCajas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlbMenu
        '
        Me.tlbMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tlbMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnVerCortes, Me.ToolStripSeparator1, Me.btnAbrir, Me.btnCerrar, Me.ToolStripSeparator2, Me.btnImpresionCorte})
        Me.tlbMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlbMenu.Name = "tlbMenu"
        Me.tlbMenu.Size = New System.Drawing.Size(800, 39)
        Me.tlbMenu.TabIndex = 5
        Me.tlbMenu.Text = "CiToolBar1"
        '
        'btnVerCortes
        '
        Me.btnVerCortes.Image = Global.Azteca.Windows.Ventas.My.Resources.Resources.Informe
        Me.btnVerCortes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnVerCortes.Name = "btnVerCortes"
        Me.btnVerCortes.Size = New System.Drawing.Size(114, 36)
        Me.btnVerCortes.Text = "Lista de Cajas"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'btnAbrir
        '
        Me.btnAbrir.Image = Global.Azteca.Windows.Ventas.My.Resources.Resources.unlock_32
        Me.btnAbrir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.Size = New System.Drawing.Size(69, 36)
        Me.btnAbrir.Text = "Abrir"
        '
        'btnCerrar
        '
        Me.btnCerrar.Image = Global.Azteca.Windows.Ventas.My.Resources.Resources.lock_32
        Me.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 36)
        Me.btnCerrar.Text = "Cerrar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'btnImpresionCorte
        '
        Me.btnImpresionCorte.Image = CType(resources.GetObject("btnImpresionCorte.Image"), System.Drawing.Image)
        Me.btnImpresionCorte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImpresionCorte.Name = "btnImpresionCorte"
        Me.btnImpresionCorte.Size = New System.Drawing.Size(128, 36)
        Me.btnImpresionCorte.Text = "Impresion Corte"
        '
        'grdCajas
        '
        Me.grdCajas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdCajas.DataSource = Me.bsCajas
        Me.grdCajas.Images.Add(CType(resources.GetObject("grdCajas.Images"), System.Drawing.Image))
        Me.grdCajas.Location = New System.Drawing.Point(12, 72)
        Me.grdCajas.Name = "grdCajas"
        Me.grdCajas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdCajas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdCajas.PreviewInfo.ZoomFactor = 75.0R
        Me.grdCajas.PrintInfo.PageSettings = CType(resources.GetObject("grdCajas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdCajas.Size = New System.Drawing.Size(776, 347)
        Me.grdCajas.TabIndex = 6
        Me.grdCajas.Text = "AzTrueDBGrid1"
        Me.grdCajas.PropBag = resources.GetString("grdCajas.PropBag")
        '
        'lblCajas
        '
        Me.lblCajas.AutoSize = True
        Me.lblCajas.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblCajas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCajas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCajas.Location = New System.Drawing.Point(12, 52)
        Me.lblCajas.Name = "lblCajas"
        Me.lblCajas.Size = New System.Drawing.Size(399, 18)
        Me.lblCajas.TabIndex = 7
        Me.lblCajas.Text = "Listado de cajas disponibles  y Cortes actuales correspondientes"
        '
        'AdminCajasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 444)
        Me.Controls.Add(Me.lblCajas)
        Me.Controls.Add(Me.tlbMenu)
        Me.Controls.Add(Me.grdCajas)
        Me.Name = "AdminCajasForm"
        Me.Text = "CortesForm"
        Me.Controls.SetChildIndex(Me.grdCajas, 0)
        Me.Controls.SetChildIndex(Me.tlbMenu, 0)
        Me.Controls.SetChildIndex(Me.lblCajas, 0)
        Me.tlbMenu.ResumeLayout(False)
        Me.tlbMenu.PerformLayout()
        CType(Me.grdCajas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCajas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tlbMenu As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnAbrir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnVerCortes As System.Windows.Forms.ToolStripButton
    Friend WithEvents bsCajas As System.Windows.Forms.BindingSource
    Friend WithEvents grdCajas As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnImpresionCorte As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblCajas As Azteca.Windows.Controls.CILabel
End Class
