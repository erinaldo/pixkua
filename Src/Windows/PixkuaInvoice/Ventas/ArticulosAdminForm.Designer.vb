<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArticulosAdminForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ArticulosAdminForm))
        Me.bsArticulos = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdArticulos = New Azteca.Windows.Controls.AZTrueDBGrid()
        CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdArticulos
        '
        Me.grdArticulos.AlternatingRows = True
        Me.grdArticulos.DataSource = Me.bsArticulos
        Me.grdArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdArticulos.FilterBar = True
        Me.grdArticulos.Images.Add(CType(resources.GetObject("grdArticulos.Images"), System.Drawing.Image))
        Me.grdArticulos.Images.Add(CType(resources.GetObject("grdArticulos.Images1"), System.Drawing.Image))
        Me.grdArticulos.Images.Add(CType(resources.GetObject("grdArticulos.Images2"), System.Drawing.Image))
        Me.grdArticulos.Location = New System.Drawing.Point(0, 32)
        Me.grdArticulos.Name = "grdArticulos"
        Me.grdArticulos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdArticulos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdArticulos.PreviewInfo.ZoomFactor = 75.0R
        Me.grdArticulos.PrintInfo.PageSettings = CType(resources.GetObject("grdEmpresas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdArticulos.RowHeight = 17
        Me.grdArticulos.Size = New System.Drawing.Size(961, 379)
        Me.grdArticulos.TabIndex = 45
        Me.grdArticulos.Text = "AzTrueDBGrid1"
        Me.grdArticulos.PropBag = resources.GetString("grdArticulos.PropBag")
        '
        'ArticulosAdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 433)
        Me.Controls.Add(Me.grdArticulos)
        Me.Name = "ArticulosAdminForm"
        Me.Text = "ArticulosAdminForm"
        Me.Controls.SetChildIndex(Me.grdArticulos, 0)
        CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bsArticulos As System.Windows.Forms.BindingSource
    Friend WithEvents grdArticulos As Azteca.Windows.Controls.AZTrueDBGrid

End Class
