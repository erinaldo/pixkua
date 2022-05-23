<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComidaRapidaForm
    Inherits Azteca.Windows.Forms.BaseForm

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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Nueva Orden", 1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Corte", 0)
        Dim DesignerRectTracker1 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ComidaRapidaForm))
        Dim CBlendItems1 As Azteca.Windows.Controls.cBlendItems = New Azteca.Windows.Controls.cBlendItems()
        Dim DesignerRectTracker2 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim DesignerRectTracker3 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim CBlendItems2 As Azteca.Windows.Controls.cBlendItems = New Azteca.Windows.Controls.cBlendItems()
        Dim DesignerRectTracker4 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim DesignerRectTracker5 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim CBlendItems3 As Azteca.Windows.Controls.cBlendItems = New Azteca.Windows.Controls.cBlendItems()
        Dim DesignerRectTracker6 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim DesignerRectTracker7 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim CBlendItems4 As Azteca.Windows.Controls.cBlendItems = New Azteca.Windows.Controls.cBlendItems()
        Dim DesignerRectTracker8 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim DesignerRectTracker9 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim CBlendItems5 As Azteca.Windows.Controls.cBlendItems = New Azteca.Windows.Controls.cBlendItems()
        Dim DesignerRectTracker10 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Me.CiListView1 = New Azteca.Windows.Controls.CIListView()
        Me.pnlMenu = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha5 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha6 = New Azteca.Windows.ColorWithAlpha()
        Me.cmdAbrirCorte = New Azteca.Windows.Controls.ButtonPlus()
        Me.cmdCorteCaja = New Azteca.Windows.Controls.ButtonPlus()
        Me.cmdNuevaOrden = New Azteca.Windows.Controls.ButtonPlus()
        Me.pnlreturn = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha3 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha4 = New Azteca.Windows.ColorWithAlpha()
        Me.btnRegresar = New Azteca.Windows.Controls.ButtonPlus()
        Me.cmdCerrarCorte = New Azteca.Windows.Controls.ButtonPlus()
        Me.pnlAzteca = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha2 = New Azteca.Windows.ColorWithAlpha()
        Me.picAzteca = New Azteca.Windows.Controls.CIPicture()
        Me.pnlMenu.SuspendLayout()
        Me.pnlreturn.SuspendLayout()
        Me.pnlAzteca.SuspendLayout()
        CType(Me.picAzteca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CiListView1
        '
        Me.CiListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2})
        Me.CiListView1.Location = New System.Drawing.Point(1, 0)
        Me.CiListView1.Name = "CiListView1"
        Me.CiListView1.Size = New System.Drawing.Size(531, 97)
        Me.CiListView1.TabIndex = 0
        Me.CiListView1.UseCompatibleStateImageBehavior = False
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlMenu.Border = False
        Me.pnlMenu.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlMenu.Colors.Add(Me.ColorWithAlpha5)
        Me.pnlMenu.Colors.Add(Me.ColorWithAlpha6)
        Me.pnlMenu.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlMenu.Controls.Add(Me.cmdAbrirCorte)
        Me.pnlMenu.Controls.Add(Me.cmdCorteCaja)
        Me.pnlMenu.Controls.Add(Me.cmdNuevaOrden)
        Me.pnlMenu.Controls.Add(Me.pnlreturn)
        Me.pnlMenu.Controls.Add(Me.cmdCerrarCorte)
        Me.pnlMenu.CornerRadius = 20
        Me.pnlMenu.Corners = CType((((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight) _
            Or Azteca.Windows.Corner.BottomLeft) _
            Or Azteca.Windows.Corner.BottomRight), Azteca.Windows.Corner)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMenu.Gradient = True
        Me.pnlMenu.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlMenu.GradientOffset = 1.0!
        Me.pnlMenu.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlMenu.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlMenu.Grayscale = False
        Me.pnlMenu.Image = Nothing
        Me.pnlMenu.ImageAlpha = 75
        Me.pnlMenu.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlMenu.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlMenu.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlMenu.Location = New System.Drawing.Point(0, 100)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Rounded = True
        Me.pnlMenu.Size = New System.Drawing.Size(859, 387)
        Me.pnlMenu.TabIndex = 22
        '
        'ColorWithAlpha5
        '
        Me.ColorWithAlpha5.Alpha = 255
        Me.ColorWithAlpha5.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorWithAlpha5.Parent = Me.pnlMenu
        '
        'ColorWithAlpha6
        '
        Me.ColorWithAlpha6.Alpha = 255
        Me.ColorWithAlpha6.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorWithAlpha6.Parent = Me.pnlMenu
        '
        'cmdAbrirCorte
        '
        Me.cmdAbrirCorte.AutoLock = False
        Me.cmdAbrirCorte.BorderColor = System.Drawing.Color.Olive
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.cmdAbrirCorte.CenterPtTracker = DesignerRectTracker1
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))}
        CBlendItems1.iPoint = New Single() {0.0!, 1.0!}
        Me.cmdAbrirCorte.ColorFillBlend = CBlendItems1
        Me.cmdAbrirCorte.ColorFillSolid = System.Drawing.SystemColors.Control
        Me.cmdAbrirCorte.Corners.All = CType(20, Short)
        Me.cmdAbrirCorte.Corners.LowerLeft = CType(20, Short)
        Me.cmdAbrirCorte.Corners.LowerRight = CType(20, Short)
        Me.cmdAbrirCorte.Corners.UpperLeft = CType(20, Short)
        Me.cmdAbrirCorte.Corners.UpperRight = CType(20, Short)
        Me.cmdAbrirCorte.FillType = Azteca.Windows.Controls.ButtonPlus.eFillType.GradientLinear
        Me.cmdAbrirCorte.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdAbrirCorte.FocalPoints.CenterPtX = 0.5!
        Me.cmdAbrirCorte.FocalPoints.CenterPtY = 0.5!
        Me.cmdAbrirCorte.FocalPoints.FocusPtX = 0.0!
        Me.cmdAbrirCorte.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.cmdAbrirCorte.FocusPtTracker = DesignerRectTracker2
        Me.cmdAbrirCorte.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.cmdAbrirCorte.ForeColor = System.Drawing.Color.Olive
        Me.cmdAbrirCorte.Image = CType(resources.GetObject("cmdAbrirCorte.Image"), System.Drawing.Image)
        Me.cmdAbrirCorte.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAbrirCorte.ImageIndex = 0
        Me.cmdAbrirCorte.ImageSize = New System.Drawing.Size(256, 256)
        Me.cmdAbrirCorte.Location = New System.Drawing.Point(8, 9)
        Me.cmdAbrirCorte.Name = "cmdAbrirCorte"
        Me.cmdAbrirCorte.Shape = Azteca.Windows.Controls.ButtonPlus.eShape.Rectangle
        Me.cmdAbrirCorte.SideImage = Nothing
        Me.cmdAbrirCorte.SideImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAbrirCorte.SideImageSize = New System.Drawing.Size(48, 48)
        Me.cmdAbrirCorte.Size = New System.Drawing.Size(279, 278)
        Me.cmdAbrirCorte.TabIndex = 25
        Me.cmdAbrirCorte.Tag = "PackageInfo"
        Me.cmdAbrirCorte.Text = "Abrir Corte de Caja"
        Me.cmdAbrirCorte.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAbrirCorte.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.cmdAbrirCorte.TextMargin = New System.Windows.Forms.Padding(2)
        Me.cmdAbrirCorte.TextShadow = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdAbrirCorte.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.cmdAbrirCorte.UseMnemonic = True
        '
        'cmdCorteCaja
        '
        Me.cmdCorteCaja.AutoLock = False
        Me.cmdCorteCaja.BorderColor = System.Drawing.Color.Olive
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.cmdCorteCaja.CenterPtTracker = DesignerRectTracker3
        CBlendItems2.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))}
        CBlendItems2.iPoint = New Single() {0.0!, 1.0!}
        Me.cmdCorteCaja.ColorFillBlend = CBlendItems2
        Me.cmdCorteCaja.ColorFillSolid = System.Drawing.SystemColors.Control
        Me.cmdCorteCaja.Corners.All = CType(20, Short)
        Me.cmdCorteCaja.Corners.LowerLeft = CType(20, Short)
        Me.cmdCorteCaja.Corners.LowerRight = CType(20, Short)
        Me.cmdCorteCaja.Corners.UpperLeft = CType(20, Short)
        Me.cmdCorteCaja.Corners.UpperRight = CType(20, Short)
        Me.cmdCorteCaja.FillType = Azteca.Windows.Controls.ButtonPlus.eFillType.GradientLinear
        Me.cmdCorteCaja.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdCorteCaja.FocalPoints.CenterPtX = 0.5!
        Me.cmdCorteCaja.FocalPoints.CenterPtY = 0.5!
        Me.cmdCorteCaja.FocalPoints.FocusPtX = 0.0!
        Me.cmdCorteCaja.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.cmdCorteCaja.FocusPtTracker = DesignerRectTracker4
        Me.cmdCorteCaja.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.cmdCorteCaja.ForeColor = System.Drawing.Color.Olive
        Me.cmdCorteCaja.Image = CType(resources.GetObject("cmdCorteCaja.Image"), System.Drawing.Image)
        Me.cmdCorteCaja.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdCorteCaja.ImageIndex = 0
        Me.cmdCorteCaja.ImageSize = New System.Drawing.Size(256, 256)
        Me.cmdCorteCaja.Location = New System.Drawing.Point(578, 9)
        Me.cmdCorteCaja.Name = "cmdCorteCaja"
        Me.cmdCorteCaja.Shape = Azteca.Windows.Controls.ButtonPlus.eShape.Rectangle
        Me.cmdCorteCaja.SideImage = Nothing
        Me.cmdCorteCaja.SideImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCorteCaja.SideImageSize = New System.Drawing.Size(48, 48)
        Me.cmdCorteCaja.Size = New System.Drawing.Size(279, 278)
        Me.cmdCorteCaja.TabIndex = 24
        Me.cmdCorteCaja.Text = "Corte de Caja"
        Me.cmdCorteCaja.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCorteCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.cmdCorteCaja.TextMargin = New System.Windows.Forms.Padding(2)
        Me.cmdCorteCaja.TextShadow = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdCorteCaja.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.cmdCorteCaja.UseMnemonic = True
        '
        'cmdNuevaOrden
        '
        Me.cmdNuevaOrden.AutoLock = False
        Me.cmdNuevaOrden.BorderColor = System.Drawing.Color.Olive
        DesignerRectTracker5.IsActive = False
        DesignerRectTracker5.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker5.TrackerRectangle"), System.Drawing.RectangleF)
        Me.cmdNuevaOrden.CenterPtTracker = DesignerRectTracker5
        CBlendItems3.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))}
        CBlendItems3.iPoint = New Single() {0.0!, 1.0!}
        Me.cmdNuevaOrden.ColorFillBlend = CBlendItems3
        Me.cmdNuevaOrden.ColorFillSolid = System.Drawing.SystemColors.Control
        Me.cmdNuevaOrden.Corners.All = CType(20, Short)
        Me.cmdNuevaOrden.Corners.LowerLeft = CType(20, Short)
        Me.cmdNuevaOrden.Corners.LowerRight = CType(20, Short)
        Me.cmdNuevaOrden.Corners.UpperLeft = CType(20, Short)
        Me.cmdNuevaOrden.Corners.UpperRight = CType(20, Short)
        Me.cmdNuevaOrden.FillType = Azteca.Windows.Controls.ButtonPlus.eFillType.GradientLinear
        Me.cmdNuevaOrden.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdNuevaOrden.FocalPoints.CenterPtX = 0.5!
        Me.cmdNuevaOrden.FocalPoints.CenterPtY = 0.5!
        Me.cmdNuevaOrden.FocalPoints.FocusPtX = 0.0!
        Me.cmdNuevaOrden.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker6.IsActive = False
        DesignerRectTracker6.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker6.TrackerRectangle"), System.Drawing.RectangleF)
        Me.cmdNuevaOrden.FocusPtTracker = DesignerRectTracker6
        Me.cmdNuevaOrden.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.cmdNuevaOrden.ForeColor = System.Drawing.Color.Olive
        Me.cmdNuevaOrden.Image = CType(resources.GetObject("cmdNuevaOrden.Image"), System.Drawing.Image)
        Me.cmdNuevaOrden.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdNuevaOrden.ImageIndex = 0
        Me.cmdNuevaOrden.ImageSize = New System.Drawing.Size(256, 256)
        Me.cmdNuevaOrden.Location = New System.Drawing.Point(293, 9)
        Me.cmdNuevaOrden.Name = "cmdNuevaOrden"
        Me.cmdNuevaOrden.Shape = Azteca.Windows.Controls.ButtonPlus.eShape.Rectangle
        Me.cmdNuevaOrden.SideImage = Nothing
        Me.cmdNuevaOrden.SideImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNuevaOrden.SideImageSize = New System.Drawing.Size(48, 48)
        Me.cmdNuevaOrden.Size = New System.Drawing.Size(279, 278)
        Me.cmdNuevaOrden.TabIndex = 23
        Me.cmdNuevaOrden.Text = "Nueva Orden"
        Me.cmdNuevaOrden.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdNuevaOrden.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.cmdNuevaOrden.TextMargin = New System.Windows.Forms.Padding(2)
        Me.cmdNuevaOrden.TextShadow = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdNuevaOrden.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.cmdNuevaOrden.UseMnemonic = True
        '
        'pnlreturn
        '
        Me.pnlreturn.BackColor = System.Drawing.Color.Transparent
        Me.pnlreturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlreturn.Border = False
        Me.pnlreturn.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlreturn.Colors.Add(Me.ColorWithAlpha3)
        Me.pnlreturn.Colors.Add(Me.ColorWithAlpha4)
        Me.pnlreturn.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlreturn.Controls.Add(Me.btnRegresar)
        Me.pnlreturn.CornerRadius = 20
        Me.pnlreturn.Corners = CType((((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight) _
            Or Azteca.Windows.Corner.BottomLeft) _
            Or Azteca.Windows.Corner.BottomRight), Azteca.Windows.Corner)
        Me.pnlreturn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlreturn.Gradient = True
        Me.pnlreturn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlreturn.GradientOffset = 1.0!
        Me.pnlreturn.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlreturn.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlreturn.Grayscale = False
        Me.pnlreturn.Image = Nothing
        Me.pnlreturn.ImageAlpha = 75
        Me.pnlreturn.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlreturn.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlreturn.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlreturn.Location = New System.Drawing.Point(0, 302)
        Me.pnlreturn.Name = "pnlreturn"
        Me.pnlreturn.Rounded = True
        Me.pnlreturn.Size = New System.Drawing.Size(859, 85)
        Me.pnlreturn.TabIndex = 22
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorWithAlpha3.Parent = Me.pnlreturn
        '
        'ColorWithAlpha4
        '
        Me.ColorWithAlpha4.Alpha = 255
        Me.ColorWithAlpha4.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorWithAlpha4.Parent = Me.pnlreturn
        '
        'btnRegresar
        '
        Me.btnRegresar.AutoLock = False
        Me.btnRegresar.BorderColor = System.Drawing.Color.Olive
        DesignerRectTracker7.IsActive = False
        DesignerRectTracker7.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker7.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnRegresar.CenterPtTracker = DesignerRectTracker7
        CBlendItems4.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))}
        CBlendItems4.iPoint = New Single() {0.0!, 1.0!}
        Me.btnRegresar.ColorFillBlend = CBlendItems4
        Me.btnRegresar.ColorFillSolid = System.Drawing.SystemColors.Control
        Me.btnRegresar.Corners.All = CType(20, Short)
        Me.btnRegresar.Corners.LowerLeft = CType(20, Short)
        Me.btnRegresar.Corners.LowerRight = CType(20, Short)
        Me.btnRegresar.Corners.UpperLeft = CType(20, Short)
        Me.btnRegresar.Corners.UpperRight = CType(20, Short)
        Me.btnRegresar.FillType = Azteca.Windows.Controls.ButtonPlus.eFillType.GradientLinear
        Me.btnRegresar.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnRegresar.FocalPoints.CenterPtX = 0.5!
        Me.btnRegresar.FocalPoints.CenterPtY = 0.5!
        Me.btnRegresar.FocalPoints.FocusPtX = 0.0!
        Me.btnRegresar.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker8.IsActive = False
        DesignerRectTracker8.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker8.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnRegresar.FocusPtTracker = DesignerRectTracker8
        Me.btnRegresar.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegresar.ForeColor = System.Drawing.Color.Olive
        Me.btnRegresar.Image = Nothing
        Me.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegresar.ImageIndex = 0
        Me.btnRegresar.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnRegresar.Location = New System.Drawing.Point(291, 7)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Shape = Azteca.Windows.Controls.ButtonPlus.eShape.Rectangle
        Me.btnRegresar.SideImage = Nothing
        Me.btnRegresar.SideImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegresar.SideImageSize = New System.Drawing.Size(48, 48)
        Me.btnRegresar.Size = New System.Drawing.Size(279, 71)
        Me.btnRegresar.TabIndex = 24
        Me.btnRegresar.Text = "Regresar..."
        Me.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnRegresar.TextMargin = New System.Windows.Forms.Padding(2)
        Me.btnRegresar.TextShadow = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRegresar.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.btnRegresar.UseMnemonic = True
        '
        'cmdCerrarCorte
        '
        Me.cmdCerrarCorte.AutoLock = False
        Me.cmdCerrarCorte.BorderColor = System.Drawing.Color.Olive
        DesignerRectTracker9.IsActive = False
        DesignerRectTracker9.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker9.TrackerRectangle"), System.Drawing.RectangleF)
        Me.cmdCerrarCorte.CenterPtTracker = DesignerRectTracker9
        CBlendItems5.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(213, Byte), Integer))}
        CBlendItems5.iPoint = New Single() {0.0!, 1.0!}
        Me.cmdCerrarCorte.ColorFillBlend = CBlendItems5
        Me.cmdCerrarCorte.ColorFillSolid = System.Drawing.SystemColors.Control
        Me.cmdCerrarCorte.Corners.All = CType(20, Short)
        Me.cmdCerrarCorte.Corners.LowerLeft = CType(20, Short)
        Me.cmdCerrarCorte.Corners.LowerRight = CType(20, Short)
        Me.cmdCerrarCorte.Corners.UpperLeft = CType(20, Short)
        Me.cmdCerrarCorte.Corners.UpperRight = CType(20, Short)
        Me.cmdCerrarCorte.FillType = Azteca.Windows.Controls.ButtonPlus.eFillType.GradientLinear
        Me.cmdCerrarCorte.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdCerrarCorte.FocalPoints.CenterPtX = 0.5!
        Me.cmdCerrarCorte.FocalPoints.CenterPtY = 0.5!
        Me.cmdCerrarCorte.FocalPoints.FocusPtX = 0.0!
        Me.cmdCerrarCorte.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker10.IsActive = False
        DesignerRectTracker10.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker10.TrackerRectangle"), System.Drawing.RectangleF)
        Me.cmdCerrarCorte.FocusPtTracker = DesignerRectTracker10
        Me.cmdCerrarCorte.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.cmdCerrarCorte.ForeColor = System.Drawing.Color.Olive
        Me.cmdCerrarCorte.Image = CType(resources.GetObject("cmdCerrarCorte.Image"), System.Drawing.Image)
        Me.cmdCerrarCorte.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdCerrarCorte.ImageIndex = 0
        Me.cmdCerrarCorte.ImageSize = New System.Drawing.Size(256, 256)
        Me.cmdCerrarCorte.Location = New System.Drawing.Point(8, 9)
        Me.cmdCerrarCorte.Name = "cmdCerrarCorte"
        Me.cmdCerrarCorte.Shape = Azteca.Windows.Controls.ButtonPlus.eShape.Rectangle
        Me.cmdCerrarCorte.SideImage = Nothing
        Me.cmdCerrarCorte.SideImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCerrarCorte.SideImageSize = New System.Drawing.Size(48, 48)
        Me.cmdCerrarCorte.Size = New System.Drawing.Size(279, 278)
        Me.cmdCerrarCorte.TabIndex = 26
        Me.cmdCerrarCorte.Tag = "PackageInfo"
        Me.cmdCerrarCorte.Text = "Cerrar Corte de Caja"
        Me.cmdCerrarCorte.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCerrarCorte.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.cmdCerrarCorte.TextMargin = New System.Windows.Forms.Padding(2)
        Me.cmdCerrarCorte.TextShadow = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdCerrarCorte.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.cmdCerrarCorte.UseMnemonic = True
        Me.cmdCerrarCorte.Visible = False
        '
        'pnlAzteca
        '
        Me.pnlAzteca.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlAzteca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlAzteca.Border = False
        Me.pnlAzteca.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlAzteca.Colors.Add(Me.ColorWithAlpha1)
        Me.pnlAzteca.Colors.Add(Me.ColorWithAlpha2)
        Me.pnlAzteca.ContentPadding = New System.Windows.Forms.Padding(20, 5, 20, 8)
        Me.pnlAzteca.Controls.Add(Me.picAzteca)
        Me.pnlAzteca.CornerRadius = 30
        Me.pnlAzteca.Corners = CType((((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight) _
            Or Azteca.Windows.Corner.BottomLeft) _
            Or Azteca.Windows.Corner.BottomRight), Azteca.Windows.Corner)
        Me.pnlAzteca.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAzteca.Gradient = True
        Me.pnlAzteca.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlAzteca.GradientOffset = 1.0!
        Me.pnlAzteca.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlAzteca.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlAzteca.Grayscale = False
        Me.pnlAzteca.Image = Nothing
        Me.pnlAzteca.ImageAlpha = 75
        Me.pnlAzteca.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlAzteca.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlAzteca.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlAzteca.Location = New System.Drawing.Point(0, 0)
        Me.pnlAzteca.Name = "pnlAzteca"
        Me.pnlAzteca.Rounded = True
        Me.pnlAzteca.Size = New System.Drawing.Size(859, 100)
        Me.pnlAzteca.TabIndex = 21
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.White
        Me.ColorWithAlpha1.Parent = Me.pnlAzteca
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.White
        Me.ColorWithAlpha2.Parent = Me.pnlAzteca
        '
        'picAzteca
        '
        Me.picAzteca.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picAzteca.Image = CType(resources.GetObject("picAzteca.Image"), System.Drawing.Image)
        Me.picAzteca.Location = New System.Drawing.Point(261, 8)
        Me.picAzteca.Name = "picAzteca"
        Me.picAzteca.Size = New System.Drawing.Size(346, 86)
        Me.picAzteca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAzteca.TabIndex = 3
        Me.picAzteca.TabStop = False
        Me.picAzteca.UIName = Nothing
        '
        'ComidaRapidaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 487)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.pnlAzteca)
        Me.Controls.Add(Me.CiListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "ComidaRapidaForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Comida rápida ..."
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlreturn.ResumeLayout(False)
        Me.pnlAzteca.ResumeLayout(False)
        CType(Me.picAzteca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CiListView1 As Azteca.Windows.Controls.CIListView
    Friend WithEvents pnlMenu As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents pnlAzteca As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents pnlreturn As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents picAzteca As Azteca.Windows.Controls.CIPicture
    Friend WithEvents cmdCorteCaja As Azteca.Windows.Controls.ButtonPlus
    Friend WithEvents cmdNuevaOrden As Azteca.Windows.Controls.ButtonPlus
    Friend WithEvents cmdAbrirCorte As Azteca.Windows.Controls.ButtonPlus
    Friend WithEvents ColorWithAlpha3 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha4 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents btnRegresar As Azteca.Windows.Controls.ButtonPlus
    Friend WithEvents ColorWithAlpha5 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha6 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents cmdCerrarCorte As Azteca.Windows.Controls.ButtonPlus
End Class
