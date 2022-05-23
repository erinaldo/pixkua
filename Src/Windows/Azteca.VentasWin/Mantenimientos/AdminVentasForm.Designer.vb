<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminVentasForm
    Inherits Azteca.Windows.Forms.BusinessForms.DocumentAdminForm

    Protected Friend cmdUnloadXML As C1.Win.C1Command.C1Command
    Protected Friend cmdEnviarXML As C1.Win.C1Command.C1Command

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminVentasForm))
        Me.grdVentas = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsVentas = New System.Windows.Forms.BindingSource(Me.components)
        Me.dlgSaveXML = New System.Windows.Forms.SaveFileDialog()
        CType(Me.grdVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdVentas
        '
        Me.grdVentas.AlternatingRows = True
        Me.grdVentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdVentas.DataSource = Me.bsVentas
        Me.grdVentas.FilterBar = True
        Me.grdVentas.Images.Add(CType(resources.GetObject("grdVentas.Images"), System.Drawing.Image))
        Me.grdVentas.Images.Add(CType(resources.GetObject("grdVentas.Images1"), System.Drawing.Image))
        Me.grdVentas.Location = New System.Drawing.Point(180, 65)
        Me.grdVentas.Name = "grdVentas"
        Me.grdVentas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdVentas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdVentas.PreviewInfo.ZoomFactor = 75.0R
        Me.grdVentas.PrintInfo.PageSettings = CType(resources.GetObject("grdVentas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdVentas.RowHeight = 17
        Me.grdVentas.Size = New System.Drawing.Size(741, 319)
        Me.grdVentas.TabIndex = 42
        Me.grdVentas.Text = "AzTrueDBGrid1"
        Me.grdVentas.PropBag = resources.GetString("grdVentas.PropBag")
        '
        'dlgSaveXML
        '
        Me.dlgSaveXML.Filter = "Archivos xml|*.xml"
        Me.dlgSaveXML.Title = "Guardar archivo xml"
        '
        'AdminVentasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 406)
        Me.Controls.Add(Me.grdVentas)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "AdminVentasForm"
        Me.Text = "AdminVentasForm"
        Me.Controls.SetChildIndex(Me.grdVentas, 0)
        CType(Me.grdVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdVentas As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents bsVentas As System.Windows.Forms.BindingSource
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        LicenseModule = Kernel.Licensing.LicenseModule.Sales
        Me.DocumentFacade = New VentaFacade

        Dim ConfigFac As New Azteca.Kernel.Configuration.ConfigurationFacade
        Dim idDoc As Integer = CInt(ConfigFac.GetSystemParameter("Configuracion/Documentos/Tipos", "Venta"))
        Me.DocumentTypeID = idDoc
        Me.DocumentBindingSource = bsVentas


        'Agregar botón de Descarga de XML
        cmdUnloadXML = New C1.Win.C1Command.C1Command()
        cmdUnloadXML.Image = My.Resources.diskette_32
        cmdUnloadXML.Text = "Guardar XML"
        cmdUnloadXML.ToolTipText = "Descargar la factura en formato XML..."
        cmdUnloadXML.Enabled = False
        Dim btnUnloadXML As New C1.Win.C1Command.C1CommandLink(cmdUnloadXML)
        btnUnloadXML.ButtonLook = C1.Win.C1Command.ButtonLookFlags.TextAndImage
        btnUnloadXML.SortOrder = 15
        MainToolBar.CommandLinks.Add(btnUnloadXML)
        AddHandler cmdUnloadXML.Click, AddressOf btnUnloadXML_Click

        'Agregar botón de Envio de XML
        cmdEnviarXML = New C1.Win.C1Command.C1Command()
        cmdEnviarXML.Image = My.Resources.invoice_mail_32
        cmdEnviarXML.Text = "Enviar al Cliente"
        cmdEnviarXML.ToolTipText = "Enviar al cliente la factura..."
        cmdEnviarXML.Enabled = False
        Dim btnEnviarXML As New C1.Win.C1Command.C1CommandLink(cmdEnviarXML)
        btnEnviarXML.ButtonLook = C1.Win.C1Command.ButtonLookFlags.TextAndImage
        btnEnviarXML.SortOrder = 16
        MainToolBar.CommandLinks.Add(btnEnviarXML)
        AddHandler cmdEnviarXML.Click, AddressOf btnEnviarXML_Click

    End Sub
    Friend WithEvents dlgSaveXML As System.Windows.Forms.SaveFileDialog

End Class
