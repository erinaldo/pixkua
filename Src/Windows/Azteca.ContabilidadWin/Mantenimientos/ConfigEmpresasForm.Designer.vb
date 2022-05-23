<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigEmpresasForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfigEmpresasForm))
        Me.tlbMenuEmpresa = New Azteca.Windows.Controls.CIToolBar()
        Me.btnGuardarEmpresas = New System.Windows.Forms.ToolStripButton()
        Me.bsEmpresas = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlEmpresa = New Azteca.Windows.Controls.CIPanel()
        Me.grdEmpresas = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.tlbMenuEmpresa.SuspendLayout()
        CType(Me.bsEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEmpresa.SuspendLayout()
        CType(Me.grdEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlbMenuEmpresa
        '
        Me.tlbMenuEmpresa.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tlbMenuEmpresa.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGuardarEmpresas})
        Me.tlbMenuEmpresa.Location = New System.Drawing.Point(0, 0)
        Me.tlbMenuEmpresa.Name = "tlbMenuEmpresa"
        Me.tlbMenuEmpresa.Size = New System.Drawing.Size(755, 39)
        Me.tlbMenuEmpresa.TabIndex = 8
        Me.tlbMenuEmpresa.Text = "CiToolBar1"
        '
        'btnGuardarEmpresas
        '
        Me.btnGuardarEmpresas.Image = Global.Azteca.Windows.Contabilidad.My.Resources.Resources.diskette_32
        Me.btnGuardarEmpresas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardarEmpresas.Name = "btnGuardarEmpresas"
        Me.btnGuardarEmpresas.Size = New System.Drawing.Size(135, 36)
        Me.btnGuardarEmpresas.Text = "Guardar Cambios"
        '
        'pnlEmpresa
        '
        Me.pnlEmpresa.Controls.Add(Me.grdEmpresas)
        Me.pnlEmpresa.Controls.Add(Me.tlbMenuEmpresa)
        Me.pnlEmpresa.GradientColorA = System.Drawing.SystemColors.ControlLight
        Me.pnlEmpresa.GradientColorB = System.Drawing.SystemColors.ControlDark
        Me.pnlEmpresa.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.pnlEmpresa.Location = New System.Drawing.Point(6, 12)
        Me.pnlEmpresa.Name = "pnlEmpresa"
        Me.pnlEmpresa.Size = New System.Drawing.Size(755, 404)
        Me.pnlEmpresa.TabIndex = 9
        Me.pnlEmpresa.UseGradient = False
        '
        'grdEmpresas
        '
        Me.grdEmpresas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdEmpresas.ExtendRightColumn = True
        Me.grdEmpresas.Images.Add(CType(resources.GetObject("grdEmpresas.Images"), System.Drawing.Image))
        Me.grdEmpresas.Location = New System.Drawing.Point(0, 39)
        Me.grdEmpresas.Name = "grdEmpresas"
        Me.grdEmpresas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdEmpresas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdEmpresas.PreviewInfo.ZoomFactor = 75.0R
        Me.grdEmpresas.PrintInfo.PageSettings = CType(resources.GetObject("grdEmpresas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdEmpresas.Size = New System.Drawing.Size(755, 365)
        Me.grdEmpresas.TabIndex = 28
        Me.grdEmpresas.Text = "AzTrueDBGrid1"
        Me.grdEmpresas.PropBag = resources.GetString("grdEmpresas.PropBag")
        '
        'ConfigEmpresasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 441)
        Me.Controls.Add(Me.pnlEmpresa)
        Me.Name = "ConfigEmpresasForm"
        Me.Text = "ConfigEmpresasForm"
        Me.tlbMenuEmpresa.ResumeLayout(False)
        Me.tlbMenuEmpresa.PerformLayout()
        CType(Me.bsEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEmpresa.ResumeLayout(False)
        Me.pnlEmpresa.PerformLayout()
        CType(Me.grdEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlbMenuEmpresa As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnGuardarEmpresas As System.Windows.Forms.ToolStripButton
    Friend WithEvents bsEmpresas As System.Windows.Forms.BindingSource
    Friend WithEvents pnlEmpresa As Azteca.Windows.Controls.CIPanel
    Friend WithEvents grdEmpresas As Azteca.Windows.Controls.AZTrueDBGrid
End Class
