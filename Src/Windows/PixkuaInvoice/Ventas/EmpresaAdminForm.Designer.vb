<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpresaAdminForm
    Inherits Azteca.Windows.Forms.BusinessForms.CatalogAdminListForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmpresaAdminForm))
        Me.grdEmpresas = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsEmpresas = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grdEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdEmpresas
        '
        Me.grdEmpresas.AlternatingRows = True
        Me.grdEmpresas.DataSource = Me.bsEmpresas
        Me.grdEmpresas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdEmpresas.FilterBar = True
        Me.grdEmpresas.Images.Add(CType(resources.GetObject("grdEmpresas.Images"), System.Drawing.Image))
        Me.grdEmpresas.Images.Add(CType(resources.GetObject("grdEmpresas.Images1"), System.Drawing.Image))
        Me.grdEmpresas.Images.Add(CType(resources.GetObject("grdEmpresas.Images2"), System.Drawing.Image))
        Me.grdEmpresas.Location = New System.Drawing.Point(0, 32)
        Me.grdEmpresas.Name = "grdEmpresas"
        Me.grdEmpresas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdEmpresas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdEmpresas.PreviewInfo.ZoomFactor = 75.0R
        Me.grdEmpresas.PrintInfo.PageSettings = CType(resources.GetObject("grdEmpresas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdEmpresas.RowHeight = 17
        Me.grdEmpresas.Size = New System.Drawing.Size(799, 335)
        Me.grdEmpresas.TabIndex = 44
        Me.grdEmpresas.Text = "AzTrueDBGrid1"
        Me.grdEmpresas.PropBag = resources.GetString("grdEmpresas.PropBag")
        '
        'EmpresaAdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 389)
        Me.Controls.Add(Me.grdEmpresas)
        Me.Name = "EmpresaAdminForm"
        Me.Text = "EmpresaAdminForm"
        Me.Controls.SetChildIndex(Me.grdEmpresas, 0)
        CType(Me.grdEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdEmpresas As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents bsEmpresas As System.Windows.Forms.BindingSource
End Class
