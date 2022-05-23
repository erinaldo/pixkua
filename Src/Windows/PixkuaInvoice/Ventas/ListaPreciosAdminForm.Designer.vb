<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaPreciosAdminForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListaPreciosAdminForm))
        Me.grdListas = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsLista = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grdListas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdListas
        '
        Me.grdListas.AlternatingRows = True
        Me.grdListas.DataSource = Me.bsLista
        Me.grdListas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdListas.FilterBar = True
        Me.grdListas.Images.Add(CType(resources.GetObject("grdListas.Images"), System.Drawing.Image))
        Me.grdListas.Images.Add(CType(resources.GetObject("grdListas.Images1"), System.Drawing.Image))
        Me.grdListas.Location = New System.Drawing.Point(0, 32)
        Me.grdListas.Name = "grdListas"
        Me.grdListas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdListas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdListas.PreviewInfo.ZoomFactor = 75.0R
        Me.grdListas.PrintInfo.PageSettings = CType(resources.GetObject("grdListas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdListas.RowHeight = 17
        Me.grdListas.Size = New System.Drawing.Size(725, 305)
        Me.grdListas.TabIndex = 48
        Me.grdListas.Text = "AzTrueDBGrid1"
        Me.grdListas.PropBag = resources.GetString("grdListas.PropBag")
        '
        'ListaPreciosAdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 359)
        Me.Controls.Add(Me.grdListas)
        Me.Name = "ListaPreciosAdminForm"
        Me.Text = "ListaPreciosAdminForm"
        Me.Controls.SetChildIndex(Me.grdListas, 0)
        CType(Me.grdListas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdListas As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents bsLista As System.Windows.Forms.BindingSource
End Class
