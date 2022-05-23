<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnidadesNegocioAdminForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UnidadesNegocioAdminForm))
        Me.bsUnidad = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdUnidades = New Azteca.Windows.Controls.AZTrueDBGrid()
        CType(Me.bsUnidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdUnidades
        '
        Me.grdUnidades.AlternatingRows = True
        Me.grdUnidades.DataSource = Me.bsUnidad
        Me.grdUnidades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdUnidades.FilterBar = True
        Me.grdUnidades.Images.Add(CType(resources.GetObject("grdUnidades.Images"), System.Drawing.Image))
        Me.grdUnidades.Images.Add(CType(resources.GetObject("grdUnidades.Images1"), System.Drawing.Image))
        Me.grdUnidades.Location = New System.Drawing.Point(0, 32)
        Me.grdUnidades.Name = "grdUnidades"
        Me.grdUnidades.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdUnidades.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdUnidades.PreviewInfo.ZoomFactor = 75.0R
        Me.grdUnidades.PrintInfo.PageSettings = CType(resources.GetObject("grdUnidades.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdUnidades.RowHeight = 17
        Me.grdUnidades.Size = New System.Drawing.Size(771, 360)
        Me.grdUnidades.TabIndex = 47
        Me.grdUnidades.Text = "AzTrueDBGrid1"
        Me.grdUnidades.PropBag = resources.GetString("grdUnidades.PropBag")
        '
        'UnidadesNegocioAdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 414)
        Me.Controls.Add(Me.grdUnidades)
        Me.Name = "UnidadesNegocioAdminForm"
        Me.Text = "UnidadesNegocioAdminForm"
        Me.Controls.SetChildIndex(Me.grdUnidades, 0)
        CType(Me.bsUnidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'Me.MainToolBar.CommandLinks(
        Me.CommandHolder.Commands("cmdNuevo").Visible = False
    End Sub
    Friend WithEvents bsUnidad As System.Windows.Forms.BindingSource
    Friend WithEvents grdUnidades As Azteca.Windows.Controls.AZTrueDBGrid
End Class
