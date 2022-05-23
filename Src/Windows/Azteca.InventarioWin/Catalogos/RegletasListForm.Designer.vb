<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegletasListForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegletasListForm))
        Me.grdRegletas = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsRegletas = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grdRegletas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsRegletas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdRegletas
        '
        Me.grdRegletas.AlternatingRows = True
        Me.grdRegletas.DataSource = Me.bsRegletas
        Me.grdRegletas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdRegletas.FilterBar = True
        Me.grdRegletas.Images.Add(CType(resources.GetObject("grdRegletas.Images"), System.Drawing.Image))
        Me.grdRegletas.Images.Add(CType(resources.GetObject("grdRegletas.Images1"), System.Drawing.Image))
        Me.grdRegletas.Images.Add(CType(resources.GetObject("grdRegletas.Images2"), System.Drawing.Image))
        Me.grdRegletas.Location = New System.Drawing.Point(0, 32)
        Me.grdRegletas.Name = "grdRegletas"
        Me.grdRegletas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdRegletas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdRegletas.PreviewInfo.ZoomFactor = 75.0R
        Me.grdRegletas.PrintInfo.PageSettings = CType(resources.GetObject("grdRegletas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdRegletas.RowHeight = 17
        Me.grdRegletas.Size = New System.Drawing.Size(725, 305)
        Me.grdRegletas.TabIndex = 47
        Me.grdRegletas.Text = "AzTrueDBGrid1"
        Me.grdRegletas.PropBag = resources.GetString("grdRegletas.PropBag")
        '
        'RegletasListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 359)
        Me.Controls.Add(Me.grdRegletas)
        Me.Name = "RegletasListForm"
        Me.Text = "RegletasListForm"
        Me.Controls.SetChildIndex(Me.grdRegletas, 0)
        CType(Me.grdRegletas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsRegletas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bsRegletas As System.Windows.Forms.BindingSource
    Friend WithEvents grdRegletas As Azteca.Windows.Controls.AZTrueDBGrid
End Class
