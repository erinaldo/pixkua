<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CertificadosAdminForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CertificadosAdminForm))
        Me.grdCertificados = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsCertificados = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grdCertificados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCertificados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdCertificados
        '
        Me.grdCertificados.AlternatingRows = True
        Me.grdCertificados.DataSource = Me.bsCertificados
        Me.grdCertificados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdCertificados.FilterBar = True
        Me.grdCertificados.Images.Add(CType(resources.GetObject("grdCertificados.Images"), System.Drawing.Image))
        Me.grdCertificados.Images.Add(CType(resources.GetObject("grdCertificados.Images1"), System.Drawing.Image))
        Me.grdCertificados.Images.Add(CType(resources.GetObject("grdCertificados.Images2"), System.Drawing.Image))
        Me.grdCertificados.Location = New System.Drawing.Point(0, 32)
        Me.grdCertificados.Name = "grdCertificados"
        Me.grdCertificados.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdCertificados.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdCertificados.PreviewInfo.ZoomFactor = 75.0R
        Me.grdCertificados.PrintInfo.PageSettings = CType(resources.GetObject("grdCertificados.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdCertificados.RowHeight = 17
        Me.grdCertificados.Size = New System.Drawing.Size(800, 345)
        Me.grdCertificados.TabIndex = 45
        Me.grdCertificados.Text = "AzTrueDBGrid1"
        Me.grdCertificados.PropBag = resources.GetString("grdCertificados.PropBag")
        '
        'CertificadosAdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 399)
        Me.Controls.Add(Me.grdCertificados)
        Me.Name = "CertificadosAdminForm"
        Me.Text = "CertificadosAdminForm"
        Me.Controls.SetChildIndex(Me.grdCertificados, 0)
        CType(Me.grdCertificados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCertificados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdCertificados As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents bsCertificados As System.Windows.Forms.BindingSource
End Class
