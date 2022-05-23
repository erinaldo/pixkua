<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotasAdminForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NotasAdminForm))
        Me.bsNotas = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdNotas = New Azteca.Windows.Controls.AZTrueDBGrid()
        CType(Me.bsNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdNotas
        '
        Me.grdNotas.AlternatingRows = True
        Me.grdNotas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdNotas.DataSource = Me.bsNotas
        Me.grdNotas.FilterBar = True
        Me.grdNotas.Images.Add(CType(resources.GetObject("grdNotas.Images"), System.Drawing.Image))
        Me.grdNotas.Images.Add(CType(resources.GetObject("grdNotas.Images1"), System.Drawing.Image))
        Me.grdNotas.Images.Add(CType(resources.GetObject("grdNotas.Images2"), System.Drawing.Image))
        Me.grdNotas.Images.Add(CType(resources.GetObject("grdNotas.Images3"), System.Drawing.Image))
        Me.grdNotas.Location = New System.Drawing.Point(174, 63)
        Me.grdNotas.Name = "grdNotas"
        Me.grdNotas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdNotas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdNotas.PreviewInfo.ZoomFactor = 75.0R
        Me.grdNotas.PrintInfo.PageSettings = CType(resources.GetObject("grdNotas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdNotas.RowHeight = 17
        Me.grdNotas.Size = New System.Drawing.Size(674, 319)
        Me.grdNotas.TabIndex = 43
        Me.grdNotas.Text = "AzTrueDBGrid1"
        Me.grdNotas.PropBag = resources.GetString("grdNotas.PropBag")
        '
        'NotasAdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 404)
        Me.Controls.Add(Me.grdNotas)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "NotasAdminForm"
        Me.Text = "NotasAdminForm"
        Me.Controls.SetChildIndex(Me.grdNotas, 0)
        CType(Me.bsNotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdNotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        LicenseModule = Azteca.Kernel.Licensing.LicenseModule.Sales
        Me.DocumentFacade = New Azteca.Business.Contabilidad.NotaFacade

        Dim ConfigFac As New Azteca.Kernel.Configuration.ConfigurationFacade
        Dim idDoc As Integer = CInt(ConfigFac.GetSystemParameter("Configuracion/Documentos/Tipos", "Venta"))
        Me.DocumentTypeID = idDoc
        Me.DocumentBindingSource = bsNotas

    End Sub
    Friend WithEvents bsNotas As System.Windows.Forms.BindingSource
    Friend WithEvents grdNotas As Azteca.Windows.Controls.AZTrueDBGrid

End Class
