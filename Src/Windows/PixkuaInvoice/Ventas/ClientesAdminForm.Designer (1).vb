<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientesAdminForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientesAdminForm))
        Me.grdClientes = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsClientes = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grdClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdClientes
        '
        Me.grdClientes.AlternatingRows = True
        Me.grdClientes.DataSource = Me.bsClientes
        Me.grdClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdClientes.FilterBar = True
        Me.grdClientes.Images.Add(CType(resources.GetObject("grdClientes.Images"), System.Drawing.Image))
        Me.grdClientes.Images.Add(CType(resources.GetObject("grdClientes.Images1"), System.Drawing.Image))
        Me.grdClientes.Images.Add(CType(resources.GetObject("grdClientes.Images2"), System.Drawing.Image))
        Me.grdClientes.Location = New System.Drawing.Point(0, 32)
        Me.grdClientes.Name = "grdClientes"
        Me.grdClientes.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdClientes.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdClientes.PreviewInfo.ZoomFactor = 75.0R
        Me.grdClientes.PrintInfo.PageSettings = CType(resources.GetObject("grdVentas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdClientes.RowHeight = 17
        Me.grdClientes.Size = New System.Drawing.Size(866, 357)
        Me.grdClientes.TabIndex = 43
        Me.grdClientes.Text = "AzTrueDBGrid1"
        Me.grdClientes.PropBag = resources.GetString("grdClientes.PropBag")
        '
        'ClientesAdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 411)
        Me.Controls.Add(Me.grdClientes)
        Me.Name = "ClientesAdminForm"
        Me.Text = "ClientesAdminForm"
        Me.Controls.SetChildIndex(Me.grdClientes, 0)
        CType(Me.grdClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdClientes As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents bsClientes As System.Windows.Forms.BindingSource
End Class
