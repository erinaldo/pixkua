<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GastosAdminForm
    Inherits Azteca.Windows.Forms.BusinessForms.DocumentAdminForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GastosAdminForm))
        Me.grdGastos = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsGastos = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grdGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdGastos
        '
        Me.grdGastos.AlternatingRows = True
        Me.grdGastos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdGastos.DataSource = Me.bsGastos
        Me.grdGastos.FilterBar = True
        Me.grdGastos.Images.Add(CType(resources.GetObject("grdGastos.Images"), System.Drawing.Image))
        Me.grdGastos.Images.Add(CType(resources.GetObject("grdGastos.Images1"), System.Drawing.Image))
        Me.grdGastos.Location = New System.Drawing.Point(183, 65)
        Me.grdGastos.Name = "grdGastos"
        Me.grdGastos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdGastos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdGastos.PreviewInfo.ZoomFactor = 75.0R
        Me.grdGastos.PrintInfo.PageSettings = CType(resources.GetObject("grdGastos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdGastos.RowHeight = 17
        Me.grdGastos.Size = New System.Drawing.Size(753, 335)
        Me.grdGastos.TabIndex = 41
        Me.grdGastos.Text = "AzTrueDBGrid1"
        Me.grdGastos.PropBag = resources.GetString("grdGastos.PropBag")
        '
        'GastosAdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 424)
        Me.Controls.Add(Me.grdGastos)
        Me.DocumentBindingSource = Me.bsGastos
        Me.DocumentTypeID = 16
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "GastosAdminForm"
        Me.Text = "GastosAdminForm"
        Me.Controls.SetChildIndex(Me.grdGastos, 0)
        CType(Me.grdGastos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsGastos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdGastos As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents bsGastos As System.Windows.Forms.BindingSource

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        LicenseModule = Kernel.Licensing.LicenseModule.Purchasing
        Me.DocumentFacade = New GastoFacade

        Dim ConfigFac As New Azteca.Kernel.Configuration.ConfigurationFacade
        Dim idDoc As Integer = CInt(ConfigFac.GetSystemParameter("Configuracion/Documentos/Tipos", "Gasto"))
        Me.DocumentTypeID = idDoc
        Me.DocumentBindingSource = bsGastos
    End Sub

End Class
