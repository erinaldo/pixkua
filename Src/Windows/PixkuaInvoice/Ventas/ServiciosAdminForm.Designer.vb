<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServiciosAdminForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ServiciosAdminForm))
        Me.bsServicios = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdServicios = New Azteca.Windows.Controls.AZTrueDBGrid()
        CType(Me.bsServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdServicios
        '
        Me.grdServicios.AlternatingRows = True
        Me.grdServicios.DataSource = Me.bsServicios
        Me.grdServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdServicios.FilterBar = True
        Me.grdServicios.Images.Add(CType(resources.GetObject("grdServicios.Images"), System.Drawing.Image))
        Me.grdServicios.Images.Add(CType(resources.GetObject("grdServicios.Images1"), System.Drawing.Image))
        Me.grdServicios.Images.Add(CType(resources.GetObject("grdServicios.Images2"), System.Drawing.Image))
        Me.grdServicios.Location = New System.Drawing.Point(0, 32)
        Me.grdServicios.Name = "grdServicios"
        Me.grdServicios.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdServicios.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdServicios.PreviewInfo.ZoomFactor = 75.0R
        Me.grdServicios.PrintInfo.PageSettings = CType(resources.GetObject("grdServicios.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdServicios.RowHeight = 17
        Me.grdServicios.Size = New System.Drawing.Size(793, 364)
        Me.grdServicios.TabIndex = 46
        Me.grdServicios.Text = "AzTrueDBGrid1"
        Me.grdServicios.PropBag = resources.GetString("grdServicios.PropBag")
        '
        'ServiciosAdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 418)
        Me.Controls.Add(Me.grdServicios)
        Me.Name = "ServiciosAdminForm"
        Me.Text = "ServiciosAdminForm"
        Me.Controls.SetChildIndex(Me.grdServicios, 0)
        CType(Me.bsServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bsServicios As System.Windows.Forms.BindingSource
    Friend WithEvents grdServicios As Azteca.Windows.Controls.AZTrueDBGrid

   

End Class
