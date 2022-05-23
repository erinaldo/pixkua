<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ColoresListForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ColoresListForm))
        Me.grdColores = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsColores = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grdColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsColores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdColores
        '
        Me.grdColores.AlternatingRows = True
        Me.grdColores.DataSource = Me.bsColores
        Me.grdColores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdColores.FilterBar = True
        Me.grdColores.Images.Add(CType(resources.GetObject("grdColores.Images"), System.Drawing.Image))
        Me.grdColores.Images.Add(CType(resources.GetObject("grdColores.Images1"), System.Drawing.Image))
        Me.grdColores.Images.Add(CType(resources.GetObject("grdColores.Images2"), System.Drawing.Image))
        Me.grdColores.Location = New System.Drawing.Point(0, 32)
        Me.grdColores.Name = "grdColores"
        Me.grdColores.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdColores.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdColores.PreviewInfo.ZoomFactor = 75.0R
        Me.grdColores.PrintInfo.PageSettings = CType(resources.GetObject("grdCertificados.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdColores.RowHeight = 17
        Me.grdColores.Size = New System.Drawing.Size(725, 305)
        Me.grdColores.TabIndex = 46
        Me.grdColores.Text = "AzTrueDBGrid1"
        Me.grdColores.PropBag = resources.GetString("grdColores.PropBag")
        '
        'ColoresListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 359)
        Me.Controls.Add(Me.grdColores)
        Me.Name = "ColoresListForm"
        Me.Text = "ColoresListForm"
        Me.Controls.SetChildIndex(Me.grdColores, 0)
        CType(Me.grdColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsColores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdColores As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents bsColores As System.Windows.Forms.BindingSource
End Class
