<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RequisicionesAdminForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RequisicionesAdminForm))
        Me.imgLst = New System.Windows.Forms.ImageList(Me.components)
        Me.bsRequisiciones = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdRequisiciones = New Azteca.Windows.Controls.AZTrueDBGrid()
        CType(Me.bsRequisiciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdRequisiciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgLst
        '
        Me.imgLst.ImageStream = CType(resources.GetObject("imgLst.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgLst.TransparentColor = System.Drawing.Color.Transparent
        Me.imgLst.Images.SetKeyName(0, "0")
        Me.imgLst.Images.SetKeyName(1, "1")
        Me.imgLst.Images.SetKeyName(2, "3")
        Me.imgLst.Images.SetKeyName(3, "10")
        '
        'grdRequisiciones
        '
        Me.grdRequisiciones.AlternatingRows = True
        Me.grdRequisiciones.DataSource = Me.bsRequisiciones
        Me.grdRequisiciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdRequisiciones.FilterBar = True
        Me.grdRequisiciones.Images.Add(CType(resources.GetObject("grdRequisiciones.Images"), System.Drawing.Image))
        Me.grdRequisiciones.Images.Add(CType(resources.GetObject("grdRequisiciones.Images1"), System.Drawing.Image))
        Me.grdRequisiciones.Location = New System.Drawing.Point(155, 99)
        Me.grdRequisiciones.Name = "grdRequisiciones"
        Me.grdRequisiciones.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdRequisiciones.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdRequisiciones.PreviewInfo.ZoomFactor = 75.0R
        Me.grdRequisiciones.PrintInfo.PageSettings = CType(resources.GetObject("grdRequisiciones.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdRequisiciones.Size = New System.Drawing.Size(781, 303)
        Me.grdRequisiciones.TabIndex = 24
        Me.grdRequisiciones.Text = "AzTrueDBGrid1"
        Me.grdRequisiciones.PropBag = resources.GetString("grdRequisiciones.PropBag")
        '
        'RequisicionesAdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 424)
        Me.Controls.Add(Me.grdRequisiciones)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "RequisicionesAdminForm"
        Me.Controls.SetChildIndex(Me.grdRequisiciones, 0)
        CType(Me.bsRequisiciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdRequisiciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bsRequisiciones As System.Windows.Forms.BindingSource
    Friend WithEvents imgLst As System.Windows.Forms.ImageList

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim ConfigFac As New Azteca.Kernel.Configuration.ConfigurationFacade
        Dim idDoc As Integer = CInt(ConfigFac.GetSystemParameter("Configuracion/Documentos/Tipos", "RequisicionCompra"))
        Me.DocumentFacade = New RequisicionFacade
        Me.DocumentTypeID = idDoc
        Me.DocumentBindingSource = bsRequisiciones
        LicenseModule = Kernel.Licensing.LicenseModule.Purchasing
    End Sub
    Friend WithEvents grdRequisiciones As Azteca.Windows.Controls.AZTrueDBGrid

End Class
