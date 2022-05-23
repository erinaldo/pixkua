<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CerrarCajaForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CerrarCajaForm))
        Me.AzTrueDBGrid1 = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsCierre = New System.Windows.Forms.BindingSource(Me.components)
        Me.AzTrueDBGrid2 = New Azteca.Windows.Controls.AZTrueDBGrid()
        CType(Me.AzTrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCierre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AzTrueDBGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AzTrueDBGrid1
        '
        Me.AzTrueDBGrid1.AllowUpdate = False
        Me.AzTrueDBGrid1.AlternatingRows = True
        Me.AzTrueDBGrid1.DataSource = Me.bsCierre
        Me.AzTrueDBGrid1.FilterBar = True
        Me.AzTrueDBGrid1.Images.Add(CType(resources.GetObject("AzTrueDBGrid1.Images"), System.Drawing.Image))
        Me.AzTrueDBGrid1.Location = New System.Drawing.Point(-1, 135)
        Me.AzTrueDBGrid1.Name = "AzTrueDBGrid1"
        Me.AzTrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.AzTrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.AzTrueDBGrid1.PreviewInfo.ZoomFactor = 75.0R
        Me.AzTrueDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("AzTrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.AzTrueDBGrid1.Size = New System.Drawing.Size(896, 253)
        Me.AzTrueDBGrid1.TabIndex = 0
        Me.AzTrueDBGrid1.Text = "Detalle del Corte"
        Me.AzTrueDBGrid1.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.AzTrueDBGrid1.PropBag = resources.GetString("AzTrueDBGrid1.PropBag")
        '
        'AzTrueDBGrid2
        '
        Me.AzTrueDBGrid2.AllowUpdate = False
        Me.AzTrueDBGrid2.AlternatingRows = True
        Me.AzTrueDBGrid2.DataSource = Me.bsCierre
        Me.AzTrueDBGrid2.FilterBar = True
        Me.AzTrueDBGrid2.Images.Add(CType(resources.GetObject("AzTrueDBGrid2.Images"), System.Drawing.Image))
        Me.AzTrueDBGrid2.Location = New System.Drawing.Point(512, 1)
        Me.AzTrueDBGrid2.Name = "AzTrueDBGrid2"
        Me.AzTrueDBGrid2.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.AzTrueDBGrid2.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.AzTrueDBGrid2.PreviewInfo.ZoomFactor = 75.0R
        Me.AzTrueDBGrid2.PrintInfo.PageSettings = CType(resources.GetObject("AzTrueDBGrid2.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.AzTrueDBGrid2.Size = New System.Drawing.Size(382, 128)
        Me.AzTrueDBGrid2.TabIndex = 1
        Me.AzTrueDBGrid2.Text = "AzTrueDBGrid2"
        Me.AzTrueDBGrid2.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.AzTrueDBGrid2.PropBag = resources.GetString("AzTrueDBGrid2.PropBag")
        '
        'CerrarCajaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 414)
        Me.Controls.Add(Me.AzTrueDBGrid2)
        Me.Controls.Add(Me.AzTrueDBGrid1)
        Me.Name = "CerrarCajaForm"
        Me.Text = "CerrarCajaForm"
        CType(Me.AzTrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCierre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AzTrueDBGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AzTrueDBGrid1 As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents bsCierre As System.Windows.Forms.BindingSource
    Friend WithEvents AzTrueDBGrid2 As Azteca.Windows.Controls.AZTrueDBGrid
End Class
