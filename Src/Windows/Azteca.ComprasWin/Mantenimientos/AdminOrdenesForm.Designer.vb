<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminOrdenesForm
    Inherits Azteca.Windows.Forms.BusinessForms.DocumentAdminForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminOrdenesForm))
        Me.bsOrdenes = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdOrdenes = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        CType(Me.bsOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdOrdenes
        '
        Me.grdOrdenes.DataSource = Me.bsOrdenes
        Me.grdOrdenes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdOrdenes.FilterBar = True
        Me.grdOrdenes.Images.Add(CType(resources.GetObject("grdOrdenes.Images"), System.Drawing.Image))
        Me.grdOrdenes.Images.Add(CType(resources.GetObject("grdOrdenes.Images1"), System.Drawing.Image))
        Me.grdOrdenes.Location = New System.Drawing.Point(177, 64)
        Me.grdOrdenes.Name = "grdOrdenes"
        Me.grdOrdenes.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdOrdenes.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdOrdenes.PreviewInfo.ZoomFactor = 75.0R
        Me.grdOrdenes.PrintInfo.PageSettings = CType(resources.GetObject("grdOrdenes.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdOrdenes.Size = New System.Drawing.Size(724, 372)
        Me.grdOrdenes.TabIndex = 23
        Me.grdOrdenes.Text = "C1TrueDBGrid1"
        Me.grdOrdenes.PropBag = resources.GetString("grdOrdenes.PropBag")
        '
        'AdminOrdenesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 458)
        Me.Controls.Add(Me.grdOrdenes)
        Me.DocumentBindingSource = Me.bsOrdenes
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "AdminOrdenesForm"
        Me.Text = "AdminOrdenesForm"
        Me.Controls.SetChildIndex(Me.grdOrdenes, 0)
        CType(Me.bsOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bsOrdenes As System.Windows.Forms.BindingSource
    Friend WithEvents grdOrdenes As C1.Win.C1TrueDBGrid.C1TrueDBGrid

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LicenseModule = Kernel.Licensing.LicenseModule.Purchasing
        Dim ConfigFac As New Azteca.Kernel.Configuration.ConfigurationFacade
        Dim idDoc As Integer = CInt(ConfigFac.GetSystemParameter("Configuracion/Documentos/Tipos", "OrdenCompra"))
        Me.DocumentFacade = New OrdenFacade
        Me.DocumentTypeID = idDoc
        Me.DocumentBindingSource = bsOrdenes
    End Sub
End Class
