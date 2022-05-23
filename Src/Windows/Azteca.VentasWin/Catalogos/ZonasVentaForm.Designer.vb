<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ZonasVentaForm
    Inherits Azteca.Windows.Forms.BusinessForms.CatalogForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ZonasVentaForm))
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.grdArticulos = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsArticulos = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdServicios = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsServicios = New System.Windows.Forms.BindingSource(Me.components)
        Me.imlZonas = New System.Windows.Forms.ImageList(Me.components)
        Me.tabZonaVenta = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagGeneral = New C1.Win.C1Command.C1DockingTabPage()
        Me.pagArticulos = New C1.Win.C1Command.C1DockingTabPage()
        Me.tlbArticulos = New Azteca.Windows.Controls.AZToolBar()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdAgregarArt = New C1.Win.C1Command.C1Command()
        Me.cmdAgregarSvc = New C1.Win.C1Command.C1Command()
        Me.cmdCambiarPrecioArt = New C1.Win.C1Command.C1Command()
        Me.cmdCambiarPreciosSvc = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink3 = New C1.Win.C1Command.C1CommandLink()
        Me.pagServicios = New C1.Win.C1Command.C1DockingTabPage()
        Me.tlbServicios = New Azteca.Windows.Controls.AZToolBar()
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink4 = New C1.Win.C1Command.C1CommandLink()
        CType(Me.grdArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabZonaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabZonaVenta.SuspendLayout()
        Me.pagGeneral.SuspendLayout()
        Me.pagArticulos.SuspendLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagServicios.SuspendLayout()
        Me.SuspendLayout()
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(17, 23)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(47, 13)
        Me.CiLabel1.TabIndex = 21
        Me.CiLabel1.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(70, 20)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(225, 20)
        Me.txtNombre.TabIndex = 22
        Me.txtNombre.UIName = "Nombre"
        '
        'grdArticulos
        '
        Me.grdArticulos.AlternatingRows = True
        Me.grdArticulos.DataSource = Me.bsArticulos
        Me.grdArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdArticulos.FilterBar = True
        Me.grdArticulos.IDCatalogField = "IdArticuloStock"
        Me.grdArticulos.Images.Add(CType(resources.GetObject("grdArticulos.Images"), System.Drawing.Image))
        Me.grdArticulos.Location = New System.Drawing.Point(0, 34)
        Me.grdArticulos.Name = "grdArticulos"
        Me.grdArticulos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdArticulos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdArticulos.PreviewInfo.ZoomFactor = 75.0R
        Me.grdArticulos.PrintInfo.PageSettings = CType(resources.GetObject("grdArticulos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdArticulos.Size = New System.Drawing.Size(925, 364)
        Me.grdArticulos.TabIndex = 0
        Me.grdArticulos.PropBag = resources.GetString("grdArticulos.PropBag")
        '
        'grdServicios
        '
        Me.grdServicios.AlternatingRows = True
        Me.grdServicios.DataSource = Me.bsServicios
        Me.grdServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdServicios.FilterBar = True
        Me.grdServicios.IDCatalogField = "IdServicio"
        Me.grdServicios.Images.Add(CType(resources.GetObject("grdServicios.Images"), System.Drawing.Image))
        Me.grdServicios.Location = New System.Drawing.Point(0, 34)
        Me.grdServicios.Name = "grdServicios"
        Me.grdServicios.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdServicios.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdServicios.PreviewInfo.ZoomFactor = 75.0R
        Me.grdServicios.PrintInfo.PageSettings = CType(resources.GetObject("grdServicios.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdServicios.Size = New System.Drawing.Size(925, 364)
        Me.grdServicios.TabIndex = 0
        Me.grdServicios.PropBag = resources.GetString("grdServicios.PropBag")
        '
        'imlZonas
        '
        Me.imlZonas.ImageStream = CType(resources.GetObject("imlZonas.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlZonas.TransparentColor = System.Drawing.Color.Transparent
        Me.imlZonas.Images.SetKeyName(0, "General")
        Me.imlZonas.Images.SetKeyName(1, "Articulos")
        Me.imlZonas.Images.SetKeyName(2, "Servicios")
        '
        'tabZonaVenta
        '
        Me.tabZonaVenta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabZonaVenta.Controls.Add(Me.pagGeneral)
        Me.tabZonaVenta.Controls.Add(Me.pagArticulos)
        Me.tabZonaVenta.Controls.Add(Me.pagServicios)
        Me.tabZonaVenta.ImageList = Me.imlZonas
        Me.tabZonaVenta.Location = New System.Drawing.Point(16, 90)
        Me.tabZonaVenta.Name = "tabZonaVenta"
        Me.tabZonaVenta.SelectedIndex = 2
        Me.tabZonaVenta.Size = New System.Drawing.Size(927, 440)
        Me.tabZonaVenta.TabIndex = 23
        Me.tabZonaVenta.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabZonaVenta.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabZonaVenta.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagGeneral
        '
        Me.pagGeneral.Controls.Add(Me.CiLabel1)
        Me.pagGeneral.Controls.Add(Me.txtNombre)
        Me.pagGeneral.ImageIndex = 0
        Me.pagGeneral.Location = New System.Drawing.Point(1, 41)
        Me.pagGeneral.Name = "pagGeneral"
        Me.pagGeneral.Size = New System.Drawing.Size(925, 398)
        Me.pagGeneral.TabIndex = 0
        Me.pagGeneral.Text = "General"
        '
        'pagArticulos
        '
        Me.pagArticulos.Controls.Add(Me.grdArticulos)
        Me.pagArticulos.Controls.Add(Me.tlbArticulos)
        Me.pagArticulos.ImageIndex = 1
        Me.pagArticulos.Location = New System.Drawing.Point(1, 41)
        Me.pagArticulos.Name = "pagArticulos"
        Me.pagArticulos.Size = New System.Drawing.Size(925, 398)
        Me.pagArticulos.TabIndex = 1
        Me.pagArticulos.Text = "Artículos"
        '
        'tlbArticulos
        '
        Me.tlbArticulos.AccessibleName = "Tool Bar"
        Me.tlbArticulos.AutoSize = False
        Me.tlbArticulos.CommandHolder = Me.C1CommandHolder1
        Me.tlbArticulos.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink1, Me.C1CommandLink3})
        Me.tlbArticulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbArticulos.Location = New System.Drawing.Point(0, 0)
        Me.tlbArticulos.MinButtonSize = 32
        Me.tlbArticulos.Movable = False
        Me.tlbArticulos.Name = "tlbArticulos"
        Me.tlbArticulos.Size = New System.Drawing.Size(925, 34)
        Me.tlbArticulos.Text = "AzToolBar1"
        Me.tlbArticulos.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdAgregarArt)
        Me.C1CommandHolder1.Commands.Add(Me.cmdAgregarSvc)
        Me.C1CommandHolder1.Commands.Add(Me.cmdCambiarPrecioArt)
        Me.C1CommandHolder1.Commands.Add(Me.cmdCambiarPreciosSvc)
        Me.C1CommandHolder1.Owner = Me
        '
        'cmdAgregarArt
        '
        Me.cmdAgregarArt.Image = CType(resources.GetObject("cmdAgregarArt.Image"), System.Drawing.Image)
        Me.cmdAgregarArt.Name = "cmdAgregarArt"
        Me.cmdAgregarArt.ShortcutText = ""
        Me.cmdAgregarArt.Text = "Agregar Artículo"
        '
        'cmdAgregarSvc
        '
        Me.cmdAgregarSvc.Image = CType(resources.GetObject("cmdAgregarSvc.Image"), System.Drawing.Image)
        Me.cmdAgregarSvc.Name = "cmdAgregarSvc"
        Me.cmdAgregarSvc.ShortcutText = ""
        Me.cmdAgregarSvc.Text = "Agregar Servicio"
        '
        'cmdCambiarPrecioArt
        '
        Me.cmdCambiarPrecioArt.Image = CType(resources.GetObject("cmdCambiarPrecioArt.Image"), System.Drawing.Image)
        Me.cmdCambiarPrecioArt.Name = "cmdCambiarPrecioArt"
        Me.cmdCambiarPrecioArt.ShortcutText = ""
        Me.cmdCambiarPrecioArt.Text = "Cambiar Precios"
        Me.cmdCambiarPrecioArt.ToolTipText = "Cambio masivo de precios"
        '
        'cmdCambiarPreciosSvc
        '
        Me.cmdCambiarPreciosSvc.Image = CType(resources.GetObject("cmdCambiarPreciosSvc.Image"), System.Drawing.Image)
        Me.cmdCambiarPreciosSvc.Name = "cmdCambiarPreciosSvc"
        Me.cmdCambiarPreciosSvc.ShortcutText = ""
        Me.cmdCambiarPreciosSvc.Text = "Cambiar Precios"
        Me.cmdCambiarPreciosSvc.ToolTipText = "Cambio masivo de precios"
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink1.Command = Me.cmdAgregarArt
        '
        'C1CommandLink3
        '
        Me.C1CommandLink3.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink3.Command = Me.cmdCambiarPrecioArt
        Me.C1CommandLink3.SortOrder = 1
        '
        'pagServicios
        '
        Me.pagServicios.Controls.Add(Me.grdServicios)
        Me.pagServicios.Controls.Add(Me.tlbServicios)
        Me.pagServicios.ImageIndex = 2
        Me.pagServicios.Location = New System.Drawing.Point(1, 41)
        Me.pagServicios.Name = "pagServicios"
        Me.pagServicios.Size = New System.Drawing.Size(925, 398)
        Me.pagServicios.TabIndex = 2
        Me.pagServicios.Text = "Servicios"
        '
        'tlbServicios
        '
        Me.tlbServicios.AccessibleName = "Tool Bar"
        Me.tlbServicios.AutoSize = False
        Me.tlbServicios.CommandHolder = Me.C1CommandHolder1
        Me.tlbServicios.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink2, Me.C1CommandLink4})
        Me.tlbServicios.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbServicios.Location = New System.Drawing.Point(0, 0)
        Me.tlbServicios.MinButtonSize = 32
        Me.tlbServicios.Movable = False
        Me.tlbServicios.Name = "tlbServicios"
        Me.tlbServicios.Size = New System.Drawing.Size(925, 34)
        Me.tlbServicios.Text = "AzToolBar1"
        Me.tlbServicios.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'C1CommandLink2
        '
        Me.C1CommandLink2.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink2.Command = Me.cmdAgregarSvc
        '
        'C1CommandLink4
        '
        Me.C1CommandLink4.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink4.Command = Me.cmdCambiarPreciosSvc
        Me.C1CommandLink4.SortOrder = 1
        '
        'ZonasVentaForm
        '
        Me.AllowRecordNavigation = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 558)
        Me.Controls.Add(Me.tabZonaVenta)
        Me.Name = "ZonasVentaForm"
        Me.Text = "ZonasVentaForm"
        Me.Controls.SetChildIndex(Me.tabZonaVenta, 0)
        CType(Me.grdArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabZonaVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabZonaVenta.ResumeLayout(False)
        Me.pagGeneral.ResumeLayout(False)
        Me.pagGeneral.PerformLayout()
        Me.pagArticulos.ResumeLayout(False)
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagServicios.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New ZonaVentaFacade
    End Sub
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents grdArticulos As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents grdServicios As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents tabZonaVenta As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagGeneral As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagArticulos As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents tlbArticulos As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents cmdAgregarArt As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents pagServicios As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents tlbServicios As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdAgregarSvc As C1.Win.C1Command.C1Command
    Private WithEvents bsArticulos As System.Windows.Forms.BindingSource
    Private WithEvents imlZonas As System.Windows.Forms.ImageList
    Private WithEvents bsServicios As System.Windows.Forms.BindingSource
    Friend WithEvents cmdCambiarPrecioArt As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink3 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdCambiarPreciosSvc As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink4 As C1.Win.C1Command.C1CommandLink
End Class
